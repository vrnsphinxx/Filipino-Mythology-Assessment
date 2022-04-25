using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP2ProjectConcept
{
    public partial class quizTF : Form
    {

        public int score = 0;
        public quizTF()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Question 1
        private void q1t_CheckedChanged(object sender, EventArgs e)
        {
            if (q1t.Checked)
            {
                q1t.Image = Properties.Resources._057;
            }
            else
                q1t.Image = null;
        }

        private void q1f_CheckedChanged(object sender, EventArgs e)
        {
            if (q1f.Checked)
            {
                q1f.Image = Properties.Resources._057;
            }
            else
                q1f.Image = null;
        }
        #endregion

        #region Question 2
        private void q2t_CheckedChanged(object sender, EventArgs e)
        {
            if (q2t.Checked)
            {
                q2t.Image = Properties.Resources._057;
            }
            else
                q2t.Image = null;
        }

        private void q2f_CheckedChanged(object sender, EventArgs e)
        {
            if (q2f.Checked)
            {
                q2f.Image = Properties.Resources._057;
            }
            else
                q2f.Image = null;
        }
        #endregion

        #region Question 3
        private void q3T_CheckedChanged(object sender, EventArgs e)
        {
            if (q3T.Checked)
            {
                q3T.Image = Properties.Resources._057;
            }
            else
                q3T.Image = null;
        }

        private void q3F_CheckedChanged(object sender, EventArgs e)
        {
            if (q3F.Checked)
            {
                q3F.Image = Properties.Resources._057;
            }
            else
                q3F.Image = null;
        }
        #endregion

        #region Question 4
        private void q4t_CheckedChanged(object sender, EventArgs e)
        {
            if (q4t.Checked)
            {
                q4t.Image = Properties.Resources._057w;
            }
            else
                q4t.Image = null;
        }

        private void q4f_CheckedChanged(object sender, EventArgs e)
        {

            if (q4f.Checked)
            {
                q4f.Image = Properties.Resources._057w;
            }
            else
                q4f.Image = null;
        }
        #endregion

        #region Question 5
        private void q5t_CheckedChanged(object sender, EventArgs e)
        {
            if (q5t.Checked)
            {
                q5t.Image = Properties.Resources._057;
            }
            else
                q5t.Image = null;
        }

        private void q5f_CheckedChanged(object sender, EventArgs e)
        {

            if (q5f.Checked)
            {
                q5f.Image = Properties.Resources._057;
            }
            else
                q5f.Image = null;
        }
        #endregion

        #region Question 6
        private void q6t_CheckedChanged(object sender, EventArgs e)
        {
            if (q6t.Checked)
            {
                q6t.Image = Properties.Resources._057;
            }
            else
                q6t.Image = null;
        }

        private void q6f_CheckedChanged(object sender, EventArgs e)
        {
            if (q6f.Checked)
            {
                q6f.Image = Properties.Resources._057;
            }
            else
                q6f.Image = null;
        }
        #endregion

        #region Question 7
        private void q7t_CheckedChanged(object sender, EventArgs e)
        {
            if (q7t.Checked)
            {
                q7t.Image = Properties.Resources._057w;
            }
            else
                q7t.Image = null;
        }

        private void q7f_CheckedChanged(object sender, EventArgs e)
        {
            if (q7f.Checked)
            {
                q7f.Image = Properties.Resources._057w;
            }
            else
                q7f.Image = null;
        }
        #endregion

        #region Question 8
        private void q8t_CheckedChanged(object sender, EventArgs e)
        {
            if (q8t.Checked)
            {
                q8t.Image = Properties.Resources._057;
            }
            else
                q8t.Image = null;
        }

        private void q8f_CheckedChanged(object sender, EventArgs e)
        {
            if (q8f.Checked)
            {
                q8f.Image = Properties.Resources._057;
            }
            else
                q8f.Image = null;
        }
        #endregion

        #region Question 9
        private void q9t_CheckedChanged(object sender, EventArgs e)
        {
            if (q9t.Checked)
            {
                q9t.Image = Properties.Resources._057;
            }
            else
                q9t.Image = null;
        }

        private void q9f_CheckedChanged(object sender, EventArgs e)
        {
            if (q9f.Checked)
            {
                q9f.Image = Properties.Resources._057;
            }
            else
                q9f.Image = null;
        }
        #endregion

        #region Question 10
        private void q10t_CheckedChanged(object sender, EventArgs e)
        {
            btnSubmit.Visible = true;
            if (q10t.Checked)
            {
                q10t.Image = Properties.Resources._057;
            }
            else
                q10t.Image = null;
        }

        private void q10f_CheckedChanged(object sender, EventArgs e)
        {
            btnSubmit.Visible = true;
            if (q10f.Checked)
            {
                q10f.Image = Properties.Resources._057;
            }
            else
                q10f.Image = null;
        }

        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double perGrade;
            #region Question 1
            if (q1t.Checked)
            {
                pnlq1.Visible = false;
                ans1.Text = "T";
                ans1.ForeColor = Color.Red;
            }
            else if (q1f.Checked)
            {
                score += 1;
                pnlq1.Visible = false;
                ans1.Text = "F";
                ans1.ForeColor = Color.Lime;
            }
            else
            {
                pnlq1.Visible = false;
                ans1.Text = "N/A";
                ans1.ForeColor = Color.Red;
            }
            #endregion

            #region Question 2
            if (q2t.Checked)
            {
                score += 1;
                contq2.Visible = false;
                ans2.Text = "T";
                ans2.ForeColor = Color.Lime;
            }
            else if (q2f.Checked)
            {
               
                contq2.Visible = false;
                ans2.Text = "F";
                ans2.ForeColor = Color.Red;
            }
            else
            {
                contq2.Visible = false;
                ans2.Text = "N/A";
                ans2.ForeColor = Color.Red;
            }
            #endregion

            #region Question 3
            if (q3T.Checked)
            {
                score += 1;
                contq3.Visible = false;
                ans3.Text = "T";
                ans3.ForeColor = Color.Lime;
            }
            else if (q3F.Checked)
            {
                contq3.Visible = false;
                ans3.Text = "F";
                ans3.ForeColor = Color.Red;
            }
            else
            {
                contq3.Visible = false;
                ans3.Text = "N/A";
                ans3.ForeColor = Color.Red;
            }
            #endregion

            #region Question 4
            if (q4t.Checked)
            {               
                contq4.Visible = false;
                ans4.Text = "T";
                ans4.ForeColor = Color.Red;
            }
            else if (q4f.Checked)
            {
                score += 1;
                contq4.Visible = false;
                ans4.Text = "F";
                ans4.ForeColor = Color.Lime;
            }
            else
            {
                contq4.Visible = false;
                ans4.Text = "N/A";
                ans4.ForeColor = Color.Red;
            }
            #endregion

            #region Question 5
            if (q5t.Checked)
            {
                contq5.Visible = false;
                ans5.Text = "T";
                ans5.ForeColor = Color.Red;
            }
            else if (q5f.Checked)
            {
                score += 1;
                contq5.Visible = false;
                ans5.Text = "F";
                ans5.ForeColor = Color.Lime;
            }
            else
            {
                contq5.Visible = false;
                ans5.Text = "N/A";
                ans5.ForeColor = Color.Red;
            }
            #endregion

            #region Question 6
            if (q6t.Checked)
            {
                contq6.Visible = false;
                ans6.Text = "T";
                ans6.ForeColor = Color.Red;
            }
            else if (q6f.Checked)
            {
                score += 1;
                contq6.Visible = false;
                ans6.Text = "F";
                ans6.ForeColor = Color.Lime;
            }
            else
            {
                contq6.Visible = false;
                ans6.Text = "N/A";
                ans6.ForeColor = Color.Red;
            }
            #endregion

            #region Question 7
            if (q7t.Checked)
            {
                contq7.Visible = false;
                ans7.Text = "T";
                ans7.ForeColor = Color.Red;
            }
            else if (q7f.Checked)
            {
                score += 1;
                contq7.Visible = false;
                ans7.Text = "F";
                ans7.ForeColor = Color.Lime;
            }
            else
            {
                contq7.Visible = false;
                ans7.Text = "N/A";
                ans7.ForeColor = Color.Red;
            }
            #endregion

            #region Question 8
            if (q8t.Checked)
            {
                contq8.Visible = false;
                ans8.Text = "T";
                ans8.ForeColor = Color.Red;
            }
            else if (q8f.Checked)
            {
                score += 1;
                contq8.Visible = false;
                ans8.Text = "F";
                ans8.ForeColor = Color.Lime;
            }
            else
            {
                contq8.Visible = false;
                ans8.Text = "N/A";
                ans8.ForeColor = Color.Red;
            }
            #endregion

            #region Question 9
            if (q9t.Checked)
            {
                score += 1;
                contq9.Visible = false;
                ans9.Text = "T";
                ans9.ForeColor = Color.Lime;
            }
            else if (q9f.Checked)
            {               
                contq9.Visible = false;
                ans9.Text = "F";
                ans9.ForeColor = Color.Red;
            }
            else
            {
                contq9.Visible = false;
                ans9.Text = "N/A";
                ans9.ForeColor = Color.Red;
            }
            #endregion

            #region Question 10
            if (q10t.Checked)
            {
                contq10.Visible = false;
                ans10.Text = "T";
                ans10.ForeColor = Color.Red;
            }
            else if (q10f.Checked)
            {
                score += 1;
                contq10.Visible = false;
                ans10.Text = "F";
                ans10.ForeColor = Color.Lime;
            }
            else
            {
                contq10.Visible = false;
                ans10.Text = "N/A";
                ans10.ForeColor = Color.Red;
            }
            #endregion

            #region Score
            if (score == 10)
            {
                lblScore.Text = "100% You Passed!";
            }
            else if (score == 9)
            {
                lblScore.Text = "95% You Passed!";
            }
            else if (score == 8)
            {
                lblScore.Text = "90% You Passed!";
            }
            else if (score == 7)
            {
                lblScore.Text = "85% You Passed!";
            }
            else if (score == 6)
            {
                lblScore.Text = "80% You Passed!";
            }
            else if (score == 5)
            {
                lblScore.Text = "75% You Passed!";
            }
            else if (score == 4)
            {
                lblScore.Text = "70% Sorry but you failed!";
            }
            else if (score == 3)
            {
                lblScore.Text = "65% Sorry but you failed!";
            }
            else if (score == 2)
            {
                lblScore.Text = "60% Sorry but you failed!";
            }
            else if (score == 1)
            {
                lblScore.Text = "55% Sorry but you failed!";
            }
            else if (score == 0)
            {
                lblScore.Text = "50% Sorry but you failed!";
            }
            #endregion

            this.AutoScroll = false;
            contq1.BackgroundImage = Properties.Resources.tfFinal;
            pnlAnswer.Visible = true;
            lblScore.Visible = true;
        }
    }
}
