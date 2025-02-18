﻿using System;
using System.IO;
using System.Text;

namespace Frends.HIT.Pgp
{
    internal static class PgpHelper
    {
        /// <summary>
        /// Create Key string to Stream
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Stream</returns>
        internal static Stream KeyStringStream(string key)
        {
            if (string.IsNullOrEmpty(key)) return null;
            var keyEncoding = Encoding.UTF8.GetBytes(key);
            return new MemoryStream(keyEncoding);
        }
        /// <summary>
        /// Convert path so it works for OperatingSystem it is running in
        /// </summary>
        /// <param name="path"></param>
        /// <returns>String</returns>
        internal static string GetRightPathForOperatingSystem(string path)
        {
            if (string.IsNullOrEmpty(path)) return null;
            var modifyPath = Path.Combine(path).Replace('/',
                Path.DirectorySeparatorChar);
            return modifyPath;
        }
    }
}