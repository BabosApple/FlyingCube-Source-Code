using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour{
    
    void OnCollisionEnter(Collision collisionInfo){
        switch(collisionInfo.collider.name){
            case "Fail 1":
                SceneManager.LoadScene("Level - Copy");
            break;

            case "Fail 2":
                SceneManager.LoadScene("Level - Copy");
            break;

            case "Fail 3":
                SceneManager.LoadScene("Level - Copy");
            break;

            case "Fail 4":
                SceneManager.LoadScene("Level - Copy");
            break;

            case "Fail 5":
                SceneManager.LoadScene("Level - Copy");
            break;

            case "Fail 6":
                SceneManager.LoadScene("Level - Copy");
            break;

            case "Fail 7":
                SceneManager.LoadScene("Level - Copy");
            break;
        }
    }

}
