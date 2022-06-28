namespace Notes.Pesistence;
public class DbInitialaizer
{
    public void Initialize(NotesDbContext context)
    {
        context.Database.EnsureCreated();
    }
}

