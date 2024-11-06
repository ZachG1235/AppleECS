using UnityEngine;
using UnityEngine.SceneManagement;



[DisallowMultipleComponent]
public class MainMenu : MonoBehaviour
{
    static public int SCENE_NUMBER = 0;
    public void LoadEasyLevel()
    {
        // SceneLoader.Instance.LoadScene(SceneType.Easy);
        SceneManager.LoadScene("Easy");
        SCENE_NUMBER = 1;
    }

    public void LoadMediumLevel()
    {
        SceneManager.LoadScene("Medium");
        SCENE_NUMBER = 2;
    }

    public void LoadHardLevel()
    {
        SceneManager.LoadScene("Hard");
        SCENE_NUMBER = 3;
    }
}
