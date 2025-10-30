using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {

    // }

    // Update is called once per frame

    public float moveSpeed = 1f;
    public float turnSpeed = 60f;
    void Update()
    {
        float move = 0f;
        float turn = 0f;

        if (Input.GetKey(KeyCode.UpArrow))
            move = 1f;
        if (Input.GetKey(KeyCode.DownArrow))
            move = -1f;

        if (Input.GetKey(KeyCode.LeftArrow))
            turn = -1f;
        if (Input.GetKey(KeyCode.RightArrow))
            turn = 1f;

        transform.Translate(Vector3.forward * move * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * turn * turnSpeed * Time.deltaTime);
    }
}
