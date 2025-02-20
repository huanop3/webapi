using System.ComponentModel.DataAnnotations;

namespace web_api.Models;

public class ProductEditVm
{

    [Required(ErrorMessage = "UserName cannot be blank!")]
    [StringLength(10, ErrorMessage = "UserName cannot exceed 10 characters!", MinimumLength = 6)]
    public string Name { get; set; }
    [Required(ErrorMessage = "Price cannot be blank!")]
    public double Price { get; set; }
}