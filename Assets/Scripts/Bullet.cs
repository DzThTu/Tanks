
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20;

    public float lifeTime = 4;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
