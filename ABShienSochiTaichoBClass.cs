// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‚`‚aŽx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚c‚`(ABShienSochiTaishoBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2023/10/13@‰º‘º@”ü]
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2023/10/13             yAB-0880-1zŒÂl§Œäî•ñÚ×ŠÇ—€–Ú’Ç‰Á
// * 2024/01/18   000001    yAB-0070-1z Žx‰‡‘[’u’Ê’m‘•W€‰»‘Î‰ž
// * 2024/03/07   000002   yAB-0900-1zƒAƒhƒŒƒXEƒx[ƒXEƒŒƒWƒXƒgƒŠ‘Î‰ž(‰º‘º)
// ************************************************************************************************
using System.Linq;
using System.Text;

namespace Densan.Reams.AB.AB000BB
{

    public class ABShienSochiTaishoBClass
    {
        #region ƒƒ“
        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private UFErrorClass m_cfErrorClass;                  // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private UFDateClass m_cfDateClass;                    // “ú•tƒNƒ‰ƒX
        private string m_strInsertSQL;                        // INSERT—pSQL
        private string m_strUpdateSQL;                        // UPDATE—pSQL
        private string m_strDelRonriSQL;                      // ˜_—íœ—pSQL
        private string m_strDelButuriSQL;                     // •¨—íœ—pSQL
        private UFParameterCollectionClass m_cfSelectUFParameterCollectionClass;      // SELECT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;      // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateUFParameterCollectionClass;      // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDelRonriUFParameterCollectionClass;    // ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDelButuriUFParameterCollectionClass;   // •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private DataSet m_csDataSchma;   // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private string m_strUpdateDatetime;                   // XV“úŽž

        public bool m_blnBatch = false;               // ƒoƒbƒ`ƒtƒ‰ƒO
                                                      // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABShienSochiTaishoBClass";                     // ƒNƒ‰ƒX–¼
        private const string THIS_BUSINESSID = "AB";                                   // ‹Æ–±ƒR[ƒh

        private const string SAKUJOFG_OFF = "0";
        private const string SAKUJOFG_ON = "1";
        private const decimal KOSHINCOUNTER_DEF = decimal.Zero;

        private const string FORMAT_UPDATETIME = "yyyyMMddHHmmssfff";

        private const string ERR_JUMINCD = "Z–¯ƒR[ƒh";
        private const string ERR_SHIENSOCHIKANRINO = "Žx‰‡‘[’uŠÇ—";/* TODO ERROR: Skipped SkippedTokensTrivia
Ô†"

#End Region

#Region "ƒRƒ“ƒXƒgƒ‰ƒNƒ^"*/
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
        public ABShienSochiTaishoBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigDataClass;
            m_cfRdbClass = cfRdbClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(m_cfConfigDataClass, m_cfControlData.m_strBusinessId);

            // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
            m_strInsertSQL = string.Empty;
            m_strUpdateSQL = string.Empty;
            m_strDelRonriSQL = string.Empty;
            m_strDelButuriSQL = string.Empty;
            m_cfSelectUFParameterCollectionClass = (object)null;
            m_cfInsertUFParameterCollectionClass = (object)null;
            m_cfUpdateUFParameterCollectionClass = (object)null;
            m_cfDelRonriUFParameterCollectionClass = (object)null;
            m_cfDelButuriUFParameterCollectionClass = (object)null;
        }
        #endregion

        #region ƒƒ\ƒbƒh
        #region Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^’Šo@[GetShienSochiTaisho]
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼    Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^’Šo
        // * 
        // * \•¶          Public Function GetShienSochiTaisho As DataSet
        // * 
        // * ‹@”\@@    @Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”          strShienSochiKanriNo : Žx‰‡‘[’uŠÇ—”Ô† 
        // * 
        // * –ß‚è’l        DataSet : Žæ“¾‚µ‚½Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetShienSochiTaisho(string strShienSochiKanriNo)
        {

            return GetShienSochiTaisho(strShienSochiKanriNo, false);

        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼    Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^’Šo
        // * 
        // * \•¶          Public Function GetShienSochiTaisho As DataSet
        // * 
        // * ‹@”\@@    @Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”          strShienSochiKanriNo : Žx‰‡‘[’uŠÇ—”Ô†
        // *               blnSakujoFG        : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l        DataSet : Žæ“¾‚µ‚½Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetShienSochiTaisho(string strShienSochiKanriNo, bool blnSakujoFG)
        {

            const string THIS_METHOD_NAME = "GetShienSochiTaisho";
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            DataSet csAtenaEntity;
            var strSQL = new StringBuilder();

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
                // Žx‰‡‘[’uŠÇ—”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢‚Æ‚«ƒGƒ‰[
                if (strShienSochiKanriNo == null || strShienSochiKanriNo.Trim().RLength == 0)
                {
                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage + ERR_SHIENSOCHIKANRINO, objErrorStruct.m_strErrorCode);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // SELECT‹å‚Ì¶¬
                strSQL.Append(CreateSelect());
                // FROM‹å‚Ì¶¬
                strSQL.AppendFormat(" FROM {0} ", ABShienSochiTaishoEntity.TABLE_NAME);

                // ÃÞ°À½·°Ï‚ÌŽæ“¾
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABShienSochiTaishoEntity.TABLE_NAME, false);
                }

