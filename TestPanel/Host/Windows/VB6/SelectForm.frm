VERSION 5.00
Begin VB.Form frmSelect 
   Caption         =   "Select Device"
   ClientHeight    =   1155
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6150
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1155
   ScaleWidth      =   6150
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdCancel 
      Caption         =   "Cancel"
      Height          =   375
      Left            =   3360
      TabIndex        =   3
      Top             =   720
      Width           =   1095
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Height          =   375
      Left            =   1440
      TabIndex        =   2
      Top             =   720
      Width           =   1095
   End
   Begin VB.ComboBox cmbDevice 
      Height          =   315
      Left            =   960
      TabIndex        =   0
      Top             =   240
      Width           =   4935
   End
   Begin VB.Label Label1 
      Caption         =   "Device:"
      Height          =   255
      Left            =   240
      TabIndex        =   1
      Top             =   240
      Width           =   735
   End
End
Attribute VB_Name = "frmSelect"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCancel_Click()

    Unload frmMain
    Unload frmSelect
    End
    
End Sub

Private Sub cmdOK_Click()

    'when ok is clicked, set the timeouts on the device
    'and open the device
    Status = SI_SetTimeouts(10000, 10000)
    Status = SI_Open(cmbDevice.ListIndex, hUSBDevice)
    
    If Status <> SI_SUCCESS Then
        frmSelect.Visible = False
        MsgBox "Error opening device: " + cmbDevice.Text + ". Application is aborting. Reset hardware and try again."
        End
    End If
    
    frmSelect.Visible = False
    frmMain.Visible = True
    
End Sub

Private Sub Form_Load()
        
    hUSBDevice = INVALID_HANDLE_VALUE
    
    'get the list of devices that are connected
    If Not GetDeviceList Then
        frmSelect.Visible = False
        MsgBox "Error finding USB device. Aborting application."
        End
    End If
    
End Sub

Private Function GetDeviceList() As Boolean

    'device number, device string, and temp var newdevstring
    Dim DevNum As Long
    Dim DevStr(SI_MAX_DEVICE_STRLEN) As Byte
    Dim NewDevStr As String
    Dim i As Integer
    
    'clear the combo box
    cmbDevice.Clear
    
    'determine how many devices are hooked up
    Status = SI_GetNumDevices(DevNum)
    
    'if we find a device, obtain the name of each device
    'and convert the string to a vb string to add to the
    'combo list
    If Status = SI_SUCCESS Then
        For i = 0 To (DevNum - 1)
            Status = SI_GetProductString(i, DevStr(0), SI_RETURN_SERIAL_NUMBER)
            NewDevStr = ConvertToVBString(DevStr)
            cmbDevice.AddItem NewDevStr, i
        Next
        
        cmbDevice.ListIndex = 0 'then set combo list to first item
        GetDeviceList = True    'return true since we found hardware
    Else
        cmbDevice.ListIndex = -1 'otherwise set list to -1
        GetDeviceList = False    'return false and close since we didnt
    End If                       'find hardware

End Function
