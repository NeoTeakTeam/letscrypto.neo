using letscrypto.neo.core;

namespace letscrypto.neo.gui.winform
{
    public partial class Main : Form
    {
        private Core coreInstance = new();

        private string textMode = "custom";
        private string keyMode = "custom";

        public void GetVersions()
        {
            AboutVersion.Text = "";
            AboutVersion.Text += $"letscrypto 版本\n";
            AboutVersion.Text += $"核心: {coreInstance.VERSION["core"]}\n";
            AboutVersion.Text += $"命令行: {coreInstance.VERSION["cli"]}\n";
            AboutVersion.Text += $"图形界面: {coreInstance.VERSION["gui"]}";
        }

        public Main()
        {
            InitializeComponent();
            GetVersions();
        }

        private void GettingStartedButton_Click(object sender, EventArgs e)
        {
            PageManager.SelectedIndex = 4;
        }

        private void TextSelectButton_Click(object sender, EventArgs e)
        {
            // 打开系统选择文件
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取选择的文件路径
                string filePath = openFileDialog.FileName;
                // 在文本框中显示文件路径
                TextFilePath.Text = filePath;
            }
        }

        private void KeySelectButton_Click(object sender, EventArgs e)
        {
            // 打开系统选择文件
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Key File (*.key)|*.key|All Files (*.*)|*.*";
            // 禁止多选
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取选择的文件路径
                string filePath = openFileDialog.FileName;
                // 在文本框中显示文件路径
                KeyFilePath.Text = filePath;
            }
        }

        private void KeySaveButton_Click(object sender, EventArgs e)
        {
            // 打开系统保存文件
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Key File (*.key)|*.key|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取选择的文件路径
                string filePath = saveFileDialog.FileName;
                coreInstance.Save(coreInstance.FormatKey(KeyUBox.Text), filePath);
            }
        }

        private void OffsetRandomGenerate_Click(object sender, EventArgs e)
        {
            if (
                int.TryParse(OffsetRandomMin.Text, out int min)
                && int.TryParse(OffsetRandomMax.Text, out int max)
            )
            {
                if (max < min)
                {
                    MessageBox.Show("Maximum offset must be greater than minimum offset", "Error");
                    return;
                }
                if (max == 0 || min == 0)
                {
                    MessageBox.Show("Offset cannot be 0", "Error");
                    return;
                }

                OffsetNumber.Text = coreInstance.RandomOffset(min, max).ToString();
            }
            else
            {
                MessageBox.Show("Minimum offset must be an integer", "Error");
                return;
            }
        }

        private void UseTextUBox_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            if (e.Value)
            {
                textMode = "custom";
            }
            else
            {
                textMode = "file";
            }
        }

        private void UseKeyUBox_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            if (e.Value)
            {
                keyMode = "custom";
            }
            else
            {
                keyMode = "file";
            }
        }

        private void ChangeTextButton_Click(object sender, EventArgs e)
        {
            PageManager.SelectedIndex = 1;
        }

        private void ChangeKeyButton_Click(object sender, EventArgs e)
        {
            PageManager.SelectedIndex = 2;
        }

        private void ChangeOffsetButton_Click(object sender, EventArgs e)
        {
            PageManager.SelectedIndex = 3;
        }

        private void ResultSaveButton_Click(object sender, EventArgs e)
        {
            // 打开系统保存文件
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取选择的文件路径
                string filePath = saveFileDialog.FileName;
                coreInstance.Save(ResultBox.Text, filePath);
            }
        }

        private void KeyGenerateButton_Click(object sender, EventArgs e)
        {
            var key = "";

            if (int.TryParse(KeyGenerateCountBox.Text, out int count))
            {
                KeyUBox.Text = coreInstance.GenerateKey(count);
            }
            else
            {
                MessageBox.Show("Key count must be an integer", "Error");
                return;
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (OffsetNumber.Text.Length == 0 || OffsetNumber.Text == "0")
            {
                MessageBox.Show("Offset cannot be empty or 0", "Error");
                return;
            }
            if (!int.TryParse(OffsetNumber.Text, out int offset))
            {
                MessageBox.Show("Offset must be an integer", "Error");
                return;
            }

            var realText = "";
            if (textMode == "file")
            {
                if (!File.Exists(TextFilePath.Text))
                {
                    MessageBox.Show("File not found", "Error");
                    return;
                }
                realText = coreInstance.Read(TextFilePath.Text);
            }
            else
            {
                if (TextUBox.Text.Length == 0)
                {
                    MessageBox.Show("Text cannot be empty", "Error");
                    return;
                }
                realText = TextUBox.Text;
            }

            var realKey = "";
            if (keyMode == "file")
            {
                if (!File.Exists(KeyFilePath.Text))
                {
                    MessageBox.Show("File not found", "Error");
                    return;
                }
                else
                {
                    var tempKey = coreInstance.Read(KeyFilePath.Text);
                    if (!coreInstance.CheckKey(tempKey))
                    {
                        MessageBox.Show("Key is not valid", "Error");
                        return;
                    }
                    realKey = coreInstance.LoadKey(tempKey);
                }
            }
            else
            {
                if (KeyUBox.Text.Length == 0)
                {
                    MessageBox.Show("Key cannot be empty", "Error");
                    return;
                }
                realKey = KeyUBox.Text;
            }

            var res = coreInstance.Encrypt(realText, realKey, offset);
            ResultBox.Text = res;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (OffsetNumber.Text.Length == 0 || OffsetNumber.Text == "0")
            {
                MessageBox.Show("Offset cannot be empty or 0", "Error");
                return;
            }
            if (!int.TryParse(OffsetNumber.Text, out int offset))
            {
                MessageBox.Show("Offset must be an integer", "Error");
                return;
            }

            var realText = "";
            if (textMode == "file")
            {
                if (!File.Exists(TextFilePath.Text))
                {
                    MessageBox.Show("File not found", "Error");
                    return;
                }
                realText = coreInstance.Read(TextFilePath.Text);
            }
            else
            {
                if (TextUBox.Text.Length == 0)
                {
                    MessageBox.Show("Text cannot be empty", "Error");
                    return;
                }
                realText = TextUBox.Text;
            }

            var realKey = "";
            if (keyMode == "file")
            {
                if (!File.Exists(KeyFilePath.Text))
                {
                    MessageBox.Show("File not found", "Error");
                    return;
                }
                else
                {
                    var tempKey = coreInstance.Read(KeyFilePath.Text);
                    if (!coreInstance.CheckKey(tempKey))
                    {
                        MessageBox.Show("Key is not valid", "Error");
                        return;
                    }
                    realKey = coreInstance.LoadKey(tempKey);
                }
            }
            else
            {
                if (KeyUBox.Text.Length == 0)
                {
                    MessageBox.Show("Key cannot be empty", "Error");
                    return;
                }
                realKey = KeyUBox.Text;
            }

            var res = coreInstance.Decrypt(realText, realKey, offset);
            ResultBox.Text = res;
        }

        private void AImixAEMochaGithub_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://github.com/AImixAE");
            MessageBox.Show("Github link copied to clipboard", "Success");
        }

        private void AImixAEMochaWebsite_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://neoteak.cn");
            MessageBox.Show("Website link copied to clipboard", "Success");
        }

        private void TextSaveButton_Click(object sender, EventArgs e)
        {
            // 打开系统保存文件
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取选择的文件路径
                string filePath = saveFileDialog.FileName;
                coreInstance.Save(coreInstance.FormatKey(TextUBox.Text), filePath);
            }
        }

        private void AImixAEMochaBlog_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://AImixAE.github.com");
            MessageBox.Show("Blog link copied to clipboard", "Success");
        }

        private void ResultCopy_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Length == 0)
            {
                MessageBox.Show("Failed to copy to clipboard", "Warning");
            }
            else
            {
                Clipboard.SetText(ResultBox.Text);
                MessageBox.Show("Result copied to clipboard", "Success");
            }
        }
    }
}
