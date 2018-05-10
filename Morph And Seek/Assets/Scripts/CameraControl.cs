using UnityEngine;

public class CameraControl : MonoBehaviour {
    public Vector3 camPOS;
    public GameObject player;
	// Use this for initialization
	void Start () {
        //check if the local player
        SetPlayer();
        transform.SetParent(player.transform);
	}
    void SetPlayer()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        SetPOV();
    }
    void SetPOV()
    {
        transform.position = player.transform.position + camPOS;
    }
}
