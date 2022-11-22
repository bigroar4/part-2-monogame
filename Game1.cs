using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace part_2_monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D circletexture;
        Rectangle circlerect, circle2Rect;
        Texture2D squaretexture;
        Rectangle rectanglerect;

        
        
        SpriteFont titleFont;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            rectanglerect = new Rectangle(140, 400, 250, 50);
            circlerect = new Rectangle(350, 200, 100, 100);
            circle2Rect = new Rectangle(150, 200, 100, 100);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            squaretexture = Content.Load<Texture2D>("rectangle");
            circletexture = Content.Load<Texture2D>("circle");
            titleFont = Content.Load<SpriteFont>("Font");


            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(circletexture,circlerect,Color.Magenta);
            _spriteBatch.Draw(squaretexture,rectanglerect, Color.Crimson);
            _spriteBatch.Draw(circletexture, circle2Rect, Color.Red);
            _spriteBatch.DrawString(titleFont, "Mr.Rohrer" , new Vector2(100,100), Color.Purple);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}