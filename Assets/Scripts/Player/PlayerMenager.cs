using UnityEngine;

public class PlayerMenager : MonoBehaviour
{
    public float protectTime = 3;
    public bool isProtect;
    public new MeshRenderer renderer;
    private Color defaultColor;

    // Start is called before the first frame update
    void Start()
    {
      
        isProtect = true;
        defaultColor = renderer.material.color;
        renderer.material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (protectTime > 0)
        {
            protectTime -= Time.deltaTime;
        } 
        else if(isProtect)
        {
            isProtect = false;
            renderer.material.color = defaultColor;
        }
    }
}
