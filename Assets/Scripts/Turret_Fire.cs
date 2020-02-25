using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Fire : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void Shoot()
    {
        Instantiate(bullet, new Vector2(transform.position.x, transform.position.y + 0.2f), Quaternion.identity);
    }
}
