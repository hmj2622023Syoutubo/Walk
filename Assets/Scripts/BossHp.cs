using UnityEngine;

public class BossHP : MonoBehaviour
{
	[SerializeField] int maxHp;  // HP 
	private int currentHp;

	private void Start()
	{
		currentHp = maxHp;
	}


	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			TakeDamage(1);  // ダメージの調整
		}
	}

	private void TakeDamage(int damage)
	{
		currentHp -= damage;
		currentHp = Mathf.Clamp(currentHp, 0, maxHp);

		if(currentHp < 0)
		{
			Die();
		}
	}

	// デスした時の処理
	void Die()
	{
		Debug.Log("Boss is Dead");
	}
}
