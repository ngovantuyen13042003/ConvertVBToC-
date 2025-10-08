// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ˆ¶–¼”N‹à‚c‚`(ABAtenaNenkinBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/01/06@ŽRè@•q¶
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/03/17 000001     ’Ç‰ÁŽžA‹¤’Ê€–Ú‚ðÝ’è‚·‚é
// * 2003/05/21 000002     ƒGƒ‰[A“ú•tƒNƒ‰ƒX‚Ì²Ý½ÀÝ½‚ðºÝ½Ä×¸À‚É•ÏX
// * 2003/06/20 000003     ƒGƒ‰[ƒNƒ‰ƒX‚ðƒGƒ‰[–ˆ‚É²Ý½ÀÝ½‰»‚·‚é
// * 2003/08/28 000004     RDBƒAƒNƒZƒXƒƒO‚ÌC³
// * 2003/09/11 000005     ”N‹à”Ô†‚ÅŽæ“¾‚·‚éƒƒ\ƒbƒh‚ÌŽd—l’Ç‰Á
// * 2003/09/24 000006     ƒtƒ@ƒCƒ‹’è‹`•ÏX‚É”º‚¤C³
// * 2003/10/03 000007     Žæ“¾——RE‘rŽ¸——R‚Ìƒ`ƒFƒbƒN‚ÍANK‚É•ÏX
// * 2004/11/11 000008     ƒf[ƒ^ƒ`ƒFƒbƒN‚ðs‚È‚í‚È‚¢
// * 2005/02/16 000009     ƒŒƒXƒ|ƒ“ƒX‰ü‘PF‚r‚p‚k•¶ì¬‚ÌC³     
// * 2010/04/16 000010     VS2008‘Î‰ži”ä‰Ãj
// ************************************************************************************************
using System;
using System.Linq;
using System.Text;

namespace Densan.Reams.AB.AB000BB
{

    public class ABAtenaNenkinBClass
    {
        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private UFErrorClass m_cfErrorClass;                  // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private UFDateClass m_cfDateClass;                    // “ú•tƒNƒ‰ƒX
        private string m_strInsertSQL;                                            // INSERT—pSQL
        private string m_strUpdateSQL;                                            // UPDATE—pSQL
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;  // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateUFParameterCollectionClass;  // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABAtenaNenkinBClass";
        private const string THIS_BUSINESSID = "AB";                              // ‹Æ–±ƒR[ƒh
        #endregion

        #region ƒRƒ“
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
        public ABAtenaNenkinBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

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
            m_cfInsertUFParameterCollectionClass = (object)null;
            m_cfUpdateUFParameterCollectionClass = (object)null;
        }
        #endregion

        #region ƒƒ\ƒbƒh
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼”N‹àƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetAtenaNenkin(ByVal strJuminCD As String) As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼”N‹àƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éBB
        // * 
        // * ˆø”           strJuminCD As String  :Z–¯ƒR[ƒh
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½ˆ¶–¼”N‹àƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsAtenaNenkinEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABAtenaNenkinEntity
        // ************************************************************************************************
        public DataSet GetAtenaNenkin(string strJuminCD)
        {
            const string THIS_METHOD_NAME = "GetAtenaNenkin";
            DataSet csAtenaNenkinEntity;
            var strSQL = new StringBuilder();
            UFParameterClass cfUFParameterClass;
            UFParameterCollectionClass cfUFParameterCollectionClass;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME);
                strSQL.Append(" WHERE ");
                strSQL.Append(ABAtenaNenkinEntity.JUMINCD);
                strSQL.Append(" = ");
                strSQL.Append(ABAtenaNenkinEntity.KEY_JUMINCD);
                strSQL.Append(" AND ");
                strSQL.Append(ABAtenaNenkinEntity.SAKUJOFG);
                strSQL.Append(" <> 1");

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaNenkinEntity.KEY_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // *—š—ð”Ô† 000004 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + strSQL.ToString + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + default



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

                // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 7133


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000004 2003/08/28 C³I—¹

