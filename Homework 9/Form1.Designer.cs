namespace Homework_9
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
            this.loadPictureBox = new System.Windows.Forms.PictureBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.colorListBox = new System.Windows.Forms.ListBox();
            this.loadPictureButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadPictureBox
            // 
            this.loadPictureBox.Location = new System.Drawing.Point(423, 92);
            this.loadPictureBox.Name = "loadPictureBox";
            this.loadPictureBox.Size = new System.Drawing.Size(600, 454);
            this.loadPictureBox.TabIndex = 0;
            this.loadPictureBox.TabStop = false;
            this.loadPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loadPictureBox_MouseClick);
            this.loadPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loadPictureBox_MouseMove);
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.Location = new System.Drawing.Point(12, 108);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(229, 147);
            this.locationListBox.TabIndex = 1;
            // 
            // colorListBox
            // 
            this.colorListBox.FormattingEnabled = true;
            this.colorListBox.Location = new System.Drawing.Point(12, 284);
            this.colorListBox.Name = "colorListBox";
            this.colorListBox.Size = new System.Drawing.Size(229, 147);
            this.colorListBox.TabIndex = 2;
            // 
            // loadPictureButton
            // 
            this.loadPictureButton.Location = new System.Drawing.Point(12, 50);
            this.loadPictureButton.Name = "loadPictureButton";
            this.loadPictureButton.Size = new System.Drawing.Size(75, 23);
            this.loadPictureButton.TabIndex = 3;
            this.loadPictureButton.Text = "Load Picture";
            this.loadPictureButton.UseVisualStyleBackColor = true;
            this.loadPictureButton.Click += new System.EventHandler(this.loadPictureButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 469);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(9, 92);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(167, 13);
            this.locationLabel.TabIndex = 5;
            this.locationLabel.Text = "Location of current pixel of picture";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(12, 268);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(150, 13);
            this.colorLabel.TabIndex = 6;
            this.colorLabel.Text = "Color of current pixel of picture";
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(419, 69);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(210, 20);
            this.promptLabel.TabIndex = 7;
            this.promptLabel.Text = "Load Picture into Application";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 558);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loadPictureButton);
            this.Controls.Add(this.colorListBox);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.loadPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.loadPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loadPictureBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.ListBox colorListBox;
        private System.Windows.Forms.Button loadPictureButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label promptLabel;
    }
}

