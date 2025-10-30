using UnityEngine;

public class GoingDown : MonoBehaviour
{
    public Transform player;
    public float triggerDistance = 2f;
    public float speed = 1f;
    private bool goingDown = false;
    private Vector3 startPosition;

    // Update is called once per frame

    void Start()
    {
        if (player == null)
        {
            player = GameObject.Find("Cube").transform;
        }

        // startPosition = player.position;
    }

    void Update()
    {
        if (!goingDown && Vector3.Distance(player.position, transform.position) < triggerDistance)
        {
            Debug.Log("Triggered GoingDown");
            goingDown = true;
        }

        if (goingDown)
        {
            if (player.position.y > 1f)
            {
                player.position += Vector3.down * speed * Time.deltaTime;
            }

            else
            {
                goingDown = false;
                player.position = new Vector3(player.position.x, 1f, player.position.z);
                Debug.Log("Returned to ground.");
            }
        }

        // if (goingDown && player.position.y > 1f)
        // {
        //     player.position -= Vector3.up * speed * Time.deltaTime;
        // }
        
        // if (goingDown && player.position.y > startPosition.y)
        // {
        //     Vector3 pos = player.position;
        //     pos.y -= speed * Time.deltaTime;

        //     if (pos.y < startPosition.y)
        //     {
        //         pos.y = startPosition.y;
        //         goingDown = false;
        //     }

        //     player.position = pos;
        // }
    }
}
