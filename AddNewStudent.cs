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
    public partial class AddNewStudent : Form
    {
        // Creating ArrayList
        public ArrayList allscores = new ArrayList();
        private string myVal;

        public string MyVal
        {
            get { return myVal; }
            set { myVal = value; }
        }

        public AddNewStudent()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            // On Cancel Dispose
            myVal = "";
            this.Dispose();
        }

        private void AddScoreBtn_Click(object sender, EventArgs e)
        {
            // Displaying Score On Add In TextBox
            String score = ScoreTextBox.Text.ToString().Trim();
            {
                   ScoresTextBox.AppendText(score+" ");
                   allscores.Add(score);
            }
        }

        private void ClearScoreBtn_Click(object sender, EventArgs e)
        {
            // Clear All
            allscores.Clear();
            ScoresTextBox.Clear();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            // Check if NameTextBox is not empty after triming all whitespaces
            if (NameTextBox.Text.ToString().Trim() != "" && allscores.Count >= 0)
            {
                // Replace whitespaces with no space and displaying name and scores splited by '|' 
                myVal = NameTextBox.Text.ToString().Trim().Replace(" ","") + " | " + ScoresTextBox.Text.ToString().Trim();
                this.Dispose();
            }
            else
            {
                // Show Message On Empty Name
                MessageBox.Show("You Cannot Add Empty Name.");
            }

        }
    }
}
