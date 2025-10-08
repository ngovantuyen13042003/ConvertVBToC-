// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ˜A—æƒ}ƒXƒ^‚c‚`(ABRenrakusakiBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/01/14@ŽRè@•q¶
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/03/17 000001     ’Ç‰ÁŽžA‹¤’Ê€–Ú‚ðÝ’è‚·‚é
// * 2003/05/21 000002     ƒGƒ‰[A“ú•tƒNƒ‰ƒX‚Ì²Ý½ÀÝ½‚ðºÝ½Ä×¸À‚É•ÏX
// * 2003/08/28 000003     RDBƒAƒNƒZƒXƒƒO‚ÌC³
// * 2004/08/27 000004     ‘¬“x‰ü‘PFi‹{‘òj
// * 2010/04/16 000005     VS2008‘Î‰ži”ä‰Ãj
// * 2023/07/13 000006     yAB-0970-1zˆ¶–¼GETŽæ“¾€–Ú•W€‰»‘Î‰ži’‡¼j
// * 2024/02/06 000007     yAB-0860-1z˜A—æŠÇ—€–Ú’Ç‰Á(‰º‘º)
// * 2024/03/07 000008     yAB-0900-1zƒAƒhƒŒƒXEƒx[ƒXEƒŒƒWƒXƒgƒŠ‘Î‰ž(‰º‘º)
// ************************************************************************************************
using System;
using System.Linq;
using System.Text;

namespace Densan.Reams.AB.AB000BB
{

    public class ABRenrakusakiBClass
    {
        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFErrorClass m_cfErrorClass;                  // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private string m_strInsertSQL;                                                // INSERT—pSQL
        private string m_strUpdateSQL;                                                // UPDATE—pSQL
        private string m_strDeleteSQL;                                                // DELETE—pSQLi•¨—j
        private string m_strDelRonriSQL;                                              // DELETE—pSQLi˜_—j
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;      // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateUFParameterCollectionClass;      // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDeleteUFParameterCollectionClass;      // DELETE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“i•¨—j
        private UFParameterCollectionClass m_cfDelRonriUFParameterCollectionClass;    // DELETE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“i˜_—j
                                                                                      // * —š—ð”Ô† 000004 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
        private DataSet m_csDataSchma;   // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
                                         // * —š—ð”Ô† 000004 2004/08/27 ’Ç‰ÁI—¹
                                         // *—š—ð”Ô† 000006 2023/07/13 ’Ç‰ÁŠJŽn
        private DataSet m_csDataSchma_Hyojun;   // •W€‰»”ÅƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
                                                // *—š—ð”Ô† 000006 2023/07/13 ’Ç‰ÁI—¹

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABRenrakusakiBClass";
        private const string THIS_BUSINESSID = "AB";                              // ‹Æ–±ƒR[ƒh
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
        public ABRenrakusakiBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

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
            m_strDelRonriSQL = string.Empty;
            m_cfInsertUFParameterCollectionClass = (object)null;
            m_cfUpdateUFParameterCollectionClass = (object)null;
            m_cfDeleteUFParameterCollectionClass = (object)null;
            m_cfDelRonriUFParameterCollectionClass = (object)null;

            // SQL•¶‚Ìì¬
            // * —š—ð”Ô† 000004 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
            m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction("SELECT * FROM " + ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.TABLE_NAME, false);
            // * —š—ð”Ô† 000004 2004/08/27 ’Ç‰ÁI—¹
            // *—š—ð”Ô† 000006 2023/07/13 ’Ç‰ÁŠJŽn
            m_csDataSchma_Hyojun = this.GetRenrakusakiSchemaBHoshu_Hyojun();
            // *—š—ð”Ô† 000006 2023/07/13 ’Ç‰ÁI—¹

        }
        #endregion

