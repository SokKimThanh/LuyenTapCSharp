﻿using System.Collections.Generic;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    class NhapXuat
    {
        public void XuatMang1D(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Write(arr[i] + "\t");
            }
            WriteLine();
        }
        public void XuatMang1D(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                WriteLine(arr[i]);
            }
        }
    }
}
