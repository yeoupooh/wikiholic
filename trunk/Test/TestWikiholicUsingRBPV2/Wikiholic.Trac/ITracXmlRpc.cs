using System;
using System.Collections.Generic;
using System.Text;
using CookComputing.XmlRpc;

namespace Wikiholic.Trac
{
    [XmlRpcUrl("http://localhost:8080/projects/HelloTOW/xmlrpc")]
    public interface ITracXmlRpc : IXmlRpcProxy
    {
        [XmlRpcMethod("wiki.getAllPages")]
        string[] GetAllPages();

        [XmlRpcBegin("wiki.getAllPages")]
        IAsyncResult BeginGetAllPages(
            AsyncCallback acb, object state);

        [XmlRpcEnd]
        string[] EndGetAllPages(IAsyncResult asr);





        [XmlRpcMethod("wiki.getPage")]
        string GetPage(string pageName, int version);

        [XmlRpcBegin("wiki.getPage")]
        IAsyncResult BeginGetPage(string pageName, int version, 
            AsyncCallback acb, object state);

        [XmlRpcEnd]
        string EndGetPage(IAsyncResult asr);
    }
}
