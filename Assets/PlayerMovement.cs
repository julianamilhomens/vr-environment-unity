using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movimento")]
    public float velocidade = 4f;
    public float gravidade = -9.81f;

    [Header("Camera")]
    public Transform cameraTransform;
    public float sensibilidadeMouse = 2f;

    private CharacterController controller;
    private float rotacaoVertical = 0f;
    private float velocidadeY = 0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        OlharComMouse();
        Mover();


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    void OlharComMouse()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidadeMouse;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidadeMouse;

 
        transform.Rotate(Vector3.up * mouseX);

  
        rotacaoVertical -= mouseY;
        rotacaoVertical = Mathf.Clamp(rotacaoVertical, -80f, 80f);
        cameraTransform.localRotation = Quaternion.Euler(rotacaoVertical, 0f, 0f);
    }

    void Mover()
    {
        float horizontal = Input.GetAxis("Horizontal"); // A/D
        float vertical = Input.GetAxis("Vertical");     // W/S

        Vector3 direcao = transform.right * horizontal + transform.forward * vertical;


        if (controller.isGrounded && velocidadeY < 0)
            velocidadeY = -2f;
        velocidadeY += gravidade * Time.deltaTime;

        Vector3 movimento = direcao * velocidade;
        movimento.y = velocidadeY;

        controller.Move(movimento * Time.deltaTime);
    }
}