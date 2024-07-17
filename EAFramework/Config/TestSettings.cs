﻿using System;
using static EAFramework.Driver.DriverFixture;

namespace EAFramework.Config
{
    public class TestSettings
    {
        public BrowserType BrowserType { get; set; }

        public Uri ApplicationUrl { get; set; }

        public float? TimeoutInternal { get; set; }
    }
}
