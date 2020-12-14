using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void GameStart()
    {
        GameObject.Find("PipeSpawner").GetComponent<PipeSpawner>().StartSpawningPipes();
        UIManager.instance.GameStart();

    }
    public void GameOver()
    {
        GameObject.Find("PipeSpawner").GetComponent<PipeSpawner>().StopSpawningPipes();
        ScoreManager.instance.StopScore();
        UIManager.instance.GameOver(); 
    }
}
