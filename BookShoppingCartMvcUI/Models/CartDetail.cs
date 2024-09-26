using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMvcUI.Models
{
    [Table("CartDetail")]
    public class CartDetail
    {
        public int Id { get; set; }

        [Required]
        public int ShoppingCart_Id { get; set; }

        public int Book_Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        // Navigation properties
        [ForeignKey("Book_Id")]
        public Book Book { get; set; }

        [ForeignKey("ShoppingCart_Id")]
        public ShoppingCart ShoppingCart { get; set; }
    }
}
