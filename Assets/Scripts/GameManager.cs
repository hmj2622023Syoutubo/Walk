using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject playerprefab;
    int playernum = 1;
    int Characternum = 0;
    int Add;
    int Sub;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlayerAdd(int num)
    {
        Add = 0;
        Add += num;
        playernum += num;
    }
    public void PlayerSub(int num)
    {
        Sub = 0;
        Sub += num;
        playernum -= num;
    }
    public int GetPlayerAdd()
    {
        return Add;
    }
    public int GetPlayerNum()
    {
        return playernum;
    }

    public int CharacterNum()
    {
        Characternum++;
        return Characternum;
    }
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
