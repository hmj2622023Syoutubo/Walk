using UnityEngine;

public class PlayerPrefab : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject Mesh;
    [SerializeField] GameObject gamemanager;
    [SerializeField] GameManager manager;
    bool playerflag = false;
    int count = 0;
    int positionX = 1;
    int positionZ =1;
    float CompanionX;
    float CompanionZ;
    public void PlayerFlag()
    {
        playerflag = true;
    }

    void Update()
    {
        GameObject item;
        if (playerflag == true)
        {
            CompanionX = player.GetComponent<PlayerController>().PlayerPostionX();
            CompanionZ = player.GetComponent<PlayerController>().PlayerPostionZ();
            for (int i = 0; i < gamemanager.GetComponent<GameManager>().GetCharacterAdd(); i++)
            {
                item = Instantiate(Mesh);
                item.transform.position = new Vector3(CompanionX + positionX, 0, CompanionZ - positionZ);
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
            playerflag = false;
        }
    }
}
