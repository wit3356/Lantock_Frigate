// This class is Auto-Generated
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Reflection;
using Munitions;
using Munitions.ModularMissiles;
using FleetEditor.MissileEditor;

public class Holder : MonoBehaviour
{
    public ScriptableObject a;
}
public class GeneratedMenuItems : MonoBehaviour {
    static AssetBundle stock; 
    static AssetBundle stockf1; 
    static AssetBundle stockf2; 
    static AssetBundle stockmaps; 

        public static object GetPrivateField(object instance, string fieldName)
        {
            static object GetPrivateFieldInternal(object instance, string fieldName, System.Type type)
            {
                FieldInfo field = type.GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);

                if (field != null)
                {
                    return field.GetValue(instance);
                }
                else if (type.BaseType != null)
                {
                    return GetPrivateFieldInternal(instance, fieldName, type.BaseType);
                }
                else
                {
                    return null;
                }
            }

            return GetPrivateFieldInternal(instance, fieldName, instance.GetType());
        }
        
    

}
