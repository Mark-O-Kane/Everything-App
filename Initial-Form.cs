using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Everything_App
{

    //This is a comment from the newly created branch. Hopefully i will not see this in my master.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitialLoad();
        }

        private void InitialLoad()
        {
            lblDayDate.Text = DateTime.Now.ToString("dddd - MMM dd yyy");
            lblUserName.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            lblCurrentWeekNumber.Text = "Current Week Number - " + CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        private void lblMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        } //Minimizing the form
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } //closing the form
        private void lblJoke_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            string[] jokes = { "Where does the General keep his armies?\n\nIn his sleevies", "How does a squid go into battle?\n\nWell-armed.",
                                "Why aren't koalas actual bears?\n\nThey don't meet the koalafications.", "What's E.T. short for?\n\nBecause he's only got little legs.",
                                "What do Alexander the Great and Winnie the Pooh have in common?\n\nSame middle name.", "What did the mayonnaise say when the refrigerator door was opened?\n\nClose the door, I'm dressing.",
                                "I used to be addicted to soap.\n\nBut I'm clean now.", "What did the left eye say to the right eye? Between you and me, something smells.",
                                "What do you call it when Batman skips church?\n\nChristian Bale.", "What's a foot long and slippery?\n\nA slipper.",
                                "They all laughed when I said I wanted to be a comedian.\n\nWell, they're not laughing now!", "I told my physical therapist that I broke my arm in two places.\n\nHe told me to stop going to those places.",
                                "How do you make holy water?\n\nYou boil the hell out of it.", "I was wondering why the ball was getting bigger.\n\nThen it hit me.",
                                "Did you hear about the guy whose whole left side was cut off?\n\nHe's all right now.", "What did the janitor say when he jumped out of the closet?\n\nSUPPLIES!",
                                "What do you call the wife of a hippie?\n\nA Mississippi.", "Today at the bank, an old lady asked me to help check her balance.\n\nSo I pushed her over.",
                                "I told my girlfriend she drew her eyebrows too high.\n\nShe seemed surprised.", "I'm so good at sleeping.\n\nI can do it with my eyes closed.",
                                "My boss told me to have a good day..\n\nso I went home.", "Why is Peter Pan always flying?\n\nHe neverlands.", "What do you call a guy with a rubber toe?\n\nRoberto.",
                                "What do you call a frenchman wearing sandals?\n\nPhillipe Phillope.", "I know a lot of jokes about unemployed people but none of them work.",
                                "Parallel lines have so much in common.\n\nIt’s a shame they’ll never meet.", "What did one hat say to the other?\n\nYou stay here. I’ll go on ahead."};
            int jokeDecider = randomNumber.Next(0, jokes.Length);
            MessageBox.Show($"{jokes[jokeDecider]}");
        } //Spits out random jokes

        private void btnPasswords_Click(object sender, EventArgs e)
        {
            Password_Manager form = new Password_Manager();
            form.Show();
        }
    }
}