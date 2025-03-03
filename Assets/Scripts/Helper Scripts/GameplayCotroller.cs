using UnityEngine;
using UnityEngine.UI;

public class GameplayCotroller : MonoBehaviour{

    public static GameplayCotroller instance;

    [SerializeField]
    private Text scoreText;

    private int score;

    void Awake(){
        if(instance == null){
            instance = this;
        }
    }

    public void IncrementScore(){
        score++;
        scoreText.text = "X " + score;
    }

    public void RestartGame(){
        Invoke("RealoadGame", 2f);
    }

    void RealoadGame(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
    
}
