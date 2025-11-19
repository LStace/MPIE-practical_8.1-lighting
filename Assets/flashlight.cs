using UnityEngine;

public class flashlight : MonoBehaviour
{
    private Light my_light;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        my_light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            my_light.enabled = !my_light.enabled;
            Debug.Log("pressed");
        }
    }
}
