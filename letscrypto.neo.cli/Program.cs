using letscrypto.neo.core;
using System.Collections.Concurrent;
using System.CommandLine;

Core coreInstance = new();

void GenerateKey(int count, string save)
{
    var key = "";

    if (count < 10000 && count > 100)
    {
        // 使用 ConcurrentBag 来收集每个线程生成的部分结果
        ConcurrentBag<string> partialKeys = new();
        int n = 1;

        // 使用 Parallel.For 来并行生成密钥
        Parallel.For(0, count, i =>
        {
            Console.Write($"Generated key {n} of {count}{new string(' ', count.ToString().Length)}\r");
            // 每个线程生成一个部分密钥
            string partialKey = coreInstance.GenerateKeyStep();
            partialKeys.Add(partialKey); // 将部分密钥添加到集合中
            n += 1;
        });

        // 将所有部分密钥合并成最终的密钥
        key = string.Join("", partialKeys);
        key += new Random().Next(0, 10).ToString();

        // 输出进度信息
        Console.WriteLine($"Generated key {count} of {count}{new string(' ', count.ToString().Length)}");
    }
    else if (count < 100)
    {
        key = coreInstance.GenerateKey(count);
    }
    else
    {
        Console.WriteLine("WARN: Key count is to high!");
        Console.WriteLine("Please wait...");
        key = coreInstance.GenerateKey(count);
    }

    if (string.IsNullOrEmpty(save))
    {
        Console.WriteLine("Generated key:");
        Console.WriteLine(coreInstance.FormatKey(key));
    }
    else
    {
        Console.WriteLine($"Save key to {save}");
        coreInstance.Save(key, save);
    }
}

void RandomOffset(int min, int max)
{
    Console.WriteLine($"Random offset between {min} and {max}: {coreInstance.RandomOffset(min, max)}");
}

void LoadKey(string keyFile)
{
    if (!File.Exists(keyFile))
    {
        Console.WriteLine($"ERROR: Key file {keyFile} does not exist");
        return;
    }

    var tempKey = coreInstance.Read(keyFile);
    if (!coreInstance.CheckKey(tempKey))
    {
        Console.WriteLine($"ERROR: Key file {keyFile} is not a valid key");
        return;
    }
    Console.WriteLine($"Loaded key from {keyFile}:\n{coreInstance.LoadKey(tempKey)}");
}

void Encrypt(string text, string file, string key, string keyFile, int offset, string save, string saveKey)
{
    if (string.IsNullOrEmpty(text) && string.IsNullOrEmpty(file))
    {
        Console.WriteLine("ERROR: You must provide a text or a file to encrypt");
        return;
    }
    else if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(file))
    {
        Console.WriteLine("ERROR: You can't use both text and file options");
        return;
    }

    if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(keyFile))
    {
        Console.WriteLine("ERROR: You can't use both key and key-file options");
    }

    if (!string.IsNullOrEmpty(keyFile) && !string.IsNullOrEmpty(saveKey))
    {
        Console.WriteLine("ERROR: You can't use both key and save-key options");
        return;
    }

    var realKey = "";
    if (!string.IsNullOrEmpty(key))
    {
        realKey = key;
        if (!string.IsNullOrEmpty(saveKey))
        {
            Console.WriteLine($"Save key to {saveKey}");
            coreInstance.Save(coreInstance.FormatKey(realKey), saveKey);
        }
    }
    else if (!string.IsNullOrEmpty(keyFile))
    {
        if (!File.Exists(keyFile))
        {
            Console.WriteLine($"ERROR: Key file {keyFile} does not exist");
            return;
        }

        var tempKey = coreInstance.Read(keyFile);
        if (!coreInstance.CheckKey(tempKey))
        {
            Console.WriteLine($"ERROR: Key file {keyFile} is not a valid key");
            return;
        }

        Console.WriteLine($"Use key file: {keyFile}");
        realKey = coreInstance.LoadKey(tempKey);
    }
    else
    {
        realKey = coreInstance.GenerateKey();
        if (!string.IsNullOrEmpty(saveKey))
        {
            Console.WriteLine($"Save generated key to {saveKey}");
            coreInstance.Save(coreInstance.FormatKey(realKey), saveKey);
        }
        else
        {
            Console.WriteLine("Generated key:");
            Console.WriteLine(coreInstance.FormatKey(realKey));
        }
    }

    var realOffset = 0;
    if (offset != 0)
    {
        realOffset = offset;
    }
    else
    {
        realOffset = 3;
        Console.WriteLine($"Use default offset: 3");
    }

    var realText = "";
    if (!string.IsNullOrEmpty(text))
    {
        realText = text;
    }
    else
    {
        if (!File.Exists(file))
        {
            Console.WriteLine($"ERROR: File {file} does not exist");
            return;
        }

        Console.WriteLine($"Use file {file}");
        realText = coreInstance.Read(file);
    }

    var res = coreInstance.Encrypt(realText, realKey, realOffset);
    if (!string.IsNullOrEmpty(save))
    {
        Console.WriteLine($"Save encrypted text to {save}");
        coreInstance.Save(res, save);
    }
    else
    {
        Console.WriteLine($"Encrypted text: {res}");
    }
}

