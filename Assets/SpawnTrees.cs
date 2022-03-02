using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrees : MonoBehaviour {
    public GameObject obj;
    // Start is called before the first frame update
    async void Start() {
        for(int i = 0; i < 100000; i++) {
            Instantiate(obj, new Vector2(Random.Range(-5f, 5f),Random.Range(-5f, 5f)), obj.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
