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
        Number = gamemanager.GetComponent<GameManager>().CharacterNum(); // 呼ばれた時にナンバーを割り振る
        Debug.Log("toujou");
    }
    void Update()
    {
        nowNumber = gamemanager.GetComponent<GameManager>().GetCharacterList();
        transform.Translate(0, 0, speed); // 一定のスピードで前に進む
        if (Number > nowNumber) // 割り振られた数字より全体の数が少ない時に消える
        {
            gamemanager.GetComponent<GameManager>().CharacterRemove(Number);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("boss")) // ボスに当たった時消える
        {
            gamemanager.GetComponent<GameManager>().CharacterRemove(Number);
            Destroy(gameObject);
        }
    }
}
