using EmailAndPasswordValidation_Video12_13_.Properties;
using System.Resources;

namespace EmailAndPasswordValidation_Video12_13_
{
    partial class SignUpSuccessful
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpSuccessful));
            this.SignUpSuccessful_lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignUpSuccessful_lable
            // 
            this.SignUpSuccessful_lable.AutoSize = true;
            this.SignUpSuccessful_lable.BackColor = System.Drawing.Color.Transparent;
            this.SignUpSuccessful_lable.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignUpSuccessful_lable.ForeColor = System.Drawing.Color.White;
            this.SignUpSuccessful_lable.Location = new System.Drawing.Point(219, 198);
            this.SignUpSuccessful_lable.Name = "SignUpSuccessful_lable";
            this.SignUpSuccessful_lable.Size = new System.Drawing.Size(362, 54);
            this.SignUpSuccessful_lable.TabIndex = 0;
            this.SignUpSuccessful_lable.Text = "SignUp Successful";
            // 
            // SignUpSuccessful
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmailAndPasswordValidation_Video12_13_.Properties.Resources._1unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignUpSuccessful_lable);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "SignUpSuccessful";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label SignUpSuccessful_lable;
    }
}