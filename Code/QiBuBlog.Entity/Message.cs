//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace QiBuBlog.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public string MsgId { get; set; }
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string Email { get; set; }
        public string HomePage { get; set; }
        public string Content { get; set; }
        public byte Visibility { get; set; }
        public string IP { get; set; }
        public System.DateTime PostTime { get; set; }
    }
}
