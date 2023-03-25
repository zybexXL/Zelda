using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Zelda
{
    internal static class OSProtect
    {
        static string entropy = Environment.MachineName;

        internal static string Unprotect(string base64text, bool allusers=false)
        {
            if (string.IsNullOrEmpty(base64text)) return base64text;
            byte[] data = Convert.FromBase64String(base64text);
            data = Unprotect(data, allusers);
            return data == null ? null : Encoding.UTF8.GetString(data);
        }

        internal static byte[] Unprotect(byte[] data, bool allusers = false)
        {
            try
            {
                DataProtectionScope scope = allusers ? DataProtectionScope.LocalMachine : DataProtectionScope.CurrentUser;
                if (data != null && data.Length > 0)
                    data = ProtectedData.Unprotect(data, Encoding.UTF8.GetBytes(entropy), scope);
                return data;
            }
            catch { }
            return null;
        }

        internal static string Protect(string text, bool allusers = false)
        {
            if (string.IsNullOrEmpty(text)) return text;
            byte[] data = Encoding.UTF8.GetBytes(text);
            data = Protect(data, allusers);
            return Convert.ToBase64String(data);
        }

        internal static byte[] Protect(byte[] data, bool allusers = false)
        {
            try
            {
                DataProtectionScope scope = allusers ? DataProtectionScope.LocalMachine : DataProtectionScope.CurrentUser;
                if (data != null && data.Length > 0)
                    data = ProtectedData.Protect(data, Encoding.UTF8.GetBytes(entropy), scope);
                return data;
            }
            catch { }
            return null;
        }
    }
}
