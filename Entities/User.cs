using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quill.Entities;

[Table("quill_user")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [StringLength(maximumLength:64)]
    [Column("user_id")]
    public string UserID { get; set; }
    
    [StringLength(maximumLength:128, MinimumLength = 5)]
    [Required]
    [DataType(DataType.EmailAddress)]
    [Column("email")]
    public string Email { get; set; }
    
    [StringLength(maximumLength:64)]
    [DataType(DataType.Password)]
    [Column("password")]
    public string Password { get; set; }
    
    [DefaultValue(10)]
    [Column("coin")]
    public int Coin { get; set; }
    
    [Column("date_created")]
    public DateTime DateCreated { get; set; }
    
    [Column("date_modified")]
    public DateTime? DateModified { get; set; }
}