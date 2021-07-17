using UnityEngine;

public class DeathByVoid : MonoBehaviour
{
    //Detect collisions between the GameObjects with Colliders attached
    public Transform target;
    public Transform player;
    public float MaxYPos;

    void Start() 
    {
        
    }
    void FixedUpdate() 
    {
        if (player.position.y < MaxYPos) 
        {
            player.position = target.position;
        }
    }
}