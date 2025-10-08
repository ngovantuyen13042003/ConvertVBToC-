// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‚`‚aˆ¶–¼ƒ}ƒXƒ^‚c‚`(ABAtenaBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2002/12/20@‘ê‘ò@‹Ô–ç
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/02/24 000001     ¶”NŒŽ“ú‚Ì‚ ‚¢‚Ü‚¢ŒŸõˆ—‚ÌƒoƒO
// * 2003/02/25 000002     ƒf[ƒ^‹æ•ª‚ª‚ ‚éŽž‚àAƒf[ƒ^Ží•Ê‚ª“ü‚Á‚Ä‚¢‚éê‡‚ÍAƒf[ƒ^Ží•Ê‚àŒŸõ‚Æ‚·‚é
// *                       ZŠî—Dæ‚Å¢‘ÑƒR[ƒh‚ªAŽw’è‚³‚ê‚Ä‚¢‚éê‡‚ÉZ–¯•[•\Ž¦‡‚ðƒ\[ƒgƒL[‚É‚·‚é
// * 2003/03/10 000003     ZŠ‚b‚c“™‚Ì®‡«ƒ`ƒFƒbƒN‚ÉŒë‚è
// * 2003/03/27 000004     ƒGƒ‰[ˆ—ƒNƒ‰ƒX‚ÌŽQÆæ‚ð"AB"ŒÅ’è‚É‚·‚é
// * 2003/03/31 000005     ®‡«ƒ`ƒFƒbƒN‚ðTrim‚µ‚½’l‚Åƒ`ƒFƒbƒN‚·‚é
// * 2003/04/16 000006     ¶˜a—ï”NŒŽ“ú‚Ì“ú•tƒ`ƒFƒbƒN‚ð”’lƒ`ƒFƒbƒN‚É•ÏX
// *                       ŒŸõ—pƒJƒi‚Ì”¼ŠpƒJƒiƒ`ƒFƒbƒN‚ð‚`‚m‚jƒ`ƒFƒbƒN‚É•ÏX
// * 2003/05/20 000007     ƒGƒ‰[A“ú•tƒNƒ‰ƒX‚Ì²Ý½ÀÝ½‚ðºÝ½Ä×¸À‚É•ÏX
// * 2003/06/12 000008     TOP‹å‚ðŠO‚·
// * 2003/08/28 000009     RDBƒAƒNƒZƒXƒƒO‚ÌC³
// * 2003/09/11 000010     ’[––‚h‚c®‡«ƒ`ƒFƒbƒN‚ðANK‚É‚·‚é
// * 2003/10/09 000011     ì¬ƒ†[ƒU[EXVƒ†[ƒU[ƒ`ƒFƒbƒN‚Ì•ÏX
// * 2003/10/30 000012     Žd—l•ÏXFƒJƒ^ƒJƒiƒ`ƒFƒbƒN‚ðANKƒ`ƒFƒbƒN‚É•ÏX
// * 2003/11/18 000013     Žd—l•ÏXFƒf[ƒ^‹æ•ª‚ÅŒÂl‚Ì‚ÝŽ‚Á‚Ä‚­‚éBiƒf[ƒ^‹æ•ª‚É"1%"‚ÆŽw’è‚³‚ê‚½ê‡j
// *                       Žd—l’Ç‰ÁFˆ¶–¼ŒÂ•Êƒf[ƒ^Žæ“¾ƒƒ\ƒbƒh‚ð’Ç‰Á
// * 2004/08/27 000014     ‘¬“x‰ü‘PFi‹{‘òj
// * 2004/10/19 000015     `‘S‘ZŠƒR[ƒh‚Ìƒ`ƒFƒbƒN‚ðCheckNumber --> CheckANK(ƒ}ƒ‹ƒS‘ºŽR)
// * 2004/11/12 000016     ƒf[ƒ^ƒ`ƒFƒbƒN‚ðs‚È‚í‚È‚¢
// * 2005/01/25 000017     ‘¬“x‰ü‘P‚QFi‹{‘òj
// * 2005/05/23 000018     SQL•¶‚ðInsert,Update,˜_—Delete,•¨—Delete‚ÌŠeƒƒ\ƒbƒh‚ªŒÄ‚Î‚ê‚½Žž‚ÉŠeŽ©ì¬‚·‚é(ƒ}ƒ‹ƒS‘ºŽR)
// * 2005/07/11 000019     CreateWhereÒ¿¯ÄÞ‚ÅZŠCD‚ÌWhere•¶ì¬Žž‚ÉZŠCD‚©‘S‘ZŠCD‚©‚Ì”»’è‚ð“ü‚ê‚é(ƒ}ƒ‹ƒS‘ºŽR)
// * 2005/12/26 000020     Žd—l•ÏXFs­‹æ‚b‚c‚ðANKƒ`ƒFƒbƒN‚É•ÏX(ƒ}ƒ‹ƒS‘ºŽR)
// * 2006/07/31 000021     ”N‹àˆ¶–¼ƒQƒbƒg‡U€–Ú’Ç‰Á(‹gàV)
// * 2007/04/28 000022     ‰îŒì”Åˆ¶–¼Žæ“¾ƒƒ\ƒbƒh‚Ì’Ç‰Á‚É‚æ‚éŽæ“¾€–Ú‚Ì’Ç‰Á (‹gàV)
// * 2007/09/03 000023     ŠO‘l–{–¼—DæŒŸõ—p‚ÉŠ¿Žš–¼Ì‚Q‚ð’Ç‰Ái’†‘òj
// * 2007/10/10 000024     ŠO‘l–{–¼—DæŒŸõ‹@”\FƒJƒi–¼‚Ìæ“ª‚ª"³"‚Ì‚Æ‚«‚Í"µ"‚ÆORðŒ‚ÅŒŸõ‚·‚éi’†‘òj
// * 2008/01/15 000025     ŒÂ•ÊŽ–€ƒf[ƒ^Žæ“¾‹@”\‚ÉŒãŠú‚—îŽæ“¾ˆ—‚ð’Ç‰Ái”ä‰Ãj•ƒl[ƒ~ƒ“ƒO•ÏXi‹gàVj
// * 2010/04/16 000026     VS2008‘Î‰ži”ä‰Ãj
// * 2010/05/12 000027     –{Ð•M“ªŽÒ‹y‚Ñˆ—’âŽ~‹æ•ª‘Î‰ži”ä‰Ãj
// * 2011/05/18 000028     ŠO‘lÝ—¯î•ñŽæ“¾‹æ•ª‘Î‰ži”ä‰Ãj
// * 2011/10/24 000029     yAB17010zƒZŠî–@‰ü³‘Î‰ž„ˆ¶–¼•tƒ}ƒXƒ^’Ç‰Á   (¬¼)
// * 2014/04/28 000030     yAB21040zƒ‹¤’Ê”Ô†‘Î‰ž„‹¤’Ê”Ô†ƒ}ƒXƒ^’Ç‰ÁiÎ‡j
// * 2018/03/08 000031     yAB26001z—š—ðŒŸõ‹@”\’Ç‰ÁiÎ‡j
// * 2020/01/10 000032     yAB32001zƒAƒ‹ƒtƒ@ƒxƒbƒgŒŸõiÎ‡j
// * 2023/03/10 000033     yAB-0970-1zˆ¶–¼GETŽæ“¾€–Ú•W€‰»‘Î‰ži’‡¼j
// * 2023/08/14 000034     yAB-0820-1zZ“oŠOŠÇ—€–Ú’Ç‰Á(‘è)
// * 2023/10/19 000035     yAB-0820-1zZ“oŠOŠÇ—€–Ú’Ç‰Á_’Ç‰ÁC³(’‡¼)
// * 2023/12/04 000036     yAB-1600-1zŒŸõ‹@”\‘Î‰ž(‰º‘º)
// * 2023/12/11 000037     yAB-9000-1zZŠîXV˜AŒg•W€‰»‘Î‰ž(‰º‘º)
// * 2024/03/07 000038     yAB-0900-1zƒAƒhƒŒƒXEƒx[ƒXEƒŒƒWƒXƒgƒŠ‘Î‰ž(‰º‘º)
// * 2024/06/06 000039     yAB-9901-1z•s‹ï‡‘Î‰ž
// ************************************************************************************************
using System;
using System.Data;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Densan.Reams.AB.AB000BB
{
    // *—š—ð”Ô† 000034 2023/08/14 ’Ç‰ÁI—¹

    // ************************************************************************************************
    // *
    // * ˆ¶–¼ƒ}ƒXƒ^Žæ“¾Žž‚ÉŽg—p‚·‚éƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
    // *
    // ************************************************************************************************
    public class ABAtenaBClass
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
        private UFParameterCollectionClass m_cfSelectUFParameterCollectionClass;      // SELECT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;      // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateUFParameterCollectionClass;      // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDelRonriUFParameterCollectionClass;    // ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDelButuriUFParameterCollectionClass;   // •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“

        // * —š—ð”Ô† 000014 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
        // * —š—ð”Ô† 000017 2005/01/25 •ÏXŠJŽni‹{‘òj
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
                                                        // * —š—ð”Ô† 000017 2005/01/25 •ÏXI—¹
                                                        // * —š—ð”Ô† 000014 2004/08/27 ’Ç‰ÁI—¹

        // * —š—ð”Ô† 000017 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
        private StringBuilder m_strAtenaSQLsbAll = new StringBuilder();
        private StringBuilder m_strAtenaSQLsbKaniAll = new StringBuilder();
        private StringBuilder m_strAtenaSQLsbKaniOnly = new StringBuilder();
        private StringBuilder m_strAtenaSQLsbNenkinAll = new StringBuilder();
        private StringBuilder m_strKobetuSQLsbAll = new StringBuilder();
        private StringBuilder m_strKobetuSQLsbKaniAll = new StringBuilder();
        private StringBuilder m_strKobetuSQLsbKaniOnly = new StringBuilder();
        private StringBuilder m_strKobetuSQLsbNenkinAll = new StringBuilder();
        public ABEnumDefine.AtenaGetKB m_blnSelectAll = ABEnumDefine.AtenaGetKB.SelectAll; // ‘S€–Ú‘I‘ðim_blnAtenaGet‚ªTrue‚ÌŽžˆ¶–¼Get‚Å•K—v‚È€–Ú‘S‚Ä‚»‚êˆÈŠO‚ÍSELECT *j
        public bool m_blnSelectCount = false;            // ƒJƒEƒ“ƒg‚ðŽæ“¾‚·‚é‚©‚Ç‚¤‚©
        public bool m_blnBatch = false;               // ƒoƒbƒ`ƒtƒ‰ƒO
                                                      // * —š—ð”Ô† 000017 2005/01/25 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000022 2007/04/28 ’Ç‰ÁŠJŽn
        public ABEnumDefine.MethodKB m_blnMethodKB;  // ƒƒ\ƒbƒh‹æ•ªi’Êí”Å‚©A‰îŒì”ÅAAAj
                                                     // *—š—ð”Ô† 000022 2007/04/28 ’Ç‰ÁI—¹
                                                     // *—š—ð”Ô† 000025 2008/01/15 ’Ç‰ÁŠJŽn
        public string m_strKobetsuShutokuKB;                  // ŒÂ•ÊŽ–€Žæ“¾‹æ•ª
                                                              // *—š—ð”Ô† 000025 2008/01/15 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000027 2010/05/12 ’Ç‰ÁŠJŽn
        private string m_strHonsekiKB = string.Empty;                 // ˆ¶–¼ŠÇ—î•ñ:–{ÐŽæ“¾
        private string m_strShoriteishiKB = string.Empty;             // ˆ¶–¼ŠÇ—î•ñ:ˆ—’âŽ~‹æ•ªŽæ“¾
        private string m_strHonsekiHittoshKB_Param = string.Empty;    // –{Ð•M“ªŽÒŽæ“¾‹æ•ªƒpƒ‰ƒ[ƒ^
        private string m_strShoriteishiKB_Param = string.Empty;       // ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ªƒpƒ‰ƒ[ƒ^
                                                                      // *—š—ð”Ô† 000027 2010/05/12 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000028 2011/05/18 ’Ç‰ÁŠJŽn
        private string m_strFrnZairyuJohoKB_Param = string.Empty;     // ŠO‘lÝ—¯î•ñŽæ“¾‹æ•ªƒpƒ‰ƒ[ƒ^
                                                                      // *—š—ð”Ô† 000028 2011/05/18 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
        private ABSekoYMDHanteiBClass m_csSekoYMDHanteiB;             // Ž{s“ú”»’èB¸×½
        private ABAtenaFZYBClass m_csAtenaFZYB;                       // ˆ¶–¼•tƒ}ƒXƒ^B¸×½
        private bool m_blnJukihoKaiseiFG = false;
        private string m_strJukihoKaiseiKB;                           // ZŠî–@‰ü³‹æ•ª
                                                                      // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
        private string m_strMyNumberKB_Param;                         // ‹¤’Ê”Ô†Žæ“¾‹æ•ª
        private string m_strMyNumberChokkinSearchKB_Param;            // ‹¤’Ê”Ô†’¼‹ßŒŸõ‹æ•ª
                                                                      // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000032 2020/01/10 ’Ç‰ÁŠJŽn
        private ABKensakuShimeiBClass m_cKensakuShimeiB;              // ŒŸõŽ–¼•ÒWƒrƒWƒlƒXƒNƒ‰ƒX
                                                                      // *—š—ð”Ô† 000032 2020/01/10 ’Ç‰ÁI—¹

        public ABEnumDefine.HyojunKB m_intHyojunKB;                   // ˆ¶–¼GET•W€‰»‹æ•ª

        // *—š—ð”Ô† 000034 2023/08/14 ’Ç‰ÁŠJŽn
        private ABAtena_HyojunBClass m_csAtenaHyojunB;                // ˆ¶–¼_•W€ƒ}ƒXƒ^B¸×½
        private ABAtenaFZY_HyojunBClass m_csAtenaFZYHyojunB;          // ˆ¶–¼•t_•W€ƒ}ƒXƒ^B¸×½
                                                                      // *—š—ð”Ô† 000034 2023/08/14 ’Ç‰ÁI—¹

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABAtenaBClass";                       // ƒNƒ‰ƒX–¼
        private const string THIS_BUSINESSID = "AB";                                  // ‹Æ–±ƒR[ƒh

        private const string JUKIHOKAISEIKB_ON = "1";

        #endregion

        // *—š—ð”Ô† 000027 2010/05/12 ’Ç‰ÁŠJŽn
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
                m_strShoriteishiKB_Param = value;
            }
        }

        // *—š—ð”Ô† 000028 2011/05/18 ’Ç‰ÁŠJŽn
        public string p_strFrnZairyuJohoKB      // ŠO‘lÝ—¯î•ñŽæ“¾‹æ•ª
        {
            set
            {
                m_strFrnZairyuJohoKB_Param = value;
            }
        }
        // *—š—ð”Ô† 000028 2011/05/18 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
        public string p_strJukihoKaiseiKB      // ZŠî–@‰ü³‹æ•ª
        {
            set
            {
                m_strJukihoKaiseiKB = value;
            }
        }
        // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
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
        // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

        #endregion
        // *—š—ð”Ô† 000027 2010/05/12 ’Ç‰ÁI—¹

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
        public ABAtenaBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)
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
            m_cfSelectUFParameterCollectionClass = (object)null;
            m_cfInsertUFParameterCollectionClass = (object)null;
            m_cfUpdateUFParameterCollectionClass = (object)null;
            m_cfDelRonriUFParameterCollectionClass = (object)null;
            m_cfDelButuriUFParameterCollectionClass = (object)null;

            // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
            // ZŠî–@‰ü³‹æ•ª‰Šú‰»
            m_strJukihoKaiseiKB = string.Empty;
            // ZŠî–@‰ü³Ì×¸ÞŽæ“¾
            GetJukihoKaiseiFG();
            // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

            // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
            // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‰Šú‰»
            m_strMyNumberKB_Param = string.Empty;
            // ‹¤’Ê”Ô†@ˆ¶–¼Žæ“¾@’¼‹ßŒŸõ‹æ•ªŽæ“¾
            this.GetMyNumberChokkinSearchKB();
            // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

            // *—š—ð”Ô† 000032 2020/01/10 ’Ç‰ÁŠJŽn
            // ŒŸõŽ–¼•ÒWƒrƒWƒlƒXƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cKensakuShimeiB = new ABKensakuShimeiBClass(m_cfControlData, m_cfConfigDataClass);
            // *—š—ð”Ô† 000032 2020/01/10 ’Ç‰ÁI—¹

        }
        // * —š—ð”Ô† 000017 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
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
        public ABAtenaBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass, ABEnumDefine.AtenaGetKB blnSelectAll, bool blnSelectCount)
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
            m_cfSelectUFParameterCollectionClass = (object)null;
            m_cfInsertUFParameterCollectionClass = (object)null;
            m_cfUpdateUFParameterCollectionClass = (object)null;
            m_cfDelRonriUFParameterCollectionClass = (object)null;
            m_cfDelButuriUFParameterCollectionClass = (object)null;

            m_blnSelectAll = blnSelectAll;
            m_blnSelectCount = blnSelectCount;

            // *—š—ð”Ô† 000027 2010/05/12 ’Ç‰ÁŠJŽn
            // ŠÇ—î•ñŽæ“¾ˆ—
            GetKanriJoho();
            // *—š—ð”Ô† 000027 2010/05/12 ’Ç‰ÁI—¹

            // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
            // ZŠî–@‰ü³‹æ•ª‰Šú‰»
            m_strJukihoKaiseiKB = string.Empty;
            // ZŠî–@‰ü³Ì×¸ÞŽæ“¾
            GetJukihoKaiseiFG();
            // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

            // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
            // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‰Šú‰»
            m_strMyNumberKB_Param = string.Empty;
            // ‹¤’Ê”Ô†@ˆ¶–¼Žæ“¾@’¼‹ßŒŸõ‹æ•ªŽæ“¾
            this.GetMyNumberChokkinSearchKB();
            // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

            // *—š—ð”Ô† 000032 2020/01/10 ’Ç‰ÁŠJŽn
            // ŒŸõŽ–¼•ÒWƒrƒWƒlƒXƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cKensakuShimeiB = new ABKensakuShimeiBClass(m_cfControlData, m_cfConfigDataClass);
            // *—š—ð”Ô† 000032 2020/01/10 ’Ç‰ÁI—¹

        }
        // * —š—ð”Ô† 000017 2005/01/25 ’Ç‰ÁI—¹
        #endregion

        #region ƒƒ\ƒbƒh
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetAtenaBHoshu(ByVal intGetCount As Integer, _
        // *                                               ByVal cSearchKey As ABAtenaSearchKey) As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼ƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           intGetCount   : Žæ“¾Œ”
        // *                cSearchKey    : ˆ¶–¼ƒ}ƒXƒ^ŒŸõƒL[
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½ˆ¶–¼ƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetAtenaBHoshu(int intGetCount, ABAtenaSearchKey cSearchKey)
        {

            return GetAtenaBHoshu(intGetCount, cSearchKey, false);

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetAtenaBHoshu(ByVal intGetCount As Integer, 
        // *                                               ByVal cSearchKey As ABAtenaSearchKey, 
        // *                                               ByVal blnSakujoFG As Boolean) As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼ƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           intGetCount   : Žæ“¾Œ”
        // *                cSearchKey    : ˆ¶–¼ƒ}ƒXƒ^ŒŸõƒL[
        // *                blnSakujoFG   : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½ˆ¶–¼ƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetAtenaBHoshu(int intGetCount, ABAtenaSearchKey cSearchKey, bool blnSakujoFG)
        {

            const string THIS_METHOD_NAME = "GetAtenaBHoshu";
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            DataSet csAtenaEntity;
            // * corresponds to VS2008 Start 2010/04/16 000026
            // Dim csDataTable As DataTable
            // * corresponds to VS2008 End 2010/04/16 000026
            // * —š—ð”Ô† 000017 2005/01/25 XVŠJŽni‹{‘òj
            // Dim strSQL As String
            var strSQL = new StringBuilder();
            string strSQLExec;
            // * —š—ð”Ô† 000017 2005/01/25 XVI—¹

            StringBuilder strWHERE;
            // * —š—ð”Ô† 000017 2005/01/25 XVŠJŽni‹{‘òj
            // Dim strORDER As String
            var strORDER = new StringBuilder();
            // * —š—ð”Ô† 000017 2005/01/25 XVI—¹

            int intMaxRows;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
                if (intGetCount < 0 | intGetCount > 999)    // Žæ“¾Œ”‚ÌŒë‚è
                {
                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_PARA_GETCOUNT);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                }

                // ˆ¶–¼ŒŸõƒL[‚Ìƒ`ƒFƒbƒN
                // ‚È‚µ

                // SQL•¶‚Ìì¬
                // * —š—ð”Ô† 000008 2003/06/12 C³ŠJŽn
                // If intGetCount = 0 Then
                // strSQL = "SELECT TOP 100 * FROM " + ABAtenaEntity.TABLE_NAME
                // Else
                // strSQL = "SELECT TOP " + intGetCount.ToString + " * FROM " + ABAtenaEntity.TABLE_NAME
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
                // * —š—ð”Ô† 000017 2005/01/25 XVŠJŽni‹{‘òj
                // strSQL = "SELECT * FROM " + ABAtenaEntity.TABLE_NAME
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

                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYEntity(m_strAtenaSQLsbKaniAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strAtenaSQLsbKaniAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                                m_strAtenaSQLsbKaniAll.Append(ABAtenaEntity.TABLE_NAME);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strAtenaSQLsbKaniAll);

                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYJoin(m_strAtenaSQLsbKaniAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strAtenaSQLsbKaniAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                                m_csDataSchmaKaniAll = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaEntity.TABLE_NAME, false);
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

                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYEntity(m_strAtenaSQLsbKaniOnly);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strAtenaSQLsbKaniOnly);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                                m_strAtenaSQLsbKaniOnly.Append(ABAtenaEntity.TABLE_NAME);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strAtenaSQLsbKaniOnly);

                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYJoin(m_strAtenaSQLsbKaniOnly);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strAtenaSQLsbKaniOnly);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                                m_csDataSchmaKaniOnly = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaEntity.TABLE_NAME, false);
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

                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYEntity(m_strAtenaSQLsbNenkinAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strAtenaSQLsbNenkinAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                                m_strAtenaSQLsbNenkinAll.Append(ABAtenaEntity.TABLE_NAME);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strAtenaSQLsbNenkinAll);

                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYJoin(m_strAtenaSQLsbNenkinAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strAtenaSQLsbNenkinAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                                m_csDataSchmaNenkinAll = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaEntity.TABLE_NAME, false);
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
                                m_strAtenaSQLsbAll.Append(ABAtenaEntity.TABLE_NAME).Append(".*");

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaCountEntity(m_strAtenaSQLsbAll);

                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYEntity(m_strAtenaSQLsbAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strAtenaSQLsbAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                                m_strAtenaSQLsbAll.Append(ABAtenaEntity.TABLE_NAME);

                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strAtenaSQLsbAll);

                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYJoin(m_strAtenaSQLsbAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strAtenaSQLsbAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                                m_csDataSchmaAll = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaEntity.TABLE_NAME, false);
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
                // m_strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".*")
                // Case ABEnumDefine.AtenaGetKB.KaniAll
                // Call SetAtenaEntity(m_strAtenaSQLsb)
                // Case ABEnumDefine.AtenaGetKB.KaniOnly
                // Call SetAtenaEntity(m_strAtenaSQLsb)
                // Case Else
                // 'Œ»s
                // m_strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".*")
                // End Select

                // '‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                // Call SetAtenaCountEntity(m_strAtenaSQLsb)

                // m_strAtenaSQLsb.Append(" FROM ")
                // m_strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME)

                // '‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                // Call SetAtenaJoin(m_strAtenaSQLsb)
                // End If
                // strSQL.Append(m_strAtenaSQLsb)
                // * —š—ð”Ô† 000017 2005/01/25 XVI—¹

                // * —š—ð”Ô† 000008 2003/06/12 C³I—¹

                // * —š—ð”Ô† 000014 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
                // If (m_csDataSchma Is Nothing) Then
                // m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaEntity.TABLE_NAME, False)
                // End If
                // * —š—ð”Ô† 000014 2004/08/27 ’Ç‰ÁI—¹
                // WHERE‹å‚Ìì¬
                // *—š—ð”Ô† 000031 2018/03/08 C³ŠJŽn
                // strWHERE = New StringBuilder(Me.CreateWhere(cSearchKey))

                // ' íœƒtƒ‰ƒO
                // If blnSakujoFG = False Then
                // If Not (strWHERE.Length = 0) Then
                // strWHERE.Append(" AND ")
                // End If
                // strWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SAKUJOFG)
                // strWHERE.Append(" <> '1'")
                // End If
                strWHERE = new StringBuilder(CreateWhereMain(cSearchKey, blnSakujoFG));
                // *—š—ð”Ô† 000031 2018/03/08 C³I—¹

                // ORDER‹å‚ðŒ‹‡

                // Z–¯—Dæ‹æ•ª‚ªh1h‚Å‚©‚Â¢‘ÑƒR[ƒh‚ªŽw’èÏ‚Ìê‡FZ–¯•[•\Ž¦‡
                // * —š—ð”Ô† 000017 2005/01/25 XVŠJŽni‹{‘òj
                // If ((cSearchKey.p_strJuminYuseniKB = "1") And (cSearchKey.p_strStaiCD.Trim <> String.Empty)) Then
                // strORDER = " ORDER BY " + ABAtenaEntity.TABLE_NAME + "." + ABAtenaEntity.JUMINHYOHYOJIJUN + " ASC,"
                // strORDER += ABAtenaEntity.JUMINCD + " ASC;"
                // ElseIf Not (cSearchKey.p_strUmareYMD.Trim = String.Empty) Then
                // strORDER = " ORDER BY " + ABAtenaEntity.TABLE_NAME + "." + ABAtenaEntity.UMAREYMD + " ASC,"
                // strORDER += ABAtenaEntity.TABLE_NAME + "." + ABAtenaEntity.JUMINCD + " ASC;"
                // Else
                // strORDER = " ORDER BY " + ABAtenaEntity.TABLE_NAME + "." + ABAtenaEntity.SEARCHKANASEIMEI + " ASC,"
                // strORDER += ABAtenaEntity.TABLE_NAME + "." + ABAtenaEntity.JUMINCD + " ASC;"
                // End If
                // If strWHERE.Length = 0 Then
                // strSQL += strORDER
                // Else
                // strSQL += " WHERE " + strWHERE.ToString + strORDER
                // End If
                if (cSearchKey.p_strJuminYuseniKB == "1" & cSearchKey.p_strStaiCD.Trim != string.Empty)
                {
                    strORDER.Append(" ORDER BY ").Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINHYOHYOJIJUN).Append(" ASC,");
                    strORDER.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD).Append(" ASC;");
                }
                else if (!(cSearchKey.p_strUmareYMD.Trim == string.Empty))
                {
                    strORDER.Append(" ORDER BY ").Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.UMAREYMD).Append(" ASC,");
                    strORDER.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD).Append(" ASC;");
                }
                else
                {
                    strORDER.Append(" ORDER BY ").Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEARCHKANASEIMEI).Append(" ASC,");
                    strORDER.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD).Append(" ASC;");
                }

                if (strWHERE.RLength == 0)
                {
                    strSQL.Append(strORDER);
                }
                else
                {
                    strSQL.Append(" WHERE ").Append(strWHERE).Append(strORDER);
                }
                strSQLExec = strSQL.ToString();
                // * —š—ð”Ô† 000017 2005/01/25 XVI—¹

                // *—š—ð”Ô† 000009 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + strSQL + "z")

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // '* —š—ð”Ô† 000017 2005/01/25 XVŠJŽni‹{‘òjIf •¶‚ÅˆÍ‚Þ
                // If (m_blnBatch = False) Then
                // m_cfLogClass.RdbWrite(m_cfControlData,
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" +
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQLExec, m_cfSelectUFParameterCollectionClass) + "z")
                // End If
                // * —š—ð”Ô† 000017 2005/01/25 XVI—¹i‹{‘òjIf •¶‚ÅˆÍ‚Þ
                // *—š—ð”Ô† 000009 2003/08/28 C³I—¹

                // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                // * —š—ð”Ô† 000014 2004/08/27 •ÏXŠJŽni‹{‘òj
                // csAtenaEntity = m_cfRdbClass.GetDataSet(strSQL, ABAtenaEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass)
                csAtenaEntity = m_csDataSchma.Clone();
                // m_csDataSchma.Clear()
                // csAtenaEntity = m_csDataSchma
                csAtenaEntity = m_cfRdbClass.GetDataSet(strSQLExec, csAtenaEntity, ABAtenaEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);
                // * —š—ð”Ô† 000014 2004/08/27 •ÏXI—¹

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 49820


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 49916


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 50184


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 50267


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csAtenaEntity;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ŒÂ•Êƒf[ƒ^’Šo
        // * 
        // * \•¶           Friend Function GetAtenaBKobetsu(ByVal intGetCount As Integer, 
        // *                                                ByVal cSearchKey As ABAtenaSearchKey, 
        // *                                                ByVal blnSakujoFG As Boolean) As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼ƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ÆŒÂ•Êƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           intGetCount   : Žæ“¾Œ”
        // *                cSearchKey    : ˆ¶–¼ƒ}ƒXƒ^ŒŸõƒL[
        // *                blnSakujoFG   : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½ˆ¶–¼ƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        // *—š—ð”Ô† 000025 2008/01/15 C³ŠJŽn
        // Friend Function GetAtenaBKobetsu(ByVal intGetCount As Integer, _
        // ByVal cSearchKey As ABAtenaSearchKey, _
        // ByVal blnSakujoFG As Boolean) As DataSet
        internal DataSet GetAtenaBKobetsu(int intGetCount, ABAtenaSearchKey cSearchKey, bool blnSakujoFG, string strKobetsuKB)
        {
            // *—š—ð”Ô† 000025 2008/01/15 C³I—¹
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            DataSet csAtenaEntity;
            // * corresponds to VS2008 Start 2010/04/16 000026
            // Dim csDataTable As DataTable
            // * corresponds to VS2008 End 2010/04/16 000026
            var strSQL = new StringBuilder();
            // * —š—ð”Ô† 000017 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
            string strSQLExec;
            // * —š—ð”Ô† 000017 2005/01/25 ’Ç‰ÁI—¹

            StringBuilder strWHERE;
            var strORDER = new StringBuilder();
            int intMaxRows;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name);

                // ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
                if (intGetCount < 0 | intGetCount > 999)    // Žæ“¾Œ”‚ÌŒë‚è
                {
                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_PARA_GETCOUNT);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                }

                // ˆ¶–¼ŒŸõƒL[‚Ìƒ`ƒFƒbƒN
                // ‚È‚µ

                // *—š—ð”Ô† 000025 2008/01/15 ’Ç‰ÁŠJŽn
                // ŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ðƒƒ“ƒo•Ï”‚ÉƒZƒbƒg
                m_strKobetsuShutokuKB = strKobetsuKB.Trim();
                // *—š—ð”Ô† 000025 2008/01/15 ’Ç‰ÁI—¹

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

                // * —š—ð”Ô† 000017 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                // ' SELECT ABATENA.*
                // strSQL.Append("SELECT ").Append(ABAtenaEntity.TABLE_NAME).Append(".*")
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

                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYEntity(m_strKobetuSQLsbKaniAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strKobetuSQLsbKaniAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                                m_strKobetuSQLsbKaniAll.Append(" FROM ").Append(ABAtenaEntity.TABLE_NAME);
                                // ŒÂ•ÊŽ–€‚ÌJOIN‹å‚ðì¬
                                SetKobetsuJoin(m_strKobetuSQLsbKaniAll);
                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strKobetuSQLsbKaniAll);

                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYJoin(m_strKobetuSQLsbKaniAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strKobetuSQLsbKaniAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                                m_csDataSchmaKobetuKaniAll = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaEntity.TABLE_NAME, false);
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

                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYEntity(m_strKobetuSQLsbKaniOnly);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strKobetuSQLsbKaniOnly);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                                m_strKobetuSQLsbKaniOnly.Append(" FROM ").Append(ABAtenaEntity.TABLE_NAME);
                                // ŒÂ•ÊŽ–€‚ÌJOIN‹å‚ðì¬
                                SetKobetsuJoin(m_strKobetuSQLsbKaniOnly);
                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strKobetuSQLsbKaniOnly);

                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYJoin(m_strKobetuSQLsbKaniOnly);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strKobetuSQLsbKaniOnly);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                                m_csDataSchmaKobetuKaniOnly = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaEntity.TABLE_NAME, false);
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

                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYEntity(m_strKobetuSQLsbNenkinAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strKobetuSQLsbNenkinAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                                m_strKobetuSQLsbNenkinAll.Append(" FROM ").Append(ABAtenaEntity.TABLE_NAME);
                                // ŒÂ•ÊŽ–€‚ÌJOIN‹å‚ðì¬
                                SetKobetsuJoin(m_strKobetuSQLsbNenkinAll);
                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strKobetuSQLsbNenkinAll);

                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYJoin(m_strKobetuSQLsbNenkinAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strKobetuSQLsbNenkinAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                                m_csDataSchmaKobetuNenkinAll = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaEntity.TABLE_NAME, false);
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
                                m_strKobetuSQLsbAll.Append(ABAtenaEntity.TABLE_NAME).Append(".*");
                                // ŒÂ•ÊŽ–€‚Ì€–ÚƒZƒbƒg
                                SetKobetsuEntity(m_strKobetuSQLsbAll);
                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaCountEntity(m_strKobetuSQLsbAll);

                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYEntity(m_strKobetuSQLsbAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éj‚Ìê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                                {
                                    SetMyNumberEntity(m_strKobetuSQLsbAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                                m_strKobetuSQLsbAll.Append(" FROM ").Append(ABAtenaEntity.TABLE_NAME);
                                // ŒÂ•ÊŽ–€‚ÌJOIN‹å‚ðì¬
                                SetKobetsuJoin(m_strKobetuSQLsbAll);
                                // ‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                                SetAtenaJoin(m_strKobetuSQLsbAll);

                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON || m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    SetFZYJoin(m_strKobetuSQLsbAll);
                                }
                                else
                                {
                                    // ˆ—‚È‚µ
                                }
                                // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ª"1"iŽæ“¾‚·‚éjA‚Ü‚½‚Í‹¤’Ê”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A‹¤’Ê”Ô†ƒ}ƒXƒ^‚ð•t‰Á
                                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON || cSearchKey.p_strMyNumber.Trim.RLength > 0)
                                {
                                    SetMyNumberJoin(m_strKobetuSQLsbAll);
                                }
                                else
                                {
                                    // noop
                                }
                                // *—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                                m_csDataSchmaKobetuAll = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaEntity.TABLE_NAME, false);
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
                // m_strKobetuSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".*")
                // Case ABEnumDefine.AtenaGetKB.KaniAll
                // Call SetAtenaEntity(m_strKobetuSQLsb)
                // Case ABEnumDefine.AtenaGetKB.KaniOnly
                // Call SetAtenaEntity(m_strKobetuSQLsb)
                // Case Else
                // 'Œ»s
                // m_strKobetuSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".*")
                // End Select

                // 'ŒÂ•ÊŽ–€‚Ì€–ÚƒZƒbƒg
                // Call SetKobetsuEntity(m_strKobetuSQLsb)

                // '‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                // Call SetAtenaCountEntity(m_strKobetuSQLsb)

                // '  FROM ABATENA 
                // m_strKobetuSQLsb.Append(" FROM ").Append(ABAtenaEntity.TABLE_NAME)

                // 'ŒÂ•ÊŽ–€‚ÌJOIN‹å‚ðì¬
                // Call SetKobetsuJoin(m_strKobetuSQLsb)

                // '‘ã—l“™‚ÌƒJƒEƒ“ƒg‚ðŽæ“¾
                // Call SetAtenaJoin(m_strKobetuSQLsb)
                // End If
                // strSQL.Append(m_strKobetuSQLsb)
                // '* —š—ð”Ô† 000017 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                // '* —š—ð”Ô† 000014 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
                // If (m_csDataSchmaKobetu Is Nothing) Then
                // m_csDataSchmaKobetu = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString, ABAtenaEntity.TABLE_NAME, False)
                // End If
                // '* —š—ð”Ô† 000014 2004/08/27 ’Ç‰ÁI—¹

                // WHERE‹å‚Ìì¬
                // *—š—ð”Ô† 000031 2018/03/08 C³ŠJŽn
                // strWHERE = New StringBuilder(Me.CreateWhere(cSearchKey))

                // ' íœƒtƒ‰ƒO
                // If blnSakujoFG = False Then
                // If Not (strWHERE.Length = 0) Then
                // strWHERE.Append(" AND ")
                // End If
                // strWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SAKUJOFG)
                // strWHERE.Append(" <> '1'")
                // End If
                strWHERE = new StringBuilder(CreateWhereMain(cSearchKey, blnSakujoFG));
                // *—š—ð”Ô† 000031 2018/03/08 C³I—¹

                // ORDER‹å‚ðŒ‹‡

                // Z–¯—Dæ‹æ•ª‚ªh1h‚Å‚©‚Â¢‘ÑƒR[ƒh‚ªŽw’èÏ‚Ìê‡FZ–¯•[•\Ž¦‡
                if (cSearchKey.p_strJuminYuseniKB == "1" & cSearchKey.p_strStaiCD.Trim != string.Empty)
                {
                    strORDER.Append(" ORDER BY ");
                    strORDER.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINHYOHYOJIJUN).Append(" ASC,");
                    strORDER.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD).Append(" ASC;");
                }
                else if (!(cSearchKey.p_strUmareYMD.Trim == string.Empty))
                {
                    strORDER.Append(" ORDER BY ");
                    strORDER.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.UMAREYMD).Append(" ASC,");
                    strORDER.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD).Append(" ASC;");
                }
                else
                {
                    strORDER.Append(" ORDER BY ");
                    strORDER.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEARCHKANASEIMEI).Append(" ASC,");
                    strORDER.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD).Append(" ASC;");
                }

                if (strWHERE.RLength == 0)
                {
                    strSQL.Append(strORDER);
                }
                else
                {
                    strSQL.Append(" WHERE ").Append(strWHERE).Append(strORDER);
                }

                // * —š—ð”Ô† 000017 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
                strSQLExec = strSQL.ToString();
                // * —š—ð”Ô† 000017 2005/01/25 ’Ç‰ÁI—¹

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // '* —š—ð”Ô† 000017 2005/01/25 XVŠJŽni‹{‘òjIf •¶‚ÅˆÍ‚Þ
                // If (m_blnBatch = False) Then
                // m_cfLogClass.RdbWrite(m_cfControlData,
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" +
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQLExec, m_cfSelectUFParameterCollectionClass) + "z")
                // End If
                // * —š—ð”Ô† 000017 2005/01/25 XVI—¹i‹{‘òjIf •¶‚ÅˆÍ‚Þ

                // * —š—ð”Ô† 000014 2004/08/27 •ÏXŠJŽni‹{‘òj
                // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                // csAtenaEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, ABAtenaEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass)
                csAtenaEntity = m_csDataSchmaKobetu.Clone();
                csAtenaEntity = m_cfRdbClass.GetDataSet(strSQLExec, csAtenaEntity, ABAtenaEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);
                // * —š—ð”Ô† 000014 2004/08/27 •ÏXI—¹

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 93985


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 94081


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 94349


                Input:
                " + Me.GetType.Name + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 94432


                                Input:
                                " + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csAtenaEntity;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertAtenaB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@ˆ¶–¼ƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertAtenaB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "InsertAtenaB";
            // * corresponds to VS2008 Start 2010/04/16 000026
            // Dim csInstRow As DataRow
            // Dim csDataColumn As DataColumn
            // * corresponds to VS2008 End 2010/04/16 000026
            int intInsCnt;                            // ’Ç‰ÁŒ”
            string strUpdateDateTime;
            // *—š—ð”Ô† 000034 2023/08/14 ’Ç‰ÁŠJŽn
            var m_cRuijiClass = new USRuijiClass();                   // —ÞŽ—•¶ŽšƒNƒ‰ƒX
                                                                      // *—š—ð”Ô† 000034 2023/08/14 ’Ç‰ÁI—¹

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strInsertSQL is null | string.IsNullOrEmpty(m_strInsertSQL) | m_cfInsertUFParameterCollectionClass is null)
                {
                    // * —š—ð”Ô† 000018 2005/05/23 C³ŠJŽn
                    // Call CreateSQL(csDataRow)
                    CreateInsertSQL(csDataRow);
                    // * —š—ð”Ô† 000018 2005/05/23 C³I—¹
                }

                // *—š—ð”Ô† 000034 2023/08/14 ’Ç‰ÁŠJŽn
                // ŒŸõ—pŠ¿Žš–¼Ì‚É—ÞŽš‚ðƒZƒbƒg‚·‚é
                // *—š—ð”Ô† 000035 2023/10/19 C³ŠJŽn
                // csDataRow(ABAtenaEntity.SEARCHKANJIMEISHO) =
                // m_cRuijiClass.GetRuijiMojiList(csDataRow(ABAtenaEntity.SEARCHKANJIMEISHO).ToString)
                csDataRow(ABAtenaEntity.SEARCHKANJIMEISHO) = m_cRuijiClass.GetRuijiMojiList(Conversions.ToString(csDataRow(ABAtenaEntity.SEARCHKANJIMEISHO)).Replace("@", string.Empty)).ToUpper;
                // *—š—ð”Ô† 000035 2023/10/19 C³I—¹
                // *—š—ð”Ô† 000034 2023/08/14 ’Ç‰ÁI—¹

                // XV“úŽž‚ÌŽæ“¾
                strUpdateDateTime = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");  // ì¬“úŽž

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABAtenaEntity.TANMATSUID) = m_cfControlData.m_strClientId; // ’[––‚h‚c
                csDataRow(ABAtenaEntity.SAKUJOFG) = "0";                               // íœƒtƒ‰ƒO
                csDataRow(ABAtenaEntity.KOSHINCOUNTER) = decimal.Zero;                 // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaEntity.SAKUSEINICHIJI) = strUpdateDateTime;           // ì¬“úŽž
                csDataRow(ABAtenaEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;  // ì¬ƒ†[ƒU[
                csDataRow(ABAtenaEntity.KOSHINNICHIJI) = strUpdateDateTime;            // XV“úŽž
                csDataRow(ABAtenaEntity.KOSHINUSER) = m_cfControlData.m_strUserId;   // XVƒ†[ƒU[


                // '“–ƒNƒ‰ƒX‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¤
                // For Each csDataColumn In csDataRow.Table.Columns
                // 'ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                // CheckColumnValue(csDataColumn.ColumnName, csDataRow(csDataColumn.ColumnName).ToString().Trim)
                // Next csDataColumn


                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    cfParam.Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaEntity.PARAM_PLACEHOLDER.RLength)).ToString();


                // *—š—ð”Ô† 000009 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strInsertSQL + "z")

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData,
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" +
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strInsertSQL, m_cfInsertUFParameterCollectionClass) + "z")
                // *—š—ð”Ô† 000009 2003/08/28 C³I—¹

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 100322


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 100418


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 100686


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 100769


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intInsCnt;

        }
        // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertAtenaB() As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼ƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”           csAtenaDr As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼j
        // * @@           csAtenaFZYDr As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼•tj
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertAtenaB(DataRow csAtenaDr, DataRow csAtenaFZYDr)
        {
            int intInsCnt = 0;
            int intInsCnt2 = 0;

            const string THIS_METHOD_NAME = "InsertAtenaB";

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ˆ¶–¼ƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                intInsCnt = InsertAtenaB(csAtenaDr);

                // ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                if (!(csAtenaFZYDr == null) && m_blnJukihoKaiseiFG)
                {
                    // ˆ¶–¼•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                    if (m_csAtenaFZYB == null)
                    {
                        m_csAtenaFZYB = new ABAtenaFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }

                    // ì¬“úŽžAXV“úŽž‚Ì“¯Šú
                    csAtenaFZYDr(ABAtenaFZYEntity.SAKUSEINICHIJI) = csAtenaDr(ABAtenaEntity.SAKUSEINICHIJI);
                    csAtenaFZYDr(ABAtenaFZYEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaEntity.KOSHINNICHIJI);

                    // ˆ¶–¼•tƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                    intInsCnt2 = m_csAtenaFZYB.InsertAtenaFZYB(csAtenaFZYDr);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 103777


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 103873


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 104141


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 104224


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intInsCnt;

        }
        // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000034 2023/08/14 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertAtenaB(ByVal csAtenaDr As DataRow, ByVal csAtenaHyojunDr As DataRow,
        // ByVal csAtenaFZYDr As DataRow, ByVal csAtenaFZYHyojunDr As DataRow) As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼ƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”           csAtenaDr As DataRow          : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼j
        // * @@           csAtenaHyojunDr As DataRow    : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼_•W€j
        // * @@           csAtenaFZYDr As DataRow       : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼•tj
        // * @@           csAtenaFZYHyojunDr As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼•t_•W€j
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertAtenaB(DataRow csAtenaDr, DataRow csAtenaHyojunDr, DataRow csAtenaFZYDr, DataRow csAtenaFZYHyojunDr)
        {
            int intInsCnt = 0;
            int intInsCnt2 = 0;
            int intInsCnt3 = 0;
            int intInsCnt4 = 0;

            const string THIS_METHOD_NAME = "InsertAtenaB";

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ˆ¶–¼ƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                intInsCnt = InsertAtenaB(csAtenaDr);

                // 'ˆ¶–¼_•W€ƒ}ƒXƒ^‚ª‘¶Ý‚µ‚Ä‚¢‚éê‡
                if (!(csAtenaHyojunDr == null))
                {
                    // ˆ¶–¼_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                    if (m_csAtenaHyojunB == null)
                    {
                        m_csAtenaHyojunB = new ABAtena_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }

                    // ì¬“úŽžAXV“úŽž‚Ì“¯Šú
                    csAtenaHyojunDr(ABAtenaFZYEntity.SAKUSEINICHIJI) = csAtenaDr(ABAtenaEntity.SAKUSEINICHIJI);
                    csAtenaHyojunDr(ABAtenaFZYEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaEntity.KOSHINNICHIJI);

                    // ˆ¶–¼_•W€ƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                    intInsCnt2 = m_csAtenaHyojunB.InsertAtenaHyojunB(csAtenaHyojunDr);

                }

                // ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                if (m_blnJukihoKaiseiFG)
                {

                    // ˆ¶–¼•tƒ}ƒXƒ^‚ª‘¶Ý‚·‚éê‡
                    if (!(csAtenaFZYDr == null))
                    {

                        // ˆ¶–¼•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                        if (m_csAtenaFZYB == null)
                        {
                            m_csAtenaFZYB = new ABAtenaFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                        }
                        else
                        {
                            // ˆ—‚È‚µ
                        }

                        // ì¬“úŽžAXV“úŽž‚Ì“¯Šú
                        csAtenaFZYDr(ABAtenaFZYEntity.SAKUSEINICHIJI) = csAtenaDr(ABAtenaEntity.SAKUSEINICHIJI);
                        csAtenaFZYDr(ABAtenaFZYEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaEntity.KOSHINNICHIJI);

                        // ˆ¶–¼•tƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                        intInsCnt3 = m_csAtenaFZYB.InsertAtenaFZYB(csAtenaFZYDr);

                    }

                    // ˆ¶–¼•t_•W€ƒ}ƒXƒ^‚ª‘¶Ý‚·‚éê‡
                    if (!(csAtenaFZYHyojunDr == null))
                    {

                        // ˆ¶–¼•t_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                        if (m_csAtenaFZYHyojunB == null)
                        {
                            m_csAtenaFZYHyojunB = new ABAtenaFZY_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                        }
                        else
                        {
                            // ˆ—‚È‚µ
                        }

                        // ì¬“úŽžAXV“úŽž‚Ì“¯Šú
                        csAtenaFZYHyojunDr(ABAtenaFZYHyojunEntity.SAKUSEINICHIJI) = csAtenaDr(ABAtenaEntity.SAKUSEINICHIJI);
                        csAtenaFZYHyojunDr(ABAtenaFZYHyojunEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaEntity.KOSHINNICHIJI);

                        // ˆ¶–¼•t_•W€ƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                        intInsCnt4 = m_csAtenaFZYHyojunB.InsertAtenaFZYHyojunB(csAtenaFZYHyojunDr);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 109999


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 110095


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 110363


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 110446


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intInsCnt;

        }
        // *—š—ð”Ô† 000034 2023/08/14 ’Ç‰ÁI—¹

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateAtenaB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@ˆ¶–¼ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : XV‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int UpdateAtenaB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "UpdateAtenaB";                     // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                                // * corresponds to VS2008 Start 2010/04/16 000026
                                                                                // Dim csDataColumn As DataColumn
                                                                                // * corresponds to VS2008 End 2010/04/16 000026
            int intUpdCnt;                            // XVŒ”


            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strUpdateSQL is null | string.IsNullOrEmpty(m_strUpdateSQL) | m_cfUpdateUFParameterCollectionClass is null)
                {
                    // * —š—ð”Ô† 000018 2005/05/23 C³ŠJŽn
                    // Call CreateSQL(csDataRow)
                    CreateUpdateSQL(csDataRow);
                    // * —š—ð”Ô† 000018 2005/05/23 C³I—¹
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABAtenaEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                   // ’[––‚h‚c
                csDataRow(ABAtenaEntity.KOSHINCOUNTER) = Conversions.ToDecimal(csDataRow(ABAtenaEntity.KOSHINCOUNTER)) + 1m;               // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");   // XV“úŽž
                csDataRow(ABAtenaEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                     // XVƒ†[ƒU[


                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABAtenaEntity.PREFIX_KEY.RLength) == ABAtenaEntity.PREFIX_KEY)
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                        // *—š—ð”Ô† 000008 2004/11/12 C³ŠJŽn
                        // CheckColumnValue(cfParam.ParameterName.Substring(ABAtenaEntity.PARAM_PLACEHOLDER.Length), csDataRow(cfParam.ParameterName.Substring(ABAtenaEntity.PARAM_PLACEHOLDER.Length), DataRowVersion.Current).ToString().Trim)
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                        // *—š—ð”Ô† 000008 2004/11/12 C³I—¹
                    }
                }

                // *—š—ð”Ô† 000009 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strUpdateSQL + "z")

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData,
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" +
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass) + "z")
                // *—š—ð”Ô† 000009 2003/08/28 C³I—¹

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 116020


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 116116


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 116384


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 116467


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intUpdCnt;

        }
        // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateAtenaB() As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚é
        // * 
        // * ˆø”           csAtenaDr As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼j
        // * @@           csAtenaFZYDr As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼•tj
        // * 
        // * –ß‚è’l         Integer : XV‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int UpdateAtenaB(DataRow csAtenaDr, DataRow csAtenaFZYDr)
        {
            int intCnt = 0;
            int intCnt2 = 0;

            const string THIS_METHOD_NAME = "UpdateAtenaB";

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ˆ¶–¼ƒ}ƒXƒ^XV‚ðŽÀs
                intCnt = UpdateAtenaB(csAtenaDr);

                // ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                if (!(csAtenaFZYDr == null) && m_blnJukihoKaiseiFG)
                {
                    // ˆ¶–¼•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                    if (m_csAtenaFZYB == null)
                    {
                        m_csAtenaFZYB = new ABAtenaFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }

                    // XV“úŽž‚Ì“¯Šú
                    csAtenaFZYDr(ABAtenaFZYEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaEntity.KOSHINNICHIJI);

                    // ˆ¶–¼•tƒ}ƒXƒ^XV‚ðŽÀs
                    intCnt2 = m_csAtenaFZYB.UpdateAtenaFZYB(csAtenaFZYDr);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 119349


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 119445


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 119713


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 119796


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intCnt;

        }
        // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000034 2023/08/14 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateAtenaB(ByVal csAtenaDr As DataRow, ByVal csAtenaHyojunDr As DataRow, _
        // *                                             ByVal csAtenaFZYDr As DataRow, ByVal csAtenaFZYHyojunDr As DataRow) As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚é
        // * 
        // * ˆø”           csAtenaDr As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼j
        // * @@           csAtenaHyojunDr As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼_•W€j
        // * @@           csAtenaFZYDr As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼•tj
        // * @@           csAtenaFZYHyojunDr As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼•t_•W€j
        // * 
        // * –ß‚è’l         Integer : XV‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int UpdateAtenaB(DataRow csAtenaDr, DataRow csAtenaHyojunDr, DataRow csAtenaFZYDr, DataRow csAtenaFZYHyojunDr, bool blnJutogai = true)
        {
            int intCnt = 0;
            int intCnt2 = 0;
            int intCnt3 = 0;
            int intCnt4 = 0;

            const string THIS_METHOD_NAME = "UpdateAtenaB";

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ˆ¶–¼ƒ}ƒXƒ^XV‚ðŽÀs
                intCnt = UpdateAtenaB(csAtenaDr);

                // ˆ¶–¼_•W€ƒ}ƒXƒ^‚ª‘¶Ý‚·‚éê‡AXV‚ð‚·‚é
                if (!(csAtenaHyojunDr == null))
                {
                    // ˆ¶–¼_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                    if (m_csAtenaHyojunB == null)
                    {
                        m_csAtenaHyojunB = new ABAtena_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }

                    // XV“úŽž‚Ì“¯Šú
                    csAtenaHyojunDr(ABAtenaHyojunEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaEntity.KOSHINNICHIJI);

                    // ˆ¶–¼_•W€ƒ}ƒXƒ^XV‚ðŽÀs
                    if (blnJutogai)
                    {
                        intCnt2 = m_csAtenaHyojunB.UpdateAtenaHyojunB(csAtenaHyojunDr, csAtenaDr(ABAtenaEntity.ATENADATAKB).ToString);
                    }
                    else
                    {
                        intCnt2 = m_csAtenaHyojunB.UpdateAtenaHyojunB(csAtenaHyojunDr);
                    }
                }

                // ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                if (m_blnJukihoKaiseiFG)
                {

                    // ˆ¶–¼•tƒ}ƒXƒ^‚ª‘¶Ý‚·‚éê‡AXV‚ð‚·‚é
                    if (!(csAtenaFZYDr == null))
                    {
                        // ˆ¶–¼•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                        if (m_csAtenaFZYB == null)
                        {
                            m_csAtenaFZYB = new ABAtenaFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                        }
                        else
                        {
                            // ˆ—‚È‚µ
                        }

                        // XV“úŽž‚Ì“¯Šú
                        csAtenaFZYDr(ABAtenaFZYEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaEntity.KOSHINNICHIJI);

                        // ˆ¶–¼•tƒ}ƒXƒ^XV‚ðŽÀs
                        intCnt3 = m_csAtenaFZYB.UpdateAtenaFZYB(csAtenaFZYDr);
                    }

                    // ˆ¶–¼•t_•W€ƒ}ƒXƒ^‚ª‘¶Ý‚·‚éê‡AXV‚ð‚·‚é
                    if (!(csAtenaFZYHyojunDr == null))
                    {
                        // ˆ¶–¼•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                        if (m_csAtenaFZYHyojunB == null)
                        {
                            m_csAtenaFZYHyojunB = new ABAtenaFZY_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                        }
                        else
                        {
                            // ˆ—‚È‚µ
                        }

                        // XV“úŽž‚Ì“¯Šú
                        csAtenaFZYHyojunDr(ABAtenaFZYHyojunEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaEntity.KOSHINNICHIJI);

                        // ˆ¶–¼•tƒ}ƒXƒ^XV‚ðŽÀs
                        intCnt4 = m_csAtenaFZYHyojunB.UpdateAtenaFZYHyojunB(csAtenaFZYHyojunDr);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 125477


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 125573


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 125841


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 125924


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intCnt;

        }
        // *—š—ð”Ô† 000034 2023/08/14 ’Ç‰ÁI—¹

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^íœ
        // * 
        // * \•¶           Public Function DeleteAtenaB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@ˆ¶–¼ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð˜_—íœ‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ˜_—íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int DeleteAtenaB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "DeleteAtenaB";  // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                             // * corresponds to VS2008 Start 2010/04/16 000026
                                                             // Dim csDataColumn As DataColumn
                                                             // * corresponds to VS2008 End 2010/04/16 000026
            int intDelCnt;        // íœŒ”


            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strDelRonriSQL is null | string.IsNullOrEmpty(m_strDelRonriSQL) | m_cfDelRonriUFParameterCollectionClass is null)
                {
                    // * —š—ð”Ô† 000018 2005/05/23 C³ŠJŽn
                    // CreateSQL(csDataRow)
                    CreateDeleteRonriSQL(csDataRow);
                    // * —š—ð”Ô† 000018 2005/05/23 C³I—¹
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABAtenaEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                   // ’[––‚h‚c
                csDataRow(ABAtenaEntity.SAKUJOFG) = "1";                                                                 // íœƒtƒ‰ƒO
                csDataRow(ABAtenaEntity.KOSHINCOUNTER) = Conversions.ToDecimal(csDataRow(ABAtenaEntity.KOSHINCOUNTER)) + 1m;               // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");   // XV“úŽž
                csDataRow(ABAtenaEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                     // XVƒ†[ƒU[

                // * —š—ð”Ô† 000018 2005/05/23 C³ŠJŽn
                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                // For Each cfParam In m_cfUpdateUFParameterCollectionClass
                foreach (UFParameterClass cfParam in m_cfDelRonriUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABAtenaEntity.PREFIX_KEY.RLength) == ABAtenaEntity.PREFIX_KEY)
                    {
                        // m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = _
                        // csDataRow(cfParam.ParameterName.Substring(ABAtenaEntity.PREFIX_KEY.Length), _
                        // DataRowVersion.Original).ToString()
                        this.m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // *—š—ð”Ô† 000008 2004/11/12 C³ŠJŽn
                        // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                        // CheckColumnValue(cfParam.ParameterName.Substring(ABAtenaEntity.PARAM_PLACEHOLDER.Length), csDataRow(cfParam.ParameterName.Substring(ABAtenaEntity.PARAM_PLACEHOLDER.Length), DataRowVersion.Current).ToString().Trim)
                        // *—š—ð”Ô† 000008 2004/11/12 C³I—¹
                        // m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.Substring(ABAtenaEntity.PARAM_PLACEHOLDER.Length), DataRowVersion.Current).ToString()
                        this.m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }
                // * —š—ð”Ô† 000018 2005/05/23 C³I—¹


                // *—š—ð”Ô† 000009 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strUpdateSQL + "z")

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData,
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" +
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass) + "z")
                // *—š—ð”Ô† 000009 2003/08/28 C³I—¹

                // SQL‚ÌŽÀs
                // intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelRonriSQL, m_cfUpdateUFParameterCollectionClass)
                intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 132356


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 132452


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 132720


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 132803


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intDelCnt;

        }
        // *—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^íœ
        // * 
        // * \•¶           Public Function UpdateAtenaB() As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð˜_—íœ‚·‚é
        // * 
        // * ˆø”           csAtenaDr As DataRow : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼j
        // * @@           csAtenaFZYDr As DataRow : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼•tj
        // * 
        // * –ß‚è’l         Integer : ˜_—íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int DeleteAtenaB(DataRow csAtenaDr, DataRow csAtenaFZYDr)
        {
            int intCnt = 0;
            int intCnt2 = 0;

            const string THIS_METHOD_NAME = "DeleteAtenaB";

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ˆ¶–¼ƒ}ƒXƒ^XV‚ðŽÀs
                intCnt = DeleteAtenaB(csAtenaDr);

                // ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                if (!(csAtenaFZYDr == null) && m_blnJukihoKaiseiFG)
                {
                    // ˆ¶–¼•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                    if (m_csAtenaFZYB == null)
                    {
                        m_csAtenaFZYB = new ABAtenaFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }

                    // XV“úŽž‚Ì“¯Šú
                    csAtenaFZYDr(ABAtenaFZYEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaEntity.KOSHINNICHIJI);

                    // ˆ¶–¼•tƒ}ƒXƒ^XV‚ðŽÀs
                    intCnt2 = m_csAtenaFZYB.DeleteAtenaFZYB(csAtenaFZYDr);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 135710


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 135806


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 136074


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 136157


                Input:
                " + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return intCnt

                    End Function
                    '*—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000034 2023/08/14 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^íœ
                    '* 
                    '* \•¶           Public Overloads Function DeleteAtenaB(ByVal csAtenaDr As DataRow, _
                    '*                                                       ByVal csAtenaFZYDr As DataRow, _
                    '*                                                       ByVal csAtenaHyojunDr As DataRow, _
                    '*                                                       ByVal csAtenaFZYHyojunDr As DataRow) As Integer
                    '* 
                    '* ‹@”\@@    @ ˆ¶–¼ƒ}ƒXƒ^Aˆ¶–¼•tƒ}ƒXƒ^Aˆ¶–¼_•W€ƒ}ƒXƒ^Aˆ¶–¼•t_•W€ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð˜_—íœ‚·‚é
                    '* 
                    '* ˆø”           csAtenaDr As DataRow           : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼j
                    '* @@           csAtenaHyojunDr As DataRow     : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼_•W€j
                    '* @@           csAtenaFZYDr As DataRow        : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼•tj
                    '* @@           csAtenaFZYHyojunDr As DataRow  : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼•t_•W€j
                    '* 
                    '* –ß‚è’l         Integer : ˜_—íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
                    '************************************************************************************************
                    '*—š—ð”Ô† 000035 2023/10/19 C³ŠJŽn
                    'Public Overloads Function DeleteAtenaB(ByVal csAtenaDr As DataRow, ByVal csAtenaFZYDr As DataRow,
                    '                                       ByVal csAtenaHyojunDr As DataRow, ByVal csAtenaFZYHyojunDr As DataRow) As Integer
                    Public Overloads Function DeleteAtenaB(ByVal csAtenaDr As DataRow, ByVal csAtenaHyojunDr As DataRow,
                                                           ByVal csAtenaFZYDr As DataRow, ByVal csAtenaFZYHyojunDr As DataRow) As Integer
                        '*—š—ð”Ô† 000035 2023/10/19 C³I—¹

                        Dim intCnt As Integer = 0
                        Dim intCnt2 As Integer = 0
                        Dim intCnt3 As Integer = 0
                        Dim intCnt4 As Integer = 0

                        Const THIS_METHOD_NAME As String = "DeleteAtenaB"

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'ˆ¶–¼ƒ}ƒXƒ^XV‚ðŽÀs
                            intCnt = Me.DeleteAtenaB(csAtenaDr)

                            'ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                            If (m_blnJukihoKaiseiFG) Then

                                'ˆ¶–¼_•W€ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ª‘¶Ý‚·‚éê‡Aˆ—‚ðs‚¤
                                If (Not IsNothing(csAtenaHyojunDr)) Then

                                    'ˆ¶–¼_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                                    If (IsNothing(m_csAtenaHyojunB)) Then
                                        m_csAtenaHyojunB = New ABAtena_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                    Else
                                        'ˆ—‚È‚µ
                                    End If

                                    'XV“úŽž‚Ì“¯Šú
                                    csAtenaHyojunDr(ABAtenaHyojunEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaEntity.KOSHINNICHIJI)

                                    'ˆ¶–¼_•W€ƒ}ƒXƒ^XV‚ðŽÀs
                                    intCnt2 = m_csAtenaHyojunB.DeleteAtenaHyojunB(csAtenaHyojunDr)

                                End If

                                'ˆ¶–¼•tƒ}ƒXƒ^‚Ìƒf[ƒ^‚ª‘¶Ý‚·‚éê‡Aˆ—‚ðs‚¤
                                If (Not IsNothing(csAtenaFZYDr)) Then

                                    'ˆ¶–¼•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                                    If (IsNothing(m_csAtenaFZYB)) Then
                                        m_csAtenaFZYB = New ABAtenaFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                    Else
                                        'ˆ—‚È‚µ
                                    End If

                                    'XV“úŽž‚Ì“¯Šú
                                    csAtenaFZYDr(ABAtenaFZYEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaEntity.KOSHINNICHIJI)

                                    'ˆ¶–¼•tƒ}ƒXƒ^XV‚ðŽÀs
                                    intCnt3 = m_csAtenaFZYB.DeleteAtenaFZYB(csAtenaFZYDr)

                                End If

                                'ˆ¶–¼•t_•W€ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ª‘¶Ý‚·‚éê‡Aˆ—‚ðs‚¤
                                If (Not IsNothing(csAtenaFZYHyojunDr)) Then

                                    'ˆ¶–¼•t_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                                    If (IsNothing(m_csAtenaFZYHyojunB)) Then
                                        m_csAtenaFZYHyojunB = New ABAtenaFZY_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                    Else
                                        'ˆ—‚È‚µ
                                    End If

                                    'XV“úŽž‚Ì“¯Šú
                                    csAtenaFZYHyojunDr(ABAtenaFZYHyojunEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaEntity.KOSHINNICHIJI)

                                    'ˆ¶–¼•t_•W€ƒ}ƒXƒ^XV‚ðŽÀs
                                    intCnt4 = m_csAtenaFZYHyojunB.DeleteAtenaFZYHyojun(csAtenaFZYHyojunDr)

                                End If

                            Else
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
                    '*—š—ð”Ô† 000034 2023/08/14 ’Ç‰ÁI—¹

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^•¨—íœ
                    '* 
                    '* \•¶           Public Function DeleteAtenaB(ByVal csDataRow As DataRow, _
                    '*                                               ByVal strSakujoKB As String) As Integer
                    '* 
                    '* ‹@”\@@    @@ˆ¶–¼ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð•¨—íœ‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
                    '* 
                    '* –ß‚è’l         Integer : íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
                    '************************************************************************************************
                    Public Overloads Function DeleteAtenaB(ByVal csDataRow As DataRow,
                                                             ByVal strSakujoKB As String) As Integer

                        Const THIS_METHOD_NAME As String = "DeleteAtenaB"
                        Dim objErrorStruct As UFErrorStruct 'ƒGƒ‰[’è‹`\‘¢‘Ì
                        Dim cfParam As UFParameterClass     'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim intDelCnt As Integer            'íœŒ”


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
                            If (m_strDelButuriSQL Is Nothing Or m_strDelButuriSQL = String.Empty Or
                                    IsNothing(m_cfDelButuriUFParameterCollectionClass)) Then
                                '* —š—ð”Ô† 000018 2005/05/23 C³ŠJŽn
                                'CreateSQL(csDataRow)
                                Call CreateDeleteButsuriSQL(csDataRow)
                                '* —š—ð”Ô† 000018 2005/05/23 C³I—¹
                            End If

                            ' ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚Öíœs‚©‚ç’l‚ðÝ’è‚·‚éB
                            For Each cfParam In m_cfDelButuriUFParameterCollectionClass

                                ' ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                                If (cfParam.ParameterName.RSubstring(0, ABAtenaEntity.PREFIX_KEY.RLength) = ABAtenaEntity.PREFIX_KEY) Then
                                    m_cfDelButuriUFParameterCollectionClass(cfParam.ParameterName).Value _
                                            = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString()
                                End If
                            Next cfParam


                            '*—š—ð”Ô† 000009 2003/08/28 C³ŠJŽn
                            '' RDBƒAƒNƒZƒXƒƒOo—Í
                            'm_cfLogClass.RdbWrite(m_cfControlData, _
                            '                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                            '                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                            '                        "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                            '                        "ySQL“à—e:" + m_strUpdateSQL + "z")

                            '' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                            'm_cfLogClass.RdbWrite(m_cfControlData,
                            '                            "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                            '                            "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                            '                            "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" +
                            '                            "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strDelButuriSQL, m_cfDelButuriUFParameterCollectionClass) + "z")
                            '*—š—ð”Ô† 000003 2003/08/28 C³I—¹

                            ' SQL‚ÌŽÀs
                            intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelButuriSQL, m_cfDelButuriUFParameterCollectionClass)

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

                        Return intDelCnt

                    End Function
                    '*—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^•¨—íœ
                    '* 
                    '* \•¶           Public Function UpdateAtenaB() As Integer
                    '* 
                    '* ‹@”\@@    @ ˆ¶–¼ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð•¨—íœ‚·‚é
                    '* 
                    '* ˆø”           csAtenaDr As DataRow : •¨—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼j
                    '* @@           csAtenaFZYDr As DataRow : •¨—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼•tj
                    '*                strSakujoKB As String F íœ‹æ•ª  
                    '* 
                    '* –ß‚è’l         Integer : íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
                    '************************************************************************************************
                    Public Overloads Function DeleteAtenaB(ByVal csAtenaDr As DataRow, ByVal csAtenaFZYDr As DataRow, ByVal strSakujoKB As String) As Integer
                        Dim intCnt As Integer = 0
                        Dim intCnt2 As Integer = 0

                        Const THIS_METHOD_NAME As String = "DeleteAtenaB"

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'ˆ¶–¼ƒ}ƒXƒ^XV‚ðŽÀs
                            intCnt = Me.DeleteAtenaB(csAtenaDr, strSakujoKB)

                            'ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                            If (Not IsNothing(csAtenaFZYDr)) AndAlso (m_blnJukihoKaiseiFG) Then
                                'ˆ¶–¼•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                                If (IsNothing(m_csAtenaFZYB)) Then
                                    m_csAtenaFZYB = New ABAtenaFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                Else
                                    'ˆ—‚È‚µ
                                End If

                                'ˆ¶–¼•tƒ}ƒXƒ^XV‚ðŽÀs
                                intCnt2 = m_csAtenaFZYB.DeleteAtenaFZYB(csAtenaFZYDr, strSakujoKB)
                            Else
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
                    '*—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000034 2023/08/14 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^•¨—íœ
                    '* 
                    '* \•¶           Public Overloads Function DeleteAtenaB(ByVal csAtenaDr As DataRow, _
                    '*                                                       ByVal csAtenaFZYDr As DataRow, _
                    '*                                                       ByVal csAtenaHyojunDr As DataRow, _
                    '*                                                       ByVal csAtenaFZYHyojunDr As DataRow, _
                    '*                                                       ByVal strSakujoKB As String) As Integer
                    '* 
                    '* ‹@”\@@    @ ˆ¶–¼ƒ}ƒXƒ^Aˆ¶–¼•tƒ}ƒXƒ^Aˆ¶–¼_•W€ƒ}ƒXƒ^Aˆ¶–¼•t_•W€ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð•¨—íœ‚·‚é
                    '* 
                    '* ˆø”           csAtenaDr As DataRow           : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼j
                    '* @@           csAtenaHyojunDr As DataRow     : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼_•W€j
                    '* @@           csAtenaFZYDr As DataRow        : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼•tj
                    '* @@           csAtenaFZYHyojunDr As DataRow  : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼•t_•W€j
                    '*                strSakujoKB As String          F íœ‹æ•ª  
                    '* 
                    '* –ß‚è’l         Integer : ˜_—íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
                    '************************************************************************************************
                    '*—š—ð”Ô† 000035 2023/10/19 C³ŠJŽn
                    'Public Overloads Function DeleteAtenaB(ByVal csAtenaDr As DataRow, ByVal csAtenaFZYDr As DataRow,
                    '                                       ByVal csAtenaHyojunDr As DataRow, ByVal csAtenaFZYHyojunDr As DataRow,
                    '                                       ByVal strSakujoKB As String) As Integer
                    Public Overloads Function DeleteAtenaB(ByVal csAtenaDr As DataRow, ByVal csAtenaHyojunDr As DataRow,
                                                           ByVal csAtenaFZYDr As DataRow, ByVal csAtenaFZYHyojunDr As DataRow,
                                                           ByVal strSakujoKB As String) As Integer
                        '*—š—ð”Ô† 000035 2023/10/19 C³I—¹

                        Dim intCnt As Integer = 0
                        Dim intCnt2 As Integer = 0
                        Dim intCnt3 As Integer = 0
                        Dim intCnt4 As Integer = 0

                        Const THIS_METHOD_NAME As String = "DeleteAtenaB"

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'ˆ¶–¼ƒ}ƒXƒ^XV‚ðŽÀs
                            intCnt = Me.DeleteAtenaB(csAtenaDr, strSakujoKB)

                            'ˆ¶–¼_•W€ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ª‘¶Ý‚·‚éê‡Aˆ—‚ðs‚¤
                            If (Not IsNothing(csAtenaHyojunDr)) Then

                                'ˆ¶–¼_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                                If (IsNothing(m_csAtenaHyojunB)) Then
                                    m_csAtenaHyojunB = New ABAtena_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                Else
                                    'ˆ—‚È‚µ
                                End If

                                'XV“úŽž‚Ì“¯Šú
                                csAtenaHyojunDr(ABAtenaHyojunEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaEntity.KOSHINNICHIJI)

                                'ˆ¶–¼_•W€ƒ}ƒXƒ^XV‚ðŽÀs
                                intCnt2 = m_csAtenaHyojunB.DeleteAtenaHyojunB(csAtenaHyojunDr, strSakujoKB)

                            End If

                            'ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                            If (m_blnJukihoKaiseiFG) Then

                                'ˆ¶–¼•tƒ}ƒXƒ^‚Ìƒf[ƒ^‚ª‘¶Ý‚·‚éê‡Aˆ—‚ðs‚¤
                                If (Not IsNothing(csAtenaFZYDr)) Then

                                    'ˆ¶–¼•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                                    If (IsNothing(m_csAtenaFZYB)) Then
                                        m_csAtenaFZYB = New ABAtenaFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                    Else
                                        'ˆ—‚È‚µ
                                    End If

                                    'XV“úŽž‚Ì“¯Šú
                                    csAtenaFZYDr(ABAtenaFZYEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaEntity.KOSHINNICHIJI)

                                    'ˆ¶–¼•tƒ}ƒXƒ^XV‚ðŽÀs
                                    intCnt3 = m_csAtenaFZYB.DeleteAtenaFZYB(csAtenaFZYDr, strSakujoKB)

                                End If

                                'ˆ¶–¼•t_•W€ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ª‘¶Ý‚·‚éê‡Aˆ—‚ðs‚¤
                                If (Not IsNothing(csAtenaFZYHyojunDr)) Then

                                    'ˆ¶–¼•t_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                                    If (IsNothing(m_csAtenaFZYHyojunB)) Then
                                        m_csAtenaFZYHyojunB = New ABAtenaFZY_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                    Else
                                        'ˆ—‚È‚µ
                                    End If

                                    'XV“úŽž‚Ì“¯Šú
                                    csAtenaFZYHyojunDr(ABAtenaFZYHyojunEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaEntity.KOSHINNICHIJI)

                                    'ˆ¶–¼•t_•W€ƒ}ƒXƒ^XV‚ðŽÀs
                                    intCnt4 = m_csAtenaFZYHyojunB.DeleteAtenaFZYHyojunB(csAtenaFZYHyojunDr, strSakujoKB)

                                End If

                            Else
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
                    '*—š—ð”Ô† 000034 2023/08/14 ’Ç‰ÁI—¹

                    '* —š—ð”Ô† 000018 2005/05/23 íœŠJŽn
                    ''************************************************************************************************
                    ''* ƒƒ\ƒbƒh–¼     SQL•¶‚Ìì¬
                    ''* 
                    ''* \•¶           Private Sub CreateSQL(ByVal csDataRow As DataRow)
                    ''* 
                    ''* ‹@”\@@    @@INSERT, UPDATE, DELETE‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    ''* 
                    ''* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    ''* 
                    ''* –ß‚è’l         ‚È‚µ
                    ''************************************************************************************************
                    'Private Sub CreateSQL(ByVal csDataRow As DataRow)

                    '    Const THIS_METHOD_NAME As String = "CreateSQL"
                    '    Dim csDataColumn As DataColumn
                    '    Dim csInsertColumn As StringBuilder                 'INSERT—pƒJƒ‰ƒ€’è‹`
                    '    Dim csInsertParam As StringBuilder                  'INSERT—pƒpƒ‰ƒ[ƒ^’è‹`
                    '    Dim cfUFParameterClass As UFParameterClass
                    '    Dim csWhere As StringBuilder                        'WHERE’è‹`
                    '    Dim csUpdateParam As StringBuilder                  'UPDATE—pSQL’è‹`
                    '    Dim csDelRonriParam As StringBuilder                '˜_—íœƒpƒ‰ƒ[ƒ^’è‹`


                    '    Try
                    '        ' ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                    '        m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                    '        ' SELECT SQL•¶‚Ìì¬
                    '        m_strInsertSQL = "INSERT INTO " + ABAtenaEntity.TABLE_NAME + " "
                    '        csInsertColumn = New StringBuilder()
                    '        csInsertParam = New StringBuilder()


                    '        ' UPDATE SQL•¶‚Ìì¬
                    '        m_strUpdateSQL = "UPDATE " + ABAtenaEntity.TABLE_NAME + " SET "
                    '        csUpdateParam = New StringBuilder()


                    '        ' WHERE•¶‚Ìì¬
                    '        csWhere = New StringBuilder()
                    '        csWhere.Append(" WHERE ")
                    '        csWhere.Append(ABAtenaEntity.JUMINCD)
                    '        csWhere.Append(" = ")
                    '        csWhere.Append(ABAtenaEntity.KEY_JUMINCD)
                    '        csWhere.Append(" AND ")
                    '        csWhere.Append(ABAtenaEntity.JUMINJUTOGAIKB)
                    '        csWhere.Append(" = ")
                    '        csWhere.Append(ABAtenaEntity.KEY_JUMINJUTOGAIKB)
                    '        csWhere.Append(" AND ")
                    '        csWhere.Append(ABAtenaEntity.KOSHINCOUNTER)
                    '        csWhere.Append(" = ")
                    '        csWhere.Append(ABAtenaEntity.KEY_KOSHINCOUNTER)


                    '        ' ˜_—DELETE SQL•¶‚Ìì¬
                    '        csDelRonriParam = New StringBuilder()
                    '        csDelRonriParam.Append("UPDATE ")
                    '        csDelRonriParam.Append(ABAtenaEntity.TABLE_NAME)
                    '        csDelRonriParam.Append(" SET ")
                    '        csDelRonriParam.Append(ABAtenaEntity.TANMATSUID)
                    '        csDelRonriParam.Append(" = ")
                    '        csDelRonriParam.Append(ABAtenaEntity.PARAM_TANMATSUID)
                    '        csDelRonriParam.Append(", ")
                    '        csDelRonriParam.Append(ABAtenaEntity.SAKUJOFG)
                    '        csDelRonriParam.Append(" = ")
                    '        csDelRonriParam.Append(ABAtenaEntity.PARAM_SAKUJOFG)
                    '        csDelRonriParam.Append(", ")
                    '        csDelRonriParam.Append(ABAtenaEntity.KOSHINCOUNTER)
                    '        csDelRonriParam.Append(" = ")
                    '        csDelRonriParam.Append(ABAtenaEntity.PARAM_KOSHINCOUNTER)
                    '        csDelRonriParam.Append(", ")
                    '        csDelRonriParam.Append(ABAtenaEntity.KOSHINNICHIJI)
                    '        csDelRonriParam.Append(" = ")
                    '        csDelRonriParam.Append(ABAtenaEntity.PARAM_KOSHINNICHIJI)
                    '        csDelRonriParam.Append(", ")
                    '        csDelRonriParam.Append(ABAtenaEntity.KOSHINUSER)
                    '        csDelRonriParam.Append(" = ")
                    '        csDelRonriParam.Append(ABAtenaEntity.PARAM_KOSHINUSER)
                    '        csDelRonriParam.Append(csWhere)
                    '        m_strDelRonriSQL = csDelRonriParam.ToString

                    '        ' •¨—DELETE SQL•¶‚Ìì¬
                    '        m_strDelButuriSQL = "DELETE FROM " + ABAtenaEntity.TABLE_NAME + csWhere.ToString

                    '        ' SELECT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    '        m_cfInsertUFParameterCollectionClass = New UFParameterCollectionClass()

                    '        ' UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    '        m_cfUpdateUFParameterCollectionClass = New UFParameterCollectionClass()

                    '        ' ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    '        m_cfDelRonriUFParameterCollectionClass = New UFParameterCollectionClass()

                    '        ' •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    '        m_cfDelButuriUFParameterCollectionClass = New UFParameterCollectionClass()


                    '        ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                    '        For Each csDataColumn In csDataRow.Table.Columns
                    '            cfUFParameterClass = New UFParameterClass()

                    '            ' INSERT SQL•¶‚Ìì¬
                    '            csInsertColumn.Append(csDataColumn.ColumnName)
                    '            csInsertColumn.Append(", ")

                    '            csInsertParam.Append(ABAtenaEntity.PARAM_PLACEHOLDER)
                    '            csInsertParam.Append(csDataColumn.ColumnName)
                    '            csInsertParam.Append(", ")


                    '            ' UPDATE SQL•¶‚Ìì¬
                    '            csUpdateParam.Append(csDataColumn.ColumnName)
                    '            csUpdateParam.Append(" = ")
                    '            csUpdateParam.Append(ABAtenaEntity.PARAM_PLACEHOLDER)
                    '            csUpdateParam.Append(csDataColumn.ColumnName)
                    '            csUpdateParam.Append(", ")

                    '            ' INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    '            cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                    '            m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass)

                    '            ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    '            cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                    '            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                    '        Next csDataColumn

                    '        'ÅŒã‚ÌƒJƒ“ƒ}‚ðŽæ‚èœ‚¢‚ÄINSERT•¶‚ðì¬
                    '        m_strInsertSQL += "(" + csInsertColumn.ToString.TrimEnd(" ".ToCharArray()).TrimEnd(",".ToCharArray()) + ")" _
                    '                + " VALUES (" + csInsertParam.ToString.TrimEnd(" ".ToCharArray()).TrimEnd(",".ToCharArray()) + ")"


                    '        ' UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                    '        m_strUpdateSQL += csUpdateParam.ToString.TrimEnd(" ".ToCharArray()).TrimEnd(",".ToCharArray())

                    '        ' UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                    '        m_strUpdateSQL += csWhere.ToString


                    '        ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    '        cfUFParameterClass = New UFParameterClass()
                    '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUMINCD
                    '        m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                    '        cfUFParameterClass = New UFParameterClass()
                    '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUMINJUTOGAIKB
                    '        m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                    '        cfUFParameterClass = New UFParameterClass()
                    '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_KOSHINCOUNTER
                    '        m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                    '        ' ˜_—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    '        cfUFParameterClass = New UFParameterClass()
                    '        cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_TANMATSUID
                    '        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                    '        cfUFParameterClass = New UFParameterClass()
                    '        cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_SAKUJOFG
                    '        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                    '        cfUFParameterClass = New UFParameterClass()
                    '        cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_KOSHINCOUNTER
                    '        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                    '        cfUFParameterClass = New UFParameterClass()
                    '        cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_KOSHINNICHIJI
                    '        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                    '        cfUFParameterClass = New UFParameterClass()
                    '        cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_KOSHINUSER
                    '        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                    '        cfUFParameterClass = New UFParameterClass()
                    '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUMINCD
                    '        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                    '        cfUFParameterClass = New UFParameterClass()
                    '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUMINJUTOGAIKB
                    '        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                    '        cfUFParameterClass = New UFParameterClass()
                    '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_KOSHINCOUNTER
                    '        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                    '        ' •¨—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    '        cfUFParameterClass = New UFParameterClass()
                    '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUMINCD
                    '        m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                    '        cfUFParameterClass = New UFParameterClass()
                    '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUMINJUTOGAIKB
                    '        m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                    '        cfUFParameterClass = New UFParameterClass()
                    '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_KOSHINCOUNTER
                    '        m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                    '        ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
                    '        m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                    '    Catch objAppExp As UFAppException
                    '        ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                    '        m_cfLogClass.WarningWrite(m_cfControlData, _
                    '                                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                    '                                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                    '                                    "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                    '                                    "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                    '        ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                    '        Throw objAppExp

                    '    Catch objExp As Exception
                    '        ' ƒGƒ‰[ƒƒOo—Í
                    '        m_cfLogClass.ErrorWrite(m_cfControlData, _
                    '                                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                    '                                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                    '                                    "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                    '        ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                    '        Throw objExp
                    '    End Try

                    'End Sub
                    '* —š—ð”Ô† 000018 2005/05/23 íœI—¹

                    '* —š—ð”Ô† 000018 2005/05/23 ’Ç‰ÁŠJŽn
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
                            m_strInsertSQL = "INSERT INTO " + ABAtenaEntity.TABLE_NAME + " "
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

                                csInsertParam.Append(ABAtenaEntity.PARAM_PLACEHOLDER)
                                csInsertParam.Append(csDataColumn.ColumnName)
                                csInsertParam.Append(", ")

                                ' INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                                cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                                m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass)

                            Next csDataColumn

                            'ÅŒã‚ÌƒJƒ“ƒ}‚ðŽæ‚èœ‚¢‚ÄINSERT•¶‚ðì¬
                            m_strInsertSQL += "(" + csInsertColumn.ToString.TrimEnd(" ".ToCharArray()).TrimEnd(",".ToCharArray()) + ")" _
                                    + " VALUES (" + csInsertParam.ToString.TrimEnd(" ".ToCharArray()).TrimEnd(",".ToCharArray()) + ")"

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
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
                            m_strUpdateSQL = "UPDATE " + ABAtenaEntity.TABLE_NAME + " SET "
                            csUpdateParam = New StringBuilder

                            ' WHERE•¶‚Ìì¬
                            csWhere = New StringBuilder
                            csWhere.Append(" WHERE ")
                            csWhere.Append(ABAtenaEntity.JUMINCD)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaEntity.KEY_JUMINCD)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaEntity.JUMINJUTOGAIKB)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaEntity.KEY_JUMINJUTOGAIKB)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaEntity.KOSHINCOUNTER)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaEntity.KEY_KOSHINCOUNTER)

                            ' UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfUpdateUFParameterCollectionClass = New UFParameterCollectionClass

                            ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                            For Each csDataColumn In csDataRow.Table.Columns
                                'Z–¯‚b‚cEZ–¯Z“oŠO‹æ•ªEì¬“úŽžEì¬ƒ†[ƒU‚ÍXV‚µ‚È‚¢
                                If Not (csDataColumn.ColumnName = ABAtenaEntity.JUMINCD) AndAlso
                                    Not (csDataColumn.ColumnName = ABAtenaEntity.JUMINJUTOGAIKB) AndAlso
                                     Not (csDataColumn.ColumnName = ABAtenaEntity.SAKUSEIUSER) AndAlso
                                      Not (csDataColumn.ColumnName = ABAtenaEntity.SAKUSEINICHIJI) Then

                                    cfUFParameterClass = New UFParameterClass

                                    ' UPDATE SQL•¶‚Ìì¬
                                    csUpdateParam.Append(csDataColumn.ColumnName)
                                    csUpdateParam.Append(" = ")
                                    csUpdateParam.Append(ABAtenaEntity.PARAM_PLACEHOLDER)
                                    csUpdateParam.Append(csDataColumn.ColumnName)
                                    csUpdateParam.Append(", ")

                                    ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                                    cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                                    m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                                End If

                            Next csDataColumn

                            ' UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                            m_strUpdateSQL += csUpdateParam.ToString.TrimEnd(" ".ToCharArray()).TrimEnd(",".ToCharArray())

                            ' UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                            m_strUpdateSQL += csWhere.ToString

                            ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUMINCD
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUMINJUTOGAIKB
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_KOSHINCOUNTER
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
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
                            csWhere.Append(ABAtenaEntity.JUMINCD)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaEntity.KEY_JUMINCD)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaEntity.JUMINJUTOGAIKB)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaEntity.KEY_JUMINJUTOGAIKB)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaEntity.KOSHINCOUNTER)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaEntity.KEY_KOSHINCOUNTER)


                            ' ˜_—DELETE SQL•¶‚Ìì¬
                            csDelRonriParam = New StringBuilder
                            csDelRonriParam.Append("UPDATE ")
                            csDelRonriParam.Append(ABAtenaEntity.TABLE_NAME)
                            csDelRonriParam.Append(" SET ")
                            csDelRonriParam.Append(ABAtenaEntity.TANMATSUID)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABAtenaEntity.PARAM_TANMATSUID)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABAtenaEntity.SAKUJOFG)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABAtenaEntity.PARAM_SAKUJOFG)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABAtenaEntity.KOSHINCOUNTER)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABAtenaEntity.PARAM_KOSHINCOUNTER)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABAtenaEntity.KOSHINNICHIJI)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABAtenaEntity.PARAM_KOSHINNICHIJI)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABAtenaEntity.KOSHINUSER)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABAtenaEntity.PARAM_KOSHINUSER)
                            csDelRonriParam.Append(csWhere)
                            ' Where•¶‚Ì’Ç‰Á
                            m_strDelRonriSQL = csDelRonriParam.ToString

                            ' ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDelRonriUFParameterCollectionClass = New UFParameterCollectionClass

                            ' ˜_—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_TANMATSUID
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_SAKUJOFG
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_KOSHINCOUNTER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_KOSHINNICHIJI
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_KOSHINUSER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUMINCD
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUMINJUTOGAIKB
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_KOSHINCOUNTER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
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
                            csWhere.Append(ABAtenaEntity.JUMINCD)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaEntity.KEY_JUMINCD)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaEntity.JUMINJUTOGAIKB)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaEntity.KEY_JUMINJUTOGAIKB)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaEntity.KOSHINCOUNTER)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaEntity.KEY_KOSHINCOUNTER)

                            ' •¨—DELETE SQL•¶‚Ìì¬
                            m_strDelButuriSQL = "DELETE FROM " + ABAtenaEntity.TABLE_NAME + csWhere.ToString

                            ' •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDelButuriUFParameterCollectionClass = New UFParameterCollectionClass

                            ' •¨—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUMINCD
                            m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUMINJUTOGAIKB
                            m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_KOSHINCOUNTER
                            m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
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

                    End Sub
                    '* —š—ð”Ô† 000018 2005/05/23 ’Ç‰ÁI—¹

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     WHERE•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\@@    @@WHERE•ª‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Function CreateWhere(ByVal cSearchKey As ABAtenaSearchKey) As String
                        Const THIS_METHOD_NAME As String = "CreateWhere"
                        Dim csWHERE As StringBuilder
                        Dim cfUFParameterClass As UFParameterClass
                        Dim strWhereHyojun As String
                        Dim strWhereFzy As String

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SELECTƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfSelectUFParameterCollectionClass = New UFParameterCollectionClass

                            ' WHERE‹å‚Ìì¬
                            '* —š—ð”Ô† 000017 2005/01/25 XVŠJŽni‹{‘òj
                            'csWHERE = New StringBuilder()
                            csWHERE = New StringBuilder(256)
                            '* —š—ð”Ô† 000017 2005/01/25 XVI—¹

                            ' Z–¯ƒR[ƒh
                            If Not (cSearchKey.p_strJuminCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                '*—š—ð”Ô† 000013 2003/11/18 C³ŠJŽn
                                'csWHERE.Append(ABAtenaEntity.JUMINCD)
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD)
                                '*—š—ð”Ô† 000013 2003/11/18 C³I—¹
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_JUMINCD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUMINCD
                                cfUFParameterClass.Value = cSearchKey.p_strJuminCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' Z–¯—Dæ‹æ•ª
                            If Not (cSearchKey.p_strJuminYuseniKB.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINYUSENIKB)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_JUMINYUSENIKB)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUMINYUSENIKB
                                cfUFParameterClass.Value = cSearchKey.p_strJuminYuseniKB

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' Z“oŠO—Dæ‹æ•ª
                            If Not (cSearchKey.p_strJutogaiYusenKB.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUTOGAIYUSENKB)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_JUTOGAIYUSENKB)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUTOGAIYUSENKB
                                cfUFParameterClass.Value = cSearchKey.p_strJutogaiYusenKB

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ¢‘ÑƒR[ƒh
                            If Not (cSearchKey.p_strStaiCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.STAICD)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_STAICD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_STAICD
                                cfUFParameterClass.Value = cSearchKey.p_strStaiCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            '*—š—ð”Ô† 000032 2020/01/10 C³ŠJŽn
                            '' ŒŸõ—pƒJƒi©–¼
                            'If Not (cSearchKey.p_strSearchKanaSeiMei.Trim = String.Empty) Then
                            '    If Not (csWHERE.Length = 0) Then
                            '        csWHERE.Append(" AND ")
                            '    End If

                            '    If cSearchKey.p_strSearchKanaSeiMei.IndexOf("%") = -1 Then
                            '        csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEARCHKANASEIMEI)
                            '        csWHERE.Append(" = ")
                            '        csWHERE.Append(ABAtenaEntity.KEY_SEARCHKANASEIMEI)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEIMEI
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanaSeiMei
                            '    Else
                            '        csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEARCHKANASEIMEI)
                            '        csWHERE.Append(" LIKE ")
                            '        csWHERE.Append(ABAtenaEntity.KEY_SEARCHKANASEIMEI)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEIMEI
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanaSeiMei.TrimEnd
                            '    End If
                            '    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            'End If

                            '' ŒŸõ—pƒJƒi©
                            'If Not (cSearchKey.p_strSearchKanaSei.Trim = String.Empty) Then
                            '    If Not (csWHERE.Length = 0) Then
                            '        csWHERE.Append(" AND ")
                            '    End If
                            '    '* —š—ð”Ô† 000024 2007/10/10 ’Ç‰ÁŠJŽn
                            '    ' ŠO‘l–{–¼—DæŒŸõ ORðŒŒŸõ‚·‚é‚½‚ß‚ÉŠ‡ŒÊ‚Å‚­‚­‚é
                            '    If (cSearchKey.p_strSearchKanaSei2.Trim() <> String.Empty) Then
                            '        csWHERE.Append(" ( ")
                            '    End If
                            '    '* —š—ð”Ô† 000024 2007/10/10 ’Ç‰ÁI—¹
                            '    If cSearchKey.p_strSearchKanaSei.IndexOf("%") = -1 Then
                            '        csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEARCHKANASEI)
                            '        csWHERE.Append(" = ")
                            '        csWHERE.Append(ABAtenaEntity.KEY_SEARCHKANASEI)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEI
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanaSei

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '        m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '    Else
                            '        csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEARCHKANASEI)
                            '        csWHERE.Append(" LIKE ")
                            '        csWHERE.Append(ABAtenaEntity.KEY_SEARCHKANASEI)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEI
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanaSei.TrimEnd

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '        m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '    End If
                            'End If

                            ''* —š—ð”Ô† 000024 2007/10/10 ’Ç‰ÁŠJŽn
                            '' ŒŸõ—pƒJƒi©‚Q‚ðORðŒ‚Å’Ç‰Á
                            '' ŒŸõƒJƒi©‚Q‚ÉŒŸõƒL[‚ªŠi”[‚³‚ê‚Ä‚¢‚éê‡‚ÍŒŸõðŒ‚Æ‚µ‚Ä’Ç‰Á
                            'If ((cSearchKey.p_strSearchKanaSei2.Trim() <> String.Empty)) Then
                            '    csWHERE.Append(" OR ")
                            '    If cSearchKey.p_strSearchKanaSei2.IndexOf("%") = -1 Then
                            '        csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEARCHKANASEI)
                            '        csWHERE.Append(" = ")
                            '        csWHERE.Append(ABAtenaEntity.KEY_SEARCHKANASEI2)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEI2
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanaSei2

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '        m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '    Else
                            '        csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEARCHKANASEI)
                            '        csWHERE.Append(" LIKE ")
                            '        csWHERE.Append(ABAtenaEntity.KEY_SEARCHKANASEI2)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEI2
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanaSei2.TrimEnd

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '        m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '    End If
                            '    ' ORðŒ‚ÍŒŸõ—pƒJƒi©‚Ì‚Ý‚Å‚ÌðŒ‚È‚Ì‚ÅŠ‡ŒÊ‚ÅŠ‡‚é
                            '    csWHERE.Append(" ) ")
                            'End If
                            ''* —š—ð”Ô† 000024 2007/10/10 ’Ç‰ÁI—¹

                            '' ŒŸõ—pƒJƒi–¼
                            'If Not (cSearchKey.p_strSearchKanaMei.Trim = String.Empty) Then
                            '    If Not (csWHERE.Length = 0) Then
                            '        csWHERE.Append(" AND ")
                            '    End If
                            '    If cSearchKey.p_strSearchKanaMei.IndexOf("%") = -1 Then
                            '        csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEARCHKANAMEI)
                            '        csWHERE.Append(" = ")
                            '        csWHERE.Append(ABAtenaEntity.KEY_SEARCHKANAMEI)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_SEARCHKANAMEI
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanaMei

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '        m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '    Else
                            '        csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEARCHKANAMEI)
                            '        csWHERE.Append(" LIKE ")
                            '        csWHERE.Append(ABAtenaEntity.KEY_SEARCHKANAMEI)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_SEARCHKANAMEI
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanaMei.TrimEnd

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '        m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '    End If
                            'End If

                            '' ŒŸõ—pŠ¿Žš–¼Ì
                            'If Not (cSearchKey.p_strSearchKanjiMeisho.Trim = String.Empty) Then
                            '    If Not (csWHERE.Length = 0) Then
                            '        csWHERE.Append(" AND ")
                            '    End If
                            '    If cSearchKey.p_strSearchKanjiMeisho.IndexOf("%") = -1 Then
                            '        csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEARCHKANJIMEISHO)
                            '        csWHERE.Append(" = ")
                            '        csWHERE.Append(ABAtenaEntity.PARAM_SEARCHKANJIMEISHO)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_SEARCHKANJIMEISHO
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanjiMeisho

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '        m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '    Else
                            '        csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEARCHKANJIMEISHO)
                            '        csWHERE.Append(" LIKE ")
                            '        csWHERE.Append(ABAtenaEntity.PARAM_SEARCHKANJIMEISHO)

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '        cfUFParameterClass = New UFParameterClass
                            '        cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_SEARCHKANJIMEISHO
                            '        cfUFParameterClass.Value = cSearchKey.p_strSearchKanjiMeisho.TrimEnd

                            '        ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '        m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '    End If
                            'End If

                            ''* —š—ð”Ô† 000023 2007/09/03 ’Ç‰ÁŠJŽn
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
                            ''* —š—ð”Ô† 000023 2007/09/03 ’Ç‰ÁI—¹

                            ' Ž–¼ŒŸõðŒ‚ð¶¬
                            m_cKensakuShimeiB.CreateWhereForShimei(cSearchKey, ABAtenaEntity.TABLE_NAME, csWHERE, m_cfSelectUFParameterCollectionClass,
                                                                   ABAtenaFZYHyojunEntity.TABLE_NAME)
                            '*—š—ð”Ô† 000032 2020/01/10 C³I—¹

                            ' ¶”NŒŽ“ú
                            If Not (cSearchKey.p_strUmareYMD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                If cSearchKey.p_strUmareYMD.RIndexOf("%") = -1 Then
                                    csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.UMAREYMD)
                                    csWHERE.Append(" = ")
                                    csWHERE.Append(ABAtenaEntity.KEY_UMAREYMD)

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                    cfUFParameterClass = New UFParameterClass
                                    cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_UMAREYMD
                                    cfUFParameterClass.Value = cSearchKey.p_strUmareYMD

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                                Else
                                    csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.UMAREYMD)
                                    csWHERE.Append(" LIKE ")
                                    csWHERE.Append(ABAtenaEntity.KEY_UMAREYMD)

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                    cfUFParameterClass = New UFParameterClass
                                    cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_UMAREYMD
                                    cfUFParameterClass.Value = cSearchKey.p_strUmareYMD.TrimEnd

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                                End If

                            End If

                            ' «•Ê
                            If Not (cSearchKey.p_strSeibetsuCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEIBETSUCD)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_SEIBETSUCD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_SEIBETSUCD
                                cfUFParameterClass.Value = cSearchKey.p_strSeibetsuCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ZŠƒR[ƒh
                            If Not (cSearchKey.p_strJushoCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUSHOCD)
                                '* —š—ð”Ô† 000019 2005/07/11 C³ŠJŽn
                                '*********************************************************
                                '*** ZŠCD‚©‘S‘ZŠCD‚©‚Ì”»’è‚µ‚ÄAWhere•¶‚ðì¬‚·‚é ***
                                '*********************************************************
                                'csWHERE.Append(" = ")
                                'csWHERE.Append(ABAtenaEntity.KEY_JUSHOCD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUSHOCD

                                If (cSearchKey.p_strJushoCD.Trim.RLength = 11 AndAlso
                                    cSearchKey.p_strJushoCD.RRemove(0, 2) = "000000000") Then
                                    ' 11Œ…‚Å ŠŽ‚Â ‰º9Œ…‚ª"0"‚Ì‚Æ‚«Aã2Œ…‚Å‚ ‚¢‚Ü‚¢ŒŸõ
                                    csWHERE.Append(" LIKE ")
                                    csWHERE.Append(ABAtenaEntity.KEY_JUSHOCD)
                                    cfUFParameterClass.Value = cSearchKey.p_strJushoCD.RSubstring(0, 2) + "%"
                                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)

                                ElseIf (cSearchKey.p_strJushoCD.Trim.RLength = 11 AndAlso
                                        cSearchKey.p_strJushoCD.RRemove(0, 5) = "000000") Then
                                    ' 11Œ…‚Å ŠŽ‚Â ‰º6Œ…‚ª"0"‚Ì‚Æ‚«Aã5Œ…‚Å‚ ‚¢‚Ü‚¢ŒŸõ
                                    csWHERE.Append(" LIKE ")
                                    csWHERE.Append(ABAtenaEntity.KEY_JUSHOCD)
                                    cfUFParameterClass.Value = cSearchKey.p_strJushoCD.RSubstring(0, 5) + "%"
                                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                                ElseIf (cSearchKey.p_strJushoCD.Trim.RLength = 11 AndAlso
                                        cSearchKey.p_strJushoCD.RRemove(0, 8) = "000") Then
                                    ' 11Œ…‚Å ŠŽ‚Â ‰º3Œ…‚ª"0"‚Ì‚Æ‚«Aã8Œ…‚Å‚ ‚¢‚Ü‚¢ŒŸõ
                                    csWHERE.Append(" LIKE ")
                                    csWHERE.Append(ABAtenaEntity.KEY_JUSHOCD)
                                    cfUFParameterClass.Value = cSearchKey.p_strJushoCD.RSubstring(0, 8) + "%"
                                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                                Else
                                    ' 13Œ…‚ÅŒŸõ
                                    csWHERE.Append(" = ")
                                    csWHERE.Append(ABAtenaEntity.KEY_JUSHOCD)
                                    If (cSearchKey.p_strJushoCD.Trim.RLength = 11) Then
                                        cfUFParameterClass.Value = cSearchKey.p_strJushoCD.RPadRight(13)
                                    Else
                                        cfUFParameterClass.Value = cSearchKey.p_strJushoCD.RPadLeft(13)
                                    End If

                                    '' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                    'cfUFParameterClass = New UFParameterClass()
                                    'cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUSHOCD
                                    'cfUFParameterClass.Value = cSearchKey.p_strJushoCD
                                    '* —š—ð”Ô† 000019 2005/07/11 C³I—¹

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                                End If
                            End If

                            ' s­‹æƒR[ƒh
                            If Not (cSearchKey.p_strGyoseikuCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.GYOSEIKUCD)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_GYOSEIKUCD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_GYOSEIKUCD
                                cfUFParameterClass.Value = cSearchKey.p_strGyoseikuCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ’n‹æƒR[ƒh‚P
                            If Not (cSearchKey.p_strChikuCD1.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CHIKUCD1)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.PARAM_CHIKUCD1)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_CHIKUCD1
                                cfUFParameterClass.Value = cSearchKey.p_strChikuCD1

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ’n‹æƒR[ƒh‚Q
                            If Not (cSearchKey.p_strChikuCD2.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CHIKUCD2)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.PARAM_CHIKUCD2)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_CHIKUCD2
                                cfUFParameterClass.Value = cSearchKey.p_strChikuCD2

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ’n‹æƒR[ƒh‚R
                            If Not (cSearchKey.p_strChikuCD3.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CHIKUCD3)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.PARAM_CHIKUCD3)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_CHIKUCD3
                                cfUFParameterClass.Value = cSearchKey.p_strChikuCD3

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ”Ô’nƒR[ƒh‚P
                            If Not (cSearchKey.p_strBanchiCD1.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.BANCHICD1)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_BANCHICD1)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_BANCHICD1
                                cfUFParameterClass.Value = cSearchKey.p_strBanchiCD1

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ”Ô’nƒR[ƒh‚Q
                            If Not (cSearchKey.p_strBanchiCD2.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.BANCHICD2)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_BANCHICD2)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_BANCHICD2
                                cfUFParameterClass.Value = cSearchKey.p_strBanchiCD2

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ”Ô’nƒR[ƒh‚R
                            If Not (cSearchKey.p_strBanchiCD3.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.BANCHICD3)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_BANCHICD3)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_BANCHICD3
                                cfUFParameterClass.Value = cSearchKey.p_strBanchiCD3

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ZŠîZŠƒR[ƒh
                            If Not (cSearchKey.p_strJukiJushoCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIJUSHOCD)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_JUKIJUSHOCD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUKIJUSHOCD
                                cfUFParameterClass.Value = cSearchKey.p_strJukiJushoCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ZŠîs­‹æƒR[ƒh
                            If Not (cSearchKey.p_strJukiGyoseikuCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIGYOSEIKUCD)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_JUKIGYOSEIKUCD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUKIGYOSEIKUCD
                                cfUFParameterClass.Value = cSearchKey.p_strJukiGyoseikuCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ZŠî’n‹æƒR[ƒh‚P
                            If Not (cSearchKey.p_strJukiChikuCD1.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKICHIKUCD1)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.PARAM_JUKICHIKUCD1)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_JUKICHIKUCD1
                                cfUFParameterClass.Value = cSearchKey.p_strJukiChikuCD1

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ZŠî’n‹æƒR[ƒh‚Q
                            If Not (cSearchKey.p_strJukiChikuCD2.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKICHIKUCD2)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.PARAM_JUKICHIKUCD2)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_JUKICHIKUCD2
                                cfUFParameterClass.Value = cSearchKey.p_strJukiChikuCD2

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ZŠî’n‹æƒR[ƒh‚R
                            If Not (cSearchKey.p_strJukiChikuCD3.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKICHIKUCD3)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.PARAM_JUKICHIKUCD3)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_JUKICHIKUCD3
                                cfUFParameterClass.Value = cSearchKey.p_strJukiChikuCD3

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ZŠî”Ô’nƒR[ƒh‚P
                            If Not (cSearchKey.p_strJukiBanchiCD1.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIBANCHICD1)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_JUKIBANCHICD1)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUKIBANCHICD1
                                cfUFParameterClass.Value = cSearchKey.p_strJukiBanchiCD1

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ZŠî”Ô’nƒR[ƒh‚Q
                            If Not (cSearchKey.p_strJukiBanchiCD2.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIBANCHICD2)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_JUKIBANCHICD2)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUKIBANCHICD2
                                cfUFParameterClass.Value = cSearchKey.p_strJukiBanchiCD2

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ZŠî”Ô’nƒR[ƒh‚R
                            If Not (cSearchKey.p_strJukiBanchiCD3.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIBANCHICD3)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_JUKIBANCHICD3)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUKIBANCHICD3
                                cfUFParameterClass.Value = cSearchKey.p_strJukiBanchiCD3

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ƒf[ƒ^‹æ•ª
                            If Not (cSearchKey.p_strDataKB.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                '*—š—ð”Ô† 000013 2003/11/18 C³ŠJŽn
                                'csWHERE.Append(ABAtenaEntity.ATENADATAKB)
                                'csWHERE.Append(" = ")
                                'csWHERE.Append(ABAtenaEntity.PARAM_ATENADATAKB)

                                If cSearchKey.p_strDataKB.RIndexOf("%") = -1 Then
                                    csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ATENADATAKB)
                                    csWHERE.Append(" = ")
                                    csWHERE.Append(ABAtenaEntity.PARAM_ATENADATAKB)
                                Else
                                    csWHERE.Append(ABAtenaEntity.ATENADATAKB)
                                    csWHERE.Append(" LIKE ")
                                    csWHERE.Append(ABAtenaEntity.PARAM_ATENADATAKB)

                                End If
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_ATENADATAKB
                                cfUFParameterClass.Value = cSearchKey.p_strDataKB

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)

                                '*—š—ð”Ô† 000013 2003/11/18 C³I—¹

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            End If

                            If Not ((cSearchKey.p_strJuminShubetu1 = String.Empty) And (cSearchKey.p_strJuminShubetu2 = String.Empty)) Then
                                If (cSearchKey.p_strDataKB.Trim = String.Empty) Then
                                    If Not (csWHERE.RLength = 0) Then
                                        csWHERE.Append(" AND ")
                                    End If
                                    csWHERE.Append("((")
                                    csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ATENADATAKB)
                                    csWHERE.Append(" = '11')")
                                    csWHERE.Append(" OR (")
                                    csWHERE.Append(ABAtenaEntity.ATENADATAKB)
                                    csWHERE.Append(" = '12'))")
                                End If

                                'Z–¯Ží•Ê‚P
                                If Not (cSearchKey.p_strJuminShubetu1.Trim = String.Empty) Then
                                    If Not (csWHERE.RLength = 0) Then
                                        csWHERE.Append(" AND ")
                                    End If
                                    csWHERE.Append(" {fn SUBSTRING(")
                                    csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ATENADATASHU)
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
                                    csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ATENADATASHU)
                                    csWHERE.Append(",2,1)} = '")
                                    csWHERE.Append(cSearchKey.p_strJuminShubetu2)
                                    csWHERE.Append("'")
                                End If
                            End If

                            ''ŠúŠÔ”NŒŽ“ú
                            'If Not (strKikanYMD.Trim = String.Empty) Then
                            '    If Not (csWHERE.Length = 0) Then
                            '        csWHERE.Append(" AND ")
                            '    End If
                            '    csWHERE.Append(ABAtenaEntity.RRKST_YMD)
                            '    csWHERE.Append(" <= ")
                            '    csWHERE.Append(ABAtenaEntity.KEY_RRKST_YMD)
                            '    csWHERE.Append(" AND ")
                            '    csWHERE.Append(ABAtenaEntity.RRKED_YMD)
                            '    csWHERE.Append(" >= ")
                            '    csWHERE.Append(ABAtenaEntity.KEY_RRKED_YMD)

                            '    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '    cfUFParameterClass = New UFParameterClass()
                            '    cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_RRKST_YMD
                            '    cfUFParameterClass.Value = strKikanYMD
                            '    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)

                            '    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '    cfUFParameterClass = New UFParameterClass()
                            '    cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_RRKED_YMD
                            '    cfUFParameterClass.Value = strKikanYMD
                            '    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            'End If

                            ' Žs’¬‘ºƒR[ƒh
                            If Not (cSearchKey.p_strShichosonCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                '*—š—ð”Ô† 000013 2003/11/18 C³ŠJŽn
                                'csWHERE.Append(ABAtenaEntity.SHICHOSONCD)
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SHICHOSONCD)
                                '*—š—ð”Ô† 000013 2003/11/18 C³I—¹
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.PARAM_SHICHOSONCD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_SHICHOSONCD
                                cfUFParameterClass.Value = cSearchKey.p_strShichosonCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            '*—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
                            ' ---------------------------------------------------------------------------------------------------------
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
                                    csWHERE.AppendFormat("{0}.{1} ", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD)
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
                                                         ABAtenaEntity.TABLE_NAME, ABAtenaEntity.KJNHJNKB,
                                                         ABAtenaEntity.PARAM_KJNHJNKB)

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^[‚ðì¬
                                    cfUFParameterClass = New UFParameterClass
                                    cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_KJNHJNKB
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
                            ' ---------------------------------------------------------------------------------------------------------
                            '*—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

                            ' “d˜b”Ô†
                            If Not (cSearchKey.p_strRenrakusaki.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append("((")
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.RENRAKUSAKI1)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.PARAM_RENRAKUSAKI1)
                                csWHERE.Append(") OR (")
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.RENRAKUSAKI2)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.PARAM_RENRAKUSAKI2)
                                csWHERE.Append("))")

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_RENRAKUSAKI1
                                cfUFParameterClass.Value = cSearchKey.p_strRenrakusaki

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_RENRAKUSAKI2
                                cfUFParameterClass.Value = cSearchKey.p_strRenrakusaki

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            'ˆ¶–¼•W€
                            strWhereHyojun = Me.CreateWhereHyojun(cSearchKey)
                            If (strWhereHyojun.RLength > 0) Then

                                If (csWHERE.RLength > 0) Then
                                    csWHERE.Append(" AND ")
                                Else
                                    ' noop
                                End If

                                csWHERE.AppendFormat("{0}.{1} IN (", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD)
                                csWHERE.AppendFormat("SELECT {0}.{1} FROM {0}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUMINCD)
                                csWHERE.AppendFormat(" WHERE {0}", strWhereHyojun)
                                csWHERE.Append(")")
                            Else
                                ' noop
                            End If

                            'ˆ¶–¼•t
                            strWhereFzy = Me.CreateWhereFZY(cSearchKey)
                            If (strWhereFzy.RLength > 0) Then

                                If (csWHERE.RLength > 0) Then
                                    csWHERE.Append(" AND ")
                                Else
                                    ' noop
                                End If

                                csWHERE.AppendFormat("{0}.{1} IN (", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD)
                                csWHERE.AppendFormat("SELECT {0}.{1} FROM {0}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUMINCD)
                                csWHERE.AppendFormat(" WHERE {0}", strWhereFzy)
                                csWHERE.Append(")")
                            Else
                                ' noop
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

                        Return csWHERE.ToString

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                    '* 
                    '* \•¶           Private Sub CheckColumnValue(ByVal strColumnName As String, ByVal strValue as String)
                    '* 
                    '* ‹@”\           XVƒf[ƒ^‚Ì®‡«‚ðƒ`ƒFƒbƒN‚·‚éB
                    '* 
                    '* ˆø”           strColumnName As String   : ˆ¶–¼ƒ}ƒXƒ^ƒf[ƒ^ƒZƒbƒg‚Ì€–Ú–¼
                    '* @@           strValue As String        : €–Ú‚É‘Î‰ž‚·‚é’l
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CheckColumnValue(ByVal strColumnName As String, ByVal strValue As String)
                        Const THIS_METHOD_NAME As String = "CheckColumnValue"
                        Const TABLENAME As String = "ˆ¶–¼D"
                        Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì

                        Try
                            ' ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                            'm_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME, strColumnName + "'" + strValue + "'")

                            ' “ú•tƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            If (IsNothing(m_cfDateClass)) Then
                                m_cfDateClass = New UFDateClass(m_cfConfigDataClass)
                                ' “ú•tƒNƒ‰ƒX‚Ì•K—v‚ÈÝ’è‚ðs‚¤
                                m_cfDateClass.p_enDateSeparator = UFDateSeparator.None
                            End If


                            Select Case strColumnName.ToUpper()

                                Case ABAtenaEntity.JUMINCD
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUMINCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.SHICHOSONCD
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SHICHOSONCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KYUSHICHOSONCD
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KYUSHICHOSONCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUMINJUTOGAIKB
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUMINJUTOGAIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUMINYUSENIKB
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUMINYUSENIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUTOGAIYUSENKB
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUTOGAIYUSENKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.ATENADATAKB
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_ATENADATAKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.STAICD
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_STAICD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUMINHYOCD               'Z–¯•[ƒR[ƒh
                                    'ƒ`ƒFƒbƒN‚È‚µ

                                Case ABAtenaEntity.SEIRINO                  '®—”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SEIRINO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.ATENADATASHU             'ˆ¶–¼ƒf[ƒ^Ží•Ê
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_ATENADATASHU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.HANYOKB1                 '”Ä—p‹æ•ª1
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_HANYOKB1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KJNHJNKB                 'ŒÂl–@l‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KJNHJNKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.HANYOKB2                 '”Ä—p‹æ•ª2
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_HANYOKB2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KANNAIKANGAIKB           'ŠÇ“àŠÇŠO‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KANNAIKANGAIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KANAMEISHO1              'ƒJƒi–¼Ì1
                                    '*—š—ð”Ô† 000012 2003/10/30 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKataKana(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '*—š—ð”Ô† 000012 2003/10/30 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KANAMEISHO1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KANJIMEISHO1             'Š¿Žš–¼Ì1
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KANJIMEISHO1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KANAMEISHO2              'ƒJƒi–¼Ì2
                                    '*—š—ð”Ô† 000012 2003/10/30 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKataKana(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '*—š—ð”Ô† 000012 2003/10/30 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KANAMEISHO2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KANJIMEISHO2             'Š¿Žš–¼Ì2
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KANJIMEISHO2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KANJIHJNKEITAI           'Š¿Žš–@lŒ`‘Ô
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KANJIHJNKEITAI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KANJIHJNDAIHYOSHSHIMEI   'Š¿Žš–@l‘ã•\ŽÒŽ–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KANJIHJNDAIHYOSHSHIMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.SEARCHKANJIMEISHO        'ŒŸõ—pŠ¿Žš–¼Ì
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SEARCHKANJIMEISHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KYUSEI                   '‹Œ©
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KYUSEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.SEARCHKANASEIMEI         'ŒŸõ—pƒJƒi©–¼
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾(‰p”ŽšE”¼ŠpƒJƒi€–Ú“ü—Í‚ÌŒë‚è‚Å‚·BF)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002017)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "ŒŸõ—pƒJƒi©–¼", objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.SEARCHKANASEI            'ŒŸõ—pƒJƒi©
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾(‰p”ŽšE”¼ŠpƒJƒi€–Ú“ü—Í‚ÌŒë‚è‚Å‚·BF)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002017)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "ŒŸõ—pƒJƒi©", objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.SEARCHKANAMEI            'ŒŸõ—pƒJƒi–¼
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾(‰p”ŽšE”¼ŠpƒJƒi€–Ú“ü—Í‚ÌŒë‚è‚Å‚·BF)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002017)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "ŒŸõ—pƒJƒi–¼", objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKIRRKNO                'ZŠî—š—ð”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKIRRKNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.RRKST_YMD                '—š—ðŠJŽn”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_RRKST_YMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.RRKED_YMD                '—š—ðI—¹”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000" Or strValue = "99999999") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_RRKED_YMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                    'Case ABAtenaEntity.UMAREYMD                 '¶”NŒŽ“ú
                                    '    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                    '        m_cfDateClass.p_strDateValue = strValue
                                    '        If (Not m_cfDateClass.CheckDate()) Then
                                    '            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                    '            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    '            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_UMAREYMD)
                                    '            '—áŠO‚ð¶¬
                                    '            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    '        End If
                                    '    End If

                                    'Case ABAtenaEntity.UMAREWMD                 '¶˜a—ï”NŒŽ“ú
                                    '    If (Not UFStringClass.CheckNumber(strValue)) Then
                                    '        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                    '        'ƒGƒ‰[’è‹`‚ðŽæ“¾(”Žš€–Ú“ü—Í‚ÌŒë‚è‚Å‚·BF)
                                    '        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002013)
                                    '        '—áŠO‚ð¶¬
                                    '        Throw New UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "¶˜a—ï”NŒŽ“ú", objErrorStruct.m_strErrorCode)
                                    '    End If

                                Case ABAtenaEntity.SEIBETSUCD               '«•ÊƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SEIBETSUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.SEIBETSU                 '«•Ê
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SEIBETSU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.SEKINO                   'Ð”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SEKINO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUMINHYOHYOJIJUN         'Z–¯•[•\Ž¦‡
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUMINHYOHYOJIJUN)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.ZOKUGARACD               '‘±•¿ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue.TrimEnd)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_ZOKUGARACD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.ZOKUGARA                 '‘±•¿
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_ZOKUGARA)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.DAI2JUMINHYOHYOJIJUN     '‘æ‚QZ–¯•[•\Ž¦‡
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_DAI2JUMINHYOHYOJIJUN)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.DAI2ZOKUGARACD           '‘æ‚Q‘±•¿ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue.TrimEnd)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_DAI2ZOKUGARACD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.DAI2ZOKUGARA             '‘æ‚Q‘±•¿
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_DAI2ZOKUGARA)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.STAINUSJUMINCD           '¢‘ÑŽåZ–¯ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_STAINUSJUMINCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.STAINUSMEI               '¢‘ÑŽå–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_STAINUSMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KANASTAINUSMEI           'ƒJƒi¢‘ÑŽå–¼
                                    '*—š—ð”Ô† 000012 2003/10/30 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKataKana(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '*—š—ð”Ô† 000012 2003/10/30 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KANASTAINUSMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.DAI2STAINUSJUMINCD       '‘æ‚Q¢‘ÑŽåZ–¯ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_DAI2STAINUSJUMINCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.DAI2STAINUSMEI           '‘æ‚Q¢‘ÑŽå–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_DAI2STAINUSMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KANADAI2STAINUSMEI       '‘æ‚QƒJƒi¢‘ÑŽå–¼
                                    '*—š—ð”Ô† 000012 2003/10/30 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKataKana(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '*—š—ð”Ô† 000012 2003/10/30 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KANADAI2STAINUSMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.YUBINNO                  '—X•Ö”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_YUBINNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUSHOCD                  'ZŠƒR[ƒh
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUSHOCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUSHO                    'ZŠ
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUSHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.BANCHICD1                '”Ô’nƒR[ƒh1
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_BANCHICD1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.BANCHICD2                '”Ô’nƒR[ƒh2
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_BANCHICD2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.BANCHICD3                '”Ô’nƒR[ƒh3
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_BANCHICD3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.BANCHI                   '”Ô’n
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_BANCHI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KATAGAKIFG               '•û‘ƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KATAGAKIFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KATAGAKICD               '•û‘ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KATAGAKICD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KATAGAKI                 '•û‘
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KATAGAKI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.RENRAKUSAKI1             '˜A—æ1
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_RENRAKUSAKI1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.RENRAKUSAKI2             '˜A—æ2
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_RENRAKUSAKI2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.HON_ZJUSHOCD             '–{Ð‘S‘ZŠƒR[ƒh
                                    '* —š—ð”Ô† 000015 2004/10/19 C³ŠJŽniƒ}ƒ‹ƒS‘ºŽRj
                                    'If (Not UFStringClass.CheckNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000015 2004/10/19 C³I—¹iƒ}ƒ‹ƒS‘ºŽRj
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_HON_ZJUSHOCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.HON_JUSHO                '–{ÐZŠ
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_HON_JUSHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.HONSEKIBANCHI            '–{Ð”Ô’n
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_HONSEKIBANCHI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.HITTOSH                  '•M“ªŽÒ
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_HITTOSH)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.CKINIDOYMD               '’¼‹ßˆÙ“®”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_CKINIDOYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.CKINJIYUCD               '’¼‹ßŽ–—RƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_CKINJIYUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.CKINJIYU                 '’¼‹ßŽ–—R
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_CKINJIYU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.CKINTDKDYMD              '’¼‹ß“Ío”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_CKINTDKDYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.CKINTDKDTUCIKB           '’¼‹ß“Ío’Ê’m‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_CKINTDKDTUCIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TOROKUIDOYMD             '“o˜^ˆÙ“®”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TOROKUIDOYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.TOROKUIDOWMD             '“o˜^ˆÙ“®˜a—ï”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "0000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TOROKUIDOWMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.TOROKUJIYUCD             '“o˜^Ž–—RƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TOROKUJIYUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TOROKUJIYU               '“o˜^Ž–—R
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TOROKUJIYU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TOROKUTDKDYMD            '“o˜^“Ío”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TOROKUTDKDYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.TOROKUTDKDWMD            '“o˜^“Ío˜a—ï”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "0000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TOROKUTDKDWMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.TOROKUTDKDTUCIKB         '“o˜^“Ío’Ê’m‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TOROKUTDKDTUCIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUTEIIDOYMD              'Z’èˆÙ“®”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUTEIIDOYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.JUTEIIDOWMD              'Z’èˆÙ“®˜a—ï”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "0000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUTEIIDOWMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.JUTEIJIYUCD              'Z’èŽ–—RƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUTEIJIYUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUTEIJIYU                'Z’èŽ–—R
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUTEIJIYU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUTEITDKDYMD             'Z’è“Ío”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUTEITDKDYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.JUTEITDKDWMD             'Z’è“Ío˜a—ï”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "0000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUTEITDKDWMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.JUTEITDKDTUCIKB          'Z’è“Ío’Ê’m‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUTEITDKDTUCIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.SHOJOIDOYMD              'ÁœˆÙ“®”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SHOJOIDOYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.SHOJOJIYUCD              'ÁœŽ–—RƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SHOJOJIYUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.SHOJOJIYU                'ÁœŽ–—R
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SHOJOJIYU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.SHOJOTDKDYMD             'Áœ“Ío”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SHOJOTDKDYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.SHOJOTDKDTUCIKB          'Áœ“Ío’Ê’m‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SHOJOTDKDTUCIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENSHUTSUYOTEIIDOYMD     '“]o—\’è“Ío”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUYOTEIIDOYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.TENSHUTSUKKTIIDOYMD      '“]oŠm’è“Ío”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUKKTIIDOYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.TENSHUTSUKKTITSUCHIYMD   '“]oŠm’è’Ê’m”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUKKTITSUCHIYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.TENSHUTSUNYURIYUCD       '“]o“ü——RƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUNYURIYUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENSHUTSUNYURIYU         '“]o“ü——R
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUNYURIYU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENUMAEJ_YUBINNO         '“]“ü‘O—X•Ö”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENUMAEJ_YUBINNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENUMAEJ_ZJUSHOCD        '“]“ü‘OZŠ‘S‘ZŠƒR[ƒh
                                    '* —š—ð”Ô† 000015 2004/10/19 C³ŠJŽniƒ}ƒ‹ƒS‘ºŽRj
                                    'If (Not UFStringClass.CheckNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000015 2004/10/19 C³I—¹iƒ}ƒ‹ƒS‘ºŽRj
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENUMAEJ_ZJUSHOCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENUMAEJ_JUSHO           '“]“ü‘OZŠZŠ
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENUMAEJ_JUSHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENUMAEJ_BANCHI          '“]“ü‘OZŠ”Ô’n
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENUMAEJ_BANCHI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENUMAEJ_KATAGAKI        '“]“ü‘OZŠ•û‘
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENUMAEJ_KATAGAKI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENUMAEJ_STAINUSMEI      '“]“ü‘OZŠ¢‘ÑŽå–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENUMAEJ_STAINUSMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENSHUTSUYOTEIYUBINNO    '“]o—\’è—X•Ö”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUYOTEIYUBINNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENSHUTSUYOTEIZJUSHOCD   '“]o—\’è‘S‘ZŠƒR[ƒh
                                    '* —š—ð”Ô† 000015 2004/10/19 C³ŠJŽniƒ}ƒ‹ƒS‘ºŽRj
                                    'If (Not UFStringClass.CheckNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000015 2004/10/19 C³I—¹iƒ}ƒ‹ƒS‘ºŽRj
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUYOTEIZJUSHOCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENSHUTSUYOTEIJUSHO      '“]o—\’èZŠ
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUYOTEIJUSHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENSHUTSUYOTEIBANCHI     '“]o—\’è”Ô’n
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUYOTEIBANCHI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENSHUTSUYOTEIKATAGAKI   '“]o—\’è•û‘
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUYOTEIKATAGAKI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENSHUTSUYOTEISTAINUSMEI '“]o—\’è¢‘ÑŽå–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUYOTEISTAINUSMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENSHUTSUKKTIYUBINNO     '“]oŠm’è—X•Ö”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUKKTIYUBINNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENSHUTSUKKTIZJUSHOCD    '“]oŠm’è‘S‘ZŠƒR[ƒh
                                    '* —š—ð”Ô† 000015 2004/10/19 C³ŠJŽniƒ}ƒ‹ƒS‘ºŽRj
                                    'If (Not UFStringClass.CheckNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000015 2004/10/19 C³I—¹iƒ}ƒ‹ƒS‘ºŽRj
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUKKTIZJUSHOCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENSHUTSUKKTIJUSHO    '“]oŠm’èZŠ
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUKKTIJUSHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENSHUTSUKKTIBANCHI      '“]oŠm’è”Ô’n
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUKKTIBANCHI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENSHUTSUKKTIKATAGAKI    '“]oŠm’è•û‘
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUKKTIKATAGAKI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENSHUTSUKKTISTAINUSMEI  '“]oŠm’è¢‘ÑŽå–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUKKTISTAINUSMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TENSHUTSUKKTIMITDKFG     '“]oŠm’èŒ©“Íƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TENSHUTSUKKTIMITDKFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.BIKOYMD                  '”õl”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_BIKOYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.BIKO                     '”õl
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_BIKO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.BIKOTENSHUTSUKKTIJUSHOFG '”õl“]oŠm’èZŠƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_BIKOTENSHUTSUKKTIJUSHOFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.HANNO                    '”Å”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_HANNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KAISEIATOFG              '‰ü»Œãƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KAISEIATOFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KAISEIMAEFG             '‰ü»‘Oƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KAISEIMAEFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KAISEIYMD                '‰ü»”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KAISEIYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.GYOSEIKUCD               's­‹æƒR[ƒh
                                    '* —š—ð”Ô† 000020 2005/12/26 C³ŠJŽn
                                    ''If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        '* —š—ð”Ô† 000020 2005/12/26 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_GYOSEIKUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.GYOSEIKUMEI              's­‹æ–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_GYOSEIKUMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.CHIKUCD1                 '’n‹æƒR[ƒh1
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_CHIKUCD1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.CHIKUMEI1                '’n‹æ–¼1
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_CHIKUMEI1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.CHIKUCD2                 '’n‹æƒR[ƒh2
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_CHIKUCD2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.CHIKUMEI2                '’n‹æ–¼2
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_CHIKUMEI2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.CHIKUCD3                 '’n‹æƒR[ƒh3
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_CHIKUCD3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.CHIKUMEI3                '’n‹æ–¼3
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_CHIKUMEI3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.TOHYOKUCD                '“Š•[‹æƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TOHYOKUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.SHOGAKKOKUCD             '¬ŠwZ‹æƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SHOGAKKOKUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.CHUGAKKOKUCD             '’†ŠwZ‹æƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_CHUGAKKOKUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.HOGOSHAJUMINCD           '•ÛŒìŽÒZ–¯ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_HOGOSHAJUMINCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KANJIHOGOSHAMEI          'Š¿Žš•ÛŒìŽÒ–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KANJIHOGOSHAMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KANAHOGOSHAMEI           'ƒJƒi•ÛŒìŽÒ–¼
                                    '*—š—ð”Ô† 000012 2003/10/30 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKataKana(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '*—š—ð”Ô† 000012 2003/10/30 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KANAHOGOSHAMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KIKAYMD                  '‹A‰»”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KIKAYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.KARIIDOKB                '‰¼ˆÙ“®‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KARIIDOKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.SHORITEISHIKB            'ˆ—’âŽ~‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SHORITEISHIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.SHORIYOKUSHIKB           'ˆ——}Ž~‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SHORIYOKUSHIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKIYUBINNO              'ZŠî—X•Ö”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKIYUBINNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKIJUSHOCD              'ZŠîZŠƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKIJUSHOCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKIJUSHO                'ZŠîZŠ
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKIJUSHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKIBANCHICD1            'ZŠî”Ô’nƒR[ƒh1
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKIBANCHICD1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKIBANCHICD2            'ZŠî”Ô’nƒR[ƒh2
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKIBANCHICD2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKIBANCHICD3            'ZŠî”Ô’nƒR[ƒh3
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKIBANCHICD3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKIBANCHI               'ZŠî”Ô’n
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKIBANCHI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKIKATAGAKIFG           'ZŠî•û‘ƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKIKATAGAKIFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKIKATAGAKICD           'ZŠî•û‘ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKIKATAGAKICD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKIKATAGAKI             'ZŠî•û‘
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKIKATAGAKI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKIGYOSEIKUCD           'ZŠîs­‹æƒR[ƒh
                                    '* —š—ð”Ô† 000020 2005/12/26 C³ŠJŽn
                                    ''If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        '* —š—ð”Ô† 000020 2005/12/26 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKIGYOSEIKUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKIGYOSEIKUMEI          'ZŠîs­‹æ–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKIGYOSEIKUMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKICHIKUCD1             'ZŠî’n‹æƒR[ƒh1
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKICHIKUCD1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKICHIKUMEI1            'ZŠî’n‹æ–¼1
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKICHIKUMEI1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKICHIKUCD2             'ZŠî’n‹æƒR[ƒh2
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKICHIKUCD2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKICHIKUMEI2            'ZŠî’n‹æ–¼2
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKICHIKUMEI2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKICHIKUCD3             'ZŠî’n‹æƒR[ƒh3
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKICHIKUCD3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.JUKICHIKUMEI3            'ZŠî’n‹æ–¼3
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_JUKICHIKUMEI3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KAOKUSHIKIKB             '‰Æ‰®•~‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KAOKUSHIKIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.BIKOZEIMOKU              '”õlÅ–Ú
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_BIKOZEIMOKU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KOKUSEKICD               '‘ÐƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KOKUSEKICD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KOKUSEKI                 '‘Ð
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KOKUSEKI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.ZAIRYUSKAKCD             'Ý—¯Ž‘ŠiƒR[ƒh
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_ZAIRYUSKAKCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.ZAIRYUSKAK               'Ý—¯Ž‘Ši
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_ZAIRYUSKAK)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.ZAIRYUKIKAN              'Ý—¯ŠúŠÔ
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_ZAIRYUKIKAN)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.ZAIRYU_ST_YMD            'Ý—¯ŠJŽn”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_ZAIRYU_ST_YMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.ZAIRYU_ED_YMD            'Ý—¯I—¹”NŒŽ“ú
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_ZAIRYU_ED_YMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABAtenaEntity.RESERCE                  'ƒŠƒU[ƒu
                                    'ƒ`ƒFƒbƒN‚È‚µ

                                Case ABAtenaEntity.TANMATSUID               '’[––‚h‚c
                                    '* —š—ð”Ô† 000010 2003/09/11 C³ŠJŽn
                                    'If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000010 2003/09/11 C³C³
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_TANMATSUID)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.SAKUJOFG                 'íœƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SAKUJOFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KOSHINCOUNTER            'XVƒJƒEƒ“ƒ^
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KOSHINCOUNTER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.SAKUSEINICHIJI           'ì¬“úŽž
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SAKUSEINICHIJI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.SAKUSEIUSER              'ì¬ƒ†[ƒU
                                    '* —š—ð”Ô† 000011 2003/10/09 C³ŠJŽn
                                    'If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000011 2003/10/09 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_SAKUSEIUSER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KOSHINNICHIJI            'XV“úŽž
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KOSHINNICHIJI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABAtenaEntity.KOSHINUSER               'XVƒ†[ƒU
                                    '* —š—ð”Ô† 000011 2003/10/09 C³ŠJŽn
                                    'If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000011 2003/10/09 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAB_RDBDATATYPE_KOSHINUSER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + ":" + strValue, objErrorStruct.m_strErrorCode)
                                    End If

                            End Select

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
                            'm_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException    ' UFAppException‚ðƒLƒƒƒbƒ`
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            'ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
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
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KYUSHICHOSONCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ATENADATAKB).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.STAICD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ATENADATASHU).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.HANYOKB1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KJNHJNKB).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.HANYOKB2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANNAIKANGAIKB).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANAMEISHO1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANJIMEISHO1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANAMEISHO2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANJIMEISHO2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANJIHJNKEITAI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANJIHJNDAIHYOSHSHIMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEARCHKANJIMEISHO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEARCHKANASEIMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEARCHKANASEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEARCHKANAMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.UMAREYMD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.UMAREWMD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEIBETSUCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEIBETSU).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SEKINO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINHYOHYOJIJUN).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ZOKUGARACD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ZOKUGARA).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.DAI2JUMINHYOHYOJIJUN).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.DAI2ZOKUGARACD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.DAI2ZOKUGARA).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.STAINUSJUMINCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.STAINUSMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANASTAINUSMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.DAI2STAINUSJUMINCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.DAI2STAINUSMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANADAI2STAINUSMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.YUBINNO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUSHOCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUSHO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.BANCHICD1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.BANCHICD2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.BANCHICD3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.BANCHI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KATAGAKIFG).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KATAGAKICD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KATAGAKI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.RENRAKUSAKI1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.RENRAKUSAKI2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TOROKUIDOYMD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TOROKUJIYUCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TOROKUJIYU).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SHOJOIDOYMD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SHOJOJIYUCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SHOJOJIYU).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.GYOSEIKUCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.GYOSEIKUMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CHIKUCD1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CHIKUMEI1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CHIKUCD2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CHIKUMEI2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CHIKUCD3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CHIKUMEI3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIYUBINNO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIJUSHOCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIJUSHO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIBANCHICD1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIBANCHICD2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIBANCHICD3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIBANCHI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIKATAGAKIFG).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIKATAGAKICD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIKATAGAKI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIGYOSEIKUCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIGYOSEIKUMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKICHIKUCD1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKICHIKUMEI1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKICHIKUCD2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKICHIKUMEI2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKICHIKUCD3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKICHIKUMEI3)

                            '*—š—ð”Ô† 000027 2010/05/12 ’Ç‰ÁŠJŽn
                            ' –{Ð•M“ªŽÒî•ñ’Šo”»’è
                            If (m_strHonsekiKB = "1" AndAlso m_strHonsekiHittoshKB_Param = "1") Then
                                ' –{ÐZŠA–{Ð”Ô’nA•M“ªŽÒ‚ð’Šo€–Ú‚ÉƒZƒbƒg‚·‚é
                                strAtenaSQLsb.Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.HON_JUSHO).Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.HONSEKIBANCHI).Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.HITTOSH)
                            Else
                            End If

                            ' ˆ—’âŽ~‹æ•ª’Šo”»’è
                            If (m_strShoriteishiKB = "1" AndAlso m_strShoriteishiKB_Param = "1") Then
                                ' ˆ—’âŽ~‹æ•ª‚ð’Šo€–Ú‚ÉƒZƒbƒg‚·‚é
                                strAtenaSQLsb.Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SHORITEISHIKB)
                            Else
                            End If
                            '*—š—ð”Ô† 000027 2010/05/12 ’Ç‰ÁI—¹

                            '*—š—ð”Ô† 000028 2011/05/18 ’Ç‰ÁŠJŽn
                            If (m_strFrnZairyuJohoKB_Param = "1") Then
                                ' ŠO‘lÝ—¯î•ñ(‘ÐAÝ—¯Ž‘ŠiƒR[ƒhAÝ—¯Ž‘ŠiAÝ—¯ŠúŠÔAÝ—¯ŠJŽn”NŒŽ“úAÝ—¯I—¹”NŒŽ“ú)‚ð’Šo€–Ú‚ÉƒZƒbƒg‚·‚é
                                strAtenaSQLsb.Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KOKUSEKI).Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ZAIRYUSKAKCD).Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ZAIRYUSKAK).Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ZAIRYUKIKAN).Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ZAIRYU_ST_YMD).Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ZAIRYU_ED_YMD)
                            Else
                            End If
                            '*—š—ð”Ô† 000028 2011/05/18 ’Ç‰ÁI—¹
                        Else
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KYUSHICHOSONCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ATENADATAKB).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.STAICD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ATENADATASHU).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.HANYOKB1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KJNHJNKB).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.HANYOKB2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANNAIKANGAIKB).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANAMEISHO1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANJIMEISHO1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANAMEISHO2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANJIMEISHO2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANJIHJNKEITAI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.UMAREYMD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.UMAREWMD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANASTAINUSMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KANADAI2STAINUSMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.YUBINNO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUSHOCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUSHO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.BANCHICD1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.BANCHICD2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.BANCHICD3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.BANCHI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KATAGAKIFG).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KATAGAKICD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KATAGAKI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.RENRAKUSAKI1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.RENRAKUSAKI2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.GYOSEIKUCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.GYOSEIKUMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CHIKUCD1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CHIKUMEI1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CHIKUCD2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CHIKUMEI2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CHIKUCD3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CHIKUMEI3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIYUBINNO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIJUSHOCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIJUSHO).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIBANCHICD1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIBANCHICD2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIBANCHICD3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIBANCHI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIKATAGAKIFG).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIKATAGAKICD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIKATAGAKI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIGYOSEIKUCD).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKIGYOSEIKUMEI).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKICHIKUCD1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKICHIKUMEI1).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKICHIKUCD2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKICHIKUMEI2).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKICHIKUCD3).Append(",")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUKICHIKUMEI3)

                            '*—š—ð”Ô† 000027 2010/05/12 ’Ç‰ÁŠJŽn
                            ' –{Ð•M“ªŽÒî•ñ’Šo”»’è
                            If (m_strHonsekiKB = "1" AndAlso m_strHonsekiHittoshKB_Param = "1") Then
                                ' –{ÐZŠA–{Ð”Ô’nA•M“ªŽÒ‚ð’Šo€–Ú‚ÉƒZƒbƒg‚·‚é
                                strAtenaSQLsb.Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.HON_JUSHO).Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.HONSEKIBANCHI).Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.HITTOSH)
                            Else
                            End If

                            ' ˆ—’âŽ~‹æ•ª’Šo”»’è
                            If (m_strShoriteishiKB = "1" AndAlso m_strShoriteishiKB_Param = "1") Then
                                ' ˆ—’âŽ~‹æ•ª‚ð’Šo€–Ú‚ÉƒZƒbƒg‚·‚é
                                strAtenaSQLsb.Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SHORITEISHIKB)
                            Else
                            End If
                            '*—š—ð”Ô† 000027 2010/05/12 ’Ç‰ÁI—¹

                            '*—š—ð”Ô† 000028 2011/05/18 ’Ç‰ÁŠJŽn
                            If (m_strFrnZairyuJohoKB_Param = "1") Then
                                ' ŠO‘lÝ—¯î•ñ(‘ÐAÝ—¯Ž‘ŠiƒR[ƒhAÝ—¯Ž‘ŠiAÝ—¯ŠúŠÔAÝ—¯ŠJŽn”NŒŽ“úAÝ—¯I—¹”NŒŽ“ú)‚ð’Šo€–Ú‚ÉƒZƒbƒg‚·‚é
                                strAtenaSQLsb.Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KOKUSEKI).Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ZAIRYUSKAKCD).Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ZAIRYUSKAK).Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ZAIRYUKIKAN).Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ZAIRYU_ST_YMD).Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ZAIRYU_ED_YMD)
                            Else
                            End If
                            '*—š—ð”Ô† 000028 2011/05/18 ’Ç‰ÁI—¹
                        End If
                        If (Me.m_blnSelectAll = ABEnumDefine.AtenaGetKB.NenkinAll) Then
                            strAtenaSQLsb.Append(",")
                            ' ‹Œ©
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KYUSEI).Append(",")
                            ' Z’èˆÙ“®”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUTEIIDOYMD).Append(",")
                            ' Z’èŽ–—R
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUTEIJIYU).Append(",")
                            ' “]“ü‘OZŠ—X•Ö”Ô†
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENUMAEJ_YUBINNO).Append(",")
                            ' “]“ü‘OZŠ‘S‘ZŠƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENUMAEJ_ZJUSHOCD).Append(",")
                            ' “]“ü‘OZŠZŠ
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENUMAEJ_JUSHO).Append(",")
                            ' “]“ü‘OZŠ”Ô’n
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENUMAEJ_BANCHI).Append(",")
                            ' “]“ü‘OZŠ•û‘
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENUMAEJ_KATAGAKI).Append(",")
                            ' “]o—\’è—X•Ö”Ô†
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUYOTEIYUBINNO).Append(",")
                            ' “]o—\’è‘S‘ZŠƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUYOTEIZJUSHOCD).Append(",")
                            ' “]o—\’èˆÙ“®”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUYOTEIIDOYMD).Append(",")
                            ' “]o—\’èZŠ
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUYOTEIJUSHO).Append(",")
                            ' “]o—\’è”Ô’n
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUYOTEIBANCHI).Append(",")
                            ' “]o—\’è•û‘
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUYOTEIKATAGAKI).Append(",")
                            ' “]oŠm’è—X•Ö”Ô†
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUKKTIYUBINNO).Append(",")
                            ' “]oŠm’è‘S‘ZŠƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUKKTIZJUSHOCD).Append(",")
                            ' “]oŠm’èˆÙ“®”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUKKTIIDOYMD).Append(",")
                            ' “]oŠm’è’Ê’m”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUKKTITSUCHIYMD).Append(",")
                            ' “]oŠm’èZŠ
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUKKTIJUSHO).Append(",")
                            ' “]oŠm’è”Ô’n
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUKKTIBANCHI).Append(",")
                            ' “]oŠm’è•û‘
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUKKTIKATAGAKI).Append(",")

                            ' Áœ“Ío”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SHOJOTDKDYMD).Append(",")
                            ' ’¼‹ßŽ–—RƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CKINJIYUCD).Append(",")

                            ' –{Ð‘S‘ZŠƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.HON_ZJUSHOCD).Append(",")
                            ' “]o—\’è¢‘ÑŽå–¼
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUYOTEISTAINUSMEI).Append(",")
                            ' “]oŠm’è¢‘ÑŽå–¼
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUKKTISTAINUSMEI).Append(",")
                            '*—š—ð”Ô† 000021 2006/07/31 ’Ç‰ÁŠJŽn
                            ' ‘ÐƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KOKUSEKICD).Append(",")
                            ' “]“ü‘OZŠ¢‘ÑŽå–¼
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENUMAEJ_STAINUSMEI)
                            'strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KOKUSEKICD)
                            '*—š—ð”Ô† 000021 2006/07/31 ’Ç‰ÁI—¹

                        End If

                        '*—š—ð”Ô† 000022 2007/04/28 ’Ç‰ÁŠJŽn
                        If m_blnMethodKB = ABEnumDefine.MethodKB.KB_Kaigo Then
                            strAtenaSQLsb.Append(",")
                            ' ‹Œ©
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KYUSEI).Append(",")
                            ' Z’èˆÙ“®”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUTEIIDOYMD).Append(",")
                            ' Z’èŽ–—R
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUTEIJIYU).Append(",")
                            ' “]“ü‘OZŠ—X•Ö”Ô†
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENUMAEJ_YUBINNO).Append(",")
                            ' “]“ü‘OZŠ‘S‘ZŠƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENUMAEJ_ZJUSHOCD).Append(",")
                            ' “]“ü‘OZŠZŠ
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENUMAEJ_JUSHO).Append(",")
                            ' “]“ü‘OZŠ”Ô’n
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENUMAEJ_BANCHI).Append(",")
                            ' “]“ü‘OZŠ•û‘
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENUMAEJ_KATAGAKI).Append(",")
                            ' “]o—\’è—X•Ö”Ô†
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUYOTEIYUBINNO).Append(",")
                            ' “]o—\’è‘S‘ZŠƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUYOTEIZJUSHOCD).Append(",")
                            ' “]o—\’èˆÙ“®”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUYOTEIIDOYMD).Append(",")
                            ' “]o—\’èZŠ
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUYOTEIJUSHO).Append(",")
                            ' “]o—\’è”Ô’n
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUYOTEIBANCHI).Append(",")
                            ' “]o—\’è•û‘
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUYOTEIKATAGAKI).Append(",")
                            ' “]oŠm’è—X•Ö”Ô†
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUKKTIYUBINNO).Append(",")
                            ' “]oŠm’è‘S‘ZŠƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUKKTIZJUSHOCD).Append(",")
                            ' “]oŠm’èˆÙ“®”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUKKTIIDOYMD).Append(",")
                            ' “]oŠm’è’Ê’m”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUKKTITSUCHIYMD).Append(",")
                            ' “]oŠm’èZŠ
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUKKTIJUSHO).Append(",")
                            ' “]oŠm’è”Ô’n
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUKKTIBANCHI).Append(",")
                            ' “]oŠm’è•û‘
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUKKTIKATAGAKI).Append(",")
                            ' Áœ“Ío”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SHOJOTDKDYMD).Append(",")
                            ' ’¼‹ßŽ–—RƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CKINJIYUCD).Append(",")
                            ' –{Ð‘S‘ZŠƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.HON_ZJUSHOCD).Append(",")
                            ' “]o—\’è¢‘ÑŽå–¼
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUYOTEISTAINUSMEI).Append(",")
                            ' “]oŠm’è¢‘ÑŽå–¼
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUKKTISTAINUSMEI).Append(",")
                            ' ‘ÐƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KOKUSEKICD).Append(",")
                            ' “o˜^“Ío”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TOROKUTDKDYMD).Append(",")
                            ' Z’è“Ío”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUTEITDKDYMD).Append(",")
                            ' “]o“ü——R
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.TENSHUTSUNYURIYU).Append(",")
                            ' Žs’¬‘ºƒR[ƒh
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SHICHOSONCD).Append(",")
                            ' ’¼‹ßˆÙ“®”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CKINIDOYMD).Append(",")
                            ' XV“úŽž
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KOSHINNICHIJI)
                        End If
                        '*—š—ð”Ô† 000022 2007/04/28 ’Ç‰ÁI—¹
                        If (m_intHyojunKB = ABEnumDefine.HyojunKB.KB_Hyojun) Then
                            strAtenaSQLsb.Append(",")
                            ' ’¼‹ß“Ío’Ê’m‹æ•ª
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.CKINTDKDTUCIKB).Append(",")
                            ' ”Å”Ô†
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.HANNO).Append(",")
                            ' ‰ü»”NŒŽ“ú
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KAISEIYMD)
                            If (m_blnMethodKB <> ABEnumDefine.MethodKB.KB_Kaigo) AndAlso
                               (m_blnSelectAll <> ABEnumDefine.AtenaGetKB.NenkinAll) Then
                                ' ‘ÐƒR[ƒh
                                strAtenaSQLsb.Append(",")
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.KOKUSEKICD)
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

                        '*—š—ð”Ô† 000025 2008/01/15 ’Ç‰ÁŠJŽn
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
                        '*—š—ð”Ô† 000025 2008/01/15 ’Ç‰ÁI—¹
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
                    '*—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼•tƒf[ƒ^€–Ú•ÒW
                    '* 
                    '* \•¶           Private SetFZYEntity()
                    '* 
                    '* ‹@”\           ˆ¶–¼•tƒf[ƒ^‚Ì€–Ú•ÒW‚ð‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetFZYEntity(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TABLEINSERTKB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.LINKNO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUMINHYOJOTAIKBN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUKYOCHITODOKEFLG)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.HONGOKUMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KANAHONGOKUMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KANJIHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KANAHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KANJITSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KANATSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KATAKANAHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.UMAREFUSHOKBN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TSUSHOMEITOUROKUYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.ZAIRYUKIKANCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.ZAIRYUKIKANMEISHO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.ZAIRYUSHACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.ZAIRYUSHAMEISHO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.ZAIRYUCARDNO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KOFUYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KOFUYOTEISTYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KOFUYOTEIEDYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUKITAISHOSHASHOJOIDOYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYUCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYU)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDTUCIKB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.FRNSTAINUSMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.FRNSTAINUSKANAMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.STAINUSHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.STAINUSKANAHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.STAINUSTSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.STAINUSKANATSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENUMAEJ_STAINUSMEI_KYOTSU)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENUMAEJ_STAINUSHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENUMAEJ_STAINUSTSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENSHUTSUYOTEISTAINUSMEI_KYOTSU)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENSHUTSUYOTEISTAINUSHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENSHUTSUYOTEISTAINUSTSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENSHUTSUKKTISTAINUSMEI_KYOTSU)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENSHUTSUKKTISTAINUSHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENSHUTSUKKTISTAINUSTSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE1)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE2)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE3)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE4)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE5)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE6)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE7)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE8)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE9)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE10)
                    End Sub
                    '*—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
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
                    '*—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                        'Dim cfUFParameterClass As UFParameterClass

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
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME)
                                strAtenaSQLsb.Append(".")
                                strAtenaSQLsb.Append(ABAtenaEntity.JUMINCD)
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
                                strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME)
                                strAtenaSQLsb.Append(".")
                                strAtenaSQLsb.Append(ABAtenaEntity.JUMINCD)
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
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME)
                            strAtenaSQLsb.Append(".")
                            strAtenaSQLsb.Append(ABAtenaEntity.JUMINCD)
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
                        strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD)
                        strAtenaSQLsb.Append("=")
                        strAtenaSQLsb.Append(ABAtenaNenkinEntity.TABLE_NAME).Append(".").Append(ABAtenaNenkinEntity.JUMINCD)

                        ' LEFT OUTER JOIN ABATENAKOKUHO ON ABATENA.JUMINCD=ABATENAKOKUHO.JUMINCD
                        strAtenaSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(" ON ")
                        strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD)
                        strAtenaSQLsb.Append("=")
                        strAtenaSQLsb.Append(ABAtenaKokuhoEntity.TABLE_NAME).Append(".").Append(ABAtenaKokuhoEntity.JUMINCD)

                        ' LEFT OUTER JOIN ABATENAINKAN ON ABATENA.JUMINCD=ABATENAINKAN.JUMINCD
                        strAtenaSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaInkanEntity.TABLE_NAME).Append(" ON ")
                        strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD)
                        strAtenaSQLsb.Append("=")
                        strAtenaSQLsb.Append(ABAtenaInkanEntity.TABLE_NAME).Append(".").Append(ABAtenaInkanEntity.JUMINCD)

                        ' LEFT OUTER JOIN ABATENASENKYO ON ABATENA.JUMINCD=ABATENASENKYO.JUMINCD
                        strAtenaSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaSenkyoEntity.TABLE_NAME).Append(" ON ")
                        strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD)
                        strAtenaSQLsb.Append("=")
                        strAtenaSQLsb.Append(ABAtenaSenkyoEntity.TABLE_NAME).Append(".").Append(ABAtenaSenkyoEntity.JUMINCD)

                        ' LEFT OUTER JOIN ABATENAJITE ON ABATENA.JUMINCD=ABATENAJIDOUTE.JUMINCD
                        strAtenaSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaJiteEntity.TABLE_NAME).Append(" ON ")
                        strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD)
                        strAtenaSQLsb.Append("=")
                        strAtenaSQLsb.Append(ABAtenaJiteEntity.TABLE_NAME).Append(".").Append(ABAtenaJiteEntity.JUMINCD)

                        ' LEFT OUTER JOIN ABATENAKAIGO ON ABATENA.JUMINCD=ABATENAKAIGO.JUMINCD
                        strAtenaSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaKaigoEntity.TABLE_NAME).Append(" ON ")
                        strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD)
                        strAtenaSQLsb.Append("=")
                        strAtenaSQLsb.Append(ABAtenaKaigoEntity.TABLE_NAME).Append(".").Append(ABAtenaKaigoEntity.JUMINCD)

                        '*—š—ð”Ô† 000025 2008/01/15 ’Ç‰ÁŠJŽn
                        If (m_strKobetsuShutokuKB = "1") Then
                            ' ŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ª"1"‚Ìê‡AŒãŠú‚—îŽÒƒ}ƒXƒ^‚àJOIN‚·‚é
                            strAtenaSQLsb.Append(" LEFT OUTER JOIN ").Append(ABAtenaKokiKoreiEntity.TABLE_NAME).Append(" ON ")
                            strAtenaSQLsb.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD)
                            strAtenaSQLsb.Append("=")
                            strAtenaSQLsb.Append(ABAtenaKokiKoreiEntity.TABLE_NAME).Append(".").Append(ABAtenaKokiKoreiEntity.JUMINCD)
                        Else
                            ' ŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ª’l–³‚µ‚Ìê‡Aˆ—‚ðs‚í‚È‚¢
                        End If
                        '*—š—ð”Ô† 000025 2008/01/15 ’Ç‰ÁI—¹
                    End Sub
                    '*—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼•tƒe[ƒuƒ‹JOIN‹åì¬
                    '* 
                    '* \•¶           Private SetFZYJoin()
                    '* 
                    '* ‹@”\           ˆ¶–¼•tƒe[ƒuƒ‹‚ÌJOIN‹å‚ðì¬‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetFZYJoin(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(" LEFT OUTER JOIN {0} ", ABAtenaFZYEntity.TABLE_NAME)
                        strAtenaSQLsb.AppendFormat(" ON {0}.{1} = {2}.{3} ",
                                                    ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD,
                                                    ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUMINCD)
                        strAtenaSQLsb.AppendFormat(" AND {0}.{1} = {2}.{3} ",
                                                    ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINJUTOGAIKB,
                                                    ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUMINJUTOGAIKB)
                    End Sub
                    '*—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
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
                        strAtenaSQLsb.AppendFormat("(SELECT * FROM {0} WHERE {1} = '{2}') AS {0} ",
                                                    ABMyNumberEntity.TABLE_NAME, ABMyNumberEntity.CKINKB, ABMyNumberEntity.DEFAULT.CKINKB.CKIN)
                        strAtenaSQLsb.AppendFormat("ON {0}.{1} = {2}.{3} ",
                                                    ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD,
                                                    ABMyNumberEntity.TABLE_NAME, ABMyNumberEntity.JUMINCD)
                    End Sub
                    '*—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

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
                            m_strHonsekiKB = cABAtenaKanriJoho.GetHonsekiKB_Param

                            ' ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ªŽæ“¾
                            m_strShoriteishiKB = cABAtenaKanriJoho.GetShoriteishiKB_Param

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException    ' UFAppException‚ðƒLƒƒƒbƒ`
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
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw objExp

                        End Try

                    End Sub
                    '*—š—ð”Ô† 000027 2010/05/12 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁŠJŽn
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
                            Else
                                'ˆ—‚È‚µ
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException    ' UFAppException‚ðƒLƒƒƒbƒ`
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
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw objExp

                        End Try
                    End Sub
                    '*—š—ð”Ô† 000029 2011/10/24 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁŠJŽn
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
                    '*—š—ð”Ô† 000030 2014/04/28 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000031 2018/03/08 ’Ç‰ÁŠJŽn
                    ''' <summary>
                    ''' ’ŠoðŒ•¶Žš—ñ‚Ì¶¬
                    ''' </summary>
                    ''' <param name="cSearchKey">ŒŸõƒL[</param>
                    ''' <param name="blnSakujoFG">íœƒtƒ‰ƒO</param>
                    ''' <returns>’ŠoðŒ•¶Žš—ñ</returns>
                    ''' <remarks></remarks>
                    Private Function CreateWhereMain(ByVal cSearchKey As ABAtenaSearchKey, ByVal blnSakujoFG As Boolean) As String

                        Dim THIS_METHOD_NAME As String = Reflection.MethodBase.GetCurrentMethod.Name
                        Dim csWhere As StringBuilder
                        Dim csWhereForRireki As StringBuilder
                        Dim strWhereRirekiHyojun As String
                        Dim strWhereRirekiFZY As String

                        Try

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            '@—š—ðŒŸõ”»’è
                            If (cSearchKey.p_blnIsRirekiSearch = True) Then

                                ' [—š—ðŒŸõ]

                                ' ƒpƒ‰ƒ[ƒ^[ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                                m_cfSelectUFParameterCollectionClass = New UFParameterCollectionClass

                                ' ’¼‹ß‚É‘Î‚·‚é’ŠoðŒ‚ð¶¬
                                csWhere = New StringBuilder(Me.CreateWhereForChokkin(cSearchKey, blnSakujoFG))

                                ' —š—ð‚É‘Î‚·‚é’ŠoðŒ‚ð¶¬
                                csWhereForRireki = New StringBuilder(Me.CreateWhereForRireki(cSearchKey))

                                ' —š—ð‚É‘Î‚·‚é’ŠoðŒ‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡A
                                ' ŠY“–ŽÒ‚ÌZ–¯ƒR[ƒh‚Å’¼‹ß‚ði‚èž‚Þ
                                If (csWhereForRireki.RLength > 0) Then

                                    If (csWhere.RLength > 0) Then
                                        csWhere.Append(" AND ")
                                    Else
                                        ' noop
                                    End If

                                    csWhere.AppendFormat("{0}.{1} IN (", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD)
                                    csWhere.AppendFormat("SELECT {0}.{1} FROM {0}", ABAtenaRirekiEntity.TABLE_NAME, ABAtenaRirekiEntity.JUMINCD)
                                    csWhere.AppendFormat(" WHERE {0}", csWhereForRireki)
                                    csWhere.Append(")")

                                Else
                                    ' noop
                                End If

                                '—š—ð•W€
                                strWhereRirekiHyojun = Me.CreateWhereRirekiHyojun(cSearchKey)
                                If (strWhereRirekiHyojun.RLength > 0) Then

                                    If (csWhere.RLength > 0) Then
                                        csWhere.Append(" AND ")
                                    Else
                                        ' noop
                                    End If

                                    csWhere.AppendFormat("{0}.{1} IN (", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD)
                                    csWhere.AppendFormat("SELECT {0}.{1} FROM {0}", ABAtenaRirekiHyojunEntity.TABLE_NAME, ABAtenaRirekiHyojunEntity.JUMINCD)
                                    csWhere.AppendFormat(" WHERE {0}", strWhereRirekiHyojun)
                                    csWhere.Append(")")

                                Else
                                    ' noop
                                End If

                                '—š—ð•t
                                strWhereRirekiFZY = Me.CreateWhereRirekiFZY(cSearchKey)
                                If (strWhereRirekiFZY.RLength > 0) Then

                                    If (csWhere.RLength > 0) Then
                                        csWhere.Append(" AND ")
                                    Else
                                        ' noop
                                    End If

                                    csWhere.AppendFormat("{0}.{1} IN (", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD)
                                    csWhere.AppendFormat("SELECT {0}.{1} FROM {0}", ABAtenaRirekiFZYEntity.TABLE_NAME, ABAtenaRirekiFZYEntity.JUMINCD)
                                    csWhere.AppendFormat(" WHERE {0}", strWhereRirekiFZY)
                                    csWhere.Append(")")

                                Else
                                    ' noop
                                End If
                            Else

                                ' [’¼‹ßŒŸõ]

                                ' Šù‘¶‚Ìˆ—‚ð‚»‚Ì‚Ü‚ÜŽÀs‚·‚é
                                csWhere = New StringBuilder(Me.CreateWhere(cSearchKey))

                                ' íœƒtƒ‰ƒO
                                If blnSakujoFG = False Then
                                    If Not (csWhere.RLength = 0) Then
                                        csWhere.Append(" AND ")
                                    End If
                                    csWhere.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SAKUJOFG)
                                    csWhere.Append(" <> '1'")
                                End If

                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch cfAppExp As UFAppException

                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + cfAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + cfAppExp.Message + "z")
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + csExp.Message + "z")
                            Throw

                        End Try

                        Return csWhere.ToString

                    End Function

                    ''' <summary>
                    ''' ’ŠoðŒ•¶Žš—ñ‚Ì¶¬i’¼‹ß—pj
                    ''' </summary>
                    ''' <param name="cSearchKey">ŒŸõƒL[</param>
                    ''' <param name="blnSakujoFG">íœƒtƒ‰ƒO</param>
                    ''' <returns>’ŠoðŒ•¶Žš—ñ</returns>
                    ''' <remarks></remarks>
                    Private Function CreateWhereForChokkin(ByVal cSearchKey As ABAtenaSearchKey, ByVal blnSakujoFG As Boolean) As String

                        Dim THIS_METHOD_NAME As String = Reflection.MethodBase.GetCurrentMethod.Name
                        Dim csWHERE As StringBuilder
                        Dim cfUFParameterClass As UFParameterClass

                        Try

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' WHERE‹å‚Ìì¬
                            csWHERE = New StringBuilder(256)

                            ' Z–¯ƒR[ƒh
                            If Not (cSearchKey.p_strJuminCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINCD)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_JUMINCD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUMINCD
                                cfUFParameterClass.Value = cSearchKey.p_strJuminCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' Z–¯—Dæ‹æ•ª
                            If Not (cSearchKey.p_strJuminYuseniKB.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUMINYUSENIKB)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_JUMINYUSENIKB)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUMINYUSENIKB
                                cfUFParameterClass.Value = cSearchKey.p_strJuminYuseniKB

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' Z“oŠO—Dæ‹æ•ª
                            If Not (cSearchKey.p_strJutogaiYusenKB.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.JUTOGAIYUSENKB)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.KEY_JUTOGAIYUSENKB)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.KEY_JUTOGAIYUSENKB
                                cfUFParameterClass.Value = cSearchKey.p_strJutogaiYusenKB

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ƒf[ƒ^‹æ•ª
                            If Not (cSearchKey.p_strDataKB.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If

                                If cSearchKey.p_strDataKB.RIndexOf("%") = -1 Then
                                    csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ATENADATAKB)
                                    csWHERE.Append(" = ")
                                    csWHERE.Append(ABAtenaEntity.PARAM_ATENADATAKB)
                                Else
                                    csWHERE.Append(ABAtenaEntity.ATENADATAKB)
                                    csWHERE.Append(" LIKE ")
                                    csWHERE.Append(ABAtenaEntity.PARAM_ATENADATAKB)

                                End If

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_ATENADATAKB
                                cfUFParameterClass.Value = cSearchKey.p_strDataKB

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ˆ¶–¼ƒf[ƒ^Ží•Ê
                            Select Case cSearchKey.p_strDataKB.Trim

                                Case ABConstClass.ATENADATAKB_HOJIN
                                    ' noop
                                Case Else

                                    ' [Z“o“àŒÂl][Z“oŠOŒÂl][‹¤—L][Žw’è‚È‚µ]‚Ìê‡

                                    If Not ((cSearchKey.p_strJuminShubetu1 = String.Empty) And (cSearchKey.p_strJuminShubetu2 = String.Empty)) Then
                                        If (cSearchKey.p_strDataKB.Trim = String.Empty) Then
                                            If Not (csWHERE.RLength = 0) Then
                                                csWHERE.Append(" AND ")
                                            End If
                                            csWHERE.Append("((")
                                            csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ATENADATAKB)
                                            csWHERE.Append(" = '11')")
                                            csWHERE.Append(" OR (")
                                            csWHERE.Append(ABAtenaEntity.ATENADATAKB)
                                            csWHERE.Append(" = '12'))")
                                        End If

                                        'Z–¯Ží•Ê‚P
                                        If Not (cSearchKey.p_strJuminShubetu1.Trim = String.Empty) Then
                                            If Not (csWHERE.RLength = 0) Then
                                                csWHERE.Append(" AND ")
                                            End If
                                            csWHERE.Append(" {fn SUBSTRING(")
                                            csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ATENADATASHU)
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
                                            csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.ATENADATASHU)
                                            csWHERE.Append(",2,1)} = '")
                                            csWHERE.Append(cSearchKey.p_strJuminShubetu2)
                                            csWHERE.Append("'")
                                        End If
                                    End If

                            End Select

                            ' Žs’¬‘ºƒR[ƒh
                            If Not (cSearchKey.p_strShichosonCD.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SHICHOSONCD)
                                csWHERE.Append(" = ")
                                csWHERE.Append(ABAtenaEntity.PARAM_SHICHOSONCD)

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_SHICHOSONCD
                                cfUFParameterClass.Value = cSearchKey.p_strShichosonCD

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ---------------------------------------------------------------------------------------------------------
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
                                    csWHERE.AppendFormat("{0}.{1} ", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD)
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
                                                         ABAtenaEntity.TABLE_NAME, ABAtenaEntity.KJNHJNKB,
                                                         ABAtenaEntity.PARAM_KJNHJNKB)

                                    ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^[‚ðì¬
                                    cfUFParameterClass = New UFParameterClass
                                    cfUFParameterClass.ParameterName = ABAtenaEntity.PARAM_KJNHJNKB
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
                            ' ---------------------------------------------------------------------------------------------------------

                            ' íœƒtƒ‰ƒO
                            If blnSakujoFG = False Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                csWHERE.Append(ABAtenaEntity.TABLE_NAME).Append(".").Append(ABAtenaEntity.SAKUJOFG)
                                csWHERE.Append(" <> '1'")
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch cfAppExp As UFAppException

                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + cfAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + cfAppExp.Message + "z")
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + csExp.Message + "z")
                            Throw

                        End Try

                        Return csWHERE.ToString

                    End Function

                    ''' <summary>
                    ''' ’ŠoðŒ•¶Žš—ñ‚Ì¶¬i—š—ð—pj
                    ''' </summary>
                    ''' <param name="cSearchKey">ŒŸõƒL[</param>
                    ''' <returns>’ŠoðŒ•¶Žš—ñ</returns>
                    ''' <remarks></remarks>
                    Private Function CreateWhereForRireki(ByVal cSearchKey As ABAtenaSearchKey) As String

                        Dim THIS_METHOD_NAME As String = Reflection.MethodBase.GetCurrentMethod.Name
                        Dim csWHERE As StringBuilder
                        Dim cfUFParameterClass As UFParameterClass

                        Try

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'WHERE‹å‚Ìì¬
                            csWHERE = New StringBuilder(256)

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

                            '*—š—ð”Ô† 000032 2020/01/10 C³ŠJŽn
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
                            '    ' ŒŸõ—pƒJƒi©‚Q‚ÉŒŸõƒL[‚ªŠi”[‚³‚ê‚Ä‚¢‚éê‡‚ÍŒŸõðŒ‚Æ‚µ‚Ä’Ç‰Á
                            '    If (cSearchKey.p_strSearchKanaSei2.Trim() <> String.Empty) Then
                            '        csWHERE.Append(" ( ")
                            '    End If
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

                            '' –{–¼Š¿Žš©–¼ –{–¼ŒŸõ="2(Tsusho_Seishiki)"‚Ì‚Æ‚«‚Ì‚ÝŠ¿ŽšŽ–¼‚Q‚ÍŒŸõ€–Ú‚Æ‚È‚é
                            'If (cSearchKey.p_enGaikokuHommyoKensaku = FrnHommyoKensakuType.Tsusho_Seishiki) Then
                            '    If Not (cSearchKey.p_strKanjiMeisho2.Trim = String.Empty) Then
                            '        If Not (csWHERE.Length = 0) Then
                            '            csWHERE.Append(" AND ")
                            '        End If
                            '        If cSearchKey.p_strKanjiMeisho2.IndexOf("%") = -1 Then
                            '            csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANJIMEISHO2)
                            '            csWHERE.Append(" = ")
                            '            csWHERE.Append(ABAtenaRirekiEntity.PARAM_KANJIMEISHO2)

                            '            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '            cfUFParameterClass = New UFParameterClass
                            '            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_KANJIMEISHO2
                            '            cfUFParameterClass.Value = cSearchKey.p_strKanjiMeisho2

                            '            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '            m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '        Else
                            '            csWHERE.Append(ABAtenaRirekiEntity.TABLE_NAME).Append(".").Append(ABAtenaRirekiEntity.KANJIMEISHO2)
                            '            csWHERE.Append(" LIKE ")
                            '            csWHERE.Append(ABAtenaRirekiEntity.PARAM_KANJIMEISHO2)

                            '            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            '            cfUFParameterClass = New UFParameterClass
                            '            cfUFParameterClass.ParameterName = ABAtenaRirekiEntity.PARAM_KANJIMEISHO2
                            '            cfUFParameterClass.Value = cSearchKey.p_strKanjiMeisho2.TrimEnd

                            '            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            '            m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            '        End If
                            '    End If
                            'End If

                            ' Ž–¼ŒŸõðŒ‚ð¶¬
                            m_cKensakuShimeiB.CreateWhereForShimei(cSearchKey, ABAtenaRirekiEntity.TABLE_NAME, csWHERE, m_cfSelectUFParameterCollectionClass,
                                                                   ABAtenaRirekiFZYHyojunEntity.TABLE_NAME)
                            '*—š—ð”Ô† 000032 2020/01/10 C³I—¹

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

                            ' –@lŒ`‘Ô
                            Select Case cSearchKey.p_strDataKB.Trim

                                Case ABConstClass.ATENADATAKB_HOJIN

                                    ' [–@l]‚Ìê‡

                                    If Not ((cSearchKey.p_strJuminShubetu1 = String.Empty) And (cSearchKey.p_strJuminShubetu2 = String.Empty)) Then
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

                                Case Else
                                    ' noop
                            End Select

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
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch cfAppExp As UFAppException

                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + cfAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + cfAppExp.Message + "z")
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + csExp.Message + "z")
                            Throw

                        End Try

                        Return csWHERE.ToString

                    End Function
                    '*—š—ð”Ô† 000031 2018/03/08 ’Ç‰ÁI—¹

                    ''' <summary>
                    ''' ’ŠoðŒ•¶Žš—ñ‚Ì¶¬iˆ¶–¼•W€—pj
                    ''' </summary>
                    ''' <param name="cSearchKey">ŒŸõƒL[</param>
                    ''' <returns>’ŠoðŒ•¶Žš—ñ</returns>
                    ''' <remarks></remarks>
                    Private Function CreateWhereHyojun(ByVal cSearchKey As ABAtenaSearchKey) As String

                        Dim THIS_METHOD_NAME As String = Reflection.MethodBase.GetCurrentMethod.Name
                        Dim csWHERE As StringBuilder
                        Dim cfUFParameterClass As UFParameterClass

                        Try

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'WHERE‹å‚Ìì¬
                            csWHERE = New StringBuilder(256)

                            'ZŠ
                            If Not (cSearchKey.p_strJusho.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                If (cSearchKey.p_strJusho.RIndexOf("%") = -1) Then
                                    csWHERE.Append(ABAtenaHyojunEntity.TABLE_NAME).Append(".").Append(ABAtenaHyojunEntity.SEARCHJUSHO)
                                    csWHERE.Append(" = ")
                                    csWHERE.Append(ABAtenaHyojunEntity.PARAM_SEARCHJUSHO)
                                Else
                                    csWHERE.Append(ABAtenaHyojunEntity.TABLE_NAME).Append(".").Append(ABAtenaHyojunEntity.SEARCHJUSHO)
                                    csWHERE.Append(" LIKE ")
                                    csWHERE.Append(ABAtenaHyojunEntity.PARAM_SEARCHJUSHO)
                                End If
                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.PARAM_SEARCHJUSHO
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
                                    csWHERE.Append(ABAtenaHyojunEntity.TABLE_NAME).Append(".").Append(ABAtenaHyojunEntity.SEARCHKATAGAKI)
                                    csWHERE.Append(" = ")
                                    csWHERE.Append(ABAtenaHyojunEntity.PARAM_SEARCHKATAGAKI)
                                Else
                                    csWHERE.Append(ABAtenaHyojunEntity.TABLE_NAME).Append(".").Append(ABAtenaHyojunEntity.SEARCHKATAGAKI)
                                    csWHERE.Append(" LIKE ")
                                    csWHERE.Append(ABAtenaHyojunEntity.PARAM_SEARCHKATAGAKI)
                                End If
                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.PARAM_SEARCHKATAGAKI
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
                                    csWHERE.Append(ABAtenaHyojunEntity.TABLE_NAME).Append(".").Append(ABAtenaHyojunEntity.SEARCHKANJIKYUUJI)
                                    csWHERE.Append(" = ")
                                    csWHERE.Append(ABAtenaHyojunEntity.PARAM_SEARCHKANJIKYUUJI)
                                Else
                                    csWHERE.Append(ABAtenaHyojunEntity.TABLE_NAME).Append(".").Append(ABAtenaHyojunEntity.SEARCHKANJIKYUUJI)
                                    csWHERE.Append(" LIKE ")
                                    csWHERE.Append(ABAtenaHyojunEntity.PARAM_SEARCHKANJIKYUUJI)
                                End If
                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.PARAM_SEARCHKANJIKYUUJI
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
                                    csWHERE.Append(ABAtenaHyojunEntity.TABLE_NAME).Append(".").Append(ABAtenaHyojunEntity.SEARCHKANAKYUUJI)
                                    csWHERE.Append(" = ")
                                    csWHERE.Append(ABAtenaHyojunEntity.PARAM_SEARCHKANAKYUUJI)
                                Else
                                    csWHERE.Append(ABAtenaHyojunEntity.TABLE_NAME).Append(".").Append(ABAtenaHyojunEntity.SEARCHKANAKYUUJI)
                                    csWHERE.Append(" LIKE ")
                                    csWHERE.Append(ABAtenaHyojunEntity.PARAM_SEARCHKANAKYUUJI)
                                End If
                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.PARAM_SEARCHKANAKYUUJI
                                cfUFParameterClass.Value = cSearchKey.p_strKanaKyuuji

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch cfAppExp As UFAppException

                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + cfAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + cfAppExp.Message + "z")
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + csExp.Message + "z")
                            Throw

                        End Try

                        Return csWHERE.ToString

                    End Function

                    ''' <summary>
                    ''' ’ŠoðŒ•¶Žš—ñ‚Ì¶¬iˆ¶–¼•t—pj
                    ''' </summary>
                    ''' <param name="cSearchKey">ŒŸõƒL[</param>
                    ''' <returns>’ŠoðŒ•¶Žš—ñ</returns>
                    ''' <remarks></remarks>
                    Private Function CreateWhereFZY(ByVal cSearchKey As ABAtenaSearchKey) As String

                        Dim THIS_METHOD_NAME As String = Reflection.MethodBase.GetCurrentMethod.Name
                        Dim csWHERE As StringBuilder
                        Dim cfUFParameterClass As UFParameterClass

                        Try

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'WHERE‹å‚Ìì¬
                            csWHERE = New StringBuilder(256)

                            'ƒJƒ^ƒJƒi•¹‹L–¼
                            If Not (cSearchKey.p_strKatakanaHeikimei.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                If (cSearchKey.p_strKatakanaHeikimei.RIndexOf("%") = -1) Then
                                    csWHERE.Append(ABAtenaFZYEntity.TABLE_NAME).Append(".").Append(ABAtenaFZYEntity.KATAKANAHEIKIMEI)
                                    csWHERE.Append(" = ")
                                    csWHERE.Append(ABAtenaFZYEntity.PARAM_KATAKANAHEIKIMEI)
                                Else
                                    csWHERE.Append(ABAtenaFZYEntity.TABLE_NAME).Append(".").Append(ABAtenaFZYEntity.KATAKANAHEIKIMEI)
                                    csWHERE.Append(" LIKE ")
                                    csWHERE.Append(ABAtenaFZYEntity.PARAM_KATAKANAHEIKIMEI)
                                End If
                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABAtenaFZYEntity.PARAM_KATAKANAHEIKIMEI
                                cfUFParameterClass.Value = cSearchKey.p_strKatakanaHeikimei

                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch cfAppExp As UFAppException

                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + cfAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + cfAppExp.Message + "z")
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + csExp.Message + "z")
                            Throw

                        End Try

                        Return csWHERE.ToString

                    End Function

                    ''' <summary>
                    ''' ’ŠoðŒ•¶Žš—ñ‚Ì¶¬iˆ¶–¼—š—ð•W€—pj
                    ''' </summary>
                    ''' <param name="cSearchKey">ŒŸõƒL[</param>
                    ''' <returns>’ŠoðŒ•¶Žš—ñ</returns>
                    ''' <remarks></remarks>
                    Private Function CreateWhereRirekiHyojun(ByVal cSearchKey As ABAtenaSearchKey) As String

                        Dim THIS_METHOD_NAME As String = Reflection.MethodBase.GetCurrentMethod.Name
                        Dim csWHERE As StringBuilder
                        Dim cfUFParameterClass As UFParameterClass

                        Try

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'WHERE‹å‚Ìì¬
                            csWHERE = New StringBuilder(256)

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

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch cfAppExp As UFAppException

                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + cfAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + cfAppExp.Message + "z")
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + csExp.Message + "z")
                            Throw

                        End Try

                        Return csWHERE.ToString

                    End Function

                    ''' <summary>
                    ''' ’ŠoðŒ•¶Žš—ñ‚Ì¶¬iˆ¶–¼•t—pj
                    ''' </summary>
                    ''' <param name="cSearchKey">ŒŸõƒL[</param>
                    ''' <returns>’ŠoðŒ•¶Žš—ñ</returns>
                    ''' <remarks></remarks>
                    Private Function CreateWhereRirekiFZY(ByVal cSearchKey As ABAtenaSearchKey) As String

                        Dim THIS_METHOD_NAME As String = Reflection.MethodBase.GetCurrentMethod.Name
                        Dim csWHERE As StringBuilder
                        Dim cfUFParameterClass As UFParameterClass

                        Try

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'WHERE‹å‚Ìì¬
                            csWHERE = New StringBuilder(256)

                            'ƒJƒ^ƒJƒi•¹‹L–¼
                            If Not (cSearchKey.p_strKatakanaHeikimei.Trim = String.Empty) Then
                                If Not (csWHERE.RLength = 0) Then
                                    csWHERE.Append(" AND ")
                                End If
                                If (cSearchKey.p_strKatakanaHeikimei.RIndexOf("%") = -1) Then
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

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch cfAppExp As UFAppException

                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + cfAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + cfAppExp.Message + "z")
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + csExp.Message + "z")
                            Throw

                        End Try

                        Return csWHERE.ToString

                    End Function
                    '*—š—ð”Ô† 000033 2023/03/10 ’Ç‰ÁŠJŽn
                #Region "ˆ¶–¼•W€ƒf[ƒ^€–Ú•ÒW"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼•W€ƒf[ƒ^€–Ú•ÒW
                    '* 
                    '* \•¶           Private SetHyojunEntity()
                    '* 
                    '* ‹@”\           ˆ¶–¼•W€ƒf[ƒ^‚Ì€–Ú•ÒW‚ð‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetHyojunEntity(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.RRKNO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.EDANO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SHIMEIKANAKAKUNINFG)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.UMAREBIFUSHOPTN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.FUSHOUMAREBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JIJITSUSTAINUSMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SHIKUCHOSONCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.MACHIAZACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SHIKUCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.MACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SEARCHJUSHO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.KANAKATAGAKI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SEARCHKATAGAKI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.BANCHIEDABANSUCHI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUSHO_KUNIMEICODE)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUSHO_KUNIMEITO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUSHO_KOKUGAIJUSHO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.HON_SHIKUCHOSONCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.HON_MACHIAZACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.HON_TODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.HON_SHIKUGUNCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.HON_MACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.CKINIDOWMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.CKINIDOBIFUSHOPTN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.FUSHOCKINIDOBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TOROKUIDOBIFUSHOPTN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.FUSHOTOROKUIDOBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.HYOJUNKISAIJIYUCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.KISAIYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.KISAIBIFUSHOPTN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.FUSHOKISAIBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUTEIIDOBIFUSHOPTN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.FUSHOJUTEIIDOBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.HYOJUNSHOJOJIYUCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.KOKUSEKISOSHITSUBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SHOJOIDOWMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SHOJOIDOBIFUSHOPTN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.FUSHOSHOJOIDOBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENUMAEJ_SHIKUCHOSONCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENUMAEJ_MACHIAZACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENUMAEJ_TODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENUMAEJ_SHIKUCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENUMAEJ_MACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENUMAEJ_KOKUSEKICD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENUMAEJ_KOKUSEKI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENUMAEJ_KOKUGAIJUSHO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SAISHUTJ_YUBINNO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SAISHUTJ_SHIKUCHOSONCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SAISHUTJ_MACHIAZACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SAISHUTJ_TODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SAISHUTJ_SHIKUCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SAISHUTJ_MACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SAISHUTJ_BANCHI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SAISHUTJ_KATAGAKI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SAISHUJ_TODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SAISHUJ_SHIKUCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SAISHUJ_MACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SAISHUJ_BANCHI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SAISHUJ_KATAGAKI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENSHUTSUYOTEISHIKUCHOSONCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENSHUTSUYOTEIMACHIAZACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENSHUTSUYOTEITODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENSHUTSUYOTEISHIKUCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENSHUTSUYOTEIMACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENSHUTSUYOTEIKOKUSEKICD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENSHUTSUYOTEIKOKUSEKI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENSHUTSUYOTEIKOKUGAIJUSHO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENSHUTSUKKTISHIKUCHOSONCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENSHUTSUKKTIMACHIAZACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENSHUTSUKKTITODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENSHUTSUKKTISHIKUCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TENSHUTSUKKTIMACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.KAISEIBIFUSHOPTN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.FUSHOKAISEIBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.KAISEISHOJOYMD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.KAISEISHOJOBIFUSHOPTN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.FUSHOKAISEISHOJOBI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.CHIKUCD4)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.CHIKUCD5)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.CHIKUCD6)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.CHIKUCD7)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.CHIKUCD8)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.CHIKUCD9)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.CHIKUCD10)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TOKUBETSUYOSHIKB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.HYOJUNIDOKB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.NYURYOKUBASHOCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.NYURYOKUBASHO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SEARCHKANJIKYUUJI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SEARCHKANAKYUUJI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.KYUUJIKANAKAKUNINFG)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TDKDSHIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.HYOJUNIDOJIYUCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.NICHIJOSEIKATSUKENIKICD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.KOBOJONOJUSHO_SHOZAICHI_YOMIGANA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TOROKUBUSHO)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TANKITAIZAISHAFG)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.KYOYUNINZU)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SHIZEIJIMUSHOCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SHUKKOKUKIKAN_ST)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SHUKKOKUKIKAN_ED)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.IDOSHURUI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.SHOKANKUCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.TOGOATENAFG)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.FUSHOUMAREBI_DATE)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.FUSHOCKINIDOBI_DATE)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.FUSHOSHOJOIDOBI_DATE)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUKISHIKUCHOSONCD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUKIMACHIAZACD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUKITODOFUKEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUKISHIKUCHOSON)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUKIMACHIAZA)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUKIKANAKATAGAKI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUKICHIKUCD4)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUKICHIKUCD5)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUKICHIKUCD6)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUKICHIKUCD7)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUKICHIKUCD8)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUKICHIKUCD9)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUKICHIKUCD10)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUKIBANCHIEDABANSUCHI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_H", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.RESERVE1)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_H", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.RESERVE2)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_H", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.RESERVE3)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_H", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.RESERVE4)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_H", ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.RESERVE5)
                    End Sub
                #End Region

                #Region "ˆ¶–¼•t•W€ƒf[ƒ^€–Ú•ÒW"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼•t•W€ƒf[ƒ^€–Ú•ÒW
                    '* 
                    '* \•¶           Private SetFZYHyojunEntity()
                    '* 
                    '* ‹@”\           ˆ¶–¼•t•W€ƒf[ƒ^‚Ì€–Ú•ÒW‚ð‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetFZYHyojunEntity(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.SEARCHFRNMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.SEARCHKANAFRNMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.SEARCHTSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.SEARCHKANATSUSHOMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.TSUSHOKANAKAKUNINFG)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.SHIMEIYUSENKB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.SEARCHKANJIHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.SEARCHKANAHEIKIMEI)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.ZAIRYUCARDNOKBN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.JUKYOCHIHOSEICD)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.HODAI30JO46MATAHA47KB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.STAINUSSHIMEIYUSENKB)
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.TOKUSHOMEI_YUKOKIGEN)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_FH", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.RESERVE1)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_FH", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.RESERVE2)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_FH", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.RESERVE3)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_FH", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.RESERVE4)
                        strAtenaSQLsb.AppendFormat(", {0}.{1} AS {1}_FH", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.RESERVE5)
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
                        strAtenaSQLsb.AppendFormat(", {0}.{1}", ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.FUGENJUGYOSEIKUCD)
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

                #Region "ˆ¶–¼•W€ƒe[ƒuƒ‹JOIN‹åì¬"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼•W€ƒe[ƒuƒ‹JOIN‹åì¬
                    '* 
                    '* \•¶           Private SetHyojunJoin()
                    '* 
                    '* ‹@”\           ˆ¶–¼•W€ƒe[ƒuƒ‹‚ÌJOIN‹å‚ðì¬‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetHyojunJoin(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(" LEFT OUTER JOIN {0} ", ABAtenaHyojunEntity.TABLE_NAME)
                        strAtenaSQLsb.AppendFormat(" ON {0}.{1} = {2}.{3} ",
                                                    ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD,
                                                    ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUMINCD)
                        strAtenaSQLsb.AppendFormat(" AND {0}.{1} = {2}.{3} ",
                                                    ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINJUTOGAIKB,
                                                    ABAtenaHyojunEntity.TABLE_NAME, ABAtenaHyojunEntity.JUMINJUTOGAIKB)
                    End Sub
                #End Region

                #Region "ˆ¶–¼•t•W€ƒe[ƒuƒ‹JOIN‹åì¬"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼•t•W€ƒe[ƒuƒ‹JOIN‹åì¬
                    '* 
                    '* \•¶           Private SetFZYHyojunJoin()
                    '* 
                    '* ‹@”\           ˆ¶–¼•t•W€ƒe[ƒuƒ‹‚ÌJOIN‹å‚ðì¬‚µ‚Ü‚·B
                    '* 
                    '* ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetFZYHyojunJoin(ByRef strAtenaSQLsb As StringBuilder)
                        strAtenaSQLsb.AppendFormat(" LEFT OUTER JOIN {0} ", ABAtenaFZYHyojunEntity.TABLE_NAME)
                        strAtenaSQLsb.AppendFormat(" ON {0}.{1} = {2}.{3} ",
                                                    ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD,
                                                    ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.JUMINCD)
                        strAtenaSQLsb.AppendFormat(" AND {0}.{1} = {2}.{3} ",
                                                    ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINJUTOGAIKB,
                                                    ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.JUMINJUTOGAIKB)
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
                                                    ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD,
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
                                                    ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD,
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
                                                        ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD,
                                                        ABDENSHISHOMEISHOMSTEntity.JUMINCD)
                            strAtenaSQLsb.AppendFormat(" AND {0}.{1} = DS3.{2} ",
                                                        ABAtenaEntity.TABLE_NAME, ABAtenaEntity.STAICD,
                                                        ABDENSHISHOMEISHOMSTEntity.STAICD)
                        End If
                    End Sub
                #End Region
                    '*—š—ð”Ô† 000033 2023/03/10 ’Ç‰ÁI—¹
                #End Region

                End Class

                 */
            }

            return default;
        }
    }
}