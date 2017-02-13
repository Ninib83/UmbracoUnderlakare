using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoUnderlakare.Business.Entities.Interfaces
{
    public interface IPostPaging :IPaging
    {
        IEnumerable<IPost> Posts { get; }
    }
}