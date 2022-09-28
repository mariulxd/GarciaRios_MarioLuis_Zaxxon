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

    //Para rotar la camara
    [SerializeField] InputActions inputActions;
    [SerializeField] float rotX;
    //max 17
    [SerializeField] float rotY;
    //maz 27
    [SerializeField] Vector3 rotCam;




    private void Awake()
    {
        inputActions = new InputActions();

        inputActions.CamCnt.RotX.performed += ctx => rotX = ctx.ReadValue<float>();
        inputActions.CamCnt.RotY.performed += ctx => rotY = ctx.ReadValue<float>();
        inputActions.CamCnt.RotX.canceled += _ => rotX = 0f;
        inputActions.CamCnt.RotY.canceled += _ => rotY = 0f;


    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

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
        rotCam = new Vector3(-rotY * 17, rotX * 27, 0f);
        //transform.eulerAngles = Vector3.SmoothDamp(rotCam, targetPosition, ref camVel, smoothVel);
    }



  
}
