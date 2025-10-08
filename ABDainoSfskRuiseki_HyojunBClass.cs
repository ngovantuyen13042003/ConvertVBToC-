// ************************************************************************************************
// * ‹Æ–±–¼           ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼         ‚`‚a‘ã”[‘—•tæˆÙ“®—ÝÏ_•W€ƒ}ƒXƒ^‚c‚`
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯           2023/10/25
// *
// * ì¬ŽÒ           Œ©é@Œ[Žl˜Y
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// *  C³—š—ð@ —š—ð”Ô†@@C³“à—e
// * 2024/06/10  000001     yAB-9902-1z•s‹ï‡‘Î‰ž
// ************************************************************************************************
using System.Data;
using System.Linq;
using System.Text;

namespace Densan.Reams.AB.AB000BB
{

    // ************************************************************************************************
    // *
    // * ‘ã”[‘—•tæˆÙ“®—ÝÏ_•W€ƒ}ƒXƒ^Žæ“¾AXVŽž‚ÉŽg—p‚·‚éƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
    // *
    // ************************************************************************************************
    public class ABDainoSfskRuiseki_HyojunBClass
    {

        #region ƒƒ“

        // @ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABDainoSfskRuiseki_HyojunBClass";     // ƒNƒ‰ƒX–¼
        private const string THIS_BUSINESSID = "AB";                                  // ‹Æ–±ƒR[ƒh
        private const string ZENGOKB_ZEN = "1";                                       // ‘OŒã‹æ•ª@‘O
        private const string ZENGOKB_GO = "2";                                        // ‘OŒã‹æ•ª@Œã
        private const string SAKUJOFG_SAKUJO = "1";                                   // íœƒtƒ‰ƒO@íœ
        private const string FORMAT_UPDATETIME = "yyyyMMddHHmmssfff";

        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        private UFLogClass m_cfLogClass;                                              // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                                        // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;                                // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                                              // ‚q‚c‚aƒNƒ‰ƒX
        private string m_strInsertSQL;                                                // INSERT—pSQL
        private UFErrorClass m_cfErrorClass;                                          // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private UFDateClass m_cfDateClass;                                            // “ú•tƒNƒ‰ƒX
        private DataSet m_csDataSchma;                                                // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private DataSet m_csDataSchmaHyojun;                                          // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private UFParameterCollectionClass m_cfSelectUFParameterCollectionClass;      // SELECT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;      // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private USSCityInfoClass m_cUSSCityInfoClass;                                 // Žs’¬‘ºî•ñŠÇ—ƒNƒ‰ƒX

        #endregion

        #region ƒRƒ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // *                               ByVal cfConfigDataClass As UFConfigDataClass, 
        // *                               ByVal cfRdbClass As UFRdbClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABDainoSfskRuiseki_HyojunBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)
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

            // AB‘ã”[‘—•tæ—ÝÏ_•W€ƒ}ƒXƒ^‚ÌƒXƒL[ƒ}Žæ“¾
            m_csDataSchmaHyojun = m_cfRdbClass.GetTableSchemaNoRestriction("SELECT * FROM " + ABDainoSfskRuisekiHyojunEntity.TABLE_NAME, ABDainoSfskRuisekiHyojunEntity.TABLE_NAME, false);

        }
        #endregion

        #region ƒƒ\ƒbƒh

