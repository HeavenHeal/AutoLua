﻿using System;
using System.Threading.Tasks;
using Android.OS;
using OpenCvSharp;

namespace AutoLua.Droid.OpenCv
{
    [Android.Runtime.Preserve(AllMembers = true)]
    public class OpenCvHelper
    {
        /// <summary>
        /// 是否初始化
        /// </summary>
        public static bool IsInitialized { get; private set; }
        
    }
}