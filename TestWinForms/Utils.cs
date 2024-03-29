﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestWinForms
{
    internal static class Utils
    {
        static Random rnd = new Random();

        internal static string GenerateRandomChars(int pLengthFrom, int pLengthTo)
        {
            string sResult = "";

            int iLength = rnd.Next(pLengthFrom, pLengthTo);

            for (int i = 0; i < iLength; i++)
            {
                if(rnd.Next(2) == 1)
                    sResult += (char)(rnd.Next((int)'a',(int)'z'));
                else
                    sResult += (char)(rnd.Next((int)'A', (int)'Z'));
            }

            return sResult;
        }
    }
}
