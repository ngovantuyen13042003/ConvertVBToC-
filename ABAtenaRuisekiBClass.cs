// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‚`‚aˆ¶–¼—ÝÏƒ}ƒXƒ^‚c‚`
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/01/15@‘ê‘ò@‹Ô–ç
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/03/10 000001     ZŠ‚b‚c“™‚Ì®‡«ƒ`ƒFƒbƒN‚ÉŒë‚è
// * 2003/03/31 000002     ®‡«ƒ`ƒFƒbƒN‚ðTrim‚µ‚½’l‚Åƒ`ƒFƒbƒN‚·‚é
// * 2003/04/16 000003     ¶˜a—ï”NŒŽ“ú‚Ì“ú•tƒ`ƒFƒbƒN‚ð”’lƒ`ƒFƒbƒN‚É•ÏX
// *                       ŒŸõ—pƒJƒi‚Ì”¼ŠpƒJƒiƒ`ƒFƒbƒN‚ð‚`‚m‚jƒ`ƒFƒbƒN‚É•ÏX
// * 2003/05/20 000004     ƒGƒ‰[A“ú•tƒNƒ‰ƒX‚Ì²Ý½ÀÝ½‚ðºÝ½Ä×¸À‚É•ÏX
// * 2003/08/28 000005     RDBƒAƒNƒZƒXƒƒO‚ÌC³
// * 2003/09/11 000006     ’[––‚h‚c®‡«ƒ`ƒFƒbƒN‚ðANK‚É‚·‚é
// * 2003/10/09 000007     ì¬ƒ†[ƒU[EXVƒ†[ƒU[ƒ`ƒFƒbƒN‚Ì•ÏX
// * 2003/10/30 000008     Žd—l•ÏXAƒJƒ^ƒJƒiƒ`ƒFƒbƒN‚ðANKƒ`ƒFƒbƒN‚É•ÏX
// * 2003/11/18 000009     Žd—l•ÏXF€–Ú’Ç‰Á
// * 2003/12/01 000010     Žd—l•ÏXF€–Ú–¼‚Ì•ÏX(SYORINICHIJI->SHORINICHIJI)
// *                       Žd—l•ÏXF€–Ú–¼‚Ì•ÏX(KOKUHOTIAHKHONHIKBMEISHO->KOKUHOTISHKHONHIKBMEISHO)
// * 2004/03/06 000011     Žd—l•ÏXF‘•Û•ÛŒ¯Ø”Ô†‚Ìƒ`ƒFƒbƒN‚È‚µ‚É•ÏX
// * 2004/08/13 000012     Žd—l•ÏXA’n‹æƒR[ƒhƒ`ƒFƒbƒN‚ðANKƒ`ƒFƒbƒN‚É•ÏX
// * 2004/11/12 000013     ƒf[ƒ^ƒ`ƒFƒbƒN‚ðs‚È‚í‚È‚¢
// * 2005/12/26 000014     Žd—l•ÏXFs­‹æ‚b‚c‚ðANKƒ`ƒFƒbƒN‚É•ÏX(ƒ}ƒ‹ƒS‘ºŽR)
// * 2010/04/16 000015     VS2008‘Î‰ži”ä‰Ãj
// * 2011/10/24 000016     yAB17010zƒZŠî–@‰ü³‘Î‰ž„ˆ¶–¼—ÝÏ•tƒ}ƒXƒ^’Ç‰Á   (¬¼)
// * 2023/08/14 000017    yAB-0820-1zZ“oŠOŠÇ—€–Ú’Ç‰Á(‘è)
// ************************************************************************************************
using System.Data;
using System.Linq;
using System.Text;

namespace Densan.Reams.AB.AB000BB
{

    // ************************************************************************************************
    // *
    // * ˆ¶–¼—ÝÏƒ}ƒXƒ^Žæ“¾Žž‚ÉŽg—p‚·‚éƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
    // *
    // ************************************************************************************************
    public class ABAtenaRuisekiBClass
    {
        #region ƒƒ“
        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private string m_strInsertSQL;                        // INSERT—pSQL
        private UFParameterCollectionClass m_cfSelectUFParameterCollectionClass;      // SELECT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;      // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFErrorClass m_cfErrorClass;                  // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private UFDateClass m_cfDateClass;                    // “ú•tƒNƒ‰ƒX

        // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁŠJŽn
        private ABSekoYMDHanteiBClass m_csSekoYMDHanteiB;             // Ž{s“ú”»’èB¸×½
        private ABAtenaRuisekiFZYBClass m_csAtenaRuisekiFZYB;         // ˆ¶–¼—ÝÏ•tƒ}ƒXƒ^B¸×½
        private bool m_blnJukihoKaiseiFG = false;
        private string m_strJukihoKaiseiKB;                           // ZŠî–@‰ü³‹æ•ª
                                                                      // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000017 2023/08/14 ’Ç‰ÁŠJŽn
        private ABAtenaRuiseki_HyojunBClass m_csAtenaRuisekiHyojunB;            // ˆ¶–¼—ÝÏ_•W€ƒ}ƒXƒ^B¸×½
        private ABAtenaRuisekiFZY_HyojunBClass m_csAtenaRuisekiFZYHyojunB;      // ˆ¶–¼—ÝÏ•t_•W€ƒ}ƒXƒ^B¸×½
                                                                                // *—š—ð”Ô† 000017 2023/08/14 ’Ç‰ÁI—¹

        // @ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABAtenaRuisekiBClass";                // ƒNƒ‰ƒX–¼
        private const string THIS_BUSINESSID = "AB";                                  // ‹Æ–±ƒR[ƒh

        private const string JUKIHOKAISEIKB_ON = "1";

        #endregion

        #region ƒvƒƒpƒeƒB
        // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁŠJŽn
        public string p_strJukihoKaiseiKB      // ZŠî–@‰ü³‹æ•ª
        {
            set
            {
                m_strJukihoKaiseiKB = value;
            }
        }
        // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁI—¹
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
        public ABAtenaRuisekiBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

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

            // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁŠJŽn
            m_strJukihoKaiseiKB = string.Empty;

            // ZŠî–@‰ü³Ì×¸ÞŽæ“¾
            GetJukihoKaiseiFG();
            // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁI—¹
        }
        #endregion

        #region ƒƒ\ƒbƒh
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—ÝÏƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Overloads Function GetAtenaRuiseki(ByVal strJuminCD As String, _
        // *                                                          ByVal strYusenKB As String) As DataSet
        // * 
        // * ‹@”\@@    @@Z“oŠOƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD    : Z–¯ƒR[ƒh
        // *                strYusenKB    : —Dæ‹æ•ª
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½ˆ¶–¼—š—ðƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetAtenaRuiseki(string strJuminCD, string strYusenKB)
        {
            return GetAtenaRuiseki(strJuminCD, "", "", strYusenKB);
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—ÝÏƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Overloads Function GetAtenaRuiseki(ByVal strKaishiNichiji As String, _
        // *                                                          ByVal strSyuryoNichiji As String, _
        // *                                                          ByVal strYusenKB As String) As DataSet
        // * 
        // * ‹@”\@@    @@Z“oŠOƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strKaishiNichiji  : ŠJŽn“úŽž
        // *                strSyuryoNichiji  : I—¹“úŽž
        // *                strYusenKB        : —Dæ‹æ•ª
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½ˆ¶–¼—š—ðƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetAtenaRuiseki(string strKaishiNichiji, string strSyuryoNichiji, string strYusenKB)

        {
            return GetAtenaRuiseki("", strKaishiNichiji, strSyuryoNichiji, strYusenKB);
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—ÝÏƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Overloads Function GetAtenaRuiseki(ByVal strJuminCD As String, _
        // *                                                          ByVal strKaishiNichiji As String, _
        // *                                                          ByVal strSyuryoNichiji As String, _
        // *                                                          ByVal strYusenKB As String) As DataSet
        // * 
        // * ‹@”\@@    @@Z“oŠOƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD        : Z–¯ƒR[ƒh
        // *                strKaishiNichiji  : ŠJŽn“úŽž
        // *                strSyuryoNichiji  : I—¹“úŽž
        // *                strYusenKB        : —Dæ‹æ•ª
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½ˆ¶–¼—š—ðƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetAtenaRuiseki(string strJuminCD, string strKaishiNichiji, string strSyuryoNichiji, string strYusenKB)


        {
            const string THIS_METHOD_NAME = "GetAtenaRuiseki";
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            UFParameterClass cfUFParameterClass;          // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            DataSet csAtenaRuisekiEntity;                 // ˆ¶–¼—ÝÏDataSet
            string strKaishiNichiji2;                     // ŠJŽn“úŽž
            string strSyuryoNichiji2;                     // I—¹“úŽž
            StringBuilder strSQL;
            StringBuilder strWHERE;
            DataSet csDataSchema;

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfSelectUFParameterCollectionClass = new UFParameterCollectionClass();

                // ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
                // ŠJŽn“úŽžƒ`ƒFƒbƒN
                if (strKaishiNichiji.RLength == 17)
                {
                    strKaishiNichiji2 = strKaishiNichiji;
                }

                else if (strKaishiNichiji.RLength == 8)
                {
                    strKaishiNichiji2 = strKaishiNichiji + "000000000";
                }

                else if (string.IsNullOrEmpty(strKaishiNichiji) & string.IsNullOrEmpty(strSyuryoNichiji))
                {
                    strKaishiNichiji2 = string.Empty;
                }
                else
                {
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_PARA_KAISHINICHIJI);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                }

                // I—¹“úŽžƒ`ƒFƒbƒN
                if (strSyuryoNichiji.RLength == 17)
                {
                    strSyuryoNichiji2 = strSyuryoNichiji;
                }

                else if (strSyuryoNichiji.RLength == 8)
                {
                    strSyuryoNichiji2 = strSyuryoNichiji + "000000000";
                }

                else if (string.IsNullOrEmpty(strSyuryoNichiji))
                {
                    strSyuryoNichiji2 = string.Empty;
                }
                else
                {
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_PARA_SYURYONICHIJI);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                }

                // —Dæ‹æ•ª
                if (!(strYusenKB == "1" | strYusenKB == "2"))
                {
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARIREKIB_PARA_YUSENKB);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                }


                // SQL•¶‚Ìì¬
                strSQL = new StringBuilder();
                // *—š—ð”Ô† 000016 2011/10/24 C³ŠJŽn
                // strSQL.Append("SELECT * FROM ")
                // strSQL.Append(ABAtenaRuisekiEntity.TABLE_NAME)
                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—ÝÏ•tƒ}ƒXƒ^‚ð•t‰Á
                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON)
                {
                    strSQL.AppendFormat("SELECT {0}.*", ABAtenaRuisekiEntity.TABLE_NAME);
                    SetFZYEntity(ref strSQL);
                    strSQL.AppendFormat(" FROM {0}", ABAtenaRuisekiEntity.TABLE_NAME);
                    SetFZYJoin(ref strSQL);
                }
                else
                {
                    strSQL.Append("SELECT * FROM ");
                    strSQL.Append(ABAtenaRuisekiEntity.TABLE_NAME);
                }
                // *—š—ð”Ô† 000016 2011/10/24 C³I—¹

                // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁŠJŽn
                csDataSchema = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABAtenaRuisekiEntity.TABLE_NAME, false);
                // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁI—¹


