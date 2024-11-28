namespace DigitalLibrary
{
    partial class Form2
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
            this.homebutton = new System.Windows.Forms.Button();
            this.authortype = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titletype = new System.Windows.Forms.TextBox();
            this.genretype = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // homebutton
            // 
            this.homebutton.BackColor = System.Drawing.Color.Gray;
            this.homebutton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebutton.ForeColor = System.Drawing.Color.White;
            this.homebutton.Location = new System.Drawing.Point(24, 25);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(72, 37);
            this.homebutton.TabIndex = 0;
            this.homebutton.Text = "Home";
            this.homebutton.UseVisualStyleBackColor = false;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // authortype
            // 
            this.authortype.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authortype.Location = new System.Drawing.Point(476, 185);
            this.authortype.Name = "authortype";
            this.authortype.Size = new System.Drawing.Size(377, 25);
            this.authortype.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(339, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(339, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(339, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(339, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Status";
            // 
            // titletype
            // 
            this.titletype.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titletype.Location = new System.Drawing.Point(476, 253);
            this.titletype.Name = "titletype";
            this.titletype.Size = new System.Drawing.Size(377, 25);
            this.titletype.TabIndex = 6;
            // 
            // genretype
            // 
            this.genretype.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genretype.Location = new System.Drawing.Point(476, 313);
            this.genretype.Name = "genretype";
            this.genretype.Size = new System.Drawing.Size(377, 25);
            this.genretype.TabIndex = 7;
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.Gray;
            this.addbutton.FlatAppearance.BorderSize = 0;
            this.addbutton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(530, 451);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(211, 70);
            this.addbutton.TabIndex = 8;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "To buy",
            "Not read",
            "Read"});
            this.status.Location = new System.Drawing.Point(476, 364);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(168, 28);
            this.status.TabIndex = 9;
            this.status.Text = "Choose";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(96)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.status);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.genretype);
            this.Controls.Add(this.titletype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authortype);
            this.Controls.Add(this.homebutton);
            this.Name = "Form2";
            this.Text = "Digital Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.TextBox authortype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titletype;
        private System.Windows.Forms.TextBox genretype;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.ComboBox status;
    }
}