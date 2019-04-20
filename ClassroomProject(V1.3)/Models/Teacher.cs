//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassroomProject_V1._3_.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;

    public partial class Teacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teacher()
        {
            this.Questions = new HashSet<Question>();
        }

        public int Id { get; set; }
        public int Lesson_Id { get; set; }
        public string TCno { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public bool Gender { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string eMail { get; set; }
        public string Password { get; set; }
        public Nullable<bool> Status { get; set; }
        public System.DateTime DateOfJoin { get; set; }
        public Nullable<System.DateTime> DateOfLeave { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }
        public string LoginErrorMessage { get; set; }

        public virtual Lesson Lesson { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }
    }
}