using UnityEngine;

public class LiikkuvaEste : MonoBehaviour
{
    public float nopeus = 2.0f; // Esteen nopeus

    private Vector3 alkuPiste;
    private Vector3 loppuPiste;

    void Start()
    {
        alkuPiste = transform.position;
        loppuPiste = new Vector3(alkuPiste.x + 5.0f, alkuPiste.y, alkuPiste.z); // Liikkeen matka
    }

    void Update()
    {
        float vaihe = Mathf.PingPong(Time.time * nopeus, 1.0f);
        transform.position = Vector3.Lerp(alkuPiste, loppuPiste, vaihe);
    }
}