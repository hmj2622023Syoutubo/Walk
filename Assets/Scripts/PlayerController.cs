using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject Gamemanager;
    [SerializeField] GameObject Playerprefab;
    [SerializeField] int pos;
    float speed = 0.01f;
    float plyaerx;
    float playery;
    int Number;
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
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("plus")) // プラスの壁に当たった時の処理
        {
            Destroy(collision.gameObject);
            Gamemanager.GetComponent<GameManager>().CharacterAdd(2);
            Playerprefab.GetComponent<PlayerPrefab>().PlayerFlagAdd();
        }
        if(collision.gameObject.CompareTag("degree"))
        {
            Destroy(collision.gameObject);
            Gamemanager.GetComponent<GameManager>().CharacterSub(2); // マイナスの壁に当たった時の処理
            Debug.Log("hetta");
        }
        if (collision.gameObject.CompareTag("double"))
        {
            Destroy(collision.gameObject);
            Playerprefab.GetComponent<PlayerPrefab>().PlayerFlagDouble(); // かけるの壁に当たった時の処理
        }
        if (collision.gameObject.CompareTag("divide"))
        {
            Destroy(collision.gameObject);
            Gamemanager.GetComponent<GameManager>().CharacterDivide(2); // 悪の壁に当たった時の処理
        }

        if (collision.gameObject.CompareTag("boss"))
        {
            //Destroy(gameObject);
        }
    }
}
