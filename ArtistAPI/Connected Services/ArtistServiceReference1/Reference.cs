﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArtistServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ArtistServiceReference1.ArtistSoap")]
    public interface ArtistSoap
    {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ArtistServiceReference1.HelloWorldResponse HelloWorld(ArtistServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ArtistServiceReference1.HelloWorldResponse> HelloWorldAsync(ArtistServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindByName", ReplyAction="*")]
        ArtistServiceReference1.FindByNameResponse FindByName(ArtistServiceReference1.FindByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindByName", ReplyAction="*")]
        System.Threading.Tasks.Task<ArtistServiceReference1.FindByNameResponse> FindByNameAsync(ArtistServiceReference1.FindByNameRequest request);
        
        // CODEGEN: Generating message contract since element name GetAllResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        ArtistServiceReference1.GetAllResponse GetAll(ArtistServiceReference1.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<ArtistServiceReference1.GetAllResponse> GetAllAsync(ArtistServiceReference1.GetAllRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ArtistServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest()
        {
        }
        
        public HelloWorldRequest(ArtistServiceReference1.HelloWorldRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody
    {
        
        public HelloWorldRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ArtistServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse()
        {
        }
        
        public HelloWorldResponse(ArtistServiceReference1.HelloWorldResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody()
        {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult)
        {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindByNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindByName", Namespace="http://tempuri.org/", Order=0)]
        public ArtistServiceReference1.FindByNameRequestBody Body;
        
        public FindByNameRequest()
        {
        }
        
        public FindByNameRequest(ArtistServiceReference1.FindByNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindByNameRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public FindByNameRequestBody()
        {
        }
        
        public FindByNameRequestBody(string name)
        {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindByNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindByNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public ArtistServiceReference1.FindByNameResponseBody Body;
        
        public FindByNameResponse()
        {
        }
        
        public FindByNameResponse(ArtistServiceReference1.FindByNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindByNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string FindByNameResult;
        
        public FindByNameResponseBody()
        {
        }
        
        public FindByNameResponseBody(string FindByNameResult)
        {
            this.FindByNameResult = FindByNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public ArtistServiceReference1.GetAllRequestBody Body;
        
        public GetAllRequest()
        {
        }
        
        public GetAllRequest(ArtistServiceReference1.GetAllRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllRequestBody
    {
        
        public GetAllRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllResponse", Namespace="http://tempuri.org/", Order=0)]
        public ArtistServiceReference1.GetAllResponseBody Body;
        
        public GetAllResponse()
        {
        }
        
        public GetAllResponse(ArtistServiceReference1.GetAllResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetAllResult;
        
        public GetAllResponseBody()
        {
        }
        
        public GetAllResponseBody(string GetAllResult)
        {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface ArtistSoapChannel : ArtistServiceReference1.ArtistSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class ArtistSoapClient : System.ServiceModel.ClientBase<ArtistServiceReference1.ArtistSoap>, ArtistServiceReference1.ArtistSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ArtistSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(ArtistSoapClient.GetBindingForEndpoint(endpointConfiguration), ArtistSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ArtistSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ArtistSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ArtistSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ArtistSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ArtistSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ArtistServiceReference1.HelloWorldResponse ArtistServiceReference1.ArtistSoap.HelloWorld(ArtistServiceReference1.HelloWorldRequest request)
        {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld()
        {
            ArtistServiceReference1.HelloWorldRequest inValue = new ArtistServiceReference1.HelloWorldRequest();
            inValue.Body = new ArtistServiceReference1.HelloWorldRequestBody();
            ArtistServiceReference1.HelloWorldResponse retVal = ((ArtistServiceReference1.ArtistSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ArtistServiceReference1.HelloWorldResponse> ArtistServiceReference1.ArtistSoap.HelloWorldAsync(ArtistServiceReference1.HelloWorldRequest request)
        {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ArtistServiceReference1.HelloWorldResponse> HelloWorldAsync()
        {
            ArtistServiceReference1.HelloWorldRequest inValue = new ArtistServiceReference1.HelloWorldRequest();
            inValue.Body = new ArtistServiceReference1.HelloWorldRequestBody();
            return ((ArtistServiceReference1.ArtistSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ArtistServiceReference1.FindByNameResponse ArtistServiceReference1.ArtistSoap.FindByName(ArtistServiceReference1.FindByNameRequest request)
        {
            return base.Channel.FindByName(request);
        }
        
        public string FindByName(string name)
        {
            ArtistServiceReference1.FindByNameRequest inValue = new ArtistServiceReference1.FindByNameRequest();
            inValue.Body = new ArtistServiceReference1.FindByNameRequestBody();
            inValue.Body.name = name;
            ArtistServiceReference1.FindByNameResponse retVal = ((ArtistServiceReference1.ArtistSoap)(this)).FindByName(inValue);
            return retVal.Body.FindByNameResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ArtistServiceReference1.FindByNameResponse> ArtistServiceReference1.ArtistSoap.FindByNameAsync(ArtistServiceReference1.FindByNameRequest request)
        {
            return base.Channel.FindByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ArtistServiceReference1.FindByNameResponse> FindByNameAsync(string name)
        {
            ArtistServiceReference1.FindByNameRequest inValue = new ArtistServiceReference1.FindByNameRequest();
            inValue.Body = new ArtistServiceReference1.FindByNameRequestBody();
            inValue.Body.name = name;
            return ((ArtistServiceReference1.ArtistSoap)(this)).FindByNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ArtistServiceReference1.GetAllResponse ArtistServiceReference1.ArtistSoap.GetAll(ArtistServiceReference1.GetAllRequest request)
        {
            return base.Channel.GetAll(request);
        }
        
        public string GetAll()
        {
            ArtistServiceReference1.GetAllRequest inValue = new ArtistServiceReference1.GetAllRequest();
            inValue.Body = new ArtistServiceReference1.GetAllRequestBody();
            ArtistServiceReference1.GetAllResponse retVal = ((ArtistServiceReference1.ArtistSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ArtistServiceReference1.GetAllResponse> ArtistServiceReference1.ArtistSoap.GetAllAsync(ArtistServiceReference1.GetAllRequest request)
        {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<ArtistServiceReference1.GetAllResponse> GetAllAsync()
        {
            ArtistServiceReference1.GetAllRequest inValue = new ArtistServiceReference1.GetAllRequest();
            inValue.Body = new ArtistServiceReference1.GetAllRequestBody();
            return ((ArtistServiceReference1.ArtistSoap)(this)).GetAllAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ArtistSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.ArtistSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ArtistSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:61903/Artist.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.ArtistSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:61903/Artist.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            ArtistSoap,
            
            ArtistSoap12,
        }
    }
}