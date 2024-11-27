// Content.Server/Sound/PlaySoundOnUseSystem.cs

namespace Content.Server.Sound;

public sealed class PlaySoundOnUseSystem : EntitySystem
{
    [Dependency] private readonly SharedAudioSystem _audio = default!;

    private void OnUseInHand(Entity<PlaySoundOnUseComponent> ent, ref UseInHandEvent args)
    {

    }

    public override void Initialize()
    {
        SubscribeLocalEvent<PlaySoundOnUseComponent, UseInHandEvent>(OnUseInHand);
    } 
}
