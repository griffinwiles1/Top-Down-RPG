using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private void onCollisionEnter2D(Collision2D collision) {
        Destroy(gameObject);
    }
}
