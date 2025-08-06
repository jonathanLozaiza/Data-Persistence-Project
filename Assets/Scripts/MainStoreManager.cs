using UnityEngine;

public class MainStoreManager : MonoBehaviour
{
    public static MainStoreManager Instance;
    public string username;
    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SaveName(string newName)
    {
        Debug.Log(newName);
        username = newName;
    }
}
