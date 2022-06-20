using UnityEngine;

public class CarInputHandler : MonoBehaviour
{

	public CarsMoveParking carMove;

	void Awake()
	{
		carMove = GetComponent<CarsMoveParking>();
	}

	void Update()
	{
		Vector2 inputVector = Vector2.zero;

		inputVector.x = Input.GetAxis("Horizontal");
		inputVector.y = Input.GetAxis("Vertical");

		carMove.SetInputVector(inputVector);
	}
}
