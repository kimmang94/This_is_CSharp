using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_55
{
    public class Board
    {
        // 게시글 번호
        public int Number { get; set; }
        // 게시글 제목
        public string Title { get; set; }
        // 게시글 내용
        public string Contents { get; set; }
        // 작성자
        public string Writer { get; set; }
        // 작성일
        public DateTime CreateDate { get; set; }
        // 수정일
        public DateTime UpdateDate { get; set; }
    }


}
