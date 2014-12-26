namespace ScoringSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblScoreBlue = new System.Windows.Forms.Label();
            this.lblSecName = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.btnS2Blue = new System.Windows.Forms.Button();
            this.btnS1Blue = new System.Windows.Forms.Button();
            this.btn1Blue = new System.Windows.Forms.Button();
            this.btn2Blue = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblSchoolRed = new System.Windows.Forms.Label();
            this.lblNameRed = new System.Windows.Forms.Label();
            this.btn2Red = new System.Windows.Forms.Button();
            this.btn1Red = new System.Windows.Forms.Button();
            this.btnS1Red = new System.Windows.Forms.Button();
            this.btnS2Red = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMatchInfo = new System.Windows.Forms.Label();
            this.lblMatchNum = new System.Windows.Forms.Label();
            this.lblNameBlue = new System.Windows.Forms.Label();
            this.lblSchoolBlue = new System.Windows.Forms.Label();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.lblScoreRed = new System.Windows.Forms.Label();
            this.btnScoreSec2Red = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnScoreSec1Red = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWinRed = new System.Windows.Forms.Button();
            this.pnlLineRed = new System.Windows.Forms.Panel();
            this.pnlBlue = new System.Windows.Forms.Panel();
            this.btnScoreSec2Blue = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnScoreSec1Blue = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnWinBlue = new System.Windows.Forms.Button();
            this.pnlLineBlue = new System.Windows.Forms.Panel();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.lblNameWin = new System.Windows.Forms.Label();
            this.btnSettingOk = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblMatchTypeSetting = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nmrNumberMatch = new System.Windows.Forms.NumericUpDown();
            this.cbbInfo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNameRed = new System.Windows.Forms.TextBox();
            this.txtNameBlue = new System.Windows.Forms.TextBox();
            this.txtSchoolRed = new System.Windows.Forms.TextBox();
            this.txtSchoolBlue = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlClock = new System.Windows.Forms.Panel();
            this.txtFocus = new System.Windows.Forms.TextBox();
            this.lblMatchType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.tmrWait = new System.Windows.Forms.Timer(this.components);
            this.tmrWin = new System.Windows.Forms.Timer(this.components);
            this.pnlRed.SuspendLayout();
            this.pnlBlue.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumberMatch)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlClock.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblScoreBlue
            // 
            this.lblScoreBlue.BackColor = System.Drawing.Color.Blue;
            this.lblScoreBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblScoreBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblScoreBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreBlue.ForeColor = System.Drawing.Color.White;
            this.lblScoreBlue.Location = new System.Drawing.Point(82, 111);
            this.lblScoreBlue.Name = "lblScoreBlue";
            this.lblScoreBlue.Size = new System.Drawing.Size(400, 380);
            this.lblScoreBlue.TabIndex = 1;
            this.lblScoreBlue.Text = "00";
            this.lblScoreBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScoreBlue.Click += new System.EventHandler(this.lblScoreBlue_Click);
            // 
            // lblSecName
            // 
            this.lblSecName.BackColor = System.Drawing.Color.Transparent;
            this.lblSecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecName.Location = new System.Drawing.Point(2, 0);
            this.lblSecName.Name = "lblSecName";
            this.lblSecName.Size = new System.Drawing.Size(165, 40);
            this.lblSecName.TabIndex = 2;
            this.lblSecName.Text = "Hiệp 1";
            this.lblSecName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClock
            // 
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(2, 40);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(165, 63);
            this.lblClock.TabIndex = 3;
            this.lblClock.Text = "02:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClock.Click += new System.EventHandler(this.lblClock_Click);
            // 
            // btnS2Blue
            // 
            this.btnS2Blue.BackColor = System.Drawing.Color.Transparent;
            this.btnS2Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS2Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS2Blue.ForeColor = System.Drawing.Color.Blue;
            this.btnS2Blue.Location = new System.Drawing.Point(382, 507);
            this.btnS2Blue.Name = "btnS2Blue";
            this.btnS2Blue.Size = new System.Drawing.Size(35, 30);
            this.btnS2Blue.TabIndex = 11;
            this.btnS2Blue.Text = "-2";
            this.btnS2Blue.UseVisualStyleBackColor = false;
            this.btnS2Blue.Click += new System.EventHandler(this.btnS2Blue_Click);
            // 
            // btnS1Blue
            // 
            this.btnS1Blue.BackColor = System.Drawing.Color.Transparent;
            this.btnS1Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS1Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS1Blue.ForeColor = System.Drawing.Color.Blue;
            this.btnS1Blue.Location = new System.Drawing.Point(282, 507);
            this.btnS1Blue.Name = "btnS1Blue";
            this.btnS1Blue.Size = new System.Drawing.Size(35, 30);
            this.btnS1Blue.TabIndex = 10;
            this.btnS1Blue.Text = "-1";
            this.btnS1Blue.UseVisualStyleBackColor = false;
            this.btnS1Blue.Click += new System.EventHandler(this.btnS1Blue_Click);
            // 
            // btn1Blue
            // 
            this.btn1Blue.BackColor = System.Drawing.Color.Transparent;
            this.btn1Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Blue.ForeColor = System.Drawing.Color.Blue;
            this.btn1Blue.Location = new System.Drawing.Point(182, 507);
            this.btn1Blue.Name = "btn1Blue";
            this.btn1Blue.Size = new System.Drawing.Size(35, 30);
            this.btn1Blue.TabIndex = 9;
            this.btn1Blue.Text = "1";
            this.btn1Blue.UseVisualStyleBackColor = false;
            this.btn1Blue.Click += new System.EventHandler(this.btn1Blue_Click);
            // 
            // btn2Blue
            // 
            this.btn2Blue.BackColor = System.Drawing.Color.Transparent;
            this.btn2Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Blue.ForeColor = System.Drawing.Color.Blue;
            this.btn2Blue.Location = new System.Drawing.Point(82, 507);
            this.btn2Blue.Name = "btn2Blue";
            this.btn2Blue.Size = new System.Drawing.Size(35, 30);
            this.btn2Blue.TabIndex = 8;
            this.btn2Blue.Text = "2";
            this.btn2Blue.UseVisualStyleBackColor = false;
            this.btn2Blue.Click += new System.EventHandler(this.btn2Blue_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Green;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(464, 610);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(72, 40);
            this.btnEnd.TabIndex = 12;
            this.btnEnd.Text = "Kết thúc";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lblSchoolRed
            // 
            this.lblSchoolRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSchoolRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolRed.ForeColor = System.Drawing.Color.Red;
            this.lblSchoolRed.Location = new System.Drawing.Point(0, 0);
            this.lblSchoolRed.Name = "lblSchoolRed";
            this.lblSchoolRed.Size = new System.Drawing.Size(350, 45);
            this.lblSchoolRed.TabIndex = 13;
            this.lblSchoolRed.Text = "-";
            this.lblSchoolRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNameRed
            // 
            this.lblNameRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNameRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameRed.ForeColor = System.Drawing.Color.Red;
            this.lblNameRed.Location = new System.Drawing.Point(0, 50);
            this.lblNameRed.Name = "lblNameRed";
            this.lblNameRed.Size = new System.Drawing.Size(350, 40);
            this.lblNameRed.TabIndex = 14;
            this.lblNameRed.Text = "-";
            this.lblNameRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn2Red
            // 
            this.btn2Red.BackColor = System.Drawing.Color.Transparent;
            this.btn2Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Red.ForeColor = System.Drawing.Color.Red;
            this.btn2Red.Location = new System.Drawing.Point(382, 507);
            this.btn2Red.Name = "btn2Red";
            this.btn2Red.Size = new System.Drawing.Size(35, 30);
            this.btn2Red.TabIndex = 18;
            this.btn2Red.Text = "2";
            this.btn2Red.UseVisualStyleBackColor = false;
            this.btn2Red.Click += new System.EventHandler(this.btn2Red_Click);
            // 
            // btn1Red
            // 
            this.btn1Red.BackColor = System.Drawing.Color.Transparent;
            this.btn1Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Red.ForeColor = System.Drawing.Color.Red;
            this.btn1Red.Location = new System.Drawing.Point(282, 507);
            this.btn1Red.Name = "btn1Red";
            this.btn1Red.Size = new System.Drawing.Size(35, 30);
            this.btn1Red.TabIndex = 17;
            this.btn1Red.Text = "1";
            this.btn1Red.UseVisualStyleBackColor = false;
            this.btn1Red.Click += new System.EventHandler(this.btn1Red_Click);
            // 
            // btnS1Red
            // 
            this.btnS1Red.BackColor = System.Drawing.Color.Transparent;
            this.btnS1Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS1Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS1Red.ForeColor = System.Drawing.Color.Red;
            this.btnS1Red.Location = new System.Drawing.Point(182, 507);
            this.btnS1Red.Name = "btnS1Red";
            this.btnS1Red.Size = new System.Drawing.Size(35, 30);
            this.btnS1Red.TabIndex = 16;
            this.btnS1Red.Text = "-1";
            this.btnS1Red.UseVisualStyleBackColor = false;
            this.btnS1Red.Click += new System.EventHandler(this.btnS1Red_Click);
            // 
            // btnS2Red
            // 
            this.btnS2Red.BackColor = System.Drawing.Color.Transparent;
            this.btnS2Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS2Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS2Red.ForeColor = System.Drawing.Color.Red;
            this.btnS2Red.Location = new System.Drawing.Point(82, 507);
            this.btnS2Red.Name = "btnS2Red";
            this.btnS2Red.Size = new System.Drawing.Size(35, 30);
            this.btnS2Red.TabIndex = 15;
            this.btnS2Red.Text = "-2";
            this.btnS2Red.UseVisualStyleBackColor = false;
            this.btnS2Red.Click += new System.EventHandler(this.btnS2Red_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(149, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(690, 90);
            this.label4.TabIndex = 19;
            this.label4.Text = "GIẢI VOVINAM HỘI THAO SINH VIÊN\r\nTP.HCM LẦN THỨ 2 NĂM HỌC 2014 - 2015";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatchInfo
            // 
            this.lblMatchInfo.BackColor = System.Drawing.Color.White;
            this.lblMatchInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMatchInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMatchInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchInfo.Location = new System.Drawing.Point(13, 11);
            this.lblMatchInfo.Name = "lblMatchInfo";
            this.lblMatchInfo.Size = new System.Drawing.Size(130, 90);
            this.lblMatchInfo.TabIndex = 20;
            this.lblMatchInfo.Text = "-Kg -";
            this.lblMatchInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatchNum
            // 
            this.lblMatchNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMatchNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMatchNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchNum.Location = new System.Drawing.Point(897, 45);
            this.lblMatchNum.Name = "lblMatchNum";
            this.lblMatchNum.Size = new System.Drawing.Size(90, 54);
            this.lblMatchNum.TabIndex = 22;
            this.lblMatchNum.Text = "0";
            this.lblMatchNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameBlue
            // 
            this.lblNameBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNameBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBlue.ForeColor = System.Drawing.Color.Blue;
            this.lblNameBlue.Location = new System.Drawing.Point(153, 49);
            this.lblNameBlue.Name = "lblNameBlue";
            this.lblNameBlue.Size = new System.Drawing.Size(347, 40);
            this.lblNameBlue.TabIndex = 25;
            this.lblNameBlue.Text = "-";
            this.lblNameBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSchoolBlue
            // 
            this.lblSchoolBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSchoolBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolBlue.ForeColor = System.Drawing.Color.Blue;
            this.lblSchoolBlue.Location = new System.Drawing.Point(148, 0);
            this.lblSchoolBlue.Name = "lblSchoolBlue";
            this.lblSchoolBlue.Size = new System.Drawing.Size(350, 45);
            this.lblSchoolBlue.TabIndex = 24;
            this.lblSchoolBlue.Text = "-";
            this.lblSchoolBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlRed
            // 
            this.pnlRed.BackColor = System.Drawing.Color.White;
            this.pnlRed.Controls.Add(this.lblScoreRed);
            this.pnlRed.Controls.Add(this.btnScoreSec2Red);
            this.pnlRed.Controls.Add(this.label14);
            this.pnlRed.Controls.Add(this.btnScoreSec1Red);
            this.pnlRed.Controls.Add(this.label2);
            this.pnlRed.Controls.Add(this.btnWinRed);
            this.pnlRed.Controls.Add(this.pnlLineRed);
            this.pnlRed.Controls.Add(this.lblSchoolRed);
            this.pnlRed.Controls.Add(this.lblNameRed);
            this.pnlRed.Controls.Add(this.btn2Red);
            this.pnlRed.Controls.Add(this.btn1Red);
            this.pnlRed.Controls.Add(this.btnS1Red);
            this.pnlRed.Controls.Add(this.btnS2Red);
            this.pnlRed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlRed.Location = new System.Drawing.Point(0, 110);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(500, 540);
            this.pnlRed.TabIndex = 26;
            // 
            // lblScoreRed
            // 
            this.lblScoreRed.BackColor = System.Drawing.Color.Red;
            this.lblScoreRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblScoreRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblScoreRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreRed.ForeColor = System.Drawing.Color.White;
            this.lblScoreRed.Location = new System.Drawing.Point(15, 111);
            this.lblScoreRed.Name = "lblScoreRed";
            this.lblScoreRed.Size = new System.Drawing.Size(400, 380);
            this.lblScoreRed.TabIndex = 38;
            this.lblScoreRed.Text = "00";
            this.lblScoreRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScoreRed.Click += new System.EventHandler(this.lblScoreRed_Click);
            // 
            // btnScoreSec2Red
            // 
            this.btnScoreSec2Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScoreSec2Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoreSec2Red.ForeColor = System.Drawing.Color.Red;
            this.btnScoreSec2Red.Location = new System.Drawing.Point(452, 338);
            this.btnScoreSec2Red.Margin = new System.Windows.Forms.Padding(0);
            this.btnScoreSec2Red.Name = "btnScoreSec2Red";
            this.btnScoreSec2Red.Size = new System.Drawing.Size(45, 45);
            this.btnScoreSec2Red.TabIndex = 36;
            this.btnScoreSec2Red.UseVisualStyleBackColor = true;
            this.btnScoreSec2Red.Click += new System.EventHandler(this.btnScoreSec2Red_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(451, 308);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 25);
            this.label14.TabIndex = 35;
            this.label14.Text = "H";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnScoreSec1Red
            // 
            this.btnScoreSec1Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScoreSec1Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoreSec1Red.ForeColor = System.Drawing.Color.Red;
            this.btnScoreSec1Red.Location = new System.Drawing.Point(452, 230);
            this.btnScoreSec1Red.Margin = new System.Windows.Forms.Padding(0);
            this.btnScoreSec1Red.Name = "btnScoreSec1Red";
            this.btnScoreSec1Red.Size = new System.Drawing.Size(45, 45);
            this.btnScoreSec1Red.TabIndex = 34;
            this.btnScoreSec1Red.UseVisualStyleBackColor = true;
            this.btnScoreSec1Red.Click += new System.EventHandler(this.btnScoreSec1Red_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(454, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "H";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnWinRed
            // 
            this.btnWinRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinRed.ForeColor = System.Drawing.Color.Red;
            this.btnWinRed.Location = new System.Drawing.Point(0, 500);
            this.btnWinRed.Name = "btnWinRed";
            this.btnWinRed.Size = new System.Drawing.Size(40, 40);
            this.btnWinRed.TabIndex = 31;
            this.btnWinRed.Text = "Win";
            this.btnWinRed.UseVisualStyleBackColor = true;
            this.btnWinRed.Click += new System.EventHandler(this.btnWinRed_Click);
            // 
            // pnlLineRed
            // 
            this.pnlLineRed.BackColor = System.Drawing.Color.Red;
            this.pnlLineRed.Location = new System.Drawing.Point(5, 43);
            this.pnlLineRed.Name = "pnlLineRed";
            this.pnlLineRed.Size = new System.Drawing.Size(300, 3);
            this.pnlLineRed.TabIndex = 28;
            // 
            // pnlBlue
            // 
            this.pnlBlue.BackColor = System.Drawing.Color.White;
            this.pnlBlue.Controls.Add(this.btnScoreSec2Blue);
            this.pnlBlue.Controls.Add(this.label13);
            this.pnlBlue.Controls.Add(this.btnScoreSec1Blue);
            this.pnlBlue.Controls.Add(this.label10);
            this.pnlBlue.Controls.Add(this.btnWinBlue);
            this.pnlBlue.Controls.Add(this.pnlLineBlue);
            this.pnlBlue.Controls.Add(this.lblSchoolBlue);
            this.pnlBlue.Controls.Add(this.lblScoreBlue);
            this.pnlBlue.Controls.Add(this.btn2Blue);
            this.pnlBlue.Controls.Add(this.btn1Blue);
            this.pnlBlue.Controls.Add(this.btnS2Blue);
            this.pnlBlue.Controls.Add(this.btnS1Blue);
            this.pnlBlue.Controls.Add(this.lblNameBlue);
            this.pnlBlue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlBlue.Location = new System.Drawing.Point(500, 110);
            this.pnlBlue.Name = "pnlBlue";
            this.pnlBlue.Size = new System.Drawing.Size(500, 540);
            this.pnlBlue.TabIndex = 27;
            // 
            // btnScoreSec2Blue
            // 
            this.btnScoreSec2Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScoreSec2Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoreSec2Blue.ForeColor = System.Drawing.Color.Blue;
            this.btnScoreSec2Blue.Location = new System.Drawing.Point(3, 338);
            this.btnScoreSec2Blue.Margin = new System.Windows.Forms.Padding(0);
            this.btnScoreSec2Blue.Name = "btnScoreSec2Blue";
            this.btnScoreSec2Blue.Size = new System.Drawing.Size(45, 45);
            this.btnScoreSec2Blue.TabIndex = 37;
            this.btnScoreSec2Blue.UseVisualStyleBackColor = true;
            this.btnScoreSec2Blue.Click += new System.EventHandler(this.btnScoreSec2Blue_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(-3, 308);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 25);
            this.label13.TabIndex = 36;
            this.label13.Text = "2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnScoreSec1Blue
            // 
            this.btnScoreSec1Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScoreSec1Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoreSec1Blue.ForeColor = System.Drawing.Color.Blue;
            this.btnScoreSec1Blue.Location = new System.Drawing.Point(3, 230);
            this.btnScoreSec1Blue.Margin = new System.Windows.Forms.Padding(0);
            this.btnScoreSec1Blue.Name = "btnScoreSec1Blue";
            this.btnScoreSec1Blue.Size = new System.Drawing.Size(45, 45);
            this.btnScoreSec1Blue.TabIndex = 35;
            this.btnScoreSec1Blue.UseVisualStyleBackColor = true;
            this.btnScoreSec1Blue.Click += new System.EventHandler(this.btnScoreSec1Blue_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(-2, 200);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 25);
            this.label10.TabIndex = 33;
            this.label10.Text = "1";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnWinBlue
            // 
            this.btnWinBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinBlue.ForeColor = System.Drawing.Color.Blue;
            this.btnWinBlue.Location = new System.Drawing.Point(460, 499);
            this.btnWinBlue.Name = "btnWinBlue";
            this.btnWinBlue.Size = new System.Drawing.Size(40, 40);
            this.btnWinBlue.TabIndex = 30;
            this.btnWinBlue.Text = "Win";
            this.btnWinBlue.UseVisualStyleBackColor = true;
            this.btnWinBlue.Click += new System.EventHandler(this.btnWinBlue_Click);
            // 
            // pnlLineBlue
            // 
            this.pnlLineBlue.BackColor = System.Drawing.Color.Blue;
            this.pnlLineBlue.Location = new System.Drawing.Point(191, 43);
            this.pnlLineBlue.Name = "pnlLineBlue";
            this.pnlLineBlue.Size = new System.Drawing.Size(300, 3);
            this.pnlLineBlue.TabIndex = 29;
            // 
            // pnlSetting
            // 
            this.pnlSetting.BackColor = System.Drawing.Color.White;
            this.pnlSetting.Controls.Add(this.label7);
            this.pnlSetting.Controls.Add(this.btnFullScreen);
            this.pnlSetting.Controls.Add(this.lblNameWin);
            this.pnlSetting.Controls.Add(this.btnSettingOk);
            this.pnlSetting.Controls.Add(this.btnPrev);
            this.pnlSetting.Controls.Add(this.btnNext);
            this.pnlSetting.Controls.Add(this.panel6);
            this.pnlSetting.Controls.Add(this.tableLayoutPanel1);
            this.pnlSetting.Location = new System.Drawing.Point(1016, 12);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(950, 543);
            this.pnlSetting.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(147, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(690, 90);
            this.label7.TabIndex = 103;
            this.label7.Text = "GIẢI VOVINAM HỘI THAO SINH VIÊN\r\nTP.HCM LẦN THỨ 2 NĂM HỌC 2014 - 2015";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.BackColor = System.Drawing.Color.Green;
            this.btnFullScreen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullScreen.ForeColor = System.Drawing.Color.White;
            this.btnFullScreen.Location = new System.Drawing.Point(932, 3);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(60, 60);
            this.btnFullScreen.TabIndex = 101;
            this.btnFullScreen.Text = "Zoom";
            this.btnFullScreen.UseVisualStyleBackColor = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // lblNameWin
            // 
            this.lblNameWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameWin.Location = new System.Drawing.Point(388, 453);
            this.lblNameWin.Name = "lblNameWin";
            this.lblNameWin.Size = new System.Drawing.Size(231, 29);
            this.lblNameWin.TabIndex = 100;
            this.lblNameWin.Text = "-";
            this.lblNameWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSettingOk
            // 
            this.btnSettingOk.BackColor = System.Drawing.Color.Blue;
            this.btnSettingOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingOk.ForeColor = System.Drawing.Color.White;
            this.btnSettingOk.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSettingOk.Location = new System.Drawing.Point(743, 397);
            this.btnSettingOk.Name = "btnSettingOk";
            this.btnSettingOk.Size = new System.Drawing.Size(228, 46);
            this.btnSettingOk.TabIndex = 99;
            this.btnSettingOk.Text = "Bắt đầu trận đấu mới";
            this.btnSettingOk.UseVisualStyleBackColor = false;
            this.btnSettingOk.Click += new System.EventHandler(this.btnSettingOk_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Green;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(453, 395);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(46, 46);
            this.btnPrev.TabIndex = 98;
            this.btnPrev.Text = "←";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Green;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(506, 395);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(46, 46);
            this.btnNext.TabIndex = 97;
            this.btnNext.Text = "→";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblMatchTypeSetting);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.nmrNumberMatch);
            this.panel6.Controls.Add(this.cbbInfo);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(21, 213);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(950, 54);
            this.panel6.TabIndex = 96;
            // 
            // lblMatchTypeSetting
            // 
            this.lblMatchTypeSetting.AutoSize = true;
            this.lblMatchTypeSetting.Location = new System.Drawing.Point(843, 15);
            this.lblMatchTypeSetting.Name = "lblMatchTypeSetting";
            this.lblMatchTypeSetting.Size = new System.Drawing.Size(17, 22);
            this.lblMatchTypeSetting.TabIndex = 96;
            this.lblMatchTypeSetting.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(756, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 95;
            this.label6.Text = "Loại trận";
            // 
            // nmrNumberMatch
            // 
            this.nmrNumberMatch.Location = new System.Drawing.Point(204, 10);
            this.nmrNumberMatch.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nmrNumberMatch.Name = "nmrNumberMatch";
            this.nmrNumberMatch.Size = new System.Drawing.Size(121, 30);
            this.nmrNumberMatch.TabIndex = 94;
            this.nmrNumberMatch.ValueChanged += new System.EventHandler(this.nmrNumberMatch_ValueChanged);
            // 
            // cbbInfo
            // 
            this.cbbInfo.Enabled = false;
            this.cbbInfo.FormattingEnabled = true;
            this.cbbInfo.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbInfo.Location = new System.Drawing.Point(539, 10);
            this.cbbInfo.Name = "cbbInfo";
            this.cbbInfo.Size = new System.Drawing.Size(144, 30);
            this.cbbInfo.TabIndex = 8;
            this.cbbInfo.Text = "Nam";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(129, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "Trận số";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(448, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Thông tin";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.06086F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.43022F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.50892F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNameRed, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNameBlue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSchoolRed, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSchoolBlue, 2, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 274);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(953, 98);
            this.tableLayoutPanel1.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(525, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đơn vị";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Blue;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 31);
            this.label9.TabIndex = 4;
            this.label9.Text = "Xanh";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Đỏ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNameRed
            // 
            this.txtNameRed.BackColor = System.Drawing.Color.Red;
            this.txtNameRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNameRed.ForeColor = System.Drawing.Color.White;
            this.txtNameRed.Location = new System.Drawing.Point(136, 35);
            this.txtNameRed.Name = "txtNameRed";
            this.txtNameRed.Size = new System.Drawing.Size(283, 30);
            this.txtNameRed.TabIndex = 94;
            // 
            // txtNameBlue
            // 
            this.txtNameBlue.BackColor = System.Drawing.Color.Blue;
            this.txtNameBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNameBlue.ForeColor = System.Drawing.Color.White;
            this.txtNameBlue.Location = new System.Drawing.Point(136, 67);
            this.txtNameBlue.Name = "txtNameBlue";
            this.txtNameBlue.Size = new System.Drawing.Size(283, 30);
            this.txtNameBlue.TabIndex = 95;
            // 
            // txtSchoolRed
            // 
            this.txtSchoolRed.BackColor = System.Drawing.Color.Red;
            this.txtSchoolRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSchoolRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchoolRed.ForeColor = System.Drawing.Color.White;
            this.txtSchoolRed.Location = new System.Drawing.Point(425, 35);
            this.txtSchoolRed.Name = "txtSchoolRed";
            this.txtSchoolRed.Size = new System.Drawing.Size(525, 30);
            this.txtSchoolRed.TabIndex = 96;
            // 
            // txtSchoolBlue
            // 
            this.txtSchoolBlue.BackColor = System.Drawing.Color.Blue;
            this.txtSchoolBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSchoolBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSchoolBlue.ForeColor = System.Drawing.Color.White;
            this.txtSchoolBlue.Location = new System.Drawing.Point(425, 67);
            this.txtSchoolBlue.Name = "txtSchoolBlue";
            this.txtSchoolBlue.Size = new System.Drawing.Size(525, 30);
            this.txtSchoolBlue.TabIndex = 97;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlClock);
            this.pnlMain.Controls.Add(this.txtFocus);
            this.pnlMain.Controls.Add(this.lblMatchType);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.lblMatchInfo);
            this.pnlMain.Controls.Add(this.lblMatchNum);
            this.pnlMain.Controls.Add(this.btnEnd);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.pnlRed);
            this.pnlMain.Controls.Add(this.pnlBlue);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1000, 650);
            this.pnlMain.TabIndex = 28;
            // 
            // pnlClock
            // 
            this.pnlClock.Controls.Add(this.lblSecName);
            this.pnlClock.Controls.Add(this.lblClock);
            this.pnlClock.Location = new System.Drawing.Point(415, 113);
            this.pnlClock.Name = "pnlClock";
            this.pnlClock.Size = new System.Drawing.Size(167, 100);
            this.pnlClock.TabIndex = 31;
            // 
            // txtFocus
            // 
            this.txtFocus.Location = new System.Drawing.Point(0, 0);
            this.txtFocus.Name = "txtFocus";
            this.txtFocus.Size = new System.Drawing.Size(0, 20);
            this.txtFocus.TabIndex = 30;
            this.txtFocus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFocus_KeyPress);
            // 
            // lblMatchType
            // 
            this.lblMatchType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMatchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMatchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchType.Location = new System.Drawing.Point(845, 11);
            this.lblMatchType.Name = "lblMatchType";
            this.lblMatchType.Size = new System.Drawing.Size(50, 88);
            this.lblMatchType.TabIndex = 29;
            this.lblMatchType.Text = "CK";
            this.lblMatchType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(897, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 34);
            this.label3.TabIndex = 29;
            this.label3.Text = "Trận số";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // tmrWait
            // 
            this.tmrWait.Interval = 2000;
            this.tmrWait.Tick += new System.EventHandler(this.tmrWait_Tick);
            // 
            // tmrWin
            // 
            this.tmrWin.Interval = 500;
            this.tmrWin.Tick += new System.EventHandler(this.tmrWin_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlSetting);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chấm điểm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pnlRed.ResumeLayout(false);
            this.pnlBlue.ResumeLayout(false);
            this.pnlSetting.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumberMatch)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlClock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblScoreBlue;
        private System.Windows.Forms.Label lblSecName;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Button btnS2Blue;
        private System.Windows.Forms.Button btnS1Blue;
        private System.Windows.Forms.Button btn1Blue;
        private System.Windows.Forms.Button btn2Blue;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblSchoolRed;
        private System.Windows.Forms.Label lblNameRed;
        private System.Windows.Forms.Button btn2Red;
        private System.Windows.Forms.Button btn1Red;
        private System.Windows.Forms.Button btnS1Red;
        private System.Windows.Forms.Button btnS2Red;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMatchInfo;
        private System.Windows.Forms.Label lblMatchNum;
        private System.Windows.Forms.Label lblNameBlue;
        private System.Windows.Forms.Label lblSchoolBlue;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Panel pnlBlue;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlLineRed;
        private System.Windows.Forms.Panel pnlLineBlue;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Timer tmrWait;
        private System.Windows.Forms.Timer tmrWin;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Label lblNameWin;
        private System.Windows.Forms.Button btnSettingOk;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown nmrNumberMatch;
        private System.Windows.Forms.ComboBox cbbInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNameRed;
        private System.Windows.Forms.TextBox txtNameBlue;
        private System.Windows.Forms.TextBox txtSchoolRed;
        private System.Windows.Forms.TextBox txtSchoolBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.Label lblMatchType;
        private System.Windows.Forms.Label lblMatchTypeSetting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnWinBlue;
        private System.Windows.Forms.Button btnWinRed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnScoreSec2Red;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnScoreSec1Red;
        private System.Windows.Forms.Button btnScoreSec2Blue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnScoreSec1Blue;
        private System.Windows.Forms.Label lblScoreRed;
        private System.Windows.Forms.TextBox txtFocus;
        private System.Windows.Forms.Panel pnlClock;

    }
}

