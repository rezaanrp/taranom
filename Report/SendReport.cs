using System.Collections.Generic;
using System.Data;

namespace Report
{
    public class SendReport
    {
        public CrystalDecisions.CrystalReports.Engine.ReportDocument GetReport(System.Data.DataTable Data, string NameReport)
        {
            if (NameReport == "")
                return null;
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = FindReport(NameReport);
            if (Data != null)
                rpt.SetDataSource(Data);
            else
            {
                Data = new DataTable();
            //    rpt.SetDataSource(Data);
            }
            while (stackParamName.Count > 0)
            {
                rpt.SetParameterValue(stackParamName.Pop(), stackParamValue.Pop());

            }
            return rpt;
        }

    
        public CrystalDecisions.CrystalReports.Engine.ReportDocument GetReport(System.Data.DataTable Data, string NameReport,System.Data.DataTable Data_S, string NameReport_S)
        {
            if (NameReport == "")
                return null;
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = FindReport(NameReport);
            rpt.SetDataSource(Data);
            rpt.Subreports[NameReport_S].SetDataSource(Data_S);

            while (stackParamName.Count > 0)
            {
                rpt.SetParameterValue(stackParamName.Pop(), stackParamValue.Pop());

            }
            return rpt;
        }
        private Stack<string> stackParamName = new Stack<string>();
        private Stack<string> stackParamValue = new Stack<string>();

        public void SetParam(string Name, string Value)
        {
            stackParamName.Push(Name);
            stackParamValue.Push(Value);
        }

