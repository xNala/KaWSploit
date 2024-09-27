using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace KaWSploit
{
    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();
            InitializeIconButton();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(AuthenticationService.loggedIn == false)
            {
                if(AuthenticationService.needs2FA == false)
                {
                    //Handle the initial login request 

                    if (emailBox.Text == "" || emailBox.Text == null || !AuthenticationService.IsValidEmail(emailBox.Text))
                    {
                        MessageBox.Show("Please enter an email in the box and make sure it's valid!", "Invalid Email");
                        return;
                    }

                    if (passwordBox.Text == "" || passwordBox.Text == null)
                    {
                        MessageBox.Show("Please enter your password in to the box!", "Empty Password");
                        return;
                    }


                    await AuthenticationService.Login(emailBox.Text, passwordBox.Text);

                    if(AuthenticationService.incorrectCredentials)
                    {
                        accountStatusLabel.Text = "STATUS: INCORRECT CREDENTIALS";
                        return;
                    }
                    else
                    {
                        if (AuthenticationService.needs2FA)
                        {
                            accountStatusLabel.Text = "STATUS: WAITING FOR 2FA | Attempts Left: " + AuthenticationService.attemptsLeft.ToString();
                        }

                        if (AuthenticationService.loggedIn)
                        {
                            accountStatusLabel.Text = "STATUS: CONNECTED";
                        }
                    }


                    return;
                }
                else
                {
                    // Handle the 2FA request

                    if(twoFactorBox.Text == "" || twoFactorBox.Text == null)
                    {
                        MessageBox.Show("This code is going to be in your email!", "Empty 2FA Code");
                        return;
                    }

                    await AuthenticationService.Authenticate(twoFactorBox.Text);
                }

                if (AuthenticationService.needs2FA)
                {
                    accountStatusLabel.Text = "STATUS: WAITING FOR 2FA | Attempts Left: " + AuthenticationService.attemptsLeft.ToString();
                }

                if(AuthenticationService.loggedIn)
                {
                    accountStatusLabel.Text = "STATUS: CONNECTED";
                }
            }
            else
            {
                MessageBox.Show("You have already logged in. Feel free to launch another application instance if you'd like to control more accounts!", "Already Logged In");
            }
        }

        private async void searchPlayerBtn_Click(object sender, EventArgs e)
        {
            if(playerNameTextBox.Text == "" || playerNameTextBox.Text == null)
            {
                MessageBox.Show("Please enter the username of the target you'd like to unload on!", "Invalid target name");
                return;
            }

            await UserProfileService.GetUserIDByUsername(playerNameTextBox.Text);

            if(UserProfileService.usernameFound == false)
            {
                MessageBox.Show("Target not found!", "Invalid target name");
                targetStatusLabel.Text = "Target Status: NOT FOUND";
                return;
            }

            targetStatusLabel.Text = "Target Status: PLAYER FOUND (READY)";
        }

        private async void scoutBtn_Click(object sender, EventArgs e)
        {
            if(UserProfileService.usernameFound == false || UserProfileService.userId == null)
            {
                MessageBox.Show("Please lock on to a target!", "Invalid target");
                return;
            }

            if (UserProfileService.userId.HasValue)
            {
                await AttackServices.Scout(UserProfileService.userId.Value);
            }
            else
            {
                MessageBox.Show("User ID is null, unable to scout.", "Invalid target");
            }

            if (AttackServices.finishedScout)
            {
                MessageBox.Show("Unloaded Scouts!", "Scouts Finished");
            }
        }

        private async void stealBtn_Click(object sender, EventArgs e)
        {
            if (UserProfileService.usernameFound == false || UserProfileService.userId == null)
            {
                MessageBox.Show("Please lock on to a target!", "Invalid target");
                return;
            }

            if (UserProfileService.userId.HasValue)
            {
                await AttackServices.Steal(UserProfileService.userId.Value);
            }
            else
            {
                MessageBox.Show("User ID is null, unable to steal.", "Invalid target");
            }

            if (AttackServices.finishedSteal)
            {
                MessageBox.Show("Unloaded Thiefs!", "Stealing Finished");
            }
        }

        private async void assassinateBtn_Click(object sender, EventArgs e)
        {
            if (UserProfileService.usernameFound == false || UserProfileService.userId == null)
            {
                MessageBox.Show("Please lock on to a target!", "Invalid target");
                return;
            }

            if (UserProfileService.userId.HasValue)
            {
                await AttackServices.Assassinate(UserProfileService.userId.Value);
            }
            else
            {
                MessageBox.Show("User ID is null, unable to assassinate.", "Invalid target");
            }

            if (AttackServices.finishedAssassinate)
            {
                MessageBox.Show("Unloaded Assassins!", "Assassins Finished");
            }
        }

        private async void attackBtn_Click(object sender, EventArgs e)
        {
            if (UserProfileService.usernameFound == false || UserProfileService.userId == null)
            {
                MessageBox.Show("Please lock on to a target!", "Invalid target");
                return;
            }


            if (UserProfileService.userId.HasValue)
            {
                await AttackServices.Attack(UserProfileService.userId.Value);
            }
            else
            {
                MessageBox.Show("User ID is null, unable to attack.", "Invalid target");
            }

            if (AttackServices.finishedAttack)
            {
                MessageBox.Show("Unloaded Troops!", "Attacks Finished");
            }

        }














        // Custom dragging controls for the custom header, and the control buttons.


        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private IconButton closeButton;
        private IconButton minimizeButton;

        private void InitializeIconButton()
        {
            // Create the Close Button
            closeButton = new IconButton();
            closeButton.IconChar = IconChar.Times;
            closeButton.IconColor = Color.White;
            closeButton.BackColor = Color.Transparent;
            closeButton.IconSize = 24;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Size = new Size(40, 30);
            closeButton.Location = new Point(this.ClientSize.Width - closeButton.Width, 0);
            closeButton.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            closeButton.Click += CloseButton_Click;
            closeButton.MouseEnter += (sender, e) =>
            {
                closeButton.IconColor = Color.White;
                closeButton.BackColor = Color.DarkGray;  // Change background on hover
            };
            closeButton.MouseLeave += (sender, e) =>
            {
                closeButton.IconColor = Color.White;
                closeButton.BackColor = Color.Transparent;  // Restore background after hover
            };

            // Create the Minimize Button
            minimizeButton = new IconButton();
            minimizeButton.IconChar = IconChar.WindowMinimize;
            minimizeButton.IconColor = Color.White;
            minimizeButton.BackColor = Color.Transparent;
            minimizeButton.IconSize = 24;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.Size = new Size(40, 30);
            minimizeButton.Location = new Point(this.ClientSize.Width - closeButton.Width - minimizeButton.Width, 0);
            minimizeButton.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            minimizeButton.Click += MinimizeButton_Click;
            minimizeButton.MouseEnter += (sender, e) =>
            {
                minimizeButton.IconColor = Color.White;
                minimizeButton.BackColor = Color.DarkGray;  // Change background on hover
            };
            minimizeButton.MouseLeave += (sender, e) =>
            {
                minimizeButton.IconColor = Color.White;
                minimizeButton.BackColor = Color.Transparent;  // Restore background after hover
            };

            // Add buttons to the form
            this.Controls.Add(closeButton);
            this.Controls.Add(minimizeButton);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  // Minimizes the form
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
