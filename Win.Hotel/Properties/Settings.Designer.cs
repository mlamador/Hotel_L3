﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Win.Hotel.Properties {
    
    
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
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DESKTOPDB_HOTEL_1_3_1a9ad7ace8" +
            "5d45f78f1f95289910a8d2;Integrated Security=True;Connect Timeout=30;Encrypt=False" +
            ";TrustServerCertificate=True")]
        public string DESKTOPDB_HOTEL_1_3_1a9ad7ace85d45f78f1f95289910a8d2ConnectionString {
            get {
                return ((string)(this["DESKTOPDB_HOTEL_1_3_1a9ad7ace85d45f78f1f95289910a8d2ConnectionString"]));
            }
        }
    }
}
