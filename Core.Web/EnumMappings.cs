﻿using System;

namespace Core.Web
{
    public static class EnumMappings
    {
        public static string ToString(TextBoxTypeEnum type)
        {
            switch (type)
            {
                case TextBoxTypeEnum.Text:
                    return "text";
                case TextBoxTypeEnum.Password:
                    return "password";
                default:
                    throw new Exception("error type.");
            }
        }

        public static string ToString(JavaScriptEventEnum @event)
        {
            switch (@event)
            {
                case JavaScriptEventEnum.Click:
                    return "click";
                case JavaScriptEventEnum.Blur:
                    return "blur";
                default:
                    throw new Exception("error type.");
            }
        }
    }
}
