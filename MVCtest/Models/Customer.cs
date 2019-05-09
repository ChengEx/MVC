namespace MVCtest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Customer_ID { get; set; }

        [StringLength(20)]
        public string Customer_Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Customer_BirDate { get; set; }

        [Column("Customer_E-mail")]
        [StringLength(100)]
        public string Customer_E_mail { get; set; }

        [StringLength(10)]
        public string Customer_Phone { get; set; }

        [StringLength(100)]
        public string User_Password { get; set; }
    }
}
