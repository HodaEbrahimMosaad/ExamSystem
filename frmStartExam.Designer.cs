
namespace ExamSystem
{
    partial class frmStartExam
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdioanswer4 = new System.Windows.Forms.RadioButton();
            this.rdioanswer3 = new System.Windows.Forms.RadioButton();
            this.lblQuestionBody = new System.Windows.Forms.Label();
            this.rdioanswer2 = new System.Windows.Forms.RadioButton();
            this.rdioanswer1 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdioanswer4);
            this.groupBox1.Controls.Add(this.rdioanswer3);
            this.groupBox1.Controls.Add(this.lblQuestionBody);
            this.groupBox1.Controls.Add(this.rdioanswer2);
            this.groupBox1.Controls.Add(this.rdioanswer1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(14, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1054, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdioanswer4
            // 
            this.rdioanswer4.AutoSize = true;
            this.rdioanswer4.Location = new System.Drawing.Point(25, 446);
            this.rdioanswer4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdioanswer4.Name = "rdioanswer4";
            this.rdioanswer4.Size = new System.Drawing.Size(17, 16);
            this.rdioanswer4.TabIndex = 4;
            this.rdioanswer4.TabStop = true;
            this.rdioanswer4.UseVisualStyleBackColor = true;
            // 
            // rdioanswer3
            // 
            this.rdioanswer3.AutoSize = true;
            this.rdioanswer3.Location = new System.Drawing.Point(25, 375);
            this.rdioanswer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdioanswer3.Name = "rdioanswer3";
            this.rdioanswer3.Size = new System.Drawing.Size(17, 16);
            this.rdioanswer3.TabIndex = 3;
            this.rdioanswer3.TabStop = true;
            this.rdioanswer3.UseVisualStyleBackColor = true;
            // 
            // lblQuestionBody
            // 
            this.lblQuestionBody.AutoSize = true;
            this.lblQuestionBody.Location = new System.Drawing.Point(25, 31);
            this.lblQuestionBody.Name = "lblQuestionBody";
            this.lblQuestionBody.Size = new System.Drawing.Size(0, 20);
            this.lblQuestionBody.TabIndex = 2;
            this.lblQuestionBody.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdioanswer2
            // 
            this.rdioanswer2.AutoSize = true;
            this.rdioanswer2.Location = new System.Drawing.Point(25, 307);
            this.rdioanswer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdioanswer2.Name = "rdioanswer2";
            this.rdioanswer2.Size = new System.Drawing.Size(17, 16);
            this.rdioanswer2.TabIndex = 1;
            this.rdioanswer2.TabStop = true;
            this.rdioanswer2.UseVisualStyleBackColor = true;
            // 
            // rdioanswer1
            // 
            this.rdioanswer1.AutoSize = true;
            this.rdioanswer1.Location = new System.Drawing.Point(25, 237);
            this.rdioanswer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdioanswer1.Name = "rdioanswer1";
            this.rdioanswer1.Size = new System.Drawing.Size(17, 16);
            this.rdioanswer1.TabIndex = 0;
            this.rdioanswer1.TabStop = true;
            this.rdioanswer1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.CadetBlue;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(797, 580);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 31);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(39, 569);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 31);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 38);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1018, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1044, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // frmStartExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStartExam";
            this.Text = "frmStartExam";
            this.Load += new System.EventHandler(this.frmStartExam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQuestionBody;
        private System.Windows.Forms.RadioButton rdioanswer2;
        private System.Windows.Forms.RadioButton rdioanswer1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rdioanswer4;
        private System.Windows.Forms.RadioButton rdioanswer3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}