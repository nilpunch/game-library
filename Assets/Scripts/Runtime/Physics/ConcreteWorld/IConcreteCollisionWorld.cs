namespace GameLibrary
{
    public interface IConcreteCollisionWorld<TConcrete>
    {
        ConcreteInteraction<TConcrete>[] AllInteractions();
        
        ConcreteInteraction<TConcrete>[] InteractionsWith(IPhysicalObject physicalObject);
        
        ConcreteRaycastHit<TConcrete> Raycast(Vector3 from, Vector3 direction);
    }
}