using System;
using System.Windows.Forms;

namespace RedstoneCalculator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void clearAmounts()
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
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            repeaterAmount.Enabled = false;
            comparatorAmount.Enabled = false;
            dispenserAmount.Enabled = false;
            dropperAmount.Enabled = false;
            redstoneLampAmount.Enabled = false;
            daylightSensorAmount.Enabled = false;
            pistonAmount.Enabled = false;
            stickyPistonAmount.Enabled = false;
            noteblockAmount.Enabled = false;
            clearAmounts();
        }

        private void repeaterButton_CheckedChanged(object sender, EventArgs e)
        {
            repeaterAmount.Enabled = true;
            comparatorAmount.Enabled = false;
            dispenserAmount.Enabled = false;
            dropperAmount.Enabled = false;
            redstoneLampAmount.Enabled = false;
            daylightSensorAmount.Enabled = false;
            pistonAmount.Enabled = false;
            stickyPistonAmount.Enabled = false;
            noteblockAmount.Enabled = false;
            clearAmounts();
        }

        private void comparatorButton_CheckedChanged(object sender, EventArgs e)
        {
            repeaterAmount.Enabled = false;
            comparatorAmount.Enabled = true;
            dispenserAmount.Enabled = false;
            dropperAmount.Enabled = false;
            redstoneLampAmount.Enabled = false;
            daylightSensorAmount.Enabled = false;
            pistonAmount.Enabled = false;
            stickyPistonAmount.Enabled = false;
            noteblockAmount.Enabled = false;
            clearAmounts();
        }

        private void dispenserButton_CheckedChanged(object sender, EventArgs e)
        {
            repeaterAmount.Enabled = false;
            comparatorAmount.Enabled = false;
            dispenserAmount.Enabled = true;
            dropperAmount.Enabled = false;
            redstoneLampAmount.Enabled = false;
            daylightSensorAmount.Enabled = false;
            pistonAmount.Enabled = false;
            stickyPistonAmount.Enabled = false;
            noteblockAmount.Enabled = false;
            clearAmounts();
        }

        private void dropperButton_CheckedChanged(object sender, EventArgs e)
        {
            repeaterAmount.Enabled = false;
            comparatorAmount.Enabled = false;
            dispenserAmount.Enabled = false;
            dropperAmount.Enabled = true;
            redstoneLampAmount.Enabled = false;
            daylightSensorAmount.Enabled = false;
            pistonAmount.Enabled = false;
            stickyPistonAmount.Enabled = false;
            noteblockAmount.Enabled = false;
            clearAmounts();
        }

        private void redstoneLampButton_CheckedChanged(object sender, EventArgs e)
        {
            repeaterAmount.Enabled = false;
            comparatorAmount.Enabled = false;
            dispenserAmount.Enabled = false;
            dropperAmount.Enabled = false;
            redstoneLampAmount.Enabled = true;
            daylightSensorAmount.Enabled = false;
            pistonAmount.Enabled = false;
            stickyPistonAmount.Enabled = false;
            noteblockAmount.Enabled = false;
            clearAmounts();
        }

        private void daylightSensorButton_CheckedChanged(object sender, EventArgs e)
        {
            repeaterAmount.Enabled = false;
            comparatorAmount.Enabled = false;
            dispenserAmount.Enabled = false;
            dropperAmount.Enabled = false;
            redstoneLampAmount.Enabled = false;
            daylightSensorAmount.Enabled = true;
            pistonAmount.Enabled = false;
            stickyPistonAmount.Enabled = false;
            noteblockAmount.Enabled = false;
            clearAmounts();
        }

        private void pistonButton_CheckedChanged(object sender, EventArgs e)
        {
            repeaterAmount.Enabled = false;
            comparatorAmount.Enabled = false;
            dispenserAmount.Enabled = false;
            dropperAmount.Enabled = false;
            redstoneLampAmount.Enabled = false;
            daylightSensorAmount.Enabled = false;
            pistonAmount.Enabled = true;
            stickyPistonAmount.Enabled = false;
            noteblockAmount.Enabled = false;
            clearAmounts();
        }

        private void stickyPistonButton_CheckedChanged(object sender, EventArgs e)
        {
            repeaterAmount.Enabled = false;
            comparatorAmount.Enabled = false;
            dispenserAmount.Enabled = false;
            dropperAmount.Enabled = false;
            redstoneLampAmount.Enabled = false;
            daylightSensorAmount.Enabled = false;
            pistonAmount.Enabled = false;
            stickyPistonAmount.Enabled = true;
            noteblockAmount.Enabled = false;
            clearAmounts();
        }

        private void noteblockButton_CheckedChanged(object sender, EventArgs e)
        {
            repeaterAmount.Enabled = false;
            comparatorAmount.Enabled = false;
            dispenserAmount.Enabled = false;
            dropperAmount.Enabled = false;
            redstoneLampAmount.Enabled = false;
            daylightSensorAmount.Enabled = false;
            pistonAmount.Enabled = false;
            stickyPistonAmount.Enabled = false;
            noteblockAmount.Enabled = true;
            clearAmounts();
        }

        private void repeaterAmount_TextChanged(object sender, EventArgs e)
        {
            redstoneResult.Text = Convert.ToString(int.Parse(repeaterAmount.Text) * 1);
            redstoneTorchResult.Text = Convert.ToString(int.Parse(repeaterAmount.Text) * 2);
            stoneResult.Text = Convert.ToString(int.Parse(repeaterAmount.Text) * 3);
        }

        private void comparatorAmount_TextChanged(object sender, EventArgs e)
        {
            stoneResult.Text = Convert.ToString(int.Parse(comparatorAmount.Text) * 3);
            redstoneTorchResult.Text = Convert.ToString(int.Parse(comparatorAmount.Text) * 3);
            quartzResult.Text = Convert.ToString(int.Parse(comparatorAmount.Text) * 1);
        }

        private void dispenserAmount_TextChanged(object sender, EventArgs e)
        {
            cobblestoneResult.Text = Convert.ToString(int.Parse(dispenserAmount.Text) * 7);
            bowResult.Text = Convert.ToString(int.Parse(dispenserAmount.Text) * 1);
            redstoneResult.Text = Convert.ToString(int.Parse(dispenserAmount.Text) * 1);
        }

        private void dropperAmount_TextChanged(object sender, EventArgs e)
        {
            cobblestoneResult.Text = Convert.ToString(int.Parse(dropperAmount.Text) * 7);
            redstoneResult.Text = Convert.ToString(int.Parse(dropperAmount.Text) * 1);
        }

        private void redstoneLampAmount_TextChanged(object sender, EventArgs e)
        {
            redstoneResult.Text = Convert.ToString(int.Parse(redstoneLampAmount.Text) * 4);
            glowstoneResult.Text = Convert.ToString(int.Parse(redstoneLampAmount.Text) * 1);
        }

        private void daylightSensorAmount_TextChanged(object sender, EventArgs e)
        {
            woodenSlabResult.Text = Convert.ToString(int.Parse(daylightSensorAmount.Text) * 3);
            quartzResult.Text = Convert.ToString(int.Parse(daylightSensorAmount.Text) * 3);
            glassResult.Text = Convert.ToString(int.Parse(daylightSensorAmount.Text) * 3);
        }

        private void pistonAmount_TextChanged(object sender, EventArgs e)
        {
            cobblestoneResult.Text = Convert.ToString(int.Parse(pistonAmount.Text) * 4);
            ironIngotResult.Text = Convert.ToString(int.Parse(pistonAmount.Text) * 1);
            redstoneResult.Text = Convert.ToString(int.Parse(pistonAmount.Text) * 1);
            woodenPlanksResult.Text = Convert.ToString(int.Parse(pistonAmount.Text) * 3);
        }

        private void stickyPistonAmount_TextChanged(object sender, EventArgs e)
        {
            cobblestoneResult.Text = Convert.ToString(int.Parse(stickyPistonAmount.Text) * 4);
            ironIngotResult.Text = Convert.ToString(int.Parse(stickyPistonAmount.Text) * 1);
            redstoneResult.Text = Convert.ToString(int.Parse(stickyPistonAmount.Text) * 1);
            woodenPlanksResult.Text = Convert.ToString(int.Parse(stickyPistonAmount.Text) * 3);
            slimeResult.Text = Convert.ToString(int.Parse(stickyPistonAmount.Text) * 1);
        }

        private void noteblockAmount_TextChanged(object sender, EventArgs e)
        {
            woodenPlanksResult.Text = Convert.ToString(int.Parse(noteblockAmount.Text) * 8);
            redstoneResult.Text = Convert.ToString(int.Parse(noteblockAmount.Text) * 1);
        }
    }
}
