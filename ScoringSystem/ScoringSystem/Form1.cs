using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ScoringSystem.Data;

namespace ScoringSystem
{
    public partial class Form1 : Form
    {
        private Function function;
        private FillData fillData;
        public Form1()
        {
            InitializeComponent();

            txtFocus.Focus();

            pnlSetting.Width = pnlMain.Width;
            pnlSetting.Height = pnlMain.Height;
            pnlMain.Left = (this.ClientSize.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.ClientSize.Height - pnlMain.Height) / 2;
            pnlSetting.Left = pnlMain.Left;
            pnlSetting.Top = pnlMain.Top;

            function = new Function();
            fillData = new FillData(nmrNumberMatch, cbbInfo, lblMatchTypeSetting, txtNameRed, txtNameBlue, txtSchoolRed, txtSchoolBlue, lblNameWin);
            Variable.MATCHES = TextDataUltil.ReadMatchText();

            //Full screen
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.Left = 0;
                this.Top = 0;
                this.Bounds = Screen.PrimaryScreen.Bounds;
                this.TopMost = true;
            }
            pnlMain.Left = (this.ClientSize.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.ClientSize.Height - pnlMain.Height) / 2;
            pnlSetting.Left = pnlMain.Left;
            pnlSetting.Top = pnlMain.Top;
            pibFullScreenClick();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pnlMain.Left = (this.ClientSize.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.ClientSize.Height - pnlMain.Height) / 2;
            pnlSetting.Left = pnlMain.Left;
            pnlSetting.Top = pnlMain.Top;
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.Left = 0;
                this.Top = 0;
                this.Bounds = Screen.PrimaryScreen.Bounds;
                this.TopMost = true;
            }
            pnlMain.Left = (this.ClientSize.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.ClientSize.Height - pnlMain.Height) / 2;
            pnlSetting.Left = pnlMain.Left;
            pnlSetting.Top = pnlMain.Top;
            pibFullScreenClick();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có thực sự muốn tắt phần mềm?", "Tắt phần mềm!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //pibFullScreen
        bool stateForm = false; //False nghĩa là form chưa full màn hình
        void pibFullScreenClick()
        {
            if (stateForm == false) //Đang resize
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.Left = 0;
                this.Top = 0;
                this.Bounds = Screen.PrimaryScreen.Bounds;
                this.TopMost = true;
                stateForm = true;
            }
            else //Đang fullScreen
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.TopMost = false;
                this.Height = 700;
                this.Width = 1100;
                this.StartPosition = FormStartPosition.CenterScreen;
                stateForm = false;
            }
        }

        #region Event Click Plus
        private void btn2Red_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
            Variable.score[0] += 2;
            lblScoreRed.Text = function.CalNumber(lblScoreRed.Text, 2);
            Variable.LastScore = 0;
        }

        private void btn1Red_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
            Variable.score[0] += 1;
            lblScoreRed.Text = function.CalNumber(lblScoreRed.Text, 1);
            Variable.LastScore = 0;
        }

        private void btnS1Red_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
            Variable.score[0] -= 1;
            lblScoreRed.Text = function.CalNumber(lblScoreRed.Text, -1);
        }

        private void btnS2Red_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
            Variable.score[0] -= 2;
            lblScoreRed.Text = function.CalNumber(lblScoreRed.Text, -2);
        }

        private void btn2Blue_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
            Variable.score[1] += 2;
            lblScoreBlue.Text = function.CalNumber(lblScoreBlue.Text, 2);
            Variable.LastScore = 1;
        }

        private void btn1Blue_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
            Variable.score[1] += 1;
            lblScoreBlue.Text = function.CalNumber(lblScoreBlue.Text, 1);
            Variable.LastScore = 1;
        }

        private void btnS1Blue_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
            Variable.score[1] -= 1;
            lblScoreBlue.Text = function.CalNumber(lblScoreBlue.Text, -1);
        }

        private void btnS2Blue_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
            Variable.score[1] -= 2;
            lblScoreBlue.Text = function.CalNumber(lblScoreBlue.Text, -2);
        }
        private void btnScoreSec1Red_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
        }

        private void btnScoreSec1Blue_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
        }

        private void btnScoreSec2Red_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
        }

        private void btnScoreSec2Blue_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
        }
        #endregion

        void ChangeRedColor(int type)
        {
            if (lblScoreRed.BackColor == Color.Red)
            {
                if (type == 1) return;
                lblScoreRed.BackColor = Color.White;
                lblScoreRed.ForeColor = Color.Red;
                /*pnlRed.BackColor = Color.White;
                lblSchoolRed.ForeColor = Color.Red;
                pnlLineRed.BackColor = Color.Red;
                lblNameRed.ForeColor = Color.Red;
                btnS2Red.ForeColor = Color.Red;
                btnS1Red.ForeColor = Color.Red;
                btn1Red.ForeColor = Color.Red;
                btn2Red.ForeColor = Color.Red;
                btnWinRed.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
                btnScoreSec1Red.ForeColor = Color.Red;
                label14.ForeColor = Color.Red;
                btnScoreSec2Red.ForeColor = Color.Red;*/
            }
            else if (lblScoreRed.BackColor == Color.White)
            {
                lblScoreRed.BackColor = Color.Red;
                lblScoreRed.ForeColor = Color.White;
                /*pnlRed.BackColor = Color.Red;
                lblSchoolRed.ForeColor = Color.White;
                pnlLineRed.BackColor = Color.White;
                lblNameRed.ForeColor = Color.White;
                btnS2Red.ForeColor = Color.White;
                btnS1Red.ForeColor = Color.White;
                btn1Red.ForeColor = Color.White;
                btn2Red.ForeColor = Color.White;
                btnWinRed.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                btnScoreSec1Red.ForeColor = Color.White;
                label14.ForeColor = Color.White;
                btnScoreSec2Red.ForeColor = Color.White;*/
            }
        }

        void ChangeBlueColor(int type)
        {
            if (lblScoreBlue.BackColor == Color.Blue)
            {
                if (type == 1) return;
                lblScoreBlue.BackColor = Color.White;
                lblScoreBlue.ForeColor = Color.Blue;
                /* pnlBlue.BackColor = Color.White;
                 lblSchoolBlue.ForeColor = Color.Blue;
                 pnlLineBlue.BackColor = Color.Blue;
                 lblNameBlue.ForeColor = Color.Blue;
                 btnS2Blue.ForeColor = Color.Blue;
                 btnS1Blue.ForeColor = Color.Blue;
                 btn1Blue.ForeColor = Color.Blue;
                 btn2Blue.ForeColor = Color.Blue;
                 btnWinBlue.ForeColor = Color.Blue;
                 label10.ForeColor = Color.Blue;
                 btnScoreSec1Blue.ForeColor = Color.Blue;
                 label13.ForeColor = Color.Blue;
                 btnScoreSec2Blue.ForeColor = Color.Blue;*/
            }
            else if (lblScoreBlue.BackColor == Color.White)
            {
                lblScoreBlue.BackColor = Color.Blue;
                lblScoreBlue.ForeColor = Color.White;
                /* pnlBlue.BackColor = Color.Blue;
                 lblSchoolBlue.ForeColor = Color.White;
                 pnlLineBlue.BackColor = Color.White;
                 lblNameBlue.ForeColor = Color.White;
                 btnS2Blue.ForeColor = Color.White;
                 btnS1Blue.ForeColor = Color.White;
                 btn1Blue.ForeColor = Color.White;
                 btn2Blue.ForeColor = Color.White;
                 btnWinBlue.ForeColor = Color.White;
                 label10.ForeColor = Color.White;
                 btnScoreSec1Blue.ForeColor = Color.White;
                 label13.ForeColor = Color.White;
                 btnScoreSec2Blue.ForeColor = Color.White;*/
            }
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            Variable.second -= 1;
            lblClock.Text = function.CalClock(Variable.second);
            //Het gio
            if (Variable.second == 0)
            {
                function.PlaySound();
                Variable.type = 0;
                pnlClock.BackColor = Color.Orange;
                tmrWait.Enabled = true;
                tmrClock.Enabled = false;
            }
        }

        private void lblSecName_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
            ClockClick();
        }

        private void lblClock_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
            ClockClick();
        }

        public void ClockClick()
        {
            if (tmrWait.Enabled == true) return;
            if (Variable.second == Variable.timeSec && Variable.type == 0)
            {
                function.PlaySound();
                Thread.Sleep(2000);
            }
            //Neu dang hiep 1
            if (Variable.sec == 2 && Variable.second == 0)
            {
                //btnEnd.Visible = true;
                return;
            }
            //Neu dang dung
            if (Variable.type == 0)
            {
                //Chay
                //Mau trang chay
                pnlClock.BackColor = Color.White;
                tmrClock.Enabled = true;
                Variable.type = 1;
            }
            //Neu dang chay
            else if (Variable.type == 1)
            {
                //dung
                //Mau vang chay
                pnlClock.BackColor = Color.Yellow;
                tmrClock.Enabled = false;
                Variable.type = 0;
            }
        }

        private void CheckWin()
        {
            if (Convert.ToInt32(lblScoreRed.Text) > Convert.ToInt32(lblScoreBlue.Text))
            {
                Variable.winTeam = 0;
            }
            else if (Convert.ToInt32(lblScoreBlue.Text) > Convert.ToInt32(lblScoreRed.Text))
            {
                Variable.winTeam = 1;
            }
            //Nếu hòa
            else
            {
                /* if (Variable.LastScore == 0)
                 {
                     Variable.winTeam = 0;
                 }
                 else if (Variable.LastScore == 1)
                 {
                     Variable.winTeam = 1;
                 }*/
            }
        }

        private void tmrWait_Tick(object sender, EventArgs e)
        {
            tmrWait.Enabled = false;
            //Het hiep 2
            if (Variable.sec == 2)
            {
                btnEnd.Visible = true;
                CheckWin();
                Variable.score[4] = Variable.score[0] - Variable.score[2];
                btnScoreSec2Red.Text = function.CalNumber(Variable.score[4].ToString(), 0);
                Variable.score[5] = Variable.score[1] - Variable.score[3];
                btnScoreSec2Blue.Text = function.CalNumber(Variable.score[5].ToString(), 0);
                tmrWin.Start();
            }
            //Het hiep 1
            else if (Variable.sec == 1)
            {
                pnlClock.BackColor = Color.White;
                lblSecName.Text = "Giải lao";
                Variable.sec = 0;
                Variable.second = Variable.timeFree;
                lblClock.Text = function.CalClock(Variable.second);
                tmrClock.Enabled = true;
                Variable.score[2] = Variable.score[0];
                btnScoreSec1Red.Text = function.CalNumber(Variable.score[2].ToString(), 0);
                Variable.score[3] = Variable.score[1];
                btnScoreSec1Blue.Text = function.CalNumber(Variable.score[3].ToString(), 0);
            }
            //Het Giai lao
            else if (Variable.sec == 0)
            {
                pnlClock.BackColor = Color.Yellow;
                lblSecName.Text = "Hiệp 2";
                Variable.sec = 2;
                Variable.second = Variable.timeSec;
                lblClock.Text = function.CalClock(Variable.second);
            }

        }

        private void tmrWin_Tick(object sender, EventArgs e)
        {
            if (Variable.winTeam == 0)
            {
                ChangeRedColor(0);
            }
            else if (Variable.winTeam == 1)
            {
                ChangeBlueColor(0);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int numMatch = Convert.ToInt32(nmrNumberMatch.Value);
            if (numMatch >= 300)
                return;
            nmrNumberMatch.Value = numMatch + 1;
            fillData.FillFromMatch(nmrNumberMatch);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int numMatch = Convert.ToInt32(nmrNumberMatch.Value);
            if (numMatch <= 0)
                return;
            nmrNumberMatch.Value = numMatch - 1;
            fillData.FillFromMatch(nmrNumberMatch);
        }

        private void nmrNumberMatch_ValueChanged(object sender, EventArgs e)
        {
            fillData.FillFromMatch(nmrNumberMatch);
        }

        private void btnSettingOk_Click(object sender, EventArgs e)
        {
            //Nếu 1 trong 2 tên chưa được điền thì bỏ qua
            if (!fillData.checkIsNumber(txtNameRed.Text))
            {
                if (fillData.checkIsNumber(txtNameBlue.Text))
                {
                    MessageBox.Show("Phải chọn cả hai vận động viên để thi đấu!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Phải chọn cả hai vận động viên để thi đấu!");
                return;
            }
            //Nếu trùng tên thì bỏ qua
            if (txtNameRed.Text == txtNameBlue.Text && txtSchoolRed.Text == txtSchoolBlue.Text)
            {
                MessageBox.Show("Phải chọn 2 vận động viên khác nhau!");
                return;
            }
            //Nếu trận đấu đã được chấm
            if (lblNameWin.Text != "-")
            {
                DialogResult dialogResult = MessageBox.Show("Trận đấu đã được chấm điểm, bạn thực sự muốn chấm lại?", "Tiếp tục chấm?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            pnlSetting.Visible = false;
            ResetForm();
        }

        private void ResetForm()
        {
            tmrClock.Enabled = false;
            tmrWait.Enabled = false;
            tmrWin.Enabled = false;
            lblMatchNum.Text = nmrNumberMatch.Value.ToString();
            lblSchoolRed.Text = txtSchoolRed.Text;
            lblNameRed.Text = txtNameRed.Text;
            lblSchoolBlue.Text = txtSchoolBlue.Text;
            lblNameBlue.Text = txtNameBlue.Text;
            lblMatchInfo.Text = cbbInfo.Text;
            lblMatchType.Text = lblMatchTypeSetting.Text;
            if (lblMatchTypeSetting.Text == "")
            {
                lblMatchType.Visible = false;
            }
            else
            {
                lblMatchType.Visible = true;
            }

            lblSecName.Text = "Hiệp 1";
            pnlClock.BackColor = Color.Yellow;
            lblClock.Text = function.CalClock(Variable.timeSec);
            lblScoreRed.Text = function.CalNumber("0", 0);
            lblScoreBlue.Text = function.CalNumber("0", 0);
            ChangeRedColor(1);
            ChangeBlueColor(1);
            btnScoreSec1Red.Text = "";
            btnScoreSec2Red.Text = "";
            btnScoreSec1Blue.Text = "";
            btnScoreSec2Blue.Text = "";
            Variable.winTeam = -1;
            Variable.LastScore = -1;
            Variable.sec = 1;
            Variable.second = Variable.timeSec;
            Variable.score = new[] { 0, 0, 0, 0, 0, 0 };
            txtFocus.Focus();
            txtFocus.Text = "";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
            //Phải có 1 người thắng
            if (Variable.winTeam != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Lưu kết quả và chuyển sang trận đấu kế tiếp?", "Lưu kết quả", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Save kết quả vào database
                    fillData.SaveMath(nmrNumberMatch.Value.ToString(), Variable.winTeam.ToString());

                    nmrNumberMatch.Value = nmrNumberMatch.Value + 1;

                    pnlSetting.Visible = true;

                    tmrWin.Stop();
                    CheckWin();
                }
                else if (dialogResult == DialogResult.No) { }
            }
            //Chưa chọn được ai thắng cả
            else
            {
                MessageBox.Show("Phải chọn một người chiến thắng!");
            }
        }

        private void btnWinRed_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
            WinRedClick();
        }

        public void WinRedClick()
        {
            DialogResult dialogResult = MessageBox.Show("ĐỎ thắng?", "Đỏ thắng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ChangeRedColor(1);
                ChangeBlueColor(1);
                Variable.winTeam = 0;
                tmrWin.Start();
                tmrClock.Stop();
                tmrWait.Stop();
            }
            else if (dialogResult == DialogResult.No) { }
        }

        private void btnWinBlue_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
            WinBlueClick();
        }

        public void WinBlueClick()
        {
            DialogResult dialogResult = MessageBox.Show("XANH thắng?", "Xanh thắng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ChangeRedColor(1);
                ChangeBlueColor(1);
                Variable.winTeam = 1;
                tmrWin.Start();
                tmrClock.Stop();
                tmrWait.Stop();
            }
            else if (dialogResult == DialogResult.No) { }
        }

        private void lblScoreRed_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
            Variable.score[0] += 1;
            lblScoreRed.Text = function.CalNumber(lblScoreRed.Text, 1);
            Variable.LastScore = 0;
        }

        private void lblScoreBlue_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();
            Variable.score[1] += 1;
            lblScoreBlue.Text = function.CalNumber(lblScoreBlue.Text, 1);
            Variable.LastScore = 1;
        }

        private void txtFocus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                ClockClick();
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                //Nếu đang chạy
                if (Variable.type == 1)
                {
                    function.PlaySound();
                    ClockClick();
                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                pnlSetting.Visible = true;
            }
        }

        private void btnWinBeforeRed_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ĐỎ thắng?", "Đỏ thắng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Variable.winTeam = 0;
                fillData.SaveMath(nmrNumberMatch.Value.ToString(), Variable.winTeam.ToString());
                lblNameWin.ForeColor = Color.Red;
                lblNameWin.Text = txtNameRed.Text;
            }
            else if (dialogResult == DialogResult.No) { }
        }

        private void btnWinBeforeBlue_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("XANH thắng?", "Xanh thắng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Variable.winTeam = 1;
                fillData.SaveMath(nmrNumberMatch.Value.ToString(), Variable.winTeam.ToString());
                lblNameWin.ForeColor = Color.Blue;
                lblNameWin.Text = txtNameBlue.Text;
            }
            else if (dialogResult == DialogResult.No) { }
        }
    }
}
