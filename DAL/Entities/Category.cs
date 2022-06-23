using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Category : BaseEntity
    {
        public Category() : base()
        {
        }

        public string Name { get; set; }
        public List<CategoryItem> CategoryItems { get; set; }
    }
}
