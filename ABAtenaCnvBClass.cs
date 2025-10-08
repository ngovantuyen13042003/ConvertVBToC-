// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ƒŒƒvƒŠƒJ‚c‚aƒf[ƒ^ƒZƒbƒgì¬(ABAtenaCnvBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2004/02/12@‹gàV@sé
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2004/03/08  000001      ”í‘ã”[l‚Ìî•ñ‘SŒŽæ“¾ˆ—‚ð’Ç‰Á
// *                      @ (‚Ù‚Ú‘S‘Ì‚Ì\¬‚ðC³‚µ‚½‚Ì‚ÅC³‰ÓŠ‚ÍŽ¦‚³‚È‚¢)
// * 2004/04/05  000002      –{“XƒR[ƒh’Ç‰Á‚É”º‚¤C³
// * 2004/11/05  000003      ‘¬“xŒüã‰üCF‡@ USSCITYINFOƒNƒ‰ƒXƒCƒ“ƒXƒ^ƒ“ƒXˆÊ’u‚ð•ÏX‚·‚éB
// *                                       ‡A ‹Æ–±î•ñ‚Ìƒe[ƒuƒ‹‚ðƒƒ“ƒo‚É•ÏX‚·‚éB
// * 2005/02/06  000004      ƒ[ƒNƒtƒ[ŒÄ‚Ño‚µˆ—‚ÌC³iƒŒƒvƒŠƒJƒf[ƒ^ì¬ˆ—‚ðƒoƒbƒ`‚ÖˆÚ‚·j
// * 2005/10/13  000005      ã“cŽsƒzƒXƒg˜AŒgiƒ[ƒNƒtƒ[jˆ—‚ð’Ç‰Á(ƒ}ƒ‹ƒS‘ºŽR)
// * 2008/05/14  000006      ã“cŽs‰îŒìŒÂ•ÊƒzƒXƒg˜AŒgiƒ[ƒNƒtƒ[jˆ—‚ð’Ç‰Ái”ä‰Ãj
// * 2010/04/16  000007      VS2008‘Î‰ži”ä‰Ãj
// * 2022/12/16  000008    yAB-8010zZ–¯ƒR[ƒh¢‘ÑƒR[ƒh15Œ…‘Î‰ž(‰º‘º)
// ************************************************************************************************
using System;
using System.Collections;

namespace Densan.Reams.AB.AB000BB
{

    public class ABAtenaCnvBClass
    {

        // **
        // * ƒNƒ‰ƒXID’è‹`
        // * 
        private const string THIS_CLASS_NAME = "ABAtenaCnvBClass";

        // **
        // * ƒƒ“ƒo•Ï”
        // *  
        private UFControlData m_cfControlData;                        // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigData;                     // ŠÂ‹«î•ñƒf[ƒ^ƒNƒ‰ƒX
        private UFLogClass m_cfLog;                                   // ƒƒOo—ÍƒNƒ‰ƒX
        private UFRdbClass m_cfRdbClass;                              // RDBƒNƒ‰ƒX
        private UFRdbClass m_cfSFSKRdbClass;                          // RDBƒNƒ‰ƒX
        private UFRdbClass m_cfDainoRdbClass;                         // RDBƒNƒ‰ƒX
        private UFErrorClass m_cfErrorClass;                          // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private UFDataReaderClass m_cReader;                          // ƒf[ƒ^ƒŠ[ƒ_ƒNƒ‰ƒX

        private ArrayList m_aryABAtena;                               // ˆ¶–¼’ŠoƒŠƒXƒg”z—ñ
        private ArrayList m_aryABSfsk;                                // ‘—•tæ’ŠoƒŠƒXƒg”z—ñ
        private ArrayList m_aryABDaino;                               // ‘ã”[’ŠoƒŠƒXƒg”z—ñ
        private string m_strSQL;                                      // ˆ¶–¼–{l‚r‚p‚k•¶
        private string m_strSFSKSQL;                                  // ‘—•tæ‚r‚p‚k•¶
        private string m_strDAINOSQL;                                 // ‘ã”[‚r‚p‚k•¶
                                                                      // *—š—ð”Ô† 000001 2004/03/08 ’Ç‰ÁŠJŽn
        private string m_strHIDAINOSQL;                               // ”í‘ã”[‚r‚p‚k•¶
                                                                      // (Žb’èˆ—‚Ì‚½‚ß"50"‚Ì”Žš‚ÉˆÓ–¡‚Í‚È‚¢)
        private string[] m_strHidainoJuminCD = new string[51];
        private int m_intHiDaiCnt = 0;                            // ”í‘ã”[lƒJƒEƒ“ƒ^
                                                                  // *—š—ð”Ô† 000001 2004/03/08 ’Ç‰ÁI—¹
                                                                  // *—š—ð”Ô† 000003 2004/11/05 ’Ç‰ÁŠJŽn
        private string m_strCityCD;                                   // Žs’¬‘ºCD
        private DataTable m_csGyomuTable;                           // ‹Æ–±î•ñƒe[ƒuƒ‹
                                                                    // *—š—ð”Ô† 000003 2004/11/05 ’Ç‰ÁI—¹

        private string m_JuminCDA;                                    // ˆ¶–¼–{l—pZ–¯ƒR[ƒh
        private string m_JuminCDS;                                    // ˆ¶–¼‘—•tæ—pZ–¯ƒR[ƒh
        private string m_JuminCDD;                                    // ˆ¶–¼‘ã”[—pZ–¯ƒR[ƒh
        private int m_intRecCnt;                                  // ˜A”Ô‚ÌƒJƒEƒ^
        private string m_strNen;                                        // ì¬“úŽž

        public const string STR_A = "A";
        public const string STR_B = "B";
        public const string STR_C = "C";
        public const string STR_D = "D";
        // *—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁŠJŽn
        public const string STR_E = "E";
        public const string STR_E_ = "E_";
        // *—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁI—¹
        public const string STR_A_ = "A_";
        public const string STR_B_ = "B_";
        public const string STR_C_ = "C_";
        public const string STR_D_ = "D_";
        private const string SEPARATOR = ",";                         // ƒZƒpƒŒ[ƒ^
        public const string ATENA = "ˆ¶–¼";                           // ƒ[ƒNƒtƒ[–¼(ˆ¶–¼)
        public const string KOKUHO = "‘•ÛŒÂ•Ê";                      // ƒ[ƒNƒtƒ[–¼(‘•Û)
                                                                      // *—š—ð”Ô† 000005 2005/10/17 ’Ç‰ÁŠJŽn
        public const string JITE = "Ž™ŽèŒÂ•Ê";                        // ƒ[ƒNƒtƒ[–¼(Ž™Žè)
                                                                      // *—š—ð”Ô† 000005 2005/10/17 ’Ç‰ÁI—¹
                                                                      // *—š—ð”Ô† 000006 2008/05/14 ’Ç‰ÁŠJŽn
        public const string KAIGO = "‰îŒìŒÂ•Ê";                       // ƒ[ƒNƒtƒ[–¼(‰îŒì)
                                                                      // *—š—ð”Ô† 000006 2008/05/14 ’Ç‰ÁI—¹

        #region ƒRƒ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // * @@                          ByVal cfConfigDataClass As UFConfigDataClass
        // * @@                          ByVal csUFRdbClass As UFRdbClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABAtenaCnvBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

        {
            USSCityInfoClass cuCityInfo;                      // Žs’¬‘ºî•ñƒNƒ‰ƒX
                                                              // * corresponds to VS2008 Start 2010/04/16 000007
                                                              // Dim strCityCD As String                                 'Žs’¬‘ºƒR[ƒh
                                                              // * corresponds to VS2008 End 2010/04/16 000007

            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigData = cfConfigDataClass;
            m_cfRdbClass = cfRdbClass;

            // *—š—ð”Ô† 000003 2004/11/05 ’Ç‰ÁŠJŽn
            // '''ƒCƒ“ƒXƒ^ƒ“ƒX‰»
            cuCityInfo = new USSCityInfoClass();
            // Žs’¬‘ºî•ñ‚ÌŽæ“¾
            cuCityInfo.GetCityInfo(m_cfControlData);
            // Žs’¬‘ºº°ÄÞ‚ÌŽæ“¾
            m_strCityCD = cuCityInfo.p_strShichosonCD(0);
            // *—š—ð”Ô† 000003 2004/11/05 ’Ç‰ÁI—¹

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLog = new UFLogClass(cfConfigDataClass, cfControlData.m_strBusinessId);

        }
        #endregion

        // *—š—ð”Ô† 000004 2005/03/22 íœŠJŽn
        #region ˆ¶–¼’Ç‰Áˆ—
        // '************************************************************************************************
        // '* ƒƒ\ƒbƒh–¼     ˆ¶–¼’Ç‰Áˆ—
        // '* 
        // '* \•¶           Public Function AtenaCnv(ByVal cABToshoProperty() As ABToshoProperty,  
        // '* @@                                      ByVal WORK_FLOW_NAME As String,
        // '*                                           ByVal DATA_NAME As String) As DataSet
        // '* 
        // '* ‹@”\@@       ŒÂlƒf[ƒ^‚Ì’Ç‰Á‚ðs‚È‚¤B
        // '* 
        // '* ˆø”           cABToshoProperty()
        // '*                WORK_FLOW_NAME
        // '*                DATA_NAME
        // '* 
        // '* –ß‚è’l         ‚È‚µ
        // '************************************************************************************************
        // Public Function AtenaCnv(ByVal cABToshoProperty() As ABToshoProperty, ByVal WORK_FLOW_NAME As String, ByVal DATA_NAME As String) As DataSet
        // Const THIS_METHOD_NAME As String = "AtenaCnv"
        // Dim csToshoEntity As New DataSet()                      '“–‰—pƒf[ƒ^ƒZƒbƒg
        // Dim csToshoRow As DataRow                               '“–‰ƒf[ƒ^ƒƒE
        // Dim csToshoTable As DataTable                           '“–‰ƒf[ƒ^ƒe[ƒuƒ‹
        // Dim intCnt As Integer
        // '*—š—ð”Ô† 000003 2004/11/05 íœŠJŽn
        // '''Dim cuCityInfo As USSCityInfoClass                      'Žs’¬‘ºî•ñƒNƒ‰ƒX
        // '''Dim strCityCD As String                                 'Žs’¬‘ºƒR[ƒh
        // '*—š—ð”Ô† 000003 2004/11/05 íœI—¹
        // '*—š—ð”Ô† 000001 2004/03/08 ’Ç‰ÁŠJŽn
        // Dim csHiDainoEntity As DataSet                          '”í‘ã”[ƒf[ƒ^ƒZƒbƒg
        // Dim csHiDainoRow As DataRow                             '”í‘ã”[ƒf[ƒ^ƒƒE
        // Dim intHiDainoCnt As Integer
        // '*—š—ð”Ô† 000001 2004/03/08 ’Ç‰ÁI—¹

        // Try
        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // ' ì¬“úŽž(14Œ…)
        // m_strNen = DateTime.Now.ToString("yyyyMMddHHmmss")

        // ' ƒe[ƒuƒ‹ƒZƒbƒg‚ÌŽæ“¾
        // csToshoTable = Me.CreateColumnsData()
        // csToshoTable.TableName = ABToshoTable.TABLE_NAME
        // ' ƒf[ƒ^ƒZƒbƒg‚Éƒe[ƒuƒ‹ƒZƒbƒg‚Ì’Ç‰Á
        // csToshoEntity.Tables.Add(csToshoTable)

        // '•¨—íœ‚Æ‚»‚êˆÈŠO‚Ìê‡•ª‚¯
        // If Not (cABToshoProperty(0).p_strKoshinKB = "D") Then

        // '”í‘ã”[lƒJƒEƒ“ƒ^‚ð"0"‚É‚·‚é
        // m_intHiDaiCnt = 0

        // 'ƒvƒƒoƒeƒB‚ª‚È‚­‚È‚é‚Ü‚ÅŒJ‚è•Ô‚·
        // For intCnt = 0 To cABToshoProperty.Length - 1

        // '**
        // '*–{lî•ñ‚Ì‘Sî•ñŽæ“¾ˆ—
        // '*
        // csToshoEntity = Me.AtenaHenshu(cABToshoProperty(intCnt).p_strJuminCD, cABToshoProperty(intCnt).p_strRonSakuFG, cABToshoProperty(intCnt).p_strKoshinKB, csToshoEntity)


        // '**
        // '*”í‘ã”[lZ–¯ƒR[ƒh•ÒW
        // '*
        // ' ”í‘ã”[SQLŽÀs
        // csHiDainoEntity = m_cfRdbClass.GetDataSet(m_strHIDAINOSQL, ABDainoEntity.TABLE_NAME)
        // '‘ã”[ƒf[ƒ^‚ÌŽæ“¾
        // For Each csHiDainoRow In csHiDainoEntity.Tables(ABDainoEntity.TABLE_NAME).Rows
        // m_strHidainoJuminCD(m_intHiDaiCnt) = CType(csHiDainoRow.Item(ABDainoEntity.JUMINCD), String)
        // '”í‘ã”[l‚Ì”‚ðƒJƒEƒ“ƒg
        // m_intHiDaiCnt += 1
        // Next

        // Next

        // '**
        // '*”í‘ã”[l‚Ì‘Sî•ñŽæ“¾ˆ—
        // '*
        // For intHiDainoCnt = 0 To m_intHiDaiCnt - 1
        // '‘SŒŽæ“¾ˆ—
        // csToshoEntity = Me.AtenaHenshu(m_strHidainoJuminCD(intHiDainoCnt), cABToshoProperty(0).p_strRonSakuFG, cABToshoProperty(0).p_strKoshinKB, csToshoEntity)
        // Next

        // Else

        // '**
        // '*•¨—íœ‚Ì•ÒWˆ—
        // '*
        // '*—š—ð”Ô† 000003 2004/11/05 íœŠJŽn
        // ''''ƒCƒ“ƒXƒ^ƒ“ƒX‰»
        // '''cuCityInfo = New USSCityInfoClass()
        // ''''Žs’¬‘ºî•ñ‚ÌŽæ“¾
        // '''cuCityInfo.GetCityInfo(m_cfControlData)
        // ''''Žs’¬‘ºº°ÄÞ‚ÌŽæ“¾
        // '''strCityCD = cuCityInfo.p_strShichosonCD(0)
        // '*—š—ð”Ô† 000003 2004/11/05 íœI—¹

        // '˜A”Ô‚ÌƒJƒEƒ“ƒg‚ð‚Æ‚é
        // m_intRecCnt += 1
        // 'V‚µ‚¢Row‚ð’Ç‰Á
        // csToshoRow = csToshoEntity.Tables(ABToshoTable.TABLE_NAME).NewRow

        // ' Žs’¬‘ºº°ÄÞ(6Œ…)
        // '*—š—ð”Ô† 000003 2004/11/05 C³ŠJŽn
        // '''csToshoRow.Item(ABToshoTable.SHICHOSONCD) = strCityCD
        // csToshoRow.Item(ABToshoTable.SHICHOSONCD) = m_strCityCD
        // '*—š—ð”Ô† 000003 2004/11/05 C³I—¹
        // ' Ž¯•ÊID(4Œ…)
        // csToshoRow.Item(ABToshoTable.SHIKIBETSUID) = "AB21"
        // ' ì¬“úŽž(14Œ…)
        // csToshoRow.Item(ABToshoTable.SAKUSEIYMD) = m_strNen
        // ' ÅIs‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.LASTRECKB) = ""
        // ' ˜A”Ô(7Œ…)
        // csToshoRow.Item(ABToshoTable.RENBAN) = CType(m_intRecCnt, String).PadLeft(7, "0"c)
        // ' Z–¯ƒR[ƒh(8Œ…)(.NET12Œ…)
        // csToshoRow.Item(ABToshoTable.JUMIN_CD) = cABToshoProperty(intCnt).p_strJuminCD.Substring(4, 8)
        // ' XV‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.UPDATE_KBN) = cABToshoProperty(intCnt).p_strKoshinKB

        // '•ÒW‚µ‚½Row‚ðƒf[ƒ^ƒZƒbƒg‚É’Ç‰Á
        // csToshoEntity.Tables(ABToshoTable.TABLE_NAME).Rows.Add(csToshoRow)

        // End If

        // '**
        // '*ÅIs‚Ì•ÒWˆ—
        // '*
        // '˜A”Ô‚ÌƒJƒEƒ“ƒg‚ð‚Æ‚é
        // m_intRecCnt += 1
        // 'ÅIs‚ÌŽæ“¾
        // csToshoRow = csToshoEntity.Tables(ABToshoTable.TABLE_NAME).NewRow
        // csToshoRow = Me.ReflectLastData(csToshoRow)
        // '•ÒW‚µ‚½Row‚ðƒf[ƒ^ƒZƒbƒg‚É’Ç‰Á
        // csToshoEntity.Tables(ABToshoTable.TABLE_NAME).Rows.Add(csToshoRow)

        // '**
        // '*ƒ[ƒNƒtƒ[‘—Mˆ—ŒÄ‚Ño‚µ
        // '*
        // Me.WorkFlowExec(csToshoEntity, WORK_FLOW_NAME, DATA_NAME)

        // ' RDBƒAƒNƒZƒXƒƒOo—Í
        // m_cfLog.RdbWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
        // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
        // "ySQL“à—e:" + m_strSQL + m_strSFSKSQL + m_strDAINOSQL + "z")

        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // Catch exAppException As UFAppException
        // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
        // m_cfLog.WarningWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
        // "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
        // ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
        // Throw exAppException

        // Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
        // ' ƒGƒ‰[ƒƒOo—Í
        // m_cfLog.ErrorWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒGƒ‰[“à—e:" + exException.Message + "z")

        // ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
        // Throw exException

        // End Try

        // Return csToshoEntity

        // End Function
        #endregion

        #region ˆ¶–¼’Ç‰Áˆ—(MAIN)
        // '************************************************************************************************
        // '* ƒƒ\ƒbƒh–¼     ˆ¶–¼’Ç‰Áˆ—(ŒJ•Ô‚µ“à)
        // '* 
        // '* \•¶           Public Function AtenaHenshu(ByVal strJuminCD As String,   
        // '* @@                                      ByVal strRonSakuFG As String,
        // '*                                           ByVal strUpdataKB As String,
        // '*                                           ByVal csToshoEntity As DataSet) As DataSet
        // '* 
        // '* ‹@”\@@       ‘SŒ‚Ìƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // '* 
        // '* ˆø”           strJuminCD        
        // '*                strRonSakuFG
        // '*                strUpdataKB
        // '*              @csToshoEntity
        // '* 
        // '* –ß‚è’l         DataSet
        // '************************************************************************************************
        // Public Function AtenaHenshu(ByVal strJuminCD As String, ByVal strRonSakuFG As String, ByVal strUpdataKB As String, ByVal csToshoEntity As DataSet) As DataSet
        // Const THIS_METHOD_NAME As String = "AtenaHenshu"
        // Dim csToshoRow As DataRow                               '“–‰ƒf[ƒ^ƒƒE
        // Dim csAtenaEntity As DataSet                            '–{lˆ¶–¼î•ñ—pƒf[ƒ^ƒZƒbƒg
        // Dim csDainoEntity As DataSet                            '–{lˆ¶–¼+‘ã”[lî•ñ—pƒf[ƒ^ƒZƒbƒg
        // Dim csSfskEntity As New DataSet()                       '–{lˆ¶–¼+‘—fæî•ñ—pƒf[ƒ^ƒZƒbƒg
        // Dim csAtenaRow As DataRow                               '–{lˆ¶–¼î•ñ—pƒf[ƒ^ƒƒE
        // Dim csSfskRow As DataRow                                '–{lˆ¶–¼+‘—•tæî•ñ—pƒf[ƒ^ƒƒE
        // Dim csDainoRow As DataRow                               '–{lˆ¶–¼+‘ã”[lî•ñ—pƒf[ƒ^ƒƒE
        // Dim strKey(1) As String                                 'ƒL[
        // Dim intED As Integer = 1                                'Ž}”ÔƒJƒEƒ“ƒ^
        // '*—š—ð”Ô† 000003 2004/11/29 íœŠJŽn
        // '''''Dim csGyomuTable As DataTable
        // '*—š—ð”Ô† 000003 2004/11/29 íœI—¹
        // Dim csGyomuRow As DataRow                               '‹Æ–±ƒf[ƒ^ƒƒE
        // Dim csGERows As DataRow()                               '‹Æ–±EŽ}”Å—pƒf[ƒ^ƒƒE

        // Try
        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // ' ì¬“úŽž(14Œ…)
        // m_strNen = DateTime.Now.ToString("yyyyMMddHHmmss")

        // 'SQLì¬
        // Me.CreateSQL(strJuminCD, strRonSakuFG)

        // '**
        // '*–{lˆ¶–¼î•ñ•ÒW
        // '*
        // '–{lSQLŽÀs
        // csAtenaEntity = m_cfRdbClass.GetDataSet(m_strSQL, ABAtenaEntity.TABLE_NAME)
        // ' –{lˆ¶–¼ƒf[ƒ^‚ÌŽæ“¾
        // For Each csAtenaRow In csAtenaEntity.Tables(ABAtenaEntity.TABLE_NAME).Rows
        // '˜A”Ô‚ÌƒJƒEƒ“ƒg‚ð‚Æ‚é
        // m_intRecCnt += 1
        // 'V‚µ‚¢Row‚ð’Ç‰Á
        // csToshoRow = csToshoEntity.Tables(ABToshoTable.TABLE_NAME).NewRow()

        // ' ˆ¶–¼–{l‚Ìƒf[ƒ^‚ðˆês“Ç‚Ýž‚ÝƒZƒbƒg‚·‚é
        // csToshoRow = Me.ReflectAtenaData(csAtenaRow, csToshoRow, strUpdataKB)
        // '•ÒW‚µ‚½Row‚ðƒf[ƒ^ƒZƒbƒg‚É’Ç‰Á
        // csToshoEntity.Tables(ABToshoTable.TABLE_NAME).Rows.Add(csToshoRow)
        // Next

        // 'Ž}”Ô‚ÌƒJƒEƒ“ƒ^‚ð‰Šú‰»
        // intED = 0
        // '‹Æ–±ƒR[ƒh‚ÌƒL[‚ð‰Šú‰»
        // strKey(0) = String.Empty
        // strKey(1) = String.Empty
        // '‹Æ–±ƒR[ƒhEŽ}”Ô‚Ìƒe[ƒuƒ‹ì¬
        // '*—š—ð”Ô† 000003 2004/11/29 C³ŠJŽn
        // '‹Æ–±‚b‚cEŽ}”Åƒe[ƒuƒ‹‚Ìì¬
        // If m_csGyomuTable Is Nothing Then
        // m_csGyomuTable = Me.CreateClmGyomuData
        // End If
        // ''''''csGyomuTable = Me.CreateClmGyomuData
        // '*—š—ð”Ô† 000003 2004/11/29 C³I—¹

        // '**
        // '*–{lˆ¶–¼E‘—•tæî•ñ•ÒW
        // '*
        // ' ‘—•tæSQLŽÀs
        // csSfskEntity = m_cfRdbClass.GetDataSet(m_strSFSKSQL, ABSfskEntity.TABLE_NAME)
        // '‘—•tæƒf[ƒ^‚ÌŽæ“¾
        // ' ƒf[ƒ^•ÒW & o—Í
        // For Each csSfskRow In csSfskEntity.Tables(ABSfskEntity.TABLE_NAME).Rows
        // '˜A”Ô‚ÌƒJƒEƒ“ƒg‚ð‚Æ‚é
        // m_intRecCnt += 1
        // ''V‚µ‚¢Row‚ð’Ç‰Á
        // csToshoRow = csToshoEntity.Tables(ABToshoTable.TABLE_NAME).NewRow
        // ' ˆ¶–¼–{lE‘—•tæ‚ðˆês“Ç‚Ýž‚ÝƒZƒbƒg‚·‚é
        // csToshoRow = Me.ReflectSofusakiData(csSfskRow, csToshoRow, strUpdataKB)
        // 'Ž}”Ô‚Ì•ÒW
        // If Not (CType(csToshoRow.Item(ABToshoTable.GYOMU_CD), String) = String.Empty) Then
        // 'ƒuƒŒƒCƒNƒL[‚ÌÝ’è(ŒãƒL[)
        // strKey(0) = CType(csToshoRow.Item(ABToshoTable.GYOMU_CD), String)
        // '‘OƒL[‚ÆŒãƒL[‚ª“¯‚¶‚¾‚Á‚½‚çŽ}”ÔƒJƒEƒ“ƒ^‚É+1‚µ‚ÄŽ}”Ô‚Éƒf[ƒ^‚ð’Ç‰Á
        // If (strKey(0) = strKey(1)) Then
        // intED += 1
        // csToshoRow.Item(ABToshoTable.EDABAN) = CStr(intED).PadLeft(3, "0"c)
        // Else
        // '‹Æ–±ƒR[ƒhEŽ}”Ôƒe[ƒuƒ‹‚ÉV‹KƒƒE‚ðì¬
        // csGyomuRow = m_csGyomuTable.NewRow()
        // csGyomuRow.Item(ABToshoTable.GYOMU_CD) = strKey(1)
        // csGyomuRow.Item(ABToshoTable.EDABAN) = CStr(intED)
        // '‹Æ–±ƒR[ƒhEŽ}”Ôƒe[ƒuƒ‹‚ÉƒƒE‚ð’Ç‰Á
        // m_csGyomuTable.Rows.Add(csGyomuRow)

        // intED = 1
        // 'Ž}”Ô‚Éˆê”Ô–Ú‚Ìƒf[ƒ^(001)
        // csToshoRow.Item(ABToshoTable.EDABAN) = CStr(intED).PadLeft(3, "0"c)

        // End If
        // Else
        // intED = 1
        // 'Ž}”Ô‚Éˆê”Ô–Ú‚Ìƒf[ƒ^(001)
        // ' Ž}”Ô(3Œ…)
        // csToshoRow.Item(ABToshoTable.EDABAN) = CStr(intED).PadLeft(3, "0"c)
        // End If
        // 'ƒuƒŒƒCƒNƒL[‚ÌÝ’è(‘OƒL[)
        // strKey(1) = CType(csToshoRow.Item(ABToshoTable.GYOMU_CD), String)
        // '•ÒW‚µ‚½Row‚ðƒf[ƒ^ƒZƒbƒg‚É’Ç‰Á
        // csToshoEntity.Tables(ABToshoTable.TABLE_NAME).Rows.Add(csToshoRow)
        // Next

        // '‹Æ–±ƒR[ƒhEŽ}”Ôƒe[ƒuƒ‹‚ÉV‹KƒƒE‚ðì¬
        // csGyomuRow = m_csGyomuTable.NewRow()
        // csGyomuRow.Item(ABToshoTable.GYOMU_CD) = strKey(1)
        // csGyomuRow.Item(ABToshoTable.EDABAN) = CStr(intED)
        // '‹Æ–±ƒR[ƒhEŽ}”Ôƒe[ƒuƒ‹‚ÉƒƒE‚ð’Ç‰Á
        // m_csGyomuTable.Rows.Add(csGyomuRow)

        // 'Ž}”Ô‚ÌƒJƒEƒ“ƒ^‚ð‰Šú‰»
        // intED = 0
        // '‹Æ–±ƒR[ƒh‚ÌƒL[‚ð‰Šú‰»
        // strKey(0) = String.Empty
        // strKey(1) = String.Empty


        // '**
        // '*–{lˆ¶–¼E‘ã”[lˆ¶–¼î•ñ•ÒW
        // '*
        // ' ‘ã”[SQLŽÀs
        // csDainoEntity = m_cfRdbClass.GetDataSet(m_strDAINOSQL, ABDainoEntity.TABLE_NAME)

        // '‘ã”[ƒf[ƒ^‚ÌŽæ“¾
        // For Each csDainoRow In csDainoEntity.Tables(ABDainoEntity.TABLE_NAME).Rows
        // '˜A”Ô‚ÌƒJƒEƒ“ƒg‚ð‚Æ‚é
        // m_intRecCnt += 1
        // 'V‚µ‚¢Row‚ð’Ç‰Á
        // csToshoRow = csToshoEntity.Tables(ABToshoTable.TABLE_NAME).NewRow

        // ' ˆ¶–¼–{lE‘ã”[‚Ìƒf[ƒ^‚ðˆês“Ç‚Ýž‚ÝƒZƒbƒg‚·‚é
        // csToshoRow = Me.ReflectDainoData(csDainoRow, csToshoRow, strUpdataKB)

        // 'Ž}”Ô‚Ì•ÒW
        // If Not (CType(csToshoRow.Item(ABToshoTable.GYOMU_CD), String) = String.Empty) Then
        // 'ƒuƒŒƒCƒNƒL[‚ÌÝ’è(ŒãƒL[)
        // strKey(0) = CType(csToshoRow.Item(ABToshoTable.GYOMU_CD), String)
        // '‘OƒL[‚ÆŒãƒL[‚ª“¯‚¶‚¾‚Á‚½‚çŽ}”ÔƒJƒEƒ“ƒ^‚É+1‚µ‚ÄŽ}”Ô‚Éƒf[ƒ^‚ð’Ç‰Á
        // If (strKey(0) = strKey(1)) Then
        // intED += 1
        // csToshoRow.Item(ABToshoTable.EDABAN) = CStr(intED).PadLeft(3, "0"c)
        // Else
        // If Not (m_csGyomuTable.Rows.Count = 0) Then

        // '‹Æ–±ƒR[ƒh‚ðƒL[‚ðŒŸõðŒ‚Æ‚µ‚Ä‘¶Ý‚·‚éƒƒE‚ðŽæ“¾
        // csGERows = m_csGyomuTable.Select(ABToshoTable.GYOMU_CD + " = " + "'" + strKey(0) + "'")

        // '‹Æ–±‚b‚cEŽ}”Ôƒe[ƒuƒ‹‚Éƒf[ƒ^‚ª‘¶Ý‚·‚é‚©‚Ç‚¤‚©
        // If Not (csGERows.Length = 0) Then
        // intED = CType(csGERows(0).Item(ABToshoTable.EDABAN), Integer) + 1
        // csToshoRow.Item(ABToshoTable.EDABAN) = CType(intED, String).PadLeft(3, "0"c)
        // Else
        // intED = 1
        // 'Ž}”Ô‚Éˆê”Ô–Ú‚Ìƒf[ƒ^(001)
        // csToshoRow.Item(ABToshoTable.EDABAN) = CStr(intED).PadLeft(3, "0"c)
        // End If
        // Else
        // intED = 1
        // 'Ž}”Ô‚Éˆê”Ô–Ú‚Ìƒf[ƒ^(001)
        // csToshoRow.Item(ABToshoTable.EDABAN) = CStr(intED).PadLeft(3, "0"c)
        // End If
        // End If
        // Else
        // intED = 1
        // 'Ž}”Ô‚Éˆê”Ô–Ú‚Ìƒf[ƒ^(001)
        // ' Ž}”Ô(3Œ…)
        // csToshoRow.Item(ABToshoTable.EDABAN) = CStr(intED).PadLeft(3, "0"c)
        // End If
        // 'ƒuƒŒƒCƒNƒL[‚ÌÝ’è(‘OƒL[)
        // strKey(1) = CType(csToshoRow.Item(ABToshoTable.GYOMU_CD), String)

        // '•ÒW‚µ‚½Row‚ðƒf[ƒ^ƒZƒbƒg‚É’Ç‰Á
        // csToshoEntity.Tables(ABToshoTable.TABLE_NAME).Rows.Add(csToshoRow)
        // Next


        // ' RDBƒAƒNƒZƒXƒƒOo—Í
        // m_cfLog.RdbWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
        // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
        // "ySQL“à—e:" + m_strSQL + m_strSFSKSQL + m_strDAINOSQL + "z")

        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // Catch exAppException As UFAppException
        // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
        // m_cfLog.WarningWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
        // "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
        // ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
        // Throw exAppException

        // Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
        // ' ƒGƒ‰[ƒƒOo—Í
        // m_cfLog.ErrorWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒGƒ‰[“à—e:" + exException.Message + "z")

        // ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
        // Throw exException

        // End Try

        // Return csToshoEntity

        // End Function
        #endregion

        #region ˆ¶–¼ƒf[ƒ^•ÒW
        // '**
        // '*	ƒƒ\ƒbƒh–¼	ReflectAtenaData
        // '*	ŠT—v			ˆ¶–¼ƒf[ƒ^‚Ì”½‰f (–{lˆ¶–¼î•ñ)
        // '*	ˆø”			csRow		@@: ƒf[ƒ^Žæ“¾
        // '*			    	csToshoRow		: ƒf[ƒ^Ši”[
        // '*				    strUpDateKB		: XV‹æ•ª
        // '*	–ß‚è’l		‚È‚µ
        // '*
        // Private Function ReflectAtenaData(ByVal csRow As DataRow, ByVal csToshoRow As DataRow, ByVal strUpDateKB As String) As DataRow
        // Const THIS_METHOD_NAME As String = "ReflectAtenaData"
        // Dim strPrefixA As String = CType((STR_A_), String)
        // '*—š—ð”Ô† 000002 2004/04/058 ’Ç‰ÁŠJŽn
        // Dim strPrefixE As String = CType((STR_E_), String)
        // '*—š—ð”Ô† 000002 2004/04/058 ’Ç‰ÁI—¹

        // Try
        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // ' Žs’¬‘ºº°ÄÞ(6Œ…)
        // csToshoRow.Item(ABToshoTable.SHICHOSONCD) = csRow.Item(strPrefixA + ABAtenaEntity.SHICHOSONCD)
        // ' Ž¯•ÊID(4Œ…)
        // csToshoRow.Item(ABToshoTable.SHIKIBETSUID) = "AB21"
        // ' ì¬“úŽž(14Œ…)
        // csToshoRow.Item(ABToshoTable.SAKUSEIYMD) = m_strNen
        // ' ÅIs‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.LASTRECKB) = ""
        // ' ˜A”Ô(7Œ…)
        // csToshoRow.Item(ABToshoTable.RENBAN) = CType(m_intRecCnt, String).PadLeft(7, "0"c)
        // ' Z–¯ƒR[ƒh(8Œ…)(.NET12Œ…)
        // csToshoRow.Item(ABToshoTable.JUMIN_CD) = CType(csRow.Item(strPrefixA + ABAtenaEntity.JUMINCD), String).Substring(4, 8)
        // ' Ž}”Ô(3Œ…)
        // csToshoRow.Item(ABToshoTable.EDABAN) = "001"
        // ' ¢‘ÑƒR[ƒh(8Œ…)(.NET12Œ…)
        // If CType(csRow.Item(strPrefixA + ABAtenaEntity.STAICD), String) = String.Empty Then
        // csToshoRow.Item(ABToshoTable.SETAI_CD) = CType(csRow.Item(strPrefixA + ABAtenaEntity.STAICD), String)
        // ElseIf CType(csRow.Item(strPrefixA + ABAtenaEntity.STAICD), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.SETAI_CD) = "        "
        // Else
        // csToshoRow.Item(ABToshoTable.SETAI_CD) = CType(csRow.Item(strPrefixA + ABAtenaEntity.STAICD), String).Substring(4, 8)
        // End If
        // ' ƒf[ƒ^‹æ•ª(2Œ…)
        // csToshoRow.Item(ABToshoTable.DATA_KBN) = csRow.Item(strPrefixA + ABAtenaEntity.ATENADATAKB)
        // Dim strDataKB As String = CType(csToshoRow.Item(ABToshoTable.DATA_KBN), String)
        // ' Z–¯Šî–{‘ä’ ”Ô†(14Œ…)
        // csToshoRow.Item(ABToshoTable.DAICHO_NO) = ""
        // ' ƒf[ƒ^Ží•Ê(2Œ…)
        // csToshoRow.Item(ABToshoTable.DATA_SHU) = csRow.Item(strPrefixA + ABAtenaEntity.ATENADATASHU)
        // Dim strDataSB As String = CType(csToshoRow.Item(ABToshoTable.DATA_SHU), String)
        // ' ŒŸõ—pƒJƒii©j(24Œ…)
        // csToshoRow.Item(ABToshoTable.KANASEI) = csRow.Item(strPrefixA + ABAtenaEntity.SEARCHKANASEI)
        // ' ŒŸõ—pƒJƒii–¼j(16Œ…)
        // csToshoRow.Item(ABToshoTable.KANAMEI) = csRow.Item(strPrefixA + ABAtenaEntity.SEARCHKANAMEI)
        // ' ƒJƒi–¼Ì‚P(60Œ…)
        // csToshoRow.Item(ABToshoTable.KANAMEISHO1) = csRow.Item(strPrefixA + ABAtenaEntity.KANAMEISHO1)
        // ' Š¿Žš–¼Ì‚P(80Œ…)
        // csToshoRow.Item(ABToshoTable.MEISHO1) = csRow.Item(strPrefixA + ABAtenaEntity.KANJIMEISHO1)
        // ' ƒJƒi–¼Ì‚Q(60Œ…)
        // csToshoRow.Item(ABToshoTable.KANAMEISHO2) = csRow.Item(strPrefixA + ABAtenaEntity.KANAMEISHO2)
        // ' Š¿Žš–¼Ì‚Q(80Œ…)
        // csToshoRow.Item(ABToshoTable.MEISHO2) = csRow.Item(strPrefixA + ABAtenaEntity.KANJIMEISHO2)
        // '¶”NŒŽ“ú(8Œ…)
        // csToshoRow.Item(ABToshoTable.UMARE_YMD) = csRow.Item(strPrefixA + ABAtenaEntity.UMAREYMD)
        // ' ¶˜a—ï”NŒŽ“ú(7Œ…)
        // csToshoRow.Item(ABToshoTable.UMARE_WYMD) = csRow.Item(strPrefixA + ABAtenaEntity.UMAREWMD)
        // '«•ÊƒR[ƒh(1Œ…)
        // csToshoRow.Item(ABToshoTable.SEIBETSU_CD) = csRow.Item(strPrefixA + ABAtenaEntity.SEIBETSUCD)
        // ' «•Ê(2Œ…)
        // csToshoRow.Item(ABToshoTable.SEIBETSU) = csRow.Item(strPrefixA + ABAtenaEntity.SEIBETSU)
        // ' ‘±•¿ƒR[ƒh(8Œ…)
        // csToshoRow.Item(ABToshoTable.ZOKUGARA_CD) = csRow.Item(strPrefixA + ABAtenaEntity.ZOKUGARACD)
        // ' ‘±•¿(30Œ…)
        // csToshoRow.Item(ABToshoTable.ZOKUGARA) = csRow.Item(strPrefixA + ABAtenaEntity.ZOKUGARA)
        // ' ‘æ‚Q‘±•¿ƒR[ƒh(8Œ…)
        // csToshoRow.Item(ABToshoTable.ZOKUGARA_CD2) = csRow.Item(strPrefixA + ABAtenaEntity.DAI2ZOKUGARACD)
        // ' ‘æ‚Q‘±•¿(30Œ…)
        // csToshoRow.Item(ABToshoTable.ZOKUGARA2) = csRow.Item(strPrefixA + ABAtenaEntity.DAI2ZOKUGARA)
        // ' ‹¤—L‘ã•\ŽÒZ–¯ƒR[ƒh(8Œ…)
        // csToshoRow.Item(ABToshoTable.K_DAIHYOJUMIN_CD) = ""
        // ' –@l‘ã•\ŽÒ–¼iŠ¿Žšj(60Œ…)
        // csToshoRow.Item(ABToshoTable.H_DAIHYOMEI) = csRow.Item(strPrefixA + ABAtenaEntity.KANJIHJNDAIHYOSHSHIMEI)
        // ' ŽY‹Æ•ª—ÞƒR[ƒh(4Œ…)
        // csToshoRow.Item(ABToshoTable.SANGYO_CD) = ""
        // '*—š—ð”Ô† 000002 2004/04/058 C³ŠJŽn
        // If CType(csRow.Item(strPrefixE + ABDainoEntity.DAINOJUMINCD), String).Trim = String.Empty Then
        // ' –{“XƒR[ƒh(8Œ…)
        // csToshoRow.Item(ABToshoTable.HONTEN_CD) = ""
        // Else
        // ' –{“XƒR[ƒh(8Œ…)
        // csToshoRow.Item(ABToshoTable.HONTEN_CD) = CType(csRow.Item(strPrefixE + ABDainoEntity.DAINOJUMINCD), String).Substring(4, 8)
        // End If
        // 'csToshoRow.Item(ABToshoTable.HONTEN_CD) = ""
        // '*—š—ð”Ô† 000002 2004/04/058 C³I—¹
        // ' ”Ä—p‹æ•ª‚P(1Œ…)
        // '(ƒf[ƒ^‹æ•ª‚ª"11""12"‚ÌŽžAƒJƒi–¼Ì‚Q‚ª‚ ‚éŽž‚Ì”»’è)
        // If (strDataKB = "11" Or strDataKB = "12") Then
        // If Not (csToshoRow.Item(ABToshoTable.KANAMEISHO2) Is String.Empty) Then
        // csToshoRow.Item(ABToshoTable.HANYO_KBN1) = "T"
        // Else
        // csToshoRow.Item(ABToshoTable.HANYO_KBN1) = "S"
        // End If
        // Else
        // csToshoRow.Item(ABToshoTable.HANYO_KBN1) = csRow.Item(strPrefixA + ABAtenaEntity.HANYOKB1)
        // End If
        // ' –@lŒ`‘Ô(20Œ…)
        // csToshoRow.Item(ABToshoTable.HOJINKEITAI) = csRow.Item(strPrefixA + ABAtenaEntity.KANJIHJNKEITAI)
        // ' ŒÂl–@l‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.KOJINHOJIN_KBN) = csRow.Item(strPrefixA + ABAtenaEntity.KJNHJNKB)
        // ' ‘¼l”(4Œ…)
        // csToshoRow.Item(ABToshoTable.HOKA_NINZU) = ""
        // ' ”Ä—p‹æ•ª‚Q(1Œ…)
        // '(ƒf[ƒ^‹æ•ª‚ª"18""28"‚ÌŽžA“]oŠm’èZŠE“]o—\’èZŠ‚ª‚ ‚éŽž‚Ì”»’è)
        // If strDataSB = "18" Or strDataSB = "28" Then
        // If Not (csRow.Item(strPrefixA + ABAtenaEntity.TENSHUTSUKKTIJUSHO) Is String.Empty) Then
        // csToshoRow.Item(ABToshoTable.HANYO_KBN2) = "K"
        // ElseIf Not (csRow.Item(strPrefixA + ABAtenaEntity.TENSHUTSUYOTEIJUSHO) Is String.Empty) Then
        // csToshoRow.Item(ABToshoTable.HANYO_KBN2) = "Y"
        // Else
        // csToshoRow.Item(ABToshoTable.HANYO_KBN2) = csRow.Item(strPrefixA + ABAtenaEntity.HANYOKB2)
        // End If
        // Else
        // csToshoRow.Item(ABToshoTable.HANYO_KBN2) = csRow.Item(strPrefixA + ABAtenaEntity.HANYOKB2)
        // End If
        // ' ŠÇ“àŠÇŠO‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.NAIGAI_KBN) = csRow.Item(strPrefixA + ABAtenaEntity.KANNAIKANGAIKB)
        // ' —X•Ö”Ô†(7Œ…)
        // csToshoRow.Item(ABToshoTable.YUBIN_NO) = csRow.Item(strPrefixA + ABAtenaEntity.YUBINNO)
        // ' ZŠƒR[ƒh(11Œ…)
        // csToshoRow.Item(ABToshoTable.JUSHO_CD) = csRow.Item(strPrefixA + ABAtenaEntity.JUSHOCD)
        // ' ZŠ–¼(60Œ…)
        // csToshoRow.Item(ABToshoTable.JUSHO) = csRow.Item(strPrefixA + ABAtenaEntity.JUSHO)
        // ' ”Ô’nƒR[ƒh‚P(5Œ…)
        // csToshoRow.Item(ABToshoTable.BANCHI_CD1) = csRow.Item(strPrefixA + ABAtenaEntity.BANCHICD1)
        // ' ”Ô’nƒR[ƒh‚Q(5Œ…)
        // csToshoRow.Item(ABToshoTable.BANCHI_CD2) = csRow.Item(strPrefixA + ABAtenaEntity.BANCHICD2)
        // ' ”Ô’nƒR[ƒh‚R(5Œ…)
        // csToshoRow.Item(ABToshoTable.BANCHI_CD3) = csRow.Item(strPrefixA + ABAtenaEntity.BANCHICD3)
        // ' ”Ô’n(40Œ…)
        // csToshoRow.Item(ABToshoTable.BANCHI) = csRow.Item(strPrefixA + ABAtenaEntity.BANCHI)
        // ' •û‘ƒtƒ‰ƒO(1Œ…)
        // csToshoRow.Item(ABToshoTable.KATAGAKI_FLG) = csRow.Item(strPrefixA + ABAtenaEntity.KATAGAKIFG)
        // ' •û‘ƒR[ƒh(4Œ…)
        // csToshoRow.Item(ABToshoTable.KATAGAKI_CD) = csRow.Item(strPrefixA + ABAtenaEntity.KATAGAKICD)
        // ' •û‘(60Œ…)
        // csToshoRow.Item(ABToshoTable.KATAGAKI) = csRow.Item(strPrefixA + ABAtenaEntity.KATAGAKI)
        // ' ˜A—æ‚P(14Œ…)
        // csToshoRow.Item(ABToshoTable.RENRAKUSAKI1) = csRow.Item(strPrefixA + ABAtenaEntity.RENRAKUSAKI1)
        // ' ˜A—æ‚Q(14Œ…)
        // csToshoRow.Item(ABToshoTable.RENRAKUSAKI2) = csRow.Item(strPrefixA + ABAtenaEntity.RENRAKUSAKI2)
        // ' s­‹æƒR[ƒh(7Œ…)(.NET9Œ…)
        // If csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUCD) Is String.Empty Or _
        // CType(csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUCD), String).Length <= 7 Then
        // csToshoRow.Item(ABToshoTable.GYOSEIKU_CD) = csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUCD)
        // ElseIf CType(csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUCD), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.GYOSEIKU_CD) = "       "
        // Else
        // csToshoRow.Item(ABToshoTable.GYOSEIKU_CD) = CType(csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUCD), String).Substring(2, 7)
        // End If
        // ' s­‹æ–¼(60Œ…)
        // csToshoRow.Item(ABToshoTable.GYOSEIKU) = csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUMEI)
        // ' ’n‹æƒR[ƒh‚P(6Œ…)(.NET8Œ…)
        // If csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD1) Is String.Empty Or _
        // CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD1), String).Length <= 6 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD1) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD1)
        // ElseIf CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD1), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD1) = "      "
        // Else
        // csToshoRow.Item(ABToshoTable.CHIKU_CD1) = CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD1), String).Substring(2, 6)
        // End If
        // ' ’n‹æ–¼‚P(60Œ…)
        // csToshoRow.Item(ABToshoTable.CHIKU1) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUMEI1)
        // ' ’n‹æƒR[ƒh‚Q(6Œ…)(.NET8Œ…)
        // If csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD2) Is String.Empty Or _
        // CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD2), String).Length <= 6 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD2) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD2)
        // ElseIf CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD2), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD2) = "      "
        // Else
        // csToshoRow.Item(ABToshoTable.CHIKU_CD2) = CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD2), String).Substring(2, 6)
        // End If
        // ' ’n‹æ–¼‚Q(60Œ…)
        // csToshoRow.Item(ABToshoTable.CHIKU2) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUMEI2)
        // ' ’n‹æƒR[ƒh‚R(6Œ…)(.NET8Œ…)
        // If csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD3) Is String.Empty Or _
        // CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD3), String).Length <= 6 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD3) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD3)
        // ElseIf CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD3), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD3) = "      "
        // Else
        // csToshoRow.Item(ABToshoTable.CHIKU_CD3) = CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD3), String).Substring(2, 6)
        // End If
        // ' ’n‹æ–¼‚R(60Œ…)
        // csToshoRow.Item(ABToshoTable.CHIKU3) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUMEI3)
        // ' “o˜^ˆÙ“®”NŒŽ“ú(8Œ…)
        // csToshoRow.Item(ABToshoTable.TRK_IDO_YMD) = csRow.Item(strPrefixA + ABAtenaEntity.TOROKUIDOYMD)
        // ' “o˜^Ž–—RƒR[ƒh(2Œ…)
        // csToshoRow.Item(ABToshoTable.TRK_JIYU_CD) = csRow.Item(strPrefixA + ABAtenaEntity.TOROKUJIYUCD)
        // ' íœˆÙ“®”NŒŽ“ú(8Œ…)
        // csToshoRow.Item(ABToshoTable.SJO_IDO_YMD) = csRow.Item(strPrefixA + ABAtenaEntity.SHOJOIDOYMD)
        // ' íœŽ–—RƒR[ƒh(2Œ…)
        // csToshoRow.Item(ABToshoTable.SJO_JIYU_CD) = csRow.Item(strPrefixA + ABAtenaEntity.SHOJOJIYUCD)
        // ' ÅI—š—ð”Ô†(4Œ…)
        // csToshoRow.Item(ABToshoTable.LAST_RIREKI_NO) = ""
        // ' ˆÙ“®”NŒŽ“ú(8Œ…)
        // csToshoRow.Item(ABToshoTable.IDO_YMD) = csRow.Item(strPrefixA + ABAtenaEntity.CKINIDOYMD)
        // ' ˆÙ“®Ž–—RƒR[ƒh(2Œ…)
        // csToshoRow.Item(ABToshoTable.JIYU_CD) = csRow.Item(strPrefixA + ABAtenaEntity.CKINJIYUCD)
        // ' “o˜^”NŒŽ“ú(8Œ…)
        // csToshoRow.Item(ABToshoTable.TRK_YMD) = csRow.Item(strPrefixA + ABAtenaEntity.CKINTDKDYMD)
        // ' XV‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.UPDATE_KBN) = strUpDateKB
        // ' ƒ†[ƒUID(8Œ…)(.NET32Œ…)
        // If CType(csRow.Item(strPrefixA + ABAtenaEntity.SAKUSEIUSER), String).Length >= 8 Then
        // csToshoRow.Item(ABToshoTable.USER_ID) = CType(csRow.Item(strPrefixA + ABAtenaEntity.SAKUSEIUSER), String).Substring(0, 8)
        // Else
        // csToshoRow.Item(ABToshoTable.USER_ID) = csRow.Item(strPrefixA + ABAtenaEntity.SAKUSEIUSER)
        // End If
        // ' ’[––ID(8Œ…)(.NET32Œ…)
        // If CType(csRow.Item(strPrefixA + ABAtenaEntity.TANMATSUID), String).Length >= 8 Then
        // csToshoRow.Item(ABToshoTable.WS_ID) = CType(csRow.Item(strPrefixA + ABAtenaEntity.TANMATSUID), String).Substring(0, 8)
        // Else
        // csToshoRow.Item(ABToshoTable.WS_ID) = csRow.Item(strPrefixA + ABAtenaEntity.TANMATSUID)
        // End If
        // ' ƒ^ƒCƒ€ƒXƒ^ƒ“ƒv(14Œ…)
        // csToshoRow.Item(ABToshoTable.UP_DATE) = ""
        // ' ˜_—ƒƒbƒNƒL[(6Œ…)
        // csToshoRow.Item(ABToshoTable.LOCK_KEY) = ""

        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // Catch exAppException As UFAppException
        // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
        // m_cfLog.WarningWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
        // "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
        // ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
        // Throw exAppException

        // Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
        // ' ƒGƒ‰[ƒƒOo—Í
        // m_cfLog.ErrorWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒGƒ‰[“à—e:" + exException.Message + "z")

        // ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
        // Throw exException

        // End Try

        // Return csToshoRow

        // End Function
        #endregion

        #region ‘—•tæƒf[ƒ^•ÒW
        // '**
        // '*	ƒƒ\ƒbƒh–¼	ReflectSofusakiData
        // '*	ŠT—v			‘—•tæƒf[ƒ^‚Ì”½‰f
        // '*	ˆø”			csRow		@@: ƒf[ƒ^Žæ“¾
        // '*				    csToshoRow		: ƒf[ƒ^Ši”[
        // '*				    strUpDateKB		: XV‹æ•ª
        // '*	–ß‚è’l		‚È‚µ
        // '*
        // Private Function ReflectSofusakiData(ByVal csRow As DataRow, ByVal csToshoRow As DataRow, ByVal strUpDateKB As String) As DataRow
        // Const THIS_METHOD_NAME As String = "ReflectSofusakiData"
        // Dim strPrefixA As String = CType((STR_A_), String)
        // Dim strPrefixB As String = CType((STR_B_), String)
        // '*—š—ð”Ô† 000002 2004/04/058 ’Ç‰ÁŠJŽn
        // Dim strPrefixE As String = CType((STR_E_), String)
        // '*—š—ð”Ô† 000002 2004/04/058 ’Ç‰ÁI—¹

        // Try
        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // ' Žs’¬‘ºº°ÄÞ(6Œ…)
        // csToshoRow.Item(ABToshoTable.SHICHOSONCD) = csRow.Item(strPrefixA + ABAtenaEntity.SHICHOSONCD)
        // ' Ž¯•ÊID(4Œ…)
        // csToshoRow.Item(ABToshoTable.SHIKIBETSUID) = "AB21"
        // ' ì¬“úŽž(14Œ…)
        // csToshoRow.Item(ABToshoTable.SAKUSEIYMD) = m_strNen
        // ' ÅIs‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.LASTRECKB) = ""
        // ' ˜A”Ô(7Œ…)
        // csToshoRow.Item(ABToshoTable.RENBAN) = CType(m_intRecCnt, String).PadLeft(7, "0"c)
        // ' Z–¯ƒR[ƒh(8Œ…)(.NET12Œ…)
        // csToshoRow.Item(ABToshoTable.JUMIN_CD) = CType(csRow.Item(strPrefixA + ABAtenaEntity.JUMINCD), String).Substring(4, 8)
        // ' Ž}”Ô(3Œ…)
        // 'csToshoRow.Item(ABToshoTable.EDABAN) = ""
        // ' ¢‘ÑƒR[ƒh(8Œ…)(.NET12Œ…)
        // If CType(csRow.Item(strPrefixA + ABAtenaEntity.STAICD), String) = String.Empty Then
        // csToshoRow.Item(ABToshoTable.SETAI_CD) = CType(csRow.Item(strPrefixA + ABAtenaEntity.STAICD), String)
        // ElseIf CType(csRow.Item(strPrefixA + ABAtenaEntity.STAICD), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.SETAI_CD) = "        "
        // Else
        // csToshoRow.Item(ABToshoTable.SETAI_CD) = CType(csRow.Item(strPrefixA + ABAtenaEntity.STAICD), String).Substring(4, 8)
        // End If
        // ' ƒf[ƒ^‹æ•ª(2Œ…)
        // csToshoRow.Item(ABToshoTable.DATA_KBN) = csRow.Item(strPrefixA + ABAtenaEntity.ATENADATAKB)
        // Dim strDataKB As String = CType(csToshoRow.Item(ABToshoTable.DATA_KBN), String)
        // ' Z–¯Šî–{‘ä’ ”Ô†(14Œ…)
        // csToshoRow.Item(ABToshoTable.DAICHO_NO) = ""
        // ' ƒf[ƒ^Ží•Ê(2Œ…)
        // csToshoRow.Item(ABToshoTable.DATA_SHU) = csRow.Item(strPrefixA + ABAtenaEntity.ATENADATASHU)
        // Dim strDataSB As String = CType(csToshoRow.Item(ABToshoTable.DATA_SHU), String)
        // ' ŒŸõ—pƒJƒii©j(24Œ…)
        // csToshoRow.Item(ABToshoTable.KANASEI) = csRow.Item(strPrefixA + ABAtenaEntity.SEARCHKANASEI)
        // ' ŒŸõ—pƒJƒii–¼j(16Œ…)
        // csToshoRow.Item(ABToshoTable.KANAMEI) = csRow.Item(strPrefixA + ABAtenaEntity.SEARCHKANAMEI)
        // ' ƒJƒi–¼Ì‚P(60Œ…)
        // csToshoRow.Item(ABToshoTable.KANAMEISHO1) = csRow.Item(strPrefixA + ABAtenaEntity.KANAMEISHO1)
        // ' Š¿Žš–¼Ì‚P(80Œ…)
        // csToshoRow.Item(ABToshoTable.MEISHO1) = csRow.Item(strPrefixA + ABAtenaEntity.KANJIMEISHO1)
        // ' ƒJƒi–¼Ì‚Q(60Œ…)
        // csToshoRow.Item(ABToshoTable.KANAMEISHO2) = csRow.Item(strPrefixA + ABAtenaEntity.KANAMEISHO2)
        // ' Š¿Žš–¼Ì‚Q(80Œ…)
        // csToshoRow.Item(ABToshoTable.MEISHO2) = csRow.Item(strPrefixA + ABAtenaEntity.KANJIMEISHO2)
        // '¶”NŒŽ“ú(8Œ…)
        // csToshoRow.Item(ABToshoTable.UMARE_YMD) = csRow.Item(strPrefixA + ABAtenaEntity.UMAREYMD)
        // ' ¶˜a—ï”NŒŽ“ú(7Œ…)
        // csToshoRow.Item(ABToshoTable.UMARE_WYMD) = csRow.Item(strPrefixA + ABAtenaEntity.UMAREWMD)
        // '«•ÊƒR[ƒh(1Œ…)
        // csToshoRow.Item(ABToshoTable.SEIBETSU_CD) = csRow.Item(strPrefixA + ABAtenaEntity.SEIBETSUCD)
        // ' «•Ê(2Œ…)
        // csToshoRow.Item(ABToshoTable.SEIBETSU) = csRow.Item(strPrefixA + ABAtenaEntity.SEIBETSU)
        // ' ‘±•¿ƒR[ƒh(8Œ…)
        // csToshoRow.Item(ABToshoTable.ZOKUGARA_CD) = csRow.Item(strPrefixA + ABAtenaEntity.ZOKUGARACD)
        // ' ‘±•¿(30Œ…)
        // csToshoRow.Item(ABToshoTable.ZOKUGARA) = csRow.Item(strPrefixA + ABAtenaEntity.ZOKUGARA)
        // ' ‘æ‚Q‘±•¿ƒR[ƒh(8Œ…)
        // csToshoRow.Item(ABToshoTable.ZOKUGARA_CD2) = csRow.Item(strPrefixA + ABAtenaEntity.DAI2ZOKUGARACD)
        // ' ‘æ‚Q‘±•¿(30Œ…)
        // csToshoRow.Item(ABToshoTable.ZOKUGARA2) = csRow.Item(strPrefixA + ABAtenaEntity.DAI2ZOKUGARA)
        // ' ‹¤—L‘ã•\ŽÒZ–¯ƒR[ƒh(8Œ…)
        // csToshoRow.Item(ABToshoTable.K_DAIHYOJUMIN_CD) = ""
        // ' –@l‘ã•\ŽÒ–¼iŠ¿Žšj(60Œ…)
        // csToshoRow.Item(ABToshoTable.H_DAIHYOMEI) = csRow.Item(strPrefixA + ABAtenaEntity.KANJIHJNDAIHYOSHSHIMEI)
        // ' ŽY‹Æ•ª—ÞƒR[ƒh(4Œ…)
        // csToshoRow.Item(ABToshoTable.SANGYO_CD) = ""
        // '*—š—ð”Ô† 000002 2004/04/058 C³ŠJŽn
        // If CType(csRow.Item(strPrefixE + ABDainoEntity.DAINOJUMINCD), String).Trim = String.Empty Then
        // ' –{“XƒR[ƒh(8Œ…)
        // csToshoRow.Item(ABToshoTable.HONTEN_CD) = ""
        // Else
        // ' –{“XƒR[ƒh(8Œ…)
        // csToshoRow.Item(ABToshoTable.HONTEN_CD) = CType(csRow.Item(strPrefixE + ABDainoEntity.DAINOJUMINCD), String).Substring(4, 8)
        // End If
        // 'csToshoRow.Item(ABToshoTable.HONTEN_CD) = ""
        // '*—š—ð”Ô† 000002 2004/04/058 C³I—¹
        // ' ”Ä—p‹æ•ª‚P(1Œ…)
        // '(ƒf[ƒ^‹æ•ª‚ª"11""12"‚ÌŽžAƒJƒi–¼Ì‚Q‚ª‚ ‚éŽž‚Ì”»’è)
        // If (strDataKB = "11" Or strDataKB = "12") Then
        // If Not (csToshoRow.Item(ABToshoTable.KANAMEISHO2) Is String.Empty) Then
        // csToshoRow.Item(ABToshoTable.HANYO_KBN1) = "T"
        // Else
        // csToshoRow.Item(ABToshoTable.HANYO_KBN1) = "S"
        // End If
        // Else
        // csToshoRow.Item(ABToshoTable.HANYO_KBN1) = csRow.Item(strPrefixA + ABAtenaEntity.HANYOKB1)
        // End If
        // ' –@lŒ`‘Ô(20Œ…)
        // csToshoRow.Item(ABToshoTable.HOJINKEITAI) = csRow.Item(strPrefixA + ABAtenaEntity.KANJIHJNKEITAI)
        // ' ŒÂl–@l‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.KOJINHOJIN_KBN) = csRow.Item(strPrefixA + ABAtenaEntity.KJNHJNKB)
        // ' ‘¼l”(4Œ…)
        // csToshoRow.Item(ABToshoTable.HOKA_NINZU) = ""
        // ' ”Ä—p‹æ•ª‚Q(1Œ…)
        // '(ƒf[ƒ^‹æ•ª‚ª"18""28"‚ÌŽžA“]oŠm’èZŠE“]o—\’èZŠ‚ª‚ ‚éŽž‚Ì”»’è)
        // If strDataSB = "18" Or strDataSB = "28" Then
        // If Not (csRow.Item(strPrefixA + ABAtenaEntity.TENSHUTSUKKTIJUSHO) Is String.Empty) Then
        // csToshoRow.Item(ABToshoTable.HANYO_KBN2) = "K"
        // ElseIf Not (csRow.Item(strPrefixA + ABAtenaEntity.TENSHUTSUYOTEIJUSHO) Is String.Empty) Then
        // csToshoRow.Item(ABToshoTable.HANYO_KBN2) = "Y"
        // Else
        // csToshoRow.Item(ABToshoTable.HANYO_KBN2) = csRow.Item(strPrefixA + ABAtenaEntity.HANYOKB2)
        // End If
        // Else
        // csToshoRow.Item(ABToshoTable.HANYO_KBN2) = csRow.Item(strPrefixA + ABAtenaEntity.HANYOKB2)
        // End If
        // ' ŠÇ“àŠÇŠO‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.NAIGAI_KBN) = csRow.Item(strPrefixA + ABAtenaEntity.KANNAIKANGAIKB)
        // ' —X•Ö”Ô†(7Œ…)
        // csToshoRow.Item(ABToshoTable.YUBIN_NO) = csRow.Item(strPrefixA + ABAtenaEntity.YUBINNO)
        // ' ZŠƒR[ƒh(11Œ…)
        // csToshoRow.Item(ABToshoTable.JUSHO_CD) = csRow.Item(strPrefixA + ABAtenaEntity.JUSHOCD)
        // ' ZŠ–¼(60Œ…)
        // csToshoRow.Item(ABToshoTable.JUSHO) = csRow.Item(strPrefixA + ABAtenaEntity.JUSHO)
        // ' ”Ô’nƒR[ƒh‚P(5Œ…)
        // csToshoRow.Item(ABToshoTable.BANCHI_CD1) = csRow.Item(strPrefixA + ABAtenaEntity.BANCHICD1)
        // ' ”Ô’nƒR[ƒh‚Q(5Œ…)
        // csToshoRow.Item(ABToshoTable.BANCHI_CD2) = csRow.Item(strPrefixA + ABAtenaEntity.BANCHICD2)
        // ' ”Ô’nƒR[ƒh‚R(5Œ…)
        // csToshoRow.Item(ABToshoTable.BANCHI_CD3) = csRow.Item(strPrefixA + ABAtenaEntity.BANCHICD3)
        // ' ”Ô’n(40Œ…)
        // csToshoRow.Item(ABToshoTable.BANCHI) = csRow.Item(strPrefixA + ABAtenaEntity.BANCHI)
        // ' •û‘ƒtƒ‰ƒO(1Œ…)
        // csToshoRow.Item(ABToshoTable.KATAGAKI_FLG) = csRow.Item(strPrefixA + ABAtenaEntity.KATAGAKIFG)
        // ' •û‘ƒR[ƒh(4Œ…)
        // csToshoRow.Item(ABToshoTable.KATAGAKI_CD) = csRow.Item(strPrefixA + ABAtenaEntity.KATAGAKICD)
        // ' •û‘(60Œ…)
        // csToshoRow.Item(ABToshoTable.KATAGAKI) = csRow.Item(strPrefixA + ABAtenaEntity.KATAGAKI)
        // ' ˜A—æ‚P(14Œ…)
        // csToshoRow.Item(ABToshoTable.RENRAKUSAKI1) = csRow.Item(strPrefixA + ABAtenaEntity.RENRAKUSAKI1)
        // ' ˜A—æ‚Q(14Œ…)
        // csToshoRow.Item(ABToshoTable.RENRAKUSAKI2) = csRow.Item(strPrefixA + ABAtenaEntity.RENRAKUSAKI2)
        // ' s­‹æƒR[ƒh(7Œ…)(.NET9Œ…)
        // If csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUCD) Is String.Empty Or _
        // CType(csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUCD), String).Length <= 7 Then
        // csToshoRow.Item(ABToshoTable.GYOSEIKU_CD) = csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUCD)
        // ElseIf CType(csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUCD), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.GYOSEIKU_CD) = "       "
        // Else
        // csToshoRow.Item(ABToshoTable.GYOSEIKU_CD) = CType(csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUCD), String).Substring(2, 7)
        // End If
        // ' s­‹æ–¼(60Œ…)
        // csToshoRow.Item(ABToshoTable.GYOSEIKU) = csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUMEI)
        // ' ’n‹æƒR[ƒh‚P(6Œ…)(.NET8Œ…)
        // If csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD1) Is String.Empty Or _
        // CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD1), String).Length <= 6 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD1) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD1)
        // ElseIf CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD1), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD1) = "      "
        // Else
        // csToshoRow.Item(ABToshoTable.CHIKU_CD1) = CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD1), String).Substring(2, 6)
        // End If
        // ' ’n‹æ–¼‚P(60Œ…)
        // csToshoRow.Item(ABToshoTable.CHIKU1) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUMEI1)
        // ' ’n‹æƒR[ƒh‚Q(6Œ…)(.NET8Œ…)
        // If csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD2) Is String.Empty Or _
        // CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD2), String).Length <= 6 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD2) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD2)
        // ElseIf CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD2), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD2) = "      "
        // Else
        // csToshoRow.Item(ABToshoTable.CHIKU_CD2) = CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD2), String).Substring(2, 6)
        // End If
        // ' ’n‹æ–¼‚Q(60Œ…)
        // csToshoRow.Item(ABToshoTable.CHIKU2) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUMEI2)
        // ' ’n‹æƒR[ƒh‚R(6Œ…)(.NET8Œ…)
        // If csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD3) Is String.Empty Or _
        // CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD3), String).Length <= 6 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD3) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD3)
        // ElseIf CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD3), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD3) = "      "
        // Else
        // csToshoRow.Item(ABToshoTable.CHIKU_CD3) = CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD3), String).Substring(2, 6)
        // End If
        // ' ’n‹æ–¼‚R(60Œ…)
        // csToshoRow.Item(ABToshoTable.CHIKU3) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUMEI3)
        // ' “o˜^ˆÙ“®”NŒŽ“ú(8Œ…)
        // csToshoRow.Item(ABToshoTable.TRK_IDO_YMD) = csRow.Item(strPrefixA + ABAtenaEntity.TOROKUIDOYMD)
        // ' “o˜^Ž–—RƒR[ƒh(2Œ…)
        // csToshoRow.Item(ABToshoTable.TRK_JIYU_CD) = csRow.Item(strPrefixA + ABAtenaEntity.TOROKUJIYUCD)
        // ' íœˆÙ“®”NŒŽ“ú(8Œ…)
        // csToshoRow.Item(ABToshoTable.SJO_IDO_YMD) = csRow.Item(strPrefixA + ABAtenaEntity.SHOJOIDOYMD)
        // ' íœŽ–—RƒR[ƒh(2Œ…)
        // csToshoRow.Item(ABToshoTable.SJO_JIYU_CD) = csRow.Item(strPrefixA + ABAtenaEntity.SHOJOJIYUCD)
        // ' ÅI—š—ð”Ô†(4Œ…)
        // csToshoRow.Item(ABToshoTable.LAST_RIREKI_NO) = ""
        // ' ˆÙ“®”NŒŽ“ú(8Œ…)
        // csToshoRow.Item(ABToshoTable.IDO_YMD) = csRow.Item(strPrefixA + ABAtenaEntity.CKINIDOYMD)
        // ' ˆÙ“®Ž–—RƒR[ƒh(2Œ…)
        // csToshoRow.Item(ABToshoTable.JIYU_CD) = csRow.Item(strPrefixA + ABAtenaEntity.CKINJIYUCD)
        // ' “o˜^”NŒŽ“ú(8Œ…)
        // csToshoRow.Item(ABToshoTable.TRK_YMD) = csRow.Item(strPrefixA + ABAtenaEntity.CKINTDKDYMD)
        // ' XV‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.UPDATE_KBN) = strUpDateKB
        // ' ƒ†[ƒUID(8Œ…)(.NET32Œ…)
        // If CType(csRow.Item(strPrefixA + ABAtenaEntity.SAKUSEIUSER), String).Length >= 8 Then
        // csToshoRow.Item(ABToshoTable.USER_ID) = CType(csRow.Item(strPrefixA + ABAtenaEntity.SAKUSEIUSER), String).Substring(0, 8)
        // Else
        // csToshoRow.Item(ABToshoTable.USER_ID) = csRow.Item(strPrefixA + ABAtenaEntity.SAKUSEIUSER)
        // End If
        // ' ’[––ID(8Œ…)(.NET32Œ…)
        // If CType(csRow.Item(strPrefixA + ABAtenaEntity.TANMATSUID), String).Length >= 8 Then
        // csToshoRow.Item(ABToshoTable.WS_ID) = CType(csRow.Item(strPrefixA + ABAtenaEntity.TANMATSUID), String).Substring(0, 8)
        // Else
        // csToshoRow.Item(ABToshoTable.WS_ID) = csRow.Item(strPrefixA + ABAtenaEntity.TANMATSUID)
        // End If
        // ' ƒ^ƒCƒ€ƒXƒ^ƒ“ƒv(14Œ…)
        // csToshoRow.Item(ABToshoTable.UP_DATE) = ""
        // ' ˜_—ƒƒbƒNƒL[(6Œ…)
        // csToshoRow.Item(ABToshoTable.LOCK_KEY) = ""


        // 'Z–¯ƒR[ƒh(8Œ…)(.NET12Œ…)
        // csToshoRow.Item(ABToshoTable.D_JUMIN_CD) = CType(csRow.Item(strPrefixB + ABSfskEntity.JUMINCD), String).Substring(4, 8)
        // ' ‹Æ–±ƒR[ƒh(2Œ…)
        // csToshoRow.Item(ABToshoTable.GYOMU_CD) = csRow.Item(strPrefixB + ABSfskEntity.GYOMUCD)
        // ' ŠJŽn”NŒŽ“ú(6Œ…)
        // csToshoRow.Item(ABToshoTable.ST_YM) = csRow.Item(strPrefixB + ABSfskEntity.STYM)
        // ' I—¹”NŒŽ“ú(6Œ…)
        // csToshoRow.Item(ABToshoTable.ED_YM) = csRow.Item(strPrefixB + ABSfskEntity.EDYM)
        // ' ‘ã”[‹æ•ª(2Œ…)
        // csToshoRow.Item(ABToshoTable.D_DAINO_KBN) = "40"
        // ' ƒJƒi–¼Ì‚P(60Œ…)
        // csToshoRow.Item(ABToshoTable.D_KANAMEISHO1) = csRow.Item(strPrefixB + ABSfskEntity.SFSKKANAMEISHO)
        // ' Š¿Žš–¼Ì‚P(80Œ…)
        // csToshoRow.Item(ABToshoTable.D_MEISHO1) = csRow.Item(strPrefixB + ABSfskEntity.SFSKKANJIMEISHO)
        // 'ŠÇ“àŠÇŠO‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.D_NAIGAI_KBN) = csRow.Item(strPrefixB + ABSfskEntity.SFSKKANNAIKANGAIKB)
        // ' —X•Ö”Ô†(7Œ…)
        // csToshoRow.Item(ABToshoTable.D_YUBIN_NO) = csRow.Item(strPrefixB + ABSfskEntity.SFSKYUBINNO)
        // ' ZŠƒR[ƒh(11Œ…)
        // csToshoRow.Item(ABToshoTable.D_JUSHO_CD) = csRow.Item(strPrefixB + ABSfskEntity.SFSKZJUSHOCD)
        // 'ZŠ(60Œ…)
        // csToshoRow.Item(ABToshoTable.D_JUSHO) = csRow.Item(strPrefixB + ABSfskEntity.SFSKJUSHO)
        // '”Ô’n(40Œ…)
        // csToshoRow.Item(ABToshoTable.D_BANCHI) = csRow.Item(strPrefixB + ABSfskEntity.SFSKBANCHI)
        // ' •û‘(60Œ…)
        // csToshoRow.Item(ABToshoTable.D_KATAGAKI) = csRow.Item(strPrefixB + ABSfskEntity.SFSKKATAGAKI)
        // ' ˜A—æ1(14Œ…)
        // csToshoRow.Item(ABToshoTable.D_RENRAKUSAKI1) = csRow.Item(strPrefixB + ABSfskEntity.SFSKRENRAKUSAKI1)
        // ' ˜A—æ2(14Œ…)
        // csToshoRow.Item(ABToshoTable.D_RENRAKUSAKI2) = csRow.Item(strPrefixB + ABSfskEntity.SFSKRENRAKUSAKI2)
        // ' s­‹æƒR[ƒh(7Œ…)(.NET9Œ…)
        // If csRow.Item(strPrefixB + ABSfskEntity.SFSKGYOSEIKUCD) Is String.Empty Or _
        // CType(csRow.Item(strPrefixB + ABSfskEntity.SFSKGYOSEIKUCD), String).Length <= 7 Then
        // csToshoRow.Item(ABToshoTable.D_GYOSEIKU_CD) = csRow.Item(strPrefixB + ABSfskEntity.SFSKGYOSEIKUCD)
        // ElseIf CType(csRow.Item(strPrefixB + ABSfskEntity.SFSKGYOSEIKUCD), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.D_GYOSEIKU_CD) = "       "
        // Else
        // csToshoRow.Item(ABToshoTable.D_GYOSEIKU_CD) = CType(csRow.Item(strPrefixB + ABSfskEntity.SFSKGYOSEIKUCD), String).Substring(2, 7)
        // End If
        // ' s­‹æ–¼(60Œ…)
        // csToshoRow.Item(ABToshoTable.D_GYOSEIKU) = csRow.Item(strPrefixB + ABSfskEntity.SFSKGYOSEIKUMEI)
        // ' ’n‹æƒR[ƒh‚P(6Œ…)(.NET8Œ…)
        // If csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUCD1) Is String.Empty Or _
        // CType(csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUCD1), String).Length <= 6 Then
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD1) = csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUCD1)
        // ElseIf CType(csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUCD1), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD1) = "      "
        // Else
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD1) = CType(csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUCD1), String).Substring(2, 6)
        // End If
        // ' ’n‹æ‚P(60Œ…)
        // csToshoRow.Item(ABToshoTable.D_CHIKU1) = csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUMEI1)
        // ' ’n‹æƒR[ƒh‚Q(6Œ…)(.NET8Œ…)
        // If csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUCD2) Is String.Empty Or _
        // CType(csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUCD2), String).Length <= 6 Then
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD2) = csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUCD2)
        // ElseIf CType(csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUCD2), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD2) = "      "
        // Else
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD2) = CType(csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUCD2), String).Substring(2, 6)
        // End If
        // ' ’n‹æ‚Q(60Œ…)
        // csToshoRow.Item(ABToshoTable.D_CHIKU2) = csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUMEI2)
        // ' ’n‹æƒR[ƒh‚R(6Œ…)(.NET8Œ…)
        // If csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUCD3) Is String.Empty Or _
        // CType(csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUCD3), String).Length <= 6 Then
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD3) = csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUCD3)
        // ElseIf CType(csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUCD3), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD3) = "      "
        // Else
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD3) = CType(csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUCD3), String).Substring(2, 6)
        // End If
        // ' ’n‹æ‚R(60Œ…)
        // csToshoRow.Item(ABToshoTable.D_CHIKU3) = csRow.Item(strPrefixB + ABSfskEntity.SFSKCHIKUMEI3)

        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // Catch exAppException As UFAppException
        // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
        // m_cfLog.WarningWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
        // "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
        // ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
        // Throw exAppException

        // Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
        // ' ƒGƒ‰[ƒƒOo—Í
        // m_cfLog.ErrorWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒGƒ‰[“à—e:" + exException.Message + "z")

        // ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
        // Throw exException

        // End Try

        // Return csToshoRow

        // End Function
        #endregion

        #region ‘ã”
        // '**
        // '*	ƒƒ\ƒbƒh–¼	ReflectDainoData
        // '*	ŠT—v			ˆ¶–¼ƒf[ƒ^‚Ì”½‰f (‘ã”[ˆ¶–¼î•ñ)
        // '*	ˆø”			csRow		@@: ƒf[ƒ^Žæ“¾
        // '*				    csToshoRow		: ƒf[ƒ^Ši”[
        // '*			    	strUpDateKB		: XV‹æ•ª
        // '*	–ß‚è’l		‚È‚µ
        // '*
        // Private Function ReflectDainoData(ByVal csRow As DataRow, ByVal csToshoRow As DataRow, ByVal strUpDateKB As String) As DataRow
        // Const THIS_METHOD_NAME As String = "ReflectDainoData"
        // Dim strPrefixA As String = CType((STR_A_), String)
        // Dim strPrefixC As String = CType((STR_C_), String)
        // Dim strPrefixD As String = CType((STR_D_), String)
        // '*—š—ð”Ô† 000002 2004/04/058 ’Ç‰ÁŠJŽn
        // Dim strPrefixE As String = CType((STR_E_), String)
        // '*—š—ð”Ô† 000002 2004/04/058 ’Ç‰ÁI—¹

        // Try
        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // ' Žs’¬‘ºº°ÄÞ(6Œ…)
        // csToshoRow.Item(ABToshoTable.SHICHOSONCD) = csRow.Item(strPrefixA + ABAtenaEntity.SHICHOSONCD)
        // ' Ž¯•ÊID(4Œ…)
        // csToshoRow.Item(ABToshoTable.SHIKIBETSUID) = "AB21"
        // ' ì¬“úŽž(14Œ…)
        // csToshoRow.Item(ABToshoTable.SAKUSEIYMD) = m_strNen
        // ' ÅIs‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.LASTRECKB) = ""
        // ' ˜A”Ô(7Œ…)
        // csToshoRow.Item(ABToshoTable.RENBAN) = CType(m_intRecCnt, String).PadLeft(7, "0"c)
        // ' Z–¯ƒR[ƒh(8Œ…)(.NET12Œ…)
        // csToshoRow.Item(ABToshoTable.JUMIN_CD) = CType(csRow.Item(strPrefixA + ABAtenaEntity.JUMINCD), String).Substring(4, 8)
        // ' Ž}”Ô(3Œ…)
        // 'csToshoRow.Item(ABToshoTable.EDABAN) = ""
        // ' ¢‘ÑƒR[ƒh(8Œ…)(.NET12Œ…)
        // If CType(csRow.Item(strPrefixA + ABAtenaEntity.STAICD), String) = String.Empty Then
        // csToshoRow.Item(ABToshoTable.SETAI_CD) = CType(csRow.Item(strPrefixA + ABAtenaEntity.STAICD), String)
        // ElseIf CType(csRow.Item(strPrefixA + ABAtenaEntity.STAICD), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.SETAI_CD) = "        "
        // Else
        // csToshoRow.Item(ABToshoTable.SETAI_CD) = CType(csRow.Item(strPrefixA + ABAtenaEntity.STAICD), String).Substring(4, 8)
        // End If
        // ' ƒf[ƒ^‹æ•ª(2Œ…)
        // csToshoRow.Item(ABToshoTable.DATA_KBN) = csRow.Item(strPrefixA + ABAtenaEntity.ATENADATAKB)
        // Dim strDataKB As String = CType(csToshoRow.Item(ABToshoTable.DATA_KBN), String)
        // ' Z–¯Šî–{‘ä’ ”Ô†(14Œ…)
        // csToshoRow.Item(ABToshoTable.DAICHO_NO) = ""
        // ' ƒf[ƒ^Ží•Ê(2Œ…)
        // csToshoRow.Item(ABToshoTable.DATA_SHU) = csRow.Item(strPrefixA + ABAtenaEntity.ATENADATASHU)
        // Dim strDataSB As String = CType(csToshoRow.Item(ABToshoTable.DATA_SHU), String)
        // ' ŒŸõ—pƒJƒii©j(24Œ…)
        // csToshoRow.Item(ABToshoTable.KANASEI) = csRow.Item(strPrefixA + ABAtenaEntity.SEARCHKANASEI)
        // ' ŒŸõ—pƒJƒii–¼j(16Œ…)
        // csToshoRow.Item(ABToshoTable.KANAMEI) = csRow.Item(strPrefixA + ABAtenaEntity.SEARCHKANAMEI)
        // ' ƒJƒi–¼Ì‚P(60Œ…)
        // csToshoRow.Item(ABToshoTable.KANAMEISHO1) = csRow.Item(strPrefixA + ABAtenaEntity.KANAMEISHO1)
        // ' Š¿Žš–¼Ì‚P(80Œ…)
        // csToshoRow.Item(ABToshoTable.MEISHO1) = csRow.Item(strPrefixA + ABAtenaEntity.KANJIMEISHO1)
        // ' ƒJƒi–¼Ì‚Q(60Œ…)
        // csToshoRow.Item(ABToshoTable.KANAMEISHO2) = csRow.Item(strPrefixA + ABAtenaEntity.KANAMEISHO2)
        // ' Š¿Žš–¼Ì‚Q(80Œ…)
        // csToshoRow.Item(ABToshoTable.MEISHO2) = csRow.Item(strPrefixA + ABAtenaEntity.KANJIMEISHO2)
        // '¶”NŒŽ“ú(8Œ…)
        // csToshoRow.Item(ABToshoTable.UMARE_YMD) = csRow.Item(strPrefixA + ABAtenaEntity.UMAREYMD)
        // ' ¶˜a—ï”NŒŽ“ú(7Œ…)
        // csToshoRow.Item(ABToshoTable.UMARE_WYMD) = csRow.Item(strPrefixA + ABAtenaEntity.UMAREWMD)
        // '«•ÊƒR[ƒh(1Œ…)
        // csToshoRow.Item(ABToshoTable.SEIBETSU_CD) = csRow.Item(strPrefixA + ABAtenaEntity.SEIBETSUCD)
        // ' «•Ê(2Œ…)
        // csToshoRow.Item(ABToshoTable.SEIBETSU) = csRow.Item(strPrefixA + ABAtenaEntity.SEIBETSU)
        // ' ‘±•¿ƒR[ƒh(8Œ…)
        // csToshoRow.Item(ABToshoTable.ZOKUGARA_CD) = csRow.Item(strPrefixA + ABAtenaEntity.ZOKUGARACD)
        // ' ‘±•¿(30Œ…)
        // csToshoRow.Item(ABToshoTable.ZOKUGARA) = csRow.Item(strPrefixA + ABAtenaEntity.ZOKUGARA)
        // ' ‘æ‚Q‘±•¿ƒR[ƒh(8Œ…)
        // csToshoRow.Item(ABToshoTable.ZOKUGARA_CD2) = csRow.Item(strPrefixA + ABAtenaEntity.DAI2ZOKUGARACD)
        // ' ‘æ‚Q‘±•¿(30Œ…)
        // csToshoRow.Item(ABToshoTable.ZOKUGARA2) = csRow.Item(strPrefixA + ABAtenaEntity.DAI2ZOKUGARA)
        // ' ‹¤—L‘ã•\ŽÒZ–¯ƒR[ƒh(8Œ…)
        // csToshoRow.Item(ABToshoTable.K_DAIHYOJUMIN_CD) = ""
        // ' –@l‘ã•\ŽÒ–¼iŠ¿Žšj(60Œ…)
        // csToshoRow.Item(ABToshoTable.H_DAIHYOMEI) = csRow.Item(strPrefixA + ABAtenaEntity.KANJIHJNDAIHYOSHSHIMEI)
        // ' ŽY‹Æ•ª—ÞƒR[ƒh(4Œ…)
        // csToshoRow.Item(ABToshoTable.SANGYO_CD) = ""
        // '*—š—ð”Ô† 000002 2004/04/058 C³ŠJŽn
        // If CType(csRow.Item(strPrefixE + ABDainoEntity.DAINOJUMINCD), String).Trim = String.Empty Then
        // ' –{“XƒR[ƒh(8Œ…)
        // csToshoRow.Item(ABToshoTable.HONTEN_CD) = ""
        // Else
        // ' –{“XƒR[ƒh(8Œ…)
        // csToshoRow.Item(ABToshoTable.HONTEN_CD) = CType(csRow.Item(strPrefixE + ABDainoEntity.DAINOJUMINCD), String).Substring(4, 8)
        // End If
        // 'csToshoRow.Item(ABToshoTable.HONTEN_CD) = ""
        // '*—š—ð”Ô† 000002 2004/04/058 C³I—¹
        // ' ”Ä—p‹æ•ª‚P(1Œ…)
        // '(ƒf[ƒ^‹æ•ª‚ª"11""12"‚ÌŽžAƒJƒi–¼Ì‚Q‚ª‚ ‚éŽž‚Ì”»’è)
        // If (strDataKB = "11" Or strDataKB = "12") Then
        // If Not (csToshoRow.Item(ABToshoTable.KANAMEISHO2) Is String.Empty) Then
        // csToshoRow.Item(ABToshoTable.HANYO_KBN1) = "T"
        // Else
        // csToshoRow.Item(ABToshoTable.HANYO_KBN1) = "S"
        // End If
        // Else
        // csToshoRow.Item(ABToshoTable.HANYO_KBN1) = csRow.Item(strPrefixA + ABAtenaEntity.HANYOKB1)
        // End If
        // ' –@lŒ`‘Ô(20Œ…)
        // csToshoRow.Item(ABToshoTable.HOJINKEITAI) = csRow.Item(strPrefixA + ABAtenaEntity.KANJIHJNKEITAI)
        // ' ŒÂl–@l‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.KOJINHOJIN_KBN) = csRow.Item(strPrefixA + ABAtenaEntity.KJNHJNKB)
        // ' ‘¼l”(4Œ…)
        // csToshoRow.Item(ABToshoTable.HOKA_NINZU) = ""
        // ' ”Ä—p‹æ•ª‚Q(1Œ…)
        // '(ƒf[ƒ^‹æ•ª‚ª"18""28"‚ÌŽžA“]oŠm’èZŠE“]o—\’èZŠ‚ª‚ ‚éŽž‚Ì”»’è)
        // If strDataSB = "18" Or strDataSB = "28" Then
        // If Not (csRow.Item(strPrefixA + ABAtenaEntity.TENSHUTSUKKTIJUSHO) Is String.Empty) Then
        // csToshoRow.Item(ABToshoTable.HANYO_KBN2) = "K"
        // ElseIf Not (csRow.Item(strPrefixA + ABAtenaEntity.TENSHUTSUYOTEIJUSHO) Is String.Empty) Then
        // csToshoRow.Item(ABToshoTable.HANYO_KBN2) = "Y"
        // Else
        // csToshoRow.Item(ABToshoTable.HANYO_KBN2) = csRow.Item(strPrefixA + ABAtenaEntity.HANYOKB2)
        // End If
        // Else
        // csToshoRow.Item(ABToshoTable.HANYO_KBN2) = csRow.Item(strPrefixA + ABAtenaEntity.HANYOKB2)
        // End If
        // ' ŠÇ“àŠÇŠO‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.NAIGAI_KBN) = csRow.Item(strPrefixA + ABAtenaEntity.KANNAIKANGAIKB)
        // ' —X•Ö”Ô†(7Œ…)
        // csToshoRow.Item(ABToshoTable.YUBIN_NO) = csRow.Item(strPrefixA + ABAtenaEntity.YUBINNO)
        // ' ZŠƒR[ƒh(11Œ…)
        // csToshoRow.Item(ABToshoTable.JUSHO_CD) = csRow.Item(strPrefixA + ABAtenaEntity.JUSHOCD)
        // ' ZŠ–¼(60Œ…)
        // csToshoRow.Item(ABToshoTable.JUSHO) = csRow.Item(strPrefixA + ABAtenaEntity.JUSHO)
        // ' ”Ô’nƒR[ƒh‚P(5Œ…)
        // csToshoRow.Item(ABToshoTable.BANCHI_CD1) = csRow.Item(strPrefixA + ABAtenaEntity.BANCHICD1)
        // ' ”Ô’nƒR[ƒh‚Q(5Œ…)
        // csToshoRow.Item(ABToshoTable.BANCHI_CD2) = csRow.Item(strPrefixA + ABAtenaEntity.BANCHICD2)
        // ' ”Ô’nƒR[ƒh‚R(5Œ…)
        // csToshoRow.Item(ABToshoTable.BANCHI_CD3) = csRow.Item(strPrefixA + ABAtenaEntity.BANCHICD3)
        // ' ”Ô’n(40Œ…)
        // csToshoRow.Item(ABToshoTable.BANCHI) = csRow.Item(strPrefixA + ABAtenaEntity.BANCHI)
        // ' •û‘ƒtƒ‰ƒO(1Œ…)
        // csToshoRow.Item(ABToshoTable.KATAGAKI_FLG) = csRow.Item(strPrefixA + ABAtenaEntity.KATAGAKIFG)
        // ' •û‘ƒR[ƒh(4Œ…)
        // csToshoRow.Item(ABToshoTable.KATAGAKI_CD) = csRow.Item(strPrefixA + ABAtenaEntity.KATAGAKICD)
        // ' •û‘(60Œ…)
        // csToshoRow.Item(ABToshoTable.KATAGAKI) = csRow.Item(strPrefixA + ABAtenaEntity.KATAGAKI)
        // ' ˜A—æ‚P(14Œ…)
        // csToshoRow.Item(ABToshoTable.RENRAKUSAKI1) = csRow.Item(strPrefixA + ABAtenaEntity.RENRAKUSAKI1)
        // ' ˜A—æ‚Q(14Œ…)
        // csToshoRow.Item(ABToshoTable.RENRAKUSAKI2) = csRow.Item(strPrefixA + ABAtenaEntity.RENRAKUSAKI2)
        // ' s­‹æƒR[ƒh(7Œ…)(.NET9Œ…)
        // If csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUCD) Is String.Empty Or _
        // CType(csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUCD), String).Length <= 7 Then
        // csToshoRow.Item(ABToshoTable.GYOSEIKU_CD) = csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUCD)
        // ElseIf CType(csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUCD), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.GYOSEIKU_CD) = "       "
        // Else
        // csToshoRow.Item(ABToshoTable.GYOSEIKU_CD) = CType(csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUCD), String).Substring(2, 7)
        // End If
        // ' s­‹æ–¼(60Œ…)
        // csToshoRow.Item(ABToshoTable.GYOSEIKU) = csRow.Item(strPrefixA + ABAtenaEntity.GYOSEIKUMEI)
        // ' ’n‹æƒR[ƒh‚P(6Œ…)(.NET8Œ…)
        // If csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD1) Is String.Empty Or _
        // CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD1), String).Length <= 6 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD1) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD1)
        // ElseIf CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD1), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD1) = "      "
        // Else
        // csToshoRow.Item(ABToshoTable.CHIKU_CD1) = CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD1), String).Substring(2, 6)
        // End If
        // ' ’n‹æ–¼‚P(60Œ…)
        // csToshoRow.Item(ABToshoTable.CHIKU1) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUMEI1)
        // ' ’n‹æƒR[ƒh‚Q(6Œ…)(.NET8Œ…)
        // If csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD2) Is String.Empty Or _
        // CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD2), String).Length <= 6 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD2) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD2)
        // ElseIf CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD2), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD2) = "      "
        // Else
        // csToshoRow.Item(ABToshoTable.CHIKU_CD2) = CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD2), String).Substring(2, 6)
        // End If
        // ' ’n‹æ–¼‚Q(60Œ…)
        // csToshoRow.Item(ABToshoTable.CHIKU2) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUMEI2)
        // ' ’n‹æƒR[ƒh‚R(6Œ…)(.NET8Œ…)
        // If csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD3) Is String.Empty Or _
        // CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD3), String).Length <= 6 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD3) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD3)
        // ElseIf CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD3), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.CHIKU_CD3) = "      "
        // Else
        // csToshoRow.Item(ABToshoTable.CHIKU_CD3) = CType(csRow.Item(strPrefixA + ABAtenaEntity.CHIKUCD3), String).Substring(2, 6)
        // End If
        // ' ’n‹æ–¼‚R(60Œ…)
        // csToshoRow.Item(ABToshoTable.CHIKU3) = csRow.Item(strPrefixA + ABAtenaEntity.CHIKUMEI3)
        // ' “o˜^ˆÙ“®”NŒŽ“ú(8Œ…)
        // csToshoRow.Item(ABToshoTable.TRK_IDO_YMD) = csRow.Item(strPrefixA + ABAtenaEntity.TOROKUIDOYMD)
        // ' “o˜^Ž–—RƒR[ƒh(2Œ…)
        // csToshoRow.Item(ABToshoTable.TRK_JIYU_CD) = csRow.Item(strPrefixA + ABAtenaEntity.TOROKUJIYUCD)
        // ' íœˆÙ“®”NŒŽ“ú(8Œ…)
        // csToshoRow.Item(ABToshoTable.SJO_IDO_YMD) = csRow.Item(strPrefixA + ABAtenaEntity.SHOJOIDOYMD)
        // ' íœŽ–—RƒR[ƒh(2Œ…)
        // csToshoRow.Item(ABToshoTable.SJO_JIYU_CD) = csRow.Item(strPrefixA + ABAtenaEntity.SHOJOJIYUCD)
        // ' ÅI—š—ð”Ô†(4Œ…)
        // csToshoRow.Item(ABToshoTable.LAST_RIREKI_NO) = ""
        // ' ˆÙ“®”NŒŽ“ú(8Œ…)
        // csToshoRow.Item(ABToshoTable.IDO_YMD) = csRow.Item(strPrefixA + ABAtenaEntity.CKINIDOYMD)
        // ' ˆÙ“®Ž–—RƒR[ƒh(2Œ…)
        // csToshoRow.Item(ABToshoTable.JIYU_CD) = csRow.Item(strPrefixA + ABAtenaEntity.CKINJIYUCD)
        // ' “o˜^”NŒŽ“ú(8Œ…)
        // csToshoRow.Item(ABToshoTable.TRK_YMD) = csRow.Item(strPrefixA + ABAtenaEntity.CKINTDKDYMD)
        // ' XV‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.UPDATE_KBN) = strUpDateKB
        // ' ƒ†[ƒUID(8Œ…)(.NET32Œ…)
        // If CType(csRow.Item(strPrefixA + ABAtenaEntity.SAKUSEIUSER), String).Length >= 8 Then
        // csToshoRow.Item(ABToshoTable.USER_ID) = CType(csRow.Item(strPrefixA + ABAtenaEntity.SAKUSEIUSER), String).Substring(0, 8)
        // Else
        // csToshoRow.Item(ABToshoTable.USER_ID) = csRow.Item(strPrefixA + ABAtenaEntity.SAKUSEIUSER)
        // End If
        // ' ’[––ID(8Œ…)(.NET32Œ…)
        // If CType(csRow.Item(strPrefixA + ABAtenaEntity.TANMATSUID), String).Length >= 8 Then
        // csToshoRow.Item(ABToshoTable.WS_ID) = CType(csRow.Item(strPrefixA + ABAtenaEntity.TANMATSUID), String).Substring(0, 8)
        // Else
        // csToshoRow.Item(ABToshoTable.WS_ID) = csRow.Item(strPrefixA + ABAtenaEntity.TANMATSUID)
        // End If
        // ' ƒ^ƒCƒ€ƒXƒ^ƒ“ƒv(14Œ…)
        // csToshoRow.Item(ABToshoTable.UP_DATE) = ""
        // ' ˜_—ƒƒbƒNƒL[(6Œ…)
        // csToshoRow.Item(ABToshoTable.LOCK_KEY) = ""

        // ' ‘ã”[Z–¯ƒR[ƒh(8Œ…)(.NET12Œ…)
        // csToshoRow.Item(ABToshoTable.D_JUMIN_CD) = CType(csRow.Item(strPrefixD + ABDainoEntity.DAINOJUMINCD), String).Substring(4, 8)
        // ' ‹Æ–±ƒR[ƒh(2Œ…)
        // csToshoRow.Item(ABToshoTable.GYOMU_CD) = csRow.Item(strPrefixD + ABDainoEntity.GYOMUCD)
        // ' ŠJŽn”NŒŽ“ú(6Œ…)
        // csToshoRow.Item(ABToshoTable.ST_YM) = csRow.Item(strPrefixD + ABDainoEntity.STYM)
        // ' I—¹”NŒŽ“ú(6Œ…)
        // csToshoRow.Item(ABToshoTable.ED_YM) = csRow.Item(strPrefixD + ABDainoEntity.EDYM)
        // ' ‘ã”[‹æ•ª(2Œ…)
        // csToshoRow.Item(ABToshoTable.D_DAINO_KBN) = csRow.Item(strPrefixD + ABDainoEntity.DAINOKB)
        // ' ¢‘ÑƒR[ƒh(8Œ…)(.NET12Œ…)
        // If CType(csRow.Item(strPrefixC + ABAtenaEntity.STAICD), String) = String.Empty Then
        // csToshoRow.Item(ABToshoTable.D_SETAI_CD) = CType(csRow.Item(strPrefixC + ABAtenaEntity.STAICD), String)
        // ElseIf CType(csRow.Item(strPrefixC + ABAtenaEntity.STAICD), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.D_SETAI_CD) = "        "
        // Else
        // csToshoRow.Item(ABToshoTable.D_SETAI_CD) = CType(csRow.Item(strPrefixC + ABAtenaEntity.STAICD), String).Substring(4, 8)
        // End If
        // 'ƒf[ƒ^‹æ•ª(2Œ…)
        // csToshoRow.Item(ABToshoTable.D_DATA_KBN) = csRow.Item(strPrefixC + ABAtenaEntity.ATENADATAKB)
        // Dim strDataDKB As String = CStr(csToshoRow.Item(ABToshoTable.D_DATA_KBN))
        // 'Z–¯Šî–{‘ä’ ”Ô†(14Œ…)
        // csToshoRow.Item(ABToshoTable.D_DAICHO_NO) = ""
        // 'ŒÂl–@l‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.D_KOJINHOJIN_KBN) = csRow.Item(strPrefixC + ABAtenaEntity.KJNHJNKB)
        // ' ƒf[ƒ^Ží•Ê(2Œ…)
        // csToshoRow.Item(ABToshoTable.D_DATA_SHU) = csRow.Item(strPrefixC + ABAtenaEntity.ATENADATASHU)
        // Dim strDataDSB As String = CStr(csToshoRow.Item(ABToshoTable.D_DATA_SHU))
        // ' ƒJƒi–¼Ì‚P(60Œ…)
        // csToshoRow.Item(ABToshoTable.D_KANAMEISHO1) = csRow.Item(strPrefixC + ABAtenaEntity.KANAMEISHO1)
        // ' Š¿Žš–¼Ì‚P(80Œ…)
        // csToshoRow.Item(ABToshoTable.D_MEISHO1) = csRow.Item(strPrefixC + ABAtenaEntity.KANJIMEISHO1)
        // ' ƒJƒi–¼Ì‚Q(60Œ…)
        // csToshoRow.Item(ABToshoTable.D_KANAMEISHO2) = csRow.Item(strPrefixC + ABAtenaEntity.KANAMEISHO2)
        // ' Š¿Žš–¼Ì‚Q(80Œ…)
        // csToshoRow.Item(ABToshoTable.D_MEISHO2) = csRow.Item(strPrefixC + ABAtenaEntity.KANJIMEISHO2)
        // ' ”Ä—p‹æ•ª‚P(1Œ…)
        // '(ƒf[ƒ^‹æ•ª‚ª"11""12"‚ÌŽžAƒJƒi–¼Ì‚Q‚ª‚ ‚éŽž‚Ì”»’è)
        // If (strDataKB = "11" Or strDataKB = "12") Then
        // If Not (csToshoRow.Item(ABToshoTable.D_KANAMEISHO2) Is String.Empty) Then
        // csToshoRow.Item(ABToshoTable.D_HANYO_KBN1) = "T"
        // Else
        // csToshoRow.Item(ABToshoTable.D_HANYO_KBN1) = "S"
        // End If
        // Else
        // csToshoRow.Item(ABToshoTable.D_HANYO_KBN1) = csRow.Item(strPrefixC + ABAtenaEntity.HANYOKB1)
        // End If
        // ' –@lŒ`‘Ô(20Œ…)
        // csToshoRow.Item(ABToshoTable.D_HOJINKEITAI) = csRow.Item(strPrefixC + ABAtenaEntity.KANJIHJNKEITAI)
        // ' ”Ä—p‹æ•ª‚Q(1Œ…)
        // '(ƒf[ƒ^‹æ•ª‚ª"18""28"‚ÌŽžA“]oŠm’èZŠE“]o—\’èZŠ‚ª‚ ‚éŽž‚Ì”»’è)
        // If strDataSB = "18" Or strDataSB = "28" Then
        // If Not (csRow.Item(strPrefixC + ABAtenaEntity.TENSHUTSUKKTIJUSHO) Is String.Empty) Then
        // csToshoRow.Item(ABToshoTable.D_HANYO_KBN2) = "K"
        // ElseIf Not (CType(csRow.Item(strPrefixC + ABAtenaEntity.TENSHUTSUYOTEIJUSHO), String) = String.Empty) Then
        // csToshoRow.Item(ABToshoTable.D_HANYO_KBN2) = "Y"
        // Else
        // csToshoRow.Item(ABToshoTable.D_HANYO_KBN2) = csRow.Item(strPrefixC + ABAtenaEntity.HANYOKB2)
        // End If
        // Else
        // csToshoRow.Item(ABToshoTable.D_HANYO_KBN2) = csRow.Item(strPrefixC + ABAtenaEntity.HANYOKB2)
        // End If
        // 'ŠÇ“àŠÇŠO‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.D_NAIGAI_KBN) = csRow.Item(strPrefixC + ABAtenaEntity.KANNAIKANGAIKB)
        // ' —X•Ö”Ô†(7Œ…)
        // csToshoRow.Item(ABToshoTable.D_YUBIN_NO) = csRow.Item(strPrefixC + ABAtenaEntity.YUBINNO)
        // ' ZŠƒR[ƒh(11Œ…)
        // csToshoRow.Item(ABToshoTable.D_JUSHO_CD) = csRow.Item(strPrefixC + ABAtenaEntity.JUSHOCD)
        // 'ZŠ(60Œ…)
        // csToshoRow.Item(ABToshoTable.D_JUSHO) = csRow.Item(strPrefixC + ABAtenaEntity.JUSHO)
        // '”Ô’nƒR[ƒh‚P(5Œ…)
        // csToshoRow.Item(ABToshoTable.D_BANCHI_CD1) = csRow.Item(strPrefixC + ABAtenaEntity.BANCHICD1)
        // '”Ô’nƒR[ƒh‚Q(5Œ…)
        // csToshoRow.Item(ABToshoTable.D_BANCHI_CD2) = csRow.Item(strPrefixC + ABAtenaEntity.BANCHICD2)
        // '”Ô’nƒR[ƒh‚R(5Œ…)
        // csToshoRow.Item(ABToshoTable.D_BANCHI_CD3) = csRow.Item(strPrefixC + ABAtenaEntity.BANCHICD3)
        // '”Ô’n(40Œ…)
        // csToshoRow.Item(ABToshoTable.D_BANCHI) = csRow.Item(strPrefixC + ABAtenaEntity.BANCHI)
        // ' •û‘ƒtƒ‰ƒO(1Œ…)
        // csToshoRow.Item(ABToshoTable.D_KATAGAKI_FLG) = csRow.Item(strPrefixC + ABAtenaEntity.KATAGAKIFG)
        // ' •û‘ƒR[ƒh(4Œ…)
        // csToshoRow.Item(ABToshoTable.D_KATAGAKI_CD) = csRow.Item(strPrefixC + ABAtenaEntity.KATAGAKICD)
        // ' •û‘(60Œ…)
        // csToshoRow.Item(ABToshoTable.D_KATAGAKI) = csRow.Item(strPrefixC + ABAtenaEntity.KATAGAKI)
        // ' ˜A—æ1(14Œ…)
        // csToshoRow.Item(ABToshoTable.D_RENRAKUSAKI1) = csRow.Item(strPrefixC + ABAtenaEntity.RENRAKUSAKI1)
        // ' ˜A—æ2(14Œ…)
        // csToshoRow.Item(ABToshoTable.D_RENRAKUSAKI2) = csRow.Item(strPrefixC + ABAtenaEntity.RENRAKUSAKI2)
        // ' s­‹æƒR[ƒh(7Œ…)(.NET9Œ…)
        // If csRow.Item(strPrefixC + ABAtenaEntity.GYOSEIKUCD) Is String.Empty Or _
        // CType(csRow.Item(strPrefixC + ABAtenaEntity.GYOSEIKUCD), String).Length <= 7 Then
        // csToshoRow.Item(ABToshoTable.D_GYOSEIKU_CD) = csRow.Item(strPrefixC + ABAtenaEntity.GYOSEIKUCD)
        // ElseIf CType(csRow.Item(strPrefixC + ABAtenaEntity.GYOSEIKUCD), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.D_GYOSEIKU_CD) = "       "
        // Else
        // csToshoRow.Item(ABToshoTable.D_GYOSEIKU_CD) = CType(csRow.Item(strPrefixC + ABAtenaEntity.GYOSEIKUCD), String).Substring(2, 7)
        // End If
        // ' s­‹æ–¼(60Œ…)
        // csToshoRow.Item(ABToshoTable.D_GYOSEIKU) = csRow.Item(strPrefixC + ABAtenaEntity.GYOSEIKUMEI)
        // ' ’n‹æƒR[ƒh‚P(6Œ…)(.NET8Œ…)
        // If csRow.Item(strPrefixC + ABAtenaEntity.CHIKUCD1) Is String.Empty Or _
        // CType(csRow.Item(strPrefixC + ABAtenaEntity.CHIKUCD1), String).Length <= 6 Then
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD1) = csRow.Item(strPrefixC + ABAtenaEntity.CHIKUCD1)
        // ElseIf CType(csRow.Item(strPrefixC + ABAtenaEntity.CHIKUCD1), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD1) = "      "
        // Else
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD1) = CType(csRow.Item(strPrefixC + ABAtenaEntity.CHIKUCD1), String).Substring(2, 6)
        // End If
        // ' ’n‹æ–¼‚P(60Œ…)
        // csToshoRow.Item(ABToshoTable.D_CHIKU1) = csRow.Item(strPrefixC + ABAtenaEntity.CHIKUMEI1)
        // ' ’n‹æƒR[ƒh‚Q(6Œ…)(.NET8Œ…)
        // If csRow.Item(strPrefixC + ABAtenaEntity.CHIKUCD2) Is String.Empty Or _
        // CType(csRow.Item(strPrefixC + ABAtenaEntity.CHIKUCD2), String).Length <= 6 Then
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD2) = csRow.Item(strPrefixC + ABAtenaEntity.CHIKUCD2)
        // ElseIf CType(csRow.Item(strPrefixC + ABAtenaEntity.CHIKUCD2), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD2) = "      "
        // Else
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD2) = CType(csRow.Item(strPrefixC + ABAtenaEntity.CHIKUCD1), String).Substring(2, 6)
        // End If
        // ' ’n‹æ–¼‚Q(60Œ…)
        // csToshoRow.Item(ABToshoTable.D_CHIKU2) = csRow.Item(strPrefixC + ABAtenaEntity.CHIKUMEI2)
        // ' ’n‹æƒR[ƒh‚R(6Œ…)(.NET8Œ…)
        // If csRow.Item(strPrefixC + ABAtenaEntity.CHIKUCD3) Is String.Empty Or _
        // CType(csRow.Item(strPrefixC + ABAtenaEntity.CHIKUCD3), String).Length <= 6 Then
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD3) = csRow.Item(strPrefixC + ABAtenaEntity.CHIKUCD3)
        // ElseIf CType(csRow.Item(strPrefixC + ABAtenaEntity.CHIKUCD3), String).Trim.Length = 0 Then
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD3) = "      "
        // Else
        // csToshoRow.Item(ABToshoTable.D_CHIKU_CD3) = CType(csRow.Item(strPrefixC + ABAtenaEntity.CHIKUCD1), String).Substring(2, 6)
        // End If
        // ' ’n‹æ‚R(60Œ…)
        // csToshoRow.Item(ABToshoTable.D_CHIKU3) = csRow.Item(strPrefixC + ABAtenaEntity.CHIKUMEI3)
        // ' •Êˆ¶–¼”(3Œ…)
        // csToshoRow.Item(ABToshoTable.D_BETSUATENA) = "000"


        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // Catch exAppException As UFAppException
        // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
        // m_cfLog.WarningWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
        // "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
        // ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
        // Throw exAppException

        // Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
        // ' ƒGƒ‰[ƒƒOo—Í
        // m_cfLog.ErrorWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒGƒ‰[“à—e:" + exException.Message + "z")

        // ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
        // Throw exException

        // End Try

        // Return csToshoRow

        // End Function
        #endregion

        #region ÅIƒf[ƒ^•ÒW
        // '**
        // '*	ƒƒ\ƒbƒh–¼	ReflectLastData
        // '*	ŠT—v			ÅIƒf[ƒ^‚Ì”½‰f
        // '*	ˆø”			csRow		: Žæ“¾ƒf[ƒ^
        // '*				    csToshoRow	: Ši”[ƒf[ƒ^
        // '*	–ß‚è’l		DataRow
        // '*
        // Public Function ReflectLastData(ByVal csToshoRow As DataRow) As DataRow
        // Const THIS_METHOD_NAME As String = "ReflectLastData"
        // '*—š—ð”Ô† 000003 2004/11/05 íœŠJŽn
        // ''''Dim cuCityInfo As USSCityInfoClass
        // ''''Dim strCityCD As String
        // '*—š—ð”Ô† 000003 2004/11/05 íœI—¹

        // Try
        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // '*—š—ð”Ô† 000003 2004/11/05 C³ŠJŽn
        // ''''ƒCƒ“ƒXƒ^ƒ“ƒX‰»
        // '''cuCityInfo = New USSCityInfoClass()
        // ''''Žs’¬‘ºî•ñ‚ÌŽæ“¾
        // '''cuCityInfo.GetCityInfo(m_cfControlData)
        // ''''Žs’¬‘ºº°ÄÞ‚ÌŽæ“¾
        // '''strCityCD = cuCityInfo.p_strShichosonCD(0)
        // ' Žs’¬‘ºº°ÄÞ(6Œ…)
        // ''''csToshoRow.Item(ABToshoTable.SHICHOSONCD) = strCityCD
        // csToshoRow.Item(ABToshoTable.SHICHOSONCD) = m_strCityCD
        // '*—š—ð”Ô† 000003 2004/11/05 C³I—¹
        // ' Ž¯•ÊID(4Œ…)
        // csToshoRow.Item(ABToshoTable.SHIKIBETSUID) = "AB21"
        // ' ì¬“úŽž(14Œ…)
        // csToshoRow.Item(ABToshoTable.SAKUSEIYMD) = m_strNen
        // ' ÅIs‹æ•ª(1Œ…)
        // csToshoRow.Item(ABToshoTable.LASTRECKB) = "E"
        // ' ˜A”Ô(7Œ…)
        // csToshoRow.Item(ABToshoTable.RENBAN) = CType(m_intRecCnt, String).PadLeft(7, "0"c)

        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // Catch exAppException As UFAppException
        // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
        // m_cfLog.WarningWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
        // "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
        // ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
        // Throw exAppException

        // Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
        // ' ƒGƒ‰[ƒƒOo—Í
        // m_cfLog.ErrorWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒGƒ‰[“à—e:" + exException.Message + "z")

        // ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
        // Throw exException

        // End Try

        // Return csToshoRow
        // End Function
        #endregion

        #region SQL•ª‚Ìì¬
        // '************************************************************************************************
        // '* ƒƒ\ƒbƒh–¼     SQL•¶‚Ìì¬
        // '* 
        // '* \•¶           Private Sub CreateSQL(ByVal strJuminCD As String)
        // '* 
        // '* ‹@”\@@    @@INSERT, UPDATE, DELETE‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // '* 
        // '* ˆø”           strJuminCD As String : Žæ“¾ƒf[ƒ^‚ÌZ–¯ƒR[ƒh
        // '* 
        // '* –ß‚è’l         ‚È‚µ
        // '************************************************************************************************
        // Private Sub CreateSQL(ByVal strJuminCD As String, ByVal strRonSakuFG As String)
        // Const THIS_METHOD_NAME As String = "CreateSQL"
        // Dim strSQL As New Text.StringBuilder()
        // Dim strSFSKSQL As New Text.StringBuilder()
        // Dim strDAINOSQL As New Text.StringBuilder()
        // '*—š—ð”Ô† 000001 2004/03/08 ’Ç‰ÁŠJŽn
        // Dim strHIDAINOSQL As New Text.StringBuilder()
        // '*—š—ð”Ô† 000001 2004/03/08 ’Ç‰ÁI—¹


        // '**
        // '*–{lˆ¶–¼
        // '*
        // strSQL.Append(" SELECT	")
        // strSQL.Append(getColumnList(True))
        // strSQL.Append(" FROM	ABATENA A")
        // '˜_—íœ‚Ì”»’è
        // If strRonSakuFG = "1" Then
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁŠJŽn
        // strSQL.Append("			LEFT OUTER JOIN (SELECT * FROM ABDAINO WHERE SAKUJOFG <> '0' AND GYOMUCD='05' AND GYOMUNAISHU_CD='9') E ON A.JUMINCD = E.JUMINCD")
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁI—¹
        // strSQL.Append(" WHERE	A.SAKUJOFG<>'0' AND A.JUTOGAIYUSENKB ='1' AND A.JUMINCD = '")
        // Else
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁŠJŽn
        // strSQL.Append("			LEFT OUTER JOIN (SELECT * FROM ABDAINO WHERE SAKUJOFG <> '1' AND GYOMUCD='05' AND GYOMUNAISHU_CD='9') E ON A.JUMINCD = E.JUMINCD")
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁI—¹
        // strSQL.Append(" WHERE	A.SAKUJOFG<>'1' AND A.JUTOGAIYUSENKB ='1' AND A.JUMINCD = '")
        // End If
        // strSQL.Append(strJuminCD)
        // strSQL.Append("'")

        // '**
        // '*–{lˆ¶–¼{–{l‘—•tæ
        // '*
        // strSFSKSQL.Append(" SELECT	")
        // strSFSKSQL.Append(getSFSKColumnList(True))
        // strSFSKSQL.Append(" FROM	ABSFSK B")
        // '˜_—íœ‚Ì”»’è
        // If strRonSakuFG = "1" Then
        // strSFSKSQL.Append("			LEFT OUTER JOIN (SELECT * FROM ABATENA WHERE SAKUJOFG <> '0' AND JUTOGAIYUSENKB ='1') A ON B.JUMINCD = A.JUMINCD")
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁŠJŽn
        // strSFSKSQL.Append("			LEFT OUTER JOIN (SELECT * FROM ABDAINO WHERE SAKUJOFG <> '0' AND GYOMUCD='05' AND GYOMUNAISHU_CD='9') E ON B.JUMINCD = E.JUMINCD")
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁI—¹
        // strSFSKSQL.Append(" WHERE	B.SAKUJOFG<>'0' AND B.JUMINCD = '")
        // Else
        // strSFSKSQL.Append("			LEFT OUTER JOIN (SELECT * FROM ABATENA WHERE SAKUJOFG <> '1' AND JUTOGAIYUSENKB ='1') A ON B.JUMINCD = A.JUMINCD")
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁŠJŽn
        // strSFSKSQL.Append("			LEFT OUTER JOIN (SELECT * FROM ABDAINO WHERE SAKUJOFG <> '1' AND GYOMUCD='05' AND GYOMUNAISHU_CD='9') E ON B.JUMINCD = E.JUMINCD")
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁI—¹
        // strSFSKSQL.Append(" WHERE	B.SAKUJOFG<>'1' AND B.JUMINCD = '")
        // End If
        // strSFSKSQL.Append(strJuminCD)
        // strSFSKSQL.Append("'")
        // strSFSKSQL.Append(" ORDER BY B.GYOMUCD ")

        // '**
        // '*–{lˆ¶–¼{‘ã”[lˆ¶–¼{–{l‘ã”[
        // '*
        // strDAINOSQL.Append(" SELECT	")
        // strDAINOSQL.Append(getDAINOColumnList(True))
        // strDAINOSQL.Append(" FROM	ABDAINO D")
        // '˜_—íœ‚Ì”»’è
        // If strRonSakuFG = "1" Then
        // strDAINOSQL.Append("			LEFT OUTER JOIN (SELECT * FROM ABATENA WHERE SAKUJOFG <> '0' AND JUTOGAIYUSENKB ='1') C ON D.DAINOJUMINCD = C.JUMINCD")
        // strDAINOSQL.Append("			LEFT OUTER JOIN (SELECT * FROM ABATENA WHERE SAKUJOFG <> '0' AND JUTOGAIYUSENKB ='1') A ON D.JUMINCD = A.JUMINCD")
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁŠJŽn
        // strDAINOSQL.Append("			LEFT OUTER JOIN (SELECT * FROM ABDAINO WHERE SAKUJOFG <> '0' AND GYOMUCD='05' AND GYOMUNAISHU_CD='9') E ON D.JUMINCD = E.JUMINCD")
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁI—¹
        // strDAINOSQL.Append(" WHERE	D.SAKUJOFG<>'0' AND D.GYOMUCD<>'05' AND D.GYOMUNAISHU_CD<>'9' AND D.JUMINCD = '")
        // Else
        // strDAINOSQL.Append("			LEFT OUTER JOIN (SELECT * FROM ABATENA WHERE SAKUJOFG <> '1' AND JUTOGAIYUSENKB ='1') C ON D.DAINOJUMINCD = C.JUMINCD")
        // strDAINOSQL.Append("			LEFT OUTER JOIN (SELECT * FROM ABATENA WHERE SAKUJOFG <> '1' AND JUTOGAIYUSENKB ='1') A ON D.JUMINCD = A.JUMINCD")
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁŠJŽn
        // strDAINOSQL.Append("			LEFT OUTER JOIN (SELECT * FROM ABDAINO WHERE SAKUJOFG <> '1' AND GYOMUCD='05' AND GYOMUNAISHU_CD='9') E ON D.JUMINCD = E.JUMINCD")
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁI—¹
        // strDAINOSQL.Append(" WHERE	D.SAKUJOFG<>'1' AND D.GYOMUCD<>'05' AND D.GYOMUNAISHU_CD<>'9' AND D.JUMINCD = '")
        // End If
        // strDAINOSQL.Append(strJuminCD)
        // strDAINOSQL.Append("'")
        // strDAINOSQL.Append(" ORDER BY D.GYOMUCD ")

        // '*—š—ð”Ô† 000001 2004/03/08 ’Ç‰ÁŠJŽn
        // '**
        // '*”í‘ã”[lZ–¯ƒR[ƒh
        // '*
        // strHIDAINOSQL.Append(" SELECT  JUMINCD ")
        // strHIDAINOSQL.Append(" FROM    ABDAINO ")
        // strHIDAINOSQL.Append(" WHERE	SAKUJOFG<>'1' AND GYOMUCD<>'05' AND GYOMUNAISHU_CD<>'9' AND DAINOJUMINCD = '")
        // strHIDAINOSQL.Append(strJuminCD)
        // strHIDAINOSQL.Append("'")
        // '*—š—ð”Ô† 000001 2004/03/08 ’Ç‰ÁI—¹

        // m_strSQL = strSQL.ToString()
        // m_strSFSKSQL = strSFSKSQL.ToString()
        // m_strDAINOSQL = strDAINOSQL.ToString()
        // '*—š—ð”Ô† 000001 2004/03/08 ’Ç‰ÁŠJŽn
        // m_strHIDAINOSQL = strHIDAINOSQL.ToString()
        // '*—š—ð”Ô† 000001 2004/03/08 ’Ç‰ÁI—¹
        // End Sub
        #endregion

        #region SQLƒpƒ‰ƒ[ƒ^•ÒW
        // '**
        // '* ƒƒ\ƒbƒh–¼
        // '*	GetColumnList_ABAtena
        // '* 
        // '* ŠT—v
        // '*	ABAtena‚Åˆ—‚É•K—v‚È—ñ‚ÌƒŠƒXƒg‚ð•Ô‚·B
        // '* 
        // '* ˆø”
        // '*	‚È‚µ
        // '* 
        // '* –ß‚è’l
        // '*	—ñƒŠƒXƒg
        // Private Function GetColumnList_ABAtena() As ArrayList

        // If (m_aryABAtena Is Nothing) Then
        // m_aryABAtena = New ArrayList(56)
        // m_aryABAtena.Add(ABAtenaEntity.SHICHOSONCD)
        // m_aryABAtena.Add(ABAtenaEntity.JUMINCD)
        // m_aryABAtena.Add(ABAtenaEntity.STAICD)
        // m_aryABAtena.Add(ABAtenaEntity.ATENADATAKB)
        // m_aryABAtena.Add(ABAtenaEntity.ATENADATASHU)
        // m_aryABAtena.Add(ABAtenaEntity.SEARCHKANASEI)
        // m_aryABAtena.Add(ABAtenaEntity.SEARCHKANAMEI)
        // m_aryABAtena.Add(ABAtenaEntity.KANAMEISHO1)
        // m_aryABAtena.Add(ABAtenaEntity.KANJIMEISHO1)
        // m_aryABAtena.Add(ABAtenaEntity.KANAMEISHO2)
        // m_aryABAtena.Add(ABAtenaEntity.KANJIMEISHO2)
        // m_aryABAtena.Add(ABAtenaEntity.UMAREYMD)
        // m_aryABAtena.Add(ABAtenaEntity.UMAREWMD)
        // m_aryABAtena.Add(ABAtenaEntity.SEIBETSUCD)
        // m_aryABAtena.Add(ABAtenaEntity.SEIBETSU)
        // m_aryABAtena.Add(ABAtenaEntity.ZOKUGARACD)
        // m_aryABAtena.Add(ABAtenaEntity.ZOKUGARA)
        // m_aryABAtena.Add(ABAtenaEntity.DAI2ZOKUGARACD)
        // m_aryABAtena.Add(ABAtenaEntity.DAI2ZOKUGARA)
        // m_aryABAtena.Add(ABAtenaEntity.KANJIHJNDAIHYOSHSHIMEI)
        // m_aryABAtena.Add(ABAtenaEntity.HANYOKB1)
        // m_aryABAtena.Add(ABAtenaEntity.KANJIHJNKEITAI)
        // m_aryABAtena.Add(ABAtenaEntity.KJNHJNKB)
        // m_aryABAtena.Add(ABAtenaEntity.HANYOKB2)
        // m_aryABAtena.Add(ABAtenaEntity.KANNAIKANGAIKB)
        // m_aryABAtena.Add(ABAtenaEntity.YUBINNO)
        // m_aryABAtena.Add(ABAtenaEntity.JUSHOCD)
        // m_aryABAtena.Add(ABAtenaEntity.JUSHO)
        // m_aryABAtena.Add(ABAtenaEntity.BANCHICD1)
        // m_aryABAtena.Add(ABAtenaEntity.BANCHICD2)
        // m_aryABAtena.Add(ABAtenaEntity.BANCHICD3)
        // m_aryABAtena.Add(ABAtenaEntity.BANCHI)
        // m_aryABAtena.Add(ABAtenaEntity.KATAGAKIFG)
        // m_aryABAtena.Add(ABAtenaEntity.KATAGAKICD)
        // m_aryABAtena.Add(ABAtenaEntity.KATAGAKI)
        // m_aryABAtena.Add(ABAtenaEntity.RENRAKUSAKI1)
        // m_aryABAtena.Add(ABAtenaEntity.RENRAKUSAKI2)
        // m_aryABAtena.Add(ABAtenaEntity.GYOSEIKUCD)
        // m_aryABAtena.Add(ABAtenaEntity.GYOSEIKUMEI)
        // m_aryABAtena.Add(ABAtenaEntity.CHIKUCD1)
        // m_aryABAtena.Add(ABAtenaEntity.CHIKUMEI1)
        // m_aryABAtena.Add(ABAtenaEntity.CHIKUCD2)
        // m_aryABAtena.Add(ABAtenaEntity.CHIKUMEI2)
        // m_aryABAtena.Add(ABAtenaEntity.CHIKUCD3)
        // m_aryABAtena.Add(ABAtenaEntity.CHIKUMEI3)
        // m_aryABAtena.Add(ABAtenaEntity.TOROKUIDOYMD)
        // m_aryABAtena.Add(ABAtenaEntity.TOROKUJIYUCD)
        // m_aryABAtena.Add(ABAtenaEntity.SHOJOIDOYMD)
        // m_aryABAtena.Add(ABAtenaEntity.SHOJOJIYUCD)
        // m_aryABAtena.Add(ABAtenaEntity.CKINIDOYMD)
        // m_aryABAtena.Add(ABAtenaEntity.CKINJIYUCD)
        // m_aryABAtena.Add(ABAtenaEntity.CKINTDKDYMD)
        // m_aryABAtena.Add(ABAtenaEntity.SAKUSEIUSER)
        // m_aryABAtena.Add(ABAtenaEntity.TANMATSUID)
        // m_aryABAtena.Add(ABAtenaEntity.TENSHUTSUKKTIJUSHO)
        // m_aryABAtena.Add(ABAtenaEntity.TENSHUTSUYOTEIJUSHO)
        // m_aryABAtena.TrimToSize()
        // End If

        // Return m_aryABAtena
        // End Function

        // '**
        // '* ƒƒ\ƒbƒh–¼
        // '*	GetColumnList_ABSfsk
        // '* 
        // '* ŠT—v
        // '*	ABSfsk‚Åˆ—‚É•K—v‚È—ñ‚ÌƒŠƒXƒg‚ð•Ô‚·B
        // '* 
        // '* ˆø”
        // '*	‚È‚µ
        // '* 
        // '* –ß‚è’l
        // '*	—ñƒŠƒXƒg
        // Private Function GetColumnList_ABSfsk() As ArrayList

        // If (m_aryABSfsk Is Nothing) Then
        // m_aryABSfsk = New ArrayList(23)
        // m_aryABSfsk.Add(ABSfskEntity.STYM)
        // m_aryABSfsk.Add(ABSfskEntity.EDYM)
        // m_aryABSfsk.Add(ABSfskEntity.JUMINCD)
        // m_aryABSfsk.Add(ABSfskEntity.GYOMUCD)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKDATAKB)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKKANAMEISHO)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKKANJIMEISHO)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKKANNAIKANGAIKB)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKYUBINNO)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKZJUSHOCD)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKJUSHO)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKBANCHI)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKKATAGAKI)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKRENRAKUSAKI1)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKRENRAKUSAKI2)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKGYOSEIKUCD)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKGYOSEIKUMEI)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKCHIKUCD1)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKCHIKUMEI1)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKCHIKUCD2)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKCHIKUMEI2)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKCHIKUCD3)
        // m_aryABSfsk.Add(ABSfskEntity.SFSKCHIKUMEI3)
        // m_aryABSfsk.TrimToSize()
        // End If

        // Return m_aryABSfsk
        // End Function
        // '**
        // '* ƒƒ\ƒbƒh–¼
        // '*	GetColumnList_ABDaino
        // '* 
        // '* ŠT—v
        // '*	ABDaino‚Åˆ—‚É•K—v‚È—ñ‚ÌƒŠƒXƒg‚ð•Ô‚·B
        // '* 
        // '* ˆø”
        // '*	‚È‚µ
        // '* 
        // '* –ß‚è’l
        // '*	—ñƒŠƒXƒg
        // Private Function GetColumnList_ABDaino() As ArrayList
        // If (m_aryABDaino Is Nothing) Then
        // m_aryABDaino = New ArrayList(5)
        // m_aryABDaino.Add(ABDainoEntity.STYM)
        // m_aryABDaino.Add(ABDainoEntity.EDYM)
        // m_aryABDaino.Add(ABDainoEntity.DAINOKB)
        // m_aryABDaino.Add(ABDainoEntity.DAINOJUMINCD)
        // m_aryABDaino.Add(ABDainoEntity.GYOMUCD)
        // m_aryABDaino.TrimToSize()
        // End If

        // Return m_aryABDaino
        // End Function

        // '**
        // '* ƒƒ\ƒbƒh–¼
        // '*	getColumnList
        // '* 
        // '* ŠT—v
        // '*	SQL‚ÌSelectß‚Ì•¶Žš—ñ‚ð¶¬‚·‚éB
        // '* 
        // '* ˆø”
        // '*	blnNeedAll		: ‹Æ–±ƒR[ƒh‚ªŽw’è‚³‚êA‘S‚Ä‚Ìƒe[ƒuƒ‹‚©‚ç
        // '*					  ‚»‚ê‚¼‚êƒf[ƒ^‚ðŽæ“¾‚·‚é•K—v‚ª‚ ‚é‚©H
        // '* 
        // '* –ß‚è’l
        // '*	Selectß•¶Žš—ñ(’A‚µA"Select" ‚ðœ‚­)
        // Private Function getColumnList(ByVal blnNeedAll As Boolean) As String
        // Dim ary As ArrayList
        // Dim iEnum As IEnumerator
        // Dim strTmp As String
        // Dim strClmn As String
        // Dim strBldr1 As New Text.StringBuilder()
        // '*—š—ð”Ô† 000002 2004/04/058 ’Ç‰ÁŠJŽn
        // Dim strBldr2 As New Text.StringBuilder()
        // '*—š—ð”Ô† 000002 2004/04/058 ’Ç‰ÁŠJŽn

        // Const CLMDEF_1 As String = " {0}.{1} AS {0}_{1}"
        // Const CLMDEF_2 As String = " '' AS {0}_{1}"

        // Dim strFormat As String = CType(IIf(blnNeedAll, CLMDEF_1, CLMDEF_2), String)

        // ' –{lˆ¶–¼
        // ary = GetColumnList_ABAtena()
        // iEnum = ary.GetEnumerator()
        // While (iEnum.MoveNext())
        // If (strBldr1.Length > 0) Then
        // strBldr1.Append(SEPARATOR)
        // End If
        // ' –{lˆ¶–¼
        // strTmp = String.Format(CLMDEF_1, STR_A, iEnum.Current)
        // strBldr1.Append(strTmp)

        // End While

        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁŠJŽn
        // ' ‘ã”[
        // ary = GetColumnList_ABDaino()
        // iEnum = ary.GetEnumerator()
        // While (iEnum.MoveNext())
        // If (strBldr2.Length > 0) Then
        // strBldr2.Append(SEPARATOR)
        // End If
        // strTmp = String.Format(strFormat, STR_E, iEnum.Current)
        // strBldr2.Append(strTmp)
        // End While
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁI—¹

        // '*—š—ð”Ô† 000002 2004/04/05 C³ŠJŽn
        // Return strBldr1.ToString() + SEPARATOR + strBldr2.ToString()
        // 'Return strBldr1.ToString()
        // '*—š—ð”Ô† 000002 2004/04/05 C³ŠJŽn
        // End Function

        // '**
        // '* ƒƒ\ƒbƒh–¼
        // '*	getSFSKColumnList
        // '* 
        // '* ŠT—v
        // '*	SQL‚ÌSelectß‚Ì•¶Žš—ñ‚ð¶¬‚·‚éB
        // '* 
        // '* ˆø”
        // '*	blnNeedAll		: ‹Æ–±ƒR[ƒh‚ªŽw’è‚³‚êA‘S‚Ä‚Ìƒe[ƒuƒ‹‚©‚ç
        // '*					  ‚»‚ê‚¼‚êƒf[ƒ^‚ðŽæ“¾‚·‚é•K—v‚ª‚ ‚é‚©H
        // '* 
        // '* –ß‚è’l
        // '*	Selectß•¶Žš—ñ(’A‚µA"Select" ‚ðœ‚­)
        // Private Function getSFSKColumnList(ByVal blnNeedAll As Boolean) As String
        // Dim ary As ArrayList

        // Dim iEnum As IEnumerator
        // Dim strSFSKTmp As String
        // Dim strSFSKClmn As String
        // Dim strSFSKBldr1 As New Text.StringBuilder()
        // Dim strSFSKBldr2 As New Text.StringBuilder()
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁŠJŽn
        // Dim strSFSKBldr3 As New Text.StringBuilder()
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁŠJŽn

        // Const CLMDEF_1 As String = " {0}.{1} AS {0}_{1}"
        // Const CLMDEF_2 As String = " '' AS {0}_{1}"

        // Dim strFormat As String = CType(IIf(blnNeedAll, CLMDEF_1, CLMDEF_2), String)

        // ' –{lˆ¶–¼
        // ary = GetColumnList_ABAtena()
        // iEnum = ary.GetEnumerator()
        // While (iEnum.MoveNext())
        // If (strSFSKBldr1.Length > 0) Then
        // strSFSKBldr1.Append(SEPARATOR)
        // End If
        // ' –{lˆ¶–¼
        // strSFSKTmp = String.Format(CLMDEF_1, STR_A, iEnum.Current)
        // strSFSKBldr1.Append(strSFSKTmp)

        // End While
        // '–{l‘—•tæ()
        // ary = GetColumnList_ABSfsk()
        // iEnum = ary.GetEnumerator()
        // While (iEnum.MoveNext())
        // If (strSFSKBldr2.Length > 0) Then
        // strSFSKBldr2.Append(SEPARATOR)
        // End If
        // ' –{l‘—•tæ
        // strSFSKTmp = String.Format(strFormat, STR_B, iEnum.Current)
        // strSFSKBldr2.Append(strSFSKTmp)
        // End While


        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁŠJŽn
        // ' ‘ã”[
        // ary = GetColumnList_ABDaino()
        // iEnum = ary.GetEnumerator()
        // While (iEnum.MoveNext())
        // If (strSFSKBldr3.Length > 0) Then
        // strSFSKBldr3.Append(SEPARATOR)
        // End If
        // strSFSKTmp = String.Format(strFormat, STR_E, iEnum.Current)
        // strSFSKBldr3.Append(strSFSKTmp)
        // End While
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁI—¹

        // '*—š—ð”Ô† 000002 2004/04/05 C³ŠJŽn
        // Return strSFSKBldr1.ToString() + SEPARATOR + strSFSKBldr2.ToString() + SEPARATOR + strSFSKBldr3.ToString()
        // 'Return strSFSKBldr1.ToString() + SEPARATOR + strSFSKBldr2.ToString()
        // '*—š—ð”Ô† 000002 2004/04/05 C³I—¹
        // End Function

        // '**
        // '* ƒƒ\ƒbƒh–¼
        // '*	getDAINOColumnList
        // '* 
        // '* ŠT—v
        // '*	SQL‚ÌSelectß‚Ì•¶Žš—ñ‚ð¶¬‚·‚éB
        // '* 
        // '* ˆø”
        // '*	blnNeedAll		: ‹Æ–±ƒR[ƒh‚ªŽw’è‚³‚êA‘S‚Ä‚Ìƒe[ƒuƒ‹‚©‚ç
        // '*					  ‚»‚ê‚¼‚êƒf[ƒ^‚ðŽæ“¾‚·‚é•K—v‚ª‚ ‚é‚©H
        // '* 
        // '* –ß‚è’l
        // '*	Selectß•¶Žš—ñ(’A‚µA"Select" ‚ðœ‚­)
        // Private Function getDAINOColumnList(ByVal blnNeedAll As Boolean) As String
        // Dim ary As ArrayList

        // Dim iEnum As IEnumerator
        // Dim strDAINOTmp As String
        // Dim strDAINOClmn As String
        // Dim strDAINOBldr1 As New Text.StringBuilder()
        // Dim strDAINOBldr2 As New Text.StringBuilder()
        // Dim strDAINOBldr3 As New Text.StringBuilder()
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁŠJŽn
        // Dim strDAINOBldr4 As New Text.StringBuilder()
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁI—¹

        // Const CLMDEF_1 As String = " {0}.{1} AS {0}_{1}"
        // Const CLMDEF_2 As String = " '' AS {0}_{1}"

        // Dim strFormat As String = CType(IIf(blnNeedAll, CLMDEF_1, CLMDEF_2), String)

        // ' –{lˆ¶–¼
        // ary = GetColumnList_ABAtena()
        // iEnum = ary.GetEnumerator()
        // While (iEnum.MoveNext())
        // If (strDAINOBldr1.Length > 0) Then
        // strDAINOBldr1.Append(SEPARATOR)
        // strDAINOBldr2.Append(SEPARATOR)
        // End If
        // ' –{lˆ¶–¼
        // strDAINOTmp = String.Format(CLMDEF_1, STR_A, iEnum.Current)
        // strDAINOBldr1.Append(strDAINOTmp)

        // ' ‘ã”[lˆ¶–¼
        // strDAINOTmp = String.Format(strFormat, STR_C, iEnum.Current)
        // strDAINOBldr2.Append(strDAINOTmp)
        // End While

        // ' ‘ã”[
        // ary = GetColumnList_ABDaino()
        // iEnum = ary.GetEnumerator()
        // While (iEnum.MoveNext())
        // If (strDAINOBldr3.Length > 0) Then
        // strDAINOBldr3.Append(SEPARATOR)
        // End If
        // strDAINOTmp = String.Format(strFormat, STR_D, iEnum.Current)
        // strDAINOBldr3.Append(strDAINOTmp)
        // End While

        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁŠJŽn
        // ' ‘ã”[
        // ary = GetColumnList_ABDaino()
        // iEnum = ary.GetEnumerator()
        // While (iEnum.MoveNext())
        // If (strDAINOBldr4.Length > 0) Then
        // strDAINOBldr4.Append(SEPARATOR)
        // End If
        // strDAINOTmp = String.Format(strFormat, STR_E, iEnum.Current)
        // strDAINOBldr4.Append(strDAINOTmp)
        // End While
        // '*—š—ð”Ô† 000002 2004/04/05 ’Ç‰ÁI—¹

        // '*—š—ð”Ô† 000002 2004/04/05 C³ŠJŽn
        // Return strDAINOBldr1.ToString() + SEPARATOR + strDAINOBldr2.ToString() + SEPARATOR + strDAINOBldr3.ToString() + SEPARATOR + strDAINOBldr4.ToString()
        // 'Return strDAINOBldr1.ToString() + SEPARATOR + strDAINOBldr2.ToString() + SEPARATOR + strDAINOBldr3.ToString()
        // '*—š—ð”Ô† 000002 2004/04/05 C³I—¹
        // End Function
        #endregion

        #region ƒf[ƒ^ƒJƒ‰ƒ€ì¬
        // '************************************************************************************************
        // '* ƒƒ\ƒbƒh–¼      ƒf[ƒ^ƒJƒ‰ƒ€ì¬
        // '* 
        // '* \•¶            Private Function CreateColumnsData() As DataTable
        // '* 
        // '* ‹@”\@@        ƒŒƒvƒŠƒJ‚c‚a‚ÌƒJƒ‰ƒ€’è‹`‚ðì¬‚·‚é
        // '* 
        // '* ˆø”           ‚È‚µ
        // '* 
        // '* –ß‚è’l         DataTable() ‘ã”[î•ñƒe[ƒuƒ‹
        // '************************************************************************************************
        // Private Function CreateColumnsData() As DataTable
        // Const THIS_METHOD_NAME As String = "CreateColumnsData"
        // Dim csToshoTable As DataTable
        // Dim csDataColumn As DataColumn

        // Try
        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // ' ‘ã”[î•ñƒJƒ‰ƒ€’è‹`
        // csToshoTable = New DataTable()
        // csToshoTable.TableName = ABToshoTable.TABLE_NAME
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.SHICHOSONCD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 6
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.SHIKIBETSUID, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 4
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.SAKUSEIYMD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 14
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.LASTRECKB, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 1
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.RENBAN, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 7
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.JUMIN_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 8
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.GYOMU_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 2
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.EDABAN, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 3
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.ST_YM, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 6
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.ED_YM, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 6
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.SETAI_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 8
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.DATA_KBN, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 2
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.DAICHO_NO, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 14
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.DATA_SHU, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 2
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.KANASEI, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 24
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.KANAMEI, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 16
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.KANAMEISHO1, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.MEISHO1, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 80
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.KANAMEISHO2, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.MEISHO2, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 80
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.UMARE_YMD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 8
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.UMARE_WYMD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 7
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.SEIBETSU_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 1
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.SEIBETSU, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 2
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.ZOKUGARA_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 8
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.ZOKUGARA, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 30
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.ZOKUGARA_CD2, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 8
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.ZOKUGARA2, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 30
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.K_DAIHYOJUMIN_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 8
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.H_DAIHYOMEI, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.SANGYO_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 4
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.HONTEN_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 8
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.HANYO_KBN1, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 1
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.HOJINKEITAI, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 20
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.KOJINHOJIN_KBN, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 1
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.HOKA_NINZU, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 4
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.HANYO_KBN2, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 1
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.NAIGAI_KBN, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 1
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.YUBIN_NO, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 7
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.JUSHO_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 11
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.JUSHO, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.BANCHI_CD1, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 5
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.BANCHI_CD2, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 5
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.BANCHI_CD3, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 5
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.BANCHI, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 40
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.KATAGAKI_FLG, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 1
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.KATAGAKI_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 4
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.KATAGAKI, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.RENRAKUSAKI1, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 14
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.RENRAKUSAKI2, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 14
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.GYOSEIKU_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 7
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.GYOSEIKU, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.CHIKU_CD1, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 6
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.CHIKU1, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.CHIKU_CD2, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 6
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.CHIKU2, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.CHIKU_CD3, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 6
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.CHIKU3, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.TRK_IDO_YMD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 8
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.TRK_JIYU_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 2
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.SJO_IDO_YMD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 8
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.SJO_JIYU_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 2
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.LAST_RIREKI_NO, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 4
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_DAINO_KBN, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 2
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_JUMIN_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 8
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_SETAI_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 8
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_DATA_KBN, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 2
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_DAICHO_NO, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 14
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_KOJINHOJIN_KBN, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 1
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_DATA_SHU, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 2
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_KANAMEISHO1, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_MEISHO1, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 80
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_KANAMEISHO2, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_MEISHO2, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 80
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_HANYO_KBN1, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 1
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_HOJINKEITAI, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 20
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_HANYO_KBN2, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 1
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_NAIGAI_KBN, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 1
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_YUBIN_NO, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 7
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_JUSHO_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 11
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_JUSHO, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_BANCHI_CD1, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 5
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_BANCHI_CD2, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 5
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_BANCHI_CD3, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 5
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_BANCHI, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 40
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_KATAGAKI_FLG, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 1
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_KATAGAKI_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 4
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_KATAGAKI, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_RENRAKUSAKI1, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 14
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_RENRAKUSAKI2, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 14
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_GYOSEIKU_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 7
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_GYOSEIKU, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_CHIKU_CD1, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 6
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_CHIKU1, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_CHIKU_CD2, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 6
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_CHIKU2, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_CHIKU_CD3, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 6
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_CHIKU3, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 60
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.D_BETSUATENA, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 3
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.IDO_YMD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 8
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.JIYU_CD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 2
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.TRK_YMD, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 8
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.UPDATE_KBN, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 1
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.RSV, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 23
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.USER_ID, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 8
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.WS_ID, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 8
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.UP_DATE, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 14
        // csDataColumn = csToshoTable.Columns.Add(ABToshoTable.LOCK_KEY, System.Type.GetType("System.String"))
        // csDataColumn.MaxLength = 6


        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)


        // Catch objAppExp As UFAppException
        // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
        // m_cfLog.WarningWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
        // "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
        // ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
        // Throw objAppExp

        // Catch objExp As Exception
        // ' ƒGƒ‰[ƒƒOo—Í
        // m_cfLog.ErrorWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒGƒ‰[“à—e:" + objExp.Message + "z")
        // ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
        // Throw objExp
        // End Try

        // Return csToshoTable

        // End Function
        #endregion

        #region ƒf[ƒ^ƒJƒ‰ƒ€ì¬(‹Æ–±EŽ}”
        // '************************************************************************************************
        // '* ƒƒ\ƒbƒh–¼      ƒf[ƒ^ƒJƒ‰ƒ€ì¬
        // '* 
        // '* \•¶            Private Function CreateClmGyomuData() As DataTable
        // '* 
        // '* ‹@”\@@        ƒŒƒvƒŠƒJ‚c‚a‚ÌƒJƒ‰ƒ€’è‹`‚ðì¬‚·‚é
        // '* 
        // '* ˆø”           ‚È‚µ
        // '* 
        // '* –ß‚è’l         DataTable() ‘ã”[î•ñƒe[ƒuƒ‹
        // '************************************************************************************************
        // Private Function CreateClmGyomuData() As DataTable
        // Const THIS_METHOD_NAME As String = "CreateClmGyomuData"
        // Dim csGyomuTable As DataTable
        // Dim csGyomuColumn As DataColumn

        // Try
        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // ' ‘ã”[î•ñƒJƒ‰ƒ€’è‹`
        // csGyomuTable = New DataTable()
        // csGyomuTable.TableName = ABToshoTable.TABLE_NAME
        // csGyomuColumn = csGyomuTable.Columns.Add(ABToshoTable.GYOMU_CD, System.Type.GetType("System.String"))
        // csGyomuColumn.MaxLength = 2
        // csGyomuColumn = csGyomuTable.Columns.Add(ABToshoTable.EDABAN, System.Type.GetType("System.String"))
        // csGyomuColumn.MaxLength = 3

        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // Catch objAppExp As UFAppException
        // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
        // m_cfLog.WarningWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
        // "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
        // ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
        // Throw objAppExp

        // Catch objExp As Exception
        // ' ƒGƒ‰[ƒƒOo—Í
        // m_cfLog.ErrorWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒGƒ‰[“à—e:" + objExp.Message + "z")
        // ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
        // Throw objExp
        // End Try

        // Return csGyomuTable

        // End Function
        #endregion
        // *—š—ð”Ô† 000004 2005/03/22 íœI—¹

        #region ƒ[ƒNƒtƒ[‘—M
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒ[ƒNƒtƒ[‘—M
        // * 
        // * \•¶            Private Sub WorkFlowExec()
        // * 
        // * ‹@”\@@        ƒŒƒvƒŠƒJ‚c‚a‚ÌƒJƒ‰ƒ€’è‹`‚ðì¬‚·‚é
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        public void WorkFlowExec(DataSet csToshoEntity, string WORK_FLOW_NAME, string DATA_NAME)
        {
            const string THIS_METHOD_NAME = "WorkFlowExec";
            UWMessageClass cwMessage;
            UWStartRetInfo cwStartRetInfo;
            var cwStartDataInfoForDataSet = new UWStartDataInfoForDataSet[1];
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            var cwSerialGroupId = new UWSerialGroupId[1];            // ƒVƒŠƒAƒ‹ƒOƒ‹[ƒv
            var cwStartDataInfo = new UWStartDataInfo[1];
            var strHanteiFile = new string[1];

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒ[ƒNƒtƒ[o—ÍÝ’è
                cwStartDataInfoForDataSet[0] = new UWStartDataInfoForDataSet();
                cwStartDataInfoForDataSet[0].p_blnColumnOn = false;                                          // ƒJƒ‰ƒ€î•ñƒtƒ‰ƒO
                cwStartDataInfoForDataSet[0].p_strSep = ",";                                                 // ‹æØ‚è•¶Žš
                cwStartDataInfoForDataSet[0].p_strDataName = DATA_NAME;                                      // ƒf[ƒ^–¼
                cwStartDataInfoForDataSet[0].p_strDataKbn = UWStartDataInfo.DATAKBN_DATA;                    // ƒf[ƒ^‹æ•ª
                cwStartDataInfoForDataSet[0].p_strCompressionType = UWStartDataInfo.COMPRESSIONTYPE_NONE;    // ˆ³kŒ`Ž®

                // ƒ[ƒNƒtƒ[‹N“®—pƒNƒ‰ƒX‚ÌƒvƒƒpƒeƒBÝ’è
                cwMessage = new UWMessageClass(WORK_FLOW_NAME, m_cfControlData.m_strBusinessId);
                cwMessage.p_strWorkFlowName = WORK_FLOW_NAME;
                cwMessage.p_strBusinessCd = ABConstClass.THIS_BUSINESSID;
                cwMessage.p_strApplicationId = m_cfControlData.m_strMenuId;
                cwMessage.p_strUserId = m_cfControlData.m_strUserId;
                cwMessage.p_strClientId = m_cfControlData.m_strClientId;
                // ƒf[ƒ^ƒl[ƒ€‚É‚æ‚Á‚Äƒe[ƒuƒ‹–¼‚Ìê‡•ª‚¯‚ð‚·‚é
                switch (DATA_NAME ?? "")
                {
                    case ATENA:
                        {
                            // *—š—ð”Ô† 000004 2005/02/28 C³ŠJŽn
                            cwStartDataInfoForDataSet[0].p_csData = csToshoEntity.Tables(ABToshoPrmEntity.TABLE_NAME);
                            cwSerialGroupId[0] = new UWSerialGroupId();
                            cwSerialGroupId[0].p_strValue = (string)csToshoEntity.Tables(ABToshoPrmEntity.TABLE_NAME).Rows(0).Item(ABToshoPrmEntity.STAICD);
                            cwMessage.p_arySerialGroupId = cwSerialGroupId;
                            // ƒ[ƒNƒtƒ[o—ÍÝ’è_‚Q
                            cwStartDataInfo[0] = new UWStartDataInfo();
                            cwStartDataInfo[0].p_strDataName = DATA_NAME + "ˆ—";/* TODO ERROR: Skipped SkippedTokensTrivia
»*/// è"                         'ƒf[ƒ^–¼
                            cwStartDataInfo[0].p_strDataKbn = UWStartDataInfo.DATAKBN_PARAM;                    // ƒf[ƒ^‹æ•ª
                            cwStartDataInfo[0].p_strCompressionType = UWStartDataInfo.COMPRESSIONTYPE_NONE;    // ˆ³kŒ`Ž®
                            cwStartDataInfo[0].p_strEncryptionType = UWStartDataInfo.ENCRYPTIONTYPE_NONE;
                            cwStartDataInfo[0].p_strDataType = UWStartDataInfo.DATATYPE_TXT;
                            cwStartDataInfo[0].p_strCharCode = UWStartDataInfo.CHARCODE_SJIS + UWStartDataInfo.CHAR_RENKETSU + UWStartDataInfo.GAIJI_DENSANUSER;
                            strHanteiFile[0] = "SET PRM_FG=0";
                            cwStartDataInfo[0].p_strData = strHanteiFile;
                            cwMessage.p_aryDataInfo = cwStartDataInfo;
                            break;
                        }
                    // -----------------------------------
                    // '''''cwStartDataInfoForDataSet(1) = New UWStartDataInfoForDataSet()
                    // '''''cwStartDataInfoForDataSet(1).p_blnColumnOn = False                                          'ƒJƒ‰ƒ€î•ñƒtƒ‰ƒO
                    // '''''cwStartDataInfoForDataSet(1).p_strSep = ","                                                 '‹æØ‚è•¶Žš
                    // '''''cwStartDataInfoForDataSet(1).p_strDataName = DATA_NAME + "ˆ—”»’è"                         'ƒf[ƒ^–¼
                    // '''''cwStartDataInfoForDataSet(1).p_strDataKbn = UWStartDataInfo.DATAKBN_DATA                    'ƒf[ƒ^‹æ•ª
                    // '''''cwStartDataInfoForDataSet(1).p_strCompressionType = UWStartDataInfo.COMPRESSIONTYPE_NONE    'ˆ³kŒ`Ž®
                    // '''''cwStartDataInfoForDataSet(1).p_strEncryptionType = UWStartDataInfo.ENCRYPTIONTYPE_NONE
                    // '''''cwStartDataInfoForDataSet(1).p_strCharCode = UWStartDataInfo.CHARCODE_SJIS + UWStartDataInfo.CHAR_RENKETSU + UWStartDataInfo.GAIJI_DENSANUSER
                    // '''''cwStartDataInfoForDataSet(1).p_strDataType = UWStartDataInfo.DATATYPE_TXT
                    // '''''cwStartDataInfoForDataSet(1).p_csData = csToshoEntity.Tables(ABToshoPrmEntity.TABLE_NAME)
                    // -------------------------------------
                    // '''''cwStartDataInfoForDataSet(0).p_csData = csToshoEntity.Tables(ABToshoTable.TABLE_NAME)
                    // *—š—ð”Ô† 000004 2005/02/28 C³I—¹
                    case KOKUHO:
                        {
                            cwStartDataInfoForDataSet[0].p_csData = csToshoEntity.Tables(ABKobetsuKokuhoEntity.TABLE_NAME);
                            break;
                        }
                    // *—š—ð”Ô† 000005 2005/10/17 ’Ç‰ÁŠJŽn
                    case JITE:
                        {
                            cwStartDataInfoForDataSet[0].p_csData = csToshoEntity.Tables(ABKobetsuJiteEntity.TABLE_NAME);
                            break;
                        }
                    // *—š—ð”Ô† 000005 2005/10/17 ’Ç‰ÁI—¹
                    // *—š—ð”Ô† 000006 2008/05/14 ’Ç‰ÁŠJŽn
                    case KAIGO:
                        {
                            cwStartDataInfoForDataSet[0].p_csData = csToshoEntity.Tables(ABKobetsuKaigoEntity.TABLE_NAME);
                            break;
                        }
                        // *—š—ð”Ô† 000006 2008/05/14 ’Ç‰ÁI—¹
                }
                cwMessage.SetAryDataInfoFromDataSet(cwStartDataInfoForDataSet);

                try
                {
                    cwStartRetInfo = new UWStartRetInfo();
                    // *—š—ð”Ô† 000005 2005/10/17 C³ŠJŽn
                    // '''cwStartRetInfo = cwMessage.SendPreStartMsg()
                    try
                    {
                        cwStartRetInfo = cwMessage.SendPreStartMsg();
                    }
                    catch
                    {
                        cwStartRetInfo = cwMessage.SendPreStartCancel();
                        throw;
                    }
                    // *—š—ð”Ô† 000005 2005/10/17 C³I—¹

                    if (cwStartRetInfo.p_enStatus == UWReturnCodeTyep.SUCCESS)
                    {
                        try
                        {
                        }
                        // ƒ[ƒNƒtƒ[‹N“®‚n‚j
                        // –{—ˆ‚Í‚±‚±‚ÅƒRƒ~ƒbƒg‚ð‚µ‚È‚¯‚ê‚Î‚È‚ç‚È‚¢
                        catch (Exception objExp)
                        {
                            m_cfLog.DebugWrite(m_cfControlData, default
        /* TODO ERROR: Skipped SkippedTokensTrivia
        ®EƒXƒeƒbƒv‚Q^" + objExp.ToString)
                                cwStartRetInfo = cwMessage.SendPreStartCancel()
                                m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                'ƒGƒ‰[’è‹`‚ðŽæ“¾*/
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
         "ƒ[ƒNƒtƒ[‹N“
          */);
                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE003070);
                            // —áŠO‚ð¶¬
                            throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                        }
                        try
                        {
                            cwStartRetInfo = cwMessage.SendStartMsg();
                            if (cwStartRetInfo.p_enStatus == UWReturnCodeTyep.ERROR)
                            {
                                m_cfLog.DebugWrite(m_cfControlData, default
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
       "ƒ[ƒNƒtƒ[‹N“
        */
       );
                                m_cfErrorClass = new UFErrorClass(ABConstClass.THIS_BUSINESSID);
                                // ƒGƒ‰[’è‹`‚ðŽæ“¾
                                objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE003070);
                                // —áŠO‚ð¶¬
                                throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            }
                        }
                        catch (Exception objExp)
                        {
                            m_cfLog.DebugWrite(m_cfControlData, default
        /* TODO ERROR: Skipped SkippedTokensTrivia
        ®EƒXƒeƒbƒv‚R^" + objExp.ToString)
                                'System.Diagnostics.Debug.WriteLine(ex.Message)
                                cwStartRetInfo = cwMessage.SendPreStartCancel()
                                m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                'ƒGƒ‰[’è‹`‚ðŽæ“¾*/
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
         "ƒ[ƒNƒtƒ[‹N“
          */);
                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE003070);
                            // —áŠO‚ð¶¬
                            throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                        }
                    }
                    // *—š—ð”Ô† 000005 2005/10/17 ’Ç‰ÁŠJŽn
                    else
                    {
                        m_cfLog.DebugWrite(m_cfControlData, default
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
       "ƒ[ƒNƒtƒ[‹N“
        */
       );
                        cwStartRetInfo = cwMessage.SendPreStartCancel();
                        m_cfErrorClass = new UFErrorClass(ABConstClass.THIS_BUSINESSID);
                        // ƒGƒ‰[’è‹`‚ðŽæ“¾
                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE003070);
                        // —áŠO‚ð¶¬
                        throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                        // *—š—ð”Ô† 000005 2005/10/17 ’Ç‰ÁI—¹
                    }
                }
                catch (Exception objExp)
                {
                    m_cfLog.DebugWrite(m_cfControlData, default
        /* TODO ERROR: Skipped SkippedTokensTrivia
        ®EƒXƒeƒbƒv‚P^" + objExp.ToString)
                        m_cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                        'ƒGƒ‰[’è‹`‚ðŽæ“¾*/
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
         "ƒ[ƒNƒtƒ[‹N“
          */);
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE003070);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                }

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 152448


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 152546


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLog.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 152811


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 152896


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }
        #endregion

        // *—š—ð”Ô† 000004 2005/02/28 ’Ç‰ÁŠJŽn
        #region ƒŒƒvƒŠƒJƒf[ƒ^ì¬—pƒpƒ‰ƒ[ƒ^ƒf[ƒ^ƒJƒ‰ƒ€ì¬
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒŒƒvƒŠƒJƒf[ƒ^ì¬—pƒpƒ‰ƒ[ƒ^ƒf[ƒ^ƒJƒ‰ƒ€ì¬
        // * 
        // * \•¶            Private Function CreateColumnsData() As DataTable
        // * 
        // * ‹@”\@@        ƒŒƒvƒŠƒJ‚c‚a‚ÌƒJƒ‰ƒ€’è‹`‚ðì¬‚·‚é
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         DataTable() ‘ã”[î•ñƒe[ƒuƒ‹
        // ************************************************************************************************
        public DataTable CreateColumnsToshoPrmData()
        {
            const string THIS_METHOD_NAME = "CreateColumnsToshoPrmData";
            DataTable csABToshoPrmTable;                       // ƒŒƒvƒŠƒJì¬—pƒpƒ‰ƒ[ƒ^ƒf[ƒ^ƒe[ƒuƒ‹
            DataColumn csDataColumn;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒŒƒvƒŠƒJƒf[ƒ^ì¬—pƒpƒ‰ƒ[ƒ^ƒJƒ‰ƒ€’è‹`
                csABToshoPrmTable = new DataTable();
                csABToshoPrmTable.TableName = ABToshoPrmEntity.TABLE_NAME;
                csDataColumn = csABToshoPrmTable.Columns.Add(ABToshoPrmEntity.JUMINCD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 15;
                csDataColumn = csABToshoPrmTable.Columns.Add(ABToshoPrmEntity.STAICD, Type.GetType("System.String"));
                csDataColumn.MaxLength = 15;
                csDataColumn = csABToshoPrmTable.Columns.Add(ABToshoPrmEntity.KOSHINKB, Type.GetType("System.String"));
                csDataColumn.MaxLength = 1;

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 155465


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 155563


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLog.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 155828


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 155913


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }
            return csABToshoPrmTable;

        }
        #endregion
        // *—š—ð”Ô† 000004 2005/02/28 ’Ç‰ÁI—¹

    }
}