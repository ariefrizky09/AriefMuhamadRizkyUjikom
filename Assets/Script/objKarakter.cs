using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.Mathematics;

public class objKarakter : MonoBehaviour
{
//    public AudioSource soundJump;
//     public AudioSource soundSkor;
//     public AudioSource soundEnemy;
//     public AudioSource soundNyawa;
    public float health = 10;
    public int skor;
    public int hightscore;
    public Vector2 mousePosition;
    public Image healthImage;
    public TMP_Text teksSkor;
    // public Transform KarakterTransform;
    // public Vector2 PosisiKlik;
    public GameObject spawnPeluru;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.HasKey("hightscore"))
        {
            hightscore = PlayerPrefs.GetInt("hightscore");
        }
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        health= Mathf.Clamp(health, 0, 10);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("tembak");
            Instantiate(spawnPeluru, new Vector3(worldMousePosition.x, -4.5f, 0), quaternion.identity);
        }

        move();        
    }

    public void move()
    {
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //untuk mengatur posisi
        mousePosition = new Vector2(worldMousePosition.x, transform.position.y); //kalau sesuai posisi pakai transform.position
        Vector2 minimum = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Vector2 maximum = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        mousePosition.x = Mathf.Clamp(mousePosition.x, minimum.x, maximum.x);
        mousePosition.y = Mathf.Clamp(mousePosition.y, minimum.y, maximum.y);
        transform.position = mousePosition;
    }
}
