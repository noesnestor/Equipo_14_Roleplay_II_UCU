namespace RoleplayGame
{
    public interface IPersonaje
    {
        void ReceiveAttack(IPersonaje value);
        int AttackValue {get;}
    }
}