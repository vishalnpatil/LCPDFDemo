using PdfGenerator.Models.Resx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Resources;
using System.Web;



namespace PdfGenerator.Models
{
    [MetadataType(typeof(StudentLCMetaData))]
    public partial class StudentLCData
    {
    }


    public class StudentLCMetaData
    {
        public int Id { get; set; }
       
       [Display(Name ="AdmissionNumber",ResourceType =typeof(SchoolLC))]
      
        public Nullable<int> AdmissionNo { get; set; }
        [Required]
        [Display(Name = "FullName", ResourceType = typeof(SchoolLC))]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "Nationality", ResourceType = typeof(SchoolLC))]
        public string Nationality { get; set; }
        [Required]
        [Display(Name = "MotherTongue", ResourceType = typeof(SchoolLC))]
        public string MotherTongue { get; set; }
        [Required]
        [Display(Name = "Religion", ResourceType = typeof(SchoolLC))]
        public string Religion { get; set; }
        [Required]
        [Display(Name = "Caste", ResourceType = typeof(SchoolLC))]
        public string Caste { get; set; }
        [Display(Name = "SubCaste", ResourceType = typeof(SchoolLC))]
        public string SubCaste { get; set; }
        [Required]
        [Display(Name = "BirthPlace", ResourceType = typeof(SchoolLC))]
        public string BirthPlace { get; set; }
        [Required]
       // [DataType(DataType.DateTime)]
        [Display(Name = "DOBInDigits", ResourceType = typeof(SchoolLC))]
        public string DOBInDigits { get; set; }
        [Display(Name = "DOBInWords", ResourceType = typeof(SchoolLC))]
        public string DOBInWords { get; set; }
        [Display(Name = "PrevSchlName", ResourceType = typeof(SchoolLC))]
        public string PrevSchlName { get; set; }
        [Display(Name = "AdmittedInClass", ResourceType = typeof(SchoolLC))]
        public string AdmittedInClass { get; set; }
        [Display(Name = "AdmissionDate", ResourceType = typeof(SchoolLC))]
        public string AdmissionDate { get; set; }
        [Required]
        [Display(Name = "Progress", ResourceType = typeof(SchoolLC))]
        public string Progress { get; set; }
        [Display(Name = "ConductBehaviour", ResourceType = typeof(SchoolLC))]
        public string ConductBehaviour { get; set; }
        [Required]
        [Display(Name = "DateOfSchlLeaving", ResourceType = typeof(SchoolLC))]
        public string DateOfSchlLeaving { get; set; }
        [Required]
        [Display(Name = "ClassFromLeft", ResourceType = typeof(SchoolLC))]
        public string ClassFromLeft { get; set; }
        [Required]
        [Display(Name = "ReasonForLeaving", ResourceType = typeof(SchoolLC))]
        public string ReasonForLeaving { get; set; }
        [Display(Name = "CertificateRcvdDate", ResourceType = typeof(SchoolLC))]
        public string CertificateRcvdDate { get; set; }
        [Display(Name = "ReceivedByName", ResourceType = typeof(SchoolLC))]
        public string ReceivedByName { get; set; }
    }
}