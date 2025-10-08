// ************************************************************************************************
// * ‹Æ–±–¼           ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼         ‚`‚a‚…‚k‚s‚`‚wŽóM‚w‚l‚kƒ}ƒXƒ^(ABLTXmlDatBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t             2009/07/15
// *
// * ì¬ŽÒ           ”ä‰Ã@Œv¬
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2010/04/16   000001     VS2008‘Î‰ži”ä‰Ãj
// * 2011/08/30   000002     eLTAX—˜—p“Ío˜AŒg‚Ìíœ‹@”\’Ç‰Á‚É”º‚¤‰üCi”ä‰Ãj
// ************************************************************************************************
using System;
using System.Linq;
using System.Text;

namespace Densan.Reams.AB.AB000BB
{

    public class ABLTXmlDatBClass
    {

        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX

        private DataSet m_csDataSchma;                        // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private string m_strInsertSQL;
        private string m_strUpDateSQL;
        private string m_strUpDateSQL_ConvertFG;
        private string m_strUpDateSQL_SakujoFG;
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;  // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateUFParameterCollectionClass;  // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateConvertFGUFParameterCollectionClass;  // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateSakujoFGUFParameterCollectionClass;  // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
                                                                                          // *—š—ð”Ô† 000002 2011/08/30 ’Ç‰ÁŠJŽn
        private string m_strDeleteSQL;
        private UFParameterCollectionClass m_cfDeleteUFParameterCollectionClass;  // DELETE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
                                                                                  // *—š—ð”Ô† 000002 2011/08/30 ’Ç‰ÁI—¹

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABLTXmlDatBClass";
        private const string THIS_BUSINESSID = "AB";                              // ‹Æ–±ƒR[ƒh

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
        public ABLTXmlDatBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigDataClass;
            m_cfRdbClass = cfRdbClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(m_cfConfigDataClass, m_cfControlData.m_strBusinessId);

            // SQL•¶‚Ìì¬
            m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction("SELECT * FROM " + ABLTXMLDatEntity.TABLE_NAME, ABLTXMLDatEntity.TABLE_NAME, false);

        }
        #endregion

        #region ƒƒ\ƒbƒh

        #region eLTAXŽóMXMLƒf[ƒ^Žæ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼   eLTAXŽóMXML“ÍoE\ƒf[ƒ^Žæ“¾
        // * 
        // * \•¶         Public Function GetLTXmlDat(ByVal csABLTXmlDatParaX As ABLTXmlDatParaXClass) As DataSet
        // * 
        // * ‹@”\@@     eLTAXŽóMXMLƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”         csABLTXmlDatParaX As ABLTXmlDatParaXClass   : eLTAXŽóMXMLƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
        // * 
        // * –ß‚è’l       Žæ“¾‚µ‚½‚…‚k‚s‚`‚wŽóM‚w‚l‚kƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                 \‘¢FcsLtXMLDatEntity    
        // ************************************************************************************************
        public DataSet GetLTXmlDat(ABLTXmlDatParaXClass csABLTXmlDatParaX)
        {
            const string THIS_METHOD_NAME = "GetLTXmlDat";

            // * corresponds to VS2008 Start 2010/04/16 000001
            // Dim objErrorStruct As UFErrorStruct                             ' ƒGƒ‰[’è‹`\‘¢‘Ì
            // * corresponds to VS2008 End 2010/04/16 000001
            DataSet csLtXMLDatEntity;                                 // —˜—p“ÍoŽóMƒ}ƒXƒ^
            var strSQL = new StringBuilder();                                 // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * ");
                strSQL.Append(" FROM ").Append(ABLTXMLDatEntity.TABLE_NAME);

                // WHERE‹å
                strSQL.Append(" WHERE ");

                // •K{ðŒ
                // * SHINKOKUSHINSEIKB = "R0" AND 
                strSQL.Append(ABLTXMLDatEntity.SHINKOKUSHINSEIKB).Append(" = ");
                strSQL.Append(ABLTXMLDatEntity.KEY_SHINKOKUSHINSEIKB);
                strSQL.Append(" AND ");
                strSQL.Append(ABLTXMLDatEntity.SAKUJOFG).Append(" <> ");
                strSQL.Append("'1'");


                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABLTXMLDatEntity.KEY_SHINKOKUSHINSEIKB;
                cfUFParameterClass.Value = ABConstClass.ELTAX_RIYOTDKD;

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // Å–Ú‹æ•ª
                if (csABLTXmlDatParaX.p_strTaxKB != ABEnumDefine.ZeimokuCDType.Empty)
                {
                    strSQL.Append(" AND ");

                    // Å–Ú‹æ•ª‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡A’ŠoðŒ‚É‚·‚é
                    strSQL.Append(ABLTXMLDatEntity.TAXKB).Append(" = ");
                    strSQL.Append(ABLTXMLDatEntity.KEY_TAXKB);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLTXMLDatEntity.KEY_TAXKB;
                    cfUFParameterClass.Value = (string)csABLTXmlDatParaX.p_strTaxKB;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                }
                else
                {
                }

                // ƒRƒ“ƒo[ƒgƒtƒ‰ƒO
                strSQL.Append(" AND ");
                if (csABLTXmlDatParaX.p_blnConvertFG == true)
                {
                    // ƒRƒ“ƒo[ƒgƒtƒ‰ƒO‚ªTrue‚Ìê‡A"1"‚ðŽæ“¾‚·‚é
                    strSQL.Append(ABLTXMLDatEntity.CONVERTFG).Append(" = ");
                    strSQL.Append("'1'");
                }

                else
                {
                    // ƒRƒ“ƒo[ƒgƒtƒ‰ƒO‚ªFalse‚Ìê‡A"1"ˆÈŠO‚ðŽæ“¾‚·‚é
                    strSQL.Append(ABLTXMLDatEntity.CONVERTFG).Append(" <> ");
                    strSQL.Append("'1'");

                }

                // Å‘åŽæ“¾Œ”ƒZƒbƒg
                if (csABLTXmlDatParaX.p_intMaxCount != 0)
                {
                    m_cfRdbClass.p_intMaxRows = csABLTXmlDatParaX.p_intMaxCount;
                }
                else
                {
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 8693


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")

                                            ' “ÍoE\ƒf[ƒ^Žæ“¾
                                            csLtXMLDatEntity = m_csDataSchma.Clone()
                                            csLtXMLDatEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, csLtXMLDatEntity, ABLTXMLDatEntity.TABLE_NAME, cfUFParameterCollectionClass, False)


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9579


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9682


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10213


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return csLtXMLDatEntity

                    End Function
                #End Region

                #Region "eLTAXŽóMXMLƒf[ƒ^Žæ“¾ƒƒ\ƒbƒh"

                 */
            }

