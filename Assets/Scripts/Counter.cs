using UnityEngine.UI;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private Text counter;
    [SerializeField] private int num; 
    [SerializeField] public float stock;
    public GameObject can1, can2;
    public Timer myTimer;
    void Start()
    {
        counter = GetComponent<Text>();
    }
    void Update()
    {
        counter.text = stock + "/" + num;
        if(stock == num)
        {
            myTimer.enabled = false;
            can1.SetActive(true);
        }
        if (stock != num && myTimer.myTime < 1)
        {
            myTimer.enabled = false;
            can2.SetActive(true);
        }
    }
}
