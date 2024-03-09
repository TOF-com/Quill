using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quill.Entities;

public class User
{
    [Key]
    [StringLength(maximumLength:64)]
    public string UserID { get; set; }
    
    [StringLength(maximumLength:128, MinimumLength = 5)]
    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    
    [StringLength(maximumLength:64)]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    [DefaultValue(10)]
    public int Coin { get; set; }
    
    public DateTime DateCreated { get; set; }
    
    public DateTime? DateModified { get; set; }
}