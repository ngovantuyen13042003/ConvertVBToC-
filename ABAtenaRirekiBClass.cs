// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‚`‚aˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/01/10@‘ê‘ò@‹Ô–ç
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/02/25 000001     ƒf[ƒ^‹æ•ª‚ª‚ ‚éŽž‚àAƒf[ƒ^Ží•Ê‚ª“ü‚Á‚Ä‚¢‚éê‡‚ÍAƒf[ƒ^Ží•Ê‚àŒŸõ‚Æ‚·‚é
// * 2003/03/10 000002     ZŠ‚b‚c“™‚Ì®‡«ƒ`ƒFƒbƒN‚ÉŒë‚è
// * 2003/03/17 000003     ƒGƒ‰[ƒƒbƒZ[ƒW‚ÌŒë‚è
// * 2003/03/27 000004     ƒGƒ‰[ˆ—ƒNƒ‰ƒX‚ÌŽQÆæ‚ð"AB"ŒÅ’è‚É‚·‚é
// * 2003/03/31 000005     ®‡«ƒ`ƒFƒbƒN‚ðTrim‚µ‚½’l‚Åƒ`ƒFƒbƒN‚·‚é
// * 2003/04/11 000006     ˆ¶–¼—š—ðŽæ“¾‚ÅAŠú“ú”NŒŽ“ú=99999999‚ð‹–‚·
// * 2003/04/16 000007     ¶˜a—ï”NŒŽ“ú‚Ì“ú•tƒ`ƒFƒbƒN‚ð”’lƒ`ƒFƒbƒN‚É•ÏX
// *                       ŒŸõ—pƒJƒi‚Ì”¼ŠpƒJƒiƒ`ƒFƒbƒN‚ð‚`‚m‚jƒ`ƒFƒbƒN‚É•ÏX
// * 2003/04/30 000008     Žw’è“ú‚ª–³‚­‚Ä‚àƒGƒ‰[‚É‚µ‚È‚¢B
// * 2003/05/20 000009     ƒGƒ‰[A“ú•tƒNƒ‰ƒX‚Ì²Ý½ÀÝ½‚ðºÝ½Ä×¸À‚É•ÏX
// * 2003/06/12 000010     TOP‹å‚ðŠO‚·
// * 2003/08/28 000011     RDBƒAƒNƒZƒXƒƒO‚ÌC³
// * 2003/09/11 000012     ’[––‚h‚c®‡«ƒ`ƒFƒbƒN‚ðANK‚É‚·‚é
// * 2003/10/09 000013     ì¬ƒ†[ƒU[EXVƒ†[ƒU[ƒ`ƒFƒbƒN‚Ì•ÏX
// * 2003/10/30 000014     Žd—l•ÏXAƒJƒ^ƒJƒiƒ`ƒFƒbƒN‚ðANKƒ`ƒFƒbƒN‚É•ÏX
// * 2003/11/18 000015     Žd—l•ÏXFƒf[ƒ^‹æ•ª‚ÅŒÂl‚Ì‚ÝŽ‚Á‚Ä‚­‚éBiƒf[ƒ^‹æ•ª‚É"1%"‚ÆŽw’è‚³‚ê‚½ê‡j
// *                       Žd—l’Ç‰ÁFˆ¶–¼ŒÂ•Êƒf[ƒ^Žæ“¾ƒƒ\ƒbƒh‚ð’Ç‰Á
// * 2004/04/12 000016     Žd—l•ÏXF’¼‹ßŽ–—Rƒ`ƒFƒbƒN‚ðƒRƒƒ“ƒgƒAƒEƒg‚ÉC³
// *          @@         ’n‹æƒR[ƒh‚ðANKƒ`ƒFƒbƒN‚É•ÏX
// * 2004/10/19 000017     `‘S‘ZŠƒR[ƒh‚Ìƒ`ƒFƒbƒN‚ðCheckNumber --> CheckANK(ƒ}ƒ‹ƒS‘ºŽR)
// * 2004/11/12 000018     ƒf[ƒ^ƒ`ƒFƒbƒN‚ðs‚È‚í‚È‚¢
// * 2005/01/25 000019     ‘¬“x‰ü‘P‚QFi‹{‘òj
// * 2005/06/15 000020     SQL•¶‚ðInsert,Update,˜_—Delete,•¨—Delete‚ÌŠeƒƒ\ƒbƒh‚ªŒÄ‚Î‚ê‚½Žž‚ÉŠeŽ©ì¬‚·‚é
// * 2005/06/17 000021     —š—ð”Ô†‚Ì‚Ý‚ðŽæ“¾‚·‚éƒƒ\ƒbƒh’Ç‰Á
// * 2005/11/18 000022     Z–¯‚b‚cŽw’è(‚PZ–¯‚b‚cj‚ÅŠY“–Z–¯‚b‚c‚Ì‘S—š—ðƒf[ƒ^‚ðíœ‚·‚éˆ—‚ð’Ç‰Á(ƒ}ƒ‹ƒS‘ºŽR)
// * 2005/12/26 000023     Žd—l•ÏXFs­‹æ‚b‚c‚ðANKƒ`ƒFƒbƒN‚É•ÏX(ƒ}ƒ‹ƒS‘ºŽR)
// * 2006/07/31 000024     ”N‹àˆ¶–¼ƒQƒbƒg‡U€–Ú’Ç‰Á(‹gàV)
// * 2007/04/28 000025     ‰îŒì”Åˆ¶–¼Žæ“¾ƒƒ\ƒbƒh‚Ì’Ç‰Á‚É‚æ‚éŽæ“¾€–Ú‚Ì’Ç‰Á (‹gàV)
// * 2007/09/04 000026     ŠO‘l–{–¼—DæŒŸõ—p‚ÉŠ¿Žš–¼Ì‚Q‚ð’Ç‰Ái’†‘òj
// * 2007/10/10 000027     ŠO‘l–{–¼—DæŒŸõ‚ª‰Â”\‚ÈŽs’¬‘º‚ÍAƒJƒi–¼‚Ìæ“ª‚ª"³"‚Ì‚Æ‚«‚Í"µ"‚ÆORðŒ‚ÅŒŸõ‚·‚éi’†‘òj
// * 2008/01/17 000028     ŒÂ•ÊŽ–€ƒf[ƒ^Žæ“¾‹@”\‚ÉŒãŠú‚—îŽæ“¾ˆ—‚ð’Ç‰Ái”ä‰Ãj•ƒl[ƒ~ƒ“ƒO•ÏXi‹gàVj
// * 2010/04/16 000029     VS2008‘Î‰ži”ä‰Ãj
// * 2010/05/14 000030     –{Ð•M“ªŽÒ‹y‚Ñˆ—’âŽ~‹æ•ª‘Î‰ži”ä‰Ãj
// * 2011/05/18 000031     ŠO‘lÝ—¯î•ñŽæ“¾‹æ•ª‘Î‰ži”ä‰Ãj
// * 2011/10/24 000032     yAB17010zƒZŠî–@‰ü³‘Î‰ž„ˆ¶–¼—š—ð•tƒ}ƒXƒ^’Ç‰Á   (¬¼)
// * 2014/04/28 000033     yAB21040zƒ‹¤’Ê”Ô†‘Î‰ž„‹¤’Ê”Ô†ƒ}ƒXƒ^’Ç‰ÁiÎ‡j
// * 2014/06/05 000034     yAB21040-00zƒ‹¤’Ê”Ô†‘Î‰ž„ŒÂ•ÊŽæ“¾ƒƒ\ƒbƒh‚Ì‘Î‰ž˜R‚ê‰üCiÎ‡j
// * 2015/05/08 000035     yAB21052zƒ‹¤’Ê”Ô†‘Î‰ž„ŒÂl”Ô†ˆêÄŽæ“¾—š—ðŽæ“¾ƒƒ\ƒbƒh’Ç‰ÁiŠâ‰ºj
// * 2020/01/10 000036     yAB32001zƒAƒ‹ƒtƒ@ƒxƒbƒgŒŸõiÎ‡j
// * 2023/03/10 000037     yAB-0970-1zˆ¶–¼GETŽæ“¾€–Ú•W€‰»‘Î‰ži’‡¼j
// * 2023/08/14 000038     yAB-0820-1zZ“oŠOŠÇ—€–Ú’Ç‰Á(‘è)
// * 2023/10/19 000039     yAB-0820-1zZ“oŠOŠÇ—€–Ú’Ç‰Á_’Ç‰ÁC³(’‡¼)
// * 2023/12/04 000040     yAB-1600-1zŒŸõ‹@”\‘Î‰ž(‰º‘º)
// * 2023/12/07 000041     yAB-9000-1zZŠîXV˜AŒg•W€‰»‘Î‰ž(‰º‘º)
// ************************************************************************************************
using System;
using System.Data;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Densan.Reams.AB.AB000BB
{

    // ************************************************************************************************
    // *
    // * ˆ¶–¼—š—ðƒ}ƒXƒ^Žæ“¾Žž‚ÉŽg—p‚·‚éƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
    // *
    // ************************************************************************************************
    public class ABAtenaRirekiBClass
    {
        #region ƒƒ“
        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private UFErrorClass m_cfErrorClass;                  // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private UFDateClass m_cfDateClass;                    // “ú•tƒNƒ‰ƒX
        private string m_strInsertSQL;                        // INSERT—pSQL
        private string m_strUpdateSQL;                        // UPDATE—pSQL
        private string m_strDelRonriSQL;                      // ˜_—íœ—pSQL
        private string m_strDelButuriSQL;                     // •¨—íœ—pSQL
                                                              // * —š—ð”Ô† 000022 2005/11/18 ’Ç‰ÁŠJŽn
        private string m_strDelFromJuminCDSQL;                // •¨—íœ—pSQL(‚PZ–¯ƒR[ƒhŽw’è)
                                                              // * —š—ð”Ô† 000022 2005/11/18 ’Ç‰ÁI—¹
        private UFParameterCollectionClass m_cfSelectUFParameterCollectionClass;      // SELECT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;      // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateUFParameterCollectionClass;      // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDelRonriUFParameterCollectionClass;    // ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDelButuriUFParameterCollectionClass;   // •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
                                                                                      // * —š—ð”Ô† 000022 2005/11/18 ’Ç‰ÁŠJŽn
        private UFParameterCollectionClass m_cfDelFromJuminCDPrmCollection;           // •¨—íœ—pSQL(‚PZ–¯ƒR[ƒhŽw’è)
                                                                                      // * —š—ð”Ô† 000022 2005/11/18 ’Ç‰ÁI—¹

        // * —š—ð”Ô† 000019 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
        private StringBuilder m_strAtenaSQLsbAll = new StringBuilder();
        private StringBuilder m_strAtenaSQLsbKaniAll = new StringBuilder();
        private StringBuilder m_strAtenaSQLsbKaniOnly = new StringBuilder();
        private StringBuilder m_strAtenaSQLsbNenkinAll = new StringBuilder();
        private StringBuilder m_strKobetuSQLsbAll = new StringBuilder();
        private StringBuilder m_strKobetuSQLsbKaniAll = new StringBuilder();
        private StringBuilder m_strKobetuSQLsbKaniOnly = new StringBuilder();
        private StringBuilder m_strKobetuSQLsbNenkinAll = new StringBuilder();
        private DataSet m_csDataSchma;   // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private DataSet m_csDataSchmaKobetu;   // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private DataSet m_csDataSchmaAll;   // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private DataSet m_csDataSchmaKaniAll;   // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private DataSet m_csDataSchmaKaniOnly;   // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private DataSet m_csDataSchmaNenkinAll;   // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private DataSet m_csDataSchmaKobetuAll;   // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private DataSet m_csDataSchmaKobetuKaniAll;   // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private DataSet m_csDataSchmaKobetuKaniOnly;   // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private DataSet m_csDataSchmaKobetuNenkinAll;   // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        public ABEnumDefine.AtenaGetKB m_blnSelectAll = ABEnumDefine.AtenaGetKB.SelectAll; // ‘S€–Ú‘I‘ðim_blnAtenaGet‚ªTrue‚ÌŽžˆ¶–¼Get‚Å•K—v‚È€–Ú‘S‚Ä‚»‚êˆÈŠO‚ÍSELECT *j
        public bool m_blnSelectCount = false;            // ƒJƒEƒ“ƒg‚ðŽæ“¾‚·‚é‚©‚Ç‚¤‚©
        public bool m_blnBatch = false;               // ƒoƒbƒ`ƒtƒ‰ƒO
                                                      // * —š—ð”Ô† 000019 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj

        // *—š—ð”Ô† 000025 2007/04/28 ’Ç‰ÁŠJŽn
        public ABEnumDefine.MethodKB m_blnMethodKB;  // ƒƒ\ƒbƒh‹æ•ªi’Êí”Å‚©A‰îŒì”ÅAAAj
                                                     // *—š—ð”Ô† 000025 2007/04/28 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000028 2008/01/17 ’Ç‰ÁŠJŽn
        public string m_strKobetsuShutokuKB;                  // ŒÂ•ÊŽ–€Žæ“¾‹æ•ª
                                                              // *—š—ð”Ô† 000028 2008/01/17 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000030 2010/05/14 ’Ç‰ÁŠJŽn
        private string m_strHonsekiHittoshKB = string.Empty;          // –{Ð•M“ªŽÒŽæ“¾‹æ•ª(ˆ¶–¼ŠÇ—î•ñ)
        private string m_strShoriteishiKB = string.Empty;             // ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ª(ˆ¶–¼ŠÇ—î•ñ)
        private string m_strHonsekiHittoshKB_Param = string.Empty;    // –{Ð•M“ªŽÒŽæ“¾‹æ•ªƒpƒ‰ƒ[ƒ^
        private string m_strShoriTeishiKB_Param = string.Empty;       // ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ªƒpƒ‰ƒ[ƒ^
                                                                      // *—š—ð”Ô† 000030 2010/05/14 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000031 2011/05/18 ’Ç‰ÁŠJŽn
        private string m_strFrnZairyuJohoKB_Param = string.Empty;     // ŠO‘lÝ—¯î•ñŽæ“¾‹æ•ªƒpƒ‰ƒ[ƒ^
                                                                      // *—š—ð”Ô† 000031 2011/05/18 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
        private ABSekoYMDHanteiBClass m_csSekoYMDHanteiB;             // Ž{s“ú”»’èB¸×½
        private ABAtenaRirekiFZYBClass m_csAtenaRirekiFZYB;                // ˆ¶–¼•tƒ}ƒXƒ^B¸×½
        private bool m_blnJukihoKaiseiFG = false;
        private string m_strJukihoKaiseiKB;                           // ZŠî–@‰ü³‹æ•ª
                                                                      // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
        private string m_strMyNumberKB_Param;                         // ‹¤’Ê”Ô†Žæ“¾‹æ•ª
        private string m_strMyNumberChokkinSearchKB_Param;            // ‹¤’Ê”Ô†’¼‹ßŒŸõ‹æ•ª
                                                                      // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000036 2020/01/10 ’Ç‰ÁŠJŽn
        private ABKensakuShimeiBClass m_cKensakuShimeiB;              // ŒŸõŽ–¼•ÒWƒrƒWƒlƒXƒNƒ‰ƒX
                                                                      // *—š—ð”Ô† 000036 2020/01/10 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000038 2023/08/14 ’Ç‰ÁŠJŽn
        private ABAtenaRireki_HyojunBClass m_csAtenaRirekiHyojunB;            // ˆ¶–¼—š—ð_•W€ƒ}ƒXƒ^B¸×½
        private ABAtenaRirekiFZY_HyojunBClass m_csAtenaRirekiFZYHyojunB;      // ˆ¶–¼—š—ð•t_•W€ƒ}ƒXƒ^B¸×½
                                                                              // *—š—ð”Ô† 000038 2023/08/14 ’Ç‰ÁI—¹

        public ABEnumDefine.HyojunKB m_intHyojunKB;                   // ˆ¶–¼GET•W€‰»‹æ•ª

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABAtenaRirekiBClass";                 // ƒNƒ‰ƒX–¼
        private const string THIS_BUSINESSID = "AB";                                  // ‹Æ–±ƒR[ƒh

        private const string JUKIHOKAISEIKB_ON = "1";

        #endregion

        // *—š—ð”Ô† 000030 2010/05/14 ’Ç‰ÁŠJŽn
        #region ƒvƒƒpƒeƒB
        public string p_strHonsekiHittoshKB     // –{Ð•M“ªŽÒŽæ“¾‹æ•ª
        {
            set
            {
                m_strHonsekiHittoshKB_Param = value;
            }
        }
        public string p_strShoriteishiKB        // ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ª
        {
            set
            {
                m_strShoriTeishiKB_Param = value;
            }
        }

        // *—š—ð”Ô† 000031 2011/05/18 ’Ç‰ÁŠJŽn
        public string p_strFrnZairyuJohoKB      // ŠO‘lÝ—¯Ž‘Šiî•ñŽæ“¾‹æ•ª
        {
            set
            {
                m_strFrnZairyuJohoKB_Param = value;
            }
        }
        // *—š—ð”Ô† 000031 2011/05/18 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
        public string p_strJukihoKaiseiKB      // ZŠî–@‰ü³‹æ•ª
        {
            set
            {
                m_strJukihoKaiseiKB = value;
            }
        }
        // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
        public string p_strMyNumberKB                     // ‹¤’Ê”Ô†Žæ“¾‹æ•ª
        {
            get
            {
                return m_strMyNumberKB_Param;
            }
            set
            {
                m_strMyNumberKB_Param = value;
            }
        }
        // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

        #endregion
        // *—š—ð”Ô† 000030 2010/05/14 ’Ç‰ÁI—¹

        #region ƒRƒ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // * @@                          ByVal cfConfigDataClass As UFConfigDataClass, 
        // * @@                          ByVal cfRdbClass As UFRdbClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABAtenaRirekiBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigDataClass;
            m_cfRdbClass = cfRdbClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(m_cfConfigDataClass, m_cfControlData.m_strBusinessId);

            // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
            m_strInsertSQL = string.Empty;
            m_strUpdateSQL = string.Empty;
            m_strDelRonriSQL = string.Empty;
            m_strDelButuriSQL = string.Empty;
            // * —š—ð”Ô† 000022 2005/11/18 ’Ç‰ÁŠJŽn
            m_strDelFromJuminCDSQL = string.Empty;
            // * —š—ð”Ô† 000022 2005/11/18 ’Ç‰ÁI—¹
            m_cfSelectUFParameterCollectionClass = (object)null;
            m_cfInsertUFParameterCollectionClass = (object)null;
            m_cfUpdateUFParameterCollectionClass = (object)null;
            m_cfDelRonriUFParameterCollectionClass = (object)null;
            m_cfDelButuriUFParameterCollectionClass = (object)null;
            // * —š—ð”Ô† 000022 2005/11/18 ’Ç‰ÁŠJŽn
            m_cfDelFromJuminCDPrmCollection = (object)null;
            // * —š—ð”Ô† 000022 2005/11/18 ’Ç‰ÁI—¹

            // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
            // ZŠî–@‰ü³‹æ•ª‰Šú‰»
            m_strJukihoKaiseiKB = string.Empty;
            // ZŠî–@‰ü³Ì×¸ÞŽæ“¾
            GetJukihoKaiseiFG();
            // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

            // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
            // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‰Šú‰»
            m_strMyNumberKB_Param = string.Empty;
            // ‹¤’Ê”Ô†@ˆ¶–¼Žæ“¾@’¼‹ßŒŸõ‹æ•ªŽæ“¾
            this.GetMyNumberChokkinSearchKB();
            // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

            // *—š—ð”Ô† 000036 2020/01/10 ’Ç‰ÁŠJŽn
            // ŒŸõŽ–¼•ÒWƒrƒWƒlƒXƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cKensakuShimeiB = new ABKensakuShimeiBClass(m_cfControlData, m_cfConfigDataClass);
            // *—š—ð”Ô† 000036 2020/01/10 ’Ç‰ÁI—¹

        }
        // * —š—ð”Ô† 000019 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // * @@                          ByVal cfConfigDataClass As UFConfigDataClass, 
        // * @@                          ByVal cfRdbClass As UFRdbClass)
        // * @@                          ByVal blnSelectAll As Boolean, _
        // * @@                          ByVal blnAtenaGet As Boolean)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * @@           blnSelectAll As Boolean                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * @@           blnAtenaGet As Boolean                 : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // *                ƒtƒ‰ƒO‚Ì‘g‚Ý‡‚í‚¹à–¾
        // *                            blnSelectAll binAtenaGet
        // *                              True         True       ˆ¶–¼Getê—p‚Ì€–Ú‚ð‘S‚ÄŽæ“¾i‘ã”[lA‘—•tæA˜A—æŒ”‚ðŠÜ‚Þj
        // *                              True         False      ˆ¶–¼€–Ú‚ð‘S‚Ä“Ç‚Ýž‚ÞiŒ»s‚Ì“Ç‚Ý•ûji‘ã”[lA‘—•tæA˜A—æŒ”‚ðŠÜ‚Ü‚È‚¢jiƒfƒtƒHƒ‹ƒgÝ’èj
        // *                              False        True       ˆ¶–¼Getê—p‚Ì€–Ú‚ÅŠÈˆÕ“I‚È€–Ú‚Ì‚Ýi‘ã”[lA‘—•tæA˜A—æŒ”‚ðŠÜ‚Þj
        // *                              False        False      ŠÈˆÕ“I‚È€–Ú‚Ì‚Ýi‘ã”[lA‘—•tæA˜A—æŒ”‚ðŠÜ‚Ü‚È‚¢j
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABAtenaRirekiBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass, ABEnumDefine.AtenaGetKB blnSelectAll, bool blnSelectCount)



        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigDataClass;
            m_cfRdbClass = cfRdbClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(m_cfConfigDataClass, m_cfControlData.m_strBusinessId);

            // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
            m_strInsertSQL = string.Empty;
            m_strUpdateSQL = string.Empty;
            m_strDelRonriSQL = string.Empty;
            m_strDelButuriSQL = string.Empty;
            // * —š—ð”Ô† 000022 2005/11/18 ’Ç‰ÁŠJŽn
            m_strDelFromJuminCDSQL = string.Empty;
            // * —š—ð”Ô† 000022 2005/11/18 ’Ç‰ÁI—¹
            m_cfSelectUFParameterCollectionClass = (object)null;
            m_cfInsertUFParameterCollectionClass = (object)null;
            m_cfUpdateUFParameterCollectionClass = (object)null;
            m_cfDelRonriUFParameterCollectionClass = (object)null;
            m_cfDelButuriUFParameterCollectionClass = (object)null;
            // * —š—ð”Ô† 000022 2005/11/18 ’Ç‰ÁŠJŽn
            m_cfDelFromJuminCDPrmCollection = (object)null;
            // * —š—ð”Ô† 000022 2005/11/18 ’Ç‰ÁI—¹
            m_blnSelectAll = blnSelectAll;
            m_blnSelectCount = blnSelectCount;

            // *—š—ð”Ô† 000030 2010/05/14 ’Ç‰ÁŠJŽn
            // ŠÇ—î•ñŽæ“¾ˆ—
            GetKanriJoho();
            // *—š—ð”Ô† 000030 2010/05/14 ’Ç‰ÁI—¹

            // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
            // ZŠî–@‰ü³‹æ•ª‰Šú‰»
            m_strJukihoKaiseiKB = string.Empty;

            // ZŠî–@‰ü³Ì×¸ÞŽæ“¾
            GetJukihoKaiseiFG();
            // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

            // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
            // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‰Šú‰»
            m_strMyNumberKB_Param = string.Empty;
            // ‹¤’Ê”Ô†@ˆ¶–¼Žæ“¾@’¼‹ßŒŸõ‹æ•ªŽæ“¾
            this.GetMyNumberChokkinSearchKB();
            // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

            // *—š—ð”Ô† 000036 2020/01/10 ’Ç‰ÁŠJŽn
            // ŒŸõŽ–¼•ÒWƒrƒWƒlƒXƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cKensakuShimeiB = new ABKensakuShimeiBClass(m_cfControlData, m_cfConfigDataClass);
            // *—š—ð”Ô† 000036 2020/01/10 ’Ç‰ÁI—¹

        }
        // * —š—ð”Ô† 000019 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj
        #endregion

        #region ƒƒ\ƒbƒh
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetAtenaRBHoshu(ByVal intGetCount As Integer, _
        // *                                                ByVal cSearchKey As ABAtenaSearchKey, _
        // *                                                ByVal strKikanYMD As String) As DataSet
        // * 
        // * ‹@”\@@    @@Z“oŠOƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           intGetCount   : Žæ“¾Œ”
        // *                  cSearchKey    : ˆ¶–¼—š—ðƒ}ƒXƒ^ŒŸõƒL[
        // *                  strKikanYMD   : ŠúŠÔ”NŒŽ“ú
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½ˆ¶–¼—š—ðƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetAtenaRBHoshu(int intGetCount, ABAtenaSearchKey cSearchKey, string strKikanYMD)

        {
            return GetAtenaRBHoshu(intGetCount, cSearchKey, strKikanYMD, false);
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetAtenaRBHoshu(ByVal intGetCount As Integer, _
        // *                                                ByVal cSearchKey As ABAtenaSearchKey, _
        // *                                                ByVal strKikanYMD As String, _
        // *                                                ByVal blnSakujoKB As Boolean) As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼—š—ðƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           intGetCount   : Žæ“¾Œ”
        // * @@           cSearchKey    : ˆ¶–¼—š—ðƒ}ƒXƒ^ŒŸõƒL[
        // * @@           strKikanYMD   : ŠúŠÔ”NŒŽ“ú
        // * @@           blnSakujoKB   : íœ‹æ•ª
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½ˆ¶–¼—š—ðƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetAtenaRBHoshu(int intGetCount, ABAtenaSearchKey cSearchKey, string strKikanYMD, bool blnSakujoFG)


        {
            const string THIS_METHOD_NAME = "GetAtenaRBHoshu";
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            DataSet csAtenaRirekiEntity;                  // ˆ¶–¼—š—ðƒf[ƒ^ƒZƒbƒg
            var strSQL = new StringBuilder();
            string strWHERE;
            StringBuilder strORDER;
            int intMaxRows;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // “ú•tƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                if (m_cfDateClass == null)
                {
                    m_cfDateClass = new UFDateClass(m_cfConfigDataClass);
                    // “ú•tƒNƒ‰ƒX‚Ì•K—v‚ÈÝ’è‚ðs‚¤
                    m_cfDateClass.p_enDateSeparator = UFDateSeparator.None;
                }

                // ˆø”‚Ìƒ`ƒFƒbƒN‚ðs‚È‚¤

                // Žæ“¾Œ”‚Ìƒ`ƒFƒbƒN
                if (intGetCount < 0 | intGetCount > 999)                // Žæ“¾Œ”‚ÌŒë‚è
                {
                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002001);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                }


                // Šú“ú”NŒŽ“ú‚Ìƒ`ƒFƒbƒN
                if (!(strKikanYMD == "99999999" | string.IsNullOrEmpty(strKikanYMD)))
                {
                    m_cfDateClass.p_enDateSeparator = UFDateSeparator.None;
                    m_cfDateClass.p_strDateValue = strKikanYMD;
                    if (!m_cfDateClass.CheckDate())
                    {
                        m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                        // ƒGƒ‰[’è‹`‚ðŽæ“¾
                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_PARA_KIKANYMD);
                        // —áŠO‚ð¶¬
                        throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                    }
                }

                // ˆ¶–¼ŒŸõƒL[‚Ìƒ`ƒFƒbƒN
                // ‚È‚µ

                // SQL•¶‚Ìì¬
                // * C³”Ô† 000010 2003/06/12 C³ŠJŽn
                // If intGetCount = 0 Then
                // strSQL = "SELECT TOP 100 * FROM " + ABAtenaRirekiEntity.TABLE_NAME
                // Else
                // strSQL = "SELECT TOP " + intGetCount.ToString + " * FROM " + ABAtenaRirekiEntity.TABLE_NAME
                // End If

                // p_intMaxRows‚ð‘Þ”ð‚·‚é
                intMaxRows = m_cfRdbClass.p_intMaxRows;
                if (intGetCount == 0)
                {
                    m_cfRdbClass.p_intMaxRows = 100;
                }
                else
                {
                    m_cfRdbClass.p_intMaxRows = intGetCount;
                }
                // *—š—ð”Ô† 000011 2003/08/28 C³ŠJŽn
                // strSQL = "SELECT * FROM " + ABAtenaRirekiEntity.TABLE_NAME

                // * —š—ð”Ô† 000019 2005/01/25 XVŠJŽni‹{‘òj
                // strSQL.Append("SELECT * FROM ").Append(ABAtenaRirekiEntity.TABLE_NAME)
                switch (m_blnSelectAll)
                {
                    case var @case when @case == ABEnumDefine.AtenaGetKB.KaniAll:
                        {
                            if (m_strAtenaSQLsbKaniAll.RLength == 0)
                            {
                                m_strAtenaSQLsbKaniAll.Append("SELECT ");
                                SetAtenaEntity(m_strAtenaSQLsbKaniAll);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaCountEntity(m_strAtenaSQLsbKaniAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYEntity(m_strAtenaSQLsbKaniAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strAtenaSQLsbKaniAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetHyojunEntity(m_strAtenaSQLsbKaniAll);
                                    SetFZYHyojunEntity(m_strAtenaSQLsbKaniAll);
                                    SetFugenjuEntity(m_strAtenaSQLsbKaniAll);
                                    SetDenshiShomeishoMSTEntity(m_strAtenaSQLsbKaniAll);
                                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                    {
                                        SetMyNumberHyojunEntity(m_strAtenaSQLsbKaniAll);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }

                                m_strAtenaSQLsbKaniAll.Append(" FROM ");
                                m_strAtenaSQLsbKaniAll.Append(ABAtenaRirekiEntity.TABLE_NAME);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strAtenaSQLsbKaniAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYJoin(m_strAtenaSQLsbKaniAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strAtenaSQLsbKaniAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetHyojunJoin(m_strAtenaSQLsbKaniAll);
                                    SetFZYHyojunJoin(m_strAtenaSQLsbKaniAll);
                                    SetFugenjuJoin(m_strAtenaSQLsbKaniAll);
                                    SetDenshiShomeishoMSTJoin(m_strAtenaSQLsbKaniAll);
                                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                    {
                                        SetMyNumberHyojunJoin(m_strAtenaSQLsbKaniAll);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }

                            }
                            strSQL.Append(m_strAtenaSQLsbKaniAll);
                            if (m_csDataSchmaKaniAll is null)
                            {
                                m_csDataSchmaKaniAll = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaRirekiEntity.TABLE_NAME, false);
                            }
                            m_csDataSchma = m_csDataSchmaKaniAll;
                            break;
                        }
                    case var case1 when case1 == ABEnumDefine.AtenaGetKB.KaniOnly:
                        {
                            if (m_strAtenaSQLsbKaniOnly.RLength == 0)
                            {
                                m_strAtenaSQLsbKaniOnly.Append("SELECT ");
                                SetAtenaEntity(m_strAtenaSQLsbKaniOnly);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaCountEntity(m_strAtenaSQLsbKaniOnly);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYEntity(m_strAtenaSQLsbKaniOnly);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strAtenaSQLsbKaniOnly);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetHyojunEntity(m_strAtenaSQLsbKaniOnly);
                                    SetFZYHyojunEntity(m_strAtenaSQLsbKaniOnly);
                                    SetFugenjuEntity(m_strAtenaSQLsbKaniOnly);
                                    SetDenshiShomeishoMSTEntity(m_strAtenaSQLsbKaniOnly);
                                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                    {
                                        SetMyNumberHyojunEntity(m_strAtenaSQLsbKaniOnly);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }

                                m_strAtenaSQLsbKaniOnly.Append(" FROM ");
                                m_strAtenaSQLsbKaniOnly.Append(ABAtenaRirekiEntity.TABLE_NAME);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strAtenaSQLsbKaniOnly);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYJoin(m_strAtenaSQLsbKaniOnly);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strAtenaSQLsbKaniOnly);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetHyojunJoin(m_strAtenaSQLsbKaniOnly);
                                    SetFZYHyojunJoin(m_strAtenaSQLsbKaniOnly);
                                    SetFugenjuJoin(m_strAtenaSQLsbKaniOnly);
                                    SetDenshiShomeishoMSTJoin(m_strAtenaSQLsbKaniOnly);
                                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                    {
                                        SetMyNumberHyojunJoin(m_strAtenaSQLsbKaniOnly);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }

                            }
                            strSQL.Append(m_strAtenaSQLsbKaniOnly);
                            if (m_csDataSchmaKaniOnly is null)
                            {
                                m_csDataSchmaKaniOnly = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaRirekiEntity.TABLE_NAME, false);
                            }
                            m_csDataSchma = m_csDataSchmaKaniOnly;
                            break;
                        }
                    case var case2 when case2 == ABEnumDefine.AtenaGetKB.NenkinAll:
                        {
                            if (m_strAtenaSQLsbNenkinAll.RLength == 0)
                            {
                                m_strAtenaSQLsbNenkinAll.Append("SELECT ");
                                SetAtenaEntity(m_strAtenaSQLsbNenkinAll);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaCountEntity(m_strAtenaSQLsbNenkinAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYEntity(m_strAtenaSQLsbNenkinAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strAtenaSQLsbNenkinAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetHyojunEntity(m_strAtenaSQLsbNenkinAll);
                                    SetFZYHyojunEntity(m_strAtenaSQLsbNenkinAll);
                                    SetFugenjuEntity(m_strAtenaSQLsbNenkinAll);
                                    SetDenshiShomeishoMSTEntity(m_strAtenaSQLsbNenkinAll);
                                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                    {
                                        SetMyNumberHyojunEntity(m_strAtenaSQLsbNenkinAll);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }

                                m_strAtenaSQLsbNenkinAll.Append(" FROM ");
                                m_strAtenaSQLsbNenkinAll.Append(ABAtenaRirekiEntity.TABLE_NAME);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strAtenaSQLsbNenkinAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYJoin(m_strAtenaSQLsbNenkinAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strAtenaSQLsbNenkinAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetHyojunJoin(m_strAtenaSQLsbNenkinAll);
                                    SetFZYHyojunJoin(m_strAtenaSQLsbNenkinAll);
                                    SetFugenjuJoin(m_strAtenaSQLsbNenkinAll);
                                    SetDenshiShomeishoMSTJoin(m_strAtenaSQLsbNenkinAll);
                                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                    {
                                        SetMyNumberHyojunJoin(m_strAtenaSQLsbNenkinAll);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }

                            }
                            strSQL.Append(m_strAtenaSQLsbNenkinAll);
                            if (m_csDataSchmaNenkinAll is null)
                            {
                                m_csDataSchmaNenkinAll = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaRirekiEntity.TABLE_NAME, false);
                            }
                            m_csDataSchma = m_csDataSchmaNenkinAll;
                            break;
                        }

                    default:
                        {
                            if (m_strAtenaSQLsbAll.RLength == 0)
                            {
                                m_strAtenaSQLsbAll.Append("SELECT ");
                                // Œ»s
                                m_strAtenaSQLsbAll.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".*");

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaCountEntity(m_strAtenaSQLsbAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYEntity(m_strAtenaSQLsbAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strAtenaSQLsbAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetHyojunEntity(m_strAtenaSQLsbAll);
                                    SetFZYHyojunEntity(m_strAtenaSQLsbAll);
                                    if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_Kaigo)
                                    {
                                        SetFugenjuEntity(m_strAtenaSQLsbAll);
                                        SetDenshiShomeishoMSTEntity(m_strAtenaSQLsbAll);
                                    }
                                    else
                                    {
                                    }
                                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                    {
                                        SetMyNumberHyojunEntity(m_strAtenaSQLsbAll);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }

                                m_strAtenaSQLsbAll.Append(" FROM ");
                                m_strAtenaSQLsbAll.Append(ABAtenaRirekiEntity.TABLE_NAME);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strAtenaSQLsbAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYJoin(m_strAtenaSQLsbAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strAtenaSQLsbAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetHyojunJoin(m_strAtenaSQLsbAll);
                                    SetFZYHyojunJoin(m_strAtenaSQLsbAll);
                                    if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_Kaigo)
                                    {
                                        SetFugenjuJoin(m_strAtenaSQLsbAll);
                                        SetDenshiShomeishoMSTJoin(m_strAtenaSQLsbAll);
                                    }
                                    else
                                    {
                                    }
                                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                    {
                                        SetMyNumberHyojunJoin(m_strAtenaSQLsbAll);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }

                            }
                            strSQL.Append(m_strAtenaSQLsbAll);
                            if (m_csDataSchmaAll is null)
                            {
                                m_csDataSchmaAll = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaRirekiEntity.TABLE_NAME, false);
                            }
                            m_csDataSchma = m_csDataSchmaAll;
                            break;
                        }
                }
                // If (m_strAtenaSQLsb.Length = 0) Then
                // m_strAtenaSQLsb.Append("SELECT ")
                // Select Case (Me.m_blnSelectAll)
                // Case ABEnumDefine.AtenaGetKB.SelectAll
                // 'Œ»s
                // m_strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".*")
                // Case ABEnumDefine.AtenaGetKB.KaniAll
                // Call SetAtenaEntity(m_strAtenaSQLsb)
                // Case ABEnumDefine.AtenaGetKB.KaniOnly
                // Call SetAtenaEntity(m_strAtenaSQLsb)
                // Case Else
                // 'Œ»s
                // m_strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".*")
                // End Select

                // '‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                // Call SetAtenaCountEntity(m_strAtenaSQLsb)

                // m_strAtenaSQLsb.Append(" FROM ")
                // m_strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME)

                // '‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                // Call SetAtenaJoin(m_strAtenaSQLsb)
                // End If
                // strSQL.Append(m_strAtenaSQLsb)
                // '* —š—ð”Ô† 000019 2005/01/25 XVI—¹i‹{‘òj

                // '* —š—ð”Ô† 000014 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
                // If (m_csDataSchma Is Nothing) Then
                // m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString, ABAtenaRirekiEntity.TABLE_NAME, False)
                // End If
                // * —š—ð”Ô† 000014 2004/08/27 ’Ç‰ÁI—¹

                // *—š—ð”Ô† 000011 2003/08/28 C³I—¹
                // * C³”Ô† 000010 2003/06/12 C³I—¹

                // WHERE‹å‚Ìì¬
                strWHERE = CreateWhere(cSearchKey, strKikanYMD);

                // íœƒtƒ‰ƒO
                if (blnSakujoFG == false)
                {
                    if (!string.IsNullOrEmpty(strWHERE))
                    {
                        strWHERE += " AND ";
                    }
                    strWHERE += ABAtenaRirekiEntity.TABLE_NAME + "." + ABAtenaRirekiEntity.SAKUJOFG + " <> '1'";
                }

                // ORDER‹å‚ðŒ‹‡
                strORDER = new StringBuilder();
                if (cSearchKey.p_strJuminYuseniKB == "1" & !(cSearchKey.p_strStaiCD == string.Empty))
                {
                    strORDER.Append(" ORDER BY ");
                    strORDER.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINHYOHYOJIJUN);
                    strORDER.Append(" ASC;");
                }
                else if (!(cSearchKey.p_strUmareYMD == string.Empty))
                {
                    strORDER.Append(" ORDER BY ");
                    strORDER.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.UMAREYMD);
                    strORDER.Append(" ASC,");
                    strORDER.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD);
                    strORDER.Append(" ASC;");
                }
                else
                {
                    strORDER.Append(" ORDER BY ");
                    strORDER.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEARCHKANASEIMEI);
                    strORDER.Append(" ASC,");
                    strORDER.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD);
                    strORDER.Append(" ASC;");
                }

                // *—š—ð”Ô† 000011 2003/08/28 C³ŠJŽn
                // If strWHERE = String.Empty Then
                // strSQL += strORDER.ToString
                // Else
                // strSQL += " WHERE " + strWHERE + strORDER.ToString
                // End If

                if (!string.IsNullOrEmpty(strWHERE))
                {
                    strSQL.Append(" WHERE ").Append(strWHERE);
                }
                strSQL.Append(strORDER);
                // *—š—ð”Ô† 000011 2003/08/28 C³I—¹

                // *—š—ð”Ô† 000011 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + strSQL + "z")

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // '* —š—ð”Ô† 000019 2005/01/25 XVŠJŽni‹{‘òjIf •¶‚ÅˆÍ‚Þ
                // If (m_blnBatch = False) Then
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, m_cfSelectUFParameterCollectionClass) + "z")
                // End If
                // '* —š—ð”Ô† 000019 2005/01/25 XVI—¹i‹{‘òjIf •¶‚ÅˆÍ‚Þ
                // *—š—ð”Ô† 000011 2003/08/28 C³I—¹

                // *—š—ð”Ô† 000011 2003/08/28 C³ŠJŽn
                // ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                // csAtenaRirekiEntity = m_cfRdbClass.GetDataSet(strSQL, ABAtenaRirekiEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass)

                // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                // * —š—ð”Ô† 000019 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
                // csAtenaRirekiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, ABAtenaRirekiEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass)
                csAtenaRirekiEntity = m_csDataSchma.Clone();
                csAtenaRirekiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csAtenaRirekiEntity, ABAtenaRirekiEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);
                // * —š—ð”Ô† 000019 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj


                // *—š—ð”Ô† 000011 2003/08/28 C³I—¹

                // MaxRows’l‚ð–ß‚·
                m_cfRdbClass.p_intMaxRows = intMaxRows;

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLogClass.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


