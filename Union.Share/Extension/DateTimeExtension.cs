using System;

namespace Union.Share.Extension
{
    public static class DateTimeExtension
    {
        public static DateTime CurrentNow(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second);
        }
    }
}