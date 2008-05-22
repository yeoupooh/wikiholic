using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace OpenCsHttp
{
    public class HttpGetter : BaseHttpConnection, IHttpGetter
    {
        public HttpGetter(string url, CookieContainer cc)
            : base(url, cc)
        {
        }

        public HttpGetter(string url, CookieContainer cc, NetworkCredential networkCredential)
            : base(url, cc, networkCredential)
        {
        }

        public HttpResult Get()
        {
            HttpResult result = new HttpResult();

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(m_url);

            req.CookieContainer = m_cc;
            req.Method = "GET";
            if (this.networkCredential != null)
            {
                req.Credentials = this.networkCredential;
            }

            using (HttpWebResponse res = (HttpWebResponse)req.GetResponse())
            {
                using (StreamReader sr = new StreamReader(res.GetResponseStream()))
                {
                    AddCookies(m_cc, req.RequestUri, res);
                }
            }

            return result;
        }
    }
}
