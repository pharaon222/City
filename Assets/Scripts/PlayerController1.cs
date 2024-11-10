using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public int speed = 10;
    public float acceleration = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * acceleration);
    }
}
