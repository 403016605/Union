using System;

namespace Union.Share
{
    public class PageResult
    {
        public int Total { get; set; }
        public IEquatable<dynamic> Result { get; set; }
    }
}