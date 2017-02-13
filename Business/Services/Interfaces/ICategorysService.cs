using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UmbracoUnderlakare.Business.Entities;
using UmbracoUnderlakare.Business.Entities.Interfaces;

namespace UmbracoUnderlakare.Business.Services.Interfaces
{
    public interface ICategorysService
    {
        ICategory GetCategoryById(int id);
        IEnumerable<Category> GetAllSubCategories(Guid parentId);
    }
}