using SFML.Graphics;
using SFML.System;

namespace pong
{
    /// <summary>
    /// Class Player
    /// </summary>
    class Player
    {
        #region[Attributs]
        /// <summary>
        /// Player width
        /// </summary>
        const float PLAYER_WIDTH = 20;
        /// <summary>
        /// Player Height
        /// </summary>
        const float PLAYER_HEIGHT = 80;
        /// <summary>
        /// Shape of the player
        /// </summary>
        private RectangleShape _playerShape;
        /// <summary>
        /// Velocity of the player for the position Y
        /// </summary>
        private int _vPlayerY = 5;
        #endregion

        #region[Get, Set]
        /// <summary>
        /// Getter on PLAYER_WIDTH
        /// </summary>
        public float PlayerWidth
        {
            get { return PLAYER_WIDTH; }
        }
        /// <summary>
        /// Getter on PLAYER_HEIGHT
        /// </summary>
        public float PlayerHeight
        {
            get { return PLAYER_HEIGHT; }
        }
        /// <summary>
        /// Getter, setter on _vPlayerY
        /// </summary>
        public int VPlayerY
        {
            get { return _vPlayerY; }
            set { _vPlayerY = value; }
        }
        /// <summary>
        /// Getter, setter on _playerShape
        /// </summary>
        public RectangleShape PlayerShape
        {
            get { return _playerShape; }
            set { _playerShape = value; }
        }
        /// <summary>
        /// Getter, setter on _playerShape.Position
        /// </summary>
        public Vector2f Position
        {
            get { return _playerShape.Position; }
            set { _playerShape.Position = value; }
        }
        #endregion

        /// <summary>
        /// Constructor of the class
        /// </summary>
        public Player()
        {
            // Initialization of a new shape
            _playerShape = new RectangleShape(new Vector2f(PLAYER_WIDTH, PLAYER_HEIGHT));
        }
    }
}
