using UnityEngine;

public class Ground : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Vector2 offset;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        float speed = GameManager.Instance.gameSpeed / transform.localScale.x;
        offset += Vector2.right * speed * Time.deltaTime;
        meshRenderer.material.mainTextureOffset = offset;
    }
}
