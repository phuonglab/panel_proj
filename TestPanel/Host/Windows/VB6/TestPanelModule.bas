Attribute VB_Name = "modTestPanel"

Option Explicit

' Declare statements for all the functions in the SiF32xUSb DLL
' NOTE: These statements assume that the DLL file is located in
'       the same directory as this project.
'       If you change the location of the DLL, be sure to change the location
'       in the declare statements also.
Public Declare Function SI_GetNumDevices Lib "SiUSBXp.dll" (ByRef lpwdNumDevices As Long) As Integer
Public Declare Function SI_GetProductString Lib "SiUSBXp.dll" (ByVal dwDeviceNum As Long, ByRef lpvDeviceString As Byte, ByVal dwFlags As Long) As Integer
Public Declare Function SI_Open Lib "SiUSBXp.dll" (ByVal dwDevice As Long, ByRef cyHandle As Long) As Integer
Public Declare Function SI_Close Lib "SiUSBXp.dll" (ByVal cyHandle As Long) As Integer
Public Declare Function SI_Read Lib "SiUSBXp.dll" (ByVal cyHandle As Long, ByRef lpBuffer As Byte, ByVal dwBytesToRead As Long, ByRef lpdwBytesReturned As Long, ByVal lpOverlapped As Long) As Integer
Public Declare Function SI_Write Lib "SiUSBXp.dll" (ByVal cyHandle As Long, ByRef lpBuffer As Byte, ByVal dwBytesToWrite As Long, ByRef lpdwBytesWritten As Long, ByVal lpOverlapped As Long) As Integer
Public Declare Function SI_SetTimeouts Lib "SiUSBXp.dll" (ByVal dwReadTimeout As Long, ByVal dwWriteTimeout As Long) As Integer
Public Declare Function SI_GetTimeouts Lib "SiUSBXp.dll" (ByRef lpdwReadTimeout As Long, ByRef lpdwWriteTimeout As Long) As Integer
Public Declare Function SI_CheckRXQueue Lib "SiUSBXp.dll" (ByVal cyHandle As Long, ByRef lpdwNumBytesInQueue As Long, ByRef lpdwQueueStatus As Long) As Integer

'Masks for the serial number and description
Public Const SI_RETURN_SERIAL_NUMBER = &H0
Public Const SI_RETURN_DESCRIPTION = &H1

'Masks for return values from the device
Public Const SI_SUCCESS = &H0
Public Const SI_DEVICE_NOT_FOUND = &HFF
Public Const SI_INVALID_HANDLE = &H1
Public Const SI_READ_ERROR = &H2
Public Const SI_RX_QUEUE_NOT_READY = &H3
Public Const SI_WRITE_ERROR = &H4
Public Const SI_RESET_ERROR = &H5
Public Const SI_INVALID_BUFFER = &H6
Public Const SI_INVALID_REQUEST_LENGTH = &H7
Public Const SI_DEVICE_IO_FAILED = &H8

Public Const SI_QUEUE_NO_OVERRUN = &H0
Public Const SI_QUEUE_OVERRUN = &H1
Public Const SI_QUEUE_READY = &H2

Public Const SI_MAX_DEVICE_STRLEN = 256
Public Const SI_MAX_READ_SIZE = 64
Public Const SI_MAX_WRITE_SIZE = 64

Public Const INVALID_HANDLE_VALUE = &H1

Public Const MAX_PACKET_SIZE = &H40
Public Const MAX_WRITE_PKTS = &H8

Public Const FT_READ_MSG = &H0
Public Const FT_WRITE_MSG = &H1
Public Const FT_READ_ACK = &H2
Public Const FT_MSG_SIZE = &H3

'Variables used within the project
Global hUSBDevice  'global handle that is set when connected with the usb device
Global Status      'status, value to set when communicating with the board to determine success
Global TempString  'tempstring, contains the value of the file when performing a read

Public Const IOBufSize = 12
Global IOBuf(IOBufSize) As Byte 'io buffer; bits are defined as follows:
'IOBuf(0) = LED1
'IOBuf(1) = LED2
'IOBuf(2) = Port
'IOBuf(3) = Analog1
'IOBuf(4) = Analog2
'IOBuf(5,6,7) = Unused
'IOBuf(8,9,10,11) = Number Of Interrupts

Public Function ConvertToVBString(Str)

    Dim NewString As String
    Dim i As Integer
    
    'for the received string array, loop until we get
    'a 0 char, or until the max length has been obtained
    'then add the ascii char value to a vb string
    i = 0
    Do While (i < SI_MAX_DEVICE_STRLEN) And (Str(i) <> 0)
        NewString = NewString + Chr$(Str(i))
        i = i + 1
    Loop
    
    ConvertToVBString = NewString
    
End Function


Public Function DeviceWrite(Buffer() As Byte, dwSize As Long, lpdwBytesWritten As Long, dwTimeout As Long) As Boolean
    Dim TmpReadTO As Long
    Dim TmpWriteTO As Long
    Dim Stat As Integer
    Dim WriteStatus As Integer
    
    'save timeout values to replace after the write
    Stat = SI_GetTimeouts(TmpReadTO, TmpWriteTO)
    Stat = SI_SetTimeouts(0, dwTimeout)
    
    WriteStatus = SI_Write(hUSBDevice, Buffer(0), dwSize, lpdwBytesWritten, 0)
    
    'replace timeouts
    Stat = SI_SetTimeouts(TmpReadTO, TmpWriteTO)
    
    If WriteStatus = SI_SUCCESS Then
        DeviceWrite = True
    Else
        DeviceWrite = False
    End If
  
End Function



Public Function DeviceRead(Buffer() As Byte, dwSize As Long, lpdwBytesRead As Long, dwTimeout As Long) As Boolean

    Dim TmpReadTO As Long
    Dim TmpWriteTO As Long
    Dim Stat As Integer
    Dim ReadStatus As Integer
    Dim QueueStatus As Long
    Dim BytesInQueue As Long
    Dim QueueStatNAndQueueReady As Long
    Stat = SI_SUCCESS
    QueueStatus = SI_QUEUE_NO_OVERRUN
    BytesInQueue = 0
    
    'save the timeout values to replace after the read
    Stat = SI_GetTimeouts(TmpReadTO, TmpWriteTO)
    
    If dwTimeout = 0 Then
        'wait forever until queue ready
        'QueueStatNAndQueueReady = Not (QueueStatus And SI_QUEUE_READY)
        Do While (Stat = SI_SUCCESS) And (QueueStatus <> SI_QUEUE_READY)
            Stat = SI_CheckRXQueue(hUSBDevice, BytesInQueue, QueueStatus)
            'QueueStatNAndQueueReady = Not (QueueStatus And SI_QUEUE_READY)
        Loop
    Else
        'set a timeout for the read
        Stat = SI_SetTimeouts(dwTimeout, 0)
    End If

    'read in the ack
    If Stat = SI_SUCCESS Then
        ReadStatus = SI_Read(hUSBDevice, Buffer(0), dwSize, lpdwBytesRead, 0)
    End If
    
    'restore timeouts
    Stat = SI_SetTimeouts(TmpReadTO, TmpWriteTO)

    If ReadStatus = SI_SUCCESS Then
        DeviceRead = True
    Else
        DeviceRead = False
    End If
    
End Function

Public Sub MemSet(Buffer() As Byte, Value As Byte, Amount As Long)
    
    'this function sets all elements of on array to 0
    Dim i
    
    For i = 0 To (Amount - 1)
        Buffer(i) = Value
    Next
    
End Sub
