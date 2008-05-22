using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Diagnostics;

namespace OpenCsHttp
{
    public class BaseHttpConnection : IHttpConnection
    {
        protected string m_url;
        protected Encoding m_encoding;
        protected string m_userAgent;
        protected CookieContainer m_cc;
        protected NetworkCredential networkCredential;

        public BaseHttpConnection(string url)
        {
            m_url = url;
        }

        public BaseHttpConnection(string url, CookieContainer cc)
        {
            m_url = url;
            m_cc = cc;
        }

        public BaseHttpConnection(string url, CookieContainer cc, NetworkCredential networkCredential)
        {
            m_url = url;
            m_cc = cc;
            this.networkCredential = networkCredential;
        }

        public BaseHttpConnection(string url, Encoding encoding, string userAgent)
        {
            m_url = url;
            m_encoding = encoding;
            m_userAgent = userAgent;
        }

        public BaseHttpConnection(string url, Encoding encoding, string userAgent, CookieContainer cc)
        {
            m_url = url;
            m_encoding = encoding;
            m_userAgent = userAgent;
            m_cc = cc;
        }

        private void ViewCookies(CookieCollection cc)
        {
            // Display the cookies. 
            Console.WriteLine("Number of cookies: " +
                                cc.Count);
            Console.WriteLine("{0,-20}{1,-20}{2}", "Name", "Value", "Domain");

            for (int i = 0; i < cc.Count; i++)
                Console.WriteLine("{0, -20}{1,-20}{2}",
                                   cc[i].Name,
                                   cc[i].Value,
                                   cc[i].Domain
                                   );
        }

        #region IHttpConnection 멤버

        public void AddCookies(CookieContainer cc, Uri uri, HttpWebResponse res)
        {
            ViewCookies(res.Cookies);

            foreach (string header in res.Headers)
            {
                if (header == "Location")
                {
                    Debug.Print("location=" + res.Headers[header]);
                }
                if (header == "Set-Cookie")
                {
                    Debug.Print("set-cookie=" + res.Headers[header]);
                    cc.SetCookies(res.ResponseUri, res.Headers[header]);
                    //cc.Add(res.Cookies);
                }
            }
        }

        #endregion
    }
}
