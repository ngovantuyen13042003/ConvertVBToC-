// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ˆ¶–¼Ž™Žèƒ}ƒXƒ^XV(ABAtenaJiteupBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/11/11@‹gàV@sé
// * 
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2004/03/26 000001     ƒrƒWƒlƒXID‚Ì•ÏXC³ 
// * 2005/10/13 000002     ã“cŽsƒzƒXƒg˜AŒgiƒ[ƒNƒtƒ[jˆ—‚ð’Ç‰Á(ƒ}ƒ‹ƒS‘ºŽR)
// * 2005/10/25 000003     ã“cŽsƒzƒXƒg˜AŒgiƒ[ƒNƒtƒ[jˆ—‚ðC³(ƒ}ƒ‹ƒS‘ºŽR)
// * 2005/12/01 000004     ZŠî‚ÌŒÂ•ÊŽ–€XVŒ‹‰Ê‚ð•]‰¿‚·‚é‚©‚µ‚È‚¢‚©‚Ìˆ—‚ð’Ç‰Á
// * 2010/04/09 000005     ŠÇ—î•ñ‚É‚æ‚èZŠîŒÂ•ÊŽ–€‚ÌXV‚ð§Œä‚·‚éi”ä‰Ãj
// * 2010/04/16 000006     VS2008‘Î‰ži”ä‰Ãj
// * 2022/12/16 000007    yAB-8010zZ–¯ƒR[ƒh¢‘ÑƒR[ƒh15Œ…‘Î‰ž(‰º‘º)
// ************************************************************************************************
using System;
using System.Linq;

namespace Densan.Reams.AB.AB000BB
{
    // *—š—ð”Ô† 000002 2005/10/13 ’Ç‰ÁI—¹

    public class ABAtenaJiteupBClass
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
        private const string THIS_CLASS_NAME = "ABAtenaJiteupBClass";
        private const string AA_BUSSINESS_ID = "AA";                              // ‹Æ–±ƒR[ƒh
                                                                                  // *—š—ð”Ô† 000002 2005/10/13 ’Ç‰ÁŠJŽn
        private const string WORK_FLOW_NAME = "ˆ¶–¼Ž™ŽèŒÂ•ÊŽ–€";         // ƒ[ƒNƒtƒ[–¼
        private const string DATA_NAME = "Ž™ŽèŒÂ•Ê";                      // ƒf[ƒ^–¼
                                                                          // *—š—ð”Ô† 000002 2005/10/13 ’Ç‰ÁI—¹
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
        public ABAtenaJiteupBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

