using UnityEngine;

public class SpinningObject : MonoBehaviour
{
    public float donmeHizi = 10f; // Dönme hýzý
    public Transform player; // Takip edilecek player objesi

    void Update()
    {
        // Player objesinin varlýðýný kontrol et
        if (player != null)
        {
            // Player objesinin konumunu takip etme
            transform.position = player.position;

            // Yatay eksende sürekli döndürme
            transform.Rotate(Vector3.up, donmeHizi * Time.deltaTime);
        }
        else
        {
            Debug.LogError("Player referansý atanmamýþ!");
        }
    }
}
