using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScoringSystem.Data
{
    public class FillData
    {
        //private TextBox txtNumberMatch;
        private NumericUpDown nmrNumberMatch;
        private ComboBox cbbInfo;
        private Label lblMatchTypeSetting;

        private TextBox txtNameRed;
        private TextBox txtNameBlue;
        private TextBox txtSchoolRed;
        private TextBox txtSchoolBlue;

        private Label lblNameWin;

        public FillData(NumericUpDown nmrNumberMatch, ComboBox cbbInfo,Label lblMatchTypeSetting,
            TextBox txtNameRed, TextBox txtNameBlue, TextBox txtSchoolRed, TextBox txtSchoolBlue, Label lblNameWin)
        {
            this.nmrNumberMatch = nmrNumberMatch;
            this.cbbInfo = cbbInfo;
            this.lblMatchTypeSetting = lblMatchTypeSetting;

            this.txtNameRed = txtNameRed;
            this.txtNameBlue = txtNameBlue;
            this.txtSchoolRed = txtSchoolRed;
            this.txtSchoolBlue = txtSchoolBlue;
            this.lblNameWin = lblNameWin;
        }

        private void ClearTexbox()
        {
            txtNameRed.Text = "";
            txtNameBlue.Text = "";
            txtSchoolRed.Text = "";
            txtSchoolBlue.Text = "";
            lblNameWin.Text = "-";
            lblMatchTypeSetting.Text = "-";
        }

        #region ListDatabase
        public void FillFromMatch(NumericUpDown nmrNumberMatch)
        {
            string matchString = nmrNumberMatch.Value.ToString();
            try
            {
                var match = new Match();
                match = TextDataUltil.GetMatchFromMatchId(matchString);
                if (match != null)
                {
                    try
                    {
                        match = SetInfoFromMatchId(matchString, match.NameRed, match.NameBlue);

                        cbbInfo.Text = match.MatchInfo;
                        lblMatchTypeSetting.Text = match.MatchType;
                        txtNameRed.Text = match.NameRed;
                        txtSchoolRed.Text = match.SchoolRed;
                        txtNameBlue.Text = match.NameBlue;
                        txtSchoolBlue.Text = match.SchoolBlue;

                        if (match.Win == "0")
                        {
                            lblNameWin.Text = "Đỏ thắng";
                            lblNameWin.ForeColor = Color.Red;
                        }
                        else if (match.Win == "1")
                        {
                            lblNameWin.Text = "Xanh thắng";
                            lblNameWin.ForeColor = Color.Blue;
                        }
                        else
                        {
                            lblNameWin.Text = "-";
                            lblNameWin.ForeColor = Color.Black;
                        }
                    }
                    catch (Exception fail)
                    {
                        String error = "The following error has occurred:\n\n";
                        error += fail.Message.ToString() + "\n\n";
                        MessageBox.Show(error);
                    }
                }
                else
                {
                    ClearTexbox();
                }
            }
            catch (Exception fail)
            {
                String error = "The following error has occurred:\n\n";
                error += fail.Message.ToString() + "\n\n";
                MessageBox.Show(error);
            }
        }

        public Match SetInfoFromMatchId(string matchString, string matchIdRed, string matchIdBlue)
        {
             var match = new Match();
             match = TextDataUltil.GetMatchFromMatchId(matchString);
            if(checkIsNumber(matchIdRed))
            {
                var matchTempRed = TextDataUltil.GetMatchFromMatchId(matchIdRed);
                if(matchTempRed!=null)
                {
                    if (matchTempRed.Win == "0")
                    {
                        match.NameRed = matchTempRed.NameRed;
                        match.SchoolRed = matchTempRed.SchoolRed;
                    }
                    else if(matchTempRed.Win == "1")
                    {
                        match.NameRed = matchTempRed.NameBlue;
                        match.SchoolRed = matchTempRed.SchoolBlue;
                    }
                }
            }
            if (checkIsNumber(matchIdBlue))
            {
                var matchTempblue = TextDataUltil.GetMatchFromMatchId(matchIdBlue);
                if(matchTempblue!=null)
                {
                    if (matchTempblue.Win == "0")
                    {
                        match.NameBlue = matchTempblue.NameRed;
                        match.SchoolBlue = matchTempblue.SchoolRed;
                    }
                    else if (matchTempblue.Win == "1")
                    {
                        match.NameBlue = matchTempblue.NameBlue;
                        match.SchoolBlue = matchTempblue.SchoolBlue;
                    }
                }
            }
            return match;
        }

        //Kiểm tra thông tin này là số người thắng của trận, hay đơn thuần là thông tin
        //Là số trận thì True.
        public Boolean checkIsNumber(string info)
        {
            try
            {
                Convert.ToInt32(info);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Kiểm tra xem trận đấu có hay không
        public Boolean checkMatchExist(string matchId)
        {
            try
            {
                var match = new Match();
                match = TextDataUltil.GetMatchFromMatchId(matchId);
                if (match != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //Lưu trận đấu
        public void SaveMath(string matchId, string win)
        {
            var match = new Match();
            match = TextDataUltil.GetMatchFromMatchId(matchId);
            //Nếu đã tồn tại Match này thì xóa
            if (checkMatchExist(nmrNumberMatch.Value.ToString()))
            {
                TextDataUltil.DeleteMatchByMatchId(matchId);
            }
            match.Win = win;
            try
            {
                TextDataUltil.InsertMatch(match);
            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message);
            }
        }

        //Kiểm tra xem trận đấu đã được chấm chưa. True là đã chấm tức là có dữ liệu != ""
        public Boolean isFighted(string matchId)
        {
            try
            {
                var match = new Match();
                match = TextDataUltil.GetMatchFromMatchId(matchId);
                if (match != null)
                {
                    if (match.Win != "") return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}
