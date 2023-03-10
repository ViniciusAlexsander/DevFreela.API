namespace DevFreela.Application.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(string title)
        {
            Title = title;
        }

        public string Title { get; set; }
    }
}
