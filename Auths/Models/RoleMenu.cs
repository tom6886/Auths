using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auths.Models
{
    [Table("RoleMenu")]
    public class RoleMenu
    {
        [Display(Name = "角色ID"), MaxLength(0x40), Required]
        public string RoleID { get; set; }

        [Display(Name = "菜单ID"), MaxLength(0x40), Required]
        public string MenuID { get; set; }
    }
}
