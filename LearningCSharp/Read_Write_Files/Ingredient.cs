using System;
using System.Collections.Generic;
using System.Text;

namespace Read_Write_Files
{
    internal class Ingredient
    {
        private string category;
        private string item;
        private string item_type;

        public string p_category { get { return category; } set { category = value; } }
        public string p_item { get; set; }

        public string p_itemType { get; set; }
    }
}
