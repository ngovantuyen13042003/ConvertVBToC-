// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ˆ¶–¼‘•Ûƒ}ƒXƒ^XV(ABAtenaKokuhoupBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/11/12@‹gàV@sé
// * 
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2004/02/26  000001     R‡V˜AŒgiƒ[ƒNƒtƒ[jˆ—‚ð’Ç‰Á
// * 2004/03/08  000002     ZŠîXVˆ——L–³‚Ì”»’è‚ð’Ç‰Á
// * 2004/03/26  000003     ƒrƒWƒlƒXID‚Ì•ÏXC³
// * 2005/12/01  000004     ZŠî‚ÌŒÂ•ÊŽ–€XVŒ‹‰Ê‚ð•]‰¿‚·‚é‚©‚µ‚È‚¢‚©‚Ìˆ—‚ð’Ç‰Á
// * 2010/04/16  000005      VS2008‘Î‰ži”ä‰Ãj
// * 2022/12/16  000006    yAB-8010zZ–¯ƒR[ƒh¢‘ÑƒR[ƒh15Œ…‘Î‰ž(‰º‘º)
// * 2024/02/19  000007    yAB-9001_1zŒÂ•Ê‹LÚŽ–€‘Î‰ž(‰º‘º)
// ************************************************************************************************
using System;
using System.Linq;

namespace Densan.Reams.AB.AB000BB
{

    public class ABAtenaKokuhoupBClass
    {

        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfABConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^AB
        private UFConfigDataClass m_cfAAConfigDataClass;       // ƒRƒ“ƒtƒBƒOƒf[ƒ^AA
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private string m_strRsBusiId;

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABAtenaKokuhoupBClass";
        private const string AA_BUSSINESS_ID = "AA";          // ‹Æ–±ƒR[ƒh
                                                              // *—š—ð”Ô† 000001 2004/02/26 ’Ç‰ÁŠJŽn
        private const string WORK_FLOW_NAME = "ˆ¶–¼‘•ÛŒÂ•ÊŽ–€";             // ƒ[ƒNƒtƒ[–¼
        private const string DATA_NAME = "‘•ÛŒÂ•Ê";                      // ƒf[ƒ^–¼
                                                                          // *—š—ð”Ô† 000001 2004/02/26 ’Ç‰ÁI—¹

        #endregion

        #region ƒRƒ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶            Public Sub New(ByVal cfControlData As UFControlData,
        // * @@                           ByVal cfConfigDataClass As UFConfigDataClass,
        // * @@                           ByVal cfRdbClass As UFRdbClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”            cfControlData As UFControlData         : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@            cfConfigDataClass As UFConfigDataClass : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg 
        // * @@            cfRdbClass As UFRdbClass               : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABAtenaKokuhoupBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

        {
            UFConfigDataClass cfAAUFConfigData;
            UFConfigClass cfAAUFConfigClass;

            // ----------ƒRƒ“ƒtƒBƒOƒf[ƒ^‚Ì"AA"‚ÌŠÂ‹«î•ñ‚ðŽæ“¾----------------------
            cfAAUFConfigClass = new UFConfigClass();
            cfAAUFConfigData = cfAAUFConfigClass.GetConfig(AA_BUSSINESS_ID);
            m_cfAAConfigDataClass = cfAAUFConfigData;
            // ----------ƒRƒ“ƒtƒBƒOƒf[ƒ^‚Ì"AA"‚ÌŠÂ‹«î•ñ‚ðŽæ“¾----------------------

            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfABConfigDataClass = cfConfigDataClass;
            m_cfRdbClass = cfRdbClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(m_cfABConfigDataClass, m_cfControlData.m_strBusinessId);

            // Žó‚¯Žæ‚Á‚½ƒrƒWƒlƒXID‚ðƒƒ“ƒo‚Ö•Û‘¶
            m_strRsBusiId = m_cfControlData.m_strBusinessId;

            // *—š—ð”Ô† 000003 2004/03/26 íœŠJŽn
            // '‹Æ–±ID‚ðˆ¶–¼(AB)‚É•ÏX
            // m_cfControlData.m_strBusinessId = "AB"
            // *—š—ð”Ô† 000003 2004/03/26 íœI—¹

        }

        #endregion

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼‘•Ûƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateAtenaKokuho(ByVal cABKobetsuProperty As ABKobetsuKokuhoProperty) As Integer
        // * 
        // * ‹@”\@@    @  ˆ¶–¼‘•Ûƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚éB
        // * 
        // * ˆø”           cABKobetsuProperty As ABKobetsuProperty  :XVƒf[ƒ^
        // * 
        // * –ß‚è’l         XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateAtenaKokuho(ABKobetsuKokuhoProperty cABKobetsuProperty)
        {
            const string THIS_METHOD_NAME = "UpdateAtenaKokuho";
            int intUpdCnt;
            ABAtenaKokuhoBClass cABAtenaKokuhoBClass;
            var cAAKOBETSUKOKUHOParamClass = new localhost.AAKOBETSUKOKUHOParamClass[1];
            localhost.AACommonBSClass cAACommonBSClass;
            DataSet csABAtenaKokuhoEntity;
            DataRow cDatRow;
            string strControlData;
            var cUSSCItyInfo = new USSCityInfoClass();
            UFErrorClass cfErrorClass;                    // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            UFAppException csAppExp;
            // *—š—ð”Ô† 000001 2004/02/26 ’Ç‰ÁŠJŽn
            ABAtenaKanriJohoBClass cAtenaKanriJohoB;      // ˆ¶–¼ŠÇ—î•ñ‚c‚`ƒrƒWƒlƒXƒNƒ‰ƒX
            DataSet csAtenaKanriEntity;                   // ˆ¶–¼ŠÇ—î•ñƒf[ƒ^ƒZƒbƒg
                                                          // *—š—ð”Ô† 000001 2004/02/26 ’Ç‰ÁI—¹
                                                          // *—š—ð”Ô† 000004 2005/12/01 ’Ç‰ÁŠJŽn
            string strJukiResult;                         // ZŠî‚ÌŒ‹‰Ê‚ðƒ`ƒFƒbƒN‚·‚é‚©‚Ç‚¤‚©(0:‚·‚é 1:‚µ‚È‚¢)
                                                          // *—š—ð”Ô† 000004 2005/12/01 ’Ç‰ÁI—¹

            try
            {

                // *—š—ð”Ô† 000003 2004/03/26 ’Ç‰ÁŠJŽn
                // ‹Æ–±ID‚ðˆ¶–¼(AB)‚É•ÏX
                m_cfControlData.m_strBusinessId = "AB";
                // *—š—ð”Ô† 000003 2004/03/26 ’Ç‰ÁI—¹

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // Žs’¬‘ºî•ñŽæ“¾iŽs’¬‘ºƒR[ƒh)
                cUSSCItyInfo.GetCityInfo(m_cfControlData);

                // ˆ¶–¼‘•Û‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cABAtenaKokuhoBClass = new ABAtenaKokuhoBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass);

                // ˆ¶–¼‘•Ûƒ}ƒXƒ^’ŠoŒÄ‚Ño‚µ
                csABAtenaKokuhoEntity = cABAtenaKokuhoBClass.GetAtenaKokuho(cABKobetsuProperty.p_strJUMINCD);

                // ’Ç‰ÁEXV‚Ì”»’è
                if (csABAtenaKokuhoEntity.Tables(ABAtenaKokuhoEntity.TABLE_NAME).Rows.Count == 0)
                {

                    cDatRow = csABAtenaKokuhoEntity.Tables(ABAtenaKokuhoEntity.TABLE_NAME).NewRow();
                    // Še€–Ú‚ðƒvƒƒpƒeƒB‚©‚çŽæ“¾
                    cDatRow.Item(ABAtenaKokuhoEntity.JUMINCD) = cABKobetsuProperty.p_strJUMINCD;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHONO) = cABKobetsuProperty.p_strKOKUHONO;
                    cDatRow.Item(ABAtenaKokuhoEntity.HIHOKENSHAGAITOKB) = string.Empty;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOSHIKAKUKB) = cABKobetsuProperty.p_strKOKUHOSHIKAKUKB;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOSHIKAKUKBMEISHO) = cABKobetsuProperty.p_strKOKUHOSHIKAKUKBMEISHO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOSHIKAKUKBRYAKUSHO) = cABKobetsuProperty.p_strKOKUHOSHIKAKUKBRYAKUSHO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOGAKUENKB) = cABKobetsuProperty.p_strKOKUHOGAKUENKB;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOGAKUENKBMEISHO) = cABKobetsuProperty.p_strKOKUHOGAKUENKBMEISHO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOGAKUENKBRYAKUSHO) = cABKobetsuProperty.p_strKOKUHOGAKUENKBRYAKUSHO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOSHUTOKUYMD) = cABKobetsuProperty.p_strKOKUHOSHUTOKUYMD;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOSOSHITSUYMD) = cABKobetsuProperty.p_strKOKUHOSOSHITSUYMD;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOTISHKKB) = cABKobetsuProperty.p_strKOKUHOTISHKKB;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOTISHKKBMEISHO) = cABKobetsuProperty.p_strKOKUHOTISHKKBMEISHO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOTISHKKBRYAKUSHO) = cABKobetsuProperty.p_strKOKUHOTISHKKBRYAKUSHO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKB) = cABKobetsuProperty.p_strKOKUHOTISHKHONHIKB;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKBMEISHO) = cABKobetsuProperty.p_strKOKUHOTISHKHONHIKBMEISHO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKBRYAKUSHO) = cABKobetsuProperty.p_strKOKUHOTISHKHONHIKBRYAKUSHO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOTISHKGAITOYMD) = cABKobetsuProperty.p_strKOKUHOTISHKGAITOYMD;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOTISHKHIGAITOYMD) = cABKobetsuProperty.p_strKOKUHOTISHKHIGAITOYMD;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOHOKENSHOKIGO) = cABKobetsuProperty.p_strKOKUHOHOKENSHOKIGO;   // *DB(ABATENAKOKUHO)‚É‘¶Ý‚µ‚Ä‚È‚¢
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOHOKENSHONO) = cABKobetsuProperty.p_strKOKUHOHOKENSHONO;

                    // Žs’¬‘ºƒR[ƒh
                    cDatRow.Item(ABAtenaKokuhoEntity.SHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);
                    // ‹ŒŽs’¬‘ºƒR[ƒh
                    cDatRow.Item(ABAtenaKokuhoEntity.KYUSHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);

                    // ƒf[ƒ^‚Ì’Ç‰Á
                    // csABAtenaKokuhoEntity.Tables(ABAtenaKokuhoEntity.TABLE_NAME).Rows.Add(cDatRow)

                    // ˆ¶–¼‘•Ûƒ}ƒXƒ^’Ç‰Áƒƒ\ƒbƒhŒÄ‚Ño‚µ
                    intUpdCnt = cABAtenaKokuhoBClass.InsertAtenaKokuho(cDatRow);
                }
                else
                {

                    cDatRow = csABAtenaKokuhoEntity.Tables(ABAtenaKokuhoEntity.TABLE_NAME).Rows(0);
                    // Še€–Ú‚ðƒvƒƒpƒeƒB‚©‚çŽæ“¾
                    cDatRow.Item(ABAtenaKokuhoEntity.JUMINCD) = cABKobetsuProperty.p_strJUMINCD;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHONO) = cABKobetsuProperty.p_strKOKUHONO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOSHIKAKUKB) = cABKobetsuProperty.p_strKOKUHOSHIKAKUKB;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOSHIKAKUKBMEISHO) = cABKobetsuProperty.p_strKOKUHOSHIKAKUKBMEISHO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOSHIKAKUKBRYAKUSHO) = cABKobetsuProperty.p_strKOKUHOSHIKAKUKBRYAKUSHO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOGAKUENKB) = cABKobetsuProperty.p_strKOKUHOGAKUENKB;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOGAKUENKBMEISHO) = cABKobetsuProperty.p_strKOKUHOGAKUENKBMEISHO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOGAKUENKBRYAKUSHO) = cABKobetsuProperty.p_strKOKUHOGAKUENKBRYAKUSHO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOSHUTOKUYMD) = cABKobetsuProperty.p_strKOKUHOSHUTOKUYMD;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOSOSHITSUYMD) = cABKobetsuProperty.p_strKOKUHOSOSHITSUYMD;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOTISHKKB) = cABKobetsuProperty.p_strKOKUHOTISHKKB;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOTISHKKBMEISHO) = cABKobetsuProperty.p_strKOKUHOTISHKKBMEISHO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOTISHKKBRYAKUSHO) = cABKobetsuProperty.p_strKOKUHOTISHKKBRYAKUSHO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKB) = cABKobetsuProperty.p_strKOKUHOTISHKHONHIKB;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKBMEISHO) = cABKobetsuProperty.p_strKOKUHOTISHKHONHIKBMEISHO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOTISHKHONHIKBRYAKUSHO) = cABKobetsuProperty.p_strKOKUHOTISHKHONHIKBRYAKUSHO;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOTISHKGAITOYMD) = cABKobetsuProperty.p_strKOKUHOTISHKGAITOYMD;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOTISHKHIGAITOYMD) = cABKobetsuProperty.p_strKOKUHOTISHKHIGAITOYMD;
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOHOKENSHOKIGO) = cABKobetsuProperty.p_strKOKUHOHOKENSHOKIGO;  // *DB(ABATENAKOKUHO)‚É‘¶Ý‚µ‚Ä‚È‚¢
                    cDatRow.Item(ABAtenaKokuhoEntity.KOKUHOHOKENSHONO) = cABKobetsuProperty.p_strKOKUHOHOKENSHONO;

                    // Žs’¬‘ºƒR[ƒh
                    cDatRow.Item(ABAtenaKokuhoEntity.SHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);
                    // ‹ŒŽs’¬‘ºƒR[ƒh
                    cDatRow.Item(ABAtenaKokuhoEntity.KYUSHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);

                    // ˆ¶–¼‘•Ûƒ}ƒXƒ^XVƒƒ\ƒbƒhŒÄ‚Ño‚µ
                    intUpdCnt = cABAtenaKokuhoBClass.UpdateAtenaKokuho(cDatRow);
                }

                // ’Ç‰ÁEXVŒ”‚ª0Œ‚ÌŽžƒƒbƒZ[ƒW"ˆ¶–¼‚ÌŒÂ•ÊŽ–€‚ÌXV‚Í³í‚És‚¦‚Ü‚¹‚ñ‚Å‚µ‚½"‚ð•Ô‚·
                if (intUpdCnt == 0)
                {
                    cfErrorClass = new UFErrorClass(m_cfControlData.m_strBusinessId);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003004);
                    // —áŠO‚ð¶¬
                    csAppExp = new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                    throw csAppExp;
                }


                // *—š—ð”Ô† 000002 2004/03/08 ’Ç‰ÁŠJŽn
                // ˆ¶–¼ŠÇ—î•ñ‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                cAtenaKanriJohoB = new ABAtenaKanriJohoBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass);
                // ˆ¶–¼ŠÇ—î•ñ‚ÌŽí•Ê04Ž¯•ÊƒL[01‚Ìƒf[ƒ^‚ð‘SŒŽæ“¾‚·‚é
                csAtenaKanriEntity = cAtenaKanriJohoB.GetKanriJohoHoshu("04", "11");

                // ŠÇ—î•ñ‚ÌZŠîXVƒŒƒR[ƒh‚ª‘¶Ý‚µAƒpƒ‰ƒ[ƒ^‚ª"0"‚ÌŽž‚¾‚¯ZŠîXVˆ—‚ðs‚¤
                if (!(csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count == 0))
                {
                    if ((string)csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER) == "0")
                    {

                        // Webservice‚ÌURL‚ðWebConfig‚©‚çŽæ“¾‚µ‚ÄÝ’è‚·‚é
                        cAACommonBSClass = new localhost.AACommonBSClass();
                        cAACommonBSClass.Url = m_cfAAConfigDataClass.p_strWebServiceDomain + m_cfAAConfigDataClass.p_strWWWroot + "AA001BS/AACommonBSClass.asmx";
                        // cAACommonBSClass.Url = "http://localhost/Densan/Reams/AA/AA001BS/AACommonBSClass.asmx"

                        // ŒÂ•Ê‘•Ûƒpƒ‰ƒ[ƒ^‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                        cAAKOBETSUKOKUHOParamClass[0] = new localhost.AAKOBETSUKOKUHOParamClass();

                        // XVE’Ç‰Á‚µ‚½€–Ú‚ðŽæ“¾
                        cAAKOBETSUKOKUHOParamClass[0].m_strJUMINCD = cABKobetsuProperty.p_strJUMINCD;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHONO = cABKobetsuProperty.p_strKOKUHONO;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOSHIKAKUKB = cABKobetsuProperty.p_strKOKUHOSHIKAKUKB;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOSHIKAKUKBMEISHO = cABKobetsuProperty.p_strKOKUHOSHIKAKUKBMEISHO;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOSHIKAKUKBRYAKUSHO = cABKobetsuProperty.p_strKOKUHOSHIKAKUKBRYAKUSHO;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOGAKUENKB = cABKobetsuProperty.p_strKOKUHOGAKUENKB;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOGAKUENKBMEISHO = cABKobetsuProperty.p_strKOKUHOGAKUENKBMEISHO;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOGAKUENKBRYAKUSHO = cABKobetsuProperty.p_strKOKUHOGAKUENKBRYAKUSHO;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOSHUTOKUYMD = cABKobetsuProperty.p_strKOKUHOSHUTOKUYMD;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOSOSHITSUYMD = cABKobetsuProperty.p_strKOKUHOSOSHITSUYMD;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOTISHKKB = cABKobetsuProperty.p_strKOKUHOTISHKKB;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOTISHKKBMEISHO = cABKobetsuProperty.p_strKOKUHOTISHKKBMEISHO;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOTISHKKBRYAKUSHO = cABKobetsuProperty.p_strKOKUHOTISHKKBRYAKUSHO;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOTISHKHONHIKB = cABKobetsuProperty.p_strKOKUHOTISHKHONHIKB;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOTISHKHONHIKBMEISHO = cABKobetsuProperty.p_strKOKUHOTISHKHONHIKBMEISHO; // –‘•Û‘ÞE–{”í‹æ•ª³Ž®–¼Ì‰pŽš€–Ú–¼‚ÉŠÔˆá‚¢‚ ‚è–
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOTISHKHONHIKBRYAKUSHO = cABKobetsuProperty.p_strKOKUHOTISHKHONHIKBRYAKUSHO;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOTISHKGAITOYMD = cABKobetsuProperty.p_strKOKUHOTISHKGAITOYMD;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOTISHKHIGAITOYMD = cABKobetsuProperty.p_strKOKUHOTISHKHIGAITOYMD;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOHOKENSHOKIGO = cABKobetsuProperty.p_strKOKUHOHOKENSHOKIGO;
                        cAAKOBETSUKOKUHOParamClass[0].m_strKOKUHOHOKENSHONO = cABKobetsuProperty.p_strKOKUHOHOKENSHONO;

                        // ZŠîŒÂ•Ê‘•ÛXVƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                        strControlData = UFControlToolClass.ControlGetStr(m_cfControlData);
                        intUpdCnt = cAACommonBSClass.UpdateKBKOKUHO(strControlData, cAAKOBETSUKOKUHOParamClass);

                        // *—š—ð”Ô† 000004 2005/12/01 ’Ç‰ÁŠJŽn
                        // ˆ¶–¼ŠÇ—î•ñ‚ÌŽí•Ê04Ž¯•ÊƒL[22‚Ìƒf[ƒ^‚ðŽæ“¾‚·‚é(ZŠî‘¤‚ÌXVˆ—‚ÌŒ‹‰Ê‚ð”»’f‚·‚é‚©‚Ç‚¤‚©)
                        csAtenaKanriEntity = cAtenaKanriJohoB.GetKanriJohoHoshu("04", "22");
                        // ŠÇ—î•ñ‚ÉƒŒƒR[ƒh‚ª‘¶Ý‚µAƒpƒ‰ƒ[ƒ^‚ª"1"‚ÌŽž‚Íƒ`ƒFƒbƒN‚µ‚È‚¢
                        if (!(csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count == 0))
                        {
                            if ((string)csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER) == "1")
                            {
                                // Êß×Ò°À‚ª"1"‚Ì‚Æ‚«‚Íƒ`ƒFƒbƒN‚µ‚È‚¢
                                strJukiResult = "1";
                            }
                            else
                            {
                                // Êß×Ò°À‚ª"1"‚Ì‚Æ‚«‚Íƒ`ƒFƒbƒN‚·‚é
                                strJukiResult = "0";
                            }
                        }
                        else
                        {
                            // ƒŒƒR[ƒh‚ª‚È‚¢‚Æ‚«‚Íƒ`ƒFƒbƒN‚·‚é
                            strJukiResult = "0";
                        }
                        // *—š—ð”Ô† 000004 2005/12/01 ’Ç‰ÁI—¹

                        // *—š—ð”Ô† 000004 2005/12/01 C³ŠJŽn
                        // * corresponds to VS2008 Start 2010/04/16 000005
                        // '''’Ç‰ÁEXVŒ”‚ª0Œ‚ÌŽžƒƒbƒZ[ƒW"ZŠî‚ÌŒÂ•ÊŽ–€‚ÌXV‚Í³í‚És‚¦‚Ü‚¹‚ñ‚Å‚µ‚½"‚ð•Ô‚·
                        // '''If intUpdCnt = 0 Then
                        // '''    cfErrorClass = New UFErrorClass(m_cfControlData.m_strBusinessId)
                        // '''    'ƒGƒ‰[’è‹`‚ðŽæ“¾
                        // '''    objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003002)
                        // '''    '—áŠO‚ð¶¬
                        // '''    csAppExp = New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                        // '''    Throw csAppExp
                        // '''End If
                        // * corresponds to VS2008 End 2010/04/16 000005
                        if (strJukiResult == "0")
                        {
                            // ŠÇ—î•ñ‚©‚çŽæ“¾‚µ‚½“à—e‚ª"0"‚Ì‚Æ‚«‚Íƒ`ƒFƒbƒN‚·‚é
                            // ’Ç‰ÁEXVŒ”‚ª0Œ‚ÌŽžƒƒbƒZ[ƒW"ZŠî‚ÌŒÂ•ÊŽ–€‚ÌXV‚Í³í‚És‚¦‚Ü‚¹‚ñ‚Å‚µ‚½"‚ð•Ô‚·
                            if (intUpdCnt == 0)
                            {
                                cfErrorClass = new UFErrorClass(m_cfControlData.m_strBusinessId);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003002);
                                // —áŠO‚ð¶¬
                                csAppExp = new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                                throw csAppExp;
                            }
                        }
                        else if (strJukiResult == "1")
                        {
                        }
                        // ƒ`ƒFƒbƒN‚µ‚È‚¢
                        else
                        {
                            // ƒ`ƒFƒbƒN‚µ‚È‚¢
                        }
                        // *—š—ð”Ô† 000004 2005/12/01 C³I—¹
                    }
                }
                // *—š—ð”Ô† 000002 2004/03/08 ’Ç‰ÁŠJŽn

                // *—š—ð”Ô† 000001 2004/02/26 ’Ç‰ÁŠJŽn
                // ˆ¶–¼ŠÇ—î•ñ‚ÌŽí•Ê04Ž¯•ÊƒL[01‚Ìƒf[ƒ^‚ð‘SŒŽæ“¾‚·‚é
                csAtenaKanriEntity = cAtenaKanriJohoB.GetKanriJohoHoshu("04", "02");

                // ŠÇ—î•ñ‚Ìƒ[ƒNƒtƒ[ƒŒƒR[ƒh‚ª‘¶Ý‚µAƒpƒ‰ƒ[ƒ^‚ª"1"‚ÌŽž‚¾‚¯ƒ[ƒNƒtƒ[ˆ—‚ðs‚¤
                if (!(csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count == 0))
                {
                    if ((string)csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER) == "1")
                    {
                        // ƒ[ƒNƒtƒ[ˆ—ƒƒ\ƒbƒh‚ðŒÄ‚Ô
                        WorkFlowSet(cABKobetsuProperty);
                    }
                }
                // *—š—ð”Ô† 000001 2004/02/26 ’Ç‰ÁI—¹

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (Global.System.Web.Services.Protocols.SoapException objSoapExp)             // SoapException‚ðƒLƒƒƒbƒ`
            {
                // OuterXml‚ÉƒGƒ‰[“à—e‚ªŠi”[‚µ‚Ä‚ ‚éB
                var objExpTool = new UFExceptionTool(objSoapExp.Detail.OuterXml);
                var objErr = default(UFErrorStruct);

                // ƒAƒvƒŠƒP[ƒVƒ‡ƒ“—áŠO‚©‚Ç‚¤‚©‚Ì”»’è
                if (objExpTool.IsAppException == true)
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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22503


                    Input:
                    " + objExpTool.p_strErrorCode + "z" + _
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;

                    // ƒAƒvƒŠƒP[ƒVƒ‡ƒ“—áŠO‚ðì¬‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22602


                                        Input:
                                        " + objExpTool.p_strErrorMessage + "z")

                                                        ' •t‰ÁƒƒbƒZ[ƒW‚ðì¬‚·‚é
                                                        Dim strExtMsg As String = "<P>‘ÎÛZ–¯‚ÌƒŠƒJƒoƒŠˆ—‚ðs‚Á‚Ä‚­‚¾‚³‚¢B<BR>"

                                         */
                    UFAppException objAppExp;
                    objAppExp = new UFAppException(objExpTool.p_strErrorMessage + strExtMsg, objExpTool.p_strErrorCode);

                    // Šg’£—Ìˆæ‚ÌƒƒbƒZ[ƒW‚É‚à•t‰ÁiŽÀÛ‚É‚Í‚±‚±‚ÌƒƒbƒZ[ƒW‚ª•\Ž¦‚³‚ê‚éj
                    UFErrorToolClass.ErrorStructSetStr(objErr, objExpTool.p_strExt);
                    objErr.m_strErrorMessage += strExtMsg;
                    objAppExp.p_strExt = UFErrorToolClass.ErrorStructGetStr(objErr);
                    // ƒƒbƒZ[ƒW‚ð•t‰Á‚µ‚È‚¢ê‡‚ÍˆÈ‰º
                    // objAppExp.p_strExt = objExpTool.p_strExt

                    throw objAppExp;
                }
                else
                {
                    // ƒVƒXƒeƒ€—áŠO‚Ìê‡
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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 23853


                                        Input:
                                        " + objExpTool.p_strErrorMessage + "z")
                                                        Throw objSoapExp
                                                    End If
                                                Catch exAppExp As UFAppException                   ' UFAppException‚ðƒLƒƒƒbƒ`
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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 24398


                    Input:
                    " + exAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 24491


                    Input:
                    " + exAppExp.Message + "z")
                                Throw exAppExp
                            Catch exExp As Exception                           ' Exception‚ðƒLƒƒƒbƒ`
                                ' ƒGƒ‰[ƒƒOo—Í
                                m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 24760


                    Input:
                    " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 24841


                                        Input:
                                        " + THIS_METHOD_NAME + "z" + _
                                                                            "yƒGƒ‰[“à—e:" + exExp.Message + "z")

                                         */
                    throw exExp;
                }
            }
            finally
            {
                // Œ³‚ÌƒrƒWƒlƒXID‚ð“ü‚ê‚é
                m_cfControlData.m_strBusinessId = m_strRsBusiId;
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            return intUpdCnt;

        }


        // *—š—ð”Ô† 000001 2004/02/26 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼‘•Ûƒ[ƒNƒtƒ[
        // * 
        // * \•¶           Public Function UpdateAtenaKokuho(ByVal cABKobetsuProperty As ABKobetsuKokuhoProperty) As Integer
        // * 
        // * ‹@”\@@    @  ˆ¶–¼‘•Ûƒf[ƒ^‚ðƒ[ƒNƒtƒ[‚Ö“n‚·B
        // * 
        // * ˆø”           cABKobetsuProperty As ABKobetsuProperty  :XVƒf[ƒ^
        // * 
        // * –ß‚è’l         XVŒ”(Integer)
        // ************************************************************************************************
        public void WorkFlowSet(ABKobetsuKokuhoProperty cABKobetsuProperty)
        {
            const string THIS_METHOD_NAME = "WorkFlowSet";
            // * corresponds to VS2008 Start 2010/04/16 000005
            // Dim cwMessage As UWMessageClass                     'ƒ[ƒNƒtƒ[‹N“®ƒNƒ‰ƒX
            // Dim cwStartRetInfo As UWStartRetInfo                'ƒ[ƒNƒtƒ[ŠJŽnƒNƒ‰ƒX
            // * corresponds to VS2008 End 2010/04/16 000005
            // Dim cUWSerialGroupId(0) As UWSerialGroupId
            // Dim cUWSerialGroupIdTemp As UWSerialGroupId
            // Dim cwDataInfo As UWStartDataInfo                                              ' ƒ[ƒNƒtƒ[ƒf[ƒ^
            string strMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;       // ƒ[ƒNƒtƒ[ƒf[ƒ^
            var cUWStartDataInfoForDataSet = new UWStartDataInfoForDataSet[1];
            // * corresponds to VS2008 Start 2010/04/16 000005
            // Dim cfErrorClass As UFErrorClass                    'ƒGƒ‰[ˆ—ƒNƒ‰ƒX
            // Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì
            // * corresponds to VS2008 End 2010/04/16 000005
            var csABKokuhoEntity = new DataSet();               // ŒÂ•ÊŽ–€‘•Ûƒf[ƒ^ƒZƒbƒg
            DataTable csABKokuhoTable;                    // ŒÂ•ÊŽ–€‘•Ûƒf[ƒ^ƒe[ƒuƒ‹
            DataRow csABKokuhoRow;                        // ŒÂ•ÊŽ–€‘•Ûƒf[ƒ^ƒƒE
            string strNen;                                // ì¬“úŽž
            int intRecCnt;                            // ˜A”Ô—pƒJƒEƒ“ƒ^[
            var cuCityInfoClass = new USSCityInfoClass();       // Žs’¬‘ºŠÇ—î•ñƒNƒ‰ƒX
            string strCityCD;                             // Žs’¬‘ºƒR[ƒh
            ABAtenaCnvBClass cABAtenaCnvBClass;

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // Žs’¬‘ºŠÇ—î•ñ‚ÌŽæ“¾
                cuCityInfoClass.GetCityInfo(m_cfControlData);
                // Žs’¬‘ºƒR[ƒh‚ÌŽæ“¾
                strCityCD = cuCityInfoClass.p_strShichosonCD(0);
                // ì¬“úŽž(14Œ…)‚ÌŽæ“¾
                strNen = DateTime.Now.ToString("yyyyMMddHHmmss");
                // ˜A”Ô—pƒJƒEƒ“ƒ^[‚Ì‰ŠúÝ’è
                intRecCnt = 1;

                // ƒe[ƒuƒ‹ƒZƒbƒg‚ÌŽæ“¾
                csABKokuhoTable = CreateColumnsData();
                csABKokuhoTable.TableName = ABKobetsuKokuhoEntity.TABLE_NAME;
                // ƒf[ƒ^ƒZƒbƒg‚Éƒe[ƒuƒ‹ƒZƒbƒg‚Ì’Ç‰Á
                csABKokuhoEntity.Tables.Add(csABKokuhoTable);

                // *****
                // *@‚Ps–Ú‚Ì•ÒW
                // *
                // *****
                // V‹KƒŒƒR[ƒh‚Ìì¬
                csABKokuhoRow = csABKokuhoEntity.Tables(ABKobetsuKokuhoEntity.TABLE_NAME).NewRow;
                // Še€–Ú‚Éƒf[ƒ^‚ðƒZƒbƒg
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.SHICHOSONCD) = strCityCD;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.SHIKIBETSUID) = "AA60";
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.LASTRECKB) = "";
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.SAKUSEIYMD) = strNen;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.RENBAN) = intRecCnt.ToString().RPadLeft(7, '0');
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.JUMINCD) = cABKobetsuProperty.p_strJUMINCD.RSubstring(3, 12);
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHONO) = cABKobetsuProperty.p_strKOKUHONO;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOSHIKAKUKB) = cABKobetsuProperty.p_strKOKUHOSHIKAKUKB;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOSHIKAKUKBMEISHO) = cABKobetsuProperty.p_strKOKUHOSHIKAKUKBMEISHO;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOSHIKAKUKBRYAKUSHO) = cABKobetsuProperty.p_strKOKUHOSHIKAKUKBRYAKUSHO;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOGAKUENKB) = cABKobetsuProperty.p_strKOKUHOGAKUENKB;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOGAKUENKBMEISHO) = cABKobetsuProperty.p_strKOKUHOGAKUENKBMEISHO;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOGAKUENKBRYAKUSHO) = cABKobetsuProperty.p_strKOKUHOGAKUENKBRYAKUSHO;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOSHUTOKUYMD) = cABKobetsuProperty.p_strKOKUHOSHUTOKUYMD;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOSOSHITSUYMD) = cABKobetsuProperty.p_strKOKUHOSOSHITSUYMD;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOTISHKKB) = cABKobetsuProperty.p_strKOKUHOTISHKKB;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOTISHKKBMEISHO) = cABKobetsuProperty.p_strKOKUHOTISHKKBMEISHO;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOTISHKKBRYAKUSHO) = cABKobetsuProperty.p_strKOKUHOTISHKKBRYAKUSHO;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOTISHKHONHIKB) = cABKobetsuProperty.p_strKOKUHOTISHKHONHIKB;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOTISHKHONHIKBMEISHO) = cABKobetsuProperty.p_strKOKUHOTISHKHONHIKBMEISHO;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOTISHKHONHIKBRYAKUSHO) = cABKobetsuProperty.p_strKOKUHOTISHKHONHIKBRYAKUSHO;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOTISHKGAITOYMD) = cABKobetsuProperty.p_strKOKUHOTISHKGAITOYMD;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOTISHKHIGAITOYMD) = cABKobetsuProperty.p_strKOKUHOTISHKHIGAITOYMD;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOHOKENSHOKIGO) = cABKobetsuProperty.p_strKOKUHOHOKENSHOKIGO;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.KOKUHOHOKENSHONO) = cABKobetsuProperty.p_strKOKUHOHOKENSHONO;
                // ƒf[ƒ^ƒZƒbƒg‚ÉƒŒƒR[ƒh‚ð’Ç‰Á
                csABKokuhoEntity.Tables(ABKobetsuKokuhoEntity.TABLE_NAME).Rows.Add(csABKokuhoRow);

                // *****
                // *@ÅIs‚Ì•ÒW
                // *
                // *****
                // ˜A”Ô—pƒJƒEƒ“ƒ^‚É‚P‚ð‘«‚·
                intRecCnt += 1;
                // V‹KƒŒƒR[ƒh‚Ìì¬
                csABKokuhoRow = csABKokuhoEntity.Tables(ABKobetsuKokuhoEntity.TABLE_NAME).NewRow;
                // Še€–Ú‚Éƒf[ƒ^‚ðƒZƒbƒg
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.SHICHOSONCD) = strCityCD;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.SHIKIBETSUID) = "AA60";
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.LASTRECKB) = "E";
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.SAKUSEIYMD) = strNen;
                csABKokuhoRow.Item(ABKobetsuKokuhoEntity.RENBAN) = intRecCnt.ToString().RPadLeft(7, '0');
                // ƒf[ƒ^ƒZƒbƒg‚ÉƒŒƒR[ƒh‚ð’Ç‰Á
                csABKokuhoEntity.Tables(ABKobetsuKokuhoEntity.TABLE_NAME).Rows.Add(csABKokuhoRow);

                // *****
                // *@ƒ[ƒNƒtƒ[‘—M
                // *
                // *****
                // ƒf[ƒ^ƒZƒbƒgŽæ“¾ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cABAtenaCnvBClass = new ABAtenaCnvBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass);
                // ƒ[ƒNƒtƒ[‘—Mˆ—ŒÄ‚Ño‚µ
                cABAtenaCnvBClass.WorkFlowExec(csABKokuhoEntity, WORK_FLOW_NAME, DATA_NAME);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException exAppExp)                   // UFAppException‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 33681


                Input:
                " + exAppExp.p_strErrorCode + "z" + _
                                                    "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 33774


                Input:
                " + exAppExp.Message + "z")
                            Throw exAppExp
                        Catch exExp As Exception                           ' Exception‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                    "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 34043


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                    "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 34124


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                    "yƒGƒ‰[“à—e:" + exExp.Message + "z")

                                 */
                throw exExp;

            }

        }


        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒf[ƒ^ƒJƒ‰ƒ€ì¬
        // * 
        // * \•¶            Private Function CreateColumnsData() As DataTable
        // * 
        // * ‹@”\@@        ƒŒƒvƒŠƒJ‚c‚a‚ÌƒJƒ‰ƒ€’è‹`‚ðì¬‚·‚é
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         DataTable() ‘ã”[î•ñƒe[ƒuƒ‹
        // ************************************************************************************************
        private DataTable CreateColumnsData()
        {
            const string THIS_METHOD_NAME = "CreateColumnsData";
            DataTable csABKokuhoTable;
            DataColumn csDataColumn;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ‘ã”[î•ñƒJƒ‰ƒ€’è‹`
                csABKokuhoTable = new DataTable();
                csABKokuhoTable.TableName = ABKobetsuKokuhoEntity.TABLE_NAME;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.SHICHOSONCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.SHIKIBETSUID, Type.GetType("System.String"));
                csDataColumn.MaxLength = 4;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.SAKUSEIYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 14;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.LASTRECKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.RENBAN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.JUMINCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 12;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHONO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 14;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOSHIKAKUKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOSHIKAKUKBMEISHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 24;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOSHIKAKUKBRYAKUSHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOGAKUENKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOGAKUENKBMEISHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 24;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOGAKUENKBRYAKUSHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOSHUTOKUYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOSOSHITSUYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOTISHKKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOTISHKKBMEISHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 24;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOTISHKKBRYAKUSHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOTISHKHONHIKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOTISHKHONHIKBMEISHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 24;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOTISHKHONHIKBRYAKUSHO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOTISHKGAITOYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOTISHKHIGAITOYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOHOKENSHOKIGO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 32;
                csDataColumn = csABKokuhoTable.Columns.Add(ABKobetsuKokuhoEntity.KOKUHOHOKENSHONO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 32;

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40513


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40611


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40881


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40966


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csABKokuhoTable;

        }
        // *—š—ð”Ô† 000001 2004/02/26 ’Ç‰ÁI—¹

    }
}