namespace letscrypto.neo.gui.winform
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AntdUI.Tabs.StyleLine styleLine2 = new AntdUI.Tabs.StyleLine();
            AntdUI.Tabs.StyleLine styleLine1 = new AntdUI.Tabs.StyleLine();
            Title = new AntdUI.Label();
            PageManager = new AntdUI.Tabs();
            HomePage = new AntdUI.TabPage();
            HomeDotNEO = new AntdUI.Label();
            HomeIcon = new AntdUI.Image3D();
            GettingStartedButton = new AntdUI.Button();
            SubTitile = new AntdUI.Label();
            TextPage = new AntdUI.TabPage();
            TextSaveButton = new AntdUI.Button();
            UseTextFile = new AntdUI.Radio();
            UseTextUBox = new AntdUI.Radio();
            TextSelectButton = new Button();
            TextFilePath = new TextBox();
            TextLoadFromFileTip = new AntdUI.Label();
            TextUBox = new TextBox();
            TextTitle = new AntdUI.Label();
            KeyPage = new AntdUI.TabPage();
            KeyGenerateButton = new Button();
            KeyGenerateCountBox = new TextBox();
            KeyGenerateTip = new AntdUI.Label();
            KeySaveButton = new AntdUI.Button();
            UseKeyFile = new AntdUI.Radio();
            UseKeyUBox = new AntdUI.Radio();
            KeySelectButton = new Button();
            KeyFilePath = new TextBox();
            KeyLoadFromFileTip = new AntdUI.Label();
            KeyUBox = new TextBox();
            KeyTitle = new AntdUI.Label();
            OffsetPage = new AntdUI.TabPage();
            OffsetRandomGenerate = new AntdUI.Button();
            OffsetRandomMinAndMax = new AntdUI.Label();
            OffsetRandomMax = new AntdUI.InputNumber();
            OffsetRandomMin = new AntdUI.InputNumber();
            OffsetRandomTip = new AntdUI.Label();
            OffsetNumber = new AntdUI.InputNumber();
            OffsetTitle = new AntdUI.Label();
            EncryptOrDecryptPage = new AntdUI.TabPage();
            EncryptButton = new Button();
            DecryptButton = new Button();
            ChangeOffsetButton = new AntdUI.Button();
            ChangeKeyButton = new AntdUI.Button();
            ChangeTextButton = new AntdUI.Button();
            ResultSaveButton = new Button();
            ResultBox = new TextBox();
            ResultTip = new AntdUI.Label();
            EncryptOrDecryptTitle = new AntdUI.Label();
            SettingsPage = new AntdUI.TabPage();
            SettingsTitle = new AntdUI.Label();
            AboutPage = new AntdUI.TabPage();
            AboutVersion = new AntdUI.Label();
            AboutDotNEO = new AntdUI.Label();
            AboutInfo = new AntdUI.Label();
            AuthorGroup = new GroupBox();
            AuthorTab = new AntdUI.Tabs();
            AuthorAImixAEMocha = new AntdUI.TabPage();
            AImixAEMochaBlog = new AntdUI.Button();
            AImixAEMochaWebsite = new AntdUI.Button();
            AImixAEMochaGithub = new AntdUI.Button();
            AboutSubTitle = new AntdUI.Label();
            AboutTitle = new AntdUI.Label();
            AboutIcon = new AntdUI.Image3D();
            ResultCopy = new Button();
            PageManager.SuspendLayout();
            HomePage.SuspendLayout();
            TextPage.SuspendLayout();
            KeyPage.SuspendLayout();
            OffsetPage.SuspendLayout();
            EncryptOrDecryptPage.SuspendLayout();
            SettingsPage.SuspendLayout();
            AboutPage.SuspendLayout();
            AuthorGroup.SuspendLayout();
            AuthorTab.SuspendLayout();
            AuthorAImixAEMocha.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(349, 236);
            Title.Name = "Title";
            Title.Size = new Size(121, 33);
            Title.TabIndex = 0;
            Title.Text = "Letscrypto";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PageManager
            // 
            PageManager.Dock = DockStyle.Fill;
            PageManager.Location = new Point(0, 0);
            PageManager.Name = "PageManager";
            PageManager.Pages.Add(HomePage);
            PageManager.Pages.Add(TextPage);
            PageManager.Pages.Add(KeyPage);
            PageManager.Pages.Add(OffsetPage);
            PageManager.Pages.Add(EncryptOrDecryptPage);
            PageManager.Pages.Add(SettingsPage);
            PageManager.Pages.Add(AboutPage);
            //PageManager.SelectedIndex = 4;
            PageManager.Size = new Size(860, 463);
            PageManager.Style = styleLine2;
            PageManager.TabIndex = 1;
            PageManager.Text = "PageManager";
            // 
            // HomePage
            // 
            HomePage.Controls.Add(HomeDotNEO);
            HomePage.Controls.Add(HomeIcon);
            HomePage.Controls.Add(GettingStartedButton);
            HomePage.Controls.Add(SubTitile);
            HomePage.Controls.Add(Title);
            HomePage.Location = new Point(-854, -432);
            HomePage.Name = "HomePage";
            HomePage.Size = new Size(854, 432);
            HomePage.TabIndex = 0;
            HomePage.Text = "Home";
            // 
            // HomeDotNEO
            // 
            HomeDotNEO.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeDotNEO.Location = new Point(461, 236);
            HomeDotNEO.Name = "HomeDotNEO";
            HomeDotNEO.Size = new Size(55, 33);
            HomeDotNEO.TabIndex = 6;
            HomeDotNEO.Text = ".neo";
            // 
            // HomeIcon
            // 
            HomeIcon.Image = Properties.Resources.icon;
            HomeIcon.Location = new Point(333, 56);
            HomeIcon.Name = "HomeIcon";
            HomeIcon.Size = new Size(180, 174);
            HomeIcon.TabIndex = 4;
            HomeIcon.Text = "icon";
            // 
            // GettingStartedButton
            // 
            GettingStartedButton.BackHover = Color.AliceBlue;
            GettingStartedButton.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GettingStartedButton.Location = new Point(9, 368);
            GettingStartedButton.Name = "GettingStartedButton";
            GettingStartedButton.Size = new Size(836, 55);
            GettingStartedButton.TabIndex = 3;
            GettingStartedButton.Text = "Getting Started";
            GettingStartedButton.Click += GettingStartedButton_Click;
            // 
            // SubTitile
            // 
            SubTitile.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubTitile.Location = new Point(342, 267);
            SubTitile.Name = "SubTitile";
            SubTitile.Size = new Size(165, 23);
            SubTitile.TabIndex = 1;
            SubTitile.Text = "Let's encrypt together!";
            SubTitile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextPage
            // 
            TextPage.Controls.Add(TextSaveButton);
            TextPage.Controls.Add(UseTextFile);
            TextPage.Controls.Add(UseTextUBox);
            TextPage.Controls.Add(TextSelectButton);
            TextPage.Controls.Add(TextFilePath);
            TextPage.Controls.Add(TextLoadFromFileTip);
            TextPage.Controls.Add(TextUBox);
            TextPage.Controls.Add(TextTitle);
            TextPage.Location = new Point(-854, -432);
            TextPage.Name = "TextPage";
            TextPage.Size = new Size(854, 432);
            TextPage.TabIndex = 4;
            TextPage.Text = "Text";
            // 
            // TextSaveButton
            // 
            TextSaveButton.Location = new Point(761, 3);
            TextSaveButton.Name = "TextSaveButton";
            TextSaveButton.Size = new Size(84, 27);
            TextSaveButton.TabIndex = 13;
            TextSaveButton.Text = "Save";
            TextSaveButton.Click += TextSaveButton_Click;
            // 
            // UseTextFile
            // 
            UseTextFile.Location = new Point(214, 6);
            UseTextFile.Name = "UseTextFile";
            UseTextFile.Size = new Size(118, 23);
            UseTextFile.TabIndex = 6;
            UseTextFile.Text = "File";
            // 
            // UseTextUBox
            // 
            UseTextUBox.Checked = true;
            UseTextUBox.Location = new Point(90, 6);
            UseTextUBox.Name = "UseTextUBox";
            UseTextUBox.Size = new Size(118, 23);
            UseTextUBox.TabIndex = 5;
            UseTextUBox.Text = "Custom text";
            UseTextUBox.CheckedChanged += UseTextUBox_CheckedChanged;
            // 
            // TextSelectButton
            // 
            TextSelectButton.Location = new Point(815, 405);
            TextSelectButton.Name = "TextSelectButton";
            TextSelectButton.Size = new Size(30, 26);
            TextSelectButton.TabIndex = 4;
            TextSelectButton.Text = "...";
            TextSelectButton.UseVisualStyleBackColor = true;
            TextSelectButton.Click += TextSelectButton_Click;
            // 
            // TextFilePath
            // 
            TextFilePath.Location = new Point(110, 406);
            TextFilePath.Name = "TextFilePath";
            TextFilePath.Size = new Size(699, 23);
            TextFilePath.TabIndex = 3;
            // 
            // TextLoadFromFileTip
            // 
            TextLoadFromFileTip.Location = new Point(9, 405);
            TextLoadFromFileTip.Name = "TextLoadFromFileTip";
            TextLoadFromFileTip.Size = new Size(102, 23);
            TextLoadFromFileTip.TabIndex = 2;
            TextLoadFromFileTip.Text = "Load from a file";
            // 
            // TextUBox
            // 
            TextUBox.AcceptsReturn = true;
            TextUBox.AcceptsTab = true;
            TextUBox.Location = new Point(9, 35);
            TextUBox.Multiline = true;
            TextUBox.Name = "TextUBox";
            TextUBox.ScrollBars = ScrollBars.Vertical;
            TextUBox.Size = new Size(836, 364);
            TextUBox.TabIndex = 1;
            // 
            // TextTitle
            // 
            TextTitle.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextTitle.Location = new Point(9, 6);
            TextTitle.Name = "TextTitle";
            TextTitle.Size = new Size(75, 23);
            TextTitle.TabIndex = 0;
            TextTitle.Text = "Text";
            // 
            // KeyPage
            // 
            KeyPage.Controls.Add(KeyGenerateButton);
            KeyPage.Controls.Add(KeyGenerateCountBox);
            KeyPage.Controls.Add(KeyGenerateTip);
            KeyPage.Controls.Add(KeySaveButton);
            KeyPage.Controls.Add(UseKeyFile);
            KeyPage.Controls.Add(UseKeyUBox);
            KeyPage.Controls.Add(KeySelectButton);
            KeyPage.Controls.Add(KeyFilePath);
            KeyPage.Controls.Add(KeyLoadFromFileTip);
            KeyPage.Controls.Add(KeyUBox);
            KeyPage.Controls.Add(KeyTitle);
            KeyPage.Location = new Point(-854, -432);
            KeyPage.Name = "KeyPage";
            KeyPage.Size = new Size(854, 432);
            KeyPage.TabIndex = 5;
            KeyPage.Text = "Key";
            // 
            // KeyGenerateButton
            // 
            KeyGenerateButton.Location = new Point(761, 373);
            KeyGenerateButton.Name = "KeyGenerateButton";
            KeyGenerateButton.Size = new Size(84, 26);
            KeyGenerateButton.TabIndex = 15;
            KeyGenerateButton.Text = "Generate";
            KeyGenerateButton.UseVisualStyleBackColor = true;
            KeyGenerateButton.Click += KeyGenerateButton_Click;
            // 
            // KeyGenerateCountBox
            // 
            KeyGenerateCountBox.Location = new Point(161, 375);
            KeyGenerateCountBox.Name = "KeyGenerateCountBox";
            KeyGenerateCountBox.Size = new Size(594, 23);
            KeyGenerateCountBox.TabIndex = 14;
            KeyGenerateCountBox.Text = "20";
            // 
            // KeyGenerateTip
            // 
            KeyGenerateTip.Location = new Point(9, 374);
            KeyGenerateTip.Name = "KeyGenerateTip";
            KeyGenerateTip.Size = new Size(146, 23);
            KeyGenerateTip.TabIndex = 13;
            KeyGenerateTip.Text = "The count to generate";
            // 
            // KeySaveButton
            // 
            KeySaveButton.Location = new Point(755, 0);
            KeySaveButton.Name = "KeySaveButton";
            KeySaveButton.Size = new Size(84, 27);
            KeySaveButton.TabIndex = 12;
            KeySaveButton.Text = "Save";
            KeySaveButton.Click += KeySaveButton_Click;
            // 
            // UseKeyFile
            // 
            UseKeyFile.Location = new Point(210, 4);
            UseKeyFile.Name = "UseKeyFile";
            UseKeyFile.Size = new Size(118, 23);
            UseKeyFile.TabIndex = 11;
            UseKeyFile.Text = "File";
            // 
            // UseKeyUBox
            // 
            UseKeyUBox.Checked = true;
            UseKeyUBox.Location = new Point(86, 4);
            UseKeyUBox.Name = "UseKeyUBox";
            UseKeyUBox.Size = new Size(118, 23);
            UseKeyUBox.TabIndex = 10;
            UseKeyUBox.Text = "Custom key";
            UseKeyUBox.CheckedChanged += UseKeyUBox_CheckedChanged;
            // 
            // KeySelectButton
            // 
            KeySelectButton.Location = new Point(815, 405);
            KeySelectButton.Name = "KeySelectButton";
            KeySelectButton.Size = new Size(30, 26);
            KeySelectButton.TabIndex = 9;
            KeySelectButton.Text = "...";
            KeySelectButton.UseVisualStyleBackColor = true;
            KeySelectButton.Click += KeySelectButton_Click;
            // 
            // KeyFilePath
            // 
            KeyFilePath.Location = new Point(110, 406);
            KeyFilePath.Name = "KeyFilePath";
            KeyFilePath.Size = new Size(699, 23);
            KeyFilePath.TabIndex = 8;
            // 
            // KeyLoadFromFileTip
            // 
            KeyLoadFromFileTip.Location = new Point(9, 405);
            KeyLoadFromFileTip.Name = "KeyLoadFromFileTip";
            KeyLoadFromFileTip.Size = new Size(102, 23);
            KeyLoadFromFileTip.TabIndex = 7;
            KeyLoadFromFileTip.Text = "Load from a file";
            // 
            // KeyUBox
            // 
            KeyUBox.Location = new Point(9, 33);
            KeyUBox.Multiline = true;
            KeyUBox.Name = "KeyUBox";
            KeyUBox.ScrollBars = ScrollBars.Vertical;
            KeyUBox.Size = new Size(836, 335);
            KeyUBox.TabIndex = 6;
            // 
            // KeyTitle
            // 
            KeyTitle.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyTitle.Location = new Point(9, 4);
            KeyTitle.Name = "KeyTitle";
            KeyTitle.Size = new Size(75, 23);
            KeyTitle.TabIndex = 5;
            KeyTitle.Text = "Key";
            // 
            // OffsetPage
            // 
            OffsetPage.Controls.Add(OffsetRandomGenerate);
            OffsetPage.Controls.Add(OffsetRandomMinAndMax);
            OffsetPage.Controls.Add(OffsetRandomMax);
            OffsetPage.Controls.Add(OffsetRandomMin);
            OffsetPage.Controls.Add(OffsetRandomTip);
            OffsetPage.Controls.Add(OffsetNumber);
            OffsetPage.Controls.Add(OffsetTitle);
            OffsetPage.Location = new Point(-854, -432);
            OffsetPage.Name = "OffsetPage";
            OffsetPage.Size = new Size(854, 432);
            OffsetPage.TabIndex = 6;
            OffsetPage.Text = "Offset";
            // 
            // OffsetRandomGenerate
            // 
            OffsetRandomGenerate.BackHover = Color.AliceBlue;
            OffsetRandomGenerate.Location = new Point(672, 181);
            OffsetRandomGenerate.Name = "OffsetRandomGenerate";
            OffsetRandomGenerate.Size = new Size(170, 49);
            OffsetRandomGenerate.TabIndex = 12;
            OffsetRandomGenerate.Text = "Generate";
            OffsetRandomGenerate.Click += OffsetRandomGenerate_Click;
            // 
            // OffsetRandomMinAndMax
            // 
            OffsetRandomMinAndMax.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OffsetRandomMinAndMax.Location = new Point(207, 127);
            OffsetRandomMinAndMax.Name = "OffsetRandomMinAndMax";
            OffsetRandomMinAndMax.Size = new Size(62, 23);
            OffsetRandomMinAndMax.TabIndex = 11;
            OffsetRandomMinAndMax.Text = "-";
            OffsetRandomMinAndMax.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OffsetRandomMax
            // 
            OffsetRandomMax.Location = new Point(275, 116);
            OffsetRandomMax.Name = "OffsetRandomMax";
            OffsetRandomMax.Size = new Size(567, 47);
            OffsetRandomMax.TabIndex = 10;
            OffsetRandomMax.Text = "0";
            // 
            // OffsetRandomMin
            // 
            OffsetRandomMin.Location = new Point(9, 116);
            OffsetRandomMin.Name = "OffsetRandomMin";
            OffsetRandomMin.Size = new Size(192, 47);
            OffsetRandomMin.TabIndex = 9;
            OffsetRandomMin.Text = "0";
            // 
            // OffsetRandomTip
            // 
            OffsetRandomTip.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OffsetRandomTip.Location = new Point(9, 87);
            OffsetRandomTip.Name = "OffsetRandomTip";
            OffsetRandomTip.Size = new Size(99, 23);
            OffsetRandomTip.TabIndex = 8;
            OffsetRandomTip.Text = "Random";
            // 
            // OffsetNumber
            // 
            OffsetNumber.Location = new Point(9, 34);
            OffsetNumber.Name = "OffsetNumber";
            OffsetNumber.Size = new Size(833, 47);
            OffsetNumber.TabIndex = 7;
            OffsetNumber.Text = "0";
            // 
            // OffsetTitle
            // 
            OffsetTitle.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OffsetTitle.Location = new Point(9, 5);
            OffsetTitle.Name = "OffsetTitle";
            OffsetTitle.Size = new Size(75, 23);
            OffsetTitle.TabIndex = 6;
            OffsetTitle.Text = "Offset";
            // 
            // EncryptOrDecryptPage
            // 
            EncryptOrDecryptPage.Controls.Add(ResultCopy);
            EncryptOrDecryptPage.Controls.Add(EncryptButton);
            EncryptOrDecryptPage.Controls.Add(DecryptButton);
            EncryptOrDecryptPage.Controls.Add(ChangeOffsetButton);
            EncryptOrDecryptPage.Controls.Add(ChangeKeyButton);
            EncryptOrDecryptPage.Controls.Add(ChangeTextButton);
            EncryptOrDecryptPage.Controls.Add(ResultSaveButton);
            EncryptOrDecryptPage.Controls.Add(ResultBox);
            EncryptOrDecryptPage.Controls.Add(ResultTip);
            EncryptOrDecryptPage.Controls.Add(EncryptOrDecryptTitle);
            EncryptOrDecryptPage.Location = new Point(3, 28);
            EncryptOrDecryptPage.Name = "EncryptOrDecryptPage";
            EncryptOrDecryptPage.Size = new Size(854, 432);
            EncryptOrDecryptPage.TabIndex = 1;
            EncryptOrDecryptPage.Text = "Encrypt/Decrypt";
            // 
            // EncryptButton
            // 
            EncryptButton.Location = new Point(3, 317);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(282, 50);
            EncryptButton.TabIndex = 15;
            EncryptButton.Text = "Encrypt";
            EncryptButton.UseVisualStyleBackColor = true;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // DecryptButton
            // 
            DecryptButton.Location = new Point(3, 373);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(282, 50);
            DecryptButton.TabIndex = 14;
            DecryptButton.Text = "Decrypt";
            DecryptButton.UseVisualStyleBackColor = true;
            DecryptButton.Click += DecryptButton_Click;
            // 
            // ChangeOffsetButton
            // 
            ChangeOffsetButton.BackHover = Color.AliceBlue;
            ChangeOffsetButton.Location = new Point(3, 136);
            ChangeOffsetButton.Name = "ChangeOffsetButton";
            ChangeOffsetButton.Size = new Size(282, 46);
            ChangeOffsetButton.TabIndex = 13;
            ChangeOffsetButton.Text = "Change offset";
            ChangeOffsetButton.Click += ChangeOffsetButton_Click;
            // 
            // ChangeKeyButton
            // 
            ChangeKeyButton.BackHover = Color.AliceBlue;
            ChangeKeyButton.Location = new Point(3, 84);
            ChangeKeyButton.Name = "ChangeKeyButton";
            ChangeKeyButton.Size = new Size(282, 46);
            ChangeKeyButton.TabIndex = 12;
            ChangeKeyButton.Text = "Change key";
            ChangeKeyButton.Click += ChangeKeyButton_Click;
            // 
            // ChangeTextButton
            // 
            ChangeTextButton.BackHover = Color.AliceBlue;
            ChangeTextButton.Location = new Point(3, 32);
            ChangeTextButton.Name = "ChangeTextButton";
            ChangeTextButton.Size = new Size(282, 46);
            ChangeTextButton.TabIndex = 11;
            ChangeTextButton.Text = "Change text";
            ChangeTextButton.Click += ChangeTextButton_Click;
            // 
            // ResultSaveButton
            // 
            ResultSaveButton.Location = new Point(770, 3);
            ResultSaveButton.Name = "ResultSaveButton";
            ResultSaveButton.Size = new Size(75, 23);
            ResultSaveButton.TabIndex = 10;
            ResultSaveButton.Text = "Save";
            ResultSaveButton.UseVisualStyleBackColor = true;
            ResultSaveButton.Click += ResultSaveButton_Click;
            // 
            // ResultBox
            // 
            ResultBox.Location = new Point(291, 32);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.ScrollBars = ScrollBars.Vertical;
            ResultBox.Size = new Size(554, 391);
            ResultBox.TabIndex = 9;
            // 
            // ResultTip
            // 
            ResultTip.Location = new Point(291, 3);
            ResultTip.Name = "ResultTip";
            ResultTip.Size = new Size(75, 23);
            ResultTip.TabIndex = 8;
            ResultTip.Text = "Result";
            // 
            // EncryptOrDecryptTitle
            // 
            EncryptOrDecryptTitle.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EncryptOrDecryptTitle.Location = new Point(3, 3);
            EncryptOrDecryptTitle.Name = "EncryptOrDecryptTitle";
            EncryptOrDecryptTitle.Size = new Size(206, 23);
            EncryptOrDecryptTitle.TabIndex = 7;
            EncryptOrDecryptTitle.Text = "Encrypt or Decrypt";
            // 
            // SettingsPage
            // 
            SettingsPage.Controls.Add(SettingsTitle);
            SettingsPage.Location = new Point(0, 0);
            SettingsPage.Name = "SettingsPage";
            SettingsPage.Size = new Size(0, 0);
            SettingsPage.TabIndex = 2;
            SettingsPage.Text = "Settings";
            // 
            // SettingsTitle
            // 
            SettingsTitle.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SettingsTitle.Location = new Point(9, 3);
            SettingsTitle.Name = "SettingsTitle";
            SettingsTitle.Size = new Size(195, 42);
            SettingsTitle.TabIndex = 0;
            SettingsTitle.Text = "这边还没有东西呢...";
            // 
            // AboutPage
            // 
            AboutPage.Controls.Add(AboutVersion);
            AboutPage.Controls.Add(AboutDotNEO);
            AboutPage.Controls.Add(AboutInfo);
            AboutPage.Controls.Add(AuthorGroup);
            AboutPage.Controls.Add(AboutSubTitle);
            AboutPage.Controls.Add(AboutTitle);
            AboutPage.Controls.Add(AboutIcon);
            AboutPage.Location = new Point(-854, -432);
            AboutPage.Name = "AboutPage";
            AboutPage.Size = new Size(854, 432);
            AboutPage.TabIndex = 3;
            AboutPage.Text = "About";
            // 
            // AboutVersion
            // 
            AboutVersion.BackColor = SystemColors.ButtonHighlight;
            AboutVersion.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AboutVersion.Location = new Point(469, 182);
            AboutVersion.Name = "AboutVersion";
            AboutVersion.Size = new Size(376, 135);
            AboutVersion.TabIndex = 6;
            AboutVersion.Text = "letscrypto 版本:\r\ncore: 未获取到\r\ncli: 未获取到\r\ngui: 未获取到";
            AboutVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AboutDotNEO
            // 
            AboutDotNEO.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AboutDotNEO.Location = new Point(379, 41);
            AboutDotNEO.Name = "AboutDotNEO";
            AboutDotNEO.Size = new Size(55, 47);
            AboutDotNEO.TabIndex = 5;
            AboutDotNEO.Text = ".neo";
            // 
            // AboutInfo
            // 
            AboutInfo.BackColor = SystemColors.ButtonHighlight;
            AboutInfo.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AboutInfo.Location = new Point(469, 41);
            AboutInfo.Name = "AboutInfo";
            AboutInfo.Size = new Size(376, 135);
            AboutInfo.TabIndex = 4;
            AboutInfo.Text = " letscrypto 是一种自己实现的加解密工具，虽然它还有许多美中不足的内容，但我们以后会争取做到最好！\r\n 如果你想参与开发，不妨看看我们的Github，上面不出所料，就会有letscrypto.neo的仓库，你就可以为我们提供贡献啦！";
            // 
            // AuthorGroup
            // 
            AuthorGroup.Controls.Add(AuthorTab);
            AuthorGroup.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AuthorGroup.Location = new Point(9, 175);
            AuthorGroup.Name = "AuthorGroup";
            AuthorGroup.Size = new Size(441, 248);
            AuthorGroup.TabIndex = 3;
            AuthorGroup.TabStop = false;
            AuthorGroup.Text = "Authors";
            // 
            // AuthorTab
            // 
            AuthorTab.Alignment = TabAlignment.Left;
            AuthorTab.Location = new Point(6, 29);
            AuthorTab.Name = "AuthorTab";
            AuthorTab.Pages.Add(AuthorAImixAEMocha);
            AuthorTab.Size = new Size(429, 213);
            AuthorTab.Style = styleLine1;
            AuthorTab.TabIndex = 0;
            AuthorTab.Text = "AuthorTab";
            // 
            // AuthorAImixAEMocha
            // 
            AuthorAImixAEMocha.Controls.Add(AImixAEMochaBlog);
            AuthorAImixAEMocha.Controls.Add(AImixAEMochaWebsite);
            AuthorAImixAEMocha.Controls.Add(AImixAEMochaGithub);
            AuthorAImixAEMocha.Location = new Point(125, 3);
            AuthorAImixAEMocha.Name = "AuthorAImixAEMocha";
            AuthorAImixAEMocha.Size = new Size(301, 207);
            AuthorAImixAEMocha.TabIndex = 0;
            AuthorAImixAEMocha.Text = "AImixAE Mocha";
            // 
            // AImixAEMochaBlog
            // 
            AImixAEMochaBlog.BackHover = Color.AliceBlue;
            AImixAEMochaBlog.Location = new Point(3, 45);
            AImixAEMochaBlog.Name = "AImixAEMochaBlog";
            AImixAEMochaBlog.Size = new Size(145, 36);
            AImixAEMochaBlog.TabIndex = 2;
            AImixAEMochaBlog.Text = "Blog";
            AImixAEMochaBlog.Click += AImixAEMochaBlog_Click;
            // 
            // AImixAEMochaWebsite
            // 
            AImixAEMochaWebsite.BackHover = Color.AliceBlue;
            AImixAEMochaWebsite.Location = new Point(154, 3);
            AImixAEMochaWebsite.Name = "AImixAEMochaWebsite";
            AImixAEMochaWebsite.Size = new Size(145, 36);
            AImixAEMochaWebsite.TabIndex = 1;
            AImixAEMochaWebsite.Text = "Website";
            AImixAEMochaWebsite.Click += AImixAEMochaWebsite_Click;
            // 
            // AImixAEMochaGithub
            // 
            AImixAEMochaGithub.BackHover = Color.AliceBlue;
            AImixAEMochaGithub.Location = new Point(3, 3);
            AImixAEMochaGithub.Name = "AImixAEMochaGithub";
            AImixAEMochaGithub.Size = new Size(145, 36);
            AImixAEMochaGithub.TabIndex = 0;
            AImixAEMochaGithub.Text = "Github";
            AImixAEMochaGithub.Click += AImixAEMochaGithub_Click;
            // 
            // AboutSubTitle
            // 
            AboutSubTitle.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AboutSubTitle.Location = new Point(214, 94);
            AboutSubTitle.Name = "AboutSubTitle";
            AboutSubTitle.Size = new Size(236, 34);
            AboutSubTitle.TabIndex = 2;
            AboutSubTitle.Text = "Let's encrypt together!";
            // 
            // AboutTitle
            // 
            AboutTitle.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AboutTitle.Location = new Point(214, 41);
            AboutTitle.Name = "AboutTitle";
            AboutTitle.Size = new Size(212, 47);
            AboutTitle.TabIndex = 1;
            AboutTitle.Text = "Letscrypto";
            // 
            // AboutIcon
            // 
            AboutIcon.Image = Properties.Resources.icon;
            AboutIcon.Location = new Point(9, 3);
            AboutIcon.Name = "AboutIcon";
            AboutIcon.Size = new Size(199, 195);
            AboutIcon.TabIndex = 0;
            AboutIcon.Text = "icon";
            // 
            // ResultCopy
            // 
            ResultCopy.Location = new Point(689, 3);
            ResultCopy.Name = "ResultCopy";
            ResultCopy.Size = new Size(75, 23);
            ResultCopy.TabIndex = 16;
            ResultCopy.Text = "Copy";
            ResultCopy.UseVisualStyleBackColor = true;
            ResultCopy.Click += ResultCopy_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 463);
            Controls.Add(PageManager);
            Name = "Main";
            Text = "letscrypto";
            PageManager.ResumeLayout(false);
            HomePage.ResumeLayout(false);
            TextPage.ResumeLayout(false);
            TextPage.PerformLayout();
            KeyPage.ResumeLayout(false);
            KeyPage.PerformLayout();
            OffsetPage.ResumeLayout(false);
            EncryptOrDecryptPage.ResumeLayout(false);
            EncryptOrDecryptPage.PerformLayout();
            SettingsPage.ResumeLayout(false);
            AboutPage.ResumeLayout(false);
            AuthorGroup.ResumeLayout(false);
            AuthorTab.ResumeLayout(false);
            AuthorAImixAEMocha.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label Title;
        private AntdUI.Tabs PageManager;
        private AntdUI.TabPage HomePage;
        private AntdUI.TabPage EncryptOrDecryptPage;
        private AntdUI.TabPage SettingsPage;
        private AntdUI.TabPage AboutPage;
        private AntdUI.Label SubTitile;
        private AntdUI.TabPage TextPage;
        private AntdUI.TabPage KeyPage;
        private AntdUI.TabPage OffsetPage;
        private AntdUI.Button GettingStartedButton;
        private AntdUI.Label TextTitle;
        private TextBox TextFilePath;
        private AntdUI.Label TextLoadFromFileTip;
        private TextBox TextUBox;
        private Button TextSelectButton;
        private Button KeySelectButton;
        private TextBox KeyFilePath;
        private AntdUI.Label KeyLoadFromFileTip;
        private TextBox KeyUBox;
        private AntdUI.Label KeyTitle;
        private AntdUI.Radio UseTextFile;
        private AntdUI.Radio UseTextUBox;
        private AntdUI.Radio UseKeyFile;
        private AntdUI.Radio UseKeyUBox;
        private AntdUI.Label OffsetTitle;
        private AntdUI.InputNumber OffsetNumber;
        private AntdUI.Button OffsetRandomGenerate;
        private AntdUI.Label OffsetRandomMinAndMax;
        private AntdUI.InputNumber OffsetRandomMax;
        private AntdUI.InputNumber OffsetRandomMin;
        private AntdUI.Label OffsetRandomTip;
        private AntdUI.Button KeySaveButton;
        private AntdUI.Label EncryptOrDecryptTitle;
        private AntdUI.Label ResultTip;
        private TextBox ResultBox;
        private Button ResultSaveButton;
        private AntdUI.Button ChangeOffsetButton;
        private AntdUI.Button ChangeKeyButton;
        private AntdUI.Button ChangeTextButton;
        private Button EncryptButton;
        private Button DecryptButton;
        private Button KeyGenerateButton;
        private TextBox KeyGenerateCountBox;
        private AntdUI.Label KeyGenerateTip;
        private AntdUI.Image3D HomeIcon;
        private AntdUI.Image3D AboutIcon;
        private AntdUI.Label AboutSubTitle;
        private AntdUI.Label AboutTitle;
        private GroupBox AuthorGroup;
        private AntdUI.Tabs AuthorTab;
        private AntdUI.TabPage AuthorAImixAEMocha;
        private AntdUI.Button AImixAEMochaGithub;
        private AntdUI.Button AImixAEMochaWebsite;
        private AntdUI.Button TextSaveButton;
        private AntdUI.Label AboutDotNEO;
        private AntdUI.Label AboutInfo;
        private AntdUI.Label HomeDotNEO;
        private AntdUI.Label SettingsTitle;
        private AntdUI.Label AboutVersion;
        private AntdUI.Button AImixAEMochaBlog;
        private Button ResultCopy;
    }
}
