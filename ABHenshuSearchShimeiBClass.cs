// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        •ÒWŒŸõŽ–¼(ABHenshuSearchShimeiBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2007/09/28@’†‘ò@½
// * 
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2007/10/10 000001     •W€Žs’¬‘º‚ÌŒŸõƒJƒi€–Ú‚ªƒAƒ‹ƒtƒ@ƒxƒbƒg‚Ìê‡‚Í‘å•¶Žš‚É•ÏŠ·i’†‘òj
// * 2023/08/14 000002    yAB-0820-1zZ“oŠOŠÇ—€–Ú’Ç‰Á(‘è)
// ************************************************************************************************
using System;

namespace Densan.Reams.AB.AB000BB
{

    public class ABHenshuSearchShimeiBClass
    {

        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfLog;                       // ƒƒOo—ÍƒNƒ‰ƒX
        private UFConfigDataClass m_cfConfigData;         // ŠÂ‹«î•ñƒf[ƒ^ƒNƒ‰ƒX
        private UFControlData m_cfControlData;            // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABHenshuSearchShimeiBClass";
        // *—š—ð”Ô† 000002 2023/08/14 ’Ç‰ÁŠJŽn
        private const int KANA_SEIMEI = 120;
        private const int KANA_SEI = 72;
        private const int KANA_MEI = 48;
        // *—š—ð”Ô† 000002 2023/08/14 ’Ç‰ÁI—¹
        #endregion

        #region ƒRƒ“
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
        public ABHenshuSearchShimeiBClass(UFControlData cfControlData, UFConfigDataClass cfConfigData)
        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigData = cfConfigData;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLog = new UFLogClass(m_cfConfigData, m_cfControlData.m_strBusinessId);

        }
        #endregion

        #region ƒƒ\ƒbƒh
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ŒŸõ—pƒJƒi•ÒW
        // * 
        // * \•¶           Public Function GetSearchKana(ByVal strKanaMeisho As String, _
        // *                                              ByVal strKanaMeisho As String, _
        // *                                              ByVal enHommyKensakuKB As FrnHommyoKensakuType) As String()
        // * 
        // * ‹@”\@@       ŒŸõ—pƒJƒi–¼Ì‚ð•ÒW‚·‚é
        // * 
        // * ˆø”           strKanaMeisho    As String                   : ƒJƒi–¼Ì‚P
        // *                strKanaMeisho2   As String                   : ƒJƒi–¼Ì‚Q
        // *                enHommyKensakuKB As FrnHommyoKensakuType     : –{–¼—DæŒŸõ‹æ•ª
        // * 
        // * –ß‚è’l         String()          : [0]ŒŸõ—pƒJƒi©–¼
        // *                                  : [1]ŒŸõ—pƒJƒi©
        // *                                  : [2]ŒŸõ—pƒJƒi–¼
        // *                                  : [3]ƒJƒi©
        // *                                  : [4]ƒJƒi–¼
        // ************************************************************************************************
        public string[] GetSearchKana(string strKanaMeisho, string strKanaMeisho2, FrnHommyoKensakuType enHommyKensakuKB)

