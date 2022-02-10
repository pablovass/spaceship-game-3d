
using UnityEngine;

public class SpawnManager : MonoBehaviour
{   
    //coleccion de ...
    public GameObject[] obstaculePrefabs;

    private float startDelay = 2;
    private float repeatRate = 2;
    public int elementIndex;

    private float spawnRangeX = 5;

    private float spawnPosZ;
    // Start is called before the first frame update
    
    void Start()
    {
        spawnPosZ = this.transform.position.z;// esto es mas obtimo
        InvokeRepeating("SpawnObstacule",startDelay,repeatRate);
    }

    void SpawnObstacule()
    {
        GameObject obstaculePrefab = obstaculePrefabs[Random.Range(0, obstaculePrefabs.Length)];
        Instantiate(obstaculePrefab);
    }
    

    // Update is called once per frame
    void Update()
    {
        if (elementIndex>=0&&elementIndex<4)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                //posicion del nuevo objeto obstaculo
                Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);

                Instantiate(obstaculePrefabs[elementIndex], spawnPos,
                    obstaculePrefabs[elementIndex].transform.rotation);
            }
        }
        else
        {
            //elementos que exiten
            Debug.Log("el numero de elementos a instaciar  no exite");
        }
    }
}
