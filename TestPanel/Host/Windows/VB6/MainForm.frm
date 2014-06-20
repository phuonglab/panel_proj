VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmMain 
   Caption         =   "Test Panel"
   ClientHeight    =   3240
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9585
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3240
   ScaleWidth      =   9585
   StartUpPosition =   3  'Windows Default
   Visible         =   0   'False
   Begin VB.CheckBox chkP0B0 
      Caption         =   "0"
      Enabled         =   0   'False
      Height          =   255
      Left            =   1560
      Style           =   1  'Graphical
      TabIndex        =   21
      Top             =   2400
      Width           =   375
   End
   Begin VB.CheckBox chkP0B1 
      Caption         =   "1"
      Enabled         =   0   'False
      Height          =   255
      Left            =   1200
      Style           =   1  'Graphical
      TabIndex        =   20
      Top             =   2400
      Width           =   375
   End
   Begin VB.CheckBox chkP0B2 
      Caption         =   "2"
      Enabled         =   0   'False
      Height          =   255
      Left            =   840
      Style           =   1  'Graphical
      TabIndex        =   19
      Top             =   2400
      Width           =   375
   End
   Begin VB.CheckBox chkP0B3 
      Caption         =   "3"
      Enabled         =   0   'False
      Height          =   255
      Left            =   480
      Style           =   1  'Graphical
      TabIndex        =   18
      Top             =   2400
      Width           =   375
   End
   Begin VB.Timer Timer1 
      Interval        =   100
      Left            =   240
      Top             =   3000
   End
   Begin VB.Frame Frame6 
      Caption         =   "Analog2"
      Height          =   975
      Left            =   4440
      TabIndex        =   10
      Top             =   1920
      Width           =   4455
      Begin MSComctlLib.ProgressBar pbAnalog2 
         Height          =   255
         Left            =   240
         TabIndex        =   26
         Top             =   240
         Width           =   3975
         _ExtentX        =   7011
         _ExtentY        =   450
         _Version        =   393216
         Appearance      =   1
         Max             =   255
         Scrolling       =   1
      End
      Begin VB.Label Label4 
         Caption         =   "Temperature"
         Height          =   255
         Left            =   240
         TabIndex        =   24
         Top             =   600
         Width           =   1095
      End
      Begin VB.Label lblAnalog2 
         Caption         =   "0"
         Height          =   255
         Left            =   1320
         TabIndex        =   12
         Top             =   600
         Width           =   975
      End
   End
   Begin VB.Frame Frame4 
      Caption         =   "Port 1"
      Height          =   1095
      Left            =   2280
      TabIndex        =   8
      Top             =   1800
      Width           =   1935
      Begin VB.CheckBox chkP1B3 
         Caption         =   "3"
         Height          =   255
         Left            =   360
         Style           =   1  'Graphical
         TabIndex        =   17
         Top             =   600
         Width           =   375
      End
      Begin VB.CheckBox chkP1B2 
         Caption         =   "2"
         Height          =   255
         Left            =   720
         Style           =   1  'Graphical
         TabIndex        =   16
         Top             =   600
         Width           =   375
      End
      Begin VB.CheckBox chkP1B1 
         Caption         =   "1"
         Height          =   255
         Left            =   1080
         Style           =   1  'Graphical
         TabIndex        =   14
         Top             =   600
         Width           =   375
      End
      Begin VB.CheckBox chkP1B0 
         Caption         =   "0"
         Height          =   255
         Left            =   1440
         Style           =   1  'Graphical
         TabIndex        =   13
         Top             =   600
         Width           =   375
      End
      Begin VB.Label Label1 
         Caption         =   "Bits (Press to Set)"
         Height          =   255
         Left            =   360
         TabIndex        =   15
         Top             =   240
         Width           =   1455
      End
   End
   Begin VB.Frame Frame3 
      Caption         =   "LEDs"
      Height          =   1095
      Left            =   2280
      TabIndex        =   3
      Top             =   240
      Width           =   1935
      Begin VB.CheckBox chkLED2 
         Caption         =   "LED 2"
         Height          =   255
         Left            =   480
         TabIndex        =   7
         Top             =   720
         Width           =   975
      End
      Begin VB.CheckBox chkLED1 
         Caption         =   "LED 1"
         Height          =   255
         Left            =   480
         TabIndex        =   6
         Top             =   360
         Width           =   1215
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Port 0"
      Height          =   1095
      Left            =   240
      TabIndex        =   2
      Top             =   1800
      Width           =   1815
      Begin VB.Label Label2 
         Caption         =   "Bits"
         Height          =   255
         Left            =   240
         TabIndex        =   22
         Top             =   240
         Width           =   855
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Buttons"
      Height          =   1095
      Left            =   240
      TabIndex        =   1
      Top             =   240
      Width           =   1815
      Begin VB.Shape cButton2 
         FillColor       =   &H00008000&
         Height          =   255
         Left            =   120
         Shape           =   3  'Circle
         Top             =   720
         Width           =   375
      End
      Begin VB.Shape cButton1 
         FillColor       =   &H00008000&
         Height          =   255
         Left            =   120
         Shape           =   3  'Circle
         Top             =   240
         Width           =   375
      End
      Begin VB.Label lblButton2 
         Caption         =   "Button 2"
         Height          =   255
         Left            =   600
         TabIndex        =   5
         Top             =   720
         Width           =   1095
      End
      Begin VB.Label lblButton1 
         Caption         =   "Button 1"
         Height          =   255
         Left            =   600
         TabIndex        =   4
         Top             =   240
         Width           =   1095
      End
   End
   Begin VB.CommandButton cmdExit 
      Caption         =   "Exit"
      Height          =   495
      Left            =   8040
      TabIndex        =   0
      Top             =   240
      Width           =   1215
   End
   Begin VB.Frame Frame5 
      Caption         =   "Analog1"
      Height          =   975
      Left            =   4440
      TabIndex        =   9
      Top             =   840
      Width           =   4455
      Begin MSComctlLib.ProgressBar pbAnalog1 
         Height          =   255
         Left            =   240
         TabIndex        =   25
         Top             =   240
         Width           =   3975
         _ExtentX        =   7011
         _ExtentY        =   450
         _Version        =   393216
         Appearance      =   1
         Max             =   255
         Scrolling       =   1
      End
      Begin VB.Label Label3 
         Caption         =   "Potentiometer"
         Height          =   255
         Left            =   240
         TabIndex        =   23
         Top             =   600
         Width           =   1095
      End
      Begin VB.Label lblAnalog1 
         Caption         =   "0"
         Height          =   255
         Left            =   1320
         TabIndex        =   11
         Top             =   600
         Width           =   975
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub cmdExit_Click()
    
    'close use device and exit program
    SI_Close (hUSBDevice)
    End
    
