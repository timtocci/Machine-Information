<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Output
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
        Me.btnGetInfo = New System.Windows.Forms.Button()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.btnServices = New System.Windows.Forms.Button()
        Me.btnProcesses = New System.Windows.Forms.Button()
        Me.btnCustom = New System.Windows.Forms.Button()
        Me.txtCustom = New System.Windows.Forms.TextBox()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGetInfo
        '
        Me.btnGetInfo.Location = New System.Drawing.Point(12, 12)
        Me.btnGetInfo.Name = "btnGetInfo"
        Me.btnGetInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnGetInfo.TabIndex = 0
        Me.btnGetInfo.Text = "Get Info"
        Me.btnGetInfo.UseVisualStyleBackColor = True
        '
        'txtOut
        '
        Me.txtOut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOut.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOut.Location = New System.Drawing.Point(12, 41)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.ReadOnly = True
        Me.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOut.Size = New System.Drawing.Size(391, 346)
        Me.txtOut.TabIndex = 1
        Me.txtOut.WordWrap = False
        '
        'btnServices
        '
        Me.btnServices.Location = New System.Drawing.Point(184, 12)
        Me.btnServices.Name = "btnServices"
        Me.btnServices.Size = New System.Drawing.Size(99, 23)
        Me.btnServices.TabIndex = 2
        Me.btnServices.Text = "Running Services"
        Me.btnServices.UseVisualStyleBackColor = True
        '
        'btnProcesses
        '
        Me.btnProcesses.Location = New System.Drawing.Point(289, 12)
        Me.btnProcesses.Name = "btnProcesses"
        Me.btnProcesses.Size = New System.Drawing.Size(111, 23)
        Me.btnProcesses.TabIndex = 3
        Me.btnProcesses.Text = "Running Processes"
        Me.btnProcesses.UseVisualStyleBackColor = True
        '
        'btnCustom
        '
        Me.btnCustom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCustom.Location = New System.Drawing.Point(12, 393)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Size = New System.Drawing.Size(136, 23)
        Me.btnCustom.TabIndex = 4
        Me.btnCustom.Text = "Run Custom WMI Query"
        Me.btnCustom.UseVisualStyleBackColor = True
        '
        'txtCustom
        '
        Me.txtCustom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCustom.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustom.Location = New System.Drawing.Point(155, 395)
        Me.txtCustom.Name = "txtCustom"
        Me.txtCustom.Size = New System.Drawing.Size(248, 20)
        Me.txtCustom.TabIndex = 5
        '
        'btnProducts
        '
        Me.btnProducts.Location = New System.Drawing.Point(93, 12)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(85, 23)
        Me.btnProducts.TabIndex = 6
        Me.btnProducts.Text = "Get Products"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'Output
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 424)
        Me.Controls.Add(Me.btnProducts)
        Me.Controls.Add(Me.txtCustom)
        Me.Controls.Add(Me.btnCustom)
        Me.Controls.Add(Me.btnProcesses)
        Me.Controls.Add(Me.btnServices)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.btnGetInfo)
        Me.MinimumSize = New System.Drawing.Size(431, 463)
        Me.Name = "Output"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Machine Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGetInfo As Button
    Friend WithEvents txtOut As TextBox
    Friend WithEvents btnServices As Button
    Friend WithEvents btnProcesses As Button
    Friend WithEvents btnCustom As Button
    Friend WithEvents txtCustom As TextBox
    Friend WithEvents btnProducts As Button
End Class
