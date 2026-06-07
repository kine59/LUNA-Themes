namespace LUNA
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            this.charCountLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.renderButton = new System.Windows.Forms.Button();
            this.themeButton = new System.Windows.Forms.Button();
            this.themeChange1 = new System.Windows.Forms.Button();
            this.themeChange2 = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.LightCyan;
            this.newButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newButton.FlatAppearance.BorderSize = 10;
            this.newButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(109, 8);
            this.newButton.Margin = new System.Windows.Forms.Padding(2);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(60, 32);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightCyan;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(173, 8);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(60, 32);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LUNA.Properties.Resources.luna;
            this.pictureBox1.InitialImage = global::LUNA.Properties.Resources.luna;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(33, 32);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(33, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.LightCyan;
            this.openButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.Location = new System.Drawing.Point(45, 8);
            this.openButton.Margin = new System.Windows.Forms.Padding(2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(60, 32);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // charCountLabel
            // 
            this.charCountLabel.AutoSize = true;
            this.charCountLabel.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charCountLabel.Location = new System.Drawing.Point(7, 384);
            this.charCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.charCountLabel.Name = "charCountLabel";
            this.charCountLabel.Size = new System.Drawing.Size(98, 18);
            this.charCountLabel.TabIndex = 6;
            this.charCountLabel.Text = "characters: ";
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.SeaShell;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(8, 44);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(705, 336);
            this.textBox.TabIndex = 7;
            this.textBox.Text = "";
            this.textBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // renderButton
            // 
            this.renderButton.BackColor = System.Drawing.Color.LightCyan;
            this.renderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.renderButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renderButton.Location = new System.Drawing.Point(237, 8);
            this.renderButton.Margin = new System.Windows.Forms.Padding(2);
            this.renderButton.Name = "renderButton";
            this.renderButton.Size = new System.Drawing.Size(200, 32);
            this.renderButton.TabIndex = 8;
            this.renderButton.Text = "Highlight Markdown";
            this.renderButton.UseVisualStyleBackColor = false;
            this.renderButton.Click += new System.EventHandler(this.render_Click);
            // 
            // themeButton
            // 
            this.themeButton.BackColor = System.Drawing.Color.LightCyan;
            this.themeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.themeButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeButton.Location = new System.Drawing.Point(580, 8);
            this.themeButton.Margin = new System.Windows.Forms.Padding(2);
            this.themeButton.Name = "themeButton";
            this.themeButton.Size = new System.Drawing.Size(101, 32);
            this.themeButton.TabIndex = 10;
            this.themeButton.Text = "Light";
            this.themeButton.UseVisualStyleBackColor = false;
            this.themeButton.Click += new System.EventHandler(this.lightMode_Click);
            // 
            // themeChange1
            // 
            this.themeChange1.BackColor = System.Drawing.Color.LightCyan;
            this.themeChange1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.themeChange1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeChange1.Location = new System.Drawing.Point(548, 8);
            this.themeChange1.Margin = new System.Windows.Forms.Padding(2);
            this.themeChange1.Name = "themeChange1";
            this.themeChange1.Size = new System.Drawing.Size(30, 32);
            this.themeChange1.TabIndex = 11;
            this.themeChange1.Text = "<";
            this.themeChange1.UseVisualStyleBackColor = false;
            this.themeChange1.Click += new System.EventHandler(this.themeChange1_Click);
            // 
            // themeChange2
            // 
            this.themeChange2.BackColor = System.Drawing.Color.LightCyan;
            this.themeChange2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.themeChange2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeChange2.Location = new System.Drawing.Point(683, 8);
            this.themeChange2.Margin = new System.Windows.Forms.Padding(2);
            this.themeChange2.Name = "themeChange2";
            this.themeChange2.Size = new System.Drawing.Size(30, 32);
            this.themeChange2.TabIndex = 12;
            this.themeChange2.Text = ">";
            this.themeChange2.UseVisualStyleBackColor = false;
            this.themeChange2.Click += new System.EventHandler(this.button2_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.LightCyan;
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Location = new System.Drawing.Point(612, 384);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(2);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(101, 32);
            this.aboutButton.TabIndex = 13;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(724, 419);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.themeChange2);
            this.Controls.Add(this.themeChange1);
            this.Controls.Add(this.themeButton);
            this.Controls.Add(this.renderButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.charCountLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "LUNA";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button themeButton;

        private System.Windows.Forms.Button renderButton;

        #endregion
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label charCountLabel;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button themeChange1;
        private System.Windows.Forms.Button themeChange2;
        private System.Windows.Forms.Button aboutButton;
    }
}

