// ************************************************************************************************
// * ‹Æ–±–¼           ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼         ”Ô’nƒR[ƒh•ÒW‚aƒNƒ‰ƒX(ABBanchiCDHenshuBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2009/04/07  H“¡@”ü•‡—R
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 
// ************************************************************************************************
using System.Security;

namespace Densan.Reams.AB.AB000BB
{

    public class ABBanchiCDHenshuBClass
    {

        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfUFLogClass;                            // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfUFControlData;                      // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfUFConfigDataClass;              // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                              // ‚q‚c‚aƒNƒ‰ƒX
        private URBANCHICDMSTBClass m_crBanchiCdMstB;                 // ‚t‚q”Ô’nƒR[ƒhƒ}ƒXƒ^ƒNƒ‰ƒX
        private UFErrorClass m_cfErrorClass;                          // ƒGƒ‰[ˆ—ƒNƒ‰ƒX

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABBanchiCDHenshuBClass";
        private const string THIS_BUSINESSID = "AB";


        #endregion

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
        [SecuritySafeCritical]
        public ABBanchiCDHenshuBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)
        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfUFControlData = cfControlData;
            m_cfUFConfigDataClass = cfConfigDataClass;
            m_cfRdbClass = new UFRdbClass(m_cfUFControlData.m_strBusinessId);

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfUFLogClass = new UFLogClass(m_cfUFConfigDataClass, m_cfUFControlData.m_strBusinessId);

            // ‚t‚q”Ô’nƒR[ƒhƒ}ƒXƒ^ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            if (m_crBanchiCdMstB is null)
            {
                m_crBanchiCdMstB = new URBANCHICDMSTBClass(cfControlData, cfConfigDataClass, m_cfRdbClass);
            }

        }
        #endregion

        #region ƒƒ\ƒbƒh

        #region CreateBanchiCD:”
        // **********************************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ”Ô’nƒR[ƒh•ÒW
        // * 
        // * \•¶           Public Function CreateBanchiCD(ByVal strBanchi As String) As String()
        // * 
        // * ‹@”\           ”Ô’n‚©‚ç”Ô’nƒR[ƒh‚P`‚R‚ð•ÒW‚·‚é
        // * 
        // * ˆø”           strBanchi     ”Ô’n
        // *
        // * –ß‚è’l         String()      •ÒW‚µ‚½”Ô’nƒR[ƒh”z—ñ
        // *
        // **********************************************************************************************************************
        [SecuritySafeCritical]
        public string[] CreateBanchiCD(string strBanchi)
        {
            string THIS_METHOD_NAME = "CreateBanchiCD";
            var strBanchiCD = new string[3];                        // ”Ô’nƒR[ƒh”z—ñiŽæ“¾—pj
            var strRetBanchiCD = new string[3];                     // ”Ô’nƒR[ƒh”z—ñi–ß‚è’l—pj
            var strMotoBanchiCD = default(string[]);                     // •ÏX‘O”Ô’nƒR[ƒh
            int intLoop;                              // ƒ‹[ƒvƒJƒEƒ“ƒ^

            try
            {

                // ”Ô’nƒR[ƒhŽæ“¾
                strBanchiCD = m_crBanchiCdMstB.GetBanchiCd(strBanchi, strMotoBanchiCD, true);

                var loopTo = strBanchiCD.Length - 1;
                for (intLoop = 0; intLoop <= loopTo; intLoop++)
                {
                    if (strBanchiCD[intLoop] == null)
                    {
                        // Žæ“¾‚µ‚½”Ô’nƒR[ƒh”z—ñ‚ÉNothing‚ª‚ ‚éê‡‚ÍString.Empty‚ðƒZƒbƒg
                        strBanchiCD[intLoop] = string.Empty;
                    }

                    // ”Ô’nƒR[ƒh‚ð‰E‹l‚·‚éi5Œ…‚É–ž‚½‚È‚¢ê‡‚Í”¼ŠpƒXƒy[ƒX‚ð¶‹lj
                    strRetBanchiCD[intLoop] = strBanchiCD[intLoop].Trim().RPadLeft(5, ' ');
                }
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 5427


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 5528


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 5784


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 5867


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")

                                 */
                throw;
            }

            return strRetBanchiCD;

        }
        #endregion

        #endregion

    }
}