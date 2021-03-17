﻿using System.Linq;

namespace NHttp
{
    public static class HttpRequestEventArgsHelper
    {

        /// <summary>
        /// Shortcut for extracting Http Params
        /// </summary>
        /// <param name="e"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetParam(this HttpRequestEventArgs e, string str) => e.Request.GetParam(str);

        /// <summary>
        /// Shortcut for extracting Http Params
        /// </summary>
        /// <param name="req"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetParam(this HttpRequest req, string str) => req != null && req.Params.AllKeys.Contains(str) ? req.Params[str]?.ToString().Trim() : null;
    }
}
