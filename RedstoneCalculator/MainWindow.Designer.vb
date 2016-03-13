<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.repeaterAmount = New System.Windows.Forms.TextBox()
        Me.comparatorAmount = New System.Windows.Forms.TextBox()
        Me.dispenserAmount = New System.Windows.Forms.TextBox()
        Me.dropperAmount = New System.Windows.Forms.TextBox()
        Me.redstoneLampAmount = New System.Windows.Forms.TextBox()
        Me.daylightSensorAmount = New System.Windows.Forms.TextBox()
        Me.repeaterButton = New System.Windows.Forms.RadioButton()
        Me.comparatorButton = New System.Windows.Forms.RadioButton()
        Me.dispenserButton = New System.Windows.Forms.RadioButton()
        Me.dropperButton = New System.Windows.Forms.RadioButton()
        Me.redstoneLampButton = New System.Windows.Forms.RadioButton()
        Me.daylightSensorButton = New System.Windows.Forms.RadioButton()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.noteblockButton = New System.Windows.Forms.RadioButton()
        Me.stickyPistonButton = New System.Windows.Forms.RadioButton()
        Me.pistonButton = New System.Windows.Forms.RadioButton()
        Me.noteblockAmount = New System.Windows.Forms.TextBox()
        Me.stickyPistonAmount = New System.Windows.Forms.TextBox()
        Me.pistonAmount = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.redstone = New System.Windows.Forms.Label()
        Me.redstoneT = New System.Windows.Forms.Label()
        Me.Cstone = New System.Windows.Forms.Label()
        Me.stone = New System.Windows.Forms.Label()
        Me.bow = New System.Windows.Forms.Label()
        Me.iron = New System.Windows.Forms.Label()
        Me.qua = New System.Windows.Forms.Label()
        Me.Gstone = New System.Windows.Forms.Label()
        Me.glass = New System.Windows.Forms.Label()
        Me.slab = New System.Windows.Forms.Label()
        Me.plank = New System.Windows.Forms.Label()
        Me.slime = New System.Windows.Forms.Label()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'repeaterAmount
        '
        Me.repeaterAmount.BackColor = System.Drawing.Color.Silver
        Me.repeaterAmount.Location = New System.Drawing.Point(67, 98)
        Me.repeaterAmount.Name = "repeaterAmount"
        Me.repeaterAmount.Size = New System.Drawing.Size(35, 20)
        Me.repeaterAmount.TabIndex = 2
        Me.repeaterAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'comparatorAmount
        '
        Me.comparatorAmount.BackColor = System.Drawing.Color.Silver
        Me.comparatorAmount.Location = New System.Drawing.Point(103, 98)
        Me.comparatorAmount.Name = "comparatorAmount"
        Me.comparatorAmount.Size = New System.Drawing.Size(35, 20)
        Me.comparatorAmount.TabIndex = 27
        Me.comparatorAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dispenserAmount
        '
        Me.dispenserAmount.BackColor = System.Drawing.Color.Silver
        Me.dispenserAmount.Location = New System.Drawing.Point(138, 98)
        Me.dispenserAmount.Name = "dispenserAmount"
        Me.dispenserAmount.Size = New System.Drawing.Size(35, 20)
        Me.dispenserAmount.TabIndex = 29
        Me.dispenserAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dropperAmount
        '
        Me.dropperAmount.BackColor = System.Drawing.Color.Silver
        Me.dropperAmount.Location = New System.Drawing.Point(173, 98)
        Me.dropperAmount.Name = "dropperAmount"
        Me.dropperAmount.Size = New System.Drawing.Size(35, 20)
        Me.dropperAmount.TabIndex = 31
        Me.dropperAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'redstoneLampAmount
        '
        Me.redstoneLampAmount.BackColor = System.Drawing.Color.Silver
        Me.redstoneLampAmount.Location = New System.Drawing.Point(209, 98)
        Me.redstoneLampAmount.Name = "redstoneLampAmount"
        Me.redstoneLampAmount.Size = New System.Drawing.Size(35, 20)
        Me.redstoneLampAmount.TabIndex = 33
        Me.redstoneLampAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'daylightSensorAmount
        '
        Me.daylightSensorAmount.BackColor = System.Drawing.Color.Silver
        Me.daylightSensorAmount.Location = New System.Drawing.Point(245, 98)
        Me.daylightSensorAmount.Name = "daylightSensorAmount"
        Me.daylightSensorAmount.Size = New System.Drawing.Size(35, 20)
        Me.daylightSensorAmount.TabIndex = 35
        Me.daylightSensorAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'repeaterButton
        '
        Me.repeaterButton.AutoSize = True
        Me.repeaterButton.BackColor = System.Drawing.Color.Silver
        Me.repeaterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.repeaterButton.Location = New System.Drawing.Point(77, 46)
        Me.repeaterButton.Name = "repeaterButton"
        Me.repeaterButton.Size = New System.Drawing.Size(14, 13)
        Me.repeaterButton.TabIndex = 36
        Me.repeaterButton.TabStop = True
        Me.repeaterButton.UseVisualStyleBackColor = False
        '
        'comparatorButton
        '
        Me.comparatorButton.AutoSize = True
        Me.comparatorButton.BackColor = System.Drawing.Color.Silver
        Me.comparatorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.comparatorButton.Location = New System.Drawing.Point(113, 46)
        Me.comparatorButton.Name = "comparatorButton"
        Me.comparatorButton.Size = New System.Drawing.Size(14, 13)
        Me.comparatorButton.TabIndex = 37
        Me.comparatorButton.TabStop = True
        Me.comparatorButton.UseVisualStyleBackColor = False
        '
        'dispenserButton
        '
        Me.dispenserButton.AutoSize = True
        Me.dispenserButton.BackColor = System.Drawing.Color.Silver
        Me.dispenserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.dispenserButton.Location = New System.Drawing.Point(149, 46)
        Me.dispenserButton.Name = "dispenserButton"
        Me.dispenserButton.Size = New System.Drawing.Size(14, 13)
        Me.dispenserButton.TabIndex = 38
        Me.dispenserButton.TabStop = True
        Me.dispenserButton.UseVisualStyleBackColor = False
        '
        'dropperButton
        '
        Me.dropperButton.AutoSize = True
        Me.dropperButton.BackColor = System.Drawing.Color.Silver
        Me.dropperButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.dropperButton.Location = New System.Drawing.Point(185, 46)
        Me.dropperButton.Name = "dropperButton"
        Me.dropperButton.Size = New System.Drawing.Size(14, 13)
        Me.dropperButton.TabIndex = 39
        Me.dropperButton.TabStop = True
        Me.dropperButton.UseVisualStyleBackColor = False
        '
        'redstoneLampButton
        '
        Me.redstoneLampButton.AutoSize = True
        Me.redstoneLampButton.BackColor = System.Drawing.Color.Silver
        Me.redstoneLampButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.redstoneLampButton.Location = New System.Drawing.Point(221, 46)
        Me.redstoneLampButton.Name = "redstoneLampButton"
        Me.redstoneLampButton.Size = New System.Drawing.Size(14, 13)
        Me.redstoneLampButton.TabIndex = 40
        Me.redstoneLampButton.TabStop = True
        Me.redstoneLampButton.UseVisualStyleBackColor = False
        '
        'daylightSensorButton
        '
        Me.daylightSensorButton.AutoSize = True
        Me.daylightSensorButton.BackColor = System.Drawing.Color.Silver
        Me.daylightSensorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.daylightSensorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.daylightSensorButton.ForeColor = System.Drawing.Color.Red
        Me.daylightSensorButton.Location = New System.Drawing.Point(257, 46)
        Me.daylightSensorButton.Name = "daylightSensorButton"
        Me.daylightSensorButton.Size = New System.Drawing.Size(14, 13)
        Me.daylightSensorButton.TabIndex = 41
        Me.daylightSensorButton.TabStop = True
        Me.daylightSensorButton.UseVisualStyleBackColor = False
        '
        'PictureBox17
        '
        Me.PictureBox17.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox17.BackgroundImage = CType(resources.GetObject("PictureBox17.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox17.Location = New System.Drawing.Point(52, 12)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(354, 118)
        Me.PictureBox17.TabIndex = 44
        Me.PictureBox17.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(3, 139)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(464, 119)
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'noteblockButton
        '
        Me.noteblockButton.AutoSize = True
        Me.noteblockButton.BackColor = System.Drawing.Color.Silver
        Me.noteblockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.noteblockButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.noteblockButton.ForeColor = System.Drawing.Color.Red
        Me.noteblockButton.Location = New System.Drawing.Point(367, 46)
        Me.noteblockButton.Name = "noteblockButton"
        Me.noteblockButton.Size = New System.Drawing.Size(14, 13)
        Me.noteblockButton.TabIndex = 51
        Me.noteblockButton.TabStop = True
        Me.noteblockButton.UseVisualStyleBackColor = False
        '
        'stickyPistonButton
        '
        Me.stickyPistonButton.AutoSize = True
        Me.stickyPistonButton.BackColor = System.Drawing.Color.Silver
        Me.stickyPistonButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.stickyPistonButton.Location = New System.Drawing.Point(331, 46)
        Me.stickyPistonButton.Name = "stickyPistonButton"
        Me.stickyPistonButton.Size = New System.Drawing.Size(14, 13)
        Me.stickyPistonButton.TabIndex = 50
        Me.stickyPistonButton.TabStop = True
        Me.stickyPistonButton.UseVisualStyleBackColor = False
        '
        'pistonButton
        '
        Me.pistonButton.AutoSize = True
        Me.pistonButton.BackColor = System.Drawing.Color.Silver
        Me.pistonButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pistonButton.Location = New System.Drawing.Point(295, 46)
        Me.pistonButton.Name = "pistonButton"
        Me.pistonButton.Size = New System.Drawing.Size(14, 13)
        Me.pistonButton.TabIndex = 49
        Me.pistonButton.TabStop = True
        Me.pistonButton.UseVisualStyleBackColor = False
        '
        'noteblockAmount
        '
        Me.noteblockAmount.BackColor = System.Drawing.Color.Silver
        Me.noteblockAmount.Location = New System.Drawing.Point(355, 98)
        Me.noteblockAmount.Name = "noteblockAmount"
        Me.noteblockAmount.Size = New System.Drawing.Size(35, 20)
        Me.noteblockAmount.TabIndex = 48
        Me.noteblockAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'stickyPistonAmount
        '
        Me.stickyPistonAmount.BackColor = System.Drawing.Color.Silver
        Me.stickyPistonAmount.Location = New System.Drawing.Point(319, 98)
        Me.stickyPistonAmount.Name = "stickyPistonAmount"
        Me.stickyPistonAmount.Size = New System.Drawing.Size(35, 20)
        Me.stickyPistonAmount.TabIndex = 47
        Me.stickyPistonAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pistonAmount
        '
        Me.pistonAmount.BackColor = System.Drawing.Color.Silver
        Me.pistonAmount.Location = New System.Drawing.Point(283, 98)
        Me.pistonAmount.Name = "pistonAmount"
        Me.pistonAmount.Size = New System.Drawing.Size(35, 20)
        Me.pistonAmount.TabIndex = 46
        Me.pistonAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(195, 301)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.TabIndex = 53
        Me.PictureBox3.TabStop = False
        '
        'redstone
        '
        Me.redstone.AutoSize = True
        Me.redstone.BackColor = System.Drawing.Color.Silver
        Me.redstone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.redstone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.redstone.Location = New System.Drawing.Point(21, 226)
        Me.redstone.Name = "redstone"
        Me.redstone.Size = New System.Drawing.Size(13, 13)
        Me.redstone.TabIndex = 54
        Me.redstone.Text = "0"
        '
        'redstoneT
        '
        Me.redstoneT.AutoSize = True
        Me.redstoneT.BackColor = System.Drawing.Color.Silver
        Me.redstoneT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.redstoneT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.redstoneT.Location = New System.Drawing.Point(60, 226)
        Me.redstoneT.Name = "redstoneT"
        Me.redstoneT.Size = New System.Drawing.Size(13, 13)
        Me.redstoneT.TabIndex = 55
        Me.redstoneT.Text = "0"
        '
        'Cstone
        '
        Me.Cstone.AutoSize = True
        Me.Cstone.BackColor = System.Drawing.Color.Silver
        Me.Cstone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cstone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cstone.Location = New System.Drawing.Point(132, 226)
        Me.Cstone.Name = "Cstone"
        Me.Cstone.Size = New System.Drawing.Size(13, 13)
        Me.Cstone.TabIndex = 57
        Me.Cstone.Text = "0"
        '
        'stone
        '
        Me.stone.AutoSize = True
        Me.stone.BackColor = System.Drawing.Color.Silver
        Me.stone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.stone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.stone.Location = New System.Drawing.Point(97, 226)
        Me.stone.Name = "stone"
        Me.stone.Size = New System.Drawing.Size(13, 13)
        Me.stone.TabIndex = 56
        Me.stone.Text = "0"
        '
        'bow
        '
        Me.bow.AutoSize = True
        Me.bow.BackColor = System.Drawing.Color.Silver
        Me.bow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bow.Location = New System.Drawing.Point(203, 226)
        Me.bow.Name = "bow"
        Me.bow.Size = New System.Drawing.Size(13, 13)
        Me.bow.TabIndex = 59
        Me.bow.Text = "0"
        '
        'iron
        '
        Me.iron.AutoSize = True
        Me.iron.BackColor = System.Drawing.Color.Silver
        Me.iron.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.iron.ForeColor = System.Drawing.SystemColors.ControlText
        Me.iron.Location = New System.Drawing.Point(168, 226)
        Me.iron.Name = "iron"
        Me.iron.Size = New System.Drawing.Size(13, 13)
        Me.iron.TabIndex = 58
        Me.iron.Text = "0"
        '
        'qua
        '
        Me.qua.AutoSize = True
        Me.qua.BackColor = System.Drawing.Color.Silver
        Me.qua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.qua.ForeColor = System.Drawing.SystemColors.ControlText
        Me.qua.Location = New System.Drawing.Point(278, 226)
        Me.qua.Name = "qua"
        Me.qua.Size = New System.Drawing.Size(13, 13)
        Me.qua.TabIndex = 61
        Me.qua.Text = "0"
        '
        'Gstone
        '
        Me.Gstone.AutoSize = True
        Me.Gstone.BackColor = System.Drawing.Color.Silver
        Me.Gstone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Gstone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Gstone.Location = New System.Drawing.Point(239, 226)
        Me.Gstone.Name = "Gstone"
        Me.Gstone.Size = New System.Drawing.Size(13, 13)
        Me.Gstone.TabIndex = 60
        Me.Gstone.Text = "0"
        '
        'glass
        '
        Me.glass.AutoSize = True
        Me.glass.BackColor = System.Drawing.Color.Silver
        Me.glass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.glass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.glass.Location = New System.Drawing.Point(347, 226)
        Me.glass.Name = "glass"
        Me.glass.Size = New System.Drawing.Size(13, 13)
        Me.glass.TabIndex = 63
        Me.glass.Text = "0"
        '
        'slab
        '
        Me.slab.AutoSize = True
        Me.slab.BackColor = System.Drawing.Color.Silver
        Me.slab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.slab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.slab.Location = New System.Drawing.Point(313, 226)
        Me.slab.Name = "slab"
        Me.slab.Size = New System.Drawing.Size(13, 13)
        Me.slab.TabIndex = 62
        Me.slab.Text = "0"
        '
        'plank
        '
        Me.plank.AutoSize = True
        Me.plank.BackColor = System.Drawing.Color.Silver
        Me.plank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.plank.ForeColor = System.Drawing.SystemColors.ControlText
        Me.plank.Location = New System.Drawing.Point(419, 226)
        Me.plank.Name = "plank"
        Me.plank.Size = New System.Drawing.Size(13, 13)
        Me.plank.TabIndex = 65
        Me.plank.Text = "0"
        '
        'slime
        '
        Me.slime.AutoSize = True
        Me.slime.BackColor = System.Drawing.Color.Silver
        Me.slime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.slime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.slime.Location = New System.Drawing.Point(385, 226)
        Me.slime.Name = "slime"
        Me.slime.Size = New System.Drawing.Size(13, 13)
        Me.slime.TabIndex = 64
        Me.slime.Text = "0"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(469, 261)
        Me.Controls.Add(Me.plank)
        Me.Controls.Add(Me.slime)
        Me.Controls.Add(Me.glass)
        Me.Controls.Add(Me.slab)
        Me.Controls.Add(Me.qua)
        Me.Controls.Add(Me.Gstone)
        Me.Controls.Add(Me.bow)
        Me.Controls.Add(Me.iron)
        Me.Controls.Add(Me.Cstone)
        Me.Controls.Add(Me.stone)
        Me.Controls.Add(Me.redstoneT)
        Me.Controls.Add(Me.redstone)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.noteblockButton)
        Me.Controls.Add(Me.stickyPistonButton)
        Me.Controls.Add(Me.pistonButton)
        Me.Controls.Add(Me.noteblockAmount)
        Me.Controls.Add(Me.stickyPistonAmount)
        Me.Controls.Add(Me.pistonAmount)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.repeaterAmount)
        Me.Controls.Add(Me.daylightSensorButton)
        Me.Controls.Add(Me.redstoneLampButton)
        Me.Controls.Add(Me.dropperButton)
        Me.Controls.Add(Me.dispenserButton)
        Me.Controls.Add(Me.comparatorButton)
        Me.Controls.Add(Me.repeaterButton)
        Me.Controls.Add(Me.daylightSensorAmount)
        Me.Controls.Add(Me.redstoneLampAmount)
        Me.Controls.Add(Me.dropperAmount)
        Me.Controls.Add(Me.dispenserAmount)
        Me.Controls.Add(Me.comparatorAmount)
        Me.Controls.Add(Me.PictureBox17)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainWindow"
        Me.Text = "Redstone'owy kalkulator"
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents repeaterAmount As TextBox
    Friend WithEvents comparatorAmount As TextBox
    Friend WithEvents dispenserAmount As TextBox
    Friend WithEvents dropperAmount As TextBox
    Friend WithEvents redstoneLampAmount As TextBox
    Friend WithEvents daylightSensorAmount As TextBox
    Friend WithEvents repeaterButton As RadioButton
    Friend WithEvents comparatorButton As RadioButton
    Friend WithEvents dispenserButton As RadioButton
    Friend WithEvents dropperButton As RadioButton
    Friend WithEvents redstoneLampButton As RadioButton
    Friend WithEvents daylightSensorButton As RadioButton
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents noteblockButton As RadioButton
    Friend WithEvents stickyPistonButton As RadioButton
    Friend WithEvents pistonButton As RadioButton
    Friend WithEvents noteblockAmount As TextBox
    Friend WithEvents stickyPistonAmount As TextBox
    Friend WithEvents pistonAmount As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents redstone As Label
    Friend WithEvents redstoneT As Label
    Friend WithEvents Cstone As Label
    Friend WithEvents stone As Label
    Friend WithEvents bow As Label
    Friend WithEvents iron As Label
    Friend WithEvents qua As Label
    Friend WithEvents Gstone As Label
    Friend WithEvents glass As Label
    Friend WithEvents slab As Label
    Friend WithEvents plank As Label
    Friend WithEvents slime As Label
End Class