using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_55
{
    internal class Example
    {

        public void Run()
        {
            int number = 1;
            string title = "첫 번째 게시글입니다";
            string contents = "첫 번쨰 공지사항 입니다";
            string writer = "운영자";

            BoardService boardService = new BoardService();
            boardService.Save(number, title, contents, writer);
            boardService.Read();

            Console.WriteLine("=====");

            title = "첫 번쨰 게시글 수정";
            boardService.Update(title, contents, writer);
            boardService.Read();

            Console.WriteLine("=====");

            boardService.Delete();
            boardService.Read();

            Console.WriteLine("=====");

            // 생성자 오버로딩 이용
            Board board = new Board();
            board.Number = 2;
            board.Title = "두 번쨰 게시글 입니다";
            board.Contents = "두 번쨰 공지사항 입니다";
            board.Writer = "운영자";
            board.CreateDate = DateTime.Now;
            board.UpdateDate = DateTime.Now;

            BoardService anotherBoardService = new BoardService(board);
            anotherBoardService.Read();
        }
    }
}
