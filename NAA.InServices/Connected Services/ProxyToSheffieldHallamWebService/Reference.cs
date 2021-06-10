﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NAA.InServices.ProxyToSheffieldHallamWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyToSheffieldHallamWebService.SHUWebServiceSoap")]
    public interface SHUWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SheffCourses", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        NAA.InServices.ProxyToSheffieldHallamWebService.SHUCourse[] SheffCourses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SheffCourses", ReplyAction="*")]
        System.Threading.Tasks.Task<NAA.InServices.ProxyToSheffieldHallamWebService.SHUCourse[]> SheffCoursesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SheffCoursesInShort", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        NAA.InServices.ProxyToSheffieldHallamWebService.ShortSHUCourse[] SheffCoursesInShort();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SheffCoursesInShort", ReplyAction="*")]
        System.Threading.Tasks.Task<NAA.InServices.ProxyToSheffieldHallamWebService.ShortSHUCourse[]> SheffCoursesInShortAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SHUCourse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int courseIdField;
        
        private string cNameField;
        
        private string cRequirementsField;
        
        private string cDescriptionField;
        
        private string cDegreeField;
        
        private string cTarifField;
        
        private string cNSSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int CourseId {
            get {
                return this.courseIdField;
            }
            set {
                this.courseIdField = value;
                this.RaisePropertyChanged("CourseId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string CName {
            get {
                return this.cNameField;
            }
            set {
                this.cNameField = value;
                this.RaisePropertyChanged("CName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string CRequirements {
            get {
                return this.cRequirementsField;
            }
            set {
                this.cRequirementsField = value;
                this.RaisePropertyChanged("CRequirements");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string CDescription {
            get {
                return this.cDescriptionField;
            }
            set {
                this.cDescriptionField = value;
                this.RaisePropertyChanged("CDescription");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string CDegree {
            get {
                return this.cDegreeField;
            }
            set {
                this.cDegreeField = value;
                this.RaisePropertyChanged("CDegree");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string CTarif {
            get {
                return this.cTarifField;
            }
            set {
                this.cTarifField = value;
                this.RaisePropertyChanged("CTarif");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string CNSS {
            get {
                return this.cNSSField;
            }
            set {
                this.cNSSField = value;
                this.RaisePropertyChanged("CNSS");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ShortSHUCourse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int courseIdField;
        
        private string cNameField;
        
        private string cRequirementsField;
        
        private string cDegreeField;
        
        private string cTarifField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int CourseId {
            get {
                return this.courseIdField;
            }
            set {
                this.courseIdField = value;
                this.RaisePropertyChanged("CourseId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string CName {
            get {
                return this.cNameField;
            }
            set {
                this.cNameField = value;
                this.RaisePropertyChanged("CName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string CRequirements {
            get {
                return this.cRequirementsField;
            }
            set {
                this.cRequirementsField = value;
                this.RaisePropertyChanged("CRequirements");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string CDegree {
            get {
                return this.cDegreeField;
            }
            set {
                this.cDegreeField = value;
                this.RaisePropertyChanged("CDegree");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string CTarif {
            get {
                return this.cTarifField;
            }
            set {
                this.cTarifField = value;
                this.RaisePropertyChanged("CTarif");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SHUWebServiceSoapChannel : NAA.InServices.ProxyToSheffieldHallamWebService.SHUWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SHUWebServiceSoapClient : System.ServiceModel.ClientBase<NAA.InServices.ProxyToSheffieldHallamWebService.SHUWebServiceSoap>, NAA.InServices.ProxyToSheffieldHallamWebService.SHUWebServiceSoap {
        
        public SHUWebServiceSoapClient() {
        }
        
        public SHUWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SHUWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SHUWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SHUWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public NAA.InServices.ProxyToSheffieldHallamWebService.SHUCourse[] SheffCourses() {
            return base.Channel.SheffCourses();
        }
        
        public System.Threading.Tasks.Task<NAA.InServices.ProxyToSheffieldHallamWebService.SHUCourse[]> SheffCoursesAsync() {
            return base.Channel.SheffCoursesAsync();
        }
        
        public NAA.InServices.ProxyToSheffieldHallamWebService.ShortSHUCourse[] SheffCoursesInShort() {
            return base.Channel.SheffCoursesInShort();
        }
        
        public System.Threading.Tasks.Task<NAA.InServices.ProxyToSheffieldHallamWebService.ShortSHUCourse[]> SheffCoursesInShortAsync() {
            return base.Channel.SheffCoursesInShortAsync();
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
    }
}
