﻿using YawlUrl.Core;
using YawlUrl.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using YawlUrl.Common;

namespace YawlUrl.Infrastructure
{
    public class SettingManager : ISettingManager
    {
        private readonly ISettingRepository _settingRepository;

        private const string FORBIDDEN_WORDS_SETTING_NAME = "ForbiddenWords";

        public SettingManager(ISettingRepository settingRepository)
        {
            _settingRepository = settingRepository;
        }

        public async Task AddForbiddenWord(string word)
        {
            Check.ArgumentNotNullOrEmpty(word);

            var setting = (await _settingRepository.GetMany(s => s.Name.Equals(FORBIDDEN_WORDS_SETTING_NAME))).FirstOrDefault();

            var words = ((List<string>)setting.Value);

            if (!words.Any(w => w.Equals(word)))
            {
                words.Add(word);

                setting.SetValue(words);

                await _settingRepository.Update(setting);
            }
        }

        public async Task<List<string>> ForbiddenWords()
        {
            var words = (await _settingRepository.GetMany(s => s.Name.Equals(FORBIDDEN_WORDS_SETTING_NAME))).FirstOrDefault();

            return words == null ? new List<string>() : (List<string>)words.Value;
        }

        public async Task RemoveForbiddenWord(string word)
        {
            Check.ArgumentNotNullOrEmpty(word);

            var setting = (await _settingRepository.GetMany(s => s.Name.Equals(FORBIDDEN_WORDS_SETTING_NAME))).FirstOrDefault();

            var words = ((List<string>)setting.Value);

            if (words.Any(w => w.Equals(word)))
            {
                words.Remove(word);

                setting.SetValue(words);

                await _settingRepository.Update(setting);
            }
        }
    }
}
