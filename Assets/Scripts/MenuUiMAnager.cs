using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUiMAnager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("LevelOne");
    }
}
