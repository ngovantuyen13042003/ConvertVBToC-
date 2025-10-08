// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‚`‚aˆ¶–¼—ÝÏ_•W€ƒ}ƒXƒ^‚c‚`(ABAtenaRuiseki_HyojunBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2023/08/14 ‘è  —Y–î
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// *
// ************************************************************************************************
using System;
using System.Data;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Densan.Reams.AB.AB000BB
{

    // ************************************************************************************************
    // *
    // * ˆ¶–¼—ÝÏ_•W€ƒ}ƒXƒ^Žæ“¾Žž‚ÉŽg—p‚·‚éƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
    // *
    // ************************************************************************************************
    public class ABAtenaRuiseki_HyojunBClass
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
        private UFParameterCollectionClass m_cfSelectUFParameterCollectionClass;      // SELECT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;      // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateUFParameterCollectionClass;      // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDelRonriUFParameterCollectionClass;    // ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private DataSet m_csDataSchma;                                                // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
        private string m_strUpdateDatetime;                                           // XV“úŽž

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABAtenaRuiseki_HyojunBClass";         // ƒNƒ‰ƒX–¼
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
        public ABAtenaRuiseki_HyojunBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)
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
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—ÝÏ_•W€ƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetABAtenaRuisekiHyojunBClassBHoshu(ByVal strJuminCD As String, _
        // *                                                                    ByVal strRirekiNO As String, _
        // *                                                                    ByVal strShoriNichiji As String, _
        // *                                                                    ByVal strZengoKB As String) As DataSet
        // * 
        // * ‹@”\@@    @ ˆ¶–¼—ÝÏ_•W€ƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD         : Z–¯ƒR[ƒh 
        // *                strRirekiNO        : —š—ð”Ô†
        // *                strShoriNichiji    : ˆ—“úŽž
        // *                strZengoKB         : ‘OŒã‹æ•ª
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½ˆ¶–¼_•W€ƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetABAtenaRuisekiHyojunBClassBHoshu(string strJuminCD, string strRirekiNO, string strShoriNichiji, string strZengoKB)
        {

            const string THIS_METHOD_NAME = "GetABAtenaRuisekiHyojunBClassBHoshu";
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
                csSQL.AppendFormat(" FROM {0} ", ABAtenaRuisekiHyojunEntity.TABLE_NAME);
                // ÃÞ°À½·°Ï‚ÌŽæ“¾
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(csSQL.ToString(), ABAtenaRuisekiHyojunEntity.TABLE_NAME, false);
                }

                // WHERE‹å‚Ìì¬
                csSQL.Append(CreateWhere(strJuminCD, strRirekiNO, strShoriNichiji, strZengoKB));

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData,
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" +
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(
                // csSQL.ToString(), m_cfSelectUFParameterCollectionClass) + "z")

                // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                csAtenaEntity = m_csDataSchma.Clone();
                csAtenaEntity = m_cfRdbClass.GetDataSet(csSQL.ToString(), csAtenaEntity, ABAtenaRuisekiHyojunEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9656


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9752


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10020


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10103


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
                csSELECT.AppendFormat("SELECT {0}", ABAtenaRuisekiHyojunEntity.JUMINCD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUMINJUTOGAIKB);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.RIREKINO);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SHORINICHIJI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.ZENGOKB);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.EDANO);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SHIMEIKANAKAKUNINFG);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.UMAREBIFUSHOPTN);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.FUSHOUMAREBI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JIJITSUSTAINUSMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.MACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SHIKUCHOSON);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.MACHIAZA);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SEARCHJUSHO);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.KANAKATAGAKI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SEARCHKATAGAKI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.BANCHIEDABANSUCHI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUSHO_KUNIMEICODE);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUSHO_KUNIMEITO);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUSHO_KOKUGAIJUSHO);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.HON_SHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.HON_MACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.HON_TODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.HON_SHIKUGUNCHOSON);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.HON_MACHIAZA);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.CKINIDOWMD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.CKINIDOBIFUSHOPTN);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.FUSHOCKINIDOBI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TOROKUIDOBIFUSHOPTN);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.FUSHOTOROKUIDOBI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.HYOJUNKISAIJIYUCD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.KISAIYMD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.KISAIBIFUSHOPTN);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.FUSHOKISAIBI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUTEIIDOBIFUSHOPTN);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.FUSHOJUTEIIDOBI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.HYOJUNSHOJOJIYUCD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.KOKUSEKISOSHITSUBI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SHOJOIDOWMD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SHOJOIDOBIFUSHOPTN);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.FUSHOSHOJOIDOBI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENUMAEJ_SHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENUMAEJ_MACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENUMAEJ_TODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENUMAEJ_SHIKUCHOSON);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENUMAEJ_MACHIAZA);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENUMAEJ_KOKUSEKICD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENUMAEJ_KOKUSEKI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENUMAEJ_KOKUGAIJUSHO);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SAISHUTJ_YUBINNO);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SAISHUTJ_SHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SAISHUTJ_MACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SAISHUTJ_TODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SAISHUTJ_SHIKUCHOSON);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SAISHUTJ_MACHIAZA);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SAISHUTJ_BANCHI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SAISHUTJ_KATAGAKI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SAISHUJ_TODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SAISHUJ_SHIKUCHOSON);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SAISHUJ_MACHIAZA);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SAISHUJ_BANCHI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SAISHUJ_KATAGAKI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENSHUTSUYOTEISHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENSHUTSUYOTEIMACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENSHUTSUYOTEITODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENSHUTSUYOTEISHIKUCHOSON);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENSHUTSUYOTEIMACHIAZA);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENSHUTSUYOTEIKOKUSEKICD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENSHUTSUYOTEIKOKUSEKI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENSHUTSUYOTEIKOKUGAIJUSHO);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENSHUTSUKKTISHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENSHUTSUKKTIMACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENSHUTSUKKTITODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENSHUTSUKKTISHIKUCHOSON);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TENSHUTSUKKTIMACHIAZA);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.KAISEIBIFUSHOPTN);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.FUSHOKAISEIBI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.KAISEISHOJOYMD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.KAISEISHOJOBIFUSHOPTN);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.FUSHOKAISEISHOJOBI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.CHIKUCD4);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.CHIKUCD5);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.CHIKUCD6);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.CHIKUCD7);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.CHIKUCD8);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.CHIKUCD9);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.CHIKUCD10);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TOKUBETSUYOSHIKB);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.IDOKB);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.NYURYOKUBASHOCD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.NYURYOKUBASHO);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SEARCHKANJIKYUUJI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SEARCHKANAKYUUJI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.KYUUJIKANAKAKUNINFG);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TDKDSHIMEI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.HYOJUNIDOJIYUCD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.NICHIJOSEIKATSUKENIKICD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.KOBOJONOJUSHO_SHOZAICHI_YOMIGANA);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TOROKUBUSHO);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TANKITAIZAISHAFG);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.KYOYUNINZU);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SHIZEIJIMUSHOCD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SHUKKOKUKIKAN_ST);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SHUKKOKUKIKAN_ED);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.IDOSHURUI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SHOKANKUCD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TOGOATENAFG);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.FUSHOUMAREBI_DATE);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.FUSHOCKINIDOBI_DATE);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.FUSHOSHOJOIDOBI_DATE);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUKISHIKUCHOSONCD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUKIMACHIAZACD);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUKITODOFUKEN);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUKISHIKUCHOSON);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUKIMACHIAZA);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUKIKANAKATAGAKI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUKICHIKUCD4);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUKICHIKUCD5);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUKICHIKUCD6);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUKICHIKUCD7);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUKICHIKUCD8);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUKICHIKUCD9);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUKICHIKUCD10);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.JUKIBANCHIEDABANSUCHI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.RESERVE1);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.RESERVE2);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.RESERVE3);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.RESERVE4);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.RESERVE5);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.TANMATSUID);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SAKUJOFG);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.KOSHINCOUNTER);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SAKUSEINICHIJI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.SAKUSEIUSER);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.KOSHINNICHIJI);
                csSELECT.AppendFormat(", {0}", ABAtenaRuisekiHyojunEntity.KOSHINUSER);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 23812


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 23908


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 24176


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 24259


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
        // *                                             ByVal strRirekiNO As String, _
        // *                                             ByVal strShoriNichiji As String, _
        // *                                             ByVal strZengoKB As String) As String
        // * 
        // * ‹@”\@@    @ WHERE•ª‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”           strJuminCD         : Z–¯ƒR[ƒh 
        // *                strRirekiNO        : —š—ð”Ô†
        // *                strShoriNichiji    : ˆ—“úŽž
        // *                strZengoKB         : ‘OŒã‹æ•ª
        // *
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private string CreateWhere(string strJuminCD, string strRirekiNO, string strShoriNichiji, string strZengoKB)
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
                csWHERE.AppendFormat("WHERE {0} = {1}", ABAtenaRuisekiHyojunEntity.JUMINCD, ABAtenaRuisekiHyojunEntity.KEY_JUMINCD);
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaRuisekiHyojunEntity.KEY_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);

                // —š—ð”Ô†
                if (!strRirekiNO.Trim().Equals(string.Empty))
                {
                    csWHERE.AppendFormat(" AND {0} = {1}", ABAtenaRuisekiHyojunEntity.RIREKINO, ABAtenaRuisekiHyojunEntity.KEY_RIREKINO);
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABAtenaRuisekiHyojunEntity.KEY_RIREKINO;
                    cfUFParameterClass.Value = strRirekiNO;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // ˆ—“úŽž
                if (!strShoriNichiji.Trim().Equals(string.Empty))
                {
                    csWHERE.AppendFormat(" AND {0} = {1}", ABAtenaRuisekiHyojunEntity.SHORINICHIJI, ABAtenaRuisekiHyojunEntity.KEY_SHORINICHIJI);
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABAtenaRuisekiHyojunEntity.KEY_SHORINICHIJI;
                    cfUFParameterClass.Value = strShoriNichiji;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // ‘OŒã‹æ•ª
                if (!strZengoKB.Trim().Equals(string.Empty))
                {
                    csWHERE.AppendFormat(" AND {0} = {1}", ABAtenaRuisekiHyojunEntity.ZENGOKB, ABAtenaRuisekiHyojunEntity.KEY_ZENGOKB);
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABAtenaRuisekiHyojunEntity.KEY_ZENGOKB;
                    cfUFParameterClass.Value = strZengoKB;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 29589


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 29685


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 29953


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 30036


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csWHERE.ToString();

        }

        #region ˆ¶–¼—ÝÏ_•W€ƒ}ƒXƒ^’Ç‰Á
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—ÝÏ_•W€ƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertAtenaRuisekiHyojunB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼—ÝÏ_•W€ƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertAtenaRuisekiHyojunB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "InsertAtenaRuisekiHyojunB";
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
                csDataRow(ABAtenaRuisekiHyojunEntity.TANMATSUID) = m_cfControlData.m_strClientId;     // ’[––‚h‚c
                csDataRow(ABAtenaRuisekiHyojunEntity.SAKUJOFG) = SAKUJOFG_OFF;                        // íœƒtƒ‰ƒO
                csDataRow(ABAtenaRuisekiHyojunEntity.KOSHINCOUNTER) = KOSHINCOUNTER_DEF;              // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaRuisekiHyojunEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;      // ì¬ƒ†[ƒU[
                csDataRow(ABAtenaRuisekiHyojunEntity.KOSHINUSER) = m_cfControlData.m_strUserId;       // XVƒ†[ƒU[

                // ì¬“úŽžAXV“úŽž‚ÌÝ’è
                var argcsDate = csDataRow(ABAtenaRuisekiHyojunEntity.SAKUSEINICHIJI);
                this.SetUpdateDatetime(ref argcsDate);
                var argcsDate1 = csDataRow(ABAtenaRuisekiHyojunEntity.KOSHINNICHIJI);
                this.SetUpdateDatetime(ref argcsDate1);

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    cfParam.Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaRuisekiHyojunEntity.PARAM_PLACEHOLDER.RLength)).ToString();

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData,
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" +
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 34468


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 34564


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 34832


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 34915


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
                    strParamName = string.Format("{0}{1}", ABAtenaRuisekiHyojunEntity.PARAM_PLACEHOLDER, csDataColumn.ColumnName);

                    // INSERT SQL•¶‚Ìì¬
                    csInsertColumn.AppendFormat("{0},", csDataColumn.ColumnName);
                    csInsertParam.AppendFormat("{0},", strParamName);

                    // INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    cfUFParameterClass.ParameterName = strParamName;
                    m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass);

                }

                // ÅŒã‚ÌƒJƒ“ƒ}‚ðŽæ‚èœ‚¢‚ÄINSERT•¶‚ðì¬
                m_strInsertSQL = string.Format("INSERT INTO {0}({1}) VALUES ({2})", ABAtenaRuisekiHyojunEntity.TABLE_NAME, csInsertColumn.ToString().TrimEnd(",".ToCharArray()), csInsertParam.ToString().TrimEnd(",".ToCharArray()));

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 38396


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 38492


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 38760


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 38843


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }
        #endregion

        #region ˆ¶–¼—ÝÏ_•W€ƒ}ƒXƒ^XV
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—ÝÏ_•W€ƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateAtenaRuisekiHyojunB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼—ÝÏ_•W€ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : XV‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int UpdateAtenaRuisekiHyojunB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "UpdateAtenaRuisekiHyojunB";                     // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
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
                csDataRow(ABAtenaRuisekiHyojunEntity.TANMATSUID) = m_cfControlData.m_strClientId;   // ’[––‚h‚c
                csDataRow(ABAtenaRuisekiHyojunEntity.KOSHINCOUNTER) = Conversions.ToDecimal(csDataRow(ABAtenaRuisekiHyojunEntity.KOSHINCOUNTER)) + 1m;                  // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaRuisekiHyojunEntity.KOSHINUSER) = m_cfControlData.m_strUserId;     // XVƒ†[ƒU[

                // XV“úŽž‚ÌÝ’è
                m_strUpdateDatetime = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME);
                var argcsDate = csDataRow(ABAtenaRuisekiHyojunEntity.KOSHINNICHIJI);
                this.SetUpdateDatetime(ref argcsDate);

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABAtenaRuisekiHyojunEntity.PREFIX_KEY.RLength) == ABAtenaRuisekiHyojunEntity.PREFIX_KEY)
                    {

                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaRuisekiHyojunEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }

                    // ƒL[€–ÚˆÈŠO‚Í•ÒW“à—eŽæ“¾
                    else
                    {
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaRuisekiHyojunEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData,
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" +
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 43730


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 43826


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 44094


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 44177


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
                m_strUpdateSQL = "UPDATE " + ABAtenaRuisekiHyojunEntity.TABLE_NAME + " SET ";
                csUpdateParam = new StringBuilder();

                // WHERE•¶‚Ìì¬
                csWhere = new StringBuilder();
                csWhere.Append(" WHERE ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.JUMINCD);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.KEY_JUMINCD);
                csWhere.Append(" AND ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.RIREKINO);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.KEY_RIREKINO);
                csWhere.Append(" AND ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.SHORINICHIJI);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.KEY_SHORINICHIJI);
                csWhere.Append(" AND ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.ZENGOKB);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.KEY_ZENGOKB);
                csWhere.Append(" AND ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.KOSHINCOUNTER);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.KEY_KOSHINCOUNTER);

                // UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfUpdateUFParameterCollectionClass = new UFParameterCollectionClass();

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                {
                    // Z–¯‚b‚cE—š—ð”Ô†Eˆ—“úŽžE‘OŒã‹æ•ªEì¬“úŽžEì¬ƒ†[ƒU‚ÍXV‚µ‚È‚¢
                    if (!(csDataColumn.ColumnName == ABAtenaRuisekiHyojunEntity.JUMINCD) && !(csDataColumn.ColumnName == ABAtenaRuisekiHyojunEntity.RIREKINO) && !(csDataColumn.ColumnName == ABAtenaRuisekiHyojunEntity.SHORINICHIJI) && !(csDataColumn.ColumnName == ABAtenaRuisekiHyojunEntity.ZENGOKB) && !(csDataColumn.ColumnName == ABAtenaRuisekiHyojunEntity.SAKUSEIUSER) && !(csDataColumn.ColumnName == ABAtenaRuisekiHyojunEntity.SAKUSEINICHIJI))
                    {

                        cfUFParameterClass = new UFParameterClass();

                        // UPDATE SQL•¶‚Ìì¬
                        csUpdateParam.Append(csDataColumn.ColumnName);
                        csUpdateParam.Append(" = ");
                        csUpdateParam.Append(ABAtenaRuisekiHyojunEntity.PARAM_PLACEHOLDER);
                        csUpdateParam.Append(csDataColumn.ColumnName);
                        csUpdateParam.Append(",");

                        // UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                        cfUFParameterClass.ParameterName = ABAtenaRuisekiHyojunEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
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
                cfUFParameterClass.ParameterName = ABAtenaRuisekiHyojunEntity.KEY_JUMINCD;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaRuisekiHyojunEntity.KEY_JUMINJUTOGAIKB;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaRuisekiHyojunEntity.KEY_KOSHINCOUNTER;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 50148


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 50244


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 50512


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 50595


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }
        #endregion

        #region ˆ¶–¼—ÝÏ_•W€ƒ}ƒXƒ^íœ
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—ÝÏ_•W€ƒ}ƒXƒ^íœ
        // * 
        // * \•¶           Public Function DeleteAtenaRuisekiHyojunB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼—ÝÏ_•W€ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð˜_—íœ‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ˜_—íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int DeleteAtenaRuisekiHyojunB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "DeleteAtenaRuisekiHyojunB";  // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
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
                csDataRow(ABAtenaRuisekiHyojunEntity.TANMATSUID) = m_cfControlData.m_strClientId;      // ’[––‚h‚c
                csDataRow(ABAtenaRuisekiHyojunEntity.SAKUJOFG) = SAKUJOFG_ON;                          // íœƒtƒ‰ƒO
                csDataRow(ABAtenaRuisekiHyojunEntity.KOSHINCOUNTER) = Conversions.ToDecimal(csDataRow(ABAtenaRuisekiHyojunEntity.KOSHINCOUNTER)) + 1m;                     // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaRuisekiHyojunEntity.KOSHINUSER) = m_cfControlData.m_strUserId;        // XVƒ†[ƒU[

                // XV“úŽž‚ÌÝ’è
                m_strUpdateDatetime = m_cfRdbClass.GetSystemDate().ToString(FORMAT_UPDATETIME);
                var argcsDate = csDataRow(ABAtenaRuisekiHyojunEntity.KOSHINNICHIJI);
                this.SetUpdateDatetime(ref argcsDate);

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfDelRonriUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABAtenaRuisekiHyojunEntity.PREFIX_KEY.RLength) == ABAtenaRuisekiHyojunEntity.PREFIX_KEY)
                    {

                        this.m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaRuisekiHyojunEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    // ƒL[€–ÚˆÈŠO‚Í•ÒW“à—e‚ðÝ’è
                    else
                    {
                        this.m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaRuisekiHyojunEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData,
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" +
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 55608


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 55704


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 55972


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 56055


                                Input:
                                " + THIS_METHOD_NAME + "z" +
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
                csWhere.Append(ABAtenaRuisekiHyojunEntity.JUMINCD);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.KEY_JUMINCD);
                csWhere.Append(" AND ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.RIREKINO);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.KEY_RIREKINO);
                csWhere.Append(" AND ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.SHORINICHIJI);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.KEY_SHORINICHIJI);
                csWhere.Append(" AND ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.ZENGOKB);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.KEY_ZENGOKB);
                csWhere.Append(" AND ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.KOSHINCOUNTER);
                csWhere.Append(" = ");
                csWhere.Append(ABAtenaRuisekiHyojunEntity.KEY_KOSHINCOUNTER);

                // ˜_—DELETE SQL•¶‚Ìì¬
                csDelRonriParam = new StringBuilder();
                csDelRonriParam.Append("UPDATE ");
                csDelRonriParam.Append(ABAtenaRuisekiHyojunEntity.TABLE_NAME);
                csDelRonriParam.Append(" SET ");
                csDelRonriParam.Append(ABAtenaRuisekiHyojunEntity.TANMATSUID);
                csDelRonriParam.Append(" = ");
                csDelRonriParam.Append(ABAtenaRuisekiHyojunEntity.PARAM_TANMATSUID);
                csDelRonriParam.Append(", ");
                csDelRonriParam.Append(ABAtenaRuisekiHyojunEntity.SAKUJOFG);
                csDelRonriParam.Append(" = ");
                csDelRonriParam.Append(ABAtenaRuisekiHyojunEntity.PARAM_SAKUJOFG);
                csDelRonriParam.Append(", ");
                csDelRonriParam.Append(ABAtenaRuisekiHyojunEntity.KOSHINCOUNTER);
                csDelRonriParam.Append(" = ");
                csDelRonriParam.Append(ABAtenaRuisekiHyojunEntity.PARAM_KOSHINCOUNTER);
                csDelRonriParam.Append(", ");
                csDelRonriParam.Append(ABAtenaRuisekiHyojunEntity.KOSHINNICHIJI);
                csDelRonriParam.Append(" = ");
                csDelRonriParam.Append(ABAtenaRuisekiHyojunEntity.PARAM_KOSHINNICHIJI);
                csDelRonriParam.Append(", ");
                csDelRonriParam.Append(ABAtenaRuisekiHyojunEntity.KOSHINUSER);
                csDelRonriParam.Append(" = ");
                csDelRonriParam.Append(ABAtenaRuisekiHyojunEntity.PARAM_KOSHINUSER);
                csDelRonriParam.Append(csWhere);
                // Where•¶‚Ì’Ç‰Á
                m_strDelRonriSQL = csDelRonriParam.ToString();

                // ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfDelRonriUFParameterCollectionClass = new UFParameterCollectionClass();

                // ˜_—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaRuisekiHyojunEntity.PARAM_TANMATSUID;
                m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaRuisekiHyojunEntity.PARAM_SAKUJOFG;
                m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaRuisekiHyojunEntity.PARAM_KOSHINCOUNTER;
                m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaRuisekiHyojunEntity.PARAM_KOSHINNICHIJI;
                m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaRuisekiHyojunEntity.PARAM_KOSHINUSER;
                m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaRuisekiHyojunEntity.KEY_JUMINCD;
                m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaRuisekiHyojunEntity.KEY_JUMINJUTOGAIKB;
                m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaRuisekiHyojunEntity.KEY_KOSHINCOUNTER;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 62699


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 62795


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 63063


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 63146


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }
        #endregion

        #region XV“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     XV“úŽžÝ’è
        // * 
        // * \•¶           Private Sub SetUpdateDatetime(ByRef csDate As Object)
        // * 
        // * ‹@”\           –¢Ý’è‚Ì‚Æ‚«XV“úŽž‚ðÝ’è‚·‚é
        // * 
        // * ˆø”           csDate As Object : XV“úŽž‚Ì€–Ú
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void SetUpdateDatetime(ref object csDate)
        {
            try
            {
                // –¢Ý’è‚Ì‚Æ‚«
                if (csDate is DBNull || Conversions.ToString(csDate).Trim().Equals(string.Empty))
                {
                    csDate = m_strUpdateDatetime;
                }
                else
                {
                    // ˆ—‚È‚µ
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #endregion

    }
}