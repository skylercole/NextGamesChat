﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NextGamesChat.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute(@"DefaultEndpointsProtocol=https;AccountName=nextgameschat;AccountKey=eAWb2B/cOHuGB8qTv5k34HPSkJgkhbCviKU0ZtN0dq2q7RJ5hqxTN3Osd7CTPKne8sPshicmqBycpFzUeYPAHg==;BlobEndpoint=https://nextgameschat.blob.core.windows.net/;TableEndpoint=https://nextgameschat.table.core.windows.net/;QueueEndpoint=https://nextgameschat.queue.core.windows.net/;FileEndpoint=https://nextgameschat.file.core.windows.net/")]
        public string StorageConnectionString {
            get {
                return ((string)(this["StorageConnectionString"]));
            }
        }
    }
}