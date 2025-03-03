using UnityEngine;
public class PlayerInteraction : MonoBehaviour{

    private Rigidbody rb;

    private bool playerDied;
    private CameraFollow CameraFollow;
    

    void Awake(){
        rb = GetComponent<Rigidbody>();
        CameraFollow = Camera.main.GetComponent<CameraFollow>();
    }
    void Update(){
        if(!playerDied){
            if(rb.linearVelocity.sqrMagnitude > 60){
                playerDied = true;
                CameraFollow.CanFollow = false;

                SoundManager.instance.GameOverSound();
                GameplayCotroller.instance.RestartGame();
            }
        }
    }

    void OnTriggerEnter(Collider target){

        if(target.tag == "Coin"){
            SoundManager.instance.CoinSound();
            target.gameObject.SetActive(false);
            GameplayCotroller.instance.IncrementScore();
        }
        if(target.tag == "Spike"){
            CameraFollow.CanFollow = false;
            gameObject.SetActive(false);
            SoundManager.instance.GameOverSound();
            GameplayCotroller.instance.RestartGame();
        }
       
    }
    void OnCollisionEnter(Collision target){

        if(target.gameObject.tag == "EndPlatform"){
            SoundManager.instance.GameStartSound();
            GameplayCotroller.instance.RestartGame();
        }
       
    }
}
