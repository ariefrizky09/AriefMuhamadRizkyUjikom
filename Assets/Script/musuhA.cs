using UnityEngine;

public class musuhA : MonoBehaviour
{
    public nyawa health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject _nyawa = GameObject.FindGameObjectWithTag("nyawa");
        health = _nyawa.GetComponent<nyawa>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("batas"))
        {
            health.KurangNyawa();
            health.updateNyawa();
            Destroy(gameObject);
        }

        if (col.collider.CompareTag("peluru"))
        {
            Destroy(gameObject);
        }
    }
}
