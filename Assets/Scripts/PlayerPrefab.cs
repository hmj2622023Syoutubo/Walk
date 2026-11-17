using UnityEngine;

public class PlayerPrefab : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject gamemanager;
    bool playerflag = false;
    float CompanionX;
    float CompanionZ;
    public void PlayerFlag()
    {
        playerflag = true;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject item;
        if (playerflag == true)
        {
            CompanionX = player.GetComponent<PlayerController>().PlayerPostionX();
            CompanionZ = player.GetComponent<PlayerController>().PlayerPostionZ();
            for (int i = 0; i < gamemanager.GetComponent<GameManager>().GetPlayerNum(); i++)
            {
                item = Instantiate(player);
                item.transform.position = new Vector3(CompanionX, 0, CompanionZ);
                playerflag = false;
            }
        }
    }
}
