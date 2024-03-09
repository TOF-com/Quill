namespace Quill.Models;

public class UserChapterUnlock
{
    public Guid UserChapterUnlockId { get; set; }

    public Guid UserId { get; set; }

    public Guid ChapterId { get; set; }

    public DateTime DateUnlocked { get; set; }
    
    public UserChapterUnlock()
    {
        
    }

    public UserChapterUnlock(Guid userChapterUnlockId)
    {
        
    }
}