// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‘—•tæ_•W€ƒ}ƒXƒ^‚c‚`(ABSfsk_HyojunBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2023/10/20 ‘è —Y–î
// *
// * ’˜ìŒ           iŠ”j“dŽZ 
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2024/6/11   000001    yAB-9901-1z•s‹ï‡‘Î‰ž
// ************************************************************************************************
using System;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;

namespace Densan.Reams.AB.AB000BB
{

    public class ABSfsk_HyojunBClass
    {
        #region ƒƒ“

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABSfsk_HyojunBClass";
        private const string THIS_BUSINESSID = "AB";                                  // ‹Æ–±ƒR[ƒh
        private const string FORMAT_UPDATETIME = "yyyyMMddHHmmssfff";
        private const string SAKUJOFG_OFF = "0";
        private const string SAKUJOFG_ON = "1";
        public bool m_blnBatch = false;                                            // ƒoƒbƒ`ƒtƒ‰ƒO
        private DataSet m_csDataSchma;                                                // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private DataSet m_csDataSchma_Hyojun;                                         // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg_•W€”Å

        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfLogClass;                                              // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                                        // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;                                // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                                              // ‚q‚c‚aƒNƒ‰ƒX
        private UFErrorClass m_cfErrorClass;                                          // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private UFDateClass m_cfDateClass;                                            // “ú•tƒNƒ‰ƒX
        private string m_strInsertSQL;                                                // INSERT—pSQL
        private string m_strUpdateSQL;                                                // UPDATE—pSQL
        private string m_strDeleteSQL;                                                // DELETE—pSQLi•¨—j
        private string m_strDelRonriSQL;                                              // DELETE—pSQLi˜_—j
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;      // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateUFParameterCollectionClass;      // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDeleteUFParameterCollectionClass;      // DELETE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“i•¨—j
        private UFParameterCollectionClass m_cfDelRonriUFParameterCollectionClass;    // DELETE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“i˜_—j

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
        // *                 cfConfigDataClass As UFConfigDataClass : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg 
        // *                 cfRdbClass As UFRdbClass               : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABSfsk_HyojunBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)
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
        }
        #endregion

