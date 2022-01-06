using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveCustom
{
    public static void SaveData(EditorUI data)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = BuilderUI.path + " layout.dat";
        FileStream stream = new FileStream(path, FileMode.Create);

        LevelData gameData = new LevelData(data);

        formatter.Serialize(stream, gameData);
        stream.Close();
    }

    public static LevelData LoadData()
    {
        string path = BuilderUI.path + " layout.dat";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            LevelData data = formatter.Deserialize(stream) as LevelData;
            stream.Close();
            return data;
        }
        else return null;

    }
}