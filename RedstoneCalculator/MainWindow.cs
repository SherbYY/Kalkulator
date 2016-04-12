using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RedstoneCalculator
{
    public partial class MainWindow : Form
    {
        private List<TransparentLabel> results = new List<TransparentLabel>();

        public MainWindow()
        {
            InitializeComponent();

            results.Add(redstoneResult);
            results.Add(redstoneTorchResult);
            results.Add(stoneResult);
            results.Add(cobblestoneResult);
            results.Add(ironIngotResult);
            results.Add(bowResult);
            results.Add(glowstoneResult);
            results.Add(quartzResult);
            results.Add(woodenSlabResult);
            results.Add(glassResult);
            results.Add(slimeBallsResult);
            results.Add(woodenPlanksResult);

            byte[] font = Properties.Resources.Minecraftia;
            PrivateFontCollection pfc = new PrivateFontCollection();
            IntPtr pointer = Marshal.AllocCoTaskMem(font.Length);
            Marshal.Copy(font, 0, pointer, font.Length);
            pfc.AddMemoryFont(pointer, font.Length);
            Marshal.FreeCoTaskMem(pointer);
            Font minecraftia = new Font(pfc.Families[0], 10);

            foreach(TransparentLabel label in results)
                label.Font = minecraftia;
        }

        private int getText(TextBox textBox)
        {
            if (textBox.Text == "")
                return 0;
            else
                return int.Parse(textBox.Text);
        }

        private void setText(TransparentLabel label, int number)
        {
            if (number > 999) label.Text = "∞";
            else label.Text = number.ToString();
        }

        private void amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int repeaters = getText(repeaterAmount);
                int comparators = getText(comparatorAmount);
                int dispensers = getText(dispenserAmount);
                int droppers = getText(dropperAmount);
                int redstoneLamps = getText(redstoneLampAmount);
                int daylightSensors = getText(daylightSensorAmount);
                int pistons = getText(pistonAmount);
                int stickyPistons = getText(stickyPistonAmount);
                int noteblocks = getText(noteblockAmount);

                int redstones = 0;
                int redstoneTorches = 0;
                int stones = 0;
                int cobblestones = 0;
                int ironIngots = 0;
                int bows = 0;
                int glowstones = 0;
                int quartzes = 0;
                int woodenSlabs = 0;
                int glasses = 0;
                int slimeBalls = 0;
                int woodenPlanks = 0;

                redstones += repeaters;
                redstoneTorches += repeaters * 2;
                stones += repeaters * 3;

                redstoneTorches += comparators * 3;
                stones += comparators * 3;
                quartzes += comparators;

                redstones += dispensers;
                cobblestones += dispensers * 7;
                bows += dispensers * 1;

                redstones += droppers;
                cobblestones += droppers * 7;

                redstones += redstoneLamps * 4;
                glowstones += redstoneLamps;

                woodenSlabs += daylightSensors * 3;
                quartzes += daylightSensors * 3;
                glasses += daylightSensors * 3;

                redstones += pistons;
                cobblestones += pistons * 4;
                ironIngots += pistons;
                woodenPlanks += pistons * 3;

                redstones += stickyPistons;
                cobblestones += stickyPistons * 4;
                ironIngots += stickyPistons;
                woodenPlanks += stickyPistons * 3;
                slimeBalls += stickyPistons;

                redstones += noteblocks;
                woodenPlanks += noteblocks * 8;

                setText(redstoneResult, redstones);
                setText(redstoneTorchResult, redstoneTorches);
                setText(stoneResult, stones);
                setText(cobblestoneResult, cobblestones);
                setText(ironIngotResult, ironIngots);
                setText(bowResult, bows);
                setText(glowstoneResult, glowstones);
                setText(quartzResult, quartzes);
                setText(woodenSlabResult, woodenSlabs);
                setText(glassResult, glasses);
                setText(slimeBallsResult, slimeBalls);
                setText(woodenPlanksResult, woodenPlanks);
            }
            catch (FormatException)
            {
                foreach (TransparentLabel label in results)
                    label.Text = "...";
            }
        }
    }
}
