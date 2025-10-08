// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        “¯ˆêlÆ‰ï‚c‚`(ABDoitsuninShokaiBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/05/01@‘ê‘ò@‹Ô–ç
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/08/28 000001     RDBƒAƒNƒZƒXƒƒO‚ÌC³
// * 2004/01/19 000002     ‹ŒŽs’¬‘ºƒR[ƒh‚Ì’Ç‰Á‚É”º‚¤C³     
// * 2007/05/22 000003     ˆ¶–¼ƒf[ƒ^Ží•Ê‚Ì’Ç‰Á‚É”º‚¤C³(¶”NŒŽ“ú“ˆê‰»‚Ì”»’è—p‚É’Ç‰Á)
// * 2007/07/10 000004     DB•¶Žš”Šg’£‘Î‰žC•¶Žš”‚ðŠg’£‚µ‚½DB‚É‘Î‰ž‚·‚é‚½‚ß‚ÉƒJƒ‰ƒ€ì¬Žž‚ÌMaxLength’lC³i’†‘òj
// * 2014/09/01 000005     yAB21010zŒÂl”Ô†§“x‘Î‰žiŠâ‰ºj
// * 2022/12/16 000006    yAB-8010zZ–¯ƒR[ƒh¢‘ÑƒR[ƒh15Œ…‘Î‰ž(‰º‘º)
// * 2023/12/18 000007    yAB-7010-1z“¯ˆêlÝ’èî•ñŽæ“¾‘Î‰ž(‰º‘º)
// ************************************************************************************************
using System;
using System.Linq;
using System.Text;

namespace Densan.Reams.AB.AB000BB
{

    public class ABDoitsuninShokaiBClass
    {
        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfLog;                           // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdb;                           // ‚q‚c‚aƒNƒ‰ƒX

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABDoitsuninShokaiBClass";
        #endregion

        #region ƒRƒ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶            Public Sub New(ByVal cfUFControlData As UFControlData,
        // *                                ByVal cfUFConfigDataClass As UFConfigDataClass,
        // *                                ByVal cfUFRdbClass As UFRdbClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”            cfUFControlData As UFControlData         : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                 cfUFConfigDataClass As UFConfigDataClass : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg 
        // *                 cfUFRdbClass As UFRdbClass               : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABDoitsuninShokaiBClass(UFControlData cfControlData, UFConfigDataClass cfConfigData, UFRdbClass cfRdb)
        {

            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigData;
            m_cfRdb = cfRdb;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLog = new UFLogClass(cfConfigData, cfControlData.m_strBusinessId);

        }
        #endregion

