using UnityEngine.InputSystem;
using UnityEngine;
using TMPro;

public class playerShoot : MonoBehaviour
{
    Color hitColor;

    [SerializeField]
    private InputAction reloadKey;

    private int bullets;
    private int maxBullets;

    [SerializeField]
    private TMP_Text bulletText;
    [SerializeField]
    private ParticleSystem shootParticles;

    private void OnEnable()
    {
       reloadKey.Enable();
    }

    private void OnDisable()
    {
       reloadKey.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bullets = 10;
        maxBullets = 25;
        UpdateBulletText();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isPlaying == true)
        {


            if (reloadKey.triggered)
            {
                if (maxBullets > 0)
                {
                    if (maxBullets < 10)
                    {
                        bullets += maxBullets;
                        maxBullets = 0;
                    }
                    else
                    {
                        bullets += 10;
                        maxBullets -= 10;
                    }
                }
                UpdateBulletText();
            }

            if (Mouse.current.leftButton.wasPressedThisFrame && bullets > 0)
            {
                RaycastHit hit;
                bullets--;
                UpdateBulletText();
                if (!shootParticles.isPlaying)
                {
                    shootParticles.Play();
                }
                if (Physics.Raycast(transform.position, transform.forward, out hit))
                {
                    Debug.DrawRay(transform.position, transform.forward * hit.distance, hitColor);
                    //Debug.Break();
                }
            }
        }
    }

    void UpdateBulletText()
    {
        bulletText.text = bullets.ToString() + " / " + maxBullets.ToString();
    }

    public void AddBullets(int value)
    {
        maxBullets += value;
        UpdateBulletText();
    }

    private void FixedUpdate()
    {
    }

}