#error Cannot convert LiteralExpressionSyntax - see comment for details
      /* Cannot convert LiteralExpressionSyntax, System.ArgumentOutOfRangeException: Length cannot be less than zero.
       Parameter name: length
          at System.String.Substring(Int32 startIndex, Int32 length)
          at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetQuotedStringTextForUser(String textForUser, String valueTextForCompiler)
          at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetLiteralExpression(Object value, String textForUser, ITypeSymbol convertedType)
          at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitLiteralExpression>d__43.MoveNext()
       --- End of stack trace from previous location where exception was thrown ---
          at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
          at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__12`1.MoveNext()

       Input:
       "yƒ[ƒjƒ“
        */
        );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 51672


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 51770


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 52040


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 52125


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csAtenaRirekiEntity;

        }

        // *—š—ð”Ô† 000015 2003/11/18 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetAtenaRBHoshu(ByVal intGetCount As Integer, _
        // *                                                ByVal cSearchKey As ABAtenaSearchKey, _
        // *                                                ByVal strKikanYMD As String, _
        // *                                                ByVal strJuminJutogaiKB As String, _
        // *                                                ByVal blnSakujoKB As Boolean) As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼—š—ðƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éiZŠîƒf[ƒ^XV—pj
        // * 
        // * ˆø”           intGetCount   : Žæ“¾Œ”
        // * @@           cSearchKey    : ˆ¶–¼—š—ðƒ}ƒXƒ^ŒŸõƒL[
        // * @@           strKikanYMD   : ŠúŠÔ”NŒŽ“ú
        // * @@           strJuminJutogaiKB : Z–¯Z“oŠO‹æ•ª
        // * @@           blnSakujoKB   : íœ‹æ•ª
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½ˆ¶–¼—š—ðƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        internal DataSet GetAtenaRBHoshu(int intGetCount, ABAtenaSearchKey cSearchKey, string strKikanYMD, string strJuminJutogaiKB, bool blnSakujoFG)



        {
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            DataSet csAtenaRirekiEntity;                  // ˆ¶–¼—š—ðƒf[ƒ^ƒZƒbƒg
            var strSQL = new StringBuilder();
            string strWHERE;
            StringBuilder strORDER;
            int intMaxRows;
            UFParameterClass cfUFParameterClass;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name);

                // “ú•tƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                if (m_cfDateClass == null)
                {
                    m_cfDateClass = new UFDateClass(m_cfConfigDataClass);
                    // “ú•tƒNƒ‰ƒX‚Ì•K—v‚ÈÝ’è‚ðs‚¤
                    m_cfDateClass.p_enDateSeparator = UFDateSeparator.None;
                }

                // ˆø”‚Ìƒ`ƒFƒbƒN‚ðs‚È‚¤

                // Žæ“¾Œ”‚Ìƒ`ƒFƒbƒN
                if (intGetCount < 0 | intGetCount > 999)                // Žæ“¾Œ”‚ÌŒë‚è
                {
                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002001);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                }


                // Šú“ú”NŒŽ“ú‚Ìƒ`ƒFƒbƒN
                if (!(strKikanYMD == "99999999" | string.IsNullOrEmpty(strKikanYMD)))
                {
                    m_cfDateClass.p_enDateSeparator = UFDateSeparator.None;
                    m_cfDateClass.p_strDateValue = strKikanYMD;
                    if (!m_cfDateClass.CheckDate())
                    {
                        m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                        // ƒGƒ‰[’è‹`‚ðŽæ“¾
                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_PARA_KIKANYMD);
                        // —áŠO‚ð¶¬
                        throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                    }
                }

                // ˆ¶–¼ŒŸõƒL[‚Ìƒ`ƒFƒbƒN
                // ‚È‚µ

                // SQL•¶‚Ìì¬

                // p_intMaxRows‚ð‘Þ”ð‚·‚é
                intMaxRows = m_cfRdbClass.p_intMaxRows;
                if (intGetCount == 0)
                {
                    m_cfRdbClass.p_intMaxRows = 100;
                }
                else
                {
                    m_cfRdbClass.p_intMaxRows = intGetCount;
                }
                // * —š—ð”Ô† 000019 2005/01/25 XVŠJŽni‹{‘òj
                // strSQL.Append("SELECT * FROM ").Append(ABAtenaRirekiEntity.TABLE_NAME)
                switch (m_blnSelectAll)
                {
                    case var @case when @case == ABEnumDefine.AtenaGetKB.KaniAll:
                        {
                            if (m_strAtenaSQLsbKaniAll.RLength == 0)
                            {
                                m_strAtenaSQLsbKaniAll.Append("SELECT ");
                                SetAtenaEntity(m_strAtenaSQLsbKaniAll);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaCountEntity(m_strAtenaSQLsbKaniAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON)
                                {
                                    SetFZYEntity(m_strAtenaSQLsbKaniAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strAtenaSQLsbKaniAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                                m_strAtenaSQLsbKaniAll.Append(" FROM ");
                                m_strAtenaSQLsbKaniAll.Append(ABAtenaRirekiEntity.TABLE_NAME);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strAtenaSQLsbKaniAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON)
                                {
                                    SetFZYJoin(m_strAtenaSQLsbKaniAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strAtenaSQLsbKaniAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                            }
                            strSQL.Append(m_strAtenaSQLsbKaniAll);
                            if (m_csDataSchmaKaniAll is null)
                            {
                                m_csDataSchmaKaniAll = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaRirekiEntity.TABLE_NAME, false);
                            }
                            m_csDataSchma = m_csDataSchmaKaniAll;
                            break;
                        }
                    case var case1 when case1 == ABEnumDefine.AtenaGetKB.KaniOnly:
                        {
                            if (m_strAtenaSQLsbKaniOnly.RLength == 0)
                            {
                                m_strAtenaSQLsbKaniOnly.Append("SELECT ");
                                SetAtenaEntity(m_strAtenaSQLsbKaniOnly);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaCountEntity(m_strAtenaSQLsbKaniOnly);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON)
                                {
                                    SetFZYEntity(m_strAtenaSQLsbKaniOnly);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strAtenaSQLsbKaniOnly);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                                m_strAtenaSQLsbKaniOnly.Append(" FROM ");
                                m_strAtenaSQLsbKaniOnly.Append(ABAtenaRirekiEntity.TABLE_NAME);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strAtenaSQLsbKaniOnly);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON)
                                {
                                    SetFZYJoin(m_strAtenaSQLsbKaniOnly);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strAtenaSQLsbKaniOnly);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                            }
                            strSQL.Append(m_strAtenaSQLsbKaniOnly);
                            if (m_csDataSchmaKaniOnly is null)
                            {
                                m_csDataSchmaKaniOnly = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaRirekiEntity.TABLE_NAME, false);
                            }
                            m_csDataSchma = m_csDataSchmaKaniOnly;
                            break;
                        }
                    case var case2 when case2 == ABEnumDefine.AtenaGetKB.NenkinAll:
                        {
                            if (m_strAtenaSQLsbNenkinAll.RLength == 0)
                            {
                                m_strAtenaSQLsbNenkinAll.Append("SELECT ");
                                SetAtenaEntity(m_strAtenaSQLsbNenkinAll);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaCountEntity(m_strAtenaSQLsbNenkinAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON)
                                {
                                    SetFZYEntity(m_strAtenaSQLsbNenkinAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strAtenaSQLsbNenkinAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                                m_strAtenaSQLsbNenkinAll.Append(" FROM ");
                                m_strAtenaSQLsbNenkinAll.Append(ABAtenaRirekiEntity.TABLE_NAME);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strAtenaSQLsbNenkinAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON)
                                {
                                    SetFZYJoin(m_strAtenaSQLsbNenkinAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strAtenaSQLsbNenkinAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                            }
                            strSQL.Append(m_strAtenaSQLsbNenkinAll);
                            if (m_csDataSchmaNenkinAll is null)
                            {
                                m_csDataSchmaNenkinAll = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaRirekiEntity.TABLE_NAME, false);
                            }
                            m_csDataSchma = m_csDataSchmaNenkinAll;
                            break;
                        }

                    default:
                        {
                            if (m_strAtenaSQLsbAll.RLength == 0)
                            {
                                m_strAtenaSQLsbAll.Append("SELECT ");
                                // Œ»s
                                m_strAtenaSQLsbAll.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".*");

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaCountEntity(m_strAtenaSQLsbAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON)
                                {
                                    SetFZYEntity(m_strAtenaSQLsbAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strAtenaSQLsbAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                                m_strAtenaSQLsbAll.Append(" FROM ");
                                m_strAtenaSQLsbAll.Append(ABAtenaRirekiEntity.TABLE_NAME);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strAtenaSQLsbAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON)
                                {
                                    SetFZYJoin(m_strAtenaSQLsbAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strAtenaSQLsbAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                            }
                            strSQL.Append(m_strAtenaSQLsbAll);
                            if (m_csDataSchmaAll is null)
                            {
                                m_csDataSchmaAll = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaRirekiEntity.TABLE_NAME, false);
                            }
                            m_csDataSchma = m_csDataSchmaAll;
                            break;
                        }
                }
                // If (m_strAtenaSQLsb.Length = 0) Then
                // m_strAtenaSQLsb.Append("SELECT ")
                // Select Case (Me.m_blnSelectAll)
                // Case ABEnumDefine.AtenaGetKB.SelectAll
                // 'Œ»s
                // m_strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".*")
                // Case ABEnumDefine.AtenaGetKB.KaniAll
                // Call SetAtenaEntity(m_strAtenaSQLsb)
                // Case ABEnumDefine.AtenaGetKB.KaniOnly
                // Call SetAtenaEntity(m_strAtenaSQLsb)
                // Case Else
                // 'Œ»s
                // m_strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".*")
                // End Select

                // '‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                // Call SetAtenaCountEntity(m_strAtenaSQLsb)

                // m_strAtenaSQLsb.Append(" FROM ")
                // m_strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME)

                // '‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                // Call SetAtenaJoin(m_strAtenaSQLsb)
                // End If
                // strSQL.Append(m_strAtenaSQLsb)
                // If (m_csDataSchma Is Nothing) Then
                // m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString, ABAtenaRirekiEntity.TABLE_NAME, False)
                // End If
                // * —š—ð”Ô† 000019 2005/01/25 XVI—¹i‹{‘òj

                // WHERE‹å‚Ìì¬
                strWHERE = CreateWhere(cSearchKey, strKikanYMD);

                // Z–¯Z“oŠO‹æ•ª
                if (!string.IsNullOrEmpty(strJuminJutogaiKB.Trim()))
                {
                    if (!string.IsNullOrEmpty(strWHERE))
                    {
                        strWHERE += " AND ";
                    }
                    strWHERE += ABAtenaRirekiEntity.TABLE_NAME + "." + ABAtenaRirekiEntity.JUMINJUTOGAIKB + " = ";
                    strWHERE += ABAtenaRirekiEntity.PARAM_JUMINJUTOGAIKB;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_JUMINJUTOGAIKB;
                    cfUFParameterClass.Value = strJuminJutogaiKB;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);
                }

                // íœƒtƒ‰ƒO
                if (blnSakujoFG == false)
                {
                    if (!string.IsNullOrEmpty(strWHERE))
                    {
                        strWHERE += " AND ";
                    }
                    strWHERE += ABAtenaRirekiEntity.TABLE_NAME + "." + ABAtenaRirekiEntity.SAKUJOFG + " <> '1'";
                }

                // ORDER‹å‚ðŒ‹‡
                strORDER = new StringBuilder();
                strORDER.Append(" ORDER BY ");
                strORDER.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.RIREKINO);
                strORDER.Append(" DESC;");

                if (!string.IsNullOrEmpty(strWHERE))
                {
                    strSQL.Append(" WHERE ").Append(strWHERE);
                }
                strSQL.Append(strORDER);

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // '* —š—ð”Ô† 000019 2005/01/25 XVŠJŽni‹{‘òjIf •¶‚ÅˆÍ‚Þ
                // If (m_blnBatch = False) Then
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, m_cfSelectUFParameterCollectionClass) + "z")
                // End If
                // '* —š—ð”Ô† 000019 2005/01/25 XVI—¹i‹{‘òjIf •¶‚ÅˆÍ‚Þ

                // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                // * —š—ð”Ô† 000019 2005/01/25 XVŠJŽni‹{‘òj
                // csAtenaRirekiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, ABAtenaRirekiEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass)
                csAtenaRirekiEntity = m_csDataSchma.Clone();
                csAtenaRirekiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csAtenaRirekiEntity, ABAtenaRirekiEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);
                // * —š—ð”Ô† 000019 2005/01/25 XVI—¹i‹{‘òj
                // MaxRows’l‚ð–ß‚·
                m_cfRdbClass.p_intMaxRows = intMaxRows;

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }

            catch (UFAppException objAppExp)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLogClass.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + default


#error Cannot convert LiteralExpressionSyntax - see comment for details
                   /* Cannot convert LiteralExpressionSyntax, System.ArgumentOutOfRangeException: Length cannot be less than zero.
                                 Parameter name: length
                                    at System.String.Substring(Int32 startIndex, Int32 length)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetQuotedStringTextForUser(String textForUser, String valueTextForCompiler)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetLiteralExpression(Object value, String textForUser, ITypeSymbol convertedType)
                                    at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitLiteralExpression>d__43.MoveNext()
                                 --- End of stack trace from previous location where exception was thrown ---
                                    at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
                                    at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__12`1.MoveNext()

                                 Input:
                                 "yƒ[ƒjƒ“
                                  */
                     );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 74345


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 74443


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 74713


                Input:
                " + Me.GetType.Name + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 74798


                                Input:
                                " + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csAtenaRirekiEntity;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ŒÂ•Ê—š—ðƒf[ƒ^’Šo
        // * 
        // * \•¶           Friend Function GetAtenaRBKobetsu(ByVal intGetCount As Integer, _
        // *                                                  ByVal cSearchKey As ABAtenaSearchKey, _
        // *                                                  ByVal strKikanYMD As String, _
        // *                                                  ByVal blnSakujoKB As Boolean) As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼—š—ðƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           intGetCount   : Žæ“¾Œ”
        // * @@           cSearchKey    : ˆ¶–¼—š—ðƒ}ƒXƒ^ŒŸõƒL[
        // * @@           strKikanYMD   : ŠúŠÔ”NŒŽ“ú
        // * @@           blnSakujoKB   : íœ‹æ•ª
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½ˆ¶–¼—š—ðƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        // *—š—ð”Ô† 000028 2008/01/17 C³ŠJŽn
        // Friend Function GetAtenaRBKobetsu(ByVal intGetCount As Integer, _
        // ByVal cSearchKey As ABAtenaSearchKey, _
        // ByVal strKikanYMD As String, _
        // ByVal blnSakujoFG As Boolean) As DataSet
        internal DataSet GetAtenaRBKobetsu(int intGetCount, ABAtenaSearchKey cSearchKey, string strKikanYMD, bool blnSakujoFG, string strKobetsuKB)



        {
            // *—š—ð”Ô† 000028 2008/01/17 C³I—¹
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            DataSet csAtenaRirekiEntity;                  // ˆ¶–¼—š—ðƒf[ƒ^ƒZƒbƒg
            var strSQL = new StringBuilder();
            StringBuilder strWHERE;
            StringBuilder strORDER;
            int intMaxRows;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name);

                // “ú•tƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                if (m_cfDateClass == null)
                {
                    m_cfDateClass = new UFDateClass(m_cfConfigDataClass);
                    // “ú•tƒNƒ‰ƒX‚Ì•K—v‚ÈÝ’è‚ðs‚¤
                    m_cfDateClass.p_enDateSeparator = UFDateSeparator.None;
                }

                // ˆø”‚Ìƒ`ƒFƒbƒN‚ðs‚È‚¤

                // Žæ“¾Œ”‚Ìƒ`ƒFƒbƒN
                if (intGetCount < 0 | intGetCount > 999)                // Žæ“¾Œ”‚ÌŒë‚è
                {
                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002001);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                }


                // Šú“ú”NŒŽ“ú‚Ìƒ`ƒFƒbƒN
                if (!(strKikanYMD == "99999999" | string.IsNullOrEmpty(strKikanYMD)))
                {
                    m_cfDateClass.p_enDateSeparator = UFDateSeparator.None;
                    m_cfDateClass.p_strDateValue = strKikanYMD;
                    if (!m_cfDateClass.CheckDate())
                    {
                        m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                        // ƒGƒ‰[’è‹`‚ðŽæ“¾
                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_PARA_KIKANYMD);
                        // —áŠO‚ð¶¬
                        throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                    }
                }

                // *—š—ð”Ô† 000028 2008/01/17 ’Ç‰ÁŠJŽn
                // ŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ðƒƒ“ƒo•Ï”‚ÉƒZƒbƒg
                m_strKobetsuShutokuKB = strKobetsuKB.Trim();
                // *—š—ð”Ô† 000028 2008/01/17 ’Ç‰ÁI—¹

                // ˆ¶–¼ŒŸõƒL[‚Ìƒ`ƒFƒbƒN
                // ‚È‚µ

                // SQL•¶‚Ìì¬

                // p_intMaxRows‚ð‘Þ”ð‚·‚é
                intMaxRows = m_cfRdbClass.p_intMaxRows;
                if (intGetCount == 0)
                {
                    m_cfRdbClass.p_intMaxRows = 100;
                }
                else
                {
                    m_cfRdbClass.p_intMaxRows = intGetCount;
                }
                // SELECT ABATENA.*
                // * —š—ð”Ô† 000019 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                // strSQL.Append("SELECT ").Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".*")
                // ' , ABATENANENKIN.KSNENKNNO AS KSNENKNNO
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.KSNENKNNO)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KSNENKNNO)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.SKAKSHUTKYMD)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.NENKNSKAKSHUTKYMD)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.SKAKSHUTKSHU)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.NENKNSKAKSHUTKSHU)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.SKAKSHUTKRIYUCD)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.NENKNSKAKSHUTKRIYUCD)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.SKAKSSHTSYMD)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.NENKNSKAKSSHTSYMD)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.SKAKSSHTSRIYUCD)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.NENKNSKAKSSHTSRIYUCD)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKIGO1)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKIGO1)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNNO1)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNNO1)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNSHU1)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNSHU1)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNEDABAN1)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNEDABAN1)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKB1)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKB1)

                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKIGO2)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKIGO2)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNNO2)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNNO2)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNSHU2)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNSHU2)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNEDABAN2)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNEDABAN2)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKB2)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKB2)

                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKIGO3)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKIGO3)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNNO3)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNNO3)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNSHU3)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNSHU3)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNEDABAN3)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNEDABAN3)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKB3)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKB3)

                // ' ‘•Û
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHONO)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHONO)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOSHIKAKUKB)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKB)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOSHIKAKUKBMEISHO)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKBMEISHO)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOSHIKAKUKBRYAKUSHO)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKBRYAKUSHO)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOGAKUENKB)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOGAKUENKB)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOGAKUENKBMEISHO)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOGAKUENKBMEISHO)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOGAKUENKBRYAKUSHO)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOGAKUENKBRYAKUSHO)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOSHUTOKUYMD)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOSHUTOKUYMD)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOSOSHITSUYMD)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOSOSHITSUYMD)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKKB)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKKB)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKKBMEISHO)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKKBMEISHO)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKKBRYAKUSHO)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKKBRYAKUSHO)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKB)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKB)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKBMEISHO)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKBMEISHO)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKBRYAKUSHO)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKBRYAKUSHO)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKGAITOYMD)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKGAITOYMD)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKHIGAITOYMD)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKHIGAITOYMD)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOHOKENSHOKIGO)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOHOKENSHOKIGO)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOHOKENSHONO)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOHOKENSHONO)

                // ' ˆóŠÓ
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaInkanEntity.TABLE_NAME).Append(".").Append(ABAtenaInkanEntity.INKANNO)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.INKANNO)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaInkanEntity.TABLE_NAME).Append(".").Append(ABAtenaInkanEntity.INKANTOROKUKB)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.INKANTOROKUKB)

                // ' ‘I‹“
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaSenkyoEntity.TABLE_NAME).Append(".").Append(ABAtenaSenkyoEntity.SENKYOSHIKAKUKB)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.SENKYOSHIKAKUKB)

                // ' Ž™“¶Žè“–
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaJiteEntity.TABLE_NAME).Append(".").Append(ABAtenaJiteEntity.JIDOTEATEHIYOKB)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JIDOTEATEHIYOKB)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaJiteEntity.TABLE_NAME).Append(".").Append(ABAtenaJiteEntity.JIDOTEATESTYM)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JIDOTEATESTYM)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaJiteEntity.TABLE_NAME).Append(".").Append(ABAtenaJiteEntity.JIDOTEATEEDYM)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.JIDOTEATEEDYM)

                // ' ‰îŒì
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.HIHKNSHANO)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGHIHKNSHANO)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.SKAKSHUTKYMD)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGSKAKSHUTKYMD)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.SKAKSSHTSYMD)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGSKAKSSHTSYMD)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.SKAKHIHOKENSHAKB)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGSKAKHIHOKENSHAKB)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.JUSHOCHITKRIKB)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGJUSHOCHITKRIKB)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.JUKYUSHAKB)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGJUKYUSHAKB)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.YOKAIGJOTAIKBCD)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.YOKAIGJOTAIKBCD)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.KAIGSKAKKB)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGSKAKKB)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.NINTEIKAISHIYMD)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGNINTEIKAISHIYMD)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.NINTEISHURYOYMD)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGNINTEISHURYOYMD)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.JUKYUNINTEIYMD)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGJUKYUNINTEIYMD)
                // strSQL.Append(", ")
                // strSQL.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.JUKYUNINTEITORIKESHIYMD)
                // strSQL.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGJUKYUNINTEITORIKESHIYMD)
                // '  FROM ABATENA 
                // strSQL.Append(" FROM ").Append(ABAtenaRirekiEntity.TABLE_NAME)

                // ' LEFT OUTER JOIN ABATENANENKIN ON ABATENA.JUMINCD=ABATENANENKIN.JUMINCD
                // strSQL.Append(" LEFT OUTER JOIN ").Append(ABAtenaNenkinEntity.TABLE_NAME).Append(" ON ")
                // strSQL.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                // strSQL.Append("=")
                // strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JUMINCD)

                // ' LEFT OUTER JOIN ABATENAKOKUHO ON ABATENA.JUMINCD=ABATENAKOKUHO.JUMINCD
                // strSQL.Append(" LEFT OUTER JOIN ").Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(" ON ")
                // strSQL.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                // strSQL.Append("=")
                // strSQL.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.JUMINCD)

                // ' LEFT OUTER JOIN ABATENAINKAN ON ABATENA.JUMINCD=ABATENAINKAN.JUMINCD
                // strSQL.Append(" LEFT OUTER JOIN ").Append(ABAtenaInkanEntity.TABLE_NAME).Append(" ON ")
                // strSQL.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                // strSQL.Append("=")
                // strSQL.Append(ABAtenaInkanEntity.TABLE_NAME).Append(".").Append(ABAtenaInkanEntity.JUMINCD)

                // ' LEFT OUTER JOIN ABATENASENKYO ON ABATENA.JUMINCD=ABATENASENKYO.JUMINCD
                // strSQL.Append(" LEFT OUTER JOIN ").Append(ABAtenaSenkyoEntity.TABLE_NAME).Append(" ON ")
                // strSQL.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                // strSQL.Append("=")
                // strSQL.Append(ABAtenaSenkyoEntity.TABLE_NAME).Append(".").Append(ABAtenaSenkyoEntity.JUMINCD)

                // ' LEFT OUTER JOIN ABATENAJITE ON ABATENA.JUMINCD=ABATENAJIDOUTE.JUMINCD
                // strSQL.Append(" LEFT OUTER JOIN ").Append(ABAtenaJiteEntity.TABLE_NAME).Append(" ON ")
                // strSQL.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                // strSQL.Append("=")
                // strSQL.Append(ABAtenaJiteEntity.TABLE_NAME).Append(".").Append(ABAtenaJiteEntity.JUMINCD)

                // ' LEFT OUTER JOIN ABATENAKAIGO ON ABATENA.JUMINCD=ABATENAKAIGO.JUMINCD
                // strSQL.Append(" LEFT OUTER JOIN ").Append(ABAtenaKaigoEntity.TABLE_NAME).Append(" ON ")
                // strSQL.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                // strSQL.Append("=")
                // strSQL.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.JUMINCD)
                switch (m_blnSelectAll)
                {
                    case var @case when @case == ABEnumDefine.AtenaGetKB.KaniAll:
                        {
                            if (m_strKobetuSQLsbKaniAll.RLength == 0)
                            {
                                m_strKobetuSQLsbKaniAll.Append("SELECT ");
                                SetAtenaEntity(m_strKobetuSQLsbKaniAll);
                                // ŒÂ•ÊŽ–€‚Ì€–ÚƒZƒbƒg
                                SetKobetsuEntity(m_strKobetuSQLsbKaniAll);
                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaCountEntity(m_strKobetuSQLsbKaniAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYEntity(m_strKobetuSQLsbKaniAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000034 2014/06/05 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strKobetuSQLsbKaniAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000034 2014/06/05 ’Ç‰ÁI—¹

                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetHyojunEntity(m_strKobetuSQLsbKaniAll);
                                    SetFZYHyojunEntity(m_strKobetuSQLsbKaniAll);
                                    SetFugenjuEntity(m_strKobetuSQLsbKaniAll);
                                    SetDenshiShomeishoMSTEntity(m_strKobetuSQLsbKaniAll);
                                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                    {
                                        SetMyNumberHyojunEntity(m_strKobetuSQLsbKaniAll);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }

                                // FROM ABATENA 
                                m_strKobetuSQLsbKaniAll.Append(" FROM ").Append(ABAtenaRirekiEntity.TABLE_NAME);
                                // ŒÂ•ÊŽ–€‚ÌJOIN‹å‚ðì¬
                                SetKobetsuJoin(m_strKobetuSQLsbKaniAll);
                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strKobetuSQLsbKaniAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYJoin(m_strKobetuSQLsbKaniAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000034 2014/06/05 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strKobetuSQLsbKaniAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000034 2014/06/05 ’Ç‰ÁI—¹

                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetHyojunJoin(m_strKobetuSQLsbKaniAll);
                                    SetFZYHyojunJoin(m_strKobetuSQLsbKaniAll);
                                    SetFugenjuJoin(m_strKobetuSQLsbKaniAll);
                                    SetDenshiShomeishoMSTJoin(m_strKobetuSQLsbKaniAll);
                                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                    {
                                        SetMyNumberHyojunJoin(m_strKobetuSQLsbKaniAll);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }

                            }
                            strSQL.Append(m_strKobetuSQLsbKaniAll);
                            if (m_csDataSchmaKobetuKaniAll is null)
                            {
                                m_csDataSchmaKobetuKaniAll = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaRirekiEntity.TABLE_NAME, false);
                            }
                            m_csDataSchmaKobetu = m_csDataSchmaKobetuKaniAll;
                            break;
                        }
                    case var case1 when case1 == ABEnumDefine.AtenaGetKB.KaniOnly:
                        {
                            if (m_strKobetuSQLsbKaniOnly.RLength == 0)
                            {
                                m_strKobetuSQLsbKaniOnly.Append("SELECT ");
                                SetAtenaEntity(m_strKobetuSQLsbKaniOnly);
                                // ŒÂ•ÊŽ–€‚Ì€–ÚƒZƒbƒg
                                SetKobetsuEntity(m_strKobetuSQLsbKaniOnly);
                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaCountEntity(m_strKobetuSQLsbKaniOnly);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYEntity(m_strKobetuSQLsbKaniOnly);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000034 2014/06/05 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strKobetuSQLsbKaniOnly);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000034 2014/06/05 ’Ç‰ÁI—¹

                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetHyojunEntity(m_strKobetuSQLsbKaniOnly);
                                    SetFZYHyojunEntity(m_strKobetuSQLsbKaniOnly);
                                    SetFugenjuEntity(m_strKobetuSQLsbKaniOnly);
                                    SetDenshiShomeishoMSTEntity(m_strKobetuSQLsbKaniOnly);
                                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                    {
                                        SetMyNumberHyojunEntity(m_strKobetuSQLsbKaniOnly);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }

                                // FROM ABATENA 
                                m_strKobetuSQLsbKaniOnly.Append(" FROM ").Append(ABAtenaRirekiEntity.TABLE_NAME);
                                // ŒÂ•ÊŽ–€‚ÌJOIN‹å‚ðì¬
                                SetKobetsuJoin(m_strKobetuSQLsbKaniOnly);
                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strKobetuSQLsbKaniOnly);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYJoin(m_strKobetuSQLsbKaniOnly);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000034 2014/06/05 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strKobetuSQLsbKaniOnly);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000034 2014/06/05 ’Ç‰ÁI—¹

                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetHyojunJoin(m_strKobetuSQLsbKaniOnly);
                                    SetFZYHyojunJoin(m_strKobetuSQLsbKaniOnly);
                                    SetFugenjuJoin(m_strKobetuSQLsbKaniOnly);
                                    SetDenshiShomeishoMSTJoin(m_strKobetuSQLsbKaniOnly);
                                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                    {
                                        SetMyNumberHyojunJoin(m_strKobetuSQLsbKaniOnly);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }

                            }
                            strSQL.Append(m_strKobetuSQLsbKaniOnly);
                            if (m_csDataSchmaKobetuKaniOnly is null)
                            {
                                m_csDataSchmaKobetuKaniOnly = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaRirekiEntity.TABLE_NAME, false);
                            }
                            m_csDataSchmaKobetu = m_csDataSchmaKobetuKaniOnly;
                            break;
                        }
                    case var case2 when case2 == ABEnumDefine.AtenaGetKB.NenkinAll:
                        {
                            if (m_strKobetuSQLsbNenkinAll.RLength == 0)
                            {
                                m_strKobetuSQLsbNenkinAll.Append("SELECT ");
                                SetAtenaEntity(m_strKobetuSQLsbNenkinAll);
                                // ŒÂ•ÊŽ–€‚Ì€–ÚƒZƒbƒg
                                SetKobetsuEntity(m_strKobetuSQLsbNenkinAll);
                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaCountEntity(m_strKobetuSQLsbNenkinAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYEntity(m_strKobetuSQLsbNenkinAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000034 2014/06/05 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strKobetuSQLsbNenkinAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000034 2014/06/05 ’Ç‰ÁI—¹

                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetHyojunEntity(m_strKobetuSQLsbNenkinAll);
                                    SetFZYHyojunEntity(m_strKobetuSQLsbNenkinAll);
                                    SetFugenjuEntity(m_strKobetuSQLsbNenkinAll);
                                    SetDenshiShomeishoMSTEntity(m_strKobetuSQLsbNenkinAll);
                                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                    {
                                        SetMyNumberHyojunEntity(m_strKobetuSQLsbNenkinAll);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }

                                // FROM ABATENA 
                                m_strKobetuSQLsbNenkinAll.Append(" FROM ").Append(ABAtenaRirekiEntity.TABLE_NAME);
                                // ŒÂ•ÊŽ–€‚ÌJOIN‹å‚ðì¬
                                SetKobetsuJoin(m_strKobetuSQLsbNenkinAll);
                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strKobetuSQLsbNenkinAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYJoin(m_strKobetuSQLsbNenkinAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000034 2014/06/05 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strKobetuSQLsbNenkinAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000034 2014/06/05 ’Ç‰ÁI—¹

                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetHyojunJoin(m_strKobetuSQLsbNenkinAll);
                                    SetFZYHyojunJoin(m_strKobetuSQLsbNenkinAll);
                                    SetFugenjuJoin(m_strKobetuSQLsbNenkinAll);
                                    SetDenshiShomeishoMSTJoin(m_strKobetuSQLsbNenkinAll);
                                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                    {
                                        SetMyNumberHyojunJoin(m_strKobetuSQLsbNenkinAll);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }

                            }
                            strSQL.Append(m_strKobetuSQLsbNenkinAll);
                            if (m_csDataSchmaKobetuNenkinAll is null)
                            {
                                m_csDataSchmaKobetuNenkinAll = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaRirekiEntity.TABLE_NAME, false);
                            }
                            m_csDataSchmaKobetu = m_csDataSchmaKobetuNenkinAll;
                            break;
                        }

                    default:
                        {
                            if (m_strKobetuSQLsbAll.RLength == 0)
                            {
                                m_strKobetuSQLsbAll.Append("SELECT ");
                                // Œ»s
                                m_strKobetuSQLsbAll.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".*");
                                // ŒÂ•ÊŽ–€‚Ì€–ÚƒZƒbƒg
                                SetKobetsuEntity(m_strKobetuSQLsbAll);
                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaCountEntity(m_strKobetuSQLsbAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYEntity(m_strKobetuSQLsbAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000034 2014/06/05 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strKobetuSQLsbAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000034 2014/06/05 ’Ç‰ÁI—¹

                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetHyojunEntity(m_strKobetuSQLsbAll);
                                    SetFZYHyojunEntity(m_strKobetuSQLsbAll);
                                    if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_Kaigo)
                                    {
                                        SetFugenjuEntity(m_strKobetuSQLsbAll);
                                        SetDenshiShomeishoMSTEntity(m_strKobetuSQLsbAll);
                                    }
                                    else
                                    {
                                    }
                                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                    {
                                        SetMyNumberHyojunEntity(m_strKobetuSQLsbAll);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }

                                // FROM ABATENA 
                                m_strKobetuSQLsbAll.Append(" FROM ").Append(ABAtenaRirekiEntity.TABLE_NAME);
                                // ŒÂ•ÊŽ–€‚ÌJOIN‹å‚ðì¬
                                SetKobetsuJoin(m_strKobetuSQLsbAll);
                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strKobetuSQLsbAll);

                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYJoin(m_strKobetuSQLsbAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000034 2014/06/05 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strKobetuSQLsbAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000034 2014/06/05 ’Ç‰ÁI—¹

                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetHyojunJoin(m_strKobetuSQLsbAll);
                                    SetFZYHyojunJoin(m_strKobetuSQLsbAll);
                                    if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_Kaigo)
                                    {
                                        SetFugenjuJoin(m_strKobetuSQLsbAll);
                                        SetDenshiShomeishoMSTJoin(m_strKobetuSQLsbAll);
                                    }
                                    else
                                    {
                                    }
                                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                    {
                                        SetMyNumberHyojunJoin(m_strKobetuSQLsbAll);
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }

                            }
                            strSQL.Append(m_strKobetuSQLsbAll);
                            if (m_csDataSchmaKobetuAll is null)
                            {
                                m_csDataSchmaKobetuAll = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaRirekiEntity.TABLE_NAME, false);
                            }
                            m_csDataSchmaKobetu = m_csDataSchmaKobetuAll;
                            break;
                        }
                }
                // If (m_strKobetuSQLsb.Length = 0) Then
                // m_strKobetuSQLsb.Append("SELECT ")
                // Select Case (Me.m_blnSelectAll)
                // Case ABEnumDefine.AtenaGetKB.SelectAll
                // 'Œ»s
                // m_strKobetuSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".*")
                // Case ABEnumDefine.AtenaGetKB.KaniAll
                // Call SetAtenaEntity(m_strKobetuSQLsb)
                // Case ABEnumDefine.AtenaGetKB.KaniOnly
                // Call SetAtenaEntity(m_strKobetuSQLsb)
                // Case Else
                // 'Œ»s
                // m_strKobetuSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".*")
                // End Select
                // ' , ABATENANENKIN.KSNENKNNO AS KSNENKNNO
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.KSNENKNNO)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KSNENKNNO)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.SKAKSHUTKYMD)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.NENKNSKAKSHUTKYMD)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.SKAKSHUTKSHU)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.NENKNSKAKSHUTKSHU)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.SKAKSHUTKRIYUCD)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.NENKNSKAKSHUTKRIYUCD)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.SKAKSSHTSYMD)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.NENKNSKAKSSHTSYMD)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.SKAKSSHTSRIYUCD)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.NENKNSKAKSSHTSRIYUCD)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKIGO1)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKIGO1)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNNO1)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNNO1)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNSHU1)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNSHU1)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNEDABAN1)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNEDABAN1)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKB1)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKB1)

                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKIGO2)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKIGO2)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNNO2)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNNO2)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNSHU2)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNSHU2)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNEDABAN2)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNEDABAN2)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKB2)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKB2)

                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKIGO3)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKIGO3)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNNO3)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNNO3)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNSHU3)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNSHU3)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNEDABAN3)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNEDABAN3)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKB3)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKB3)

                // ' ‘•Û
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHONO)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHONO)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOSHIKAKUKB)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKB)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOSHIKAKUKBMEISHO)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKBMEISHO)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOSHIKAKUKBRYAKUSHO)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKBRYAKUSHO)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOGAKUENKB)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOGAKUENKB)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOGAKUENKBMEISHO)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOGAKUENKBMEISHO)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOGAKUENKBRYAKUSHO)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOGAKUENKBRYAKUSHO)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOSHUTOKUYMD)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOSHUTOKUYMD)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOSOSHITSUYMD)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOSOSHITSUYMD)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKKB)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKKB)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKKBMEISHO)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKKBMEISHO)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKKBRYAKUSHO)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKKBRYAKUSHO)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKB)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKB)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKBMEISHO)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKBMEISHO)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKBRYAKUSHO)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKBRYAKUSHO)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKGAITOYMD)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKGAITOYMD)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKHIGAITOYMD)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKHIGAITOYMD)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOHOKENSHOKIGO)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOHOKENSHOKIGO)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOHOKENSHONO)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOHOKENSHONO)

                // ' ˆóŠÓ
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaInkanEntity.TABLE_NAME).Append(".").Append(ABAtenaInkanEntity.INKANNO)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.INKANNO)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaInkanEntity.TABLE_NAME).Append(".").Append(ABAtenaInkanEntity.INKANTOROKUKB)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.INKANTOROKUKB)

                // ' ‘I‹“
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaSenkyoEntity.TABLE_NAME).Append(".").Append(ABAtenaSenkyoEntity.SENKYOSHIKAKUKB)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.SENKYOSHIKAKUKB)

                // ' Ž™“¶Žè“–
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaJiteEntity.TABLE_NAME).Append(".").Append(ABAtenaJiteEntity.JIDOTEATEHIYOKB)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JIDOTEATEHIYOKB)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaJiteEntity.TABLE_NAME).Append(".").Append(ABAtenaJiteEntity.JIDOTEATESTYM)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JIDOTEATESTYM)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaJiteEntity.TABLE_NAME).Append(".").Append(ABAtenaJiteEntity.JIDOTEATEEDYM)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JIDOTEATEEDYM)

                // ' ‰îŒì
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.HIHKNSHANO)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGHIHKNSHANO)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.SKAKSHUTKYMD)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGSKAKSHUTKYMD)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.SKAKSSHTSYMD)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGSKAKSSHTSYMD)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.SKAKHIHOKENSHAKB)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGSKAKHIHOKENSHAKB)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.JUSHOCHITKRIKB)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGJUSHOCHITKRIKB)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.JUKYUSHAKB)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGJUKYUSHAKB)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.YOKAIGJOTAIKBCD)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.YOKAIGJOTAIKBCD)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.KAIGSKAKKB)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGSKAKKB)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.NINTEIKAISHIYMD)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGNINTEIKAISHIYMD)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.NINTEISHURYOYMD)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGNINTEISHURYOYMD)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.JUKYUNINTEIYMD)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGJUKYUNINTEIYMD)
                // m_strKobetuSQLsb.Append(", ")
                // m_strKobetuSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.JUKYUNINTEITORIKESHIYMD)
                // m_strKobetuSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGJUKYUNINTEITORIKESHIYMD)

                // '‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                // Call SetAtenaCountEntity(m_strKobetuSQLsb)

                // '  FROM ABATENA 
                // m_strKobetuSQLsb.Append(" FROM ").Append(ABAtenaRirekiEntity.TABLE_NAME)

                // ' LEFT OUTER JOIN ABATENANENKIN ON ABATENA.JUMINCD=ABATENANENKIN.JUMINCD
                // m_strKobetuSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaNenkinEntity.TABLE_NAME).Append(" ON ")
                // m_strKobetuSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                // m_strKobetuSQLsb.Append("=")
                // m_strKobetuSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JUMINCD)

                // ' LEFT OUTER JOIN ABATENAKOKUHO ON ABATENA.JUMINCD=ABATENAKOKUHO.JUMINCD
                // m_strKobetuSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(" ON ")
                // m_strKobetuSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                // m_strKobetuSQLsb.Append("=")
                // m_strKobetuSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.JUMINCD)

                // ' LEFT OUTER JOIN ABATENAINKAN ON ABATENA.JUMINCD=ABATENAINKAN.JUMINCD
                // m_strKobetuSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaInkanEntity.TABLE_NAME).Append(" ON ")
                // m_strKobetuSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                // m_strKobetuSQLsb.Append("=")
                // m_strKobetuSQLsb.Append(ABAtenaInkanEntity.TABLE_NAME).Append(".").Append(ABAtenaInkanEntity.JUMINCD)

                // ' LEFT OUTER JOIN ABATENASENKYO ON ABATENA.JUMINCD=ABATENASENKYO.JUMINCD
                // m_strKobetuSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaSenkyoEntity.TABLE_NAME).Append(" ON ")
                // m_strKobetuSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                // m_strKobetuSQLsb.Append("=")
                // m_strKobetuSQLsb.Append(ABAtenaSenkyoEntity.TABLE_NAME).Append(".").Append(ABAtenaSenkyoEntity.JUMINCD)

                // ' LEFT OUTER JOIN ABATENAJITE ON ABATENA.JUMINCD=ABATENAJIDOUTE.JUMINCD
                // m_strKobetuSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaJiteEntity.TABLE_NAME).Append(" ON ")
                // m_strKobetuSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                // m_strKobetuSQLsb.Append("=")
                // m_strKobetuSQLsb.Append(ABAtenaJiteEntity.TABLE_NAME).Append(".").Append(ABAtenaJiteEntity.JUMINCD)

                // ' LEFT OUTER JOIN ABATENAKAIGO ON ABATENA.JUMINCD=ABATENAKAIGO.JUMINCD
                // m_strKobetuSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaKaigoEntity.TABLE_NAME).Append(" ON ")
                // m_strKobetuSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                // m_strKobetuSQLsb.Append("=")
                // m_strKobetuSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.JUMINCD)

                // '‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                // Call SetAtenaJoin(m_strKobetuSQLsb)
                // End If
                // strSQL.Append(m_strKobetuSQLsb)
                // If (m_csDataSchmaKobetu Is Nothing) Then
                // m_csDataSchmaKobetu = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString, ABAtenaRirekiEntity.TABLE_NAME, False)
                // End If
                // * —š—ð”Ô† 000019 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                // WHERE‹å‚Ìì¬
                strWHERE = new StringBuilder(CreateWhere(cSearchKey, strKikanYMD));

                // íœƒtƒ‰ƒO
                if (blnSakujoFG == false)
                {
                    if (!(strWHERE.RLength == 0))
                    {
                        strWHERE.Append(" AND ");
                    }
                    strWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SAKUJOFG);
                    strWHERE.Append(" <> '1'");
                }

                // ORDER‹å‚ðŒ‹‡
                strORDER = new StringBuilder();
                if (cSearchKey.p_strJuminYuseniKB == "1" & !(cSearchKey.p_strStaiCD == string.Empty))
                {
                    strORDER.Append(" ORDER BY ");
                    strORDER.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINHYOHYOJIJUN);
                    strORDER.Append(" ASC;");
                }
                else if (!(cSearchKey.p_strUmareYMD == string.Empty))
                {
                    strORDER.Append(" ORDER BY ");
                    strORDER.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.UMAREYMD);
                    strORDER.Append(" ASC,");
                    strORDER.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD);
                    strORDER.Append(" ASC;");
                }
                else
                {
                    strORDER.Append(" ORDER BY ");
                    strORDER.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEARCHKANASEIMEI);
                    strORDER.Append(" ASC,");
                    strORDER.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD);
                    strORDER.Append(" ASC;");
                }

                if (!string.IsNullOrEmpty(strWHERE.ToString()))
                {
                    strSQL.Append(" WHERE ").Append(strWHERE);
                }
                strSQL.Append(strORDER);

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // '* —š—ð”Ô† 000019 2005/01/25 XVŠJŽni‹{‘òjIf •¶‚ÅˆÍ‚Þ
                // If (m_blnBatch = False) Then
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, m_cfSelectUFParameterCollectionClass) + "z")
                // End If
                // '* —š—ð”Ô† 000019 2005/01/25 XVI—¹i‹{‘òjIf •¶‚ÅˆÍ‚Þ

                // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                // * —š—ð”Ô† 000019 2005/01/25 XVŠJŽni‹{‘òj
                // csAtenaRirekiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, ABAtenaRirekiEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass)
                csAtenaRirekiEntity = m_csDataSchmaKobetu.Clone();
                csAtenaRirekiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csAtenaRirekiEntity, ABAtenaRirekiEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);
                // * —š—ð”Ô† 000019 2005/01/25 XVI—¹i‹{‘òj

                // MaxRows’l‚ð–ß‚·
                m_cfRdbClass.p_intMaxRows = intMaxRows;

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }

            catch (UFAppException objAppExp)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLogClass.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + default


