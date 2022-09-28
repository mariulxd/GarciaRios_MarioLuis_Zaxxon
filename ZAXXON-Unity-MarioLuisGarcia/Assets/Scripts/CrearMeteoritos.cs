using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearMeteoritos : MonoBehaviour
{
    public GameObject[] Asteroides;
    private Transform RefPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CrearObstaculo()
    {
        int r = Random.Range(0, Asteroides.Length);
        float posRandom = Random.Range(-20f, 20f);
        float randomY = Random.Range(-20f, 20f);
        Vector3 DestPos = new Vector3(posRandom, randomY, 0);
        Vector3 NewPos = RefPos.position + DestPos;
        Instantiate(Asteroides[r], NewPos, Quaternion.identity);
    }
}
