// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‚`‚aŽx‰‡‘[’u‚c‚`
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2023/10/13@‰º‘º@”ü]
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2023/10/13             yAB-0880-1zŒÂl§Œäî•ñÚ×ŠÇ—€–Ú’Ç‰Á
// *
// ************************************************************************************************
using System.Linq;
using System.Text;

namespace Densan.Reams.AB.AB000BB
{

    public class ABShienSochiBClass
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
        private const string THIS_CLASS_NAME = "ABShienSochiBClass";                   // ƒNƒ‰ƒX–¼
        private const string THIS_BUSINESSID = "AB";                                   // ‹Æ–±ƒR[ƒh

        private const string SAKUJOFG_OFF = "0";
        private const string SAKUJOFG_ON = "1";
        private const string SAISHINFG_ON = "1";
        private const string SAISHINFG_OFF = "0";
        private const string KARISHIENSOCHI = "2";
        private const decimal KOSHINCOUNTER_DEF = decimal.Zero;

        private const string FORMAT_UPDATETIME = "yyyyMMddHHmmssfff";

        private const string ERR_SHIENSOCHI = "Žx‰‡‘[’uŠÇ—";/* TODO ERROR: Skipped SkippedTokensTrivia
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
        public ABShienSochiBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

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
        #region Žx‰‡‘[’u’Šo@[GetShienSochi]
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼    Žx‰‡‘[’u’Šo
        // * 
        // * \•¶          Public Function GetShienSochi As DataSet
        // * 
        // * ‹@”\@@    @Žx‰‡‘[’u‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”          strShienSochiKanriNo : Žx‰‡‘[’uŠÇ—”Ô† 
        // * 
        // * –ß‚è’l        DataSet : Žæ“¾‚µ‚½Žx‰‡‘[’u‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetShienSochi(string strShienSochiKanriNo)
        {

            return GetShienSochi(strShienSochiKanriNo, true, false);

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼    Žx‰‡‘[’u’Šo
        // * 
        // * \•¶          Public Function GetShienSochi As DataSet
        // * 
        // * ‹@”\@@    @Žx‰‡‘[’u‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”          strShienSochiKanriNo : Žx‰‡‘[’uŠÇ—”Ô†  
        // *               blnSaishin           : ÅVƒtƒ‰ƒO
        // *               blnSakujoFG          : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l        DataSet : Žæ“¾‚µ‚½Žx‰‡‘[’u‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetShienSochi(string strShienSochiKanriNo, bool blnSaishin, bool blnSakujoFG)
        {

            const string THIS_METHOD_NAME = "GetShienSochi";
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            DataSet csShienSochiEntity;
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
                    throw new UFAppException(objErrorStruct.m_strErrorMessage + ERR_SHIENSOCHI, objErrorStruct.m_strErrorCode);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // SELECT‹å‚Ì¶¬
                strSQL.Append(CreateSelect());
                // FROM‹å‚Ì¶¬
                strSQL.AppendFormat(" FROM {0} ", ABShienSochiEntity.TABLE_NAME);

                // ÃÞ°À½·°Ï‚ÌŽæ“¾
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABShienSochiEntity.TABLE_NAME, false);
                }

                // WHERE‹å‚Ìì¬
                strSQL.Append(CreateWhere(strShienSochiKanriNo, blnSaishin, blnSakujoFG));

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 8703


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString(), m_cfSelectUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csShienSochiEntity = m_csDataSchma.Clone();
                csShienSochiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csShienSochiEntity, ABShienSochiEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9675


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9771


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10039


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10122


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csShienSochiEntity;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼    Žx‰‡‘[’u’Šo
        // * 
        // * \•¶          Public Function GetShienSochi As DataSet
        // * 
        // * ‹@”\@@    @Žx‰‡‘[’u‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”          strShienSochiKanriNo : Žx‰‡‘[’uŠÇ—”Ô†‚Ì”z—ñ       
        // * 
        // * –ß‚è’l        DataSet : Žæ“¾‚µ‚½Žx‰‡‘[’u‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetShienSochi(string[] strShienSochiKanriNo)
        {

            const string THIS_METHOD_NAME = "GetShienSochi";
            DataSet csShienSochiEntity;
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
                strSQL.AppendFormat(" FROM {0} ", ABShienSochiEntity.TABLE_NAME);

                // ÃÞ°À½·°Ï‚ÌŽæ“¾
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABShienSochiEntity.TABLE_NAME, false);
                }

                // WHERE‹å‚Ìì¬
                if (strShienSochiKanriNo.Length == 0)
                {
                    csShienSochiEntity = m_csDataSchma.Clone();
                }
                else
                {
                    strSQL.Append(" WHERE ");
                    strSQL.Append(ABShienSochiEntity.SHIENSOCHIKANRINO);
                    strSQL.Append(" IN (");

                    for (int i = 0, loopTo = strShienSochiKanriNo.Length - 1; i <= loopTo; i++)
                    {
                        // -----------------------------------------------------------------------------
                        // Žx‰‡‘[’uŠÇ—”Ô†
                        strParameterName = ABShienSochiEntity.KEY_SHIENSOCHIKANRINO + i.ToString();

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
                    strSQL.Append(ABShienSochiEntity.SAISHINFG);

                    strSQL.Append(" = '1'");

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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13847


                                        Input:
                                        " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString(), m_cfSelectUFParameterCollectionClass) + "z")

                                                        ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                         */
                    csShienSochiEntity = m_csDataSchma.Clone();
                    csShienSochiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csShienSochiEntity, ABShienSochiEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 14850


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 14946


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 15214


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 15297


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csShienSochiEntity;

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
                csSELECT.AppendFormat("SELECT {0}", ABShienSochiEntity.SHICHOSONCD);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.SHIENSOCHIKANRINO);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.RIREKINO);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.SAISHINFG);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.UKETSUKEKBN);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.UKETSUKEYMD);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.SHIENSOCHIKBN);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.KARISHIENSOCHIUMU);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.KARISHIENSOCHISTYMD);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.KARISHIENSOCHIEDYMD);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.SHIENSOCHISTYMD);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.SHIENSOCHIEDYMD);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.SHIENFUYOKAKUNINRENRAKUYMD);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TOSHOUKETSUKESHICHOSONCD);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TOSHOUKETSUKESHICHOSON);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.GYOMUCD);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.BIKO);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD1);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON1);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD1);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD2);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON2);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD2);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD3);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON3);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD3);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD4);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON4);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD4);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD5);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON5);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD5);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD6);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON6);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD6);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD7);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON7);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD7);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD8);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON8);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD8);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD9);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON9);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD9);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD10);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON10);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD10);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD11);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON11);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD11);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD12);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON12);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD12);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD13);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON13);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD13);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD14);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON14);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD14);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD15);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON15);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD15);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD16);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON16);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD16);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD17);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON17);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD17);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD18);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON18);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD18);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD19);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON19);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD19);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSONCD20);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOSHICHOSON20);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TENSOYMD20);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.KANRIKB);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.SETAIYOKUSHIKB);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.RESERVE1);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.RESERVE2);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.RESERVE3);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.RESERVE4);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.RESERVE5);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.NYURYOKUBASHOCD);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.NYURYOKUBASHO);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.TANMATSUID);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.SAKUJOFG);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.KOSHINCOUNTER);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.SAKUSEINICHIJI);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.SAKUSEIUSER);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.KOSHINNICHIJI);
                csSELECT.AppendFormat(", {0}", ABShienSochiEntity.KOSHINUSER);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 24200


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 24298


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 24568


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 24653


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
        // * \•¶         Private Sub CreateWhere
        // * 
        // * ‹@”\         WHERE•ª‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”         strShienSochiKanriNo: Žx‰‡‘[’uŠÇ—”Ô† 
        // *              blnSaishin          : ÅVƒtƒ‰ƒO
        // *              blnSakujoFG         : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l       ‚È‚µ
        // ************************************************************************************************
        private string CreateWhere(string strShienSochiKanriNo, bool blnSaishin, bool blnSakujoFG)
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
                csWHERE.AppendFormat("WHERE {0} = {1}", ABShienSochiEntity.SHIENSOCHIKANRINO, ABShienSochiEntity.KEY_SHIENSOCHIKANRINO);
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABShienSochiEntity.KEY_SHIENSOCHIKANRINO;
                cfUFParameterClass.Value = strShienSochiKanriNo;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);

                // ÅVƒtƒ‰ƒO
                if (blnSaishin)
                {
                    csWHERE.AppendFormat(" AND {0} = {1}", ABShienSochiEntity.SAISHINFG, SAISHINFG_ON);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // íœƒtƒ‰ƒO
                if (blnSakujoFG == false)
                {
                    csWHERE.AppendFormat(" AND {0} <> '{1}'", ABShienSochiEntity.SAKUJOFG, SAKUJOFG_ON);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 27990


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 28086


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 28354


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 28437


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csWHERE.ToString();

        }
        #endregion

        #region Žx‰‡‘[’u’Ç‰Á@[InsertShienSochi]
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Žx‰‡‘[’u’Ç‰Á
        // * 
        // * \•¶           Public Function InsertShienSochi((ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@Žx‰‡‘[’u‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertShienSochi(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "InsertShienSochi";
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
                csDataRow(ABShienSochiEntity.TANMATSUID) = m_cfControlData.m_strClientId;     // ’[––‚h‚c
                csDataRow(ABShienSochiEntity.KOSHINCOUNTER) = KOSHINCOUNTER_DEF;              // XVƒJƒEƒ“ƒ^
                csDataRow(ABShienSochiEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;      // ì¬ƒ†[ƒU[
                csDataRow(ABShienSochiEntity.SAKUSEINICHIJI) = m_strUpdateDatetime;           // ì¬“úŽž
                csDataRow(ABShienSochiEntity.KOSHINUSER) = m_cfControlData.m_strUserId;       // XVƒ†[ƒU[
                csDataRow(ABShienSochiEntity.KOSHINNICHIJI) = m_strUpdateDatetime;             // XV“úŽž

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    cfParam.Value = csDataRow(cfParam.ParameterName.RSubstring(ABShienSochiEntity.PARAM_PLACEHOLDER.RLength)).ToString();

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31614


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 32379


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 32475


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 32743


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 32826


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intInsCnt;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Insert—pSQL•¶‚Ìì¬
        // * 
        // * \•¶           Private Sub CreateInsertSQL(ByVal csDataRow As DataRow)
        // * 
        // * ‹@”\           INSERT—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void CreateInsertSQL(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "CreateInsertSQL";
            StringBuilder csInsertColumn;                 // INSERT—pƒJƒ‰ƒ€’è‹`
            StringBuilder csInsertParam;                  // INSERT—pƒpƒ‰ƒ[ƒ^’è‹`
            UFParameterClass cfUFParameterClass;
            string strParamName;


            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SELECT SQL•¶‚Ìì¬
                csInsertColumn = new StringBuilder();
                csInsertParam = new StringBuilder();

                // INSERT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfInsertUFParameterCollectionClass = new UFParameterCollectionClass();

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                {
                    cfUFParameterClass = new UFParameterClass();
                    strParamName = string.Format("{0}{1}", ABShienSochiEntity.PARAM_PLACEHOLDER, csDataColumn.ColumnName);

                    // INSERT SQL•¶‚Ìì¬
                    csInsertColumn.AppendFormat("{0},", csDataColumn.ColumnName);
                    csInsertParam.AppendFormat("{0},", strParamName);

                    // INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    cfUFParameterClass.ParameterName = strParamName;
                    m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass);

                }

                // ÅŒã‚ÌƒJƒ“ƒ}‚ðŽæ‚èœ‚¢‚ÄINSERT•¶‚ðì¬
                m_strInsertSQL = string.Format("INSERT INTO {0}({1}) VALUES ({2})", ABShienSochiEntity.TABLE_NAME, csInsertColumn.ToString().TrimEnd(",".ToCharArray()), csInsertParam.ToString().TrimEnd(",".ToCharArray()));

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36233


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36331


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36601


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36686


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }

        #endregion

        #region Žx‰‡‘[’uXV@[UpdateShienSochi]
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Žx‰‡‘[’uXV
        // * 
        // * \•¶           Public Function UpdateShienSochi(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @ Žx‰‡‘[’u‚Ìƒf[ƒ^‚ðXV‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : XV‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int UpdateShienSochi(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "UpdateShienSochi";                     // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            int intUpdCnt;                            // XVŒ”


            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strUpdateSQL is null || string.IsNullOrEmpty(m_strUpdateSQL) || m_cfUpdateUFParameterCollectionClass is null)
                {
                    CreateUpdateSQL(csDataRow);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABShienSochiEntity.SAISHINFG) = SAISHINFG_OFF;                                                    // ÅVƒtƒ‰ƒO
                csDataRow(ABShienSochiEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                   // ’[––‚h‚c
                csDataRow(ABShienSochiEntity.KOSHINCOUNTER) = (decimal)csDataRow(ABShienSochiEntity.KOSHINCOUNTER) + 1m;        // XVƒJƒEƒ“ƒ^
                csDataRow(ABShienSochiEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                     // XVƒ†[ƒU[

                // XV“úŽž‚ÌÝ’è
                m_strUpdateDatetime = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME);
                csDataRow(ABShienSochiEntity.KOSHINNICHIJI) = m_strUpdateDatetime;

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABShienSochiEntity.PREFIX_KEY.RLength) == ABShienSochiEntity.PREFIX_KEY)
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABShienSochiEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }

                    // ƒL[€–ÚˆÈŠO‚Í•ÒW“à—eŽæ“¾
                    else
                    {
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABShienSochiEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40605


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs
                                            intUpdCnt = m_cfRdbClass.ExecuteSQL(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass)

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 41370


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 41466


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 41734


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 41817


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intUpdCnt;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Update—pSQL•¶‚Ìì¬
        // * 
        // * \•¶           Private Sub CreateUpdateSQL(ByVal csDataRow As DataRow)
        // * 
        // * ‹@”\           UPDATE—p‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void CreateUpdateSQL(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "CreateUpdateSQL";
            UFParameterClass cfUFParameterClass;
            StringBuilder csWhere;                        // WHERE’è‹`
            StringBuilder csUpdateParam;                  // UPDATE—pSQL’è‹`


            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // UPDATE SQL•¶‚Ìì¬
                m_strUpdateSQL = "UPDATE " + ABShienSochiEntity.TABLE_NAME + " SET ";
                csUpdateParam = new StringBuilder();

                // WHERE•¶‚Ìì¬
                csWhere = new StringBuilder();
                csWhere.Append(" WHERE ");
                csWhere.Append(ABShienSochiEntity.SHIENSOCHIKANRINO);
                csWhere.Append(" = ");
                csWhere.Append(ABShienSochiEntity.KEY_SHIENSOCHIKANRINO);
                csWhere.Append(" AND ");
                csWhere.Append(ABShienSochiEntity.RIREKINO);
                csWhere.Append(" = ");
                csWhere.Append(ABShienSochiEntity.KEY_RIREKINO);
                csWhere.Append(" AND ");
                csWhere.Append(ABShienSochiEntity.KOSHINCOUNTER);
                csWhere.Append(" = ");
                csWhere.Append(ABShienSochiEntity.KEY_KOSHINCOUNTER);

                // UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfUpdateUFParameterCollectionClass = new UFParameterCollectionClass();

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                {
                    // Žx‰‡‘[’uŠÇ—”Ô†E—š—ð”Ô†Eì¬“úŽžEì¬ƒ†[ƒU‚ÍXV‚µ‚È‚¢
                    if (!(csDataColumn.ColumnName == ABShienSochiEntity.SHIENSOCHIKANRINO) && !(csDataColumn.ColumnName == ABShienSochiEntity.RIREKINO) && !(csDataColumn.ColumnName == ABShienSochiEntity.SAKUSEIUSER) && !(csDataColumn.ColumnName == ABShienSochiEntity.SAKUSEINICHIJI))
                    {

                        cfUFParameterClass = new UFParameterClass();

                        // UPDATE SQL•¶‚Ìì¬
                        csUpdateParam.Append(csDataColumn.ColumnName);
                        csUpdateParam.Append(" = ");
                        csUpdateParam.Append(ABShienSochiEntity.PARAM_PLACEHOLDER);
                        csUpdateParam.Append(csDataColumn.ColumnName);
                        csUpdateParam.Append(",");

                        // UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                        cfUFParameterClass.ParameterName = ABShienSochiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
                        m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }

                }

                // UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                m_strUpdateSQL += csUpdateParam.ToString().TrimEnd(",".ToCharArray());

                // UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                m_strUpdateSQL += csWhere.ToString();

                // UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABShienSochiEntity.KEY_SHIENSOCHIKANRINO;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABShienSochiEntity.KEY_RIREKINO;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABShienSochiEntity.KEY_KOSHINCOUNTER;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 47011


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 47109


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 47379


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 47464


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }

        #endregion

        #region Žx‰‡‘[’uíœ@[DeleteShienSochi]
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Žx‰‡‘[’uíœ
        // * 
        // * \•¶           Public Function DeleteShienSochi(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@Žx‰‡‘[’u‚Ìƒf[ƒ^‚ð˜_—íœ‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ˜_—íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int DeleteShienSochi(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "DeleteShienSochi";  // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            int intDelCnt;        // íœŒ”


            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strDelRonriSQL is null || string.IsNullOrEmpty(m_strDelRonriSQL) || m_cfDelRonriUFParameterCollectionClass is null)
                {
                    CreateDeleteRonriSQL(csDataRow);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABShienSochiEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                   // ’[––‚h‚c
                csDataRow(ABShienSochiEntity.SAKUJOFG) = SAKUJOFG_ON;                                                       // íœƒtƒ‰ƒO
                csDataRow(ABShienSochiEntity.KOSHINCOUNTER) = (decimal)csDataRow(ABShienSochiEntity.KOSHINCOUNTER) + 1m;        // XVƒJƒEƒ“ƒ^
                csDataRow(ABShienSochiEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                     // XVƒ†[ƒU[

                // XV“úŽž‚ÌÝ’è
                m_strUpdateDatetime = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME);
                this.SetUpdateDatetime(csDataRow(ABShienSochiEntity.KOSHINNICHIJI));

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfDelRonriUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABShienSochiEntity.PREFIX_KEY.RLength) == ABShienSochiEntity.PREFIX_KEY)
                    {
                        this.m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABShienSochiEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    // ƒL[€–ÚˆÈŠO‚Í•ÒW“à—e‚ðÝ’è
                    else
                    {
                        this.m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABShienSochiEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 51342


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass) + "z")
                                            ' SQL‚ÌŽÀs
                                            intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass)

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 52114


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 52210


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 52478


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return intDelCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     Žx‰‡‘[’u•¨—íœ
                    '* 
                    '* \•¶           Public Function DeleteShienSochi(ByVal csDataRow As DataRow, _
                    '*                                               ByVal strSakujoKB As String) As Integer
                    '* 
                    '* ‹@”\@@    @@Žx‰‡‘[’u‚Ìƒf[ƒ^‚ð•¨—íœ‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
                    '* 
                    '* –ß‚è’l         Integer : íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
                    '************************************************************************************************
                    Public Overloads Function DeleteShienSochi(ByVal csDataRow As DataRow,
                                                             ByVal strSakujoKB As String) As Integer

                        Const THIS_METHOD_NAME As String = "DeleteShienSochi"
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
                                If (cfParam.ParameterName.RSubstring(0, ABShienSochiEntity.PREFIX_KEY.RLength) = ABShienSochiEntity.PREFIX_KEY) Then
                                    m_cfDelButuriUFParameterCollectionClass(cfParam.ParameterName).Value _
                                            = csDataRow(cfParam.ParameterName.RSubstring(ABShienSochiEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString()

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
                            csWhere.Append(ABShienSochiEntity.SHIENSOCHIKANRINO)
                            csWhere.Append(" = ")
                            csWhere.Append(ABShienSochiEntity.KEY_SHIENSOCHIKANRINO)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABShienSochiEntity.RIREKINO)
                            csWhere.Append(" = ")
                            csWhere.Append(ABShienSochiEntity.KEY_RIREKINO)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABShienSochiEntity.KOSHINCOUNTER)
                            csWhere.Append(" = ")
                            csWhere.Append(ABShienSochiEntity.KEY_KOSHINCOUNTER)


                            ' ˜_—DELETE SQL•¶‚Ìì¬
                            csDelRonriParam = New StringBuilder
                            csDelRonriParam.Append("UPDATE ")
                            csDelRonriParam.Append(ABShienSochiEntity.TABLE_NAME)
                            csDelRonriParam.Append(" SET ")
                            csDelRonriParam.Append(ABShienSochiEntity.NYURYOKUBASHOCD)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABShienSochiEntity.PARAM_NYURYOKUBASHOCD)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABShienSochiEntity.NYURYOKUBASHO)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABShienSochiEntity.PARAM_NYURYOKUBASHO)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABShienSochiEntity.TANMATSUID)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABShienSochiEntity.PARAM_TANMATSUID)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABShienSochiEntity.SAKUJOFG)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABShienSochiEntity.PARAM_SAKUJOFG)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABShienSochiEntity.KOSHINCOUNTER)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABShienSochiEntity.PARAM_KOSHINCOUNTER)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABShienSochiEntity.KOSHINNICHIJI)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABShienSochiEntity.PARAM_KOSHINNICHIJI)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABShienSochiEntity.KOSHINUSER)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABShienSochiEntity.PARAM_KOSHINUSER)
                            csDelRonriParam.Append(csWhere)
                            ' Where•¶‚Ì’Ç‰Á
                            m_strDelRonriSQL = csDelRonriParam.ToString

                            ' ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDelRonriUFParameterCollectionClass = New UFParameterCollectionClass

                            ' ˜_—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiEntity.PARAM_NYURYOKUBASHOCD
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiEntity.PARAM_NYURYOKUBASHO
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiEntity.PARAM_TANMATSUID
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiEntity.PARAM_SAKUJOFG
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiEntity.PARAM_KOSHINCOUNTER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiEntity.PARAM_KOSHINNICHIJI
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiEntity.PARAM_KOSHINUSER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiEntity.KEY_SHIENSOCHIKANRINO
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiEntity.KEY_RIREKINO
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiEntity.KEY_KOSHINCOUNTER
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
                            csWhere.Append(ABShienSochiEntity.SHIENSOCHIKANRINO)
                            csWhere.Append(" = ")
                            csWhere.Append(ABShienSochiEntity.KEY_SHIENSOCHIKANRINO)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABShienSochiEntity.RIREKINO)
                            csWhere.Append(" = ")
                            csWhere.Append(ABShienSochiEntity.KEY_RIREKINO)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABShienSochiEntity.KOSHINCOUNTER)
                            csWhere.Append(" = ")
                            csWhere.Append(ABShienSochiEntity.KEY_KOSHINCOUNTER)

                            ' •¨—DELETE SQL•¶‚Ìì¬
                            m_strDelButuriSQL = "DELETE FROM " + ABShienSochiEntity.TABLE_NAME + csWhere.ToString

                            ' •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDelButuriUFParameterCollectionClass = New UFParameterCollectionClass

                            ' •¨—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiEntity.KEY_SHIENSOCHIKANRINO
                            m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiEntity.KEY_RIREKINO
                            m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiEntity.KEY_KOSHINCOUNTER
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

                #Region "Žx‰‡‘[’uî•ñŽæ“¾"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     Žx‰‡‘[’uî•ñŽæ“¾
                    '* 
                    '* \•¶           Public Function GetShienSochiJoho(ByVal strJumincd As String) As DataSet
                    '* 
                    '* ‹@”\@@    @ Žx‰‡‘[’u‚ÆŽx‰‡‘[’u‘ÎÛ‚©‚çƒf[ƒ^‚ðŽæ“¾
                    '* 
                    '* ˆø”           strJumincdFZ–¯ƒR[ƒh
                    '* 
                    '* –ß‚è’l         Žæ“¾‚µ‚½ƒf[ƒ^FDataSet
                    '************************************************************************************************
                    Public Function GetShienSochiJoho(ByVal strJumincd As String) As DataSet
                        Const THIS_METHOD_NAME As String = "GetShienSochiJoho"
                        Dim csShienSochiDS As DataSet                                        ' Žx‰‡‘[’uƒf[ƒ^
                        Dim strSQL As StringBuilder                                         ' SQL•¶SELECT‹å
                        Dim cfUFParameterClass As UFParameterClass                          ' ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim cfUFParameterCollectionClass As UFParameterCollectionClass      ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            strSQL = New StringBuilder

                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                            cfUFParameterCollectionClass = New UFParameterCollectionClass

                            ' SQL•¶‚Ìì¬
                            strSQL.Append("SELECT ")
                            strSQL.Append(ABShienSochiEntity.TABLE_NAME)
                            strSQL.Append(".* ")
                            strSQL.Append(" FROM ")
                            strSQL.Append(ABShienSochiEntity.TABLE_NAME)
                            strSQL.Append(" INNER JOIN ")
                            strSQL.Append(ABShienSochiTaishoEntity.TABLE_NAME)
                            strSQL.Append(" ON ")
                            strSQL.AppendFormat("{0}.{1}", ABShienSochiEntity.TABLE_NAME, ABShienSochiEntity.SHIENSOCHIKANRINO)
                            strSQL.Append(" = ")
                            strSQL.AppendFormat("{0}.{1}", ABShienSochiTaishoEntity.TABLE_NAME, ABShienSochiTaishoEntity.SHIENSOCHIKANRINO)
                            strSQL.Append(" AND ")
                            strSQL.Append(ABShienSochiTaishoEntity.JUMINCD)
                            strSQL.Append(" = ")
                            strSQL.Append(ABShienSochiTaishoEntity.PARAM_JUMINCD)

                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            ' Z–¯ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiTaishoEntity.PARAM_JUMINCD
                            cfUFParameterClass.Value = strJumincd
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' WHERE‹å‚Ìì¬
                            strSQL.Append(" WHERE ")
                            strSQL.AppendFormat("{0} = '{1}'", ABShienSochiEntity.SAISHINFG, SAISHINFG_ON)
                            strSQL.AppendFormat(" AND {0}.{1} <> '{2}'", ABShienSochiEntity.TABLE_NAME, ABShienSochiEntity.SAKUJOFG, SAKUJOFG_ON)
                            strSQL.Append(" ORDER BY ")
                            strSQL.AppendFormat("{0}.{1}", ABShienSochiEntity.TABLE_NAME, ABShienSochiEntity.SHIENSOCHIKANRINO)
                            strSQL.Append(" DESC")

                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" +
                                                        "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")

                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                            csShiensochids = m_cfRdbClass.GetDataSet(strSQL.ToString, ABShienSochiEntity.TABLE_NAME, cfUFParameterCollectionClass, False)

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
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return csShienSochiDS

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‰¼Žx‰‡‘[’uƒ`ƒFƒbƒN
                    '* 
                    '* \•¶           Public Function CheckKariShienSochi(ByVal strSystemYMD As String) As DataSet
                    '* 
                    '* ‹@”\@@    @ Žx‰‡‘[’u‚ÆŽx‰‡‘[’u‘ÎÛ‚©‚çƒf[ƒ^‚ðŽæ“¾
                    '* 
                    '* ˆø”           strSystemYMDFƒVƒXƒeƒ€“ú•t
                    '* 
                    '* –ß‚è’l         Žæ“¾‚µ‚½ƒf[ƒ^FDataSet
                    '************************************************************************************************
                    Public Function CheckKariShienSochi(ByVal strSystemYMD As String) As DataSet
                        Const THIS_METHOD_NAME As String = "CheckKariShienSochi"
                        Dim cABKanriJohoB As ABAtenaKanriJohoBClass         'ˆ¶–¼ŠÇ—î•ñƒNƒ‰ƒX
                        Dim csABKanriJohoDS As DataSet
                        Dim intNisu As Integer
                        Dim csShienSochiDS As DataSet                                        ' Žx‰‡‘[’uƒf[ƒ^
                        Dim strSQL As StringBuilder                                         ' SQL•¶SELECT‹å
                        Dim cfUFParameterClass As UFParameterClass                          ' ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim cfUFParameterCollectionClass As UFParameterCollectionClass      ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
                        Dim cfDate As UFDateClass

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ˆ¶–¼ŠÇ—î•ñƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            cABKanriJohoB = New ABAtenaKanriJohoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                            ' ŠÇ—î•ñŽæ“¾ƒƒ\ƒbƒhŽÀs(ŒÂl§Œä‹@”\(20)A‰¼Žx‰‡Œx“ú”(84))
                            csABKanriJohoDS = cABKanriJohoB.GetKanriJohoHoshu("20", "84")

                            ' ŠÇ—î•ñƒ`ƒFƒbƒN
                            If (Not (csABKanriJohoDS Is Nothing) AndAlso csABKanriJohoDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count > 0) AndAlso
                                (UFStringClass.CheckNumber(csABKanriJohoDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0)(ABAtenaKanriJohoEntity.PARAMETER).ToString.Trim)) Then
                                intNisu = CType(csABKanriJohoDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0)(ABAtenaKanriJohoEntity.PARAMETER).ToString, Integer)
                            Else
                                intNisu = 30
                            End If
                            cfDate = New UFDateClass(m_cfConfigDataClass, UFDateSeparator.None, UFDateFillType.Zero)
                            intNisu = intNisu * -1
                            cfDate.p_strDateValue = strSystemYMD
                            cfDate.p_strDateValue = cfDate.AddDay(intNisu)

                            strSQL = New StringBuilder

                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                            cfUFParameterCollectionClass = New UFParameterCollectionClass

                            ' SQL•¶‚Ìì¬
                            strSQL.Append("SELECT DISTINCT ")
                            strSQL.AppendFormat("{0}.{1}", ABShienSochiTaishoEntity.TABLE_NAME, ABShienSochiTaishoEntity.JUMINCD)
                            strSQL.Append(" FROM ")
                            strSQL.Append(ABShienSochiEntity.TABLE_NAME)
                            strSQL.Append(" INNER JOIN ")
                            strSQL.Append(ABShienSochiTaishoEntity.TABLE_NAME)
                            strSQL.Append(" ON ")
                            strSQL.AppendFormat("{0}.{1}", ABShienSochiEntity.TABLE_NAME, ABShienSochiEntity.SHIENSOCHIKANRINO)
                            strSQL.Append(" = ")
                            strSQL.AppendFormat("{0}.{1}", ABShienSochiTaishoEntity.TABLE_NAME, ABShienSochiTaishoEntity.SHIENSOCHIKANRINO)

                            ' WHERE‹å‚Ìì¬
                            strSQL.Append(" WHERE ")
                            strSQL.AppendFormat("{0}.{1} = '{2}'", ABShienSochiEntity.TABLE_NAME, ABShienSochiEntity.SHIENSOCHIKBN, KARISHIENSOCHI)
                            strSQL.AppendFormat(" AND {0}.{1} = '{2}'", ABShienSochiEntity.TABLE_NAME, ABShienSochiEntity.SAISHINFG, SAISHINFG_ON)
                            strSQL.AppendFormat(" AND {0}.{1} = '{2}'", ABShienSochiEntity.TABLE_NAME, ABShienSochiEntity.KARISHIENSOCHIEDYMD, "99999999")
                            strSQL.AppendFormat(" AND {0}.{1} < {2}", ABShienSochiEntity.TABLE_NAME, ABShienSochiEntity.KARISHIENSOCHISTYMD, ABShienSochiEntity.PARAM_KARISHIENSOCHISTYMD)
                            strSQL.AppendFormat(" AND {0}.{1} <> '{2}'", ABShienSochiEntity.TABLE_NAME, ABShienSochiEntity.SAKUJOFG, SAKUJOFG_ON)

                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            ' ƒVƒXƒeƒ€“ú•t
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiEntity.PARAM_KARISHIENSOCHISTYMD
                            cfUFParameterClass.Value = cfDate.p_strSeirekiYMD
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" +
                                                        "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")

                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                            csShienSochiDS = m_cfRdbClass.GetDataSet(strSQL.ToString, ABShienSochiEntity.TABLE_NAME, cfUFParameterCollectionClass, False)

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
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return csShienSochiDS

                    End Function
                #End Region

                #Region "Žx‰‡‘[’uî•ñŽæ“¾"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     Žx‰‡‘[’uî•ñŽæ“¾
                    '* 
                    '* \•¶           Public Function GetShienSochi(ByVal strShienSochiNo As String, ByVal strRirekiNo As String) As DataSet
                    '* 
                    '* ‹@”\@@    @ Žx‰‡‘[’u”Ô†‚Æ—š—ð”Ô†‚©‚çƒf[ƒ^‚ðŽæ“¾
                    '* 
                    '* ˆø”           strShienSochiNoFZ–¯ƒR[ƒh
                    '*                strRirekiNO    :—š—ð”Ô†
                    '* 
                    '* –ß‚è’l         Žæ“¾‚µ‚½ƒf[ƒ^FDataSet
                    '************************************************************************************************
                    Public Overloads Function GetShienSochi(ByVal strShienSochiNo As String, ByVal strRirekiNo As String) As DataSet
                        Const THIS_METHOD_NAME As String = "GetShienSochi"
                        Dim csShienSochiDS As DataSet                                        ' Žx‰‡‘[’uƒf[ƒ^
                        Dim strSQL As StringBuilder                                         ' SQL•¶SELECT‹å
                        Dim cfUFParameterClass As UFParameterClass                          ' ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim cfUFParameterCollectionClass As UFParameterCollectionClass      ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            strSQL = New StringBuilder

                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                            cfUFParameterCollectionClass = New UFParameterCollectionClass

                            ' SQL•¶‚Ìì¬
                            ' SELECT‹å‚Ì¶¬
                            strSQL.Append(Me.CreateSelect)
                            ' FROM‹å‚Ì¶¬
                            strSQL.AppendFormat(" FROM {0} ", ABShienSochiEntity.TABLE_NAME)

                            ' ÃÞ°À½·°Ï‚ÌŽæ“¾
                            If (m_csDataSchma Is Nothing) Then
                                m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABShienSochiEntity.TABLE_NAME, False)
                            End If

                            strSQL.AppendFormat("WHERE {0} = {1}", ABShienSochiEntity.SHIENSOCHIKANRINO, ABShienSochiEntity.KEY_SHIENSOCHIKANRINO)
                            strSQL.AppendFormat(" AND {0} = {1}", ABShienSochiEntity.RIREKINO, ABShienSochiEntity.KEY_RIREKINO)

                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            ' Žx‰‡‘[’uŠÇ—”Ô†
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiEntity.KEY_SHIENSOCHIKANRINO
                            cfUFParameterClass.Value = strShienSochiNo
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' —š—ð”Ô†
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABShienSochiEntity.KEY_RIREKINO
                            cfUFParameterClass.Value = strRirekiNo
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" +
                                                        "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")

                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                            csShienSochiDS = m_cfRdbClass.GetDataSet(strSQL.ToString, ABShienSochiEntity.TABLE_NAME, cfUFParameterCollectionClass, False)

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
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return csShienSochiDS

                    End Function

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