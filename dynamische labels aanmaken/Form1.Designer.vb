<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBingo
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
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.pnl3 = New System.Windows.Forms.Panel()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.pnl4 = New System.Windows.Forms.Panel()
        Me.lblGetal = New System.Windows.Forms.Label()
        Me.btnVolgendGetal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.Location = New System.Drawing.Point(30, 31)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(218, 225)
        Me.pnl1.TabIndex = 0
        '
        'pnl3
        '
        Me.pnl3.Location = New System.Drawing.Point(31, 285)
        Me.pnl3.Name = "pnl3"
        Me.pnl3.Size = New System.Drawing.Size(218, 225)
        Me.pnl3.TabIndex = 2
        '
        'pnl2
        '
        Me.pnl2.Location = New System.Drawing.Point(290, 31)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(218, 225)
        Me.pnl2.TabIndex = 1
        '
        'pnl4
        '
        Me.pnl4.Location = New System.Drawing.Point(290, 285)
        Me.pnl4.Name = "pnl4"
        Me.pnl4.Size = New System.Drawing.Size(218, 225)
        Me.pnl4.TabIndex = 3
        '
        'lblGetal
        '
        Me.lblGetal.AutoSize = True
        Me.lblGetal.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGetal.Location = New System.Drawing.Point(612, 105)
        Me.lblGetal.Name = "lblGetal"
        Me.lblGetal.Size = New System.Drawing.Size(0, 108)
        Me.lblGetal.TabIndex = 2
        Me.lblGetal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnVolgendGetal
        '
        Me.btnVolgendGetal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolgendGetal.Location = New System.Drawing.Point(630, 239)
        Me.btnVolgendGetal.Name = "btnVolgendGetal"
        Me.btnVolgendGetal.Size = New System.Drawing.Size(117, 72)
        Me.btnVolgendGetal.TabIndex = 4
        Me.btnVolgendGetal.Text = "Het volgende getal"
        Me.btnVolgendGetal.UseVisualStyleBackColor = True
        '
        'frmBingo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 533)
        Me.Controls.Add(Me.btnVolgendGetal)
        Me.Controls.Add(Me.lblGetal)
        Me.Controls.Add(Me.pnl4)
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl3)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "frmBingo"
        Me.Text = "Bingo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnl1 As Panel
    Friend WithEvents pnl3 As Panel
    Friend WithEvents pnl2 As Panel
    Friend WithEvents pnl4 As Panel
    Friend WithEvents lblGetal As Label
    Friend WithEvents btnVolgendGetal As Button
End Class
