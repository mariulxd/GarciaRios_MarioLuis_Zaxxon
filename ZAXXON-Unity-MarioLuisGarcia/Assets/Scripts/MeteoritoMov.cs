using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoritoMov : MonoBehaviour
{
    [SerializeField] Movimiento nave;
    [SerializeField] GameObject Nave;
    float metspeed;
    float multSpeed = 3f;
    Vector3 despl = Vector3.back;
    float rotanX = ;
    float rotanY = ;
    
    // Start is called before the first frame update
    void Start()
    {
        Nave = GameObject.Find("Nave");
        nave = Nave.GetComponent<Movimiento>();
    }

    // Update is called once per frame
    void Update()
    {
        MeteorWork();
    }

    void MeteorWork() 
    {
        metspeed = nave.speed * multSpeed;
        transform.Translate(despl * metspeed * Time.deltaTime, Space.World);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x + rotanX, transform.eulerAngles.y + rotanY, transform.eulerAngles.z);
        if (transform.position.z < -25)
        {
            Destroy(this.gameObject);
        }
    }
}
