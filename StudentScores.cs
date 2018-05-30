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
    public partial class StudentScores : Form
    {
        // Creating a method to add items in StudentScoreListBox
        public void setStudentScoreListBox(string val)
        {
            // Check if val(parameter) is not empty
            if(val != "")
                // If true then add val to listbox
                StudentScoresListBox.Items.Add(val);
        }

        public StudentScores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // On Exit Close Program not only form so not using this
            Close();
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            // Instantiate AddNewStudent form
            AddNewStudent ans = new AddNewStudent();
            this.Hide();
            ans.ShowDialog();
            // On dispose show this(parent) form or hide
            if (ans.IsDisposed)
            {
                this.Show();
            }
            else
            {
                this.Hide();
            }
            // Calling method to add new item in listbox
            setStudentScoreListBox(ans.MyVal);

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {   
            // Check if Selected Index is selected
           if(StudentScoresListBox.SelectedIndex >= 0)
            {
                // Getting selected item value
                string selecteditem = StudentScoresListBox.SelectedItem.ToString();
                // Instantiating New Form Of Tyoe UpdateStudentScore
                UpdateStudentScore uss = new UpdateStudentScore();
                uss.SelectedItemData = selecteditem.ToString();
                uss.SelectedIndex = StudentScoresListBox.SelectedIndex;
                this.Hide();
                uss.ShowDialog();
                if (uss.IsDisposed)
                {
                    this.Show();
                }
                else
                {
                    this.Hide();
                }
                // Check if Selected Index is >= 0 Or Data is not null
                if(uss.MyVal != null && uss.SelectedIndex >= 0)
                {
                StudentScoresListBox.Items.Insert(uss.SelectedIndex, uss.MyVal);
                StudentScoresListBox.Items.RemoveAt(uss.SelectedIndex + 1);
                }
            }
            else
            {
                // Show Box With Message To Select Row
                MessageBox.Show("Please Select An Row To Update It.");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Check if Selected
            if(StudentScoresListBox.SelectedIndex >= 0)
            {
                StudentScoresListBox.Items.RemoveAt(StudentScoresListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please Select A Row To Delete It.");
            }
        }

        private void StudentScoresListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentScoresListBox.SelectedIndex >= 0)
            {
                string selecteditem = StudentScoresListBox.SelectedItem.ToString();
                // Spliting Selected Data Into Name And Score For Doing Math Operations 
                string[] words = selecteditem.Split('|');
                foreach (string word in words)
                {
                    int i = 0; double sum = 0; double j = 0;
                    string[] words1 = word.Split(' ');
                    for (i = 1; i < words1.Length; i++)
                    {
                        double.TryParse(words1[i].ToString().Trim(), out j);
                        sum = sum + j;
                    }
                    ScoreTotalTextBox.Text = sum.ToString();
                    // If Sum > 0 then Count is not 0
                    if(sum > 0)
                    {
                        ScoreCountTextBox.Text = (words1.Length - 1).ToString().Trim();
                    }
                    else
                    {
                    ScoreCountTextBox.Text = 0.ToString();
                    }
                    AvgTextBox.Text = (sum / (words1.Length - 1)).ToString();
                }
            }
        }
    }
}
