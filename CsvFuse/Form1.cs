using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using CsvHelper;

namespace CsvFuse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Generate a filename based on current date.
            String timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssff");
            generatedFileNameTextBox.Text = "FILENAME_" + timeStamp + ".csv";

        }

        /// <summary>
        /// Remove selected file from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                for(int i = listViewCsvFiles.Items.Count -1; i >= 0; i--)
                {
                    if (listViewCsvFiles.Items[i].Selected)
                    {
                        listViewCsvFiles.Items.RemoveAt(i);
                    }
                    
                }
                
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("No valid item was selected.\n\n" + ex);
            }

        }

        /// <summary>
        /// Generates a csv with data from all csv-files in the listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateCsvButtton_Click(object sender, EventArgs e)
        {
            //Get filename
            string filename = "/" + generatedFileNameTextBox.Text;

            //Get save folder
            string savePath;
            using (var browse = new FolderBrowserDialog())
            {
                DialogResult result = browse.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(browse.SelectedPath))
                {
                    savePath = browse.SelectedPath;
                }

                else
                {
                    return; // If we don't choose a save location we don't want to run the reader and writer.
                }
            }

            // Get paths to files
            List<string> files = new List<string>();          
            foreach (ListViewItem item in listViewCsvFiles.Items)
            {
                files.Add(item.SubItems[0].Text);
            }

            foreach (var item in files)
            {                
                using (var stream = new StreamReader(item))
                using (var csv = new CsvReader(stream))
                using (var writer = new StreamWriter(savePath + filename, true))
                using (var output = new CsvWriter(writer))
                {
                    //Read files
                    csv.Configuration.HasHeaderRecord = false;
                    output.Configuration.HasHeaderRecord = false;
                    var records = csv.GetRecords<dynamic>();
                    //Write result to file
                    output.WriteRecords(records);
                }

            }

            
            MessageBox.Show("Finished merging " + files.Count + " files!\n\n" + string.Join("\n", files), "Success!");
            
        }

        /// <summary>
        /// Exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Add files to the listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCsvButtton_Click(object sender, EventArgs e)
        {
            using (var browse = new OpenFileDialog())
            {
                browse.Multiselect = true;
                browse.Filter = "Csv files (*.csv)|*.csv";
                DialogResult result = browse.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(browse.FileName)) 
                {
                    string[] files = browse.FileNames;
                    foreach (var item in files)
                    {
                        listViewCsvFiles.Items.Add(new ListViewItem(item));
                    }

                }
            }
        }
    }
}
