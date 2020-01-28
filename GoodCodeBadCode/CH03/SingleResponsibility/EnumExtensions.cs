using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace GoodCodeBadCode.CH03.SingleResponsibility
{
    public static class EnumExtensions
    {
        public static string Description<T>(this T source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi
                .GetCustomAttributes(typeof(DescriptionAttribute),
                false
            );
            if (attributes?.Length > 0)
                return attributes[0].Description;
            else
                return source.ToString();
        }
    }
}
