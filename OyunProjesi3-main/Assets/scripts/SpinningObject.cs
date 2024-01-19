using UnityEngine;

public class SpinningObject : MonoBehaviour
{
    public float donmeHizi = 10f; // D�nme h�z�
    public Transform player; // Takip edilecek player objesi

    void Update()
    {
        // Player objesinin varl���n� kontrol et
        if (player != null)
        {
            // Player objesinin konumunu takip etme
            transform.position = player.position;

            // Yatay eksende s�rekli d�nd�rme
            transform.Rotate(Vector3.up, donmeHizi * Time.deltaTime);
        }
        else
        {
            Debug.LogError("Player referans� atanmam��!");
        }
    }
}
