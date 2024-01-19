using UnityEngine;

public class PrefabOlusturucu : MonoBehaviour
{
    public GameObject prefab; // Unity Editörü'nde atayabileceğiniz prefab

    void Start()
    {
        // Belirli aralıklarla Prefab oluşturmak için InvokeRepeating kullanılır.
        InvokeRepeating("OyuncuOlustur", 5f, 5f);
    }

    void OyuncuOlustur()
    {
        // prefab değişkeni null değilse ve atanmışsa bir kopyasını oluştur.
        if (prefab != null)
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("Prefab atanmamış veya null. Lütfen bir prefab atayın.");
        }
    }
}
