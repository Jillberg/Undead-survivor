using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text kill;
    public Text level;
    public Text time;
    public Slider exp;

    public static HUD instance;
    public GameObject resultPanel;
    public Text resultText;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.kill.text = GameManger.instance.kill.ToString(); // kill
        this.level.text = GameManger.instance.level.ToString(); // level
        float curExp = GameManger.instance.exp;
        float maxExp = GameManger.instance.nextexp[Mathf.Min(GameManger.instance.level, GameManger.instance.nextexp.Length - 1)];
        exp.value = curExp / maxExp; //经验条


        float remainTime = GameManger.instance.maxGameTime - GameManger.instance.gameTime; //剩余时间

        int minutes = Mathf.FloorToInt(remainTime / 60); //分钟
        int seconds = Mathf.FloorToInt(remainTime % 60); // 秒
        time.text = string.Format("{0:D2}:{1:D2}",minutes ,seconds);
    }

    public void GameResult(bool isWin)
    {
        resultPanel.SetActive(true);
        if(isWin)
        {
            resultText.text = "Congrats!";
        }
        else
        {
            resultText.text = "You dead";
        }
    }
}
