// ************************************************************************************************
// * ‹Æ–±–¼           ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼         ‚…‚k‚s‚`‚wÅ–Ú‹æ•ªƒ}ƒXƒ^(ABLTTaxKBBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t             2008/11/25
// *
// * ì¬ŽÒ           ”ä‰Ã@Œv¬
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2009/07/16   000001     Å–Ú‹æ•ªƒ}ƒXƒ^‹Æ–±ƒR[ƒhŽw’èŽæ“¾ƒƒ\ƒbƒh‚ð’Ç‰Ái”ä‰Ãj
// * 2010/04/16   000002     VS2008‘Î‰ži”ä‰Ãj
// ************************************************************************************************
using System;
using System.Linq;

namespace Densan.Reams.AB.AB000BB
{

    public class ABLTTaxKBBClass
    {

        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private UFErrorClass m_cfErrorClass;                  // ƒGƒ‰[ˆ—ƒNƒ‰ƒX

        private DataSet m_csDataSchma;   // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABLTTaxKBBClass";

        #endregion

        #region ƒRƒ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶            Public Sub New(ByVal cfControlData As UFControlData, 
        // *                                ByVal cfConfigDataClass As UFConfigDataClass, 
        // *                                ByVal cfRdbClass As UFRdbClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”            cfControlData As UFControlData         : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                 cfConfigData As UFConfigDataClass      : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg 
        // *                 cfRdbClass As UFRdbClass               : ‚q‚c‚aƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABLTTaxKBBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigDataClass;
            m_cfRdbClass = cfRdbClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(m_cfConfigDataClass, m_cfControlData.m_strBusinessId);

            // SQL•¶‚Ìì¬
            m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction("SELECT * FROM " + ABLTTaxKBEntity.TABLE_NAME, ABLTTaxKBEntity.TABLE_NAME, false);

        }
        #endregion

        #region ƒƒ\ƒbƒh
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Å–Ú‹æ•ªƒ}ƒXƒ^Žæ“¾
        // * 
        // * \•¶           Public Overloads Function GetLTTaxKB() As DataSet
        // * 
        // * ‹@”\@@    @ Å–Ú‹æ•ªƒ}ƒXƒ^‚æ‚è‘SŒƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½Å–Ú‹æ•ªƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // ************************************************************************************************
        public DataSet GetLTTaxKB()
        {
            const string THIS_METHOD_NAME = "GetLTTaxKB";
            DataSet csLTTaxKBEntity;                                      // Å–Ú‹æ•ªƒ}ƒXƒ^ƒf[ƒ^
            var strSQL = new System.Text.StringBuilder();                         // SQL•¶•¶Žš—ñ
                                                                                  // * corresponds to VS2008 Start 2010/04/16 000002
                                                                                  // Dim cfUFParameterClass As UFParameterClass                          ' ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                                  // * corresponds to VS2008 End 2010/04/16 000002
            UFParameterCollectionClass cfUFParameterCollectionClass;      // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABLTTaxKBEntity.TABLE_NAME);
                // ORDER•¶Œ‹‡
                strSQL.Append(" ORDER BY ");
                strSQL.Append(ABLTTaxKBEntity.TAXKB);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + default



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
       "ySQL“
        */
        );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 5195


                                Input:
                                " + strSQL.ToString + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csLTTaxKBEntity = m_csDataSchma.Clone();
                csLTTaxKBEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csLTTaxKBEntity, ABLTTaxKBEntity.TABLE_NAME, cfUFParameterCollectionClass, false);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 6069


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 6172


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw;
            }

            catch (Exception exException) // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
            {
                // ƒGƒ‰[ƒƒOo—Í
                m_cfLogClass.ErrorWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 6702


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return csLTTaxKBEntity

                    End Function

                    '*—š—ð”Ô† 000001 2009/07/16 ’Ç‰ÁŠJŽn

                 */
            }

            return default;
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Å–Ú‹æ•ªƒ}ƒXƒ^Žæ“¾
        // * 
        // * \•¶           Public Overloads Function GetLTTaxKB(ByVal strGyomuCD() As String) As DataSet
        // * 
        // * ‹@”\@@    @ Å–Ú‹æ•ªƒ}ƒXƒ^‚æ‚è‘SŒƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”           strGyomuCD() As String        :‹Æ–±ƒR[ƒh”z—ñ
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½Å–Ú‹æ•ªƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // ************************************************************************************************
        public DataSet GetLTTaxKB(string[] strGyomuCD)
        {
            const string THIS_METHOD_NAME = "GetLTTaxKB";
            DataSet csLTTaxKBEntity;                                      // Å–Ú‹æ•ªƒ}ƒXƒ^ƒf[ƒ^
            var strSQL = new System.Text.StringBuilder();                         // SQL•¶•¶Žš—ñ
                                                                                  // * corresponds to VS2008 Start 2010/04/16 000002
                                                                                  // Dim cfUFParameterClass As UFParameterClass                          ' ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                                  // * corresponds to VS2008 End 2010/04/16 000002
            UFParameterCollectionClass cfUFParameterCollectionClass;      // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
            int intI;
            var strWhere = new System.Text.StringBuilder();

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABLTTaxKBEntity.TABLE_NAME);

                // WHERE‹å
                if (strGyomuCD.Length > 0)
                {
                    strSQL.Append(" WHERE ");
                    strSQL.Append(ABLTTaxKBEntity.GYOMUCD);
                    strSQL.Append(" IN(");

                    var loopTo = strGyomuCD.Length - 1;
                    for (intI = 0; intI <= loopTo; intI++)
                    {
                        strSQL.Append("'");
                        strSQL.Append(strGyomuCD[intI]);
                        strSQL.Append("',");
                    }
                    strSQL.RRemove(strSQL.RLength - 1, 1);
                    strSQL.Append(")");
                }

                else
                {
                }

                // ORDER•¶Œ‹‡
                strSQL.Append(" ORDER BY ");
                strSQL.Append(ABLTTaxKBEntity.TAXKB);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + default



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
                         "ySQL“
                          */
                 );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9763


                                Input:
                                " + strSQL.ToString + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csLTTaxKBEntity = m_csDataSchma.Clone();
                csLTTaxKBEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csLTTaxKBEntity, ABLTTaxKBEntity.TABLE_NAME, cfUFParameterCollectionClass, false);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10637


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10740


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw;
            }

            catch (Exception exException) // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
            {
                // ƒGƒ‰[ƒƒOo—Í
                m_cfLogClass.ErrorWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11270


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return csLTTaxKBEntity

                    End Function
                    '*—š—ð”Ô† 000001 2009/07/16 ’Ç‰ÁI—¹

                 */
            }

            return default;
        }
        #endregion

    }
}