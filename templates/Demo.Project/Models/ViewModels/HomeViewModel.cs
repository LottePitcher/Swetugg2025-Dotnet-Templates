using Demo.Project.Models.PublishedModels;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Demo.Project.Models.ViewModels
{
    public class HomeViewModel : Home
    {
        public HomeViewModel(IPublishedContent content, IPublishedValueFallback publishedValueFallback) : base(content, publishedValueFallback)
        {
        }
    }
}
