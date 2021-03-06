﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CPUserControls.WASalesTax {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WASalesTax.serviceSoap")]
    public interface serviceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLocCode", ReplyAction="*")]
        CPUserControls.WASalesTax.GetLocCodeResponse GetLocCode(CPUserControls.WASalesTax.GetLocCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLocCode", ReplyAction="*")]
        System.Threading.Tasks.Task<CPUserControls.WASalesTax.GetLocCodeResponse> GetLocCodeAsync(CPUserControls.WASalesTax.GetLocCodeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLocCodeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetLocCode", Namespace="http://tempuri.org/", Order=0)]
        public CPUserControls.WASalesTax.GetLocCodeRequestBody Body;
        
        public GetLocCodeRequest() {
        }
        
        public GetLocCodeRequest(CPUserControls.WASalesTax.GetLocCodeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetLocCodeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string street;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string city;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string zip;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string loccode;
        
        public GetLocCodeRequestBody() {
        }
        
        public GetLocCodeRequestBody(string street, string city, string zip, string loccode) {
            this.street = street;
            this.city = city;
            this.zip = zip;
            this.loccode = loccode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLocCodeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetLocCodeResponse", Namespace="http://tempuri.org/", Order=0)]
        public CPUserControls.WASalesTax.GetLocCodeResponseBody Body;
        
        public GetLocCodeResponse() {
        }
        
        public GetLocCodeResponse(CPUserControls.WASalesTax.GetLocCodeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetLocCodeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int GetLocCodeResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string loccode;
        
        public GetLocCodeResponseBody() {
        }
        
        public GetLocCodeResponseBody(int GetLocCodeResult, string loccode) {
            this.GetLocCodeResult = GetLocCodeResult;
            this.loccode = loccode;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface serviceSoapChannel : CPUserControls.WASalesTax.serviceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class serviceSoapClient : System.ServiceModel.ClientBase<CPUserControls.WASalesTax.serviceSoap>, CPUserControls.WASalesTax.serviceSoap {
        
        public serviceSoapClient() {
        }
        
        public serviceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public serviceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public serviceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public serviceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CPUserControls.WASalesTax.GetLocCodeResponse CPUserControls.WASalesTax.serviceSoap.GetLocCode(CPUserControls.WASalesTax.GetLocCodeRequest request) {
            return base.Channel.GetLocCode(request);
        }
        
        public int GetLocCode(string street, string city, string zip, ref string loccode) {
            CPUserControls.WASalesTax.GetLocCodeRequest inValue = new CPUserControls.WASalesTax.GetLocCodeRequest();
            inValue.Body = new CPUserControls.WASalesTax.GetLocCodeRequestBody();
            inValue.Body.street = street;
            inValue.Body.city = city;
            inValue.Body.zip = zip;
            inValue.Body.loccode = loccode;
            CPUserControls.WASalesTax.GetLocCodeResponse retVal = ((CPUserControls.WASalesTax.serviceSoap)(this)).GetLocCode(inValue);
            loccode = retVal.Body.loccode;
            return retVal.Body.GetLocCodeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CPUserControls.WASalesTax.GetLocCodeResponse> CPUserControls.WASalesTax.serviceSoap.GetLocCodeAsync(CPUserControls.WASalesTax.GetLocCodeRequest request) {
            return base.Channel.GetLocCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<CPUserControls.WASalesTax.GetLocCodeResponse> GetLocCodeAsync(string street, string city, string zip, string loccode) {
            CPUserControls.WASalesTax.GetLocCodeRequest inValue = new CPUserControls.WASalesTax.GetLocCodeRequest();
            inValue.Body = new CPUserControls.WASalesTax.GetLocCodeRequestBody();
            inValue.Body.street = street;
            inValue.Body.city = city;
            inValue.Body.zip = zip;
            inValue.Body.loccode = loccode;
            return ((CPUserControls.WASalesTax.serviceSoap)(this)).GetLocCodeAsync(inValue);
        }
    }
}
