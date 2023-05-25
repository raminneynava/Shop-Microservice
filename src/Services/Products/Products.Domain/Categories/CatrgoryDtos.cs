using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Categories
{
    public class CatrgoryDto : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? ParentCategoryId { get; set; }
        public string Permalink { get; set; }
        public bool Active { get; set; }
        public int Priority { get; set; }
        public string BannerUrl { get; set; }
        public string IconUrl { get; set; }
        public string ThumbnailUrl { get; set; }
    }

    public class CategoryFilterPageReqDto
    {
        public int Id { get; set; }
        public string SearchTerm { get; set; }
        public int? ParentCategoryId { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
