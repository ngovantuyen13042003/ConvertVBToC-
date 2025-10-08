// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‚`‚aˆ¶–¼•ÒWƒNƒ‰ƒX(ABAtenaHenshuBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/01/14@‘ê‘ò@‹Ô–ç
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/02/19 000001     –{l‘—•tæ•ÒW‚ÅA‘—•tæ‚ª•ÒW‚³‚ê‚È‚¢ê‡‚ª‚ ‚é
// * 2003/02/20 000002     ƒf[ƒ^‚ª‹ó”’‚Ìê‡‚ÌA”»’è‚É•s”õ
// *                       ‘—•tæƒf[ƒ^ƒ}[ƒWðŒ‚Ì•ÏX
// * 2003/02/21 000003     ‘—•tæƒf[ƒ^‚ð•ÒW‚·‚éŽžA‹Æ–±ƒR[ƒhE‹Æ–±“àŽí•Ê‚ÍA‘—•tæƒŒƒR[ƒh‚æ‚èƒZƒbƒg
// * 2003/02/25 000004     ZŠ•ÒW3‚ÅA3C4‚Ìê‡ij‚ð•t‰Á‚·‚éB’A‚µA–³‚¢ê‡‚ÍAij–³‚µ
// *                       •û‘‚ð•t‰Á‚·‚éŽž‚ÉŠ¿ŽšƒXƒy[ƒX‚ð‚PŒÂ“ü‚ê‚Ä•t‰Á‚µ‚Ä‚­‚¾‚³‚¢iŽd—l•ÏXj
// * 2003/02/25 000005     ‘—•tæ‚ª‘¶Ý‚µ‚È‚¢ê‡A‹Æ–±ƒR[ƒhE‹Æ–±“àŽí•ÊƒR[ƒh‚Í String.Empty ‚Æ‚·‚é
// * 2003/03/07 000006     ƒvƒƒWƒFƒNƒg‚ÌImports‚Í’è‹`‚µ‚È‚¢iŽd—l•ÏXj
// * 2003/03/17 000007     ƒpƒ‰ƒ[ƒ^‚Ìƒ`ƒFƒbƒN‚ð“ü‚ê‚é
// * 2003/03/17 000008     ZŠ•ÒW‚R‚Ì’l‚È‚µ‚Ìl—¶‚ð’Ç‰ÁiŽd—l•ÏXj
// * 2003/03/18 000009     ƒGƒ‰[ƒƒbƒZ[ƒW‚Ì•ÏXiŽd—l•ÏXj
// * 2003/03/27 000010     ƒGƒ‰[ˆ—ƒNƒ‰ƒX‚ÌŽQÆæ‚ð"AB"ŒÅ’è‚É‚·‚é
// * 2003/04/01 000011     ABAtena1‚Ìƒvƒ‰ƒCƒ}ƒŠ[ƒL[‚ðŠO‚·
// * 2003/04/18 000012     ˆ¶–¼î•ñEntity‚É‘±•¿ƒR[ƒhE‘±•¿EƒJƒi–¼Ì‚QEŠ¿Žš–¼Ì‚QEÐ”Ô†‚ð’Ç‰Á
// * 2003/04/18 000013     ”N‹à—pˆ¶–¼î•ñEntity‚ð’Ç‰Á
// * 2003/04/30 000014     –@l‚ÌŽžAƒJƒi–¼Ì2AŠ¿Žš–¼Ì‚Q‚ÍAƒZƒbƒg‚µ‚È‚¢iŽd—l•ÏXj
// * 2003/04/30 000015     ˆ¶–¼•ÒW€–Ú‚ð‰Šú‰»ŒãAÝ’è‚·‚éB                      
// * 2003/08/22 000016     ‚t‚qƒLƒƒƒbƒVƒ…‘Î‰ž^Œp³‰Â”\ƒNƒ‰ƒX‚É•ÏX
// * 2003/10/09 000017     ˜A—æ‚ÍA˜A—æƒ}ƒXƒ^‚Éƒf[ƒ^‚ª‘¶Ý‚·‚éê‡‚ÍA‚»‚¿‚ç‚©‚çŽæ“¾‚·‚éB’A‚µA‹Æ–±ƒR[ƒh‚ªŽw’è‚³‚ê‚Ä‚½ê‡‚Ì‚Ý‚ÉŒÀ‚éB
// *                       NenkinAtenaGet‚àAtenaGet1‚Æ“¯—l‚ÉŽw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚½‚çAˆ¶–¼—š—ð‚æ‚èŽæ“¾‚·‚éB˜A—æ‚à“¯—lB’A‚µA‘ã”[E‡ŽZ‚Í•s—vB
// * 2003/10/14 000018     —š—ð•ÒW‚ÅA‘±•¿‚Q‚ª–³‚¢ê‡A‘±•¿‚ª•ÒW‚³‚ê‚È‚¢B
// * 2003/11/19 000019     ˆ¶–¼ŒÂ•Êî•ñ•ÒWˆ—‚ð’Ç‰Á
// * 2003/12/01 000020     ˜A—æ‹Æ–±ƒR[ƒh‚ðABAtena1‚©‚ç‚Í‚¸‚·BABNenkinAtenaEŒÂ•Êˆ¶–¼‚É’Ç‰Á
// * 2003/12/02 000021     ˜A—æŽæ“¾E•ÒW‚ðˆ¶–¼Žæ“¾‚ÖˆÚ“®
// * 2003/12/04 000022     Žd—l•ÏXF”N‹à—pˆ¶–¼î•ñEntity€–Ú’Ç‰Á‚É”º‚¤•ÏX
// * 2004/08/27 000023     ‘¬“x‰ü‘PFi‹{‘òj
// * 2005/01/25 000024     ‘¬“x‰ü‘P‚QFi‹{‘òj
// * 2005/07/14 000025     CheckColumnValueƒƒ\ƒbƒh‚Å‚ÌZŠ•ÒW‚R‚Ì’l‚Ì”ÍˆÍ‚ðC³(ƒ}ƒ‹ƒS‘ºŽR)
// * 2005/12/21 000026     Z–¯•[•\Ž¦‡‚Ì•ÒWŽd—l•ÏX(ùˆä)
// * 2006/07/31 000027     ”N‹àˆ¶–¼ƒQƒbƒg‡U’Ç‰Á(‹gàV)
// * 2007/01/15 000028     ZŠ•ÒWƒpƒ^[ƒ“’Ç‰Á
// *                       —š—ð•ÒWEZŠî—Dæ‚Å‚Í‚È‚¢ê‡‚ÌƒR[ƒfƒBƒ“ƒOC³
// * 2007/01/25 000029     ‘—•tæ‚É”Ô’nƒR[ƒh‚ðÝ’è‚·‚é‚æ‚¤‚ÉC³
// * 2007/04/28 000030     ‰îŒì”Åˆ¶–¼Žæ“¾ƒƒ\ƒbƒh‚Ì’Ç‰Á‚É‚æ‚éŽæ“¾€–Ú‚Ì’Ç‰Á (‹gàV)
// * 2007/06/28 000031     DB•¶Žš”Šg’£‘Î‰žC•¶Žš”Šg’£‚É‚Æ‚à‚È‚¤ˆ¶–¼î•ñƒJƒ‰ƒ€’è‹`•”‚¨‚æ‚Ñ”N‹à—pˆ¶–¼î•ñƒJƒ‰ƒ€’è‹`•”MaxLength’lC³
// *                       i‘Î‰žŒÂŠ‚ª•¡”‚É“n‚éˆ×C—š—ð”Ô†•t‰Á–³‚µji’†‘òj
// * 2007/07/09 000032     •¶Žš—ñŒ‹‡Œã‚ÉØ‚è‹l‚ß‚Ä‚¢‚é•¶Žš”‚ÌC³i’†‘òj
// * 2007/07/17 000033     Žx“X–¼‚ª–³‚¢ê‡‚ÍC–@l–¼Ì‚ÆŽx“X–¼‚ÌŒ‹‡ˆ—‚ðs‚í‚È‚¢i’†‘òj
// * 2008/01/15 000034     ˆ¶–¼ŒÂ•Êî•ñƒJƒ‰ƒ€ì¬‚ÉŒãŠú‚—îî•ñ€–Ú‚ð’Ç‰Ái”ä‰Ãj•ƒl[ƒ~ƒ“ƒO•ÏXi‹gàVj
// * 2008/02/15 000035     Ž–¼ŠÈ—ª•¶Žš•ÒWˆ—‚ð’Ç‰Ái”ä‰Ãj
// * 2008/11/10 000036     ˆ¶–¼ƒf[ƒ^ƒZƒbƒg‚Ìì¬Žž‚É”[ÅŽÒIDE—˜—pŽÒID‚ð’Ç‰Ái”ä‰Ãj
// * 2008/11/17 000037     ‘—•tæ•ÒW€–Ú‚ð‰Šú‰»‚·‚éˆ—‚ð’Ç‰Ái”ä‰Ãj
// * 2008/11/18 000038     —š—ð”Ô†:000036‚Ì’Ç‰Á‚É”º‚¤‰üCi”ä‰Ãj
// * 2010/04/16 000039     VS2008‘Î‰ži”ä‰Ãj
// * 2010/05/14 000040     –{Ð•M“ªŽÒ‹y‚Ñˆ—’âŽ~‹æ•ª‘Î‰ži”ä‰Ãj
// * 2011/05/18 000041     ŠO‘lÝ—¯î•ñŽæ“¾‹æ•ª‘Î‰ži”ä‰Ãj
// * 2011/05/18 000042     –{–¼E’ÊÌ–¼—Dæ§Œä‘Î‰ži”ä‰Ãj
// * 2011/06/23 000043     –{–¼E’ÊÌ–¼—Dæ§Œä‘Î‰žUS‹@”\‘g‚Ýž‚Ý‰üCi”ä‰Ãj
// * 2011/06/24 000044     ƒŒƒCƒAƒEƒgF”N‹à—p‚ÌŠO‘lÝ—¯î•ñ‚ÌÝ’èˆÊ’u‚ð•ÏXi”ä‰Ãj
// * 2011/06/27 000045     –¼Ì•ÒWˆ—‚Å–{–¼—Dæˆ—‚Ìê‡‚ÉŠ¿Žš–¼Ì‚Q‚Ì‘¶Ýƒ`ƒFƒbƒNs‚¤‚æ‚¤‚É‰üCi”ä‰Ãj
// * 2011/11/07 000046     yAB17010zZŠî–@‰ü³‚É‚æ‚èˆ¶–¼•tƒf[ƒ^‚ðŒ‹‡‚µ‚ÄŽæ“¾‚·‚é‚æ‚¤‚É‰üCi’r“cj
// * 2012/03/13 000047     yAB17010-00z˜A‘±ˆ—‚É‚æ‚èˆÙíI—¹‚·‚é•s‹ï‡C³i’†“ˆj
// * 2014/04/28 000048     yAB21040zƒ‹¤’Ê”Ô†‘Î‰ž„‹¤’Ê”Ô†’Ç‰ÁiÎ‡j
// * 2022/12/16 000049     yAB-8010zZ–¯ƒR[ƒh¢‘ÑƒR[ƒh15Œ…‘Î‰ž(‰º‘º)
// * 2023/03/10 000050     yAB-0970-1zˆ¶–¼GETŽæ“¾€–Ú•W€‰»‘Î‰ži’‡¼j
// * 2023/10/19 000051     yAB-0820-1zZ“oŠOŠÇ—€–Ú’Ç‰Á_’Ç‰ÁC³(’‡¼)
// * 2023/12/22 000020     yAB-0970-1_2zˆ¶–¼GET“ú•t€–ÚÝ’è‘Î‰ž(‰º‘º)
// * 2024/06/17 000021     yAB-9903-1z•s‹ï‡‘Î‰ž
// ************************************************************************************************
using System;
// *—š—ð”Ô† 000006  2003/03/07 íœŠJŽn
// Imports Densan.Reams.AB.AB001BX
// *—š—ð”Ô† 000006  2003/03/07 íœI—¹
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Densan.Reams.AB.AB000BB
{

    public class ABAtenaHenshuBClass
    {

        #region  ƒƒ“
        // ************************************************************************************************
        // *
        // * ˆ¶–¼•ÒW‚ÉŽg—p‚·‚éƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
        // *
        // ************************************************************************************************
        // *—š—ð”Ô† 000016 2003/08/22 C³ŠJŽn
        // 'ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        // Private m_cfUFLogClass As UFLogClass                    'ƒƒOo—ÍƒNƒ‰ƒX
        // Private m_cfUFControlData As UFControlData              'ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        // Private m_cfUFConfigDataClass As UFConfigDataClass      'ƒRƒ“ƒtƒBƒOƒf[ƒ^
        // Private m_cfUFRdbClass As UFRdbClass                    '‚q‚c‚aƒNƒ‰ƒX

        // '@ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        // Private Const THIS_CLASS_NAME As String = "ABAtenaHenshuBClass"             ' ƒNƒ‰ƒX–¼
        // Private Const THIS_BUSINESSID As String = "AB"                              ' ‹Æ–±ƒR[ƒh
        // Private Const NENKIN As String = "NENKIN"

        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        protected UFLogClass m_cfUFLogClass;                                      // ƒƒOo—ÍƒNƒ‰ƒX
        protected UFControlData m_cfUFControlData;                                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        protected UFConfigDataClass m_cfUFConfigDataClass;                        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        protected UFRdbClass m_cfUFRdbClass;                                      // ‚q‚c‚aƒNƒ‰ƒX

        // @ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        protected const string THIS_CLASS_NAME = "ABAtenaHenshuBClass";           // ƒNƒ‰ƒX–¼
        protected const string THIS_BUSINESSID = "AB";                            // ‹Æ–±ƒR[ƒh
        protected const string NENKIN = "NENKIN";                                 // ”N‹àˆ—
                                                                                  // *—š—ð”Ô† 000027 2006/07/31 ’Ç‰ÁŠJŽn
        protected const string NENKIN_2 = "NENKIN_2";                                 // ”N‹àˆ—ƒp[ƒg‡U
                                                                                      // *—š—ð”Ô† 000027 2006/07/31 ’Ç‰ÁI—¹
                                                                                      // *—š—ð”Ô† 000016 2003/08/22 C³I—¹

        // *—š—ð”Ô† 000019 2003/11/19 ’Ç‰ÁŠJŽn
        protected const string KOBETSU = "KOBETSU";                               // ˆ¶–¼ŒÂ•Êî•ñˆ—
                                                                                  // *—š—ð”Ô† 000019 2003/11/19 ’Ç‰ÁI—¹

        // * —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
        private USSCityInfoClass m_cuUSSCityInfo;               // Žs’¬‘ºî•ñŠÇ—ƒNƒ‰ƒX
        private ABDainoKankeiBClass m_cABDainoKankeiB;          // ‘ã”[ŠÖŒWƒNƒ‰ƒX
        private ABJuminShubetsuBClass m_cABJuminShubetsuB;      // Z–¯Ží•ÊƒNƒ‰ƒX
        private ABHojinMeishoBClass m_cABHojinMeishoB;          // –@l–¼ÌƒNƒ‰ƒX
        private ABKjnhjnKBBClass m_cABKjnhjnKBB;                // ŒÂl–@lƒNƒ‰ƒX
        private ABKannaiKangaiKBBClass m_cABKannaiKangaiKBB;    // ŠÇ“àŠÇŠOƒNƒ‰ƒX
        private ABUmareHenshuBClass m_cABUmareHenshuB;          // ¶”NŒŽ“ú•ÒWƒNƒ‰ƒX
        private ABCommonClass m_cABCommon;                      // ˆ¶–¼‹¤’ÊƒNƒ‰ƒX
        private URKANRIJOHOCacheBClass m_cURKanriJohoB;         // ŠÇ—î•ñŽæ“¾ƒNƒ‰ƒX
                                                                // * —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁI—¹
                                                                // * —š—ðŠJŽn 000035 2008/02/15 ’Ç‰ÁŠJŽn
        private ABMojiretsuHenshuBClass m_cABMojiHenshuB;       // •¶Žš•ÒW‚aƒNƒ‰ƒX
                                                                // * —š—ðŠJŽn 000035 2008/02/15 ’Ç‰ÁI—¹
                                                                // *—š—ð”Ô† 000042 2011/05/18 ’Ç‰ÁŠJŽn
        private ABMeishoSeigyoBClass m_cABMeishoSeigyoB;        // –¼Ì§Œä‚aƒNƒ‰ƒX
                                                                // *—š—ð”Ô† 000043 2011/06/23 C³ŠJŽn
        private USUrlParmClass m_cuUSSUrlParm;                  // USURLƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                // *—š—ð”Ô† 000043 2011/06/23 C³I—¹
                                                                // *—š—ð”Ô† 000042 2011/05/18 ’Ç‰ÁI—¹
        private ABHyojunkaCdHenshuBClass m_cABHyojunkaCdHenshuB;    // •W€‰»ƒR[ƒh•ÒWƒNƒ‰ƒX

        // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
        protected SofuJushoGyoseikuType m_cSofuJushoGyoseikuType;
        protected bool m_bSofuJushoGyoseikuTypeFlg = false;
        public ABEnumDefine.AtenaGetKB m_blnSelectAll = ABEnumDefine.AtenaGetKB.KaniAll;
        private StringBuilder m_strHenshuJusho = new StringBuilder(200);                        // •ÒWZŠ–¼
        private DataTable m_csOrgAtena1;
        private DataTable m_csOrgAtena1Kobetsu;
        private DataTable m_csOrgAtena1Nenkin;
        // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000030 2007/04/28 ’Ç‰ÁŠJŽn
        public ABEnumDefine.MethodKB m_blnMethodKB;  // ƒƒ\ƒbƒh‹æ•ªi’Êí”Å‚©A‰îŒì”ÅAAAj
                                                     // *—š—ð”Ô† 000030 2007/04/28 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000034 2008/01/15 ’Ç‰ÁŠJŽn
        private string m_strKobetsuShutokuKB;         // ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^:ŒÂ•ÊŽžŒøŽæ“¾‹æ•ª
                                                      // *—š—ð”Ô† 000034 2008/01/15 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000036 2008/11/10 ’Ç‰ÁŠJŽn
        private string m_strRiyoTdkdKB;               // —˜—p“ÍoŽæ“¾‹æ•ª
        private bool m_blnKobetsu;                 // ŒÂ•ÊŽ–€”»’èƒtƒ‰ƒO
                                                   // *—š—ð”Ô† 000036 2008/11/10 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁŠJŽn
        private string m_strHonsekiHittoshKB_Param;                   // –{Ð•M“ªŽÒ‹æ•ªƒpƒ‰ƒ[ƒ^
        private string m_strShoriteishiKB_Param;                      // ˆ—’âŽ~‹æ•ªƒpƒ‰ƒ[ƒ^
        private string m_strHonsekiHittoshKB = string.Empty;          // –{Ð•M“ªŽÒŽæ“¾‹æ•ª(ˆ¶–¼ŠÇ—î•ñ)
        private string m_strShoriteishiKB = string.Empty;             // ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ª(ˆ¶–¼ŠÇ—î•ñ)
        private bool m_blnNenKin = false;                          // ”N‹à”Å”»’èƒtƒ‰ƒO
                                                                   // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000041 2011/05/18 ’Ç‰ÁŠJŽn
        private string m_strFrnZairyuJohoKB_Param = string.Empty;     // ŠO‘lÝ—¯î•ñŽæ“¾‹æ•ªƒpƒ‰ƒ[ƒ^
                                                                      // *—š—ð”Ô† 000041 2011/05/18 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000042 2011/05/18 ’Ç‰ÁŠJŽn
        private string m_strHonmyoTsushomeiYusenKB = string.Empty;    // –{–¼’ÊÌ–¼—DæÝ’è§Œä‹æ•ª(ˆ¶–¼ŠÇ—î•ñ)
                                                                      // *—š—ð”Ô† 000042 2011/05/18 ’Ç‰ÁI—¹
                                                                      // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁŠJŽn
        private string m_strJukiHokaiseiKB_Param;                     // ZŠî–@‰ü³‹æ•ª
                                                                      // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁI—¹
                                                                      // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁŠJŽn
        private string m_strMyNumberKB_Param = string.Empty;          // ‹¤’Ê”Ô†Žæ“¾‹æ•ª
                                                                      // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁI—¹
                                                                      // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁŠJŽn
        private DataTable m_csOrgNenkinKobetsu;                       // ”N‹àorŒÂ•Ê‚ÌŽž‚Ì•ÛŽƒXƒL[ƒ}
                                                                      // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁI—¹
        public ABEnumDefine.HyojunKB m_intHyojunKB;                   // ˆ¶–¼GET•W€‰»‹æ•ª
        private DataTable m_csOrgAtena1Hyojun;
        private DataTable m_csOrgAtena1KobetsuHyojun;
        private DataTable m_csOrgAtena1NenkinHyojun;
        private UFDateClass m_cfDate;
        private string m_strUmareYMDHenkanParam;
        private string m_strUmareWmdHenkan;
        private string m_strUmareWmdhenkanSeireki;
        private string m_strShojoIdobiHenkanParam;
        private string m_strShojoIdoWmdHenkan;
        private string m_strCknIdobiHenkanParam;
        private string m_strCknIdoWmdHenkan;

        #endregion

        #region  ƒRƒ“
        // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfUFControlData As UFControlData, 
        // *                               ByVal cfUFConfigDataClass As UFConfigDataClass,
        // *                               ByVal cfUFRdbClass as UFRdbClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfUFControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfUFConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfUFRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABAtenaHenshuBClass(UFControlData cfUFControlData, UFConfigDataClass cfUFConfigDataClass, UFRdbClass cfUFRdbClass)
        {
            Initial(cfUFControlData, cfUFConfigDataClass, cfUFRdbClass, ABEnumDefine.AtenaGetKB.KaniAll);
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfUFControlData As UFControlData, 
        // *                               ByVal cfUFConfigDataClass As UFConfigDataClass,
        // *                               ByVal cfUFRdbClass as UFRdbClass)
        // * @@                          ByVal blnSelectAll as boolean)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfUFControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfUFConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfUFRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * @@           ByVal blnSelectAll As Boolean           : True‚Ìê‡‘S€–ÚAFalse‚Ìê‡ŠÈˆÕ€–Ú‚Ì‚ÝŽæ“¾
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABAtenaHenshuBClass(UFControlData cfUFControlData, UFConfigDataClass cfUFConfigDataClass, UFRdbClass cfUFRdbClass, ABEnumDefine.AtenaGetKB blnSelectAll)
        {
            Initial(cfUFControlData, cfUFConfigDataClass, cfUFRdbClass, blnSelectAll);
        }
        // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfUFControlData As UFControlData, 
        // *                               ByVal cfUFConfigDataClass As UFConfigDataClass,
        // *                               ByVal cfUFRdbClass as UFRdbClass)
        // * @@                          ByVal blnSelectAll as boolean)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfUFControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfUFConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfUFRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * @@           ByVal blnSelectAll As Boolean           : True‚Ìê‡‘S€–ÚAFalse‚Ìê‡ŠÈˆÕ€–Ú‚Ì‚ÝŽæ“¾
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
        // Public Sub New(ByVal cfUFControlData As UFControlData, _
        // ByVal cfUFConfigDataClass As UFConfigDataClass, _
        // ByVal cfUFRdbClass As UFRdbClass)
        [SecuritySafeCritical]
        public void Initial(UFControlData cfUFControlData, UFConfigDataClass cfUFConfigDataClass, UFRdbClass cfUFRdbClass, ABEnumDefine.AtenaGetKB blnSelectAll)
        {
            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹

            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfUFControlData = cfUFControlData;
            m_cfUFConfigDataClass = cfUFConfigDataClass;
            m_cfUFRdbClass = cfUFRdbClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfUFLogClass = new UFLogClass(cfUFConfigDataClass, cfUFControlData.m_strBusinessId);

            // * —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
            // 'Žs’¬‘ºî•ñ‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            m_cuUSSCityInfo = new USSCityInfoClass();
            m_cuUSSCityInfo.GetCityInfo(m_cfUFControlData);

            /// ã”[ŠÖŒW‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            m_cABDainoKankeiB = new ABDainoKankeiBClass(m_cfUFControlData, m_cfUFConfigDataClass, m_cfUFRdbClass);

            // 'Z–¯Ží•Ê‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            m_cABJuminShubetsuB = new ABJuminShubetsuBClass(m_cfUFControlData, m_cfUFConfigDataClass);

            // '–@l–¼Ì‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            m_cABHojinMeishoB = new ABHojinMeishoBClass(m_cfUFControlData, m_cfUFConfigDataClass);

            // 'ŒÂl–@l‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            m_cABKjnhjnKBB = new ABKjnhjnKBBClass(m_cfUFControlData, m_cfUFConfigDataClass);

            // 'ŠÇ“àŠÇŠO‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            m_cABKannaiKangaiKBB = new ABKannaiKangaiKBBClass(m_cfUFControlData, m_cfUFConfigDataClass);

            // '¶”NŒŽ“ú•ÒW‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            m_cABUmareHenshuB = new ABUmareHenshuBClass(m_cfUFControlData, m_cfUFConfigDataClass);

            m_cABCommon = new ABCommonClass();

            // ŠÇ—î•ñŽæ“¾‚a‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            m_cURKanriJohoB = new URKANRIJOHOCacheBClass(m_cfUFControlData, m_cfUFConfigDataClass, m_cfUFRdbClass);
            // * —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽn

            // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
            m_blnSelectAll = blnSelectAll;
            // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹

            // * —š—ð”Ô† 000035 2008/02/15 ’Ç‰ÁŠJŽn
            m_cABMojiHenshuB = new ABMojiretsuHenshuBClass(m_cfUFControlData, m_cfUFConfigDataClass);
            // * —š—ð”Ô† 000035 2008/02/15 ’Ç‰ÁI—¹

            // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁŠJŽn
            // ŠÇ—î•ñŽæ“¾ˆ—
            GetKanriJoho();
            // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁI—¹

            // '•W€‰»ƒR[ƒh•ÒW‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            m_cABHyojunkaCdHenshuB = new ABHyojunkaCdHenshuBClass(m_cfUFControlData, m_cfUFConfigDataClass);

        }


        // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼       ŠÇ—î•ñŽæ“¾
        // * 
        // * \•¶             Private Function GetKanriJoho()
        // * 
        // * ‹@”\@@    @   ŠÇ—î•ñ‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”             ‚È‚µ
        // * 
        // * –ß‚è’l           ‚È‚µ
        // ************************************************************************************************
        private void GetKanriJoho()
        {
            const string THIS_METHOD_NAME = "GetKanriJoho";
            var cABAtenaKanriJoho = default(ABAtenaKanriJohoBClass);

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ˆ¶–¼ŠÇ—î•ñ‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                if (cABAtenaKanriJoho is null)
                {
                    cABAtenaKanriJoho = new ABAtenaKanriJohoBClass(m_cfUFControlData, m_cfUFConfigDataClass, m_cfUFRdbClass);
                }

                // –{ÐŽæ“¾‹æ•ªŽæ“¾
                m_strHonsekiHittoshKB = cABAtenaKanriJoho.GetHonsekiKB_Param;

                // ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ªŽæ“¾
                m_strShoriteishiKB = cABAtenaKanriJoho.GetShoriteishiKB_Param;

                // *—š—ð”Ô† 000042 2011/05/18 ’Ç‰ÁŠJŽn
                // –{–¼’ÊÌ–¼—DæÝ’è§ŒäŽæ“¾
                m_strHonmyoTsushomeiYusenKB = cABAtenaKanriJoho.GetHonmyoTsushomeiYusenKB_Param;
                // *—š—ð”Ô† 000042 2011/05/18 ’Ç‰ÁI—¹

                if (m_cfDate == null)
                {
                    m_cfDate = new UFDateClass(m_cfUFConfigDataClass);
                    m_cfDate.p_enDateSeparator = UFDateSeparator.None;
                }
                m_strUmareYMDHenkanParam = cABAtenaKanriJoho.GetUmareYMDHenkanHizuke_Param;
                m_cfDate.p_strDateValue = m_strUmareYMDHenkanParam;
                m_strUmareWmdHenkan = m_cfDate.p_strWarekiYMD;
                if (m_strUmareYMDHenkanParam.Trim().RLength >= 8)
                {
                    m_strUmareWmdhenkanSeireki = m_strUmareYMDHenkanParam.RSubstring(1, 7);
                }
                else
                {
                    m_strUmareWmdhenkanSeireki = string.Empty;
                }

                m_strShojoIdobiHenkanParam = cABAtenaKanriJoho.GetShojoIdobiHenkanHizuke_Param;
                m_cfDate.p_strDateValue = m_strShojoIdobiHenkanParam;
                m_strShojoIdoWmdHenkan = m_cfDate.p_strWarekiYMD;

                m_strCknIdobiHenkanParam = cABAtenaKanriJoho.GetCknIdobiHenkanHizuke_Param;
                m_cfDate.p_strDateValue = m_strCknIdobiHenkanParam;
                m_strCknIdoWmdHenkan = m_cfDate.p_strWarekiYMD;

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfUFLogClass.WarningWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22661


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22757


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 23029


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 23112


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

        }
        // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁI—¹
        #endregion

        #region  ˆ¶–¼•ÒW(AtenaHenshu) 
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼•ÒW
        // * 
        // * \•¶           Public Function AtenaHenshu(ByVal cAtenaGetPara1 As ABAtenaGetPara1, 
        // *                                           ByVal csAtenaEntity As DataSet) As DataSet
        // * 
        // * ‹@”\@@    @@•ÒWˆ¶–¼ƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”           cAtenaGetPara1     : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // *               csAtenaEntity      : ˆ¶–¼ƒf[ƒ^
        // * 
        // * –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        public DataSet AtenaHenshu(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtenaEntity)
        {

            // *—š—ð”Ô† 000013 2003/04/18 ’Ç‰ÁŠJŽn
            // Return Me.AtenaHenshu(cAtenaGetPara1, csAtenaEntity, "", "", "")
            return AtenaHenshu(cAtenaGetPara1, csAtenaEntity, "", "", "", "");
            // *—š—ð”Ô† 000013 2003/04/18 ’Ç‰ÁI—¹
        }

        // *—š—ð”Ô† 000013 2003/04/18 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼•ÒW
        // * 
        // * \•¶           Public Function AtenaHenshu(ByVal cAtenaGetPara1 As ABAtenaGetPara1,
        // *                                           ByVal csAtenaEntity As DataSet, 
        // *                                           ByVal strDainoKB As String,
        // *                                           ByVal strGyomuCD As String,
        // *                                           ByVal strGyomunaiSHU_CD As String) As DataSet
        // * 
        // * ‹@”\@@    @@•ÒWˆ¶–¼ƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”         cAtenaGetPara1      : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // * @@         csAtenaEntity       : ˆ¶–¼ƒf[ƒ^
        // * @@         strDainoKB          : ‘ã”[‹æ•ª
        // * @@         strGyomuCD          : ‹Æ–±ƒR[ƒh
        // * @@         strGyomunaiSHU_CD   : ‹Æ–±“àŽí•ÊƒR[ƒh
        // * 
        // * –ß‚è’l       DataSet(ABAtena1)   : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        public DataSet AtenaHenshu(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtenaEntity, string strDainoKB, string strGyomuCD, string strGyomunaiSHU_CD)
        {
            return AtenaHenshu(cAtenaGetPara1, csAtenaEntity, strDainoKB, strGyomuCD, strGyomunaiSHU_CD, "");
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼•ÒW
        // * 
        // * \•¶           Public Function AtenaHenshu(ByVal cAtenaGetPara1 As ABAtenaGetPara1,
        // *                                           ByVal csAtenaEntity As DataSet, 
        // *                                           ByVal strDainoKB As String,
        // *                                           ByVal strGyomuCD As String,
        // *                                           ByVal strGyomunaiSHU_CD As String,
        // *                                           ByVal strGyomuMei As String) As DataSet
        // * 
        // * ‹@”\@@    @@•ÒWˆ¶–¼ƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”         cAtenaGetPara1      : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^(ABAtenaGetPara1XClass)
        // *              csAtenaEntity       : ˆ¶–¼ƒf[ƒ^(ABAtenaEntity)
        // *              strDainoKB          : ‘ã”[‹æ•ª
        // *              strGyomuCD          : ‹Æ–±ƒR[ƒh
        // *              strGyomunaiSHU_CD   : ‹Æ–±“àŽí•ÊƒR[ƒh
        // *              strGyomuMei         : ‹Æ–±–¼
        // * 
        // * –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        private DataSet AtenaHenshu(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtenaEntity, string strDainoKB, string strGyomuCD, string strGyomunaiSHU_CD, string strGyomuMei)
        {
            // *—š—ð”Ô† 000013 2003/04/18 ’Ç‰ÁI—¹
            const string THIS_METHOD_NAME = "AtenaHenshu";
            // Dim cfErrorClass As UFErrorClass                    'ƒGƒ‰[ˆ—ƒNƒ‰ƒX
            // Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì
            // * corresponds to VS2008 Start 2010/04/16 000039
            // Dim csDataSet As DataSet
            // * corresponds to VS2008 End 2010/04/16 000039
            DataTable csDataTable;
            DataSet csAtena1;                             // ˆ¶–¼î•ñ(ABAtena1)
            DataRow csDataNewRow;
            // * —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
            // Dim cuUSSCityInfo As USSCityInfoClass               'Žs’¬‘ºî•ñŠÇ—ƒNƒ‰ƒX
            // Dim cABDainoKankeiB As ABDainoKankeiBClass          '‘ã”[ŠÖŒWƒNƒ‰ƒX
            // Dim cABJuminShubetsuB As ABJuminShubetsuBClass      'Z–¯Ží•ÊƒNƒ‰ƒX
            // Dim cABHojinMeishoB As ABHojinMeishoBClass          '–@l–¼ÌƒNƒ‰ƒX
            // Dim cABKjnhjnKBB As ABKjnhjnKBBClass                'ŒÂl–@lƒNƒ‰ƒX
            // Dim cABKannaiKangaiKBB As ABKannaiKangaiKBBClass    'ŠÇ“àŠÇŠOƒNƒ‰ƒX
            // Dim cABUmareHenshuB As ABUmareHenshuBClass          '¶”NŒŽ“ú•ÒWƒNƒ‰ƒX
            // * —š—ð”Ô† 000023 2004/08/27 íœI—¹
            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
            // Dim csDainoKankeiCDMSTEntity As DataSet             '‘ã”[ŠÖŒWDataSet
            DataRow[] csDainoKankeiCDMSTEntity;             // ‘ã”[ŠÖŒWDataRow()
                                                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj

            // * —š—ð”Ô† 000024 2005/01/25 íœŠJŽni‹{‘òj
            // Dim strHenshuJusho As String                        '•ÒWZŠ–¼
            // * —š—ð”Ô† 000024 2005/01/25 íœI—¹

            string strHenshuKanaMeisho;                   // •ÒWƒJƒi–¼Ì
            string strHenshuKanjiShimei;                  // •ÒWŠ¿ŽšŽ–¼
                                                          // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁŠJŽn
                                                          // *—š—ð”Ô† 000016 2003/08/22 íœŠJŽn
                                                          // Dim cURKanriJohoB As URKANRIJOHOBClass              'ŠÇ—î•ñŽæ“¾ƒNƒ‰ƒX
                                                          // *—š—ð”Ô† 000016 2003/08/22 íœI—¹
            SofuJushoGyoseikuType cSofuJushoGyoseikuType;
            var strJushoHenshu3 = default(string);                       // ZŠ•ÒW‚R
                                                                         // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁI—¹
                                                                         // *—š—ð”Ô† 000015 2003/04/30 ’Ç‰ÁŠJŽn
            var strJushoHenshu4 = default(string);                       // ZŠ•ÒW‚S
                                                                         // *—š—ð”Ô† 000015 2003/04/30 ’Ç‰ÁI—¹

            // *—š—ð”Ô† 000021 2003/12/02 íœŠJŽn
            // '*—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁŠJŽn
            // Dim cRenrakusakiBClass As ABRenrakusakiBClass       ' ˜A—æ‚aƒNƒ‰ƒX
            // Dim csRenrakusakiEntity As DataSet                  ' ˜A—æDataSet
            // Dim csRenrakusakiRow As DataRow                     ' ˜A—æRow
            // '*—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁI—¹
            // *—š—ð”Ô† 000021 2003/12/02 íœI—¹

            // * —š—ð”Ô† 000026 2005/12/21 ’Ç‰ÁŠJŽn
            string strWork;
            // * —š—ð”Ô† 000026 2005/12/21 ’Ç‰ÁI—¹
            // *—š—ð”Ô† 000042 2011/05/18 ’Ç‰ÁŠJŽn
            var strMeisho = new string[2];                          // –{–¼’ÊÌ–¼—Dæ§Œä—p
                                                                    // *—š—ð”Ô† 000042 2011/05/18 ’Ç‰ÁI—¹
            string strAtenaDataKB;
            string strAtenaDataSHU;


            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // 'ƒGƒ‰[ˆ—ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // '*—š—ð”Ô† 000010  2003/03/27 C³ŠJŽn
                // 'cfErrorClass = New UFErrorClass(m_cfUFControlData.m_strBusinessId)
                // cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                // '*—š—ð”Ô† 000010  2003/03/27 C³I—¹

                // *—š—ð”Ô† 000013 2003/04/18 C³ŠJŽn
                // 'ƒJƒ‰ƒ€î•ñì¬
                // csDataTable = Me.CreateAtena1Columns()
                // csAtena1 = New DataSet()
                // csAtena1.Tables.Add(csDataTable)

                // *—š—ð”Ô† 000019 2003/11/19 C³ŠJŽn
                // 'ƒJƒ‰ƒ€î•ñì¬
                // If (strGyomuMei = NENKIN) Then
                // csDataTable = Me.CreateNenkinAtenaColumns()
                // Else
                // csDataTable = Me.CreateAtena1Columns()
                // End If

                // *—š—ð”Ô† 000036 2008/11/10 ’Ç‰ÁŠJŽn
                // —˜—p“ÍoŽæ“¾‹æ•ª‚ð•Ï”‚ÉƒZƒbƒg()
                m_strRiyoTdkdKB = cAtenaGetPara1.p_strTdkdKB;
                // *—š—ð”Ô† 000036 2008/11/10 ’Ç‰ÁI—¹

                // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁŠJŽn
                // –{Ð•M“ªŽÒ‹æ•ªƒpƒ‰ƒ[ƒ^‚É•Ï”‚ðƒZƒbƒg
                m_strHonsekiHittoshKB_Param = cAtenaGetPara1.p_strHonsekiHittoshKB;

                // ˆ—’âŽ~‹æ•ªƒpƒ‰ƒ[ƒ^‚É•Ï”‚ðƒZƒbƒg
                m_strShoriteishiKB_Param = cAtenaGetPara1.p_strShoriTeishiKB;
                // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁI—¹

                // *—š—ð”Ô† 000041 2011/05/18 ’Ç‰ÁŠJŽn
                // ŠO‘lÝ—¯î•ñŽæ“¾‹æ•ªƒpƒ‰ƒ[ƒ^‚É•Ï”‚ðƒZƒbƒg
                m_strFrnZairyuJohoKB_Param = cAtenaGetPara1.p_strFrnZairyuJohoKB;
                // *—š—ð”Ô† 000041 2011/05/18 ’Ç‰ÁI—¹
                // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁŠJŽn
                // ZŠî–@‰ü³‹æ•ª‚ð•Ï”‚ÉƒZƒbƒg
                m_strJukiHokaiseiKB_Param = cAtenaGetPara1.p_strJukiHokaiseiKB;
                // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁI—¹
                // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁŠJŽn
                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ð•Ï”‚ÉƒZƒbƒg
                m_strMyNumberKB_Param = cAtenaGetPara1.p_strMyNumberKB;
                // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁI—¹

                // ƒJƒ‰ƒ€î•ñì¬
                switch (strGyomuMei ?? "")
                {
                    // *—š—ð”Ô† 000027 2006/07/31 C³ŠJŽn
                    case NENKIN:
                    case NENKIN_2:    // ”N‹àˆ¶–¼î•ñ
                        {
                            // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁŠJŽn
                            m_blnNenKin = true;
                            // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁI—¹
                            // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁŠJŽn
                            m_blnKobetsu = false;
                            m_strKobetsuShutokuKB = string.Empty;
                            // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁI—¹
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                csDataTable = CreateNenkinAtenaHyojunColumns(strGyomuMei);
                            }
                            else
                            {
                                csDataTable = CreateNenkinAtenaColumns(strGyomuMei);
                            }

                            break;
                        }
                    // Case NENKIN     ' ”N‹àˆ¶–¼î•ñ
                    // csDataTable = Me.CreateNenkinAtenaColumns()
                    // *—š—ð”Ô† 000027 2006/07/31 C³I—¹
                    case KOBETSU:    // ˆ¶–¼ŒÂ•Êî•ñ
                        {
                            // *—š—ð”Ô† 000034 2008/01/15 ’Ç‰ÁŠJŽn
                            // ŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ðƒƒ“ƒo•Ï”‚ÉƒZƒbƒg
                            m_strKobetsuShutokuKB = cAtenaGetPara1.p_strKobetsuShutokuKB.Trim;
                            // *—š—ð”Ô† 000034 2008/01/15 ’Ç‰ÁI—¹

                            // *—š—ð”Ô† 000036 2008/11/10 ’Ç‰ÁŠJŽn
                            m_blnKobetsu = true;
                            // *—š—ð”Ô† 000036 2008/11/10 ’Ç‰ÁI—¹
                            // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁŠJŽn
                            m_blnNenKin = false;
                            // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁI—¹
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                csDataTable = this.CreateAtena1KobetsuHyojunColumns();
                            }
                            else
                            {
                                csDataTable = CreateAtena1KobetsuColumns();
                            }       // ˆ¶–¼î•ñ

                            break;
                        }

                    default:
                        {
                            // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁŠJŽn
                            m_blnKobetsu = false;
                            m_blnNenKin = false;
                            m_strKobetsuShutokuKB = string.Empty;
                            // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁI—¹
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                csDataTable = CreateAtena1HyojunColumns();
                            }
                            else
                            {
                                csDataTable = CreateAtena1Columns();
                            }

                            break;
                        }
                }
                // *—š—ð”Ô† 000019 2003/11/19 C³I—¹
                csAtena1 = new DataSet();
                csAtena1.Tables.Add(csDataTable);
                // *—š—ð”Ô† 000013 2003/04/18 C³C³

                // * —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                // 'Žs’¬‘ºî•ñ‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cuUSSCityInfo = New USSCityInfoClass()

                /// ã”[ŠÖŒW‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cABDainoKankeiB = New ABDainoKankeiBClass(m_cfUFControlData, m_cfUFConfigDataClass, m_cfUFRdbClass)

                // 'Z–¯Ží•Ê‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cABJuminShubetsuB = New ABJuminShubetsuBClass(m_cfUFControlData, m_cfUFConfigDataClass)

                // '–@l–¼Ì‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cABHojinMeishoB = New ABHojinMeishoBClass(m_cfUFControlData, m_cfUFConfigDataClass)

                // 'ŒÂl–@l‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cABKjnhjnKBB = New ABKjnhjnKBBClass(m_cfUFControlData, m_cfUFConfigDataClass)

                // 'ŠÇ“àŠÇŠO‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cABKannaiKangaiKBB = New ABKannaiKangaiKBBClass(m_cfUFControlData, m_cfUFConfigDataClass)

                // '¶”NŒŽ“ú•ÒW‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cABUmareHenshuB = New ABUmareHenshuBClass(m_cfUFControlData, m_cfUFConfigDataClass)
                // * —š—ð”Ô† 000023 2004/08/27 íœI—¹

                // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁŠJŽn
                // *—š—ð”Ô† 000016 2003/08/22 íœŠJŽn
                // ŠÇ—î•ñŽæ“¾‚a‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cURKanriJohoB = New Densan.Reams.UR.UR001BB.URKANRIJOHOBClass(m_cfUFControlData, m_cfUFConfigDataClass, m_cfUFRdbClass)
                // *—š—ð”Ô† 000016 2003/08/22 íœI—¹
                // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁI—¹

                // *—š—ð”Ô† 000021 2003/12/02 íœŠJŽn
                // '*—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁŠJŽn
                // ' ˜A—æ‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cRenrakusakiBClass = New ABRenrakusakiBClass(m_cfUFControlData, m_cfUFConfigDataClass, m_cfUFRdbClass)
                // '*—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁI—¹
                // *—š—ð”Ô† 000021 2003/12/02 íœI—¹

                // *—š—ð”Ô† 000007 2003/03/17 ’Ç‰ÁŠJŽn
                // ƒpƒ‰ƒ[ƒ^‚Ìƒ`ƒFƒbƒN
                CheckColumnValue(cAtenaGetPara1);
                // *—š—ð”Ô† 000007 2003/03/17 ’Ç‰ÁI—¹

                // ZŠ•ÒW‚P‚ª"1"ŠŽ‚ÂZŠ•ÒW‚Q‚ª"1"‚Ìê‡
                // * —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                // If cAtenaGetPara1.p_strJushoHenshu1 = "1" And cAtenaGetPara1.p_strJushoHenshu2 = "1" Then

                // '’¼‹ß‚ÌŽs’¬‘º–¼‚ðŽæ“¾‚·‚é
                // cuUSSCityInfo.GetCityInfo(m_cfUFControlData)
                // End If
                // * —š—ð”Ô† 000023 2004/08/27 íœI—¹

                // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁŠJŽn
                // ZŠ•ÒW‚P‚ª"1"ŠŽ‚ÂZŠ•ÒW‚R‚ª""‚Ìê‡
                if (cAtenaGetPara1.p_strJushoHenshu1 == "1" & cAtenaGetPara1.p_strJushoHenshu3 == string.Empty)
                {
                    // *—š—ð”Ô† 000016 2003/08/22 C³ŠJŽn
                    // cSofuJushoGyoseikuType = cURKanriJohoB.GetSofuJushoGyoseiku_SofuJushoGyoseiku_Param

                    cSofuJushoGyoseikuType = this.GetSofuJushoGyoseikuType;
                    // *—š—ð”Ô† 000016 2003/08/22 C³I—¹
                    switch (cSofuJushoGyoseikuType)
                    {
                        case var @case when @case == SofuJushoGyoseikuType.Jusho_Banchi:
                            {
                                strJushoHenshu3 = "1";
                                strJushoHenshu4 = "";
                                break;
                            }
                        case var case1 when case1 == SofuJushoGyoseikuType.Jusho_Banchi_SP_Katagaki:
                            {
                                strJushoHenshu3 = "1";
                                strJushoHenshu4 = "1";
                                break;
                            }
                        case var case2 when case2 == SofuJushoGyoseikuType.Gyoseiku_SP_Banchi:
                            {
                                strJushoHenshu3 = "5";
                                strJushoHenshu4 = "";
                                break;
                            }
                        case var case3 when case3 == SofuJushoGyoseikuType.Gyoseiku_SP_Banchi_SP_Katagaki:
                            {
                                strJushoHenshu3 = "5";
                                strJushoHenshu4 = "1";
                                break;
                            }
                    }
                }
                else
                {
                    strJushoHenshu3 = cAtenaGetPara1.p_strJushoHenshu3;
                    strJushoHenshu4 = cAtenaGetPara1.p_strJushoHenshu4;
                }
                // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁI—¹

                // •ÒWˆ¶–¼ƒf[ƒ^‚ðì¬‚·‚é
                foreach (DataRow csDataRow in csAtenaEntity.Tables(ABAtenaEntity.TABLE_NAME).Rows)
                {
                    // *—š—ð”Ô† 000013 2003/04/18 C³ŠJŽn
                    // csDataNewRow = csAtena1.Tables(ABAtena1Entity.TABLE_NAME).NewRow

                    csDataNewRow = csDataTable.NewRow();
                    // *—š—ð”Ô† 000013 2003/04/18 C³I—¹

                    // *—š—ð”Ô† 000026 2005/12/21 ’Ç‰ÁŠJŽn
                    csDataNewRow.BeginEdit();
                    // *—š—ð”Ô† 000026 2005/12/21 ’Ç‰ÁI—¹

                    // *—š—ð”Ô† 000015 2003/04/30 ’Ç‰ÁŠJŽn
                    foreach (DataColumn csColumn in csDataNewRow.Table.Columns)
                        csDataNewRow[csColumn] = string.Empty;
                    // *—š—ð”Ô† 000015 2003/04/30 ’Ç‰ÁI—¹

                    // *—š—ð”Ô† 000021 2003/12/02 íœŠJŽn
                    // '*—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁŠJŽn
                    // ' ‹Æ–±ƒR[ƒh‚ªŽw’è‚³‚ê‚½ê‡
                    // If (strGyomuCD <> String.Empty) Then

                    // ' ˜A—æƒf[ƒ^‚ðŽæ“¾‚·‚é
                    // csRenrakusakiEntity = cRenrakusakiBClass.GetRenrakusakiBHoshu(CType(csDataRow(ABAtenaEntity.JUMINCD), String), strGyomuCD, strGyomunaiSHU_CD)
                    // If (csRenrakusakiEntity.Tables(ABRenrakusakiEntity.TABLE_NAME).Rows.Count <> 0) Then
                    // csRenrakusakiRow = csRenrakusakiEntity.Tables(ABRenrakusakiEntity.TABLE_NAME).Rows(0)
                    // Else
                    // csRenrakusakiRow = Nothing
                    // End If
                    // Else
                    // csRenrakusakiRow = Nothing
                    // End If
                    // *—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁI—¹
                    // *—š—ð”Ô† 000021 2003/12/02 íœI—¹

                    // Z–¯ƒR[ƒh
                    csDataNewRow(ABAtena1Entity.JUMINCD) = csDataRow(ABAtenaEntity.JUMINCD);

                    // ‘ã”[‹æ•ªŽw’è‚È‚µ‚Ìê‡
                    if (string.IsNullOrEmpty(strDainoKB))
                    {
                        // ‘ã”[‹æ•ª
                        csDataNewRow(ABAtena1Entity.DAINOKB) = "00";
                    }
                    else
                    {
                        // ‘ã”[‹æ•ª
                        csDataNewRow(ABAtena1Entity.DAINOKB) = strDainoKB;
                    }

                    if (Conversions.ToString(csDataNewRow(ABAtena1Entity.DAINOKB)) == "00")
                    {

                        // ‘ã”[‹æ•ª–¼Ì
                        csDataNewRow(ABAtena1Entity.DAINOKBMEISHO) = string.Empty;

                        // ‘ã”[‹æ•ª—ªŽ®–¼Ì
                        csDataNewRow(ABAtena1Entity.DAINOKBRYAKUMEISHO) = string.Empty;
                    }
                    else
                    {

                        // ‘ã”[ŠÖŒWƒf[ƒ^‚ðŽæ“¾‚·‚é

                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                        // csDainoKankeiCDMSTEntity = m_cABDainoKankeiB.GetDainoKBHoshu(CType(csDataNewRow(ABAtena1Entity.DAINOKB), String))
                        // ' ‚OŒ‚Ìê‡A
                        // If csDainoKankeiCDMSTEntity.Tables(ABDainoKankeiCDMSTEntity.TABLE_NAME).Rows.Count = 0 Then
                        // csDataNewRow(ABAtena1Entity.DAINOKBMEISHO) = String.Empty                   '‘ã”[‹æ•ª–¼Ì
                        // csDataNewRow(ABAtena1Entity.DAINOKBRYAKUMEISHO) = String.Empty              '‘ã”[‹æ•ª—ªŽ®–¼Ì
                        // Else
                        // With csDainoKankeiCDMSTEntity.Tables(ABDainoKankeiCDMSTEntity.TABLE_NAME).Rows(0)

                        // ' ‘ã”[‹æ•ª–¼Ì
                        // csDataNewRow(ABAtena1Entity.DAINOKBMEISHO) = CType(.Item(ABDainoKankeiCDMSTEntity.DAINOKBMEISHO), String)

                        // ' ‘ã”[‹æ•ª—ªŽ®–¼Ì
                        // csDataNewRow(ABAtena1Entity.DAINOKBRYAKUMEISHO) = CType(.Item(ABDainoKankeiCDMSTEntity.DAINOKBRYAKUMEI), String)
                        // End With
                        // End If
                        csDainoKankeiCDMSTEntity = m_cABDainoKankeiB.GetDainoKBHoshu2(Conversions.ToString(csDataNewRow(ABAtena1Entity.DAINOKB)));
                        if (csDainoKankeiCDMSTEntity.Length == 0)
                        {
                            csDataNewRow(ABAtena1Entity.DAINOKBMEISHO) = string.Empty;                   // ‘ã”[‹æ•ª–¼Ì
                            csDataNewRow(ABAtena1Entity.DAINOKBRYAKUMEISHO) = string.Empty;              // ‘ã”[‹æ•ª—ªŽ®–¼Ì
                        }
                        else
                        {

                            // ‘ã”[‹æ•ª–¼Ì
                            csDataNewRow(ABAtena1Entity.DAINOKBMEISHO) = Conversions.ToString(csDainoKankeiCDMSTEntity[0].Item(ABDainoKankeiCDMSTEntity.DAINOKBMEISHO));

                            // ‘ã”[‹æ•ª—ªŽ®–¼Ì
                            csDataNewRow(ABAtena1Entity.DAINOKBRYAKUMEISHO) = Conversions.ToString(csDainoKankeiCDMSTEntity[0].Item(ABDainoKankeiCDMSTEntity.DAINOKBRYAKUMEI));
                        }
                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                    }

                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                    {

                        // ‘ã”[‹æ•ªŽw’è‚È‚µ‚Ìê‡
                        if (string.IsNullOrEmpty(strGyomuCD))
                        {

                            // ‹Æ–±ƒR[ƒh
                            csDataNewRow(ABAtena1Entity.GYOMUCD) = "00";

                            // ‹Æ–±“àŽí•ÊƒR[ƒh
                            csDataNewRow(ABAtena1Entity.GYOMUNAISHU_CD) = string.Empty;
                        }
                        else
                        {
                            // ‹Æ–±ƒR[ƒh
                            csDataNewRow(ABAtena1Entity.GYOMUCD) = strGyomuCD;

                            // ‹Æ–±“àŽí•ÊƒR[ƒh
                            csDataNewRow(ABAtena1Entity.GYOMUNAISHU_CD) = strGyomunaiSHU_CD;
                        }

                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                    // ‹ŒŽs’¬‘ºƒR[ƒh
                    csDataNewRow(ABAtena1Entity.KYUSHICHOSONCD) = csDataRow(ABAtenaEntity.KYUSHICHOSONCD);

                    // ¢‘ÑƒR[ƒh
                    csDataNewRow(ABAtena1Entity.STAICD) = csDataRow(ABAtenaEntity.STAICD);

                    // ˆ¶–¼ƒf[ƒ^‹æ•ª
                    csDataNewRow(ABAtena1Entity.ATENADATAKB) = csDataRow(ABAtenaEntity.ATENADATAKB);

                    // ˆ¶–¼ƒf[ƒ^Ží•Ê
                    csDataNewRow(ABAtena1Entity.ATENADATASHU) = csDataRow(ABAtenaEntity.ATENADATASHU);

                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                    {
                        // •ÒWŽí•Ê
                        m_cABJuminShubetsuB.GetJuminshubetsu(Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATAKB)), Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATASHU)));
                        csDataNewRow(ABAtena1Entity.HENSHUSHUBETSU) = m_cABJuminShubetsuB.p_strHenshuShubetsu;

                        // •ÒWŽí•Ê—ªÌ
                        csDataNewRow(ABAtena1Entity.HENSHUSHUBETSURYAKU) = m_cABJuminShubetsuB.p_strHenshuShubetsuRyaku;
                        // ŒŸõ—pƒJƒi©–¼
                        csDataNewRow(ABAtena1Entity.SEARCHKANASEIMEI) = csDataRow(ABAtenaEntity.SEARCHKANASEIMEI);

                        // ŒŸõ—pƒJƒi©
                        csDataNewRow(ABAtena1Entity.SEARCHKANASEI) = csDataRow(ABAtenaEntity.SEARCHKANASEI);

                        // ŒŸõ—pƒJƒi–¼
                        csDataNewRow(ABAtena1Entity.SEARCHKANAMEI) = csDataRow(ABAtenaEntity.SEARCHKANAMEI);

                        // ŒŸõ—pŠ¿Žš–¼Ì
                        csDataNewRow(ABAtena1Entity.SEARCHKANJIMEI) = csDataRow(ABAtenaEntity.SEARCHKANJIMEISHO);
                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                    // *—š—ð”Ô† 000042 2011/05/18 ’Ç‰ÁŠJŽn
                    // –{–¼’ÊÌ–¼Ø‘Ö‘Î‰ž - ƒJƒi–¼ÌAŠ¿Žš–¼ÌŽæ“¾
                    switch (Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATAKB)) ?? "")
                    {
                        case "11":
                        case "12":         // Z“o“àAZ“oŠO
                            {

                                if (m_strHonmyoTsushomeiYusenKB.Trim() == "1")
                                {
                                    // ŠÇ—î•ñF–{–¼’ÊÌ–¼—Dæ§Œä = "1" ‚Ìê‡
                                    strMeisho = MeishoHenshu(csDataRow);
                                }
                                else
                                {
                                    strMeisho[0] = Conversions.ToString(csDataRow(ABAtenaEntity.KANAMEISHO1));       // ƒJƒi–¼Ì‚P
                                    strMeisho[1] = Conversions.ToString(csDataRow(ABAtenaEntity.KANJIMEISHO1));
                                }      // 

                                break;
                            }
                        case "20":               // –@l
                            {
                                break;
                            }

                        case "30":               // ‹¤—L
                            {
                                strMeisho[0] = Conversions.ToString(csDataRow(ABAtenaEntity.KANAMEISHO1));
                                strMeisho[1] = Conversions.ToString(csDataRow(ABAtenaEntity.KANJIMEISHO1));
                                break;
                            }

                        default:
                            {
                                break;
                            }
                    }
                    // *—š—ð”Ô† 000042 2011/05/18 ’Ç‰ÁI—¹

                    // •ÒWƒJƒi–¼Ì
                    // ˆ¶–¼‹æ•ª="20"(–@l)‚Ìê‡
                    if (Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATAKB)) == "20")
                    {
                        // * —š—ð”Ô† 000033 2007/07/17 C³ŠJŽn
                        // ƒJƒi–¼Ì‚QiŽx“X–¼j‚ª–³‚¢ê‡‚ÍƒJƒi–¼Ì‚Pi–@l–¼j‚ÆƒJƒi–¼Ì‚QiŽx“X–¼j‚ÌŒ‹‡‚Ís‚í‚È‚¢
                        if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.KANAMEISHO2)).Trim ?? new char[0]) != "")
                        {
                            strHenshuKanaMeisho = Conversions.ToString(csDataRow(ABAtenaEntity.KANAMEISHO1)).TrimEnd + " " + Conversions.ToString(csDataRow(ABAtenaEntity.KANAMEISHO2)).TrimEnd;
                        }
                        else
                        {
                            strHenshuKanaMeisho = Conversions.ToString(csDataRow(ABAtenaEntity.KANAMEISHO1)).TrimEnd;
                        }
                        // strHenshuKanaMeisho = CType(csDataRow(ABAtenaEntity.KANAMEISHO1), String).TrimEnd + _
                        // " " + CType(csDataRow(ABAtenaEntity.KANAMEISHO2), String).TrimEnd
                        // * —š—ð”Ô† 000033 2007/07/17 C³I—¹
                        // * —š—ð”Ô† 000032 2007/07/09 C³ŠJŽn
                        if (strHenshuKanaMeisho.RLength > 240)
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUKANASHIMEI) = strHenshuKanaMeisho.RSubstring(0, 240);
                        }
                        // If (strHenshuKanaMeisho.Length > 60) Then
                        // csDataNewRow(ABAtena1Entity.HENSHUKANASHIMEI) = strHenshuKanaMeisho.Substring(0, 60)
                        // * —š—ð”Ô† 000032 2007/07/09 C³I—¹
                        else
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUKANASHIMEI) = strHenshuKanaMeisho;
                        }
                    }
                    else
                    {
                        // *—š—ð”Ô† 000042 2011/05/18 C³ŠJŽn
                        strHenshuKanaMeisho = strMeisho[0];
                        csDataNewRow(ABAtena1Entity.HENSHUKANASHIMEI) = ABStrXClass.Left(strHenshuKanaMeisho, ABAtenaGetConstClass.KETA_HENSHUKANAMEISHO);
                        // csDataNewRow(ABAtena1Entity.HENSHUKANASHIMEI) = csDataRow(ABAtenaEntity.KANAMEISHO1)
                        // *—š—ð”Ô† 000042 2011/05/18 C³I—¹
                    }
                    // •ÒWƒJƒi–¼Ìiƒtƒ‹j
                    if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                    {
                        csDataNewRow(ABAtena1HyojunEntity.HENSHUKANASHIMEI_FULL) = strHenshuKanaMeisho;
                    }
                    else
                    {
                    }

                    // •ÒWŠ¿Žš–¼Ì
                    // ˆ¶–¼‹æ•ª="20"(–@l)‚Ìê‡
                    if (Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATAKB)) == "20")
                    {
                        m_cABHojinMeishoB.p_strKeitaiFuyoKB = Conversions.ToString(csDataRow(ABAtenaEntity.HANYOKB1));
                        m_cABHojinMeishoB.p_strKeitaiSeiRyakuKB = Conversions.ToString(csDataRow(ABAtenaEntity.HANYOKB2));
                        m_cABHojinMeishoB.p_strKanjiHjnKeitai = Conversions.ToString(csDataRow(ABAtenaEntity.KANJIHJNKEITAI));
                        m_cABHojinMeishoB.p_strKanjiMeisho1 = Conversions.ToString(csDataRow(ABAtenaEntity.KANJIMEISHO1));
                        m_cABHojinMeishoB.p_strKanjiMeisho2 = Conversions.ToString(csDataRow(ABAtenaEntity.KANJIMEISHO2));
                        strHenshuKanjiShimei = m_cABHojinMeishoB.GetHojinMeisho();
                        // * —š—ð”Ô† 000032 2007/07/09 C³ŠJŽn
                        if (strHenshuKanjiShimei.RLength > 240)
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = strHenshuKanjiShimei.RSubstring(0, 240);
                        }
                        // If (strHenshuKanjiShimei.Length > 80) Then
                        // csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = strHenshuKanjiShimei.Substring(0, 80)
                        // * —š—ð”Ô† 000032 2007/07/09 C³I—¹
                        else
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = strHenshuKanjiShimei;
                        }
                    }
                    // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                    // csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = csDataRow(ABAtenaEntity.KANJIMEISHO1)
                    else if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                    {
                        // *—š—ð”Ô† 000042 2011/05/18 C³ŠJŽn
                        // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                        strHenshuKanjiShimei = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATAKB)), Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATASHU)), strMeisho[1]);
                        csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = ABStrXClass.Left(strHenshuKanjiShimei, ABAtenaGetConstClass.KETA_HENSHUKANJIMEISHO);
                    }
                    // csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = m_cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataRow(ABAtenaEntity.ATENADATAKB)), _
                    // CStr(csDataRow(ABAtenaEntity.ATENADATASHU)), _
                    // CStr(csDataRow(ABAtenaEntity.KANJIMEISHO1)))
                    // *—š—ð”Ô† 000042 2011/05/18 C³I—¹
                    else
                    {
                        // *—š—ð”Ô† 000042 2011/05/18 C³ŠJŽn
                        // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                        strHenshuKanjiShimei = strMeisho[1];
                        csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = ABStrXClass.Left(strHenshuKanjiShimei, ABAtenaGetConstClass.KETA_HENSHUKANJIMEISHO);
                        // csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = csDataRow(ABAtenaEntity.KANJIMEISHO1)
                        // *—š—ð”Ô† 000042 2011/05/18 C³I—¹
                        // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹
                    }
                    // •ÒWŠ¿Žš–¼Ìiƒtƒ‹j
                    if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                    {
                        csDataNewRow(ABAtena1HyojunEntity.HENSHUKANJISHIMEI_FULL) = strHenshuKanjiShimei;
                    }
                    else
                    {
                    }

                    if (csDataRow(ABAtenaEntity.ATENADATAKB).ToString == ABConstClass.ATENADATAKB_JUTONAI_KOJIN)
                    {
                        if (csDataRow(ABAtenaEntity.UMAREYMD).ToString.Trim == string.Empty)
                        {
                            csDataNewRow(ABAtena1Entity.UMAREYMD) = m_strUmareYMDHenkanParam;
                            if (csDataRow(ABAtenaEntity.ATENADATASHU).ToString.RSubstring(0, 1) == "1")
                            {
                                csDataNewRow(ABAtena1Entity.UMAREWMD) = m_strUmareWmdHenkan;
                            }
                            else
                            {
                                csDataNewRow(ABAtena1Entity.UMAREWMD) = m_strUmareWmdhenkanSeireki;
                            }
                        }
                        else if (CheckDate(csDataRow(ABAtenaEntity.UMAREYMD).ToString))
                        {
                            csDataNewRow(ABAtena1Entity.UMAREYMD) = csDataRow(ABAtenaEntity.UMAREYMD);
                            csDataNewRow(ABAtena1Entity.UMAREWMD) = csDataRow(ABAtenaEntity.UMAREWMD);
                        }
                        else
                        {
                            csDataNewRow(ABAtena1Entity.UMAREYMD) = GetSeirekiLastDay(csDataRow(ABAtenaEntity.UMAREYMD).ToString);
                            csDataNewRow(ABAtena1Entity.UMAREWMD) = GetWarekiLastDay(csDataRow(ABAtenaEntity.UMAREWMD).ToString, csDataRow(ABAtenaEntity.UMAREYMD).ToString);
                        }
                    }
                    else
                    {
                        // ¶”NŒŽ“ú
                        csDataNewRow(ABAtena1Entity.UMAREYMD) = csDataRow(ABAtenaEntity.UMAREYMD);

                        // ¶”NŒŽ“ú•ÒW
                        csDataNewRow(ABAtena1Entity.UMAREWMD) = csDataRow(ABAtenaEntity.UMAREWMD);
                    }

                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                    {
                        m_cABUmareHenshuB.p_strDataKB = Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATAKB));
                        m_cABUmareHenshuB.p_strJuminSHU = Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATASHU));
                        m_cABUmareHenshuB.p_strUmareYMD = Conversions.ToString(csDataNewRow(ABAtena1Entity.UMAREYMD));
                        m_cABUmareHenshuB.p_strUmareWMD = Conversions.ToString(csDataNewRow(ABAtena1Entity.UMAREWMD));
                        m_cABUmareHenshuB.HenshuUmare();
                        // ¶•\Ž¦”NŒŽ“ú
                        csDataNewRow(ABAtena1Entity.UMAREHYOJIWMD) = m_cABUmareHenshuB.p_strHyojiUmareYMD;

                        // ¶Ø–¾”NŒŽ“ú
                        csDataNewRow(ABAtena1Entity.UMARESHOMEIWMD) = m_cABUmareHenshuB.p_strShomeiUmareYMD;

                        // «•ÊƒR[ƒh
                        csDataNewRow(ABAtena1Entity.SEIBETSUCD) = csDataRow(ABAtenaEntity.SEIBETSUCD);

                        // «•Ê
                        strWork = Conversions.ToString(csDataRow(ABAtenaEntity.SEIBETSU)).Trim;
                        csDataNewRow(ABAtena1Entity.SEIBETSU) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_SEIBETSU);
                        // «•Êiƒtƒ‹j
                        if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                        {
                            csDataNewRow(ABAtena1HyojunEntity.SEIBETSU_FULL) = csDataRow(ABAtenaEntity.SEIBETSU);
                        }
                        else
                        {
                        }

                        // •ÒW‘±•¿ƒR[ƒh
                        // *—š—ð”Ô† 000002 2003/02/20 C³ŠJŽn
                        // If CType(ABAtenaEntity.DAI2ZOKUGARACD, String) = String.Empty Then
                        if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.DAI2ZOKUGARACD)).Trim ?? new char[0]) == "")
                        {
                            // *—š—ð”Ô† 000002 2003/02/20 C³I—¹
                            csDataNewRow(ABAtena1Entity.HENSHUZOKUGARACD) = csDataRow(ABAtenaEntity.ZOKUGARACD);
                        }
                        else
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUZOKUGARACD) = csDataRow(ABAtenaEntity.DAI2ZOKUGARACD);
                        }

                        // •ÒW‘±•¿
                        // *—š—ð”Ô† 000002 2003/02/20 C³ŠJŽn
                        // If CType(ABAtenaEntity.DAI2ZOKUGARA, String) = String.Empty Then
                        if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.DAI2ZOKUGARA)).Trim ?? new char[0]) == "")
                        {
                            // *—š—ð”Ô† 000002 2003/02/20 C³I—¹
                            csDataNewRow(ABAtena1Entity.HENSHUZOKUGARA) = csDataRow(ABAtenaEntity.ZOKUGARA);
                        }
                        else
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUZOKUGARA) = csDataRow(ABAtenaEntity.DAI2ZOKUGARA);
                        }

                        // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                        // –@l‘ã•\ŽÒ–¼
                        // csDataNewRow(ABAtena1Entity.HOJINDAIHYOUSHA) = csDataRow(ABAtenaEntity.KANJIHJNDAIHYOSHSHIMEI)
                        if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                        {
                            // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                            csDataNewRow(ABAtena1Entity.HOJINDAIHYOUSHA) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATAKB)), Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATASHU)), Conversions.ToString(csDataRow(ABAtenaEntity.KANJIHJNDAIHYOSHSHIMEI)));
                        }
                        else
                        {
                            // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                            csDataNewRow(ABAtena1Entity.HOJINDAIHYOUSHA) = csDataRow(ABAtenaEntity.KANJIHJNDAIHYOSHSHIMEI);
                        }
                        // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹
                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                    // ŒÂl–@l‹æ•ª
                    csDataNewRow(ABAtena1Entity.KJNHJNKB) = csDataRow(ABAtenaEntity.KJNHJNKB);

                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                    {
                        // ŒÂl–@l‹æ•ª–¼Ì
                        csDataNewRow(ABAtena1Entity.KJNHJNKBMEISHO) = m_cABKjnhjnKBB.GetKjnhjn(Conversions.ToString(csDataRow(ABAtenaEntity.KJNHJNKB)));

                        // ŠÇ“àŠÇŠO‹æ•ª–¼Ì
                        csDataNewRow(ABAtena1Entity.NAIGAIKBMEISHO) = m_cABKannaiKangaiKBB.GetKannaiKangai(Conversions.ToString(csDataRow(ABAtenaEntity.KANNAIKANGAIKB)));
                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                    // ŠÇ“àŠÇŠO‹æ•ª
                    csDataNewRow(ABAtena1Entity.KANNAIKANGAIKB) = csDataRow(ABAtenaEntity.KANNAIKANGAIKB);

                    // ZŠî—Dæ‚Ìê‡
                    if (cAtenaGetPara1.p_strJukiJutogaiKB == "1")
                    {

                        // —X•Ö”Ô†
                        csDataNewRow(ABAtena1Entity.YUBINNO) = csDataRow(ABAtenaEntity.JUKIYUBINNO);

                        // ZŠƒR[ƒh
                        csDataNewRow(ABAtena1Entity.JUSHOCD) = csDataRow(ABAtenaEntity.JUKIJUSHOCD);

                        // ZŠ
                        csDataNewRow(ABAtena1Entity.JUSHO) = csDataRow(ABAtenaEntity.JUKIJUSHO);

                        // •ÒWZŠ–¼
                        if (cAtenaGetPara1.p_strJushoHenshu1 == string.Empty)
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = string.Empty;
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •ÒWZŠ–¼iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.HENSHUJUSHO_FULL) = string.Empty;
                            }
                            else
                            {
                            }
                        }

                        else if (cAtenaGetPara1.p_strJushoHenshu1 == "1")
                        {
                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽn
                            // strHenshuJusho = String.Empty
                            m_strHenshuJusho.RRemove(0, m_strHenshuJusho.RLength);
                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹

                            if (cAtenaGetPara1.p_strJushoHenshu2 == "1")
                            {

                                // Žs’¬‘º–¼‚ð“ª‚É•t‰Á‚·‚éiŠÇ“à‚Ì‚Ýj
                                if (Conversions.ToString(csDataRow(ABAtenaEntity.KANNAIKANGAIKB)) == "1")
                                {
                                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽn
                                    // strHenshuJusho += m_cuUSSCityInfo.p_strShichosonmei(0)
                                    m_strHenshuJusho.Append(m_cuUSSCityInfo.p_strShichosonmei(0));
                                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹
                                }


                            }
                            // *—š—ð”Ô† 000008 2003/03/17 C³ŠJŽn
                            // Select Case cAtenaGetPara1.p_strJushoHenshu3
                            switch (strJushoHenshu3 ?? "")
                            {
                                // *—š—ð”Ô† 000008 2003/03/17 C³I—¹
                                // * —š—ð”Ô† 000028 2007/01/15 C³ŠJŽn
                                case "1":
                                case "6":   // ZŠ{”Ô’n
                                    {
                                        // Case "1"    'ZŠ{”Ô’n
                                        // * —š—ð”Ô† 000028 2007/01/15 C³I—¹
                                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽn
                                        // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUKIJUSHO), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaEntity.JUKIBANCHI), String).TrimEnd
                                        m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIJUSHO)).TrimEnd);
                                        m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIBANCHI)).TrimEnd);
                                        break;
                                    }
                                // * —š—ð”Ô† 000024 2005/01/25 XVI—¹
                                case "2":    // s­‹æ{”Ô’n
                                    {
                                        // *—š—ð”Ô† 000009 2003/03/17 C³ŠJŽn
                                        // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaEntity.JUKIBANCHI), String).TrimEnd
                                        // s­‹æ–¼‚ª‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI)).Trim ?? new char[0]) == "")
                                        {
                                            // ZŠ{”Ô’n
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽn
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUKIJUSHO), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIJUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIBANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹
                                        else
                                        {
                                            // s­‹æ{”Ô’n
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽn
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIBANCHI)).TrimEnd);
                                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹
                                        }

                                        break;
                                    }
                                // *—š—ð”Ô† 000009 2003/03/17 C³I—¹
                                case "3":    // ZŠ{is­‹æj{”Ô’n
                                    {
                                        // *—š—ð”Ô† 000004  2003/02/25 C³ŠJŽn
                                        // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUKIJUSHO), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaEntity.JUKIBANCHI), String).TrimEnd

                                        // s­‹æ–¼‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽn
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUKIJUSHO), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIJUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIBANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹
                                        else
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽn
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUKIJUSHO), String).TrimEnd _
                                            // + "i" _
                                            // + CType(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI), String).TrimEnd _
                                            // + "j" _
                                            // + CType(csDataRow(ABAtenaEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIJUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append("i");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append("j");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIBANCHI)).TrimEnd);
                                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹
                                        }

                                        break;
                                    }
                                // *—š—ð”Ô† 000004  2003/02/25 C³I—¹
                                case "4":    // s­‹æ{iZŠj{”Ô’n
                                    {
                                        // *—š—ð”Ô† 000004  2003/02/25 C³ŠJŽn
                                        // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaEntity.JUKIJUSHO), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaEntity.JUKIBANCHI), String).TrimEnd

                                        // ZŠ‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIJUSHO)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽn
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIBANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹
                                        // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁŠJŽn
                                        // s­‹æ‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        else if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // ZŠ{”Ô’n
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽn
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUKIJUSHO), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIJUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIBANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹
                                        // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁI—¹
                                        else
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽn
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI), String).TrimEnd _
                                            // + "i" _
                                            // + CType(csDataRow(ABAtenaEntity.JUKIJUSHO), String).TrimEnd _
                                            // + "j" _
                                            // + CType(csDataRow(ABAtenaEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append("i");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIJUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append("j");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIBANCHI)).TrimEnd);
                                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹
                                        }

                                        break;
                                    }
                                // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁŠJŽn
                                case "5":    // s­‹æ{¢{”Ô’n
                                    {
                                        // s­‹æ–¼‚ª‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI)).Trim ?? new char[0]) == "")
                                        {
                                            // ZŠ{”Ô’n
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽn
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUKIJUSHO), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIJUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIBANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹
                                        else
                                        {
                                            // s­‹æ{”Ô’n
                                            // 
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI), String).TrimEnd _
                                            // + "@" _
                                            // + CType(csDataRow(ABAtenaEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append("@");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIBANCHI)).TrimEnd);
                                        }

                                        break;
                                    }
                                    // *—š—ð”Ô† 000009 2003/03/17 C³I—¹
                            }
                            // *—š—ð”Ô† 000008 2003/03/17 C³ŠJŽn
                            // If cAtenaGetPara1.p_strJushoHenshu4 = "1" Then
                            // * —š—ð”Ô† 000028 2007/01/15 C³ŠJŽn
                            if (strJushoHenshu4 == "1" && new string(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIKATAGAKI)).Trim ?? new char[0]) != "")
                            {
                                // If strJushoHenshu4 = "1" Then
                                // * —š—ð”Ô† 000028 2007/01/15 C³I—¹
                                // *—š—ð”Ô† 000008 2003/03/17 C³I—¹
                                // *—š—ð”Ô† 000004  2003/02/25 C³ŠJŽn
                                // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUKIKATAGAKI), String).TrimEnd

                                // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽn
                                // strHenshuJusho += "@" + CType(csDataRow(ABAtenaEntity.JUKIKATAGAKI), String).TrimEnd
                                m_strHenshuJusho.Append("@");
                                m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIKATAGAKI)).TrimEnd);
                                // * —š—ð”Ô† 000024 2005/01/25 XVI—¹
                                // *—š—ð”Ô† 000004  2003/02/25 C³I—¹
                            }
                            // * —š—ð”Ô† 000028 2007/01/15 ’Ç‰ÁŠJŽn
                            // ZŠ•ÒW‚Rƒpƒ‰ƒ[ƒ^‚ª‚UAŠŽ‚Âs­‹æ–¼‚ª‚ ‚é‚Æ‚«‚ÍA•ÒWZŠ‚Éis­‹æj‚ð’Ç‰Á‚·‚é
                            if (strJushoHenshu3 == "6" && new string(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI)).Trim ?? new char[0]) != "")
                            {
                                m_strHenshuJusho.Append("i");
                                m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI)).TrimEnd);
                                m_strHenshuJusho.Append("j");
                            }
                            // * —š—ð”Ô† 000028 2007/01/15 ’Ç‰ÁI—¹
                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽn
                            // If strHenshuJusho.Length >= 80 Then
                            // csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = strHenshuJusho.Substring(0, 80)
                            // Else
                            // csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = strHenshuJusho
                            // End If
                            // * —š—ð”Ô† 000032 2007/07/09 C³ŠJŽn
                            if (m_strHenshuJusho.RLength >= 160)
                            {
                                csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = m_strHenshuJusho.ToString().RSubstring(0, 160);
                            }
                            // If m_strHenshuJusho.Length >= 80 Then
                            // csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = m_strHenshuJusho.ToString.Substring(0, 80)
                            // * —š—ð”Ô† 000032 2007/07/09 C³I—¹
                            else
                            {
                                csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = m_strHenshuJusho.ToString();
                            }
                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •ÒWZŠ–¼iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.HENSHUJUSHO_FULL) = m_strHenshuJusho.ToString();
                            }
                            else
                            {
                            }
                        }

                        // ”Ô’nƒR[ƒh‚P
                        csDataNewRow(ABAtena1Entity.BANCHICD1) = csDataRow(ABAtenaEntity.JUKIBANCHICD1);

                        // ”Ô’nƒR[ƒh‚Q
                        csDataNewRow(ABAtena1Entity.BANCHICD2) = csDataRow(ABAtenaEntity.JUKIBANCHICD2);

                        // ”Ô’nƒR[ƒh‚R
                        csDataNewRow(ABAtena1Entity.BANCHICD3) = csDataRow(ABAtenaEntity.JUKIBANCHICD3);

                        // ”Ô’n
                        if (cAtenaGetPara1.p_strJushoHenshu1 == "1")
                        {

                            // ZŠ•ÒW‚ ‚è‚Ìê‡‚ÍANull
                            csDataNewRow(ABAtena1Entity.BANCHI) = string.Empty;
                        }
                        else
                        {
                            csDataNewRow(ABAtena1Entity.BANCHI) = csDataRow(ABAtenaEntity.JUKIBANCHI);
                        }

                        // •û‘ƒtƒ‰ƒO
                        csDataNewRow(ABAtena1Entity.KATAGAKIFG) = csDataRow(ABAtenaEntity.JUKIKATAGAKIFG);

                        // •û‘ƒR[ƒh
                        csDataNewRow(ABAtena1Entity.KATAGAKICD) = csDataRow(ABAtenaEntity.JUKIKATAGAKICD);

                        // •û‘
                        if (cAtenaGetPara1.p_strJushoHenshu1 == "1" & cAtenaGetPara1.p_strJushoHenshu4 == "1")
                        {
                            // •û‘•t‰Á‚ ‚è‚Ìê‡‚ÍANull
                            csDataNewRow(ABAtena1Entity.KATAGAKI) = string.Empty;
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •û‘iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.KATAGAKI_FULL) = string.Empty;
                            }
                            else
                            {
                            }
                        }
                        else
                        {
                            strWork = Conversions.ToString(csDataRow(ABAtenaEntity.JUKIKATAGAKI)).Trim;
                            csDataNewRow(ABAtena1Entity.KATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •û‘iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.KATAGAKI_FULL) = csDataRow(ABAtenaEntity.JUKIKATAGAKI);
                            }
                            else
                            {
                            }
                        }

                        // *—š—ð”Ô† 000017 2003/10/09 C³ŠJŽn
                        // '˜A—æ‚P
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csDataRow(ABAtenaEntity.RENRAKUSAKI1)
                        // '˜A—æ‚Q
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csDataRow(ABAtenaEntity.RENRAKUSAKI2)

                        // *—š—ð”Ô† 000021 2003/12/02 C³ŠJŽn
                        // ' ˜A—æƒ}ƒXƒ^‚ª‘¶Ý‚·‚éê‡‚ÍA˜A—æƒ}ƒXƒ^‚Ì˜A—æ‚ðÝ’è‚·‚é
                        // If (csRenrakusakiRow Is Nothing) Then
                        // '˜A—æ‚P
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csDataRow(ABAtenaEntity.RENRAKUSAKI1)
                        // '˜A—æ‚Q
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csDataRow(ABAtenaEntity.RENRAKUSAKI2)
                        // Else
                        // '˜A—æ‚P
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKI1)
                        // '˜A—æ‚Q
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKI2)
                        // '˜A—æŽæ“¾‹Æ–±ƒR[ƒh
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI_GYOMUCD) = strGyomuCD
                        // End If
                        // '*—š—ð”Ô† 000017 2003/10/09 C³I—¹

                        // ˜A—æ‚P
                        csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csDataRow(ABAtenaEntity.RENRAKUSAKI1);
                        // ˜A—æ‚Q
                        csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csDataRow(ABAtenaEntity.RENRAKUSAKI2);
                        // *—š—ð”Ô† 000021 2003/12/02 C³I—¹

                        // s­‹æƒR[ƒh
                        csDataNewRow(ABAtena1Entity.GYOSEIKUCD) = csDataRow(ABAtenaEntity.JUKIGYOSEIKUCD);

                        // s­‹æ–¼
                        csDataNewRow(ABAtena1Entity.GYOSEIKUMEI) = csDataRow(ABAtenaEntity.JUKIGYOSEIKUMEI);

                        // ’n‹æƒR[ƒh‚P
                        csDataNewRow(ABAtena1Entity.CHIKUCD1) = csDataRow(ABAtenaEntity.JUKICHIKUCD1);

                        // ’n‹æ‚P
                        csDataNewRow(ABAtena1Entity.CHIKUMEI1) = csDataRow(ABAtenaEntity.JUKICHIKUMEI1);

                        // ’n‹æƒR[ƒh‚Q
                        csDataNewRow(ABAtena1Entity.CHIKUCD2) = csDataRow(ABAtenaEntity.JUKICHIKUCD2);

                        // ’n‹æ‚Q
                        csDataNewRow(ABAtena1Entity.CHIKUMEI2) = csDataRow(ABAtenaEntity.JUKICHIKUMEI2);

                        // ’n‹æƒR[ƒh‚R
                        csDataNewRow(ABAtena1Entity.CHIKUCD3) = csDataRow(ABAtenaEntity.JUKICHIKUCD3);

                        // ’n‹æ‚R
                        csDataNewRow(ABAtena1Entity.CHIKUMEI3) = csDataRow(ABAtenaEntity.JUKICHIKUMEI3);

                        // •\Ž¦‡i‘æ‚QZ–¯•[•\Ž¦‡‚ª‚ ‚éê‡‚ÍA‘æ‚QZ–¯•[•\Ž¦‡j
                        // *—š—ð”Ô† 000002 2003/02/20 C³ŠJŽn
                        // If CType(csDataRow(ABAtenaEntity.DAI2JUMINHYOHYOJIJUN), String) = String.Empty Then
                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽn IF•¶‚ÅˆÍ‚Þ
                        if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                        {
                            if (Conversions.ToString(csDataRow(ABAtenaEntity.DAI2JUMINHYOHYOJIJUN)).Trim == "00")
                            {
                                // *—š—ð”Ô† 000002 2003/02/20 C³I—¹
                                csDataNewRow(ABAtena1Entity.HYOJIJUN) = csDataRow(ABAtenaEntity.JUMINHYOHYOJIJUN);
                            }
                            else
                            {
                                csDataNewRow(ABAtena1Entity.HYOJIJUN) = csDataRow(ABAtenaEntity.DAI2JUMINHYOHYOJIJUN);
                            }
                        }
                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹ IF•¶‚ÅˆÍ‚Þ
                    else
                    {

                        // —X•Ö”Ô†
                        csDataNewRow(ABAtena1Entity.YUBINNO) = csDataRow(ABAtenaEntity.YUBINNO);

                        // ZŠƒR[ƒh
                        csDataNewRow(ABAtena1Entity.JUSHOCD) = csDataRow(ABAtenaEntity.JUSHOCD);

                        // ZŠ
                        csDataNewRow(ABAtena1Entity.JUSHO) = csDataRow(ABAtenaEntity.JUSHO);

                        // •ÒWZŠ–¼
                        if (cAtenaGetPara1.p_strJushoHenshu1 == string.Empty)
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = string.Empty;
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •ÒWZŠ–¼iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.HENSHUJUSHO_FULL) = string.Empty;
                            }
                            else
                            {
                            }
                        }

                        else if (cAtenaGetPara1.p_strJushoHenshu1 == "1")
                        {
                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                            // strHenshuJusho = String.Empty
                            m_strHenshuJusho.RRemove(0, m_strHenshuJusho.RLength);
                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                            if (cAtenaGetPara1.p_strJushoHenshu2 == "1")
                            {

                                // ŠÇ“à‚Ì‚ÝŽs’¬‘º–¼‚ð•t‰Á‚·‚é
                                if (Conversions.ToString(csDataRow(ABAtenaEntity.KANNAIKANGAIKB)) == "1")
                                {
                                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                    // strHenshuJusho += m_cuUSSCityInfo.p_strShichosonmei(0)
                                    m_strHenshuJusho.Append(m_cuUSSCityInfo.p_strShichosonmei(0));
                                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                }
                            }
                            // *—š—ð”Ô† 000008 2003/03/17 C³ŠJŽn
                            // Select Case cAtenaGetPara1.p_strJushoHenshu3
                            switch (strJushoHenshu3 ?? "")
                            {
                                // *—š—ð”Ô† 000008 2003/03/17 C³I—¹
                                // * —š—ð”Ô† 000028 2007/01/15 C³ŠJŽn
                                case "1":
                                case "6":   // ZŠ{”Ô’n
                                    {
                                        // Case "1"    'ZŠ{”Ô’n
                                        // * —š—ð”Ô† 000028 2007/01/15 C³I—¹
                                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                        // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUSHO), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaEntity.BANCHI), String).TrimEnd
                                        m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUSHO)).TrimEnd);
                                        m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.BANCHI)).TrimEnd);
                                        break;
                                    }
                                // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                case "2":    // s­‹æ{”Ô’n
                                    {
                                        // *—š—ð”Ô† 000009 2003/03/17 C³ŠJŽn
                                        // strHenshuJusho += CType(csDataRow(ABAtenaEntity.GYOSEIKUMEI), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaEntity.BANCHI), String).TrimEnd
                                        // s­‹æ–¼‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.GYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // ZŠ{”Ô’n
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUSHO), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.BANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        else
                                        {
                                            // s­‹æ{”Ô’n
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.GYOSEIKUMEI), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.GYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.BANCHI)).TrimEnd);
                                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        }

                                        break;
                                    }
                                // *—š—ð”Ô† 000009 2003/03/17 C³I—¹
                                case "3":    // ZŠ{is­‹æj{”Ô’n
                                    {
                                        // *—š—ð”Ô† 000004  2003/02/25 C³ŠJŽn
                                        // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUSHO), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaEntity.GYOSEIKUMEI), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaEntity.BANCHI), String).TrimEnd

                                        // s­‹æ–¼‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.GYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUSHO), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.BANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        else
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUSHO), String).TrimEnd _
                                            // + "i" _
                                            // + CType(csDataRow(ABAtenaEntity.GYOSEIKUMEI), String).TrimEnd _
                                            // + "j" _
                                            // + CType(csDataRow(ABAtenaEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append("i");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.GYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append("j");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.BANCHI)).TrimEnd);
                                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        }

                                        break;
                                    }
                                // *—š—ð”Ô† 000004  2003/02/25 C³I—¹

                                case "4":    // s­‹æ{iZŠj{”Ô’n
                                    {
                                        // *—š—ð”Ô† 000004 2003/02/25 C³ŠJŽn
                                        // strHenshuJusho += CType(csDataRow(ABAtenaEntity.GYOSEIKUMEI), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaEntity.JUSHO), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaEntity.BANCHI), String).TrimEnd

                                        // ZŠ‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.JUSHO)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.GYOSEIKUMEI), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.GYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.BANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁŠJŽn
                                        else if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.GYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // ZŠ{”Ô’n
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUSHO), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.BANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁI—¹
                                        else
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.GYOSEIKUMEI), String).TrimEnd _
                                            // + "i" _
                                            // + CType(csDataRow(ABAtenaEntity.JUSHO), String).TrimEnd _
                                            // + "j" _
                                            // + CType(csDataRow(ABAtenaEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.GYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append("i");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append("j");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.BANCHI)).TrimEnd);
                                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        }

                                        break;
                                    }
                                // *—š—ð”Ô† 000004 2003/02/25 C³I—¹
                                // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁŠJŽn
                                case "5":    // s­‹æ{¢{”Ô’n
                                    {
                                        // *—š—ð”Ô† 000009 2003/03/17 C³ŠJŽn
                                        // s­‹æ–¼‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.GYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // ZŠ{”Ô’n
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.JUSHO), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.JUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.BANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        else
                                        {
                                            // s­‹æ{”Ô’n
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaEntity.GYOSEIKUMEI), String).TrimEnd _
                                            // + "@" _
                                            // + CType(csDataRow(ABAtenaEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.GYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append("@");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.BANCHI)).TrimEnd);
                                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        }

                                        break;
                                    }
                                    // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁI—¹
                            }
                            // *—š—ð”Ô† 000008 2003/03/17 C³ŠJŽn
                            // If cAtenaGetPara1.p_strJushoHenshu4 = "1" Then
                            // * —š—ð”Ô† 000028 2007/01/15 C³ŠJŽn
                            if (strJushoHenshu4 == "1" && new string(Conversions.ToString(csDataRow(ABAtenaEntity.KATAGAKI)).Trim ?? new char[0]) != "")
                            {
                                // If strJushoHenshu4 = "1" Then
                                // * —š—ð”Ô† 000028 2007/01/15 C³I—¹
                                // *—š—ð”Ô† 000008 2003/03/17 C³I—¹
                                // *—š—ð”Ô† 000004  2003/02/25 C³ŠJŽn
                                // strHenshuJusho += CType(csDataRow(ABAtenaEntity.KATAGAKI), String).TrimEnd

                                // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                // strHenshuJusho += "@" + CType(csDataRow(ABAtenaEntity.KATAGAKI), String).TrimEnd
                                m_strHenshuJusho.Append("@");
                                m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.KATAGAKI)).TrimEnd);
                                // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                // *—š—ð”Ô† 000004  2003/02/25 C³I—¹
                            }
                            // * —š—ð”Ô† 000028 2007/01/15 ’Ç‰ÁŠJŽn
                            // ZŠ•ÒW‚Rƒpƒ‰ƒ[ƒ^‚ª‚UAŠŽ‚Âs­‹æ–¼‚ª‚ ‚é‚Æ‚«‚ÍA•ÒWZŠ‚Éis­‹æj‚ð’Ç‰Á‚·‚é
                            if (strJushoHenshu3 == "6" && new string(Conversions.ToString(csDataRow(ABAtenaEntity.GYOSEIKUMEI)).Trim ?? new char[0]) != "")
                            {
                                m_strHenshuJusho.Append("i");
                                m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.GYOSEIKUMEI)).TrimEnd);
                                m_strHenshuJusho.Append("j");
                            }
                            // * —š—ð”Ô† 000028 2007/01/15 ’Ç‰ÁI—¹
                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                            // If strHenshuJusho.Length >= 80 Then
                            // csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = strHenshuJusho.Substring(0, 80)
                            // Else
                            // csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = strHenshuJusho
                            // End If
                            // * —š—ð”Ô† 000032 2007/07/09 C³ŠJŽn
                            if (m_strHenshuJusho.RLength >= 160)
                            {
                                csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = m_strHenshuJusho.ToString().RSubstring(0, 160);
                            }
                            // If m_strHenshuJusho.Length >= 80 Then
                            // csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = m_strHenshuJusho.ToString().Substring(0, 80)
                            // * —š—ð”Ô† 000032 2007/07/09 C³I—¹
                            else
                            {
                                csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = m_strHenshuJusho.ToString();
                            }
                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •ÒWZŠ–¼iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.HENSHUJUSHO_FULL) = m_strHenshuJusho.ToString();
                            }
                            else
                            {
                            }
                        }

                        // ”Ô’nƒR[ƒh‚P
                        csDataNewRow(ABAtena1Entity.BANCHICD1) = csDataRow(ABAtenaEntity.BANCHICD1);

                        // ”Ô’nƒR[ƒh‚Q
                        csDataNewRow(ABAtena1Entity.BANCHICD2) = csDataRow(ABAtenaEntity.BANCHICD2);

                        // ”Ô’nƒR[ƒh‚R
                        csDataNewRow(ABAtena1Entity.BANCHICD3) = csDataRow(ABAtenaEntity.BANCHICD3);

                        // ”Ô’n
                        if (cAtenaGetPara1.p_strJushoHenshu1 == "1")
                        {

                            // ZŠ•ÒW‚ ‚è‚Ìê‡‚ÍANull
                            csDataNewRow(ABAtena1Entity.BANCHI) = "";
                        }
                        else
                        {
                            csDataNewRow(ABAtena1Entity.BANCHI) = csDataRow(ABAtenaEntity.BANCHI);
                        }

                        // •û‘ƒtƒ‰ƒO
                        csDataNewRow(ABAtena1Entity.KATAGAKIFG) = csDataRow(ABAtenaEntity.KATAGAKIFG);

                        // •û‘ƒR[ƒh
                        csDataNewRow(ABAtena1Entity.KATAGAKICD) = csDataRow(ABAtenaEntity.KATAGAKICD);

                        // •û‘
                        if (cAtenaGetPara1.p_strJushoHenshu1 == "1" & cAtenaGetPara1.p_strJushoHenshu4 == "1")
                        {

                            // •û‘•t‰Á‚ ‚è‚Ìê‡‚ÍANull
                            csDataNewRow(ABAtena1Entity.KATAGAKI) = "";
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •û‘iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.KATAGAKI_FULL) = string.Empty;
                            }
                            else
                            {
                            }
                        }
                        else
                        {
                            strWork = Conversions.ToString(csDataRow(ABAtenaEntity.KATAGAKI)).Trim;
                            csDataNewRow(ABAtena1Entity.KATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •û‘iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.KATAGAKI_FULL) = csDataRow(ABAtenaEntity.KATAGAKI);
                            }
                            else
                            {
                            }
                        }

                        // *—š—ð”Ô† 000017 2003/10/09 C³ŠJŽn
                        // '˜A—æ‚P
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csDataRow(ABAtenaEntity.RENRAKUSAKI1)
                        // '˜A—æ‚Q
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csDataRow(ABAtenaEntity.RENRAKUSAKI2)

                        // *—š—ð”Ô† 000021 2003/12/02 C³ŠJŽn
                        // ' ˜A—æƒ}ƒXƒ^‚ª‘¶Ý‚·‚éê‡‚ÍA˜A—æƒ}ƒXƒ^‚Ì˜A—æ‚ðÝ’è‚·‚é
                        // If (csRenrakusakiRow Is Nothing) Then
                        // '˜A—æ‚P
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csDataRow(ABAtenaEntity.RENRAKUSAKI1)
                        // '˜A—æ‚Q
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csDataRow(ABAtenaEntity.RENRAKUSAKI2)
                        // Else
                        // '˜A—æ‚P
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKI1)
                        // '˜A—æ‚Q
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKI2)
                        // '˜A—æŽæ“¾‹Æ–±ƒR[ƒh
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI_GYOMUCD) = strGyomuCD
                        // End If
                        // '*—š—ð”Ô† 000017 2003/10/09 C³I—¹

                        // ˜A—æ‚P
                        csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csDataRow(ABAtenaEntity.RENRAKUSAKI1);
                        // ˜A—æ‚Q
                        csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csDataRow(ABAtenaEntity.RENRAKUSAKI2);
                        // *—š—ð”Ô† 000021 2003/12/02 C³I—¹

                        // s­‹æƒR[ƒh
                        csDataNewRow(ABAtena1Entity.GYOSEIKUCD) = csDataRow(ABAtenaEntity.GYOSEIKUCD);

                        // s­‹æ–¼
                        csDataNewRow(ABAtena1Entity.GYOSEIKUMEI) = csDataRow(ABAtenaEntity.GYOSEIKUMEI);

                        // ’n‹æƒR[ƒh‚P
                        csDataNewRow(ABAtena1Entity.CHIKUCD1) = csDataRow(ABAtenaEntity.CHIKUCD1);

                        // ’n‹æ‚P
                        csDataNewRow(ABAtena1Entity.CHIKUMEI1) = csDataRow(ABAtenaEntity.CHIKUMEI1);

                        // ’n‹æƒR[ƒh‚Q
                        csDataNewRow(ABAtena1Entity.CHIKUCD2) = csDataRow(ABAtenaEntity.CHIKUCD2);

                        // ’n‹æ‚Q
                        csDataNewRow(ABAtena1Entity.CHIKUMEI2) = csDataRow(ABAtenaEntity.CHIKUMEI2);

                        // ’n‹æƒR[ƒh‚R
                        csDataNewRow(ABAtena1Entity.CHIKUCD3) = csDataRow(ABAtenaEntity.CHIKUCD3);

                        // ’n‹æ‚R
                        csDataNewRow(ABAtena1Entity.CHIKUMEI3) = csDataRow(ABAtenaEntity.CHIKUMEI3);

                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                        if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                        {
                            // * —š—ð”Ô† 000026 2005/12/21 C³ŠJŽn
                            // '•\Ž¦‡
                            // csDataNewRow(ABAtena1Entity.HYOJIJUN) = String.Empty

                            // •\Ž¦‡i‘æ‚QZ–¯•[•\Ž¦‡‚ª‚ ‚éê‡‚ÍA‘æ‚QZ–¯•[•\Ž¦‡j
                            if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                            {
                                strWork = Conversions.ToString(csDataRow(ABAtenaEntity.DAI2JUMINHYOHYOJIJUN)).Trim;
                                if (strWork == "00")
                                {
                                    strWork = csDataRow(ABAtenaEntity.JUMINHYOHYOJIJUN).ToString().Trim;
                                }
                                if (string.IsNullOrEmpty(strWork))
                                {
                                    strWork = "99";
                                }
                                csDataNewRow(ABAtena1Entity.HYOJIJUN) = strWork;
                            }
                            // * —š—ð”Ô† 000026 2005/12/21 C³I—¹
                        }
                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                    {

                        // “o˜^ˆÙ“®”NŒŽ“ú 
                        csDataNewRow(ABAtena1Entity.TOROKUIDOYMD) = csDataRow(ABAtenaEntity.TOROKUIDOYMD);

                        // “o˜^Ž–—RƒR[ƒh
                        csDataNewRow(ABAtena1Entity.TOROKUJIYUCD) = csDataRow(ABAtenaEntity.TOROKUJIYUCD);

                        // “o˜^Ž–—R
                        csDataNewRow(ABAtena1Entity.TOROKUJIYU) = csDataRow(ABAtenaEntity.TOROKUJIYU);

                        if ((csDataRow(ABAtenaEntity.ATENADATAKB).ToString == ABConstClass.ATENADATAKB_JUTONAI_KOJIN || csDataRow(ABAtenaEntity.ATENADATAKB).ToString == ABConstClass.ATENADATAKB_JUTOGAI_KOJIN) && !(csDataRow(ABAtenaEntity.SHOJOJIYUCD).ToString.Trim == string.Empty))
                        {
                            if (csDataRow(ABAtenaEntity.SHOJOIDOYMD).ToString.Trim == string.Empty)
                            {
                                csDataNewRow(ABAtena1Entity.SHOJOIDOYMD) = m_strShojoIdobiHenkanParam;
                            }
                            else
                            {
                                csDataNewRow(ABAtena1Entity.SHOJOIDOYMD) = csDataRow(ABAtenaEntity.SHOJOIDOYMD);
                            }
                        }
                        else
                        {
                            // ÁœˆÙ“®”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.SHOJOIDOYMD) = csDataRow(ABAtenaEntity.SHOJOIDOYMD);
                        }

                        // ÁœŽ–—RƒR[ƒh
                        csDataNewRow(ABAtena1Entity.SHOJOJIYUCD) = csDataRow(ABAtenaEntity.SHOJOJIYUCD);

                        // ÁœŽ–—R–¼Ì
                        csDataNewRow(ABAtena1Entity.SHOJOJIYU) = csDataRow(ABAtenaEntity.SHOJOJIYU);

                        // •ÒW¢‘ÑŽåZ–¯ƒR[ƒh
                        // *—š—ð”Ô† 000002 2003/02/20 C³ŠJŽn
                        // If CType(csDataRow(ABAtenaEntity.DAI2STAINUSJUMINCD), String) = String.Empty Then
                        if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.DAI2STAINUSJUMINCD)).Trim ?? new char[0]) == "")
                        {
                            // *—š—ð”Ô† 000002 2003/02/20 C³I—¹
                            csDataNewRow(ABAtena1Entity.HENSHUNUSHIJUMINCD) = csDataRow(ABAtenaEntity.STAINUSJUMINCD);
                        }
                        else
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUNUSHIJUMINCD) = csDataRow(ABAtenaEntity.DAI2STAINUSJUMINCD);
                        }
                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                    // •ÒWƒJƒi¢‘ÑŽå–¼
                    // *—š—ð”Ô† 000002 2003/02/20 C³ŠJŽn
                    // If CType(csDataRow(ABAtenaEntity.KANADAI2STAINUSMEI), String) = String.Empty Then
                    if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.KANADAI2STAINUSMEI)).Trim ?? new char[0]) == "")
                    {
                        // *—š—ð”Ô† 000002 2003/02/20 C³I—¹
                        csDataNewRow(ABAtena1Entity.HENSHUKANANUSHIMEI) = csDataRow(ABAtenaEntity.KANASTAINUSMEI);
                    }
                    else
                    {
                        csDataNewRow(ABAtena1Entity.HENSHUKANANUSHIMEI) = csDataRow(ABAtenaEntity.KANADAI2STAINUSMEI);
                    }

                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                    {
                        // •ÒWŠ¿Žš¢‘ÑŽå–¼
                        // *—š—ð”Ô† 000002 2003/02/20 C³ŠJŽn
                        // If CType(csDataRow(ABAtenaEntity.DAI2STAINUSMEI), String) = String.Empty Then
                        if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.DAI2STAINUSMEI)).Trim ?? new char[0]) == "")
                        {
                            // *—š—ð”Ô† 000002 2003/02/20 C³I—¹
                            // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                            // csDataNewRow(ABAtena1Entity.HENSHUNUSHIMEI) = csDataRow(ABAtenaEntity.STAINUSMEI)
                            if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                                csDataNewRow(ABAtena1Entity.HENSHUNUSHIMEI) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaEntity.STAINUSMEI)));
                            }
                            else
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                                csDataNewRow(ABAtena1Entity.HENSHUNUSHIMEI) = csDataRow(ABAtenaEntity.STAINUSMEI);
                            }
                        }
                        // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹
                        // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                        // csDataNewRow(ABAtena1Entity.HENSHUNUSHIMEI) = csDataRow(ABAtenaEntity.DAI2STAINUSMEI)
                        else if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                        {
                            // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                            csDataNewRow(ABAtena1Entity.HENSHUNUSHIMEI) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaEntity.DAI2STAINUSMEI)));
                        }
                        else
                        {
                            // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                            csDataNewRow(ABAtena1Entity.HENSHUNUSHIMEI) = csDataRow(ABAtenaEntity.DAI2STAINUSMEI);
                            // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹
                        }

                        // *—š—ð”Ô† 000012 2003/04/18 ’Ç‰ÁŠJŽn
                        // ‘±•¿ƒR[ƒh
                        csDataNewRow(ABAtena1Entity.ZOKUGARACD) = csDataRow(ABAtenaEntity.ZOKUGARACD);
                        // ‘±•¿
                        csDataNewRow(ABAtena1Entity.ZOKUGARA) = csDataRow(ABAtenaEntity.ZOKUGARA);

                        // *—š—ð”Ô† 000014 2003/04/30 C³ŠJŽn
                        // ' ƒJƒi–¼Ì‚Q
                        // csDataNewRow(ABAtena1Entity.KANAMEISHO2) = csDataRow(ABAtenaEntity.KANAMEISHO2)
                        // ' Š¿Žš–¼Ì‚Q
                        // csDataNewRow(ABAtena1Entity.KANJIMEISHO2) = csDataRow(ABAtenaEntity.KANJIMEISHO2)

                        // ˆ¶–¼‹æ•ª‚"20"(–@l)‚Ìê‡
                        if (!(Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATAKB)) == "20"))
                        {
                            // ƒJƒi–¼Ì‚Q
                            csDataNewRow(ABAtena1Entity.KANAMEISHO2) = csDataRow(ABAtenaEntity.KANAMEISHO2);
                            // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                            // Š¿Žš–¼Ì‚Q
                            // csDataNewRow(ABAtena1Entity.KANJIMEISHO2) = csDataRow(ABAtenaEntity.KANJIMEISHO2)
                            if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                                csDataNewRow(ABAtena1Entity.KANJIMEISHO2) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATAKB)), Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATASHU)), Conversions.ToString(csDataRow(ABAtenaEntity.KANJIMEISHO2)));
                            }
                            else
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                                csDataNewRow(ABAtena1Entity.KANJIMEISHO2) = csDataRow(ABAtenaEntity.KANJIMEISHO2);
                            }
                            // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹
                        }
                        // *—š—ð”Ô† 000014 2003/04/30 C³I—¹

                        // Ð”Ô†
                        csDataNewRow(ABAtena1Entity.SEKINO) = csDataRow(ABAtenaEntity.SEKINO);
                        // *—š—ð”Ô† 000012 2003/04/18 ’Ç‰ÁI—¹
                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                    // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁŠJŽn
                    // –{Ð•M“ªŽÒî•ño—Í”»’è
                    if (m_strHonsekiHittoshKB_Param == "1" && m_strHonsekiHittoshKB == "1")
                    {
                        // ƒpƒ‰ƒ[ƒ^:–{Ð•M“ªŽÒŽæ“¾‹æ•ª‚ª"1"‚©‚ÂAŠÇ—î•ñ:–{ÐŽæ“¾‹æ•ª(10¥18)‚ª"1"‚Ìê‡‚Ì‚ÝƒZƒbƒg
                        // –{ÐZŠ
                        csDataNewRow(ABAtena1Entity.HON_JUSHO) = csDataRow(ABAtenaEntity.HON_JUSHO);
                        // –{Ð”Ô’n
                        csDataNewRow(ABAtena1Entity.HONSEKIBANCHI) = csDataRow(ABAtenaEntity.HONSEKIBANCHI);
                        // •M“ªŽÒ
                        csDataNewRow(ABAtena1Entity.HITTOSH) = csDataRow(ABAtenaEntity.HITTOSH);
                    }
                    else
                    {
                    }

                    // ˆ—’âŽ~‹æ•ªo—Í”»’è
                    if (m_strShoriteishiKB_Param == "1" && m_strShoriteishiKB == "1")
                    {
                        // ƒpƒ‰ƒ[ƒ^:ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ª‚ª"1"‚©‚ÂAŠÇ—î•ñ:ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ª(10¥19)‚ª"1"‚Ìê‡‚Ì‚ÝƒZƒbƒg
                        // ˆ—’âŽ~‹æ•ª
                        csDataNewRow(ABAtena1Entity.SHORITEISHIKB) = csDataRow(ABAtenaEntity.SHORITEISHIKB);
                    }
                    else
                    {
                    }
                    // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁI—¹

                    // *—š—ð”Ô† 000041 2011/05/18 ’Ç‰ÁŠJŽn
                    if (m_strFrnZairyuJohoKB_Param == "1")
                    {
                        // ƒpƒ‰ƒ[ƒ^FŠO‘lÝ—¯Ž‘ŠiŽæ“¾‹æ•ª‚ª"1"‚Ìê‡
                        // ‘Ð
                        strWork = Conversions.ToString(csDataRow(ABAtenaEntity.KOKUSEKI)).Trim;
                        csDataNewRow(ABAtena1Entity.KOKUSEKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KOKUSEKI);
                        // ‘Ðiƒtƒ‹j
                        if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                        {
                            csDataNewRow(ABAtena1HyojunEntity.KOKUSEKI_FULL) = csDataRow(ABAtenaEntity.KOKUSEKI);
                        }
                        else
                        {
                        }
                        // Ý—¯Ž‘ŠiƒR[ƒh
                        csDataNewRow(ABAtena1Entity.ZAIRYUSKAKCD) = csDataRow(ABAtenaEntity.ZAIRYUSKAKCD);
                        // Ý—¯Ž‘Ši
                        csDataNewRow(ABAtena1Entity.ZAIRYUSKAK) = csDataRow(ABAtenaEntity.ZAIRYUSKAK);
                        // Ý—¯ŠúŠÔ
                        csDataNewRow(ABAtena1Entity.ZAIRYUKIKAN) = csDataRow(ABAtenaEntity.ZAIRYUKIKAN);
                        // Ý—¯ŠJŽn”NŒŽ“ú
                        csDataNewRow(ABAtena1Entity.ZAIRYU_ST_YMD) = csDataRow(ABAtenaEntity.ZAIRYU_ST_YMD);
                        // Ý—¯I—¹”NŒŽ“ú
                        csDataNewRow(ABAtena1Entity.ZAIRYU_ED_YMD) = csDataRow(ABAtenaEntity.ZAIRYU_ED_YMD);
                    }
                    else
                    {
                    }
                    // *—š—ð”Ô† 000041 2011/05/18 ’Ç‰ÁI—¹

                    // *—š—ð”Ô† 000013 2003/04/18 C³ŠJŽn
                    // 'ƒf[ƒ^ƒŒƒR[ƒh‚Ì’Ç‰Á
                    // csAtena1.Tables(ABAtena1Entity.TABLE_NAME).Rows.Add(csDataNewRow)

                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                    {
                        // ”N‹à—pƒf[ƒ^ì¬
                        // *—š—ð”Ô† 000027 2006/07/31 C³ŠJŽn
                        if ((strGyomuMei ?? "") == NENKIN | (strGyomuMei ?? "") == NENKIN_2)
                        {
                            // If (strGyomuMei = NENKIN) Then
                            // *—š—ð”Ô† 000027 2006/07/31 C³I—¹

                            // ‹Œ©
                            csDataNewRow(ABNenkinAtenaEntity.KYUSEI) = csDataRow(ABAtenaEntity.KYUSEI);
                            // Z’èˆÙ“®”NŒŽ“ú
                            csDataNewRow(ABNenkinAtenaEntity.JUTEIIDOYMD) = csDataRow(ABAtenaEntity.JUTEIIDOYMD);
                            // Z’èŽ–—R
                            csDataNewRow(ABNenkinAtenaEntity.JUTEIJIYU) = csDataRow(ABAtenaEntity.JUTEIJIYU);
                            // “]“ü‘OZŠ—X•Ö”Ô†
                            csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_YUBINNO) = csDataRow(ABAtenaEntity.TENUMAEJ_YUBINNO);
                            // *—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁŠJŽn
                            // “]“ü‘OZŠ‘S‘ZŠƒR[ƒh
                            csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_ZJUSHOCD) = csDataRow(ABAtenaEntity.TENUMAEJ_ZJUSHOCD);
                            // *—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁI—¹
                            // “]“ü‘OZŠZŠ
                            csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_JUSHO) = csDataRow(ABAtenaEntity.TENUMAEJ_JUSHO);
                            // “]“ü‘OZŠ”Ô’n
                            csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_BANCHI) = csDataRow(ABAtenaEntity.TENUMAEJ_BANCHI);
                            // “]“ü‘OZŠ•û‘
                            strWork = Conversions.ToString(csDataRow(ABAtenaEntity.TENUMAEJ_KATAGAKI)).Trim;
                            csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_KATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                            // “]o—\’è—X•Ö”Ô†
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIYUBINNO) = csDataRow(ABAtenaEntity.TENSHUTSUYOTEIYUBINNO);
                            // “]o—\’è‘S‘ZŠƒR[ƒh
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIZJUSHOCD) = csDataRow(ABAtenaEntity.TENSHUTSUYOTEIZJUSHOCD);
                            // “]o—\’èˆÙ“®”NŒŽ“ú
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIIDOYMD) = csDataRow(ABAtenaEntity.TENSHUTSUYOTEIIDOYMD);
                            // “]o—\’èZŠ
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIJUSHO) = csDataRow(ABAtenaEntity.TENSHUTSUYOTEIJUSHO);
                            // “]o—\’è”Ô’n
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIBANCHI) = csDataRow(ABAtenaEntity.TENSHUTSUYOTEIBANCHI);
                            // “]o—\’è•û‘
                            strWork = Conversions.ToString(csDataRow(ABAtenaEntity.TENSHUTSUYOTEIKATAGAKI)).Trim;
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIKATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                            // “]oŠm’è—X•Ö”Ô†
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIYUBINNO) = csDataRow(ABAtenaEntity.TENSHUTSUKKTIYUBINNO);
                            // *—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁŠJŽn
                            // “]oŠm’è‘S‘ZŠƒR[ƒh
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIZJUSHOCD) = csDataRow(ABAtenaEntity.TENSHUTSUKKTIZJUSHOCD);
                            // *—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁI—¹
                            // “]oŠm’èˆÙ“®”NŒŽ“ú
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIIDOYMD) = csDataRow(ABAtenaEntity.TENSHUTSUKKTIIDOYMD);
                            // “]oŠm’è’Ê’m”NŒŽ“ú
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTITSUCHIYMD) = csDataRow(ABAtenaEntity.TENSHUTSUKKTITSUCHIYMD);
                            // “]oŠm’èZŠ
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIJUSHO) = csDataRow(ABAtenaEntity.TENSHUTSUKKTIJUSHO);
                            // “]oŠm’è”Ô’n
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIBANCHI) = csDataRow(ABAtenaEntity.TENSHUTSUKKTIBANCHI);
                            // “]oŠm’è•û‘
                            strWork = Conversions.ToString(csDataRow(ABAtenaEntity.TENSHUTSUKKTIKATAGAKI)).Trim;
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIKATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);

                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // “]“ü‘OZŠ•û‘iƒtƒ‹j
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_KATAGAKI_FULL) = csDataRow(ABAtenaEntity.TENUMAEJ_KATAGAKI);
                                // “]o—\’è•û‘iƒtƒ‹j
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIKATAGAKI_FULL) = csDataRow(ABAtenaEntity.TENSHUTSUYOTEIKATAGAKI);
                                // “]oŠm’è•û‘iƒtƒ‹j
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTIKATAGAKI_FULL) = csDataRow(ABAtenaEntity.TENSHUTSUKKTIKATAGAKI);
                            }
                            else
                            {
                            }

                            // ZŠî—Dæ‚Ìê‡
                            if (cAtenaGetPara1.p_strJukiJutogaiKB == "1")
                            {
                                // •ÒW‘O”Ô’n
                                csDataNewRow(ABNenkinAtenaEntity.HENSHUMAEBANCHI) = csDataRow(ABAtenaEntity.JUKIBANCHI);
                                // •ÒW‘O•û‘
                                strWork = Conversions.ToString(csDataRow(ABAtenaEntity.JUKIKATAGAKI)).Trim;
                                csDataNewRow(ABNenkinAtenaEntity.HENSHUMAEKATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    // •ÒW‘O•û‘iƒtƒ‹j
                                    csDataNewRow(ABNenkinAtenaHyojunEntity.HENSHUMAEKATAGAKI_FULL) = csDataRow(ABAtenaEntity.JUKIKATAGAKI);
                                }
                                else
                                {
                                }
                            }
                            else
                            {
                                // •ÒW‘O”Ô’n
                                csDataNewRow(ABNenkinAtenaEntity.HENSHUMAEBANCHI) = csDataRow(ABAtenaEntity.BANCHI);
                                // •ÒW‘O•û‘
                                strWork = Conversions.ToString(csDataRow(ABAtenaEntity.KATAGAKI)).Trim;
                                csDataNewRow(ABNenkinAtenaEntity.HENSHUMAEKATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    // •ÒW‘O•û‘iƒtƒ‹j
                                    csDataNewRow(ABNenkinAtenaHyojunEntity.HENSHUMAEKATAGAKI_FULL) = csDataRow(ABAtenaEntity.KATAGAKI);
                                }
                                else
                                {
                                }
                            }

                            // Áœ“Ío”NŒŽ“ú
                            csDataNewRow(ABNenkinAtenaEntity.SHOJOTDKDYMD) = csDataRow(ABAtenaEntity.SHOJOTDKDYMD);
                            // ’¼‹ßŽ–—RƒR[ƒh
                            csDataNewRow(ABNenkinAtenaEntity.CKINJIYUCD) = csDataRow(ABAtenaEntity.CKINJIYUCD);

                            // *—š—ð”Ô† 000022 2003/12/04 ’Ç‰ÁŠJŽn
                            // –{Ð‘S‘ZŠƒR[ƒh
                            csDataNewRow(ABNenkinAtenaEntity.HON_ZJUSHOCD) = csDataRow(ABAtenaEntity.HON_ZJUSHOCD);
                            // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                            // “]o—\’è¢‘ÑŽå–¼
                            // csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEISTAINUSMEI) = csDataRow(ABAtenaEntity.TENSHUTSUYOTEISTAINUSMEI)
                            // “]oŠm’è¢‘ÑŽå–¼
                            // csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTISTAINUSMEI) = csDataRow(ABAtenaEntity.TENSHUTSUKKTISTAINUSMEI)
                            if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                                // “]o—\’è¢‘ÑŽå–¼
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEISTAINUSMEI) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaEntity.TENSHUTSUYOTEISTAINUSMEI)));
                                // “]oŠm’è¢‘ÑŽå–¼
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTISTAINUSMEI) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaEntity.TENSHUTSUKKTISTAINUSMEI)));
                            }
                            else
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                                // “]o—\’è¢‘ÑŽå–¼
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEISTAINUSMEI) = csDataRow(ABAtenaEntity.TENSHUTSUYOTEISTAINUSMEI);
                                // “]oŠm’è¢‘ÑŽå–¼
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTISTAINUSMEI) = csDataRow(ABAtenaEntity.TENSHUTSUKKTISTAINUSMEI);
                            }
                            // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹
                            // ‘ÐƒR[ƒh
                            csDataNewRow(ABNenkinAtenaEntity.KOKUSEKICD) = csDataRow(ABAtenaEntity.KOKUSEKICD);
                            // *—š—ð”Ô† 000022 2003/12/04 ’Ç‰ÁI—¹
                            // *—š—ð”Ô† 000027 2006/07/31 ’Ç‰ÁŠJŽn
                            if ((strGyomuMei ?? "") == NENKIN_2)
                            {
                                // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                                // “]“ü‘OZŠ¢‘ÑŽå–¼
                                // csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_STAINUSMEI) = csDataRow(ABAtenaEntity.TENUMAEJ_STAINUSMEI)
                                if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                                {
                                    // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                                    csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_STAINUSMEI) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaEntity.TENUMAEJ_STAINUSMEI)));
                                }
                                else
                                {
                                    // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                                    csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_STAINUSMEI) = csDataRow(ABAtenaEntity.TENUMAEJ_STAINUSMEI);
                                }
                                // *—š—ð”Ô† 000022 2003/12/04 ’Ç‰ÁI—¹
                            }
                            // *—š—ð”Ô† 000027 2006/07/31 ’Ç‰ÁI—¹
                        }

                        // *—š—ð”Ô† 000030 2007/04/28 ’Ç‰ÁŠJŽn
                        // ‰îŒì—pƒTƒuƒ‹[ƒ`ƒ“Žæ“¾€–Ú
                        if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_Kaigo)
                        {
                            // ‹Œ©
                            csDataNewRow(ABAtena1Entity.KYUSEI) = csDataRow(ABAtenaEntity.KYUSEI);
                            // Z’èˆÙ“®”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.JUTEIIDOYMD) = csDataRow(ABAtenaEntity.JUTEIIDOYMD);
                            // Z’èŽ–—R
                            csDataNewRow(ABAtena1Entity.JUTEIJIYU) = csDataRow(ABAtenaEntity.JUTEIJIYU);
                            // –{Ð‘S‘ZŠƒR[ƒh
                            csDataNewRow(ABAtena1Entity.HON_ZJUSHOCD) = csDataRow(ABAtenaEntity.HON_ZJUSHOCD);
                            // “]“ü‘OZŠ—X•Ö”Ô†
                            csDataNewRow(ABAtena1Entity.TENUMAEJ_YUBINNO) = csDataRow(ABAtenaEntity.TENUMAEJ_YUBINNO);
                            // “]“ü‘OZŠ‘S‘ZŠƒR[ƒh
                            csDataNewRow(ABAtena1Entity.TENUMAEJ_ZJUSHOCD) = csDataRow(ABAtenaEntity.TENUMAEJ_ZJUSHOCD);
                            // “]“ü‘OZŠZŠ
                            csDataNewRow(ABAtena1Entity.TENUMAEJ_JUSHO) = csDataRow(ABAtenaEntity.TENUMAEJ_JUSHO);
                            // “]“ü‘OZŠ”Ô’n
                            csDataNewRow(ABAtena1Entity.TENUMAEJ_BANCHI) = csDataRow(ABAtenaEntity.TENUMAEJ_BANCHI);
                            // “]“ü‘OZŠ•û‘
                            strWork = Conversions.ToString(csDataRow(ABAtenaEntity.TENUMAEJ_KATAGAKI)).Trim;
                            csDataNewRow(ABAtena1Entity.TENUMAEJ_KATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                            // “]o—\’è—X•Ö”Ô†
                            csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEIYUBINNO) = csDataRow(ABAtenaEntity.TENSHUTSUYOTEIYUBINNO);
                            // “]o—\’è‘S‘ZŠƒR[ƒh
                            csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEIZJUSHOCD) = csDataRow(ABAtenaEntity.TENSHUTSUYOTEIZJUSHOCD);
                            // “]o—\’èˆÙ“®”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEIIDOYMD) = csDataRow(ABAtenaEntity.TENSHUTSUYOTEIIDOYMD);
                            // “]o—\’èZŠ
                            csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEIJUSHO) = csDataRow(ABAtenaEntity.TENSHUTSUYOTEIJUSHO);
                            // “]o—\’è”Ô’n
                            csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEIBANCHI) = csDataRow(ABAtenaEntity.TENSHUTSUYOTEIBANCHI);
                            // “]o—\’è•û‘
                            strWork = Conversions.ToString(csDataRow(ABAtenaEntity.TENSHUTSUYOTEIKATAGAKI)).Trim;
                            csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEIKATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // “]“ü‘OZŠ•û‘iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_KATAGAKI_FULL) = csDataRow(ABAtenaEntity.TENUMAEJ_KATAGAKI);
                                // “]o—\’è•û‘iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIKATAGAKI_FULL) = csDataRow(ABAtenaEntity.TENSHUTSUYOTEIKATAGAKI);
                            }
                            else
                            {
                            }
                            // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                            // “]o—\’è¢‘ÑŽå–¼
                            // csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEISTAINUSMEI) = csDataRow(ABAtenaEntity.TENSHUTSUYOTEISTAINUSMEI)
                            if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEISTAINUSMEI) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaEntity.TENSHUTSUYOTEISTAINUSMEI)));
                            }
                            else
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                                csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEISTAINUSMEI) = csDataRow(ABAtenaEntity.TENSHUTSUYOTEISTAINUSMEI);
                            }
                            // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹
                            // “]oŠm’è—X•Ö”Ô†
                            csDataNewRow(ABAtena1Entity.TENSHUTSUKKTIYUBINNO) = csDataRow(ABAtenaEntity.TENSHUTSUKKTIYUBINNO);
                            // “]oŠm’è‘S‘ZŠƒR[ƒh
                            csDataNewRow(ABAtena1Entity.TENSHUTSUKKTIZJUSHOCD) = csDataRow(ABAtenaEntity.TENSHUTSUKKTIZJUSHOCD);
                            // “]oŠm’èˆÙ“®”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.TENSHUTSUKKTIIDOYMD) = csDataRow(ABAtenaEntity.TENSHUTSUKKTIIDOYMD);
                            // “]oŠm’è’Ê’m”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.TENSHUTSUKKTITSUCHIYMD) = csDataRow(ABAtenaEntity.TENSHUTSUKKTITSUCHIYMD);
                            // “]oŠm’èZŠ
                            csDataNewRow(ABAtena1Entity.TENSHUTSUKKTIJUSHO) = csDataRow(ABAtenaEntity.TENSHUTSUKKTIJUSHO);
                            // “]oŠm’è”Ô’n
                            csDataNewRow(ABAtena1Entity.TENSHUTSUKKTIBANCHI) = csDataRow(ABAtenaEntity.TENSHUTSUKKTIBANCHI);
                            // “]oŠm’è•û‘
                            strWork = Conversions.ToString(csDataRow(ABAtenaEntity.TENSHUTSUKKTIKATAGAKI)).Trim;
                            csDataNewRow(ABAtena1Entity.TENSHUTSUKKTIKATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // “]oŠm’è•û‘iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTIKATAGAKI_FULL) = csDataRow(ABAtenaEntity.TENSHUTSUKKTIKATAGAKI);
                            }
                            else
                            {
                            }
                            // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                            // “]oŠm’è¢‘ÑŽå–¼
                            // csDataNewRow(ABAtena1Entity.TENSHUTSUKKTISTAINUSMEI) = csDataRow(ABAtenaEntity.TENSHUTSUKKTISTAINUSMEI)
                            if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTISTAINUSMEI) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaEntity.TENSHUTSUKKTISTAINUSMEI)));
                            }
                            else
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                                csDataNewRow(ABAtena1Entity.TENSHUTSUKKTISTAINUSMEI) = csDataRow(ABAtenaEntity.TENSHUTSUKKTISTAINUSMEI);
                            }
                            // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹

                            // ZŠî—Dæ‚Ìê‡
                            if (cAtenaGetPara1.p_strJukiJutogaiKB == "1")
                            {
                                // •ÒW‘O”Ô’n
                                csDataNewRow(ABAtena1Entity.HENSHUMAEBANCHI) = csDataRow(ABAtenaEntity.JUKIBANCHI);
                                // •ÒW‘O•û‘
                                strWork = Conversions.ToString(csDataRow(ABAtenaEntity.JUKIKATAGAKI)).Trim;
                                csDataNewRow(ABAtena1Entity.HENSHUMAEKATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    // •ÒW‘O•û‘iƒtƒ‹j
                                    csDataNewRow(ABAtena1HyojunEntity.HENSHUMAEKATAGAKI_FULL) = csDataRow(ABAtenaEntity.JUKIKATAGAKI);
                                }
                                else
                                {
                                }
                            }
                            else
                            {
                                // •ÒW‘O”Ô’n
                                csDataNewRow(ABAtena1Entity.HENSHUMAEBANCHI) = csDataRow(ABAtenaEntity.BANCHI);
                                // •ÒW‘O•û‘
                                strWork = Conversions.ToString(csDataRow(ABAtenaEntity.KATAGAKI)).Trim;
                                csDataNewRow(ABAtena1Entity.HENSHUMAEKATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    // •ÒW‘O•û‘iƒtƒ‹j
                                    csDataNewRow(ABAtena1HyojunEntity.HENSHUMAEKATAGAKI_FULL) = csDataRow(ABAtenaEntity.KATAGAKI);
                                }
                                else
                                {
                                }
                            }

                            // Áœ“Ío”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.SHOJOTDKDYMD) = csDataRow(ABAtenaEntity.SHOJOTDKDYMD);
                            // ’¼‹ßŽ–—RƒR[ƒh
                            csDataNewRow(ABAtena1Entity.CKINJIYUCD) = csDataRow(ABAtenaEntity.CKINJIYUCD);
                            // ‘ÐƒR[ƒh
                            csDataNewRow(ABAtena1Entity.KOKUSEKICD) = csDataRow(ABAtenaEntity.KOKUSEKICD);
                            // “o˜^“Ío”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.TOROKUTDKDYMD) = csDataRow(ABAtenaEntity.TOROKUTDKDYMD);
                            // Z’è“Ío”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.JUTEITDKDYMD) = csDataRow(ABAtenaEntity.JUTEITDKDYMD);
                            // “]o“ü——R
                            csDataNewRow(ABAtena1Entity.TENSHUTSUNYURIYU) = csDataRow(ABAtenaEntity.TENSHUTSUNYURIYU);
                            // Žs’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1Entity.SHICHOSONCD) = csDataRow(ABAtenaEntity.SHICHOSONCD);

                            if (!(csDataRow(ABAtenaEntity.CKINJIYUCD).ToString.Trim == string.Empty) && csDataRow(ABAtenaEntity.CKINIDOYMD).ToString.Trim == string.Empty)
                            {
                                csDataNewRow(ABAtena1Entity.CKINIDOYMD) = m_strCknIdobiHenkanParam;
                            }
                            else
                            {

                                // ’¼‹ßˆÙ“®”NŒŽ“ú
                                csDataNewRow(ABAtena1Entity.CKINIDOYMD) = csDataRow(ABAtenaEntity.CKINIDOYMD);
                            }
                            // XV“úŽž
                            csDataNewRow(ABAtena1Entity.KOSHINNICHIJI) = csDataRow(ABAtenaEntity.KOSHINNICHIJI);
                        }
                        // *—š—ð”Ô† 000030 2007/04/28 ’Ç‰ÁI—¹

                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                    // *—š—ð”Ô† 000019 2003/11/19 ’Ç‰ÁŠJŽn
                    // ˆ¶–¼ŒÂ•Êî•ñ—pƒf[ƒ^ì¬(–{lƒŒƒR[ƒh‚Ì‚ÝÝ’è)
                    if ((strGyomuMei ?? "") == KOBETSU & string.IsNullOrEmpty(strDainoKB.Trim()))
                    {
                        // Šî‘b”N‹à”Ô†	
                        csDataNewRow(ABAtena1KobetsuEntity.KSNENKNNO) = csDataRow(ABAtena1KobetsuEntity.KSNENKNNO);
                        // ”N‹àŽ‘ŠiŽæ“¾”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.NENKNSKAKSHUTKYMD) = csDataRow(ABAtena1KobetsuEntity.NENKNSKAKSHUTKYMD);
                        // ”N‹àŽ‘ŠiŽæ“¾Ží•Ê	
                        csDataNewRow(ABAtena1KobetsuEntity.NENKNSKAKSHUTKSHU) = csDataRow(ABAtena1KobetsuEntity.NENKNSKAKSHUTKSHU);
                        // ”N‹àŽ‘ŠiŽæ“¾——RƒR[ƒh	
                        csDataNewRow(ABAtena1KobetsuEntity.NENKNSKAKSHUTKRIYUCD) = csDataRow(ABAtena1KobetsuEntity.NENKNSKAKSHUTKRIYUCD);
                        // ”N‹àŽ‘Ši‘rŽ¸”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.NENKNSKAKSSHTSYMD) = csDataRow(ABAtena1KobetsuEntity.NENKNSKAKSSHTSYMD);
                        // ”N‹àŽ‘Ši‘rŽ¸——RƒR[ƒh	
                        csDataNewRow(ABAtena1KobetsuEntity.NENKNSKAKSSHTSRIYUCD) = csDataRow(ABAtena1KobetsuEntity.NENKNSKAKSSHTSRIYUCD);
                        // Žó‹‹”N‹à‹L†‚P	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNKIGO1) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNKIGO1);
                        // Žó‹‹”N‹à”Ô†‚P	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNNO1) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNNO1);
                        // Žó‹‹”N‹àŽí•Ê‚P	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNSHU1) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNSHU1);
                        // Žó‹‹”N‹àŽ}”Ô‚P	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNEDABAN1) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNEDABAN1);
                        // Žó‹‹”N‹à‹æ•ª‚P	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNKB1) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNKB1);
                        // Žó‹‹”N‹à‹L†‚Q	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNKIGO2) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNKIGO2);
                        // Žó‹‹”N‹à”Ô†‚Q	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNNO2) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNNO2);
                        // Žó‹‹”N‹àŽí•Ê‚Q	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNSHU2) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNSHU2);
                        // Žó‹‹”N‹àŽ}”Ô‚Q	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNEDABAN2) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNEDABAN2);
                        // Žó‹‹”N‹à‹æ•ª‚Q	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNKB2) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNKB2);
                        // Žó‹‹”N‹à‹L†‚R	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNKIGO3) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNKIGO3);
                        // Žó‹‹”N‹à”Ô†‚R	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNNO3) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNNO3);
                        // Žó‹‹”N‹àŽí•Ê‚R	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNSHU3) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNSHU3);
                        // Žó‹‹”N‹àŽ}”Ô‚R	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNEDABAN3) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNEDABAN3);
                        // Žó‹‹”N‹à‹æ•ª‚R	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNKB3) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNKB3);
                        // ‘•Û”Ô†	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHONO) = csDataRow(ABAtena1KobetsuEntity.KOKUHONO);
                        // ‘•ÛŽ‘Ši‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKB) = csDataRow(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKB);
                        // ‘•ÛŽ‘Ši‹æ•ª³Ž®–¼Ì	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKBMEISHO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKBMEISHO);
                        // ‘•ÛŽ‘Ši‹æ•ª—ªŽ®–¼Ì	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKBRYAKUSHO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKBRYAKUSHO);
                        // ‘•ÛŠw‰“‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOGAKUENKB) = csDataRow(ABAtena1KobetsuEntity.KOKUHOGAKUENKB);
                        // ‘•ÛŠw‰“‹æ•ª³Ž®–¼Ì	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOGAKUENKBMEISHO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOGAKUENKBMEISHO);
                        // ‘•ÛŠw‰“‹æ•ª—ªŽ®–¼Ì	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOGAKUENKBRYAKUSHO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOGAKUENKBRYAKUSHO);
                        // ‘•ÛŽæ“¾”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOSHUTOKUYMD) = csDataRow(ABAtena1KobetsuEntity.KOKUHOSHUTOKUYMD);
                        // ‘•Û‘rŽ¸”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOSOSHITSUYMD) = csDataRow(ABAtena1KobetsuEntity.KOKUHOSOSHITSUYMD);
                        // ‘•Û‘ÞE‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOTISHKKB) = csDataRow(ABAtena1KobetsuEntity.KOKUHOTISHKKB);
                        // ‘•Û‘ÞE‹æ•ª³Ž®–¼Ì	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOTISHKKBMEISHO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOTISHKKBMEISHO);
                        // ‘•Û‘ÞE‹æ•ª—ªŽ®–¼Ì	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOTISHKKBRYAKUSHO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOTISHKKBRYAKUSHO);
                        // ‘•Û‘ÞE–{”í‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKB) = csDataRow(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKB);
                        // ‘•Û‘ÞE–{”í‹æ•ª³Ž®–¼Ì	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKBMEISHO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKBMEISHO);
                        // ‘•Û‘ÞE–{”í‹æ•ª—ªŽ®–¼Ì	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKBRYAKUSHO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKBRYAKUSHO);
                        // ‘•Û‘ÞEŠY“–”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOTISHKGAITOYMD) = csDataRow(ABAtena1KobetsuEntity.KOKUHOTISHKGAITOYMD);
                        // ‘•Û‘ÞE”ñŠY“–”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOTISHKHIGAITOYMD) = csDataRow(ABAtena1KobetsuEntity.KOKUHOTISHKHIGAITOYMD);
                        // ‘•Û•ÛŒ¯Ø‹L†	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOHOKENSHOKIGO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOHOKENSHOKIGO);
                        // ‘•Û•ÛŒ¯Ø”Ô†	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOHOKENSHONO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOHOKENSHONO);
                        // ˆóŠÓ”Ô†	
                        csDataNewRow(ABAtena1KobetsuEntity.INKANNO) = csDataRow(ABAtena1KobetsuEntity.INKANNO);
                        // ˆóŠÓ“o˜^‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.INKANTOROKUKB) = csDataRow(ABAtena1KobetsuEntity.INKANTOROKUKB);
                        // ‘I‹“Ž‘Ši‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.SENKYOSHIKAKUKB) = csDataRow(ABAtena1KobetsuEntity.SENKYOSHIKAKUKB);
                        // Ž™Žè”í—p‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.JIDOTEATEHIYOKB) = csDataRow(ABAtena1KobetsuEntity.JIDOTEATEHIYOKB);
                        // Ž™ŽèŠJŽn”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.JIDOTEATESTYM) = csDataRow(ABAtena1KobetsuEntity.JIDOTEATESTYM);
                        // Ž™ŽèI—¹”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.JIDOTEATEEDYM) = csDataRow(ABAtena1KobetsuEntity.JIDOTEATEEDYM);
                        // ‰îŒì”í•ÛŒ¯ŽÒ”Ô†	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGHIHKNSHANO) = csDataRow(ABAtena1KobetsuEntity.KAIGHIHKNSHANO);
                        // ‰îŒìŽ‘ŠiŽæ“¾“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGSKAKSHUTKYMD) = csDataRow(ABAtena1KobetsuEntity.KAIGSKAKSHUTKYMD);
                        // ‰îŒìŽ‘Ši‘rŽ¸“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGSKAKSSHTSYMD) = csDataRow(ABAtena1KobetsuEntity.KAIGSKAKSSHTSYMD);
                        // ‰îŒìŽ‘Ši”í•ÛŒ¯ŽÒ‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGSKAKHIHOKENSHAKB) = csDataRow(ABAtena1KobetsuEntity.KAIGSKAKHIHOKENSHAKB);
                        // ‰îŒìZŠ’n“Á—áŽÒ‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGJUSHOCHITKRIKB) = csDataRow(ABAtena1KobetsuEntity.KAIGJUSHOCHITKRIKB);
                        // ‰îŒìŽó‹‹ŽÒ‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGJUKYUSHAKB) = csDataRow(ABAtena1KobetsuEntity.KAIGJUKYUSHAKB);
                        // —v‰îŒìó‘Ô‹æ•ªƒR[ƒh	
                        csDataNewRow(ABAtena1KobetsuEntity.YOKAIGJOTAIKBCD) = csDataRow(ABAtena1KobetsuEntity.YOKAIGJOTAIKBCD);
                        // —v‰îŒìó‘Ô‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGSKAKKB) = csDataRow(ABAtena1KobetsuEntity.KAIGSKAKKB);
                        // ‰îŒì”F’è—LŒøŠJŽn“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGNINTEIKAISHIYMD) = csDataRow(ABAtena1KobetsuEntity.KAIGNINTEIKAISHIYMD);
                        // ‰îŒì”F’è—LŒøI—¹“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGNINTEISHURYOYMD) = csDataRow(ABAtena1KobetsuEntity.KAIGNINTEISHURYOYMD);
                        // ‰îŒìŽó‹‹”F’è”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGJUKYUNINTEIYMD) = csDataRow(ABAtena1KobetsuEntity.KAIGJUKYUNINTEIYMD);
                        // ‰îŒìŽó‹‹”F’èŽæÁ”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGJUKYUNINTEITORIKESHIYMD) = csDataRow(ABAtena1KobetsuEntity.KAIGJUKYUNINTEITORIKESHIYMD);

                        // *—š—ð”Ô† 000034 2008/01/15 ’Ç‰ÁŠJŽn
                        if (m_strKobetsuShutokuKB == "1")
                        {
                            // ŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ª"1"‚Ìê‡‚ÍŒãŠú‚—î€–Ú‚ð’Ç‰Á‚·‚é
                            // Ž‘Ši‹æ•ª
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREISHIKAKUKB) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREISHIKAKUKB);
                            // ”í•ÛŒ¯ŽÒ”Ô†
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREIHIHKNSHANO) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREIHIHKNSHANO);
                            // ”í•ÛŒ¯ŽÒŽ‘ŠiŽæ“¾Ž–—RƒR[ƒh
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKJIYUCD) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKJIYUCD);
                            // ”í•ÛŒ¯ŽÒŽ‘ŠiŽæ“¾Ž–—R–¼Ì
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKJIYUMEI) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKJIYUMEI);
                            // ”í•ÛŒ¯ŽÒŽ‘ŠiŽæ“¾”NŒŽ“ú
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKYMD) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKYMD);
                            // ”í•ÛŒ¯ŽÒŽ‘Ši‘rŽ¸Ž–—RƒR[ƒh
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSJIYUCD) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSJIYUCD);
                            // ”í•ÛŒ¯ŽÒŽ‘Ši‘rŽ¸Ž–—R–¼Ì
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSJIYUMEI) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSJIYUMEI);
                            // ”í•ÛŒ¯ŽÒŽ‘Ši‘rŽ¸”NŒŽ“ú
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSYMD) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSYMD);
                            // •ÛŒ¯ŽÒ”Ô†“K—pŠJŽn”NŒŽ“ú
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREITEKIYOKAISHIYMD) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREITEKIYOKAISHIYMD);
                            // •ÛŒ¯ŽÒ”Ô†“K—pI—¹”NŒŽ“ú
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREITEKIYOSHURYOYMD) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREITEKIYOSHURYOYMD);
                        }
                        else
                        {
                            // ŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ª’l‚È‚µ‚Ìê‡‚ÍŒãŠú‚—î€–Ú‚ð’Ç‰Á‚µ‚È‚¢
                        }
                        // *—š—ð”Ô† 000034 2008/01/15 ’Ç‰ÁI—¹

                    }
                    // *—š—ð”Ô† 000019 2003/11/19 ’Ç‰ÁI—¹

                    // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁŠJŽn
                    // ZŠî–@‰ü³”»’è
                    if (m_strJukiHokaiseiKB_Param == "1")
                    {
                        // Z–¯•[ó‘Ô‹æ•ª
                        csDataNewRow(ABAtenaFZYEntity.JUMINHYOJOTAIKBN) = csDataRow(ABAtenaFZYEntity.JUMINHYOJOTAIKBN);
                        // Z‹’n“Ío—L–³ƒtƒ‰ƒO
                        csDataNewRow(ABAtenaFZYEntity.JUKYOCHITODOKEFLG) = csDataRow(ABAtenaFZYEntity.JUKYOCHITODOKEFLG);
                        // –{‘–¼
                        csDataNewRow(ABAtenaFZYEntity.HONGOKUMEI) = csDataRow(ABAtenaFZYEntity.HONGOKUMEI);
                        // ƒJƒi–{‘–¼
                        csDataNewRow(ABAtenaFZYEntity.KANAHONGOKUMEI) = csDataRow(ABAtenaFZYEntity.KANAHONGOKUMEI);
                        // •¹‹L–¼
                        csDataNewRow(ABAtenaFZYEntity.KANJIHEIKIMEI) = csDataRow(ABAtenaFZYEntity.KANJIHEIKIMEI);
                        // ƒJƒi•¹‹L–¼
                        csDataNewRow(ABAtenaFZYEntity.KANAHEIKIMEI) = csDataRow(ABAtenaFZYEntity.KANAHEIKIMEI);
                        // ’ÊÌ–¼
                        csDataNewRow(ABAtenaFZYEntity.KANJITSUSHOMEI) = csDataRow(ABAtenaFZYEntity.KANJITSUSHOMEI);
                        // ƒJƒi’ÊÌ–¼
                        csDataNewRow(ABAtenaFZYEntity.KANATSUSHOMEI) = csDataRow(ABAtenaFZYEntity.KANATSUSHOMEI);
                        // ƒJƒ^ƒJƒi•¹‹L–¼
                        csDataNewRow(ABAtenaFZYEntity.KATAKANAHEIKIMEI) = csDataRow(ABAtenaFZYEntity.KATAKANAHEIKIMEI);
                        // ¶”NŒŽ“ú•sÚ‹æ•ª
                        csDataNewRow(ABAtenaFZYEntity.UMAREFUSHOKBN) = csDataRow(ABAtenaFZYEntity.UMAREFUSHOKBN);
                        // ’ÊÌ–¼“o˜^i•ÏXj”NŒŽ“ú
                        csDataNewRow(ABAtenaFZYEntity.TSUSHOMEITOUROKUYMD) = csDataRow(ABAtenaFZYEntity.TSUSHOMEITOUROKUYMD);
                        // Ý—¯ŠúŠÔƒR[ƒh
                        csDataNewRow(ABAtenaFZYEntity.ZAIRYUKIKANCD) = csDataRow(ABAtenaFZYEntity.ZAIRYUKIKANCD);
                        // Ý—¯ŠúŠÔ–¼Ì
                        csDataNewRow(ABAtenaFZYEntity.ZAIRYUKIKANMEISHO) = csDataRow(ABAtenaFZYEntity.ZAIRYUKIKANMEISHO);
                        // ’†’·ŠúÝ—¯ŽÒ‚Å‚ ‚éŽ|“™‚ÌƒR[ƒh
                        csDataNewRow(ABAtenaFZYEntity.ZAIRYUSHACD) = csDataRow(ABAtenaFZYEntity.ZAIRYUSHACD);
                        // ’†’·ŠúÝ—¯ŽÒ‚Å‚ ‚éŽ|“™
                        csDataNewRow(ABAtenaFZYEntity.ZAIRYUSHAMEISHO) = csDataRow(ABAtenaFZYEntity.ZAIRYUSHAMEISHO);
                        // Ý—¯ƒJ[ƒh“™”Ô†
                        csDataNewRow(ABAtenaFZYEntity.ZAIRYUCARDNO) = csDataRow(ABAtenaFZYEntity.ZAIRYUCARDNO);
                        // “Á•Ê‰iZŽÒØ–¾‘Œð•t”NŒŽ“ú
                        csDataNewRow(ABAtenaFZYEntity.KOFUYMD) = csDataRow(ABAtenaFZYEntity.KOFUYMD);
                        // “Á•Ê‰iZŽÒØ–¾‘Œð•t—\’èŠúŠÔŠJŽn“ú
                        csDataNewRow(ABAtenaFZYEntity.KOFUYOTEISTYMD) = csDataRow(ABAtenaFZYEntity.KOFUYOTEISTYMD);
                        // “Á’è‰iZŽÒØ–¾‘Œð•t—\’èŠúŠÔI—¹“ú
                        csDataNewRow(ABAtenaFZYEntity.KOFUYOTEIEDYMD) = csDataRow(ABAtenaFZYEntity.KOFUYOTEIEDYMD);
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœˆÙ“®”NŒŽ“ú
                        csDataNewRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOIDOYMD) = csDataRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOIDOYMD);
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœŽ–—RƒR[ƒh
                        csDataNewRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYUCD) = csDataRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYUCD);
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœŽ–—R
                        csDataNewRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYU) = csDataRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYU);
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœ“Ío”NŒŽ“ú
                        csDataNewRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDYMD) = csDataRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDYMD);
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœ“Ío’Ê’m‹æ•ª
                        csDataNewRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDTUCIKB) = csDataRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDTUCIKB);
                        // ŠO‘l¢‘ÑŽå–¼
                        csDataNewRow(ABAtenaFZYEntity.FRNSTAINUSMEI) = csDataRow(ABAtenaFZYEntity.FRNSTAINUSMEI);
                        // ŠO‘l¢‘ÑŽåƒJƒi–¼
                        csDataNewRow(ABAtenaFZYEntity.FRNSTAINUSKANAMEI) = csDataRow(ABAtenaFZYEntity.FRNSTAINUSKANAMEI);
                        // ¢‘ÑŽå•¹‹L–¼
                        csDataNewRow(ABAtenaFZYEntity.STAINUSHEIKIMEI) = csDataRow(ABAtenaFZYEntity.STAINUSHEIKIMEI);
                        // ¢‘ÑŽåƒJƒi•¹‹L–¼
                        csDataNewRow(ABAtenaFZYEntity.STAINUSKANAHEIKIMEI) = csDataRow(ABAtenaFZYEntity.STAINUSKANAHEIKIMEI);
                        // ¢‘ÑŽå’ÊÌ–¼
                        csDataNewRow(ABAtenaFZYEntity.STAINUSTSUSHOMEI) = csDataRow(ABAtenaFZYEntity.STAINUSTSUSHOMEI);
                        // ¢‘ÑŽåƒJƒi’ÊÌ–¼
                        csDataNewRow(ABAtenaFZYEntity.STAINUSKANATSUSHOMEI) = csDataRow(ABAtenaFZYEntity.STAINUSKANATSUSHOMEI);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }
                    // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁI—¹

                    // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁŠJŽn
                    // ‹¤’Ê”Ô†”»’è
                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                    {
                        // ‹ó”’œ‹Ž‚µ‚½’l‚ðÝ’è‚·‚éB
                        csDataNewRow(ABMyNumberEntity.MYNUMBER) = csDataRow(ABMyNumberEntity.MYNUMBER).ToString.Trim;
                    }
                    else
                    {
                        // noop
                    }
                    // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁI—¹

                    if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                    {
                        // ¢‘ÑŽåŽ–¼—Dæ‹æ•ª
                        csDataNewRow(ABAtena1HyojunEntity.STAINUSSHIMEIYUSENKB) = csDataRow(ABAtenaFZYHyojunEntity.STAINUSSHIMEIYUSENKB);
                        // Ž–¼—Dæ€–Ú
                        csDataNewRow(ABAtena1HyojunEntity.SHIMEIYUSENKB) = csDataRow(ABAtenaFZYHyojunEntity.SHIMEIYUSENKB);
                        // ‹ŒŽ
                        csDataNewRow(ABAtena1HyojunEntity.KANJIKYUUJI) = csDataRow(ABAtenaFZYEntity.RESERVE7);
                        // ƒJƒi‹ŒŽ
                        csDataNewRow(ABAtena1HyojunEntity.KANAKYUUJI) = csDataRow(ABAtenaFZYEntity.RESERVE8);
                        // Ž–¼ƒtƒŠƒKƒiŠm”Fƒtƒ‰ƒO
                        csDataNewRow(ABAtena1HyojunEntity.SHIMEIKANAKAKUNINFG) = csDataRow(ABAtenaHyojunEntity.SHIMEIKANAKAKUNINFG);
                        // ‹ŒŽƒtƒŠƒKƒiŠm”Fƒtƒ‰ƒO
                        csDataNewRow(ABAtena1HyojunEntity.KYUUJIKANAKAKUNINFG) = csDataRow(ABAtenaHyojunEntity.KYUUJIKANAKAKUNINFG);
                        // ’ÊÌƒtƒŠƒKƒiŠm”Fƒtƒ‰ƒO
                        csDataNewRow(ABAtena1HyojunEntity.TSUSHOKANAKAKUNINFG) = csDataRow(ABAtenaFZYHyojunEntity.TSUSHOKANAKAKUNINFG);
                        // ¶”NŒŽ“ú•sÚƒpƒ^[ƒ“
                        csDataNewRow(ABAtena1HyojunEntity.UMAREBIFUSHOPTN) = csDataRow(ABAtenaHyojunEntity.UMAREBIFUSHOPTN);
                        // •sÚ¶”NŒŽ“ú
                        csDataNewRow(ABAtena1HyojunEntity.FUSHOUMAREBI) = csDataRow(ABAtenaHyojunEntity.FUSHOUMAREBI);
                        // ‹LÚŽ–—R
                        csDataNewRow(ABAtena1HyojunEntity.HYOJUNKISAIJIYUCD) = csDataRow(ABAtenaHyojunEntity.HYOJUNKISAIJIYUCD);
                        // ‹LÚ”NŒŽ“ú
                        csDataNewRow(ABAtena1HyojunEntity.KISAIYMD) = csDataRow(ABAtenaHyojunEntity.KISAIYMD);
                        // ÁœŽ–—R
                        csDataNewRow(ABAtena1HyojunEntity.HYOJUNSHOJOJIYUCD) = csDataRow(ABAtenaHyojunEntity.HYOJUNSHOJOJIYUCD);

                        if ((csDataRow(ABAtenaEntity.ATENADATAKB).ToString == ABConstClass.ATENADATAKB_JUTONAI_KOJIN || csDataRow(ABAtenaEntity.ATENADATAKB).ToString == ABConstClass.ATENADATAKB_JUTOGAI_KOJIN) && !(csDataRow(ABAtenaEntity.SHOJOJIYUCD).ToString.Trim == string.Empty))
                        {
                            if (csDataRow(ABAtenaHyojunEntity.SHOJOIDOWMD).ToString.Trim == string.Empty)
                            {
                                csDataNewRow(ABAtena1HyojunEntity.SHOJOIDOWMD) = m_strShojoIdoWmdHenkan;
                            }
                            else
                            {
                                csDataNewRow(ABAtena1HyojunEntity.SHOJOIDOWMD) = csDataRow(ABAtenaHyojunEntity.SHOJOIDOWMD);
                            }
                        }
                        else
                        {
                            // ÁœˆÙ“®˜a—ï”NŒŽ“ú
                            csDataNewRow(ABAtena1HyojunEntity.SHOJOIDOWMD) = csDataRow(ABAtenaHyojunEntity.SHOJOIDOWMD);
                        }
                        // ÁœˆÙ“®“ú•sÚƒpƒ^[ƒ“
                        csDataNewRow(ABAtena1HyojunEntity.SHOJOIDOBIFUSHOPTN) = csDataRow(ABAtenaHyojunEntity.SHOJOIDOBIFUSHOPTN);
                        // •sÚÁœˆÙ“®“ú
                        csDataNewRow(ABAtena1HyojunEntity.FUSHOSHOJOIDOBI) = csDataRow(ABAtenaHyojunEntity.FUSHOSHOJOIDOBI);

                        if (!(csDataRow(ABAtenaHyojunEntity.FUSHOCKINIDOBI).ToString.Trim == string.Empty) && csDataRow(ABAtenaHyojunEntity.CKINIDOWMD).ToString.Trim == string.Empty)
                        {
                            csDataNewRow(ABAtena1HyojunEntity.CKINIDOWMD) = m_strCknIdoWmdHenkan;
                        }
                        else
                        {
                            // ’¼‹ßˆÙ“®˜a—ï”NŒŽ“ú
                            csDataNewRow(ABAtena1HyojunEntity.CKINIDOWMD) = csDataRow(ABAtenaHyojunEntity.CKINIDOWMD);
                        }
                        // ’¼‹ßˆÙ“®“ú•sÚƒpƒ^[ƒ“
                        csDataNewRow(ABAtena1HyojunEntity.CKINIDOBIFUSHOPTN) = csDataRow(ABAtenaHyojunEntity.CKINIDOBIFUSHOPTN);
                        // •sÚ’¼‹ßˆÙ“®“ú
                        csDataNewRow(ABAtena1HyojunEntity.FUSHOCKINIDOBI) = csDataRow(ABAtenaHyojunEntity.FUSHOCKINIDOBI);
                        // Ž–ŽÀã‚Ì¢‘ÑŽå
                        csDataNewRow(ABAtena1HyojunEntity.JIJITSUSTAINUSMEI) = csDataRow(ABAtenaHyojunEntity.JIJITSUSTAINUSMEI);
                        if (cAtenaGetPara1.p_strJukiJutogaiKB == "1")
                        {
                            // ZŠ_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.SHIKUCHOSONCD) = csDataRow(ABAtenaHyojunEntity.JUKISHIKUCHOSONCD);
                            // ZŠ_’¬ŽšƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.MACHIAZACD) = csDataRow(ABAtenaHyojunEntity.JUKIMACHIAZACD);
                            // ZŠ_“s“¹•{Œ§
                            csDataNewRow(ABAtena1HyojunEntity.TODOFUKEN) = csDataRow(ABAtenaHyojunEntity.JUKITODOFUKEN);
                            // ZŠ_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABAtena1HyojunEntity.SHIKUCHOSON) = csDataRow(ABAtenaHyojunEntity.JUKISHIKUCHOSON);
                            // ZŠ_’¬Žš
                            csDataNewRow(ABAtena1HyojunEntity.MACHIAZA) = csDataRow(ABAtenaHyojunEntity.JUKIMACHIAZA);
                        }
                        else
                        {
                            // ZŠ_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.SHIKUCHOSONCD) = csDataRow(ABAtenaHyojunEntity.SHIKUCHOSONCD);
                            // ZŠ_’¬ŽšƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.MACHIAZACD) = csDataRow(ABAtenaHyojunEntity.MACHIAZACD);
                            // ZŠ_“s“¹•{Œ§
                            csDataNewRow(ABAtena1HyojunEntity.TODOFUKEN) = csDataRow(ABAtenaHyojunEntity.TODOFUKEN);
                            // ZŠ_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABAtena1HyojunEntity.SHIKUCHOSON) = csDataRow(ABAtenaHyojunEntity.SHIKUCHOSON);
                            // ZŠ_’¬Žš
                            csDataNewRow(ABAtena1HyojunEntity.MACHIAZA) = csDataRow(ABAtenaHyojunEntity.MACHIAZA);
                        }
                        if (m_strHonsekiHittoshKB_Param == "1" && m_strHonsekiHittoshKB == "1")
                        {
                            // –{Ð_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.HON_SHIKUCHOSONCD) = csDataRow(ABAtenaHyojunEntity.HON_SHIKUCHOSONCD);
                            // –{Ð_’¬ŽšƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.HON_MACHIAZACD) = csDataRow(ABAtenaHyojunEntity.HON_MACHIAZACD);
                            // –{Ð_“s“¹•{Œ§
                            csDataNewRow(ABAtena1HyojunEntity.HON_TODOFUKEN) = csDataRow(ABAtenaHyojunEntity.HON_TODOFUKEN);
                            // –{Ð_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABAtena1HyojunEntity.HON_SHIKUGUNCHOSON) = csDataRow(ABAtenaHyojunEntity.HON_SHIKUGUNCHOSON);
                            // –{Ð_’¬Žš
                            csDataNewRow(ABAtena1HyojunEntity.HON_MACHIAZA) = csDataRow(ABAtenaHyojunEntity.HON_MACHIAZA);
                        }
                        if (m_blnMethodKB != ABEnumDefine.MethodKB.KB_Kaigo && (strGyomuMei ?? "") != NENKIN && (strGyomuMei ?? "") != NENKIN_2)
                        {
                            // ‘ÐƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.KOKUSEKICD) = csDataRow(ABAtenaEntity.KOKUSEKICD);
                        }
                        if ((strGyomuMei ?? "") == NENKIN | (strGyomuMei ?? "") == NENKIN_2)
                        {
                            // “]“ü‘OZŠ_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_SHIKUCHOSONCD) = csDataRow(ABAtenaHyojunEntity.TENUMAEJ_SHIKUCHOSONCD);
                            // “]“ü‘O’¬ŽšƒR[ƒh
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_MACHIAZACD) = csDataRow(ABAtenaHyojunEntity.TENUMAEJ_MACHIAZACD);
                            // “]“ü‘OZŠ_“s“¹•{Œ§
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_TODOFUKEN) = csDataRow(ABAtenaHyojunEntity.TENUMAEJ_TODOFUKEN);
                            // “]“ü‘OZŠ_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_SHIKUCHOSON) = csDataRow(ABAtenaHyojunEntity.TENUMAEJ_SHIKUCHOSON);
                            // “]“ü‘OZŠ_’¬Žš
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_MACHIAZA) = csDataRow(ABAtenaHyojunEntity.TENUMAEJ_MACHIAZA);
                            // “]“ü‘OZŠ_‘–¼ƒR[ƒh
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_KOKUSEKICD) = csDataRow(ABAtenaHyojunEntity.TENUMAEJ_KOKUSEKICD);
                            // “]“ü‘OZŠ_‘–¼
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_KOKUSEKI) = csDataRow(ABAtenaHyojunEntity.TENUMAEJ_KOKUSEKI);
                            // “]“ü‘OZŠ_‘ŠOZŠ
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_KOKUGAIJUSHO) = csDataRow(ABAtenaHyojunEntity.TENUMAEJ_KOKUGAIJUSHO);
                            // “]oŠm’è_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTISHIKUCHOSONCD) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUKKTISHIKUCHOSONCD);
                            // “]oŠm’è’¬ŽšƒR[ƒh
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTIMACHIAZACD) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUKKTIMACHIAZACD);
                            // “]oŠm’è_“s“¹•{Œ§
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTITODOFUKEN) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUKKTITODOFUKEN);
                            // “]oŠm’è_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTISHIKUCHOSON) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUKKTISHIKUCHOSON);
                            // “]oŠm’è_’¬Žš
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTIMACHIAZA) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUKKTIMACHIAZA);
                            // “]o—\’è_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEISHIKUCHOSONCD) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUYOTEISHIKUCHOSONCD);
                            // “]o—\’è’¬ŽšƒR[ƒh
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIMACHIAZACD) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUYOTEIMACHIAZACD);
                            // “]o—\’è_“s“¹•{Œ§
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEITODOFUKEN) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUYOTEITODOFUKEN);
                            // “]o—\’è_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEISHIKUCHOSON) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUYOTEISHIKUCHOSON);
                            // “]o—\’è_’¬Žš
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIMACHIAZA) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUYOTEIMACHIAZA);
                            // “]o—\’è_‘–¼ƒR[ƒh
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIKOKUSEKICD) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUYOTEIKOKUSEKICD);
                            // “]o—\’è_‘–¼“™
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIKOKUSEKI) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUYOTEIKOKUSEKI);
                            // “]o—\’è_‘ŠOZŠ
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIKOKUGAIJUSHO) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUYOTEIKOKUGAIJUSHO);
                        }
                        if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_Kaigo)
                        {
                            // “]“ü‘OZŠ_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_SHIKUCHOSONCD) = csDataRow(ABAtenaHyojunEntity.TENUMAEJ_SHIKUCHOSONCD);
                            // “]“ü‘O’¬ŽšƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_MACHIAZACD) = csDataRow(ABAtenaHyojunEntity.TENUMAEJ_MACHIAZACD);
                            // “]“ü‘OZŠ_“s“¹•{Œ§
                            csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_TODOFUKEN) = csDataRow(ABAtenaHyojunEntity.TENUMAEJ_TODOFUKEN);
                            // “]“ü‘OZŠ_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_SHIKUCHOSON) = csDataRow(ABAtenaHyojunEntity.TENUMAEJ_SHIKUCHOSON);
                            // “]“ü‘OZŠ_’¬Žš
                            csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_MACHIAZA) = csDataRow(ABAtenaHyojunEntity.TENUMAEJ_MACHIAZA);
                            // “]“ü‘OZŠ_‘–¼ƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_KOKUSEKICD) = csDataRow(ABAtenaHyojunEntity.TENUMAEJ_KOKUSEKICD);
                            // “]“ü‘OZŠ_‘–¼
                            csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_KOKUSEKI) = csDataRow(ABAtenaHyojunEntity.TENUMAEJ_KOKUSEKI);
                            // “]“ü‘OZŠ_‘ŠOZŠ
                            csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_KOKUGAIJUSHO) = csDataRow(ABAtenaHyojunEntity.TENUMAEJ_KOKUGAIJUSHO);
                            // “]oŠm’è_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTISHIKUCHOSONCD) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUKKTISHIKUCHOSONCD);
                            // “]oŠm’è’¬ŽšƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTIMACHIAZACD) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUKKTIMACHIAZACD);
                            // “]oŠm’è_“s“¹•{Œ§
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTITODOFUKEN) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUKKTITODOFUKEN);
                            // “]oŠm’è_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTISHIKUCHOSON) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUKKTISHIKUCHOSON);
                            // “]oŠm’è_’¬Žš
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTIMACHIAZA) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUKKTIMACHIAZA);
                            // “]o—\’è_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEISHIKUCHOSONCD) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUYOTEISHIKUCHOSONCD);
                            // “]o—\’è’¬ŽšƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIMACHIAZACD) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUYOTEIMACHIAZACD);
                            // “]o—\’è_“s“¹•{Œ§
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEITODOFUKEN) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUYOTEITODOFUKEN);
                            // “]o—\’è_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEISHIKUCHOSON) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUYOTEISHIKUCHOSON);
                            // “]o—\’è_’¬Žš
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIMACHIAZA) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUYOTEIMACHIAZA);
                            // “]o—\’è_‘–¼ƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIKOKUSEKICD) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUYOTEIKOKUSEKICD);
                            // “]o—\’è_‘–¼“™
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIKOKUSEKI) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUYOTEIKOKUSEKI);
                            // “]o—\’è_‘ŠOZŠ
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIKOKUGAIJUSHO) = csDataRow(ABAtenaHyojunEntity.TENSHUTSUYOTEIKOKUGAIJUSHO);
                        }
                        else
                        {
                        }
                        // –@‘æ30ð46–”‚Í47‹æ•ª
                        csDataNewRow(ABAtena1HyojunEntity.HODAI30JO46MATAHA47KB) = csDataRow(ABAtenaFZYHyojunEntity.HODAI30JO46MATAHA47KB);
                        // Ý—¯ƒJ[ƒh“™”Ô†‹æ•ª
                        csDataNewRow(ABAtena1HyojunEntity.ZAIRYUCARDNOKBN) = csDataRow(ABAtenaFZYHyojunEntity.ZAIRYUCARDNOKBN);
                        // Z‹’n•â³ƒR[ƒh
                        csDataNewRow(ABAtena1HyojunEntity.JUKYOCHIHOSEICD) = csDataRow(ABAtenaFZYHyojunEntity.JUKYOCHIHOSEICD);
                        // ’¼‹ß“Ío’Ê’m‹æ•ª
                        csDataNewRow(ABAtena1HyojunEntity.CKINTDKDTUCIKB) = csDataRow(ABAtenaEntity.CKINTDKDTUCIKB);
                        // ”Å”Ô†
                        csDataNewRow(ABAtena1HyojunEntity.HANNO) = csDataRow(ABAtenaEntity.HANNO);
                        // ‰ü»”NŒŽ“ú
                        csDataNewRow(ABAtena1HyojunEntity.KAISEIYMD) = csDataRow(ABAtenaEntity.KAISEIYMD);
                        // ˆÙ“®‹æ•ª
                        csDataNewRow(ABAtena1HyojunEntity.HYOJUNIDOKB) = csDataRow(ABAtenaHyojunEntity.HYOJUNIDOKB);
                        // “ü—ÍêŠƒR[ƒh
                        csDataNewRow(ABAtena1HyojunEntity.NYURYOKUBASHOCD) = csDataRow(ABAtenaHyojunEntity.NYURYOKUBASHOCD);
                        // “ü—ÍêŠ•\‹L
                        csDataNewRow(ABAtena1HyojunEntity.NYURYOKUBASHO) = csDataRow(ABAtenaHyojunEntity.NYURYOKUBASHO);
                        if ((strGyomuMei ?? "") == KOBETSU & string.IsNullOrEmpty(strDainoKB.Trim()))
                        {
                            // ‰îŒì_”í•ÛŒ¯ŽÒŠY“–—L–³
                            csDataNewRow(ABAtena1KobetsuHyojunEntity.KAIGOHIHOKENSHAGAITOKB) = csDataRow(ABAtena1KobetsuHyojunEntity.KAIGOHIHOKENSHAGAITOKB);
                            // ‘•Û_”í•ÛŒ¯ŽÒŠY“–—L–³
                            csDataNewRow(ABAtena1KobetsuHyojunEntity.KOKUHOHIHOKENSHAGAITOKB) = csDataRow(ABAtena1KobetsuHyojunEntity.KOKUHOHIHOKENSHAGAITOKB);
                            // ”N‹à_”í•ÛŒ¯ŽÒŠY“–—L–³
                            csDataNewRow(ABAtena1KobetsuHyojunEntity.NENKINHIHOKENSHAGAITOKB) = csDataRow(ABAtena1KobetsuHyojunEntity.NENKINHIHOKENSHAGAITOKB);
                            // ”N‹à_Ží•Ê•ÏX”NŒŽ“ú
                            csDataNewRow(ABAtena1KobetsuHyojunEntity.NENKINSHUBETSUHENKOYMD) = csDataRow(ABAtena1KobetsuHyojunEntity.NENKINSHUBETSUHENKOYMD);
                            // ‘I‹“_ó‘Ô‹æ•ª
                            csDataNewRow(ABAtena1KobetsuHyojunEntity.SENKYOTOROKUJOTAIKBN) = csDataRow(ABAtena1KobetsuHyojunEntity.SENKYOTOROKUJOTAIKBN);
                            if (m_strKobetsuShutokuKB == "1")
                            {
                                // ŒãŠú‚—î_”í•ÛŒ¯ŽÒŠY“–—L–³
                                csDataNewRow(ABAtena1KobetsuHyojunEntity.KOKIKOREIHIHOKENSHAGAITOKB) = csDataRow(ABAtena1KobetsuHyojunEntity.KOKIKOREIHIHOKENSHAGAITOKB);
                            }
                        }
                        // ˜A—æ‹æ•ªi˜A—æj
                        csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKIKB) = string.Empty;
                        // ˜A—æ–¼
                        csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKIMEI) = string.Empty;
                        // ˜A—æ1i˜A—æj
                        csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKI1_RENRAKUSAKI) = string.Empty;
                        // ˜A—æ2i˜A—æj
                        csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKI2_RENRAKUSAKI) = string.Empty;
                        // ˜A—æ3i˜A—æj
                        csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKI3_RENRAKUSAKI) = string.Empty;
                        // ˜A—æŽí•Ê1
                        csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU1) = string.Empty;
                        // ˜A—æŽí•Ê2
                        csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU2) = string.Empty;
                        // ˜A—æŽí•Ê3
                        csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU3) = string.Empty;
                        // * —š—ð”Ô† 000051 2023/10/19 C³ŠJŽn
                        // If (strGyomuMei <> NENKIN AndAlso strGyomuMei <> NENKIN_2) Then
                        if ((strGyomuMei ?? "") != NENKIN && (strGyomuMei ?? "") != NENKIN_2 && csDataRow.Table.Columns.Contains(ABFugenjuJohoEntity.FUGENJUKB))
                        {
                            // * —š—ð”Ô† 000051 2023/10/19 C³I—¹
                            // •sŒ»Z‹æ•ª
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUKB) = csDataRow(ABFugenjuJohoEntity.FUGENJUKB);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_—X•Ö”Ô†
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_YUBINNO) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_YUBINNO);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_SHICHOSONCD) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_SHICHOSONCD);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_’¬ŽšƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_MACHIAZACD) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_MACHIAZACD);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_“s“¹•{Œ§
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_TODOFUKEN) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_TODOFUKEN);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_SHIKUGUNCHOSON) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_SHIKUGUNCHOSON);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_’¬Žš
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_MACHIAZA) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_MACHIAZA);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_”Ô’n†•\‹L
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_BANCHI) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_BANCHI);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_•û‘
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_KATAGAKI) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_KATAGAKI);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_•û‘_ƒtƒŠƒKƒi
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_KANAKATAGAKI) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_KANAKATAGAKI);
                            // •sŒ»Zî•ñi‘ÎÛŽÒ‹æ•ªj
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUJOHO_TAISHOSHAKUBUN) = csDataRow(ABFugenjuJohoEntity.FUGENJUJOHO_TAISHOSHAKUBUN);
                            // •sŒ»Zî•ñi‘ÎÛŽÒŽ–¼j
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUJOHO_TAISHOSHASHIMEI) = csDataRow(ABFugenjuJohoEntity.FUGENJUJOHO_TAISHOSHASHIMEI);
                            // •sŒ»Zî•ñi¶”NŒŽ“új
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUJOHO_UMAREYMD) = csDataRow(ABFugenjuJohoEntity.FUGENJUJOHO_UMAREYMD);
                            // •sŒ»Zî•ñi«•Êj
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUJOHO_SEIBETSU) = csDataRow(ABFugenjuJohoEntity.FUGENJUJOHO_SEIBETSU);
                            // ‹Z•s–¾”NŒŽ“ú
                            csDataNewRow(ABAtena1HyojunEntity.KYOJUFUMEI_YMD) = csDataRow(ABFugenjuJohoEntity.KYOJUFUMEI_YMD);
                            // •sŒ»Zî•ñi”õlj
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUJOHO_BIKO) = csDataRow(ABFugenjuJohoEntity.FUGENJUJOHO_BIKO);
                        }
                        else
                        {
                        }
                        if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                        {
                            // ”Ô†–@XV‹æ•ª
                            csDataNewRow(ABAtena1HyojunEntity.BANGOHOKOSHINKB) = csDataRow(ABMyNumberHyojunEntity.BANGOHOKOSHINKB);
                        }
                        // * —š—ð”Ô† 000051 2023/10/19 C³ŠJŽn
                        // If (m_blnMethodKB = ABEnumDefine.MethodKB.KB_AtenaGet1) AndAlso (strGyomuMei <> NENKIN) AndAlso (strGyomuMei <> NENKIN_2) Then
                        if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_AtenaGet1 && (strGyomuMei ?? "") != NENKIN && (strGyomuMei ?? "") != NENKIN_2 && csDataRow.Table.Columns.Contains(ABDENSHISHOMEISHOMSTEntity.SERIALNO))
                        {
                            // * —š—ð”Ô† 000051 2023/10/19 C³I—¹
                            // ƒVƒŠƒAƒ‹”Ô†
                            csDataNewRow(ABAtena1HyojunEntity.SERIALNO) = csDataRow(ABDENSHISHOMEISHOMSTEntity.SERIALNO);
                        }
                        // •W€€‹’ˆÙ“®Ž–—RƒR[ƒh
                        csDataNewRow(ABAtena1HyojunEntity.HYOJUNIDOJIYUCD) = csDataRow(ABAtenaHyojunEntity.HYOJUNIDOJIYUCD);
                        if ((strGyomuMei ?? "") != NENKIN && (strGyomuMei ?? "") != NENKIN_2)
                        {
                            // ˜A—æ‹æ•ªi‘—•tæj
                            csDataNewRow(ABAtena1HyojunEntity.SFSKRENRAKUSAKIKB) = string.Empty;
                            // ‘—•tæ‹æ•ª
                            csDataNewRow(ABAtena1HyojunEntity.SFSKKBN) = string.Empty;
                        }
                        else
                        {
                        }

                        strAtenaDataKB = Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATAKB)).Trim;
                        strAtenaDataSHU = Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATASHU)).Trim;
                        m_cABHyojunkaCdHenshuB.HenshuHyojunkaCd(strAtenaDataKB, strAtenaDataSHU);
                        // Z–¯‹æ•ª
                        csDataNewRow(ABAtena1HyojunEntity.JUMINKBN) = m_cABHyojunkaCdHenshuB.p_strJuminKbn;
                        // Z–¯Ží•Ê
                        csDataNewRow(ABAtena1HyojunEntity.JUMINSHUBETSU) = m_cABHyojunkaCdHenshuB.p_strJuminShubetsu;
                        // Z–¯ó‘Ô
                        csDataNewRow(ABAtena1HyojunEntity.JUMINJOTAI) = m_cABHyojunkaCdHenshuB.p_strJuminJotai;
                        if (cAtenaGetPara1.p_strJukiJutogaiKB == "1")
                        {
                            // ”Ô’nŽ}”Ô”’l
                            csDataNewRow(ABAtena1HyojunEntity.BANCHIEDABANSUCHI) = csDataRow(ABAtenaHyojunEntity.JUKIBANCHIEDABANSUCHI);
                        }
                        else
                        {
                            // ”Ô’nŽ}”Ô”’l
                            csDataNewRow(ABAtena1HyojunEntity.BANCHIEDABANSUCHI) = csDataRow(ABAtenaHyojunEntity.BANCHIEDABANSUCHI);
                        }
                    }
                    else
                    {
                        // noop
                    }

                    // *—š—ð”Ô† 000026 2005/12/21 ’Ç‰ÁŠJŽn
                    csDataNewRow.EndEdit();
                    // *—š—ð”Ô† 000026 2005/12/21 ’Ç‰ÁI—¹

                    // ƒf[ƒ^ƒŒƒR[ƒh‚Ì’Ç‰Á
                    csDataTable.Rows.Add(csDataNewRow);
                    // *—š—ð”Ô† 000013 2003/04/18 C³I—¹

                }

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException exException)
            {

                // ƒGƒ‰[ƒƒOo—Í
                m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default
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
                                                    "yƒGƒ‰[“
               */
);
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 182389


                Input:
                " + exException.Message + "z")

                            ' ƒXƒ[‚·‚é
                            Throw exException

                        Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                      "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 182681


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                      "yƒƒ\ƒbƒh–¼:
                 */
                ;

                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 182762


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                      "yƒGƒ‰[“à—e:" + exException.Message + "z")

                                 */
                throw exException;

            }

            return csAtena1;

        }
        #endregion

        #region  ”
        // *—š—ð”Ô† 000013 2003/04/18 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ”N‹àˆ¶–¼•ÒW
        // * 
        // * \•¶           Public Function NenkinAtenaHenshu(ByVal cAtenaGetPara1 As ABAtenaGetPara1,
        // *                                           ByVal csAtenaEntity As DataSet) As DataSet
        // * 
        // * ‹@”\@@    @@”N‹à•ÒWˆ¶–¼ƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”         cAtenaGetPara1      : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // *              csAtenaEntity       : ˆ¶–¼ƒf[ƒ^
        // * 
        // * –ß‚è’l       DataSet(ABNenkinAtena)   : Žæ“¾‚µ‚½”N‹à—pˆ¶–¼î•ñ
        // ************************************************************************************************
        public DataSet NenkinAtenaHenshu(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtenaEntity)
        {
            return AtenaHenshu(cAtenaGetPara1, csAtenaEntity, "", "", "", NENKIN);
        }
        // *—š—ð”Ô† 000013 2003/04/18 ’Ç‰ÁI—¹
        // *—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ”N‹à—š—ð•ÒW
        // * 
        // * \•¶           Public Function NenkinRirekiHenshu(ByVal cAtenaGetPara1 As ABAtenaGetPara1,
        // *                                                  ByVal csAtenaEntity As DataSet) As DataSet
        // * 
        // * ‹@”\@@    @@”N‹à•ÒWˆ¶–¼ƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”         cAtenaGetPara1      : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // *              csAtenaEntity       : ˆ¶–¼ƒf[ƒ^
        // * 
        // * –ß‚è’l       DataSet(ABNenkinAtena)   : Žæ“¾‚µ‚½”N‹à—pˆ¶–¼î•ñ
        // ************************************************************************************************
        public DataSet NenkinRirekiHenshu(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtenaEntity)
        {
            return RirekiHenshu(cAtenaGetPara1, csAtenaEntity, string.Empty, string.Empty, string.Empty, NENKIN);
        }
        // *—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁI—¹
        #endregion

        #region  ”
        // *—š—ð”Ô† 000027 2006/07/31 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ”N‹àˆ¶–¼•ÒW‡U
        // * 
        // * \•¶           Public Function NenkinAtenaHenshu2(ByVal cAtenaGetPara1 As ABAtenaGetPara1,
        // *                                           ByVal csAtenaEntity As DataSet) As DataSet
        // * 
        // * ‹@”\@@    @@”N‹à•ÒWˆ¶–¼ƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”         cAtenaGetPara1      : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // *              csAtenaEntity       : ˆ¶–¼ƒf[ƒ^
        // * 
        // * –ß‚è’l       DataSet(ABNenkinAtena)   : Žæ“¾‚µ‚½”N‹à—pˆ¶–¼î•ñ
        // ************************************************************************************************
        public DataSet NenkinAtenaHenshu2(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtenaEntity)
        {
            return AtenaHenshu(cAtenaGetPara1, csAtenaEntity, "", "", "", NENKIN_2);
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ”N‹à—š—ð•ÒW‡U
        // * 
        // * \•¶           Public Function NenkinRirekiHenshu2(ByVal cAtenaGetPara1 As ABAtenaGetPara1,
        // *                                                  ByVal csAtenaEntity As DataSet) As DataSet
        // * 
        // * ‹@”\@@    @@”N‹à•ÒWˆ¶–¼ƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”         cAtenaGetPara1      : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // *              csAtenaEntity       : ˆ¶–¼ƒf[ƒ^
        // * 
        // * –ß‚è’l       DataSet(ABNenkinAtena)   : Žæ“¾‚µ‚½”N‹à—pˆ¶–¼î•ñ
        // ************************************************************************************************
        public DataSet NenkinRirekiHenshu2(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtenaEntity)
        {
            return RirekiHenshu(cAtenaGetPara1, csAtenaEntity, string.Empty, string.Empty, string.Empty, NENKIN_2);
        }
        // *—š—ð”Ô† 000027 2006/07/31 ’Ç‰ÁI—¹
        #endregion

        #region  ˆ¶–¼ŒÂ•Ê•ÒW(AtenaKobetsuHenshu) 
        // *—š—ð”Ô† 000019 2003/11/19 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ŒÂ•Ê•ÒW
        // * 
        // * \•¶           Friend Function AtenaKobetsuHenshu(ByVal cAtenaGetPara1 As ABAtenaGetPara1,
        // *                                           ByVal csAtenaEntity As DataSet) As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼ŒÂ•Ê•ÒWƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”         cAtenaGetPara1      : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // *              csAtenaEntity       : ˆ¶–¼ƒf[ƒ^
        // * 
        // * –ß‚è’l       DataSet(ABAtena1Kobetsu)   : Žæ“¾‚µ‚½ˆ¶–¼ŒÂ•Ê•ÒW
        // ************************************************************************************************
        internal DataSet AtenaKobetsuHenshu(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtenaEntity)
        {
            return AtenaHenshu(cAtenaGetPara1, csAtenaEntity, "", "", "", KOBETSU);
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ŒÂ•Ê•ÒW
        // * 
        // * \•¶           Friend Function AtenaKobetsuHenshu(ByVal cAtenaGetPara1 As ABAtenaGetPara1,
        // *                                           ByVal csAtenaEntity As DataSet) As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼ŒÂ•Ê•ÒWƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”         cAtenaGetPara1      : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // * @@         csAtenaEntity       : ˆ¶–¼ƒf[ƒ^
        // * @@         strDainoKB          : ‘ã”[‹æ•ª
        // * @@         strGyomuCD          : ‹Æ–±ƒR[ƒh
        // * @@         strGyomunaiSHU_CD   : ‹Æ–±“àŽí•ÊƒR[ƒh
        // * 
        // * –ß‚è’l       DataSet(ABAtena1Kobetsu)   : Žæ“¾‚µ‚½ˆ¶–¼ŒÂ•Ê•ÒW
        // ************************************************************************************************
        internal DataSet AtenaKobetsuHenshu(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtenaEntity, string strDainoKB, string strGyomuCD, string strGyomunaiSHU_CD)
        {
            return AtenaHenshu(cAtenaGetPara1, csAtenaEntity, strDainoKB, strGyomuCD, strGyomunaiSHU_CD, KOBETSU);
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðŒÂ•Ê•ÒW
        // * 
        // * \•¶           Friend Function RirekiKobetsuHenshu(ByVal cAtenaGetPara1 As ABAtenaGetPara1,
        // *                                                  ByVal csAtenaEntity As DataSet) As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼—š—ðŒÂ•Ê•ÒWƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”         cAtenaGetPara1      : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // *              csAtenaEntity       : ˆ¶–¼ƒf[ƒ^
        // * 
        // * –ß‚è’l       DataSet(ABAtena1Kobetsu)   : Žæ“¾‚µ‚½ˆ¶–¼—š—ðŒÂ•Ê•ÒW
        // ************************************************************************************************
        internal DataSet RirekiKobetsuHenshu(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtenaEntity)
        {
            return RirekiHenshu(cAtenaGetPara1, csAtenaEntity, string.Empty, string.Empty, string.Empty, KOBETSU);
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðŒÂ•Ê•ÒW
        // * 
        // * \•¶           Friend Function RirekiKobetsuHenshu(ByVal cAtenaGetPara1 As ABAtenaGetPara1,
        // *                                                  ByVal csAtenaEntity As DataSet) As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼—š—ðŒÂ•Ê•ÒWƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”          cAtenaGetPara1         : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // * @@          csAtenaRirekiEntity    : ˆ¶–¼—š—ðƒf[ƒ^
        // * @@          strDainoKB             : ‘ã”[‹æ•ª
        // * @@          strGyomuMei            : ‹Æ–±–¼
        // * 
        // * –ß‚è’l       DataSet(ABAtena1Kobetsu)   : Žæ“¾‚µ‚½ˆ¶–¼—š—ðŒÂ•Ê•ÒW
        // ************************************************************************************************
        internal DataSet RirekiKobetsuHenshu(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtenaRirekiEntity, string strDainoKB, string strGyomuCD, string strGyomunaiSHU_CD)
        {
            return RirekiHenshu(cAtenaGetPara1, csAtenaRirekiEntity, strDainoKB, strGyomuCD, strGyomunaiSHU_CD, KOBETSU);
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘—•tæŒÂ•Ê•ÒW
        // * 
        // * \•¶           Friend Function SofusakiKobetsuHenshu(ByVal csAtena1 As DataSet, _
        // *                                                      ByVal csSfskEntity As DataSet, _
        // *                                                      ByVal cAtenaGetPara1 As ABAtenaGetPara1) As DataSet
        // * 
        // * ‹@”\@@    @ •ÒWˆ¶–¼ƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”           csAtena1              : ˆ¶–¼—š—ðƒf[ƒ^
        // *               csSfskEntity           : ‘—•tæƒf[ƒ^
        // *               cAtenaGetPara1         : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // * 
        // * –ß‚è’l         DataSet(ABAtena12)    : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        internal DataSet SofusakiKobetsuHenshu(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtena1, DataSet csSfskEntity)
        {
            return SofusakiHenshu(cAtenaGetPara1, csAtena1, csSfskEntity, KOBETSU);
        }
        // *—š—ð”Ô† 000019 2003/11/19 ’Ç‰ÁI—¹
        #endregion

        #region  —š—ð•ÒW(RirekiHenshu) 
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     —š—ð•ÒW
        // * 
        // * \•¶           Public Function RirekiHenshu(ByVal cAtenaGetPara1 As ABAtenaGetPara1, _
        // *                                            ByVal csAtenaRirekiEntity As DataSet) As DataSet
        // * 
        // * ‹@”\@@    @ •ÒWˆ¶–¼ƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”           cAtenaGetPara1         : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // *               csAtenaRirekiEntity    : ˆ¶–¼—š—ðƒf[ƒ^
        // * 
        // * –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        public DataSet RirekiHenshu(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtenaRirekiEntity)
        {

            // *—š—ð”Ô† 000017 2003/10/09 C³ŠJŽn
            // Return RirekiHenshu(cAtenaGetPara1, csAtenaRirekiEntity, "", "", "")
            return RirekiHenshu(cAtenaGetPara1, csAtenaRirekiEntity, string.Empty, string.Empty, string.Empty);
            // *—š—ð”Ô† 000017 2003/10/09 C³I—¹
        }

        // *—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     —š—ð•ÒW
        // * 
        // * \•¶           Public Function RirekiHenshu(ByVal csAtenaRirekiEntity As DataSet, 
        // *                                            ByVal cAtenaGetPara1 As ABAtenaGetPara1, 
        // *                                            ByVal strDainoKB As String,
        // *                                            ByVal strGyomuCD As String,
        // *                                            ByVal strGyomunaiSHU_CD As String) As DataSet
        // * 
        // * ‹@”\@@    @ •ÒWˆ¶–¼ƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”           cAtenaGetPara1         : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // *               csAtenaRirekiEntity    : ˆ¶–¼—š—ðƒf[ƒ^
        // *               strDainoKB             : ‘ã”[‹æ•ª
        // * 
        // * –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        public DataSet RirekiHenshu(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtenaRirekiEntity, string strDainoKB, string strGyomuCD, string strGyomunaiSHU_CD)
        {
            return RirekiHenshu(cAtenaGetPara1, csAtenaRirekiEntity, strDainoKB, strGyomuCD, strGyomunaiSHU_CD, string.Empty);
        }
        // *—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁI—¹

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     —š—ð•ÒW
        // * 
        // * \•¶           Public Function RirekiHenshu(ByVal csAtenaRirekiEntity As DataSet, 
        // *                                            ByVal cAtenaGetPara1 As ABAtenaGetPara1, 
        // *                                            ByVal strDainoKB As String,
        // *                                            ByVal strGyomuCD As String,
        // *                                            ByVal strGyomunaiSHU_CD As String, _
        // *                                            ByVal strGyomuMei As String) As DataSet
        // * 
        // * ‹@”\@@    @ •ÒWˆ¶–¼ƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”           cAtenaGetPara1         : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // *               csAtenaRirekiEntity    : ˆ¶–¼—š—ðƒf[ƒ^
        // *               strDainoKB             : ‘ã”[‹æ•ª
        // *               strGyomuMei            : ‹Æ–±–¼
        // * 
        // * –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        // *—š—ð”Ô† 000017 2003/10/09 C³ŠJŽn
        // Public Overloads Function RirekiHenshu(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass, _
        // ByVal csAtenaRirekiEntity As DataSet, _
        // ByVal strDainoKB As String, _
        // ByVal strGyomuCD As String, _
        // ByVal strGyomunaiSHU_CD As String) As DataSet
        private DataSet RirekiHenshu(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtenaRirekiEntity, string strDainoKB, string strGyomuCD, string strGyomunaiSHU_CD, string strGyomuMei)
        {
            // *—š—ð”Ô† 000017 2003/10/09 C³I—¹
            const string THIS_METHOD_NAME = "RirekiHenshu";
            // Dim cfErrorClass As UFErrorClass                    'ƒGƒ‰[ˆ—ƒNƒ‰ƒX
            // Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì
            // * corresponds to VS2008 Start 2010/04/16 000039
            // Dim csDataSet As DataSet
            // * corresponds to VS2008 End 2010/04/16 000039
            DataTable csDataTable;
            DataSet csAtena1;                             // ˆ¶–¼î•ñ(ABAtena1)
            DataRow csDataNewRow;
            // * —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
            // Dim cuUSSCityInfo As USSCityInfoClass               'Žs’¬‘ºî•ñŠÇ—ƒNƒ‰ƒX
            // Dim cABDainoKankeiB As ABDainoKankeiBClass          '‘ã”[ŠÖŒWƒNƒ‰ƒX
            // Dim cABJuminShubetsuB As ABJuminShubetsuBClass      'Z–¯Ží•ÊƒNƒ‰ƒX
            // Dim cABHojinMeishoB As ABHojinMeishoBClass          '–@l–¼ÌƒNƒ‰ƒX
            // Dim cABKjnhjnKBB As ABKjnhjnKBBClass                'ŒÂl–@lƒNƒ‰ƒX
            // Dim cABKannaiKangaiKBB As ABKannaiKangaiKBBClass    'ŠÇ“àŠÇŠOƒNƒ‰ƒX
            // Dim cABUmareHenshuB As ABUmareHenshuBClass          '¶”NŒŽ“ú•ÒWƒNƒ‰ƒX
            // * —š—ð”Ô† 000023 2004/08/27 íœI—¹
            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
            // Dim csDainoKankeiCDMSTEntity As DataSet             '‘ã”[ŠÖŒWDataSet
            DataRow[] csDainoKankeiCDMSTEntity;             // ‘ã”[ŠÖŒWDataRow()
                                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj

            // * —š—ð”Ô† 000024 2005/01/25 íœŠJŽni‹{‘òj
            // Dim strHenshuJusho As String                        '•ÒWZŠ–¼
            // * —š—ð”Ô† 000024 2005/01/25 íœI—¹

            string strHenshuKanaMeisho;                   // •ÒWƒJƒi–¼Ì
            string strHenshuKanjiShimei;                  // •ÒWŠ¿ŽšŽ–¼
                                                          // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁŠJŽn
                                                          // *—š—ð”Ô† 000016 2003/08/22 íœŠJŽn
                                                          // Dim cURKanriJohoB As URKANRIJOHOBClass              'ŠÇ—î•ñŽæ“¾ƒNƒ‰ƒX
                                                          // *—š—ð”Ô† 000016 2003/08/22 íœI—¹
            SofuJushoGyoseikuType cSofuJushoGyoseikuType;
            var strJushoHenshu3 = default(string);                       // ZŠ•ÒW‚R
                                                                         // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁI—¹
                                                                         // *—š—ð”Ô† 000015 2003/04/30 ’Ç‰ÁŠJŽn
            var strJushoHenshu4 = default(string);                       // ZŠ•ÒW‚S
                                                                         // *—š—ð”Ô† 000015 2003/04/30 ’Ç‰ÁI—¹

            // *—š—ð”Ô† 000021 2003/12/02 íœŠJŽn
            // '*—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁŠJŽn
            // Dim cRenrakusakiBClass As ABRenrakusakiBClass       ' ˜A—æ‚aƒNƒ‰ƒX
            // Dim csRenrakusakiEntity As DataSet                  ' ˜A—æDataSet
            // Dim csRenrakusakiRow As DataRow                     ' ˜A—æRow
            // '*—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁI—¹
            // *—š—ð”Ô† 000021 2003/12/02 íœI—¹
            // * corresponds to VS2008 Start 2010/04/16 000039
            // *—š—ð”Ô† 000020 2003/12/01 ’Ç‰ÁŠJŽn
            // Dim strRenrakusakiGyomuCD As String                 ' ˜A—æ‹Æ–±ƒR[ƒh
            // *—š—ð”Ô† 000020 2003/12/01 ’Ç‰ÁI—¹
            // * corresponds to VS2008 End 2010/04/16 000039

            // * —š—ð”Ô† 000026 2005/12/21 ’Ç‰ÁŠJŽn
            string strWork;
            // * —š—ð”Ô† 000026 2005/12/21 ’Ç‰ÁI—¹
            // *—š—ð”Ô† 000042 2011/05/18 ’Ç‰ÁŠJŽn
            var strMeisho = new string[2];                          // –{–¼’ÊÌ–¼—Dæ§Œä—p
                                                                    // *—š—ð”Ô† 000042 2011/05/18 ’Ç‰ÁI—¹
            string strAtenaDataKB;
            string strAtenaDataSHU;


            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // 'ƒGƒ‰[ˆ—ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // '*—š—ð”Ô† 000010  2003/03/27 C³ŠJŽn
                // 'cfErrorClass = New UFErrorClass(m_cfUFControlData.m_strBusinessId)
                // cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                // '*—š—ð”Ô† 000010  2003/03/27 C³I—¹

                // *—š—ð”Ô† 000017 2003/10/09 C³ŠJŽn
                // 'ƒJƒ‰ƒ€î•ñì¬
                // csAtena1 = New DataSet()
                // csAtena1.Tables.Add(Me.CreateAtena1Columns())

                // *—š—ð”Ô† 000019 2003/11/19 C³ŠJŽn
                // 'ƒJƒ‰ƒ€î•ñì¬
                // If (strGyomuMei = NENKIN) Then
                // csDataTable = Me.CreateNenkinAtenaColumns()
                // Else
                // csDataTable = Me.CreateAtena1Columns()
                // End If

                // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁŠJŽn
                // –{Ð•M“ªŽÒ‹æ•ªƒpƒ‰ƒ[ƒ^‚É•Ï”‚ðƒZƒbƒg
                m_strHonsekiHittoshKB_Param = cAtenaGetPara1.p_strHonsekiHittoshKB;

                // ˆ—’âŽ~‹æ•ªƒpƒ‰ƒ[ƒ^‚É•Ï”‚ðƒZƒbƒg
                m_strShoriteishiKB_Param = cAtenaGetPara1.p_strShoriTeishiKB;
                // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁI—¹

                // *—š—ð”Ô† 000041 2011/05/18 ’Ç‰ÁŠJŽn
                // ŠO‘lÝ—¯î•ñŽæ“¾‹æ•ªƒpƒ‰ƒ[ƒ^‚É•Ï”‚ðƒZƒbƒg
                m_strFrnZairyuJohoKB_Param = cAtenaGetPara1.p_strFrnZairyuJohoKB;
                // *—š—ð”Ô† 000041 2011/05/18 ’Ç‰ÁI—¹
                // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁŠJŽn
                // ZŠî–@‰ü³‹æ•ª‚ð•Ï”‚ÉƒZƒbƒg
                m_strJukiHokaiseiKB_Param = cAtenaGetPara1.p_strJukiHokaiseiKB;
                // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁI—¹
                // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁŠJŽn
                // ‹¤’Ê”Ô†Žæ“¾‹æ•ª‚ð•Ï”‚ÉƒZƒbƒg
                m_strMyNumberKB_Param = cAtenaGetPara1.p_strMyNumberKB;
                // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁI—¹

                // ƒJƒ‰ƒ€î•ñì¬
                switch (strGyomuMei ?? "")
                {
                    // *—š—ð”Ô† 000027 2006/07/31 C³ŠJŽn
                    case NENKIN:
                    case NENKIN_2:    // ”N‹àˆ¶–¼î•ñ
                        {
                            // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁŠJŽn
                            m_blnNenKin = true;
                            // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁI—¹

                            // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁŠJŽn
                            m_blnKobetsu = false;
                            m_strKobetsuShutokuKB = string.Empty;
                            // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁI—¹
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                csDataTable = CreateNenkinAtenaHyojunColumns(strGyomuMei);
                            }
                            else
                            {
                                csDataTable = CreateNenkinAtenaColumns(strGyomuMei);
                            }

                            break;
                        }
                    // Case NENKIN     ' ”N‹àˆ¶–¼î•ñ
                    // csDataTable = Me.CreateNenkinAtenaColumns()
                    // *—š—ð”Ô† 000027 2006/07/31 C³I—¹
                    case KOBETSU:    // ˆ¶–¼ŒÂ•Êî•ñ
                        {
                            // *—š—ð”Ô† 000034 2008/01/15 ’Ç‰ÁŠJŽn
                            // ŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ðƒƒ“ƒo•Ï”‚ÉƒZƒbƒg
                            m_strKobetsuShutokuKB = cAtenaGetPara1.p_strKobetsuShutokuKB.Trim;
                            // *—š—ð”Ô† 000034 2008/01/15 ’Ç‰ÁI—¹

                            // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁŠJŽn
                            m_blnKobetsu = true;
                            // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁI—¹

                            // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁŠJŽn
                            m_blnNenKin = false;
                            // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁI—¹
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                csDataTable = this.CreateAtena1KobetsuHyojunColumns();
                            }
                            else
                            {
                                csDataTable = CreateAtena1KobetsuColumns();
                            }       // ˆ¶–¼î•ñ

                            break;
                        }

                    default:
                        {
                            // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁŠJŽn
                            m_blnKobetsu = false;
                            m_blnNenKin = false;
                            m_strKobetsuShutokuKB = string.Empty;
                            // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁI—¹
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                csDataTable = CreateAtena1HyojunColumns();
                            }
                            else
                            {
                                csDataTable = CreateAtena1Columns();
                            }

                            break;
                        }
                }
                // *—š—ð”Ô† 000019 2003/11/19 C³I—¹

                csAtena1 = new DataSet();
                csAtena1.Tables.Add(csDataTable);
                // *—š—ð”Ô† 000017 2003/10/09 C³I—¹

                // * —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                // 'Žs’¬‘ºî•ñ‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // 'cuUSSCityInfo = New USSCityInfoClass()

                /// ã”[ŠÖŒW‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cABDainoKankeiB = New ABDainoKankeiBClass(m_cfUFControlData, m_cfUFConfigDataClass, m_cfUFRdbClass)

                // 'Z–¯Ží•Ê‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cABJuminShubetsuB = New ABJuminShubetsuBClass(m_cfUFControlData, m_cfUFConfigDataClass)

                // '–@l–¼Ì‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cABHojinMeishoB = New ABHojinMeishoBClass(m_cfUFControlData, m_cfUFConfigDataClass)

                // 'ŒÂl–@l‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cABKjnhjnKBB = New ABKjnhjnKBBClass(m_cfUFControlData, m_cfUFConfigDataClass)

                // 'ŠÇ“àŠÇŠO‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cABKannaiKangaiKBB = New ABKannaiKangaiKBBClass(m_cfUFControlData, m_cfUFConfigDataClass)

                // '¶”NŒŽ“ú•ÒWƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                // cABUmareHenshuB = New ABUmareHenshuBClass(m_cfUFControlData, m_cfUFConfigDataClass)
                // * —š—ð”Ô† 000023 2004/08/27 íœI—¹

                // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁŠJŽn
                // *—š—ð”Ô† 000016 2003/08/22 íœŠJŽn
                // 'ŠÇ—î•ñŽæ“¾‚a‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cURKanriJohoB = New Densan.Reams.UR.UR001BB.URKANRIJOHOBClass(m_cfUFControlData, m_cfUFConfigDataClass, m_cfUFRdbClass)
                // *—š—ð”Ô† 000016 2003/08/22 íœI—¹
                // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁI—¹

                // *—š—ð”Ô† 000021 2003/12/02 íœŠJŽn
                // '*—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁŠJŽn
                // ' ˜A—æ‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cRenrakusakiBClass = New ABRenrakusakiBClass(m_cfUFControlData, m_cfUFConfigDataClass, m_cfUFRdbClass)
                // '*—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁI—¹
                // *—š—ð”Ô† 000021 2003/12/02 íœI—¹

                // *—š—ð”Ô† 000007 2003/03/17 ’Ç‰ÁŠJŽn
                // ƒpƒ‰ƒ[ƒ^‚Ìƒ`ƒFƒbƒN
                CheckColumnValue(cAtenaGetPara1);
                // *—š—ð”Ô† 000007 2003/03/17 ’Ç‰ÁI—¹

                // * —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                // 'ZŠ•ÒW‚P‚ª"1"ŠŽ‚ÂZŠ•ÒW‚Q‚ª"1"‚Ìê‡
                // If cAtenaGetPara1.p_strJushoHenshu1 = "1" And cAtenaGetPara1.p_strJushoHenshu2 = "1" Then

                // '’¼‹ß‚ÌŽs’¬‘º–¼‚ðŽæ“¾‚·‚é
                // 'm_cuUSSCityInfo.GetCityInfo(m_cfUFControlData)
                // End If
                // * —š—ð”Ô† 000023 2004/08/27 íœI—¹

                // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁŠJŽn
                // ZŠ•ÒW‚P‚ª"1"ŠŽ‚ÂZŠ•ÒW‚R‚ª""‚Ìê‡
                if (cAtenaGetPara1.p_strJushoHenshu1 == "1" & cAtenaGetPara1.p_strJushoHenshu3 == string.Empty)
                {
                    // *—š—ð”Ô† 000016 2003/08/22 C³ŠJŽn
                    // cSofuJushoGyoseikuType = cURKanriJohoB.GetSofuJushoGyoseiku_SofuJushoGyoseiku_Param

                    cSofuJushoGyoseikuType = this.GetSofuJushoGyoseikuType;
                    // *—š—ð”Ô† 000016 2003/08/22 C³I—¹
                    switch (cSofuJushoGyoseikuType)
                    {
                        case var @case when @case == SofuJushoGyoseikuType.Jusho_Banchi:
                            {
                                strJushoHenshu3 = "1";
                                strJushoHenshu4 = "";
                                break;
                            }
                        case var case1 when case1 == SofuJushoGyoseikuType.Jusho_Banchi_SP_Katagaki:
                            {
                                strJushoHenshu3 = "1";
                                strJushoHenshu4 = "1";
                                break;
                            }
                        case var case2 when case2 == SofuJushoGyoseikuType.Gyoseiku_SP_Banchi:
                            {
                                strJushoHenshu3 = "5";
                                strJushoHenshu4 = "";
                                break;
                            }
                        case var case3 when case3 == SofuJushoGyoseikuType.Gyoseiku_SP_Banchi_SP_Katagaki:
                            {
                                strJushoHenshu3 = "5";
                                strJushoHenshu4 = "1";
                                break;
                            }
                    }
                }
                else
                {
                    strJushoHenshu3 = cAtenaGetPara1.p_strJushoHenshu3;
                    strJushoHenshu4 = cAtenaGetPara1.p_strJushoHenshu4;
                }
                // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁI—¹

                // •ÒWˆ¶–¼ƒf[ƒ^‚ðì¬‚·‚é
                foreach (DataRow csDataRow in csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows)
                {
                    // *—š—ð”Ô† 000017 2003/10/09 C³ŠJŽn
                    // csDataNewRow = csAtena1.Tables(ABAtena1Entity.TABLE_NAME).NewRow
                    csDataNewRow = csDataTable.NewRow();
                    // *—š—ð”Ô† 000017 2003/10/09 C³I—¹

                    // *—š—ð”Ô† 000015 2003/04/30 ’Ç‰ÁŠJŽn
                    foreach (DataColumn csColumn in csDataNewRow.Table.Columns)
                        csDataNewRow[csColumn] = string.Empty;
                    // *—š—ð”Ô† 000015 2003/04/30 ’Ç‰ÁI—¹

                    // *—š—ð”Ô† 000021 2003/12/02 íœŠJŽn
                    // '*—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁŠJŽn
                    // ' ‹Æ–±ƒR[ƒh‚ªŽw’è‚³‚ê‚½ê‡
                    // If (strGyomuCD <> String.Empty) Then

                    // ' ˜A—æƒf[ƒ^‚ðŽæ“¾‚·‚é
                    // csRenrakusakiEntity = cRenrakusakiBClass.GetRenrakusakiBHoshu(CType(csDataRow(ABAtenaEntity.JUMINCD), String), strGyomuCD, strGyomunaiSHU_CD)
                    // If (csRenrakusakiEntity.Tables(ABRenrakusakiEntity.TABLE_NAME).Rows.Count <> 0) Then
                    // csRenrakusakiRow = csRenrakusakiEntity.Tables(ABRenrakusakiEntity.TABLE_NAME).Rows(0)
                    // Else
                    // csRenrakusakiRow = Nothing
                    // End If
                    // Else
                    // csRenrakusakiRow = Nothing
                    // End If
                    // '*—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁI—¹
                    // *—š—ð”Ô† 000021 2003/12/02 íœI—¹

                    // Z–¯ƒR[ƒh
                    csDataNewRow(ABAtena1Entity.JUMINCD) = csDataRow(ABAtenaRirekiEntity.JUMINCD);

                    // ‘ã”[‹æ•ª
                    if (string.IsNullOrEmpty(strDainoKB))
                    {
                        csDataNewRow(ABAtena1Entity.DAINOKB) = "00";
                    }
                    else
                    {
                        csDataNewRow(ABAtena1Entity.DAINOKB) = strDainoKB;
                    }

                    if (Conversions.ToString(csDataNewRow(ABAtena1Entity.DAINOKB)) == "00")
                    {
                        // ‘ã”[‹æ•ª–¼Ì
                        csDataNewRow(ABAtena1Entity.DAINOKBMEISHO) = string.Empty;
                        // ‘ã”[‹æ•ª—ªŽ®–¼Ì
                        csDataNewRow(ABAtena1Entity.DAINOKBRYAKUMEISHO) = string.Empty;
                    }
                    else
                    {
                        // ‘ã”[ŠÖŒWƒf[ƒ^‚ðŽæ“¾‚·‚é

                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                        // csDainoKankeiCDMSTEntity = m_cABDainoKankeiB.GetDainoKBHoshu(CType(csDataNewRow(ABAtena1Entity.DAINOKB), String))
                        // '‚OŒ‚Ìê‡A
                        // If csDainoKankeiCDMSTEntity.Tables(ABDainoKankeiCDMSTEntity.TABLE_NAME).Rows.Count = 0 Then
                        // csDataNewRow(ABAtena1Entity.DAINOKBMEISHO) = String.Empty                   '‘ã”[‹æ•ª–¼Ì
                        // csDataNewRow(ABAtena1Entity.DAINOKBRYAKUMEISHO) = String.Empty              '‘ã”[‹æ•ª—ªŽ®–¼Ì
                        // Else
                        // With csDainoKankeiCDMSTEntity.Tables(ABDainoKankeiCDMSTEntity.TABLE_NAME).Rows(0)

                        // '‘ã”[‹æ•ª–¼Ì
                        // csDataNewRow(ABAtena1Entity.DAINOKBMEISHO) = CType(.Item(ABDainoKankeiCDMSTEntity.DAINOKBMEISHO), String)

                        // '‘ã”[‹æ•ª—ªŽ®–¼Ì
                        // csDataNewRow(ABAtena1Entity.DAINOKBRYAKUMEISHO) = CType(.Item(ABDainoKankeiCDMSTEntity.DAINOKBRYAKUMEI), String)
                        // End With

                        // End If
                        csDainoKankeiCDMSTEntity = m_cABDainoKankeiB.GetDainoKBHoshu2(Conversions.ToString(csDataNewRow(ABAtena1Entity.DAINOKB)));
                        if (csDainoKankeiCDMSTEntity.Length == 0)
                        {
                            csDataNewRow(ABAtena1Entity.DAINOKBMEISHO) = string.Empty;                   // ‘ã”[‹æ•ª–¼Ì
                            csDataNewRow(ABAtena1Entity.DAINOKBRYAKUMEISHO) = string.Empty;              // ‘ã”[‹æ•ª—ªŽ®–¼Ì
                        }
                        else
                        {

                            // ‘ã”[‹æ•ª–¼Ì
                            csDataNewRow(ABAtena1Entity.DAINOKBMEISHO) = Conversions.ToString(csDainoKankeiCDMSTEntity[0].Item(ABDainoKankeiCDMSTEntity.DAINOKBMEISHO));

                            // ‘ã”[‹æ•ª—ªŽ®–¼Ì
                            csDataNewRow(ABAtena1Entity.DAINOKBRYAKUMEISHO) = Conversions.ToString(csDainoKankeiCDMSTEntity[0].Item(ABDainoKankeiCDMSTEntity.DAINOKBRYAKUMEI));

                        }
                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                    }

                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                    {

                        // ‘ã”[‹æ•ªŽw’è‚È‚µ‚Ìê‡
                        if (string.IsNullOrEmpty(strGyomuCD))
                        {

                            // ‹Æ–±ƒR[ƒh
                            csDataNewRow(ABAtena1Entity.GYOMUCD) = "00";

                            // ‹Æ–±“àŽí•ÊƒR[ƒh
                            csDataNewRow(ABAtena1Entity.GYOMUNAISHU_CD) = string.Empty;
                        }
                        else
                        {
                            // ‹Æ–±ƒR[ƒh
                            csDataNewRow(ABAtena1Entity.GYOMUCD) = strGyomuCD;

                            // ‹Æ–±“àŽí•ÊƒR[ƒh
                            csDataNewRow(ABAtena1Entity.GYOMUNAISHU_CD) = strGyomunaiSHU_CD;
                        }

                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                    // ‹ŒŽs’¬‘ºƒR[ƒh
                    csDataNewRow(ABAtena1Entity.KYUSHICHOSONCD) = csDataRow(ABAtenaRirekiEntity.KYUSHICHOSONCD);

                    // ¢‘ÑƒR[ƒh
                    csDataNewRow(ABAtena1Entity.STAICD) = csDataRow(ABAtenaRirekiEntity.STAICD);

                    // ˆ¶–¼ƒf[ƒ^‹æ•ª
                    csDataNewRow(ABAtena1Entity.ATENADATAKB) = csDataRow(ABAtenaRirekiEntity.ATENADATAKB);

                    // ˆ¶–¼ƒf[ƒ^Ží•Ê
                    csDataNewRow(ABAtena1Entity.ATENADATASHU) = csDataRow(ABAtenaRirekiEntity.ATENADATASHU);

                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                    {
                        // •ÒWŽí•Ê
                        m_cABJuminShubetsuB.GetJuminshubetsu(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.ATENADATAKB)), Conversions.ToString(csDataRow(ABAtenaRirekiEntity.ATENADATASHU)));
                        csDataNewRow(ABAtena1Entity.HENSHUSHUBETSU) = m_cABJuminShubetsuB.p_strHenshuShubetsu;

                        // •ÒWŽí•Ê—ªÌ
                        csDataNewRow(ABAtena1Entity.HENSHUSHUBETSURYAKU) = m_cABJuminShubetsuB.p_strHenshuShubetsuRyaku;

                        // ŒŸõ—pƒJƒi©–¼
                        csDataNewRow(ABAtena1Entity.SEARCHKANASEIMEI) = csDataRow(ABAtenaRirekiEntity.SEARCHKANASEIMEI);

                        // ŒŸõ—pƒJƒi©
                        csDataNewRow(ABAtena1Entity.SEARCHKANASEI) = csDataRow(ABAtenaRirekiEntity.SEARCHKANASEI);
                        // ŒŸõ—pƒJƒi–¼

                        csDataNewRow(ABAtena1Entity.SEARCHKANAMEI) = csDataRow(ABAtenaRirekiEntity.SEARCHKANAMEI);

                        // ŒŸõ—pŠ¿Žš–¼Ì
                        csDataNewRow(ABAtena1Entity.SEARCHKANJIMEI) = csDataRow(ABAtenaRirekiEntity.SEARCHKANJIMEISHO);
                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                    // *—š—ð”Ô† 000042 2011/05/18 ’Ç‰ÁŠJŽn
                    // –{–¼’ÊÌ–¼Ø‘Ö‘Î‰ž - ƒJƒi–¼ÌAŠ¿Žš–¼ÌŽæ“¾
                    switch (Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATAKB)) ?? "")
                    {
                        case "11":
                        case "12":         // Z“o“àAZ“oŠO
                            {

                                if (m_strHonmyoTsushomeiYusenKB.Trim() == "1")
                                {
                                    // ŠÇ—î•ñF–{–¼’ÊÌ–¼—Dæ§Œä = "1" ‚Ìê‡
                                    strMeisho = MeishoHenshu(csDataRow);
                                }
                                else
                                {
                                    strMeisho[0] = Conversions.ToString(csDataRow(ABAtenaEntity.KANAMEISHO1));       // ƒJƒi–¼Ì‚P
                                    strMeisho[1] = Conversions.ToString(csDataRow(ABAtenaEntity.KANJIMEISHO1));
                                }      // 

                                break;
                            }
                        case "20":               // –@l
                            {
                                break;
                            }

                        case "30":               // ‹¤—L
                            {
                                strMeisho[0] = Conversions.ToString(csDataRow(ABAtenaEntity.KANAMEISHO1));
                                strMeisho[1] = Conversions.ToString(csDataRow(ABAtenaEntity.KANJIMEISHO1));
                                break;
                            }

                        default:
                            {
                                break;
                            }
                    }
                    // *—š—ð”Ô† 000042 2011/05/18 ’Ç‰ÁI—¹

                    // •ÒWƒJƒi–¼Ì
                    // ˆ¶–¼‹æ•ª="20"(–@l)‚Ìê‡
                    if (Conversions.ToString(csDataRow(ABAtenaRirekiEntity.ATENADATAKB)) == "20")
                    {
                        // * —š—ð”Ô† 000033 2007/07/17 C³ŠJŽn
                        // ƒJƒi–¼Ì‚QiŽx“X–¼j‚ª–³‚¢ê‡‚ÍƒJƒi–¼Ì‚Pi–@l–¼j‚ÆƒJƒi–¼Ì‚QiŽx“X–¼j‚ÌŒ‹‡‚Ís‚í‚È‚¢
                        if (new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KANAMEISHO2)).Trim ?? new char[0]) != "")
                        {
                            strHenshuKanaMeisho = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KANAMEISHO1)).TrimEnd + " " + Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KANAMEISHO2)).TrimEnd;
                        }
                        else
                        {
                            strHenshuKanaMeisho = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KANAMEISHO1)).TrimEnd;
                        }
                        // strHenshuKanaMeisho = CType(csDataRow(ABAtenaRirekiEntity.KANAMEISHO1), String).TrimEnd _
                        // + " " + CType(csDataRow(ABAtenaRirekiEntity.KANAMEISHO2), String).TrimEnd
                        // * —š—ð”Ô† 000033 2007/07/17 C³I—¹
                        // * —š—ð”Ô† 000032 2007/07/09 C³ŠJŽn
                        if (strHenshuKanaMeisho.RLength > 240)
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUKANASHIMEI) = strHenshuKanaMeisho.RSubstring(0, 240);
                        }
                        // If (strHenshuKanaMeisho.Length > 60) Then
                        // csDataNewRow(ABAtena1Entity.HENSHUKANASHIMEI) = strHenshuKanaMeisho.Substring(0, 60)
                        // * —š—ð”Ô† 000032 2007/07/09 C³I—¹
                        else
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUKANASHIMEI) = strHenshuKanaMeisho;
                        }
                    }
                    else
                    {
                        // *—š—ð”Ô† 000042 2011/05/18 C³ŠJŽn
                        strHenshuKanaMeisho = strMeisho[0];
                        csDataNewRow(ABAtena1Entity.HENSHUKANASHIMEI) = ABStrXClass.Left(strHenshuKanaMeisho, ABAtenaGetConstClass.KETA_HENSHUKANAMEISHO);
                        // csDataNewRow(ABAtena1Entity.HENSHUKANASHIMEI) = csDataRow(ABAtenaRirekiEntity.KANAMEISHO1)
                        // *—š—ð”Ô† 000042 2011/05/18 C³I—¹
                    }
                    // •ÒWƒJƒi–¼Ìiƒtƒ‹j
                    if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                    {
                        csDataNewRow(ABAtena1HyojunEntity.HENSHUKANASHIMEI_FULL) = strHenshuKanaMeisho;
                    }
                    else
                    {
                    }

                    // •ÒWŠ¿Žš–¼Ì
                    // ˆ¶–¼‹æ•ª="20"(–@l)‚Ìê‡
                    if (Conversions.ToString(csDataRow(ABAtenaRirekiEntity.ATENADATAKB)) == "20")
                    {
                        m_cABHojinMeishoB.p_strKeitaiFuyoKB = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.HANYOKB1));
                        m_cABHojinMeishoB.p_strKeitaiSeiRyakuKB = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.HANYOKB2));
                        m_cABHojinMeishoB.p_strKanjiHjnKeitai = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KANJIHJNKEITAI));
                        m_cABHojinMeishoB.p_strKanjiMeisho1 = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KANJIMEISHO1));
                        m_cABHojinMeishoB.p_strKanjiMeisho2 = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KANJIMEISHO2));
                        strHenshuKanjiShimei = m_cABHojinMeishoB.GetHojinMeisho();
                        // * —š—ð”Ô† 000032 2007/076/09 C³ŠJŽn
                        if (strHenshuKanjiShimei.RLength > 240)
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = strHenshuKanjiShimei.RSubstring(0, 240);
                        }
                        // If (strHenshuKanjiShimei.Length > 80) Then
                        // csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = strHenshuKanjiShimei.Substring(0, 80)
                        // * —š—ð”Ô† 000032 2007/07/09 C³I—¹
                        else
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = strHenshuKanjiShimei;
                        }
                    }
                    // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                    // csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = csDataRow(ABAtenaRirekiEntity.KANJIMEISHO1)
                    else if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                    {
                        // *—š—ð”Ô† 000042 2011/05/18 C³ŠJŽn
                        // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                        strHenshuKanjiShimei = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.ATENADATAKB)), Conversions.ToString(csDataRow(ABAtenaRirekiEntity.ATENADATASHU)), strMeisho[1]);
                        csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = ABStrXClass.Left(strHenshuKanjiShimei, ABAtenaGetConstClass.KETA_HENSHUKANJIMEISHO);
                    }
                    // csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = m_cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataRow(ABAtenaRirekiEntity.ATENADATAKB)), _
                    // CStr(csDataRow(ABAtenaRirekiEntity.ATENADATASHU)), _
                    // CStr(csDataRow(ABAtenaRirekiEntity.KANJIMEISHO1)))
                    // *—š—ð”Ô† 000042 2011/05/18 C³I—¹
                    else
                    {
                        // *—š—ð”Ô† 000042 2011/05/18 C³ŠJŽn
                        // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                        strHenshuKanjiShimei = strMeisho[1];
                        csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = ABStrXClass.Left(strHenshuKanjiShimei, ABAtenaGetConstClass.KETA_HENSHUKANJIMEISHO);
                        // csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = csDataRow(ABAtenaRirekiEntity.KANJIMEISHO1)
                        // *—š—ð”Ô† 000042 2011/05/18 C³I—¹
                        // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹
                    }
                    // •ÒWŠ¿Žš–¼Ìiƒtƒ‹j
                    if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                    {
                        csDataNewRow(ABAtena1HyojunEntity.HENSHUKANJISHIMEI_FULL) = strHenshuKanjiShimei;
                    }
                    else
                    {
                    }

                    if (csDataRow(ABAtenaRirekiEntity.ATENADATAKB).ToString == ABConstClass.ATENADATAKB_JUTONAI_KOJIN || csDataRow(ABAtenaRirekiEntity.ATENADATAKB).ToString == ABConstClass.ATENADATAKB_JUTOGAI_KOJIN)
                    {
                        if (csDataRow(ABAtenaRirekiEntity.UMAREYMD).ToString.Trim == string.Empty)
                        {
                            csDataNewRow(ABAtena1Entity.UMAREYMD) = m_strUmareYMDHenkanParam;
                            csDataNewRow(ABAtena1Entity.UMAREWMD) = m_strUmareWmdHenkan;
                        }
                        else if (CheckDate(csDataRow(ABAtenaRirekiEntity.UMAREYMD).ToString))
                        {
                            csDataNewRow(ABAtena1Entity.UMAREYMD) = csDataRow(ABAtenaRirekiEntity.UMAREYMD);
                            csDataNewRow(ABAtena1Entity.UMAREWMD) = csDataRow(ABAtenaRirekiEntity.UMAREWMD);
                        }
                        else
                        {
                            csDataNewRow(ABAtena1Entity.UMAREYMD) = GetSeirekiLastDay(csDataRow(ABAtenaRirekiEntity.UMAREYMD).ToString);
                            csDataNewRow(ABAtena1Entity.UMAREWMD) = GetWarekiLastDay(csDataRow(ABAtenaRirekiEntity.UMAREWMD).ToString, csDataRow(ABAtenaRirekiEntity.UMAREYMD).ToString);
                        }
                    }
                    else
                    {
                        // ¶”NŒŽ“ú
                        csDataNewRow(ABAtena1Entity.UMAREYMD) = csDataRow(ABAtenaRirekiEntity.UMAREYMD);

                        // ¶˜a—ï”NŒŽ“ú
                        csDataNewRow(ABAtena1Entity.UMAREWMD) = csDataRow(ABAtenaRirekiEntity.UMAREWMD);
                    }
                    // ¶”NŒŽ“ú•ÒW
                    // csDataNewRow(ABAtena1Entity.UMAREWMD) = csDataRow(ABAtenaRirekiEntity.UMAREWMD)

                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                    {
                        m_cABUmareHenshuB.p_strDataKB = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.ATENADATAKB));
                        m_cABUmareHenshuB.p_strJuminSHU = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.ATENADATASHU));
                        m_cABUmareHenshuB.p_strUmareYMD = Conversions.ToString(csDataNewRow(ABAtena1Entity.UMAREYMD));
                        m_cABUmareHenshuB.p_strUmareWMD = Conversions.ToString(csDataNewRow(ABAtena1Entity.UMAREWMD));
                        m_cABUmareHenshuB.HenshuUmare();
                        // ¶•\Ž¦”NŒŽ“ú
                        csDataNewRow(ABAtena1Entity.UMAREHYOJIWMD) = m_cABUmareHenshuB.p_strHyojiUmareYMD;

                        // ¶Ø–¾”NŒŽ“ú
                        csDataNewRow(ABAtena1Entity.UMARESHOMEIWMD) = m_cABUmareHenshuB.p_strShomeiUmareYMD;

                        // «•ÊƒR[ƒh
                        csDataNewRow(ABAtena1Entity.SEIBETSUCD) = csDataRow(ABAtenaRirekiEntity.SEIBETSUCD);

                        // «•Ê
                        strWork = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.SEIBETSU)).Trim;
                        csDataNewRow(ABAtena1Entity.SEIBETSU) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_SEIBETSU);
                        // «•Êiƒtƒ‹j
                        if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                        {
                            csDataNewRow(ABAtena1HyojunEntity.SEIBETSU_FULL) = csDataRow(ABAtenaRirekiEntity.SEIBETSU);
                        }
                        else
                        {
                        }

                        // •ÒW‘±•¿ƒR[ƒh
                        // *—š—ð”Ô† 000002 2003/02/20 C³ŠJŽn
                        // If CType(ABAtenaRirekiEntity.DAI2ZOKUGARACD, String) = String.Empty Then
                        // *—š—ð”Ô† 000018 2003/10/14 C³ŠJŽn
                        // If CType(ABAtenaRirekiEntity.DAI2ZOKUGARACD, String).Trim = String.Empty Then
                        if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.DAI2ZOKUGARACD)).Trim ?? new char[0]) == "")
                        {
                            // *—š—ð”Ô† 000018 2003/10/14 C³I—¹
                            // *—š—ð”Ô† 000002 2003/02/20 C³I—¹
                            csDataNewRow(ABAtena1Entity.HENSHUZOKUGARACD) = csDataRow(ABAtenaRirekiEntity.ZOKUGARACD);
                        }
                        else
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUZOKUGARACD) = csDataRow(ABAtenaRirekiEntity.DAI2ZOKUGARACD);
                        }

                        // •ÒW‘±•¿
                        // *—š—ð”Ô† 000002 2003/02/20 C³ŠJŽn
                        // If CType(ABAtenaRirekiEntity.DAI2ZOKUGARA, String) = String.Empty Then
                        // *—š—ð”Ô† 000018 2003/10/14 C³ŠJŽn
                        // If CType(ABAtenaRirekiEntity.DAI2ZOKUGARA, String).Trim = String.Empty Then
                        if (new string(Conversions.ToString(csDataRow(ABAtenaEntity.DAI2ZOKUGARA)).Trim ?? new char[0]) == "")
                        {
                            // *—š—ð”Ô† 000018 2003/10/14 C³I—¹
                            // *—š—ð”Ô† 000002 2003/02/20 C³I—¹
                            csDataNewRow(ABAtena1Entity.HENSHUZOKUGARA) = csDataRow(ABAtenaRirekiEntity.ZOKUGARA);
                        }
                        else
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUZOKUGARA) = csDataRow(ABAtenaRirekiEntity.DAI2ZOKUGARA);
                        }

                        // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                        // –@l‘ã•\ŽÒ–¼
                        // csDataNewRow(ABAtena1Entity.HOJINDAIHYOUSHA) = csDataRow(ABAtenaRirekiEntity.KANJIHJNDAIHYOSHSHIMEI)
                        if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                        {
                            // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                            csDataNewRow(ABAtena1Entity.HOJINDAIHYOUSHA) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.ATENADATAKB)), Conversions.ToString(csDataRow(ABAtenaRirekiEntity.ATENADATASHU)), Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KANJIHJNDAIHYOSHSHIMEI)));
                        }
                        else
                        {
                            // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                            csDataNewRow(ABAtena1Entity.HOJINDAIHYOUSHA) = csDataRow(ABAtenaEntity.KANJIHJNDAIHYOSHSHIMEI);
                        }
                        // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹
                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    // ŒÂl–@l‹æ•ª
                    csDataNewRow(ABAtena1Entity.KJNHJNKB) = csDataRow(ABAtenaRirekiEntity.KJNHJNKB);

                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                    {

                        // ŒÂl–@l‹æ•ª–¼Ì
                        csDataNewRow(ABAtena1Entity.KJNHJNKBMEISHO) = m_cABKjnhjnKBB.GetKjnhjn(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KJNHJNKB)));

                        // ŠÇ“àŠÇŠO‹æ•ª–¼Ì
                        csDataNewRow(ABAtena1Entity.NAIGAIKBMEISHO) = m_cABKannaiKangaiKBB.GetKannaiKangai(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KANNAIKANGAIKB)));
                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                    // ŠÇ“àŠÇŠO‹æ•ª
                    csDataNewRow(ABAtena1Entity.KANNAIKANGAIKB) = csDataRow(ABAtenaRirekiEntity.KANNAIKANGAIKB);

                    // ZŠî—Dæ‚Ìê‡
                    if (cAtenaGetPara1.p_strJukiJutogaiKB == "1")
                    {

                        // —X•Ö”Ô†
                        csDataNewRow(ABAtena1Entity.YUBINNO) = csDataRow(ABAtenaRirekiEntity.JUKIYUBINNO);

                        // ZŠƒR[ƒh
                        csDataNewRow(ABAtena1Entity.JUSHOCD) = csDataRow(ABAtenaRirekiEntity.JUKIJUSHOCD);

                        // ZŠ
                        csDataNewRow(ABAtena1Entity.JUSHO) = csDataRow(ABAtenaRirekiEntity.JUKIJUSHO);

                        // •ÒWZŠ–¼
                        if (cAtenaGetPara1.p_strJushoHenshu1 == string.Empty)
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = string.Empty;
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •ÒWZŠ–¼iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.HENSHUJUSHO_FULL) = string.Empty;
                            }
                            else
                            {
                            }
                        }

                        else if (cAtenaGetPara1.p_strJushoHenshu1 == "1")
                        {
                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                            // strHenshuJusho = String.Empty
                            m_strHenshuJusho.RRemove(0, m_strHenshuJusho.RLength);
                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                            if (cAtenaGetPara1.p_strJushoHenshu2 == "1")
                            {

                                // Žs’¬‘º–¼‚ð“ª‚É•t‰Á‚·‚éiŠÇ“à‚Ì‚Ýj
                                if (Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KANNAIKANGAIKB)) == "1")
                                {
                                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                    // strHenshuJusho += m_cuUSSCityInfo.p_strShichosonmei(0)
                                    m_strHenshuJusho.Append(m_cuUSSCityInfo.p_strShichosonmei(0));
                                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                }
                            }
                            // *—š—ð”Ô† 000008 2003/03/17 C³ŠJŽn
                            // Select Case cAtenaGetPara1.p_strJushoHenshu3
                            switch (strJushoHenshu3 ?? "")
                            {
                                // *—š—ð”Ô† 000008 2003/03/17 C³I—¹
                                // * —š—ð”Ô† 000028 2007/01/15 C³ŠJŽn
                                case "1":
                                case "6":   // ZŠ{”Ô’n
                                    {
                                        // Case "1"    'ZŠ{”Ô’n
                                        // * —š—ð”Ô† 000028 2007/01/15 C³I—¹
                                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                        // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI), String).TrimEnd
                                        m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO)).TrimEnd);
                                        m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI)).TrimEnd);
                                        break;
                                    }
                                // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                case "2":    // s­‹æ{”Ô’n
                                    {
                                        // *—š—ð”Ô† 000009 2003/03/17 C³ŠJŽn
                                        // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI), String).TrimEnd

                                        // s­‹æ–¼‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // ZŠ{”Ô’n
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        else
                                        {
                                            // s­‹æ{”Ô’n
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI)).TrimEnd);
                                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        }

                                        break;
                                    }
                                // *—š—ð”Ô† 000009 2003/03/17 C³I—¹
                                case "3":    // ZŠ{is­‹æj{”Ô’n
                                    {
                                        // *—š—ð”Ô† 000004  2003/02/25 C³ŠJŽn
                                        // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI), String).TrimEnd

                                        // s­‹æ–¼‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        else
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO), String).TrimEnd _
                                            // + "i" _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI), String).TrimEnd _
                                            // + "j" _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append("i");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append("j");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI)).TrimEnd);
                                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        }

                                        break;
                                    }
                                // *—š—ð”Ô† 000004 2003/02/25 C³I—¹
                                case "4":    // s­‹æ{iZŠj{”Ô’n
                                    {
                                        // *—š—ð”Ô† 000004 2003/02/25 C³ŠJŽn 
                                        // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI), String).TrimEnd

                                        // ZŠ‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁŠJŽn
                                        // s­‹æ–¼‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        else if (new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁI—¹
                                        else
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI), String).TrimEnd _
                                            // + "i" _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO), String).TrimEnd _
                                            // + "j" _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append("i");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append("j");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI)).TrimEnd);
                                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj

                                        }

                                        break;
                                    }
                                // *—š—ð”Ô† 000004 2003/02/25 C³I—¹
                                // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁŠJŽn
                                case "5":    // s­‹æ{¢{”Ô’n
                                    {
                                        // s­‹æ–¼‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // ZŠ{”Ô’n
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIJUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        else
                                        {
                                            // s­‹æ{¢{”Ô’n
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI), String).TrimEnd _
                                            // + "@" _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append("@");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIBANCHI)).TrimEnd);
                                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        }

                                        break;
                                    }
                                    // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁI—¹
                            }

                            // *—š—ð”Ô† 000008 2003/03/17 C³ŠJŽn
                            // If cAtenaGetPara1.p_strJushoHenshu4 = "1" Then
                            // * —š—ð”Ô† 000028 2007/01/15 C³ŠJŽn
                            if (strJushoHenshu4 == "1" && new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIKATAGAKI)).Trim ?? new char[0]) != "")
                            {
                                // If strJushoHenshu4 = "1" Then
                                // * —š—ð”Ô† 000028 2007/01/15 C³I—¹
                                // *—š—ð”Ô† 000008 2003/03/17 C³I—¹
                                // *—š—ð”Ô† 000004 2003/02/25 C³ŠJŽn
                                // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUKIKATAGAKI), String).TrimEnd

                                // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                // strHenshuJusho += "@" + CType(csDataRow(ABAtenaRirekiEntity.JUKIKATAGAKI), String).TrimEnd
                                m_strHenshuJusho.Append("@");
                                m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIKATAGAKI)).TrimEnd);
                                // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                // *—š—ð”Ô† 000004 2003/02/25 C³I—¹
                            }
                            // * —š—ð”Ô† 000028 2007/01/15 ’Ç‰ÁŠJŽn
                            // ZŠ•ÒW‚Rƒpƒ‰ƒ[ƒ^‚ª‚UAŠŽ‚Âs­‹æ–¼‚ª‚ ‚é‚Æ‚«‚ÍA•ÒWZŠ‚Éis­‹æj‚ð’Ç‰Á‚·‚é
                            if (strJushoHenshu3 == "6" && new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI)).Trim ?? new char[0]) != "")
                            {
                                m_strHenshuJusho.Append("i");
                                m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI)).TrimEnd);
                                m_strHenshuJusho.Append("j");
                            }
                            // * —š—ð”Ô† 000028 2007/01/15 ’Ç‰ÁI—¹
                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                            // If strHenshuJusho.Length >= 80 Then
                            // csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = strHenshuJusho.Substring(0, 80)
                            // Else
                            // csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = strHenshuJusho
                            // End If
                            // * —š—ð”Ô† 000032 2007/07/09 C³ŠJŽn
                            if (m_strHenshuJusho.RLength >= 160)
                            {
                                csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = m_strHenshuJusho.ToString().RSubstring(0, 160);
                            }
                            // If m_strHenshuJusho.Length >= 80 Then
                            // csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = m_strHenshuJusho.ToString().Substring(0, 80)
                            // * —š—ð”Ô† 000032 2007/07/09 C³I—¹
                            else
                            {
                                csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = m_strHenshuJusho.ToString();
                            }
                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •ÒWZŠ–¼iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.HENSHUJUSHO_FULL) = m_strHenshuJusho.ToString();
                            }
                            else
                            {
                            }
                        }

                        // ”Ô’nƒR[ƒh‚P
                        csDataNewRow(ABAtena1Entity.BANCHICD1) = csDataRow(ABAtenaRirekiEntity.JUKIBANCHICD1);

                        // ”Ô’nƒR[ƒh‚Q
                        csDataNewRow(ABAtena1Entity.BANCHICD2) = csDataRow(ABAtenaRirekiEntity.JUKIBANCHICD2);

                        // ”Ô’nƒR[ƒh‚R
                        csDataNewRow(ABAtena1Entity.BANCHICD3) = csDataRow(ABAtenaRirekiEntity.JUKIBANCHICD3);
                        // ”Ô’n
                        if (cAtenaGetPara1.p_strJushoHenshu1 == "1")
                        {
                            // ZŠ•ÒW‚ ‚è‚Ìê‡‚ÍANull
                            csDataNewRow(ABAtena1Entity.BANCHI) = "";
                        }
                        else
                        {
                            csDataNewRow(ABAtena1Entity.BANCHI) = csDataRow(ABAtenaRirekiEntity.JUKIBANCHI);
                        }

                        // •û‘ƒtƒ‰ƒO
                        csDataNewRow(ABAtena1Entity.KATAGAKIFG) = csDataRow(ABAtenaRirekiEntity.JUKIKATAGAKIFG);

                        // •û‘ƒR[ƒh
                        csDataNewRow(ABAtena1Entity.KATAGAKICD) = csDataRow(ABAtenaRirekiEntity.JUKIKATAGAKICD);

                        // •û‘
                        if (cAtenaGetPara1.p_strJushoHenshu1 == "1" & cAtenaGetPara1.p_strJushoHenshu4 == "1")
                        {
                            // •û‘•t‰Á‚ ‚è‚Ìê‡‚ÍANull
                            csDataNewRow(ABAtena1Entity.KATAGAKI) = string.Empty;
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •û‘iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.KATAGAKI_FULL) = string.Empty;
                            }
                            else
                            {
                            }
                        }
                        else
                        {
                            strWork = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIKATAGAKI)).Trim;
                            csDataNewRow(ABAtena1Entity.KATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •û‘iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.KATAGAKI_FULL) = csDataRow(ABAtenaRirekiEntity.JUKIKATAGAKI);
                            }
                            else
                            {
                            }
                        }

                        // *—š—ð”Ô† 000017 2003/10/09 C³ŠJŽn
                        // '˜A—æ‚P
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csDataRow(ABAtenaRirekiEntity.RENRAKUSAKI1)
                        // '˜A—æ‚Q
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csDataRow(ABAtenaRirekiEntity.RENRAKUSAKI2)

                        // *—š—ð”Ô† 000021 2003/12/02 C³ŠJŽn
                        // ' ˜A—æƒ}ƒXƒ^‚ª‘¶Ý‚·‚éê‡‚ÍA˜A—æƒ}ƒXƒ^‚Ì˜A—æ‚ðÝ’è‚·‚é
                        // If (csRenrakusakiRow Is Nothing) Then
                        // '˜A—æ‚P
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csDataRow(ABAtenaRirekiEntity.RENRAKUSAKI1)
                        // '˜A—æ‚Q
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csDataRow(ABAtenaRirekiEntity.RENRAKUSAKI2)
                        // '*—š—ð”Ô† 000020 2003/12/01 ’Ç‰ÁŠJŽn
                        // '˜A—æŽæ“¾‹Æ–±ƒR[ƒh
                        // strRenrakusakiGyomuCD = String.Empty
                        // '*—š—ð”Ô† 000020 2003/12/01 ’Ç‰ÁI—¹
                        // Else
                        // '˜A—æ‚P
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKI1)
                        // '˜A—æ‚Q
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKI2)
                        // '*—š—ð”Ô† 000020 2003/12/01 C³ŠJŽn
                        // ''˜A—æŽæ“¾‹Æ–±ƒR[ƒh
                        // 'csDataNewRow(ABAtena1Entity.RENRAKUSAKI_GYOMUCD) = strGyomuCD

                        // '˜A—æŽæ“¾‹Æ–±ƒR[ƒh
                        // strRenrakusakiGyomuCD = strGyomuCD
                        // '*—š—ð”Ô† 000020 2003/12/01 C³I—¹
                        // End If
                        // '*—š—ð”Ô† 000017 2003/10/09 C³I—¹

                        // ˜A—æ‚P
                        csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csDataRow(ABAtenaRirekiEntity.RENRAKUSAKI1);
                        // ˜A—æ‚Q
                        csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csDataRow(ABAtenaRirekiEntity.RENRAKUSAKI2);
                        // *—š—ð”Ô† 000021 2003/12/02 C³I—¹

                        // s­‹æƒR[ƒh
                        csDataNewRow(ABAtena1Entity.GYOSEIKUCD) = csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUCD);

                        // s­‹æ–¼
                        csDataNewRow(ABAtena1Entity.GYOSEIKUMEI) = csDataRow(ABAtenaRirekiEntity.JUKIGYOSEIKUMEI);

                        // ’n‹æƒR[ƒh‚P
                        csDataNewRow(ABAtena1Entity.CHIKUCD1) = csDataRow(ABAtenaRirekiEntity.JUKICHIKUCD1);

                        // ’n‹æ‚P
                        csDataNewRow(ABAtena1Entity.CHIKUMEI1) = csDataRow(ABAtenaRirekiEntity.JUKICHIKUMEI1);

                        // ’n‹æƒR[ƒh‚Q
                        csDataNewRow(ABAtena1Entity.CHIKUCD2) = csDataRow(ABAtenaRirekiEntity.JUKICHIKUCD2);

                        // ’n‹æ‚Q
                        csDataNewRow(ABAtena1Entity.CHIKUMEI2) = csDataRow(ABAtenaRirekiEntity.JUKICHIKUMEI2);

                        // ’n‹æƒR[ƒh‚R
                        csDataNewRow(ABAtena1Entity.CHIKUCD3) = csDataRow(ABAtenaRirekiEntity.JUKICHIKUCD3);

                        // ’n‹æ‚R
                        csDataNewRow(ABAtena1Entity.CHIKUMEI3) = csDataRow(ABAtenaRirekiEntity.JUKICHIKUMEI3);

                        // •\Ž¦‡i‘æ‚QZ–¯•[•\Ž¦‡‚ª‚ ‚éê‡‚ÍA‘æ‚QZ–¯•[•\Ž¦‡j
                        // *—š—ð”Ô† 000002 2003/02/20 C³ŠJŽn
                        // If CType(csDataRow(ABAtenaRirekiEntity.DAI2JUMINHYOHYOJIJUN), String) = String.Empty Then
                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                        if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                        {
                            if (Conversions.ToString(csDataRow(ABAtenaRirekiEntity.DAI2JUMINHYOHYOJIJUN)).Trim == "00")
                            {
                                // *—š—ð”Ô† 000002 2003/02/20 C³I—¹
                                csDataNewRow(ABAtena1Entity.HYOJIJUN) = csDataRow(ABAtenaRirekiEntity.JUMINHYOHYOJIJUN);
                            }
                            else
                            {
                                csDataNewRow(ABAtena1Entity.HYOJIJUN) = csDataRow(ABAtenaRirekiEntity.DAI2JUMINHYOHYOJIJUN);
                            }
                        }
                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    else
                    {
                        // —X•Ö”Ô†
                        csDataNewRow(ABAtena1Entity.YUBINNO) = csDataRow(ABAtenaRirekiEntity.YUBINNO);
                        // ZŠƒR[ƒh
                        csDataNewRow(ABAtena1Entity.JUSHOCD) = csDataRow(ABAtenaRirekiEntity.JUSHOCD);
                        // ZŠ
                        csDataNewRow(ABAtena1Entity.JUSHO) = csDataRow(ABAtenaRirekiEntity.JUSHO);

                        // •ÒWZŠ–¼
                        if (cAtenaGetPara1.p_strJushoHenshu1 == string.Empty)
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = string.Empty;
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •ÒWZŠ–¼iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.HENSHUJUSHO_FULL) = string.Empty;
                            }
                            else
                            {
                            }
                        }

                        else if (cAtenaGetPara1.p_strJushoHenshu1 == "1")
                        {
                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                            // strHenshuJusho = String.Empty
                            m_strHenshuJusho.RRemove(0, m_strHenshuJusho.RLength);
                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                            if (cAtenaGetPara1.p_strJushoHenshu2 == "1")
                            {

                                // ŠÇ“à‚Ì‚ÝŽs’¬‘º–¼‚ð•t‰Á‚·‚é
                                if (Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KANNAIKANGAIKB)) == "1")
                                {
                                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                    // strHenshuJusho += m_cuUSSCityInfo.p_strShichosonmei(0)
                                    m_strHenshuJusho.Append(m_cuUSSCityInfo.p_strShichosonmei(0));
                                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                }
                            }
                            // *—š—ð”Ô† 000008 2003/03/17 C³ŠJŽn
                            // Select Case cAtenaGetPara1.p_strJushoHenshu3
                            switch (strJushoHenshu3 ?? "")
                            {
                                // *—š—ð”Ô† 000008 2003/03/17 C³I—¹
                                // * —š—ð”Ô† 000028 2007/01/15 C³ŠJŽn
                                case "1":
                                case "6":   // ZŠ{”Ô’n
                                    {
                                        // Case "1"    'ZŠ{”Ô’n
                                        // * —š—ð”Ô† 000028 2007/01/15 C³I—¹
                                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                        // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUSHO), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaRirekiEntity.BANCHI), String).TrimEnd
                                        m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUSHO)).TrimEnd);
                                        m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.BANCHI)).TrimEnd);
                                        break;
                                    }
                                // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                case "2":    // s­‹æ{”Ô’n
                                    {
                                        // *—š—ð”Ô† 000009 2003/03/17 C³ŠJŽn
                                        // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaRirekiEntity.BANCHI), String).TrimEnd
                                        // s­‹æ–¼‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUSHO), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.BANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        else
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.BANCHI)).TrimEnd);
                                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        }

                                        break;
                                    }
                                // *—š—ð”Ô† 000009 2003/03/17 C³I—¹
                                case "3":    // ZŠ{is­‹æj{”Ô’n
                                    {
                                        // *—š—ð”Ô† 000004  2003/02/25 C³ŠJŽn
                                        // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUSHO), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaRirekiEntity.BANCHI), String).TrimEnd

                                        // s­‹æ–¼‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUSHO), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.BANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        else
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUSHO), String).TrimEnd _
                                            // + "i" _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI), String).TrimEnd _
                                            // + "j" _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append("i");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append("j");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.BANCHI)).TrimEnd);
                                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        }

                                        break;
                                    }
                                // *—š—ð”Ô† 000004  2003/02/25 C³I—¹
                                case "4":    // s­‹æ{iZŠj{”Ô’n
                                    {
                                        // *—š—ð”Ô† 000004  2003/02/25 C³ŠJŽn
                                        // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaRirekiEntity.JUSHO), String).TrimEnd _
                                        // + CType(csDataRow(ABAtenaRirekiEntity.BANCHI), String).TrimEnd

                                        // ZŠ‚ª‘¶Ý‚µ‚È‚¢ê‡As­‹æ{”Ô’n
                                        if (new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUSHO)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.BANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁŠJŽn
                                        else if (new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // s­‹æ–¼‚ª‘¶Ý‚µ‚È‚¢ê‡AZŠ{”Ô’n
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUSHO), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.BANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁI—¹
                                        else
                                        {
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI), String).TrimEnd _
                                            // + "i" _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.JUSHO), String).TrimEnd _
                                            // + "j" _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI)).TrimEnd);
                                            m_strHenshuJusho.Append("i");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append("j");
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.BANCHI)).TrimEnd);
                                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        }

                                        break;
                                    }
                                // *—š—ð”Ô† 000004 2003/02/25 C³I—¹
                                // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁŠJŽn
                                case "5":    // s­‹æ{¢{”Ô’n
                                    {
                                        // s­‹æ–¼‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // ZŠ{”Ô’n
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.JUSHO), String).TrimEnd _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUSHO)).TrimEnd);
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.BANCHI)).TrimEnd);
                                        }
                                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        else
                                        {
                                            // s­‹æ{¢{”Ô’n
                                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                            // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI), String).TrimEnd _
                                            // + "@" _
                                            // + CType(csDataRow(ABAtenaRirekiEntity.BANCHI), String).TrimEnd
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI)).TrimEnd);
                                            // * —š—ð”Ô† 000028 2007/01/15 ’Ç‰ÁŠJŽn
                                            m_strHenshuJusho.Append("@");
                                            // * —š—ð”Ô† 000028 2007/01/15 ’Ç‰ÁI—¹
                                            m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.BANCHI)).TrimEnd);
                                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                        }

                                        break;
                                    }
                                    // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁI—¹
                            }
                            // *—š—ð”Ô† 000008 2003/03/17 C³ŠJŽn
                            // If cAtenaGetPara1.p_strJushoHenshu4 = "1" Then
                            // * —š—ð”Ô† 000028 2007/01/15 C³ŠJŽn
                            if (strJushoHenshu4 == "1" && new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KATAGAKI)).Trim ?? new char[0]) != "")
                            {
                                // If strJushoHenshu4 = "1" Then
                                // * —š—ð”Ô† 000028 2007/01/15 C³I—¹
                                // *—š—ð”Ô† 000008 2003/03/17 C³I—¹
                                // *—š—ð”Ô† 000004  2003/02/25 C³ŠJŽn
                                // strHenshuJusho += CType(csDataRow(ABAtenaRirekiEntity.KATAGAKI), String).TrimEnd

                                // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                // strHenshuJusho += "@" + CType(csDataRow(ABAtenaRirekiEntity.KATAGAKI), String).TrimEnd
                                m_strHenshuJusho.Append("@");
                                m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KATAGAKI)).TrimEnd);
                                // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                                // *—š—ð”Ô† 000004  2003/02/25 C³I—¹
                            }
                            // * —š—ð”Ô† 000028 2007/01/15 ’Ç‰ÁŠJŽn
                            // ZŠ•ÒW‚Rƒpƒ‰ƒ[ƒ^‚ª‚UAŠŽ‚Âs­‹æ–¼‚ª‚ ‚é‚Æ‚«‚ÍA•ÒWZŠ‚Éis­‹æj‚ð’Ç‰Á‚·‚é
                            if (strJushoHenshu3 == "6" && new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI)).Trim ?? new char[0]) != "")
                            {
                                m_strHenshuJusho.Append("i");
                                m_strHenshuJusho.Append(Conversions.ToString(csDataRow(ABAtenaEntity.GYOSEIKUMEI)).TrimEnd);
                                m_strHenshuJusho.Append("j");
                            }
                            // * —š—ð”Ô† 000028 2007/01/15 ’Ç‰ÁI—¹
                            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                            // If strHenshuJusho.Length >= 80 Then
                            // csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = strHenshuJusho.Substring(0, 80)
                            // Else
                            // csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = strHenshuJusho
                            // End If
                            // * —š—ð”Ô† 000032 2007/07/09 C³ŠJŽn
                            if (m_strHenshuJusho.RLength >= 160)
                            {
                                csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = m_strHenshuJusho.ToString().RSubstring(0, 160);
                            }
                            // If m_strHenshuJusho.Length >= 80 Then
                            // csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = m_strHenshuJusho.ToString().Substring(0, 80)
                            // * —š—ð”Ô† 000032 2007/07/09 C³I—¹
                            else
                            {
                                csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = m_strHenshuJusho.ToString();
                            }
                            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •ÒWZŠ–¼iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.HENSHUJUSHO_FULL) = m_strHenshuJusho.ToString();
                            }
                            else
                            {
                            }
                        }

                        // ”Ô’nƒR[ƒh‚P
                        csDataNewRow(ABAtena1Entity.BANCHICD1) = csDataRow(ABAtenaRirekiEntity.BANCHICD1);

                        // ”Ô’nƒR[ƒh‚Q
                        csDataNewRow(ABAtena1Entity.BANCHICD2) = csDataRow(ABAtenaRirekiEntity.BANCHICD2);

                        // ”Ô’nƒR[ƒh‚R
                        csDataNewRow(ABAtena1Entity.BANCHICD3) = csDataRow(ABAtenaRirekiEntity.BANCHICD3);

                        // ”Ô’n
                        if (cAtenaGetPara1.p_strJushoHenshu1 == "1")
                        {
                            // ZŠ•ÒW‚ ‚è‚Ìê‡‚ÍANull
                            csDataNewRow(ABAtena1Entity.BANCHI) = "";
                        }
                        else
                        {
                            csDataNewRow(ABAtena1Entity.BANCHI) = csDataRow(ABAtenaRirekiEntity.BANCHI);
                        }

                        // •û‘ƒtƒ‰ƒO
                        csDataNewRow(ABAtena1Entity.KATAGAKIFG) = csDataRow(ABAtenaRirekiEntity.KATAGAKIFG);

                        // •û‘ƒR[ƒh
                        csDataNewRow(ABAtena1Entity.KATAGAKICD) = csDataRow(ABAtenaRirekiEntity.KATAGAKICD);

                        // •û‘
                        if (cAtenaGetPara1.p_strJushoHenshu1 == "1" & cAtenaGetPara1.p_strJushoHenshu4 == "1")
                        {
                            // •û‘•t‰Á‚ ‚è‚Ìê‡‚ÍANull
                            csDataNewRow(ABAtena1Entity.KATAGAKI) = "";
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •û‘iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.KATAGAKI_FULL) = string.Empty;
                            }
                            else
                            {
                            }
                        }
                        else
                        {
                            strWork = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KATAGAKI)).Trim;
                            csDataNewRow(ABAtena1Entity.KATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •û‘iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.KATAGAKI_FULL) = csDataRow(ABAtenaRirekiEntity.KATAGAKI);
                            }
                            else
                            {
                            }
                        }

                        // *—š—ð”Ô† 000017 2003/10/09 C³ŠJŽn
                        // '˜A—æ‚P
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csDataRow(ABAtenaRirekiEntity.RENRAKUSAKI1)
                        // '˜A—æ‚Q
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csDataRow(ABAtenaRirekiEntity.RENRAKUSAKI2)

                        // *—š—ð”Ô† 000021 2003/12/02 C³ŠJŽn
                        // ' ˜A—æƒ}ƒXƒ^‚ª‘¶Ý‚·‚éê‡‚ÍA˜A—æƒ}ƒXƒ^‚Ì˜A—æ‚ðÝ’è‚·‚é
                        // If (csRenrakusakiRow Is Nothing) Then
                        // '˜A—æ‚P
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csDataRow(ABAtenaRirekiEntity.RENRAKUSAKI1)
                        // '˜A—æ‚Q
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csDataRow(ABAtenaRirekiEntity.RENRAKUSAKI2)
                        // '*—š—ð”Ô† 000020 2003/12/01 ’Ç‰ÁŠJŽn
                        // '˜A—æŽæ“¾‹Æ–±ƒR[ƒh
                        // strRenrakusakiGyomuCD = String.Empty
                        // '*—š—ð”Ô† 000020 2003/12/01 ’Ç‰ÁI—¹
                        // Else
                        // '˜A—æ‚P
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKI1)
                        // '˜A—æ‚Q
                        // csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKI2)
                        // '*—š—ð”Ô† 000020 2003/12/01 C³ŠJŽn
                        // ''˜A—æŽæ“¾‹Æ–±ƒR[ƒh
                        // 'csDataNewRow(ABAtena1Entity.RENRAKUSAKI_GYOMUCD) = strGyomuCD

                        // '˜A—æŽæ“¾‹Æ–±ƒR[ƒh
                        // strRenrakusakiGyomuCD = strGyomuCD
                        // '*—š—ð”Ô† 000020 2003/12/01 C³I—¹
                        // End If
                        // '*—š—ð”Ô† 000017 2003/10/09 C³I—¹

                        // ˜A—æ‚P
                        csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csDataRow(ABAtenaRirekiEntity.RENRAKUSAKI1);
                        // ˜A—æ‚Q
                        csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csDataRow(ABAtenaRirekiEntity.RENRAKUSAKI2);
                        // *—š—ð”Ô† 000021 2003/12/02 C³I—¹

                        // s­‹æƒR[ƒh
                        csDataNewRow(ABAtena1Entity.GYOSEIKUCD) = csDataRow(ABAtenaRirekiEntity.GYOSEIKUCD);

                        // s­‹æ–¼
                        csDataNewRow(ABAtena1Entity.GYOSEIKUMEI) = csDataRow(ABAtenaRirekiEntity.GYOSEIKUMEI);

                        // ’n‹æƒR[ƒh‚P
                        csDataNewRow(ABAtena1Entity.CHIKUCD1) = csDataRow(ABAtenaRirekiEntity.CHIKUCD1);

                        // ’n‹æ‚P
                        csDataNewRow(ABAtena1Entity.CHIKUMEI1) = csDataRow(ABAtenaRirekiEntity.CHIKUMEI1);

                        // ’n‹æƒR[ƒh‚Q
                        csDataNewRow(ABAtena1Entity.CHIKUCD2) = csDataRow(ABAtenaRirekiEntity.CHIKUCD2);

                        // ’n‹æ‚Q
                        csDataNewRow(ABAtena1Entity.CHIKUMEI2) = csDataRow(ABAtenaRirekiEntity.CHIKUMEI2);

                        // ’n‹æƒR[ƒh‚R
                        csDataNewRow(ABAtena1Entity.CHIKUCD3) = csDataRow(ABAtenaRirekiEntity.CHIKUCD3);

                        // ’n‹æ‚R
                        csDataNewRow(ABAtena1Entity.CHIKUMEI3) = csDataRow(ABAtenaRirekiEntity.CHIKUMEI3);

                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                        if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                        {
                            // * —š—ð”Ô† 000026 2005/12/21 C³ŠJŽn
                            // '•\Ž¦‡
                            // csDataNewRow(ABAtena1Entity.HYOJIJUN) = String.Empty

                            // •\Ž¦‡i‘æ‚QZ–¯•[•\Ž¦‡‚ª‚ ‚éê‡‚ÍA‘æ‚QZ–¯•[•\Ž¦‡j
                            if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                            {
                                strWork = Conversions.ToString(csDataRow(ABAtenaEntity.DAI2JUMINHYOHYOJIJUN)).Trim;
                                if (strWork == "00")
                                {
                                    strWork = csDataRow(ABAtenaEntity.JUMINHYOHYOJIJUN).ToString().Trim;
                                }
                                if (string.IsNullOrEmpty(strWork))
                                {
                                    strWork = "99";
                                }
                                csDataNewRow(ABAtena1Entity.HYOJIJUN) = strWork;
                            }
                            // * —š—ð”Ô† 000026 2005/12/21 C³I—¹
                        }
                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                    {

                        // “o˜^ˆÙ“®”NŒŽ“ú
                        csDataNewRow(ABAtena1Entity.TOROKUIDOYMD) = csDataRow(ABAtenaRirekiEntity.TOROKUIDOYMD);

                        // “o˜^Ž–—RƒR[ƒh
                        csDataNewRow(ABAtena1Entity.TOROKUJIYUCD) = csDataRow(ABAtenaRirekiEntity.TOROKUJIYUCD);

                        // “o˜^Ž–—R
                        csDataNewRow(ABAtena1Entity.TOROKUJIYU) = csDataRow(ABAtenaRirekiEntity.TOROKUJIYU);

                        if ((csDataRow(ABAtenaRirekiEntity.ATENADATAKB).ToString == ABConstClass.ATENADATAKB_JUTONAI_KOJIN || csDataRow(ABAtenaRirekiEntity.ATENADATAKB).ToString == ABConstClass.ATENADATAKB_JUTOGAI_KOJIN) && !(csDataRow(ABAtenaRirekiEntity.SHOJOJIYUCD).ToString.Trim == string.Empty))
                        {
                            if (csDataRow(ABAtenaRirekiEntity.SHOJOIDOYMD).ToString.Trim == string.Empty)
                            {
                                csDataNewRow(ABAtena1Entity.SHOJOIDOYMD) = m_strShojoIdobiHenkanParam;
                            }
                            else
                            {
                                csDataNewRow(ABAtena1Entity.SHOJOIDOYMD) = csDataRow(ABAtenaRirekiEntity.SHOJOIDOYMD);
                            }
                        }
                        else
                        {
                            // ÁœˆÙ“®”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.SHOJOIDOYMD) = csDataRow(ABAtenaRirekiEntity.SHOJOIDOYMD);
                        }
                        // ÁœŽ–—RƒR[ƒh
                        csDataNewRow(ABAtena1Entity.SHOJOJIYUCD) = csDataRow(ABAtenaRirekiEntity.SHOJOJIYUCD);

                        // ÁœŽ–—R–¼Ì
                        csDataNewRow(ABAtena1Entity.SHOJOJIYU) = csDataRow(ABAtenaRirekiEntity.SHOJOJIYU);

                        // •ÒW¢‘ÑŽåZ–¯ƒR[ƒh
                        // *—š—ð”Ô† 000002 2003/02/20 C³ŠJŽn
                        // If CType(csDataRow(ABAtenaRirekiEntity.DAI2STAINUSJUMINCD), String) = String.Empty Then
                        if (new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.DAI2STAINUSJUMINCD)).Trim ?? new char[0]) == "")
                        {
                            // *—š—ð”Ô† 000002 2003/02/20 C³I—¹
                            csDataNewRow(ABAtena1Entity.HENSHUNUSHIJUMINCD) = csDataRow(ABAtenaRirekiEntity.STAINUSJUMINCD);
                        }
                        else
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUNUSHIJUMINCD) = csDataRow(ABAtenaRirekiEntity.DAI2STAINUSJUMINCD);
                        }
                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    // •ÒWƒJƒi¢‘ÑŽå–¼
                    // *—š—ð”Ô† 000002 2003/02/20 C³ŠJŽn
                    // If CType(csDataRow(ABAtenaRirekiEntity.KANADAI2STAINUSMEI), String) = String.Empty Then
                    if (new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KANADAI2STAINUSMEI)).Trim ?? new char[0]) == "")
                    {
                        // *—š—ð”Ô† 000002 2003/02/20 C³I—¹
                        csDataNewRow(ABAtena1Entity.HENSHUKANANUSHIMEI) = csDataRow(ABAtenaRirekiEntity.KANASTAINUSMEI);
                    }
                    else
                    {
                        csDataNewRow(ABAtena1Entity.HENSHUKANANUSHIMEI) = csDataRow(ABAtenaRirekiEntity.KANADAI2STAINUSMEI);
                    }

                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                    {
                        // •ÒWŠ¿Žš¢‘ÑŽå–¼
                        // *—š—ð”Ô† 000002 2003/02/20 C³ŠJŽn
                        // If CType(csDataRow(ABAtenaRirekiEntity.DAI2STAINUSMEI), String) = String.Empty Then
                        if (new string(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.DAI2STAINUSMEI)).Trim ?? new char[0]) == "")
                        {
                            // *—š—ð”Ô† 000002 2003/02/20 C³I—¹
                            // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                            // csDataNewRow(ABAtena1Entity.HENSHUNUSHIMEI) = csDataRow(ABAtenaRirekiEntity.STAINUSMEI)
                            if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                                csDataNewRow(ABAtena1Entity.HENSHUNUSHIMEI) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.STAINUSMEI)));
                            }
                            else
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                                csDataNewRow(ABAtena1Entity.HENSHUNUSHIMEI) = csDataRow(ABAtenaRirekiEntity.STAINUSMEI);
                            }
                        }
                        // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹
                        // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                        // csDataNewRow(ABAtena1Entity.HENSHUNUSHIMEI) = csDataRow(ABAtenaRirekiEntity.DAI2STAINUSMEI)
                        else if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                        {
                            // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                            csDataNewRow(ABAtena1Entity.HENSHUNUSHIMEI) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.DAI2STAINUSMEI)));
                        }
                        else
                        {
                            // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                            csDataNewRow(ABAtena1Entity.HENSHUNUSHIMEI) = csDataRow(ABAtenaRirekiEntity.DAI2STAINUSMEI);
                            // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹
                        }

                        // *—š—ð”Ô† 000012 2003/04/18 ’Ç‰ÁŠJŽn
                        // ‘±•¿ƒR[ƒh
                        csDataNewRow(ABAtena1Entity.ZOKUGARACD) = csDataRow(ABAtenaRirekiEntity.ZOKUGARACD);
                        // ‘±•¿
                        csDataNewRow(ABAtena1Entity.ZOKUGARA) = csDataRow(ABAtenaRirekiEntity.ZOKUGARA);

                        // *—š—ð”Ô† 000014 2003/04/30 C³ŠJŽn
                        // ' ƒJƒi–¼Ì‚Q
                        // csDataNewRow(ABAtena1Entity.KANAMEISHO2) = csDataRow(ABAtenaRirekiEntity.KANAMEISHO2)
                        // ' Š¿Žš–¼Ì‚Q
                        // csDataNewRow(ABAtena1Entity.KANJIMEISHO2) = csDataRow(ABAtenaRirekiEntity.KANJIMEISHO2)

                        // ˆ¶–¼‹æ•ª‚"20"(–@l)‚Ìê‡
                        if (!(Conversions.ToString(csDataRow(ABAtenaEntity.ATENADATAKB)) == "20"))
                        {
                            // ƒJƒi–¼Ì‚Q
                            csDataNewRow(ABAtena1Entity.KANAMEISHO2) = csDataRow(ABAtenaRirekiEntity.KANAMEISHO2);
                            // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                            // Š¿Žš–¼Ì‚Q
                            // csDataNewRow(ABAtena1Entity.KANJIMEISHO2) = csDataRow(ABAtenaRirekiEntity.KANJIMEISHO2)
                            if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                                csDataNewRow(ABAtena1Entity.KANJIMEISHO2) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.ATENADATAKB)), Conversions.ToString(csDataRow(ABAtenaRirekiEntity.ATENADATASHU)), Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KANJIMEISHO2)));
                            }
                            else
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                                csDataNewRow(ABAtena1Entity.KANJIMEISHO2) = csDataRow(ABAtenaRirekiEntity.KANJIMEISHO2);
                            }
                            // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹
                        }
                        // *—š—ð”Ô† 000014 2003/04/30 C³I—¹

                        // Ð”Ô†
                        csDataNewRow(ABAtena1Entity.SEKINO) = csDataRow(ABAtenaRirekiEntity.SEKINO);
                        // *—š—ð”Ô† 000012 2003/04/18 ’Ç‰ÁI—¹
                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                    // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁŠJŽn
                    // –{Ð•M“ªŽÒî•ño—Í”»’è
                    if (m_strHonsekiHittoshKB_Param == "1" && m_strHonsekiHittoshKB == "1")
                    {
                        // ƒpƒ‰ƒ[ƒ^:–{Ð•M“ªŽÒŽæ“¾‹æ•ª‚ª"1"‚©‚ÂAŠÇ—î•ñ:–{ÐŽæ“¾‹æ•ª(10¥18)‚ª"1"‚Ìê‡‚Ì‚ÝƒZƒbƒg
                        // –{ÐZŠ
                        csDataNewRow(ABAtena1Entity.HON_JUSHO) = csDataRow(ABAtenaRirekiEntity.HON_JUSHO);
                        // –{Ð”Ô’n
                        csDataNewRow(ABAtena1Entity.HONSEKIBANCHI) = csDataRow(ABAtenaRirekiEntity.HONSEKIBANCHI);
                        // •M“ªŽÒ
                        csDataNewRow(ABAtena1Entity.HITTOSH) = csDataRow(ABAtenaRirekiEntity.HITTOSH);
                    }
                    else
                    {
                    }

                    // ˆ—’âŽ~‹æ•ªo—Í”»’è
                    if (m_strShoriteishiKB == "1" && m_strShoriteishiKB_Param == "1")
                    {
                        // ƒpƒ‰ƒ[ƒ^:ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ª‚ª"1"‚©‚ÂAŠÇ—î•ñ:ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ª(10¥19)‚ª"1"‚Ìê‡‚Ì‚ÝƒZƒbƒg
                        // ˆ—’âŽ~‹æ•ª
                        csDataNewRow(ABAtena1Entity.SHORITEISHIKB) = csDataRow(ABAtenaRirekiEntity.SHORITEISHIKB);
                    }
                    else
                    {
                    }
                    // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁI—¹

                    // *—š—ð”Ô† 000041 2011/05/18 ’Ç‰ÁŠJŽn
                    if (m_strFrnZairyuJohoKB_Param == "1")
                    {
                        // ƒpƒ‰ƒ[ƒ^FŠO‘lÝ—¯Ž‘ŠiŽæ“¾‹æ•ª‚ª"1"‚Ìê‡
                        // ‘Ð
                        strWork = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KOKUSEKI)).Trim;
                        csDataNewRow(ABAtena1Entity.KOKUSEKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KOKUSEKI);
                        // ‘Ðiƒtƒ‹j
                        if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                        {
                            csDataNewRow(ABAtena1HyojunEntity.KOKUSEKI_FULL) = csDataRow(ABAtenaRirekiEntity.KOKUSEKI);
                        }
                        else
                        {
                        }
                        // Ý—¯Ž‘ŠiƒR[ƒh
                        csDataNewRow(ABAtena1Entity.ZAIRYUSKAKCD) = csDataRow(ABAtenaRirekiEntity.ZAIRYUSKAKCD);
                        // Ý—¯Ž‘Ši
                        csDataNewRow(ABAtena1Entity.ZAIRYUSKAK) = csDataRow(ABAtenaRirekiEntity.ZAIRYUSKAK);
                        // Ý—¯ŠúŠÔ
                        csDataNewRow(ABAtena1Entity.ZAIRYUKIKAN) = csDataRow(ABAtenaRirekiEntity.ZAIRYUKIKAN);
                        // Ý—¯ŠJŽn”NŒŽ“ú
                        csDataNewRow(ABAtena1Entity.ZAIRYU_ST_YMD) = csDataRow(ABAtenaRirekiEntity.ZAIRYU_ST_YMD);
                        // Ý—¯I—¹”NŒŽ“ú
                        csDataNewRow(ABAtena1Entity.ZAIRYU_ED_YMD) = csDataRow(ABAtenaRirekiEntity.ZAIRYU_ED_YMD);
                    }
                    else
                    {
                    }
                    // *—š—ð”Ô† 000041 2011/05/18 ’Ç‰ÁI—¹

                    // *—š—ð”Ô† 000017 2003/10/09 C³ŠJŽn
                    // 'ƒŒƒR[ƒh‚Ì’Ç‰Á
                    // csAtena1.Tables(ABAtena1Entity.TABLE_NAME).Rows.Add(csDataNewRow)

                    // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                    {
                        // ”N‹à—pƒf[ƒ^ì¬
                        // *—š—ð”Ô† 000027 2006/07/31 C³ŠJŽn
                        if ((strGyomuMei ?? "") == NENKIN | (strGyomuMei ?? "") == NENKIN_2)
                        {
                            // If (strGyomuMei = NENKIN) Then
                            // *—š—ð”Ô† 000027 2006/07/31 C³I—¹


                            // ‹Œ©
                            csDataNewRow(ABNenkinAtenaEntity.KYUSEI) = csDataRow(ABAtenaRirekiEntity.KYUSEI);
                            // Z’èˆÙ“®”NŒŽ“ú
                            csDataNewRow(ABNenkinAtenaEntity.JUTEIIDOYMD) = csDataRow(ABAtenaRirekiEntity.JUTEIIDOYMD);
                            // Z’èŽ–—R
                            csDataNewRow(ABNenkinAtenaEntity.JUTEIJIYU) = csDataRow(ABAtenaRirekiEntity.JUTEIJIYU);
                            // “]“ü‘OZŠ—X•Ö”Ô†
                            csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_YUBINNO) = csDataRow(ABAtenaRirekiEntity.TENUMAEJ_YUBINNO);
                            // “]“ü‘OZŠ‘S‘ZŠƒR[ƒh
                            csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_ZJUSHOCD) = csDataRow(ABAtenaRirekiEntity.TENUMAEJ_ZJUSHOCD);
                            // “]“ü‘OZŠZŠ
                            csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_JUSHO) = csDataRow(ABAtenaRirekiEntity.TENUMAEJ_JUSHO);
                            // “]“ü‘OZŠ”Ô’n
                            csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_BANCHI) = csDataRow(ABAtenaRirekiEntity.TENUMAEJ_BANCHI);
                            // “]“ü‘OZŠ•û‘
                            strWork = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.TENUMAEJ_KATAGAKI)).Trim;
                            csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_KATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                            // “]o—\’è—X•Ö”Ô†
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIYUBINNO) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEIYUBINNO);
                            // “]o—\’è‘S‘ZŠƒR[ƒh
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIZJUSHOCD) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEIZJUSHOCD);
                            // “]o—\’èˆÙ“®”NŒŽ“ú
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIIDOYMD) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEIIDOYMD);
                            // “]o—\’èZŠ
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIJUSHO) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEIJUSHO);
                            // “]o—\’è”Ô’n
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIBANCHI) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEIBANCHI);
                            // “]o—\’è•û‘
                            strWork = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEIKATAGAKI)).Trim;
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIKATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                            // “]oŠm’è—X•Ö”Ô†
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIYUBINNO) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTIYUBINNO);
                            // “]oŠm’è‘S‘ZŠƒR[ƒh
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIZJUSHOCD) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTIZJUSHOCD);
                            // “]oŠm’èˆÙ“®”NŒŽ“ú
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIIDOYMD) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTIIDOYMD);
                            // “]oŠm’è’Ê’m”NŒŽ“ú
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTITSUCHIYMD) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTITSUCHIYMD);
                            // “]oŠm’èZŠ
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIJUSHO) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTIJUSHO);
                            // “]oŠm’è”Ô’n
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIBANCHI) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTIBANCHI);
                            // “]oŠm’è•û‘
                            strWork = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTIKATAGAKI)).Trim;
                            csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIKATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);

                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // “]“ü‘OZŠ•û‘iƒtƒ‹j
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_KATAGAKI_FULL) = csDataRow(ABAtenaRirekiEntity.TENUMAEJ_KATAGAKI);
                                // “]o—\’è•û‘iƒtƒ‹j
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIKATAGAKI_FULL) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEIKATAGAKI);
                                // “]oŠm’è•û‘iƒtƒ‹j
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTIKATAGAKI_FULL) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTIKATAGAKI);
                            }
                            else
                            {
                            }

                            // ZŠî—Dæ‚Ìê‡
                            if (cAtenaGetPara1.p_strJukiJutogaiKB == "1")
                            {
                                // •ÒW‘O”Ô’n
                                csDataNewRow(ABNenkinAtenaEntity.HENSHUMAEBANCHI) = csDataRow(ABAtenaRirekiEntity.JUKIBANCHI);
                                // •ÒW‘O•û‘
                                strWork = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIKATAGAKI)).Trim;
                                csDataNewRow(ABNenkinAtenaEntity.HENSHUMAEKATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    // •ÒW‘O•û‘iƒtƒ‹j
                                    csDataNewRow(ABNenkinAtenaHyojunEntity.HENSHUMAEKATAGAKI_FULL) = csDataRow(ABAtenaRirekiEntity.JUKIKATAGAKI);
                                }
                                else
                                {
                                }
                            }
                            else
                            {
                                // •ÒW‘O”Ô’n
                                csDataNewRow(ABNenkinAtenaEntity.HENSHUMAEBANCHI) = csDataRow(ABAtenaRirekiEntity.BANCHI);
                                // •ÒW‘O•û‘
                                strWork = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KATAGAKI)).Trim;
                                csDataNewRow(ABNenkinAtenaEntity.HENSHUMAEKATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    // •ÒW‘O•û‘iƒtƒ‹j
                                    csDataNewRow(ABNenkinAtenaHyojunEntity.HENSHUMAEKATAGAKI_FULL) = csDataRow(ABAtenaRirekiEntity.KATAGAKI);
                                }
                                else
                                {
                                }
                            }

                            // Áœ“Ío”NŒŽ“ú
                            csDataNewRow(ABNenkinAtenaEntity.SHOJOTDKDYMD) = csDataRow(ABAtenaRirekiEntity.SHOJOTDKDYMD);
                            // ’¼‹ßŽ–—RƒR[ƒh
                            csDataNewRow(ABNenkinAtenaEntity.CKINJIYUCD) = csDataRow(ABAtenaRirekiEntity.CKINJIYUCD);

                            // *—š—ð”Ô† 000022 2003/12/04 ’Ç‰ÁŠJŽn
                            // –{Ð‘S‘ZŠƒR[ƒh
                            csDataNewRow(ABNenkinAtenaEntity.HON_ZJUSHOCD) = csDataRow(ABAtenaRirekiEntity.HON_ZJUSHOCD);
                            // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                            // “]o—\’è¢‘ÑŽå–¼
                            // csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEISTAINUSMEI) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEISTAINUSMEI)
                            // “]oŠm’è¢‘ÑŽå–¼
                            // csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTISTAINUSMEI) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTISTAINUSMEI)
                            if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                                // “]o—\’è¢‘ÑŽå–¼
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEISTAINUSMEI) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEISTAINUSMEI)));
                                // “]oŠm’è¢‘ÑŽå–¼
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTISTAINUSMEI) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTISTAINUSMEI)));
                            }
                            else
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                                // “]o—\’è¢‘ÑŽå–¼
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEISTAINUSMEI) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEISTAINUSMEI);
                                // “]oŠm’è¢‘ÑŽå–¼
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTISTAINUSMEI) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTISTAINUSMEI);
                            }
                            // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹
                            // ‘ÐƒR[ƒh
                            csDataNewRow(ABNenkinAtenaEntity.KOKUSEKICD) = csDataRow(ABAtenaRirekiEntity.KOKUSEKICD);
                            // *—š—ð”Ô† 000022 2003/12/04 ’Ç‰ÁI—¹
                            // *—š—ð”Ô† 000027 2006/07/31 ’Ç‰ÁŠJŽn
                            if ((strGyomuMei ?? "") == NENKIN_2)
                            {
                                // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                                // “]“ü‘OZŠ¢‘ÑŽå–¼
                                // csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_STAINUSMEI) = csDataRow(ABAtenaRirekiEntity.TENUMAEJ_STAINUSMEI)
                                if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                                {
                                    // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                                    csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_STAINUSMEI) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.TENUMAEJ_STAINUSMEI)));
                                }
                                else
                                {
                                    // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                                    csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_STAINUSMEI) = csDataRow(ABAtenaRirekiEntity.TENUMAEJ_STAINUSMEI);
                                }
                                // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹
                            }
                            // *—š—ð”Ô† 000027 2006/07/31 ’Ç‰ÁI—¹
                        }

                        // *—š—ð”Ô† 000030 2007/04/28 ’Ç‰ÁŠJŽn
                        // ‰îŒì—pƒTƒuƒ‹[ƒ`ƒ“Žæ“¾€–Ú
                        if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_Kaigo)
                        {
                            // ‹Œ©
                            csDataNewRow(ABAtena1Entity.KYUSEI) = csDataRow(ABAtenaRirekiEntity.KYUSEI);
                            // Z’èˆÙ“®”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.JUTEIIDOYMD) = csDataRow(ABAtenaRirekiEntity.JUTEIIDOYMD);
                            // Z’èŽ–—R
                            csDataNewRow(ABAtena1Entity.JUTEIJIYU) = csDataRow(ABAtenaRirekiEntity.JUTEIJIYU);
                            // –{Ð‘S‘ZŠƒR[ƒh
                            csDataNewRow(ABAtena1Entity.HON_ZJUSHOCD) = csDataRow(ABAtenaRirekiEntity.HON_ZJUSHOCD);
                            // “]“ü‘OZŠ—X•Ö”Ô†
                            csDataNewRow(ABAtena1Entity.TENUMAEJ_YUBINNO) = csDataRow(ABAtenaRirekiEntity.TENUMAEJ_YUBINNO);
                            // “]“ü‘OZŠ‘S‘ZŠƒR[ƒh
                            csDataNewRow(ABAtena1Entity.TENUMAEJ_ZJUSHOCD) = csDataRow(ABAtenaRirekiEntity.TENUMAEJ_ZJUSHOCD);
                            // “]“ü‘OZŠZŠ
                            csDataNewRow(ABAtena1Entity.TENUMAEJ_JUSHO) = csDataRow(ABAtenaRirekiEntity.TENUMAEJ_JUSHO);
                            // “]“ü‘OZŠ”Ô’n
                            csDataNewRow(ABAtena1Entity.TENUMAEJ_BANCHI) = csDataRow(ABAtenaRirekiEntity.TENUMAEJ_BANCHI);
                            // “]“ü‘OZŠ•û‘
                            strWork = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.TENUMAEJ_KATAGAKI)).Trim;
                            csDataNewRow(ABAtena1Entity.TENUMAEJ_KATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                            // “]o—\’è—X•Ö”Ô†
                            csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEIYUBINNO) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEIYUBINNO);
                            // “]o—\’è‘S‘ZŠƒR[ƒh
                            csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEIZJUSHOCD) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEIZJUSHOCD);
                            // “]o—\’èˆÙ“®”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEIIDOYMD) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEIIDOYMD);
                            // “]o—\’èZŠ
                            csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEIJUSHO) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEIJUSHO);
                            // “]o—\’è”Ô’n
                            csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEIBANCHI) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEIBANCHI);
                            // “]o—\’è•û‘
                            strWork = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEIKATAGAKI)).Trim;
                            csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEIKATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // “]“ü‘OZŠ•û‘iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_KATAGAKI_FULL) = csDataRow(ABAtenaRirekiEntity.TENUMAEJ_KATAGAKI);
                                // “]o—\’è•û‘iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIKATAGAKI_FULL) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEIKATAGAKI);
                            }
                            else
                            {
                            }
                            // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                            // “]o—\’è¢‘ÑŽå–¼
                            // csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEISTAINUSMEI) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEISTAINUSMEI)
                            if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                                csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEISTAINUSMEI) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEISTAINUSMEI)));
                            }
                            else
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                                csDataNewRow(ABAtena1Entity.TENSHUTSUYOTEISTAINUSMEI) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUYOTEISTAINUSMEI);
                            }
                            // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹
                            // “]oŠm’è—X•Ö”Ô†
                            csDataNewRow(ABAtena1Entity.TENSHUTSUKKTIYUBINNO) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTIYUBINNO);
                            // “]oŠm’è‘S‘ZŠƒR[ƒh
                            csDataNewRow(ABAtena1Entity.TENSHUTSUKKTIZJUSHOCD) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTIZJUSHOCD);
                            // “]oŠm’èˆÙ“®”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.TENSHUTSUKKTIIDOYMD) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTIIDOYMD);
                            // “]oŠm’è’Ê’m”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.TENSHUTSUKKTITSUCHIYMD) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTITSUCHIYMD);
                            // “]oŠm’èZŠ
                            csDataNewRow(ABAtena1Entity.TENSHUTSUKKTIJUSHO) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTIJUSHO);
                            // “]oŠm’è”Ô’n
                            csDataNewRow(ABAtena1Entity.TENSHUTSUKKTIBANCHI) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTIBANCHI);
                            // “]oŠm’è•û‘
                            strWork = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTIKATAGAKI)).Trim;
                            csDataNewRow(ABAtena1Entity.TENSHUTSUKKTIKATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // “]oŠm’è•û‘iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTIKATAGAKI_FULL) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTIKATAGAKI);
                            }
                            else
                            {
                            }
                            // * —š—ðŠJŽn 000035 2008/02/15 C³ŠJŽn
                            // “]oŠm’è¢‘ÑŽå–¼
                            // csDataNewRow(ABAtena1Entity.TENSHUTSUKKTISTAINUSMEI) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTISTAINUSMEI)
                            if (cAtenaGetPara1.p_strFrnMeishoHenshuKB != "1")
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                                csDataNewRow(ABAtena1Entity.TENSHUTSUKKTISTAINUSMEI) = m_cABMojiHenshuB.EditKanryakuMeisho(Conversions.ToString(csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTISTAINUSMEI)));
                            }
                            else
                            {
                                // ŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                                csDataNewRow(ABAtena1Entity.TENSHUTSUKKTISTAINUSMEI) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUKKTISTAINUSMEI);
                            }
                            // * —š—ðŠJŽn 000035 2008/02/15 C³I—¹

                            // ZŠî—Dæ‚Ìê‡
                            if (cAtenaGetPara1.p_strJukiJutogaiKB == "1")
                            {
                                // •ÒW‘O”Ô’n
                                csDataNewRow(ABAtena1Entity.HENSHUMAEBANCHI) = csDataRow(ABAtenaRirekiEntity.JUKIBANCHI);
                                // •ÒW‘O•û‘
                                strWork = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.JUKIKATAGAKI)).Trim;
                                csDataNewRow(ABAtena1Entity.HENSHUMAEKATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    // •ÒW‘O•û‘iƒtƒ‹j
                                    csDataNewRow(ABAtena1HyojunEntity.HENSHUMAEKATAGAKI_FULL) = csDataRow(ABAtenaRirekiEntity.JUKIKATAGAKI);
                                }
                                else
                                {
                                }
                            }
                            else
                            {
                                // •ÒW‘O”Ô’n
                                csDataNewRow(ABAtena1Entity.HENSHUMAEBANCHI) = csDataRow(ABAtenaRirekiEntity.BANCHI);
                                // •ÒW‘O•û‘
                                strWork = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.KATAGAKI)).Trim;
                                csDataNewRow(ABAtena1Entity.HENSHUMAEKATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    // •ÒW‘O•û‘iƒtƒ‹j
                                    csDataNewRow(ABAtena1HyojunEntity.HENSHUMAEKATAGAKI_FULL) = csDataRow(ABAtenaRirekiEntity.KATAGAKI);
                                }
                                else
                                {
                                }
                            }

                            // Áœ“Ío”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.SHOJOTDKDYMD) = csDataRow(ABAtenaRirekiEntity.SHOJOTDKDYMD);
                            // ’¼‹ßŽ–—RƒR[ƒh
                            csDataNewRow(ABAtena1Entity.CKINJIYUCD) = csDataRow(ABAtenaRirekiEntity.CKINJIYUCD);
                            // ‘ÐƒR[ƒh
                            csDataNewRow(ABAtena1Entity.KOKUSEKICD) = csDataRow(ABAtenaRirekiEntity.KOKUSEKICD);
                            // “o˜^“Ío”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.TOROKUTDKDYMD) = csDataRow(ABAtenaRirekiEntity.TOROKUTDKDYMD);
                            // Z’è“Ío”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.JUTEITDKDYMD) = csDataRow(ABAtenaRirekiEntity.JUTEITDKDYMD);
                            // “]o“ü——R
                            csDataNewRow(ABAtena1Entity.TENSHUTSUNYURIYU) = csDataRow(ABAtenaRirekiEntity.TENSHUTSUNYURIYU);
                            // Žs’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1Entity.SHICHOSONCD) = csDataRow(ABAtenaRirekiEntity.SHICHOSONCD);
                            if (!(csDataRow(ABAtenaRirekiEntity.CKINJIYUCD).ToString.Trim == string.Empty) && csDataRow(ABAtenaRirekiEntity.CKINIDOYMD).ToString.Trim == string.Empty)
                            {
                                csDataNewRow(ABAtena1Entity.CKINIDOYMD) = m_strCknIdobiHenkanParam;
                            }
                            else
                            {
                                // ’¼‹ßˆÙ“®”NŒŽ“ú
                                csDataNewRow(ABAtena1Entity.CKINIDOYMD) = csDataRow(ABAtenaRirekiEntity.CKINIDOYMD);
                            }
                            // XV“úŽž
                            csDataNewRow(ABAtena1Entity.KOSHINNICHIJI) = csDataRow(ABAtenaRirekiEntity.KOSHINNICHIJI);
                        }
                        // *—š—ð”Ô† 000030 2007/04/28 ’Ç‰ÁI—¹

                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    // *—š—ð”Ô† 000019 2003/11/19 ’Ç‰ÁŠJŽn
                    // ˆ¶–¼ŒÂ•Êî•ñ—pƒf[ƒ^ì¬(–{lƒŒƒR[ƒh‚Ì‚ÝÝ’è)
                    if ((strGyomuMei ?? "") == KOBETSU & string.IsNullOrEmpty(strDainoKB.Trim()))
                    {

                        // Šî‘b”N‹à”Ô†	
                        csDataNewRow(ABAtena1KobetsuEntity.KSNENKNNO) = csDataRow(ABAtena1KobetsuEntity.KSNENKNNO);
                        // ”N‹àŽ‘ŠiŽæ“¾”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.NENKNSKAKSHUTKYMD) = csDataRow(ABAtena1KobetsuEntity.NENKNSKAKSHUTKYMD);
                        // ”N‹àŽ‘ŠiŽæ“¾Ží•Ê	
                        csDataNewRow(ABAtena1KobetsuEntity.NENKNSKAKSHUTKSHU) = csDataRow(ABAtena1KobetsuEntity.NENKNSKAKSHUTKSHU);
                        // ”N‹àŽ‘ŠiŽæ“¾——RƒR[ƒh	
                        csDataNewRow(ABAtena1KobetsuEntity.NENKNSKAKSHUTKRIYUCD) = csDataRow(ABAtena1KobetsuEntity.NENKNSKAKSHUTKRIYUCD);
                        // ”N‹àŽ‘Ši‘rŽ¸”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.NENKNSKAKSSHTSYMD) = csDataRow(ABAtena1KobetsuEntity.NENKNSKAKSSHTSYMD);
                        // ”N‹àŽ‘Ši‘rŽ¸——RƒR[ƒh	
                        csDataNewRow(ABAtena1KobetsuEntity.NENKNSKAKSSHTSRIYUCD) = csDataRow(ABAtena1KobetsuEntity.NENKNSKAKSSHTSRIYUCD);
                        // Žó‹‹”N‹à‹L†‚P	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNKIGO1) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNKIGO1);
                        // Žó‹‹”N‹à”Ô†‚P	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNNO1) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNNO1);
                        // Žó‹‹”N‹àŽí•Ê‚P	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNSHU1) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNSHU1);
                        // Žó‹‹”N‹àŽ}”Ô‚P	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNEDABAN1) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNEDABAN1);
                        // Žó‹‹”N‹à‹æ•ª‚P	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNKB1) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNKB1);
                        // Žó‹‹”N‹à‹L†‚Q	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNKIGO2) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNKIGO2);
                        // Žó‹‹”N‹à”Ô†‚Q	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNNO2) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNNO2);
                        // Žó‹‹”N‹àŽí•Ê‚Q	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNSHU2) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNSHU2);
                        // Žó‹‹”N‹àŽ}”Ô‚Q	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNEDABAN2) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNEDABAN2);
                        // Žó‹‹”N‹à‹æ•ª‚Q	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNKB2) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNKB2);
                        // Žó‹‹”N‹à‹L†‚R	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNKIGO3) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNKIGO3);
                        // Žó‹‹”N‹à”Ô†‚R	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNNO3) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNNO3);
                        // Žó‹‹”N‹àŽí•Ê‚R	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNSHU3) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNSHU3);
                        // Žó‹‹”N‹àŽ}”Ô‚R	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNEDABAN3) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNEDABAN3);
                        // Žó‹‹”N‹à‹æ•ª‚R	
                        csDataNewRow(ABAtena1KobetsuEntity.JKYNENKNKB3) = csDataRow(ABAtena1KobetsuEntity.JKYNENKNKB3);
                        // ‘•Û”Ô†	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHONO) = csDataRow(ABAtena1KobetsuEntity.KOKUHONO);
                        // ‘•ÛŽ‘Ši‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKB) = csDataRow(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKB);
                        // ‘•ÛŽ‘Ši‹æ•ª³Ž®–¼Ì	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKBMEISHO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKBMEISHO);
                        // ‘•ÛŽ‘Ši‹æ•ª—ªŽ®–¼Ì	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKBRYAKUSHO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKBRYAKUSHO);
                        // ‘•ÛŠw‰“‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOGAKUENKB) = csDataRow(ABAtena1KobetsuEntity.KOKUHOGAKUENKB);
                        // ‘•ÛŠw‰“‹æ•ª³Ž®–¼Ì	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOGAKUENKBMEISHO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOGAKUENKBMEISHO);
                        // ‘•ÛŠw‰“‹æ•ª—ªŽ®–¼Ì	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOGAKUENKBRYAKUSHO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOGAKUENKBRYAKUSHO);
                        // ‘•ÛŽæ“¾”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOSHUTOKUYMD) = csDataRow(ABAtena1KobetsuEntity.KOKUHOSHUTOKUYMD);
                        // ‘•Û‘rŽ¸”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOSOSHITSUYMD) = csDataRow(ABAtena1KobetsuEntity.KOKUHOSOSHITSUYMD);
                        // ‘•Û‘ÞE‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOTISHKKB) = csDataRow(ABAtena1KobetsuEntity.KOKUHOTISHKKB);
                        // ‘•Û‘ÞE‹æ•ª³Ž®–¼Ì	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOTISHKKBMEISHO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOTISHKKBMEISHO);
                        // ‘•Û‘ÞE‹æ•ª—ªŽ®–¼Ì	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOTISHKKBRYAKUSHO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOTISHKKBRYAKUSHO);
                        // ‘•Û‘ÞE–{”í‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKB) = csDataRow(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKB);
                        // ‘•Û‘ÞE–{”í‹æ•ª³Ž®–¼Ì	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKBMEISHO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKBMEISHO);
                        // ‘•Û‘ÞE–{”í‹æ•ª—ªŽ®–¼Ì	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKBRYAKUSHO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKBRYAKUSHO);
                        // ‘•Û‘ÞEŠY“–”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOTISHKGAITOYMD) = csDataRow(ABAtena1KobetsuEntity.KOKUHOTISHKGAITOYMD);
                        // ‘•Û‘ÞE”ñŠY“–”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOTISHKHIGAITOYMD) = csDataRow(ABAtena1KobetsuEntity.KOKUHOTISHKHIGAITOYMD);
                        // ‘•Û•ÛŒ¯Ø‹L†	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOHOKENSHOKIGO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOHOKENSHOKIGO);
                        // ‘•Û•ÛŒ¯Ø”Ô†	
                        csDataNewRow(ABAtena1KobetsuEntity.KOKUHOHOKENSHONO) = csDataRow(ABAtena1KobetsuEntity.KOKUHOHOKENSHONO);
                        // ˆóŠÓ”Ô†	
                        csDataNewRow(ABAtena1KobetsuEntity.INKANNO) = csDataRow(ABAtena1KobetsuEntity.INKANNO);
                        // ˆóŠÓ“o˜^‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.INKANTOROKUKB) = csDataRow(ABAtena1KobetsuEntity.INKANTOROKUKB);
                        // ‘I‹“Ž‘Ši‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.SENKYOSHIKAKUKB) = csDataRow(ABAtena1KobetsuEntity.SENKYOSHIKAKUKB);
                        // Ž™Žè”í—p‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.JIDOTEATEHIYOKB) = csDataRow(ABAtena1KobetsuEntity.JIDOTEATEHIYOKB);
                        // Ž™ŽèŠJŽn”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.JIDOTEATESTYM) = csDataRow(ABAtena1KobetsuEntity.JIDOTEATESTYM);
                        // Ž™ŽèI—¹”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.JIDOTEATEEDYM) = csDataRow(ABAtena1KobetsuEntity.JIDOTEATEEDYM);
                        // ‰îŒì”í•ÛŒ¯ŽÒ”Ô†	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGHIHKNSHANO) = csDataRow(ABAtena1KobetsuEntity.KAIGHIHKNSHANO);
                        // ‰îŒìŽ‘ŠiŽæ“¾“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGSKAKSHUTKYMD) = csDataRow(ABAtena1KobetsuEntity.KAIGSKAKSHUTKYMD);
                        // ‰îŒìŽ‘Ši‘rŽ¸“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGSKAKSSHTSYMD) = csDataRow(ABAtena1KobetsuEntity.KAIGSKAKSSHTSYMD);
                        // ‰îŒìŽ‘Ši”í•ÛŒ¯ŽÒ‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGSKAKHIHOKENSHAKB) = csDataRow(ABAtena1KobetsuEntity.KAIGSKAKHIHOKENSHAKB);
                        // ‰îŒìZŠ’n“Á—áŽÒ‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGJUSHOCHITKRIKB) = csDataRow(ABAtena1KobetsuEntity.KAIGJUSHOCHITKRIKB);
                        // ‰îŒìŽó‹‹ŽÒ‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGJUKYUSHAKB) = csDataRow(ABAtena1KobetsuEntity.KAIGJUKYUSHAKB);
                        // —v‰îŒìó‘Ô‹æ•ªƒR[ƒh	
                        csDataNewRow(ABAtena1KobetsuEntity.YOKAIGJOTAIKBCD) = csDataRow(ABAtena1KobetsuEntity.YOKAIGJOTAIKBCD);
                        // —v‰îŒìó‘Ô‹æ•ª	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGSKAKKB) = csDataRow(ABAtena1KobetsuEntity.KAIGSKAKKB);
                        // ‰îŒì”F’è—LŒøŠJŽn“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGNINTEIKAISHIYMD) = csDataRow(ABAtena1KobetsuEntity.KAIGNINTEIKAISHIYMD);
                        // ‰îŒì”F’è—LŒøI—¹“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGNINTEISHURYOYMD) = csDataRow(ABAtena1KobetsuEntity.KAIGNINTEISHURYOYMD);
                        // ‰îŒìŽó‹‹”F’è”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGJUKYUNINTEIYMD) = csDataRow(ABAtena1KobetsuEntity.KAIGJUKYUNINTEIYMD);
                        // ‰îŒìŽó‹‹”F’èŽæÁ”NŒŽ“ú	
                        csDataNewRow(ABAtena1KobetsuEntity.KAIGJUKYUNINTEITORIKESHIYMD) = csDataRow(ABAtena1KobetsuEntity.KAIGJUKYUNINTEITORIKESHIYMD);

                        // *—š—ð”Ô† 000034 2008/01/15 ’Ç‰ÁŠJŽn
                        if (m_strKobetsuShutokuKB == "1")
                        {
                            // ŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ª"1"‚Ìê‡‚ÍŒãŠú‚—î€–Ú‚ð’Ç‰Á‚·‚é
                            // Ž‘Ši‹æ•ª
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREISHIKAKUKB) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREISHIKAKUKB);
                            // ”í•ÛŒ¯ŽÒ”Ô†
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREIHIHKNSHANO) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREIHIHKNSHANO);
                            // ”í•ÛŒ¯ŽÒŽ‘ŠiŽæ“¾Ž–—RƒR[ƒh
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKJIYUCD) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKJIYUCD);
                            // ”í•ÛŒ¯ŽÒŽ‘ŠiŽæ“¾Ž–—R–¼Ì
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKJIYUMEI) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKJIYUMEI);
                            // ”í•ÛŒ¯ŽÒŽ‘ŠiŽæ“¾”NŒŽ“ú
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKYMD) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKYMD);
                            // ”í•ÛŒ¯ŽÒŽ‘Ši‘rŽ¸Ž–—RƒR[ƒh
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSJIYUCD) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSJIYUCD);
                            // ”í•ÛŒ¯ŽÒŽ‘Ši‘rŽ¸Ž–—R–¼Ì
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSJIYUMEI) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSJIYUMEI);
                            // ”í•ÛŒ¯ŽÒŽ‘Ši‘rŽ¸”NŒŽ“ú
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSYMD) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSYMD);
                            // •ÛŒ¯ŽÒ”Ô†“K—pŠJŽn”NŒŽ“ú
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREITEKIYOKAISHIYMD) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREITEKIYOKAISHIYMD);
                            // •ÛŒ¯ŽÒ”Ô†“K—pI—¹”NŒŽ“ú
                            csDataNewRow(ABAtena1KobetsuEntity.KOKIKOREITEKIYOSHURYOYMD) = csDataRow(ABAtena1KobetsuEntity.KOKIKOREITEKIYOSHURYOYMD);
                        }
                        else
                        {
                            // ŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ª’l‚È‚µ‚Ìê‡‚ÍŒãŠú‚—î€–Ú‚ð’Ç‰Á‚µ‚È‚¢
                        }
                        // *—š—ð”Ô† 000034 2008/01/15 ’Ç‰ÁI—¹

                    }
                    // *—š—ð”Ô† 000019 2003/11/19 ’Ç‰ÁI—¹

                    // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁŠJŽn
                    // ZŠî–@‰ü³”»’è
                    if (m_strJukiHokaiseiKB_Param == "1")
                    {
                        // Z–¯•[ó‘Ô‹æ•ª
                        csDataNewRow(ABAtenaFZYEntity.JUMINHYOJOTAIKBN) = csDataRow(ABAtenaFZYEntity.JUMINHYOJOTAIKBN);
                        // Z‹’n“Ío—L–³ƒtƒ‰ƒO
                        csDataNewRow(ABAtenaFZYEntity.JUKYOCHITODOKEFLG) = csDataRow(ABAtenaFZYEntity.JUKYOCHITODOKEFLG);
                        // –{‘–¼
                        csDataNewRow(ABAtenaFZYEntity.HONGOKUMEI) = csDataRow(ABAtenaFZYEntity.HONGOKUMEI);
                        // ƒJƒi–{‘–¼
                        csDataNewRow(ABAtenaFZYEntity.KANAHONGOKUMEI) = csDataRow(ABAtenaFZYEntity.KANAHONGOKUMEI);
                        // •¹‹L–¼
                        csDataNewRow(ABAtenaFZYEntity.KANJIHEIKIMEI) = csDataRow(ABAtenaFZYEntity.KANJIHEIKIMEI);
                        // ƒJƒi•¹‹L–¼
                        csDataNewRow(ABAtenaFZYEntity.KANAHEIKIMEI) = csDataRow(ABAtenaFZYEntity.KANAHEIKIMEI);
                        // ’ÊÌ–¼
                        csDataNewRow(ABAtenaFZYEntity.KANJITSUSHOMEI) = csDataRow(ABAtenaFZYEntity.KANJITSUSHOMEI);
                        // ƒJƒi’ÊÌ–¼
                        csDataNewRow(ABAtenaFZYEntity.KANATSUSHOMEI) = csDataRow(ABAtenaFZYEntity.KANATSUSHOMEI);
                        // ƒJƒ^ƒJƒi•¹‹L–¼
                        csDataNewRow(ABAtenaFZYEntity.KATAKANAHEIKIMEI) = csDataRow(ABAtenaFZYEntity.KATAKANAHEIKIMEI);
                        // ¶”NŒŽ“ú•sÚ‹æ•ª
                        csDataNewRow(ABAtenaFZYEntity.UMAREFUSHOKBN) = csDataRow(ABAtenaFZYEntity.UMAREFUSHOKBN);
                        // ’ÊÌ–¼“o˜^i•ÏXj”NŒŽ“ú
                        csDataNewRow(ABAtenaFZYEntity.TSUSHOMEITOUROKUYMD) = csDataRow(ABAtenaFZYEntity.TSUSHOMEITOUROKUYMD);
                        // Ý—¯ŠúŠÔƒR[ƒh
                        csDataNewRow(ABAtenaFZYEntity.ZAIRYUKIKANCD) = csDataRow(ABAtenaFZYEntity.ZAIRYUKIKANCD);
                        // Ý—¯ŠúŠÔ–¼Ì
                        csDataNewRow(ABAtenaFZYEntity.ZAIRYUKIKANMEISHO) = csDataRow(ABAtenaFZYEntity.ZAIRYUKIKANMEISHO);
                        // ’†’·ŠúÝ—¯ŽÒ‚Å‚ ‚éŽ|“™‚ÌƒR[ƒh
                        csDataNewRow(ABAtenaFZYEntity.ZAIRYUSHACD) = csDataRow(ABAtenaFZYEntity.ZAIRYUSHACD);
                        // ’†’·ŠúÝ—¯ŽÒ‚Å‚ ‚éŽ|“™
                        csDataNewRow(ABAtenaFZYEntity.ZAIRYUSHAMEISHO) = csDataRow(ABAtenaFZYEntity.ZAIRYUSHAMEISHO);
                        // Ý—¯ƒJ[ƒh“™”Ô†
                        csDataNewRow(ABAtenaFZYEntity.ZAIRYUCARDNO) = csDataRow(ABAtenaFZYEntity.ZAIRYUCARDNO);
                        // “Á•Ê‰iZŽÒØ–¾‘Œð•t”NŒŽ“ú
                        csDataNewRow(ABAtenaFZYEntity.KOFUYMD) = csDataRow(ABAtenaFZYEntity.KOFUYMD);
                        // “Á•Ê‰iZŽÒØ–¾‘Œð•t—\’èŠúŠÔŠJŽn“ú
                        csDataNewRow(ABAtenaFZYEntity.KOFUYOTEISTYMD) = csDataRow(ABAtenaFZYEntity.KOFUYOTEISTYMD);
                        // “Á’è‰iZŽÒØ–¾‘Œð•t—\’èŠúŠÔI—¹“ú
                        csDataNewRow(ABAtenaFZYEntity.KOFUYOTEIEDYMD) = csDataRow(ABAtenaFZYEntity.KOFUYOTEIEDYMD);
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœˆÙ“®”NŒŽ“ú
                        csDataNewRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOIDOYMD) = csDataRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOIDOYMD);
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœŽ–—RƒR[ƒh
                        csDataNewRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYUCD) = csDataRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYUCD);
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœŽ–—R
                        csDataNewRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYU) = csDataRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYU);
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœ“Ío”NŒŽ“ú
                        csDataNewRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDYMD) = csDataRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDYMD);
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœ“Ío’Ê’m‹æ•ª
                        csDataNewRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDTUCIKB) = csDataRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDTUCIKB);
                        // ŠO‘l¢‘ÑŽå–¼
                        csDataNewRow(ABAtenaFZYEntity.FRNSTAINUSMEI) = csDataRow(ABAtenaFZYEntity.FRNSTAINUSMEI);
                        // ŠO‘l¢‘ÑŽåƒJƒi–¼
                        csDataNewRow(ABAtenaFZYEntity.FRNSTAINUSKANAMEI) = csDataRow(ABAtenaFZYEntity.FRNSTAINUSKANAMEI);
                        // ¢‘ÑŽå•¹‹L–¼
                        csDataNewRow(ABAtenaFZYEntity.STAINUSHEIKIMEI) = csDataRow(ABAtenaFZYEntity.STAINUSHEIKIMEI);
                        // ¢‘ÑŽåƒJƒi•¹‹L–¼
                        csDataNewRow(ABAtenaFZYEntity.STAINUSKANAHEIKIMEI) = csDataRow(ABAtenaFZYEntity.STAINUSKANAHEIKIMEI);
                        // ¢‘ÑŽå’ÊÌ–¼
                        csDataNewRow(ABAtenaFZYEntity.STAINUSTSUSHOMEI) = csDataRow(ABAtenaFZYEntity.STAINUSTSUSHOMEI);
                        // ¢‘ÑŽåƒJƒi’ÊÌ–¼
                        csDataNewRow(ABAtenaFZYEntity.STAINUSKANATSUSHOMEI) = csDataRow(ABAtenaFZYEntity.STAINUSKANATSUSHOMEI);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }
                    // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁI—¹

                    // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁŠJŽn
                    // ‹¤’Ê”Ô†”»’è
                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                    {
                        // ‹ó”’œ‹Ž‚µ‚½’l‚ðÝ’è‚·‚éB
                        csDataNewRow(ABMyNumberEntity.MYNUMBER) = csDataRow(ABMyNumberEntity.MYNUMBER).ToString.Trim;
                    }
                    else
                    {
                        // noop
                    }
                    // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁI—¹

                    if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                    {
                        // ¢‘ÑŽåŽ–¼—Dæ‹æ•ª
                        csDataNewRow(ABAtena1HyojunEntity.STAINUSSHIMEIYUSENKB) = csDataRow(ABAtenaRirekiFZYHyojunEntity.STAINUSSHIMEIYUSENKB);
                        // Ž–¼—Dæ€–Ú
                        csDataNewRow(ABAtena1HyojunEntity.SHIMEIYUSENKB) = csDataRow(ABAtenaRirekiFZYHyojunEntity.SHIMEIYUSENKB);
                        // ‹ŒŽ
                        csDataNewRow(ABAtena1HyojunEntity.KANJIKYUUJI) = csDataRow(ABAtenaRirekiFZYEntity.RESERVE7);
                        // ƒJƒi‹ŒŽ
                        csDataNewRow(ABAtena1HyojunEntity.KANAKYUUJI) = csDataRow(ABAtenaRirekiFZYEntity.RESERVE8);
                        // Ž–¼ƒtƒŠƒKƒiŠm”Fƒtƒ‰ƒO
                        csDataNewRow(ABAtena1HyojunEntity.SHIMEIKANAKAKUNINFG) = csDataRow(ABAtenaRirekiHyojunEntity.SHIMEIKANAKAKUNINFG);
                        // ‹ŒŽƒtƒŠƒKƒiŠm”Fƒtƒ‰ƒO
                        csDataNewRow(ABAtena1HyojunEntity.KYUUJIKANAKAKUNINFG) = csDataRow(ABAtenaRirekiHyojunEntity.KYUUJIKANAKAKUNINFG);
                        // ’ÊÌƒtƒŠƒKƒiŠm”Fƒtƒ‰ƒO
                        csDataNewRow(ABAtena1HyojunEntity.TSUSHOKANAKAKUNINFG) = csDataRow(ABAtenaRirekiFZYHyojunEntity.TSUSHOKANAKAKUNINFG);
                        // ¶”NŒŽ“ú•sÚƒpƒ^[ƒ“
                        csDataNewRow(ABAtena1HyojunEntity.UMAREBIFUSHOPTN) = csDataRow(ABAtenaRirekiHyojunEntity.UMAREBIFUSHOPTN);
                        // •sÚ¶”NŒŽ“ú
                        csDataNewRow(ABAtena1HyojunEntity.FUSHOUMAREBI) = csDataRow(ABAtenaRirekiHyojunEntity.FUSHOUMAREBI);
                        // ‹LÚŽ–—R
                        csDataNewRow(ABAtena1HyojunEntity.HYOJUNKISAIJIYUCD) = csDataRow(ABAtenaRirekiHyojunEntity.HYOJUNKISAIJIYUCD);
                        // ‹LÚ”NŒŽ“ú
                        csDataNewRow(ABAtena1HyojunEntity.KISAIYMD) = csDataRow(ABAtenaRirekiHyojunEntity.KISAIYMD);
                        // ÁœŽ–—R
                        csDataNewRow(ABAtena1HyojunEntity.HYOJUNSHOJOJIYUCD) = csDataRow(ABAtenaRirekiHyojunEntity.HYOJUNSHOJOJIYUCD);

                        if ((csDataRow(ABAtenaRirekiEntity.ATENADATAKB).ToString == ABConstClass.ATENADATAKB_JUTONAI_KOJIN || csDataRow(ABAtenaRirekiEntity.ATENADATAKB).ToString == ABConstClass.ATENADATAKB_JUTOGAI_KOJIN) && !(csDataRow(ABAtenaRirekiEntity.SHOJOJIYUCD).ToString.Trim == string.Empty))
                        {
                            if (csDataRow(ABAtenaRirekiHyojunEntity.SHOJOIDOWMD).ToString.Trim == string.Empty)
                            {
                                csDataNewRow(ABAtena1HyojunEntity.SHOJOIDOWMD) = m_strShojoIdoWmdHenkan;
                            }
                            else
                            {
                                csDataNewRow(ABAtena1HyojunEntity.SHOJOIDOWMD) = csDataRow(ABAtenaRirekiHyojunEntity.SHOJOIDOWMD);
                            }
                        }
                        else
                        {
                            // ÁœˆÙ“®˜a—ï”NŒŽ“ú
                            csDataNewRow(ABAtena1HyojunEntity.SHOJOIDOWMD) = csDataRow(ABAtenaRirekiHyojunEntity.SHOJOIDOWMD);
                        }
                        // ÁœˆÙ“®“ú•sÚƒpƒ^[ƒ“
                        csDataNewRow(ABAtena1HyojunEntity.SHOJOIDOBIFUSHOPTN) = csDataRow(ABAtenaRirekiHyojunEntity.SHOJOIDOBIFUSHOPTN);
                        // •sÚÁœˆÙ“®“ú
                        csDataNewRow(ABAtena1HyojunEntity.FUSHOSHOJOIDOBI) = csDataRow(ABAtenaRirekiHyojunEntity.FUSHOSHOJOIDOBI);

                        if (!(csDataRow(ABAtenaRirekiHyojunEntity.FUSHOCKINIDOBI).ToString.Trim == string.Empty) && csDataRow(ABAtenaRirekiHyojunEntity.CKINIDOWMD).ToString.Trim == string.Empty)
                        {
                            csDataNewRow(ABAtena1HyojunEntity.CKINIDOWMD) = m_strCknIdoWmdHenkan;
                        }
                        else
                        {
                            // ’¼‹ßˆÙ“®˜a—ï”NŒŽ“ú
                            csDataNewRow(ABAtena1HyojunEntity.CKINIDOWMD) = csDataRow(ABAtenaRirekiHyojunEntity.CKINIDOWMD);
                        }
                        // ’¼‹ßˆÙ“®“ú•sÚƒpƒ^[ƒ“
                        csDataNewRow(ABAtena1HyojunEntity.CKINIDOBIFUSHOPTN) = csDataRow(ABAtenaRirekiHyojunEntity.CKINIDOBIFUSHOPTN);
                        // •sÚ’¼‹ßˆÙ“®“ú
                        csDataNewRow(ABAtena1HyojunEntity.FUSHOCKINIDOBI) = csDataRow(ABAtenaRirekiHyojunEntity.FUSHOCKINIDOBI);
                        // Ž–ŽÀã‚Ì¢‘ÑŽå
                        csDataNewRow(ABAtena1HyojunEntity.JIJITSUSTAINUSMEI) = csDataRow(ABAtenaRirekiHyojunEntity.JIJITSUSTAINUSMEI);
                        if (cAtenaGetPara1.p_strJukiJutogaiKB == "1")
                        {
                            // ZŠ_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.SHIKUCHOSONCD) = csDataRow(ABAtenaRirekiHyojunEntity.JUKISHIKUCHOSONCD);
                            // ZŠ_’¬ŽšƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.MACHIAZACD) = csDataRow(ABAtenaRirekiHyojunEntity.JUKIMACHIAZACD);
                            // ZŠ_“s“¹•{Œ§
                            csDataNewRow(ABAtena1HyojunEntity.TODOFUKEN) = csDataRow(ABAtenaRirekiHyojunEntity.JUKITODOFUKEN);
                            // ZŠ_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABAtena1HyojunEntity.SHIKUCHOSON) = csDataRow(ABAtenaRirekiHyojunEntity.JUKISHIKUCHOSON);
                            // ZŠ_’¬Žš
                            csDataNewRow(ABAtena1HyojunEntity.MACHIAZA) = csDataRow(ABAtenaRirekiHyojunEntity.JUKIMACHIAZA);
                        }
                        else
                        {
                            // ZŠ_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.SHIKUCHOSONCD) = csDataRow(ABAtenaRirekiHyojunEntity.SHIKUCHOSONCD);
                            // ZŠ_’¬ŽšƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.MACHIAZACD) = csDataRow(ABAtenaRirekiHyojunEntity.MACHIAZACD);
                            // ZŠ_“s“¹•{Œ§
                            csDataNewRow(ABAtena1HyojunEntity.TODOFUKEN) = csDataRow(ABAtenaRirekiHyojunEntity.TODOFUKEN);
                            // ZŠ_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABAtena1HyojunEntity.SHIKUCHOSON) = csDataRow(ABAtenaRirekiHyojunEntity.SHIKUCHOSON);
                            // ZŠ_’¬Žš
                            csDataNewRow(ABAtena1HyojunEntity.MACHIAZA) = csDataRow(ABAtenaRirekiHyojunEntity.MACHIAZA);
                        }
                        if (m_strHonsekiHittoshKB_Param == "1" && m_strHonsekiHittoshKB == "1")
                        {
                            // –{Ð_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.HON_SHIKUCHOSONCD) = csDataRow(ABAtenaRirekiHyojunEntity.HON_SHIKUCHOSONCD);
                            // –{Ð_’¬ŽšƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.HON_MACHIAZACD) = csDataRow(ABAtenaRirekiHyojunEntity.HON_MACHIAZACD);
                            // –{Ð_“s“¹•{Œ§
                            csDataNewRow(ABAtena1HyojunEntity.HON_TODOFUKEN) = csDataRow(ABAtenaRirekiHyojunEntity.HON_TODOFUKEN);
                            // –{Ð_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABAtena1HyojunEntity.HON_SHIKUGUNCHOSON) = csDataRow(ABAtenaRirekiHyojunEntity.HON_SHIKUGUNCHOSON);
                            // –{Ð_’¬Žš
                            csDataNewRow(ABAtena1HyojunEntity.HON_MACHIAZA) = csDataRow(ABAtenaRirekiHyojunEntity.HON_MACHIAZA);
                        }
                        if (m_blnMethodKB != ABEnumDefine.MethodKB.KB_Kaigo && (strGyomuMei ?? "") != NENKIN && (strGyomuMei ?? "") != NENKIN_2)
                        {
                            // ‘ÐƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.KOKUSEKICD) = csDataRow(ABAtenaRirekiEntity.KOKUSEKICD);
                        }
                        if ((strGyomuMei ?? "") == NENKIN | (strGyomuMei ?? "") == NENKIN_2)
                        {
                            // “]“ü‘OZŠ_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_SHIKUCHOSONCD) = csDataRow(ABAtenaRirekiHyojunEntity.TENUMAEJ_SHIKUCHOSONCD);
                            // “]“ü‘O’¬ŽšƒR[ƒh
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_MACHIAZACD) = csDataRow(ABAtenaRirekiHyojunEntity.TENUMAEJ_MACHIAZACD);
                            // “]“ü‘OZŠ_“s“¹•{Œ§
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_TODOFUKEN) = csDataRow(ABAtenaRirekiHyojunEntity.TENUMAEJ_TODOFUKEN);
                            // “]“ü‘OZŠ_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_SHIKUCHOSON) = csDataRow(ABAtenaRirekiHyojunEntity.TENUMAEJ_SHIKUCHOSON);
                            // “]“ü‘OZŠ_’¬Žš
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_MACHIAZA) = csDataRow(ABAtenaRirekiHyojunEntity.TENUMAEJ_MACHIAZA);
                            // “]“ü‘OZŠ_‘–¼ƒR[ƒh
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_KOKUSEKICD) = csDataRow(ABAtenaRirekiHyojunEntity.TENUMAEJ_KOKUSEKICD);
                            // “]“ü‘OZŠ_‘–¼
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_KOKUSEKI) = csDataRow(ABAtenaRirekiHyojunEntity.TENUMAEJ_KOKUSEKI);
                            // “]“ü‘OZŠ_‘ŠOZŠ
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_KOKUGAIJUSHO) = csDataRow(ABAtenaRirekiHyojunEntity.TENUMAEJ_KOKUGAIJUSHO);
                            // “]oŠm’è_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTISHIKUCHOSONCD) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUKKTISHIKUCHOSONCD);
                            // “]oŠm’è’¬ŽšƒR[ƒh
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTIMACHIAZACD) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUKKTIMACHIAZACD);
                            // “]oŠm’è_“s“¹•{Œ§
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTITODOFUKEN) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUKKTITODOFUKEN);
                            // “]oŠm’è_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTISHIKUCHOSON) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUKKTISHIKUCHOSON);
                            // “]oŠm’è_’¬Žš
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTIMACHIAZA) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUKKTIMACHIAZA);
                            // “]o—\’è_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEISHIKUCHOSONCD) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEISHIKUCHOSONCD);
                            // “]o—\’è’¬ŽšƒR[ƒh
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIMACHIAZACD) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEIMACHIAZACD);
                            // “]o—\’è_“s“¹•{Œ§
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEITODOFUKEN) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEITODOFUKEN);
                            // “]o—\’è_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEISHIKUCHOSON) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEISHIKUCHOSON);
                            // “]o—\’è_’¬Žš
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIMACHIAZA) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEIMACHIAZA);
                            // “]o—\’è_‘–¼ƒR[ƒh
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIKOKUSEKICD) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEIKOKUSEKICD);
                            // “]o—\’è_‘–¼“™
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIKOKUSEKI) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEIKOKUSEKI);
                            // “]o—\’è_‘ŠOZŠ
                            csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIKOKUGAIJUSHO) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEIKOKUGAIJUSHO);
                        }
                        if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_Kaigo)
                        {
                            // “]“ü‘OZŠ_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_SHIKUCHOSONCD) = csDataRow(ABAtenaRirekiHyojunEntity.TENUMAEJ_SHIKUCHOSONCD);
                            // “]“ü‘O’¬ŽšƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_MACHIAZACD) = csDataRow(ABAtenaRirekiHyojunEntity.TENUMAEJ_MACHIAZACD);
                            // “]“ü‘OZŠ_“s“¹•{Œ§
                            csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_TODOFUKEN) = csDataRow(ABAtenaRirekiHyojunEntity.TENUMAEJ_TODOFUKEN);
                            // “]“ü‘OZŠ_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_SHIKUCHOSON) = csDataRow(ABAtenaRirekiHyojunEntity.TENUMAEJ_SHIKUCHOSON);
                            // “]“ü‘OZŠ_’¬Žš
                            csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_MACHIAZA) = csDataRow(ABAtenaRirekiHyojunEntity.TENUMAEJ_MACHIAZA);
                            // “]“ü‘OZŠ_‘–¼ƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_KOKUSEKICD) = csDataRow(ABAtenaRirekiHyojunEntity.TENUMAEJ_KOKUSEKICD);
                            // “]“ü‘OZŠ_‘–¼
                            csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_KOKUSEKI) = csDataRow(ABAtenaRirekiHyojunEntity.TENUMAEJ_KOKUSEKI);
                            // “]“ü‘OZŠ_‘ŠOZŠ
                            csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_KOKUGAIJUSHO) = csDataRow(ABAtenaRirekiHyojunEntity.TENUMAEJ_KOKUGAIJUSHO);
                            // “]oŠm’è_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTISHIKUCHOSONCD) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUKKTISHIKUCHOSONCD);
                            // “]oŠm’è’¬ŽšƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTIMACHIAZACD) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUKKTIMACHIAZACD);
                            // “]oŠm’è_“s“¹•{Œ§
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTITODOFUKEN) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUKKTITODOFUKEN);
                            // “]oŠm’è_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTISHIKUCHOSON) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUKKTISHIKUCHOSON);
                            // “]oŠm’è_’¬Žš
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTIMACHIAZA) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUKKTIMACHIAZA);
                            // “]o—\’è_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEISHIKUCHOSONCD) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEISHIKUCHOSONCD);
                            // “]o—\’è’¬ŽšƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIMACHIAZACD) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEIMACHIAZACD);
                            // “]o—\’è_“s“¹•{Œ§
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEITODOFUKEN) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEITODOFUKEN);
                            // “]o—\’è_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEISHIKUCHOSON) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEISHIKUCHOSON);
                            // “]o—\’è_’¬Žš
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIMACHIAZA) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEIMACHIAZA);
                            // “]o—\’è_‘–¼ƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIKOKUSEKICD) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEIKOKUSEKICD);
                            // “]o—\’è_‘–¼“™
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIKOKUSEKI) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEIKOKUSEKI);
                            // “]o—\’è_‘ŠOZŠ
                            csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIKOKUGAIJUSHO) = csDataRow(ABAtenaRirekiHyojunEntity.TENSHUTSUYOTEIKOKUGAIJUSHO);
                        }
                        else
                        {
                        }
                        // –@‘æ30ð46–”‚Í47‹æ•ª
                        csDataNewRow(ABAtena1HyojunEntity.HODAI30JO46MATAHA47KB) = csDataRow(ABAtenaRirekiFZYHyojunEntity.HODAI30JO46MATAHA47KB);
                        // Ý—¯ƒJ[ƒh“™”Ô†‹æ•ª
                        csDataNewRow(ABAtena1HyojunEntity.ZAIRYUCARDNOKBN) = csDataRow(ABAtenaRirekiFZYHyojunEntity.ZAIRYUCARDNOKBN);
                        // Z‹’n•â³ƒR[ƒh
                        csDataNewRow(ABAtena1HyojunEntity.JUKYOCHIHOSEICD) = csDataRow(ABAtenaRirekiFZYHyojunEntity.JUKYOCHIHOSEICD);
                        // ’¼‹ß“Ío’Ê’m‹æ•ª
                        csDataNewRow(ABAtena1HyojunEntity.CKINTDKDTUCIKB) = csDataRow(ABAtenaRirekiEntity.CKINTDKDTUCIKB);
                        // ”Å”Ô†
                        csDataNewRow(ABAtena1HyojunEntity.HANNO) = csDataRow(ABAtenaRirekiEntity.HANNO);
                        // ‰ü»”NŒŽ“ú
                        csDataNewRow(ABAtena1HyojunEntity.KAISEIYMD) = csDataRow(ABAtenaRirekiEntity.KAISEIYMD);
                        // ˆÙ“®‹æ•ª
                        csDataNewRow(ABAtena1HyojunEntity.HYOJUNIDOKB) = csDataRow(ABAtenaRirekiHyojunEntity.HYOJUNIDOKB);
                        // “ü—ÍêŠƒR[ƒh
                        csDataNewRow(ABAtena1HyojunEntity.NYURYOKUBASHOCD) = csDataRow(ABAtenaRirekiHyojunEntity.NYURYOKUBASHOCD);
                        // “ü—ÍêŠ•\‹L
                        csDataNewRow(ABAtena1HyojunEntity.NYURYOKUBASHO) = csDataRow(ABAtenaRirekiHyojunEntity.NYURYOKUBASHO);
                        if ((strGyomuMei ?? "") == KOBETSU & string.IsNullOrEmpty(strDainoKB.Trim()))
                        {
                            // ‰îŒì_”í•ÛŒ¯ŽÒŠY“–—L–³
                            csDataNewRow(ABAtena1KobetsuHyojunEntity.KAIGOHIHOKENSHAGAITOKB) = csDataRow(ABAtena1KobetsuHyojunEntity.KAIGOHIHOKENSHAGAITOKB);
                            // ‘•Û_”í•ÛŒ¯ŽÒŠY“–—L–³
                            csDataNewRow(ABAtena1KobetsuHyojunEntity.KOKUHOHIHOKENSHAGAITOKB) = csDataRow(ABAtena1KobetsuHyojunEntity.KOKUHOHIHOKENSHAGAITOKB);
                            // ”N‹à_”í•ÛŒ¯ŽÒŠY“–—L–³
                            csDataNewRow(ABAtena1KobetsuHyojunEntity.NENKINHIHOKENSHAGAITOKB) = csDataRow(ABAtena1KobetsuHyojunEntity.NENKINHIHOKENSHAGAITOKB);
                            // ”N‹à_Ží•Ê•ÏX”NŒŽ“ú
                            csDataNewRow(ABAtena1KobetsuHyojunEntity.NENKINSHUBETSUHENKOYMD) = csDataRow(ABAtena1KobetsuHyojunEntity.NENKINSHUBETSUHENKOYMD);
                            // ‘I‹“_ó‘Ô‹æ•ª
                            csDataNewRow(ABAtena1KobetsuHyojunEntity.SENKYOTOROKUJOTAIKBN) = csDataRow(ABAtena1KobetsuHyojunEntity.SENKYOTOROKUJOTAIKBN);
                            if (m_strKobetsuShutokuKB == "1")
                            {
                                // ŒãŠú‚—î_”í•ÛŒ¯ŽÒŠY“–—L–³
                                csDataNewRow(ABAtena1KobetsuHyojunEntity.KOKIKOREIHIHOKENSHAGAITOKB) = csDataRow(ABAtena1KobetsuHyojunEntity.KOKIKOREIHIHOKENSHAGAITOKB);
                            }
                        }
                        // ˜A—æ‹æ•ªi˜A—æj
                        csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKIKB) = string.Empty;
                        // ˜A—æ–¼
                        csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKIMEI) = string.Empty;
                        // ˜A—æ1i˜A—æj
                        csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKI1_RENRAKUSAKI) = string.Empty;
                        // ˜A—æ2i˜A—æj
                        csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKI2_RENRAKUSAKI) = string.Empty;
                        // ˜A—æ3i˜A—æj
                        csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKI3_RENRAKUSAKI) = string.Empty;
                        // ˜A—æŽí•Ê1
                        csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU1) = string.Empty;
                        // ˜A—æŽí•Ê2
                        csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU2) = string.Empty;
                        // ˜A—æŽí•Ê3
                        csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU3) = string.Empty;
                        // * —š—ð”Ô† 000051 2023/10/19 C³ŠJŽn
                        // If (strGyomuMei <> NENKIN AndAlso strGyomuMei <> NENKIN_2) Then
                        if ((strGyomuMei ?? "") != NENKIN && (strGyomuMei ?? "") != NENKIN_2 && csDataRow.Table.Columns.Contains(ABFugenjuJohoEntity.FUGENJUKB))
                        {
                            // * —š—ð”Ô† 000051 2023/10/19 C³I—¹
                            // •sŒ»Z‹æ•ª
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUKB) = csDataRow(ABFugenjuJohoEntity.FUGENJUKB);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_—X•Ö”Ô†
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_YUBINNO) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_YUBINNO);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_SHICHOSONCD) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_SHICHOSONCD);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_’¬ŽšƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_MACHIAZACD) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_MACHIAZACD);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_“s“¹•{Œ§
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_TODOFUKEN) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_TODOFUKEN);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_SHIKUGUNCHOSON) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_SHIKUGUNCHOSON);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_’¬Žš
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_MACHIAZA) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_MACHIAZA);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_”Ô’n†•\‹L
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_BANCHI) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_BANCHI);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_•û‘
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_KATAGAKI) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_KATAGAKI);
                            // •sŒ»Z‚¾‚Á‚½ZŠ_•û‘_ƒtƒŠƒKƒi
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_KANAKATAGAKI) = csDataRow(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_KANAKATAGAKI);
                            // •sŒ»Zî•ñi‘ÎÛŽÒ‹æ•ªj
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUJOHO_TAISHOSHAKUBUN) = csDataRow(ABFugenjuJohoEntity.FUGENJUJOHO_TAISHOSHAKUBUN);
                            // •sŒ»Zî•ñi‘ÎÛŽÒŽ–¼j
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUJOHO_TAISHOSHASHIMEI) = csDataRow(ABFugenjuJohoEntity.FUGENJUJOHO_TAISHOSHASHIMEI);
                            // •sŒ»Zî•ñi¶”NŒŽ“új
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUJOHO_UMAREYMD) = csDataRow(ABFugenjuJohoEntity.FUGENJUJOHO_UMAREYMD);
                            // •sŒ»Zî•ñi«•Êj
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUJOHO_SEIBETSU) = csDataRow(ABFugenjuJohoEntity.FUGENJUJOHO_SEIBETSU);
                            // ‹Z•s–¾”NŒŽ“ú
                            csDataNewRow(ABAtena1HyojunEntity.KYOJUFUMEI_YMD) = csDataRow(ABFugenjuJohoEntity.KYOJUFUMEI_YMD);
                            // •sŒ»Zî•ñi”õlj
                            csDataNewRow(ABAtena1HyojunEntity.FUGENJUJOHO_BIKO) = csDataRow(ABFugenjuJohoEntity.FUGENJUJOHO_BIKO);
                        }
                        else
                        {
                        }
                        if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                        {
                            // ”Ô†–@XV‹æ•ª
                            csDataNewRow(ABAtena1HyojunEntity.BANGOHOKOSHINKB) = csDataRow(ABMyNumberHyojunEntity.BANGOHOKOSHINKB);
                        }
                        // * —š—ð”Ô† 000051 2023/10/19 C³ŠJŽn
                        // If (m_blnMethodKB = ABEnumDefine.MethodKB.KB_AtenaGet1) AndAlso (strGyomuMei <> NENKIN) AndAlso (strGyomuMei <> NENKIN_2) Then
                        if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_AtenaGet1 && (strGyomuMei ?? "") != NENKIN && (strGyomuMei ?? "") != NENKIN_2 && csDataRow.Table.Columns.Contains(ABDENSHISHOMEISHOMSTEntity.SERIALNO))
                        {
                            // * —š—ð”Ô† 000051 2023/10/19 C³I—¹
                            // ƒVƒŠƒAƒ‹”Ô†
                            csDataNewRow(ABAtena1HyojunEntity.SERIALNO) = csDataRow(ABDENSHISHOMEISHOMSTEntity.SERIALNO);
                        }
                        // •W€€‹’ˆÙ“®Ž–—RƒR[ƒh
                        csDataNewRow(ABAtena1HyojunEntity.HYOJUNIDOJIYUCD) = csDataRow(ABAtenaRirekiHyojunEntity.HYOJUNIDOJIYUCD);
                        if ((strGyomuMei ?? "") != NENKIN && (strGyomuMei ?? "") != NENKIN_2)
                        {
                            // ˜A—æ‹æ•ªi‘—•tæj
                            csDataNewRow(ABAtena1HyojunEntity.SFSKRENRAKUSAKIKB) = string.Empty;
                            // ‘—•tæ‹æ•ª
                            csDataNewRow(ABAtena1HyojunEntity.SFSKKBN) = string.Empty;
                        }
                        else
                        {
                        }

                        strAtenaDataKB = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.ATENADATAKB)).Trim;
                        strAtenaDataSHU = Conversions.ToString(csDataRow(ABAtenaRirekiEntity.ATENADATASHU)).Trim;
                        m_cABHyojunkaCdHenshuB.HenshuHyojunkaCd(strAtenaDataKB, strAtenaDataSHU);
                        // Z–¯‹æ•ª
                        csDataNewRow(ABAtena1HyojunEntity.JUMINKBN) = m_cABHyojunkaCdHenshuB.p_strJuminKbn;
                        // Z–¯Ží•Ê
                        csDataNewRow(ABAtena1HyojunEntity.JUMINSHUBETSU) = m_cABHyojunkaCdHenshuB.p_strJuminShubetsu;
                        // Z–¯ó‘Ô
                        csDataNewRow(ABAtena1HyojunEntity.JUMINJOTAI) = m_cABHyojunkaCdHenshuB.p_strJuminJotai;
                        if (cAtenaGetPara1.p_strJukiJutogaiKB == "1")
                        {
                            // ”Ô’nŽ}”Ô”’l
                            csDataNewRow(ABAtena1HyojunEntity.BANCHIEDABANSUCHI) = csDataRow(ABAtenaRirekiHyojunEntity.JUKIBANCHIEDABANSUCHI);
                        }
                        else
                        {
                            // ”Ô’nŽ}”Ô”’l
                            csDataNewRow(ABAtena1HyojunEntity.BANCHIEDABANSUCHI) = csDataRow(ABAtenaRirekiHyojunEntity.BANCHIEDABANSUCHI);
                        }
                    }
                    else
                    {
                        // noop
                    }

                    // ƒf[ƒ^ƒŒƒR[ƒh‚Ì’Ç‰Á
                    csDataTable.Rows.Add(csDataNewRow);

                    // *—š—ð”Ô† 000017 2003/10/09 C³I—¹

                }

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException exException)
            {

                // ƒGƒ‰[ƒƒOo—Í
                m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default
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
                                                    "yƒGƒ‰[“
               */
);
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 357851


                Input:
                " + exException.Message + "z")

                            ' ƒXƒ[‚·‚é
                            Throw exException

                        Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                      "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 358143


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                      "yƒƒ\ƒbƒh–¼:
                 */
                ;

                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 358224


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                      "yƒGƒ‰[“à—e:" + exException.Message + "z")

                                 */
                throw exException;

            }

            return csAtena1;

        }
        #endregion

        #region  ‘—•tæ•ÒW(SofusakiHenshu) 
        // *—š—ð”Ô† 000019 2003/11/19 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘—•tæ•ÒW
        // * 
        // * \•¶           Public Function SofusakiHenshu(ByVal csAtena1 As DataSet, _
        // *                                              ByVal csSfskEntity As DataSet, _
        // *                                              ByVal cAtenaGetPara1 As ABAtenaGetPara1) As DataSet
        // * 
        // * ‹@”\@@    @ •ÒWˆ¶–¼ƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”           csAtena1              : ˆ¶–¼—š—ðƒf[ƒ^
        // *               csSfskEntity           : ‘—•tæƒf[ƒ^
        // *               cAtenaGetPara1         : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // * 
        // * –ß‚è’l         DataSet(ABAtena12)    : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        public DataSet SofusakiHenshu(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtena1, DataSet csSfskEntity)
        {
            return SofusakiHenshu(cAtenaGetPara1, csAtena1, csSfskEntity, string.Empty);
        }
        // *—š—ð”Ô† 000019 2003/11/19 ’Ç‰ÁI—¹

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘—•tæ•ÒW
        // * 
        // * \•¶           Public Function SofusakiHenshu(ByVal csAtena1 As DataSet, _
        // *                                              ByVal csSfskEntity As DataSet, _
        // *                                              ByVal cAtenaGetPara1 As ABAtenaGetPara1) As DataSet
        // * 
        // * ‹@”\@@    @ •ÒWˆ¶–¼ƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”           csAtena1              : ˆ¶–¼Žæ“¾ƒf[ƒ^
        // *               csSfskEntity           : ‘—•tæƒf[ƒ^
        // *               cAtenaGetPara1         : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // *               strGyomuMei            : ‹Æ–±–¼
        // * 
        // * –ß‚è’l         DataSet(ABAtena12)    : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        // *—š—ð”Ô† 000019 2003/11/19 C³ŠJŽn
        // Public Overloads Function SofusakiHenshu(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass, _
        // ByVal csAtena1 As DataSet, _
        // ByVal csSfskEntity As DataSet) As DataSet
        [SecuritySafeCritical]
        private DataSet SofusakiHenshu(ABAtenaGetPara1XClass cAtenaGetPara1, DataSet csAtena1, DataSet csSfskEntity, string strGyomuMei)
        {
            // *—š—ð”Ô† 000019 2003/11/19 C³I—¹
            const string THIS_METHOD_NAME = "SofusakiHenshu";
            // Dim cfErrorClass As UFErrorClass                    'ƒGƒ‰[ˆ—ƒNƒ‰ƒX
            // Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì
            // * corresponds to VS2008 Start 2010/04/16 000039
            // Dim csDataSet As DataSet
            // * corresponds to VS2008 End 2010/04/16 000039
            // * —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
            // Dim cuUSSCityInfo As USSCityInfoClass               'Žs’¬‘ºî•ñŠÇ—ƒNƒ‰ƒX
            // * —š—ð”Ô† 000023 2004/08/27 íœI—¹
            DataTable csDataTable;                          // ˆ¶–¼î•ñ“ü—ÍRow
            DataSet csAtena12;                            // ˆ¶–¼î•ñ(ABAtena1)
            DataRow csDataNewRow;                         // ˆ¶–¼î•ño—ÍRow
            DataRow csSfskRow;                            // ‘—•tæDataRow
                                                          // * —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                                                          // Dim cABKannaiKangaiKBB As ABKannaiKangaiKBBClass    'ŠÇ“àŠÇŠOƒNƒ‰ƒX
                                                          // * —š—ð”Ô† 000023 2004/08/27 íœI—¹
            string strHenshuJusho;                        // •ÒWZŠ
                                                          // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁŠJŽn
                                                          // *—š—ð”Ô† 000016 2003/08/22 íœŠJŽn
                                                          // Dim cURKanriJohoB As URKANRIJOHOBClass              'ŠÇ—î•ñŽæ“¾ƒNƒ‰ƒX
                                                          // *—š—ð”Ô† 000016 2003/08/22 íœI—¹
            SofuJushoGyoseikuType cSofuJushoGyoseikuType;
            var strJushoHenshu3 = default(string);                       // ZŠ•ÒW‚R
            var strJushoHenshu4 = default(string);                       // ZŠ•ÒW‚S
                                                                         // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁI—¹
                                                                         // *—š—ð”Ô† 000019 2003/11/19 ’Ç‰ÁŠJŽn
            DataTable dsAtena1Table;                      // ˆ¶–¼Žæ“¾ƒf[ƒ^Table
                                                          // *—š—ð”Ô† 000019 2003/11/19 ’Ç‰ÁI—¹
                                                          // * —š—ð”Ô† 000029 2007/01/25 ’Ç‰ÁŠJŽn
            URBANCHICDMSTBClass crBanchiCdMstB;           // UR”Ô’nƒR[ƒhƒ}ƒXƒ^ƒNƒ‰ƒX
            string[] strBanchiCD;                         // ”Ô’nƒR[ƒhŽæ“¾—p”z—ñ
            var strMotoBanchiCD = default(string[]);                     // •ÏX‘O”Ô’nƒR[ƒh
                                                                         // * —š—ð”Ô† 000029 2007/01/25 ’Ç‰ÁI—¹
                                                                         // *—š—ð”Ô† 000037 2008/11/17 ’Ç‰ÁŠJŽn
            int intLoop;                              // ƒ‹[ƒvƒJƒEƒ“ƒ^
                                                      // *—š—ð”Ô† 000037 2008/11/17 ’Ç‰ÁI—¹
            string strWork;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // 'ƒGƒ‰[ˆ—ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // '*—š—ð”Ô† 000010  2003/03/27 C³ŠJŽn
                // 'cfErrorClass = New UFErrorClass(m_cfUFControlData.m_strBusinessId)
                // cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                // '*—š—ð”Ô† 000010  2003/03/27 C³I—¹

                // *—š—ð”Ô† 000019 2003/11/19 C³ŠJŽn
                // 'ƒJƒ‰ƒ€î•ñì¬
                // csAtena12 = New DataSet()
                // csAtena12.Tables.Add(Me.CreateAtena1Columns())

                // ƒJƒ‰ƒ€î•ñì¬
                switch (strGyomuMei ?? "")
                {
                    // *—š—ð”Ô† 000027 2006/07/31 C³ŠJŽn
                    case NENKIN:
                    case NENKIN_2:    // ”N‹àˆ¶–¼î•ñ
                        {
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                csDataTable = CreateNenkinAtenaHyojunColumns(strGyomuMei);
                                dsAtena1Table = csAtena1.Tables(ABNenkinAtenaHyojunEntity.TABLE_NAME);
                            }
                            else
                            {
                                csDataTable = CreateNenkinAtenaColumns(strGyomuMei);
                                // Case NENKIN     ' ”N‹àˆ¶–¼î•ñ
                                // csDataTable = Me.CreateNenkinAtenaColumns()
                                // *—š—ð”Ô† 000027 2006/07/31 C³I—¹
                                dsAtena1Table = csAtena1.Tables(ABNenkinAtenaEntity.TABLE_NAME);
                            }

                            break;
                        }
                    case KOBETSU:    // ˆ¶–¼ŒÂ•Êî•ñ
                        {
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                csDataTable = this.CreateAtena1KobetsuHyojunColumns();
                                dsAtena1Table = csAtena1.Tables(ABAtena1KobetsuHyojunEntity.TABLE_NAME);
                            }
                            else
                            {
                                csDataTable = CreateAtena1KobetsuColumns();
                                dsAtena1Table = csAtena1.Tables(ABAtena1KobetsuEntity.TABLE_NAME);
                            }       // ˆ¶–¼î•ñ

                            break;
                        }

                    default:
                        {
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                csDataTable = CreateAtena1HyojunColumns();
                                dsAtena1Table = csAtena1.Tables(ABAtena1HyojunEntity.TABLE_NAME);
                            }
                            else
                            {
                                csDataTable = CreateAtena1Columns();
                                dsAtena1Table = csAtena1.Tables(ABAtena1Entity.TABLE_NAME);
                            }

                            break;
                        }
                }
                csAtena12 = new DataSet();
                csAtena12.Tables.Add(csDataTable);
                // *—š—ð”Ô† 000019 2003/11/19 C³I—¹

                // * —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                // Žs’¬‘ºî•ñ‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cuUSSCityInfo = New USSCityInfoClass()

                // ŠÇ“àŠÇŠO‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cABKannaiKangaiKBB = New ABKannaiKangaiKBBClass(m_cfUFControlData, m_cfUFConfigDataClass)
                // * —š—ð”Ô† 000023 2004/08/27 íœI—¹

                // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁŠJŽn
                // *—š—ð”Ô† 000016 2003/08/22 íœŠJŽn
                // 'ŠÇ—î•ñŽæ“¾‚a‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cURKanriJohoB = New Densan.Reams.UR.UR001BB.URKANRIJOHOBClass(m_cfUFControlData, m_cfUFConfigDataClass, m_cfUFRdbClass)
                // *—š—ð”Ô† 000016 2003/08/22 íœI—¹
                // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁI—¹

                // * —š—ð”Ô† 000029 2007/01/25 ’Ç‰ÁŠJŽn
                // UR”Ô’nƒR[ƒhƒ}ƒXƒ^ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX¶¬
                crBanchiCdMstB = new URBANCHICDMSTBClass(m_cfUFControlData, m_cfUFConfigDataClass, m_cfUFRdbClass);
                // * —š—ð”Ô† 000029 2007/01/25 ’Ç‰ÁI—¹

                // *—š—ð”Ô† 000007 2003/03/17 ’Ç‰ÁŠJŽn
                // ƒpƒ‰ƒ[ƒ^‚Ìƒ`ƒFƒbƒN
                CheckColumnValue(cAtenaGetPara1);
                // *—š—ð”Ô† 000007 2003/03/17 ’Ç‰ÁI—¹

                // * —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                // ZŠ•ÒW‚P‚ª"1"ŠŽ‚ÂZŠ•ÒW‚Q‚ª"1"‚Ìê‡
                // If cAtenaGetPara1.p_strJushoHenshu1 = "1" And cAtenaGetPara1.p_strJushoHenshu2 = "1" Then
                // '’¼‹ß‚ÌŽs’¬‘º–¼‚ðŽæ“¾‚·‚é
                // 'm_cuUSSCityInfo.GetCityInfo(m_cfUFControlData)
                // End If
                // * —š—ð”Ô† 000023 2004/08/27 íœI—¹

                // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁŠJŽn
                // ZŠ•ÒW‚P‚ª"1"ŠŽ‚ÂZŠ•ÒW‚R‚ª""‚Ìê‡
                if (cAtenaGetPara1.p_strJushoHenshu1 == "1" & cAtenaGetPara1.p_strJushoHenshu3 == string.Empty)
                {
                    // *—š—ð”Ô† 000016 2003/08/22 C³ŠJŽn
                    // cSofuJushoGyoseikuType = cURKanriJohoB.GetSofuJushoGyoseiku_SofuJushoGyoseiku_Param

                    cSofuJushoGyoseikuType = this.GetSofuJushoGyoseikuType;
                    // *—š—ð”Ô† 000016 2003/08/22 C³I—¹
                    switch (cSofuJushoGyoseikuType)
                    {
                        case var @case when @case == SofuJushoGyoseikuType.Jusho_Banchi:
                            {
                                strJushoHenshu3 = "1";
                                strJushoHenshu4 = "";
                                break;
                            }
                        case var case1 when case1 == SofuJushoGyoseikuType.Jusho_Banchi_SP_Katagaki:
                            {
                                strJushoHenshu3 = "1";
                                strJushoHenshu4 = "1";
                                break;
                            }
                        case var case2 when case2 == SofuJushoGyoseikuType.Gyoseiku_SP_Banchi:
                            {
                                strJushoHenshu3 = "5";
                                strJushoHenshu4 = "";
                                break;
                            }
                        case var case3 when case3 == SofuJushoGyoseikuType.Gyoseiku_SP_Banchi_SP_Katagaki:
                            {
                                strJushoHenshu3 = "5";
                                strJushoHenshu4 = "1";
                                break;
                            }
                    }
                }
                else
                {
                    strJushoHenshu3 = cAtenaGetPara1.p_strJushoHenshu3;
                    strJushoHenshu4 = cAtenaGetPara1.p_strJushoHenshu4;
                }
                // *—š—ð”Ô† 000008 2003/03/17 ’Ç‰ÁI—¹

                // •ÒWˆ¶–¼ƒf[ƒ^‚ðì¬‚·‚é
                // *—š—ð”Ô† 000017 2003/10/09 C³ŠJŽn
                // For Each csAtena1Row In csAtena1.Tables(ABAtena1Entity.TABLE_NAME).Rows
                // csDataNewRow = csAtena12.Tables(ABAtena1Entity.TABLE_NAME).NewRow

                foreach (DataRow csAtena1Row in dsAtena1Table.Rows)
                {
                    csDataNewRow = csDataTable.NewRow();
                    // *—š—ð”Ô† 000019 2003/11/19 C³I—¹

                    // *—š—ð”Ô† 000037 2008/11/17 ’Ç‰ÁŠJŽn
                    foreach (DataColumn csColumn in csDataNewRow.Table.Columns)
                        csDataNewRow[csColumn] = string.Empty;
                    // *—š—ð”Ô† 000037 2008/11/17 C³I—¹

                    // ‘—•tæƒf[ƒ^ŒŸõ
                    csSfskRow = null;
                    // *—š—ð”Ô† 000002 2003/02/20 C³ŠJŽn
                    // For Each csDataRow In csSfskEntity.Tables(ABSfskEntity.TABLE_NAME).Rows
                    // '*—š—ð”Ô† 000001 2003/02/19 C³ŠJŽn
                    // 'If CType(csAtena1Row(ABAtena1Entity.JUMINCD), String).Trim = CType(csDataRow(ABSfskEntity.JUMINCD), String).Trim _
                    // '        And CType(csAtena1Row(ABAtena1Entity.GYOMUCD), String).Trim = CType(csDataRow(ABSfskEntity.GYOMUCD), String).Trim _
                    // '        And CType(csAtena1Row(ABAtena1Entity.GYOMUNAISHU_CD), String).Trim = CType(csDataRow(ABSfskEntity.GYOMUNAISHU_CD), String).Trim Then
                    // If CType(csAtena1Row(ABAtena1Entity.JUMINCD), String).Trim = CType(csDataRow(ABSfskEntity.JUMINCD), String).Trim _
                    // And CType(csAtena1Row(ABAtena1Entity.GYOMUCD), String).Trim = CType(csDataRow(ABSfskEntity.GYOMUCD), String).Trim _
                    // And CType(csAtena1Row(ABAtena1Entity.GYOMUNAISHU_CD), String).Trim = CType(csDataRow(ABSfskEntity.GYOMUNAISHU_CD), String).Trim Then
                    // '*—š—ð”Ô† 000001 2003/02/19 C³I—¹
                    // csSfskRow = csDataRow
                    // Exit For
                    // End If
                    // Next csDataRow

                    // ‘—•tæƒf[ƒ^‚Í0Œ–”‚Í1Œ—ˆ‚é
                    if (csSfskEntity.Tables(ABSfskEntity.TABLE_NAME).Rows.Count > 0)
                    {
                        csSfskRow = csSfskEntity.Tables(ABSfskEntity.TABLE_NAME).Rows(0);
                    }
                    // *—š—ð”Ô† 000002 2003/02/20 C³I—¹

                    // ‘—•tæ‚ª‘¶Ý‚µ‚È‚¢ê‡
                    if (csSfskRow is null)
                    {

                        csDataNewRow.ItemArray = csAtena1Row.ItemArray;

                        // Z–¯ƒR[ƒh
                        csDataNewRow(ABAtena1Entity.JUMINCD) = csAtena1Row(ABAtena1Entity.JUMINCD);

                        // ‘ã”[‹æ•ªi–{lƒ}ƒXƒ^‚Ì‘ã”[‹æ•ª‚ª"00"‚Ìê‡"40"A‚»‚êˆÈŠO‚Í"50"j
                        if (Conversions.ToString(csAtena1Row(ABAtena1Entity.DAINOKB)) == "00")
                        {
                            // ‘ã”[‹æ•ª
                            csDataNewRow(ABAtena1Entity.DAINOKB) = "40";
                        }
                        else
                        {
                            csDataNewRow(ABAtena1Entity.DAINOKB) = "50";
                        }

                        // ‘ã”[‹æ•ª–¼Ì
                        csDataNewRow(ABAtena1Entity.DAINOKBMEISHO) = string.Empty;

                        // ‘ã”[‹æ•ª—ªŽ®–¼Ì
                        csDataNewRow(ABAtena1Entity.DAINOKBRYAKUMEISHO) = string.Empty;

                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                        if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                        {

                            // *—š—ð”Ô† 000005  2003/02/25 C³ŠJŽn
                            // ‹Æ–±ƒR[ƒh
                            csDataNewRow(ABAtena1Entity.GYOMUCD) = string.Empty;

                            // ‹Æ–±“àŽí•ÊƒR[ƒh
                            csDataNewRow(ABAtena1Entity.GYOMUNAISHU_CD) = string.Empty;
                            // *—š—ð”Ô† 000005  2003/02/25 C³I—¹
                        }
                    }
                    // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                    else
                    {

                        // Z–¯ƒR[ƒh
                        csDataNewRow(ABAtena1Entity.JUMINCD) = csAtena1Row(ABAtena1Entity.JUMINCD);

                        // ‘ã”[‹æ•ªi–{lƒ}ƒXƒ^‚Ì‘ã”[‹æ•ª‚ª"00"‚Ìê‡"40"A‚»‚êˆÈŠO‚Í"50"j
                        if (Conversions.ToString(csAtena1Row(ABAtena1Entity.DAINOKB)) == "00")
                        {
                            // ‘ã”[‹æ•ª
                            csDataNewRow(ABAtena1Entity.DAINOKB) = "40";
                        }
                        else
                        {
                            csDataNewRow(ABAtena1Entity.DAINOKB) = "50";
                        }

                        // ‘ã”[‹æ•ª–¼Ì
                        csDataNewRow(ABAtena1Entity.DAINOKBMEISHO) = string.Empty;

                        // ‘ã”[‹æ•ª—ªŽ®–¼Ì
                        csDataNewRow(ABAtena1Entity.DAINOKBRYAKUMEISHO) = string.Empty;

                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                        if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                        {

                            // *—š—ð”Ô† 000003 2003/02/21 C³ŠJŽn
                            // '‹Æ–±ƒR[ƒh
                            // csDataNewRow(ABAtena1Entity.GYOMUCD) = csAtena1Row(ABAtena1Entity.GYOMUCD)
                            // '‹Æ–±“àŽí•ÊƒR[ƒh
                            // csDataNewRow(ABAtena1Entity.GYOMUNAISHU_CD) = csAtena1Row(ABAtena1Entity.GYOMUNAISHU_CD)

                            // ‹Æ–±ƒR[ƒh
                            csDataNewRow(ABAtena1Entity.GYOMUCD) = csSfskRow(ABSfskEntity.GYOMUCD);

                            // ‹Æ–±“àŽí•ÊƒR[ƒh
                            csDataNewRow(ABAtena1Entity.GYOMUNAISHU_CD) = csSfskRow(ABSfskEntity.GYOMUNAISHU_CD);
                            // *—š—ð”Ô† 000003 2003/02/21 C³I—¹

                        }
                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                        // ‹ŒŽs’¬‘ºƒR[ƒh
                        csDataNewRow(ABAtena1Entity.KYUSHICHOSONCD) = csAtena1Row(ABAtena1Entity.KYUSHICHOSONCD);

                        // ¢‘ÑƒR[ƒh
                        csDataNewRow(ABAtena1Entity.STAICD) = csAtena1Row(ABAtena1Entity.STAICD);

                        // ˆ¶–¼ƒf[ƒ^‹æ•ª
                        csDataNewRow(ABAtena1Entity.ATENADATAKB) = csSfskRow(ABSfskEntity.SFSKDATAKB);

                        // ˆ¶–¼ƒf[ƒ^Ží•Ê
                        csDataNewRow(ABAtena1Entity.ATENADATASHU) = string.Empty;

                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                        if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                        {

                            // •ÒWŽí•Ê
                            csDataNewRow(ABAtena1Entity.HENSHUSHUBETSU) = string.Empty;

                            // •ÒWŽí•Ê—ªÌ
                            csDataNewRow(ABAtena1Entity.HENSHUSHUBETSURYAKU) = string.Empty;

                            // ŒŸõ—pƒJƒi©–¼
                            csDataNewRow(ABAtena1Entity.SEARCHKANASEIMEI) = string.Empty;

                            // ŒŸõ—pƒJƒi©
                            csDataNewRow(ABAtena1Entity.SEARCHKANASEI) = string.Empty;

                            // ŒŸõ—pƒJƒi–¼
                            csDataNewRow(ABAtena1Entity.SEARCHKANAMEI) = string.Empty;

                            // ŒŸõ—pŠ¿Žš–¼Ì
                            csDataNewRow(ABAtena1Entity.SEARCHKANJIMEI) = string.Empty;
                        }
                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                        // •ÒWƒJƒi–¼Ì
                        strWork = Conversions.ToString(csSfskRow(ABSfskEntity.SFSKKANAMEISHO)).Trim;
                        csDataNewRow(ABAtena1Entity.HENSHUKANASHIMEI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_HENSHUKANAMEISHO);

                        // •ÒWŠ¿Žš–¼Ì
                        strWork = Conversions.ToString(csSfskRow(ABSfskEntity.SFSKKANJIMEISHO)).Trim;
                        csDataNewRow(ABAtena1Entity.HENSHUKANJISHIMEI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_HENSHUKANJIMEISHO);

                        if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                        {
                            // •ÒWƒJƒi–¼Ìiƒtƒ‹j
                            csDataNewRow(ABAtena1HyojunEntity.HENSHUKANASHIMEI_FULL) = csSfskRow(ABSfskEntity.SFSKKANAMEISHO);

                            // •ÒWŠ¿Žš–¼Ìiƒtƒ‹j
                            csDataNewRow(ABAtena1HyojunEntity.HENSHUKANJISHIMEI_FULL) = csSfskRow(ABSfskEntity.SFSKKANJIMEISHO);
                        }
                        else
                        {
                        }

                        // ¶”NŒŽ“ú
                        csDataNewRow(ABAtena1Entity.UMAREYMD) = string.Empty;

                        // ¶˜a—ï”NŒŽ“ú
                        csDataNewRow(ABAtena1Entity.UMAREWMD) = string.Empty;

                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                        if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                        {
                            // ¶•\Ž¦”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.UMAREHYOJIWMD) = string.Empty;

                            // ¶Ø–¾”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.UMARESHOMEIWMD) = string.Empty;

                            // «•ÊƒR[ƒh
                            csDataNewRow(ABAtena1Entity.SEIBETSUCD) = string.Empty;

                            // «•Ê
                            csDataNewRow(ABAtena1Entity.SEIBETSU) = string.Empty;

                            // •ÒW‘±•¿ƒR[ƒh
                            csDataNewRow(ABAtena1Entity.HENSHUZOKUGARACD) = string.Empty;

                            // •ÒW‘±•¿
                            csDataNewRow(ABAtena1Entity.HENSHUZOKUGARA) = string.Empty;

                            // –@l‘ã•\ŽÒ–¼
                            csDataNewRow(ABAtena1Entity.HOJINDAIHYOUSHA) = string.Empty;
                        }
                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                        // ŒÂl–@l‹æ•ª
                        csDataNewRow(ABAtena1Entity.KJNHJNKB) = string.Empty;
                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                        if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                        {

                            // ŒÂl–@l‹æ•ª–¼Ì
                            csDataNewRow(ABAtena1Entity.KJNHJNKBMEISHO) = string.Empty;

                            // ŠÇ“àŠÇŠO‹æ•ª–¼Ì
                            csDataNewRow(ABAtena1Entity.NAIGAIKBMEISHO) = m_cABKannaiKangaiKBB.GetKannaiKangai(Conversions.ToString(csSfskRow(ABSfskEntity.SFSKKANNAIKANGAIKB)));
                        }
                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                        // ŠÇ“àŠÇŠO‹æ•ª
                        csDataNewRow(ABAtena1Entity.KANNAIKANGAIKB) = csSfskRow(ABSfskEntity.SFSKKANNAIKANGAIKB);

                        // —X•Ö”Ô†
                        csDataNewRow(ABAtena1Entity.YUBINNO) = csSfskRow(ABSfskEntity.SFSKYUBINNO);

                        // ZŠƒR[ƒh
                        csDataNewRow(ABAtena1Entity.JUSHOCD) = csSfskRow(ABSfskEntity.SFSKZJUSHOCD);

                        // ZŠ
                        csDataNewRow(ABAtena1Entity.JUSHO) = csSfskRow(ABSfskEntity.SFSKJUSHO);

                        // •ÒWZŠ–¼
                        if (cAtenaGetPara1.p_strJushoHenshu1 == string.Empty)
                        {
                            csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = string.Empty;
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •ÒWZŠ–¼iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.HENSHUJUSHO_FULL) = string.Empty;
                            }
                            else
                            {
                            }
                        }

                        else if (cAtenaGetPara1.p_strJushoHenshu1 == "1")
                        {
                            strHenshuJusho = string.Empty;
                            if (cAtenaGetPara1.p_strJushoHenshu2 == "1")
                            {

                                // ŠÇ“à‚Ì‚ÝŽs’¬‘º–¼‚ð•t‰Á‚·‚é
                                if (Conversions.ToString(csSfskRow(ABSfskEntity.SFSKKANNAIKANGAIKB)) == "1")
                                {
                                    strHenshuJusho += m_cuUSSCityInfo.p_strShichosonmei(0);
                                }
                            }
                            // *—š—ð”Ô† 000008 2003/03/17 C³ŠJŽn
                            // Select Case cAtenaGetPara1.p_strJushoHenshu3
                            switch (strJushoHenshu3 ?? "")
                            {
                                // *—š—ð”Ô† 000008 2003/03/17 C³I—¹
                                // * —š—ð”Ô† 000028 2007/01/15 C³ŠJŽn
                                case "1":
                                case "6":   // ZŠ{”Ô’n
                                    {
                                        // Case "1"    'ZŠ{”Ô’n
                                        // * —š—ð”Ô† 000028 2007/01/15 C³I—¹
                                        strHenshuJusho += Conversions.ToString(csSfskRow(ABSfskEntity.SFSKJUSHO)).TrimEnd + Conversions.ToString(csSfskRow(ABSfskEntity.SFSKBANCHI)).TrimEnd;
                                        break;
                                    }
                                case "2":    // s­‹æ{”Ô’n
                                    {
                                        // *—š—ð”Ô† 000009 2003/03/17 C³ŠJŽn
                                        // strHenshuJusho += CType(csSfskRow(ABSfskEntity.SFSKGYOSEIKUMEI), String).TrimEnd _
                                        // + CType(csSfskRow(ABSfskEntity.SFSKBANCHI), String).TrimEnd
                                        // s­‹æ–¼‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csSfskRow(ABSfskEntity.SFSKGYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // ZŠ{”Ô’n
                                            strHenshuJusho += Conversions.ToString(csSfskRow(ABSfskEntity.SFSKJUSHO)).TrimEnd + Conversions.ToString(csSfskRow(ABSfskEntity.SFSKBANCHI)).TrimEnd;
                                        }
                                        else
                                        {
                                            // s­‹æ{”Ô’n
                                            strHenshuJusho += Conversions.ToString(csSfskRow(ABSfskEntity.SFSKGYOSEIKUMEI)).TrimEnd + Conversions.ToString(csSfskRow(ABSfskEntity.SFSKBANCHI)).TrimEnd;
                                        }

                                        break;
                                    }
                                // *—š—ð”Ô† 000009 2003/03/17 C³I—¹
                                case "3":    // ZŠ{is­‹æj{”Ô’n
                                    {
                                        // *—š—ð”Ô† 000004  2003/02/25 C³ŠJŽn
                                        // strHenshuJusho += CType(csSfskRow(ABSfskEntity.SFSKJUSHO), String).TrimEnd _
                                        // + CType(csSfskRow(ABSfskEntity.SFSKGYOSEIKUMEI), String).TrimEnd _
                                        // + CType(csSfskRow(ABSfskEntity.SFSKBANCHI), String).TrimEnd

                                        // s­‹æ–¼‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csSfskRow(ABSfskEntity.SFSKGYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            strHenshuJusho += Conversions.ToString(csSfskRow(ABSfskEntity.SFSKJUSHO)).TrimEnd + Conversions.ToString(csSfskRow(ABSfskEntity.SFSKBANCHI)).TrimEnd;
                                        }
                                        else
                                        {
                                            strHenshuJusho += Conversions.ToString(csSfskRow(ABSfskEntity.SFSKJUSHO)).TrimEnd + "i" + Conversions.ToString(csSfskRow(ABSfskEntity.SFSKGYOSEIKUMEI)).TrimEnd + "j" + Conversions.ToString(csSfskRow(ABSfskEntity.SFSKBANCHI)).TrimEnd;



                                        }

                                        break;
                                    }
                                // *—š—ð”Ô† 000004  2003/02/25 C³I—¹
                                case "4":    // s­‹æ{iZŠj{”Ô’n
                                    {
                                        // *—š—ð”Ô† 000004  2003/02/25 C³ŠJŽn
                                        // strHenshuJusho += CType(csSfskRow(ABSfskEntity.SFSKGYOSEIKUMEI), String).TrimEnd _
                                        // + CType(csSfskRow(ABSfskEntity.SFSKJUSHO), String).TrimEnd _
                                        // + CType(csSfskRow(ABSfskEntity.SFSKBANCHI), String).TrimEnd

                                        // ZŠ‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csSfskRow(ABSfskEntity.SFSKJUSHO)).TrimEnd ?? new char[0]) == "")
                                        {
                                            strHenshuJusho += Conversions.ToString(csSfskRow(ABSfskEntity.SFSKGYOSEIKUMEI)).TrimEnd + Conversions.ToString(csSfskRow(ABSfskEntity.SFSKBANCHI)).TrimEnd;
                                        }
                                        // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁŠJŽn
                                        // s­‹æ–¼‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        else if (new string(Conversions.ToString(csSfskRow(ABSfskEntity.SFSKGYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            strHenshuJusho += Conversions.ToString(csSfskRow(ABSfskEntity.SFSKJUSHO)).TrimEnd + Conversions.ToString(csSfskRow(ABSfskEntity.SFSKBANCHI)).TrimEnd;
                                        }
                                        // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁI—¹
                                        else
                                        {
                                            strHenshuJusho += Conversions.ToString(csSfskRow(ABSfskEntity.SFSKGYOSEIKUMEI)).TrimEnd + "i" + Conversions.ToString(csSfskRow(ABSfskEntity.SFSKJUSHO)).TrimEnd + "j" + Conversions.ToString(csSfskRow(ABSfskEntity.SFSKBANCHI)).TrimEnd;



                                        }

                                        break;
                                    }
                                // *—š—ð”Ô† 000004 2003/02/25 C³I—¹
                                // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁŠJŽn
                                case "5":    // s­‹æ{¢{”Ô’n
                                    {
                                        // s­‹æ–¼‚ª‘¶Ý‚µ‚È‚¢ê‡
                                        if (new string(Conversions.ToString(csSfskRow(ABSfskEntity.SFSKGYOSEIKUMEI)).TrimEnd ?? new char[0]) == "")
                                        {
                                            // ZŠ{”Ô’n
                                            strHenshuJusho += Conversions.ToString(csSfskRow(ABSfskEntity.SFSKJUSHO)).TrimEnd + Conversions.ToString(csSfskRow(ABSfskEntity.SFSKBANCHI)).TrimEnd;
                                        }
                                        else
                                        {
                                            // s­‹æ{¢{”Ô’n
                                            strHenshuJusho += Conversions.ToString(csSfskRow(ABSfskEntity.SFSKGYOSEIKUMEI)).TrimEnd + "@" + Conversions.ToString(csSfskRow(ABSfskEntity.SFSKBANCHI)).TrimEnd;

                                        }

                                        break;
                                    }
                                    // *—š—ð”Ô† 000009 2003/03/17 ’Ç‰ÁI—¹
                            }
                            // *—š—ð”Ô† 000008 2003/03/17 C³ŠJŽn
                            // If cAtenaGetPara1.p_strJushoHenshu4 = "1" Then
                            // * —š—ð”Ô† 000028 2007/01/15 C³ŠJŽn
                            if (strJushoHenshu4 == "1" && new string(Conversions.ToString(csSfskRow(ABSfskEntity.SFSKKATAGAKI)).Trim ?? new char[0]) != "")
                            {
                                // If strJushoHenshu4 = "1" Then
                                // * —š—ð”Ô† 000028 2007/01/15 C³I—¹
                                // *—š—ð”Ô† 000008 2003/03/17 C³I—¹
                                // *—š—ð”Ô† 000004 2003/02/25 C³ŠJŽn
                                // strHenshuJusho += CType(csSfskRow(ABSfskEntity.SFSKKATAGAKI), String).TrimEnd

                                strHenshuJusho += "@" + Conversions.ToString(csSfskRow(ABSfskEntity.SFSKKATAGAKI)).TrimEnd;
                                // *—š—ð”Ô† 000004 2003/02/25 C³I—¹
                            }
                            // * —š—ð”Ô† 000028 2007/01/15 ’Ç‰ÁŠJŽn
                            // ZŠ•ÒW‚Rƒpƒ‰ƒ[ƒ^‚ª‚UAŠŽ‚Âs­‹æ–¼‚ª‚ ‚é‚Æ‚«‚ÍA•ÒWZŠ‚Éis­‹æj‚ð’Ç‰Á‚·‚é
                            if (strJushoHenshu3 == "6" && new string(Conversions.ToString(csSfskRow(ABSfskEntity.SFSKGYOSEIKUMEI)).Trim ?? new char[0]) != "")
                            {
                                strHenshuJusho += "i";
                                strHenshuJusho += Conversions.ToString(csSfskRow(ABSfskEntity.SFSKGYOSEIKUMEI)).TrimEnd;
                                strHenshuJusho += "j";
                            }
                            // * —š—ð”Ô† 000028 2007/01/15 ’Ç‰ÁI—¹
                            // * —š—ð”Ô† 000032 2007/07/09 C³ŠJŽn
                            if (strHenshuJusho.RLength >= 160)
                            {
                                csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = strHenshuJusho.RSubstring(0, 160);
                            }
                            // If strHenshuJusho.Length >= 80 Then
                            // csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = strHenshuJusho.Substring(0, 80)
                            // * —š—ð”Ô† 000032 2007/07/09 C³I—¹
                            else
                            {
                                csDataNewRow(ABAtena1Entity.HENSHUJUSHO) = strHenshuJusho;
                            }
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •ÒWZŠ–¼iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.HENSHUJUSHO_FULL) = strHenshuJusho;
                            }
                            else
                            {
                            }
                        }

                        // * —š—ð”Ô† 000029 2007/01/25 C³ŠJŽn
                        if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                        {
                            // ”Ô’nƒR[ƒh‚P
                            csDataNewRow(ABAtena1Entity.BANCHICD1) = csSfskRow(ABSfskHyojunEntity.SFSKBANCHICD1);

                            // ”Ô’nƒR[ƒh‚Q
                            csDataNewRow(ABAtena1Entity.BANCHICD2) = csSfskRow(ABSfskHyojunEntity.SFSKBANCHICD2);

                            // ”Ô’nƒR[ƒh‚R
                            csDataNewRow(ABAtena1Entity.BANCHICD3) = csSfskRow(ABSfskHyojunEntity.SFSKBANCHICD3);
                        }
                        else if (csSfskRow(ABSfskEntity.SFSKBANCHI) == null == false && new string(Conversions.ToString(csSfskRow(ABSfskEntity.SFSKBANCHI)).Trim ?? new char[0]) != "")
                        {
                            // ”Ô’nî•ñ‚ª‚ ‚éê‡‚ÍAUR‚Ìƒƒ\ƒbƒh‚©‚ç”Ô’n‚ðŽæ“¾‚·‚é
                            // ”Ô’nƒR[ƒhŽæ“¾ƒƒ\ƒbƒh‚ðŒÄ‚Ño‚·
                            strBanchiCD = crBanchiCdMstB.GetBanchiCd(Conversions.ToString(csSfskRow(ABSfskEntity.SFSKBANCHI)), strMotoBanchiCD, true);

                            // Žæ“¾‚µ‚½”Ô’nƒR[ƒh”z—ñ‚ÉNothing‚Ì€–Ú‚ª‚ ‚éê‡‚ÍString.Empty‚ðƒZƒbƒg‚·‚é
                            var loopTo = strBanchiCD.Length - 1;
                            for (intLoop = 0; intLoop <= loopTo; intLoop++)
                            {
                                if (strBanchiCD[intLoop] == null)
                                {
                                    strBanchiCD[intLoop] = string.Empty;
                                }
                            }

                            // ”Ô’nƒR[ƒh‚P
                            csDataNewRow(ABAtena1Entity.BANCHICD1) = strBanchiCD[0];

                            // ”Ô’nƒR[ƒh‚Q
                            csDataNewRow(ABAtena1Entity.BANCHICD2) = strBanchiCD[1];

                            // ”Ô’nƒR[ƒh‚R
                            csDataNewRow(ABAtena1Entity.BANCHICD3) = strBanchiCD[2];
                        }
                        else
                        {
                            // ”Ô’nƒR[ƒh‚P
                            csDataNewRow(ABAtena1Entity.BANCHICD1) = string.Empty;

                            // ”Ô’nƒR[ƒh‚Q
                            csDataNewRow(ABAtena1Entity.BANCHICD2) = string.Empty;

                            // ”Ô’nƒR[ƒh‚R
                            csDataNewRow(ABAtena1Entity.BANCHICD3) = string.Empty;
                        }
                        // * —š—ð”Ô† 000029 2007/01/25 C³I—¹

                        // ”Ô’n
                        if (cAtenaGetPara1.p_strJushoHenshu1 == "1")
                        {
                            // ZŠ•ÒW‚ ‚è‚Ìê‡‚ÍANull
                            csDataNewRow(ABAtena1Entity.BANCHI) = string.Empty;
                        }
                        else
                        {
                            csDataNewRow(ABAtena1Entity.BANCHI) = csSfskRow(ABSfskEntity.SFSKBANCHI);
                        }

                        // •û‘ƒtƒ‰ƒO
                        csDataNewRow(ABAtena1Entity.KATAGAKIFG) = string.Empty;

                        // •û‘ƒR[ƒh
                        csDataNewRow(ABAtena1Entity.KATAGAKICD) = string.Empty;

                        // •û‘
                        if (cAtenaGetPara1.p_strJushoHenshu1 == "1" & cAtenaGetPara1.p_strJushoHenshu4 == "1")
                        {
                            // •û‘•t‰Á‚ ‚è‚Ìê‡‚ÍANull
                            csDataNewRow(ABAtena1Entity.KATAGAKI) = string.Empty;
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •û‘iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.KATAGAKI_FULL) = string.Empty;
                            }
                            else
                            {
                            }
                        }
                        else
                        {
                            strWork = Conversions.ToString(csSfskRow(ABSfskEntity.SFSKKATAGAKI)).Trim;
                            csDataNewRow(ABAtena1Entity.KATAGAKI) = ABStrXClass.Left(strWork, ABAtenaGetConstClass.KETA_KATAGAKI);
                            if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                // •û‘iƒtƒ‹j
                                csDataNewRow(ABAtena1HyojunEntity.KATAGAKI_FULL) = csSfskRow(ABSfskEntity.SFSKKATAGAKI);
                            }
                            else
                            {
                            }
                        }

                        // ˜A—æ‚P
                        csDataNewRow(ABAtena1Entity.RENRAKUSAKI1) = csSfskRow(ABSfskEntity.SFSKRENRAKUSAKI1);

                        // ˜A—æ‚Q
                        csDataNewRow(ABAtena1Entity.RENRAKUSAKI2) = csSfskRow(ABSfskEntity.SFSKRENRAKUSAKI2);

                        // s­‹æƒR[ƒh
                        csDataNewRow(ABAtena1Entity.GYOSEIKUCD) = csSfskRow(ABSfskEntity.SFSKGYOSEIKUCD);

                        // s­‹æ–¼
                        csDataNewRow(ABAtena1Entity.GYOSEIKUMEI) = csSfskRow(ABSfskEntity.SFSKGYOSEIKUMEI);

                        // ’n‹æƒR[ƒh‚P
                        csDataNewRow(ABAtena1Entity.CHIKUCD1) = csSfskRow(ABSfskEntity.SFSKCHIKUCD1);

                        // ’n‹æ‚P
                        csDataNewRow(ABAtena1Entity.CHIKUMEI1) = csSfskRow(ABSfskEntity.SFSKCHIKUMEI1);

                        // ’n‹æƒR[ƒh‚Q
                        csDataNewRow(ABAtena1Entity.CHIKUCD2) = csSfskRow(ABSfskEntity.SFSKCHIKUCD2);

                        // ’n‹æ‚Q
                        csDataNewRow(ABAtena1Entity.CHIKUMEI2) = csSfskRow(ABSfskEntity.SFSKCHIKUMEI2);

                        // ’n‹æƒR[ƒh‚R
                        csDataNewRow(ABAtena1Entity.CHIKUCD3) = csSfskRow(ABSfskEntity.SFSKCHIKUCD3);

                        // ’n‹æ‚R
                        csDataNewRow(ABAtena1Entity.CHIKUMEI3) = csSfskRow(ABSfskEntity.SFSKCHIKUMEI3);

                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                        if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                        {

                            // “o˜^ˆÙ“®”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.TOROKUIDOYMD) = csAtena1Row(ABAtena1Entity.TOROKUIDOYMD);

                            // “o˜^Ž–—RƒR[ƒh
                            csDataNewRow(ABAtena1Entity.TOROKUJIYUCD) = csAtena1Row(ABAtena1Entity.TOROKUJIYUCD);

                            // “o˜^Ž–—R
                            csDataNewRow(ABAtena1Entity.TOROKUJIYU) = csAtena1Row(ABAtena1Entity.TOROKUJIYU);

                            // ÁœˆÙ“®”NŒŽ“ú
                            csDataNewRow(ABAtena1Entity.SHOJOIDOYMD) = csAtena1Row(ABAtena1Entity.SHOJOIDOYMD);

                            // ÁœŽ–—RƒR[ƒh
                            csDataNewRow(ABAtena1Entity.SHOJOJIYUCD) = csAtena1Row(ABAtena1Entity.SHOJOJIYUCD);

                            // ÁœŽ–—R–¼Ì
                            csDataNewRow(ABAtena1Entity.SHOJOJIYU) = csAtena1Row(ABAtena1Entity.SHOJOJIYU);

                            // •ÒW¢‘ÑŽåZ–¯ƒR[ƒh
                            csDataNewRow(ABAtena1Entity.HENSHUNUSHIJUMINCD) = csAtena1Row(ABAtena1Entity.HENSHUNUSHIJUMINCD);
                        }
                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                        // •ÒWƒJƒi¢‘ÑŽå–¼
                        csDataNewRow(ABAtena1Entity.HENSHUKANANUSHIMEI) = csAtena1Row(ABAtena1Entity.HENSHUKANANUSHIMEI);

                        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                        if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                        {
                            // •ÒWŠ¿Žš¢‘ÑŽå–¼
                            csDataNewRow(ABAtena1Entity.HENSHUNUSHIMEI) = csAtena1Row(ABAtena1Entity.HENSHUNUSHIMEI);

                            // •\Ž¦‡i‘æ‚QZ–¯•[•\Ž¦‡‚ª‚ ‚éê‡‚ÍA‘æ‚QZ–¯•[•\Ž¦‡j
                            csDataNewRow(ABAtena1Entity.HYOJIJUN) = csAtena1Row(ABAtena1Entity.HYOJIJUN);

                            // *—š—ð”Ô† 000012 2003/04/18 ’Ç‰ÁŠJŽn
                            // ‘±•¿ƒR[ƒh
                            csDataNewRow(ABAtena1Entity.ZOKUGARACD) = string.Empty;
                            // ‘±•¿
                            csDataNewRow(ABAtena1Entity.ZOKUGARA) = string.Empty;

                            // ƒJƒi–¼Ì‚Q
                            csDataNewRow(ABAtena1Entity.KANAMEISHO2) = string.Empty;
                            // Š¿Žš–¼Ì‚Q
                            csDataNewRow(ABAtena1Entity.KANJIMEISHO2) = string.Empty;

                            // Ð”Ô†
                            csDataNewRow(ABAtena1Entity.SEKINO) = string.Empty;
                            // *—š—ð”Ô† 000012 2003/04/18 ’Ç‰ÁI—¹


                            // *—š—ð”Ô† 000030 2007/04/28 ’Ç‰ÁŠJŽn
                            // ‰îŒì—pƒTƒuƒ‹[ƒ`ƒ“Žæ“¾€–Ú
                            if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_Kaigo)
                            {
                                // ˜A—æ‹Æ–±ƒR[ƒh
                                csDataNewRow(ABNenkinAtenaEntity.RENRAKUSAKI_GYOMUCD) = string.Empty;
                                // ‹Œ©
                                csDataNewRow(ABNenkinAtenaEntity.KYUSEI) = string.Empty;
                                // Z’èˆÙ“®”NŒŽ“ú
                                csDataNewRow(ABNenkinAtenaEntity.JUTEIIDOYMD) = string.Empty;
                                // Z’èŽ–—R
                                csDataNewRow(ABNenkinAtenaEntity.JUTEIJIYU) = string.Empty;
                                // –{Ð‘S‘ZŠƒR[ƒh
                                csDataNewRow(ABNenkinAtenaEntity.HON_ZJUSHOCD) = string.Empty;
                                // “]“ü‘OZŠ—X•Ö”Ô†
                                csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_YUBINNO) = string.Empty;
                                // “]“ü‘OZŠ‘S‘ZŠƒR[ƒh
                                csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_ZJUSHOCD) = string.Empty;
                                // “]“ü‘OZŠZŠ
                                csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_JUSHO) = string.Empty;
                                // “]“ü‘OZŠ”Ô’n
                                csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_BANCHI) = string.Empty;
                                // “]“ü‘OZŠ•û‘
                                csDataNewRow(ABNenkinAtenaEntity.TENUMAEJ_KATAGAKI) = string.Empty;
                                // “]o—\’è—X•Ö”Ô†
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIYUBINNO) = string.Empty;
                                // “]o—\’è‘S‘ZŠƒR[ƒh
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIZJUSHOCD) = string.Empty;
                                // “]o—\’èˆÙ“®”NŒŽ“ú
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIIDOYMD) = string.Empty;
                                // “]o—\’èZŠ
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIJUSHO) = string.Empty;
                                // “]o—\’è”Ô’n
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIBANCHI) = string.Empty;
                                // “]o—\’è•û‘
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEIKATAGAKI) = string.Empty;
                                // “]o—\’è¢‘ÑŽå–¼
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUYOTEISTAINUSMEI) = string.Empty;
                                // “]oŠm’è—X•Ö”Ô†
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIYUBINNO) = string.Empty;
                                // “]oŠm’è‘S‘ZŠƒR[ƒh
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIZJUSHOCD) = string.Empty;
                                // “]oŠm’èˆÙ“®”NŒŽ“ú
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIIDOYMD) = string.Empty;
                                // “]oŠm’è’Ê’m”NŒŽ“ú
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTITSUCHIYMD) = string.Empty;
                                // “]oŠm’èZŠ
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIJUSHO) = string.Empty;
                                // “]oŠm’è”Ô’n
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIBANCHI) = string.Empty;
                                // “]oŠm’è•û‘
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTIKATAGAKI) = string.Empty;
                                // “]oŠm’è¢‘ÑŽå–¼
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUKKTISTAINUSMEI) = string.Empty;
                                // •ÒW‘O”Ô’n
                                csDataNewRow(ABNenkinAtenaEntity.HENSHUMAEBANCHI) = string.Empty;
                                // •ÒW‘O•û‘
                                csDataNewRow(ABNenkinAtenaEntity.HENSHUMAEKATAGAKI) = string.Empty;
                                // Áœ“Ío”NŒŽ“ú
                                csDataNewRow(ABNenkinAtenaEntity.SHOJOTDKDYMD) = string.Empty;
                                // ’¼‹ßŽ–—RƒR[ƒh
                                csDataNewRow(ABNenkinAtenaEntity.CKINJIYUCD) = string.Empty;
                                // ‘ÐƒR[ƒh
                                csDataNewRow(ABNenkinAtenaEntity.KOKUSEKICD) = string.Empty;
                                // “o˜^“Ío”NŒŽ“ú
                                csDataNewRow(ABNenkinAtenaEntity.TOROKUTDKDYMD) = string.Empty;
                                // Z’è“Ío”NŒŽ“ú
                                csDataNewRow(ABNenkinAtenaEntity.JUTEITDKDYMD) = string.Empty;
                                // “]o“ü——R
                                csDataNewRow(ABNenkinAtenaEntity.TENSHUTSUNYURIYU) = string.Empty;
                                // Žs’¬‘ºƒR[ƒh
                                csDataNewRow(ABNenkinAtenaEntity.SHICHOSONCD) = string.Empty;
                                // ’¼‹ßˆÙ“®”NŒŽ“ú
                                csDataNewRow(ABNenkinAtenaEntity.CKINIDOYMD) = string.Empty;
                                // XV“úŽž
                                csDataNewRow(ABNenkinAtenaEntity.KOSHINNICHIJI) = csSfskRow(ABSfskEntity.KOSHINNICHIJI);
                                if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                                {
                                    // “]“ü‘OZŠ•û‘iƒtƒ‹j
                                    csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_KATAGAKI_FULL) = string.Empty;
                                    // “]o—\’è•û‘iƒtƒ‹j
                                    csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIKATAGAKI_FULL) = string.Empty;
                                    // “]oŠm’è•û‘iƒtƒ‹j
                                    csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTIKATAGAKI_FULL) = string.Empty;
                                    // •ÒW‘O•û‘iƒtƒ‹j
                                    csDataNewRow(ABNenkinAtenaHyojunEntity.HENSHUMAEKATAGAKI_FULL) = string.Empty;
                                }
                                else
                                {
                                }
                            }
                            // *—š—ð”Ô† 000030 2007/04/28 ’Ç‰ÁI—¹

                        }
                        // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ

                        if (m_intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                        {
                            // ¢‘ÑŽåŽ–¼—Dæ‹æ•ª
                            csDataNewRow(ABAtena1HyojunEntity.STAINUSSHIMEIYUSENKB) = csAtena1Row(ABAtenaFZYHyojunEntity.STAINUSSHIMEIYUSENKB);
                            // Ž–¼—Dæ€–Ú
                            csDataNewRow(ABAtena1HyojunEntity.SHIMEIYUSENKB) = csAtena1Row(ABAtenaFZYHyojunEntity.SHIMEIYUSENKB);
                            // ‹ŒŽ
                            csDataNewRow(ABAtena1HyojunEntity.KANJIKYUUJI) = string.Empty;
                            // ƒJƒi‹ŒŽ
                            csDataNewRow(ABAtena1HyojunEntity.KANAKYUUJI) = string.Empty;
                            // Ž–¼ƒtƒŠƒKƒiŠm”Fƒtƒ‰ƒO
                            csDataNewRow(ABAtena1HyojunEntity.SHIMEIKANAKAKUNINFG) = string.Empty;
                            // ‹ŒŽƒtƒŠƒKƒiŠm”Fƒtƒ‰ƒO
                            csDataNewRow(ABAtena1HyojunEntity.KYUUJIKANAKAKUNINFG) = string.Empty;
                            // ’ÊÌƒtƒŠƒKƒiŠm”Fƒtƒ‰ƒO
                            csDataNewRow(ABAtena1HyojunEntity.TSUSHOKANAKAKUNINFG) = string.Empty;
                            // ¶”NŒŽ“ú•sÚƒpƒ^[ƒ“
                            csDataNewRow(ABAtena1HyojunEntity.UMAREBIFUSHOPTN) = string.Empty;
                            // •sÚ¶”NŒŽ“ú
                            csDataNewRow(ABAtena1HyojunEntity.FUSHOUMAREBI) = string.Empty;
                            // ‹LÚŽ–—R
                            csDataNewRow(ABAtena1HyojunEntity.HYOJUNKISAIJIYUCD) = csAtena1Row(ABAtenaHyojunEntity.HYOJUNKISAIJIYUCD);
                            // ‹LÚ”NŒŽ“ú
                            csDataNewRow(ABAtena1HyojunEntity.KISAIYMD) = csAtena1Row(ABAtenaHyojunEntity.KISAIYMD);
                            // ÁœŽ–—R
                            csDataNewRow(ABAtena1HyojunEntity.HYOJUNSHOJOJIYUCD) = csAtena1Row(ABAtenaHyojunEntity.HYOJUNSHOJOJIYUCD);
                            // ÁœˆÙ“®˜a—ï”NŒŽ“ú
                            csDataNewRow(ABAtena1HyojunEntity.SHOJOIDOWMD) = csAtena1Row(ABAtenaHyojunEntity.SHOJOIDOWMD);
                            // ÁœˆÙ“®“ú•sÚƒpƒ^[ƒ“
                            csDataNewRow(ABAtena1HyojunEntity.SHOJOIDOBIFUSHOPTN) = csAtena1Row(ABAtenaHyojunEntity.SHOJOIDOBIFUSHOPTN);
                            // •sÚÁœˆÙ“®“ú
                            csDataNewRow(ABAtena1HyojunEntity.FUSHOSHOJOIDOBI) = csAtena1Row(ABAtenaHyojunEntity.FUSHOSHOJOIDOBI);
                            // ’¼‹ßˆÙ“®˜a—ï”NŒŽ“ú
                            csDataNewRow(ABAtena1HyojunEntity.CKINIDOWMD) = csAtena1Row(ABAtenaHyojunEntity.CKINIDOWMD);
                            // ’¼‹ßˆÙ“®“ú•sÚƒpƒ^[ƒ“
                            csDataNewRow(ABAtena1HyojunEntity.CKINIDOBIFUSHOPTN) = csAtena1Row(ABAtenaHyojunEntity.CKINIDOBIFUSHOPTN);
                            // •sÚ’¼‹ßˆÙ“®“ú
                            csDataNewRow(ABAtena1HyojunEntity.FUSHOCKINIDOBI) = csAtena1Row(ABAtenaHyojunEntity.FUSHOCKINIDOBI);
                            // Ž–ŽÀã‚Ì¢‘ÑŽå
                            csDataNewRow(ABAtena1HyojunEntity.JIJITSUSTAINUSMEI) = csAtena1Row(ABAtenaHyojunEntity.JIJITSUSTAINUSMEI);
                            // ZŠ_Žs‹æ’¬‘ºƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.SHIKUCHOSONCD) = csSfskRow(ABSfskHyojunEntity.SFSKSHIKUCHOSONCD);
                            // ZŠ_’¬ŽšƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.MACHIAZACD) = csSfskRow(ABSfskHyojunEntity.SFSKMACHIAZACD);
                            // ZŠ_“s“¹•{Œ§
                            csDataNewRow(ABAtena1HyojunEntity.TODOFUKEN) = csSfskRow(ABSfskHyojunEntity.SFSKTODOFUKEN);
                            // ZŠ_Žs‹æŒS’¬‘º–¼
                            csDataNewRow(ABAtena1HyojunEntity.SHIKUCHOSON) = csSfskRow(ABSfskHyojunEntity.SFSKSHIKUCHOSON);
                            // ZŠ_’¬Žš
                            csDataNewRow(ABAtena1HyojunEntity.MACHIAZA) = csSfskRow(ABSfskHyojunEntity.SFSKMACHIAZA);
                            if (m_strHonsekiHittoshKB_Param == "1" && m_strHonsekiHittoshKB == "1")
                            {
                                // –{Ð_Žs‹æ’¬‘ºƒR[ƒh
                                csDataNewRow(ABAtena1HyojunEntity.HON_SHIKUCHOSONCD) = string.Empty;
                                // –{Ð_’¬ŽšƒR[ƒh
                                csDataNewRow(ABAtena1HyojunEntity.HON_MACHIAZACD) = string.Empty;
                                // –{Ð_“s“¹•{Œ§
                                csDataNewRow(ABAtena1HyojunEntity.HON_TODOFUKEN) = string.Empty;
                                // –{Ð_Žs‹æŒS’¬‘º–¼
                                csDataNewRow(ABAtena1HyojunEntity.HON_SHIKUGUNCHOSON) = string.Empty;
                                // –{Ð_’¬Žš
                                csDataNewRow(ABAtena1HyojunEntity.HON_MACHIAZA) = string.Empty;
                            }
                            if (m_blnMethodKB != ABEnumDefine.MethodKB.KB_Kaigo && (strGyomuMei ?? "") != NENKIN && (strGyomuMei ?? "") != NENKIN_2)
                            {
                                // ‘ÐƒR[ƒh
                                csDataNewRow(ABAtena1HyojunEntity.KOKUSEKICD) = string.Empty;
                            }
                            if ((strGyomuMei ?? "") == NENKIN | (strGyomuMei ?? "") == NENKIN_2)
                            {
                                // “]“ü‘OZŠ_Žs‹æ’¬‘ºƒR[ƒh
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_SHIKUCHOSONCD) = string.Empty;
                                // “]“ü‘O’¬ŽšƒR[ƒh
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_MACHIAZACD) = string.Empty;
                                // “]“ü‘OZŠ_“s“¹•{Œ§
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_TODOFUKEN) = string.Empty;
                                // “]“ü‘OZŠ_Žs‹æŒS’¬‘º–¼
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_SHIKUCHOSON) = string.Empty;
                                // “]“ü‘OZŠ_’¬Žš
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_MACHIAZA) = string.Empty;
                                // “]“ü‘OZŠ_‘–¼ƒR[ƒh
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_KOKUSEKICD) = string.Empty;
                                // “]“ü‘OZŠ_‘–¼
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_KOKUSEKI) = string.Empty;
                                // “]“ü‘OZŠ_‘ŠOZŠ
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENUMAEJ_KOKUGAIJUSHO) = string.Empty;
                                // “]oŠm’è_Žs‹æ’¬‘ºƒR[ƒh
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTISHIKUCHOSONCD) = string.Empty;
                                // “]oŠm’è’¬ŽšƒR[ƒh
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTIMACHIAZACD) = string.Empty;
                                // “]oŠm’è_“s“¹•{Œ§
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTITODOFUKEN) = string.Empty;
                                // “]oŠm’è_Žs‹æŒS’¬‘º–¼
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTISHIKUCHOSON) = string.Empty;
                                // “]oŠm’è_’¬Žš
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTIMACHIAZA) = string.Empty;
                                // “]o—\’è_Žs‹æ’¬‘ºƒR[ƒh
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEISHIKUCHOSONCD) = string.Empty;
                                // “]o—\’è’¬ŽšƒR[ƒh
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIMACHIAZACD) = string.Empty;
                                // “]o—\’è_“s“¹•{Œ§
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEITODOFUKEN) = string.Empty;
                                // “]o—\’è_Žs‹æŒS’¬‘º–¼
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEISHIKUCHOSON) = string.Empty;
                                // “]o—\’è_’¬Žš
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIMACHIAZA) = string.Empty;
                                // “]o—\’è_‘–¼ƒR[ƒh
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIKOKUSEKICD) = string.Empty;
                                // “]o—\’è_‘–¼“™
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIKOKUSEKI) = string.Empty;
                                // “]o—\’è_‘ŠOZŠ
                                csDataNewRow(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIKOKUGAIJUSHO) = string.Empty;
                            }
                            if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_Kaigo)
                            {
                                // “]“ü‘OZŠ_Žs‹æ’¬‘ºƒR[ƒh
                                csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_SHIKUCHOSONCD) = string.Empty;
                                // “]“ü‘O’¬ŽšƒR[ƒh
                                csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_MACHIAZACD) = string.Empty;
                                // “]“ü‘OZŠ_“s“¹•{Œ§
                                csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_TODOFUKEN) = string.Empty;
                                // “]“ü‘OZŠ_Žs‹æŒS’¬‘º–¼
                                csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_SHIKUCHOSON) = string.Empty;
                                // “]“ü‘OZŠ_’¬Žš
                                csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_MACHIAZA) = string.Empty;
                                // “]“ü‘OZŠ_‘–¼ƒR[ƒh
                                csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_KOKUSEKICD) = string.Empty;
                                // “]“ü‘OZŠ_‘–¼
                                csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_KOKUSEKI) = string.Empty;
                                // “]“ü‘OZŠ_‘ŠOZŠ
                                csDataNewRow(ABAtena1HyojunEntity.TENUMAEJ_KOKUGAIJUSHO) = string.Empty;
                                // “]oŠm’è_Žs‹æ’¬‘ºƒR[ƒh
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTISHIKUCHOSONCD) = string.Empty;
                                // “]oŠm’è’¬ŽšƒR[ƒh
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTIMACHIAZACD) = string.Empty;
                                // “]oŠm’è_“s“¹•{Œ§
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTITODOFUKEN) = string.Empty;
                                // “]oŠm’è_Žs‹æŒS’¬‘º–¼
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTISHIKUCHOSON) = string.Empty;
                                // “]oŠm’è_’¬Žš
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUKKTIMACHIAZA) = string.Empty;
                                // “]o—\’è_Žs‹æ’¬‘ºƒR[ƒh
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEISHIKUCHOSONCD) = string.Empty;
                                // “]o—\’è’¬ŽšƒR[ƒh
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIMACHIAZACD) = string.Empty;
                                // “]o—\’è_“s“¹•{Œ§
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEITODOFUKEN) = string.Empty;
                                // “]o—\’è_Žs‹æŒS’¬‘º–¼
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEISHIKUCHOSON) = string.Empty;
                                // “]o—\’è_’¬Žš
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIMACHIAZA) = string.Empty;
                                // “]o—\’è_‘–¼ƒR[ƒh
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIKOKUSEKICD) = string.Empty;
                                // “]o—\’è_‘–¼“™
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIKOKUSEKI) = string.Empty;
                                // “]o—\’è_‘ŠOZŠ
                                csDataNewRow(ABAtena1HyojunEntity.TENSHUTSUYOTEIKOKUGAIJUSHO) = string.Empty;
                            }
                            else
                            {
                            }
                            // –@‘æ30ð46–”‚Í47‹æ•ª
                            csDataNewRow(ABAtena1HyojunEntity.HODAI30JO46MATAHA47KB) = csAtena1Row(ABAtenaFZYHyojunEntity.HODAI30JO46MATAHA47KB);
                            // Ý—¯ƒJ[ƒh“™”Ô†‹æ•ª
                            csDataNewRow(ABAtena1HyojunEntity.ZAIRYUCARDNOKBN) = csAtena1Row(ABAtenaFZYHyojunEntity.ZAIRYUCARDNOKBN);
                            // Z‹’n•â³ƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.JUKYOCHIHOSEICD) = csAtena1Row(ABAtenaFZYHyojunEntity.JUKYOCHIHOSEICD);
                            // ’¼‹ß“Ío’Ê’m‹æ•ª
                            csDataNewRow(ABAtena1HyojunEntity.CKINTDKDTUCIKB) = string.Empty;
                            // ”Å”Ô†
                            csDataNewRow(ABAtena1HyojunEntity.HANNO) = string.Empty;
                            // ‰ü»”NŒŽ“ú
                            csDataNewRow(ABAtena1HyojunEntity.KAISEIYMD) = string.Empty;
                            // ˆÙ“®‹æ•ª
                            csDataNewRow(ABAtena1HyojunEntity.HYOJUNIDOKB) = string.Empty;
                            // “ü—ÍêŠƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.NYURYOKUBASHOCD) = string.Empty;
                            // “ü—ÍêŠ•\‹L
                            csDataNewRow(ABAtena1HyojunEntity.NYURYOKUBASHO) = string.Empty;
                            if ((strGyomuMei ?? "") == KOBETSU)
                            {
                                // ‰îŒì_”í•ÛŒ¯ŽÒŠY“–—L–³
                                csDataNewRow(ABAtena1KobetsuHyojunEntity.KAIGOHIHOKENSHAGAITOKB) = string.Empty;
                                // ‘•Û_”í•ÛŒ¯ŽÒŠY“–—L–³
                                csDataNewRow(ABAtena1KobetsuHyojunEntity.KOKUHOHIHOKENSHAGAITOKB) = string.Empty;
                                // ”N‹à_”í•ÛŒ¯ŽÒŠY“–—L–³
                                csDataNewRow(ABAtena1KobetsuHyojunEntity.NENKINHIHOKENSHAGAITOKB) = string.Empty;
                                // ”N‹à_Ží•Ê•ÏX”NŒŽ“ú
                                csDataNewRow(ABAtena1KobetsuHyojunEntity.NENKINSHUBETSUHENKOYMD) = string.Empty;
                                // ‘I‹“_ó‘Ô‹æ•ª
                                csDataNewRow(ABAtena1KobetsuHyojunEntity.SENKYOTOROKUJOTAIKBN) = string.Empty;
                                if (m_strKobetsuShutokuKB == "1")
                                {
                                    // ŒãŠú‚—î_”í•ÛŒ¯ŽÒŠY“–—L–³
                                    csDataNewRow(ABAtena1KobetsuHyojunEntity.KOKIKOREIHIHOKENSHAGAITOKB) = string.Empty;
                                }
                            }
                            // ˜A—æ‹æ•ªi˜A—æj
                            csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKIKB) = string.Empty;
                            // ˜A—æ–¼
                            csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKIMEI) = string.Empty;
                            // ˜A—æ1i˜A—æj
                            csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKI1_RENRAKUSAKI) = string.Empty;
                            // ˜A—æ2i˜A—æj
                            csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKI2_RENRAKUSAKI) = string.Empty;
                            // ˜A—æ3i˜A—æj
                            csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKI3_RENRAKUSAKI) = string.Empty;
                            // ˜A—æŽí•Ê1
                            csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU1) = string.Empty;
                            // ˜A—æŽí•Ê2
                            csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU2) = string.Empty;
                            // ˜A—æŽí•Ê3
                            csDataNewRow(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU3) = string.Empty;
                            if ((strGyomuMei ?? "") != NENKIN && (strGyomuMei ?? "") != NENKIN_2)
                            {
                                // •sŒ»Z‹æ•ª
                                csDataNewRow(ABAtena1HyojunEntity.FUGENJUKB) = string.Empty;
                                // •sŒ»Z‚¾‚Á‚½ZŠ_—X•Ö”Ô†
                                csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_YUBINNO) = string.Empty;
                                // •sŒ»Z‚¾‚Á‚½ZŠ_Žs‹æ’¬‘ºƒR[ƒh
                                csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_SHICHOSONCD) = string.Empty;
                                // •sŒ»Z‚¾‚Á‚½ZŠ_’¬ŽšƒR[ƒh
                                csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_MACHIAZACD) = string.Empty;
                                // •sŒ»Z‚¾‚Á‚½ZŠ_“s“¹•{Œ§
                                csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_TODOFUKEN) = string.Empty;
                                // •sŒ»Z‚¾‚Á‚½ZŠ_Žs‹æŒS’¬‘º–¼
                                csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_SHIKUGUNCHOSON) = string.Empty;
                                // •sŒ»Z‚¾‚Á‚½ZŠ_’¬Žš
                                csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_MACHIAZA) = string.Empty;
                                // •sŒ»Z‚¾‚Á‚½ZŠ_”Ô’n†•\‹L
                                csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_BANCHI) = string.Empty;
                                // •sŒ»Z‚¾‚Á‚½ZŠ_•û‘
                                csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_KATAGAKI) = string.Empty;
                                // •sŒ»Z‚¾‚Á‚½ZŠ_•û‘_ƒtƒŠƒKƒi
                                csDataNewRow(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_KANAKATAGAKI) = string.Empty;
                                // •sŒ»Zî•ñi‘ÎÛŽÒ‹æ•ªj
                                csDataNewRow(ABAtena1HyojunEntity.FUGENJUJOHO_TAISHOSHAKUBUN) = string.Empty;
                                // •sŒ»Zî•ñi‘ÎÛŽÒŽ–¼j
                                csDataNewRow(ABAtena1HyojunEntity.FUGENJUJOHO_TAISHOSHASHIMEI) = string.Empty;
                                // •sŒ»Zî•ñi¶”NŒŽ“új
                                csDataNewRow(ABAtena1HyojunEntity.FUGENJUJOHO_UMAREYMD) = string.Empty;
                                // •sŒ»Zî•ñi«•Êj
                                csDataNewRow(ABAtena1HyojunEntity.FUGENJUJOHO_SEIBETSU) = string.Empty;
                                // ‹Z•s–¾”NŒŽ“ú
                                csDataNewRow(ABAtena1HyojunEntity.KYOJUFUMEI_YMD) = string.Empty;
                                // •sŒ»Zî•ñi”õlj
                                csDataNewRow(ABAtena1HyojunEntity.FUGENJUJOHO_BIKO) = string.Empty;
                            }
                            else
                            {
                            }
                            if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                            {
                                // ”Ô†–@XV‹æ•ª
                                csDataNewRow(ABAtena1HyojunEntity.BANGOHOKOSHINKB) = csAtena1Row(ABMyNumberHyojunEntity.BANGOHOKOSHINKB);
                            }
                            if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_AtenaGet1)
                            {
                                // ƒVƒŠƒAƒ‹”Ô†
                                csDataNewRow(ABAtena1HyojunEntity.SERIALNO) = string.Empty;
                            }
                            // •W€€‹’ˆÙ“®Ž–—RƒR[ƒh
                            csDataNewRow(ABAtena1HyojunEntity.HYOJUNIDOJIYUCD) = string.Empty;
                            if ((strGyomuMei ?? "") != NENKIN && (strGyomuMei ?? "") != NENKIN_2)
                            {
                                // ˜A—æ‹æ•ªi‘—•tæj
                                csDataNewRow(ABAtena1HyojunEntity.SFSKRENRAKUSAKIKB) = csSfskRow(ABSfskHyojunEntity.SFSKRENRAKUSAKIKB);
                                // ‘—•tæ‹æ•ª
                                csDataNewRow(ABAtena1HyojunEntity.SFSKKBN) = csSfskRow(ABSfskHyojunEntity.SFSKKBN);
                            }
                            else
                            {
                            }
                            // Z–¯‹æ•ª
                            csDataNewRow(ABAtena1HyojunEntity.JUMINKBN) = string.Empty;
                            // Z–¯Ží•Ê
                            csDataNewRow(ABAtena1HyojunEntity.JUMINSHUBETSU) = string.Empty;
                            // Z–¯ó‘Ô
                            csDataNewRow(ABAtena1HyojunEntity.JUMINJOTAI) = string.Empty;
                            // ”Ô’nŽ}”Ô”’l
                            csDataNewRow(ABAtena1HyojunEntity.BANCHIEDABANSUCHI) = string.Empty;
                        }
                        else
                        {
                            // noop
                        }

                    }

                    // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁŠJŽn
                    // ZŠî–@‰ü³”»’è
                    if (m_strJukiHokaiseiKB_Param == "1")
                    {
                        // Z–¯•[ó‘Ô‹æ•ª
                        csDataNewRow(ABAtenaFZYEntity.JUMINHYOJOTAIKBN) = csAtena1Row(ABAtenaFZYEntity.JUMINHYOJOTAIKBN);
                        // Z‹’n“Ío—L–³ƒtƒ‰ƒO
                        csDataNewRow(ABAtenaFZYEntity.JUKYOCHITODOKEFLG) = csAtena1Row(ABAtenaFZYEntity.JUKYOCHITODOKEFLG);
                        // –{‘–¼
                        csDataNewRow(ABAtenaFZYEntity.HONGOKUMEI) = csAtena1Row(ABAtenaFZYEntity.HONGOKUMEI);
                        // ƒJƒi–{‘–¼
                        csDataNewRow(ABAtenaFZYEntity.KANAHONGOKUMEI) = csAtena1Row(ABAtenaFZYEntity.KANAHONGOKUMEI);
                        // •¹‹L–¼
                        csDataNewRow(ABAtenaFZYEntity.KANJIHEIKIMEI) = csAtena1Row(ABAtenaFZYEntity.KANJIHEIKIMEI);
                        // ƒJƒi•¹‹L–¼
                        csDataNewRow(ABAtenaFZYEntity.KANAHEIKIMEI) = csAtena1Row(ABAtenaFZYEntity.KANAHEIKIMEI);
                        // ’ÊÌ–¼
                        csDataNewRow(ABAtenaFZYEntity.KANJITSUSHOMEI) = csAtena1Row(ABAtenaFZYEntity.KANJITSUSHOMEI);
                        // ƒJƒi’ÊÌ–¼
                        csDataNewRow(ABAtenaFZYEntity.KANATSUSHOMEI) = csAtena1Row(ABAtenaFZYEntity.KANATSUSHOMEI);
                        // ƒJƒ^ƒJƒi•¹‹L–¼
                        csDataNewRow(ABAtenaFZYEntity.KATAKANAHEIKIMEI) = csAtena1Row(ABAtenaFZYEntity.KATAKANAHEIKIMEI);
                        // ¶”NŒŽ“ú•sÚ‹æ•ª
                        csDataNewRow(ABAtenaFZYEntity.UMAREFUSHOKBN) = csAtena1Row(ABAtenaFZYEntity.UMAREFUSHOKBN);
                        // ’ÊÌ–¼“o˜^i•ÏXj”NŒŽ“ú
                        csDataNewRow(ABAtenaFZYEntity.TSUSHOMEITOUROKUYMD) = csAtena1Row(ABAtenaFZYEntity.TSUSHOMEITOUROKUYMD);
                        // Ý—¯ŠúŠÔƒR[ƒh
                        csDataNewRow(ABAtenaFZYEntity.ZAIRYUKIKANCD) = csAtena1Row(ABAtenaFZYEntity.ZAIRYUKIKANCD);
                        // Ý—¯ŠúŠÔ–¼Ì
                        csDataNewRow(ABAtenaFZYEntity.ZAIRYUKIKANMEISHO) = csAtena1Row(ABAtenaFZYEntity.ZAIRYUKIKANMEISHO);
                        // ’†’·ŠúÝ—¯ŽÒ‚Å‚ ‚éŽ|“™‚ÌƒR[ƒh
                        csDataNewRow(ABAtenaFZYEntity.ZAIRYUSHACD) = csAtena1Row(ABAtenaFZYEntity.ZAIRYUSHACD);
                        // ’†’·ŠúÝ—¯ŽÒ‚Å‚ ‚éŽ|“™
                        csDataNewRow(ABAtenaFZYEntity.ZAIRYUSHAMEISHO) = csAtena1Row(ABAtenaFZYEntity.ZAIRYUSHAMEISHO);
                        // Ý—¯ƒJ[ƒh“™”Ô†
                        csDataNewRow(ABAtenaFZYEntity.ZAIRYUCARDNO) = csAtena1Row(ABAtenaFZYEntity.ZAIRYUCARDNO);
                        // “Á•Ê‰iZŽÒØ–¾‘Œð•t”NŒŽ“ú
                        csDataNewRow(ABAtenaFZYEntity.KOFUYMD) = csAtena1Row(ABAtenaFZYEntity.KOFUYMD);
                        // “Á•Ê‰iZŽÒØ–¾‘Œð•t—\’èŠúŠÔŠJŽn“ú
                        csDataNewRow(ABAtenaFZYEntity.KOFUYOTEISTYMD) = csAtena1Row(ABAtenaFZYEntity.KOFUYOTEISTYMD);
                        // “Á’è‰iZŽÒØ–¾‘Œð•t—\’èŠúŠÔI—¹“ú
                        csDataNewRow(ABAtenaFZYEntity.KOFUYOTEIEDYMD) = csAtena1Row(ABAtenaFZYEntity.KOFUYOTEIEDYMD);
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœˆÙ“®”NŒŽ“ú
                        csDataNewRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOIDOYMD) = csAtena1Row(ABAtenaFZYEntity.JUKITAISHOSHASHOJOIDOYMD);
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœŽ–—RƒR[ƒh
                        csDataNewRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYUCD) = csAtena1Row(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYUCD);
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœŽ–—R
                        csDataNewRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYU) = csAtena1Row(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYU);
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœ“Ío”NŒŽ“ú
                        csDataNewRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDYMD) = csAtena1Row(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDYMD);
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœ“Ío’Ê’m‹æ•ª
                        csDataNewRow(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDTUCIKB) = csAtena1Row(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDTUCIKB);
                        // ŠO‘l¢‘ÑŽå–¼
                        csDataNewRow(ABAtenaFZYEntity.FRNSTAINUSMEI) = csAtena1Row(ABAtenaFZYEntity.FRNSTAINUSMEI);
                        // ŠO‘l¢‘ÑŽåƒJƒi–¼
                        csDataNewRow(ABAtenaFZYEntity.FRNSTAINUSKANAMEI) = csAtena1Row(ABAtenaFZYEntity.FRNSTAINUSKANAMEI);
                        // ¢‘ÑŽå•¹‹L–¼
                        csDataNewRow(ABAtenaFZYEntity.STAINUSHEIKIMEI) = csAtena1Row(ABAtenaFZYEntity.STAINUSHEIKIMEI);
                        // ¢‘ÑŽåƒJƒi•¹‹L–¼
                        csDataNewRow(ABAtenaFZYEntity.STAINUSKANAHEIKIMEI) = csAtena1Row(ABAtenaFZYEntity.STAINUSKANAHEIKIMEI);
                        // ¢‘ÑŽå’ÊÌ–¼
                        csDataNewRow(ABAtenaFZYEntity.STAINUSTSUSHOMEI) = csAtena1Row(ABAtenaFZYEntity.STAINUSTSUSHOMEI);
                        // ¢‘ÑŽåƒJƒi’ÊÌ–¼
                        csDataNewRow(ABAtenaFZYEntity.STAINUSKANATSUSHOMEI) = csAtena1Row(ABAtenaFZYEntity.STAINUSKANATSUSHOMEI);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }
                    // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁI—¹

                    // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁŠJŽn
                    // ‹¤’Ê”Ô†”»’è
                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                    {
                        // ‹ó”’œ‹Ž‚µ‚½’l‚ðÝ’è‚·‚éB
                        csDataNewRow(ABMyNumberEntity.MYNUMBER) = csAtena1Row(ABMyNumberEntity.MYNUMBER).ToString.Trim;
                    }
                    else
                    {
                        // noop
                    }
                    // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁI—¹

                    // *—š—ð”Ô† 000019 2003/11/19 C³ŠJŽn
                    // 'ƒŒƒR[ƒh‚Ì’Ç‰Á
                    // csAtena12.Tables(ABAtena1Entity.TABLE_NAME).Rows.Add(csDataNewRow)

                    // ƒŒƒR[ƒh‚Ì’Ç‰Á
                    csDataTable.Rows.Add(csDataNewRow);
                    // *—š—ð”Ô† 000019 2003/11/19 C³I—¹


                }

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException exException)
            {

                // ƒGƒ‰[ƒƒOo—Í
                m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default
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
                                                    "yƒGƒ‰[“
               */
);
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 431415


                Input:
                " + exException.Message + "z")

                            ' ƒXƒ[‚·‚é
                            Throw exException

                        Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                      "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 431707


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                      "yƒƒ\ƒbƒh–¼:
                 */
                ;

                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 431788


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                      "yƒGƒ‰[“à—e:" + exException.Message + "z")

                                 */
                throw exException;

            }

            return csAtena12;

        }
        #endregion

        #region  ƒpƒ‰ƒ[ƒ^[ƒ`ƒFƒbƒN(CheckColumnValue) 
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ƒpƒ‰ƒ[ƒ^[ƒ`ƒFƒbƒN
        // * 
        // * \•¶           Private Sub CheckColumnValue(ByVal cAtenaGetPara1 As ABAtenaGetPara1)
        // * 
        // * ‹@”\@@    @@ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^‚Ìƒ`ƒFƒbƒN‚ðs‚È‚¤
        // * 
        // * ˆø”           cAtenaGetPara1 As ABAtenaGetPara1 : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void CheckColumnValue(ABAtenaGetPara1XClass cAtenaGetPara1)
        {

            const string THIS_METHOD_NAME = "CheckColumnValue";
            UFErrorClass cfErrorClass;                    // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
                                                          // * —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                                                          // Dim cABCommon As ABCommonClass                      'ˆ¶–¼‹¤’ÊƒNƒ‰ƒX
                                                          // * —š—ð”Ô† 000023 2004/08/27 íœI—¹

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // 'ƒGƒ‰[ˆ—ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // '*—š—ð”Ô† 000010  2003/03/27 C³ŠJŽn
                // 'cfErrorClass = New UFErrorClass(m_cfUFControlData.m_strBusinessId)
                // cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                // '*—š—ð”Ô† 000010  2003/03/27 C³I—¹

                // ˆ¶–¼‹¤’ÊƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // * —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                // m_cABCommon = New ABCommonClass()
                // * —š—ð”Ô† 000023 2004/08/27 íœI—¹

                // *—š—ð”Ô† 000007 2003/03/17 íœŠJŽn
                // 'ZŠîEZ“oŠO‹æ•ª
                // If Not (cAtenaGetPara1.p_strJukiJutogaiKB = String.Empty) Then
                // If Not (cAtenaGetPara1.p_strJukiJutogaiKB = "1") Then
                // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                // objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAGETB_PARA_JUKIJUTOGAIKB)
                // '—áŠO‚ð¶¬
                // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                // End If
                // End If
                // *—š—ð”Ô† 000007 2003/03/17 íœI—¹

                // ‹Æ–±ƒR[ƒh
                if (!(cAtenaGetPara1.p_strGyomuCD == string.Empty))
                {
                    if (!UFStringClass.CheckAlphabetNumber(cAtenaGetPara1.p_strGyomuCD))
                    {
                        // *—š—ð”Ô† 000009 2003/03/18 C³ŠJŽn
                        // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                        // objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAGETB_PARA_GYOMUCD)
                        // '—áŠO‚ð¶¬
                        // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)

                        // ƒGƒ‰[’è‹`‚ðŽæ“¾
                        cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                        objErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001036);
                        // —áŠO‚ð¶¬
                        throw new UFAppException(objErrorStruct.m_strErrorMessage + "‹Æ–±ƒR[ƒh", objErrorStruct.m_strErrorCode);
                        // *—š—ð”Ô† 000009 2003/03/18 C³I—¹
                    }
                }

                // ‹Æ–±“àŽí•ÊƒR[ƒh
                if (!(cAtenaGetPara1.p_strGyomunaiSHU_CD == string.Empty))
                {
                    if (!UFStringClass.CheckNumber(cAtenaGetPara1.p_strGyomunaiSHU_CD))
                    {
                        // *—š—ð”Ô† 000009 2003/03/18 C³ŠJŽn
                        // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                        // objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAGETB_PARA_GYOMUNAISHU_CD)
                        // '—áŠO‚ð¶¬
                        // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)

                        // ƒGƒ‰[’è‹`‚ðŽæ“¾
                        cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                        objErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001036);
                        // —áŠO‚ð¶¬
                        throw new UFAppException(objErrorStruct.m_strErrorMessage + default
                   /* TODO ERROR: Skipped SkippedTokensTrivia
                   àŽí•ÊƒR[ƒh", objErrorStruct.m_strErrorCode)
                                       '*—š—ð”Ô† 000009 2003/03/18 C³I—¹*/
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
                                 "‹Æ–±“
                                  */
                     );
                    }
                }

                // *—š—ð”Ô† 000007 2003/03/17 íœŠJŽn
                /// —•tæƒf[ƒ^‹æ•ª
                // If Not (cAtenaGetPara1.p_strSfskDataKB = String.Empty) Then
                // If (Not (cAtenaGetPara1.p_strSfskDataKB = "1")) Then
                // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                // objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAGETB_PARA_SFSKDATAKB)
                // '—áŠO‚ð¶¬
                // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                // End If
                // End If

                // '¢‘Ñˆõ•ÒW
                // If Not (cAtenaGetPara1.p_strStaiinHenshu = String.Empty) Then
                // If (Not (cAtenaGetPara1.p_strStaiinHenshu = "1")) Then
                // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                // objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAGETB_PARA_STAIINHENSHU)
                // '—áŠO‚ð¶¬
                // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                // End If
                // End If

                // 'ƒf[ƒ^‹æ•ª
                // If Not (cAtenaGetPara1.p_strDataKB = String.Empty) Then
                // If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strDataKB)) Then
                // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                // objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAGETB_PARA_DATAKB)
                // '—áŠO‚ð¶¬
                // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                // End If
                // End If
                // *—š—ð”Ô† 000007 2003/03/17 íœI—¹

                // ZŠ•ÒW‚P
                if (!(cAtenaGetPara1.p_strJushoHenshu1 == string.Empty))
                {
                    if (!(cAtenaGetPara1.p_strJushoHenshu1 == "1"))
                    {
                        // *—š—ð”Ô† 000009 2003/03/18 C³ŠJŽn
                        // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                        // objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAGETB_PARA_JUSHOHENSHU1)
                        // '—áŠO‚ð¶¬
                        // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)

                        // ƒGƒ‰[’è‹`‚ðŽæ“¾
                        cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                        objErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001036);
                        // —áŠO‚ð¶¬
                        throw new UFAppException(objErrorStruct.m_strErrorMessage + "ZŠ•ÒW‚P", objErrorStruct.m_strErrorCode);
                        // *—š—ð”Ô† 000009 2003/03/18 C³I—¹
                    }
                }

                // ZŠ•ÒW‚Q
                if (!(cAtenaGetPara1.p_strJushoHenshu2 == string.Empty))
                {
                    if (!(cAtenaGetPara1.p_strJushoHenshu2 == "1"))
                    {
                        // *—š—ð”Ô† 000009 2003/03/18 C³ŠJŽn
                        // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                        // objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAGETB_PARA_JUSHOHENSHU2)
                        // '—áŠO‚ð¶¬
                        // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)

                        // ƒGƒ‰[’è‹`‚ðŽæ“¾
                        cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                        objErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001036);
                        // —áŠO‚ð¶¬
                        throw new UFAppException(objErrorStruct.m_strErrorMessage + "ZŠ•ÒW‚Q", objErrorStruct.m_strErrorCode);
                        // *—š—ð”Ô† 000009 2003/03/18 C³I—¹
                    }
                }

                // ZŠ•ÒW‚R
                if (!(cAtenaGetPara1.p_strJushoHenshu3 == string.Empty))
                {
                    // * —š—ð”Ô† 000028 2007/01/15 C³ŠJŽn
                    // * —š—ð”Ô† 000025 2005/07/14 C³ŠJŽn
                    // If (Not (cAtenaGetPara1.p_strJushoHenshu3 >= "1" And cAtenaGetPara1.p_strJushoHenshu3 <= "4")) Then
                    // If (Not (cAtenaGetPara1.p_strJushoHenshu3 >= "1" And cAtenaGetPara1.p_strJushoHenshu3 <= "5")) Then
                    if (!(cAtenaGetPara1.p_strJushoHenshu3 >= "1" & cAtenaGetPara1.p_strJushoHenshu3 <= "6"))
                    {
                        // * —š—ð”Ô† 000025 2005/07/14 C³I—¹
                        // * —š—ð”Ô† 000028 2007/01/15 C³I—¹
                        // *—š—ð”Ô† 000009 2003/03/18 C³ŠJŽn
                        // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                        // objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAGETB_PARA_JUSHOHENSHU3)
                        // '—áŠO‚ð¶¬
                        // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)

                        // ƒGƒ‰[’è‹`‚ðŽæ“¾
                        cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                        objErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001036);
                        // —áŠO‚ð¶¬
                        throw new UFAppException(objErrorStruct.m_strErrorMessage + "ZŠ•ÒW‚R", objErrorStruct.m_strErrorCode);
                        // *—š—ð”Ô† 000009 2003/03/18 C³I—¹
                    }
                }

                // ZŠ•ÒW‚S
                if (!(cAtenaGetPara1.p_strJushoHenshu4 == string.Empty))
                {
                    if (!(cAtenaGetPara1.p_strJushoHenshu4 == "1"))
                    {
                        // *—š—ð”Ô† 000009 2003/03/18 C³ŠJŽn
                        // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                        // objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAGETB_PARA_JUSHOHENSHU4)
                        // '—áŠO‚ð¶¬
                        // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)

                        // ƒGƒ‰[’è‹`‚ðŽæ“¾
                        cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                        objErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001036);
                        // —áŠO‚ð¶¬
                        throw new UFAppException(objErrorStruct.m_strErrorMessage + "ZŠ•ÒW‚S", objErrorStruct.m_strErrorCode);
                        // *—š—ð”Ô† 000009 2003/03/18 C³I—¹
                    }
                }

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException ObjAppExp)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default
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
                                                      "yƒGƒ‰[“
               */
);
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 443364


                Input:
                " + ObjAppExp.Message + "z")

                            ' ƒGƒ‰[‚ðƒXƒ[‚·‚é()
                            Throw ObjAppExp

                        Catch objExp As Exception
                            'ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 443630


                Input:
                " + THIS_CLASS_NAME + "z" _
                                                      + "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 443713


                                Input:
                                " + THIS_METHOD_NAME + "z" _
                                                                      + "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }
        #endregion

        #region  ˆ¶–¼î•ñƒJƒ‰ƒ€ì¬(CreateAtena1Columns) 
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼î•ñƒJƒ‰ƒ€ì¬
        // * 
        // * \•¶           Private Function CreateAtena1Columns() As DataTable
        // * 
        // * ‹@”\@@    @@ˆ¶–¼î•ñDataSet‚ÌƒJƒ‰ƒ€‚ðì¬‚·‚é
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        public DataTable CreateAtena1Columns()
        {
            const string THIS_METHOD_NAME = "CreateAtena1Columns";
            // * corresponds to VS2008 Start 2010/04/16 000039
            // Dim csDataSet As DataSet
            // * corresponds to VS2008 End 2010/04/16 000039
            DataTable csDataTable;
            DataColumn csDataColumn;
            // *—š—ð”Ô† 000011 2003/04/01 íœŠJŽn
            // Dim csDataPrimaryKey(4) As DataColumn               'ŽåƒL[
            // *—š—ð”Ô† 000011 2003/04/01 íœI—¹

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // *—š—ð”Ô† 000047 2012/03/13 C³ŠJŽn
                // '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
                // If Not (m_csOrgAtena1 Is Nothing) Then
                // Return m_csOrgAtena1.Clone
                // End If
                // '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj

                if (!m_blnNenKin && !m_blnKobetsu)
                {
                    // ”N‹àEŒÂ•ÊˆÈŠO‚ÌŽž‚Í’ÊíƒXƒL[ƒ}‚ðŒ©‚é
                    if (m_csOrgAtena1 is not null)
                    {
                        return m_csOrgAtena1.Clone();
                    }
                    else
                    {
                        // ‰½‚à‚µ‚È‚¢
                    }
                }
                // ”N‹àorŒÂ•Ê‚ÌŽž‚Íê—p‚ÌƒXƒL[ƒ}‚ðŒ©‚é
                else if (m_csOrgNenkinKobetsu is not null)
                {
                    return m_csOrgNenkinKobetsu.Clone();
                }
                else
                {
                    // ‰½‚à‚µ‚È‚¢
                }
                // *—š—ð”Ô† 000047 2012/03/13 C³I—¹

                csDataTable = new DataTable();
                csDataTable.TableName = ABAtena1Entity.TABLE_NAME;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.JUMINCD, Type.GetType("System.String"));
                csDataColumn.AllowDBNull = false;
                csDataColumn.MaxLength = 15;
                // *—š—ð”Ô† 000011 2003/04/01 íœŠJŽn
                // csDataPrimaryKey(0) = csDataColumn              'ŽåƒL[‡@
                // *—š—ð”Ô† 000011 2003/04/01 íœI—¹
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.DAINOKB, Type.GetType("System.String"));
                csDataColumn.AllowDBNull = false;
                csDataColumn.MaxLength = 2;
                // *—š—ð”Ô† 000011 2003/04/01 íœŠJŽn
                // csDataPrimaryKey(1) = csDataColumn              'ŽåƒL[‡A
                // *—š—ð”Ô† 000011 2003/04/01 íœI—¹

                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.DAINOKBMEISHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 10;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.DAINOKBRYAKUMEISHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 5;

                // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.GYOMUCD, Type.GetType("System.String"));
                    csDataColumn.AllowDBNull = false;
                    csDataColumn.MaxLength = 2;
                    // *—š—ð”Ô† 000011 2003/04/01 íœŠJŽn
                    // csDataPrimaryKey(2) = csDataColumn              'ŽåƒL[‡B
                    // *—š—ð”Ô† 000011 2003/04/01 íœI—¹
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.GYOMUNAISHU_CD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1;
                    // *—š—ð”Ô† 000011 2003/04/01 íœŠJŽn
                    // csDataPrimaryKey(3) = csDataColumn              'ŽåƒL[‡C
                    // *—š—ð”Ô† 000011 2003/04/01 íœI—¹
                }
                // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.KYUSHICHOSONCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.STAICD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 15;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ATENADATAKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ATENADATASHU, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HENSHUSHUBETSU, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HENSHUSHUBETSURYAKU, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 3;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.SEARCHKANASEIMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 120;        // 40
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.SEARCHKANASEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 72;         // 24
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.SEARCHKANAMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 48;         // 16
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.SEARCHKANJIMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;        // 40
                }
                // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HENSHUKANASHIMEI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 240;        // 60
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HENSHUKANJISHIMEI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 920;        // 80
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.UMAREYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.UMAREWMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.UMAREHYOJIWMD, Type.GetType("System.String"));
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.UMARESHOMEIWMD, Type.GetType("System.String"));
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.SEIBETSUCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.SEIBETSU, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HENSHUZOKUGARACD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HENSHUZOKUGARA, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 40;         // 15
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HOJINDAIHYOUSHA, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;        // 30
                }
                // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.KJNHJNKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.KJNHJNKBMEISHO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 2;
                }
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.KANNAIKANGAIKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.NAIGAIKBMEISHO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 2;
                }
                // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.YUBINNO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.JUSHOCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 13;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.JUSHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 200;         // 30
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HENSHUJUSHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 640;        // 80
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.BANCHICD1, Type.GetType("System.String"));
                csDataColumn.MaxLength = 5;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.BANCHICD2, Type.GetType("System.String"));
                csDataColumn.MaxLength = 5;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.BANCHICD3, Type.GetType("System.String"));
                csDataColumn.MaxLength = 5;
                // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.BANCHI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 200;         // 30
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.KATAGAKIFG, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.KATAGAKICD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 20;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.KATAGAKI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 240;         // 30
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.RENRAKUSAKI1, Type.GetType("System.String"));
                csDataColumn.MaxLength = 15;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.RENRAKUSAKI2, Type.GetType("System.String"));
                csDataColumn.MaxLength = 15;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.GYOSEIKUCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 12;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.GYOSEIKUMEI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 120;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.CHIKUCD1, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.CHIKUMEI1, Type.GetType("System.String"));
                csDataColumn.MaxLength = 120;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.CHIKUCD2, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.CHIKUMEI2, Type.GetType("System.String"));
                csDataColumn.MaxLength = 120;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.CHIKUCD3, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.CHIKUMEI3, Type.GetType("System.String"));
                csDataColumn.MaxLength = 30;
                // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TOROKUIDOYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TOROKUJIYUCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 2;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TOROKUJIYU, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 10;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.SHOJOIDOYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.SHOJOJIYUCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 2;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.SHOJOJIYU, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 10;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HENSHUNUSHIJUMINCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 15;
                }
                // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HENSHUKANANUSHIMEI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 120;        // 40
                                                     // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HENSHUNUSHIMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;        // 30
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HYOJIJUN, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 4;
                }
                // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                // *—š—ð”Ô† 000011 2003/04/01 íœŠJŽn
                // csDataTable.PrimaryKey = csDataPrimaryKey       'ŽåƒL[
                // *—š—ð”Ô† 000011 2003/04/01 íœI—¹
                // *—š—ð”Ô† 000012 2003/04/18 ’Ç‰ÁŠJŽn
                // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òjIF•¶‚ÅˆÍ‚Þ
                if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZOKUGARACD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZOKUGARA, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 40;         // 15
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.KANAMEISHO2, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 120;        // 60
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.KANJIMEISHO2, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;        // 40
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.SEKINO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 2;
                }
                // * —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òjIF•¶‚ÅˆÍ‚Þ
                // *—š—ð”Ô† 000012 2003/04/18 ’Ç‰ÁI—¹
                // *—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁŠJŽn
                // *—š—ð”Ô† 000020 2003/12/01 íœŠJŽn
                // csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.RENRAKUSAKI_GYOMUCD, System.Type.GetType("System.String"))
                // csDataColumn.MaxLength = 2
                // *—š—ð”Ô† 000020 2003/12/01 íœI—¹
                // *—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁI—¹

                // *—š—ð”Ô† 000030 2007/04/28 ’Ç‰ÁŠJŽn
                // ‰îŒì—pŽæ“¾€–Ú
                if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_Kaigo)
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.RENRAKUSAKI_GYOMUCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 2;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.KYUSEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 60;         // 15
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.JUTEIIDOYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.JUTEIJIYU, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 10;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HON_ZJUSHOCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 13;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENUMAEJ_YUBINNO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 7;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENUMAEJ_ZJUSHOCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 13;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENUMAEJ_JUSHO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 200;         // 30
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENUMAEJ_BANCHI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 200;         // 20
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENUMAEJ_KATAGAKI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 240;         // 30
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENSHUTSUYOTEIYUBINNO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 7;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENSHUTSUYOTEIZJUSHOCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 13;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENSHUTSUYOTEIIDOYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENSHUTSUYOTEIJUSHO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 200;         // 30
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENSHUTSUYOTEIBANCHI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 200;         // 20
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENSHUTSUYOTEIKATAGAKI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 240;         // 30
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENSHUTSUYOTEISTAINUSMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;        // 30
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENSHUTSUKKTIYUBINNO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 7;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENSHUTSUKKTIZJUSHOCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 13;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENSHUTSUKKTIIDOYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENSHUTSUKKTITSUCHIYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENSHUTSUKKTIJUSHO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 200;         // 30
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENSHUTSUKKTIBANCHI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 200;         // 20
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENSHUTSUKKTIKATAGAKI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 240;         // 30
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENSHUTSUKKTISTAINUSMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;        // 30
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HENSHUMAEBANCHI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 200;         // 20
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HENSHUMAEKATAGAKI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 240;         // 30
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.SHOJOTDKDYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.CKINJIYUCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 2;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.KOKUSEKICD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 3;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TOROKUTDKDYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.JUTEITDKDYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.TENSHUTSUNYURIYU, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 30;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.SHICHOSONCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 6;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.CKINIDOYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.KOSHINNICHIJI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 17;
                }
                // *—š—ð”Ô† 000030 2007/04/28 ’Ç‰ÁI—¹

                // *—š—ð”Ô† 000037 2008/11/18 C³ŠJŽn
                // *—š—ð”Ô† 000036 2008/11/10 ’Ç‰ÁŠJŽn
                // If (m_blnSelectAll <> ABEnumDefine.AtenaGetKB.KaniOnly AndAlso m_blnKobetsu = False AndAlso _
                // (m_strRiyoTdkdKB = "1" OrElse m_strRiyoTdkdKB = "2")) Then
                if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly && m_blnKobetsu == false && m_blnMethodKB != ABEnumDefine.MethodKB.KB_Kaigo && (m_strRiyoTdkdKB == "1" || m_strRiyoTdkdKB == "2"))
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.NOZEIID, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 11;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.RIYOSHAID, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 11;
                }
                else
                {
                }
                // *—š—ð”Ô† 000036 2008/11/10 ’Ç‰ÁI—¹
                // *—š—ð”Ô† 000037 2008/11/18 C³I—¹

                // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁŠJŽn
                if (m_blnNenKin == false && m_blnKobetsu == false)
                {
                    // ’ÊíAŠÈˆÕˆ¶–¼—pA‰îŒì—p‚Ì‚Ý

                    // –{Ð•M“ªŽÒî•ño—Í”»’è
                    if (m_strHonsekiHittoshKB_Param == "1" && m_strHonsekiHittoshKB == "1")
                    {
                        // ƒpƒ‰ƒ[ƒ^:–{Ð•M“ªŽÒŽæ“¾‹æ•ª‚ª"1"‚©‚ÂAŠÇ—î•ñ:–{ÐŽæ“¾‹æ•ª(10¥18)‚ª"1"‚Ìê‡‚Ì‚Ýo—Í
                        // –{ÐZŠ
                        csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HON_JUSHO, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 200;        // 30
                                                             // –{Ð”Ô’n
                        csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HONSEKIBANCHI, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 200;        // 20
                                                             // •M“ªŽÒ
                        csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HITTOSH, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 480;        // 30
                    }
                    else
                    {
                    }

                    // ˆ—’âŽ~‹æ•ªo—Í”»’è
                    if (m_strShoriteishiKB == "1" && m_strShoriteishiKB_Param == "1")
                    {
                        // ƒpƒ‰ƒ[ƒ^:ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ª‚ª"1"‚©‚ÂAŠÇ—î•ñ:ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ª(10¥19)‚ª"1"‚Ìê‡‚Ì‚Ýo—Í
                        // ˆ—’âŽ~‹æ•ª
                        csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.SHORITEISHIKB, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 1;
                    }
                    else
                    {
                    }

                    // *—š—ð”Ô† 000041 2011/05/18 ’Ç‰ÁŠJŽn
                    // ŠO‘lÝ—¯î•ño—Í”»’è
                    if (m_strFrnZairyuJohoKB_Param == "1")
                    {
                        // ƒpƒ‰ƒ[ƒ^:ŠO‘lÝ—¯î•ñŽæ“¾‹æ•ª‚ª"1"‚Ìê‡‚Ì‚Ý
                        // ‘Ð
                        csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.KOKUSEKI, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 20;
                        // Ý—¯Ž‘ŠiƒR[ƒh
                        csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYUSKAKCD, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 3;
                        // Ý—¯Ž‘Ši
                        csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYUSKAK, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 15;
                        // Ý—¯ŠúŠÔ
                        csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYUKIKAN, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 4;
                        // Ý—¯ŠJŽn”NŒŽ“ú
                        csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYU_ST_YMD, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 8;
                        // Ý—¯I—¹”NŒŽ“ú
                        csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYU_ED_YMD, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 8;
                    }
                    // *—š—ð”Ô† 000041 2011/05/18 ’Ç‰ÁI—¹
                    // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁŠJŽn
                    // ZŠî–@‰ü³”»’è
                    if (m_strJukiHokaiseiKB_Param == "1")
                    {
                        // Z–¯•[ó‘Ô‹æ•ª
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUMINHYOJOTAIKBN, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 1;
                        // Z‹’n“Ío—L–³ƒtƒ‰ƒO
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKYOCHITODOKEFLG, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 1;
                        // –{‘–¼
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.HONGOKUMEI, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 480;
                        // ƒJƒi–{‘–¼
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KANAHONGOKUMEI, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 120;
                        // •¹‹L–¼
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KANJIHEIKIMEI, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 480;
                        // ƒJƒi•¹‹L–¼
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KANAHEIKIMEI, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 120;
                        // ’ÊÌ–¼
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KANJITSUSHOMEI, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 480;
                        // ƒJƒi’ÊÌ–¼
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KANATSUSHOMEI, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 120;
                        // ƒJƒ^ƒJƒi•¹‹L–¼
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KATAKANAHEIKIMEI, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 120;
                        // ¶”NŒŽ“ú•sÚ‹æ•ª
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.UMAREFUSHOKBN, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 2;
                        // ’ÊÌ–¼“o˜^i•ÏXj”NŒŽ“ú
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.TSUSHOMEITOUROKUYMD, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 8;
                        // Ý—¯ŠúŠÔƒR[ƒh
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.ZAIRYUKIKANCD, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 7;
                        // Ý—¯ŠúŠÔ–¼Ì
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.ZAIRYUKIKANMEISHO, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 10;
                        // ’†’·ŠúÝ—¯ŽÒ‚Å‚ ‚éŽ|“™‚ÌƒR[ƒh
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.ZAIRYUSHACD, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 2;
                        // ’†’·ŠúÝ—¯ŽÒ‚Å‚ ‚éŽ|“™
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.ZAIRYUSHAMEISHO, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 20;
                        // Ý—¯ƒJ[ƒh“™”Ô†
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.ZAIRYUCARDNO, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 12;
                        // “Á•Ê‰iZŽÒØ–¾‘Œð•t”NŒŽ“ú
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KOFUYMD, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 8;
                        // “Á•Ê‰iZŽÒØ–¾‘Œð•t—\’èŠúŠÔŠJŽn“ú
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KOFUYOTEISTYMD, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 8;
                        // “Á’è‰iZŽÒØ–¾‘Œð•t—\’èŠúŠÔI—¹“ú
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KOFUYOTEIEDYMD, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 8;
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœˆÙ“®”NŒŽ“ú
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKITAISHOSHASHOJOIDOYMD, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 8;
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœŽ–—RƒR[ƒh
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYUCD, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 2;
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœŽ–—R
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYU, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 10;
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœ“Ío”NŒŽ“ú
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDYMD, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 8;
                        // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœ“Ío’Ê’m‹æ•ª
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDTUCIKB, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 1;
                        // ŠO‘l¢‘ÑŽå–¼
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.FRNSTAINUSMEI, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 480;
                        // ŠO‘l¢‘ÑŽåƒJƒi–¼
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.FRNSTAINUSKANAMEI, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 120;
                        // ¢‘ÑŽå•¹‹L–¼
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.STAINUSHEIKIMEI, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 480;
                        // ¢‘ÑŽåƒJƒi•¹‹L–¼
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.STAINUSKANAHEIKIMEI, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 120;
                        // ¢‘ÑŽå’ÊÌ–¼
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.STAINUSTSUSHOMEI, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 480;
                        // ¢‘ÑŽåƒJƒi’ÊÌ–¼
                        csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.STAINUSKANATSUSHOMEI, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 120;
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }
                    // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁI—¹

                    // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁŠJŽn
                    // ‹¤’Ê”Ô†”»’è
                    if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                    {
                        // ‹¤’Ê”Ô†
                        csDataColumn = csDataTable.Columns.Add(ABMyNumberEntity.MYNUMBER, Type.GetType("System.String"));
                        csDataColumn.MaxLength = 13;
                    }
                    else
                    {
                        // noop
                    }
                    // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁI—¹

                    // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁŠJŽn
                    // ’ÊíƒXƒL[ƒ}‚É•Û‘¶
                    m_csOrgAtena1 = csDataTable.Clone();
                }
                // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁI—¹
                else
                {
                    // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁŠJŽn
                    // ”N‹àEŒÂ•ÊƒXƒL[ƒ}‚É•Û‘¶
                    m_csOrgNenkinKobetsu = csDataTable.Clone();
                    // *—š—ð”Ô† 000047 2012/03/13 ’Ç‰ÁI—¹
                }
                // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁI—¹

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException exException)
            {

                // ƒGƒ‰[ƒƒOo—Í
                m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default
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
                                                    "yƒGƒ‰[“
               */
);
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 481256


                Input:
                " + exException.Message + "z")

                            ' ƒXƒ[‚·‚é
                            Throw exException

                        Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                      "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 481548


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                      "yƒƒ\ƒbƒh–¼:
                 */
                ;

                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 481629


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                      "yƒGƒ‰[“à—e:" + exException.Message + "z")

                                 */
                throw exException;

            }

            // *—š—ð”Ô† 000047 2012/03/13 C³ŠJŽn
            // '* —š—ð”Ô† 000024 2005/01/25 •ÏXŠJŽni‹{‘òj
            // 'Return csDataTable
            // m_csOrgAtena1 = csDataTable
            // Return m_csOrgAtena1.Clone
            // '* —š—ð”Ô† 000024 2005/01/25 •ÏXI—¹i‹{‘òj

            return csDataTable;
            // *—š—ð”Ô† 000047 2012/03/13 C³I—¹
        }
        #endregion

        #region  ”
        // *—š—ð”Ô† 000013 2003/04/18 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ”N‹à—pˆ¶–¼î•ñƒJƒ‰ƒ€ì¬
        // * 
        // * \•¶           Private Function CreateNenkinAtenaColumns(ByVal strGyomuMei As String) As DataTable
        // * 
        // * ‹@”\@@    @@”N‹à—pˆ¶–¼î•ñDataSet‚ÌƒJƒ‰ƒ€‚ðì¬‚·‚é
        // * 
        // * ˆø”           ByVal strGyomuMei As String
        // * 
        // * –ß‚è’l         DataSet(ABNenkinAtena) : ì¬‚µ‚½”N‹à—pˆ¶–¼î•ñ
        // ************************************************************************************************
        // *—š—ð”Ô† 000027 2006/07/31 C³ŠJŽn
        private DataTable CreateNenkinAtenaColumns(string strGyomuMei)
        {
            // Private Function CreateNenkinAtenaColumns() As DataTable
            // *—š—ð”Ô† 000027 2006/07/31 C³I—¹
            const string THIS_METHOD_NAME = "CreateNenkinAtenaColumns";
            // * corresponds to VS2008 Start 2010/04/16 000039
            // Dim csDataSet As DataSet
            // * corresponds to VS2008 End 2010/04/16 000039
            DataTable csDataTable;
            DataColumn csDataColumn;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
                if (m_csOrgAtena1Nenkin is not null)
                {
                    return m_csOrgAtena1Nenkin.Clone();
                }
                // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj

                // ˆ¶–¼î•ñ‚æ‚èì¬‚·‚é
                csDataTable = CreateAtena1Columns();
                csDataTable.TableName = ABNenkinAtenaEntity.TABLE_NAME;

                // *—š—ð”Ô† 000020 2003/12/01 ’Ç‰ÁŠJŽn
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.RENRAKUSAKI_GYOMUCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                // *—š—ð”Ô† 000020 2003/12/01 ’Ç‰ÁI—¹
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.KYUSEI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 60;         // 15
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.JUTEIIDOYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.JUTEIJIYU, Type.GetType("System.String"));
                csDataColumn.MaxLength = 10;
                // *—š—ð”Ô† 000022 2003/12/04 ’Ç‰ÁŠJŽn
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.HON_ZJUSHOCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 13;
                // *—š—ð”Ô† 000022 2003/12/04 ’Ç‰ÁI—¹
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENUMAEJ_YUBINNO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                // *—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁŠJŽn
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENUMAEJ_ZJUSHOCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 13;
                // *—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁI—¹
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENUMAEJ_JUSHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 200;         // 30
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENUMAEJ_BANCHI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 200;         // 20
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENUMAEJ_KATAGAKI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 240;         // 30
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENSHUTSUYOTEIYUBINNO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENSHUTSUYOTEIZJUSHOCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 13;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENSHUTSUYOTEIIDOYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENSHUTSUYOTEIJUSHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 200;         // 30
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENSHUTSUYOTEIBANCHI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 200;         // 20
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENSHUTSUYOTEIKATAGAKI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 240;         // 30
                                                      // *—š—ð”Ô† 000022 2003/12/04 ’Ç‰ÁŠJŽn
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENSHUTSUYOTEISTAINUSMEI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 480;        // 30
                                                     // *—š—ð”Ô† 000022 2003/12/04 ’Ç‰ÁI—¹
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENSHUTSUKKTIYUBINNO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                // *—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁŠJŽn
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENSHUTSUKKTIZJUSHOCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 13;
                // *—š—ð”Ô† 000017 2003/10/09 ’Ç‰ÁI—¹
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENSHUTSUKKTIIDOYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENSHUTSUKKTITSUCHIYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENSHUTSUKKTIJUSHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 200;         // 30
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENSHUTSUKKTIBANCHI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 200;         // 20
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENSHUTSUKKTIKATAGAKI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 240;         // 30
                                                      // *—š—ð”Ô† 000022 2003/12/04 ’Ç‰ÁŠJŽn
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENSHUTSUKKTISTAINUSMEI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 480;        // 30
                                                     // *—š—ð”Ô† 000022 2003/12/04 ’Ç‰ÁI—¹
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.HENSHUMAEBANCHI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 200;         // 20
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.HENSHUMAEKATAGAKI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 240;         // 30
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.SHOJOTDKDYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.CKINJIYUCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                // *—š—ð”Ô† 000022 2003/12/04 ’Ç‰ÁŠJŽn
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.KOKUSEKICD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 3;
                // *—š—ð”Ô† 000022 2003/12/04 ’Ç‰ÁI—¹
                // *—š—ð”Ô† 000027 2006/07/31 C³ŠJŽn
                if (strGyomuMei == "NENKIN_2")
                {
                    csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.TENUMAEJ_STAINUSMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;        // 30
                }
                // *—š—ð”Ô† 000027 2006/07/31 C³I—¹

                // *—š—ð”Ô† 000044 2011/06/24 ’Ç‰ÁŠJŽn
                // ŠO‘lÝ—¯î•ño—Í”»’è
                if (m_strFrnZairyuJohoKB_Param == "1")
                {
                    // ƒpƒ‰ƒ[ƒ^:ŠO‘lÝ—¯î•ñŽæ“¾‹æ•ª‚ª"1"‚Ìê‡‚Ì‚Ý
                    // ‘Ð
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.KOKUSEKI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 20;
                    // Ý—¯Ž‘ŠiƒR[ƒh
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYUSKAKCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 3;
                    // Ý—¯Ž‘Ši
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYUSKAK, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 15;
                    // Ý—¯ŠúŠÔ
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYUKIKAN, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 4;
                    // Ý—¯ŠJŽn”NŒŽ“ú
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYU_ST_YMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    // Ý—¯I—¹”NŒŽ“ú
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYU_ED_YMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                }
                // *—š—ð”Ô† 000044 2011/06/24 ’Ç‰ÁI—¹

                // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁŠJŽn
                // –{Ð•M“ªŽÒî•ño—Í”»’è
                if (m_strHonsekiHittoshKB_Param == "1" && m_strHonsekiHittoshKB == "1")
                {
                    // ƒpƒ‰ƒ[ƒ^:–{Ð•M“ªŽÒŽæ“¾‹æ•ª‚ª"1"‚©‚ÂAŠÇ—î•ñ:–{ÐŽæ“¾‹æ•ª(10¥18)‚ª"1"‚Ìê‡‚Ì‚Ýo—Í
                    // –{ÐZŠ
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HON_JUSHO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 200;        // 30
                                                         // –{Ð”Ô’n
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HONSEKIBANCHI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 200;        // 20
                                                         // •M“ªŽÒ
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HITTOSH, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;        // 30
                }
                else
                {
                }

                // ˆ—’âŽ~‹æ•ªo—Í”»’è
                if (m_strShoriteishiKB == "1" && m_strShoriteishiKB_Param == "1")
                {
                    // ƒpƒ‰ƒ[ƒ^:ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ª‚ª"1"‚©‚ÂAŠÇ—î•ñ:ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ª(10¥19)‚ª"1"‚Ìê‡‚Ì‚Ýo—Í
                    // ˆ—’âŽ~‹æ•ª
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.SHORITEISHIKB, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1;
                }
                else
                {
                }
                // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁI—¹

                // *—š—ð”Ô† 000044 2011/06/24 íœŠJŽn
                // '*—š—ð”Ô† 000041 2011/05/18 ’Ç‰ÁŠJŽn
                // ' ŠO‘lÝ—¯î•ño—Í”»’è
                // If (m_strFrnZairyuJohoKB_Param = "1") Then
                // ' ƒpƒ‰ƒ[ƒ^:ŠO‘lÝ—¯î•ñŽæ“¾‹æ•ª‚ª"1"‚Ìê‡‚Ì‚Ý
                // ' ‘Ð
                // csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.KOKUSEKI, System.Type.GetType("System.String"))
                // csDataColumn.MaxLength = 20
                // ' Ý—¯Ž‘ŠiƒR[ƒh
                // csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYUSKAKCD, System.Type.GetType("System.String"))
                // csDataColumn.MaxLength = 3
                // ' Ý—¯Ž‘Ši
                // csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYUSKAK, System.Type.GetType("System.String"))
                // csDataColumn.MaxLength = 15
                // ' Ý—¯ŠúŠÔ
                // csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYUKIKAN, System.Type.GetType("System.String"))
                // csDataColumn.MaxLength = 4
                // ' Ý—¯ŠJŽn”NŒŽ“ú
                // csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYU_ST_YMD, System.Type.GetType("System.String"))
                // csDataColumn.MaxLength = 8
                // ' Ý—¯I—¹”NŒŽ“ú
                // csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYU_ED_YMD, System.Type.GetType("System.String"))
                // csDataColumn.MaxLength = 8
                // End If
                // '*—š—ð”Ô† 000041 2011/05/18 ’Ç‰ÁI—¹
                // *—š—ð”Ô† 000044 2011/06/24 íœI—¹

                // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁŠJŽn
                // ZŠî–@‰ü³”»’è
                if (m_strJukiHokaiseiKB_Param == "1")
                {
                    // Z–¯•[ó‘Ô‹æ•ª
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUMINHYOJOTAIKBN, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1;
                    // Z‹’n“Ío—L–³ƒtƒ‰ƒO
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKYOCHITODOKEFLG, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1;
                    // –{‘–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.HONGOKUMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                    // ƒJƒi–{‘–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KANAHONGOKUMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 120;
                    // •¹‹L–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KANJIHEIKIMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                    // ƒJƒi•¹‹L–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KANAHEIKIMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 120;
                    // ’ÊÌ–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KANJITSUSHOMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                    // ƒJƒi’ÊÌ–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KANATSUSHOMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 120;
                    // ƒJƒ^ƒJƒi•¹‹L–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KATAKANAHEIKIMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 120;
                    // ¶”NŒŽ“ú•sÚ‹æ•ª
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.UMAREFUSHOKBN, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 2;
                    // ’ÊÌ–¼“o˜^i•ÏXj”NŒŽ“ú
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.TSUSHOMEITOUROKUYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    // Ý—¯ŠúŠÔƒR[ƒh
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.ZAIRYUKIKANCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 7;
                    // Ý—¯ŠúŠÔ–¼Ì
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.ZAIRYUKIKANMEISHO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 10;
                    // ’†’·ŠúÝ—¯ŽÒ‚Å‚ ‚éŽ|“™‚ÌƒR[ƒh
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.ZAIRYUSHACD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 2;
                    // ’†’·ŠúÝ—¯ŽÒ‚Å‚ ‚éŽ|“™
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.ZAIRYUSHAMEISHO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 20;
                    // Ý—¯ƒJ[ƒh“™”Ô†
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.ZAIRYUCARDNO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 12;
                    // “Á•Ê‰iZŽÒØ–¾‘Œð•t”NŒŽ“ú
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KOFUYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    // “Á•Ê‰iZŽÒØ–¾‘Œð•t—\’èŠúŠÔŠJŽn“ú
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KOFUYOTEISTYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    // “Á’è‰iZŽÒØ–¾‘Œð•t—\’èŠúŠÔI—¹“ú
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KOFUYOTEIEDYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœˆÙ“®”NŒŽ“ú
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKITAISHOSHASHOJOIDOYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœŽ–—RƒR[ƒh
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYUCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 2;
                    // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœŽ–—R
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYU, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 10;
                    // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœ“Ío”NŒŽ“ú
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœ“Ío’Ê’m‹æ•ª
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDTUCIKB, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1;
                    // ŠO‘l¢‘ÑŽå–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.FRNSTAINUSMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                    // ŠO‘l¢‘ÑŽåƒJƒi–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.FRNSTAINUSKANAMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 120;
                    // ¢‘ÑŽå•¹‹L–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.STAINUSHEIKIMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                    // ¢‘ÑŽåƒJƒi•¹‹L–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.STAINUSKANAHEIKIMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 120;
                    // ¢‘ÑŽå’ÊÌ–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.STAINUSTSUSHOMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                    // ¢‘ÑŽåƒJƒi’ÊÌ–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.STAINUSKANATSUSHOMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 120;
                }
                else
                {
                    // ˆ—‚È‚µ
                }
                // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁI—¹

                // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁŠJŽn
                // ‹¤’Ê”Ô†”»’è
                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                {
                    // ‹¤’Ê”Ô†
                    csDataColumn = csDataTable.Columns.Add(ABMyNumberEntity.MYNUMBER, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 13;
                }
                else
                {
                    // noop
                }
                // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁI—¹

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException exException)
            {

                // ƒGƒ‰[ƒƒOo—Í
                m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default
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
                                                    "yƒGƒ‰[“
               */
);
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 503213


                Input:
                " + exException.Message + "z")

                            ' ƒXƒ[‚·‚é
                            Throw exException

                        Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                      "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 503505


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                      "yƒƒ\ƒbƒh–¼:
                 */
                ;

                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 503586


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                      "yƒGƒ‰[“à—e:" + exException.Message + "z")

                                 */
                throw exException;

            }

            // * —š—ð”Ô† 000024 2005/01/25 •ÏXŠJŽni‹{‘òj
            // Return csDataTable
            m_csOrgAtena1Nenkin = csDataTable;
            return m_csOrgAtena1Nenkin.Clone();
            // * —š—ð”Ô† 000024 2005/01/25 •ÏXI—¹i‹{‘òj


        }
        // *—š—ð”Ô† 000013 2003/04/18 ’Ç‰ÁI—¹
        #endregion

        #region  ˆ¶–¼ŒÂ•Êî•ñƒJƒ‰ƒ€ì¬(CreateAtena1KobetsuColumns) 
        // *—š—ð”Ô† 000019 2003/11/19 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ŒÂ•Êî•ñƒJƒ‰ƒ€ì¬
        // * 
        // * \•¶           Private Function CreateAtena1KobetsuColumns() As DataTable
        // * 
        // * ‹@”\@@    @@ˆ¶–¼ŒÂ•Êî•ñDataSet‚ÌƒJƒ‰ƒ€‚ðì¬‚·‚é
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         DataSet(ABAtena1Kobetsu) : ì¬‚µ‚½ˆ¶–¼ŒÂ•Êî•ñ
        // ************************************************************************************************
        private DataTable CreateAtena1KobetsuColumns()
        {
            // * corresponds to VS2008 Start 2010/04/16 000039
            // Dim csDataSet As DataSet
            // * corresponds to VS2008 End 2010/04/16 000039
            DataTable csDataTable;
            DataColumn csDataColumn;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name);

                // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
                if (m_csOrgAtena1Kobetsu is not null)
                {
                    return m_csOrgAtena1Kobetsu.Clone();
                }
                // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj
                // ˆ¶–¼î•ñ‚æ‚èì¬‚·‚é
                csDataTable = CreateAtena1Columns();
                csDataTable.TableName = ABAtena1KobetsuEntity.TABLE_NAME;

                // *—š—ð”Ô† 000020 2003/12/01 ’Ç‰ÁŠJŽn
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaEntity.RENRAKUSAKI_GYOMUCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                // *—š—ð”Ô† 000020 2003/12/01 ’Ç‰ÁI—¹
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KSNENKNNO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 10;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.NENKNSKAKSHUTKYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.NENKNSKAKSHUTKSHU, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.NENKNSKAKSHUTKRIYUCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.NENKNSKAKSSHTSYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.NENKNSKAKSSHTSRIYUCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JKYNENKNKIGO1, Type.GetType("System.String"));
                csDataColumn.MaxLength = 4;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JKYNENKNNO1, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JKYNENKNSHU1, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JKYNENKNEDABAN1, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JKYNENKNKB1, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JKYNENKNKIGO2, Type.GetType("System.String"));
                csDataColumn.MaxLength = 4;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JKYNENKNNO2, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JKYNENKNSHU2, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JKYNENKNEDABAN2, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JKYNENKNKB2, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JKYNENKNKIGO3, Type.GetType("System.String"));
                csDataColumn.MaxLength = 4;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JKYNENKNNO3, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JKYNENKNSHU3, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JKYNENKNEDABAN3, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JKYNENKNKB3, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHONO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 14;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKBMEISHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 12;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOSHIKAKUKBRYAKUSHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 3;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOGAKUENKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOGAKUENKBMEISHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 12;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOGAKUENKBRYAKUSHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 3;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOSHUTOKUYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOSOSHITSUYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOTISHKKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOTISHKKBMEISHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 12;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOTISHKKBRYAKUSHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 3;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKBMEISHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 12;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOTISHKHONHIKBRYAKUSHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 3;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOTISHKGAITOYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOTISHKHIGAITOYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOHOKENSHOKIGO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 16;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKUHOHOKENSHONO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 16;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.INKANNO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 15;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.INKANTOROKUKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.SENKYOSHIKAKUKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 9;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JIDOTEATEHIYOKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JIDOTEATESTYM, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.JIDOTEATEEDYM, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KAIGHIHKNSHANO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 10;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KAIGSKAKSHUTKYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KAIGSKAKSSHTSYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KAIGSKAKHIHOKENSHAKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KAIGJUSHOCHITKRIKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KAIGJUKYUSHAKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.YOKAIGJOTAIKBCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KAIGSKAKKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 10;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KAIGNINTEIKAISHIYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KAIGNINTEISHURYOYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KAIGJUKYUNINTEIYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KAIGJUKYUNINTEITORIKESHIYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                // *—š—ð”Ô† 000034 2008/01/15 ’Ç‰ÁŠJŽn
                if (m_strKobetsuShutokuKB == "1")
                {
                    // ŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ª"1"‚Ìê‡‚ÍŒãŠú‚—î€–Ú‚ð’Ç‰Á‚·‚é
                    csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKIKOREISHIKAKUKB, Type.GetType("System.String"));           // Ž‘Ši‹æ•ª
                    csDataColumn.MaxLength = 1;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKIKOREIHIHKNSHANO, Type.GetType("System.String"));          // ”í•ÛŒ¯ŽÒ”Ô†
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKJIYUCD, Type.GetType("System.String"));     // ”í•ÛŒ¯ŽÒŽ‘ŠiŽæ“¾Ž–—RƒR[ƒh
                    csDataColumn.MaxLength = 3;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKJIYUMEI, Type.GetType("System.String"));    // ”í•ÛŒ¯ŽÒŽ‘ŠiŽæ“¾Ž–—R–¼Ì
                    csDataColumn.MaxLength = 10;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKIKOREISKAKSHUTKYMD, Type.GetType("System.String"));        // ”í•ÛŒ¯ŽÒŽ‘ŠiŽæ“¾”NŒŽ“ú
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSJIYUCD, Type.GetType("System.String"));     // ”í•ÛŒ¯ŽÒŽ‘Ši‘rŽ¸Ž–—RƒR[ƒh
                    csDataColumn.MaxLength = 3;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSJIYUMEI, Type.GetType("System.String"));    // ”í•ÛŒ¯ŽÒŽ‘Ši‘rŽ¸Ž–—R–¼Ì
                    csDataColumn.MaxLength = 10;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKIKOREISKAKSSHTSYMD, Type.GetType("System.String"));        // ”í•ÛŒ¯ŽÒŽ‘Ši‘rŽ¸”NŒŽ“ú
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKIKOREITEKIYOKAISHIYMD, Type.GetType("System.String"));     // •ÛŒ¯ŽÒ”Ô†“K—pŠJŽn”NŒŽ“ú
                    csDataColumn.MaxLength = 8;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuEntity.KOKIKOREITEKIYOSHURYOYMD, Type.GetType("System.String"));     // •ÛŒ¯ŽÒ”Ô†“K—pI—¹”NŒŽ“ú
                    csDataColumn.MaxLength = 8;
                }
                else
                {
                    // ŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ª’l‚È‚µ‚Ìê‡‚ÍŒãŠú‚—î€–Ú‚ð’Ç‰Á‚µ‚È‚¢
                }

                // *—š—ð”Ô† 000034 2008/01/15 ’Ç‰ÁI—¹

                // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁŠJŽn
                // –{Ð•M“ªŽÒî•ño—Í”»’è
                if (m_strHonsekiHittoshKB_Param == "1" && m_strHonsekiHittoshKB == "1")
                {
                    // ƒpƒ‰ƒ[ƒ^:–{Ð•M“ªŽÒŽæ“¾‹æ•ª‚ª"1"‚©‚ÂAŠÇ—î•ñ:–{ÐŽæ“¾‹æ•ª(10¥18)‚ª"1"‚Ìê‡‚Ì‚Ýo—Í
                    // –{ÐZŠ
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HON_JUSHO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 200;        // 30
                                                         // –{Ð”Ô’n
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HONSEKIBANCHI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 200;        // 20
                                                         // •M“ªŽÒ
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.HITTOSH, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;        // 30
                }
                else
                {
                }

                // ˆ—’âŽ~‹æ•ªo—Í”»’è
                if (m_strShoriteishiKB == "1" && m_strShoriteishiKB_Param == "1")
                {
                    // ƒpƒ‰ƒ[ƒ^:ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ª‚ª"1"‚©‚ÂAŠÇ—î•ñ:ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ª(10¥19)‚ª"1"‚Ìê‡‚Ì‚Ýo—Í
                    // ˆ—’âŽ~‹æ•ª
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.SHORITEISHIKB, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1;
                }
                else
                {
                }
                // *—š—ð”Ô† 000040 2010/05/14 ’Ç‰ÁI—¹

                // *—š—ð”Ô† 000041 2011/05/18 ’Ç‰ÁŠJŽn
                // ŠO‘lÝ—¯î•ño—Í”»’è
                if (m_strFrnZairyuJohoKB_Param == "1")
                {
                    // ƒpƒ‰ƒ[ƒ^:ŠO‘lÝ—¯î•ñŽæ“¾‹æ•ª‚ª"1"‚Ìê‡‚Ì‚Ý
                    // ‘Ð
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.KOKUSEKI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 20;
                    // Ý—¯Ž‘ŠiƒR[ƒh
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYUSKAKCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 3;
                    // Ý—¯Ž‘Ši
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYUSKAK, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 15;
                    // Ý—¯ŠúŠÔ
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYUKIKAN, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 4;
                    // Ý—¯ŠJŽn”NŒŽ“ú
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYU_ST_YMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    // Ý—¯I—¹”NŒŽ“ú
                    csDataColumn = csDataTable.Columns.Add(ABAtena1Entity.ZAIRYU_ED_YMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                }
                // *—š—ð”Ô† 000041 2011/05/18 ’Ç‰ÁI—¹
                // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁŠJŽn
                // ZŠî–@‰ü³”»’è
                if (m_strJukiHokaiseiKB_Param == "1")
                {
                    // Z–¯•[ó‘Ô‹æ•ª
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUMINHYOJOTAIKBN, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1;
                    // Z‹’n“Ío—L–³ƒtƒ‰ƒO
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKYOCHITODOKEFLG, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1;
                    // –{‘–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.HONGOKUMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                    // ƒJƒi–{‘–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KANAHONGOKUMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 120;
                    // •¹‹L–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KANJIHEIKIMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                    // ƒJƒi•¹‹L–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KANAHEIKIMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 120;
                    // ’ÊÌ–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KANJITSUSHOMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                    // ƒJƒi’ÊÌ–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KANATSUSHOMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 120;
                    // ƒJƒ^ƒJƒi•¹‹L–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KATAKANAHEIKIMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 120;
                    // ¶”NŒŽ“ú•sÚ‹æ•ª
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.UMAREFUSHOKBN, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 2;
                    // ’ÊÌ–¼“o˜^i•ÏXj”NŒŽ“ú
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.TSUSHOMEITOUROKUYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    // Ý—¯ŠúŠÔƒR[ƒh
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.ZAIRYUKIKANCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 7;
                    // Ý—¯ŠúŠÔ–¼Ì
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.ZAIRYUKIKANMEISHO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 10;
                    // ’†’·ŠúÝ—¯ŽÒ‚Å‚ ‚éŽ|“™‚ÌƒR[ƒh
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.ZAIRYUSHACD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 2;
                    // ’†’·ŠúÝ—¯ŽÒ‚Å‚ ‚éŽ|“™
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.ZAIRYUSHAMEISHO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 20;
                    // Ý—¯ƒJ[ƒh“™”Ô†
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.ZAIRYUCARDNO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 12;
                    // “Á•Ê‰iZŽÒØ–¾‘Œð•t”NŒŽ“ú
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KOFUYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    // “Á•Ê‰iZŽÒØ–¾‘Œð•t—\’èŠúŠÔŠJŽn“ú
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KOFUYOTEISTYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    // “Á’è‰iZŽÒØ–¾‘Œð•t—\’èŠúŠÔI—¹“ú
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.KOFUYOTEIEDYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœˆÙ“®”NŒŽ“ú
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKITAISHOSHASHOJOIDOYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœŽ–—RƒR[ƒh
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYUCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 2;
                    // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœŽ–—R
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYU, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 10;
                    // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœ“Ío”NŒŽ“ú
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDYMD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 8;
                    // ZŠî‘ÎÛŽÒi‘æ30ð45”ñŠY“–jÁœ“Ío’Ê’m‹æ•ª
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDTUCIKB, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1;
                    // ŠO‘l¢‘ÑŽå–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.FRNSTAINUSMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                    // ŠO‘l¢‘ÑŽåƒJƒi–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.FRNSTAINUSKANAMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 120;
                    // ¢‘ÑŽå•¹‹L–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.STAINUSHEIKIMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                    // ¢‘ÑŽåƒJƒi•¹‹L–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.STAINUSKANAHEIKIMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 120;
                    // ¢‘ÑŽå’ÊÌ–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.STAINUSTSUSHOMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                    // ¢‘ÑŽåƒJƒi’ÊÌ–¼
                    csDataColumn = csDataTable.Columns.Add(ABAtenaFZYEntity.STAINUSKANATSUSHOMEI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 120;
                }
                else
                {
                    // ˆ—‚È‚µ
                }
                // *—š—ð”Ô† 000046 2011/11/07 ’Ç‰ÁI—¹

                // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁŠJŽn
                // ‹¤’Ê”Ô†”»’è
                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                {
                    // ‹¤’Ê”Ô†
                    csDataColumn = csDataTable.Columns.Add(ABMyNumberEntity.MYNUMBER, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 13;
                }
                else
                {
                    // noop
                }
                // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁI—¹

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }

            catch (UFAppException exException)
            {

                // ƒGƒ‰[ƒƒOo—Í
                m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + default
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
                                                    "yƒGƒ‰[“
               */
);
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 529841


                Input:
                " + exException.Message + "z")

                            ' ƒXƒ[‚·‚é
                            Throw exException

                        Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                      "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 530133


                Input:
                " + Me.GetType.Name + "z" +
                                                      "yƒƒ\ƒbƒh–¼:
                 */
                ;

                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 530214


                                Input:
                                " + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                                      "yƒGƒ‰[“à—e:" + exException.Message + "z")

                                 */
                throw exException;

            }

            // * —š—ð”Ô† 000024 2005/01/25 •ÏXŠJŽni‹{‘òj
            // Return csDataTable
            m_csOrgAtena1Kobetsu = csDataTable;
            return m_csOrgAtena1Kobetsu.Clone();
            // * —š—ð”Ô† 000024 2005/01/25 •ÏXI—¹i‹{‘òj

        }
        // *—š—ð”Ô† 000019 2003/11/19 ’Ç‰ÁI—¹
        #endregion

        // *—š—ð”Ô† 000050 2023/03/10 ’Ç‰ÁŠJŽn
        #region  ˆ¶–¼î•ñ•W€”
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼î•ñ•W€”ÅƒJƒ‰ƒ€ì¬
        // * 
        // * \•¶           Private Function CreateAtena1HyojunColumns() As DataTable
        // * 
        // * ‹@”\@@    @@ˆ¶–¼î•ñ•W€”ÅDataSet‚ÌƒJƒ‰ƒ€‚ðì¬‚·‚é
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         DataSet(ABAtena1Hyojun) : ì¬‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        private DataTable CreateAtena1HyojunColumns()
        {
            DataTable csDataTable;
            DataColumn csDataColumn;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name);

                if (m_csOrgAtena1Hyojun is not null)
                {
                    return m_csOrgAtena1Hyojun.Clone();
                }
                // ˆ¶–¼î•ñ‚æ‚èì¬‚·‚é
                csDataTable = CreateAtena1Columns();
                csDataTable.TableName = ABAtena1HyojunEntity.TABLE_NAME;

                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HENSHUKANASHIMEI_FULL, Type.GetType("System.String"));

                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HENSHUKANJISHIMEI_FULL, Type.GetType("System.String"));

                if (m_blnSelectAll != ABEnumDefine.AtenaGetKB.KaniOnly)
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SEIBETSU_FULL, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 10;
                }
                else
                {
                }
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HENSHUJUSHO_FULL, Type.GetType("System.String"));

                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KATAGAKI_FULL, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1200;
                if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_Kaigo)
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENUMAEJ_KATAGAKI_FULL, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1200;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENSHUTSUYOTEIKATAGAKI_FULL, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1200;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENSHUTSUKKTIKATAGAKI_FULL, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1200;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HENSHUMAEKATAGAKI_FULL, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1200;
                }
                if (m_strFrnZairyuJohoKB_Param == "1")
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KOKUSEKI_FULL, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 100;
                }
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.STAINUSSHIMEIYUSENKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SHIMEIYUSENKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KANJIKYUUJI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 80;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KANAKYUUJI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 20;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SHIMEIKANAKAKUNINFG, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KYUUJIKANAKAKUNINFG, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TSUSHOKANAKAKUNINFG, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.UMAREBIFUSHOPTN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUSHOUMAREBI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 72;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HYOJUNKISAIJIYUCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KISAIYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HYOJUNSHOJOJIYUCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SHOJOIDOWMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SHOJOIDOBIFUSHOPTN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUSHOSHOJOIDOBI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 72;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.CKINIDOWMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.CKINIDOBIFUSHOPTN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUSHOCKINIDOBI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 72;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.JIJITSUSTAINUSMEI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 480;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SHIKUCHOSONCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.MACHIAZACD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TODOFUKEN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 16;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SHIKUCHOSON, Type.GetType("System.String"));
                csDataColumn.MaxLength = 48;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.MACHIAZA, Type.GetType("System.String"));
                csDataColumn.MaxLength = 480;
                if (m_strHonsekiHittoshKB_Param == "1" && m_strHonsekiHittoshKB == "1")
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HON_SHIKUCHOSONCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 6;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HON_MACHIAZACD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 7;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HON_TODOFUKEN, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 16;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HON_SHIKUGUNCHOSON, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 48;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HON_MACHIAZA, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                }
                if (m_blnMethodKB != ABEnumDefine.MethodKB.KB_Kaigo)
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KOKUSEKICD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 3;
                }
                if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_Kaigo)
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENUMAEJ_SHIKUCHOSONCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 6;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENUMAEJ_MACHIAZACD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 7;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENUMAEJ_TODOFUKEN, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 16;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENUMAEJ_SHIKUCHOSON, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 48;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENUMAEJ_MACHIAZA, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENUMAEJ_KOKUSEKICD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 3;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENUMAEJ_KOKUSEKI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 200;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENUMAEJ_KOKUGAIJUSHO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 300;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENSHUTSUYOTEISHIKUCHOSONCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 6;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENSHUTSUYOTEIMACHIAZACD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 7;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENSHUTSUYOTEITODOFUKEN, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 16;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENSHUTSUYOTEISHIKUCHOSON, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 48;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENSHUTSUYOTEIMACHIAZA, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENSHUTSUYOTEIKOKUSEKICD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 3;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENSHUTSUYOTEIKOKUSEKI, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 200;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENSHUTSUYOTEIKOKUGAIJUSHO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 300;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENSHUTSUKKTISHIKUCHOSONCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 6;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENSHUTSUKKTIMACHIAZACD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 7;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENSHUTSUKKTITODOFUKEN, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 16;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENSHUTSUKKTISHIKUCHOSON, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 48;
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TENSHUTSUKKTIMACHIAZA, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                }
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HODAI30JO46MATAHA47KB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.ZAIRYUCARDNOKBN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.JUKYOCHIHOSEICD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.CKINTDKDTUCIKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HANNO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 5;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KAISEIYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HYOJUNIDOKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.NYURYOKUBASHOCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 4;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.NYURYOKUBASHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 30;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.RENRAKUSAKIKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 3;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.RENRAKUSAKIMEI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 400;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.RENRAKUSAKI1_RENRAKUSAKI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 254;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.RENRAKUSAKI2_RENRAKUSAKI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 254;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.RENRAKUSAKI3_RENRAKUSAKI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 254;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU1, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU2, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU3, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 3;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_YUBINNO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_SHICHOSONCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_MACHIAZACD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_TODOFUKEN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 4;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_SHIKUGUNCHOSON, Type.GetType("System.String"));
                csDataColumn.MaxLength = 12;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_MACHIAZA, Type.GetType("System.String"));
                csDataColumn.MaxLength = 480;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_BANCHI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 50;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_KATAGAKI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 300;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_KANAKATAGAKI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 300;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUJOHO_TAISHOSHAKUBUN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 3;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUJOHO_TAISHOSHASHIMEI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 100;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUJOHO_UMAREYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUJOHO_SEIBETSU, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KYOJUFUMEI_YMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUJOHO_BIKO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2000;
                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.BANGOHOKOSHINKB, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1;
                }
                if (m_blnMethodKB == ABEnumDefine.MethodKB.KB_AtenaGet1)
                {
                    csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SERIALNO, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 40;
                }
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HYOJUNIDOJIYUCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SFSKRENRAKUSAKIKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SFSKKBN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.JUMINKBN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.JUMINSHUBETSU, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.JUMINJOTAI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.BANCHIEDABANSUCHI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 20;

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }

            catch (UFAppException exException)
            {

                // ƒGƒ‰[ƒƒOo—Í
                m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + default
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
                                                    "yƒGƒ‰[“
               */
);
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 552154


                Input:
                " + exException.Message + "z")

                            ' ƒXƒ[‚·‚é
                            Throw exException

                        Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                      "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 552446


                Input:
                " + Me.GetType.Name + "z" +
                                                      "yƒƒ\ƒbƒh–¼:
                 */
                ;

                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 552527


                                Input:
                                " + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                                      "yƒGƒ‰[“à—e:" + exException.Message + "z")

                                 */
                throw exException;

            }

            m_csOrgAtena1Hyojun = csDataTable;
            return m_csOrgAtena1Hyojun.Clone();

        }
        #endregion

        #region  ”
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ”N‹à—pˆ¶–¼î•ñ•W€”ÅƒJƒ‰ƒ€ì¬
        // * 
        // * \•¶           Private Function CreateNenkinAtenaHyojunColumns(ByVal strGyomuMei As String) As DataTable
        // * 
        // * ‹@”\@@    @@”N‹à—pˆ¶–¼î•ñ•W€”ÅDataSet‚ÌƒJƒ‰ƒ€‚ðì¬‚·‚é
        // * 
        // * ˆø”           ByVal strGyomuMei As String
        // * 
        // * –ß‚è’l         DataSet(Atena1NenkinHyojun) : ì¬‚µ‚½”N‹à—pˆ¶–¼î•ñ
        // ************************************************************************************************
        private DataTable CreateNenkinAtenaHyojunColumns(string strGyomuMei)
        {
            DataTable csDataTable;
            DataColumn csDataColumn;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name);

                if (m_csOrgAtena1NenkinHyojun is not null)
                {
                    return m_csOrgAtena1NenkinHyojun.Clone();
                }

                // ˆ¶–¼î•ñ‚æ‚èì¬‚·‚é
                csDataTable = CreateNenkinAtenaColumns(strGyomuMei);
                csDataTable.TableName = ABNenkinAtenaHyojunEntity.TABLE_NAME;

                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.HENSHUKANASHIMEI_FULL, Type.GetType("System.String"));

                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.HENSHUKANJISHIMEI_FULL, Type.GetType("System.String"));

                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.SEIBETSU_FULL, Type.GetType("System.String"));
                csDataColumn.MaxLength = 10;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.HENSHUJUSHO_FULL, Type.GetType("System.String"));

                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.KATAGAKI_FULL, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1200;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENUMAEJ_KATAGAKI_FULL, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1200;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIKATAGAKI_FULL, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1200;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTIKATAGAKI_FULL, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1200;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.HENSHUMAEKATAGAKI_FULL, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1200;
                if (m_strFrnZairyuJohoKB_Param == "1")
                {
                    csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.KOKUSEKI_FULL, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 100;
                }
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.STAINUSSHIMEIYUSENKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.SHIMEIYUSENKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.KANJIKYUUJI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 80;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.KANAKYUUJI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 20;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.SHIMEIKANAKAKUNINFG, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.KYUUJIKANAKAKUNINFG, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TSUSHOKANAKAKUNINFG, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.UMAREBIFUSHOPTN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.FUSHOUMAREBI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 72;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.HYOJUNKISAIJIYUCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.KISAIYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.HYOJUNSHOJOJIYUCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.SHOJOIDOWMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.SHOJOIDOBIFUSHOPTN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.FUSHOSHOJOIDOBI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 72;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.CKINIDOWMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.CKINIDOBIFUSHOPTN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.FUSHOCKINIDOBI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 72;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.JIJITSUSTAINUSMEI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 480;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.SHIKUCHOSONCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.MACHIAZACD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TODOFUKEN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 16;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.SHIKUCHOSON, Type.GetType("System.String"));
                csDataColumn.MaxLength = 48;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.MACHIAZA, Type.GetType("System.String"));
                csDataColumn.MaxLength = 480;
                if (m_strHonsekiHittoshKB_Param == "1" && m_strHonsekiHittoshKB == "1")
                {
                    csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.HON_SHIKUCHOSONCD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 6;
                    csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.HON_MACHIAZACD, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 7;
                    csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.HON_TODOFUKEN, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 16;
                    csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.HON_SHIKUGUNCHOSON, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 48;
                    csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.HON_MACHIAZA, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 480;
                }
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENUMAEJ_SHIKUCHOSONCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENUMAEJ_MACHIAZACD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENUMAEJ_TODOFUKEN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 16;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENUMAEJ_SHIKUCHOSON, Type.GetType("System.String"));
                csDataColumn.MaxLength = 48;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENUMAEJ_MACHIAZA, Type.GetType("System.String"));
                csDataColumn.MaxLength = 480;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENUMAEJ_KOKUSEKICD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 3;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENUMAEJ_KOKUSEKI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 200;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENUMAEJ_KOKUGAIJUSHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 300;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEISHIKUCHOSONCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIMACHIAZACD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEITODOFUKEN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 16;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEISHIKUCHOSON, Type.GetType("System.String"));
                csDataColumn.MaxLength = 48;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIMACHIAZA, Type.GetType("System.String"));
                csDataColumn.MaxLength = 480;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIKOKUSEKICD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 3;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIKOKUSEKI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 200;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENSHUTSUYOTEIKOKUGAIJUSHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 300;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTISHIKUCHOSONCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTIMACHIAZACD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTITODOFUKEN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 16;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTISHIKUCHOSON, Type.GetType("System.String"));
                csDataColumn.MaxLength = 48;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.TENSHUTSUKKTIMACHIAZA, Type.GetType("System.String"));
                csDataColumn.MaxLength = 480;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.HODAI30JO46MATAHA47KB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.ZAIRYUCARDNOKBN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.JUKYOCHIHOSEICD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.CKINTDKDTUCIKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.HANNO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 5;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.KAISEIYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.HYOJUNIDOKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.NYURYOKUBASHOCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 4;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.NYURYOKUBASHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 30;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.RENRAKUSAKIKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 3;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.RENRAKUSAKIMEI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 400;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.RENRAKUSAKI1_RENRAKUSAKI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 254;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.RENRAKUSAKI2_RENRAKUSAKI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 254;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.RENRAKUSAKI3_RENRAKUSAKI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 254;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.RENRAKUSAKISHUBETSU1, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.RENRAKUSAKISHUBETSU2, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.RENRAKUSAKISHUBETSU3, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                if (m_strMyNumberKB_Param == ABConstClass.MYNUMBER.MYNUMBERKB.ON)
                {
                    csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.BANGOHOKOSHINKB, Type.GetType("System.String"));
                    csDataColumn.MaxLength = 1;
                }
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.HYOJUNIDOJIYUCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.JUMINKBN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.JUMINSHUBETSU, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.JUMINJOTAI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csDataTable.Columns.Add(ABNenkinAtenaHyojunEntity.BANCHIEDABANSUCHI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 20;

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }

            catch (UFAppException exException)
            {

                // ƒGƒ‰[ƒƒOo—Í
                m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + default
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
                                                    "yƒGƒ‰[“
               */
);
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 570440


                Input:
                " + exException.Message + "z")

                            ' ƒXƒ[‚·‚é
                            Throw exException

                        Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                      "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 570732


                Input:
                " + Me.GetType.Name + "z" +
                                                      "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                      "yƒGƒ‰[“à—e:" + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        m_csOrgAtena1Hyojun = csDataTable
                        Return m_csOrgAtena1Hyojun.Clone

                    End Function
                #End Region

                #Region " ˆ¶–¼ŒÂ•Êî•ñ•W€”ÅƒJƒ‰ƒ€ì¬(CreateAtena1KobetsuHyojunColumns) "
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼ŒÂ•Êî•ñ•W€”ÅƒJƒ‰ƒ€ì¬
                    '* 
                    '* \•¶           Private Function CreateAtena1KobetsuHyojunColumns() As DataTable
                    '* 
                    '* ‹@”\@@    @@ˆ¶–¼ŒÂ•Êî•ñ•W€”ÅDataSet‚ÌƒJƒ‰ƒ€‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           ‚È‚µ
                    '* 
                    '* –ß‚è’l         DataSet(Atena1KobetsuHyojun) : ì¬‚µ‚½ˆ¶–¼ŒÂ•Êî•ñ
                    '************************************************************************************************
                    Private Function CreateAtena1KobetsuHyojunColumns() As DataTable
                        Dim csDataTable As DataTable
                        Dim csDataColumn As DataColumn

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, Me.GetType.Name, System.Reflection.MethodBase.GetCurrentMethod.Name)

                            If Not (m_csOrgAtena1KobetsuHyojun Is Nothing) Then
                                Return m_csOrgAtena1KobetsuHyojun.Clone
                            End If

                            ' ˆ¶–¼î•ñ‚æ‚èì¬‚·‚é
                            csDataTable = CreateAtena1KobetsuColumns()
                            csDataTable.TableName = ABAtena1KobetsuHyojunEntity.TABLE_NAME

                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HENSHUKANASHIMEI_FULL, System.Type.GetType("System.String"))

                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HENSHUKANJISHIMEI_FULL, System.Type.GetType("System.String"))

                            If (m_blnSelectAll <> ABEnumDefine.AtenaGetKB.KaniOnly) Then
                                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SEIBETSU_FULL, System.Type.GetType("System.String"))
                                csDataColumn.MaxLength = 10
                            Else
                            End If
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HENSHUJUSHO_FULL, System.Type.GetType("System.String"))

                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KATAGAKI_FULL, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1200
                            If (m_strFrnZairyuJohoKB_Param = "1") Then
                                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KOKUSEKI_FULL, System.Type.GetType("System.String"))
                                csDataColumn.MaxLength = 100
                            End If
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.STAINUSSHIMEIYUSENKB, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SHIMEIYUSENKB, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KANJIKYUUJI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 80
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KANAKYUUJI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 20
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SHIMEIKANAKAKUNINFG, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KYUUJIKANAKAKUNINFG, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TSUSHOKANAKAKUNINFG, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.UMAREBIFUSHOPTN, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUSHOUMAREBI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 72
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HYOJUNKISAIJIYUCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KISAIYMD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HYOJUNSHOJOJIYUCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SHOJOIDOWMD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 7
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SHOJOIDOBIFUSHOPTN, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUSHOSHOJOIDOBI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 72
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.CKINIDOWMD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 7
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.CKINIDOBIFUSHOPTN, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUSHOCKINIDOBI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 72
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.JIJITSUSTAINUSMEI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 480
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SHIKUCHOSONCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 6
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.MACHIAZACD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 7
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.TODOFUKEN, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 16
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SHIKUCHOSON, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 48
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.MACHIAZA, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 480
                            If (m_strHonsekiHittoshKB_Param = "1" AndAlso m_strHonsekiHittoshKB = "1") Then
                                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HON_SHIKUCHOSONCD, System.Type.GetType("System.String"))
                                csDataColumn.MaxLength = 6
                                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HON_MACHIAZACD, System.Type.GetType("System.String"))
                                csDataColumn.MaxLength = 7
                                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HON_TODOFUKEN, System.Type.GetType("System.String"))
                                csDataColumn.MaxLength = 16
                                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HON_SHIKUGUNCHOSON, System.Type.GetType("System.String"))
                                csDataColumn.MaxLength = 48
                                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HON_MACHIAZA, System.Type.GetType("System.String"))
                                csDataColumn.MaxLength = 480
                            End If
                            If m_blnMethodKB <> ABEnumDefine.MethodKB.KB_Kaigo Then
                                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KOKUSEKICD, System.Type.GetType("System.String"))
                                csDataColumn.MaxLength = 3
                            End If
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HODAI30JO46MATAHA47KB, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.ZAIRYUCARDNOKBN, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.JUKYOCHIHOSEICD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.CKINTDKDTUCIKB, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HANNO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 5
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KAISEIYMD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HYOJUNIDOKB, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.NYURYOKUBASHOCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 4
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.NYURYOKUBASHO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 30
                            csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuHyojunEntity.KAIGOHIHOKENSHAGAITOKB, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuHyojunEntity.KOKUHOHIHOKENSHAGAITOKB, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuHyojunEntity.NENKINHIHOKENSHAGAITOKB, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuHyojunEntity.NENKINSHUBETSUHENKOYMD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuHyojunEntity.SENKYOTOROKUJOTAIKBN, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2
                            If (m_strKobetsuShutokuKB = "1") Then
                                csDataColumn = csDataTable.Columns.Add(ABAtena1KobetsuHyojunEntity.KOKIKOREIHIHOKENSHAGAITOKB, System.Type.GetType("System.String"))
                                csDataColumn.MaxLength = 1
                            End If
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.RENRAKUSAKIKB, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 3
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.RENRAKUSAKIMEI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 400
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.RENRAKUSAKI1_RENRAKUSAKI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 254
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.RENRAKUSAKI2_RENRAKUSAKI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 254
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.RENRAKUSAKI3_RENRAKUSAKI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 254
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU1, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU2, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU3, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUKB, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 3
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_YUBINNO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 7
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_SHICHOSONCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 6
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_MACHIAZACD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 7
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_TODOFUKEN, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 4
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_SHIKUGUNCHOSON, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 12
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_MACHIAZA, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 480
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_BANCHI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 50
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_KATAGAKI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 300
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUDATTAJUSHO_KANAKATAGAKI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 300
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUJOHO_TAISHOSHAKUBUN, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 3
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUJOHO_TAISHOSHASHIMEI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 100
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUJOHO_UMAREYMD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUJOHO_SEIBETSU, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.KYOJUFUMEI_YMD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.FUGENJUJOHO_BIKO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2000
                            If (m_strMyNumberKB_Param = ABConstClass.MYNUMBER.MYNUMBERKB.ON) Then
                                csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.BANGOHOKOSHINKB, System.Type.GetType("System.String"))
                                csDataColumn.MaxLength = 1
                            End If
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SERIALNO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 40
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.HYOJUNIDOJIYUCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SFSKRENRAKUSAKIKB, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.SFSKKBN, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.JUMINKBN, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.JUMINSHUBETSU, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.JUMINJOTAI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABAtena1HyojunEntity.BANCHIEDABANSUCHI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 20

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, Me.GetType.Name, System.Reflection.MethodBase.GetCurrentMethod.Name)

                        Catch exException As UFAppException

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                      "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                                                      "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                      "yƒGƒ‰[“à—e:" + exException.Message + "z")

                            ' ƒXƒ[‚·‚é
                            Throw exException

                        Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                      "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                                                      "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                      "yƒGƒ‰[“à—e:" + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        m_csOrgAtena1Hyojun = csDataTable
                        Return m_csOrgAtena1Hyojun.Clone

                    End Function
                #End Region
                    '*—š—ð”Ô† 000050 2023/03/10 ’Ç‰ÁI—¹

                #Region " ‘—•tæZŠs­‹æ•ÒW‹æ•ªŽæ“¾(GetSofuJushoGyoseikuType) "
                    '*—š—ð”Ô† 000016 2003/08/22 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‘—•tæZŠs­‹æ•ÒW‹æ•ªŽæ“¾
                    '* 
                    '* \•¶           Private Function GetSofuJushoGyoseikuType() As SofuJushoGyoseikuType
                    '* 
                    '* ‹@”\@@    @@‘—•tæZŠs­‹æ•ÒW‹æ•ª‚ðŽæ“¾‚·‚é
                    '* 
                    '* ˆø”           ‚È‚µ
                    '* 
                    '* –ß‚è’l         SofuJushoGyoseikuType
                    '************************************************************************************************
                    <SecuritySafeCritical>
                    Protected Overridable Function GetSofuJushoGyoseikuType() As SofuJushoGyoseikuType
                        Const THIS_METHOD_NAME As String = "GetSofuJushoGyoseikuType"
                        '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                        'Dim cURKanriJohoB As URKANRIJOHOCacheBClass         'ŠÇ—î•ñŽæ“¾ƒNƒ‰ƒX
                        '* —š—ð”Ô† 000023 2004/08/27 íœI—¹
                        Dim cSofuJushoGyoseikuType As SofuJushoGyoseikuType

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                            'ŠÇ—î•ñŽæ“¾‚a‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                            'cURKanriJohoB = New URKANRIJOHOCacheBClass(m_cfUFControlData, m_cfUFConfigDataClass, m_cfUFRdbClass)
                            '* —š—ð”Ô† 000023 2004/08/27 íœI—¹

                            '* —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                            'cSofuJushoGyoseikuType = m_cURKanriJohoB.GetSofuJushoGyoseiku_SofuJushoGyoseiku_Param
                            If (m_bSofuJushoGyoseikuTypeFlg = False) Then
                                m_cSofuJushoGyoseikuType = m_cURKanriJohoB.GetSofuJushoGyoseiku_SofuJushoGyoseiku_Param
                                m_bSofuJushoGyoseikuTypeFlg = True
                            End If
                            cSofuJushoGyoseikuType = m_cSofuJushoGyoseikuType
                            '* —š—ð”Ô† 000024 2005/01/25 XVI—¹i‹{‘òj

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException    ' UFAppException‚ðƒLƒƒƒbƒ`
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfUFLogClass.WarningWrite(m_cfUFControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp
                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return cSofuJushoGyoseikuType

                    End Function
                    '*—š—ð”Ô† 000016 2003/08/22 ’Ç‰ÁI—¹
                #End Region

                    '*—š—ð”Ô† 000042 2011/05/18 ’Ç‰ÁŠJŽn
                #Region "–¼Ì•ÒWˆ—(MeishoHenshu)"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼       –¼Ì•ÒWˆ—
                    '* 
                    '* \•¶             Private Function MeishoHenshu(ByVal csAtenaDataRow As DataRow) As String()
                    '* 
                    '* ‹@”\@@    @   –{–¼’ÊÌ–¼—p–¼Ì•ÒWˆ—‚ðs‚¤
                    '* 
                    '* ˆø”             csAtenaDataRow  : DataRow(ˆ¶–¼ƒf[ƒ^)
                    '* 
                    '* –ß‚è’l           String()        : ”z—ñ[ƒJƒi–¼ÌAŠ¿Žš–¼Ì]
                    '************************************************************************************************
                    Private Function MeishoHenshu(ByVal csAtenaDataRow As DataRow) As String()
                        Const THIS_METHOD_NAME As String = "MeishoHenshu"
                        Dim strMeisho(1) As String                          ' •Ô‹p—p–¼Ì”z—ñ[ƒJƒi–¼ÌAŠ¿Žš–¼Ì]
                        Dim strGroupID As String                            ' ƒOƒ‹[ƒvID
                        Dim csMeishoSeigyoDS As DataSet                     ' –¼Ì§Œäƒf[ƒ^—pƒf[ƒ^ƒZƒbƒg
                        Dim blnMeishoSeigyoFlg As Boolean                   ' –¼Ì§Œäƒtƒ‰ƒO
                        Dim strRiyoFlg As String = String.Empty             ' —˜—pƒtƒ‰ƒO
                        '*—š—ð”Ô† 000043 2011/06/23 ’Ç‰ÁŠJŽn
                        Dim cuUrlPrmData As USUrlPrmData                    ' URLƒpƒ‰ƒ[ƒ^ƒCƒ“ƒ^[ƒtƒF[ƒX
                        Const DEFAULT_VALUE As String = "01"
                        '*—š—ð”Ô† 000043 2011/06/23 ’Ç‰ÁI—¹


                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ‰Šú‰»ˆ—
                            strMeisho(0) = String.Empty
                            strMeisho(1) = String.Empty

                            '*—š—ð”Ô† 000043 2011/06/23 C³ŠJŽn
                            '**
                            '* ‰Ûî•ñŽæ“¾ˆ—
                            '*
                            'URLƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            If (m_cuUSSUrlParm Is Nothing) Then
                                m_cuUSSUrlParm = New USUrlParmClass
                            End If

                            '‰Ûî•ñ‚ÌŽæ“¾
                            cuUrlPrmData = m_cuUSSUrlParm.getURLPrm(m_cfUFControlData, USUrlParmClass.PrmType.ToshimaAtenaType, DEFAULT_VALUE)
                            strGroupID = cuUrlPrmData.p_strPrm

                            'strGroupID = "01"
                            '*—š—ð”Ô† 000043 2011/06/23 C³I—¹

                            '**
                            '* —Dæ–¼Ìî•ñŽæ“¾ˆ—
                            '*
                            ' •\Ž¦–¼Ì§Œä‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                            If (m_cABMeishoSeigyoB Is Nothing) Then
                                m_cABMeishoSeigyoB = New ABMeishoSeigyoBClass(m_cfUFControlData, m_cfUFConfigDataClass, m_cfUFRdbClass)
                            End If

                            ' •\Ž¦–¼Ì§Œäƒf[ƒ^Žæ“¾
                            csMeishoSeigyoDS = m_cABMeishoSeigyoB.GetMeishoSeigyo(CStr(csAtenaDataRow(ABAtenaEntity.JUMINCD)), strGroupID)

                            If (Not (csMeishoSeigyoDS Is Nothing) AndAlso csMeishoSeigyoDS.Tables(ABMeishoSeigyoEntity.TABLE_NAME).Rows.Count > 0) Then
                                ' •\Ž¦–¼Ì§Œäƒf[ƒ^‚ª‘¶Ý‚·‚éê‡
                                ' —˜—pƒtƒ‰ƒOŽæ“¾
                                strRiyoFlg = csMeishoSeigyoDS.Tables(ABMeishoSeigyoEntity.TABLE_NAME).Rows(0)(ABMeishoSeigyoEntity.RIYOFG).ToString

                                blnMeishoSeigyoFlg = True
                            Else
                                ' •\Ž¦–¼Ì§Œäƒf[ƒ^‚ª‘¶Ý‚µ‚È‚¢ê‡
                                strRiyoFlg = String.Empty

                                blnMeishoSeigyoFlg = False
                            End If

                            '**
                            '* –¼Ì•ÒWˆ—
                            '*
                            If (blnMeishoSeigyoFlg = True) Then
                                Select Case strRiyoFlg
                                    Case "0"        ' –{–¼
                                        '*—š—ð”Ô† 000045 2011/06/27 ’Ç‰ÁŠJŽn
                                        If (csAtenaDataRow(ABAtenaEntity.KANJIMEISHO2).ToString.Trim <> String.Empty) Then
                                            ' Š¿Žš–¼Ì‚Q‚ª‹ó”’ˆÈŠO‚Ìê‡AƒJƒi–¼Ì‚QAŠ¿Žš–¼Ì‚Q‚ðƒZƒbƒg
                                            strMeisho(0) = csAtenaDataRow(ABAtenaEntity.KANAMEISHO2).ToString
                                            strMeisho(1) = csAtenaDataRow(ABAtenaEntity.KANJIMEISHO2).ToString
                                        Else
                                            ' Š¿Žš–¼Ì‚Q‚ª‹ó”’‚Ìê‡AƒJƒi–¼Ì‚PAŠ¿Žš–¼Ì‚P‚ðƒZƒbƒg
                                            strMeisho(0) = csAtenaDataRow(ABAtenaEntity.KANAMEISHO1).ToString
                                            strMeisho(1) = csAtenaDataRow(ABAtenaEntity.KANJIMEISHO1).ToString
                                        End If
                                        'strMeisho(0) = csAtenaDataRow(ABAtenaEntity.KANAMEISHO2).ToString
                                        'strMeisho(1) = csAtenaDataRow(ABAtenaEntity.KANJIMEISHO2).ToString
                                        '*—š—ð”Ô† 000045 2011/06/27 ’Ç‰ÁI—¹

                                    Case "1"        ' ’ÊÌ–¼
                                        strMeisho(0) = csAtenaDataRow(ABAtenaEntity.KANAMEISHO1).ToString
                                        strMeisho(1) = csAtenaDataRow(ABAtenaEntity.KANJIMEISHO1).ToString

                                    Case Else       ' ‚»‚êˆÈŠO
                                        strMeisho(0) = csAtenaDataRow(ABAtenaEntity.KANAMEISHO1).ToString
                                        strMeisho(1) = csAtenaDataRow(ABAtenaEntity.KANJIMEISHO1).ToString

                                End Select
                            Else
                                strMeisho(0) = csAtenaDataRow(ABAtenaEntity.KANAMEISHO1).ToString
                                strMeisho(1) = csAtenaDataRow(ABAtenaEntity.KANJIMEISHO1).ToString
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException    ' UFAppException‚ðƒLƒƒƒbƒ`
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfUFLogClass.WarningWrite(m_cfUFControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return strMeisho

                    End Function
                #End Region
                    '*—š—ð”Ô† 000042 2011/05/18 ’Ç‰ÁI—¹

                #Region "—ïã“úƒ`ƒFƒbƒN "
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     —ïã“úƒ`ƒFƒbƒN
                    '* 
                    '* \•¶           Private Function CheckDate(ByVal strDate As String) As Boolean
                    '* 
                    '* ‹@”\@@    @@—ïã“úƒ`ƒFƒbƒN‚ðs‚È‚¤
                    '* 
                    '* ˆø”           strDate As String
                    '* 
                    '* –ß‚è’l         Boolean
                    '************************************************************************************************
                    <SecuritySafeCritical>
                    Private Function CheckDate(ByVal strDate As String) As Boolean
                        Const THIS_METHOD_NAME As String = "CheckDate"
                        Dim blnResult As Boolean

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            m_cfDate.p_strDateValue = strDate
                            blnResult = m_cfDate.CheckDate

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException    ' UFAppException‚ðƒLƒƒƒbƒ`
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfUFLogClass.WarningWrite(m_cfUFControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp
                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return blnResult

                    End Function

                #End Region

                #Region "¼—ï––“úŽZo "
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ¼—ï––“úŽZo
                    '* 
                    '* \•¶           Private Function GetSeirekiLastDay(ByVal strDate As String) As String
                    '* 
                    '* ‹@”\@@    @@¼—ï‚Ì––“úŽZo‚ðs‚È‚¤
                    '* 
                    '* ˆø”           strDate As String
                    '* 
                    '* –ß‚è’l         String
                    '************************************************************************************************
                    <SecuritySafeCritical>
                    Private Function GetSeirekiLastDay(ByVal strDate As String) As String
                        Const THIS_METHOD_NAME As String = "GetSeirekiLastDay"
                        Dim strResult As String

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            m_cfDate.p_strDateValue = strDate.RSubstring(0, 6) + "01"
                            strResult = m_cfDate.GetLastDay()

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException    ' UFAppException‚ðƒLƒƒƒbƒ`
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfUFLogClass.WarningWrite(m_cfUFControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp
                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return strResult

                    End Function

                #End Region

                #Region "˜a—ï––“úŽZo "
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˜a—ï––“úŽZo
                    '* 
                    '* \•¶           Private Function GetWarekiLastDay(ByVal strDate As String) As String
                    '* 
                    '* ‹@”\@@    @@˜a—ï‚Ì––“úŽZo‚ðs‚È‚¤
                    '* 
                    '* ˆø”           String
                    '* 
                    '* –ß‚è’l         Boolean
                    '************************************************************************************************
                    <SecuritySafeCritical>
                    Private Function GetWarekiLastDay(ByVal strDate As String, ByVal strSeireki As String) As String
                        Const THIS_METHOD_NAME As String = "GetWarekiLastDay"
                        Dim strWork As String
                        Dim strResult As String

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            strWork = GetSeirekiLastDay(strSeireki)
                            strResult = strDate.RSubstring(0, 5) + strWork.RSubstring(6, 2)

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException    ' UFAppException‚ðƒLƒƒƒbƒ`
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfUFLogClass.WarningWrite(m_cfUFControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp
                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return strResult

                    End Function

                #End Region

                End Class

                 */
            }

            return default;
        }
    }
}