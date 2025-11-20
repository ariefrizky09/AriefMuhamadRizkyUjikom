using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.Mathematics;

public class nyawa : MonoBehaviour
{
    public float health = 10;
    public Image healthImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KurangNyawa()
    {
        if (health > 1)
        {
           // soundEnemy.Play();
            health = health -1;
        
        } else
        {
            //PlayerPrefs.SetInt("skor", skor);
            //PlayerPrefs.Save();
            //simpanHightSkor();
            SceneManager.LoadScene("gameOver");
        }
        
    }

    public void updateNyawa()
    {
        healthImage.fillAmount = health/10;
    }
}
