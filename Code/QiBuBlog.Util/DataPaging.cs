﻿using System;
using System.Collections.Generic;

namespace QiBuBlog.Util
{
    public class DataPaging<T>
    {

        public DataPaging()
        {
            Data = new List<T>();
        }

        public int CurrentPage { get; set; }

        public int TotalRecord { get; set; }

        public List<T> Data { get; set; }
    }
}
