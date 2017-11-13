using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public Transform player;
    [SerializeField]
    private float speed = 10f;

    void OnMouseDrag() {

        if(!Player.lose) {
        Vector3 MousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        MousePos.x = MousePos.x > 2.6 ? 2.6f : MousePos.x;
        MousePos.x = MousePos.x < -2.6 ? -2.6f : MousePos.x;
        player.position = Vector2.MoveTowards (player.position, new Vector2(MousePos.x, player.position.y), speed * Time.deltaTime);
        }
    }
}
