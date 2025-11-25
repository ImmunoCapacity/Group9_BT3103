using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventDriven.Project.Model
{
    [Table("tblFeeStructure")]
    public class FeeStructure
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string GradeLevel { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal BaseTuition { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal LabFee { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal LibraryFee { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal SportsFee { get; set; }

        // Computed column (read-only)
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal TuitionFee { get; set; }
    }
}
