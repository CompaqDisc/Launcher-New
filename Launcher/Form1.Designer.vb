﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TempCloseBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TempCloseBtn
        '
        Me.TempCloseBtn.Location = New System.Drawing.Point(12, 12)
        Me.TempCloseBtn.Name = "TempCloseBtn"
        Me.TempCloseBtn.Size = New System.Drawing.Size(75, 23)
        Me.TempCloseBtn.TabIndex = 0
        Me.TempCloseBtn.Text = "Close" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TempCloseBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 361)
        Me.Controls.Add(Me.TempCloseBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Launcher"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TempCloseBtn As Button
End Class
