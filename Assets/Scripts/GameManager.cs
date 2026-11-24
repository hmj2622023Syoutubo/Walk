using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject playerprefab;
    [SerializeField] GameObject otomo;
    int Characternum;
    int Add;
    int time;
    public void CharacterAdd(int num)
    {
        Add = 0;
        Add += num;
    }
    public void CharacterSub(int num)
    {
        Debug.Log("Œ¸‚ç‚³‚ê‚é‘O‚Ìcharacternum"+Characternum);
        Characternum -= num;
        Debug.Log("‚Ö‚ç‚³‚ê‚½‚º‚¦‚¦‚¦‚¦‚¦‚¦" + Characternum);
    }
    public int GetCharacterAdd()
    {
        return Add;
    }
    public int GetCharacterNum()
    {
        return Characternum;
    }

    public int CharacterNum(int num)
    {
        Characternum += num;
        Debug.Log("ŠÖ”“Ç‚ñ‚Åcharacternum‘‚â‚µ‚½"+Characternum);
        return Characternum;
    }
    private void Start()
    {
        Characternum = 0;
        Debug.Log("‰Šú‰»‚µ‚½");
    }
    private void Update()
    {
        time++;
        if(time> 100)
        {
            time = 0;
            Debug.Log("charactrnum‚ğí‚É•\¦"+Characternum);
        }
    }
}