        #region ƒƒ\ƒbƒh
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     “¯ˆêlƒOƒ‹[ƒvˆ¶–¼’Šo
        // * 
        // * \•¶           Public Function GetDoitsuninAtena(ByVal strDoitsuninShikibetsuCD As String) As DataSet
        // * 
        // * ‹@”\@@    @@‡•¹“¯ˆêl‚æ‚èŠY“–ƒf[ƒ^‚ð‘SŒŽæ“¾‚·‚éB
        // * 
        // * ˆø”           strDoitsuninShikibetsuCD As String      :“¯ˆêlŽ¯•ÊƒR[ƒh
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½‡•¹“¯ˆêl‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsGappeiDoitsuninEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABGappeiDoitsuninEntity
        // ************************************************************************************************
        public DataSet GetDoitsuninAtena(string strDoitsuninShikibetsuCD)
        {
            const string THIS_METHOD_NAME = "GetDoitsuninAtena";          // ‚±‚Ìƒƒ\ƒbƒh–¼
            DataSet csGappeiDoitsuninEntity;                          // ‡•¹“¯ˆêlƒf[ƒ^
            var strSQL = new StringBuilder();                               // SQL•¶•¶Žš—ñ
            UFParameterClass cfParameter;                             // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfParameterCollection;         // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT ");
                strSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                strSQL.Append(".*,");
                strSQL.Append(ABAtenaEntity.TABLE_NAME);
                strSQL.Append(".* FROM ");
                strSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                strSQL.Append(" LEFT OUTER JOIN ");
                strSQL.Append(ABAtenaEntity.TABLE_NAME);
                strSQL.Append(" ON ");
                strSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                strSQL.Append(".");
                strSQL.Append(ABGappeiDoitsuninEntity.JUMINCD);
                strSQL.Append("=");
                strSQL.Append(ABAtenaEntity.TABLE_NAME);
                strSQL.Append(".");
                strSQL.Append(ABAtenaEntity.JUMINCD);
                // WHERE•¶Œ‹‡
                strSQL.Append(" WHERE ");
                strSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                strSQL.Append(".");
                strSQL.Append(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD);
                strSQL.Append("=");
                strSQL.Append(ABGappeiDoitsuninEntity.KEY_DOITSUNINSHIKIBETSUCD);
                strSQL.Append(" AND ");
                strSQL.Append(ABAtenaEntity.TABLE_NAME);
                strSQL.Append(".");
                strSQL.Append(ABAtenaEntity.JUTOGAIYUSENKB);
                strSQL.Append(" = ");
                strSQL.Append(ABAtenaEntity.KEY_JUTOGAIYUSENKB);
                strSQL.Append(" AND ");
                strSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                strSQL.Append(".");
                strSQL.Append(ABGappeiDoitsuninEntity.SAKUJOFG);
                strSQL.Append(" <> 1");

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfParameterCollection = new UFParameterCollectionClass();
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬

                // “¯ˆêlŽ¯•ÊƒR[ƒh
                cfParameter = new UFParameterClass();
                cfParameter.ParameterName = ABGappeiDoitsuninEntity.KEY_DOITSUNINSHIKIBETSUCD;
                cfParameter.Value = strDoitsuninShikibetsuCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfParameterCollection.Add(cfParameter);

                // Z“oŠO—Dæ‹æ•ª
                cfParameter = new UFParameterClass();
                cfParameter.ParameterName = ABAtenaEntity.KEY_JUTOGAIYUSENKB;
                cfParameter.Value = "1";
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfParameterCollection.Add(cfParameter);

                // *—š—ð”Ô† 000001 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLog.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + strSQL.ToString + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLog.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + default



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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 7898


                                Input:
                                " + m_cfRdb.GetDevelopmentSQLString(strSQL.ToString, cfParameterCollection) + "z")
                                            '*—š—ð”Ô† 000001 2003/08/28 C³I—¹

                                 */
                csGappeiDoitsuninEntity = m_cfRdb.GetDataSet(strSQL.ToString(), ABGappeiDoitsuninEntity.TABLE_NAME, cfParameterCollection);


                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException exAppException)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 8810


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 8913


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
            }

