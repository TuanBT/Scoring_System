using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ScoringSystem.Data
{
    public static class TextDataUltil
    {
        private static string pathMatchText = "Match.txt";

        public static List<Match> ReadMatchText()
        {
            Match match;
            var matches = new List<Match>();
            string[] lines;
            try
            {
                lines = File.ReadAllLines(pathMatchText);
                foreach (string line in lines)
                {
                    string[] cols = line.Split('\t');
                    match = new Match
                    {
                        MatchId = cols[0],
                        MatchInfo = cols[1],
                        MatchType = cols[2],
                        NameRed = cols[3],
                        SchoolRed = cols[4],
                        NameBlue = cols[5],
                        SchoolBlue = cols[6],
                        Win = cols[7],
                    };
                    matches.Add(match);
                }
                return matches;
            }
            catch (Exception)
            {
                MessageBox.Show("Có vấn đề với file " + pathMatchText + ". Vui lòng kiểm tra lại?");
                return null;
            }
            
        }

        public static bool WriteMatchText()
        {
            try
            {
                //hàm sắp xếp Object MATCHES theo thứ tự tăng dần của MatId
                var matches = new List<Match>();
                for (int j = 1; j <= Variable.MATCHES.Count; j++)
                {
                    matches.Add(GetMatchFromMatchId(j.ToString()));
                }
                Variable.MATCHES = matches;

                var lines = new string[Variable.MATCHES.Count];
                int i = 0;
                foreach (var match in Variable.MATCHES)
                {
                    lines[i] = match.MatchId + '\t' + match.MatchInfo + '\t' + match.MatchType + '\t' +
                        match.NameRed + '\t' + match.SchoolRed + '\t' + match.NameBlue + '\t' + match.SchoolBlue + '\t' + match.Win;
                    i++;
                }
                File.WriteAllLines(pathMatchText, lines);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public static Match GetMatchFromMatchId(string matchId)
        {
            foreach (Match match in Variable.MATCHES)
            {
                if (match.MatchId == matchId)
                {
                    return match;
                }
            }
            return null;
        }


        public static bool InsertMatch(Match match)
        {
            try
            {
                Variable.MATCHES.Add(match);
                WriteMatchText();
                return true;
            }
            catch { }
            return false;
        }

        public static bool DeleteMatchByMatchId(string matchId)
        {
            try
            {
                Variable.MATCHES.Remove(GetMatchFromMatchId(matchId));
                // WriteMatchText();
                return true;
            }
            catch { }
            return false;
        }
    }
}
