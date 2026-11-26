using NUnit.Framework;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using System.Collections.Generic;
using System.Linq;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject playerprefab;
    [SerializeField] GameObject otomo;
    [SerializeField] GameObject text;
    int Characternum;
    int Add;
    int time;
    List<int> otomonum = new List<int>();
    
    // 増える数を受け取る
    public void CharacterAdd(int num)
    {
        Add = 0;
        Add += num;
    }

    // 受け取った数でひく
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
    public int CharacterNum()
    {
        Characternum ++;
        otomonum.Add(Characternum);
        return Characternum;
    }

    // リストから消す
    public void CharacterRemove(int num)
    {
        otomonum.Remove(num);
    }

    // リストの中で最も大きい数を消す
    public int GetCharacterList()
    {
        if (otomonum.Count > 0)
        {
            int maxScore = otomonum.Max();
            Debug.Log("最大値: " + maxScore);
            return maxScore;
        }
        return 0;
    }
    private void Start()
    {
        Characternum = 0; // 初期化
    }
    private void Update()
    {
        if(Characternum < otomonum.Count)
        {
            otomonum.Remove(otomonum.Max());
        }
        text.GetComponent<TextMeshProUGUI>().text = otomonum.Count.ToString("F1");
    }
}