            return default;
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼   eLTAXŽóMXML“ÍoE\ƒf[ƒ^Žæ“¾
        // * 
        // * \•¶         Public Function GetLTXmlDat(ByVal csABLTXmlDatParaX As ABLTXmlDatParaXClass, _
        // *                                          ByRef intAllCount As Integer) As DataSet
        // * 
        // * ‹@”\@@     eLTAXŽóMXMLƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”         csABLTXmlDatParaX As ABLTXmlDatParaXClass   : eLTAXŽóMXMLƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
        // *              intAllCount As Integer                      : ‘Sƒf[ƒ^Œ”
        // * 
        // * –ß‚è’l       Žæ“¾‚µ‚½‚…‚k‚s‚`‚wŽóM‚w‚l‚kƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                 \‘¢FcsLtXMLDatEntity    
        // ************************************************************************************************
        public DataSet GetLTXmlDat(ABLTXmlDatParaXClass csABLTXmlDatParaX, ref int intAllCount)
        {
            const string THIS_METHOD_NAME = "GetLTXmlDat";
            const string COL_COUNT = "COUNT";
            // * corresponds to VS2008 Start 2010/04/16 000001
            // Dim objErrorStruct As UFErrorStruct                             ' ƒGƒ‰[’è‹`\‘¢‘Ì
            // * corresponds to VS2008 End 2010/04/16 000001
            DataSet csLtXMLDatEntity;                                 // —˜—p“ÍoŽóMƒ}ƒXƒ^
            DataSet csLtXmlDat_All;                                   // —˜—p“ÍoŽóM‘SŒƒf[ƒ^
            var strSQL = new StringBuilder();                                 // SQL•¶•¶Žš—ñ
            var strSQL_ALL = new StringBuilder();                             // SQL•¶‘SŒŽæ“¾•¶Žš—ñ
            var strWhere = new StringBuilder();                               // WHERE•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * ");
                strSQL.Append(" FROM ").Append(ABLTXMLDatEntity.TABLE_NAME);

                strSQL_ALL.Append("SELECT COUNT(*) AS ").Append(COL_COUNT);
                strSQL_ALL.Append(" FROM ").Append(ABLTXMLDatEntity.TABLE_NAME);

                // WHERE‹å
                strWhere.Append(" WHERE ");

                // •K{ðŒ
                // * SHINKOKUSHINSEIKB = "R0" AND 
                strWhere.Append(ABLTXMLDatEntity.SHINKOKUSHINSEIKB).Append(" = ");
                strWhere.Append(ABLTXMLDatEntity.KEY_SHINKOKUSHINSEIKB);
                strWhere.Append(" AND ");

                // *—š—ð”Ô† 000002 2011/08/30 C³ŠJŽn
                if (csABLTXmlDatParaX.p_blnSakuJoFG == false)
                {
                    // eLTAXŽóMXMLƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX:íœƒtƒ‰ƒO="False"‚Ìê‡Aíœƒf[ƒ^ˆÈŠO‚ð’Šo
                    strWhere.Append(ABLTXMLDatEntity.SAKUJOFG).Append(" <> ");
                    strWhere.Append("'1'");
                }
                else
                {
                    // eLTAXŽóMXMLƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX:íœƒtƒ‰ƒO="True"‚Ìê‡Aíœƒf[ƒ^‚ð’Šo
                    strWhere.Append(ABLTXMLDatEntity.SAKUJOFG).Append(" = ");
                    strWhere.Append("'1'");
                }
                // strWhere.Append(ABLTXMLDatEntity.SAKUJOFG).Append(" <> ")
                // strWhere.Append("'1'")
                // *—š—ð”Ô† 000002 2011/08/30 C³I—¹


                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABLTXMLDatEntity.KEY_SHINKOKUSHINSEIKB;
                cfUFParameterClass.Value = ABConstClass.ELTAX_RIYOTDKD;

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // Å–Ú‹æ•ª
                if (csABLTXmlDatParaX.p_strTaxKB != ABEnumDefine.ZeimokuCDType.Empty)
                {
                    strWhere.Append(" AND ");

                    // Å–Ú‹æ•ª‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡A’ŠoðŒ‚É‚·‚é
                    strWhere.Append(ABLTXMLDatEntity.TAXKB).Append(" = ");
                    strWhere.Append(ABLTXMLDatEntity.KEY_TAXKB);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLTXMLDatEntity.KEY_TAXKB;
                    cfUFParameterClass.Value = (string)csABLTXmlDatParaX.p_strTaxKB;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                }
                else
                {
                }

                // ƒRƒ“ƒo[ƒgƒtƒ‰ƒO
                strWhere.Append(" AND ");
                if (csABLTXmlDatParaX.p_blnConvertFG == true)
                {
                    // ƒRƒ“ƒo[ƒgƒtƒ‰ƒO‚ªTrue‚Ìê‡A"1"‚ðŽæ“¾‚·‚é
                    strWhere.Append(ABLTXMLDatEntity.CONVERTFG).Append(" = ");
                    strWhere.Append("'1'");
                }

                else
                {
                    // ƒRƒ“ƒo[ƒgƒtƒ‰ƒO‚ªFalse‚Ìê‡A"1"ˆÈŠO‚ðŽæ“¾‚·‚é
                    strWhere.Append(ABLTXMLDatEntity.CONVERTFG).Append(" <> ");
                    strWhere.Append("'1'");

                }

                // Å‘åŽæ“¾Œ”ƒZƒbƒg
                if (csABLTXmlDatParaX.p_intMaxCount != 0)
                {
                    m_cfRdbClass.p_intMaxRows = csABLTXmlDatParaX.p_intMaxCount;
                }
                else
                {
                }

                // SQL•¶Œ‹‡ 
                strSQL.Append(strWhere.ToString());
                strSQL_ALL.Append(strWhere.ToString());

                // ‘SŒŽæ“¾ˆ—
                csLtXmlDat_All = m_cfRdbClass.GetDataSet(strSQL_ALL.ToString(), cfUFParameterCollectionClass);

                intAllCount = (int)csLtXmlDat_All.Tables(0).Rows(0)(COL_COUNT);


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 16750


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")

                                            ' “ÍoE\ƒf[ƒ^Žæ“¾
                                            csLtXMLDatEntity = m_csDataSchma.Clone()
                                            csLtXMLDatEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, csLtXMLDatEntity, ABLTXMLDatEntity.TABLE_NAME, cfUFParameterCollectionClass, False)


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17636


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17739


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 18270


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return csLtXMLDatEntity

                    End Function
                #End Region

                #Region "eLTAXŽóMXML“ÍoE\ƒf[ƒ^Œ”Žæ“¾ƒƒ\ƒbƒh"

                 */
            }

