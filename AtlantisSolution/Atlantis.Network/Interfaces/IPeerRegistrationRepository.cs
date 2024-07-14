namespace Interfaces;

public interface IPeerRegistrationRepository
{
    bool IsPeerRegistred { get; }
        
    Guid PeerId { get; set; }

    void StartPeerRegistration(string userName);
        
    void StopPeerRegistration();
}