void Decrypt(string text, string file, string key, string keyFile, int offset, string save)
{
    if (string.IsNullOrEmpty(text) && string.IsNullOrEmpty(file))
    {
        Console.WriteLine("ERROR: You must provide a text or a file to encrypt");
        return;
    }
    else if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(file))
    {
        Console.WriteLine("ERROR: You can't use both text and file options");
        return;
    }

    if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(keyFile))
    {
        Console.WriteLine("ERROR: You can't use both key and key-file options");
        return;
    }

    if (offset == 0)
    {
        Console.WriteLine("ERROR: You must provide an offset");
        return;
    }

    var realKey = "";
    if (!string.IsNullOrEmpty(key))
    {
        realKey = key;
    }
    else
    {
        if (!File.Exists(keyFile))
        {
            Console.WriteLine($"ERROR: Key file {keyFile} does not exist");
            return;
        }

        var tempKey = coreInstance.Read(keyFile);
        if (!coreInstance.CheckKey(tempKey))
        {
            Console.WriteLine($"ERROR: Key file {keyFile} is not a valid key");
            return;
        }

        Console.WriteLine($"Use key file: {keyFile}");
        realKey = coreInstance.LoadKey(tempKey);
    }

    var realText = "";
    if (!string.IsNullOrEmpty(text))
    {
        realText = text;
    }
    else
    {
        if (!File.Exists(file))
        {
            Console.WriteLine($"ERROR: File {file} does not exist");
        }

        Console.WriteLine($"Use file {file}");
        realText = coreInstance.Read(file);
    }

    var res = coreInstance.Decrypt(realText, realKey, offset);
    if (!string.IsNullOrEmpty(save))
    {
        Console.WriteLine($"Save decrypted text to {save}");
        coreInstance.Save(res, save);
    }
    else
    {
        Console.WriteLine($"Decrypted text: {res}");
    }
}

var RootCommand = new RootCommand("Let's encrypt together!");

var GenerateKeyCountOption = new Option<int>(["-c", "--count"], () => 20, description: "Number of keys to generate");
var GenerateKeySaveOption = new Option<string>(["-s", "--save"], description: "Save key to file");
var GenerateKeyCommand = new Command("generate-key", "Generates a key");
GenerateKeyCommand.AddOption(GenerateKeyCountOption);
GenerateKeyCommand.AddOption(GenerateKeySaveOption);

var RandomOffsetMinOption = new Option<int>(["-m", "--min"], () => 3, description: "Minimum offset");
var RandomOffsetMaxOption = new Option<int>(["-M", "--max"], () => 32, description: "Maximum offset");
var RandomOffsetCommand = new Command("random-offset", description: "Generates a random offset");
RandomOffsetCommand.AddOption(RandomOffsetMinOption);
RandomOffsetCommand.AddOption(RandomOffsetMaxOption);

