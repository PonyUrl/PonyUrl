﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PonyUrl.Application.ShortUrls.Queries.GetAllShortUrl
{
    public class ShortUrlListViewModel
    {
        public IEnumerable<ShortUrlDto> ShortUrls { get; set; }
    }
}