            return default;
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼   eLTAXŽóMXML“ÍoE\ƒf[ƒ^Œ”Žæ“¾
        // * 
        // * \•¶         Public Function GetLTXmlCount(ByVal csABLTXmlDatParaX As ABLTXmlDatParaXClass) As DataSet
        // * 
        // * ‹@”\@@     eLTAXŽóMXMLƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ÌŒ”‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”         csABLTXmlDatParaX As ABLTXmlDatParaXClass   : eLTAXŽóMXMLƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
        // * 
        // * –ß‚è’l       Žæ“¾‚µ‚½eLTAXŽóMƒf[ƒ^Œ”ƒf[ƒ^iDataSetj
        // *                 \‘¢FcsLtXMLDatCountDS    
        // ************************************************************************************************
        public DataSet GetLTXmlCount(ABLTXmlDatParaXClass csABLTXmlDatParaX)
        {
            const string THIS_METHOD_NAME = "GetLTXmlCount";

            // * corresponds to VS2008 Start 2010/04/16 000001
            // Dim objErrorStruct As UFErrorStruct                             ' ƒGƒ‰[’è‹`\‘¢‘Ì
            // * corresponds to VS2008 End 2010/04/16 000001
            DataSet csLtXMLDatCountDS;                                // ABeLTAXŽóMDATŒ”ƒf[ƒ^ƒZƒbƒg
            DataSet csDataSet;
            var strSQL = new StringBuilder();                                 // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
            DataRow csDataRow;
            DataRow csNewRow;
            int intCount = 0;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT ");
                strSQL.Append(ABLTXMLDatEntity.TAXKB).Append(", ");
                strSQL.Append(ABLTXMLDatEntity.PROCID).Append(", ");
                strSQL.Append("COUNT(*) AS COUNT");
                strSQL.Append(" FROM ").Append(ABLTXMLDatEntity.TABLE_NAME);

                // WHERE‹å
                strSQL.Append(" WHERE ");

                // •K{ðŒ
                // * SHINKOKUSHINSEIKB = "T0" AND 
                strSQL.Append(ABLTXMLDatEntity.SHINKOKUSHINSEIKB).Append(" = ");
                strSQL.Append(ABLTXMLDatEntity.KEY_SHINKOKUSHINSEIKB);
                strSQL.Append(" AND ");
                strSQL.Append(ABLTXMLDatEntity.SAKUJOFG).Append(" <> ");
                strSQL.Append("'1'");

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABLTXMLDatEntity.KEY_SHINKOKUSHINSEIKB;
                cfUFParameterClass.Value = ABConstClass.ELTAX_RIYOTDKD;

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // Å–Ú‹æ•ª
                if (csABLTXmlDatParaX.p_strTaxKB != ABEnumDefine.ZeimokuCDType.Empty)
                {
                    strSQL.Append(" AND ");

                    // Å–Ú‹æ•ª‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡A’ŠoðŒ‚É‚·‚é
                    strSQL.Append(ABLTXMLDatEntity.TAXKB).Append(" = ");
                    strSQL.Append(ABLTXMLDatEntity.KEY_TAXKB);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLTXMLDatEntity.KEY_TAXKB;
                    cfUFParameterClass.Value = (string)csABLTXmlDatParaX.p_strTaxKB;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                }
                else
                {
                }

                // ƒRƒ“ƒo[ƒgƒtƒ‰ƒO
                strSQL.Append(" AND ");
                if (csABLTXmlDatParaX.p_blnConvertFG == true)
                {
                    // ƒRƒ“ƒo[ƒgƒtƒ‰ƒO‚ªTrue‚Ìê‡A"1"‚ðŽæ“¾‚·‚é
                    strSQL.Append(ABLTXMLDatEntity.CONVERTFG).Append(" = ");
                    strSQL.Append("'1'");
                }

                else
                {
                    // ƒRƒ“ƒo[ƒgƒtƒ‰ƒO‚ªFalse‚Ìê‡A"1"ˆÈŠO‚ðŽæ“¾‚·‚é
                    strSQL.Append(ABLTXMLDatEntity.CONVERTFG).Append(" <> ");
                    strSQL.Append("'1'");

                }

                // GROUP BY‹å
                strSQL.Append(" GROUP BY ");
                strSQL.Append(ABLTXMLDatEntity.TAXKB).Append(", ");
                strSQL.Append(ABLTXMLDatEntity.PROCID);

                // ORDER BY‹å
                strSQL.Append(" ORDER BY ");
                strSQL.Append(ABLTXMLDatEntity.TAXKB).Append(", ");
                strSQL.Append(ABLTXMLDatEntity.PROCID);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 23617


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")

                                            ' ƒf[ƒ^Žæ“¾

                                 */
                csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString(), ABLTXMLDatEntity.TABLE_NAME, cfUFParameterCollectionClass, false);


                // eLTAXŽóMDATŒ”ƒf[ƒ^ƒe[ƒuƒ‹ì¬
                csLtXMLDatCountDS = CreateDataSet();


                // ‚…‚k‚s‚`‚wŽóM‚w‚l‚k“ÍoE\ƒf[ƒ^Œ”ƒf[ƒ^ƒZƒbƒg‚ÉƒZƒbƒg
                foreach (DataRow currentCsDataRow in csDataSet.Tables(ABLTXMLDatEntity.TABLE_NAME).Rows)
                {
                    csDataRow = currentCsDataRow;

                    csNewRow = csLtXMLDatCountDS.Tables(ABLTXmlDatCountData.TABLE_NAME).NewRow;

                    csNewRow(ABLTXmlDatCountData.TAXKB) = csDataRow(ABLTXMLDatEntity.TAXKB);
                    csNewRow(ABLTXmlDatCountData.PROCID) = csDataRow(ABLTXMLDatEntity.PROCID);
                    csNewRow(ABLTXmlDatCountData.PROCRYAKUMEI) = GetProcRyakumei((string)csDataRow(ABLTXMLDatEntity.PROCID));
                    csNewRow(ABLTXmlDatCountData.COUNT) = csDataRow("COUNT");

                    csLtXMLDatCountDS.Tables(ABLTXmlDatCountData.TABLE_NAME).Rows.Add(csNewRow);

                }
                // ----------------------------------------------------------------------------
                // ‡Œvs’Ç‰Á
                csNewRow = csLtXMLDatCountDS.Tables(ABLTXmlDatCountData.TABLE_NAME).NewRow;

                // Å–Ú‹æ•ª
                if (csABLTXmlDatParaX.p_strTaxKB != ABEnumDefine.ZeimokuCDType.Empty)
                {
                    // ‹ó”’ˆÈŠO
                    csNewRow(ABLTXmlDatCountData.TAXKB) = (string)csABLTXmlDatParaX.p_strTaxKB;
                }
                else
                {
                    // ‹ó”’‚Ìê‡
                    csNewRow(ABLTXmlDatCountData.TAXKB) = string.Empty;
                }

                // Žè‘±ID
                csNewRow(ABLTXmlDatCountData.PROCID) = string.Empty;

                // Žè‘±–¼
                csNewRow(ABLTXmlDatCountData.PROCRYAKUMEI) = string.Empty;

                // Œ”
                foreach (DataRow currentCsDataRow1 in csDataSet.Tables(ABLTXMLDatEntity.TABLE_NAME).Rows)
                {
                    csDataRow = currentCsDataRow1;
                    intCount += (int)csDataRow("COUNT");
                }
                csNewRow(ABLTXmlDatCountData.COUNT) = intCount.ToString();

                csLtXMLDatCountDS.Tables(ABLTXmlDatCountData.TABLE_NAME).Rows.Add(csNewRow);
                // ----------------------------------------------------------------------------


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 26465


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 26568


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 27099


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return csLtXMLDatCountDS

                    End Function
                #End Region

                #Region "eLTAXŽóMXMLƒf[ƒ^’Ç‰Áƒƒ\ƒbƒh"

                 */
            }

