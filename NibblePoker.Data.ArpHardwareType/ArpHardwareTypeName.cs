using System;
using System.Reflection;

namespace NibblePoker.Data.ArpHardwareType {
    /// <summary>
    ///   Attribute used to give a friendly name to entries in the <i>ARP Hardware Types</i> enumerations.
    /// </summary>
    /// <seealso cref="EIanaArpHardwareTypes"/>
    /// <seealso cref="ELinuxArpHardwareTypes"/>
    public class ArpHardwareTypeName : Attribute {
        private readonly string _description;
    
        /// <summary>
        ///   Instantiates an <see cref="Attribute">Attribute</see> that contains a friendly name for any
        ///    entry in the <i>ARP Hardware Types</i> enumerations.
        /// </summary>
        /// <param name="description">Friendly name to be attributed</param>
        public ArpHardwareTypeName(string description) {
            this._description = description;
        }
    
        /// <summary>
        ///   Retrieves the friendly name from a given <i>ARP Hardware Types</i>.
        /// </summary>
        /// <param name="enumObj">The <i>ARP Hardware Types</i> enumeration member whose friendly name is retrieved.</param>
        /// <returns>The friendly name if found, ane empty string otherwise.</returns>
        public static string GetFrom(Enum enumObj) {
            FieldInfo fieldInfo = enumObj.GetType().GetField(enumObj.ToString());
        
            if(fieldInfo != null) {
                object[] attribArray = fieldInfo.GetCustomAttributes(false);
                if(attribArray.Length != 0) {
                    if(attribArray[0] is ArpHardwareTypeName attrib) {
                        return attrib._description;
                    }
                }
            }
        
            return string.Empty;
        }
    }
}
