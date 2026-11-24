using UnityEngine;
using UnityEngine.InputSystem;

public class OtomoController : MonoBehaviour
{
    [SerializeField] GameObject Gamemanager;
    private GameManager gamemanager;
    float speed = 0.01f;
    int Number;
    int nowNumber;
    
    public void SetGameManager(GameManager gm)
    {
        gamemanager = gm;
    }
    private void Start()
    {
        Number = 0;
        Number = gamemanager.GetComponent<GameManager>().CharacterNum(1);
        Debug.Log("toujou");
       // Debug.Log(Number);
    }
    void Update()
    {
        nowNumber = gamemanager.GetComponent<GameManager>().GetCharacterNum();
        transform.Translate(0, 0, speed);
        if (Keyboard.current.aKey.isPressed && transform.position.x > -3)
        {
            transform.Translate(-speed, 0, 0);
        Debug.Log("常にnumberを表示" + Number);
        Debug.Log("nownumberを表示" + nowNumber);
        }
        if (Keyboard.current.dKey.isPressed && transform.position.x < 3)
        {
            transform.Translate(speed, 0, 0);
        }
        if (Number > nowNumber)
        {
           Debug.Log("キノコ消えた");
           Destroy(gameObject);
        }
        else if(Number == nowNumber)
        {
            Debug.Log("消えてない");
           // Debug.Log(Number);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("boss"))
        {
            Destroy(gameObject);
        }
    }
}
