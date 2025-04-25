using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dev_scenario_ali_backend.Models
{
    public class StatusLevel
    {
        [Key]

        public int Id { get; set; }

        public string? StatusName { get; set; }
    }
}
