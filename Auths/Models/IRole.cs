using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auths.Models
{
    [Table("IRole")]
    public class IRole : BaseObj
    {
        [Display(Name = "角色名"), MaxLength(0x40), Required]
        public string RoleName { get; set; }

        public Status Status { get; set; }
    }
}
