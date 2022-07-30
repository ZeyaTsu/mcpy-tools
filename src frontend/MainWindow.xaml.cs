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
        // Init variables

        // Area Block Counter
        int x1 = 0;
        int y1 = 0;
        int z1 = 0;
        int x2 = 0;
        int y2 = 0;
        int z2 = 0;
        int afResult = 0;

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
    }
}
