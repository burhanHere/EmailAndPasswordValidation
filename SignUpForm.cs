using System.Text.RegularExpressions;
namespace EmailAndPasswordValidation_Video12_13_
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        string EMailValidationStirng = @"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";
        string PasswordValidationString = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        public static DialogResult result;
        private void Email_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Email_textBox.Text) || !Regex.IsMatch(Email_textBox.Text, EMailValidationStirng))
            {
                Email_errorProvider.SetError(Email_textBox, "Please enter a valid E-Mail.");
            }
            else
            {
                Email_errorProvider.Clear();
            }
        }

        private void Email_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password_textBox.Focus();
            }
        }

        private void Password_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Password_textBox.Text) || !Regex.IsMatch(Password_textBox.Text, PasswordValidationString))
            {
                Password_errorProvider.SetError(Password_textBox, "Your password should contain One upper-case latter, one lower-case latter,one number and one special character.");
            }
            else
            {
                Password_errorProvider.Clear();
            }
        }
        private void Password_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmPassword_textBox.Focus();
            }
        }

        private void ConfirmPassword_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ConfirmPassword_textBox.Text) || ConfirmPassword_textBox.Text != Password_textBox.Text)
            {
                ConfirmPassword_errorProvider.SetError(ConfirmPassword_textBox, "Password does not match!");
            }
            else
            {
                ConfirmPassword_errorProvider.Clear();
            }
        }

        private void ConfirmPassword_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //SignUpbutton.Focus();
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(Email_textBox.Text) && Regex.IsMatch(Email_textBox.Text, EMailValidationStirng) && !string.IsNullOrEmpty(Password_textBox.Text) && Regex.IsMatch(Password_textBox.Text, PasswordValidationString) && !string.IsNullOrEmpty(ConfirmPassword_textBox.Text) && ConfirmPassword_textBox.Text == Password_textBox.Text)
                    {
                        Email_textBox.Clear();
                        Password_textBox.Clear();
                        ConfirmPassword_textBox.Clear();
                        Email_errorProvider.Clear();
                        Password_errorProvider.Clear();
                        ConfirmPassword_errorProvider.Clear();
                        result = MessageBox.Show("SignUp SuccessFul!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        this.Close();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(Email_textBox.Text) || !Regex.IsMatch(Email_textBox.Text, EMailValidationStirng))
                        {
                            Email_errorProvider.SetError(Email_textBox, "Enter a valid E-Mail.");
                        }
                        if (string.IsNullOrEmpty(Password_textBox.Text) || !Regex.IsMatch(Password_textBox.Text, PasswordValidationString))
                        {
                            Password_errorProvider.SetError(Password_textBox, "Your password should contain One upper-case latter, one lower-case latter,one number and one special character.");
                        }
                        if (string.IsNullOrEmpty(ConfirmPassword_textBox.Text) || ConfirmPassword_textBox.Text == Password_textBox.Text)
                        {
                            ConfirmPassword_errorProvider.SetError(ConfirmPassword_textBox, "Password does not match!");
                        }
                    }
                }
            }
        }

        private void ShowPassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Password_textBox.UseSystemPasswordChar = !ShowPassword_checkBox.Checked;
            ConfirmPassword_textBox.UseSystemPasswordChar = !ShowPassword_checkBox.Checked;
        }

        private void SignUpbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Email_textBox.Text) && Regex.IsMatch(Email_textBox.Text, EMailValidationStirng) && !string.IsNullOrEmpty(Password_textBox.Text) && Regex.IsMatch(Password_textBox.Text, PasswordValidationString) && !string.IsNullOrEmpty(ConfirmPassword_textBox.Text) && ConfirmPassword_textBox.Text == Password_textBox.Text)
            {
                Email_textBox.Clear();
                Password_textBox.Clear();
                ConfirmPassword_textBox.Clear();
                Email_errorProvider.Clear();
                Password_errorProvider.Clear();
                ConfirmPassword_errorProvider.Clear();
                result = MessageBox.Show("SignUp SuccessFul!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            else
            {
                if (string.IsNullOrEmpty(Email_textBox.Text) || !Regex.IsMatch(Email_textBox.Text, EMailValidationStirng))
                {
                    Email_errorProvider.SetError(Email_textBox, "Enter a valid E-Mail.");
                }
                if (string.IsNullOrEmpty(Password_textBox.Text) || !Regex.IsMatch(Password_textBox.Text, PasswordValidationString))
                {
                    Password_errorProvider.SetError(Password_textBox, "Your password should contain One upper-case latter, one lower-case latter,one number and one special character.");
                }
                if (string.IsNullOrEmpty(ConfirmPassword_textBox.Text) || ConfirmPassword_textBox.Text == Password_textBox.Text)
                {
                    ConfirmPassword_errorProvider.SetError(ConfirmPassword_textBox, "Password does not match!");
                }
            }
        }

        private void SignUpbutton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(Email_textBox.Text) && Regex.IsMatch(Email_textBox.Text, EMailValidationStirng) && !string.IsNullOrEmpty(Password_textBox.Text) && Regex.IsMatch(Password_textBox.Text, PasswordValidationString) && !string.IsNullOrEmpty(ConfirmPassword_textBox.Text) && ConfirmPassword_textBox.Text == Password_textBox.Text)
                {
                    Email_textBox.Clear();
                    Password_textBox.Clear();
                    ConfirmPassword_textBox.Clear();
                    Email_errorProvider.Clear();
                    Password_errorProvider.Clear();
                    ConfirmPassword_errorProvider.Clear();
                    MessageBox.Show("SignUp SuccessFul!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (string.IsNullOrEmpty(Email_textBox.Text) || !Regex.IsMatch(Email_textBox.Text, EMailValidationStirng))
                    {
                        Email_errorProvider.SetError(Email_textBox, "Enter a valid E-Mail.");
                    }
                    if (string.IsNullOrEmpty(Password_textBox.Text) || !Regex.IsMatch(Password_textBox.Text, PasswordValidationString))
                    {
                        Password_errorProvider.SetError(Password_textBox, "Your password should contain One upper-case latter, one lower-case latter,one number and one special character.");
                    }
                    if (string.IsNullOrEmpty(ConfirmPassword_textBox.Text) || ConfirmPassword_textBox.Text == Password_textBox.Text)
                    {
                        ConfirmPassword_errorProvider.SetError(ConfirmPassword_textBox, "Password does not match!");
                    }
                }
            }
        }
    }
}