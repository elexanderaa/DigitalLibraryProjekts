namespace DigitalLibrary
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
            this.label1 = new System.Windows.Forms.Label();
            this.addnew = new System.Windows.Forms.Button();
            this.seeall = new System.Windows.Forms.Button();
            this.tobuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(96)))), ((int)(((byte)(73)))));
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(417, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digital Library";
            // 
            // addnew
            // 
            this.addnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(96)))), ((int)(((byte)(73)))));
            this.addnew.FlatAppearance.BorderSize = 0;
            this.addnew.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnew.ForeColor = System.Drawing.Color.White;
            this.addnew.Location = new System.Drawing.Point(542, 326);
            this.addnew.Name = "addnew";
            this.addnew.Size = new System.Drawing.Size(211, 70);
            this.addnew.TabIndex = 1;
            this.addnew.Text = "Add new";
            this.addnew.UseVisualStyleBackColor = false;
            this.addnew.Click += new System.EventHandler(this.addnew_Click);
            // 
            // seeall
            // 
            this.seeall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(96)))), ((int)(((byte)(73)))));
            this.seeall.FlatAppearance.BorderSize = 0;
            this.seeall.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeall.ForeColor = System.Drawing.Color.White;
            this.seeall.Location = new System.Drawing.Point(542, 417);
            this.seeall.Name = "seeall";
            this.seeall.Size = new System.Drawing.Size(211, 70);
            this.seeall.TabIndex = 2;
            this.seeall.Text = "See all";
            this.seeall.UseVisualStyleBackColor = false;
            this.seeall.Click += new System.EventHandler(this.seeall_Click);
            // 
            // tobuy
            // 
            this.tobuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(96)))), ((int)(((byte)(73)))));
            this.tobuy.FlatAppearance.BorderSize = 0;
            this.tobuy.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tobuy.ForeColor = System.Drawing.Color.White;
            this.tobuy.Location = new System.Drawing.Point(542, 504);
            this.tobuy.Name = "tobuy";
            this.tobuy.Size = new System.Drawing.Size(211, 70);
            this.tobuy.TabIndex = 3;
            this.tobuy.Text = "To buy";
            this.tobuy.UseVisualStyleBackColor = false;
            this.tobuy.Click += new System.EventHandler(this.tobuy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DigitalLibrary.Properties.Resources.classic_and_rare_books1;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.tobuy);
            this.Controls.Add(this.seeall);
            this.Controls.Add(this.addnew);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Digital Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addnew;
        private System.Windows.Forms.Button seeall;
        private System.Windows.Forms.Button tobuy;
    }
}

