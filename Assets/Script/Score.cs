using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text TeksSkor;
    public int isiSkor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        updateSkor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateSkor()
    {
        TeksSkor.text = "Score : " + isiSkor;
    }

    public void addSkor()
    {
        isiSkor++;
    }
}
