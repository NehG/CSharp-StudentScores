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
            this.Dispose();
        }

        private void UpdateStudentScore_Load(object sender, EventArgs e)
        {
            string[] words = SelectedItemData.Split('|');
            foreach (string word in words)
            {
                int i; double j;
                string[] words1 = word.Split(' ');
                for (i = 1; i < words1.Length; i++)
                {
                    double.TryParse(words1[i].Trim(), out j);
                    if (j != 0)
                    {
                        UpdateStudentScoreListBox.Items.Add(j);
                        allscores.Add(j);
                    }
                }
                NameTextBox.Text = words[0].ToString().Trim();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
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
            UpdateStudentScoreListBox.Items.Add(ads.MyVal);
            allscores.Add(ads.MyVal);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
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
                UpdateStudentScoreListBox.Items.Insert(SelectedItemIndex, us.MyVal);
                UpdateStudentScoreListBox.Items.RemoveAt(SelectedItemIndex + 1);
                allscores[SelectedItemIndex] = us.MyVal;
            }
            else
            {
                MessageBox.Show("Please Select An Row to Update It.");
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if(UpdateStudentScoreListBox.SelectedIndex >= 0)
            {
            int SelectedItemIndex = UpdateStudentScoreListBox.SelectedIndex;
            UpdateStudentScoreListBox.Items.RemoveAt(SelectedItemIndex);
            allscores.RemoveAt(SelectedItemIndex);
            }
            else
            {
                MessageBox.Show("Please Select An Row To Remove It.");
            }
        }

        private void ClearScoreBtn_Click(object sender, EventArgs e)
        {
            UpdateStudentScoreListBox.Items.Clear();
            allscores.Clear();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            string score = "";
            for(int i = 0; i < UpdateStudentScoreListBox.Items.Count;i++)
            {
                HiddenTextBox.AppendText(score+UpdateStudentScoreListBox.Items[i]+" ");
            }

            if (NameTextBox.Text.ToString().Trim() != "" && allscores.Count >= 0)
            {
                myVal = NameTextBox.Text.ToString().Trim() + " | " + HiddenTextBox.Text.ToString().Trim();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("You Cannot Add Empty Name.");
            }
        }
    }
}
