using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmbracoUnderlakare.Business.Entities;
using UmbracoUnderlakare.Business.Entities.Interfaces;

namespace UmbracoUnderlakare.Business.Services.Interfaces
{
    public interface ITopicsService
    {
        ITopic GetTopicById(Guid id);
        IList<Topic> GetAllTopicsByUser(int memberId);
        ITopicPaging GetRecentTopics(int page, int size);

    }

  
}
