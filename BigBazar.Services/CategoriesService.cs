﻿using BigBazar.Database;
using BigBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBazar.Services
{
    public class CategoriesService
    {
        public Category GetCategory(int ID)
        {
            using (var context = new BDContext())
            {
                return context.Categories.Find(ID);
            }
        }
        public List<Category> GetCategories()
        {
            using (var context = new BDContext())
            {
                return context.Categories.ToList();
            }
        }
        public List<Category> GetFeaturedCategories()
        {
            using (var context = new BDContext())
            {
                return context.Categories.Where(x => x.IsFeatured && x.ImageURL !=null).ToList();
            }
        }
        public void SaveCategory(Category category)
        {
            using (var context = new BDContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
        public void UpdateCategory(Category category)
        {
            using (var context = new BDContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteCategory(int ID)
        {
            using (var context = new BDContext())
            {
                var category = context.Categories.Find(ID);
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
