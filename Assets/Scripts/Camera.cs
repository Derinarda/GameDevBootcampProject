using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
        public Transform Target;
        public Vector3 FollowDistance;
        public float FollowSpeed;

        // Start is called before the first frame update
        void Start()
        {
            FollowDistance = Target.position - transform.position;
        }

        private void LateUpdate()
        {

            Vector3 newPos = Target.position - FollowDistance;
            transform.position = newPos;

            /*
            Vector3 newPos = Target.position - FollowDistance;
            transform.position = Vector3.MoveTowards(transform.position, newPos, FollowSpeed * Time.deltaTime);
            */
        }
    // public Transform player;
    // Vector3 offset;

    // void Start()
    // {
    //     offset = transform.position = player.position;
    // }

    // void Update()
    // {
    //     Vector3 targetPos = player.position + offset;
    //     targetPos.x = 0;
    // }


}