                strSQL.Append(" WHERE ");

                // WHERE‹å‚Ìì¬
                strWHERE = new StringBuilder();
                // Z–¯ƒR[ƒh
                if (!string.IsNullOrEmpty(strJuminCD))
                {
                    if (!(strWHERE.RLength == 0))
                    {
                        strWHERE.Append(" AND ");
                    }
                    // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁŠJŽn
                    // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—ÝÏ•tƒ}ƒXƒ^‚ð•t‰Á
                    if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON)
                    {
                        strWHERE.AppendFormat("{0}.", ABAtenaRuisekiEntity.TABLE_NAME);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }
                    // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁI—¹
                    strWHERE.Append(ABAtenaRuisekiEntity.JUMINCD);
                    strWHERE.Append(" = ");
                    strWHERE.Append(ABAtenaRuisekiEntity.KEY_JUMINCD);
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABAtenaRuisekiEntity.KEY_JUMINCD;
                    cfUFParameterClass.Value = strJuminCD;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);
                }
                // ŠJŽn“úŽž
                if (!string.IsNullOrEmpty(strKaishiNichiji2))
                {
                    if (!(strWHERE.RLength == 0))
                    {
                        strWHERE.Append(" AND ");
                    }
                    // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁŠJŽn
                    // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—ÝÏ•tƒ}ƒXƒ^‚ð•t‰Á
                    if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON)
                    {
                        strWHERE.AppendFormat("{0}.", ABAtenaRuisekiEntity.TABLE_NAME);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }
                    // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁI—¹
                    // *—š—ð”Ô† 000010 2003/12/01 C³ŠJŽn
                    // strWHERE.Append(ABAtenaRuisekiEntity.SYORINICHIJI)
                    strWHERE.Append(ABAtenaRuisekiEntity.SHORINICHIJI);
                    // *—š—ð”Ô† 000010 2003/12/01 C³I—¹
                    strWHERE.Append(" >= ");
                    strWHERE.Append(ABAtenaRuisekiEntity.KEY_SYORINICHIJI);
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABAtenaRuisekiEntity.KEY_SYORINICHIJI;
                    cfUFParameterClass.Value = strKaishiNichiji2;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);
                }
                // I—¹“úŽž
                if (!string.IsNullOrEmpty(strSyuryoNichiji2))
                {
                    if (!(strWHERE.RLength == 0))
                    {
                        strWHERE.Append(" AND ");
                    }
                    // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁŠJŽn
                    // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼—ÝÏ•tƒ}ƒXƒ^‚ð•t‰Á
                    if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON)
                    {
                        strWHERE.AppendFormat("{0}.", ABAtenaRuisekiEntity.TABLE_NAME);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }
                    // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁI—¹
                    // *—š—ð”Ô† 000010 2003/12/01 C³ŠJŽn
                    // strWHERE.Append(ABAtenaRuisekiEntity.SYORINICHIJI)
                    strWHERE.Append(ABAtenaRuisekiEntity.SHORINICHIJI);
                    // *—š—ð”Ô† 000010 2003/12/01 C³I—¹
                    strWHERE.Append(" <= ");
                    strWHERE.Append(ABAtenaRuisekiEntity.PARAM_SYORINICHIJI);
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABAtenaRuisekiEntity.PARAM_SYORINICHIJI;
                    cfUFParameterClass.Value = strSyuryoNichiji2;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfSelectUFParameterCollectionClass.Add(cfUFParameterClass);
                }
                // —Dæ‹æ•ª
                if (strYusenKB == "1")
                {
                    if (!(strWHERE.RLength == 0))
                    {
                        strWHERE.Append(" AND ");
                    }
                    strWHERE.Append(ABAtenaRuisekiEntity.JUTOGAIYUSENKB);
                    strWHERE.Append(" = '1'");
                }
                if (strYusenKB == "2")
                {
                    if (!(strWHERE.RLength == 0))
                    {
                        strWHERE.Append(" AND ");
                    }
                    strWHERE.Append(ABAtenaRuisekiEntity.JUMINYUSENIKB);
                    strWHERE.Append(" = '1'");
                }


                // ORDER‹å‚ðŒ‹‡
                if (strWHERE.RLength != 0)
                {
                    strSQL.Append(strWHERE);
                }


                // *—š—ð”Ô† 000005 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + strSQL.ToString + "z")

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, m_cfSelectUFParameterCollectionClass) + "z")
                // *—š—ð”Ô† 000005 2003/08/28 C³I—¹

                // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                // *—š—ð”Ô† 000016 2011/10/24 C³ŠJŽn
                // csAtenaRuisekiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, ABAtenaRuisekiEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass)
                csAtenaRuisekiEntity = csDataSchema.Clone();
                csAtenaRuisekiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csAtenaRuisekiEntity, ABAtenaRuisekiEntity.TABLE_NAME, m_cfSelectUFParameterCollectionClass, false);
                // *—š—ð”Ô† 000016 2011/10/24 C³I—¹


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21304


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21402


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21672


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21757


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csAtenaRuisekiEntity;

        }


        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ðƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertAtenaRB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@ˆ¶–¼—š—ðƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertAtenaRB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "InsertAtenaRB";
            // * corresponds to VS2008 Start 2010/04/16 000015
            // Dim csInstRow As DataRow
            // Dim csDataColumn As DataColumn
            // * corresponds to VS2008 End 2010/04/16 000015
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
                csDataRow(ABAtenaRuisekiEntity.TANMATSUID) = m_cfControlData.m_strClientId;  // ’[––‚h‚c
                csDataRow(ABAtenaRuisekiEntity.SAKUJOFG) = "0";                              // íœƒtƒ‰ƒO
                csDataRow(ABAtenaRuisekiEntity.KOSHINCOUNTER) = decimal.Zero;                // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaRuisekiEntity.SAKUSEINICHIJI) = strUpdateDateTime;          // ì¬“úŽž
                csDataRow(ABAtenaRuisekiEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;   // ì¬ƒ†[ƒU[
                csDataRow(ABAtenaRuisekiEntity.KOSHINNICHIJI) = strUpdateDateTime;           // XV“úŽž
                csDataRow(ABAtenaRuisekiEntity.KOSHINUSER) = m_cfControlData.m_strUserId;    // XVƒ†[ƒU[

                // *—š—ð”Ô† 000013 2004/11/12 C³ŠJŽn
                // “–ƒNƒ‰ƒX‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¤
                // For Each csDataColumn In csDataRow.Table.Columns
                // CheckColumnValue(csDataColumn.ColumnName, csDataRow(csDataColumn.ColumnName).ToString().Trim)
                // Next csDataColumn
                // *—š—ð”Ô† 000016 2004/11/12 C³I—¹

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    cfParam.Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaRuisekiEntity.PARAM_PLACEHOLDER.RLength)).ToString();

                // *—š—ð”Ô† 000005 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strInsertSQL + "z")

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strInsertSQL, m_cfInsertUFParameterCollectionClass) + "z")
                // *—š—ð”Ô† 000005 2003/08/28 C³I—¹

                // SQL‚ÌŽÀs
                intInsCnt = m_cfRdbClass.ExecuteSQL(m_strInsertSQL, m_cfInsertUFParameterCollectionClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 26874


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 26972


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 27242


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 27327


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intInsCnt;

        }
        // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—ÝÏƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertAtenaB() As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼—ÝÏƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”           csAtenaDr As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—ÝÏj
        // * @@           csAtenaFZYDr As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—ÝÏ•tj
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertAtenaRB(DataRow csAtenaDr, DataRow csAtenaFZYDr)
        {
            int intCnt = 0;
            int intCnt2 = 0;

            const string THIS_METHOD_NAME = "InsertAtenaRB";

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ˆ¶–¼—ÝÏƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                intCnt = InsertAtenaRB(csAtenaDr);

                // ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                if (!(csAtenaFZYDr == null) && m_blnJukihoKaiseiFG)
                {
                    // ˆ¶–¼—ÝÏ•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                    if (m_csAtenaRuisekiFZYB == null)
                    {
                        m_csAtenaRuisekiFZYB = new ABAtenaRuisekiFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }

                    // ì¬“úŽžAXV“úŽž‚Ì“¯Šú
                    csAtenaFZYDr(ABAtenaRuisekiFZYEntity.SAKUSEINICHIJI) = csAtenaDr(ABAtenaRuisekiEntity.SAKUSEINICHIJI);
                    csAtenaFZYDr(ABAtenaRuisekiFZYEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaRuisekiEntity.KOSHINNICHIJI);

                    // ˆ¶–¼—ÝÏ•tƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                    intCnt2 = m_csAtenaRuisekiFZYB.InsertAtenaFZYRB(csAtenaFZYDr);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 30440


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 30538


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 30808


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 30893


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intCnt;

        }

        // *—š—ð”Ô† 000017 2023/08/14 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—ÝÏƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertAtenaRB(ByVal csAtenaDr As DataRow, ByVal csAtenaHyojunDr As DataRow, _
        // *                                              ByVal csAtenaFZYDr As DataRow, ByVal csAtenaFZYHyojunDr As DataRow) As Integer
        // * 
        // * ‹@”\@@    @ ˆ¶–¼—ÝÏƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”           csAtenaDr As DataRow           : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—ÝÏj
        // *                csAtenaHyojunDr As DataRow     : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—ÝÏ_•W€j
        // * @@           csAtenaFZYDr As DataRow        : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—ÝÏ•tj
        // *                csAtenaFZYHyojunDr As DataRow  : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒgiˆ¶–¼—ÝÏ•t_•W€j
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertAtenaRB(DataRow csAtenaDr, DataRow csAtenaHyojunDr, DataRow csAtenaFZYDr, DataRow csAtenaFZYHyojunDr)
        {
            int intCnt = 0;
            int intCnt2 = 0;
            int intCnt3 = 0;
            int intCnt4 = 0;

            const string THIS_METHOD_NAME = "InsertAtenaRB";

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ˆ¶–¼—ÝÏƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                intCnt = InsertAtenaRB(csAtenaDr);

                if (!(csAtenaHyojunDr == null))
                {

                    // ˆ¶–¼—ÝÏ_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                    if (m_csAtenaRuisekiHyojunB == null)
                    {
                        m_csAtenaRuisekiHyojunB = new ABAtenaRuiseki_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                    }
                    else
                    {
                        // ˆ—‚È‚µ
                    }

                    // ˆ¶–¼—ÝÏ•W€‚Ìì¬“úŽž‚ÆXV“úŽž‚Éˆ¶–¼—ÝÏRow‚Ìì¬“úŽž‚ÆXV“úŽž‚ðƒZƒbƒg‚·‚é
                    csAtenaHyojunDr(ABAtenaRuisekiHyojunEntity.SAKUSEINICHIJI) = csAtenaDr(ABAtenaRuisekiEntity.SAKUSEINICHIJI);
                    csAtenaHyojunDr(ABAtenaRuisekiHyojunEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaRuisekiEntity.KOSHINNICHIJI);

                    // ˆ¶–¼—ÝÏ_•W€ƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                    intCnt2 = m_csAtenaRuisekiHyojunB.InsertAtenaRuisekiHyojunB(csAtenaHyojunDr);

                }
                // ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«
                if (m_blnJukihoKaiseiFG)
                {

                    // ˆ¶–¼—ÝÏ•tRow‚ª‘¶Ý‚·‚éê‡
                    if (csAtenaFZYDr is not null)
                    {

                        // ˆ¶–¼—ÝÏ•tƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                        if (m_csAtenaRuisekiFZYB == null)
                        {
                            m_csAtenaRuisekiFZYB = new ABAtenaRuisekiFZYBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                        }
                        else
                        {
                            // ˆ—‚È‚µ
                        }

                        // ì¬“úŽžAXV“úŽž‚Ì“¯Šú
                        csAtenaFZYDr(ABAtenaRuisekiFZYEntity.SAKUSEINICHIJI) = csAtenaDr(ABAtenaRuisekiEntity.SAKUSEINICHIJI);
                        csAtenaFZYDr(ABAtenaRuisekiFZYEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaRuisekiEntity.KOSHINNICHIJI);

                        // ˆ¶–¼—ÝÏ•tƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                        intCnt3 = m_csAtenaRuisekiFZYB.InsertAtenaFZYRB(csAtenaFZYDr);

                    }

                    // ˆ¶–¼—ÝÏ•t_•W€Row‚ª‘¶Ý‚·‚éê‡
                    if (csAtenaFZYHyojunDr is not null)
                    {

                        // ˆ¶–¼—ÝÏ•t_•W€ƒ}ƒXƒ^B¸×½‚Ì²Ý½ÀÝ½‰»
                        if (m_csAtenaRuisekiFZYHyojunB == null)
                        {
                            m_csAtenaRuisekiFZYHyojunB = new ABAtenaRuisekiFZY_HyojunBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                        }
                        else
                        {
                            // ˆ—‚È‚µ
                        }

                        // ì¬“úŽžAXV“úŽž‚Ì“¯Šú
                        csAtenaFZYHyojunDr(ABAtenaRuisekiFZYHyojunEntity.SAKUSEINICHIJI) = csAtenaDr(ABAtenaRuisekiEntity.SAKUSEINICHIJI);
                        csAtenaFZYHyojunDr(ABAtenaRuisekiFZYHyojunEntity.KOSHINNICHIJI) = csAtenaDr(ABAtenaRuisekiEntity.KOSHINNICHIJI);

                        // ˆ¶–¼—ÝÏ•t_•W€ƒ}ƒXƒ^’Ç‰Á‚ðŽÀs
                        intCnt4 = m_csAtenaRuisekiFZYHyojunB.InsertAtenaRuisekiFZYHyojunB(csAtenaFZYHyojunDr);

                    }
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36806


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36904


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37174


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37259


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intCnt;

        }
        // *—š—ð”Ô† 000017 2023/08/14 ’Ç‰ÁI—¹

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     SQL•¶‚Ìì¬
        // * 
        // * \•¶           Private Sub CreateSQL(ByVal csDataRow As DataRow)
        // * 
        // * ‹@”\@@    @@INSERT, UPDATE, DELETE‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
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
                m_strInsertSQL = "INSERT INTO " + ABAtenaRuisekiEntity.TABLE_NAME + " ";
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

                    csInsertParam.Append(ABAtenaRuisekiEntity.PARAM_PLACEHOLDER);
                    csInsertParam.Append(csDataColumn.ColumnName);
                    csInsertParam.Append(", ");

                    // INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    cfUFParameterClass.ParameterName = ABAtenaRuisekiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40753


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40851


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 41121


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 41206


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }

        // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼•tƒf[ƒ^€–Ú•ÒW
        // * 
        // * \•¶           Private SetFZYEntity()
        // * 
        // * ‹@”\           ˆ¶–¼•tƒf[ƒ^‚Ì€–Ú•ÒW‚ð‚µ‚Ü‚·B
        // * 
        // * ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void SetFZYEntity(ref StringBuilder strAtenaSQLsb)
        {
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.TABLEINSERTKB);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.LINKNO);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.JUMINHYOJOTAIKBN);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.JUKYOCHITODOKEFLG);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.HONGOKUMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.KANAHONGOKUMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.KANJIHEIKIMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.KANAHEIKIMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.KANJITSUSHOMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.KANATSUSHOMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.KATAKANAHEIKIMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.UMAREFUSHOKBN);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.TSUSHOMEITOUROKUYMD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.ZAIRYUKIKANCD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.ZAIRYUKIKANMEISHO);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.ZAIRYUSHACD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.ZAIRYUSHAMEISHO);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.ZAIRYUCARDNO);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.KOFUYMD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.KOFUYOTEISTYMD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.KOFUYOTEIEDYMD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.JUKITAISHOSHASHOJOIDOYMD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.JUKITAISHOSHASHOJOJIYUCD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.JUKITAISHOSHASHOJOJIYU);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.JUKITAISHOSHASHOJOTDKDYMD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.JUKITAISHOSHASHOJOTDKDTUCIKB);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.FRNSTAINUSMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.FRNSTAINUSKANAMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.STAINUSHEIKIMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.STAINUSKANAHEIKIMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.STAINUSTSUSHOMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.STAINUSKANATSUSHOMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.TENUMAEJ_STAINUSMEI_KYOTSU);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.TENUMAEJ_STAINUSHEIKIMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.TENUMAEJ_STAINUSTSUSHOMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.TENSHUTSUYOTEISTAINUSMEI_KYOTSU);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.TENSHUTSUYOTEISTAINUSHEIKIMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.TENSHUTSUYOTEISTAINUSTSUSHOMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.TENSHUTSUKKTISTAINUSMEI_KYOTSU);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.TENSHUTSUKKTISTAINUSHEIKIMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.TENSHUTSUKKTISTAINUSTSUSHOMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.RESERVE1);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.RESERVE2);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.RESERVE3);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.RESERVE4);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.RESERVE5);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.RESERVE6);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.RESERVE7);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.RESERVE8);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.RESERVE9);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.RESERVE10);

        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼•tƒe[ƒuƒ‹JOIN‹åì¬
        // * 
        // * \•¶           Private SetFZYJoin()
        // * 
        // * ‹@”\           ˆ¶–¼•tƒe[ƒuƒ‹‚ÌJOIN‹å‚ðì¬‚µ‚Ü‚·B
        // * 
        // * ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void SetFZYJoin(ref StringBuilder strAtenaSQLsb)
        {
            strAtenaSQLsb.AppendFormat(" LEFT OUTER JOIN {0} ", ABAtenaRuisekiFZYEntity.TABLE_NAME);
            strAtenaSQLsb.AppendFormat(" ON {0}.{1} = {2}.{3} ", ABAtenaRuisekiEntity.TABLE_NAME, ABAtenaRuisekiEntity.JUMINCD, ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.JUMINCD);

            strAtenaSQLsb.AppendFormat(" AND {0}.{1} = {2}.{3} ", ABAtenaRuisekiEntity.TABLE_NAME, ABAtenaRuisekiEntity.RIREKINO, ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.RIREKINO);

            strAtenaSQLsb.AppendFormat(" AND {0}.{1} = {2}.{3} ", ABAtenaRuisekiEntity.TABLE_NAME, ABAtenaRuisekiEntity.SHORINICHIJI, ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.SHORINICHIJI);

            strAtenaSQLsb.AppendFormat(" AND {0}.{1} = {2}.{3} ", ABAtenaRuisekiEntity.TABLE_NAME, ABAtenaRuisekiEntity.ZENGOKB, ABAtenaRuisekiFZYEntity.TABLE_NAME, ABAtenaRuisekiFZYEntity.ZENGOKB);

        }
        // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁI—¹

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
        // * 
        // * \•¶           Private Sub CheckColumnValue(ByVal strColumnName As String, ByVal strValue as String)
        // * 
        // * ‹@”\           XVƒf[ƒ^‚Ì®‡«‚ðƒ`ƒFƒbƒN‚·‚éB
        // * 
        // * ˆø”           strColumnName As String : ˆ¶–¼—š—ðƒ}ƒXƒ^ƒf[ƒ^ƒZƒbƒg‚Ì€–Ú–¼
        // *                strValue As String     : €–Ú‚É‘Î‰ž‚·‚é’l
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void CheckColumnValue(string strColumnName, string strValue)
        {

            const string THIS_METHOD_NAME = "CheckColumnValue";
            const string TABLENAME = "ˆ¶–¼—ÝÏD";
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                // m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME, strColumnName + "'" + strValue + "'")

                // “ú•tƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                if (m_cfDateClass == null)
                {
                    m_cfDateClass = new UFDateClass(m_cfConfigDataClass);
                    // “ú•tƒNƒ‰ƒX‚Ì•K—v‚ÈÝ’è‚ðs‚¤
                    m_cfDateClass.p_enDateSeparator = UFDateSeparator.None;
                }

                switch (strColumnName.ToUpper() ?? "")
                {

                    case var @case when @case == ABAtenaRuisekiEntity.JUMINCD:            // Z–¯ƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUMINCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case1 when case1 == ABAtenaRuisekiEntity.SHICHOSONCD:        // Žs’¬‘ºƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SHICHOSONCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case2 when case2 == ABAtenaRuisekiEntity.KYUSHICHOSONCD:     // ‹ŒŽs’¬‘ºƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KYUSHICHOSONCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case3 when case3 == ABAtenaRuisekiEntity.RIREKINO:           // —š—ð”Ô†
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_RIREKINO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    // *—š—ð”Ô† 000010 2003/12/01 C³ŠJŽn
                    // Case ABAtenaRuisekiEntity.SYORINICHIJI      'ˆ—“úŽž
                    case var case4 when case4 == ABAtenaRuisekiEntity.SHORINICHIJI:      // ˆ—“úŽž
                        {
                            // *—š—ð”Ô† 000010 2003/12/01 C³I—¹
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SYORINICHIJI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }
                    case var case5 when case5 == ABAtenaRuisekiEntity.ZENGOKB:           // ‘OŒã‹æ•ª
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_ZENGOKB);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case6 when case6 == ABAtenaRuisekiEntity.RRKST_YMD:          // —š—ðŠJŽn”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_RRKST_YMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case7 when case7 == ABAtenaRuisekiEntity.RRKED_YMD:          // —š—ðI—¹”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000" | strValue == "99999999"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_RRKED_YMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case8 when case8 == ABAtenaRuisekiEntity.JUMINJUTOGAIKB:     // Z–¯Z“oŠO‹æ•ª
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUMINJUTOGAIKB);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case9 when case9 == ABAtenaRuisekiEntity.JUMINYUSENIKB:      // Z–¯—Dæ‹æ•ª
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUMINYUSENIKB);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case10 when case10 == ABAtenaRuisekiEntity.JUTOGAIYUSENKB:     // Z“oŠO—Dæ‹æ•ª
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUTOGAIYUSENKB);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case11 when case11 == ABAtenaRuisekiEntity.ATENADATAKB:        // ˆ¶–¼ƒf[ƒ^‹æ•ª
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_ATENADATAKB);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case12 when case12 == ABAtenaRuisekiEntity.STAICD:             // ¢‘ÑƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_STAICD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case13 when case13 == ABAtenaRuisekiEntity.JUMINHYOCD:         // Z–¯•[ƒR[ƒh
                        {
                            break;
                        }
                    // ƒ`ƒFƒbƒN‚È‚µ

                    case var case14 when case14 == ABAtenaRuisekiEntity.SEIRINO:            // ®—”Ô†
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SEIRINO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case15 when case15 == ABAtenaRuisekiEntity.ATENADATASHU:       // ˆ¶–¼ƒf[ƒ^Ží•Ê
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_ATENADATASHU);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case16 when case16 == ABAtenaRuisekiEntity.HANYOKB1:           // ”Ä—p‹æ•ª1
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_HANYOKB1);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case17 when case17 == ABAtenaRuisekiEntity.KJNHJNKB:           // ŒÂl–@l‹æ•ª
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KJNHJNKB);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case18 when case18 == ABAtenaRuisekiEntity.HANYOKB2:           // ”Ä—p‹æ•ª2
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_HANYOKB2);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case19 when case19 == ABAtenaRuisekiEntity.KANNAIKANGAIKB:     // ŠÇ“àŠÇŠO‹æ•ª
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KANNAIKANGAIKB);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case20 when case20 == ABAtenaRuisekiEntity.KANAMEISHO1:        // ƒJƒi–¼Ì1
                        {
                            // *—š—ð”Ô† 000008 2003/10/30 C³ŠJŽn
                            // If (Not UFStringClass.CheckKataKana(strValue)) Then
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // *—š—ð”Ô† 000008 2003/10/30 C³I—¹
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KANAMEISHO1);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case21 when case21 == ABAtenaRuisekiEntity.KANJIMEISHO1:       // Š¿Žš–¼Ì1
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KANJIMEISHO1);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case22 when case22 == ABAtenaRuisekiEntity.KANAMEISHO2:        // ƒJƒi–¼Ì2
                        {
                            // *—š—ð”Ô† 000008 2003/10/30 C³ŠJŽn
                            // If (Not UFStringClass.CheckKataKana(strValue)) Then
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // *—š—ð”Ô† 000008 2003/10/30 C³I—¹
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KANAMEISHO2);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case23 when case23 == ABAtenaRuisekiEntity.KANJIMEISHO2:       // Š¿Žš–¼Ì2
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KANJIMEISHO2);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case24 when case24 == ABAtenaRuisekiEntity.KANJIHJNKEITAI:     // Š¿Žš–@lŒ`‘Ô
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KANJIHJNKEITAI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case25 when case25 == ABAtenaRuisekiEntity.KANJIHJNDAIHYOSHSHIMEI:   // Š¿Žš–@l‘ã•\ŽÒŽ–¼
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KANJIHJNDAIHYOSHSHIMEI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case26 when case26 == ABAtenaRuisekiEntity.SEARCHKANJIMEISHO:  // ŒŸõ—pŠ¿Žš–¼Ì
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SEARCHKANJIMEISHO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case27 when case27 == ABAtenaRuisekiEntity.KYUSEI:             // ‹Œ©
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KYUSEI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case28 when case28 == ABAtenaRuisekiEntity.SEARCHKANASEIMEI:   // ŒŸõ—pƒJƒi©–¼
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾(‰p”ŽšE”¼ŠpƒJƒi€–Ú“ü—Í‚ÌŒë‚è‚Å‚·BF)
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002017);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "ŒŸõ—pƒJƒi©–¼", objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case29 when case29 == ABAtenaRuisekiEntity.SEARCHKANASEI:      // ŒŸõ—pƒJƒi©
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾(‰p”ŽšE”¼ŠpƒJƒi€–Ú“ü—Í‚ÌŒë‚è‚Å‚·BF)
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002017);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "ŒŸõ—pƒJƒi©", objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case30 when case30 == ABAtenaRuisekiEntity.SEARCHKANAMEI:      // ŒŸõ—pƒJƒi–¼
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾(‰p”ŽšE”¼ŠpƒJƒi€–Ú“ü—Í‚ÌŒë‚è‚Å‚·BF)
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002017);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "ŒŸõ—pƒJƒi–¼", objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case31 when case31 == ABAtenaRuisekiEntity.JUKIRRKNO:          // ZŠî—š—ð”Ô†
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKIRRKNO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    // Case ABAtenaRuisekiEntity.UMAREYMD           '¶”NŒŽ“ú
                    // If Not (strValue = String.Empty Or strValue = "00000000") Then
                    // m_cfDateClass.p_strDateValue = strValue
                    // If (Not m_cfDateClass.CheckDate()) Then
                    // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                    // m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                    // objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_UMAREYMD)
                    // '—áŠO‚ð¶¬
                    // Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                    // End If
                    // End If

                    // Case ABAtenaRuisekiEntity.UMAREWMD           '¶˜a—ï”NŒŽ“ú
                    // If (Not UFStringClass.CheckNumber(strValue)) Then
                    // 'ƒGƒ‰[’è‹`‚ðŽæ“¾(”Žš€–Ú“ü—Í‚ÌŒë‚è‚Å‚·BF)
                    // m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                    // objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002013)
                    // '—áŠO‚ð¶¬
                    // Throw New UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "¶˜a—ï”NŒŽ“ú", objErrorStruct.m_strErrorCode)
                    // End If

                    case var case32 when case32 == ABAtenaRuisekiEntity.SEIBETSUCD:         // «•ÊƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SEIBETSUCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case33 when case33 == ABAtenaRuisekiEntity.SEIBETSU:           // «•Ê
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SEIBETSU);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case34 when case34 == ABAtenaRuisekiEntity.SEKINO:             // Ð”Ô†
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SEKINO);
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case35 when case35 == ABAtenaRuisekiEntity.JUMINHYOHYOJIJUN:   // Z–¯•[•\Ž¦‡
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUMINHYOHYOJIJUN);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case36 when case36 == ABAtenaRuisekiEntity.ZOKUGARACD:         // ‘±•¿ƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue.TrimEnd()))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_ZOKUGARACD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case37 when case37 == ABAtenaRuisekiEntity.ZOKUGARA:           // ‘±•¿
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_ZOKUGARA);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case38 when case38 == ABAtenaRuisekiEntity.DAI2JUMINHYOHYOJIJUN:     // ‘æ‚QZ–¯•[•\Ž¦‡
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_DAI2JUMINHYOHYOJIJUN);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case39 when case39 == ABAtenaRuisekiEntity.DAI2ZOKUGARACD:           // ‘æ‚Q‘±•¿ƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue.TrimEnd()))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_DAI2ZOKUGARACD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case40 when case40 == ABAtenaRuisekiEntity.DAI2ZOKUGARA:             // ‘æ‚Q‘±•¿
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_DAI2ZOKUGARA);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case41 when case41 == ABAtenaRuisekiEntity.STAINUSJUMINCD:     // ¢‘ÑŽåZ–¯ƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_STAINUSJUMINCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case42 when case42 == ABAtenaRuisekiEntity.STAINUSMEI:         // ¢‘ÑŽå–¼
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_STAINUSMEI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case43 when case43 == ABAtenaRuisekiEntity.KANASTAINUSMEI:     // ƒJƒi¢‘ÑŽå–¼
                        {
                            // *—š—ð”Ô† 000008 2003/10/30 C³ŠJŽn
                            // If (Not UFStringClass.CheckKataKana(strValue)) Then
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // *—š—ð”Ô† 000008 2003/10/30 C³I—¹
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KANASTAINUSMEI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case44 when case44 == ABAtenaRuisekiEntity.DAI2STAINUSJUMINCD:       // ‘æ‚Q¢‘ÑŽåZ–¯ƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_DAI2STAINUSJUMINCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case45 when case45 == ABAtenaRuisekiEntity.DAI2STAINUSMEI:           // ‘æ‚Q¢‘ÑŽå–¼
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_DAI2STAINUSMEI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case46 when case46 == ABAtenaRuisekiEntity.KANADAI2STAINUSMEI:       // ‘æ‚QƒJƒi¢‘ÑŽå–¼
                        {
                            // *—š—ð”Ô† 000008 2003/10/30 C³ŠJŽn
                            // If (Not UFStringClass.CheckKataKana(strValue)) Then
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // *—š—ð”Ô† 000008 2003/10/30 C³I—¹
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KANADAI2STAINUSMEI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case47 when case47 == ABAtenaRuisekiEntity.YUBINNO:            // —X•Ö”Ô†
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_YUBINNO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case48 when case48 == ABAtenaRuisekiEntity.JUSHOCD:            // ZŠƒR[ƒh
                        {
                            if (!UFStringClass.CheckANK(strValue.TrimStart()))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUSHOCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case49 when case49 == ABAtenaRuisekiEntity.JUSHO:              // ZŠ
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUSHO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case50 when case50 == ABAtenaRuisekiEntity.BANCHICD1:          // ”Ô’nƒR[ƒh1
                        {
                            if (!UFStringClass.CheckANK(strValue.TrimStart()))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_BANCHICD1);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case51 when case51 == ABAtenaRuisekiEntity.BANCHICD2:          // ”Ô’nƒR[ƒh2
                        {
                            if (!UFStringClass.CheckANK(strValue.TrimStart()))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_BANCHICD2);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case52 when case52 == ABAtenaRuisekiEntity.BANCHICD3:          // ”Ô’nƒR[ƒh3
                        {
                            if (!UFStringClass.CheckANK(strValue.TrimStart()))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_BANCHICD3);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case53 when case53 == ABAtenaRuisekiEntity.BANCHI:             // ”Ô’n
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_BANCHI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case54 when case54 == ABAtenaRuisekiEntity.KATAGAKIFG:         // •û‘ƒtƒ‰ƒO
                        {
                            if (!string.IsNullOrEmpty(strValue.Trim()))
                            {
                                if (!UFStringClass.CheckNumber(strValue))
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KATAGAKIFG);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case55 when case55 == ABAtenaRuisekiEntity.KATAGAKICD:         // •û‘ƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue.TrimStart()))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KATAGAKICD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case56 when case56 == ABAtenaRuisekiEntity.KATAGAKI:           // •û‘
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KATAGAKI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case57 when case57 == ABAtenaRuisekiEntity.RENRAKUSAKI1:       // ˜A—æ1
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_RENRAKUSAKI1);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case58 when case58 == ABAtenaRuisekiEntity.RENRAKUSAKI2:       // ˜A—æ2
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_RENRAKUSAKI2);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case59 when case59 == ABAtenaRuisekiEntity.HON_ZJUSHOCD:       // –{Ð‘S‘ZŠƒR[ƒh
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_HON_ZJUSHOCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case60 when case60 == ABAtenaRuisekiEntity.HON_JUSHO:          // –{ÐZŠ
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_HON_JUSHO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case61 when case61 == ABAtenaRuisekiEntity.HONSEKIBANCHI:      // –{Ð”Ô’n
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_HONSEKIBANCHI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case62 when case62 == ABAtenaRuisekiEntity.HITTOSH:            // •M“ªŽÒ
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_HITTOSH);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case63 when case63 == ABAtenaRuisekiEntity.CKINIDOYMD:         // ’¼‹ßˆÙ“®”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_CKINIDOYMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case64 when case64 == ABAtenaRuisekiEntity.CKINJIYUCD:         // ’¼‹ßŽ–—RƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_CKINJIYUCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case65 when case65 == ABAtenaRuisekiEntity.CKINJIYU:           // ’¼‹ßŽ–—R
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_CKINJIYU);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case66 when case66 == ABAtenaRuisekiEntity.CKINTDKDYMD:        // ’¼‹ß“Ío”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_CKINTDKDYMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case67 when case67 == ABAtenaRuisekiEntity.CKINTDKDTUCIKB:     // ’¼‹ß“Ío’Ê’m‹æ•ª
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_CKINTDKDTUCIKB);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case68 when case68 == ABAtenaRuisekiEntity.TOROKUIDOYMD:       // “o˜^ˆÙ“®”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TOROKUIDOYMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case69 when case69 == ABAtenaRuisekiEntity.TOROKUIDOWMD:       // “o˜^ˆÙ“®˜a—ï”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "0000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TOROKUIDOWMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case70 when case70 == ABAtenaRuisekiEntity.TOROKUJIYUCD:       // “o˜^Ž–—RƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TOROKUJIYUCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case71 when case71 == ABAtenaRuisekiEntity.TOROKUJIYU:         // “o˜^Ž–—R
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TOROKUJIYU);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case72 when case72 == ABAtenaRuisekiEntity.TOROKUTDKDYMD:      // “o˜^“Ío”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TOROKUTDKDYMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case73 when case73 == ABAtenaRuisekiEntity.TOROKUTDKDWMD:      // “o˜^“Ío˜a—ï”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "0000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TOROKUTDKDWMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case74 when case74 == ABAtenaRuisekiEntity.TOROKUTDKDTUCIKB:   // “o˜^“Ío’Ê’m‹æ•ª
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TOROKUTDKDTUCIKB);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case75 when case75 == ABAtenaRuisekiEntity.JUTEIIDOYMD:        // Z’èˆÙ“®”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUTEIIDOYMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case76 when case76 == ABAtenaRuisekiEntity.JUTEIIDOWMD:        // Z’èˆÙ“®˜a—ï”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "0000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUTEIIDOWMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case77 when case77 == ABAtenaRuisekiEntity.JUTEIJIYUCD:        // Z’èŽ–—RƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUTEIJIYUCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case78 when case78 == ABAtenaRuisekiEntity.JUTEIJIYU:          // Z’èŽ–—R
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUTEIJIYU);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case79 when case79 == ABAtenaRuisekiEntity.JUTEITDKDYMD:       // Z’è“Ío”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUTEITDKDYMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case80 when case80 == ABAtenaRuisekiEntity.JUTEITDKDWMD:       // Z’è“Ío˜a—ï”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "0000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUTEITDKDWMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case81 when case81 == ABAtenaRuisekiEntity.JUTEITDKDTUCIKB:    // Z’è“Ío’Ê’m‹æ•ª
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUTEITDKDTUCIKB);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case82 when case82 == ABAtenaRuisekiEntity.SHOJOIDOYMD:        // ÁœˆÙ“®”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SHOJOIDOYMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case83 when case83 == ABAtenaRuisekiEntity.SHOJOJIYUCD:        // ÁœŽ–—RƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SHOJOJIYUCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case84 when case84 == ABAtenaRuisekiEntity.SHOJOJIYU:          // ÁœŽ–—R
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SHOJOJIYU);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case85 when case85 == ABAtenaRuisekiEntity.SHOJOTDKDYMD:       // Áœ“Ío”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SHOJOTDKDYMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case86 when case86 == ABAtenaRuisekiEntity.SHOJOTDKDTUCIKB:    // Áœ“Ío’Ê’m‹æ•ª
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SHOJOTDKDTUCIKB);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case87 when case87 == ABAtenaRuisekiEntity.TENSHUTSUYOTEIIDOYMD:     // “]o—\’è“Ío”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUYOTEIIDOYMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case88 when case88 == ABAtenaRuisekiEntity.TENSHUTSUKKTIIDOYMD:      // “]oŠm’è“Ío”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUKKTIIDOYMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case89 when case89 == ABAtenaRuisekiEntity.TENSHUTSUKKTITSUCHIYMD:   // “]oŠm’è’Ê’m”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUKKTITSUCHIYMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case90 when case90 == ABAtenaRuisekiEntity.TENSHUTSUNYURIYUCD:       // “]o“ü——RƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUNYURIYUCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case91 when case91 == ABAtenaRuisekiEntity.TENSHUTSUNYURIYU:         // “]o“ü——R
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUNYURIYU);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case92 when case92 == ABAtenaRuisekiEntity.TENUMAEJ_YUBINNO:         // “]“ü‘OZŠ—X•Ö”Ô†
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENUMAEJ_YUBINNO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case93 when case93 == ABAtenaRuisekiEntity.TENUMAEJ_ZJUSHOCD:        // “]“ü‘OZŠ‘S‘ZŠƒR[ƒh
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENUMAEJ_ZJUSHOCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case94 when case94 == ABAtenaRuisekiEntity.TENUMAEJ_JUSHO:           // “]“ü‘OZŠZŠ
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENUMAEJ_JUSHO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case95 when case95 == ABAtenaRuisekiEntity.TENUMAEJ_BANCHI:          // “]“ü‘OZŠ”Ô’n
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENUMAEJ_BANCHI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case96 when case96 == ABAtenaRuisekiEntity.TENUMAEJ_KATAGAKI:        // “]“ü‘OZŠ•û‘
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENUMAEJ_KATAGAKI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case97 when case97 == ABAtenaRuisekiEntity.TENUMAEJ_STAINUSMEI:      // “]“ü‘OZŠ¢‘ÑŽå–¼
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENUMAEJ_STAINUSMEI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case98 when case98 == ABAtenaRuisekiEntity.TENSHUTSUYOTEIYUBINNO:    // “]o—\’è—X•Ö”Ô†
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUYOTEIYUBINNO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case99 when case99 == ABAtenaRuisekiEntity.TENSHUTSUYOTEIZJUSHOCD:   // “]o—\’è‘S‘ZŠƒR[ƒh
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUYOTEIZJUSHOCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case100 when case100 == ABAtenaRuisekiEntity.TENSHUTSUYOTEIJUSHO:      // “]o—\’èZŠ
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUYOTEIJUSHO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case101 when case101 == ABAtenaRuisekiEntity.TENSHUTSUYOTEIBANCHI:     // “]o—\’è”Ô’n
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUYOTEIBANCHI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case102 when case102 == ABAtenaRuisekiEntity.TENSHUTSUYOTEIKATAGAKI:   // “]o—\’è•û‘
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUYOTEIKATAGAKI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case103 when case103 == ABAtenaRuisekiEntity.TENSHUTSUYOTEISTAINUSMEI: // “]o—\’è¢‘ÑŽå–¼
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUYOTEISTAINUSMEI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case104 when case104 == ABAtenaRuisekiEntity.TENSHUTSUKKTIYUBINNO:     // “]oŠm’è—X•Ö”Ô†
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUKKTIYUBINNO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case105 when case105 == ABAtenaRuisekiEntity.TENSHUTSUKKTIZJUSHOCD:    // “]oŠm’è‘S‘ZŠƒR[ƒh
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUKKTIZJUSHOCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case106 when case106 == ABAtenaRuisekiEntity.TENSHUTSUKKTIJUSHO:     // “]oŠm’èZŠ
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUKKTIJUSHO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case107 when case107 == ABAtenaRuisekiEntity.TENSHUTSUKKTIBANCHI:      // “]oŠm’è”Ô’n
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUKKTIBANCHI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case108 when case108 == ABAtenaRuisekiEntity.TENSHUTSUKKTIKATAGAKI:    // “]oŠm’è•û‘
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUKKTIKATAGAKI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case109 when case109 == ABAtenaRuisekiEntity.TENSHUTSUKKTISTAINUSMEI:  // “]oŠm’è¢‘ÑŽå–¼
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUKKTISTAINUSMEI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case110 when case110 == ABAtenaRuisekiEntity.TENSHUTSUKKTIMITDKFG:     // “]oŠm’è–¢“Íƒtƒ‰ƒO
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TENSHUTSUKKTIMITDKFG);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case111 when case111 == ABAtenaRuisekiEntity.BIKOYMD:                  // ”õl”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_BIKOYMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case112 when case112 == ABAtenaRuisekiEntity.BIKO:                     // ”õl
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_BIKO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case113 when case113 == ABAtenaRuisekiEntity.BIKOTENSHUTSUKKTIJUSHOFG: // ”õl“]oŠm’èZŠƒtƒ‰ƒO
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_BIKOTENSHUTSUKKTIJUSHOFG);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case114 when case114 == ABAtenaRuisekiEntity.HANNO:                    // ”Å”Ô†
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_HANNO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case115 when case115 == ABAtenaRuisekiEntity.KAISEIATOFG:              // ‰ü»Œãƒtƒ‰ƒO
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KAISEIATOFG);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case116 when case116 == ABAtenaRuisekiEntity.KAISEIMAEFG:             // ‰ü»‘Oƒtƒ‰ƒO
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KAISEIMAEFG);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case117 when case117 == ABAtenaRuisekiEntity.KAISEIYMD:                // ‰ü»”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KAISEIYMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case118 when case118 == ABAtenaRuisekiEntity.GYOSEIKUCD:               // s­‹æƒR[ƒh
                        {
                            // * —š—ð”Ô† 000014 2005/12/26 C³ŠJŽn
                            // 'If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                            if (!UFStringClass.CheckANK(strValue.TrimStart()))
                            {
                                // * —š—ð”Ô† 000014 2005/12/26 C³I—¹
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_GYOSEIKUCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case119 when case119 == ABAtenaRuisekiEntity.GYOSEIKUMEI:              // s­‹æ–¼
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_GYOSEIKUMEI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case120 when case120 == ABAtenaRuisekiEntity.CHIKUCD1:                 // ’n‹æƒR[ƒh1
                        {
                            // *—š—ð”Ô† 00012 2004/08/13 C³ŠJŽn
                            if (!UFStringClass.CheckANK(strValue.TrimStart()))
                            {
                                // *—š—ð”Ô† 00012 2004/08/13 C³I—¹
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_CHIKUCD1);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case121 when case121 == ABAtenaRuisekiEntity.CHIKUMEI1:                // ’n‹æ–¼1
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_CHIKUMEI1);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case122 when case122 == ABAtenaRuisekiEntity.CHIKUCD2:                 // ’n‹æƒR[ƒh2
                        {
                            // *—š—ð”Ô† 00012 2004/08/13 C³ŠJŽn
                            if (!UFStringClass.CheckANK(strValue.TrimStart()))
                            {
                                // *—š—ð”Ô† 00012 2004/08/13 C³I—¹
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_CHIKUCD2);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case123 when case123 == ABAtenaRuisekiEntity.CHIKUMEI2:                // ’n‹æ–¼2
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_CHIKUMEI2);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case124 when case124 == ABAtenaRuisekiEntity.CHIKUCD3:                 // ’n‹æƒR[ƒh3
                        {
                            // *—š—ð”Ô† 00012 2004/08/13 C³ŠJŽn
                            if (!UFStringClass.CheckANK(strValue.TrimStart()))
                            {
                                // *—š—ð”Ô† 00012 2004/08/13 C³I—¹
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_CHIKUCD3);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case125 when case125 == ABAtenaRuisekiEntity.CHIKUMEI3:                // ’n‹æ–¼3
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_CHIKUMEI3);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case126 when case126 == ABAtenaRuisekiEntity.TOHYOKUCD:                // “Š•[‹æƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue.TrimStart()))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TOHYOKUCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case127 when case127 == ABAtenaRuisekiEntity.SHOGAKKOKUCD:             // ¬ŠwZ‹æƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue.TrimStart()))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SHOGAKKOKUCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case128 when case128 == ABAtenaRuisekiEntity.CHUGAKKOKUCD:             // ’†ŠwZ‹æƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue.TrimStart()))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_CHUGAKKOKUCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case129 when case129 == ABAtenaRuisekiEntity.HOGOSHAJUMINCD:           // •ÛŒìŽÒZ–¯ƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_HOGOSHAJUMINCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case130 when case130 == ABAtenaRuisekiEntity.KANJIHOGOSHAMEI:          // Š¿Žš•ÛŒìŽÒ–¼
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KANJIHOGOSHAMEI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case131 when case131 == ABAtenaRuisekiEntity.KANAHOGOSHAMEI:           // ƒJƒi•ÛŒìŽÒ–¼
                        {
                            // *—š—ð”Ô† 000008 2003/10/30 C³ŠJŽn
                            // If (Not UFStringClass.CheckKataKana(strValue)) Then
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // *—š—ð”Ô† 000008 2003/10/30 C³I—¹
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KANAHOGOSHAMEI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case132 when case132 == ABAtenaRuisekiEntity.KIKAYMD:                  // ‹A‰»”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KIKAYMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case133 when case133 == ABAtenaRuisekiEntity.KARIIDOKB:                // ‰¼ˆÙ“®‹æ•ª
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KARIIDOKB);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case134 when case134 == ABAtenaRuisekiEntity.SHORITEISHIKB:            // ˆ—’âŽ~‹æ•ª
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SHORITEISHIKB);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case135 when case135 == ABAtenaRuisekiEntity.JUKIYUBINNO:              // ZŠî—X•Ö”Ô†
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKIYUBINNO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case136 when case136 == ABAtenaRuisekiEntity.SHORIYOKUSHIKB:           // ˆ——}Ž~‹æ•ª
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SHORIYOKUSHIKB);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case137 when case137 == ABAtenaRuisekiEntity.JUKIJUSHOCD:              // ZŠîZŠƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue.TrimStart()))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKIJUSHOCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case138 when case138 == ABAtenaRuisekiEntity.JUKIJUSHO:                // ZŠîZŠ
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKIJUSHO);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case139 when case139 == ABAtenaRuisekiEntity.JUKIBANCHICD1:            // ZŠî”Ô’nƒR[ƒh1
                        {
                            if (!UFStringClass.CheckANK(strValue.TrimStart()))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKIBANCHICD1);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case140 when case140 == ABAtenaRuisekiEntity.JUKIBANCHICD2:            // ZŠî”Ô’nƒR[ƒh2
                        {
                            if (!UFStringClass.CheckANK(strValue.TrimStart()))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKIBANCHICD2);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case141 when case141 == ABAtenaRuisekiEntity.JUKIBANCHICD3:            // ZŠî”Ô’nƒR[ƒh3
                        {
                            if (!UFStringClass.CheckANK(strValue.TrimStart()))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKIBANCHICD3);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case142 when case142 == ABAtenaRuisekiEntity.JUKIBANCHI:               // ZŠî”Ô’n
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKIBANCHI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case143 when case143 == ABAtenaRuisekiEntity.JUKIKATAGAKIFG:           // ZŠî•û‘ƒtƒ‰ƒO
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKIKATAGAKIFG);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case144 when case144 == ABAtenaRuisekiEntity.JUKIKATAGAKICD:           // ZŠî•û‘ƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue.TrimStart()))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKIKATAGAKICD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case145 when case145 == ABAtenaRuisekiEntity.JUKIKATAGAKI:             // ZŠî•û‘
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKIKATAGAKI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case146 when case146 == ABAtenaRuisekiEntity.JUKIGYOSEIKUCD:           // ZŠîs­‹æƒR[ƒh
                        {
                            // * —š—ð”Ô† 000014 2005/12/26 C³ŠJŽn
                            // 'If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                            if (!UFStringClass.CheckANK(strValue.TrimStart()))
                            {
                                // * —š—ð”Ô† 000014 2005/12/26 C³I—¹
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKIGYOSEIKUCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case147 when case147 == ABAtenaRuisekiEntity.JUKIGYOSEIKUMEI:          // ZŠîs­‹æ–¼
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKIGYOSEIKUMEI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case148 when case148 == ABAtenaRuisekiEntity.JUKICHIKUCD1:                    // ZŠî’n‹æƒR[ƒh1
                        {
                            // *—š—ð”Ô† 00012 2004/08/13 C³ŠJŽn
                            if (!UFStringClass.CheckANK(strValue.TrimStart()))
                            {
                                // *—š—ð”Ô† 00012 2004/08/13 C³I—¹
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKICHIKUCD1);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case149 when case149 == ABAtenaRuisekiEntity.JUKICHIKUMEI1:            // ZŠî’n‹æ–¼1
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKICHIKUMEI1);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case150 when case150 == ABAtenaRuisekiEntity.JUKICHIKUCD2:             // ZŠî’n‹æƒR[ƒh2
                        {
                            // *—š—ð”Ô† 00012 2004/08/13 C³ŠJŽn
                            if (!UFStringClass.CheckANK(strValue.TrimStart()))
                            {
                                // *—š—ð”Ô† 00012 2004/08/13 C³I—¹
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKICHIKUCD2);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case151 when case151 == ABAtenaRuisekiEntity.JUKICHIKUMEI2:            // ZŠî’n‹æ–¼2
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKICHIKUMEI2);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case152 when case152 == ABAtenaRuisekiEntity.JUKICHIKUCD3:             // ZŠî’n‹æƒR[ƒh3
                        {
                            // *—š—ð”Ô† 00012 2004/08/13 C³ŠJŽn
                            if (!UFStringClass.CheckANK(strValue.TrimStart()))
                            {
                                // *—š—ð”Ô† 00012 2004/08/13 C³I—¹
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKICHIKUCD3);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case153 when case153 == ABAtenaRuisekiEntity.JUKICHIKUMEI3:            // ZŠî’n‹æ–¼3
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_JUKICHIKUMEI3);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case154 when case154 == ABAtenaRuisekiEntity.KAOKUSHIKIKB:             // ‰Æ‰®•~‹æ•ª
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KAOKUSHIKIKB);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case155 when case155 == ABAtenaRuisekiEntity.BIKOZEIMOKU:              // ”õlÅ–Ú
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_BIKOZEIMOKU);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case156 when case156 == ABAtenaRuisekiEntity.KOKUSEKICD:               // ‘ÐƒR[ƒh
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KOKUSEKICD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case157 when case157 == ABAtenaRuisekiEntity.KOKUSEKI:                 // ‘Ð
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KOKUSEKI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case158 when case158 == ABAtenaRuisekiEntity.ZAIRYUSKAKCD:             // Ý—¯Ž‘ŠiƒR[ƒh
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_ZAIRYUSKAKCD);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case159 when case159 == ABAtenaRuisekiEntity.ZAIRYUSKAK:               // Ý—¯Ž‘Ši
                        {
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_ZAIRYUSKAK);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case160 when case160 == ABAtenaRuisekiEntity.ZAIRYUKIKAN:              // Ý—¯ŠúŠÔ
                        {
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_ZAIRYUKIKAN);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case161 when case161 == ABAtenaRuisekiEntity.ZAIRYU_ST_YMD:            // Ý—¯ŠJŽn”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_ZAIRYU_ST_YMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case162 when case162 == ABAtenaRuisekiEntity.ZAIRYU_ED_YMD:            // Ý—¯I—¹”NŒŽ“ú
                        {
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_ZAIRYU_ED_YMD);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    // *—š—ð”Ô† 000009 2003/11/18 ’Ç‰ÁŠJŽn
                    case var case163 when case163 == ABAtenaRuisekiEntity.KSNENKNNO:
                    case var case164 when case164 == ABAtenaRuisekiEntity.JKYNENKNKIGO1:
                    case var case165 when case165 == ABAtenaRuisekiEntity.JKYNENKNNO1:
                    case var case166 when case166 == ABAtenaRuisekiEntity.JKYNENKNEDABAN1:
                    case var case167 when case167 == ABAtenaRuisekiEntity.JKYNENKNKB1:
                    case var case168 when case168 == ABAtenaRuisekiEntity.JKYNENKNKIGO2:
                    case var case169 when case169 == ABAtenaRuisekiEntity.JKYNENKNNO2:
                    case var case170 when case170 == ABAtenaRuisekiEntity.JKYNENKNEDABAN2:
                    case var case171 when case171 == ABAtenaRuisekiEntity.JKYNENKNKB2:
                    case var case172 when case172 == ABAtenaRuisekiEntity.JKYNENKNKIGO3:
                    case var case173 when case173 == ABAtenaRuisekiEntity.JKYNENKNNO3:
                    case var case174 when case174 == ABAtenaRuisekiEntity.JKYNENKNEDABAN3:
                    case var case175 when case175 == ABAtenaRuisekiEntity.JKYNENKNKB3:
                    case var case176 when case176 == ABAtenaRuisekiEntity.KOKUHOSHIKAKUKB:
                        {
                            // Šî‘b”N‹à”Ô†
                            // Žó‹‹”N‹à‹L†‚P
                            // Žó‹‹”N‹à”Ô†‚P
                            // Žó‹‹”N‹àŽ}”Ô‚P
                            // Žó‹‹”N‹à‹æ•ª‚P
                            // Žó‹‹”N‹à‹L†‚Q
                            // Žó‹‹”N‹à”Ô†‚Q
                            // Žó‹‹”N‹àŽ}”Ô‚Q
                            // Žó‹‹”N‹à‹æ•ª‚Q
                            // Žó‹‹”N‹à‹L†‚R
                            // Žó‹‹”N‹à”Ô†‚R
                            // Žó‹‹”N‹àŽ}”Ô‚R
                            // Žó‹‹”N‹à‹æ•ª‚R
                            // ‘•ÛŽ‘Ši‹æ•ª
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002013);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage + strColumnName, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case177 when case177 == ABAtenaRuisekiEntity.NENKNSKAKSHUTKYMD:
                    case var case178 when case178 == ABAtenaRuisekiEntity.NENKNSKAKSSHTSYMD:
                    case var case179 when case179 == ABAtenaRuisekiEntity.KOKUHOSHUTOKUYMD:
                    case var case180 when case180 == ABAtenaRuisekiEntity.KOKUHOSOSHITSUYMD:
                    case var case181 when case181 == ABAtenaRuisekiEntity.KOKUHOTISHKGAITOYMD:
                    case var case182 when case182 == ABAtenaRuisekiEntity.KOKUHOTISHKHIGAITOYMD:
                        {
                            // ”N‹àŽ‘ŠiŽæ“¾”NŒŽ“ú
                            // ”N‹àŽ‘Ši‘rŽ¸”NŒŽ“ú
                            // ‘•ÛŽæ“¾”NŒŽ“ú
                            // ‘•Û‘rŽ¸”NŒŽ“ú
                            // ‘•Û‘ÞEŠY“–”NŒŽ“ú
                            // ‘•Û‘ÞE”ñŠY“–”NŒŽ“ú
                            if (!(string.IsNullOrEmpty(strValue) | strValue == "00000000"))
                            {
                                m_cfDateClass.p_strDateValue = strValue;
                                if (!m_cfDateClass.CheckDate())
                                {
                                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002019);
                                    // —áŠO‚ð¶¬
                                    throw new UFAppException(objErrorStruct.m_strErrorMessage + strColumnName, objErrorStruct.m_strErrorCode);
                                }
                            }

                            break;
                        }

                    case var case183 when case183 == ABAtenaRuisekiEntity.NENKNSKAKSHUTKSHU:
                    case var case184 when case184 == ABAtenaRuisekiEntity.NENKNSKAKSHUTKRIYUCD:
                    case var case185 when case185 == ABAtenaRuisekiEntity.NENKNSKAKSSHTSRIYUCD:
                    case var case186 when case186 == ABAtenaRuisekiEntity.JKYNENKNSHU1:
                    case var case187 when case187 == ABAtenaRuisekiEntity.JKYNENKNSHU2:
                    case var case188 when case188 == ABAtenaRuisekiEntity.JKYNENKNSHU3:
                    case var case189 when case189 == ABAtenaRuisekiEntity.KOKUHONO:
                    case var case190 when case190 == ABAtenaRuisekiEntity.KOKUHOGAKUENKB:
                    case var case191 when case191 == ABAtenaRuisekiEntity.KOKUHOTISHKKB:
                    case var case192 when case192 == ABAtenaRuisekiEntity.KOKUHOTISHKHONHIKB:
                        {
                            // ”N‹àŽ‘ŠiŽæ“¾Ží•Ê
                            // ”N‹àŽ‘ŠiŽæ“¾——RƒR[ƒh
                            // ”N‹àŽ‘Ši‘rŽ¸——RƒR[ƒh
                            // Žó‹‹”N‹àŽí•Ê‚P
                            // Žó‹‹”N‹àŽí•Ê‚Q
                            // Žó‹‹”N‹àŽí•Ê‚R
                            // ‘•Û”Ô†
                            // ‘•ÛŠw‰“‹æ•ª
                            // ‘•Û‘ÞE‹æ•ª
                            // ‘•Û‘ÞE–{”í‹æ•ª
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002017);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage + strColumnName, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    // *—š—ð”Ô† 000010 2003/12/01 C³ŠJŽn
                    // Case ABAtenaRuisekiEntity.KOKUHOSHIKAKUKBMEISHO, _
                    // ABAtenaRuisekiEntity.KOKUHOSHIKAKUKBRYAKUSHO, _
                    // ABAtenaRuisekiEntity.KOKUHOGAKUENKBMEISHO, _
                    // ABAtenaRuisekiEntity.KOKUHOGAKUENKBRYAKUSHO, _
                    // ABAtenaRuisekiEntity.KOKUHOTISHKKBMEISHO, _
                    // ABAtenaRuisekiEntity.KOKUHOTISHKKBRYAKUSHO, _
                    // ABAtenaRuisekiEntity.KOKUHOTIAHKHONHIKBMEISHO, _
                    // ABAtenaRuisekiEntity.KOKUHOTISHKHONHIKBRYAKUSHO, _
                    // ABAtenaRuisekiEntity.KOKUHOHOKENSHOKIGO, _
                    // ABAtenaRuisekiEntity.KOKUHOHOKENSHONO
                    case var case193 when case193 == ABAtenaRuisekiEntity.KOKUHOSHIKAKUKBMEISHO:
                    case var case194 when case194 == ABAtenaRuisekiEntity.KOKUHOSHIKAKUKBRYAKUSHO:
                    case var case195 when case195 == ABAtenaRuisekiEntity.KOKUHOGAKUENKBMEISHO:
                    case var case196 when case196 == ABAtenaRuisekiEntity.KOKUHOGAKUENKBRYAKUSHO:
                    case var case197 when case197 == ABAtenaRuisekiEntity.KOKUHOTISHKKBMEISHO:
                    case var case198 when case198 == ABAtenaRuisekiEntity.KOKUHOTISHKKBRYAKUSHO:
                    case var case199 when case199 == ABAtenaRuisekiEntity.KOKUHOTISHKHONHIKBMEISHO:
                    case var case200 when case200 == ABAtenaRuisekiEntity.KOKUHOTISHKHONHIKBRYAKUSHO:
                    case var case201 when case201 == ABAtenaRuisekiEntity.KOKUHOHOKENSHOKIGO: // , _
                        {
                            // *—š—ð”Ô† 000011 2004/03/06 C³ŠJŽn
                            // ABAtenaRuisekiEntity.KOKUHOHOKENSHONO
                            // *—š—ð”Ô† 000011 2004/03/06 C³ŠJŽn
                            // *—š—ð”Ô† 000010 2003/12/01 C³I—¹
                            // ‘•ÛŽ‘Ši‹æ•ª³Ž®–¼Ì
                            // ‘•ÛŽ‘Ši‹æ•ª—ªŽ®–¼Ì
                            // ‘•ÛŠw‰“‹æ•ª³Ž®–¼Ì
                            // ‘•ÛŠw‰“‹æ•ª—ªŽ®–¼Ì
                            // ‘•Û‘ÞE‹æ•ª³Ž®–¼Ì
                            // ‘•Û‘ÞE‹æ•ª—ªŽ®–¼Ì
                            // ‘•Û‘ÞE–{”í‹æ•ª³Ž®–¼Ì
                            // ‘•Û‘ÞE–{”í‹æ•ª—ªŽ®–¼Ì
                            // ‘•Û•ÛŒ¯Ø‹L†
                            // ‘•Û•ÛŒ¯Ø”Ô†
                            if (!UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002011);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage + strColumnName, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    // *—š—ð”Ô† 000009 2003/11/18 ’Ç‰ÁI—¹

                    case var case202 when case202 == ABAtenaRuisekiEntity.RESERCE:                  // ƒŠƒU[ƒu
                        {
                            break;
                        }
                    // ƒ`ƒFƒbƒN‚È‚µ

                    case var case203 when case203 == ABAtenaRuisekiEntity.TANMATSUID:               // ’[––‚h‚c
                        {
                            // * —š—ð”Ô† 000006 2003/09/11 C³ŠJŽn
                            // If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // * —š—ð”Ô† 000006 2003/09/11 C³I—¹
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_TANMATSUID);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case204 when case204 == ABAtenaRuisekiEntity.SAKUJOFG:                 // íœƒtƒ‰ƒO
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SAKUJOFG);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case205 when case205 == ABAtenaRuisekiEntity.KOSHINCOUNTER:            // XVƒJƒEƒ“ƒ^
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KOSHINCOUNTER);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case206 when case206 == ABAtenaRuisekiEntity.SAKUSEINICHIJI:           // ì¬“úŽž
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SAKUSEINICHIJI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case207 when case207 == ABAtenaRuisekiEntity.SAKUSEIUSER:              // ì¬ƒ†[ƒU
                        {
                            // * —š—ð”Ô† 000007 2003/10/09 C³ŠJŽn
                            // If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // * —š—ð”Ô† 000007 2003/10/09 C³I—¹
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_SAKUSEIUSER);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case208 when case208 == ABAtenaRuisekiEntity.KOSHINNICHIJI:            // XV“úŽž
                        {
                            if (!UFStringClass.CheckNumber(strValue))
                            {
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KOSHINNICHIJI);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                    case var case209 when case209 == ABAtenaRuisekiEntity.KOSHINUSER:               // XVƒ†[ƒU
                        {
                            // * —š—ð”Ô† 000007 2003/10/09 C³ŠJŽn
                            // If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                            if (!UFStringClass.CheckANK(strValue))
                            {
                                // * —š—ð”Ô† 000007 2003/10/09 C³I—¹
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENARUISEKIB_RDBDATATYPE_KOSHINUSER);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }

                            break;
                        }

                }
            }

            // ƒfƒoƒbƒOI—¹ƒƒOo—Í
            // m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 176478


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 176576


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 176838


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 176923


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }

        // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼       ZŠî–@‰ü³Ì×¸ÞŽæ“¾
        // * 
        // * \•¶             Private Function GetJukihoKaiseiFG()
        // * 
        // * ‹@”\@@    @   ŠÇ—î•ñ‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”             ‚È‚µ
        // * 
        // * –ß‚è’l           ‚È‚µ
        // ************************************************************************************************
        private void GetJukihoKaiseiFG()
        {
            const string THIS_METHOD_NAME = "GetJukihoKaiseiFG";
            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                if (m_csSekoYMDHanteiB == null)
                {
                    // Ž{s“ú”»’è‚a¸×½‚Ì²Ý½ÀÝ½‰»
                    m_csSekoYMDHanteiB = new ABSekoYMDHanteiBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                    // ZŠî–@‰ü³Ì×¸ÞŽ{s“ú”»’èŒ‹‰Ê
                    m_blnJukihoKaiseiFG = m_csSekoYMDHanteiB.CheckAfterSekoYMD();
                }
                else
                {
                    // ˆ—‚È‚µ
                }

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 179028


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 179126


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 179396


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 179481


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }
        }
        // *—š—ð”Ô† 000016 2011/10/24 ’Ç‰ÁI—¹

        #endregion

    }
}