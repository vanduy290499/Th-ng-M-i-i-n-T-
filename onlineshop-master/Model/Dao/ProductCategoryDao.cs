﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class ProductCategoryDao
    {
        OnlineShopDbContext db = null;
        public ProductCategoryDao()
        {
            db = new OnlineShopDbContext();
        }

        public List<ProductCatagory> ListAll()
        {
            //return db.ProductCategories.Where(x => x.Status == true).OrderBy(x => x.DisplayOrder).ToList();
            return db.ProductCategories.Where(x => x.Status == true).OrderBy(x => x.DisplayOrder).ToList();  
        }

        public ProductCatagory ViewDetail(long id)
        {
            return db.ProductCategories.Find(id);
        }
    }
}
