// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ŠÇ“àŠÇŠO(ABKannaiKangaiKBBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2002/12/17@ŽRè@•q¶
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 
// ************************************************************************************************
using System;

namespace Densan.Reams.AB.AB000BB
{

    public class ABKannaiKangaiKBBClass
    {
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfUFLogClass;                    // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfUFControlData;              // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfUFConfigDataClass;      // ƒRƒ“ƒtƒBƒOƒf[ƒ^

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABJuminShubetsuBClass";

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶            Public Sub New(ByVal cfControlData AS UFControlData,
        // *         @@@@               ByVal cfConfigData  AS UFConfigDataClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”            cfUFControlData As UFControlData         : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                 cfUFConfigDataClass As UFConfigDataClass : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg 
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABKannaiKangaiKBBClass(UFControlData cfControlData, UFConfigDataClass cfUFConfigDataClass)
        {

            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfUFControlData = cfControlData;
            m_cfUFConfigDataClass = cfUFConfigDataClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfUFLogClass = new UFLogClass(cfUFConfigDataClass, cfControlData.m_strBusinessId);
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ŠÇ“àŠÇŠOŽæ“¾
        // * 
        // * \•¶            Public Function GetKannaiKangai(strKannaiKangaiKB As String) As String
        // * 
        // * ‹@”\@@        ‹æ•ª‚æ‚èŠÇ“àŠÇŠO–¼Ì‚ðŽæ“¾
        // * 
        // * ˆø”            strKannaiKangaiKB As String   :ŠÇ“àŠÇŠO‹æ•ª
        // * 
        // * –ß‚è’l          ŠÇ“àŠÇŠO–¼Ì
        // ************************************************************************************************
        public string GetKannaiKangai(string strKannaiKangaiKB)
        {
            string strMeisho = string.Empty;
            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, "GetKannaiKangai");

                switch (strKannaiKangaiKB ?? "")
                {
                    case "1":
                        {
                            strMeisho = default
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
             "ŠÇ“à"
                             Case "2"
                                 strMeisho = "ŠÇŠO"
                         End Select

                         'ƒfƒoƒbƒOI—¹ƒƒOo—Í
                         m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, "GetKannaiKangai")

                     Catch objExp As Exception
                         'ƒGƒ‰[ƒƒOo—Í
                         m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:
              */;/* TODO ERROR: Skipped SkippedTokensTrivia
à"
                Case "2"
                    strMeisho = "ŠÇŠO"
            End Select

            'ƒfƒoƒbƒOI—¹ƒƒOo—Í
            m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, "GetKannaiKangai")

        Catch objExp As Exception
            'ƒGƒ‰[ƒƒOo—Í
            m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼*/
                            ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                            /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 3487


                            Input:
                            " + THIS_CLASS_NAME + "zyƒƒ\ƒbƒh–¼:
                             */
                            GetKannaiKangai();/* TODO ERROR: Skipped SkippedTokensTrivia
zyƒGƒ‰[“à—e:" + objExp.Message + "z")*/
                            // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            throw objExp;
                        }
                }
            }

            return strMeisho;
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ŠÇ“àŠÇŠO•ÒW
        // * 
        // * \•¶            Public Function HenKannaiKangai() As DataSet
        // * 
        // * ‹@”\@@        ŠÇ“àŠÇŠO‚ÌƒR[ƒh‚Æ–¼Ì‚ð•ÒW‚·‚é
        // * 
        // * ˆø”            ‚È‚µ
        // * 
        // * –ß‚è’l          ŠÇ“àŠÇŠO–¼ÌiDataSetj
        // *                   \‘¢FcsKannaiKangaiData    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABKannaiKangaiData
        // ************************************************************************************************
        public DataSet HenKannaiKangai()
        {
            var csKannaiKangaiData = new DataSet();
            DataTable csKannaiKangaiDataTbl;
            DataRow csKannaiKangaiDataRow;

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, "HenKannaiKangai");

                // ƒe[ƒuƒ‹‚ðì¬‚·‚é
                csKannaiKangaiDataTbl = csKannaiKangaiData.Tables.Add(ABKannaiKangaiData.TABLE_NAME);

                // ƒe[ƒuƒ‹”z‰º‚É•K—vƒtƒB[ƒ‹ƒh‚ð—pˆÓ‚·‚é
                csKannaiKangaiDataTbl.Columns.Add(ABKannaiKangaiData.KANNAIKANGAIKB, Type.GetType("System.String"));
                csKannaiKangaiDataTbl.Columns.Add(ABKannaiKangaiData.KANNAIKANGAIKBMEI, Type.GetType("System.String"));

                // ŠeƒtƒB[ƒ‹ƒh‚Éƒf[ƒ^‚ðŠi”[‚·‚é
                // ŠÇ“àŠÇŠO‹æ•ª = 1
                csKannaiKangaiDataRow = csKannaiKangaiDataTbl.NewRow();
                csKannaiKangaiDataRow.Item(ABKannaiKangaiData.KANNAIKANGAIKB) = "1";
                csKannaiKangaiDataRow.Item(ABKannaiKangaiData.KANNAIKANGAIKBMEI) = default
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
                                                                                    "ŠÇ“à"
                                                                                                'ƒf[ƒ^‚Ì’Ç‰Á
                                                                                                csKannaiKangaiData.Tables(ABKannaiKangaiData.TABLE_NAME).Rows.Add(csKannaiKangaiDataRow)

                                                                                                'ŠÇ“àŠÇŠO‹æ•ª = 2

                                                                                     */;/* TODO ERROR: Skipped SkippedTokensTrivia
à"
            'ƒf[ƒ^‚Ì’Ç‰Á
            csKannaiKangaiData.Tables(ABKannaiKangaiData.TABLE_NAME).Rows.Add(csKannaiKangaiDataRow)

            'ŠÇ“àŠÇŠO‹æ•ª = 2*/
                csKannaiKangaiDataRow = csKannaiKangaiDataTbl.NewRow();
                csKannaiKangaiDataRow.Item(ABKannaiKangaiData.KANNAIKANGAIKB) = "2";
                csKannaiKangaiDataRow.Item(ABKannaiKangaiData.KANNAIKANGAIKBMEI) = "ŠÇŠO";
                // ƒf[ƒ^‚Ì’Ç‰Á
                csKannaiKangaiData.Tables(ABKannaiKangaiData.TABLE_NAME).Rows.Add(csKannaiKangaiDataRow);

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, "HenKannaiKangai");
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
                                "zyƒƒ\ƒbƒh–¼:HenKannaiKangaizyƒGƒ‰[“
                                 */
                                );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 6396


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return csKannaiKangaiData
                    End Function

                End Class

                 */
            }

            return default;
        }
    }
}