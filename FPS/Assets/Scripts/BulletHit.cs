using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
    void OnCollisionEnter()
    {
        gameObject.SetActive(false);
    }
}
