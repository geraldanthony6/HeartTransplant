using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogTrainer : MonoBehaviour
{
    [SerializeField]private Transform _pivotPoint;
    [SerializeField]private Transform _firePoint;
    [SerializeField]private Transform _dog1Position;
    [SerializeField]private Transform _dog2Position;
    [SerializeField]private GameObject bonePrefab;
    [SerializeField]private GameObject dogPrefab;
    [SerializeField]private GameObject[] dogs;
    [SerializeField]private GameObject dog1Target;
    [SerializeField]private GameObject dog2Target;
    [SerializeField]private bool dogOneAvailable = true;
    [SerializeField]private bool dogTwoAvailable = true;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject dog1 = Instantiate(dogPrefab, _dog1Position.position, Quaternion.identity);
        dogs[0] = dog1;
        dog1.transform.parent = gameObject.transform;
        GameObject dog2 = Instantiate(dogPrefab, _dog2Position.position, Quaternion.identity);
        dogs[1] = dog2;        
        dog2.transform.parent = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - _pivotPoint.position; 
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg; 
        _pivotPoint.rotation = Quaternion.Euler(0f, 0f, rotation_z);

        if(Input.GetKeyDown(KeyCode.Mouse0)){
            Instantiate(bonePrefab, _firePoint.position, _firePoint.rotation);
        }

        if(!dogOneAvailable && dog1Target){
            AttackDog(0); 
        }

        if(!dogTwoAvailable && dog2Target){
            AttackDog(1);
        }

        if(!dog1Target && !dogOneAvailable){
            dogs[0].transform.position = Vector2.MoveTowards(dogs[0].transform.position, _dog1Position.position, 150 * Time.deltaTime);
            if(Vector3.Distance(dogs[0].transform.position, _dog1Position.position) < 5){
                dogOneAvailable = true;
            }
        }

        if(!dog2Target && !dogTwoAvailable){
            dogs[1].transform.position = Vector2.MoveTowards(dogs[1].transform.position, _dog2Position.position, 150 * Time.deltaTime);
            if(Vector3.Distance(dogs[1].transform.position, _dog2Position.position) < 5){
                dogTwoAvailable = true;
            }
        }
    }

    public bool getDogOneAvailable(){
        return dogOneAvailable;
    }

    public bool getDogTwoAvailable(){
        return dogTwoAvailable;
    }

    public Transform getDog1Pos(){
        return _dog1Position;
    }

    public void SetDogOneAvailable(bool availability){
        dogOneAvailable = availability;
    }

    public void SetDogTwoAvailable(bool availability){
        dogTwoAvailable = availability;
    }

    public void SetDog1Target(GameObject target){
        dog1Target = target;
    }

    public void SetDog2Target(GameObject target){
        dog2Target = target;
    }

    private void AttackDog(int index){
        if(index == 0){
            dogs[index].transform.parent = null;
            dogs[index].transform.position = Vector2.MoveTowards(dogs[index].transform.position, dog1Target.transform.position, 150 * Time.deltaTime);
        }  

        if(index == 1){
           dogs[index].transform.parent = null;
            dogs[index].transform.position = Vector2.MoveTowards(dogs[index].transform.position, dog2Target.transform.position, 150 * Time.deltaTime);
        } 
    }
}
