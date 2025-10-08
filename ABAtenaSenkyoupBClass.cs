// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ˆ¶–¼‘I‹“ƒ}ƒXƒ^XV(ABAtenaSenkyoupBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/11/11@‹gàV@sé
// * 
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2004/03/26 000001     ƒrƒWƒlƒXID‚Ì•ÏXC³
// * 2005/02/17 000002     ƒŒƒXƒ|ƒ“ƒX‰ü‘PFUpdateAtenaSenkyo‚ÅAtenaƒ}ƒXƒ^XVC³
// * 2006/03/17 000003     “Š•[‹æƒR[ƒh‚ÌXV”»’è‚ðC³
// * 2010/02/09 000004     ŠÇ—î•ñ‚É‚æ‚èZŠîŒÂ•ÊŽ–€‚ÌXV‚ð§Œä‚·‚é
// * 2024/02/19 000005    yAB-9001_1zŒÂ•Ê‹LÚŽ–€‘Î‰ž(‰º‘º)
// ************************************************************************************************
using System;
using System.Linq;

namespace Densan.Reams.AB.AB000BB
{

    public class ABAtenaSenkyoupBClass
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
        private const string THIS_CLASS_NAME = "ABAtenaSenkyoupBClass";
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
        public ABAtenaSenkyoupBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

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
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼‘I‹“ƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateAtenaSenkyo(ByVal cABKobetsuProperty As ABKobetsuSenkyoProperty) As Integer
        // * 
        // * ‹@”\@@    @  ˆ¶–¼‘I‹“ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚éB
        // * 
        // * ˆø”           cABKobetsuProperty As ABKobetsuProperty  :XVƒf[ƒ^
        // * 
        // * –ß‚è’l         XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateAtenaSenkyo(ABKobetsuSenkyoProperty[] cABKobetsuProperty)
        {
            const string THIS_METHOD_NAME = "UpdateAtenaSenkyo";
            var intUpdCnt = default(int);
            ABAtenaSenkyoBClass cABAtenaSenkyoBClass;
            var cAAKOBETSUSENKYOParamClass = new localhost.AAKOBETSUSENKYOParamClass[1];
            localhost.AACommonBSClass cAACommonBSClass;
            DataSet csABAtenaSenkyoEntity;
            DataRow cDatRow;
            string strControlData;
            var cUSSCItyInfo = new USSCityInfoClass();

            ABAtenaBClass cABAtenaBClass;
            DataSet csABAtenaEntity;
            DataRow cDatRowt;
            var cSearchKey = new ABAtenaSearchKey();            // ˆ¶–¼ŒŸõƒL[
            UFErrorClass cfErrorClass;                    // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            UFAppException csAppExp;
            int intcnt;

            // *—š—ð”Ô† 000004 2010/02/09 ’Ç‰ÁŠJŽn
            ABAtenaKanriJohoBClass cAtenaKanriJohoB;      // ˆ¶–¼ŠÇ—î•ñ‚c‚`ƒrƒWƒlƒXƒNƒ‰ƒX
            DataSet csAtenaKanriEntity;                   // ˆ¶–¼ŠÇ—î•ñƒf[ƒ^ƒZƒbƒg
                                                          // *—š—ð”Ô† 000004 2010/02/09 ’Ç‰ÁI—¹

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

                // ˆ¶–¼‘I‹“‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cABAtenaSenkyoBClass = new ABAtenaSenkyoBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass);

                // ˆ¶–¼‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cABAtenaBClass = new ABAtenaBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass);
                cSearchKey.p_strJuminYuseniKB = "1";

                var loopTo = cABKobetsuProperty.Length - 1;
                for (intcnt = 0; intcnt <= loopTo; intcnt++)
                {

                    // ˆ¶–¼‘I‹“ƒ}ƒXƒ^’ŠoŒÄ‚Ño‚µ
                    csABAtenaSenkyoEntity = cABAtenaSenkyoBClass.GetAtenaSenkyo(cABKobetsuProperty[intcnt].p_strJUMINCD);

                    // ’Ç‰ÁEXV‚Ì”»’è
                    if (csABAtenaSenkyoEntity.Tables(ABAtenaSenkyoEntity.TABLE_NAME).Rows.Count == 0)
                    {

                        cDatRow = csABAtenaSenkyoEntity.Tables(ABAtenaSenkyoEntity.TABLE_NAME).NewRow();
                        // Še€–Ú‚ðƒvƒƒpƒeƒB‚©‚çŽæ“¾
                        cDatRow.Item(ABAtenaSenkyoEntity.JUMINCD) = cABKobetsuProperty[intcnt].p_strJUMINCD;
                        cDatRow.Item(ABAtenaSenkyoEntity.SENKYOSHIKAKUKB) = cABKobetsuProperty[intcnt].p_strSenkyoShikakuKB;
                        cDatRow.Item(ABAtenaSenkyoEntity.TOROKUJOTAIKBN) = string.Empty;

                        // Žs’¬‘ºƒR[ƒh
                        cDatRow.Item(ABAtenaSenkyoEntity.SHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);
                        // ‹ŒŽs’¬‘ºƒR[ƒh
                        cDatRow.Item(ABAtenaSenkyoEntity.KYUSHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);

                        // ƒf[ƒ^‚Ì’Ç‰Á
                        // csABAtenaSenkyoEntity.Tables(ABAtenaSenkyoEntity.TABLE_NAME).Rows.Add(cDatRow)

                        // ˆ¶–¼‘I‹“ƒ}ƒXƒ^’Ç‰Áƒƒ\ƒbƒhŒÄ‚Ño‚µ
                        intUpdCnt = cABAtenaSenkyoBClass.InsertAtenaSenkyo(cDatRow);
                    }

                    else
                    {

                        cDatRow = csABAtenaSenkyoEntity.Tables(ABAtenaSenkyoEntity.TABLE_NAME).Rows(0);
                        // Še€–Ú‚ðƒvƒƒpƒeƒB‚©‚çŽæ“¾
                        cDatRow.Item(ABAtenaSenkyoEntity.JUMINCD) = cABKobetsuProperty[intcnt].p_strJUMINCD;
                        cDatRow.Item(ABAtenaSenkyoEntity.SENKYOSHIKAKUKB) = cABKobetsuProperty[intcnt].p_strSenkyoShikakuKB;

                        // Žs’¬‘ºƒR[ƒh
                        cDatRow.Item(ABAtenaSenkyoEntity.SHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);
                        // ‹ŒŽs’¬‘ºƒR[ƒh
                        cDatRow.Item(ABAtenaSenkyoEntity.KYUSHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);

                        // ˆ¶–¼‘I‹“ƒ}ƒXƒ^XVƒƒ\ƒbƒhŒÄ‚Ño‚µ
                        intUpdCnt = cABAtenaSenkyoBClass.UpdateAtenaSenkyo(cDatRow);
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

                    // ˆ¶–¼ŒŸõƒL[‚ÌÝ’è‚ð‚·‚é
                    cSearchKey.p_strJuminCD = cABKobetsuProperty[intcnt].p_strJUMINCD;

                    // ˆ¶–¼ƒf[ƒ^‚ðŽæ“¾‚·‚é
                    csABAtenaEntity = cABAtenaBClass.GetAtenaBHoshu(1, cSearchKey);

                    // ’Ç‰ÁEXV‚Ì”»’è
                    if (csABAtenaEntity.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count == 0)
                    {
                        intUpdCnt = 0;
                    }
                    else
                    {
                        // *—š—ð”Ô† 000002 2005/02/17 C³ŠJŽn@000003 2006/03/17 C³ŠJŽn
                        // Row‚ðŽæ“¾
                        cDatRowt = csABAtenaEntity.Tables(ABAtenaEntity.TABLE_NAME).Rows(0);

                        // ˆ¶–¼ƒ}ƒXƒ^‚Ì“Š•[‹æƒR[ƒh‚ÆŒÂ•ÊƒvƒƒpƒeƒB‚Ì“Š•[‹æƒR[ƒh‚ª“¯‚¶‚¾‚Á‚½‚çXV‚µ‚È‚¢
                        if (!((string)cDatRowt.Item(ABAtenaEntity.TOHYOKUCD) == cABKobetsuProperty[intcnt].p_strTohyokuCD))
                        {
                            // “Š•[‹æCD‚ðƒvƒƒpƒeƒB‚©‚çŽæ“¾
                            cDatRowt.Item(ABAtenaEntity.TOHYOKUCD) = cABKobetsuProperty[intcnt].p_strTohyokuCD;

                            // ˆ¶–¼ƒ}ƒXƒ^’Ç‰Áƒƒ\ƒbƒhŒÄ‚Ño‚µ
                            intUpdCnt = cABAtenaBClass.UpdateAtenaB(cDatRowt);
                        }

                        // cDatRowt = csABAtenaEntity.Tables(ABAtenaEntity.TABLE_NAME).Rows(0)
                        // '“Š•[‹æCD‚ðƒvƒƒpƒeƒB‚©‚çŽæ“¾
                        // cDatRowt.Item(ABAtenaEntity.TOHYOKUCD) = cABKobetsuProperty(intcnt).p_strTohyokuCD

                        // 'ˆ¶–¼ƒ}ƒXƒ^’Ç‰Áƒƒ\ƒbƒhŒÄ‚Ño‚µ
                        // intUpdCnt = cABAtenaBClass.UpdateAtenaB(cDatRowt)
                        // *—š—ð”Ô† 000002 2004/02/17 C³I—¹@000003 2006/03/17 C³ŠJŽn
                    }

                    // ’Ç‰ÁEXVŒ”‚ª0Œ‚ÌŽž0‚ð•Ô‚·
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

                // *—š—ð”Ô† 000004 2010/02/09 C³ŠJŽn
                // ˆ¶–¼ŠÇ—î•ñ‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                cAtenaKanriJohoB = new ABAtenaKanriJohoBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass);
                // ˆ¶–¼ŠÇ—î•ñ‚ÌŽí•Ê04Ž¯•ÊƒL[01‚Ìƒf[ƒ^‚ð‘SŒŽæ“¾‚·‚é
                csAtenaKanriEntity = cAtenaKanriJohoB.GetKanriJohoHoshu("04", "15");

                // ŠÇ—î•ñ‚ÌZŠîXVƒŒƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢A‚Ü‚½‚ÍAƒpƒ‰ƒ[ƒ^‚ª"0"‚ÌŽž‚¾‚¯ZŠîXVˆ—‚ðs‚¤
                if (csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count == 0 || (string)csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER) == "0")
                {

                    // Webservice‚ÌURL‚ðWebConfig‚©‚çŽæ“¾‚µ‚ÄÝ’è‚·‚é
                    cAACommonBSClass = new localhost.AACommonBSClass();
                    cAACommonBSClass.Url = m_cfAAConfigDataClass.p_strWebServiceDomain + m_cfAAConfigDataClass.p_strWWWroot + "AA001BS/AACommonBSClass.asmx";
                    // cAACommonBSClass.Url = "http://localhost/Densan/Reams/AA/AA001BS/AACommonBSClass.asmx"

                    cAAKOBETSUSENKYOParamClass = new localhost.AAKOBETSUSENKYOParamClass[cABKobetsuProperty.Length];

                    var loopTo1 = cABKobetsuProperty.Length - 1;
                    for (intcnt = 0; intcnt <= loopTo1; intcnt++)
                    {

                        // ŒÂ•Ê‘I‹“ƒpƒ‰ƒ[ƒ^‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                        cAAKOBETSUSENKYOParamClass[intcnt] = new localhost.AAKOBETSUSENKYOParamClass();

                        // XVE’Ç‰Á‚µ‚½€–Ú‚ðŽæ“¾
                        cAAKOBETSUSENKYOParamClass[intcnt].m_strJuminCD = (string)cABKobetsuProperty[intcnt].p_strJUMINCD;
                        cAAKOBETSUSENKYOParamClass[intcnt].m_strSenkyoShikakuKB = (string)cABKobetsuProperty[intcnt].p_strSenkyoShikakuKB;
                        cAAKOBETSUSENKYOParamClass[intcnt].m_strTohyokuCD = (string)cABKobetsuProperty[intcnt].p_strTohyokuCD;

                    }

                    // ZŠîŒÂ•Ê‘I‹“XVƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                    strControlData = UFControlToolClass.ControlGetStr(m_cfControlData);
                    intUpdCnt = cAACommonBSClass.UpdateKBSENKYO(strControlData, cAAKOBETSUSENKYOParamClass);

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
            }
            // 'Webservice‚ÌURL‚ðWebConfig‚©‚çŽæ“¾‚µ‚ÄÝ’è‚·‚é
            // cAACommonBSClass = New localhost.AACommonBSClass
            // cAACommonBSClass.Url = m_cfAAConfigDataClass.p_strWebServiceDomain + m_cfAAConfigDataClass.p_strWWWroot + "AA001BS/AACommonBSClass.asmx"
            // 'cAACommonBSClass.Url = "http://localhost/Densan/Reams/AA/AA001BS/AACommonBSClass.asmx"

            // ReDim cAAKOBETSUSENKYOParamClass(cABKobetsuProperty.Length - 1)

            // For intcnt = 0 To cABKobetsuProperty.Length - 1

            // 'ŒÂ•Ê‘I‹“ƒpƒ‰ƒ[ƒ^‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            // cAAKOBETSUSENKYOParamClass(intcnt) = New localhost.AAKOBETSUSENKYOParamClass

            // 'XVE’Ç‰Á‚µ‚½€–Ú‚ðŽæ“¾
            // cAAKOBETSUSENKYOParamClass(intcnt).m_strJuminCD = CStr(cABKobetsuProperty(intcnt).p_strJUMINCD)
            // cAAKOBETSUSENKYOParamClass(intcnt).m_strSenkyoShikakuKB = CStr(cABKobetsuProperty(intcnt).p_strSenkyoShikakuKB)
            // cAAKOBETSUSENKYOParamClass(intcnt).m_strTohyokuCD = CStr(cABKobetsuProperty(intcnt).p_strTohyokuCD)

            // Next

            // ' ZŠîŒÂ•Ê‘I‹“XVƒƒ\ƒbƒh‚ðŽÀs‚·‚é
            // strControlData = UFControlToolClass.ControlGetStr(m_cfControlData)
            // intUpdCnt = cAACommonBSClass.UpdateKBSENKYO(strControlData, cAAKOBETSUSENKYOParamClass)

            /// Ç‰ÁEXVŒ”‚ª0Œ‚ÌŽžƒƒbƒZ[ƒW"ZŠî‚ÌŒÂ•ÊŽ–€‚ÌXV‚Í³í‚És‚¦‚Ü‚¹‚ñ‚Å‚µ‚½"‚ð•Ô‚·
            // If Not (intUpdCnt = cABKobetsuProperty.Length) Then

            // cfErrorClass = New UFErrorClass(m_cfControlData.m_strBusinessId)
            // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
            // objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003002)
            // '—áŠO‚ð¶¬
            // csAppExp = New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
            // Throw csAppExp

            // End If
            // *—š—ð”Ô† 000004 2010/02/09 C³I—¹

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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17279


                    Input:
                    " + objExpTool.p_strErrorCode + "z" + _
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;

                    // ƒAƒvƒŠƒP[ƒVƒ‡ƒ“—áŠO‚ðì¬‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17378


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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 18629


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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 19174


                    Input:
                    " + exAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 19267


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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 19536


                    Input:
                    " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 19617


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