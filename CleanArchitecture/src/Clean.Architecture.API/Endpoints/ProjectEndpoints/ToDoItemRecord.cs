namespace Clean.Architecture.API.Endpoints.ProjectEndpoints;

public record ToDoItemRecord(int Id, string Title, string Description, bool IsDone, int? ContributorId);
