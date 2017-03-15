using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClass
{
    public static class DirectoryInfoExtension
    {
        public static void CopyTo(DirectoryInfo sourceDirectory,string target,SearchOption option,string searchPattern)
        {
            if (target[target.Length - 1] != Path.DirectorySeparatorChar)
            {
                target += Path.DirectorySeparatorChar;
            }
            if (!Directory.Exists(target))
            {
                Directory.CreateDirectory(target);
            }
            for (int i = 0; i < searchPattern.Length; i++)
            {
                foreach (var file in Directory.GetFiles(sourceDirectory.FullName,searchPattern))
                {
                    File.Copy(file, target + Path.GetFileName(file), true);
                }
            }
            if (option == SearchOption.AllDirectories)
            {
                foreach (var element in Directory.GetDirectories(sourceDirectory.FullName))
                {
                    //Copy(element, target + Path.GetFileName(element), searchPattern);
                }
            }
        }
    }
}
