using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cooptutor.Models
{
    public class position
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string positionId { get; set; }
        public string positionName { get; set; }
        public float baseSalary { get; set; }
        public float salaryIncreaseRate { get; set; }
    }
}
