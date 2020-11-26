using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PersonalApplication
{
    public class TargetManager : MonoBehaviour
    {
        bool muestraFicha = false;
        float y;
        private void Awake()
        {
            y = transform.position.y;
        }
        private void Update()
        {
            if (muestraFicha == true)
            {
                if (y < 1.3f)
                {
                    y += y + Time.deltaTime;
                }
                transform.position = new Vector3(transform.position.x, y, transform.position.z);
            }
        }

        public void MuestraFicha()
        {
            muestraFicha = true;
        }
    }

}
