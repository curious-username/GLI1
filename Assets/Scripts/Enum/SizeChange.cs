using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChange : MonoBehaviour
{

    private enum ChangeSize
    {
        Grow,
        Shrink,
        Reset
    }

    private void Update()
    {
        InputController();
        
    }

    private void InputController()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            SizeController(ChangeSize.Grow);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            SizeController(ChangeSize.Shrink);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            SizeController(ChangeSize.Reset);
        }

    }
    private void SizeController(ChangeSize val)
    {
        switch ((int)val)
        {
            case 0:
                transform.localScale += new Vector3(0.05f, 0.05f, 0.05f) * Time.deltaTime * 15.0f;
                break;
            case 1:
                if(transform.localScale.x < 0.01)
                {
                    transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                }
                transform.localScale -= new Vector3(0.05f, 0.05f, 0.05f) * Time.deltaTime * 15.0f;
                break;
            case 2:
                transform.localScale = Vector3.one;
                break;
        }
    }


    

}
