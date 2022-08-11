using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MCPy_Tools_GUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Init Best Y Level
            var bestYTextOverworld = "Coal: 95 / 96" + Environment.NewLine +
                "Copper: 47 / 48" + Environment.NewLine +
                "Diamond: -58" + Environment.NewLine +
                "Emerald: 256" + Environment.NewLine +
                "Iron: 42 /232" + Environment.NewLine +
                "Gold: 32 / -64 / -16" + Environment.NewLine +
                "Lapis Lazuli: 0" + Environment.NewLine +
                "Redstone: -58 / -64";
            overworldRichTextBox.Text = bestYTextOverworld;
            var bestYTextNether = "Gold: Everywhere" + Environment.NewLine +
                "Netherite: 11 / 13" + Environment.NewLine +
                "Quartz: 12 / 80";
            netherRichTextBox.Text = bestYTextNether;

            // Init Stronghold Finder
            comboBoxSF.SelectedItem = "North";

            // CanPlaceOn | CanDestroy
            if (radioButtonCC1.IsChecked == true)
            {
                radioButtonCC2.IsChecked = false;
            }
            if (radioButtonCC2.IsChecked == true)
            {
                radioButtonCC1.IsChecked = false;
            }
        }

        // Area Block Counter
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var x = Convert.ToInt32(textBoxAF1.Text);
            var y = Convert.ToInt32(textBoxAF2.Text);
            var z = Convert.ToInt32(textBoxAF3.Text);

            var x2 = Convert.ToInt32(textBoxAF4.Text);
            var y2 = Convert.ToInt32(textBoxAF5.Text);
            var z2 = Convert.ToInt32(textBoxAF6.Text);

            var x3 = x - x2;
            if (x3 < 0)
            {
                x3 = x3 * -1;
            }
            x3 += 1;

            var y3 = y - y2;

            if (y3 < 0)
            {
                y3 = y3 * -1;
            }
            y3 += 1;

            var z3 = z - z2;

            if (z3 < 0)
            {
                z3 = z3 * -1;
            }
            z3 += 1;

            var fi = x3 * z3 * y3;

            string result;
            result = fi.ToString();

            richTextBoxAF.Text = result;
        }

        // Block | Chunk converter
        private void buttonBC1_Click(object sender, RoutedEventArgs e)
        {
            string[] values = { textBoxBlocks.Text };
            foreach (var value in values)
            {
                int number;

                number = Convert.ToInt32(value);
                var result = number / 16;

                bool success = int.TryParse(value, out number);
                if (success)
                {
                    richTextBoxChunks.Text = result.ToString();
                }
            }
        }

        private void buttonBC2_Click(object sender, RoutedEventArgs e)
        {
            string[] values = { textBoxChunks.Text };
            foreach (var value in values)
            {
                int number;

                number = Convert.ToInt32(value);
                var result = number * 16;

                bool success = int.TryParse(value, out number);
                if (success)
                {
                    richTextBoxBlocks.Text = result.ToString();
                }
            }
        }

        // Stronghold Finder
        public void buttonSF2_Click(object sender, RoutedEventArgs e)
        {
            var ThisAngle1 = Convert.ToDouble(textBoxSF1.Text);
            var h0 = 90 - ThisAngle1;
            var h1 = (Math.PI / 180) * h0;
            var h11 = ThisAngle1;
            var h3 = (Math.PI / 180) * h11;

            var ThisAngle2 = Convert.ToDouble(textBoxSF2.Text);
            var h00 = 90 - ThisAngle2;
            var h2 = (Math.PI / 180) * h00;
            var h22 = ThisAngle2;
            var h4 = (Math.PI / 180) * h22;

            double c;

            c = 0;
            
            if (comboBoxSF.Text == "North")
            {
                c = (-310);
            }
            if (comboBoxSF.Text == "South")
            {
                c = 310;
            }
            if (comboBoxSF.Text == "West")
            {
                c = (-310);
            }
            if (comboBoxSF.Text == "East")
            {
                c = 310;
            }

            var xNorthFind = -(c / (Math.Tan(h1) - Math.Tan(h2)));
            var zNorthFind = (c * Math.Tan(h1)) / (Math.Tan(h1) - Math.Tan(h2));

            var aWestFind = (c * Math.Tan(h3)) / (Math.Tan(h3) - Math.Tan(h4));
            var bWestFind = -(c / (Math.Tan(h3) - Math.Tan(h4)));

            if (comboBoxSF.Text == "North" || comboBoxSF.Text == "South")
            {
                richTextBoxSF.Text = "Stronghold found!" + Environment.NewLine +
                "X: " + xNorthFind + Environment.NewLine +
                "Z: " + zNorthFind;
            }
            if (comboBoxSF.Text == "West" || comboBoxSF.Text == "East")
            {
                richTextBoxSF.Text = "Stronghold found!" + Environment.NewLine +
                "X: " + aWestFind + Environment.NewLine +
                "Z: " + bWestFind;
            }
        }

        // CanPlaceOn | CanDestroy
        private void buttonCC_Click(object sender, RoutedEventArgs e)
        {
            var blocklist = new List<string>();
            var mc = "minecraft:";
            
            if (radioButtonCC1.IsChecked == true)
            {
                if (textBoxCC2.Text.Contains(","))
                {
                    // add all blocks to list and show to richtextboxcc
                    var blocks = textBoxCC2.Text.Split(',');
                    foreach (var block in blocks)
                    {
                        blocklist.Add(mc + block);
                    }
                    richTextBoxCC.Text = "/give @s minecraft:" + textBoxCC1.Text + "{CanPlaceOn:[\u0022" + string.Join(",", blocklist) + "\u0022]}";
                }
                else
                {
                    richTextBoxCC.Text = "/give @s minecraft:" + textBoxCC1.Text + "{CanPlaceOn:[\u0022" + mc + textBoxCC2.Text + "\u0022]}";
                }
            }
            else if (radioButtonCC2.IsChecked == true)
            {
                if (textBoxCC2.Text.Contains(","))
                {
                    // add all blocks to list and show to richtextboxcc
                    var blocks = textBoxCC2.Text.Split(',');
                    foreach (var block in blocks)
                    {
                        blocklist.Add(mc + block);
                    }
                    richTextBoxCC.Text = "/give @s minecraft:" + textBoxCC1.Text + "{CanDestroy:[\u0022" + string.Join(",", blocklist) + "\u0022]}";
                }
                else
                {
                    richTextBoxCC.Text = "/give @s minecraft:" + textBoxCC1.Text + "{CanDestroy:[\u0022" + mc + textBoxCC2.Text + "\u0022]}";
                }
            }
        }

        // Perimeter Calculation
        private void buttonPC_Click(object sender, RoutedEventArgs e)
        {
            var x = Convert.ToInt32(textBoxPC1.Text);
            var y = Convert.ToInt32(textBoxPC2.Text);
            var z = Convert.ToInt32(textBoxPC3.Text);

            var x2 = Convert.ToInt32(textBoxPC4.Text);
            var y2 = Convert.ToInt32(textBoxPC5.Text);
            var z2 = Convert.ToInt32(textBoxPC6.Text);

            var x3 = x - x2;
            var y3 = y - y2;
            var z3 = z - z2;

            if (x3 < 0)
            {
                x3 = x3 * -1;
            }
            x3 += 1;

            if (z3 < 0)
            {
                z3 = z3 * -1;
            }
            z3 += 1;

            if (y3 < 0)
            {
                y3 = y3 * -1;
            }
            y3 += 1;

            var per = (2*(x3+z3)) * y3;
            richTextBoxPC.Text = per.ToString() + " Blocks";
        }

        // Mineshaft Mirror
        private void buttonMm_Click(object sender, RoutedEventArgs e)
        {
            var x = Convert.ToInt32(textBoxMm1.Text);
            var y = Convert.ToInt32(textBoxMm2.Text);
            var z = Convert.ToInt32(textBoxMm3.Text);

            var mine_x = x * -1;
            var mine_z = z * -1;

            richTextBoxMm.Text = "Mineshaft found!\nX: " + mine_x + "\nY: " + y +"\nZ: " + mine_z;
        }

        // Distance calculation
        private void buttonDC_Click(object sender, RoutedEventArgs e)
        {
            var x = Convert.ToInt32(textBoxDC1.Text);
            var z = Convert.ToInt32(textBoxDC2.Text);
            var x2 = Convert.ToInt32(textBoxDC3.Text);
            var z2 = Convert.ToInt32(textBoxDC4.Text);

            var x3 = x - x2;
            var z3 = z - z2;

            if (x3 < 0)
            {
                x3 = x3 * -1;
            }
            x3 += 1;

            if (z3 < 0)
            {
                z3 = z3 * -1;
            }
            z3 += 1;
            
            double v = 0;
            
            if (comboBoxDC.Text == "Run")
            {
                v = 5.6;
            }
            else if (comboBoxDC.Text == "Elytra")
            {
                v = 7.2;
            }

            var distance = Math.Sqrt(Math.Pow(x3 - 2, 2) + Math.Pow(z3 - 2, 2));
            var t = distance / v;

            richTextBoxDC.Text = "From X: " + x + " Z: " + z + Environment.NewLine +
                "To X: " + x2 + " Z: " + z2 + Environment.NewLine + Environment.NewLine
                + "Distance: around " + Convert.ToInt32(distance) + " Blocks" + Environment.NewLine +
                "Duration: " + Convert.ToInt32(t) + " seconds" + Environment.NewLine +
                "               " + Convert.ToInt32(t) / 60 + " minutes";
        }

        // Other
        private void aboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog();
        }

        private void closeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
