using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGO : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit res;
            if (Physics.Raycast(ray, out res))
            {
                StartCoroutine(HighlightGO(res.collider.gameObject));
            }
        }
    }

    IEnumerator HighlightGO(GameObject highlighter)
    {
        if (highlighter.GetComponent<MeshRenderer>() == null) yield break;
        Color original = highlighter.GetComponent<MeshRenderer>().material.color;
        highlighter.GetComponent<MeshRenderer>().material.color = Color.white;
        yield return new WaitForSeconds(3);
        highlighter.GetComponent<MeshRenderer>().material.color = original;
    }
}
