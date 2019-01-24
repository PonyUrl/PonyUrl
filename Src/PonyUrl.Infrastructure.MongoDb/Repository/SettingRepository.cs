﻿using PonyUrl.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PonyUrl.Infrastructure.MongoDb.Repository
{
    public class SettingRepository : MongoDbRepository<Setting>, ISettingRepository
    {
        public SettingRepository(IMongoDbContext mongoDbContext) : base(mongoDbContext)
        { }
    }
}