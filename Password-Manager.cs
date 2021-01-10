using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Everything_App
{
    public partial class Password_Manager : Form
    {
        public Password_Manager()
        {
            InitializeComponent();
        }

        private void radNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radNo.Checked)
            {
                txtWord.Visible = false;
                txtWord.Text = null;
            }
            else
                txtWord.Visible = true;
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            int passwordLength = GetPasswordLength(txtPasswordLength.Text);
            string enteredWord = GetEnteredWord(txtWord.Text);
            string password = GenerateRandomPassword(passwordLength, enteredWord);
            DisplayInformation(passwordLength, enteredWord, password);
            lblCopyPassword.Visible = true;
        }

        private void DisplayInformation(int passwordLength, string enteredWord, string password)
        {
            txtGenLog.Text += $"Parameters:\n{{\n    Length: {passwordLength}\n    Word: {enteredWord}\n}}\n\n";
            txtGenLog.Text += $"Password:\n";
            txtGenLog.Text += $"{password}\n\n";
            lblPassword.Text = $"{password}";
        }

        private string GenerateRandomPassword(int passwordLength, string enteredWord)
        {
            string pword = null;
            int randomChar;
            char[] characters = new char[] { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M',
                                             'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm',
                                             '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '!', '@', ':', '#', ';', '<', '>', '?', '*', '&', '$', '(', ')', '/', '\\', '.' };
            Random random = new Random();
            //txtGenLog.Text += $"Parameters:\n{{\n    Length: {passwordLength}\n    Word: {enteredWord}\n}}\n";

            if (String.IsNullOrWhiteSpace(enteredWord))
            {
                char[] buffer = new char[passwordLength];
                for (int i = 0; i < passwordLength; i++)
                {
                    randomChar = random.Next(0, characters.Length);
                    buffer[i] = (char)characters[randomChar];
                }
                pword = new string(buffer);
                return pword;
            }
            else
            {
                string concat = enteredWord;
                int subtract = enteredWord.Length;
                char[] buffer = new char[passwordLength - subtract];
                for (int i = 0; i < passwordLength - subtract; i++)
                {
                    randomChar = random.Next(0, characters.Length);
                    buffer[i] = (char)characters[randomChar];
                }
                pword = new string(buffer);
                pword += concat;
                return pword;
            }
        }

        private string GetEnteredWord(string text)
        {
            if (String.IsNullOrWhiteSpace(text))
            {
                return null;
            }
            else
            {
                return text;
            }
        }

        private int GetPasswordLength(string text)
        {
            int length;
            if (String.IsNullOrWhiteSpace(text))
            {
                txtPasswordLength.Text = "Default";
                return 12;
            }
            else
            {
                if (Int32.TryParse(text, out length))
                {
                    //valid
                    return length;
                }
                else
                {
                    //invalid
                    return 12;
                }
            }
        }

        private async void lblCopyPassword_Click(object sender, EventArgs e)
        {
            lblCopyPassword.Visible = false;
            lblCopied.Visible = true;
            lblCopied.Location = new Point(325, 149);
            Clipboard.SetText(lblPassword.Text);
            await Task.Delay(1000);
            lblCopied.Visible = false;
            lblCopied.Location = new Point(378, 149);
            lblCopyPassword.Visible = true;
        }

        private void lblPasswordJokes_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            string[] jokes = { "I was going to change my password to France but its Toulon", "Wasn't hard to guess Forrest Gump's password.\n\n1forrest1", 
                                "Was going to change my password to MilkyTea but apparently that’s too weak.", "I changed my password to BeefStew but the computer told me it wasn’t Stroganoff.",
                                "Changed my password to fortnight but apparently that’s two week.", "Asked the librarian for the wifi password. He said “Sshhhhhh!”\n\n I asked “is that all lower case?",
                                "I tried changing my password to “Twilight”\n\nIt said “Error: contains too many useless characters”",
                                "My girlfriend wanted to have a talk about how childish i am\n\nBut she didnt have the secret password to my pillow fort so she couldnt get in!",
                                "Internet went down last night. My neighbour added a password.", "Enter Password: chucknorris\n\nError: Password too strong",
                                "It's ok password. Im insecure too.", "My email password has been hacked again.\n\nThats the third time ive had to rename my cat",
                                "Enter new password: chicken\n\nError: Password must contain at least one capital.\n\nChicken Kiev",
                                "They say using your pets name as a password is a bad idea..\n\nbut my bcQr#1f!e is just so adorable!",
                                "Husband: Call the ambulance i think im having a heart attack...\n\nWife: (Takes phone) quickly, give me your password...\n\nHusband: Oooh i think im fine now..."};
            int jokeDecider = randomNumber.Next(0, jokes.Length);
            MessageBox.Show($"{jokes[jokeDecider]}");
        }

        private void btnLogDisplay_Click(object sender, EventArgs e)
        {
            string buttonText = btnLogDisplay.Text;

            if (buttonText.ToUpper() == "HIDE LOG")
            {
                this.Size = new Size(837, 570);
                txtGenLog.Visible = false;
                btnLogDisplay.Text = "Show Log";
            }
            else
            {
                this.Size = new Size(1127, 570);
                txtGenLog.Visible = true;
                btnLogDisplay.Text = "Hide Log";
            }
        }

        private void btnPasswordGenerator_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1127, 570);
            btnShrink.Enabled = true;
            btnLogDisplay.Enabled = true;
            tabControl1.Visible = true;
            tabControl1.TabPages.Remove(tabPasswordGenerator);
            tabControl1.TabPages.Add(tabPasswordGenerator);
            btnLogDisplay.PerformClick();
        }

        private void btnShrink_Click(object sender, EventArgs e)
        {
            this.Size = new Size(837, 138);
            btnShrink.Enabled = false;
            btnLogDisplay.Enabled = false;
            tabControl1.Visible = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1127, 570);
            btnShrink.Enabled = true;
            btnLogDisplay.Enabled = true;
            tabControl1.Visible = true;
            tabControl1.TabPages.Remove(tabPasswordGenerator);
        }

        private void btnAddDelete_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1127, 570);
            btnShrink.Enabled = true;
            btnLogDisplay.Enabled = true;
            tabControl1.Visible = true;
            tabControl1.TabPages.Remove(tabPasswordGenerator);
            
        }

        //private void DisplayEmptyFieldInfo(int v, TextBox textbox)
        //{
        //    textbox.ForeColor = Color.Red;
        //    textbox.Font = new Font(this.Font, FontStyle.Bold);

        //    System.Timers.Timer time = new System.Timers.Timer(v);
        //    time.Enabled = false;
        //    time.Elapsed += new ElapsedEventHandler(timeElapsed);
        //    void timeElapsed(object send, ElapsedEventArgs ev)
        //    {
        //        textbox.Text = String.Empty;
        //        textbox.ForeColor = Color.Black;
        //        textbox.Font = new Font(this.Font, FontStyle.Regular);
        //        time.Enabled = false;
        //    }
        //    time.Enabled = true;
        //    textbox.Text = "***Field cannot be blank***";
        //}
    }
}