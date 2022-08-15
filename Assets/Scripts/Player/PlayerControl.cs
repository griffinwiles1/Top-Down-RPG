using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float moveSpeed = 5f;
    public float backSpeed = 2f;
    public float strafeSpeed = 3.5f;
    public Rigidbody2D rb;
    public PlayerWeapon weapon;

    Vector2 moveDirection;
    Vector2 mousePosition;

    // Update is called once per frame
    void Update() {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        if (Input.GetMouseButtonDown(0)) {
            weapon.Fire();
        }

        moveDirection = new Vector2(moveX, moveY).normalized;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    //Move towards the mouse on 'W' pressed

    
    private void FixedUpdate() {
        //Rotate Player to where the mouse is pointing
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }
}
