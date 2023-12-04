using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace scoop
{
   
       

    public class ProductionInfo
    {        
        public string LHS;
        public int RHS_len;
    }
    public class ProductionTable
    {
        public ProductionInfo[] prd_tab = new ProductionInfo[126];
        public ProductionTable()
        {
            populateProd_tab();
        }
        void populateProd_tab()
        {
            ProductionInfo tmpPrdInf;
            tmpPrdInf = null;
            prd_tab[0] = tmpPrdInf;
            

            prd_tab[1] = new ProductionInfo();            
            prd_tab[1].LHS = "<program>"; 
            prd_tab[1].RHS_len = 2;   // including $$ the length is 2

            prd_tab[2] = new ProductionInfo();            
            prd_tab[2].LHS = "<cls_list>";
            prd_tab[2].RHS_len = 2;

            prd_tab[3] = new ProductionInfo();            
            prd_tab[3].LHS = "<cls_list>";
            prd_tab[3].RHS_len = 0;

            prd_tab[4] = new ProductionInfo();            
            prd_tab[4].LHS = "<class>";
            prd_tab[4].RHS_len = 6;

            prd_tab[5] = new ProductionInfo();            
            prd_tab[5].LHS = "<st_dec_list>";
            prd_tab[5].RHS_len = 6;

            prd_tab[6] = new ProductionInfo();            
            prd_tab[6].LHS = "<st_dec_list>";
            prd_tab[6].RHS_len = 0;

            prd_tab[7] = new ProductionInfo();            
            prd_tab[7].LHS = "<st_list>";
            prd_tab[7].RHS_len = 3;

            prd_tab[8] = new ProductionInfo();            
            prd_tab[8].LHS = "<st_list>";
            prd_tab[8].RHS_len = 1;

            prd_tab[9] = new ProductionInfo();            
            prd_tab[9].LHS = "<st_id>";
            prd_tab[9].RHS_len = 1;

            prd_tab[10] = new ProductionInfo();            
            prd_tab[10].LHS = "<cls_body>";
            prd_tab[10].RHS_len = 4;

            prd_tab[11] = new ProductionInfo();            
            prd_tab[11].LHS = "<var_dec_list>";
            prd_tab[11].RHS_len = 3;

            prd_tab[12] = new ProductionInfo();            
            prd_tab[12].LHS = "<var_dec_list>";
            prd_tab[12].RHS_len = 0;

            prd_tab[13] = new ProductionInfo();            
            prd_tab[13].LHS = "<var_dec>";
            prd_tab[13].RHS_len = 2;

            prd_tab[14] = new ProductionInfo();
            prd_tab[14].LHS = "<vd_start>";
            prd_tab[14].RHS_len = 3;

            prd_tab[15] = new ProductionInfo();            
            prd_tab[15].LHS = "<dt>";
            prd_tab[15].RHS_len = 1;

            prd_tab[16] = new ProductionInfo();            
            prd_tab[16].LHS = "<dt>";
            prd_tab[16].RHS_len = 1;

            prd_tab[17] = new ProductionInfo();            
            prd_tab[17].LHS = "<dt>";
            prd_tab[17].RHS_len = 1;

            prd_tab[18] = new ProductionInfo();
            prd_tab[18].LHS = "<st_binding>";
            prd_tab[18].RHS_len = 4;

            prd_tab[19] = new ProductionInfo();
            prd_tab[19].LHS = "<b_list>";
            prd_tab[19].RHS_len = 3;

            prd_tab[20] = new ProductionInfo();
            prd_tab[20].LHS = "<b_list>";
            prd_tab[20].RHS_len = 1;

            prd_tab[21] = new ProductionInfo();
            prd_tab[21].LHS = "<bind>";
            prd_tab[21].RHS_len = 5;

            prd_tab[22] = new ProductionInfo();
            prd_tab[22].LHS = "<b_rel_exp>";           // this is actually removed
            prd_tab[22].RHS_len = 1;

            prd_tab[23] = new ProductionInfo();
            prd_tab[23].LHS = "<st_binding>";
            prd_tab[23].RHS_len = 0;


            prd_tab[24] = new ProductionInfo();
            prd_tab[24].LHS = "<cls_m_list>";
            prd_tab[24].RHS_len = 2;

            prd_tab[25] = new ProductionInfo();
            prd_tab[25].LHS = "<cls_m_list>";
            prd_tab[25].RHS_len = 0;

            prd_tab[26] = new ProductionInfo();
            prd_tab[26].LHS = "<cls_method>";
            prd_tab[26].RHS_len = 9;

            prd_tab[27] = new ProductionInfo();
            prd_tab[27].LHS = "<pub-prv>";
            prd_tab[27].RHS_len = 1;

            prd_tab[28] = new ProductionInfo();
            prd_tab[28].LHS = "<pub-prv>";
            prd_tab[28].RHS_len = 1;

            prd_tab[29] = new ProductionInfo();
            prd_tab[29].LHS = "<r_type>";
            prd_tab[29].RHS_len = 1;

            prd_tab[30] = new ProductionInfo();
            prd_tab[30].LHS = "<m_id>";
            prd_tab[30].RHS_len = 1;

            prd_tab[31] = new ProductionInfo();
            prd_tab[31].LHS = "<arg_list>";
            prd_tab[31].RHS_len = 0;

            prd_tab[32] = new ProductionInfo();
            prd_tab[32].LHS = "<arg_list>";
            prd_tab[32].RHS_len = 1;

            prd_tab[33] = new ProductionInfo();
            prd_tab[33].LHS = "<args>";
            prd_tab[33].RHS_len = 3;

            prd_tab[34] = new ProductionInfo();
            prd_tab[34].LHS = "<args>";
            prd_tab[34].RHS_len = 1;

            prd_tab[35] = new ProductionInfo();
            prd_tab[35].LHS = "<arg>";
            prd_tab[35].RHS_len = 2;

            prd_tab[36] = new ProductionInfo();
            prd_tab[36].LHS = "<m_body>";
            prd_tab[36].RHS_len = 2;

            prd_tab[37] = new ProductionInfo();
            prd_tab[37].LHS = "<stm_list>";
            prd_tab[37].RHS_len = 2;

            prd_tab[38] = new ProductionInfo();
            prd_tab[38].LHS = "<stm_list>";
            prd_tab[38].RHS_len = 0;

            prd_tab[39] = new ProductionInfo();
            prd_tab[39].LHS = "<stm>";
            prd_tab[39].RHS_len = 4;

            prd_tab[40] = new ProductionInfo();
            prd_tab[40].LHS = "<stm>";
            prd_tab[40].RHS_len = 5;

            prd_tab[41] = new ProductionInfo();
            prd_tab[41].LHS = "<stm>";
            prd_tab[41].RHS_len = 3;

            prd_tab[42] = new ProductionInfo();
            prd_tab[42].LHS = "<stm>";
            prd_tab[42].RHS_len = 7;

            prd_tab[43] = new ProductionInfo();
            prd_tab[43].LHS = "<vd_new>";
            prd_tab[43].RHS_len = 5;

            prd_tab[44] = new ProductionInfo();
            prd_tab[44].LHS = "<stm>";
            prd_tab[44].RHS_len = 8;

            prd_tab[45] = new ProductionInfo();
            prd_tab[45].LHS = "<else>";
            prd_tab[45].RHS_len = 4;

            prd_tab[46] = new ProductionInfo();
            prd_tab[46].LHS = "<else>";
            prd_tab[46].RHS_len = 0;

            prd_tab[47] = new ProductionInfo();
            prd_tab[47].LHS = "<stm>";
            prd_tab[47].RHS_len = 7;

            prd_tab[48] = new ProductionInfo();
            prd_tab[48].LHS = "<stm>";
            prd_tab[48].RHS_len = 10;

            prd_tab[49] = new ProductionInfo();
            prd_tab[49].LHS = "<rel_exp>";
            prd_tab[49].RHS_len = 3;

            prd_tab[50] = new ProductionInfo();
            prd_tab[50].LHS = "<rel_term>";
            prd_tab[50].RHS_len = 1;

            prd_tab[51] = new ProductionInfo();
            prd_tab[51].LHS = "<rel_exp>";
            prd_tab[51].RHS_len = 1;

            prd_tab[52] = new ProductionInfo();
            prd_tab[52].LHS = "<rel_term>";
            prd_tab[52].RHS_len = 3;


            prd_tab[53] = new ProductionInfo();
            prd_tab[53].LHS = "<rel_bool_fac>";
            prd_tab[53].RHS_len = 1;

            prd_tab[54] = new ProductionInfo();
            prd_tab[54].LHS = "<rel_fac>";
            prd_tab[54].RHS_len = 1;

            prd_tab[55] = new ProductionInfo();
            prd_tab[55].LHS = "<rel_fac>";
            prd_tab[55].RHS_len = 1;

            prd_tab[56] = new ProductionInfo();
            prd_tab[56].LHS = "<rel_fac> ";
            prd_tab[56].RHS_len = 3;

            prd_tab[57] = new ProductionInfo();
            prd_tab[57].LHS = "<rel_op>";
            prd_tab[57].RHS_len = 1;

            prd_tab[58] = new ProductionInfo();
            prd_tab[58].LHS = "<rel_op>";
            prd_tab[58].RHS_len = 1;

            prd_tab[59] = new ProductionInfo();
            prd_tab[59].LHS = "<comp_op>";
            prd_tab[59].RHS_len = 1;

            prd_tab[59] = new ProductionInfo();
            prd_tab[59].LHS = "<comp_op>";
            prd_tab[59].RHS_len = 1;

            prd_tab[60] = new ProductionInfo();
            prd_tab[60].LHS = "<comp_op>";
            prd_tab[60].RHS_len = 1;

            prd_tab[61] = new ProductionInfo();
            prd_tab[61].LHS = "<comp_op>";
            prd_tab[61].RHS_len = 1;

            prd_tab[62] = new ProductionInfo();
            prd_tab[62].LHS = "<comp_op>";
            prd_tab[62].RHS_len = 1;

            prd_tab[63] = new ProductionInfo();
            prd_tab[63].LHS = "<comp_op>";
            prd_tab[63].RHS_len = 1;

            prd_tab[64] = new ProductionInfo();
            prd_tab[64].LHS = "<comp_op>";
            prd_tab[64].RHS_len = 1;

            prd_tab[65] = new ProductionInfo();
            prd_tab[65].LHS = "<exp>";
            prd_tab[65].RHS_len = 1;

            prd_tab[66] = new ProductionInfo();
            prd_tab[66].LHS = "<exp>";
            prd_tab[66].RHS_len = 3;

            prd_tab[67] = new ProductionInfo();
            prd_tab[67].LHS = "<term>";
            prd_tab[67].RHS_len = 1;

            prd_tab[68] = new ProductionInfo();
            prd_tab[68].LHS = "<term>";
            prd_tab[68].RHS_len = 3;

            prd_tab[69] = new ProductionInfo();
            prd_tab[69].LHS = "<factor>";
            prd_tab[69].RHS_len = 3;

            prd_tab[70] = new ProductionInfo();
            prd_tab[70].LHS = "<factor>";
            prd_tab[70].RHS_len = 1;

            prd_tab[71] = new ProductionInfo();
            prd_tab[71].LHS = "<factor>";
            prd_tab[71].RHS_len = 3;

            prd_tab[72] = new ProductionInfo();
            prd_tab[72].LHS = "<factor>";
            prd_tab[72].RHS_len = 1;

            prd_tab[73] = new ProductionInfo();
            prd_tab[73].LHS = "<add_op>";
            prd_tab[73].RHS_len = 1;

            prd_tab[74] = new ProductionInfo();
            prd_tab[74].LHS = "<add_op>";
            prd_tab[74].RHS_len = 1;

            prd_tab[75] = new ProductionInfo();
            prd_tab[75].LHS = "<mult_op>";
            prd_tab[75].RHS_len = 1;

            prd_tab[76] = new ProductionInfo();
            prd_tab[76].LHS = "<mult_op>";
            prd_tab[76].RHS_len = 1;

            prd_tab[77] = new ProductionInfo();
            prd_tab[77].LHS = "<c_s_m_list>";
            prd_tab[77].RHS_len = 0;

            prd_tab[78] = new ProductionInfo();
            prd_tab[78].LHS = "<c_s_m_list>";
            prd_tab[78].RHS_len = 2;

            prd_tab[79] = new ProductionInfo();
            prd_tab[79].LHS = "<c_s_method>";
            prd_tab[79].RHS_len = 5;

            prd_tab[80] = new ProductionInfo();
            prd_tab[80].LHS = "<s_m_list>";
            prd_tab[80].RHS_len = 2;

            prd_tab[81] = new ProductionInfo();
            prd_tab[81].LHS = "<s_m_list>";
            prd_tab[81].RHS_len = 1;

            prd_tab[82] = new ProductionInfo();
            prd_tab[82].LHS = "<s_method>";
            prd_tab[82].RHS_len = 9;

            prd_tab[83] = new ProductionInfo();
            prd_tab[83].LHS = "<s_end_list>";
            prd_tab[83].RHS_len = 3;

            prd_tab[84] = new ProductionInfo();
            prd_tab[84].LHS = "<s_list>";
            prd_tab[84].RHS_len = 3;

            prd_tab[85] = new ProductionInfo();
            prd_tab[85].LHS = "<s_list>";
            prd_tab[85].RHS_len = 1;

            prd_tab[86] = new ProductionInfo();
            prd_tab[86].LHS = "<s_e_list>";
            prd_tab[86].RHS_len = 3;

            prd_tab[87] = new ProductionInfo();
            prd_tab[87].LHS = "<s_e_list>";
            prd_tab[87].RHS_len = 1;

            prd_tab[88] = new ProductionInfo();
            prd_tab[88].LHS = "<s_m_body>";
            prd_tab[88].RHS_len = 2;

            prd_tab[89] = new ProductionInfo();
            prd_tab[89].LHS = "<s_stm_list>";
            prd_tab[89].RHS_len = 2;

            prd_tab[90] = new ProductionInfo();
            prd_tab[90].LHS = "<s_stm_list>";
            prd_tab[90].RHS_len = 0;

            prd_tab[91] = new ProductionInfo();
            prd_tab[91].LHS = "<st_stm>";
            prd_tab[91].RHS_len = 7;

            prd_tab[92] = new ProductionInfo();
            prd_tab[92].LHS = "<st_stm>";
            prd_tab[92].RHS_len = 4;

            prd_tab[93] = new ProductionInfo();
            prd_tab[93].LHS = "<st_stm>";
            prd_tab[93].RHS_len = 5;

            prd_tab[94] = new ProductionInfo();
            prd_tab[94].LHS = "<st_stm>";
            prd_tab[94].RHS_len = 3;

            prd_tab[95] = new ProductionInfo();
            prd_tab[95].LHS = "<st_stm>";
            prd_tab[95].RHS_len = 7;

            //prd_tab[96] = new ProductionInfo();
            //prd_tab[96].LHS = "<st_stm>";                      //this is actually removed
            //prd_tab[96].RHS_len = 7;

            prd_tab[97] = new ProductionInfo();
            prd_tab[97].LHS = "<st_stm>";
            prd_tab[97].RHS_len = 7;

            prd_tab[98] = new ProductionInfo();
            prd_tab[98].LHS = "<st_stm>";
            prd_tab[98].RHS_len = 10;

            prd_tab[99] = new ProductionInfo();
            prd_tab[99].LHS = "<st_stm>";
            prd_tab[99].RHS_len = 8;

            prd_tab[100] = new ProductionInfo();
            prd_tab[100].LHS = "<s_else>";
            prd_tab[100].RHS_len = 4;

            prd_tab[101] = new ProductionInfo();
            prd_tab[101].LHS = "<s_else>";
            prd_tab[101].RHS_len = 0;

            prd_tab[102] = new ProductionInfo();
            prd_tab[102].LHS = "<init>";
            prd_tab[102].RHS_len = 4;

            prd_tab[103] = new ProductionInfo();
            prd_tab[103].LHS = "<mid>";
            prd_tab[103].RHS_len = 1;

            prd_tab[104] = new ProductionInfo();
            prd_tab[104].LHS = "<last>";
            prd_tab[104].RHS_len = 2;

            prd_tab[105] = new ProductionInfo();
            prd_tab[105].LHS = "<in_dec>";
            prd_tab[105].RHS_len = 1;

            prd_tab[106] = new ProductionInfo();
            prd_tab[106].LHS = "<in_dec>";
            prd_tab[106].RHS_len = 1;

            prd_tab[107] = new ProductionInfo();
            prd_tab[107].LHS = "<lhs>";
            prd_tab[107].RHS_len = 1;

            prd_tab[108] = new ProductionInfo();
            prd_tab[108].LHS = "<lhs>";
            prd_tab[108].RHS_len = 3;

            prd_tab[109] = new ProductionInfo();
            prd_tab[109].LHS = "<param_list>";
            prd_tab[109].RHS_len = 1;

            prd_tab[110] = new ProductionInfo();
            prd_tab[110].LHS = "<params>";
            prd_tab[110].RHS_len = 3;

            prd_tab[111] = new ProductionInfo();
            prd_tab[111].LHS = "<params>";
            prd_tab[111].RHS_len = 1;

            prd_tab[112] = new ProductionInfo();
            prd_tab[112].LHS = "<param_list>";
            prd_tab[112].RHS_len = 0;

            prd_tab[113] = new ProductionInfo();
            prd_tab[113].LHS = "<new>";
            prd_tab[113].RHS_len = 0;

            prd_tab[114] = new ProductionInfo();
            prd_tab[114].LHS = "<cl_id>";
            prd_tab[114].RHS_len = 1;

            prd_tab[115] = new ProductionInfo();
            prd_tab[115].LHS = "<s_id>";
            prd_tab[115].RHS_len = 3;

            prd_tab[116] = new ProductionInfo();
            prd_tab[116].LHS = "<s_id>";
            prd_tab[116].RHS_len = 7;

            prd_tab[117] = new ProductionInfo();
            prd_tab[117].LHS = "<vd_rest>";
            prd_tab[117].RHS_len = 1;

            prd_tab[118] = new ProductionInfo();
            prd_tab[118].LHS = "<vd_rest>";
            prd_tab[118].RHS_len = 1;

            prd_tab[119] = new ProductionInfo();
            prd_tab[119].LHS = "<vd_simple>";
            prd_tab[119].RHS_len = 3;

            prd_tab[120] = new ProductionInfo();
            prd_tab[120].LHS = "<vd_simple>";
            prd_tab[120].RHS_len = 0;

            prd_tab[121] = new ProductionInfo();
            prd_tab[121].LHS = "<vd_new>";
            prd_tab[121].RHS_len = 0;

            prd_tab[122] = new ProductionInfo();
            prd_tab[122].LHS = "<s_v_d_lst>";
            prd_tab[122].RHS_len = 3;

            prd_tab[123] = new ProductionInfo();
            prd_tab[123].LHS = "<s_v_d_lst>";
            prd_tab[123].RHS_len = 0;

            prd_tab[124] = new ProductionInfo();
            prd_tab[124].LHS = "<s_v_d>";
            prd_tab[124].RHS_len = 2;

            prd_tab[125] = new ProductionInfo();
            prd_tab[125].LHS = "<s_vd_start>";
            prd_tab[125].RHS_len = 2;

            
        }
    }




}
