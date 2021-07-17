using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhenEndObjectCollidedLevel5 : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Player")
            {
                 SceneManager.LoadScene("Level 2");
            }
        }
}