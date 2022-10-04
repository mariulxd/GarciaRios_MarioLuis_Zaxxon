using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject nave;
    [SerializeField] Transform posNav;
    [SerializeField] float offsetZ;
    [SerializeField] float offsetY;

    //Variables para el suavizado
    [SerializeField] float smoothVel = 0.2f;
    [SerializeField] Vector3 camVel = Vector3.zero;

  

    // Start is called before the first frame update
    void Start()
    {
        offsetZ = 0;
        offsetY = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        posNav = nave.GetComponent<Transform>();
        Vector3 targetPosition = new Vector3(posNav.position.x, posNav.position.y + offsetY, transform.position.z + offsetZ);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camVel, smoothVel);
       
    }



  
}
