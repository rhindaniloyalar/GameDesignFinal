/**************************PPSerialization**********************************
 *Programmer: Christine Jordan
 *Class: PPSerialization
 *Inheritance: NONE    
 *Date Created: 11/7/15
 *Date Modified: 11/7/15
 *Project: Project Avenon
 *Purpose:
 *ChangeLog: [11/7/15]
 ***************************************************************************/
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
//episode 13 & 14
public class PPSerialization
{
    public static BinaryFormatter binaryFormatter = new BinaryFormatter();

/********************************Save****************************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    public static void Save(string tag, object obj)
    {
        MemoryStream memoryStream = new MemoryStream();
        binaryFormatter.Serialize(memoryStream, obj);
        string temp = System.Convert.ToBase64String(memoryStream.ToArray());
        PlayerPrefs.SetString(tag, temp);
    }

/******************************Load******************************************
 * In:
 * Out:
 * Purpose: 
 * **************************************************************************/
    public static object Load(string tag)
    {
        string temp = PlayerPrefs.GetString(tag);
        if (temp == string.Empty)
        {
            return null;
        }
        MemoryStream memoryStream = 
            new MemoryStream(System.Convert.FromBase64String(temp));
        return binaryFormatter.Deserialize(memoryStream);
    }
}
