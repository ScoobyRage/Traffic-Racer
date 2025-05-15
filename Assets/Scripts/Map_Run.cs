using UnityEngine;

public class Map_Run : MonoBehaviour
{
    Vector3 originalPosition;
    private float force = 20f; // Initial Backward Movement Speed of the Base
    private float extended_force = 10f; // Extra Backward Movement Speed of the Base
    private float rforce = 40f;
    void Start()
    {
        originalPosition = transform.position;      
    }
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -force) * Time.deltaTime);//Forward Movement
        force += 1 / 10000;
        Debug.Log("Count:" + force);
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.RightArrow))//Forward Movement++
        {
            transform.Translate(new Vector3(0, 0, -extended_force) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))//Left Movement
        {
            transform.Translate(new Vector3(-rforce, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))//Right Movement
        {
            transform.Translate(new Vector3(rforce, 0, 0) * Time.deltaTime);
        }
        

        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.RightArrow))//Left Movement with speed
        {
            transform.Translate(new Vector3(-rforce, 0, -extended_force) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.RightArrow))//Left Movement with speed
        {
            transform.Translate(new Vector3(rforce, 0, -extended_force) * Time.deltaTime);
        }        
    }
}