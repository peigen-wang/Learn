using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterface
{
    interface ISettingProvider:IReadableSettingsProvider
    {
        void SetSetting(string name, string value);
    }
}
