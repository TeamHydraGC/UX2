using UnityEngine;
using UnityEngine.UI;

public class Abilities : MonoBehaviour
{

    [Header("Ability 1")]
    public Image AB1CD;
    public float cd1 = 0.5f;
    bool isOnCooldown = false;
    public KeyCode ability1;

    [Header("Ability 2")]
    public Image AB2CD;
    public float cd2 = 6f;
    bool is2OnCooldown = false;
    public KeyCode ability2;

    [Header("Ability 3")]
    public Image AB3CD;
    public float cd3 = 5f;
    bool is3OnCooldown = false;
    public KeyCode ability3;

    [Header("Ability 4")]
    public Image AB4CD;
    public float cd4 = 6f;
    bool is4OnCooldown = false;
    public KeyCode ability4;

    void Start()
    {
        AB1CD.fillAmount = 0;
        AB2CD.fillAmount = 0;
        AB3CD.fillAmount = 0;
        AB4CD.fillAmount = 0;
    }

    void Update()
    {
        Ability1();
        Ability2();
        Ability3();
        Ability4();
    }

    void Ability1()
    {
        if (Input.GetKey(ability1) && isOnCooldown == false)
        {
            isOnCooldown = true;
            AB1CD.fillAmount = 1;
        }

        if (isOnCooldown)
        {
            AB1CD.fillAmount -= 1 / cd1 * Time.deltaTime;

            if (AB1CD.fillAmount <= 0)
            {
                AB1CD.fillAmount = 0;
                isOnCooldown = false;
            }
        }
    }
    void Ability2()
    {
        if (Input.GetKey(ability2) && is2OnCooldown == false)
        {
            is2OnCooldown = true;
            AB2CD.fillAmount = 1;
        }

        if (is2OnCooldown)
        {
            AB2CD.fillAmount -= 1 / cd2 * Time.deltaTime;

            if (AB2CD.fillAmount <= 0)
            {
                AB2CD.fillAmount = 0;
                is2OnCooldown = false;
            }
        }
    }
    void Ability3()
    {
        if (Input.GetKey(ability3) && is3OnCooldown == false)
        {
            is3OnCooldown = true;
            AB3CD.fillAmount = 1;
        }

        if (is3OnCooldown)
        {
            AB3CD.fillAmount -= 1 / cd3 * Time.deltaTime;

            if (AB3CD.fillAmount <= 0)
            {
                AB3CD.fillAmount = 0;
                is3OnCooldown = false;
            }
        }
    }
    void Ability4()
    {
        if (Input.GetKey(ability4) && is4OnCooldown == false)
        {
            is4OnCooldown = true;
            AB4CD.fillAmount = 1;
        }

        if (is4OnCooldown)
        {
            AB4CD.fillAmount -= 1 / cd4 * Time.deltaTime;

            if (AB4CD.fillAmount <= 0)
            {
                AB4CD.fillAmount = 0;
                is4OnCooldown = false;
            }
        }
    }
}


