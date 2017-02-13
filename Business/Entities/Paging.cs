using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UmbracoUnderlakare.Business.Entities.Interfaces;

namespace UmbracoUnderlakare.Business.Entities
{
    public class Paging : IPaging
    {
        public Paging(bool hasMore, int totalMatching)
        {
            HasMore = hasMore;
            TotalMatching = totalMatching;
        }
        public bool HasMore { get; }
        public int TotalMatching { get; }
    }
}