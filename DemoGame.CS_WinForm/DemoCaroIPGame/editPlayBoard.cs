using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCaroIPGame
{
    // Source Editor to Setup for Play Board Here!!!

    public class EditPlayBoard
    {

        #region properties

        private Panel playBoard;
        public Panel PlayBoard { get => playBoard; set => playBoard = value; }

        private List<Player> player;
        public List<Player> Player { get => player; set => player = value; }

        private int idCurPlayer;
        public int IDCurPlayer { get => idCurPlayer; set => idCurPlayer = value; }

        private TextBox playerName;
        public TextBox PlayerName { get => playerName; set => playerName = value; }

        private PictureBox playerPicture;
        public PictureBox PlayerPicture { get => playerPicture; set => playerPicture = value; }

        #endregion



        #region initializes

        public EditPlayBoard(Panel playBoard, TextBox playerName, PictureBox playerPicture)
        {
            this.PlayBoard = playBoard;
            this.Player = new List<Player>()
            {
                // Đang gán tên người chơi mặc định! Nghĩ cách tạo tính năng cho người chơi đặt tên sau!
                new Player ( "RedPlayer", Image.FromFile(Application.StartupPath + "\\Resources\\x.jpg") ),
                new Player ( "BluePlayer", Image.FromFile(Application.StartupPath + "\\Resources\\o.jpg") )
                // màu của từng tên tương úng (X tên đỏ, O tên xanh) phải viết sự kiện sau!
            };

            IDCurPlayer = 0;
            this.PlayerName = playerName;
            this.PlayerPicture = playerPicture;

            ChangePlayer();
        }

        #endregion



        #region mothods

        // function to Draw Caro Play Board 
        public void DrawPlayBroad()
        {
            // MessageBox.Show(" Đã vẽ bàn cờ! ");
            Button prevOCaro = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < ConstVal.BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < ConstVal.BOARD_WIDTH; j++)
                {
                    Button oCaro = new Button()
                    {
                        Width = ConstVal.OCARO_WIDTH,
                        Height = ConstVal.OCARO_HEIGHT,
                        Location = new Point(prevOCaro.Location.X + prevOCaro.Width, prevOCaro.Location.Y),
                    };
                    prevOCaro = oCaro;

                    // load event 'click' to oCaro Squares
                    oCaro.Click += oCaro_Click;

                    PlayBoard.Controls.Add(oCaro);
                }
                prevOCaro.Location = new Point(0, prevOCaro.Location.Y + ConstVal.OCARO_HEIGHT);
                prevOCaro.Width = 0;
                prevOCaro.Height = 0;
            }
        }

        // function to setup for Event 'oCaro_Click'
        private void oCaro_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Button oCaro = sender as Button;

            if (oCaro.BackgroundImage != null)
                return;
            OcaroClick(oCaro);
            ChangePlayer();
        }

        // function to process Event Click to Ocaro
        private void OcaroClick(Button oCaro)
        {
            oCaro.BackgroundImage = Player[IDCurPlayer].Caro;
            oCaro.BackgroundImageLayout = ImageLayout.Stretch;
            IDCurPlayer = (IDCurPlayer == 1) ? 0 : 1;
            //oCaro.Size = new Size(oCaro.Size.Width, oCaro.Size.Height);
        }

        private void ChangePlayer()
        {

            PlayerName.Text = Player[IDCurPlayer].Name;
            PlayerPicture.BackgroundImage = Player[IDCurPlayer].Caro;
        }

        #endregion

    }
}
