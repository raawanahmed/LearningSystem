﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2.adminServicesReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CourseData", Namespace="http://schemas.datacontract.org/2004/07/Elearning_WCF_Services.DataModels")]
    [System.SerializableAttribute()]
    public partial class CourseData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CourseDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CourseGenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CourseInstructorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CourseNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CoursePriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CourseDescription {
            get {
                return this.CourseDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.CourseDescriptionField, value) != true)) {
                    this.CourseDescriptionField = value;
                    this.RaisePropertyChanged("CourseDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CourseGenre {
            get {
                return this.CourseGenreField;
            }
            set {
                if ((object.ReferenceEquals(this.CourseGenreField, value) != true)) {
                    this.CourseGenreField = value;
                    this.RaisePropertyChanged("CourseGenre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CourseInstructor {
            get {
                return this.CourseInstructorField;
            }
            set {
                if ((object.ReferenceEquals(this.CourseInstructorField, value) != true)) {
                    this.CourseInstructorField = value;
                    this.RaisePropertyChanged("CourseInstructor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CourseName {
            get {
                return this.CourseNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CourseNameField, value) != true)) {
                    this.CourseNameField = value;
                    this.RaisePropertyChanged("CourseName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CoursePrice {
            get {
                return this.CoursePriceField;
            }
            set {
                if ((this.CoursePriceField.Equals(value) != true)) {
                    this.CoursePriceField = value;
                    this.RaisePropertyChanged("CoursePrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedAt {
            get {
                return this.CreatedAtField;
            }
            set {
                if ((this.CreatedAtField.Equals(value) != true)) {
                    this.CreatedAtField = value;
                    this.RaisePropertyChanged("CreatedAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="adminServicesReference.IadminServices")]
    public interface IadminServices {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IadminServices/addCourse")]
        void addCourse(WindowsFormsApp2.adminServicesReference.CourseData course);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IadminServices/addCourse")]
        System.Threading.Tasks.Task addCourseAsync(WindowsFormsApp2.adminServicesReference.CourseData course);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IadminServices/editCourse")]
        void editCourse(int courseId, WindowsFormsApp2.adminServicesReference.CourseData course);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IadminServices/editCourse")]
        System.Threading.Tasks.Task editCourseAsync(int courseId, WindowsFormsApp2.adminServicesReference.CourseData course);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IadminServices/deleteCourse")]
        void deleteCourse(int courseId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IadminServices/deleteCourse")]
        System.Threading.Tasks.Task deleteCourseAsync(int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IadminServices/getAllCourses", ReplyAction="http://tempuri.org/IadminServices/getAllCoursesResponse")]
        WindowsFormsApp2.adminServicesReference.CourseData[] getAllCourses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IadminServices/getAllCourses", ReplyAction="http://tempuri.org/IadminServices/getAllCoursesResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp2.adminServicesReference.CourseData[]> getAllCoursesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IadminServices/getCourseData", ReplyAction="http://tempuri.org/IadminServices/getCourseDataResponse")]
        WindowsFormsApp2.adminServicesReference.CourseData getCourseData(int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IadminServices/getCourseData", ReplyAction="http://tempuri.org/IadminServices/getCourseDataResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp2.adminServicesReference.CourseData> getCourseDataAsync(int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IadminServices/getAllCoursesIDs", ReplyAction="http://tempuri.org/IadminServices/getAllCoursesIDsResponse")]
        int[] getAllCoursesIDs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IadminServices/getAllCoursesIDs", ReplyAction="http://tempuri.org/IadminServices/getAllCoursesIDsResponse")]
        System.Threading.Tasks.Task<int[]> getAllCoursesIDsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IadminServicesChannel : WindowsFormsApp2.adminServicesReference.IadminServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IadminServicesClient : System.ServiceModel.ClientBase<WindowsFormsApp2.adminServicesReference.IadminServices>, WindowsFormsApp2.adminServicesReference.IadminServices {
        
        public IadminServicesClient() {
        }
        
        public IadminServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IadminServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IadminServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IadminServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void addCourse(WindowsFormsApp2.adminServicesReference.CourseData course) {
            base.Channel.addCourse(course);
        }
        
        public System.Threading.Tasks.Task addCourseAsync(WindowsFormsApp2.adminServicesReference.CourseData course) {
            return base.Channel.addCourseAsync(course);
        }
        
        public void editCourse(int courseId, WindowsFormsApp2.adminServicesReference.CourseData course) {
            base.Channel.editCourse(courseId, course);
        }
        
        public System.Threading.Tasks.Task editCourseAsync(int courseId, WindowsFormsApp2.adminServicesReference.CourseData course) {
            return base.Channel.editCourseAsync(courseId, course);
        }
        
        public void deleteCourse(int courseId) {
            base.Channel.deleteCourse(courseId);
        }
        
        public System.Threading.Tasks.Task deleteCourseAsync(int courseId) {
            return base.Channel.deleteCourseAsync(courseId);
        }
        
        public WindowsFormsApp2.adminServicesReference.CourseData[] getAllCourses() {
            return base.Channel.getAllCourses();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp2.adminServicesReference.CourseData[]> getAllCoursesAsync() {
            return base.Channel.getAllCoursesAsync();
        }
        
        public WindowsFormsApp2.adminServicesReference.CourseData getCourseData(int courseId) {
            return base.Channel.getCourseData(courseId);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp2.adminServicesReference.CourseData> getCourseDataAsync(int courseId) {
            return base.Channel.getCourseDataAsync(courseId);
        }
        
        public int[] getAllCoursesIDs() {
            return base.Channel.getAllCoursesIDs();
        }
        
        public System.Threading.Tasks.Task<int[]> getAllCoursesIDsAsync() {
            return base.Channel.getAllCoursesIDsAsync();
        }
    }
}
