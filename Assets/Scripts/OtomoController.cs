using UnityEngine;
using UnityEngine.InputSystem;

public class OtomoController : MonoBehaviour
{
    [SerializeField] GameObject Gamemanager;
    private GameManager gamemanager;
    float speed = 0.01f;
    int Number;
    int nowNumber;
    
    // 呼ばれた時にゲームマネージャーを渡す
    public void SetGameManager(GameManager gm)
    {
        gamemanager = gm;
    }
    private void Start()
    {
        Number = 0;
        Number = gamemanager.GetComponent<GameManager>().CharacterNum(1); // 呼ばれた時にナンバーを割り振る
        Debug.Log("toujou");
    }
    void Update()
    {
        nowNumber = gamemanager.GetComponent<GameManager>().GetCharacterNum();
        transform.Translate(0, 0, speed); // 一定のスピードで前に進む
        if (Keyboard.current.aKey.isPressed && transform.position.x > -3) // aが押されている時左に進む
        {
            transform.Translate(-speed, 0, 0);
        }
        if (Keyboard.current.dKey.isPressed && transform.position.x < 3) // dが押されている時右に進む
        {
            transform.Translate(speed, 0, 0);
        }
        if (Number > nowNumber) // 割り振られた数字より全体の数が少ない時に消える
        {
            Debug.Log("キノコ消えた");
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("boss")) // ボスに当たった時消える
        {
            gamemanager.GetComponent<GameManager>().CharacterSub(1);
        }
    }
}