                // WHERE‹å‚Ìì¬
                strSQL.Append(CreateWhere(strShienSochiKanriNo, 0, blnSakujoFG));
                strSQL.Append(" ORDER BY ");
                strSQL.Append(ABShienSochiTaishoEntity.SHIENSOCHIKANRINO);
                strSQL.AppendFormat(", {0}", ABShienSochiTaishoEntity.RENBAN);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9002


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString(), m_cfSelectUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csAtenaEntity = m_csDataSchma.Clone();
                csAtenaEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csAtenaEntity, ABShienSochiTaishoEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9977


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10073


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10341


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10424


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csAtenaEntity;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼    Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^’Šo
        // * 
        // * \•¶          Public Function GetShienSochiTaisho As DataSet
        // * 
        // * ‹@”\@@    @Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”          strShienSochiKanriNo : Žx‰‡‘[’uŠÇ—”Ô† 
        // *               intRenban            : ˜A”Ô
        // * 
        // * –ß‚è’l        DataSet : Žæ“¾‚µ‚½Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetShienSochiTaisho(string strShienSochiKanriNo, int intRenban)
        {

            return GetShienSochiTaisho(strShienSochiKanriNo, intRenban, false);

        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼    Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^’Šo
        // * 
        // * \•¶          Public Function GetShienSochiTaisho As DataSet
        // * 
        // * ‹@”\@@    @Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”          strShienSochiKanriNo : Žx‰‡‘[’uŠÇ—”Ô†
        // *               intRenban            : ˜A”Ô
        // *               blnSakujoFG        : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l        DataSet : Žæ“¾‚µ‚½Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetShienSochiTaisho(string strShienSochiKanriNo, int intRenban, bool blnSakujoFG)
        {

            const string THIS_METHOD_NAME = "GetShienSochiTaisho";
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            DataSet csAtenaEntity;
            var strSQL = new StringBuilder();

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
                // Žx‰‡‘[’uŠÇ—”Ô†‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢‚Æ‚«ƒGƒ‰[
                if (strShienSochiKanriNo == null || strShienSochiKanriNo.Trim().RLength == 0)
                {
                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage + ERR_SHIENSOCHIKANRINO, objErrorStruct.m_strErrorCode);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // SELECT‹å‚Ì¶¬
                strSQL.Append(CreateSelect());
                // FROM‹å‚Ì¶¬
                strSQL.AppendFormat(" FROM {0} ", ABShienSochiTaishoEntity.TABLE_NAME);

                // ÃÞ°À½·°Ï‚ÌŽæ“¾
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABShienSochiTaishoEntity.TABLE_NAME, false);
                }

                // WHERE‹å‚Ìì¬
                strSQL.Append(CreateWhere(strShienSochiKanriNo, intRenban, blnSakujoFG));

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 14613


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString(), m_cfSelectUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csAtenaEntity = m_csDataSchma.Clone();
                csAtenaEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csAtenaEntity, ABShienSochiTaishoEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 15588


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 15684


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 15952


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 16035


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csAtenaEntity;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼    Žx‰‡‘[’u‘ÎÛŽÒ’Šo
        // * 
        // * \•¶          Public Overloads Function GetShienSochiTaisho(ByVal strShienSochiKanriNo() As String) As DataSet
        // * 
        // * ‹@”\@@    @Žx‰‡‘[’uŠÇ—”Ô†‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”          strShienSochiKanriNo : Žx‰‡‘[’uŠÇ—”Ô†‚Ì”z—ñ       
        // * 
        // * –ß‚è’l        DataSet : Žæ“¾‚µ‚½Žx‰‡‘[’u‘ÎÛŽÒ‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetShienSochiTaisho(string[] strShienSochiKanriNo)
        {

            const string THIS_METHOD_NAME = "GetShienSochiTaisho";
            DataSet csShienSochitaishoEntity;
            var strSQL = new StringBuilder();
            UFParameterClass cfParameter;
            string strParameterName;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                m_cfSelectUFParameterCollectionClass = new UFParameterCollectionClass();

                // SELECT‹å‚Ì¶¬
                strSQL.Append(CreateSelect());
                // FROM‹å‚Ì¶¬
                strSQL.AppendFormat(" FROM {0} ", ABShienSochiTaishoEntity.TABLE_NAME);

                // ÃÞ°À½·°Ï‚ÌŽæ“¾
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABShienSochiTaishoEntity.TABLE_NAME, false);
                }

