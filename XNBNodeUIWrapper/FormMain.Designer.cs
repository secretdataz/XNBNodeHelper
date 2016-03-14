namespace XNBNodeUIWrapper
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Title = new System.Windows.Forms.Label();
            this.SubLabel = new System.Windows.Forms.Label();
            this.UnpackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.RepackerBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(12, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(189, 25);
            this.Title.TabIndex = 12;
            this.Title.Text = "XNBNode Helper";
            // 
            // SubLabel
            // 
            this.SubLabel.AutoSize = true;
            this.SubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SubLabel.ForeColor = System.Drawing.Color.White;
            this.SubLabel.Location = new System.Drawing.Point(207, 18);
            this.SubLabel.Name = "SubLabel";
            this.SubLabel.Size = new System.Drawing.Size(96, 16);
            this.SubLabel.TabIndex = 13;
            this.SubLabel.Text = "by secretdataz";
            // 
            // UnpackBtn
            // 
            this.UnpackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.UnpackBtn.FlatAppearance.BorderSize = 0;
            this.UnpackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnpackBtn.ForeColor = System.Drawing.Color.White;
            this.UnpackBtn.Location = new System.Drawing.Point(47, 60);
            this.UnpackBtn.Name = "UnpackBtn";
            this.UnpackBtn.Size = new System.Drawing.Size(154, 56);
            this.UnpackBtn.TabIndex = 16;
            this.UnpackBtn.Text = "Unpacker";
            this.UnpackBtn.UseVisualStyleBackColor = false;
            this.UnpackBtn.Click += new System.EventHandler(this.UnpackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "https://github.com/secretdataz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(499, 14);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(29, 22);
            this.CloseBtn.TabIndex = 18;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // RepackerBtn
            // 
            this.RepackerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.RepackerBtn.FlatAppearance.BorderSize = 0;
            this.RepackerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepackerBtn.ForeColor = System.Drawing.Color.White;
            this.RepackerBtn.Location = new System.Drawing.Point(341, 60);
            this.RepackerBtn.Name = "RepackerBtn";
            this.RepackerBtn.Size = new System.Drawing.Size(154, 56);
            this.RepackerBtn.TabIndex = 19;
            this.RepackerBtn.Text = "Repacker";
            this.RepackerBtn.UseVisualStyleBackColor = false;
            this.RepackerBtn.Click += new System.EventHandler(this.RepackerBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "alpha 0.1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(540, 142);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RepackerBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnpackBtn);
            this.Controls.Add(this.SubLabel);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label SubLabel;
        private System.Windows.Forms.Button UnpackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button RepackerBtn;
        private System.Windows.Forms.Label label2;
    }
}

