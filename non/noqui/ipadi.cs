bool CheckGrounded()
{
    RaycastHit hit;
    if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.1f))
    {
        return true;
    }
    return false;
}
