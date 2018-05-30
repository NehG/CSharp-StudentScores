using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class UpdateStudentScore : Form
    {
        // Creating Instance Variables
        public string SelectedItemData;
        public int SelectedIndex;
        private string myVal;
        public ArrayList allscores = new ArrayList();

        public string MyVal
        {
            get { return myVal; }
            set { myVal = value; }
        }

        public UpdateStudentScore()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            // Dispose
            this.Dispose();
        }

        private void UpdateStudentScore_Load(object sender, EventArgs e)
        {
            // Spliting Scores And Name To Add Each Score As An Individual Item Into ListBox
            string[] words = SelectedItemData.Split('|');
            // Working on each splitted word
            foreach (string word in words)
            {
                int i; double j;
                // Spliting Score Seperated by " " Whitespcae
                string[] words1 = word.Split(' ');
                for (i = 1; i < words1.Length; i++)
                {
                    // Convert String To Double
                    double.TryParse(words1[i].Trim(), out j);
                    if (j != 0)
                    {
                        // Adding Each Score As Item To ListBox
                        UpdateStudentScoreListBox.Items.Add(j);
                        allscores.Add(j);
                    }
                }
                // Displaying Name to TextBox
                NameTextBox.Text = words[0].ToString().Trim();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Instantiating New Form Of Type AddScore
            AddScore ads = new AddScore();
            this.Hide();
            ads.ShowDialog();
            if (ads.IsDisposed)
            {
                this.Show();
            }
            else
            {
                this.Hide();
            }
            // Adding Item To ListBox
            UpdateStudentScoreListBox.Items.Add(ads.MyVal);
            allscores.Add(ads.MyVal);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            // Check If Item Is Selected For Updating It
            if (UpdateStudentScoreListBox.SelectedIndex >= 0)
            {
                int SelectedItemIndex = UpdateStudentScoreListBox.SelectedIndex;
                UpdateScore us = new UpdateScore();
                us.preVal = UpdateStudentScoreListBox.SelectedItem.ToString();
                this.Hide();
                us.ShowDialog();
                if (us.IsDisposed)
                {
                    this.Show();
                }
                else
                {
                    this.Hide();
                }
                // Removing Old Item And Adding Item At Same Index
                UpdateStudentScoreListBox.Items.Insert(SelectedItemIndex, us.MyVal);
                UpdateStudentScoreListBox.Items.RemoveAt(SelectedItemIndex + 1);
                allscores[SelectedItemIndex] = us.MyVal;
            }
            else
            {
                // Show Message Box
                MessageBox.Show("Please Select An Row to Update It.");
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            // Remove Selected Index
            if(UpdateStudentScoreListBox.SelectedIndex >= 0)
            {
            int SelectedItemIndex = UpdateStudentScoreListBox.SelectedIndex;
            UpdateStudentScoreListBox.Items.RemoveAt(SelectedItemIndex);
            allscores.RemoveAt(SelectedItemIndex);
            }
            else
            {
                // Show Message If Not Selected Any Row
                MessageBox.Show("Please Select An Row To Remove It.");
            }
        }

        private void ClearScoreBtn_Click(object sender, EventArgs e)
        {
            // Clear All Scores
            UpdateStudentScoreListBox.Items.Clear();
            allscores.Clear();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            // Creating an hidden TextBox to store all scores seperated by space
            string score = "";
            for(int i = 0; i < UpdateStudentScoreListBox.Items.Count;i++)
            {
                HiddenTextBox.AppendText(score+UpdateStudentScoreListBox.Items[i]+" ");
            }
            // Check if NameTextBox is not empty and Score Is greater than 0
            if (NameTextBox.Text.ToString().Trim() != "" && allscores.Count >= 0)
            {
                // Storing Name | Score in format
                myVal = NameTextBox.Text.ToString().Trim() + " | " + HiddenTextBox.Text.ToString().Trim();
                this.Dispose();
            }
            else
            {
                // Show Message
                MessageBox.Show("You Cannot Add Empty Name.");
            }
        }
    }
}
