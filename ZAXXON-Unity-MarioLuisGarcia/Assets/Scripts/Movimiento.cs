using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimiento : MonoBehaviour
{

    public float speedDespl = 10f;
    InputActions inputActions;
    
    
    float joyV;
    float joyH;
    
    float rotation;

    bool inlimi;

    private void Awake()
    {
        speedDespl = 10f;
        inputActions = new InputActions();

        inputActions.NaveCnt.MoveH.performed += ctx => joyH = ctx.ReadValue<float>();
        inputActions.NaveCnt.MoveV.performed += ctx => joyV = ctx.ReadValue<float>();
        inputActions.NaveCnt.MoveH.canceled += _ => joyH = 0f;
        inputActions.NaveCnt.MoveV.canceled += _ => joyV = 0f;

        inputActions.NaveCnt.Disparar.started += _ => Disparar();
        //inputActions.Player.Disparar.canceled += _ => 

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
        print(speedDespl);
    }

    // Update is called once per frame
    void Update()
    {
        MoverNave();
        //Disparar();

    }

    void MoverNave()
    {

        //MOVIMIETO HORIZONTAL Y VERTICAL, con respecto al mundo

        float PosX = transform.position.x;
        float PosY = transform.position.y;
        float limiX = 11f;
        float limiY = 6f;

        /*
        if (PosY <= limiY || joyV > 0)
        {
            inlimi = false;
        }
        else if (PosY >= -limiY)
        {
            inlimi = false;
        }
        else { inlimi = true; }
        */
        
        if (PosX > -limiX && PosX < limiX || PosX < -limiX && joyH > 0 || PosX > limiX && joyH < 0)
        {
            transform.Translate(Vector3.right * speedDespl * joyH * Time.deltaTime, Space.World);
        }
        if (PosY > -limiY && PosY < limiY || PosY < -limiY && joyV > 0 || PosY > limiY && joyV < 0)
        {
            transform.Translate(Vector3.up * speedDespl * joyV * Time.deltaTime, Space.World);
        }

       

        //Hago que rote la nave cuando me desplazo 
        transform.eulerAngles = new Vector3(joyV * -30f , 0f, joyH * -45f );

        
    }
    void Disparar() {

        print("BUM");
    }
}
