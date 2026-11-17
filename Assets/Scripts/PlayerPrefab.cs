using UnityEngine;

public class PlayerPrefab : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject gamemanager;
    bool playerflag = false;
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

            for (int i = 0; i < gamemanager.GetComponent<GameManager>().GetPlayerNum(); i++)
            {
                item = Instantiate(player);
                item.transform.position = new Vector3(player.GetComponent<PlayerController>().PlayerPostionX(), 0, player.GetComponent<PlayerController>().PlayerPostionZ());
                playerflag = false;
            }
        }
    }
}
