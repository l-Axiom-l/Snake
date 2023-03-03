using GridTools;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Snake
{
    public partial class Form1 : Form
    {
        //Graphics g;
        public int speed = 150;
        public int XDim = 20;
        public int YDim = 20;

        Point drawPoint = new Point(20,20);

        Grid grid;
        Timer update;
        SnakeObject snake;
        bool initialized = false;

        bool fruitAvailable = false;
        Point fruitPosition = Point.Empty;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new System.Drawing.Size(900, 900);

            Menu menu = new Menu(this);
            menu.ShowDialog();

            grid = new Grid(XDim, YDim);

            update = new Timer(speed);
            update.AutoReset = true;
            update.Enabled = true;
            update.Elapsed += Update;

            KeyDown += Controls;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Start();
        }

        void Controls(object form, KeyEventArgs k)
        {
            switch (k.KeyCode)
            {
                case Keys.W:
                    if (snake.GetRotation() != Rotation.Down)
                        snake.SetRotation(Rotation.Up);
                    break;
                case Keys.S:
                    if (snake.GetRotation() != Rotation.Up)
                        snake.SetRotation(Rotation.Down);
                    break;
                case Keys.A:
                    if (snake.GetRotation() != Rotation.Right)
                        snake.SetRotation(Rotation.Left);
                    break;
                case Keys.D:
                    if (snake.GetRotation() != Rotation.Left)
                        snake.SetRotation(Rotation.Right);
                    break;
                case Keys.Escape:
                    Application.Restart();
                    break;
            }
        }

        void SpawnFruit()
        {
            Point pos;

            while (true)
            {
                pos = new Point(Random.Shared.Next(0, XDim), Random.Shared.Next(0, YDim));

                if (!snake.queue.Contains(pos))
                    break;
            }

            using (Graphics g = CreateGraphics())
            {
                Tile t = new Tile(pos.X, pos.Y, 0, false);
                grid.DrawTile(t, Color.DarkOrange, g, ClientSize, drawPoint);
            }

            fruitPosition = pos;
            fruitAvailable = true;
        }

        void Update(object s, ElapsedEventArgs e)
        {
            if (!initialized)
                return;

            using (Graphics g = CreateGraphics())
            {
                snake.Move();
                Point p2 = snake.queue.Last();

                if (!Enumerable.Range(0, XDim).Contains(p2.X) || !Enumerable.Range(0, YDim).Contains(p2.Y) || snake.isSnakePosition(p2))
                {
                    End();
                    return;
                }

                if (fruitPosition.Equals(p2))
                {
                    fruitAvailable = false;
                    snake.SizeIncrease();
                }

                Tile t2 = new Tile(p2.X, p2.Y, 0, false);
                grid.DrawTile(t2, Color.DarkRed, g, ClientSize, drawPoint);
            }

            if (!fruitAvailable)
                SpawnFruit();
        }

        void Dequeue(Point p)
        {
            using (Graphics g = CreateGraphics())
            {
                Tile t = new Tile(p.X, p.Y, 0, false);
                grid.DrawTile(t, GridBrushes.mainBrush.Color, g, ClientSize, drawPoint);
            }

        }

        void Start()
        {
            drawPoint = new Point(20,20);
            snake = new SnakeObject(new Point(2, 5));
            snake.OnDequeue += Dequeue;
            using (Graphics g = CreateGraphics())
            {
                grid.DrawGrid(g, ClientSize, drawPoint);
            }

            update.Enabled = true;
            initialized = true;
        }

        void End()
        {
            update.Enabled = false;
            initialized = false;
            fruitAvailable = false;
            MessageBox.Show("Score: " + snake.queue.Count.ToString(), "You died", MessageBoxButtons.OK);
            Start();

        }
    }
}

public delegate void dequeue(Point p);
public class SnakeObject
{
    private Point position;
    private Rotation rotation = Rotation.Up;
    public Queue<Point> queue = new Queue<Point>();
    bool sizeIncrease = false;
    public event dequeue OnDequeue;

    public SnakeObject(Point position)
    {
        this.position = position;
        queue.Enqueue(position);
    }

    public Point GetPosition()
    { return position; }

    public Rotation GetRotation()
    { return rotation; }

    public void SetRotation(Rotation rotation)
    { this.rotation = rotation; }

    public void SizeIncrease()
    {
        sizeIncrease = true;
    }

    public bool isSnakePosition(Point p)
    {
        return queue.Count(x => x.Equals(p)) >= 2;
    }

    public void Move()
    {
        switch (rotation)
        {
            case Rotation.Up:
                position = new Point(position.X, position.Y - 1);
                if (!sizeIncrease) { OnDequeue.Invoke(queue.Dequeue()); };
                queue.Enqueue(position);
                sizeIncrease = false;
                break;
            case Rotation.Down:
                position = new Point(position.X, position.Y + 1);
                if (!sizeIncrease) { OnDequeue.Invoke(queue.Dequeue()); };
                queue.Enqueue(position);
                sizeIncrease = false;
                break;
            case Rotation.Left:
                position = new Point(position.X - 1, position.Y);
                if (!sizeIncrease) { OnDequeue.Invoke(queue.Dequeue()); };
                queue.Enqueue(position);
                sizeIncrease = false;
                break;
            case Rotation.Right:
                position = new Point(position.X + 1, position.Y);
                if (!sizeIncrease) { OnDequeue.Invoke(queue.Dequeue()); };
                queue.Enqueue(position);
                sizeIncrease = false;
                break;
        }
    }
}

public enum Rotation
{
    Up, Down, Left, Right,
}