<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBoxLabel = New System.Windows.Forms.Label()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.VirusesFoundLabel = New System.Windows.Forms.Label()
        Me.SuspFilesFoundLabel = New System.Windows.Forms.Label()
        Me.ItemsScannedLabel = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.MainLabel = New System.Windows.Forms.Label()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.StartStopButton = New System.Windows.Forms.Button()
        Me.MainProgressBar = New System.Windows.Forms.ProgressBar()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MainTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(706, 215)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.LabelStatus)
        Me.TabPage1.Controls.Add(Me.StartStopButton)
        Me.TabPage1.Controls.Add(Me.MainProgressBar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(698, 189)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Scan"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBoxLabel)
        Me.GroupBox1.Controls.Add(Me.ListBox)
        Me.GroupBox1.Controls.Add(Me.VirusesFoundLabel)
        Me.GroupBox1.Controls.Add(Me.SuspFilesFoundLabel)
        Me.GroupBox1.Controls.Add(Me.ItemsScannedLabel)
        Me.GroupBox1.Controls.Add(Me.CancelButton)
        Me.GroupBox1.Controls.Add(Me.MainLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 107)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'ListBoxLabel
        '
        Me.ListBoxLabel.AutoSize = True
        Me.ListBoxLabel.Location = New System.Drawing.Point(251, 8)
        Me.ListBoxLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ListBoxLabel.Name = "ListBoxLabel"
        Me.ListBoxLabel.Size = New System.Drawing.Size(55, 13)
        Me.ListBoxLabel.TabIndex = 6
        Me.ListBoxLabel.Text = "Messages"
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Location = New System.Drawing.Point(254, 24)
        Me.ListBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(218, 82)
        Me.ListBox.TabIndex = 5
        '
        'VirusesFoundLabel
        '
        Me.VirusesFoundLabel.AutoSize = True
        Me.VirusesFoundLabel.Location = New System.Drawing.Point(11, 77)
        Me.VirusesFoundLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VirusesFoundLabel.Name = "VirusesFoundLabel"
        Me.VirusesFoundLabel.Size = New System.Drawing.Size(83, 13)
        Me.VirusesFoundLabel.TabIndex = 4
        Me.VirusesFoundLabel.Text = "0 Viruses Found"
        '
        'SuspFilesFoundLabel
        '
        Me.SuspFilesFoundLabel.AutoSize = True
        Me.SuspFilesFoundLabel.Location = New System.Drawing.Point(11, 63)
        Me.SuspFilesFoundLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SuspFilesFoundLabel.Name = "SuspFilesFoundLabel"
        Me.SuspFilesFoundLabel.Size = New System.Drawing.Size(124, 13)
        Me.SuspFilesFoundLabel.TabIndex = 3
        Me.SuspFilesFoundLabel.Text = "0 Suspicious Files Found"
        '
        'ItemsScannedLabel
        '
        Me.ItemsScannedLabel.AutoSize = True
        Me.ItemsScannedLabel.Location = New System.Drawing.Point(11, 50)
        Me.ItemsScannedLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ItemsScannedLabel.Name = "ItemsScannedLabel"
        Me.ItemsScannedLabel.Size = New System.Drawing.Size(84, 13)
        Me.ItemsScannedLabel.TabIndex = 2
        Me.ItemsScannedLabel.Text = "0 items scanned"
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(608, 5)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(83, 30)
        Me.CancelButton.TabIndex = 1
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'MainLabel
        '
        Me.MainLabel.AutoSize = True
        Me.MainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainLabel.Location = New System.Drawing.Point(7, 16)
        Me.MainLabel.Name = "MainLabel"
        Me.MainLabel.Size = New System.Drawing.Size(192, 25)
        Me.MainLabel.TabIndex = 0
        Me.MainLabel.Text = "Scan not started."
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(3, 111)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(85, 13)
        Me.LabelStatus.TabIndex = 2
        Me.LabelStatus.Text = "Scan not started"
        '
        'StartStopButton
        '
        Me.StartStopButton.Location = New System.Drawing.Point(343, 108)
        Me.StartStopButton.Name = "StartStopButton"
        Me.StartStopButton.Size = New System.Drawing.Size(353, 41)
        Me.StartStopButton.TabIndex = 1
        Me.StartStopButton.Text = "StartScan"
        Me.StartStopButton.UseVisualStyleBackColor = True
        '
        'MainProgressBar
        '
        Me.MainProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MainProgressBar.Location = New System.Drawing.Point(3, 147)
        Me.MainProgressBar.Name = "MainProgressBar"
        Me.MainProgressBar.Size = New System.Drawing.Size(692, 39)
        Me.MainProgressBar.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(698, 189)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Options"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MainTimer
        '
        Me.MainTimer.Enabled = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 215)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.Text = "ViruScan"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents StartStopButton As System.Windows.Forms.Button
    Friend WithEvents MainProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MainLabel As System.Windows.Forms.Label
    Friend WithEvents MainTimer As System.Windows.Forms.Timer
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents VirusesFoundLabel As System.Windows.Forms.Label
    Friend WithEvents SuspFilesFoundLabel As System.Windows.Forms.Label
    Friend WithEvents ItemsScannedLabel As System.Windows.Forms.Label
    Friend WithEvents ListBoxLabel As System.Windows.Forms.Label
    Friend WithEvents ListBox As System.Windows.Forms.ListBox

End Class
