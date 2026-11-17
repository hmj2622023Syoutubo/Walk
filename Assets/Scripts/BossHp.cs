using UnityEngine;

public class BossHP : MonoBehaviour
{
	[SerializeField] int maxHp;  // HP
	[SerializeField] int attackPower;  // 攻撃力
	[SerializeField] int defensePower; 
	int currentHp;

	private void Start()
	{
		currentHp = maxHp;
	}

	// ボスのステイタス
	void TakeDamage(int damage)
	{
		int damageToTake = Mathf.Max(0, damage - defensePower);
		currentHp -= damageToTake;
		if(currentHp <= 0)
		{
			currentHp = 0;
			Die();
		}
	}


	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			TakeDamage(10);  // ダメージの調整
		}
	}

	// デスした時の処理
	void Die()
	{
		Debug.Log("Boss is Dead");
	}
}
