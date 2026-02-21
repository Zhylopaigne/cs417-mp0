using UnityEngine;
using UnityEngine.InputSystem;


public class LightScript : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        light = GetComponent<Light>();
        action.action.performed += (ctx) =>
        {
            light.color = new Color(255, 0, 255);
        };
    }

    // Update is called once per frame
    void Update()
    {

    }
}
