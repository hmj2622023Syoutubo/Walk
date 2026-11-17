using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject playerprefab;
    int playernum = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlayerNum(int num)
    {
        playernum *= num;
    }
    public int GetPlayerNum()
    {
        return playernum;
    }
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
