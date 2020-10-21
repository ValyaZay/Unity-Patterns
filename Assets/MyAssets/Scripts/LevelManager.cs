using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadStatePatternScene()
    {
        SceneManager.LoadScene(1);
    }
    
    public void LoadViaIfScene()
    {
        SceneManager.LoadScene(0);
    }
}