        #region ‘ã”
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[‘—•tæˆÙ“®—ÝÏ_•W€ƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertDainoSfskB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\           ‘ã”[‘—•tæˆÙ“®—ÝÏ_•W€ƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á
        // * 
        // * ˆø”           csDataRow As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertDainoSfskB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "InsertDainoSfskB";
            int intInsCnt;                            // ’Ç‰ÁŒ”
            string strUpdateDateTime;

            try
            {

                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strInsertSQL is null || string.IsNullOrEmpty(m_strInsertSQL) || m_cfInsertUFParameterCollectionClass is null)
                {
                    CreateSQL(csDataRow);
                }

                // XV“úŽž‚ÌŽæ“¾
                strUpdateDateTime = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME);  // ì¬“úŽž

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABDainoSfskRuisekiHyojunEntity.TANMATSUID) = m_cfControlData.m_strClientId;  // ’[––‚h‚c
                csDataRow(ABDainoSfskRuisekiHyojunEntity.KOSHINCOUNTER) = decimal.Zero;                // XVƒJƒEƒ“ƒ^
                csDataRow(ABDainoSfskRuisekiHyojunEntity.SAKUSEINICHIJI) = strUpdateDateTime;          // ì¬“úŽž
                csDataRow(ABDainoSfskRuisekiHyojunEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;   // ì¬ƒ†[ƒU[
                csDataRow(ABDainoSfskRuisekiHyojunEntity.KOSHINNICHIJI) = strUpdateDateTime;           // XV“úŽž
                csDataRow(ABDainoSfskRuisekiHyojunEntity.KOSHINUSER) = m_cfControlData.m_strUserId;    // XVƒ†[ƒU[

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    cfParam.Value = csDataRow(cfParam.ParameterName.RSubstring(ABDainoSfskRuisekiHyojunEntity.PARAM_PLACEHOLDER.RLength)).ToString();

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 8253


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(
                                                                                m_strInsertSQL, m_cfInsertUFParameterCollectionClass) + "z")

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9084


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9180


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9438


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9521


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
        // * ‹@”\           INSERT‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void CreateSQL(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "CreateSQL";
            UFParameterClass cfUFParameterClass;
            StringBuilder strInsertColumn;                 // INSERT—pƒJƒ‰ƒ€’è‹`
            StringBuilder strInsertParam;                  // INSERT—pƒpƒ‰ƒ[ƒ^’è‹`


            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // INSERT SQL•¶‚Ìì¬
                m_strInsertSQL = "INSERT INTO " + ABDainoSfskRuisekiHyojunEntity.TABLE_NAME + " ";
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

                    strInsertParam.Append(ABDainoSfskRuisekiHyojunEntity.PARAM_PLACEHOLDER);
                    strInsertParam.Append(csDataColumn.ColumnName);
                    strInsertParam.Append(", ");

