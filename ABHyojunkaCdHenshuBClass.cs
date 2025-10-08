// ************************************************************************************************
// * ‹Æ–±–¼           ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼         •W€‰»ƒR[ƒh•ÒW‚aƒNƒ‰ƒX(ABHyojunkaCdHenshuBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2023/03/13  ’‡¼@Ÿ
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 
// ************************************************************************************************

namespace Densan.Reams.AB.AB000BB
{

    public class ABHyojunkaCdHenshuBClass
    {

        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFControlData m_cfControlData;                        // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;                // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFLogClass m_cfLogClass;                              // ƒƒOo—ÍƒNƒ‰ƒX

        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        private string m_strJuminKbn;                                 // Z–¯‹æ•ª
        private string m_strJuminShubetsu;                            // Z–¯Ží•Ê
        private string m_strJuminJotai;                               // Z–¯ó‘Ô

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABHyojunkaCdHenshuBClass";

        // Šeƒƒ“ƒo•Ï”‚ÌƒvƒƒpƒeƒB’è‹`
        public string p_strJuminKbn
        {
            get
            {
                return m_strJuminKbn;
            }
        }
        public string p_strJuminShubetsu
        {
            get
            {
                return m_strJuminShubetsu;
            }
        }
        public string p_strJuminJotai
        {
            get
            {
                return m_strJuminJotai;
            }
        }

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
        public ABHyojunkaCdHenshuBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass)
        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigDataClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(m_cfConfigDataClass, m_cfControlData.m_strBusinessId);

            // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
            m_strJuminKbn = string.Empty;
            m_strJuminShubetsu = string.Empty;
            m_strJuminJotai = string.Empty;

        }
        #endregion

        #region ƒƒ\ƒbƒh

        #region HenshuHyojunkaCd:•W€‰»ƒR[ƒh•ÒW
        // **********************************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     •W€‰»ƒR[ƒh•ÒW
        // * 
        // * \•¶           Public Sub HenshuHyojunkaCd(ByVal strAtenaDataKB As String, ByVal strAtenaDataSHU As String)
        // * 
        // * ‹@”\           ŠeƒR[ƒh‚ð•W€‰»€‹’‚É€‚¸‚é‘ÌŒn‚É•ÒW‚·‚é
        // * 
        // * ˆø”           strAtenaDataKB     ˆ¶–¼ƒf[ƒ^‹æ•ª
        // *                strAtenaDataSHU    ˆ¶–¼ƒf[ƒ^Ží•Ê
        // *
        // * –ß‚è’l         ‚È‚µ
        // *
        // **********************************************************************************************************************
        public void HenshuHyojunkaCd(string strAtenaDataKB, string strAtenaDataSHU)
        {
            string THIS_METHOD_NAME = "HenshuHyojunkaCd";

            try
            {
                m_strJuminKbn = GetJuminKbn(strAtenaDataKB);
                m_strJuminShubetsu = GetJuminShubetsu(strAtenaDataKB, strAtenaDataSHU);
                m_strJuminJotai = GetJuminJotai(strAtenaDataKB, strAtenaDataSHU);
            }

            catch (UFAppException exAppException)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 4901


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 5002


                Input:
                " + exAppException.Message + "z")
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 5255


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 5338


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")

                                 */
                throw;

            }

        }
        #endregion

        #region GetJuminKbn:Z–¯‹æ•ªŽæ“
        // **********************************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Z–¯‹æ•ªŽæ“¾
        // * 
        // * \•¶           Private Function GetJuminKbn(ByVal strAtenaDataKB As String) As String
        // * 
        // * ‹@”\           •W€‰»€‹’‚ÌƒR[ƒh‘ÌŒn‚É€‚¸‚éZ–¯‹æ•ª‚ð•Ô‹p‚·‚é
        // * 
        // * ˆø”           strAtenaDataKB     ˆ¶–¼ƒf[ƒ^‹æ•ª
        // *
        // * –ß‚è’l         String             Z–¯‹æ•ª
        // *
        // **********************************************************************************************************************
        private string GetJuminKbn(string strAtenaDataKB)
        {
            string THIS_METHOD_NAME = "GetJuminKbn";
            string strRet = string.Empty;

            try
            {
                switch (strAtenaDataKB ?? "")
                {
                    case var @case when @case == ABConstClass.ATENADATAKB_JUTONAI_KOJIN:
                        {
                            // Z–¯
                            strRet = "1";
                            break;
                        }
                    case var case1 when case1 == ABConstClass.ATENADATAKB_JUTOGAI_KOJIN:
                        {
                            // Z“oŠO
                            strRet = "2";
                            break;
                        }
                    case var case2 when case2 == ABConstClass.ATENADATAKB_HOJIN:
                        {
                            // –@l
                            strRet = "3";
                            break;
                        }

                    default:
                        {
                            // ˆÈŠO‚Ìê‡A‹ó”’‚ðÝ’è
                            strRet = string.Empty;
                            break;
                        }
                }
            }

            catch (UFAppException exAppException)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 7276


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 7377


                Input:
                " + exAppException.Message + "z")
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 7630


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 7713


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")

                                 */
                throw;

            }

            return strRet;
        }
        #endregion

        #region GetJuminShubetsu:Z–¯Ží•ÊŽæ“
        // **********************************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Z–¯Ží•ÊŽæ“¾
        // * 
        // * \•¶           Private Function GetJuminShubetsu(ByVal strAtenaDataKB As String) As String
        // * 
        // * ‹@”\           •W€‰»€‹’‚ÌƒR[ƒh‘ÌŒn‚É€‚¸‚éZ–¯Ží•Ê‚ð•Ô‹p‚·‚é
        // * 
        // * ˆø”           strAtenaDataKB     ˆ¶–¼ƒf[ƒ^‹æ•ª
        // *                strAtenaDataSHU    ˆ¶–¼ƒf[ƒ^Ží•Ê
        // *
        // * –ß‚è’l         String             Z–¯Ží•Ê
        // *
        // **********************************************************************************************************************
        private string GetJuminShubetsu(string strAtenaDataKB, string strAtenaDataSHU)
        {
            string THIS_METHOD_NAME = "GetJuminShubetsu";
            string strRet = string.Empty;

            try
            {
                switch (strAtenaDataKB ?? "")
                {
                    case var @case when @case == ABConstClass.ATENADATAKB_JUTONAI_KOJIN:
                    case var case1 when case1 == ABConstClass.ATENADATAKB_JUTOGAI_KOJIN:
                        {
                            if (strAtenaDataSHU.Trim().RLength > 0 && strAtenaDataSHU.Trim().RSubstring(0, 1) == "1")
                            {
                                // “ú–{l
                                strRet = "1";
                            }
                            else if (strAtenaDataSHU.Trim().RLength > 0 && strAtenaDataSHU.Trim().RSubstring(0, 1) == "2")
                            {
                                // ŠO‘l
                                strRet = "2";
                            }
                            else
                            {
                                // ˆÈŠO‚Ìê‡A‹ó”’‚ðÝ’è
                                strRet = string.Empty;
                            }

                            break;
                        }

                    default:
                        {
                            // ˆÈŠO‚Ìê‡A‹ó”’‚ðÝ’è
                            strRet = string.Empty;
                            break;
                        }
                }
            }

            catch (UFAppException exAppException)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10079


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10180


                Input:
                " + exAppException.Message + "z")
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10433


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10516


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")

                                 */
                throw;

            }

            return strRet;
        }
        #endregion

        #region GetJuminJotai:Z–¯ó‘ÔŽæ“
        // **********************************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Z–¯ó‘ÔŽæ“¾
        // * 
        // * \•¶           Private Function GetJuminJotai(ByVal strAtenaDataKB As String) As String
        // * 
        // * ‹@”\           •W€‰»€‹’‚ÌƒR[ƒh‘ÌŒn‚É€‚¸‚éZ–¯ó‘Ô‚ð•Ô‹p‚·‚é
        // * 
        // * ˆø”           strAtenaDataKB     ˆ¶–¼ƒf[ƒ^‹æ•ª
        // *                strAtenaDataSHU    ˆ¶–¼ƒf[ƒ^Ží•Ê
        // *
        // * –ß‚è’l         String             Z–¯ó‘Ô
        // *
        // **********************************************************************************************************************
        private string GetJuminJotai(string strAtenaDataKB, string strAtenaDataSHU)
        {
            string THIS_METHOD_NAME = "GetJuminJotai";
            string strRet = string.Empty;

            try
            {
                switch (strAtenaDataKB ?? "")
                {
                    case var @case when @case == ABConstClass.ATENADATAKB_JUTONAI_KOJIN:
                        {
                            switch (strAtenaDataSHU ?? "")
                            {
                                case var case1 when case1 == ABConstClass.JUMINSHU_NIHONJIN_JUMIN:
                                case var case2 when case2 == ABConstClass.JUMINSHU_GAIKOKUJIN_JUMIN:
                                    {
                                        // Z“oŽÒ
                                        strRet = "1";
                                        break;
                                    }
                                case var case3 when case3 == ABConstClass.JUMINSHU_NIHONJIN_TENSHUTU:
                                case var case4 when case4 == ABConstClass.JUMINSHU_GAIKOKUJIN_TENSHUTU:
                                    {
                                        // “]oŽÒ
                                        strRet = "2";
                                        break;
                                    }
                                case var case5 when case5 == ABConstClass.JUMINSHU_NIHONJIN_SHIBOU:
                                case var case6 when case6 == ABConstClass.JUMINSHU_GAIKOKUJIN_SHIBOU:
                                    {
                                        // Ž€–SŽÒ
                                        strRet = "3";
                                        break;
                                    }

                                default:
                                    {
                                        // ‚»‚Ì‘¼ÁœŽÒ
                                        strRet = "9";
                                        break;
                                    }
                            }

                            break;
                        }

                    case var case7 when case7 == ABConstClass.ATENADATAKB_JUTOGAI_KOJIN:
                        {
                            switch (strAtenaDataSHU ?? "")
                            {
                                case var case8 when case8 == ABConstClass.JUMINSHU_NIHONJIN_JUMIN:
                                case var case9 when case9 == ABConstClass.JUMINSHU_GAIKOKUJIN_JUMIN:
                                    {
                                        // Z“oŠOŽÒ
                                        strRet = "1";
                                        break;
                                    }
                                case var case10 when case10 == ABConstClass.JUMINSHU_NIHONJIN_SHIBOU:
                                case var case11 when case11 == ABConstClass.JUMINSHU_GAIKOKUJIN_SHIBOU:
                                    {
                                        // Ž€–SŽÒ
                                        strRet = "2";
                                        break;
                                    }

                                default:
                                    {
                                        // ‚»‚Ì‘¼ÁœŽÒ
                                        strRet = "9";
                                        break;
                                    }
                            }

                            break;
                        }

                    default:
                        {
                            // ˆÈŠO‚Ìê‡A‹ó”’‚ðÝ’è
                            strRet = string.Empty;
                            break;
                        }
                }
            }

            catch (UFAppException exAppException)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13813


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13914


                Input:
                " + exAppException.Message + "z")
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 14167


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 14250


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")

                                 */
                throw;

            }

            return strRet;
        }
        #endregion

        #endregion

    }
}