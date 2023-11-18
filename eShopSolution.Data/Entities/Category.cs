using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Data.Enum;

namespace eShopSolution.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOrder {  get; set; }
        public bool IsShownHome {  get; set; }
        public int? ParentId {  get; set; }
        public Status Status { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
