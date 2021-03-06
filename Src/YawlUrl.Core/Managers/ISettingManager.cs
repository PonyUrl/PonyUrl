﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace YawlUrl.Core
{
    public interface ISettingManager
    {
        Task<List<string>> ForbiddenWords();

        Task AddForbiddenWord(string word);

        Task RemoveForbiddenWord(string word);
    }
}
