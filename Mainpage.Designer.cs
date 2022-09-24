
namespace thirdpage
{
    partial class Mainpage
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
            this.panelmenu = new System.Windows.Forms.Panel();
            this.help = new System.Windows.Forms.LinkLabel();
            this.Appid = new FontAwesome.Sharp.IconButton();
            this.iconAbout = new FontAwesome.Sharp.IconButton();
            this.iconcontactus = new FontAwesome.Sharp.IconButton();
            this.iconDemo = new FontAwesome.Sharp.IconButton();
            this.iconHome = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.panelmenu.Controls.Add(this.help);
            this.panelmenu.Controls.Add(this.Appid);
            this.panelmenu.Controls.Add(this.iconAbout);
            this.panelmenu.Controls.Add(this.iconcontactus);
            this.panelmenu.Controls.Add(this.iconDemo);
            this.panelmenu.Controls.Add(this.iconHome);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(228, 529);
            this.panelmenu.TabIndex = 0;
            // 
            // help
            // 
            this.help.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.help.AutoSize = true;
            this.help.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(244)))), ((int)(((byte)(164)))));
            this.help.Location = new System.Drawing.Point(76, 506);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(45, 17);
            this.help.TabIndex = 3;
            this.help.TabStop = true;
            this.help.Text = "Help?";
            // 
            // Appid
            // 
            this.Appid.FlatAppearance.BorderSize = 0;
            this.Appid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Appid.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Appid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(244)))), ((int)(((byte)(164)))));
            this.Appid.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.Appid.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(244)))), ((int)(((byte)(164)))));
            this.Appid.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Appid.IconSize = 100;
            this.Appid.Location = new System.Drawing.Point(33, 50);
            this.Appid.Name = "Appid";
            this.Appid.Size = new System.Drawing.Size(151, 118);
            this.Appid.TabIndex = 4;
            this.Appid.Text = "Application ID";
            this.Appid.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Appid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Appid.UseVisualStyleBackColor = true;
            // 
            // iconAbout
            // 
            this.iconAbout.FlatAppearance.BorderSize = 0;
            this.iconAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAbout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(244)))), ((int)(((byte)(164)))));
            this.iconAbout.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconAbout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(244)))), ((int)(((byte)(164)))));
            this.iconAbout.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconAbout.IconSize = 35;
            this.iconAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconAbout.Location = new System.Drawing.Point(15, 320);
            this.iconAbout.Name = "iconAbout";
            this.iconAbout.Size = new System.Drawing.Size(205, 35);
            this.iconAbout.TabIndex = 3;
            this.iconAbout.Text = "About Us";
            this.iconAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconAbout.UseVisualStyleBackColor = true;
            this.iconAbout.Click += new System.EventHandler(this.iconAbout_Click);
            // 
            // iconcontactus
            // 
            this.iconcontactus.FlatAppearance.BorderSize = 0;
            this.iconcontactus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconcontactus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconcontactus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(244)))), ((int)(((byte)(164)))));
            this.iconcontactus.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconcontactus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(244)))), ((int)(((byte)(164)))));
            this.iconcontactus.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconcontactus.IconSize = 35;
            this.iconcontactus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconcontactus.Location = new System.Drawing.Point(15, 370);
            this.iconcontactus.Name = "iconcontactus";
            this.iconcontactus.Size = new System.Drawing.Size(205, 35);
            this.iconcontactus.TabIndex = 2;
            this.iconcontactus.Text = "Contact Us";
            this.iconcontactus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconcontactus.UseVisualStyleBackColor = true;
            this.iconcontactus.Click += new System.EventHandler(this.iconcontactus_Click);
            // 
            // iconDemo
            // 
            this.iconDemo.FlatAppearance.BorderSize = 0;
            this.iconDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDemo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconDemo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(244)))), ((int)(((byte)(164)))));
            this.iconDemo.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconDemo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(244)))), ((int)(((byte)(164)))));
            this.iconDemo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconDemo.IconSize = 35;
            this.iconDemo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconDemo.Location = new System.Drawing.Point(15, 267);
            this.iconDemo.Name = "iconDemo";
            this.iconDemo.Size = new System.Drawing.Size(205, 47);
            this.iconDemo.TabIndex = 1;
            this.iconDemo.Text = "Demo";
            this.iconDemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDemo.UseVisualStyleBackColor = true;
            this.iconDemo.Click += new System.EventHandler(this.iconDemo_Click);
            // 
            // iconHome
            // 
            this.iconHome.FlatAppearance.BorderSize = 0;
            this.iconHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconHome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(244)))), ((int)(((byte)(164)))));
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(244)))), ((int)(((byte)(164)))));
            this.iconHome.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconHome.IconSize = 35;
            this.iconHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconHome.Location = new System.Drawing.Point(15, 226);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(205, 35);
            this.iconHome.TabIndex = 0;
            this.iconHome.Text = "Home";
            this.iconHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconHome.UseVisualStyleBackColor = true;
            this.iconHome.Click += new System.EventHandler(this.iconHome_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(228, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 529);
            this.panel1.TabIndex = 1;
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(51)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1055, 529);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelmenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(244)))), ((int)(((byte)(164)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document Analyzer";
            this.panelmenu.ResumeLayout(false);
            this.panelmenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private FontAwesome.Sharp.IconButton iconHome;
        private FontAwesome.Sharp.IconButton Appid;
        private FontAwesome.Sharp.IconButton iconAbout;
        private FontAwesome.Sharp.IconButton iconcontactus;
        private FontAwesome.Sharp.IconButton iconDemo;
        private System.Windows.Forms.LinkLabel help;
        private System.Windows.Forms.Panel panel1;
    }
}

