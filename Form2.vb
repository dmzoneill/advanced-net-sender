Imports Microsoft.Win32
Imports Microsoft.Win32.Registry
Public Class Form2
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents cmdfertig As System.Windows.Forms.Button
    Friend WithEvents cmdloeschen As System.Windows.Forms.Button
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents cmdedit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.cmdadd = New System.Windows.Forms.Button
        Me.cmdloeschen = New System.Windows.Forms.Button
        Me.cmdedit = New System.Windows.Forms.Button
        Me.cmdfertig = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "{ schließen }"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Computer"
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(8, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(176, 212)
        Me.ListBox1.TabIndex = 2
        '
        'cmdadd
        '
        Me.cmdadd.Location = New System.Drawing.Point(192, 32)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(72, 24)
        Me.cmdadd.TabIndex = 3
        Me.cmdadd.Text = "Hinzufügen"
        '
        'cmdloeschen
        '
        Me.cmdloeschen.Location = New System.Drawing.Point(192, 80)
        Me.cmdloeschen.Name = "cmdloeschen"
        Me.cmdloeschen.Size = New System.Drawing.Size(72, 24)
        Me.cmdloeschen.TabIndex = 4
        Me.cmdloeschen.Text = "Löschen"
        '
        'cmdedit
        '
        Me.cmdedit.Location = New System.Drawing.Point(192, 56)
        Me.cmdedit.Name = "cmdedit"
        Me.cmdedit.Size = New System.Drawing.Size(72, 24)
        Me.cmdedit.TabIndex = 5
        Me.cmdedit.Text = "Bearbeiten"
        '
        'cmdfertig
        '
        Me.cmdfertig.Location = New System.Drawing.Point(192, 120)
        Me.cmdfertig.Name = "cmdfertig"
        Me.cmdfertig.Size = New System.Drawing.Size(72, 24)
        Me.cmdfertig.TabIndex = 6
        Me.cmdfertig.Text = "Fertig"
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(344, 272)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdfertig)
        Me.Controls.Add(Me.cmdedit)
        Me.Controls.Add(Me.cmdloeschen)
        Me.Controls.Add(Me.cmdadd)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.Text = "                                                  Optionen"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim reg As RegistryKey
    Dim key As RegistryKey
    Public frm As New Form1

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = 0
        reg = LocalMachine.OpenSubKey("Software\Adv Sender", True)
        reg.CreateSubKey("computers")
        Me.Top = reg.GetValue("top")
        Me.Left = reg.GetValue("left") + 80
        run_timer()
        check_computers()
    End Sub
    Public Sub run_timer()
        Timer1.Enabled = True
        Timer1.Interval = 250
    End Sub
    Public Sub check_computers()
        reg = LocalMachine.OpenSubKey("software\Adv Sender\computers", True)
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(reg.GetValueNames)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i As Integer
        Do Until Me.Height > 290
            Me.Height = Me.Height + 4
        Loop
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub





    Private Sub cmdfertig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfertig.Click
        reg = LocalMachine.OpenSubKey("Software\Adv Sender\computers", True)

        frm.txtsender.Text = reg.GetValue(Me.ListBox1.SelectedItem)
        Me.Close()
    End Sub

    Private Sub cmdloeschen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdloeschen.Click
        reg = LocalMachine.OpenSubKey("Software\Adv Sender\computers", True)
        If Me.ListBox1.SelectedItem = Nothing Then

        Else
            If MessageBox.Show("Sind Sie sicher, dass Sie " & ListBox1.SelectedItem & " Löschen wollten??", "Löschen", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                reg.DeleteValue(ListBox1.SelectedItem)
                check_computers()
            End If
        End If

    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        Dim frm3 As New Form3
        frm3.frm2 = Me
        frm3.ShowDialog()
    End Sub

    Private Sub cmdedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdedit.Click
        Dim frm4 As New Form4
        frm4.frm2 = Me
        frm4.ShowDialog()
    End Sub
End Class
