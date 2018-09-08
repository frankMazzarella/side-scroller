using UnityEngine;

public class Movement: MonoBehaviour {
    public Rigidbody rigidbody;

	void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(0, 3500, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = rigidbody.transform.position;
            position.x += 3.5f * Time.deltaTime;
            rigidbody.transform.position = position;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = rigidbody.transform.position;
            position.x -= 3f * Time.deltaTime;
            rigidbody.transform.position = position;
        }
    }
}
