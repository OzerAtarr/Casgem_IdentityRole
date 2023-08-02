using System.ComponentModel.DataAnnotations;

namespace Casgem_IdentityRole.DAL
{
    public class Product
    {
        [Key]
        public int ProcuctId { get; set; }
        public string ProductName { get; set; }
    }
}
