namespace EmailAndPasswordValidation_Video12_13_
{
    partial class SignUpForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.Input_panel = new System.Windows.Forms.Panel();
            this.ShowPassword_checkBox = new System.Windows.Forms.CheckBox();
            this.SignUpbutton = new System.Windows.Forms.Button();
            this.ConfirmPassword_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Email_label = new System.Windows.Forms.Label();
            this.ConfirmPassword_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.Email_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Password_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ConfirmPassword_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Input_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Email_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPassword_errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Input_panel
            // 
            this.Input_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input_panel.AutoSize = true;
            this.Input_panel.BackColor = System.Drawing.Color.Transparent;
            this.Input_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Input_panel.Controls.Add(this.ShowPassword_checkBox);
            this.Input_panel.Controls.Add(this.SignUpbutton);
            this.Input_panel.Controls.Add(this.ConfirmPassword_label);
            this.Input_panel.Controls.Add(this.Password_label);
            this.Input_panel.Controls.Add(this.Email_label);
            this.Input_panel.Controls.Add(this.ConfirmPassword_textBox);
            this.Input_panel.Controls.Add(this.Password_textBox);
            this.Input_panel.Controls.Add(this.Email_textBox);
            this.Input_panel.Location = new System.Drawing.Point(98, 77);
            this.Input_panel.Name = "Input_panel";
            this.Input_panel.Padding = new System.Windows.Forms.Padding(50);
            this.Input_panel.Size = new System.Drawing.Size(605, 296);
            this.Input_panel.TabIndex = 0;
            // 
            // ShowPassword_checkBox
            // 
            this.ShowPassword_checkBox.AutoSize = true;
            this.ShowPassword_checkBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowPassword_checkBox.ForeColor = System.Drawing.Color.White;
            this.ShowPassword_checkBox.Location = new System.Drawing.Point(252, 186);
            this.ShowPassword_checkBox.Name = "ShowPassword_checkBox";
            this.ShowPassword_checkBox.Size = new System.Drawing.Size(103, 18);
            this.ShowPassword_checkBox.TabIndex = 4;
            this.ShowPassword_checkBox.Text = "Show Password";
            this.ShowPassword_checkBox.UseVisualStyleBackColor = true;
            this.ShowPassword_checkBox.CheckedChanged += new System.EventHandler(this.ShowPassword_checkBox_CheckedChanged);
            // 
            // SignUpbutton
            // 
            this.SignUpbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignUpbutton.AutoSize = true;
            this.SignUpbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SignUpbutton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignUpbutton.ForeColor = System.Drawing.Color.White;
            this.SignUpbutton.Location = new System.Drawing.Point(271, 204);
            this.SignUpbutton.Name = "SignUpbutton";
            this.SignUpbutton.Size = new System.Drawing.Size(98, 39);
            this.SignUpbutton.TabIndex = 3;
            this.SignUpbutton.Text = "Sign Up";
            this.SignUpbutton.UseVisualStyleBackColor = false;
            this.SignUpbutton.Click += new System.EventHandler(this.SignUpbutton_Click);
            this.SignUpbutton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SignUpbutton_KeyDown);
            // 
            // ConfirmPassword_label
            // 
            this.ConfirmPassword_label.AutoSize = true;
            this.ConfirmPassword_label.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPassword_label.ForeColor = System.Drawing.Color.White;
            this.ConfirmPassword_label.Location = new System.Drawing.Point(47, 149);
            this.ConfirmPassword_label.Name = "ConfirmPassword_label";
            this.ConfirmPassword_label.Size = new System.Drawing.Size(197, 29);
            this.ConfirmPassword_label.TabIndex = 2;
            this.ConfirmPassword_label.Text = "Confirm Password";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password_label.ForeColor = System.Drawing.Color.White;
            this.Password_label.Location = new System.Drawing.Point(47, 103);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(111, 29);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password";
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email_label.ForeColor = System.Drawing.Color.White;
            this.Email_label.Location = new System.Drawing.Point(47, 56);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(77, 29);
            this.Email_label.TabIndex = 2;
            this.Email_label.Text = "E-Mail";
            // 
            // ConfirmPassword_textBox
            // 
            this.ConfirmPassword_textBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPassword_textBox.Location = new System.Drawing.Point(252, 143);
            this.ConfirmPassword_textBox.Name = "ConfirmPassword_textBox";
            this.ConfirmPassword_textBox.Size = new System.Drawing.Size(300, 37);
            this.ConfirmPassword_textBox.TabIndex = 2;
            this.ConfirmPassword_textBox.UseSystemPasswordChar = true;
            this.ConfirmPassword_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfirmPassword_textBox_KeyDown);
            this.ConfirmPassword_textBox.Leave += new System.EventHandler(this.ConfirmPassword_textBox_Leave);
            // 
            // Password_textBox
            // 
            this.Password_textBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_textBox.Location = new System.Drawing.Point(252, 97);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(300, 37);
            this.Password_textBox.TabIndex = 1;
            this.Password_textBox.UseSystemPasswordChar = true;
            this.Password_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_textBox_KeyDown);
            this.Password_textBox.Leave += new System.EventHandler(this.Password_textBox_Leave);
            // 
            // Email_textBox
            // 
            this.Email_textBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email_textBox.Location = new System.Drawing.Point(252, 50);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(300, 37);
            this.Email_textBox.TabIndex = 0;
            this.Email_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Email_textBox_KeyDown);
            this.Email_textBox.Leave += new System.EventHandler(this.Email_textBox_Leave);
            // 
            // Email_errorProvider
            // 
            this.Email_errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Email_errorProvider.ContainerControl = this;
            // 
            // Password_errorProvider
            // 
            this.Password_errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Password_errorProvider.ContainerControl = this;
            // 
            // ConfirmPassword_errorProvider
            // 
            this.ConfirmPassword_errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ConfirmPassword_errorProvider.ContainerControl = this;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmailAndPasswordValidation_Video12_13_.Properties.Resources._1unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Input_panel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            // this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.Input_panel.ResumeLayout(false);
            this.Input_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Email_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPassword_errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Input_panel;
        private Label Email_label;
        private TextBox Email_textBox;
        private Label Password_label;
        private TextBox Password_textBox;
        private Label ConfirmPassword_label;
        private TextBox ConfirmPassword_textBox;
        private Button SignUpbutton;
        private CheckBox ShowPassword_checkBox;
        private ErrorProvider Email_errorProvider;
        private ErrorProvider Password_errorProvider;
        private ErrorProvider ConfirmPassword_errorProvider;
    }
}