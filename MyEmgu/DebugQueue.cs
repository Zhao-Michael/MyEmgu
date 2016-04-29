﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEmgu
{
    /// <summary>
    /// 显示Debug信息
    /// </summary>
    public class DebugQueue
    {

        private int m_Count;
        public int Count
        {
            get
            {
                return m_Count;
            }
            set
            {
                m_Count = value;
            }
        }

        public DebugQueue()
        {
            Count = 0;
        }


        private string m_Debug;
        public string Debug
        {
            get
            {
                return m_Debug;
            }
            set
            {
                m_Debug = value;
            }
        }

    }
}
