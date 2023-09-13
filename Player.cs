using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField]
    public float speed = 3.5f;
    [SerializeField]
    private GameObject _laserPrefab;

    public float horizontalInput;

    public float verticalInput;
    
    private float _fireRate = 0.5f;

    private float _canFire = -1f;




    
    
 void Start() 
    {     
    transform.position = new Vector3(0, 0, 0);
  
    }
        
    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.Space) && Time.time > _canFire)
     {
      _canFire = Time.time + _fireRate;
      Instantiate(_laserPrefab, transform.position + new Vector3(0, 0.8f, 0), Quaternion.identity);


     }




    



    
      float horizontalInput = Input.GetAxis("Horizontal");

      float verticalInput = Input.GetAxis("Vertical");
    
     Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

     transform.Translate(direction * speed * Time.deltaTime);

     transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

     transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);

     if(transform.position.y >= 0)
     {
      transform.position = new Vector3(transform.position.x, 0, 0);
     }


     

     else if(transform.position.y <= -3.8f)
     {
      transform.position = new Vector3(transform.position.x, -3.8f, 0);
     }

     if(transform.position.x <= -11.318f)
    {
      transform.position = new Vector3(11.33434f, transform.position.y, 0);
    }
     
    else if(transform.position.x >= 11.33434f)
    {
      transform.position = new Vector3(-11.318f, transform.position.y, 0);
    }
     


    


    }
}
