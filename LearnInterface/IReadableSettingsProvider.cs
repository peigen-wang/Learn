using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInterface
{
    interface IReadableSettingsProvider
    {
        string GetSetting(string name, string defaultValue);
    }
}