        #region ƒƒ\ƒbƒh
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Overloads Function GetSfskBHoshu(ByVal strJuminCD As String) As DataSet
        // * 
        // * ‹@”\@@    @ ‘—•tæƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”           strJuminCD As String  :Z–¯ƒR[ƒh
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½‘—•tæƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *
        // ************************************************************************************************
        public DataSet GetSfskBHoshu(string strJuminCD)
        {

            return GetSfskBHoshu(strJuminCD, string.Empty, string.Empty, string.Empty, false);
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Overloads Function GetSfskBHoshu(ByVal strJuminCD As String, ByVal blnSakujoFG As Boolean) As DataSet
        // * 
        // * ‹@”\@@    @ ‘—•tæƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”           strJuminCD As String    :Z–¯ƒR[ƒh
        // *                blnSakujoFG As Boolean  :íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½‘—•tæƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *
        // ************************************************************************************************
        public DataSet GetSfskBHoshu(string strJuminCD, bool blnSakujoFG)
        {

            return GetSfskBHoshu(strJuminCD, string.Empty, string.Empty, string.Empty, blnSakujoFG);

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Overloads Function GetSfskBHoshu(ByVal strJuminCD As String, _
        // *                                                          ByVal strGyomuCD As String, _
        // *                                                          ByVal strGyomunaiShuCD As String, _
        // *                                                          ByVal strTorokurenban As String) As DataSet
        // * 
        // * ‹@”\           ‘—•tæƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”           strJuminCD As String        :Z–¯ƒR[ƒh
        // *                strGyomuCD As String        :‹Æ–±ƒR[ƒh
        // *                strGyomunaiShuCD As String  :‹Æ–±“àŽí•ÊƒR[ƒh
        // *                strTorokurenban As String   :“o˜^˜A”Ô
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½‘—•tæƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *
        // ************************************************************************************************
        public DataSet GetSfskBHoshu(string strJuminCD, string strGyomuCD, string strGyomunaiShuCD, string strTorokurenban)
        {

            return GetSfskBHoshu(strJuminCD, strGyomuCD, strGyomunaiShuCD, strTorokurenban, true);

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^’Šo(µ°ÊÞ°Û°ÄÞ)
        // * 
        // * \•¶           Public Overloads Function GetSfskBHoshu(ByVal strJuminCD As String, _
        // *                                                          ByVal strGyomuCD As String, _
        // *                                                          ByVal strGyomunaiShuCD As String, _
        // *                                                          ByVal strTorokurenban As String, _
        // *                                                          ByVal blnSakujoFG As Boolean) As DataSet
        // * 
        // * ‹@”\@@    @ ‘—•tæƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”           strJuminCD As String        :Z–¯ƒR[ƒh
        // *                strGyomuCD As String        :‹Æ–±ƒR[ƒh
        // *                strGyomunaiShuCD As String  :‹Æ–±“àŽí•ÊƒR[ƒh
        // *                strTorokurenban As String   :“o˜^˜A”Ô
        // *                blnSakujoFG As Boolean      :íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½‘—•tæƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *
        // ************************************************************************************************
        public DataSet GetSfskBHoshu(string strJuminCD, string strGyomuCD, string strGyomunaiShuCD, string strTorokurenban, bool blnSakujoFG)
        {

            const string THIS_METHOD_NAME = "GetSfskBHoshu";            // ‚±‚Ìƒƒ\ƒbƒh–¼
            DataSet csSfskEntity;                                     // ‘—•tæƒ}ƒXƒ^ƒf[ƒ^
            string strSQL;                                            // SQL•¶•¶Žš—ñ
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
            bool blnSakujo;                                        // íœƒf[ƒ^“Ç‚Ýž‚Ý

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                int intWkKensu;
                intWkKensu = m_cfRdbClass.p_intMaxRows();

                // SQL,ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                blnSakujo = blnSakujoFG;
                cfUFParameterCollectionClass = new UFParameterCollectionClass();
                strSQL = this.CreateSql_Param(strJuminCD, strGyomuCD, strGyomunaiShuCD, true, strTorokurenban, blnSakujo, cfUFParameterCollectionClass);

                // RDBƒAƒNƒZƒXƒƒOo—Í
                if (m_blnBatch == false)
                {
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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11166


                                        Input:
                                        " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                                                    End If

                                                    'SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                         */
                    csSfskEntity = m_csDataSchma.Clone();
                    csSfskEntity = m_cfRdbClass.GetDataSet(strSQL, csSfskEntity, ABSfskHyojunEntity.TABLE_NAME, cfUFParameterCollectionClass, false);


                    m_cfRdbClass.p_intMaxRows = intWkKensu;

                    // ƒfƒoƒbƒOƒƒOo—Í
                    m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12169


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12270


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12813


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csSfskEntity

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‘—•tæ_•W€ƒf[ƒ^ì¬
                    '* 
                    '* \•¶           Public Function CreateSfskHyojunData(ByVal csDataRow As DataRow, ByVal csSfskEntity As DataSet) As DataRow
                    '*                                      
                    '* 
                    '* ‹@”\@@    @ ‘—•tæ_•W€ƒf[ƒ^‚ðì¬‚·‚é

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           csDataRow As DataRow      : ‘—•tæƒf[ƒ^
        // *                csSfskEntity As DataSet   : ‘—•tæƒGƒ“ƒeƒBƒeƒB
        // * 
        // * –ß‚è’l         DataRow
        // ************************************************************************************************
        public DataRow CreateSfskHyojunData(DataRow csDataRow, DataSet csSfskEntity)
        {
            const string THIS_METHOD_NAME = "CreateSfskHyojunData";
            DataRow[] csSfskHyojunRows;
            DataRow csSfskHyojunRow;
            StringBuilder strSelect;                                         // ’ŠoSQL

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ‘—•tæ_•W€‚ÌDateRow‚ðì¬
                csSfskHyojunRow = csSfskEntity.Tables(ABSfskHyojunEntity.TABLE_NAME).NewRow;

                // ƒŒƒR[ƒh‚Ì“Á’è
                strSelect = new StringBuilder();
                strSelect.Append(ABSfskHyojunEntity.GYOMUCD);
                strSelect.Append("='");
                strSelect.Append((string)csDataRow(ABSfskEntity.GYOMUCD));
                strSelect.Append("' AND ");

                strSelect.Append(ABSfskHyojunEntity.GYOMUNAISHU_CD);
                strSelect.Append("='");
                strSelect.Append((string)csDataRow(ABSfskEntity.GYOMUNAISHU_CD));
                strSelect.Append("' AND ");

                strSelect.Append(ABSfskHyojunEntity.TOROKURENBAN);
                strSelect.Append("='");
                strSelect.Append((string)csDataRow(ABSfskEntity.TOROKURENBAN));
                strSelect.Append("'");

                csSfskHyojunRows = csSfskEntity.Tables(ABSfskHyojunEntity.TABLE_NAME).Select(strSelect.ToString());
                csSfskHyojunRow = csSfskHyojunRows[0];

                // ‘—•tæ‚Ìƒf[ƒ^‚ð‘—•tæ_•W€‚É•ÏŠ·
                foreach (DataColumn csDataHyojunColumn in csSfskHyojunRow.Table.Columns)
                {
                    foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                    {
                        if (!(csDataColumn.ColumnName == ABSfskEntity.KOSHINCOUNTER))
                        {
                            // ƒJƒ‰ƒ€–¼‚ªˆê’v‚·‚éƒf[ƒ^‚ð‘ã“ü
                            if (csDataColumn.ColumnName == csDataHyojunColumn.ColumnName)
                            {

                                csSfskHyojunRow(csDataHyojunColumn.ColumnName) = csDataRow(csDataColumn.ColumnName);

                                break;

                            }
                        }
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 16617


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 16713


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 16971


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17054


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw;
            }

            return csSfskHyojunRow;
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertSfskB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @ ‘—•tæƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚éB
        // * 
        // * ˆø”           csDataRow As DataRow  :’Ç‰Áƒf[ƒ^
        // * 
        // * –ß‚è’l         ’Ç‰ÁŒ”(Integer)
        // ************************************************************************************************
        public int InsertSfskB(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "InsertSfskB";                // ‚±‚Ìƒƒ\ƒbƒh–¼
                                                                          // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            int intInsCnt;                                        // ’Ç‰ÁŒ”
            string strUpdateDateTime;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strInsertSQL is null || string.IsNullOrEmpty(m_strInsertSQL) || m_cfInsertUFParameterCollectionClass is null)
                {

                    CreateInsertSQL(csDataRow);

                }

                // XV“úŽž‚ÌŽæ“¾
                strUpdateDateTime = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME);          // ì¬“úŽž

                // ŒÂ•Ê€–Ú•ÒW‚ðs‚¤
                csDataRow(ABSfskHyojunEntity.SFSKTOROKUYMD) = Strings.Left(strUpdateDateTime, 8);         // ‘—•tæ“o˜^”NŒŽ“ú

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABSfskHyojunEntity.TANMATSUID) = m_cfControlData.m_strClientId;  // ’[––‚h‚c
                csDataRow(ABSfskHyojunEntity.SAKUJOFG) = SAKUJOFG_OFF;                     // íœƒtƒ‰ƒO
                csDataRow(ABSfskHyojunEntity.KOSHINCOUNTER) = decimal.Zero;                // XVƒJƒEƒ“ƒ^
                csDataRow(ABSfskHyojunEntity.SAKUSEINICHIJI) = strUpdateDateTime;          // ì¬“úŽž
                csDataRow(ABSfskHyojunEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;   // ì¬ƒ†[ƒU[
                csDataRow(ABSfskHyojunEntity.KOSHINNICHIJI) = strUpdateDateTime;           // XV“úŽž
                csDataRow(ABSfskHyojunEntity.KOSHINUSER) = m_cfControlData.m_strUserId;    // XVƒ†[ƒU[

                // “–ƒNƒ‰ƒX‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¤
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                    // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                    CheckColumnValue(csDataColumn.ColumnName, csDataRow(csDataColumn.ColumnName).ToString.Trim);

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    this.m_cfInsertUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABSfskHyojunEntity.PARAM_PLACEHOLDER.RLength)).ToString();

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 20914


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strInsertSQL, m_cfInsertUFParameterCollectionClass) + "z")

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21685


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21786


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22329


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return intInsCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^XV
                    '* 
                    '* \•¶           Public Function UpdateSfskB(ByVal csDataRow As DataRow) As Integer
                    '* 
                    '* ‹@”\@@    @ ‘—•tæƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           csDataRow As DataRow  :XVƒf[ƒ^
        // * 
        // * –ß‚è’l         XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateSfskB(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "UpdateSfskB";                // ‚±‚Ìƒƒ\ƒbƒh–¼
                                                                          // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            int intUpdCnt;                                        // XVŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strUpdateSQL is null || string.IsNullOrEmpty(m_strUpdateSQL) || m_cfUpdateUFParameterCollectionClass is null)
                {
                    CreateUpdateSQL(csDataRow);
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABSfskHyojunEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                  // ’[––‚h‚c
                csDataRow(ABSfskHyojunEntity.KOSHINCOUNTER) = (decimal)csDataRow(ABSfskHyojunEntity.KOSHINCOUNTER) + 1m;       // XVƒJƒEƒ“ƒ^
                csDataRow(ABSfskHyojunEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME);    // XV“úŽž
                csDataRow(ABSfskHyojunEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                    // XVƒ†[ƒU[

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABSfskHyojunEntity.PREFIX_KEY.RLength) == ABSfskHyojunEntity.PREFIX_KEY)
                    {
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABSfskHyojunEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                        CheckColumnValue(cfParam.ParameterName.RSubstring(ABSfskHyojunEntity.PARAM_PLACEHOLDER.RLength), csDataRow(cfParam.ParameterName.RSubstring(ABSfskHyojunEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString.Trim);
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABSfskHyojunEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 26179


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass) + "z")
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 26949


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 27050


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 27593


                Input:
                " + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return intUpdCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^íœi˜_—j
                    '* 
                    '* \•¶           Public Function DeleteSfskB(ByVal csDataRow As DataRow) As Integer
                    '* 
                    '* ‹@”\@@    @ ‘—•tæƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðíœi˜_—j‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           csDataRow As DataRow  :íœƒf[ƒ^
        // * 
        // * –ß‚è’l         íœi˜_—jŒ”(Integer)
        // ************************************************************************************************
        public int DeleteSfskB(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "DeleteSfskBi˜_—j";        // ‚±‚Ìƒƒ\ƒbƒh–¼
                                                                          // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            int intDelCnt;                                        // íœŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strDelRonriSQL is null || string.IsNullOrEmpty(m_strDelRonriSQL) || m_cfDelRonriUFParameterCollectionClass is null)
                {
                    CreateDeleteRonriSQL(csDataRow);
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABSfskHyojunEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                  // ’[––‚h‚c
                csDataRow(ABSfskHyojunEntity.SAKUJOFG) = SAKUJOFG_ON;                                                      // íœƒtƒ‰ƒO
                csDataRow(ABSfskHyojunEntity.KOSHINCOUNTER) = (decimal)csDataRow(ABSfskHyojunEntity.KOSHINCOUNTER) + 1m;       // XVƒJƒEƒ“ƒ^
                csDataRow(ABSfskHyojunEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME);    // XV“úŽž
                csDataRow(ABSfskHyojunEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                    // XVƒ†[ƒU[

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfDelRonriUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABSfskHyojunEntity.PREFIX_KEY.RLength) == ABSfskHyojunEntity.PREFIX_KEY)
                    {
                        this.m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABSfskHyojunEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABSfskHyojunEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31303


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass) + "z")


                                            ' SQL‚ÌŽÀs
                                            intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass)

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 32083


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 32184


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 32728


                Input:
                " + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return intDelCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^íœi•¨—j
                    '* 
                    '* \•¶           Public Overloads Function DeleteSfskB(ByVal csDataRow As DataRow, 
                    '*                                                      ByVal strSakujoKB As String) As Integer
                    '* 
                    '* ‹@”\@@    @ ‘—•tæƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðíœi•¨—j‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           csDataRow As DataRow      :íœƒf[ƒ^
        // *                strSakujoKB As String     :íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         íœi•¨—jŒ”(Integer)
        // ************************************************************************************************
        public int DeleteSfskB(DataRow csDataRow, string strSakujoKB)
        {
            const string THIS_METHOD_NAME = "DeleteSfskBi•¨—j";
            const string SAKUJOKB_D = "D";                    // íœ‹æ•ª
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
                                                          // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            int intDelCnt;                            // íœŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ˆø”‚Ìíœ‹æ•ª‚ðƒ`ƒFƒbƒN
                if ((strSakujoKB ?? "") != SAKUJOKB_D)
                {
                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_DELETE_SAKUJOKB);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                }

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strDeleteSQL is null || string.IsNullOrEmpty(m_strDeleteSQL) || m_cfDeleteUFParameterCollectionClass is null)
                {
                    CreateDeleteButsuriSQL(csDataRow);
                }

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfDeleteUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABSfskHyojunEntity.PREFIX_KEY.RLength) == ABSfskHyojunEntity.PREFIX_KEY)
                    {
                        this.m_cfDeleteUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABSfskHyojunEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfDeleteUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABSfskHyojunEntity.PREFIX_KEY.RLength), DataRowVersion.Current).ToString();
                    }
                }

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36419


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strDeleteSQL, m_cfDeleteUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs
                                            intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDeleteSQL, m_cfDeleteUFParameterCollectionClass)

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37190


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37291


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37835


                Input:
                " + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return intDelCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     Insert—pSQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateInsertSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\           INSERT—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow :
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 38367


                Input:
                 XV‘ÎÛ‚Ìs

                 */
            }

            return default;
        }
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void CreateInsertSQL(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "CreateInsertSQL";
            UFParameterClass cfUFParameterClass;                 // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            StringBuilder strInsertColumn;                       // ’Ç‰ÁSQL•¶€–Ú•¶Žš—ñ
            StringBuilder strInsertParam;                        // ’Ç‰ÁSQL•¶ƒpƒ‰ƒ[ƒ^•¶Žš—ñ

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // INSERT SQL•¶‚Ìì¬
                m_strInsertSQL = "INSERT INTO " + ABSfskHyojunEntity.TABLE_NAME + " ";
                strInsertColumn = new StringBuilder();
                strInsertParam = new StringBuilder();

                // INSERT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfInsertUFParameterCollectionClass = new UFParameterCollectionClass();

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                {
                    cfUFParameterClass = new UFParameterClass();

                    // INSERT SQL•¶‚Ìì¬
                    strInsertColumn.Append(csDataColumn.ColumnName);
                    strInsertColumn.Append(", ");
                    strInsertParam.Append(ABSfskHyojunEntity.PARAM_PLACEHOLDER);
                    strInsertParam.Append(csDataColumn.ColumnName);
                    strInsertParam.Append(", ");

                    // INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    cfUFParameterClass.ParameterName = ABSfskHyojunEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
                    m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass);

                }

                // INSERT SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                m_strInsertSQL += "(" + strInsertColumn.ToString().Trim().Trim(",") + ")" + " VALUES (" + strInsertParam.ToString().Trim().TrimEnd(",") + ")";

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 41189


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 41290


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 41833


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try
                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     Update—pSQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateUpdateSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\           UPDATE—p‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow :
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42334


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
            UFParameterClass cfUFParameterClass;                  // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            var strWhere = new StringBuilder();                           // XVíœSQL•¶Where•¶•¶Žš—ñ

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // XVíœWhere•¶ì¬
                strWhere.Append(" WHERE ");
                strWhere.Append(ABSfskHyojunEntity.JUMINCD);
                strWhere.Append(" = ");
                strWhere.Append(ABSfskHyojunEntity.KEY_JUMINCD);
                strWhere.Append(" AND ");
                strWhere.Append(ABSfskHyojunEntity.GYOMUCD);
                strWhere.Append(" = ");
                strWhere.Append(ABSfskHyojunEntity.KEY_GYOMUCD);
                strWhere.Append(" AND ");
                strWhere.Append(ABSfskHyojunEntity.GYOMUNAISHU_CD);
                strWhere.Append(" = ");
                strWhere.Append(ABSfskHyojunEntity.KEY_GYOMUNAISHU_CD);
                strWhere.Append(" AND ");
                strWhere.Append(ABSfskHyojunEntity.TOROKURENBAN);
                strWhere.Append(" = ");
                strWhere.Append(ABSfskHyojunEntity.KEY_TOROKURENBAN);
                strWhere.Append(" AND ");
                strWhere.Append(ABSfskHyojunEntity.KOSHINCOUNTER);
                strWhere.Append(" = ");
                strWhere.Append(ABSfskHyojunEntity.KEY_KOSHINCOUNTER);

                // UPDATE SQL•¶‚Ìì¬
                m_strUpdateSQL = "UPDATE " + ABSfskHyojunEntity.TABLE_NAME + " SET ";

                // UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfUpdateUFParameterCollectionClass = new UFParameterCollectionClass();

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                {
                    // Z–¯‚b‚cEì¬“úŽžEì¬ƒ†[ƒU‚ÍXV‚µ‚È‚¢
                    if (!(csDataColumn.ColumnName == ABSfskHyojunEntity.JUMINCD) && !(csDataColumn.ColumnName == ABSfskHyojunEntity.SAKUSEIUSER) && !(csDataColumn.ColumnName == ABSfskHyojunEntity.SAKUSEINICHIJI))
                    {
                        cfUFParameterClass = new UFParameterClass();

                        // SQL•¶‚Ìì¬
                        m_strUpdateSQL += csDataColumn.ColumnName + " = " + ABSfskHyojunEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", ";

                        // UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                        cfUFParameterClass.ParameterName = ABSfskHyojunEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
                        m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);
                    }

                }

                // UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                m_strUpdateSQL = m_strUpdateSQL.Trim();
                m_strUpdateSQL = m_strUpdateSQL.Trim(",");

                // UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                m_strUpdateSQL += strWhere.ToString();

                // UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚ÉƒL[î•ñ‚ð’Ç‰Á
                // Z–¯ƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABSfskHyojunEntity.KEY_JUMINCD;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);
                // ‹Æ–±ƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABSfskHyojunEntity.KEY_GYOMUCD;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);
                // ‹Æ–±“àŽí•ÊƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABSfskHyojunEntity.KEY_GYOMUNAISHU_CD;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);
                // “o˜^˜A”Ô
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABSfskHyojunEntity.KEY_TOROKURENBAN;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);
                // XVƒJƒEƒ“ƒ^
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABSfskHyojunEntity.KEY_KOSHINCOUNTER;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 47406


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 47507


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 48050


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try
                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˜_—íœ—pSQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateDeleteRonriSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\           ˜_—DELETE—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateDeleteRonriSQL(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateDeleteRonriSQL"
                        Dim cfUFParameterClass As UFParameterClass                  'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim strDelRonriSQL As New StringBuilder                     '˜_—íœSQL•¶•¶Žš—ñ
                        Dim strWhere As New StringBuilder                           'XVíœSQL•¶Where•¶•¶Žš—ñ

                        Try
                            'ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'XVíœWhere•¶ì¬
                            strWhere.Append(" WHERE ")
                            strWhere.Append(ABSfskHyojunEntity.JUMINCD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskHyojunEntity.KEY_JUMINCD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABSfskHyojunEntity.GYOMUCD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskHyojunEntity.KEY_GYOMUCD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABSfskHyojunEntity.GYOMUNAISHU_CD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskHyojunEntity.KEY_GYOMUNAISHU_CD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABSfskHyojunEntity.TOROKURENBAN)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskHyojunEntity.KEY_TOROKURENBAN)

                            'DELETEi˜_—j SQL•¶‚Ìì¬
                            strDelRonriSQL.Append("UPDATE ")
                            strDelRonriSQL.Append(ABSfskHyojunEntity.TABLE_NAME)
                            strDelRonriSQL.Append(" SET ")
                            strDelRonriSQL.Append(ABSfskHyojunEntity.TANMATSUID)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABSfskHyojunEntity.PARAM_TANMATSUID)
                            strDelRonriSQL.Append(", ")
                            strDelRonriSQL.Append(ABSfskHyojunEntity.SAKUJOFG)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABSfskHyojunEntity.PARAM_SAKUJOFG)
                            strDelRonriSQL.Append(", ")
                            strDelRonriSQL.Append(ABSfskHyojunEntity.KOSHINCOUNTER)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABSfskHyojunEntity.PARAM_KOSHINCOUNTER)
                            strDelRonriSQL.Append(", ")
                            strDelRonriSQL.Append(ABSfskHyojunEntity.KOSHINNICHIJI)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABSfskHyojunEntity.PARAM_KOSHINNICHIJI)
                            strDelRonriSQL.Append(", ")
                            strDelRonriSQL.Append(ABSfskHyojunEntity.KOSHINUSER)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABSfskHyojunEntity.PARAM_KOSHINUSER)
                            strDelRonriSQL.Append(", ")
                            strDelRonriSQL.Append(ABSfskHyojunEntity.RRKNO)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABSfskHyojunEntity.PARAM_RRKNO)
                            strDelRonriSQL.Append(strWhere.ToString)
                            m_strDelRonriSQL = strDelRonriSQL.ToString

                            'DELETEi˜_—j ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDelRonriUFParameterCollectionClass = New UFParameterCollectionClass

                            'DELETEi˜_—j ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            '’[––‚h‚c
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskHyojunEntity.PARAM_TANMATSUID
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            'íœƒtƒ‰ƒO
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskHyojunEntity.PARAM_SAKUJOFG
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            'XVƒJƒEƒ“ƒ^
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskHyojunEntity.PARAM_KOSHINCOUNTER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            'XV“úŽž
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskHyojunEntity.PARAM_KOSHINNICHIJI
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            'XVƒ†[ƒU
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskHyojunEntity.PARAM_KOSHINUSER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            '—š—ð”Ô†
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskHyojunEntity.PARAM_RRKNO
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            'Z–¯ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskHyojunEntity.KEY_JUMINCD
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            '‹Æ–±ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskHyojunEntity.KEY_GYOMUCD
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            '‹Æ–±“àŽí•ÊƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskHyojunEntity.KEY_GYOMUNAISHU_CD
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            '“o˜^˜A”Ô
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskHyojunEntity.KEY_TOROKURENBAN
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

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

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     •¨—íœ—pSQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateDeleteButsuriSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\           •¨—DELETE—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateDeleteButsuriSQL(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateDeleteButsuriSQL"
                        Dim cfUFParameterClass As UFParameterClass                  'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim strDeleteSQL As New StringBuilder                       '•¨—íœSQL•¶•¶Žš—ñ
                        Dim strWhere As New StringBuilder                           'XVíœSQL•¶Where•¶•¶Žš—ñ

                        Try
                            'ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'XVíœWhere•¶ì¬
                            strWhere.Append(" WHERE ")
                            strWhere.Append(ABSfskHyojunEntity.JUMINCD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskHyojunEntity.KEY_JUMINCD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABSfskHyojunEntity.GYOMUCD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskHyojunEntity.KEY_GYOMUCD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABSfskHyojunEntity.GYOMUNAISHU_CD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskHyojunEntity.KEY_GYOMUNAISHU_CD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABSfskHyojunEntity.TOROKURENBAN)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskHyojunEntity.KEY_TOROKURENBAN)

                            'DELETEi•¨—j SQL•¶‚Ìì¬
                            strDeleteSQL.Append("DELETE FROM ")
                            strDeleteSQL.Append(ABSfskHyojunEntity.TABLE_NAME)
                            strDeleteSQL.Append(strWhere.ToString)
                            m_strDeleteSQL = strDeleteSQL.ToString

                            'DELETEi•¨—j ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDeleteUFParameterCollectionClass = New UFParameterCollectionClass

                            'DELETE(•¨—) ƒRƒŒƒNƒVƒ‡ƒ“‚ÉƒL[î•ñ‚ð’Ç‰Á
                            'Z–¯ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskHyojunEntity.KEY_JUMINCD
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            '‹Æ–±ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskHyojunEntity.KEY_GYOMUCD
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            '‹Æ–±“àŽí•ÊƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskHyojunEntity.KEY_GYOMUNAISHU_CD
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            '“o˜^˜A”Ô
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskHyojunEntity.KEY_TOROKURENBAN
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)

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

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                    '* 
                    '* \•¶           Private Sub CheckColumnValue(ByVal strColumnName As String,
                    '*                                             ByVal strValue As String)
                    '* 
                    '* ‹@”\@@       ‘—•tæ_•W€ƒ}ƒXƒ^‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¢‚Ü‚·B
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

                            ' “ú•tƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            If (IsNothing(m_cfDateClass)) Then
                                m_cfDateClass = New UFDateClass(m_cfConfigDataClass)
                                ' “ú•tƒNƒ‰ƒX‚Ì•K—v‚ÈÝ’è‚ðs‚¤
                                m_cfDateClass.p_enDateSeparator = UFDateSeparator.None
                            End If

                            Select Case strColumnName.ToUpper()
                                Case ABSfskHyojunEntity.JUMINCD                               ' Z–¯ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_JUMINCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.GYOMUCD                               ' ‹Æ–±ƒR[ƒh
                                    If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_GYOMUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.GYOMUNAISHU_CD                        ' ‹Æ–±“àŽí•ÊƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_GYOMUNAISHU_CD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.TOROKURENBAN                          ' “o˜^˜A”Ô
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_TOROKURENBAN)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.STYMD                                  ' ŠJŽn”NŒŽ“ú
                                    If (Not (strValue = String.Empty OrElse strValue = "00000000")) Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_STYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If
                                Case ABSfskHyojunEntity.EDYMD                                   ' I—¹”NŒŽ“ú
                                    If (Not (strValue = String.Empty OrElse strValue = "00000000" OrElse strValue = "99999999")) Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_EDYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If
                                Case ABSfskHyojunEntity.RRKNO                                   ' —š—ð”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_RRKNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKKANAKATAGAKI                        ' ‘—•tæ•û‘ƒtƒŠƒKƒi
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKKANAKATAGAKI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKTSUSHO                              ' ‘—•tæŽ–¼_’ÊÌ
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKTSUSHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKKANATSUSHO                           ' ‘—•tæŽ–¼_’ÊÌ_ƒtƒŠƒKƒi
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKKANATSUSHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKSHIMEIYUSENKB                         ' ‘—•tæŽ–¼_—Dæ‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKSHIMEIYUSENKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKEIJISHIMEI                            ' ‘—•tæŽ–¼_ŠO‘l‰pŽš
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKEIJISHIMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKKANJISHIMEI                           ' ‘—•tæŽ–¼_ŠO‘lŠ¿Žš
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKKANJISHIMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKSHINSEISHAMEI                          ' ‘—•tæ\¿ŽÒ–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKSHINSEISHAMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKSHINSEISHAKANKEICD                     ' ‘—•tæ\¿ŽÒŠÖŒWƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKSHINSEISHAKANKEICD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKSHIKUCHOSONCD                          ' ‘—•tæ_Žs‹æ’¬‘ºƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKSHIKUCHOSONCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKMACHIAZACD                             ' ‘—•tæ_’¬ŽšƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKMACHIAZACD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKTODOFUKEN                               ' ‘—•tæ_“s“¹•{Œ§
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKTODOFUKEN)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKSHIKUCHOSON                             ' ‘—•tæ_Žs‹æŒS’¬‘º–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKSHIKUCHOSON)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKMACHIAZA                                ' ‘—•tæ_’¬Žš
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKMACHIAZA)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKBANCHICD1                                ' ‘—•tæ”Ô’nƒR[ƒh‚P
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKBANCHICD1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKBANCHICD2                                 ' ‘—•tæ”Ô’nƒR[ƒh‚Q
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKBANCHICD2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKBANCHICD3                                 ' ‘—•tæ”Ô’nƒR[ƒh‚R
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKBANCHICD3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKKATAGAKICD                                ' ‘—•tæ•û‘ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKKATAGAKICD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKRENRAKUSAKIKB                             ' ˜A—æ‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKRENRAKUSAKIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKKBN                                       ' ‘—•tæ‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKKBN)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SFSKTOROKUYMD                                  ' ‘—•tæ“o˜^”NŒŽ“ú
                                    If (Not strValue = String.Empty) Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SFSKTOROKUYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If
                                Case ABSfskEntity.RESERVE                                               ' ƒŠƒU[ƒu
                                    '‰½‚à‚µ‚È‚¢
                                Case ABSfskEntity.TANMATSUID                                            ' ’[––ID
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_TANMATSUID)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SAKUJOFG                                        ' íœƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SAKUJOFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.KOSHINCOUNTER                                   ' XVƒJƒEƒ“ƒ^
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_KOSHINCOUNTER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SAKUSEINICHIJI                                  ' ì¬“úŽž
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SAKUSEINICHIJI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.SAKUSEIUSER                                     ' ì¬ƒ†[ƒU
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_SAKUSEIUSER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.KOSHINNICHIJI                                   ' XV“úŽž
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_KOSHINNICHIJI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskHyojunEntity.KOSHINUSER                                      ' XVƒ†[ƒU
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKHB_RDBDATATYPE_KOSHINUSER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                            End Select

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

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‚r‚p‚k•¶Eƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ì¬
                    '* 
                    '* \•¶           Private Function CreateSql_Param(ByVal strJuminCD As String, 
                    '*                                                 ByVal strGyomuCD As String, 
                    '*                                                 ByVal strGyomunaiSHUCD As String, 
                    '*                                                 ByVal blnGyomunaiSHUCD As Boolean, 
                    '*                                                 ByVal strTorokurenban As String, 
                    '*                                                 ByVal blnSakujoFG As Boolean,
                    '*                                                 ByVal cfUFParameterCollectionClass As UFParameterCollectionClass)
                    '                                            As String
                    '* 
                    '* ‹@”\@@    @@‚r‚p‚k•¶‹y‚Ñƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚µˆø‚«“n‚·B
                    '* 
                    '* ˆø”           strJuminCD As String          :Z–¯ƒR[ƒh
                    '*                strGyomuCD As String          :‹Æ–±ƒR[ƒh
                    '*                strGyomunaiSHUCD As String    :‹Æ–±“àŽí•ÊƒR[ƒh
                    '*                blnGyomunaiSHUCD As Boolean   :‹Æ–±“àŽí•ÊƒR[ƒh‚Ì—L–³iTrue:—L‚è,False:–³‚µj
                    '*                strTorokurenban As String     :“o˜^”Ô†
                    '*                blnSakujoFG As Boolean        :íœƒf[ƒ^‚Ì—L–³(True:—L‚è,False:–³‚µ)
                    '*                cfUFParameterCollectionClass As UFParameterCollectionClass  :ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
                    '* 
                    '* –ß‚è’l         ‚r‚p‚k•¶(String)
                    '*                ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX(UFParameterCollectionClass)
                    '************************************************************************************************
                    Private Function CreateSql_Param(ByVal strJuminCD As String, ByVal strGyomuCD As String,
                                                     ByVal strGyomunaiSHUCD As String, ByVal blnGyomunaiSHUCD As Boolean,
                                                     ByVal strTorokurenban As String, ByVal blnSakujoFG As Boolean,
                                                     ByVal cfUFParameterCollectionClass As UFParameterCollectionClass) As String
                        Const THIS_METHOD_NAME As String = "CreateSql_Param"            '‚±‚Ìƒƒ\ƒbƒh–¼
                        Dim strSQL As New StringBuilder                                 'SQL•¶•¶Žš—ñ
                        Dim cfUFParameterClass As UFParameterClass                      'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SQL•¶‚Ìì¬
                            strSQL.Append("SELECT * FROM ")
                            strSQL.Append(ABSfskHyojunEntity.TABLE_NAME)

                            If (m_csDataSchma Is Nothing) Then
                                m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString, ABSfskHyojunEntity.TABLE_NAME, False)
                            End If

                            ' WHERE•¶Œ‹‡
                            strSQL.Append(" WHERE ")
                            strSQL.Append(ABSfskEntity.JUMINCD)                 'Z–¯ƒR[ƒh
                            strSQL.Append(" = ")
                            strSQL.Append(ABSfskEntity.KEY_JUMINCD)

                            '‹Æ–±ƒR[ƒh
                            If (Not (strGyomuCD = String.Empty)) Then
                                strSQL.Append(" AND ")
                                strSQL.Append(ABSfskEntity.GYOMUCD)
                                strSQL.Append(" IN(")
                                strSQL.Append(ABSfskEntity.KEY_GYOMUCD)
                                strSQL.Append(",'00')")
                                strSQL.Append(" AND ")
                                strSQL.Append(ABSfskEntity.GYOMUNAISHU_CD)
                                strSQL.Append(" IN(")
                                strSQL.Append(ABSfskEntity.KEY_GYOMUNAISHU_CD)
                                strSQL.Append(" ,'')")
                            End If

                            If (Not (strTorokurenban = String.Empty)) Then
                                strSQL.Append(" AND ")
                                strSQL.Append(ABSfskEntity.TOROKURENBAN)
                                strSQL.Append(" = ")
                                strSQL.Append(ABSfskEntity.KEY_TOROKURENBAN)
                            End If

                            If (Not (blnSakujoFG)) Then
                                strSQL.Append(" AND ")
                                strSQL.Append(ABSfskEntity.SAKUJOFG)            'íœƒtƒ‰ƒO
                                strSQL.Append(" <> ")
                                strSQL.Append(SAKUJOFG_ON)
                            End If

                            'ƒ\[ƒg
                            strSQL.Append(" ORDER BY ")
                            strSQL.Append(ABSfskEntity.GYOMUCD)
                            strSQL.Append(" DESC,")
                            strSQL.Append(ABSfskEntity.GYOMUNAISHU_CD)
                            strSQL.Append(" DESC")

                            'ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            'Z–¯ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_JUMINCD
                            cfUFParameterClass.Value = strJuminCD
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ‹Æ–±ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUCD
                            cfUFParameterClass.Value = strGyomuCD
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ‹Æ–±“àŽí•ÊƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUNAISHU_CD
                            If (blnGyomunaiSHUCD) Then
                                cfUFParameterClass.Value = strGyomunaiSHUCD
                            Else
                                cfUFParameterClass.Value = String.Empty
                            End If
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' “o˜^˜A”Ô
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_TOROKURENBAN
                            cfUFParameterClass.Value = strTorokurenban

                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)

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

                        Return strSQL.ToString

                    End Function

                #End Region

                End Class

                 */
            }
        }
    }
}