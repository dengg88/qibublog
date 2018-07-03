﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace QiBuBlog.Com
{
    /// <summary>
    /// 组件异常类
    /// </summary>
    [Serializable]
    public class ComponentException : Exception
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public ComponentException() { }

        /// <summary>
        /// 使用指定错误消息初始化
        /// </summary>
        /// <param name="message">描述错误的消息</param>
        public ComponentException(string message)
            : base(message) { }

        /// <summary>
        /// 使用异常消息与一个内部异常实例化
        /// </summary>
        /// <param name="message">异常消息</param>
        /// <param name="inner">用于封装在ComponentException内部的异常实例</param>
        public ComponentException(string message, Exception inner)
            : base(message, inner) { }

        /// <summary>
        /// 使用可序列化数据实例化
        /// </summary>
        /// <param name="info">保存序列化对象数据的对象。</param>
        /// <param name="context">有关源或目标的上下文信息。</param>
        protected ComponentException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
