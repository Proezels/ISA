using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    private Scene scene;
    public int sceneNum = 1;
    public static int loadNum = 0;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        sceneNum = sceneNum + loadNum;
    }


    void nextScene(int levelIndex)
    {
        if (scene.name == "goSleep")
        {
            loadNum++;
            SceneManager.LoadScene(sceneNum + 2);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
        
        
    }
}
