using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

namespace GDA.Interactibles.UserHitText
{
    public class HitText : MonoBehaviour
    {
        [SerializeField]
        TMP_Text text;

        const float lifetime = 2f;
        float currentTime = 0f;

        Action moveEvent = () => { };

        void Reset()
        {
            if (GetComponentInChildren<TMP_Text>() == null)
                Instantiate(Resources.Load<GameObject>("GUI/DamageText"), transform);
        }

        public void Show(float damage)
        {
            text.enabled = true;
            text.transform.localPosition = Vector3.zero;
            text.text = damage.ToString();
            currentTime = 0f;
        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;

            if (currentTime >= lifetime)
                text.enabled = false;

            float distance = Vector3.Distance(transform.position, Camera.main.transform.position);
            text.transform.localScale = Vector3.one * distance * 0.06f;

            Vector3 upperLimit = Camera.main.transform.up * 2f;

            text.transform.localPosition = Vector3.Lerp(text.transform.localPosition, upperLimit, 40f * Time.deltaTime * text.transform.localScale.y);          

            text.transform.LookAt(Camera.main.transform);
            text.transform.Rotate(Vector3.up * 180);
        }
    }
}