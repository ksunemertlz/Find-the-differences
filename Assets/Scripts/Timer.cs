using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private Text myText;
    private float gameTime;
    public int myTime;
    void Start()
    {
        myText = GetComponent<Text>();
    }
    void Update()
    {
        myText.text = ": " + myTime;
        gameTime += 1 * Time.deltaTime;
        if(gameTime > 1)
        {
            myTime -= 1;
            gameTime = 0;
        }
        //if(myTime < 1)
        //{
        //    this.enabled = false;
        //}
    }
}
