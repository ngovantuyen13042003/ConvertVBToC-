// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‚`‚aˆ¶–¼Žæ“¾(ABAtenaGetClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/01/06@‘ê‘ò@‹Ô–ç
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/02/19 000001     ŠÈˆÕˆ¶–¼Žæ“¾‚P‚ÅAŠÇ—î•ñ‚ªˆø‚«“n‚³‚ê‚È‚¢ƒP[ƒX‚ª‚ ‚éB
// *                       ŠÈˆÕˆ¶–¼Žæ“¾‚P‚ÅA‹Æ–±ƒR[ƒh‚ªŽw’è‚³‚ê‚Ä‚¢‚ÄAŽæ“¾Œ”‚ª‚PŒ‚Ìê‡‚ÍA‘—•tæƒf[ƒ^‚ª‚È‚­‚Ä‚àA‘—•tæƒŒƒR[ƒh‚ð–ß‚·
// * 2003/02/25 000002     ŠÈˆÕˆ¶–¼Žæ“¾‚Pƒƒbƒ\ƒbƒh‚ÅA16E17‚Åƒf[ƒ^Žæ“¾‚OŒ‚Ìê‡‚ÍAƒGƒ‰[‚É‚¹‚¸‚ÉcsAtenaH‚ÆcsAtenaHS ‚ðƒ}[ƒW‚µ‚Ä–ß‚·B
// * 2003/02/26 000003     Žs’¬‘ºƒR[ƒh‚Ì’ŠoðŒ‚ð’Ç‰Á
// * 2003/03/07 000004     ƒvƒƒWƒFƒNƒg‚ÌImports‚Í’è‹`‚µ‚È‚¢iŽd—l•ÏXj
// * 2003/03/07 000005     —LŒøŒ…”‘Î‰žiŽd—l•ÏXj
// * 2003/03/17 000006     ƒpƒ‰ƒ[ƒ^‚Ìƒ`ƒFƒbƒN‚ð‚Í‚¸‚·iŽd—l•ÏXj
// * 2003/03/17 000007     ‹Æ–±"AB"ŒÅ’è‚ÅRDB‚ðƒAƒNƒZƒX‚·‚éiŽd—l•ÏXj
// * 2003/03/18 000008     ƒGƒ‰[ƒƒbƒZ[ƒW‚Ì•ÏXiŽd—l•ÏXj
// * 2003/03/27 000009     ƒGƒ‰[ˆ—ƒNƒ‰ƒX‚ÌŽQÆæ‚ð"AB"ŒÅ’è‚É‚·‚é
// * 2003/04/18 000010     ”N‹àˆ¶–¼Žæ“¾ƒƒ\ƒbƒhE‘•Ûˆ¶–¼—š—ðŽæ“¾ƒƒ\ƒbƒh‚ð’Ç‰Á
// * 2003/04/22 000011     ƒf[ƒ^‚ªŽæ“¾o—ˆ‚È‚­‚Ä‚à—áŠO‚ð”­¶‚³‚¹‚È‚¢
// * 2003/04/30 000012     ƒf[ƒ^‚ªŽæ“¾‚Å‚«‚È‚©‚Á‚½ê‡‚àA0Œ‚Å•ÒWƒf[ƒ^‚ð•Ô‚·B
// * 2003/05/22 000013     RDB‚ÌConnect‚ÍÒ¿¯ÄÞ‚Ìæ“ª‚É•ÏX(Žd—l•ÏX)
// * 2003/06/17 000014     ƒ`ƒ…[ƒjƒ“ƒO(ŠÇ—î•ñŽæ“¾‚ðÅ¬ŒÀ‚É‚·‚é)
// * 2003/08/21 000015     ‚t‚qƒLƒƒƒbƒVƒ…‘Î‰ž^Œp³‰Â”\ƒNƒ‰ƒX‚É•ÏX
// * 2003/09/08 000016     ‘•Ûˆ¶–¼—š—ðŽæ“¾‚ÌŽd—l•ÏX
// * 2003/10/09 000017     ˜A—æ‚ÍA˜A—æƒ}ƒXƒ^‚Éƒf[ƒ^‚ª‘¶Ý‚·‚éê‡‚ÍA‚»‚¿‚ç‚©‚çŽæ“¾‚·‚éB’A‚µA‹Æ–±ƒR[ƒh‚ªŽw’è‚³‚ê‚Ä‚½ê‡‚Ì‚Ý‚ÉŒÀ‚éB
// *                       NenkinAtenaGet‚àAtenaGet1‚Æ“¯—l‚ÉŽw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚½‚çAˆ¶–¼—š—ð‚æ‚èŽæ“¾‚·‚éB˜A—æ‚à“¯—lB’A‚µA‘ã”[E‡ŽZ‚Í•s—vB
// * 2003/10/30 000018     p_strJukiJushoCD‚Í8Œ…
// * 2003/10/30 000019     Žd—l•ÏXFƒJƒ^ƒJƒiƒ`ƒFƒbƒN‚ðANKƒ`ƒFƒbƒN‚É•ÏX
// * 2003/11/19 000020     Žd—l’Ç‰ÁFŠÈˆÕˆ¶–¼Žæ“¾1(ƒI[ƒo[ƒ[ƒh)ƒƒ\ƒbƒh‚Ì’Ç‰Á
// * 2003/12/01 000021     Žd—l•ÏXFƒf[ƒ^‹æ•ª'1%'‚Ìê‡AŒÂl‚Ì‚Ý‚ðŽæ“¾‚·‚é
// * 2003/12/02 000022     Žd—l•ÏXF˜A—æŽæ“¾ˆ—‚ðˆ¶–¼•ÒW‚©‚çˆ¶–¼Žæ“¾‚ÖˆÚ“®
// * 2004/08/27 000023     ‘¬“x‰ü‘PFi‹{‘òj
// * 2005/01/25 000024     ‘¬“x‰ü‘P‚QFi‹{‘òj
// * 2005/04/04 000025     ‘SŠp‚Å‚Ì‚ ‚¢‚Ü‚¢ŒŸõ‚ð‰Â”\‚É‚·‚é(ƒ}ƒ‹ƒS‘ºŽR)
// * 2005/04/21 000026     ‘ã”[E‘—•tæ‚ÌŠúŠÔŽw’è“ú‚ðƒVƒXƒeƒ€“ú•t‚É‚·‚é
// * 2005/05/06 000027     ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN‚ðTRIM‚µ‚Ä‚©‚çs‚È‚¤B«•Ê’P“Æ‚Í‹–‚³‚È‚¢B
// * 2005/12/06 000028     CheckColumnValueƒƒ\ƒbƒh‚Ås­‹æ‚b‚c‚Í‚`‚m‚jƒ`ƒFƒbƒN‚ðs‚¤B(ƒ}ƒ‹ƒS‘ºŽR)
// * 2006/07/31 000029     ”N‹àˆ¶–¼ƒQƒbƒg‡U’Ç‰Á‚É”º‚¤C³ (‹gàV)
// * 2007/04/21 000030     ‰îŒì”Åˆ¶–¼Žæ“¾ƒƒ\ƒbƒh‚Ì’Ç‰Á (‹gàV)
// * 2007/07/28 000031     “¯ˆêl‘ã•\ŽÒŽæ“¾‹@”\‚Ì’Ç‰Á (‹gàV)
// * 2007/09/04 000032     ŠO‘l–{–¼ŒŸõ‹@”\‚Ì’Ç‰ÁFŒŸõƒJƒi–¼•ÒW—pƒƒ\ƒbƒh’Ç‰Ái’†‘òj
// * 2007/09/13 000033     ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^‚ÌZ–¯ƒR[ƒh‚ðƒgƒŠƒ€‚·‚éup_strJuminCDv (‹gàV)
// * 2007/10/10 000034     ŒŸõ—pƒJƒi€–Ú‚ÉƒAƒ‹ƒtƒ@ƒxƒbƒg‚ª“ü‚Á‚Ä‚«‚½ê‡‚Í‘å•¶Žš‚É•ÏŠ·i’†‘òj
// * 2007/10/10 000035     ŠO‘l–{–¼ŒŸõ‚Å–¼‘O‚Ìæ“ª‚ªuƒEv‚Ìê‡‚ÌŒŸõ˜R‚ê‘Î‰ži’†‘òj
// * 2007/11/06 000036     ŒŸõƒJƒi•ÒWƒƒ\ƒbƒhAŽd—l’Ê‚è•ÒW‚³‚ê‚È‚¢•”•ª‚ðC³i’†‘òj
// * 2008/01/17 000037     “¯ˆêl‘ã•\ŽÒŽæ“¾‚É‚æ‚éZ–¯ƒR[ƒhŒë‚è‚Ì•s‹ï‡‘Î‰ži‹gàVj
// * 2008/01/17 000038     ˆ¶–¼ŒÂ•Êî•ñ‚ðŽæ“¾‚·‚éŽžAŒÂ•ÊŽ–€Žæ“¾‹æ•ª‚ðˆø”‚ÉÝ’è‚·‚é‚æ‚¤C³i”ä‰Ãj
// * 2008/02/17 000039     Ž–¼ŠÈ—ª•¶Žš•ÒWˆ—‚ð’Ç‰Ái”ä‰Ãj
// * 2008/11/10 000040     —˜—p“ÍoŽæ“¾ˆ—‚ð’Ç‰Ái”ä‰Ãj
// * 2008/11/17 000041     —˜—p“ÍŠY“–ƒf[ƒ^iž‚Ýˆ—‚ÌC³i”ä‰Ãj
// * 2008/11/18 000042     —˜—p“ÍoŽæ“¾ˆ—‚Ì’Ç‰Á‚É”º‚¤A˜A—æƒf[ƒ^Žæ“¾ˆ—‚Ì‰üCi”ä‰Ãj
// * 2009/04/08 000043     ŒŸõƒL[–³‚µ‚ÅAtnaGet2‚ðŽg—p‚·‚é‚ÆƒIƒuƒWƒFƒNƒgŽQÆƒGƒ‰[‚ª”­¶‚·‚é•s‹ï‡‰üCi’†‘òj
// * 2010/04/16 000044     VS2008‘Î‰ži”ä‰Ãj
// * 2010/05/17 000045     –{Ð•M“ªŽÒ‹y‚Ñˆ—’âŽ~‹æ•ª‘Î‰ži”ä‰Ãj
// * 2011/05/18 000046     ŠO‘lÝ—¯î•ñŽæ“¾‹æ•ª‘Î‰ži”ä‰Ãj
// * 2011/11/07 000047     yAB17010zZŠî–@‰ü³‹æ•ª’Ç‰Á‘Î‰ži’r“cj
// * 2014/04/28 000048     yAB21040zƒ‹¤’Ê”Ô†‘Î‰ž„‹¤’Ê”Ô†Žæ“¾‹æ•ª’Ç‰ÁiÎ‡j
// * 2018/03/08 000049     yAB26001z—š—ðŒŸõ‹@”\’Ç‰ÁiÎ‡j
// * 2020/01/31 000050     yAB00185zAtenaGet1ˆÈŠO‚Ì—š—ðŒŸõ‹@”\’Ç‰ÁiÎ‡j
// * 2020/11/04 000051     yAB00189z—˜—p“Ío•¡””[ÅŽÒID‘Î‰ži{]j
// * 2023/03/10 000052     yAB-0970-1zˆ¶–¼GETŽæ“¾€–Ú•W€‰»‘Î‰ži’‡¼j
// * 2023/12/04 000053     yAB-1600-1zŒŸõ‹@”\‘Î‰ž(‰º‘º)
// * 2024/03/07 000054     yAB-0900-1zƒAƒhƒŒƒXEƒx[ƒXEƒŒƒWƒXƒgƒŠ‘Î‰ž(‰º‘º)
// ************************************************************************************************
using System;
using System.Data;
using System.Linq;
using System.Security;

namespace Densan.Reams.AB.AB000BB
{

    // ************************************************************************************************
    // *
    // * ˆ¶–¼Žæ“¾‚ÉŽg—p‚·‚éƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
    // *
    // ************************************************************************************************
    public class ABAtenaGetBClass
    {

        #region  ƒƒ“
        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        // * —š—ð”Ô† 000015 2003/08/21 C³ŠJŽn
        // Private m_cfLogClass As UFLogClass                      ' ƒƒOo—ÍƒNƒ‰ƒX
        // Private m_cfControlData As UFControlData                ' ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        // Private m_cfConfigDataClass As UFConfigDataClass        ' ƒRƒ“ƒtƒBƒOƒf[ƒ^
        // Private m_cfRdbClass As UFRdbClass                      ' ‚q‚c‚aƒNƒ‰ƒX
        // Private m_cfErrorClass As UFErrorClass                  ' ƒGƒ‰[ˆ—ƒNƒ‰ƒX

        // Private m_intHyojiketaJuminCD As Integer                ' Z–¯ƒR[ƒh•\Ž¦Œ…”
        // Private m_intHyojiketaStaiCD As Integer                 ' ¢‘ÑƒR[ƒh•\Ž¦Œ…”
        // Private m_intHyojiketaJushoCD As Integer                ' ZŠƒR[ƒh•\Ž¦Œ…”iŠÇ“à‚Ì‚Ýj
        // Private m_intHyojiketaGyoseikuCD As Integer             ' s­‹æƒR[ƒh•\Ž¦Œ…”
        // Private m_intHyojiketaChikuCD1 As Integer               ' ’n‹æƒR[ƒh‚P•\Ž¦Œ…”
        // Private m_intHyojiketaChikuCD2 As Integer               ' ’n‹æƒR[ƒh‚Q•\Ž¦Œ…”
        // Private m_intHyojiketaChikuCD3 As Integer               ' ’n‹æƒR[ƒh‚R•\Ž¦Œ…”
        // Private m_strChikuCD1HyojiMeisho As String              ' ’n‹æƒR[ƒh‚P•\Ž¦–¼Ì
        // Private m_strChikuCD2HyojiMeisho As String              ' ’n‹æƒR[ƒh‚Q•\Ž¦–¼Ì
        // Private m_strChikuCD3HyojiMeisho As String              ' ’n‹æƒR[ƒh‚R•\Ž¦–¼Ì
        // Private m_strRenrakusaki1HyojiMeisho As String          ' ˜A—æ‚P•\Ž¦–¼Ì
        // Private m_strRenrakusaki2HyojiMeisho As String          ' ˜A—æ‚Q•\Ž¦–¼Ì
        // '* —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
        // Private m_blnKanriJoho As Boolean                       ' ŠÇ—î•ñŽæ“¾
        // '* —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹

        // '@ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        // Private Const THIS_CLASS_NAME As String = "ABAtenaGetBClass"                ' ƒNƒ‰ƒX–¼
        // Private Const THIS_BUSINESSID As String = "AB"                              ' ‹Æ–±ƒR[ƒh

        protected UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        protected UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        protected UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        protected UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        protected UFErrorClass m_cfErrorClass;                  // ƒGƒ‰[ˆ—ƒNƒ‰ƒX

        protected int m_intHyojiketaJuminCD;                // Z–¯ƒR[ƒh•\Ž¦Œ…”
        protected int m_intHyojiketaStaiCD;                 // ¢‘ÑƒR[ƒh•\Ž¦Œ…”
        protected int m_intHyojiketaJushoCD;                // ZŠƒR[ƒh•\Ž¦Œ…”iŠÇ“à‚Ì‚Ýj
        protected int m_intHyojiketaGyoseikuCD;             // s­‹æƒR[ƒh•\Ž¦Œ…”
        protected int m_intHyojiketaChikuCD1;               // ’n‹æƒR[ƒh‚P•\Ž¦Œ…”
        protected int m_intHyojiketaChikuCD2;               // ’n‹æƒR[ƒh‚Q•\Ž¦Œ…”
        protected int m_intHyojiketaChikuCD3;               // ’n‹æƒR[ƒh‚R•\Ž¦Œ…”
        protected string m_strChikuCD1HyojiMeisho;              // ’n‹æƒR[ƒh‚P•\Ž¦–¼Ì
        protected string m_strChikuCD2HyojiMeisho;              // ’n‹æƒR[ƒh‚Q•\Ž¦–¼Ì
        protected string m_strChikuCD3HyojiMeisho;              // ’n‹æƒR[ƒh‚R•\Ž¦–¼Ì
        protected string m_strRenrakusaki1HyojiMeisho;          // ˜A—æ‚P•\Ž¦–¼Ì
        protected string m_strRenrakusaki2HyojiMeisho;          // ˜A—æ‚Q•\Ž¦–¼Ì
        protected bool m_blnKanriJoho;                       // ŠÇ—î•ñŽæ“¾
        protected bool m_blnBatch;                           // ƒoƒbƒ`‹æ•ª(True:ƒoƒbƒ`Œn, False:ƒŠƒAƒ‹Œn)
        protected bool m_blnBatchRdb;
        protected ABAtenaHenshuBClass m_cABAtenaHenshuB;                          // ˆ¶–¼•ÒWƒNƒ‰ƒX
        protected ABBatchAtenaHenshuBClass m_cABBatchAtenaHenshuB;                // ˆ¶–¼•ÒWƒNƒ‰ƒX(ƒoƒbƒ`Œn)
                                                                                  // * —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
        private ABAtenaRirekiBClass m_cABAtenaRirekiB;          // ˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
        private ABAtenaBClass m_cABAtenaB;                      // ˆ¶–¼ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
        private ABSfskBClass m_cABSfskB;                        // ‘—•tæƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
        private ABDainoBClass m_cABDainoB;                      // ‘ã”[ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX

        private USSCityInfoClass m_cUSSCityInfoClass;           // Žs’¬‘ºî•ñŠÇ—ƒNƒ‰ƒX
        private ABRenrakusakiBClass m_cRenrakusakiBClass;       // ˜A—æ‚aƒNƒ‰ƒX
        private UFDateClass m_cfDateClass;                    // “ú•tƒNƒ‰ƒX
        private URAtenaKanriJohoCacheBClass m_cfURAtenaKanriJoho;   // ˆ¶–¼ŠÇ—î•ñƒLƒƒƒbƒVƒ…‚aƒNƒ‰ƒX
                                                                    // * —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁI—¹
                                                                    // *—š—ð”Ô† 000032 2007/09/04 ’Ç‰ÁŠJŽn
        private URKANRIJOHOBClass m_cURKanriJohoB;         // ŠÇ—î•ñŽæ“¾ƒNƒ‰ƒX
                                                           // ƒoƒbƒ`‚©‚çŒÄ‚Î‚ê‚½ê‡ƒGƒ‰[‚ª”­¶‚·‚é‚½‚ßCƒLƒƒƒbƒVƒ…ƒNƒ‰ƒX‚ÍƒRƒƒ“ƒgƒAƒEƒg
                                                           // Private m_cURKanriJohoB As URKANRIJOHOCacheBClass         'ŠÇ—î•ñŽæ“¾ƒNƒ‰ƒX
                                                           // *—š—ð”Ô† 000032 2007/09/04 ’Ç‰ÁI—¹

        // @ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        protected const string THIS_CLASS_NAME = "ABAtenaGetBClass";              // ƒNƒ‰ƒX–¼
        protected const string THIS_BUSINESSID = "AB";                            // ‹Æ–±ƒR[ƒh
                                                                                  // * —š—ð”Ô† 000015 2003/08/21 C³I—¹

        // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
        protected ABEnumDefine.AtenaGetKB m_blnSelectAll = ABEnumDefine.AtenaGetKB.KaniAll;
        protected ABAtenaRirekiBClass m_cABAtenaRirekiBRef;          // ˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
        protected ABAtenaBClass m_cABAtenaBRef;                      // ˆ¶–¼ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
        protected ABSfskBClass m_cABSfskBRef;                        // ‘—•tæƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
        protected ABDainoBClass m_cABDainoBRef;                      // ‘ã”[ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
                                                                     // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹
                                                                     // * —š—ð”Ô† 000026 2005/04/21 ’Ç‰ÁŠJŽn
        private string m_strSystemDateTime;                          // ˆ—“úŽž
                                                                     // * —š—ð”Ô† 000026 2005/04/21 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000022 2007/04/28 ’Ç‰ÁŠJŽn
        private ABEnumDefine.MethodKB m_blnSelectKaigo;  // ƒƒ\ƒbƒh‹æ•ªi’Êí”Å‚©A‰îŒì”ÅAAAj
                                                         // *—š—ð”Ô† 000022 2007/04/28 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000031 2007/07/28 ’Ç‰ÁŠJŽn
        private ABAtenaKanriJohoBClass m_cABAtenaKanriJohoB;              // ŠÇ—î•ñ‚aƒNƒ‰ƒX
        private ABGappeiDoitsuninBClass m_cABGappeiDoitsuninB;            // “¯ˆêl‚aƒNƒ‰ƒX
        private string m_strDoitsu_Param;                    // “¯ˆêl”»’èƒpƒ‰ƒ[ƒ^
        private string m_strHonninJuminCD;                    // –{lZ–¯ƒR[ƒh
                                                              // *—š—ð”Ô† 000031 2007/07/28 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000042 2008/11/18 ’Ç‰ÁŠJŽn
        private ABEnumDefine.MethodKB m_blnMethodKB;
        // *—š—ð”Ô† 000042 2008/11/18 ’Ç‰ÁI—¹

        #endregion

        #region ƒvƒƒpƒeƒB 
        // ************************************************************************************************
        // * Šeƒƒ“ƒo•Ï”‚ÌƒvƒƒpƒeƒB’è‹`
        // ************************************************************************************************
        public int p_intHyojiketaJuminCD
        {
            get
            {
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
                if (!m_blnKanriJoho)
                {
                    KanriJohoGet();
                }
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹
                return m_intHyojiketaJuminCD;
            }
        }
        public int p_intHyojiketaStaiCD
        {
            get
            {
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
                if (!m_blnKanriJoho)
                {
                    KanriJohoGet();
                }
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹
                return m_intHyojiketaStaiCD;
            }
        }
        public int p_intHyojiketaJushoCD
        {
            get
            {
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
                if (!m_blnKanriJoho)
                {
                    KanriJohoGet();
                }
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹
                return m_intHyojiketaJushoCD;
            }
        }
        public int p_intHyojiketaGyoseikuCD
        {
            get
            {
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
                if (!m_blnKanriJoho)
                {
                    KanriJohoGet();
                }
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹
                return m_intHyojiketaGyoseikuCD;
            }
        }
        public int p_intHyojiketaChikuCD1
        {
            get
            {
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
                if (!m_blnKanriJoho)
                {
                    KanriJohoGet();
                }
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹
                return m_intHyojiketaChikuCD1;
            }
        }
        public int p_intHyojiketaChikuCD2
        {
            get
            {
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
                if (!m_blnKanriJoho)
                {
                    KanriJohoGet();
                }
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹
                return m_intHyojiketaChikuCD2;
            }
        }
        public int p_intHyojiketaChikuCD3
        {
            get
            {
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
                if (!m_blnKanriJoho)
                {
                    KanriJohoGet();
                }
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹
                return m_intHyojiketaChikuCD3;
            }
        }
        public string p_strChikuCD1HyojiMeisho
        {
            get
            {
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
                if (!m_blnKanriJoho)
                {
                    KanriJohoGet();
                }
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹
                return m_strChikuCD1HyojiMeisho;
            }
        }
        public string p_strChikuCD2HyojiMeisho
        {
            get
            {
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
                if (!m_blnKanriJoho)
                {
                    KanriJohoGet();
                }
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹
                return m_strChikuCD2HyojiMeisho;
            }
        }
        public string p_strChikuCD3HyojiMeisho
        {
            get
            {
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
                if (!m_blnKanriJoho)
                {
                    KanriJohoGet();
                }
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹
                return m_strChikuCD3HyojiMeisho;
            }
        }
        public string p_strRenrakusaki1HyojiMeisho
        {
            get
            {
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
                if (!m_blnKanriJoho)
                {
                    KanriJohoGet();
                }
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹
                return m_strRenrakusaki1HyojiMeisho;
            }
        }
        public string p_strRenrakusaki2HyojiMeisho
        {
            get
            {
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
                if (!m_blnKanriJoho)
                {
                    KanriJohoGet();
                }
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹
                return m_strRenrakusaki2HyojiMeisho;
            }
        }
        #endregion

        #region  ƒRƒ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // * @@                          ByVal cfConfigDataClass As UFConfigDataClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABAtenaGetBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass)
        {
            // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
            m_blnBatchRdb = false;
            // ‚q‚c‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfRdbClass = new UFRdbClass(THIS_BUSINESSID);
            Initial(cfControlData, cfConfigDataClass, m_cfRdbClass, true);
            // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹

            // * —š—ð”Ô† 000024 2005/01/25 íœŠJŽni‹{‘òj
            // ' ƒƒ“ƒo•Ï”ƒZƒbƒg
            // m_cfControlData = cfControlData
            // m_cfConfigDataClass = cfConfigDataClass

            // ' ‚q‚c‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            // m_cfRdbClass = New UFRdbClass(THIS_BUSINESSID)

            // ' ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            // m_cfLogClass = New UFLogClass(cfConfigDataClass, cfControlData.m_strBusinessId)

            // ' ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”‰Šú‰»
            // m_intHyojiketaJuminCD = 0                           'Z–¯ƒR[ƒh•\Ž¦Œ…”
            // m_intHyojiketaStaiCD = 0                            '¢‘ÑƒR[ƒh•\Ž¦Œ…”
            // m_intHyojiketaJushoCD = 0                           'ZŠƒR[ƒh•\Ž¦Œ…”iŠÇ“à‚Ì‚Ýj
            // m_intHyojiketaGyoseikuCD = 0                        's­‹æƒR[ƒh•\Ž¦Œ…”
            // m_intHyojiketaChikuCD1 = 0                          '’n‹æƒR[ƒh‚P•\Ž¦Œ…”
            // m_intHyojiketaChikuCD2 = 0                          '’n‹æƒR[ƒh‚Q•\Ž¦Œ…”
            // m_intHyojiketaChikuCD3 = 0                          '’n‹æƒR[ƒh‚R•\Ž¦Œ…”
            // m_strChikuCD1HyojiMeisho = String.Empty             '’n‹æƒR[ƒh‚P•\Ž¦–¼Ì
            // m_strChikuCD2HyojiMeisho = String.Empty             '’n‹æƒR[ƒh‚Q•\Ž¦–¼Ì
            // m_strChikuCD3HyojiMeisho = String.Empty             '’n‹æƒR[ƒh‚R•\Ž¦–¼Ì
            // m_strRenrakusaki1HyojiMeisho = String.Empty         '˜A—æ‚P•\Ž¦–¼Ì
            // m_strRenrakusaki2HyojiMeisho = String.Empty         '˜A—æ‚Q•\Ž¦–¼Ì
            // '* —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
            // ' ŠÇ—î•ñŽæ“¾Ï‚Ýƒtƒ‰ƒO‚Ì‰Šú‰»
            // m_blnKanriJoho = False
            // '* —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹
            // '* —š—ð”Ô† 000015 2003/08/21 ’Ç‰ÁŠJŽn
            // m_blnBatch = False                                  ' ƒoƒbƒ`‹æ•ª
            // '* —š—ð”Ô† 000015 2003/08/21 ’Ç‰ÁI—¹
            // m_blnBatchRdb = False

            // '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
            // 'ˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // m_cABAtenaRirekiB = New ABAtenaRirekiBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
            // 'ˆ¶–¼ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // m_cABAtenaB = New ABAtenaBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
            /// —•tæƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // m_cABSfskB = New ABSfskBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
            /// ã”[ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // m_cABDainoB = New ABDainoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
            // m_cUSSCityInfoClass = New USSCityInfoClass()
            // m_cUSSCityInfoClass.GetCityInfo(m_cfControlData)
            // m_cfDateClass = New UFDateClass(m_cfConfigDataClass)
            // '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁI—¹
            // * —š—ð”Ô† 000024 2005/01/25 íœI—¹
        }

        // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // * @@                          ByVal cfConfigDataClass As UFConfigDataClass)
        // * @@                          ByVal blnSelectAll As Boolean)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           ByVal blnSelectAll As Boolean           : True‚Ìê‡‘S€–ÚAFalse‚Ìê‡ŠÈˆÕ€–Ú‚Ì‚ÝŽæ“¾
        // *
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABAtenaGetBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, bool blnSelectAll)
        {
            m_blnBatchRdb = false;
            // ‚q‚c‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfRdbClass = new UFRdbClass(THIS_BUSINESSID);
            Initial(cfControlData, cfConfigDataClass, m_cfRdbClass, blnSelectAll);
        }
        // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // * @@                          ByVal cfConfigDataClass As UFConfigDataClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABAtenaGetBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)
        {
            // * —š—ð”Ô† 000015 2003/08/21 ’Ç‰ÁŠJŽn
            m_blnBatchRdb = true;                                  // ƒoƒbƒ`‹æ•ª
                                                                   // * —š—ð”Ô† 000015 2003/08/21 ’Ç‰ÁI—¹
            Initial(cfControlData, cfConfigDataClass, cfRdbClass, true);
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // * @@                          ByVal cfConfigDataClass As UFConfigDataClass)
        // * @@                          ByVal cfRdbClass As UFRdbClass, _
        // * @@                          ByVal blnSelectAll As Boolean)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * @@           ByVal blnSelectAll As Boolean           : True‚Ìê‡‘S€–ÚAFalse‚Ìê‡ŠÈˆÕ€–Ú‚Ì‚ÝŽæ“¾
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABAtenaGetBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass, bool blnSelectAll)
        {
            // * —š—ð”Ô† 000015 2003/08/21 ’Ç‰ÁŠJŽn
            m_blnBatchRdb = true;                                  // ƒoƒbƒ`‹æ•ª
                                                                   // * —š—ð”Ô† 000015 2003/08/21 ’Ç‰ÁI—¹
            Initial(cfControlData, cfConfigDataClass, cfRdbClass, blnSelectAll);
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           'Public Sub New(ByVal cfControlData As UFControlData, 
        // * @@           '               ByVal cfConfigDataClass As UFConfigDataClass)
        // * \•¶           Public Sub Initial(ByVal cfControlData As UFControlData, 
        // * @@                          ByVal cfConfigDataClass As UFConfigDataClass,
        // * @@                          ByVal blnSelectAll as boolean)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * @@           ByVal blnSelectAll As Boolean           : True‚Ìê‡‘S€–ÚAFalse‚Ìê‡ŠÈˆÕ€–Ú‚Ì‚ÝŽæ“¾
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
        // Public Sub New(ByVal cfControlData As UFControlData, _
        // ByVal cfConfigDataClass As UFConfigDataClass, _
        // ByVal cfRdbClass As UFRdbClass)
        [SecuritySafeCritical]
        private void Initial(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass, bool blnSelectAll)
        {
            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹
            m_cfRdbClass = cfRdbClass;

            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigDataClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(cfConfigDataClass, cfControlData.m_strBusinessId);

            // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”‰Šú‰»
            m_intHyojiketaJuminCD = 0;                           // Z–¯ƒR[ƒh•\Ž¦Œ…”
            m_intHyojiketaStaiCD = 0;                            // ¢‘ÑƒR[ƒh•\Ž¦Œ…”
            m_intHyojiketaJushoCD = 0;                           // ZŠƒR[ƒh•\Ž¦Œ…”iŠÇ“à‚Ì‚Ýj
            m_intHyojiketaGyoseikuCD = 0;                        // s­‹æƒR[ƒh•\Ž¦Œ…”
            m_intHyojiketaChikuCD1 = 0;                          // ’n‹æƒR[ƒh‚P•\Ž¦Œ…”
            m_intHyojiketaChikuCD2 = 0;                          // ’n‹æƒR[ƒh‚Q•\Ž¦Œ…”
            m_intHyojiketaChikuCD3 = 0;                          // ’n‹æƒR[ƒh‚R•\Ž¦Œ…”
            m_strChikuCD1HyojiMeisho = string.Empty;             // ’n‹æƒR[ƒh‚P•\Ž¦–¼Ì
            m_strChikuCD2HyojiMeisho = string.Empty;             // ’n‹æƒR[ƒh‚Q•\Ž¦–¼Ì
            m_strChikuCD3HyojiMeisho = string.Empty;             // ’n‹æƒR[ƒh‚R•\Ž¦–¼Ì
            m_strRenrakusaki1HyojiMeisho = string.Empty;         // ˜A—æ‚P•\Ž¦–¼Ì
            m_strRenrakusaki2HyojiMeisho = string.Empty;         // ˜A—æ‚Q•\Ž¦–¼Ì
                                                                 // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
                                                                 // ŠÇ—î•ñŽæ“¾Ï‚Ýƒtƒ‰ƒO‚Ì‰Šú‰»
            m_blnKanriJoho = false;
            // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹
            // * —š—ð”Ô† 000015 2003/08/21 ’Ç‰ÁŠJŽn
            m_blnBatch = false;                                  // ƒoƒbƒ`‹æ•ª
                                                                 // * —š—ð”Ô† 000015 2003/08/21 ’Ç‰ÁI—¹

            // * —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
            // ˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬

            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
            // m_cABAtenaRirekiB = New ABAtenaRirekiBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
            if (blnSelectAll == true)
            {
                m_blnSelectAll = ABEnumDefine.AtenaGetKB.KaniAll;
            }
            else
            {
                m_blnSelectAll = ABEnumDefine.AtenaGetKB.KaniOnly;
            }
            m_cABAtenaRirekiB = new ABAtenaRirekiBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass, m_blnSelectAll, true);
            m_cABAtenaRirekiBRef = m_cABAtenaRirekiB;
            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹

            // ˆ¶–¼ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // * —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
            // m_cABAtenaB = New ABAtenaBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
            m_cABAtenaB = new ABAtenaBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass, m_blnSelectAll, true);
            m_cABAtenaBRef = m_cABAtenaB;
            // * —š—ð”Ô† 000024 2005/01/25 XVI—¹

            // ‘—•tæƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            m_cABSfskB = new ABSfskBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
            // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
            m_cABSfskBRef = m_cABSfskB;
            // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹(‹{‘ò)
            // ‘ã”[ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            m_cABDainoB = new ABDainoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
            // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
            m_cABDainoBRef = m_cABDainoB;
            // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹(‹{‘ò)

            m_cUSSCityInfoClass = new USSCityInfoClass();
            m_cUSSCityInfoClass.GetCityInfo(m_cfControlData);
            m_cfDateClass = new UFDateClass(m_cfConfigDataClass);
            // * —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁI—¹

            // * —š—ð”Ô† 000026 2005/04/21 ’Ç‰ÁŠJŽn
            m_strSystemDateTime = m_cfRdbClass.GetSystemDate().ToString("yyyyMMdd");    // ˆ—“úŽž
                                                                                        // * —š—ð”Ô† 000026 2005/04/21 ’Ç‰ÁI—¹

            // *—š—ð”Ô† 000032 2007/09/04 ’Ç‰ÁŠJŽn
            // URŠÇ—î•ñ‚ðŽæ“¾
            if (m_cURKanriJohoB is null)
            {
                m_cURKanriJohoB = new URKANRIJOHOBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
            }
            // ƒoƒbƒ`‚©‚çŒÄ‚Î‚ê‚½ê‡ƒGƒ‰[‚ª”­¶‚·‚é‚½‚ßCƒRƒƒ“ƒgƒAƒEƒg
            // m_cURKanriJohoB = New URKANRIJOHOCacheBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
            // *—š—ð”Ô† 000032 2007/09/04 ’Ç‰ÁI—¹

        }
        #endregion

        #region  ŠÈˆÕˆ¶–¼Žæ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ŠÈˆÕˆ¶–¼Žæ“¾‚P
        // * 
        // * \•¶           Public Function AtenaGet1(ByVal cAtenaGetPara1 As ABAtenaGetPara1) As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           cAtenaGetPara1   : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // * 
        // * –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        // *—š—ð”Ô† 000020 2003/11/19 C³ŠJŽn
        // Public Function AtenaGet1(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet
        public DataSet AtenaGet1(ABAtenaGetPara1XClass cAtenaGetPara1)
        {
            // *—š—ð”Ô† 000020 2003/11/19 C³ŠJŽn

            // '*—š—ð”Ô† 000020 2003/11/19 C³I—¹
            // Const THIS_METHOD_NAME As String = "AtenaGet1"
            // Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì
            // Dim cSearchKey As ABAtenaSearchKey                  'ˆ¶–¼ŒŸõƒL[
            // Dim csDataTable As DataTable
            // Dim csDataSet As DataSet
            // Dim cABAtenaRirekiB As ABAtenaRirekiBClass          'ˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
            // Dim cABAtenaB As ABAtenaBClass                      'ˆ¶–¼ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
            // Dim cABSfskB As ABSfskBClass                        '‘—•tæƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
            // Dim cABDainoB As ABDainoBClass                      '‘ã”[ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
            // '*—š—ð”Ô† 000015 2003/08/21 íœŠJŽn
            // 'Dim cABAtenaHenshuB As ABAtenaHenshuBClass          'ˆ¶–¼•ÒWƒNƒ‰ƒX
            // '*—š—ð”Ô† 000015 2003/08/21 íœI—¹
            // Dim csAtena1 As DataSet                             'ˆ¶–¼î•ñ(ABAtena1)
            // Dim csAtenaH As DataSet                             'ˆ¶–¼î•ñ(ABAtena1)
            // Dim csAtenaHS As DataSet                            'ˆ¶–¼î•ñ(ABAtena1)
            // Dim csAtenaD As DataSet                             'ˆ¶–¼î•ñ(ABAtena1)
            // Dim csAtenaDS As DataSet                            'ˆ¶–¼î•ñ(ABAtena1)
            // Dim strStaiCD As String                             '¢‘ÑƒR[ƒh
            // Dim intHyojiKensu As Integer                        'Å‘åŽæ“¾Œ”
            // Dim intGetCount As Integer                          'Žæ“¾Œ”
            // Dim strKikanYM As String                            'ŠúŠÔ”NŒŽ
            // Dim strDainoKB As String                            '‘ã”[‹æ•ª
            // Dim strGyomuCD As String                            '‹Æ–±ƒR[ƒh
            // Dim strGyomunaiSHU_CD As String                     '‹Æ–±“àŽí•ÊƒR[ƒh
            // Dim cUSSCityInfoClass As New USSCityInfoClass()     'Žs’¬‘ºî•ñŠÇ—ƒNƒ‰ƒX
            // Dim strShichosonCD As String                        'Žs’¬‘ºƒR[ƒh

            // Try
            // ' ƒfƒoƒbƒOŠJŽnƒƒOo—Í
            // m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

            // ' RDBƒAƒNƒZƒXƒƒOo—Í
            // m_cfLogClass.RdbWrite(m_cfControlData, _
            // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
            // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
            // "yŽÀsƒƒ\ƒbƒh–¼:Connectz")
            // '‚q‚c‚aÚ‘±
            // m_cfRdbClass.Connect()

            // Try
            // '* —š—ð”Ô† 000014 2003/06/17 íœŠJŽn
            // '' ŠÇ—î•ñŽæ“¾(“à•”ˆ—)ƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
            // 'Me.GetKanriJoho()
            // '* —š—ð”Ô† 000014 2003/06/17 íœI—¹

            // 'ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
            // Me.CheckColumnValue(cAtenaGetPara1)

            // 'ˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // cABAtenaRirekiB = New ABAtenaRirekiBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)

            // 'ˆ¶–¼ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // cABAtenaB = New ABAtenaBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)

            // '‘—•tæƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // cABSfskB = New ABSfskBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)

            // '‘ã”[ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // cABDainoB = New ABDainoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)

            // '*—š—ð”Ô† 000015 2003/08/21 C³ŠJŽn
            // ''ˆ¶–¼•ÒWƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // 'cABAtenaHenshuB = New ABAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)

            // If (m_blnBatch) Then
            // 'ˆ¶–¼•ÒWƒoƒbƒ`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // m_cABBatchAtenaHenshuB = New ABBatchAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
            // Else
            // 'ˆ¶–¼•ÒWƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // m_cABAtenaHenshuB = New ABAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
            // End If
            // '*—š—ð”Ô† 000015 2003/08/21 C³I—¹

            // '*—š—ð’Ç‰Á 000003 2003/02/26 ’Ç‰ÁŠJŽn
            // 'USSCityInfoClass.GetCityInfo()‚ðŽg—p‚µ‚ÄA’¼‹ßŽs’¬‘ºî•ñŽæ“¾‚ðŽæ“¾‚·‚éB
            // cUSSCityInfoClass.GetCityInfo(m_cfControlData)

            // 'Žs’¬‘ºƒR[ƒh‚Ì“à—e‚ðÝ’è‚·‚éB
            // If (cAtenaGetPara1.p_strShichosonCD = String.Empty) Then
            // strShichosonCD = cUSSCityInfoClass.p_strShichosonCD(0)
            // Else
            // strShichosonCD = cAtenaGetPara1.p_strShichosonCD
            // End If
            // '*—š—ð’Ç‰Á 000003 2003/02/26 ’Ç‰ÁI—¹

            // '¢‘ÑƒR[ƒh‚ÌŽw’è‚ª‚È‚­A¢‘Ñˆõ•ÒW‚ÌŽwŽ¦‚ª‚ ‚éê‡
            // If cAtenaGetPara1.p_strStaiCD = "" And cAtenaGetPara1.p_strStaiinHenshu = "1" Then

            // 'ˆ¶–¼ŒŸõƒL[‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            // cSearchKey = New ABAtenaSearchKey()

            // 'Z–¯ƒR[ƒh‚ÌÝ’è
            // cSearchKey.p_strJuminCD = cAtenaGetPara1.p_strJuminCD

            // 'ZŠîEZ“oŠO‹æ•ª‚ª<>"1"‚Ìê‡
            // If cAtenaGetPara1.p_strJukiJutogaiKB <> "1" Then
            // cSearchKey.p_strJutogaiYusenKB = "1"
            // End If

            // 'ZŠîEZ“oŠO‹æ•ª‚ª="1"‚Ìê‡
            // If cAtenaGetPara1.p_strJukiJutogaiKB = "1" Then
            // cSearchKey.p_strJuminYuseniKB = "1"
            // End If

            // 'Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡
            // If Not (cAtenaGetPara1.p_strShiteiYMD = String.Empty) Then

            // 'uˆ¶–¼—š—ðƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
            // csDataSet = cABAtenaRirekiB.GetAtenaRBHoshu(cAtenaGetPara1.p_intHyojiKensu, _
            // cSearchKey, _
            // cAtenaGetPara1.p_strShiteiYMD, _
            // cAtenaGetPara1.p_blnSakujoFG)

            // 'Žæ“¾Œ”‚ª‚PŒ‚Å‚È‚¢ê‡AƒGƒ‰[
            // If (csDataSet.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Count <> 1) Then
            // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
            // m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
            // objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
            // Throw New UFAppException(objErrorStruct.m_strErrorMessage + "Z–¯ƒR[ƒh", objErrorStruct.m_strErrorCode)
            // End If

            // strStaiCD = CType(csDataSet.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows(0).Item(ABAtenaRirekiEntity.STAICD), String)
            // End If

            // 'Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢ê‡
            // If (cAtenaGetPara1.p_strShiteiYMD = String.Empty) Then

            // 'uˆ¶–¼ƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
            // csDataSet = cABAtenaB.GetAtenaBHoshu(cAtenaGetPara1.p_intHyojiKensu, _
            // cSearchKey, cAtenaGetPara1.p_blnSakujoFG)

            // 'Žæ“¾Œ”‚ª‚PŒ‚Å‚È‚¢ê‡AƒGƒ‰[
            // If (csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count <> 1) Then
            // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
            // m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
            // objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
            // Throw New UFAppException(objErrorStruct.m_strErrorMessage + "Z–¯ƒR[ƒh", objErrorStruct.m_strErrorCode)
            // End If

            // '¢‘ÑƒR[ƒh‚ªNULL‚Ìê‡AƒGƒ‰[
            // If CType(csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows(0).Item(ABAtenaEntity.STAICD), String).Trim = String.Empty Then
            // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
            // m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
            // objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
            // Throw New UFAppException(objErrorStruct.m_strErrorMessage + "Z–¯ƒR[ƒh", objErrorStruct.m_strErrorCode)
            // End If

            // strStaiCD = CType(csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows(0).Item(ABAtenaEntity.STAICD), String)
            // End If
            // cAtenaGetPara1.p_strStaiCD = strStaiCD
            // cAtenaGetPara1.p_strJuminCD = String.Empty
            // End If

            // cSearchKey = Nothing
            // cSearchKey = New ABAtenaSearchKey()

            // '¢‘Ñˆõ•ÒW‚ª"1"‚Ìê‡
            // If cAtenaGetPara1.p_strStaiinHenshu = "1" Then
            // cSearchKey.p_strStaiCD = cAtenaGetPara1.p_strStaiCD
            // Else
            // 'ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^‚©‚çˆ¶–¼ŒŸõƒL[‚ÉƒZƒbƒg‚·‚é
            // cSearchKey.p_strJuminCD = cAtenaGetPara1.p_strJuminCD
            // cSearchKey.p_strStaiCD = cAtenaGetPara1.p_strStaiCD
            // cSearchKey.p_strSearchKanaSeiMei = cAtenaGetPara1.p_strKanaSeiMei
            // cSearchKey.p_strSearchKanaSei = cAtenaGetPara1.p_strKanaSei
            // cSearchKey.p_strSearchKanaMei = cAtenaGetPara1.p_strKanaMei
            // cSearchKey.p_strSearchKanjiMeisho = cAtenaGetPara1.p_strKanjiShimei
            // cSearchKey.p_strUmareYMD = cAtenaGetPara1.p_strUmareYMD
            // cSearchKey.p_strSeibetsuCD = cAtenaGetPara1.p_strSeibetsu
            // cSearchKey.p_strDataKB = cAtenaGetPara1.p_strDataKB
            // cSearchKey.p_strJuminShubetu1 = cAtenaGetPara1.p_strJuminSHU1
            // cSearchKey.p_strJuminShubetu2 = cAtenaGetPara1.p_strJuminSHU2
            // cSearchKey.p_strShichosonCD = strShichosonCD
            // End If

            // 'ZŠîEZ“oŠO‹æ•ª‚ª<>"1"‚Ìê‡
            // If cAtenaGetPara1.p_strJukiJutogaiKB <> "1" Then
            // cSearchKey.p_strJutogaiYusenKB = "1"
            // End If

            // 'ZŠîEZ“oŠO‹æ•ª‚ª="1"‚Ìê‡
            // If cAtenaGetPara1.p_strJukiJutogaiKB = "1" Then
            // cSearchKey.p_strJuminYuseniKB = "1"
            // End If

            // 'ZŠ`”Ô’nƒR[ƒh3‚ÌƒZƒbƒg
            // 'Z“oŠO—Dæ‚Ìê‡
            // If cAtenaGetPara1.p_strJukiJutogaiKB <> "1" Then
            // cSearchKey.p_strJushoCD = cAtenaGetPara1.p_strJushoCD.PadLeft(11)
            // cSearchKey.p_strGyoseikuCD = cAtenaGetPara1.p_strGyoseikuCD.PadLeft(9)
            // cSearchKey.p_strChikuCD1 = cAtenaGetPara1.p_strChikuCD1.PadLeft(8)
            // cSearchKey.p_strChikuCD2 = cAtenaGetPara1.p_strChikuCD2.PadLeft(8)
            // cSearchKey.p_strChikuCD3 = cAtenaGetPara1.p_strChikuCD3.PadLeft(8)
            // cSearchKey.p_strBanchiCD1 = cAtenaGetPara1.p_strBanchiCD1.PadLeft(5)
            // cSearchKey.p_strBanchiCD2 = cAtenaGetPara1.p_strBanchiCD2.PadLeft(5)
            // cSearchKey.p_strBanchiCD3 = cAtenaGetPara1.p_strBanchiCD3.PadLeft(5)
            // End If

            // 'ZŠî—Dæ‚Ìê‡
            // If cAtenaGetPara1.p_strJukiJutogaiKB = "1" Then
            // '*—š—ð”Ô† 000018 2003/10/30 C³ŠJŽn
            // 'cSearchKey.p_strJukiJushoCD = cAtenaGetPara1.p_strJushoCD.PadLeft(11)
            // cSearchKey.p_strJukiJushoCD = cAtenaGetPara1.p_strJushoCD.PadLeft(8)
            // '*—š—ð”Ô† 000018 2003/10/30 C³I—¹
            // cSearchKey.p_strJukiGyoseikuCD = cAtenaGetPara1.p_strGyoseikuCD.PadLeft(9)
            // cSearchKey.p_strJukiChikuCD1 = cAtenaGetPara1.p_strChikuCD1.PadLeft(8)
            // cSearchKey.p_strJukiChikuCD2 = cAtenaGetPara1.p_strChikuCD2.PadLeft(8)
            // cSearchKey.p_strJukiChikuCD3 = cAtenaGetPara1.p_strChikuCD3.PadLeft(8)
            // cSearchKey.p_strJukiBanchiCD1 = cAtenaGetPara1.p_strBanchiCD1.PadLeft(5)
            // cSearchKey.p_strJukiBanchiCD2 = cAtenaGetPara1.p_strBanchiCD2.PadLeft(5)
            // cSearchKey.p_strJukiBanchiCD3 = cAtenaGetPara1.p_strBanchiCD3.PadLeft(5)
            // End If

            // 'Å‘åŽæ“¾Œ”‚ðƒZƒbƒg‚·‚é
            // If cAtenaGetPara1.p_intHyojiKensu = 0 Then
            // intHyojiKensu = 100
            // Else
            // intHyojiKensu = cAtenaGetPara1.p_intHyojiKensu
            // End If

            // 'Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡
            // If Not (cAtenaGetPara1.p_strShiteiYMD = String.Empty) Then

            // 'uˆ¶–¼—š—ðƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
            // csDataSet = cABAtenaRirekiB.GetAtenaRBHoshu(intHyojiKensu, _
            // cSearchKey, _
            // cAtenaGetPara1.p_strShiteiYMD, _
            // cAtenaGetPara1.p_blnSakujoFG)

            // intGetCount = csDataSet.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Count

            // '*—š—ð”Ô† 000015 2003/08/21 C³ŠJŽn
            // ''uˆ¶–¼•ÒWv‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // 'csAtenaH = cABAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet)

            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaH = m_cABBatchAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaH = m_cABAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet)
            // End If
            // '*—š—ð”Ô† 000015 2003/08/21 C³I—¹
            // End If

            // 'Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢ê‡
            // If (cAtenaGetPara1.p_strShiteiYMD = String.Empty) Then

            // 'uˆ¶–¼ƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
            // csDataSet = cABAtenaB.GetAtenaBHoshu(intHyojiKensu, cSearchKey, cAtenaGetPara1.p_blnSakujoFG)

            // intGetCount = csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count

            // '*—š—ð”Ô† 000015 2003/08/21 C³ŠJŽn
            // ''uˆ¶–¼•ÒWv‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // 'csAtenaH = cABAtenaHenshuB.AtenaHenshu(cAtenaGetPara1, csDataSet)

            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaH = m_cABBatchAtenaHenshuB.AtenaHenshu(cAtenaGetPara1, csDataSet)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaH = m_cABAtenaHenshuB.AtenaHenshu(cAtenaGetPara1, csDataSet)
            // End If
            // '*—š—ð”Ô† 000015 2003/08/21 C³I—¹

            // End If

            // 'Žæ“¾ƒpƒ‰ƒ[ƒ^‚Ì‹Æ–±ƒR[ƒh‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢‚©AŽæ“¾Œ”‚ª1Œ‚Å‚È‚¢ê‡‚ÍA’l‚ð•Ô‚·
            // If cAtenaGetPara1.p_strGyomuCD = "" Or intGetCount <> 1 Then

            // csAtena1 = csAtenaH

            // Exit Try
            // End If

            // 'Žw’è”NŒŽ“ú‚ªŽw’è‚µ‚Ä‚ ‚èŠŽ‚ÂŽæ“¾ƒpƒ‰ƒ[ƒ^‚Ì‘—•tæƒf[ƒ^‹æ•ª‚ª"1"‚Ìê‡
            // If cAtenaGetPara1.p_strShiteiYMD <> "" And cAtenaGetPara1.p_strSfskDataKB = "1" Then
            // strKikanYM = cAtenaGetPara1.p_strShiteiYMD.Substring(0, 6)
            // Else
            // strKikanYM = "999999"
            // End If

            // 'u‘—•tæƒ}ƒXƒ^‚c‚`v‚Ìu‘—•tæƒ}ƒXƒ^’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csDataSet = cABSfskB.GetSfskBHoshu(cAtenaGetPara1.p_strJuminCD, _
            // cAtenaGetPara1.p_strGyomuCD, _
            // cAtenaGetPara1.p_strGyomunaiSHU_CD, _
            // strKikanYM, _
            // cAtenaGetPara1.p_blnSakujoFG)


            // '*—š—ð”Ô† 000015 2003/08/21 C³ŠJŽn
            // ''uˆ¶–¼•ÒWv‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // 'csAtenaHS = cABAtenaHenshuB.SofusakiHenshu(cAtenaGetPara1, csAtenaH, csDataSet)

            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaHS = m_cABBatchAtenaHenshuB.SofusakiHenshu(cAtenaGetPara1, csAtenaH, csDataSet)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaHS = m_cABAtenaHenshuB.SofusakiHenshu(cAtenaGetPara1, csAtenaH, csDataSet)
            // End If
            // '*—š—ð”Ô† 000015 2003/08/21 C³I—¹

            // 'Žw’è”NŒŽ“ú‚ªŽw’è‚µ‚Ä‚ ‚éê‡
            // If (cAtenaGetPara1.p_strShiteiYMD <> "") Then
            // strKikanYM = cAtenaGetPara1.p_strShiteiYMD.Substring(0, 6)
            // Else
            // strKikanYM = "999999"
            // End If

            // 'u‘ã”[ƒ}ƒXƒ^‚c‚`v‚Ìu‘ã”[ƒ}ƒXƒ^’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csDataSet = cABDainoB.GetDainoBHoshu(cAtenaGetPara1.p_strJuminCD, _
            // cAtenaGetPara1.p_strGyomuCD, _
            // cAtenaGetPara1.p_strGyomunaiSHU_CD, _
            // strKikanYM, _
            // cAtenaGetPara1.p_blnSakujoFG)

            // 'Žæ“¾Œ”‚ª1Œ‚Å‚È‚¢ê‡
            // If (csDataSet.Tables(ABDainoEntity.TABLE_NAME).Rows.Count <> 1) Then

            // 'csAtenaH ‚Æ csAtenaHS ‚ðƒ}[ƒW‚µ‚ÄAcaAtena1 ‚ÉƒZƒbƒg‚·‚é
            // csAtena1 = Me.CreateAtenaDataSet(csAtenaH, csAtenaHS, csAtenaD, csAtenaDS)
            // Exit Try
            // End If

            // With csDataSet.Tables(ABDainoEntity.TABLE_NAME).Rows(0)

            // '‘ã”[‹æ•ª‚ð‘Þ”ð‚·‚é
            // strDainoKB = CType(.Item(ABDainoEntity.DAINOKB), String)

            // '‹Æ–±ƒR[ƒh‚ð‘Þ”ð‚·‚é
            // strGyomuCD = CType(.Item(ABDainoEntity.GYOMUCD), String)

            // '‹Æ–±“àŽí•ÊƒR[ƒh‚ð‘Þ”ð‚·‚é
            // strGyomunaiSHU_CD = CType(.Item(ABDainoEntity.GYOMUNAISHU_CD), String)

            // 'ˆ¶–¼ŒŸõƒL[‚ÉƒZƒbƒg‚·‚é
            // cSearchKey = Nothing
            // cSearchKey = New ABAtenaSearchKey()

            // cSearchKey.p_strJuminCD = CType(.Item(ABDainoEntity.DAINOJUMINCD), String)

            // End With

            // 'ZŠîEZ“oŠO‹æ•ª‚ª<>"1"‚Ìê‡
            // If cAtenaGetPara1.p_strJukiJutogaiKB <> "1" Then
            // cSearchKey.p_strJutogaiYusenKB = "1"
            // End If

            // 'ZŠîEZ“oŠO‹æ•ª‚ª="1"‚Ìê‡
            // If cAtenaGetPara1.p_strJukiJutogaiKB = "1" Then
            // cSearchKey.p_strJuminYuseniKB = "1"
            // End If

            // '‡OŽw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡
            // If Not (cAtenaGetPara1.p_strShiteiYMD = "") Then
            // 'uˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`v‚Ìuˆ¶–¼—š—ðƒ}ƒXƒ^’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csDataSet = cABAtenaRirekiB.GetAtenaRBHoshu(cAtenaGetPara1.p_intHyojiKensu, _
            // cSearchKey, _
            // cAtenaGetPara1.p_strShiteiYMD, _
            // cAtenaGetPara1.p_blnSakujoFG)

            // 'Žæ“¾Œ”
            // intGetCount = csDataSet.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Count
            // 'Žæ“¾Œ”‚ª‚OŒ‚Ìê‡A
            // If (intGetCount = 0) Then

            // 'csAtenaH ‚Æ csAtenaHS ‚ðƒ}[ƒW‚µ‚ÄAcaAtena1 ‚ÉƒZƒbƒg‚·‚é
            // csAtena1 = Me.CreateAtenaDataSet(csAtenaH, csAtenaHS, csAtenaD, csAtenaDS)
            // Exit Try
            // End If

            // '*—š—ð”Ô† 000015 2003/08/21 C³ŠJŽn
            // ''uˆ¶–¼•ÒWv‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // 'csAtenaD = cABAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet, strDainoKB, _
            // '                                        strGyomuCD, strGyomunaiSHU_CD)

            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaD = m_cABBatchAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet, strDainoKB, _
            // strGyomuCD, strGyomunaiSHU_CD)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaD = m_cABAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet, strDainoKB, _
            // strGyomuCD, strGyomunaiSHU_CD)
            // End If
            // '*—š—ð”Ô† 000015 2003/08/21 C³I—¹

            // Else
            // '‡PŽw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢ê‡

            // 'uˆ¶–¼ƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
            // csDataSet = cABAtenaB.GetAtenaBHoshu(cAtenaGetPara1.p_intHyojiKensu, _
            // cSearchKey, cAtenaGetPara1.p_blnSakujoFG)

            // 'Žæ“¾Œ”
            // intGetCount = csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count
            // 'Žæ“¾Œ”‚ª‚OŒ‚Ìê‡A
            // If (intGetCount = 0) Then

            // 'csAtenaH ‚Æ csAtenaHS ‚ðƒ}[ƒW‚µ‚ÄAcaAtena1 ‚ÉƒZƒbƒg‚·‚é
            // csAtena1 = Me.CreateAtenaDataSet(csAtenaH, csAtenaHS, csAtenaD, csAtenaDS)
            // Exit Try
            // End If

            // '*—š—ð”Ô† 000015 2003/08/21 C³ŠJŽn
            // ''uˆ¶–¼•ÒWv‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // 'csAtenaD = cABAtenaHenshuB.AtenaHenshu(cAtenaGetPara1, csDataSet, strDainoKB, _
            // '                                       strGyomuCD, strGyomunaiSHU_CD)

            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaD = m_cABBatchAtenaHenshuB.AtenaHenshu(cAtenaGetPara1, csDataSet, strDainoKB, _
            // strGyomuCD, strGyomunaiSHU_CD)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaD = m_cABAtenaHenshuB.AtenaHenshu(cAtenaGetPara1, csDataSet, strDainoKB, _
            // strGyomuCD, strGyomunaiSHU_CD)
            // End If
            // '*—š—ð”Ô† 000015 2003/08/21 C³I—¹

            // End If

            // 'Žw’è”NŒŽ“ú‚ªŽw’è‚µ‚Ä‚ ‚èŠŽ‚ÂŽæ“¾ƒpƒ‰ƒ[ƒ^‚Ì‘—•tæƒf[ƒ^‹æ•ª‚ª"1"‚Ìê‡
            // If cAtenaGetPara1.p_strShiteiYMD <> "" And cAtenaGetPara1.p_strSfskDataKB = "1" Then
            // strKikanYM = cAtenaGetPara1.p_strShiteiYMD.Substring(0, 6)
            // Else
            // strKikanYM = "999999"
            // End If

            // 'u‘—•tæƒ}ƒXƒ^‚c‚`v‚Ìu‘—•tæƒ}ƒXƒ^’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csDataSet = cABSfskB.GetSfskBHoshu(cSearchKey.p_strJuminCD, _
            // cAtenaGetPara1.p_strGyomuCD, _
            // cAtenaGetPara1.p_strGyomunaiSHU_CD, _
            // strKikanYM, _
            // cAtenaGetPara1.p_blnSakujoFG)

            // '*—š—ð”Ô† 000015 2003/08/21 C³ŠJŽn
            // ''uˆ¶–¼•ÒWv‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // 'csAtenaDS = cABAtenaHenshuB.SofusakiHenshu(cAtenaGetPara1, csAtenaD, csDataSet)

            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaDS = m_cABBatchAtenaHenshuB.SofusakiHenshu(cAtenaGetPara1, csAtenaD, csDataSet)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaDS = m_cABAtenaHenshuB.SofusakiHenshu(cAtenaGetPara1, csAtenaD, csDataSet)
            // End If
            // '*—š—ð”Ô† 000015 2003/08/21 C³I—¹

            // 'csAtenaH ‚Æ csAtenaHS ‚ðƒ}[ƒW‚µ‚ÄAcaAtena1 ‚ÉƒZƒbƒg‚·‚é
            // csAtena1 = Me.CreateAtenaDataSet(csAtenaH, csAtenaHS, csAtenaD, csAtenaDS)

            // Catch objRdbTimeOutExp As UFRdbTimeOutException    ' UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
            // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
            // m_cfLogClass.WarningWrite(m_cfControlData, _
            // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
            // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
            // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objRdbTimeOutExp.p_strErrorCode + "z" + _
            // "yƒ[ƒjƒ“ƒO“à—e:" + objRdbTimeOutExp.Message + "z")
            // ' UFAppException‚ðƒXƒ[‚·‚é
            // Throw New UFAppException(objRdbTimeOutExp.Message, objRdbTimeOutExp.p_intErrorCode, objRdbTimeOutExp)

            // Catch
            // ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[
            // Throw

            // Finally
            // ' RDBƒAƒNƒZƒXƒƒOo—Í
            // m_cfLogClass.RdbWrite(m_cfControlData, _
            // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
            // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
            // "yŽÀsƒƒ\ƒbƒh–¼:Disconnectz")
            // ' RDBØ’f
            // m_cfRdbClass.Disconnect()
            // End Try

            // ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
            // m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

            // Catch objAppExp As UFAppException
            // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
            // m_cfLogClass.WarningWrite(m_cfControlData, _
            // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
            // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
            // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
            // "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
            // ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
            // Throw objAppExp

            // Catch objExp As Exception
            // ' ƒGƒ‰[ƒƒOo—Í
            // m_cfLogClass.ErrorWrite(m_cfControlData, _
            // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
            // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
            // "yƒGƒ‰[“à—e:" + objExp.Message + "z")
            // Throw objExp
            // End Try

            // Return csAtena1

            return AtenaGet1(cAtenaGetPara1, false);
            // *—š—ð”Ô† 000020 2003/11/19 C³I—¹

        }
        #endregion

        #region  ŠÈˆÕˆ¶–¼Žæ“
        // *—š—ð”Ô† 000020 2003/11/19 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ŠÈˆÕˆ¶–¼Žæ“¾‚P
        // * 
        // * \•¶           Public Function AtenaGet1(ByVal cAtenaGetPara1 As ABAtenaGetPara1) As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           cAtenaGetPara1   : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // * @@           blnKobetsu       : ŒÂ•ÊŽæ“¾(True:ŠeŒÂ•Êƒ}ƒXƒ^‚æ‚èƒf[ƒ^‚ðŽæ“¾‚·‚é)
        // * 
        // * –ß‚è’l         DataSet(ABAtena1Kobetsu) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        public DataSet AtenaGet1(ABAtenaGetPara1XClass cAtenaGetPara1, bool blnKobetsu)
        {
            // *—š—ð”Ô† 000030 2007/04/21 C³ŠJŽn
            // Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì
            // Dim cSearchKey As ABAtenaSearchKey                  'ˆ¶–¼ŒŸõƒL[
            // Dim csDataTable As DataTable
            // Dim csDataSet As DataSet
            // '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
            // 'Dim cABAtenaRirekiB As ABAtenaRirekiBClass          'ˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
            // 'Dim cABAtenaB As ABAtenaBClass                      'ˆ¶–¼ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
            // 'Dim cABSfskB As ABSfskBClass                        '‘—•tæƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
            // 'Dim cABDainoB As ABDainoBClass                      '‘ã”[ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
            // '* —š—ð”Ô† 000023 2004/08/27 íœI—¹
            // Dim csAtena1 As DataSet                             'ˆ¶–¼î•ñ(ABAtena1)
            // Dim csAtenaH As DataSet                             'ˆ¶–¼î•ñ(ABAtena1)
            // Dim csAtenaHS As DataSet                            'ˆ¶–¼î•ñ(ABAtena1)
            // Dim csAtenaD As DataSet                             'ˆ¶–¼î•ñ(ABAtena1)
            // Dim csAtenaDS As DataSet                            'ˆ¶–¼î•ñ(ABAtena1)
            // Dim strStaiCD As String                             '¢‘ÑƒR[ƒh
            // Dim intHyojiKensu As Integer                        'Å‘åŽæ“¾Œ”
            // Dim intGetCount As Integer                          'Žæ“¾Œ”
            // Dim strKikanYM As String                            'ŠúŠÔ”NŒŽ
            // Dim strDainoKB As String                            '‘ã”[‹æ•ª
            // Dim strGyomuCD As String                            '‹Æ–±ƒR[ƒh
            // Dim strGyomunaiSHU_CD As String                     '‹Æ–±“àŽí•ÊƒR[ƒh
            // '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
            // 'Dim cUSSCityInfoClass As New USSCityInfoClass()     'Žs’¬‘ºî•ñŠÇ—ƒNƒ‰ƒX
            // '* —š—ð”Ô† 000023 2004/08/27 íœI—¹
            // Dim strShichosonCD As String                        'Žs’¬‘ºƒR[ƒh

            // '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
            // Dim csWkAtena As DataSet                             'ˆ¶–¼î•ñ(ABAtena1)
            // '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹

            // Try
            // ' ƒfƒoƒbƒOŠJŽnƒƒOo—Í
            // m_cfLogClass.DebugStartWrite(m_cfControlData, Me.GetType.Name, System.Reflection.MethodBase.GetCurrentMethod.Name)

            // '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
            // ' RDBƒAƒNƒZƒXƒƒOo—Í
            // 'm_cfLogClass.RdbWrite(m_cfControlData, _
            // '                                "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
            // '                                "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
            // '                                "yŽÀsƒƒ\ƒbƒh–¼:Connectz")
            // '* —š—ð”Ô† 000023 2004/08/27 íœI—¹
            // '‚q‚c‚aÚ‘±
            // If m_blnBatchRdb = False Then
            // '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
            // ' RDBƒAƒNƒZƒXƒƒOo—Í
            // m_cfLogClass.RdbWrite(m_cfControlData, _
            // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
            // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
            // "yŽÀsƒƒ\ƒbƒh–¼:Connectz")
            // '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁI—¹
            // m_cfRdbClass.Connect()
            // End If
            // Try
            // 'ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
            // Me.CheckColumnValue(cAtenaGetPara1)
            // '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
            // ''ˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // 'cABAtenaRirekiB = New ABAtenaRirekiBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)

            // ''ˆ¶–¼ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // 'cABAtenaB = New ABAtenaBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)

            // ''‘—•tæƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // 'cABSfskB = New ABSfskBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)

            // ''‘ã”[ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // 'cABDainoB = New ABDainoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
            // '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽn

            // If (m_blnBatch) Then
            // If (m_cABBatchAtenaHenshuB Is Nothing) Then
            // 'ˆ¶–¼•ÒWƒoƒbƒ`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // '* —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
            // 'm_cABBatchAtenaHenshuB = New ABBatchAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
            // m_cABBatchAtenaHenshuB = New ABBatchAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass, m_blnSelectAll)
            // '* —š—ð”Ô† 000024 2005/01/25 XVI—¹
            // End If
            // Else
            // If (m_cABAtenaHenshuB Is Nothing) Then
            // 'ˆ¶–¼•ÒWƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // '* —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
            // 'm_cABAtenaHenshuB = New ABAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
            // m_cABAtenaHenshuB = New ABAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass, m_blnSelectAll)
            // '* —š—ð”Ô† 000024 2005/01/25 XVI—¹
            // End If
            // End If

            // 'USSCityInfoClass.GetCityInfo()‚ðŽg—p‚µ‚ÄA’¼‹ßŽs’¬‘ºî•ñŽæ“¾‚ðŽæ“¾‚·‚éB
            // '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
            // 'cUSSCityInfoClass.GetCityInfo(m_cfControlData)
            // '* —š—ð”Ô† 000023 2004/08/27 íœI—¹

            // 'Žs’¬‘ºƒR[ƒh‚Ì“à—e‚ðÝ’è‚·‚éB
            // If (cAtenaGetPara1.p_strShichosonCD = String.Empty) Then
            // strShichosonCD = m_cUSSCityInfoClass.p_strShichosonCD(0)
            // Else
            // strShichosonCD = cAtenaGetPara1.p_strShichosonCD
            // End If

            // '¢‘ÑƒR[ƒh‚ÌŽw’è‚ª‚È‚­A¢‘Ñˆõ•ÒW‚ÌŽwŽ¦‚ª‚ ‚éê‡
            // If cAtenaGetPara1.p_strStaiCD = "" And cAtenaGetPara1.p_strStaiinHenshu = "1" Then

            // 'ˆ¶–¼ŒŸõƒL[‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            // cSearchKey = New ABAtenaSearchKey

            // 'Z–¯ƒR[ƒh‚ÌÝ’è
            // cSearchKey.p_strJuminCD = cAtenaGetPara1.p_strJuminCD

            // 'ZŠîEZ“oŠO‹æ•ª‚ª<>"1"‚Ìê‡
            // If cAtenaGetPara1.p_strJukiJutogaiKB <> "1" Then
            // cSearchKey.p_strJutogaiYusenKB = "1"
            // End If

            // 'ZŠîEZ“oŠO‹æ•ª‚ª="1"‚Ìê‡
            // If cAtenaGetPara1.p_strJukiJutogaiKB = "1" Then
            // cSearchKey.p_strJuminYuseniKB = "1"
            // End If

            // 'Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡
            // If Not (cAtenaGetPara1.p_strShiteiYMD = String.Empty) Then

            // 'uˆ¶–¼—š—ðƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
            // csDataSet = m_cABAtenaRirekiB.GetAtenaRBHoshu(cAtenaGetPara1.p_intHyojiKensu, _
            // cSearchKey, _
            // cAtenaGetPara1.p_strShiteiYMD, _
            // cAtenaGetPara1.p_blnSakujoFG)

            // 'Žæ“¾Œ”‚ª‚PŒ‚Å‚È‚¢ê‡AƒGƒ‰[
            // If (csDataSet.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Count <> 1) Then
            // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
            // m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
            // objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
            // Throw New UFAppException(objErrorStruct.m_strErrorMessage + "Z–¯ƒR[ƒh", objErrorStruct.m_strErrorCode)
            // End If

            // strStaiCD = CType(csDataSet.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows(0).Item(ABAtenaRirekiEntity.STAICD), String)
            // End If

            // 'Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢ê‡
            // If (cAtenaGetPara1.p_strShiteiYMD = String.Empty) Then

            // 'uˆ¶–¼ƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
            // csDataSet = m_cABAtenaB.GetAtenaBHoshu(cAtenaGetPara1.p_intHyojiKensu, _
            // cSearchKey, cAtenaGetPara1.p_blnSakujoFG)

            // 'Žæ“¾Œ”‚ª‚PŒ‚Å‚È‚¢ê‡AƒGƒ‰[
            // If (csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count <> 1) Then
            // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
            // m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
            // objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
            // Throw New UFAppException(objErrorStruct.m_strErrorMessage + "Z–¯ƒR[ƒh", objErrorStruct.m_strErrorCode)
            // End If

            // '¢‘ÑƒR[ƒh‚ªNULL‚Ìê‡AƒGƒ‰[
            // If CType(csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows(0).Item(ABAtenaEntity.STAICD), String).Trim = String.Empty Then
            // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
            // m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
            // objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
            // Throw New UFAppException(objErrorStruct.m_strErrorMessage + "Z–¯ƒR[ƒh", objErrorStruct.m_strErrorCode)
            // End If

            // strStaiCD = CType(csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows(0).Item(ABAtenaEntity.STAICD), String)
            // End If
            // cAtenaGetPara1.p_strStaiCD = strStaiCD
            // cAtenaGetPara1.p_strJuminCD = String.Empty
            // End If

            // cSearchKey = Nothing
            // cSearchKey = New ABAtenaSearchKey

            // '¢‘Ñˆõ•ÒW‚ª"1"‚Ìê‡
            // If cAtenaGetPara1.p_strStaiinHenshu = "1" Then
            // cSearchKey.p_strStaiCD = cAtenaGetPara1.p_strStaiCD
            // Else
            // 'ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^‚©‚çˆ¶–¼ŒŸõƒL[‚ÉƒZƒbƒg‚·‚é
            // cSearchKey.p_strJuminCD = cAtenaGetPara1.p_strJuminCD
            // cSearchKey.p_strStaiCD = cAtenaGetPara1.p_strStaiCD
            // cSearchKey.p_strSearchKanaSeiMei = cAtenaGetPara1.p_strKanaSeiMei
            // cSearchKey.p_strSearchKanaSei = cAtenaGetPara1.p_strKanaSei
            // cSearchKey.p_strSearchKanaMei = cAtenaGetPara1.p_strKanaMei
            // cSearchKey.p_strSearchKanjiMeisho = cAtenaGetPara1.p_strKanjiShimei
            // cSearchKey.p_strUmareYMD = cAtenaGetPara1.p_strUmareYMD
            // cSearchKey.p_strSeibetsuCD = cAtenaGetPara1.p_strSeibetsu
            // cSearchKey.p_strDataKB = cAtenaGetPara1.p_strDataKB
            // cSearchKey.p_strJuminShubetu1 = cAtenaGetPara1.p_strJuminSHU1
            // cSearchKey.p_strJuminShubetu2 = cAtenaGetPara1.p_strJuminSHU2
            // cSearchKey.p_strShichosonCD = strShichosonCD
            // End If

            // 'ZŠîEZ“oŠO‹æ•ª‚ª<>"1"‚Ìê‡
            // If cAtenaGetPara1.p_strJukiJutogaiKB <> "1" Then
            // cSearchKey.p_strJutogaiYusenKB = "1"
            // End If

            // 'ZŠîEZ“oŠO‹æ•ª‚ª="1"‚Ìê‡
            // If cAtenaGetPara1.p_strJukiJutogaiKB = "1" Then
            // cSearchKey.p_strJuminYuseniKB = "1"
            // End If

            // 'ZŠ`”Ô’nƒR[ƒh3‚ÌƒZƒbƒg
            // 'Z“oŠO—Dæ‚Ìê‡
            // If cAtenaGetPara1.p_strJukiJutogaiKB <> "1" Then
            // cSearchKey.p_strJushoCD = cAtenaGetPara1.p_strJushoCD.PadLeft(11)
            // cSearchKey.p_strGyoseikuCD = cAtenaGetPara1.p_strGyoseikuCD.PadLeft(9)
            // cSearchKey.p_strChikuCD1 = cAtenaGetPara1.p_strChikuCD1.PadLeft(8)
            // cSearchKey.p_strChikuCD2 = cAtenaGetPara1.p_strChikuCD2.PadLeft(8)
            // cSearchKey.p_strChikuCD3 = cAtenaGetPara1.p_strChikuCD3.PadLeft(8)
            // cSearchKey.p_strBanchiCD1 = cAtenaGetPara1.p_strBanchiCD1.PadLeft(5)
            // cSearchKey.p_strBanchiCD2 = cAtenaGetPara1.p_strBanchiCD2.PadLeft(5)
            // cSearchKey.p_strBanchiCD3 = cAtenaGetPara1.p_strBanchiCD3.PadLeft(5)
            // End If

            // 'ZŠî—Dæ‚Ìê‡
            // If cAtenaGetPara1.p_strJukiJutogaiKB = "1" Then
            // cSearchKey.p_strJukiJushoCD = cAtenaGetPara1.p_strJushoCD.PadLeft(8)
            // cSearchKey.p_strJukiGyoseikuCD = cAtenaGetPara1.p_strGyoseikuCD.PadLeft(9)
            // cSearchKey.p_strJukiChikuCD1 = cAtenaGetPara1.p_strChikuCD1.PadLeft(8)
            // cSearchKey.p_strJukiChikuCD2 = cAtenaGetPara1.p_strChikuCD2.PadLeft(8)
            // cSearchKey.p_strJukiChikuCD3 = cAtenaGetPara1.p_strChikuCD3.PadLeft(8)
            // cSearchKey.p_strJukiBanchiCD1 = cAtenaGetPara1.p_strBanchiCD1.PadLeft(5)
            // cSearchKey.p_strJukiBanchiCD2 = cAtenaGetPara1.p_strBanchiCD2.PadLeft(5)
            // cSearchKey.p_strJukiBanchiCD3 = cAtenaGetPara1.p_strBanchiCD3.PadLeft(5)
            // End If

            // 'Å‘åŽæ“¾Œ”‚ðƒZƒbƒg‚·‚é
            // If cAtenaGetPara1.p_intHyojiKensu = 0 Then
            // intHyojiKensu = 100
            // Else
            // intHyojiKensu = cAtenaGetPara1.p_intHyojiKensu
            // End If

            // 'Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡
            // If Not (cAtenaGetPara1.p_strShiteiYMD = String.Empty) Then

            // ' ˆ¶–¼ŒÂ•Êî•ñ‚Ìê‡
            // If (blnKobetsu) Then
            // 'uˆ¶–¼ŒÂ•Ê—š—ðƒf[ƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
            // csDataSet = m_cABAtenaRirekiB.GetAtenaRBKobetsu(intHyojiKensu, _
            // cSearchKey, _
            // cAtenaGetPara1.p_strShiteiYMD, _
            // cAtenaGetPara1.p_blnSakujoFG)

            // intGetCount = csDataSet.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Count

            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaH = m_cABBatchAtenaHenshuB.RirekiKobetsuHenshu(cAtenaGetPara1, csDataSet)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaH = m_cABAtenaHenshuB.RirekiKobetsuHenshu(cAtenaGetPara1, csDataSet)
            // End If
            // Else
            // 'uˆ¶–¼—š—ðƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
            // csDataSet = m_cABAtenaRirekiB.GetAtenaRBHoshu(intHyojiKensu, _
            // cSearchKey, _
            // cAtenaGetPara1.p_strShiteiYMD, _
            // cAtenaGetPara1.p_blnSakujoFG)

            // intGetCount = csDataSet.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Count

            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaH = m_cABBatchAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaH = m_cABAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet)
            // End If
            // End If
            // Else
            // 'Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢ê‡

            // ' ˆ¶–¼ŒÂ•Êî•ñ‚Ìê‡
            // If (blnKobetsu) Then
            // 'uˆ¶–¼ŒÂ•Êî•ñ’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
            // csDataSet = m_cABAtenaB.GetAtenaBKobetsu(intHyojiKensu, cSearchKey, cAtenaGetPara1.p_blnSakujoFG)

            // intGetCount = csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count

            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìuˆ¶–¼ŒÂ•Ê•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaH = m_cABBatchAtenaHenshuB.AtenaKobetsuHenshu(cAtenaGetPara1, csDataSet)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìuˆ¶–¼ŒÂ•Ê•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaH = m_cABAtenaHenshuB.AtenaKobetsuHenshu(cAtenaGetPara1, csDataSet)
            // End If
            // Else
            // 'uˆ¶–¼ƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
            // csDataSet = m_cABAtenaB.GetAtenaBHoshu(intHyojiKensu, cSearchKey, cAtenaGetPara1.p_blnSakujoFG)

            // intGetCount = csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count

            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaH = m_cABBatchAtenaHenshuB.AtenaHenshu(cAtenaGetPara1, csDataSet)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaH = m_cABAtenaHenshuB.AtenaHenshu(cAtenaGetPara1, csDataSet)
            // End If

            // End If

            // End If

            // '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
            // csWkAtena = csDataSet
            // '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹

            // '*—š—ð”Ô† 000022 2003/12/02 ’Ç‰ÁŠJŽn
            // ' ˜A—æ•ÒWˆ—

            // '* —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
            // 'Me.RenrakusakiHenshu(cAtenaGetPara1.p_strGyomuCD, cAtenaGetPara1.p_strGyomunaiSHU_CD, csAtenaH)
            // Me.RenrakusakiHenshu(cAtenaGetPara1.p_strGyomuCD, cAtenaGetPara1.p_strGyomunaiSHU_CD, csAtenaH, csWkAtena)
            // '* —š—ð”Ô† 000024 2005/01/25 XVI—¹
            // '*—š—ð”Ô† 000022 2003/12/02 ’Ç‰ÁI—¹

            // 'Žæ“¾ƒpƒ‰ƒ[ƒ^‚Ì‹Æ–±ƒR[ƒh‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢‚©AŽæ“¾Œ”‚ª1Œ‚Å‚È‚¢ê‡‚ÍA’l‚ð•Ô‚·
            // If cAtenaGetPara1.p_strGyomuCD = "" Or intGetCount <> 1 Then

            // csAtena1 = csAtenaH

            // Exit Try
            // End If

            // 'Žw’è”NŒŽ“ú‚ªŽw’è‚µ‚Ä‚ ‚èŠŽ‚ÂŽæ“¾ƒpƒ‰ƒ[ƒ^‚Ì‘—•tæƒf[ƒ^‹æ•ª‚ª"1"‚Ìê‡
            // If cAtenaGetPara1.p_strShiteiYMD <> "" And cAtenaGetPara1.p_strSfskDataKB = "1" Then
            // strKikanYM = cAtenaGetPara1.p_strShiteiYMD.Substring(0, 6)
            // Else
            // '* —š—ð”Ô† 000026 2005/04/21 C³ŠJŽn
            // strKikanYM = m_strSystemDateTime
            // ''''strKikanYM = "999999"
            // '* —š—ð”Ô† 000026 2005/04/21 C³I—¹
            // End If

            // '* —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
            // ''u‘—•tæƒ}ƒXƒ^‚c‚`v‚Ìu‘—•tæƒ}ƒXƒ^’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // 'csDataSet = m_cABSfskB.GetSfskBHoshu(cAtenaGetPara1.p_strJuminCD, _
            // '                                   cAtenaGetPara1.p_strGyomuCD, _
            // '                                   cAtenaGetPara1.p_strGyomunaiSHU_CD, _
            // '                                   strKikanYM, _
            // '                                   cAtenaGetPara1.p_blnSakujoFG)
            // 'u‘—•tæƒ}ƒXƒ^‚c‚`v‚Ìu‘—•tæƒ}ƒXƒ^’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // If (csWkAtena.Tables(0).Select(ABAtenaCountEntity.SFSKCOUNT + " IS NOT NULL AND " + ABAtenaCountEntity.SFSKCOUNT + " > 0").Length > 0) Then
            // '‘—•tæ‚ª‚ ‚é‚Ì‚Å“Ç‚Ýž‚Þ
            // csDataSet = m_cABSfskB.GetSfskBHoshu(cAtenaGetPara1.p_strJuminCD, _
            // cAtenaGetPara1.p_strGyomuCD, _
            // cAtenaGetPara1.p_strGyomunaiSHU_CD, _
            // strKikanYM, _
            // cAtenaGetPara1.p_blnSakujoFG)
            // Else
            // '‘—•tæ‚ª–³‚¢‚Ì‚ÅA‹ó‚Ìƒe[ƒuƒ‹ì¬
            // csDataSet = m_cABSfskB.GetSfskSchemaBHoshu()
            // End If
            // '* —š—ð”Ô† 000024 2005/01/25 XVI—¹

            // ' ˆ¶–¼ŒÂ•Êî•ñ‚Ìê‡
            // If (blnKobetsu) Then
            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu‘—•tæŒÂ•Ê•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaHS = m_cABBatchAtenaHenshuB.SofusakiKobetsuHenshu(cAtenaGetPara1, csAtenaH, csDataSet)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìu‘—•tæŒÂ•Ê•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaHS = m_cABAtenaHenshuB.SofusakiKobetsuHenshu(cAtenaGetPara1, csAtenaH, csDataSet)
            // End If
            // Else
            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaHS = m_cABBatchAtenaHenshuB.SofusakiHenshu(cAtenaGetPara1, csAtenaH, csDataSet)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaHS = m_cABAtenaHenshuB.SofusakiHenshu(cAtenaGetPara1, csAtenaH, csDataSet)
            // End If
            // End If

            // 'Žw’è”NŒŽ“ú‚ªŽw’è‚µ‚Ä‚ ‚éê‡
            // If (cAtenaGetPara1.p_strShiteiYMD <> "") Then
            // strKikanYM = cAtenaGetPara1.p_strShiteiYMD.Substring(0, 6)
            // Else
            // '* —š—ð”Ô† 000026 2005/04/21 C³ŠJŽn
            // strKikanYM = m_strSystemDateTime
            // ''''strKikanYM = "999999"
            // '* —š—ð”Ô† 000026 2005/04/21 C³I—¹
            // End If

            // '* —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
            // ''u‘ã”[ƒ}ƒXƒ^‚c‚`v‚Ìu‘ã”[ƒ}ƒXƒ^’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // 'csDataSet = m_cABDainoB.GetDainoBHoshu(cAtenaGetPara1.p_strJuminCD, _
            // '                                     cAtenaGetPara1.p_strGyomuCD, _
            // '                                     cAtenaGetPara1.p_strGyomunaiSHU_CD, _
            // '                                     strKikanYM, _
            // '                                     cAtenaGetPara1.p_blnSakujoFG)
            // 'u‘ã”[ƒ}ƒXƒ^‚c‚`v‚Ìu‘ã”[ƒ}ƒXƒ^’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // If (csWkAtena.Tables(0).Select(ABAtenaCountEntity.DAINOCOUNT + " IS NOT NULL AND " + ABAtenaCountEntity.DAINOCOUNT + " > 0").Length > 0) Then
            // '‘ã”[‚ª‚ ‚é‚Ì‚Å“Ç‚Ýž‚Þ
            // csDataSet = m_cABDainoB.GetDainoBHoshu(cAtenaGetPara1.p_strJuminCD, _
            // cAtenaGetPara1.p_strGyomuCD, _
            // cAtenaGetPara1.p_strGyomunaiSHU_CD, _
            // strKikanYM, _
            // cAtenaGetPara1.p_blnSakujoFG)
            // Else
            // '‘ã”[‚ª–³‚¢‚Ì‚ÅA‹ó‚Ìƒe[ƒuƒ‹ì¬
            // csDataSet = m_cABDainoB.GetDainoSchemaBHoshu()
            // End If
            // '* —š—ð”Ô† 000024 2005/01/25 XVI—¹

            // 'Žæ“¾Œ”‚ª1Œ‚Å‚È‚¢ê‡
            // If (csDataSet.Tables(ABDainoEntity.TABLE_NAME).Rows.Count <> 1) Then

            // 'csAtenaH ‚Æ csAtenaHS ‚ðƒ}[ƒW‚µ‚ÄAcaAtena1 ‚ÉƒZƒbƒg‚·‚é
            // csAtena1 = Me.CreateAtenaDataSet(csAtenaH, csAtenaHS, csAtenaD, csAtenaDS, blnKobetsu)

            // Exit Try
            // End If

            // With csDataSet.Tables(ABDainoEntity.TABLE_NAME).Rows(0)

            // '‘ã”[‹æ•ª‚ð‘Þ”ð‚·‚é
            // strDainoKB = CType(.Item(ABDainoEntity.DAINOKB), String)

            // '‹Æ–±ƒR[ƒh‚ð‘Þ”ð‚·‚é
            // strGyomuCD = CType(.Item(ABDainoEntity.GYOMUCD), String)

            // '‹Æ–±“àŽí•ÊƒR[ƒh‚ð‘Þ”ð‚·‚é
            // strGyomunaiSHU_CD = CType(.Item(ABDainoEntity.GYOMUNAISHU_CD), String)

            // 'ˆ¶–¼ŒŸõƒL[‚ÉƒZƒbƒg‚·‚é
            // cSearchKey = Nothing
            // cSearchKey = New ABAtenaSearchKey

            // cSearchKey.p_strJuminCD = CType(.Item(ABDainoEntity.DAINOJUMINCD), String)

            // End With

            // 'ZŠîEZ“oŠO‹æ•ª‚ª<>"1"‚Ìê‡
            // If cAtenaGetPara1.p_strJukiJutogaiKB <> "1" Then
            // cSearchKey.p_strJutogaiYusenKB = "1"
            // End If

            // 'ZŠîEZ“oŠO‹æ•ª‚ª="1"‚Ìê‡
            // If cAtenaGetPara1.p_strJukiJutogaiKB = "1" Then
            // cSearchKey.p_strJuminYuseniKB = "1"
            // End If

            // '‡OŽw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡
            // If Not (cAtenaGetPara1.p_strShiteiYMD = "") Then

            // ' ˆ¶–¼ŒÂ•Êî•ñ‚Ìê‡
            // If (blnKobetsu) Then

            // 'uˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`v‚Ìuˆ¶–¼—š—ðƒ}ƒXƒ^’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csDataSet = m_cABAtenaRirekiB.GetAtenaRBKobetsu(cAtenaGetPara1.p_intHyojiKensu, _
            // cSearchKey, _
            // cAtenaGetPara1.p_strShiteiYMD, _
            // cAtenaGetPara1.p_blnSakujoFG)

            // 'Žæ“¾Œ”
            // intGetCount = csDataSet.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Count
            // 'Žæ“¾Œ”‚ª‚OŒ‚Ìê‡A
            // If (intGetCount = 0) Then

            // 'csAtenaH ‚Æ csAtenaHS ‚ðƒ}[ƒW‚µ‚ÄAcaAtena1 ‚ÉƒZƒbƒg‚·‚é
            // csAtena1 = Me.CreateAtenaDataSet(csAtenaH, csAtenaHS, csAtenaD, csAtenaDS, blnKobetsu)
            // Exit Try
            // End If

            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu—š—ðŒÂ•Ê•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaD = m_cABBatchAtenaHenshuB.RirekiKobetsuHenshu(cAtenaGetPara1, csDataSet, strDainoKB, _
            // strGyomuCD, strGyomunaiSHU_CD)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìu—š—ðŒÂ•Ê•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaD = m_cABAtenaHenshuB.RirekiKobetsuHenshu(cAtenaGetPara1, csDataSet, strDainoKB, _
            // strGyomuCD, strGyomunaiSHU_CD)
            // End If
            // Else
            // 'uˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`v‚Ìuˆ¶–¼—š—ðƒ}ƒXƒ^’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csDataSet = m_cABAtenaRirekiB.GetAtenaRBHoshu(cAtenaGetPara1.p_intHyojiKensu, _
            // cSearchKey, _
            // cAtenaGetPara1.p_strShiteiYMD, _
            // cAtenaGetPara1.p_blnSakujoFG)

            // 'Žæ“¾Œ”
            // intGetCount = csDataSet.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Count
            // 'Žæ“¾Œ”‚ª‚OŒ‚Ìê‡A
            // If (intGetCount = 0) Then

            // 'csAtenaH ‚Æ csAtenaHS ‚ðƒ}[ƒW‚µ‚ÄAcaAtena1 ‚ÉƒZƒbƒg‚·‚é
            // csAtena1 = Me.CreateAtenaDataSet(csAtenaH, csAtenaHS, csAtenaD, csAtenaDS, blnKobetsu)
            // Exit Try
            // End If

            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaD = m_cABBatchAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet, strDainoKB, _
            // strGyomuCD, strGyomunaiSHU_CD)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaD = m_cABAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet, strDainoKB, _
            // strGyomuCD, strGyomunaiSHU_CD)
            // End If
            // End If
            // Else

            // '‡PŽw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢ê‡
            // ' ˆ¶–¼ŒÂ•Êî•ñ‚Ìê‡
            // If (blnKobetsu) Then

            // 'uˆ¶–¼ŒÂ•Êƒf[ƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
            // csDataSet = m_cABAtenaB.GetAtenaBKobetsu(cAtenaGetPara1.p_intHyojiKensu, _
            // cSearchKey, cAtenaGetPara1.p_blnSakujoFG)

            // 'Žæ“¾Œ”
            // intGetCount = csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count
            // 'Žæ“¾Œ”‚ª‚OŒ‚Ìê‡A
            // If (intGetCount = 0) Then

            // 'csAtenaH ‚Æ csAtenaHS ‚ðƒ}[ƒW‚µ‚ÄAcaAtena1 ‚ÉƒZƒbƒg‚·‚é
            // csAtena1 = Me.CreateAtenaDataSet(csAtenaH, csAtenaHS, csAtenaD, csAtenaDS, blnKobetsu)
            // Exit Try
            // End If

            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaD = m_cABBatchAtenaHenshuB.AtenaKobetsuHenshu(cAtenaGetPara1, csDataSet, strDainoKB, _
            // strGyomuCD, strGyomunaiSHU_CD)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaD = m_cABAtenaHenshuB.AtenaKobetsuHenshu(cAtenaGetPara1, csDataSet, strDainoKB, _
            // strGyomuCD, strGyomunaiSHU_CD)
            // End If

            // Else

            // 'uˆ¶–¼ƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
            // csDataSet = m_cABAtenaB.GetAtenaBHoshu(cAtenaGetPara1.p_intHyojiKensu, _
            // cSearchKey, cAtenaGetPara1.p_blnSakujoFG)

            // 'Žæ“¾Œ”
            // intGetCount = csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count
            // 'Žæ“¾Œ”‚ª‚OŒ‚Ìê‡A
            // If (intGetCount = 0) Then

            // 'csAtenaH ‚Æ csAtenaHS ‚ðƒ}[ƒW‚µ‚ÄAcaAtena1 ‚ÉƒZƒbƒg‚·‚é
            // csAtena1 = Me.CreateAtenaDataSet(csAtenaH, csAtenaHS, csAtenaD, csAtenaDS, blnKobetsu)
            // Exit Try
            // End If

            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaD = m_cABBatchAtenaHenshuB.AtenaHenshu(cAtenaGetPara1, csDataSet, strDainoKB, _
            // strGyomuCD, strGyomunaiSHU_CD)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaD = m_cABAtenaHenshuB.AtenaHenshu(cAtenaGetPara1, csDataSet, strDainoKB, _
            // strGyomuCD, strGyomunaiSHU_CD)
            // End If
            // End If
            // End If

            // 'Žw’è”NŒŽ“ú‚ªŽw’è‚µ‚Ä‚ ‚èŠŽ‚ÂŽæ“¾ƒpƒ‰ƒ[ƒ^‚Ì‘—•tæƒf[ƒ^‹æ•ª‚ª"1"‚Ìê‡
            // If cAtenaGetPara1.p_strShiteiYMD <> "" And cAtenaGetPara1.p_strSfskDataKB = "1" Then
            // strKikanYM = cAtenaGetPara1.p_strShiteiYMD.Substring(0, 6)
            // Else
            // '* —š—ð”Ô† 000026 2005/04/21 C³ŠJŽn
            // strKikanYM = m_strSystemDateTime
            // ''''strKikanYM = "999999"
            // '* —š—ð”Ô† 000026 2005/04/21 C³I—¹
            // End If

            // '* —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
            // 'u‘—•tæƒ}ƒXƒ^‚c‚`v‚Ìu‘—•tæƒ}ƒXƒ^’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // 'csDataSet = m_cABSfskB.GetSfskBHoshu(cSearchKey.p_strJuminCD, _
            // '                                   cAtenaGetPara1.p_strGyomuCD, _
            // '                                   cAtenaGetPara1.p_strGyomunaiSHU_CD, _
            // '                                   strKikanYM, _
            // '                                   cAtenaGetPara1.p_blnSakujoFG)
            // If (csDataSet.Tables(0).Select(ABAtenaCountEntity.SFSKCOUNT + " IS NOT NULL AND " + ABAtenaCountEntity.SFSKCOUNT + " > 0").Length > 0) Then
            // '‘—•tæ‚ª‚ ‚é‚Ì‚Å“Ç‚Ýž‚Þ
            // csDataSet = m_cABSfskB.GetSfskBHoshu(cSearchKey.p_strJuminCD, _
            // cAtenaGetPara1.p_strGyomuCD, _
            // cAtenaGetPara1.p_strGyomunaiSHU_CD, _
            // strKikanYM, _
            // cAtenaGetPara1.p_blnSakujoFG)
            // Else
            // '‘—•tæ‚ª–³‚¢‚Ì‚ÅA‹ó‚Ìƒe[ƒuƒ‹ì¬
            // csDataSet = m_cABSfskB.GetSfskSchemaBHoshu()
            // End If
            // '* —š—ð”Ô† 000024 2005/01/25 XVI—¹

            // ' ˆ¶–¼ŒÂ•Êî•ñ‚Ìê‡
            // If (blnKobetsu) Then
            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaDS = m_cABBatchAtenaHenshuB.SofusakiKobetsuHenshu(cAtenaGetPara1, csAtenaD, csDataSet)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaDS = m_cABAtenaHenshuB.SofusakiKobetsuHenshu(cAtenaGetPara1, csAtenaD, csDataSet)
            // End If
            // Else
            // If (m_blnBatch) Then
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaDS = m_cABBatchAtenaHenshuB.SofusakiHenshu(cAtenaGetPara1, csAtenaD, csDataSet)
            // Else
            // 'uˆ¶–¼•ÒWv‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // csAtenaDS = m_cABAtenaHenshuB.SofusakiHenshu(cAtenaGetPara1, csAtenaD, csDataSet)
            // End If
            // End If

            // 'csAtenaH ‚Æ csAtenaHS ‚ðƒ}[ƒW‚µ‚ÄAcaAtena1 ‚ÉƒZƒbƒg‚·‚é
            // csAtena1 = Me.CreateAtenaDataSet(csAtenaH, csAtenaHS, csAtenaD, csAtenaDS, blnKobetsu)



            // Catch objRdbTimeOutExp As UFRdbTimeOutException    ' UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
            // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
            // m_cfLogClass.WarningWrite(m_cfControlData, _
            // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
            // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
            // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objRdbTimeOutExp.p_strErrorCode + "z" + _
            // "yƒ[ƒjƒ“ƒO“à—e:" + objRdbTimeOutExp.Message + "z")
            // ' UFAppException‚ðƒXƒ[‚·‚é
            // Throw New UFAppException(objRdbTimeOutExp.Message, objRdbTimeOutExp.p_intErrorCode, objRdbTimeOutExp)

            // Catch
            // ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[
            // Throw

            // Finally
            // '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
            // ' RDBƒAƒNƒZƒXƒƒOo—Í
            // 'm_cfLogClass.RdbWrite(m_cfControlData, _
            // '                        "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
            // '                        "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
            // '                        "yŽÀsƒƒ\ƒbƒh–¼:Disconnectz")
            // '* —š—ð”Ô† 000023 2004/08/27 íœI—¹
            // ' RDBØ’f
            // If m_blnBatchRdb = False Then
            // '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
            // ' RDBƒAƒNƒZƒXƒƒOo—Í
            // m_cfLogClass.RdbWrite(m_cfControlData, _
            // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
            // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
            // "yŽÀsƒƒ\ƒbƒh–¼:Disconnectz")
            // '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁI—¹
            // m_cfRdbClass.Disconnect()
            // End If
            // End Try

            // ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
            // m_cfLogClass.DebugEndWrite(m_cfControlData, Me.GetType.Name, System.Reflection.MethodBase.GetCurrentMethod.Name)

            // Catch objAppExp As UFAppException
            // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
            // m_cfLogClass.WarningWrite(m_cfControlData, _
            // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
            // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
            // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
            // "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
            // ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
            // Throw objAppExp

            // Catch objExp As Exception
            // ' ƒGƒ‰[ƒƒOo—Í
            // m_cfLogClass.ErrorWrite(m_cfControlData, _
            // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
            // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
            // "yƒGƒ‰[“à—e:" + objExp.Message + "z")
            // Throw objExp
            // End Try

            // Return csAtena1

            return AtenaGetMain(cAtenaGetPara1, blnKobetsu, ABEnumDefine.MethodKB.KB_AtenaGet1, ABEnumDefine.HyojunKB.KB_Tsujo);
            // *—š—ð”Ô† 000030 2007/04/21 C³I—¹

        }
        // *—š—ð”Ô† 000020 2003/11/19 ’Ç‰ÁI—¹
        #endregion

        // *—š—ð”Ô† 000030 2007/04/21 ’Ç‰ÁŠJŽn
        #region  ˆ¶–¼Žæ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼Žæ“¾ƒƒCƒ“iŠÈˆÕˆ¶–¼Žæ“¾‚PA‰îŒì—pˆ¶–¼Žæ“¾j
        // * 
        // * \•¶           Public Function AtenaGetMain(ByVal cAtenaGetPara1 As ABAtenaGetPara1, _
        // *                    ByVal blnKobetsu As Boolean, ByVal MethodKB As ABEnumDefine.MethodKB) As DataSet
        // *
        // * ‹@”\@@    @@ˆ¶–¼‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           cAtenaGetPara1   : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // * @@           blnKobetsu       : ŒÂ•ÊŽæ“¾(True:ŠeŒÂ•Êƒ}ƒXƒ^‚æ‚èƒf[ƒ^‚ðŽæ“¾‚·‚é)
        // * @@           MethodKB         : call‚³‚ê‚½ƒƒ\ƒbƒh‚ÌŽí—Þ‚ð•\‚·
        // * 
        // * –ß‚è’l         DataSet(ABAtena1Kobetsu) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        private DataSet AtenaGetMain(ABAtenaGetPara1XClass cAtenaGetPara1, bool blnKobetsu, ABEnumDefine.MethodKB blnMethodKB, ABEnumDefine.HyojunKB intHyojunKB)
        {
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            ABAtenaSearchKey cSearchKey;                  // ˆ¶–¼ŒŸõƒL[
                                                          // * corresponds to VS2008 Start 2010/04/16 000044
                                                          // Dim csDataTable As DataTable
                                                          // * corresponds to VS2008 End 2010/04/16 000044
            DataSet csDataSet;
            var csAtena1 = default(DataSet);                             // ˆ¶–¼î•ñ(ABAtena1)
            DataSet csAtenaH;                             // ˆ¶–¼î•ñ(ABAtena1)
            DataSet csAtenaHS;                            // ˆ¶–¼î•ñ(ABAtena1)
            var csAtenaD = default(DataSet);                             // ˆ¶–¼î•ñ(ABAtena1)
            var csAtenaDS = default(DataSet);                            // ˆ¶–¼î•ñ(ABAtena1)
            var strStaiCD = default(string);                             // ¢‘ÑƒR[ƒh
            int intHyojiKensu;                        // Å‘åŽæ“¾Œ”
            int intGetCount;                          // Žæ“¾Œ”
            string strKikanYMD;                           // ŠúŠÔ”NŒŽ“ú
            string strDainoKB;                            // ‘ã”[‹æ•ª
            string strGyomuCD;                            // ‹Æ–±ƒR[ƒh
            string strGyomunaiSHU_CD;                     // ‹Æ–±“àŽí•ÊƒR[ƒh
            string strShichosonCD;                        // Žs’¬‘ºƒR[ƒh
            DataSet csWkAtena;                             // ˆ¶–¼î•ñ(ABAtena1)

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name);

                // =====================================================================================================================
                // == ‚PD‚q‚c‚aÚ‘±
                // ==@@@@
                // ==@@@@<à–¾>@ƒoƒbƒ`ƒvƒƒOƒ‰ƒ€‚©‚çŒÄ‚Ño‚³‚ê‚½ê‡‚È‚ÇA–ˆ‰ñ‚q‚c‚aÚ‘±‚ðs‚í‚È‚¢§Œä‚ðs‚¤B
                // ==@@@@
                // =====================================================================================================================
                if (m_blnBatchRdb == false)
                {
                    // RDBƒAƒNƒZƒXƒƒOo—Í
                    m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:Connectz");
                    m_cfRdbClass.Connect();
                }

                do
                {
                    try
                    {
                        // =====================================================================================================================
                        // == ‚QDˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
                        // ==@@@@
                        // ==@@@@<à–¾>@ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX‚ÉŽw’è‚³‚ê‚½“à—e‚ðƒ`ƒFƒbƒN‚·‚éB
                        // ==@@@@
                        // =====================================================================================================================
                        this.CheckColumnValue(cAtenaGetPara1, intHyojunKB);

                        // =====================================================================================================================
                        // == ‚RDŠeŽíƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                        // ==@@@@
                        // ==@@@@<à–¾>@ƒoƒbƒ`ƒtƒ‰ƒO‚Ìê‡•ª‚¯‚É‚æ‚èAƒŠƒAƒ‹—pEƒoƒbƒ`—pƒNƒ‰ƒX‚ðƒCƒ“ƒXƒ^ƒ“ƒX‰»‚·‚éB
                        // ==@@@@
                        // =====================================================================================================================
                        if (m_blnBatch)
                        {
                            if (m_cABBatchAtenaHenshuB is null)
                            {
                                // ˆ¶–¼•ÒWƒoƒbƒ`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                                m_cABBatchAtenaHenshuB = new ABBatchAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass, m_blnSelectAll);
                                m_cABBatchAtenaHenshuB.m_blnMethodKB = blnMethodKB;               // ˆ¶–¼•ÒW‚aƒNƒ‰ƒX
                            }
                            m_cABBatchAtenaHenshuB.m_intHyojunKB = intHyojunKB;
                        }
                        else
                        {
                            if (m_cABAtenaHenshuB is null)
                            {
                                // ˆ¶–¼•ÒWƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                                m_cABAtenaHenshuB = new ABAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass, m_blnSelectAll);
                                // ŽÀsƒƒ\ƒbƒh‚É‚æ‚èo—ÍƒŒƒCƒAƒEƒg‚ð•ÏX‚·‚é
                                m_cABAtenaHenshuB.m_blnMethodKB = blnMethodKB;               // ˆ¶–¼•ÒW‚aƒNƒ‰ƒX
                            }
                            m_cABAtenaHenshuB.m_intHyojunKB = intHyojunKB;
                        }
                        // ŽÀsƒƒ\ƒbƒh‚É‚æ‚èo—ÍƒŒƒCƒAƒEƒg‚ð•ÏX‚·‚é
                        m_cABAtenaB.m_blnMethodKB = blnMethodKB;                             // ˆ¶–¼‚aƒNƒ‰ƒX
                        m_cABAtenaRirekiB.m_blnMethodKB = blnMethodKB;                      // ˆ¶–¼—š—ð‚aƒNƒ‰ƒX
                        m_cABAtenaB.m_intHyojunKB = intHyojunKB;
                        m_cABAtenaRirekiB.m_intHyojunKB = intHyojunKB;

                        // *—š—ð”Ô† 000042 2008/11/18 ’Ç‰ÁŠJŽn
                        m_blnMethodKB = blnMethodKB;
                        // *—š—ð”Ô† 000042 2008/11/18 ’Ç‰ÁI—¹

                        // *—š—ð”Ô† 000045 2010/05/17 ’Ç‰ÁŠJŽn
                        // ˆ¶–¼‚aƒNƒ‰ƒXŠeŽíƒvƒƒpƒeƒB‚ðƒZƒbƒg
                        m_cABAtenaB.p_strHonsekiHittoshKB = cAtenaGetPara1.p_strHonsekiHittoshKB;
                        m_cABAtenaB.p_strShoriteishiKB = cAtenaGetPara1.p_strShoriTeishiKB;
                        // *—š—ð”Ô† 000046 2011/05/18 ’Ç‰ÁŠJŽn
                        m_cABAtenaB.p_strFrnZairyuJohoKB = cAtenaGetPara1.p_strFrnZairyuJohoKB;
                        // *—š—ð”Ô† 000046 2011/05/18 ’Ç‰ÁI—¹
                        // *—š—ð”Ô† 000047 2011/11/07 ’Ç‰ÁŠJŽn
                        m_cABAtenaB.p_strJukihoKaiseiKB = cAtenaGetPara1.p_strJukiHokaiseiKB;
                        // *—š—ð”Ô† 000047 2011/11/07 ’Ç‰ÁI—¹
                        // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁŠJŽn
                        m_cABAtenaB.p_strMyNumberKB = cAtenaGetPara1.p_strMyNumberKB;
                        // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁI—¹

                        // ˆ¶–¼—š—ð‚aƒNƒ‰ƒXŠeŽíƒvƒƒpƒeƒB‚ðƒZƒbƒg
                        m_cABAtenaRirekiB.p_strHonsekiHittoshKB = cAtenaGetPara1.p_strHonsekiHittoshKB;
                        m_cABAtenaRirekiB.p_strShoriteishiKB = cAtenaGetPara1.p_strShoriTeishiKB;
                        // *—š—ð”Ô† 000046 2011/05/18 ’Ç‰ÁŠJŽn
                        m_cABAtenaRirekiB.p_strFrnZairyuJohoKB = cAtenaGetPara1.p_strFrnZairyuJohoKB;
                        // *—š—ð”Ô† 000046 2011/05/18 ’Ç‰ÁI—¹
                        // *—š—ð”Ô† 000047 2011/11/07 ’Ç‰ÁŠJŽn
                        m_cABAtenaRirekiB.p_strJukihoKaiseiKB = cAtenaGetPara1.p_strJukiHokaiseiKB;
                        // *—š—ð”Ô† 000047 2011/11/07 ’Ç‰ÁI—¹
                        // *—š—ð”Ô† 000045 2010/05/17 ’Ç‰ÁI—¹
                        // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁŠJŽn
                        m_cABAtenaRirekiB.p_strMyNumberKB = cAtenaGetPara1.p_strMyNumberKB;
                        // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁI—¹

                        // =====================================================================================================================
                        // == ‚SDŽs’¬‘ºƒR[ƒhÝ’è
                        // ==@@@@
                        // ==@@@@<à–¾>@—Žs’¬‘ºƒR[ƒh‚ÌŽw’è‚ª‚È‚¢ê‡‚ÍAŒ»Ý(’¼‹ß)‚ÌŽs’¬‘ºƒR[ƒh‚ðÝ’è‚·‚éB
                        // ==@@@@
                        // =====================================================================================================================
                        if (cAtenaGetPara1.p_strShichosonCD == string.Empty)
                        {
                            strShichosonCD = m_cUSSCityInfoClass.p_strShichosonCD(0);
                        }
                        else
                        {
                            strShichosonCD = cAtenaGetPara1.p_strShichosonCD;
                        }


                        // =====================================================================================================================
                        // == ‚TD¢‘Ñˆõ•ÒWŽž‚Ì¢‘ÑƒR[ƒh‚ðŽæ“¾
                        // ==@@@@
                        // ==@@@@<à–¾>@—¢‘Ñˆõ•ÒW‚ÌŽw’è‚ª‚ ‚éê‡‚ÍA—¢‘ÑƒR[ƒh‚ðŽg—p‚µ¢‘Ñˆõ‚ðŽæ“¾‚·‚éB
                        // ==@@@@@@@@—¢‘ÑƒR[ƒh‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚©‚Á‚½ê‡‚Í—Z–¯ƒR[ƒh‚É‚æ‚è¢‘ÑƒR[ƒh‚ÌŽæ“¾‚ðs‚¤B
                        // ==@@@@
                        // =====================================================================================================================
                        // ¢‘ÑƒR[ƒh‚ÌŽw’è‚ª‚È‚­A¢‘Ñˆõ•ÒW‚ÌŽwŽ¦‚ª‚ ‚éê‡
                        if (cAtenaGetPara1.p_strStaiCD == "" & cAtenaGetPara1.p_strStaiinHenshu == "1")
                        {

                            // ˆ¶–¼ŒŸõƒL[‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            cSearchKey = new ABAtenaSearchKey();

                            // Z–¯ƒR[ƒh‚ÌÝ’è
                            cSearchKey.p_strJuminCD = cAtenaGetPara1.p_strJuminCD;

                            // ZŠîEZ“oŠO‹æ•ª‚ª<>"1"‚Ìê‡
                            if (cAtenaGetPara1.p_strJukiJutogaiKB != "1")
                            {
                                cSearchKey.p_strJutogaiYusenKB = "1";
                            }

                            // ZŠîEZ“oŠO‹æ•ª‚ª="1"‚Ìê‡
                            if (cAtenaGetPara1.p_strJukiJutogaiKB == "1")
                            {
                                cSearchKey.p_strJuminYuseniKB = "1";
                            }

                            // Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡
                            if (!(cAtenaGetPara1.p_strShiteiYMD == string.Empty))
                            {

                                // uˆ¶–¼—š—ðƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
                                csDataSet = m_cABAtenaRirekiB.GetAtenaRBHoshu(cAtenaGetPara1.p_intHyojiKensu, cSearchKey, cAtenaGetPara1.p_strShiteiYMD, cAtenaGetPara1.p_blnSakujoFG);

                                // Žæ“¾Œ”‚ª‚PŒ‚Å‚È‚¢ê‡AƒGƒ‰[
                                if (csDataSet.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Count != 1)
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036);
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage + "Z–¯ƒR[ƒh", objErrorStruct.m_strErrorCode);
                                }

                                strStaiCD = (string)csDataSet.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows(0)(ABAtenaRirekiEntity.STAICD);
                            }

                            // Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢ê‡
                            if (cAtenaGetPara1.p_strShiteiYMD == string.Empty)
                            {

                                // uˆ¶–¼ƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
                                csDataSet = m_cABAtenaB.GetAtenaBHoshu(cAtenaGetPara1.p_intHyojiKensu, cSearchKey, cAtenaGetPara1.p_blnSakujoFG);

                                // Žæ“¾Œ”‚ª‚PŒ‚Å‚È‚¢ê‡AƒGƒ‰[
                                if (csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count != 1)
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036);
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage + "Z–¯ƒR[ƒh", objErrorStruct.m_strErrorCode);
                                }

                                // ¢‘ÑƒR[ƒh‚ªNULL‚Ìê‡AƒGƒ‰[
                                if (new string(((string)csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows(0)(ABAtenaEntity.STAICD)).Trim ?? new char[0]) == "")
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036);
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage + "Z–¯ƒR[ƒh", objErrorStruct.m_strErrorCode);
                                }

                                strStaiCD = (string)csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows(0)(ABAtenaEntity.STAICD);
                            }
                            cAtenaGetPara1.p_strStaiCD = strStaiCD;
                            cAtenaGetPara1.p_strJuminCD = string.Empty;
                        }



                        // *—š—ð”Ô† 000031 2007/07/28 ’Ç‰ÁŠJŽn
                        // =====================================================================================================================
                        // == ‚UD“¯ˆêl‘ã•\ŽÒŽæ“¾ˆ—
                        // ==@@@@
                        // ==@@@@<à–¾>@Z–¯ƒR[ƒhEZ“oŠO—DæE“¯ˆêl”»’èFG—LŒø‚ÌŒŸõðŒ‚Ìê‡‚Ì‚ÝA“¯ˆêl‘ã•\ŽÒŽæ“¾‚ðs‚¤B
                        // ==@@@@@@@@ŠÇ—î•ñ‚É‚æ‚èAƒ†[ƒU‚²‚Æ‚ÌŽæ“¾”»’è—L‚èB
                        // ==@@@@
                        // =====================================================================================================================
                        // “¯ˆêl‘ã•\ŽÒZ–¯ƒR[ƒh‚ðŒŸõƒpƒ‰ƒ[ƒ^‚Éã‘‚«‚·‚é
                        GetDaihyoJuminCD(cAtenaGetPara1);
                        // *—š—ð”Ô† 000031 2007/07/28 ’Ç‰ÁI—¹



                        // =====================================================================================================================
                        // == ‚VD–{lˆ¶–¼Žæ“¾ŒŸõƒL[‚ÌÝ’è
                        // ==@@@@
                        // ==@@@@<à–¾>@–{l‚Ìˆ¶–¼î•ñ‚ðŽæ“¾‚·‚é‚½‚ß‚ÌŒŸõƒL[‚ðŽw’è‚³‚ê‚½ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX‚æ‚èÝ’è‚·‚éB
                        // ==@@@@@@@@Å‘åŽæ“¾Œ”‚àŽæ“¾‚·‚éB
                        // ==@@@@
                        // =====================================================================================================================
                        // ŒŸõƒL[ƒNƒ‰ƒX‚Ì‰Šú‰»‚ÆƒCƒ“ƒXƒ^ƒ“ƒX‰»
                        cSearchKey = default;
                        cSearchKey = new ABAtenaSearchKey();

                        // ¢‘Ñˆõ•ÒW‚ª"1"‚Ìê‡
                        if (cAtenaGetPara1.p_strStaiinHenshu == "1")
                        {
                            cSearchKey.p_strStaiCD = cAtenaGetPara1.p_strStaiCD;
                        }
                        else
                        {
                            // ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^‚©‚çˆ¶–¼ŒŸõƒL[‚ÉƒZƒbƒg‚·‚é
                            cSearchKey.p_strJuminCD = cAtenaGetPara1.p_strJuminCD;
                            cSearchKey.p_strStaiCD = cAtenaGetPara1.p_strStaiCD;
                            cSearchKey.p_strSearchKanaSeiMei = cAtenaGetPara1.p_strKanaSeiMei;
                            cSearchKey.p_strSearchKanaSei = cAtenaGetPara1.p_strKanaSei;
                            cSearchKey.p_strSearchKanaMei = cAtenaGetPara1.p_strKanaMei;
                            cSearchKey.p_strSearchKanjiMeisho = cAtenaGetPara1.p_strKanjiShimei;
                            cSearchKey.p_strUmareYMD = cAtenaGetPara1.p_strUmareYMD;
                            cSearchKey.p_strSeibetsuCD = cAtenaGetPara1.p_strSeibetsu;
                            cSearchKey.p_strDataKB = cAtenaGetPara1.p_strDataKB;
                            cSearchKey.p_strJuminShubetu1 = cAtenaGetPara1.p_strJuminSHU1;
                            cSearchKey.p_strJuminShubetu2 = cAtenaGetPara1.p_strJuminSHU2;
                            cSearchKey.p_strShichosonCD = strShichosonCD;

                            // *—š—ð”Ô† 000032 2007/09/04 ’Ç‰ÁŠJŽn
                            // ŒŸõ—pƒJƒi©–¼EŒŸõ—pƒJƒi©EŒŸõ—pƒJƒi–¼‚Ì•ÒW
                            cSearchKey = HenshuSearchKana(cSearchKey, cAtenaGetPara1.p_blnGaikokuHommyoYusen);
                            // *—š—ð”Ô† 000032 2007/09/04 ’Ç‰ÁI—¹

                            // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁŠJŽn
                            cSearchKey.p_strMyNumber = cAtenaGetPara1.p_strMyNumber.RPadRight(13);
                            cSearchKey.p_strMyNumberKojinHojinKB = cAtenaGetPara1.p_strMyNumberKojinHojinKB;
                            cSearchKey.p_strMyNumberChokkinSearchKB = cAtenaGetPara1.p_strMyNumberChokkinSearchKB;
                            // *—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁI—¹
                            cSearchKey.p_strKyuuji = cAtenaGetPara1.p_strKyuuji;
                            cSearchKey.p_strKanaKyuuji = cAtenaGetPara1.p_strKanaKyuuji;
                            cSearchKey.p_strKatakanaHeikimei = cAtenaGetPara1.p_strKatakanaHeikimei;
                            cSearchKey.p_strJusho = cAtenaGetPara1.p_strJusho;
                            cSearchKey.p_strKatagaki = cAtenaGetPara1.p_strKatagaki;
                            cSearchKey.p_strRenrakusaki = cAtenaGetPara1.p_strRenrakusaki;
                        }

                        // ZŠîEZ“oŠO‹æ•ª‚ª<>"1"‚Ìê‡
                        if (cAtenaGetPara1.p_strJukiJutogaiKB != "1")
                        {
                            cSearchKey.p_strJutogaiYusenKB = "1";
                        }

                        // ZŠîEZ“oŠO‹æ•ª‚ª="1"‚Ìê‡
                        if (cAtenaGetPara1.p_strJukiJutogaiKB == "1")
                        {
                            cSearchKey.p_strJuminYuseniKB = "1";
                        }

                        // ZŠ`”Ô’nƒR[ƒh3‚ÌƒZƒbƒg
                        // Z“oŠO—Dæ‚Ìê‡
                        if (cAtenaGetPara1.p_strJukiJutogaiKB != "1")
                        {
                            cSearchKey.p_strJushoCD = cAtenaGetPara1.p_strJushoCD;
                            cSearchKey.p_strGyoseikuCD = cAtenaGetPara1.p_strGyoseikuCD.RPadLeft(9);
                            cSearchKey.p_strChikuCD1 = cAtenaGetPara1.p_strChikuCD1.RPadLeft(8);
                            cSearchKey.p_strChikuCD2 = cAtenaGetPara1.p_strChikuCD2.RPadLeft(8);
                            cSearchKey.p_strChikuCD3 = cAtenaGetPara1.p_strChikuCD3.RPadLeft(8);
                            cSearchKey.p_strBanchiCD1 = cAtenaGetPara1.p_strBanchiCD1.RPadLeft(5);
                            cSearchKey.p_strBanchiCD2 = cAtenaGetPara1.p_strBanchiCD2.RPadLeft(5);
                            cSearchKey.p_strBanchiCD3 = cAtenaGetPara1.p_strBanchiCD3.RPadLeft(5);
                        }

                        // ZŠî—Dæ‚Ìê‡
                        if (cAtenaGetPara1.p_strJukiJutogaiKB == "1")
                        {
                            cSearchKey.p_strJukiJushoCD = cAtenaGetPara1.p_strJushoCD.Trim.RPadLeft(8);
                            cSearchKey.p_strJukiGyoseikuCD = cAtenaGetPara1.p_strGyoseikuCD.RPadLeft(9);
                            cSearchKey.p_strJukiChikuCD1 = cAtenaGetPara1.p_strChikuCD1.RPadLeft(8);
                            cSearchKey.p_strJukiChikuCD2 = cAtenaGetPara1.p_strChikuCD2.RPadLeft(8);
                            cSearchKey.p_strJukiChikuCD3 = cAtenaGetPara1.p_strChikuCD3.RPadLeft(8);
                            cSearchKey.p_strJukiBanchiCD1 = cAtenaGetPara1.p_strBanchiCD1.RPadLeft(5);
                            cSearchKey.p_strJukiBanchiCD2 = cAtenaGetPara1.p_strBanchiCD2.RPadLeft(5);
                            cSearchKey.p_strJukiBanchiCD3 = cAtenaGetPara1.p_strBanchiCD3.RPadLeft(5);
                        }

                        // *—š—ð”Ô† 000049 2018/03/08 ’Ç‰ÁŠJŽn
                        // —š—ðŒŸõƒtƒ‰ƒO
                        cSearchKey.p_blnIsRirekiSearch = cAtenaGetPara1.p_blnIsRirekiSearch;
                        // *—š—ð”Ô† 000049 2018/03/08 ’Ç‰ÁI—¹

                        // Å‘åŽæ“¾Œ”‚ðƒZƒbƒg‚·‚é
                        if (cAtenaGetPara1.p_intHyojiKensu == 0)
                        {
                            intHyojiKensu = 100;
                        }
                        else
                        {
                            intHyojiKensu = cAtenaGetPara1.p_intHyojiKensu;
                        }


                        // =====================================================================================================================
                        // == ‚WD–{lˆ¶–¼ƒf[ƒ^‚ÌŽæ“¾
                        // ==@@@@
                        // ==@@@@<à–¾>@–{l‚Ìˆ¶–¼î•ñ‚ðŽæ“¾‚·‚éB
                        // ==@@@@@@@@ú@. Žw’è”NŒŽ“ú‚ª‚ ‚éê‡‚Íuˆ¶–¼—š—ðƒ}ƒXƒ^FABATENARIREKIv‚É‚æ‚èŽæ“¾‚·‚é
                        // ==@@@@@@@@úA. Žw’è”NŒŽ“ú‚ª‚È‚¢ê‡‚Íuˆ¶–¼ƒ}ƒXƒ^FABATENAv‚É‚æ‚èŽæ“¾‚·‚é
                        // ==@@@@@@@@úB. ŒÂ•ÊŽ–€‚e‚f‚ÌŽw’è‚ª‚ ‚éê‡‚ÍŒÂ•ÊŽ–€ƒf[ƒ^‚àŽæ“¾‚·‚é
                        // ==@@@@@@@@úC. ƒoƒbƒ`”Å‚ÌŽw’è‚ª‚ ‚éê‡‚Íƒoƒbƒ`”Å‚ÌƒNƒ‰ƒX‚É‚æ‚èŽæ“¾‚·‚é
                        // ==@@@@
                        // =====================================================================================================================
                        // Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡
                        if (!(cAtenaGetPara1.p_strShiteiYMD == string.Empty))
                        {

                            // ˆ¶–¼ŒÂ•Êî•ñ‚Ìê‡
                            if (blnKobetsu)
                            {
                                // *—š—ð”Ô† 000038 2008/01/17 C³ŠJŽn
                                // uˆ¶–¼ŒÂ•Ê—š—ðƒf[ƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
                                // csDataSet = m_cABAtenaRirekiB.GetAtenaRBKobetsu(intHyojiKensu, _
                                // cSearchKey, _
                                // cAtenaGetPara1.p_strShiteiYMD, _
                                // cAtenaGetPara1.p_blnSakujoFG)
                                csDataSet = m_cABAtenaRirekiB.GetAtenaRBKobetsu(intHyojiKensu, cSearchKey, cAtenaGetPara1.p_strShiteiYMD, cAtenaGetPara1.p_blnSakujoFG, cAtenaGetPara1.p_strKobetsuShutokuKB);
                                // *—š—ð”Ô† 000038 2008/01/17 C³I—¹

                                intGetCount = csDataSet.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Count;

                                if (m_blnBatch)
                                {
                                    // uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                    csAtenaH = m_cABBatchAtenaHenshuB.RirekiKobetsuHenshu(cAtenaGetPara1, csDataSet);
                                }
                                else
                                {
                                    // uˆ¶–¼•ÒWv‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                    csAtenaH = m_cABAtenaHenshuB.RirekiKobetsuHenshu(cAtenaGetPara1, csDataSet);
                                }
                            }
                            else
                            {
                                // uˆ¶–¼—š—ðƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
                                csDataSet = m_cABAtenaRirekiB.GetAtenaRBHoshu(intHyojiKensu, cSearchKey, cAtenaGetPara1.p_strShiteiYMD, cAtenaGetPara1.p_blnSakujoFG);

                                intGetCount = csDataSet.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Count;

                                if (m_blnBatch)
                                {
                                    // uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                    csAtenaH = m_cABBatchAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet);
                                }
                                else
                                {
                                    // uˆ¶–¼•ÒWv‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                    csAtenaH = m_cABAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet);
                                }
                            }
                        }
                        // Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢ê‡

                        // ˆ¶–¼ŒÂ•Êî•ñ‚Ìê‡
                        else if (blnKobetsu)
                        {
                            // *—š—ð”Ô† 000038 2008/01/17 C³ŠJŽn
                            // uˆ¶–¼ŒÂ•Êî•ñ’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                            // csDataSet = m_cABAtenaB.GetAtenaBKobetsu(intHyojiKensu, cSearchKey, cAtenaGetPara1.p_blnSakujoFG)
                            csDataSet = m_cABAtenaB.GetAtenaBKobetsu(intHyojiKensu, cSearchKey, cAtenaGetPara1.p_blnSakujoFG, cAtenaGetPara1.p_strKobetsuShutokuKB);
                            // *—š—ð”Ô† 000038 2008/01/17 C³I—¹

                            intGetCount = csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count;

                            if (m_blnBatch)
                            {
                                // uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìuˆ¶–¼ŒÂ•Ê•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                csAtenaH = m_cABBatchAtenaHenshuB.AtenaKobetsuHenshu(cAtenaGetPara1, csDataSet);
                            }
                            else
                            {
                                // uˆ¶–¼•ÒWv‚Ìuˆ¶–¼ŒÂ•Ê•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                csAtenaH = m_cABAtenaHenshuB.AtenaKobetsuHenshu(cAtenaGetPara1, csDataSet);
                            }
                        }
                        else
                        {
                            // uˆ¶–¼ƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
                            csDataSet = m_cABAtenaB.GetAtenaBHoshu(intHyojiKensu, cSearchKey, cAtenaGetPara1.p_blnSakujoFG);

                            intGetCount = csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count;

                            if (m_blnBatch)
                            {
                                // uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                csAtenaH = m_cABBatchAtenaHenshuB.AtenaHenshu(cAtenaGetPara1, csDataSet);
                            }
                            else
                            {
                                // uˆ¶–¼•ÒWv‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                csAtenaH = m_cABAtenaHenshuB.AtenaHenshu(cAtenaGetPara1, csDataSet);
                            }


                        }

                        csWkAtena = csDataSet;

                        // *—š—ð”Ô† 000040 2008/11/10 ’Ç‰ÁŠJŽn
                        // =====================================================================================================================
                        // == ‚XD—˜—p“Íƒf[ƒ^‚ÌŽæ“¾
                        // ==@@@@
                        // ==@@@@<à–¾>@—˜—p“Íƒf[ƒ^‚ÌŽæ“¾
                        // ==@@@@@@@@ú@. •W€ƒŒƒCƒAƒEƒg‚Ìê‡‚©‚ÂAˆ¶–¼ŒÂ•Êî•ñˆÈŠO‚Ìê‡‚Éˆ—‚ðs‚¤
                        // ==@@@@@@@@úA. —˜—p“ÍoŽæ“¾‹æ•ª‚ª"1,2"‚Ìê‡‚Éˆ—‚ðs‚¤
                        // ==@@@@@@@@úB. Z–¯ƒR[ƒhAÅ–Ú‹æ•ª‚È‚Ç‚©‚ç—˜—p“Íƒf[ƒ^‚ðŽæ“¾‚µA”[ÅŽÒIDA—˜—pŽÒID‚ÉƒZƒbƒg‚·‚é
                        // ==@@@@
                        // =====================================================================================================================
                        this.RiyoTdkHenshu(cAtenaGetPara1, blnKobetsu, csAtenaH);

                        // *—š—ð”Ô† 000041 2008/11/17 ’Ç‰ÁŠJŽn
                        // —˜—p“Í‹æ•ª‚ª"2"‚Ìê‡AŠY“–ƒf[ƒ^ˆÈŠO‚ªíœ‚³‚ê‚é‚Ì‚ÅV‹KŒ”‚ðƒZƒbƒg‚·‚é
                        if (cAtenaGetPara1.p_strTdkdKB == "2")
                        {
                            intGetCount = csAtenaH.Tables[0].Rows.Count;
                        }
                        else
                        {
                        }
                        // *—š—ð”Ô† 000041 2008/11/17 ’Ç‰ÁI—¹
                        // *—š—ð”Ô† 000040 2008/11/10 ’Ç‰ÁI—¹

                        // =====================================================================================================================
                        // == ‚P‚OD˜A—æƒf[ƒ^‚ÌŽæ“¾
                        // ==@@@@
                        // ==@@@@<à–¾>@˜A—æî•ñ‚ðŽæ“¾‚·‚éB
                        // ==@@@@@@@@ú@. ‹Æ–±ƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢ê‡‚ÍA‰½‚à‚µ‚È‚¢
                        // ==@@@@@@@@úA. Žw’è‚µ‚½‹Æ–±ƒR[ƒhE‹Æ–±“àŽí•ÊƒR[ƒh‚ððŒ‚Éu˜A—æƒ}ƒXƒ^FABRENRAKUSAKIv‚©‚çŽæ“¾‚·‚é
                        // ==@@@@@@@@úB. úA.‚Åƒf[ƒ^‚ªŽæ“¾‚µ‚½ê‡A–³ðŒ‚É˜A—æ‚PA˜A—æ‚Q‚ð•Ô‹p‚·‚é
                        // ==@@@@@@@@úC. ”N‹àˆ¶–¼ƒQƒbƒgEŒÂ•ÊƒQƒbƒg‚ÌƒŒƒCƒAƒEƒg‚Ìê‡‚Ì‚Ýu˜A—æ‹Æ–±ƒR[ƒhv‚É’ŠoðŒ‚Ì‹Æ–±ƒR[ƒh‚ðƒZƒbƒg‚·‚é
                        // ==@@@@
                        // =====================================================================================================================
                        // Žw’è”NŒŽ“ú‚ªŽw’è‚µ‚Ä‚ ‚èŠŽ‚ÂŽæ“¾ƒpƒ‰ƒ[ƒ^‚Ì‘—•tæƒf[ƒ^‹æ•ª‚ª"1"‚Ìê‡
                        if (cAtenaGetPara1.p_strShiteiYMD != "" & cAtenaGetPara1.p_strSfskDataKB == "1")
                        {
                            strKikanYMD = cAtenaGetPara1.p_strShiteiYMD.RSubstring(0, 8);
                        }
                        else
                        {
                            strKikanYMD = m_strSystemDateTime;
                        }
                        this.RenrakusakiHenshu(cAtenaGetPara1.p_strGyomuCD, cAtenaGetPara1.p_strGyomunaiSHU_CD, csAtenaH, csWkAtena, intHyojunKB, strKikanYMD);


                        // =====================================================================================================================
                        // == ‚P‚PD‘ã”[E‘—•tæƒf[ƒ^Žæ“¾‚Ì”»’è
                        // ==@@@@
                        // ==@@@@<à–¾>@—‹Æ–±ƒR[ƒh‚ÌŽw’è‚ª‚È‚¢ê‡‚ÍAˆ—‚ð‹­§“I‚ÉI—¹‚·‚éB
                        // ==@@@@@@@@–{lƒf[ƒ^‚ÌŽæ“¾Œ”‚ª‚PŒ‚Å‚È‚¢ê‡‚àˆ—‚ð‹­§“I‚ÉI—¹‚·‚éB
                        // ==@@@@
                        // =====================================================================================================================
                        // Žæ“¾ƒpƒ‰ƒ[ƒ^‚Ì‹Æ–±ƒR[ƒh‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢‚©AŽæ“¾Œ”‚ª1Œ‚Å‚È‚¢ê‡‚ÍA’l‚ð•Ô‚·
                        if (cAtenaGetPara1.p_strGyomuCD == "" | intGetCount != 1)
                        {

                            csAtena1 = csAtenaH;

                            // ˆ—‚ðI—¹‚·‚é
                            break;
                        }


                        // =====================================================================================================================
                        // == ‚P‚QD‘—•tæƒf[ƒ^‚Ì’Šo“ú‚ðÝ’è
                        // ==@@@@
                        // ==@@@@<à–¾>@‘—•tæƒf[ƒ^‚Ì’Šo‚É‚¨‚¢‚ÄA—Žw’è“ú‚ÌŽw’è‚ª‚ ‚èA‚©‚Â—‘—•tæƒf[ƒ^‹æ•ª‚ª "1" ‚Ìê‡‚Í
                        // ==@@@@@@@@Žw’è‚³‚ê‚½“ú•t‚ª—LŒøŠúŠÔ‚ÉŠÜ‚Ü‚ê‚Ä‚¢‚é‚±‚Æ‚ððŒ‚Æ‚·‚éB
                        // ==@@@@@@@@ã‹LˆÈŠO‚ÍAƒVƒXƒeƒ€“ú•t‚ª—LŒøŠúŠÔ‚ÉŠÜ‚Ü‚ê‚é‚Ä‚¢‚é‚±‚Æ‚ððŒ‚Æ‚·‚éB
                        // ==@@@@
                        // =====================================================================================================================
                        // Žw’è”NŒŽ“ú‚ªŽw’è‚µ‚Ä‚ ‚èŠŽ‚ÂŽæ“¾ƒpƒ‰ƒ[ƒ^‚Ì‘—•tæƒf[ƒ^‹æ•ª‚ª"1"‚Ìê‡
                        if (cAtenaGetPara1.p_strShiteiYMD != "" & cAtenaGetPara1.p_strSfskDataKB == "1")
                        {
                            strKikanYMD = cAtenaGetPara1.p_strShiteiYMD.RSubstring(0, 8);
                        }
                        else
                        {
                            strKikanYMD = m_strSystemDateTime;
                        }


                        // =====================================================================================================================
                        // == ‚P‚RD‘—•tæƒf[ƒ^‚ÌŽæ“¾
                        // ==@@@@
                        // ==@@@@<à–¾>@‘—•tæƒf[ƒ^‚ÌŒ”‚É‚æ‚èA‘¶Ý‚µ‚Ä‚¢‚éê‡‚Ì‚Ý‘—•tæƒf[ƒ^‚ÌŽæ“¾‚ðs‚¤B
                        // ==@@@@@@@@Žæ“¾‚ðs‚í‚È‚©‚Á‚½ê‡‚ÍA‹ó‚Ìƒe[ƒuƒ‹‚ðì¬‚·‚éB
                        // ==@@@@
                        // =====================================================================================================================
                        // u‘—•tæƒ}ƒXƒ^‚c‚`v‚Ìu‘—•tæƒ}ƒXƒ^’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                        if (csWkAtena.Tables[0].Select(ABAtenaCountEntity.SFSKCOUNT + " IS NOT NULL AND " + ABAtenaCountEntity.SFSKCOUNT + " > 0").Length > 0)
                        {
                            // ‘—•tæ‚ª‚ ‚é‚Ì‚Å“Ç‚Ýž‚Þ
                            if (intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                csDataSet = m_cABSfskB.GetSfskBHoshu_Hyojun(cAtenaGetPara1.p_strJuminCD, cAtenaGetPara1.p_strGyomuCD, cAtenaGetPara1.p_strGyomunaiSHU_CD, strKikanYMD, cAtenaGetPara1.p_blnSakujoFG);
                            }
                            else
                            {
                                csDataSet = m_cABSfskB.GetSfskBHoshu(cAtenaGetPara1.p_strJuminCD, cAtenaGetPara1.p_strGyomuCD, cAtenaGetPara1.p_strGyomunaiSHU_CD, strKikanYMD, cAtenaGetPara1.p_blnSakujoFG);
                            }
                        }
                        // ‘—•tæ‚ª–³‚¢‚Ì‚ÅA‹ó‚Ìƒe[ƒuƒ‹ì¬
                        else if (intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                        {
                            csDataSet = m_cABSfskB.GetSfskSchemaBHoshu_Hyojun();
                        }
                        else
                        {
                            csDataSet = m_cABSfskB.GetSfskSchemaBHoshu();
                        }


                        // =====================================================================================================================
                        // == ‚P‚SD‘—•tæƒf[ƒ^‚ÌƒŒƒCƒAƒEƒg•ÒW
                        // ==@@@@
                        // ==@@@@<à–¾>@ŒÂ•ÊŽ–€‚e‚f‚ÌŽw’è‚ª‚ ‚éê‡‚ÍA‘—•tæƒf[ƒ^‚ðŒÂ•ÊŽ–€€–Ú‚ª•t‰Á‚³‚ê‚½ƒŒƒCƒAƒEƒg‚É•ÒW‚·‚éB
                        // ==@@@@@@@@‚Ü‚½Aƒoƒbƒ`”ÅEƒŠƒAƒ‹”Å‚É‚æ‚èŽg—p‚·‚éƒNƒ‰ƒX‚ð•ª‚¯‚éB
                        // ==@@@@
                        // =====================================================================================================================
                        // ˆ¶–¼ŒÂ•Êî•ñ‚Ìê‡
                        if (blnKobetsu)
                        {
                            if (m_blnBatch)
                            {
                                // uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu‘—•tæŒÂ•Ê•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                csAtenaHS = m_cABBatchAtenaHenshuB.SofusakiKobetsuHenshu(cAtenaGetPara1, csAtenaH, csDataSet);
                            }
                            else
                            {
                                // uˆ¶–¼•ÒWv‚Ìu‘—•tæŒÂ•Ê•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                csAtenaHS = m_cABAtenaHenshuB.SofusakiKobetsuHenshu(cAtenaGetPara1, csAtenaH, csDataSet);
                            }
                        }
                        else if (m_blnBatch)
                        {
                            // uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                            csAtenaHS = m_cABBatchAtenaHenshuB.SofusakiHenshu(cAtenaGetPara1, csAtenaH, csDataSet);
                        }
                        else
                        {
                            // uˆ¶–¼•ÒWv‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                            csAtenaHS = m_cABAtenaHenshuB.SofusakiHenshu(cAtenaGetPara1, csAtenaH, csDataSet);
                        }


                        // =====================================================================================================================
                        // == ‚P‚TD‘ã”[ƒf[ƒ^‚Ì’Šo“ú‚ðÝ’è
                        // ==@@@@
                        // ==@@@@<à–¾>@‘ã”[ƒf[ƒ^‚Ì’Šo‚É‚¨‚¢‚ÄA—Žw’è“ú‚ÌŽw’è‚ª‚ ‚éê‡‚ÍAŽw’è‚³‚ê‚½“ú•t‚ª—LŒøŠúŠÔ‚ÉŠÜ‚Ü‚ê‚Ä‚¢‚é
                        // ==@@@@@@@@‚±‚Æ‚ððŒ‚Æ‚·‚éB
                        // ==@@@@@@@@ã‹LˆÈŠO‚ÍAƒVƒXƒeƒ€“ú•t‚ª—LŒøŠúŠÔ‚ÉŠÜ‚Ü‚ê‚é‚Ä‚¢‚é‚±‚Æ‚ððŒ‚Æ‚·‚éB
                        // ==@@@@
                        // =====================================================================================================================
                        // Žw’è”NŒŽ“ú‚ªŽw’è‚µ‚Ä‚ ‚éê‡
                        if (cAtenaGetPara1.p_strShiteiYMD != "")
                        {
                            strKikanYMD = cAtenaGetPara1.p_strShiteiYMD.RSubstring(0, 8);
                        }
                        else
                        {
                            strKikanYMD = m_strSystemDateTime;
                        }


                        // =====================================================================================================================
                        // == ‚P‚UD‘ã”[ƒf[ƒ^‚ÌŽæ“¾
                        // ==@@@@
                        // ==@@@@<à–¾>@‘ã”[ƒf[ƒ^‚ÌŒ”‚É‚æ‚èA‘¶Ý‚µ‚Ä‚¢‚éê‡‚Ì‚Ý‘ã”[ƒf[ƒ^‚ÌŽæ“¾‚ðs‚¤B
                        // ==@@@@@@@@Žæ“¾‚ðs‚í‚È‚©‚Á‚½ê‡‚ÍA‹ó‚Ìƒe[ƒuƒ‹‚ðì¬‚·‚éB
                        // ==@@@@
                        // =====================================================================================================================
                        // u‘ã”[ƒ}ƒXƒ^‚c‚`v‚Ìu‘ã”[ƒ}ƒXƒ^’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                        if (csWkAtena.Tables[0].Select(ABAtenaCountEntity.DAINOCOUNT + " IS NOT NULL AND " + ABAtenaCountEntity.DAINOCOUNT + " > 0").Length > 0)
                        {
                            // ‘ã”[‚ª‚ ‚é‚Ì‚Å“Ç‚Ýž‚Þ
                            csDataSet = m_cABDainoB.GetDainoBHoshu(cAtenaGetPara1.p_strJuminCD, cAtenaGetPara1.p_strGyomuCD, cAtenaGetPara1.p_strGyomunaiSHU_CD, strKikanYMD, cAtenaGetPara1.p_blnSakujoFG);
                        }
                        else
                        {
                            // ‘ã”[‚ª–³‚¢‚Ì‚ÅA‹ó‚Ìƒe[ƒuƒ‹ì¬
                            csDataSet = m_cABDainoB.GetDainoSchemaBHoshu();
                        }


                        // =====================================================================================================================
                        // == ‚P‚VDŽæ“¾ƒf[ƒ^‚Ìƒ}[ƒW
                        // ==@@@@
                        // ==@@@@<à–¾>@‘ã”[ƒf[ƒ^‚ÌŽæ“¾Œ”‚ª‚PŒ‚Å‚È‚¢ê‡‚ÍAu–{lvu‘—•tævu‘ã”[lvu‘ã”[‘—•tævƒf[ƒ^‚ð
                        // ==@@@@@@@@‚P‚Â‚Ìƒf[ƒ^ƒZƒbƒg‚Éƒ}[ƒW‚µAˆ—‚ð‹­§“I‚ÉI—¹‚·‚éB
                        // ==@@@@@@@@‚±‚ÌŽž“_‚Å‚ÍAu‘ã”[lvu‘ã”[‘—•tævƒf[ƒ^‚Í‹ó‚Å‚ ‚éB
                        // ==@@@@
                        // =====================================================================================================================
                        // Žæ“¾Œ”‚ª1Œ‚Å‚È‚¢ê‡
                        if (csDataSet.Tables(ABDainoEntity.TABLE_NAME).Rows.Count != 1)
                        {

                            // csAtenaH ‚Æ csAtenaHS ‚ðƒ}[ƒW‚µ‚ÄAcaAtena1 ‚ÉƒZƒbƒg‚·‚é
                            csAtena1 = this.CreateAtenaDataSet(csAtenaH, csAtenaHS, csAtenaD, csAtenaDS, blnKobetsu, intHyojunKB);

                            // ˆ—‚ðI—¹‚·‚é
                            break;
                        }


                        // =====================================================================================================================
                        // == ‚P‚WD‘ã”[lˆ¶–¼Žæ“¾ŒŸõƒL[‚ÌÝ’è
                        // ==@@@@
                        // ==@@@@<à–¾>@‘ã”[l‚Ìˆ¶–¼î•ñ‚ðŽæ“¾‚·‚é‚½‚ß‚ÌŒŸõƒL[‚ðŽw’è‚³‚ê‚½ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX‚æ‚èÝ’è‚·‚éB
                        // ==@@@@@@@@‚±‚ÌŽžA‘ã”[‹æ•ªE‹Æ–±ƒR[ƒhE‹Æ–±“àŽí•ÊƒR[ƒh‚ð‘Þ”ð‚·‚éB
                        // ==@@@@
                        // =====================================================================================================================
                        {
                            var withBlock = csDataSet.Tables(ABDainoEntity.TABLE_NAME).Rows(0);

                            // ‘ã”[‹æ•ª‚ð‘Þ”ð‚·‚é
                            strDainoKB = (string)withBlock(ABDainoEntity.DAINOKB);

                            // ‹Æ–±ƒR[ƒh‚ð‘Þ”ð‚·‚é
                            strGyomuCD = (string)withBlock(ABDainoEntity.GYOMUCD);

                            // ‹Æ–±“àŽí•ÊƒR[ƒh‚ð‘Þ”ð‚·‚é
                            strGyomunaiSHU_CD = (string)withBlock(ABDainoEntity.GYOMUNAISHU_CD);

                            // ˆ¶–¼ŒŸõƒL[‚ÉƒZƒbƒg‚·‚é
                            cSearchKey = default;
                            cSearchKey = new ABAtenaSearchKey();

                            cSearchKey.p_strJuminCD = (string)withBlock(ABDainoEntity.DAINOJUMINCD);

                        }

                        // ZŠîEZ“oŠO‹æ•ª‚ª<>"1"‚Ìê‡
                        if (cAtenaGetPara1.p_strJukiJutogaiKB != "1")
                        {
                            cSearchKey.p_strJutogaiYusenKB = "1";
                        }

                        // ZŠîEZ“oŠO‹æ•ª‚ª="1"‚Ìê‡
                        if (cAtenaGetPara1.p_strJukiJutogaiKB == "1")
                        {
                            cSearchKey.p_strJuminYuseniKB = "1";
                        }


                        // =====================================================================================================================
                        // == ‚P‚XD‘ã”[lˆ¶–¼ƒf[ƒ^‚ÌŽæ“¾
                        // ==@@@@
                        // ==@@@@<à–¾>@‘ã”[l‚Ìˆ¶–¼î•ñ‚ðŽæ“¾‚·‚éB
                        // ==@@@@@@@@ú@. Žw’è”NŒŽ“ú‚ª‚ ‚éê‡‚Íuˆ¶–¼—š—ðƒ}ƒXƒ^FABATENARIREKIv‚É‚æ‚èŽæ“¾‚·‚é
                        // ==@@@@@@@@úA. Žw’è”NŒŽ“ú‚ª‚È‚¢ê‡‚Íuˆ¶–¼ƒ}ƒXƒ^FABATENAv‚É‚æ‚èŽæ“¾‚·‚é
                        // ==@@@@@@@@úB. ŒÂ•ÊŽ–€‚e‚f‚ÌŽw’è‚ª‚ ‚éê‡‚ÍŒÂ•ÊŽ–€ƒf[ƒ^‚àŽæ“¾‚·‚é
                        // ==@@@@@@@@úC. ƒoƒbƒ`”Å‚ÌŽw’è‚ª‚ ‚éê‡‚Íƒoƒbƒ`”Å‚ÌƒNƒ‰ƒX‚É‚æ‚èŽæ“¾‚·‚é
                        // ==@@@@
                        // =====================================================================================================================
                        // Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡
                        if (!(cAtenaGetPara1.p_strShiteiYMD == ""))
                        {

                            // ˆ¶–¼ŒÂ•Êî•ñ‚Ìê‡
                            if (blnKobetsu)
                            {

                                // *—š—ð”Ô† 000038 2008/01/17 C³ŠJŽn
                                // uˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`v‚Ìuˆ¶–¼—š—ðƒ}ƒXƒ^’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                // csDataSet = m_cABAtenaRirekiB.GetAtenaRBKobetsu(cAtenaGetPara1.p_intHyojiKensu, _
                                // cSearchKey, _
                                // cAtenaGetPara1.p_strShiteiYMD, _
                                // cAtenaGetPara1.p_blnSakujoFG)
                                csDataSet = m_cABAtenaRirekiB.GetAtenaRBKobetsu(cAtenaGetPara1.p_intHyojiKensu, cSearchKey, cAtenaGetPara1.p_strShiteiYMD, cAtenaGetPara1.p_blnSakujoFG, cAtenaGetPara1.p_strKobetsuShutokuKB);
                                // *—š—ð”Ô† 000038 2008/01/17 C³I—¹

                                // Žæ“¾Œ”
                                intGetCount = csDataSet.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Count;
                                // Žæ“¾Œ”‚ª‚OŒ‚Ìê‡A
                                if (intGetCount == 0)
                                {

                                    // csAtenaH ‚Æ csAtenaHS ‚ðƒ}[ƒW‚µ‚ÄAcaAtena1 ‚ÉƒZƒbƒg‚·‚é
                                    csAtena1 = this.CreateAtenaDataSet(csAtenaH, csAtenaHS, csAtenaD, csAtenaDS, blnKobetsu, intHyojunKB);

                                    // ˆ—‚ðI—¹‚·‚é
                                    break;
                                }

                                if (m_blnBatch)
                                {
                                    // uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu—š—ðŒÂ•Ê•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                    csAtenaD = m_cABBatchAtenaHenshuB.RirekiKobetsuHenshu(cAtenaGetPara1, csDataSet, strDainoKB, strGyomuCD, strGyomunaiSHU_CD);
                                }
                                else
                                {
                                    // uˆ¶–¼•ÒWv‚Ìu—š—ðŒÂ•Ê•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                    csAtenaD = m_cABAtenaHenshuB.RirekiKobetsuHenshu(cAtenaGetPara1, csDataSet, strDainoKB, strGyomuCD, strGyomunaiSHU_CD);
                                }
                            }
                            else
                            {
                                // uˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`v‚Ìuˆ¶–¼—š—ðƒ}ƒXƒ^’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                csDataSet = m_cABAtenaRirekiB.GetAtenaRBHoshu(cAtenaGetPara1.p_intHyojiKensu, cSearchKey, cAtenaGetPara1.p_strShiteiYMD, cAtenaGetPara1.p_blnSakujoFG);
                                // Žæ“¾Œ”
                                intGetCount = csDataSet.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Count;
                                // Žæ“¾Œ”‚ª‚OŒ‚Ìê‡A
                                if (intGetCount == 0)
                                {

                                    // csAtenaH ‚Æ csAtenaHS ‚ðƒ}[ƒW‚µ‚ÄAcaAtena1 ‚ÉƒZƒbƒg‚·‚é
                                    csAtena1 = this.CreateAtenaDataSet(csAtenaH, csAtenaHS, csAtenaD, csAtenaDS, blnKobetsu, intHyojunKB);

                                    // ˆ—‚ðI—¹‚·‚é
                                    break;
                                }

                                if (m_blnBatch)
                                {
                                    // uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                    csAtenaD = m_cABBatchAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet, strDainoKB, strGyomuCD, strGyomunaiSHU_CD);
                                }
                                else
                                {
                                    // uˆ¶–¼•ÒWv‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                    csAtenaD = m_cABAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet, strDainoKB, strGyomuCD, strGyomunaiSHU_CD);
                                }
                            }
                        }

                        // ‡PŽw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢ê‡
                        // ˆ¶–¼ŒÂ•Êî•ñ‚Ìê‡
                        else if (blnKobetsu)
                        {

                            // *—š—ð”Ô† 000038 2008/01/17 C³ŠJŽn
                            // uˆ¶–¼ŒÂ•Êƒf[ƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
                            // csDataSet = m_cABAtenaB.GetAtenaBKobetsu(cAtenaGetPara1.p_intHyojiKensu, _
                            // cSearchKey, cAtenaGetPara1.p_blnSakujoFG)
                            csDataSet = m_cABAtenaB.GetAtenaBKobetsu(cAtenaGetPara1.p_intHyojiKensu, cSearchKey, cAtenaGetPara1.p_blnSakujoFG, cAtenaGetPara1.p_strKobetsuShutokuKB);
                            // *—š—ð”Ô† 000038 2008/01/17 C³I—¹

                            // Žæ“¾Œ”
                            intGetCount = csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count;
                            // Žæ“¾Œ”‚ª‚OŒ‚Ìê‡A
                            if (intGetCount == 0)
                            {

                                // csAtenaH ‚Æ csAtenaHS ‚ðƒ}[ƒW‚µ‚ÄAcaAtena1 ‚ÉƒZƒbƒg‚·‚é
                                csAtena1 = this.CreateAtenaDataSet(csAtenaH, csAtenaHS, csAtenaD, csAtenaDS, blnKobetsu, intHyojunKB);

                                // ˆ—‚ðI—¹‚·‚é
                                break;
                            }

                            if (m_blnBatch)
                            {
                                // uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                csAtenaD = m_cABBatchAtenaHenshuB.AtenaKobetsuHenshu(cAtenaGetPara1, csDataSet, strDainoKB, strGyomuCD, strGyomunaiSHU_CD);
                            }
                            else
                            {
                                // uˆ¶–¼•ÒWv‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                csAtenaD = m_cABAtenaHenshuB.AtenaKobetsuHenshu(cAtenaGetPara1, csDataSet, strDainoKB, strGyomuCD, strGyomunaiSHU_CD);
                            }
                        }

                        else
                        {

                            // uˆ¶–¼ƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
                            csDataSet = m_cABAtenaB.GetAtenaBHoshu(cAtenaGetPara1.p_intHyojiKensu, cSearchKey, cAtenaGetPara1.p_blnSakujoFG);

                            // Žæ“¾Œ”
                            intGetCount = csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count;
                            // Žæ“¾Œ”‚ª‚OŒ‚Ìê‡A
                            if (intGetCount == 0)
                            {

                                // csAtenaH ‚Æ csAtenaHS ‚ðƒ}[ƒW‚µ‚ÄAcaAtena1 ‚ÉƒZƒbƒg‚·‚é
                                csAtena1 = this.CreateAtenaDataSet(csAtenaH, csAtenaHS, csAtenaD, csAtenaDS, blnKobetsu, intHyojunKB);

                                // ˆ—‚ðI—¹‚·‚é
                                break;
                            }

                            if (m_blnBatch)
                            {
                                // uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                csAtenaD = m_cABBatchAtenaHenshuB.AtenaHenshu(cAtenaGetPara1, csDataSet, strDainoKB, strGyomuCD, strGyomunaiSHU_CD);
                            }
                            else
                            {
                                // uˆ¶–¼•ÒWv‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                csAtenaD = m_cABAtenaHenshuB.AtenaHenshu(cAtenaGetPara1, csDataSet, strDainoKB, strGyomuCD, strGyomunaiSHU_CD);
                            }
                        }


                        // =====================================================================================================================
                        // == ‚Q‚OD‘ã”[l‘—•tæƒf[ƒ^‚Ì’Šo“ú‚ðÝ’è
                        // ==@@@@
                        // ==@@@@<à–¾>@‘ã”[l‚Ì‘—•tæƒf[ƒ^‚Ì’Šo‚É‚¨‚¢‚ÄA—Žw’è“ú‚ÌŽw’è‚ª‚ ‚èA‚©‚Â—‘—•tæƒf[ƒ^‹æ•ª‚ª "1" ‚Ìê‡‚Í
                        // ==@@@@@@@@Žw’è‚³‚ê‚½“ú•t‚ª—LŒøŠúŠÔ‚ÉŠÜ‚Ü‚ê‚Ä‚¢‚é‚±‚Æ‚ððŒ‚Æ‚·‚éB
                        // ==@@@@@@@@ã‹LˆÈŠO‚ÍAƒVƒXƒeƒ€“ú•t‚ª—LŒøŠúŠÔ‚ÉŠÜ‚Ü‚ê‚é‚Ä‚¢‚é‚±‚Æ‚ððŒ‚Æ‚·‚éB
                        // ==@@@@
                        // =====================================================================================================================
                        // Žw’è”NŒŽ“ú‚ªŽw’è‚µ‚Ä‚ ‚èŠŽ‚ÂŽæ“¾ƒpƒ‰ƒ[ƒ^‚Ì‘—•tæƒf[ƒ^‹æ•ª‚ª"1"‚Ìê‡
                        if (cAtenaGetPara1.p_strShiteiYMD != "" & cAtenaGetPara1.p_strSfskDataKB == "1")
                        {
                            strKikanYMD = cAtenaGetPara1.p_strShiteiYMD.RSubstring(0, 8);
                        }
                        else
                        {
                            strKikanYMD = m_strSystemDateTime;
                        }


                        // =====================================================================================================================
                        // == ‚Q‚PD‘ã”[l‘—•tæƒf[ƒ^‚ÌŽæ“¾
                        // ==@@@@
                        // ==@@@@<à–¾>@‘ã”[l‚Ì‘—•tæƒf[ƒ^‚ÌŒ”‚É‚æ‚èA‘¶Ý‚µ‚Ä‚¢‚éê‡‚Ì‚Ý‘—•tæƒf[ƒ^‚ÌŽæ“¾‚ðs‚¤B
                        // ==@@@@@@@@Žæ“¾‚ðs‚í‚È‚©‚Á‚½ê‡‚ÍA‹ó‚Ìƒe[ƒuƒ‹‚ðì¬‚·‚éB
                        // ==@@@@
                        // =====================================================================================================================
                        if (csDataSet.Tables[0].Select(ABAtenaCountEntity.SFSKCOUNT + " IS NOT NULL AND " + ABAtenaCountEntity.SFSKCOUNT + " > 0").Length > 0)
                        {
                            // ‘—•tæ‚ª‚ ‚é‚Ì‚Å“Ç‚Ýž‚Þ
                            if (intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                            {
                                csDataSet = m_cABSfskB.GetSfskBHoshu_Hyojun(cSearchKey.p_strJuminCD, cAtenaGetPara1.p_strGyomuCD, cAtenaGetPara1.p_strGyomunaiSHU_CD, strKikanYMD, cAtenaGetPara1.p_blnSakujoFG);
                            }
                            else
                            {
                                csDataSet = m_cABSfskB.GetSfskBHoshu(cSearchKey.p_strJuminCD, cAtenaGetPara1.p_strGyomuCD, cAtenaGetPara1.p_strGyomunaiSHU_CD, strKikanYMD, cAtenaGetPara1.p_blnSakujoFG);
                            }
                        }
                        // ‘—•tæ‚ª–³‚¢‚Ì‚ÅA‹ó‚Ìƒe[ƒuƒ‹ì¬
                        else if (intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                        {
                            csDataSet = m_cABSfskB.GetSfskSchemaBHoshu_Hyojun();
                        }
                        else
                        {
                            csDataSet = m_cABSfskB.GetSfskSchemaBHoshu();
                        }


                        // =====================================================================================================================
                        // == ‚Q‚QD‘ã”[‘—•tæƒf[ƒ^‚ÌƒŒƒCƒAƒEƒg•ÒW
                        // ==@@@@
                        // ==@@@@<à–¾>@ŒÂ•ÊŽ–€‚e‚f‚ÌŽw’è‚ª‚ ‚éê‡‚ÍA‘—•tæƒf[ƒ^‚ðŒÂ•ÊŽ–€€–Ú‚ª•t‰Á‚³‚ê‚½ƒŒƒCƒAƒEƒg‚É•ÒW‚·‚éB
                        // ==@@@@@@@@‚Ü‚½Aƒoƒbƒ`”ÅEƒŠƒAƒ‹”Å‚É‚æ‚èŽg—p‚·‚éƒNƒ‰ƒX‚ð•ª‚¯‚éB
                        // ==@@@@
                        // =====================================================================================================================
                        // ˆ¶–¼ŒÂ•Êî•ñ‚Ìê‡
                        if (blnKobetsu)
                        {
                            if (m_blnBatch)
                            {
                                // uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                csAtenaDS = m_cABBatchAtenaHenshuB.SofusakiKobetsuHenshu(cAtenaGetPara1, csAtenaD, csDataSet);
                            }
                            else
                            {
                                // uˆ¶–¼•ÒWv‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                csAtenaDS = m_cABAtenaHenshuB.SofusakiKobetsuHenshu(cAtenaGetPara1, csAtenaD, csDataSet);
                            }
                        }
                        else if (m_blnBatch)
                        {
                            // uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                            csAtenaDS = m_cABBatchAtenaHenshuB.SofusakiHenshu(cAtenaGetPara1, csAtenaD, csDataSet);
                        }
                        else
                        {
                            // uˆ¶–¼•ÒWv‚Ìu‘—•tæ•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                            csAtenaDS = m_cABAtenaHenshuB.SofusakiHenshu(cAtenaGetPara1, csAtenaD, csDataSet);
                        }


                        // =====================================================================================================================
                        // == ‚Q‚RDŽæ“¾ƒf[ƒ^‚Ìƒ}[ƒW
                        // ==@@@@
                        // ==@@@@<à–¾>@u–{lvu‘—•tævu‘ã”[lvu‘ã”[‘—•tævƒf[ƒ^‚ð‚P‚Â‚Ìƒf[ƒ^ƒZƒbƒg‚Éƒ}[ƒW‚µˆ—‚ð‹­§“I‚ÉI—¹‚·‚éB
                        // ==@@@@
                        // =====================================================================================================================
                        // csAtenaH ‚Æ csAtenaHS ‚ðƒ}[ƒW‚µ‚ÄAcaAtena1 ‚ÉƒZƒbƒg‚·‚é
                        csAtena1 = this.CreateAtenaDataSet(csAtenaH, csAtenaHS, csAtenaD, csAtenaDS, blnKobetsu, intHyojunKB);
                    }



                    catch (UFRdbTimeOutException objRdbTimeOutExp)    // UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
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
                        /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 153898


                        Input:
                        " + objRdbTimeOutExp.p_strErrorCode + "z" +
                                                                "yƒ[ƒjƒ“ƒO“à—e:
                         */
                        ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                        /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 154001


                        Input:
                        " + objRdbTimeOutExp.Message + "z")
                                        ' UFAppException‚ðƒXƒ[‚·‚é
                                        Throw New UFAppException(objRdbTimeOutExp.Message, objRdbTimeOutExp.p_intErrorCode, objRdbTimeOutExp)

                                    Catch
                                        ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[
                                        Throw

                                    Finally

                                        '=====================================================================================================================
                                        '== ‚Q‚SD‚q‚c‚aØ’f
                                        '==@@@@
                                        '==@@@@<à–¾>@ƒoƒbƒ`ƒvƒƒOƒ‰ƒ€‚©‚çŒÄ‚Ño‚³‚ê‚½ê‡‚È‚ÇA–ˆ‰ñ‚q‚c‚aØ’f‚ðs‚í‚È‚¢§Œä‚ðs‚¤B
                                        '==@@@@
                                        '=====================================================================================================================
                                        ' RDBØ’f
                                        If m_blnBatchRdb = False Then
                                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                                            m_cfLogClass.RdbWrite(m_cfControlData,
                                                                    "yƒNƒ‰ƒX–¼:
                         */
                        ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                        /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 155011


                        Input:
                        " + Me.GetType.Name + "z" +
                                                                    "yƒƒ\ƒbƒh–¼:
                         */
                        ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                        /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 155098


                        Input:
                        " + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                                    "yŽÀsƒƒ\ƒbƒh–¼:
                         */
                        Disconnect();/* TODO ERROR: Skipped SkippedTokensTrivia
z")
                    m_cfRdbClass.Disconnect()
                End If


                '*—š—ð”Ô† 000031 2007/07/30 C³ŠJŽn*/
                        // =====================================================================================================================
                        // == ‚Q‚TD•Ô‹p‚·‚éZ–¯ƒR[ƒh‚ðŽw’è‚³‚ê‚½Z–¯ƒR[ƒh‚Åã‘‚«‚·‚é
                        // ==@@@@
                        // ==@@@@<à–¾>@“¯ˆêl‘ã•\ŽÒŽæ“¾‚³‚ê‚½ê‡‚ÍAŽw’è‚³‚ê‚½Z–¯ƒR[ƒh‚ð•Ô‚·
                        // ==@@@@
                        // =====================================================================================================================
                        // ‘Þ”ð‚µ‚½Z–¯ƒR[ƒh‚ª‘¶Ý‚·‚éê‡‚ÍAã‘‚«‚·‚é
                        SetJuminCD(csAtena1);
                    }
                }
                // *—š—ð”Ô† 000031 2007/07/30 C³I—¹

                // *—š—ð”Ô† 000041 2008/11/17 íœŠJŽn
                // '*—š—ð”Ô† 000040 2008/11/10 ’Ç‰ÁŠJŽn
                // '=====================================================================================================================
                // '== ‚Q‚UD—˜—p“Íoƒf[ƒ^‚Ìiž‚Ý
                // '==@@@@
                // '==@@@@<à–¾>@—˜—p“ÍoŽæ“¾‹æ•ª = "2" ‚Ìê‡A•Ô‹pƒf[ƒ^‚Ì”[ÅŽÒID‚ª‘¶Ý‚µ‚È‚¢ƒŒƒR[ƒh‚Í•Ô‹p‚µ‚È‚¢
                // '==@@@@
                // '=====================================================================================================================
                /// Þ”ð‚µ‚½Z–¯ƒR[ƒh‚ª‘¶Ý‚·‚éê‡‚ÍAã‘‚«‚·‚é
                // RiyoTdkHenshu_Select(cAtenaGetPara1, blnKobetsu, csAtena1)
                // '*—š—ð”Ô† 000040 2008/11/10 ’Ç‰ÁI—¹
                // *—š—ð”Ô† 000041 2008/11/17 íœƒVƒ…ƒEƒŠƒ‡‚¤

                while (false);

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 157482


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 157578


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 157846


                Input:
                " + Me.GetType.Name + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 157929


                                Input:
                                " + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csAtena1;

        }
        #endregion
        // *—š—ð”Ô† 000030 2007/04/21 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000030 2007/04/21 ’Ç‰ÁŠJŽn
        #region  ‰îŒì—pˆ¶–¼Žæ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‰îŒì—pˆ¶–¼Žæ“¾
        // * 
        // * \•¶           Public Function GetKaigoAtena(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           cAtenaGetPara1   : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        public DataSet GetKaigoAtena(ABAtenaGetPara1XClass cAtenaGetPara1)
        {
            ABEnumDefine.AtenaGetKB blnAtenaSelectAll;
            // * corresponds to VS2008 Start 2010/04/16 000044
            // Dim blnAtenaKani As Boolean
            // Dim blnRirekiSelectAll As ABEnumDefine.AtenaGetKB
            // Dim blnRirekiKani As Boolean
            // * corresponds to VS2008 End 2010/04/16 000044
            DataSet csAtenaEntity;                        // ‰îŒì—pˆ¶–¼Entity

            try
            {
                // ƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ð•Û‘¶
                blnAtenaSelectAll = m_blnSelectAll;
                m_blnSelectAll = ABEnumDefine.AtenaGetKB.SelectAll;
                if (m_cABAtenaB is not null)
                {
                    m_cABAtenaB.m_blnSelectAll = ABEnumDefine.AtenaGetKB.SelectAll;
                }
                if (m_cABAtenaRirekiB is not null)
                {
                    m_cABAtenaRirekiB.m_blnSelectAll = ABEnumDefine.AtenaGetKB.SelectAll;
                }

                // ˆ¶–¼Žæ“¾ƒƒCƒ“ƒƒ\ƒbƒh‚ÌŒÄo‚µiˆø”FŽæ“¾ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒXAŒÂ•ÊŽ–€ƒf[ƒ^Žæ“¾ƒtƒ‰ƒOAŒÄ‚Ño‚µƒƒ\ƒbƒh‹æ•ªj
                csAtenaEntity = AtenaGetMain(cAtenaGetPara1, false, ABEnumDefine.MethodKB.KB_Kaigo, ABEnumDefine.HyojunKB.KB_Tsujo);

                // ƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ðŒ³‚É‚à‚Ç‚·
                m_blnSelectAll = blnAtenaSelectAll;
                if (m_cABAtenaB is not null)
                {
                    m_cABAtenaB.m_blnSelectAll = blnAtenaSelectAll;
                }
                if (m_cABAtenaRirekiB is not null)
                {
                    m_cABAtenaRirekiB.m_blnSelectAll = m_blnSelectAll;
                }
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 160847


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 160943


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 161211


                Input:
                " + Me.GetType.Name + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 161294


                                Input:
                                " + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csAtenaEntity;

        }
        #endregion
        // *—š—ð”Ô† 000030 2007/04/21 ’Ç‰ÁI—¹

        #region  ŠÈˆÕˆ¶–¼Žæ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ŠÈˆÕˆ¶–¼Žæ“¾‚Q
        // * 
        // * \•¶           Public Function AtenaGet2(ByVal cAtenaGetPara1 As ABAtenaGetPara1) As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           cAtenaGetPara1   : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // * 
        // * –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        public DataSet AtenaGet2(ABAtenaGetPara1XClass cAtenaGetPara1)
        {
            const string THIS_METHOD_NAME = "AtenaGet2";
            var csAtenaEntity = default(DataSet);                        // ˆ¶–¼Entity
                                                                         // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
            var blnAtenaSelectAll = default(ABEnumDefine.AtenaGetKB);
            var blnAtenaKani = default(bool);
            var blnRirekiSelectAll = default(ABEnumDefine.AtenaGetKB);
            var blnRirekiKani = default(bool);
            // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // * —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                // RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:Connectz")
                // * —š—ð”Ô† 000023 2004/08/27 íœI—¹
                // ‚q‚c‚aÚ‘±
                if (m_blnBatchRdb == false)
                {
                    // * —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
                    // RDBƒAƒNƒZƒXƒƒOo—Í
                    m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:Connectz");
                    // * —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁI—¹
                    m_cfRdbClass.Connect();
                }

                try
                {
                    // * —š—ð”Ô† 000014 2003/06/17 íœŠJŽn
                    // ' ŠÇ—î•ñŽæ“¾(“à•”ˆ—)ƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
                    // Me.GetKanriJoho()
                    // * —š—ð”Ô† 000014 2003/06/17 íœI—¹

                    // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òjŠÈˆÕ“Ç‚Ýž‚Ý‰Â”\‚É‚µ‚½‚½‚ß”N‹à‘Î‰ži‘S‚Ä“Ç‚Þ‚æ‚¤‚Éj
                    // ƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ð•Û‘¶
                    if (m_cABAtenaB is not null)
                    {
                        blnAtenaSelectAll = m_cABAtenaB.m_blnSelectAll;
                        blnAtenaKani = m_cABAtenaB.m_blnSelectCount;
                        m_cABAtenaB.m_blnSelectAll = ABEnumDefine.AtenaGetKB.SelectAll;
                        m_cABAtenaB.m_blnSelectCount = false;
                    }
                    if (m_cABAtenaRirekiB is not null)
                    {
                        blnRirekiSelectAll = m_cABAtenaRirekiB.m_blnSelectAll;
                        blnRirekiKani = m_cABAtenaRirekiB.m_blnSelectCount;
                        m_cABAtenaRirekiB.m_blnSelectAll = ABEnumDefine.AtenaGetKB.SelectAll;
                        m_cABAtenaRirekiB.m_blnSelectCount = false;

                    }
                    // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹

                    // ŠÈˆÕˆ¶–¼Žæ“¾‚Q(“à•”ˆ—)ƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
                    csAtenaEntity = this.GetAtena2(cAtenaGetPara1, ABEnumDefine.HyojunKB.KB_Tsujo);

                    // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
                    // ƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ðŒ³‚É‚à‚Ç‚·
                    if (m_cABAtenaB is not null)
                    {
                        m_cABAtenaB.m_blnSelectAll = blnAtenaSelectAll;
                        m_cABAtenaB.m_blnSelectCount = blnAtenaKani;
                    }
                    if (m_cABAtenaRirekiB is not null)
                    {
                        m_cABAtenaRirekiB.m_blnSelectAll = blnRirekiSelectAll;
                        m_cABAtenaRirekiB.m_blnSelectCount = blnRirekiKani;
                    }
                }
                // * —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹

                catch (UFRdbTimeOutException objRdbTimeOutExp)    // UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 166439


                    Input:
                    " + objRdbTimeOutExp.p_strErrorCode + "z" +
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
                    // RDBƒAƒNƒZƒXƒƒOo—Í
                    // m_cfLogClass.RdbWrite(m_cfControlData, _
                    // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                    // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                    // "yŽÀsƒƒ\ƒbƒh–¼:Disconnectz")
                    // * —š—ð”Ô† 000023 2004/08/27 íœI—¹
                    // RDBØ’f
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 166542


                                        Input:
                                        " + objRdbTimeOutExp.Message + "z")
                                                        ' UFAppException‚ðƒXƒ[‚·‚é
                                                        Throw New UFAppException(objRdbTimeOutExp.Message, objRdbTimeOutExp.p_intErrorCode, objRdbTimeOutExp)

                                                    Catch
                                                        ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[
                                                        Throw

                                                    Finally
                                                        '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj

                                         */
                    if (m_blnBatchRdb == false)
                    {
                        // * —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
                        // RDBƒAƒNƒZƒXƒƒOo—Í
                        m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:Disconnectz");
                        // * —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁI—¹
                        m_cfRdbClass.Disconnect();
                    }

                }

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 168620


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 168716


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 168984


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 169067


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

            return csAtenaEntity;

        }
        #endregion

        #region  ŠÇ—î•ñŽæ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ŠÇ—î•ñŽæ“¾
        // * 
        // * \•¶           Public Function KanriJohoGet()
        // * 
        // * ‹@”\@@    @@ŠÇ—î•ñ‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        public void KanriJohoGet()
        {
            const string THIS_METHOD_NAME = "KanriJohoGet";

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
                if (m_blnKanriJoho)
                {
                    return;
                }
                // * —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹

                // * —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                // RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:Connectz")
                // * —š—ð”Ô† 000023 2004/08/27 íœI—¹
                // ‚q‚c‚aÚ‘±
                if (m_blnBatchRdb == false)
                {
                    // * —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
                    // RDBƒAƒNƒZƒXƒƒOo—Í
                    m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:Connectz");
                    // * —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁI—¹
                    m_cfRdbClass.Connect();
                }

                try
                {

                    // ŠÇ—î•ñŽæ“¾(“à•”ˆ—)ƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
                    this.GetKanriJoho();
                }

                catch (UFRdbTimeOutException objRdbTimeOutExp)    // UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 171917


                    Input:
                    " + objRdbTimeOutExp.p_strErrorCode + "z" +
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
                    // RDBƒAƒNƒZƒXƒƒOo—Í
                    // m_cfLogClass.RdbWrite(m_cfControlData, _
                    // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                    // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                    // "yŽÀsƒƒ\ƒbƒh–¼:Disconnectz")
                    // * —š—ð”Ô† 000023 2004/08/27 íœI—¹
                    // RDBØ’f
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 172020


                                        Input:
                                        " + objRdbTimeOutExp.Message + "z")
                                                        ' UFAppException‚ðƒXƒ[‚·‚é
                                                        Throw New UFAppException(objRdbTimeOutExp.Message, objRdbTimeOutExp.p_intErrorCode, objRdbTimeOutExp)

                                                    Catch
                                                        ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[
                                                        Throw

                                                    Finally
                                                        '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj

                                         */
                    if (m_blnBatchRdb == false)
                    {
                        // * —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
                        // RDBƒAƒNƒZƒXƒƒOo—Í
                        m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:Disconnectz");
                        // * —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁI—¹
                        m_cfRdbClass.Disconnect();
                    }

                }

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 174098


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 174194


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 174462


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 174545


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }
        }
        #endregion

        #region  ”
        // *—š—ð”Ô† 000029 2006/07/31 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ”N‹àˆ¶–¼Žæ“¾
        // * 
        // * \•¶           Public Function NenkinAtenaGet(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet
        // * 
        // * ‹@”\@@       ”N‹àˆ¶–¼î•ñ‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           cAtenaGetPara1    : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // * 
        // * –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        public DataSet NenkinAtenaGet(ABAtenaGetPara1XClass cAtenaGetPara1)
        {
            // * corresponds to VS2008 Start 2010/04/16 000044
            // Const THIS_METHOD_NAME As String = "NenkinAtenaGet"
            // * corresponds to VS2008 End 2010/04/16 000044
            // ”N‹àˆ¶–¼ƒQƒbƒg‚æ‚è”N‹àˆ¶–¼î•ñ‚ðŽæ“¾‚·‚é
            return NenkinAtenaGet(cAtenaGetPara1, ABEnumDefine.NenkinAtenaGetKB.Version01);
        }
        // *—š—ð”Ô† 000029 2006/07/31 ’Ç‰ÁI—¹
        #endregion

        #region  ”
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ”N‹àˆ¶–¼Žæ“¾
        // * 
        // * \•¶           Public Function NenkinAtenaGet(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet
        // * 
        // * ‹@”\@@       ”N‹àˆ¶–¼î•ñ‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           cAtenaGetPara1    : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // * 
        // * –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        // *—š—ð”Ô† 000029 2006/07/31 C³ŠJŽn
        public DataSet NenkinAtenaGet(ABAtenaGetPara1XClass cAtenaGetPara1, int intNenkinAtenaGetKB)
        {
            // Const THIS_METHOD_NAME As String = "NenkinAtenaGet"
            // 'Public Function NenkinAtenaGet(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet
            // '    Const THIS_METHOD_NAME As String = "KanriJohoGet"
            // '*—š—ð”Ô† 000029 2006/07/31 C³I—¹
            // '*—š—ð”Ô† 000015 2003/08/21 íœŠJŽn
            // 'Dim cABAtenaHenshuB As ABAtenaHenshuBClass          'ˆ¶–¼•ÒWƒNƒ‰ƒX
            // '*—š—ð”Ô† 000015 2003/08/21 íœI—¹
            // Dim csAtenaEntity As DataSet                        'ˆ¶–¼Entity
            // Dim csAtena1Entity As DataSet                       'ˆ¶–¼1Entity
            // '*—š—ð”Ô† 000022 2003/12/02 ’Ç‰ÁŠJŽn
            // Dim cAtenaGetPara1Save As New ABAtenaGetPara1XClass     ' ‘Þ”ð—p
            // '*—š—ð”Ô† 000022 2003/12/02 ’Ç‰ÁI—¹

            // '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
            // Dim blnAtenaSelectAll As ABEnumDefine.AtenaGetKB
            // Dim blnAtenaKani As Boolean
            // Dim blnRirekiSelectAll As ABEnumDefine.AtenaGetKB
            // Dim blnRirekiKani As Boolean
            // '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹

            // Try
            // ' ƒfƒoƒbƒOƒƒOo—Í
            // m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)


            // '=====================================================================================================================
            // '== ‚PD‚q‚c‚aÚ‘±
            // '==@@@@
            // '==@@@@<à–¾>@ƒoƒbƒ`ƒvƒƒOƒ‰ƒ€‚©‚çŒÄ‚Ño‚³‚ê‚½ê‡‚È‚ÇA–ˆ‰ñ‚q‚c‚aÚ‘±‚ðs‚í‚È‚¢§Œä‚ðs‚¤B
            // '==@@@@
            // '=====================================================================================================================
            // '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
            // ' RDBƒAƒNƒZƒXƒƒOo—Í
            // 'm_cfLogClass.RdbWrite(m_cfControlData, _
            // '                                "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
            // '                                "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
            // '                                "yŽÀsƒƒ\ƒbƒh–¼:Connectz")
            // '* —š—ð”Ô† 000023 2004/08/27 íœI—¹
            // '‚q‚c‚aÚ‘±
            // If m_blnBatchRdb = False Then
            // '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
            // ' RDBƒAƒNƒZƒXƒƒOo—Í
            // m_cfLogClass.RdbWrite(m_cfControlData,
            // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
            // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
            // "yŽÀsƒƒ\ƒbƒh–¼:Connectz")
            // '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁI—¹
            // m_cfRdbClass.Connect()
            // End If

            // Try
            // '=====================================================================================================================
            // '== ‚QDŠeŽíƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            // '==@@@@
            // '==@@@@<à–¾>@ƒoƒbƒ`ƒtƒ‰ƒO‚Ìê‡•ª‚¯‚É‚æ‚èAƒŠƒAƒ‹—pEƒoƒbƒ`—pƒNƒ‰ƒX‚ðƒCƒ“ƒXƒ^ƒ“ƒX‰»‚·‚éB
            // '==@@@@
            // '=====================================================================================================================
            // '*—š—ð”Ô† 000015 2003/08/21 C³ŠJŽn
            // ''ˆ¶–¼•ÒWƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // 'cABAtenaHenshuB = New ABAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
            // If (m_blnBatch) Then
            // If (m_cABBatchAtenaHenshuB Is Nothing) Then
            // 'ˆ¶–¼•ÒWƒoƒbƒ`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // '* —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
            // 'm_cABBatchAtenaHenshuB = New ABBatchAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
            // m_cABBatchAtenaHenshuB = New ABBatchAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass, m_blnSelectAll)
            // '* —š—ð”Ô† 000024 2005/01/25 XVI—¹
            // End If
            // Else
            // If (m_cABAtenaHenshuB Is Nothing) Then
            // 'ˆ¶–¼•ÒWƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            // '* —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
            // 'm_cABAtenaHenshuB = New ABAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
            // m_cABAtenaHenshuB = New ABAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass, m_blnSelectAll)
            // '* —š—ð”Ô† 000024 2005/01/25 XVI—¹
            // End If
            // End If
            // '*—š—ð”Ô† 000015 2003/08/21 C³I—¹

            // '*—š—ð”Ô† 000045 2010/05/17 ’Ç‰ÁŠJŽn
            // ' ˆ¶–¼‚aƒNƒ‰ƒXŠeŽíƒvƒƒpƒeƒB‚ðƒZƒbƒg
            // m_cABAtenaB.p_strHonsekiHittoshKB = cAtenaGetPara1.p_strHonsekiHittoshKB
            // m_cABAtenaB.p_strShoriteishiKB = cAtenaGetPara1.p_strShoriTeishiKB
            // '*—š—ð”Ô† 000046 2011/05/18 ’Ç‰ÁŠJŽn
            // m_cABAtenaB.p_strFrnZairyuJohoKB = cAtenaGetPara1.p_strFrnZairyuJohoKB
            // '*—š—ð”Ô† 000046 2011/05/18 ’Ç‰ÁI—¹

            // ' ˆ¶–¼—š—ð‚aƒNƒ‰ƒXŠeŽíƒvƒƒpƒeƒB‚ðƒZƒbƒg
            // m_cABAtenaRirekiB.p_strHonsekiHittoshKB = cAtenaGetPara1.p_strHonsekiHittoshKB
            // m_cABAtenaRirekiB.p_strShoriteishiKB = cAtenaGetPara1.p_strShoriTeishiKB
            // '*—š—ð”Ô† 000046 2011/05/18 ’Ç‰ÁŠJŽn
            // m_cABAtenaRirekiB.p_strFrnZairyuJohoKB = cAtenaGetPara1.p_strFrnZairyuJohoKB
            // '*—š—ð”Ô† 000046 2011/05/18 ’Ç‰ÁI—¹
            // '*—š—ð”Ô† 000045 2010/05/17 ’Ç‰ÁI—¹


            // '=====================================================================================================================
            // '== ‚RDƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ð•Û‘¶
            // '==@@@@
            // '==@@@@<à–¾>@ŠÈˆÕ”ÅE’Êí”Å‚Ìî•ñ‚ð•Û‘¶‚·‚éB
            // '==@@@@
            // '=====================================================================================================================
            // '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òjŠÈˆÕ“Ç‚Ýž‚Ý‰Â”\‚É‚µ‚½‚½‚ß”N‹à‘Î‰ži‘S‚Ä“Ç‚Þ‚æ‚¤‚Éj
            // 'ƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ð•Û‘¶
            // If Not (Me.m_cABBatchAtenaHenshuB Is Nothing) Then
            // Me.m_cABBatchAtenaHenshuB.m_blnSelectAll = ABEnumDefine.AtenaGetKB.SelectAll
            // End If
            // If Not (Me.m_cABAtenaHenshuB Is Nothing) Then
            // Me.m_cABAtenaHenshuB.m_blnSelectAll = ABEnumDefine.AtenaGetKB.SelectAll
            // End If
            // '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj



            // '=====================================================================================================================
            // '== ‚SDŠÇ—î•ñ‚ÌŽæ“¾
            // '==@@@@
            // '==@@@@<à–¾>@ŠeŽíŠÇ—î•ñ‚ÌŽæ“¾‚ðs‚¤B
            // '==@@@@
            // '=====================================================================================================================
            // ' ŠÇ—î•ñŽæ“¾(“à•”ˆ—)ƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
            // Me.GetKanriJoho()



            // '=====================================================================================================================
            // '== ‚TD‹Æ–±ƒR[ƒh‚Ì‘Þ”ð
            // '==@@@@
            // '==@@@@<à–¾>@‹Æ–±ƒR[ƒhE‹Æ–±“àŽí•ÊƒR[ƒh‚ð‘Þ”ð‚·‚éB
            // '==@@@@
            // '=====================================================================================================================
            // '*—š—ð”Ô† 000022 2003/12/02 ’Ç‰ÁŠJŽn
            // ' ‹Æ–±ƒR[ƒhE‹Æ–±“àŽí•ÊƒR[ƒh‚ð‘Þ”ð‚·‚é
            // cAtenaGetPara1Save.p_strGyomuCD = cAtenaGetPara1.p_strGyomuCD
            // cAtenaGetPara1Save.p_strGyomunaiSHU_CD = cAtenaGetPara1.p_strGyomunaiSHU_CD
            // cAtenaGetPara1.p_strGyomuCD = String.Empty
            // cAtenaGetPara1.p_strGyomunaiSHU_CD = String.Empty
            // '*—š—ð”Ô† 000022 2003/12/02 ’Ç‰ÁI—¹



            // '=====================================================================================================================
            // '== ‚UDƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ð•Û‘¶
            // '==@@@@
            // '==@@@@<à–¾>@ŠÈˆÕ”ÅE’Êí”ÅA’¼‹ß”ÅE—š—ð”Å‚Ìî•ñ‚ð•Û‘¶‚·‚éB
            // '==@@@@
            // '=====================================================================================================================
            // '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òjŠÈˆÕ“Ç‚Ýž‚Ý‰Â”\‚É‚µ‚½‚½‚ß”N‹à‘Î‰ži‘S‚Ä“Ç‚Þ‚æ‚¤‚Éj
            // 'ƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ð•Û‘¶
            // If Not (Me.m_cABAtenaB Is Nothing) Then
            // blnAtenaSelectAll = Me.m_cABAtenaB.m_blnSelectAll
            // blnAtenaKani = Me.m_cABAtenaB.m_blnSelectCount
            // Me.m_cABAtenaB.m_blnSelectAll = ABEnumDefine.AtenaGetKB.NenkinAll
            // Me.m_cABAtenaB.m_blnSelectCount = True
            // End If
            // If Not (Me.m_cABAtenaRirekiB Is Nothing) Then
            // blnRirekiSelectAll = Me.m_cABAtenaRirekiB.m_blnSelectAll
            // blnRirekiKani = Me.m_cABAtenaRirekiB.m_blnSelectCount
            // Me.m_cABAtenaRirekiB.m_blnSelectAll = ABEnumDefine.AtenaGetKB.NenkinAll
            // Me.m_cABAtenaRirekiB.m_blnSelectCount = True

            // End If
            // '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹



            // '=====================================================================================================================
            // '== ‚UDˆ¶–¼î•ñ‚ÌŽæ“¾
            // '==@@@@
            // '==@@@@<à–¾>@ˆ¶–¼î•ñ‚ÌŽæ“¾‚ðs‚¤B
            // '==@@@@
            // '=====================================================================================================================
            // ' ŠÈˆÕˆ¶–¼Žæ“¾(“à•”ˆ—)‚Qƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
            // csAtenaEntity = Me.GetAtena2(cAtenaGetPara1)



            // '=====================================================================================================================
            // '== ‚VDƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ð–ß‚·
            // '==@@@@
            // '==@@@@<à–¾>@ŠÈˆÕ”ÅE’Êí”ÅA’¼‹ß”ÅE—š—ð”Å‚Ìî•ñ‚ð–ß‚·B
            // '==@@@@
            // '=====================================================================================================================
            // '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
            // 'ƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ðŒ³‚É‚à‚Ç‚·
            // If Not (Me.m_cABAtenaB Is Nothing) Then
            // Me.m_cABAtenaB.m_blnSelectAll = blnAtenaSelectAll
            // Me.m_cABAtenaB.m_blnSelectCount = blnAtenaKani
            // End If
            // If Not (Me.m_cABAtenaRirekiB Is Nothing) Then
            // Me.m_cABAtenaRirekiB.m_blnSelectAll = blnRirekiSelectAll
            // Me.m_cABAtenaRirekiB.m_blnSelectCount = blnRirekiKani
            // End If
            // '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹



            // '=====================================================================================================================
            // '== ‚WDˆ¶–¼î•ñ‚Ì•ÒW
            // '==@@@@
            // '==@@@@<à–¾>@ˆ¶–¼î•ñ‚Ì•ÒW‚ðs‚¤B
            // '==@@@@@@@@ú@. Žw’è”NŒŽ“ú‚ª‚ ‚éê‡‚Íuˆ¶–¼—š—ðƒ}ƒXƒ^FABATENARIREKIv‚É‚æ‚èŽæ“¾‚·‚é
            // '==@@@@@@@@úA. Žw’è”NŒŽ“ú‚ª‚È‚¢ê‡‚Íuˆ¶–¼ƒ}ƒXƒ^FABATENAv‚É‚æ‚èŽæ“¾‚·‚é
            // '==@@@@@@@@úB. ƒoƒbƒ`”Å‚ÌŽw’è‚ª‚ ‚éê‡‚Íƒoƒbƒ`”Å‚ÌƒNƒ‰ƒX‚É‚æ‚èŽæ“¾‚·‚é
            // '==@@@@
            // '=====================================================================================================================
            // '*—š—ð”Ô† 000015 2003/08/21 C³ŠJŽn
            // '' ˆ¶–¼•ÒWƒNƒ‰ƒX‚Ì”N‹àˆ¶–¼•ÒWƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
            // 'csAtena1Entity = cABAtenaHenshuB.NenkinAtenaHenshu(cAtenaGetPara1, csAtenaEntity)
            // '*—š—ð”Ô† 000016 2003/10/09 C³ŠJŽn
            // 'If (m_blnBatch) Then
            // '    ' ˆ¶–¼•ÒWƒoƒbƒ`ƒNƒ‰ƒX‚Ì”N‹àˆ¶–¼•ÒWƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
            // '    csAtena1Entity = m_cABBatchAtenaHenshuB.NenkinAtenaHenshu(cAtenaGetPara1, csAtenaEntity)
            // 'Else
            // '    ' ˆ¶–¼•ÒWƒNƒ‰ƒX‚Ì”N‹àˆ¶–¼•ÒWƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
            // '    csAtena1Entity = m_cABAtenaHenshuB.NenkinAtenaHenshu(cAtenaGetPara1, csAtenaEntity)
            // 'End If
            // ' Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡
            // If Not (cAtenaGetPara1.p_strShiteiYMD = "") Then
            // If (m_blnBatch) Then
            // '*—š—ð”Ô† 000029 2006/07/31 C³ŠJŽn
            // 'uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // If intNenkinAtenaGetKB = ABEnumDefine.NenkinAtenaGetKB.Version01 Then
            // csAtena1Entity = m_cABBatchAtenaHenshuB.NenkinRirekiHenshu(cAtenaGetPara1, csAtenaEntity)
            // Else
            // csAtena1Entity = m_cABBatchAtenaHenshuB.NenkinRirekiHenshu2(cAtenaGetPara1, csAtenaEntity)
            // End If
            // 'csAtena1Entity = m_cABBatchAtenaHenshuB.NenkinRirekiHenshu(cAtenaGetPara1, csAtenaEntity)
            // '*—š—ð”Ô† 000029 2006/07/31 C³I—¹

            // Else
            // '*—š—ð”Ô† 000029 2006/07/31 C³ŠJŽn
            // 'uˆ¶–¼•ÒWv‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // If intNenkinAtenaGetKB = ABEnumDefine.NenkinAtenaGetKB.Version01 Then
            // csAtena1Entity = m_cABAtenaHenshuB.NenkinRirekiHenshu(cAtenaGetPara1, csAtenaEntity)
            // Else
            // csAtena1Entity = m_cABAtenaHenshuB.NenkinRirekiHenshu2(cAtenaGetPara1, csAtenaEntity)
            // End If
            // 'csAtena1Entity = m_cABAtenaHenshuB.NenkinRirekiHenshu(cAtenaGetPara1, csAtenaEntity)
            // '*—š—ð”Ô† 000029 2006/07/31 C³I—¹
            // End If
            // Else
            // If (m_blnBatch) Then
            // '*—š—ð”Ô† 000029 2006/07/31 C³ŠJŽn
            // ' ˆ¶–¼•ÒWƒoƒbƒ`ƒNƒ‰ƒX‚Ì”N‹àˆ¶–¼•ÒWƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
            // If intNenkinAtenaGetKB = ABEnumDefine.NenkinAtenaGetKB.Version01 Then
            // csAtena1Entity = m_cABBatchAtenaHenshuB.NenkinAtenaHenshu(cAtenaGetPara1, csAtenaEntity)
            // Else
            // csAtena1Entity = m_cABBatchAtenaHenshuB.NenkinAtenaHenshu2(cAtenaGetPara1, csAtenaEntity)
            // End If
            // 'csAtena1Entity = m_cABBatchAtenaHenshuB.NenkinAtenaHenshu(cAtenaGetPara1, csAtenaEntity)
            // '*—š—ð”Ô† 000029 2006/07/31 C³I—¹
            // Else
            // '*—š—ð”Ô† 000029 2006/07/31 C³ŠJŽn
            // ' ˆ¶–¼•ÒWƒNƒ‰ƒX‚Ì”N‹àˆ¶–¼•ÒWƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
            // If intNenkinAtenaGetKB = ABEnumDefine.NenkinAtenaGetKB.Version01 Then
            // csAtena1Entity = m_cABAtenaHenshuB.NenkinAtenaHenshu(cAtenaGetPara1, csAtenaEntity)
            // Else
            // csAtena1Entity = m_cABAtenaHenshuB.NenkinAtenaHenshu2(cAtenaGetPara1, csAtenaEntity)
            // End If
            // 'csAtena1Entity = m_cABAtenaHenshuB.NenkinAtenaHenshu(cAtenaGetPara1, csAtenaEntity)
            // '*—š—ð”Ô† 000029 2006/07/31 C³I—¹
            // End If
            // End If
            // '*—š—ð”Ô† 000016 2003/10/09 C³I—¹
            // '*—š—ð”Ô† 000015 2003/08/21 C³I—¹



            // '=====================================================================================================================
            // '== ‚XD‹Æ–±ƒR[ƒh‚Ì‘Þ”ð
            // '==@@@@
            // '==@@@@<à–¾>@‹Æ–±ƒR[ƒhE‹Æ–±“àŽí•ÊƒR[ƒh‚ð‘Þ”ð‚·‚éB
            // '==@@@@
            // '=====================================================================================================================
            // '*—š—ð”Ô† 000022 2003/12/02 ’Ç‰ÁŠJŽn
            // ' ‹Æ–±ƒR[ƒhE‹Æ–±“àŽí•ÊƒR[ƒh‚ð•œŒ³‚·‚é
            // cAtenaGetPara1.p_strGyomuCD = cAtenaGetPara1Save.p_strGyomuCD
            // cAtenaGetPara1.p_strGyomunaiSHU_CD = cAtenaGetPara1Save.p_strGyomunaiSHU_CD




            // '=====================================================================================================================
            // '== ‚P‚OD˜A—æƒf[ƒ^‚ÌŽæ“¾
            // '==@@@@
            // '==@@@@<à–¾>@˜A—æî•ñ‚ðŽæ“¾‚·‚éB
            // '==@@@@@@@@ú@. ‹Æ–±ƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢ê‡‚ÍA‰½‚à‚µ‚È‚¢
            // '==@@@@@@@@úA. Žw’è‚µ‚½‹Æ–±ƒR[ƒhE‹Æ–±“àŽí•ÊƒR[ƒh‚ððŒ‚Éu˜A—æƒ}ƒXƒ^FABRENRAKUSAKIv‚©‚çŽæ“¾‚·‚é
            // '==@@@@@@@@úB. úA.‚Åƒf[ƒ^‚ªŽæ“¾‚µ‚½ê‡A–³ðŒ‚É˜A—æ‚PA˜A—æ‚Q‚ð•Ô‹p‚·‚é
            // '==@@@@@@@@úC. ”N‹àˆ¶–¼ƒQƒbƒgEŒÂ•ÊƒQƒbƒg‚ÌƒŒƒCƒAƒEƒg‚Ìê‡‚Ì‚Ýu˜A—æ‹Æ–±ƒR[ƒhv‚É’ŠoðŒ‚Ì‹Æ–±ƒR[ƒh‚ðƒZƒbƒg‚·‚é
            // '==@@@@
            // '=====================================================================================================================
            // ' ˜A—æ•ÒWˆ—
            // '* —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
            // 'Me.RenrakusakiHenshu(cAtenaGetPara1.p_strGyomuCD, cAtenaGetPara1.p_strGyomunaiSHU_CD, csAtena1Entity)
            // Me.RenrakusakiHenshu(cAtenaGetPara1.p_strGyomuCD, cAtenaGetPara1.p_strGyomunaiSHU_CD, csAtena1Entity, csAtenaEntity)
            // '* —š—ð”Ô† 000024 2005/01/25 XVI—¹
            // '*—š—ð”Ô† 000022 2003/12/02 ’Ç‰ÁI—¹



            // '=====================================================================================================================
            // '== ‚P‚PDƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ð–ß‚·
            // '==@@@@
            // '==@@@@<à–¾>@ŠÈˆÕ”ÅE’Êí”Å‚Ìî•ñ‚ð–ß‚·B
            // '==@@@@
            // '=====================================================================================================================
            // '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
            // 'ƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ðŒ³‚É‚à‚Ç‚·
            // If Not (Me.m_cABBatchAtenaHenshuB Is Nothing) Then
            // Me.m_cABBatchAtenaHenshuB.m_blnSelectAll = Me.m_blnSelectAll
            // End If
            // If Not (Me.m_cABAtenaHenshuB Is Nothing) Then
            // Me.m_cABAtenaHenshuB.m_blnSelectAll = Me.m_blnSelectAll
            // End If
            // '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹

            // Catch objRdbTimeOutExp As UFRdbTimeOutException    ' UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
            // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
            // m_cfLogClass.WarningWrite(m_cfControlData,
            // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
            // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
            // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objRdbTimeOutExp.p_strErrorCode + "z" +
            // "yƒ[ƒjƒ“ƒO“à—e:" + objRdbTimeOutExp.Message + "z")
            // ' UFAppException‚ðƒXƒ[‚·‚é
            // Throw New UFAppException(objRdbTimeOutExp.Message, objRdbTimeOutExp.p_intErrorCode, objRdbTimeOutExp)

            // Catch
            // ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[
            // Throw

            // Finally
            // '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
            // ' RDBƒAƒNƒZƒXƒƒOo—Í
            // 'm_cfLogClass.RdbWrite(m_cfControlData, _
            // '                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
            // '                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
            // '                        "yŽÀsƒƒ\ƒbƒh–¼:Disconnectz")
            // '* —š—ð”Ô† 000023 2004/08/27 íœI—¹
            // ' RDBØ’f
            // If m_blnBatchRdb = False Then
            // '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
            // ' RDBƒAƒNƒZƒXƒƒOo—Í
            // m_cfLogClass.RdbWrite(m_cfControlData,
            // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
            // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
            // "yŽÀsƒƒ\ƒbƒh–¼:Disconnectz")
            // '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁI—¹
            // m_cfRdbClass.Disconnect()
            // End If

            // End Try

            // ' ƒfƒoƒbƒOƒƒOo—Í
            // m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)


            // Catch objAppExp As UFAppException    ' UFAppException‚ðƒLƒƒƒbƒ`
            // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
            // m_cfLogClass.WarningWrite(m_cfControlData,
            // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
            // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
            // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" +
            // "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
            // ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
            // Throw objAppExp

            // Catch objExp As Exception
            // ' ƒGƒ‰[ƒƒOo—Í
            // m_cfLogClass.ErrorWrite(m_cfControlData,
            // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
            // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
            // "yƒGƒ‰[“à—e:" + objExp.Message + "z")
            // ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
            // Throw objExp

            // End Try

            // Return csAtena1Entity

            return GetNenkinAtena(cAtenaGetPara1, intNenkinAtenaGetKB, ABEnumDefine.HyojunKB.KB_Tsujo);

        }
        #endregion

        #region  ”
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ”N‹àˆ¶–¼Žæ“¾i“à•”ˆ—j
        // * 
        // * \•¶           Private Function GetNenkinAtena(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet
        // * 
        // * ‹@”\@@       ”N‹àˆ¶–¼î•ñ‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           cAtenaGetPara1    : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
        // * 
        // * –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
        // ************************************************************************************************
        private DataSet GetNenkinAtena(ABAtenaGetPara1XClass cAtenaGetPara1, int intNenkinAtenaGetKB, ABEnumDefine.HyojunKB intHyojunKB)
        {
            const string THIS_METHOD_NAME = "GetNenkinAtena";
            DataSet csAtenaEntity;                        // ˆ¶–¼Entity
            DataSet csAtena1Entity;                       // ˆ¶–¼1Entity
            var cAtenaGetPara1Save = new ABAtenaGetPara1XClass();     // ‘Þ”ð—p
            var blnAtenaSelectAll = default(ABEnumDefine.AtenaGetKB);
            var blnAtenaKani = default(bool);
            var blnRirekiSelectAll = default(ABEnumDefine.AtenaGetKB);
            var blnRirekiKani = default(bool);
            string strKikanYMD;                           // ŠúŠÔ”NŒŽ“ú

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);


                // =====================================================================================================================
                // == ‚PD‚q‚c‚aÚ‘±
                // ==@@@@
                // ==@@@@<à–¾>@ƒoƒbƒ`ƒvƒƒOƒ‰ƒ€‚©‚çŒÄ‚Ño‚³‚ê‚½ê‡‚È‚ÇA–ˆ‰ñ‚q‚c‚aÚ‘±‚ðs‚í‚È‚¢§Œä‚ðs‚¤B
                // ==@@@@
                // =====================================================================================================================
                // ‚q‚c‚aÚ‘±
                if (m_blnBatchRdb == false)
                {
                    // RDBƒAƒNƒZƒXƒƒOo—Í
                    m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:Connectz");
                    m_cfRdbClass.Connect();
                }

                try
                {
                    // =====================================================================================================================
                    // == ‚QDŠeŽíƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    // ==@@@@
                    // ==@@@@<à–¾>@ƒoƒbƒ`ƒtƒ‰ƒO‚Ìê‡•ª‚¯‚É‚æ‚èAƒŠƒAƒ‹—pEƒoƒbƒ`—pƒNƒ‰ƒX‚ðƒCƒ“ƒXƒ^ƒ“ƒX‰»‚·‚éB
                    // ==@@@@
                    // =====================================================================================================================
                    if (m_blnBatch)
                    {
                        if (m_cABBatchAtenaHenshuB is null)
                        {
                            // ˆ¶–¼•ÒWƒoƒbƒ`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                            m_cABBatchAtenaHenshuB = new ABBatchAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass, m_blnSelectAll);
                        }
                        m_cABBatchAtenaHenshuB.m_intHyojunKB = intHyojunKB;
                    }
                    else
                    {
                        if (m_cABAtenaHenshuB is null)
                        {
                            // ˆ¶–¼•ÒWƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                            m_cABAtenaHenshuB = new ABAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass, m_blnSelectAll);
                        }
                        m_cABAtenaHenshuB.m_intHyojunKB = intHyojunKB;
                    }

                    m_cABAtenaB.m_intHyojunKB = intHyojunKB;
                    m_cABAtenaRirekiB.m_intHyojunKB = intHyojunKB;

                    // ˆ¶–¼‚aƒNƒ‰ƒXŠeŽíƒvƒƒpƒeƒB‚ðƒZƒbƒg
                    m_cABAtenaB.p_strHonsekiHittoshKB = cAtenaGetPara1.p_strHonsekiHittoshKB;
                    m_cABAtenaB.p_strShoriteishiKB = cAtenaGetPara1.p_strShoriTeishiKB;
                    m_cABAtenaB.p_strFrnZairyuJohoKB = cAtenaGetPara1.p_strFrnZairyuJohoKB;

                    // ˆ¶–¼—š—ð‚aƒNƒ‰ƒXŠeŽíƒvƒƒpƒeƒB‚ðƒZƒbƒg
                    m_cABAtenaRirekiB.p_strHonsekiHittoshKB = cAtenaGetPara1.p_strHonsekiHittoshKB;
                    m_cABAtenaRirekiB.p_strShoriteishiKB = cAtenaGetPara1.p_strShoriTeishiKB;
                    m_cABAtenaRirekiB.p_strFrnZairyuJohoKB = cAtenaGetPara1.p_strFrnZairyuJohoKB;


                    // =====================================================================================================================
                    // == ‚RDƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ð•Û‘¶
                    // ==@@@@
                    // ==@@@@<à–¾>@ŠÈˆÕ”ÅE’Êí”Å‚Ìî•ñ‚ð•Û‘¶‚·‚éB
                    // ==@@@@
                    // =====================================================================================================================
                    // ƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ð•Û‘¶
                    if (m_cABBatchAtenaHenshuB is not null)
                    {
                        m_cABBatchAtenaHenshuB.m_blnSelectAll = ABEnumDefine.AtenaGetKB.SelectAll;
                    }
                    if (m_cABAtenaHenshuB is not null)
                    {
                        m_cABAtenaHenshuB.m_blnSelectAll = ABEnumDefine.AtenaGetKB.SelectAll;
                    }



                    // =====================================================================================================================
                    // == ‚SDŠÇ—î•ñ‚ÌŽæ“¾
                    // ==@@@@
                    // ==@@@@<à–¾>@ŠeŽíŠÇ—î•ñ‚ÌŽæ“¾‚ðs‚¤B
                    // ==@@@@
                    // =====================================================================================================================
                    // ŠÇ—î•ñŽæ“¾(“à•”ˆ—)ƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
                    this.GetKanriJoho();



                    // =====================================================================================================================
                    // == ‚TD‹Æ–±ƒR[ƒh‚Ì‘Þ”ð
                    // ==@@@@
                    // ==@@@@<à–¾>@‹Æ–±ƒR[ƒhE‹Æ–±“àŽí•ÊƒR[ƒh‚ð‘Þ”ð‚·‚éB
                    // ==@@@@
                    // =====================================================================================================================
                    // ‹Æ–±ƒR[ƒhE‹Æ–±“àŽí•ÊƒR[ƒh‚ð‘Þ”ð‚·‚é
                    cAtenaGetPara1Save.p_strGyomuCD = cAtenaGetPara1.p_strGyomuCD;
                    cAtenaGetPara1Save.p_strGyomunaiSHU_CD = cAtenaGetPara1.p_strGyomunaiSHU_CD;
                    cAtenaGetPara1.p_strGyomuCD = string.Empty;
                    cAtenaGetPara1.p_strGyomunaiSHU_CD = string.Empty;



                    // =====================================================================================================================
                    // == ‚UDƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ð•Û‘¶
                    // ==@@@@
                    // ==@@@@<à–¾>@ŠÈˆÕ”ÅE’Êí”ÅA’¼‹ß”ÅE—š—ð”Å‚Ìî•ñ‚ð•Û‘¶‚·‚éB
                    // ==@@@@
                    // =====================================================================================================================
                    // ƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ð•Û‘¶
                    if (m_cABAtenaB is not null)
                    {
                        blnAtenaSelectAll = m_cABAtenaB.m_blnSelectAll;
                        blnAtenaKani = m_cABAtenaB.m_blnSelectCount;
                        m_cABAtenaB.m_blnSelectAll = ABEnumDefine.AtenaGetKB.NenkinAll;
                        m_cABAtenaB.m_blnSelectCount = true;
                    }
                    if (m_cABAtenaRirekiB is not null)
                    {
                        blnRirekiSelectAll = m_cABAtenaRirekiB.m_blnSelectAll;
                        blnRirekiKani = m_cABAtenaRirekiB.m_blnSelectCount;
                        m_cABAtenaRirekiB.m_blnSelectAll = ABEnumDefine.AtenaGetKB.NenkinAll;
                        m_cABAtenaRirekiB.m_blnSelectCount = true;

                    }



                    // =====================================================================================================================
                    // == ‚UDˆ¶–¼î•ñ‚ÌŽæ“¾
                    // ==@@@@
                    // ==@@@@<à–¾>@ˆ¶–¼î•ñ‚ÌŽæ“¾‚ðs‚¤B
                    // ==@@@@
                    // =====================================================================================================================
                    // ŠÈˆÕˆ¶–¼Žæ“¾(“à•”ˆ—)‚Qƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
                    csAtenaEntity = this.GetAtena2(cAtenaGetPara1, intHyojunKB);



                    // =====================================================================================================================
                    // == ‚VDƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ð–ß‚·
                    // ==@@@@
                    // ==@@@@<à–¾>@ŠÈˆÕ”ÅE’Êí”ÅA’¼‹ß”ÅE—š—ð”Å‚Ìî•ñ‚ð–ß‚·B
                    // ==@@@@
                    // =====================================================================================================================
                    // ƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ðŒ³‚É‚à‚Ç‚·
                    if (m_cABAtenaB is not null)
                    {
                        m_cABAtenaB.m_blnSelectAll = blnAtenaSelectAll;
                        m_cABAtenaB.m_blnSelectCount = blnAtenaKani;
                    }
                    if (m_cABAtenaRirekiB is not null)
                    {
                        m_cABAtenaRirekiB.m_blnSelectAll = blnRirekiSelectAll;
                        m_cABAtenaRirekiB.m_blnSelectCount = blnRirekiKani;
                    }



                    // =====================================================================================================================
                    // == ‚WDˆ¶–¼î•ñ‚Ì•ÒW
                    // ==@@@@
                    // ==@@@@<à–¾>@ˆ¶–¼î•ñ‚Ì•ÒW‚ðs‚¤B
                    // ==@@@@@@@@ú@. Žw’è”NŒŽ“ú‚ª‚ ‚éê‡‚Íuˆ¶–¼—š—ðƒ}ƒXƒ^FABATENARIREKIv‚É‚æ‚èŽæ“¾‚·‚é
                    // ==@@@@@@@@úA. Žw’è”NŒŽ“ú‚ª‚È‚¢ê‡‚Íuˆ¶–¼ƒ}ƒXƒ^FABATENAv‚É‚æ‚èŽæ“¾‚·‚é
                    // ==@@@@@@@@úB. ƒoƒbƒ`”Å‚ÌŽw’è‚ª‚ ‚éê‡‚Íƒoƒbƒ`”Å‚ÌƒNƒ‰ƒX‚É‚æ‚èŽæ“¾‚·‚é
                    // ==@@@@
                    // =====================================================================================================================
                    // Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡
                    if (!(cAtenaGetPara1.p_strShiteiYMD == ""))
                    {
                        if (m_blnBatch)
                        {
                            // uˆ¶–¼•ÒWƒoƒbƒ`v‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                            if (intNenkinAtenaGetKB == ABEnumDefine.NenkinAtenaGetKB.Version01)
                            {
                                csAtena1Entity = m_cABBatchAtenaHenshuB.NenkinRirekiHenshu(cAtenaGetPara1, csAtenaEntity);
                            }
                            else
                            {
                                csAtena1Entity = m_cABBatchAtenaHenshuB.NenkinRirekiHenshu2(cAtenaGetPara1, csAtenaEntity);
                            }
                        }

                        // uˆ¶–¼•ÒWv‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                        else if (intNenkinAtenaGetKB == ABEnumDefine.NenkinAtenaGetKB.Version01)
                        {
                            csAtena1Entity = m_cABAtenaHenshuB.NenkinRirekiHenshu(cAtenaGetPara1, csAtenaEntity);
                        }
                        else
                        {
                            csAtena1Entity = m_cABAtenaHenshuB.NenkinRirekiHenshu2(cAtenaGetPara1, csAtenaEntity);
                        }
                    }
                    else if (m_blnBatch)
                    {
                        // ˆ¶–¼•ÒWƒoƒbƒ`ƒNƒ‰ƒX‚Ì”N‹àˆ¶–¼•ÒWƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
                        if (intNenkinAtenaGetKB == ABEnumDefine.NenkinAtenaGetKB.Version01)
                        {
                            csAtena1Entity = m_cABBatchAtenaHenshuB.NenkinAtenaHenshu(cAtenaGetPara1, csAtenaEntity);
                        }
                        else
                        {
                            csAtena1Entity = m_cABBatchAtenaHenshuB.NenkinAtenaHenshu2(cAtenaGetPara1, csAtenaEntity);
                        }
                    }
                    // ˆ¶–¼•ÒWƒNƒ‰ƒX‚Ì”N‹àˆ¶–¼•ÒWƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
                    else if (intNenkinAtenaGetKB == ABEnumDefine.NenkinAtenaGetKB.Version01)
                    {
                        csAtena1Entity = m_cABAtenaHenshuB.NenkinAtenaHenshu(cAtenaGetPara1, csAtenaEntity);
                    }
                    else
                    {
                        csAtena1Entity = m_cABAtenaHenshuB.NenkinAtenaHenshu2(cAtenaGetPara1, csAtenaEntity);
                    }



                    // =====================================================================================================================
                    // == ‚XD‹Æ–±ƒR[ƒh‚Ì‘Þ”ð
                    // ==@@@@
                    // ==@@@@<à–¾>@‹Æ–±ƒR[ƒhE‹Æ–±“àŽí•ÊƒR[ƒh‚ð‘Þ”ð‚·‚éB
                    // ==@@@@
                    // =====================================================================================================================
                    // ‹Æ–±ƒR[ƒhE‹Æ–±“àŽí•ÊƒR[ƒh‚ð•œŒ³‚·‚é
                    cAtenaGetPara1.p_strGyomuCD = cAtenaGetPara1Save.p_strGyomuCD;
                    cAtenaGetPara1.p_strGyomunaiSHU_CD = cAtenaGetPara1Save.p_strGyomunaiSHU_CD;




                    // =====================================================================================================================
                    // == ‚P‚OD˜A—æƒf[ƒ^‚ÌŽæ“¾
                    // ==@@@@
                    // ==@@@@<à–¾>@˜A—æî•ñ‚ðŽæ“¾‚·‚éB
                    // ==@@@@@@@@ú@. ‹Æ–±ƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢ê‡‚ÍA‰½‚à‚µ‚È‚¢
                    // ==@@@@@@@@úA. Žw’è‚µ‚½‹Æ–±ƒR[ƒhE‹Æ–±“àŽí•ÊƒR[ƒh‚ððŒ‚Éu˜A—æƒ}ƒXƒ^FABRENRAKUSAKIv‚©‚çŽæ“¾‚·‚é
                    // ==@@@@@@@@úB. úA.‚Åƒf[ƒ^‚ªŽæ“¾‚µ‚½ê‡A–³ðŒ‚É˜A—æ‚PA˜A—æ‚Q‚ð•Ô‹p‚·‚é
                    // ==@@@@@@@@úC. ”N‹àˆ¶–¼ƒQƒbƒgEŒÂ•ÊƒQƒbƒg‚ÌƒŒƒCƒAƒEƒg‚Ìê‡‚Ì‚Ýu˜A—æ‹Æ–±ƒR[ƒhv‚É’ŠoðŒ‚Ì‹Æ–±ƒR[ƒh‚ðƒZƒbƒg‚·‚é
                    // ==@@@@
                    // =====================================================================================================================
                    // Žw’è”NŒŽ“ú‚ªŽw’è‚µ‚Ä‚ ‚èŠŽ‚ÂŽæ“¾ƒpƒ‰ƒ[ƒ^‚Ì‘—•tæƒf[ƒ^‹æ•ª‚ª"1"‚Ìê‡
                    if (cAtenaGetPara1.p_strShiteiYMD != "" & cAtenaGetPara1.p_strSfskDataKB == "1")
                    {
                        strKikanYMD = cAtenaGetPara1.p_strShiteiYMD.RSubstring(0, 8);
                    }
                    else
                    {
                        strKikanYMD = m_strSystemDateTime;
                    }
                    // ˜A—æ•ÒWˆ—
                    this.RenrakusakiHenshu(cAtenaGetPara1.p_strGyomuCD, cAtenaGetPara1.p_strGyomunaiSHU_CD, csAtena1Entity, csAtenaEntity, intHyojunKB, strKikanYMD);



                    // =====================================================================================================================
                    // == ‚P‚PDƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ð–ß‚·
                    // ==@@@@
                    // ==@@@@<à–¾>@ŠÈˆÕ”ÅE’Êí”Å‚Ìî•ñ‚ð–ß‚·B
                    // ==@@@@
                    // =====================================================================================================================
                    // ƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ðŒ³‚É‚à‚Ç‚·
                    if (m_cABBatchAtenaHenshuB is not null)
                    {
                        m_cABBatchAtenaHenshuB.m_blnSelectAll = m_blnSelectAll;
                    }
                    if (m_cABAtenaHenshuB is not null)
                    {
                        m_cABAtenaHenshuB.m_blnSelectAll = m_blnSelectAll;
                    }
                }

                catch (UFRdbTimeOutException objRdbTimeOutExp)    // UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 215219


                    Input:
                    " + objRdbTimeOutExp.p_strErrorCode + "z" +
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 215322


                    Input:
                    " + objRdbTimeOutExp.Message + "z")
                                    ' UFAppException‚ðƒXƒ[‚·‚é
                                    Throw New UFAppException(objRdbTimeOutExp.Message, objRdbTimeOutExp.p_intErrorCode, objRdbTimeOutExp)

                                Catch
                                    ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[
                                    Throw

                                Finally
                                    ' RDBØ’f
                                    If m_blnBatchRdb = False Then
                                        ' RDBƒAƒNƒZƒXƒƒOo—Í
                                        m_cfLogClass.RdbWrite(m_cfControlData,
                                                                "yƒNƒ‰ƒX–¼:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 215854


                    Input:
                    " + THIS_CLASS_NAME + "z" +
                                                                "yƒƒ\ƒbƒh–¼:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 215941


                    Input:
                    " + THIS_METHOD_NAME + "z" +
                                                                "yŽÀsƒƒ\ƒbƒh–¼:
                     */
                    Disconnect();/* TODO ERROR: Skipped SkippedTokensTrivia
z")
                    m_cfRdbClass.Disconnect()
                End If

            End Try

            ' ƒfƒoƒbƒOƒƒOo—Í
            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)


        Catch objAppExp As UFAppException    ' UFAppException‚ðƒLƒƒƒbƒ`
            ' ƒ[ƒjƒ“ƒOƒƒOo—Í*/
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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 216702


                    Input:
                    " + objAppExp.p_strErrorCode + "z" +
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 216798


                    Input:
                    " + objAppExp.Message + "z")
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

                            Return csAtena1Entity

                        End Function
                    #End Region

                    #Region " ‘•Ûˆ¶–¼—š—ðŽæ“¾(KokuhoAtenaRirekiGet) "
                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     ‘•Ûˆ¶–¼—š—ðŽæ“¾
                        '* 
                        '* \•¶           Public Function KokuhoAtenaRirekiGet(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet
                        '* 
                        '* ‹@”\@@       ‘•Ûˆ¶–¼—š—ðƒf[ƒ^‚ðŽæ“¾‚·‚é
                        '* 
                        '* ˆø”           cAtenaGetPara1    : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
                        '* 
                        '* –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
                        '************************************************************************************************
                        Public Function KokuhoAtenaRirekiGet(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet
                            Const THIS_METHOD_NAME As String = "KokuhoAtenaRirekiGet"
                            '*—š—ð”Ô† 000015 2003/08/21 íœŠJŽn
                            'Dim cABAtenaHenshuB As ABAtenaHenshuBClass          'ˆ¶–¼•ÒWƒNƒ‰ƒX
                            '*—š—ð”Ô† 000015 2003/08/21 íœI—¹
                            Dim csAtena1Entity As DataSet                       'ˆ¶–¼1Entity

                            Try
                                ' ƒfƒoƒbƒOƒƒOo—Í
                                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                                ' RDBƒAƒNƒZƒXƒƒOo—Í
                                'm_cfLogClass.RdbWrite(m_cfControlData, _
                                '                                "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                '                                "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                '                                "yŽÀsƒƒ\ƒbƒh–¼:Connectz")
                                '* —š—ð”Ô† 000023 2004/08/27 íœI—¹
                                '‚q‚c‚aÚ‘±
                                If m_blnBatchRdb = False Then
                                    '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
                                    ' RDBƒAƒNƒZƒXƒƒOo—Í
                                    m_cfLogClass.RdbWrite(m_cfControlData,
                                                                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                                    "yŽÀsƒƒ\ƒbƒh–¼:Connectz")
                                    '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁI—¹
                                    m_cfRdbClass.Connect()
                                End If

                                Try
                                    ' ŠÇ—î•ñŽæ“¾(“à•”ˆ—)ƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
                                    Me.GetKanriJoho()

                                    ' ‘•Ûˆ¶–¼—š—ðŽæ“¾(“à•”ˆ—)ƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
                                    csAtena1Entity = Me.GetKokuhoAtenaRireki(cAtenaGetPara1, ABEnumDefine.HyojunKB.KB_Tsujo)

                                Catch objRdbTimeOutExp As UFRdbTimeOutException    ' UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
                                    ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                                    m_cfLogClass.WarningWrite(m_cfControlData,
                                                            "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                            "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                            "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objRdbTimeOutExp.p_strErrorCode + "z" +
                                                            "yƒ[ƒjƒ“ƒO“à—e:" + objRdbTimeOutExp.Message + "z")
                                    ' UFAppException‚ðƒXƒ[‚·‚é
                                    Throw New UFAppException(objRdbTimeOutExp.Message, objRdbTimeOutExp.p_intErrorCode, objRdbTimeOutExp)

                                Catch
                                    ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[
                                    Throw

                                Finally
                                    '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                                    ' RDBƒAƒNƒZƒXƒƒOo—Í
                                    'm_cfLogClass.RdbWrite(m_cfControlData, _
                                    '                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                    '                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                    '                        "yŽÀsƒƒ\ƒbƒh–¼:Disconnectz")
                                    '* —š—ð”Ô† 000023 2004/08/27 íœI—¹
                                    ' RDBØ’f
                                    If m_blnBatchRdb = False Then
                                        '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
                                        ' RDBƒAƒNƒZƒXƒƒOo—Í
                                        m_cfLogClass.RdbWrite(m_cfControlData,
                                                                "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                                "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                                "yŽÀsƒƒ\ƒbƒh–¼:Disconnectz")
                                        '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁI—¹
                                        m_cfRdbClass.Disconnect()
                                    End If

                                End Try

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

                            Return csAtena1Entity

                        End Function
                    #End Region

                    #Region " ŠÈˆÕˆ¶–¼Žæ“¾‚Q(GetAtena2) "
                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     ŠÈˆÕˆ¶–¼Žæ“¾‚Qi“à•”ˆ—j
                        '* 
                        '* \•¶           Private Function GetAtena2(ByVal cAtenaGetPara1 As ABAtenaGetPara1) As DataSet
                        '* 
                        '* ‹@”\@@    @@ˆ¶–¼‚ðŽæ“¾‚·‚é
                        '* 
                        '* ˆø”           cAtenaGetPara1   : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
                        '* 
                        '* –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
                        '************************************************************************************************
                        Private Function GetAtena2(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass, ByVal intHyojunKB As ABEnumDefine.HyojunKB) As DataSet
                            Const THIS_METHOD_NAME As String = "GetAtena2"
                            Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì
                            Dim cSearchKey As ABAtenaSearchKey                  'ˆ¶–¼ŒŸõƒL[
                            '* corresponds to VS2008 Start 2010/04/16 000044
                            'Dim csDataTable As DataTable
                            '* corresponds to VS2008 End 2010/04/16 000044
                            Dim csDataSet As DataSet
                            '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                            'Dim cABAtenaRirekiB As ABAtenaRirekiBClass          'ˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
                            'Dim cABAtenaB As ABAtenaBClass                      'ˆ¶–¼ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
                            '* —š—ð”Ô† 000023 2004/08/27 íœI—¹
                            '*—š—ð”Ô† 000015 2003/08/21 íœŠJŽn
                            'Dim cABAtenaHenshuB As ABAtenaHenshuBClass          'ˆ¶–¼•ÒWƒNƒ‰ƒX
                            '*—š—ð”Ô† 000015 2003/08/21 íœI—¹
                            Dim intHyojiKensu As Integer                        'Å‘åŽæ“¾Œ”
                            '* corresponds to VS2008 Start 2010/04/16 000044
                            'Dim intGetCount As Integer                          'Žæ“¾Œ”
                            '* corresponds to VS2008 End 2010/04/16 000044
                            '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                            'Dim cUSSCityInfoClass As New USSCityInfoClass()     'Žs’¬‘ºî•ñŠÇ—ƒNƒ‰ƒX
                            '* —š—ð”Ô† 000023 2004/08/27 íœI—¹
                            Dim strShichosonCD As String                        'Žs’¬‘ºƒR[ƒh
                            '* —š—ð”Ô† 000039 2008/02/17 ’Ç‰ÁŠJŽn
                            Dim intIdx As Integer
                            Dim cABMojiHenshuB As ABMojiretsuHenshuBClass       '•¶Žš•ÒW‚aƒNƒ‰ƒX
                            '* —š—ð”Ô† 000039 2008/02/17 ’Ç‰ÁI—¹

                            Try
                                ' ƒfƒoƒbƒOƒƒOo—Í
                                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)


                                '=====================================================================================================================
                                '== ‚PDˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
                                '==@@@@
                                '==@@@@<à–¾>@ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX‚ÉŽw’è‚³‚ê‚½“à—e‚ðƒ`ƒFƒbƒN‚·‚éB
                                '==@@@@
                                '=====================================================================================================================
                                ' ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
                                Me.CheckColumnValue(cAtenaGetPara1, intHyojunKB)


                                '=====================================================================================================================
                                '== ‚QD‹Æ–±ƒR[ƒh‘¶Ýƒ`ƒFƒbƒN
                                '==@@@@
                                '==@@@@<à–¾>@‹Æ–±ƒR[ƒh‚ªŒŸõƒL[‚É‚µ‚Ä‚³‚ê‚Ä‚¢‚½ê‡‚ÍAƒGƒ‰[‚ð•Ô‚·B
                                '==@@@@
                                '=====================================================================================================================
                                ' ‹Æ–±ƒR[ƒh‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡‚ÍAƒGƒ‰[
                                If Not (cAtenaGetPara1.p_strGyomuCD = String.Empty) Then
                                    ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002002)
                                    Throw New UFAppException(objErrorStruct.m_strErrorMessage + "‹Æ–±ƒR[ƒh", objErrorStruct.m_strErrorCode)
                                End If

                                '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                                ' ˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                                'cABAtenaRirekiB = New ABAtenaRirekiBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)

                                ' ˆ¶–¼ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                                'cABAtenaB = New ABAtenaBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                '* —š—ð”Ô† 000023 2004/08/27 íœI—¹


                                '*—š—ð”Ô† 000015 2003/08/21 C³ŠJŽn
                                '' ˆ¶–¼•ÒWƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                                'cABAtenaHenshuB = New ABAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                '*—š—ð”Ô† 000015 2003/08/21 C³I—¹

                                ' ’¼‹ßŽs’¬‘ºî•ñŽæ“¾‚ðŽæ“¾‚·‚éB
                                '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                                'cUSSCityInfoClass.GetCityInfo(m_cfControlData)
                                '* —š—ð”Ô† 000023 2004/08/27 íœI—¹


                                '=====================================================================================================================
                                '== ‚RDŽs’¬‘ºƒR[ƒh‚ÌŽæ“¾
                                '==@@@@
                                '==@@@@<à–¾>@’¼‹ß‚ÌŽs’¬‘ºƒR[ƒh‚ðŽæ“¾‚·‚éB
                                '==@@@@
                                '=====================================================================================================================
                                ' Žs’¬‘ºƒR[ƒh‚Ì“à—e‚ðÝ’è‚·‚éB
                                If (cAtenaGetPara1.p_strShichosonCD = String.Empty) Then
                                    strShichosonCD = m_cUSSCityInfoClass.p_strShichosonCD(0)
                                Else
                                    strShichosonCD = cAtenaGetPara1.p_strShichosonCD
                                End If



                                '*—š—ð”Ô† 000031 2007/07/31 ’Ç‰ÁŠJŽn
                                '=====================================================================================================================
                                '== ‚SD“¯ˆêl‘ã•\ŽÒŽæ“¾ˆ—
                                '==@@@@
                                '==@@@@<à–¾>@Z–¯ƒR[ƒhEZ“oŠO—DæE“¯ˆêl”»’èFG—LŒø‚ÌŒŸõðŒ‚Ìê‡‚Ì‚ÝA“¯ˆêl‘ã•\ŽÒŽæ“¾‚ðs‚¤B
                                '==@@@@@@@@ŠÇ—î•ñ‚É‚æ‚èAƒ†[ƒU‚²‚Æ‚ÌŽæ“¾”»’è—L‚èB
                                '==@@@@
                                '=====================================================================================================================
                                '“¯ˆêl‘ã•\ŽÒZ–¯ƒR[ƒh‚ðŒŸõƒpƒ‰ƒ[ƒ^‚Éã‘‚«‚·‚é
                                GetDaihyoJuminCD(cAtenaGetPara1)
                                '*—š—ð”Ô† 000031 2007/07/31 ’Ç‰ÁI—¹



                                '=====================================================================================================================
                                '== ‚TD–{lˆ¶–¼Žæ“¾ŒŸõƒL[‚ÌÝ’è
                                '==@@@@
                                '==@@@@<à–¾>@–{l‚Ìˆ¶–¼î•ñ‚ðŽæ“¾‚·‚é‚½‚ß‚ÌŒŸõƒL[‚ðŽw’è‚³‚ê‚½ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX‚æ‚èÝ’è‚·‚éB
                                '==@@@@@@@@Å‘åŽæ“¾Œ”‚àŽæ“¾‚·‚éB
                                '==@@@@
                                '=====================================================================================================================
                                ' ˆ¶–¼ŒŸõƒL[‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                                cSearchKey = New ABAtenaSearchKey

                                ' ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^‚©‚çˆ¶–¼ŒŸõƒL[‚ÉƒZƒbƒg‚·‚é
                                cSearchKey.p_strJuminCD = cAtenaGetPara1.p_strJuminCD
                                cSearchKey.p_strStaiCD = cAtenaGetPara1.p_strStaiCD
                                cSearchKey.p_strSearchKanaSeiMei = cAtenaGetPara1.p_strKanaSeiMei
                                cSearchKey.p_strSearchKanaSei = cAtenaGetPara1.p_strKanaSei
                                cSearchKey.p_strSearchKanaMei = cAtenaGetPara1.p_strKanaMei
                                cSearchKey.p_strSearchKanjiMeisho = cAtenaGetPara1.p_strKanjiShimei
                                cSearchKey.p_strUmareYMD = cAtenaGetPara1.p_strUmareYMD
                                cSearchKey.p_strSeibetsuCD = cAtenaGetPara1.p_strSeibetsu
                                cSearchKey.p_strDataKB = cAtenaGetPara1.p_strDataKB
                                cSearchKey.p_strJuminShubetu1 = cAtenaGetPara1.p_strJuminSHU1
                                cSearchKey.p_strJuminShubetu2 = cAtenaGetPara1.p_strJuminSHU2
                                cSearchKey.p_strShichosonCD = strShichosonCD
                                '*—š—ð”Ô† 000032 2007/09/04 ’Ç‰ÁŠJŽn
                                'ŒŸõ—pƒJƒi©–¼EŒŸõ—pƒJƒi©EŒŸõ—pƒJƒi–¼‚Ì•ÒW
                                cSearchKey = HenshuSearchKana(cSearchKey, cAtenaGetPara1.p_blnGaikokuHommyoYusen)
                                '*—š—ð”Ô† 000032 2007/09/04 ’Ç‰ÁI—¹

                                ' ZŠ`”Ô’nƒR[ƒh3‚ÌƒZƒbƒg
                                If Not (cAtenaGetPara1.p_strJukiJutogaiKB = "1") Then
                                    ' Z“oŠO—Dæ‚Ìê‡
                                    cSearchKey.p_strJutogaiYusenKB = "1"
                                    cSearchKey.p_strJushoCD = cAtenaGetPara1.p_strJushoCD
                                    cSearchKey.p_strGyoseikuCD = cAtenaGetPara1.p_strGyoseikuCD.RPadLeft(9)
                                    cSearchKey.p_strChikuCD1 = cAtenaGetPara1.p_strChikuCD1.RPadLeft(8)
                                    cSearchKey.p_strChikuCD2 = cAtenaGetPara1.p_strChikuCD2.RPadLeft(8)
                                    cSearchKey.p_strChikuCD3 = cAtenaGetPara1.p_strChikuCD3.RPadLeft(8)
                                    cSearchKey.p_strBanchiCD1 = cAtenaGetPara1.p_strBanchiCD1.RPadLeft(5)
                                    cSearchKey.p_strBanchiCD2 = cAtenaGetPara1.p_strBanchiCD2.RPadLeft(5)
                                    cSearchKey.p_strBanchiCD3 = cAtenaGetPara1.p_strBanchiCD3.RPadLeft(5)
                                Else
                                    ' ZŠî—Dæ‚Ìê‡
                                    cSearchKey.p_strJuminYuseniKB = "1"
                                    '*—š—ð”Ô† 000018 2003/10/30 C³ŠJŽn
                                    'cSearchKey.p_strJukiJushoCD = cAtenaGetPara1.p_strJushoCD.PadLeft(11)
                                    cSearchKey.p_strJukiJushoCD = cAtenaGetPara1.p_strJushoCD.Trim.RPadLeft(8)
                                    '*—š—ð”Ô† 000018 2003/10/30 C³I—¹
                                    cSearchKey.p_strJukiGyoseikuCD = cAtenaGetPara1.p_strGyoseikuCD.RPadLeft(9)
                                    cSearchKey.p_strJukiChikuCD1 = cAtenaGetPara1.p_strChikuCD1.RPadLeft(8)
                                    cSearchKey.p_strJukiChikuCD2 = cAtenaGetPara1.p_strChikuCD2.RPadLeft(8)
                                    cSearchKey.p_strJukiChikuCD3 = cAtenaGetPara1.p_strChikuCD3.RPadLeft(8)
                                    cSearchKey.p_strJukiBanchiCD1 = cAtenaGetPara1.p_strBanchiCD1.RPadLeft(5)
                                    cSearchKey.p_strJukiBanchiCD2 = cAtenaGetPara1.p_strBanchiCD2.RPadLeft(5)
                                    cSearchKey.p_strJukiBanchiCD3 = cAtenaGetPara1.p_strBanchiCD3.RPadLeft(5)
                                End If
                                '*—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁŠJŽn
                                cSearchKey.p_strMyNumber = cAtenaGetPara1.p_strMyNumber.RPadRight(13)
                                cSearchKey.p_strMyNumberKojinHojinKB = cAtenaGetPara1.p_strMyNumberKojinHojinKB
                                cSearchKey.p_strMyNumberChokkinSearchKB = cAtenaGetPara1.p_strMyNumberChokkinSearchKB
                                '*—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁI—¹
                                ' Å‘åŽæ“¾Œ”‚ðƒZƒbƒg‚·‚é
                                If cAtenaGetPara1.p_intHyojiKensu = 0 Then
                                    intHyojiKensu = 100
                                Else
                                    intHyojiKensu = cAtenaGetPara1.p_intHyojiKensu
                                End If
                                '*—š—ð”Ô† 000047 2011/11/07 ’Ç‰ÁŠJŽn
                                m_cABAtenaB.p_strJukihoKaiseiKB = cAtenaGetPara1.p_strJukiHokaiseiKB
                                m_cABAtenaRirekiB.p_strJukihoKaiseiKB = cAtenaGetPara1.p_strJukiHokaiseiKB
                                '*—š—ð”Ô† 000047 2011/11/07 ’Ç‰ÁI—¹
                                '*—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁŠJŽn
                                m_cABAtenaB.p_strMyNumberKB = cAtenaGetPara1.p_strMyNumberKB
                                m_cABAtenaRirekiB.p_strMyNumberKB = cAtenaGetPara1.p_strMyNumberKB
                                '*—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁI—¹

                                '*—š—ð”Ô† 000050 2020/01/31 ’Ç‰ÁŠJŽn
                                ' —š—ðŒŸõƒtƒ‰ƒO
                                cSearchKey.p_blnIsRirekiSearch = cAtenaGetPara1.p_blnIsRirekiSearch
                                '*—š—ð”Ô† 000050 2020/01/31 ’Ç‰ÁI—¹
                                cSearchKey.p_strKyuuji = cAtenaGetPara1.p_strKyuuji
                                cSearchKey.p_strKanaKyuuji = cAtenaGetPara1.p_strKanaKyuuji
                                cSearchKey.p_strKatakanaHeikimei = cAtenaGetPara1.p_strKatakanaHeikimei
                                cSearchKey.p_strJusho = cAtenaGetPara1.p_strJusho
                                cSearchKey.p_strKatagaki = cAtenaGetPara1.p_strKatagaki
                                cSearchKey.p_strRenrakusaki = cAtenaGetPara1.p_strRenrakusaki

                                m_cABAtenaB.m_intHyojunKB = intHyojunKB
                                m_cABAtenaRirekiB.m_intHyojunKB = intHyojunKB

                                '=====================================================================================================================
                                '== ‚UD–{lˆ¶–¼ƒf[ƒ^‚ÌŽæ“¾
                                '==@@@@
                                '==@@@@<à–¾>@–{l‚Ìˆ¶–¼î•ñ‚ðŽæ“¾‚·‚éB
                                '==@@@@@@@@ú@. Žw’è”NŒŽ“ú‚ª‚ ‚éê‡‚Íuˆ¶–¼—š—ðƒ}ƒXƒ^FABATENARIREKIv‚É‚æ‚èŽæ“¾‚·‚é
                                '==@@@@@@@@úA. Žw’è”NŒŽ“ú‚ª‚È‚¢ê‡‚Íuˆ¶–¼ƒ}ƒXƒ^FABATENAv‚É‚æ‚èŽæ“¾‚·‚é
                                '==@@@@
                                '=====================================================================================================================
                                If Not (cAtenaGetPara1.p_strShiteiYMD = String.Empty) Then
                                    ' Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚éê‡
                                    'uˆ¶–¼—š—ðƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
                                    csDataSet = m_cABAtenaRirekiB.GetAtenaRBHoshu(cAtenaGetPara1.p_intHyojiKensu,
                                                                                cSearchKey,
                                                                                cAtenaGetPara1.p_strShiteiYMD,
                                                                                cAtenaGetPara1.p_blnSakujoFG)

                                Else
                                    ' Žw’è”NŒŽ“ú‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢ê‡
                                    'uˆ¶–¼ƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
                                    csDataSet = m_cABAtenaB.GetAtenaBHoshu(cAtenaGetPara1.p_intHyojiKensu,
                                                                         cSearchKey, cAtenaGetPara1.p_blnSakujoFG)
                                End If

                                '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹
                                ' ƒfƒoƒbƒOƒƒOo—Í
                                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            Catch objRdbTimeOutExp As UFRdbTimeOutException    ' UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
                                ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                                m_cfLogClass.WarningWrite(m_cfControlData,
                                                            "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                            "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                            "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objRdbTimeOutExp.p_strErrorCode + "z" +
                                                            "yƒ[ƒjƒ“ƒO“à—e:" + objRdbTimeOutExp.Message + "z")
                                ' UFAppException‚ðƒXƒ[‚·‚é
                                Throw New UFAppException(objRdbTimeOutExp.Message, objRdbTimeOutExp.p_intErrorCode, objRdbTimeOutExp)

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

                                '*—š—ð”Ô† 000031 2007/07/31 ’Ç‰ÁŠJŽn
                            Finally
                                '=====================================================================================================================
                                '== ‚Q‚SD•Ô‹p‚·‚éZ–¯ƒR[ƒh‚ðŽw’è‚³‚ê‚½Z–¯ƒR[ƒh‚Åã‘‚«‚·‚é
                                '==@@@@
                                '==@@@@<à–¾>@“¯ˆêl‘ã•\ŽÒŽæ“¾‚³‚ê‚½ê‡‚ÍAŽw’è‚³‚ê‚½Z–¯ƒR[ƒh‚ð•Ô‚·
                                '==@@@@
                                '=====================================================================================================================
                                '‘Þ”ð‚µ‚½Z–¯ƒR[ƒh‚ª‘¶Ý‚·‚éê‡‚ÍAã‘‚«‚·‚é
                                SetJuminCD(csDataSet)
                                '*—š—ð”Ô† 000031 2007/07/31 ’Ç‰ÁI—¹

                                '*—š—ð”Ô† 000039 2008/02/17 ’Ç‰ÁŠJŽn
                                '=====================================================================================================================
                                '== ‚WDŠO‘l‚ÌŠ¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                                '==@@@@
                                '==@@@@<à–¾>@ŠO‘lƒf[ƒ^:Š¿ŽšŽ–¼‚PA‚QA‚Ü‚½‚ÍŠ¿Žš¢‘ÑŽå–¼(“]oŠm’èA“]o—\’èA“]“ü‘OŠÜ‚Þ)‚ÌŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤
                                '==@@@@@@@@
                                '=====================================================================================================================
                                '*—š—ð”Ô† 000043 2009/04/08 C³ŠJŽn
                                If Not (csDataSet Is Nothing) Then
                                    If (cAtenaGetPara1.p_strFrnMeishoHenshuKB <> "1") Then
                                        'Š¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤

                                        cABMojiHenshuB = New ABMojiretsuHenshuBClass(m_cfControlData, m_cfConfigDataClass)

                                        ' ‘SŽæ“¾ƒf[ƒ^•ªs‚¤
                                        '* ˆ¶–¼ƒ}ƒXƒ^Aˆ¶–¼—š—ðƒ}ƒXƒ^‚Æ‚à‚É“¯‚¶ƒŒƒCƒAƒEƒg‚Ì‚½‚ßAƒe[ƒuƒ‹Žw’èF"0"A€–Ú–¼‚Íˆ¶–¼Entity‚ðŽg—pB
                                        For intIdx = 0 To csDataSet.Tables(0).Rows.Count - 1
                                            ' Š¿Žš–¼Ì‚P
                                            csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.KANJIMEISHO1) = cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.ATENADATAKB)),
                                                                                                                                             CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.ATENADATASHU)),
                                                                                                                                             CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.KANJIMEISHO1)))
                                            ' Š¿Žš–¼Ì‚Q
                                            csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.KANJIMEISHO2) = cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.ATENADATAKB)),
                                                                                                                                             CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.ATENADATASHU)),
                                                                                                                                             CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.KANJIMEISHO2)))
                                            ' ¢‘ÑŽå–¼
                                            csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.STAINUSMEI) = cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.STAINUSMEI)))
                                            ' ‘æ‚Q¢‘ÑŽå–¼
                                            csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.DAI2STAINUSMEI) = cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.DAI2STAINUSMEI)))
                                            ' Š¿Žš–@l‘ã•\ŽÒ–¼
                                            csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.KANJIHJNDAIHYOSHSHIMEI) = cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.ATENADATAKB)),
                                                                                                                                                       CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.ATENADATASHU)),
                                                                                                                                                       CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.KANJIHJNDAIHYOSHSHIMEI)))
                                            ' “]“ü‘O¢‘ÑŽå–¼
                                            csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.TENUMAEJ_STAINUSMEI) = cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.TENUMAEJ_STAINUSMEI)))
                                            ' “]o—\’è¢‘ÑŽå–¼
                                            csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.TENSHUTSUYOTEISTAINUSMEI) = cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.TENSHUTSUYOTEISTAINUSMEI)))
                                            ' “]oŠm’è¢‘ÑŽå–¼
                                            csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.TENSHUTSUKKTISTAINUSMEI) = cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.TENSHUTSUKKTISTAINUSMEI)))
                                        Next
                                    Else
                                        ' Š¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                                    End If
                                End If

                                'If (cAtenaGetPara1.p_strFrnMeishoHenshuKB <> "1") Then
                                '    'Š¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚¤

                                '    cABMojiHenshuB = New ABMojiretsuHenshuBClass(m_cfControlData, m_cfConfigDataClass)

                                '    ' ‘SŽæ“¾ƒf[ƒ^•ªs‚¤
                                '    '* ˆ¶–¼ƒ}ƒXƒ^Aˆ¶–¼—š—ðƒ}ƒXƒ^‚Æ‚à‚É“¯‚¶ƒŒƒCƒAƒEƒg‚Ì‚½‚ßAƒe[ƒuƒ‹Žw’èF"0"A€–Ú–¼‚Íˆ¶–¼Entity‚ðŽg—pB
                                '    For intIdx = 0 To csDataSet.Tables(0).Rows.Count - 1
                                '        ' Š¿Žš–¼Ì‚P
                                '        csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.KANJIMEISHO1) = cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.ATENADATAKB)), _
                                '                                                                                                         CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.ATENADATASHU)), _
                                '                                                                                                         CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.KANJIMEISHO1)))
                                '        ' Š¿Žš–¼Ì‚Q
                                '        csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.KANJIMEISHO2) = cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.ATENADATAKB)), _
                                '                                                                                                         CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.ATENADATASHU)), _
                                '                                                                                                         CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.KANJIMEISHO2)))
                                '        ' ¢‘ÑŽå–¼
                                '        csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.STAINUSMEI) = cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.STAINUSMEI)))
                                '        ' ‘æ‚Q¢‘ÑŽå–¼
                                '        csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.DAI2STAINUSMEI) = cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.DAI2STAINUSMEI)))
                                '        ' Š¿Žš–@l‘ã•\ŽÒ–¼
                                '        csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.KANJIHJNDAIHYOSHSHIMEI) = cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.ATENADATAKB)), _
                                '                                                                                                                   CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.ATENADATASHU)), _
                                '                                                                                                                   CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.KANJIHJNDAIHYOSHSHIMEI)))
                                '        ' “]“ü‘O¢‘ÑŽå–¼
                                '        csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.TENUMAEJ_STAINUSMEI) = cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.TENUMAEJ_STAINUSMEI)))
                                '        ' “]o—\’è¢‘ÑŽå–¼
                                '        csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.TENSHUTSUYOTEISTAINUSMEI) = cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.TENSHUTSUYOTEISTAINUSMEI)))
                                '        ' “]oŠm’è¢‘ÑŽå–¼
                                '        csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.TENSHUTSUKKTISTAINUSMEI) = cABMojiHenshuB.EditKanryakuMeisho(CStr(csDataSet.Tables(0).Rows(intIdx)(ABAtenaEntity.TENSHUTSUKKTISTAINUSMEI)))
                                '    Next
                                'Else
                                '    ' Š¿ŽšŽ–¼‚ÉŠÜ‚Ü‚ê‚éŠ‡ŒÊ‚ÅŠ‡‚ç‚ê‚½•¶Žš—ñ‚Ìœ‹Ž‚ðs‚í‚È‚¢
                                'End If
                                ''*—š—ð”Ô† 000039 2008/02/17 ’Ç‰ÁI—¹
                                '*—š—ð”Ô† 000043 2009/04/08 C³I—¹

                            End Try

                            Return csDataSet

                        End Function
                    #End Region

                    #Region " ‘•Ûˆ¶–¼—š—ðŽæ“¾(GetKokuhoAtenaRireki) "
                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     ‘•Ûˆ¶–¼—š—ðŽæ“¾i“à•”ˆ—j
                        '* 
                        '* \•¶           Private Function GetKokuhoAtenaRireki(ByVal cAtenaGetPara1 As ABAtenaGetPara1) As DataSet
                        '* 
                        '* ‹@”\@@    @@Žæ“¾ƒpƒ‰ƒ[ƒ^‚æ‚èˆ¶–¼—š—ðƒf[ƒ^‚ð•Ô‚·B
                        '* 
                        '* ˆø”           cAtenaGetPara1   : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
                        '* 
                        '* –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
                        '************************************************************************************************
                        Private Function GetKokuhoAtenaRireki(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass, ByVal intHyojunKB As ABEnumDefine.HyojunKB) As DataSet
                            Const THIS_METHOD_NAME As String = "GetKokuhoAtenaRireki"
                            '* corresponds to VS2008 Start 2010/04/16 000044
                            'Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì
                            '* corresponds to VS2008 End 2010/04/16 000044
                            Dim cSearchKey As ABAtenaSearchKey                  'ˆ¶–¼ŒŸõƒL[
                            Dim csDataSet As DataSet
                            '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                            'Dim cABAtenaRirekiB As ABAtenaRirekiBClass          'ˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
                            'Dim cABAtenaB As ABAtenaBClass                      'ˆ¶–¼ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX
                            '* —š—ð”Ô† 000023 2004/08/27 íœI—¹
                            '*—š—ð”Ô† 000015 2003/08/21 íœŠJŽn
                            'Dim cABAtenaHenshuB As ABAtenaHenshuBClass          'ˆ¶–¼•ÒWƒNƒ‰ƒX
                            '*—š—ð”Ô† 000015 2003/08/21 íœI—¹
                            Dim csAtena1Entity As DataSet                       'ˆ¶–¼1Entity
                            '* corresponds to VS2008 Start 2010/04/16 000044
                            'Dim strShiteiYMD As String                          ' Žw’è“ú
                            '* corresponds to VS2008 End 2010/04/16 000044

                            Try
                                ' ƒfƒoƒbƒOƒƒOo—Í
                                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                                ' ˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                                'cABAtenaRirekiB = New ABAtenaRirekiBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                '
                                ' ˆ¶–¼ƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                                'cABAtenaB = New ABAtenaBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                '* —š—ð”Ô† 000023 2004/08/27 íœI—¹

                                '*—š—ð”Ô† 000015 2003/08/21 C³ŠJŽn
                                '' ˆ¶–¼•ÒWƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                                'cABAtenaHenshuB = New ABAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)

                                If (m_blnBatch) Then
                                    If (m_cABBatchAtenaHenshuB Is Nothing) Then
                                        'ˆ¶–¼•ÒWƒoƒbƒ`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                                        '* —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                        'm_cABBatchAtenaHenshuB = New ABBatchAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                        m_cABBatchAtenaHenshuB = New ABBatchAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass, m_blnSelectAll)
                                        '* —š—ð”Ô† 000024 2005/01/25 XVI—¹
                                    End If
                                    m_cABBatchAtenaHenshuB.m_intHyojunKB = intHyojunKB
                                Else
                                    If (m_cABAtenaHenshuB Is Nothing) Then
                                        'ˆ¶–¼•ÒWƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                                        '* —š—ð”Ô† 000024 2005/01/25 XVŠJŽni‹{‘òj
                                        'm_cABAtenaHenshuB = New ABAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                        m_cABAtenaHenshuB = New ABAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass, m_blnSelectAll)
                                        '* —š—ð”Ô† 000024 2005/01/25 XVI—¹
                                    End If
                                    m_cABAtenaHenshuB.m_intHyojunKB = intHyojunKB
                                End If
                                '*—š—ð”Ô† 000015 2003/08/21 C³I—¹

                                ' ‡@ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
                                Me.CheckColumnValue(cAtenaGetPara1, intHyojunKB)

                                ' ˆ¶–¼ŒŸõƒL[‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                                cSearchKey = New ABAtenaSearchKey

                                ' ‡Bˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^‚©‚çˆ¶–¼ŒŸõƒL[‚ÉƒZƒbƒg‚·‚é
                                cSearchKey.p_strJuminCD = cAtenaGetPara1.p_strJuminCD

                                '*—š—ð”Ô† 000016 2003/09/08 C³ŠJŽn
                                ''uˆ¶–¼ƒ}ƒXƒ^’Šovƒƒ]ƒbƒg‚ðŽÀs‚·‚é
                                'csDataSet = cABAtenaB.GetAtenaBHoshu(cAtenaGetPara1.p_intHyojiKensu, _
                                '                                     cSearchKey, cAtenaGetPara1.p_blnSakujoFG)

                                '' Žæ“¾Œ”‚ª‚PŒ‚Å‚È‚¢ê‡AƒGƒ‰[
                                'If Not (csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count = 1) Then
                                '    'ƒGƒ‰[’è‹`‚ðŽæ“¾(ŒŸõƒL[‚ÌŒë‚è‚Å‚·BFZ–¯ƒR[ƒh)
                                '    m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                '    objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                '    Throw New UFAppException(objErrorStruct.m_strErrorMessage + "Z–¯ƒR[ƒh", objErrorStruct.m_strErrorCode)
                                'End If

                                '' ¢‘ÑƒR[ƒh‚ªNullê‡AƒGƒ‰[
                                'If (CType(csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows(0)(ABAtenaEntity.STAICD), String).Trim = String.Empty) Then
                                '    'ƒGƒ‰[’è‹`‚ðŽæ“¾(ŒŸõƒL[‚ÌŒë‚è‚Å‚·BFZ–¯ƒR[ƒh)
                                '    m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                '    objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                '    Throw New UFAppException(objErrorStruct.m_strErrorMessage + "Z–¯ƒR[ƒh", objErrorStruct.m_strErrorCode)
                                'End If

                                '' ˆ¶–¼ŒŸõƒL[‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                                'cSearchKey = New ABAtenaSearchKey()

                                '' ‡C	ABAtenaSearchKey‚É¢‘ÑƒR[ƒh‚ðƒZƒbƒg
                                'cSearchKey.p_strStaiCD = CType(csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows(0)(ABAtenaEntity.STAICD), String)

                                'If (CType(csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows(0)(ABAtenaEntity.JUMINJUTOGAIKB), String) = "1") Then
                                '    ' ZŠîEZ“oŠO‹æ•ª‚ªh1h‚ÌŽžAh1h‚ðZ–¯—Dæ‹æ•ª‚ÉƒZƒbƒg
                                '    cSearchKey.p_strJuminYuseniKB = "1"
                                'Else
                                '    ' ZŠîEZ“oŠO‹æ•ª‚ª<>h1h‚ÌŽžAh1h‚ðZ“oŠO—Dæ‹æ•ª‚ÉƒZƒbƒg
                                '    cSearchKey.p_strJutogaiYusenKB = "1"
                                'End If

                                ' ZŠîEZ“oŠO‹æ•ª‚ª<>h1h‚ÌŽžAh1h‚ðZ“oŠO—Dæ‹æ•ª‚ÉƒZƒbƒg
                                If (cAtenaGetPara1.p_strJukiJutogaiKB <> "1") Then
                                    cSearchKey.p_strJutogaiYusenKB = "1"
                                Else
                                    cSearchKey.p_strJuminYuseniKB = "1"
                                End If
                                '*—š—ð”Ô† 000016 2003/09/08 C³I—¹
                                '*—š—ð”Ô† 000047 2011/11/07 ’Ç‰ÁŠJŽn
                                m_cABAtenaRirekiB.p_strJukihoKaiseiKB = cAtenaGetPara1.p_strJukiHokaiseiKB
                                '*—š—ð”Ô† 000047 2011/11/07 ’Ç‰ÁI—¹
                                '*—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁŠJŽn
                                m_cABAtenaRirekiB.p_strMyNumberKB = cAtenaGetPara1.p_strMyNumberKB
                                '*—š—ð”Ô† 000048 2014/04/28 ’Ç‰ÁI—¹
                                m_cABAtenaRirekiB.m_intHyojunKB = intHyojunKB

                                ' ‡D	ˆ¶–¼—š—ðƒ}ƒXƒ^‚c‚`vƒNƒ‰ƒX‚Ìuˆ¶–¼—š—ðƒ}ƒXƒ^’Šovƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                                csDataSet = m_cABAtenaRirekiB.GetAtenaRBHoshu(cAtenaGetPara1.p_intHyojiKensu,
                                                                            cSearchKey, cAtenaGetPara1.p_strShiteiYMD)

                                '*—š—ð”Ô† 000015 2003/08/21 C³ŠJŽn
                                '' uˆ¶–¼•ÒWvƒNƒ‰ƒX‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
                                'csAtena1Entity = cABAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet)

                                If (m_blnBatch) Then
                                    ' uˆ¶–¼•ÒWvƒNƒ‰ƒX‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
                                    csAtena1Entity = m_cABBatchAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet)
                                Else
                                    ' uˆ¶–¼•ÒWvƒNƒ‰ƒX‚Ìu—š—ð•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
                                    csAtena1Entity = m_cABAtenaHenshuB.RirekiHenshu(cAtenaGetPara1, csDataSet)
                                End If
                                '*—š—ð”Ô† 000015 2003/08/21 C³I—¹

                                ' ƒfƒoƒbƒOƒƒOo—Í
                                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)


                            Catch objRdbTimeOutExp As UFRdbTimeOutException    ' UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
                                ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                                m_cfLogClass.WarningWrite(m_cfControlData,
                                                            "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                            "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                            "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objRdbTimeOutExp.p_strErrorCode + "z" +
                                                            "yƒ[ƒjƒ“ƒO“à—e:" + objRdbTimeOutExp.Message + "z")
                                ' UFAppException‚ðƒXƒ[‚·‚é
                                Throw New UFAppException(objRdbTimeOutExp.Message, objRdbTimeOutExp.p_intErrorCode, objRdbTimeOutExp)

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

                            Return csAtena1Entity

                        End Function
                    #End Region

                    #Region " ŠÇ—î•ñŽæ“¾(GetKanriJoho) "
                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     ŠÇ—î•ñŽæ“¾i“à•”ˆ—j
                        '* 
                        '* \•¶           Private Function GetKanriJoho()
                        '* 
                        '* ‹@”\@@    @@ŠÇ—î•ñ‚ðŽæ“¾‚·‚é
                        '* 
                        '* ˆø”           ‚È‚µ
                        '* 
                        '* –ß‚è’l         ‚È‚µ
                        '************************************************************************************************
                        '* —š—ð”Ô† 000015 2003/08/21 C³ŠJŽn
                        'Private Sub GetKanriJoho()
                        <SecuritySafeCritical>
                        Protected Overridable Sub GetKanriJoho()
                            '* —š—ð”Ô† 000015 2003/08/21 C³I—¹
                            Const THIS_METHOD_NAME As String = "GetKanriJoho"
                            '* —š—ð”Ô† 000015 2003/08/21 íœŠJŽn
                            'Dim cfURAtenaKanriJoho As URAtenaKanriJohoBClass    'ˆ¶–¼ŠÇ—î•ñ‚aƒNƒ‰ƒX
                            '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                            'Dim cfURAtenaKanriJoho As URAtenaKanriJohoCacheBClass   'ˆ¶–¼ŠÇ—î•ñƒLƒƒƒbƒVƒ…‚aƒNƒ‰ƒX
                            '* —š—ð”Ô† 000023 2004/08/27 íœI—¹
                            '* —š—ð”Ô† 000015 2003/08/21 íœI—¹

                            Try
                                ' ƒfƒoƒbƒOƒƒOo—Í
                                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                '* —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
                                If (m_blnKanriJoho) Then
                                    Exit Sub
                                End If
                                '* —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹

                                '* —š—ð”Ô† 000015 2003/08/21 C³ŠJŽn
                                'ŠÇ—î•ñƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                                'cfURAtenaKanriJoho = New URAtenaKanriJohoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)

                                ' ˆ¶–¼ŠÇ—î•ñƒLƒƒƒbƒVƒ…‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                                '* —š—ð”Ô† 000023 2004/08/27 XVŠJŽni‹{‘òj
                                'cfURAtenaKanriJoho = New URAtenaKanriJohoCacheBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                If (m_cfURAtenaKanriJoho Is Nothing) Then
                                    m_cfURAtenaKanriJoho = New URAtenaKanriJohoCacheBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                End If
                                '* —š—ð”Ô† 000023 2004/08/27 XVI—¹
                                '* —š—ð”Ô† 000015 2003/08/21 C³I—¹

                                m_intHyojiketaJuminCD = m_cfURAtenaKanriJoho.p_intHyojiketaJuminCD                'Z–¯ƒR[ƒh•\Ž¦Œ…”
                                m_intHyojiketaStaiCD = m_cfURAtenaKanriJoho.p_intHyojiketaSetaiCD                 '¢‘ÑƒR[ƒh•\Ž¦Œ…”
                                m_intHyojiketaJushoCD = m_cfURAtenaKanriJoho.p_intHyojiketaJushoCD                'ZŠƒR[ƒh•\Ž¦Œ…”iŠÇ“à‚Ì‚Ýj
                                m_intHyojiketaGyoseikuCD = m_cfURAtenaKanriJoho.p_intHyojiketaGyoseikuCD          's­‹æƒR[ƒh•\Ž¦Œ…”
                                m_intHyojiketaChikuCD1 = m_cfURAtenaKanriJoho.p_intHyojiketaChikuCD1              '’n‹æƒR[ƒh‚P•\Ž¦Œ…”
                                m_intHyojiketaChikuCD2 = m_cfURAtenaKanriJoho.p_intHyojiketaChikuCD2              '’n‹æƒR[ƒh‚Q•\Ž¦Œ…”
                                m_intHyojiketaChikuCD3 = m_cfURAtenaKanriJoho.p_intHyojiketaChikuCD3              '’n‹æƒR[ƒh‚R•\Ž¦Œ…”
                                m_strChikuCD1HyojiMeisho = m_cfURAtenaKanriJoho.p_strChikuCD1HyojiMeisho          '’n‹æƒR[ƒh‚P•\Ž¦–¼Ì
                                m_strChikuCD2HyojiMeisho = m_cfURAtenaKanriJoho.p_strChikuCD2HyojiMeisho          '’n‹æƒR[ƒh‚Q•\Ž¦–¼Ì
                                m_strChikuCD3HyojiMeisho = m_cfURAtenaKanriJoho.p_strChikuCD3HyojiMeisho          '’n‹æƒR[ƒh‚R•\Ž¦–¼Ì
                                m_strRenrakusaki1HyojiMeisho = m_cfURAtenaKanriJoho.p_strRenrakusaki1HyojiMeisho  '˜A—æ‚P•\Ž¦–¼Ì
                                m_strRenrakusaki2HyojiMeisho = m_cfURAtenaKanriJoho.p_strRenrakusaki2HyojiMeisho  '˜A—æ‚Q•\Ž¦–¼Ì

                                '* —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁŠJŽn
                                ' ŠÇ—î•ñŽæ“¾Ï‚Ýƒtƒ‰ƒOÝ’è
                                m_blnKanriJoho = True
                                '* —š—ð”Ô† 000014 2003/06/17 ’Ç‰ÁI—¹

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
                    #End Region

                    #Region " ƒpƒ‰ƒ[ƒ^[ƒ`ƒFƒbƒN(CheckColumnValue) "
                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     ƒpƒ‰ƒ[ƒ^[ƒ`ƒFƒbƒN
                        '* 
                        '* \•¶           Private Sub CheckColumnValue(ByVal cAtenaGetPara1 As ABAtenaGetPara1)
                        '* 
                        '* ‹@”\@@    @@ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^‚Ìƒ`ƒFƒbƒN‚ðs‚È‚¤
                        '* 
                        '* ˆø”           cAtenaGetPara1 As ABAtenaGetPara1 : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
                        '*                intHyojunKB                       : •W€‰»‹æ•ª
                        '* 
                        '* –ß‚è’l         ‚È‚µ
                        '************************************************************************************************
                        Private Sub CheckColumnValue(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass, ByVal intHyojunKB As ABEnumDefine.HyojunKB)

                            Const THIS_METHOD_NAME As String = "CheckColumnValue"
                            Dim objErrorStruct As UFErrorStruct                 ' ƒGƒ‰[’è‹`\‘¢‘Ì
                            '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                            'Dim m_cfDateClass As UFDateClass                    ' “ú•tƒNƒ‰ƒX
                            '* —š—ð”Ô† 000023 2004/08/27 íœI—¹

                            Try

                                ' ƒfƒoƒbƒOƒƒOo—Í
                                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                '“ú•tƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                                '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                                'm_cfDateClass = New UFDateClass(m_cfConfigDataClass)
                                '* —š—ð”Ô† 000023 2004/08/27 íœI—¹
                                '•K—v‚ÈÝ’è‚ðs‚¤
                                m_cfDateClass.p_enDateSeparator = UFDateSeparator.None


                                'ZŠîEZ“oŠO‹æ•ª
                                If Not (cAtenaGetPara1.p_strJukiJutogaiKB.Trim = String.Empty) Then
                                    If (Not (cAtenaGetPara1.p_strJukiJutogaiKB = "1")) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "ZŠîEZ“oŠO‹æ•ª", objErrorStruct.m_strErrorCode)
                                    End If
                                End If


                                '‘—•tæƒf[ƒ^‹æ•ª
                                If Not (cAtenaGetPara1.p_strSfskDataKB = String.Empty) Then
                                    If (Not (cAtenaGetPara1.p_strSfskDataKB = "1")) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "‘—•tæƒf[ƒ^‹æ•ª", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                '¢‘Ñˆõ•ÒW
                                If Not (cAtenaGetPara1.p_strStaiinHenshu = String.Empty) Then
                                    If (Not (cAtenaGetPara1.p_strStaiinHenshu = "1")) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "¢‘Ñˆõ•ÒW", objErrorStruct.m_strErrorCode)
                                    End If
                                End If


                                'Z–¯ƒR[ƒh
                                If Not (cAtenaGetPara1.p_strJuminCD.Trim = String.Empty) Then
                                    If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strJuminCD.Trim)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "Z–¯ƒR[ƒh", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                '¢‘ÑƒR[ƒh
                                If Not (cAtenaGetPara1.p_strStaiCD.Trim = String.Empty) Then
                                    If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strStaiCD.Trim)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "¢‘ÑƒR[ƒh", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                'ƒJƒi©–¼
                                If Not (cAtenaGetPara1.p_strKanaSeiMei = String.Empty) Then
                                    '*—š—ð”Ô† 000019 2003/10/30 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKataKana(cAtenaGetPara1.p_strKanaSeiMei.TrimEnd("%"c))) Then
                                    If (Not UFStringClass.CheckANK(cAtenaGetPara1.p_strKanaSeiMei.TrimEnd("%"c))) Then
                                        '*—š—ð”Ô† 000019 2003/10/30 C³I—¹

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "ƒJƒi©–¼", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                'ƒJƒi©
                                If Not (cAtenaGetPara1.p_strKanaSei = String.Empty) Then
                                    '*—š—ð”Ô† 000019 2003/10/30 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKataKana(cAtenaGetPara1.p_strKanaSei.TrimEnd("%"c))) Then
                                    If (Not UFStringClass.CheckANK(cAtenaGetPara1.p_strKanaSei.TrimEnd("%"c))) Then
                                        '*—š—ð”Ô† 000019 2003/10/30 C³I—¹

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "ƒJƒi©", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                'ƒJƒi–¼
                                If Not (cAtenaGetPara1.p_strKanaMei = String.Empty) Then
                                    '*—š—ð”Ô† 000019 2003/10/30 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKataKana(cAtenaGetPara1.p_strKanaMei.TrimEnd("%"c))) Then
                                    If (Not UFStringClass.CheckANK(cAtenaGetPara1.p_strKanaMei.TrimEnd("%"c))) Then
                                        '*—š—ð”Ô† 000019 2003/10/30 C³I—¹

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "ƒJƒi–¼", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                'Š¿Žš–¼Ì
                                If Not (cAtenaGetPara1.p_strKanjiShimei = String.Empty) Then
                                    '* —š—ð”Ô† 000025 2005/04/04 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKanjiCode(cAtenaGetPara1.p_strKanjiShimei.TrimEnd("%"c), m_cfConfigDataClass)) Then
                                    If (Not UFStringClass.CheckKanjiCode(cAtenaGetPara1.p_strKanjiShimei.Replace("%"c, String.Empty), m_cfConfigDataClass)) Then
                                        '* —š—ð”Ô† 000025 2005/04/04 C³I—¹

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "Š¿Žš–¼Ì", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                '¶”NŒŽ“ú
                                If Not (cAtenaGetPara1.p_strUmareYMD = String.Empty Or cAtenaGetPara1.p_strUmareYMD = "00000000") Then
                                    If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strUmareYMD.TrimEnd("%"c))) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "¶”NŒŽ“ú", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                '«•ÊƒR[ƒh
                                If Not (cAtenaGetPara1.p_strSeibetsu = String.Empty) Then
                                    If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strSeibetsu)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "«•ÊƒR[ƒh", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                'ZŠƒR[ƒh
                                If Not (cAtenaGetPara1.p_strJushoCD.Trim = String.Empty) Then
                                    If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strJushoCD.Trim)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "ZŠƒR[ƒh", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                's­‹æƒR[ƒh
                                If Not (cAtenaGetPara1.p_strGyoseikuCD.Trim = String.Empty) Then
                                    '*—š—ð”Ô† 000028 2005/12/06 C³ŠJŽn
                                    ''If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strGyoseikuCD.Trim)) Then
                                    If (Not UFStringClass.CheckANK(cAtenaGetPara1.p_strGyoseikuCD.Trim)) Then
                                        '*—š—ð”Ô† 000028 2005/12/06 C³I—¹

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "s­‹æƒR[ƒh", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                '’n‹æƒR[ƒh‚P
                                If Not (cAtenaGetPara1.p_strChikuCD1.Trim = String.Empty) Then
                                    If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strChikuCD1.Trim)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "’n‹æƒR[ƒh‚P", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                '’n‹æƒR[ƒh‚Q
                                If Not (cAtenaGetPara1.p_strChikuCD2.Trim = String.Empty) Then
                                    If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strChikuCD2.Trim)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "’n‹æƒR[ƒh‚Q", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                '’n‹æƒR[ƒh‚R
                                If Not (cAtenaGetPara1.p_strChikuCD3.Trim = String.Empty) Then
                                    If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strChikuCD3)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "’n‹æƒR[ƒh‚R", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                '”Ô’nƒR[ƒh‚P
                                If Not (cAtenaGetPara1.p_strBanchiCD1.Trim = String.Empty) Then
                                    If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strBanchiCD1.Trim)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "”Ô’nƒR[ƒh‚P", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                '”Ô’nƒR[ƒh‚Q
                                If Not (cAtenaGetPara1.p_strBanchiCD2.Trim = String.Empty) Then
                                    If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strBanchiCD2.Trim)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "”Ô’nƒR[ƒh‚Q", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                '”Ô’nƒR[ƒh‚R
                                If Not (cAtenaGetPara1.p_strBanchiCD3.Trim = String.Empty) Then
                                    If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strBanchiCD3.Trim)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "”Ô’nƒR[ƒh‚R", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                'ƒf[ƒ^‹æ•ª
                                '*—š—ð”Ô† 000021 2003/12/01 C³ŠJŽn
                                'If Not (cAtenaGetPara1.p_strDataKB = String.Empty) Then
                                If Not ((cAtenaGetPara1.p_strDataKB = String.Empty) Or (cAtenaGetPara1.p_strDataKB = "1%")) Then
                                    '*—š—ð”Ô† 000021 2003/12/01 C³I—¹
                                    If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strDataKB)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "ƒf[ƒ^‹æ•ª", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                'Z–¯Ží•Ê‚P
                                If Not (cAtenaGetPara1.p_strJuminSHU1 = String.Empty) Then
                                    If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strJuminSHU1)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "Z–¯Ží•Ê‚P", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                'Z–¯Ží•Ê‚Q
                                If Not (cAtenaGetPara1.p_strJuminSHU2 = String.Empty) Then
                                    If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strJuminSHU2)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "Z–¯Ží•Ê‚Q", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                'Žw’è”NŒŽ“ú
                                If Not (cAtenaGetPara1.p_strShiteiYMD = String.Empty Or cAtenaGetPara1.p_strShiteiYMD = "00000000") Then
                                    m_cfDateClass.p_strDateValue = cAtenaGetPara1.p_strShiteiYMD
                                    If (Not m_cfDateClass.CheckDate()) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "Žw’è”NŒŽ“ú", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                'Žs’¬‘ºƒR[ƒh
                                If Not (cAtenaGetPara1.p_strShichosonCD = String.Empty) Then
                                    If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strShichosonCD)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "Žs’¬‘ºƒR[ƒh", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                '•\Ž¦Œ”
                                If (cAtenaGetPara1.p_intHyojiKensu < 0) Or (cAtenaGetPara1.p_intHyojiKensu > 999) Then

                                    m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                    'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                    '—áŠO‚ð¶¬
                                    Throw New UFAppException(objErrorStruct.m_strErrorMessage + "•\Ž¦Œ”", objErrorStruct.m_strErrorCode)
                                End If

                                'Z–¯ƒR[ƒh‚Æ¢‘ÑƒR[ƒh‚ªNULL‚ÅA¢‘Ñˆõ•ÒW‚ª"1"‚ÌŽžA—áŠOƒGƒ‰[
                                If (cAtenaGetPara1.p_strJuminCD = String.Empty) _
                                        And (cAtenaGetPara1.p_strStaiCD = String.Empty) _
                                        And (cAtenaGetPara1.p_strStaiinHenshu = "1") Then

                                    m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                    'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                    '—áŠO‚ð¶¬
                                    Throw New UFAppException(objErrorStruct.m_strErrorMessage + "¢‘Ñˆõ•ÒW", objErrorStruct.m_strErrorCode)
                                End If

                                '‹ŒŽ
                                If Not (cAtenaGetPara1.p_strKyuuji.Trim = String.Empty) Then
                                    If (Not UFStringClass.CheckKanjiCode(cAtenaGetPara1.p_strKyuuji.Replace("%"c, String.Empty), m_cfConfigDataClass)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "‹ŒŽ", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                'ƒJƒi‹ŒŽ
                                If Not (cAtenaGetPara1.p_strKanaKyuuji.Trim = String.Empty) Then
                                    If (Not UFStringClass.CheckANK(cAtenaGetPara1.p_strKanaKyuuji.Replace("%"c, String.Empty))) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "ƒJƒi‹ŒŽ", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                'ƒJƒ^ƒJƒi•¹‹L–¼
                                If Not (cAtenaGetPara1.p_strKatakanaHeikimei.Trim = String.Empty) Then
                                    If (Not UFStringClass.CheckKataKanaWide(cAtenaGetPara1.p_strKatakanaHeikimei.Replace("%"c, String.Empty))) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "ƒJƒ^ƒJƒi•¹‹L–¼", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                'ZŠ
                                If Not (cAtenaGetPara1.p_strJusho.Trim = String.Empty) Then
                                    If (Not UFStringClass.CheckKanjiCode(cAtenaGetPara1.p_strJusho.Replace("%"c, String.Empty), m_cfConfigDataClass)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "ZŠ", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                '•û‘
                                If Not (cAtenaGetPara1.p_strKatagaki.Trim = String.Empty) Then
                                    If (Not UFStringClass.CheckKanjiCode(cAtenaGetPara1.p_strKatagaki.Replace("%"c, String.Empty), m_cfConfigDataClass)) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "•û‘", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                '“d˜b”Ô†
                                If Not (cAtenaGetPara1.p_strRenrakusaki.Trim = String.Empty) Then
                                    If (Not UFStringClass.CheckNumber(cAtenaGetPara1.p_strRenrakusaki.Replace("-", String.Empty))) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "“d˜b”Ô†", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                'Z–¯ƒR[ƒh`”Ô’nƒR[ƒh‚R‚·‚×‚Ä‚ªNULL‚ÌŽžA—áŠOƒGƒ‰[
                                '*—š—ð”Ô† 000027 2005/05/06 C³ŠJŽn
                                '*—š—ð”Ô† 000048 2014/04/28 C³ŠJŽn
                                ' ‹¤’Ê”Ô†‚Ì’P“ÆŽw’è‚ð‰Â”\‚Æ‚·‚é‚½‚ßA”»’è€–Ú‚É’Ç‰Á‚·‚éB
                                'If (cAtenaGetPara1.p_strJuminCD.Trim = String.Empty) _
                                '        And (cAtenaGetPara1.p_strStaiCD.Trim = String.Empty) _
                                '        And (cAtenaGetPara1.p_strKanaSeiMei.Trim = String.Empty) _
                                '        And (cAtenaGetPara1.p_strKanaSei.Trim = String.Empty) _
                                '        And (cAtenaGetPara1.p_strKanaMei.Trim = String.Empty) _
                                '        And (cAtenaGetPara1.p_strKanjiShimei.Trim = String.Empty) _
                                '        And (cAtenaGetPara1.p_strUmareYMD.Trim = String.Empty) _
                                '        And (cAtenaGetPara1.p_strJushoCD.Trim = String.Empty) _
                                '        And (cAtenaGetPara1.p_strGyoseikuCD.Trim = String.Empty) _
                                '        And (cAtenaGetPara1.p_strChikuCD1.Trim = String.Empty) _
                                '        And (cAtenaGetPara1.p_strChikuCD2.Trim = String.Empty) _
                                '        And (cAtenaGetPara1.p_strChikuCD3.Trim = String.Empty) _
                                '        And (cAtenaGetPara1.p_strBanchiCD1.Trim = String.Empty) _
                                '        And (cAtenaGetPara1.p_strBanchiCD2.Trim = String.Empty) _
                                '        And (cAtenaGetPara1.p_strBanchiCD3.Trim = String.Empty) Then

                                If (Not cAtenaGetPara1.p_strShiteiYMD.Trim = String.Empty) AndAlso
                                   (intHyojunKB = ABEnumDefine.HyojunKB.KB_Tsujo) Then
                                    If (cAtenaGetPara1.p_strJuminCD.Trim = String.Empty) _
                                        And (cAtenaGetPara1.p_strStaiCD.Trim = String.Empty) _
                                        And (cAtenaGetPara1.p_strKanaSeiMei.Trim = String.Empty) _
                                        And (cAtenaGetPara1.p_strKanaSei.Trim = String.Empty) _
                                        And (cAtenaGetPara1.p_strKanaMei.Trim = String.Empty) _
                                        And (cAtenaGetPara1.p_strKanjiShimei.Trim = String.Empty) _
                                        And (cAtenaGetPara1.p_strUmareYMD.Trim = String.Empty) _
                                        And (cAtenaGetPara1.p_strJushoCD.Trim = String.Empty) _
                                        And (cAtenaGetPara1.p_strGyoseikuCD.Trim = String.Empty) _
                                        And (cAtenaGetPara1.p_strChikuCD1.Trim = String.Empty) _
                                        And (cAtenaGetPara1.p_strChikuCD2.Trim = String.Empty) _
                                        And (cAtenaGetPara1.p_strChikuCD3.Trim = String.Empty) _
                                        And (cAtenaGetPara1.p_strBanchiCD1.Trim = String.Empty) _
                                        And (cAtenaGetPara1.p_strBanchiCD2.Trim = String.Empty) _
                                        And (cAtenaGetPara1.p_strBanchiCD3.Trim = String.Empty) _
                                        And (cAtenaGetPara1.p_strMyNumber.Trim = String.Empty) _
                                        And (cAtenaGetPara1.p_strRenrakusaki.Trim = String.Empty) Then
                                        '*—š—ð”Ô† 000048 2014/04/28 C³I—¹
                                        '*—š—ð”Ô† 000027 2005/05/06 C³I—¹

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "ŒŸõƒL[‚È‚µ", objErrorStruct.m_strErrorCode)
                                    End If
                                Else
                                    If (cAtenaGetPara1.p_strJuminCD.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strStaiCD.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strKanaSeiMei.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strKanaSei.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strKanaMei.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strKanjiShimei.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strUmareYMD.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strJushoCD.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strGyoseikuCD.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strChikuCD1.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strChikuCD2.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strChikuCD3.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strBanchiCD1.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strBanchiCD2.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strBanchiCD3.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strMyNumber.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strKyuuji.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strKanaKyuuji.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strKatakanaHeikimei.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strJusho.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strKatagaki.Trim = String.Empty) _
                                        AndAlso (cAtenaGetPara1.p_strRenrakusaki.Trim = String.Empty) Then

                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + "ŒŸõƒL[‚È‚µ", objErrorStruct.m_strErrorCode)
                                    End If
                                End If

                                '*—š—ð”Ô† 000040 2008/11/10 ’Ç‰ÁŠJŽn
                                If ((cAtenaGetPara1.p_strTdkdKB = "1" OrElse cAtenaGetPara1.p_strTdkdKB = "2") AndAlso
                                    cAtenaGetPara1.p_strTdkdZeimokuCD = ABEnumDefine.ZeimokuCDType.Empty) Then

                                    m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                    'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                    '—áŠO‚ð¶¬
                                    Throw New UFAppException(objErrorStruct.m_strErrorMessage + "—˜—p“ÍoŽæ“¾‹æ•ª‚ðŽg—p‚·‚éê‡‚ÍA—˜—p“ÍoŽæ“¾—pÅ–ÚƒR[ƒh‚ðŽw’è‚µ‚Ä‚­‚¾‚³‚¢B",
                                                             objErrorStruct.m_strErrorCode)
                                End If
                                '*—š—ð”Ô† 000040 2008/11/10 ’Ç‰ÁI—¹

                                '*—š—ð”Ô† 000051 2020/11/02 ’Ç‰ÁŠJŽn
                                '—˜—p“Ío—˜—p‹æ•ª
                                If ((cAtenaGetPara1.p_strTdkdKB = "1" OrElse cAtenaGetPara1.p_strTdkdKB = "2") AndAlso
                                    Not (cAtenaGetPara1.p_strTdkdRiyoKB = String.Empty OrElse cAtenaGetPara1.p_strTdkdRiyoKB = "1" OrElse cAtenaGetPara1.p_strTdkdRiyoKB = "2" OrElse cAtenaGetPara1.p_strTdkdRiyoKB = "3")) Then

                                    m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                    'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036)
                                    '—áŠO‚ð¶¬
                                    Throw New UFAppException(objErrorStruct.m_strErrorMessage + "—˜—p“Ío—˜—p‹æ•ª", objErrorStruct.m_strErrorCode)
                                End If
                                '*—š—ð”Ô† 000051 2020/11/02 ’Ç‰ÁI—¹

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
                                Throw objExp
                            End Try

                        End Sub
                    #End Region

                    #Region " ˆ¶–¼î•ñ‚Ìƒ}[ƒW(CreateAtenaDataSet) "
                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     ˆ¶–¼î•ñ‚Ìƒ}[ƒW
                        '* 
                        '* \•¶           Private Function CreateAtenaDataSet(ByVal csAtenaH As DataSet, _
                        '*                                                  ByVal csAtenaHS As DataSet, _
                        '*                                                  ByVal csAtenaD As DataSet, _
                        '*                                                  ByVal csAtenaDS As DataSet) As DataSet
                        '* 
                        '* ‹@”\@@    @@Šeˆ¶–¼î•ñƒf[ƒ^ƒZƒbƒg‚ðƒ}[ƒW‚·‚é
                        '* 
                        '* ˆø”           csAtenaH As DataSet   : ˆ¶–¼ƒf[ƒ^
                        '*                csAtenaHS As DataSet  : ‘—•tæƒf[ƒ^
                        '*                csAtenaD  As DataSet  : ‘ã”[ƒf[ƒ^
                        '*                csAtenaDS As DataSet  : ‘ã”[‘—•tæƒf[ƒ^
                        '* @@           blnKobetsu       : ŒÂ•ÊŽæ“¾(True:ŠeŒÂ•Êƒ}ƒXƒ^‚æ‚èƒf[ƒ^‚ðŽæ“¾‚·‚é)
                        '* 
                        '* –ß‚è’l         ‚È‚µ
                        '************************************************************************************************
                        '*—š—ð”Ô† 000020 2003/11/19 C³ŠJŽn
                        'Private Function CreateAtenaDataSet(ByVal csAtenaH As DataSet, ByVal csAtenaHS As DataSet, _
                        '                                    ByVal csAtenaD As DataSet, ByVal csAtenaDS As DataSet) As DataSet
                        Private Function CreateAtenaDataSet(ByVal csAtenaH As DataSet, ByVal csAtenaHS As DataSet,
                                                            ByVal csAtenaD As DataSet, ByVal csAtenaDS As DataSet,
                                                            ByVal blnKobetsu As Boolean, ByVal intHyojunKB As ABEnumDefine.HyojunKB) As DataSet
                            '*—š—ð”Ô† 000020 2003/11/19 C³I—¹
                            Const THIS_METHOD_NAME As String = "CreateAtenaDataSet"
                            Dim csAtena1 As DataSet                             'ˆ¶–¼î•ñ(ABAtena1)
                            '* corresponds to VS2008 Start 2010/04/16 000044
                            'Dim csRow As DataRow
                            'Dim csNewRow As DataRow
                            '* corresponds to VS2008 End 2010/04/16 000044
                            'Dim cABCommon As ABCommonClass                      'ˆ¶–¼‹Æ–±‹¤’ÊƒNƒ‰ƒX
                            Dim strTableName As String

                            Try

                                '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                                'ƒƒOo—Í—pƒNƒ‰ƒXƒCƒ“ƒXƒ^ƒ“ƒX‰»
                                'm_cfLogClass = New UFLogClass(m_cfConfigDataClass, m_cfControlData.m_strBusinessId)
                                '* —š—ð”Ô† 000023 2004/08/27 íœI—¹

                                'ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                'ˆ¶–¼‹Æ–±‹¤’ÊƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                                'cABCommon = New ABCommonClass()

                                'ˆ¶–¼î•ñ‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                                csAtena1 = New DataSet

                                If (blnKobetsu) Then
                                    If (intHyojunKB = ABEnumDefine.HyojunKB.KB_Hyojun) Then
                                        strTableName = ABAtena1KobetsuHyojunEntity.TABLE_NAME
                                    Else
                                        strTableName = ABAtena1KobetsuEntity.TABLE_NAME
                                    End If
                                Else
                                    If (intHyojunKB = ABEnumDefine.HyojunKB.KB_Hyojun) Then
                                        strTableName = ABAtena1HyojunEntity.TABLE_NAME
                                    Else
                                        strTableName = ABAtena1Entity.TABLE_NAME
                                    End If
                                End If

                                'ˆ¶–¼ƒf[ƒ^‘¶Ýƒ`ƒFƒbƒN
                                If Not (csAtenaH Is Nothing) Then
                                    ''*—š—ð”Ô† 000020 2003/11/19 C³ŠJŽn
                                    '''ˆ¶–¼î•ñ‚Éˆ¶–¼ƒf[ƒ^‚ð’Ç‰Á‚·‚é
                                    ''csAtena1.Merge(csAtenaH.Tables(ABAtena1Entity.TABLE_NAME))

                                    'If (blnKobetsu) Then
                                    '    'ˆ¶–¼î•ñ‚Éˆ¶–¼ƒf[ƒ^‚ð’Ç‰Á‚·‚é
                                    '    csAtena1.Merge(csAtenaH.Tables(ABAtena1KobetsuEntity.TABLE_NAME))
                                    'Else
                                    '    'ˆ¶–¼î•ñ‚Éˆ¶–¼ƒf[ƒ^‚ð’Ç‰Á‚·‚é
                                    '    csAtena1.Merge(csAtenaH.Tables(ABAtena1Entity.TABLE_NAME))
                                    'End If
                                    ''*—š—ð”Ô† 000020 2003/11/19 C³I—¹
                                    'ˆ¶–¼î•ñ‚Éˆ¶–¼ƒf[ƒ^‚ð’Ç‰Á‚·‚é
                                    csAtena1.Merge(csAtenaH.Tables(strTableName))
                                End If

                                '‘ã”[ƒf[ƒ^‘¶Ýƒ`ƒFƒbƒN
                                If Not (csAtenaD Is Nothing) Then
                                    ''*—š—ð”Ô† 000020 2003/11/19 C³ŠJŽn
                                    '''‘ã”[ƒf[ƒ^‚ð’Ç‰Á‚·‚é
                                    ''csAtena1.Merge(csAtenaD.Tables(ABAtena1Entity.TABLE_NAME))

                                    'If (blnKobetsu) Then
                                    '    'ˆ¶–¼î•ñ‚Éˆ¶–¼ƒf[ƒ^‚ð’Ç‰Á‚·‚é
                                    '    csAtena1.Merge(csAtenaD.Tables(ABAtena1KobetsuEntity.TABLE_NAME))
                                    'Else
                                    '    'ˆ¶–¼î•ñ‚Éˆ¶–¼ƒf[ƒ^‚ð’Ç‰Á‚·‚é
                                    '    csAtena1.Merge(csAtenaD.Tables(ABAtena1Entity.TABLE_NAME))
                                    'End If
                                    ''*—š—ð”Ô† 000020 2003/11/19 C³I—¹
                                    'ˆ¶–¼î•ñ‚É‘ã”[ƒf[ƒ^‚ð’Ç‰Á‚·‚é
                                    csAtena1.Merge(csAtenaD.Tables(strTableName))
                                End If

                                '‘—•tæƒf[ƒ^‘¶Ýƒ`ƒFƒbƒN
                                If Not (csAtenaHS Is Nothing) Then
                                    ''*—š—ð”Ô† 000020 2003/11/19 C³ŠJŽn
                                    '''‘—•tæƒf[ƒ^‚ð’Ç‰Á‚·‚é
                                    ''csAtena1.Merge(csAtenaHS.Tables(ABAtena1Entity.TABLE_NAME))

                                    'If (blnKobetsu) Then
                                    '    'ˆ¶–¼î•ñ‚Éˆ¶–¼ƒf[ƒ^‚ð’Ç‰Á‚·‚é
                                    '    csAtena1.Merge(csAtenaHS.Tables(ABAtena1KobetsuEntity.TABLE_NAME))
                                    'Else
                                    '    'ˆ¶–¼î•ñ‚Éˆ¶–¼ƒf[ƒ^‚ð’Ç‰Á‚·‚é
                                    '    csAtena1.Merge(csAtenaHS.Tables(ABAtena1Entity.TABLE_NAME))
                                    'End If
                                    ''*—š—ð”Ô† 000020 2003/11/19 C³I—¹
                                    'ˆ¶–¼î•ñ‚É‘—•tæƒf[ƒ^‚ð’Ç‰Á‚·‚é
                                    csAtena1.Merge(csAtenaHS.Tables(strTableName))
                                End If

                                '‘ã”[‘—•tæƒf[ƒ^‘¶Ýƒ`ƒFƒbƒN
                                If Not (csAtenaDS Is Nothing) Then
                                    ''*—š—ð”Ô† 000020 2003/11/19 C³ŠJŽn
                                    '''‘ã”[‘—•tæƒf[ƒ^‚ð’Ç‰Á‚·‚é
                                    ''csAtena1.Merge(csAtenaDS.Tables(ABAtena1Entity.TABLE_NAME))

                                    'If (blnKobetsu) Then
                                    '    'ˆ¶–¼î•ñ‚Éˆ¶–¼ƒf[ƒ^‚ð’Ç‰Á‚·‚é
                                    '    csAtena1.Merge(csAtenaDS.Tables(ABAtena1KobetsuEntity.TABLE_NAME))
                                    'Else
                                    '    'ˆ¶–¼î•ñ‚Éˆ¶–¼ƒf[ƒ^‚ð’Ç‰Á‚·‚é
                                    '    csAtena1.Merge(csAtenaDS.Tables(ABAtena1Entity.TABLE_NAME))
                                    'End If
                                    ''*—š—ð”Ô† 000020 2003/11/19 C³I—¹
                                    'ˆ¶–¼î•ñ‚É‘ã”[‘—•tæƒf[ƒ^‚ð’Ç‰Á‚·‚é
                                    csAtena1.Merge(csAtenaDS.Tables(strTableName))
                                End If

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
                                Throw objExp
                            End Try

                            Return csAtena1

                        End Function
                    #End Region

                    #Region " ˜A—æ•ÒWˆ—(RenrakusakiHenshu) "
                        '*—š—ð”Ô† 000022 2003/12/02 ’Ç‰ÁŠJŽn
                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     ˜A—æ•ÒWˆ—
                        '* 
                        '* \•¶           Private Sub RenrakusakiHenshu(ByVal strGyomuCD As String, 
                        '* @@                                         ByVal strGyomunaiSHU_CD As String, 
                        '* @@                                         ByRef csAtenaH As DataSet,
                        '* @@                                         ByRef csOrgAtena As DataSet)
                        '* 
                        '* ‹@”\@@    @@˜A—æ‚ðŽæ“¾‚µ‚ÄA•ÒW‚·‚é
                        '* 
                        '* ˆø”           strGyomuCD As String          : ‹Æ–±ƒR[ƒh
                        '* @@           strGyomunaiSHU_CD As String   : ‹Æ–±“àŽí•ÊƒR[ƒh
                        '*                csAtenaH  As DataSet          : –{lƒf[ƒ^
                        '* 
                        '* –ß‚è’l         ‚È‚µ
                        '************************************************************************************************
                        'Private Sub RenrakusakiHenshu(ByVal strGyomuCD As String, ByVal strGyomunaiSHU_CD As String, ByRef csAtenaH As DataSet)
                        Private Sub RenrakusakiHenshu(ByVal strGyomuCD As String, ByVal strGyomunaiSHU_CD As String, ByRef csAtenaH As DataSet,
                                                      ByRef csOrgAtena As DataSet, ByVal intHyojunKB As ABEnumDefine.HyojunKB, ByVal strKikanYMD As String)
                            '* —š—ð”Ô† 000023 2004/08/27 íœŠJŽni‹{‘òj
                            'Dim cRenrakusakiBClass As ABRenrakusakiBClass       ' ˜A—æ‚aƒNƒ‰ƒX
                            '* —š—ð”Ô† 000023 2004/08/27 íœI—¹
                            Dim csRenrakusakiEntity As DataSet                  ' ˜A—æDataSet
                            Dim csRenrakusakiRow As DataRow                     ' ˜A—æRow
                            Dim csRow As DataRow
                            Dim csAtena1Table As DataTable                      ' AtenaTable

                            Try
                                'ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                                m_cfLogClass.DebugStartWrite(m_cfControlData, Me.GetType.Name, System.Reflection.MethodBase.GetCurrentMethod.Name)

                                ' ‹Æ–±ƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢ê‡‚ÍAˆ—‚µ‚È‚¢
                                If (strGyomuCD.Trim = String.Empty) Then
                                    Exit Sub
                                End If

                                ' ˜A—æ‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                                'cRenrakusakiBClass = New ABRenrakusakiBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                If (m_cRenrakusakiBClass Is Nothing) Then
                                    m_cRenrakusakiBClass = New ABRenrakusakiBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                End If

                                If (csAtenaH.Tables.Contains(ABAtena1Entity.TABLE_NAME)) Then
                                    csAtena1Table = csAtenaH.Tables(ABAtena1Entity.TABLE_NAME)
                                ElseIf (csAtenaH.Tables.Contains(ABNenkinAtenaEntity.TABLE_NAME)) Then
                                    csAtena1Table = csAtenaH.Tables(ABNenkinAtenaEntity.TABLE_NAME)
                                ElseIf (csAtenaH.Tables.Contains(ABAtena1KobetsuEntity.TABLE_NAME)) Then
                                    csAtena1Table = csAtenaH.Tables(ABAtena1KobetsuEntity.TABLE_NAME)
                                ElseIf (csAtenaH.Tables.Contains(ABAtena1HyojunEntity.TABLE_NAME)) Then
                                    csAtena1Table = csAtenaH.Tables(ABAtena1HyojunEntity.TABLE_NAME)
                                ElseIf (csAtenaH.Tables.Contains(ABNenkinAtenaHyojunEntity.TABLE_NAME)) Then
                                    csAtena1Table = csAtenaH.Tables(ABNenkinAtenaHyojunEntity.TABLE_NAME)
                                ElseIf (csAtenaH.Tables.Contains(ABAtena1KobetsuHyojunEntity.TABLE_NAME)) Then
                                    csAtena1Table = csAtenaH.Tables(ABAtena1KobetsuHyojunEntity.TABLE_NAME)
                                Else
                                    ' ƒVƒXƒeƒ€ƒGƒ‰[
                                End If

                                '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
                                Dim intCount As Integer = 0
                                Dim csAtenaRow As DataRow
                                '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹

                                For Each csRow In csAtena1Table.Rows
                                    '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òjIF•¶‚ð’Ç‰Á
                                    csAtenaRow = csOrgAtena.Tables(0).Rows(intCount)
                                    If (Not (csAtenaRow.Item(ABAtenaCountEntity.RENERAKUSAKICOUNT) Is System.DBNull.Value)) Then
                                        If (CType(csAtenaRow.Item(ABAtenaCountEntity.RENERAKUSAKICOUNT), Integer) > 0) Then
                                            '* —š—ð”Ô† 000024 2005/01/25 ’Ç‰ÁI—¹i‹{‘òjIF•¶‚ð’Ç‰Á
                                            ' ˜A—æƒf[ƒ^‚ðŽæ“¾‚·‚é
                                            csRenrakusakiEntity = m_cRenrakusakiBClass.GetRenrakusakiBHoshu_Hyojun(CType(csRow(ABAtena1Entity.JUMINCD), String), strGyomuCD, strGyomunaiSHU_CD, strKikanYMD)
                                            If (csRenrakusakiEntity.Tables(ABRenrakusakiEntity.TABLE_NAME).Rows.Count <> 0) Then
                                                csRenrakusakiRow = csRenrakusakiEntity.Tables(ABRenrakusakiEntity.TABLE_NAME).Rows(0)
                                                '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
                                                csRenrakusakiRow.BeginEdit()
                                                '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁI—¹
                                                '˜A—æ‚P
                                                If (CType(csRenrakusakiRow(ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU1), String).Trim <> "03") AndAlso
                                                   (CType(csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKI1), String).RLength <= 15) Then
                                                    csRow(ABAtena1Entity.RENRAKUSAKI1) = csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKI1)
                                                End If
                                                '˜A—æ‚Q
                                                If (CType(csRenrakusakiRow(ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU2), String).Trim <> "03") AndAlso
                                                   (CType(csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKI2), String).RLength <= 15) Then
                                                    csRow(ABAtena1Entity.RENRAKUSAKI2) = csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKI2)
                                                End If
                                                Select Case csAtena1Table.TableName
                                                    Case ABNenkinAtenaEntity.TABLE_NAME, ABNenkinAtenaHyojunEntity.TABLE_NAME
                                                        '˜A—æŽæ“¾‹Æ–±ƒR[ƒh
                                                        csRow(ABNenkinAtenaEntity.RENRAKUSAKI_GYOMUCD) = strGyomuCD
                                                    Case ABAtena1KobetsuEntity.TABLE_NAME, ABAtena1KobetsuHyojunEntity.TABLE_NAME
                                                        '˜A—æŽæ“¾‹Æ–±ƒR[ƒh
                                                        csRow(ABAtena1KobetsuEntity.RENRAKUSAKI_GYOMUCD) = strGyomuCD
                                                        '*—š—ð”Ô† 000030 2007/04/21 C³ŠJŽn
                                                    Case ABAtena1Entity.TABLE_NAME, ABAtena1HyojunEntity.TABLE_NAME
                                                        '*—š—ð”Ô† 000042 2008/11/18 C³ŠJŽn
                                                        ' ƒƒ\ƒbƒh‹æ•ª‚ª‰îŒì‚Ìê‡‚Ì‚ÝƒZƒbƒg‚·‚é
                                                        '˜A—æŽæ“¾‹Æ–±ƒR[ƒh (‰îŒì—pƒe[ƒuƒ‹‚Ìê‡‚Ì‚ÝƒZƒbƒg‚·‚éB€–Ú”68ŒÂˆÈã‚Í‰îŒì—pƒe[ƒuƒ‹‚Æ‚Ý‚È‚·B)
                                                        'If csRow.ItemArray.Length > 67 Then
                                                        If (m_blnMethodKB = ABEnumDefine.MethodKB.KB_Kaigo) Then
                                                            csRow(ABAtena1Entity.RENRAKUSAKI_GYOMUCD) = strGyomuCD
                                                        End If
                                                        '*—š—ð”Ô† 000042 2008/11/18 C³I—¹
                                                        '*—š—ð”Ô† 000030 2007/04/21 C³I—¹
                                                End Select
                                                '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj

                                                If (intHyojunKB = ABEnumDefine.HyojunKB.KB_Hyojun) Then
                                                    '˜A—æ‹æ•ª
                                                    csRow(ABAtena1HyojunEntity.RENRAKUSAKIKB) = csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKIKB)
                                                    '˜A—æ–¼
                                                    csRow(ABAtena1HyojunEntity.RENRAKUSAKIMEI) = csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKIMEI)
                                                    '˜A—æ‚P
                                                    csRow(ABAtena1HyojunEntity.RENRAKUSAKI1_RENRAKUSAKI) = csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKI1)
                                                    '˜A—æ‚Q
                                                    csRow(ABAtena1HyojunEntity.RENRAKUSAKI2_RENRAKUSAKI) = csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKI2)
                                                    '˜A—æ‚R
                                                    csRow(ABAtena1HyojunEntity.RENRAKUSAKI3_RENRAKUSAKI) = csRenrakusakiRow(ABRenrakusakiEntity.RENRAKUSAKI3)
                                                    '˜A—æŽí•Ê‚P
                                                    csRow(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU1) = csRenrakusakiRow(ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU1)
                                                    '˜A—æŽí•Ê‚Q
                                                    csRow(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU2) = csRenrakusakiRow(ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU2)
                                                    '˜A—æŽí•Ê‚R
                                                    csRow(ABAtena1HyojunEntity.RENRAKUSAKISHUBETSU3) = csRenrakusakiRow(ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU3)
                                                Else
                                                End If

                                                csRenrakusakiRow.EndEdit()
                                                '* —š—ð”Ô† 000023 2004/08/27 ’Ç‰ÁI—¹
                                            End If
                                        End If
                                    End If
                                    intCount = intCount + 1
                                Next csRow

                                ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
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
                                Throw objExp
                            End Try

                        End Sub
                        '*—š—ð”Ô† 000022 2003/12/02 ’Ç‰ÁI—¹
                    #End Region

                        '*—š—ð”Ô† 000031 2007/07/28 ’Ç‰ÁŠJŽn
                    #Region " “¯ˆêl‘ã•\ŽÒZ–¯ƒR[ƒhŽæ“¾(GetDaihyoJuminCD)"
                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     “¯ˆêl‘ã•\ŽÒZ–¯ƒR[ƒhŽæ“¾
                        '* 
                        '* \•¶           Private Sub GetDaihyoJuminCD(ByRef cAtenaGetPara1 As ABAtenaGetPara1XClass)
                        '* 
                        '* ‹@”\@@    @@Z–¯ƒR[ƒhƒZƒbƒg
                        '* 
                        '* ˆø”           cAtenaGetPara1@F@ŒŸõƒpƒ‰‚ß[ˆŸ
                        '* 
                        '* –ß‚è’l         ‚È‚µ
                        '************************************************************************************************
                        Private Sub GetDaihyoJuminCD(ByRef cAtenaGetPara1 As ABAtenaGetPara1XClass)
                            Const THIS_METHOD_NAME As String = "GetDaihyoJuminCD"
                            '* corresponds to VS2008 Start 2010/04/16 000044
                            'Dim strDaihyoJuminCD As String                  '‘ã•\ŽÒZ–¯ƒR[ƒh
                            '* corresponds to VS2008 End 2010/04/16 000044

                            Try
                                ' ƒfƒoƒbƒOƒƒOo—Í
                                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                'ŒŸõðŒ‚É‚æ‚èA‘ã•\ŽÒŽæ“¾‚Ìˆ—‚ðs‚¤
                                If cAtenaGetPara1.p_strJuminCD <> String.Empty AndAlso cAtenaGetPara1.p_strJukiJutogaiKB = "" AndAlso cAtenaGetPara1.p_strDaihyoShaKB = "" Then

                                    'ŠÇ—î•ñŽæ“¾‚ðs‚¤
                                    If m_strDoitsu_Param = String.Empty Then
                                        'ƒƒ“ƒo‚É–³‚¢ê‡‚Ì‚ÝƒCƒ“ƒXƒ^ƒ“ƒX‰»‚ðs‚¤
                                        If (m_cABAtenaKanriJohoB Is Nothing) Then
                                            m_cABAtenaKanriJohoB = New ABAtenaKanriJohoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                        End If
                                        'ŠÇ—î•ñ‚æ‚èŽæ“¾
                                        m_strDoitsu_Param = m_cABAtenaKanriJohoB.GetDoitsuHantei_Param()
                                    End If

                                    'ŠÇ—î•ñ‚É‚æ‚èA“¯ˆêl‘ã•\ŽÒŽæ“¾‚ðs‚¤‚©”»’è‚·‚é
                                    If m_strDoitsu_Param = ABConstClass.PRM_DAIHYO Then
                                        'Z–¯ƒR[ƒh‚ð‘Þ”ð‚³‚¹‚é
                                        m_strHonninJuminCD = cAtenaGetPara1.p_strJuminCD.Trim
                                        'ƒƒ“ƒo‚É–³‚¢ê‡‚Ì‚ÝƒCƒ“ƒXƒ^ƒ“ƒX‰»‚ðs‚¤
                                        If (m_cABGappeiDoitsuninB Is Nothing) Then
                                            m_cABGappeiDoitsuninB = New ABGappeiDoitsuninBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                                        End If

                                        '“¯ˆêl‘ã•\ŽÒ‚Ìî•ñ‚ðŽæ“¾‚µAŒŸõƒpƒ‰ƒ[ƒ^‚ÖƒZƒbƒg‚·‚é
                                        cAtenaGetPara1.p_strJuminCD = m_cABGappeiDoitsuninB.GetDoitsuninDaihyoJuminCD(m_strHonninJuminCD)
                                    Else
                                        '‘Þ”ð—pZ–¯ƒR[ƒh‚ðƒNƒŠƒA‚·‚é
                                        m_strHonninJuminCD = String.Empty
                                    End If
                                Else
                                    '*—š—ð”Ô† 000037 2008/01/17 ’Ç‰ÁŠJŽn
                                    '‘Þ”ð—pZ–¯ƒR[ƒh‚ðƒNƒŠƒA‚·‚é
                                    m_strHonninJuminCD = String.Empty
                                    '*—š—ð”Ô† 000037 2008/01/17 ’Ç‰ÁI—¹
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
                    #End Region

                    #Region " Z–¯ƒR[ƒhƒZƒbƒg(SetJuminCD) "
                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     Z–¯ƒR[ƒhƒZƒbƒgi“à•”ˆ—j
                        '* 
                        '* \•¶           Private Sub SetJuminCD(ByRef csDataSet As DataSet)
                        '* 
                        '* ‹@”\@@    @@Z–¯ƒR[ƒhƒZƒbƒg
                        '* 
                        '* ˆø”           csDataSet@F@ˆ¶–¼ƒf[ƒ^ƒZƒbƒg
                        '* 
                        '* –ß‚è’l         ‚È‚µ
                        '************************************************************************************************
                        Private Sub SetJuminCD(ByRef csDataSet As DataSet)
                            Const THIS_METHOD_NAME As String = "SetJuminCD"
                            Dim intCnt As Integer

                            Try
                                ' ƒfƒoƒbƒOƒƒOo—Í
                                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                '‘Þ”ð‚µ‚½Z–¯ƒR[ƒh‚ª‘¶Ý‚·‚éê‡‚ÍAã‘‚«‚·‚é
                                If (m_strHonninJuminCD <> String.Empty) Then

                                    'ƒe[ƒuƒ‹–¼‚É‚æ‚Á‚Äê‡•ª‚¯‚ðs‚¤(ƒe[ƒuƒ‹‚Í•K‚¸‚P‚Â‚µ‚©‚È‚¢)
                                    Select Case csDataSet.Tables(0).TableName
                                        Case ABAtena1Entity.TABLE_NAME, ABAtena1KobetsuEntity.TABLE_NAME, ABAtena1HyojunEntity.TABLE_NAME, ABAtena1KobetsuHyojunEntity.TABLE_NAME
                                            '“¯ˆêl‘ã•\ŽÒŽæ“¾‚ðs‚Á‚½ê‡‚ÍA‘Þ”ð‚µ‚½Z–¯ƒR[ƒh(–{l)‚Åã‘‚«‚·‚é
                                            For intCnt = 0 To csDataSet.Tables(0).Rows.Count - 1
                                                '–{lE‘—•tæi–{ljƒŒƒR[ƒh‚Ì‚Ýã‘‚«‚·‚é
                                                If (CStr(csDataSet.Tables(0).Rows(intCnt).Item(ABAtena1Entity.DAINOKB)) = ABConstClass.DAINOKB_HONNIN) OrElse
                                                    (CStr(csDataSet.Tables(0).Rows(intCnt).Item(ABAtena1Entity.DAINOKB)) = ABConstClass.DAINOKB_H_SFSK) Then
                                                    csDataSet.Tables(0).Rows(intCnt).Item(ABAtena1Entity.JUMINCD) = m_strHonninJuminCD
                                                End If
                                            Next

                                        Case Else
                                            '“¯ˆêl‘ã•\ŽÒŽæ“¾‚ðs‚Á‚½ê‡‚ÍA‘Þ”ð‚µ‚½Z–¯ƒR[ƒh(–{l)‚Åã‘‚«‚·‚é
                                            For intCnt = 0 To csDataSet.Tables(0).Rows.Count - 1
                                                csDataSet.Tables(0).Rows(intCnt).Item(ABAtenaEntity.JUMINCD) = m_strHonninJuminCD
                                            Next

                                    End Select
                                Else
                                    '‰½‚à‚µ‚È‚¢
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
                    #End Region
                        '*—š—ð”Ô† 000031 2007/07/28 ’Ç‰ÁI—¹

                        '*—š—ð”Ô† 000032 2007/09/04 ’Ç‰ÁŠJŽn
                    #Region " ŒŸõƒJƒi©–¼EŒŸõƒJƒi–¼EŒŸõƒJƒi–¼•ÒW(HenshuSearchKana)"
                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     ŒŸõƒJƒi©–¼EŒŸõƒJƒi–¼EŒŸõƒJƒi–¼•ÒW
                        '* 
                        '* \•¶           Private Function HenshuSearchKana(ByRef cSearchKey As ABAtenaSearchKey,
                        '*                                                  ByRef blnHommyoYusen As Boolean) As ABAtenaSearchKey 
                        '* 
                        '* ‹@”\@@    @ ˆ¶–¼ŒŸõ‚ÌƒJƒi©–¼‚ð•W€Žd—l‚ÆŠO‘l–{–¼ŒŸõ‹@”\—p‚É•ÒW‚·‚é
                        '* 
                        '* ˆø”           ABAtenaSearchKey@F@ˆ¶–¼ŒŸõƒL[ƒpƒ‰ƒ[ƒ^
                        '* 
                        '* –ß‚è’l         ABAtenaSearchKey@F@ˆ¶–¼ŒŸõƒL[ƒpƒ‰ƒ[ƒ^
                        '************************************************************************************************
                        <SecuritySafeCritical>
                        Private Function HenshuSearchKana(ByVal cSearchKey As ABAtenaSearchKey,
                                                            ByVal blnHommyoYusen As Boolean) As ABAtenaSearchKey
                            Const THIS_METHOD_NAME As String = "HenshuSearchKana"

                            Dim cSearch_Param As ABAtenaSearchKey 'ˆ¶–¼ŒŸõƒL[ƒpƒ‰ƒ[ƒ^
                            Dim HenshuKanaSeiMei As String = String.Empty  '•ÒWŒŸõ—pƒJƒi©–¼(‰p•¶Žš‚Í‘å•¶Žš‚ÅŠi”[‚·‚é‚±‚Æ)
                            Dim HenshuKanaSei As String = String.Empty     '•ÒWŒŸõ—pƒJƒi©(‰p•¶Žš‚Í‘å•¶Žš‚ÅŠi”[‚·‚é‚±‚Æ)
                            Dim HenshuKanaMei As String = String.Empty     '•ÒWŒŸõ—pƒJƒi–¼(‰p•¶Žš‚Í‘å•¶Žš‚ÅŠi”[‚·‚é‚±‚Æ)
                            '* —š—ð”Ô† 000034 2007/10/10 ’Ç‰ÁŠJŽn
                            Dim HenshuKanaSei2 As String = String.Empty    '•ÒWŒŸõ—pƒJƒi©‚Q(‰p•¶Žš‚Í‘å•¶Žš‚ÅŠi”[‚·‚é‚±‚Æ)
                            Dim cuString As New USStringClass              'ƒ~ƒhƒ‹ƒl[ƒ€“™´‰¹‰»
                            '* —š—ð”Ô† 000034 2007/10/10 ’Ç‰ÁI—¹

                            Try
                                ' ƒfƒoƒbƒOƒƒOo—Í
                                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                'ˆ¶–¼ŒŸõƒL[ƒpƒ‰ƒ[ƒ^‚ðƒRƒs[
                                cSearch_Param = cSearchKey

                                'ŠO‘l–{–¼ŒŸõ‹@”\‰ŠúÝ’è‚ðˆ¶–¼ŒŸõƒL[ƒpƒ‰ƒ[ƒ^‚ÉÝ’è
                                cSearch_Param.p_enGaikokuHommyoKensaku = FrnHommyoKensakuType.Tsusho

                                '•W€Žd—l‚Ìê‡‚Í‰½‚à•ÒW‚¹‚¸‚É‚»‚Ì‚Ü‚Ü•Ô‚·
                                'ŠO‘l–{–¼—DæŒŸõ‹@”\‚ª“±“ü‚³‚ê‚½Žs’¬‘º‚Í
                                '‚c‚a€–Ú‚ªê—p‚È‚Ì‚Å(ŒŸõ—pƒJƒi©–¼EŒŸõ—pƒJƒi©EŒŸõ—pƒJƒi–¼EŒŸõ—pŠ¿Žš–¼Ì‚ð‚»‚ê‚¼‚êÄƒZƒbƒg)
                                If (m_cURKanriJohoB.GetFrn_HommyoKensaku_Param() = 2) Then
                                    'ŠO‘l–{–¼ŒŸõ‹@”\‚ðˆ¶–¼ŒŸõƒL[ƒpƒ‰ƒ[ƒ^‚ÉÝ’è
                                    cSearch_Param.p_enGaikokuHommyoKensaku = FrnHommyoKensakuType.Tsusho_Seishiki
                                    If (blnHommyoYusen = True) Then
                                        'ŒŸõƒpƒ‰ƒ[ƒ^‚Ì•ÒW
                                        '*—š—ð”Ô† 000036 2007/11/06 ’Ç‰ÁŠJŽn
                                        ' ŒŸõƒJƒi©–¼‚ª—L‚èAŒŸõƒJƒi©‚ª–³‚µ‚Ìê‡AŒŸõƒJƒi©–¼‚ÍŒŸõƒJƒi©‚Æ“¯—l‚Ìˆµ‚¢‚ð‚·‚é
                                        If (cSearchKey.p_strSearchKanaSeiMei <> String.Empty AndAlso
                                            cSearchKey.p_strSearchKanaSei = String.Empty) Then
                                            cSearchKey.p_strSearchKanaSei = cSearchKey.p_strSearchKanaSeiMei.ToUpper()
                                        End If
                                        ''ŒŸõƒJƒi©–¼‚ðŒŸõƒJƒi©‚ÌŒŸõƒL[ƒpƒ‰ƒ[ƒ^‚Æ‚µ‚ÄƒZƒbƒg
                                        'If (cSearchKey.p_strSearchKanaSeiMei <> String.Empty) Then
                                        '    HenshuKanaSei = cSearchKey.p_strSearchKanaSeiMei.ToUpper()
                                        'End If
                                        '*—š—ð”Ô† 000036 2007/11/06 ’Ç‰ÁI—¹
                                        'ŒŸõƒJƒi©‚ðŒŸõƒJƒi©‚ÌŒŸõƒL[ƒpƒ‰ƒ[ƒ^‚Æ‚µ‚ÄƒZƒbƒg
                                        If (cSearchKey.p_strSearchKanaSei <> String.Empty) Then
                                            '*—š—ð”Ô† 000036 2007/11/06 C³ŠJŽn
                                            ' ŒŸõ—pƒJƒi©‚ÌƒAƒ‹ƒtƒ@ƒxƒbƒg‚ð‘å•¶Žš‚É•ÏŠ·‚·‚é
                                            HenshuKanaSei = cSearchKey.p_strSearchKanaSei.ToUpper()
                                            ''ŒŸõƒJƒi©‚Ì•¶Žš‚ÌÅŒã‚É"%"‚ð•K‚¸•t‰Á‚·‚é
                                            'If (InStr(cSearchKey.p_strSearchKanaSei, "%") = cSearchKey.p_strSearchKanaSei.Length) Then
                                            '    HenshuKanaSei = cSearchKey.p_strSearchKanaSei.ToUpper()
                                            'Else
                                            '    HenshuKanaSei = cSearchKey.p_strSearchKanaSei.ToUpper() + "%"
                                            'End If
                                            '*—š—ð”Ô† 000036 2007/11/06 C³I—¹
                                        End If
                                        'ƒJƒi©‚ÆƒJƒi–¼‚ª‚ ‚éê‡CŒ‹‡‚µ‚ÄŒŸõƒJƒi©‚ÌŒŸõƒL[ƒpƒ‰ƒ[ƒ^‚Æ‚µ‚ÄƒZƒbƒg
                                        '‘S‚Ä‚ÌŒŸõƒJƒi€–Ú‚ÅŒŸõ‚ª‚©‚¯‚ç‚ê‚½ê‡‚Í‚±‚ÌŒŸõƒL[‚ªƒZƒbƒg‚³‚ê‚é
                                        If (cSearchKey.p_strSearchKanaSei <> String.Empty AndAlso cSearchKey.p_strSearchKanaMei <> String.Empty) Then
                                            '* —š—ð”Ô† 000034 2007/10/10 ’Ç‰ÁŠJŽn
                                            ' ƒJƒi–¼‚Ìæ“ª•¶Žš‚ª"³"‚Ìê‡‚Ì‚Ý"µ"‚É’uŠ·‚µ‚ÄŒŸõ—pƒJƒi©‚Q‚ð¶¬‚·‚é
                                            If (cSearchKey.p_strSearchKanaMei.StartsWith("³")) Then
                                                ' ƒJƒi–¼‚ÉŠÜ‚Ü‚ê‚éƒ~ƒhƒ‹ƒl[ƒ€“™‚Å‚àŒŸõƒqƒbƒg‚·‚é‚æ‚¤‚ÉƒXƒy[ƒX‚ª‚ ‚éê‡‚ÍƒXƒy[ƒXœ‹Ž‚µ´‰¹‰»‚ðs‚¤
                                                If (InStr(cSearchKey.p_strSearchKanaMei, " ") <> 0) Then
                                                    HenshuKanaSei2 = HenshuKanaSei + cuString.ToKanaKey(Replace(cSearchKey.p_strSearchKanaMei, "³", "µ", 1, 1).Replace(" ", String.Empty)).ToUpper()
                                                Else
                                                    HenshuKanaSei2 = HenshuKanaSei + Replace(cSearchKey.p_strSearchKanaMei, "³", "µ", 1, 1).ToUpper()
                                                End If
                                            End If
                                            ' ƒJƒi–¼‚ÉŠÜ‚Ü‚ê‚éƒ~ƒhƒ‹ƒl[ƒ€“™‚Å‚àŒŸõƒqƒbƒg‚·‚é‚æ‚¤‚ÉƒXƒy[ƒX‚ª‚ ‚éê‡‚ÍƒXƒy[ƒXœ‹Ž‚µ´‰¹‰»‚ðs‚¤
                                            If (InStr(cSearchKey.p_strSearchKanaMei, " ") <> 0) Then
                                                HenshuKanaSei = HenshuKanaSei + cuString.ToKanaKey(cSearchKey.p_strSearchKanaMei.Replace(" ", String.Empty)).ToUpper()
                                            Else
                                                HenshuKanaSei = HenshuKanaSei + cSearchKey.p_strSearchKanaMei.ToUpper()
                                            End If
                                            'HenshuKanaSei = HenshuKanaSei + cSearchKey.p_strSearchKanaMei.ToUpper()
                                            '* —š—ð”Ô† 000034 2007/10/10 ’Ç‰ÁI—¹
                                        End If
                                        'ƒJƒi–¼‚Ì‚Ý‚Ìê‡Cæ“ª‚É“‚ð‰Á‚¦ŒŸõƒJƒi©‚ÌŒŸõƒL[ƒpƒ‰ƒ[ƒ^‚Æ‚µ‚ÄƒZƒbƒg
                                        If (cSearchKey.p_strSearchKanaSei = String.Empty AndAlso cSearchKey.p_strSearchKanaMei <> String.Empty) Then
                                            '* —š—ð”Ô† 000034 2007/10/10 ’Ç‰ÁŠJŽn
                                            ' ƒJƒi–¼‚Ìæ“ª•¶Žš‚ª"³"‚Ìê‡‚Ì‚Ý"µ"‚É’uŠ·‚µ‚ÄŒŸõ—pƒJƒi©‚Q‚ð¶¬‚·‚é
                                            If (cSearchKey.p_strSearchKanaMei.StartsWith("³")) Then
                                                ' ƒJƒi–¼‚ÉŠÜ‚Ü‚ê‚éƒ~ƒhƒ‹ƒl[ƒ€“™‚Å‚àŒŸõƒqƒbƒg‚·‚é‚æ‚¤‚ÉƒXƒy[ƒX‚ª‚ ‚éê‡‚ÍƒXƒy[ƒXœ‹Ž‚µ´‰¹‰»‚ðs‚¤
                                                If (InStr(cSearchKey.p_strSearchKanaMei, " ") <> 0) Then
                                                    HenshuKanaSei2 = "%" + cuString.ToKanaKey(Replace(cSearchKey.p_strSearchKanaMei, "³", "µ", 1, 1).Replace(" ", String.Empty)).ToUpper()
                                                Else
                                                    HenshuKanaSei2 = "%" + Replace(cSearchKey.p_strSearchKanaMei, "³", "µ", 1, 1).ToUpper()
                                                End If
                                            End If
                                            ' ƒJƒi–¼‚ÉŠÜ‚Ü‚ê‚éƒ~ƒhƒ‹ƒl[ƒ€“™‚Å‚àŒŸõƒqƒbƒg‚·‚é‚æ‚¤‚ÉƒXƒy[ƒX‚ª‚ ‚éê‡‚ÍƒXƒy[ƒXœ‹Ž‚µ´‰¹‰»‚ðs‚¤
                                            If (InStr(cSearchKey.p_strSearchKanaMei, " ") <> 0) Then
                                                HenshuKanaSei = "%" + cuString.ToKanaKey(cSearchKey.p_strSearchKanaMei.Replace(" ", String.Empty)).ToUpper()
                                            Else
                                                HenshuKanaSei = "%" + cSearchKey.p_strSearchKanaMei.ToUpper()
                                            End If
                                            'HenshuKanaSei = "%" + cSearchKey.p_strSearchKanaMei.ToUpper()
                                            '* —š—ð”Ô† 000034 2007/10/10 ’Ç‰ÁI—¹
                                        End If
                                        'ŒŸõ—pƒJƒi©‚Q‚É•ÒW‚µ‚½ŒŸõƒL[‚ðŒŸõƒL[ƒpƒ‰ƒ[ƒ^‚ÉƒZƒbƒg
                                        '–{–¼‚ÌŒŸõƒpƒ‰ƒ[ƒ^‚ðƒZƒbƒg
                                        cSearch_Param.p_strSearchKanaSeiMei = String.Empty
                                        cSearch_Param.p_strSearchKanaSei = HenshuKanaSei                            'ƒJƒi‚ÍŒŸõƒJƒi©‚Ì€–Ú‚Ì‚Ý‚ÅŒŸõ
                                        cSearch_Param.p_strSearchKanaMei = String.Empty
                                        cSearch_Param.p_strSearchKanaSei2 = HenshuKanaSei2                    'ŒŸõ—pƒJƒi©‚Q
                                        'ŒŸõŠ¿Žš–¼Ì
                                        cSearch_Param.p_strKanjiMeisho2 = cSearchKey.p_strSearchKanjiMeisho         'Š¿Žš–¼Ì‚Q‚ÉŒŸõ—pŠ¿Žš–¼Ì‚ðƒZƒbƒg
                                        cSearch_Param.p_strSearchKanjiMeisho = String.Empty
                                    Else
                                        'ŒŸõƒpƒ‰ƒ[ƒ^‚Ì•ÒW
                                        '*—š—ð”Ô† 000036 2007/11/06 ’Ç‰ÁŠJŽn
                                        ' ŒŸõƒJƒi©–¼‚ª—L‚èAŒŸõƒJƒi©‚ª–³‚µ‚Ìê‡AŒŸõƒJƒi©–¼‚ÍŒŸõƒJƒi©‚Æ“¯—l‚Ìˆµ‚¢‚ð‚·‚é
                                        If (cSearchKey.p_strSearchKanaSeiMei <> String.Empty AndAlso
                                            cSearchKey.p_strSearchKanaSei = String.Empty) Then
                                            cSearchKey.p_strSearchKanaSei = cSearchKey.p_strSearchKanaSeiMei.ToUpper()
                                        End If
                                        ''ŒŸõƒJƒi©–¼‚ðŒŸõƒJƒi©–¼‚ÌŒŸõƒL[ƒpƒ‰ƒ[ƒ^‚Æ‚µ‚ÄƒZƒbƒg
                                        'If (cSearchKey.p_strSearchKanaSeiMei <> String.Empty) Then
                                        '    HenshuKanaSeiMei = cSearchKey.p_strSearchKanaSeiMei.ToUpper()
                                        'End If
                                        '*—š—ð”Ô† 000036 2007/11/06 ’Ç‰ÁI—¹
                                        'ŒŸõƒJƒi©‚ª‚ ‚éê‡‚ÍŒŸõƒJƒi©–¼‚Éƒpƒ‰ƒ[ƒ^‚ðƒZƒbƒg
                                        If (cSearchKey.p_strSearchKanaSei <> String.Empty) Then
                                            '*—š—ð”Ô† 000036 2007/11/06 C³ŠJŽn
                                            ' ŒŸõƒJƒi©‚ÆŒŸõƒJƒi–¼‚Ì—¼•û‚É"%"‚ª–³‚¢ê‡‚ÍŠ®‘Sˆê’v
                                            If (InStr(cSearchKey.p_strSearchKanaSei, "%") = 0 AndAlso
                                                InStr(cSearchKey.p_strSearchKanaMei, "%") = 0) Then
                                                ' Š®‘Sˆê’vŽž‚Ì‚ÝŒŸõƒJƒi©–¼‚Æ‚µ‚ÄŒ‹‡‚·‚é‚Ì‚ÅA´‰¹‰»‚ðs‚¤
                                                HenshuKanaSeiMei = cuString.ToKanaKey(cSearchKey.p_strSearchKanaSei + cSearchKey.p_strSearchKanaMei).ToUpper()
                                            Else
                                                ' "%"‚ª‚ ‚éê‡‚Í‚»‚Ì‚Ü‚ÜŒŸõƒJƒi©–¼‚É‘å•¶Žš‰»‚µ‚ÄƒZƒbƒg
                                                ' ‚½‚¾‚µ"%"‚Ì‚Ý‚Ìê‡‚Í‰½‚àƒZƒbƒg‚µ‚È‚¢
                                                If (cSearchKey.p_strSearchKanaSei <> "%") Then
                                                    HenshuKanaSeiMei = cSearchKey.p_strSearchKanaSei.ToUpper()
                                                End If
                                                'ŒŸõƒJƒi–¼‚ðƒAƒ‹ƒtƒ@ƒxƒbƒg‘å•¶Žš‰»‚µ‚ÄƒZƒbƒg
                                                If (cSearchKey.p_strSearchKanaMei <> String.Empty) Then
                                                    HenshuKanaMei = cSearchKey.p_strSearchKanaMei.ToUpper()
                                                End If
                                            End If
                                            ''ŒŸõƒJƒi©‚Ì•¶Žš‚ÌÅŒã‚É"%"‚ð•K‚¸•t‰Á‚µCŒŸõƒJƒi©–¼‚ÌŒŸõƒL[ƒpƒ‰ƒ[ƒ^‚Æ‚µ‚ÄƒZƒbƒg
                                            'If (InStr(cSearchKey.p_strSearchKanaSei, "%") = cSearchKey.p_strSearchKanaSei.Length) Then
                                            '    HenshuKanaSeiMei = cSearchKey.p_strSearchKanaSei.ToUpper()
                                            'Else
                                            '    HenshuKanaSeiMei = cSearchKey.p_strSearchKanaSei.ToUpper() + "%"
                                            'End If
                                            ''ŒŸõƒJƒi–¼‚ðƒAƒ‹ƒtƒ@ƒxƒbƒg‘å•¶Žš‰»‚µ‚ÄƒZƒbƒg
                                            'If (cSearchKey.p_strSearchKanaMei <> String.Empty) Then
                                            '    HenshuKanaMei = cSearchKey.p_strSearchKanaMei.ToUpper()
                                            'End If
                                            '*—š—ð”Ô† 000036 2007/11/06 C³I—¹
                                        Else
                                            'ŒŸõƒJƒi–¼
                                            HenshuKanaMei = cSearch_Param.p_strSearchKanaMei.ToUpper()
                                        End If
                                        'ŒŸõ—pƒJƒi©‚Q‚É•ÒW‚µ‚½ŒŸõƒL[‚ðŒŸõƒL[ƒpƒ‰ƒ[ƒ^‚ÉƒZƒbƒg
                                        '’ÊÌ–¼‚ÌŒŸõƒpƒ‰ƒ[ƒ^‚ðƒZƒbƒg
                                        cSearch_Param.p_strSearchKanaSeiMei = HenshuKanaSeiMei                      'ƒJƒi©–¼CƒJƒi©
                                        cSearch_Param.p_strSearchKanaSei = String.Empty
                                        cSearch_Param.p_strSearchKanaMei = HenshuKanaMei                            'ƒJƒi–¼
                                        cSearch_Param.p_strSearchKanaSei2 = String.Empty                         'ŒŸõ—pƒJƒi©‚Qi‹ó‚É‚·‚éj
                                        'ŒŸõŠ¿Žš–¼Ì
                                        cSearch_Param.p_strSearchKanjiMeisho = cSearchKey.p_strSearchKanjiMeisho    'ŒŸõ—pŠ¿Žš–¼Ì‚ÉŒŸõ—pŠ¿Žš–¼Ì‚ðƒZƒbƒg
                                        cSearch_Param.p_strKanjiMeisho2 = String.Empty
                                    End If
                                    '* —š—ð”Ô† 000034 2007/10/10 ’Ç‰ÁŠJŽn
                                Else
                                    ' •W€Žd—l‚ÌŽs’¬‘º‚É‚¨‚¢‚Ä‚àŒŸõƒJƒi€–Ú‚ÌƒAƒ‹ƒtƒ@ƒxƒbƒg‚Í‘å•¶Žš‚Åˆµ‚¤
                                    cSearch_Param.p_strSearchKanaSeiMei = cSearchKey.p_strSearchKanaSeiMei.ToUpper() 'ƒJƒi©–¼
                                    cSearch_Param.p_strSearchKanaSei = cSearchKey.p_strSearchKanaSei.ToUpper()       'ƒJƒi©
                                    cSearch_Param.p_strSearchKanaMei = cSearchKey.p_strSearchKanaMei.ToUpper()       'ƒJƒi–¼
                                    cSearch_Param.p_strSearchKanaSei2 = String.Empty                              'ŒŸõ—pƒJƒi©‚Qi‹ó‚É‚·‚éj
                                    '* —š—ð”Ô† 000034 2007/10/10 ’Ç‰ÁI—¹
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

                            Return cSearch_Param

                        End Function
                    #End Region
                        '*—š—ð”Ô† 000032 2007/09/04 ’Ç‰ÁI—¹

                        '*—š—ð”Ô† 000040 2008/11/10 ’Ç‰ÁŠJŽn
                    #Region " —˜—p“Í•ÒWˆ—(RiyoTdkHenshu) "
                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     —˜—p“Í•ÒWˆ—
                        '* 
                        '* \•¶           Private Sub RiyoTdkHenshu(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass,
                        '* @@                                     ByVal blnKobetsu As Boolean, 
                        '* @@                                     ByRef csAtenaH As DataSet)
                        '* 
                        '* ‹@”\@@    @ —˜—p“Íƒf[ƒ^‚ðŽæ“¾‚µAˆ¶–¼ƒf[ƒ^ƒZƒbƒg‚ÖƒZƒbƒg‚·‚é
                        '* 
                        '* ˆø”           cAtenaGetPara1 As ABAtenaGetPara1XClass   : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
                        '* @@           blnKobetsu As Boolean                     : ŒÂ•ÊŽ–€”»’èƒtƒ‰ƒO
                        '*                csAtenaH As DataSet                       : –{lƒf[ƒ^
                        '* 
                        '* –ß‚è’l         ‚È‚µ
                        '************************************************************************************************
                        Private Sub RiyoTdkHenshu(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass, ByVal blnKobetsu As Boolean, ByRef csAtenaH As DataSet)
                            Dim cABLTRiyoTdkB As ABLTRiyoTdkBClass                      ' ABeLTAX—˜—p“Íƒ}ƒXƒ^‚c‚`
                            Dim cABLTRiyoTdkParaX As ABLTRiyoTdkParaXClass              ' ABeLTAX—˜—p“Íƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                            Dim csRiyoTdkEntity As DataSet                              ' —˜—p“Íƒf[ƒ^ƒZƒbƒg
                            Dim csRiyoTdkRow As DataRow                                 ' —˜—p“Íƒf[ƒ^ƒZƒbƒg
                            Dim csRow As DataRow
                            '*—š—ð”Ô† 000041 2008/11/17 ’Ç‰ÁŠJŽn
                            Dim csNotRiyouTdkdRows As DataRow()
                            '*—š—ð”Ô† 000041 2008/11/17 ’Ç‰ÁI—¹

                            Try
                                'ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                                m_cfLogClass.DebugStartWrite(m_cfControlData, Me.GetType.Name, System.Reflection.MethodBase.GetCurrentMethod.Name)

                                '*—š—ð”Ô† 000041 2008/11/17 ’Ç‰ÁŠJŽn
                                If Not (cAtenaGetPara1.p_strShiteiYMD = String.Empty) Then
                                    Exit Try
                                Else
                                End If
                                '*—š—ð”Ô† 000041 2008/11/17 ’Ç‰ÁI—¹

                                '*—š—ð”Ô† 000042 2008/11/18 C³ŠJŽn
                                'If (m_blnSelectAll <> ABEnumDefine.AtenaGetKB.KaniOnly AndAlso _
                                '    blnKobetsu = False AndAlso (cAtenaGetPara1.p_strTdkdKB = "1" OrElse cAtenaGetPara1.p_strTdkdKB = "2")) Then
                                If (m_blnSelectAll <> ABEnumDefine.AtenaGetKB.KaniOnly AndAlso
                                    blnKobetsu = False AndAlso m_blnMethodKB <> ABEnumDefine.MethodKB.KB_Kaigo AndAlso
                                    (cAtenaGetPara1.p_strTdkdKB = "1" OrElse cAtenaGetPara1.p_strTdkdKB = "2")) Then
                                    '*—š—ð”Ô† 000042 2008/11/18 C³I—¹
                                    ' ŠÈˆÕ”Å‚Å‚Í‚È‚¢ê‡‚©‚ÂŒÂ•ÊŽ–€Žæ“¾‚µ‚È‚¢ê‡‚©‚Â—˜—p“ÍoŽæ“¾‹æ•ª‚ª"1,2"‚Ìê‡A”[ÅŽÒID‚Æ—˜—pŽÒID‚ðƒZƒbƒg

                                    ' ABeLTAX—˜—p“Íƒ}ƒXƒ^‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                                    cABLTRiyoTdkB = New ABLTRiyoTdkBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)

                                    ' ABeLTAX—˜—p“Íƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                                    cABLTRiyoTdkParaX = New ABLTRiyoTdkParaXClass

                                    ' Žæ“¾ƒf[ƒ^ƒZƒbƒgˆ—
                                    For Each csRow In csAtenaH.Tables(0).Rows

                                        ' —˜—p“Íoƒpƒ‰ƒ[ƒ^ƒZƒbƒg
                                        ' Z–¯ƒR[ƒh
                                        If (m_strHonninJuminCD.Trim = String.Empty) Then
                                            ' Z–¯ƒR[ƒh‚ðƒZƒbƒg
                                            cABLTRiyoTdkParaX.p_strJuminCD = CStr(csRow(ABAtena1Entity.JUMINCD))
                                        Else
                                            ' “¯ˆêl‘ã•\ŽÒƒf[ƒ^‚Ì‚½‚ßA–{lZ–¯ƒR[ƒh‚ðƒZƒbƒg
                                            cABLTRiyoTdkParaX.p_strJuminCD = m_strHonninJuminCD
                                        End If

                                        ' Å–ÚƒR[ƒh:‹Æ–±ƒR[ƒh‚ðƒZƒbƒg
                                        cABLTRiyoTdkParaX.p_strZeimokuCD = cAtenaGetPara1.p_strTdkdZeimokuCD

                                        ' ”pŽ~ƒtƒ‰ƒO:”pŽ~ƒf[ƒ^ˆÈŠO‚ðŽæ“¾
                                        cABLTRiyoTdkParaX.p_blnHaishiFG = False

                                        ' o—Í‹æ•ª:”[ÅŽÒIDA—˜—pŽÒID‚Ì‚Q€–Ú‚ðŽæ“¾
                                        cABLTRiyoTdkParaX.p_strOutKB = "1"

                                        '*—š—ð”Ô† 000051 2020/11/02 ’Ç‰ÁŠJŽn
                                        ' —˜—p‹æ•ªF—˜—p“Ío—˜—p‹æ•ª‚ðƒZƒbƒg
                                        cABLTRiyoTdkParaX.p_strRiyoKB = cAtenaGetPara1.p_strTdkdRiyoKB
                                        '*—š—ð”Ô† 000051 2020/11/02 ’Ç‰ÁI—¹

                                        ' —˜—p“Íoƒf[ƒ^‚ðŽæ“¾
                                        csRiyoTdkEntity = cABLTRiyoTdkB.GetLTRiyoTdkData(cABLTRiyoTdkParaX)

                                        ' —˜—p“Íoƒf[ƒ^‚ð–{lƒf[ƒ^‚ÉƒZƒbƒg
                                        csRow.BeginEdit()
                                        If (csRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).Rows.Count <> 0) Then
                                            csRiyoTdkRow = csRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).Rows(0)

                                            csRow(ABAtena1Entity.NOZEIID) = csRiyoTdkRow(ABLtRiyoTdkEntity.NOZEIID)         ' ”[ÅŽÒID
                                            csRow(ABAtena1Entity.RIYOSHAID) = csRiyoTdkRow(ABLtRiyoTdkEntity.RIYOSHAID)     ' —˜—pŽÒID
                                        Else
                                            csRow(ABAtena1Entity.NOZEIID) = String.Empty                                    ' ”[ÅŽÒID
                                            csRow(ABAtena1Entity.RIYOSHAID) = String.Empty                                  ' —˜—pŽÒID

                                        End If
                                        csRow.EndEdit()
                                    Next csRow

                                    '*—š—ð”Ô† 000041 2008/11/17 ’Ç‰ÁŠJŽn
                                    If (cAtenaGetPara1.p_strTdkdKB = "2") Then
                                        ' –{lƒf[ƒ^‚©‚ç”[ÅŽÒID‚ª‹ó”’‚Ìƒf[ƒ^‚ðŽæ“¾‚·‚é
                                        csNotRiyouTdkdRows = csAtenaH.Tables(0).Select(ABAtena1Entity.NOZEIID + " = ''")

                                        ' ”[ÅŽÒID‚ª‹ó”’‚Ìƒf[ƒ^‚ðíœ‚·‚é
                                        For Each csRow In csNotRiyouTdkdRows
                                            csRow.Delete()
                                        Next
                                    Else
                                    End If
                                    '*—š—ð”Ô† 000041 2008/11/17 ’Ç‰ÁI—¹
                                Else
                                End If

                                ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
                                m_cfLogClass.DebugEndWrite(m_cfControlData, Me.GetType.Name, System.Reflection.MethodBase.GetCurrentMethod.Name)

                            Catch objAppExp As UFAppException
                                ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                                m_cfLogClass.WarningWrite(m_cfControlData,
                                                            "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                                                            "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                            "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" +
                                                            "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                                ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                                Throw

                            Catch objExp As Exception
                                ' ƒGƒ‰[ƒƒOo—Í
                                m_cfLogClass.ErrorWrite(m_cfControlData,
                                                            "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                                                            "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                            "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                                Throw
                            End Try

                        End Sub
                    #End Region

                        '*—š—ð”Ô† 000041 2008/11/17 íœŠJŽn
                    #Region " —˜—p“Íƒf[ƒ^iž‚Ý(RiyoTdkHenshu_Select) "
                        ''************************************************************************************************
                        ''* ƒƒ\ƒbƒh–¼     —˜—p“Í•ÒWˆ—
                        ''* 
                        ''* \•¶           Private Sub RiyoTdkHenshu_Select(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass,
                        ''* @@                                            ByVal blnKobetsu As Boolean, 
                        ''* @@                                            ByRef csAtenaH As DataSet)
                        ''* 
                        ''* ‹@”\@@    @ –{lƒf[ƒ^‚©‚ç”[ÅŽÒID‚ª‘¶Ý‚µ‚È‚¢ƒŒƒR[ƒh‚ðíœ‚·‚é
                        ''* 
                        ''* ˆø”           cAtenaGetPara1 As ABAtenaGetPara1XClass   : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
                        ''* @@           blnKobetsu As Boolean                     : ŒÂ•ÊŽ–€”»’èƒtƒ‰ƒO
                        ''*                csAtenaH As DataSet                       : –{lƒf[ƒ^
                        ''* 
                        ''* –ß‚è’l         ‚È‚µ
                        ''************************************************************************************************
                        'Private Sub RiyoTdkHenshu_Select(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass, ByVal blnKobetsu As Boolean, ByRef csAtena1 As DataSet)
                        '    Dim csRow As DataRow
                        '    Dim csNotRiyouTdkdRows As DataRow()

                        '    Try
                        '        'ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                        '        m_cfLogClass.DebugStartWrite(m_cfControlData, Me.GetType.Name, System.Reflection.MethodBase.GetCurrentMethod.Name)

                        '        If (m_blnSelectAll <> ABEnumDefine.AtenaGetKB.KaniOnly AndAlso _
                        '            blnKobetsu = False AndAlso cAtenaGetPara1.p_strTdkdKB = "2") Then
                        '            ' ŠÈˆÕ”Å‚Å‚Í‚È‚¢ê‡‚©‚ÂŒÂ•ÊŽ–€Žæ“¾‚µ‚È‚¢ê‡‚©‚Â—˜—p“ÍoŽæ“¾‹æ•ª‚ª"2"‚Ìê‡A”[ÅŽÒID‚ª‘¶Ý‚µ‚È‚¢ƒf[ƒ^‚ðíœ‚·‚é

                        '            ' –{lƒf[ƒ^‚©‚ç”[ÅŽÒID‚ª‹ó”’‚Ìƒf[ƒ^‚ðŽæ“¾‚·‚é
                        '            csNotRiyouTdkdRows = csAtena1.Tables(0).Select(ABAtena1Entity.NOZEIID + " = ''")

                        '            ' ”[ÅŽÒID‚ª‹ó”’‚Ìƒf[ƒ^‚ðíœ‚·‚é
                        '            For Each csRow In csNotRiyouTdkdRows
                        '                csRow.Delete()
                        '            Next
                        '        Else
                        '        End If

                        '        ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
                        '        m_cfLogClass.DebugEndWrite(m_cfControlData, Me.GetType.Name, System.Reflection.MethodBase.GetCurrentMethod.Name)

                        '    Catch objAppExp As UFAppException
                        '        ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                        '        m_cfLogClass.WarningWrite(m_cfControlData, _
                        '                                    "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                        '                                    "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                        '                                    "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                        '                                    "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                        '        ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                        '        Throw

                        '    Catch objExp As Exception
                        '        ' ƒGƒ‰[ƒƒOo—Í
                        '        m_cfLogClass.ErrorWrite(m_cfControlData, _
                        '                                    "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                        '                                    "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                        '                                    "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                        '        Throw
                        '    End Try

                        'End Sub
                    #End Region
                        '*—š—ð”Ô† 000041 2008/11/17 íœI—¹
                        '*—š—ð”Ô† 000040 2008/11/10 ’Ç‰ÁI—¹

                        '*—š—ð”Ô† 000052 2023/03/10 ’Ç‰ÁŠJŽn
                    #Region " ŠÈˆÕˆ¶–¼Žæ“¾‚P_•W€”Å(AtenaGet1_Hyojun) "
                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     ŠÈˆÕˆ¶–¼Žæ“¾‚P_•W€”Å
                        '* 
                        '* \•¶           Public Function AtenaGet1_Hyojun(ByVal cAtenaGetPara1 As ABAtenaGetPara1) As DataSet
                        '* 
                        '* ‹@”\@@    @@ˆ¶–¼‚ðŽæ“¾‚·‚é
                        '* 
                        '* ˆø”           cAtenaGetPara1   : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
                        '* 
                        '* –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
                        '************************************************************************************************
                        Public Overloads Function AtenaGet1_Hyojun(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet

                            Return AtenaGet1_Hyojun(cAtenaGetPara1, False)

                        End Function

                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     ŠÈˆÕˆ¶–¼Žæ“¾‚P_•W€”Å
                        '* 
                        '* \•¶           Public Function AtenaGet1_Hyoujn(ByVal cAtenaGetPara1 As ABAtenaGetPara1) As DataSet
                        '* 
                        '* ‹@”\@@    @@ˆ¶–¼‚ðŽæ“¾‚·‚é
                        '* 
                        '* ˆø”           cAtenaGetPara1   : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
                        '* @@           blnKobetsu       : ŒÂ•ÊŽæ“¾(True:ŠeŒÂ•Êƒ}ƒXƒ^‚æ‚èƒf[ƒ^‚ðŽæ“¾‚·‚é)
                        '* 
                        '* –ß‚è’l         DataSet(ABAtena1Kobetsu) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
                        '************************************************************************************************
                        Public Overloads Function AtenaGet1_Hyojun(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass,
                                                                    ByVal blnKobetsu As Boolean) As DataSet

                            Return AtenaGetMain(cAtenaGetPara1, blnKobetsu, ABEnumDefine.MethodKB.KB_AtenaGet1, ABEnumDefine.HyojunKB.KB_Hyojun)

                        End Function
                    #End Region

                    #Region " ŠÈˆÕˆ¶–¼Žæ“¾‚Q_•W€”Å(AtenaGet2_Hyojun) "
                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     ŠÈˆÕˆ¶–¼Žæ“¾‚Q_•W€”Å
                        '* 
                        '* \•¶           Public Function AtenaGet2_Hyojun(ByVal cAtenaGetPara1 As ABAtenaGetPara1) As DataSet
                        '* 
                        '* ‹@”\@@    @@ˆ¶–¼‚ðŽæ“¾‚·‚é
                        '* 
                        '* ˆø”           cAtenaGetPara1   : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
                        '* 
                        '* –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
                        '************************************************************************************************
                        Public Function AtenaGet2_Hyojun(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet
                            Const THIS_METHOD_NAME As String = "AtenaGet2_Hyojun"
                            Dim csAtenaEntity As DataSet                        'ˆ¶–¼Entity
                            Dim blnAtenaSelectAll As ABEnumDefine.AtenaGetKB
                            Dim blnAtenaKani As Boolean
                            Dim blnRirekiSelectAll As ABEnumDefine.AtenaGetKB
                            Dim blnRirekiKani As Boolean

                            Try
                                ' ƒfƒoƒbƒOƒƒOo—Í
                                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                '‚q‚c‚aÚ‘±
                                If m_blnBatchRdb = False Then
                                    ' RDBƒAƒNƒZƒXƒƒOo—Í
                                    m_cfLogClass.RdbWrite(m_cfControlData,
                                                                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                                    "yŽÀsƒƒ\ƒbƒh–¼:Connectz")
                                    m_cfRdbClass.Connect()
                                End If

                                Try
                                    'ƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ð•Û‘¶
                                    If Not (Me.m_cABAtenaB Is Nothing) Then
                                        blnAtenaSelectAll = Me.m_cABAtenaB.m_blnSelectAll
                                        blnAtenaKani = Me.m_cABAtenaB.m_blnSelectCount
                                        Me.m_cABAtenaB.m_blnSelectAll = ABEnumDefine.AtenaGetKB.SelectAll
                                        Me.m_cABAtenaB.m_blnSelectCount = False
                                    End If
                                    If Not (Me.m_cABAtenaRirekiB Is Nothing) Then
                                        blnRirekiSelectAll = Me.m_cABAtenaRirekiB.m_blnSelectAll
                                        blnRirekiKani = Me.m_cABAtenaRirekiB.m_blnSelectCount
                                        Me.m_cABAtenaRirekiB.m_blnSelectAll = ABEnumDefine.AtenaGetKB.SelectAll
                                        Me.m_cABAtenaRirekiB.m_blnSelectCount = False

                                    End If

                                    ' ŠÈˆÕˆ¶–¼Žæ“¾‚Q(“à•”ˆ—)ƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
                                    csAtenaEntity = Me.GetAtena2(cAtenaGetPara1, ABEnumDefine.HyojunKB.KB_Hyojun)

                                    'ƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ðŒ³‚É‚à‚Ç‚·
                                    If Not (Me.m_cABAtenaB Is Nothing) Then
                                        Me.m_cABAtenaB.m_blnSelectAll = blnAtenaSelectAll
                                        Me.m_cABAtenaB.m_blnSelectCount = blnAtenaKani
                                    End If
                                    If Not (Me.m_cABAtenaRirekiB Is Nothing) Then
                                        Me.m_cABAtenaRirekiB.m_blnSelectAll = blnRirekiSelectAll
                                        Me.m_cABAtenaRirekiB.m_blnSelectCount = blnRirekiKani
                                    End If

                                Catch objRdbTimeOutExp As UFRdbTimeOutException    ' UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
                                    ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                                    m_cfLogClass.WarningWrite(m_cfControlData,
                                                            "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                            "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                            "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objRdbTimeOutExp.p_strErrorCode + "z" +
                                                            "yƒ[ƒjƒ“ƒO“à—e:" + objRdbTimeOutExp.Message + "z")
                                    ' UFAppException‚ðƒXƒ[‚·‚é
                                    Throw New UFAppException(objRdbTimeOutExp.Message, objRdbTimeOutExp.p_intErrorCode, objRdbTimeOutExp)

                                Catch
                                    ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[
                                    Throw

                                Finally
                                    ' RDBØ’f
                                    If m_blnBatchRdb = False Then
                                        ' RDBƒAƒNƒZƒXƒƒOo—Í
                                        m_cfLogClass.RdbWrite(m_cfControlData,
                                                                "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                                "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                                "yŽÀsƒƒ\ƒbƒh–¼:Disconnectz")
                                        m_cfRdbClass.Disconnect()
                                    End If

                                End Try

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

                            Return csAtenaEntity

                        End Function
                    #End Region

                    #Region " ‰îŒì—pˆ¶–¼Žæ“¾_•W€”Å(GetKaigoAtena_Hyojun) "
                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     ‰îŒì—pˆ¶–¼Žæ“¾_•W€”Å
                        '* 
                        '* \•¶           Public Function GetKaigoAtena_Hyojun(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet
                        '* 
                        '* ‹@”\@@    @@ˆ¶–¼‚ðŽæ“¾‚·‚é
                        '* 
                        '* ˆø”           cAtenaGetPara1   : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
                        '* 
                        '* –ß‚è’l         DataSet : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
                        '************************************************************************************************
                        Public Function GetKaigoAtena_Hyojun(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet
                            Dim blnAtenaSelectAll As ABEnumDefine.AtenaGetKB
                            Dim csAtenaEntity As DataSet                        '‰îŒì—pˆ¶–¼Entity

                            Try
                                'ƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ð•Û‘¶
                                blnAtenaSelectAll = m_blnSelectAll
                                m_blnSelectAll = ABEnumDefine.AtenaGetKB.SelectAll
                                If Not (Me.m_cABAtenaB Is Nothing) Then
                                    Me.m_cABAtenaB.m_blnSelectAll = ABEnumDefine.AtenaGetKB.SelectAll
                                End If
                                If Not (Me.m_cABAtenaRirekiB Is Nothing) Then
                                    Me.m_cABAtenaRirekiB.m_blnSelectAll = ABEnumDefine.AtenaGetKB.SelectAll
                                End If

                                'ˆ¶–¼Žæ“¾ƒƒCƒ“ƒƒ\ƒbƒh‚ÌŒÄo‚µiˆø”FŽæ“¾ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒXAŒÂ•ÊŽ–€ƒf[ƒ^Žæ“¾ƒtƒ‰ƒOAŒÄ‚Ño‚µƒƒ\ƒbƒh‹æ•ªj
                                csAtenaEntity = AtenaGetMain(cAtenaGetPara1, False, ABEnumDefine.MethodKB.KB_Kaigo, ABEnumDefine.HyojunKB.KB_Hyojun)

                                'ƒRƒ“ƒXƒgƒ‰ƒNƒ^‚ÌÝ’è‚ðŒ³‚É‚à‚Ç‚·
                                m_blnSelectAll = blnAtenaSelectAll
                                If Not (Me.m_cABAtenaB Is Nothing) Then
                                    Me.m_cABAtenaB.m_blnSelectAll = blnAtenaSelectAll
                                End If
                                If Not (Me.m_cABAtenaRirekiB Is Nothing) Then
                                    Me.m_cABAtenaRirekiB.m_blnSelectAll = m_blnSelectAll
                                End If

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
                                Throw objExp
                            End Try

                            Return csAtenaEntity

                        End Function
                    #End Region

                    #Region " ”N‹àˆ¶–¼Žæ“¾_•W€”Å(NenkinAtenaGet_Hyojun) "
                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     ”N‹àˆ¶–¼Žæ“¾_•W€”Å
                        '* 
                        '* \•¶           Public Function NenkinAtenaGet_Hyojun(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet
                        '* 
                        '* ‹@”\@@       ”N‹àˆ¶–¼î•ñ‚ðŽæ“¾‚·‚é
                        '* 
                        '* ˆø”           cAtenaGetPara1    : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
                        '* 
                        '* –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
                        '************************************************************************************************
                        Public Overloads Function NenkinAtenaGet_Hyojun(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet

                            '”N‹àˆ¶–¼ƒQƒbƒg‚æ‚è”N‹àˆ¶–¼î•ñ‚ðŽæ“¾‚·‚é
                            Return NenkinAtenaGet_Hyojun(cAtenaGetPara1, ABEnumDefine.NenkinAtenaGetKB.Version01)
                        End Function

                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     ”N‹àˆ¶–¼Žæ“¾_•W€”Å
                        '* 
                        '* \•¶           Public Function NenkinAtenaGet_Hyojun(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet
                        '* 
                        '* ‹@”\@@       ”N‹àˆ¶–¼î•ñ‚ðŽæ“¾‚·‚é
                        '* 
                        '* ˆø”           cAtenaGetPara1    : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
                        '* 
                        '* –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
                        '************************************************************************************************
                        Public Overloads Function NenkinAtenaGet_Hyojun(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass, ByVal intNenkinAtenaGetKB As Integer) As DataSet

                            Return GetNenkinAtena(cAtenaGetPara1, intNenkinAtenaGetKB, ABEnumDefine.HyojunKB.KB_Hyojun)

                        End Function
                    #End Region

                    #Region " ‘•Ûˆ¶–¼—š—ðŽæ“¾_•W€”Å(KokuhoAtenaRirekiGet_Hyojun) "
                        '************************************************************************************************
                        '* ƒƒ\ƒbƒh–¼     ‘•Ûˆ¶–¼—š—ðŽæ“¾_•W€”Å
                        '* 
                        '* \•¶           Public Function KokuhoAtenaRirekiGet_Hyojun(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet
                        '* 
                        '* ‹@”\@@       ‘•Ûˆ¶–¼—š—ðƒf[ƒ^‚ðŽæ“¾‚·‚é
                        '* 
                        '* ˆø”           cAtenaGetPara1    : ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^
                        '* 
                        '* –ß‚è’l         DataSet(ABAtena1) : Žæ“¾‚µ‚½ˆ¶–¼î•ñ
                        '************************************************************************************************
                        Public Function KokuhoAtenaRirekiGet_Hyojun(ByVal cAtenaGetPara1 As ABAtenaGetPara1XClass) As DataSet
                            Const THIS_METHOD_NAME As String = "KokuhoAtenaRirekiGet_Hyojun"
                            Dim csAtena1Entity As DataSet                       'ˆ¶–¼1Entity

                            Try
                                ' ƒfƒoƒbƒOƒƒOo—Í
                                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                '‚q‚c‚aÚ‘±
                                If m_blnBatchRdb = False Then
                                    ' RDBƒAƒNƒZƒXƒƒOo—Í
                                    m_cfLogClass.RdbWrite(m_cfControlData,
                                                                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                                    "yŽÀsƒƒ\ƒbƒh–¼:Connectz")
                                    m_cfRdbClass.Connect()
                                End If

                                Try
                                    ' ŠÇ—î•ñŽæ“¾(“à•”ˆ—)ƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
                                    Me.GetKanriJoho()

                                    ' ‘•Ûˆ¶–¼—š—ðŽæ“¾(“à•”ˆ—)ƒƒ\ƒbƒh‚ðŽÀs‚·‚éB
                                    csAtena1Entity = Me.GetKokuhoAtenaRireki(cAtenaGetPara1, ABEnumDefine.HyojunKB.KB_Hyojun)

                                Catch objRdbTimeOutExp As UFRdbTimeOutException    ' UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
                                    ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                                    m_cfLogClass.WarningWrite(m_cfControlData,
                                                            "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                            "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                            "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objRdbTimeOutExp.p_strErrorCode + "z" +
                                                            "yƒ[ƒjƒ“ƒO“à—e:" + objRdbTimeOutExp.Message + "z")
                                    ' UFAppException‚ðƒXƒ[‚·‚é
                                    Throw New UFAppException(objRdbTimeOutExp.Message, objRdbTimeOutExp.p_intErrorCode, objRdbTimeOutExp)

                                Catch
                                    ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[
                                    Throw

                                Finally
                                    ' RDBØ’f
                                    If m_blnBatchRdb = False Then
                                        ' RDBƒAƒNƒZƒXƒƒOo—Í
                                        m_cfLogClass.RdbWrite(m_cfControlData,
                                                                "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                                "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                                "yŽÀsƒƒ\ƒbƒh–¼:Disconnectz")
                                        m_cfRdbClass.Disconnect()
                                    End If

                                End Try

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

                            Return csAtena1Entity

                        End Function
                    #End Region
                        '*—š—ð”Ô† 000052 2023/03/10 ’Ç‰ÁI—¹

                        Public Sub New()

                        End Sub
                    End Class

                     */
                }
            }

            return default;
        }
    }
}