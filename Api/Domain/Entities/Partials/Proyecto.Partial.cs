namespace TimesheetApi.Domain.Entities;

public partial class Proyecto
{
    public virtual ICollection<ResourceToProject> ResourceToProjects { get; set; } = new List<ResourceToProject>();
}
