﻿using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace ScoringSystem
{
    class Function
    {
        public string CalNumber(string numString, int subNum)
        {
            int num = Convert.ToInt32(numString);
            num += subNum;
            if (num < 10 && num >= 0)
            {
                return "0" + num.ToString();
            }
            if (num > -10 && num < 0)
            {
                return "-0" + num.ToString().Replace("-", "");
            }
            return num.ToString();
        }

        public string CalClock(int number)
        {
            string min;
            string sec;
            min = CalNumber((number / 60).ToString(), 0);
            int minNu = number / 60;
            sec = CalNumber((number - minNu * 60).ToString(), 0);
            return min + ":" + sec;
        }

        public void PlaySound()
        {
            SoundPlayer Sound = new SoundPlayer(Properties.Resources.Reggg);
            Sound.Play();
        }
    }
}
