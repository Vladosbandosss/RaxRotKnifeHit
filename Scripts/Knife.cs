using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knife : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    private Rigidbody rb;
    private bool onWood;

    private KnifeSpawner knifeSpawner;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        knifeSpawner = GameObject.Find("KnifeSpawner").GetComponent<KnifeSpawner>();
    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !onWood)
        {
            rb.velocity = new Vector3(0f, speed, 0f);
        }  
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Wood")
        {
             gameObject.transform.SetParent(coll.transform);
            rb.velocity = Vector3.zero;
            onWood = true;
            rb.detectCollisions = false;
            knifeSpawner.SpawnKnife();
            knifeSpawner.IncrementScore();
        }

        if (coll.tag == "Knife")
        {
            SceneManager.LoadScene("Game");
        }
    }


}
