using UnityEngine;

public class Tipper : MonoBehaviour
{
    // // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {

    // }

    // Update is called once per frame
    public float tipSpeed = 60f;
    private float currentTip = 0f;
    
    void Update()
    {
        float tipDirection = 0f;

        if (Input.GetKey(KeyCode.PageUp) || Input.GetKey(KeyCode.D))
            tipDirection = 1f;
        if (Input.GetKey(KeyCode.PageDown) || Input.GetKey(KeyCode.U))
            tipDirection = -1f;
        currentTip += tipDirection * tipSpeed * Time.deltaTime;

        currentTip = Mathf.Clamp(currentTip, -80f, 80f);

        transform.localEulerAngles = new Vector3(currentTip, 0f, 0f);
    }
}
