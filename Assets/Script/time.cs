using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class time : MonoBehaviour
{
    public float waktu = 10f;
    //public TMP_Text timerText;
    public bool isCounting = true;
    public Score score;
    public Image fillTime;
    private Coroutine timerCoroutine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        timerCoroutine = StartCoroutine(HitungTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator HitungTimer()
    {
        //untuk hitung mundur waktu
        while (isCounting && waktu > 0)
        {
            yield return new WaitForSeconds(1f);

            waktu -= 1;
            //timerText.text = waktu.ToString();
            fillTime.fillAmount = waktu /10;
            //yield return new WaitForSeconds(1);
        }

        // kondisi jika waktu habis atau bisa ketika waktu menyentuh waktu tertentu
        if (waktu <= 0)
        {
            isCounting = false;
            //timerText.text = "Waktu : 0";
            PlayerPrefs.SetInt("skor", score.isiSkor);
            PlayerPrefs.Save();
            //objKarakter.simpanHightSkor();
            SceneManager.LoadScene("gameOver");
        }
    }
}
