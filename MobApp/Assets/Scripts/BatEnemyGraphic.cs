using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class BatEnemyGraphic : MonoBehaviour
{
   public AIPath aiPath;

    // Update is called once per frame
    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f)//if positive, travelling right
        {
            transform.localScale = new Vector3(-0.5f, 0.5f, 0.25f);
        } else if (aiPath.desiredVelocity.x <= -0.01f)//if negative, travelling left
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.25f);
        }
    }
}
