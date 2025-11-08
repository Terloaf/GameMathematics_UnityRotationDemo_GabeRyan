using Unity.Mathematics;
using UnityEngine;

public class LookRotation : MonoBehaviour
{
    public GameObject target;
    public GameObject upTarget;
    public Vector3 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direction = upTarget.transform.position - transform.forward;
    }

    // Update is called once per frame
    void Update()
    {


        transform.rotation = Quaternion.LookRotation(target.transform.position);
        transform.rotation = quaternion.LookRotation(upTarget.transform.position, upTarget.transform.position);


    }

}
