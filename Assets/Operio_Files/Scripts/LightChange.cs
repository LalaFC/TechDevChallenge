using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using DG.Tweening;
using Unity.VisualScripting;

public class LightChange : MonoBehaviour
{
    public GameObject Light1, Light2, Light3;
    private Color color1,color2, color3;

    private void Start()
    {
        color1 = Light1.GetComponent<Light>().color;
        color2 = Light2.GetComponent<Light>().color;
        color3 = Light3.GetComponent<Light>().color;
        AlarmLight();
    }
    void Update()
    {
        if (Input.GetKey("space"))
        {
            AlarmLight();
        }
    }
    private Color value;
    public void AlarmLight()
    {
        DG.Tweening.Sequence seq = DOTween.Sequence();
        seq.Append(DOVirtual.Color(color1, Color.red, 1, value =>
        {
            Light1.GetComponent<Light>().color = value;
        }));
        seq.Join(DOVirtual.Color(color2, Color.red, 1, value =>
        {
            Light2.GetComponent<Light>().color = value;
        }));
        seq.Join(DOVirtual.Color(color3, Color.red, 1, value =>
        {
            Light3.GetComponent<Light>().color = value;
        }));

        seq.AppendInterval(0.2f);

        seq.Append(DOVirtual.Color(Color.red,color1, 1, value =>
        {
            Light1.GetComponent<Light>().color = value;
        }));
        seq.Join(DOVirtual.Color(Color.red, color2, 1, value =>
        {
            Light2.GetComponent<Light>().color = value;
        }));
        seq.Join(DOVirtual.Color(Color.red, color3, 1, value =>
        {
            Light3.GetComponent<Light>().color = value;
        }));

        seq.AppendInterval(0.15f);

        seq.Append(DOVirtual.Color(color1, Color.red, 1, value =>
        {
            Light1.GetComponent<Light>().color = value;
        }));
        seq.Join(DOVirtual.Color(color2, Color.red, 1, value =>
        {
            Light2.GetComponent<Light>().color = value;
        }));
        seq.Join(DOVirtual.Color(color3, Color.red, 1, value =>
        {
            Light3.GetComponent<Light>().color = value;
        }));

        seq.AppendInterval(0.15f);

        seq.Append(DOVirtual.Color(Color.red, color1, 1, value =>
        {
            Light1.GetComponent<Light>().color = value;
        }));
        seq.Join(DOVirtual.Color(Color.red, color2, 1, value =>
        {
            Light2.GetComponent<Light>().color = value;
        }));
        seq.Join(DOVirtual.Color(Color.red, color3, 1, value =>
        {
            Light3.GetComponent<Light>().color = value;
        }));

        seq.AppendInterval(0.1f);

        seq.Append(DOVirtual.Color(color1, Color.red, 1, value =>
        {
            Light1.GetComponent<Light>().color = value;
        }));
        seq.Join(DOVirtual.Color(color2, Color.red, 1, value =>
        {
            Light2.GetComponent<Light>().color = value;
        }));
        seq.Join(DOVirtual.Color(color3, Color.red, 1, value =>
        {
            Light3.GetComponent<Light>().color = value;
        }));

        seq.AppendInterval(0.1f);

        seq.Append(DOVirtual.Color(Color.red, color1, 1, value =>
        {
            Light1.GetComponent<Light>().color = value;
        }));
        seq.Join(DOVirtual.Color(Color.red, color2, 1, value =>
        {
            Light2.GetComponent<Light>().color = value;
        }));
        seq.Join(DOVirtual.Color(Color.red, color3, 1, value =>
        {
            Light3.GetComponent<Light>().color = value;
        }));

    }
}
