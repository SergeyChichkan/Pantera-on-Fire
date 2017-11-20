using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public Transform player;
    [SerializeField]
    private float speed = 10f;

    void OnMouseDrag() {

        //if (!Player.lose)
        //{
        //    Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    MousePos.x = MousePos.x > Screen.height*0.9f ? Screen.height*0.9f : MousePos.x;
        //    MousePos.x = MousePos.x < Screen.height - (Screen.height*1.1f) ? Screen.height - (Screen.height*1.1f) : MousePos.x;
        //    player.position = Vector2.MoveTowards(player.position, new Vector2(MousePos.x, player.position.y), speed * Time.deltaTime);
        //    Debug.Log(Screen.width);
        //    Debug.Log(Screen.height);
        //}

        //if(!Player.lose) {
        //    Vector3 MousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        //    MousePos.x = MousePos.x > Camera.main.pixelWidth ? Screen.width - 20f : MousePos.x;
        //    MousePos.x = MousePos.x < 0 ? 20 : MousePos.x;
        //    player.position = Vector2.MoveTowards (player.position, new Vector2(MousePos.x, player.position.y), speed * Time.deltaTime);
        //    Debug.Log(Camera.main.pixelWidth);
        //}

        if (!Player.lose)
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
            MousePos.x = MousePos.x > 2.25f ? 2.25f : MousePos.x;
            MousePos.x = MousePos.x < -2.25f ? -2.25f : MousePos.x;
            player.position = Vector2.MoveTowards(player.position, new Vector2(MousePos.x, player.position.y), speed * Time.deltaTime);
            Debug.Log(Screen.height);
        }
        
    }
}
