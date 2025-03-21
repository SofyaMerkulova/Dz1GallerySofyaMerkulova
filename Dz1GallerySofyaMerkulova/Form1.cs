using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Dz1GallerySofyaMerkulova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> pictures = new Dictionary<string, string>();
        private void downloadingButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictures.Clear();
                    imageSelectionListBox.Items.Clear();
                    using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            string[] linesAndHeadlines = line.Split(',');
                            var path = linesAndHeadlines[0];
                            string title;
                            if (linesAndHeadlines.Length > 1)
                            {
                                title = linesAndHeadlines[1];
                                Console.WriteLine(title);
                            }
                            else
                            {
                                title = "";
                                Console.WriteLine("Заголовка нет");
                            }
                            imageSelectionListBox.Items.Add(path);
                            pictures[path] = title;
                        }
                        imageSelectionListBox.SelectedIndex = imageSelectionListBox.Items.Count > 0 ? 0 : -1;
                    }
                }
            }
        }

        private void headingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (imageSelectionListBox.SelectedItem != null)
            {
                string imagePath = imageSelectionListBox.SelectedItem.ToString();
                pictures[imagePath] = headingTextBox.Text;
            }
        }
        private void imageSelectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imageSelectionListBox.SelectedItem != null)
            {
                string imagePath = imageSelectionListBox.SelectedItem.ToString();
                displayingImagesPictureBox.ImageLocation = imagePath;
                if (pictures.ContainsKey(imagePath))
                {
                    headingTextBox.Text = pictures[imagePath];
                }
                else
                {
                    headingTextBox.Text = "";
                }
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream myStream = saveFileDialog.OpenFile())
                using (StreamWriter writer = new StreamWriter(myStream))
                {
                    foreach (var pathOfPicture in pictures.Keys)
                    {
                        writer.WriteLine($"{pathOfPicture},{pictures[pathOfPicture]}");
                    }

                    MessageBox.Show("Ваш файл сохранен");
                }
            }
        }
    }
}
