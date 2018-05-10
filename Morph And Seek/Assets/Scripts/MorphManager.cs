using UnityEngine;
public class MorphManager : MonoBehaviour {
    public GameObject playerBody,morphBody;

    public void Morph(GameObject prop)
    {
        if (playerBody.activeInHierarchy)
        {  playerBody.SetActive(false); }
        else
        {  Destroy(morphBody);}
        GameObject newMorphBody;
        newMorphBody = Instantiate(prop, transform.position, Quaternion.identity, transform) as GameObject;
        morphBody = newMorphBody;
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                print("hit a " + hit.transform.name);
                if (hit.transform.CompareTag("Prop"))
                { Morph(hit.transform.GetComponent<PropHolder>().propModel); }
            }
        }
    }
}
