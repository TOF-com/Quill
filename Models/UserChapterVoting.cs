namespace Quill.Models;

public class UserChapterVoting
{
    public Guid UserChapterVotingId { get; set; }

    public Guid ChapterId { get; set; }

    public DateTime DateCreated { get; set; }

    public Guid UserId { get; set; }
    
    public UserChapterVoting()
    {
        
    }

    public UserChapterVoting(Guid userChapterVotingId)
    {
        
    }
}