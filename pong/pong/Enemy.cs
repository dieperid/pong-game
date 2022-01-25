using SFML.Graphics;
using SFML.System;

namespace pong
{
    /// <summary>
    /// Class Enemy
    /// </summary>
    class Enemy
    {
        #region[Attributs]
        /// <summary>
        /// Enemy width
        /// </summary>
        private const float ENEMY_WIDTH = 20;
        /// <summary>
        /// Enemy height
        /// </summary>
        private const float ENEMY_HEIGHT = 80;
        /// <summary>
        /// Shape of the enemy
        /// </summary>
        private RectangleShape _enemyShape;
        #endregion

        #region[Get, Set]
        /// <summary>
        /// Getter on ENEMY_WIDTH
        /// </summary>
        public float EnemyWidth
        {
            get { return ENEMY_WIDTH; }
        }
        /// <summary>
        /// Getter on ENEMY_HEIGHT
        /// </summary>
        public float EnemyHeight
        {
            get { return ENEMY_HEIGHT; }
        }
        /// <summary>
        /// Getter, setter on _enemyShape
        /// </summary>
        public RectangleShape EnemyShape
        {
            get { return _enemyShape; }
            set { _enemyShape = value; }
        }
        /// <summary>
        /// Getter, setter on _enemyShape.Position
        /// </summary>
        public Vector2f Position
        {
            get { return _enemyShape.Position; }
            set { _enemyShape.Position = value; }
        }
        #endregion

        /// <summary>
        /// Constructor of the class
        /// </summary>
        public Enemy()
        {
            // Initialization of a new shape
            _enemyShape = new RectangleShape(new Vector2f(ENEMY_WIDTH, ENEMY_HEIGHT));
        }
    }
}