                // WHERE‹å‚Ìì¬
                if (strShienSochiKanriNo.Length == 0)
                {
                    csShienSochitaishoEntity = m_csDataSchma.Clone();
                }
                else
                {
                    strSQL.Append(" WHERE ");
                    strSQL.Append(ABShienSochiTaishoEntity.SHIENSOCHIKANRINO);
                    strSQL.Append(" IN (");

                    for (int i = 0, loopTo = strShienSochiKanriNo.Length - 1; i <= loopTo; i++)
                    {
                        // -----------------------------------------------------------------------------
                        // Žx‰‡‘[’uŠÇ—”Ô†
                        strParameterName = ABShienSochiTaishoEntity.KEY_SHIENSOCHIKANRINO + i.ToString();

                        if (i > 0)
                        {
                            strSQL.AppendFormat(", {0}", strParameterName);
                        }
                        else
                        {
                            strSQL.Append(strParameterName);
                        }

                        cfParameter = new UFParameterClass();
                        cfParameter.ParameterName = strParameterName;
                        cfParameter.Value = strShienSochiKanriNo[i];
                        m_cfSelectUFParameterCollectionClass.Add(cfParameter);
                        // -----------------------------------------------------------------------------
                    }

                    strSQL.Append(")");
                    strSQL.Append(" AND ");
                    strSQL.Append(ABShienSochiTaishoEntity.SAKUJOFG);

                    strSQL.Append(" <> '1'");

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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 19891


                                        Input:
                                        " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString(), m_cfSelectUFParameterCollectionClass) + "z")

                                                        ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                         */
                    csShienSochitaishoEntity = m_csDataSchma.Clone();
                    csShienSochitaishoEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csShienSochitaishoEntity, ABShienSochiTaishoEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 20997


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21093


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21361


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21444


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csShienSochitaishoEntity;

        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     SELECT‹å‚Ìì¬
        // * 
        // * \•¶           Private Sub CreateSelect() As String
        // * 
        // * ‹@”\@@    @ SELECT‹å‚ð¶¬‚·‚é
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         String    :   SELECT‹å
        // ************************************************************************************************
        private string CreateSelect()
        {
            const string THIS_METHOD_NAME = "CreateSelect";
            var csSELECT = new StringBuilder();

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SELECT‹å‚Ìì¬
                csSELECT.AppendFormat("SELECT {0}", ABShienSochiTaishoEntity.SHIENSOCHIKANRINO);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.RENBAN);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.JUMINCD);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MOSHIDEJOKYOKB);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.TAISHOSHAKB);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.TAISHOSHAKANKEI);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.YUBINNO);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.JUSHO_KANNAIKANGAIKB);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.JUSHO_JUSHOCD);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.JUSHO_JUSHO);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.SHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.TODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.SHIKUCHOSON);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MACHIAZA);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.BANCHI);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.KATAGAKICD);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.KATAGAKI);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.KANAKATAGAKI);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.SHIENJIMUTAISHOKB_JUKIDAICHOETSURAN_GENJUSHO);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.SHIENJIMUTAISHOKB_JUMINHYOUTSUSHIKOFU_GENJUSHO);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.SHIENJIMUTAISHOKB_JUMINHYOUTSUSHIKOFU_ZENJUSHO);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.SHIENJUSHO_TENSHUTSUKAKUTEI);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.SHIENJUSHO_TENSHUTSUYOTEI);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.SHIENJUSHO_TOGOKISAIRAN);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAE_JUSHOCD);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAE_JUSHO);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAE_SHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAE_MACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAE_TODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAE_SHIKUCHOSON);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAE_MACHIAZA);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAE_BANCHI);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAE_KATAGAKI);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.SHIENJIMUTAISHOKB_KOSEKIFUHYOUTSUSHIKOFU_HONSEKI);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.HON_JUSHOCD);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.HON_JUSHO);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.HON_SHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.HON_MACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.HON_TODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.HON_SHIKUGUNCHOSON);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.HON_MACHIAZA);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.HONSEKIBANCHI);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.SHIENJIMUTAISHOKB_KOSEKIFUHYOUTSUSHIKOFU_ZENHONSEKI);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAEHON_JUSHOCD);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAEHON_JUSHO);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAEHON_SHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAEHON_MACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAEHON_TODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAEHON_SHIKUGUNCHOSON);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAEHON_MACHIAZA);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.MAEHONSEKIBANCHI);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.SHIENJIMUTAISHOKB_KOTEISHISAN);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.KOTEI_SHICHOSONCD1);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.KOTEI_SHICHOSON1);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.KOTEI_SHICHOSONCD2);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.KOTEI_SHICHOSON2);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.KOTEI_SHICHOSONCD3);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.KOTEI_SHICHOSON3);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.KOTEI_SHICHOSONCD4);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.KOTEI_SHICHOSON4);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.KOTEI_SHICHOSONCD5);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.KOTEI_SHICHOSON5);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.RESERVE1);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.RESERVE2);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.RESERVE3);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.RESERVE4);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.RESERVE5);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.TANMATSUID);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.SAKUJOFG);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.KOSHINCOUNTER);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.SAKUSEINICHIJI);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.SAKUSEIUSER);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.KOSHINNICHIJI);
                csSELECT.AppendFormat(", {0}", ABShienSochiTaishoEntity.KOSHINUSER);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 29586


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 29684


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 29954


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 30039


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csSELECT.ToString();

        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼   WHERE•¶‚Ìì¬
        // * 
        // * \•¶         Private Sub CreateSQL(ByVal csDataRow As DataRow)
        // * 
        // * ‹@”\         WHERE•ª‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”         strShienSochiKanriNo : Žx‰‡‘[’uŠÇ—”Ô† 
        // *              intRenban            : ˜A”Ô
        // *              blnSakujoFG          : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l       ‚È‚µ
        // ************************************************************************************************
        private string CreateWhere(string strShienSochiKanriNo, int intRenban, bool blnSakujoFG)
        {
            const string THIS_METHOD_NAME = "CreateWhere";
            StringBuilder csWHERE;
            UFParameterClass cfUFParameterClass;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SELECTƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfSelectUFParameterCollectionClass = new UFParameterCollectionClass();

                // WHERE‹å‚Ìì¬
                csWHERE = new StringBuilder(256);

                // Žx‰‡‘[’uŠÇ—”Ô†
                csWHERE.AppendFormat("WHERE {0} = {1}", ABShienSochiTaishoEntity.SHIENSOCHIKANRINO, ABShienSochiTaishoEntity.KEY_SHIENSOCHIKANRINO);
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.KEY_SHIENSOCHIKANRINO;
                cfUFParameterClass.Value = strShienSochiKanriNo;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);

                // ˜A”Ô
                if (!(intRenban == 0))
                {
                    csWHERE.AppendFormat(" AND {0} = {1}", ABShienSochiTaishoEntity.RENBAN, ABShienSochiTaishoEntity.KEY_RENBAN);
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.KEY_RENBAN;
                    cfUFParameterClass.Value = intRenban.ToString();
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // íœƒtƒ‰ƒO
                if (blnSakujoFG == false)
                {
                    csWHERE.AppendFormat(" AND {0} <> '{1}'", ABShienSochiTaishoEntity.SAKUJOFG, SAKUJOFG_ON);
                }
                else
                {
                    // ˆ—‚È‚µ
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 33849


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 33945


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 34213


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 34296


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csWHERE.ToString();

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼    Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^’Šo
        // * 
        // * \•¶          Public Function GetShienSochiTaishoByJuminCD() As DataSet
        // * 
        // * ‹@”\@@    @Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”          a_strJuminCd()       : Z–¯ƒR[ƒh‚Ì”z—ñ
        // * 
        // * –ß‚è’l        DataSet : Žæ“¾‚µ‚½Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetShienSochiTaishoByJuminCD(string[] a_strJuminCd)
        {

            const string THIS_METHOD_NAME = "GetShienSochiTaishoByJuminCD";
            DataSet csAtenaEntity;
            var strSQL = new StringBuilder();
            string strParameterName;
            UFParameterClass cfParameter;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                m_cfSelectUFParameterCollectionClass = new UFParameterCollectionClass();
                // SELECT‹å‚Ì¶¬
                strSQL.Append(CreateSelect());
                // FROM‹å‚Ì¶¬
                strSQL.AppendFormat(" FROM {0} ", ABShienSochiTaishoEntity.TABLE_NAME);

                // ÃÞ°À½·°Ï‚ÌŽæ“¾
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABShienSochiTaishoEntity.TABLE_NAME, false);
                }

                // WHERE‹å‚Ìì¬
                strSQL.Append(" WHERE ");
                strSQL.Append(ABShienSochiTaishoEntity.JUMINCD);
                strSQL.Append(" IN (");

                for (int i = 0, loopTo = a_strJuminCd.Length - 1; i <= loopTo; i++)
                {
                    // -----------------------------------------------------------------------------
                    // Z–¯ƒR[ƒh
                    strParameterName = ABShienSochiTaishoEntity.PARAM_JUMINCD + i.ToString();

                    if (i > 0)
                    {
                        strSQL.AppendFormat(", {0}", strParameterName);
                    }
                    else
                    {
                        strSQL.Append(strParameterName);
                    }

                    cfParameter = new UFParameterClass();
                    cfParameter.ParameterName = strParameterName;
                    cfParameter.Value = a_strJuminCd[i];
                    m_cfSelectUFParameterCollectionClass.Add(cfParameter);
                    // -----------------------------------------------------------------------------
                }

                strSQL.Append(")");

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37690


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString(), m_cfSelectUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csAtenaEntity = m_csDataSchma.Clone();
                csAtenaEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csAtenaEntity, ABShienSochiTaishoEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 38665


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 38761


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 39029


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 39112


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csAtenaEntity;

        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼    Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^’Šo
        // * 
        // * \•¶          Public Function GetShienSochiTaishoByJuminCD As DataSet
        // * 
        // * ‹@”\@@    @Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”          strJuminCD : Z–¯ƒR[ƒh 
        // * 
        // * –ß‚è’l        DataSet : Žæ“¾‚µ‚½Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetShienSochiTaishoByJuminCD(string strJuminCD)
        {

            return GetShienSochiTaishoByJuminCD(strJuminCD, string.Empty, false);

        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼    Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^’Šo
        // * 
        // * \•¶          Public Function GetShienSochiTaishoByJuminCD() As DataSet
        // * 
        // * ‹@”\@@    @Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”          strJuminCD           : Z–¯ƒR[ƒh
        // *               strShienSochiKanriNo : Žx‰‡‘[’uŠÇ—”Ô†
        // *               blnSakujoFG          : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l        DataSet : Žæ“¾‚µ‚½Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetShienSochiTaishoByJuminCD(string strJuminCd, string strShienSochiKanriNo, bool blnSakujoFG)
        {

            const string THIS_METHOD_NAME = "GetShienSochiTaishoByJuminCD";
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            DataSet csAtenaEntity;
            var strSQL = new StringBuilder();

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
                // Z–¯ƒR[ƒh‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢‚Æ‚«ƒGƒ‰[
                if (strJuminCd == null || strJuminCd.Trim().RLength == 0)
                {
                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage + ERR_JUMINCD, objErrorStruct.m_strErrorCode);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // SELECT‹å‚Ì¶¬
                strSQL.Append(CreateSelect());
                // FROM‹å‚Ì¶¬
                strSQL.AppendFormat(" FROM {0} ", ABShienSochiTaishoEntity.TABLE_NAME);

                // ÃÞ°À½·°Ï‚ÌŽæ“¾
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABShienSochiTaishoEntity.TABLE_NAME, false);
                }

                // WHERE‹å‚Ìì¬
                strSQL.Append(CreateWhereJuminCD(strJuminCd, strShienSochiKanriNo, blnSakujoFG));

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 43194


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString(), m_cfSelectUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csAtenaEntity = m_csDataSchma.Clone();
                csAtenaEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csAtenaEntity, ABShienSochiTaishoEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 44169


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 44265


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 44533


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 44616


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csAtenaEntity;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼   WHERE•¶‚Ìì¬
        // * 
        // * \•¶         Private Sub CreateSQL(ByVal csDataRow As DataRow)
        // * 
        // * ‹@”\         WHERE•ª‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”         strJuminCD           : Z–¯ƒR[ƒh 
        // *              strShienSochiKanriNo : Žx‰‡‘[’uŠÇ—”Ô†
        // *              blnSakujoFG          : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l       ‚È‚µ
        // ************************************************************************************************
        private string CreateWhereJuminCD(string strJuminCD, string strShienSochiKanriNo, bool blnSakujoFG)
        {
            const string THIS_METHOD_NAME = "CreateWhere";
            StringBuilder csWHERE;
            UFParameterClass cfUFParameterClass;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SELECTƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfSelectUFParameterCollectionClass = new UFParameterCollectionClass();

                // WHERE‹å‚Ìì¬
                csWHERE = new StringBuilder(256);

                // Z–¯ƒR[ƒh
                csWHERE.AppendFormat("WHERE {0} = {1}", ABShienSochiTaishoEntity.JUMINCD, ABShienSochiTaishoEntity.PARAM_JUMINCD);
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.PARAM_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);

                // Žx‰‡‘[’uŠÇ—”Ô†
                if (!string.IsNullOrEmpty(strShienSochiKanriNo))
                {
                    csWHERE.AppendFormat(" AND {0} = {1}", ABShienSochiTaishoEntity.SHIENSOCHIKANRINO, ABShienSochiTaishoEntity.KEY_SHIENSOCHIKANRINO);
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.KEY_SHIENSOCHIKANRINO;
                    cfUFParameterClass.Value = strShienSochiKanriNo;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // íœƒtƒ‰ƒO
                if (blnSakujoFG == false)
                {
                    csWHERE.AppendFormat(" AND {0} <> '{1}'", ABShienSochiTaishoEntity.SAKUJOFG, SAKUJOFG_ON);
                }
                else
                {
                    // ˆ—‚È‚µ
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 48475


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 48571


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 48839


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 48922


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csWHERE.ToString();

        }
        #endregion

        #region Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^’Ç‰Á@[InsertShienSochiTaisho]
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertShienSochiTaisho(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertShienSochiTaisho(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "InsertShienSochiTaisho";
            int intInsCnt;                            // ’Ç‰ÁŒ”

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strInsertSQL is null || string.IsNullOrEmpty(m_strInsertSQL) || m_cfInsertUFParameterCollectionClass is null)
                {
                    CreateInsertSQL(csDataRow);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                m_strUpdateDatetime = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME);

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABShienSochiTaishoEntity.TANMATSUID) = m_cfControlData.m_strClientId;     // ’[––‚h‚c
                csDataRow(ABShienSochiTaishoEntity.SAKUJOFG) = SAKUJOFG_OFF;                        // íœƒtƒ‰ƒO
                csDataRow(ABShienSochiTaishoEntity.KOSHINCOUNTER) = KOSHINCOUNTER_DEF;              // XVƒJƒEƒ“ƒ^
                csDataRow(ABShienSochiTaishoEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;      // ì¬ƒ†[ƒU[
                csDataRow(ABShienSochiTaishoEntity.KOSHINUSER) = m_cfControlData.m_strUserId;       // XVƒ†[ƒU[

                // ì¬“úŽžAXV“úŽž‚ÌÝ’è
                this.SetUpdateDatetime(csDataRow(ABShienSochiTaishoEntity.SAKUSEINICHIJI));
                this.SetUpdateDatetime(csDataRow(ABShienSochiTaishoEntity.KOSHINNICHIJI));

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    cfParam.Value = csDataRow(cfParam.ParameterName.RSubstring(ABShienSochiTaishoEntity.PARAM_PLACEHOLDER.RLength)).ToString();

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 52372


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strInsertSQL, m_cfInsertUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs
                                            intInsCnt = m_cfRdbClass.ExecuteSQL(m_strInsertSQL, m_cfInsertUFParameterCollectionClass)

                                            ' ƒfƒoƒbƒOƒƒOo—Í
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 53143


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 53239


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 53507


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return intInsCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     Insert—pSQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateInsertSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\           INSERT—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateInsertSQL(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateInsertSQL"
                        Dim csDataColumn As DataColumn
                        Dim csInsertColumn As StringBuilder                 'INSERT—pƒJƒ‰ƒ€’è‹`
                        Dim csInsertParam As StringBuilder                  'INSERT—pƒpƒ‰ƒ[ƒ^’è‹`
                        Dim cfUFParameterClass As UFParameterClass
                        Dim strParamName As String


                        Try
                            ' ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SELECT SQL•¶‚Ìì¬
                            csInsertColumn = New StringBuilder
                            csInsertParam = New StringBuilder

                            ' INSERT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfInsertUFParameterCollectionClass = New UFParameterCollectionClass

                            ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                            For Each csDataColumn In csDataRow.Table.Columns
                                cfUFParameterClass = New UFParameterClass
                                strParamName = String.Format("{0}{1}", ABShienSochiTaishoEntity.PARAM_PLACEHOLDER, csDataColumn.ColumnName)

                                ' INSERT SQL•¶‚Ìì¬
                                csInsertColumn.AppendFormat("{0},", csDataColumn.ColumnName)
                                csInsertParam.AppendFormat("{0},", strParamName)

                                ' INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                                cfUFParameterClass.ParameterName = strParamName
                                m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass)

                            Next csDataColumn

                            'ÅŒã‚ÌƒJƒ“ƒ}‚ðŽæ‚èœ‚¢‚ÄINSERT•¶‚ðì¬
                            m_strInsertSQL = String.Format("INSERT INTO {0}({1}) VALUES ({2})",
                                                           ABShienSochiTaishoEntity.TABLE_NAME,
                                                           csInsertColumn.ToString.TrimEnd(",".ToCharArray),
                                                           csInsertParam.ToString.TrimEnd(",".ToCharArray))

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                    End Sub

                #End Region

                #Region "Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^XV@[UpdateShienSochiTaisho]"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^XV
                    '* 
                    '* \•¶           Public Function UpdateShienSochiTaisho(ByVal csDataRow As DataRow) As Integer
                    '* 
                    '* ‹@”\@@    @ Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
                    '* 
                    '* –ß‚è’l         Integer : XV‚µ‚½ƒf[ƒ^‚ÌŒ”
                    '************************************************************************************************
                    Public Function UpdateShienSochiTaisho(ByVal csDataRow As DataRow) As Integer

                        Const THIS_METHOD_NAME As String = "UpdateShienSochiTaisho"
                        Dim cfParam As UFParameterClass                     'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim intUpdCnt As Integer                            'XVŒ”


                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                            If (m_strUpdateSQL Is Nothing OrElse m_strUpdateSQL = String.Empty OrElse
                                m_cfUpdateUFParameterCollectionClass Is Nothing) Then
                                Call CreateUpdateSQL(csDataRow)
                            Else
                                'ˆ—‚È‚µ
                            End If

                            '‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                            csDataRow(ABShienSochiTaishoEntity.TANMATSUID) = m_cfControlData.m_strClientId                                   '’[––‚h‚c
                            csDataRow(ABShienSochiTaishoEntity.KOSHINCOUNTER) = CDec(csDataRow(ABShienSochiTaishoEntity.KOSHINCOUNTER)) + 1  'XVƒJƒEƒ“ƒ^
                            csDataRow(ABShienSochiTaishoEntity.KOSHINUSER) = m_cfControlData.m_strUserId                                     'XVƒ†[ƒU[

                            'XV“úŽž‚ÌÝ’è
                            m_strUpdateDatetime = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME)
                            csDataRow(ABShienSochiTaishoEntity.KOSHINNICHIJI) = m_strUpdateDatetime

                            'ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                            For Each cfParam In m_cfUpdateUFParameterCollectionClass
                                'ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                                If (cfParam.ParameterName.RSubstring(0, ABShienSochiTaishoEntity.PREFIX_KEY.RLength) = ABShienSochiTaishoEntity.PREFIX_KEY) Then
                                    ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                                    m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value _
                                        = csDataRow(cfParam.ParameterName.RSubstring(ABShienSochiTaishoEntity.PREFIX_KEY.RLength),
                                                      DataRowVersion.Original).ToString()

                                    'ƒL[€–ÚˆÈŠO‚Í•ÒW“à—eŽæ“¾
                                Else
                                    m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value _
                                         = csDataRow(cfParam.ParameterName.RSubstring(ABShienSochiTaishoEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString()
                                End If
                            Next cfParam

                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                        "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" +
                                                        "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass) + "z")

                            ' SQL‚ÌŽÀs
                            intUpdCnt = m_cfRdbClass.ExecuteSQL(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass)

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

                        Return intUpdCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     Update—pSQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateUpdateSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\           UPDATE—p‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateUpdateSQL(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateUpdateSQL"
                        Dim csDataColumn As DataColumn
                        Dim cfUFParameterClass As UFParameterClass
                        Dim csWhere As StringBuilder                        'WHERE’è‹`
                        Dim csUpdateParam As StringBuilder                  'UPDATE—pSQL’è‹`


                        Try
                            ' ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' UPDATE SQL•¶‚Ìì¬
                            m_strUpdateSQL = "UPDATE " + ABShienSochiTaishoEntity.TABLE_NAME + " SET "
                            csUpdateParam = New StringBuilder

                            ' WHERE•¶‚Ìì¬
                            csWhere = New StringBuilder
                            csWhere.Append(" WHERE ")
                            csWhere.Append(ABShienSochiTaishoEntity.SHIENSOCHIKANRINO)
                            csWhere.Append(" = ")
                            csWhere.Append(ABShienSochiTaishoEntity.KEY_SHIENSOCHIKANRINO)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABShienSochiTaishoEntity.RENBAN)
                            csWhere.Append(" = ")
                            csWhere.Append(ABShienSochiTaishoEntity.KEY_RENBAN)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABShienSochiTaishoEntity.KOSHINCOUNTER)
                            csWhere.Append(" = ")
                            csWhere.Append(ABShienSochiTaishoEntity.KEY_KOSHINCOUNTER)

                            ' UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfUpdateUFParameterCollectionClass = New UFParameterCollectionClass

                            ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                            For Each csDataColumn In csDataRow.Table.Columns
                                'Žx‰‡‘[’uŠÇ—”Ô†E˜A”ÔEì¬“úŽžEì¬ƒ†[ƒU‚ÍXV‚µ‚È‚¢
                                If Not (csDataColumn.ColumnName = ABShienSochiTaishoEntity.SHIENSOCHIKANRINO) AndAlso
                                    Not (csDataColumn.ColumnName = ABShienSochiTaishoEntity.RENBAN) AndAlso
                                     Not (csDataColumn.ColumnName = ABShienSochiTaishoEntity.SAKUSEIUSER) AndAlso
                                      Not (csDataColumn.ColumnName = ABShienSochiTaishoEntity.SAKUSEINICHIJI) Then

                                    cfUFParameterClass = New UFParameterClass

                                    ' UPDATE SQL•¶‚Ìì¬
                                    csUpdateParam.Append(csDataColumn.ColumnName)
                                    csUpdateParam.Append(" = ")
                                    csUpdateParam.Append(ABShienSochiTaishoEntity.PARAM_PLACEHOLDER)
                                    csUpdateParam.Append(csDataColumn.ColumnName)
                                    csUpdateParam.Append(",")

                                    ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                                    cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                                    m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                                Else
                                    'ˆ—‚È‚µ
                                End If

                            Next csDataColumn

                            ' UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                            m_strUpdateSQL += csUpdateParam.ToString.TrimEnd(",".ToCharArray())

                            ' UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                            m_strUpdateSQL += csWhere.ToString

                            ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.KEY_SHIENSOCHIKANRINO
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.KEY_RENBAN
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.KEY_KOSHINCOUNTER
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                    End Sub

                #End Region

                #Region "Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^íœ@[DeleteShienSochiTaisho]"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^íœ
                    '* 
                    '* \•¶           Public Function DeleteShienSochiTaisho(ByVal csDataRow As DataRow) As Integer
                    '* 
                    '* ‹@”\@@    @@Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð˜_—íœ‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
                    '* 
                    '* –ß‚è’l         Integer : ˜_—íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
                    '************************************************************************************************
                    Public Overloads Function DeleteShienSochiTaisho(ByVal csDataRow As DataRow) As Integer

                        Const THIS_METHOD_NAME As String = "DeleteShienSochiTaisho"
                        Dim cfParam As UFParameterClass  'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim intDelCnt As Integer        'íœŒ”


                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                            If (m_strDelRonriSQL Is Nothing OrElse m_strDelRonriSQL = String.Empty OrElse
                                    m_cfDelRonriUFParameterCollectionClass Is Nothing) Then
                                Call CreateDeleteRonriSQL(csDataRow)
                            Else
                                'ˆ—‚È‚µ
                            End If

                            '‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                            csDataRow(ABShienSochiTaishoEntity.TANMATSUID) = m_cfControlData.m_strClientId                                   '’[––‚h‚c
                            csDataRow(ABShienSochiTaishoEntity.SAKUJOFG) = SAKUJOFG_ON                                                       'íœƒtƒ‰ƒO
                            csDataRow(ABShienSochiTaishoEntity.KOSHINCOUNTER) = CDec(csDataRow(ABShienSochiTaishoEntity.KOSHINCOUNTER)) + 1  'XVƒJƒEƒ“ƒ^
                            csDataRow(ABShienSochiTaishoEntity.KOSHINUSER) = m_cfControlData.m_strUserId                                     'XVƒ†[ƒU[

                            'XV“úŽž‚ÌÝ’è
                            m_strUpdateDatetime = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME)
                            Me.SetUpdateDatetime(csDataRow(ABShienSochiTaishoEntity.KOSHINNICHIJI))

                            'ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                            For Each cfParam In m_cfDelRonriUFParameterCollectionClass
                                'ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                                If (cfParam.ParameterName.RSubstring(0, ABShienSochiTaishoEntity.PREFIX_KEY.RLength) = ABShienSochiTaishoEntity.PREFIX_KEY) Then
                                    m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value =
                                                 csDataRow(cfParam.ParameterName.RSubstring(ABShienSochiTaishoEntity.PREFIX_KEY.RLength),
                                                           DataRowVersion.Original).ToString()
                                    'ƒL[€–ÚˆÈŠO‚Í•ÒW“à—e‚ðÝ’è
                                Else
                                    m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value _
                                        = csDataRow(cfParam.ParameterName.RSubstring(ABShienSochiTaishoEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString()
                                End If
                            Next cfParam

                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                        "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" +
                                                        "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass) + "z")
                            ' SQL‚ÌŽÀs
                            intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass)

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

                        Return intDelCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     Žx‰‡‘[’u‘ÎÛŽÒ•¨—íœ
                    '* 
                    '* \•¶           Public Function DeleteShiensochiTaisho(ByVal csDataRow As DataRow, _
                    '*                                               ByVal strSakujoKB As String) As Integer
                    '* 
                    '* ‹@”\@@    @@Žx‰‡‘[’u‘ÎÛŽÒƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð•¨—íœ‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
                    '* 
                    '* –ß‚è’l         Integer : íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
                    '************************************************************************************************
                    Public Overloads Function DeleteShiensochiTaisho(ByVal csDataRow As DataRow,
                                                             ByVal strSakujoKB As String) As Integer

                        Const THIS_METHOD_NAME As String = "DeleteShiensochiTaisho"
                        Dim objErrorStruct As UFErrorStruct 'ƒGƒ‰[’è‹`\‘¢‘Ì
                        Dim cfParam As UFParameterClass     'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim intDelCnt As Integer            'íœŒ”


                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' íœ‹æ•ª‚Ìƒ`ƒFƒbƒN‚ðs‚¤
                            If Not (strSakujoKB = "D") Then

                                m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_DELETE_SAKUJOKB)
                                '—áŠO‚ð¶¬
                                Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                            Else
                                'ˆ—‚È‚µ
                            End If

                            ' íœ—p‚Ìƒpƒ‰ƒ[ƒ^•tDELETE•¶•¶Žš—ñ‚Æƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                            If (m_strDelButuriSQL Is Nothing OrElse m_strDelButuriSQL = String.Empty OrElse
                                    IsNothing(m_cfDelButuriUFParameterCollectionClass)) Then
                                Call CreateDeleteButsuriSQL(csDataRow)
                            Else
                                'ˆ—‚È‚µ
                            End If

                            ' ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚Öíœs‚©‚ç’l‚ðÝ’è‚·‚éB
                            For Each cfParam In m_cfDelButuriUFParameterCollectionClass
                                ' ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                                If (cfParam.ParameterName.RSubstring(0, ABShienSochiTaishoEntity.PREFIX_KEY.RLength) = ABShienSochiTaishoEntity.PREFIX_KEY) Then
                                    m_cfDelButuriUFParameterCollectionClass(cfParam.ParameterName).Value _
                                            = csDataRow(cfParam.ParameterName.RSubstring(ABShienSochiTaishoEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString()

                                    'ƒL[€–ÚˆÈŠO‚ÌŽæ“¾‚È‚µ
                                Else
                                    'ˆ—‚È‚µ
                                End If
                            Next cfParam

                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                        "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" +
                                                        "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strDelButuriSQL, m_cfDelButuriUFParameterCollectionClass) + "z")
                            ' SQL‚ÌŽÀs
                            intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelButuriSQL, m_cfDelButuriUFParameterCollectionClass)

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

                        Return intDelCnt

                    End Function


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
                        Dim cfUFParameterClass As UFParameterClass
                        Dim csWhere As StringBuilder                        'WHERE’è‹`
                        Dim csDelRonriParam As StringBuilder                '˜_—íœƒpƒ‰ƒ[ƒ^’è‹`

                        Try
                            ' ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' WHERE•¶‚Ìì¬
                            csWhere = New StringBuilder
                            csWhere.Append(" WHERE ")
                            csWhere.Append(ABShienSochiTaishoEntity.SHIENSOCHIKANRINO)
                            csWhere.Append(" = ")
                            csWhere.Append(ABShienSochiTaishoEntity.KEY_SHIENSOCHIKANRINO)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABShienSochiTaishoEntity.RENBAN)
                            csWhere.Append(" = ")
                            csWhere.Append(ABShienSochiTaishoEntity.KEY_RENBAN)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABShienSochiTaishoEntity.KOSHINCOUNTER)
                            csWhere.Append(" = ")
                            csWhere.Append(ABShienSochiTaishoEntity.KEY_KOSHINCOUNTER)


                            ' ˜_—DELETE SQL•¶‚Ìì¬
                            csDelRonriParam = New StringBuilder
                            csDelRonriParam.Append("UPDATE ")
                            csDelRonriParam.Append(ABShienSochiTaishoEntity.TABLE_NAME)
                            csDelRonriParam.Append(" SET ")
                            csDelRonriParam.Append(ABShienSochiTaishoEntity.TANMATSUID)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABShienSochiTaishoEntity.PARAM_TANMATSUID)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABShienSochiTaishoEntity.SAKUJOFG)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABShienSochiTaishoEntity.PARAM_SAKUJOFG)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABShienSochiTaishoEntity.KOSHINCOUNTER)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABShienSochiTaishoEntity.PARAM_KOSHINCOUNTER)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABShienSochiTaishoEntity.KOSHINNICHIJI)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABShienSochiTaishoEntity.PARAM_KOSHINNICHIJI)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABShienSochiTaishoEntity.KOSHINUSER)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABShienSochiTaishoEntity.PARAM_KOSHINUSER)
                            csDelRonriParam.Append(csWhere)
                            ' Where•¶‚Ì’Ç‰Á
                            m_strDelRonriSQL = csDelRonriParam.ToString

                            ' ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDelRonriUFParameterCollectionClass = New UFParameterCollectionClass

                            ' ˜_—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.PARAM_TANMATSUID
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.PARAM_SAKUJOFG
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.PARAM_KOSHINCOUNTER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.PARAM_KOSHINNICHIJI
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.PARAM_KOSHINUSER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.KEY_SHIENSOCHIKANRINO
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.KEY_RENBAN
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.KEY_KOSHINCOUNTER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     •¨—íœ—pSQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateButsuriSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\           •¨—DELETE—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateDeleteButsuriSQL(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateButsuriSQL"
                        Dim cfUFParameterClass As UFParameterClass
                        Dim csWhere As StringBuilder                        'WHERE’è‹`

                        Try
                            ' ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' WHERE•¶‚Ìì¬
                            csWhere = New StringBuilder
                            csWhere.Append(" WHERE ")
                            csWhere.Append(ABShienSochiTaishoEntity.SHIENSOCHIKANRINO)
                            csWhere.Append(" = ")
                            csWhere.Append(ABShienSochiTaishoEntity.KEY_SHIENSOCHIKANRINO)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABShienSochiTaishoEntity.RENBAN)
                            csWhere.Append(" = ")
                            csWhere.Append(ABShienSochiTaishoEntity.KEY_RENBAN)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABShienSochiTaishoEntity.KOSHINCOUNTER)
                            csWhere.Append(" = ")
                            csWhere.Append(ABShienSochiTaishoEntity.KEY_KOSHINCOUNTER)

                            ' •¨—DELETE SQL•¶‚Ìì¬
                            m_strDelButuriSQL = "DELETE FROM " + ABShienSochiTaishoEntity.TABLE_NAME + csWhere.ToString

                            ' •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDelButuriUFParameterCollectionClass = New UFParameterCollectionClass

                            ' •¨—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.KEY_SHIENSOCHIKANRINO
                            m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.KEY_RENBAN
                            m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.KEY_KOSHINCOUNTER
                            m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                    End Sub
                #End Region

                #Region "‚»‚Ì‘¼"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     XV“úŽžÝ’è
                    '* 
                    '* \•¶           Private Sub SetUpdateDatetime()
                    '* 
                    '* ‹@”\           –¢Ý’è‚Ì‚Æ‚«XV“úŽž‚ðÝ’è‚·‚é
                    '* 
                    '* ˆø”           csDate As Object : XV“úŽž‚Ì€–Ú
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub SetUpdateDatetime(ByRef csDate As Object)
                        Try
                            '–¢Ý’è‚Ì‚Æ‚«
                            If (IsDBNull(csDate)) OrElse (CType(csDate, String).Trim.Equals(String.Empty)) Then
                                csDate = m_strUpdateDatetime
                            Else
                                'ˆ—‚È‚µ
                            End If
                        Catch
                            Throw
                        End Try
                    End Sub
                #End Region

                #End Region

                End Class

                 */
            }

            return default;
        }
    }
}