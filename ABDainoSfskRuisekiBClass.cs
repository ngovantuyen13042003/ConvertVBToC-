// ************************************************************************************************
// * ‹Æ–±–¼           ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼         ‚`‚a‘ã”[‘—•tæˆÙ“®—ÝÏƒ}ƒXƒ^‚c‚`
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯           2007/08/10
// *
// * ì¬ŽÒ           ”ä‰Ã@Œv¬
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// *  C³—š—ð@ —š—ð”Ô†@@C³“à—e
// * 2010/02/26   000001     ‘—•tæƒf[ƒ^XV‚Ìê‡A‘ã”[‘—•tæ—ÝÏƒ}ƒXƒ^:‘ã”[‹æ•ª‚É¢40£‚ðƒZƒbƒg‚·‚é‚æ‚¤‰üCi”ä‰Ãj
// * 2010/04/16   000002     VS2008‘Î‰ži”ä‰Ãj
// * 2023/10/25   000003    yAB-0840-1z‘—•tæŠÇ—€–Ú’Ç‰ÁiŒ©éj
// * 2023/12/05   000004    yAB-0840-1z‘—•tæŠÇ—€–Ú’Ç‰Á_’Ç‰ÁC³i’‡¼j
// * 2024/03/07   000005    yAB-0900-1zƒAƒhƒŒƒXEƒx[ƒXEƒŒƒWƒXƒgƒŠ‘Î‰ž(‰º‘º)
// * 2024/06/10   000006    yAB-9902-1z•s‹ï‡‘Î‰ž 
// ************************************************************************************************
using System;
using System.Data;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Densan.Reams.AB.AB000BB
{
    // *—š—ð”Ô† 000003 2023/10/25 ’Ç‰ÁI—¹

    // ************************************************************************************************
    // *
    // * ‘ã”[‘—•tæˆÙ“®—ÝÏƒ}ƒXƒ^Žæ“¾AXVŽž‚ÉŽg—p‚·‚éƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
    // *
    // ************************************************************************************************
    public class ABDainoSfskRuisekiBClass
    {

        #region ƒƒ“
        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private string m_strInsertSQL;                        // INSERT—pSQL
        private UFErrorClass m_cfErrorClass;                  // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private UFDateClass m_cfDateClass;                    // “ú•tƒNƒ‰ƒX
        private DataSet m_csDataSchma;                        // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private UFParameterCollectionClass m_cfSelectUFParameterCollectionClass;      // SELECT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;      // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“

        // @ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABDainoSfskRuisekiBClass";            // ƒNƒ‰ƒX–¼
        private const string THIS_BUSINESSID = "AB";                                  // ‹Æ–±ƒR[ƒh
        private const string STRING_D = "D";                                          // ‘ã”[
        private const string string_S = "S";                                          // ‘—•tæ
                                                                                      // *—š—ð”Ô† 000003 2023/10/25 ’Ç‰ÁŠJŽn
        private const string ZENGOKB_ZEN = "1";                                       // ‘OŒã‹æ•ª@‘O
        private const string ZENGOKB_GO = "2";                                        // ‘OŒã‹æ•ª@Œã
        private const string SOUFU_TSUIKA = "S0";                                     // ˆ—‹æ•ª@‘—•t_’Ç‰Á
        private const string SOUFU_SHUSEI = "S1";                                     // ˆ—‹æ•ª@‘—•t_C³
        private const string SOUFU_SAKUJO = "S2";                                     // ˆ—‹æ•ª@‘—•t_íœ
        private const string DAINO_TSUIKA = "D0";                                     // ˆ—‹æ•ª@‘ã”[_’Ç‰Á
        private const string DAINO_SHUSEI = "D1";                                     // ˆ—‹æ•ª@‘ã”[_C³
        private const string DAINO_SAKUJO = "D2";                                     // ˆ—‹æ•ª@‘ã”[_íœ
        private const string SAKUJO_ON = "1";                                         // íœƒtƒ‰ƒO
                                                                                      // *—š—ð”Ô† 000003 2023/10/25 ’Ç‰ÁI—¹
        #endregion

        #region ƒRƒ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfUFControlData As UFControlData, 
        // *                               ByVal cfUFConfigDataClass As UFConfigDataClass, 
        // *                               ByVal cfUFRdbClass As UFRdbClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfUFControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfUFConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfUFRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABDainoSfskRuisekiBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)
        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigDataClass;
            m_cfRdbClass = cfRdbClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(cfConfigDataClass, cfControlData.m_strBusinessId);

            // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
            m_strInsertSQL = string.Empty;
            m_cfSelectUFParameterCollectionClass = (object)null;
            m_cfInsertUFParameterCollectionClass = (object)null;

            // AB‘ã”[‘—•tæ—ÝÏƒ}ƒXƒ^‚ÌƒXƒL[ƒ}Žæ“¾
            m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction("SELECT * FROM " + ABDainoSfskRuisekiEntity.TABLE_NAME, ABDainoSfskRuisekiEntity.TABLE_NAME, false);

        }
        #endregion

        #region ƒƒ\ƒbƒh

        #region ‘ã”
        // Žg—p‚µ‚Ä‚¢‚È‚¢‚ªAì‚Á‚½‚Ì‚ÅŽc‚µ‚Ä‚¨‚­
        // ''''************************************************************************************************
        // ''''* ƒƒ\ƒbƒh–¼     ‘ã”[‘—•tæˆÙ“®—ÝÏƒ}ƒXƒ^’Šo
        // ''''* 
        // ''''* \•¶           Public Overloads Function GetDainoSfsk(ByVal strJuminCD As String) As DataSet
        // ''''* 
        // ''''* ‹@”\@@    @ ‘ã”[‘—•tæˆÙ“®—ÝÏƒ}ƒXƒ^‚æ‚èƒf[ƒ^‚ð’Šo‚·‚é
        // ''''* 
        // ''''* ˆø”           strJuminCD        : Z–¯ƒR[ƒh
        // ''''* 
        // ''''* –ß‚è’l         DataSet : Žæ“¾‚µ‚½‘ã”[‘—•tæˆÙ“®—ÝÏƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ''''************************************************************************************************
        // '''Public Overloads Function GetDainoSfsk(ByVal strJuminCD As String) As DataSet
        // '''    Const THIS_METHOD_NAME As String = "GetDainoSfsk"
        // '''    Dim objErrorStruct As UFErrorStruct                 ' ƒGƒ‰[’è‹`\‘¢‘Ì
        // '''    Dim cfUFParameterClass As UFParameterClass          ' ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
        // '''    Dim csDainoSfskEntity As DataSet                    ' ‘ã”[‘—•tæ—ÝÏDataSet
        // '''    Dim strSQL As StringBuilder
        // '''    Dim strWHERE As StringBuilder

        // '''    Try
        // '''        ' ƒfƒoƒbƒOŠJŽnƒƒOo—Í
        // '''        m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // '''        ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
        // '''        m_cfSelectUFParameterCollectionClass = New UFParameterCollectionClass

        // '''        ' SQL•¶‚Ìì¬
        // '''        strSQL = New StringBuilder
        // '''        strSQL.Append("SELECT * FROM ")
        // '''        strSQL.Append(ABDainoSfskRuisekiEntity.TABLE_NAME)
        // '''        strSQL.Append(" WHERE ")

        // '''        'WHERE‹å‚Ìì¬
        // '''        strWHERE = New StringBuilder
        // '''        'Z–¯ƒR[ƒh
        // '''        If Not (strJuminCD = String.Empty) Then
        // '''            strWHERE.Append(ABDainoSfskRuisekiEntity.JUMINCD)
        // '''            strWHERE.Append(" = ")
        // '''            strWHERE.Append(ABDainoSfskRuisekiEntity.KEY_JUMINCD)
        // '''            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
        // '''            cfUFParameterClass = New UFParameterClass
        // '''            cfUFParameterClass.ParameterName = ABDainoSfskRuisekiEntity.KEY_JUMINCD
        // '''            cfUFParameterClass.Value = strJuminCD
        // '''            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
        // '''            m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass)
        // '''        End If

        // '''        'ORDER‹å‚ðŒ‹‡
        // '''        If (strWHERE.Length <> 0) Then
        // '''            strSQL.Append(strWHERE)
        // '''            strSQL.Append(" ORDER BY ")
        // '''            strSQL.Append(ABDainoSfskRuisekiEntity.SHORINICHIJI)
        // '''            strSQL.Append(" , ")
        // '''            strSQL.Append(ABDainoSfskRuisekiEntity.ZENGOKB)
        // '''        Else
        // '''            strSQL.Append(" ORDER BY ")
        // '''            strSQL.Append(ABDainoSfskRuisekiEntity.JUMINCD)
        // '''            strSQL.Append(", ")
        // '''            strSQL.Append(ABDainoSfskRuisekiEntity.SHORINICHIJI)
        // '''            strSQL.Append(", ")
        // '''            strSQL.Append(ABDainoSfskRuisekiEntity.ZENGOKB)
        // '''        End If

        // '''        ' RDBƒAƒNƒZƒXƒƒOo—Í
        // '''        m_cfLogClass.RdbWrite(m_cfControlData, _
        // '''                                    "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
        // '''                                    "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
        // '''                                    "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
        // '''                                    "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, m_cfSelectUFParameterCollectionClass) + "z")

        // '''        ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
        // '''        csDainoSfskEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, ABDainoSfskRuisekiEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass)


        // '''        ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
        // '''        m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // '''    Catch objAppExp As UFAppException
        // '''        ' ƒ[ƒjƒ“ƒOƒƒOo—Í
        // '''        m_cfLogClass.WarningWrite(m_cfControlData, _
        // '''                                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // '''                                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // '''                                    "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
        // '''                                    "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
        // '''        ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
        // '''        Throw

        // '''    Catch objExp As Exception
        // '''        ' ƒGƒ‰[ƒƒOo—Í
        // '''        m_cfLogClass.ErrorWrite(m_cfControlData, _
        // '''                                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // '''                                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // '''                                    "yƒGƒ‰[“à—e:" + objExp.Message + "z")
        // '''        ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
        // '''        Throw
        // '''    End Try

        // '''    Return csDainoSfskEntity

        // '''End Function
        #endregion

        #region ‘ã”
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[‘—•tæˆÙ“®—ÝÏƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertDainoSfskB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@     @‘ã”[‘—•tæˆÙ“®—ÝÏƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á
        // * 
        // * ˆø”           csDataRow As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertDainoSfskB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "InsertDainoSfskB";
            // * corresponds to VS2008 Start 2010/04/16 000002
            // Dim csInstRow As DataRow
            // Dim csDataColumn As DataColumn
            // * corresponds to VS2008 End 2010/04/16 000002
            int intInsCnt;                            // ’Ç‰ÁŒ”
            string strUpdateDateTime;

            try
            {

                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strInsertSQL is null | string.IsNullOrEmpty(m_strInsertSQL) | m_cfInsertUFParameterCollectionClass is null)
                {
                    CreateSQL(csDataRow);
                }

                // XV“úŽž‚ÌŽæ“¾
                strUpdateDateTime = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");  // ì¬“úŽž

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABDainoSfskRuisekiEntity.TANMATSUID) = m_cfControlData.m_strClientId;  // ’[––‚h‚c
                                                                                                 // csDataRow(ABDainoSfskRuisekiEntity.SAKUJOFG) = "0"                              ' íœƒtƒ‰ƒO
                csDataRow(ABDainoSfskRuisekiEntity.KOSHINCOUNTER) = decimal.Zero;                // XVƒJƒEƒ“ƒ^
                csDataRow(ABDainoSfskRuisekiEntity.SAKUSEINICHIJI) = strUpdateDateTime;          // ì¬“úŽž
                csDataRow(ABDainoSfskRuisekiEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;   // ì¬ƒ†[ƒU[
                csDataRow(ABDainoSfskRuisekiEntity.KOSHINNICHIJI) = strUpdateDateTime;           // XV“úŽž
                csDataRow(ABDainoSfskRuisekiEntity.KOSHINUSER) = m_cfControlData.m_strUserId;    // XVƒ†[ƒU[

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    cfParam.Value = csDataRow(cfParam.ParameterName.RSubstring(ABDainoSfskRuisekiEntity.PARAM_PLACEHOLDER.RLength)).ToString();

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 14382


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strInsertSQL, m_cfInsertUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs
                                            intInsCnt = m_cfRdbClass.ExecuteSQL(m_strInsertSQL, m_cfInsertUFParameterCollectionClass)

                                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
                                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                        Catch objAppExp As UFAppException
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 15157


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 15253


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 15511


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 15594


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw;
            }

            return intInsCnt;

        }
        #endregion

        #region SQL•¶ì¬
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     SQL•¶‚Ìì¬
        // * 
        // * \•¶           Private Sub CreateSQL(ByVal csDataRow As DataRow)
        // * 
        // * ‹@”\@@    @ INSERT‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void CreateSQL(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "CreateSQL";
            UFParameterClass cfUFParameterClass;
            StringBuilder csInsertColumn;                 // INSERT—pƒJƒ‰ƒ€’è‹`
            StringBuilder csInsertParam;                  // INSERT—pƒpƒ‰ƒ[ƒ^’è‹`


            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // INSERT SQL•¶‚Ìì¬
                m_strInsertSQL = "INSERT INTO " + ABDainoSfskRuisekiEntity.TABLE_NAME + " ";
                csInsertColumn = new StringBuilder();
                csInsertParam = new StringBuilder();

                // INSERT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfInsertUFParameterCollectionClass = new UFParameterCollectionClass();


                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                {
                    cfUFParameterClass = new UFParameterClass();

                    // INSERT SQL•¶‚Ìì¬
                    csInsertColumn.Append(csDataColumn.ColumnName);
                    csInsertColumn.Append(", ");

                    csInsertParam.Append(ABDainoSfskRuisekiEntity.PARAM_PLACEHOLDER);
                    csInsertParam.Append(csDataColumn.ColumnName);
                    csInsertParam.Append(", ");

                    // INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    cfUFParameterClass.ParameterName = ABDainoSfskRuisekiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
                    m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass);


                }

                // ÅŒã‚ÌƒJƒ“ƒ}‚ðŽæ‚èœ‚¢‚ÄINSERT•¶‚ðì¬
                m_strInsertSQL += "(" + csInsertColumn.ToString().TrimEnd().TrimEnd(",".ToCharArray()) + ")" + " VALUES (" + csInsertParam.ToString().TrimEnd().TrimEnd(",".ToCharArray()) + ")";

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 19062


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 19158


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 19416


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 19499


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw;
            }

        }
        #endregion

        #region ‘ã”
        // *—š—ð”Ô† 000003 2023/10/25 C³ŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[‘—•tæ—ÝÏƒf[ƒ^ì¬
        // * 
        // * \•¶           Public Function CreateDainoSfskData(ByVal csDataRow As DataRow, _
        // *                                                    ByVal strShoriKB As String) As Integer
        // * 
        // * ‹@”\@@    @ ‘ã”[‘—•tæ—ÝÏƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow      : ‘ã”[‘—•tæƒf[ƒ^
        // *                strShoriKB As String      : ˆ—‹æ•ª
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int CreateDainoSfskData(DataRow csDataRow, string strShoriKB)
        {
            string strShoriNichiji = string.Empty;

            return CreateDainoSfskData(csDataRow, strShoriKB, null, ref strShoriNichiji);

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[‘—•tæ—ÝÏƒf[ƒ^ì¬
        // * 
        // * \•¶           Public Function CreateDainoSfskData(ByVal csDataRow As DataRow, _
        // *                                                    ByVal strShoriKB As String, _
        // ByRef strShoriNichiji As String) As Integer
        // * 
        // * ‹@”\@@    @ ‘ã”[‘—•tæ—ÝÏƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow      : ‘ã”[‘—•tæƒf[ƒ^
        // *                strShoriKB As String      : ˆ—‹æ•ª
        // *                strShoriNichiji As String : ˆ—“úŽž
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int CreateDainoSfskData(DataRow csDataRow, string strShoriKB, ref string strShoriNichiji)
        {

            return CreateDainoSfskData(csDataRow, strShoriKB, null, ref strShoriNichiji);

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[‘—•tæ—ÝÏƒf[ƒ^ì¬
        // * 
        // * \•¶           Public Function CreateDainoSfskData(ByVal csDataRow As DataRow, _
        // *                                                    ByVal strShoriKB As String, _
        // *                                                    ByVal csABSfskHyojunDataRow As DataRow, _
        // *                                                    ByRef strShoriNichiji As String) As Integer
        // * 
        // * ‹@”\@@    @ ‘ã”[‘—•tæ—ÝÏƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow                : ‘ã”[‘—•tæƒf[ƒ^
        // *                strShoriKB As String                : ˆ—‹æ•ª
        // *                csABSfskHyojunDataRow As DataRow    : AB‘—•tæ_•W€ƒf[ƒ^iDataRowŒ`Ž®j
        // *                strShoriNichiji As String           : ˆ—“úŽž
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************

        // Public Function CreateDainoSfskData(ByVal csDataRow As DataRow, ByVal strShoriKB As String) As Integer
        public int CreateDainoSfskData(DataRow csDataRow, string strShoriKB, DataRow csABSfskHyojunDataRow, ref string strShorinichiji)
        {
            // *—š—ð”Ô† 000003 2023/10/25 C³I—¹
            const string THIS_METHOD_NAME = "CreateDainoSfskData";
            DataSet csDataSet;
            DataRow csRuisekiDR;
            DataColumn csDataColumn;
            string strSystemDate;                 // ƒVƒXƒeƒ€“ú•t
            int intInsCnt;
            // Dim csDainoSfskRows() As DataRow
            // Dim csDainoSfskRow As DataRow
            // * corresponds to VS2008 Start 2010/04/16 000002
            // Dim csNewDainosfskRow As DataRow
            // * corresponds to VS2008 End 2010/04/16 000002
            DataRow csOriginalDR;
            // Dim csDainoSfskEntity As DataSet
            int intUpdataCount_zen;
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                strSystemDate = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");
                strShorinichiji = strSystemDate;
                // ƒXƒL[ƒ}‚ðŽæ“¾
                csDataSet = m_csDataSchma.Clone();

                // ***
                // * ‘ã”[‘—•tæ—ÝÏ(‘O)•ÒWˆ—
                // *
                if (strShoriKB != ABConstClass.DAINO_ADD && strShoriKB != ABConstClass.SFSK_ADD)
                {
                    // ˆ—‹æ•ª‚ª’Ç‰ÁˆÈŠO‚Ìê‡
                    if (csDataRow.HasVersion(DataRowVersion.Original))
                    {
                        // C³‘Oî•ñ‚ªŽc‚Á‚Ä‚¢‚éê‡

                        // ‘ã”[‘—•tæ—ÝÏƒf[ƒ^‚ðì¬
                        csOriginalDR = csDataSet.Tables(ABDainoSfskRuisekiEntity.TABLE_NAME).NewRow;

                        foreach (DataColumn currentCsDataColumn in csDataRow.Table.Columns)
                        {
                            csDataColumn = currentCsDataColumn;
                            if (!(csDataColumn.ColumnName == ABDainoEntity.RESERVE) && !(csDataColumn.ColumnName == ABSfskDataEntity.SFSKDATAKB))
                            {
                                csOriginalDR[csDataColumn.ColumnName] = csDataRow[csDataColumn.ColumnName, DataRowVersion.Original];
                            }
                        }

                        csOriginalDR(ABDainoSfskRuisekiEntity.SHORINICHIJI) = strSystemDate;
                        csOriginalDR(ABDainoSfskRuisekiEntity.SHORIKB) = strShoriKB;               // ˆ—‹æ•ª
                        csOriginalDR(ABDainoSfskRuisekiEntity.ZENGOKB) = "1";                      // ‘OŒã‹æ•ª

                        // *—š—ð”Ô† 000001 2010/02/26 C³ŠJŽn
                        // -- ƒRƒƒ“ƒgC³ --
                        // '''' ‘—•tæƒf[ƒ^‚Ìê‡A‘—•tæ‹æ•ª‚ð‘ã”[‹æ•ª‚ÉƒZƒbƒg‚·‚é
                        // ‘—•tæƒf[ƒ^‚Ìê‡A‘ã”[‹æ•ª‚É¢40£‚ðƒZƒbƒg‚·‚éB‘—•tæƒf[ƒ^‚Í¢40£ŒÅ’è‚Ì‚½‚ßB
                        // -- ƒRƒƒ“ƒgC³ --
                        if (strShoriKB.RSubstring(0, 1) == "S")
                        {
                            // csOriginalDR(ABDainoSfskRuisekiEntity.DAINOKB) = csDataRow(ABSfskEntity.SFSKDATAKB)
                            csOriginalDR(ABDainoSfskRuisekiEntity.DAINOKB) = "40";

                            // *—š—ð”Ô† 000003 2023/10/25 ’Ç‰ÁŠJŽn
                            if (!(csABSfskHyojunDataRow == null) && csABSfskHyojunDataRow.HasVersion(DataRowVersion.Original))
                            {
                                // ‘—•tæ_•W€‚ªNothingˆÈŠO‚Å‚©‚ÂAC³‘Oî•ñ‚ªŽc‚Á‚Ä‚¢‚éê‡
                                // ‘—•tæ”Ô’nƒR[ƒh‚P
                                csOriginalDR(ABDainoSfskRuisekiEntity.SFSKBANCHICD1) = csABSfskHyojunDataRow(ABSfskHyojunEntity.SFSKBANCHICD1, DataRowVersion.Original);
                                // ‘—•tæ”Ô’nƒR[ƒh‚Q
                                csOriginalDR(ABDainoSfskRuisekiEntity.SFSKBANCHICD2) = csABSfskHyojunDataRow(ABSfskHyojunEntity.SFSKBANCHICD2, DataRowVersion.Original);
                                // ‘—•tæ”Ô’nƒR[ƒh‚R
                                csOriginalDR(ABDainoSfskRuisekiEntity.SFSKBANCHICD3) = csABSfskHyojunDataRow(ABSfskHyojunEntity.SFSKBANCHICD3, DataRowVersion.Original);
                                // ‘—•tæ•û‘ƒR[ƒh
                                csOriginalDR(ABDainoSfskRuisekiEntity.SFSKKATAGAKICD) = csABSfskHyojunDataRow(ABSfskHyojunEntity.SFSKKATAGAKICD, DataRowVersion.Original);
                            }
                        }
                        // *—š—ð”Ô† 000003 2023/10/25 ’Ç‰ÁI—¹

                        else
                        {
                        }
                        // *—š—ð”Ô† 000001 2010/02/26 C³I—¹

                        // ƒf[ƒ^ƒZƒbƒg‚ÉC³‘Oî•ñ‚ð’Ç‰Á
                        csDataSet.Tables(ABDainoSfskRuisekiEntity.TABLE_NAME).Rows.Add(csOriginalDR);

                        // ‘ã”[‘—•tæ—ÝÏ(‘O)ƒ}ƒXƒ^’Ç‰Áˆ—
                        intUpdataCount_zen = this.InsertDainoSfskB(csDataSet.Tables(ABDainoSfskRuisekiEntity.TABLE_NAME).Rows(0));

                        // XVŒ”‚ª‚PŒˆÈŠO‚Ìê‡AƒGƒ‰[‚ð”­¶‚³‚¹‚é
                        if (!(intUpdataCount_zen == 1))
                        {
                            m_cfErrorClass = new UFErrorClass(m_cfControlData.m_strBusinessId);
                            // ƒGƒ‰[’è‹`‚ðŽæ“¾iŠù‚É“¯ˆêƒf[ƒ^‚ª‘¶Ý‚µ‚Ü‚·BF‘ã”[‘—•tæ—ÝÏj
                            objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001044);
                            throw new UFAppException(objErrorStruct.m_strErrorMessage + "‘ã");
                        }

                        // ƒf[ƒ^ƒZƒbƒg‚ÌƒNƒŠƒA
                        csDataSet.Clear();
                    }
                    else
                    {

                    }
                }
                else
                {

                }


                // ***
                // * ‘ã”[‘—•tæ—ÝÏ(Œã)•ÒWˆ—
                // *
                // ‘ã”[‘—•tæ—ÝÏƒf[ƒ^‚ðì¬
                csRuisekiDR = csDataSet.Tables(ABDainoSfskRuisekiEntity.TABLE_NAME).NewRow;

                foreach (DataColumn currentCsDataColumn1 in csDataRow.Table.Columns)
                {
                    csDataColumn = currentCsDataColumn1;
                    if (!(csDataColumn.ColumnName == ABDainoEntity.RESERVE) && !(csDataColumn.ColumnName == ABSfskDataEntity.SFSKDATAKB))
                    {
                        csRuisekiDR[csDataColumn.ColumnName] = csDataRow[csDataColumn.ColumnName];
                    }
                }

                // ‹¤’Ê€–Ú‚Ìƒf[ƒ^ƒZƒbƒg
                csRuisekiDR(ABDainoSfskRuisekiEntity.SHORINICHIJI) = strSystemDate;              // ˆ—“úŽž
                csRuisekiDR(ABDainoSfskRuisekiEntity.SHORIKB) = strShoriKB;                      // ˆ—‹æ•ª
                csRuisekiDR(ABDainoSfskRuisekiEntity.ZENGOKB) = "2";                             // ‘OŒã‹æ•ª
                csRuisekiDR(ABDainoSfskRuisekiEntity.RESERVE1) = string.Empty;                   // ƒŠƒU[ƒu1
                csRuisekiDR(ABDainoSfskRuisekiEntity.RESERVE2) = string.Empty;                   // ƒŠƒU[ƒu2

                // *—š—ð”Ô† 000003 2023/10/25 ’Ç‰ÁŠJŽn
                // ‘ã”[A‘—•tæ‚Ìˆ—‹æ•ª‚ªíœ‚Ìê‡Aíœƒtƒ‰ƒO‚ð—§‚Ä‚é
                if (strShoriKB == ABConstClass.DAINO_DELETE || strShoriKB == ABConstClass.SFSK_DELETE)
                {
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SAKUJOFG) = SAKUJO_ON;                  // íœƒtƒ‰ƒO

                }
                // *—š—ð”Ô† 000003 2023/10/25 ’Ç‰ÁI—¹

                // ‘ã”[ƒf[ƒ^A‘—•tæƒf[ƒ^•Êˆ—‚Ìê‡
                // If (CStr(csDataRow(ABDainoSfskRuisekiEntity.DAINOKB)) <> "40") Then
                if (strShoriKB.RSubstring(0, 1) == "D")
                {
                    // ‘ã”[ƒf[ƒ^‚Ìê‡
                    // ‘ã”[‹æ•ª‚ª"40"ˆÈŠO‚Ìê‡
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKKANNAIKANGAIKB) = string.Empty;     // ‘—•tæŠÇ“àŠÇŠO‹æ•ª
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKKANAMEISHO) = string.Empty;         // ‘—•tæƒJƒi–¼Ì
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKKANJIMEISHO) = string.Empty;        // ‘—•tæŠ¿Žš–¼Ì
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKYUBINNO) = string.Empty;            // ‘—•tæ—X•Ö”Ô†
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKZJUSHOCD) = string.Empty;           // ‘—•tæZŠƒR[ƒh
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKJUSHO) = string.Empty;              // ‘—•tæZŠ
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKBANCHICD1) = string.Empty;          // ‘—•tæ”Ô’nƒR[ƒh1
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKBANCHICD2) = string.Empty;          // ‘—•tæ”Ô’nƒR[ƒh2
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKBANCHICD3) = string.Empty;          // ‘—•tæ”Ô’nƒR[ƒh3
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKBANCHI) = string.Empty;             // ‘—•tæ”Ô’n
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKKATAGAKICD) = string.Empty;         // ‘—•tæ•û‘ƒR[ƒh
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKKATAGAKI) = string.Empty;           // ‘—•tæ•û‘
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKRENRAKUSAKI1) = string.Empty;       // ‘—•tæ˜A—æ1
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKRENRAKUSAKI2) = string.Empty;       // ‘—•tæ˜A—æ2
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKGYOSEIKUCD) = string.Empty;         // ‘—•tæs­‹æƒR[ƒh
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKGYOSEIKUMEI) = string.Empty;        // ‘—•tæs­‹æ–¼
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKCHIKUCD1) = string.Empty;           // ‘—•tæ’n‹æƒR[ƒh1
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKCHIKUMEI1) = string.Empty;          // ‘—•tæ’n‹æ–¼1
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKCHIKUCD2) = string.Empty;           // ‘—•tæ’n‹æƒR[ƒh2
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKCHIKUMEI2) = string.Empty;          // ‘—•tæ’n‹æ–¼2
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKCHIKUCD3) = string.Empty;           // ‘—•tæ’n‹æƒR[ƒh3
                    csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKCHIKUMEI3) = string.Empty;          // ‘—•tæ’n‹æ–¼3
                }
                else
                {
                    // ‘—•tæƒf[ƒ^‚Ìê‡
                    // ‘ã”[‹æ•ª‚ª"40"‚Ìê‡
                    // *—š—ð”Ô† 000001 2010/02/26 C³ŠJŽn
                    // **ƒRƒƒ“ƒg F ‘—•tæƒf[ƒ^‚Ìê‡A‘ã”[‹æ•ª‚É¢40£‚ðƒZƒbƒgB‘—•tæƒf[ƒ^‚Í¢40£ŒÅ’è‚Ì‚½‚ßB
                    // csRuisekiDR(ABDainoSfskRuisekiEntity.DAINOKB) = csDataRow(ABSfskEntity.SFSKDATAKB)
                    csRuisekiDR(ABDainoSfskRuisekiEntity.DAINOKB) = "40";
                    // *—š—ð”Ô† 000001 2010/02/26 C³I—¹
                    // *—š—ð”Ô† 000003 2023/10/25 C³ŠJŽn
                    // csRuisekiDR(ABDainoSfskRuisekiEntity.DAINOJUMINCD) = String.Empty
                    // csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKBANCHICD1) = String.Empty          ' ‘—•tæ”Ô’nƒR[ƒh1
                    // csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKBANCHICD2) = String.Empty          ' ‘—•tæ”Ô’nƒR[ƒh2
                    // csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKBANCHICD3) = String.Empty          ' ‘—•tæ”Ô’nƒR[ƒh3
                    // csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKKATAGAKICD) = String.Empty         ' ‘—•tæ•û‘ƒR[ƒh
                    if (!(csABSfskHyojunDataRow == null))
                    {
                        // ‘—•tæ_•W€‚ªNothingˆÈŠO‚Ìê‡
                        // ‘—•tæ”Ô’nƒR[ƒh‚P
                        csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKBANCHICD1) = csABSfskHyojunDataRow(ABSfskHyojunEntity.SFSKBANCHICD1);
                        // ‘—•tæ”Ô’nƒR[ƒh‚Q
                        csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKBANCHICD2) = csABSfskHyojunDataRow(ABSfskHyojunEntity.SFSKBANCHICD2);
                        // ‘—•tæ”Ô’nƒR[ƒh‚R
                        csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKBANCHICD3) = csABSfskHyojunDataRow(ABSfskHyojunEntity.SFSKBANCHICD3);
                        // ‘—•tæ•û‘ƒR[ƒh
                        csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKKATAGAKICD) = csABSfskHyojunDataRow(ABSfskHyojunEntity.SFSKKATAGAKICD);
                    }
                    else
                    {
                        csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKBANCHICD1) = string.Empty;          // ‘—•tæ”Ô’nƒR[ƒh1
                        csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKBANCHICD2) = string.Empty;          // ‘—•tæ”Ô’nƒR[ƒh2
                        csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKBANCHICD3) = string.Empty;          // ‘—•tæ”Ô’nƒR[ƒh3
                        csRuisekiDR(ABDainoSfskRuisekiEntity.SFSKKATAGAKICD) = string.Empty;

                    }         // ‘—•tæ•û‘ƒR[ƒh
                              // *—š—ð”Ô† 000003 2023/10/25 C³I—¹
                }

                csDataSet.Tables(ABDainoSfskRuisekiEntity.TABLE_NAME).Rows.Add(csRuisekiDR);

                // ***
                // * ‘ã”[‘—•tæ—ÝÏ(Œã)ƒ}ƒXƒ^’Ç‰Áˆ—
                // *
                intInsCnt = InsertDainoSfskB(csDataSet.Tables(ABDainoSfskRuisekiEntity.TABLE_NAME).Rows(0));

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36832


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36928


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37186


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37269


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw;
            }

            return intInsCnt;

        }
        #endregion

        // *—š—ð”Ô† 000003 2023/10/25 ’Ç‰ÁŠJŽn
        #region ‘ã”
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[‘—•tæ—ÝÏƒf[ƒ^’Šo
        // * 
        // * \•¶           PPublic Function GetABDainoSfskRuisekiData(ByVal strJuminCD As String,
        // *                                                           ByVal strGyomuCD As String,
        // *                                                           ByVal strGyomuNaiShubetsuCD As String,
        // *                                                           ByVal intTorokuRenban As Integer,
        // *                                                           ByVal strShoriKB As String) As DataRow()
        // * 
        // * ‹@”\@@    @ ‘ã”[‘—•tæ—ÝÏƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD             : Z–¯ƒR[ƒh 
        // *                strGyomuCD             : ‹Æ–±ƒR[ƒh
        // *                strGyomuNaiShubetsuCD  : ‹Æ–±“àŽí•ÊƒR[ƒh
        // *                intTorokuRenban        : “o˜^”Ô†
        // *                strShoriKB             : ˆ—‹æ•ª@"D"F‘ã”[A"S"F‘—•t
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½‘ã”[‘—•tæ—ÝÏƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^(DataRow())
        // ************************************************************************************************
        public DataRow[] GetABDainoSfskRuisekiData(string strJuminCD, string strGyomuCD, string strGyomuNaiShubetsuCD, int intTorokuRenban, string strShoriKB)
        {

            const string THIS_METHOD_NAME = "GetABDainoSfskRuisekiData";
            DataSet csDainoSfskRuisekiEntity;
            DataRow[] csReturnDataRows;
            var strSQL = new StringBuilder();

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SELECT‹å‚Ì¶¬
                strSQL.Append(CreateSelect());
                // FROM‹å‚Ì¶¬
                strSQL.AppendFormat(" FROM {0} ", ABDainoSfskRuisekiEntity.TABLE_NAME);
                // ÃÞ°À½·°Ï‚ÌŽæ“¾
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABDainoSfskRuisekiEntity.TABLE_NAME, false);
                }

                // WHERE‹å‚Ìì¬
                strSQL.Append(CreateWhere(strJuminCD, strGyomuCD, strGyomuNaiShubetsuCD, intTorokuRenban.ToString(), strShoriKB, THIS_METHOD_NAME));

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40732


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(
                                                                            strSQL.ToString(), m_cfSelectUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csDainoSfskRuisekiEntity = m_csDataSchma.Clone();
                csDainoSfskRuisekiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csDainoSfskRuisekiEntity, ABDainoSfskRuisekiEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);
                // –ß‚è’l—p‚Éƒf[ƒ^‚ðŠi”[
                strSQL.Clear();
                strSQL.Append(ABDainoSfskRuisekiEntity.JUMINCD);
                strSQL.Append(" = '");
                strSQL.Append(strJuminCD);
                strSQL.Append("'");
                csReturnDataRows = csDainoSfskRuisekiEntity.Tables(ABDainoSfskRuisekiEntity.TABLE_NAME).Select(strSQL.ToString());

                // ƒfƒoƒbƒOƒƒOo—Í
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42189


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42285


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42553


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42636


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csReturnDataRows;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     SELECT‹å‚Ìì¬
        // * 
        // * \•¶           Private Sub CreateSelect() As String
        // * 
        // * ‹@”\           SELECT‹å‚ð¶¬‚·‚é
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         String    :   SELECT‹å
        // ************************************************************************************************
        private string CreateSelect()
        {
            const string THIS_METHOD_NAME = "CreateSelect";
            var strSELECT = new StringBuilder();

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SELECT‹å‚Ìì¬
                strSELECT.AppendFormat("SELECT {0}", ABDainoSfskRuisekiEntity.JUMINCD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SHICHOSONCD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.KYUSHICHOSONCD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SHORINICHIJI);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SHORIKB);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.ZENGOKB);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.GYOMUCD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.GYOMUNAISHU_CD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.TOROKURENBAN);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.STYMD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.EDYMD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.RRKNO);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.DAINOKB);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.DAINOJUMINCD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKKANNAIKANGAIKB);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKKANAMEISHO);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKKANJIMEISHO);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKYUBINNO);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKZJUSHOCD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKJUSHO);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKBANCHICD1);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKBANCHICD2);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKBANCHICD3);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKBANCHI);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKKATAGAKICD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKKATAGAKI);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKRENRAKUSAKI1);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKRENRAKUSAKI2);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKGYOSEIKUCD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKGYOSEIKUMEI);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKCHIKUCD1);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKCHIKUMEI1);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKCHIKUCD2);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKCHIKUMEI2);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKCHIKUCD3);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SFSKCHIKUMEI3);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.RESERVE1);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.RESERVE2);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.TANMATSUID);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SAKUJOFG);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.KOSHINCOUNTER);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SAKUSEINICHIJI);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.SAKUSEIUSER);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.KOSHINNICHIJI);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiEntity.KOSHINUSER);

                // ƒfƒoƒbƒOƒƒOo—Í
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 48034


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 48130


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 48398


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 48481


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return strSELECT.ToString();

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     WHERE•¶‚Ìì¬
        // * 
        // * \•¶           Private Function CreateWhere(ByVal strJuminCD As String,
        // *                                             ByVal strGyomuCD As String,
        // *                                             ByVal strGyomuNaiShubetsuCD As String,
        // *                                             ByVal strTorokuRenban As String,
        // *                                             ByVal strShoriKB As String,
        // *                                             ByVal strMethodName As String) As String
        // * 
        // * ‹@”\@@    @ WHERE•ª‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”           strJuminCD             : Z–¯ƒR[ƒh 
        // *                strGyomuCD             : ‹Æ–±ƒR[ƒh
        // *                strGyomuNaiShubetsuCD  : ‹Æ–±“àŽí•ÊƒR[ƒh
        // *                strTorokuRenban        : “o˜^˜A”Ô
        // *                strShoriKB             : ˆ—‹æ•ª@"D"F‘ã”[A"S"F‘—•t
        // *                strMethodName          : ŒÄo‚µŒ³ŠÖ”–¼
        // *
        // * –ß‚è’l         String    :   WHERE‹å
        // ************************************************************************************************
        private string CreateWhere(string strJuminCD, string strGyomuCD, string strGyomuNaiShubetsuCD, string strTorokuRenban, string strShoriKB, string strMethodName)
        {

            const string THIS_METHOD_NAME = "CreateWhere";
            const string GET_MAX_TOROKURENBAN = "GetMaxTorokuRenban";

            StringBuilder strWHERE;
            UFParameterClass cfUFParameterClass;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SELECTƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfSelectUFParameterCollectionClass = new UFParameterCollectionClass();

                // WHERE‹å‚Ìì¬
                strWHERE = new StringBuilder(256);

                // Z–¯ƒR[ƒh
                strWHERE.AppendFormat("WHERE {0} = {1}", ABDainoSfskRuisekiEntity.JUMINCD, ABDainoSfskRuisekiEntity.KEY_JUMINCD);
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABDainoSfskRuisekiEntity.KEY_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);

                // ‹Æ–±ƒR[ƒh
                strWHERE.AppendFormat(" AND {0} = {1}", ABDainoSfskRuisekiEntity.GYOMUCD, ABDainoSfskRuisekiEntity.KEY_GYOMUCD);
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABDainoSfskRuisekiEntity.KEY_GYOMUCD;
                cfUFParameterClass.Value = strGyomuCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);

                // ‹Æ–±“àŽí•ÊƒR[ƒh
                strWHERE.AppendFormat(" AND {0} = {1}", ABDainoSfskRuisekiEntity.GYOMUNAISHU_CD, ABDainoSfskRuisekiEntity.KEY_GYOMUNAISHU_CD);
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABDainoSfskRuisekiEntity.KEY_GYOMUNAISHU_CD;
                cfUFParameterClass.Value = strGyomuNaiShubetsuCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);

                // “o˜^˜A”Ô
                if (!string.IsNullOrEmpty(strTorokuRenban))
                {
                    strWHERE.AppendFormat(" AND {0} = {1}", ABDainoSfskRuisekiEntity.TOROKURENBAN, ABDainoSfskRuisekiEntity.KEY_TOROKURENBAN);
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABDainoSfskRuisekiEntity.KEY_TOROKURENBAN;
                    cfUFParameterClass.Value = strTorokuRenban;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);
                }

                // ˆ—‹æ•ª
                switch (strShoriKB ?? "")
                {
                    case string_S:
                        {
                            // ‘—•t
                            strWHERE.AppendFormat(" AND {0} IN ('{1}','{2}','{3}')", ABDainoSfskRuisekiEntity.SHORIKB, ABConstClass.SFSK_ADD, ABConstClass.SFSK_SHUSEI, ABConstClass.SFSK_DELETE);
                            break;
                        }

                    case STRING_D:
                        {
                            // ‘ã”[
                            // *—š—ð”Ô† 000004 2023/12/05 C³ŠJŽn
                            // strWHERE.AppendFormat(" AND {0} IN ('{1}','{2}','{3}')", ABDainoSfskRuisekiEntity.SHORIKB,
                            // ABConstClass.DAINO_ADD, ABConstClass.DAINO_SHUSEI, ABConstClass.DAINO_SHUSEI)
                            strWHERE.AppendFormat(" AND {0} IN ('{1}','{2}','{3}')", ABDainoSfskRuisekiEntity.SHORIKB, ABConstClass.DAINO_ADD, ABConstClass.DAINO_SHUSEI, ABConstClass.DAINO_DELETE);
                            break;
                        }
                        // *—š—ð”Ô† 000004 2023/12/05 C³I—¹

                }

                // ‘OŒã‹æ•ª
                strWHERE.AppendFormat(" AND {0} = '{1}'", ABDainoSfskRuisekiEntity.ZENGOKB, ZENGOKB_GO);

                // —š—ð”Ô†@~”Ô‚Åƒ\[ƒg@
                if ((strMethodName ?? "") != GET_MAX_TOROKURENBAN)
                {
                    strWHERE.AppendFormat(" ORDER BY {0} DESC", ABDainoSfskRuisekiEntity.RRKNO);
                }


                // ƒfƒoƒbƒOƒƒOo—Í
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 55512


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 55608


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 55876


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 55959


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return strWHERE.ToString();

        }
        #endregion

        #region “
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     “o˜^˜A”ÔÅ‘å’lŽæ“¾ˆ—
        // * 
        // * \•¶           Public Function GetMaxTorokuRenban(ByVal strJuminCD As String,
        // *                                                    ByVal strGyomuCD As String,
        // *                                                    ByVal strGyomuNaiShubetsuCD As String,
        // *                                                    ByVal strShoriKB As String) As Integer
        // * 
        // * ‹@”\@@    @ ‘ã”[‘—•tæ—ÝÏƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD             : Z–¯ƒR[ƒh 
        // *                strGyomuCD             : ‹Æ–±ƒR[ƒh
        // *                strGyomuNaiShubetsuCD  : ‹Æ–±“àŽí•ÊƒR[ƒh
        // *                strShoriKB             : ˆ—‹æ•ª@"D"F‘ã”[A"S"F‘—•t
        // * 
        // * –ß‚è’l         Integer : Žæ“¾‚µ‚½“o˜^˜A”Ô‚ÌÅ‘å
        // ************************************************************************************************
        public int GetMaxTorokuRenban(string strJuminCD, string strGyomuCD, string strGyomuNaiShubetsuCD, string strShoriKB)
        {

            const string THIS_METHOD_NAME = "GetMaxTorokuRenban";
            DataSet csDainoSfskRuisekiEntity;
            int intMaxTorokuRenban = 0;
            var strSQL = new StringBuilder();

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SELECT‹å‚Ì¶¬
                strSQL.AppendFormat("SELECT MAX({0}) AS MAXTOROKURENBAN ", ABDainoSfskRuisekiEntity.TOROKURENBAN);
                // FROM‹å‚Ì¶¬
                strSQL.AppendFormat(" FROM {0} ", ABDainoSfskRuisekiEntity.TABLE_NAME);
                // ÃÞ°À½·°Ï‚ÌŽæ“¾
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABDainoSfskRuisekiEntity.TABLE_NAME, false);
                }

                // WHERE‹å‚Ìì¬
                strSQL.Append(CreateWhere(strJuminCD, strGyomuCD, strGyomuNaiShubetsuCD, string.Empty, strShoriKB, THIS_METHOD_NAME));

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 59080


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(
                                                                            strSQL.ToString(), m_cfSelectUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csDainoSfskRuisekiEntity = m_csDataSchma.Clone();
                csDainoSfskRuisekiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csDainoSfskRuisekiEntity, default, m_cfSelectUFParameterCollectionClass, false);

                if (0 < csDainoSfskRuisekiEntity.Tables(ABDainoSfskRuisekiEntity.TABLE_NAME).Rows.Count)
                {
                    // ƒf[ƒ^‚ª‚ ‚éê‡‚Í–ß‚è’l‚ÉŠi”[‚·‚é
                    if (Information.IsNumeric(csDainoSfskRuisekiEntity.Tables[0].Rows[0][0]))
                    {
                        intMaxTorokuRenban = Conversions.ToInteger(csDainoSfskRuisekiEntity.Tables[0].Rows[0][0]);
                    }
                    else
                    {
                        // ƒf[ƒ^‚ª–³‚¢ê‡‚Í0‚ð–ß‚è’l‚ÉƒZƒbƒg
                        intMaxTorokuRenban = 0;
                    }

                }
                // ƒfƒoƒbƒOƒƒOo—Í
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 60706


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 60802


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 61070


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 61153


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intMaxTorokuRenban;

        }
        #endregion


        #region ‘ã”

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[‘—•tæ—ÝÏ‚Æ”õl‚Ìƒf[ƒ^‚ðƒGƒ“ƒeƒBƒeƒB‚ÉŠi”[‚·‚é
        // * 
        // * \•¶        Public Function SetDainoSfsfRirekiData(ByVal csDainoSfskRuisekiDataset As DataSet,
        // *                                                    ByVal strShoriKB As String) As DataSet
        // * 
        // * ‹@”\@@    @ ‘ã”[‘—•tæ—ÝÏƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŠi”[‚·‚é
        // * 
        // * ˆø”           csDainoSfskRuisekiDataset As DataSet   F‘ã”[‘—•tæ—ÝÏƒf[ƒ^ƒZƒbƒg
        // *                strShoriKB As String                   Fˆ—‹æ•ª@"D"F‘ã”[A"S"F‘—•tæ
        // * 
        // * –ß‚è’l         DataSet : ‘ã”[—š—ðˆê——•\Ž¦—p‚Ìƒf[ƒ^(DataSet)
        // ************************************************************************************************
        public DataSet SetDainoSfsfRirekiData(DataSet csDainoSfskRuisekiDataset, string strShoriKB)
        {
            const string SHORIKB_SFSK = "S";
            const string SHORIKB_DAINO = "D";

            var csReturnDataset = default(DataSet);

            if ((strShoriKB ?? "") == SHORIKB_SFSK)
            {
                csReturnDataset = SetSfskRirekiData(csDainoSfskRuisekiDataset, strShoriKB);
            }
            else if ((strShoriKB ?? "") == SHORIKB_DAINO)
            {
                csReturnDataset = SetDainoRirekiData(csDainoSfskRuisekiDataset, strShoriKB);
            }

            return csReturnDataset;
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[‘—•tæ—ÝÏ‚Æ”õl‚Ìƒf[ƒ^‚ðƒGƒ“ƒeƒBƒeƒB‚ÉŠi”[‚·‚é
        // * 
        // * \•¶           Public Function SetSfskRirekiData(ByVal csDainoSfskRuisekiDataset As DataSet,
        // *                                                  ByVal strShoriKB As String) As DataSet
        // * 
        // * ‹@”\@@    @ ‘ã”[‘—•tæ—ÝÏƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŠi”[‚·‚é
        // * 
        // * ˆø”           csDainoSfskRuisekiDataset As DataSet   F‘ã”[‘—•tæ—ÝÏƒf[ƒ^ƒZƒbƒg
        // *                strShoriKB As String                   Fˆ—‹æ•ª@"D"F‘ã”[A"S"F‘—•tæ
        // * 
        // * –ß‚è’l         DataSet : ‘ã”[—š—ðˆê——•\Ž¦—p‚Ìƒf[ƒ^(DataSet)
        // ************************************************************************************************
        public DataSet SetSfskRirekiData(DataSet csDainoSfskRuisekiDataset, string strShoriKB)
        {
            // ’è”
            const string ALL9_YMD = "99999999";               // ”NŒŽ“úƒI[ƒ‹‚X
            const string SFSK = "‘—•tæ";                      // ‘—•tæ•¶Œ¾

            DataSet csReturnDataset;
            DataRow csDataNewRow;

            bool blnIsDainoSfskBiko = false;
            DataSet csBikoDataSet;
            // *—š—ð”Ô† 000004 2023/12/05 C³ŠJŽn
            // Dim blnSakujoFG As Boolean = False
            bool blnSakujoFG = true;
            // *—š—ð”Ô† 000004 2023/12/05 C³I—¹

            URGyomuCDMstBClass cGyomuCDMstB;              // ‹Æ–±ƒR[ƒhƒ}ƒXƒ^‚c‚`
            DataSet csGyomuCDMstEntity;                   // ‹Æ–±ƒR[ƒhƒ}ƒXƒ^DataSet
            UFDateClass cfDate;                           // “ú•tƒNƒ‰ƒX
            ABDainoKankeiBClass cDainoKankeiB;            // ‘ã”[ŠÖŒWŽæ“¾ƒNƒ‰ƒX
            ABAtenaGetBClass cAtenaGetB;                  // ˆ¶–¼Žæ“¾ƒNƒ‰ƒX
            ABAtenaHenshuBClass cAtenaHenshuB;            // ˆ¶–¼•ÒW‚a
            ABJuminShubetsuBClass cJuminShubetsuB;        // Z–¯Ží•Ê–¼ÌŽæ“¾ƒNƒ‰ƒX
            ABKannaiKangaiKBBClass cKannaiKangaiKBB;      // ŠÇ“àŠÇŠO–¼ÌŽæ“¾ƒNƒ‰ƒX
            ABBikoBClass cABBikoB;

            DataTable csDataTable;
            ABDainoSfskRuisekiBClass cDainoSfskRuisekiB;               // ‘ã”[‘—•tæ—ÝÏ‚c‚`ƒrƒWƒlƒXƒNƒ‰ƒX
            ABDainoSfskRuiseki_HyojunBClass cDainoSfskRuisekiHyojunB;  // ‘ã”[‘—•tæ—ÝÏ_•W€‚c‚`ƒrƒWƒlƒXƒNƒ‰ƒX
            DataRow[] csSfskRirekiDataRows;
            DataRow csSfskRirekiHyojunDataRow;
            var csSfskRirekiHyojunDataTable = new DataTable();

            // ƒf[ƒ^’Šo—p•Ï”
            string strJuminCd;
            string strGyomuCD;
            string strGyomuNaiShuCD;
            int intTorokuRenban;
            // *—š—ð”Ô† 000004 2023/12/05 ’Ç‰ÁŠJŽn
            string strKannaiKangaiCD;
            string strKannaiKangaiMeisho;
            // *—š—ð”Ô† 000004 2023/12/05 ’Ç‰ÁI—¹

            try
            {

                DataRow[] csDataRows;

                csDataRows = csDainoSfskRuisekiDataset.Tables(ABSfskDataEntity.TABLE_NAME).Select(string.Format("{0} = 'True'", ABSfskDataEntity.CHECK));

                strJuminCd = csDataRows[0].Item(ABSfskDataEntity.JUMINCD).ToString;
                strGyomuCD = csDataRows[0].Item(ABSfskDataEntity.GYOMUCD).ToString;
                strGyomuNaiShuCD = csDataRows[0].Item(ABSfskDataEntity.GYOMUNAISHUCD).ToString;
                intTorokuRenban = Conversions.ToInteger(csDataRows[0].Item(ABSfskDataEntity.TOROKURENBAN));

                // ‘ã”[‘—•tæ—ÝÏƒf[ƒ^‚ÌŽæ“¾
                // ‘ã”[‘—•tæ—ÝÏ‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cDainoSfskRuisekiB = new ABDainoSfskRuisekiBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                csSfskRirekiDataRows = cDainoSfskRuisekiB.GetABDainoSfskRuisekiData(strJuminCd, strGyomuCD, strGyomuNaiShuCD, intTorokuRenban, strShoriKB);
                // ‘ã”[‘—•tæ—ÝÏ_•W€ƒf[ƒ^‚ÌŽæ“¾
                cDainoSfskRuisekiHyojunB = new ABDainoSfskRuiseki_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);

                // ƒf[ƒ^ƒZƒbƒgƒCƒ“ƒXƒ^ƒ“ƒX‰»
                csReturnDataset = new DataSet();

                // ƒe[ƒuƒ‹ƒZƒbƒg‚ÌŽæ“¾
                csDataTable = this.CreateColumnsABSfskRirekiData();

                // ƒf[ƒ^ƒZƒbƒg‚Éƒe[ƒuƒ‹ƒZƒbƒg‚Ì’Ç‰Á
                csReturnDataset.Tables.Add(csDataTable);

                // “ú•tƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cfDate = new UFDateClass(m_cfConfigDataClass);

                // ‘ã”[ŠÖŒWŽæ“¾ƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cDainoKankeiB = new ABDainoKankeiBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);

                // ‹Æ–±ƒR[ƒhƒ}ƒXƒ^‚c‚`‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                cGyomuCDMstB = new URGyomuCDMstBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);

                // ˆ¶–¼•ÒW‚a‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                cAtenaHenshuB = new ABAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);

                // ˆ¶–¼Žæ“¾ƒNƒ‰ƒXƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cAtenaGetB = new ABAtenaGetBClass(m_cfControlData, m_cfConfigDataClass);

                // Z–¯Ží•ÊƒNƒ‰ƒXƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cJuminShubetsuB = new ABJuminShubetsuBClass(m_cfControlData, m_cfConfigDataClass);

                // ŠÇ“àŠÇŠOƒNƒ‰ƒXƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cKannaiKangaiKBB = new ABKannaiKangaiKBBClass(m_cfControlData, m_cfConfigDataClass);

                // ”õlƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cABBikoB = new ABBikoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);

                foreach (var csDataRow in csSfskRirekiDataRows)
                {

                    csDataNewRow = csReturnDataset.Tables(ABSfskDataEntity.TABLE_NAME).NewRow;

                    // ‰Šú’l‚ÌÝ’è
                    foreach (DataColumn csDataColumn in csDataNewRow.Table.Columns)
                    {
                        if (csDataColumn.ColumnName == ABSfskDataEntity.KOSHINCOUNTER)
                        {
                            csDataNewRow[csDataColumn.ColumnName] = decimal.Zero;
                        }
                        else
                        {
                            csDataNewRow[csDataColumn.ColumnName] = string.Empty;
                        }
                    }

                    // Z–¯ƒR[ƒh
                    csDataNewRow(ABSfskDataEntity.JUMINCD) = csDataRow(ABDainoSfskRuisekiEntity.JUMINCD);
                    // Žs’¬‘ºƒR[ƒh
                    csDataNewRow(ABSfskDataEntity.SHICHOSONCD) = csDataRow(ABDainoSfskRuisekiEntity.SHICHOSONCD);
                    // ‹ŒŽs’¬‘ºƒR[ƒh
                    csDataNewRow(ABSfskDataEntity.KYUSHICHOSONCD) = csDataRow(ABDainoSfskRuisekiEntity.KYUSHICHOSONCD);
                    // ‹Æ–±ƒR[ƒh
                    csDataNewRow(ABSfskDataEntity.GYOMUCD) = csDataRow(ABDainoSfskRuisekiEntity.GYOMUCD);

                    // ‹Æ–±ƒR[ƒhƒ}ƒXƒ^‚æ‚èŽæ“¾‚·‚é
                    strGyomuCD = Conversions.ToString(csDataRow(ABDainoSfskRuisekiEntity.GYOMUCD));
                    csGyomuCDMstEntity = cGyomuCDMstB.GetGyomuCDHoshu(strGyomuCD);

                    if (csGyomuCDMstEntity.Tables(URGyomuCDMstEntity.TABLE_NAME).Rows.Count == 0)
                    {
                        // ‹Æ–±–¼Ì
                        csDataNewRow(ABSfskDataEntity.GYOMUMEISHO) = string.Empty;
                        // ‹Æ–±–¼Ì—ª
                        csDataNewRow(ABSfskDataEntity.GYOMUMEISHORYAKU) = string.Empty;
                    }
                    else
                    {
                        // ‹Æ–±–¼Ì
                        csDataNewRow(ABSfskDataEntity.GYOMUMEISHO) = csGyomuCDMstEntity.Tables(URGyomuCDMstEntity.TABLE_NAME).Rows(0)(URGyomuCDMstEntity.GYOMUMEI);
                        // ‹Æ–±–¼Ì—ª
                        csDataNewRow(ABSfskDataEntity.GYOMUMEISHORYAKU) = csGyomuCDMstEntity.Tables(URGyomuCDMstEntity.TABLE_NAME).Rows(0)(URGyomuCDMstEntity.GYOMURYAKUSHO);
                    }

                    // ‹Æ–±“àŽí•ÊƒR[ƒh
                    csDataNewRow(ABSfskDataEntity.GYOMUNAISHUCD) = csDataRow(ABDainoSfskRuisekiEntity.GYOMUNAISHU_CD);
                    // ‘ã”[Z–¯ƒR[ƒh
                    csDataNewRow(ABSfskDataEntity.DAINOJUMINCD) = csDataRow(ABDainoSfskRuisekiEntity.DAINOJUMINCD);
                    // ŠJŽn”NŒŽ
                    csDataNewRow(ABSfskDataEntity.STYMD) = csDataRow(ABDainoSfskRuisekiEntity.STYMD);
                    // I—¹”NŒŽ
                    csDataNewRow(ABSfskDataEntity.EDYMD) = csDataRow(ABDainoSfskRuisekiEntity.EDYMD);

                    // •\Ž¦—pŠJŽn”NŒŽ
                    cfDate.p_strDateValue = Conversions.ToString(csDataRow(ABDainoSfskRuisekiEntity.STYMD));
                    cfDate.p_enEraType = UFEraType.KanjiRyaku;
                    cfDate.p_enDateSeparator = UFDateSeparator.Period;
                    csDataNewRow(ABSfskDataEntity.DISP_STYMD) = cfDate.p_strWarekiYMD;

                    // •\Ž¦—pI—¹”NŒŽi999999‚ÌŽž‚ÍA”ñ•\Ž¦j
                    if ((Conversions.ToString(csDataRow(ABDainoSfskRuisekiEntity.EDYMD)) ?? "") == ALL9_YMD)
                    {
                        csDataNewRow(ABSfskDataEntity.DISP_EDYMD) = string.Empty;
                    }
                    else
                    {
                        cfDate.p_strDateValue = Conversions.ToString(csDataRow(ABDainoSfskRuisekiEntity.EDYMD));
                        csDataNewRow(ABSfskDataEntity.DISP_EDYMD) = cfDate.p_strWarekiYMD;
                    }

                    // ‘—•tæƒJƒi–¼Ì
                    csDataNewRow(ABSfskDataEntity.SFSKKANAMEISHO) = csDataRow(ABDainoSfskRuisekiEntity.SFSKKANAMEISHO);
                    // ‘—•tæŠ¿Žš–¼Ì
                    csDataNewRow(ABSfskDataEntity.SFSKKANJIMEISHO) = csDataRow(ABDainoSfskRuisekiEntity.SFSKKANJIMEISHO);

                    // ‘—•tæŠÇ“àŠÇŠO‹æ•ª
                    csDataNewRow(ABSfskDataEntity.SFSKKANNAiKANGAIKB) = csDataRow(ABDainoSfskRuisekiEntity.SFSKKANNAIKANGAIKB);
                    // *—š—ð”Ô† 000004 2023/12/05 ’Ç‰ÁŠJŽn
                    // ŠÇ“àŠÇŠO–¼ÌƒL[ƒZƒbƒg
                    strKannaiKangaiCD = Conversions.ToString(csDataRow(ABDainoSfskRuisekiEntity.SFSKKANNAIKANGAIKB));
                    // ŠÇ“àŠÇŠO–¼ÌŽæ“¾ƒƒ]ƒbƒgŽÀs
                    strKannaiKangaiMeisho = cKannaiKangaiKBB.GetKannaiKangai(strKannaiKangaiCD);
                    // ŠÇ“àŠÇŠO–¼Ì
                    csDataNewRow(ABSfskDataEntity.SFSKKANNAIKANGAIMEI) = strKannaiKangaiMeisho;
                    // *—š—ð”Ô† 000004 2023/12/05 ’Ç‰ÁI—¹
                    // ‘—•tæ—X•Ö”Ô†
                    csDataNewRow(ABSfskDataEntity.SFSKYUBINNO) = csDataRow(ABDainoSfskRuisekiEntity.SFSKYUBINNO);
                    // ‘—•tæZŠƒR[ƒh
                    csDataNewRow(ABSfskDataEntity.SFSKZJUSHOCD) = csDataRow(ABDainoSfskRuisekiEntity.SFSKZJUSHOCD);
                    // ‘—•tæZŠ
                    csDataNewRow(ABSfskDataEntity.SFSKJUSHO) = csDataRow(ABDainoSfskRuisekiEntity.SFSKJUSHO);
                    // ‘—•tæ”Ô’n
                    csDataNewRow(ABSfskDataEntity.SFSKBANCHI) = csDataRow(ABDainoSfskRuisekiEntity.SFSKBANCHI);
                    // ‘—•tæ”Ô’nƒR[ƒh1
                    csDataNewRow(ABSfskDataEntity.BANCHICD1) = csDataRow(ABDainoSfskRuisekiEntity.SFSKBANCHICD1);
                    // ‘—•tæ”Ô’nƒR[ƒh2
                    csDataNewRow(ABSfskDataEntity.BANCHICD2) = csDataRow(ABDainoSfskRuisekiEntity.SFSKBANCHICD2);
                    // ‘—•tæ”Ô’nƒR[ƒh3
                    csDataNewRow(ABSfskDataEntity.BANCHICD3) = csDataRow(ABDainoSfskRuisekiEntity.SFSKBANCHICD3);
                    // ‘—•tæ•û‘
                    csDataNewRow(ABSfskDataEntity.SFSKKATAGAKI) = csDataRow(ABDainoSfskRuisekiEntity.SFSKKATAGAKI);
                    // ‘—•tæ˜A—æ‚P
                    csDataNewRow(ABSfskDataEntity.SFSKRENRAKUSAKI1) = csDataRow(ABDainoSfskRuisekiEntity.SFSKRENRAKUSAKI1);
                    // ‘—•tæ˜A—æ‚Q
                    csDataNewRow(ABSfskDataEntity.SFSKRENRAKUSAKI2) = csDataRow(ABDainoSfskRuisekiEntity.SFSKRENRAKUSAKI2);
                    // •û‘ƒR[ƒh
                    csDataNewRow.Item(ABSfskDataEntity.SFSKKATAGAKICD) = csDataRow(ABDainoSfskRuisekiEntity.SFSKKATAGAKICD);
                    // ‘—•tæs­‹æƒR[ƒh
                    csDataNewRow(ABSfskDataEntity.SFSKGYOSEIKUCD) = csDataRow(ABDainoSfskRuisekiEntity.SFSKGYOSEIKUCD);
                    // ‘—•tæs­‹æ–¼
                    // s­‹æ‚b‚c‚É”ŽšˆÈŠO‚Ì‚à‚Ì‚ª¬“ü‚µ‚Ä‚¢‚éê‡‚Í‚»‚Ì‚Ü‚Üs­‹æ–¼Ì‚ðƒZƒbƒg
                    csDataNewRow(ABSfskDataEntity.SFSKGYOSEIKUMEI) = csDataRow(ABDainoSfskRuisekiEntity.SFSKGYOSEIKUMEI);
                    // ‘—•tæ’n‹æƒR[ƒh‚P
                    csDataNewRow(ABSfskDataEntity.SFSKCHIKUCD1) = csDataRow(ABDainoSfskRuisekiEntity.SFSKCHIKUCD1);
                    // ‘—•tæ’n‹æ–¼‚P
                    csDataNewRow(ABSfskDataEntity.SFSKCHIKUMEI1) = csDataRow(ABDainoSfskRuisekiEntity.SFSKCHIKUMEI1);
                    // ‘—•tæ’n‹æƒR[ƒh‚Q
                    csDataNewRow(ABSfskDataEntity.SFSKCHIKUCD2) = csDataRow(ABDainoSfskRuisekiEntity.SFSKCHIKUCD2);
                    // ‘—•tæ’n‹æ–¼‚Q
                    csDataNewRow(ABSfskDataEntity.SFSKCHIKUMEI2) = csDataRow(ABDainoSfskRuisekiEntity.SFSKCHIKUMEI2);
                    // ‘—•tæ’n‹æƒR[ƒh‚R
                    csDataNewRow(ABSfskDataEntity.SFSKCHIKUCD3) = csDataRow(ABDainoSfskRuisekiEntity.SFSKCHIKUCD3);
                    // ‘—•tæ’n‹æ–¼‚R
                    csDataNewRow(ABSfskDataEntity.SFSKCHIKUMEI3) = csDataRow(ABDainoSfskRuisekiEntity.SFSKCHIKUMEI3);
                    // ‘—•tæ˜A—æ‚P
                    csDataNewRow(ABSfskDataEntity.SFSKRENRAKUSAKI1) = csDataRow(ABDainoSfskRuisekiEntity.SFSKRENRAKUSAKI1);
                    // ‘—•tæ˜A—æ‚Q
                    csDataNewRow(ABSfskDataEntity.SFSKRENRAKUSAKI2) = csDataRow(ABDainoSfskRuisekiEntity.SFSKRENRAKUSAKI2);


                    csSfskRirekiHyojunDataTable = cDainoSfskRuisekiHyojunB.GetABDainoSfskRuisekiData(strJuminCd, strGyomuCD, strGyomuNaiShuCD, intTorokuRenban, strShoriKB);
                    csSfskRirekiHyojunDataRow = csSfskRirekiHyojunDataTable.Select(string.Format("{0}='{1}'", ABDainoSfskRuisekiHyojunEntity.RRKNO, csDataRow(ABDainoSfskRuisekiEntity.RRKNO).ToString))[0];

                    // ”õlƒ}ƒXƒ^‚ðŽæ“¾
                    csBikoDataSet = cABBikoB.SelectByKey(ABBikoEntity.DEFAULT.BIKOKBN.SFSK, csDataRow(ABDainoSfskRuisekiEntity.JUMINCD).ToString(), csDataRow(ABDainoSfskRuisekiEntity.GYOMUCD).ToString(), csDataRow(ABDainoSfskRuisekiEntity.GYOMUNAISHU_CD).ToString(), csDataRow(ABDainoSfskRuisekiEntity.TOROKURENBAN).ToString(), csDataRow(ABDainoSfskRuisekiEntity.RRKNO).ToString(), blnSakujoFG);

                    if (csBikoDataSet is not null && 0 < csBikoDataSet.Tables(ABBikoEntity.TABLE_NAME).Rows.Count)
                    {
                        // Z–¯ƒR[ƒh
                        csDataNewRow(ABSfskDataEntity.DAINOJUMINCD) = csBikoDataSet.Tables(ABBikoEntity.TABLE_NAME).Rows(0)(ABBikoEntity.RESERVE);
                        csDataNewRow(ABSfskDataEntity.BIKO) = csBikoDataSet.Tables(ABBikoEntity.TABLE_NAME).Rows(0)(ABBikoEntity.BIKO);
                    }
                    else
                    {
                        csDataNewRow(ABSfskDataEntity.BIKO) = string.Empty;
                    }

                    csDataNewRow(ABSfskDataEntity.CHECK) = false;
                    csDataNewRow(ABSfskDataEntity.JOTAI) = ABDainoSfskShoriMode.Empty.GetHashCode.ToString;
                    csDataNewRow(ABSfskDataEntity.DISP_JOTAI) = string.Empty;
                    csDataNewRow(ABSfskDataEntity.SEIGYOKB) = string.Empty;

                    csDataNewRow(ABSfskDataEntity.TOROKURENBAN) = csDataRow(ABDainoSfskRuisekiEntity.TOROKURENBAN);     // “o˜^˜A”Ô
                    csDataNewRow(ABSfskDataEntity.RRKNO) = csDataRow(ABDainoSfskRuisekiEntity.RRKNO);                   // —š—ð”Ô†
                    csDataNewRow(ABSfskDataEntity.SHIKUCHOSONCD) = string.Empty;                                        // Žs‹æ’¬‘ºƒR[ƒg
                    csDataNewRow(ABSfskDataEntity.MACHIAZACD) = string.Empty;                                           // ’¬ŽšƒR[ƒh
                    csDataNewRow(ABSfskDataEntity.TODOFUKEN) = string.Empty;                                            // “s“¹•{Œ§
                    csDataNewRow(ABSfskDataEntity.SHIKUCHOSON) = string.Empty;
                    csDataNewRow(ABSfskDataEntity.MACHIAZA) = string.Empty;

                    // ‘—•tæ‹æ•ª
                    csDataNewRow(ABSfskDataEntity.SFSKKBN) = csSfskRirekiHyojunDataRow.Item(ABDainoSfskRuisekiHyojunEntity.SFSKKBN).ToString();

                    csDataNewRow(ABSfskDataEntity.DISP_DAINOKB) = SFSK;

                    // íœƒtƒ‰ƒO
                    csDataNewRow(ABSfskDataEntity.SAKUJOFG) = csDataRow(ABDainoSfskRuisekiEntity.SAKUJOFG);

                    // XVƒ†[ƒU
                    csDataNewRow(ABSfskDataEntity.KOSHINUSER) = csDataRow(ABDainoSfskRuisekiEntity.KOSHINUSER);
                    // XVƒJƒEƒ“ƒ^
                    csDataNewRow(ABSfskDataEntity.KOSHINCOUNTER) = csDataRow(ABDainoSfskRuisekiEntity.KOSHINCOUNTER);

                    csReturnDataset.Tables(ABSfskDataEntity.TABLE_NAME).Rows.Add(csDataNewRow);

                }
                csReturnDataset.AcceptChanges();
            }


            catch (UFAppException cfAppExp)
            {

                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLogClass.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + default
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 81157


                Input:
                " + cfAppExp.p_strErrorCode + "z" +
                                                    "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 81248


                Input:
                " + cfAppExp.Message + "z")

                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                    "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 81502


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                    "yƒƒ\ƒbƒh–¼:
                 */
                ;

                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 81581


                                Input:
                                " + Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                                    "yƒGƒ‰[“à—e:" + csExp.Message + "z")

                                 */
                throw;

            }

            return csReturnDataset;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[‘—•tæ—ÝÏ‚Æ”õl‚Ìƒf[ƒ^‚ðƒGƒ“ƒeƒBƒeƒB‚ÉŠi”[‚·‚é
        // * 
        // * \•¶        Public Function SetDainoRirekiData(ByVal csDainoSfskRuisekiDataset As DataSet,
        // *                                                    ByVal strShoriKB As String) As DataSet
        // * 
        // * ‹@”\@@    @ ‘ã”[‘—•tæ—ÝÏƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŠi”[‚·‚é
        // * 
        // * ˆø”           csDainoSfskRuisekiDataset As DataSet   F‘ã”[‘—•tæ—ÝÏƒf[ƒ^ƒZƒbƒg
        // *                strShoriKB As String                  : ˆ—‹æ•ª@"D"F‘ã”[A"S"F‘—•tæ
        // * 
        // * –ß‚è’l         DataSet : ‘ã”[—š—ðˆê——•\Ž¦—p‚Ìƒf[ƒ^(DataSet)
        // ************************************************************************************************
        public DataSet SetDainoRirekiData(DataSet csDainoSfskRuisekiDataset, string strShoriKB)
        {
            // ’è”
            const string ALL9_YMD = "99999999";               // ”NŒŽ“úƒI[ƒ‹‚X
            const string JUSHOHENSHU1_PARA_ONE = "1";         // î•ñ•ÒW1@ƒpƒ‰ƒ[ƒ^1
            const string GET_HONNINDATA = "1";                // –{lƒf[ƒ^Žæ“¾
            const string DATAKB_HOJIN = "20";                 // ƒf[ƒ^‹æ•ª@–@l
            const string DATASHU_FRN = "2";                   // ƒf[ƒ^Ží@ŠO‘l

            UFErrorClass cfErrorClass;                    // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì

            DataSet csReturnDataset;
            DataRow csDataNewRow;
            DataSet csDainoKankeiDataSet;
            DataSet csAtenaDataSet;
            DataRow csAtenaRow;

            string strDainoKB;
            int intRowCount;
            string strDataKB;
            string strDataShu;
            string strMeisho;
            string strKannaiKangaiCD;
            string strKannaiKangaiMeisho;
            string strKanjiShimei;                        // Š¿ŽšŽ–¼
            string strKanaShimei;                         // ƒJƒiŽ–¼
            string strYubinNO;                            // —X•Ö”Ô†
            DataSet csBikoDataSet;
            // *—š—ð”Ô† 000004 2023/12/05 C³ŠJŽn
            // Dim blnSakujoFG As Boolean = False
            bool blnSakujoFG = true;
            // *—š—ð”Ô† 000004 2023/12/05 C³I—¹

            URGyomuCDMstBClass cGyomuCDMstB;              // ‹Æ–±ƒR[ƒhƒ}ƒXƒ^‚c‚`
            DataSet csGyomuCDMstEntity;                   // ‹Æ–±ƒR[ƒhƒ}ƒXƒ^DataSet
            UFDateClass cfDate;                           // “ú•tƒNƒ‰ƒX
            ABDainoKankeiBClass cDainoKankeiB;            // ‘ã”[ŠÖŒWŽæ“¾ƒNƒ‰ƒX
            ABAtenaGetBClass cAtenaGetB;                  // ˆ¶–¼Žæ“¾ƒNƒ‰ƒX
            ABAtenaGetPara1XClass cAtenaGetPara1X;        // ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            ABAtenaHenshuBClass cAtenaHenshuB;            // ˆ¶–¼•ÒW‚a
            DataSet csAtena1Entity;                       // ˆ¶–¼ƒf[ƒ^Entity
            ABJuminShubetsuBClass cJuminShubetsuB;        // Z–¯Ží•Ê–¼ÌŽæ“¾ƒNƒ‰ƒX
            ABKannaiKangaiKBBClass cKannaiKangaiKBB;      // ŠÇ“àŠÇŠO–¼ÌŽæ“¾ƒNƒ‰ƒX
            ABBikoBClass cABBikoB;

            DataTable csDataTable;
            ABDainoSfskRuisekiBClass csDainoSfskRuisekiB; // ‘ã”[‘—•tæ—ÝÏ‚c‚`ƒrƒWƒlƒXƒNƒ‰ƒX
            DataRow[] csDainoRirekiDataRows;

            // ƒf[ƒ^’Šo—p•Ï”
            string strJuminCd;
            string strGyomuCD;
            string strGyomuNaiShuCD;
            int intTorokuRenban;

            try
            {

                DataRow[] csDataRows;
                csDataRows = csDainoSfskRuisekiDataset.Tables(ABDainoDataEntity.TABLE_NAME).Select(string.Format("{0} = 'True'", ABDainoDataEntity.CHECK));

                strJuminCd = csDataRows[0].Item(ABDainoDataEntity.JUMINCD).ToString;
                strGyomuCD = csDataRows[0].Item(ABDainoDataEntity.GYOMUCD).ToString;
                strGyomuNaiShuCD = csDataRows[0].Item(ABDainoDataEntity.GYOMUNAISHUCD).ToString;
                intTorokuRenban = Conversions.ToInteger(csDataRows[0].Item(ABDainoDataEntity.TOROKURENBAN));


                // ‘ã”[‘—•tæ—ÝÏƒf[ƒ^‚ÌŽæ“¾
                // ‘ã”[‘—•tæ—ÝÏ‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                csDainoSfskRuisekiB = new ABDainoSfskRuisekiBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                csDainoRirekiDataRows = csDainoSfskRuisekiB.GetABDainoSfskRuisekiData(strJuminCd, strGyomuCD, strGyomuNaiShuCD, intTorokuRenban, strShoriKB);

                // ƒf[ƒ^ƒZƒbƒgƒCƒ“ƒXƒ^ƒ“ƒX‰»
                csReturnDataset = new DataSet();

                // ƒe[ƒuƒ‹ƒZƒbƒg‚ÌŽæ“¾
                csDataTable = this.CreateColumnsABDainoRirekiData();

                // ƒf[ƒ^ƒZƒbƒg‚Éƒe[ƒuƒ‹ƒZƒbƒg‚Ì’Ç‰Á
                csReturnDataset.Tables.Add(csDataTable);

                // “ú•tƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cfDate = new UFDateClass(m_cfConfigDataClass);

                // ‘ã”[ŠÖŒWŽæ“¾ƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cDainoKankeiB = new ABDainoKankeiBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);

                // ‹Æ–±ƒR[ƒhƒ}ƒXƒ^‚c‚`‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                cGyomuCDMstB = new URGyomuCDMstBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);

                // ˆ¶–¼•ÒW‚a‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                cAtenaHenshuB = new ABAtenaHenshuBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);

                // ˆ¶–¼Žæ“¾ƒNƒ‰ƒXƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cAtenaGetB = new ABAtenaGetBClass(m_cfControlData, m_cfConfigDataClass);

                // Z–¯Ží•ÊƒNƒ‰ƒXƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cJuminShubetsuB = new ABJuminShubetsuBClass(m_cfControlData, m_cfConfigDataClass);

                // ŠÇ“àŠÇŠOƒNƒ‰ƒXƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cKannaiKangaiKBB = new ABKannaiKangaiKBBClass(m_cfControlData, m_cfConfigDataClass);

                // ”õlƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cABBikoB = new ABBikoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);

                foreach (var csDataRow in csDainoRirekiDataRows)
                {
                    csDataNewRow = csReturnDataset.Tables(ABDainoDataEntity.TABLE_NAME).NewRow;

                    // ‰Šú’l‚ÌÝ’è
                    foreach (DataColumn csDataColumn in csDataNewRow.Table.Columns)
                    {
                        if (csDataColumn.ColumnName == ABDainoDataEntity.KOSHINCOUNTER)
                        {
                            csDataNewRow[csDataColumn.ColumnName] = decimal.Zero;
                        }
                        else
                        {
                            csDataNewRow[csDataColumn.ColumnName] = string.Empty;
                        }
                    }

                    // Z–¯ƒR[ƒh
                    csDataNewRow(ABDainoDataEntity.JUMINCD) = csDataRow(ABDainoSfskRuisekiEntity.JUMINCD);
                    // Žs’¬‘ºƒR[ƒh
                    csDataNewRow(ABDainoDataEntity.SHICHOSONCD) = csDataRow(ABDainoSfskRuisekiEntity.SHICHOSONCD);
                    // ‹ŒŽs’¬‘ºƒR[ƒh
                    csDataNewRow(ABDainoDataEntity.KYUSHICHOSONCD) = csDataRow(ABDainoSfskRuisekiEntity.KYUSHICHOSONCD);
                    // ‹Æ–±ƒR[ƒh
                    csDataNewRow(ABDainoDataEntity.GYOMUCD) = csDataRow(ABDainoSfskRuisekiEntity.GYOMUCD);

                    // ‹Æ–±ƒR[ƒhƒ}ƒXƒ^‚æ‚èŽæ“¾‚·‚é
                    strGyomuCD = Conversions.ToString(csDataRow(ABDainoSfskRuisekiEntity.GYOMUCD));
                    csGyomuCDMstEntity = cGyomuCDMstB.GetGyomuCDHoshu(strGyomuCD);

                    if (csGyomuCDMstEntity.Tables(URGyomuCDMstEntity.TABLE_NAME).Rows.Count == 0)
                    {
                        // ‹Æ–±–¼Ì
                        csDataNewRow(ABHiDainoDataEntity.GYOMUMEISHO) = string.Empty;
                        // ‹Æ–±–¼Ì—ª
                        csDataNewRow(ABHiDainoDataEntity.GYOMUMEISHORYAKU) = string.Empty;
                    }
                    else
                    {
                        // ‹Æ–±–¼Ì
                        csDataNewRow(ABHiDainoDataEntity.GYOMUMEISHO) = csGyomuCDMstEntity.Tables(URGyomuCDMstEntity.TABLE_NAME).Rows(0)(URGyomuCDMstEntity.GYOMUMEI);
                        // ‹Æ–±–¼Ì—ª
                        csDataNewRow(ABHiDainoDataEntity.GYOMUMEISHORYAKU) = csGyomuCDMstEntity.Tables(URGyomuCDMstEntity.TABLE_NAME).Rows(0)(URGyomuCDMstEntity.GYOMURYAKUSHO);
                    }

                    // ‹Æ–±“àŽí•ÊƒR[ƒh
                    csDataNewRow(ABDainoDataEntity.GYOMUNAISHUCD) = csDataRow(ABDainoSfskRuisekiEntity.GYOMUNAISHU_CD);
                    // ‘ã”[Z–¯ƒR[ƒh
                    csDataNewRow(ABDainoDataEntity.DAINOJUMINCD) = csDataRow(ABDainoSfskRuisekiEntity.DAINOJUMINCD);
                    // ŠJŽn”NŒŽ
                    csDataNewRow(ABDainoDataEntity.STYMD) = csDataRow(ABDainoSfskRuisekiEntity.STYMD);
                    // I—¹”NŒŽ
                    csDataNewRow(ABDainoDataEntity.EDYMD) = csDataRow(ABDainoSfskRuisekiEntity.EDYMD);

                    // •\Ž¦—pŠJŽn”NŒŽ
                    cfDate.p_strDateValue = Conversions.ToString(csDataRow(ABDainoSfskRuisekiEntity.STYMD));
                    cfDate.p_enEraType = UFEraType.KanjiRyaku;
                    cfDate.p_enDateSeparator = UFDateSeparator.Period;
                    csDataNewRow(ABDainoDataEntity.DISP_STYMD) = cfDate.p_strWarekiYMD;

                    // •\Ž¦—pI—¹”NŒŽi999999‚ÌŽž‚ÍA”ñ•\Ž¦j
                    if ((Conversions.ToString(csDataRow(ABDainoSfskRuisekiEntity.EDYMD)) ?? "") == ALL9_YMD)
                    {
                        csDataNewRow(ABDainoDataEntity.DISP_EDYMD) = string.Empty;
                    }
                    else
                    {
                        cfDate.p_strDateValue = Conversions.ToString(csDataRow(ABDainoSfskRuisekiEntity.EDYMD));
                        csDataNewRow(ABDainoDataEntity.DISP_EDYMD) = cfDate.p_strWarekiYMD;
                    }

                    // ‘ã”[‹æ•ª
                    csDataNewRow(ABDainoDataEntity.DAINOKB) = csDataRow(ABDainoSfskRuisekiEntity.DAINOKB);
                    // ‘ã”[‹æ•ª–¼Ì
                    strDainoKB = Conversions.ToString(csDataRow(ABDainoSfskRuisekiEntity.DAINOKB));
                    csDainoKankeiDataSet = cDainoKankeiB.GetDainoKBHoshu(strDainoKB);
                    intRowCount = csDainoKankeiDataSet.Tables(ABDainoKankeiCDMSTEntity.TABLE_NAME).Rows.Count;
                    if (!(intRowCount == 0))
                    {
                        csDataNewRow(ABDainoDataEntity.DAINOKBMEISHO) = (string)csDainoKankeiDataSet.Tables(ABDainoKankeiCDMSTEntity.TABLE_NAME).Rows(0)(ABDainoKankeiCDMSTEntity.DAINOKBMEISHO);
                        csDataNewRow(ABDainoDataEntity.DAINOKBRYAKUMEI) = (string)csDainoKankeiDataSet.Tables(ABDainoKankeiCDMSTEntity.TABLE_NAME).Rows(0)(ABDainoKankeiCDMSTEntity.DAINOKBRYAKUMEI);
                    }

                    // ˆ¶–¼Žæ“¾ƒpƒ‰ƒ[ƒ^ƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    cAtenaGetPara1X = new ABAtenaGetPara1XClass();

                    // ˆ¶–¼’ŠoƒL[ƒZƒbƒg
                    cAtenaGetPara1X.p_strJuminCD = Conversions.ToString(csDataRow(ABDainoSfskRuisekiEntity.DAINOJUMINCD));
                    cAtenaGetPara1X.p_strJushoHenshu1 = JUSHOHENSHU1_PARA_ONE;
                    cAtenaGetPara1X.p_blnSakujoFG = true;
                    cAtenaGetPara1X.p_strDaihyoShaKB = GET_HONNINDATA;       // *–{lƒf[ƒ^Žæ“¾
                                                                             // ŒÂl”Ô†Žæ“¾ƒpƒ‰ƒ[ƒ^‚ðÝ’è
                    cAtenaGetPara1X.p_strMyNumberKB = ABConstClass.MYNUMBER.MYNUMBERKB.ON;

                    try
                    {
                        // uˆ¶–¼Žæ“¾‚avƒNƒ‰ƒX‚Ìuˆ¶–¼Žæ“¾‚Qvƒƒ\ƒbƒh‚ðŽÀs
                        csAtenaDataSet = cAtenaGetB.AtenaGet2(cAtenaGetPara1X);

                        intRowCount = csAtenaDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count;
                        if (!(intRowCount == 1))
                        {
                            // ƒGƒ‰[ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            cfErrorClass = new UFErrorClass(m_cfControlData.m_strBusinessId);
                            // ƒGƒ‰[’è‹`‚ðŽæ“¾
                            objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003078);
                            throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                        }

                        // uˆ¶–¼•ÒW‚avƒNƒ‰ƒX‚Ìuˆ¶–¼•ÒWvƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                        csAtena1Entity = cAtenaHenshuB.AtenaHenshu(cAtenaGetPara1X, csAtenaDataSet);

                        csAtenaRow = csAtenaDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows(0);

                        // Z–¯–¼ÌŽæ“¾ƒL[ƒZƒbƒg
                        strDataKB = Conversions.ToString(csAtenaRow(ABAtenaEntity.ATENADATAKB));
                        strDataShu = Conversions.ToString(csAtenaRow(ABAtenaEntity.ATENADATASHU));
                        // Z–¯–¼ÌŽæ“¾ƒƒ]ƒbƒgŽÀs
                        cJuminShubetsuB.GetJuminshubetsu(strDataKB, strDataShu);
                        // Z–¯Ží•Ê–¼Ì
                        csDataNewRow(ABDainoDataEntity.JUMINSHUMEISHO) = cJuminShubetsuB.p_strHenshuShubetsu;

                        // ƒJƒi–¼
                        strMeisho = Conversions.ToString(csAtenaRow(ABAtenaEntity.KANAMEISHO2));
                        if (string.IsNullOrEmpty(strMeisho))
                        {
                            csDataNewRow(ABDainoDataEntity.KANASHIMEI) = csAtenaRow(ABAtenaEntity.KANAMEISHO1);
                        }
                        // ### –@l‚ÌŽž‚ÍƒJƒi–¼Ì‚P‚ÆƒJƒi–¼Ì‚Q‚ð”¼ŠpƒXƒy[ƒX‚Å‚­‚Á‚Â‚¯‚é
                        else if ((strDataKB ?? "") == DATAKB_HOJIN)
                        {
                            // •¶Žš—ñ‚ðŒ‹‡‚µ‚½ê‡CMaxLength‚ð’´‚¦‚È‚¢‚æ‚¤‚ÉØ‚è‹l‚ß
                            strKanaShimei = Conversions.ToString(csAtenaRow(ABAtenaEntity.KANAMEISHO1)) + " " + Conversions.ToString(csAtenaRow(ABAtenaEntity.KANAMEISHO2));
                            if (strKanaShimei.RLength > csDataNewRow.Table.Columns(ABDainoDataEntity.KANASHIMEI).MaxLength)
                            {
                                csDataNewRow(ABDainoDataEntity.KANASHIMEI) = strKanaShimei.RSubstring(0, csDataNewRow.Table.Columns(ABDainoDataEntity.KANASHIMEI).MaxLength);
                            }
                            else
                            {
                                csDataNewRow(ABDainoDataEntity.KANASHIMEI) = strKanaShimei;
                            }
                        }
                        else if (Conversions.ToString(strDataShu[0]) == DATASHU_FRN)
                        {
                            // ### ŠO‘l‚ÌŽž‚ÍƒJƒi–¼Ì‚P
                            csDataNewRow(ABDainoDataEntity.KANASHIMEI) = csAtenaRow(ABAtenaEntity.KANAMEISHO1);
                        }
                        else
                        {
                            csDataNewRow(ABDainoDataEntity.KANASHIMEI) = csAtenaRow(ABAtenaEntity.KANAMEISHO2);
                        }

                        strKanjiShimei = (string)csAtena1Entity.Tables(ABAtena1Entity.TABLE_NAME).Rows(0)(ABAtena1Entity.HENSHUKANJISHIMEI);
                        if (csDataNewRow.Table.Columns(ABDainoDataEntity.KANJISHIMEI).MaxLength < strKanjiShimei.RLength)
                        {
                            csDataNewRow(ABDainoDataEntity.KANJISHIMEI) = strKanjiShimei.RSubstring(0, csDataNewRow.Table.Columns(ABDainoDataEntity.KANJISHIMEI).MaxLength);
                        }
                        else
                        {
                            csDataNewRow(ABDainoDataEntity.KANJISHIMEI) = strKanjiShimei;
                        }

                        // ŠÇ“àŠÇŠO–¼ÌƒL[ƒZƒbƒg
                        strKannaiKangaiCD = Conversions.ToString(csAtenaRow(ABAtenaEntity.KANNAIKANGAIKB));
                        // ŠÇ“àŠÇŠO–¼ÌŽæ“¾ƒƒ]ƒbƒgŽÀs
                        strKannaiKangaiMeisho = cKannaiKangaiKBB.GetKannaiKangai(strKannaiKangaiCD);
                        // ŠÇ“àŠÇŠO–¼Ì
                        csDataNewRow(ABDainoDataEntity.KANNAIKANGAIMEISHO) = strKannaiKangaiMeisho;
                        // —X•Ö”Ô†
                        csDataNewRow(ABDainoDataEntity.YUBINNO) = csAtenaRow(ABAtenaEntity.YUBINNO);
                        // ZŠƒR[ƒh
                        csDataNewRow(ABDainoDataEntity.JUSHOCD) = csAtenaRow(ABAtenaEntity.JUSHOCD);
                        // ZŠ–¼
                        csDataNewRow(ABDainoDataEntity.JUSHO) = csAtenaRow(ABAtenaEntity.JUSHO);
                        // ”Ô’nƒR[ƒh‚P
                        csDataNewRow(ABDainoDataEntity.BANCHICD1) = csAtenaRow(ABAtenaEntity.BANCHICD1);
                        // ”Ô’nƒR[ƒh‚Q
                        csDataNewRow(ABDainoDataEntity.BANCHICD2) = csAtenaRow(ABAtenaEntity.BANCHICD2);
                        // ”Ô’nƒR[ƒh‚R
                        csDataNewRow(ABDainoDataEntity.BANCHICD3) = csAtenaRow(ABAtenaEntity.BANCHICD3);
                        // ”Ô’n
                        csDataNewRow(ABDainoDataEntity.BANCHI) = csAtenaRow(ABAtenaEntity.BANCHI);
                        // •û‘ƒtƒ‰ƒO
                        csDataNewRow(ABDainoDataEntity.KATAGAKIFG) = csAtenaRow(ABAtenaEntity.KATAGAKIFG);
                        // •û‘ƒR[ƒh
                        csDataNewRow(ABDainoDataEntity.KATAGAKICD) = csAtenaRow(ABAtenaEntity.KATAGAKICD);
                        // •û‘
                        csDataNewRow(ABDainoDataEntity.KATAGAKI) = csAtenaRow(ABAtenaEntity.KATAGAKI);
                        // ˜A—æ‚P
                        csDataNewRow(ABDainoDataEntity.RENRAKUSAKI1) = csAtenaRow(ABAtenaEntity.RENRAKUSAKI1);
                        // ˜A—æ‚Q
                        csDataNewRow(ABDainoDataEntity.RENRAKUSAKI2) = csAtenaRow(ABAtenaEntity.RENRAKUSAKI2);
                        // s­‹æƒR[ƒh
                        csDataNewRow(ABDainoDataEntity.GYOSEIKUCD) = csAtenaRow(ABAtenaEntity.GYOSEIKUCD);
                        // s­‹æ–¼
                        csDataNewRow(ABDainoDataEntity.GYOSEIKUMEI) = csAtenaRow(ABAtenaEntity.GYOSEIKUMEI);
                        // ’n‹æƒR[ƒh‚P
                        csDataNewRow(ABDainoDataEntity.CHIKUCD1) = csAtenaRow(ABAtenaEntity.CHIKUCD1);
                        // ’n‹æ–¼‚P
                        csDataNewRow(ABDainoDataEntity.CHIKUMEI1) = csAtenaRow(ABAtenaEntity.CHIKUMEI1);
                        // ’n‹æƒR[ƒh‚Q
                        csDataNewRow(ABDainoDataEntity.CHIKUCD2) = csAtenaRow(ABAtenaEntity.CHIKUCD2);
                        // ’n‹æ–¼‚Q
                        csDataNewRow(ABDainoDataEntity.CHIKUMEI2) = csAtenaRow(ABAtenaEntity.CHIKUMEI2);
                        // ’n‹æƒR[ƒh‚R
                        csDataNewRow(ABDainoDataEntity.CHIKUCD3) = csAtenaRow(ABAtenaEntity.CHIKUCD3);
                        // ’n‹æ–¼‚R
                        csDataNewRow(ABDainoDataEntity.CHIKUMEI3) = csAtenaRow(ABAtenaEntity.CHIKUMEI3);
                        // —X•Ö”Ô†
                        strYubinNO = Conversions.ToString(csAtenaRow(ABAtenaEntity.YUBINNO)).Trim;
                        if (3 < strYubinNO.RLength)
                        {
                            csDataNewRow(ABDainoDataEntity.DISP_YUBINNO) = strYubinNO.RSubstring(0, 3) + "-" + strYubinNO.RSubstring(3);
                        }
                        else
                        {
                            csDataNewRow(ABDainoDataEntity.DISP_YUBINNO) = strYubinNO;
                        }
                        // •\Ž¦—p•ÒWZŠ
                        csDataNewRow(ABDainoDataEntity.DISP_HENSHUJUSHO) = csAtena1Entity.Tables(ABAtena1Entity.TABLE_NAME).Rows(0)(ABAtena1Entity.HENSHUJUSHO);
                        csDataNewRow(ABDainoDataEntity.KOSHINUSER) = csDataRow(ABAtenaEntity.KOSHINUSER);
                        csDataNewRow(ABDainoDataEntity.MYNUMBER) = csAtenaRow(ABMyNumberEntity.MYNUMBER);
                        csDataNewRow(ABDainoDataEntity.ATENADATAKB) = csAtenaRow(ABAtenaEntity.ATENADATAKB);

                        // ”õlƒ}ƒXƒ^‚ðŽæ“¾
                        csBikoDataSet = cABBikoB.SelectByKey(ABBikoEntity.DEFAULT.BIKOKBN.DAINO, csDataRow(ABDainoSfskRuisekiEntity.JUMINCD).ToString(), csDataRow(ABDainoSfskRuisekiEntity.GYOMUCD).ToString(), csDataRow(ABDainoSfskRuisekiEntity.GYOMUNAISHU_CD).ToString(), csDataRow(ABDainoSfskRuisekiEntity.TOROKURENBAN).ToString(), csDataRow(ABDainoSfskRuisekiEntity.RRKNO).ToString(), blnSakujoFG);

                        if (csBikoDataSet is not null && 0 < csBikoDataSet.Tables(ABBikoEntity.TABLE_NAME).Rows.Count)
                        {
                            csDataNewRow(ABDainoDataEntity.BIKO) = csBikoDataSet.Tables(ABBikoEntity.TABLE_NAME).Rows(0)(ABBikoEntity.BIKO);
                        }
                        else
                        {
                            csDataNewRow(ABDainoDataEntity.BIKO) = string.Empty;
                        }

                        csDataNewRow(ABDainoDataEntity.CHECK) = false;
                        csDataNewRow(ABDainoDataEntity.JOTAI) = ABDainoSfskShoriMode.Empty.GetHashCode.ToString;
                        csDataNewRow(ABDainoDataEntity.DISP_JOTAI) = string.Empty;
                        csDataNewRow(ABDainoDataEntity.SEIGYOKB) = string.Empty;

                        csDataNewRow(ABDainoDataEntity.TOROKURENBAN) = csDataRow(ABDainoSfskRuisekiEntity.TOROKURENBAN);     // “o˜^˜A”Ô
                        csDataNewRow(ABDainoDataEntity.RRKNO) = csDataRow(ABDainoSfskRuisekiEntity.RRKNO);                   // —š—ð”Ô†
                        csDataNewRow(ABDainoDataEntity.SHIKUCHOSONCD) = string.Empty;                                        // Žs‹æ’¬‘ºƒR[ƒg
                        csDataNewRow(ABDainoDataEntity.MACHIAZACD) = string.Empty;                                           // ’¬ŽšƒR[ƒh
                        csDataNewRow(ABDainoDataEntity.TODOFUKEN) = string.Empty;                                            // “s“¹•{Œ§

                        csDataNewRow(ABDainoDataEntity.SHORINICHIJI) = csDataRow(ABDainoSfskRuisekiEntity.SHORINICHIJI);     // ˆ—“úŽž
                        csDataNewRow(ABDainoDataEntity.ZENGOKB) = csDataRow(ABDainoSfskRuisekiEntity.ZENGOKB);               // ‘OŒã‹æ•ª
                    }
                    catch
                    {
                        // ‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                        throw;
                    }


                    // íœƒtƒ‰ƒO
                    csDataNewRow(ABDainoDataEntity.SAKUJOFG) = csDataRow(ABDainoSfskRuisekiEntity.SAKUJOFG);

                    // XVƒJƒEƒ“ƒ^
                    csDataNewRow(ABDainoDataEntity.KOSHINCOUNTER) = csDataRow(ABDainoSfskRuisekiEntity.KOSHINCOUNTER);

                    csReturnDataset.Tables(ABDainoDataEntity.TABLE_NAME).Rows.Add(csDataNewRow);

                }
                csReturnDataset.AcceptChanges();
            }

            catch (UFAppException cfAppExp)
            {

                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLogClass.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + default
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 104767


                Input:
                " + cfAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 104862


                Input:
                " + cfAppExp.Message + "z")

                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 105120


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 105203


                Input:
                " + Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                        "yƒGƒ‰[“à—e:" + csExp.Message + "z")

                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return csReturnDataset

                    End Function
                #End Region

                #Region "‘ã”[‘—•tæ—ÝÏ—š—ðƒf[ƒ^ƒJƒ‰ƒ€ì¬"

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼      ƒf[ƒ^ƒJƒ‰ƒ€ì¬
                    '* 
                    '* \•¶            Private Function CreateColumnsABSfskRirekiData() As DataTable
                    '* 
                    '* ‹@”\@@        ‘—•tæ—š—ðî•ñƒZƒbƒVƒ‡ƒ“‚ÌƒJƒ‰ƒ€’è‹`‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           ‚È‚µ
                    '* 
                    '* –ß‚è’l         DataTable() ‘ã”[—š—ðî•ñƒe[ƒuƒ‹
                    '************************************************************************************************
                    Private Function CreateColumnsABSfskRirekiData() As DataTable
                        Const THIS_METHOD_NAME As String = "CreateColumnsABSfskRirekiData"
                        Dim csDataTable As DataTable
                        Dim csDataColumn As DataColumn
                        Dim csDataPrimaryKey(8) As DataColumn               'ŽåƒL[

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ‘—•tæî•ñƒJƒ‰ƒ€’è‹`
                            csDataTable = New DataTable()
                            csDataTable.TableName = ABSfskDataEntity.TABLE_NAME
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.JUMINCD, System.Type.GetType("System.String"))
                            csDataColumn.AllowDBNull = False
                            csDataColumn.MaxLength = 15
                            csDataPrimaryKey(0) = csDataColumn              'ŽåƒL[‡@@Z–¯ƒR[ƒh
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SHICHOSONCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 6
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.KYUSHICHOSONCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 6
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.GYOMUCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2
                            csDataColumn.AllowDBNull = False
                            csDataPrimaryKey(1) = csDataColumn              'ŽåƒL[‡A@‹Æ–±ƒR[ƒh
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.GYOMUMEISHO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 15
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.GYOMUMEISHORYAKU, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 3
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.GYOMUNAISHUCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn.AllowDBNull = False
                            csDataPrimaryKey(2) = csDataColumn              'ŽåƒL[‡B@‹Æ–±“àŽíƒR[ƒh
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.STYMD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn.AllowDBNull = False
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.EDYMD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn.AllowDBNull = False
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKDATAKB, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKKANNAiKANGAIKB, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKKANNAIKANGAIMEI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKKANAMEISHO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 120        '60
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKKANJIMEISHO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 480        '40
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKYUBINNO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 7
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKZJUSHOCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 13
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKJUSHO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 200         '30
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKBANCHI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 200         '20
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.BANCHICD1, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 5
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.BANCHICD2, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 5
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.BANCHICD3, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 5
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKKATAGAKI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1200         '30
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKRENRAKUSAKI1, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 15
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKRENRAKUSAKI2, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 15
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKGYOSEIKUCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 9
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKGYOSEIKUMEI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 30
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKCHIKUCD1, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKCHIKUMEI1, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 120
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKCHIKUCD2, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKCHIKUMEI2, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 120
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKCHIKUCD3, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKCHIKUMEI3, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 120
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SAKUJOFG, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.KOSHINCOUNTER, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 10
                            ' XVƒ†[ƒU[
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.KOSHINUSER, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 32

                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.DISP_STYMD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 9
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.DISP_EDYMD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 9

                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.BIKO, GetType(String))
                            csDataColumn.DefaultValue = String.Empty

                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.CHECK, GetType(String))
                            csDataColumn.DefaultValue = Boolean.FalseString
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.JOTAI, GetType(String))
                            csDataColumn.DefaultValue = String.Empty
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.DISP_JOTAI, GetType(String))
                            csDataColumn.DefaultValue = String.Empty
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.DAINOKB, GetType(String))
                            csDataColumn.DefaultValue = String.Empty
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.DISP_DAINOKB, GetType(String))
                            csDataColumn.DefaultValue = String.Empty
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.DAINOJUMINCD, GetType(String))
                            csDataColumn.DefaultValue = String.Empty
                            csDataPrimaryKey(3) = csDataColumn              'ŽåƒL[‡C@‘ã”[Z–¯ƒR[ƒh
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SEIGYOKB, GetType(String))
                            csDataColumn.DefaultValue = String.Empty

                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.TOROKURENBAN, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 10
                            csDataPrimaryKey(4) = csDataColumn              'ŽåƒL[‡D@“o˜^˜A”Ô
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.RRKNO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 10
                            csDataPrimaryKey(5) = csDataColumn              'ŽåƒL[‡E@—š—ð”Ô†
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKKBN, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SFSKKATAGAKICD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 20
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SHIKUCHOSONCD, GetType(String))
                            csDataColumn.DefaultValue = 6
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.MACHIAZACD, GetType(String))
                            csDataColumn.DefaultValue = 7
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.TODOFUKEN, GetType(String))
                            csDataColumn.DefaultValue = 16
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SHIKUCHOSON, GetType(String))
                            csDataColumn.DefaultValue = 48
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.MACHIAZA, GetType(String))
                            csDataColumn.DefaultValue = 480
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.SHORINICHIJI, GetType(String))
                            csDataColumn.DefaultValue = 17
                            csDataPrimaryKey(6) = csDataColumn              'ŽåƒL[‡F@ˆ—“úŽž
                            csDataColumn = csDataTable.Columns.Add(ABSfskDataEntity.ZENGOKB, GetType(String))
                            csDataColumn.DefaultValue = 1
                            csDataPrimaryKey(7) = csDataColumn              'ŽåƒL[‡G@‘OŒã‹æ•ª

                            csDataTable.PrimaryKey = csDataPrimaryKey       'ŽåƒL[

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)


                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return csDataTable

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼      ƒf[ƒ^ƒJƒ‰ƒ€ì¬
                    '* 
                    '* \•¶            Private Function CreateColumnsABDainoRirekiData() As DataTable
                    '* 
                    '* ‹@”\@@        ‘ã”[—š—ðî•ñƒZƒbƒVƒ‡ƒ“‚ÌƒJƒ‰ƒ€’è‹`‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           ‚È‚µ
                    '* 
                    '* –ß‚è’l         DataTable() ‘ã”[—š—ðî•ñƒe[ƒuƒ‹
                    '************************************************************************************************
                    Private Function CreateColumnsABDainoRirekiData() As DataTable
                        Const THIS_METHOD_NAME As String = "CreateColumnsABDainoRirekiData"
                        Dim csDataTable As DataTable
                        Dim csDataColumn As DataColumn
                        Dim csDataPrimaryKey(8) As DataColumn               'ŽåƒL[

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ‘ã”[î•ñƒJƒ‰ƒ€’è‹`
                            csDataTable = New DataTable
                            csDataTable.TableName = ABDainoDataEntity.TABLE_NAME
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.JUMINCD, System.Type.GetType("System.String"))
                            csDataColumn.AllowDBNull = False
                            csDataColumn.MaxLength = 15
                            csDataPrimaryKey(0) = csDataColumn              'ŽåƒL[‡@@Z–¯ƒR[ƒh
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.SHICHOSONCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 6
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.KYUSHICHOSONCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 6
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.GYOMUCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2
                            csDataColumn.AllowDBNull = False
                            csDataPrimaryKey(1) = csDataColumn              'ŽåƒL[‡A@‹Æ–±ƒR[ƒh
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.GYOMUMEISHO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 15
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.GYOMUMEISHORYAKU, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 3
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.GYOMUNAISHUCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn.AllowDBNull = False
                            csDataPrimaryKey(2) = csDataColumn              'ŽåƒL[‡B@‹Æ–±“àŽíƒR[ƒh
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.DAINOJUMINCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 15
                            csDataColumn.AllowDBNull = False
                            csDataPrimaryKey(3) = csDataColumn              'ŽåƒL[‡C@‘ã”[Z–¯ƒR[ƒh
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.STYMD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.EDYMD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.DAINOKB, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.DAINOKBMEISHO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 10
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.DAINOKBRYAKUMEI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 5
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.JUMINSHUMEISHO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.KANASHIMEI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 240
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.KANJISHIMEI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 480
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.KANNAIKANGAIMEISHO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.YUBINNO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 7
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.JUSHOCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 13
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.JUSHO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 200
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.BANCHICD1, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 5
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.BANCHICD2, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 5
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.BANCHICD3, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 5
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.BANCHI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 200
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.KATAGAKIFG, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.KATAGAKICD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 20
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.KATAGAKI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1200
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.RENRAKUSAKI1, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 15
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.RENRAKUSAKI2, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 15
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.GYOSEIKUCD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 9
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.GYOSEIKUMEI, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 30
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.CHIKUCD1, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.CHIKUMEI1, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 120
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.CHIKUCD2, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.CHIKUMEI2, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 120
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.CHIKUCD3, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.CHIKUMEI3, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 120
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.SAKUJOFG, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 1
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.KOSHINCOUNTER, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 10
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.DISP_STYMD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 9
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.DISP_EDYMD, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 9
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.DISP_YUBINNO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 8
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.DISP_HENSHUJUSHO, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 160
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.KOSHINUSER, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 32
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.MYNUMBER, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 13
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.ATENADATAKB, System.Type.GetType("System.String"))
                            csDataColumn.MaxLength = 2
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.BIKO, GetType(String))
                            csDataColumn.DefaultValue = String.Empty
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.CHECK, GetType(String))
                            csDataColumn.DefaultValue = Boolean.FalseString
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.JOTAI, GetType(String))
                            csDataColumn.DefaultValue = String.Empty
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.DISP_JOTAI, GetType(String))
                            csDataColumn.DefaultValue = String.Empty
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.SEIGYOKB, GetType(String))
                            csDataColumn.DefaultValue = String.Empty

                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.SFSKZJUSHOCD, GetType(String))
                            csDataColumn.DefaultValue = 13
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.TOROKURENBAN, GetType(String))
                            csDataColumn.DefaultValue = 10
                            csDataPrimaryKey(4) = csDataColumn              'ŽåƒL[‡D@“o˜^˜A”Ô
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.RRKNO, GetType(String))
                            csDataColumn.DefaultValue = 10
                            csDataPrimaryKey(5) = csDataColumn              'ŽåƒL[‡E@—š—ð”Ô†
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.SHIKUCHOSONCD, GetType(String))
                            csDataColumn.DefaultValue = 10
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.MACHIAZACD, GetType(String))
                            csDataColumn.DefaultValue = 10
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.TODOFUKEN, GetType(String))
                            csDataColumn.DefaultValue = 10
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.SHORINICHIJI, GetType(String))
                            csDataColumn.DefaultValue = 17
                            csDataPrimaryKey(6) = csDataColumn              'ŽåƒL[‡F@ˆ—“úŽž
                            csDataColumn = csDataTable.Columns.Add(ABDainoDataEntity.ZENGOKB, GetType(String))
                            csDataColumn.DefaultValue = 1
                            csDataPrimaryKey(7) = csDataColumn              'ŽåƒL[‡G@‘OŒã‹æ•ª

                            csDataTable.PrimaryKey = csDataPrimaryKey       'ŽåƒL[

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)


                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return csDataTable

                    End Function
                #End Region
                    '*—š—ð”Ô† 000003 2023/10/25 ’Ç‰ÁI—¹
                #End Region

                End Class

                 */
            }

            return default;
        }
    }
}