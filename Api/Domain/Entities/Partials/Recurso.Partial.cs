namespace TimesheetApi.Domain.Entities;

public partial class Recurso
{
    public virtual ICollection<ResourceToProject> ResourceToProjects { get; set; } = new List<ResourceToProject>();
}
