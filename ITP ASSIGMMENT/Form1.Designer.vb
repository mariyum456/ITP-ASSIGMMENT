<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.Btn_1 = New System.Windows.Forms.Button()
        Me.Btn_2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Font = New System.Drawing.Font("Elephant", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbl_1.Location = New System.Drawing.Point(119, 112)
        Me.lbl_1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(908, 90)
        Me.lbl_1.TabIndex = 0
        Me.lbl_1.Text = "Welcome to my first page"
        '
        'Btn_1
        '
        Me.Btn_1.Font = New System.Drawing.Font("Franklin Gothic Demi", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_1.Location = New System.Drawing.Point(334, 330)
        Me.Btn_1.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_1.Name = "Btn_1"
        Me.Btn_1.Size = New System.Drawing.Size(256, 78)
        Me.Btn_1.TabIndex = 1
        Me.Btn_1.Text = "Searching"
        Me.Btn_1.UseVisualStyleBackColor = True
        '
        'Btn_2
        '
        Me.Btn_2.Font = New System.Drawing.Font("Franklin Gothic Demi", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_2.Location = New System.Drawing.Point(598, 330)
        Me.Btn_2.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_2.Name = "Btn_2"
        Me.Btn_2.Size = New System.Drawing.Size(256, 78)
        Me.Btn_2.TabIndex = 2
        Me.Btn_2.Text = "Sorting"
        Me.Btn_2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 544)
        Me.Controls.Add(Me.Btn_2)
        Me.Controls.Add(Me.Btn_1)
        Me.Controls.Add(Me.lbl_1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_1 As Label
    Friend WithEvents Btn_1 As Button
    Friend WithEvents Btn_2 As Button
End Class
