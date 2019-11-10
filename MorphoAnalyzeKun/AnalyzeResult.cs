using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorphoAnalyzeKun
{
    class AnalyzeResult
    {
        public string 表層形 { get; set; }
        public string 原形 { get; set; }
        public string 品詞 { get; set; }
        public int 出現回数 { get; set; }
    }
}
