
using UnityEngine;

public class SpawnManager : MonoBehaviour
{   
    //coleccion de ...
    public GameObject[] obstaculePrefabs;

    [SerializeField]private float startDelay = 2;
    [SerializeField]private float spawnInterval = 1.5f;
    public int elementIndex;
    private float spawnRangeX = 5;
    private float spawnPosZ;
    // Start is called before the first frame update
    
    void Start()
    {
        spawnPosZ = this.transform.position.z;// esto es mas obtimo
        InvokeRepeating("SpawnRandomObstacule",startDelay,spawnInterval);
    }

    void SpawnRandomObstacule()
    {
            //posicion del nuevo objeto obstaculo
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
            Instantiate(obstaculePrefabs[elementIndex], spawnPos, 
                obstaculePrefabs[elementIndex].transform.rotation);
        
        
    }    
    

            
        
    
    
}
