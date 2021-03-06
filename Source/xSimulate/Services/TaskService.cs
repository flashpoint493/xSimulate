﻿using System;
using System.Collections.Generic;
using System.Text;
using xSimulate.Web.Model;

namespace xSimulate.Services
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "TaskServiceServiceSoap", Namespace = "http://tempuri.org/")]
    public partial class TaskService : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        /// <remarks/>
        public TaskService()
        {
        }

        public new string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                base.Url = value;
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTask", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public xSimulate.Web.Model.RetrieveTask GetTask(int customerSysNo)
        {
            object[] results = this.Invoke("GetTask", new object[] {
                        customerSysNo});
            return ((xSimulate.Web.Model.RetrieveTask)(results[0]));
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateRunTaskStatus", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateRunTaskStatus(RetrieveTask retrieveTask)
        {
            this.Invoke("UpdateRunTaskStatus", new object[] {
                        retrieveTask});
        }
    }

}
