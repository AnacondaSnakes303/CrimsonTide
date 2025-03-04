using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public Slider healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(5);
        }
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        healthBar.value = currentHealth / maxHealth;
    }


}
