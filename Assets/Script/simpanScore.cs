using UnityEngine;
using TMPro;

public class simpanScore : MonoBehaviour
{
    public TMP_Text teksSkor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        teksSkor.text = "Your Score : " + PlayerPrefs.GetInt("skor").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
