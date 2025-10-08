// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ˆ¶–¼‰îŒìƒ}ƒXƒ^XV(ABAtenaNenkinupBClas)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/11/12@‹gàV@sé
// * 
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2004/03/26 000001     ƒrƒWƒlƒXID‚Ì•ÏXC³
// * 2005/12/01 000002     ZŠî‚ÌŒÂ•ÊŽ–€XVŒ‹‰Ê‚ð•]‰¿‚·‚é‚©‚µ‚È‚¢‚©‚Ìˆ—‚ð’Ç‰Á
// * 2008/05/13 000003     ƒzƒXƒg˜AŒgˆ—‚ð‹N“®‚·‚éƒ[ƒNƒtƒ[‹N“®ˆ—‚ð’Ç‰Ái”ä‰Ãj
// * 2008/09/30 000004     ZŠî‚ÌŒÂ•ÊŽ–€ƒ}ƒXƒ^XV‚Ì§Œä‹@”\‚ð’Ç‰Ái‹gàVj
// * 2022/12/16 000005    yAB-8010zZ–¯ƒR[ƒh¢‘ÑƒR[ƒh15Œ…‘Î‰ž(‰º‘º)
// * 2024/02/19 000006    yAB-9001_1zŒÂ•Ê‹LÚŽ–€‘Î‰ž(‰º‘º)
// ************************************************************************************************
using System;
using System.Linq;

namespace Densan.Reams.AB.AB000BB
{

    public class ABAtenaKaigoupBClass
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
        private const string THIS_CLASS_NAME = "ABAtenaKaigoupBClass";
        private const string AA_BUSSINESS_ID = "AA";                            // ‹Æ–±ƒR[ƒh
                                                                                // *—š—ð”Ô† 000003 2008/05/13 ’Ç‰ÁŠJŽn
        private const string WORK_FLOW_NAME = "ˆ¶–¼‰îŒìŒÂ•ÊŽ–€";         // ƒ[ƒNƒtƒ[–¼
        private const string DATA_NAME = "‰îŒìŒÂ•Ê";                      // ƒf[ƒ^–¼
                                                                          // *—š—ð”Ô† 000003 2008/05/13 ’Ç‰ÁI—¹
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
        public ABAtenaKaigoupBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

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

