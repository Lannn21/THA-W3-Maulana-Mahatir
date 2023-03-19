namespace THA_W3_MaulanaM.A
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
            this.btnopen = new System.Windows.Forms.Button();
            this.txtartist = new System.Windows.Forms.TextBox();
            this.lblartist = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.chcktrue = new System.Windows.Forms.CheckBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(247, 174);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(122, 23);
            this.btnopen.TabIndex = 0;
            this.btnopen.Text = "Open Next Form";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // txtartist
            // 
            this.txtartist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtartist.Location = new System.Drawing.Point(181, 75);
            this.txtartist.Name = "txtartist";
            this.txtartist.Size = new System.Drawing.Size(290, 30);
            this.txtartist.TabIndex = 12;
            // 
            // lblartist
            // 
            this.lblartist.AutoSize = true;
            this.lblartist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblartist.Location = new System.Drawing.Point(11, 75);
            this.lblartist.Name = "lblartist";
            this.lblartist.Size = new System.Drawing.Size(139, 25);
            this.lblartist.TabIndex = 11;
            this.lblartist.Text = "My Fav Artist";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(181, 28);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(290, 30);
            this.txtname.TabIndex = 10;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(11, 31);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(68, 25);
            this.lblname.TabIndex = 9;
            this.lblname.Text = "Name";
            // 
            // chcktrue
            // 
            this.chcktrue.AutoSize = true;
            this.chcktrue.Location = new System.Drawing.Point(236, 131);
            this.chcktrue.Name = "chcktrue";
            this.chcktrue.Size = new System.Drawing.Size(235, 20);
            this.chcktrue.TabIndex = 13;
            this.chcktrue.Text = "All of the content I put above is true!";
            this.chcktrue.UseVisualStyleBackColor = true;
            this.chcktrue.CheckedChanged += new System.EventHandler(this.chcktrue_CheckedChanged);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Enabled = false;
            this.btnsubmit.Location = new System.Drawing.Point(382, 174);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(89, 23);
            this.btnsubmit.TabIndex = 14;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.chcktrue);
            this.Controls.Add(this.txtartist);
            this.Controls.Add(this.lblartist);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnopen);
            this.Name = "Main";
            this.Text = "Main Window Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.TextBox txtartist;
        private System.Windows.Forms.Label lblartist;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.CheckBox chcktrue;
        private System.Windows.Forms.Button btnsubmit;
    }
}

