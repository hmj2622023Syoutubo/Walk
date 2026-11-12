using UnityEngine;

public class CameraController : MonoBehaviour
{
	[SerializeField] GameObject Player;  // プレイヤー
	private Vector3 offset;  // 相対距離

	void Start()
	{
		// カメラとプレイヤーとの相対距離を求める
		offset = transform.position - Player.transform.position;
	}

    void Update()
    {
		// 新しいトランスフォームの値を代入する
        transform.position = Player.transform.position + offset;
    }
}
