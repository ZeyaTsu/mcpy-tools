using System;
using System.Collections.Generic;
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
            if (y3 == 0)
            {
                y3 += 1;
            }

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
    }
}
