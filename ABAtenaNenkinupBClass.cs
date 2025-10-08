// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ˆ¶–¼”N‹àƒ}ƒXƒ^XV(ABAtenaNenkinupBClas)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/11/11@‹gàV@sé
// * 
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2004/03/26 000001     ƒrƒWƒlƒXID‚Ì•ÏXC³
// * 2005/12/01 000002     ZŠî‚ÌŒÂ•ÊŽ–€XVŒ‹‰Ê‚ð•]‰¿‚·‚é‚©‚µ‚È‚¢‚©‚Ìˆ—‚ð’Ç‰Á
// * 2024/02/19 000003    yAB-9001_1zŒÂ•Ê‹LÚŽ–€‘Î‰ž(‰º‘º)
// ************************************************************************************************
using System;
using System.Linq;

namespace Densan.Reams.AB.AB000BB
{

    public class ABAtenaNenkinupBClass
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
        private const string THIS_CLASS_NAME = "ABAtenaNenkinupBClass";
        private const string THIS_BUSINESSID = "AB";                              // ‹Æ–±ƒR[ƒh
        private const string AA_BUSSINESS_ID = "AA";            // ‹Æ–±ƒR[ƒh
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
        public ABAtenaNenkinupBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

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
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼”N‹àƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateAtenaNenkin(ByVal cABKobetsuProperty As ABKobetsuNenkinProperty) As Integer
        // * 
        // * ‹@”\@@    @  ˆ¶–¼”N‹àƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚éB
        // * 
        // * ˆø”           cABKobetsuProperty As ABKobetsuProperty  :XVƒf[ƒ^
        // * 
        // * –ß‚è’l         XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateAtenaNenkin(ABKobetsuNenkinProperty[] cABKobetsuProperty)
        {
            const string THIS_METHOD_NAME = "UpdateAtenaNenkin";
            int intUpdCnt;
            ABAtenaNenkinBClass cABAtenaNenkinBClass;
            var cAAKOBETSUNENKINParamClass = new localhost.AAKOBETSUNENKINParamClass[1];
            localhost.AACommonBSClass cAACommonBSClass;
            DataSet csAtenaNenkinEntity;
            DataRow cDatRow;
            string strControlData;
            var cUSSCItyInfo = new USSCityInfoClass();
            UFErrorClass cfErrorClass;                    // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            UFAppException csAppExp;
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

                // ˆ¶–¼”N‹à‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cABAtenaNenkinBClass = new ABAtenaNenkinBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass);

                int intcnt;
                var loopTo = cABKobetsuProperty.Length - 1;
                for (intcnt = 0; intcnt <= loopTo; intcnt++)
                {

                    // ˆ¶–¼”N‹àƒ}ƒXƒ^’ŠoŒÄ‚Ño‚µ
                    csAtenaNenkinEntity = cABAtenaNenkinBClass.GetAtenaNenkin((string)cABKobetsuProperty[intcnt].p_strJUMINCD);

                    // ’Ç‰ÁEXV‚Ì”»’è
                    if (csAtenaNenkinEntity.Tables(ABAtenaNenkinEntity.TABLE_NAME).Rows.Count == 0)
                    {

                        cDatRow = csAtenaNenkinEntity.Tables(ABAtenaNenkinEntity.TABLE_NAME).NewRow();
                        // Še€–Ú‚ðƒvƒƒpƒeƒB‚©‚çŽæ“¾
                        cDatRow.Item(ABAtenaNenkinEntity.JUMINCD) = cABKobetsuProperty[intcnt].p_strJUMINCD;
                        cDatRow.Item(ABAtenaNenkinEntity.HIHOKENSHAGAITOKB) = string.Empty;
                        cDatRow.Item(ABAtenaNenkinEntity.KSNENKNNO) = cABKobetsuProperty[intcnt].p_strKSNENKNNO;
                        cDatRow.Item(ABAtenaNenkinEntity.SKAKSHUTKYMD) = cABKobetsuProperty[intcnt].p_strSKAKSHUTKYMD;
                        cDatRow.Item(ABAtenaNenkinEntity.SKAKSHUTKSHU) = cABKobetsuProperty[intcnt].p_strSKAKSHUTKSHU;
                        cDatRow.Item(ABAtenaNenkinEntity.SHUBETSUHENKOYMD) = string.Empty;
                        cDatRow.Item(ABAtenaNenkinEntity.SKAKSHUTKRIYUCD) = cABKobetsuProperty[intcnt].p_strSKAKSHUTKRIYUCD;
                        cDatRow.Item(ABAtenaNenkinEntity.SKAKSSHTSYMD) = cABKobetsuProperty[intcnt].p_strSKAKSSHTSYMD;
                        cDatRow.Item(ABAtenaNenkinEntity.SKAKSSHTSRIYUCD) = cABKobetsuProperty[intcnt].p_strSKAKSSHTSRIYUCD;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNKIGO1) = cABKobetsuProperty[intcnt].p_strJKYNENKNKIGO1;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNNO1) = cABKobetsuProperty[intcnt].p_strJKYNENKNNO1;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNSHU1) = cABKobetsuProperty[intcnt].p_strJKYNENKNSHU1;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNEDABAN1) = cABKobetsuProperty[intcnt].p_strJKYNENKNEDABAN1;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNKB1) = cABKobetsuProperty[intcnt].p_strJKYNENKNKB1;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNKIGO2) = cABKobetsuProperty[intcnt].p_strJKYNENKNKIGO2;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNNO2) = cABKobetsuProperty[intcnt].p_strJKYNENKNNO2;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNSHU2) = cABKobetsuProperty[intcnt].p_strJKYNENKNSHU2;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNEDABAN2) = cABKobetsuProperty[intcnt].p_strJKYNENKNEDABAN2;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNKB2) = cABKobetsuProperty[intcnt].p_strJKYNENKNKB2;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNKIGO3) = cABKobetsuProperty[intcnt].p_strJKYNENKNKIGO3;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNNO3) = cABKobetsuProperty[intcnt].p_strJKYNENKNNO3;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNSHU3) = cABKobetsuProperty[intcnt].p_strJKYNENKNSHU3;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNEDABAN3) = cABKobetsuProperty[intcnt].p_strJKYNENKNEDABAN3;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNKB3) = cABKobetsuProperty[intcnt].p_strJKYNENKNKB3;
                        // Žs’¬‘ºƒR[ƒh
                        cDatRow.Item(ABAtenaNenkinEntity.SHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);
                        // ‹ŒŽs’¬‘ºƒR[ƒh
                        cDatRow.Item(ABAtenaNenkinEntity.KYUSHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);

                        // ƒf[ƒ^‚Ì’Ç‰Á
                        // csAtenaNenkinEntity.Tables(ABAtenaNenkinEntity.TABLE_NAME).Rows.Add(cDatRow)

                        // ˆ¶–¼”N‹àƒ}ƒXƒ^’Ç‰Áƒƒ\ƒbƒhŒÄ‚Ño‚µ
                        intUpdCnt = cABAtenaNenkinBClass.InsertAtenaNenkin(cDatRow);
                    }
                    else
                    {

                        cDatRow = csAtenaNenkinEntity.Tables(ABAtenaNenkinEntity.TABLE_NAME).Rows(0);
                        // Še€–Ú‚ðƒvƒƒpƒeƒB‚©‚çŽæ“¾
                        cDatRow.Item(ABAtenaNenkinEntity.JUMINCD) = cABKobetsuProperty[intcnt].p_strJUMINCD;
                        cDatRow.Item(ABAtenaNenkinEntity.KSNENKNNO) = cABKobetsuProperty[intcnt].p_strKSNENKNNO;
                        cDatRow.Item(ABAtenaNenkinEntity.SKAKSHUTKYMD) = cABKobetsuProperty[intcnt].p_strSKAKSHUTKYMD;
                        cDatRow.Item(ABAtenaNenkinEntity.SKAKSHUTKSHU) = cABKobetsuProperty[intcnt].p_strSKAKSHUTKSHU;
                        cDatRow.Item(ABAtenaNenkinEntity.SKAKSHUTKRIYUCD) = cABKobetsuProperty[intcnt].p_strSKAKSHUTKRIYUCD;
                        cDatRow.Item(ABAtenaNenkinEntity.SKAKSSHTSYMD) = cABKobetsuProperty[intcnt].p_strSKAKSSHTSYMD;
                        cDatRow.Item(ABAtenaNenkinEntity.SKAKSSHTSRIYUCD) = cABKobetsuProperty[intcnt].p_strSKAKSSHTSRIYUCD;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNKIGO1) = cABKobetsuProperty[intcnt].p_strJKYNENKNKIGO1;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNNO1) = cABKobetsuProperty[intcnt].p_strJKYNENKNNO1;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNSHU1) = cABKobetsuProperty[intcnt].p_strJKYNENKNSHU1;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNEDABAN1) = cABKobetsuProperty[intcnt].p_strJKYNENKNEDABAN1;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNKB1) = cABKobetsuProperty[intcnt].p_strJKYNENKNKB1;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNKIGO2) = cABKobetsuProperty[intcnt].p_strJKYNENKNKIGO2;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNNO2) = cABKobetsuProperty[intcnt].p_strJKYNENKNNO2;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNSHU2) = cABKobetsuProperty[intcnt].p_strJKYNENKNSHU2;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNEDABAN2) = cABKobetsuProperty[intcnt].p_strJKYNENKNEDABAN2;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNKB2) = cABKobetsuProperty[intcnt].p_strJKYNENKNKB2;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNKIGO3) = cABKobetsuProperty[intcnt].p_strJKYNENKNKIGO3;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNNO3) = cABKobetsuProperty[intcnt].p_strJKYNENKNNO3;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNSHU3) = cABKobetsuProperty[intcnt].p_strJKYNENKNSHU3;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNEDABAN3) = cABKobetsuProperty[intcnt].p_strJKYNENKNEDABAN3;
                        cDatRow.Item(ABAtenaNenkinEntity.JKYNENKNKB3) = cABKobetsuProperty[intcnt].p_strJKYNENKNKB3;

                        // Žs’¬‘ºƒR[ƒh
                        cDatRow.Item(ABAtenaNenkinEntity.SHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);
                        // ‹ŒŽs’¬‘ºƒR[ƒh
                        cDatRow.Item(ABAtenaNenkinEntity.KYUSHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);

                        // ˆ¶–¼”N‹àƒ}ƒXƒ^XVƒƒ\ƒbƒhŒÄ‚Ño‚µ
                        intUpdCnt = cABAtenaNenkinBClass.UpdateAtenaNenkin(cDatRow);
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

                // *—š—ð”Ô† 000002 2005/12/01 ’Ç‰ÁŠJŽn
                // ˆ¶–¼ŠÇ—î•ñ‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                cAtenaKanriJohoB = new ABAtenaKanriJohoBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass);
                // ˆ¶–¼ŠÇ—î•ñ‚ÌŽí•Ê04Ž¯•ÊƒL[23‚Ìƒf[ƒ^‚ðŽæ“¾‚·‚é(ZŠî‘¤‚ÌXVˆ—‚ÌŒ‹‰Ê‚ð”»’f‚·‚é‚©‚Ç‚¤‚©)
                csAtenaKanriEntity = cAtenaKanriJohoB.GetKanriJohoHoshu("04", "23");
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
                // m_cfLogClass.WarningWrite(m_cfControlData, m_cfABConfigDataClass.p_strWebServerDomain + "Densan/Reams/AA/AA001BS/AACommonBSClass.asmx")
                cAACommonBSClass.Url = m_cfAAConfigDataClass.p_strWebServiceDomain + m_cfAAConfigDataClass.p_strWWWroot + "AA001BS/AACommonBSClass.asmx";

                // cAACommonBSClass.Url = "http://localhost/Densan/Reams/AA/AA001BS/AACommonBSClass.asmx"

                cAAKOBETSUNENKINParamClass = new localhost.AAKOBETSUNENKINParamClass[cABKobetsuProperty.Length];

                var loopTo1 = cABKobetsuProperty.Length - 1;
                for (intcnt = 0; intcnt <= loopTo1; intcnt++)
                {

                    // ŒÂ•Ê”N‹àƒpƒ‰ƒ[ƒ^‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    cAAKOBETSUNENKINParamClass[intcnt] = new localhost.AAKOBETSUNENKINParamClass();

                    // XVE’Ç‰Á‚µ‚½€–Ú‚ðŽæ“¾
                    cAAKOBETSUNENKINParamClass[intcnt].m_strJUMINCD = (string)cABKobetsuProperty[intcnt].p_strJUMINCD;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strKSNENKNNO = (string)cABKobetsuProperty[intcnt].p_strKSNENKNNO;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strSKAKSHUTKYMD = (string)cABKobetsuProperty[intcnt].p_strSKAKSHUTKYMD;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strSKAKSHUTKSHU = (string)cABKobetsuProperty[intcnt].p_strSKAKSHUTKSHU;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strSKAKSHUTKRIYUCD = (string)cABKobetsuProperty[intcnt].p_strSKAKSHUTKRIYUCD;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strSKAKSSHTSYMD = (string)cABKobetsuProperty[intcnt].p_strSKAKSSHTSYMD;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strSKAKSSHTSRIYUCD = (string)cABKobetsuProperty[intcnt].p_strSKAKSSHTSRIYUCD;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strJKYNENKNKIGO1 = (string)cABKobetsuProperty[intcnt].p_strJKYNENKNKIGO1;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strJKYNENKNNO1 = (string)cABKobetsuProperty[intcnt].p_strJKYNENKNNO1;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strJKYNENKNSHU1 = (string)cABKobetsuProperty[intcnt].p_strJKYNENKNSHU1;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strJKYNENKNEDABAN1 = (string)cABKobetsuProperty[intcnt].p_strJKYNENKNEDABAN1;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strJKYNENKNKB1 = (string)cABKobetsuProperty[intcnt].p_strJKYNENKNKB1;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strJKYNENKNKIGO2 = (string)cABKobetsuProperty[intcnt].p_strJKYNENKNKIGO2;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strJKYNENKNNO2 = (string)cABKobetsuProperty[intcnt].p_strJKYNENKNNO2;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strJKYNENKNSHU2 = (string)cABKobetsuProperty[intcnt].p_strJKYNENKNSHU2;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strJKYNENKNEDABAN2 = (string)cABKobetsuProperty[intcnt].p_strJKYNENKNEDABAN2;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strJKYNENKNKB2 = (string)cABKobetsuProperty[intcnt].p_strJKYNENKNKB2;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strJKYNENKNKIGO3 = (string)cABKobetsuProperty[intcnt].p_strJKYNENKNKIGO3;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strJKYNENKNNO3 = (string)cABKobetsuProperty[intcnt].p_strJKYNENKNNO3;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strJKYNENKNSHU3 = (string)cABKobetsuProperty[intcnt].p_strJKYNENKNSHU3;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strJKYNENKNEDABAN3 = (string)cABKobetsuProperty[intcnt].p_strJKYNENKNEDABAN3;
                    cAAKOBETSUNENKINParamClass[intcnt].m_strJKYNENKNKB3 = (string)cABKobetsuProperty[intcnt].p_strJKYNENKNKB3;

                }

                // ZŠîŒÂ•Ê”N‹àXVƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                strControlData = UFControlToolClass.ControlGetStr(m_cfControlData);
                intUpdCnt = cAACommonBSClass.UpdateKBNENKIN(strControlData, cAAKOBETSUNENKINParamClass);

                // *—š—ð”Ô† 000002 2005/12/01 C³ŠJŽn
                // '''''’Ç‰ÁEXVŒ”‚ª0Œ‚ÌŽžƒƒbƒZ[ƒW"ZŠî‚ÌŒÂ•ÊŽ–€‚ÌXV‚Í³í‚És‚¦‚Ü‚¹‚ñ‚Å‚µ‚½"‚ð•Ô‚·
                // ''''If Not (intUpdCnt = cABKobetsuProperty.Length) Then

                // ''''    cfErrorClass = New UFErrorClass(m_cfControlData.m_strBusinessId)
                // ''''    'ƒGƒ‰[’è‹`‚ðŽæ“¾
                // ''''    objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003002)
                // ''''    '—áŠO‚ð¶¬
                // ''''    csAppExp = New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                // ''''    Throw csAppExp

                // ''''End If

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
            }
            // *—š—ð”Ô† 000002 2005/12/01 C³I—¹

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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21258


                    Input:
                    " + objExpTool.p_strErrorCode + "z" + _
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;

                    // ƒAƒvƒŠƒP[ƒVƒ‡ƒ“—áŠO‚ðì¬‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21357


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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22608


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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 23153


                    Input:
                    " + exAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 23246


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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 23515


                    Input:
                    " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 23596


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

    }
}