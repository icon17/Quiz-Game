namespace QuizGame
{
    partial class MainForm
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
            this.questionLbl = new System.Windows.Forms.Label();
            this.aBtn = new System.Windows.Forms.Button();
            this.bBtn = new System.Windows.Forms.Button();
            this.dBtn = new System.Windows.Forms.Button();
            this.cBtn = new System.Windows.Forms.Button();
            this.randomBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(76, 102);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(90, 19);
            this.questionLbl.TabIndex = 0;
            this.questionLbl.Text = "Lorem Ipsum";
            // 
            // aBtn
            // 
            this.aBtn.Location = new System.Drawing.Point(80, 243);
            this.aBtn.Name = "aBtn";
            this.aBtn.Size = new System.Drawing.Size(231, 55);
            this.aBtn.TabIndex = 1;
            this.aBtn.Text = "A";
            this.aBtn.UseVisualStyleBackColor = true;
            // 
            // bBtn
            // 
            this.bBtn.Location = new System.Drawing.Point(80, 327);
            this.bBtn.Name = "bBtn";
            this.bBtn.Size = new System.Drawing.Size(231, 55);
            this.bBtn.TabIndex = 2;
            this.bBtn.Text = "B";
            this.bBtn.UseVisualStyleBackColor = true;
            // 
            // dBtn
            // 
            this.dBtn.Location = new System.Drawing.Point(473, 327);
            this.dBtn.Name = "dBtn";
            this.dBtn.Size = new System.Drawing.Size(231, 55);
            this.dBtn.TabIndex = 4;
            this.dBtn.Text = "D";
            this.dBtn.UseVisualStyleBackColor = true;
            // 
            // cBtn
            // 
            this.cBtn.Location = new System.Drawing.Point(473, 243);
            this.cBtn.Name = "cBtn";
            this.cBtn.Size = new System.Drawing.Size(231, 55);
            this.cBtn.TabIndex = 3;
            this.cBtn.Text = "C";
            this.cBtn.UseVisualStyleBackColor = true;
            // 
            // randomBtn
            // 
            this.randomBtn.Location = new System.Drawing.Point(710, 113);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(78, 70);
            this.randomBtn.TabIndex = 5;
            this.randomBtn.Text = "Randomize";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monoid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "[]";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(817, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.dBtn);
            this.Controls.Add(this.cBtn);
            this.Controls.Add(this.bBtn);
            this.Controls.Add(this.aBtn);
            this.Controls.Add(this.questionLbl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Button aBtn;
        private System.Windows.Forms.Button bBtn;
        private System.Windows.Forms.Button dBtn;
        private System.Windows.Forms.Button cBtn;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.Label label1;
    }
}

