using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pachinko : MonoBehaviour
{
    [SerializeField] private GameObject _PachinkoBall;
    // Start is called before the first frame update
    [SerializeField] private GameObject[] _Spinners;
    void Start()
    {
        for(int i = 0; i <100; i++)
        {

            GameObject.Instantiate(_PachinkoBall, new Vector3(Random.Range(-4.4f, 4.4f), 4.5f, 0), Quaternion.identity);
        }
        StartCoroutine(Spinner());
    }

    private IEnumerator Spinner()
    {
        while(true){
            foreach(GameObject spinner in _Spinners)
            {
                spinner.GetComponent<Rigidbody2D>().AddTorque(5f);
            }
            
            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
