using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raqueta : MonoBehaviour
{
    [SerializeField] private float velocidad = 15.0f;

    [SerializeField] private string ejeY, ejeX;
    
    [SerializeField] private float xMin, xMax, yMin, yMax; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {

        //Capto el valor del eje vertical de la raqueta
        float y = Input.GetAxisRaw(ejeY);
        float x = Input.GetAxisRaw(ejeX);
        //Modifico la velocidad de la raqueta
        GetComponent<Rigidbody2D>().velocity = new Vector2(x * velocidad, y * velocidad);

        transform.position = new Vector3(
            Mathf.Clamp (transform.position.x, xMin, xMax), 
            Mathf.Clamp (transform.position.y, yMin, yMax),
            transform.position.z
            );

    }
}