        #region ƒƒ\ƒbƒh
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˜A—æƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Overloads Function GetRenrakusakiBHoshu(ByVal strJuminCD As String) As DataSet
        // * 
        // * ‹@”\@@    @@˜A—æƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”           strJuminCD As String  :Z–¯ƒR[ƒh
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½˜A—æƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsRenrakusakiEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABRenrakusakiEntity
        // ************************************************************************************************
        public DataSet GetRenrakusakiBHoshu(string strJuminCD)
        {
            const string THIS_METHOD_NAME = "GetRenrakusakiBHoshu";       // ‚±‚Ìƒƒ\ƒbƒh–¼
            DataSet csRenrakusakiEntity;                              // ˜A—æƒ}ƒXƒ^ƒf[ƒ^
            var strSQL = new StringBuilder();                               // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABRenrakusakiEntity.TABLE_NAME);
                // WHERE•¶Œ‹‡
                strSQL.Append(" WHERE ");
                strSQL.Append(ABRenrakusakiEntity.JUMINCD);
                strSQL.Append(" = ");
                strSQL.Append(ABRenrakusakiEntity.KEY_JUMINCD);
                // ORDER•¶Œ‹‡
                strSQL.Append(" ORDER BY ");
                strSQL.Append(ABRenrakusakiEntity.GYOMUCD);
                strSQL.Append(" ASC, ");
                strSQL.Append(ABRenrakusakiEntity.TOROKURENBAN);
                strSQL.Append(" ASC");

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_JUMINCD;
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
                // * —š—ð”Ô† 000004 2004/08/27 XVŠJŽni‹{‘òj
                // csRenrakusakiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, ABRenrakusakiEntity.TABLE_NAME, cfUFParameterCollectionClass)
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 8320


                                Input:
                                " + strSQL.ToString + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csRenrakusakiEntity = m_csDataSchma.Clone();
                csRenrakusakiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csRenrakusakiEntity, ABRenrakusakiEntity.TABLE_NAME, cfUFParameterCollectionClass, false);
                // * —š—ð”Ô† 000004 2004/08/27 XVI—¹
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9465


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9568


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10117


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csRenrakusakiEntity

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˜A—æƒ}ƒXƒ^’Šo(µ°ÊÞ°Û°ÄÞ)
                    '* 
                    '* \•¶           Public Overloads Function GetRenrakusakiBHoshu(ByVal strJuminCD As String, 
                    '*                                                        ByVal blnSakujoFG As Boolean) As DataSet
                    '* 
                    '* ‹@”\@@    @@˜A—æƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           strJuminCD As String    :Z–¯ƒR[ƒh
        // *                blnSakujoFG As Boolean  :íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½˜A—æƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsRenrakusakiEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABRenrakusakiEntity
        // ************************************************************************************************
        public DataSet GetRenrakusakiBHoshu(string strJuminCD, bool blnSakujoFG)
        {
            const string THIS_METHOD_NAME = "GetRenrakusakiBHoshu";       // ‚±‚Ìƒƒ\ƒbƒh–¼
            DataSet csRenrakusakiEntity;                              // ˜A—æƒ}ƒXƒ^ƒf[ƒ^
            var strSQL = new StringBuilder();                               // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABRenrakusakiEntity.TABLE_NAME);
                // WHERE•¶Œ‹‡
                strSQL.Append(" WHERE ");
                strSQL.Append(ABRenrakusakiEntity.JUMINCD);
                strSQL.Append(" = ");
                strSQL.Append(ABRenrakusakiEntity.KEY_JUMINCD);
                if (!blnSakujoFG)
                {
                    strSQL.Append(" AND ");
                    strSQL.Append(ABRenrakusakiEntity.SAKUJOFG);
                    strSQL.Append(" <> 1");
                }
                // ORDER•¶Œ‹‡
                strSQL.Append(" ORDER BY ");
                strSQL.Append(ABRenrakusakiEntity.GYOMUCD);
                strSQL.Append(" ASC, ");
                strSQL.Append(ABRenrakusakiEntity.TOROKURENBAN);
                strSQL.Append(" ASC");

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // *—š—ð”Ô† 000003 2003/08/28 C³ŠJŽn
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

                // * —š—ð”Ô† 000004 2004/08/27 XVŠJŽni‹{‘òj
                // csRenrakusakiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, ABRenrakusakiEntity.TABLE_NAME, cfUFParameterCollectionClass)
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 14111


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000003 2003/08/28 C³I—¹

                                 */
                csRenrakusakiEntity = m_csDataSchma.Clone();
                csRenrakusakiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csRenrakusakiEntity, ABRenrakusakiEntity.TABLE_NAME, cfUFParameterCollectionClass, false);
                // * —š—ð”Ô† 000004 2004/08/27 XVI—¹

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 15376


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 15479


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 16028


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csRenrakusakiEntity

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˜A—æƒ}ƒXƒ^’Šo(µ°ÊÞ°Û°ÄÞ)
                    '* 
                    '* \•¶           Public Overloads Function GetRenrakusakiBHoshu(ByVal strJuminCD As String, 
                    '*                                                        ByVal strGyomuCD As String, 
                    '*                                                        ByVal strGyomunaiSHUCD As String) As DataSet
                    '* 
                    '* ‹@”\@@    @@˜A—æƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           strJuminCD As String          :Z–¯ƒR[ƒh
        // *                strGyomuCD As String          :‹Æ–±ƒR[ƒh
        // *                strGyomunaiSHUCD As String    :‹Æ–±“àŽí•ÊƒR[ƒh
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½˜A—æƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsRenrakusakiEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABRenrakusakiEntity
        // ************************************************************************************************
        public DataSet GetRenrakusakiBHoshu(string strJuminCD, string strGyomuCD, string strGyomunaiSHUCD)
        {
            const string THIS_METHOD_NAME = "GetRenrakusakiBHoshu";       // ‚±‚Ìƒƒ\ƒbƒh–¼
            DataSet csRenrakusakiEntity;                              // ˜A—æƒ}ƒXƒ^ƒf[ƒ^
            var strSQL = new StringBuilder();                               // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
            bool blnSakujo = true;                                 // íœƒf[ƒ^“Ç‚Ýž‚Ý

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABRenrakusakiEntity.TABLE_NAME);
                // WHERE•¶Œ‹‡
                strSQL.Append(" WHERE ");
                strSQL.Append(ABRenrakusakiEntity.JUMINCD);          // Z–¯ƒR[ƒh
                strSQL.Append(" = ");
                strSQL.Append(ABRenrakusakiEntity.KEY_JUMINCD);
                strSQL.Append(" AND ");
                strSQL.Append(ABRenrakusakiEntity.GYOMUCD);          // ‹Æ–±ƒR[ƒh
                strSQL.Append(" = ");
                strSQL.Append(ABRenrakusakiEntity.KEY_GYOMUCD);
                strSQL.Append(" AND ");
                strSQL.Append(ABRenrakusakiEntity.GYOMUNAISHU_CD);   // ‹Æ–±“àŽí•ÊƒR[ƒh
                strSQL.Append(" = ");
                strSQL.Append(ABRenrakusakiEntity.KEY_GYOMUNAISHU_CD);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                // Z–¯ƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);
                // ‹Æ–±ƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_GYOMUCD;
                cfUFParameterClass.Value = strGyomuCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);
                // ‹Æ–±“àŽí•ÊƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_GYOMUNAISHU_CD;
                cfUFParameterClass.Value = strGyomunaiSHUCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // *—š—ð”Ô† 000003 2003/08/28 C³ŠJŽn
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
                // * —š—ð”Ô† 000004 2004/08/27 XVŠJŽni‹{‘òj
                // csRenrakusakiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, ABRenrakusakiEntity.TABLE_NAME, cfUFParameterCollectionClass)
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21080


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000003 2003/08/28 C³I—¹

                                 */
                csRenrakusakiEntity = m_csDataSchma.Clone();
                csRenrakusakiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csRenrakusakiEntity, ABRenrakusakiEntity.TABLE_NAME, cfUFParameterCollectionClass, false);
                // * —š—ð”Ô† 000004 2004/08/27 XVI—¹

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22338


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22439


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22982


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csRenrakusakiEntity

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˜A—æƒ}ƒXƒ^’Šo(µ°ÊÞ°Û°ÄÞ)
                    '* 
                    '* \•¶           Public Overloads Function GetRenrakusakiBHoshu(ByVal strJuminCD As String, 
                    '*                                                        ByVal strGyomuCD As String, 
                    '*                                                        ByVal strGyomunaiSHUCD As String, 
                    '*                                                        ByVal blnSakujoFG As Boolean) As DataSet
                    '* 
                    '* ‹@”\@@    @@˜A—æƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           strJuminCD As String          :Z–¯ƒR[ƒh
        // *                strGyomuCD As String          :‹Æ–±ƒR[ƒh
        // *                strGyomunaiSHUCD As String    :‹Æ–±“àŽí•ÊƒR[ƒh
        // *                blnSakujoFG As Boolean        :íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½˜A—æƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsRenrakusakiEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABRenrakusakiEntity
        // ************************************************************************************************
        public DataSet GetRenrakusakiBHoshu(string strJuminCD, string strGyomuCD, string strGyomunaiSHUCD, bool blnSakujoFG)
        {
            const string THIS_METHOD_NAME = "GetRenrakusakiBHoshu";       // ‚±‚Ìƒƒ\ƒbƒh–¼
            DataSet csRenrakusakiEntity;                              // ˜A—æƒ}ƒXƒ^ƒf[ƒ^
            var strSQL = new StringBuilder();                               // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
            bool blnSakujo = true;                                 // íœƒf[ƒ^“Ç‚Ýž‚Ý

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABRenrakusakiEntity.TABLE_NAME);
                // WHERE•¶Œ‹‡
                strSQL.Append(" WHERE ");
                strSQL.Append(ABRenrakusakiEntity.JUMINCD);          // Z–¯ƒR[ƒh
                strSQL.Append(" = ");
                strSQL.Append(ABRenrakusakiEntity.KEY_JUMINCD);
                strSQL.Append(" AND ");
                strSQL.Append(ABRenrakusakiEntity.GYOMUCD);          // ‹Æ–±ƒR[ƒh
                strSQL.Append(" = ");
                strSQL.Append(ABRenrakusakiEntity.KEY_GYOMUCD);
                strSQL.Append(" AND ");
                strSQL.Append(ABRenrakusakiEntity.GYOMUNAISHU_CD);   // ‹Æ–±“àŽí•ÊƒR[ƒh
                strSQL.Append(" = ");
                strSQL.Append(ABRenrakusakiEntity.KEY_GYOMUNAISHU_CD);
                if (!blnSakujoFG)
                {
                    strSQL.Append(" AND ");
                    strSQL.Append(ABRenrakusakiEntity.SAKUJOFG);     // íœƒtƒ‰ƒO
                    strSQL.Append(" <> 1");
                }

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                // Z–¯ƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);
                // ‹Æ–±ƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_GYOMUCD;
                cfUFParameterClass.Value = strGyomuCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);
                // ‹Æ–±“àŽí•ÊƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_GYOMUNAISHU_CD;
                cfUFParameterClass.Value = strGyomunaiSHUCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // *—š—ð”Ô† 000003 2003/08/28 C³ŠJŽn
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
                // * —š—ð”Ô† 000004 2004/08/27 XVŠJŽni‹{‘òj
                // csRenrakusakiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, ABRenrakusakiEntity.TABLE_NAME, cfUFParameterCollectionClass)
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 28440


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000003 2003/08/28 C³I—¹

                                 */
                csRenrakusakiEntity = m_csDataSchma.Clone();
                csRenrakusakiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csRenrakusakiEntity, ABRenrakusakiEntity.TABLE_NAME, cfUFParameterCollectionClass, false);
                // * —š—ð”Ô† 000004 2004/08/27 XVI—¹

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 29704


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 29807


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 30356


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csRenrakusakiEntity

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˜A—æƒ}ƒXƒ^’Ç‰Á
                    '* 
                    '* \•¶           Public Function InsertRenrakusakiB(ByVal csDataRow As DataRow) As Integer
                    '* 
                    '* ‹@”\@@    @  ˜A—æƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           csDataRow As DataRow  :’Ç‰Áƒf[ƒ^
        // * 
        // * –ß‚è’l         ’Ç‰ÁŒ”(Integer)
        // ************************************************************************************************
        public int InsertRenrakusakiB(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "InsertRenrakusakiB";         // ‚±‚Ìƒƒ\ƒbƒh–¼
                                                                          // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            int intInsCnt;                                        // ’Ç‰ÁŒ”
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
                csDataRow(ABRenrakusakiEntity.TANMATSUID) = m_cfControlData.m_strClientId;               // ’[––‚h‚c
                csDataRow(ABRenrakusakiEntity.SAKUJOFG) = "0";                                           // íœƒtƒ‰ƒO
                csDataRow(ABRenrakusakiEntity.KOSHINCOUNTER) = decimal.Zero;                             // XVƒJƒEƒ“ƒ^
                csDataRow(ABRenrakusakiEntity.SAKUSEINICHIJI) = strUpdateDateTime;                       // ì¬“úŽž
                csDataRow(ABRenrakusakiEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;                // ì¬ƒ†[ƒU[
                csDataRow(ABRenrakusakiEntity.KOSHINNICHIJI) = strUpdateDateTime;                        // XV“úŽž
                csDataRow(ABRenrakusakiEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                 // XVƒ†[ƒU[

                // “–ƒNƒ‰ƒX‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¤
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                    // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                    CheckColumnValue(csDataColumn.ColumnName, csDataRow(csDataColumn.ColumnName).ToString.Trim);

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    this.m_cfInsertUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABRenrakusakiEntity.PARAM_PLACEHOLDER.RLength)).ToString();

                // *—š—ð”Ô† 000003 2003/08/28 C³ŠJŽn
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 34424


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strInsertSQL, m_cfInsertUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000003 2003/08/28 C³I—¹

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 35317


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 35420


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 35969


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return intInsCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˜A—æƒ}ƒXƒ^XV
                    '* 
                    '* \•¶           Public Function UpdateRenrakusakiB(ByVal csDataRow As DataRow) As Integer
                    '* 
                    '* ‹@”\@@    @  ˜A—æƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           csDataRow As DataRow  :XVƒf[ƒ^
        // * 
        // * –ß‚è’l         XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateRenrakusakiB(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "UpdateRenrakusakiB";         // ‚±‚Ìƒƒ\ƒbƒh–¼
                                                                          // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                          // * corresponds to VS2008 Start 2010/04/16 000005
                                                                          // Dim csDataColumn As DataColumn
                                                                          // * corresponds to VS2008 End 2010/04/16 000005
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
                csDataRow(ABRenrakusakiEntity.TANMATSUID) = m_cfControlData.m_strClientId; // ’[––‚h‚c
                csDataRow(ABRenrakusakiEntity.KOSHINCOUNTER) = (decimal)csDataRow(ABRenrakusakiEntity.KOSHINCOUNTER) + 1m;   // XVƒJƒEƒ“ƒ^
                csDataRow(ABRenrakusakiEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");   // XV“úŽž
                csDataRow(ABRenrakusakiEntity.KOSHINUSER) = m_cfControlData.m_strUserId;   // XVƒ†[ƒU[

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABRenrakusakiEntity.PREFIX_KEY.RLength) == ABRenrakusakiEntity.PREFIX_KEY)
                    {
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABRenrakusakiEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                        CheckColumnValue(cfParam.ParameterName.RSubstring(ABRenrakusakiEntity.PARAM_PLACEHOLDER.RLength), csDataRow(cfParam.ParameterName.RSubstring(ABRenrakusakiEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString.Trim);
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABRenrakusakiEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // *—š—ð”Ô† 000003 2003/08/28 C³ŠJŽn
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
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40228


                Input:
                " + m_cfRdbClass.GetDevelopmentSQLString(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass) + "z")
                            '*—š—ð”Ô† 000003 2003/08/28 C³I—¹

                            ' SQL‚ÌŽÀs
                            intUpdCnt = m_cfRdbClass.ExecuteSQL(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass)

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

                        Return intUpdCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˜A—æƒ}ƒXƒ^íœi˜_—j
                    '* 
                    '* \•¶           Public Function DeleteRenrakusakiB(ByVal csDataRow As DataRow) As Integer
                    '* 
                    '* ‹@”\@@    @  ˜A—æƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðíœi˜_—j‚·‚éB
                    '* 
                    '* ˆø”           csDataRow As DataRow  :íœƒf[ƒ^
                    '* 
                    '* –ß‚è’l         íœi˜_—jŒ”(Integer)
                    '************************************************************************************************
                    Public Overloads Function DeleteRenrakusakiB(ByVal csDataRow As DataRow) As Integer
                        Const THIS_METHOD_NAME As String = "DeleteRenrakusakiBi˜_—j"  '‚±‚Ìƒƒ\ƒbƒh–¼
                        Dim cfParam As UFParameterClass                                 'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        '* corresponds to VS2008 Start 2010/04/16 000005
                        'Dim csDataColumn As DataColumn
                        '* corresponds to VS2008 End 2010/04/16 000005
                        Dim intDelCnt As Integer                                        'íœŒ”

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                            If (m_strDelRonriSQL Is Nothing Or m_strDelRonriSQL = String.Empty Or _
                                m_cfDelRonriUFParameterCollectionClass Is Nothing) Then
                                Call CreateSQL(csDataRow)
                            End If

                            ' ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                            csDataRow(ABRenrakusakiEntity.TANMATSUID) = m_cfControlData.m_strClientId '’[––‚h‚c
                            csDataRow(ABRenrakusakiEntity.SAKUJOFG) = 1                                 'íœƒtƒ‰ƒO
                            csDataRow(ABRenrakusakiEntity.KOSHINCOUNTER) = CDec(csDataRow(ABRenrakusakiEntity.KOSHINCOUNTER)) + 1   'XVƒJƒEƒ“ƒ^
                            csDataRow(ABRenrakusakiEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff")   'XV“úŽž
                            csDataRow(ABRenrakusakiEntity.KOSHINUSER) = m_cfControlData.m_strUserId   'XVƒ†[ƒU[

                            ' ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                            For Each cfParam In m_cfDelRonriUFParameterCollectionClass
                                ' ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                                If (cfParam.ParameterName.RSubstring(0, ABRenrakusakiEntity.PREFIX_KEY.RLength) = ABRenrakusakiEntity.PREFIX_KEY) Then
                                    m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value =
                                            csDataRow(cfParam.ParameterName.RSubstring(ABRenrakusakiEntity.PREFIX_KEY.RLength),
                                                      DataRowVersion.Original).ToString()
                                Else
                                    ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                                    m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABRenrakusakiEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString()
                                End If
                            Next cfParam

                            '*—š—ð”Ô† 000003 2003/08/28 C³ŠJŽn
                            '' RDBƒAƒNƒZƒXƒƒOo—Í
                            'm_cfLogClass.RdbWrite(m_cfControlData, _
                            '                            "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                            '                            "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                            '                            "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                            '                            "ySQL“à—e:" + m_strDelRonriSQL + "z")

                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                                                        "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                                                        "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass) + "z")
                            '*—š—ð”Ô† 000003 2003/08/28 C³I—¹

                            ' SQL‚ÌŽÀs
                            intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass)

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
                    '* ƒƒ\ƒbƒh–¼     ˜A—æƒ}ƒXƒ^íœi•¨—j
                    '* 
                    '* \•¶           Public Overloads Function DeleteRenrakusakiB(ByVal csDataRow As DataRow, 
                    '*                                                      ByVal strSakujoKB As String) As Integer
                    '* 
                    '* ‹@”\@@    @  ˜A—æƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðíœi•¨—j‚·‚éB
                    '* 
                    '* ˆø”           csDataRow As DataRow      :íœƒf[ƒ^
                    '*                strSakujoKB As String     :íœƒtƒ‰ƒO
                    '* 
                    '* –ß‚è’l         íœi•¨—jŒ”(Integer)
                    '************************************************************************************************
                    Public Overloads Function DeleteRenrakusakiB(ByVal csDataRow As DataRow, ByVal strSakujoKB As String) As Integer
                        Const THIS_METHOD_NAME As String = "DeleteRenrakusakiBi•¨—j"  '‚±‚Ìƒƒ\ƒbƒh–¼
                        Dim objErrorStruct As UFErrorStruct                             'ƒGƒ‰[’è‹`\‘¢‘Ì
                        Dim cfParam As UFParameterClass                                 'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        '* corresponds to VS2008 Start 2010/04/16 000005
                        'Dim csDataColumn As DataColumn
                        '* corresponds to VS2008 End 2010/04/16 000005
                        Dim intDelCnt As Integer                                        'íœŒ”

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ˆø”‚Ìíœ‹æ•ª‚ðƒ`ƒFƒbƒN
                            If (strSakujoKB <> "D") Then
                                m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                ' ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABRENRAKUSAKIB_DELETE_SAKUJOKB)
                                ' —áŠO‚ð¶¬
                                Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                            End If

                            ' SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                            If (m_strDeleteSQL Is Nothing Or m_strDeleteSQL = String.Empty Or _
                                m_cfDeleteUFParameterCollectionClass Is Nothing) Then
                                Call CreateSQL(csDataRow)
                            End If

                            ' ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                            For Each cfParam In m_cfDeleteUFParameterCollectionClass
                                ' ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                                If (cfParam.ParameterName.RSubstring(0, ABRenrakusakiEntity.PREFIX_KEY.RLength) = ABRenrakusakiEntity.PREFIX_KEY) Then
                                    m_cfDeleteUFParameterCollectionClass(cfParam.ParameterName).Value =
                                            csDataRow(cfParam.ParameterName.RSubstring(ABRenrakusakiEntity.PREFIX_KEY.RLength),
                                                      DataRowVersion.Original).ToString()
                                Else
                                    ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                                    m_cfDeleteUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABRenrakusakiEntity.PREFIX_KEY.RLength), DataRowVersion.Current).ToString()
                                End If
                            Next cfParam

                            '*—š—ð”Ô† 000003 2003/08/28 C³ŠJŽn
                            '' RDBƒAƒNƒZƒXƒƒOo—Í
                            'm_cfLogClass.RdbWrite(m_cfControlData, _
                            '                            "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                            '                            "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                            '                            "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                            '                            "ySQL“à—e:" + m_strDeleteSQL + "z")

                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                                                        "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                                                        "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strDeleteSQL, m_cfDeleteUFParameterCollectionClass) + "z")
                            '*—š—ð”Ô† 000003 2003/08/28 C³I—¹

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
                        Const THIS_METHOD_NAME As String = "CreateSQL"              '‚±‚Ìƒƒ\ƒbƒh–¼
                        Dim csDataColumn As DataColumn
                        Dim cfUFParameterClass As UFParameterClass                  'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim strInsertColumn As String                               '’Ç‰ÁSQL•¶€–Ú•¶Žš—ñ
                        Dim strInsertParam As String                                '’Ç‰ÁSQL•¶ƒpƒ‰ƒ[ƒ^•¶Žš—ñ
                        Dim strDelRonriSQL As New StringBuilder()                   '˜_—íœSQL•¶•¶Žš—ñ
                        Dim strDeleteSQL As New StringBuilder()                     '•¨—íœSQL•¶•¶Žš—ñ
                        Dim strWhere As New StringBuilder()                         'XVíœSQL•¶Where•¶•¶Žš—ñ

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SELECT SQL•¶‚Ìì¬
                            m_strInsertSQL = "INSERT INTO " + ABRenrakusakiEntity.TABLE_NAME + " "
                            strInsertColumn = ""
                            strInsertParam = ""

                            ' XVíœWhere•¶ì¬
                            strWhere.Append(" WHERE ")
                            strWhere.Append(ABRenrakusakiEntity.JUMINCD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABRenrakusakiEntity.KEY_JUMINCD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABRenrakusakiEntity.GYOMUCD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABRenrakusakiEntity.KEY_GYOMUCD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABRenrakusakiEntity.GYOMUNAISHU_CD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABRenrakusakiEntity.KEY_GYOMUNAISHU_CD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABRenrakusakiEntity.KOSHINCOUNTER)
                            strWhere.Append(" = ")
                            strWhere.Append(ABRenrakusakiEntity.KEY_KOSHINCOUNTER)

                            ' UPDATE SQL•¶‚Ìì¬
                            m_strUpdateSQL = "UPDATE " + ABRenrakusakiEntity.TABLE_NAME + " SET "

                            ' DELETEi˜_—j SQL•¶‚Ìì¬
                            strDelRonriSQL.Append("UPDATE ")
                            strDelRonriSQL.Append(ABRenrakusakiEntity.TABLE_NAME)
                            strDelRonriSQL.Append(" SET ")
                            strDelRonriSQL.Append(ABRenrakusakiEntity.TANMATSUID)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABRenrakusakiEntity.PARAM_TANMATSUID)
                            strDelRonriSQL.Append(", ")
                            strDelRonriSQL.Append(ABRenrakusakiEntity.SAKUJOFG)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABRenrakusakiEntity.PARAM_SAKUJOFG)
                            strDelRonriSQL.Append(", ")
                            strDelRonriSQL.Append(ABRenrakusakiEntity.KOSHINCOUNTER)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABRenrakusakiEntity.PARAM_KOSHINCOUNTER)
                            strDelRonriSQL.Append(", ")
                            strDelRonriSQL.Append(ABRenrakusakiEntity.KOSHINNICHIJI)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABRenrakusakiEntity.PARAM_KOSHINNICHIJI)
                            strDelRonriSQL.Append(", ")
                            strDelRonriSQL.Append(ABRenrakusakiEntity.KOSHINUSER)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABRenrakusakiEntity.PARAM_KOSHINUSER)
                            strDelRonriSQL.Append(strWhere.ToString)
                            m_strDelRonriSQL = strDelRonriSQL.ToString

                            ' DELETEi•¨—j SQL•¶‚Ìì¬
                            strDeleteSQL.Append("DELETE FROM ")
                            strDeleteSQL.Append(ABRenrakusakiEntity.TABLE_NAME)
                            strDeleteSQL.Append(strWhere.ToString)
                            m_strDeleteSQL = strDeleteSQL.ToString

                            ' SELECT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfInsertUFParameterCollectionClass = New UFParameterCollectionClass()

                            ' UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfUpdateUFParameterCollectionClass = New UFParameterCollectionClass()

                            ' DELETEi˜_—j ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDelRonriUFParameterCollectionClass = New UFParameterCollectionClass()

                            ' DELETEi•¨—j ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDeleteUFParameterCollectionClass = New UFParameterCollectionClass()

                            ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                            For Each csDataColumn In csDataRow.Table.Columns
                                cfUFParameterClass = New UFParameterClass()

                                ' INSERT SQL•¶‚Ìì¬
                                strInsertColumn += csDataColumn.ColumnName + ", "
                                strInsertParam += ABRenrakusakiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", "

                                ' SQL•¶‚Ìì¬
                                m_strUpdateSQL += csDataColumn.ColumnName + " = " + ABRenrakusakiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", "

                                ' INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                                cfUFParameterClass.ParameterName = ABRenrakusakiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                                m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass)

                                ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                                cfUFParameterClass.ParameterName = ABRenrakusakiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

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
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_JUMINCD
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ‹Æ–±ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_GYOMUCD
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ‹Æ–±“àŽí•ÊƒR[ƒh
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_GYOMUNAISHU_CD
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' XVƒJƒEƒ“ƒ^
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_KOSHINCOUNTER
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' DELETEi˜_—j ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            ' ’[––‚h‚c
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiEntity.PARAM_TANMATSUID
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' íœƒtƒ‰ƒO
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiEntity.PARAM_SAKUJOFG
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' XVƒJƒEƒ“ƒ^
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiEntity.PARAM_KOSHINCOUNTER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' XV“úŽž
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiEntity.PARAM_KOSHINNICHIJI
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' XVƒ†[ƒU
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiEntity.PARAM_KOSHINUSER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' Z–¯ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_JUMINCD
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ‹Æ–±ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_GYOMUCD
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ‹Æ–±“àŽí•ÊƒR[ƒh
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_GYOMUNAISHU_CD
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' XVƒJƒEƒ“ƒ^
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_KOSHINCOUNTER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

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
                    '* ‹@”\@@       ˜A—æƒ}ƒXƒ^‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¢‚Ü‚·B
                    '* 
                    '* ˆø”           strColumnName As String
                    '*                strValue As String
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CheckColumnValue(ByVal strColumnName As String, ByVal strValue As String)
                        Const THIS_METHOD_NAME As String = "CheckColumnValue"       '‚±‚Ìƒƒ\ƒbƒh–¼
                        Dim objErrorStruct As UFErrorStruct                         'ƒGƒ‰[’è‹`\‘¢‘Ì

                        Try
                            'ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            Select Case strColumnName.ToUpper()
                                Case ABRenrakusakiEntity.JUMINCD                        'Z–¯ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABRENRAKUSAKIB_RDBDATATYPE_JUMINCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABRenrakusakiEntity.SHICHOSONCD                    'Žs’¬‘ºƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABRENRAKUSAKIB_RDBDATATYPE_SHICHOSONCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABRenrakusakiEntity.KYUSHICHOSONCD                 '‹ŒŽs’¬‘ºƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABRENRAKUSAKIB_RDBDATATYPE_KYUSHICHOSONCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABRenrakusakiEntity.GYOMUCD                        '‹Æ–±ƒR[ƒh
                                    If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABRENRAKUSAKIB_RDBDATATYPE_GYOMUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABRenrakusakiEntity.GYOMUNAISHU_CD                 '‹Æ–±“àŽí•ÊƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABRENRAKUSAKIB_RDBDATATYPE_GYOMUNAISHU_CD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABRenrakusakiEntity.RENRAKUSAKI1                   '˜A—æ1
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABRENRAKUSAKIB_RDBDATATYPE_RENRAKUSAKI1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABRenrakusakiEntity.RENRAKUSAKI2                   '˜A—æ2
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABRENRAKUSAKIB_RDBDATATYPE_RENRAKUSAKI2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABRenrakusakiEntity.RESERVE                        'ƒŠƒU[ƒu
                                    '‰½‚à‚µ‚È‚¢
                                Case ABRenrakusakiEntity.TANMATSUID                     '’[––ID
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABRENRAKUSAKIB_RDBDATATYPE_TANMATSUID)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABRenrakusakiEntity.SAKUJOFG                       'íœƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABRENRAKUSAKIB_RDBDATATYPE_SAKUJOFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABRenrakusakiEntity.KOSHINCOUNTER                  'XVƒJƒEƒ“ƒ^
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABRENRAKUSAKIB_RDBDATATYPE_KOSHINCOUNTER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABRenrakusakiEntity.SAKUSEINICHIJI                 'ì¬“úŽž
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABRENRAKUSAKIB_RDBDATATYPE_SAKUSEINICHIJI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABRenrakusakiEntity.SAKUSEIUSER                    'ì¬ƒ†[ƒU
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABRENRAKUSAKIB_RDBDATATYPE_SAKUSEIUSER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABRenrakusakiEntity.KOSHINNICHIJI                  'XV“úŽž
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABRENRAKUSAKIB_RDBDATATYPE_KOSHINNICHIJI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABRenrakusakiEntity.KOSHINUSER                     'XVƒ†[ƒU
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABRENRAKUSAKIB_RDBDATATYPE_KOSHINUSER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                            End Select

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException
                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException
                        End Try
                    End Sub

                    '*—š—ð”Ô† 000006 2023/07/13 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˜A—æƒ}ƒXƒ^’Šo_•W€”Å
                    '* 
                    '* \•¶           Public Overloads Function GetRenrakusakiBHoshu_Hyojun(ByVal strJuminCD As String, 
                    '*                                                        ByVal strGyomuCD As String, 
                    '*                                                        ByVal strGyomunaiSHUCD As String,
                    '*                                                        ByVal strKikanYMD As String) As DataSet
                    '* 
                    '* ‹@”\@@    @@˜A—æƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
                    '* 
                    '* ˆø”           strJuminCD As String          :Z–¯ƒR[ƒh
                    '*                strGyomuCD As String          :‹Æ–±ƒR[ƒh
                    '*                strGyomunaiSHUCD As String    :‹Æ–±“àŽí•ÊƒR[ƒh
                    '*                strKikanYMD As String         :ŠúŠÔ”NŒŽ“ú
                    '* 
                    '* –ß‚è’l         Žæ“¾‚µ‚½˜A—æƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
                    '*                   \‘¢FcsRenrakusakiEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABRenrakusakiEntity
                    '************************************************************************************************
                    Public Overloads Function GetRenrakusakiBHoshu_Hyojun(ByVal strJuminCD As String, ByVal strGyomuCD As String, ByVal strGyomunaiSHUCD As String, ByVal strKikanYMD As String) As DataSet
                        Const THIS_METHOD_NAME As String = "GetRenrakusakiBHoshu_Hyojun" '‚±‚Ìƒƒ\ƒbƒh–¼
                        Dim csRenrakusakiEntity As DataSet                              '˜A—æƒ}ƒXƒ^ƒf[ƒ^
                        Dim strSQL As New StringBuilder()                               'SQL•¶•¶Žš—ñ
                        Dim cfUFParameterClass As UFParameterClass                      'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim cfUFParameterCollectionClass As UFParameterCollectionClass  'ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
                        Dim blnSakujo As Boolean = True                                 'íœƒf[ƒ^“Ç‚Ýž‚Ý

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SQL•¶‚Ìì¬
                            strSQL.AppendFormat("SELECT {0}.* ", ABRenrakusakiEntity.TABLE_NAME)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI4)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI5)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI6)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI1BIKO)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI2BIKO)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI3BIKO)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI4BIKO)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI5BIKO)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI6BIKO)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKI_STYMD)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKI_EDYMD)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU1)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU2)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU3)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU4)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU5)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU6)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKIYUBINNO)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKIJUSHOCD)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKIJUSHO)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHIKUCHOSONCD)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKIMACHIAZACD)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKTODOFUKEN)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHICHOSON)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKIMACHIAZA)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKIBANCHI)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKIKATAGAKI)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.TOROKUYMD)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.GYOSEIKUCD)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKIEDABAN)
                            strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.BIKO)
                            strSQL.AppendFormat(" FROM {0}", ABRenrakusakiEntity.TABLE_NAME)

                            ' JOIN•¶Œ‹‡
                            strSQL.AppendFormat(" LEFT JOIN {0}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME)
                            strSQL.AppendFormat(" ON {0}.{1} = {2}.{3}",
                                                ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.JUMINCD,
                                                ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.JUMINCD)
                            strSQL.AppendFormat(" AND {0}.{1} = {2}.{3}",
                                                ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.GYOMUCD,
                                                ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.GYOMUCD)
                            strSQL.AppendFormat(" AND {0}.{1} = {2}.{3}",
                                                ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.GYOMUNAISHU_CD,
                                                ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.GYOMUNAISHU_CD)
                            strSQL.AppendFormat(" AND {0}.{1} = {2}.{3}",
                                                ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.TOROKURENBAN,
                                                ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.TOROKURENBAN)
                            strSQL.AppendFormat(" LEFT JOIN {0}", ABRenrakusakiFZYEntity.TABLE_NAME)
                            strSQL.AppendFormat(" ON {0}.{1} = {2}.{3}",
                                                ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.JUMINCD,
                                                ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.JUMINCD)
                            strSQL.AppendFormat(" AND {0}.{1} = {2}.{3}",
                                                ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.GYOMUCD,
                                                ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.GYOMUCD)
                            strSQL.AppendFormat(" AND {0}.{1} = {2}.{3}",
                                                ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.GYOMUNAISHU_CD,
                                                ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.GYOMUNAISHU_CD)
                            strSQL.AppendFormat(" AND {0}.{1} = {2}.{3}",
                                                ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.TOROKURENBAN,
                                                ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.TOROKURENBAN)

                            ' WHERE•¶Œ‹‡
                            strSQL.AppendFormat(" WHERE {0}.{1} = {2}",
                                                ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.JUMINCD, ABRenrakusakiFZYHyojunEntity.KEY_JUMINCD)
                            strSQL.AppendFormat(" AND {0}.{1} = {2}",
                                                ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.GYOMUCD, ABRenrakusakiFZYHyojunEntity.KEY_GYOMUCD)
                            strSQL.AppendFormat(" AND {0}.{1} = {2}",
                                                ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.GYOMUNAISHU_CD, ABRenrakusakiFZYHyojunEntity.KEY_GYOMUNAISHU_CD)
                            strSQL.AppendFormat(" AND {0}.{1} <= {2}",
                                                ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKI_STYMD, ABRenrakusakiFZYHyojunEntity.KEY_RENRAKUSAKI_STYMD)
                            strSQL.AppendFormat(" AND {0}.{1} >= {2}",
                                                ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKI_EDYMD, ABRenrakusakiFZYHyojunEntity.KEY_RENRAKUSAKI_EDYMD)

                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                            cfUFParameterCollectionClass = New UFParameterCollectionClass()

                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            ' Z–¯ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_JUMINCD
                            cfUFParameterClass.Value = strJuminCD
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ‹Æ–±ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_GYOMUCD
                            cfUFParameterClass.Value = strGyomuCD
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ‹Æ–±“àŽí•ÊƒR[ƒh
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiEntity.KEY_GYOMUNAISHU_CD
                            cfUFParameterClass.Value = strGyomunaiSHUCD
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ˜A—æŠJŽn“ú
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiFZYHyojunEntity.KEY_RENRAKUSAKI_STYMD
                            cfUFParameterClass.Value = strKikanYMD
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ˜A—æI—¹“ú
                            cfUFParameterClass = New UFParameterClass()
                            cfUFParameterClass.ParameterName = ABRenrakusakiFZYHyojunEntity.KEY_RENRAKUSAKI_EDYMD
                            cfUFParameterClass.Value = strKikanYMD
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                        "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" +
                                                        "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")

                            csRenrakusakiEntity = m_csDataSchma_Hyojun.Clone()
                            csRenrakusakiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, csRenrakusakiEntity, ABRenrakusakiEntity.TABLE_NAME, cfUFParameterCollectionClass, False)

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csRenrakusakiEntity

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˜A—æƒ}ƒXƒ^ƒXƒL[ƒ}Žæ“¾_•W€”Å
                    '* 
                    '* \•¶           Public Overloads Function GetRenrakusakiSchemaBHoshu_Hyojun() As DataSet
                    '* 
                    '* ‹@”\@@    @ ˜A—æƒ}ƒXƒ^‚æ‚èƒXƒL[ƒ}‚ðŽæ“¾‚·‚éB
                    '* 
                    '* ˆø”           ‚È‚µ
                    '* 
                    '* –ß‚è’l         DataSet : Žæ“¾‚µ‚½‘—•tæƒ}ƒXƒ^‚ÌƒXƒL[ƒ}
                    '************************************************************************************************
                    Public Overloads Function GetRenrakusakiSchemaBHoshu_Hyojun() As DataSet
                        Const THIS_METHOD_NAME As String = "GetRenrakusakiSchemaBHoshu_Hyojun" '‚±‚Ìƒƒ\ƒbƒh–¼
                        Dim csRenrakusakiEntity As DataSet                              '˜A—æƒ}ƒXƒ^ƒf[ƒ^
                        Dim strSQL As New StringBuilder()                               'SQL•¶•¶Žš—ñ

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            If (m_csDataSchma_Hyojun Is Nothing) Then
                                ' SQL•¶‚Ìì¬
                                strSQL.AppendFormat("SELECT {0}.* ", ABRenrakusakiEntity.TABLE_NAME)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI4)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI5)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI6)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI1BIKO)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI2BIKO)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI3BIKO)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI4BIKO)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI5BIKO)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.RENRAKUSAKI6BIKO)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKI_STYMD)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKI_EDYMD)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU1)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU2)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU3)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU4)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU5)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHUBETSU6)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKIYUBINNO)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKIJUSHOCD)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKIJUSHO)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHIKUCHOSONCD)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKIMACHIAZACD)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKTODOFUKEN)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKISHICHOSON)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKIMACHIAZA)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKIBANCHI)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKIKATAGAKI)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.TOROKUYMD)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.GYOSEIKUCD)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.RENRAKUSAKIEDABAN)
                                strSQL.AppendFormat(", {0}.{1}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.BIKO)
                                strSQL.AppendFormat(" FROM {0}", ABRenrakusakiEntity.TABLE_NAME)

                                ' JOIN•¶Œ‹‡
                                strSQL.AppendFormat(" LEFT JOIN {0}", ABRenrakusakiFZYHyojunEntity.TABLE_NAME)
                                strSQL.AppendFormat(" ON {0}.{1} = {2}.{3}",
                                                    ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.JUMINCD,
                                                    ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.JUMINCD)
                                strSQL.AppendFormat(" AND {0}.{1} = {2}.{3}",
                                                    ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.GYOMUCD,
                                                    ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.GYOMUCD)
                                strSQL.AppendFormat(" AND {0}.{1} = {2}.{3}",
                                                    ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.GYOMUNAISHU_CD,
                                                    ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.GYOMUNAISHU_CD)
                                strSQL.AppendFormat(" AND {0}.{1} = {2}.{3}",
                                                    ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.TOROKURENBAN,
                                                    ABRenrakusakiFZYHyojunEntity.TABLE_NAME, ABRenrakusakiFZYHyojunEntity.TOROKURENBAN)
                                strSQL.AppendFormat(" LEFT JOIN {0}", ABRenrakusakiFZYEntity.TABLE_NAME)
                                strSQL.AppendFormat(" ON {0}.{1} = {2}.{3}",
                                                    ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.JUMINCD,
                                                    ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.JUMINCD)
                                strSQL.AppendFormat(" AND {0}.{1} = {2}.{3}",
                                                    ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.GYOMUCD,
                                                    ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.GYOMUCD)
                                strSQL.AppendFormat(" AND {0}.{1} = {2}.{3}",
                                                    ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.GYOMUNAISHU_CD,
                                                    ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.GYOMUNAISHU_CD)
                                strSQL.AppendFormat(" AND {0}.{1} = {2}.{3}",
                                                    ABRenrakusakiEntity.TABLE_NAME, ABRenrakusakiEntity.TOROKURENBAN,
                                                    ABRenrakusakiFZYEntity.TABLE_NAME, ABRenrakusakiFZYEntity.TOROKURENBAN)

                                csRenrakusakiEntity = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString, ABRenrakusakiEntity.TABLE_NAME, False)
                            Else
                                csRenrakusakiEntity = m_csDataSchma_Hyojun.Clone
                            End If

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csRenrakusakiEntity

                    End Function
                    '*—š—ð”Ô† 000006 2023/07/13 ’Ç‰ÁI—¹
                #End Region

                End Class
                 */
            }

            return default;
        }
    }
}