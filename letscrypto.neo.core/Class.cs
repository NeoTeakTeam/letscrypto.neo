using System.Collections.Concurrent;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace letscrypto.neo.core
{
    public class Core
    {
        private const int FORMAT_KEY_LENGTH = 28;

        private Random random = new();
        private string curDir = Environment.CurrentDirectory;
        private int pid = Process.GetCurrentProcess().Id;

        public Dictionary<string, string> VERSION = new()
        {
            { "core", "1.0.0" },
            { "cli", "1.0.0" },
            { "gui", "1.0.0" },
        };

        public void PrintVersion()
        {
            foreach (var kvp in VERSION)
            {
                Console.WriteLine($"VERSION [{kvp.Key}]\t: v{kvp.Value}");
            }
        }

        public int RandomOffset(int min = 3, int max = 32)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }

        public string GenerateKeyStep(int max = 10000)
        {
            string result = "";

            string now = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            int randomNumber = random.Next(0, max + 1);

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(now + randomNumber.ToString() + curDir + pid));
                result += BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }

            return result;
        }

        public string GenerateKey(int count = 20, int max = 10000)
        {
            string result = "";

            // 使用 ConcurrentBag 来收集每个线程生成的部分结果
            ConcurrentBag<string> partialKeys = new();
            int n = 1;

            // 使用 Parallel.For 来并行生成密钥
            Parallel.For(0, count, i =>
            {
                string now = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                int randomNumber = random.Next(0, max + 1);

                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(now + randomNumber.ToString() + curDir + pid));
                    string partialKey = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                    partialKeys.Add(partialKey);
                }
                n += 1;
            });

            // 将所有部分密钥合并成最终的密钥
            result = string.Join("", partialKeys);
            result += new Random().Next(0, 10).ToString();

            return result;
        }

        public string FormatKey(string key)
        {
            string res = "";
            res += new string('-', FORMAT_KEY_LENGTH) + " Key " + new string('-', FORMAT_KEY_LENGTH) + "\n";
            for (int i = 0; i < key.Length; i += FORMAT_KEY_LENGTH * 2 + 5)
            {
                res += key.Substring(i, Math.Min(FORMAT_KEY_LENGTH * 2 + 5, key.Length - i)) + "\n";
            }

            res += new string('-', FORMAT_KEY_LENGTH) + " End " + new string('-', FORMAT_KEY_LENGTH);
            return res;
        }

        public string LoadKey(string key)
        {
            // Remove the header and footer and return as a string
            return key.Substring(
                FORMAT_KEY_LENGTH * 2 + " Key ".Length,
                key.Length - (FORMAT_KEY_LENGTH * 2 + " End ".Length) * 2
            ).Replace("\n", "");
        }

        public bool CheckKey(string key)
        {
            // Check the header and footer
            if (!key.StartsWith(new string('-', FORMAT_KEY_LENGTH) + " Key " + new string('-', FORMAT_KEY_LENGTH)) ||
                !key.EndsWith(new string('-', FORMAT_KEY_LENGTH) + " End " + new string('-', FORMAT_KEY_LENGTH)))
            {
                return false;
            }

            // Check if the middle is empty
            if (string.IsNullOrEmpty(LoadKey(key)))
            {
                return false;
            }

            return true;
        }

        public void Save(string text, string path)
        {
            File.WriteAllText(path, text);
        }

        public string Read(string path)
        {
            return File.ReadAllText(path);
        }

        public string Encrypt(string text, string key, int offset)
        {
            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] resultBytes = new byte[textBytes.Length];

            for (int i = 0; i < textBytes.Length; i++)
            {
                int keyIndex = (i + offset) % keyBytes.Length;
                resultBytes[i] = (byte)(textBytes[i] ^ keyBytes[keyIndex]);
            }

            return Convert.ToBase64String(resultBytes);
        }

        public string Decrypt(string text, string key, int offset)
        {
            byte[] textBytes = Convert.FromBase64String(text);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] resultBytes = new byte[textBytes.Length];

            for (int i = 0; i < textBytes.Length; i++)
            {
                int keyIndex = (i + offset) % keyBytes.Length;
                resultBytes[i] = (byte)(textBytes[i] ^ keyBytes[keyIndex]);
            }

            return Encoding.UTF8.GetString(resultBytes);
        }
    }
}