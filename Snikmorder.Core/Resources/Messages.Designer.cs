﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Snikmorder.Core.Resources {
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
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Snikmorder.Core.Resources.Messages", typeof(Messages).Assembly);
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
        ///   Looks up a localized string similar to Gratulerer {0}, søknaden din ble godkjent.
        ///Du vil snart få tilsendt ditt første oppdrag..
        /// </summary>
        internal static string ApplicationApproved {
            get {
                return ResourceManager.GetString("ApplicationApproved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Beklager, søknaden din om å bli agent ble ikke godkjent. Prøv igjen ved å sende /nySøknad.
        /// </summary>
        internal static string ApplicationNotApproved {
            get {
                return ResourceManager.GetString("ApplicationNotApproved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Takk.
        ///Søknaden din er nå registrert.
        ///Du vil få svar innen kort tid..
        /// </summary>
        internal static string ApplicationRegistered {
            get {
                return ResourceManager.GetString("ApplicationRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vi har registert følgende søknad:
        ///Navn: {0}
        ///Agent-navn: {1}
        ///Er dette rett, send /ok
        ///Er dette feil, start på nytt ved å sende /nySøknad.
        /// </summary>
        internal static string ConfirmApplication {
            get {
                return ResourceManager.GetString("ConfirmApplication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For å eliminiere en agent må du skrive inn agent-navnet til den eliminerte agenten..
        /// </summary>
        internal static string ConfirmKill {
            get {
                return ResourceManager.GetString("ConfirmKill", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vi har registrert navnet ditt.
        ///For å fortsette trenger vi å vite agent-navnet ditt.
        ///Vi har gitt deg navnet Agent {0}, men du kan lage ditt eget navn selv.
        ///Skriv inn bekreftelse på at du vil ha agent-navn Agent {0} ved å svare /ok, eller send oss ditt eget agent navn hvis du vil ha et eget navn.
        ///Men husk at agent-navnet vil bli godkjent av hovedkvarteret, og kan bli avslått..
        /// </summary>
        internal static string RequestAgentName {
            get {
                return ResourceManager.GetString("RequestAgentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vi har registrert agent navnet ditt. Du vil bli kalt {0}.
        ///For å fullføre søknaden din må du sende oss et profilbilde. Send oss en selfie der det er helt tydelig hvem du er..
        /// </summary>
        internal static string RequestSelfie {
            get {
                return ResourceManager.GetString("RequestSelfie", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vi forsto ikke hva du mente. For å bli agent må du følge instruksjonene nøyaktig!.
        /// </summary>
        internal static string UnknownResponse {
            get {
                return ResourceManager.GetString("UnknownResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Din søknad er registrert og venter på godkjenning fra hovedkvarteret. Du vil få svar så fort som mulig. I mellomtiden ber vi deg vente..
        /// </summary>
        internal static string WaitForAdminApproval {
            get {
                return ResourceManager.GetString("WaitForAdminApproval", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Du har ingen mål enda.
        ///Du vil få tildelt et oppdrag snart..
        /// </summary>
        internal static string WaitForGameStart {
            get {
                return ResourceManager.GetString("WaitForGameStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Velkommen til Divisjonen!
        ///For å fullføre din søknad om å bli agent må du først sende oss ditt fulle navn.
        ///Men vi advarer deg. Dersom du prøver å bruke et feil navn vil søknaden din bli avslått.
        ///Du kan når som helst starte søknaden på nytt ved å skrive /nySøknad.
        /// </summary>
        internal static string WelcomeMessage {
            get {
                return ResourceManager.GetString("WelcomeMessage", resourceCulture);
            }
        }
    }
}
