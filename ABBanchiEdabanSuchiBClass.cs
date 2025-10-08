// ************************************************************************************************
// * ‹Æ–±–¼           ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼         ”Ô’nƒR[ƒh•ÒW‚aƒNƒ‰ƒX(ABBanchiEdabanSuchiBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2023/08/14  ‘è —Y–î
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 
// ************************************************************************************************
using System.Security;
using Microsoft.VisualBasic;

namespace Densan.Reams.AB.AB000BB
{

    public class ABBanchiEdabanSuchiBClass
    {

        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfUFLogClass;                            // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfUFControlData;                      // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfUFConfigDataClass;              // ƒRƒ“ƒtƒBƒOƒf[ƒ^

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABBanchiEdabanSuchiBClass";

        #endregion

        #region ƒRƒ“
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
        [SecuritySafeCritical]
        public ABBanchiEdabanSuchiBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass)
        {

            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfUFControlData = cfControlData;
            m_cfUFConfigDataClass = cfConfigDataClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfUFLogClass = new UFLogClass(m_cfUFConfigDataClass, m_cfUFControlData.m_strBusinessId);

        }
        #endregion

        #region ƒƒ\ƒbƒh
        // **********************************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ”Ô’nƒR[ƒh•ÒW
        // * 
        // * \•¶           Public Function GetBanchiEdabanSuchi(ByVal strBanchiCD1 As String, ByVal strBanchiCD2 As String, _
        // *                                                     ByVal strBanchiCD3 As String) As String
        // * 
        // * ‹@”\           ”Ô’n‚©‚ç”Ô’nƒR[ƒh‚P`‚R‚ð•ÒW‚·‚é
        // * 
        // * ˆø”           strBanchiCD1 As String : ”Ô’nƒR[ƒh‚P
        // *                strBanchiCD2 As String : ”Ô’nƒR[ƒh‚Q
        // *                strBanchiCD3 As String : ”Ô’nƒR[ƒh‚R
        // *
        // * –ß‚è’l         String      •ÒW‚µ‚½”Ô’nƒR[ƒh
        // *
        // **********************************************************************************************************************
        [SecuritySafeCritical]
        public string GetBanchiEdabanSuchi(string strBanchiCD1, string strBanchiCD2, string strBanchiCD3)
        {
            string GetBanchiEdabanSuchiRet = default;
            string THIS_METHOD_NAME = "GetBanchiEdabanSuchi";
            string strAfterBanchiCD1;
            string strAfterBanchiCD2;
            string strAfterBanchiCD3;

            try
            {

                strAfterBanchiCD1 = GetBanchiCDChange(strBanchiCD1);
                strAfterBanchiCD2 = GetBanchiCDChange(strBanchiCD2);
                strAfterBanchiCD3 = GetBanchiCDChange(strBanchiCD3);

                // ˜AŒ‹‚µ‚Ä–ß‚è’l‚Æ‚·‚é
                GetBanchiEdabanSuchiRet = strAfterBanchiCD1 + strAfterBanchiCD2 + strAfterBanchiCD3;
            }

            catch (UFAppException exAppException)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 4421


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 4522


                Input:
                " + exAppException.Message + "z")
                            Throw
                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 4778


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 4861


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")

                                 */
                throw;
            }

            return GetBanchiEdabanSuchiRet;

        }

        // **********************************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ”Ô’nƒR[ƒh•ÏŠ·(5Œ…)
        // * 
        // * \•¶           Public Function GetBanchiCDChange(ByVal strBanchiCD As String) As String
        // * 
        // * ‹@”\           ”Ô’nƒR[ƒh‚É”’lˆÈŠO‚ª‘¶Ý‚µ‚½ê‡AˆÈ~‚ð‚O–„‚ß‚·‚é(5Œ…)
        // * 
        // * ˆø”           strBanchiCD As String : ”Ô’nƒR[ƒh
        // *
        // * –ß‚è’l         String      •ÒW‚µ‚½”Ô’nƒR[ƒh
        // *
        // **********************************************************************************************************************
        public string GetBanchiCDChange(string strBanchiCD)
        {
            string THIS_METHOD_NAME = "GetBanchiCDChange";
            string strBanchiCDAfter = string.Empty;

            // ”Ô’nƒR[ƒh‚‹ó”’‚Ìê‡
            if (!ReferenceEquals(strBanchiCD.Trim(), string.Empty))
            {
                // ”Ô’nƒR[ƒh‚É”’lˆÈŠO‚ªŠÜ‚Ü‚ê‚éê‡
                if (!Information.IsNumeric(strBanchiCD))
                {
                    // ˆê•¶Žš‚Ã‚Âƒ`ƒFƒbƒN‚ðs‚¢A”’lˆÈŠO‚ª‘¶Ý‚·‚éê‡AˆÈ~0–„‚ß‚·‚é(5Œ…)
                    foreach (string strBanchiData in strBanchiCD)
                    {
                        if (Information.IsNumeric(strBanchiData))
                        {
                            strBanchiCDAfter = strBanchiCDAfter + strBanchiData;
                        }

                        else if (strBanchiData == " ")
                        {
                            strBanchiCDAfter = strBanchiCDAfter + "0";
                        }

                        else
                        {
                            strBanchiCDAfter = strBanchiCDAfter.PadRight(5, '0');
                            break;
                        }
                    }
                }
                else if (strBanchiCD.Trim().Length < 5)
                {
                    // ”’l‚Ì‚Ý5Œ…ˆÈ‰º‚Ìê‡A‘O0‚Å5Œ…–„‚ß‚é
                    strBanchiCDAfter = strBanchiCD.Trim().PadLeft(5, '0');
                }
                else if (strBanchiCD.Trim().Length == 5)
                {
                    // ”’l‚Ì‚Ý5Œ…‚Ìê‡A‚»‚Ì‚Ü‚Ü•Ô‚·
                    strBanchiCDAfter = strBanchiCD;
                }
            }
            else
            {
                strBanchiCDAfter = string.Empty.PadLeft(5, '0');
            }

            return strBanchiCDAfter;

        }
        #endregion

    }
}