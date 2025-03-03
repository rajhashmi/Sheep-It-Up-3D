using UnityEngine;

public class SoundManager : MonoBehaviour{

    public static SoundManager instance;

    [SerializeField] 
    private AudioSource gameStart, gameEnd, coinSound, jumpSound;

    void Awake(){
        if(instance == null){
            instance = this;
        }
    }   

    public void GameStartSound(){
        gameStart.Play();
    }

    public void GameOverSound(){
        gameEnd.Play();
    }

    public void CoinSound(){
        coinSound.Play();
    }

    public void JumpSound(){
        jumpSound.Play();
    }


}