            catch (Exception exException) // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
            {
                // ƒGƒ‰[ƒƒOo—Í
                m_cfLog.ErrorWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9461


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csGappeiDoitsuninEntity

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     “¯ˆêlƒf[ƒ^ƒXƒL[ƒ}ì¬

                 */
            }

            return default;
        }
        // * 
        // * \•¶           Public Function GetSchemaDoitsuninData() As DataSet
        // * 
        // * ‹@”\@@       “¯ˆêlƒf[ƒ^‚ÌƒXƒL[ƒ}‚ðì¬‚·‚éB
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         ABDoitsuninDataEntity(DataSet) : “¯ˆêlƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetSchemaDoitsuninData()
        {
            const string THIS_METHOD_NAME = "GetSchemaDoitsuninData";
            DataSet csDoitsuninDataEntity;                // “¯ˆêlƒf[ƒ^ƒZƒbƒg
            DataTable csDoitsuninDataTable;               // “¯ˆêlƒf[ƒ^ƒe[ƒuƒ‹
            DataColumn csDataColumn;                      // ƒf[ƒ^ƒJƒ‰ƒ€

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ‡•¹“¯ˆêl‚Ìƒe[ƒuƒ‹ƒXƒL[ƒ}‚ðŽæ“¾‚·‚é
                csDoitsuninDataEntity = m_cfRdb.GetTableSchema(ABGappeiDoitsuninEntity.TABLE_NAME);

                // ƒe[ƒuƒ‹–¼‚ð•ÏX‚·‚é
                csDoitsuninDataTable = csDoitsuninDataEntity.Tables(ABGappeiDoitsuninEntity.TABLE_NAME);
                csDoitsuninDataTable.TableName = ABDoitsuninDataEntity.TABLE_NAME;

                // **
                // * •\Ž¦—pƒJƒ‰ƒ€‚ð’Ç‰Á‚·‚é
                // *
                // •\Ž¦—pŽí•Ê(Z–¯Ží•Ê)
                csDataColumn = new DataColumn(ABDoitsuninDataEntity.DISP_HENSHUSHUBETSURYOKU, Type.GetType("System.String"));
                csDataColumn.MaxLength = 3;
                csDoitsuninDataTable.Columns.Add(csDataColumn);
                // •\Ž¦—p¶”NŒŽ“ú
                csDataColumn = new DataColumn(ABDoitsuninDataEntity.DISP_UMAREHYOJIWMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 11;
                csDoitsuninDataTable.Columns.Add(csDataColumn);
                // •\Ž¦—p«•Ê
                csDataColumn = new DataColumn(ABDoitsuninDataEntity.DISP_SEIBETSU, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDoitsuninDataTable.Columns.Add(csDataColumn);
                // •\Ž¦—pŽ–¼i–¼Ìj
                csDataColumn = new DataColumn(ABDoitsuninDataEntity.DISP_HENSHUKANJISHIMEI, Type.GetType("System.String"));
                // * —š—ð”Ô† 000004 2007/07/10 C³ŠJŽn
                csDataColumn.MaxLength = 240;
                // csDataColumn.MaxLength = 40
                // * —š—ð”Ô† 000004 2007/07/10 C³I—¹
                csDoitsuninDataTable.Columns.Add(csDataColumn);
                // •\Ž¦—pZŠ
                csDataColumn = new DataColumn(ABDoitsuninDataEntity.DISP_HENSHUJUSHO, Type.GetType("System.String"));
                // * —š—ð”Ô† 000004 2007/07/10 C³ŠJŽn
                csDataColumn.MaxLength = 160;
                // csDataColumn.MaxLength = 60
                // * —š—ð”Ô† 000004 2007/07/10 C³I—¹
                csDoitsuninDataTable.Columns.Add(csDataColumn);
                // •\Ž¦—ps­‹æ
                csDataColumn = new DataColumn(ABDoitsuninDataEntity.DISP_GYOSEIKUMEI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 30;
                csDoitsuninDataTable.Columns.Add(csDataColumn);
                // •\Ž¦—p¢‘ÑƒR[ƒh
                csDataColumn = new DataColumn(ABDoitsuninDataEntity.DISP_STAICD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 15;
                csDoitsuninDataTable.Columns.Add(csDataColumn);
                // *—š—ð”Ô† 000002 2003/08/28 C³ŠJŽn
                // •\Ž¦—p¢‘ÑƒR[ƒh
                csDataColumn = new DataColumn(ABDoitsuninDataEntity.DISP_KYUSHICHOSONCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDoitsuninDataTable.Columns.Add(csDataColumn);
                // *—š—ð”Ô† 000002 2003/08/28 C³I—¹
                // •\Ž¦—p–{l‹æ•ª
                csDataColumn = new DataColumn(ABDoitsuninDataEntity.DISP_HONNINKBMEI, Type.GetType("System.String"));
                csDataColumn.MaxLength = 3;
                csDoitsuninDataTable.Columns.Add(csDataColumn);

                // —š—ð”Ô† 000003 2007/05/22 ’Ç‰ÁŠJŽn
                // ˆ¶–¼ƒf[ƒ^Ží•Ê
                csDataColumn = new DataColumn(ABDoitsuninDataEntity.ATENADATASHU, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDoitsuninDataTable.Columns.Add(csDataColumn);
                // —š—ð”Ô† 000003 2007/05/22 ’Ç‰ÁI—¹

                // —š—ð”Ô† 000005 2014/09/01 ’Ç‰ÁŠJŽn
                // ŒÂl”Ô†
                csDataColumn = new DataColumn(ABDoitsuninDataEntity.MYNUMBER, Type.GetType("System.String"));
                csDataColumn.MaxLength = 13;
                csDoitsuninDataTable.Columns.Add(csDataColumn);
                // ˆ¶–¼ƒf[ƒ^‹æ•ª
                csDataColumn = new DataColumn(ABDoitsuninDataEntity.ATENADATAKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                csDoitsuninDataTable.Columns.Add(csDataColumn);
                // —š—ð”Ô† 000005 2014/09/01 ’Ç‰ÁI—¹

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFRdbTimeOutException objRdbTimeOutExp)    // UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 15475


                Input:
                " + objRdbTimeOutExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 15578


                                Input:
                                " + objRdbTimeOutExp.Message + "z")
                                            ' UFAppException‚ðƒXƒ[‚·‚é
                                            Throw New UFAppException(objRdbTimeOutExp.Message, objRdbTimeOutExp.p_intErrorCode, objRdbTimeOutExp)

                                        Catch objAppExp As UFAppException    ' UFAppException‚ðƒLƒƒƒbƒ`
                                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í

                                 */
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 16212


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 16308


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLog.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 16571


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 16654


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csDoitsuninDataEntity;

        }

        #region “
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     “¯ˆêlŽæ“¾
        // * 
        // * \•¶           Public Function GetDoitsuninData_JuminCD(ByVal strJuminCD As String) As DataSet
        // * 
        // * ‹@”\@@    @Z–¯ƒR[ƒhŽw’è‚Å“¯ˆêl‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”           strJuminCD As String      :Z–¯ƒR[ƒh
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½‡•¹“¯ˆêl‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsGappeiDoitsuninEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABGappeiDoitsuninEntity
        // ************************************************************************************************
        public DataSet GetDoitsuninData_JuminCD(string strJuminCD)
        {
            const string THIS_METHOD_NAME = "GetDoitsuninData_JuminCD";          // ‚±‚Ìƒƒ\ƒbƒh–¼
            DataSet csGappeiDoitsuninEntity;                          // ‡•¹“¯ˆêlƒf[ƒ^
            var strSQL = new StringBuilder();                               // SQL•¶•¶Žš—ñ
            UFParameterClass cfParameter;                             // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfParameterCollection;         // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);

                // WHERE•¶Œ‹‡
                strSQL.Append(" WHERE ");
                strSQL.Append(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD);
                strSQL.Append(" = (SELECT ");
                strSQL.Append(ABGappeiDoitsuninEntity.DOITSUNINSHIKIBETSUCD);
                strSQL.Append(" FROM ");
                strSQL.Append(ABGappeiDoitsuninEntity.TABLE_NAME);
                strSQL.Append(" WHERE ");
                strSQL.Append(ABGappeiDoitsuninEntity.JUMINCD);
                strSQL.Append(" = ");
                strSQL.Append(ABGappeiDoitsuninEntity.KEY_JUMINCD);
                strSQL.Append(" AND ");
                strSQL.Append(ABGappeiDoitsuninEntity.SAKUJOFG);
                strSQL.Append(" <> '1')");
                strSQL.Append(" AND ");
                strSQL.Append(ABGappeiDoitsuninEntity.SAKUJOFG);
                strSQL.Append(" <> '1'");
                strSQL.Append(" ORDER BY ");
                strSQL.Append(ABGappeiDoitsuninEntity.JUMINCD);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfParameterCollection = new UFParameterCollectionClass();
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬

                // “¯ˆêlŽ¯•ÊƒR[ƒh
                cfParameter = new UFParameterClass();
                cfParameter.ParameterName = ABGappeiDoitsuninEntity.KEY_JUMINCD;
                cfParameter.Value = strJuminCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfParameterCollection.Add(cfParameter);

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLog.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + default
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 20318


                                Input:
                                " + m_cfRdb.GetDevelopmentSQLString(strSQL.ToString, cfParameterCollection) + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csGappeiDoitsuninEntity = m_cfRdb.GetDataSet(strSQL.ToString(), ABGappeiDoitsuninEntity.TABLE_NAME, cfParameterCollection);


                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException exAppException)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21174


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21275


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
            }

            catch (Exception exException) // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
            {
                // ƒGƒ‰[ƒƒOo—Í
                m_cfLog.ErrorWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21817


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csGappeiDoitsuninEntity

                    End Function
                #End Region

                #Region "“¯ˆêlŒó•âŽÒŽæ“¾"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     “¯ˆêlŒó•âŽÒŽæ“¾
                    '* 
                    '* \•¶           Public Function GetDoitsuninKohoshaData(ByVal strJuminCD As String) As DataSet
                    '* 
                    '* ‹@”\@@    @Z–¯ƒR[ƒhŽw’è‚Å“¯ˆêlŒó•âŽÒ‚ðŽæ“¾‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           strJuminCD As String      :Z–¯ƒR[ƒh
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½“¯ˆêlŒó•âŽÒ‚Ìƒf[ƒ^iDataSetj
        // *                   \‘¢FcsResultDS    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABDoitsuninKohoshaEntity
        // ************************************************************************************************
        public DataSet GetDoitsuninKohoshaData(string strJuminCD)
        {
            const string THIS_METHOD_NAME = "GetDoitsuninKohoshaData";          // ‚±‚Ìƒƒ\ƒbƒh–¼
            var csResultDS = default(DataSet);                                       // “¯ˆêlŒó•âŽÒƒf[ƒ^
            var strSQL = new StringBuilder();                               // SQL•¶•¶Žš—ñ
            UFParameterClass cfParameter;                             // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfParameterCollection;         // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
            ABAtenaSearchKey cSearchKey;
            ABAtenaBClass cABAtenaB;
            DataSet csDataSet;
            DataRow csRow;
            string strUmareYMD;
            string strSearchKanaShimei1;
            string strSearchKanaShimei2;
            string strSearchKanaShimei3;
            string strSearchKanaShimei4;
            string strSearchKanaShimei5;
            string strSeibetsuCd;
            int intI = 0;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ‘ÎÛŽÒ‚ÌŒŸõ
                cSearchKey = new ABAtenaSearchKey();
                cSearchKey.p_strJuminCD = strJuminCD;
                cSearchKey.p_strJutogaiYusenKB = "1";                                // Z“oŠO—Dæ
                cABAtenaB = new ABAtenaBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdb, ABEnumDefine.AtenaGetKB.SelectAll, true);
                cABAtenaB.m_intHyojunKB = ABEnumDefine.HyojunKB.KB_Hyojun;           // •W€‰»‘Î‰ž
                csDataSet = cABAtenaB.GetAtenaBHoshu(1, cSearchKey);

                if (csDataSet is null)
                {
                    return csResultDS;
                }
                else if (csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count > 0)
                {
                    csRow = csDataSet.Tables(ABAtenaEntity.TABLE_NAME).Rows(0);
                    strUmareYMD = csRow.Item(ABAtenaEntity.UMAREYMD).ToString;
                    strSearchKanaShimei1 = csRow.Item(ABAtenaEntity.SEARCHKANASEIMEI).ToString;
                    if (csRow.Item(ABAtenaEntity.ATENADATAKB).ToString == ABConstClass.ATENADATAKB_HOJIN)
                    {
                        strSearchKanaShimei2 = csRow.Item(ABAtenaEntity.SEARCHKANASEI).ToString;
                    }
                    else
                    {
                        strSearchKanaShimei2 = string.Empty;
                    }
                    strSearchKanaShimei3 = csRow.Item(ABAtenaFZYHyojunEntity.SEARCHKANAFRNMEI).ToString;
                    strSearchKanaShimei4 = csRow.Item(ABAtenaFZYHyojunEntity.SEARCHKANATSUSHOMEI).ToString;
                    strSearchKanaShimei5 = csRow.Item(ABAtenaFZYHyojunEntity.SEARCHKANAHEIKIMEI).ToString;
                    strSeibetsuCd = csRow.Item(ABAtenaEntity.SEIBETSUCD).ToString;
                }
                else
                {
                    return csResultDS;
                }

                // SQL•¶‚Ìì¬
                strSQL.Append(CreateSelect());
                strSQL.Append(" FROM ");
                strSQL.Append(ABAtenaEntity.TABLE_NAME);
                strSQL.Append(" LEFT JOIN ");
                strSQL.Append(ABAtenaFZYEntity.TABLE_NAME);
                strSQL.AppendFormat(" ON {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD);
                strSQL.AppendFormat(" = {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUMINCD);
                strSQL.AppendFormat(" AND {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINJUTOGAIKB);
                strSQL.AppendFormat(" = {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUMINJUTOGAIKB);
                strSQL.Append(" LEFT JOIN ");
                strSQL.Append(ABAtenaFZYHyojunEntity.TABLE_NAME);
                strSQL.AppendFormat(" ON {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD);
                strSQL.AppendFormat(" = {0}.{1}", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYEntity.JUMINCD);
                strSQL.AppendFormat(" AND {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINJUTOGAIKB);
                strSQL.AppendFormat(" = {0}.{1}", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.JUMINJUTOGAIKB);

                // WHERE•¶Œ‹‡
                strSQL.Append(" WHERE ");
                strSQL.AppendFormat("{0}.{1} = '1'", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUTOGAIYUSENKB);
                strSQL.AppendFormat(" AND {0}.{1} <> '1'", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.SAKUJOFG);
                strSQL.AppendFormat(" AND {0}.{1} <> ", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD);
                strSQL.Append(ABAtenaEntity.KEY_JUMINCD);
                strSQL.AppendFormat(" AND {0}.{1} = ", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.UMAREYMD);
                strSQL.Append(ABAtenaEntity.PARAM_UMAREYMD);
                strSQL.AppendFormat(" AND {0}.{1} = ", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.SEIBETSUCD);
                strSQL.Append(ABAtenaEntity.PARAM_SEIBETSUCD);
                // ŒŸõƒJƒi©–¼
                strSQL.AppendFormat(" AND (( {0}.{1} <> '' AND ", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.SEARCHKANASEIMEI);
                strSQL.AppendFormat("{0}.{1} IN(", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.SEARCHKANASEIMEI);
                intI = 1;
                strSQL.AppendFormat("{0},", ABAtenaEntity.PARAM_SEARCHKANASEIMEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0} ,", ABAtenaEntity.PARAM_SEARCHKANASEIMEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0} ,", ABAtenaEntity.PARAM_SEARCHKANASEIMEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0} ,", ABAtenaEntity.PARAM_SEARCHKANASEIMEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0})", ABAtenaEntity.PARAM_SEARCHKANASEIMEI + intI.ToString());
                // ŒŸõƒJƒi©
                strSQL.AppendFormat(") OR ({0}.{1} <> '' AND ", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.SEARCHKANASEI);
                strSQL.AppendFormat("{0}.{1} IN(", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.SEARCHKANASEI);
                intI = 1;
                strSQL.AppendFormat("{0} ,", ABAtenaEntity.PARAM_SEARCHKANASEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0} ,", ABAtenaEntity.PARAM_SEARCHKANASEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0} ,", ABAtenaEntity.PARAM_SEARCHKANASEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0} ,", ABAtenaEntity.PARAM_SEARCHKANASEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0})", ABAtenaEntity.PARAM_SEARCHKANASEI + intI.ToString());
                // ŒŸõƒJƒiŠO‘l–¼
                strSQL.AppendFormat(") OR ({0}.{1} <> '' AND ", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.SEARCHKANAFRNMEI);
                strSQL.AppendFormat("{0}.{1} IN(", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.SEARCHKANAFRNMEI);
                intI = 1;
                strSQL.AppendFormat("{0} ,", ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAFRNMEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0} ,", ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAFRNMEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0} ,", ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAFRNMEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0} ,", ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAFRNMEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0})", ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAFRNMEI + intI.ToString());
                // ŒŸõƒJƒi’ÊÌ–¼
                strSQL.AppendFormat(") OR ({0}.{1} <> '' AND ", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.SEARCHKANATSUSHOMEI);
                strSQL.AppendFormat("{0}.{1} IN(", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.SEARCHKANATSUSHOMEI);
                intI = 1;
                strSQL.AppendFormat("{0} ,", ABAtenaFZYHyojunEntity.PARAM_SEARCHKANATSUSHOMEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0} ,", ABAtenaFZYHyojunEntity.PARAM_SEARCHKANATSUSHOMEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0} ,", ABAtenaFZYHyojunEntity.PARAM_SEARCHKANATSUSHOMEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0} ,", ABAtenaFZYHyojunEntity.PARAM_SEARCHKANATSUSHOMEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0})", ABAtenaFZYHyojunEntity.PARAM_SEARCHKANATSUSHOMEI + intI.ToString());
                // ŒŸõƒJƒi•¹‹L–¼
                strSQL.AppendFormat(") OR ({0}.{1} <> '' AND ", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.SEARCHKANAHEIKIMEI);
                strSQL.AppendFormat("{0}.{1} IN(", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.SEARCHKANAHEIKIMEI);
                intI = 1;
                strSQL.AppendFormat("{0} ,", ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAHEIKIMEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0} ,", ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAHEIKIMEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0} ,", ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAHEIKIMEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0} ,", ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAHEIKIMEI + intI.ToString());
                intI += 1;
                strSQL.AppendFormat("{0})))", ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAHEIKIMEI + intI.ToString());

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfParameterCollection = new UFParameterCollectionClass();
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬

                // Z–¯ƒR[ƒh
                cfParameter = new UFParameterClass();
                cfParameter.ParameterName = ABAtenaEntity.KEY_JUMINCD;
                cfParameter.Value = strJuminCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfParameterCollection.Add(cfParameter);

                // ¶”NŒŽ“ú
                cfParameter = new UFParameterClass();
                cfParameter.ParameterName = ABAtenaEntity.PARAM_UMAREYMD;
                cfParameter.Value = strUmareYMD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfParameterCollection.Add(cfParameter);

                // «•ÊƒR[ƒh
                cfParameter = new UFParameterClass();
                cfParameter.ParameterName = ABAtenaEntity.PARAM_SEIBETSUCD;
                cfParameter.Value = strSeibetsuCd;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfParameterCollection.Add(cfParameter);

                // ŒŸõƒJƒi©–¼
                for (intI = 1; intI <= 5; intI++)
                {
                    cfParameter = new UFParameterClass();
                    cfParameter.ParameterName = ABAtenaEntity.PARAM_SEARCHKANASEIMEI + intI.ToString();
                    switch (intI)
                    {
                        case 1:
                            {
                                cfParameter.Value = strSearchKanaShimei1;
                                break;
                            }
                        case 2:
                            {
                                cfParameter.Value = strSearchKanaShimei2;
                                break;
                            }
                        case 3:
                            {
                                cfParameter.Value = strSearchKanaShimei3;
                                break;
                            }
                        case 4:
                            {
                                cfParameter.Value = strSearchKanaShimei4;
                                break;
                            }
                        case 5:
                            {
                                cfParameter.Value = strSearchKanaShimei5;
                                break;
                            }
                    }
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfParameterCollection.Add(cfParameter);
                }

                // ŒŸõƒJƒi©
                for (intI = 1; intI <= 5; intI++)
                {
                    cfParameter = new UFParameterClass();
                    cfParameter.ParameterName = ABAtenaEntity.PARAM_SEARCHKANASEI + intI.ToString();
                    switch (intI)
                    {
                        case 1:
                            {
                                cfParameter.Value = strSearchKanaShimei1;
                                break;
                            }
                        case 2:
                            {
                                cfParameter.Value = strSearchKanaShimei2;
                                break;
                            }
                        case 3:
                            {
                                cfParameter.Value = strSearchKanaShimei3;
                                break;
                            }
                        case 4:
                            {
                                cfParameter.Value = strSearchKanaShimei4;
                                break;
                            }
                        case 5:
                            {
                                cfParameter.Value = strSearchKanaShimei5;
                                break;
                            }
                    }
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfParameterCollection.Add(cfParameter);
                }

                // ŒŸõƒJƒiŠO‘l–¼
                for (intI = 1; intI <= 5; intI++)
                {
                    cfParameter = new UFParameterClass();
                    cfParameter.ParameterName = ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAFRNMEI + intI.ToString();
                    switch (intI)
                    {
                        case 1:
                            {
                                cfParameter.Value = strSearchKanaShimei1;
                                break;
                            }
                        case 2:
                            {
                                cfParameter.Value = strSearchKanaShimei2;
                                break;
                            }
                        case 3:
                            {
                                cfParameter.Value = strSearchKanaShimei3;
                                break;
                            }
                        case 4:
                            {
                                cfParameter.Value = strSearchKanaShimei4;
                                break;
                            }
                        case 5:
                            {
                                cfParameter.Value = strSearchKanaShimei5;
                                break;
                            }
                    }
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfParameterCollection.Add(cfParameter);
                }

                // ŒŸõƒJƒi’ÊÌ–¼
                for (intI = 1; intI <= 5; intI++)
                {
                    cfParameter = new UFParameterClass();
                    cfParameter.ParameterName = ABAtenaFZYHyojunEntity.PARAM_SEARCHKANATSUSHOMEI + intI.ToString();
                    switch (intI)
                    {
                        case 1:
                            {
                                cfParameter.Value = strSearchKanaShimei1;
                                break;
                            }
                        case 2:
                            {
                                cfParameter.Value = strSearchKanaShimei2;
                                break;
                            }
                        case 3:
                            {
                                cfParameter.Value = strSearchKanaShimei3;
                                break;
                            }
                        case 4:
                            {
                                cfParameter.Value = strSearchKanaShimei4;
                                break;
                            }
                        case 5:
                            {
                                cfParameter.Value = strSearchKanaShimei5;
                                break;
                            }
                    }
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfParameterCollection.Add(cfParameter);
                }

                // ŒŸõƒJƒi•¹‹L–¼
                for (intI = 1; intI <= 5; intI++)
                {
                    cfParameter = new UFParameterClass();
                    cfParameter.ParameterName = ABAtenaFZYHyojunEntity.PARAM_SEARCHKANAHEIKIMEI + intI.ToString();
                    switch (intI)
                    {
                        case 1:
                            {
                                cfParameter.Value = strSearchKanaShimei1;
                                break;
                            }
                        case 2:
                            {
                                cfParameter.Value = strSearchKanaShimei2;
                                break;
                            }
                        case 3:
                            {
                                cfParameter.Value = strSearchKanaShimei3;
                                break;
                            }
                        case 4:
                            {
                                cfParameter.Value = strSearchKanaShimei4;
                                break;
                            }
                        case 5:
                            {
                                cfParameter.Value = strSearchKanaShimei5;
                                break;
                            }
                    }
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfParameterCollection.Add(cfParameter);
                }

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLog.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + default
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 38216


                                Input:
                                " + m_cfRdb.GetDevelopmentSQLString(strSQL.ToString, cfParameterCollection) + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csResultDS = m_cfRdb.GetDataSet(strSQL.ToString(), ABDoitsuninKohoshaEntity.TABLE_NAME, cfParameterCollection);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException exAppException)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 39059


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 39160


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
            }

            catch (Exception exException) // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
            {
                // ƒGƒ‰[ƒƒOo—Í
                m_cfLog.ErrorWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 39702


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csResultDS

                    End Function

                #End Region

                #Region "SELECT‹åì¬"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     SELECT‹å‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateSelect() As String
                    '* 
                    '* ‹@”\@@    @ SELECT‹å‚ð¶¬‚·‚é

                 */
            }

            return default;
        }
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
                m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SELECT‹å‚Ìì¬
                csSELECT.AppendFormat("SELECT {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUMINCD);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.ATENADATAKB);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.ATENADATASHU);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.KANAMEISHO1);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.KANJIMEISHO1);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.KANAMEISHO2);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.KANJIMEISHO2);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KANATSUSHOMEI);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KANJITSUSHOMEI);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KANAHONGOKUMEI);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.HONGOKUMEI);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KANAHEIKIMEI);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KANJIHEIKIMEI);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaFZYHyojunEntity.TABLE_NAME, ABAtenaFZYHyojunEntity.SHIMEIYUSENKB);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.UMAREYMD);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.SEIBETSUCD);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.SEIBETSU);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUSHO);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.BANCHI);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.KATAGAKI);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.YUBINNO);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.JUSHOCD);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.BANCHICD1);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.BANCHICD2);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.BANCHICD3);
                csSELECT.AppendFormat(", {0}.{1}", ABAtenaEntity.TABLE_NAME, ABAtenaEntity.KATAGAKICD);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 43962


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 44058


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLog.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 44321


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 44404


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csSELECT.ToString();

        }
        #endregion

        #endregion

    }
}