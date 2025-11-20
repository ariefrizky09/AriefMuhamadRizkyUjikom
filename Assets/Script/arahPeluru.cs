using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class arahPeluru : MonoBehaviour
{
    public float speed = 5f;
    public float PeluruLifeTime = 2f;
    public Score skor;
    //public TMP_Text teksSkor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, PeluruLifeTime);
        GameObject _karakter = GameObject.FindGameObjectWithTag("skor");
        skor = _karakter.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
      gameObject.transform.Translate(0, speed * Time.deltaTime, 0);   
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("musuh"))
        {
            Destroy(gameObject);
            skor.addSkor();
            skor.updateSkor();
            
        }
    }
}
