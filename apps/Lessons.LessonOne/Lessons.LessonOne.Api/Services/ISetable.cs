namespace Lessons.LessonOne.Api.Services
{
    public interface ISetable<TModel>
    {
        void Set(TModel model);
    }
}
