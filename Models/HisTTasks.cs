using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace THE_REAL_ONE.Models
{
    public class HisTTasks
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Title { get; set; }
        [Required, MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Priority { get; set; }
        [Required]
        DateTime DeadLine { get; set; }
        [ForeignKey("HisProjectID")]
        public int HisProjectID { get; set; }
        [ForeignKey("HisTeamMemberID")]
        public int HisTeamMemberID { get; set; }
    }
}
