using System;
using System.Collections.Generic;
using System.Text;
using ScoringSystem.Data;

namespace ScoringSystem
{
    public static class Variable
    {
        public static int timeSec = 5;    //120
        public static int timeFree = 4;    //45
        public static int sec = 1;          //0 GL, 1 H1, 2 H2
        public static int type = 0;         //0 dung, 1 chay
        public static int second = 90;     //120
        public static int winTeam = -1;      //0 Red, 1 blue
        public static int LastScore = -1;    //0 Red, 1 blue
        public static List<Match> MATCHES { get; set; }
        public static int[] score = {0, 0, 0, 0, 0, 0}; //Tổng đỏ, tổng xanh, h1 đỏ, h1 xanh, h2 đỏ, h2 xanh
        public static int indexSound = 1;

        public static int pnlMainHeight = 654;
        public static int pnlMainWidth = 1000;
    }
}
