﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iTunesRichPresence_Clone.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RunOnStartup {
            get {
                return ((bool)(this["RunOnStartup"]));
            }
            set {
                this["RunOnStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%artist - %track")]
        public string PlayingTopLine {
            get {
                return ((string)(this["PlayingTopLine"]));
            }
            set {
                this["PlayingTopLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%playlist_type: %playlist_name")]
        public string PlayingBottomLine {
            get {
                return ((string)(this["PlayingBottomLine"]));
            }
            set {
                this["PlayingBottomLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%artist - %track")]
        public string PausedTopLine {
            get {
                return ((string)(this["PausedTopLine"]));
            }
            set {
                this["PausedTopLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("일시정지 됨")]
        public string PausedBottomLine {
            get {
                return ((string)(this["PausedBottomLine"]));
            }
            set {
                this["PausedBottomLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DisplayPlaybackDuration {
            get {
                return ((bool)(this["DisplayPlaybackDuration"]));
            }
            set {
                this["DisplayPlaybackDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Orange")]
        public string Accent {
            get {
                return ((string)(this["Accent"]));
            }
            set {
                this["Accent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ExperimentsEnabled {
            get {
                return ((bool)(this["ExperimentsEnabled"]));
            }
            set {
                this["ExperimentsEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("iTunes")]
        public string AppName {
            get {
                return ((string)(this["AppName"]));
            }
            set {
                this["AppName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ClearOnPause {
            get {
                return ((bool)(this["ClearOnPause"]));
            }
            set {
                this["ClearOnPause"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MinimizeOnStartup {
            get {
                return ((bool)(this["MinimizeOnStartup"]));
            }
            set {
                this["MinimizeOnStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Red</string>
  <string>Green</string>
  <string>Blue</string>
  <string>Purple</string>
  <string>Orange</string>
  <string>Lime</string>
  <string>Emerald</string>
  <string>Teal</string>
  <string>Cyan</string>
  <string>Cobalt</string>
  <string>Indigo</string>
  <string>Violet</string>
  <string>Pink</string>
  <string>Magenta</string>
  <string>Crimson</string>
  <string>Amber</string>
  <string>Yellow</string>
  <string>Brown</string>
  <string>Olive</string>
  <string>Steel</string>
  <string>Mauve</string>
  <string>Taupe</string>
  <string>Sienna</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection AccentsEn {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["AccentsEn"]));
            }
            set {
                this["AccentsEn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>빨간색</string>
  <string>초록색</string>
  <string>파란색</string>
  <string>보라색</string>
  <string>주황색</string>
  <string>라임색</string>
  <string>에메랄드</string>
  <string>청록색</string>
  <string>시안</string>
  <string>코발트</string>
  <string>남색</string>
  <string>자주색</string>
  <string>분홍색</string>
  <string>자홍색</string>
  <string>심홍색</string>
  <string>등색</string>
  <string>노란색</string>
  <string>갈색</string>
  <string>갈록색</string>
  <string>Steel</string>
  <string>모브색</string>
  <string>회갈색</string>
  <string>시에나</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection AccentsKr {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["AccentsKr"]));
            }
            set {
                this["AccentsKr"] = value;
            }
        }
    }
}
