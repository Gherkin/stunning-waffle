using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour {
    public Transform transform;
    private float i = 0.002f;

    private Vector2 speed = new Vector2(0,0);
    // Start is called before the first frame update
    void Start() {
        // transform
    }

    // Update is called once per frame
    async void Update() {
        
        var oldx = transform.position.x;
        var oldy = transform.position.y;
        transform.position = new Vector3(oldx + speed.x * i, oldy + speed.y * i, 0);
    }
    
    public void onMove(InputAction.CallbackContext context) {
        var dir = context.ReadValue<Vector2>();
        speed = dir;

    }

    void OnCollisionEnter2D(Collision2D collisionInfo) {
        print("apa");
    }

    private void onClick() {
        print("apa");
    }
}
