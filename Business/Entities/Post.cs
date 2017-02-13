using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dialogue.Logic.Models;
using UmbracoUnderlakare.Business.Entities.Interfaces;

namespace UmbracoUnderlakare.Business.Entities
{
    public class Post : IPost
    {
        public Post(int memberId, string postContent)
        {
            MemberId = memberId;
            PostContent = postContent;
        }
        public int MemberId
        {
            get;
            
        }

        public string PostContent
        {
            get;
            
        }
    }
}