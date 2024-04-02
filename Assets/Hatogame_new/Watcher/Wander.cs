using UnityEngine;

public class Wander : MonoBehaviour
{
    public float wanderRadius; // Bán kính vòng tròn đi lang thang
    public float wanderDistance; // Khoảng cách tối đa mà đối tượng có thể đi xa khỏi vị trí hiện tại
    public float wanderJitter; // Biến sự biến đổi của vị trí đi lang thang

    private Vector3 startPosition;
    private Vector3 wanderTarget;

    void Start()
    {
        startPosition = transform.position;
        GetNewWanderTarget();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, wanderTarget) <= 1f)
        {
            GetNewWanderTarget();
        }

        // Di chuyển đến vị trí đích
        transform.position = Vector3.MoveTowards(transform.position, wanderTarget, Time.deltaTime * 3f);
    }

    void GetNewWanderTarget()
    {
        Vector3 wanderOffset = Random.insideUnitCircle * wanderRadius;
        wanderOffset += new Vector3(0, 0, wanderDistance);
        wanderOffset = Quaternion.Euler(0, Random.Range(0, 360), 0) * wanderOffset;

        Vector3 targetPosition = startPosition + wanderOffset;
        wanderTarget = new Vector3(targetPosition.x, transform.position.y, targetPosition.z);
    }
}
