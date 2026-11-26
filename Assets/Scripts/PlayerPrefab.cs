using UnityEngine;

public class PlayerPrefab : MonoBehaviour
{
    [SerializeField] GameObject player;  // プレイヤー
    [SerializeField] GameObject Mesh;  // お供
    [SerializeField] GameObject gamemanager; // ゲームマネージャー
    [SerializeField] GameManager manager;
    bool playerflagadd = false;
    bool playerflagdouble = false;
    int count = 0;
    int positionX = 1;
    int positionZ =1;
    float CompanionX;
    float CompanionY;
    float CompanionZ;
    public void PlayerFlagAdd()
    {
        playerflagadd = true;
    }
    public void PlayerFlagDouble()
    {
        playerflagdouble = true;
    }

    void Update()
    {
        GameObject item;
        if (playerflagadd == true)
        {
            CompanionX = player.GetComponent<PlayerController>().PlayerPostionX();
            CompanionY = player.GetComponent<PlayerController>().PlayerPostionY();
            CompanionZ = player.GetComponent<PlayerController>().PlayerPostionZ();
            for (int i = 0; i < gamemanager.GetComponent<GameManager>().GetCharacterAdd(); i++)
            {
                item = Instantiate(Mesh);
                item.transform.position = new Vector3(CompanionX + positionX, CompanionY, CompanionZ - positionZ);
                item.GetComponent<OtomoController>().SetGameManager(manager);
                count++;
                positionX--;
                if(count == 3)
                {
                    positionX = 1;
                    positionZ++;
                    count = 0;
                }
            }
            playerflagadd = false;
        }
        if(playerflagdouble == true)
        {
            CompanionX = player.GetComponent<PlayerController>().PlayerPostionX();
            CompanionY = player.GetComponent<PlayerController>().PlayerPostionY();
            CompanionZ = player.GetComponent<PlayerController>().PlayerPostionZ();
            for (int i = 0; i < gamemanager.GetComponent<GameManager>().GetCharacterNum(); i++)
            {
                item = Instantiate(Mesh);
                item.transform.position = new Vector3(CompanionX + positionX, CompanionY, CompanionZ - positionZ);
                item.GetComponent<OtomoController>().SetGameManager(manager);
                count++;
                positionX--;
                if (count == 3)
                {
                    positionX = 1;
                    positionZ++;
                    count = 0;
                }
            }
            playerflagdouble = false;
        }
    }
}
