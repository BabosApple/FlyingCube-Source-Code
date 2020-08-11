using UnityEngine;
using UnityEngine.SceneManagement;

public class PMovement : MonoBehaviour {

    public Rigidbody rb;

    public Transform player;

    public float forwardForce = 2000f;
    public float wForce = 50f; 
    public float aForce = 500f;

    void Start(){
      Debug.Log("OwO Yes");
    }

    void FixedUpdate(){
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(Input.GetKey("d")){
            rb.AddForce(aForce, 0, 0);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-aForce, 0, 0);
        }
        if(Input.GetKey("w")){
            rb.AddForce(0, wForce, 0); 
        }
    }
}
