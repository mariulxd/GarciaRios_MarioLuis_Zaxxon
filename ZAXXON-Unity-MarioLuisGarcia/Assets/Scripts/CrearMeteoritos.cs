using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearMeteoritos : MonoBehaviour
{
    [SerializeField] GameObject asteroides;
    [SerializeField] Transform refPos;
     float randomRangeH = 20f;
     float randomRangeV = 11f;
     float randomScaleMAX = 3f;
     float tiempoSpawn = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("MeteorCorrutine");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void CrearObstaculo()
    {
        float randomRangeX = Random.Range(-randomRangeH, randomRangeH);
        float randomRangeY = Random.Range(-randomRangeV, randomRangeV);
        float randomScale = Random.Range(1f, randomScaleMAX);
        Vector3 randomPos = new Vector3(randomRangeX, randomRangeY, refPos.position.z);
        GameObject newObject = Instantiate(asteroides, randomPos, Quaternion.identity) as GameObject;
        newObject.transform.localScale= new Vector3(randomScale, randomScale, randomScale);
    }

    IEnumerator MeteorCorrutine()
    {
        for (int n = 0; ; n++)
        {
            CrearObstaculo();
            yield return new WaitForSeconds(tiempoSpawn);
        }
    }


}
