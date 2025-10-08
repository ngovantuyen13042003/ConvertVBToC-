// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ˆÙ“®Ž–—R(ABIdoJiyuBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/04/01@‘ê‘ò@‹Ô–ç
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 
// ************************************************************************************************

namespace Densan.Reams.AB.AB000BB
{

    public class ABIdoJiyuBClass
    {

        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABIdoJiyuBClass";

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶            Public Sub New(ByVal cfControlData As UFControlData, 
        // *                                  ByVal cfConfigData As UFConfigDataClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”            cfControlData As UFControlData         : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                   cfConfigData As UFConfigDataClass      : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg 
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABIdoJiyuBClass(UFControlData cfControlData, UFConfigDataClass cfConfigData)
        {

            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(cfConfigData, cfControlData.m_strBusinessId);

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ˆÙ“®Ž–—RŽæ“¾
        // * 
        // * \•¶            Public Sub GetIdoJiyu(ByVal strAtenaDataKB As String,
        // *                                         ByVal strAtenaDataSHU As String)
        // * 
        // * ‹@”\@@        ˆ¶–¼ƒf[ƒ^‹æ•ªAˆ¶–¼ƒf[ƒ^Ží•Ê‚æ‚è–¼Ì‚ð•ÒW‚·‚é
        // * 
        // * ˆø”            strIdoJiyuCD As String   : ˆÙ“®Ž–—RƒR[ƒh
        // * 
        // * –ß‚è’l          ˆÙ“®Ž–—R(String)
        // ************************************************************************************************
        public string GetIdoJiyu(string strIdoJiyuCD)
        {
            const string THIS_METHOD_NAME = "GetIdoJiyu";
            string strIdoJiyu;

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                switch (strIdoJiyuCD ?? "")
                {
                    case "001":
                    case "01":
                        {
                            strIdoJiyu = "íœ";
                            break;
                        }
                    case "002":
                    case "02":
                        {
                            strIdoJiyu = "’Ç‰Á";
                            break;
                        }
                    case "010":
                    case "10":
                        {
                            strIdoJiyu = default
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
             "“]“ü"

              */;/* TODO ERROR: Skipped SkippedTokensTrivia
]“ü"*/
                            break;
                        }
                    case "011":
                    case "11":
                        {
                            strIdoJiyu = "o¶";
                            break;
                        }
                    case "012":
                    case "12":
                        {
                            strIdoJiyu = "EŒ ‹LÚ";
                            break;
                        }
                    case "013":
                    case "13":
                        {
                            strIdoJiyu = "‹A‰»";
                            break;
                        }
                    case "014":
                    case "14":
                        {
                            strIdoJiyu = default
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
             "‘ÐŽæ“¾"
                             Case "015", "15"
                                 strIdoJiyu = "‰ñ•œ"
                             Case "020", "20"
                                 strIdoJiyu = "“]o"

              */;/* TODO ERROR: Skipped SkippedTokensTrivia
¾"
                Case "015", "15"
                    strIdoJiyu = "‰ñ•œ"
                Case "020", "20"
                    strIdoJiyu = "“]o"*/
                            break;
                        }
                    case "021":
                    case "21":
                        {
                            strIdoJiyu = "Ž€–S";
                            break;
                        }
                    case "022":
                    case "22":
                        {
                            strIdoJiyu = "EŒ Áœ";
                            break;
                        }
                    case "023":
                    case "23":
                        {
                            strIdoJiyu = "‘Ð‘rŽ¸";
                            break;
                        }
                    case "024":
                    case "24":
                        {
                            strIdoJiyu = "Ž¸çH";
                            break;
                        }

                    default:
                        {
                            strIdoJiyu = "";
                            break;
                        }
                }

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 4628


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 4726


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 4968


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 5053


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return strIdoJiyu;

        }

    }
}