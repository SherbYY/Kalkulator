using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RedstoneCalculator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            byte[] font = Properties.Resources.Minecraftia;
            PrivateFontCollection pfc = new PrivateFontCollection();
            IntPtr pointer = Marshal.AllocCoTaskMem(font.Length);
            Marshal.Copy(font, 0, pointer, font.Length);
            pfc.AddMemoryFont(pointer, font.Length);
            Marshal.FreeCoTaskMem(pointer);
            Font minecraftia = new Font(pfc.Families[0], 10);

            redstoneResult.Font = minecraftia;
            redstoneTorchResult.Font = minecraftia;
            stoneResult.Font = minecraftia;
            cobblestoneResult.Font = minecraftia;
            ironIngotResult.Font = minecraftia;
            bowResult.Font = minecraftia;
            glowstoneResult.Font = minecraftia;
            quartzResult.Font = minecraftia;
            woodenSlabResult.Font = minecraftia;
            glassResult.Font = minecraftia;
            slimeResult.Font = minecraftia;
            woodenPlanksResult.Font = minecraftia;
        }

        private void clear(TextBox textBox)
        {
            repeaterAmount.Text = "0";
            comparatorAmount.Text = "0";
            dispenserAmount.Text = "0";
            dropperAmount.Text = "0";
            redstoneLampAmount.Text = "0";
            daylightSensorAmount.Text = "0";
            pistonAmount.Text = "0";
            stickyPistonAmount.Text = "0";
            noteblockAmount.Text = "0";

            repeaterAmount.Enabled = false;
            comparatorAmount.Enabled = false;
            dispenserAmount.Enabled = false;
            dropperAmount.Enabled = false;
            redstoneLampAmount.Enabled = false;
            daylightSensorAmount.Enabled = false;
            pistonAmount.Enabled = false;
            stickyPistonAmount.Enabled = false;
            noteblockAmount.Enabled = false;

            if (textBox != null)
                textBox.Enabled = true;
        }

        private void setText(Control label, int number)
        {
            if (number > 999) label.Text = "∞";
            else label.Text = number.ToString();
        }

        private int getAmount(TextBox textBox)
        {
            try { return int.Parse(textBox.Text); }
            catch (FormatException) { return 0; }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            clear(null);
        }

        #region CheckedChanged

        private void repeaterButton_CheckedChanged(object sender, EventArgs e)
        {
            clear(repeaterAmount);
        }

        private void comparatorButton_CheckedChanged(object sender, EventArgs e)
        {
            clear(comparatorAmount);
        }

        private void dispenserButton_CheckedChanged(object sender, EventArgs e)
        {
            clear(dispenserAmount);
        }

        private void dropperButton_CheckedChanged(object sender, EventArgs e)
        {
            clear(dropperAmount);
        }

        private void redstoneLampButton_CheckedChanged(object sender, EventArgs e)
        {
            clear(redstoneLampAmount);
        }

        private void daylightSensorButton_CheckedChanged(object sender, EventArgs e)
        {
            clear(daylightSensorAmount);
        }

        private void pistonButton_CheckedChanged(object sender, EventArgs e)
        {
            clear(pistonAmount);
        }

        private void stickyPistonButton_CheckedChanged(object sender, EventArgs e)
        {
            clear(stickyPistonAmount);
        }

        private void noteblockButton_CheckedChanged(object sender, EventArgs e)
        {
            clear(noteblockAmount);
        }

        #endregion

        #region TextChanged

        private void repeaterAmount_TextChanged(object sender, EventArgs e)
        {
            int amount = getAmount(repeaterAmount);
            setText(redstoneResult, amount * 1);
            setText(redstoneTorchResult, amount * 2);
            setText(stoneResult, amount * 3);
        }

        private void comparatorAmount_TextChanged(object sender, EventArgs e)
        {
            int amount = getAmount(comparatorAmount);
            setText(stoneResult, amount * 3);
            setText(redstoneTorchResult, amount * 3);
            setText(quartzResult, amount * 1);
        }

        private void dispenserAmount_TextChanged(object sender, EventArgs e)
        {
            int amount = getAmount(dispenserAmount);
            setText(cobblestoneResult, amount * 7);
            setText(bowResult, amount * 1);
            setText(redstoneResult, amount * 1);
        }

        private void dropperAmount_TextChanged(object sender, EventArgs e)
        {
            int amount = getAmount(dropperAmount);
            setText(cobblestoneResult, amount * 7);
            setText(redstoneResult, amount * 1);
        }

        private void redstoneLampAmount_TextChanged(object sender, EventArgs e)
        {
            int amount = getAmount(redstoneLampAmount);
            setText(redstoneResult, amount * 4);
            setText(glowstoneResult, amount * 1);
        }

        private void daylightSensorAmount_TextChanged(object sender, EventArgs e)
        {
            int amount = getAmount(daylightSensorAmount);
            setText(woodenSlabResult, amount * 3);
            setText(quartzResult, amount * 3);
            setText(glassResult, amount * 3);
        }

        private void pistonAmount_TextChanged(object sender, EventArgs e)
        {
            int amount = getAmount(pistonAmount);
            setText(cobblestoneResult, amount * 4);
            setText(ironIngotResult, amount * 1);
            setText(redstoneResult, amount * 1);
            setText(woodenPlanksResult, amount * 3);
        }

        private void stickyPistonAmount_TextChanged(object sender, EventArgs e)
        {
            int amount = getAmount(stickyPistonAmount);
            setText(cobblestoneResult, amount * 4);
            setText(ironIngotResult, amount * 1);
            setText(redstoneResult, amount * 1);
            setText(woodenPlanksResult, amount * 3);
            setText(slimeResult, amount * 1);
        }

        private void noteblockAmount_TextChanged(object sender, EventArgs e)
        {
            int amount = getAmount(noteblockAmount);
            setText(woodenPlanksResult, amount * 8);
            setText(redstoneResult, amount * 1);
        }

        #endregion
    }
}
