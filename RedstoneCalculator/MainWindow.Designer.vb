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
        Me.inputBackground = New System.Windows.Forms.PictureBox()
        Me.outputBackground = New System.Windows.Forms.PictureBox()
        Me.noteblockButton = New System.Windows.Forms.RadioButton()
        Me.stickyPistonButton = New System.Windows.Forms.RadioButton()
        Me.pistonButton = New System.Windows.Forms.RadioButton()
        Me.noteblockAmount = New System.Windows.Forms.TextBox()
        Me.stickyPistonAmount = New System.Windows.Forms.TextBox()
        Me.pistonAmount = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.redstoneResult = New System.Windows.Forms.Label()
        Me.redstoneTorchResult = New System.Windows.Forms.Label()
        Me.cobblestoneResult = New System.Windows.Forms.Label()
        Me.stoneResult = New System.Windows.Forms.Label()
        Me.bowResult = New System.Windows.Forms.Label()
        Me.ironIngotResult = New System.Windows.Forms.Label()
        Me.quartzResult = New System.Windows.Forms.Label()
        Me.glowstoneResult = New System.Windows.Forms.Label()
        Me.glassResult = New System.Windows.Forms.Label()
        Me.woodenSlabResult = New System.Windows.Forms.Label()
        Me.woodenPlanksResult = New System.Windows.Forms.Label()
        Me.slimeResult = New System.Windows.Forms.Label()
        CType(Me.inputBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.outputBackground, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'inputBackground
        '
        Me.inputBackground.BackColor = System.Drawing.Color.Transparent
        Me.inputBackground.BackgroundImage = CType(resources.GetObject("inputBackground.BackgroundImage"), System.Drawing.Image)
        Me.inputBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inputBackground.Location = New System.Drawing.Point(52, 12)
        Me.inputBackground.Name = "inputBackground"
        Me.inputBackground.Size = New System.Drawing.Size(354, 118)
        Me.inputBackground.TabIndex = 44
        Me.inputBackground.TabStop = False
        '
        'outputBackground
        '
        Me.outputBackground.BackColor = System.Drawing.Color.Transparent
        Me.outputBackground.BackgroundImage = CType(resources.GetObject("outputBackground.BackgroundImage"), System.Drawing.Image)
        Me.outputBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.outputBackground.Location = New System.Drawing.Point(3, 139)
        Me.outputBackground.Name = "outputBackground"
        Me.outputBackground.Size = New System.Drawing.Size(464, 119)
        Me.outputBackground.TabIndex = 45
        Me.outputBackground.TabStop = False
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
        'redstoneResult
        '
        Me.redstoneResult.AutoSize = True
        Me.redstoneResult.BackColor = System.Drawing.Color.Silver
        Me.redstoneResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.redstoneResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.redstoneResult.Location = New System.Drawing.Point(21, 226)
        Me.redstoneResult.Name = "redstoneResult"
        Me.redstoneResult.Size = New System.Drawing.Size(13, 13)
        Me.redstoneResult.TabIndex = 54
        Me.redstoneResult.Text = "0"
        '
        'redstoneTorchResult
        '
        Me.redstoneTorchResult.AutoSize = True
        Me.redstoneTorchResult.BackColor = System.Drawing.Color.Silver
        Me.redstoneTorchResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.redstoneTorchResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.redstoneTorchResult.Location = New System.Drawing.Point(60, 226)
        Me.redstoneTorchResult.Name = "redstoneTorchResult"
        Me.redstoneTorchResult.Size = New System.Drawing.Size(13, 13)
        Me.redstoneTorchResult.TabIndex = 55
        Me.redstoneTorchResult.Text = "0"
        '
        'cobblestoneResult
        '
        Me.cobblestoneResult.AutoSize = True
        Me.cobblestoneResult.BackColor = System.Drawing.Color.Silver
        Me.cobblestoneResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cobblestoneResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cobblestoneResult.Location = New System.Drawing.Point(132, 226)
        Me.cobblestoneResult.Name = "cobblestoneResult"
        Me.cobblestoneResult.Size = New System.Drawing.Size(13, 13)
        Me.cobblestoneResult.TabIndex = 57
        Me.cobblestoneResult.Text = "0"
        '
        'stoneResult
        '
        Me.stoneResult.AutoSize = True
        Me.stoneResult.BackColor = System.Drawing.Color.Silver
        Me.stoneResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.stoneResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.stoneResult.Location = New System.Drawing.Point(97, 226)
        Me.stoneResult.Name = "stoneResult"
        Me.stoneResult.Size = New System.Drawing.Size(13, 13)
        Me.stoneResult.TabIndex = 56
        Me.stoneResult.Text = "0"
        '
        'bowResult
        '
        Me.bowResult.AutoSize = True
        Me.bowResult.BackColor = System.Drawing.Color.Silver
        Me.bowResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bowResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bowResult.Location = New System.Drawing.Point(203, 226)
        Me.bowResult.Name = "bowResult"
        Me.bowResult.Size = New System.Drawing.Size(13, 13)
        Me.bowResult.TabIndex = 59
        Me.bowResult.Text = "0"
        '
        'ironIngotResult
        '
        Me.ironIngotResult.AutoSize = True
        Me.ironIngotResult.BackColor = System.Drawing.Color.Silver
        Me.ironIngotResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ironIngotResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ironIngotResult.Location = New System.Drawing.Point(168, 226)
        Me.ironIngotResult.Name = "ironIngotResult"
        Me.ironIngotResult.Size = New System.Drawing.Size(13, 13)
        Me.ironIngotResult.TabIndex = 58
        Me.ironIngotResult.Text = "0"
        '
        'quartzResult
        '
        Me.quartzResult.AutoSize = True
        Me.quartzResult.BackColor = System.Drawing.Color.Silver
        Me.quartzResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.quartzResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.quartzResult.Location = New System.Drawing.Point(278, 226)
        Me.quartzResult.Name = "quartzResult"
        Me.quartzResult.Size = New System.Drawing.Size(13, 13)
        Me.quartzResult.TabIndex = 61
        Me.quartzResult.Text = "0"
        '
        'glowstoneResult
        '
        Me.glowstoneResult.AutoSize = True
        Me.glowstoneResult.BackColor = System.Drawing.Color.Silver
        Me.glowstoneResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.glowstoneResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.glowstoneResult.Location = New System.Drawing.Point(239, 226)
        Me.glowstoneResult.Name = "glowstoneResult"
        Me.glowstoneResult.Size = New System.Drawing.Size(13, 13)
        Me.glowstoneResult.TabIndex = 60
        Me.glowstoneResult.Text = "0"
        '
        'glassResult
        '
        Me.glassResult.AutoSize = True
        Me.glassResult.BackColor = System.Drawing.Color.Silver
        Me.glassResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.glassResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.glassResult.Location = New System.Drawing.Point(347, 226)
        Me.glassResult.Name = "glassResult"
        Me.glassResult.Size = New System.Drawing.Size(13, 13)
        Me.glassResult.TabIndex = 63
        Me.glassResult.Text = "0"
        '
        'woodenSlabResult
        '
        Me.woodenSlabResult.AutoSize = True
        Me.woodenSlabResult.BackColor = System.Drawing.Color.Silver
        Me.woodenSlabResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.woodenSlabResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.woodenSlabResult.Location = New System.Drawing.Point(313, 226)
        Me.woodenSlabResult.Name = "woodenSlabResult"
        Me.woodenSlabResult.Size = New System.Drawing.Size(13, 13)
        Me.woodenSlabResult.TabIndex = 62
        Me.woodenSlabResult.Text = "0"
        '
        'woodenPlanksResult
        '
        Me.woodenPlanksResult.AutoSize = True
        Me.woodenPlanksResult.BackColor = System.Drawing.Color.Silver
        Me.woodenPlanksResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.woodenPlanksResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.woodenPlanksResult.Location = New System.Drawing.Point(419, 226)
        Me.woodenPlanksResult.Name = "woodenPlanksResult"
        Me.woodenPlanksResult.Size = New System.Drawing.Size(13, 13)
        Me.woodenPlanksResult.TabIndex = 65
        Me.woodenPlanksResult.Text = "0"
        '
        'slimeResult
        '
        Me.slimeResult.AutoSize = True
        Me.slimeResult.BackColor = System.Drawing.Color.Silver
        Me.slimeResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.slimeResult.ForeColor = System.Drawing.SystemColors.ControlText
        Me.slimeResult.Location = New System.Drawing.Point(385, 226)
        Me.slimeResult.Name = "slimeResult"
        Me.slimeResult.Size = New System.Drawing.Size(13, 13)
        Me.slimeResult.TabIndex = 64
        Me.slimeResult.Text = "0"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(469, 261)
        Me.Controls.Add(Me.woodenPlanksResult)
        Me.Controls.Add(Me.slimeResult)
        Me.Controls.Add(Me.glassResult)
        Me.Controls.Add(Me.woodenSlabResult)
        Me.Controls.Add(Me.quartzResult)
        Me.Controls.Add(Me.glowstoneResult)
        Me.Controls.Add(Me.bowResult)
        Me.Controls.Add(Me.ironIngotResult)
        Me.Controls.Add(Me.cobblestoneResult)
        Me.Controls.Add(Me.stoneResult)
        Me.Controls.Add(Me.redstoneTorchResult)
        Me.Controls.Add(Me.redstoneResult)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.noteblockButton)
        Me.Controls.Add(Me.stickyPistonButton)
        Me.Controls.Add(Me.pistonButton)
        Me.Controls.Add(Me.noteblockAmount)
        Me.Controls.Add(Me.stickyPistonAmount)
        Me.Controls.Add(Me.pistonAmount)
        Me.Controls.Add(Me.outputBackground)
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
        Me.Controls.Add(Me.inputBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainWindow"
        Me.Text = "Redstone'owy kalkulator"
        CType(Me.inputBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.outputBackground, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents inputBackground As PictureBox
    Friend WithEvents outputBackground As PictureBox
    Friend WithEvents noteblockButton As RadioButton
    Friend WithEvents stickyPistonButton As RadioButton
    Friend WithEvents pistonButton As RadioButton
    Friend WithEvents noteblockAmount As TextBox
    Friend WithEvents stickyPistonAmount As TextBox
    Friend WithEvents pistonAmount As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents redstoneResult As Label
    Friend WithEvents redstoneTorchResult As Label
    Friend WithEvents cobblestoneResult As Label
    Friend WithEvents stoneResult As Label
    Friend WithEvents bowResult As Label
    Friend WithEvents ironIngotResult As Label
    Friend WithEvents quartzResult As Label
    Friend WithEvents glowstoneResult As Label
    Friend WithEvents glassResult As Label
    Friend WithEvents woodenSlabResult As Label
    Friend WithEvents woodenPlanksResult As Label
    Friend WithEvents slimeResult As Label
End Class