// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‚`‚aˆ¶–¼_•W€ƒ}ƒXƒ^‚c‚`(ABAtena_HyojunBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2023/08/14 ‘è  —Y–î
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2023/12/11  000001     yAB-9000-1zZŠîXV˜AŒg•W€‰»‘Î‰ž(‰º‘º)
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
    // * ˆ¶–¼_•W€ƒ}ƒXƒ^Žæ“¾Žž‚ÉŽg—p‚·‚éƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
    // *
    // ************************************************************************************************
    public class ABAtena_HyojunBClass
    {
        #region ƒƒ“
        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        private UFLogClass m_cfLogClass;                                              // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                                        // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;                                // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                                              // ‚q‚c‚aƒNƒ‰ƒX
        private UFErrorClass m_cfErrorClass;                                          // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private string m_strInsertSQL;                                                // INSERT—pSQL
        private string m_strUpdateSQL;                                                // UPDATE—pSQL
        private string m_strDelRonriSQL;                                              // ˜_—íœ—pSQL
        private string m_strDelButuriSQL;                                             // •¨—íœ—pSQL
        private UFParameterCollectionClass m_cfSelectUFParameterCollectionClass;      // SELECT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;      // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateUFParameterCollectionClass;      // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDelRonriUFParameterCollectionClass;    // ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDelButuriUFParameterCollectionClass;   // •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private DataSet m_csDataSchma;                                                // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private string m_strUpdateDatetime;                                           // XV“úŽž

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABAtena_HyojunBClass";                // ƒNƒ‰ƒX–¼
        private const string THIS_BUSINESSID = "AB";                                  // ‹Æ–±ƒR[ƒh
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
        public ABAtena_HyojunBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)
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
            m_cfSelectUFParameterCollectionClass = (object)null;
            m_cfInsertUFParameterCollectionClass = (object)null;
            m_cfUpdateUFParameterCollectionClass = (object)null;
            m_cfDelRonriUFParameterCollectionClass = (object)null;

        }
        #endregion

        #region ƒƒ\ƒbƒh
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼_•W€ƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetAtenaHyojunBHoshu(ByVal strJuminCD As String, _
        // *                                                     ByVal strJuminJutogaiKB As String, _
        // *                                                     ByVal blnSakujoFG As Boolean) As DataSet
        // * 
        // * ‹@”\@@    @ ˆ¶–¼_•W€ƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD         : Z–¯ƒR[ƒh 
        // *                strJuminJutogaiKB  : Z–¯Z“oŠO‹æ•ª
        // *                blnSakujoFG        : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½ˆ¶–¼_•W€ƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetAtenaHyojunBHoshu(string strJuminCD, string strJuminJutogaiKB, bool blnSakujoFG)
        {

            const string THIS_METHOD_NAME = "GetAtenaHyojunBHoshu";
            UFErrorStruct cfErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            DataSet csAtenaEntity;
            var csSQL = new StringBuilder();

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
                    cfErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001036);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(cfErrorStruct.m_strErrorMessage + ERR_JUMINCD, cfErrorStruct.m_strErrorCode);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // SELECT‹å‚Ì¶¬
                csSQL.Append(CreateSelect());
                // FROM‹å‚Ì¶¬
                csSQL.AppendFormat(" FROM {0} ", ABAtenaHyojunEntity.TABLE_NAME);
                // ÃÞ°À½·°Ï‚ÌŽæ“¾
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(csSQL.ToString(), ABAtenaHyojunEntity.TABLE_NAME, false);
                }

                // WHERE‹å‚Ìì¬
                csSQL.Append(CreateWhere(strJuminCD, strJuminJutogaiKB, blnSakujoFG));

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString( _
                // csSQL.ToString(), m_cfSelectUFParameterCollectionClass) + "z")

                // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                csAtenaEntity = m_csDataSchma.Clone();
                csAtenaEntity = m_cfRdbClass.GetDataSet(csSQL.ToString(), csAtenaEntity, ABAtenaHyojunEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9526


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9622


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9890


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9973


                                Input:
                                " + THIS_METHOD_NAME + "z" +
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
                csSELECT.AppendFormat("SELECT {0}", ABAtenaHyojunEntity.JUMINCD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUMINJUTOGAIKB);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.RRKNO);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.EDANO);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SHIMEIKANAKAKUNINFG);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.UMAREBIFUSHOPTN);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.FUSHOUMAREBI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JIJITSUSTAINUSMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.MACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SHIKUCHOSON);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.MACHIAZA);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SEARCHJUSHO);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.KANAKATAGAKI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SEARCHKATAGAKI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.BANCHIEDABANSUCHI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUSHO_KUNIMEICODE);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUSHO_KUNIMEITO);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUSHO_KOKUGAIJUSHO);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.HON_SHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.HON_MACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.HON_TODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.HON_SHIKUGUNCHOSON);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.HON_MACHIAZA);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.CKINIDOWMD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.CKINIDOBIFUSHOPTN);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.FUSHOCKINIDOBI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TOROKUIDOBIFUSHOPTN);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.FUSHOTOROKUIDOBI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.HYOJUNKISAIJIYUCD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.KISAIYMD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.KISAIBIFUSHOPTN);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.FUSHOKISAIBI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUTEIIDOBIFUSHOPTN);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.FUSHOJUTEIIDOBI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.HYOJUNSHOJOJIYUCD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.KOKUSEKISOSHITSUBI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SHOJOIDOWMD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SHOJOIDOBIFUSHOPTN);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.FUSHOSHOJOIDOBI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENUMAEJ_SHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENUMAEJ_MACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENUMAEJ_TODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENUMAEJ_SHIKUCHOSON);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENUMAEJ_MACHIAZA);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENUMAEJ_KOKUSEKICD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENUMAEJ_KOKUSEKI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENUMAEJ_KOKUGAIJUSHO);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SAISHUTJ_YUBINNO);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SAISHUTJ_SHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SAISHUTJ_MACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SAISHUTJ_TODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SAISHUTJ_SHIKUCHOSON);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SAISHUTJ_MACHIAZA);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SAISHUTJ_BANCHI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SAISHUTJ_KATAGAKI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SAISHUJ_TODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SAISHUJ_SHIKUCHOSON);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SAISHUJ_MACHIAZA);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SAISHUJ_BANCHI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SAISHUJ_KATAGAKI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENSHUTSUYOTEISHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENSHUTSUYOTEIMACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENSHUTSUYOTEITODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENSHUTSUYOTEISHIKUCHOSON);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENSHUTSUYOTEIMACHIAZA);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENSHUTSUYOTEIKOKUSEKICD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENSHUTSUYOTEIKOKUSEKI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENSHUTSUYOTEIKOKUGAIJUSHO);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENSHUTSUKKTISHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENSHUTSUKKTIMACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENSHUTSUKKTITODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENSHUTSUKKTISHIKUCHOSON);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TENSHUTSUKKTIMACHIAZA);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.KAISEIBIFUSHOPTN);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.FUSHOKAISEIBI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.KAISEISHOJOYMD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.KAISEISHOJOBIFUSHOPTN);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.FUSHOKAISEISHOJOBI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.CHIKUCD4);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.CHIKUCD5);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.CHIKUCD6);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.CHIKUCD7);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.CHIKUCD8);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.CHIKUCD9);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.CHIKUCD10);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TOKUBETSUYOSHIKB);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.IDOKB);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.NYURYOKUBASHOCD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.NYURYOKUBASHO);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SEARCHKANJIKYUUJI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SEARCHKANAKYUUJI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.KYUUJIKANAKAKUNINFG);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TDKDSHIMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.HYOJUNIDOJIYUCD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.NICHIJOSEIKATSUKENIKICD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.KOBOJONOJUSHO_SHOZAICHI_YOMIGANA);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TOROKUBUSHO);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TANKITAIZAISHAFG);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.KYOYUNINZU);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SHIZEIJIMUSHOCD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SHUKKOKUKIKAN_ST);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SHUKKOKUKIKAN_ED);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.IDOSHURUI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SHOKANKUCD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TOGOATENAFG);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.FUSHOUMAREBI_DATE);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.FUSHOCKINIDOBI_DATE);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.FUSHOSHOJOIDOBI_DATE);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUKISHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUKIMACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUKITODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUKISHIKUCHOSON);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUKIMACHIAZA);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUKIKANAKATAGAKI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUKICHIKUCD4);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUKICHIKUCD5);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUKICHIKUCD6);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUKICHIKUCD7);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUKICHIKUCD8);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUKICHIKUCD9);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUKICHIKUCD10);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.JUKIBANCHIEDABANSUCHI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.RESERVE1);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.RESERVE2);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.RESERVE3);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.RESERVE4);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.RESERVE5);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.TANMATSUID);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SAKUJOFG);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.KOSHINCOUNTER);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SAKUSEINICHIJI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.SAKUSEIUSER);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.KOSHINNICHIJI);
                csSELECT.AppendFormat(", {0}", ABAtenaHyojunEntity.KOSHINUSER);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22543


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22639


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22907


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22990


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csSELECT.ToString();

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     WHERE•¶‚Ìì¬
        // * 
        // * \•¶           Private Function CreateWhere(ByVal strJuminCD As String, _
        // ByVal strJuminJutogaiKB As String, _
        // ByVal blnSakujoFG As Boolean) As String
        // * 
        // * ‹@”\@@    @ WHERE•ª‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”           strJuminCD         : Z–¯ƒR[ƒh 
        // *                strJuminJutogaiKB  : Z–¯Z“oŠO‹æ•ª
        // *                blnSakujoFG        : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         ‚È‚µ
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
                csWHERE.AppendFormat("WHERE {0} = {1}", ABAtenaHyojunEntity.JUMINCD, ABAtenaHyojunEntity.KEY_JUMINCD);
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.KEY_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);

                // Z–¯Z“oŠO‹æ•ª
                if (!strJuminJutogaiKB.Trim().Equals(string.Empty))
                {
                    csWHERE.AppendFormat(" AND {0} = {1}", ABAtenaHyojunEntity.JUMINJUTOGAIKB, ABAtenaHyojunEntity.KEY_JUMINJUTOGAIKB);
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.KEY_JUMINJUTOGAIKB;
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
                    csWHERE.AppendFormat(" AND {0} <> '{1}'", ABAtenaHyojunEntity.SAKUJOFG, SAKUJOFG_ON);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 26968


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 27064


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 27332


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 27415


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csWHERE.ToString();

        }

        #region ˆ¶–¼_•W€ƒ}ƒXƒ^’Ç‰Á
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼_•W€ƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertAtenaHyojunB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼_•W€ƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertAtenaHyojunB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "InsertAtenaHyojunB";
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
                csDataRow(ABAtenaHyojunEntity.TANMATSUID) = m_cfControlData.m_strClientId;     // ’[––‚h‚c
                csDataRow(ABAtenaHyojunEntity.SAKUJOFG) = SAKUJOFG_OFF;                        // íœƒtƒ‰ƒO
                csDataRow(ABAtenaHyojunEntity.KOSHINCOUNTER) = KOSHINCOUNTER_DEF;              // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaHyojunEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;      // ì¬ƒ†[ƒU[
                csDataRow(ABAtenaHyojunEntity.KOSHINUSER) = m_cfControlData.m_strUserId;       // XVƒ†[ƒU[

                // ì¬“úŽžAXV“úŽž‚ÌÝ’è
                this.SetUpdateDatetime(csDataRow(ABAtenaHyojunEntity.SAKUSEINICHIJI));
                this.SetUpdateDatetime(csDataRow(ABAtenaHyojunEntity.KOSHINNICHIJI));

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    cfParam.Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaHyojunEntity.PARAM_PLACEHOLDER.RLength)).ToString();

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString( _
                // m_strInsertSQL, m_cfInsertUFParameterCollectionClass) + "z")

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31726


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31822


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 32090


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 32173


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
                    strParamName = string.Format("{0}{1}", ABAtenaHyojunEntity.PARAM_PLACEHOLDER, csDataColumn.ColumnName);

                    // INSERT SQL•¶‚Ìì¬
                    csInsertColumn.AppendFormat("{0},", csDataColumn.ColumnName);
                    csInsertParam.AppendFormat("{0},", strParamName);

                    // INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    cfUFParameterClass.ParameterName = strParamName;
                    m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass);

                }

                // ÅŒã‚ÌƒJƒ“ƒ}‚ðŽæ‚èœ‚¢‚ÄINSERT•¶‚ðì¬
                m_strInsertSQL = string.Format("INSERT INTO {0}({1}) VALUES ({2})", ABAtenaHyojunEntity.TABLE_NAME, csInsertColumn.ToString().TrimEnd(",".ToCharArray()), csInsertParam.ToString().TrimEnd(",".ToCharArray()));

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 35619


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 35715


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 35983


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36066


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }
        #endregion

        #region ˆ¶–¼_•W€ƒ}ƒXƒ^XV
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼_•W€ƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateAtenaHyojunB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼_•W€ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow @@: XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // *                strAtenaDataKB As String : ˆ¶–¼ƒf[ƒ^‹æ•ª
        // * 
        // * –ß‚è’l         Integer : XV‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int UpdateAtenaHyojunB(DataRow csDataRow, string strAtenaDataKB)
        {

            const string THIS_METHOD_NAME = "UpdateAtenaHyojunB";                     // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            int intUpdCnt;                            // XVŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strUpdateSQL is null || string.IsNullOrEmpty(m_strUpdateSQL) || m_cfUpdateUFParameterCollectionClass is null)
                {
                    CreateUpdateSQL(csDataRow, strAtenaDataKB);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABAtenaHyojunEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                   // ’[––‚h‚c
                csDataRow(ABAtenaHyojunEntity.KOSHINCOUNTER) = Conversions.ToDecimal(csDataRow(ABAtenaHyojunEntity.KOSHINCOUNTER)) + 1m;       // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaHyojunEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                     // XVƒ†[ƒU[

                // XV“úŽž‚ÌÝ’è
                m_strUpdateDatetime = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME);
                this.SetUpdateDatetime(csDataRow(ABAtenaHyojunEntity.KOSHINNICHIJI));

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABAtenaHyojunEntity.PREFIX_KEY.RLength) == ABAtenaHyojunEntity.PREFIX_KEY)
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        if (cfParam.ParameterName != ABAtenaHyojunEntity.KOSHINCOUNTER)
                        {
                            this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaHyojunEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                        }
                        else
                        {
                            this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaHyojunEntity.PREFIX_KEY.RLength), DataRowVersion.Original);
                        }
                    }
                    else
                    {
                        // ƒL[€–ÚˆÈŠO‚Í•ÒW“à—eŽæ“¾
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaHyojunEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString( _
                // m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass) + "z")

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 41402


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 41498


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 41766


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 41849


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
        // * ˆø”           csDataRow As DataRow @@: XV‘ÎÛ‚Ìs
        // *                strAtenaDataKB As String : ˆ¶–¼ƒf[ƒ^‹æ•ª
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void CreateUpdateSQL(DataRow csDataRow, string strAtenaDataKB)
        {
            const string THIS_METHOD_NAME = "CreateUpdateSQL";
            const string strAtenaDataKbn_Hojin = "13";
            const string strAtenaDataKbn_Kyoyu = "14";
            UFParameterClass cfUFParameterClass;
            StringBuilder csWhere;                        // WHERE’è‹`
            StringBuilder csUpdateParam;                  // UPDATE—pSQL’è‹`

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // UPDATE SQL•¶‚Ìì¬
                m_strUpdateSQL = "UPDATE " + ABAtenaHyojunEntity.TABLE_NAME + " SET ";
                csUpdateParam = new StringBuilder();

                // WHERE•¶‚Ìì¬
                csWhere = new StringBuilder();
                csWhere.Append(" WHERE ");
                csWhere.Append(ABAtenaHyojunEntity.JUMINCD);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaHyojunEntity.KEY_JUMINCD);
                csWhere.Append(" AND ");
                csWhere.Append(ABAtenaHyojunEntity.JUMINJUTOGAIKB);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaHyojunEntity.KEY_JUMINJUTOGAIKB);

                // UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfUpdateUFParameterCollectionClass = new UFParameterCollectionClass();

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                {
                    // ˆÈ‰º‚Ì€–Ú‚¾‚¯XV‚·‚é
                    if (csDataColumn.ColumnName == ABAtenaHyojunEntity.JUMINJUTOGAIKB || csDataColumn.ColumnName == ABAtenaHyojunEntity.RRKNO || csDataColumn.ColumnName == ABAtenaHyojunEntity.UMAREBIFUSHOPTN || csDataColumn.ColumnName == ABAtenaHyojunEntity.FUSHOUMAREBI || csDataColumn.ColumnName == ABAtenaHyojunEntity.SHIKUCHOSONCD || csDataColumn.ColumnName == ABAtenaHyojunEntity.MACHIAZACD || csDataColumn.ColumnName == ABAtenaHyojunEntity.TODOFUKEN || csDataColumn.ColumnName == ABAtenaHyojunEntity.SHIKUCHOSON || csDataColumn.ColumnName == ABAtenaHyojunEntity.MACHIAZA || csDataColumn.ColumnName == ABAtenaHyojunEntity.SEARCHJUSHO || csDataColumn.ColumnName == ABAtenaHyojunEntity.SEARCHKATAGAKI || csDataColumn.ColumnName == ABAtenaHyojunEntity.BANCHIEDABANSUCHI || csDataColumn.ColumnName == ABAtenaHyojunEntity.SHOJOIDOBIFUSHOPTN || csDataColumn.ColumnName == ABAtenaHyojunEntity.FUSHOSHOJOIDOBI || csDataColumn.ColumnName == ABAtenaHyojunEntity.NYURYOKUBASHOCD || csDataColumn.ColumnName == ABAtenaHyojunEntity.NYURYOKUBASHO || csDataColumn.ColumnName == ABAtenaHyojunEntity.FUSHOUMAREBI_DATE || csDataColumn.ColumnName == ABAtenaHyojunEntity.FUSHOSHOJOIDOBI_DATE || csDataColumn.ColumnName == ABAtenaHyojunEntity.TANMATSUID || csDataColumn.ColumnName == ABAtenaHyojunEntity.SAKUJOFG || csDataColumn.ColumnName == ABAtenaHyojunEntity.KOSHINCOUNTER || csDataColumn.ColumnName == ABAtenaHyojunEntity.KOSHINNICHIJI || csDataColumn.ColumnName == ABAtenaHyojunEntity.KOSHINUSER)
                    {

                        // ˆÈ‰º‚ÌðŒ‚ÌŽž‚Íƒ‹[ƒv‚Ìæ“ª‚É–ß‚é
                        switch (csDataColumn.ColumnName ?? "")
                        {
                            case var @case when @case == ABAtenaHyojunEntity.RRKNO:
                                {
                                    // —š—ð”Ô†
                                    if (m_cfControlData.m_strMenuId == ABMenuIdCNST.MENU_ATENATOKUSHU_UPDATE)
                                    {
                                        // ƒƒjƒ…[IDuAB09092v(“ÁŽêC³)‚Ìê‡‚ÍXV‚µ‚È‚¢
                                        continue;
                                    }

                                    break;
                                }
                            case var case1 when case1 == ABAtenaHyojunEntity.UMAREBIFUSHOPTN:
                            case var case2 when case2 == ABAtenaHyojunEntity.FUSHOUMAREBI:
                                {
                                    // ¶”NŒŽ“ú•sÚƒpƒ^[ƒ“,•sÚ¶”NŒŽ“ú
                                    if (ReferenceEquals(strAtenaDataKB, strAtenaDataKbn_Hojin) || ReferenceEquals(strAtenaDataKB, strAtenaDataKbn_Kyoyu))
                                    {
                                        // ÁœˆÙ“®“ú•sÚƒpƒ^[ƒ“
                                        continue;
                                    }

                                    break;
                                }
                        }

                        cfUFParameterClass = new UFParameterClass();

                        // UPDATE SQL•¶‚Ìì¬
                        csUpdateParam.Append(csDataColumn.ColumnName);
                        csUpdateParam.Append(" = ");
                        csUpdateParam.Append(ABAtenaHyojunEntity.PARAM_PLACEHOLDER);
                        csUpdateParam.Append(csDataColumn.ColumnName);
                        csUpdateParam.Append(",");

                        // UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                        cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
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
                cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.KEY_JUMINCD;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.KEY_JUMINJUTOGAIKB;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 49463


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 49559


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 49827


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 49910


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }
        #endregion

        #region ˆ¶–¼•tƒ}ƒXƒ^XV@[UpdateAtenaHyojunB]
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
        public int UpdateAtenaHyojunB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "UpdateAtenaHyojunB";                     // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
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
                csDataRow(ABAtenaHyojunEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                   // ’[––‚h‚c
                csDataRow(ABAtenaHyojunEntity.KOSHINCOUNTER) = Conversions.ToDecimal(csDataRow(ABAtenaHyojunEntity.KOSHINCOUNTER)) + 1m;       // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaHyojunEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                     // XVƒ†[ƒU[

                // XV“úŽž‚ÌÝ’è
                m_strUpdateDatetime = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME);
                this.SetUpdateDatetime(csDataRow(ABAtenaHyojunEntity.KOSHINNICHIJI));

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABAtenaHyojunEntity.PREFIX_KEY.RLength) == ABAtenaHyojunEntity.PREFIX_KEY)
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaHyojunEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }

                    // ƒL[€–ÚˆÈŠO‚Í•ÒW“à—eŽæ“¾
                    else
                    {
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaHyojunEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData,
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" +
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 54617


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 54713


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 54981


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 55064


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
                m_strUpdateSQL = "UPDATE " + ABAtenaHyojunEntity.TABLE_NAME + " SET ";
                csUpdateParam = new StringBuilder();

                // WHERE•¶‚Ìì¬
                csWhere = new StringBuilder();
                csWhere.Append(" WHERE ");
                csWhere.Append(ABAtenaHyojunEntity.JUMINCD);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaHyojunEntity.KEY_JUMINCD);
                csWhere.Append(" AND ");
                csWhere.Append(ABAtenaHyojunEntity.JUMINJUTOGAIKB);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaHyojunEntity.KEY_JUMINJUTOGAIKB);
                csWhere.Append(" AND ");
                csWhere.Append(ABAtenaHyojunEntity.KOSHINCOUNTER);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaHyojunEntity.KEY_KOSHINCOUNTER);

                // UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfUpdateUFParameterCollectionClass = new UFParameterCollectionClass();

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                {
                    // Z–¯‚b‚cEZ–¯Z“oŠO‹æ•ªEì¬“úŽžEì¬ƒ†[ƒU‚ÍXV‚µ‚È‚¢
                    if (!(csDataColumn.ColumnName == ABAtenaHyojunEntity.JUMINCD) && !(csDataColumn.ColumnName == ABAtenaHyojunEntity.JUMINJUTOGAIKB) && !(csDataColumn.ColumnName == ABAtenaHyojunEntity.SAKUSEIUSER) && !(csDataColumn.ColumnName == ABAtenaHyojunEntity.SAKUSEINICHIJI))
                    {

                        cfUFParameterClass = new UFParameterClass();

                        // UPDATE SQL•¶‚Ìì¬
                        csUpdateParam.Append(csDataColumn.ColumnName);
                        csUpdateParam.Append(" = ");
                        csUpdateParam.Append(ABAtenaHyojunEntity.PARAM_PLACEHOLDER);
                        csUpdateParam.Append(csDataColumn.ColumnName);
                        csUpdateParam.Append(",");

                        // UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                        cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
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
                cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.KEY_JUMINCD;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.KEY_JUMINJUTOGAIKB;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.KEY_KOSHINCOUNTER;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 60294


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 60390


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 60658


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 60741


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }

        #endregion

        #region ˆ¶–¼_•W€ƒ}ƒXƒ^íœ
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼_•W€ƒ}ƒXƒ^íœ
        // * 
        // * \•¶           Public Function DeleteAtenaHyojunB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼_•W€ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð˜_—íœ‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ˜_—íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int DeleteAtenaHyojunB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "DeleteAtenaHyojunB";  // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
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
                csDataRow(ABAtenaHyojunEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                   // ’[––‚h‚c
                csDataRow(ABAtenaHyojunEntity.SAKUJOFG) = SAKUJOFG_ON;                                                       // íœƒtƒ‰ƒO
                csDataRow(ABAtenaHyojunEntity.KOSHINCOUNTER) = Conversions.ToDecimal(csDataRow(ABAtenaHyojunEntity.KOSHINCOUNTER)) + 1m;       // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaHyojunEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                     // XVƒ†[ƒU[

                // XV“úŽž‚ÌÝ’è
                m_strUpdateDatetime = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME);
                this.SetUpdateDatetime(csDataRow(ABAtenaHyojunEntity.KOSHINNICHIJI));

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfDelRonriUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABAtenaHyojunEntity.PREFIX_KEY.RLength) == ABAtenaHyojunEntity.PREFIX_KEY)
                    {
                        this.m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaHyojunEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    // ƒL[€–ÚˆÈŠO‚Í•ÒW“à—e‚ðÝ’è
                    else
                    {
                        this.m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaHyojunEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString( _
                // m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass) + "z")
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 65670


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 65766


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 66034


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 66117


                Input:
                " + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                        Return intDelCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼_•W€ƒ}ƒXƒ^•¨—íœ
                    '* 
                    '* \•¶           Public Function DeleteAtenaHyojunB(ByVal csDataRow As DataRow, _
                    '*                                                   ByVal strSakujoKB As String) As Integer
                    '* 
                    '* ‹@”\@@    @ ˆ¶–¼_•W€ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð•¨—íœ‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow  : íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
                    '*                strSakujoKB As String : íœƒtƒ‰ƒO
                    '* 
                    '* –ß‚è’l         Integer : íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
                    '************************************************************************************************
                    Public Overloads Function DeleteAtenaHyojunB(ByVal csDataRow As DataRow,
                                                                 ByVal strSakujoKB As String) As Integer

                        Const THIS_METHOD_NAME As String = "DeleteAtenaHyojunB"
                        Dim cfErrorStruct As UFErrorStruct 'ƒGƒ‰[’è‹`\‘¢‘Ì
                        Dim cfParam As UFParameterClass     'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim intDelCnt As Integer            'íœŒ”

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' íœ‹æ•ª‚Ìƒ`ƒFƒbƒN‚ðs‚¤
                            If (Not (strSakujoKB = "D")) Then

                                m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                cfErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_DELETE_SAKUJOKB)
                                '—áŠO‚ð¶¬
                                Throw New UFAppException(cfErrorStruct.m_strErrorMessage, cfErrorStruct.m_strErrorCode)
                            Else
                                'ˆ—‚È‚µ
                            End If

                            ' íœ—p‚Ìƒpƒ‰ƒ[ƒ^•tDELETE•¶•¶Žš—ñ‚Æƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                            If ((m_strDelButuriSQL Is Nothing) OrElse (m_strDelButuriSQL = String.Empty) _
                                OrElse (IsNothing(m_cfDelButuriUFParameterCollectionClass))) Then
                                Call CreateDeleteButsuriSQL(csDataRow)
                            Else
                                'ˆ—‚È‚µ
                            End If

                            ' ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚Öíœs‚©‚ç’l‚ðÝ’è‚·‚éB
                            For Each cfParam In m_cfDelButuriUFParameterCollectionClass
                                ' ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                                If (cfParam.ParameterName.RSubstring(0, ABAtenaHyojunEntity.PREFIX_KEY.RLength) = ABAtenaHyojunEntity.PREFIX_KEY) Then
                                    m_cfDelButuriUFParameterCollectionClass(cfParam.ParameterName).Value _
                                            = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaHyojunEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString()

                                    'ƒL[€–ÚˆÈŠO‚ÌŽæ“¾‚È‚µ
                                Else
                                    'ˆ—‚È‚µ
                                End If
                            Next cfParam

                            '' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                            'm_cfLogClass.RdbWrite(m_cfControlData, _
                            '                            "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                            '                            "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                            '                            "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                            '                            "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strDelButuriSQL, m_cfDelButuriUFParameterCollectionClass) + "z")
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
                            csWhere.Append(ABAtenaHyojunEntity.JUMINCD)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaHyojunEntity.KEY_JUMINCD)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaHyojunEntity.JUMINJUTOGAIKB)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaHyojunEntity.KEY_JUMINJUTOGAIKB)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaHyojunEntity.KOSHINCOUNTER)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaHyojunEntity.KEY_KOSHINCOUNTER)

                            ' ˜_—DELETE SQL•¶‚Ìì¬
                            csDelRonriParam = New StringBuilder
                            csDelRonriParam.Append("UPDATE ")
                            csDelRonriParam.Append(ABAtenaHyojunEntity.TABLE_NAME)
                            csDelRonriParam.Append(" SET ")
                            csDelRonriParam.Append(ABAtenaHyojunEntity.TANMATSUID)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABAtenaHyojunEntity.PARAM_TANMATSUID)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABAtenaHyojunEntity.SAKUJOFG)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABAtenaHyojunEntity.PARAM_SAKUJOFG)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABAtenaHyojunEntity.KOSHINCOUNTER)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABAtenaHyojunEntity.PARAM_KOSHINCOUNTER)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABAtenaHyojunEntity.KOSHINNICHIJI)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABAtenaHyojunEntity.PARAM_KOSHINNICHIJI)
                            csDelRonriParam.Append(", ")
                            csDelRonriParam.Append(ABAtenaHyojunEntity.KOSHINUSER)
                            csDelRonriParam.Append(" = ")
                            csDelRonriParam.Append(ABAtenaHyojunEntity.PARAM_KOSHINUSER)
                            csDelRonriParam.Append(csWhere)
                            ' Where•¶‚Ì’Ç‰Á
                            m_strDelRonriSQL = csDelRonriParam.ToString

                            ' ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDelRonriUFParameterCollectionClass = New UFParameterCollectionClass

                            ' ˜_—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.PARAM_TANMATSUID
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.PARAM_SAKUJOFG
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.PARAM_KOSHINCOUNTER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.PARAM_KOSHINNICHIJI
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.PARAM_KOSHINUSER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.KEY_JUMINCD
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.KEY_JUMINJUTOGAIKB
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.KEY_KOSHINCOUNTER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
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
                        Dim cfUFParameterClass As UFParameterClass
                        Dim csWhere As StringBuilder                        'WHERE’è‹`

                        Try
                            ' ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' WHERE•¶‚Ìì¬
                            csWhere = New StringBuilder
                            csWhere.Append(" WHERE ")
                            csWhere.Append(ABAtenaHyojunEntity.JUMINCD)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaHyojunEntity.KEY_JUMINCD)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaHyojunEntity.JUMINJUTOGAIKB)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaHyojunEntity.KEY_JUMINJUTOGAIKB)
                            csWhere.Append(" AND ")
                            csWhere.Append(ABAtenaHyojunEntity.KOSHINCOUNTER)
                            csWhere.Append(" = ")
                            csWhere.Append(ABAtenaHyojunEntity.KEY_KOSHINCOUNTER)

                            ' •¨—DELETE SQL•¶‚Ìì¬
                            m_strDelButuriSQL = "DELETE FROM " + ABAtenaHyojunEntity.TABLE_NAME + csWhere.ToString

                            ' •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDelButuriUFParameterCollectionClass = New UFParameterCollectionClass

                            ' •¨—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.KEY_JUMINCD
                            m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.KEY_JUMINJUTOGAIKB
                            m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaHyojunEntity.KEY_KOSHINCOUNTER
                            m_cfDelButuriUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
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

                    End Sub
                #End Region

                #Region "XV“úŽžÝ’è"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     XV“úŽžÝ’è
                    '* 
                    '* \•¶           Private Sub SetUpdateDatetime(ByRef csDate As Object)
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
                            If ((IsDBNull(csDate)) OrElse (CType(csDate, String).Trim.Equals(String.Empty))) Then
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