namespace Курсовая_работа_Кривая_дракона_
{
    partial class Inform
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
            this.tbInform = new System.Windows.Forms.TabControl();
            this.tb1 = new System.Windows.Forms.TabPage();
            this.rchTxtBox1 = new System.Windows.Forms.RichTextBox();
            this.tb2 = new System.Windows.Forms.TabPage();
            this.rchTxtBox2 = new System.Windows.Forms.RichTextBox();
            this.tbInform.SuspendLayout();
            this.tb1.SuspendLayout();
            this.tb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInform
            // 
            this.tbInform.Controls.Add(this.tb1);
            this.tbInform.Controls.Add(this.tb2);
            this.tbInform.ItemSize = new System.Drawing.Size(200, 18);
            this.tbInform.Location = new System.Drawing.Point(12, 12);
            this.tbInform.Name = "tbInform";
            this.tbInform.SelectedIndex = 0;
            this.tbInform.Size = new System.Drawing.Size(774, 557);
            this.tbInform.TabIndex = 0;
            // 
            // tb1
            // 
            this.tb1.Controls.Add(this.rchTxtBox1);
            this.tb1.Location = new System.Drawing.Point(4, 22);
            this.tb1.Name = "tb1";
            this.tb1.Padding = new System.Windows.Forms.Padding(3);
            this.tb1.Size = new System.Drawing.Size(766, 531);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "Общие сведения";
            this.tb1.UseVisualStyleBackColor = true;
            // 
            // rchTxtBox1
            // 
            this.rchTxtBox1.Location = new System.Drawing.Point(0, 0);
            this.rchTxtBox1.Name = "rchTxtBox1";
            this.rchTxtBox1.Size = new System.Drawing.Size(774, 528);
            this.rchTxtBox1.TabIndex = 0;
            this.rchTxtBox1.Text = "";
            // 
            // tb2
            // 
            this.tb2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tb2.Controls.Add(this.rchTxtBox2);
            this.tb2.Location = new System.Drawing.Point(4, 22);
            this.tb2.Name = "tb2";
            this.tb2.Padding = new System.Windows.Forms.Padding(3);
            this.tb2.Size = new System.Drawing.Size(766, 531);
            this.tb2.TabIndex = 1;
            this.tb2.Text = "Руководство";
            this.tb2.UseVisualStyleBackColor = true;
            // 
            // rchTxtBox2
            // 
            this.rchTxtBox2.Location = new System.Drawing.Point(-4, -2);
            this.rchTxtBox2.Name = "rchTxtBox2";
            this.rchTxtBox2.Size = new System.Drawing.Size(771, 531);
            this.rchTxtBox2.TabIndex = 1;
            this.rchTxtBox2.Text = "";
            // 
            // Inform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 575);
            this.Controls.Add(this.tbInform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Inform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.Inform_Load);
            this.tbInform.ResumeLayout(false);
            this.tb1.ResumeLayout(false);
            this.tb2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbInform;
        private System.Windows.Forms.TabPage tb1;
        private System.Windows.Forms.TabPage tb2;
        private System.Windows.Forms.RichTextBox rchTxtBox1;
        private System.Windows.Forms.RichTextBox rchTxtBox2;
    }
}