using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] livingObject;
    private int _spawnerQuant = 0;
    public int _planteQuant;
    
    



    void Start()
    {
        while (_spawnerQuant < 101)
        {
            _spawnerQuant = (_spawnerQuant + 1);
            int randomIndexObject = Random.Range(0, livingObject.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-200, 201), 5, (Random.Range(-200, 201)));
            Instantiate(livingObject[randomIndexObject], randomSpawnPosition, Quaternion.identity);

        }


    }


    private void Update()
    {
        
        _planteQuant = GameObject.FindGameObjectsWithTag("plante.prefab").Length; //je ne trouve pas les plantes
        
        
        while (_planteQuant < 30) 
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-200, 201), 5, (Random.Range(-200, 201))); 
            Instantiate(livingObject[2], randomSpawnPosition, Quaternion.identity);
        }
        
       
    }

}