        {
            UFConfigDataClass cfAAUFConfigData;
            UFConfigClass cfAAUFConfigClass;

            // ƒRƒ“ƒtƒBƒOƒf[ƒ^‚Ì"AA"‚ÌŠÂ‹«î•ñ‚ðŽæ“¾
            cfAAUFConfigClass = new UFConfigClass();
            cfAAUFConfigData = cfAAUFConfigClass.GetConfig(AA_BUSSINESS_ID);
            m_cfAAConfigDataClass = cfAAUFConfigData;

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
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼Ž™Žèƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateAtenaJite(ByVal cABKobetsuProperty As ABKobetsuJiteProperty) As Integer
        // * 
        // * ‹@”\@@    @  ˆ¶–¼Ž™Žèƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚éB
        // * 
        // * ˆø”           cABKobetsuProperty As ABKobetsuProperty  :XVƒf[ƒ^
        // * 
        // * –ß‚è’l         XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateAtenaJite(ABKobetsuJiteProperty[] cABKobetsuProperty)
        {
            const string THIS_METHOD_NAME = "UpdateAtenaJite";
            var intUpdCnt = default(int);
            ABAtenaJiteBClass cABAtenaJiteBClass;
            var cAAKOBETSUJITEParamClass = new localhost.AAKOBETSUJITEParamClass[1];
            localhost.AACommonBSClass cAACommonBSClass;
            DataSet csABAtenaJiteEntity;
            DataRow cDatRow;
            string strControlData;
            var cUSSCItyInfo = new USSCityInfoClass();
            UFErrorClass cfErrorClass;                    // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            UFAppException csAppExp;
            // *—š—ð”Ô† 000002 2005/10/13 ’Ç‰ÁŠJŽn
            ABAtenaKanriJohoBClass cAtenaKanriJohoB;      // ˆ¶–¼ŠÇ—î•ñ‚c‚`ƒrƒWƒlƒXƒNƒ‰ƒX
            DataSet csAtenaKanriEntity;                   // ˆ¶–¼ŠÇ—î•ñƒf[ƒ^ƒZƒbƒg
                                                          // *—š—ð”Ô† 000002 2005/10/13 ’Ç‰ÁI—¹
                                                          // *—š—ð”Ô† 000004 2005/12/01 ’Ç‰ÁŠJŽn
            string strJukiResult;                         // ZŠî‚ÌŒ‹‰Ê‚ðƒ`ƒFƒbƒN‚·‚é‚©‚Ç‚¤‚©(0:‚·‚é 1:‚µ‚È‚¢)
                                                          // *—š—ð”Ô† 000004 2005/12/01 ’Ç‰ÁI—¹

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

                // ˆ¶–¼Ž™Žè‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cABAtenaJiteBClass = new ABAtenaJiteBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass);

                int intcnt;
                var loopTo = cABKobetsuProperty.Length - 1;
                for (intcnt = 0; intcnt <= loopTo; intcnt++)
                {

                    // ˆ¶–¼Ž™Žèƒ}ƒXƒ^’ŠoŒÄ‚Ño‚µ
                    csABAtenaJiteEntity = cABAtenaJiteBClass.GetAtenaJite(cABKobetsuProperty[intcnt].p_strJUMINCD);

                    // ’Ç‰ÁEXV‚Ì”»’è
                    if (csABAtenaJiteEntity.Tables(ABAtenaJiteEntity.TABLE_NAME).Rows.Count == 0)
                    {

                        cDatRow = csABAtenaJiteEntity.Tables(ABAtenaJiteEntity.TABLE_NAME).NewRow();
                        // Še€–Ú‚ðƒvƒƒpƒeƒB‚©‚çŽæ“¾
                        cDatRow.Item(ABAtenaJiteEntity.JUMINCD) = cABKobetsuProperty[intcnt].p_strJUMINCD;
                        cDatRow.Item(ABAtenaJiteEntity.JIDOTEATEHIYOKB) = cABKobetsuProperty[intcnt].p_strHIYOKB;
                        cDatRow.Item(ABAtenaJiteEntity.JIDOTEATESTYM) = cABKobetsuProperty[intcnt].p_strJIDOTEATESTYM;
                        cDatRow.Item(ABAtenaJiteEntity.JIDOTEATEEDYM) = cABKobetsuProperty[intcnt].p_strJIDOTEATEEDYM;

                        // Žs’¬‘ºƒR[ƒh
                        cDatRow.Item(ABAtenaJiteEntity.SHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);
                        // ‹ŒŽs’¬‘ºƒR[ƒh
                        cDatRow.Item(ABAtenaJiteEntity.KYUSHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);

                        // ƒf[ƒ^‚Ì’Ç‰Á
                        // csABAtenaJiteEntity.Tables(ABAtenaJiteEntity.TABLE_NAME).Rows.Add(cDatRow)

                        // ˆ¶–¼Ž™Žèƒ}ƒXƒ^’Ç‰Áƒƒ\ƒbƒhŒÄ‚Ño‚µ
                        intUpdCnt = cABAtenaJiteBClass.InsertAtenaJite(cDatRow);
                    }
                    else
                    {

                        cDatRow = csABAtenaJiteEntity.Tables(ABAtenaJiteEntity.TABLE_NAME).Rows(0);
                        // Še€–Ú‚ðƒvƒƒpƒeƒB‚©‚çŽæ“¾
                        cDatRow.Item(ABAtenaJiteEntity.JUMINCD) = cABKobetsuProperty[intcnt].p_strJUMINCD;
                        cDatRow.Item(ABAtenaJiteEntity.JIDOTEATEHIYOKB) = cABKobetsuProperty[intcnt].p_strHIYOKB;
                        cDatRow.Item(ABAtenaJiteEntity.JIDOTEATESTYM) = cABKobetsuProperty[intcnt].p_strJIDOTEATESTYM;
                        cDatRow.Item(ABAtenaJiteEntity.JIDOTEATEEDYM) = cABKobetsuProperty[intcnt].p_strJIDOTEATEEDYM;
                        // Žs’¬‘ºƒR[ƒh
                        cDatRow.Item(ABAtenaJiteEntity.SHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);
                        // ‹ŒŽs’¬‘ºƒR[ƒh
                        cDatRow.Item(ABAtenaJiteEntity.KYUSHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);

                        // ˆ¶–¼Ž™Žèƒ}ƒXƒ^XVƒƒ\ƒbƒhŒÄ‚Ño‚µ
                        intUpdCnt = cABAtenaJiteBClass.UpdateAtenaJite(cDatRow);
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

                // *—š—ð”Ô† 000005 2010/04/09 C³ŠJŽn
                // ˆ¶–¼ŠÇ—î•ñ‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                cAtenaKanriJohoB = new ABAtenaKanriJohoBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass);
                // ˆ¶–¼ŠÇ—î•ñ‚ÌŽí•ÊƒL[:04,Ž¯•ÊƒL[:16‚Ìƒf[ƒ^‚ðŽæ“¾‚·‚é
                csAtenaKanriEntity = cAtenaKanriJohoB.GetKanriJohoHoshu("04", "16");

                // ŠÇ—î•ñ‚ÌZŠîXVƒŒƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢A‚Ü‚½‚ÍAƒpƒ‰ƒ[ƒ^‚ª"0"‚ÌŽž‚¾‚¯ZŠîXVˆ—‚ðs‚¤
                if (csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count == 0 || (string)csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER) == "0")
                {

                    // ˆ¶–¼ŠÇ—î•ñ‚ÌŽí•Ê04Ž¯•ÊƒL[24‚Ìƒf[ƒ^‚ðŽæ“¾‚·‚é(ZŠî‘¤‚ÌXVˆ—‚ÌŒ‹‰Ê‚ð”»’f‚·‚é‚©‚Ç‚¤‚©)
                    csAtenaKanriEntity = cAtenaKanriJohoB.GetKanriJohoHoshu("04", "24");
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

                    // Webservice‚ÌURL‚ðWebConfig‚©‚çŽæ“¾‚µ‚ÄÝ’è‚·‚é
                    cAACommonBSClass = new localhost.AACommonBSClass();
                    cAACommonBSClass.Url = m_cfAAConfigDataClass.p_strWebServiceDomain + m_cfAAConfigDataClass.p_strWWWroot + "AA001BS/AACommonBSClass.asmx";
                    // cAACommonBSClass.Url = "http://localhost/Densan/Reams/AA/AA001BS/AACommonBSClass.asmx"

                    cAAKOBETSUJITEParamClass = new localhost.AAKOBETSUJITEParamClass[cABKobetsuProperty.Length];

                    var loopTo1 = cABKobetsuProperty.Length - 1;
                    for (intcnt = 0; intcnt <= loopTo1; intcnt++)
                    {

                        // ŒÂ•ÊŽ™Žèƒpƒ‰ƒ[ƒ^‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                        cAAKOBETSUJITEParamClass[intcnt] = new localhost.AAKOBETSUJITEParamClass();

                        // XVE’Ç‰Á‚µ‚½€–Ú‚ðŽæ“¾
                        cAAKOBETSUJITEParamClass[intcnt].m_strJUMINCD = (string)cABKobetsuProperty[intcnt].p_strJUMINCD;
                        cAAKOBETSUJITEParamClass[intcnt].m_strHIYOKB = (string)cABKobetsuProperty[intcnt].p_strHIYOKB;
                        cAAKOBETSUJITEParamClass[intcnt].m_strJIDOTEATESTYM = (string)cABKobetsuProperty[intcnt].p_strJIDOTEATESTYM;
                        cAAKOBETSUJITEParamClass[intcnt].m_strJIDOTEATEEDYM = (string)cABKobetsuProperty[intcnt].p_strJIDOTEATEEDYM;

                    }

                    // ZŠîŒÂ•ÊŽ™ŽèXVƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                    strControlData = UFControlToolClass.ControlGetStr(m_cfControlData);
                    intUpdCnt = cAACommonBSClass.UpdateKBJITE(strControlData, cAAKOBETSUJITEParamClass);

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
                else
                {
                }

                // '*—š—ð”Ô† 000004 2005/12/01 ’Ç‰ÁŠJŽn
                // ' ˆ¶–¼ŠÇ—î•ñ‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // cAtenaKanriJohoB = New ABAtenaKanriJohoBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass)
                // ' ˆ¶–¼ŠÇ—î•ñ‚ÌŽí•Ê04Ž¯•ÊƒL[24‚Ìƒf[ƒ^‚ðŽæ“¾‚·‚é(ZŠî‘¤‚ÌXVˆ—‚ÌŒ‹‰Ê‚ð”»’f‚·‚é‚©‚Ç‚¤‚©)
                // csAtenaKanriEntity = cAtenaKanriJohoB.GetKanriJohoHoshu("04", "24")
                // ' ŠÇ—î•ñ‚ÉƒŒƒR[ƒh‚ª‘¶Ý‚µAƒpƒ‰ƒ[ƒ^‚ª"1"‚ÌŽž‚Íƒ`ƒFƒbƒN‚µ‚È‚¢
                // If Not (csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count = 0) Then
                // If CStr(csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER)) = "1" Then
                // ' Êß×Ò°À‚ª"1"‚Ì‚Æ‚«‚Íƒ`ƒFƒbƒN‚µ‚È‚¢
                // strJukiResult = "1"
                // Else
                // ' Êß×Ò°À‚ª"1"‚Ì‚Æ‚«‚Íƒ`ƒFƒbƒN‚·‚é
                // strJukiResult = "0"
                // End If
                // Else
                // ' ƒŒƒR[ƒh‚ª‚È‚¢‚Æ‚«‚Íƒ`ƒFƒbƒN‚·‚é
                // strJukiResult = "0"
                // End If
                // '*—š—ð”Ô† 000004 2005/12/01 ’Ç‰ÁI—¹

                // 'Webservice‚ÌURL‚ðWebConfig‚©‚çŽæ“¾‚µ‚ÄÝ’è‚·‚é
                // cAACommonBSClass = New localhost.AACommonBSClass
                // cAACommonBSClass.Url = m_cfAAConfigDataClass.p_strWebServiceDomain + m_cfAAConfigDataClass.p_strWWWroot + "AA001BS/AACommonBSClass.asmx"
                // 'cAACommonBSClass.Url = "http://localhost/Densan/Reams/AA/AA001BS/AACommonBSClass.asmx"

                // ReDim cAAKOBETSUJITEParamClass(cABKobetsuProperty.Length - 1)

                // For intcnt = 0 To cABKobetsuProperty.Length - 1

                // 'ŒÂ•ÊŽ™Žèƒpƒ‰ƒ[ƒ^‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                // cAAKOBETSUJITEParamClass(intcnt) = New localhost.AAKOBETSUJITEParamClass

                // 'XVE’Ç‰Á‚µ‚½€–Ú‚ðŽæ“¾
                // cAAKOBETSUJITEParamClass(intcnt).m_strJUMINCD = CStr(cABKobetsuProperty(intcnt).p_strJUMINCD)
                // cAAKOBETSUJITEParamClass(intcnt).m_strHIYOKB = CStr(cABKobetsuProperty(intcnt).p_strHIYOKB)
                // cAAKOBETSUJITEParamClass(intcnt).m_strJIDOTEATESTYM = CStr(cABKobetsuProperty(intcnt).p_strJIDOTEATESTYM)
                // cAAKOBETSUJITEParamClass(intcnt).m_strJIDOTEATEEDYM = CStr(cABKobetsuProperty(intcnt).p_strJIDOTEATEEDYM)

                // Next

                // ' ZŠîŒÂ•ÊŽ™ŽèXVƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                // strControlData = UFControlToolClass.ControlGetStr(m_cfControlData)
                // intUpdCnt = cAACommonBSClass.UpdateKBJITE(strControlData, cAAKOBETSUJITEParamClass)

                // '*—š—ð”Ô† 000004 2005/12/01 C³ŠJŽn
                // ''''’Ç‰ÁEXVŒ”‚ª0Œ‚ÌŽžƒƒbƒZ[ƒW"ZŠî‚ÌŒÂ•ÊŽ–€‚ÌXV‚Í³í‚És‚¦‚Ü‚¹‚ñ‚Å‚µ‚½"‚ð•Ô‚·
                // '''If Not (intUpdCnt = cABKobetsuProperty.Length) Then

                // '''    cfErrorClass = New UFErrorClass(m_cfControlData.m_strBusinessId)
                // '''    'ƒGƒ‰[’è‹`‚ðŽæ“¾
                // '''    objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003002)
                // '''    '—áŠO‚ð¶¬
                // '''    csAppExp = New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                // '''    Throw csAppExp

                // '''End If

                // If strJukiResult = "0" Then
                // ' ŠÇ—î•ñ‚©‚çŽæ“¾‚µ‚½“à—e‚ª"0"‚Ì‚Æ‚«‚Íƒ`ƒFƒbƒN‚·‚é
                // '’Ç‰ÁEXVŒ”‚ª0Œ‚ÌŽžƒƒbƒZ[ƒW"ZŠî‚ÌŒÂ•ÊŽ–€‚ÌXV‚Í³í‚És‚¦‚Ü‚¹‚ñ‚Å‚µ‚½"‚ð•Ô‚·
                // If Not (intUpdCnt = cABKobetsuProperty.Length) Then

                // cfErrorClass = New UFErrorClass(m_cfControlData.m_strBusinessId)
                // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
                // objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003002)
                // '—áŠO‚ð¶¬
                // csAppExp = New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                // Throw csAppExp

                // End If
                // ElseIf strJukiResult = "1" Then
                // ' ƒ`ƒFƒbƒN‚µ‚È‚¢
                // Else
                // ' ƒ`ƒFƒbƒN‚µ‚È‚¢
                // End If
                // '*—š—ð”Ô† 000004 2005/12/01 C³I—¹
                // *—š—ð”Ô† 000005 2010/04/09 C³I—¹

                // *—š—ð”Ô† 000002 2005/10/13 ’Ç‰ÁŠJŽn
                // *—š—ð”Ô† 000004 2005/12/01 íœŠJŽn
                // ã‚Ì‚Ù‚¤‚Åˆ¶–¼ŠÇ—î•ñ‚ðŽæ“¾‚·‚é‚Ì‚ÅA‚»‚±‚ÅƒCƒ“ƒXƒ^ƒ“ƒXì¬‚·‚é
                // ''' ˆ¶–¼ŠÇ—î•ñ‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // * corresponds to VS2008 Start 2010/04/16 000006
                // '''cAtenaKanriJohoB = New ABAtenaKanriJohoBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass)
                // * corresponds to VS2008 End 2010/04/16 000006
                // *—š—ð”Ô† 000004 2005/12/01 íœI—¹

                // ˆ¶–¼ŠÇ—î•ñ‚ÌŽí•Ê04Ž¯•ÊƒL[21‚Ìƒf[ƒ^‚ðŽæ“¾‚·‚é(ã“cŽsÎ½Ä‚Æ‚Ì˜AŒg‚ð‚·‚é‚©‚Ç‚¤‚©‚Ì”»’è)
                csAtenaKanriEntity = cAtenaKanriJohoB.GetKanriJohoHoshu("04", "21");

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
            // *—š—ð”Ô† 000002 2005/10/13 ’Ç‰ÁI—¹

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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 20444


                    Input:
                    " + objExpTool.p_strErrorCode + "z" + _
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;

                    // ƒAƒvƒŠƒP[ƒVƒ‡ƒ“—áŠO‚ðì¬‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 20543


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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21792


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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22335


                    Input:
                    " + exAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22428


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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22697


                    Input:
                    " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 22778


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

        // *—š—ð”Ô† 000002 2005/10/13 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼Ž™“¶Žè“–ƒ[ƒNƒtƒ[
        // * 
        // * \•¶           Public Sub WorkFlowSet(ByVal cABKobetsuProperty() As ABKobetsuJiteProperty)
        // * 
        // * ‹@”\@@    @ ˆ¶–¼Ž™“¶Žè“–ƒf[ƒ^‚ðƒ[ƒNƒtƒ[‚Ö“n‚·B
        // * 
        // * ˆø”           ByVal cDatRow As DataRow  :XVƒf[ƒ^
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        public void WorkFlowSet(ABKobetsuJiteProperty[] cABKobetsuProperty)
        {
            const string THIS_METHOD_NAME = "WorkFlowSet";
            var csABJiteEntity = new DataSet();                 // ŒÂ•ÊŽ–€Ž™Žèƒf[ƒ^ƒZƒbƒg
            DataTable csABJiteTable;                      // ŒÂ•ÊŽ–€Ž™Žèƒf[ƒ^ƒe[ƒuƒ‹
            DataRow csABJiteRow;                          // ŒÂ•ÊŽ–€Ž™Žèƒf[ƒ^ƒƒE
            string strNen;                                // ì¬“úŽž
            int intRecCnt;                            // ˜A”Ô—pƒJƒEƒ“ƒ^[
            var cuCityInfoClass = new USSCityInfoClass();       // Žs’¬‘ºŠÇ—î•ñƒNƒ‰ƒX
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
                csABJiteTable = CreateColumnsData();
                csABJiteTable.TableName = ABKobetsuJiteEntity.TABLE_NAME;
                // ƒf[ƒ^ƒZƒbƒg‚Éƒe[ƒuƒ‹ƒZƒbƒg‚Ì’Ç‰Á
                csABJiteEntity.Tables.Add(csABJiteTable);

                // *****
                // *@‚Ps–Ú`‚Ì•ÒW
                // *
                // *****
                var loopTo = cABKobetsuProperty.Length - 1;
                for (intIdx = 0; intIdx <= loopTo; intIdx++)
                {
                    // V‹KƒŒƒR[ƒh‚Ìì¬
                    csABJiteRow = csABJiteEntity.Tables(ABKobetsuJiteEntity.TABLE_NAME).NewRow;
                    // Še€–Ú‚Éƒf[ƒ^‚ðƒZƒbƒg
                    csABJiteRow.Item(ABKobetsuJiteEntity.SHICHOSONCD) = strCityCD;
                    csABJiteRow.Item(ABKobetsuJiteEntity.SHIKIBETSUID) = "AA64";
                    csABJiteRow.Item(ABKobetsuJiteEntity.LASTRECKB) = "";
                    csABJiteRow.Item(ABKobetsuJiteEntity.SAKUSEIYMD) = strNen;
                    csABJiteRow.Item(ABKobetsuJiteEntity.RENBAN) = intRecCnt.ToString().RPadLeft(7, '0');
                    csABJiteRow.Item(ABKobetsuJiteEntity.JUMINCD) = cABKobetsuProperty[intIdx].p_strJUMINCD;
                    // *—š—ð”Ô† 000003 2005/10/25 ’Ç‰ÁŠJŽn
                    csABJiteRow.Item(ABKobetsuJiteEntity.CITYCD) = strCityCD;
                    csABJiteRow.Item(ABKobetsuJiteEntity.KYUCITYCD) = string.Empty;
                    // *—š—ð”Ô† 000003 2005/10/25 ’Ç‰ÁI—¹
                    csABJiteRow.Item(ABKobetsuJiteEntity.HIYOKB) = cABKobetsuProperty[intIdx].p_strHIYOKB;
                    csABJiteRow.Item(ABKobetsuJiteEntity.JIDOTEATESTYM) = cABKobetsuProperty[intIdx].p_strJIDOTEATESTYM;
                    csABJiteRow.Item(ABKobetsuJiteEntity.JIDOTEATEEDYM) = cABKobetsuProperty[intIdx].p_strJIDOTEATEEDYM;

                    // ƒf[ƒ^ƒZƒbƒg‚ÉƒŒƒR[ƒh‚ð’Ç‰Á
                    csABJiteEntity.Tables(ABKobetsuJiteEntity.TABLE_NAME).Rows.Add(csABJiteRow);
                    // ˜A”Ô—pƒJƒEƒ“ƒgƒAƒbƒv
                    intRecCnt += 1;
                }

                // *****
                // *@ÅIs‚Ì•ÒW
                // *
                // *****
                // V‹KƒŒƒR[ƒh‚Ìì¬
                csABJiteRow = csABJiteEntity.Tables(ABKobetsuJiteEntity.TABLE_NAME).NewRow;
                // Še€–Ú‚Éƒf[ƒ^‚ðƒZƒbƒg
                csABJiteRow.Item(ABKobetsuJiteEntity.SHICHOSONCD) = strCityCD;
                csABJiteRow.Item(ABKobetsuJiteEntity.SHIKIBETSUID) = "AA64";
                csABJiteRow.Item(ABKobetsuJiteEntity.LASTRECKB) = "E";
                csABJiteRow.Item(ABKobetsuJiteEntity.SAKUSEIYMD) = strNen;
                csABJiteRow.Item(ABKobetsuJiteEntity.RENBAN) = intRecCnt.ToString().RPadLeft(7, '0');
                csABJiteRow.Item(ABKobetsuJiteEntity.JUMINCD) = string.Empty;
                // *—š—ð”Ô† 000003 2005/10/25 ’Ç‰ÁŠJŽn
                csABJiteRow.Item(ABKobetsuJiteEntity.CITYCD) = string.Empty;
                csABJiteRow.Item(ABKobetsuJiteEntity.KYUCITYCD) = string.Empty;
                csABJiteRow.Item(ABKobetsuJiteEntity.HIYOKB) = string.Empty;
                csABJiteRow.Item(ABKobetsuJiteEntity.JIDOTEATESTYM) = string.Empty;
                csABJiteRow.Item(ABKobetsuJiteEntity.JIDOTEATEEDYM) = string.Empty;
                // *—š—ð”Ô† 000003 2005/10/25 ’Ç‰ÁI—¹
                // ƒf[ƒ^ƒZƒbƒg‚ÉƒŒƒR[ƒh‚ð’Ç‰Á
                csABJiteEntity.Tables(ABKobetsuJiteEntity.TABLE_NAME).Rows.Add(csABJiteRow);

                // *****
                // *@ƒ[ƒNƒtƒ[‘—M
                // *
                // *****
                // ƒf[ƒ^ƒZƒbƒgŽæ“¾ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cABAtenaCnvBClass = new ABAtenaCnvBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass);
                // ƒ[ƒNƒtƒ[‘—Mˆ—ŒÄ‚Ño‚µ
                cABAtenaCnvBClass.WorkFlowExec(csABJiteEntity, WORK_FLOW_NAME, DATA_NAME);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 29578


                Input:
                " + exAppExp.p_strErrorCode + "z" + _
                                                    "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 29671


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 29940


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                    "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 30021


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
            DataTable csABJiteTable;
            DataColumn csDataColumn;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ŒÂ•ÊŽ™Žèî•ñƒJƒ‰ƒ€’è‹`
                csABJiteTable = new DataTable();
                csABJiteTable.TableName = ABKobetsuJiteEntity.TABLE_NAME;
                csDataColumn = csABJiteTable.Columns.Add(ABKobetsuJiteEntity.SHICHOSONCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csABJiteTable.Columns.Add(ABKobetsuJiteEntity.SHIKIBETSUID, Type.GetType("System.String"));
                csDataColumn.MaxLength = 4;
                csDataColumn = csABJiteTable.Columns.Add(ABKobetsuJiteEntity.SAKUSEIYMD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 14;
                csDataColumn = csABJiteTable.Columns.Add(ABKobetsuJiteEntity.LASTRECKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csABJiteTable.Columns.Add(ABKobetsuJiteEntity.RENBAN, Type.GetType("System.String"));
                csDataColumn.MaxLength = 7;
                csDataColumn = csABJiteTable.Columns.Add(ABKobetsuJiteEntity.JUMINCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 15;
                // *—š—ð”Ô† 000003 2005/10/25 ’Ç‰ÁŠJŽn
                csDataColumn = csABJiteTable.Columns.Add(ABKobetsuJiteEntity.CITYCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csABJiteTable.Columns.Add(ABKobetsuJiteEntity.KYUCITYCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                // *—š—ð”Ô† 000003 2005/10/25 ’Ç‰ÁI—¹
                csDataColumn = csABJiteTable.Columns.Add(ABKobetsuJiteEntity.HIYOKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;
                csDataColumn = csABJiteTable.Columns.Add(ABKobetsuJiteEntity.JIDOTEATESTYM, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;
                csDataColumn = csABJiteTable.Columns.Add(ABKobetsuJiteEntity.JIDOTEATEEDYM, Type.GetType("System.String"));
                csDataColumn.MaxLength = 6;

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 33806


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 33904


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 34174


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 34259


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return csABJiteTable;

        }
        // *—š—ð”Ô† 000002 2005/10/13 ’Ç‰ÁI—¹

    }
}