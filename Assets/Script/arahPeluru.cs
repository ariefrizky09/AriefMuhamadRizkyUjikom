using UnityEngine;
using TMPro;

public class arahPeluru : MonoBehaviour
{
    public float speed = 5f;
    public float PeluruLifeTime = 2f;
    public int skor;
    public TMP_Text teksSkor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      gameObject.transform.Translate(0, speed * Time.deltaTime, 0);   
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("musuh"))
        {
            TambahSkor();
            Destroy(gameObject);
        }
    }

    public void TambahSkor()
    {
        //soundSkor.Play();
        skor= skor +1;
        teksSkor.text = "Skor : " + skor.ToString();
    }
}
