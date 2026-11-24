using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject playerprefab;
    [SerializeField] GameObject otomo;
    [SerializeField] GameObject text;
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
        Characternum -= num;
    }
    public void CharacterDivide(int num)
    {
        Characternum /= num;
        Debug.Log("”¼•ª‚É‚µ‚½’¼Œã‚Ìcharacter" + Characternum);
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

        return Characternum;
    }
    private void Start()
    {
        Characternum = 0;
    }
    private void Update()
    {
        time++;
        if(time> 100)
        {
            time = 0;
            Debug.Log("charactrnum‚ğí‚É•\¦"+Characternum);
        }
        text.GetComponent<TextMeshProUGUI>().text = Characternum.ToString("F1");
    }
}
