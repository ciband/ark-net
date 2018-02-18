﻿using System;

namespace ArkNet.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ArkQueryParamAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
