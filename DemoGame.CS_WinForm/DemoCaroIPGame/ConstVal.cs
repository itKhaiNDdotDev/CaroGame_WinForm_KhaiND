using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCaroIPGame
{
    public class ConstVal
    {
        // Set the size for a Caro Square by (pixel)
        public static int OCARO_WIDTH = 35;
        public static int OCARO_HEIGHT = 35;

        // Set the size for Play Board by (number of Caro Squares)
        public static int BOARD_WIDTH = 50;
        public static int BOARD_HEIGHT = 30;
        // Size này sẽ set lại sau: Để autoSize khi 2 người chơi full mới load thêm button để chơi tiếp, chưa full thì không load thêm tránh ngốn RAM
    }
}
