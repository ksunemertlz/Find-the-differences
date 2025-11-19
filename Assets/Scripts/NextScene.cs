using YG;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    [SerializeField] Counter count;
    public Timer myTimer;
    private int numOfLevel = 1;
    public void toMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ReastartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
            numOfLevel = 1;
        else if (SceneManager.GetActiveScene().buildIndex == 3)
            numOfLevel = 2;
        else if (SceneManager.GetActiveScene().buildIndex == 4)
            numOfLevel = 3;
        else if (SceneManager.GetActiveScene().buildIndex == 5)
            numOfLevel = 4;
        else if (SceneManager.GetActiveScene().buildIndex == 6)
            numOfLevel = 5;
        else if (SceneManager.GetActiveScene().buildIndex == 7)
            numOfLevel = 6;
        else if (SceneManager.GetActiveScene().buildIndex == 8)
            numOfLevel = 7;
        else if (SceneManager.GetActiveScene().buildIndex == 9)
            numOfLevel = 8;
        else if (SceneManager.GetActiveScene().buildIndex == 10)
            numOfLevel = 9;
        else if (SceneManager.GetActiveScene().buildIndex == 11)
            numOfLevel = 10;
        else if (SceneManager.GetActiveScene().buildIndex == 12)
            numOfLevel = 11;
        else if (SceneManager.GetActiveScene().buildIndex == 13)
            numOfLevel = 12;
        else if (SceneManager.GetActiveScene().buildIndex == 14)
            numOfLevel = 13;
        else if (SceneManager.GetActiveScene().buildIndex == 15)
            numOfLevel = 14;
        else if (SceneManager.GetActiveScene().buildIndex == 16)
            numOfLevel = 15;
        else if (SceneManager.GetActiveScene().buildIndex == 17)
            numOfLevel = 16;
        else if (SceneManager.GetActiveScene().buildIndex == 18)
            numOfLevel = 17;
        else if (SceneManager.GetActiveScene().buildIndex == 19)
            numOfLevel = 18;
        else if (SceneManager.GetActiveScene().buildIndex == 20)
            numOfLevel = 19;
        else if (SceneManager.GetActiveScene().buildIndex == 21)
            numOfLevel = 20;
        else if (SceneManager.GetActiveScene().buildIndex == 22)
            numOfLevel = 21;
        else if (SceneManager.GetActiveScene().buildIndex == 23)
            numOfLevel = 22;
        else if (SceneManager.GetActiveScene().buildIndex == 24)
            numOfLevel = 23;
        else if (SceneManager.GetActiveScene().buildIndex == 25)
            numOfLevel = 24;
        else if (SceneManager.GetActiveScene().buildIndex == 25)
            numOfLevel = 25;


        YandexGame.NewLeaderboardScores("Level", numOfLevel);
    }
    public void AddTime()
    {
        YandexGame.RewVideoShow(1);
        count.can2.SetActive(false);
        myTimer.myTime = 30;
        myTimer.enabled = true;
    }
    public void to1()
    {   if (PlayerPrefs.GetInt("lev25") == 25)
            SceneManager.LoadScene(25);
        else if (PlayerPrefs.GetInt("lev24") == 24)
            SceneManager.LoadScene(24);
        else if (PlayerPrefs.GetInt("lev23") == 23)
            SceneManager.LoadScene(23);
        else if (PlayerPrefs.GetInt("lev22") == 22)
            SceneManager.LoadScene(22);
        else if (PlayerPrefs.GetInt("lev21") == 21)
            SceneManager.LoadScene(21);
        else if (PlayerPrefs.GetInt("lev20") == 20)
            SceneManager.LoadScene(20);
        else if (PlayerPrefs.GetInt("lev19") == 19)
            SceneManager.LoadScene(19);
        else if (PlayerPrefs.GetInt("lev18") == 18)
            SceneManager.LoadScene(18);
        else if (PlayerPrefs.GetInt("lev17") == 17)
            SceneManager.LoadScene(17);
        else if (PlayerPrefs.GetInt("lev16") == 16)
            SceneManager.LoadScene(16);
        else if (PlayerPrefs.GetInt("lev15") == 15)
            SceneManager.LoadScene(15);
        else if (PlayerPrefs.GetInt("lev14") == 14)
            SceneManager.LoadScene(14);
        else if (PlayerPrefs.GetInt("lev13") == 13)
            SceneManager.LoadScene(13);
        else if (PlayerPrefs.GetInt("lev12") == 12)
            SceneManager.LoadScene(12);
        else if (PlayerPrefs.GetInt("lev11") == 11)
            SceneManager.LoadScene(11);
        else if (PlayerPrefs.GetInt("lev10") == 10)
            SceneManager.LoadScene(10);
        else if (PlayerPrefs.GetInt("lev9") == 9)
            SceneManager.LoadScene(9);
        else if (PlayerPrefs.GetInt("lev8") == 8)
            SceneManager.LoadScene(8);
        else if (PlayerPrefs.GetInt("lev7") == 7)
            SceneManager.LoadScene(7);
        else if (PlayerPrefs.GetInt("lev6") == 6)
            SceneManager.LoadScene(6);
        else if (PlayerPrefs.GetInt("lev5") == 5)
            SceneManager.LoadScene(5);
        else if (PlayerPrefs.GetInt("lev4") == 4)
            SceneManager.LoadScene(4);
        else if (PlayerPrefs.GetInt("lev3") == 3)
            SceneManager.LoadScene(3);
        else if (PlayerPrefs.GetInt("lev2") == 2)
            SceneManager.LoadScene(2);
        else
            SceneManager.LoadScene(1);
    }
    public void to2()
    {
        PlayerPrefs.SetInt("lev2", 2);
        SceneManager.LoadScene(2);
    }
    public void to3()
    {
        PlayerPrefs.SetInt("lev3", 3);
        SceneManager.LoadScene(3);
    }
    public void to4()
    {
        PlayerPrefs.SetInt("lev4", 4);
        SceneManager.LoadScene(4);
    }
    public void to5()
    {
        PlayerPrefs.SetInt("lev5", 5);
        SceneManager.LoadScene(5);
    }
    public void to6()
    {
        PlayerPrefs.SetInt("lev6", 6);
        SceneManager.LoadScene(6);
    }
    public void to7()
    {
        PlayerPrefs.SetInt("lev7", 7);
        SceneManager.LoadScene(7);
    }
    public void to8()
    {
        PlayerPrefs.SetInt("lev8", 8);
        SceneManager.LoadScene(8);
    }
    public void to9()
    {
        PlayerPrefs.SetInt("lev9", 9);
        SceneManager.LoadScene(9);
    }
    public void to10()
    {
        PlayerPrefs.SetInt("lev10", 10);
        SceneManager.LoadScene(10);
    }
    public void to11()
    {
        PlayerPrefs.SetInt("lev11", 11);
        SceneManager.LoadScene(11);
    }
    public void to12()
    {
        PlayerPrefs.SetInt("lev12", 12);
        SceneManager.LoadScene(12);
    }
    public void to13()
    {
        PlayerPrefs.SetInt("lev13", 13);
        SceneManager.LoadScene(13);
    }
    public void to14()
    {
        PlayerPrefs.SetInt("lev14", 14);
        SceneManager.LoadScene(14);
    }
    public void to15()
    {
        PlayerPrefs.SetInt("lev15", 15);
        SceneManager.LoadScene(15);
    }
    public void to16()
    {
        PlayerPrefs.SetInt("lev16", 16);
        SceneManager.LoadScene(16);
    }
    public void to17()
    {
        PlayerPrefs.SetInt("lev17", 17);
        SceneManager.LoadScene(17);
    }
    public void to18()
    {
        PlayerPrefs.SetInt("lev18", 18);
        SceneManager.LoadScene(18);
    }
    public void to19()
    {
        PlayerPrefs.SetInt("lev19", 19);
        SceneManager.LoadScene(19);
    }
    public void to20()
    {
        PlayerPrefs.SetInt("lev20", 20);
        SceneManager.LoadScene(20);
    }
    public void to21()
    {
        PlayerPrefs.SetInt("lev21", 21);
        SceneManager.LoadScene(21);
    }
    public void to22()
    {
        PlayerPrefs.SetInt("lev22", 22);
        SceneManager.LoadScene(22);
    }
    public void to23()
    {
        PlayerPrefs.SetInt("lev23", 23);
        SceneManager.LoadScene(23);
    }
    public void to24()
    {
        PlayerPrefs.SetInt("lev24", 24);
        SceneManager.LoadScene(24);
    }
    public void to25()
    {
        PlayerPrefs.SetInt("lev25", 25);
        SceneManager.LoadScene(25);
    }
    public void Again()
    {
        PlayerPrefs.DeleteAll();
    }
   
}
