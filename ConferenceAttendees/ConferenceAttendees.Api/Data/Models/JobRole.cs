using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConferenceAttendees.Api.Data.Models
{
    public class JobRole : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; } = null;
    }
}
