//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NAA.InServices.ProxyToSheffieldWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyToSheffieldWebService.SheffieldWebServiceSoap")]
    public interface SheffieldWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SheffCourses", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        NAA.InServices.ProxyToSheffieldWebService.ShefCourse[] SheffCourses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SheffCourses", ReplyAction="*")]
        System.Threading.Tasks.Task<NAA.InServices.ProxyToSheffieldWebService.ShefCourse[]> SheffCoursesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SheffCoursesInShort", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        NAA.InServices.ProxyToSheffieldWebService.ShortSheffCourse[] SheffCoursesInShort();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SheffCoursesInShort", ReplyAction="*")]
        System.Threading.Tasks.Task<NAA.InServices.ProxyToSheffieldWebService.ShortSheffCourse[]> SheffCoursesInShortAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ShefCourse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string nameField;
        
        private string descriptionField;
        
        private string entryReqField;
        
        private System.Nullable<int> tarifField;
        
        private string universityField;
        
        private System.Nullable<int> nSSField;
        
        private string qualificationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("Description");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string EntryReq {
            get {
                return this.entryReqField;
            }
            set {
                this.entryReqField = value;
                this.RaisePropertyChanged("EntryReq");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public System.Nullable<int> Tarif {
            get {
                return this.tarifField;
            }
            set {
                this.tarifField = value;
                this.RaisePropertyChanged("Tarif");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string University {
            get {
                return this.universityField;
            }
            set {
                this.universityField = value;
                this.RaisePropertyChanged("University");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public System.Nullable<int> NSS {
            get {
                return this.nSSField;
            }
            set {
                this.nSSField = value;
                this.RaisePropertyChanged("NSS");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Qualification {
            get {
                return this.qualificationField;
            }
            set {
                this.qualificationField = value;
                this.RaisePropertyChanged("Qualification");
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
    public partial class ShortSheffCourse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string nameField;
        
        private string descriptionField;
        
        private string entryReqField;
        
        private string qualificationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("Description");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string EntryReq {
            get {
                return this.entryReqField;
            }
            set {
                this.entryReqField = value;
                this.RaisePropertyChanged("EntryReq");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Qualification {
            get {
                return this.qualificationField;
            }
            set {
                this.qualificationField = value;
                this.RaisePropertyChanged("Qualification");
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
    public interface SheffieldWebServiceSoapChannel : NAA.InServices.ProxyToSheffieldWebService.SheffieldWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SheffieldWebServiceSoapClient : System.ServiceModel.ClientBase<NAA.InServices.ProxyToSheffieldWebService.SheffieldWebServiceSoap>, NAA.InServices.ProxyToSheffieldWebService.SheffieldWebServiceSoap {
        
        public SheffieldWebServiceSoapClient() {
        }
        
        public SheffieldWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SheffieldWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SheffieldWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SheffieldWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public NAA.InServices.ProxyToSheffieldWebService.ShefCourse[] SheffCourses() {
            return base.Channel.SheffCourses();
        }
        
        public System.Threading.Tasks.Task<NAA.InServices.ProxyToSheffieldWebService.ShefCourse[]> SheffCoursesAsync() {
            return base.Channel.SheffCoursesAsync();
        }
        
        public NAA.InServices.ProxyToSheffieldWebService.ShortSheffCourse[] SheffCoursesInShort() {
            return base.Channel.SheffCoursesInShort();
        }
        
        public System.Threading.Tasks.Task<NAA.InServices.ProxyToSheffieldWebService.ShortSheffCourse[]> SheffCoursesInShortAsync() {
            return base.Channel.SheffCoursesInShortAsync();
        }
    }
}
