namespace CMSPlus.Domain.Models.CommentModels;

public class CommentModel
{
    public string TopicSystemName { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public string Comment { get; set; } = null!;
    public DateTime? CreatedOnUtc { get; set; }
}
