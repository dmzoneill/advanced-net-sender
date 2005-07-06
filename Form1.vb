Imports Microsoft.Win32
Imports Microsoft.Win32.Registry
Imports System.runtime.InteropServices

Public Class Form1
    Inherits System.Windows.Forms.Form
    Public Class NetSend
        Public Function Sende(ByVal SendeAn As String, _
          ByVal SendeNachricht As String) As Integer

            Return NetMessageBufferSend(Nothing, SendeAn, Nothing, _
              SendeNachricht, SendeNachricht.Length * 2 + 2)
        End Function

        <DllImportAttribute("Netapi32", CharSet:=CharSet.Unicode)> _
        Public Shared Function NetMessageBufferSend(ByVal servername As String, _
          ByVal msgname As String, ByVal fromname As String, ByVal buf As String, _
          ByVal buflen As Integer) As Integer
        End Function
    End Class
#Region " Vom Windows Form Designer generierter Code "

    Public Sub New()
        MyBase.New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Initialisierungen nach dem Aufruf InitializeComponent() hinzufügen

    End Sub

    ' Die Form überschreibt den Löschvorgang der Basisklasse, um Komponenten zu bereinigen.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Für Windows Form-Designer erforderlich
    Private components As System.ComponentModel.IContainer

    'HINWEIS: Die folgende Prozedur ist für den Windows Form-Designer erforderlich
    'Sie kann mit dem Windows Form-Designer modifiziert werden.
    'Verwenden Sie nicht den Code-Editor zur Bearbeitung.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtsender As System.Windows.Forms.TextBox
    Friend WithEvents txtnachricht As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtanzahl As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkcheck As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtsender = New System.Windows.Forms.TextBox
        Me.txtnachricht = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtanzahl = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkcheck = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empfänger:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nachricht:"
        '
        'txtsender
        '
        Me.txtsender.BackColor = System.Drawing.Color.Silver
        Me.txtsender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsender.Location = New System.Drawing.Point(80, 16)
        Me.txtsender.Name = "txtsender"
        Me.txtsender.Size = New System.Drawing.Size(272, 20)
        Me.txtsender.TabIndex = 2
        Me.txtsender.Text = ""
        '
        'txtnachricht
        '
        Me.txtnachricht.BackColor = System.Drawing.Color.Silver
        Me.txtnachricht.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnachricht.Location = New System.Drawing.Point(80, 64)
        Me.txtnachricht.Multiline = True
        Me.txtnachricht.Name = "txtnachricht"
        Me.txtnachricht.Size = New System.Drawing.Size(272, 192)
        Me.txtnachricht.TabIndex = 3
        Me.txtnachricht.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(368, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Optionen"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(368, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Info"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(368, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 24)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Senden"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(372, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "{ schließen }"
        '
        'txtanzahl
        '
        Me.txtanzahl.BackColor = System.Drawing.Color.Silver
        Me.txtanzahl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtanzahl.ForeColor = System.Drawing.Color.Black
        Me.txtanzahl.Location = New System.Drawing.Point(408, 240)
        Me.txtanzahl.MaxLength = 2
        Me.txtanzahl.Name = "txtanzahl"
        Me.txtanzahl.Size = New System.Drawing.Size(24, 20)
        Me.txtanzahl.TabIndex = 8
        Me.txtanzahl.Text = "1"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(360, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Anzahl:"
        '
        'chkcheck
        '
        Me.chkcheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkcheck.Location = New System.Drawing.Point(80, 264)
        Me.chkcheck.Name = "chkcheck"
        Me.chkcheck.Size = New System.Drawing.Size(176, 16)
        Me.chkcheck.TabIndex = 10
        Me.chkcheck.Text = "Benachrichtigung"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(442, 296)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkcheck)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtanzahl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnachricht)
        Me.Controls.Add(Me.txtsender)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "                                                          Advanced Net Sender"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim reg As RegistryKey
    Public Sub check_registry()
        reg = LocalMachine.OpenSubKey("Software", True)
        If reg.OpenSubKey("Adv Sender", True) Is Nothing Then
            reg.CreateSubKey("Adv Sender")
        Else
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        check_registry()
        reg = LocalMachine.OpenSubKey("Software\Adv Sender", True)
        On Error Resume Next
        If reg.GetValue("Checkit") = "true" Then
            Me.chkcheck.Checked = True
        Else
            Me.chkcheck.Checked = False
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        write_registry()
        Dim frm2 As New Form2
        frm2.frm = Me
        frm2.ShowDialog()

    End Sub

    Public Sub write_registry()
        reg = LocalMachine.OpenSubKey("Software\Adv Sender", True)
        reg.SetValue("top", Me.Top)
        reg.SetValue("left", Me.Left)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("Um an gespeicherte Computernamen Nachrichten zu senden, müssen sie mit einem Slash beginnen" & vbCrLf & _
        "z.B.: /localhost")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        reg = LocalMachine.OpenSubKey("Software\Adv Sender\computers", True)
        Dim sAdresse As String
        Dim Message As New NetSend
        Dim erg As Integer
        If Me.txtsender.Text.StartsWith("/") Then
            sAdresse = Me.txtsender.Text.Replace("/", "")
            ' Nachricht übermiiteln
            If Me.txtanzahl.Text <= "1" Then
                erg = Message.Sende(reg.GetValue(sAdresse), Me.txtnachricht.Text)
            Else
                Dim i As Integer
                i = 0
                Do Until i = Me.txtanzahl.Text
                    erg = Message.Sende(reg.GetValue(sAdresse), Me.txtnachricht.Text)
                    i = i + 1
                Loop
                
            End If
        Else
            If Me.txtanzahl.Text <= "1" Then
                erg = Message.Sende(Me.txtsender.Text, Me.txtnachricht.Text)
            Else
                Dim i As Integer
                i = 0
                Do Until i = Me.txtanzahl.Text
                    erg = Message.Sende(Me.txtsender.Text, Me.txtnachricht.Text)
                    i = i + 1
                Loop
            End If

        End If

        ' Checken ob nachricht verschickt wurde!
        If Me.chkcheck.Checked = True Then
            If erg = 0 Then
                MessageBox.Show("Nachricht erfolgreich übermittelt", "Übermittlung OK", _
                  MessageBoxButtons.OK, MessageBoxIcon.None)
            Else
                MessageBox.Show("Fehler: " & erg, "Keine Nachricht gesendet!", _
                  MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else

        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
        End
    End Sub

    Private Sub chkcheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcheck.CheckedChanged
        reg = LocalMachine.OpenSubKey("Software\Adv Sender", True)
        If Me.chkcheck.Checked = True Then
            reg.SetValue("Checkit", "true")
        Else
            reg.SetValue("Checkit", "false")
        End If
    End Sub
End Class
