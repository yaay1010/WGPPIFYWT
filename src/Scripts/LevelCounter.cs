using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Level 1") 
         {
             Debug.Log("Level 1");
         }
         else if (sceneName == "Level 2")
         {
             Debug.Log("Level 2");
         }
         // Retrieve the index of the scene in the project's build settings.
         int buildIndex = currentScene.buildIndex;
 
         // Check the scene name as a conditional.
         switch (buildIndex)
         {
         case 0:
             // Do something...
             break;
         case 1:
             // Do something...
             break;
         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
