// ************************************************************************************************
// * ‹Æ–±–¼           ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼         •W€‰»@ˆ¶–¼ŠÇ—@•sŒ»ZŠÇ—‹@”\
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯           2024/01/15
// *
// * ì¬ŽÒ@@@     ŽÂŒ´
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2024/01/15           yAB-0830-1z•sŒ»ZŠÇ—‹@”\’Ç‰Á(ŽÂŒ´)
// * 2024/03/07  000001   yAB-0900-1zƒAƒhƒŒƒXEƒx[ƒXEƒŒƒWƒXƒgƒŠ‘Î‰ž(‰º‘º)
// ************************************************************************************************
using System;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;

namespace Densan.Reams.AB.AB000BB
{

    public class ABFugenjuJohoBClass
    {

        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private DataSet m_csDataSchma;                        // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg:‘S€–Ú—p

        private string m_strInsertSQL;
        private string m_strUpDateSQL;
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;  // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateUFParameterCollectionClass;  // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABFugenjuJohoBClass";

        // ’è”
        private const int MAX_ROWS = 100;                       // Å‘åŽæ“¾Œ”
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
        public ABFugenjuJohoBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigDataClass;
            m_cfRdbClass = cfRdbClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(m_cfConfigDataClass, m_cfControlData.m_strBusinessId);

            // SQL•¶‚Ìì¬
            // ‘S€–Ú’Šo—pƒXƒL[ƒ}
            m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction("SELECT * FROM " + ABFugenjuJohoEntity.TABLE_NAME, ABFugenjuJohoEntity.TABLE_NAME, false);
        }
        #endregion

        #region ƒƒ\ƒbƒh

        #region •sŒ»Zî•ñƒf[ƒ^Žæ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼   •sŒ»Zî•ñƒf[ƒ^Žæ“¾ƒƒ\ƒbƒh
        // * 
        // * \•¶         Public Function GetFugenjuJohoData(ByVal csABFugenjuJohoParaX As ABFugenjuJohoParaXClass) As DataSet
        // * 
        // * ‹@”\         •sŒ»Zî•ñ‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”         csABFugenjuJohoParaX As ABFugenjuJohoParaXClass   : •sŒ»Zî•ñƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
        // * 
        // * –ß‚è’l       Žæ“¾‚µ‚½•sŒ»Zî•ñ‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                 \‘¢FcsFugenjuJohoEntity    
        // ************************************************************************************************
        public DataSet GetFugenjuJohoData(ABFugenjuJohoParaXClass csABFugenjuJohoParaX)
        {
            const string THIS_METHOD_NAME = "GetFugenjuJohoData";
            DataSet csFugenjuJohoEntity;                              // •sŒ»Zî•ñƒf[ƒ^
            var strSQL = new StringBuilder();                                 // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
            ABKensakuShimeiBClass cABKensakuShimeiB;                  // ŒŸõŽ–¼•ÒWBƒNƒ‰ƒX
            int intAimaiKanji = 0;                                // ”¼Šp“‚ªŠÜ‚Ü‚ê‚é”(Š¿Žšj
            int intAimaiKana = 0;                                 // ”¼Šp“‚ªŠÜ‚Ü‚ê‚é”(ƒJƒij
            string strJushoCD = string.Empty;                         // ZŠƒR[ƒh
            string strJusho = string.Empty;                           // ZŠ
            string strBanchi = string.Empty;                          // ”Ô’n
            string strKatagaki = string.Empty;                        // •û‘
            string strShimei = string.Empty;                          // Ž–¼
            const string CHAR_PERCENT = "%";                              // %
            var cRuijiClass = new USRuijiClass();                             // —ÞŽ—•¶ŽšƒNƒ‰ƒX
            string strRuijiJusho;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // SQL•¶‚Ìì¬
                // SELECT‹å
                strSQL.Append(CreateSelect());
                strSQL.Append(" FROM ").Append(ABFugenjuJohoEntity.TABLE_NAME);

                // WHERE‹å
                strSQL.Append(" WHERE ");

                // •K{ŒŸõðŒ
                // íœƒf[ƒ^‚Í’Šo‚µ‚È‚¢‚æ‚¤‚ÉˆÈ‰º‚ÌðŒ‚ð’Ç‰Á‚·‚éB
                strSQL.Append(ABFugenjuJohoEntity.SAKUJOFG).Append(" <> '1'");

                // Ž–¼
                if (csABFugenjuJohoParaX.p_strShimei.Trim.RLength > 0)
                {
                    // AB000BB.ABKensakuShimeiBClass‚ÌGetKensakuShimeiƒƒ\ƒbƒh‚ð—˜—p‚µAŒŸõ—pŽ–¼‚ð•ÒW‚·‚éB
                    // ¦Š¿Žš‚Ìê‡‚Í—ÞŽš‰»AƒJƒi‚Ìê‡‚Í”¼Šp´‰¹‰»AƒAƒ‹ƒtƒ@ƒxƒbƒg‚Ìê‡‚Í‘å•¶Žš‰»‚ðs‚¢Aˆø”‚Ì‘O•ûˆê’v‚Ì’l‚É‰ž‚¶‚Ä•¶Žš—ñ‚Ì‘OŒã‚É”¼Šp“‚Ì•t—^‚ðs‚¤B

                    strShimei = csABFugenjuJohoParaX.p_strShimei.Replace("–", string.Empty).Replace("*", string.Empty).Replace("@", string.Empty).Replace(" ", string.Empty);
                    // ƒCƒ“ƒXƒ^ƒ“ƒXì¬
                    cABKensakuShimeiB = new ABKensakuShimeiBClass(m_cfControlData, m_cfConfigDataClass);
                    cABKensakuShimeiB.GetKensakuShimei(csABFugenjuJohoParaX.p_strShimeiZenpoIcchi, strShimei);
                    intAimaiKanji = Strings.InStr(cABKensakuShimeiB.p_strSearchkanjimei, CHAR_PERCENT);
                    intAimaiKana = Strings.InStr(cABKensakuShimeiB.p_strSearchKanaseimei, CHAR_PERCENT);

                    if (cABKensakuShimeiB.p_strSearchkanjimei.Trim().RLength > 0)
                    {
                        // ŒŸõ—pŽ–¼ƒNƒ‰ƒX.ŒŸõ—pŠ¿Žš–¼Ì‚‹ó”’‚Ìê‡
                        if (intAimaiKanji > 0)
                        {
                            // ŒŸõ—pŽ–¼ƒNƒ‰ƒX.ŒŸõ—pŠ¿Žš–¼Ì‚É”¼Šp“‚ªŠÜ‚Ü‚ê‚Ä‚¢‚éê‡
                            // AB•sŒ»Zî•ñ.•sŒ»Zî•ñiŒŸõ—pŠ¿ŽšŽ–¼j@LIKE@'ŒŸõ—pŽ–¼ƒNƒ‰ƒX.ŒŸõ—pŠ¿Žš–¼Ì'
                            strSQL.Append(" AND ");
                            strSQL.Append(ABFugenjuJohoEntity.FUGENJUJOHO_SEARCHKANJISHIMEI);
                            strSQL.Append(" LIKE ");
                            strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUJOHO_SEARCHKANJISHIMEI);
                        }
                        else
                        {
                            // AB•sŒ»Zî•ñ.•sŒ»Zî•ñiŒŸõ—pŠ¿ŽšŽ–¼j@@'ŒŸõ—pŽ–¼ƒNƒ‰ƒX.ŒŸõ—pŠ¿Žš–¼Ì'
                            strSQL.Append(" AND ");
                            strSQL.Append(ABFugenjuJohoEntity.FUGENJUJOHO_SEARCHKANJISHIMEI);
                            strSQL.Append(" = ");
                            strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUJOHO_SEARCHKANJISHIMEI);
                        }

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                        cfUFParameterClass = new UFParameterClass();
                        cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PARAM_FUGENJUJOHO_SEARCHKANJISHIMEI;
                        cfUFParameterClass.Value = cABKensakuShimeiB.p_strSearchkanjimei;
                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfUFParameterCollectionClass.Add(cfUFParameterClass);
                    }

