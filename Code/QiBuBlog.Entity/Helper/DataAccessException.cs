﻿using System;
using System.Runtime.Serialization;

namespace QiBuBlog.Entity.Helper
{
    [Serializable]
    public class DataAccessException : Exception
    {
        public DataAccessException() { }

        public DataAccessException(string message)
            : base(message) { }

        public DataAccessException(string message, Exception inner)
            : base(message, inner) { }

        protected DataAccessException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
