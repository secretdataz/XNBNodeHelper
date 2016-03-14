namespace XNBNodeUIWrapper
{
    partial class UnpackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnpackForm));
            this.Title = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SourceFileBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UnpackFileBtn = new System.Windows.Forms.Button();
            this.BrowseSourceFileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UnpackDirBtn = new System.Windows.Forms.Button();
            this.BrowseSourceDirBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceDirBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(264, 25);
            this.Title.TabIndex = 13;
            this.Title.Text = "XNBNode Unpack Mode";
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(450, 9);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(29, 22);
            this.CloseBtn.TabIndex = 19;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SourceFileBox
            // 
            this.SourceFileBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.SourceFileBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SourceFileBox.ForeColor = System.Drawing.Color.White;
            this.SourceFileBox.Location = new System.Drawing.Point(6, 37);
            this.SourceFileBox.Name = "SourceFileBox";
            this.SourceFileBox.Size = new System.Drawing.Size(397, 20);
            this.SourceFileBox.TabIndex = 20;
            this.SourceFileBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UnpackFileBtn);
            this.groupBox1.Controls.Add(this.BrowseSourceFileBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SourceFileBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 102);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Mode";
            // 
            // UnpackFileBtn
            // 
            this.UnpackFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.UnpackFileBtn.FlatAppearance.BorderSize = 0;
            this.UnpackFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnpackFileBtn.ForeColor = System.Drawing.Color.White;
            this.UnpackFileBtn.Location = new System.Drawing.Point(172, 63);
            this.UnpackFileBtn.Name = "UnpackFileBtn";
            this.UnpackFileBtn.Size = new System.Drawing.Size(129, 33);
            this.UnpackFileBtn.TabIndex = 23;
            this.UnpackFileBtn.Text = "Unpack File";
            this.UnpackFileBtn.UseVisualStyleBackColor = false;
            this.UnpackFileBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrowseSourceFileBtn
            // 
            this.BrowseSourceFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.BrowseSourceFileBtn.FlatAppearance.BorderSize = 0;
            this.BrowseSourceFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseSourceFileBtn.ForeColor = System.Drawing.Color.White;
            this.BrowseSourceFileBtn.Location = new System.Drawing.Point(409, 37);
            this.BrowseSourceFileBtn.Name = "BrowseSourceFileBtn";
            this.BrowseSourceFileBtn.Size = new System.Drawing.Size(52, 20);
            this.BrowseSourceFileBtn.TabIndex = 22;
            this.BrowseSourceFileBtn.Text = "Browse";
            this.BrowseSourceFileBtn.UseVisualStyleBackColor = false;
            this.BrowseSourceFileBtn.Click += new System.EventHandler(this.BrowseSourceFileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Source File";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UnpackDirBtn);
            this.groupBox2.Controls.Add(this.BrowseSourceDirBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.SourceDirBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 102);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folder Mode";
            // 
            // UnpackDirBtn
            // 
            this.UnpackDirBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.UnpackDirBtn.FlatAppearance.BorderSize = 0;
            this.UnpackDirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnpackDirBtn.ForeColor = System.Drawing.Color.White;
            this.UnpackDirBtn.Location = new System.Drawing.Point(172, 63);
            this.UnpackDirBtn.Name = "UnpackDirBtn";
            this.UnpackDirBtn.Size = new System.Drawing.Size(129, 33);
            this.UnpackDirBtn.TabIndex = 23;
            this.UnpackDirBtn.Text = "Unpack Directory";
            this.UnpackDirBtn.UseVisualStyleBackColor = false;
            this.UnpackDirBtn.Click += new System.EventHandler(this.UnpackDirBtn_Click);
            // 
            // BrowseSourceDirBtn
            // 
            this.BrowseSourceDirBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.BrowseSourceDirBtn.FlatAppearance.BorderSize = 0;
            this.BrowseSourceDirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseSourceDirBtn.ForeColor = System.Drawing.Color.White;
            this.BrowseSourceDirBtn.Location = new System.Drawing.Point(409, 37);
            this.BrowseSourceDirBtn.Name = "BrowseSourceDirBtn";
            this.BrowseSourceDirBtn.Size = new System.Drawing.Size(52, 20);
            this.BrowseSourceDirBtn.TabIndex = 22;
            this.BrowseSourceDirBtn.Text = "Browse";
            this.BrowseSourceDirBtn.UseVisualStyleBackColor = false;
            this.BrowseSourceDirBtn.Click += new System.EventHandler(this.BrowseSourceDirBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Source Folder";
            // 
            // SourceDirBox
            // 
            this.SourceDirBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.SourceDirBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SourceDirBox.ForeColor = System.Drawing.Color.White;
            this.SourceDirBox.Location = new System.Drawing.Point(6, 37);
            this.SourceDirBox.Name = "SourceDirBox";
            this.SourceDirBox.Size = new System.Drawing.Size(397, 20);
            this.SourceDirBox.TabIndex = 20;
            this.SourceDirBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UnpackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(491, 257);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UnpackForm";
            this.Text = "UnpackForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UnpackForm_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TextBox SourceFileBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UnpackFileBtn;
        private System.Windows.Forms.Button BrowseSourceFileBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button UnpackDirBtn;
        private System.Windows.Forms.Button BrowseSourceDirBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SourceDirBox;
    }
}