<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstCandidate = New System.Windows.Forms.ListBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDisplayVotes = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSam = New System.Windows.Forms.Label()
        Me.lblSheima = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMark = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Candidate:"
        '
        'lstCandidate
        '
        Me.lstCandidate.FormattingEnabled = True
        Me.lstCandidate.ItemHeight = 17
        Me.lstCandidate.Items.AddRange(New Object() {"Mark Stone", "Sam Perez", "Sheima Patel"})
        Me.lstCandidate.Location = New System.Drawing.Point(16, 34)
        Me.lstCandidate.Name = "lstCandidate"
        Me.lstCandidate.Size = New System.Drawing.Size(137, 106)
        Me.lstCandidate.Sorted = True
        Me.lstCandidate.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(195, 34)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 31)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save Vote"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDisplayVotes
        '
        Me.btnDisplayVotes.Location = New System.Drawing.Point(195, 71)
        Me.btnDisplayVotes.Name = "btnDisplayVotes"
        Me.btnDisplayVotes.Size = New System.Drawing.Size(106, 31)
        Me.btnDisplayVotes.TabIndex = 3
        Me.btnDisplayVotes.Text = "&Display Votes"
        Me.btnDisplayVotes.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(195, 108)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 31)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSam)
        Me.GroupBox1.Controls.Add(Me.lblSheima)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblMark)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Votes:"
        '
        'lblSam
        '
        Me.lblSam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSam.Location = New System.Drawing.Point(194, 58)
        Me.lblSam.Name = "lblSam"
        Me.lblSam.Size = New System.Drawing.Size(58, 26)
        Me.lblSam.TabIndex = 0
        '
        'lblSheima
        '
        Me.lblSheima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSheima.Location = New System.Drawing.Point(103, 58)
        Me.lblSheima.Name = "lblSheima"
        Me.lblSheima.Size = New System.Drawing.Size(58, 26)
        Me.lblSheima.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(194, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Sam Perez:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sheima Patel:"
        '
        'lblMark
        '
        Me.lblMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMark.Location = New System.Drawing.Point(9, 57)
        Me.lblMark.Name = "lblMark"
        Me.lblMark.Size = New System.Drawing.Size(58, 26)
        Me.lblMark.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mark Stone:"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 319)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplayVotes)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lstCandidate)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "Warren High School"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstCandidate As ListBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDisplayVotes As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSam As Label
    Friend WithEvents lblSheima As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMark As Label
    Friend WithEvents Label2 As Label
End Class
