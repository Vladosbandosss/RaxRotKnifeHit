using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    [SerializeField] float speed = 0.6f;
    void Update()
    {
        transform.Rotate(0f, speed, 0f);
    }
}
