Imports Microsoft.Win32.Registry
Imports Microsoft.Win32
Public Class Form3
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents txtalias As System.Windows.Forms.TextBox
    Friend WithEvents txtcomputer As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdsave = New System.Windows.Forms.Button
        Me.txtalias = New System.Windows.Forms.TextBox
        Me.txtcomputer = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alias:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IP | Computername:"
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.Silver
        Me.cmdsave.Location = New System.Drawing.Point(304, 56)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(80, 24)
        Me.cmdsave.TabIndex = 2
        Me.cmdsave.Text = "Speichern"
        '
        'txtalias
        '
        Me.txtalias.Location = New System.Drawing.Point(120, 8)
        Me.txtalias.Name = "txtalias"
        Me.txtalias.Size = New System.Drawing.Size(224, 20)
        Me.txtalias.TabIndex = 3
        Me.txtalias.Text = ""
        '
        'txtcomputer
        '
        Me.txtcomputer.Location = New System.Drawing.Point(120, 32)
        Me.txtcomputer.Name = "txtcomputer"
        Me.txtcomputer.Size = New System.Drawing.Size(224, 20)
        Me.txtcomputer.TabIndex = 4
        Me.txtcomputer.Text = ""
        '
        'Form3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(384, 80)
        Me.Controls.Add(Me.txtcomputer)
        Me.Controls.Add(Me.txtalias)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.ShowInTaskbar = False
        Me.Text = "Hinzufügen >>"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim reg As RegistryKey
    Public frm2 As Form2
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        reg = LocalMachine.OpenSubKey("software\Adv Sender\computers", True)
        reg.SetValue(Me.txtalias.Text, Me.txtcomputer.Text)
        frm2.check_computers()
        Me.Close()
    End Sub
End Class
