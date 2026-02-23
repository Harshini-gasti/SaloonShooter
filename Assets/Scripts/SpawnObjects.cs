using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject bottle;
    bool spawn;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    private void Update()
    {
        
    }

    IEnumerator SpawnRoutine()
    {
        while(spawn == false)
        {
            yield return new WaitForSeconds(Random.Range(1f,2f));
            GameObject g = Instantiate(bottle, transform.position, transform.rotation);
            g.transform.SetParent(transform);
            yield return new WaitForSeconds(Random.Range(3f, 5f));
            Destroy(g);
        }
    }

}
