namespace Lessons.LessonOne.Api.Services
{
    public interface IGetable<TModel>
    {
        TModel Get();
    }
}
