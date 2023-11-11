namespace LPDA
{
    partial class dashboard_form
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
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu_tag = new System.Windows.Forms.Label();
            this.munu_tag_icon_picture = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.home_contener = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.allClientBoten = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dailyUpdatesBotten = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.addClientBotten = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homeBotten = new System.Windows.Forms.Button();
            this.pnlComtent = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.taskBotten = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.settingButten = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.eventButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.aboutButten = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.helpButton = new System.Windows.Forms.Button();
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.HomeTimer = new System.Windows.Forms.Timer(this.components);
            this.SidebarTimerEx = new System.Windows.Forms.Timer(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.Greeting = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.munu_tag_icon_picture)).BeginInit();
            this.home_contener.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.home_contener);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar.MaximumSize = new System.Drawing.Size(309, 1033);
            this.sidebar.MinimumSize = new System.Drawing.Size(131, 1033);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(131, 1033);
            this.sidebar.TabIndex = 2;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menu_tag);
            this.panel1.Controls.Add(this.munu_tag_icon_picture);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 113);
            this.panel1.TabIndex = 3;
            // 
            // menu_tag
            // 
            this.menu_tag.AutoSize = true;
            this.menu_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_tag.ForeColor = System.Drawing.Color.White;
            this.menu_tag.Location = new System.Drawing.Point(125, 43);
            this.menu_tag.Name = "menu_tag";
            this.menu_tag.Size = new System.Drawing.Size(62, 20);
            this.menu_tag.TabIndex = 4;
            this.menu_tag.Text = "MENU";
            // 
            // munu_tag_icon_picture
            // 
            this.munu_tag_icon_picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.munu_tag_icon_picture.Image = global::LPDA.Properties.Resources.Artboard_23;
            this.munu_tag_icon_picture.Location = new System.Drawing.Point(29, 34);
            this.munu_tag_icon_picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.munu_tag_icon_picture.Name = "munu_tag_icon_picture";
            this.munu_tag_icon_picture.Size = new System.Drawing.Size(67, 41);
            this.munu_tag_icon_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.munu_tag_icon_picture.TabIndex = 4;
            this.munu_tag_icon_picture.TabStop = false;
            this.munu_tag_icon_picture.Click += new System.EventHandler(this.munu_tag_icon_picture_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.panel7.Location = new System.Drawing.Point(313, -2);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1592, 116);
            this.panel7.TabIndex = 3;
            // 
            // home_contener
            // 
            this.home_contener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.home_contener.Controls.Add(this.panel13);
            this.home_contener.Controls.Add(this.panel12);
            this.home_contener.Controls.Add(this.panel9);
            this.home_contener.Controls.Add(this.panel2);
            this.home_contener.Controls.Add(this.panel10);
            this.home_contener.Location = new System.Drawing.Point(3, 119);
            this.home_contener.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.home_contener.MaximumSize = new System.Drawing.Size(357, 350);
            this.home_contener.MinimumSize = new System.Drawing.Size(357, 98);
            this.home_contener.Name = "home_contener";
            this.home_contener.Size = new System.Drawing.Size(357, 349);
            this.home_contener.TabIndex = 4;
            this.home_contener.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel13.Controls.Add(this.allClientBoten);
            this.panel13.Location = new System.Drawing.Point(0, 277);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(357, 49);
            this.panel13.TabIndex = 4;
            // 
            // allClientBoten
            // 
            this.allClientBoten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allClientBoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allClientBoten.ForeColor = System.Drawing.Color.White;
            this.allClientBoten.Image = global::LPDA.Properties.Resources.Artboard_34;
            this.allClientBoten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allClientBoten.Location = new System.Drawing.Point(-19, -7);
            this.allClientBoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allClientBoten.Name = "allClientBoten";
            this.allClientBoten.Padding = new System.Windows.Forms.Padding(69, 0, 0, 0);
            this.allClientBoten.Size = new System.Drawing.Size(385, 66);
            this.allClientBoten.TabIndex = 3;
            this.allClientBoten.Text = "           ALL CLIENT";
            this.allClientBoten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allClientBoten.UseVisualStyleBackColor = true;
            this.allClientBoten.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel12.Controls.Add(this.dailyUpdatesBotten);
            this.panel12.Location = new System.Drawing.Point(3, 222);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(357, 49);
            this.panel12.TabIndex = 4;
            // 
            // dailyUpdatesBotten
            // 
            this.dailyUpdatesBotten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyUpdatesBotten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyUpdatesBotten.ForeColor = System.Drawing.Color.White;
            this.dailyUpdatesBotten.Image = global::LPDA.Properties.Resources.Artboard_34;
            this.dailyUpdatesBotten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dailyUpdatesBotten.Location = new System.Drawing.Point(-20, -7);
            this.dailyUpdatesBotten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dailyUpdatesBotten.Name = "dailyUpdatesBotten";
            this.dailyUpdatesBotten.Padding = new System.Windows.Forms.Padding(69, 0, 0, 0);
            this.dailyUpdatesBotten.Size = new System.Drawing.Size(385, 66);
            this.dailyUpdatesBotten.TabIndex = 3;
            this.dailyUpdatesBotten.Text = "           DAILY UPDATES";
            this.dailyUpdatesBotten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dailyUpdatesBotten.UseVisualStyleBackColor = true;
            this.dailyUpdatesBotten.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel9.Controls.Add(this.addClientBotten);
            this.panel9.Location = new System.Drawing.Point(3, 112);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(357, 49);
            this.panel9.TabIndex = 4;
            // 
            // addClientBotten
            // 
            this.addClientBotten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClientBotten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientBotten.ForeColor = System.Drawing.Color.White;
            this.addClientBotten.Image = global::LPDA.Properties.Resources.Artboard_34;
            this.addClientBotten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addClientBotten.Location = new System.Drawing.Point(-17, -11);
            this.addClientBotten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addClientBotten.Name = "addClientBotten";
            this.addClientBotten.Padding = new System.Windows.Forms.Padding(69, 0, 0, 0);
            this.addClientBotten.Size = new System.Drawing.Size(385, 66);
            this.addClientBotten.TabIndex = 3;
            this.addClientBotten.Text = "           ADD CLIENT";
            this.addClientBotten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addClientBotten.UseVisualStyleBackColor = true;
            this.addClientBotten.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.homeBotten);
            this.panel2.Controls.Add(this.pnlComtent);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 103);
            this.panel2.TabIndex = 4;
            // 
            // homeBotten
            // 
            this.homeBotten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBotten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBotten.ForeColor = System.Drawing.Color.White;
            this.homeBotten.Image = global::LPDA.Properties.Resources.Artboard_251;
            this.homeBotten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBotten.Location = new System.Drawing.Point(-17, -12);
            this.homeBotten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homeBotten.Name = "homeBotten";
            this.homeBotten.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.homeBotten.Size = new System.Drawing.Size(385, 124);
            this.homeBotten.TabIndex = 3;
            this.homeBotten.Text = "                 HOME";
            this.homeBotten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBotten.UseVisualStyleBackColor = true;
            this.homeBotten.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlComtent
            // 
            this.pnlComtent.Location = new System.Drawing.Point(126, 4);
            this.pnlComtent.Name = "pnlComtent";
            this.pnlComtent.Size = new System.Drawing.Size(1792, 908);
            this.pnlComtent.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel10.Controls.Add(this.taskBotten);
            this.panel10.Location = new System.Drawing.Point(3, 167);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(357, 49);
            this.panel10.TabIndex = 4;
            // 
            // taskBotten
            // 
            this.taskBotten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskBotten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskBotten.ForeColor = System.Drawing.Color.White;
            this.taskBotten.Image = global::LPDA.Properties.Resources.Artboard_34_copy1;
            this.taskBotten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taskBotten.Location = new System.Drawing.Point(-17, -9);
            this.taskBotten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskBotten.Name = "taskBotten";
            this.taskBotten.Padding = new System.Windows.Forms.Padding(69, 0, 0, 0);
            this.taskBotten.Size = new System.Drawing.Size(385, 66);
            this.taskBotten.TabIndex = 3;
            this.taskBotten.Text = "           TASK";
            this.taskBotten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taskBotten.UseVisualStyleBackColor = true;
            this.taskBotten.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.settingButten);
            this.panel3.Location = new System.Drawing.Point(3, 472);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 103);
            this.panel3.TabIndex = 4;
            // 
            // settingButten
            // 
            this.settingButten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingButten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingButten.ForeColor = System.Drawing.Color.White;
            this.settingButten.Image = global::LPDA.Properties.Resources.Artboard_25_copy;
            this.settingButten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingButten.Location = new System.Drawing.Point(-17, -14);
            this.settingButten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingButten.Name = "settingButten";
            this.settingButten.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.settingButten.Size = new System.Drawing.Size(385, 128);
            this.settingButten.TabIndex = 3;
            this.settingButten.Text = "                 SETTING";
            this.settingButten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingButten.UseVisualStyleBackColor = true;
            this.settingButten.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.eventButton);
            this.panel4.Location = new System.Drawing.Point(3, 579);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 103);
            this.panel4.TabIndex = 4;
            // 
            // eventButton
            // 
            this.eventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventButton.ForeColor = System.Drawing.Color.White;
            this.eventButton.Image = global::LPDA.Properties.Resources.Artboard_25_copy_2;
            this.eventButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventButton.Location = new System.Drawing.Point(-17, -21);
            this.eventButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventButton.Name = "eventButton";
            this.eventButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.eventButton.Size = new System.Drawing.Size(385, 133);
            this.eventButton.TabIndex = 3;
            this.eventButton.Text = "                 EVENTS";
            this.eventButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventButton.UseVisualStyleBackColor = true;
            this.eventButton.Click += new System.EventHandler(this.event_button_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.aboutButten);
            this.panel5.Location = new System.Drawing.Point(3, 686);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(357, 103);
            this.panel5.TabIndex = 4;
            // 
            // aboutButten
            // 
            this.aboutButten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButten.ForeColor = System.Drawing.Color.White;
            this.aboutButten.Image = global::LPDA.Properties.Resources.Artboard_25_copy_3;
            this.aboutButten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButten.Location = new System.Drawing.Point(-17, -5);
            this.aboutButten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aboutButten.Name = "aboutButten";
            this.aboutButten.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.aboutButten.Size = new System.Drawing.Size(385, 121);
            this.aboutButten.TabIndex = 3;
            this.aboutButten.Text = "                 ABOUT ";
            this.aboutButten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButten.UseVisualStyleBackColor = true;
            this.aboutButten.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.helpButton);
            this.panel6.Location = new System.Drawing.Point(3, 793);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(357, 103);
            this.panel6.TabIndex = 5;
            // 
            // helpButton
            // 
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Image = global::LPDA.Properties.Resources.Artboard_25_copy_31;
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpButton.Location = new System.Drawing.Point(-17, -5);
            this.helpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.helpButton.Name = "helpButton";
            this.helpButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.helpButton.Size = new System.Drawing.Size(385, 118);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "                 HELP ";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Interval = 10;
            this.SidebarTimer.Tick += new System.EventHandler(this.SidebarTimer_Tick);
            // 
            // HomeTimer
            // 
            this.HomeTimer.Interval = 10;
            this.HomeTimer.Tick += new System.EventHandler(this.HomeTimer_Tick);
            // 
            // SidebarTimerEx
            // 
            this.SidebarTimerEx.Interval = 10;
            this.SidebarTimerEx.Tick += new System.EventHandler(this.SidebarTimerEx_Tick);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel14);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.Greeting);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Location = new System.Drawing.Point(134, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1334, 116);
            this.panel8.TabIndex = 4;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Location = new System.Drawing.Point(1340, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(250, 110);
            this.panel14.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(1432, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(161, 116);
            this.panel11.TabIndex = 5;
            // 
            // Greeting
            // 
            this.Greeting.AutoSize = true;
            this.Greeting.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greeting.Location = new System.Drawing.Point(121, 24);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(255, 65);
            this.Greeting.TabIndex = 1;
            this.Greeting.Text = " L  P  D  A";
            this.Greeting.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::LPDA.Properties.Resources.wings_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LPDA.Properties.Resources.Artboard_211;
            this.pictureBox2.Location = new System.Drawing.Point(66, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.Control;
            this.panel15.Controls.Add(this.pictureBox2);
            this.panel15.Location = new System.Drawing.Point(1724, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(200, 119);
            this.panel15.TabIndex = 5;
            // 
            // dashboard_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dashboard_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dashboard_form_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.munu_tag_icon_picture)).EndInit();
            this.home_contener.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel15.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button homeBotten;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button settingButten;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button eventButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button aboutButten;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.PictureBox munu_tag_icon_picture;
        private System.Windows.Forms.Label menu_tag;
        private System.Windows.Forms.Timer SidebarTimer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel home_contener;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button addClientBotten;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button taskBotten;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button dailyUpdatesBotten;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button allClientBoten;
        private System.Windows.Forms.Timer HomeTimer;
        private UserControl1 userControl11;
        private System.Windows.Forms.Timer SidebarTimerEx;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Greeting;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel pnlComtent;
    }
}