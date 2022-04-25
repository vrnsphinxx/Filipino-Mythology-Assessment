using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace CP2ProjectConcept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideSub();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hideSub()
        {
            quizSub.Visible = false;
        }

        private void hideSubMenu()
        {
            if (quizSub.Visible == true)
                quizSub.Visible = false;
        }

        private void showSub(Panel Sub)
        {
            if (Sub.Visible == false)
            {
                hideSubMenu();
                Sub.Visible = true;

            }
            else
                Sub.Visible = false;
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            showSub(quizSub);
        }

        private Form openForm = null;
        private void openNewForm(Form newForm)
        {
            if (openForm != null)
                openForm.Close();
            openForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(newForm);
            pnlChildForm.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quiz1_Click(object sender, EventArgs e)
        {
            openNewForm(new Form2());
            hideSubMenu();          
        }

        private void quiz2_Click(object sender, EventArgs e)
        {
            openNewForm(new quizTF());
            hideSubMenu();
            
        }
    }
}
