using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCaroIPGame
{
    // Sourrce Editor for Panel Play Board Here!!!

    public partial class MainScreen : Form
    {

        #region properties

        EditPlayBoard playBoard;

        #endregion



        #region initializes

        #endregion



        #region mothods

        public MainScreen()
        {
            InitializeComponent();

            playBoard = new EditPlayBoard(pnPlayBoard, boxNameCurPlayer, boxPicCurPlayer);
            playBoard.DrawPlayBroad();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void MainGameLabbel_Click(object sender, EventArgs e)
        {
        }

        private void pnPlayBroad_Paint(object sender, PaintEventArgs e)
        {
        }

        #endregion

    }
}
