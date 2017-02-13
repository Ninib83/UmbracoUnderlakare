using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UmbracoUnderlakare.Business.Entities.Interfaces;
using UmbracoUnderlakare.Business.Entities;

namespace UmbracoUnderlakare.Business.Services.Interfaces
{
    public interface IPostsService
    {
        List<Post> GetPostByMemberId(int memberId);

    }
}