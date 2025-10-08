// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        –@lŒÂl(ABKjnhjnKBBClass)
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

    public class ABKjnhjnKBBClass
    {
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfUFLogClass;            // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfUFControlData;      // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABKjnhjnKBBClass";

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
        public ABKjnhjnKBBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass)
        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfUFControlData = cfControlData;
            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfUFLogClass = new UFLogClass(cfConfigDataClass, cfControlData.m_strBusinessId);
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ŒÂl–@lŽæ“¾
        // * 
        // * \•¶            Public Function GetKjnhjn(strKjnhjnKB As String) As String
        // * 
        // * ‹@”\@@        ‹æ•ª‚æ‚èŠÇ“àŠÇŠO–¼Ì‚ðŽæ“¾
        // * 
        // * ˆø”            strKjnhjnKB As String   :ŒÂl–@l‹æ•ª
        // * 
        // * –ß‚è’l          ŒÂl–@l–¼Ì
        // ************************************************************************************************
        public string GetKjnhjn(string strKjnhjnKB)
        {
            string strMeisho = string.Empty;
            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, "GetKjnhjn");

                switch (strKjnhjnKB ?? "")
                {
                    case "1":
                        {
                            strMeisho = "ŒÂl";
                            break;
                        }
                    case "2":
                        {
                            strMeisho = "–@l";
                            break;
                        }
                }

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, "GetKjnhjn");
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
       "zyƒƒ\ƒbƒh–¼:GetKjnhjnzyƒGƒ‰[“
        */
       );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 3444


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return strMeisho
                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼      ŒÂl–@l•ÒW
                    '* 
                    '* \•¶            Public Function HenKangaiKangai() As DataSet
                    '* 
                    '* ‹@”\@@        ŒÂl–@l‚ÌƒR[ƒh‚Æ–¼Ì‚ð•ÒW‚·‚é

                 */
            }

            return default;
        }
        // * 
        // * ˆø”            ‚È‚µ
        // * 
        // * –ß‚è’l          ŒÂl–@l–¼ÌiDataSetj
        // *                   \‘¢FcsKjnHjnData    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABKjnHjnData
        // ************************************************************************************************
        public DataSet HenKangaiKangai()
        {
            var csKjnHjnData = new DataSet();
            DataTable csKjnHjnDataTbl;
            DataRow csKjnHjnDataRow;

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, "HenKangaiKangai");

                // ƒe[ƒuƒ‹‚ðì¬‚·‚é
                csKjnHjnDataTbl = csKjnHjnData.Tables.Add(ABKjnHjnData.TABLE_NAME);

                // ƒe[ƒuƒ‹”z‰º‚É•K—vƒtƒB[ƒ‹ƒh‚ð—pˆÓ‚·‚é
                csKjnHjnDataTbl.Columns.Add(ABKjnHjnData.KJNHJNKB, Type.GetType("System.String"));
                csKjnHjnDataTbl.Columns.Add(ABKjnHjnData.KJNHJNKBMEI, Type.GetType("System.String"));

                // ŠeƒtƒB[ƒ‹ƒh‚Éƒf[ƒ^‚ðŠi”[‚·‚é
                // ŒÂl–@l‹æ•ª = 1
                csKjnHjnDataRow = csKjnHjnDataTbl.NewRow();
                csKjnHjnDataRow.Item(ABKjnHjnData.KJNHJNKB) = "1";
                csKjnHjnDataRow.Item(ABKjnHjnData.KJNHJNKBMEI) = "ŒÂl";
                // ƒf[ƒ^‚Ì’Ç‰Á
                csKjnHjnData.Tables(ABKjnHjnData.TABLE_NAME).Rows.Add(csKjnHjnDataRow);

                // ŒÂl–@l‹æ•ª = 2
                csKjnHjnDataRow = csKjnHjnDataTbl.NewRow();
                csKjnHjnDataRow.Item(ABKjnHjnData.KJNHJNKB) = "2";
                csKjnHjnDataRow.Item(ABKjnHjnData.KJNHJNKBMEI) = "–@l";
                // ƒf[ƒ^‚Ì’Ç‰Á
                csKjnHjnData.Tables(ABKjnHjnData.TABLE_NAME).Rows.Add(csKjnHjnDataRow);

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, "HenKangaiKangai");
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
                "zyƒƒ\ƒbƒh–¼:HenKangaiKangaizyƒGƒ‰[“
                 */
                );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 6051


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return csKjnHjnData
                    End Function

                End Class

                 */
            }

            return default;
        }
    }
}