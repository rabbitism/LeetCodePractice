﻿using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solution solution = new Solution();
            Timer timer = new Timer();
            timer.Start();
            var input = "tmmzuxt";

            var result = solution.LengthOfLongestSubstring(input);

            #region End Timer
            timer.Stop();
            #endregion 
            Printer.Print(result);
            timer.Result();
        
            
        }
    }
}
