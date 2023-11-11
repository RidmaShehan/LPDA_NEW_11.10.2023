namespace LPDA
{
    partial class emailPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emailPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.bodyTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mailAddrTextBox = new System.Windows.Forms.TextBox();
            this.sendButten = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ReadMore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "HELP CENTER";
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.bodyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bodyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyTextBox.Location = new System.Drawing.Point(85, 207);
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.Size = new System.Drawing.Size(1167, 353);
            this.bodyTextBox.TabIndex = 1;
            this.bodyTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Write Your Qustion hear,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Write Your Email hear,";
            // 
            // mailAddrTextBox
            // 
            this.mailAddrTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailAddrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailAddrTextBox.Location = new System.Drawing.Point(85, 629);
            this.mailAddrTextBox.Name = "mailAddrTextBox";
            this.mailAddrTextBox.Size = new System.Drawing.Size(505, 26);
            this.mailAddrTextBox.TabIndex = 5;
            this.mailAddrTextBox.TextChanged += new System.EventHandler(this.mailAddrTextBox_TextChanged);
            // 
            // sendButten
            // 
            this.sendButten.Enabled = false;
            this.sendButten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendButten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButten.Location = new System.Drawing.Point(637, 629);
            this.sendButten.Name = "sendButten";
            this.sendButten.Size = new System.Drawing.Size(109, 26);
            this.sendButten.TabIndex = 6;
            this.sendButten.Text = "S E N D";
            this.sendButten.UseVisualStyleBackColor = true;
            this.sendButten.EnabledChanged += new System.EventHandler(this.mailAddrTextBox_TextChanged);
            this.sendButten.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(86, 719);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1037, 150);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // ReadMore
            // 
            this.ReadMore.AutoSize = true;
            this.ReadMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadMore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ReadMore.Location = new System.Drawing.Point(710, 841);
            this.ReadMore.Name = "ReadMore";
            this.ReadMore.Size = new System.Drawing.Size(84, 16);
            this.ReadMore.TabIndex = 8;
            this.ReadMore.Text = "Read More";
            this.ReadMore.Click += new System.EventHandler(this.label4_Click);
            // 
            // emailPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1575, 986);
            this.Controls.Add(this.ReadMore);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.sendButten);
            this.Controls.Add(this.mailAddrTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bodyTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "emailPanel";
            this.Text = "emailPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox bodyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mailAddrTextBox;
        private System.Windows.Forms.Button sendButten;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label ReadMore;
    }
}