using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterface
{
    class FileSettingsProvider : ISettingProvider,IReadableSettingsProvider
    {
        #region IServiceProvider接口成员
        public void SetSetting(string name, string value)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IReadableSettingsProvider接口成员
        public string GetSetting(string name, string defaultValue)
        {
            throw new NotImplementedException();
        }
        #endregion

       
    }
}
