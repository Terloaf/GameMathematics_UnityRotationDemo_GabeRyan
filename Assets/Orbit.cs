using UnityEngine;

public class Orbit : MonoBehaviour
{
    private Vector3 direction;
    public GameObject target;
    public float speed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = target.transform.position - transform.position;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * speed);

        transform.Translate(0, 0, 1);
        
    }
}
