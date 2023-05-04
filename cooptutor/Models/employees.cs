using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cooptutor.Models
{
    public class employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string empId { get; set; }
        public string empName { get; set; }
        public string Email { get; set; }
        public string phoneNumber { get; set; }
        public DateTime hireDate { get; set; }
        public string positionId { get; set; }
    }
}
