using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimiento : MonoBehaviour
{

    public float speed = 10f;
    InputActions inputActions;
    [SerializeField] float limiX = 20f;
    [SerializeField] float limiY = 11f;

    float joyV;
    float joyH;
    

    private void Awake()
    {
        speed = 10f;

        inputActions = new InputActions();
        inputActions.NaveCnt.MoveH.performed += ctx => joyH = ctx.ReadValue<float>();
        inputActions.NaveCnt.MoveV.performed += ctx => joyV = ctx.ReadValue<float>();
        inputActions.NaveCnt.MoveH.canceled += _ => joyH = 0f;
        inputActions.NaveCnt.MoveV.canceled += _ => joyV = 0f;
        inputActions.NaveCnt.Disparar.started += _ => Disparar();
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
        print(speed);
    }

    // Update is called once per frame
    void Update()
    {
        MoverNave();
    }

    void MoverNave()
    {
        //MOVIMIETO HORIZONTAL Y VERTICAL, con respecto al mundo
        float PosX = transform.position.x;
        float PosY = transform.position.y;

        if (PosX > -limiX && PosX < limiX || PosX < -limiX && joyH > 0 || PosX > limiX && joyH < 0)
        {
            transform.Translate(Vector3.right * speed * joyH * Time.deltaTime, Space.World);
        }
        if (PosY > -limiY && PosY < limiY || PosY < -limiY && joyV > 0 || PosY > limiY && joyV < 0)
        {
            transform.Translate(Vector3.up * speed * joyV * Time.deltaTime, Space.World);
        }

        //Hago que rote la nave cuando me desplazo 
        transform.eulerAngles = new Vector3(joyV * -30f , 0f, joyH * -45f );
    }

    void Disparar() {

        print("BUM");
    }
}
