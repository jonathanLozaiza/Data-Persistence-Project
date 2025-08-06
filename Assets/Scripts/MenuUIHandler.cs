using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField inputField;
    private string userName;
    private void Start()
    {
        inputField.onValueChanged.AddListener(changeName);
    }

    public void StarNew()
    {
        if (MainStoreManager.Instance != null)
        {
            MainStoreManager.Instance.username = userName;
        }
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
    private void changeName(string name)
    {
        userName = name;
    }
}