var PrintVersionCommand = new Command("version", description: "Print version and exit");

var EncryptTextOption = new Option<string>(["-t", "--text"], description: "Text to encrypt");
var EncryptFileOption = new Option<string>(["-f", "--file"], description: "File to encrypt");
var EncryptKeyOption = new Option<string>(["-k", "--key"], description: "Key to encrypt with");
var EncryptKeyFileOption = new Option<string>(["-K", "--key-file"], description: "Key file to encrypt with");
var EncryptOffsetOption = new Option<int>(["-o", "--offset"], description: "Offset to encrypt with");
var EncryptSaveOption = new Option<string>(["-s", "--save"], description: "File to save encrypted text to");
var EncryptSaveKeyOption = new Option<string>(["-S", "--save-key"], description: "File to save key to when key is generated");
var EncryptCommand = new Command("encrypt", description: "Encrypts a text or a file");
EncryptCommand.AddOption(EncryptTextOption);
EncryptCommand.AddOption(EncryptFileOption);
EncryptCommand.AddOption(EncryptKeyOption);
EncryptCommand.AddOption(EncryptKeyFileOption);
EncryptCommand.AddOption(EncryptOffsetOption);
EncryptCommand.AddOption(EncryptSaveOption);
EncryptCommand.AddOption(EncryptSaveKeyOption);

var DecryptTextOption = new Option<string>(["-t", "--text"], description: "Text to decrypt");
var DecryptFileOption = new Option<string>(["-f", "--file"], description: "File to decrypt");
var DecryptKeyOption = new Option<string>(["-k", "--key"], description: "Key to decrypt with");
var DecryptKeyFileOption = new Option<string>(["-K", "--key-file"], description: "Key file to decrypt with");
var DecryptOffsetOption = new Option<int>(["-o", "--offset"], description: "Offset to decrypt with");
var DecryptSaveOption = new Option<string>(["-s", "--save"], description: "File to save decrypted text to");
var DecryptCommand = new Command("decrypt", description: "Decrypts a text or a file");
DecryptCommand.AddOption(DecryptTextOption);
DecryptCommand.AddOption(DecryptFileOption);
DecryptCommand.AddOption(DecryptKeyOption);
DecryptCommand.AddOption(DecryptKeyFileOption);
DecryptCommand.AddOption(DecryptOffsetOption);
DecryptCommand.AddOption(DecryptSaveOption);

var LoadKeyFileOption = new Option<string>(["-f", "--file"], description: "Key file to load");
var LoadKeyCommand = new Command("loadkey", description: "Loads a key from a file");
LoadKeyCommand.AddOption(LoadKeyFileOption);

GenerateKeyCommand.SetHandler(GenerateKey, GenerateKeyCountOption, GenerateKeySaveOption);
RandomOffsetCommand.SetHandler(RandomOffset, RandomOffsetMinOption, RandomOffsetMaxOption);
PrintVersionCommand.SetHandler(coreInstance.PrintVersion);
LoadKeyCommand.SetHandler(LoadKey, LoadKeyFileOption);
EncryptCommand.SetHandler(
    Encrypt,
    EncryptTextOption,
    EncryptFileOption,
    EncryptKeyOption,
    EncryptKeyFileOption,
    EncryptOffsetOption,
    EncryptSaveOption,
    EncryptSaveKeyOption
);
DecryptCommand.SetHandler(
    Decrypt,
    DecryptTextOption,
    DecryptFileOption,
    DecryptKeyOption,
    DecryptKeyFileOption,
    DecryptOffsetOption,
    DecryptSaveOption
);

RootCommand.AddCommand(GenerateKeyCommand);
RootCommand.AddCommand(RandomOffsetCommand);
RootCommand.AddCommand(PrintVersionCommand);
RootCommand.AddCommand(EncryptCommand);
RootCommand.AddCommand(DecryptCommand);
RootCommand.AddCommand(LoadKeyCommand);

Console.WriteLine("letscrypto - Let's encrypt together!\n");

return await RootCommand.InvokeAsync(args);
