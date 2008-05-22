using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCsHttp
{
    public interface IHttpGetter : IHttpConnection
    {
        HttpResult Get();
    }
}
