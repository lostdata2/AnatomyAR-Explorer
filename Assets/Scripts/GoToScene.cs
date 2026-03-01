using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    public void GoTo(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
