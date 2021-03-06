﻿using System;
using System.Runtime.Serialization;

namespace QiBuBlog.Entity.Helper
{
    [Serializable]
    public class BusinessException : Exception
    {
        public BusinessException() { }

        public BusinessException(string message) : base(message) { }

        public BusinessException(string message, Exception inner)
            : base(message, inner) { }


        protected BusinessException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
