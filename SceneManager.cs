using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneMAnager : MonoBehaviour
{
    public void LoadScene(string SceneToLoad)
    {
        SceneManager.LoadScene(SceneToLoad);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
