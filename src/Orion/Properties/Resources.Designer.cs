﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Orion.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Orion.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {EventName}: Invoking {RegistrationName} with {Args}.
        /// </summary>
        internal static string EventHandlerCollection_Invoke {
            get {
                return ResourceManager.GetString("EventHandlerCollection_Invoke", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {EventName}: Canceled for {CancellationReason}.
        /// </summary>
        internal static string EventHandlerCollection_InvokeCanceled {
            get {
                return ResourceManager.GetString("EventHandlerCollection_InvokeCanceled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {EventName}: Unhandled exception occurred.
        /// </summary>
        internal static string EventHandlerCollection_InvokeException {
            get {
                return ResourceManager.GetString("EventHandlerCollection_InvokeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {EventName}: Registered {RegistrationName}.
        /// </summary>
        internal static string EventHandlerCollection_Register {
            get {
                return ResourceManager.GetString("EventHandlerCollection_Register", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {EventName}: Unregistered {RegistrationName}.
        /// </summary>
        internal static string EventHandlerCollection_Unregister {
            get {
                return ResourceManager.GetString("EventHandlerCollection_Unregister", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Spawning item {Type} x{StackSize} at {Position}.
        /// </summary>
        internal static string ItemService_SpawnItem {
            get {
                return ResourceManager.GetString("ItemService_SpawnItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initialized {PluginName} v{PluginVersion} by {PluginAuthor}.
        /// </summary>
        internal static string Kernel_InitalizePlugin {
            get {
                return ResourceManager.GetString("Kernel_InitalizePlugin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loaded {PluginName} from {AssemblyPath}.
        /// </summary>
        internal static string Kernel_LoadPlugin {
            get {
                return ResourceManager.GetString("Kernel_LoadPlugin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unloaded {PluginName}.
        /// </summary>
        internal static string Kernel_UnloadPlugin {
            get {
                return ResourceManager.GetString("Kernel_UnloadPlugin", resourceCulture);
            }
        }
    }
}
