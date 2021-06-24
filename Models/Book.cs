namespace BookManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(100,ErrorMessage = "Tieu de khong duoc qua 100 ky tu ")]
        [Required(ErrorMessage = "Tieu de khong duoc bo trong")]
        public string Title { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Mo ta khong duoc bo trong")]
        public string Description { get; set; }

        [StringLength(30, ErrorMessage = "Tac gia khong duoc qua 30 ky tu ")]
        [Required(ErrorMessage = "Tac gia khong duoc bo trong")]
        public string Author { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Hinh anh khong duoc bo trong")]
        public string Images { get; set; }

        [Range(1000,1000000, ErrorMessage = "Gia tien nam trong khoang 1000 den 1 cu ")]
        public int? Price { get; set; }
    }
}
