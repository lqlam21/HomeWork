using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.DTO
{
    class dto_loai
    {
        string ten_tiengviet;
        string ten_latin;
        int bo_id;
        int ho_id;
        int chi_id;

        public string Ten_tiengviet { get => ten_tiengviet; set => ten_tiengviet = value; }
        public string Ten_latin { get => ten_latin; set => ten_latin = value; }
        public int Bo_id { get => bo_id; set => bo_id = value; }
        public int Ho_id { get => ho_id; set => ho_id = value; }
        public int Chi_id { get => chi_id; set => chi_id = value; }
    }
}
