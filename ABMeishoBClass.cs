// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        –¼Ì(ABMeishoBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/07/25@‘ê‘ò@‹Ô–ç
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// *
// ************************************************************************************************
using System;
using Microsoft.VisualBasic;

namespace Densan.Reams.AB.AB000BB
{

    public class ABMeishoBClass
    {
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfUFLogClass;            // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfUFControlData;      // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABMeishoBClass";

        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        private string m_strKeitaiFuyoKB;                     // ‹æ•ªi1Œ…j
        private string m_strKeitaiSeiRyakuKB;                 // ‹æ•ªi1Œ…j
        private string m_strKanjiHjnKeitai;                   // Œ`‘Ôi‘SŠp@Max‚P‚O•¶Žšj
        private string m_strKanjiMeisho1;                     // –¼Ìi‘SŠp@Max‚S‚O•¶Žšj
        private string m_strKanjiMeisho2;                     // –¼Ìi‘SŠp@Max‚S‚O•¶Žšj
        private string m_strAtenaDataKB;                      // ˆ¶–¼ƒf[ƒ^‹æ•ª
        private ABHojinMeishoBClass m_cHojinMeishoBClass;     // –@l–¼ÌƒNƒ‰ƒX

        // Šeƒƒ“ƒo•Ï”‚ÌƒvƒƒpƒeƒB’è‹`
        public string p_strKeitaiFuyoKB
        {
            set
            {
                m_strKeitaiFuyoKB = value;
            }
        }
        public string p_strKeitaiSeiRyakuKB
        {
            set
            {
                m_strKeitaiSeiRyakuKB = value;
            }
        }
        public string p_strKanjiHjnKeitai
        {
            set
            {
                m_strKanjiHjnKeitai = value;
            }
        }
        public string p_strKanjiMeisho1
        {
            set
            {
                m_strKanjiMeisho1 = value;
            }
        }
        public string p_strKanjiMeisho2
        {
            set
            {
                m_strKanjiMeisho2 = value;
            }
        }
        public string p_strAtenaDataKB
        {
            set
            {
                m_strAtenaDataKB = value;
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
        public ABMeishoBClass(UFControlData cfControlData, UFConfigDataClass cfConfigData)
        {

            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfUFControlData = cfControlData;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfUFLogClass = new UFLogClass(cfConfigData, cfControlData.m_strBusinessId);

            // –@l–¼ÌƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            m_cHojinMeishoBClass = new ABHojinMeishoBClass(cfControlData, cfConfigData);

            // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
            m_strKeitaiFuyoKB = string.Empty;
            m_strKeitaiSeiRyakuKB = string.Empty;
            m_strKanjiHjnKeitai = string.Empty;
            m_strKanjiMeisho1 = string.Empty;
            m_strKanjiMeisho2 = string.Empty;
            m_strAtenaDataKB = string.Empty;
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      –¼Ì•ÒW
        // * 
        // * \•¶            Public Function GetMeisho() As String
        // * 
        // * ‹@”\@@        –@lŒ`‘Ô•t—^‹æ•ªA–@lŒ`‘Ô³Ž®—ªÌ‹æ•ªA–@lŒ`‘ÔA–¼Ì‚PA–¼Ì‚Q‚æ‚è–¼Ì‚ð•ÒW‚·‚é
        // * 
        // * ˆø”            –¼Ì
        // * 
        // * –ß‚è’l          •ÒW–¼ÌiStringj
        // ************************************************************************************************
        public string GetMeisho()
        {
            const string THIS_METHOD_NAME = "GetHojinMeisho";
            string strKanjiMeisho = string.Empty;

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                switch (m_strAtenaDataKB ?? "")
                {
                    case var @case when @case == ABConstClass.ATENADATAKB_HOJIN:
                        {
                            // –@l‚Ì–¼Ì‚Ì•ÒW
                            m_cHojinMeishoBClass.p_strKeitaiFuyoKB = m_strKeitaiFuyoKB;
                            m_cHojinMeishoBClass.p_strKeitaiSeiRyakuKB = m_strKeitaiSeiRyakuKB;
                            m_cHojinMeishoBClass.p_strKanjiHjnKeitai = m_strKanjiHjnKeitai;
                            m_cHojinMeishoBClass.p_strKanjiMeisho1 = m_strKanjiMeisho1;
                            m_cHojinMeishoBClass.p_strKanjiMeisho2 = m_strKanjiMeisho2;
                            strKanjiMeisho = m_cHojinMeishoBClass.GetHojinMeisho();
                            break;
                        }

                    default:
                        {
                            strKanjiMeisho = m_strKanjiMeisho1;
                            break;
                        }
                }

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (Exception objExp)
            {

                // ƒGƒ‰[ƒƒOo—Í
                m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + @"zyƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + default
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
       "zyƒGƒ‰[“
        */
       );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 6221


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return strKanjiMeisho

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼      –¼Ì•ÒW
                    '* 
                    '* \•¶            Public Function GetHojinMeisho(ByVal cABHojinMeishoParaX() As ABHojinMeishoParaXClass) As String()
                    '* 
                    '* ‹@”\@@        –@lŒ`‘Ô•t—^‹æ•ªA–@lŒ`‘Ô³Ž®—ªÌ‹æ•ªA–@lŒ`‘ÔA–¼Ì‚PA–¼Ì‚Q‚æ‚è–¼Ì‚ð•ÒW‚·‚é

                 */
            }

            return default;
        }
        // * 
        // * ˆø”            –¼Ìƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX   : ABMeishoParaXClass[]
        // * 
        // * –ß‚è’l          •ÒW–¼ÌiString[]j
        // ************************************************************************************************
        public string[] GetMeisho(ABMeishoParaXClass[] cABMeishoParaX)
        {
            const string THIS_METHOD_NAME = "GetHojinMeisho";
            string[] strKanjiMeisho;
            int intIndex;

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                strKanjiMeisho = new string[Information.UBound(cABMeishoParaX) + 1];
                var loopTo = Information.UBound(cABMeishoParaX);
                for (intIndex = 0; intIndex <= loopTo; intIndex++)
                {
                    {
                        ref var withBlock = ref cABMeishoParaX[intIndex];
                        m_strKeitaiFuyoKB = withBlock.p_strKeitaiFuyoKB;
                        m_strKeitaiSeiRyakuKB = withBlock.p_strKeitaiSeiRyakuKB;
                        m_strKanjiHjnKeitai = withBlock.p_strKanjiHjnKeitai;
                        m_strKanjiMeisho1 = withBlock.p_strKanjiMeisho1;
                        m_strKanjiMeisho2 = withBlock.p_strKanjiMeisho2;
                        m_strAtenaDataKB = withBlock.p_strAtenaDataKB;
                    }
                    strKanjiMeisho[intIndex] = GetMeisho();
                }

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (Exception objExp)
            {
                // ƒGƒ‰[ƒƒOo—Í
                m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + @"zyƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + default
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
                "zyƒGƒ‰[“
                 */
                );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 8600


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return strKanjiMeisho

                    End Function
                End Class

                 */
            }

            return default;
        }
    }
}