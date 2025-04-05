using System.ComponentModel.DataAnnotations;
using TBB.Domain.Enum;

namespace TBB.Domain.Entity;

public class Card
{
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    [StringLength(110)]
    public string? Title { get; set; }
    
    [StringLength(200)]
    public string? Description { get; set; }
    public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeadLine { get; set; }
    public ListCard? List { get; set; }
    public StatusItemEnum Status { get; set; }
}