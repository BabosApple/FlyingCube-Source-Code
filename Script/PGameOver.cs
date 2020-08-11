using UnityEngine;
using UnityEngine.SceneManagement;

public class PGameOver : MonoBehaviour{

    public Rigidbody rb;
    public Transform player;

    public float Speed = 10f;

    void FixedUpdate(){
        if(Input.GetKey("a")){
            rb.AddForce(-Speed, 0, 0);
        }
        if(Input.GetKey("d")){
            rb.AddForce(Speed, 0, 0);
        }
    }

    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.name == "Cube1"){
            SceneManager.LoadScene("Level");
        }
        if(collisionInfo.collider.name == "Cube2"){
            SceneManager.LoadScene("MainMenu");
        }
    }

}
