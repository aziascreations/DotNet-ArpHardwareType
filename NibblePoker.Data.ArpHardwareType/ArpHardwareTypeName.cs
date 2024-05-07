using System.Reflection;

namespace NibblePoker.Data.ArpHardwareType;

public class ArpHardwareTypeName : Attribute {
    private readonly string _description;
    
    public ArpHardwareTypeName(string description) {
        this._description = description;
    }
    
    public static string GetFrom(Enum enumObj) {
        FieldInfo? fieldInfo = enumObj.GetType().GetField(enumObj.ToString());
        
        if(fieldInfo != null) {
            object[] attribArray = fieldInfo.GetCustomAttributes(false);
            if(attribArray.Length != 0) {
                /*if(attribArray[0] is ArpHardwareTypeName attrib) {
                    return attrib.Description;
                }*/
                ArpHardwareTypeName? attrib = attribArray[0] as ArpHardwareTypeName;
                if(attrib != null) {
                    return attrib._description;
                }
            }
        }
        
        return string.Empty;
    }
}
