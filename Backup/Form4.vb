Imports Microsoft.Win32
Imports Microsoft.Win32.Registry
Public Class Form4
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
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcomputer As System.Windows.Forms.TextBox
    Friend WithEvents cmbalias As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdsave = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbalias = New System.Windows.Forms.ComboBox
        Me.txtcomputer = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(304, 56)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(80, 24)
        Me.cmdsave.TabIndex = 0
        Me.cmdsave.Text = "Speichern"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "IP | Computername:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Alias:"
        '
        'cmbalias
        '
        Me.cmbalias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbalias.Location = New System.Drawing.Point(120, 8)
        Me.cmbalias.Name = "cmbalias"
        Me.cmbalias.Size = New System.Drawing.Size(224, 21)
        Me.cmbalias.Sorted = True
        Me.cmbalias.TabIndex = 4
        Me.cmbalias.Tag = "1"
        '
        'txtcomputer
        '
        Me.txtcomputer.Location = New System.Drawing.Point(120, 32)
        Me.txtcomputer.Name = "txtcomputer"
        Me.txtcomputer.Size = New System.Drawing.Size(224, 20)
        Me.txtcomputer.TabIndex = 5
        Me.txtcomputer.Text = ""
        '
        'Form4
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(384, 80)
        Me.Controls.Add(Me.txtcomputer)
        Me.Controls.Add(Me.cmbalias)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdsave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.ShowInTaskbar = False
        Me.Text = "Bearbeiten >>"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim reg As RegistryKey
    Public frm2 As Form2
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_aliasbox()

    End Sub
    Public Sub fill_aliasbox()
        On Error GoTo errex
        reg = LocalMachine.OpenSubKey("Software\Adv Sender\computers", True)
        Me.cmbalias.Items.AddRange(reg.GetValueNames)
        Exit Sub
errex:
        MsgBox("Error Number: " & Err.Number & " | " & Err.Description)

    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        reg = LocalMachine.OpenSubKey("Software\Adv Sender\computers", True)
        reg.SetValue(Me.cmbalias.Text, Me.txtcomputer.Text)
        frm2.check_computers()
        Me.Close()
    End Sub
End Class
