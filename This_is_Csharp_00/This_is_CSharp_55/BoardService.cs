﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_55
{
    internal class BoardService
    {
        This_is_CSharp_55.Board board;

        public BoardService()
        {
            this.board = new Board();
        }

        public BoardService(Board board)
        {
            this.board = board;
        }

        public void Save(int number, string title, string content, string writer)
        {
            board.Number = number;
            board.Title = title;    
            board.Contents = content;
            board.Writer = writer;  
            board.CreateDate = DateTime.Now;
            board.UpdateDate = DateTime.Now;

            Console.WriteLine("게시물이 저장되었습니다");
        }

        public void Update(string title, string content, string writer)
        {
            board.Title = title;
            board.Contents = content;
            board.Writer = writer;
            board.UpdateDate= DateTime.Now;

            Console.WriteLine("게시물이 수정되었습니다.");
        }

        public void Delete()
        {
            board = null;
            Console.WriteLine("게시물이 삭제되었습니다");
        }

        public void Read()
        {
            if (board != null)
            {
                Console.WriteLine("{0} 번 게시물 : ", board.Number);
                Console.WriteLine("제목 : {0}", board.Title);
                Console.WriteLine("작성일 : {0}", board.CreateDate);
                Console.WriteLine("수정일 : {0}", board.UpdateDate);
                Console.WriteLine("글쓴이 : {0}", board.Writer);
                Console.WriteLine("내용 : {0}", board.Contents);
            }
            else
            {
                Console.WriteLine("게시물이 없습니다.");
            }
        }
    }
}