#error Cannot convert LiteralExpressionSyntax - see comment for details
                   /* Cannot convert LiteralExpressionSyntax, System.ArgumentOutOfRangeException: Length cannot be less than zero.
                                 Parameter name: length
                                    at System.String.Substring(Int32 startIndex, Int32 length)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetQuotedStringTextForUser(String textForUser, String valueTextForCompiler)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetLiteralExpression(Object value, String textForUser, ITypeSymbol convertedType)
                                    at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitLiteralExpression>d__43.MoveNext()
                                 --- End of stack trace from previous location where exception was thrown ---
                                    at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
                                    at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__12`1.MoveNext()

                                 Input:
                                 "yƒ[ƒjƒ“
                                  */
                     );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 141020


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 141118


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 141388


                Input:
                " + Me.GetType.Name + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 141473


                                Input:
                                " + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csAtenaRirekiEntity;

        }

        // *—š—ð”Ô† 000015 2003/11/18 ’Ç‰ÁI—¹

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertAtenaRB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@ˆ¶–¼—š—ðƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertAtenaRB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "InsertAtenaRB";
            // * corresponds to VS2008 Start 2010/04/16 000029
            // Dim csInstRow As DataRow
            // Dim csDataColumn As DataColumn
            // * corresponds to VS2008 End 2010/04/16 000029
            int intInsCnt;        // ’Ç‰ÁŒ”
            string strUpdateDateTime;

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strInsertSQL is null | string.IsNullOrEmpty(m_strInsertSQL) | m_cfInsertUFParameterCollectionClass is null)
                {
                    // * —š—ð”Ô† 000020 2005/06/15 C³ŠJŽn
                    // Call CreateSQL(csDataRow)
                    CreateInsertSQL(csDataRow);
                    // * —š—ð”Ô† 000020 2005/06/15 C³I—¹
                }

                // XV“úŽž‚ÌŽæ“¾
                strUpdateDateTime = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");  // ì¬“úŽž

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABAtenaRirekiEntity.TANMATSUID) = m_cfControlData.m_strClientId;   // ’[––‚h‚c
                csDataRow(ABAtenaRirekiEntity.SAKUJOFG) = "0";                               // íœƒtƒ‰ƒO
                csDataRow(ABAtenaRirekiEntity.KOSHINCOUNTER) = decimal.Zero;                 // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaRirekiEntity.SAKUSEINICHIJI) = strUpdateDateTime;           // ì¬“úŽž
                csDataRow(ABAtenaRirekiEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;    // ì¬ƒ†[ƒU[
                csDataRow(ABAtenaRirekiEntity.KOSHINNICHIJI) = strUpdateDateTime;            // XV“úŽž
                csDataRow(ABAtenaRirekiEntity.KOSHINUSER) = m_cfControlData.m_strUserId;     // XVƒ†[ƒU[


                // ' “–ƒNƒ‰ƒX‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¤
                // For Each csDataColumn In csDataRow.Table.Columns
                // CheckColumnValue(csDataColumn.ColumnName, csDataRow(csDataColumn.ColumnName).ToString().Trim)
                // Next csDataColumn


                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    cfParam.Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaRirekiEntity.PARAM_PLACEHOLDER.RLength)).ToString();

                // *—š—ð”Ô† 000011 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strInsertSQL + "z")

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strInsertSQL, m_cfInsertUFParameterCollectionClass) + "z")
                // *—š—ð”Ô† 000011 2003/08/28 C³I—¹

                // SQL‚ÌŽÀs
                intInsCnt = m_cfRdbClass.ExecuteSQL(m_strInsertSQL, m_cfInsertUFParameterCollectionClass);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLogClass.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


#error Cannot convert LiteralExpressionSyntax - see comment for details
                   /* Cannot convert LiteralExpressionSyntax, System.ArgumentOutOfRangeException: Length cannot be less than zero.
                                 Parameter name: length
                                    at System.String.Substring(Int32 startIndex, Int32 length)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetQuotedStringTextForUser(String textForUser, String valueTextForCompiler)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetLiteralExpression(Object value, String textForUser, ITypeSymbol convertedType)
                                    at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitLiteralExpression>d__43.MoveNext()
                                 --- End of stack trace from previous location where exception was thrown ---
                                    at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
                                    at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__12`1.MoveNext()

                                 Input:
                                 "yƒ[ƒjƒ“
                                  */
                     );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 146694


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 146792


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 147062


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 147147


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intInsCnt;

        }
        // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertAtenaRB() As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼—š—ðƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”           csAtenaDr As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ðj
        // * @@           csAtenaFZYDr As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ð•tj
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertAtenaRB(DataRow csAtenaDr, DataRow csAtenaFZYDr)
        {
            int intCnt = 0;
            int intCnt2 = 0;

            const string THIS_METHOD_NAME = "InsertAtenaRB";

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ˆ¶–¼—š—ðƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                intCnt = InsertAtenaRB(csAtenaDr);

                // ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                if (!(csAtenaFZYDr == null) && m_blnJukihoKaiseiFG)
                {
                    // ˆ¶–¼—š—ð•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                    if (m_csAtenaRirekiFZYB == null)
                    {
                        m_csAtenaRirekiFZYB = new ABAtenaRirekiFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }

                    // ì¬“úŽžAXV“úŽž‚Ì“¯Šú
                    csAtenaFZYDr(ABAtenaRirekiFZYEntity.SAKUSEINICHIJI) = csAtenaDr(ABAtenaRirekiEntity.SAKUSEINICHIJI);
                    csAtenaFZYDr(ABAtenaRirekiFZYEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaRirekiEntity.KOSHINNICHIJI);

                    // ˆ¶–¼•tƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                    intCnt2 = m_csAtenaRirekiFZYB.InsertAtenaFZYRB(csAtenaFZYDr);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLogClass.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


#error Cannot convert LiteralExpressionSyntax - see comment for details
                   /* Cannot convert LiteralExpressionSyntax, System.ArgumentOutOfRangeException: Length cannot be less than zero.
                                 Parameter name: length
                                    at System.String.Substring(Int32 startIndex, Int32 length)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetQuotedStringTextForUser(String textForUser, String valueTextForCompiler)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetLiteralExpression(Object value, String textForUser, ITypeSymbol convertedType)
                                    at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitLiteralExpression>d__43.MoveNext()
                                 --- End of stack trace from previous location where exception was thrown ---
                                    at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
                                    at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__12`1.MoveNext()

                                 Input:
                                 "yƒ[ƒjƒ“
                                  */
                     );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 150246


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 150344


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 150614


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 150699


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intCnt;

        }
        // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000038 2023/08/14 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertAtenaRB(ByVal csAtenaDr As DataRow, ByVal csAtenaHyojunDr As DataRow, _
        // *                                              ByVal csAtenaFZYDr As DataRow, ByVal csAtenaFZYHyojunDr As DataRow) As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼—š—ðƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”           csAtenaDr As DataRow          : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ðj
        // * @@           csAtenaHyojunDr As DataRow    : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ð_•W€j
        // * @@           csAtenaFZYDr As DataRow       : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ð•tj
        // * @@           csAtenaFZYHyojunDr As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ð•t_•W€j
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertAtenaRB(DataRow csAtenaDr, DataRow csAtenaHyojunDr, DataRow csAtenaFZYDr, DataRow csAtenaFZYHyojunDr)
        {
            int intCnt = 0;
            int intCnt2 = 0;
            int intCnt3 = 0;
            int intCnt4 = 0;

            const string THIS_METHOD_NAME = "InsertAtenaRB";

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ˆ¶–¼—š—ðƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                intCnt = InsertAtenaRB(csAtenaDr);

                // ˆ¶–¼—š—ð_•W€‚ª‘¶Ý‚·‚éê‡
                if (!(csAtenaHyojunDr == null))
                {
                    // ˆ¶–¼—š—ð_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                    if (m_csAtenaRirekiHyojunB == null)
                    {
                        m_csAtenaRirekiHyojunB = new ABAtenaRireki_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }

                    // ì¬“úŽžAXV“úŽž‚Ì“¯Šú
                    csAtenaHyojunDr(ABAtenaRirekiHyojunEntity.SAKUSEINICHIJI) = csAtenaDr(ABAtenaRirekiEntity.SAKUSEINICHIJI);
                    csAtenaHyojunDr(ABAtenaRirekiHyojunEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaRirekiEntity.KOSHINNICHIJI);

                    // ˆ¶–¼—š—ð_•W€ƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                    intCnt2 = m_csAtenaRirekiHyojunB.InsertAtenaRirekiHyojunB(csAtenaHyojunDr);

                }

                // ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                if (m_blnJukihoKaiseiFG)
                {

                    // ˆ¶–¼—š—ð•t‚ª‘¶Ý‚·‚éê‡
                    if (!(csAtenaFZYDr == null))
                    {
                        // ˆ¶–¼—š—ð•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                        if (m_csAtenaRirekiFZYB == null)
                        {
                            m_csAtenaRirekiFZYB = new ABAtenaRirekiFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                        }
                        else
                        {
                            // ˆ—‚È‚µ
                        }

                        // ì¬“úŽžAXV“úŽž‚Ì“¯Šú
                        csAtenaFZYDr(ABAtenaRirekiFZYEntity.SAKUSEINICHIJI) = csAtenaDr(ABAtenaRirekiEntity.SAKUSEINICHIJI);
                        csAtenaFZYDr(ABAtenaRirekiFZYEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaRirekiEntity.KOSHINNICHIJI);

                        // ˆ¶–¼•tƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                        intCnt3 = m_csAtenaRirekiFZYB.InsertAtenaFZYRB(csAtenaFZYDr);
                    }

                    // ˆ¶–¼—š—ð•t_•W€‚ª‘¶Ý‚·‚éê‡
                    if (!(csAtenaFZYHyojunDr == null))
                    {
                        // ˆ¶–¼—š—ð•t_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                        if (m_csAtenaRirekiFZYHyojunB == null)
                        {
                            m_csAtenaRirekiFZYHyojunB = new ABAtenaRirekiFZY_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                        }
                        else
                        {
                            // ˆ—‚È‚µ
                        }

                        // ì¬“úŽžAXV“úŽž‚Ì“¯Šú
                        csAtenaFZYHyojunDr(ABAtenaRirekiFZYHyojunEntity.SAKUSEINICHIJI) = csAtenaDr(ABAtenaRirekiEntity.SAKUSEINICHIJI);
                        csAtenaFZYHyojunDr(ABAtenaRirekiFZYHyojunEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaRirekiEntity.KOSHINNICHIJI);

                        // ˆ¶–¼•t_•W€ƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                        intCnt4 = m_csAtenaRirekiFZYHyojunB.InsertAtenaRirekiFZYHyojunB(csAtenaFZYHyojunDr);
                    }
                }

                else
                {
                    // ˆ—‚È‚µ
                }

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLogClass.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


#error Cannot convert LiteralExpressionSyntax - see comment for details
                   /* Cannot convert LiteralExpressionSyntax, System.ArgumentOutOfRangeException: Length cannot be less than zero.
                                 Parameter name: length
                                    at System.String.Substring(Int32 startIndex, Int32 length)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetQuotedStringTextForUser(String textForUser, String valueTextForCompiler)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetLiteralExpression(Object value, String textForUser, ITypeSymbol convertedType)
                                    at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitLiteralExpression>d__43.MoveNext()
                                 --- End of stack trace from previous location where exception was thrown ---
                                    at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
                                    at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__12`1.MoveNext()

                                 Input:
                                 "yƒ[ƒjƒ“
                                  */
                     );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 156674


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 156772


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 157042


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 157127


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intCnt;

        }
        // *—š—ð”Ô† 000038 2023/08/14 ’Ç‰ÁI—¹

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateAtenaRB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@ˆ¶–¼—š—ðƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : XV‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int UpdateAtenaRB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "UpdateAtenaRB";                     // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                                 // * corresponds to VS2008 Start 2010/04/16 000029
                                                                                 // Dim csDataColumn As DataColumn
                                                                                 // * corresponds to VS2008 End 2010/04/16 000029
            int intUpdCnt;                            // XVŒ”


            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strUpdateSQL is null | string.IsNullOrEmpty(m_strUpdateSQL) | m_cfUpdateUFParameterCollectionClass is null)
                {
                    // * —š—ð”Ô† 000020 2005/06/15 C³ŠJŽn
                    // Call CreateSQL(csDataRow)
                    CreateUpdateSQL(csDataRow);
                    // * —š—ð”Ô† 000020 2005/06/15 C³I—¹
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABAtenaRirekiEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                 // ’[––‚h‚c
                csDataRow(ABAtenaRirekiEntity.KOSHINCOUNTER) = Conversions.ToDecimal(csDataRow(ABAtenaRirekiEntity.KOSHINCOUNTER)) + 1m;       // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaRirekiEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff"); // XV“úŽž
                csDataRow(ABAtenaRirekiEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                   // XVƒ†[ƒU[

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABAtenaRirekiEntity.PREFIX_KEY.RLength) == ABAtenaRirekiEntity.PREFIX_KEY)
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaRirekiEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // *—š—ð”Ô† 000016 2004/11/12 C³ŠJŽn
                        // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                        // CheckColumnValue(cfParam.ParameterName.Substring(ABAtenaRirekiEntity.PARAM_PLACEHOLDER.Length), csDataRow(cfParam.ParameterName.Substring(ABAtenaRirekiEntity.PARAM_PLACEHOLDER.Length), DataRowVersion.Current).ToString().Trim)
                        // *—š—ð”Ô† 000016 2004/11/12 C³ŠJŽn
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaRirekiEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // *—š—ð”Ô† 000011 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strUpdateSQL + "z")

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass) + "z")
                // *—š—ð”Ô† 000011 2003/08/28 C³I—¹

                // SQL‚ÌŽÀs
                intUpdCnt = m_cfRdbClass.ExecuteSQL(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLogClass.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


#error Cannot convert LiteralExpressionSyntax - see comment for details
                   /* Cannot convert LiteralExpressionSyntax, System.ArgumentOutOfRangeException: Length cannot be less than zero.
                                 Parameter name: length
                                    at System.String.Substring(Int32 startIndex, Int32 length)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetQuotedStringTextForUser(String textForUser, String valueTextForCompiler)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetLiteralExpression(Object value, String textForUser, ITypeSymbol convertedType)
                                    at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitLiteralExpression>d__43.MoveNext()
                                 --- End of stack trace from previous location where exception was thrown ---
                                    at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
                                    at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__12`1.MoveNext()

                                 Input:
                                 "yƒ[ƒjƒ“
                                  */
                     );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 162796


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 162894


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 163164


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 163249


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intUpdCnt;

        }
        // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateAtenaRB() As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚é
        // * 
        // * ˆø”           csAtenaDr As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ðj
        // * @@           csAtenaFZYDr As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ð•tj
        // * 
        // * –ß‚è’l         Integer : XV‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int UpdateAtenaRB(DataRow csAtenaDr, DataRow csAtenaFZYDr)
        {
            int intInsCnt = 0;
            int intInsCnt2 = 0;

            const string THIS_METHOD_NAME = "UpdateAtenaRB";

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ˆ¶–¼—š—ðƒ}ƒXƒ^XV‚ðŽÀs
                intInsCnt = UpdateAtenaRB(csAtenaDr);

                // ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                if (!(csAtenaFZYDr == null) && m_blnJukihoKaiseiFG)
                {
                    // ˆ¶–¼—š—ð•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                    if (m_csAtenaRirekiFZYB == null)
                    {
                        m_csAtenaRirekiFZYB = new ABAtenaRirekiFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }

                    // XV“úŽž‚Ì“¯Šú
                    csAtenaFZYDr(ABAtenaRirekiFZYEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaRirekiEntity.KOSHINNICHIJI);

                    // ˆ¶–¼—š—ð•tƒ}ƒXƒ^XV‚ðŽÀs
                    intInsCnt2 = m_csAtenaRirekiFZYB.UpdateAtenaFZYRB(csAtenaFZYDr);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLogClass.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


#error Cannot convert LiteralExpressionSyntax - see comment for details
                   /* Cannot convert LiteralExpressionSyntax, System.ArgumentOutOfRangeException: Length cannot be less than zero.
                                 Parameter name: length
                                    at System.String.Substring(Int32 startIndex, Int32 length)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetQuotedStringTextForUser(String textForUser, String valueTextForCompiler)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetLiteralExpression(Object value, String textForUser, ITypeSymbol convertedType)
                                    at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitLiteralExpression>d__43.MoveNext()
                                 --- End of stack trace from previous location where exception was thrown ---
                                    at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
                                    at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__12`1.MoveNext()

                                 Input:
                                 "yƒ[ƒjƒ“
                                  */
                     );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 166234


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 166332


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 166602


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 166687


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intInsCnt;

        }
        // *—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000038 2023/08/14 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateAtenaRB(ByVal csAtenaDr As DataRow, _
        // *                                              ByVal csAtenaHyojunDr As DataRow, _
        // *                                              ByVal csAtenaFZYDr As DataRow, _
        // *                                              ByVal csAtenaFZYHyojunDr As DataRow) As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚é
        // * 
        // * ˆø”           csAtenaDr As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ðj
        // * @@           csAtenaHyojunDr As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ð_•W€j
        // * @@           csAtenaFZYDr As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ð•tj
        // * @@           csAtenaFZYHyojunDr As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ð•t_•W€j
        // * 
        // * –ß‚è’l         Integer : XV‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int UpdateAtenaRB(DataRow csAtenaDr, DataRow csAtenaHyojunDr, DataRow csAtenaFZYDr, DataRow csAtenaFZYHyojunDr)


        {

            int intInsCnt = 0;
            int intInsCnt2 = 0;
            int intInsCnt3 = 0;
            int intInsCnt4 = 0;

            const string THIS_METHOD_NAME = "UpdateAtenaRB";

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ˆ¶–¼—š—ðƒ}ƒXƒ^XV‚ðŽÀs
                intInsCnt = UpdateAtenaRB(csAtenaDr);

                // ˆ¶–¼—š—ð_•W€ƒ}ƒXƒ^‚ª‘¶Ý‚·‚éê‡
                if (!(csAtenaHyojunDr == null))
                {
                    // ˆ¶–¼—š—ð_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                    if (m_csAtenaRirekiHyojunB == null)
                    {
                        m_csAtenaRirekiHyojunB = new ABAtenaRireki_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }

                    // XV“úŽž‚Ì“¯Šú
                    csAtenaHyojunDr(ABAtenaRirekiHyojunEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaRirekiEntity.KOSHINNICHIJI);

                    // ˆ¶–¼—š—ð_•W€ƒ}ƒXƒ^XV‚ðŽÀs
                    intInsCnt2 = m_csAtenaRirekiHyojunB.UpdateAtenaRirekiHyojunB(csAtenaHyojunDr);

                }

                // ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                if (m_blnJukihoKaiseiFG)
                {
                    // ˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ª‘¶Ý‚·‚éê‡
                    if (!(csAtenaFZYDr == null))
                    {
                        // ˆ¶–¼—š—ð•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                        if (m_csAtenaRirekiFZYB == null)
                        {
                            m_csAtenaRirekiFZYB = new ABAtenaRirekiFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                        }
                        else
                        {
                            // ˆ—‚È‚µ
                        }

                        // XV“úŽž‚Ì“¯Šú
                        csAtenaFZYDr(ABAtenaRirekiFZYEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaRirekiEntity.KOSHINNICHIJI);

                        // ˆ¶–¼—š—ð•tƒ}ƒXƒ^XV‚ðŽÀs
                        intInsCnt3 = m_csAtenaRirekiFZYB.UpdateAtenaFZYRB(csAtenaFZYDr);

                    }

                    // ˆ¶–¼—š—ð•t_•W€ƒ}ƒXƒ^‚ª‘¶Ý‚·‚éê‡
                    if (!(csAtenaFZYHyojunDr == null))
                    {
                        // ˆ¶–¼—š—ð•t_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                        if (m_csAtenaRirekiFZYHyojunB == null)
                        {
                            m_csAtenaRirekiFZYHyojunB = new ABAtenaRirekiFZY_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                        }
                        else
                        {
                            // ˆ—‚È‚µ
                        }

                        // XV“úŽž‚Ì“¯Šú
                        csAtenaFZYHyojunDr(ABAtenaRirekiFZYHyojunEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaRirekiEntity.KOSHINNICHIJI);

                        // ˆ¶–¼—š—ð•tƒ}ƒXƒ^XV‚ðŽÀs
                        intInsCnt4 = m_csAtenaRirekiFZYHyojunB.UpdateAtenaRirekiFZYHyojunB(csAtenaFZYHyojunDr);

                    }
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLogClass.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


#error Cannot convert LiteralExpressionSyntax - see comment for details
                   /* Cannot convert LiteralExpressionSyntax, System.ArgumentOutOfRangeException: Length cannot be less than zero.
                                 Parameter name: length
                                    at System.String.Substring(Int32 startIndex, Int32 length)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetQuotedStringTextForUser(String textForUser, String valueTextForCompiler)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetLiteralExpression(Object value, String textForUser, ITypeSymbol convertedType)
                                    at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitLiteralExpression>d__43.MoveNext()
                                 --- End of stack trace from previous location where exception was thrown ---
                                    at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
                                    at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__12`1.MoveNext()

                                 Input:
                                 "yƒ[ƒjƒ“
                                  */
                     );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 172466


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 172564


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 172834


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 172919


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intInsCnt;

        }
        // *—š—ð”Ô† 000038 2023/08/14 ’Ç‰ÁI—¹

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^íœ
        // * 
        // * \•¶           Public Function DeleteAtenaRB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@ˆ¶–¼—š—ðƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð˜_—íœ‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ˜_—íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int DeleteAtenaRB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "DeleteAtenaRB";                     // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                                 // * corresponds to VS2008 Start 2010/04/16 000029
                                                                                 // Dim csDataColumn As DataColumn
                                                                                 // * corresponds to VS2008 End 2010/04/16 000029
            int intDelCnt;                            // íœŒ”


            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strDelRonriSQL is null | string.IsNullOrEmpty(m_strDelRonriSQL) | m_cfDelRonriUFParameterCollectionClass is null)
                {
                    // * —š—ð”Ô† 000020 2005/06/15 C³ŠJŽn
                    // CreateSQL(csDataRow)
                    CreateDeleteRonriSQL(csDataRow);
                    // * —š—ð”Ô† 000020 2005/06/15 C³I—¹
                }


                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABAtenaRirekiEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                   // ’[––‚h‚c
                csDataRow(ABAtenaRirekiEntity.SAKUJOFG) = "1";                                                                 // íœƒtƒ‰ƒO
                csDataRow(ABAtenaRirekiEntity.KOSHINCOUNTER) = Conversions.ToDecimal(csDataRow(ABAtenaRirekiEntity.KOSHINCOUNTER)) + 1m;               // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaRirekiEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");   // XV“úŽž
                csDataRow(ABAtenaRirekiEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                     // XVƒ†[ƒU[

                // *—š—ð”Ô† 000011 2003/08/28 C³ŠJŽn
                // 'ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                // For Each cfParam In m_cfUpdateUFParameterCollectionClass
                // 'ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                // If (cfParam.ParameterName.Substring(0, ABAtenaRirekiEntity.PREFIX_KEY.Length) = ABAtenaRirekiEntity.PREFIX_KEY) Then
                // m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = _
                // csDataRow(cfParam.ParameterName.Substring(ABAtenaRirekiEntity.PREFIX_KEY.Length), _
                // DataRowVersion.Original).ToString()
                // Else
                // 'ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                // CheckColumnValue(cfParam.ParameterName.Substring(ABAtenaRirekiEntity.PARAM_PLACEHOLDER.Length), csDataRow(cfParam.ParameterName.Substring(ABAtenaRirekiEntity.PARAM_PLACEHOLDER.Length), DataRowVersion.Current).ToString().Trim)
                // m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.Substring(ABAtenaRirekiEntity.PARAM_PLACEHOLDER.Length), DataRowVersion.Current).ToString()
                // End If
                // Next cfParam

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfDelRonriUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABAtenaRirekiEntity.PREFIX_KEY.RLength) == ABAtenaRirekiEntity.PREFIX_KEY)
                    {
                        this.m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaRirekiEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // *—š—ð”Ô† 000016 2004/11/12 C³ŠJŽn
                        // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                        // CheckColumnValue(cfParam.ParameterName.Substring(ABAtenaRirekiEntity.PARAM_PLACEHOLDER.Length), csDataRow(cfParam.ParameterName.Substring(ABAtenaRirekiEntity.PARAM_PLACEHOLDER.Length), DataRowVersion.Current).ToString().Trim)
                        // *—š—ð”Ô† 000016 2004/11/12 C³I—¹
                        this.m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaRirekiEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }
                // *—š—ð”Ô† 000011 2003/08/28 C³I—¹

                // *—š—ð”Ô† 000011 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strUpdateSQL + "z")

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass) + "z")
                // *—š—ð”Ô† 000011 2003/08/28 C³I—¹

                // *—š—ð”Ô† 000011 2003/08/28 C³ŠJŽn
                // ' SQL‚ÌŽÀs
                // intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelRonriSQL, m_cfUpdateUFParameterCollectionClass)

                // SQL‚ÌŽÀs
                intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass);
                // *—š—ð”Ô† 000011 2003/08/28 C³I—¹

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLogClass.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


