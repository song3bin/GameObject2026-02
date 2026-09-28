using UnityEngine;

public class SimpleTranslate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5.0f;
   
    // Update is called once per frame
    private void Update()
    {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        transform.Translate(vec*speed* Time.deltaTime);
    }
}
