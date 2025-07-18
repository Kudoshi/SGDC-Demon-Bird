using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float MovementSpeed;
    public float TimeToDestroy;

    private void Start()
    {
        Invoke("DestroySelf", TimeToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(-MovementSpeed * Time.deltaTime, 0, 0);
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