            return default;
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼   eLTAXŽóMXMLƒf[ƒ^’Ç‰Áƒƒ\ƒbƒh
        // * 
        // * \•¶         Public Function InsertLTXMLDat(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@     eLTAXŽóMXMLƒ}ƒXƒ^‚ÉV‹Kƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”         csDataRow As DataRow   : ’Ç‰Áƒf[ƒ^(ABeLTAXRiyoTdk)
        // * 
        // * –ß‚è’l       ’Ç‰ÁŒ”(Integer)
        // ************************************************************************************************
        public int InsertLTXMLDat(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "InsertLTXMLDat";                                 // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                                              // * corresponds to VS2008 Start 2010/04/16 000001
                                                                                              // Dim csDataColumn As DataColumn                                  ' ƒf[ƒ^ƒJƒ‰ƒ€
                                                                                              // * corresponds to VS2008 End 2010/04/16 000001
            int intInsCnt;                                        // ’Ç‰ÁŒ”
            string strUpdateDateTime;                                 // ƒVƒXƒeƒ€“ú•t

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strInsertSQL is null | string.IsNullOrEmpty(m_strInsertSQL) | m_cfInsertUFParameterCollectionClass is null)
                {
                    CreateSQL(csDataRow);
                }
                else
                {
                }

                // XV“úŽž‚ÌŽæ“¾
                strUpdateDateTime = m_cfRdbClass.GetSystemDate.ToString("yyyyMMddHHmmssfff");        // ì¬“úŽž

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABLTXMLDatEntity.TANMATSUID) = m_cfControlData.m_strClientId;              // ’[––‚h‚c
                csDataRow(ABLTXMLDatEntity.SAKUJOFG) = "0";                                          // íœƒtƒ‰ƒO
                csDataRow(ABLTXMLDatEntity.KOSHINCOUNTER) = decimal.Zero;                            // XVƒJƒEƒ“ƒ^
                csDataRow(ABLTXMLDatEntity.SAKUSEINICHIJI) = strUpdateDateTime;                      // ì¬“úŽž
                csDataRow(ABLTXMLDatEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;               // ì¬ƒ†[ƒU[
                csDataRow(ABLTXMLDatEntity.KOSHINNICHIJI) = strUpdateDateTime;                       // XV“úŽž
                csDataRow(ABLTXMLDatEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                // XVƒ†[ƒU[


                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                {
                    if (cfParam.ParameterName == ABLTXMLDatEntity.KEY_XMLDAT)
                    {
                        // €–Ú:XMLDat‚Ìê‡‚ÍAbyteŒ^‚Ì‚Ü‚ÜƒZƒbƒg‚·‚é
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABLTXMLDatEntity.PARAM_PLACEHOLDER.RLength));
                    }
                    else
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfInsertUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABLTXMLDatEntity.PARAM_PLACEHOLDER.RLength)).ToString();
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31162


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31936


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 32039


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 32570


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return intInsCnt

                    End Function
                #End Region

                #Region "eLTAXŽóMXMLƒf[ƒ^XVƒƒ\ƒbƒh"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼   eLTAXŽóMXMLƒf[ƒ^XVƒƒ\ƒbƒh
                    '* 
                    '* \•¶         Public Function UpdateLTXMLDat(ByVal csDataRow As DataRow) As Integer
                    '* 
                    '* ‹@”\@@     eLTAXŽóMXMLƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”         csDataRow As DataRow   : —˜—p“Íƒf[ƒ^(ABeLTAXRiyoTdk)
        // * 
        // * –ß‚è’l       XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateLTXMLDat(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "UpdateLTXmlDat";                         // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                                      // * corresponds to VS2008 Start 2010/04/16 000001
                                                                                      // Dim csDataColumn As DataColumn                          ' ƒf[ƒ^ƒJƒ‰ƒ€
                                                                                      // * corresponds to VS2008 End 2010/04/16 000001
            int intUpdCnt;                                // XVŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strUpDateSQL is null | string.IsNullOrEmpty(m_strUpDateSQL) | m_cfUpdateUFParameterCollectionClass is null)
                {
                    CreateSQL(csDataRow);
                }
                else
                {
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABLTXMLDatEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                  // ’[––‚h‚c
                csDataRow(ABLTXMLDatEntity.KOSHINCOUNTER) = (decimal)csDataRow(ABLTXMLDatEntity.KOSHINCOUNTER) + 1m;         // XVƒJƒEƒ“ƒ^
                csDataRow(ABLTXMLDatEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate.ToString("yyyyMMddHHmmssfff");    // XV“úŽž
                csDataRow(ABLTXMLDatEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                    // XVƒ†[ƒU[

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    if (cfParam.ParameterName.RSubstring(0, ABLTXMLDatEntity.PREFIX_KEY.RLength) == ABLTXMLDatEntity.PREFIX_KEY)
                    {
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABLTXMLDatEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else if (cfParam.ParameterName == ABLTXMLDatEntity.KEY_XMLDAT)
                    {
                        // €–Ú:XMLDat‚Ìê‡‚ÍAbyteŒ^‚Ì‚Ü‚ÜƒZƒbƒg‚·‚é
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABLTXMLDatEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current);
                    }
                    else
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABLTXMLDatEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36554


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strUpDateSQL, m_cfUpdateUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs
                                            intUpdCnt = m_cfRdbClass.ExecuteSQL(m_strUpDateSQL, m_cfUpdateUFParameterCollectionClass)

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37328


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37431


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37962


                Input:
                " + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return intUpdCnt

                    End Function
                #End Region

                #Region "eLTAXŽóMXMLƒf[ƒ^:
                 */
                ƒRƒ(default
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
                “ƒo[ƒgƒtƒ‰ƒOXVƒƒ\ƒbƒh"
                 */
                );
            }

            return default;
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼   eLTAXŽóMXMLƒf[ƒ^:ƒRƒ“ƒo[ƒgƒtƒ‰ƒOXVƒƒ\ƒbƒh
        // * 
        // * \•¶         Public Function UpdateLTXMLDat_ConvertFG(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@     eLTAXŽóMXMLƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚éB
        // * 
        // * ˆø”         csDataRow As DataRow   : —˜—p“Íƒf[ƒ^(ABeLTAXRiyoTdk)
        // * 
        // * –ß‚è’l       XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateLTXMLDat_ConvertFG(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "UpdateLTXMLDat_ConvertFG";                         // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                                                // * corresponds to VS2008 Start 2010/04/16 000001
                                                                                                // Dim csDataColumn As DataColumn                          ' ƒf[ƒ^ƒJƒ‰ƒ€
                                                                                                // * corresponds to VS2008 End 2010/04/16 000001
            int intUpdCnt;                                // XVŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strUpDateSQL_ConvertFG is null | string.IsNullOrEmpty(m_strUpDateSQL_ConvertFG) | m_cfUpdateConvertFGUFParameterCollectionClass is null)
                {
                    CreateSQL_UpDateConvertFG();
                }
                else
                {
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABLTXMLDatEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                  // ’[––‚h‚c
                csDataRow(ABLTXMLDatEntity.KOSHINCOUNTER) = (decimal)csDataRow(ABLTXMLDatEntity.KOSHINCOUNTER) + 1m;         // XVƒJƒEƒ“ƒ^
                csDataRow(ABLTXMLDatEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate.ToString("yyyyMMddHHmmssfff");    // XV“úŽž
                csDataRow(ABLTXMLDatEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                    // XVƒ†[ƒU[

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateConvertFGUFParameterCollectionClass)
                {
                    if (cfParam.ParameterName.RSubstring(0, ABLTXMLDatEntity.PREFIX_KEY.RLength) == ABLTXMLDatEntity.PREFIX_KEY)
                    {
                        this.m_cfUpdateConvertFGUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABLTXMLDatEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateConvertFGUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABLTXMLDatEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 41645


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strUpDateSQL, m_cfUpdateUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs
                                            intUpdCnt = m_cfRdbClass.ExecuteSQL(m_strUpDateSQL_ConvertFG, m_cfUpdateConvertFGUFParameterCollectionClass)

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42438


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42541


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 43072


                Input:
                " + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return intUpdCnt

                    End Function
                #End Region

                #Region "eLTAXŽóMXMLƒf[ƒ^:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 43266


                Input:
                íœƒtƒ‰ƒOXVƒƒ\ƒbƒh"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼   eLTAXŽóMXMLƒf[ƒ^:íœƒtƒ‰ƒOXVƒƒ\ƒbƒh
                    '* 
                    '* \•¶         Public Overloads Function UpdateLTXMLDat_SakujoFG(ByVal csDataRow As DataRow) As Integer
                    '* 
                    '* ‹@”\@@     eLTAXŽóMXMLƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”         csDataRow As DataRow   : —˜—p“Íƒf[ƒ^(ABeLTAXRiyoTdk)
        // * 
        // * –ß‚è’l       XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateLTXMLDat_SakujoFG(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "UpdateLTXMLDat_SakujoFG";                         // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                                               // * corresponds to VS2008 Start 2010/04/16 000001
                                                                                               // Dim csDataColumn As DataColumn                          ' ƒf[ƒ^ƒJƒ‰ƒ€
                                                                                               // * corresponds to VS2008 End 2010/04/16 000001
            int intUpdCnt;                                // XVŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strUpDateSQL_SakujoFG is null | string.IsNullOrEmpty(m_strUpDateSQL_SakujoFG) | m_cfUpdateSakujoFGUFParameterCollectionClass is null)
                {
                    CreateSQL_UpDateSakujoFG();
                }
                else
                {
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABLTXMLDatEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                  // ’[––‚h‚c
                csDataRow(ABLTXMLDatEntity.KOSHINCOUNTER) = (decimal)csDataRow(ABLTXMLDatEntity.KOSHINCOUNTER) + 1m;         // XVƒJƒEƒ“ƒ^
                csDataRow(ABLTXMLDatEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate.ToString("yyyyMMddHHmmssfff");    // XV“úŽž
                csDataRow(ABLTXMLDatEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                    // XVƒ†[ƒU[

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateSakujoFGUFParameterCollectionClass)
                {
                    if (cfParam.ParameterName.RSubstring(0, ABLTXMLDatEntity.PREFIX_KEY.RLength) == ABLTXMLDatEntity.PREFIX_KEY)
                    {
                        this.m_cfUpdateSakujoFGUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABLTXMLDatEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateSakujoFGUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABLTXMLDatEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 46768


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strUpDateSQL, m_cfUpdateUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs
                                            intUpdCnt = m_cfRdbClass.ExecuteSQL(m_strUpDateSQL_SakujoFG, m_cfUpdateSakujoFGUFParameterCollectionClass)

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 47559


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 47662


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 48193


                Input:
                " + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return intUpdCnt

                    End Function
                #End Region

                #Region "eLTAXŽóMXMLƒf[ƒ^:íœƒtƒ‰ƒOXVƒƒ\ƒbƒh"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼   eLTAXŽóMXMLƒf[ƒ^:íœƒtƒ‰ƒOXVƒƒ\ƒbƒh
                    '* 
                    '* \•¶         Public Function UpdateLTXMLDat_SakujoFG(ByVal csDataRow As DataRow, _
                    '*                                                      ByVal blnKoshinCounter As Boolean) As Integer
                    '* 
                    '* ‹@”\@@     eLTAXŽóMXMLƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚éB
                    '* 
                    '* ˆø”         csDataRow As DataRow    : —˜—p“Íƒf[ƒ^(ABeLTAXRiyoTdk)
                    '*              blnKoshinCounter        : XVƒJƒEƒ“ƒ^(True:ðŒ‚ÉŠÜ‚ÞAFalse:ŠÜ‚Ü‚È‚¢)
                    '* 
                    '* –ß‚è’l       XVŒ”(Integer)
                    '************************************************************************************************
                    Public Overloads Function UpdateLTXMLDat_SakujoFG(ByVal csDataRow As DataRow, _
                                                                      ByVal blnKoshinCounter As Boolean) As Integer
                        Const THIS_METHOD_NAME As String = "UpdateLTXMLDat_SakujoFG"
                        Dim cfParam As UFParameterClass                         ' ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        '* corresponds to VS2008 Start 2010/04/16 000001
                        'Dim csDataColumn As DataColumn                          ' ƒf[ƒ^ƒJƒ‰ƒ€
                        '* corresponds to VS2008 End 2010/04/16 000001
                        Dim intUpdCnt As Integer                                ' XVŒ”

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                            If (m_strUpDateSQL_SakujoFG Is Nothing Or m_strUpDateSQL_SakujoFG = String.Empty Or _
                                m_cfUpdateSakujoFGUFParameterCollectionClass Is Nothing) Then
                                Call CreateSQL_UpDateSakujoFG(blnKoshinCounter)
                            Else
                            End If

                            ' ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                            csDataRow(ABLTXMLDatEntity.TANMATSUID) = m_cfControlData.m_strClientId                                  ' ’[––‚h‚c
                            csDataRow(ABLTXMLDatEntity.KOSHINCOUNTER) = CDec(csDataRow(ABLTXMLDatEntity.KOSHINCOUNTER)) + 1         ' XVƒJƒEƒ“ƒ^
                            csDataRow(ABLTXMLDatEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate.ToString("yyyyMMddHHmmssfff")    ' XV“úŽž
                            csDataRow(ABLTXMLDatEntity.KOSHINUSER) = m_cfControlData.m_strUserId                                    ' XVƒ†[ƒU[

                            ' ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                            For Each cfParam In m_cfUpdateSakujoFGUFParameterCollectionClass
                                If (cfParam.ParameterName.RSubstring(0, ABLTXMLDatEntity.PREFIX_KEY.RLength) = ABLTXMLDatEntity.PREFIX_KEY) Then
                                    m_cfUpdateSakujoFGUFParameterCollectionClass(cfParam.ParameterName).Value =
                                            csDataRow(cfParam.ParameterName.RSubstring(ABLTXMLDatEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString()
                                Else
                                    ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                                    m_cfUpdateSakujoFGUFParameterCollectionClass(cfParam.ParameterName).Value =
                                                csDataRow(cfParam.ParameterName.RSubstring(ABLTXMLDatEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString
                                End If
                            Next cfParam

                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                                                        "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                                                        "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strUpDateSQL, m_cfUpdateUFParameterCollectionClass) + "z")

                            ' SQL‚ÌŽÀs
                            intUpdCnt = m_cfRdbClass.ExecuteSQL(m_strUpDateSQL_SakujoFG, m_cfUpdateSakujoFGUFParameterCollectionClass)

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
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return intUpdCnt

                    End Function
                #End Region

                    '*—š—ð”Ô† 000002 2011/08/30 ’Ç‰ÁŠJŽn
                #Region "eLTAXŽóMXMLƒf[ƒ^:íœ(•¨—)ƒƒ\ƒbƒh"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼   eLTAXŽóMXMLƒf[ƒ^:íœ(•¨—)ƒƒ\ƒbƒh
                    '* 
                    '* \•¶         Public Overloads Function DeleteLTXMLDat() As Integer
                    '* 
                    '* ‹@”\@@     eLTAXŽóMXMLƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^‚ð•¨—íœ‚·‚é
                    '* 
                    '* ˆø”         ‚È‚µ
                    '* 
                    '* –ß‚è’l       XVŒ”(Integer)
                    '************************************************************************************************
                    Public Overloads Function DeleteLTXMLDat(ByVal csDataRow As DataRow) As Integer
                        Const THIS_METHOD_NAME As String = "DeleteLTXMLDat"
                        Dim cfParam As UFParameterClass                         ' ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim intUpdCnt As Integer                                ' XVŒ”
                        Dim blnKoshinCounter As Boolean = False                 ' XVƒJƒEƒ“ƒ^[

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                            If (m_strUpDateSQL_SakujoFG Is Nothing OrElse m_strUpDateSQL_SakujoFG = String.Empty OrElse _
                                m_cfUpdateSakujoFGUFParameterCollectionClass Is Nothing) Then
                                Call CreateSQL_UpDateSakujoFG(blnKoshinCounter)
                            Else
                            End If

                            ' ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                            csDataRow(ABLTXMLDatEntity.TANMATSUID) = m_cfControlData.m_strClientId                                  ' ’[––‚h‚c
                            csDataRow(ABLTXMLDatEntity.KOSHINCOUNTER) = CDec(csDataRow(ABLTXMLDatEntity.KOSHINCOUNTER)) + 1         ' XVƒJƒEƒ“ƒ^
                            csDataRow(ABLTXMLDatEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate.ToString("yyyyMMddHHmmssfff")    ' XV“úŽž
                            csDataRow(ABLTXMLDatEntity.KOSHINUSER) = m_cfControlData.m_strUserId                                    ' XVƒ†[ƒU[

                            ' ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                            For Each cfParam In m_cfDeleteUFParameterCollectionClass
                                If (cfParam.ParameterName.RSubstring(0, ABLTXMLDatEntity.PREFIX_KEY.RLength) = ABLTXMLDatEntity.PREFIX_KEY) Then
                                    m_cfDeleteUFParameterCollectionClass(cfParam.ParameterName).Value =
                                            csDataRow(cfParam.ParameterName.RSubstring(ABLTXMLDatEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString()
                                Else
                                    ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                                    m_cfDeleteUFParameterCollectionClass(cfParam.ParameterName).Value =
                                                csDataRow(cfParam.ParameterName.RSubstring(ABLTXMLDatEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString
                                End If
                            Next cfParam

                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                                                        "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                                                        "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strDeleteSQL, m_cfDeleteUFParameterCollectionClass) + "z")

                            ' SQL‚ÌŽÀs
                            intUpdCnt = m_cfRdbClass.ExecuteSQL(m_strDeleteSQL, m_cfDeleteUFParameterCollectionClass)

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
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return intUpdCnt

                    End Function
                #End Region

                #Region "eLTAXŽóMXMLƒf[ƒ^:íœƒf[ƒ^ˆêŠ‡íœ(•¨—)ƒƒ\ƒbƒh"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼   eLTAXŽóMXMLƒf[ƒ^:íœƒf[ƒ^ˆêŠ‡íœ(•¨—)ƒƒ\ƒbƒh
                    '* 
                    '* \•¶         Public Overloads Function DeleteLTXMLDat_Sakujo() As Integer
                    '* 
                    '* ‹@”\@@     eLTAXŽóMXMLƒ}ƒXƒ^‚Ìƒf[ƒ^‚Ìíœƒtƒ‰ƒO="1"‚Ìƒf[ƒ^‚ðˆêŠ‡íœ‚·‚é
                    '* 
                    '* ˆø”         ‚È‚µ
                    '* 
                    '* –ß‚è’l       XVŒ”(Integer)
                    '************************************************************************************************
                    Public Overloads Function DeleteLTXMLDat_Sakujo() As Integer
                        Const THIS_METHOD_NAME As String = "DeleteLTXMLDat_Sakujo"
                        Dim csSQL As New StringBuilder
                        Dim intUpdCnt As Integer                                ' XVŒ”

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SQL•¶ì¬
                            csSQL.Append("DELETE ").Append(ABLTXMLDatEntity.TABLE_NAME)
                            csSQL.Append(" WHERE ").Append(ABLTXMLDatEntity.CONVERTFG).Append(" <> '1' ")
                            csSQL.Append("AND ").Append(ABLTXMLDatEntity.SAKUJOFG).Append(" = '1'")

                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                                                        "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                                                        "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(csSQL.ToString) + "z")

                            ' SQL‚ÌŽÀs
                            intUpdCnt = m_cfRdbClass.ExecuteSQL(csSQL.ToString)

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
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return intUpdCnt

                    End Function
                #End Region

                #Region "eLTAXŽóMXMLƒf[ƒ^:ƒRƒ“ƒo[ƒgÏ‚ÝˆêŠ‡íœ(•¨—)ƒƒ\ƒbƒh"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼   eLTAXŽóMXMLƒf[ƒ^:ƒRƒ“ƒo[ƒgÏ‚ÝˆêŠ‡íœ(•¨—)ƒƒ\ƒbƒh
                    '* 
                    '* \•¶         Public Overloads Function DeleteLTXMLDat_Sakujo() As Integer
                    '* 
                    '* ‹@”\@@     eLTAXŽóMXMLƒ}ƒXƒ^‚Ìƒf[ƒ^‚ÌƒRƒ“ƒo[ƒgƒtƒ‰ƒO="1"‚Ìƒf[ƒ^‚ðˆêŠ‡íœ‚·‚é
                    '* 
                    '* ˆø”         ‚È‚µ
                    '* 
                    '* –ß‚è’l       XVŒ”(Integer)
                    '************************************************************************************************
                    Public Overloads Function DeleteLTXMLDat_Convert() As Integer
                        Const THIS_METHOD_NAME As String = "DeleteLTXMLDat_Convert"
                        Dim csSQL As New StringBuilder
                        Dim intUpdCnt As Integer                    ' XVŒ”

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SQL•¶ì¬
                            csSQL.Append("DELETE ").Append(ABLTXMLDatEntity.TABLE_NAME)
                            csSQL.Append(" WHERE ").Append(ABLTXMLDatEntity.CONVERTFG).Append(" = '1'")

                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                                                        "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                                                        "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(csSQL.ToString) + "z")

                            ' SQL‚ÌŽÀs
                            intUpdCnt = m_cfRdbClass.ExecuteSQL(csSQL.ToString)

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
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return intUpdCnt

                    End Function
                #End Region
                    '*—š—ð”Ô† 000002 2011/08/30 ’Ç‰ÁI—¹

                #Region "SQL•¶‚Ìì¬"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼   SQL•¶‚Ìì¬
                    '* 
                    '* \•¶         Private Sub CreateSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\@@     INSERT, UPDATE‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”         csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l       ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateSQL(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateSQL"
                        Dim csDataColumn As DataColumn
                        Dim cfUFParameterClass As UFParameterClass                  ' ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim strInsertColumn As String                               ' ’Ç‰ÁSQL•¶€–Ú•¶Žš—ñ
                        Dim strInsertParam As String                                ' ’Ç‰ÁSQL•¶ƒpƒ‰ƒ[ƒ^•¶Žš—ñ
                        Dim strWhere As New StringBuilder                           ' XVíœSQL•¶Where•¶•¶Žš—ñ

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' INSERT SQL•¶‚Ìì¬
                            m_strInsertSQL = "INSERT INTO " + ABLTXMLDatEntity.TABLE_NAME + " "
                            strInsertColumn = ""
                            strInsertParam = ""

                            ' UPDATE SQL•¶‚Ìì¬
                            m_strUpDateSQL = "UPDATE " + ABLTXMLDatEntity.TABLE_NAME + " SET "

                            ' UPDATE Where•¶ì¬
                            strWhere.Append(" WHERE ")
                            strWhere.Append(ABLTXMLDatEntity.JUSHINYMD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.JUSHINYMD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABLTXMLDatEntity.RCPTNO)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.RCPTNO)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABLTXMLDatEntity.XMLRENBAN)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.XMLRENBAN)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABLTXMLDatEntity.RCPTYMD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.RCPTYMD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABLTXMLDatEntity.KOSHINCOUNTER)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.KOSHINCOUNTER)

                            ' SELECT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfInsertUFParameterCollectionClass = New UFParameterCollectionClass

                            ' UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfUpdateUFParameterCollectionClass = New UFParameterCollectionClass

                            ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                            For Each csDataColumn In csDataRow.Table.Columns
                                cfUFParameterClass = New UFParameterClass

                                ' INSERT SQL•¶‚Ìì¬
                                strInsertColumn += csDataColumn.ColumnName + ", "
                                strInsertParam += ABLTXMLDatEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", "

                                ' UPDATE SQL•¶‚Ìì¬
                                m_strUpDateSQL += csDataColumn.ColumnName + " = " + ABLTXMLDatEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", "

                                ' INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                                cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                                m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass)

                                ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                                cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                            Next csDataColumn

                            ' INSERT SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                            strInsertColumn = strInsertColumn.Trim()
                            strInsertColumn = strInsertColumn.Trim(CType(",", Char))
                            strInsertParam = strInsertParam.Trim()
                            strInsertParam = strInsertParam.Trim(CType(",", Char))
                            m_strInsertSQL += "(" + strInsertColumn + ")" + " VALUES (" + strInsertParam + ")"

                            ' UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                            m_strUpDateSQL = m_strUpDateSQL.Trim()
                            m_strUpDateSQL = m_strUpDateSQL.Trim(CType(",", Char))

                            ' UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                            m_strUpDateSQL += strWhere.ToString

                            ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚ÉƒL[î•ñ‚ð’Ç‰Á
                            ' ŽóM“úŽž
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.JUSHINYMD
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' Žó•t”Ô†
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.RCPTNO
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ‚w‚l‚k˜A”Ô
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.XMLRENBAN
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' \Žó•t”Ô†
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.RCPTYMD
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' XVƒJƒEƒ“ƒ^
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.KOSHINCOUNTER
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

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
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try
                    End Sub
                #End Region

                #Region "SQL•¶‚Ìì¬(ƒRƒ“ƒo[ƒgƒtƒ‰ƒO—p)"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼   SQL•¶‚Ìì¬(ƒRƒ“ƒo[ƒgƒtƒ‰ƒO—p)
                    '* 
                    '* \•¶         Private Sub CreateSQL_UpDateConvertFG()
                    '* 
                    '* ‹@”\@@     UPDATE‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”         csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l       ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateSQL_UpDateConvertFG()
                        Const THIS_METHOD_NAME As String = "CreateSQL_UpDateConvertFG"
                        Dim cfUFParameterClass As UFParameterClass                  ' ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim strWhere As New StringBuilder                           ' XVSQL•¶Where•¶•¶Žš—ñ
                        Dim strSet As New StringBuilder                             ' XVSQL•¶Set•¶•¶Žš—ñ

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' UPDATE SQL•¶‚Ìì¬
                            m_strUpDateSQL_ConvertFG = "UPDATE " + ABLTXMLDatEntity.TABLE_NAME + " SET "

                            ' UPDATE Where•¶ì¬
                            strWhere.Append(" WHERE ")
                            strWhere.Append(ABLTXMLDatEntity.JUSHINYMD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.JUSHINYMD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABLTXMLDatEntity.RCPTNO)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.RCPTNO)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABLTXMLDatEntity.XMLRENBAN)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.XMLRENBAN)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABLTXMLDatEntity.RCPTYMD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.RCPTYMD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABLTXMLDatEntity.KOSHINCOUNTER)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.KOSHINCOUNTER)

                            ' UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfUpdateConvertFGUFParameterCollectionClass = New UFParameterCollectionClass

                            ' ƒRƒ“ƒo[ƒgƒtƒ‰ƒO—pUPDATE SQL•¶‚Ìì¬
                            m_strUpDateSQL_ConvertFG += ABLTXMLDatEntity.CONVERTFG + " = " + ABLTXMLDatEntity.KEY_CONVERTFG + ","

                            ' ‹¤’ÊSet•¶
                            strSet.Append(ABLTXMLDatEntity.TANMATSUID).Append(" = ").Append(ABLTXMLDatEntity.KEY_TANMATSUID).Append(",")
                            strSet.Append(ABLTXMLDatEntity.KOSHINCOUNTER).Append(" = ").Append(ABLTXMLDatEntity.KEY_KOSHINCOUNTER).Append(",")
                            strSet.Append(ABLTXMLDatEntity.KOSHINNICHIJI).Append(" = ").Append(ABLTXMLDatEntity.KEY_KOSHINNICHIJI).Append(",")
                            strSet.Append(ABLTXMLDatEntity.KOSHINUSER).Append(" = ").Append(ABLTXMLDatEntity.KEY_KOSHINUSER)

                            ' UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                            m_strUpDateSQL_ConvertFG += strSet.ToString + strWhere.ToString

                            '*-------------------------------------------------------------------------*
                            ' ƒRƒ“ƒo[ƒgƒtƒ‰ƒO—pUPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            ' ƒRƒ“ƒo[ƒgƒtƒ‰ƒO
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.KEY_CONVERTFG
                            m_cfUpdateConvertFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            '*-------------------------------------------------------------------------*
                            ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚ÉƒL[î•ñ‚ð’Ç‰Á
                            ' ’[––‚h‚c
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.KEY_TANMATSUID
                            m_cfUpdateConvertFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' XVƒJƒEƒ“ƒ^
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.KEY_KOSHINCOUNTER
                            m_cfUpdateConvertFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' XV“úŽž
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.KEY_KOSHINNICHIJI
                            m_cfUpdateConvertFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' XVƒ†[ƒU
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.KEY_KOSHINUSER
                            m_cfUpdateConvertFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ŽóM“úŽž
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.JUSHINYMD
                            m_cfUpdateConvertFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' Žó•t”Ô†
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.RCPTNO
                            m_cfUpdateConvertFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ‚w‚l‚k˜A”Ô
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.XMLRENBAN
                            m_cfUpdateConvertFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' \Žó•t”Ô†
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.RCPTYMD
                            m_cfUpdateConvertFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' XVƒJƒEƒ“ƒ^
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.KOSHINCOUNTER
                            m_cfUpdateConvertFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            '*-------------------------------------------------------------------------*

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
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try
                    End Sub
                #End Region

                #Region "SQL•¶‚Ìì¬(íœƒtƒ‰ƒO—p)"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼   SQL•¶‚Ìì¬(íœƒtƒ‰ƒO—p)
                    '* 
                    '* \•¶         Private Sub CreateSQL_UpDateSakujoFG()
                    '* 
                    '* ‹@”\@@     UPDATE‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”         csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l       ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateSQL_UpDateSakujoFG()

                        Call CreateSQL_UpDateSakujoFG(True)

                    End Sub
                    Private Sub CreateSQL_UpDateSakujoFG(ByVal blnKoshinCounter As Boolean)
                        Const THIS_METHOD_NAME As String = "CreateSQL_UpDateSakujoFG"
                        Dim cfUFParameterClass As UFParameterClass                  ' ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim strWhere As New StringBuilder                           ' XVSQL•¶Where•¶•¶Žš—ñ
                        Dim strSet As New StringBuilder                             ' XVSQL•¶Set•¶•¶Žš—ñ

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' UPDATE SQL•¶‚Ìì¬
                            m_strUpDateSQL_SakujoFG = "UPDATE " + ABLTXMLDatEntity.TABLE_NAME + " SET "

                            '*—š—ð”Ô† 000002 2011/08/30 ’Ç‰ÁŠJŽn
                            m_strDeleteSQL = "DELETE " + ABLTXMLDatEntity.TABLE_NAME
                            '*—š—ð”Ô† 000002 2011/08/30 ’Ç‰ÁI—¹

                            ' UPDATE Where•¶ì¬
                            strWhere.Append(" WHERE ")
                            strWhere.Append(ABLTXMLDatEntity.JUSHINYMD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.JUSHINYMD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABLTXMLDatEntity.RCPTNO)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.RCPTNO)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABLTXMLDatEntity.XMLRENBAN)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.XMLRENBAN)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABLTXMLDatEntity.RCPTYMD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.RCPTYMD)

                            If (blnKoshinCounter = True) Then
                                strWhere.Append(" AND ")
                                strWhere.Append(ABLTXMLDatEntity.KOSHINCOUNTER)
                                strWhere.Append(" = ")
                                strWhere.Append(ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.KOSHINCOUNTER)
                            Else
                            End If

                            ' UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfUpdateSakujoFGUFParameterCollectionClass = New UFParameterCollectionClass

                            ' íœƒtƒ‰ƒO—pUPDATE SQL•¶‚Ìì¬
                            m_strUpDateSQL_SakujoFG += ABLTXMLDatEntity.SAKUJOFG + " = " + ABLTXMLDatEntity.KEY_SAKUJOFG + ","

                            ' ‹¤’ÊSet•¶
                            strSet.Append(ABLTXMLDatEntity.TANMATSUID).Append(" = ").Append(ABLTXMLDatEntity.KEY_TANMATSUID).Append(",")
                            strSet.Append(ABLTXMLDatEntity.KOSHINCOUNTER).Append(" = ").Append(ABLTXMLDatEntity.KEY_KOSHINCOUNTER).Append(",")
                            strSet.Append(ABLTXMLDatEntity.KOSHINNICHIJI).Append(" = ").Append(ABLTXMLDatEntity.KEY_KOSHINNICHIJI).Append(",")
                            strSet.Append(ABLTXMLDatEntity.KOSHINUSER).Append(" = ").Append(ABLTXMLDatEntity.KEY_KOSHINUSER)

                            ' UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                            m_strUpDateSQL_SakujoFG += strSet.ToString + strWhere.ToString

                            '*-------------------------------------------------------------------------*
                            ' íœƒtƒ‰ƒO—pUPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.KEY_SAKUJOFG
                            m_cfUpdateSakujoFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            '*-------------------------------------------------------------------------*
                            ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚ÉƒL[î•ñ‚ð’Ç‰Á
                            ' ’[––‚h‚c
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.KEY_TANMATSUID
                            m_cfUpdateSakujoFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' XVƒJƒEƒ“ƒ^
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.KEY_KOSHINCOUNTER
                            m_cfUpdateSakujoFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' XV“úŽž
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.KEY_KOSHINNICHIJI
                            m_cfUpdateSakujoFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' XVƒ†[ƒU
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.KEY_KOSHINUSER
                            m_cfUpdateSakujoFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ŽóM“úŽž
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.JUSHINYMD
                            m_cfUpdateSakujoFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' Žó•t”Ô†
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.RCPTNO
                            m_cfUpdateSakujoFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ‚w‚l‚k˜A”Ô
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.XMLRENBAN
                            m_cfUpdateSakujoFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' \Žó•t”Ô†
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.RCPTYMD
                            m_cfUpdateSakujoFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            If (blnKoshinCounter = True) Then
                                ' XVƒJƒEƒ“ƒ^
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.KOSHINCOUNTER
                                m_cfUpdateSakujoFGUFParameterCollectionClass.Add(cfUFParameterClass)
                            Else
                            End If
                            '*-------------------------------------------------------------------------*

                            '*—š—ð”Ô† 000002 2011/08/30 ’Ç‰ÁŠJŽn
                            ' DELETE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDeleteUFParameterCollectionClass = New UFParameterCollectionClass

                            ' DELETE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                            m_strDeleteSQL += strWhere.ToString

                            '*-------------------------------------------------------------------------*
                            ' DELETE ƒRƒŒƒNƒVƒ‡ƒ“‚ÉƒL[î•ñ‚ð’Ç‰Á
                            ' ŽóM“úŽž
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.JUSHINYMD
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' Žó•t”Ô†
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.RCPTNO
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ‚w‚l‚k˜A”Ô
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.XMLRENBAN
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' \Žó•t”Ô†
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.RCPTYMD
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            If (blnKoshinCounter = True) Then
                                ' XVƒJƒEƒ“ƒ^
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABLTXMLDatEntity.PREFIX_KEY + ABLTXMLDatEntity.KOSHINCOUNTER
                                m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            Else
                            End If
                            '*-------------------------------------------------------------------------*
                            '*—š—ð”Ô† 000002 2011/08/30 ’Ç‰ÁI—¹

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
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try
                    End Sub
                #End Region

                #Region "ƒf[ƒ^ƒZƒbƒgì¬"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼   ‚…‚k‚s‚`‚wŽóM‚c‚`‚sŒ”ƒf[ƒ^ƒZƒbƒgì¬
                    '* 
                    '* \•¶         Private Function CreateDataSet() As DataSet
                    '* 
                    '* ‹@”\@@     ‚…‚k‚s‚`‚wŽóM‚c‚`‚sŒ”ƒf[ƒ^ƒZƒbƒg‚ðì¬‚·‚é
                    '* 
                    '* ˆø”         ‚È‚µ
                    '* 
                    '* –ß‚è’l       ì¬‚µ‚½‚…‚k‚s‚`‚wŽóM‚c‚`‚sƒf[ƒ^ƒZƒbƒg(DataSet)
                    '************************************************************************************************
                    Private Function CreateDataSet() As DataSet
                        Const THIS_METHOD_NAME As String = "CreateDataSet"
                        Dim csDataSet As DataSet                        ' ƒf[ƒ^ƒZƒbƒg
                        Dim csDataTable As DataTable                    ' ƒe[ƒuƒ‹
                        Dim csDataColumn As DataColumn                  ' ƒJƒ‰ƒ€

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' DataSet‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                            csDataSet = New DataSet

                            ' ƒf[ƒ^ƒe[ƒuƒ‹ì¬
                            csDataTable = csDataSet.Tables.Add(ABLTXmlDatCountData.TABLE_NAME)

                            ' ƒJƒ‰ƒ€’è‹`‚Ìì¬
                            ' Å–Ú‹æ•ª
                            csDataColumn = csDataTable.Columns.Add(ABLTXmlDatCountData.TAXKB, System.Type.GetType("System.String"))
                            ' Žè‘±ID
                            csDataColumn = csDataTable.Columns.Add(ABLTXmlDatCountData.PROCID, System.Type.GetType("System.String"))
                            ' Žè‘±–¼(—ª)
                            csDataColumn = csDataTable.Columns.Add(ABLTXmlDatCountData.PROCRYAKUMEI, System.Type.GetType("System.String"))
                            ' Œ”
                            csDataColumn = csDataTable.Columns.Add(ABLTXmlDatCountData.COUNT, System.Type.GetType("System.String"))

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
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return csDataSet

                    End Function
                #End Region

                #Region "Žè‘±–¼Ì(—ª)Žæ“¾ˆ—"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼   Žè‘±–¼Ì(—ª)Žæ“¾ˆ—
                    '* 
                    '* \•¶         Private Function GetProcRyakumei(ByVal strProcId As String) As String
                    '* 
                    '* ‹@”\@@     Žè‘±–¼Ì(—ª)‚ðŽæ“¾‚·‚é
                    '* 
                    '* ˆø”         ByVal strProcId As String   FŽè‘±‚h‚c
                    '* 
                    '* –ß‚è’l       
                    '************************************************************************************************
                    Private Function GetProcRyakumei(ByVal strProcId As String) As String
                        Const THIS_METHOD_NAME As String = "GetProcRyakumei"
                        Dim strProcRyakumei As String = String.Empty

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            Select Case strProcId
                                Case ABConstClass.ELTAX_PROCID_SHINKI
                                    ' Žè‘±‚h‚c:T0999910CŽè‘±—ªÌ:“ÍoV‹K
                                    strProcRyakumei = ABConstClass.ELTAX_PROCRYAKU_SHINKI

                                Case ABConstClass.ELTAX_PROCID_HENKO_RIYOSHAJOHO
                                    ' Žè‘±‚h‚c:T0999920CŽè‘±—ªÌ:•ÏX(—˜)
                                    strProcRyakumei = ABConstClass.ELTAX_PROCRYAKU_HENKO_RIYOSHAJOHO

                                Case ABConstClass.ELTAX_PROCID_HENKO_SHINKOKUSAKITAXKB
                                    ' Žè‘±‚h‚c:T0999910CŽè‘±—ªÌ:•ÏX(\)
                                    strProcRyakumei = ABConstClass.ELTAX_PROCRYAKU_HENKO_SHINKOKUSAKITAXKB

                                Case ABConstClass.ELTAX_PROCID_HAISHI
                                    ' Žè‘±‚h‚c:T0999910CŽè‘±—ªÌ:”pŽ~
                                    strProcRyakumei = ABConstClass.ELTAX_PROCRYAKU_HAISHI

                                Case ABConstClass.ELTAX_PROCID_SHOMEISHOSASIKAE
                                    ' Žè‘±‚h‚c:T0999910CŽè‘±—ªÌ:Ø–¾·‘Ö
                                    strProcRyakumei = ABConstClass.ELTAX_PROCRYAKU_SHOMEISHOSASIKAE

                                Case Else

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
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return strProcRyakumei

                    End Function
                #End Region

                #End Region

                End Class

                 */
            }

            return default;
        }
    }
}