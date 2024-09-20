namespace CompareFiles
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirstDirectoryPath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSecondDirectoryPath = new System.Windows.Forms.TextBox();
            this.buttonBrowseSecond = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Directory";
            // 
            // textBoxFirstDirectoryPath
            // 
            this.textBoxFirstDirectoryPath.Location = new System.Drawing.Point(73, 19);
            this.textBoxFirstDirectoryPath.Name = "textBoxFirstDirectoryPath";
            this.textBoxFirstDirectoryPath.Size = new System.Drawing.Size(375, 20);
            this.textBoxFirstDirectoryPath.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(477, 19);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "&Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "D&irectory";
            // 
            // textBoxSecondDirectoryPath
            // 
            this.textBoxSecondDirectoryPath.Location = new System.Drawing.Point(73, 45);
            this.textBoxSecondDirectoryPath.Name = "textBoxSecondDirectoryPath";
            this.textBoxSecondDirectoryPath.Size = new System.Drawing.Size(375, 20);
            this.textBoxSecondDirectoryPath.TabIndex = 4;
            // 
            // buttonBrowseSecond
            // 
            this.buttonBrowseSecond.Location = new System.Drawing.Point(477, 45);
            this.buttonBrowseSecond.Name = "buttonBrowseSecond";
            this.buttonBrowseSecond.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseSecond.TabIndex = 5;
            this.buttonBrowseSecond.Text = "B&rowse";
            this.buttonBrowseSecond.UseVisualStyleBackColor = true;
            this.buttonBrowseSecond.Click += new System.EventHandler(this.buttonBrowseSecond_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(477, 251);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(75, 23);
            this.buttonCompare.TabIndex = 9;
            this.buttonCompare.Text = "&Compare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Extension";
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(73, 74);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(375, 20);
            this.textBoxExtension.TabIndex = 7;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(73, 101);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(375, 173);
            this.textBoxResult.TabIndex = 8;
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackgroundImage = global::CompareFiles.Properties.Resources.Iconsmind_Outline_File_Copy_2_16;
            this.buttonCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCopy.Location = new System.Drawing.Point(477, 221);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 24);
            this.buttonCopy.TabIndex = 10;
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 292);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.buttonBrowseSecond);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSecondDirectoryPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFirstDirectoryPath);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Compare Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFirstDirectoryPath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSecondDirectoryPath;
        private System.Windows.Forms.Button buttonBrowseSecond;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonCopy;
    }
}

