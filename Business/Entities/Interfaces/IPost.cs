﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoUnderlakare.Business.Entities.Interfaces
{
    public interface IPost
    {
        int MemberId { get; }
        string PostContent { get; }

    }
}