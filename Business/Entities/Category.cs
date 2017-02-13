using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UmbracoUnderlakare.Business.Entities.Interfaces;

namespace UmbracoUnderlakare.Business.Entities
{
    public class Category : ICategory
    {
        public Category(int id, 
                        string categoryName,
                        //string description,
                        DateTime? createDate
                        )
        {
            Id = id;          
            CategoryName = categoryName;
            CreateDate = createDate;
            //Description = description;

        }

        public int Id
        {
            get;
        }

        public string CategoryName
        {
            get;
        }

        //public string Description
        //{
        //    get;
        //}
        public DateTime? CreateDate
        {
            get;
        }



    }
}