#error Cannot convert LiteralExpressionSyntax - see comment for details
                   /* Cannot convert LiteralExpressionSyntax, System.ArgumentOutOfRangeException: Length cannot be less than zero.
                                 Parameter name: length
                                    at System.String.Substring(Int32 startIndex, Int32 length)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetQuotedStringTextForUser(String textForUser, String valueTextForCompiler)
                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetLiteralExpression(Object value, String textForUser, ITypeSymbol convertedType)
                                    at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitLiteralExpression>d__43.MoveNext()
                                 --- End of stack trace from previous location where exception was thrown ---
                                    at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
                                    at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__12`1.MoveNext()

                                 Input:
                                 "yƒ[ƒjƒ“
                                  */
                     );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 180229


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 180327


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 180597


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 180682


                Input:
                " + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return intDelCnt

                    End Function
                    '*—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^íœ
                    '* 
                    '* \•¶           Public Function UpdateAtenaB() As Integer
                    '* 
                    '* ‹@”\@@    @ ˆ¶–¼—š—ðƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð˜_—íœ‚·‚é
                    '* 
                    '* ˆø”           csAtenaDr As DataRow : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ðj
                    '* @@           csAtenaFZYDr As DataRow : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ð•tj
                    '* 
                    '* –ß‚è’l         Integer : ˜_—íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
                    '************************************************************************************************
                    Public Overloads Function DeleteAtenaRB(ByVal csAtenaDr As DataRow, ByVal csAtenaFZYDr As DataRow) As Integer
                        Dim intCnt As Integer = 0
                        Dim intCnt2 As Integer = 0

                        Const THIS_METHOD_NAME As String = "DeleteAtenaRB"

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'ˆ¶–¼—š—ðƒ}ƒXƒ^XV‚ðŽÀs
                            intCnt = Me.DeleteAtenaRB(csAtenaDr)

                            'ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                            If (Not IsNothing(csAtenaFZYDr)) AndAlso (m_blnJukihoKaiseiFG) Then
                                'ˆ¶–¼—š—ð•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                                If (IsNothing(m_csAtenaRirekiFZYB)) Then
                                    m_csAtenaRirekiFZYB = New ABAtenaRirekiFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                Else
                                    'ˆ—‚È‚µ
                                End If

                                'XV“úŽž‚Ì“¯Šú
                                csAtenaFZYDr(ABAtenaRirekiFZYEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaRirekiEntity.KOSHINNICHIJI)

                                'ˆ¶–¼—š—ð•tƒ}ƒXƒ^íœ‚ðŽÀs
                                intCnt2 = m_csAtenaRirekiFZYB.DeleteAtenaFZYRB(csAtenaFZYDr)
                            Else
                                'ˆ—‚È‚µ
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return intCnt

                    End Function

                    '*—š—ð”Ô† 000038 2023/08/14 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^íœ
                    '* 
                    '* \•¶           Public Function UpdateAtenaB(ByVal csAtenaDr As DataRow, ByVal csAtenaFZYDr As DataRow, _
                    '*                                             ByVal csAtenaHyojunDr As DataRow, ByVal csAtenaFZYHyojunDr As DataRow) As Integer
                    '* 
                    '* ˆø”           csAtenaDr As DataRow          : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ðj
                    '* @@           csAtenaHyojunDr As DataRow    : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ð_•W€j
                    '* @@           csAtenaFZYDr As DataRow       : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ð•tj
                    '* @@           csAtenaFZYHyojunDr As DataRow : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ð•t_•W€j
                    '* 
                    '* –ß‚è’l         Integer : ˜_—íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
                    '************************************************************************************************
                    '*—š—ð”Ô† 000039 2023/10/19 C³ŠJŽn
                    'Public Overloads Function DeleteAtenaRB(ByVal csAtenaDr As DataRow, ByVal csAtenaFZYDr As DataRow,
                    '                                        ByVal csAtenaHyojunDr As DataRow, ByVal csAtenaFZYHyojunDr As DataRow) As Integer
                    Public Overloads Function DeleteAtenaRB(ByVal csAtenaDr As DataRow, ByVal csAtenaHyojunDr As DataRow,
                                                            ByVal csAtenaFZYDr As DataRow, ByVal csAtenaFZYHyojunDr As DataRow) As Integer
                        '*—š—ð”Ô† 000039 2023/10/19 C³I—¹
                        Dim intCnt As Integer = 0
                        Dim intCnt2 As Integer = 0
                        Dim intCnt3 As Integer = 0
                        Dim intCnt4 As Integer = 0

                        Const THIS_METHOD_NAME As String = "DeleteAtenaRB"

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'ˆ¶–¼—š—ðƒ}ƒXƒ^XV‚ðŽÀs
                            intCnt = Me.DeleteAtenaRB(csAtenaDr)

                            'ˆ¶–¼—š—ð_•W€ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ª‘¶Ý‚·‚éê‡Aˆ—‚ðs‚¤
                            If (Not IsNothing(csAtenaHyojunDr)) Then

                                'ˆ¶–¼—š—ð_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                                If (IsNothing(m_csAtenaRirekiHyojunB)) Then
                                    m_csAtenaRirekiHyojunB = New ABAtenaRireki_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                Else
                                    'ˆ—‚È‚µ
                                End If

                                'XV“úŽž‚Ì“¯Šú
                                csAtenaHyojunDr(ABAtenaRirekiHyojunEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaRirekiEntity.KOSHINNICHIJI)

                                'ˆ¶–¼—š—ð_•W€ƒ}ƒXƒ^íœ‚ðŽÀs
                                intCnt2 = m_csAtenaRirekiHyojunB.DeleteAtenaRirekiHyojunB(csAtenaHyojunDr)

                            End If

                            'ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                            If (m_blnJukihoKaiseiFG) Then

                                'ˆ¶–¼—š—ð•tƒ}ƒXƒ^‚Ìƒf[ƒ^‚ª‘¶Ý‚·‚éê‡Aˆ—‚ðs‚¤
                                If (Not IsNothing(csAtenaFZYDr)) Then

                                    'ˆ¶–¼—š—ð•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                                    If (IsNothing(m_csAtenaRirekiFZYB)) Then
                                        m_csAtenaRirekiFZYB = New ABAtenaRirekiFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                    Else
                                        'ˆ—‚È‚µ
                                    End If

                                    'XV“úŽž‚Ì“¯Šú
                                    csAtenaFZYDr(ABAtenaRirekiFZYEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaRirekiEntity.KOSHINNICHIJI)

                                    'ˆ¶–¼—š—ð•tƒ}ƒXƒ^íœ‚ðŽÀs
                                    intCnt3 = m_csAtenaRirekiFZYB.DeleteAtenaFZYRB(csAtenaFZYDr)

                                End If

                                'ˆ¶–¼—š—ð•t_•W€ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ª‘¶Ý‚·‚éê‡Aˆ—‚ðs‚¤
                                If (Not IsNothing(csAtenaFZYHyojunDr)) Then

                                    'ˆ¶–¼—š—ð•t_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                                    If (IsNothing(m_csAtenaRirekiFZYHyojunB)) Then
                                        m_csAtenaRirekiFZYHyojunB = New ABAtenaRirekiFZY_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                    Else
                                        'ˆ—‚È‚µ
                                    End If

                                    'XV“úŽž‚Ì“¯Šú
                                    csAtenaFZYHyojunDr(ABAtenaRirekiFZYHyojunEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaRirekiEntity.KOSHINNICHIJI)

                                    'ˆ¶–¼—š—ð•t_•W€ƒ}ƒXƒ^íœ‚ðŽÀs
                                    intCnt4 = m_csAtenaRirekiFZYHyojunB.DeleteAtenaRirekiFZYHyojunB(csAtenaFZYHyojunDr)

                                End If

                                'ˆ—‚È‚µ
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return intCnt

                    End Function
                    '*—š—ð”Ô† 000038 2023/08/14 ’Ç‰ÁI—¹
                    '*—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^•¨—íœ
                    '* 
                    '* \•¶           Public Function DeleteAtenaRB(ByVal csDataRow As DataRow, _
                    '*                                              ByVal strSakujoKB As String) As Integer
                    '* 
                    '* ‹@”\@@    @@ˆ¶–¼—š—ðƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð•¨—íœ‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
                    '* 
                    '* –ß‚è’l         Integer : íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
                    '************************************************************************************************
                    Public Overloads Function DeleteAtenaRB(ByVal csDataRow As DataRow, _
                                                            ByVal strSakujoKB As String) As Integer

                        Const THIS_METHOD_NAME As String = "DeleteAtenaRB"
                        Dim objErrorStruct As UFErrorStruct                 ' ƒGƒ‰[’è‹`\‘¢‘Ì
                        Dim cfParam As UFParameterClass                     ' ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        '* corresponds to VS2008 Start 2010/04/16 000029
                        'Dim csDataColumn As DataColumn
                        '* corresponds to VS2008 End 2010/04/16 000029
                        Dim intDelCnt As Integer                            ' íœŒ”


                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' íœ‹æ•ª‚Ìƒ`ƒFƒbƒN‚ðs‚¤
                            If Not (strSakujoKB = "D") Then

                                m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_DELETE_SAKUJOKB)
                                '—áŠO‚ð¶¬
                                Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)

                            End If

                            ' íœ—p‚Ìƒpƒ‰ƒ[ƒ^•tDELETE•¶•¶Žš—ñ‚Æƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                            If (m_strDelButuriSQL Is Nothing Or m_strDelButuriSQL = String.Empty Or _
                                    IsNothing(m_cfDelButuriUFParameterCollectionClass)) Then
                                '* —š—ð”Ô† 000020 2005/06/15 C³ŠJŽn
                                'CreateSQL(csDataRow)
                                Call CreateDeleteButsuriSQL(csDataRow)
                                '* —š—ð”Ô† 000020 2005/06/15 C³I—¹
                            End If

                            ' ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚Öíœs‚©‚ç’l‚ðÝ’è‚·‚éB
                            For Each cfParam In m_cfDelButuriUFParameterCollectionClass

                                ' ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                                If (cfParam.ParameterName.RSubstring(0, ABAtenaRirekiEntity.PREFIX_KEY.RLength) = ABAtenaRirekiEntity.PREFIX_KEY) Then
                                    m_cfDelButuriUFParameterCollectionClass(cfParam.ParameterName).Value _
                                            = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaRirekiEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString()
                                End If
                            Next cfParam


                            '*—š—ð”Ô† 000011 2003/08/28 C³ŠJŽn
                            '' RDBƒAƒNƒZƒXƒƒOo—Í
                            'm_cfLogClass.RdbWrite(m_cfControlData, _
                            '                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                            '                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                            '                        "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                            '                        "ySQL“à—e:" + m_strUpdateSQL + "z")

                            '' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                            'm_cfLogClass.RdbWrite(m_cfControlData, _
                            '                            "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                            '                            "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                            '                            "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                            '                            "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strDelButuriSQL, m_cfDelButuriUFParameterCollectionClass) + "z")
                            '*—š—ð”Ô† 000011 2003/08/28 C³I—¹

                            ' SQL‚ÌŽÀs
                            intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelButuriSQL, m_cfDelButuriUFParameterCollectionClass)

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return intDelCnt

                    End Function
                    '*—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^•¨—íœ
                    '* 
                    '* \•¶           Public Function DeleteAtenaRB() As Integer
                    '* 
                    '* ‹@”\@@    @ ˆ¶–¼—š—ðƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð•¨—íœ‚·‚é
                    '* 
                    '* ˆø”           csAtenaDr As DataRow : •¨—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ðj
                    '* @@           csAtenaFZYDr As DataRow : •¨—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ð•tj
                    '*                strSakujoKB As String F íœ‹æ•ª  
                    '* 
                    '* –ß‚è’l         Integer : íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
                    '************************************************************************************************
                    Public Overloads Function DeleteAtenaRB(ByVal csAtenaDr As DataRow, ByVal csAtenaFZYDr As DataRow, ByVal strSakujoKB As String) As Integer
                        Dim intCnt As Integer = 0
                        Dim intCnt2 As Integer = 0

                        Const THIS_METHOD_NAME As String = "DeleteAtenaB"

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'ˆ¶–¼—š—ðƒ}ƒXƒ^XV‚ðŽÀs
                            intCnt = Me.DeleteAtenaRB(csAtenaDr, strSakujoKB)

                            'ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                            If (Not IsNothing(csAtenaFZYDr)) AndAlso (m_blnJukihoKaiseiFG) Then
                                'ˆ¶–¼—š—ð•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                                If (IsNothing(m_csAtenaRirekiFZYB)) Then
                                    m_csAtenaRirekiFZYB = New ABAtenaRirekiFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                Else
                                    'ˆ—‚È‚µ
                                End If

                                'ˆ¶–¼—š—ð•tƒ}ƒXƒ^•¨—íœŽÀs
                                intCnt2 = m_csAtenaRirekiFZYB.DeleteAtenaFZYRB(csAtenaFZYDr, strSakujoKB)
                            Else
                                'ˆ—‚È‚µ
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return intCnt

                    End Function
                    '*—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000038 2023/08/14 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^•¨—íœ
                    '* 
                    '* \•¶           Public Overloads Function DeleteAtenaRB(ByVal csAtenaDr As DataRow, _
                    '*                                                        ByVal csAtenaHyojunDr As DataRow, _
                    '*                                                        ByVal csAtenaFZYDr As DataRow, _
                    '*                                                        ByVal csAtenaFZYHyojunDr As DataRow, _
                    '*                                                        ByVal strSakujoKB As String) As Integer
                    '* 
                    '* ‹@”\@@    @ ˆ¶–¼—š—ðƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð•¨—íœ‚·‚é
                    '* 
                    '* ˆø”           csAtenaDr As DataRow          : •¨—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ðj
                    '*                csAtenaHyojunDr As DataRow    : •¨—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ð_•W€j
                    '*                csAtenaFZYDr As DataRow       : •¨—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ð•tj
                    '*                csAtenaFZYHyojunDr As DataRow : •¨—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—š—ð•t_•W€j
                    '*                strSakujoKB As String         : íœ‹æ•ª  
                    '* 
                    '* –ß‚è’l         Integer : íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
                    '************************************************************************************************
                    Public Overloads Function DeleteAtenaRB(ByVal csAtenaDr As DataRow, _
                                                            ByVal csAtenaHyojunDr As DataRow, _
                                                            ByVal csAtenaFZYDr As DataRow, _                                    
                                                            ByVal csAtenaFZYHyojunDr As DataRow, _
                                                            ByVal strSakujoKB As String) As Integer

                        Dim intCnt As Integer = 0
                        Dim intCnt2 As Integer = 0
                        Dim intCnt3 As Integer = 0
                        Dim intCnt4 As Integer = 0

                        Const THIS_METHOD_NAME As String = "DeleteAtenaRB"

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'ˆ¶–¼—š—ðƒ}ƒXƒ^XV‚ðŽÀs
                            intCnt = Me.DeleteAtenaRB(csAtenaDr, strSakujoKB)

                            'ˆ¶–¼—š—ð_•W€ƒ}ƒXƒ^‚ª‘¶Ý‚·‚ê‚ÎXV‚ðŽÀs
                            If (Not IsNothing(csAtenaHyojunDr)) Then
                                'ˆ¶–¼—š—ð_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                                If (IsNothing(m_csAtenaRirekiHyojunB)) Then
                                    m_csAtenaRirekiHyojunB = New ABAtenaRireki_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                Else
                                    'ˆ—‚È‚µ
                                End If

                                'ˆ¶–¼—š—ð_•W€ƒ}ƒXƒ^•¨—íœŽÀs
                                intCnt2 = m_csAtenaRirekiHyojunB.DeleteAtenaHyojunRB(csAtenaHyojunDr, strSakujoKB)
                            End If

                            'ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                            If (m_blnJukihoKaiseiFG) Then

                                'ˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ª‘¶Ý‚·‚éê‡AXV‚·‚é
                                If (Not IsNothing(csAtenaFZYDr)) Then
                                    'ˆ¶–¼—š—ð•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                                    If (IsNothing(m_csAtenaRirekiFZYB)) Then
                                        m_csAtenaRirekiFZYB = New ABAtenaRirekiFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                    Else
                                        'ˆ—‚È‚µ
                                    End If

                                    'ˆ¶–¼—š—ð•tƒ}ƒXƒ^•¨—íœŽÀs
                                    intCnt3 = m_csAtenaRirekiFZYB.DeleteAtenaFZYRB(csAtenaFZYDr, strSakujoKB)
                                End If

                                'ˆ¶–¼—š—ð•tƒ}ƒXƒ^‚ª‘¶Ý‚·‚éê‡AXV‚·‚é
                                If (Not IsNothing(csAtenaFZYHyojunDr)) Then
                                    'ˆ¶–¼—š—ð•t_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                                    If (IsNothing(m_csAtenaRirekiFZYHyojunB)) Then
                                        m_csAtenaRirekiFZYHyojunB = New ABAtenaRirekiFZY_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                    Else
                                        'ˆ—‚È‚µ
                                    End If

                                    'ˆ¶–¼—š—ð•t_•W€ƒ}ƒXƒ^•¨—íœŽÀs
                                    intCnt4 = m_csAtenaRirekiFZYHyojunB.DeleteAtenaFZYHyojunRB(csAtenaFZYHyojunDr, strSakujoKB)
                                End If
                            Else
                                'ˆ—‚È‚µ
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return intCnt

                    End Function
                    '*—š—ð”Ô† 000038 2023/08/14 ’Ç‰ÁI—¹

                    '* —š—ð”Ô† 000022 2005/11/18 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^•¨—íœ(‚PZ–¯ƒR[ƒhŽw’è)
                    '* 
                    '* \•¶           Public Overloads Function DeleteAtenaRB(ByVal strJuminCD As String) As Integer
                    '* 
                    '* ‹@”\@@    @@ˆ¶–¼—š—ðƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð•¨—íœ‚·‚é
                    '* 
                    '* ˆø”           strJuminCD As String : íœ‚·‚é‘ÎÛ‚Æ‚È‚éZ–¯ƒR[ƒh
                    '* 
                    '* –ß‚è’l         Integer : íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
                    '************************************************************************************************
                    Public Overloads Function DeleteAtenaRB(ByVal strJuminCD As String) As Integer
                        Const THIS_METHOD_NAME As String = "DeleteAtenaRB"
                        Dim intDelCnt As Integer                            ' íœŒ”

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)


                            ' íœ—p‚Ìƒpƒ‰ƒ[ƒ^•tDELETE•¶•¶Žš—ñ‚Æƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                            If (m_strDelFromJuminCDSQL Is Nothing OrElse m_strDelFromJuminCDSQL = String.Empty OrElse _
                                    IsNothing(m_cfDelFromJuminCDPrmCollection)) Then
                                Call CreateDelFromJuminCDSQL()
                            End If

                            ' ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚Öíœs‚©‚ç’l‚ðÝ’è‚·‚éB
                            m_cfDelFromJuminCDPrmCollection(ABAtenaRirekiEntity.KEY_JUMINCD).Value = strJuminCD

                            '' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                            'm_cfLogClass.RdbWrite(m_cfControlData, _
                            '                            "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                            '                            "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                            '                            "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                            '                            "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strDelFromJuminCDSQL, m_cfDelFromJuminCDPrmCollection) + "z")

                            ' SQL‚ÌŽÀs
                            intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelFromJuminCDSQL, m_cfDelFromJuminCDPrmCollection)

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return intDelCnt

                    End Function

                    '* —š—ð”Ô† 000022 2005/11/18 ’Ç‰ÁI—¹

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     WHERE•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\@@    @@INSERT, UPDATE, DELETE‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '*                strKikanYMD As String : ŠúŠÔ”NŒŽ“ú
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Function CreateWhere(ByVal cSearchKey As ABAtenaSearchKey, ByVal strKikanYMD As String) As String
                        Const THIS_METHOD_NAME As String = "CreateWhere"
                        Dim csWHERE As StringBuilder
                        Dim cfUFParameterClass As UFParameterClass

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' INSERT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfSelectUFParameterCollectionClass = New UFParameterCollectionClass

                            'WHERE‹å‚Ìì¬
                            '* —š—ð”Ô† 000019 2005/01/25 XVŠJŽni‹{‘òj
                            'csWHERE = New StringBuilder()
                            csWHERE = New StringBuilder(256)
                            '* —š—ð”Ô† 000019 2005/01/25 XVI—¹i‹{‘òj

                            'Z–¯ƒR[ƒh
                            If Not (cSearchKey.p_strJuminCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                '*—š—ð”Ô† 000015 2003/11/18 C³ŠJŽn
                                'csWHERE.Append(ABAtenaRirekiEntity.JUMINCD)
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                                '*—š—ð”Ô† 000015 2003/11/18 C³I—¹
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_JUMINCD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUMINCD
                                cfUFParameterClass.Value = cSearchKey.p_strJuminCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            'Z–¯—Dæ‹æ•ª
                            If Not (cSearchKey.p_strJuminYuseniKB.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINYUSENIKB)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_JUMINYUSENIKB)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUMINYUSENIKB
                                cfUFParameterClass.Value = cSearchKey.p_strJuminYuseniKB

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            'Z“oŠO—Dæ‹æ•ª
                            If Not (cSearchKey.p_strJutogaiYusenKB.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUTOGAIYUSENKB)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_JUTOGAIYUSENKB)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUTOGAIYUSENKB
                                cfUFParameterClass.Value = cSearchKey.p_strJutogaiYusenKB

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            '¢‘ÑƒR[ƒh
                            If Not (cSearchKey.p_strStaiCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.STAICD)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_STAICD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_STAICD
                                cfUFParameterClass.Value = cSearchKey.p_strStaiCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            '*—š—ð”Ô† 000036 2020/01/10 C³ŠJŽn
                            ''ŒŸõ—pƒJƒi©–¼
                            'If Not (cSearchKey.p_strSearchKanaSeiMei.Trim = String.Empty) Then
                            '    If Not (csWHERE.Length = 0) Then
                            '        csWHERE.Append(" AND ")
                            '    End If

                            '    If cSearchKey.p_strSearchKanaSeiMei.IndexOf("%") = -1 Then
                            '        csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEARCHKANASEIMEI)
                            '        csWHERE.Append(" = ")
                            '        csWHERE.Append(ABAtenaRirekiEntity.KEY_SEARCHKANASEIMEI)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_SEARCHKANASEIMEI
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanaSeiMei
                            '    Else
                            '        csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEARCHKANASEIMEI)
                            '        csWHERE.Append(" LIKE ")
                            '        csWHERE.Append(ABAtenaRirekiEntity.KEY_SEARCHKANASEIMEI)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_SEARCHKANASEIMEI
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanaSeiMei.TrimEnd
                            '    End If
                            '    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            'End If

                            ''ŒŸõ—pƒJƒi©
                            'If Not (cSearchKey.p_strSearchKanaSei.Trim = String.Empty) Then
                            '    If Not (csWHERE.Length = 0) Then
                            '        csWHERE.Append(" AND ")
                            '    End If
                            '    '* —š—ð”Ô† 000027 2007/10/10 ’Ç‰ÁŠJŽn
                            '    ' ŒŸõ—pƒJƒi©‚Q‚ÉŒŸõƒL[‚ªŠi”[‚³‚ê‚Ä‚¢‚éê‡‚ÍŒŸõðŒ‚Æ‚µ‚Ä’Ç‰Á
                            '    If (cSearchKey.p_strSearchKanaSei2.Trim() <> String.Empty) Then
                            '        csWHERE.Append(" ( ")
                            '    End If
                            '    '* —š—ð”Ô† 000027 2007/10/10 ’Ç‰ÁI—¹
                            '    If cSearchKey.p_strSearchKanaSei.IndexOf("%") = -1 Then
                            '        csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEARCHKANASEI)
                            '        csWHERE.Append(" = ")
                            '        csWHERE.Append(ABAtenaRirekiEntity.KEY_SEARCHKANASEI)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_SEARCHKANASEI
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanaSei

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '        m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '    Else
                            '        csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEARCHKANASEI)
                            '        csWHERE.Append(" LIKE ")
                            '        csWHERE.Append(ABAtenaRirekiEntity.KEY_SEARCHKANASEI)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_SEARCHKANASEI
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanaSei.TrimEnd

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '        m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '    End If
                            'End If

                            ''* —š—ð”Ô† 000027 2007/10/10 ’Ç‰ÁŠJŽn
                            '' ŒŸõ—pƒJƒi©‚QORðŒ
                            '' ŒŸõ—pƒJƒi©‚Q‚ÉŒŸõƒL[‚ªŠi”[‚³‚ê‚Ä‚¢‚éê‡‚ÍŒŸõðŒ‚Æ‚µ‚Ä’Ç‰Á
                            'If (cSearchKey.p_strSearchKanaSei2.Trim() <> String.Empty) Then
                            '    csWHERE.Append(" OR ")
                            '    If cSearchKey.p_strSearchKanaSei2.IndexOf("%") = -1 Then
                            '        csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEARCHKANASEI)
                            '        csWHERE.Append(" = ")
                            '        csWHERE.Append(ABAtenaRirekiEntity.KEY_SEARCHKANASEI2)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_SEARCHKANASEI2
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanaSei2

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '        m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '    Else
                            '        csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEARCHKANASEI)
                            '        csWHERE.Append(" LIKE ")
                            '        csWHERE.Append(ABAtenaRirekiEntity.KEY_SEARCHKANASEI2)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_SEARCHKANASEI2
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanaSei2.TrimEnd

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '        m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '    End If
                            '    ' ORðŒ‚ÍŒŸõ—pƒJƒi©‚Ì‚Ý‚Å‚ÌðŒ‚È‚Ì‚ÅŠ‡ŒÊ‚ÅŠ‡‚é
                            '    csWHERE.Append(" ) ")
                            'End If
                            ''* —š—ð”Ô† 000027 2007/10/10 ’Ç‰ÁI—¹

                            ''ŒŸõ—pƒJƒi–¼
                            'If Not (cSearchKey.p_strSearchKanaMei.Trim = String.Empty) Then
                            '    If Not (csWHERE.Length = 0) Then
                            '        csWHERE.Append(" AND ")
                            '    End If
                            '    If cSearchKey.p_strSearchKanaMei.IndexOf("%") = -1 Then
                            '        csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEARCHKANAMEI)
                            '        csWHERE.Append(" = ")
                            '        csWHERE.Append(ABAtenaRirekiEntity.KEY_SEARCHKANAMEI)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_SEARCHKANAMEI
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanaMei

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '        m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '    Else
                            '        csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEARCHKANAMEI)
                            '        csWHERE.Append(" LIKE ")
                            '        csWHERE.Append(ABAtenaRirekiEntity.KEY_SEARCHKANAMEI)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_SEARCHKANAMEI
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanaMei.TrimEnd

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '        m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '    End If
                            'End If

                            ''ŒŸõ—pŠ¿Žš–¼Ì
                            'If Not (cSearchKey.p_strSearchKanjiMeisho.Trim = String.Empty) Then
                            '    If Not (csWHERE.Length = 0) Then
                            '        csWHERE.Append(" AND ")
                            '    End If
                            '    If cSearchKey.p_strSearchKanjiMeisho.IndexOf("%") = -1 Then
                            '        csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEARCHKANJIMEISHO)
                            '        csWHERE.Append(" = ")
                            '        csWHERE.Append(ABAtenaRirekiEntity.PARAM_SEARCHKANJIMEISHO)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_SEARCHKANJIMEISHO
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanjiMeisho

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '        m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '    Else
                            '        csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEARCHKANJIMEISHO)
                            '        csWHERE.Append(" LIKE ")
                            '        csWHERE.Append(ABAtenaRirekiEntity.PARAM_SEARCHKANJIMEISHO)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_SEARCHKANJIMEISHO
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanjiMeisho.TrimEnd

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '        m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '    End If
                            'End If

                            ''* —š—ð”Ô† 000026 2007/09/04 ’Ç‰ÁŠJŽn
                            '' –{–¼Š¿Žš©–¼ –{–¼ŒŸõ="2(Tsusho_Seishiki)"‚Ì‚Æ‚«‚Ì‚ÝŠ¿ŽšŽ–¼‚Q‚ÍŒŸõ€–Ú‚Æ‚È‚é
                            'If (cSearchKey.p_enGaikokuHommyoKensaku = FrnHommyoKensakuType.Tsusho_Seishiki) Then
                            '    If Not (cSearchKey.p_strKanjiMeisho2.Trim = String.Empty) Then
                            '        If Not (csWHERE.Length = 0) Then
                            '            csWHERE.Append(" AND ")
                            '        End If
                            '        If cSearchKey.p_strKanjiMeisho2.IndexOf("%") = -1 Then
                            '            csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANJIMEISHO2)
                            '            csWHERE.Append(" = ")
                            '            csWHERE.Append(ABAtenaEntity.PARAM_KANJIMEISHO2)

                            '            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '            cfUFParameterClass = New UFParameterClass
                            '            cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_KANJIMEISHO2
                            '            cfUFParameterClass.Value = cSearchKey.p_strKanjiMeisho2

                            '            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '            m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '        Else
                            '            csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANJIMEISHO2)
                            '            csWHERE.Append(" LIKE ")
                            '            csWHERE.Append(ABAtenaEntity.PARAM_KANJIMEISHO2)

                            '            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '            cfUFParameterClass = New UFParameterClass
                            '            cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_KANJIMEISHO2
                            '            cfUFParameterClass.Value = cSearchKey.p_strKanjiMeisho2.TrimEnd

                            '            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '            m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '        End If
                            '    End If
                            'End If
                            ''* —š—ð”Ô† 000026 2007/09/04 ’Ç‰ÁI—¹

                            ' Ž–¼ŒŸõðŒ‚ð¶¬
                            m_cKensakuShimeiB.CreateWhereForShimei(cSearchKey, ABAtenaRirekiEntity.TABLE_NAME, csWHERE, m_cfSelectUFParameterCollectionClass,
                                                                   ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, True, m_intHyojunKB)
                            '*—š—ð”Ô† 000036 2020/01/10 C³I—¹

                            '¶”NŒŽ“ú
                            If Not (cSearchKey.p_strUmareYMD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                If cSearchKey.p_strUmareYMD.RIndexOf("%") = -1 Then
                                    csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.UMAREYMD)
                                    csWHERE.Append(" = ")
                                    csWHERE.Append(ABAtenaRirekiEntity.KEY_UMAREYMD)

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                    cfUFParameterClass = New UFParameterClass
                                    cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_UMAREYMD
                                    cfUFParameterClass.Value = cSearchKey.p_strUmareYMD

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                                Else
                                    csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.UMAREYMD)
                                    csWHERE.Append(" LIKE ")
                                    csWHERE.Append(ABAtenaRirekiEntity.KEY_UMAREYMD)

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                    cfUFParameterClass = New UFParameterClass
                                    cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_UMAREYMD
                                    cfUFParameterClass.Value = cSearchKey.p_strUmareYMD.TrimEnd

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                                End If

                            End If

                            '«•Ê
                            If Not (cSearchKey.p_strSeibetsuCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEIBETSUCD)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_SEIBETSUCD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_SEIBETSUCD
                                cfUFParameterClass.Value = cSearchKey.p_strSeibetsuCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            'ZŠƒR[ƒh
                            If Not (cSearchKey.p_strJushoCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUSHOCD)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_JUSHOCD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUSHOCD
                                cfUFParameterClass.Value = cSearchKey.p_strJushoCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            's­‹æƒR[ƒh
                            If Not (cSearchKey.p_strGyoseikuCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.GYOSEIKUCD)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_GYOSEIKUCD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_GYOSEIKUCD
                                cfUFParameterClass.Value = cSearchKey.p_strGyoseikuCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            '’n‹æƒR[ƒh‚P
                            If Not (cSearchKey.p_strChikuCD1.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CHIKUCD1)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.PARAM_CHIKUCD1)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_CHIKUCD1
                                cfUFParameterClass.Value = cSearchKey.p_strChikuCD1

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            '’n‹æƒR[ƒh‚Q
                            If Not (cSearchKey.p_strChikuCD2.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CHIKUCD2)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.PARAM_CHIKUCD2)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_CHIKUCD2
                                cfUFParameterClass.Value = cSearchKey.p_strChikuCD2

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            '’n‹æƒR[ƒh‚R
                            If Not (cSearchKey.p_strChikuCD3.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CHIKUCD3)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.PARAM_CHIKUCD3)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_CHIKUCD3
                                cfUFParameterClass.Value = cSearchKey.p_strChikuCD3

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            '”Ô’nƒR[ƒh‚P
                            If Not (cSearchKey.p_strBanchiCD1.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.BANCHICD1)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_BANCHICD1)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_BANCHICD1
                                cfUFParameterClass.Value = cSearchKey.p_strBanchiCD1

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            '”Ô’nƒR[ƒh‚Q
                            If Not (cSearchKey.p_strBanchiCD2.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.BANCHICD2)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_BANCHICD2)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_BANCHICD2
                                cfUFParameterClass.Value = cSearchKey.p_strBanchiCD2

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            '”Ô’nƒR[ƒh‚R
                            If Not (cSearchKey.p_strBanchiCD3.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.BANCHICD3)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_BANCHICD3)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_BANCHICD3
                                cfUFParameterClass.Value = cSearchKey.p_strBanchiCD3

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            'ZŠîZŠƒR[ƒh
                            If Not (cSearchKey.p_strJukiJushoCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIJUSHOCD)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_JUKIJUSHOCD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUKIJUSHOCD
                                cfUFParameterClass.Value = cSearchKey.p_strJukiJushoCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            'ZŠîs­‹æƒR[ƒh
                            If Not (cSearchKey.p_strJukiGyoseikuCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIGYOSEIKUCD)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_JUKIGYOSEIKUCD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUKIGYOSEIKUCD
                                cfUFParameterClass.Value = cSearchKey.p_strJukiGyoseikuCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            'ZŠî’n‹æƒR[ƒh‚P
                            If Not (cSearchKey.p_strJukiChikuCD1.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKICHIKUCD1)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.PARAM_JUKICHIKUCD1)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_JUKICHIKUCD1
                                cfUFParameterClass.Value = cSearchKey.p_strJukiChikuCD1

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            'ZŠî’n‹æƒR[ƒh‚Q
                            If Not (cSearchKey.p_strJukiChikuCD2.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKICHIKUCD2)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.PARAM_JUKICHIKUCD2)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_JUKICHIKUCD2
                                cfUFParameterClass.Value = cSearchKey.p_strJukiChikuCD2

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            'ZŠî’n‹æƒR[ƒh‚R
                            If Not (cSearchKey.p_strJukiChikuCD3.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKICHIKUCD3)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.PARAM_JUKICHIKUCD3)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_JUKICHIKUCD3
                                cfUFParameterClass.Value = cSearchKey.p_strJukiChikuCD3

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            'ZŠî”Ô’nƒR[ƒh‚P
                            If Not (cSearchKey.p_strJukiBanchiCD1.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIBANCHICD1)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_JUKIBANCHICD1)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUKIBANCHICD1
                                cfUFParameterClass.Value = cSearchKey.p_strJukiBanchiCD1

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            'ZŠî”Ô’nƒR[ƒh‚Q
                            If Not (cSearchKey.p_strJukiBanchiCD2.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIBANCHICD2)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_JUKIBANCHICD2)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUKIBANCHICD2
                                cfUFParameterClass.Value = cSearchKey.p_strJukiBanchiCD2

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            'ZŠî”Ô’nƒR[ƒh‚R
                            If Not (cSearchKey.p_strJukiBanchiCD3.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIBANCHICD3)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_JUKIBANCHICD3)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUKIBANCHICD3
                                cfUFParameterClass.Value = cSearchKey.p_strJukiBanchiCD3

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            'ƒf[ƒ^‹æ•ª
                            If Not (cSearchKey.p_strDataKB.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                '*—š—ð”Ô† 000015 2003/11/18 C³ŠJŽn
                                'csWHERE.Append(ABAtenaRirekiEntity.ATENADATAKB)
                                'csWHERE.Append(" = ")
                                'csWHERE.Append(ABAtenaRirekiEntity.PARAM_ATENADATAKB)

                                If cSearchKey.p_strDataKB.RIndexOf("%") = -1 Then
                                    csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ATENADATAKB)
                                    csWHERE.Append(" = ")
                                    csWHERE.Append(ABAtenaRirekiEntity.PARAM_ATENADATAKB)
                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                Else
                                    csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ATENADATAKB)
                                    csWHERE.Append(" LIKE ")
                                    csWHERE.Append(ABAtenaRirekiEntity.PARAM_ATENADATAKB)
                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                End If
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_ATENADATAKB
                                cfUFParameterClass.Value = cSearchKey.p_strDataKB

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                                '*—š—ð”Ô† 000015 2003/11/18 C³I—¹


                            End If

                            If Not ((cSearchKey.p_strJuminShubetu1 = String.Empty) And (cSearchKey.p_strJuminShubetu2 = String.Empty)) Then
                                If (cSearchKey.p_strDataKB.Trim = String.Empty) Then
                                    If Not (csWHERE.RLength = 0) Then
                                        csWHERE.Append(" AND ")
                                    End If
                                    csWHERE.Append("((")
                                    csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ATENADATAKB)
                                    csWHERE.Append(" = '11')")
                                    csWHERE.Append(" OR (")
                                    csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ATENADATAKB)
                                    csWHERE.Append(" = '12'))")
                                End If

                                'Z–¯Ží•Ê‚P
                                If Not (cSearchKey.p_strJuminShubetu1.Trim = String.Empty) Then
                                    If Not (csWHERE.RLength = 0) Then
                                        csWHERE.Append(" AND ")
                                    End If
                                    csWHERE.Append(" {fn SUBSTRING(")
                                    csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ATENADATASHU)
                                    csWHERE.Append(",1,1)} = '")
                                    csWHERE.Append(cSearchKey.p_strJuminShubetu1)
                                    csWHERE.Append("'")
                                End If

                                'Z–¯Ží•Ê‚Q
                                If Not (cSearchKey.p_strJuminShubetu2.Trim = String.Empty) Then
                                    If Not (csWHERE.RLength = 0) Then
                                        csWHERE.Append(" AND ")
                                    End If
                                    csWHERE.Append(" {fn SUBSTRING(")
                                    csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ATENADATASHU)
                                    csWHERE.Append(",2,1)} = '")
                                    csWHERE.Append(cSearchKey.p_strJuminShubetu2)
                                    csWHERE.Append("'")
                                End If
                            End If

                            'ŠúŠÔ”NŒŽ“ú

                            If Not (strKikanYMD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If

                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.RRKST_YMD)
                                csWHERE.Append(" <= ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_RRKST_YMD)
                                csWHERE.Append(" AND ")
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.RRKED_YMD)
                                csWHERE.Append(" >= ")
                                csWHERE.Append(ABAtenaRirekiEntity.KEY_RRKED_YMD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_RRKST_YMD
                                cfUFParameterClass.Value = strKikanYMD
                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_RRKED_YMD
                                cfUFParameterClass.Value = strKikanYMD
                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            'Žs’¬‘ºƒR[ƒh
                            If Not (cSearchKey.p_strShichosonCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                '*—š—ð”Ô† 000015 2003/11/18 C³ŠJŽn
                                'csWHERE.Append(ABAtenaRirekiEntity.SHICHOSONCD)
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SHICHOSONCD)
                                '*—š—ð”Ô† 000015 2003/11/18 C³I—¹
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.PARAM_SHICHOSONCD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_SHICHOSONCD
                                cfUFParameterClass.Value = cSearchKey.p_strShichosonCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            '*—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                            ' --------------------------------------------------------------------------------------------------------
                            ' ‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡
                            If (cSearchKey.p_strMyNumber.Trim.RLength > 0) Then

                                ' -----------------------------------------------------------------------------------------------------
                                ' y‚PD’¼‹ßŒŸõ‹æ•ª‚É‚æ‚é§Œäz
                                ' ’¼‹ßŒŸõ‹æ•ª‚Ì®”õ
                                Select Case cSearchKey.p_strMyNumberChokkinSearchKB
                                    Case ABEnumDefine.MyNumberChokkinSearchKB.CKIN.GetHashCode.ToString,
                                         ABEnumDefine.MyNumberChokkinSearchKB.RRK.GetHashCode.ToString
                                        ' noop
                                    Case Else
                                        ' ‹K’è’lˆÈŠOi’l‚È‚µ‚ðŠÜ‚Þj‚Ìê‡AŠÇ—î•ñ“o˜^’l‚É‚Ä§Œä‚·‚éB
                                        cSearchKey.p_strMyNumberChokkinSearchKB = m_strMyNumberChokkinSearchKB_Param
                                End Select

                                ' ’¼‹ßŒŸõ‹æ•ª‚ª"1"i’¼‹ß‚Ì‚Ýj‚Ìê‡
                                If (cSearchKey.p_strMyNumberChokkinSearchKB = ABEnumDefine.MyNumberChokkinSearchKB.CKIN.GetHashCode.ToString) Then

                                    ' ‹¤’Ê”Ô†ƒJƒ‰ƒ€‚É‹¤’Ê”Ô†‚ðŽw’è‚·‚éB
                                    If (csWHERE.RLength > 0) Then
                                        csWHERE.Append(" AND ")
                                    Else
                                        ' noop
                                    End If
                                    csWHERE.AppendFormat("{0}.{1} = {2}",
                                                         ABMyNumberEntity.TABLE_NAME, ABMyNumberEntity.MYNUMBER,
                                                         ABMyNumberEntity.PARAM_MYNUMBER)

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^[‚ðì¬
                                    cfUFParameterClass = New UFParameterClass
                                    cfUFParameterClass.ParameterName = ABMyNumberEntity.PARAM_MYNUMBER
                                    cfUFParameterClass.Value = cSearchKey.p_strMyNumber

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)

                                Else

                                    ' ‹¤’Ê”Ô†ƒ}ƒXƒ^‚Ö‚ÌƒTƒuƒNƒGƒŠ‚É‹¤’Ê”Ô†‚ðŽw’è‚·‚éB
                                    If (csWHERE.RLength > 0) Then
                                        csWHERE.Append(" AND ")
                                    Else
                                        ' noop
                                    End If
                                    csWHERE.AppendFormat("{0}.{1} ", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUMINCD)
                                    csWHERE.Append("IN ( ")
                                    csWHERE.AppendFormat("SELECT {0} FROM {1} ", ABMyNumberEntity.JUMINCD, ABMyNumberEntity.TABLE_NAME)
                                    csWHERE.AppendFormat("WHERE {0} = {1} ", ABMyNumberEntity.MYNUMBER, ABMyNumberEntity.PARAM_MYNUMBER)
                                    csWHERE.Append(")")

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^[‚ðì¬
                                    cfUFParameterClass = New UFParameterClass
                                    cfUFParameterClass.ParameterName = ABMyNumberEntity.PARAM_MYNUMBER
                                    cfUFParameterClass.Value = cSearchKey.p_strMyNumber

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)

                                End If
                                ' -----------------------------------------------------------------------------------------------------
                                ' y‚QDŒÂl–@l‹æ•ª‚É‚æ‚é§Œäz
                                ' ŒÂl–@l‹æ•ª‚ª"1"iŒÂljA‚Ü‚½‚Í"2"i–@lj‚Ìê‡
                                If (cSearchKey.p_strMyNumberKojinHojinKB = "1" _
                                    OrElse cSearchKey.p_strMyNumberKojinHojinKB = "2") Then

                                    ' ŒÂl–@l‹æ•ªƒJƒ‰ƒ€‚ÉŒÂl–@l‹æ•ª‚ðŽw’è‚·‚éB
                                    If (csWHERE.RLength > 0) Then
                                        csWHERE.Append(" AND ")
                                    Else
                                        ' noop
                                    End If
                                    csWHERE.AppendFormat("{0}.{1} = {2}",
                                                         ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KJNHJNKB,
                                                         ABAtenaRirekiEntity.PARAM_KJNHJNKB)

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^[‚ðì¬
                                    cfUFParameterClass = New UFParameterClass
                                    cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_KJNHJNKB
                                    cfUFParameterClass.Value = cSearchKey.p_strMyNumberKojinHojinKB

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)

                                Else
                                    ' noop
                                End If
                                ' -----------------------------------------------------------------------------------------------------

                            Else
                                ' noop
                            End If
                            ' --------------------------------------------------------------------------------------------------------
                            '*—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹            

                            '“d˜b”Ô†
                            If Not (cSearchKey.p_strRenrakusaki.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append("((")
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.RENRAKUSAKI1)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.PARAM_RENRAKUSAKI1)
                                csWHERE.Append(") OR (")
                                csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.RENRAKUSAKI2)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaRirekiEntity.PARAM_RENRAKUSAKI2)
                                csWHERE.Append("))")

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_RENRAKUSAKI1
                                cfUFParameterClass.Value = cSearchKey.p_strRenrakusaki

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_RENRAKUSAKI2
                                cfUFParameterClass.Value = cSearchKey.p_strRenrakusaki

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            If (m_intHyojunKB = ABEnumDefine.HyojunKB.KB_Hyojun) Then
                                'ZŠ
                                If Not (cSearchKey.p_strJusho.Trim = String.Empty) Then
                                    If Not (csWHERE.RLength = 0) Then
                                        csWHERE.Append(" AND ")
                                    End If
                                    If (cSearchKey.p_strJusho.RIndexOf("%") = -1) Then
                                        csWHERE.Append(ABAtenaRirekiHyojunEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiHyojunEntity.SEARCHJUSHO)
                                        csWHERE.Append(" = ")
                                        csWHERE.Append(ABAtenaRirekiHyojunEntity.PARAM_SEARCHJUSHO)
                                    Else
                                        csWHERE.Append(ABAtenaRirekiHyojunEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiHyojunEntity.SEARCHJUSHO)
                                        csWHERE.Append(" LIKE ")
                                        csWHERE.Append(ABAtenaRirekiHyojunEntity.PARAM_SEARCHJUSHO)
                                    End If
                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                    cfUFParameterClass = New UFParameterClass
                                    cfUFParameterClass.ParameterName = ABAtenaRirekiHyojunEntity.PARAM_SEARCHJUSHO
                                    cfUFParameterClass.Value = cSearchKey.p_strJusho

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                                End If

                                '•û‘
                                If Not (cSearchKey.p_strKatagaki.Trim = String.Empty) Then
                                    If Not (csWHERE.RLength = 0) Then
                                        csWHERE.Append(" AND ")
                                    End If
                                    If cSearchKey.p_strKatagaki.RIndexOf("%") = -1 Then
                                        csWHERE.Append(ABAtenaRirekiHyojunEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiHyojunEntity.SEARCHKATAGAKI)
                                        csWHERE.Append(" = ")
                                        csWHERE.Append(ABAtenaRirekiHyojunEntity.PARAM_SEARCHKATAGAKI)
                                    Else
                                        csWHERE.Append(ABAtenaRirekiHyojunEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiHyojunEntity.SEARCHKATAGAKI)
                                        csWHERE.Append(" LIKE ")
                                        csWHERE.Append(ABAtenaRirekiHyojunEntity.PARAM_SEARCHKATAGAKI)
                                    End If
                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                    cfUFParameterClass = New UFParameterClass
                                    cfUFParameterClass.ParameterName = ABAtenaRirekiHyojunEntity.PARAM_SEARCHKATAGAKI
                                    cfUFParameterClass.Value = cSearchKey.p_strKatagaki

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                                End If

                                '‹ŒŽ
                                If Not (cSearchKey.p_strKyuuji.Trim = String.Empty) Then
                                    If Not (csWHERE.RLength = 0) Then
                                        csWHERE.Append(" AND ")
                                    End If
                                    If cSearchKey.p_strKyuuji.RIndexOf("%") = -1 Then
                                        csWHERE.Append(ABAtenaRirekiHyojunEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiHyojunEntity.SEARCHKANJIKYUUJI)
                                        csWHERE.Append(" = ")
                                        csWHERE.Append(ABAtenaRirekiHyojunEntity.PARAM_SEARCHKANJIKYUUJI)
                                    Else
                                        csWHERE.Append(ABAtenaRirekiHyojunEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiHyojunEntity.SEARCHKANJIKYUUJI)
                                        csWHERE.Append(" LIKE ")
                                        csWHERE.Append(ABAtenaRirekiHyojunEntity.PARAM_SEARCHKANJIKYUUJI)
                                    End If
                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                    cfUFParameterClass = New UFParameterClass
                                    cfUFParameterClass.ParameterName = ABAtenaRirekiHyojunEntity.PARAM_SEARCHKANJIKYUUJI
                                    cfUFParameterClass.Value = cSearchKey.p_strKyuuji

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                                End If

                                'ƒJƒi‹ŒŽ
                                If Not (cSearchKey.p_strKanaKyuuji.Trim = String.Empty) Then
                                    If Not (csWHERE.RLength = 0) Then
                                        csWHERE.Append(" AND ")
                                    End If
                                    If cSearchKey.p_strKanaKyuuji.RIndexOf("%") = -1 Then
                                        csWHERE.Append(ABAtenaRirekiHyojunEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiHyojunEntity.SEARCHKANAKYUUJI)
                                        csWHERE.Append(" = ")
                                        csWHERE.Append(ABAtenaRirekiHyojunEntity.PARAM_SEARCHKANAKYUUJI)
                                    Else
                                        csWHERE.Append(ABAtenaRirekiHyojunEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiHyojunEntity.SEARCHKANAKYUUJI)
                                        csWHERE.Append(" LIKE ")
                                        csWHERE.Append(ABAtenaRirekiHyojunEntity.PARAM_SEARCHKANAKYUUJI)
                                    End If
                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                    cfUFParameterClass = New UFParameterClass
                                    cfUFParameterClass.ParameterName = ABAtenaRirekiHyojunEntity.PARAM_SEARCHKANAKYUUJI
                                    cfUFParameterClass.Value = cSearchKey.p_strKanaKyuuji

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                                End If

                                'ƒJƒ^ƒJƒi•¹‹L–¼
                                If Not (cSearchKey.p_strKatakanaHeikimei.Trim = String.Empty) Then
                                    If Not (csWHERE.RLength = 0) Then
                                        csWHERE.Append(" AND ")
                                    End If
                                    If cSearchKey.p_strKatakanaHeikimei.RIndexOf("%") = -1 Then
                                        csWHERE.Append(ABAtenaRirekiFZYEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiFZYEntity.KATAKANAHEIKIMEI)
                                        csWHERE.Append(" = ")
                                        csWHERE.Append(ABAtenaRirekiFZYEntity.PARAM_KATAKANAHEIKIMEI)
                                    Else
                                        csWHERE.Append(ABAtenaRirekiFZYEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiFZYEntity.KATAKANAHEIKIMEI)
                                        csWHERE.Append(" LIKE ")
                                        csWHERE.Append(ABAtenaRirekiFZYEntity.PARAM_KATAKANAHEIKIMEI)
                                    End If
                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                    cfUFParameterClass = New UFParameterClass
                                    cfUFParameterClass.ParameterName = ABAtenaRirekiFZYEntity.PARAM_KATAKANAHEIKIMEI
                                    cfUFParameterClass.Value = cSearchKey.p_strKatakanaHeikimei

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                                End If
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return csWHERE.ToString

                    End Function

                    '* corresponds to VS2008 Start 2010/04/16 000029
                    '* —š—ð”Ô† 000020 2005/06/15 íœŠJŽn
                    ''''************************************************************************************************
                    ''''* ƒƒ\ƒbƒh–¼     SQL•¶‚Ìì¬
                    ''''* 
                    ''''* \•¶           Private Sub CreateSQL(ByVal csDataRow As DataRow)
                    ''''* 
                    ''''* ‹@”\@@    @@INSERT, UPDATE, DELETE‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    ''''* 
                    ''''* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    ''''* 
                    ''''* –ß‚è’l         ‚È‚µ
                    ''''************************************************************************************************
                    ''Private Sub CreateSQL(ByVal csDataRow As DataRow)

                    ''    Const THIS_METHOD_NAME As String = "CreateSQL"
                    ''    Dim csDataColumn As DataColumn
                    ''    Dim cfUFParameterClass As UFParameterClass
                    ''    Dim csInsertColumn As StringBuilder                 'INSERT—pƒJƒ‰ƒ€’è‹`
                    ''    Dim csInsertParam As StringBuilder                  'INSERT—pƒpƒ‰ƒ[ƒ^’è‹`
                    ''    Dim csWhere As StringBuilder                        'WHERE’è‹`
                    ''    Dim csUpdateParam As StringBuilder                  'UPDATE—pSQL’è‹`
                    ''    Dim csDelRonriParam As StringBuilder                '˜_—íœƒpƒ‰ƒ[ƒ^’è‹`


                    ''    Try
                    '''' ƒfƒoƒbƒOƒƒOo—Í
                    ''m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                    '''' SELECT SQL•¶‚Ìì¬
                    ''m_strInsertSQL = "INSERT INTO " + ABAtenaRirekiEntity.TABLE_NAME + " "
                    ''csInsertColumn = New StringBuilder()
                    ''csInsertParam = New StringBuilder()


                    '''' UPDATE SQL•¶‚Ìì¬
                    ''m_strUpdateSQL = "UPDATE " + ABAtenaRirekiEntity.TABLE_NAME + " SET "
                    ''csUpdateParam = New StringBuilder()


                    '''' WHERE•¶‚Ìì¬
                    ''csWhere = New StringBuilder()
                    ''csWhere.Append(" WHERE ")
                    ''csWhere.Append(ABAtenaRirekiEntity.JUMINCD)
                    ''csWhere.Append(" = ")
                    ''csWhere.Append(ABAtenaRirekiEntity.KEY_JUMINCD)
                    ''csWhere.Append(" AND ")
                    ''csWhere.Append(ABAtenaRirekiEntity.RIREKINO)
                    ''csWhere.Append(" = ")
                    ''csWhere.Append(ABAtenaRirekiEntity.KEY_RIREKINO)
                    ''csWhere.Append(" AND ")
                    ''csWhere.Append(ABAtenaRirekiEntity.KOSHINCOUNTER)
                    ''csWhere.Append(" = ")
                    ''csWhere.Append(ABAtenaRirekiEntity.KEY_KOSHINCOUNTER)


                    '''' ˜_—DELETE SQL•¶‚Ìì¬
                    ''csDelRonriParam = New StringBuilder()
                    ''csDelRonriParam.Append("UPDATE ")
                    ''csDelRonriParam.Append(ABAtenaRirekiEntity.TABLE_NAME)
                    ''csDelRonriParam.Append(" SET ")
                    ''csDelRonriParam.Append(ABAtenaRirekiEntity.TANMATSUID)
                    ''csDelRonriParam.Append(" = ")
                    ''csDelRonriParam.Append(ABAtenaRirekiEntity.PARAM_TANMATSUID)
                    ''csDelRonriParam.Append(", ")
                    ''csDelRonriParam.Append(ABAtenaRirekiEntity.SAKUJOFG)
                    ''csDelRonriParam.Append(" = ")
                    ''csDelRonriParam.Append(ABAtenaRirekiEntity.PARAM_SAKUJOFG)
                    ''csDelRonriParam.Append(", ")
                    ''csDelRonriParam.Append(ABAtenaRirekiEntity.KOSHINCOUNTER)
                    ''csDelRonriParam.Append(" = ")
                    ''csDelRonriParam.Append(ABAtenaRirekiEntity.PARAM_KOSHINCOUNTER)
                    ''csDelRonriParam.Append(", ")
                    ''csDelRonriParam.Append(ABAtenaRirekiEntity.KOSHINNICHIJI)
                    ''csDelRonriParam.Append(" = ")
                    ''csDelRonriParam.Append(ABAtenaRirekiEntity.PARAM_KOSHINNICHIJI)
                    ''csDelRonriParam.Append(", ")
                    ''csDelRonriParam.Append(ABAtenaRirekiEntity.KOSHINUSER)
                    ''csDelRonriParam.Append(" = ")
                    ''csDelRonriParam.Append(ABAtenaRirekiEntity.PARAM_KOSHINUSER)
                    ''csDelRonriParam.Append(csWhere)
                    ''m_strDelRonriSQL = csDelRonriParam.ToString

                    '''' •¨—DELETE SQL•¶‚Ìì¬
                    ''m_strDelButuriSQL = "DELETE FROM " + ABAtenaRirekiEntity.TABLE_NAME + csWhere.ToString

                    '''' INSERT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    ''m_cfInsertUFParameterCollectionClass = New UFParameterCollectionClass()

                    '''' UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    ''m_cfUpdateUFParameterCollectionClass = New UFParameterCollectionClass()

                    '''' ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    ''m_cfDelRonriUFParameterCollectionClass = New UFParameterCollectionClass()

                    '''' •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    ''m_cfDelButuriUFParameterCollectionClass = New UFParameterCollectionClass()


                    '''' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                    ''For Each csDataColumn In csDataRow.Table.Columns
                    ''    cfUFParameterClass = New UFParameterClass()

                    '''' INSERT SQL•¶‚Ìì¬
                    ''csInsertColumn.Append(csDataColumn.ColumnName)
                    ''csInsertColumn.Append(", ")

                    ''csInsertParam.Append(ABAtenaRirekiEntity.PARAM_PLACEHOLDER)
                    ''csInsertParam.Append(csDataColumn.ColumnName)
                    ''csInsertParam.Append(", ")


                    '''' UPDATE SQL•¶‚Ìì¬
                    ''csUpdateParam.Append(csDataColumn.ColumnName)
                    ''csUpdateParam.Append(" = ")
                    ''csUpdateParam.Append(ABAtenaRirekiEntity.PARAM_PLACEHOLDER)
                    ''csUpdateParam.Append(csDataColumn.ColumnName)
                    ''csUpdateParam.Append(", ")

                    '''' INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    ''cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                    ''m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass)

                    '''' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    ''cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                    ''m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                    ''Next csDataColumn

                    ''''ÅŒã‚ÌƒJƒ“ƒ}‚ðŽæ‚èœ‚¢‚ÄINSERT•¶‚ðì¬
                    ''m_strInsertSQL += "(" + csInsertColumn.ToString.TrimEnd(" ".ToCharArray()).TrimEnd(",".ToCharArray()) + ")" _
                    ''        + " VALUES (" + csInsertParam.ToString.TrimEnd(" ".ToCharArray()).TrimEnd(",".ToCharArray()) + ")"


                    '''' UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                    ''m_strUpdateSQL += csUpdateParam.ToString.TrimEnd(" ".ToCharArray()).TrimEnd(",".ToCharArray())

                    '''' UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                    ''m_strUpdateSQL += csWhere.ToString


                    '''' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    ''cfUFParameterClass = New UFParameterClass()
                    ''cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUMINCD
                    ''m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                    ''cfUFParameterClass = New UFParameterClass()
                    ''cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_RIREKINO
                    ''m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                    ''cfUFParameterClass = New UFParameterClass()
                    ''cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_KOSHINCOUNTER
                    ''m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)


                    '''' ˜_—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    ''cfUFParameterClass = New UFParameterClass()
                    ''cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_TANMATSUID
                    ''m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                    ''cfUFParameterClass = New UFParameterClass()
                    ''cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_SAKUJOFG
                    ''m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                    ''cfUFParameterClass = New UFParameterClass()
                    ''cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_KOSHINCOUNTER
                    ''m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                    ''cfUFParameterClass = New UFParameterClass()
                    ''cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_KOSHINNICHIJI
                    ''m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                    ''cfUFParameterClass = New UFParameterClass()
                    ''cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_KOSHINUSER
                    ''m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                    ''cfUFParameterClass = New UFParameterClass()
                    ''cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUMINCD
                    ''m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                    ''cfUFParameterClass = New UFParameterClass()
                    ''cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_RIREKINO
                    ''m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                    ''cfUFParameterClass = New UFParameterClass()
                    ''cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_KOSHINCOUNTER
                    ''m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)


                    '''' •¨—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    ''cfUFParameterClass = New UFParameterClass()
                    ''cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUMINCD
                    ''m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                    ''cfUFParameterClass = New UFParameterClass()
                    ''cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_RIREKINO
                    ''m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                    ''cfUFParameterClass = New UFParameterClass()
                    ''cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_KOSHINCOUNTER
                    ''m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                    '''' ƒfƒoƒbƒOƒƒOo—Í
                    ''m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                    ''    Catch objAppExp As UFAppException
                    ''        ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                    ''        m_cfLogClass.WarningWrite(m_cfControlData, _
                    ''                                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                    ''                                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                    ''                                    "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                    ''                                    "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                    ''        ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                    ''        Throw objAppExp

                    ''    Catch objExp As Exception
                    ''        ' ƒGƒ‰[ƒƒOo—Í
                    ''        m_cfLogClass.ErrorWrite(m_cfControlData, _
                    ''                                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                    ''                                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                    ''                                    "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                    ''        ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                    ''        Throw objExp
                    ''    End Try

                    ''End Sub
                    '* —š—ð”Ô† 000020 2005/06/15 íœI—¹
                    '* corresponds to VS2008 End 2010/04/16 000029


                    '* —š—ð”Ô† 000020 2005/06/15 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     Insert—pSQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateInsertSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\           INSERT—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateInsertSQL(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateInsertSQL"
                        Dim csDataColumn As DataColumn
                        Dim csInsertColumn As StringBuilder                 'INSERT—pƒJƒ‰ƒ€’è‹`
                        Dim csInsertParam As StringBuilder                  'INSERT—pƒpƒ‰ƒ[ƒ^’è‹`
                        Dim cfUFParameterClass As UFParameterClass


                        Try
                            ' ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SELECT SQL•¶‚Ìì¬
                            m_strInsertSQL = "INSERT INTO " + ABAtenaRirekiEntity.TABLE_NAME + " "
                            csInsertColumn = New StringBuilder
                            csInsertParam = New StringBuilder

                            ' INSERT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfInsertUFParameterCollectionClass = New UFParameterCollectionClass

                            ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                            For Each csDataColumn In csDataRow.Table.Columns
                                cfUFParameterClass = New UFParameterClass

                                ' INSERT SQL•¶‚Ìì¬
                                csInsertColumn.Append(csDataColumn.ColumnName)
                                csInsertColumn.Append(", ")

                                csInsertParam.Append(ABAtenaRirekiEntity.PARAM_PLACEHOLDER)
                                csInsertParam.Append(csDataColumn.ColumnName)
                                csInsertParam.Append(", ")

                                ' INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                                cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                                m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass)

                            Next csDataColumn

                            'ÅŒã‚ÌƒJƒ“ƒ}‚ðŽæ‚èœ‚¢‚ÄINSERT•¶‚ðì¬
                            m_strInsertSQL += "(" + csInsertColumn.ToString.TrimEnd(" ".ToCharArray()).TrimEnd(",".ToCharArray()) + ")" _
                                    + " VALUES (" + csInsertParam.ToString.TrimEnd(" ".ToCharArray()).TrimEnd(",".ToCharArray()) + ")"

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     Update—pSQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateUpdateSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\           UPDATE—p‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateUpdateSQL(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateUpdateSQL"
                        Dim csDataColumn As DataColumn
                        Dim cfUFParameterClass As UFParameterClass
                        Dim csWhere As StringBuilder                        'WHERE’è‹`
                        Dim csUpdateParam As StringBuilder                  'UPDATE—pSQL’è‹`


                        Try
                            ' ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' UPDATE SQL•¶‚Ìì¬
                            m_strUpdateSQL = "UPDATE " + ABAtenaRirekiEntity.TABLE_NAME + " SET "
                            csUpdateParam = New StringBuilder

                            ' WHERE•¶‚Ìì¬
                            csWhere = New StringBuilder
                            csWhere.Append(" WHERE ")
                            csWhere.Append(ABAtenaRirekiEntity.JUMINCD)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaRirekiEntity.KEY_JUMINCD)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaRirekiEntity.RIREKINO)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaRirekiEntity.KEY_RIREKINO)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaRirekiEntity.KOSHINCOUNTER)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaRirekiEntity.KEY_KOSHINCOUNTER)

                            ' UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfUpdateUFParameterCollectionClass = New UFParameterCollectionClass

                            ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                            For Each csDataColumn In csDataRow.Table.Columns
                                'Z–¯‚b‚cE—š—ð”Ô†Eì¬“úŽžEì¬ƒ†[ƒU‚ÍXV‚µ‚È‚¢
                                If Not (csDataColumn.ColumnName = ABAtenaRirekiEntity.JUMINCD) AndAlso _
                                    Not (csDataColumn.ColumnName = ABAtenaRirekiEntity.RIREKINO) AndAlso _
                                     Not (csDataColumn.ColumnName = ABAtenaRirekiEntity.SAKUSEIUSER) AndAlso _
                                      Not (csDataColumn.ColumnName = ABAtenaRirekiEntity.SAKUSEINICHIJI) Then

                                    cfUFParameterClass = New UFParameterClass

                                    ' UPDATE SQL•¶‚Ìì¬
                                    csUpdateParam.Append(csDataColumn.ColumnName)
                                    csUpdateParam.Append(" = ")
                                    csUpdateParam.Append(ABAtenaRirekiEntity.PARAM_PLACEHOLDER)
                                    csUpdateParam.Append(csDataColumn.ColumnName)
                                    csUpdateParam.Append(", ")

                                    ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                                    cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                                    m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                                End If

                            Next csDataColumn


                            ' UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                            m_strUpdateSQL += csUpdateParam.ToString.TrimEnd(" ".ToCharArray()).TrimEnd(",".ToCharArray())

                            ' UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                            m_strUpdateSQL += csWhere.ToString


                            ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUMINCD
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_RIREKINO
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_KOSHINCOUNTER
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˜_—íœ—pSQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateDeleteRonriSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\           ˜_—DELETE—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateDeleteRonriSQL(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateDeleteRonriSQL"
                        Dim cfUFParameterClass As UFParameterClass
                        Dim csWhere As StringBuilder                        'WHERE’è‹`
                        Dim csDelRonriParam As StringBuilder                '˜_—íœƒpƒ‰ƒ[ƒ^’è‹`

                        Try
                            ' ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' WHERE•¶‚Ìì¬
                            csWhere = New StringBuilder
                            csWhere.Append(" WHERE ")
                            csWhere.Append(ABAtenaRirekiEntity.JUMINCD)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaRirekiEntity.KEY_JUMINCD)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaRirekiEntity.RIREKINO)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaRirekiEntity.KEY_RIREKINO)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaRirekiEntity.KOSHINCOUNTER)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaRirekiEntity.KEY_KOSHINCOUNTER)

                            ' ˜_—DELETE SQL•¶‚Ìì¬
                            csDelRonriParam = New StringBuilder
                            csDelRonriParam.Append("UPDATE ")
                            csDelRonriParam.Append(ABAtenaRirekiEntity.TABLE_NAME)
                            csDelRonriParam.Append(" SET ")
                            csDelRonriParam.Append(ABAtenaRirekiEntity.TANMATSUID)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABAtenaRirekiEntity.PARAM_TANMATSUID)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABAtenaRirekiEntity.SAKUJOFG)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABAtenaRirekiEntity.PARAM_SAKUJOFG)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABAtenaRirekiEntity.KOSHINCOUNTER)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABAtenaRirekiEntity.PARAM_KOSHINCOUNTER)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABAtenaRirekiEntity.KOSHINNICHIJI)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABAtenaRirekiEntity.PARAM_KOSHINNICHIJI)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABAtenaRirekiEntity.KOSHINUSER)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABAtenaRirekiEntity.PARAM_KOSHINUSER)
                            csDelRonriParam.Append(csWhere)
                            ' Where•¶‚Ì’Ç‰Á
                            m_strDelRonriSQL = csDelRonriParam.ToString

                            ' ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDelRonriUFParameterCollectionClass = New UFParameterCollectionClass


                            ' ˜_—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_TANMATSUID
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_SAKUJOFG
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_KOSHINCOUNTER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_KOSHINNICHIJI
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_KOSHINUSER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUMINCD
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_RIREKINO
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_KOSHINCOUNTER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     •¨—íœ—pSQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateButsuriSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\           •¨—DELETE—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateDeleteButsuriSQL(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateButsuriSQL"
                        Dim cfUFParameterClass As UFParameterClass
                        Dim csWhere As StringBuilder                        'WHERE’è‹`

                        Try
                            ' ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' WHERE•¶‚Ìì¬
                            csWhere = New StringBuilder
                            csWhere.Append(" WHERE ")
                            csWhere.Append(ABAtenaRirekiEntity.JUMINCD)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaRirekiEntity.KEY_JUMINCD)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaRirekiEntity.RIREKINO)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaRirekiEntity.KEY_RIREKINO)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaRirekiEntity.KOSHINCOUNTER)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaRirekiEntity.KEY_KOSHINCOUNTER)

                            ' •¨—DELETE SQL•¶‚Ìì¬
                            m_strDelButuriSQL = "DELETE FROM " + ABAtenaRirekiEntity.TABLE_NAME + csWhere.ToString

                            ' •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDelButuriUFParameterCollectionClass = New UFParameterCollectionClass

                            ' •¨—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUMINCD
                            m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_RIREKINO
                            m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_KOSHINCOUNTER
                            m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                    End Sub
                    '* —š—ð”Ô† 000020 2005/06/15 ’Ç‰ÁI—¹

                    '* —š—ð”Ô† 000022 2005/11/18 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     •¨—íœ—p(‚PZ–¯‚b‚cŽw’è)SQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateDelFromJuminCDSQL()
                    '* 
                    '* ‹@”\           Z–¯‚b‚c‚ÅŠY“–‘S—š—ðƒf[ƒ^‚ð•¨—íœ‚·‚éSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           ‚È‚µ
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateDelFromJuminCDSQL()
                        Const THIS_METHOD_NAME As String = "CreateDelFromJuminCDSQL"
                        '* corresponds to VS2008 Start 2010/04/16 000029
                        'Dim cfUFParameterClass As UFParameterClass
                        '* corresponds to VS2008 End 2010/04/16 000029
                        Dim csWhere As StringBuilder                        'WHERE’è‹`

                        Try
                            ' ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' WHERE•¶‚Ìì¬
                            csWhere = New StringBuilder
                            csWhere.Append(" WHERE ")
                            csWhere.Append(ABAtenaRirekiEntity.JUMINCD)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaRirekiEntity.KEY_JUMINCD)

                            ' •¨—DELETE(‚PZ–¯‚b‚cŽw’è) SQL•¶‚Ìì¬
                            m_strDelFromJuminCDSQL = "DELETE FROM " + ABAtenaRirekiEntity.TABLE_NAME + csWhere.ToString

                            ' •¨—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            m_cfDelFromJuminCDPrmCollection = New UFParameterCollectionClass
                            m_cfDelFromJuminCDPrmCollection.Add(ABAtenaRirekiEntity.KEY_JUMINCD, DbType.String)

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                    End Sub
                    '* —š—ð”Ô† 000022 2005/11/18 ’Ç‰ÁI—¹

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                    '* 
                    '* \•¶           Private Sub CheckColumnValue(ByVal strColumnName As String, ByVal strValue as String)
                    '* 
                    '* ‹@”\           XVƒf[ƒ^‚Ì®‡«‚ðƒ`ƒFƒbƒN‚·‚éB
                    '* 
                    '* ˆø”           strColumnName As String : ˆ¶–¼—š—ðƒ}ƒXƒ^ƒf[ƒ^ƒZƒbƒg‚Ì€–Ú–¼
                    '*                strValue As String     : €–Ú‚É‘Î‰ž‚·‚é’l
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CheckColumnValue(ByVal strColumnName As String, ByVal strValue As String)

                        Const THIS_METHOD_NAME As String = "CheckColumnValue"
                        Const TABLENAME As String = "ˆ¶–¼—š—ðD"
                        Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            'm_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME, strColumnName + "'" + strValue + "'")

                            ' “ú•tƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            If (IsNothing(m_cfDateClass)) Then
                                m_cfDateClass = New UFDateClass(m_cfConfigDataClass)
                                ' “ú•tƒNƒ‰ƒX‚Ì•K—v‚ÈÝ’è‚ðs‚¤
                                m_cfDateClass.p_enDateSeparator = UFDateSeparator.None
                            End If

                            Select Case strColumnName.ToUpper()

                                Case ABAtenaRirekiEntity.JUMINCD            'Z–¯ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUMINCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.SHICHOSONCD        'Žs’¬‘ºƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SHICHOSONCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KYUSHICHOSONCD     '‹ŒŽs’¬‘ºƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KYUSHICHOSONCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.RIREKINO           '—š—ð”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_RIREKINO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.RRKST_YMD          '—š—ðŠJŽn”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_RRKST_YMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.RRKED_YMD          '—š—ðI—¹”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000" Or strValue = "99999999") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_RRKED_YMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.JUMINJUTOGAIKB     'Z–¯Z“oŠO‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUMINJUTOGAIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUMINYUSENIKB      'Z–¯—Dæ‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUMINYUSENIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUTOGAIYUSENKB     'Z“oŠO—Dæ‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUTOGAIYUSENKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.ATENADATAKB        'ˆ¶–¼ƒf[ƒ^‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_ATENADATAKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.STAICD             '¢‘ÑƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_STAICD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUMINHYOCD         'Z–¯•[ƒR[ƒh
                                    'ƒ`ƒFƒbƒN‚È‚µ

                                Case ABAtenaRirekiEntity.SEIRINO            '®—”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SEIRINO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.ATENADATASHU       'ˆ¶–¼ƒf[ƒ^Ží•Ê
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_ATENADATASHU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.HANYOKB1           '”Ä—p‹æ•ª1
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_HANYOKB1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KJNHJNKB           'ŒÂl–@l‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KJNHJNKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.HANYOKB2           '”Ä—p‹æ•ª2
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_HANYOKB2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KANNAIKANGAIKB     'ŠÇ“àŠÇŠO‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KANNAIKANGAIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KANAMEISHO1        'ƒJƒi–¼Ì1
                                    '*—š—ð”Ô† 000014 2003/10/30 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKataKana(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '*—š—ð”Ô† 000014 2003/10/30 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KANAMEISHO1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KANJIMEISHO1       'Š¿Žš–¼Ì1
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KANJIMEISHO1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KANAMEISHO2        'ƒJƒi–¼Ì2
                                    '*—š—ð”Ô† 000014 2003/10/30 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKataKana(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '*—š—ð”Ô† 000014 2003/10/30 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KANAMEISHO2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KANJIMEISHO2       'Š¿Žš–¼Ì2
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KANJIMEISHO2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KANJIHJNKEITAI     'Š¿Žš–@lŒ`‘Ô
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KANJIHJNKEITAI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KANJIHJNDAIHYOSHSHIMEI   'Š¿Žš–@l‘ã•\ŽÒŽ–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KANJIHJNDAIHYOSHSHIMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.SEARCHKANJIMEISHO  'ŒŸõ—pŠ¿Žš–¼Ì
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SEARCHKANJIMEISHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KYUSEI             '‹Œ©
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KYUSEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.SEARCHKANASEIMEI   'ŒŸõ—pƒJƒi©–¼
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾(‰p”ŽšE”¼ŠpƒJƒi€–Ú“ü—Í‚ÌŒë‚è‚Å‚·BF)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002017)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "ŒŸõ—pƒJƒi©–¼", objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.SEARCHKANASEI      'ŒŸõ—pƒJƒi©
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾(‰p”ŽšE”¼ŠpƒJƒi€–Ú“ü—Í‚ÌŒë‚è‚Å‚·BF)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002017)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "ŒŸõ—pƒJƒi©", objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.SEARCHKANAMEI      'ŒŸõ—pƒJƒi–¼
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾(‰p”ŽšE”¼ŠpƒJƒi€–Ú“ü—Í‚ÌŒë‚è‚Å‚·BF)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002017)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "ŒŸõ—pƒJƒi–¼", objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKIRRKNO          'ZŠî—š—ð”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKIRRKNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                    'Case ABAtenaRirekiEntity.UMAREYMD           '¶”NŒŽ“ú
                                    '    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                    '        m_cfDateClass.p_strDateValue = strValue
                                    '        If (Not m_cfDateClass.CheckDate()) Then
                                    '            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                    '            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    '            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_UMAREYMD)
                                    '            '—áŠO‚ð¶¬
                                    '            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    '        End If
                                    '    End If

                                    'Case ABAtenaRirekiEntity.UMAREWMD           '¶˜a—ï”NŒŽ“ú
                                    '    If (Not UFStringClass.CheckNumber(strValue)) Then
                                    '        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                    '        'ƒGƒ‰[’è‹`‚ðŽæ“¾(”Žš€–Ú“ü—Í‚ÌŒë‚è‚Å‚·BF)
                                    '        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002013)
                                    '        '—áŠO‚ð¶¬
                                    '        Throw New UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "¶˜a—ï”NŒŽ“ú", objErrorStruct.m_strErrorCode)
                                    '    End If

                                Case ABAtenaRirekiEntity.SEIBETSUCD         '«•ÊƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SEIBETSUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.SEIBETSU           '«•Ê
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SEIBETSU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.SEKINO             'Ð”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SEKINO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUMINHYOHYOJIJUN   'Z–¯•[•\Ž¦‡
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUMINHYOHYOJIJUN)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.ZOKUGARACD         '‘±•¿ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue.TrimEnd)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_ZOKUGARACD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.ZOKUGARA           '‘±•¿
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_ZOKUGARA)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.DAI2JUMINHYOHYOJIJUN     '‘æ‚QZ–¯•[•\Ž¦‡
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_DAI2JUMINHYOHYOJIJUN)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.DAI2ZOKUGARACD           '‘æ‚Q‘±•¿ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue.TrimEnd)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_DAI2ZOKUGARACD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.DAI2ZOKUGARA             '‘æ‚Q‘±•¿
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_DAI2ZOKUGARA)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.STAINUSJUMINCD     '¢‘ÑŽåZ–¯ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_STAINUSJUMINCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.STAINUSMEI         '¢‘ÑŽå–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_STAINUSMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KANASTAINUSMEI     'ƒJƒi¢‘ÑŽå–¼
                                    '*—š—ð”Ô† 000014 2003/10/30 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKataKana(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '*—š—ð”Ô† 000014 2003/10/30 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KANASTAINUSMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.DAI2STAINUSJUMINCD       '‘æ‚Q¢‘ÑŽåZ–¯ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_DAI2STAINUSJUMINCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.DAI2STAINUSMEI           '‘æ‚Q¢‘ÑŽå–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_DAI2STAINUSMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KANADAI2STAINUSMEI       '‘æ‚QƒJƒi¢‘ÑŽå–¼
                                    '*—š—ð”Ô† 000014 2003/10/30 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKataKana(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '*—š—ð”Ô† 000014 2003/10/30 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KANADAI2STAINUSMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.YUBINNO            '—X•Ö”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_YUBINNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUSHOCD            'ZŠƒR[ƒh
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUSHOCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUSHO              'ZŠ
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUSHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.BANCHICD1          '”Ô’nƒR[ƒh1
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_BANCHICD1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.BANCHICD2          '”Ô’nƒR[ƒh2
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_BANCHICD2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.BANCHICD3          '”Ô’nƒR[ƒh3
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_BANCHICD3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.BANCHI             '”Ô’n
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_BANCHI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KATAGAKIFG         '•û‘ƒtƒ‰ƒO
                                    If (Not strValue.Trim = String.Empty) Then
                                        If (Not UFStringClass.CheckNumber(strValue)) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KATAGAKIFG)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.KATAGAKICD         '•û‘ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KATAGAKICD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KATAGAKI           '•û‘
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KATAGAKI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.RENRAKUSAKI1       '˜A—æ1
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_RENRAKUSAKI1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.RENRAKUSAKI2       '˜A—æ2
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_RENRAKUSAKI2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.HON_ZJUSHOCD       '–{Ð‘S‘ZŠƒR[ƒh
                                    '* —š—ð”Ô† 000017 2004/10/19 C³ŠJŽniƒ}ƒ‹ƒS‘ºŽRj
                                    'If (Not UFStringClass.CheckNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000017 2004/10/19 C³I—¹iƒ}ƒ‹ƒS‘ºŽRj
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_HON_ZJUSHOCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.HON_JUSHO          '–{ÐZŠ
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_HON_JUSHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.HONSEKIBANCHI      '–{Ð”Ô’n
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_HONSEKIBANCHI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.HITTOSH            '•M“ªŽÒ
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_HITTOSH)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.CKINIDOYMD         '’¼‹ßˆÙ“®”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_CKINIDOYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.CKINJIYUCD         '’¼‹ßŽ–—RƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_CKINJIYUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                    'Case ABAtenaRirekiEntity.CKINJIYU           '’¼‹ßŽ–—R
                                    '    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                    '        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                    '        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    '        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_CKINJIYU)
                                    '        '—áŠO‚ð¶¬
                                    '        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    '    End If

                                Case ABAtenaRirekiEntity.CKINTDKDYMD        '’¼‹ß“Ío”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_CKINTDKDYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.CKINTDKDTUCIKB     '’¼‹ß“Ío’Ê’m‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_CKINTDKDTUCIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TOROKUIDOYMD       '“o˜^ˆÙ“®”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TOROKUIDOYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.TOROKUIDOWMD       '“o˜^ˆÙ“®˜a—ï”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "0000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TOROKUIDOWMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.TOROKUJIYUCD       '“o˜^Ž–—RƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TOROKUJIYUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TOROKUJIYU         '“o˜^Ž–—R
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TOROKUJIYU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TOROKUTDKDYMD      '“o˜^“Ío”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TOROKUTDKDYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.TOROKUTDKDWMD      '“o˜^“Ío˜a—ï”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "0000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TOROKUTDKDWMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.TOROKUTDKDTUCIKB   '“o˜^“Ío’Ê’m‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TOROKUTDKDTUCIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUTEIIDOYMD        'Z’èˆÙ“®”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUTEIIDOYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.JUTEIIDOWMD        'Z’èˆÙ“®˜a—ï”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "0000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUTEIIDOWMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.JUTEIJIYUCD        'Z’èŽ–—RƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUTEIJIYUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUTEIJIYU          'Z’èŽ–—R
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUTEIJIYU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUTEITDKDYMD       'Z’è“Ío”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUTEITDKDYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.JUTEITDKDWMD       'Z’è“Ío˜a—ï”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "0000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUTEITDKDWMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.JUTEITDKDTUCIKB    'Z’è“Ío’Ê’m‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUTEITDKDTUCIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.SHOJOIDOYMD        'ÁœˆÙ“®”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SHOJOIDOYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.SHOJOJIYUCD        'ÁœŽ–—RƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SHOJOJIYUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.SHOJOJIYU          'ÁœŽ–—R
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SHOJOJIYU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.SHOJOTDKDYMD       'Áœ“Ío”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SHOJOTDKDYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.SHOJOTDKDTUCIKB    'Áœ“Ío’Ê’m‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SHOJOTDKDTUCIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUYOTEIIDOYMD     '“]o—\’è“Ío”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUYOTEIIDOYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUKKTIIDOYMD      '“]oŠm’è“Ío”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUKKTIIDOYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUKKTITSUCHIYMD   '“]oŠm’è’Ê’m”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUKKTITSUCHIYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUNYURIYUCD       '“]o“ü——RƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUNYURIYUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUNYURIYU         '“]o“ü——R
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUNYURIYU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENUMAEJ_YUBINNO         '“]“ü‘OZŠ—X•Ö”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENUMAEJ_YUBINNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENUMAEJ_ZJUSHOCD        '“]“ü‘OZŠ‘S‘ZŠƒR[ƒh
                                    '* —š—ð”Ô† 000017 2004/10/19 C³ŠJŽniƒ}ƒ‹ƒS‘ºŽRj
                                    'If (Not UFStringClass.CheckNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000017 2004/10/19 C³I—¹iƒ}ƒ‹ƒS‘ºŽRj
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENUMAEJ_ZJUSHOCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENUMAEJ_JUSHO           '“]“ü‘OZŠZŠ
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENUMAEJ_JUSHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENUMAEJ_BANCHI          '“]“ü‘OZŠ”Ô’n
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENUMAEJ_BANCHI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENUMAEJ_KATAGAKI        '“]“ü‘OZŠ•û‘
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENUMAEJ_KATAGAKI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENUMAEJ_STAINUSMEI      '“]“ü‘OZŠ¢‘ÑŽå–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENUMAEJ_STAINUSMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUYOTEIYUBINNO    '“]o—\’è—X•Ö”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUYOTEIYUBINNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUYOTEIZJUSHOCD   '“]o—\’è‘S‘ZŠƒR[ƒh
                                    '* —š—ð”Ô† 000017 2004/10/19 C³ŠJŽniƒ}ƒ‹ƒS‘ºŽRj
                                    'If (Not UFStringClass.CheckNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000017 2004/10/19 C³I—¹iƒ}ƒ‹ƒS‘ºŽRj
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUYOTEIZJUSHOCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUYOTEIJUSHO      '“]o—\’èZŠ
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUYOTEIJUSHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUYOTEIBANCHI     '“]o—\’è”Ô’n
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUYOTEIBANCHI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUYOTEIKATAGAKI   '“]o—\’è•û‘
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUYOTEIKATAGAKI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUYOTEISTAINUSMEI '“]o—\’è¢‘ÑŽå–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUYOTEISTAINUSMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUKKTIYUBINNO     '“]oŠm’è—X•Ö”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUKKTIYUBINNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUKKTIZJUSHOCD    '“]oŠm’è‘S‘ZŠƒR[ƒh
                                    '* —š—ð”Ô† 000017 2004/10/19 C³ŠJŽniƒ}ƒ‹ƒS‘ºŽRj
                                    'If (Not UFStringClass.CheckNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000017 2004/10/19 C³I—¹iƒ}ƒ‹ƒS‘ºŽRj
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUKKTIZJUSHOCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUKKTIJUSHO     '“]oŠm’èZŠ
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUKKTIJUSHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUKKTIBANCHI      '“]oŠm’è”Ô’n
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUKKTIBANCHI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUKKTIKATAGAKI    '“]oŠm’è•û‘
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUKKTIKATAGAKI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUKKTISTAINUSMEI  '“]oŠm’è¢‘ÑŽå–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUKKTISTAINUSMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TENSHUTSUKKTIMITDKFG     '“]oŠm’è–¢“Íƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TENSHUTSUKKTIMITDKFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.BIKOYMD                  '”õl”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_BIKOYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.BIKO                     '”õl
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_BIKO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.BIKOTENSHUTSUKKTIJUSHOFG '”õl“]oŠm’èZŠƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_BIKOTENSHUTSUKKTIJUSHOFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.HANNO                    '”Å”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_HANNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KAISEIATOFG              '‰ü»Œãƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KAISEIATOFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KAISEIMAEFG             '‰ü»‘Oƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KAISEIMAEFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KAISEIYMD                '‰ü»”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KAISEIYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.GYOSEIKUCD               's­‹æƒR[ƒh
                                    '* —š—ð”Ô† 000023 2005/12/26 C³ŠJŽn
                                    ''If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        '* —š—ð”Ô† 000023 2005/12/26 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_GYOSEIKUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.GYOSEIKUMEI              's­‹æ–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_GYOSEIKUMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.CHIKUCD1                 '’n‹æƒR[ƒh1
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_CHIKUCD1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.CHIKUMEI1                '’n‹æ–¼1
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_CHIKUMEI1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.CHIKUCD2                 '’n‹æƒR[ƒh2
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_CHIKUCD2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.CHIKUMEI2                '’n‹æ–¼2
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_CHIKUMEI2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.CHIKUCD3                 '’n‹æƒR[ƒh3
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_CHIKUCD3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.CHIKUMEI3                '’n‹æ–¼3
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_CHIKUMEI3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.TOHYOKUCD                '“Š•[‹æƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TOHYOKUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.SHOGAKKOKUCD             '¬ŠwZ‹æƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SHOGAKKOKUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.CHUGAKKOKUCD             '’†ŠwZ‹æƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_CHUGAKKOKUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.HOGOSHAJUMINCD           '•ÛŒìŽÒZ–¯ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_HOGOSHAJUMINCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KANJIHOGOSHAMEI          'Š¿Žš•ÛŒìŽÒ–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KANJIHOGOSHAMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KANAHOGOSHAMEI           'ƒJƒi•ÛŒìŽÒ–¼
                                    '*—š—ð”Ô† 000014 2003/10/30 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKataKana(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '*—š—ð”Ô† 000014 2003/10/30 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KANAHOGOSHAMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KIKAYMD                  '‹A‰»”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KIKAYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.KARIIDOKB                '‰¼ˆÙ“®‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KARIIDOKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.SHORITEISHIKB            'ˆ—’âŽ~‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SHORITEISHIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKIYUBINNO              'ZŠî—X•Ö”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKIYUBINNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.SHORIYOKUSHIKB           'ˆ——}Ž~‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SHORIYOKUSHIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKIJUSHOCD              'ZŠîZŠƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKIJUSHOCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKIJUSHO                'ZŠîZŠ
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKIJUSHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKIBANCHICD1            'ZŠî”Ô’nƒR[ƒh1
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKIBANCHICD1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKIBANCHICD2            'ZŠî”Ô’nƒR[ƒh2
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKIBANCHICD2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKIBANCHICD3            'ZŠî”Ô’nƒR[ƒh3
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKIBANCHICD3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKIBANCHI               'ZŠî”Ô’n
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKIBANCHI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKIKATAGAKIFG           'ZŠî•û‘ƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKIKATAGAKIFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKIKATAGAKICD           'ZŠî•û‘ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKIKATAGAKICD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKIKATAGAKI             'ZŠî•û‘
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKIKATAGAKI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKIGYOSEIKUCD           'ZŠîs­‹æƒR[ƒh
                                    '* —š—ð”Ô† 000023 2005/12/26 C³ŠJŽn
                                    ''If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        '* —š—ð”Ô† 000023 2005/12/26 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKIGYOSEIKUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKIGYOSEIKUMEI          'ZŠîs­‹æ–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKIGYOSEIKUMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKICHIKUCD1             'ZŠî’n‹æƒR[ƒh1
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKICHIKUCD1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKICHIKUMEI1            'ZŠî’n‹æ–¼1
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKICHIKUMEI1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKICHIKUCD2             'ZŠî’n‹æƒR[ƒh2
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKICHIKUCD2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKICHIKUMEI2            'ZŠî’n‹æ–¼2
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKICHIKUMEI2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKICHIKUCD3             'ZŠî’n‹æƒR[ƒh3
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKICHIKUCD3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.JUKICHIKUMEI3            'ZŠî’n‹æ–¼3
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_JUKICHIKUMEI3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KAOKUSHIKIKB             '‰Æ‰®•~‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KAOKUSHIKIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.BIKOZEIMOKU              '”õlÅ–Ú
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_BIKOZEIMOKU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KOKUSEKICD               '‘ÐƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KOKUSEKICD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KOKUSEKI                 '‘Ð
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KOKUSEKI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.ZAIRYUSKAKCD             'Ý—¯Ž‘ŠiƒR[ƒh
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_ZAIRYUSKAKCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.ZAIRYUSKAK               'Ý—¯Ž‘Ši
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_ZAIRYUSKAK)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.ZAIRYUKIKAN              'Ý—¯ŠúŠÔ
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_ZAIRYUKIKAN)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.ZAIRYU_ST_YMD            'Ý—¯ŠJŽn”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_ZAIRYU_ST_YMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.ZAIRYU_ED_YMD            'Ý—¯I—¹”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_ZAIRYU_ED_YMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaRirekiEntity.RESERCE                  'ƒŠƒU[ƒu
                                    'ƒ`ƒFƒbƒN‚È‚µ

                                Case ABAtenaRirekiEntity.TANMATSUID               '’[––‚h‚c
                                    '* —š—ð”Ô† 000012 2003/09/11 C³ŠJŽn
                                    'If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000012 2003/09/11 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_TANMATSUID)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.SAKUJOFG                 'íœƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SAKUJOFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KOSHINCOUNTER            'XVƒJƒEƒ“ƒ^
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KOSHINCOUNTER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.SAKUSEINICHIJI           'ì¬“úŽž
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SAKUSEINICHIJI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.SAKUSEIUSER              'ì¬ƒ†[ƒU
                                    '* —š—ð”Ô† 000013 2003/10/09 C³ŠJŽn
                                    'If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000013 2003/10/09 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_SAKUSEIUSER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KOSHINNICHIJI            'XV“úŽž
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KOSHINNICHIJI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaRirekiEntity.KOSHINUSER               'XVƒ†[ƒU
                                    '* —š—ð”Ô† 000013 2003/10/09 C³ŠJŽn
                                    'If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000013 2003/10/09 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_RDBDATATYPE_KOSHINUSER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                            End Select

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            'm_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                    End Sub
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼Get—p‚Ì€–Ú‚ð•ÒW
                    '* 
                    '* \•¶           Private SetAtenaEntity(ByRef strSql As StringBuilder)
                    '* 
                    '* ‹@”\           ˆ¶–¼Get—p‚Ì€–Ú‚ð•ÒW‚·‚éB
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetAtenaEntity(ByRef strAtenaSQLsb As StringBuilder)
                        If (Me.m_blnSelectAll <> ABEnumDefine.AtenaGetKB.KaniOnly) Then
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KYUSHICHOSONCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ATENADATAKB).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.STAICD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ATENADATASHU).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.HANYOKB1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KJNHJNKB).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.HANYOKB2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANNAIKANGAIKB).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANAMEISHO1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANJIMEISHO1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANAMEISHO2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANJIMEISHO2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANJIHJNKEITAI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANJIHJNDAIHYOSHSHIMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEARCHKANJIMEISHO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEARCHKANASEIMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEARCHKANASEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEARCHKANAMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.UMAREYMD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.UMAREWMD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEIBETSUCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEIBETSU).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SEKINO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINHYOHYOJIJUN).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ZOKUGARACD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ZOKUGARA).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.DAI2JUMINHYOHYOJIJUN).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.DAI2ZOKUGARACD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.DAI2ZOKUGARA).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.STAINUSJUMINCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.STAINUSMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANASTAINUSMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.DAI2STAINUSJUMINCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.DAI2STAINUSMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANADAI2STAINUSMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.YUBINNO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUSHOCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUSHO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.BANCHICD1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.BANCHICD2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.BANCHICD3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.BANCHI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KATAGAKIFG).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KATAGAKICD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KATAGAKI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.RENRAKUSAKI1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.RENRAKUSAKI2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TOROKUIDOYMD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TOROKUJIYUCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TOROKUJIYU).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SHOJOIDOYMD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SHOJOJIYUCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SHOJOJIYU).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.GYOSEIKUCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.GYOSEIKUMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CHIKUCD1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CHIKUMEI1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CHIKUCD2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CHIKUMEI2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CHIKUCD3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CHIKUMEI3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIYUBINNO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIJUSHOCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIJUSHO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIBANCHICD1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIBANCHICD2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIBANCHICD3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIBANCHI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIKATAGAKIFG).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIKATAGAKICD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIKATAGAKI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIGYOSEIKUCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKICHIKUCD1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKICHIKUMEI1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKICHIKUCD2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKICHIKUMEI2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKICHIKUCD3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKICHIKUMEI3)

                            '*—š—ð”Ô† 000030 2010/05/14 ’Ç‰ÁŠJŽn
                            ' –{Ð•M“ªŽÒî•ñ’Šo”»’è
                            If (m_strHonsekiHittoshKB = "1" AndAlso m_strHonsekiHittoshKB_Param = "1") Then
                                ' –{ÐZŠA–{Ð”Ô’nA•M“ªŽÒ‚ð’Šo€–Ú‚ÉƒZƒbƒg‚·‚é
                                strAtenaSQLsb.Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.HON_JUSHO).Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.HONSEKIBANCHI).Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.HITTOSH)
                            Else
                            End If

                            ' ˆ—’âŽ~‹æ•ª’Šo”»’è
                            If (m_strShoriteishiKB = "1" AndAlso m_strShoriTeishiKB_Param = "1") Then
                                ' ˆ—’âŽ~‹æ•ª‚ð’Šo€–Ú‚ÉƒZƒbƒg‚·‚é
                                strAtenaSQLsb.Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SHORITEISHIKB)
                            Else
                            End If
                            '*—š—ð”Ô† 000030 2010/05/14 ’Ç‰ÁI—¹

                            '*—š—ð”Ô† 000031 2011/05/18 ’Ç‰ÁŠJŽn
                            If (m_strFrnZairyuJohoKB_Param = "1") Then
                                ' ŠO‘lÝ—¯î•ñ(‘ÐAÝ—¯Ž‘ŠiƒR[ƒhAÝ—¯Ž‘ŠiAÝ—¯ŠúŠÔAÝ—¯ŠJŽn”NŒŽ“úAÝ—¯I—¹”NŒŽ“ú)‚ð’Šo€–Ú‚ÉƒZƒbƒg‚·‚é
                                strAtenaSQLsb.Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KOKUSEKI).Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ZAIRYUSKAKCD).Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ZAIRYUSKAK).Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ZAIRYUKIKAN).Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ZAIRYU_ST_YMD).Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ZAIRYU_ED_YMD)
                            Else
                            End If
                            '*—š—ð”Ô† 000031 2011/05/18 ’Ç‰ÁI—¹
                        Else
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KYUSHICHOSONCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ATENADATAKB).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.STAICD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ATENADATASHU).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.HANYOKB1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KJNHJNKB).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.HANYOKB2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANNAIKANGAIKB).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANAMEISHO1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANJIMEISHO1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANAMEISHO2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANJIMEISHO2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANJIHJNKEITAI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.UMAREYMD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.UMAREWMD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANASTAINUSMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANADAI2STAINUSMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.YUBINNO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUSHOCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUSHO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.BANCHICD1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.BANCHICD2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.BANCHICD3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.BANCHI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KATAGAKIFG).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KATAGAKICD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KATAGAKI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.RENRAKUSAKI1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.RENRAKUSAKI2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.GYOSEIKUCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.GYOSEIKUMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CHIKUCD1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CHIKUMEI1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CHIKUCD2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CHIKUMEI2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CHIKUCD3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CHIKUMEI3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIYUBINNO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIJUSHOCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIJUSHO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIBANCHICD1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIBANCHICD2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIBANCHICD3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIBANCHI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIKATAGAKIFG).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIKATAGAKICD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIKATAGAKI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIGYOSEIKUCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKICHIKUCD1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKICHIKUMEI1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKICHIKUCD2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKICHIKUMEI2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKICHIKUCD3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUKICHIKUMEI3)

                            '*—š—ð”Ô† 000030 2010/05/14 ’Ç‰ÁŠJŽn
                            ' –{Ð•M“ªŽÒî•ñ’Šo”»’è
                            If (m_strHonsekiHittoshKB = "1" AndAlso m_strHonsekiHittoshKB_Param = "1") Then
                                ' –{ÐZŠA–{Ð”Ô’nA•M“ªŽÒ‚ð’Šo€–Ú‚ÉƒZƒbƒg‚·‚é
                                strAtenaSQLsb.Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.HON_JUSHO).Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.HONSEKIBANCHI).Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.HITTOSH)
                            Else
                            End If

                            ' ˆ—’âŽ~‹æ•ª’Šo”»’è
                            If (m_strShoriteishiKB = "1" AndAlso m_strShoriTeishiKB_Param = "1") Then
                                ' ˆ—’âŽ~‹æ•ª‚ð’Šo€–Ú‚ÉƒZƒbƒg‚·‚é
                                strAtenaSQLsb.Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SHORITEISHIKB)
                            Else
                            End If
                            '*—š—ð”Ô† 000030 2010/05/14 ’Ç‰ÁI—¹

                            '*—š—ð”Ô† 000031 2011/05/18 ’Ç‰ÁŠJŽn
                            If (m_strFrnZairyuJohoKB_Param = "1") Then
                                ' ŠO‘lÝ—¯î•ñ(‘ÐAÝ—¯Ž‘ŠiƒR[ƒhAÝ—¯Ž‘ŠiAÝ—¯ŠúŠÔAÝ—¯ŠJŽn”NŒŽ“úAÝ—¯I—¹”NŒŽ“ú)‚ð’Šo€–Ú‚ÉƒZƒbƒg‚·‚é
                                strAtenaSQLsb.Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KOKUSEKI).Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ZAIRYUSKAKCD).Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ZAIRYUSKAK).Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ZAIRYUKIKAN).Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ZAIRYU_ST_YMD).Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.ZAIRYU_ED_YMD)
                            Else
                            End If
                            '*—š—ð”Ô† 000031 2011/05/18 ’Ç‰ÁI—¹

                        End If
                        If (Me.m_blnSelectAll = ABEnumDefine.AtenaGetKB.NenkinAll) Then
                            strAtenaSQLsb.Append(",")
                            ' ‹Œ©
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KYUSEI).Append(",")
                            ' Z’èˆÙ“®”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUTEIIDOYMD).Append(",")
                            ' Z’èŽ–—R
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUTEIJIYU).Append(",")
                            ' “]“ü‘OZŠ—X•Ö”Ô†
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENUMAEJ_YUBINNO).Append(",")
                            ' “]“ü‘OZŠ‘S‘ZŠƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENUMAEJ_ZJUSHOCD).Append(",")
                            ' “]“ü‘OZŠZŠ
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENUMAEJ_JUSHO).Append(",")
                            ' “]“ü‘OZŠ”Ô’n
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENUMAEJ_BANCHI).Append(",")
                            ' “]“ü‘OZŠ•û‘
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENUMAEJ_KATAGAKI).Append(",")
                            ' “]o—\’è—X•Ö”Ô†
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUYOTEIYUBINNO).Append(",")
                            ' “]o—\’è‘S‘ZŠƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUYOTEIZJUSHOCD).Append(",")
                            ' “]o—\’èˆÙ“®”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUYOTEIIDOYMD).Append(",")
                            ' “]o—\’èZŠ
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUYOTEIJUSHO).Append(",")
                            ' “]o—\’è”Ô’n
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUYOTEIBANCHI).Append(",")
                            ' “]o—\’è•û‘
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUYOTEIKATAGAKI).Append(",")
                            ' “]oŠm’è—X•Ö”Ô†
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUKKTIYUBINNO).Append(",")
                            ' “]oŠm’è‘S‘ZŠƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUKKTIZJUSHOCD).Append(",")
                            ' “]oŠm’èˆÙ“®”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUKKTIIDOYMD).Append(",")
                            ' “]oŠm’è’Ê’m”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUKKTITSUCHIYMD).Append(",")
                            ' “]oŠm’èZŠ
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUKKTIJUSHO).Append(",")
                            ' “]oŠm’è”Ô’n
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUKKTIBANCHI).Append(",")
                            ' “]oŠm’è•û‘
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUKKTIKATAGAKI).Append(",")

                            ' Áœ“Ío”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SHOJOTDKDYMD).Append(",")
                            ' ’¼‹ßŽ–—RƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CKINJIYUCD).Append(",")

                            ' –{Ð‘S‘ZŠƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.HON_ZJUSHOCD).Append(",")
                            ' “]o—\’è¢‘ÑŽå–¼
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUYOTEISTAINUSMEI).Append(",")
                            ' “]oŠm’è¢‘ÑŽå–¼
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUKKTISTAINUSMEI).Append(",")
                            '*—š—ð”Ô† 000024 2006/07/31 ’Ç‰ÁŠJŽn
                            ' ‘ÐƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KOKUSEKICD).Append(",")
                            ' “]“ü‘OZŠ¢‘ÑŽå–¼
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENUMAEJ_STAINUSMEI)
                            'strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KOKUSEKICD)
                            '*—š—ð”Ô† 000024 2006/07/31 ’Ç‰ÁI—¹

                        End If

                        '*—š—ð”Ô† 000025 2007/04/28 ’Ç‰ÁŠJŽn
                        If m_blnMethodKB = ABEnumDefine.MethodKB.KB_Kaigo Then
                            strAtenaSQLsb.Append(",")
                            ' ‹Œ©
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KYUSEI).Append(",")
                            ' Z’èˆÙ“®”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUTEIIDOYMD).Append(",")
                            ' Z’èŽ–—R
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUTEIJIYU).Append(",")
                            ' “]“ü‘OZŠ—X•Ö”Ô†
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENUMAEJ_YUBINNO).Append(",")
                            ' “]“ü‘OZŠ‘S‘ZŠƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENUMAEJ_ZJUSHOCD).Append(",")
                            ' “]“ü‘OZŠZŠ
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENUMAEJ_JUSHO).Append(",")
                            ' “]“ü‘OZŠ”Ô’n
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENUMAEJ_BANCHI).Append(",")
                            ' “]“ü‘OZŠ•û‘
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENUMAEJ_KATAGAKI).Append(",")
                            ' “]o—\’è—X•Ö”Ô†
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUYOTEIYUBINNO).Append(",")
                            ' “]o—\’è‘S‘ZŠƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUYOTEIZJUSHOCD).Append(",")
                            ' “]o—\’èˆÙ“®”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUYOTEIIDOYMD).Append(",")
                            ' “]o—\’èZŠ
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUYOTEIJUSHO).Append(",")
                            ' “]o—\’è”Ô’n
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUYOTEIBANCHI).Append(",")
                            ' “]o—\’è•û‘
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUYOTEIKATAGAKI).Append(",")
                            ' “]oŠm’è—X•Ö”Ô†
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUKKTIYUBINNO).Append(",")
                            ' “]oŠm’è‘S‘ZŠƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUKKTIZJUSHOCD).Append(",")
                            ' “]oŠm’èˆÙ“®”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUKKTIIDOYMD).Append(",")
                            ' “]oŠm’è’Ê’m”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUKKTITSUCHIYMD).Append(",")
                            ' “]oŠm’èZŠ
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUKKTIJUSHO).Append(",")
                            ' “]oŠm’è”Ô’n
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUKKTIBANCHI).Append(",")
                            ' “]oŠm’è•û‘
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUKKTIKATAGAKI).Append(",")
                            ' Áœ“Ío”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SHOJOTDKDYMD).Append(",")
                            ' ’¼‹ßŽ–—RƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CKINJIYUCD).Append(",")
                            ' –{Ð‘S‘ZŠƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.HON_ZJUSHOCD).Append(",")
                            ' “]o—\’è¢‘ÑŽå–¼
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUYOTEISTAINUSMEI).Append(",")
                            ' “]oŠm’è¢‘ÑŽå–¼
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUKKTISTAINUSMEI).Append(",")
                            ' ‘ÐƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KOKUSEKICD).Append(",")
                            ' “o˜^“Ío”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TOROKUTDKDYMD).Append(",")
                            ' Z’è“Ío”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUTEITDKDYMD).Append(",")
                            ' “]o“ü——R
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.TENSHUTSUNYURIYU).Append(",")
                            ' Žs’¬‘ºƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SHICHOSONCD).Append(",")
                            ' ’¼‹ßˆÙ“®”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CKINIDOYMD).Append(",")
                            ' XV“úŽž
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KOSHINNICHIJI)
                        End If
                        '*—š—ð”Ô† 000025 2007/04/28 ’Ç‰ÁI—¹
                        If (m_intHyojunKB = ABEnumDefine.HyojunKB.KB_Hyojun) Then
                            strAtenaSQLsb.Append(",")
                            ' ’¼‹ß“Ío’Ê’m‹æ•ª
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.CKINTDKDTUCIKB).Append(",")
                            ' ”Å”Ô†
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.HANNO).Append(",")
                            ' ‰ü»”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KAISEIYMD)
                            If (m_blnMethodKB <> ABEnumDefine.MethodKB.KB_Kaigo) AndAlso
                               (m_blnSelectAll <> ABEnumDefine.AtenaGetKB.NenkinAll) Then
                                ' ‘ÐƒR[ƒh
                                strAtenaSQLsb.Append(",")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KOKUSEKICD)
                            End If
                        End If
                    End Sub
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼Get—p‚ÌŒÂ•ÊŽ–€€–Ú‚ð•ÒW
                    '* 
                    '* \•¶           Private SetKobetsuaEntity(ByRef strSql As StringBuilder)
                    '* 
                    '* ‹@”\           ˆ¶–¼Get—p‚Ì€–Ú‚ð•ÒW‚·‚éB
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetKobetsuEntity(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.KSNENKNNO)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KSNENKNNO)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.SKAKSHUTKYMD)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.NENKNSKAKSHUTKYMD)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.SKAKSHUTKSHU)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.NENKNSKAKSHUTKSHU)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.SKAKSHUTKRIYUCD)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.NENKNSKAKSHUTKRIYUCD)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.SKAKSSHTSYMD)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.NENKNSKAKSSHTSYMD)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.SKAKSSHTSRIYUCD)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.NENKNSKAKSSHTSRIYUCD)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKIGO1)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKIGO1)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNNO1)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNNO1)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNSHU1)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNSHU1)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNEDABAN1)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNEDABAN1)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKB1)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKB1)

                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKIGO2)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKIGO2)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNNO2)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNNO2)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNSHU2)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNSHU2)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNEDABAN2)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNEDABAN2)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKB2)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKB2)

                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKIGO3)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKIGO3)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNNO3)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNNO3)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNSHU3)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNSHU3)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNEDABAN3)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNEDABAN3)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JKYNENKNKB3)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JKYNENKNKB3)
                        If (m_intHyojunKB = ABEnumDefine.HyojunKB.KB_Hyojun) Then
                            strAtenaSQLsb.Append(", ")
                            strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.HIHOKENSHAGAITOKB)
                            strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuHyojunEntity.NENKINHIHOKENSHAGAITOKB)
                            strAtenaSQLsb.Append(", ")
                            strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.SHUBETSUHENKOYMD)
                            strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuHyojunEntity.NENKINSHUBETSUHENKOYMD)
                        End If

                        ' ‘•Û
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHONO)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHONO)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOSHIKAKUKB)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKB)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOSHIKAKUKBMEISHO)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKBMEISHO)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOSHIKAKUKBRYAKUSHO)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKBRYAKUSHO)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOGAKUENKB)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOGAKUENKB)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOGAKUENKBMEISHO)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOGAKUENKBMEISHO)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOGAKUENKBRYAKUSHO)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOGAKUENKBRYAKUSHO)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOSHUTOKUYMD)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOSHUTOKUYMD)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOSOSHITSUYMD)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOSOSHITSUYMD)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKKB)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKKB)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKKBMEISHO)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKKBMEISHO)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKKBRYAKUSHO)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKKBRYAKUSHO)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKB)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKB)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKBMEISHO)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKBMEISHO)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKBRYAKUSHO)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKBRYAKUSHO)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKGAITOYMD)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKGAITOYMD)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOTISHKHIGAITOYMD)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOTISHKHIGAITOYMD)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOHOKENSHOKIGO)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOHOKENSHOKIGO)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.KOKUHOHOKENSHONO)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKUHOHOKENSHONO)
                        If (m_intHyojunKB = ABEnumDefine.HyojunKB.KB_Hyojun) Then
                            strAtenaSQLsb.Append(", ")
                            strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.HIHOKENSHAGAITOKB)
                            strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuHyojunEntity.KOKUHOHIHOKENSHAGAITOKB)
                        End If

                        ' ˆóŠÓ
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaInkanEntity.TABLE_NAME).Append(".").Append(ABAtenaInkanEntity.INKANNO)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.INKANNO)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaInkanEntity.TABLE_NAME).Append(".").Append(ABAtenaInkanEntity.INKANTOROKUKB)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.INKANTOROKUKB)

                        ' ‘I‹“
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaSenkyoEntity.TABLE_NAME).Append(".").Append(ABAtenaSenkyoEntity.SENKYOSHIKAKUKB)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.SENKYOSHIKAKUKB)
                        If (m_intHyojunKB = ABEnumDefine.HyojunKB.KB_Hyojun) Then
                            strAtenaSQLsb.Append(", ")
                            strAtenaSQLsb.Append(ABAtenaSenkyoEntity.TABLE_NAME).Append(".").Append(ABAtenaSenkyoEntity.TOROKUJOTAIKBN)
                            strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuHyojunEntity.SENKYOTOROKUJOTAIKBN)
                        End If

                        ' Ž™“¶Žè“–
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaJiteEntity.TABLE_NAME).Append(".").Append(ABAtenaJiteEntity.JIDOTEATEHIYOKB)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JIDOTEATEHIYOKB)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaJiteEntity.TABLE_NAME).Append(".").Append(ABAtenaJiteEntity.JIDOTEATESTYM)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JIDOTEATESTYM)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaJiteEntity.TABLE_NAME).Append(".").Append(ABAtenaJiteEntity.JIDOTEATEEDYM)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.JIDOTEATEEDYM)

                        ' ‰îŒì
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.HIHKNSHANO)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGHIHKNSHANO)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.SKAKSHUTKYMD)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGSKAKSHUTKYMD)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.SKAKSSHTSYMD)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGSKAKSSHTSYMD)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.SKAKHIHOKENSHAKB)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGSKAKHIHOKENSHAKB)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.JUSHOCHITKRIKB)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGJUSHOCHITKRIKB)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.JUKYUSHAKB)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGJUKYUSHAKB)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.YOKAIGJOTAIKBCD)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.YOKAIGJOTAIKBCD)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.KAIGSKAKKB)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGSKAKKB)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.NINTEIKAISHIYMD)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGNINTEIKAISHIYMD)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.NINTEISHURYOYMD)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGNINTEISHURYOYMD)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.JUKYUNINTEIYMD)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGJUKYUNINTEIYMD)
                        strAtenaSQLsb.Append(", ")
                        strAtenaSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.JUKYUNINTEITORIKESHIYMD)
                        strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KAIGJUKYUNINTEITORIKESHIYMD)
                        If (m_intHyojunKB = ABEnumDefine.HyojunKB.KB_Hyojun) Then
                            strAtenaSQLsb.Append(", ")
                            strAtenaSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.HIHOKENSHAGAITOKB)
                            strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuHyojunEntity.KAIGOHIHOKENSHAGAITOKB)
                        End If

                        '*—š—ð”Ô† 000028 2008/01/17 ’Ç‰ÁŠJŽn
                        ' ŒãŠú‚—î
                        If (m_strKobetsuShutokuKB = "1") Then
                            ' ŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ª"1"‚Ìê‡AŒãŠú‚—îŽÒƒ}ƒXƒ^€–Ú‚ðŽæ“¾‚·‚é
                            strAtenaSQLsb.Append(", ")
                            strAtenaSQLsb.Append(ABAtenaKokiKoreiEntity.TABLE_NAME).Append(".").Append(ABAtenaKokiKoreiEntity.SHIKAKUKB)
                            strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKIKOREISHIKAKUKB)
                            strAtenaSQLsb.Append(", ")
                            strAtenaSQLsb.Append(ABAtenaKokiKoreiEntity.TABLE_NAME).Append(".").Append(ABAtenaKokiKoreiEntity.HIHKNSHANO)
                            strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKIKOREIHIHKNSHANO)
                            strAtenaSQLsb.Append(", ")
                            strAtenaSQLsb.Append(ABAtenaKokiKoreiEntity.TABLE_NAME).Append(".").Append(ABAtenaKokiKoreiEntity.SKAKSHUTKJIYUCD)
                            strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKJIYUCD)
                            strAtenaSQLsb.Append(", ")
                            strAtenaSQLsb.Append(ABAtenaKokiKoreiEntity.TABLE_NAME).Append(".").Append(ABAtenaKokiKoreiEntity.SKAKSHUTKJIYUMEI)
                            strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKJIYUMEI)
                            strAtenaSQLsb.Append(", ")
                            strAtenaSQLsb.Append(ABAtenaKokiKoreiEntity.TABLE_NAME).Append(".").Append(ABAtenaKokiKoreiEntity.SKAKSHUTKYMD)
                            strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKYMD)
                            strAtenaSQLsb.Append(", ")
                            strAtenaSQLsb.Append(ABAtenaKokiKoreiEntity.TABLE_NAME).Append(".").Append(ABAtenaKokiKoreiEntity.SKAKSSHTSJIYUCD)
                            strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSJIYUCD)
                            strAtenaSQLsb.Append(", ")
                            strAtenaSQLsb.Append(ABAtenaKokiKoreiEntity.TABLE_NAME).Append(".").Append(ABAtenaKokiKoreiEntity.SKAKSSHTSJIYUMEI)
                            strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSJIYUMEI)
                            strAtenaSQLsb.Append(", ")
                            strAtenaSQLsb.Append(ABAtenaKokiKoreiEntity.TABLE_NAME).Append(".").Append(ABAtenaKokiKoreiEntity.SKAKSSHTSYMD)
                            strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSYMD)
                            strAtenaSQLsb.Append(", ")
                            strAtenaSQLsb.Append(ABAtenaKokiKoreiEntity.TABLE_NAME).Append(".").Append(ABAtenaKokiKoreiEntity.TEKIYOKAISHIYMD)
                            strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKIKOREITEKIYOKAISHIYMD)
                            strAtenaSQLsb.Append(", ")
                            strAtenaSQLsb.Append(ABAtenaKokiKoreiEntity.TABLE_NAME).Append(".").Append(ABAtenaKokiKoreiEntity.TEKIYOSHURYOYMD)
                            strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuEntity.KOKIKOREITEKIYOSHURYOYMD)
                            If (m_intHyojunKB = ABEnumDefine.HyojunKB.KB_Hyojun) Then
                                strAtenaSQLsb.Append(", ")
                                strAtenaSQLsb.Append(ABAtenaKokiKoreiEntity.TABLE_NAME).Append(".").Append(ABAtenaKokiKoreiEntity.HIHOKENSHAGAITOKB)
                                strAtenaSQLsb.Append(" AS ").Append(ABAtena1KobetsuHyojunEntity.KOKIKOREIHIHOKENSHAGAITOKB)
                            End If
                        Else
                            ' ŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ª’l–³‚µ‚Ìê‡Aˆ—‚ðs‚í‚È‚¢
                        End If
                        '*—š—ð”Ô† 000028 2008/01/17 ’Ç‰ÁI—¹
                    End Sub
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼Get—p‚ÌCOUNTEntity‚ð•ÒW
                    '* 
                    '* \•¶           Private SetAtenaCountEntity()
                    '* 
                    '* ‹@”\           ˆ¶–¼Get—p‚Ì€–Ú‚ð•ÒW‚·‚éB
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetAtenaCountEntity(ByRef strAtenaSQLsb As StringBuilder)
                        If (Me.m_blnSelectCount = True) Then
                            If (Me.m_blnSelectAll <> ABEnumDefine.AtenaGetKB.NenkinAll) Then
                                strAtenaSQLsb.Append(",B.")
                                strAtenaSQLsb.Append(ABAtenaCountEntity.DAINOCOUNT)
                                strAtenaSQLsb.Append(",C.")
                                strAtenaSQLsb.Append(ABAtenaCountEntity.SFSKCOUNT)
                            End If
                            strAtenaSQLsb.Append(",D.")
                            strAtenaSQLsb.Append(ABAtenaCountEntity.RENERAKUSAKICOUNT)
                        End If
                    End Sub
                    '*—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ð•tƒf[ƒ^€–Ú•ÒW
                    '* 
                    '* \•¶           Private SetFZYEntity()
                    '* 
                    '* ‹@”\           ˆ¶–¼—š—ð•tƒf[ƒ^‚Ì€–Ú•ÒW‚ð‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetFZYEntity(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.TABLEINSERTKB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.LINKNO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.JUMINHYOJOTAIKBN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.JUKYOCHITODOKEFLG)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.HONGOKUMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.KANAHONGOKUMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.KANJIHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.KANAHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.KANJITSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.KANATSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.KATAKANAHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.UMAREFUSHOKBN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.TSUSHOMEITOUROKUYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.ZAIRYUKIKANCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.ZAIRYUKIKANMEISHO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.ZAIRYUSHACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.ZAIRYUSHAMEISHO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.ZAIRYUCARDNO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.KOFUYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.KOFUYOTEISTYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.KOFUYOTEIEDYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.JUKITAISHOSHASHOJOIDOYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.JUKITAISHOSHASHOJOJIYUCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.JUKITAISHOSHASHOJOJIYU)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.JUKITAISHOSHASHOJOTDKDYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.JUKITAISHOSHASHOJOTDKDTUCIKB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.FRNSTAINUSMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.FRNSTAINUSKANAMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.STAINUSHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.STAINUSKANAHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.STAINUSTSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.STAINUSKANATSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.TENUMAEJ_STAINUSMEI_KYOTSU)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.TENUMAEJ_STAINUSHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.TENUMAEJ_STAINUSTSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.TENSHUTSUYOTEISTAINUSMEI_KYOTSU)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.TENSHUTSUYOTEISTAINUSHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.TENSHUTSUYOTEISTAINUSTSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.TENSHUTSUKKTISTAINUSMEI_KYOTSU)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.TENSHUTSUKKTISTAINUSHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.TENSHUTSUKKTISTAINUSTSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.RESERVE1)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.RESERVE2)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.RESERVE3)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.RESERVE4)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.RESERVE5)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.RESERVE6)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.RESERVE7)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.RESERVE8)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.RESERVE9)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.RESERVE10)
                    End Sub

                    '*—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‹¤’Ê”Ô†ƒf[ƒ^€–Ú•ÒW
                    '* 
                    '* \•¶           Private SetMyNumberEntity()
                    '* 
                    '* ‹@”\           ‹¤’Ê”Ô†ƒf[ƒ^‚Ì€–Ú•ÒW‚ð‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetMyNumberEntity(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABMyNumberEntity.TABLE_NAME, ABMyNumberEntity.MYNUMBER)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABMyNumberEntity.TABLE_NAME, ABMyNumberEntity.CKINKB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABMyNumberEntity.TABLE_NAME, ABMyNumberEntity.IDOKB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABMyNumberEntity.TABLE_NAME, ABMyNumberEntity.IDOYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABMyNumberEntity.TABLE_NAME, ABMyNumberEntity.IDOSHA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABMyNumberEntity.TABLE_NAME, ABMyNumberEntity.RESERVE)
                    End Sub
                    '*—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼Get—p‚ÌJOIN‹å‚ð•ÒW
                    '* 
                    '* \•¶           Private SetAtenaJoin()
                    '* 
                    '* ‹@”\           ˆ¶–¼Get—p‚Ì€–Ú‚ð•ÒW‚·‚éB
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetAtenaJoin(ByRef strAtenaSQLsb As StringBuilder)
                        If (Me.m_blnSelectCount = True) Then
                            If (Me.m_blnSelectAll <> ABEnumDefine.AtenaGetKB.NenkinAll) Then
                                strAtenaSQLsb.Append(" LEFT OUTER JOIN (SELECT ")
                                strAtenaSQLsb.Append(ABDainoEntity.JUMINCD)
                                strAtenaSQLsb.Append(",COUNT(*) AS ")
                                strAtenaSQLsb.Append(ABAtenaCountEntity.DAINOCOUNT)
                                strAtenaSQLsb.Append(" FROM ")
                                strAtenaSQLsb.Append(ABDainoEntity.TABLE_NAME)
                                strAtenaSQLsb.Append(" GROUP BY ")
                                strAtenaSQLsb.Append(ABDainoEntity.JUMINCD)
                                strAtenaSQLsb.Append(") B ON ")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME)
                                strAtenaSQLsb.Append(".")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.JUMINCD)
                                strAtenaSQLsb.Append(" = B.")
                                strAtenaSQLsb.Append(ABDainoEntity.JUMINCD)
                                strAtenaSQLsb.Append(" LEFT OUTER JOIN (SELECT ")
                                strAtenaSQLsb.Append(ABSfskEntity.JUMINCD)
                                strAtenaSQLsb.Append(",COUNT(*) AS ")
                                strAtenaSQLsb.Append(ABAtenaCountEntity.SFSKCOUNT)
                                strAtenaSQLsb.Append(" FROM ")
                                strAtenaSQLsb.Append(ABSfskEntity.TABLE_NAME)
                                strAtenaSQLsb.Append(" GROUP BY ")
                                strAtenaSQLsb.Append(ABSfskEntity.JUMINCD)
                                strAtenaSQLsb.Append(") C ON ")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME)
                                strAtenaSQLsb.Append(".")
                                strAtenaSQLsb.Append(ABAtenaRirekiEntity.JUMINCD)
                                strAtenaSQLsb.Append(" = C.")
                                strAtenaSQLsb.Append(ABSfskEntity.JUMINCD)
                            End If
                            strAtenaSQLsb.Append(" LEFT OUTER JOIN (SELECT ")
                            strAtenaSQLsb.Append(ABRenrakusakiEntity.JUMINCD)
                            strAtenaSQLsb.Append(",COUNT(*) AS ")
                            strAtenaSQLsb.Append(ABAtenaCountEntity.RENERAKUSAKICOUNT)
                            strAtenaSQLsb.Append(" FROM ")
                            strAtenaSQLsb.Append(ABRenrakusakiEntity.TABLE_NAME)
                            strAtenaSQLsb.Append(" GROUP BY ")
                            strAtenaSQLsb.Append(ABRenrakusakiEntity.JUMINCD)
                            strAtenaSQLsb.Append(") D ON ")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME)
                            strAtenaSQLsb.Append(".")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.JUMINCD)
                            strAtenaSQLsb.Append(" = D.")
                            strAtenaSQLsb.Append(ABRenrakusakiEntity.JUMINCD)
                        End If
                    End Sub
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼Get—p‚ÌŒÂ•ÊŽ–€JOIN‹å‚ð•ÒW
                    '* 
                    '* \•¶           Private SetKobetsuJoin()
                    '* 
                    '* ‹@”\           ˆ¶–¼Get—p‚Ì€–Ú‚ð•ÒW‚·‚éB
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetKobetsuJoin(ByRef strAtenaSQLsb As StringBuilder)

                        ' LEFT OUTER JOIN ABATENANENKIN ON ABATENA.JUMINCD=ABATENANENKIN.JUMINCD
                        strAtenaSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaNenkinEntity.TABLE_NAME).Append(" ON ")
                        strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                        strAtenaSQLsb.Append("=")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JUMINCD)

                        ' LEFT OUTER JOIN ABATENAKOKUHO ON ABATENA.JUMINCD=ABATENAKOKUHO.JUMINCD
                        strAtenaSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(" ON ")
                        strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                        strAtenaSQLsb.Append("=")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.JUMINCD)

                        ' LEFT OUTER JOIN ABATENAINKAN ON ABATENA.JUMINCD=ABATENAINKAN.JUMINCD
                        strAtenaSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaInkanEntity.TABLE_NAME).Append(" ON ")
                        strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                        strAtenaSQLsb.Append("=")
                        strAtenaSQLsb.Append(ABAtenaInkanEntity.TABLE_NAME).Append(".").Append(ABAtenaInkanEntity.JUMINCD)

                        ' LEFT OUTER JOIN ABATENASENKYO ON ABATENA.JUMINCD=ABATENASENKYO.JUMINCD
                        strAtenaSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaSenkyoEntity.TABLE_NAME).Append(" ON ")
                        strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                        strAtenaSQLsb.Append("=")
                        strAtenaSQLsb.Append(ABAtenaSenkyoEntity.TABLE_NAME).Append(".").Append(ABAtenaSenkyoEntity.JUMINCD)

                        ' LEFT OUTER JOIN ABATENAJITE ON ABATENA.JUMINCD=ABATENAJIDOUTE.JUMINCD
                        strAtenaSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaJiteEntity.TABLE_NAME).Append(" ON ")
                        strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                        strAtenaSQLsb.Append("=")
                        strAtenaSQLsb.Append(ABAtenaJiteEntity.TABLE_NAME).Append(".").Append(ABAtenaJiteEntity.JUMINCD)

                        ' LEFT OUTER JOIN ABATENAKAIGO ON ABATENA.JUMINCD=ABATENAKAIGO.JUMINCD
                        strAtenaSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaKaigoEntity.TABLE_NAME).Append(" ON ")
                        strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                        strAtenaSQLsb.Append("=")
                        strAtenaSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.JUMINCD)

                        '*—š—ð”Ô† 000025 2008/01/15 ’Ç‰ÁŠJŽn
                        If (m_strKobetsuShutokuKB = "1") Then
                            ' ŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ª"1"‚Ìê‡AŒãŠú‚—îŽÒƒ}ƒXƒ^‚àJOIN‚·‚é
                            strAtenaSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaKokiKoreiEntity.TABLE_NAME).Append(" ON ")
                            strAtenaSQLsb.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                            strAtenaSQLsb.Append("=")
                            strAtenaSQLsb.Append(ABAtenaKokiKoreiEntity.TABLE_NAME).Append(".").Append(ABAtenaKokiKoreiEntity.JUMINCD)
                        Else
                            ' ŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ª’l–³‚µ‚Ìê‡Aˆ—‚ðs‚í‚È‚¢
                        End If
                        '*—š—ð”Ô† 000025 2008/01/15 ’Ç‰ÁI—¹
                    End Sub
                    '*—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                   '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ð•tƒe[ƒuƒ‹JOIN‹åì¬
                    '* 
                    '* \•¶           Private SetFZYJoin()
                    '* 
                    '* ‹@”\           ˆ¶–¼—š—ð•tƒe[ƒuƒ‹‚ÌJOIN‹å‚ðì¬‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetFZYJoin(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(" LEFT OUTER JOIN {0} ", ABAtenaRirekiFZYEntity.TABLE_NAME)
                        strAtenaSQLsb.AppendFormat(" ON {0}.{1} = {2}.{3} ", _
                                                    ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUMINCD, _
                                                    ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.JUMINCD)
                        strAtenaSQLsb.AppendFormat(" AND {0}.{1} = {2}.{3} ", _
                                                    ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.RIREKINO, _
                                                    ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.RIREKINO)
                    End Sub
                    '*—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‹¤’Ê”Ô†ƒe[ƒuƒ‹JOIN‹åì¬
                    '* 
                    '* \•¶           Private SetMyNumberJoin()
                    '* 
                    '* ‹@”\           ‹¤’Ê”Ô†ƒe[ƒuƒ‹‚ÌJOIN‹å‚ðì¬‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetMyNumberJoin(ByRef strAtenaSQLsb As StringBuilder)
                        ' ‹¤’Ê”Ô†ƒe[ƒuƒ‹‚Í’¼‹ßƒŒƒR[ƒh‚Ì‚Ý‚ðŒ‹‡‚·‚éB
                        strAtenaSQLsb.Append(" LEFT OUTER JOIN ")
                        strAtenaSQLsb.AppendFormat("(SELECT * FROM {0} WHERE {1} = '{2}') AS {0} ", _
                                                    ABMyNumberEntity.TABLE_NAME, ABMyNumberEntity.CKINKB, ABMyNumberEntity.DEFAULT.CKINKB.CKIN)
                        strAtenaSQLsb.AppendFormat("ON {0}.{1} = {2}.{3} ", _
                                                    ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUMINCD, _
                                                    ABMyNumberEntity.TABLE_NAME, ABMyNumberEntity.JUMINCD)
                    End Sub
                    '*—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                    '* —š—ð”Ô† 000021 2005/06/17 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     —š—ð”Ô†‚ÌŽæ“¾
                    '* 
                    '* \•¶           Private Function GetRirekiNo(ByVal strJuminCD As String) As DataSet
                    '* 
                    '* ‹@”\           —š—ð”Ô†‚ÌŽæ“¾‚ðs‚¤
                    '* 
                    '* ˆø”           strJuminCD As string : ‘ÎÛ‚Æ‚È‚éZ–¯‚b‚c
                    '* 
                    '* –ß‚è’l         csRirekiNoDataEntity as DataSet:—š—ð”Ô†
                    '************************************************************************************************
                    Public Function GetRirekiNo(ByVal strJuminCD As String) As DataSet
                        Const THIS_METHOD_NAME As String = "GetRirekiNo"
                        Dim csRirekiNoDataEntity As DataSet                '—š—ð”Ô†ƒf[ƒ^ƒZƒbƒg
                        Dim strGetRirekiNoSQL As StringBuilder        '‚r‚p‚k•¶
                        Dim cfUFParameterClass As UFParameterClass      'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim cfUFParameterCollectionClass As UFParameterCollectionClass    'ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX

                        Try

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, Me.GetType.Name, System.Reflection.MethodBase.GetCurrentMethod.Name)

                            '‚r‚p‚k•¶‚Ìì¬
                            strGetRirekiNoSQL = New StringBuilder
                            strGetRirekiNoSQL.Append("SELECT ")
                            strGetRirekiNoSQL.Append(ABAtenaRirekiEntity.RIREKINO)
                            strGetRirekiNoSQL.Append(" FROM ")
                            strGetRirekiNoSQL.Append(ABAtenaRirekiEntity.TABLE_NAME)
                            strGetRirekiNoSQL.Append(" WHERE ")
                            strGetRirekiNoSQL.Append(ABAtenaRirekiEntity.JUMINCD)
                            strGetRirekiNoSQL.Append(" = ")
                            strGetRirekiNoSQL.Append(ABAtenaRirekiEntity.PARAM_JUMINCD)
                            strGetRirekiNoSQL.Append(" ORDER BY ")
                            strGetRirekiNoSQL.Append(ABAtenaRirekiEntity.RIREKINO)
                            strGetRirekiNoSQL.Append(" DESC ")

                            'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            cfUFParameterClass = New UFParameterClass
                            'ƒpƒ‰ƒ[ƒ^‚ÌƒZƒbƒg
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_JUMINCD
                            cfUFParameterClass.Value = strJuminCD

                            'ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            cfUFParameterCollectionClass = New UFParameterCollectionClass
                            'ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÉƒZƒbƒg
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)

                            '—š—ð”Ô†‚ÌŽæ“¾
                            csRirekiNoDataEntity = m_cfRdbClass.GetDataSet(strGetRirekiNoSQL.ToString, ABAtenaRirekiEntity.TABLE_NAME, cfUFParameterCollectionClass, False)

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return csRirekiNoDataEntity

                    End Function
                    '* —š—ð”Ô† 000021 2005/06/17 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000030 2010/05/14 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼       ŠÇ—î•ñŽæ“¾
                    '* 
                    '* \•¶             Private Function GetKanriJoho()
                    '* 
                    '* ‹@”\@@    @   ŠÇ—î•ñ‚ðŽæ“¾‚·‚é
                    '* 
                    '* ˆø”             ‚È‚µ
                    '* 
                    '* –ß‚è’l           ‚È‚µ
                    '************************************************************************************************
                    Private Sub GetKanriJoho()
                        Const THIS_METHOD_NAME As String = "GetKanriJoho"
                        Dim cABAtenaKanriJoho As ABAtenaKanriJohoBClass

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ˆ¶–¼ŠÇ—î•ñ‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                            If (cABAtenaKanriJoho Is Nothing) Then
                                cABAtenaKanriJoho = New ABAtenaKanriJohoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                            End If

                            ' –{ÐŽæ“¾‹æ•ªŽæ“¾
                            m_strHonsekiHittoshKB = cABAtenaKanriJoho.GetHonsekiKB_Param

                            ' ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ªŽæ“¾
                            m_strShoriteishiKB = cABAtenaKanriJoho.GetShoriteishiKB_Param

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException    ' UFAppException‚ðƒLƒƒƒbƒ`
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw objExp

                        End Try

                    End Sub
                    '*—š—ð”Ô† 000030 2010/05/14 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼       ZŠî–@‰ü³Ì×¸ÞŽæ“¾
                    '* 
                    '* \•¶             Private Function GetJukihoKaiseiFG()
                    '* 
                    '* ‹@”\@@    @   ŠÇ—î•ñ‚ðŽæ“¾‚·‚é
                    '* 
                    '* ˆø”             ‚È‚µ
                    '* 
                    '* –ß‚è’l           ‚È‚µ
                    '************************************************************************************************
                    Private Sub GetJukihoKaiseiFG()
                        Const THIS_METHOD_NAME As String = "GetJukihoKaiseiFG"
                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            If (IsNothing(m_csSekoYMDHanteiB)) Then
                                'Ž{s“ú”»’è‚a¸×½‚Ì²Ý½ÀÝ½‰»
                                m_csSekoYMDHanteiB = New ABSekoYMDHanteiBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                'ZŠî–@‰ü³Ì×¸ÞŽ{s“ú”»’èŒ‹‰Ê
                                m_blnJukihoKaiseiFG = m_csSekoYMDHanteiB.CheckAfterSekoYMD
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException    ' UFAppException‚ðƒLƒƒƒbƒ`
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw objExp

                        End Try
                    End Sub
                    '*—š—ð”Ô† 000032 2011/10/24 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁŠJŽn
                    ''' <summary>
                    ''' ‹¤’Ê”Ô†@ˆ¶–¼Žæ“¾@’¼‹ßŒŸõ‹æ•ªŽæ“¾
                    ''' </summary>
                    ''' <remarks></remarks>
                    Private Sub GetMyNumberChokkinSearchKB()

                        Dim cABAtenaKanriJoho As ABAtenaKanriJohoBClass

                        Try

                            ' ˆ¶–¼ŠÇ—î•ñƒrƒWƒlƒXƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            cABAtenaKanriJoho = New ABAtenaKanriJohoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)

                            ' ‹¤’Ê”Ô†@ˆ¶–¼Žæ“¾@’¼‹ßŒŸõ‹æ•ª‚ÌŽæ“¾
                            m_strMyNumberChokkinSearchKB_Param = cABAtenaKanriJoho.GetMyNumberChokkinSearchKB_Param()

                        Catch csExp As Exception
                            Throw
                        End Try

                    End Sub
                    '*—š—ð”Ô† 000033 2014/04/28 ’Ç‰ÁI—¹

                #End Region

                    '*—š—ð”Ô† 000035 2015/05/08 ’Ç‰ÁŠJŽn
                #Region "ˆ¶–¼—š—ðƒ}ƒXƒ^’Šo(”Ô†ˆêŠ‡Žæ“¾ƒoƒbƒ`‚©‚çŒÄo)"
                    ''' <summary>
                    ''' ˆ¶–¼—š—ðƒ}ƒXƒ^’Šo
                    ''' </summary>
                    ''' <param name="cSearchKey">ˆ¶–¼—š—ðƒ}ƒXƒ^ŒŸõƒL[</param>
                    ''' <returns>Žæ“¾‚µ‚½ˆ¶–¼—š—ðƒ}ƒXƒ^‚Ì’¼‹ßƒf[ƒ^</returns>
                    Public Function CreateRuisekiData(ByVal cSearchKey As ABAtenaSearchKey) As DataSet
                        Const THIS_METHOD_NAME As String = "CreateRuisekiData"
                        Dim csAtenaRirekiEntity As DataSet                  'ˆ¶–¼—š—ðƒf[ƒ^ƒZƒbƒg
                        Dim strSQL As New StringBuilder()
                        Dim strAtenaSQLsbWhere As StringBuilder
                        Dim strORDER As StringBuilder
                        Dim cfUFParameterClass As UFParameterClass
                        Dim cfSelectUFParameterCollectionClass As UFParameterCollectionClass

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            If (m_strAtenaSQLsbAll.ToString = String.Empty) Then
                                '‰‰ñSQLì¬
                                Call GetRirekiSQLString()
                            End If
                            strSQL.Append(m_strAtenaSQLsbAll)

                            If (m_csDataSchmaAll Is Nothing) Then
                                m_csDataSchmaAll = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaRirekiEntity.TABLE_NAME, False)
                            End If
                            m_csDataSchma = m_csDataSchmaAll

                            'Where‹åì¬(Z–¯ƒR[ƒh/Z“oŠO—Dæ‹æ•ª)
                            strAtenaSQLsbWhere = New StringBuilder
                            strAtenaSQLsbWhere.Append(" WHERE ")
                            strAtenaSQLsbWhere.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                            strAtenaSQLsbWhere.Append(" = ")
                            strAtenaSQLsbWhere.Append(ABAtenaRirekiEntity.KEY_JUMINCD)
                            strAtenaSQLsbWhere.Append(" AND ")
                            strAtenaSQLsbWhere.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUTOGAIYUSENKB)
                            strAtenaSQLsbWhere.Append(" = ")
                            strAtenaSQLsbWhere.Append(ABAtenaRirekiEntity.KEY_JUTOGAIYUSENKB)
                            strAtenaSQLsbWhere.Append(" AND ")
                            strAtenaSQLsbWhere.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.RRKED_YMD)
                            strAtenaSQLsbWhere.Append(" = ")
                            strAtenaSQLsbWhere.Append(ABAtenaRirekiEntity.KEY_RRKED_YMD)
                            strAtenaSQLsbWhere.Append(" AND ")
                            strAtenaSQLsbWhere.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.SAKUJOFG)
                            strAtenaSQLsbWhere.Append(" <> '1' ")

                            'ORDER BY‹åì¬(Z–¯ƒR[ƒh)
                            strORDER = New StringBuilder()
                            strORDER.Append(" ORDER BY ")
                            strORDER.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.JUMINCD)
                            strORDER.Append(" ASC;")

                            strSQL.Append(strAtenaSQLsbWhere)
                            strSQL.Append(strORDER)

                            ' SELECT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            cfSelectUFParameterCollectionClass = New UFParameterCollectionClass
                            'ƒpƒ‰ƒ[ƒ^(Z–¯ƒR[ƒh)
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUMINCD
                            cfUFParameterClass.Value = cSearchKey.p_strJuminCD
                            cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            'ƒpƒ‰ƒ[ƒ^(Z“oŠO—Dæ‹æ•ª)
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUTOGAIYUSENKB
                            cfUFParameterClass.Value = cSearchKey.p_strJutogaiYusenKB
                            cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            'ƒpƒ‰ƒ[ƒ^(—š—ðI—¹”NŒŽ“ú)
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_RRKED_YMD
                            cfUFParameterClass.Value = "99999999"
                            cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                            csAtenaRirekiEntity = m_csDataSchma.Clone()
                            csAtenaRirekiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, csAtenaRirekiEntity, ABAtenaRirekiEntity.TABLE_NAME, cfSelectUFParameterCollectionClass, False)

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return csAtenaRirekiEntity

                    End Function

                    ''' <summary>
                    ''' SQL•¶Žš—ñ‚ðŽæ“¾‚·‚é
                    ''' </summary>
                    ''' <remarks></remarks>
                    Private Sub GetRirekiSQLString()
                        Const THIS_METHOD_NAME As String = "GetRirekiSQLString"

                        Try
                            m_strAtenaSQLsbAll.Append("SELECT ")

                            'ˆ¶–¼—š—ð•t‰Á
                            Call SetRirekiEntity(m_strAtenaSQLsbAll)

                            'ˆ¶–¼”N‹à•t‰Á
                            Call SetNenkinEntity(m_strAtenaSQLsbAll)

                            'ˆ¶–¼‘•Û•t‰Á
                            Call SetKokuhoEntity(m_strAtenaSQLsbAll)

                            'FROM‹å
                            m_strAtenaSQLsbAll.Append(" FROM ")
                            m_strAtenaSQLsbAll.Append(ABAtenaRirekiEntity.TABLE_NAME)

                            'ˆ¶–¼”N‹àƒ}ƒXƒ^‚ð•t‰Á
                            Call SetNENKINJoin(m_strAtenaSQLsbAll)

                            'ˆ¶–¼‘•Ûƒ}ƒXƒ^‚ð•t‰Á
                            Call SetKOKUHOJoin(m_strAtenaSQLsbAll)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try
                    End Sub

                #Region "ˆ¶–¼—š—ðƒf[ƒ^€–Ú•ÒW"
                    ''' <summary>
                    ''' ˆ¶–¼—š—ðƒf[ƒ^€–Ú•ÒW
                    ''' </summary>
                    ''' <param name="strAtenaSQLsb">—š—ðŽæ“¾—pSQL</param>
                    ''' <remarks></remarks>
                    Private Sub SetRirekiEntity(ByRef strAtenaSQLsb As StringBuilder)
                        Const THIS_METHOD_NAME As String = "SetRirekiEntity"
                        Try
                            With strAtenaSQLsb
                                .AppendFormat("{0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUMINCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SHICHOSONCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KYUSHICHOSONCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.RIREKINO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.RRKST_YMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.RRKED_YMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUMINJUTOGAIKB)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUMINYUSENIKB)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUTOGAIYUSENKB)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.ATENADATAKB)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.STAICD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUMINHYOCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SEIRINO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.ATENADATASHU)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.HANYOKB1)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KJNHJNKB)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.HANYOKB2)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KANNAIKANGAIKB)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KANAMEISHO1)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KANJIMEISHO1)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KANAMEISHO2)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KANJIMEISHO2)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KANJIHJNKEITAI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KANJIHJNDAIHYOSHSHIMEI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SEARCHKANJIMEISHO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KYUSEI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SEARCHKANASEIMEI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SEARCHKANASEI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SEARCHKANAMEI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKIRRKNO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.UMAREYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.UMAREWMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SEIBETSUCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SEIBETSU)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SEKINO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUMINHYOHYOJIJUN)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.ZOKUGARACD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.ZOKUGARA)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.DAI2JUMINHYOHYOJIJUN)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.DAI2ZOKUGARACD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.DAI2ZOKUGARA)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.STAINUSJUMINCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.STAINUSMEI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KANASTAINUSMEI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.DAI2STAINUSJUMINCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.DAI2STAINUSMEI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KANADAI2STAINUSMEI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.YUBINNO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUSHOCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUSHO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.BANCHICD1)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.BANCHICD2)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.BANCHICD3)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.BANCHI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KATAGAKIFG)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KATAGAKICD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KATAGAKI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.RENRAKUSAKI1)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.RENRAKUSAKI2)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.HON_ZJUSHOCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.HON_JUSHO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.HONSEKIBANCHI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.HITTOSH)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.CKINIDOYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.CKINJIYUCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.CKINJIYU)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.CKINTDKDYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.CKINTDKDTUCIKB)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TOROKUIDOYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TOROKUIDOWMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TOROKUJIYUCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TOROKUJIYU)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TOROKUTDKDYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TOROKUTDKDWMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TOROKUTDKDTUCIKB)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUTEIIDOYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUTEIIDOWMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUTEIJIYUCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUTEIJIYU)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUTEITDKDYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUTEITDKDWMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUTEITDKDTUCIKB)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SHOJOIDOYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SHOJOJIYUCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SHOJOJIYU)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SHOJOTDKDYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SHOJOTDKDTUCIKB)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUYOTEIIDOYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUKKTIIDOYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUKKTITSUCHIYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUNYURIYUCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUNYURIYU)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENUMAEJ_YUBINNO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENUMAEJ_ZJUSHOCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENUMAEJ_JUSHO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENUMAEJ_BANCHI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENUMAEJ_KATAGAKI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENUMAEJ_STAINUSMEI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUYOTEIYUBINNO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUYOTEIZJUSHOCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUYOTEIJUSHO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUYOTEIBANCHI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUYOTEIKATAGAKI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUYOTEISTAINUSMEI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUKKTIYUBINNO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUKKTIZJUSHOCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUKKTIJUSHO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUKKTIBANCHI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUKKTIKATAGAKI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUKKTISTAINUSMEI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TENSHUTSUKKTIMITDKFG)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.BIKOYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.BIKO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.BIKOTENSHUTSUKKTIJUSHOFG)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.HANNO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KAISEIATOFG)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KAISEIMAEFG)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KAISEIYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.GYOSEIKUCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.GYOSEIKUMEI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.CHIKUCD1)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.CHIKUMEI1)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.CHIKUCD2)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.CHIKUMEI2)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.CHIKUCD3)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.CHIKUMEI3)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TOHYOKUCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SHOGAKKOKUCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.CHUGAKKOKUCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.HOGOSHAJUMINCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KANJIHOGOSHAMEI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KANAHOGOSHAMEI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KIKAYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KARIIDOKB)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SHORITEISHIKB)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKIYUBINNO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SHORIYOKUSHIKB)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKIJUSHOCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKIJUSHO)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKIBANCHICD1)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKIBANCHICD2)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKIBANCHICD3)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKIBANCHI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKIKATAGAKIFG)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKIKATAGAKICD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKIKATAGAKI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKIGYOSEIKUCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKIGYOSEIKUMEI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKICHIKUCD1)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKICHIKUMEI1)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKICHIKUCD2)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKICHIKUMEI2)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKICHIKUCD3)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUKICHIKUMEI3)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KAOKUSHIKIKB)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.BIKOZEIMOKU)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KOKUSEKICD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KOKUSEKI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.ZAIRYUSKAKCD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.ZAIRYUSKAK)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.ZAIRYUKIKAN)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.ZAIRYU_ST_YMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.ZAIRYU_ED_YMD)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.RESERCE)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.TANMATSUID)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SAKUJOFG)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KOSHINCOUNTER)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SAKUSEINICHIJI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.SAKUSEIUSER)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KOSHINNICHIJI)
                                .AppendFormat(", {0}.{1}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.KOSHINUSER)
                            End With
                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                    End Sub
                #End Region

                #Region "ˆ¶–¼”N‹àƒf[ƒ^€–Ú•ÒW"
                    ''' <summary>
                    ''' ”N‹àƒf[ƒ^€–Ú•ÒW
                    ''' </summary>
                    ''' <param name="strAtenaSQLsb">—š—ðŽæ“¾—pSQL</param>
                    ''' <remarks></remarks>
                    Private Sub SetNenkinEntity(ByRef strAtenaSQLsb As StringBuilder)
                        Const THIS_METHOD_NAME As String = "SetNenkinEntity"
                        Try
                            With strAtenaSQLsb
                                .AppendFormat(", {0}.{1}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.KSNENKNNO)
                                .AppendFormat(", {0}.{1} AS {2}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.SKAKSHUTKYMD, ABAtenaRuisekiEntity.NENKNSKAKSHUTKYMD)
                                .AppendFormat(", {0}.{1} AS {2}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.SKAKSHUTKSHU, ABAtenaRuisekiEntity.NENKNSKAKSHUTKSHU)
                                .AppendFormat(", {0}.{1} AS {2}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.SKAKSHUTKRIYUCD, ABAtenaRuisekiEntity.NENKNSKAKSHUTKRIYUCD)
                                .AppendFormat(", {0}.{1} AS {2}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.SKAKSSHTSYMD, ABAtenaRuisekiEntity.NENKNSKAKSSHTSYMD)
                                .AppendFormat(", {0}.{1} AS {2}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.SKAKSSHTSRIYUCD, ABAtenaRuisekiEntity.NENKNSKAKSSHTSRIYUCD)
                                .AppendFormat(", {0}.{1}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.JKYNENKNKIGO1)
                                .AppendFormat(", {0}.{1}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.JKYNENKNNO1)
                                .AppendFormat(", {0}.{1}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.JKYNENKNSHU1)
                                .AppendFormat(", {0}.{1}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.JKYNENKNEDABAN1)
                                .AppendFormat(", {0}.{1}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.JKYNENKNKB1)
                                .AppendFormat(", {0}.{1}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.JKYNENKNKIGO2)
                                .AppendFormat(", {0}.{1}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.JKYNENKNNO2)
                                .AppendFormat(", {0}.{1}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.JKYNENKNSHU2)
                                .AppendFormat(", {0}.{1}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.JKYNENKNEDABAN2)
                                .AppendFormat(", {0}.{1}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.JKYNENKNKB2)
                                .AppendFormat(", {0}.{1}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.JKYNENKNKIGO3)
                                .AppendFormat(", {0}.{1}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.JKYNENKNNO3)
                                .AppendFormat(", {0}.{1}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.JKYNENKNSHU3)
                                .AppendFormat(", {0}.{1}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.JKYNENKNEDABAN3)
                                .AppendFormat(", {0}.{1}", ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.JKYNENKNKB3)
                            End With
                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try
                    End Sub
                #End Region

                #Region "‘•Ûƒf[ƒ^€–Ú•ÒW"
                    ''' <summary>
                    ''' ‘•Ûƒf[ƒ^€–Ú•ÒW
                    ''' </summary>
                    ''' <param name="strAtenaSQLsb">—š—ðŽæ“¾—pSQL</param>
                    ''' <remarks></remarks>
                    Private Sub SetKokuhoEntity(ByRef strAtenaSQLsb As StringBuilder)
                        Const THIS_METHOD_NAME As String = "SetKokuhoEntity"
                        Try
                            With strAtenaSQLsb
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHONO)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOSHIKAKUKB)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOSHIKAKUKBMEISHO)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOSHIKAKUKBRYAKUSHO)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOGAKUENKB)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOGAKUENKBMEISHO)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOGAKUENKBRYAKUSHO)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOSHUTOKUYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOSOSHITSUYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOTISHKKB)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOTISHKKBMEISHO)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOTISHKKBRYAKUSHO)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKB)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKBMEISHO)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKBRYAKUSHO)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOTISHKGAITOYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOTISHKHIGAITOYMD)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOHOKENSHOKIGO)
                                .AppendFormat(", {0}.{1}", ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.KOKUHOHOKENSHONO)
                            End With
                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try
                    End Sub
                #End Region

                #Region "ˆ¶–¼”N‹àJOIN‹åì¬"
                    ''' <summary>
                    ''' ˆ¶–¼”N‹àƒe[ƒuƒ‹‚ÌJOIN‹å‚ðì¬
                    ''' </summary>
                    ''' <param name="strAtenaSQLsb">—š—ðŽæ“¾—pSQL</param>
                    ''' <remarks></remarks>
                    Private Sub SetNENKINJoin(ByRef strAtenaSQLsb As StringBuilder)
                        Const THIS_METHOD_NAME As String = "SetNENKINJoin"
                        Try
                            With strAtenaSQLsb
                                .AppendFormat(" LEFT OUTER JOIN {0} ", ABAtenaNenkinEntity.TABLE_NAME)
                                .AppendFormat(" ON {0}.{1} = {2}.{3} ", _
                                                    ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUMINCD, _
                                                    ABAtenaNenkinEntity.TABLE_NAME, ABAtenaNenkinEntity.JUMINCD)
                            End With
                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try
                    End Sub
                #End Region

                #Region "ˆ¶–¼‘•ÛJOIN‹åì¬"
                    ''' <summary>
                    ''' ˆ¶–¼‘•Ûƒe[ƒuƒ‹‚ÌJOIN‹å‚ðì¬
                    ''' </summary>
                    ''' <param name="strAtenaSQLsb">—š—ðŽæ“¾—pSQL</param>
                    ''' <remarks></remarks>
                    Private Sub SetKOKUHOJoin(ByRef strAtenaSQLsb As StringBuilder)
                        Const THIS_METHOD_NAME As String = "SetKOKUHOJoin"
                        Try
                            strAtenaSQLsb.AppendFormat(" LEFT OUTER JOIN {0} ", ABAtenaKokuhoEntity.TABLE_NAME)
                            strAtenaSQLsb.AppendFormat(" ON {0}.{1} = {2}.{3} ", _
                                                        ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUMINCD, _
                                                        ABAtenaKokuhoEntity.TABLE_NAME, ABAtenaKokuhoEntity.JUMINCD)
                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try
                    End Sub
                #End Region

                #End Region
                    '*—š—ð”Ô† 000035 2015/05/08 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000037 2023/03/10 ’Ç‰ÁŠJŽn
                #Region "ˆ¶–¼—š—ð•W€ƒf[ƒ^€–Ú•ÒW"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ð•W€ƒf[ƒ^€–Ú•ÒW
                    '* 
                    '* \•¶           Private SetHyojunEntity()
                    '* 
                    '* ‹@”\           ˆ¶–¼—š—ð•W€ƒf[ƒ^‚Ì€–Ú•ÒW‚ð‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetHyojunEntity(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.EDANO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SHIMEIKANAKAKUNINFG)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.UMAREBIFUSHOPTN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.FUSHOUMAREBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JIJITSUSTAINUSMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SHIKUCHOSONCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.MACHIAZACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SHIKUCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.MACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SEARCHJUSHO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.KANAKATAGAKI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SEARCHKATAGAKI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.BANCHIEDABANSUCHI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUSHO_KUNIMEICODE)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUSHO_KUNIMEITO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUSHO_KOKUGAIJUSHO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.HON_SHIKUCHOSONCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.HON_MACHIAZACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.HON_TODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.HON_SHIKUGUNCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.HON_MACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.CKINIDOWMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.CKINIDOBIFUSHOPTN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.FUSHOCKINIDOBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TOROKUIDOBIFUSHOPTN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.FUSHOTOROKUIDOBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.HYOJUNKISAIJIYUCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.KISAIYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.KISAIBIFUSHOPTN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.FUSHOKISAIBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUTEIIDOBIFUSHOPTN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.FUSHOJUTEIIDOBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.HYOJUNSHOJOJIYUCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.KOKUSEKISOSHITSUBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SHOJOIDOWMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SHOJOIDOBIFUSHOPTN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.FUSHOSHOJOIDOBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENUMAEJ_SHIKUCHOSONCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENUMAEJ_MACHIAZACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENUMAEJ_TODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENUMAEJ_SHIKUCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENUMAEJ_MACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENUMAEJ_KOKUSEKICD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENUMAEJ_KOKUSEKI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENUMAEJ_KOKUGAIJUSHO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SAISHUTJ_YUBINNO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SAISHUTJ_SHIKUCHOSONCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SAISHUTJ_MACHIAZACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SAISHUTJ_TODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SAISHUTJ_SHIKUCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SAISHUTJ_MACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SAISHUTJ_BANCHI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SAISHUTJ_KATAGAKI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SAISHUJ_TODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SAISHUJ_SHIKUCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SAISHUJ_MACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SAISHUJ_BANCHI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SAISHUJ_KATAGAKI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEISHIKUCHOSONCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEIMACHIAZACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEITODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEISHIKUCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEIMACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEIKOKUSEKICD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEIKOKUSEKI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEIKOKUGAIJUSHO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENSHUTSUKKTISHIKUCHOSONCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENSHUTSUKKTIMACHIAZACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENSHUTSUKKTITODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENSHUTSUKKTISHIKUCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TENSHUTSUKKTIMACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.KAISEIBIFUSHOPTN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.FUSHOKAISEIBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.KAISEISHOJOYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.KAISEISHOJOBIFUSHOPTN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.FUSHOKAISEISHOJOBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.CHIKUCD4)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.CHIKUCD5)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.CHIKUCD6)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.CHIKUCD7)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.CHIKUCD8)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.CHIKUCD9)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.CHIKUCD10)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TOKUBETSUYOSHIKB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.HYOJUNIDOKB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.NYURYOKUBASHOCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.NYURYOKUBASHO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SEARCHKANJIKYUUJI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SEARCHKANAKYUUJI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.KYUUJIKANAKAKUNINFG)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TDKDSHIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.HYOJUNIDOJIYUCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.NICHIJOSEIKATSUKENIKICD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.KOBOJONOJUSHO_SHOZAICHI_YOMIGANA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TOROKUBUSHO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TANKITAIZAISHAFG)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.KYOYUNINZU)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SHIZEIJIMUSHOCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SHUKKOKUKIKAN_ST)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SHUKKOKUKIKAN_ED)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.IDOSHURUI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.SHOKANKUCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.TOGOATENAFG)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.FUSHOUMAREBI_DATE)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.FUSHOCKINIDOBI_DATE)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.FUSHOSHOJOIDOBI_DATE)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUKISHIKUCHOSONCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUKIMACHIAZACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUKITODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUKISHIKUCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUKIMACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUKIKANAKATAGAKI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUKICHIKUCD4)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUKICHIKUCD5)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUKICHIKUCD6)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUKICHIKUCD7)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUKICHIKUCD8)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUKICHIKUCD9)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUKICHIKUCD10)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUKIBANCHIEDABANSUCHI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_H", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.RESERVE1)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_H", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.RESERVE2)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_H", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.RESERVE3)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_H", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.RESERVE4)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_H", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.RESERVE5)
                    End Sub
                #End Region

                #Region "ˆ¶–¼—š—ð•t•W€ƒf[ƒ^€–Ú•ÒW"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ð•t•W€ƒf[ƒ^€–Ú•ÒW
                    '* 
                    '* \•¶           Private SetFZYHyojunEntity()
                    '* 
                    '* ‹@”\           ˆ¶–¼—š—ð•t•W€ƒf[ƒ^‚Ì€–Ú•ÒW‚ð‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetFZYHyojunEntity(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.SEARCHFRNMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.SEARCHKANAFRNMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.SEARCHTSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.SEARCHKANATSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.TSUSHOKANAKAKUNINFG)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.SHIMEIYUSENKB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.SEARCHKANJIHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.SEARCHKANAHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.ZAIRYUCARDNOKBN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.JUKYOCHIHOSEICD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.HODAI30JO46MATAHA47KB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.STAINUSSHIMEIYUSENKB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.TOKUSHOMEI_YUKOKIGEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_FH", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.RESERVE1)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_FH", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.RESERVE2)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_FH", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.RESERVE3)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_FH", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.RESERVE4)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_FH", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.RESERVE5)
                    End Sub
                #End Region

                #Region "•sŒ»Zî•ñƒf[ƒ^€–Ú•ÒW"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     •sŒ»Zî•ñƒf[ƒ^€–Ú•ÒW
                    '* 
                    '* \•¶           Private SetFugenjuEntity()
                    '* 
                    '* ‹@”\           •sŒ»Zî•ñƒf[ƒ^‚Ì€–Ú•ÒW‚ð‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetFugenjuEntity(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUKB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_YUBINNO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_SHICHOSONCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_MACHIAZACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_TODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_SHIKUGUNCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_MACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_BANCHI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_KATAGAKI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_KANAKATAGAKI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUJOHO_TAISHOSHAKUBUN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUJOHO_TAISHOSHASHIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUJOHO_TAISHOSHASHIMEI_SEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUJOHO_TAISHOSHASHIMEI_MEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUJOHO_UMAREYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUJOHO_SEIBETSU)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.KYOJUFUMEI_YMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUTOROKUYMD)
                        '*—š—ð”Ô† 000038 2023/08/14 C³ŠJŽn
                        'strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.GYOSEIKUCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUGYOSEIKUCD)
                        '*—š—ð”Ô† 000038 2023/08/14 C³I—¹
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUJOHO_BIKO)
                    End Sub
                #End Region

                #Region "‹¤’Ê”Ô†•W€ƒf[ƒ^€–Ú•ÒW"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‹¤’Ê”Ô†•W€ƒf[ƒ^€–Ú•ÒW
                    '* 
                    '* \•¶           Private SetMyNumberHyojunEntity()
                    '* 
                    '* ‹@”\           ‹¤’Ê”Ô†•W€ƒf[ƒ^‚Ì€–Ú•ÒW‚ð‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetMyNumberHyojunEntity(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABMyNumberHyojunEntity.TABLE_NAME, ABMyNumberHyojunEntity.BANGOHOKOSHINKB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_MH", ABMyNumberHyojunEntity.TABLE_NAME, ABMyNumberHyojunEntity.RESERVE1)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_MH", ABMyNumberHyojunEntity.TABLE_NAME, ABMyNumberHyojunEntity.RESERVE2)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_MH", ABMyNumberHyojunEntity.TABLE_NAME, ABMyNumberHyojunEntity.RESERVE3)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_MH", ABMyNumberHyojunEntity.TABLE_NAME, ABMyNumberHyojunEntity.RESERVE4)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_MH", ABMyNumberHyojunEntity.TABLE_NAME, ABMyNumberHyojunEntity.RESERVE5)
                    End Sub
                #End Region

                #Region "“dŽqØ–¾‘î•ñƒf[ƒ^€–Ú•ÒW"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     “dŽqØ–¾‘î•ñƒf[ƒ^€–Ú•ÒW
                    '* 
                    '* \•¶           Private SetDenshiShomeishoMSTEntity()
                    '* 
                    '* ‹@”\           “dŽqØ–¾‘î•ñƒf[ƒ^‚Ì€–Ú•ÒW‚ð‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetDenshiShomeishoMSTEntity(ByRef strAtenaSQLsb As StringBuilder)
                        If (Me.m_blnSelectAll <> ABEnumDefine.AtenaGetKB.NenkinAll) AndAlso
                           (Me.m_blnMethodKB = ABEnumDefine.MethodKB.KB_AtenaGet1) Then
                            strAtenaSQLsb.AppendFormat(", DS3.{0}", ABDENSHISHOMEISHOMSTEntity.SERIALNO)
                        End If
                    End Sub
                #End Region

                #Region "ˆ¶–¼—š—ð•W€ƒe[ƒuƒ‹JOIN‹åì¬"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ð•W€ƒe[ƒuƒ‹JOIN‹åì¬
                    '* 
                    '* \•¶           Private SetHyojunJoin()
                    '* 
                    '* ‹@”\           ˆ¶–¼—š—ð•W€ƒe[ƒuƒ‹‚ÌJOIN‹å‚ðì¬‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetHyojunJoin(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(" LEFT OUTER JOIN {0} ", ABAtenaRirekiHyojunEntity.TABLE_NAME)
                        strAtenaSQLsb.AppendFormat(" ON {0}.{1} = {2}.{3} ",
                                                    ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUMINCD,
                                                    ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUMINCD)
                        strAtenaSQLsb.AppendFormat(" AND {0}.{1} = {2}.{3} ",
                                                    ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.RIREKINO,
                                                    ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.RIREKINO)
                    End Sub
                #End Region

                #Region "ˆ¶–¼—š—ð•t•W€ƒe[ƒuƒ‹JOIN‹åì¬"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ð•t•W€ƒe[ƒuƒ‹JOIN‹åì¬
                    '* 
                    '* \•¶           Private SetFZYHyojunJoin()
                    '* 
                    '* ‹@”\           ˆ¶–¼—š—ð•t•W€ƒe[ƒuƒ‹‚ÌJOIN‹å‚ðì¬‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetFZYHyojunJoin(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(" LEFT OUTER JOIN {0} ", ABAtenaRirekiFZYHyojunEntity.TABLE_NAME)
                        strAtenaSQLsb.AppendFormat(" ON {0}.{1} = {2}.{3} ",
                                                    ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUMINCD,
                                                    ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.JUMINCD)
                        strAtenaSQLsb.AppendFormat(" AND {0}.{1} = {2}.{3} ",
                                                    ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.RIREKINO,
                                                    ABAtenaRirekiFZYHyojunEntity.TABLE_NAME, ABAtenaRirekiFZYHyojunEntity.RIREKINO)
                    End Sub
                #End Region

                #Region "•sŒ»Zî•ñƒe[ƒuƒ‹JOIN‹åì¬"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     •sŒ»Zî•ñƒe[ƒuƒ‹JOIN‹åì¬
                    '* 
                    '* \•¶           Private SetFugenjuJoin()
                    '* 
                    '* ‹@”\           •sŒ»Zî•ñƒe[ƒuƒ‹‚ÌJOIN‹å‚ðì¬‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetFugenjuJoin(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(" LEFT OUTER JOIN {0} ", ABFugenjuJohoEntity.TABLE_NAME)
                        strAtenaSQLsb.AppendFormat(" ON {0}.{1} = {2}.{3} ",
                                                    ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUMINCD,
                                                    ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.JUMINCD)
                    End Sub
                #End Region

                #Region "‹¤’Ê”Ô†•W€ƒe[ƒuƒ‹JOIN‹åì¬"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‹¤’Ê”Ô†•W€ƒe[ƒuƒ‹JOIN‹åì¬
                    '* 
                    '* \•¶           Private SetMyNumberHyojunJoin()
                    '* 
                    '* ‹@”\           ‹¤’Ê”Ô†•W€ƒe[ƒuƒ‹‚ÌJOIN‹å‚ðì¬‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetMyNumberHyojunJoin(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(" LEFT OUTER JOIN {0} ", ABMyNumberHyojunEntity.TABLE_NAME)
                        strAtenaSQLsb.AppendFormat(" ON {0}.{1} = {2}.{3} ",
                                                    ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUMINCD,
                                                    ABMyNumberHyojunEntity.TABLE_NAME, ABMyNumberHyojunEntity.JUMINCD)
                        strAtenaSQLsb.AppendFormat(" AND {0}.{1} = {2}.{3} ",
                                                    ABMyNumberEntity.TABLE_NAME, ABMyNumberEntity.MYNUMBER,
                                                    ABMyNumberHyojunEntity.TABLE_NAME, ABMyNumberHyojunEntity.MYNUMBER)
                    End Sub
                #End Region

                #Region "“dŽqØ–¾‘î•ñƒe[ƒuƒ‹JOIN‹åì¬"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     “dŽqØ–¾‘î•ñƒe[ƒuƒ‹JOIN‹åì¬
                    '* 
                    '* \•¶           Private SetDenshiShomeishoMST()
                    '* 
                    '* ‹@”\           “dŽqØ–¾‘î•ñƒe[ƒuƒ‹‚ÌJOIN‹å‚ðì¬‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetDenshiShomeishoMSTJoin(ByRef strAtenaSQLsb As StringBuilder)
                        If (Me.m_blnSelectAll <> ABEnumDefine.AtenaGetKB.NenkinAll) AndAlso
                           (Me.m_blnMethodKB = ABEnumDefine.MethodKB.KB_AtenaGet1) Then
                            ' “dŽqØ–¾‘î•ñƒe[ƒuƒ‹‚Íˆ—“úŽž‚ªÅV‚ÌƒŒƒR[ƒh‚Ì‚Ý‚ðŒ‹‡‚·‚éB
                            strAtenaSQLsb.Append(" LEFT OUTER JOIN ")
                            strAtenaSQLsb.AppendFormat("(SELECT DS1.* FROM {0} AS DS1 INNER JOIN (SELECT {1}, {2}, MAX({3}) AS {3} FROM {0} GROUP BY {1}, {2}) AS DS2 ON DS1.{1} = DS2.{1} AND DS1.{2} = DS2.{2} AND DS1.{3} = DS2.{3}) AS DS3 ",
                                                       ABDENSHISHOMEISHOMSTEntity.TABLE_NAME,
                                                       ABDENSHISHOMEISHOMSTEntity.JUMINCD,
                                                       ABDENSHISHOMEISHOMSTEntity.STAICD,
                                                       ABDENSHISHOMEISHOMSTEntity.SHORINICHIJI)

                            strAtenaSQLsb.AppendFormat(" ON {0}.{1} = DS3.{2} ",
                                                        ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUMINCD,
                                                        ABDENSHISHOMEISHOMSTEntity.JUMINCD)
                            strAtenaSQLsb.AppendFormat(" AND {0}.{1} = DS3.{2} ",
                                                        ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.STAICD,
                                                        ABDENSHISHOMEISHOMSTEntity.STAICD)
                        End If
                    End Sub
                #End Region
                    '*—š—ð”Ô† 000037 2023/03/10 ’Ç‰ÁI—¹

                #Region "ˆ¶–¼—š—ðŽæ“¾"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒf[ƒ^’Šo
                    '* 
                    '* \•¶           Public Function GetAtenaRirekiByRirekiNO(ByVal strJuminCD As String, ByVal strRirekiNO As String) As DataSet
                    '* 
                    '* ‹@”\@@    @@ˆ¶–¼—š—ðƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
                    '* 
                    '* ˆø”           strJuminCD   : Z–¯ƒR[ƒh
                    '* @@           strRirekiNO  : —š—ð”Ô†
                    '* 
                    '* –ß‚è’l         DataSet : Žæ“¾‚µ‚½ˆ¶–¼—š—ðƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
                    '************************************************************************************************
                    Public Function GetAtenaRirekiByRirekiNO(ByVal strJuminCD As String, ByVal strRirekiNO As String) As DataSet
                        Dim cfUFParameterClass As UFParameterClass
                        Dim csAtenaRirekiEntity As DataSet                  'ˆ¶–¼—š—ðƒf[ƒ^ƒZƒbƒg
                        Dim strSQL As New StringBuilder
                        Dim csDataSchma As DataSet

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, Me.GetType.Name, System.Reflection.MethodBase.GetCurrentMethod.Name)

                            ' SQL•¶‚Ìì¬
                            ' SELECT‹å‚Ì¶¬
                            strSQL.Append(Me.CreateSelect)
                            ' FROM‹å‚Ì¶¬
                            strSQL.AppendFormat(" FROM {0} ", ABAtenaRirekiEntity.TABLE_NAME)

                            csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaRirekiEntity.TABLE_NAME, False)

                            ' WHERE‹å‚Ìì¬
                            ' SELECTƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfSelectUFParameterCollectionClass = New UFParameterCollectionClass

                            ' Z–¯ƒR[ƒh
                            strSQL.AppendFormat("WHERE {0} = {1}", ABAtenaRirekiEntity.JUMINCD, ABAtenaRirekiEntity.KEY_JUMINCD)
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_JUMINCD
                            cfUFParameterClass.Value = strJuminCD
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' —š—ð”Ô†
                            strSQL.AppendFormat(" AND {0} = {1}", ABAtenaRirekiEntity.RIREKINO, ABAtenaRirekiEntity.KEY_RIREKINO)
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.KEY_RIREKINO
                            cfUFParameterClass.Value = strRirekiNO
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)

                            'Z–¯Z“oŠO‹æ•ª
                            strSQL.AppendFormat(" AND {0} = '1'", ABAtenaRirekiEntity.JUMINJUTOGAIKB)
                            'íœƒtƒ‰ƒO
                            strSQL.AppendFormat(" AND {0} <> '1'", ABAtenaRirekiEntity.SAKUJOFG)

                            '' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                            'm_cfLogClass.RdbWrite(m_cfControlData,
                            '                                "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                            '                                "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                            '                                "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" +
                            '                                "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, m_cfSelectUFParameterCollectionClass) + "z")

                            csAtenaRirekiEntity = csDataSchma.Clone
                            csAtenaRirekiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, csAtenaRirekiEntity, ABAtenaRirekiEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, False)

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, Me.GetType.Name, System.Reflection.MethodBase.GetCurrentMethod.Name)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return csAtenaRirekiEntity

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     SELECT‹å‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateSelect() As String
                    '* 
                    '* ‹@”\@@    @ SELECT‹å‚ð¶¬‚·‚é
                    '* 
                    '* ˆø”           ‚È‚µ
                    '* 
                    '* –ß‚è’l         String    :   SELECT‹å
                    '************************************************************************************************
                    Private Function CreateSelect() As String
                        Const THIS_METHOD_NAME As String = "CreateSelect"
                        Dim csSELECT As New StringBuilder

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SELECT‹å‚Ìì¬
                            csSELECT.AppendFormat("SELECT {0}", ABAtenaRirekiEntity.JUMINCD)               ' Z–¯ƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SHICHOSONCD)                ' Žs’¬‘ºƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KYUSHICHOSONCD)             ' ‹ŒŽs’¬‘ºƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.RIREKINO)                   ' —š—ð”Ô†
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.RRKST_YMD)                  ' —š—ðŠJŽn”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.RRKED_YMD)                  ' —š—ðI—¹”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUMINJUTOGAIKB)             ' Z–¯Z“oŠO‹æ•ª
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUMINYUSENIKB)              ' Z–¯—Dæ‹æ•ª
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUTOGAIYUSENKB)             ' Z“oŠO—Dæ‹æ•ª
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.ATENADATAKB)                ' ˆ¶–¼ƒf[ƒ^‹æ•ª
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.STAICD)                     ' ¢‘ÑƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUMINHYOCD)                 ' Z–¯•[ƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SEIRINO)                    ' ®—”Ô†
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.ATENADATASHU)               ' ˆ¶–¼ƒf[ƒ^Ží•Ê
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.HANYOKB1)                   ' ”Ä—p‹æ•ª1
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KJNHJNKB)                   ' ŒÂl–@l‹æ•ª
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.HANYOKB2)                   ' ”Ä—p‹æ•ª2
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KANNAIKANGAIKB)             ' ŠÇ“àŠÇŠO‹æ•ª
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KANAMEISHO1)                ' ƒJƒi–¼Ì1
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KANJIMEISHO1)               ' Š¿Žš–¼Ì1
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KANAMEISHO2)                ' ƒJƒi–¼Ì2
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KANJIMEISHO2)               ' Š¿Žš–¼Ì2
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KANJIHJNKEITAI)             ' Š¿Žš–@lŒ`‘Ô
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KANJIHJNDAIHYOSHSHIMEI)     ' Š¿Žš–@l‘ã•\ŽÒŽ–¼
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SEARCHKANJIMEISHO)          ' ŒŸõ—pŠ¿Žš–¼Ì
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KYUSEI)                     ' ‹Œ©
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SEARCHKANASEIMEI)           ' ŒŸõ—pƒJƒi©–¼
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SEARCHKANASEI)              ' ŒŸõ—pƒJƒi©
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SEARCHKANAMEI)              ' ŒŸõ—pƒJƒi–¼
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKIRRKNO)                  ' ZŠî—š—ð”Ô†
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.UMAREYMD)                   ' ¶”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.UMAREWMD)                   ' ¶˜a—ï”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SEIBETSUCD)                 ' «•ÊƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SEIBETSU)                   ' «•Ê
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SEKINO)                     ' Ð”Ô†
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUMINHYOHYOJIJUN)           ' Z–¯•[•\Ž¦‡
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.ZOKUGARACD)                 ' ‘±•¿ƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.ZOKUGARA)                   ' ‘±•¿
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.DAI2JUMINHYOHYOJIJUN)       ' ‘æ2Z–¯•[•\Ž¦‡
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.DAI2ZOKUGARACD)             ' ‘æ2‘±•¿ƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.DAI2ZOKUGARA)               ' ‘æ2‘±•¿
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.STAINUSJUMINCD)             ' ¢‘ÑŽåZ–¯ƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.STAINUSMEI)                 ' ¢‘ÑŽå–¼
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KANASTAINUSMEI)             ' ƒJƒi¢‘ÑŽå–¼
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.DAI2STAINUSJUMINCD)         ' ‘æ2¢‘ÑŽåZ–¯ƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.DAI2STAINUSMEI)             ' ‘æ2¢‘ÑŽå–¼
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KANADAI2STAINUSMEI)         ' ƒJƒi‘æ2¢‘ÑŽå–¼
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.YUBINNO)                    ' —X•Ö”Ô†
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUSHOCD)                    ' ZŠƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUSHO)                      ' ZŠ
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.BANCHICD1)                  ' ”Ô’nƒR[ƒh1
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.BANCHICD2)                  ' ”Ô’nƒR[ƒh2
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.BANCHICD3)                  ' ”Ô’nƒR[ƒh3
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.BANCHI)                     ' ”Ô’n
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KATAGAKIFG)                 ' •û‘ƒtƒ‰ƒO
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KATAGAKICD)                 ' •û‘ƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KATAGAKI)                   ' •û‘
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.RENRAKUSAKI1)               ' ˜A—æ1
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.RENRAKUSAKI2)               ' ˜A—æ2
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.HON_ZJUSHOCD)               ' –{Ð‘S‘ZŠƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.HON_JUSHO)                  ' –{ÐZŠ
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.HONSEKIBANCHI)              ' –{Ð”Ô’n
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.HITTOSH)                    ' •M“ªŽÒ
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.CKINIDOYMD)                 ' ’¼‹ßˆÙ“®”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.CKINJIYUCD)                 ' ’¼‹ßŽ–—RƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.CKINJIYU)                   ' ’¼‹ßŽ–—R
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.CKINTDKDYMD)                ' ’¼‹ß“Ío”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.CKINTDKDTUCIKB)             ' ’¼‹ß“Ío’Ê’m‹æ•ª
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TOROKUIDOYMD)               ' “o˜^ˆÙ“®”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TOROKUIDOWMD)               ' “o˜^ˆÙ“®˜a—ï”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TOROKUJIYUCD)               ' “o˜^Ž–—RƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TOROKUJIYU)                 ' “o˜^Ž–—R
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TOROKUTDKDYMD)              ' “o˜^“Ío”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TOROKUTDKDWMD)              ' “o˜^“Ío˜a—ï”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TOROKUTDKDTUCIKB)           ' “o˜^“Ío’Ê’m‹æ•ª
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUTEIIDOYMD)                ' Z’èˆÙ“®”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUTEIIDOWMD)                ' Z’èˆÙ“®˜a—ï”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUTEIJIYUCD)                ' Z’èŽ–—RƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUTEIJIYU)                  ' Z’èŽ–—R
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUTEITDKDYMD)               ' Z’è“Ío”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUTEITDKDWMD)               ' Z’è“Ío˜a—ï”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUTEITDKDTUCIKB)            ' Z’è“Ío’Ê’m‹æ•ª
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SHOJOIDOYMD)                ' ÁœˆÙ“®”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SHOJOJIYUCD)                ' ÁœŽ–—RƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SHOJOJIYU)                  ' ÁœŽ–—R
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SHOJOTDKDYMD)               ' Áœ“Ío”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SHOJOTDKDTUCIKB)            ' Áœ“Ío’Ê’m‹æ•ª
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUYOTEIIDOYMD)       ' “]o—\’èˆÙ“®”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUKKTIIDOYMD)        ' “]oŠm’èˆÙ“®”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUKKTITSUCHIYMD)     ' “]oŠm’è’Ê’m”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUNYURIYUCD)         ' “]o“ü——RƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUNYURIYU)           ' “]o“ü——R
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENUMAEJ_YUBINNO)           ' “]“ü‘OZŠ—X•Ö”Ô†
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENUMAEJ_ZJUSHOCD)          ' “]“ü‘OZŠ‘S‘ZŠƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENUMAEJ_JUSHO)             ' “]“ü‘OZŠZŠ
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENUMAEJ_BANCHI)            ' “]“ü‘OZŠ”Ô’n
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENUMAEJ_KATAGAKI)          ' ‘OZŠ•û‘
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENUMAEJ_STAINUSMEI)        ' “]“ü‘OZŠ¢‘ÑŽå–¼
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUYOTEIYUBINNO)      ' “]o—\’è—X•Ö”Ô†
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUYOTEIZJUSHOCD)     ' “]o—\’è‘S‘ZŠƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUYOTEIJUSHO)        ' “]o—\’èZŠ
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUYOTEIBANCHI)       ' “]o—\’è”Ô’n
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUYOTEIKATAGAKI)     ' “]o—\’è•û‘
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUYOTEISTAINUSMEI)   ' “]o—\’è¢‘ÑŽå–¼
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUKKTIYUBINNO)       ' “]oŠm’è—X•Ö”Ô†
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUKKTIZJUSHOCD)      ' “]oŠm’è‘S‘ZŠƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUKKTIJUSHO)         ' “]oŠm’èZŠ
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUKKTIBANCHI)        ' “]oŠm’è”Ô’n
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUKKTIKATAGAKI)      ' “]oŠm’è•û‘
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUKKTISTAINUSMEI)    ' “]oŠm’è¢‘ÑŽå–¼
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TENSHUTSUKKTIMITDKFG)       ' “]oŠm’è–¢“Íƒtƒ‰ƒO
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.BIKOYMD)                    ' ”õl”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.BIKO)                       ' ”õl
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.BIKOTENSHUTSUKKTIJUSHOFG)   ' ”õl“]oŠm’èZŠƒtƒ‰ƒO
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.HANNO)                      ' ”Å”Ô†
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KAISEIATOFG)                ' ‰ü»Œãƒtƒ‰ƒO
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KAISEIMAEFG)                ' ‰ü»‘Oƒtƒ‰ƒO
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KAISEIYMD)                  ' ‰ü»”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.GYOSEIKUCD)                 ' s­‹æƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.GYOSEIKUMEI)                ' s­‹æ–¼
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.CHIKUCD1)                   ' ’n‹æƒR[ƒh1
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.CHIKUMEI1)                  ' ’n‹æ–¼1
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.CHIKUCD2)                   ' ’n‹æƒR[ƒh2
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.CHIKUMEI2)                  ' ’n‹æ–¼2
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.CHIKUCD3)                   ' ’n‹æƒR[ƒh3
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.CHIKUMEI3)                  ' ’n‹æ–¼3
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TOHYOKUCD)                  ' “Š•[‹æƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SHOGAKKOKUCD)               ' ¬ŠwZ‹æƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.CHUGAKKOKUCD)               ' ’†ŠwZ‹æƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.HOGOSHAJUMINCD)             ' •ÛŒìŽÒZ–¯ƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KANJIHOGOSHAMEI)            ' Š¿Žš•ÛŒìŽÒ–¼
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KANAHOGOSHAMEI)             ' ƒJƒi•ÛŒìŽÒ–¼
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KIKAYMD)                    ' ‹A‰»”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KARIIDOKB)                  ' ‰¼ˆÙ“®‹æ•ª
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SHORITEISHIKB)              ' ˆ—’âŽ~‹æ•ª
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKIYUBINNO)                ' ZŠî—X•Ö”Ô†
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SHORIYOKUSHIKB)             ' ˆ——}Ž~‹æ•ª
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKIJUSHOCD)                ' ZŠîZŠƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKIJUSHO)                  ' ZŠîZŠ
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKIBANCHICD1)              ' ZŠî”Ô’nƒR[ƒh1
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKIBANCHICD2)              ' ZŠî”Ô’nƒR[ƒh2
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKIBANCHICD3)              ' ZŠî”Ô’nƒR[ƒh3
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKIBANCHI)                 ' ZŠî”Ô’n
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKIKATAGAKIFG)             ' ZŠî•û‘ƒtƒ‰ƒO
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKIKATAGAKICD)             ' ZŠî•û‘ƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKIKATAGAKI)               ' ZŠî•û‘
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKIGYOSEIKUCD)             ' ZŠîs­‹æƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKIGYOSEIKUMEI)            ' ZŠîs­‹æ–¼
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKICHIKUCD1)               ' ZŠî’n‹æƒR[ƒh1
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKICHIKUMEI1)              ' ZŠî’n‹æ–¼1
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKICHIKUCD2)               ' ZŠî’n‹æƒR[ƒh2
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKICHIKUMEI2)              ' ZŠî’n‹æ–¼2
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKICHIKUCD3)               ' ZŠî’n‹æƒR[ƒh3
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.JUKICHIKUMEI3)              ' ZŠî’n‹æ–¼3
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KAOKUSHIKIKB)               ' ‰Æ‰®•~‹æ•ª
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.BIKOZEIMOKU)                ' ”õlÅ–Ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KOKUSEKICD)                 ' ‘ÐƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KOKUSEKI)                   ' ‘Ð
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.ZAIRYUSKAKCD)               ' Ý—¯Ž‘ŠiƒR[ƒh
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.ZAIRYUSKAK)                 ' Ý—¯Ž‘Ši
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.ZAIRYUKIKAN)                ' Ý—¯ŠúŠÔ
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.ZAIRYU_ST_YMD)              ' Ý—¯ŠJŽn”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.ZAIRYU_ED_YMD)              ' Ý—¯I—¹”NŒŽ“ú
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.RESERCE)                    ' ƒŠƒU[ƒu
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.TANMATSUID)                 ' ’[––ID
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SAKUJOFG)                   ' íœƒtƒ‰ƒO
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KOSHINCOUNTER)              ' XVƒJƒEƒ“ƒ^
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SAKUSEINICHIJI)             ' ì¬“úŽž
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.SAKUSEIUSER)                ' ì¬ƒ†[ƒU
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KOSHINNICHIJI)              ' XV“úŽž
                            csSELECT.AppendFormat(", {0}", ABAtenaRirekiEntity.KOSHINUSER)                 ' XVƒ†[ƒU
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return csSELECT.ToString

                    End Function
                #End Region
                End Class

                 */
            }

            return default;
        }
    }
}