using UnityEngine;

public class GoingUp : MonoBehaviour
{
    public Transform player;
    public float triggerDistance = 0.5f;
    public float speed = 1f;
    private bool goingUp = false;

    void Start()
    {
        if (player == null)
        {
            player = GameObject.Find("Cube").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!goingUp && Vector3.Distance(player.position, transform.position) < triggerDistance)
        {
            goingUp = true;
            Debug.Log("Going Up Triggered");
        }

        // if (goingUp && player.position.y < 10f)
        // {
        //     player.position += Vector3.up * speed * Time.deltaTime;
        // }

        if (goingUp)
        {
            if (player.position.y < 10f)
            {
                player.position += Vector3.up * speed * Time.deltaTime;
            }
            else
            {
                goingUp = false;
                player.position = new Vector3(player.position.x, 10f, player.position.z);
            }
        }
    }
}
