// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‡•¹“¯ˆêl‚c‚`(ABGappeiDoitsuninBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/01/15@ŽRè@•q¶
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/03/17 000001     ’Ç‰ÁŽžA‹¤’Ê€–Ú‚ðÝ’è‚·‚é
// * 2003/04/25 000002     ‡•¹“¯ˆêlƒOƒ‹[ƒv’Šoƒƒ\ƒbƒh‚ð’Ç‰Á
// * 2003/05/13 000003     ‚c‚a‚æ‚èƒXƒL[ƒ}‚ðŽæ“¾‚µ‚ÄSQL‚ðì¬
// * 2003/05/21 000004     ƒGƒ‰[A“ú•tƒNƒ‰ƒX‚Ì²Ý½ÀÝ½‚ðºÝ½Ä×¸À‚É•ÏX
// * 2003/08/21 000005     ‡•¹“¯ˆêl’Šo(GetDoitsunin)ƒƒ\ƒbƒh‚ð’Ç‰Á
// * 2007/07/27 000006     “¯ˆêl‘ã•\ŽÒŽæ“¾‹@”\‚Ì’Ç‰Á (‹gàV)
// * 2010/04/16 000007     VS2008‘Î‰ži”ä‰Ãj
// * 2016/01/07 000008     yAB00163zŒÂl§Œä‚Ì“¯ˆêl‘Î‰žiÎ‡j
// * 2018/05/01 000009     yAB27001zŠY“–ŽÒˆê——‚Ö‚Ì“¯ˆêl‹æ•ª•\Ž¦iÎ‡j
// ************************************************************************************************
using System;
using System.Collections;
// *—š—ð”Ô† 000009 2018/05/01 ’Ç‰ÁŠJŽn
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Densan.Reams.AB.AB000BB
{
    // *—š—ð”Ô† 000009 2018/05/01 ’Ç‰ÁI—¹

    public class ABGappeiDoitsuninBClass
    {
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private UFErrorClass m_cfErrorClass;                  // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private string m_strInsertSQL;                        // INSERT—pSQL
        private string m_strUpdateSQL;                        // UPDATE—pSQL
        private string m_strDeleteSQL;                        // DELETE—pSQL
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;      // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateUFParameterCollectionClass;      // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDeleteUFParameterCollectionClass;      // DELETE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABGappeiDoitsuninBClass";

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶            Public Sub New(ByVal cfControlData As UFControlData,
        // * @@                           ByVal cfConfigDataClass As UFConfigDataClass,
        // * @@                           ByVal cfRdbClass As UFRdbClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”            cfControlData As UFControlData         : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@            cfConfigDataClass As UFConfigDataClass : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg 
        // * @@            cfRdbClass As UFRdbClass               : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABGappeiDoitsuninBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigDataClass;
            m_cfRdbClass = cfRdbClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(m_cfConfigDataClass, m_cfControlData.m_strBusinessId);

            // ƒƒ“ƒo•Ï”‚Ì‰Šú‰»
            m_strInsertSQL = string.Empty;
            m_strUpdateSQL = string.Empty;
            m_strDeleteSQL = string.Empty;
            m_cfInsertUFParameterCollectionClass = (object)null;
            m_cfUpdateUFParameterCollectionClass = (object)null;
            m_cfDeleteUFParameterCollectionClass = (object)null;
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‡•¹“¯ˆêl‘Sˆõ’Šo
        // * 
        // * \•¶           Public Function GetDoitsuninAll(ByVal strJuminCD As String) As DataSet
        // * 
        // * ‹@”\@@    @@‡•¹“¯ˆêl‚æ‚èŠY“–ƒf[ƒ^‚ð‘SŒŽæ“¾‚·‚éB
        // * 
        // * ˆø”           strJuminCD As String      :Z–¯ƒR[ƒh
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½‡•¹“¯ˆêl‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsGappeiDoitsuninEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABGappeiDoitsuninEntity
        // ************************************************************************************************
        public DataSet GetDoitsuninAll(string strJuminCD)
        {
            const string THIS_METHOD_NAME = "GetDoitsuninAll";            // ‚±‚Ìƒƒ\ƒbƒh–¼
            DataSet csGappeiDoitsuninEntity;                          // ‡•¹“¯ˆêlƒf[ƒ^
            var strSQL = new StringBuilder();                               // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
            UFErrorStruct objErrorStruct;                             // ƒGƒ‰[’è‹`\‘¢‘Ì

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                // WHERE•¶Œ‹‡
                strSQL.Append(" WHERE ");
                strSQL.Append(ABGappeiDoitsuninEntity.JUMINCD);
                strSQL.Append(" = ");
                strSQL.Append(ABGappeiDoitsuninEntity.KEY_JUMINCD);
                strSQL.Append(" AND ");
                strSQL.Append(ABGappeiDoitsuninEntity.SAKUJOFG);
                strSQL.Append(" <> 1");

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                // Z–¯ƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABGappeiDoitsuninEntity.KEY_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 7158


                                Input:
                                " + strSQL.ToString + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csGappeiDoitsuninEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), ABGappeiDoitsuninEntity.TABLE_NAME, cfUFParameterCollectionClass);

                // Žæ“¾Œ”‚ª‚OŒ‚ÌŽž
                if (csGappeiDoitsuninEntity.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows.Count() == 0)
                {
                    m_cfErrorClass = new UFErrorClass(ABConstClass.THIS_BUSINESSID);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_DATA_NOTFOUND);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                }

                // Žæ“¾Œ”‚ª‚PŒ‚ÌŽž
                if (csGappeiDoitsuninEntity.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows.Count() == 1)
                {
                    // SQL•¶‚Ìì¬
                    strSQL = new StringBuilder();
                    strSQL.Append("SELECT * FROM ");
                    strSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                    // WHERE•¶Œ‹‡
                    strSQL.Append(" WHERE ");
                    strSQL.Append(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD);
                    strSQL.Append(" = ");
                    strSQL.Append(ABGappeiDoitsuninEntity.KEY_DOITSUNINSHIKIBETSUCD);
                    strSQL.Append(" AND ");
                    strSQL.Append(ABGappeiDoitsuninEntity.SAKUJOFG);
                    strSQL.Append(" <> 1");

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                    cfUFParameterCollectionClass = new UFParameterCollectionClass();
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    // “¯ˆêlŽ¯•ÊƒR[ƒh
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABGappeiDoitsuninEntity.KEY_DOITSUNINSHIKIBETSUCD;
                    cfUFParameterClass.Value = (string)csGappeiDoitsuninEntity.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows(0).Item(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD).ToString;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9854


                                        Input:
                                        " + strSQL.ToString + "z")

                                                        ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                         */
                    csGappeiDoitsuninEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), ABGappeiDoitsuninEntity.TABLE_NAME, cfUFParameterCollectionClass);
                }

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10708


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10811


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11364


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csGappeiDoitsuninEntity

                    End Function

                    '* —š—ð”Ô† 000005 2003/08/21 ’Ç‰ÁŠJŽn

                 */
            }

            return default;
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‡•¹“¯ˆêl’Šo
        // * 
        // * \•¶           Public Function GetDoitsunin(ByVal strJuminCD As String) As DataSet
        // * 
        // * ‹@”\@@    @@‡•¹“¯ˆêl‚æ‚èŠY“–ƒf[ƒ^‚ð‘SŒŽæ“¾‚·‚éB
        // * 
        // * ˆø”           strJuminCD As String      :Z–¯ƒR[ƒh
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½‡•¹“¯ˆêl‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsGappeiDoitsuninEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABGappeiDoitsuninEntity
        // ************************************************************************************************
        public DataSet GetDoitsunin(string strJuminCD)
        {
            const string THIS_METHOD_NAME = "GetDoitsunin";               // ‚±‚Ìƒƒ\ƒbƒh–¼
            DataSet csGappeiDoitsuninEntity;                          // ‡•¹“¯ˆêlƒf[ƒ^
            var strSQL = new StringBuilder();                               // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
                                                                      // * corresponds to VS2008 Start 2010/04/16 000007
                                                                      // Dim objErrorStruct As UFErrorStruct                             'ƒGƒ‰[’è‹`\‘¢‘Ì
                                                                      // * corresponds to VS2008 End 2010/04/16 000007

            do
            {
                try
                {
                    // ƒfƒoƒbƒOƒƒOo—Í
                    m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                    // SQL•¶‚Ìì¬
                    strSQL.Append("SELECT * FROM ");
                    strSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                    // WHERE•¶Œ‹‡
                    strSQL.Append(" WHERE ");
                    strSQL.Append(ABGappeiDoitsuninEntity.JUMINCD);
                    strSQL.Append(" = ");
                    strSQL.Append(ABGappeiDoitsuninEntity.KEY_JUMINCD);
                    strSQL.Append(" AND ");
                    strSQL.Append(ABGappeiDoitsuninEntity.SAKUJOFG);
                    strSQL.Append(" <> 1");

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                    cfUFParameterCollectionClass = new UFParameterCollectionClass();
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    // Z–¯ƒR[ƒh
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABGappeiDoitsuninEntity.KEY_JUMINCD;
                    cfUFParameterClass.Value = strJuminCD;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 14659


                                        Input:
                                        " + strSQL.ToString + "z")

                                                    ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                         */
                    csGappeiDoitsuninEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), ABGappeiDoitsuninEntity.TABLE_NAME, cfUFParameterCollectionClass);

                    // Žæ“¾Œ”‚ª‚OŒ‚ÌŽž
                    if (csGappeiDoitsuninEntity.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows.Count() == 0)
                    {
                        break;
                    }

                    // Žæ“¾Œ”‚ª‚PŒ‚ÌŽž
                    if (csGappeiDoitsuninEntity.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows.Count() == 1)
                    {
                        // SQL•¶‚Ìì¬
                        strSQL = new StringBuilder();
                        strSQL.Append("SELECT * FROM ");
                        strSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                        // WHERE•¶Œ‹‡
                        strSQL.Append(" WHERE ");
                        strSQL.Append(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD);
                        strSQL.Append(" = ");
                        strSQL.Append(ABGappeiDoitsuninEntity.KEY_DOITSUNINSHIKIBETSUCD);
                        strSQL.Append(" AND ");
                        strSQL.Append(ABGappeiDoitsuninEntity.SAKUJOFG);
                        strSQL.Append(" <> 1");

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                        cfUFParameterCollectionClass = new UFParameterCollectionClass();
                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                        // “¯ˆêlŽ¯•ÊƒR[ƒh
                        cfUFParameterClass = new UFParameterClass();
                        cfUFParameterClass.ParameterName = ABGappeiDoitsuninEntity.KEY_DOITSUNINSHIKIBETSUCD;
                        cfUFParameterClass.Value = (string)csGappeiDoitsuninEntity.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows(0).Item(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD).ToString;
                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfUFParameterCollectionClass.Add(cfUFParameterClass);

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
                        /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17014


                                                Input:
                                                " + strSQL.ToString + "z")

                                                                ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                                 */
                        csGappeiDoitsuninEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), ABGappeiDoitsuninEntity.TABLE_NAME, cfUFParameterCollectionClass);
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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17684


                    Input:
                    " + exAppException.p_strErrorCode + "z" + _
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17787


                                        Input:
                                        " + exAppException.Message + "z")
                                                    ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                         */
                    throw exAppException;
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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 18340


                    Input:
                    " + exException.Message + "z")
                                ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                                Throw exException
                            Finally
                                ' ƒfƒoƒbƒOƒƒOo—Í
                                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)
                            End Try

                            Return csGappeiDoitsuninEntity

                        End Function
                        '* —š—ð”Ô† 000005 2003/08/21 ’Ç‰ÁI—¹

                     */
                }
            }
            while (false);
            return default;
        }

        // *—š—ð”Ô† 000008 2016/01/07 ’Ç‰ÁŠJŽn
        /// <summary>
    /// “¯ˆêlƒf[ƒ^Žæ“¾
    /// </summary>
    /// <param name="a_strJuminCD">Z–¯ƒR[ƒh•¶Žš—ñ”z—ñ</param>
    /// <returns>“¯ˆêlƒf[ƒ^</returns>
    /// <remarks></remarks>
        public DataSet GetDoitsunin(string[] a_strJuminCD)
        {

            string THIS_METHOD_NAME = System.Reflection.MethodBase.GetCurrentMethod().Name;
            DataSet csDataSet;
            StringBuilder csSQL;
            UFParameterClass cfParameter;
            UFParameterCollectionClass cfParameterCollection;
            string strParameterName;

            try
            {

                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                csSQL = new StringBuilder();
                cfParameterCollection = new UFParameterCollectionClass();

                {
                    ref var withBlock = ref csSQL;

                    withBlock.Append("SELECT * FROM ");
                    withBlock.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                    withBlock.Append(" WHERE ");
                    withBlock.Append(ABGappeiDoitsuninEntity.JUMINCD);
                    withBlock.Append(" IN (");

                    for (int i = 0, loopTo = a_strJuminCD.Length - 1; i <= loopTo; i++)
                    {

                        // -----------------------------------------------------------------------------
                        // Z–¯ƒR[ƒh
                        strParameterName = ABGappeiDoitsuninEntity.KEY_JUMINCD + i.ToString();

                        if (i > 0)
                        {
                            withBlock.AppendFormat(", {0}", strParameterName);
                        }
                        else
                        {
                            withBlock.Append(strParameterName);
                        }

                        cfParameter = new UFParameterClass();
                        cfParameter.ParameterName = strParameterName;
                        cfParameter.Value = a_strJuminCD[i];
                        cfParameterCollection.Add(cfParameter);
                        // -----------------------------------------------------------------------------

                    }

                    withBlock.Append(")");
                    withBlock.Append(" AND ");
                    withBlock.Append(ABGappeiDoitsuninEntity.SAKUJOFG);
                    withBlock.Append(" <> '1'");

                }

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21425


                                Input:
                                " + csSQL.ToString + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csDataSet = m_cfRdbClass.GetDataSet(csSQL.ToString(), ABGappeiDoitsuninEntity.TABLE_NAME, cfParameterCollection);

                // Žæ“¾Œ”‚ª‚PŒˆÈã‚ÌŽž
                if (csDataSet.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows.Count > 0)
                {

                    // SQL•¶‚Ìì¬
                    csSQL = new StringBuilder();
                    cfParameterCollection = new UFParameterCollectionClass();


                    csSQL.Append("SELECT * FROM ");
                    csSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                    csSQL.Append(" WHERE ");
                    csSQL.Append(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD);
                    csSQL.Append(" IN (");

                    for (int i = 0, loopTo1 = csDataSet.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows.Count - 1; i <= loopTo1; i++)
                    {

                        // -----------------------------------------------------------------------------
                        // “¯ˆêlŽ¯•ÊƒR[ƒh
                        strParameterName = ABGappeiDoitsuninEntity.KEY_DOITSUNINSHIKIBETSUCD + i.ToString();

                        if (i > 0)
                        {
                            csSQL.AppendFormat(", {0}", strParameterName);
                        }
                        else
                        {
                            csSQL.Append(strParameterName);
                        }

                        cfParameter = new UFParameterClass();
                        cfParameter.ParameterName = strParameterName;
                        cfParameter.Value = csDataSet.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows(i).Item(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD).ToString;
                        cfParameterCollection.Add(cfParameter);
                        // -----------------------------------------------------------------------------

                    }

                    csSQL.Append(")");
                    csSQL.Append(" AND ");
                    csSQL.Append(ABGappeiDoitsuninEntity.SAKUJOFG);
                    csSQL.Append(" <> '1'");
                    csSQL.Append(" ORDER BY ");
                    csSQL.Append(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD);
                    csSQL.Append(", ");
                    csSQL.Append(ABGappeiDoitsuninEntity.HONNINKB);
                    csSQL.Append(", ");

                    csSQL.Append(ABGappeiDoitsuninEntity.JUMINCD);

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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 24268


                                        Input:
                                        " + csSQL.ToString + "z")

                                                        ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                         */
                    csDataSet = m_cfRdbClass.GetDataSet(csSQL.ToString(), ABGappeiDoitsuninEntity.TABLE_NAME, cfParameterCollection);
                }

                else
                {
                    // noop
                }

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException csAppExp)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 25139


                Input:
                " + csAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 25236


                                Input:
                                " + csAppExp.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw;
            }

            catch (Exception csExp)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 25737


                Input:
                " + csExp.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return csDataSet

                    End Function
                    '*—š—ð”Ô† 000008 2016/01/07 ’Ç‰ÁI—¹

                 */
            }

            return default;
        }

        // *—š—ð”Ô† 000009 2018/05/01 ’Ç‰ÁŠJŽn
        /// <summary>
    /// “¯ˆêl‹æ•ª–¼ÌŽæ“¾
    /// </summary>
    /// <param name="csJuminCDList">Z–¯ƒR[ƒhƒŠƒXƒg</param>
    /// <returns>“¯ˆêl‹æ•ª–¼Ì</returns>
    /// <remarks></remarks>
        public Hashtable GetDoitsuninMeisho(List<string> csJuminCDList)
        {

            string THIS_METHOD_NAME = System.Reflection.MethodBase.GetCurrentMethod().Name;
            Hashtable csResult;
            DataSet csDataSet;
            StringBuilder csSQL;
            UFParameterClass cfParameter;
            UFParameterCollectionClass cfParameterCollection;
            string strParameterName;

            try
            {

                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // •ÔMƒIƒuƒWƒFƒNƒg‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                csResult = new Hashtable();

                // SQL•¶‚Ìì¬
                csSQL = new StringBuilder();
                cfParameterCollection = new UFParameterCollectionClass();


                csSQL.Append("SELECT * FROM ");
                csSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                csSQL.Append(" WHERE ");
                csSQL.Append(ABGappeiDoitsuninEntity.JUMINCD);
                csSQL.Append(" IN (");

                for (int i = 0, loopTo = csJuminCDList.Count - 1; i <= loopTo; i++)
                {

                    // -----------------------------------------------------------------------------
                    // Z–¯ƒR[ƒh
                    strParameterName = ABGappeiDoitsuninEntity.KEY_JUMINCD + i.ToString();

                    if (i > 0)
                    {
                        csSQL.AppendFormat(", {0}", strParameterName);
                    }
                    else
                    {
                        csSQL.Append(strParameterName);
                    }

                    cfParameter = new UFParameterClass();
                    cfParameter.ParameterName = strParameterName;
                    cfParameter.Value = csJuminCDList[i];
                    cfParameterCollection.Add(cfParameter);
                    // -----------------------------------------------------------------------------

                }

                csSQL.Append(")");
                csSQL.Append(" AND ");
                csSQL.Append(ABGappeiDoitsuninEntity.SAKUJOFG);

                csSQL.Append(" <> '1'");

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 28901


                                Input:
                                " + csSQL.ToString + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csDataSet = m_cfRdbClass.GetDataSet(csSQL.ToString(), ABGappeiDoitsuninEntity.TABLE_NAME, cfParameterCollection);

                // Žæ“¾Œ”‚ª‚PŒˆÈã‚ÌŽž
                if (csDataSet.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows.Count > 0)
                {

                    foreach (DataRow csDataRow in csDataSet.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows)
                    {

                        // -----------------------------------------------------------------------------
                        // “¯ˆêl‹æ•ª–¼Ì•ÒW
                        switch (csDataRow.Item(ABGappeiDoitsuninEntity.HONNINKB).ToString.Trim)
                        {
                            case var @case when @case == ABConstClass.HONNINKB.CODE.DAIHYO:
                                {
                                    csResult.Add(csDataRow.Item(ABGappeiDoitsuninEntity.JUMINCD).ToString, ABConstClass.HONNINKB.RYAKUSHO.DAIHYO);
                                    break;
                                }
                            case var case1 when case1 == ABConstClass.HONNINKB.CODE.DOITSUNIN:
                                {
                                    csResult.Add(csDataRow.Item(ABGappeiDoitsuninEntity.JUMINCD).ToString, ABConstClass.HONNINKB.RYAKUSHO.DOITSUNIN);
                                    break;
                                }
                            case var case2 when case2 == ABConstClass.HONNINKB.CODE.HAISHI:
                                {
                                    csResult.Add(csDataRow.Item(ABGappeiDoitsuninEntity.JUMINCD).ToString, ABConstClass.HONNINKB.RYAKUSHO.HAISHI);
                                    break;
                                }

                            default:
                                {
                                    csResult.Add(csDataRow.Item(ABGappeiDoitsuninEntity.JUMINCD).ToString, string.Empty);
                                    break;
                                }
                        }
                        // -----------------------------------------------------------------------------

                    }
                }

                else
                {
                    // noop
                }

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException csAppExp)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31156


                Input:
                " + csAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31253


                                Input:
                                " + csAppExp.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw;
            }

            catch (Exception csExp)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31754


                Input:
                " + csExp.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return csResult

                    End Function
                    '*—š—ð”Ô† 000009 2018/05/01 ’Ç‰ÁI—¹

                 */
            }

            return default;
        }

        // *—š—ð”Ô† 000006 2007/07/27 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‡•¹“¯ˆêl‘ã•\Z–¯ƒR[ƒhŽæ“¾
        // * 
        // * \•¶           Public Function GetDoitsuninDaihyoJuminCD(ByVal strJuminCD As String) As String
        // * 
        // * ‹@”\@@    @ ‡•¹“¯ˆêl‘ã•\‚ÌZ–¯ƒR[ƒh‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD As String      :Z–¯ƒR[ƒh
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½‡•¹“¯ˆêl‚ÌŠY“–ƒf[ƒ^iStringj
        // ************************************************************************************************
        public string GetDoitsuninDaihyoJuminCD(string strJuminCD)
        {
            const string THIS_METHOD_NAME = "GetDoitsuninDaihyoJuminCD";         // ‚±‚Ìƒƒ\ƒbƒh–¼
            string strDaihyoJuminCD;                      // Z–¯ƒR[ƒhi‘ã•\ŽÒj
            DataSet csDaihyosyaEntity;              // “¯ˆêl‘ã•\ŽÒƒf[ƒ^
            var strSQL = new StringBuilder();                                 // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX


            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ‘ã•\ŽÒî•ñ‚ÌŽæ“¾‚ðs‚¤
                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT A.");
                strSQL.Append(ABGappeiDoitsuninEntity.JUMINCD);
                strSQL.Append(" FROM ");
                strSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                strSQL.Append(" A ");
                // JOIN•¶Œ‹‡
                strSQL.Append("JOIN (SELECT ");
                strSQL.Append(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD);
                strSQL.Append(" FROM ");
                strSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                strSQL.Append(" WHERE ");
                strSQL.Append(ABGappeiDoitsuninEntity.JUMINCD);
                strSQL.Append(" = ");
                strSQL.Append(ABGappeiDoitsuninEntity.KEY_JUMINCD);
                strSQL.Append(" AND ");
                strSQL.Append(ABGappeiDoitsuninEntity.HONNINKB);
                strSQL.Append(" IN ('0','1')");
                strSQL.Append(" AND ");
                strSQL.Append(ABGappeiDoitsuninEntity.SAKUJOFG);
                strSQL.Append(" <> 1) B ON A.");
                strSQL.Append(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD);
                strSQL.Append(" = B.");
                strSQL.Append(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD);
                // WHERE•¶Œ‹‡
                strSQL.Append(" WHERE A.");
                strSQL.Append(ABGappeiDoitsuninEntity.HONNINKB);
                strSQL.Append(" = '0'");


                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                // Z–¯ƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABGappeiDoitsuninEntity.KEY_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 35720


                                Input:
                                " + strSQL.ToString + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csDaihyosyaEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), ABGappeiDoitsuninEntity.TABLE_NAME, cfUFParameterCollectionClass);

                // Žæ“¾Œ”‚ª‚OŒ‚ÌŽž
                if (csDaihyosyaEntity.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows.Count() == 0)
                {
                    // “¯ˆêlŠÇ—‚³‚ê‚Ä‚¢‚È‚¢ê‡‚ÍAŽw’è‚³‚ê‚½Z–¯ƒR[ƒh‚ð•Ô‹p‚·‚é
                    strDaihyoJuminCD = strJuminCD;
                }
                else
                {
                    // “¯ˆêlŠÇ—‚³‚ê‚Ä‚¢‚éê‡‚ÍA“¯ˆêl‘ã•\ŽÒ‚ÌZ–¯ƒR[ƒh‚ð•Ô‹p‚·‚é
                    strDaihyoJuminCD = (string)csDaihyosyaEntity.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows(0).Item(ABGappeiDoitsuninEntity.JUMINCD);
                }

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37063


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37166


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37719


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return strDaihyoJuminCD

                    End Function
                    '*—š—ð”Ô† 000006 2007/07/27 ’Ç‰ÁI—¹

                 */
            }

            return default;
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‡•¹“¯ˆêl–{l’Šo
        // * 
        // * \•¶           Public Function GetDoitsuninHonnin(ByVal strJuminCD As String) As DataSet
        // * 
        // * ‹@”\@@    @@‡•¹“¯ˆêl‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”           strJuminCD As String      :Z–¯ƒR[ƒh
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½‡•¹“¯ˆêl‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsGappeiDoitsuninEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABGappeiDoitsuninEntity
        // ************************************************************************************************
        public DataSet GetDoitsuninHonnin(string strJuminCD)
        {
            const string THIS_METHOD_NAME = "GetDoitsuninHonnin";         // ‚±‚Ìƒƒ\ƒbƒh–¼
            UFErrorStruct objErrorStruct;                             // ƒGƒ‰[’è‹`\‘¢‘Ì
            DataSet csGappeiDoitsuninEntity;                          // ‡•¹“¯ˆêlƒf[ƒ^
            var strSQL = new StringBuilder();                                 // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                // WHERE•¶Œ‹‡
                strSQL.Append(" WHERE ");
                strSQL.Append(ABGappeiDoitsuninEntity.JUMINCD);
                strSQL.Append(" = ");
                strSQL.Append(ABGappeiDoitsuninEntity.KEY_JUMINCD);
                strSQL.Append(" AND ");
                strSQL.Append(ABGappeiDoitsuninEntity.SAKUJOFG);
                strSQL.Append(" <> 1");

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                // Z–¯ƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABGappeiDoitsuninEntity.KEY_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40901


                                Input:
                                " + strSQL.ToString + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csGappeiDoitsuninEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), ABGappeiDoitsuninEntity.TABLE_NAME, cfUFParameterCollectionClass);

                // Žæ“¾Œ”‚ª‚OŒ‚ÌŽž
                if (csGappeiDoitsuninEntity.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows.Count() == 0)
                {
                    m_cfErrorClass = new UFErrorClass(ABConstClass.THIS_BUSINESSID);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_DATA_NOTFOUND);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                }

                // Žæ“¾Œ”‚ª‚PŒ‚ÌŽž
                if (csGappeiDoitsuninEntity.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows.Count() == 1)
                {
                    // SQL•¶‚Ìì¬
                    strSQL = new StringBuilder();
                    strSQL.Append("SELECT * FROM ");
                    strSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                    // WHERE•¶Œ‹‡
                    strSQL.Append(" WHERE ");
                    strSQL.Append(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD);
                    strSQL.Append(" = ");
                    strSQL.Append(ABGappeiDoitsuninEntity.KEY_DOITSUNINSHIKIBETSUCD);
                    strSQL.Append(" AND ");
                    strSQL.Append(ABGappeiDoitsuninEntity.HONNINKB);
                    strSQL.Append(" = '0'");
                    strSQL.Append(" AND ");
                    strSQL.Append(ABGappeiDoitsuninEntity.SAKUJOFG);
                    strSQL.Append(" <> '1'");

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                    cfUFParameterCollectionClass = new UFParameterCollectionClass();
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    // “¯ˆêlŽ¯•ÊƒR[ƒh
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABGappeiDoitsuninEntity.KEY_DOITSUNINSHIKIBETSUCD;
                    cfUFParameterClass.Value = (string)csGappeiDoitsuninEntity.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows(0).Item(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD).ToString;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 43736


                                        Input:
                                        " + strSQL.ToString + "z")

                                                        ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                         */
                    csGappeiDoitsuninEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), ABGappeiDoitsuninEntity.TABLE_NAME, cfUFParameterCollectionClass);
                }

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 44590


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 44693


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 45246


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csGappeiDoitsuninEntity

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‡•¹“¯ˆêlƒOƒ‹[ƒv’Šo

                 */
            }

            return default;
        }
        // * 
        // * \•¶           Public Function GetDoitsuninGroup(ByVal strJuminCD As String) As DataSet
        // * 
        // * ‹@”\@@    @@‡•¹“¯ˆêl‚æ‚èŠY“–ƒf[ƒ^‚ð‘SŒŽæ“¾‚·‚éB
        // * 
        // * ˆø”           strJuminCD As String      :Z–¯ƒR[ƒh
        // * 
        // * –ß‚è’l         Ž¯•ÊƒR[ƒh(String)         
        // ************************************************************************************************
        public string GetDoitsuninGroup(string strJuminCD)
        {
            const string THIS_METHOD_NAME = "GetDoitsuninGroup";          // ‚±‚Ìƒƒ\ƒbƒh–¼
            UFErrorStruct objErrorStruct;                             // ƒGƒ‰[’è‹`\‘¢‘Ì
            DataSet csGappeiDoitsuninEntity;                          // ‡•¹“¯ˆêlƒf[ƒ^
            var strSQL = new StringBuilder();                                 // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
            string strShikibetsuCD;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                // WHERE•¶Œ‹‡
                strSQL.Append(" WHERE ");
                strSQL.Append(ABGappeiDoitsuninEntity.JUMINCD);
                strSQL.Append(" = ");
                strSQL.Append(ABGappeiDoitsuninEntity.KEY_JUMINCD);
                strSQL.Append(" AND ");
                strSQL.Append(ABGappeiDoitsuninEntity.SAKUJOFG);
                strSQL.Append(" <> '1'");

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                // Z–¯ƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABGappeiDoitsuninEntity.KEY_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 48326


                                Input:
                                " + strSQL.ToString + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csGappeiDoitsuninEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), ABGappeiDoitsuninEntity.TABLE_NAME, cfUFParameterCollectionClass);

                // Žæ“¾Œ”‚ª‚OŒ‚ÌŽž
                if (csGappeiDoitsuninEntity.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows.Count() == 0)
                {
                    m_cfErrorClass = new UFErrorClass(ABConstClass.THIS_BUSINESSID);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_DATA_NOTFOUND);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                }

                strShikibetsuCD = (string)csGappeiDoitsuninEntity.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Rows(0).Item(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD);


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 49852


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 49955


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 50508


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return strShikibetsuCD

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‡•¹“¯ˆêl’Ç‰Á

                 */
            }

            return default;
        }
        // * 
        // * \•¶           Public Function InsertDoitsunin(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @  ‡•¹“¯ˆêl‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚éB
        // * 
        // * ˆø”           csDataRow As DataRow  :’Ç‰Áƒf[ƒ^
        // * 
        // * –ß‚è’l         ’Ç‰ÁŒ”(Integer)
        // ************************************************************************************************
        public int InsertDoitsunin(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "InsertDoitsunin";            // ‚±‚Ìƒƒ\ƒbƒh–¼
                                                                          // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            int intInsCnt;                            // ’Ç‰ÁŒ”
            string strUpdateDateTime;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strInsertSQL is null | string.IsNullOrEmpty(m_strInsertSQL) | m_cfInsertUFParameterCollectionClass is null)
                {
                    CreateSQL(csDataRow);
                }

                // XV“úŽž‚ÌŽæ“¾
                strUpdateDateTime = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");          // ì¬“úŽž

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABGappeiDoitsuninEntity.TANMATSUID) = m_cfControlData.m_strClientId;           // ’[––‚h‚c
                csDataRow(ABGappeiDoitsuninEntity.SAKUJOFG) = "0";                                       // íœƒtƒ‰ƒO
                csDataRow(ABGappeiDoitsuninEntity.KOSHINCOUNTER) = decimal.Zero;                         // XVƒJƒEƒ“ƒ^
                csDataRow(ABGappeiDoitsuninEntity.SAKUSEINICHIJI) = strUpdateDateTime;                   // ì¬“úŽž
                csDataRow(ABGappeiDoitsuninEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;            // ì¬ƒ†[ƒU[
                csDataRow(ABGappeiDoitsuninEntity.KOSHINNICHIJI) = strUpdateDateTime;                    // XV“úŽž
                csDataRow(ABGappeiDoitsuninEntity.KOSHINUSER) = m_cfControlData.m_strUserId;             // XVƒ†[ƒU[

                // “–ƒNƒ‰ƒX‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¤
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                    // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                    CheckColumnValue(csDataColumn.ColumnName, csDataRow(csDataColumn.ColumnName).ToString.Trim);

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    this.m_cfInsertUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABGappeiDoitsuninEntity.PARAM_PLACEHOLDER.RLength)).ToString();

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + default



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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 54093


                                Input:
                                " + m_strInsertSQL + "z")

                                            ' SQL‚ÌŽÀs
                                            intInsCnt = m_cfRdbClass.ExecuteSQL(m_strInsertSQL, m_cfInsertUFParameterCollectionClass)

                                            ' ƒfƒoƒbƒOƒƒOo—Í
                                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                        Catch exAppException As UFAppException
                                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í

                                 */
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 54798


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 54901


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 55454


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return intInsCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‡•¹“¯ˆêlXV

                 */
            }

            return default;
        }
        // * 
        // * \•¶           Public Function UpdateDoitsunin(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @  ‡•¹“¯ˆêl‚Ìƒf[ƒ^‚ðXV‚·‚éB
        // * 
        // * ˆø”           csDataRow As DataRow  :XVƒf[ƒ^
        // * 
        // * –ß‚è’l         XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateDoitsunin(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "UpdateDoitsunin";            // ‚±‚Ìƒƒ\ƒbƒh–¼
                                                                          // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                          // * corresponds to VS2008 Start 2010/04/16 000007
                                                                          // Dim csDataColumn As DataColumn
                                                                          // * corresponds to VS2008 End 2010/04/16 000007
            int intUpdCnt;                                        // XVŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strUpdateSQL is null | string.IsNullOrEmpty(m_strUpdateSQL) | m_cfUpdateUFParameterCollectionClass is null)
                {
                    CreateSQL(csDataRow);
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABGappeiDoitsuninEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                   // ’[––‚h‚c
                csDataRow(ABGappeiDoitsuninEntity.KOSHINCOUNTER) = (decimal)csDataRow(ABGappeiDoitsuninEntity.KOSHINCOUNTER) + 1m;   // XVƒJƒEƒ“ƒ^
                csDataRow(ABGappeiDoitsuninEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");   // XV“úŽž
                csDataRow(ABGappeiDoitsuninEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                     // XVƒ†[ƒU[

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABGappeiDoitsuninEntity.PREFIX_KEY.RLength) == ABGappeiDoitsuninEntity.PREFIX_KEY)
                    {
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABGappeiDoitsuninEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                        CheckColumnValue(cfParam.ParameterName.RSubstring(ABGappeiDoitsuninEntity.PARAM_PLACEHOLDER.RLength), csDataRow(cfParam.ParameterName.RSubstring(ABGappeiDoitsuninEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString.Trim);
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABGappeiDoitsuninEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + default



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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 59366


                                Input:
                                " + m_strUpdateSQL + "z")

                                            ' SQL‚ÌŽÀs
                                            intUpdCnt = m_cfRdbClass.ExecuteSQL(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass)

                                            ' ƒfƒoƒbƒOƒƒOo—Í
                                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                        Catch exAppException As UFAppException
                                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í

                                 */
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 60071


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 60174


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 60727


                Input:
                " + exException.Message + "z")

                            'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return intUpdCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‡•¹“¯ˆêlíœi•¨—j
                    '* 
                    '* \•¶           Public Function DeleteDoitsunin(ByVal csDataRow As DataRow) As Integer
                    '* 
                    '* ‹@”\@@    @  ‡•¹“¯ˆêl‚Ìƒf[ƒ^‚ðíœi•¨—j‚·‚éB
                    '* 
                    '* ˆø”           csDataRow As DataRow      :íœƒf[ƒ^
                    '* 
                    '* –ß‚è’l         íœi•¨—jŒ”(Integer)
                    '************************************************************************************************
                    Public Function DeleteDoitsunin(ByVal csDataRow As DataRow) As Integer
                        Const THIS_METHOD_NAME As String = "DeleteDoitsunini•¨—j"
                        '* corresponds to VS2008 Start 2010/04/16 000007
                        'Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì
                        '* corresponds to VS2008 End 2010/04/16 000007
                        Dim cfParam As UFParameterClass                     'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        '* corresponds to VS2008 Start 2010/04/16 000007
                        'Dim csDataColumn As DataColumn
                        '* corresponds to VS2008 End 2010/04/16 000007
                        Dim intDelCnt As Integer                            'íœŒ”

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                            If (m_strDeleteSQL Is Nothing Or m_strDeleteSQL = String.Empty Or _
                                m_cfDeleteUFParameterCollectionClass Is Nothing) Then
                                Call CreateSQL(csDataRow)
                            End If

                            ' ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                            For Each cfParam In m_cfDeleteUFParameterCollectionClass
                                ' ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                                If (cfParam.ParameterName.RSubstring(0, ABGappeiDoitsuninEntity.PREFIX_KEY.RLength) = ABGappeiDoitsuninEntity.PREFIX_KEY) Then
                                    m_cfDeleteUFParameterCollectionClass(cfParam.ParameterName).Value =
                                            csDataRow(cfParam.ParameterName.RSubstring(ABGappeiDoitsuninEntity.PREFIX_KEY.RLength),
                                                      DataRowVersion.Original).ToString()
                                Else
                                    ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                                    m_cfDeleteUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABGappeiDoitsuninEntity.PREFIX_KEY.RLength), DataRowVersion.Current).ToString()
                                End If
                            Next cfParam

                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                                                        "ySQL“à—e:" + m_strDeleteSQL + "z")

                            ' SQL‚ÌŽÀs
                            intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDeleteSQL, m_cfDeleteUFParameterCollectionClass)

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException

                        Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return intDelCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     SQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\@@    @@INSERT, UPDATE, DELETE‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateSQL(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateSQL"
                        Dim csDataColumn As DataColumn
                        Dim cfUFParameterClass As UFParameterClass          'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim strInsertColumn As String                       '’Ç‰ÁSQL•¶€–Ú•¶Žš—ñ
                        Dim strInsertParam As String                        '’Ç‰ÁSQL•¶ƒpƒ‰ƒ[ƒ^•¶Žš—ñ
                        Dim strDeleteSQL As New StringBuilder               'íœSQL•¶•¶Žš—ñ
                        Dim strWhere As New StringBuilder                   'XVíœSQL•¶Where•¶•¶Žš—ñ

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SELECT SQL•¶‚Ìì¬
                            m_strInsertSQL = "INSERT INTO " + ABGappeiDoitsuninEntity.TABLE_NAME + " "
                            strInsertColumn = ""
                            strInsertParam = ""

                            ' XVíœWhere•¶ì¬
                            strWhere.Append(" WHERE ")
                            strWhere.Append(ABGappeiDoitsuninEntity.JUMINCD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABGappeiDoitsuninEntity.KEY_JUMINCD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABGappeiDoitsuninEntity.KEY_DOITSUNINSHIKIBETSUCD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABGappeiDoitsuninEntity.KOSHINCOUNTER)
                            strWhere.Append(" = ")
                            strWhere.Append(ABGappeiDoitsuninEntity.KEY_KOSHINCOUNTER)

                            ' UPDATE SQL•¶‚Ìì¬
                            m_strUpdateSQL = "UPDATE " + ABGappeiDoitsuninEntity.TABLE_NAME + " SET "

                            ' DELETEi•¨—j SQL•¶‚Ìì¬
                            strDeleteSQL.Append("DELETE FROM ")
                            strDeleteSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME)
                            strDeleteSQL.Append(strWhere.ToString)
                            m_strDeleteSQL = strDeleteSQL.ToString

                            ' SELECT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfInsertUFParameterCollectionClass = New UFParameterCollectionClass

                            ' UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfUpdateUFParameterCollectionClass = New UFParameterCollectionClass

                            ' DELETEi•¨—j ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDeleteUFParameterCollectionClass = New UFParameterCollectionClass

                            ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                            For Each csDataColumn In csDataRow.Table.Columns
                                '' ƒJƒ‰ƒ€‚ª‘¶Ý‚·‚éê‡
                                'If (m_csSchema.Tables(ABGappeiDoitsuninEntity.TABLE_NAME).Columns.Contains(csDataColumn.ColumnName)) Then

                                cfUFParameterClass = New UFParameterClass

                                ' INSERT SQL•¶‚Ìì¬
                                strInsertColumn += csDataColumn.ColumnName + ", "
                                strInsertParam += ABGappeiDoitsuninEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", "

                                ' SQL•¶‚Ìì¬
                                m_strUpdateSQL += csDataColumn.ColumnName + " = " + ABGappeiDoitsuninEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", "

                                ' INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                                cfUFParameterClass.ParameterName = ABGappeiDoitsuninEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                                m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass)

                                ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                                cfUFParameterClass.ParameterName = ABGappeiDoitsuninEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                                'End If

                            Next csDataColumn

                            ' INSERT SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                            strInsertColumn = strInsertColumn.Trim()
                            strInsertColumn = strInsertColumn.Trim(CType(",", Char))
                            strInsertParam = strInsertParam.Trim()
                            strInsertParam = strInsertParam.Trim(CType(",", Char))
                            m_strInsertSQL += "(" + strInsertColumn + ")" + " VALUES (" + strInsertParam + ")"

                            ' UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                            m_strUpdateSQL = m_strUpdateSQL.Trim()
                            m_strUpdateSQL = m_strUpdateSQL.Trim(CType(",", Char))

                            ' UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                            m_strUpdateSQL += strWhere.ToString

                            ' UPDATE,DELETE(•¨—) ƒRƒŒƒNƒVƒ‡ƒ“‚ÉƒL[î•ñ‚ð’Ç‰Á
                            ' Z–¯ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABGappeiDoitsuninEntity.KEY_JUMINCD
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' “¯ˆêlŽ¯•ÊƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABGappeiDoitsuninEntity.KEY_DOITSUNINSHIKIBETSUCD
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' XVƒJƒEƒ“ƒ^
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABGappeiDoitsuninEntity.KEY_KOSHINCOUNTER
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try
                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                    '* 
                    '* \•¶           Private Sub CheckColumnValue(ByVal strColumnName As String,
                    '*                                             ByVal strValue As String)
                    '* 
                    '* ‹@”\@@       ‡•¹“¯ˆê‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¢‚Ü‚·B
                    '* 
                    '* ˆø”           strColumnName As String
                    '*                strValue As String
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CheckColumnValue(ByVal strColumnName As String, ByVal strValue As String)
                        Const THIS_METHOD_NAME As String = "CheckColumnValue"
                        Dim objErrorStruct As UFErrorStruct                 ' ƒGƒ‰[’è‹`\‘¢‘Ì

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            Select Case strColumnName.ToUpper()
                                Case ABGappeiDoitsuninEntity.JUMINCD                    'Z–¯ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_RDBDATATYPE_JUMINCD)
                                        ' —áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABGappeiDoitsuninEntity.SHICHOSONCD                'Žs’¬‘ºƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_RDBDATATYPE_SHICHOSONCD)
                                        ' —áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABGappeiDoitsuninEntity.KYUSHICHOSONCD             '‹ŒŽs’¬‘ºƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_RDBDATATYPE_KYUSHICHOSONCD)
                                        ' —áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD      '“¯ˆêlŽ¯•ÊƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_RDBDATATYPE_DOITSUNINSHIKIBETSUCD)
                                        ' —áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABGappeiDoitsuninEntity.HONNINKB                   '–{l‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_RDBDATATYPE_HONNINKB)
                                        ' —áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABGappeiDoitsuninEntity.HANYOKB1                   '”Ä—p‹æ•ª1
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_RDBDATATYPE_HANYOKB1)
                                        ' —áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABGappeiDoitsuninEntity.HANYOKB2                   '”Ä—p‹æ•ª2
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_RDBDATATYPE_HANYOKB2)
                                        ' —áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABGappeiDoitsuninEntity.BIKO                       '”õl
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_RDBDATATYPE_BIKO)
                                        ' —áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABGappeiDoitsuninEntity.RESERVE                    'ƒŠƒU[ƒu
                                    ' ‰½‚à‚µ‚È‚¢
                                Case ABGappeiDoitsuninEntity.TANMATSUID                 '’[––ID
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_RDBDATATYPE_TANMATSUID)
                                        ' —áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABGappeiDoitsuninEntity.SAKUJOFG                   'íœƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_RDBDATATYPE_SAKUJOFG)
                                        ' —áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABGappeiDoitsuninEntity.KOSHINCOUNTER              'XVƒJƒEƒ“ƒ^
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_RDBDATATYPE_KOSHINCOUNTER)
                                        ' —áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABGappeiDoitsuninEntity.SAKUSEINICHIJI             'ì¬“úŽž
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_RDBDATATYPE_SAKUSEINICHIJI)
                                        ' —áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABGappeiDoitsuninEntity.SAKUSEIUSER                'ì¬ƒ†[ƒU
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_RDBDATATYPE_SAKUSEIUSER)
                                        ' —áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABGappeiDoitsuninEntity.KOSHINNICHIJI              'XV“úŽž
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_RDBDATATYPE_KOSHINNICHIJI)
                                        ' —áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABGappeiDoitsuninEntity.KOSHINUSER                 'XVƒ†[ƒU
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABGAPPEIDOITSUNINB_RDBDATATYPE_KOSHINUSER)
                                        ' —áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                            End Select

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException
                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException
                        End Try

                    End Sub

                End Class

                 */
            }

            return default;
        }
    }
}