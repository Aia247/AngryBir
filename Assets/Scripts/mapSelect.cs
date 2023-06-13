using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mapSelect : MonoBehaviour
{
    public int starsNum = 0;
    public bool isSelect = false;

    public GameObject Stars;
    public GameObject Lock;

    public GameObject Panel;
    public GameObject Map;
    public Text starsText;

    public int startNum = 1;
    public int endNum = 18;
 

    private void Start()
    {
        // PlayerPrefs.DeleteAll();
        if (PlayerPrefs.GetInt("totalNum", 0) >= starsNum) // Ĭ��Ϊ0
        {
            isSelect = true;
        }
        

        if (isSelect)
        {
            Stars.SetActive(true);
            Lock.SetActive(false);

            // ����������ʾ
            int counts = 0;
            for (int i = startNum; i<= endNum; i++)
            {
                counts += PlayerPrefs.GetInt("level" + i.ToString(), 0);
            }
            starsText.text = " " + counts.ToString() + "/" + ((endNum - startNum + 1) * 3).ToString();

        }
    }


    // �����
    public void Selected()
    {
        if (isSelect)
        {
            Panel.SetActive(true);
            Map.SetActive(false);
        }
    }

    
}
