using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject ground;

    private void FixedUpdate()
    {
        ground.transform.position = new Vector3(player.transform.position.x, -1.6f);
    }
}
