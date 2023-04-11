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
        Me.gboEnglish = New System.Windows.Forms.GroupBox()
        Me.radBrother = New System.Windows.Forms.RadioButton()
        Me.radSister = New System.Windows.Forms.RadioButton()
        Me.rafFather = New System.Windows.Forms.RadioButton()
        Me.radMother = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTranslateTo = New System.Windows.Forms.ComboBox()
        Me.lblTranslation = New System.Windows.Forms.Label()
        Me.btnTranslate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gboEnglish.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboEnglish
        '
        Me.gboEnglish.Controls.Add(Me.radBrother)
        Me.gboEnglish.Controls.Add(Me.radSister)
        Me.gboEnglish.Controls.Add(Me.rafFather)
        Me.gboEnglish.Controls.Add(Me.radMother)
        Me.gboEnglish.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboEnglish.Location = New System.Drawing.Point(62, 55)
        Me.gboEnglish.Name = "gboEnglish"
        Me.gboEnglish.Size = New System.Drawing.Size(116, 130)
        Me.gboEnglish.TabIndex = 0
        Me.gboEnglish.TabStop = False
        Me.gboEnglish.Text = "English"
        '
        'radBrother
        '
        Me.radBrother.AutoSize = True
        Me.radBrother.Location = New System.Drawing.Point(6, 99)
        Me.radBrother.Name = "radBrother"
        Me.radBrother.Size = New System.Drawing.Size(78, 22)
        Me.radBrother.TabIndex = 1
        Me.radBrother.TabStop = True
        Me.radBrother.Text = "&Brother"
        Me.radBrother.UseVisualStyleBackColor = True
        '
        'radSister
        '
        Me.radSister.AutoSize = True
        Me.radSister.Location = New System.Drawing.Point(6, 73)
        Me.radSister.Name = "radSister"
        Me.radSister.Size = New System.Drawing.Size(67, 22)
        Me.radSister.TabIndex = 1
        Me.radSister.TabStop = True
        Me.radSister.Text = "&Sister"
        Me.radSister.UseVisualStyleBackColor = True
        '
        'rafFather
        '
        Me.rafFather.AutoSize = True
        Me.rafFather.Location = New System.Drawing.Point(6, 47)
        Me.rafFather.Name = "rafFather"
        Me.rafFather.Size = New System.Drawing.Size(71, 22)
        Me.rafFather.TabIndex = 1
        Me.rafFather.Text = "&Father"
        Me.rafFather.UseVisualStyleBackColor = True
        '
        'radMother
        '
        Me.radMother.AutoSize = True
        Me.radMother.Checked = True
        Me.radMother.Location = New System.Drawing.Point(6, 21)
        Me.radMother.Name = "radMother"
        Me.radMother.Size = New System.Drawing.Size(76, 22)
        Me.radMother.TabIndex = 1
        Me.radMother.TabStop = True
        Me.radMother.Text = "&Mother"
        Me.radMother.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "T&ranslate to:"
        '
        'cboTranslateTo
        '
        Me.cboTranslateTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTranslateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTranslateTo.FormattingEnabled = True
        Me.cboTranslateTo.Items.AddRange(New Object() {"French", "Italian", "Spanish"})
        Me.cboTranslateTo.Location = New System.Drawing.Point(190, 77)
        Me.cboTranslateTo.Name = "cboTranslateTo"
        Me.cboTranslateTo.Size = New System.Drawing.Size(121, 26)
        Me.cboTranslateTo.TabIndex = 2
        '
        'lblTranslation
        '
        Me.lblTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTranslation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTranslation.Location = New System.Drawing.Point(190, 135)
        Me.lblTranslation.Name = "lblTranslation"
        Me.lblTranslation.Size = New System.Drawing.Size(121, 50)
        Me.lblTranslation.TabIndex = 3
        Me.lblTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTranslate
        '
        Me.btnTranslate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTranslate.Location = New System.Drawing.Point(326, 87)
        Me.btnTranslate.Name = "btnTranslate"
        Me.btnTranslate.Size = New System.Drawing.Size(100, 30)
        Me.btnTranslate.TabIndex = 4
        Me.btnTranslate.Text = "&Translate"
        Me.btnTranslate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(326, 123)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 213)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTranslate)
        Me.Controls.Add(Me.lblTranslation)
        Me.Controls.Add(Me.cboTranslateTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gboEnglish)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Translator"
        Me.gboEnglish.ResumeLayout(False)
        Me.gboEnglish.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gboEnglish As GroupBox
    Friend WithEvents radBrother As RadioButton
    Friend WithEvents radSister As RadioButton
    Friend WithEvents rafFather As RadioButton
    Friend WithEvents radMother As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cboTranslateTo As ComboBox
    Friend WithEvents lblTranslation As Label
    Friend WithEvents btnTranslate As Button
    Friend WithEvents btnExit As Button
End Class
