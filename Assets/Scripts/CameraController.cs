using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float maxpos;
    public float minpos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetpos = new Vector3(target.position.x, target.position.y, target.position.z);
        targetpos.y = Mathf.Clamp(targetpos.y, minpos, maxpos);

        transform.position = new Vector3(transform.position.x, targetpos.y, transform.position.z);

        /*Vector3 targetposition = new Vector3(target.position.x, target.position.y, transform.position.z);

        targetposition.x = Mathf.Clamp(targetposition.x, minpos.x, maxpos.x);

        targetposition.y = Mathf.Clamp(targetposition.y, minpos.y, maxpos.y);

        if (transform.position != target.position)
        {
            transform.position = Vector3.Lerp(transform.position, targetposition, smoothing);
        }*/
    }
}
