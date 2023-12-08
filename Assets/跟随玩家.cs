using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 跟随玩家 : MonoBehaviour
{

    public Transform tf;

    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 1, -6);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(tf.position);
        this.transform.position = tf.position+offset ;
    }
}
