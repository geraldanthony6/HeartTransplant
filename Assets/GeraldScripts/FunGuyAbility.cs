using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunGuyAbility : MonoBehaviour
{
    [SerializeField]private Transform _pivotPoint;
    [SerializeField]private Transform _firePoint;
    [SerializeField]private GameObject _lovingWords;
    private float _attackCooldown;
    private float offset = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - _pivotPoint.position; 
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg; 
        _pivotPoint.rotation = Quaternion.Euler(0f, 0f, rotation_z + offset);

        if(Input.GetKey(KeyCode.Mouse0) && _attackCooldown <= 0){
            SayLovingWords();
        }

        if(_attackCooldown > 0){
            _attackCooldown -= Time.deltaTime;
        }
    }

    private void SayLovingWords(){
        _attackCooldown = 0.2f;
        Instantiate(_lovingWords, _firePoint.position, _firePoint.rotation);
    }
}
