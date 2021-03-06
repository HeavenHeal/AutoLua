﻿namespace AutoLua.Droid.AutoAccessibility.Accessibility.Event
{
    /// <summary>
    /// Toast 监听事件
    /// </summary>
    [Android.Runtime.Preserve(AllMembers = true)]
    public interface IToastMonitorEvent
    {
        /// <summary>
        /// 监听 Toast
        /// </summary>
        /// <param name="toast"></param>
        public void OnToast(Node.Toast toast);
    }
}