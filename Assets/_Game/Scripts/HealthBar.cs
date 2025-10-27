using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Image imageFill;// them using UnityEngine.UI
    [SerializeField] Vector3 offset;
    float hp;
    float maxHp;
    private Transform target;
    void Update()
    {
        imageFill.fillAmount = Mathf.Lerp(imageFill.fillAmount, hp / maxHp, 5f * Time.deltaTime);// mat mau tu tu
        transform.position = target.position + offset;
    }
    public void OnInit(float maxHp, Transform target)
    {
        this.target = target;
        this.maxHp = maxHp;
        hp = maxHp;
        imageFill.fillAmount = 1;
    }
    public void SetNewHp(float hp)
    {
        this.hp = hp;
    }
}
