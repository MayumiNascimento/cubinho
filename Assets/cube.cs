using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNameSpace
{

    public class cube : MonoBehaviour
    {
        public Transform target;
        public float speed;
        public Vector2 axis = new Vector2(x: 0, y: 1);

        // Start is called before the first frame update
        void Start()
        {
            if (target == null)
            {
                target = gameObject.transform;

            }
        }

        // Update is called once per frame
        void Update()
        {
            transform.RotateAround(target.position, axis, speed * Time.deltaTime);
        }
    }
}
