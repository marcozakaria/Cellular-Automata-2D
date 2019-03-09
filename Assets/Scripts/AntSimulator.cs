using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AntSimulator : MonoBehaviour
{
    [Range(0.001f, 1f)]
    public float updateTime = 0.02f;

    public Text itertationsText;
    private int i = 0;

    private WaitForSeconds timeToUpdate;
    private Vector3 rotation;

    private void Start()
    {
        rotation = transform.eulerAngles;
        timeToUpdate = new WaitForSeconds(updateTime);

        StartCoroutine(MoveAnt());
    }

    private void OnValidate()
    {
        timeToUpdate = new WaitForSeconds(updateTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    private IEnumerator MoveAnt()
    {
        while (true)
        {
            if(itertationsText!=null) itertationsText.text = i++.ToString();

            transform.eulerAngles = rotation;
            transform.Translate(Vector3.right);
            yield return timeToUpdate;
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        rotation = transform.eulerAngles;
        if (collision.tag == "left") rotation.z -= 90;
        if (collision.tag == "right") rotation.z += 90;
    }
}
