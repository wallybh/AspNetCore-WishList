using System.ComponentModel.DataAnnotations;

namespace WishList.Models
{
    class Item
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Description { get; set; }
    }
}