                    else if (cABKensakuShimeiB.p_strSearchKanaseimei.Trim().RLength > 0)
                    {
                        // ŒŸõ—pŽ–¼ƒNƒ‰ƒX.ŒŸõ—pƒJƒi©–¼‚‹ó”’‚Ìê‡
                        if (intAimaiKana > 0)
                        {
                            // ŒŸõ—pŽ–¼ƒNƒ‰ƒX.ŒŸõ—pƒJƒi©–¼‚É”¼Šp“‚ªŠÜ‚Ü‚ê‚Ä‚¢‚éê‡
                            // AB•sŒ»Zî•ñ.•sŒ»Zî•ñiŒŸõ—pƒJƒiŽ–¼j@LIKE@'ŒŸõ—pŽ–¼ƒNƒ‰ƒX.ŒŸõ—pƒJƒi©–¼'
                            strSQL.Append(" AND ");
                            strSQL.Append(ABFugenjuJohoEntity.FUGENJUJOHO_SEARCHKANASHIMEI);
                            strSQL.Append(" LIKE ");
                            strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUJOHO_SEARCHKANASHIMEI);
                        }
                        else
                        {
                            // AB•sŒ»Zî•ñ.•sŒ»Zî•ñiŒŸõ—pƒJƒiŽ–¼j@@'ŒŸõ—pŽ–¼ƒNƒ‰ƒX.ŒŸõ—pƒJƒi©–¼'
                            strSQL.Append(" AND ");
                            strSQL.Append(ABFugenjuJohoEntity.FUGENJUJOHO_SEARCHKANASHIMEI);
                            strSQL.Append(" = ");
                            strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUJOHO_SEARCHKANASHIMEI);
                        }

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                        cfUFParameterClass = new UFParameterClass();
                        cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PARAM_FUGENJUJOHO_SEARCHKANASHIMEI;
                        cfUFParameterClass.Value = cABKensakuShimeiB.p_strSearchKanaseimei;
                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    }
                }

                // ¶”NŒŽ“ú
                if (csABFugenjuJohoParaX.p_strUmareymd.Trim.RLength > 0)
                {
                    // AB•sŒ»Zî•ñ.•sŒ»Zî•ñi¶”NŒŽ“új@@'AB•sŒ»Zî•ñ.¶”NŒŽ“ú'
                    strSQL.Append(" AND ");
                    strSQL.Append(ABFugenjuJohoEntity.FUGENJUJOHO_UMAREYMD);
                    strSQL.Append(" = ");
                    strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUJOHO_UMAREYMD);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PARAM_FUGENJUJOHO_UMAREYMD;
                    cfUFParameterClass.Value = csABFugenjuJohoParaX.p_strUmareymd.Trim.ToString;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                }

                // «•Ê
                if (csABFugenjuJohoParaX.p_strSeibetuCD.Trim.RLength > 0)
                {
                    // AB•sŒ»Zî•ñ.•sŒ»Zî•ñi«•Êj@@'AB•sŒ»Zî•ñ.«•Ê'
                    strSQL.Append(" AND ");
                    strSQL.Append(ABFugenjuJohoEntity.FUGENJUJOHO_SEIBETSU);
                    strSQL.Append(" = ");
                    strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUJOHO_SEIBETSU);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PARAM_FUGENJUJOHO_SEIBETSU;
                    cfUFParameterClass.Value = csABFugenjuJohoParaX.p_strSeibetuCD.Trim.ToString;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                }

                // ZŠƒR[ƒh
                if (csABFugenjuJohoParaX.p_strJushoSearchShitei.Trim.ToString == "1" || csABFugenjuJohoParaX.p_strJushoSearchShitei.Trim.ToString == "3")
                {
                    // •sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.ZŠŒŸõŽw’è1iZŠƒR[ƒh‚ÅŒŸõj or 3iZŠƒR[ƒh‚ÆZŠ‚ÅŒŸõj‚Ìê‡
                    if (csABFugenjuJohoParaX.p_strJushoCD.Trim.RLength > 0)
                    {
                        if (csABFugenjuJohoParaX.p_strKangaiJushoKB.Trim.ToString == "1")
                        {
                            // •sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.ŠÇŠOZŠ‹æ•ª1iŠÇŠOZŠj 
                            if (System.Text.RegularExpressions.Regex.IsMatch(csABFugenjuJohoParaX.p_strJushoCD.Trim.RSubstring(2), "0+?") && csABFugenjuJohoParaX.p_strJushoCD.Trim.RSubstring(2).Distinct().Count() == 1)
                            {
                                // •sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.Žs‹æ’¬‘ºƒR[ƒh‚Ìã2Œ…ˆÈ~‚ª‘S‚Ä"0"‚Ìê‡i“s“¹•{Œ§ƒR[ƒh‚ÅŒŸõj
                                // LTRIMiAB•sŒ»Zî•ñ.•sŒ»Z‚¾‚Á‚½ZŠ_ZŠƒR[ƒhj@LIKE@'•sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.ZŠƒR[ƒh‚Ìã2Œ… + ”¼Šp“'
                                strSQL.Append(" AND ");
                                strSQL.Append(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_JUSHOCD);
                                strSQL.Append(" LIKE ");
                                strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_JUSHOCD);
                                strJushoCD = csABFugenjuJohoParaX.p_strJushoCD.Trim.RSubstring(0, 2) + CHAR_PERCENT;
                            }
                            else if (System.Text.RegularExpressions.Regex.IsMatch(csABFugenjuJohoParaX.p_strJushoCD.Trim.RSubstring(5), "0+?") && csABFugenjuJohoParaX.p_strJushoCD.Trim.RSubstring(5).Distinct().Count() == 1)
                            {
                                // •sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.ZŠƒR[ƒh‚Ìã5Œ…ˆÈ~‚ª‘S‚Ä"0"‚Ìê‡iŽs‹æ’¬‘ºƒR[ƒh‚ÅŒŸõj
                                // LTRIMiAB•sŒ»Zî•ñ.•sŒ»Z‚¾‚Á‚½ZŠ_ZŠƒR[ƒhj@LIKE@'•sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.ZŠƒR[ƒh‚Ìã5Œ… + ”¼Šp“'
                                strSQL.Append(" AND ");
                                strSQL.Append(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_JUSHOCD);
                                strSQL.Append(" LIKE ");
                                strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_JUSHOCD);
                                strJushoCD = csABFugenjuJohoParaX.p_strJushoCD.Trim.RSubstring(0, 5) + CHAR_PERCENT;
                            }
                            else if (System.Text.RegularExpressions.Regex.IsMatch(csABFugenjuJohoParaX.p_strJushoCD.Trim.RSubstring(8), "0+?") && csABFugenjuJohoParaX.p_strJushoCD.Trim.RSubstring(8).Distinct().Count() == 1)
                            {
                                // •sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.ZŠƒR[ƒh‚Ìã8Œ…ˆÈ~‚ª‘S‚Ä"0"‚Ìê‡iŽs‹æ’¬‘ºƒR[ƒh‚ÅŒŸõj
                                // LTRIMiAB•sŒ»Zî•ñ.•sŒ»Z‚¾‚Á‚½ZŠ_ZŠƒR[ƒhj@LIKE@'•sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.ZŠƒR[ƒh‚Ìã8Œ… + ”¼Šp“'
                                strSQL.Append(" AND ");
                                strSQL.Append(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_JUSHOCD);
                                strSQL.Append(" LIKE ");
                                strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_JUSHOCD);
                                strJushoCD = csABFugenjuJohoParaX.p_strJushoCD.Trim.RSubstring(0, 8) + CHAR_PERCENT;
                            }
                            else
                            {
                                // i‘S‘ZŠƒR[ƒh‚ÅŒŸõj
                                // LTRIMiAB•sŒ»Zî•ñ.•sŒ»Z‚¾‚Á‚½ZŠ_Žs‹æ’¬‘ºƒR[ƒhj +@LTRIMiAB•sŒ»Zî•ñ.•sŒ»Z‚¾‚Á‚½ZŠ_’¬ŽšƒR[ƒhj @'•sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.ZŠƒR[ƒh'
                                strSQL.Append(" AND ");
                                strSQL.Append(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_JUSHOCD);
                                strSQL.Append(" = ");
                                strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_JUSHOCD);
                                strJushoCD = csABFugenjuJohoParaX.p_strJushoCD.RPadRight(13);
                            }
                        }
                        else
                        {
                            // LTRIMiAB•sŒ»Zî•ñ.•sŒ»Z‚¾‚Á‚½ZŠ_Žs‹æ’¬‘ºƒR[ƒhj +@LTRIMiAB•sŒ»Zî•ñ.•sŒ»Z‚¾‚Á‚½ZŠ_’¬ŽšƒR[ƒhj @'•sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.ZŠƒR[ƒh'
                            strSQL.Append(" AND ");
                            strSQL.Append(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_JUSHOCD);
                            strSQL.Append(" = ");
                            strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_JUSHOCD);
                            strJushoCD = csABFugenjuJohoParaX.p_strJushoCD.Trim.RPadLeft(13);
                        }

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                        cfUFParameterClass = new UFParameterClass();
                        cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_JUSHOCD;
                        cfUFParameterClass.Value = strJushoCD;
                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfUFParameterCollectionClass.Add(cfUFParameterClass);
                    }
                }

                // ZŠ
                if (csABFugenjuJohoParaX.p_strJushoSearchShitei.Trim.ToString == "2" || csABFugenjuJohoParaX.p_strJushoSearchShitei.Trim.ToString == "3")
                {
                    // •sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.ZŠŒŸõŽw’è2iZŠ‚ÅŒŸõj or 3iZŠƒR[ƒh‚ÆZŠ‚ÅŒŸõj‚Ìê‡
                    if (csABFugenjuJohoParaX.p_strJusho.Trim.RLength > 0)
                    {
                        strRuijiJusho = cRuijiClass.GetRuijiMojiList(csABFugenjuJohoParaX.p_strJusho.Replace("@", string.Empty)).ToUpper;
                        switch (csABFugenjuJohoParaX.p_strJushoZenpoIcchi.Trim.ToString)
                        {
                            case "1":
                                {
                                    // •sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.ZŠ‘O•ûˆê’v1i‘O•ûˆê’vj‚Ìê‡
                                    strSQL.Append(" AND ");
                                    strSQL.Append(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_SEARCHJUSHO);
                                    strSQL.Append(" LIKE ");
                                    strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_SEARCHJUSHO);
                                    strJusho = strRuijiJusho + CHAR_PERCENT;
                                    break;
                                }
                            case "2":
                                {
                                    // •sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.ZŠ‘O•ûˆê’v2i•”•ªˆê’vj‚Ìê‡
                                    strSQL.Append(" AND ");
                                    strSQL.Append(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_SEARCHJUSHO);
                                    strSQL.Append(" LIKE ");
                                    strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_SEARCHJUSHO);
                                    strJusho = CHAR_PERCENT + strRuijiJusho + CHAR_PERCENT;
                                    break;
                                }

                            default:
                                {
                                    // iŠ®‘Sˆê’vj
                                    strSQL.Append(" AND ");
                                    strSQL.Append(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_SEARCHJUSHO);
                                    strSQL.Append(" = ");
                                    strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_SEARCHJUSHO);
                                    strJusho = strRuijiJusho;
                                    break;
                                }
                        }

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                        cfUFParameterClass = new UFParameterClass();
                        cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_SEARCHJUSHO;
                        cfUFParameterClass.Value = strJusho;
                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfUFParameterCollectionClass.Add(cfUFParameterClass);
                    }
                }

                // ”Ô’n
                if (csABFugenjuJohoParaX.p_strBanchi.Trim.RLength > 0)
                {
                    switch (csABFugenjuJohoParaX.p_strBanchiZenpoIcchi.Trim.ToString)
                    {
                        case "1":
                            {
                                // •sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.”Ô’n‘O•ûˆê’v1i‘O•ûˆê’vj‚Ìê‡
                                // AB•sŒ»Zî•ñ.•sŒ»Z‚¾‚Á‚½ZŠ_”Ô’n†•\‹L@LIKE@f•sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.”Ô’n + ”¼Šp“f
                                strSQL.Append(" AND ");
                                strSQL.Append(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_BANCHI);
                                strSQL.Append(" LIKE ");
                                strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_BANCHI);
                                strBanchi = csABFugenjuJohoParaX.p_strBanchi.Trim.ToString + CHAR_PERCENT;
                                break;
                            }
                        case "2":
                            {
                                // Œ»ZŒŸõƒpƒ‰ƒ[ƒ^.”Ô’n‘O•ûˆê’v2i•”•ªˆê’vj‚Ìê‡
                                // AB•sŒ»Zî•ñ.•sŒ»Z‚¾‚Á‚½ZŠ_”Ô’n†•\‹L@LIKE@f”¼Šp“ + •sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.”Ô’n + ”¼Šp“f
                                strSQL.Append(" AND ");
                                strSQL.Append(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_BANCHI);
                                strSQL.Append(" LIKE ");
                                strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_BANCHI);
                                strBanchi = CHAR_PERCENT + csABFugenjuJohoParaX.p_strBanchi.Trim.ToString + CHAR_PERCENT;
                                break;
                            }

                        default:
                            {
                                // iŠ®‘Sˆê’vj
                                // AB•sŒ»Zî•ñ•sŒ»Z‚¾‚Á‚½ZŠ_”Ô’n†•\‹L@@f•sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.”Ô’nf
                                strSQL.Append(" AND ");
                                strSQL.Append(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_BANCHI);
                                strSQL.Append(" = ");
                                strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_BANCHI);
                                strBanchi = csABFugenjuJohoParaX.p_strBanchi.Trim.ToString;
                                break;
                            }
                    }

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_BANCHI;
                    cfUFParameterClass.Value = strBanchi;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                }

                // •û‘
                if (csABFugenjuJohoParaX.p_strKatagaki.Trim.RLength > 0)
                {
                    switch (csABFugenjuJohoParaX.p_strKatagakiZenpoIcchi.Trim.ToString)
                    {
                        case "1":
                            {
                                // •sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.•û‘‘O•ûˆê’v1i‘O•ûˆê’vj‚Ìê‡
                                // AB•sŒ»Zî•ñ.•sŒ»Z‚¾‚Á‚½ZŠ_•û‘@LIKE@f•sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.•û‘ + ”¼Šp“f
                                strSQL.Append(" AND ");
                                strSQL.Append(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_KATAGAKI);
                                strSQL.Append(" LIKE ");
                                strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_KATAGAKI);
                                strKatagaki = csABFugenjuJohoParaX.p_strKatagaki.Trim.ToString + CHAR_PERCENT;
                                break;
                            }
                        case "2":
                            {
                                // •sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.•û‘‘O•ûˆê’v2i•”•ªˆê’vj‚Ìê‡
                                // AB•sŒ»Zî•ñ.•sŒ»Z‚¾‚Á‚½ZŠ_•û‘@LIKE@f”¼Šp“ + •sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.•û‘ + ”¼Šp“f
                                strSQL.Append(" AND ");
                                strSQL.Append(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_KATAGAKI);
                                strSQL.Append(" LIKE ");
                                strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_KATAGAKI);
                                strKatagaki = CHAR_PERCENT + csABFugenjuJohoParaX.p_strKatagaki.Trim.ToString + CHAR_PERCENT;
                                break;
                            }

                        default:
                            {
                                // iŠ®‘Sˆê’vj
                                // AB•sŒ»Zî•ñ•sŒ»Z‚¾‚Á‚½ZŠ_•û‘@@f•sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.•û‘f
                                strSQL.Append(" AND ");
                                strSQL.Append(ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_KATAGAKI);
                                strSQL.Append(" = ");
                                strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_KATAGAKI);
                                strKatagaki = csABFugenjuJohoParaX.p_strKatagaki.Trim.ToString;
                                break;
                            }
                    }

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PARAM_FUGENJUDATTAJUSHO_KATAGAKI;
                    cfUFParameterClass.Value = strKatagaki;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                }

                // Z–¯ƒR[ƒh
                if (csABFugenjuJohoParaX.p_strJuminCD.Trim.RLength > 0)
                {
                    // AB•sŒ»Zî•ñ.Z–¯ƒR[ƒh@@f•sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.Z–¯ƒR[ƒhf
                    strSQL.Append(" AND ");
                    strSQL.Append(ABFugenjuJohoEntity.JUMINCD);
                    strSQL.Append(" = ");
                    strSQL.Append(ABFugenjuJohoEntity.PARAM_JUMINCD);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PARAM_JUMINCD;
                    cfUFParameterClass.Value = csABFugenjuJohoParaX.p_strJuminCD.Trim.ToString;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                }

                // “o˜^”NŒŽ“ú
                if (csABFugenjuJohoParaX.p_strTorokuSTYMD.Trim.RLength > 0 && csABFugenjuJohoParaX.p_strTorokuEDYMD.Trim.RLength > 0)
                {
                    // AB•sŒ»Zî•ñ.•sŒ»Z“o˜^”NŒŽ“ú@†@f•sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.ŠJŽn“o˜^”NŒŽ“úf
                    // AND@AB•sŒ»Zî•ñ.•sŒ»Z“o˜^”NŒŽ“ú@…@f•sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.I—¹“o˜^”NŒŽ“úf
                    strSQL.Append(" AND ");
                    strSQL.Append(ABFugenjuJohoEntity.FUGENJUTOROKUYMD).Append(" >= ");
                    strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUTOROKUYMD + "_ST");
                    strSQL.Append(" AND ");
                    strSQL.Append(ABFugenjuJohoEntity.FUGENJUTOROKUYMD).Append(" <= ");
                    strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUTOROKUYMD + "_ED");

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PARAM_FUGENJUTOROKUYMD + "_ST";
                    cfUFParameterClass.Value = csABFugenjuJohoParaX.p_strTorokuSTYMD.Trim.ToString;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PARAM_FUGENJUTOROKUYMD + "_ED";
                    cfUFParameterClass.Value = csABFugenjuJohoParaX.p_strTorokuEDYMD.Trim.ToString;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                }

                // ‹Z•s–¾”NŒŽ“ú
                if (csABFugenjuJohoParaX.p_strKyojuFumeiSTYMD.Trim.RLength > 0 && csABFugenjuJohoParaX.p_strKyojuFumeiEDYMD.Trim.RLength > 0)
                {
                    // AB•sŒ»Zî•ñ.•sŒ»Z‹Z•s–¾”NŒŽ“ú@†@f•sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.ŠJŽn‹Z•s–¾”NŒŽ“úf
                    // AND@AB•sŒ»Zî•ñ.•sŒ»Z‹Z•s–¾”NŒŽ“ú@…@f•sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.I—¹‹Z•s–¾”NŒŽ“úf

                    strSQL.Append(" AND ");
                    strSQL.Append(ABFugenjuJohoEntity.KYOJUFUMEI_YMD).Append(" >= ");
                    strSQL.Append(ABFugenjuJohoEntity.PARAM_KYOJUFUMEI_YMD + "_ST");
                    strSQL.Append(" AND ");
                    strSQL.Append(ABFugenjuJohoEntity.KYOJUFUMEI_YMD).Append(" <= ");
                    strSQL.Append(ABFugenjuJohoEntity.PARAM_KYOJUFUMEI_YMD + "_ED");

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PARAM_KYOJUFUMEI_YMD + "_ST";
                    cfUFParameterClass.Value = csABFugenjuJohoParaX.p_strKyojuFumeiSTYMD.Trim.ToString;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PARAM_KYOJUFUMEI_YMD + "_ED";
                    cfUFParameterClass.Value = csABFugenjuJohoParaX.p_strKyojuFumeiEDYMD.Trim.ToString;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                }

                // •sŒ»Z‹æ•ª
                if (csABFugenjuJohoParaX.p_strFugenjuKB.Trim.RLength > 0)
                {
                    strSQL.Append(" AND ");
                    strSQL.Append(ABFugenjuJohoEntity.FUGENJUKB);
                    strSQL.Append(" = ");
                    strSQL.Append(ABFugenjuJohoEntity.PARAM_FUGENJUKB);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PARAM_FUGENJUKB;
                    cfUFParameterClass.Value = csABFugenjuJohoParaX.p_strFugenjuKB.Trim.ToString;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                }

                // Å‘åŽæ“¾Œ”
                if (csABFugenjuJohoParaX.p_intHyojiKensu == 0)
                {
                    // ’ŠoSQL‚ÌŽÀs‚ðs‚¤‚q‚c‚aƒNƒ‰ƒXiUFRdbClassj‚ÌÅ‘åŽæ“¾Œ”ƒvƒƒpƒeƒBip_intMaxRowsj‚É100‚ðÝ’è‚·‚é
                    m_cfRdbClass.p_intMaxRows = MAX_ROWS;
                }
                else
                {
                    // ’ŠoSQL‚ÌŽÀs‚ðs‚¤‚q‚c‚aƒNƒ‰ƒXiUFRdbClassj‚ÌÅ‘åŽæ“¾Œ”ƒvƒƒpƒeƒBip_intMaxRowsj‚É•sŒ»ZŒŸõƒpƒ‰ƒ[ƒ^.Å‘åŽæ“¾Œ”‚Ì’l‚ðÝ’è‚·‚é
                    m_cfRdbClass.p_intMaxRows = csABFugenjuJohoParaX.p_intHyojiKensu;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 30819


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csFugenjuJohoEntity = m_csDataSchma.Clone();
                csFugenjuJohoEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csFugenjuJohoEntity, ABFugenjuJohoEntity.TABLE_NAME, cfUFParameterCollectionClass, false);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31785


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31888


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 32422


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return csFugenjuJohoEntity
                    End Function
                #End Region

                #Region "•sŒ»Zî•ñƒf[ƒ^’Ç‰Áƒƒ\ƒbƒh"

                 */
            }

            return default;
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼   •sŒ»Zî•ñƒf[ƒ^’Ç‰Áƒƒ\ƒbƒh
        // * 
        // * \•¶         Public Function InsertFugenjuJoho(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@     •sŒ»Zî•ñ‚ÉV‹Kƒf[ƒ^‚ð’Ç‰Á‚·‚éB
        // * 
        // * ˆø”         csDataRow As DataRow   : •sŒ»ZŽÒî•ñ(ABFUGENJUJOHO)
        // * 
        // * –ß‚è’l       ’Ç‰ÁŒ”(Integer)
        // ************************************************************************************************
        public int InsertFugenjuJoho(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "InsertFugenjuJoho";                                 // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            int intInsCnt;                                        // ’Ç‰ÁŒ”
            string strUpdateDateTime;                                 // ƒVƒXƒeƒ€“ú•t

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strInsertSQL is null | string.IsNullOrEmpty(m_strInsertSQL) || m_cfInsertUFParameterCollectionClass is null)
                {
                    CreateSQL(csDataRow);
                }
                else
                {
                }

                // XV“úŽž‚ÌŽæ“¾
                strUpdateDateTime = m_cfRdbClass.GetSystemDate.ToString("yyyyMMddHHmmssfff");            // ì¬“úŽž

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABFugenjuJohoEntity.TANMATSUID) = m_cfControlData.m_strClientId;               // ’[––‚h‚c
                csDataRow(ABFugenjuJohoEntity.SAKUJOFG) = "0";                                           // íœƒtƒ‰ƒO
                csDataRow(ABFugenjuJohoEntity.KOSHINCOUNTER) = decimal.Zero;                             // XVƒJƒEƒ“ƒ^
                csDataRow(ABFugenjuJohoEntity.SAKUSEINICHIJI) = strUpdateDateTime;                       // ì¬“úŽž
                csDataRow(ABFugenjuJohoEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;                // ì¬ƒ†[ƒU[
                csDataRow(ABFugenjuJohoEntity.KOSHINNICHIJI) = strUpdateDateTime;                        // XV“úŽž
                csDataRow(ABFugenjuJohoEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                 // XVƒ†[ƒU[

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    this.m_cfInsertUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABFugenjuJohoEntity.PARAM_PLACEHOLDER.RLength)).ToString();

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 35835


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36612


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36715


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37249


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return intInsCnt
                    End Function
                #End Region

                #Region "•sŒ»Zî•ñƒf[ƒ^XVƒƒ\ƒbƒh"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼   •sŒ»Zî•ñƒf[ƒ^XVƒƒ\ƒbƒh
                    '* 
                    '* \•¶         Public Function UpdateFugenjuJoho(ByVal csDataRow As DataRow) As Integer
                    '* 
                    '* ‹@”\@@     •sŒ»Zî•ñ‚Ìƒf[ƒ^‚ðXV‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”         csDataRow As DataRow   : •sŒ»ZŽÒî•ñ(ABFUGENJUJOHO)
        // * 
        // * –ß‚è’l       XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateFugenjuJoho(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "UpdateFugenjuJoho";                         // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            int intUpdCnt;                                // XVŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strUpDateSQL is null | string.IsNullOrEmpty(m_strUpDateSQL) || m_cfUpdateUFParameterCollectionClass is null)
                {
                    CreateSQL(csDataRow);
                }
                else
                {
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABFugenjuJohoEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                   // ’[––‚h‚c
                csDataRow(ABFugenjuJohoEntity.KOSHINCOUNTER) = (decimal)csDataRow(ABFugenjuJohoEntity.KOSHINCOUNTER) + 1m;       // XVƒJƒEƒ“ƒ^
                csDataRow(ABFugenjuJohoEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate.ToString("yyyyMMddHHmmssfff");     // XV“úŽž
                csDataRow(ABFugenjuJohoEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                     // XVƒ†[ƒU[

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABFugenjuJohoEntity.PREFIX_KEY.RLength) == ABFugenjuJohoEntity.PREFIX_KEY)
                    {
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABFugenjuJohoEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABFugenjuJohoEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40696


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 41473


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 41576


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42110


                Input:
                " + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return intUpdCnt
                    End Function
                #End Region

                #Region " SQL•¶‚Ìì¬"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼   SQL•¶‚Ìì¬
                    '* 
                    '* \•¶         Private Sub CreateSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\@@     INSERT, UPDATE‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”         csDataRow As DataRow :
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42650


                Input:
                 XV‘ÎÛ‚Ìs

                 */
            }

            return default;
        }
        // * 
        // * –ß‚è’l       ‚È‚µ
        // ************************************************************************************************
        private void CreateSQL(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "CreateSQL";
            UFParameterClass cfUFParameterClass;                  // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            string strInsertColumn;                               // ’Ç‰ÁSQL•¶€–Ú•¶Žš—ñ
            string strInsertParam;                                // ’Ç‰ÁSQL•¶ƒpƒ‰ƒ[ƒ^•¶Žš—ñ
            var strWhere = new StringBuilder();                           // XVíœSQL•¶Where•¶•¶Žš—ñ

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // INSERT SQL•¶‚Ìì¬
                m_strInsertSQL = "INSERT INTO " + ABFugenjuJohoEntity.TABLE_NAME + " ";
                strInsertColumn = "";
                strInsertParam = "";

                // UPDATE SQL•¶‚Ìì¬
                m_strUpDateSQL = "UPDATE " + ABFugenjuJohoEntity.TABLE_NAME + " SET ";

                // UPDATE Where•¶ì¬
                strWhere.Append(" WHERE ");
                strWhere.Append(ABFugenjuJohoEntity.JUMINCD);
                strWhere.Append(" = ");
                strWhere.Append(ABFugenjuJohoEntity.PREFIX_KEY + ABFugenjuJohoEntity.JUMINCD);
                strWhere.Append(" AND ");
                strWhere.Append(ABFugenjuJohoEntity.KOSHINCOUNTER);
                strWhere.Append(" = ");
                strWhere.Append(ABFugenjuJohoEntity.PREFIX_KEY + ABFugenjuJohoEntity.KOSHINCOUNTER);

                // SELECT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfInsertUFParameterCollectionClass = new UFParameterCollectionClass();

                // UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfUpdateUFParameterCollectionClass = new UFParameterCollectionClass();

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                {
                    cfUFParameterClass = new UFParameterClass();

                    // INSERT SQL•¶‚Ìì¬
                    strInsertColumn += csDataColumn.ColumnName + ", ";
                    strInsertParam += ABFugenjuJohoEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", ";

                    // UPDATE SQL•¶‚Ìì¬
                    m_strUpDateSQL += csDataColumn.ColumnName + " = " + ABFugenjuJohoEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", ";

                    // INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
                    m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass);

                    // UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
                    m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);
                }

                // INSERT SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                strInsertColumn = strInsertColumn.Trim();
                strInsertColumn = strInsertColumn.Trim(",");
                strInsertParam = strInsertParam.Trim();
                strInsertParam = strInsertParam.Trim(",");
                m_strInsertSQL += "(" + strInsertColumn + ")" + " VALUES (" + strInsertParam + ")";

                // UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                m_strUpDateSQL = m_strUpDateSQL.Trim();
                m_strUpDateSQL = m_strUpDateSQL.Trim(",");

                // UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                m_strUpDateSQL += strWhere.ToString();

                // UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚ÉƒL[î•ñ‚ð’Ç‰Á
                // Z–¯ƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PREFIX_KEY + ABFugenjuJohoEntity.JUMINCD;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);
                // XVƒJƒEƒ“ƒ^
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABFugenjuJohoEntity.PREFIX_KEY + ABFugenjuJohoEntity.KOSHINCOUNTER;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 47535


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 47638


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 48172


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try
                    End Sub
                #End Region

                #Region "SELECT‹å‚Ìì¬"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     SELECT‹å‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateSelect() As String
                    '* 
                    '* ‹@”\@@    @ SELECT‹å‚ð¶¬‚·‚é

                 */
            }
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
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SELECT‹å‚Ìì¬
                csSELECT.AppendFormat("SELECT {0}", ABFugenjuJohoEntity.SHICHOSONCD);                      // Žs’¬‘ºƒR[ƒh
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.JUMINCD);                               // Z–¯ƒR[ƒh
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUKB);                             // •sŒ»Z‹æ•ª
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_YUBINNO);             // •sŒ»Z‚¾‚Á‚½ZŠ_—X•Ö”Ô†
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_KANNAIKANGAIKB);      // •sŒ»Z‚¾‚Á‚½ZŠ_ŠÇ“àŠÇŠO‹æ•ª
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_JUSHOCD);             // •sŒ»Z‚¾‚Á‚½ZŠ_ZŠƒR[ƒh
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_JUSHO);               // •sŒ»Z‚¾‚Á‚½ZŠ_ZŠ
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_SHICHOSONCD);         // •sŒ»Z‚¾‚Á‚½ZŠ_Žs‹æ’¬‘ºƒR[ƒh
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_MACHIAZACD);          // •sŒ»Z‚¾‚Á‚½ZŠ_’¬ŽšƒR[ƒh
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_TODOFUKEN);           // •sŒ»Z‚¾‚Á‚½ZŠ_“s“¹•{Œ§
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_SHIKUGUNCHOSON);      // •sŒ»Z‚¾‚Á‚½ZŠ_Žs‹æŒS’¬‘º–¼
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_MACHIAZA);            // •sŒ»Z‚¾‚Á‚½ZŠ_’¬Žš
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_BANCHI);              // •sŒ»Z‚¾‚Á‚½ZŠ_”Ô’n†•\‹L
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_KATAGAKI);            // •sŒ»Z‚¾‚Á‚½ZŠ_•û‘
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_KANAKATAGAKI);        // •sŒ»Z‚¾‚Á‚½ZŠ_•û‘_ƒtƒŠƒKƒi
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUJOHO_TAISHOSHAKUBUN);            // •sŒ»Zî•ñi‘ÎÛŽÒ‹æ•ªj
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUJOHO_TAISHOSHASHIMEI);           // •sŒ»Zî•ñi‘ÎÛŽÒŽ–¼j
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUJOHO_TAISHOSHAKANASHIMEI);       // •sŒ»Zî•ñi‘ÎÛŽÒƒJƒiŽ–¼j
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUJOHO_SEARCHKANJISHIMEI);         // •sŒ»Zî•ñiŒŸõ—pŠ¿ŽšŽ–¼j
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUJOHO_SEARCHKANASHIMEI);          // •sŒ»Zî•ñiŒŸõ—pƒJƒiŽ–¼j
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUDATTAJUSHO_SEARCHJUSHO);         // •sŒ»Z‚¾‚Á‚½ZŠ_ŒŸõ—pZŠ
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUJOHO_TAISHOSHASHIMEI_SEI);       // •sŒ»Zî•ñi‘ÎÛŽÒŽ–¼_©j
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUJOHO_TAISHOSHASHIMEI_MEI);       // •sŒ»Zî•ñi‘ÎÛŽÒŽ–¼_–¼j
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUJOHO_UMAREYMD);                  // •sŒ»Zî•ñi¶”NŒŽ“új
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUJOHO_SEIBETSU);                  // •sŒ»Zî•ñi«•Êj
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.KYOJUFUMEI_YMD);                        // ‹Z•s–¾”NŒŽ“ú
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUTOROKUYMD);                      // •sŒ»Z“o˜^”NŒŽ“ú
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUGYOSEIKUCD);                     // Žw’è“sŽs_s­‹æ“™ƒR[ƒh
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.FUGENJUJOHO_BIKO);                      // •sŒ»Zî•ñi”õlj
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.RESERVE);                               // ƒŠƒU[ƒu
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.TANMATSUID);                            // ’[––ID
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.SAKUJOFG);                              // íœƒtƒ‰ƒO
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.KOSHINCOUNTER);                         // XVƒJƒEƒ“ƒ^
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.SAKUSEINICHIJI);                        // ì¬“úŽž
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.SAKUSEIUSER);                           // ì¬ƒ†[ƒU
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.KOSHINNICHIJI);                         // XV“úŽž
                csSELECT.AppendFormat(", {0}", ABFugenjuJohoEntity.KOSHINUSER);                            // XVƒ†[ƒU

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 54383


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 54479


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 54747


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 54830


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