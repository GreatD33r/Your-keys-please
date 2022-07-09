using UnityEngine;
using System;


public class CarsMoveParking : MonoBehaviour
{
	[Header("Settings")]
	public float driftFactor = 0.95f;
	public float accelerationFactor = 30.0f;
	public float turnFactor = 3.5f;
	public float maxSpeed = 20;

	private bool firstpoint = false;
	private bool twicepoint = false;

	float accelerationInput = 0;
	float steeringInput = 0;
	float rotationAngle = 0;

	float velocityVsUp = 0;
	public Rigidbody2D carRigidbody;
	public static Action wasParked;
	private Transform carTransform;

	void Awake()
	{
		carRigidbody = GetComponent<Rigidbody2D>();
		carTransform = GetComponent<Transform>();
	}

    private void Update()
    {

		if (firstpoint && twicepoint && Input.GetKeyDown(KeyCode.F))
        {
			wasParked?.Invoke();
			firstpoint = false;
			twicepoint = false;
			var CarInput = gameObject.GetComponent<CarInputHandler>();
			CarInput.enabled = false;

		}
		
	}


    void FixedUpdate()
	{
		ApplyEngineForce();

		KillOrthogonalVelocity();

		ApplySteering();
	}

	void ApplyEngineForce()
	{
		velocityVsUp = Vector2.Dot(transform.up, carRigidbody.velocity);

		if (velocityVsUp >= maxSpeed && accelerationInput > 0)
			return;

		if (velocityVsUp < -maxSpeed * 0.5f && accelerationInput < 0)
			return;

		if (carRigidbody.velocity.sqrMagnitude > maxSpeed * maxSpeed && accelerationInput > 0)
			return;


		if (accelerationInput == 0)
			carRigidbody.drag = Mathf.Lerp(carRigidbody.drag, 3.0f, Time.fixedDeltaTime * 3);
		else carRigidbody.drag = 0;

		Vector2 engineForceVector = transform.up * accelerationInput * accelerationFactor;

		carRigidbody.AddForce(engineForceVector, ForceMode2D.Force);
	}

	void ApplySteering()
	{
		float minSpeedBeforeAllowTurningFactor = (carRigidbody.velocity.magnitude / 8);
		minSpeedBeforeAllowTurningFactor = Mathf.Clamp01(minSpeedBeforeAllowTurningFactor);

		rotationAngle -= steeringInput * turnFactor * minSpeedBeforeAllowTurningFactor;

		carRigidbody.MoveRotation(rotationAngle);
	}

	public float GetVelocityMagnitude()
	{
		return carRigidbody.velocity.magnitude;
	}

	void KillOrthogonalVelocity()
	{
		Vector2 forwardVelocity = transform.up * Vector2.Dot(carRigidbody.velocity, transform.up);
		Vector2 rightVelocity = transform.right * Vector2.Dot(carRigidbody.velocity, transform.right);

		carRigidbody.velocity = forwardVelocity + rightVelocity * driftFactor;
	}

	float GetLateralVelocity()
	{
		return Vector2.Dot(transform.right, carRigidbody.velocity);
	}

	public bool IsTireScreeching(out float lateralVelocity, out bool isBraking)
	{
		lateralVelocity = GetLateralVelocity();
		isBraking = false;

		if (accelerationInput < 0 && velocityVsUp > 0)
		{
			isBraking = true;
			return true;
		}

		if (Mathf.Abs(GetLateralVelocity()) > 4.0f)
			return true;

		return false;
	}

	public void SetInputVector(Vector2 inputVector)
	{
		inputVector.x = Mathf.Clamp(inputVector.x, -1.0f, 1.0f);
		inputVector.y = Mathf.Clamp(inputVector.y, -1.0f, 1.0f);

		steeringInput = inputVector.x;
		accelerationInput = inputVector.y;
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ParkPoint1"))
        {
			firstpoint = true;
        }

		if (collision.CompareTag("ParkPoint2"))
        {
			twicepoint = true;
        }
	}

    /*private void OnTriggerExit2D(Collider2D collision)
    {
		if (collision.CompareTag("VerticalParkPoint1"))
		{
			verticalfirstpoint = false;
		}
		else if (collision.CompareTag("HorizontalParkPoint1"))
		{
			horizontalfirstpoint = false;
		}

		if (collision.CompareTag("VerticalParkPoint2"))
		{
			verticaltwicepoint = false;
		}
		else if (collision.CompareTag("HorizontalParkPoint2"))
		{
			horizontaltwicepoint = false;
		}
	}*/
}