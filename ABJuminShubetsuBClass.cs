// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        Z–¯Ží•Ê(ABJuminShubetsuBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2002/12/13@ŽRè@•q¶
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2011/03/31   000001     Z–¯Ží•ÊŽæ“¾‚Qƒƒ\ƒbƒh(GetJuminshubetsu2)‚Ì’Ç‰Ái”ä‰Ãj
// ************************************************************************************************
using System;

namespace Densan.Reams.AB.AB000BB
{

    public class ABJuminShubetsuBClass
    {

        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfUFLogClass;            // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfUFControlData;      // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^

        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        private string m_strHenshuShubetsu;           // Ží•Êi‘SŠp@Max‚W•¶Žšj
        private string m_strHenshuShubetsuRyaku;      // —ªÌi‘SŠp@Max‚R•¶Žšj

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABJuminShubetsuBClass";

        // Šeƒƒ“ƒo•Ï”‚ÌƒvƒƒpƒeƒB’è‹`
        public string p_strHenshuShubetsu
        {
            get
            {
                return m_strHenshuShubetsu;
            }
        }
        public string p_strHenshuShubetsuRyaku
        {
            get
            {
                return m_strHenshuShubetsuRyaku;
            }
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶            Public Sub New(ByVal cfUFControlData As UFControlData, 
        // *                               ByVal cfUFConfigData As UFConfigDataClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”            cfUFControlData As UFControlData         : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                 cfUFConfigData As UFConfigDataClass      : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg 
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABJuminShubetsuBClass(UFControlData cfControlData, UFConfigDataClass cfConfigData)
        {

            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfUFControlData = cfControlData;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfUFLogClass = new UFLogClass(cfConfigData, cfControlData.m_strBusinessId);

            // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
            m_strHenshuShubetsu = string.Empty;
            m_strHenshuShubetsuRyaku = string.Empty;
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      Z–¯Ží•ÊŽæ“¾
        // * 
        // * \•¶            Public Sub GetJuminshubetsu(ByVal strAtenaDataKB As String,
        // *                                             ByVal strAtenaDataSHU As String)
        // * 
        // * ‹@”\@@        ˆ¶–¼ƒf[ƒ^‹æ•ªAˆ¶–¼ƒf[ƒ^Ží•Ê‚æ‚è–¼Ì‚ð•ÒW‚·‚é
        // * 
        // * ˆø”            strAtenaDataKB As String   :ˆ¶–¼ƒf[ƒ^‹æ•ª
        // *                 strAtenaDataSHU As String  :ˆ¶–¼ƒf[ƒ^Ží•Ê
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public void GetJuminshubetsu(string strAtenaDataKB, string strAtenaDataSHU)
        {
            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, "GetJuminshubetsu");

                switch (strAtenaDataKB ?? "")
                {
                    case "20":
                        {
                            m_strHenshuShubetsu = "–@@l";
                            m_strHenshuShubetsuRyaku = "–@@l";
                            break;
                        }
                    case "30":
                        {
                            m_strHenshuShubetsu = "‹¤@—L";
                            m_strHenshuShubetsuRyaku = "‹¤@—L";
                            break;
                        }

                    default:
                        {
                            switch (strAtenaDataSHU ?? "")
                            {
                                case "10":
                                    {
                                        m_strHenshuShubetsu = default
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
                 "“ú–{lEZ–¯"
                                             m_strHenshuShubetsuRyaku = ""
                                         Case "13"
                                             m_strHenshuShubetsu = "“ú–{liZ“oŠOj"
                                             m_strHenshuShubetsuRyaku = "Z“oŠO"

                  */;/* TODO ERROR: Skipped SkippedTokensTrivia
ú–{lEZ–¯"
                            m_strHenshuShubetsuRyaku = ""
                        Case "13"
                            m_strHenshuShubetsu = "“ú–{liZ“oŠOj"
                            m_strHenshuShubetsuRyaku = "Z“oŠO"*/
                                        break;
                                    }
                                case "14":
                                    {
                                        m_strHenshuShubetsu = "‚»‚Ì‘¼ŒÂl";
                                        m_strHenshuShubetsuRyaku = "‚»‚Ì‘¼";
                                        break;
                                    }
                                case "17":
                                    {
                                        m_strHenshuShubetsu = default
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
                 "“ú–{lEÁœŽÒ"
                                             m_strHenshuShubetsuRyaku = "Á@œ"
                                         Case "18"
                                             m_strHenshuShubetsu = "“ú–{lE“]oŽÒ"
                                             m_strHenshuShubetsuRyaku = "“]@o"

                  */;/* TODO ERROR: Skipped SkippedTokensTrivia
ú–{lEÁœŽÒ"
                            m_strHenshuShubetsuRyaku = "Á@œ"
                        Case "18"
                            m_strHenshuShubetsu = "“ú–{lE“]oŽÒ"
                            m_strHenshuShubetsuRyaku = "“]@o"*/
                                        break;
                                    }
                                case "19":
                                    {
                                        m_strHenshuShubetsu = default
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
                 "“ú–{lEŽ€–SŽÒ"
                                             m_strHenshuShubetsuRyaku = "Ž€@–S"
                                         Case "20"
                                             m_strHenshuShubetsu = "ŠO‘lFZ–¯"

                  */;/* TODO ERROR: Skipped SkippedTokensTrivia
ú–{lEŽ€–SŽÒ"
                            m_strHenshuShubetsuRyaku = "Ž€@–S"
                        Case "20"
                            m_strHenshuShubetsu = "ŠO*/// ‘lFZ–¯"
                                        m_strHenshuShubetsuRyaku = "ŠO‘l";
                                        break;
                                    }
                                case "23":
                                    {
                                        m_strHenshuShubetsu = default
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
                 "ŠO‘liZ“oŠOj"
                                             m_strHenshuShubetsuRyaku = "Z“oŠO"

                  */;/* TODO ERROR: Skipped SkippedTokensTrivia
oŠOj"
                            m_strHenshuShubetsuRyaku = "Z“oŠO"*/
                                        break;
                                    }
                                case "27":
                                    {
                                        m_strHenshuShubetsu = "ŠO‘lFÁœŽÒ";
                                        m_strHenshuShubetsuRyaku = "Á@œ";
                                        break;
                                    }
                                case "28":
                                    {
                                        m_strHenshuShubetsu = default
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
                 "ŠO‘lF“]oŽÒ"
                                             m_strHenshuShubetsuRyaku = "“]@o"

                  */;/* TODO ERROR: Skipped SkippedTokensTrivia
]oŽÒ"
                            m_strHenshuShubetsuRyaku = "“]@o"*/
                                        break;
                                    }
                                case "29":
                                    {
                                        m_strHenshuShubetsu = "ŠO‘lFŽ€–SŽÒ";
                                        m_strHenshuShubetsuRyaku = "Ž€@–S";
                                        break;
                                    }

                                default:
                                    {
                                        m_strHenshuShubetsu = "––––––––";
                                        m_strHenshuShubetsuRyaku = "–––";
                                        break;
                                    }
                            }

                            break;
                        }
                }

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, "GetJuminshubetsu");
            }
            catch (Exception objExp)
            {
                // ƒGƒ‰[ƒƒOo—Í
                m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + default
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
       "zyƒƒ\ƒbƒh–¼:GetJuminshubetsuzyƒGƒ‰[“
        */
       );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 6657


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try
                    End Sub

                    '*—š—ð”Ô† 000001 2011/03/31 ’Ç‰ÁŠJŽn

                 */
            }
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      Z–¯Ží•ÊŽæ“¾‚Q
        // * 
        // * \•¶            Public Sub GetJuminshubetsu2(ByVal strAtenaDataKB As String,
        // *                                              ByVal strAtenaDataSHU As String)
        // * 
        // * ‹@”\@@        ˆ¶–¼ƒf[ƒ^‹æ•ªAˆ¶–¼ƒf[ƒ^Ží•Ê‚æ‚è–¼Ì‚ð•ÒW‚·‚é
        // *                 ¦GetJuminshubetsuƒƒ\ƒbƒh‚ÆŠO‘l‚Ì•\Ž¦•û–@‚ªˆÙ‚È‚é
        // * 
        // * ˆø”            strAtenaDataKB As String   :ˆ¶–¼ƒf[ƒ^‹æ•ª
        // *                 strAtenaDataSHU As String  :ˆ¶–¼ƒf[ƒ^Ží•Ê
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public void GetJuminshubetsu2(string strAtenaDataKB, string strAtenaDataSHU)
        {
            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, "GetJuminshubetsu");

