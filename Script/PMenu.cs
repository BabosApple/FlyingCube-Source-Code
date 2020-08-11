using UnityEngine;
using UnityEngine.SceneManagement;

public class PMenu : MonoBehaviour{

    public Rigidbody rb;

    public Transform player;

    public float Speed = 100f;

    void FixedUpdate(){
        if(Input.GetKey("a")){
            rb.AddForce(-Speed, 0, 0);
        }
        if(Input.GetKey("d")){
            rb.AddForce(Speed, 0, 0);
        }
    }

    void OnCollisionEnter(Collision CollisionInfo){
        if(CollisionInfo.collider.name == "Cube1"){
            SceneManager.LoadScene("Level");
        }
        if(CollisionInfo.collider.name == "Cube2"){
            Application.Quit();
        }
    }
}
