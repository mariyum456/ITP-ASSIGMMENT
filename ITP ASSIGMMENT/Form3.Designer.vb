<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(591, 71)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(256, 344)
        Me.ListBox1.TabIndex = 0
        '
        'btn_7
        '
        Me.btn_7.Font = New System.Drawing.Font("Franklin Gothic Demi", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_7.Location = New System.Drawing.Point(296, 103)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(171, 64)
        Me.btn_7.TabIndex = 1
        Me.btn_7.Text = "Bubble sort"
        Me.btn_7.UseVisualStyleBackColor = True
        '
        'btn_8
        '
        Me.btn_8.Font = New System.Drawing.Font("Franklin Gothic Demi", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_8.Location = New System.Drawing.Point(296, 187)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(171, 62)
        Me.btn_8.TabIndex = 2
        Me.btn_8.Text = "Insertion sort"
        Me.btn_8.UseVisualStyleBackColor = True
        '
        'btn_9
        '
        Me.btn_9.Font = New System.Drawing.Font("Franklin Gothic Demi", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_9.Location = New System.Drawing.Point(296, 264)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(171, 61)
        Me.btn_9.TabIndex = 3
        Me.btn_9.Text = "Main Menu"
        Me.btn_9.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1263, 521)
        Me.Controls.Add(Me.btn_9)
        Me.Controls.Add(Me.btn_8)
        Me.Controls.Add(Me.btn_7)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_9 As Button
End Class