                switch (strAtenaDataKB ?? "")
                {
                    case "20":
                        {
                            m_strHenshuShubetsu = "–@@l";
                            m_strHenshuShubetsuRyaku = "–@@l";
                            break;
                        }
                    case "30":
                        {
                            m_strHenshuShubetsu = "‹¤@—L";
                            m_strHenshuShubetsuRyaku = "‹¤@—L";
                            break;
                        }

                    default:
                        {
                            switch (strAtenaDataSHU ?? "")
                            {
                                case "10":
                                    {
                                        m_strHenshuShubetsu = "Z–¯";
                                        m_strHenshuShubetsuRyaku = "";
                                        break;
                                    }
                                case "13":
                                    {
                                        m_strHenshuShubetsu = default
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
                                            "Z“oŠO"
                                                                        m_strHenshuShubetsuRyaku = "Z“oŠO"

                                             */;/* TODO ERROR: Skipped SkippedTokensTrivia
oŠO"
                            m_strHenshuShubetsuRyaku = "Z“oŠO"*/
                                        break;
                                    }
                                case "14":
                                    {
                                        m_strHenshuShubetsu = "‚»‚Ì‘¼ŒÂl";
                                        m_strHenshuShubetsuRyaku = "‚»‚Ì‘¼";
                                        break;
                                    }
                                case "17":
                                    {
                                        m_strHenshuShubetsu = "EŒ ÁœŽÒ";
                                        m_strHenshuShubetsuRyaku = "Á@œ";
                                        break;
                                    }
                                case "18":
                                    {
                                        m_strHenshuShubetsu = default
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
                                            "“]oŽÒ"
                                                                        m_strHenshuShubetsuRyaku = "“]@o"

                                             */;/* TODO ERROR: Skipped SkippedTokensTrivia
]oŽÒ"
                            m_strHenshuShubetsuRyaku = "“]@o"*/
                                        break;
                                    }
                                case "19":
                                    {
                                        m_strHenshuShubetsu = "Ž€–SŽÒ";
                                        m_strHenshuShubetsuRyaku = "Ž€@–S";
                                        break;
                                    }
                                case "20":
                                    {
                                        m_strHenshuShubetsu = "ŠO‘lZ–¯";
                                        m_strHenshuShubetsuRyaku = "ŠO‘l";
                                        break;
                                    }
                                case "23":
                                    {
                                        m_strHenshuShubetsu = default
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
                                            "ŠO‘lZ“oŠO"
                                                                        m_strHenshuShubetsuRyaku = "Z“oŠO(ŠO‘l)"

                                             */;/* TODO ERROR: Skipped SkippedTokensTrivia
oŠO"
                            m_strHenshuShubetsuRyaku = "Z“oŠO(ŠO‘l)"*/
                                        break;
                                    }
                                case "27":
                                    {
                                        m_strHenshuShubetsu = "ŠO‘lEŒ ÁœŽÒ";
                                        m_strHenshuShubetsuRyaku = "Áœ(ŠO‘l)";
                                        break;
                                    }
                                case "28":
                                    {
                                        m_strHenshuShubetsu = default
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
                                            "ŠO‘l“]oŽÒ"
                                                                        m_strHenshuShubetsuRyaku = "“]o(ŠO‘l)"

                                             */;/* TODO ERROR: Skipped SkippedTokensTrivia
]oŽÒ"
                            m_strHenshuShubetsuRyaku = "“]o(ŠO‘l)"*/
                                        break;
                                    }
                                case "29":
                                    {
                                        m_strHenshuShubetsu = "ŠO‘lŽ€–SŽÒ";
                                        m_strHenshuShubetsuRyaku = "Ž€–S(ŠO‘l)";
                                        break;
                                    }

                                default:
                                    {
                                        m_strHenshuShubetsu = "––––––––";
                                        m_strHenshuShubetsuRyaku = "–––";
                                        break;
                                    }
                            }

                            break;
                        }
                }

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, "GetJuminshubetsu");
            }
            catch (Exception objExp)
            {
                // ƒGƒ‰[ƒƒOo—Í
                m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + default
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
                "zyƒƒ\ƒbƒh–¼:GetJuminshubetsuzyƒGƒ‰[“
                 */
                );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10805


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try
                    End Sub
                    '*—š—ð”Ô† 000001 2011/03/31 ’Ç‰ÁI—¹

                 */
            }
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      Z–¯Ží•Ê•ÒW
        // * 
        // * \•¶            Public Function GetJuminshubetsu() As DataSet
        // * 
        // * ‹@”\@@        ˆ¶–¼ƒf[ƒ^Ží•Ê‚ÌƒR[ƒh‚Æ–¼Ì‚ð•ÒW‚·‚é
        // * 
        // * ˆø”            ‚È‚µ
        // * 
        // * –ß‚è’l          Ží•Êƒf[ƒ^iDataSetj
        // *                   \‘¢FcsShubetsuData    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABShubetsuData
        // ************************************************************************************************
        public DataSet GetJuminshubetsu()
        {
            var csShubetsuData = new DataSet();
            DataTable csShubetsuDataTbl;
            DataRow csShubetsuDataRow;

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, "GetJuminshubetsu");

                // ƒe[ƒuƒ‹‚ðì¬‚·‚é
                csShubetsuDataTbl = csShubetsuData.Tables.Add(ABShubetsuData.TABLE_NAME);

                // ƒe[ƒuƒ‹”z‰º‚É•K—vƒtƒB[ƒ‹ƒh‚ð—pˆÓ‚·‚é
                csShubetsuDataTbl.Columns.Add(ABShubetsuData.ATENADATASHU, Type.GetType("System.String"));
                csShubetsuDataTbl.Columns.Add(ABShubetsuData.HENSHUSHUBETSU, Type.GetType("System.String"));
                csShubetsuDataTbl.Columns.Add(ABShubetsuData.HENSHUSHUBETSURYAKU, Type.GetType("System.String"));

                // ŠeƒtƒB[ƒ‹ƒh‚Éƒf[ƒ^‚ðŠi”[‚·‚é
                // ˆ¶–¼ƒf[ƒ^Ží•Ê = 10
                csShubetsuDataRow = csShubetsuDataTbl.NewRow();
                csShubetsuDataRow.Item(ABShubetsuData.ATENADATASHU) = "10";
                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSU) = default
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
                                    "“ú–{lEZ–¯"
                                                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = ""
                                                'ƒf[ƒ^‚Ì’Ç‰Á
                                                csShubetsuData.Tables(ABShubetsuData.TABLE_NAME).Rows.Add(csShubetsuDataRow)

                                                'ˆ¶–¼ƒf[ƒ^Ží•Ê = 13
                                                csShubetsuDataRow = csShubetsuDataTbl.NewRow()
                                                csShubetsuDataRow.Item(ABShubetsuData.ATENADATASHU) = "13"
                                                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSU) = "“ú–{liZ“oŠOj"
                                                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = "Z“oŠO"

                                     */;/* TODO ERROR: Skipped SkippedTokensTrivia
ú–{lEZ–¯"
            csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = ""
            'ƒf[ƒ^‚Ì’Ç‰Á
            csShubetsuData.Tables(ABShubetsuData.TABLE_NAME).Rows.Add(csShubetsuDataRow)

            'ˆ¶–¼ƒf[ƒ^Ží•Ê = 13
            csShubetsuDataRow = csShubetsuDataTbl.NewRow()
            csShubetsuDataRow.Item(ABShubetsuData.ATENADATASHU) = "13"
            csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSU) = "“ú–{liZ“oŠOj"
            csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = "Z“oŠO"*/
                // ƒf[ƒ^‚Ì’Ç‰Á
                csShubetsuData.Tables(ABShubetsuData.TABLE_NAME).Rows.Add(csShubetsuDataRow);

                // ˆ¶–¼ƒf[ƒ^Ží•Ê = 14
                csShubetsuDataRow = csShubetsuDataTbl.NewRow();
                csShubetsuDataRow.Item(ABShubetsuData.ATENADATASHU) = "14";
                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSU) = "‚»‚Ì‘¼ŒÂl";
                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = "‚»‚Ì‘¼";
                // ƒf[ƒ^‚Ì’Ç‰Á
                csShubetsuData.Tables(ABShubetsuData.TABLE_NAME).Rows.Add(csShubetsuDataRow);

                // ˆ¶–¼ƒf[ƒ^Ží•Ê = 17
                csShubetsuDataRow = csShubetsuDataTbl.NewRow();
                csShubetsuDataRow.Item(ABShubetsuData.ATENADATASHU) = "17";
                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSU) = default
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
                                    "“ú–{lEÁœŽÒ"
                                                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = "Á@œ"
                                                'ƒf[ƒ^‚Ì’Ç‰Á
                                                csShubetsuData.Tables(ABShubetsuData.TABLE_NAME).Rows.Add(csShubetsuDataRow)

                                                'ˆ¶–¼ƒf[ƒ^Ží•Ê = 18
                                                csShubetsuDataRow = csShubetsuDataTbl.NewRow()
                                                csShubetsuDataRow.Item(ABShubetsuData.ATENADATASHU) = "18"
                                                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSU) = "“ú–{lE“]oŽÒ"
                                                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = "“]@o"

                                     */;/* TODO ERROR: Skipped SkippedTokensTrivia
ú–{lEÁœŽÒ"
            csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = "Á@œ"
            'ƒf[ƒ^‚Ì’Ç‰Á
            csShubetsuData.Tables(ABShubetsuData.TABLE_NAME).Rows.Add(csShubetsuDataRow)

            'ˆ¶–¼ƒf[ƒ^Ží•Ê = 18
            csShubetsuDataRow = csShubetsuDataTbl.NewRow()
            csShubetsuDataRow.Item(ABShubetsuData.ATENADATASHU) = "18"
            csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSU) = "“ú–{lE“]oŽÒ"
            csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = "“]@o"*/
                // ƒf[ƒ^‚Ì’Ç‰Á
                csShubetsuData.Tables(ABShubetsuData.TABLE_NAME).Rows.Add(csShubetsuDataRow);

                // ˆ¶–¼ƒf[ƒ^Ží•Ê = 19
                csShubetsuDataRow = csShubetsuDataTbl.NewRow();
                csShubetsuDataRow.Item(ABShubetsuData.ATENADATASHU) = "19";
                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSU) = default
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
                                    "“ú–{lEŽ€–SŽÒ"
                                                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = "Ž€@–S"
                                                'ƒf[ƒ^‚Ì’Ç‰Á
                                                csShubetsuData.Tables(ABShubetsuData.TABLE_NAME).Rows.Add(csShubetsuDataRow)

                                                'ˆ¶–¼ƒf[ƒ^Ží•Ê = 20
                                                csShubetsuDataRow = csShubetsuDataTbl.NewRow()
                                                csShubetsuDataRow.Item(ABShubetsuData.ATENADATASHU) = "20"
                                                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSU) = "ŠO‘lFZ–¯"

                                     */;/* TODO ERROR: Skipped SkippedTokensTrivia
ú–{lEŽ€–SŽÒ"
            csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = "Ž€@–S"
            'ƒf[ƒ^‚Ì’Ç‰Á
            csShubetsuData.Tables(ABShubetsuData.TABLE_NAME).Rows.Add(csShubetsuDataRow)

            'ˆ¶–¼ƒf[ƒ^Ží•Ê = 20
            csShubetsuDataRow = csShubetsuDataTbl.NewRow()
            csShubetsuDataRow.Item(ABShubetsuData.ATENADATASHU) = "20"
            csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSU) = "ŠO*/// ‘lFZ–¯"
                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = "ŠO‘l";
                // ƒf[ƒ^‚Ì’Ç‰Á
                csShubetsuData.Tables(ABShubetsuData.TABLE_NAME).Rows.Add(csShubetsuDataRow);

                // ˆ¶–¼ƒf[ƒ^Ží•Ê = 23
                csShubetsuDataRow = csShubetsuDataTbl.NewRow();
                csShubetsuDataRow.Item(ABShubetsuData.ATENADATASHU) = "23";
                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSU) = default
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
                                    "ŠO‘liZ“oŠOj"
                                                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = "Z“oŠO"

                                     */;/* TODO ERROR: Skipped SkippedTokensTrivia
oŠOj"
            csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = "Z“oŠO"*/
                // ƒf[ƒ^‚Ì’Ç‰Á
                csShubetsuData.Tables(ABShubetsuData.TABLE_NAME).Rows.Add(csShubetsuDataRow);

                // ˆ¶–¼ƒf[ƒ^Ží•Ê = 27
                csShubetsuDataRow = csShubetsuDataTbl.NewRow();
                csShubetsuDataRow.Item(ABShubetsuData.ATENADATASHU) = "27";
                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSU) = "ŠO‘lFÁœŽÒ";
                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = "Á@œ";
                // ƒf[ƒ^‚Ì’Ç‰Á
                csShubetsuData.Tables(ABShubetsuData.TABLE_NAME).Rows.Add(csShubetsuDataRow);

                // ˆ¶–¼ƒf[ƒ^Ží•Ê = 28
                csShubetsuDataRow = csShubetsuDataTbl.NewRow();
                csShubetsuDataRow.Item(ABShubetsuData.ATENADATASHU) = "28";
                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSU) = default
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
                                    "ŠO‘lF“]oŽÒ"
                                                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = "“]@o"

                                     */;/* TODO ERROR: Skipped SkippedTokensTrivia
]oŽÒ"
            csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = "“]@o"*/
                // ƒf[ƒ^‚Ì’Ç‰Á
                csShubetsuData.Tables(ABShubetsuData.TABLE_NAME).Rows.Add(csShubetsuDataRow);

                // ˆ¶–¼ƒf[ƒ^Ží•Ê = 29
                csShubetsuDataRow = csShubetsuDataTbl.NewRow();
                csShubetsuDataRow.Item(ABShubetsuData.ATENADATASHU) = "29";
                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSU) = "ŠO‘lFŽ€–SŽÒ";
                csShubetsuDataRow.Item(ABShubetsuData.HENSHUSHUBETSURYAKU) = "Ž€@–S";
                // ƒf[ƒ^‚Ì’Ç‰Á
                csShubetsuData.Tables(ABShubetsuData.TABLE_NAME).Rows.Add(csShubetsuDataRow);

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, "GetJuminshubetsu");
            }
            catch (Exception objExp)
            {
                // ƒGƒ‰[ƒƒOo—Í
                m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + default
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
                "zyƒƒ\ƒbƒh–¼:GetJuminshubetsuzyƒGƒ‰[“
                 */
                );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17861


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return csShubetsuData
                    End Function

                End Class

                 */
            }

            return default;
        }
    }
}