                                 */
                csAtenaNenkinEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), ABAtenaNenkinEntity.TABLE_NAME, cfUFParameterCollectionClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 8062


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 8165


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 8715


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csAtenaNenkinEntity

                    End Function

                    '*—š—ð”Ô† 000005 2003/09/11 ’Ç‰ÁŠJŽn

                 */
            }

            return default;
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼”N‹àƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetAtenaNenkinBango(ByVal strKsNenknNO As String) As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼”N‹àƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éBB
        // * 
        // * ˆø”           strKsNenknNO As String  : Šî‘b”N‹à”Ô†
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½ˆ¶–¼”N‹àƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsAtenaNenkinEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABAtenaNenkinEntity
        // ************************************************************************************************
        public DataSet GetAtenaNenkinBango(string strKsNenknNO)
        {
            DataSet csAtenaNenkinEntity;
            var strSQL = new StringBuilder();
            UFParameterClass cfUFParameterClass;
            UFParameterCollectionClass cfUFParameterCollectionClass;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABAtenaNenkinEntity.TABLE_NAME);
                strSQL.Append(" WHERE ");
                strSQL.Append(ABAtenaNenkinEntity.KSNENKNNO);
                strSQL.Append(" = ");
                strSQL.Append(ABAtenaNenkinEntity.PARAM_KSNENKNNO);
                strSQL.Append(" AND ");
                strSQL.Append(ABAtenaNenkinEntity.SAKUJOFG);
                strSQL.Append(" <> ");
                strSQL.Append(ABAtenaNenkinEntity.PARAM_SAKUJOFG);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaNenkinEntity.PARAM_KSNENKNNO;
                cfUFParameterClass.Value = strKsNenknNO;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaNenkinEntity.PARAM_SAKUJOFG;
                cfUFParameterClass.Value = "1";
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);


                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + default



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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11928


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csAtenaNenkinEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), ABAtenaNenkinEntity.TABLE_NAME, cfUFParameterCollectionClass);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }

            catch (UFAppException exAppException)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLogClass.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12787


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12890


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
            }

            catch (Exception exException) // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
            {
                // ƒGƒ‰[ƒƒOo—Í
                m_cfLogClass.ErrorWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13430


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csAtenaNenkinEntity

                    End Function
                    '*—š—ð”Ô† 000005 2003/09/11 ’Ç‰ÁI—¹

                 */
            }

            return default;
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼”N‹àƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertAtenaNenkin(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @  ˆ¶–¼”N‹àƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚éB
        // * 
        // * ˆø”           csDataRow As DataRow  :’Ç‰Áƒf[ƒ^
        // * 
        // * –ß‚è’l         ’Ç‰ÁŒ”(Integer)
        // ************************************************************************************************
        public int InsertAtenaNenkin(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "InsertAtenaNenkin";
            // * corresponds to VS2008 Start 2010/04/16 000010
            // Dim csDataColumn As DataColumn
            // Dim intIndex As Integer
            // * corresponds to VS2008 End 2010/04/16 000010
            int intInsCnt;
            string strUpdateDateTime;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strInsertSQL is null | string.IsNullOrEmpty(m_strInsertSQL) | m_cfInsertUFParameterCollectionClass is null)
                {
                    // *—š—ð”Ô† 000009 2005/02/16 C³ŠJŽn
                    CreateInsertSQL(csDataRow);
                    // Call CreateSQL(csDataRow)
                    // *—š—ð”Ô† 000009 2005/02/16 C³I—¹
                }

                // XV“úŽž‚ÌŽæ“¾
                strUpdateDateTime = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");          // ì¬“úŽž

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABAtenaNenkinEntity.TANMATSUID) = m_cfControlData.m_strClientId;               // ’[––‚h‚c
                csDataRow(ABAtenaNenkinEntity.SAKUJOFG) = "0";                                           // íœƒtƒ‰ƒO
                csDataRow(ABAtenaNenkinEntity.KOSHINCOUNTER) = decimal.Zero;                             // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaNenkinEntity.SAKUSEINICHIJI) = strUpdateDateTime;                       // ì¬“úŽž
                csDataRow(ABAtenaNenkinEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;                // ì¬ƒ†[ƒU[
                csDataRow(ABAtenaNenkinEntity.KOSHINNICHIJI) = strUpdateDateTime;                        // XV“úŽž
                csDataRow(ABAtenaNenkinEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                 // XVƒ†[ƒU[

                // *—š—ð”Ô† 000008 2004/11/11 C³ŠJŽn
                // “–ƒNƒ‰ƒX‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¤
                // For Each csDataColumn In csDataRow.Table.Columns
                // ' ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                // CheckColumnValue(csDataColumn.ColumnName, csDataRow(csDataColumn.ColumnName).ToString.Trim)
                // Next csDataColumn
                // *—š—ð”Ô† 000008 2004/11/11 C³I—¹

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    this.m_cfInsertUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaNenkinEntity.PARAM_PLACEHOLDER.RLength)).ToString();

                // *—š—ð”Ô† 000004 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strInsertSQL + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + default



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

                // SQL‚ÌŽÀs
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17851


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strInsertSQL, m_cfInsertUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000004 2003/08/28 C³I—¹

                                 */
                intInsCnt = m_cfRdbClass.ExecuteSQL(m_strInsertSQL, m_cfInsertUFParameterCollectionClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 18744


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 18847


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 19397


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return intInsCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼”N‹àƒ}ƒXƒ^XV

                 */
            }

            return default;
        }
        // * 
        // * \•¶           Public Function UpdateAtenaNenkin(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @  ˆ¶–¼”N‹àƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚éB
        // * 
        // * ˆø”           csDataRow As DataRow  :XVƒf[ƒ^
        // * 
        // * –ß‚è’l         XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateAtenaNenkin(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "UpdateAtenaNenkin";
            // * corresponds to VS2008 Start 2010/04/16 000010
            // Dim csDataColumn As DataColumn
            // Dim intIndex As Integer
            // * corresponds to VS2008 End 2010/04/16 000010
            int intUpdCnt;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strUpdateSQL is null | string.IsNullOrEmpty(m_strUpdateSQL) | m_cfUpdateUFParameterCollectionClass is null)
                {
                    // *—š—ð”Ô† 000009 2005/02/16 C³ŠJŽn
                    CreateUpdateSQL(csDataRow);
                    // Call CreateSQL(csDataRow)
                    // *—š—ð”Ô† 000009 2005/02/16 C³I—¹
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABAtenaNenkinEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                   // ’[––‚h‚c
                csDataRow(ABAtenaNenkinEntity.KOSHINCOUNTER) = (decimal)csDataRow(ABAtenaNenkinEntity.KOSHINCOUNTER) + 1m;       // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaNenkinEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");   // XV“úŽž
                csDataRow(ABAtenaNenkinEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                     // XVƒ†[ƒU[

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABAtenaNenkinEntity.PREFIX_KEY.RLength) == ABAtenaNenkinEntity.PREFIX_KEY)
                    {
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaNenkinEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // *—š—ð”Ô† 000008 2004/11/11 C³ŠJŽn
                        // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                        // CheckColumnValue(cfParam.ParameterName.Substring(ABAtenaNenkinEntity.PARAM_PLACEHOLDER.Length), csDataRow(cfParam.ParameterName.Substring(ABAtenaNenkinEntity.PARAM_PLACEHOLDER.Length), DataRowVersion.Current).ToString.Trim)
                        // *—š—ð”Ô† 000008 2004/11/11 C³I—¹
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaNenkinEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // *—š—ð”Ô† 000004 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strUpdateSQL + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + default



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

                // SQL‚ÌŽÀs
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 23939


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000004 2003/08/28 C³I—¹

                                 */
                intUpdCnt = m_cfRdbClass.ExecuteSQL(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 24832


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 24935


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 25485


                Input:
                " + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return intUpdCnt

                    End Function

                    '*—š—ð”Ô† 000009 2005/02/16 ’Ç‰ÁŠJŽn

                 */
            }

            return default;
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     SQL•¶‚Ìì¬
        // * 
        // * \•¶           Private Sub CreateInsertSQL(ByVal csDataRow As DataRow)
        // * 
        // * ‹@”\@@    @ INSERTSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void CreateInsertSQL(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "CreateInsertSQL";
            string strInsertColumn;
            string strInsertParam;
            UFParameterClass cfUFParameterClass;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // INSERT SQL•¶‚Ìì¬
                m_strInsertSQL = "INSERT INTO " + ABAtenaNenkinEntity.TABLE_NAME + " ";
                strInsertColumn = "";
                strInsertParam = "";

                // INSERT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfInsertUFParameterCollectionClass = new UFParameterCollectionClass();

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                {
                    cfUFParameterClass = new UFParameterClass();

                    // INSERT SQL•¶‚Ìì¬
                    strInsertColumn += csDataColumn.ColumnName + ", ";
                    strInsertParam += ABAtenaNenkinEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", ";

                    // INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    cfUFParameterClass.ParameterName = ABAtenaNenkinEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
                    m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass);

                }

                // INSERT SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                strInsertColumn = strInsertColumn.Trim();
                strInsertColumn = strInsertColumn.Trim(",");
                strInsertParam = strInsertParam.Trim();
                strInsertParam = strInsertParam.Trim(",");

                m_strInsertSQL += "(" + strInsertColumn + ")" + " VALUES (" + strInsertParam + ")";

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 28656


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 28759


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 29309


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try
                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     SQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateUpdateSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\@@    @ UPDATESQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow :
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 29796


                Input:
                 XV‘ÎÛ‚Ìs

                 */
            }
        }
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void CreateUpdateSQL(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "CreateUpdateSQL";
            UFParameterClass cfUFParameterClass;
            string strUpdateWhere;
            string strUpdateParam;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // UPDATE SQL•¶‚Ìì¬
                m_strUpdateSQL = "UPDATE " + ABAtenaNenkinEntity.TABLE_NAME + " SET ";
                strUpdateParam = "";
                strUpdateWhere = "";

                // UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfUpdateUFParameterCollectionClass = new UFParameterCollectionClass();

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                {

                    // Z–¯‚b‚ciŽåƒL[j‚Æì¬“úŽžEì¬ƒ†[ƒU‚ÍXV‚µ‚È‚¢
                    if (!(csDataColumn.ColumnName == ABAtenaInkanEntity.JUMINCD) && !(csDataColumn.ColumnName == ABAtenaInkanEntity.SAKUSEIUSER) && !(csDataColumn.ColumnName == ABAtenaInkanEntity.SAKUSEINICHIJI))

                    {

                        cfUFParameterClass = new UFParameterClass();

                        // SQL•¶‚Ìì¬
                        m_strUpdateSQL += csDataColumn.ColumnName + " = " + ABAtenaNenkinEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", ";

                        // UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                        cfUFParameterClass.ParameterName = ABAtenaNenkinEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
                        m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);
                    }

                }

                // UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                m_strUpdateSQL = m_strUpdateSQL.Trim();
                m_strUpdateSQL = m_strUpdateSQL.Trim(",");

                // UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                m_strUpdateSQL += " WHERE " + ABAtenaNenkinEntity.JUMINCD + " = " + ABAtenaNenkinEntity.KEY_JUMINCD + " AND " + ABAtenaNenkinEntity.KOSHINCOUNTER + " = " + ABAtenaNenkinEntity.KEY_KOSHINCOUNTER;

                // UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaNenkinEntity.KEY_JUMINCD;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaNenkinEntity.KEY_KOSHINCOUNTER;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 33321


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 33424


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 33974


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try
                    End Sub
                    '*—š—ð”Ô† 000009 2005/02/16 ’Ç‰ÁI—¹

                 */
            }
        }

        // *—š—ð”Ô† 000009 2005/02/16 íœŠJŽn
        // '************************************************************************************************
        // '* ƒƒ\ƒbƒh–¼     SQL•¶‚Ìì¬
        // '* 
        // '* \•¶           Private Sub CreateSQL(ByVal csDataRow As DataRow)
        // '* 
        // '* ‹@”\@@    @@INSERT, UPDATE, DELETE‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // '* 
        // '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
        // '* 
        // '* –ß‚è’l         ‚È‚µ
        // '************************************************************************************************
        // Private Sub CreateSQL(ByVal csDataRow As DataRow)
        // Const THIS_METHOD_NAME As String = "CreateSQL"
        // Dim csDataColumn As DataColumn
        // Dim strInsertColumn As String
        // Dim strInsertParam As String
        // Dim cfUFParameterClass As UFParameterClass
        // Dim strUpdateWhere As String
        // Dim strUpdateParam As String

        // Try
        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // ' SELECT SQL•¶‚Ìì¬
        // m_strInsertSQL = "INSERT INTO " + ABAtenaNenkinEntity.TABLE_NAME + " "
        // strInsertColumn = ""
        // strInsertParam = ""

        // ' UPDATE SQL•¶‚Ìì¬
        // m_strUpdateSQL = "UPDATE " + ABAtenaNenkinEntity.TABLE_NAME + " SET "
        // strUpdateParam = ""
        // strUpdateWhere = ""

        // ' SELECT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
        // m_cfInsertUFParameterCollectionClass = New UFParameterCollectionClass()

        // ' UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
        // m_cfUpdateUFParameterCollectionClass = New UFParameterCollectionClass()

        // ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
        // For Each csDataColumn In csDataRow.Table.Columns
        // cfUFParameterClass = New UFParameterClass()

        // ' INSERT SQL•¶‚Ìì¬
        // strInsertColumn += csDataColumn.ColumnName + ", "
        // strInsertParam += ABAtenaNenkinEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", "

        // ' SQL•¶‚Ìì¬
        // m_strUpdateSQL += csDataColumn.ColumnName + " = " + ABAtenaNenkinEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", "

        // ' INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
        // cfUFParameterClass.ParameterName = ABAtenaNenkinEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
        // m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass)

        // ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
        // cfUFParameterClass.ParameterName = ABAtenaNenkinEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
        // m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

        // Next csDataColumn

        // ' INSERT SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
        // strInsertColumn = strInsertColumn.Trim()
        // strInsertColumn = strInsertColumn.Trim(CType(",", Char))
        // strInsertParam = strInsertParam.Trim()
        // strInsertParam = strInsertParam.Trim(CType(",", Char))

        // m_strInsertSQL += "(" + strInsertColumn + ")" + " VALUES (" + strInsertParam + ")"

        // ' UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
        // m_strUpdateSQL = m_strUpdateSQL.Trim()
        // m_strUpdateSQL = m_strUpdateSQL.Trim(CType(",", Char))

        // ' UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
        // m_strUpdateSQL += " WHERE " + ABAtenaNenkinEntity.JUMINCD + " = " + ABAtenaNenkinEntity.KEY_JUMINCD + " AND " + _
        // ABAtenaNenkinEntity.KOSHINCOUNTER + " = " + ABAtenaNenkinEntity.KEY_KOSHINCOUNTER

        // ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
        // cfUFParameterClass = New UFParameterClass()
        // cfUFParameterClass.ParameterName = ABAtenaNenkinEntity.KEY_JUMINCD
        // m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

        // cfUFParameterClass = New UFParameterClass()
        // cfUFParameterClass.ParameterName = ABAtenaNenkinEntity.KEY_KOSHINCOUNTER
        // m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

        // 'ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // Catch exAppException As UFAppException
        // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
        // m_cfLogClass.WarningWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
        // "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
        // ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
        // Throw exAppException

        // Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
        // ' ƒGƒ‰[ƒƒOo—Í
        // m_cfLogClass.ErrorWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒGƒ‰[“à—e:" + exException.Message + "z")
        // ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
        // Throw exException

        // End Try
        // End Sub
        // *—š—ð”Ô† 000009 2005/02/16 íœI—¹

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
        // * 
        // * \•¶           Private Sub CheckColumnValue(ByVal strColumnName As String,
        // *                                             ByVal strValue As String)
        // * 
        // * ‹@”\@@       ˆ¶–¼”N‹àƒ}ƒXƒ^‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¢‚Ü‚·B
        // * 
        // * ˆø”           strColumnName As String
        // *                strValue As String
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void CheckColumnValue(string strColumnName, string strValue)
        {
            const string THIS_METHOD_NAME = "CheckColumnValue";
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // “ú•tƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                if (m_cfDateClass == null)
                {
                    m_cfDateClass = new UFDateClass(m_cfConfigDataClass);
                    // “ú•tƒNƒ‰ƒX‚Ì•K—v‚ÈÝ’è‚ðs‚¤
                    m_cfDateClass.p_enDateSeparator = UFDateSeparator.None;
                }

                switch (strColumnName.ToUpper() ?? "")
                {
                    case var @case when @case == ABAtenaNenkinEntity.JUMINCD:                        // Z–¯ƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JUMINCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case1 when case1 == ABAtenaNenkinEntity.SHICHOSONCD:                    // Žs’¬‘ºƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_SHICHOSONCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case2 when case2 == ABAtenaNenkinEntity.KYUSHICHOSONCD:                 // ‹ŒŽs’¬‘ºƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_KYUSHICHOSONCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case3 when case3 == ABAtenaNenkinEntity.KSNENKNNO:                      // Šî‘b”N‹à”Ô†
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_KSNENKNNO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case4 when case4 == ABAtenaNenkinEntity.SKAKSHUTKYMD:                   // Ž‘ŠiŽæ“¾”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_SKAKSHUTKYMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }
                    case var case5 when case5 == ABAtenaNenkinEntity.SKAKSHUTKSHU:                   // Ž‘ŠiŽæ“¾Ží•Ê
                        {
                            if (!UFStringClass.CheckAlphabetNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_SKAKSHUTKSHU);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case6 when case6 == ABAtenaNenkinEntity.SKAKSHUTKRIYUCD:                // Ž‘ŠiŽæ“¾——RƒR[ƒh
                        {
                            // * —š—ð”Ô† 000007 2003/10/03 C³ŠJŽn
                            // If (Not UFStringClass.CheckNumber(strValue)) Then
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // * —š—ð”Ô† 000007 2003/10/03 C³I—¹
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_SKAKSHUTKRIYUCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case7 when case7 == ABAtenaNenkinEntity.SKAKSSHTSYMD:                   // Ž‘Ši‘rŽ¸”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_SKAKSSHTSYMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }
                    case var case8 when case8 == ABAtenaNenkinEntity.SKAKSSHTSRIYUCD:                // Ž‘Ši‘rŽ¸——RƒR[ƒh
                        {
                            // * —š—ð”Ô† 000007 2003/10/03 C³ŠJŽn
                            // If (Not UFStringClass.CheckNumber(strValue)) Then
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // * —š—ð”Ô† 000007 2003/10/03 C³I—¹
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_SKAKSSHTSRIYUCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case9 when case9 == ABAtenaNenkinEntity.JKYNENKNKIGO1:                  // Žó‹‹”N‹à‹L†‚P
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNKIGO1);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    // * —š—ð”Ô† 000006 2003/09/24 C³ŠJŽn
                    // Case ABAtenaNenkinEntity.JKYNENKNSHU1                   'Žó‹‹”N‹à”Ô†‚P
                    // If (Not UFStringClass.CheckNumber(strValue)) Then
                    // m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                    // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                    // objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNSHU1)
                    // '—áŠO‚ð¶¬
                    // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                    // End If
                    // Case ABAtenaNenkinEntity.JKYNENKNNO1                    'Žó‹‹”N‹àŽí•Ê‚P
                    // If (Not UFStringClass.CheckANK(strValue)) Then
                    // m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                    // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                    // objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNNO1)
                    // '—áŠO‚ð¶¬
                    // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                    // End If

                    case var case10 when case10 == ABAtenaNenkinEntity.JKYNENKNNO1:                    // Žó‹‹”N‹à”Ô†‚P
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNSHU1);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case11 when case11 == ABAtenaNenkinEntity.JKYNENKNSHU1:                   // Žó‹‹”N‹àŽí•Ê‚P
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNNO1);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    // * —š—ð”Ô† 000006 2003/09/24 C³I—¹

                    case var case12 when case12 == ABAtenaNenkinEntity.JKYNENKNEDABAN1:                // Žó‹‹”N‹àŽ}”Ô‚P
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNEDABAN1);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case13 when case13 == ABAtenaNenkinEntity.JKYNENKNKB1:                    // Žó‹‹”N‹à‹æ•ª‚P
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNKB1);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case14 when case14 == ABAtenaNenkinEntity.JKYNENKNKIGO2:                  // Žó‹‹”N‹à‹L†‚Q
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNKIGO2);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    // * —š—ð”Ô† 000006 2003/09/24 C³ŠJŽn
                    // Case ABAtenaNenkinEntity.JKYNENKNSHU2                   'Žó‹‹”N‹à”Ô†‚Q
                    // If (Not UFStringClass.CheckNumber(strValue)) Then
                    // m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                    // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                    // objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNSHU2)
                    // '—áŠO‚ð¶¬
                    // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                    // End If
                    // Case ABAtenaNenkinEntity.JKYNENKNNO2                    'Žó‹‹”N‹àŽí•Ê‚Q
                    // If (Not UFStringClass.CheckANK(strValue)) Then
                    // m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                    // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                    // objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNNO2)
                    // '—áŠO‚ð¶¬
                    // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                    // End If

                    case var case15 when case15 == ABAtenaNenkinEntity.JKYNENKNNO2:                    // Žó‹‹”N‹à”Ô†‚Q
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNSHU2);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case16 when case16 == ABAtenaNenkinEntity.JKYNENKNSHU2:                   // Žó‹‹”N‹àŽí•Ê‚Q
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNNO2);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    // * —š—ð”Ô† 000006 2003/09/24 C³I—¹
                    case var case17 when case17 == ABAtenaNenkinEntity.JKYNENKNEDABAN2:                // Žó‹‹”N‹àŽ}”Ô‚Q
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNEDABAN2);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case18 when case18 == ABAtenaNenkinEntity.JKYNENKNKB2:                    // Žó‹‹”N‹à‹æ•ª‚Q
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNKB2);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case19 when case19 == ABAtenaNenkinEntity.JKYNENKNKIGO3:                  // Žó‹‹”N‹à‹L†‚R
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNKIGO3);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    // * —š—ð”Ô† 000006 2003/09/24 C³ŠJŽn
                    // Case ABAtenaNenkinEntity.JKYNENKNSHU3                   'Žó‹‹”N‹à”Ô†‚R
                    // If (Not UFStringClass.CheckNumber(strValue)) Then
                    // m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                    // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                    // objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNSHU3)
                    // '—áŠO‚ð¶¬
                    // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                    // End If
                    // Case ABAtenaNenkinEntity.JKYNENKNNO3                    'Žó‹‹”N‹àŽí•Ê‚R
                    // If (Not UFStringClass.CheckANK(strValue)) Then
                    // m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                    // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                    // objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNNO3)
                    // '—áŠO‚ð¶¬
                    // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                    // End If

                    case var case20 when case20 == ABAtenaNenkinEntity.JKYNENKNNO3:                    // Žó‹‹”N‹à”Ô†‚R
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNSHU3);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case21 when case21 == ABAtenaNenkinEntity.JKYNENKNSHU3:                   // Žó‹‹”N‹àŽí•Ê‚R
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNNO3);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    // * —š—ð”Ô† 000006 2003/09/24 C³I—¹
                    case var case22 when case22 == ABAtenaNenkinEntity.JKYNENKNEDABAN3:                // Žó‹‹”N‹àŽ}”Ô‚R
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNEDABAN3);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case23 when case23 == ABAtenaNenkinEntity.JKYNENKNKB3:                    // Žó‹‹”N‹à‹æ•ª‚R
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_JKYNENKNKB3);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case24 when case24 == ABAtenaNenkinEntity.TANMATSUID:                     // ’[––ID
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_TANMATSUID);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case25 when case25 == ABAtenaNenkinEntity.SAKUJOFG:                       // íœƒtƒ‰ƒO
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_SAKUJOFG);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case26 when case26 == ABAtenaNenkinEntity.KOSHINCOUNTER:                  // XVƒJƒEƒ“ƒ^
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_KOSHINCOUNTER);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case27 when case27 == ABAtenaNenkinEntity.SAKUSEINICHIJI:                 // ì¬“úŽž
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_SAKUSEINICHIJI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case28 when case28 == ABAtenaNenkinEntity.SAKUSEIUSER:                    // ì¬ƒ†[ƒU
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_SAKUSEIUSER);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case29 when case29 == ABAtenaNenkinEntity.KOSHINNICHIJI:                  // XV“úŽž
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_KOSHINNICHIJI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case30 when case30 == ABAtenaNenkinEntity.KOSHINUSER:                     // XVƒ†[ƒU
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENANENKINB_RDBDATATYPE_KOSHINUSER);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 66027


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 66130


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 66679


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException
                        End Try
                    End Sub
                #End Region

                End Class

                 */
            }
        }
    }
}