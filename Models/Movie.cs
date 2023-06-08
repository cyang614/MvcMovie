using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;
public class Movie
{
    public int Id { get; set; }
    [Display(Name = "電影名稱")]
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "上映日期")]
    public DateTime ReleaseDate { get; set; }
    [Display(Name = "類型")]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    public string? Genre { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    [Range(1, 100)]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }
    [RegularExpression(@"[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(5)]
    [Required]
    public string? Rating { get; set; }
}