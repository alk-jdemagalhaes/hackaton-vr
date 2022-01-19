using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    public float Scale = 1;
    // Start is called before the first frame update
    Transform transform;
    void Start()
    {
        transform = gameObject.GetComponent(typeof(Transform)) as Transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(Scale,Scale,Scale);
    }
}
