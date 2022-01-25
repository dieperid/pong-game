using SFML.Graphics;
using SFML.System;

namespace pong
{
    /// <summary>
    /// Class Ball
    /// </summary>
    class Ball
    {
        #region[Attributs]
        /// <summary>
        /// Ball width
        /// </summary>
        private const float BALL_WIDTH = 20;
        /// <summary>
        /// Ball height
        /// </summary>
        private const float BALL_HEIGHT = 20;
        /// <summary>
        /// Shape of the ball
        /// </summary>
        private RectangleShape _ballShape;
        /// <summary>
        /// Velocity of the ball for the position X
        /// </summary>
        private int _vBallX = 5;
        /// <summary>
        /// Velocity of the ball for the position Y
        /// </summary>
        private int _vBallY = 5;
        #endregion

        #region[Get, Set]
        /// <summary>
        /// Getter on BALL_WIDTH
        /// </summary>
        public float BallWidth
        {
            get { return BALL_WIDTH; }
        }
        /// <summary>
        /// Getter, setter on _vBallX
        /// </summary>
        public int VBallX
        {
            get { return _vBallX; }
            set { _vBallX = value; }
        }
        /// <summary>
        /// Getter, setter on _vBallY
        /// </summary>
        public int VBallY
        {
            get { return _vBallY; }
            set { _vBallY = value; }
        }
        /// <summary>
        /// Getter, setter on _ballShape
        /// </summary>
        public RectangleShape BallShape
        {
            get { return _ballShape; }
            set { _ballShape = value; }
        }
        /// <summary>
        /// Getter, setter on _ballShape.Position
        /// </summary>
        public Vector2f Position
        {
            get { return _ballShape.Position; }
            set { _ballShape.Position = value; }
        }
        #endregion

        /// <summary>
        /// Constructor of the class
        /// </summary>
        public Ball()
        {
            // Initialization of a new shape
            _ballShape = new RectangleShape(new Vector2f(BALL_WIDTH, BALL_HEIGHT));
        }
    }
}
