using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    private Animator Anim;
    public GameObject Button;

    private void Awake()
    {
        Anim = GetComponent<Animator>();
    }
    // ������Ϸ 
    public void Replay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // ��ͣ����
    public void Pause()
    {
        Anim.SetBool("isPause", true); // ��ͣ����
        Button.SetActive(false); // ���ذ�ť

        if (GameManager._instance.Birds.Count >0)
        {
            if (GameManager._instance.Birds[0].isReleased == false)
            {
                GameManager._instance.Birds[0].canMove = false;
            }
        }
    }

    // ��������
    public void Resume()
    {
        Time.timeScale = 1; // ��������
        Anim.SetBool("isPause", false); // ��������

        if (GameManager._instance.Birds.Count > 0)
        {
            if (GameManager._instance.Birds[0].isReleased == false)
            {
                GameManager._instance.Birds[0].canMove = true;
            }
        }
    }


    // ���ز˵�
    public void Home()
    {
        SceneManager.LoadScene(1);
    }

    public void PauseAnimEnd()
    {
        Time.timeScale = 0; // ��ͣ����
    }

    public void ResumeAnimEnd()
    {
        Button.SetActive(true);
    }



}
