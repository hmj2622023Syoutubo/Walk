using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject Gamemanager;
    [SerializeField] GameObject Playerprefab;
    [SerializeField] int pos;
    [SerializeField] private AudioClip plusse;
    [SerializeField] private AudioClip doublese;
    [SerializeField] private AudioClip downse;
    AudioSource aud;
    float speed = 0.01f;
    bool a = false;
    public float PlayerPostionX() // プレイヤーのx座標を渡す
    {
        return transform.position.x;
    }
    public float PlayerPostionY() // プレイヤーのy座標を渡す
    {
        return transform.position.y;
    }
    public float PlayerPostionZ() // プレイヤーのz座標を渡す
    {
        return transform.position.z;
    }
    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (transform.position.z < pos)
        {
            transform.Translate(0, 0, speed);
        }
        if (Keyboard.current.aKey.isPressed && transform.position.x > -3)
        {
            transform.Translate(-speed,0,0);
        }
        if(Keyboard.current.dKey.isPressed && transform.position.x < 3)
        {
            transform.Translate(speed,0,0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("plus")) // プラスの壁に当たった時の処理
        {
            aud.PlayOneShot(plusse);
            Destroy(other.gameObject);
            Gamemanager.GetComponent<GameManager>().CharacterAdd(2);
            Playerprefab.GetComponent<PlayerPrefab>().PlayerFlagAdd();
        }
        if (other.gameObject.CompareTag("degree")) // マイナスの壁に当たった時の処理
        {
            aud.PlayOneShot(downse);
            Destroy(other.gameObject);
            Gamemanager.GetComponent<GameManager>().CharacterSub(2); 
        }
        if (other.gameObject.CompareTag("double")) // かけるの壁に当たった時の処理
        {
            aud.PlayOneShot(doublese);
            Destroy(other.gameObject);
            Playerprefab.GetComponent<PlayerPrefab>().PlayerFlagDouble(); 
        }
        if (other.gameObject.CompareTag("divide")) // かけるの壁に当たった時の処理
        {
            aud.PlayOneShot(downse);
            Destroy(other.gameObject);
            Gamemanager.GetComponent<GameManager>().CharacterDivide(2); // かけるの壁に当たった時の処理
        }
    }
}
