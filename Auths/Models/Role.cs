using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auths.Models
{
    [Table("Role")]
    public class Role : BaseObj
    {
        [Display(Name = "角色名"), MaxLength(0x40), Required]
        public string RoleName { get; set; }

        public Status Status { get; set; }
    }
}