                    // INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    cfUFParameterClass.ParameterName = ABDainoSfskRuisekiHyojunEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
                    m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass);


                }

                // ÅŒã‚ÌƒJƒ“ƒ}‚ðŽæ‚èœ‚¢‚ÄINSERT•¶‚ðì¬
                m_strInsertSQL += "(" + strInsertColumn.ToString().TrimEnd().TrimEnd(",".ToCharArray()) + ")" + " VALUES (" + strInsertParam.ToString().TrimEnd().TrimEnd(",".ToCharArray()) + ")";

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13038


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13134


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13392


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13475


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw;
            }

        }
        #endregion

        #region ‘ã”
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[‘—•tæ—ÝÏ_•W€ƒf[ƒ^ì¬
        // * 
        // * \•¶           Public Function CreateDainoSfskData(ByVal csDataRow As DataRow, _
        // *                                                    ByVal strShoriKB As String, _
        // *                                                    ByVal strShoriNichiji As String) As Integer
        // * 
        // * ‹@”\           ‘ã”[‘—•tæ—ÝÏƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow      : ‘ã”[‘—•tæƒf[ƒ^
        // *                strShoriKB As String      : ˆ—‹æ•ª
        // *                strShoriNichiji As String : ˆ—“úŽž
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int CreateDainoSfskData(DataRow csDataRow, string strShoriKB, string strShoriNichiji)
        {
            int intInsCnt;
            ABSfsk_HyojunBClass cSfskHyojunB;               // ‘—•tæ‚c‚`ƒNƒ‰ƒX
            DataSet csSfskHyojun;                           // ‘—•tæ‚c‚`ƒNƒ‰ƒX

            const string THIS_METHOD_NAME = "CreateDainoSfskData";

            try
            {

                // ‘—•tæ_•W€‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cSfskHyojunB = new ABSfsk_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);

                // ‘—•tæ_•W€‚ÌŽæ“¾
                csSfskHyojun = cSfskHyojunB.GetSfskBHoshu(csDataRow(ABSfskEntity.JUMINCD).ToString(), csDataRow(ABSfskEntity.GYOMUCD).ToString(), csDataRow(ABSfskEntity.GYOMUNAISHU_CD).ToString(), csDataRow(ABSfskEntity.TOROKURENBAN).ToString());

                intInsCnt = CreateDainoSfskData(csDataRow, strShoriKB, csSfskHyojun.Tables(ABSfskHyojunEntity.TABLE_NAME).Rows(0), strShoriNichiji);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 16230


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 16326


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 16584


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 16667


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw;
            }

            return intInsCnt;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[‘—•tæ—ÝÏ_•W€ƒf[ƒ^ì¬
        // * 
        // * \•¶           Public Function CreateDainoSfskData(ByVal csDataRow As DataRow, _
        // *                                                    ByVal strShoriKB As String, _
        // *                                                    ByVal csABSfskHyojunDataRow As DataRow, _
        // *                                                    ByVal strShoriNichiji As String) As Integer
        // * 
        // * ‹@”\@@    @ ‘ã”[‘—•tæ—ÝÏ_•W€ƒf[ƒ^‚ðì¬‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow              : ‘ã”[‘—•tæƒf[ƒ^
        // *                strShoriKB As String              : ˆ—‹æ•ª
        // *                csABSfskHyojunDataRow As DataRow  : AB‘—•tæ_•W€ƒf[ƒ^iDataRowŒ`Ž®j
        // *                strShoriNichiji As String         : ˆ—“úŽž
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int CreateDainoSfskData(DataRow csDataRow, string strShoriKB, DataRow csABSfskHyojunDataRow, string strShoriNichiji)
        {
            const string THIS_METHOD_NAME = "CreateDainoSfskData";
            DataSet csDataSet;
            DataSet csDataSetHyojun;
            DataRow csRuisekiDR;
            DataColumn csDataColumn;
            // Dim strSystemDate As String                 ' ƒVƒXƒeƒ€“ú•t
            int intInsCnt;
            DataRow csOriginalDR;
            DataRow csOriginalHyojunDR;
            DataRow csDainoSfskRuisekiHyojunDR;
            int intUpdataCount_zen;
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            var cuCityInfo = new USSCityInfoClass();            // Žs’¬‘ºî•ñŠÇ—ƒNƒ‰ƒX

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // strSystemDate = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME)

                // ƒXƒL[ƒ}‚ðŽæ“¾
                csDataSet = m_csDataSchma.Clone();
                csDataSetHyojun = m_csDataSchmaHyojun.Clone();

                // XV—pƒf[ƒ^‚ÌDataRow‚ðì¬
                csDainoSfskRuisekiHyojunDR = csDataSetHyojun.Tables(ABDainoSfskRuisekiHyojunEntity.TABLE_NAME).NewRow;

                // ***
                // * ‘ã”[‘—•tæ—ÝÏ_•W€(‘O)•ÒWˆ—
                // *

                if (strShoriKB != ABConstClass.SFSK_ADD)
                {

                    // ‘ã”[‘—•tæ—ÝÏƒf[ƒ^‚ðì¬
                    csOriginalDR = csDataSet.Tables(ABDainoSfskRuisekiEntity.TABLE_NAME).NewRow;
                    // ‘ã”[‘—•tæ—ÝÏ_•W€ƒf[ƒ^‚ðì¬
                    csOriginalHyojunDR = csDataSetHyojun.Tables(ABDainoSfskRuisekiHyojunEntity.TABLE_NAME).NewRow;

                    // ˆ—‹æ•ª‚ª’Ç‰ÁˆÈŠO‚Ìê‡
                    if (csDataRow.HasVersion(DataRowVersion.Original))
                    {

                        // C³‘Oî•ñ‚ªŽc‚Á‚Ä‚¢‚éê‡A‘ã”[‘—•tæ—ÝÏƒf[ƒ^‚ðì¬
                        csOriginalDR = csDataSet.Tables(ABDainoSfskRuisekiEntity.TABLE_NAME).NewRow;

                        foreach (DataColumn currentCsDataColumn in csDataRow.Table.Columns)
                        {
                            csDataColumn = currentCsDataColumn;
                            if (!(csDataColumn.ColumnName == ABDainoEntity.RESERVE) && !(csDataColumn.ColumnName == ABSfskDataEntity.SFSKDATAKB))
                            {
                                csOriginalDR[csDataColumn.ColumnName] = csDataRow[csDataColumn.ColumnName, DataRowVersion.Original];
                            }
                        }

                        // ‘ã”[‘—•tæ—ÝÏ_•W€ƒf[ƒ^‚ðì¬
                        csOriginalHyojunDR = csDataSetHyojun.Tables(ABDainoSfskRuisekiHyojunEntity.TABLE_NAME).NewRow;

                        foreach (DataColumn currentCsDataColumn1 in csABSfskHyojunDataRow.Table.Columns)
                        {
                            csDataColumn = currentCsDataColumn1;
                            if (!(csDataColumn.ColumnName == ABSfskHyojunEntity.SFSKBANCHICD1) && !(csDataColumn.ColumnName == ABSfskHyojunEntity.SFSKBANCHICD2) && !(csDataColumn.ColumnName == ABSfskHyojunEntity.SFSKBANCHICD3) && !(csDataColumn.ColumnName == ABSfskHyojunEntity.SFSKKATAGAKICD))
                            {

                                csOriginalHyojunDR[csDataColumn.ColumnName] = csABSfskHyojunDataRow[csDataColumn.ColumnName, DataRowVersion.Original];
                            }
                        }

                        // (‘O)ƒf[ƒ^‚ÌƒZƒbƒg
                        csOriginalHyojunDR = SetDainoSfskRuisekiHyojunData(csOriginalDR, csOriginalHyojunDR, csDainoSfskRuisekiHyojunDR);

                        // ‹¤’Ê€–Ú‚ÌƒZƒbƒg
                        csOriginalHyojunDR(ABDainoSfskRuisekiHyojunEntity.SHORINICHIJI) = strShoriNichiji;                 // ˆ—“úŽž
                        csOriginalHyojunDR(ABDainoSfskRuisekiHyojunEntity.SHORIKB) = strShoriKB;                           // ˆ—‹æ•ª
                        csOriginalHyojunDR(ABDainoSfskRuisekiHyojunEntity.ZENGOKB) = ZENGOKB_ZEN;                          // ‘OŒã‹æ•ª

                        // íœƒtƒ‰ƒO‚ÌÝ’è
                        csOriginalHyojunDR(ABDainoSfskRuisekiHyojunEntity.SAKUJOFG) = csDataRow(ABSfskEntity.SAKUJOFG, DataRowVersion.Original);

                        // ƒf[ƒ^ƒZƒbƒg‚ÉC³‘Oî•ñ‚ð’Ç‰Á
                        csDataSetHyojun.Tables(ABDainoSfskRuisekiHyojunEntity.TABLE_NAME).Rows.Add(csOriginalHyojunDR);

                        // ‘ã”[‘—•tæ—ÝÏ(‘O)ƒ}ƒXƒ^’Ç‰Áˆ—
                        intUpdataCount_zen = this.InsertDainoSfskB(csDataSetHyojun.Tables(ABDainoSfskRuisekiHyojunEntity.TABLE_NAME).Rows(0));

                        // XVŒ”‚ª‚PŒˆÈŠO‚Ìê‡AƒGƒ‰[‚ð”­¶‚³‚¹‚é
                        if (!(intUpdataCount_zen == 1))
                        {
                            m_cfErrorClass = new UFErrorClass(m_cfControlData.m_strBusinessId);
                            // ƒGƒ‰[’è‹`‚ðŽæ“¾iŠù‚É“¯ˆêƒf[ƒ^‚ª‘¶Ý‚µ‚Ü‚·BF‘ã”[‘—•tæ—ÝÏj
                            objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001044);
                            throw new UFAppException(objErrorStruct.m_strErrorMessage + "‘ã");
                        }

                        // ƒf[ƒ^ƒZƒbƒg‚ÌƒNƒŠƒA
                        csDataSetHyojun.Clear();
                    }
                    else
                    {

                    }
                }
                else
                {

                }

                // ***
                // * ‘ã”[‘—•tæ—ÝÏ_•W€(Œã)•ÒWˆ—@’Ç‰Á‚Ìê‡‚à‚±‚¿‚ç
                // *
                // ‘ã”[‘—•tæ—ÝÏ_•W€ƒf[ƒ^‚ðì¬
                csRuisekiDR = csDataSetHyojun.Tables(ABDainoSfskRuisekiHyojunEntity.TABLE_NAME).NewRow;

                // ‹¤’Ê€–Ú‚ÌƒZƒbƒg
                csRuisekiDR = SetDainoSfskRuisekiHyojunData(csDataRow, csABSfskHyojunDataRow, csDainoSfskRuisekiHyojunDR);

                // ƒf[ƒ^ƒZƒbƒg@@
                csRuisekiDR(ABDainoSfskRuisekiHyojunEntity.SHORINICHIJI) = strShoriNichiji;            // ˆ—“úŽž
                csRuisekiDR(ABDainoSfskRuisekiHyojunEntity.SHORIKB) = strShoriKB;                      // ˆ—‹æ•ª
                csRuisekiDR(ABDainoSfskRuisekiHyojunEntity.ZENGOKB) = ZENGOKB_GO;                      // ‘OŒã‹æ•ª
                                                                                                       // íœƒtƒ‰ƒO
                if (strShoriKB == ABConstClass.SFSK_DELETE)
                {
                    // íœ‚Ìê‡‚Í"1"‚ðƒZƒbƒg
                    csRuisekiDR(ABDainoSfskRuisekiHyojunEntity.SAKUJOFG) = SAKUJOFG_SAKUJO;
                }
                else
                {
                    // ‚»‚êˆÈŠO‚Ìê‡‚Í‘—•tæ‚Ì’l‚ð‚»‚Ì‚Ü‚ÜƒZƒbƒg
                    csRuisekiDR(ABDainoSfskRuisekiHyojunEntity.SAKUJOFG) = csDataRow(ABSfskEntity.SAKUJOFG);
                }

                csDataSetHyojun.Tables(ABDainoSfskRuisekiHyojunEntity.TABLE_NAME).Rows.Add(csRuisekiDR);

                // ***
                // * ‘ã”[‘—•tæ—ÝÏ_•W€(Œã)ƒ}ƒXƒ^’Ç‰Áˆ—
                // *
                intInsCnt = InsertDainoSfskB(csDataSetHyojun.Tables(ABDainoSfskRuisekiHyojunEntity.TABLE_NAME).Rows(0));

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 25868


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 25964


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 26222


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 26305


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw;
            }

            return intInsCnt;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[‘—•tæ—ÝÏ_•W€ƒf[ƒ^•ÒWˆ—
        // * 
        // * \•¶           Private Function SetDainoSfskRuisekiHyojunData(ByVal csSfskDataRow As DataRow,
        // *                                                               ByVal csSfskHyojunDataRow As DataRow,
        // *                                                               ByVal csReturnDataRow As DataRow) As DataRow
        // * 
        // * ‹@”\@@    @ ‘ã”[‘—•tæ—ÝÏ_•W€ƒf[ƒ^‚ð•ÒW‚·‚é
        // * 
        // * ˆø”           csSfskDataRow As DataRow            : ‘—•tæƒf[ƒ^
        // *                csSfskHyojunDataRow As DataRow      : ‘—•tæ_•W€ƒf[ƒ^
        // *                csReturnDataRow                     : –ß‚è’l
        // * 
        // * –ß‚è’l         DataRow : •ÒW‚µ‚½ƒf[ƒ^
        // ************************************************************************************************
        private DataRow SetDainoSfskRuisekiHyojunData(DataRow csSfskDataRow, DataRow csSfskHyojunDataRow, DataRow csReturnDataRow)
        {
            const string THIS_METHOD_NAME = "SetDainoSfskRuisekiHyojunData";

            // Žs’¬‘ºî•ñŠÇ—ƒNƒ‰ƒX‚ÌÝ’è
            m_cUSSCityInfoClass = new USSCityInfoClass();
            m_cUSSCityInfoClass.GetCityInfo(m_cfControlData);

            try
            {
                // ‹¤’Ê€–Ú@¦ˆ—“úŽžAˆ—‹æ•ªA‘OŒã‹æ•ªAíœƒtƒ‰ƒO‚ÍŒÄo‚µŒ³‚ÅƒZƒbƒg‚·‚é
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.JUMINCD) = csSfskDataRow(ABSfskEntity.JUMINCD);                                           // Z–¯ƒR[ƒh
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SHICHOSONCD) = m_cUSSCityInfoClass.p_strShichosonCD(0);                                   // Žs’¬‘ºƒR[ƒh
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.KYUSHICHOSONCD) = m_cUSSCityInfoClass.p_strShichosonCD(0);                                // ‹ŒŽs’¬‘ºƒR[ƒh

                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.GYOMUCD) = csSfskDataRow(ABSfskEntity.GYOMUCD);                                           // ‹Æ–±ƒR[ƒh
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.GYOMUNAISHU_CD) = csSfskDataRow(ABSfskEntity.GYOMUNAISHU_CD);                             // ‹Æ–±“àŽí•ÊƒR[ƒh
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.TOROKURENBAN) = csSfskDataRow(ABSfskEntity.TOROKURENBAN);                                 // “o˜^˜A”Ô
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.STYMD) = csSfskDataRow(ABSfskEntity.STYMD);                                               // ŠJŽn”NŒŽ“ú
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.EDYMD) = csSfskDataRow(ABSfskEntity.EDYMD);                                               // I—¹”NŒŽ“ú
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.RRKNO) = csSfskDataRow(ABSfskEntity.RRKNO);                                               // —š—ð”Ô†

                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SFSKKANAKATAGAKI) = csSfskHyojunDataRow(ABSfskHyojunEntity.SFSKKANAKATAGAKI);             // ‘—•tæ•û‘ƒtƒŠƒKƒi
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SFSKTSUSHO) = csSfskHyojunDataRow(ABSfskHyojunEntity.SFSKTSUSHO);                         // ‘—•tæŽ–¼_’ÊÌ
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SFSKKANATSUSHO) = csSfskHyojunDataRow(ABSfskHyojunEntity.SFSKKANATSUSHO);                 // ‘—•tæŽ–¼_’ÊÌ_ƒtƒŠƒKƒi
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SFSKSHIMEIYUSENKB) = csSfskHyojunDataRow(ABSfskHyojunEntity.SFSKSHIMEIYUSENKB);           // ‘—•tæŽ–¼_—Dæ‹æ•ª
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SFSKEIJISHIMEI) = csSfskHyojunDataRow(ABSfskHyojunEntity.SFSKEIJISHIMEI);                 // ‘—•tæŽ–¼_ŠO‘l‰pŽš
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SFSKKANJISHIMEI) = csSfskHyojunDataRow(ABSfskHyojunEntity.SFSKKANJISHIMEI);               // ‘—•tæŽ–¼_ŠO‘lŠ¿Žš
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SFSKSHINSEISHAMEI) = csSfskHyojunDataRow(ABSfskHyojunEntity.SFSKSHINSEISHAMEI);           // ‘—•tæ\¿ŽÒ–¼
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SFSKSHINSEISHAKANKEICD) = csSfskHyojunDataRow(ABSfskHyojunEntity.SFSKSHINSEISHAKANKEICD); // ‘—•tæ\¿ŽÒŠÖŒWƒR[ƒh
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SFSKSHIKUCHOSONCD) = csSfskHyojunDataRow(ABSfskHyojunEntity.SFSKSHIKUCHOSONCD);           // ‘—•tæ_Žs‹æ’¬‘ºƒR[ƒh
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SFSKMACHIAZACD) = csSfskHyojunDataRow(ABSfskHyojunEntity.SFSKMACHIAZACD);                 // ‘—•tæ_’¬ŽšƒR[ƒh
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SFSKTODOFUKEN) = csSfskHyojunDataRow(ABSfskHyojunEntity.SFSKTODOFUKEN);                   // ‘—•tæ_“s“¹•{Œ§
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SFSKSHIKUCHOSON) = csSfskHyojunDataRow(ABSfskHyojunEntity.SFSKSHIKUCHOSON);               // ‘—•tæ_Žs‹æŒS’¬‘º–¼
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SFSKMACHIAZA) = csSfskHyojunDataRow(ABSfskHyojunEntity.SFSKMACHIAZA);                     // ‘—•tæ_’¬Žš
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SFSKRENRAKUSAKIKB) = csSfskHyojunDataRow(ABSfskHyojunEntity.SFSKRENRAKUSAKIKB);           // ˜A—æ‹æ•ª
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SFSKKBN) = csSfskHyojunDataRow(ABSfskHyojunEntity.SFSKKBN);                               // ‘—•tæ‹æ•ª
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SFSKTOROKUYMD) = csSfskHyojunDataRow(ABSfskHyojunEntity.SFSKTOROKUYMD);                   // ‘—•tæ“o˜^”NŒŽ“ú
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.RESERVE1) = string.Empty;                                                                 // ƒŠƒU[ƒu‚P
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.RESERVE2) = string.Empty;                                                                 // ƒŠƒU[ƒu‚Q
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.RESERVE3) = string.Empty;                                                                 // ƒŠƒU[ƒu‚R
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.RESERVE4) = string.Empty;                                                                 // ƒŠƒU[ƒu‚S
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.RESERVE5) = string.Empty;                                                                 // ƒŠƒU[ƒu‚T
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                              // ’[––‚h‚c
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SAKUJOFG) = csSfskHyojunDataRow(ABSfskHyojunEntity.SAKUJOFG);                             // íœƒtƒ‰ƒO
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.KOSHINCOUNTER) = decimal.Zero;                                                            // XVƒJƒEƒ“ƒ^
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SAKUSEINICHIJI) = csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SHORINICHIJI);           // ì¬“úŽž
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;                                               // ì¬ƒ†[ƒU[
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.KOSHINNICHIJI) = csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.SHORINICHIJI);            // XV“úŽž
                csReturnDataRow(ABDainoSfskRuisekiHyojunEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                                // XVƒ†[ƒU[
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 34625


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                    "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 34717


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 34971


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                    "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 35050


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                    "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw;
            }

            return csReturnDataRow;

        }

        #endregion

        #region ‘ã”
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[‘—•tæ—ÝÏ_•W€ƒf[ƒ^’Šo
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
        public DataTable GetABDainoSfskRuisekiData(string strJuminCD, string strGyomuCD, string strGyomuNaiShubetsuCD, int intTorokuRenban, string strShoriKB)
        {

            const string THIS_METHOD_NAME = "GetABDainoSfskRuisekiData";
            DataSet csDainoSfskRuisekiHyojunEntity;
            DataRow[] csReturnDataRows;
            DataTable csReturnDatatable;
            var strSQL = new StringBuilder();

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SELECT‹å‚Ì¶¬
                strSQL.Append(CreateSelect());
                // FROM‹å‚Ì¶¬
                strSQL.AppendFormat(" FROM {0} ", ABDainoSfskRuisekiHyojunEntity.TABLE_NAME);
                // ÃÞ°À½·°Ï‚ÌŽæ“¾
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABDainoSfskRuisekiHyojunEntity.TABLE_NAME, false);
                }

                // WHERE‹å‚Ìì¬
                strSQL.Append(CreateWhere(strJuminCD, strGyomuCD, strGyomuNaiShubetsuCD, intTorokuRenban, strShoriKB, THIS_METHOD_NAME));

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 38560


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(
                                                                            strSQL.ToString(), m_cfSelectUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csDainoSfskRuisekiHyojunEntity = m_csDataSchma.Clone();
                csDainoSfskRuisekiHyojunEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csDainoSfskRuisekiHyojunEntity, ABDainoSfskRuisekiHyojunEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);
                // –ß‚è’l—p‚Éƒf[ƒ^‚ðŠi”[
                csReturnDatatable = csDainoSfskRuisekiHyojunEntity.Tables(ABDainoSfskRuisekiHyojunEntity.TABLE_NAME);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 39852


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 39948


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40216


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40299


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csReturnDatatable;

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
                strSELECT.AppendFormat("SELECT {0}", ABDainoSfskRuisekiHyojunEntity.JUMINCD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.SHICHOSONCD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.KYUSHICHOSONCD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.SHORINICHIJI);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.SHORIKB);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.ZENGOKB);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.GYOMUCD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.GYOMUNAISHU_CD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.TOROKURENBAN);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.STYMD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.EDYMD);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.RRKNO);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.SFSKKBN);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.RESERVE1);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.RESERVE2);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.TANMATSUID);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.SAKUJOFG);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.KOSHINCOUNTER);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.SAKUSEINICHIJI);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.SAKUSEIUSER);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.KOSHINNICHIJI);
                strSELECT.AppendFormat(", {0}", ABDainoSfskRuisekiHyojunEntity.KOSHINUSER);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 43916


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 44012


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 44280


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 44363


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
        // *                                             ByVal intTorokuRenban As Integer,
        // *                                             ByVal strShoriKB As String,
        // *                                             ByVal strMethodName As String) As String
        // * 
        // * ‹@”\@@    @ WHERE•ª‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”           strJuminCD             : Z–¯ƒR[ƒh 
        // *                strGyomuCD             : ‹Æ–±ƒR[ƒh
        // *                strGyomuNaiShubetsuCD  : ‹Æ–±“àŽí•ÊƒR[ƒh
        // *                strShoriKB             : ˆ—‹æ•ª@"D"F‘ã”[A"S"F‘—•t
        // *                strMethodName          : ŒÄo‚µŒ³ŠÖ”–¼
        // *
        // * –ß‚è’l         String    :   WHERE‹å
        // ************************************************************************************************
        private string CreateWhere(string strJuminCD, string strGyomuCD, string strGyomuNaiShubetsuCD, int intTorokuRenban, string strShoriKB, string strMethodName)
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
                strWHERE.AppendFormat(" AND {0} = {1}", ABDainoSfskRuisekiEntity.TOROKURENBAN, ABDainoSfskRuisekiEntity.KEY_TOROKURENBAN);
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABDainoSfskRuisekiEntity.KEY_TOROKURENBAN;
                cfUFParameterClass.Value = intTorokuRenban;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);

                // ˆ—‹æ•ª
                // ‘—•t
                strWHERE.AppendFormat(" AND {0} IN ('{1}','{2}','{3}')", ABDainoSfskRuisekiEntity.SHORIKB, ABConstClass.SFSK_ADD, ABConstClass.SFSK_SHUSEI, ABConstClass.SFSK_DELETE);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 50409


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 50505


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 50773


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 50856


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return strWHERE.ToString();

        }
        #endregion

        #endregion

    }
}