using UnityEngine;

public static class GameData
{
    private const string nameKey = "k";
    public static string LocalName => PlayerPrefs.GetString(nameKey);
    public static void SetLocalName(string name)
    {
        PlayerPrefs.SetString(nameKey, name);
    }
}