            // *—š—ð”Ô† 000001 2004/03/26 íœŠJŽn
            // '‹Æ–±ID‚ðˆ¶–¼(AB)‚É•ÏX
            // m_cfControlData.m_strBusinessId = "AB"
            // *—š—ð”Ô† 000001 2004/03/26 íœI—¹

        }

        #endregion

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼‰îŒìƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateAtenaKaigo(ByVal cABKobetsuProperty() As ABKobetsuKaigoProperty) As Integer
        // * 
        // * ‹@”\@@    @  ˆ¶–¼‰îŒìƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚éB
        // * 
        // * ˆø”           cABKobetsuProperty As ABKobetsuProperty  :XVƒf[ƒ^
        // * 
        // * –ß‚è’l         XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateAtenaKaigo(ABKobetsuKaigoProperty[] cABKobetsuProperty)
        {
            const string THIS_METHOD_NAME = "UpdateAtenaKaigo";
            var intUpdCnt = default(int);
            ABAtenaKaigoBClass cABAtenaKaigoBClass;
            localhost.AAKOBETSUKAIGOParamClass[] cAAKOBETSUKAIGOParamClass;
            localhost.AACommonBSClass cAACommonBSClass;
            DataSet csABAtenaKaigoEntity;
            DataRow cDatRow;
            string strControlData;
            var cUSSCItyInfo = new USSCityInfoClass();
            UFErrorClass cfErrorClass;                    // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            UFAppException csAppExp;
            int intcnt;
            // *—š—ð”Ô† 000002 2005/12/01 ’Ç‰ÁŠJŽn
            ABAtenaKanriJohoBClass cAtenaKanriJohoB;      // ˆ¶–¼ŠÇ—î•ñ‚c‚`ƒrƒWƒlƒXƒNƒ‰ƒX
            DataSet csAtenaKanriEntity;                   // ˆ¶–¼ŠÇ—î•ñƒf[ƒ^ƒZƒbƒg
            string strJukiResult;                         // ZŠî‚ÌŒ‹‰Ê‚ðƒ`ƒFƒbƒN‚·‚é‚©‚Ç‚¤‚©(0:‚·‚é 1:‚µ‚È‚¢)
                                                          // *—š—ð”Ô† 000002 2005/12/01 ’Ç‰ÁI—¹

            try
            {

                // *—š—ð”Ô† 000001 2004/03/26 ’Ç‰ÁŠJŽn
                // ‹Æ–±ID‚ðˆ¶–¼(AB)‚É•ÏX
                m_cfControlData.m_strBusinessId = "AB";
                // *—š—ð”Ô† 000001 2004/03/26 ’Ç‰ÁI—¹

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // Žs’¬‘ºî•ñŽæ“¾iŽs’¬‘ºƒR[ƒh)
                cUSSCItyInfo.GetCityInfo(m_cfControlData);

                // ˆ¶–¼‰îŒì‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cABAtenaKaigoBClass = new ABAtenaKaigoBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass);

                var loopTo = cABKobetsuProperty.Length - 1;
                for (intcnt = 0; intcnt <= loopTo; intcnt++)
                {

                    // ˆ¶–¼‰îŒìƒ}ƒXƒ^’ŠoŒÄ‚Ño‚µ
                    csABAtenaKaigoEntity = cABAtenaKaigoBClass.GetAtenaKaigo(cABKobetsuProperty[intcnt].p_strJUMINCD);

                    // ’Ç‰ÁEXV‚Ì”»’è
                    if (csABAtenaKaigoEntity.Tables(ABAtenaKaigoEntity.TABLE_NAME).Rows.Count == 0)
                    {

                        cDatRow = csABAtenaKaigoEntity.Tables(ABAtenaKaigoEntity.TABLE_NAME).NewRow();
                        // Še€–Ú‚ðƒvƒƒpƒeƒB‚©‚çŽæ“¾
                        cDatRow.Item(ABAtenaKaigoEntity.JUMINCD) = cABKobetsuProperty[intcnt].p_strJUMINCD;
                        cDatRow.Item(ABAtenaKaigoEntity.HIHOKENSHAGAITOKB) = string.Empty;
                        cDatRow.Item(ABAtenaKaigoEntity.HIHKNSHANO) = cABKobetsuProperty[intcnt].p_strHIHKNSHANO;
                        cDatRow.Item(ABAtenaKaigoEntity.SKAKSHUTKYMD) = cABKobetsuProperty[intcnt].p_strSKAKSHUTKYMD;
                        cDatRow.Item(ABAtenaKaigoEntity.SKAKSSHTSYMD) = cABKobetsuProperty[intcnt].p_strSKAKSSHTSYMD;
                        cDatRow.Item(ABAtenaKaigoEntity.SKAKHIHOKENSHAKB) = cABKobetsuProperty[intcnt].p_strSKAKHIHOKENSHAKB;
                        cDatRow.Item(ABAtenaKaigoEntity.JUSHOCHITKRIKB) = cABKobetsuProperty[intcnt].p_strJUSHOCHITKRIKB;
                        cDatRow.Item(ABAtenaKaigoEntity.JUKYUSHAKB) = cABKobetsuProperty[intcnt].p_strJUKYUSHAKB;
                        cDatRow.Item(ABAtenaKaigoEntity.YOKAIGJOTAIKBCD) = cABKobetsuProperty[intcnt].p_strYOKAIGJOTAIKBCD;
                        cDatRow.Item(ABAtenaKaigoEntity.KAIGSKAKKB) = cABKobetsuProperty[intcnt].p_strKAIGSKAKKB;
                        cDatRow.Item(ABAtenaKaigoEntity.NINTEIKAISHIYMD) = cABKobetsuProperty[intcnt].p_strNINTEIKAISHIYMD;
                        cDatRow.Item(ABAtenaKaigoEntity.NINTEISHURYOYMD) = cABKobetsuProperty[intcnt].p_strNINTEISHURYOYMD;
                        cDatRow.Item(ABAtenaKaigoEntity.JUKYUNINTEIYMD) = cABKobetsuProperty[intcnt].p_strJUKYUNINTEIYMD;
                        cDatRow.Item(ABAtenaKaigoEntity.JUKYUNINTEITORIKESHIYMD) = cABKobetsuProperty[intcnt].p_strJUKYUNINTEITORIKESHIYMD;

                        // Žs’¬‘ºƒR[ƒh
                        cDatRow.Item(ABAtenaKaigoEntity.SHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);
                        // ‹ŒŽs’¬‘ºƒR[ƒh
                        cDatRow.Item(ABAtenaKaigoEntity.KYUSHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);

                        // ƒf[ƒ^‚Ì’Ç‰Á
                        // csABAtenaKaigoEntity.Tables(ABAtenaKaigoEntity.TABLE_NAME).Rows.Add(cDatRow)

                        // ˆ¶–¼‰îŒìƒ}ƒXƒ^’Ç‰Áƒƒ\ƒbƒhŒÄ‚Ño‚µ
                        intUpdCnt = cABAtenaKaigoBClass.InsertAtenaKaigo(cDatRow);
                    }
                    else
                    {

                        cDatRow = csABAtenaKaigoEntity.Tables(ABAtenaKaigoEntity.TABLE_NAME).Rows(0);
                        // Še€–Ú‚ðƒvƒƒpƒeƒB‚©‚çŽæ“¾
                        cDatRow.Item(ABAtenaKaigoEntity.JUMINCD) = cABKobetsuProperty[intcnt].p_strJUMINCD;
                        cDatRow.Item(ABAtenaKaigoEntity.HIHKNSHANO) = cABKobetsuProperty[intcnt].p_strHIHKNSHANO;
                        cDatRow.Item(ABAtenaKaigoEntity.SKAKSHUTKYMD) = cABKobetsuProperty[intcnt].p_strSKAKSHUTKYMD;
                        cDatRow.Item(ABAtenaKaigoEntity.SKAKSSHTSYMD) = cABKobetsuProperty[intcnt].p_strSKAKSSHTSYMD;
                        cDatRow.Item(ABAtenaKaigoEntity.SKAKHIHOKENSHAKB) = cABKobetsuProperty[intcnt].p_strSKAKHIHOKENSHAKB;
                        cDatRow.Item(ABAtenaKaigoEntity.JUSHOCHITKRIKB) = cABKobetsuProperty[intcnt].p_strJUSHOCHITKRIKB;
                        cDatRow.Item(ABAtenaKaigoEntity.JUKYUSHAKB) = cABKobetsuProperty[intcnt].p_strJUKYUSHAKB;
                        cDatRow.Item(ABAtenaKaigoEntity.YOKAIGJOTAIKBCD) = cABKobetsuProperty[intcnt].p_strYOKAIGJOTAIKBCD;
                        cDatRow.Item(ABAtenaKaigoEntity.KAIGSKAKKB) = cABKobetsuProperty[intcnt].p_strKAIGSKAKKB;
                        cDatRow.Item(ABAtenaKaigoEntity.NINTEIKAISHIYMD) = cABKobetsuProperty[intcnt].p_strNINTEIKAISHIYMD;
                        cDatRow.Item(ABAtenaKaigoEntity.NINTEISHURYOYMD) = cABKobetsuProperty[intcnt].p_strNINTEISHURYOYMD;
                        cDatRow.Item(ABAtenaKaigoEntity.JUKYUNINTEIYMD) = cABKobetsuProperty[intcnt].p_strJUKYUNINTEIYMD;
                        cDatRow.Item(ABAtenaKaigoEntity.JUKYUNINTEITORIKESHIYMD) = cABKobetsuProperty[intcnt].p_strJUKYUNINTEITORIKESHIYMD;
                        // Žs’¬‘ºƒR[ƒh
                        cDatRow.Item(ABAtenaNenkinEntity.SHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);
                        // ‹ŒŽs’¬‘ºƒR[ƒh
                        cDatRow.Item(ABAtenaNenkinEntity.KYUSHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);

                        // ˆ¶–¼‰îŒìƒ}ƒXƒ^XVƒƒ\ƒbƒhŒÄ‚Ño‚µ
                        intUpdCnt = cABAtenaKaigoBClass.UpdateAtenaKaigo(cDatRow);
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

                }

                // *—š—ð”Ô† 000004 2008/09/30 C³ŠJŽn
                // ˆ¶–¼ŠÇ—î•ñ‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                cAtenaKanriJohoB = new ABAtenaKanriJohoBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass);
                // ZŠîŒÂ•ÊŽ–€ƒ}ƒXƒ^XV§Œäî•ñ‚ÌŽæ“¾
                csAtenaKanriEntity = cAtenaKanriJohoB.GetKanriJohoHoshu("04", "17");

                // ŠÇ—î•ñ‚ÌƒŒƒR[ƒh‘¶Ý‚µAƒpƒ‰ƒ[ƒ^‚ª "1" ‚Ìê‡‚Ì‚ÝXV‚ðs‚È‚í‚È‚¢B
                if (!(csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count == 0) && (string)csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER) == "1")
                {
                }
                // ZŠîŒÂ•ÊŽ–€ƒ}ƒXƒ^‚ÌXV‚Ís‚í‚È‚¢B
                else
                {

                    // *—š—ð”Ô† 000002 2005/12/01 ’Ç‰ÁŠJŽn
                    // *—š—ð”Ô† 000004 2008/09/30 íœŠJŽn
                    // ' ˆ¶–¼ŠÇ—î•ñ‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                    // cAtenaKanriJohoB = New ABAtenaKanriJohoBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass)
                    // *—š—ð”Ô† 000004 2008/09/30 íœI—¹

                    // ˆ¶–¼ŠÇ—î•ñ‚ÌŽí•Ê04Ž¯•ÊƒL[25‚Ìƒf[ƒ^‚ðŽæ“¾‚·‚é(ZŠî‘¤‚ÌXVˆ—‚ÌŒ‹‰Ê‚ð”»’f‚·‚é‚©‚Ç‚¤‚©)
                    csAtenaKanriEntity = cAtenaKanriJohoB.GetKanriJohoHoshu("04", "25");
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
                    // *—š—ð”Ô† 000002 2005/12/01 ’Ç‰ÁI—¹

                    // Webservice‚ÌURL‚ðWebConfig‚©‚çŽæ“¾‚µ‚ÄÝ’è‚·‚é
                    cAACommonBSClass = new localhost.AACommonBSClass();
                    cAACommonBSClass.Url = m_cfAAConfigDataClass.p_strWebServiceDomain + m_cfAAConfigDataClass.p_strWWWroot + "AA001BS/AACommonBSClass.asmx";
                    // cAACommonBSClass.Url = "http://localhost/Densan/Reams/AA/AA001BS/AACommonBSClass.asmx"

                    cAAKOBETSUKAIGOParamClass = new localhost.AAKOBETSUKAIGOParamClass[cABKobetsuProperty.Length];

                    var loopTo1 = cABKobetsuProperty.Length - 1;
                    for (intcnt = 0; intcnt <= loopTo1; intcnt++)
                    {

                        // ŒÂ•Ê‰îŒìƒpƒ‰ƒ[ƒ^‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                        cAAKOBETSUKAIGOParamClass[intcnt] = new localhost.AAKOBETSUKAIGOParamClass();

                        // XVE’Ç‰Á‚µ‚½€–Ú‚ðŽæ“¾
                        cAAKOBETSUKAIGOParamClass[intcnt].m_strJUMINCD = (string)cABKobetsuProperty[intcnt].p_strJUMINCD;
                        cAAKOBETSUKAIGOParamClass[intcnt].m_strHIHKNSHANO = (string)cABKobetsuProperty[intcnt].p_strHIHKNSHANO;
                        cAAKOBETSUKAIGOParamClass[intcnt].m_strSKAKSHUTKYMD = (string)cABKobetsuProperty[intcnt].p_strSKAKSHUTKYMD;
                        cAAKOBETSUKAIGOParamClass[intcnt].m_strSKAKSSHTSYMD = (string)cABKobetsuProperty[intcnt].p_strSKAKSSHTSYMD;
                        cAAKOBETSUKAIGOParamClass[intcnt].m_strSKAKHIHOKENSHAKB = (string)cABKobetsuProperty[intcnt].p_strSKAKHIHOKENSHAKB;
                        cAAKOBETSUKAIGOParamClass[intcnt].m_strJUSHOCHITKRIKB = (string)cABKobetsuProperty[intcnt].p_strJUSHOCHITKRIKB;
                        cAAKOBETSUKAIGOParamClass[intcnt].m_strJUKYUSHAKB = (string)cABKobetsuProperty[intcnt].p_strJUKYUSHAKB;
                        cAAKOBETSUKAIGOParamClass[intcnt].m_strYOKAIGJOTAIKBCD = (string)cABKobetsuProperty[intcnt].p_strYOKAIGJOTAIKBCD;
                        cAAKOBETSUKAIGOParamClass[intcnt].m_strKAIGSKAKKB = (string)cABKobetsuProperty[intcnt].p_strKAIGSKAKKB;
                        cAAKOBETSUKAIGOParamClass[intcnt].m_strNINTEIKAISHIYMD = (string)cABKobetsuProperty[intcnt].p_strNINTEIKAISHIYMD;
                        cAAKOBETSUKAIGOParamClass[intcnt].m_strNINTEISHURYOYMD = (string)cABKobetsuProperty[intcnt].p_strNINTEISHURYOYMD;
                        cAAKOBETSUKAIGOParamClass[intcnt].m_strJUKYUNINTEIYMD = (string)cABKobetsuProperty[intcnt].p_strJUKYUNINTEIYMD;
                        cAAKOBETSUKAIGOParamClass[intcnt].m_strJUKYUNINTEITORIKESHIYMD = (string)cABKobetsuProperty[intcnt].p_strJUKYUNINTEITORIKESHIYMD;
                    }

                    // ZŠîŒÂ•Ê‰îŒìXVƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                    strControlData = UFControlToolClass.ControlGetStr(m_cfControlData);
                    intUpdCnt = cAACommonBSClass.UpdateKBKAIGO(strControlData, cAAKOBETSUKAIGOParamClass);

                    // *—š—ð”Ô† 000002 2005/12/01 C³ŠJŽn
                    // ''''’Ç‰ÁEXVŒ”‚ª0Œ‚ÌŽžƒƒbƒZ[ƒW"ZŠî‚ÌŒÂ•ÊŽ–€‚ÌXV‚Í³í‚És‚¦‚Ü‚¹‚ñ‚Å‚µ‚½"‚ð•Ô‚·
                    // '''If Not (intUpdCnt = cABKobetsuProperty.Length) Then

                    // '''    cfErrorClass = New UFErrorClass(m_cfControlData.m_strBusinessId)
                    // '''    'ƒGƒ‰[’è‹`‚ðŽæ“¾
                    // '''    objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003002)
                    // '''    '—áŠO‚ð¶¬
                    // '''    csAppExp = New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                    // '''    Throw csAppExp

                    // '''End If
                    if (strJukiResult == "0")
                    {
                        // ŠÇ—î•ñ‚©‚çŽæ“¾‚µ‚½“à—e‚ª"0"‚Ì‚Æ‚«‚Íƒ`ƒFƒbƒN‚·‚é
                        // ’Ç‰ÁEXVŒ”‚ª0Œ‚ÌŽžƒƒbƒZ[ƒW"ZŠî‚ÌŒÂ•ÊŽ–€‚ÌXV‚Í³í‚És‚¦‚Ü‚¹‚ñ‚Å‚µ‚½"‚ð•Ô‚·
                        if (!(intUpdCnt == cABKobetsuProperty.Length))
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
                    // *—š—ð”Ô† 000002 2005/12/01 C³I—¹

                }
                // *—š—ð”Ô† 000004 2008/09/30 C³I—¹



                // *—š—ð”Ô† 000003 2008/05/13 ’Ç‰ÁŠJŽn
                // ˆ¶–¼ŠÇ—î•ñ‚ÌŽí•Ê04Ž¯•ÊƒL[26‚Ìƒf[ƒ^‚ðŽæ“¾‚·‚é(ã“cŽsÎ½Ä‚Æ‚Ì˜AŒg‚ð‚·‚é‚©‚Ç‚¤‚©‚Ì”»’è)
                csAtenaKanriEntity = cAtenaKanriJohoB.GetKanriJohoHoshu("04", "26");

                // ŠÇ—î•ñ‚Ìƒ[ƒNƒtƒ[ƒŒƒR[ƒh‚ª‘¶Ý‚µAƒpƒ‰ƒ[ƒ^‚ª"1"‚ÌŽž‚¾‚¯ƒ[ƒNƒtƒ[ˆ—‚ðs‚¤
                if (!(csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count == 0))
                {
                    if ((string)csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER) == "1")
                    {
                        // ƒ[ƒNƒtƒ[ˆ—ƒƒ\ƒbƒh‚ðŒÄ‚Ô
                        WorkFlowSet(cABKobetsuProperty);
                    }
                }
            }
            // *—š—ð”Ô† 000003 2008/05/13 ’Ç‰ÁI—¹

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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 20268


                    Input:
                    " + objExpTool.p_strErrorCode + "z" + _
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;

                    // ƒAƒvƒŠƒP[ƒVƒ‡ƒ“—áŠO‚ðì¬‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 20367


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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21617


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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22161


                    Input:
                    " + exAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22254


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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22523


                    Input:
                    " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22604


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

        // *—š—ð”Ô† 000003 2008/05/13 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼‰îŒìƒ[ƒNƒtƒ[
        // * 
        // * \•¶           Public Sub WorkFlowSet(ByVal cABKobetsuProperty() As ABKobetsuKaigoProperty)
        // * 
        // * ‹@”\@@    @ ˆ¶–¼‰îŒìƒf[ƒ^‚ðƒ[ƒNƒtƒ[‚Ö“n‚·B
        // * 
        // * ˆø”           ByVal cDatRow As DataRow  :XVƒf[ƒ^
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        public void WorkFlowSet(ABKobetsuKaigoProperty[] cABKobetsuProperty)
        {
            const string THIS_METHOD_NAME = "WorkFlowSet";
            var csABKaigoEntity = new DataSet();                  // ŒÂ•ÊŽ–€‰îŒìƒf[ƒ^ƒZƒbƒg
            DataTable csABKaigoTable;                     // ŒÂ•ÊŽ–€‰îŒìƒf[ƒ^ƒe[ƒuƒ‹
            DataRow csABKaigoRow;                         // ŒÂ•ÊŽ–€‰îŒìƒf[ƒ^ƒƒE
            string strNen;                                // ì¬“úŽž
            int intRecCnt;                            // ˜A”Ô—pƒJƒEƒ“ƒ^[
            var cuCityInfoClass = new USSCityInfoClass();         // Žs’¬‘ºŠÇ—î•ñƒNƒ‰ƒX
            string strCityCD;                             // Žs’¬‘ºƒR[ƒh
            ABAtenaCnvBClass cABAtenaCnvBClass;
            int intIdx;

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
                csABKaigoTable = CreateColumnsData();
                csABKaigoTable.TableName = ABKobetsuKaigoEntity.TABLE_NAME;
                // ƒf[ƒ^ƒZƒbƒg‚Éƒe[ƒuƒ‹ƒZƒbƒg‚Ì’Ç‰Á
                csABKaigoEntity.Tables.Add(csABKaigoTable);

                // *****
                // *@‚Ps–Ú`‚Ì•ÒW
                // *
                // *****
                var loopTo = cABKobetsuProperty.Length - 1;
                for (intIdx = 0; intIdx <= loopTo; intIdx++)
                {
                    // V‹KƒŒƒR[ƒh‚Ìì¬
                    csABKaigoRow = csABKaigoEntity.Tables(ABKobetsuKaigoEntity.TABLE_NAME).NewRow;
                    // Še€–Ú‚Éƒf[ƒ^‚ðƒZƒbƒg
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.CITYCD) = strCityCD;
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.SHIKIBETSUID) = "AA65";
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.SAKUSEIYMD) = strNen;
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.LASTRECKB) = "";
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.RENBAN) = intRecCnt.ToString().RPadLeft(7, '0');
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.JUMINCD) = cABKobetsuProperty[intIdx].p_strJUMINCD.RSubstring(3, 12);
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.SHICHOSONCD) = strCityCD;
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.KYUSHICHOSONCD) = string.Empty;
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.HIHKNSHANO) = cABKobetsuProperty[intIdx].p_strHIHKNSHANO;
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.SKAKSHUTKYMD) = cABKobetsuProperty[intIdx].p_strSKAKSHUTKYMD;
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.SKAKSSHTSYMD) = cABKobetsuProperty[intIdx].p_strSKAKSSHTSYMD;
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.SKAKHIHOKENSHAKB) = cABKobetsuProperty[intIdx].p_strSKAKHIHOKENSHAKB;
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.JUSHOCHITKRIKB) = cABKobetsuProperty[intIdx].p_strJUSHOCHITKRIKB;
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.JUKYUSHAKB) = cABKobetsuProperty[intIdx].p_strJUKYUSHAKB;
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.YOKAIGJOTAIKBCD) = cABKobetsuProperty[intIdx].p_strYOKAIGJOTAIKBCD;
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.KAIGSKAKKB) = cABKobetsuProperty[intIdx].p_strKAIGSKAKKB;
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.NINTEIKAISHIYMD) = cABKobetsuProperty[intIdx].p_strNINTEIKAISHIYMD;
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.NINTEISHURYOYMD) = cABKobetsuProperty[intIdx].p_strNINTEISHURYOYMD;
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.JUKYUNINTEIYMD) = cABKobetsuProperty[intIdx].p_strJUKYUNINTEIYMD;
                    csABKaigoRow.Item(ABKobetsuKaigoEntity.JUKYUNINTEITORIKESHIYMD) = cABKobetsuProperty[intIdx].p_strJUKYUNINTEITORIKESHIYMD;

                    // ƒf[ƒ^ƒZƒbƒg‚ÉƒŒƒR[ƒh‚ð’Ç‰Á
                    csABKaigoEntity.Tables(ABKobetsuKaigoEntity.TABLE_NAME).Rows.Add(csABKaigoRow);
                    // ˜A”Ô—pƒJƒEƒ“ƒgƒAƒbƒv
                    intRecCnt += 1;
                }

                // *****
                // *@ÅIs‚Ì•ÒW
                // *
                // *****
                // V‹KƒŒƒR[ƒh‚Ìì¬
                csABKaigoRow = csABKaigoEntity.Tables(ABKobetsuKaigoEntity.TABLE_NAME).NewRow;
                // Še€–Ú‚Éƒf[ƒ^‚ðƒZƒbƒg
                csABKaigoRow.Item(ABKobetsuKaigoEntity.CITYCD) = strCityCD;
                csABKaigoRow.Item(ABKobetsuKaigoEntity.SHIKIBETSUID) = "AA65";
                csABKaigoRow.Item(ABKobetsuKaigoEntity.SAKUSEIYMD) = strNen;
                csABKaigoRow.Item(ABKobetsuKaigoEntity.LASTRECKB) = "E";
                csABKaigoRow.Item(ABKobetsuKaigoEntity.RENBAN) = intRecCnt.ToString().RPadLeft(7, '0');
                csABKaigoRow.Item(ABKobetsuKaigoEntity.JUMINCD) = string.Empty;
                csABKaigoRow.Item(ABKobetsuKaigoEntity.SHICHOSONCD) = string.Empty;
                csABKaigoRow.Item(ABKobetsuKaigoEntity.KYUSHICHOSONCD) = string.Empty;
                csABKaigoRow.Item(ABKobetsuKaigoEntity.HIHKNSHANO) = string.Empty;
                csABKaigoRow.Item(ABKobetsuKaigoEntity.SKAKSHUTKYMD) = string.Empty;
                csABKaigoRow.Item(ABKobetsuKaigoEntity.SKAKSSHTSYMD) = string.Empty;
                csABKaigoRow.Item(ABKobetsuKaigoEntity.SKAKHIHOKENSHAKB) = string.Empty;
                csABKaigoRow.Item(ABKobetsuKaigoEntity.JUSHOCHITKRIKB) = string.Empty;
                csABKaigoRow.Item(ABKobetsuKaigoEntity.JUKYUSHAKB) = string.Empty;
                csABKaigoRow.Item(ABKobetsuKaigoEntity.YOKAIGJOTAIKBCD) = string.Empty;
                csABKaigoRow.Item(ABKobetsuKaigoEntity.KAIGSKAKKB) = string.Empty;
                csABKaigoRow.Item(ABKobetsuKaigoEntity.NINTEIKAISHIYMD) = string.Empty;
                csABKaigoRow.Item(ABKobetsuKaigoEntity.NINTEISHURYOYMD) = string.Empty;
                csABKaigoRow.Item(ABKobetsuKaigoEntity.JUKYUNINTEIYMD) = string.Empty;
                csABKaigoRow.Item(ABKobetsuKaigoEntity.JUKYUNINTEITORIKESHIYMD) = string.Empty;
                // ƒf[ƒ^ƒZƒbƒg‚ÉƒŒƒR[ƒh‚ð’Ç‰Á
                csABKaigoEntity.Tables(ABKobetsuKaigoEntity.TABLE_NAME).Rows.Add(csABKaigoRow);

                // *****
                // *@ƒ[ƒNƒtƒ[‘—M
                // *
                // *****
                // ƒf[ƒ^ƒZƒbƒgŽæ“¾ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cABAtenaCnvBClass = new ABAtenaCnvBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass);
                // ƒ[ƒNƒtƒ[‘—Mˆ—ŒÄ‚Ño‚µ
                cABAtenaCnvBClass.WorkFlowExec(csABKaigoEntity, WORK_FLOW_NAME, DATA_NAME);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31128


                Input:
                " + exAppExp.p_strErrorCode + "z" + _
                                                    "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31221


                Input:
                " + exAppExp.Message + "z")
                            Throw
                        Catch exExp As Exception                           ' Exception‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                    "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31481


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                    "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31562


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                    "yƒGƒ‰[“à—e:" + exExp.Message + "z")

                                 */
                throw;

            }

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒf[ƒ^ƒJƒ‰ƒ€ì¬
        // * 
        // * \•¶            Private Function CreateColumnsData() As DataTable
        // * 
        // * ‹@”\@@        ƒŒƒvƒŠƒJ‚c‚a‚ÌƒJƒ‰ƒ€’è‹`‚ðì¬‚·‚é
        // * 
        // * ˆø”            ‚È‚µ
        // * 
        // * –ß‚è’l          DataTable() ‘ã”[î•ñƒe[ƒuƒ‹
        // ************************************************************************************************
        private DataTable CreateColumnsData()
        {
            const string THIS_METHOD_NAME = "CreateColumnsData";
            DataTable csABKaigoTable;
            DataColumn csDataColumn;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ŒÂ•Ê‰îŒìî•ñƒJƒ‰ƒ€’è‹`
                csABKaigoTable = new DataTable();
                csABKaigoTable.TableName = ABKobetsuKaigoEntity.TABLE_NAME;
                // Žs’¬‘ºƒR[ƒh
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.CITYCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                // Ž¯•ÊID
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.SHIKIBETSUID, Type.GetType("System.String"));
                csDataColumn.MaxLength = 4;
                // ˆ—“úŽž
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.SAKUSEIYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 14;
                // ÅIs‹æ•ª
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.LASTRECKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                // ˜A”Ô
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.RENBAN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                // Z–¯ƒR[ƒh
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.JUMINCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 12;
                // Žs’¬‘ºƒR[ƒh
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.SHICHOSONCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                // ‹ŒŽs’¬‘ºƒR[ƒh
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.KYUSHICHOSONCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                // ”í•ÛŒ¯ŽÒ”Ô†
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.HIHKNSHANO, Type.GetType("System.String"));
                csDataColumn.MaxLength = 10;
                // Ž‘ŠiŽæ“¾“ú
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.SKAKSHUTKYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                // Ž‘Ši‘rŽ¸“ú
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.SKAKSSHTSYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                // Ž‘Ši”í•ÛŒ¯ŽÒ‹æ•ª
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.SKAKHIHOKENSHAKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                // ZŠ’n“Á—áŽÒ‹æ•ª
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.JUSHOCHITKRIKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                // Žó‹‹ŽÒ‹æ•ª
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.JUKYUSHAKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                // —v‰îŒìó‘Ô‹æ•ªƒR[ƒh
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.YOKAIGJOTAIKBCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 2;
                // —v‰îŒìó‘Ô‹æ•ª
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.KAIGSKAKKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 10;
                // ”F’è—LŒøŠJŽn”NŒŽ“ú
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.NINTEIKAISHIYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                // ”F’è—LŒøI—¹”NŒŽ“ú
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.NINTEISHURYOYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                // Žó‹‹”F’è”NŒŽ“ú
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.JUKYUNINTEIYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;
                // Žó‹‹”F’èŽæÁ”NŒŽ“ú
                csDataColumn = csABKaigoTable.Columns.Add(ABKobetsuKaigoEntity.JUKYUNINTEITORIKESHIYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 8;

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37448


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37546


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37806


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37891


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw;
            }

            return csABKaigoTable;

        }
        // *—š—ð”Ô† 000003 2008/05/13 ’Ç‰ÁI—¹

    }
}