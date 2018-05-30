using System;
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
    public partial class UpdateScore : Form
    {
        public string preVal;
        private string myVal;

        public string MyVal
        {
            get { return myVal; }
            set { myVal = value; }
        }
        public UpdateScore()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            // Get Data And Store to method
            if(UpdateScoreTextBox.Text.ToString().Trim() != null)
            {
            MyVal = UpdateScoreTextBox.Text.ToString().Trim();
            this.Dispose();
            }
            else
            {
                MessageBox.Show("Empty Score Can't Be Added.");
            }
        }

        private void UpdateScore_Load(object sender, EventArgs e)
        {
            // Loading Previous Value
            UpdateScoreTextBox.Text = preVal.ToString().Trim();
        }
    }
}
