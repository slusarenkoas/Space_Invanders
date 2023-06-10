using SFML.Graphics;

namespace Space_Invaders;

public class TextureManager
{
    private const string ASSETS_PATH = "/Users/slusarenko.as/RiderProjects/Trainer Edition Space Invanders /Space Invanders/Assets";
    private const string BACKGROUND_TEXTURE_PATH = "/Backgrounds/greenBG.png";
    private const string PLAYER_ONE_TEXTURE_PATH = "/Ships/playerShip1_green.png";
    private const string ENEMY_TEXTURE_PATH = "/Enemies/enemyBlue1.png";
    private static readonly SpriteAtlasSettings ExplosionAtlasSettings =
        new(ASSETS_PATH + "/Explosions/explosionsAtlas.png", 4, 4);
        
    public static Texture BackgroundTexture;
    public static Texture PlayerTexture;
    public static readonly Texture EnemyTexture;
    public static readonly SpriteAtlas ExplosionAtlas;
        
    static TextureManager()
    {
        BackgroundTexture = new Texture(ASSETS_PATH + BACKGROUND_TEXTURE_PATH);
        PlayerTexture = new Texture(ASSETS_PATH + PLAYER_ONE_TEXTURE_PATH);
        EnemyTexture = new Texture(ASSETS_PATH + ENEMY_TEXTURE_PATH);
        ExplosionAtlas = new SpriteAtlas(ExplosionAtlasSettings);
    }

}