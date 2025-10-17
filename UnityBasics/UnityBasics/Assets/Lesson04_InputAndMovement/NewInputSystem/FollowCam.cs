using UnityEngine;
namespace InputAndMovement
{
    public class FollowCam : MonoBehaviour
    {

        [SerializeField] Transform followTransform;
        [SerializeField] private float yOffset = 2.5f;
        [SerializeField] private float zOffset = -15.0f;
        [SerializeField] private float xRotation = 3.0f;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            transform.rotation = Quaternion.Euler(xRotation, 0.0f, 0.0f);
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 followTargetWorldPos = transform.TransformPoint(followTransform.position);
            followTargetWorldPos.z += zOffset;
            followTargetWorldPos.y += yOffset;

            Vector3 myTargetPos = transform.InverseTransformPoint(followTargetWorldPos);
            Vector3 newPos = new Vector3();

            if (myTargetPos.z >= transform.position.z)
            {
                newPos = Vector3.Lerp(transform.position, myTargetPos, 0.75f * Time.deltaTime);
            }
            else
            {
                newPos = Vector3.Lerp(transform.position, myTargetPos, 15.0f * Time.deltaTime);
            }

            transform.position = newPos;


        }
    }
}


