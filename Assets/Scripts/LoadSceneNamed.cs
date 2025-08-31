using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneNamed : MonoBehaviour
{
    public void LoadSceneWithName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
