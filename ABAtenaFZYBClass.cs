// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‚`‚aˆ¶–¼•tƒ}ƒXƒ^‚c‚`(ABAtenaFZYBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2011/10/24@¬¼@’m®
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// *
// ************************************************************************************************
using System.Data;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Densan.Reams.AB.AB000BB
{

    // ************************************************************************************************
    // *
    // * ˆ¶–¼ƒ}ƒXƒ^Žæ“¾Žž‚ÉŽg—p‚·‚éƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
    // *
    // ************************************************************************************************
    public class ABAtenaFZYBClass
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
        private const string THIS_CLASS_NAME = "ABAtenaFZYBClass";                     // ƒNƒ‰ƒX–¼
        private const string THIS_BUSINESSID = "AB";                                   // ‹Æ–±ƒR[ƒh

        private const string SAKUJOFG_OFF = "0";
        private const string SAKUJOFG_ON = "1";
        private const decimal KOSHINCOUNTER_DEF = decimal.Zero;

        private const string FORMAT_UPDATETIME = "yyyyMMddHHmmssfff";

        private const string ERR_JUMINCD = "Z–¯ƒR[ƒh";

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
        public ABAtenaFZYBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

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
        #region ˆ¶–¼•tƒ}ƒXƒ^’Šo@[GetAtenaFZYBHoshu]
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼    ˆ¶–¼•tƒ}ƒXƒ^’Šo
        // * 
        // * \•¶          Public Function GetAtenaFZYBHoshu() As DataSet
        // * 
        // * ‹@”\@@    @ˆ¶–¼•tƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”          strJuminCD         : Z–¯ƒR[ƒh 
        // *               strJuminJutogaiKB  : Z–¯Z“oŠO‹æ•ª
        // * 
        // * –ß‚è’l        DataSet : Žæ“¾‚µ‚½ˆ¶–¼•tƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetAtenaFZYBHoshu(string strJuminCD, string strJuminJutogaiKB)
        {

            return GetAtenaFZYBHoshu(strJuminCD, strJuminJutogaiKB, false);

        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼    ˆ¶–¼•tƒ}ƒXƒ^’Šo
        // * 
        // * \•¶          Public Function GetAtenaFZYBHoshu() As DataSet
        // * 
        // * ‹@”\@@    @ˆ¶–¼•tƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”          strJuminCD         : Z–¯ƒR[ƒh 
        // *               strJuminJutogaiKB  : Z–¯Z“oŠO‹æ•ª
        // *               blnSakujoFG        : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l        DataSet : Žæ“¾‚µ‚½ˆ¶–¼•tƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetAtenaFZYBHoshu(string strJuminCD, string strJuminJutogaiKB, bool blnSakujoFG)

        {

            const string THIS_METHOD_NAME = "GetAtenaFZYBHoshu";
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            DataSet csAtenaEntity;
            var strSQL = new StringBuilder();

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
                // Z–¯ƒR[ƒh‚ªŽw’è‚³‚ê‚Ä‚¢‚È‚¢‚Æ‚«ƒGƒ‰[
                if (strJuminCD == null || strJuminCD.Trim().RLength == 0)
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
                strSQL.AppendFormat(" FROM {0} ", ABAtenaFZYEntity.TABLE_NAME);

                // ÃÞ°À½·°Ï‚ÌŽæ“¾
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaFZYEntity.TABLE_NAME, false);
                }

                // WHERE‹å‚Ìì¬
                strSQL.Append(CreateWhere(strJuminCD, strJuminJutogaiKB, blnSakujoFG));

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString(), m_cfSelectUFParameterCollectionClass) + "z")

                // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                csAtenaEntity = m_csDataSchma.Clone();
                csAtenaEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csAtenaEntity, ABAtenaFZYEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10008


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10106


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10376


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10461


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csAtenaEntity;

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
                csSELECT.AppendFormat("SELECT {0}", ABAtenaFZYEntity.JUMINCD);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.SHICHOSONCD);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.KYUSHICHOSONCD);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.JUMINJUTOGAIKB);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.TABLEINSERTKB);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.LINKNO);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.JUMINHYOJOTAIKBN);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.JUKYOCHITODOKEFLG);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.HONGOKUMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.KANAHONGOKUMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.KANJIHEIKIMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.KANAHEIKIMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.KANJITSUSHOMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.KANATSUSHOMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.KATAKANAHEIKIMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.UMAREFUSHOKBN);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.TSUSHOMEITOUROKUYMD);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.ZAIRYUKIKANCD);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.ZAIRYUKIKANMEISHO);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.ZAIRYUSHACD);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.ZAIRYUSHAMEISHO);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.ZAIRYUCARDNO);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.KOFUYMD);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.KOFUYOTEISTYMD);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.KOFUYOTEIEDYMD);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.JUKITAISHOSHASHOJOIDOYMD);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYUCD);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYU);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDYMD);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDTUCIKB);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.FRNSTAINUSMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.FRNSTAINUSKANAMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.STAINUSHEIKIMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.STAINUSKANAHEIKIMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.STAINUSTSUSHOMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.STAINUSKANATSUSHOMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.TENUMAEJ_STAINUSMEI_KYOTSU);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.TENUMAEJ_STAINUSHEIKIMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.TENUMAEJ_STAINUSTSUSHOMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.TENSHUTSUYOTEISTAINUSMEI_KYOTSU);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.TENSHUTSUYOTEISTAINUSHEIKIMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.TENSHUTSUYOTEISTAINUSTSUSHOMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.TENSHUTSUKKTISTAINUSMEI_KYOTSU);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.TENSHUTSUKKTISTAINUSHEIKIMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.TENSHUTSUKKTISTAINUSTSUSHOMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.RESERVE1);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.RESERVE2);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.RESERVE3);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.RESERVE4);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.RESERVE5);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.RESERVE6);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.RESERVE7);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.RESERVE8);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.RESERVE9);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.RESERVE10);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.TANMATSUID);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.SAKUJOFG);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.KOSHINCOUNTER);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.SAKUSEINICHIJI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.SAKUSEIUSER);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.KOSHINNICHIJI);
                csSELECT.AppendFormat(", {0}", ABAtenaFZYEntity.KOSHINUSER);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 16937


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17035


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17305


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17390


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
        // * ˆø”         strJuminCD         : Z–¯ƒR[ƒh 
        // *              strJuminJutogaiKB  : Z–¯Z“oŠO‹æ•ª
        // *              blnSakujoFG        : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l       ‚È‚µ
        // ************************************************************************************************
        private string CreateWhere(string strJuminCD, string strJuminJutogaiKB, bool blnSakujoFG)

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
                csWHERE.AppendFormat("WHERE {0} = {1}", ABAtenaFZYEntity.JUMINCD, ABAtenaFZYEntity.KEY_JUMINCD);
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaFZYEntity.KEY_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);

                // Z–¯Z“oŠO‹æ•ª
                if (!strJuminJutogaiKB.Trim().Equals(string.Empty))
                {
                    csWHERE.AppendFormat(" AND {0} = {1}", ABAtenaFZYEntity.JUMINJUTOGAIKB, ABAtenaFZYEntity.KEY_JUMINJUTOGAIKB);
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABAtenaFZYEntity.KEY_JUMINJUTOGAIKB;
                    cfUFParameterClass.Value = strJuminJutogaiKB;
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
                    csWHERE.AppendFormat(" AND {0} <> '{1}'", ABAtenaFZYEntity.SAKUJOFG, SAKUJOFG_ON);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21136


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21234


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21504


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21589


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csWHERE.ToString();

        }
        #endregion

        #region ˆ¶–¼•tƒ}ƒXƒ^’Ç‰Á@[InsertAtenaFZYB]
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertAtenaFZYB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@ˆ¶–¼ƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertAtenaFZYB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "InsertAtenaB";
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
                csDataRow(ABAtenaFZYEntity.TANMATSUID) = m_cfControlData.m_strClientId;     // ’[––‚h‚c
                csDataRow(ABAtenaFZYEntity.SAKUJOFG) = SAKUJOFG_OFF;                        // íœƒtƒ‰ƒO
                csDataRow(ABAtenaFZYEntity.KOSHINCOUNTER) = KOSHINCOUNTER_DEF;              // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaFZYEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;      // ì¬ƒ†[ƒU[
                csDataRow(ABAtenaFZYEntity.KOSHINUSER) = m_cfControlData.m_strUserId;       // XVƒ†[ƒU[

                // ì¬“úŽžAXV“úŽž‚ÌÝ’è
                this.SetUpdateDatetime(csDataRow(ABAtenaFZYEntity.SAKUSEINICHIJI));
                this.SetUpdateDatetime(csDataRow(ABAtenaFZYEntity.KOSHINNICHIJI));

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    cfParam.Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaFZYEntity.PARAM_PLACEHOLDER.RLength)).ToString();

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strInsertSQL, m_cfInsertUFParameterCollectionClass) + "z")

                // SQL‚ÌŽÀs
                intInsCnt = m_cfRdbClass.ExecuteSQL(m_strInsertSQL, m_cfInsertUFParameterCollectionClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 25798


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 25896


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 26166


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 26251


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
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
                    strParamName = string.Format("{0}{1}", ABAtenaFZYEntity.PARAM_PLACEHOLDER, csDataColumn.ColumnName);

                    // INSERT SQL•¶‚Ìì¬
                    csInsertColumn.AppendFormat("{0},", csDataColumn.ColumnName);
                    csInsertParam.AppendFormat("{0},", strParamName);

                    // INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    cfUFParameterClass.ParameterName = strParamName;
                    m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass);

                }

                // ÅŒã‚ÌƒJƒ“ƒ}‚ðŽæ‚èœ‚¢‚ÄINSERT•¶‚ðì¬
                m_strInsertSQL = string.Format("INSERT INTO {0}({1}) VALUES ({2})", ABAtenaFZYEntity.TABLE_NAME, csInsertColumn.ToString().TrimEnd(",".ToCharArray()), csInsertParam.ToString().TrimEnd(",".ToCharArray()));



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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 29694


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 29792


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 30062


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 30147


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }

        #endregion

        #region ˆ¶–¼•tƒ}ƒXƒ^XV@[UpdateAtenaFZYB]
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼•tƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateAtenaFZYB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼•tƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : XV‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int UpdateAtenaFZYB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "UpdateAtenaFZYB";                     // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
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
                csDataRow(ABAtenaFZYEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                   // ’[––‚h‚c
                csDataRow(ABAtenaFZYEntity.KOSHINCOUNTER) = Conversions.ToDecimal(csDataRow(ABAtenaFZYEntity.KOSHINCOUNTER)) + 1m;          // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaFZYEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                     // XVƒ†[ƒU[

                // XV“úŽž‚ÌÝ’è
                m_strUpdateDatetime = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME);
                this.SetUpdateDatetime(csDataRow(ABAtenaFZYEntity.KOSHINNICHIJI));

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABAtenaFZYEntity.PREFIX_KEY.RLength) == ABAtenaFZYEntity.PREFIX_KEY)
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaFZYEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }

                    // ƒL[€–ÚˆÈŠO‚Í•ÒW“à—eŽæ“¾
                    else
                    {
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaFZYEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass) + "z")

                // SQL‚ÌŽÀs
                intUpdCnt = m_cfRdbClass.ExecuteSQL(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 34824


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 34922


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 35192


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 35277


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
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
                m_strUpdateSQL = "UPDATE " + ABAtenaFZYEntity.TABLE_NAME + " SET ";
                csUpdateParam = new StringBuilder();

                // WHERE•¶‚Ìì¬
                csWhere = new StringBuilder();
                csWhere.Append(" WHERE ");
                csWhere.Append(ABAtenaFZYEntity.JUMINCD);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaFZYEntity.KEY_JUMINCD);
                csWhere.Append(" AND ");
                csWhere.Append(ABAtenaFZYEntity.JUMINJUTOGAIKB);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaFZYEntity.KEY_JUMINJUTOGAIKB);
                csWhere.Append(" AND ");
                csWhere.Append(ABAtenaFZYEntity.KOSHINCOUNTER);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaFZYEntity.KEY_KOSHINCOUNTER);

                // UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfUpdateUFParameterCollectionClass = new UFParameterCollectionClass();

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                {
                    // Z–¯‚b‚cEZ–¯Z“oŠO‹æ•ªEì¬“úŽžEì¬ƒ†[ƒU‚ÍXV‚µ‚È‚¢
                    if (!(csDataColumn.ColumnName == ABAtenaFZYEntity.JUMINCD) && !(csDataColumn.ColumnName == ABAtenaFZYEntity.JUMINJUTOGAIKB) && !(csDataColumn.ColumnName == ABAtenaFZYEntity.SAKUSEIUSER) && !(csDataColumn.ColumnName == ABAtenaFZYEntity.SAKUSEINICHIJI))


                    {

                        cfUFParameterClass = new UFParameterClass();

                        // UPDATE SQL•¶‚Ìì¬
                        csUpdateParam.Append(csDataColumn.ColumnName);
                        csUpdateParam.Append(" = ");
                        csUpdateParam.Append(ABAtenaFZYEntity.PARAM_PLACEHOLDER);
                        csUpdateParam.Append(csDataColumn.ColumnName);
                        csUpdateParam.Append(",");

                        // UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                        cfUFParameterClass.ParameterName = ABAtenaFZYEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
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
                cfUFParameterClass.ParameterName = ABAtenaFZYEntity.KEY_JUMINCD;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaFZYEntity.KEY_JUMINJUTOGAIKB;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaFZYEntity.KEY_KOSHINCOUNTER;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40467


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40565


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40835


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40920


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }

        #endregion

        #region ˆ¶–¼•tƒ}ƒXƒ^íœ@[DeleteAtenaFZYB]
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^íœ
        // * 
        // * \•¶           Public Function DeleteAtenaFZYB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@ˆ¶–¼ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð˜_—íœ‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ˜_—íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int DeleteAtenaFZYB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "DeleteAtenaFZYB";  // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
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
                csDataRow(ABAtenaFZYEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                   // ’[––‚h‚c
                csDataRow(ABAtenaFZYEntity.SAKUJOFG) = SAKUJOFG_ON;                                                       // íœƒtƒ‰ƒO
                csDataRow(ABAtenaFZYEntity.KOSHINCOUNTER) = Conversions.ToDecimal(csDataRow(ABAtenaFZYEntity.KOSHINCOUNTER)) + 1m;          // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaFZYEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                     // XVƒ†[ƒU[

                // XV“úŽž‚ÌÝ’è
                m_strUpdateDatetime = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME);
                this.SetUpdateDatetime(csDataRow(ABAtenaFZYEntity.KOSHINNICHIJI));

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfDelRonriUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABAtenaFZYEntity.PREFIX_KEY.RLength) == ABAtenaFZYEntity.PREFIX_KEY)
                    {
                        this.m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaFZYEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    // ƒL[€–ÚˆÈŠO‚Í•ÒW“à—e‚ðÝ’è
                    else
                    {
                        this.m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaFZYEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass) + "z")
                // SQL‚ÌŽÀs
                intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 45735


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 45833


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 46103


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 46188


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intDelCnt;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ƒ}ƒXƒ^•¨—íœ
        // * 
        // * \•¶           Public Function DeleteAtenaFZYB(ByVal csDataRow As DataRow, _
        // *                                               ByVal strSakujoKB As String) As Integer
        // * 
        // * ‹@”\@@    @@ˆ¶–¼ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð•¨—íœ‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int DeleteAtenaFZYB(DataRow csDataRow, string strSakujoKB)
        {

            const string THIS_METHOD_NAME = "DeleteAtenaFZYB";
            UFErrorStruct objErrorStruct; // ƒGƒ‰[’è‹`\‘¢‘Ì
                                          // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            int intDelCnt;            // íœŒ”


            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // íœ‹æ•ª‚Ìƒ`ƒFƒbƒN‚ðs‚¤
                if (!(strSakujoKB == "D"))
                {

                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_DELETE_SAKUJOKB);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // íœ—p‚Ìƒpƒ‰ƒ[ƒ^•tDELETE•¶•¶Žš—ñ‚Æƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                if (m_strDelButuriSQL is null || string.IsNullOrEmpty(m_strDelButuriSQL) || m_cfDelButuriUFParameterCollectionClass == null)
                {
                    CreateDeleteButsuriSQL(csDataRow);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚Öíœs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfDelButuriUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABAtenaFZYEntity.PREFIX_KEY.RLength) == ABAtenaFZYEntity.PREFIX_KEY)
                    {
                        this.m_cfDelButuriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaFZYEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }

                    // ƒL[€–ÚˆÈŠO‚ÌŽæ“¾‚È‚µ
                    else
                    {
                        // ˆ—‚È‚µ
                    }
                }

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strDelButuriSQL, m_cfDelButuriUFParameterCollectionClass) + "z")
                // SQL‚ÌŽÀs
                intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelButuriSQL, m_cfDelButuriUFParameterCollectionClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 50648


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 50746


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 51016


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 51101


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intDelCnt;

        }


        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˜_—íœ—pSQL•¶‚Ìì¬
        // * 
        // * \•¶           Private Sub CreateDeleteRonriSQL(ByVal csDataRow As DataRow)
        // * 
        // * ‹@”\           ˜_—DELETE—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void CreateDeleteRonriSQL(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "CreateDeleteRonriSQL";
            UFParameterClass cfUFParameterClass;
            StringBuilder csWhere;                        // WHERE’è‹`
            StringBuilder csDelRonriParam;                // ˜_—íœƒpƒ‰ƒ[ƒ^’è‹`

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // WHERE•¶‚Ìì¬
                csWhere = new StringBuilder();
                csWhere.Append(" WHERE ");
                csWhere.Append(ABAtenaFZYEntity.JUMINCD);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaFZYEntity.KEY_JUMINCD);
                csWhere.Append(" AND ");
                csWhere.Append(ABAtenaFZYEntity.JUMINJUTOGAIKB);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaFZYEntity.KEY_JUMINJUTOGAIKB);
                csWhere.Append(" AND ");
                csWhere.Append(ABAtenaFZYEntity.KOSHINCOUNTER);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaFZYEntity.KEY_KOSHINCOUNTER);


                // ˜_—DELETE SQL•¶‚Ìì¬
                csDelRonriParam = new StringBuilder();
                csDelRonriParam.Append("UPDATE ");
                csDelRonriParam.Append(ABAtenaFZYEntity.TABLE_NAME);
                csDelRonriParam.Append(" SET ");
                csDelRonriParam.Append(ABAtenaFZYEntity.TANMATSUID);
                csDelRonriParam.Append(" = ");
                csDelRonriParam.Append(ABAtenaFZYEntity.PARAM_TANMATSUID);
                csDelRonriParam.Append(", ");
                csDelRonriParam.Append(ABAtenaFZYEntity.SAKUJOFG);
                csDelRonriParam.Append(" = ");
                csDelRonriParam.Append(ABAtenaFZYEntity.PARAM_SAKUJOFG);
                csDelRonriParam.Append(", ");
                csDelRonriParam.Append(ABAtenaFZYEntity.KOSHINCOUNTER);
                csDelRonriParam.Append(" = ");
                csDelRonriParam.Append(ABAtenaFZYEntity.PARAM_KOSHINCOUNTER);
                csDelRonriParam.Append(", ");
                csDelRonriParam.Append(ABAtenaFZYEntity.KOSHINNICHIJI);
                csDelRonriParam.Append(" = ");
                csDelRonriParam.Append(ABAtenaFZYEntity.PARAM_KOSHINNICHIJI);
                csDelRonriParam.Append(", ");
                csDelRonriParam.Append(ABAtenaFZYEntity.KOSHINUSER);
                csDelRonriParam.Append(" = ");
                csDelRonriParam.Append(ABAtenaFZYEntity.PARAM_KOSHINUSER);
                csDelRonriParam.Append(csWhere);
                // Where•¶‚Ì’Ç‰Á
                m_strDelRonriSQL = csDelRonriParam.ToString();

                // ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfDelRonriUFParameterCollectionClass = new UFParameterCollectionClass();

                // ˜_—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaFZYEntity.PARAM_TANMATSUID;
                m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaFZYEntity.PARAM_SAKUJOFG;
                m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaFZYEntity.PARAM_KOSHINCOUNTER;
                m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaFZYEntity.PARAM_KOSHINNICHIJI;
                m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaFZYEntity.PARAM_KOSHINUSER;
                m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaFZYEntity.KEY_JUMINCD;
                m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaFZYEntity.KEY_JUMINJUTOGAIKB;
                m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaFZYEntity.KEY_KOSHINCOUNTER;
                m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 57075


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 57173


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 57443


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 57528


                Input:
                " + THIS_METHOD_NAME + "z" + _
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
                            csWhere.Append(ABAtenaFZYEntity.JUMINCD)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaFZYEntity.KEY_JUMINCD)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaFZYEntity.JUMINJUTOGAIKB)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaFZYEntity.KEY_JUMINJUTOGAIKB)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaFZYEntity.KOSHINCOUNTER)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaFZYEntity.KEY_KOSHINCOUNTER)

                            ' •¨—DELETE SQL•¶‚Ìì¬
                            m_strDelButuriSQL = "DELETE FROM " + ABAtenaFZYEntity.TABLE_NAME + csWhere.ToString

                            ' •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDelButuriUFParameterCollectionClass = New UFParameterCollectionClass

                            ' •¨—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaFZYEntity.KEY_JUMINCD
                            m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaFZYEntity.KEY_JUMINJUTOGAIKB
                            m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaFZYEntity.KEY_KOSHINCOUNTER
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
        }
    }
}