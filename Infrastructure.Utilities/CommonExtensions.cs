﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Utilities
{
    public static class CommonExtensions
    {
        /// <summary>
        /// Checks if the specified object is null.
        /// </summary>
        /// <param name="obj">THe object to check.</param>
        /// <returns>(Boolean) True if null, False if not null.</returns>
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        public static bool IsObjectNullOrEmpty(this object obj)
        {
            return obj.IsNull() || obj.ToString().IsEmptyString();
        }


        /// <summary>
        /// Checks if the specified string is empty.
        /// </summary>
        /// <param name="str">The string to chec.k</param>
        /// <returns>(Bool) True if empty, False if not.</returns>
        public static bool IsEmptyString(this string str)
        {
            return str == string.Empty || str == null || String.IsNullOrWhiteSpace(str);
        }
    }
}