End Sub

Private Sub Form_Unload(Cancel As Integer)

    'close usb device and exit program
    SI_Close (hUSBDevice)
    End
    
End Sub

Private Sub Timer1_Timer()

    'on each timer tick we will send out the data from the
    'program to the board and set the appropriate values to
    'the board then, we will read in the data from the board
    'and set the appropriate values to the program
    
    'set the first two bytes of the array to the led values
    IOBuf(0) = chkLED1.Value
    IOBuf(1) = chkLED2.Value

    Dim B0, B1, B2, B3
    Dim P1
    
    'bits for each of the bits represented in port 1
    B0 = chkP1B0.Value
    B1 = chkP1B1.Value * 2   'shift left 1
    B2 = chkP1B2.Value * 4   'shift left 2
    B3 = chkP1B3.Value * 8   'shift left 3
    P1 = (B0 + B1 + B2 + B3) 'or all of the bits together to get the byte value
    P1 = P1 And &HF          'and then with &h0F to get the low 4 bits
    IOBuf(2) = P1            'set the third element to this value to send out

    Dim BytesSucceed As Long
    Dim BytesWriteRequest As Long
    Dim BytesReadRequest As Long

    BytesSucceed = 0
    BytesWriteRequest = IOBufSize - 4
    BytesReadRequest = IOBufSize - 4
    
    'send data to the board
    Status = SI_Write(hUSBDevice, IOBuf(0), BytesWriteRequest, BytesSucceed, 0)
    
    If (BytesSucceed <> BytesWriteRequest) Or (Status <> SI_SUCCESS) Then
        MsgBox "Error writing to USB. Wrote " + Str(BytesSucceed) + " of " + Str(BytesWriteRequest) + " bytes. Application is aborting. Reset hardware and try again."
        End
    End If

    'clear out the iobuf and bytessucceed for the next read
    BytesSucceed = 0
    Call MemSet(IOBuf, 0, IOBufSize)

    'read data from the board
    Status = SI_Read(hUSBDevice, IOBuf(0), BytesReadRequest, BytesSucceed, 0)
    
    If (BytesSucceed <> BytesReadRequest) Or (Status <> SI_SUCCESS) Then
        MsgBox "Error writing to USB. Read " + Str(BytesSucceed) + " of " + Str(BytesReadRequest) + " bytes. Application is aborting. Reset hardware and try again."
        End
    End If
        
    'the first two elements have the button status
    If IOBuf(0) Then
        cButton1.FillStyle = 0
    Else
        cButton1.FillStyle = 1
    End If
    If IOBuf(1) Then
        cButton2.FillStyle = 0
    Else
        cButton2.FillStyle = 1
    End If
    
    Dim P0
    P0 = IOBuf(2) And &HF            'and the value with &h0F to get the low 4 bits
    chkP0B0.Value = P0 And &H1       'check first bit by anding with 1, and if it is true, set the check box
    chkP0B1.Value = (P0 \ 2) And &H1 'shift right 1, and check if its true, set the check box
    chkP0B2.Value = (P0 \ 4) And &H1 'shift right 2, and check if its true, set the check box
    chkP0B3.Value = (P0 \ 8) And &H1 'shift right 3, and check if its true, set the check box
    
    lblAnalog1.Caption = IOBuf(3) 'set each analog label to the corresponding value
    lblAnalog2.Caption = IOBuf(4)
    pbAnalog1.Value = IOBuf(3)    'set each analog graphic as well
    pbAnalog2.Value = IOBuf(4)
    
End Sub
