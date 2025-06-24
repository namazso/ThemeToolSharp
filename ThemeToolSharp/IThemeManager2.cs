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
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace ThemeToolSharp
{
    [Flags]
    public enum InitializationFlags
    {
        ThemeInitNoFlags = 0,
        ThemeInitCurrentThemeOnly = 1 << 0,
        ThemeInitFlagUnk1 = 1 << 1,
        ThemeInitFlagUnk2 = 1 << 2, // something about immersive colors
    };

    [Flags]
    public enum ThemeApplyFlags
    {
        IgnoreBackground = 1 << 0,
        IgnoreCursor = 1 << 1,
        IgnoreDesktopIcons = 1 << 2,
        IgnoreColor = 1 << 3,
        IgnoreSound = 1 << 4,
        IgnoreScreensaver = 1 << 5,
        Unknown1 = 1 << 6, // something about window metrics
        Unknown2 = 1 << 7,
        NoHourglass = 1 << 8
    };

    [Flags]
    public enum ThemePackFlags
    {
        Unknown1 = 1 << 0, // setting this seems to suppress hourglass
        Unknown2 = 1 << 1, // setting this seems to suppress hourglass
        Silent = 1 << 2, // hides all dialogs and prevents sound
        Roamed = 1 << 3, // something about roaming
    };

    [Guid("26e4185f-0528-475f-acaf-abe89ba6017d")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ITheme
    {
        string DisplayName { get; set; }
    }

    [Guid("c1e8c83e-845d-4d95-81db-e283fdffc000")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IThemeManager2
    {
        void Init(InitializationFlags initFlags);
        void InitAsync(IntPtr hwnd, int unk1);
        void Refresh();
        void RefreshAsync(IntPtr hwnd, int unk1);
        void RefreshComplete();
        void GetThemeCount(out int count);
        void GetTheme(int index, out ITheme theme);
        void IsThemeDisabled(int index, out int disabled);
        void GetCurrentTheme(out int index);

        void SetCurrentTheme(IntPtr parent, int themeIndex, int applyNow, ThemeApplyFlags applyFlags,
            ThemePackFlags packFlags);

        void GetCustomTheme(out int index);
        void GetDefaultTheme(out int index);
        void CreateThemePack(IntPtr hwnd, string unk1, ThemePackFlags packFlags);
        void CloneAndSetCurrentTheme(IntPtr hwnd, string unk1, out string unk2);

        void InstallThemePack(IntPtr hwnd, string unk1, int unk2, ThemePackFlags packFlags, out string unk3,
            out ITheme unk4MaybeNotUsed);

        void DeleteTheme(string unk1);
        void OpenTheme(IntPtr hwnd, string path, ThemePackFlags packFlags);
        void AddAndSelectTheme(IntPtr hwnd, string path, ThemeApplyFlags applyFlags, ThemePackFlags packFlags);
        void SQMCurrentTheme();
        void ExportRoamingThemeToStream(IStream stream, int unk1);
        void ImportRoamingThemeFromStream(IStream stream, int unk1);
        void UpdateColorSettingsForLogonUI();
        void GetDefaultThemeId(out Guid guid);
    }

    public static class ThemeManager2
    {
        [DllImport("ole32.dll", EntryPoint = "CoCreateInstance", ExactSpelling = true, PreserveSig = false)]
        private static extern int CoCreateInstance(
            [In, MarshalAs(UnmanagedType.LPStruct)]
            Guid rclsid,
            IntPtr pUnkOuter,
            uint dwClsContext,
            [In, MarshalAs(UnmanagedType.LPStruct)]
            Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppv
        );

        private const string CLSID = "9324da94-50ec-4a14-a770-e90ca03e7c8f";

        public static IThemeManager2 CreateInstance()
        {
            /*CoCreateInstance(
                Guid.Parse(CLSID),
                IntPtr.Zero,
                1, // CLSCTX_INPROC_SERVER
                typeof(IThemeManager2).GUID,
                out var obj);
            return (IThemeManager2)obj;*/
            return (IThemeManager2)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid(CLSID)));
        }
    }
}