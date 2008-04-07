using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using CookComputing.XmlRpc;
using Wikiholic.Trac;
using System.Net;

namespace Wikiholic.Trac
{
    public partial class DCTrac : DockContent
    {
        public DCTrac()
        {
            InitializeComponent();
        }

        private delegate void AddItemDelegate(string msg);
        private void AddItem(string msg)
        {
            if (InvokeRequired == true)
            {
                Invoke(new AddItemDelegate(AddItem), new object[] { msg });
            }
            else
            {
                lstOutput.Items.Add(msg);
            }
        }

        private delegate void SetTextDelegate(string text);
        private void SetText(string text)
        {
            if (InvokeRequired == true)
            {
                Invoke(new SetTextDelegate(SetText), new object[] { text });
            }
            else
            {
                textBox1.Text = text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ITracXmlRpc trac = XmlRpcProxyGen.Create<ITracXmlRpc>();
            trac.Timeout = 10000;
            try
            {
                AsyncCallback acb = new AsyncCallback(GetAllPagesCallback);
                //int num = Convert.ToInt32(txtStateNumber.Text);
                TracAsyncState asyncState = new TracAsyncState(this);
                IAsyncResult asr = trac.BeginGetAllPages(acb, asyncState);
                if (asr.CompletedSynchronously)
                {
                    string[] ret = trac.EndGetAllPages(asr);
                    foreach (string r in ret)
                    {
                        AddItem(r);
                    }
                    //AppendSuccess(ret);
                }
            }
            catch (Exception ex)
            {
                AppendException(ex);
            }
        }

        private void GetAllPagesCallback(IAsyncResult result)
        {
            XmlRpcAsyncResult clientResult = (XmlRpcAsyncResult)result;
            ITracXmlRpc trac = (ITracXmlRpc)clientResult.ClientProtocol;
            TracAsyncState asyncState = (TracAsyncState)result.AsyncState;
            try
            {
                string[] ss = trac.EndGetAllPages(result);
                foreach (string r in ss)
                {
                    AddItem(r);
                }
                //asyncState.theForm.Invoke(new AppendSuccessDelegate(
                //  asyncState.theForm.AppendSuccess), asyncState, s);
            }
            catch (Exception ex)
            {
                asyncState.theForm.Invoke(new AppendExceptionDelegate(
                  asyncState.theForm.AppendException), ex);
            }
        }

        delegate void AppendSuccessDelegate(int stateNum, string stateName);
        delegate void AppendExceptionDelegate(Exception ex);

        private void AppendSuccess(int stateNum, string stateName)
        {
            string s = String.Format("State {0} = {1}", stateNum, stateName);
            lstOutput.Items.Insert(0, s);
        }

        private void AppendException(Exception ex)
        {
            string s;
            try
            {
                throw ex;
            }
            catch (XmlRpcFaultException fex)
            {
                s = String.Format("Fault Response: {0} {1}",
                                  fex.FaultCode, fex.FaultString);
            }
            catch (WebException webEx)
            {
                s = String.Format("WebException: {0}", webEx.Message);
                if (webEx.Response != null)
                    webEx.Response.Close();
            }
            catch (Exception excep)
            {
                s = String.Format("Exception: {0}", excep.Message);
            }
            lstOutput.Items.Insert(0, s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstOutput.SelectedItem != null)
            {
                string wikiPageName = lstOutput.SelectedItem as string;

                ITracXmlRpc trac = XmlRpcProxyGen.Create<ITracXmlRpc>();
                trac.Timeout = 10000;
                try
                {
                    AsyncCallback acb = new AsyncCallback(GetPageCallback);
                    TracAsyncState asyncState = new TracAsyncState(this);
                    IAsyncResult asr = trac.BeginGetPage(wikiPageName, 0, acb, asyncState);
                    if (asr.CompletedSynchronously)
                    {
                        string ret = trac.EndGetPage(asr);
                        SetText(ret);
                    }
                }
                catch (Exception ex)
                {
                    AppendException(ex);
                }
            }
        }

        private void GetPageCallback(IAsyncResult result)
        {
            XmlRpcAsyncResult clientResult = (XmlRpcAsyncResult)result;
            ITracXmlRpc trac = (ITracXmlRpc)clientResult.ClientProtocol;
            TracAsyncState asyncState = (TracAsyncState)result.AsyncState;
            try
            {
                string ret = trac.EndGetPage(result);
                SetText(ret);
            }
            catch (Exception ex)
            {
                asyncState.theForm.Invoke(new AppendExceptionDelegate(
                  asyncState.theForm.AppendException), ex);
            }
        }

    }

    class TracAsyncState
    {
        public DCTrac theForm;

        public TracAsyncState(DCTrac trac)
        {
            theForm = trac;
        }

    }

}