using UnityEngine;

public class Jumper : MonoBehaviour
{

    public float yChange = 10f;
    public float SpeedTreeWindAsset = 1f;
    private float targetY;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetY = transform.position.y + yChange;
    }

    // Update is called once per frame
    void Update()
    {
        // if (transform.position.y < targetY)
        // {
        //     Vector3 position = transform.position;
        //     position.y = position.y + SpeedTreeWindAsset * Time.deltaTime;

        //     if (position.y > targetY)
        //     {
        //         position.y = targetY;
        //     }
            
        //     transform.position = position;
        // }
    }
}
