namespace Fishplayer
{
    partial class Player
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
            this.Pause = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.LoadFiles = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.FileView = new System.Windows.Forms.ListView();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(160, 220);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 25);
            this.Pause.TabIndex = 0;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(288, 258);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 25);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(424, 275);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 25);
            this.Next.TabIndex = 2;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            // 
            // LoadFiles
            // 
            this.LoadFiles.Location = new System.Drawing.Point(597, 293);
            this.LoadFiles.Name = "LoadFiles";
            this.LoadFiles.Size = new System.Drawing.Size(75, 25);
            this.LoadFiles.TabIndex = 3;
            this.LoadFiles.Text = "...";
            this.LoadFiles.UseVisualStyleBackColor = true;
            this.LoadFiles.Click += new System.EventHandler(this.LoadFiles_Click);
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(56, 215);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 25);
            this.Previous.TabIndex = 4;
            this.Previous.Text = "Prev";
            this.Previous.UseVisualStyleBackColor = true;
            // 
            // FileView
            // 
            this.FileView.HideSelection = false;
            this.FileView.Location = new System.Drawing.Point(767, 105);
            this.FileView.Name = "FileView";
            this.FileView.Size = new System.Drawing.Size(412, 165);
            this.FileView.TabIndex = 5;
            this.FileView.UseCompatibleStateImageBehavior = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(802, 360);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 144);
            this.listBox1.TabIndex = 6;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1830, 1050);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.FileView);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.LoadFiles);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Pause);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Player";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button LoadFiles;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.ListView FileView;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.ListBox listBox1;
    }
}

