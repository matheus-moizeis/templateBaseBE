using System.Security.AccessControl;
using TBB.Domain.Enum;

namespace TBB.Domain.Entity;

public class Workspace
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public User? User { get; set; }
    public ICollection<ListCard>? ListCards { get; set; }
    public StatusItemEnum Status { get; set; }
    public DateTime CreateAt { get; set; } = DateTime.UtcNow;  
}