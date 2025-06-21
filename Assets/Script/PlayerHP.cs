//空腹度ゲージ・ダメージ処理
//ダメージ間隔は未定・食べ物による回復は未実装
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading;
public class PlayerHP : MonoBehaviour
{
    public Slider guage;
    public float playerMaxHP;
    public float currentHP = 500;
    public float damagePerMinute;
    public float daylength;
    public int dayCount;
    public int count;
    public float time;
    public float damageFrequency;
    public float recoverRange;
    // Start is called before the first frame update
    void Start()
    {
        playerMaxHP = 500 + currentHP;//子熊の空腹度の上限
        currentHP = playerMaxHP;//子熊の現在の空腹度
        guage.value = 1;//ゲージの最大値
        damagePerMinute = 1.0f + 0.125f * dayCount;//1回あたりの空腹度へのダメージ
        count = 0;//ダメージ回数を管理する変数
        time = 0;//経過時間を管理する変数
        damageFrequency = 20;//1秒ごとに与えるダメージの回数。
        recoverRange = 200;
        daylength = 900 * (damageFrequency / 10);//1日の長さ。単位は分を想定している。
    }

    // Update is called once per frame
    void Update()
    {
      

        if (count <= daylength || currentHP == 0)
        {
            if (time > count / damageFrequency)
            {
                if (currentHP > damagePerMinute)
                {
                    currentHP -= damagePerMinute;
                    guage.value = currentHP / playerMaxHP;
                    //Debug.Log("子熊の残りHP:" + currentHP);
                    //↓正規版では使わない。時間とダメージ間隔のデバッグのみに用いる。
                    //Thread.Sleep(50);
                }
                else
                {
                    currentHP = 0;
                    guage.value = 0;
                    //Debug.Log("子熊は死んでしまった！");
                    //SceneManager.LoadScene("title");
                }
                count++;
            }
            else
            {
                time += Time.deltaTime;
            }
        }
        else
        {
            //Debug.Log("生き残ることに成功！");
            //SceneManager.LoadScene("Result");
        }
        //デバッグ用HP回復処理
        /*        if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (currentHP + recoverRange >= playerMaxHP)
                    {
                        currentHP = playerMaxHP;
                    }
                    else
                    {
                        currentHP += recoverRange;
                    }
                }
        */
    }
    private void OnCollisionExit(Collision collision)
    {
        if (GetComponent<Collider>().gameObject.tag == "Apple")
        {
            if (currentHP + recoverRange >= playerMaxHP)
            {
                currentHP = playerMaxHP;
            }
            else
            {
                currentHP += recoverRange;
            }
        }
    }
}