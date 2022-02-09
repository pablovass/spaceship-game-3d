using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private float rotation;

    private Rigidbody _rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.angularVelocity = Random.insideUnitSphere * rotation;
        // Update is called once per frame
    }

    void Update()
    {
        
    }
}
