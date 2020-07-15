<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCardType = New System.Windows.Forms.ComboBox()
        Me.cmbTransType = New System.Windows.Forms.ComboBox()
        Me.txtRef = New System.Windows.Forms.TextBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnSend_Lines = New System.Windows.Forms.Button()
        Me.btnSend_Image = New System.Windows.Forms.Button()
        Me.btnSend_Init = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(10, 101)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(97, 37)
        Me.btnProcess.TabIndex = 0
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(113, 101)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 37)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Card Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Trans Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ref Num"
        '
        'cmbCardType
        '
        Me.cmbCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCardType.FormattingEnabled = True
        Me.cmbCardType.Location = New System.Drawing.Point(74, 12)
        Me.cmbCardType.Name = "cmbCardType"
        Me.cmbCardType.Size = New System.Drawing.Size(108, 21)
        Me.cmbCardType.TabIndex = 6
        '
        'cmbTransType
        '
        Me.cmbTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTransType.FormattingEnabled = True
        Me.cmbTransType.Location = New System.Drawing.Point(74, 39)
        Me.cmbTransType.Name = "cmbTransType"
        Me.cmbTransType.Size = New System.Drawing.Size(108, 21)
        Me.cmbTransType.TabIndex = 7
        '
        'txtRef
        '
        Me.txtRef.Location = New System.Drawing.Point(74, 66)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Size = New System.Drawing.Size(108, 20)
        Me.txtRef.TabIndex = 8
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(256, 30)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(97, 37)
        Me.btnTest.TabIndex = 9
        Me.btnTest.Text = "Test Reboot"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnSend_Lines
        '
        Me.btnSend_Lines.Location = New System.Drawing.Point(256, 82)
        Me.btnSend_Lines.Name = "btnSend_Lines"
        Me.btnSend_Lines.Size = New System.Drawing.Size(97, 37)
        Me.btnSend_Lines.TabIndex = 10
        Me.btnSend_Lines.Text = "Send Lines"
        Me.btnSend_Lines.UseVisualStyleBackColor = True
        '
        'btnSend_Image
        '
        Me.btnSend_Image.Location = New System.Drawing.Point(256, 138)
        Me.btnSend_Image.Name = "btnSend_Image"
        Me.btnSend_Image.Size = New System.Drawing.Size(97, 37)
        Me.btnSend_Image.TabIndex = 11
        Me.btnSend_Image.Text = "Send Image"
        Me.btnSend_Image.UseVisualStyleBackColor = True
        '
        'btnSend_Init
        '
        Me.btnSend_Init.Location = New System.Drawing.Point(256, 199)
        Me.btnSend_Init.Name = "btnSend_Init"
        Me.btnSend_Init.Size = New System.Drawing.Size(97, 37)
        Me.btnSend_Init.TabIndex = 12
        Me.btnSend_Init.Text = "Send Init"
        Me.btnSend_Init.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 248)
        Me.Controls.Add(Me.btnSend_Init)
        Me.Controls.Add(Me.btnSend_Image)
        Me.Controls.Add(Me.btnSend_Lines)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.txtRef)
        Me.Controls.Add(Me.cmbTransType)
        Me.Controls.Add(Me.cmbCardType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnProcess)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "PayLink VB.Net Sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCardType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTransType As System.Windows.Forms.ComboBox
    Friend WithEvents txtRef As System.Windows.Forms.TextBox
    Friend WithEvents btnTest As Button
    Friend WithEvents btnSend_Lines As Button
    Friend WithEvents btnSend_Image As Button
    Friend WithEvents btnSend_Init As Button
End Class
