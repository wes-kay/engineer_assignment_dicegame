using UnityEngine;

public class Logo : MonoBehaviour
{
    float minx, maxx;

    void Start()
    {
        minx = this.transform.position.y - 5;
        maxx = this.transform.position.y + 5;
    }

    //void Update()
    //{
    //    if (isActiveAndEnabled)
    //    {
    //        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 5, maxx - minx) + minx, transform.position.z);
    //    }
    //}
}
