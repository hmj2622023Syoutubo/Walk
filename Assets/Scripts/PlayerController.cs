using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,0.01f);
        if (Keyboard.current.aKey.isPressed)
        {
            transform.Translate(-0.01f,0,0);
        }
        if(Keyboard.current.dKey.isPressed)
        {
            transform.Translate(0.01f,0,0);
        }
    }
}
