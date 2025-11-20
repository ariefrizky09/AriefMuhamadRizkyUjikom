using UnityEngine;

public class musuhA : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter2D(Collision2D col)
    {
        //Tidak hancur bila menyentuh pemain
        if (col.collider.CompareTag("karakter"))
        {
            
        }

        //Tidak hancur bila menyentuh objek lain selain lantai
        if (!col.collider.CompareTag("batas"))
        {
            col.gameObject.GetComponent<objKarakter>().KurangNyawa();
        }

        //HANCUR hanya ketika menyentuh lantai
                Destroy(gameObject);
    }
}
