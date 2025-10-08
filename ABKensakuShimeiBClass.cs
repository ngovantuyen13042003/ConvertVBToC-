// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ŒŸõŽ–¼•ÒW(ABKensakuShimeiBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2002/12/18@ŽRè@•q¶
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/03/11 000001     ‹æØ‚è•¶Žš‚Ì•ÏX
// * 2005/04/04 000002     ‘SŠp‚Å‚Ì‚ ‚¢‚Ü‚¢ŒŸõ‚ð‰Â”\‚É‚·‚é(ƒ}ƒ‹ƒS‘ºŽR)
// * 2007/09/03 000003     ‘½–€Žs—p•ÒWƒTƒuƒ‹[ƒ`ƒ“‚ÌƒI[ƒo[ƒ[ƒhi’†‘òj
// * 2007/10/10 000004     •W€‚ÌŽd—l‚Å‚àŽ–¼‚ªƒAƒ‹ƒtƒ@ƒxƒbƒg‚Ìê‡‚Í‘å•¶Žš‚É•ÏŠ·‚·‚éi’†‘òj
// * 2007/11/06 000005     ŒŸõƒJƒi©–¼•ÒWƒpƒ^[ƒ“‚ÌC³AŒŸõƒJƒi€–Úƒƒ“ƒo•Ï”‚ð‰Šú‰»i’†‘òj
// * 2011/09/26 000006     ‘SŠpƒAƒ‹ƒtƒ@ƒxƒbƒgŒŸõŽž‚Ì´‰¹‰»”»’èˆ—‚ð’Ç‰Ái”ä‰Ãj
// * 2012/01/20 000007     yAB17051zƒAƒ‹ƒtƒ@ƒxƒbƒgŽ–¼ŒŸõ‹@”\‚Ì‰ü‘P(–k‘º)
// * 2020/01/10 000008     yAB32001zƒAƒ‹ƒtƒ@ƒxƒbƒgŒŸõiÎ‡j
// * 2023/12/04 000009     yAB-1600-1zŒŸõ‹@”\‘Î‰ž(‰º‘º)
// ************************************************************************************************
using System;
using System.Linq;
using System.Security;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Densan.Reams.AB.AB000BB
{

    public class ABKensakuShimeiBClass
    {
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfUFLogClass;            // ƒƒOo—ÍƒNƒ‰ƒX
        private UFConfigDataClass m_cfConfigData;     // ŠÂ‹«î•ñƒf[ƒ^ƒNƒ‰ƒX
        private UFControlData m_cfUFControlData;      // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private USRuijiClass m_cRuijiClass;       // —ÞŽ—•¶ŽšƒNƒ‰ƒX

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABKensakuShimeiBClass";
        private const string BUBUNITCHI = "2";

        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        private string m_strSearchkanjimei;           // ŒŸõ—pŠ¿Žš–¼Ìi‘SŠpŠ¿Žš@Max‚S‚O•¶Žšj
        private string m_strSearchKanaseimei;         // ŒŸõ—pƒJƒi©–¼i”¼ŠpƒJƒi@Max‚S‚O•¶Žšj
        private string m_strSearchKanasei;            // ŒŸõ—pƒJƒi©@i”¼ŠpƒJƒi@Max‚Q‚S•¶Žšj
        private string m_strSearchKanamei;            // ŒŸõ—pƒJƒi–¼@i”¼ŠpƒJƒi@Max‚P‚U•¶Žšj

        // Šeƒƒ“ƒo•Ï”‚ÌƒvƒƒpƒeƒB’è‹`
        public string p_strSearchkanjimei
        {
            get
            {
                return m_strSearchkanjimei;
            }
        }
        public string p_strSearchKanaseimei
        {
            get
            {
                return m_strSearchKanaseimei;
            }
        }
        public string p_strSearchKanasei
        {
            get
            {
                return m_strSearchKanasei;
            }
        }
        public string p_strSearchKanamei
        {
            get
            {
                return m_strSearchKanamei;
            }
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶            Public Sub New(ByVal csUFControlData As UFControlData, 
        // *                               ByVal csUFConfigData As UFConfigDataClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”            csUFControlData As UFControlData         : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                 csUFConfigData As UFConfigDataClass      : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg 
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABKensakuShimeiBClass(UFControlData cfControlData, UFConfigDataClass cfConfigData)
        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfUFControlData = cfControlData;
            m_cfConfigData = cfConfigData;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfUFLogClass = new UFLogClass(cfConfigData, cfControlData.m_strBusinessId);

            // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
            m_strSearchkanjimei = string.Empty;
            m_strSearchKanaseimei = string.Empty;
            m_strSearchKanasei = string.Empty;
            m_strSearchKanamei = string.Empty;
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ŒŸõŽ–¼Žæ“¾
        // * 
        // * \•¶            Public Sub GetKensakuShimei(ByVal strAimai As String, ByVal strShimei As String)
        // * 
        // * ‹@”\@@        Ž–¼‚ðŒŸõƒL[‚Æ‚µ‚Ä•ÒW‚·‚é
        // * 
        // * ˆø”            strAimai As String        :‘O•ûˆê’v
        // *                 strShimei As String      FŽ–¼
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        // *—š—ð”Ô† 000003 2007/09/03 C³ŠJŽn
        public void GetKensakuShimei(string strAimai, string strShimei)
        {
            // 'Public Sub GetKensakuShimei(ByVal strAimai As String, ByVal strShimei As String)
            // Const THIS_METHOD_NAME As String = "GetKensakuShimei"                   'ƒƒ\ƒbƒh–¼
            // Dim cuString As New USStringClass
            // Dim strHenshu As String = String.Empty              'ˆø”‚Ì•ÒW–¼Ì‚ðŠi”[
            // Dim strHenshuSei As String = String.Empty           '•ÒW–¼Ì©
            // Dim strHenshuMei As String = String.Empty           '•ÒW–¼Ì–¼
            // Dim intIchi As Integer = 0                          'Œ…ˆÊ’u
            // '04/02/28 ’Ç‰ÁŠJŽn
            // Dim strChkHenshu As String = String.Empty           '‚Ð‚ç‚ª‚çƒ`ƒFƒbƒN
            // '04/02/28 ’Ç‰ÁI—¹

            // Try
            // 'ƒfƒoƒbƒOŠJŽnƒƒOo—Í
            // m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

            // '04/02/28 ’Ç‰ÁŠJŽn
            // If cuString.ToHankaku(strShimei, strChkHenshu) Then
            // strShimei = strChkHenshu
            // End If
            // '04/02/28 ’Ç‰ÁI—¹

            // strHenshu = strShimei

            // '* —š—ð”Ô† 000002 2005/04/04 C³ŠJŽn
            // 'If (UFStringClass.CheckKanjiCode(strHenshu, m_cfConfigData)) Then
            // If (UFStringClass.CheckKanjiCode(strHenshu.Trim("%"c).Trim("“"c), m_cfConfigData)) Then
            // '* —š—ð”Ô† 000002 2005/04/04 C³I—¹
            // '‘SŠp
            // '* —š—ð”Ô† 000001 2003/03/11 C³ŠJŽn
            // 'intIchi = InStr(strHenshu, "F")
            // intIchi = InStr(strHenshu, "–")
            // '* —š—ð”Ô† 000001 2003/03/11 C³I—¹
            // If (intIchi > 0) Then
            // Mid(strHenshu, intIchi, 1) = "@"
            // End If
            // '* —š—ð”Ô† 000002 2005/04/04 ’Ç‰ÁŠJŽn
            // intIchi = InStr(strHenshu, "“")
            // If (intIchi > 0) Then
            // Mid(strHenshu, intIchi, 1) = "%"
            // End If
            // '* —š—ð”Ô† 000002 2005/04/04 ’Ç‰ÁI—¹
            // If (strAimai = "1") Then
            // strHenshu = strHenshu + "%"
            // End If
            // m_strSearchkanjimei = strHenshu
            // Else
            // '”¼Šp
            // '* —š—ð”Ô† 000002 2005/04/04 ’Ç‰ÁŠJŽn
            // intIchi = InStr(strShimei, "“")
            // If (intIchi > 0) Then
            // Mid(strHenshu, intIchi, 1) = "%"
            // End If
            // '* —š—ð”Ô† 000002 2005/04/04 ’Ç‰ÁI—¹
            // '* —š—ð”Ô† 000001 2003/03/11 C³ŠJŽn
            // 'intIchi = InStr(strShimei, ":")
            // intIchi = InStr(strShimei, "*")
            // '* —š—ð”Ô† 000001 2003/03/11 C³I—¹
            // If (intIchi = 0) Then
            // intIchi = InStr(strShimei, " ")
            // End If
            // If (intIchi <> 0) Then
            // '•ªŠ„
            // '©
            // strHenshuSei = cuString.ToKanaKey(Left(strHenshu, intIchi - 1))
            // If (strAimai = "1") Then
            // strHenshuSei = strHenshuSei + "%"
            // End If
            // m_strSearchKanasei = strHenshuSei
            // '–¼
            // strHenshuMei = cuString.ToKanaKey(Mid(strHenshu, intIchi + 1))
            // If (strAimai = "1") Then
            // strHenshuMei = strHenshuMei + "%"
            // End If
            // m_strSearchKanamei = strHenshuMei
            // Else
            // '•ªŠ„‚È‚µ
            // strHenshu = cuString.ToKanaKey(strHenshu)
            // If (strAimai = "1") Then
            // strHenshu = strHenshu + "%"
            // End If
            // m_strSearchKanaseimei = strHenshu
            // End If
            // End If

            // 'ƒfƒoƒbƒOI—¹ƒƒOo—Í
            // m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

            // Catch objExp As Exception
            // 'ƒGƒ‰[ƒƒOo—Í
            // m_cfUFLogClass.ErrorWrite(m_cfUFControlData, _
            // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" _
            // + "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" _
            // + "yƒGƒ‰[“à—e:" + objExp.Message + "z")
            // 'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
            // Throw objExp
            // End Try

            GetKensakuShimei(strAimai, strShimei, 0);
            // *—š—ð”Ô† 000003 2007/09/03 C³I—¹
        }

        // *—š—ð”Ô† 000003 2007/09/03 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ŒŸõŽ–¼Žæ“¾iƒI[ƒo[ƒ[ƒhj
        // * 
        // * \•¶            Public Sub GetKensakuShimei(ByVal strAimai As String, ByVal strShimei As String, 
        // *                                                                  ByVal intHommyoYusen As Integer)
        // * 
        // * ‹@”\@@        Ž–¼‚ðŒŸõƒL[‚Æ‚µ‚Ä•ÒW‚·‚é
        // * 
        // * ˆø”            strAimai As String        :‘O•ûˆê’v
        // *                 strShimei As String      FŽ–¼
        // *                 intHommyoYusen As IntegerF•W€(0)C–{–¼(1)C’ÊÌ–¼(2)
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        [SecuritySafeCritical]
        public void GetKensakuShimei(string strAimai, string strShimei, int intHommyoYusen)
        {
            const string THIS_METHOD_NAME = "GetKensakuShimei";                   // ƒƒ\ƒbƒh–¼
            var cuString = new USStringClass();
            string strHenshu = string.Empty;              // ˆø”‚Ì•ÒW–¼Ì‚ðŠi”[
            string strHenshuSei = string.Empty;           // •ÒW–¼Ì©
            string strHenshuMei = string.Empty;           // •ÒW–¼Ì–¼
            int intIchi = 0;                          // Œ…ˆÊ’u
            string strChkHenshu = string.Empty;           // ‚Ð‚ç‚ª‚Èƒ`ƒFƒbƒN
            UFRdbClass cfRdb;                             // RDBƒNƒ‰ƒX
            URKANRIJOHOCacheBClass crKanriJohoB;          // ŠÇ—î•ñ‚aƒNƒ‰ƒX
            FrnHommyoKensakuType enGaikokujinKensakuKB;   // ŠO‘l–{–¼ŒŸõ‹æ•ª
                                                          // *—š—ð”Ô† 000006 2011/09/26 ’Ç‰ÁŠJŽn
            ABAtenaKanriJohoBClass cABKanriJohoB;         // ˆ¶–¼ŠÇ—î•ñƒNƒ‰ƒX
            DataSet csABKanriJohoDS;
            string strZenAlphabetKB;
            // *—š—ð”Ô† 000006 2011/09/26 ’Ç‰ÁI—¹

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // RDBƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                cfRdb = new UFRdbClass(m_cfUFControlData.m_strBusinessId);

                // *—š—ð”Ô† 000005 2007/11/06 ’Ç‰ÁŠJŽn
                // ŒŸõ—pƒƒ“ƒo•Ï”‰Šú‰»
                m_strSearchkanjimei = string.Empty;
                m_strSearchKanaseimei = string.Empty;
                m_strSearchKanasei = string.Empty;
                m_strSearchKanamei = string.Empty;
                // *—š—ð”Ô† 000005 2007/11/06 ’Ç‰ÁI—¹

                // ˆ¶–¼Žæ“¾ƒrƒWƒlƒXƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                crKanriJohoB = new URKANRIJOHOCacheBClass(m_cfUFControlData, m_cfConfigData, cfRdb);
                // ŠÇ—î•ñŽæ“¾ƒƒ\ƒbƒhŽÀs
                enGaikokujinKensakuKB = crKanriJohoB.GetFrn_HommyoKensaku_Param();

                // *—š—ð”Ô† 000006 2011/09/26 ’Ç‰ÁŠJŽn
                // ˆ¶–¼ŠÇ—î•ñƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cABKanriJohoB = new ABAtenaKanriJohoBClass(m_cfUFControlData, m_cfConfigData, cfRdb);
                // ŠÇ—î•ñŽæ“¾ƒƒ\ƒbƒhŽÀs(ŒŸõ‰æ–Ê(03)A‘SŠpƒAƒ‹ƒtƒ@ƒxƒbƒgŒŸõ§Œä(14))
                csABKanriJohoDS = cABKanriJohoB.GetKanriJohoHoshu("03", "14");

                // ŠÇ—î•ñƒ`ƒFƒbƒN
                if (csABKanriJohoDS is not null && csABKanriJohoDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count > 0)
                {
                    strZenAlphabetKB = csABKanriJohoDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0)(ABAtenaKanriJohoEntity.PARAMETER).ToString;
                }
                else
                {
                    strZenAlphabetKB = "0";
                }
                // *—š—ð”Ô† 000006 2011/09/26 ’Ç‰ÁI—¹

                if (m_cRuijiClass is null)
                {
                    m_cRuijiClass = new USRuijiClass();
                }

                if (cuString.ToHankaku(strShimei, strChkHenshu))
                {
                    // *—š—ð”Ô† 000006 2011/09/26 ’Ç‰ÁŠJŽn
                    if (strZenAlphabetKB == "1")
                    {
                        // ŠÇ—î•ñFŒŸõ‰æ–ÊE‘SŠpƒAƒ‹ƒtƒ@ƒxƒbƒgŒŸõ§Œä(03E14) = "1" ‚Ìê‡
                        if (UFStringClass.CheckAlphabetNumber(strChkHenshu.Replace(" ", "").Trim('%').Trim('*').Trim('.').Trim('¥')))
                        {
                            if ((strShimei ?? "") == (strChkHenshu ?? ""))
                            {
                                // “ü—Í‚ª”¼ŠpƒAƒ‹ƒtƒ@ƒxƒbƒg‚Æ‚¢‚¤‚±‚Æ‚É‚È‚é‚½‚ß”¼Šp‚ÅŒŸõ‚³‚¹‚é
                                strShimei = strChkHenshu;
                            }
                            // *—š—ð”Ô† 000007 2012/01/20 C³ŠJŽn
                            else if (strChkHenshu == "*")
                            {
                                // ”¼Šp•ÏŠ·Œã‚Ì’l‚ª'*'‚Ìê‡A'*'‚ÅŒŸõ‚³‚¹‚é
                                strShimei = strChkHenshu;
                            }
                            // *—š—ð”Ô† 000007 2012/01/20 C³I—¹
                            else
                            {
                                // *—š—ð”Ô† 000008 2020/01/10 C³ŠJŽn
                                // '“ü—Í‚ª‘SŠpƒAƒ‹ƒtƒ@ƒxƒbƒg‚Æ‚¢‚¤‚±‚Æ‚¾‚©‚ç‘SŠp‚ÅŒŸõ‚³‚¹‚é
                                // “ü—Í‚ª‘SŠpƒAƒ‹ƒtƒ@ƒxƒbƒg‚Æ‚¢‚¤‚±‚Æ‚¾‚©‚ç‘SŠp”¼Šp—¼•û‚ÅŒŸõ‚³‚¹‚é
                                SetSearchKanjiShimei(strShimei, strAimai);
                                strShimei = strChkHenshu;
                                // *—š—ð”Ô† 000008 2020/01/10 C³I—¹
                            }
                        }
                        else
                        {
                            // ƒAƒ‹ƒtƒ@ƒxƒbƒg‚Å‚Í‚È‚¢‚Ì‚Å’Êí’Ê‚è”¼Šp‚Å‚ÌŒŸõ
                            strShimei = strChkHenshu;
                        }
                    }
                    else
                    {
                        strShimei = strChkHenshu;
                    }
                    // strShimei = strChkHenshu
                    // *—š—ð”Ô† 000006 2011/09/26 ’Ç‰ÁI—¹
                }

                strHenshu = strShimei;

                if (UFStringClass.CheckKanjiCode(strHenshu.Trim('%').Trim(
/* TODO ERROR: Skipped SkippedTokensTrivia
–")
If (intIchi > 0) Then
Mid(strHenshu, intIchi, 1) = "@"
End If
strHenshu = m_cRuijiClass.GetRuijiMojiList(strHenshu.Replace("@", String.Empty)).ToUpper
intIchi = InStr(strHenshu, "“"*/"“"c), m_cfConfigData)) Then
                '‘SŠp
                intIchi = InStr(strHenshu, ")))
                {
                    if (intIchi > 0)
                    {
                        StringType.MidStmtStr(ref strHenshu, intIchi, 1, "%");
                    }
                    if (strAimai == "1")
                    {
                        strHenshu = strHenshu + "%";
                    }
                    else if ((strAimai ?? "") == BUBUNITCHI)
                    {
                        strHenshu = "%" + strHenshu + "%";
                    }
                    m_strSearchkanjimei = strHenshu;
                }
                else
                {
                    // ”¼Šp
                    intIchi = Strings.InStr(strShimei, /* TODO ERROR: Skipped SkippedTokensTrivia
%"
                End If
                intIchi = InStr(strShimei, "*")
                If (intIchi = 0) Then
                    intIchi = InStr(strShimei, " ")
                End If

                '–{–¼—DæŒŸõƒpƒ‰ƒ[ƒ^‚ª‚PC‚QˆÈŠO‚Ì‚Æ‚«‚ÍAtenaGet‚ÌƒCƒ“ƒ^[ƒtƒF[ƒX—p‚ÉŒŸõƒJƒi—p•Ï”‚ðÝ’è
                'ŠO‘l–{–¼ŒŸõ‹@”\‹æ•ª‚ª•W€‚Ì‚Æ‚«‚ÍAtenaGet‚ÌƒCƒ“ƒ^[ƒtƒF[ƒX—p‚ÉŒŸõƒJƒi—p•Ï”‚ðÝ*/"“")
                If (intIchi > 0) Then
                    Mid(strHenshu, intIchi, 1) = ");
                    // *—š—ð”Ô† 000003 2007/09/03ˆÈ‘O‚©‚çGetKensakuShimei‚ðŽg—p‚µ‚Ä‚¢‚é‹Æ–±‚É‚Í‰e‹¿‚È‚µB
                    if (enGaikokujinKensakuKB == FrnHommyoKensakuType.Tsusho || intHommyoYusen != 1 && intHommyoYusen != 2)
                    {
                        // •W€Žd—l
                        if (intIchi != 0)
                        {
                            // •ªŠ„
                            // ©
                            // * —š—ð”Ô† 000004 2007/10/10 C³ŠJŽn
                            strHenshuSei = cuString.ToKanaKey(Strings.Left(strHenshu, intIchi - 1)).ToUpper();
                            // strHenshuSei = cuString.ToKanaKey(Left(strHenshu, intIchi - 1))
                            // * —š—ð”Ô† 000004 2007/10/10 C³I—¹
                            if (strAimai == "1")
                            {
                                strHenshuSei = strHenshuSei + "%";
                            }
                            m_strSearchKanasei = strHenshuSei;
                            // –¼
                            // * —š—ð”Ô† 000004 2007/10/10 C³ŠJŽn
                            strHenshuMei = cuString.ToKanaKey(Strings.Mid(strHenshu, intIchi + 1)).ToUpper();
                            // strHenshuMei = cuString.ToKanaKey(Mid(strHenshu, intIchi + 1))
                            // * —š—ð”Ô† 000004 2007/10/10 C³I—¹
                            if (strAimai == "1")
                            {
                                strHenshuMei = strHenshuMei + "%";
                            }
                            m_strSearchKanamei = strHenshuMei;
                            if ((strAimai ?? "") == BUBUNITCHI)
                            {
                                m_strSearchKanasei = string.Empty;
                                m_strSearchKanamei = string.Empty;
                                strHenshu = cuString.ToKanaKey(strHenshu.Replace(" ", string.Empty).Replace("*", string.Empty)).ToUpper();
                                strHenshu = "%" + strHenshu + "%";
                                m_strSearchKanaseimei = strHenshu;
                            }
                        }
                        else
                        {
                            // •ªŠ„‚È‚µ
                            // * —š—ð”Ô† 000004 2007/10/10 C³ŠJŽn
                            strHenshu = cuString.ToKanaKey(strHenshu).ToUpper();
                            // strHenshu = cuString.ToKanaKey(strHenshu)
                            // * —š—ð”Ô† 000004 2007/10/10 C³I—¹
                            if (strAimai == "1")
                            {
                                strHenshu = strHenshu + "%";
                            }
                            else if ((strAimai ?? "") == BUBUNITCHI)
                            {
                                strHenshu = "%" + strHenshu + "%";
                            }
                            m_strSearchKanaseimei = strHenshu;
                        }
                    }
                    // –{–¼‚Æ’ÊÌ–¼‚Ì—¼•û‚ÅŒŸõ‰Â”\‚È‚c‚a
                    // ƒAƒ‹ƒtƒ@ƒxƒbƒg‚Í‘S‚Ä‘å•¶Žš‚ÅƒZƒbƒg‚·‚é
                    else if (intHommyoYusen == 2)
                    {
                        // –{–¼—DæŒŸõˆÈŠO
                        // ŒŸõƒJƒi©–¼@ŒŸõƒJƒi–¼‚ÉŒŸõ•¶Žš—ñ‚ªƒZƒbƒg‚³‚ê‚é
                        // ƒJƒi’ÊÌ–¼‚Ìê‡
                        if (intIchi != 0)
                        {
                            // *—š—ð”Ô† 000005 2007/11/06 C³ŠJŽn
                            // •ªŠ„‚ ‚è ƒJƒi©ƒJƒi–¼‚ð’Šo
                            strHenshuSei = cuString.ToKanaKey(Strings.Left(strHenshu, intIchi - 1)).ToUpper();
                            strHenshuMei = cuString.ToKanaKey(Strings.Mid(strHenshu, intIchi + 1)).ToUpper();
                            if (strAimai == "1")    // žB–†ŒŸõi‘O•ûˆê’vƒ`ƒFƒbƒN‚ªTruej‚Ì‚Æ‚«"%"‚ð•t‰Á
                            {
                                if (!string.IsNullOrEmpty(strHenshuSei.Trim()))
                                {
                                    m_strSearchKanaseimei = strHenshuSei + "%";  // ŒŸõƒJƒi©
                                }
                                m_strSearchKanamei = strHenshuMei + "%";     // ŒŸõƒJƒi–¼
                            }
                            else if ((strAimai ?? "") == BUBUNITCHI)
                            {
                                strHenshu = cuString.ToKanaKey(strHenshu.Replace(" ", string.Empty)).ToUpper();
                                strHenshu = "%" + strHenshu + "%";
                                m_strSearchKanaseimei = strHenshu;
                            }
                            // Š®‘Sˆê’v
                            // ŒŸõƒJƒi©–¼
                            else if (!string.IsNullOrEmpty(strHenshuSei.Trim()))
                            {
                                m_strSearchKanaseimei = cuString.ToKanaKey(strHenshu.Replace(" ", string.Empty)).ToUpper();
                            }
                            else
                            {
                                m_strSearchKanamei = strHenshuMei;
                            }
                        }
                        // '•ªŠ„‚ ‚è ƒJƒi©ƒJƒi–¼‚ð’Šo
                        // strHenshuSei = cuString.ToKanaKey(Left(strHenshu, intIchi - 1)).ToUpper()
                        // strHenshuMei = cuString.ToKanaKey((Mid(strHenshu, intIchi + 1))).ToUpper()
                        // If (strAimai = "1") Then    'žB–†ŒŸõi‘O•ûˆê’vƒ`ƒFƒbƒN‚ªTruej‚Ì‚Æ‚«"%"‚ð•t‰Á
                        // strHenshuMei = strHenshuMei + "%"
                        // End If
                        // m_strSearchKanaseimei = strHenshuSei + "%"  'ŒŸõƒJƒi©ižB–†‚Ì—L–³‚É‚©‚©‚í‚ç‚¸“‚ª•t‰Á‚³‚ê‚éj
                        // m_strSearchKanamei = strHenshuMei           'ŒŸõƒJƒi–¼
                        // *—š—ð”Ô† 000005 2007/11/06 C³I—¹
                        else
                        {
                            // •ªŠ„‚È‚µ
                            strHenshu = cuString.ToKanaKey(strHenshu).ToUpper();
                            if (strAimai == "1")
                            {
                                strHenshu = strHenshu + "%";
                            }
                            else if ((strAimai ?? "") == BUBUNITCHI)
                            {
                                strHenshu = "%" + strHenshu + "%";
                            }
                            m_strSearchKanaseimei = strHenshu;
                        }           // ŒŸõƒJƒi©–¼
                    }
                    // –{–¼—DæŒŸõ
                    // ƒJƒi–{–¼‚Ìê‡iŒŸõƒJƒi©‚Ì‚Ý‚ÅŒŸõ‰Â”\‚É‚·‚é•Ï”‚ð¶¬j
                    // ŒŸõƒJƒi©‚ÉŒŸõ•¶Žš—ñ‚ªƒZƒbƒg‚³‚ê‚é
                    else if (intIchi != 0)
                    {
                        // *—š—ð”Ô† 000005 2007/11/06 C³ŠJŽn
                        // •ªŠ„‚ ‚è‚Ìê‡©–¼•ªŠ„
                        strHenshuSei = cuString.ToKanaKey(Strings.Left(strHenshu, intIchi - 1)).ToUpper();
                        strHenshuMei = cuString.ToKanaKey(Strings.Mid(strHenshu, intIchi + 1)).ToUpper();
                        if (strAimai == "1")    // žB–†ŒŸõi‘O•ûˆê’vƒ`ƒFƒbƒN‚ªTruej‚Ì‚Æ‚«"%"‚ð•t‰Á
                        {
                            strHenshuSei = strHenshuSei + "%";
                            strHenshuMei = strHenshuMei + "%";
                            // –{–¼ƒJƒi–¼Ì‚ÍŒŸõ—pƒJƒi©–¼‚Å•Ô‚³‚ê‚éiŒŸõƒJƒi©‚ÆŒŸõƒJƒi–¼‚ðŒ‹‡j
                            m_strSearchKanasei = strHenshuSei + strHenshuMei;
                        }
                        else if ((strAimai ?? "") == BUBUNITCHI)
                        {
                            strHenshu = cuString.ToKanaKey(strHenshu.Replace(" ", string.Empty)).ToUpper();
                            strHenshu = "%" + strHenshu + "%";
                            m_strSearchKanaseimei = strHenshu;
                        }
                        // Š®‘Sˆê’v‚Ìê‡
                        else if (string.IsNullOrEmpty(strHenshuSei.Trim()))
                        {
                            m_strSearchKanasei = "%" + strHenshuMei;
                        }
                        else
                        {
                            m_strSearchKanasei = cuString.ToKanaKey(strHenshu.Replace(" ", string.Empty)).ToUpper();
                        }
                    }
                    // '•ªŠ„‚ ‚è‚Ìê‡©–¼•ªŠ„
                    // strHenshuSei = cuString.ToKanaKey(Left(strHenshu, intIchi - 1)).ToUpper()
                    // strHenshuMei = cuString.ToKanaKey(Mid(strHenshu, intIchi + 1)).ToUpper()
                    // If (strAimai = "1") Then    'žB–†ŒŸõi‘O•ûˆê’vƒ`ƒFƒbƒN‚ªTruej‚Ì‚Æ‚«"%"‚ð•t‰Á
                    // strHenshuSei = strHenshuSei + "%"
                    // strHenshuMei = strHenshuMei + "%"
                    // End If
                    // '–{–¼ƒJƒi–¼Ì‚ÍŒŸõ—pƒJƒi©–¼‚Å•Ô‚³‚ê‚éiŒŸõƒJƒi©‚ÆŒŸõƒJƒi–¼‚ðŒ‹‡j
                    // m_strSearchKanasei = strHenshuSei + strHenshuMei
                    // *—š—ð”Ô† 000005 2007/11/06 C³I—¹
                    else
                    {
                        // •ªŠ„‚È‚µ‚Ìê‡‚»‚Ì‚Ü‚ÜžB–†ŒŸõ‚ð•t‰Á
                        strHenshu = cuString.ToKanaKey(strHenshu).ToUpper();
                        if (strAimai == "1")
                        {
                            strHenshu = strHenshu + "%";
                        }
                        else if ((strAimai ?? "") == BUBUNITCHI)
                        {
                            strHenshu = "%" + strHenshu + "%";
                        }
                        // –{–¼ƒJƒi–¼Ì‚ÍŒŸõ—pƒJƒi©–¼‚Å•Ô‚³‚ê‚é
                        m_strSearchKanasei = strHenshu;
                    }
                }

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (Exception objExp)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 26941


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                    End Sub
                    '*—š—ð”Ô† 000003 2007/09/03 ’Ç‰ÁI—¹

                 */
            }
        }

        // *—š—ð”Ô† 000008 2020/01/10 ’Ç‰ÁŠJŽn
        /// <summary>
    /// ŒŸõ—pŠ¿ŽšŽ–¼Ý’è
    /// </summary>
    /// <param name="strShimei">‘ÎÛ•¶Žš—ñ</param>
    /// <param name="strAimai">‚ ‚¢‚Ü‚¢ŒŸõ</param>
    /// <remarks></remarks>
        private void SetSearchKanjiShimei(string strShimei, string strAimai)
        {

            string strHenshu;
            int intIchi;

            try
            {

                strHenshu = strShimei;
                intIchi = Strings.InStr(strHenshu, "–");
                if (intIchi > 0)
                {
                    StringType.MidStmtStr(ref strHenshu, intIchi, 1, "@");
                }
                strHenshu = m_cRuijiClass.GetRuijiMojiList(strHenshu.Replace("@", string.Empty)).ToUpper;
                intIchi = Strings.InStr(strHenshu, /* TODO ERROR: Skipped SkippedTokensTrivia
%"
            End If
            If (strAimai = "1") Then
                strHenshu = strHenshu + "%"
            ElseIf (strAimai = BUBUNITCHI) Then
                strHenshu = "%" + strHenshu + "%"
            End If
            m_strSearchkanjimei = strHenshu

        Catch csExp As Exception
            Throw
        End Try

    End Sub

    ''' <summary>
    ''' Ž–¼ŒŸõðŒ¶¬
    ''' </summary>
    ''' <param name="cSearchKey">ˆ¶–¼ŒŸõƒL[</param>
    ''' <param name="strTableName">ƒe[ƒuƒ‹–¼</param>
    ''' <param name="csWhere">ì¬’†ðŒ</param>
    ''' <param name="cfParamCollection">ƒpƒ‰ƒ[ƒ^[ƒRƒŒƒNƒVƒ‡ƒ“</param>*/"“")
            If (intIchi > 0) Then
                Mid(strHenshu, intIchi, 1) = ");
            }
        }
        /// <remarks></remarks>
        public void CreateWhereForShimei(ABAtenaSearchKey cSearchKey, string strTableName, ref StringBuilder csWhere, ref UFParameterCollectionClass cfParamCollection)
        {

            StringBuilder csWhereForKanaShimei;
            StringBuilder csWhereForKanjiShimei;
            UFParameterClass cfParam;

            try
            {

                // ƒJƒiŒŸõ•”AŠ¿ŽšŒŸõ•”‚É‚P‚Â‚Å‚à’l‚ª‘¶Ý‚·‚éê‡‚ÉŒŸõðŒ‚ð’Ç‰Á‚·‚é
                if (cSearchKey.p_strSearchKanaSeiMei.Trim.RLength > 0 || cSearchKey.p_strSearchKanaSei.Trim.Trim.RLength > 0 || cSearchKey.p_strSearchKanaSei2.Trim.Trim.RLength > 0 || cSearchKey.p_strSearchKanaMei.Trim.Trim.RLength > 0 || cSearchKey.p_strSearchKanjiMeisho.Trim.Trim.RLength > 0 || cSearchKey.p_enGaikokuHommyoKensaku == FrnHommyoKensakuType.Tsusho_Seishiki && cSearchKey.p_strKanjiMeisho2.Trim.Trim.RLength > 0)





                {

                    if (csWhere.RLength > 0)
                    {
                        csWhere.Append(" AND ");
                    }
                    else
                    {
                        // noop
                    }

                    // ---------------------------------------------------------------------------------
                    // ƒJƒiŒŸõ•”•ÒW
                    csWhereForKanaShimei = new StringBuilder();

                    // -----------------------------------------------------------------------------
                    // ŒŸõ—pƒJƒi©–¼
                    if (cSearchKey.p_strSearchKanaSeiMei.Trim.RLength > 0)
                    {

                        if (cSearchKey.p_strSearchKanaSeiMei.RIndexOf("%") < 0)
                        {

                            csWhereForKanaShimei.AppendFormat("{0}.{1} = {2}", strTableName, ABAtenaEntity.SEARCHKANASEIMEI, ABAtenaEntity.KEY_SEARCHKANASEIMEI);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock = ref cfParam;
                                withBlock.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEIMEI;
                                withBlock.Value = cSearchKey.p_strSearchKanaSeiMei;
                            }
                        }

                        else
                        {

                            csWhereForKanaShimei.AppendFormat("{0}.{1} LIKE {2}", strTableName, ABAtenaEntity.SEARCHKANASEIMEI, ABAtenaEntity.KEY_SEARCHKANASEIMEI);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock1 = ref cfParam;
                                withBlock1.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEIMEI;
                                withBlock1.Value = cSearchKey.p_strSearchKanaSeiMei.TrimEnd;
                            }

                        }

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfParamCollection.Add(cfParam);
                    }

                    else
                    {
                        // noop
                    }
                    // -----------------------------------------------------------------------------
                    // ŒŸõ—pƒJƒi©
                    if (cSearchKey.p_strSearchKanaSei.Trim.RLength > 0)
                    {

                        if (csWhereForKanaShimei.RLength > 0)
                        {
                            csWhereForKanaShimei.Append(" AND ");
                        }
                        else
                        {
                            // noop
                        }

                        if (cSearchKey.p_strSearchKanaSei2.Trim.RLength > 0)
                        {
                            csWhereForKanaShimei.Append("(");
                        }
                        else
                        {
                            // noop
                        }

                        if (cSearchKey.p_strSearchKanaSei.RIndexOf("%") < 0)
                        {

                            csWhereForKanaShimei.AppendFormat("{0}.{1} = {2}", strTableName, ABAtenaEntity.SEARCHKANASEI, ABAtenaEntity.KEY_SEARCHKANASEI);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock2 = ref cfParam;
                                withBlock2.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEI;
                                withBlock2.Value = cSearchKey.p_strSearchKanaSei;
                            }
                        }

                        else
                        {

                            csWhereForKanaShimei.AppendFormat("{0}.{1} LIKE {2}", strTableName, ABAtenaEntity.SEARCHKANASEI, ABAtenaEntity.KEY_SEARCHKANASEI);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock3 = ref cfParam;
                                withBlock3.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEI;
                                withBlock3.Value = cSearchKey.p_strSearchKanaSei.TrimEnd;
                            }

                        }

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfParamCollection.Add(cfParam);
                    }

                    else
                    {
                        // noop
                    }
                    // -----------------------------------------------------------------------------
                    // ŒŸõƒJƒi©‚Q
                    if (cSearchKey.p_strSearchKanaSei2.Trim.RLength > 0)
                    {

                        csWhereForKanaShimei.Append(" OR ");

                        if (cSearchKey.p_strSearchKanaSei2.RIndexOf("%") < 0)
                        {

                            csWhereForKanaShimei.AppendFormat("{0}.{1} = {2}", strTableName, ABAtenaEntity.SEARCHKANASEI, ABAtenaEntity.KEY_SEARCHKANASEI2);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock4 = ref cfParam;
                                withBlock4.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEI2;
                                withBlock4.Value = cSearchKey.p_strSearchKanaSei2;
                            }
                        }

                        else
                        {

                            csWhereForKanaShimei.AppendFormat("{0}.{1} LIKE {2}", strTableName, ABAtenaEntity.SEARCHKANASEI, ABAtenaEntity.KEY_SEARCHKANASEI2);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock5 = ref cfParam;
                                withBlock5.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEI2;
                                withBlock5.Value = cSearchKey.p_strSearchKanaSei2.TrimEnd;
                            }

                        }

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfParamCollection.Add(cfParam);

                        csWhereForKanaShimei.Append(")");
                    }

                    else
                    {
                        // noop
                    }
                    // -----------------------------------------------------------------------------
                    // ŒŸõ—pƒJƒi–¼
                    if (cSearchKey.p_strSearchKanaMei.Trim.RLength > 0)
                    {

                        if (csWhereForKanaShimei.RLength > 0)
                        {
                            csWhereForKanaShimei.Append(" AND ");
                        }
                        else
                        {
                            // noop
                        }

                        if (cSearchKey.p_strSearchKanaMei.RIndexOf("%") < 0)
                        {

                            csWhereForKanaShimei.AppendFormat("{0}.{1} = {2}", strTableName, ABAtenaEntity.SEARCHKANAMEI, ABAtenaEntity.KEY_SEARCHKANAMEI);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock6 = ref cfParam;
                                withBlock6.ParameterName = ABAtenaEntity.KEY_SEARCHKANAMEI;
                                withBlock6.Value = cSearchKey.p_strSearchKanaMei;
                            }
                        }

                        else
                        {

                            csWhereForKanaShimei.AppendFormat("{0}.{1} LIKE {2}", strTableName, ABAtenaEntity.SEARCHKANAMEI, ABAtenaEntity.KEY_SEARCHKANAMEI);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock7 = ref cfParam;
                                withBlock7.ParameterName = ABAtenaEntity.KEY_SEARCHKANAMEI;
                                withBlock7.Value = cSearchKey.p_strSearchKanaMei.TrimEnd;
                            }

                        }

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfParamCollection.Add(cfParam);
                    }

                    else
                    {
                        // noop
                        // -----------------------------------------------------------------------------

                    }
                    // ---------------------------------------------------------------------------------

                    // ---------------------------------------------------------------------------------
                    // Š¿ŽšŒŸõ•”•ÒW
                    csWhereForKanjiShimei = new StringBuilder();

                    // -----------------------------------------------------------------------------
                    // ŒŸõ—pŠ¿Žš–¼Ì
                    if (cSearchKey.p_strSearchKanjiMeisho.Trim.RLength > 0)
                    {

                        if (cSearchKey.p_strSearchKanjiMeisho.RIndexOf("%") < 0)
                        {

                            csWhereForKanjiShimei.AppendFormat("{0}.{1} = {2}", strTableName, ABAtenaEntity.SEARCHKANJIMEISHO, ABAtenaEntity.PARAM_SEARCHKANJIMEISHO);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock8 = ref cfParam;
                                withBlock8.ParameterName = ABAtenaEntity.PARAM_SEARCHKANJIMEISHO;
                                withBlock8.Value = cSearchKey.p_strSearchKanjiMeisho;
                            }
                        }

                        else
                        {

                            csWhereForKanjiShimei.AppendFormat("{0}.{1} LIKE {2}", strTableName, ABAtenaEntity.SEARCHKANJIMEISHO, ABAtenaEntity.PARAM_SEARCHKANJIMEISHO);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock9 = ref cfParam;
                                withBlock9.ParameterName = ABAtenaEntity.PARAM_SEARCHKANJIMEISHO;
                                withBlock9.Value = cSearchKey.p_strSearchKanjiMeisho.TrimEnd;
                            }

                        }

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfParamCollection.Add(cfParam);
                    }

                    else
                    {
                        // noop
                    }
                    // -----------------------------------------------------------------------------
                    // Š¿ŽšŽ–¼‚Q
                    if (cSearchKey.p_enGaikokuHommyoKensaku == FrnHommyoKensakuType.Tsusho_Seishiki)
                    {

                        if (cSearchKey.p_strKanjiMeisho2.Trim.RLength > 0)
                        {

                            if (cSearchKey.p_strKanjiMeisho2.RIndexOf("%") < 0)
                            {

                                csWhereForKanjiShimei.AppendFormat("{0}.{1} = {2}", strTableName, ABAtenaEntity.KANJIMEISHO2, ABAtenaEntity.PARAM_KANJIMEISHO2);

                                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfParam = new UFParameterClass();
                                {
                                    ref var withBlock10 = ref cfParam;
                                    withBlock10.ParameterName = ABAtenaEntity.PARAM_KANJIMEISHO2;
                                    withBlock10.Value = cSearchKey.p_strKanjiMeisho2;
                                }
                            }

                            else
                            {

                                csWhereForKanjiShimei.AppendFormat("{0}.{1} LIKE {2}", strTableName, ABAtenaEntity.KANJIMEISHO2, ABAtenaEntity.PARAM_KANJIMEISHO2);

                                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfParam = new UFParameterClass();
                                cfParam.ParameterName = ABAtenaEntity.PARAM_KANJIMEISHO2;
                                cfParam.Value = cSearchKey.p_strKanjiMeisho2.TrimEnd;

                            }

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfParamCollection.Add(cfParam);
                        }

                        else
                        {
                            // noop
                        }
                    }

                    else
                    {
                        // noop
                        // -----------------------------------------------------------------------------

                    }
                    // ---------------------------------------------------------------------------------

                    // ---------------------------------------------------------------------------------
                    // ƒJƒiŒŸõ•”‚ÆŠ¿ŽšŒŸõ•”‚ª—¼•ûÝ’è‚³‚ê‚Ä‚¢‚éê‡A‚n‚qðŒ‚Å˜AŒ‹‚·‚é
                    if (csWhereForKanaShimei.RLength > 0)
                    {
                        if (csWhereForKanjiShimei.RLength > 0)
                        {
                            csWhere.AppendFormat("(({0}) OR ({1}))", csWhereForKanaShimei.ToString(), csWhereForKanjiShimei.ToString());
                        }
                        else
                        {
                            csWhere.AppendFormat("{0}", csWhereForKanaShimei.ToString());
                        }
                    }
                    else
                    {
                        csWhere.AppendFormat("{0}", csWhereForKanjiShimei.ToString());
                    }
                }
                // ---------------------------------------------------------------------------------

                else
                {
                    // noop
                }
            }

            catch (Exception csExp)
            {
                throw;
            }

        }
        // *—š—ð”Ô† 000008 2020/01/10 ’Ç‰ÁI—¹

        /// <summary>
    /// Ž–¼ŒŸõðŒ¶¬(ƒI[ƒo[ƒ[ƒh)
    /// </summary>
    /// <param name="cSearchKey">ˆ¶–¼ŒŸõƒL[</param>
    /// <param name="strTableName">ƒe[ƒuƒ‹–¼</param>
    /// <param name="csWhere">ì¬’†ðŒ</param>
    /// <param name="cfParamCollection">ƒpƒ‰ƒ[ƒ^[ƒRƒŒƒNƒVƒ‡ƒ“</param>
    /// <param name="strFZYHyojunTableName">ˆ¶–¼•t•W€ƒe[ƒuƒ‹–¼</param>
    /// <param name="blnFromAtenaRireki">ˆ¶–¼—š—ð”»’èƒtƒ‰ƒO:Optional-False</param>
    /// <param name="intHyojunKB">•W€‰»”Å”»’è:Optional’Êí</param>
    /// <remarks></remarks>
        public void CreateWhereForShimei(ABAtenaSearchKey cSearchKey, string strTableName, ref StringBuilder csWhere, ref UFParameterCollectionClass cfParamCollection, string strFZYHyojunTableName, bool blnFromAtenaRireki = false, ABEnumDefine.HyojunKB intHyojunKB = ABEnumDefine.HyojunKB.KB_Tsujo)
        {

            StringBuilder csWhereForKanaShimei;
            StringBuilder csWhereForKanjiShimei;
            UFParameterClass cfParam;
            string strWhereFZYHyojunKana;
            string strWhereFzyHyojunKanji;

            try
            {

                // ƒJƒiŒŸõ•”AŠ¿ŽšŒŸõ•”‚É‚P‚Â‚Å‚à’l‚ª‘¶Ý‚·‚éê‡‚ÉŒŸõðŒ‚ð’Ç‰Á‚·‚é
                if (cSearchKey.p_strSearchKanaSeiMei.Trim.RLength > 0 || cSearchKey.p_strSearchKanaSei.Trim.Trim.RLength > 0 || cSearchKey.p_strSearchKanaSei2.Trim.Trim.RLength > 0 || cSearchKey.p_strSearchKanaMei.Trim.Trim.RLength > 0 || cSearchKey.p_strSearchKanjiMeisho.Trim.Trim.RLength > 0 || cSearchKey.p_enGaikokuHommyoKensaku == FrnHommyoKensakuType.Tsusho_Seishiki && cSearchKey.p_strKanjiMeisho2.Trim.Trim.RLength > 0)





                {

                    if (csWhere.RLength > 0)
                    {
                        csWhere.Append(" AND ");
                    }
                    else
                    {
                        // noop
                    }

                    // ---------------------------------------------------------------------------------
                    // ƒJƒiŒŸõ•”•ÒW
                    csWhereForKanaShimei = new StringBuilder();

                    // -----------------------------------------------------------------------------
                    // ŒŸõ—pƒJƒi©–¼
                    if (cSearchKey.p_strSearchKanaSeiMei.Trim.RLength > 0)
                    {
                        strWhereFZYHyojunKana = CreateWhereFZYHyojunKana(cSearchKey, strFZYHyojunTableName, blnFromAtenaRireki, intHyojunKB);
                        if (strWhereFZYHyojunKana.RLength > 0)
                        {
                            csWhereForKanaShimei.Append("(");
                        }
                        if (cSearchKey.p_strSearchKanaSeiMei.RIndexOf("%") < 0)
                        {
                            csWhereForKanaShimei.AppendFormat("{0}.{1} = {2}", strTableName, ABAtenaEntity.SEARCHKANASEIMEI, ABAtenaEntity.KEY_SEARCHKANASEIMEI);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock = ref cfParam;
                                withBlock.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEIMEI;
                                withBlock.Value = cSearchKey.p_strSearchKanaSeiMei;
                            }
                        }

                        else
                        {

                            csWhereForKanaShimei.AppendFormat("{0}.{1} LIKE {2}", strTableName, ABAtenaEntity.SEARCHKANASEIMEI, ABAtenaEntity.KEY_SEARCHKANASEIMEI);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock1 = ref cfParam;
                                withBlock1.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEIMEI;
                                withBlock1.Value = cSearchKey.p_strSearchKanaSeiMei.TrimEnd;
                            }

                        }

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfParamCollection.Add(cfParam);
                        if (strWhereFZYHyojunKana.RLength > 0)
                        {
                            if (blnFromAtenaRireki)
                            {
                                csWhereForKanaShimei.Append(strWhereFZYHyojunKana);
                            }
                            else
                            {
                                csWhereForKanaShimei.Append(" OR ");
                                csWhereForKanaShimei.AppendFormat("{0}.{1} IN (", strTableName, ABAtenaEntity.JUMINCD);
                                csWhereForKanaShimei.AppendFormat("SELECT {0}.{1} FROM {0}", strFZYHyojunTableName, ABAtenaFZYHyojunEntity.JUMINCD);
                                csWhereForKanaShimei.AppendFormat(" WHERE {0}", strWhereFZYHyojunKana);
                                csWhereForKanaShimei.Append("))");
                            }
                            cfParam = new UFParameterClass();
                            cfParam.ParameterName = ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAFRNMEI;
                            cfParam.Value = cSearchKey.p_strSearchKanaSeiMei.TrimEnd;
                            cfParamCollection.Add(cfParam);

                            cfParam = new UFParameterClass();
                            cfParam.ParameterName = ABAtenaFZYHyojunEntity.PARAM_SEARCHKANATSUSHOMEI;
                            cfParam.Value = cSearchKey.p_strSearchKanaSeiMei.TrimEnd;
                            cfParamCollection.Add(cfParam);

                            cfParam = new UFParameterClass();
                            cfParam.ParameterName = ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAHEIKIMEI;
                            cfParam.Value = cSearchKey.p_strSearchKanaSeiMei.TrimEnd;
                            cfParamCollection.Add(cfParam);
                        }
                    }
                    else
                    {
                        // noop
                    }

                    // -----------------------------------------------------------------------------
                    // ŒŸõ—pƒJƒi©
                    if (cSearchKey.p_strSearchKanaSei.Trim.RLength > 0)
                    {

                        if (csWhereForKanaShimei.RLength > 0)
                        {
                            csWhereForKanaShimei.Append(" AND ");
                        }
                        else
                        {
                            // noop
                        }

                        if (cSearchKey.p_strSearchKanaSei2.Trim.RLength > 0)
                        {
                            csWhereForKanaShimei.Append("(");
                        }
                        else
                        {
                            // noop
                        }

                        if (cSearchKey.p_strSearchKanaSei.RIndexOf("%") < 0)
                        {

                            csWhereForKanaShimei.AppendFormat("{0}.{1} = {2}", strTableName, ABAtenaEntity.SEARCHKANASEI, ABAtenaEntity.KEY_SEARCHKANASEI);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock2 = ref cfParam;
                                withBlock2.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEI;
                                withBlock2.Value = cSearchKey.p_strSearchKanaSei;
                            }
                        }

                        else
                        {

                            csWhereForKanaShimei.AppendFormat("{0}.{1} LIKE {2}", strTableName, ABAtenaEntity.SEARCHKANASEI, ABAtenaEntity.KEY_SEARCHKANASEI);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock3 = ref cfParam;
                                withBlock3.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEI;
                                withBlock3.Value = cSearchKey.p_strSearchKanaSei.TrimEnd;
                            }

                        }

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfParamCollection.Add(cfParam);
                    }

                    else
                    {
                        // noop
                    }
                    // -----------------------------------------------------------------------------
                    // ŒŸõƒJƒi©‚Q
                    if (cSearchKey.p_strSearchKanaSei2.Trim.RLength > 0)
                    {

                        csWhereForKanaShimei.Append(" OR ");

                        if (cSearchKey.p_strSearchKanaSei2.RIndexOf("%") < 0)
                        {

                            csWhereForKanaShimei.AppendFormat("{0}.{1} = {2}", strTableName, ABAtenaEntity.SEARCHKANASEI, ABAtenaEntity.KEY_SEARCHKANASEI2);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock4 = ref cfParam;
                                withBlock4.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEI2;
                                withBlock4.Value = cSearchKey.p_strSearchKanaSei2;
                            }
                        }

                        else
                        {

                            csWhereForKanaShimei.AppendFormat("{0}.{1} LIKE {2}", strTableName, ABAtenaEntity.SEARCHKANASEI, ABAtenaEntity.KEY_SEARCHKANASEI2);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock5 = ref cfParam;
                                withBlock5.ParameterName = ABAtenaEntity.KEY_SEARCHKANASEI2;
                                withBlock5.Value = cSearchKey.p_strSearchKanaSei2.TrimEnd;
                            }

                        }

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfParamCollection.Add(cfParam);

                        csWhereForKanaShimei.Append(")");
                    }

                    else
                    {
                        // noop
                    }
                    // -----------------------------------------------------------------------------
                    // ŒŸõ—pƒJƒi–¼
                    if (cSearchKey.p_strSearchKanaMei.Trim.RLength > 0)
                    {

                        if (csWhereForKanaShimei.RLength > 0)
                        {
                            csWhereForKanaShimei.Append(" AND ");
                        }
                        else
                        {
                            // noop
                        }

                        if (cSearchKey.p_strSearchKanaMei.RIndexOf("%") < 0)
                        {

                            csWhereForKanaShimei.AppendFormat("{0}.{1} = {2}", strTableName, ABAtenaEntity.SEARCHKANAMEI, ABAtenaEntity.KEY_SEARCHKANAMEI);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock6 = ref cfParam;
                                withBlock6.ParameterName = ABAtenaEntity.KEY_SEARCHKANAMEI;
                                withBlock6.Value = cSearchKey.p_strSearchKanaMei;
                            }
                        }

                        else
                        {

                            csWhereForKanaShimei.AppendFormat("{0}.{1} LIKE {2}", strTableName, ABAtenaEntity.SEARCHKANAMEI, ABAtenaEntity.KEY_SEARCHKANAMEI);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock7 = ref cfParam;
                                withBlock7.ParameterName = ABAtenaEntity.KEY_SEARCHKANAMEI;
                                withBlock7.Value = cSearchKey.p_strSearchKanaMei.TrimEnd;
                            }

                        }

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfParamCollection.Add(cfParam);
                    }

                    else
                    {
                        // noop
                        // -----------------------------------------------------------------------------

                    }
                    // ---------------------------------------------------------------------------------

                    // ---------------------------------------------------------------------------------
                    // Š¿ŽšŒŸõ•”•ÒW
                    csWhereForKanjiShimei = new StringBuilder();

                    if (cSearchKey.p_strSearchKanjiMeisho.Trim.RLength > 0 || cSearchKey.p_enGaikokuHommyoKensaku == 2 & cSearchKey.p_strKanjiMeisho2.Trim.RLength > 0)
                    {
                        strWhereFzyHyojunKanji = CreateWhereFZYHyojunKanji(cSearchKey, strFZYHyojunTableName, blnFromAtenaRireki, intHyojunKB);
                    }
                    else
                    {
                        strWhereFzyHyojunKanji = string.Empty;
                    }
                    if (strWhereFzyHyojunKanji.RLength > 0)
                    {
                        csWhereForKanjiShimei.Append("(");
                    }
                    // -----------------------------------------------------------------------------
                    // ŒŸõ—pŠ¿Žš–¼Ì
                    if (cSearchKey.p_strSearchKanjiMeisho.Trim.RLength > 0)
                    {

                        if (cSearchKey.p_strSearchKanjiMeisho.RIndexOf("%") < 0)
                        {

                            csWhereForKanjiShimei.AppendFormat("{0}.{1} = {2}", strTableName, ABAtenaEntity.SEARCHKANJIMEISHO, ABAtenaEntity.PARAM_SEARCHKANJIMEISHO);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock8 = ref cfParam;
                                withBlock8.ParameterName = ABAtenaEntity.PARAM_SEARCHKANJIMEISHO;
                                withBlock8.Value = cSearchKey.p_strSearchKanjiMeisho;
                            }
                        }

                        else
                        {

                            csWhereForKanjiShimei.AppendFormat("{0}.{1} LIKE {2}", strTableName, ABAtenaEntity.SEARCHKANJIMEISHO, ABAtenaEntity.PARAM_SEARCHKANJIMEISHO);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfParam = new UFParameterClass();
                            {
                                ref var withBlock9 = ref cfParam;
                                withBlock9.ParameterName = ABAtenaEntity.PARAM_SEARCHKANJIMEISHO;
                                withBlock9.Value = cSearchKey.p_strSearchKanjiMeisho.TrimEnd;
                            }

                        }

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfParamCollection.Add(cfParam);
                    }

                    else
                    {
                        // noop
                    }
                    // -----------------------------------------------------------------------------
                    // Š¿ŽšŽ–¼‚Q
                    if (cSearchKey.p_enGaikokuHommyoKensaku == FrnHommyoKensakuType.Tsusho_Seishiki)
                    {

                        if (cSearchKey.p_strKanjiMeisho2.Trim.RLength > 0)
                        {

                            if (cSearchKey.p_strKanjiMeisho2.RIndexOf("%") < 0)
                            {

                                csWhereForKanjiShimei.AppendFormat("{0}.{1} = {2}", strTableName, ABAtenaEntity.KANJIMEISHO2, ABAtenaEntity.PARAM_KANJIMEISHO2);

                                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfParam = new UFParameterClass();
                                {
                                    ref var withBlock10 = ref cfParam;
                                    withBlock10.ParameterName = ABAtenaEntity.PARAM_KANJIMEISHO2;
                                    withBlock10.Value = cSearchKey.p_strKanjiMeisho2;
                                }
                            }

                            else
                            {

                                csWhereForKanjiShimei.AppendFormat("{0}.{1} LIKE {2}", strTableName, ABAtenaEntity.KANJIMEISHO2, ABAtenaEntity.PARAM_KANJIMEISHO2);

                                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfParam = new UFParameterClass();
                                {
                                    ref var withBlock11 = ref cfParam;
                                    withBlock11.ParameterName = ABAtenaEntity.PARAM_KANJIMEISHO2;
                                    withBlock11.Value = cSearchKey.p_strKanjiMeisho2.TrimEnd;
                                }

                            }

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfParamCollection.Add(cfParam);
                        }

                        else
                        {
                            // noop
                        }
                    }

                    else
                    {
                        // noop
                    }
                    // -----------------------------------------------------------------------------
                    if (strWhereFzyHyojunKanji.RLength > 0)
                    {
                        if (blnFromAtenaRireki)
                        {
                            csWhereForKanjiShimei.Append(strWhereFzyHyojunKanji);
                        }
                        else
                        {
                            csWhereForKanjiShimei.Append(" OR ");
                            csWhereForKanjiShimei.AppendFormat("{0}.{1} IN (", strTableName, ABAtenaEntity.JUMINCD);
                            csWhereForKanjiShimei.AppendFormat("SELECT {0}.{1} FROM {0}", strFZYHyojunTableName, ABAtenaFZYHyojunEntity.JUMINCD);
                            csWhereForKanjiShimei.AppendFormat(" WHERE {0}", strWhereFzyHyojunKanji);
                            csWhereForKanjiShimei.Append("))");
                        }
                        if (cSearchKey.p_strSearchKanjiMeisho.RLength > 0)
                        {
                            cfParam = new UFParameterClass();
                            cfParam.ParameterName = ABAtenaFZYHyojunEntity.PARAM_SEARCHFRNMEI;
                            cfParam.Value = cSearchKey.p_strSearchKanjiMeisho.TrimEnd;
                            cfParamCollection.Add(cfParam);

                            cfParam = new UFParameterClass();
                            cfParam.ParameterName = ABAtenaFZYHyojunEntity.PARAM_SEARCHTSUSHOMEI;
                            cfParam.Value = cSearchKey.p_strSearchKanjiMeisho.TrimEnd;
                            cfParamCollection.Add(cfParam);

                            cfParam = new UFParameterClass();
                            cfParam.ParameterName = ABAtenaFZYHyojunEntity.PARAM_SEARCHKANJIHEIKIMEI;
                            cfParam.Value = cSearchKey.p_strSearchKanjiMeisho.TrimEnd;
                            cfParamCollection.Add(cfParam);
                        }
                        else
                        {
                            cfParam = new UFParameterClass();
                            cfParam.ParameterName = ABAtenaFZYHyojunEntity.PARAM_SEARCHFRNMEI;
                            cfParam.Value = cSearchKey.p_strKanjiMeisho2.TrimEnd;
                            cfParamCollection.Add(cfParam);

                            cfParam = new UFParameterClass();
                            cfParam.ParameterName = ABAtenaFZYHyojunEntity.PARAM_SEARCHTSUSHOMEI;
                            cfParam.Value = cSearchKey.p_strKanjiMeisho2.TrimEnd;
                            cfParamCollection.Add(cfParam);

                            cfParam = new UFParameterClass();
                            cfParam.ParameterName = ABAtenaFZYHyojunEntity.PARAM_SEARCHKANJIHEIKIMEI;
                            cfParam.Value = cSearchKey.p_strKanjiMeisho2.TrimEnd;
                            cfParamCollection.Add(cfParam);
                        }

                    }
                    // ---------------------------------------------------------------------------------

                    // ---------------------------------------------------------------------------------
                    // ƒJƒiŒŸõ•”‚ÆŠ¿ŽšŒŸõ•”‚ª—¼•ûÝ’è‚³‚ê‚Ä‚¢‚éê‡A‚n‚qðŒ‚Å˜AŒ‹‚·‚é
                    if (csWhereForKanaShimei.RLength > 0)
                    {
                        if (csWhereForKanjiShimei.RLength > 0)
                        {
                            csWhere.AppendFormat("(({0}) OR ({1}))", csWhereForKanaShimei.ToString(), csWhereForKanjiShimei.ToString());
                        }
                        else
                        {
                            csWhere.AppendFormat("{0}", csWhereForKanaShimei.ToString());
                        }
                    }
                    else
                    {
                        csWhere.AppendFormat("{0}", csWhereForKanjiShimei.ToString());
                    }
                }
                // ---------------------------------------------------------------------------------

                else
                {
                    // noop
                }
            }

            catch (Exception csExp)
            {
                throw;
            }

        }

        /// <summary>
    /// ’ŠoðŒ•¶Žš—ñ‚Ì¶¬iˆ¶–¼•t•W€EƒJƒi©–¼—pj
    /// </summary>
    /// <param name="cSearchKey">ŒŸõƒL[</param>
    /// <param name="strTable">ƒe[ƒuƒ‹–¼</param>
    /// <param name="blnRireki">—š—ð‹æ•ª</param>
    /// <param name="intHyojunKB">•W€‰»‹æ•ª</param>
    /// <returns>’ŠoðŒ•¶Žš—ñ</returns>
    /// <remarks></remarks>
        public string CreateWhereFZYHyojunKana(ABAtenaSearchKey cSearchKey, string strTable, bool blnRireki, ABEnumDefine.HyojunKB intHyojunKB)
        {

            string THIS_METHOD_NAME = System.Reflection.MethodBase.GetCurrentMethod().Name;
            StringBuilder csWHERE;

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // WHERE‹å‚Ìì¬
                csWHERE = new StringBuilder(256);

                if (blnRireki)
                {
                    if (intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                    {
                        if (cSearchKey.p_strSearchKanaSeiMei.RIndexOf("%") == -1)
                        {
                            csWHERE.Append("(");
                            csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHKANAFRNMEI);
                            csWHERE.Append(" = ");
                            csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAFRNMEI);
                            csWHERE.Append(" OR ");
                            csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHKANATSUSHOMEI);
                            csWHERE.Append(" = ");
                            csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHKANATSUSHOMEI);
                            csWHERE.Append(" OR ");
                            csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHKANAHEIKIMEI);
                            csWHERE.Append(" = ");
                            csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAHEIKIMEI);
                            csWHERE.Append(")");
                        }
                        else
                        {
                            csWHERE.Append("(");
                            csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHKANAFRNMEI);
                            csWHERE.Append(" LIKE ");
                            csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAFRNMEI);
                            csWHERE.Append(" OR ");
                            csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHKANATSUSHOMEI);
                            csWHERE.Append(" LIKE ");
                            csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHKANATSUSHOMEI);
                            csWHERE.Append(" OR ");
                            csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHKANAHEIKIMEI);
                            csWHERE.Append(" LIKE ");
                            csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAHEIKIMEI);
                            csWHERE.Append(")");
                        }
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else if (cSearchKey.p_strSearchKanaSeiMei.RIndexOf("%") == -1)
                {
                    csWHERE.Append("(");
                    csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHKANAFRNMEI);
                    csWHERE.Append(" = ");
                    csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAFRNMEI);
                    csWHERE.Append(" OR ");
                    csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHKANATSUSHOMEI);
                    csWHERE.Append(" = ");
                    csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHKANATSUSHOMEI);
                    csWHERE.Append(" OR ");
                    csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHKANAHEIKIMEI);
                    csWHERE.Append(" = ");
                    csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAHEIKIMEI);
                    csWHERE.Append(")");
                }
                else
                {
                    csWHERE.Append("(");
                    csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHKANAFRNMEI);
                    csWHERE.Append(" LIKE ");
                    csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAFRNMEI);
                    csWHERE.Append(" OR ");
                    csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHKANATSUSHOMEI);
                    csWHERE.Append(" LIKE ");
                    csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHKANATSUSHOMEI);
                    csWHERE.Append(" OR ");
                    csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHKANAHEIKIMEI);
                    csWHERE.Append(" LIKE ");
                    csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAHEIKIMEI);
                    csWHERE.Append(")");
                }

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException cfAppExp)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 67842


                Input:
                " + cfAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 67937


                Input:
                " + cfAppExp.Message + "z")
                            Throw cfAppExp

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 68166


                Input:
                " + THIS_CLASS_NAME + "z" _
                                                      + "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 68249


                                Input:
                                " + THIS_METHOD_NAME + "z" _
                                                                      + "yƒGƒ‰[“à—e:" + csExp.Message + "z")

                                 */
                throw csExp;

            }

            return csWHERE.ToString();

        }

        /// <summary>
    /// ’ŠoðŒ•¶Žš—ñ‚Ì¶¬iˆ¶–¼•t•W€EŠ¿Žš©–¼—pj
    /// </summary>
    /// <param name="cSearchKey">ŒŸõƒL[</param>
    /// <param name="strTable">ƒe[ƒuƒ‹–¼</param>
    /// <param name="blnRireki">—š—ð‹æ•ª</param>
    /// <param name="intHyojunKB">•W€‰»‹æ•ª</param>
    /// <returns>’ŠoðŒ•¶Žš—ñ</returns>
    /// <remarks></remarks>
        public string CreateWhereFZYHyojunKanji(ABAtenaSearchKey cSearchKey, string strTable, bool blnRireki, ABEnumDefine.HyojunKB intHyojunKB)
        {

            string THIS_METHOD_NAME = System.Reflection.MethodBase.GetCurrentMethod().Name;
            StringBuilder csWHERE;

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // WHERE‹å‚Ìì¬
                csWHERE = new StringBuilder(256);

                if (blnRireki)
                {
                    if (intHyojunKB == ABEnumDefine.HyojunKB.KB_Hyojun)
                    {
                        if (cSearchKey.p_strSearchKanjiMeisho.RIndexOf("%") == -1)
                        {
                            csWHERE.Append("(");
                            csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHFRNMEI);
                            csWHERE.Append(" = ");
                            csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHFRNMEI);
                            csWHERE.Append(" OR ");
                            csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHTSUSHOMEI);
                            csWHERE.Append(" = ");
                            csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHTSUSHOMEI);
                            csWHERE.Append(" OR ");
                            csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHKANJIHEIKIMEI);
                            csWHERE.Append(" = ");
                            csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHKANJIHEIKIMEI);
                            csWHERE.Append(")");
                        }
                        else
                        {
                            csWHERE.Append("(");
                            csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHFRNMEI);
                            csWHERE.Append(" LIKE ");
                            csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHFRNMEI);
                            csWHERE.Append(" OR ");
                            csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHTSUSHOMEI);
                            csWHERE.Append(" LIKE ");
                            csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHTSUSHOMEI);
                            csWHERE.Append(" OR ");
                            csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHKANJIHEIKIMEI);
                            csWHERE.Append(" LIKE ");
                            csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHKANJIHEIKIMEI);
                            csWHERE.Append(")");
                        }
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else if (cSearchKey.p_strSearchKanjiMeisho.RIndexOf("%") == -1)
                {
                    csWHERE.Append("(");
                    csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHFRNMEI);
                    csWHERE.Append(" = ");
                    csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHFRNMEI);
                    csWHERE.Append(" OR ");
                    csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHTSUSHOMEI);
                    csWHERE.Append(" = ");
                    csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHTSUSHOMEI);
                    csWHERE.Append(" OR ");
                    csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHKANJIHEIKIMEI);
                    csWHERE.Append(" = ");
                    csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHKANJIHEIKIMEI);
                    csWHERE.Append(")");
                }
                else
                {
                    csWHERE.Append("(");
                    csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHFRNMEI);
                    csWHERE.Append(" LIKE ");
                    csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHFRNMEI);
                    csWHERE.Append(" OR ");
                    csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHTSUSHOMEI);
                    csWHERE.Append(" LIKE ");
                    csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHTSUSHOMEI);
                    csWHERE.Append(" OR ");
                    csWHERE.Append(strTable).Append(".").Append(ABAtenaFZYHyojunEntity.SEARCHKANJIHEIKIMEI);
                    csWHERE.Append(" LIKE ");
                    csWHERE.Append(ABAtenaFZYHyojunEntity.PARAM_SEARCHKANJIHEIKIMEI);
                    csWHERE.Append(")");
                }

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException cfAppExp)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 74112


                Input:
                " + cfAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 74207


                Input:
                " + cfAppExp.Message + "z")
                            Throw cfAppExp

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 74436


                Input:
                " + THIS_CLASS_NAME + "z" _
                                                      + "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 74519


                                Input:
                                " + THIS_METHOD_NAME + "z" _
                                                                      + "yƒGƒ‰[“à—e:" + csExp.Message + "z")

                                 */
                throw csExp;

            }

            return csWHERE.ToString();

        }
    }
}