        {
            const string THIS_METHOD_NAME = "GetSearchKana";                      // ƒƒ\ƒbƒh–¼
            var strSearchKana = new string[5];                      // ŒŸõ—pƒJƒi
            var cuString = new USStringClass();                   // •¶Žš—ñ•ÒW
            int intIndex;                             // æ“ª‚©‚ç‚Ì‹ó”’ˆÊ’u

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // •W€iTsushoF•W€@Tsusho_SeishikiF–{–¼‚Æ’ÊÌ–¼‚ÅŒŸõ‰Â”\‚ÈDBj
                if (enHommyKensakuKB == FrnHommyoKensakuType.Tsusho)
                {

                    // ƒJƒi©–¼ ‹ó”’‚ð‹l‚ß‚Ä‚©‚ç´‰¹‰»‚·‚é
                    // * —š—ð”Ô† 0000001 2007/10/10 C³ŠJŽn
                    strSearchKana[0] = cuString.ToKanaKey(strKanaMeisho.Replace(" ", string.Empty)).ToUpper();
                    // strSearchKana(0) = cuString.ToKanaKey((strKanaMeisho).Replace(" ", String.Empty))
                    // * —š—ð”Ô† 0000001 2007/10/10 C³I—¹

                    // æ“ª‚©‚ç‚Ì‹ó”’ˆÊ’u‚ð’²‚×‚é
                    intIndex = strKanaMeisho.RIndexOf(" ");

                    // ‹ó”’‚ª‘¶Ý‚µ‚È‚¢ê‡
                    if (intIndex == -1)
                    {
                        // ƒJƒi©E–¼
                        strSearchKana[1] = strSearchKana[0];
                        strSearchKana[3] = strKanaMeisho;
                        strSearchKana[2] = string.Empty;
                        strSearchKana[4] = string.Empty;
                    }
                    else
                    {
                        // ƒJƒi©E–¼
                        // * —š—ð”Ô† 0000001 2007/10/10 C³ŠJŽn
                        strSearchKana[1] = cuString.ToKanaKey(strKanaMeisho.RSubstring(0, intIndex)).ToUpper();
                        // strSearchKana(1) = cuString.ToKanaKey(strKanaMeisho.Substring(0, intIndex))
                        // * —š—ð”Ô† 0000001 2007/10/10 C³I—¹
                        strSearchKana[3] = strKanaMeisho.RSubstring(0, intIndex);

                        // æ“ª‚©‚ç‚Ì‹ó”’ˆÊ’u‚ª•¶Žš—ñ’·‚ÆˆÈãê‡
                        if (intIndex + 1 >= strKanaMeisho.RLength)
                        {
                            strSearchKana[2] = string.Empty;
                            strSearchKana[4] = string.Empty;
                        }
                        else
                        {
                            // * —š—ð”Ô† 0000001 2007/10/10 C³ŠJŽn
                            strSearchKana[2] = cuString.ToKanaKey(strKanaMeisho.RSubstring(intIndex + 1)).ToUpper();
                            // strSearchKana(2) = cuString.ToKanaKey(strKanaMeisho.Substring(intIndex + 1))
                            // * —š—ð”Ô† 0000001 2007/10/10 C³I—¹
                            strSearchKana[4] = strKanaMeisho.RSubstring(intIndex + 1);
                        }
                    }
                }
                else
                {
                    // –{–¼‚Æ’ÊÌ–¼‚ÅŒŸõ‰Â”\‚ÈDB

                    // ƒJƒi©–¼ ‹ó”’‚ð‹l‚ß‚Ä‚©‚ç´‰¹‰»‚·‚é
                    strSearchKana[0] = cuString.ToKanaKey(strKanaMeisho.Replace(" ", string.Empty)).ToUpper();

                    // æ“ª‚©‚ç‚Ì‹ó”’ˆÊ’u‚ð’²‚×‚é
                    intIndex = strKanaMeisho.RIndexOf(" ");

                    // ‹ó”’‚ª‘¶Ý‚µ‚È‚¢ê‡ƒJƒi©‚Ì‚Ý‚ðƒZƒbƒg
                    if (intIndex == -1)
                    {
                        // ƒJƒi©
                        strSearchKana[1] = string.Empty;
                        strSearchKana[3] = strKanaMeisho;
                        strSearchKana[2] = string.Empty;
                        strSearchKana[4] = string.Empty;
                    }
                    else
                    {
                        // ƒJƒi©i–@l‚Ì‚ÝŽg—pj
                        strSearchKana[3] = strKanaMeisho.RSubstring(0, intIndex);

                        // æ“ª‚©‚ç‚Ì‹ó”’ˆÊ’u‚ª•¶Žš—ñ’·ˆÈã‚Ìê‡
                        if (intIndex + 1 >= strKanaMeisho.RLength)
                        {
                            strSearchKana[2] = string.Empty;
                            strSearchKana[4] = string.Empty;
                        }
                        else
                        {
                            strSearchKana[2] = cuString.ToKanaKey(strKanaMeisho.RSubstring(intIndex + 1)).ToUpper();
                            // ƒJƒi–¼i–@l‚Ì‚ÝŽg—pj
                            strSearchKana[4] = strKanaMeisho.RSubstring(intIndex + 1);
                        }
                    }

                    // –{–¼ƒJƒi©–¼
                    if (strKanaMeisho2.RLength > 0)
                    {
                        strSearchKana[1] = cuString.ToKanaKey(strKanaMeisho2.Replace(" ", string.Empty)).ToUpper();
                    }
                    else
                    {
                        strSearchKana[1] = string.Empty;
                    }

                }

                // *—š—ð”Ô† 000002 2023/08/14 C³ŠJŽn
                // 'ŒŸõƒJƒi©–¼‚ÌŒ…ƒ`ƒFƒbƒN
                // If strSearchKana(0).RLength > 40 Then
                // strSearchKana(0) = strSearchKana(0).RSubstring(0, 40)
                // End If
                if (strSearchKana[0].RLength > KANA_SEIMEI)
                {
                    strSearchKana[0] = strSearchKana[0].RSubstring(0, KANA_SEIMEI);
                }
                // *—š—ð”Ô† 000002 2023/08/14 C³I—¹

                // *—š—ð”Ô† 000002 2023/08/14 C³ŠJŽn
                // 'ŒŸõƒJƒi©‚ÌŒ…ƒ`ƒFƒbƒN
                // If strSearchKana(1).RLength > 24 Then
                // strSearchKana(1) = strSearchKana(1).RSubstring(0, 24)
                // End If
                if (strSearchKana[1].RLength > KANA_SEI)
                {
                    strSearchKana[1] = strSearchKana[1].RSubstring(0, KANA_SEI);
                }
                // *—š—ð”Ô† 000002 2023/08/14 C³I—¹

                // *—š—ð”Ô† 000002 2023/08/14 C³ŠJŽn
                // 'ŒŸõƒJƒi–¼‚ÌŒ…ƒ`ƒFƒbƒN
                // If strSearchKana(2).RLength > 16 Then
                // strSearchKana(2) = strSearchKana(2).RSubstring(0, 16)
                // End If
                if (strSearchKana[2].RLength > KANA_MEI)
                {
                    strSearchKana[2] = strSearchKana[2].RSubstring(0, KANA_MEI);
                }
                // *—š—ð”Ô† 000002 2023/08/14 C³I—¹

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }


            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10656


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10754


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLog.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11019


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11104


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return strSearchKana;

        }
        #endregion
    }
}