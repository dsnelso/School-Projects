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
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.TxtHeight = New System.Windows.Forms.TextBox()
        Me.TxtBase = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LstResults = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(264, 256)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(112, 36)
        Me.BtnCalc.TabIndex = 0
        Me.BtnCalc.Text = "Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'TxtHeight
        '
        Me.TxtHeight.Location = New System.Drawing.Point(90, 117)
        Me.TxtHeight.Name = "TxtHeight"
        Me.TxtHeight.Size = New System.Drawing.Size(100, 26)
        Me.TxtHeight.TabIndex = 1
        '
        'TxtBase
        '
        Me.TxtBase.Location = New System.Drawing.Point(90, 64)
        Me.TxtBase.Name = "TxtBase"
        Me.TxtBase.Size = New System.Drawing.Size(100, 26)
        Me.TxtBase.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Base"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Height"
        '
        'LstResults
        '
        Me.LstResults.FormattingEnabled = True
        Me.LstResults.ItemHeight = 20
        Me.LstResults.Location = New System.Drawing.Point(402, 64)
        Me.LstResults.Name = "LstResults"
        Me.LstResults.Size = New System.Drawing.Size(159, 144)
        Me.LstResults.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 350)
        Me.Controls.Add(Me.LstResults)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBase)
        Me.Controls.Add(Me.TxtHeight)
        Me.Controls.Add(Me.BtnCalc)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCalc As Button
    Friend WithEvents TxtHeight As TextBox
    Friend WithEvents TxtBase As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LstResults As ListBox
End Class
