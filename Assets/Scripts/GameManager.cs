using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject playerprefab;
    int playernum = 1;
    int Add;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlayerNum(int num)
    {
        Add = 0;
        Add += num;
        playernum += num;
    }
    public int GetPlayerAdd()
    {
        return Add;
    }
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
