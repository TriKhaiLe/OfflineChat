using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh1.Services
{
    public static class FilePathManager
    {
        private static Dictionary<string, string> filePaths = new Dictionary<string, string>();

        public static void AddFilePath(string key, string path)
        {
            if (!filePaths.ContainsKey(key))
                filePaths.Add(key, path);
            else
                filePaths[key] = path;
        }

        public static string GetFilePath(string key)
        {
            if (filePaths.ContainsKey(key))
                return filePaths[key];
            else
                return null; // Hoặc có thể trả về một giá trị mặc định hoặc ném một ngoại lệ
        }

        // Các phương thức khác để thao tác với đường dẫn

    }
}
