using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Almodhtar.Entities
{
    public class Tag
    {
        [Key]
        public string TagId { get; set; }
        public string TagName { get; set; }

        public virtual ICollection<NewsTag> NewsTags { get; set; }
    }
}
