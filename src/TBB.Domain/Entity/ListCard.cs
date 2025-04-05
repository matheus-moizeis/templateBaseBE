using System.ComponentModel.DataAnnotations;
using TBB.Domain.Enum;

namespace TBB.Domain.Entity;

public class ListCard
{
    public Guid Id { get; set; }
    
    [Required]
    public string? Title { get; set; }
    
    public StatusItemEnum Status { get; set; } = StatusItemEnum.Active; 
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public Workspace? Workspace { get; set; }
    public ICollection<Card>? Cards { get; set; }
}
