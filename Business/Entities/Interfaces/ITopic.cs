using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoUnderlakare.Business.Entities.Interfaces
{
    public interface ITopic
    {
        Guid Id { get; }
        int MemberId { get; }
        string Name { get;}
        int Views { get; }
        DateTime? CreateDate { get; }
        string Slug { get; }

    }
}
