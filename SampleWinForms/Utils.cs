using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleWinForms
{
    internal static class Utils
    {
        internal static string GenerateRandomChars(int pLengthFrom, int pLengthTo)
        {
            string sResult = "";

            Random rnd = new Random();

            int iLength = rnd.Next(pLengthFrom, pLengthTo);

            for (int i = 0; i < iLength; i++)
            {
                sResult += (char)(rnd.Next((int)'a',(int)'z'));
            }

            return sResult;
        }
    }
}
