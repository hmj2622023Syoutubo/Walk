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
    
    // 増える数を受け取る
    public void CharacterAdd(int num)
    {
        Add = 0;
        Add += num;
    }

    // 受け取った数をひく
    public void CharacterSub(int num)
    {
        Characternum -= num;
    }

    // 受け取った数でわる
    public void CharacterDivide(int num)
    {
        Characternum /= num;
        Debug.Log("半分にした直後のcharacter" + Characternum);
    }

    // 増えた数を渡す 
    public int GetCharacterAdd()
    {
        return Add;
    }

    // キャラクターの総数を渡す
    public int GetCharacterNum()
    {
        return Characternum;
    }

    // キャラクターの総数を増やして渡す
    public int CharacterNum(int num)
    {
        Characternum += num;

        return Characternum;
    }
    private void Start()
    {
        Characternum = 0; // 初期化
    }
    private void Update()
    {
        time++;
        if(time> 100)
        {
            time = 0;
            Debug.Log("charactrnumを常に表示"+Characternum);
        }
        text.GetComponent<TextMeshProUGUI>().text = Characternum.ToString("F1");
    }
}
