﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace Socioboard.Api.DiscoverySearch {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="DiscoverySearchSoap", Namespace="http://tempuri.org/")]
    public partial class DiscoverySearch : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback DiscoverySearchFacebookOperationCompleted;
        
        private System.Threading.SendOrPostCallback DiscoverySearchTwitterOperationCompleted;
        
        private System.Threading.SendOrPostCallback contactSearchFacebookOperationCompleted;
        
        private System.Threading.SendOrPostCallback contactSearchTwitterOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public DiscoverySearch() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_DiscoverySearch_DiscoverySearch;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event DiscoverySearchFacebookCompletedEventHandler DiscoverySearchFacebookCompleted;
        
        /// <remarks/>
        public event DiscoverySearchTwitterCompletedEventHandler DiscoverySearchTwitterCompleted;
        
        /// <remarks/>
        public event contactSearchFacebookCompletedEventHandler contactSearchFacebookCompleted;
        
        /// <remarks/>
        public event contactSearchTwitterCompletedEventHandler contactSearchTwitterCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DiscoverySearchFacebook", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DiscoverySearchFacebook(string UserId, string keyword) {
            object[] results = this.Invoke("DiscoverySearchFacebook", new object[] {
                        UserId,
                        keyword});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DiscoverySearchFacebookAsync(string UserId, string keyword) {
            this.DiscoverySearchFacebookAsync(UserId, keyword, null);
        }
        
        /// <remarks/>
        public void DiscoverySearchFacebookAsync(string UserId, string keyword, object userState) {
            if ((this.DiscoverySearchFacebookOperationCompleted == null)) {
                this.DiscoverySearchFacebookOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDiscoverySearchFacebookOperationCompleted);
            }
            this.InvokeAsync("DiscoverySearchFacebook", new object[] {
                        UserId,
                        keyword}, this.DiscoverySearchFacebookOperationCompleted, userState);
        }
        
        private void OnDiscoverySearchFacebookOperationCompleted(object arg) {
            if ((this.DiscoverySearchFacebookCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DiscoverySearchFacebookCompleted(this, new DiscoverySearchFacebookCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DiscoverySearchTwitter", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DiscoverySearchTwitter(string UserId, string keyword) {
            object[] results = this.Invoke("DiscoverySearchTwitter", new object[] {
                        UserId,
                        keyword});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DiscoverySearchTwitterAsync(string UserId, string keyword) {
            this.DiscoverySearchTwitterAsync(UserId, keyword, null);
        }
        
        /// <remarks/>
        public void DiscoverySearchTwitterAsync(string UserId, string keyword, object userState) {
            if ((this.DiscoverySearchTwitterOperationCompleted == null)) {
                this.DiscoverySearchTwitterOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDiscoverySearchTwitterOperationCompleted);
            }
            this.InvokeAsync("DiscoverySearchTwitter", new object[] {
                        UserId,
                        keyword}, this.DiscoverySearchTwitterOperationCompleted, userState);
        }
        
        private void OnDiscoverySearchTwitterOperationCompleted(object arg) {
            if ((this.DiscoverySearchTwitterCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DiscoverySearchTwitterCompleted(this, new DiscoverySearchTwitterCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/contactSearchFacebook", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string contactSearchFacebook(string keyword) {
            object[] results = this.Invoke("contactSearchFacebook", new object[] {
                        keyword});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void contactSearchFacebookAsync(string keyword) {
            this.contactSearchFacebookAsync(keyword, null);
        }
        
        /// <remarks/>
        public void contactSearchFacebookAsync(string keyword, object userState) {
            if ((this.contactSearchFacebookOperationCompleted == null)) {
                this.contactSearchFacebookOperationCompleted = new System.Threading.SendOrPostCallback(this.OncontactSearchFacebookOperationCompleted);
            }
            this.InvokeAsync("contactSearchFacebook", new object[] {
                        keyword}, this.contactSearchFacebookOperationCompleted, userState);
        }
        
        private void OncontactSearchFacebookOperationCompleted(object arg) {
            if ((this.contactSearchFacebookCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.contactSearchFacebookCompleted(this, new contactSearchFacebookCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/contactSearchTwitter", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string contactSearchTwitter(string keyword) {
            object[] results = this.Invoke("contactSearchTwitter", new object[] {
                        keyword});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void contactSearchTwitterAsync(string keyword) {
            this.contactSearchTwitterAsync(keyword, null);
        }
        
        /// <remarks/>
        public void contactSearchTwitterAsync(string keyword, object userState) {
            if ((this.contactSearchTwitterOperationCompleted == null)) {
                this.contactSearchTwitterOperationCompleted = new System.Threading.SendOrPostCallback(this.OncontactSearchTwitterOperationCompleted);
            }
            this.InvokeAsync("contactSearchTwitter", new object[] {
                        keyword}, this.contactSearchTwitterOperationCompleted, userState);
        }
        
        private void OncontactSearchTwitterOperationCompleted(object arg) {
            if ((this.contactSearchTwitterCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.contactSearchTwitterCompleted(this, new contactSearchTwitterCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void DiscoverySearchFacebookCompletedEventHandler(object sender, DiscoverySearchFacebookCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DiscoverySearchFacebookCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DiscoverySearchFacebookCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void DiscoverySearchTwitterCompletedEventHandler(object sender, DiscoverySearchTwitterCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DiscoverySearchTwitterCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DiscoverySearchTwitterCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void contactSearchFacebookCompletedEventHandler(object sender, contactSearchFacebookCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class contactSearchFacebookCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal contactSearchFacebookCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void contactSearchTwitterCompletedEventHandler(object sender, contactSearchTwitterCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class contactSearchTwitterCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal contactSearchTwitterCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591