﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class TimePeriod
    {
        private int _seconds;
        public int Hours
        {
            get
            {
                return _seconds / 3600;
            }
            set
            {
                if (value < 0 || value > 24)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 24");

                _seconds = value * 3600;
            }
        }
    }
}
