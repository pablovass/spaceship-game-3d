using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;
    public GameObject asteroid;
    public Vector3 spawnValues;
    public int hazartCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public float fireRate;
    public float nextFire;

    public float xMin, xMax, zMin, zMax;
    public Transform shotContent;
    public int asteroidCount;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        //instaciamos creacion de asteroides 
        //StartCoroutine(createAsteroids());
        StartCoroutine(SpawnWaves());
    }

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotContent.position, shotContent.rotation);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 vector = new Vector3(horizontal, 5f, vertical);
        _rigidbody.velocity = vector * 10;

        _rigidbody.position = new Vector3(Mathf.Clamp(_rigidbody.position.x, xMin, xMax), 6.0f,
            Mathf.Clamp(_rigidbody.position.z, zMin, zMax));
        _rigidbody.rotation = Quaternion.Euler(0.0f, 0.0f, _rigidbody.velocity.x * -2);
    }

    

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazartCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x.));
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(asteroid, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);

            }

            yield return new WaitForSeconds(waveWait);
        }

    }

}