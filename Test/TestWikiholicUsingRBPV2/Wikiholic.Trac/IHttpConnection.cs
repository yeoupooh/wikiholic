using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace OpenCsHttp
{
    public interface IHttpConnection
    {
        void AddCookies(CookieContainer cc, Uri uri, HttpWebResponse res);
    }
}
