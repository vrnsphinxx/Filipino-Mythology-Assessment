
namespace CP2ProjectConcept
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnQuiz = new System.Windows.Forms.Button();
            this.quizSub = new System.Windows.Forms.Panel();
            this.quiz2 = new System.Windows.Forms.Button();
            this.quiz1 = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.quizSub.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuiz
            // 
            this.btnQuiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuiz.FlatAppearance.BorderSize = 0;
            this.btnQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuiz.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnQuiz.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnQuiz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuiz.Location = new System.Drawing.Point(0, 160);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQuiz.Size = new System.Drawing.Size(308, 57);
            this.btnQuiz.TabIndex = 10;
            this.btnQuiz.Text = "ㅤQuizzes";
            this.btnQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuiz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuiz.UseVisualStyleBackColor = true;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // quizSub
            // 
            this.quizSub.BackColor = System.Drawing.Color.Transparent;
            this.quizSub.Controls.Add(this.quiz2);
            this.quizSub.Controls.Add(this.quiz1);
            this.quizSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.quizSub.Location = new System.Drawing.Point(0, 217);
            this.quizSub.Name = "quizSub";
            this.quizSub.Size = new System.Drawing.Size(308, 74);
            this.quizSub.TabIndex = 11;
            // 
            // quiz2
            // 
            this.quiz2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.quiz2.Dock = System.Windows.Forms.DockStyle.Top;
            this.quiz2.FlatAppearance.BorderSize = 0;
            this.quiz2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quiz2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.quiz2.ForeColor = System.Drawing.Color.White;
            this.quiz2.Location = new System.Drawing.Point(0, 37);
            this.quiz2.Name = "quiz2";
            this.quiz2.Size = new System.Drawing.Size(308, 37);
            this.quiz2.TabIndex = 1;
            this.quiz2.Text = "Quiz 2";
            this.quiz2.UseVisualStyleBackColor = false;
            this.quiz2.Click += new System.EventHandler(this.quiz2_Click);
            // 
            // quiz1
            // 
            this.quiz1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.quiz1.Dock = System.Windows.Forms.DockStyle.Top;
            this.quiz1.FlatAppearance.BorderSize = 0;
            this.quiz1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quiz1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.quiz1.ForeColor = System.Drawing.Color.White;
            this.quiz1.Location = new System.Drawing.Point(0, 0);
            this.quiz1.Name = "quiz1";
            this.quiz1.Size = new System.Drawing.Size(308, 37);
            this.quiz1.TabIndex = 0;
            this.quiz1.Text = "Quiz 1";
            this.quiz1.UseVisualStyleBackColor = false;
            this.quiz1.Click += new System.EventHandler(this.quiz1_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(21)))), ((int)(((byte)(9)))));
            this.pnlLeft.Controls.Add(this.quizSub);
            this.pnlLeft.Controls.Add(this.btnQuiz);
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Controls.Add(this.panel1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.ForeColor = System.Drawing.Color.White;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(308, 900);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 841);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(308, 59);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CP2ProjectConcept.Properties.Resources.tulog_pa__3_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 160);
            this.panel1.TabIndex = 0;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlChildForm.BackgroundImage = global::CP2ProjectConcept.Properties.Resources.tulog_pa__3_1;
            this.pnlChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChildForm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.ForeColor = System.Drawing.Color.Black;
            this.pnlChildForm.Location = new System.Drawing.Point(308, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1292, 900);
            this.pnlChildForm.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(99)))), ((int)(((byte)(43)))));
            this.BackgroundImage = global::CP2ProjectConcept.Properties.Resources.mainbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlLeft);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.quizSub.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Panel quizSub;
        private System.Windows.Forms.Button quiz2;
        private System.Windows.Forms.Button quiz1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlChildForm;
    }
}

