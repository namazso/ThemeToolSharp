//  ThemeToolSharp - A Windows theme changer.
//  Copyright (C) 2025  namazso <admin@namazso.eu>
//
//  This library is free software; you can redistribute it and/or
//  modify it under the terms of the GNU Lesser General Public
//  License as published by the Free Software Foundation; either
//  version 2.1 of the License, or (at your option) any later version.
//
//  This library is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//  Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public
//  License along with this library; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA

using System;
using System.Windows.Forms;
using ThemeToolSharp.Properties;

namespace ThemeToolSharp
{
    public partial class MainForm : Form
    {
        private IThemeManager2 _themeManager;

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateThemes()
        {
            listBoxThemes.Items.Clear();
            _themeManager.GetThemeCount(out var count);
            for (var i = 0; i < count; i++)
            {
                _themeManager.GetTheme(i, out var theme);
                listBoxThemes.Items.Add(theme.DisplayName);
            }

            _themeManager.GetCurrentTheme(out var currentTheme);
            if (currentTheme >= 0 && currentTheme < listBoxThemes.Items.Count)
            {
                listBoxThemes.SelectedIndex = currentTheme;
            }
            else
            {
                listBoxThemes.SelectedIndex = -1;
            }
        }

        private void InitializeThemes()
        {
            _themeManager = ThemeManager2.CreateInstance();
            _themeManager.Init(
                InitializationFlags.ThemeInitNoFlags
                | (checkUnknownInit1.Checked ? InitializationFlags.ThemeInitFlagUnk1 : 0)
                | (checkUnknownInit2.Checked ? InitializationFlags.ThemeInitFlagUnk2 : 0)
            );
        }

        private void LoadSettings()
        {
            checkIgnoreBackground.Checked = Settings.Default.ThemeIgnoreBackground;
            checkIgnoreCursor.Checked = Settings.Default.ThemeIgnoreCursor;
            checkIgnoreDesktopIcons.Checked = Settings.Default.ThemeIgnoreDesktopIcons;
            checkIgnoreColor.Checked = Settings.Default.ThemeIgnoreColor;
            checkIgnoreSound.Checked = Settings.Default.ThemeIgnoreSound;
            checkIgnoreScreensaver.Checked = Settings.Default.ThemeIgnoreScreensaver;
            checkUnknown1.Checked = Settings.Default.ThemeUnknownFlag1;
            checkUnknown2.Checked = Settings.Default.ThemeUnknownFlag2;
            checkLogonUI.Checked = Settings.Default.ThemeDoNotSetLogonUi;
            checkUnknownInit1.Checked = Settings.Default.InitUnknownFlag1;
            checkUnknownInit2.Checked = Settings.Default.InitUnknownFlag2;
        }
        
        private void SaveSettings()
        {
            Settings.Default.ThemeIgnoreBackground = checkIgnoreBackground.Checked;
            Settings.Default.ThemeIgnoreCursor = checkIgnoreCursor.Checked;
            Settings.Default.ThemeIgnoreDesktopIcons = checkIgnoreDesktopIcons.Checked;
            Settings.Default.ThemeIgnoreColor = checkIgnoreColor.Checked;
            Settings.Default.ThemeIgnoreSound = checkIgnoreSound.Checked;
            Settings.Default.ThemeIgnoreScreensaver = checkIgnoreScreensaver.Checked;
            Settings.Default.ThemeUnknownFlag1 = checkUnknown1.Checked;
            Settings.Default.ThemeUnknownFlag2 = checkUnknown2.Checked;
            Settings.Default.ThemeDoNotSetLogonUi = checkLogonUI.Checked;
            Settings.Default.InitUnknownFlag1 = checkUnknownInit1.Checked;
            Settings.Default.InitUnknownFlag2 = checkUnknownInit2.Checked;
            Settings.Default.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
            InitializeThemes();
            UpdateThemes();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _themeManager.Refresh();
            UpdateThemes();
        }

        private void btnReInitialize_Click(object sender, EventArgs e)
        {
            InitializeThemes();
            UpdateThemes();
            SaveSettings();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var applyFlags = ThemeApplyFlags.NoHourglass
                             | (checkIgnoreBackground.Checked ? ThemeApplyFlags.IgnoreBackground : 0)
                             | (checkIgnoreCursor.Checked ? ThemeApplyFlags.IgnoreCursor : 0)
                             | (checkIgnoreDesktopIcons.Checked ? ThemeApplyFlags.IgnoreDesktopIcons : 0)
                             | (checkIgnoreColor.Checked ? ThemeApplyFlags.IgnoreColor : 0)
                             | (checkIgnoreSound.Checked ? ThemeApplyFlags.IgnoreSound : 0)
                             | (checkIgnoreScreensaver.Checked ? ThemeApplyFlags.IgnoreScreensaver : 0)
                             | (checkUnknown1.Checked ? ThemeApplyFlags.Unknown1 : 0)
                             | (checkUnknown2.Checked ? ThemeApplyFlags.Unknown2 : 0);
            _themeManager.SetCurrentTheme(
                Handle,
                listBoxThemes.SelectedIndex,
                1,
                applyFlags,
                0
            );
            if (!checkLogonUI.Checked)
            {
                _themeManager.UpdateColorSettingsForLogonUI();
            }
            SaveSettings();
        }
    }
}