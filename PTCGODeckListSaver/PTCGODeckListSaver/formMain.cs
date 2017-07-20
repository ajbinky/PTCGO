using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTCGODeckListSaver
{
    public partial class formMain : Form
    {

        string list;
        string deckName;
        string path;
        string selectedPath;
        static Boolean victory;

        public formMain()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedPath == null)
            {
                MessageBox.Show("Enter a path to save files.");
            }
            else
            {
                list = Clipboard.GetText();
                deckName = tbDeckName.Text;
                victory = cbVictory.Checked;
                if (victory)
                {
                    path = selectedPath + "/W - " + deckName;
                }
                else
                {
                    path = selectedPath + "/L - " + deckName;
                }

                saveList(path, 1);
                MessageBox.Show(deckName + " has been saved.");
            }
        }

        private void saveList(string path, int i)
        {

            string incrementedPath = path + " " + i + ".txt";

            if (!File.Exists(incrementedPath))
            {
                StreamWriter write = new StreamWriter(incrementedPath);
                write.Write(list);
                write.Close();
                return;
            } else
            {
                saveList(path, i+1);
            }
            
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                selectedPath = fbd.SelectedPath;
                MessageBox.Show("Text files will be saved to " + fbd.SelectedPath);
            }
        }
    }
}
