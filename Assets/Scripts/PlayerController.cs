using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject Gamemanager;
    [SerializeField] GameObject Playerprefab;
    float speed = 0.01f;
    float plyaerx;
    float playery;
    public float PlayerPostionX()
    {
        return transform.position.x;
    }
    public float PlayerPostionZ()
    {
        return transform.position.z;
    }

    void Update()
    {
        transform.Translate(0,0,speed);
        if (Keyboard.current.aKey.isPressed)
        {
            transform.Translate(-speed,0,0);
        }
        if(Keyboard.current.dKey.isPressed)
        {
            transform.Translate(speed,0,0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("double"))
        {
            Gamemanager.GetComponent<GameManager>().PlayerNum(2);
            Playerprefab.GetComponent<PlayerPrefab>().PlayerFlag();
        }
    }
}
