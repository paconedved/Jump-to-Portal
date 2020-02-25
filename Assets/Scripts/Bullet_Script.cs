using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet_Script : MonoBehaviour
{
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bounds"))
        {
            this.gameObject.SetActive(false);
            Debug.Log("HIT");
        }

        if(collision.CompareTag("grass"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
