using NUnit.Framework;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;

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
        if (Characternum < otomonum.Count && otomonum.Count > 0)
        {
            int sub = otomonum.Count - Characternum;
            for (int i = 0; i < sub; i++)
            {
                otomonum.Remove(otomonum.Max());
            }
        }
    }

    // 受け取った数でわる
    public void CharacterDivide(int num)
    {
        Characternum /= num;
        if (Characternum < otomonum.Count && otomonum.Count > 0)
        {
            int sub = otomonum.Count - Characternum;
            for (int i = 0; i < sub; i++)
            {
                otomonum.Remove(otomonum.Max());
            }
        }
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

    // リストの中で最も大きい数を渡す
    public int GetCharacterList()
    {
        if (otomonum.Count > 0)
        {
            int maxScore = otomonum.Max();
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
        time++;
        if(time >= 100)
        {
            time = 0;
            Debug.Log("characternum表示" + Characternum);
            Debug.Log("リストの長さ表示" + otomonum.Count);
        }
        if(Characternum < 0)
        {
            SceneManager.LoadScene("GameoverScene");
        }
        text.GetComponent<TextMeshProUGUI>().text = otomonum.Count.ToString("F1");
    }
}
