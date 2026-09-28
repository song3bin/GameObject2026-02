using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 5, -7);

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        
            return;

        transform.position = target.position + offset;
        
    }
}