        private CrystalDecisions.CrystalReports.Engine.ReportDocument FindReport(string Name)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt;
            switch (Name)
            {

                 
                case "crsExitPermitRequest":
                    rpt = new crsExitPermitRequest();
                    break;
                case "crsPiecesProductPlanSub":
                    rpt = new crsPiecesProductPlanInstance();
                    break;
                case "crsPiecesProductPlanMachinigSub":
                    rpt = new crsPiecesProductPlanInstanceMachinig();
                    break;

                case "SendProductToTurning":
                    return new crsSendProductToTurning();

                case "crsPerFoodStatus":
                    return new crsPerFoodStatus();

                case "crsPruductInspectionMachiningCheckList":
                    return new crsPruductInspectionMachiningCheckList();

                //case "crsPerFoodTickets":
                //    return new crsPerFoodTickets();


                case "crsSlFireExtinguisherEXP":
                    rpt = new crsSlFireExtinguisherEXP();
                    break;
                case "crsToolsPerson":
                    rpt = new crsToolsPerson();
                    break;
                case "crsToolsDelivery":
                    rpt = new crsToolsDelivery();
                    break;
                case "crsProcurmentScarbTestFN3":
                    rpt = new crsProcurmentScarbTestFN3();
                    break;
                case "crsOverTime_WorkTime":
                    rpt = new crsOverTime_WorkTime();
                    break;
                case "crsOverTime_R":
                    rpt = new crsOverTime_R();
                    break;
                case "crsProductRepairRequest":
                    rpt = new crsProductRepairRequest();
                    break;
                case "crsMessageElan":
                    rpt = new crsMessageElan();
                    break;
                case "crsAidPerson":
                    rpt = new crsAidPerson();
                    break;

                case "crsSalePlanTurning":
                    rpt = new crsSalePlanTurning();
                    break;
                case "crsProcurmentMaterialSampleReceipt":
                    rpt = new crsProcurmentMaterialSampleReceipt();
                    break;
                case "crsProcurmentMaterialTest_FN":
                    rpt = new crsProcurmentMaterialTest_FN();
                    break;
                case "crsMucsleSendReport":
                    rpt = new crsMucsleSendReport();
                    break;
                case "PruductInspectionByMonthTotal":
                    rpt = new crsPruductInspectionByMonthTotal();
                    break;
                case "crsDayHourPlannig":
                    rpt = new crsDayHourPlannig();
                    break;
                case "crsPiecesProductPlan":
                    rpt = new crsPiecesProductPlan();
                    break;
                case "crsPiecesProductPlan_Machining":
                    rpt = new crsPiecesProductPlan_Machining();
                    break;
                case "crsProcurmentScarbTestFn":
                    rpt = new crsProcurmentScarbTestFn();
                    break;
                case "crsMoldingSpeed":
                    rpt = new crsMoldingSpeed();
                    break;
                case "crsProductInspectionCompare":
                    rpt = new crsProductInspectionCompare();
                    break;
                case "crsInventoryScrab":
                    rpt = new crsInventoryScrab();
                    break;
                case "crsProcurmentScrabSuStu":
                    rpt = new crsProcurmentScrabSuStu();
                    break;
                case "crsProcurmentMaterialSuStu":
                    rpt = new crsProcurmentMaterialSuStu();
                    break;
                case "crsAnalysisFurnaceSPC":
                    rpt = new crsAnalysisFurnaceSPC();
                    break;
                case "crsInvMaterialInput":
                    rpt = new crsInvMaterialInput();
                    break;
                case "crsInvMaterialInputLabel":
                    rpt = new crsInvMaterialInputLabel();
                    break;
                case "crsSendProduct":
                    rpt = new crsSendProduct();
                    break;
                case "crsSalePlan":
                    rpt = new crsSalePlan();
                    break;
                case "crsPerFoodStatusSummery":
                    rpt = new crsPerFoodStatusSummery();
                    break;
                case "crsSandWeeklyTest":
                    rpt = new crsSandWeeklyTest();
                    break;
                case "crsNonConforming":
                    rpt = new crsNonConforming();
                    break;
                case "crsDownTimeByDateGDurationHSection":
                    rpt = new crsDownTimeByDateGDurationHSection();

                    break;
                case "crsFoundryDetailsTotalMeltByZinter":
                    rpt = new crsFoundryDetailsTotalMeltByZinter();

                    break;

                case "crsProcurmentEnteryMaterial":
                    rpt = new crsProcurmentEnteryMaterial();

                    break;

                case "crsProductInspection":
                    rpt = new crsProductInspection();

                    break;
                case "crsProductInspectionChart":
                    rpt = new crsProductInspectionChart();

                    break;
                case "crsProductInspectionGroupByDate":
                    rpt = new crsProductInspectionGroupByDate();

                    break;
                case "crsSandDailyReport":
                    rpt = new crsSandDailyReport();

                    break;
                case "crsSandMaterialUsage":
                    rpt = new crsSandMaterialUsage();

                    break;
                case "crsSandMaterialUsageRangDate":
                    rpt = new crsSandMaterialUsageRangDate();
                    break;
                case "crsSandMaterialAndDaily":
                    rpt = new crsSandMaterialAndDaily();
                    break;
                case "crsInventory":
                    rpt = new crsInventory();
                    break;
                case "crsInventoryTotal":
                    rpt = new crsInventoryTotal();
                    break;
                case "crsPieces":
                    rpt = new crsPieces();
                    break;
                case "crsPruductInspectionDefectDetials":
                    rpt = new crsPruductInspectionDefectDetials();
                    break;
                case "crsPiecesProuductAndDetial":
                    rpt = new crsPiecesProuductAndDetial();
                    break;
                case "crsPiecesProuductAndDetialAll":
                    rpt = new crsPiecesProuductAndDetialAll();
                    break;
                case "crsSandDailyReportAndRptEqu":
                    rpt = new crsSandDailyReportAndRptEqu();
                    break;
                case "crsMoldingDownTimeTtTiGr_Report":
                    rpt = new crsMoldingDownTimeTtTiGr_Report();
                    break;
                case "crsPruductInspection_PcNbDefect":
                    rpt = new crsPruductInspection_PcNbDefect();
                    break;
                case "crsPruductInspection_DefectNbPc":
                    rpt = new crsPruductInspection_DefectNbPc();
                    break;
                case "crsPruductInspectionByMonth":
                    rpt = new crsPruductInspectionByMonth();
                    break;
                case "crsPruductInspectionDefectDetialsGroup":
                    rpt = new crsPruductInspectionDefectDetialsGroup();
                    break;
                case "crsPruductInspection_PcDefectNb":
                    rpt = new crsPruductInspection_PcDefectNb();
                    break;
                case "crsSlSandWeeklyTestSpc":
                    rpt = new crsSlSandWeeklyTestSpc();
                    break;
                case "Chart_ProcessControl":
                    rpt = new Chart_ProcessControl();
                    break;
                case "crsSandDailyTestSpc":
                    rpt = new crsSandDailyTestSpc();
                    break;

                case "crsProcurmentScarbTest":
                    rpt = new crsProcurmentScarbTest();
                    break;
                case "crsProcurmentMaterialTest":
                    rpt = new crsProcurmentMaterialTest();
                    break;
                case "crsProcurmentMaterialTestTR":
                    rpt = new crsProcurmentMaterialTestTR();
                    break;
                case "crsSandDailyTestMoANDCs":
                    rpt = new crsSandDailyTestMoANDCs();
                    break;
                case "crsProcurmentScarbTestRP":
                    rpt = new crsProcurmentScarbTestRP();
                    break;
                case "crsProcurmentMaterialTestRP":
                    rpt = new crsProcurmentMaterialTestRP();
                    break;
                case "crsExitPermit":
                    rpt = new crsExitPermit();
                    break;
                case "crsFoundryMaterialUsage":
                    rpt = new crsFoundryMaterialUsage();
                    break;

                case "crsProcurmentScarbTestCo":
                    rpt = new crsProcurmentScarbTestCo();
                    break;

                case "crsProcurmentMaterialTestCo":
                    rpt = new crsProcurmentMaterialTestCo();
                    break;
                case "crsNonConformingParato":
                    rpt = new crsNonConformingParato();
                    break;
                case "crsAnalysisFurnace":
                    rpt = new crsAnalysisFurnace();
                    break;

                case "crsMoldingDownTimeByDetial":
                    rpt = new crsMoldingDownTimeByDetial();
                    break;
                default:
                    rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                    break;


            }
            return rpt;
        }
    }
}
