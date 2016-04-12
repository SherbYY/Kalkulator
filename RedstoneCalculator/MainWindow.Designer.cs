
using System.Windows.Forms;

namespace RedstoneCalculator
{
    partial class MainWindow : System.Windows.Forms.Form
    {

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        //Required by the Windows Form Designer

        private System.ComponentModel.IContainer components;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.repeaterAmount = new System.Windows.Forms.TextBox();
            this.comparatorAmount = new System.Windows.Forms.TextBox();
            this.dispenserAmount = new System.Windows.Forms.TextBox();
            this.dropperAmount = new System.Windows.Forms.TextBox();
            this.redstoneLampAmount = new System.Windows.Forms.TextBox();
            this.daylightSensorAmount = new System.Windows.Forms.TextBox();
            this.noteblockAmount = new System.Windows.Forms.TextBox();
            this.stickyPistonAmount = new System.Windows.Forms.TextBox();
            this.pistonAmount = new System.Windows.Forms.TextBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.outputBackground = new System.Windows.Forms.PictureBox();
            this.inputBackground = new System.Windows.Forms.PictureBox();
            this.woodenPlanksResult = new RedstoneCalculator.TransparentLabel();
            this.slimeBallsResult = new RedstoneCalculator.TransparentLabel();
            this.glassResult = new RedstoneCalculator.TransparentLabel();
            this.woodenSlabResult = new RedstoneCalculator.TransparentLabel();
            this.quartzResult = new RedstoneCalculator.TransparentLabel();
            this.glowstoneResult = new RedstoneCalculator.TransparentLabel();
            this.bowResult = new RedstoneCalculator.TransparentLabel();
            this.ironIngotResult = new RedstoneCalculator.TransparentLabel();
            this.cobblestoneResult = new RedstoneCalculator.TransparentLabel();
            this.stoneResult = new RedstoneCalculator.TransparentLabel();
            this.redstoneTorchResult = new RedstoneCalculator.TransparentLabel();
            this.redstoneResult = new RedstoneCalculator.TransparentLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // repeaterAmount
            // 
            this.repeaterAmount.BackColor = System.Drawing.Color.Silver;
            this.repeaterAmount.Location = new System.Drawing.Point(67, 98);
            this.repeaterAmount.Name = "repeaterAmount";
            this.repeaterAmount.Size = new System.Drawing.Size(34, 20);
            this.repeaterAmount.TabIndex = 2;
            this.repeaterAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.repeaterAmount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // comparatorAmount
            // 
            this.comparatorAmount.BackColor = System.Drawing.Color.Silver;
            this.comparatorAmount.Location = new System.Drawing.Point(103, 98);
            this.comparatorAmount.Name = "comparatorAmount";
            this.comparatorAmount.Size = new System.Drawing.Size(34, 20);
            this.comparatorAmount.TabIndex = 27;
            this.comparatorAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comparatorAmount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // dispenserAmount
            // 
            this.dispenserAmount.BackColor = System.Drawing.Color.Silver;
            this.dispenserAmount.Location = new System.Drawing.Point(139, 98);
            this.dispenserAmount.Name = "dispenserAmount";
            this.dispenserAmount.Size = new System.Drawing.Size(34, 20);
            this.dispenserAmount.TabIndex = 29;
            this.dispenserAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dispenserAmount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // dropperAmount
            // 
            this.dropperAmount.BackColor = System.Drawing.Color.Silver;
            this.dropperAmount.Location = new System.Drawing.Point(175, 98);
            this.dropperAmount.Name = "dropperAmount";
            this.dropperAmount.Size = new System.Drawing.Size(34, 20);
            this.dropperAmount.TabIndex = 31;
            this.dropperAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dropperAmount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // redstoneLampAmount
            // 
            this.redstoneLampAmount.BackColor = System.Drawing.Color.Silver;
            this.redstoneLampAmount.Location = new System.Drawing.Point(211, 98);
            this.redstoneLampAmount.Name = "redstoneLampAmount";
            this.redstoneLampAmount.Size = new System.Drawing.Size(34, 20);
            this.redstoneLampAmount.TabIndex = 33;
            this.redstoneLampAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.redstoneLampAmount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // daylightSensorAmount
            // 
            this.daylightSensorAmount.BackColor = System.Drawing.Color.Silver;
            this.daylightSensorAmount.Location = new System.Drawing.Point(247, 98);
            this.daylightSensorAmount.Name = "daylightSensorAmount";
            this.daylightSensorAmount.Size = new System.Drawing.Size(34, 20);
            this.daylightSensorAmount.TabIndex = 35;
            this.daylightSensorAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.daylightSensorAmount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // noteblockAmount
            // 
            this.noteblockAmount.BackColor = System.Drawing.Color.Silver;
            this.noteblockAmount.Location = new System.Drawing.Point(355, 98);
            this.noteblockAmount.Name = "noteblockAmount";
            this.noteblockAmount.Size = new System.Drawing.Size(34, 20);
            this.noteblockAmount.TabIndex = 48;
            this.noteblockAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.noteblockAmount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // stickyPistonAmount
            // 
            this.stickyPistonAmount.BackColor = System.Drawing.Color.Silver;
            this.stickyPistonAmount.Location = new System.Drawing.Point(319, 98);
            this.stickyPistonAmount.Name = "stickyPistonAmount";
            this.stickyPistonAmount.Size = new System.Drawing.Size(34, 20);
            this.stickyPistonAmount.TabIndex = 47;
            this.stickyPistonAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stickyPistonAmount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // pistonAmount
            // 
            this.pistonAmount.BackColor = System.Drawing.Color.Silver;
            this.pistonAmount.Location = new System.Drawing.Point(283, 98);
            this.pistonAmount.Name = "pistonAmount";
            this.pistonAmount.Size = new System.Drawing.Size(34, 20);
            this.pistonAmount.TabIndex = 46;
            this.pistonAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pistonAmount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // PictureBox3
            // 
            this.PictureBox3.Location = new System.Drawing.Point(195, 301);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(100, 50);
            this.PictureBox3.TabIndex = 53;
            this.PictureBox3.TabStop = false;
            // 
            // outputBackground
            // 
            this.outputBackground.BackColor = System.Drawing.Color.Transparent;
            this.outputBackground.BackgroundImage = global::RedstoneCalculator.Properties.Resources.OutputBackground;
            this.outputBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.outputBackground.InitialImage = null;
            this.outputBackground.Location = new System.Drawing.Point(3, 139);
            this.outputBackground.Name = "outputBackground";
            this.outputBackground.Size = new System.Drawing.Size(464, 119);
            this.outputBackground.TabIndex = 45;
            this.outputBackground.TabStop = false;
            // 
            // inputBackground
            // 
            this.inputBackground.BackColor = System.Drawing.Color.Transparent;
            this.inputBackground.BackgroundImage = global::RedstoneCalculator.Properties.Resources.InputBackground;
            this.inputBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.inputBackground.InitialImage = null;
            this.inputBackground.Location = new System.Drawing.Point(52, 12);
            this.inputBackground.Name = "inputBackground";
            this.inputBackground.Size = new System.Drawing.Size(354, 118);
            this.inputBackground.TabIndex = 44;
            this.inputBackground.TabStop = false;
            // 
            // woodenPlanksResult
            // 
            this.woodenPlanksResult.BackColor = System.Drawing.Color.Silver;
            this.woodenPlanksResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.woodenPlanksResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.woodenPlanksResult.Location = new System.Drawing.Point(416, 226);
            this.woodenPlanksResult.Name = "woodenPlanksResult";
            this.woodenPlanksResult.Size = new System.Drawing.Size(32, 26);
            this.woodenPlanksResult.TabIndex = 65;
            this.woodenPlanksResult.TabStop = false;
            this.woodenPlanksResult.Text = "...";
            this.woodenPlanksResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // slimeBallsResult
            // 
            this.slimeBallsResult.BackColor = System.Drawing.Color.Silver;
            this.slimeBallsResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.slimeBallsResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.slimeBallsResult.Location = new System.Drawing.Point(380, 226);
            this.slimeBallsResult.Name = "slimeBallsResult";
            this.slimeBallsResult.Size = new System.Drawing.Size(32, 26);
            this.slimeBallsResult.TabIndex = 64;
            this.slimeBallsResult.TabStop = false;
            this.slimeBallsResult.Text = "...";
            this.slimeBallsResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // glassResult
            // 
            this.glassResult.BackColor = System.Drawing.Color.Silver;
            this.glassResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.glassResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.glassResult.Location = new System.Drawing.Point(344, 226);
            this.glassResult.Name = "glassResult";
            this.glassResult.Size = new System.Drawing.Size(32, 26);
            this.glassResult.TabIndex = 63;
            this.glassResult.TabStop = false;
            this.glassResult.Text = "...";
            this.glassResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // woodenSlabResult
            // 
            this.woodenSlabResult.BackColor = System.Drawing.Color.Silver;
            this.woodenSlabResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.woodenSlabResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.woodenSlabResult.Location = new System.Drawing.Point(307, 226);
            this.woodenSlabResult.Name = "woodenSlabResult";
            this.woodenSlabResult.Size = new System.Drawing.Size(32, 26);
            this.woodenSlabResult.TabIndex = 62;
            this.woodenSlabResult.TabStop = false;
            this.woodenSlabResult.Text = "...";
            this.woodenSlabResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quartzResult
            // 
            this.quartzResult.BackColor = System.Drawing.Color.Silver;
            this.quartzResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quartzResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.quartzResult.Location = new System.Drawing.Point(270, 226);
            this.quartzResult.Name = "quartzResult";
            this.quartzResult.Size = new System.Drawing.Size(32, 26);
            this.quartzResult.TabIndex = 61;
            this.quartzResult.TabStop = false;
            this.quartzResult.Text = "...";
            this.quartzResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // glowstoneResult
            // 
            this.glowstoneResult.BackColor = System.Drawing.Color.Silver;
            this.glowstoneResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.glowstoneResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.glowstoneResult.Location = new System.Drawing.Point(234, 226);
            this.glowstoneResult.Name = "glowstoneResult";
            this.glowstoneResult.Size = new System.Drawing.Size(32, 26);
            this.glowstoneResult.TabIndex = 60;
            this.glowstoneResult.TabStop = false;
            this.glowstoneResult.Text = "...";
            this.glowstoneResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bowResult
            // 
            this.bowResult.BackColor = System.Drawing.Color.Silver;
            this.bowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bowResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bowResult.Location = new System.Drawing.Point(198, 226);
            this.bowResult.Name = "bowResult";
            this.bowResult.Size = new System.Drawing.Size(32, 26);
            this.bowResult.TabIndex = 59;
            this.bowResult.TabStop = false;
            this.bowResult.Text = "...";
            this.bowResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ironIngotResult
            // 
            this.ironIngotResult.BackColor = System.Drawing.Color.Silver;
            this.ironIngotResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ironIngotResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ironIngotResult.Location = new System.Drawing.Point(162, 226);
            this.ironIngotResult.Name = "ironIngotResult";
            this.ironIngotResult.Size = new System.Drawing.Size(32, 26);
            this.ironIngotResult.TabIndex = 58;
            this.ironIngotResult.TabStop = false;
            this.ironIngotResult.Text = "...";
            this.ironIngotResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cobblestoneResult
            // 
            this.cobblestoneResult.BackColor = System.Drawing.Color.Silver;
            this.cobblestoneResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cobblestoneResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cobblestoneResult.Location = new System.Drawing.Point(126, 226);
            this.cobblestoneResult.Name = "cobblestoneResult";
            this.cobblestoneResult.Size = new System.Drawing.Size(32, 26);
            this.cobblestoneResult.TabIndex = 57;
            this.cobblestoneResult.TabStop = false;
            this.cobblestoneResult.Text = "...";
            this.cobblestoneResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stoneResult
            // 
            this.stoneResult.BackColor = System.Drawing.Color.Silver;
            this.stoneResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stoneResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stoneResult.Location = new System.Drawing.Point(90, 226);
            this.stoneResult.Name = "stoneResult";
            this.stoneResult.Size = new System.Drawing.Size(32, 26);
            this.stoneResult.TabIndex = 56;
            this.stoneResult.TabStop = false;
            this.stoneResult.Text = "...";
            this.stoneResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redstoneTorchResult
            // 
            this.redstoneTorchResult.BackColor = System.Drawing.Color.Silver;
            this.redstoneTorchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.redstoneTorchResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.redstoneTorchResult.Location = new System.Drawing.Point(54, 226);
            this.redstoneTorchResult.Name = "redstoneTorchResult";
            this.redstoneTorchResult.Size = new System.Drawing.Size(32, 26);
            this.redstoneTorchResult.TabIndex = 55;
            this.redstoneTorchResult.TabStop = false;
            this.redstoneTorchResult.Text = "...";
            this.redstoneTorchResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redstoneResult
            // 
            this.redstoneResult.BackColor = System.Drawing.Color.Silver;
            this.redstoneResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.redstoneResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.redstoneResult.Location = new System.Drawing.Point(19, 226);
            this.redstoneResult.Name = "redstoneResult";
            this.redstoneResult.Size = new System.Drawing.Size(32, 26);
            this.redstoneResult.TabIndex = 54;
            this.redstoneResult.TabStop = false;
            this.redstoneResult.Text = "...";
            this.redstoneResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(18)))), ((int)(((byte)(4)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(469, 261);
            this.Controls.Add(this.woodenPlanksResult);
            this.Controls.Add(this.slimeBallsResult);
            this.Controls.Add(this.glassResult);
            this.Controls.Add(this.woodenSlabResult);
            this.Controls.Add(this.quartzResult);
            this.Controls.Add(this.glowstoneResult);
            this.Controls.Add(this.bowResult);
            this.Controls.Add(this.ironIngotResult);
            this.Controls.Add(this.cobblestoneResult);
            this.Controls.Add(this.stoneResult);
            this.Controls.Add(this.redstoneTorchResult);
            this.Controls.Add(this.redstoneResult);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.noteblockAmount);
            this.Controls.Add(this.stickyPistonAmount);
            this.Controls.Add(this.pistonAmount);
            this.Controls.Add(this.outputBackground);
            this.Controls.Add(this.repeaterAmount);
            this.Controls.Add(this.daylightSensorAmount);
            this.Controls.Add(this.redstoneLampAmount);
            this.Controls.Add(this.dropperAmount);
            this.Controls.Add(this.dispenserAmount);
            this.Controls.Add(this.comparatorAmount);
            this.Controls.Add(this.inputBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(485, 300);
            this.MinimumSize = new System.Drawing.Size(485, 300);
            this.Name = "MainWindow";
            this.Text = "Redstonowy kalkulator";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal TextBox repeaterAmount;
        internal TextBox comparatorAmount;
        internal TextBox dispenserAmount;
        internal TextBox dropperAmount;
        internal TextBox redstoneLampAmount;
        internal TextBox daylightSensorAmount;
        internal PictureBox inputBackground;
        internal PictureBox outputBackground;
        internal TextBox noteblockAmount;
        internal TextBox stickyPistonAmount;
        internal TextBox pistonAmount;
        internal PictureBox PictureBox3;
        internal TransparentLabel redstoneResult;
        internal TransparentLabel redstoneTorchResult;
        internal TransparentLabel cobblestoneResult;
        internal TransparentLabel stoneResult;
        internal TransparentLabel bowResult;
        internal TransparentLabel ironIngotResult;
        internal TransparentLabel quartzResult;
        internal TransparentLabel glowstoneResult;
        internal TransparentLabel glassResult;
        internal TransparentLabel woodenSlabResult;
        internal TransparentLabel woodenPlanksResult;
        internal TransparentLabel slimeBallsResult;
    }
}