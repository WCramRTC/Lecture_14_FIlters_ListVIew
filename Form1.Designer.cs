namespace Lecture_13_FIlters_ListVIew
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
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.ckSunRoof = new System.Windows.Forms.CheckBox();
            this.ckSpoiler = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(29, 12);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(336, 355);
            this.rtbDisplay.TabIndex = 0;
            this.rtbDisplay.Text = "";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(500, 250);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 41);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(450, 124);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(216, 26);
            this.tbSearch.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(125, 389);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 33);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBefore
            // 
            this.txtBefore.Location = new System.Drawing.Point(450, 62);
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.Size = new System.Drawing.Size(216, 26);
            this.txtBefore.TabIndex = 4;
            // 
            // ckSunRoof
            // 
            this.ckSunRoof.AutoSize = true;
            this.ckSunRoof.Location = new System.Drawing.Point(450, 172);
            this.ckSunRoof.Name = "ckSunRoof";
            this.ckSunRoof.Size = new System.Drawing.Size(103, 24);
            this.ckSunRoof.TabIndex = 5;
            this.ckSunRoof.Text = "Sun Roof";
            this.ckSunRoof.UseVisualStyleBackColor = true;
            // 
            // ckSpoiler
            // 
            this.ckSpoiler.AutoSize = true;
            this.ckSpoiler.Location = new System.Drawing.Point(450, 202);
            this.ckSpoiler.Name = "ckSpoiler";
            this.ckSpoiler.Size = new System.Drawing.Size(84, 24);
            this.ckSpoiler.TabIndex = 6;
            this.ckSpoiler.Text = "Spoiler";
            this.ckSpoiler.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckSpoiler);
            this.Controls.Add(this.ckSunRoof);
            this.Controls.Add(this.txtBefore);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rtbDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.CheckBox ckSunRoof;
        private System.Windows.Forms.CheckBox ckSpoiler;
    }
}

