using System.Collections.Generic;

namespace Payazob.CS
{
    public class csDic
    {

        public string EnToFarsiCatalog(string StInput)
        {
            Dictionary<string, string> dictionary =
   new Dictionary<string, string>();
            dictionary.Add("xDateEnter", "تاریخ ورود");
            dictionary.Add("xDateTest", "تاریخ آزمایش");
            dictionary.Add("xMaterial_", "نام مواد");
            dictionary.Add("xSupplierCompany_", "شرکت تامین کننده");
            dictionary.Add("xDriverName", "نام راننده");
            dictionary.Add("xDriverTel", "تلفن");
            dictionary.Add("xWeightBeginning", " وزن مبدا - کیلوگرم ");
            dictionary.Add("xWeightDestination", "وزن مقصد - کیلوگرم ");
            dictionary.Add("xRent", "کرایه - تومان");
            dictionary.Add("xVisualScore", "امتیاز ظاهری");
            dictionary.Add("xExperimentalScore", "امتیاز آزمایش");
            dictionary.Add("xGradeProduct", "درجه محصول");
            dictionary.Add("xState", "وضعیت");
            dictionary.Add("xConfirm", "تایید");
            dictionary.Add("xSupplier", "ثبت کننده");
            dictionary.Add("xApprove", "تایید کننده");
            dictionary.Add("xComment", "توضیحات");
            dictionary.Add("xTRConfirm", "تایید نهایی");
            dictionary.Add("xTRconfirm", "تایید نهایی");
            dictionary.Add("xTRApprove", "نام تایید کننده نهایی");
            dictionary.Add("xElemant_", "عنصر");
            dictionary.Add("xAmount", "مقدار");
            dictionary.Add("xCarNumber", "شماره پلاک");

            dictionary.Add("xUsage", "مقدار مصرف");
            dictionary.Add("xUsageMeltingAmount", "مقدار ذوب مصرفی");
            dictionary.Add("xAbsorptionPercent", "درصد جذب");

            dictionary.Add("xEntranceNumber", "شماره اعلام ورود");
            dictionary.Add("xRequestingItem", "موارد خواسته شد");
            dictionary.Add("xTestResults", "نتایج حاصله از آزمایش");
            dictionary.Add("xQCComment", "توضیحات");

            dictionary.Add("Material", "نام کالا");
            dictionary.Add("Company", "نام شرکت");

            dictionary.Add("xDate", "تاریخ");
            dictionary.Add("xCode", "کد خروج");
            dictionary.Add("xMaterial", "نام مواد");
            dictionary.Add("xType", "نوع");
            dictionary.Add("xModule_", "واحد");
            dictionary.Add("xReceiver", "مقصد - تحویل گیرنده");
            dictionary.Add("xDateReturn", "تاریخ عودت");
            dictionary.Add("xInventorConfirm", "تایید انباردار");
            dictionary.Add("xSecuritySectionConfirm", "تایید انتظامات");
            dictionary.Add("xManagerConfirm", "تایید مدیر");
            dictionary.Add("xBossConfirm", "تایید مدیر کارخانه");
            dictionary.Add("xSupplier_", "تهیه کننده");
            dictionary.Add("xSection_", "نام قسمت");
            dictionary.Add("xInventor_", " انبار دار");
            dictionary.Add("xSecuritySection_", " انتظامات");
            dictionary.Add("xManager_", "مدیر");
            dictionary.Add("xBoss_", "مدیر کارخانه");
            dictionary.Add("xConfirmBack", "تایید برگشت");
            dictionary.Add("Supplier", "تهیه کننده");
            dictionary.Add("Inventor", "انبار دار");
            dictionary.Add("SecuritySection", "انتظامات");
            dictionary.Add("Manager", "مدیر");
            dictionary.Add("Boss", "مدیر کارخانه");
            dictionary.Add("xOutCause", "علت خروج");
            dictionary.Add("xDateBack", "تاریخ برگشت");
            dictionary.Add("xReceiverBack", "تحویل دهنده");
            dictionary.Add("xCommentBack", "توضیحات");
            dictionary.Add("xAmountBack", "مقدار برگشت");

            dictionary.Add("xNonConformingType_", "شماره عدم تطابق");
            dictionary.Add("xPieces_", "نام قطعه");
            dictionary.Add("xQuarantineNumber", "تعداد قرنطینه");
            dictionary.Add("xTime", "ساعت");
            dictionary.Add("xDateProuduct", "تاریخ تولید");
            dictionary.Add("xFormNo", "شماره فرم");
            dictionary.Add("xNonconformTitleDate", "تاریخ عدم انطباق");
            dictionary.Add("xNonconformTitle", "علت مغایرت");
            dictionary.Add("xControllerName", "نام بازرس");
            dictionary.Add("xTakenActionDate", "تاریخ اقدام انجام گرفته");
            dictionary.Add("xTakenAction", "شرح اقدامات");
            dictionary.Add("xResult", "نتایج اقدامات انجام گرفته");
            dictionary.Add("xQualityComment", "نظریه سرپرست کنترل کیفی");


            dictionary.Add("xMoisturePercentUcl", "MoisturePercent Ucl");
            dictionary.Add("xMoisturePercentCl", "MoisturePercent Cl");
            dictionary.Add("xMoisturePercentLcl", "MoisturePercent Lcl");
            dictionary.Add("xMoisturePercentUsl", "MoisturePercent Usl");
            dictionary.Add("xMoisturePercentSl", "MoisturePercent Sl");
            dictionary.Add("xMoisturePercentLsl", "MoisturePercent Lsl");
            dictionary.Add("xPermeabilityUcl", "Permeability Ucl");
            dictionary.Add("xPermeabilityCl", "Permeability Cl");
            dictionary.Add("xPermeabilityLcl", "Permeability Lcl");
            dictionary.Add("xPermeabilityUsl", "Permeability Usl");
            dictionary.Add("xPermeabilitySl", "Permeability Sl");
            dictionary.Add("xPermeabilityLsl", "Permeability Lsl");
            dictionary.Add("xCompresiveStrengthUcl", "CompresiveStrength Ucl");
            dictionary.Add("xCompresiveStrengthCl", "CompresiveStrength Cl");
            dictionary.Add("xCompresiveStrengthLcl", "CompresiveStrength Lcl");
            dictionary.Add("xCompresiveStrengthUsl", "CompresiveStrength Usl");
            dictionary.Add("xCompresiveStrengthSl", "CompresiveStrength Sl");
            dictionary.Add("xCompresiveStrengthLsl", "CompresiveStrength Lsl");
            dictionary.Add("xCompactibilityUcl", "Compactibility Ucl");
            dictionary.Add("xCompactibilityCl", "Compactibility Cl");
            dictionary.Add("xCompactibilityLcl", "Compactibility Lcl");
            dictionary.Add("xCompactibilityUsl", "Compactibility Usl");
            dictionary.Add("xCompactibilitySl", "Compactibility Sl");
            dictionary.Add("xCompactibilityLsl", "Compactibility Lsl");

            dictionary.Add("xCount", "تعداد");
            dictionary.Add("xCustomer_", "مشتری");
            dictionary.Add("xSaleType", "نوع فروش");
            dictionary.Add("xSendKanban", "ارسال کانبان");
            dictionary.Add("xCarType", "نوع ماشین");
            dictionary.Add("xTradeComment", "توضیحات بازرگانی");
            dictionary.Add("xPlanComment", "توضیحات برنامه ریزی");
            dictionary.Add("xPlanUserConfirm_", "کاربر برنامه ریزی");
            dictionary.Add("xPlanUserConfirm", "کاربر برنامه ریزی");
            dictionary.Add("xConfirmDate", "تاریخ تایید");
            dictionary.Add("xConfirmKanban", "تایید کانبان");
            dictionary.Add("xDraftNumber", "شماره حواله");
            dictionary.Add("xQcComment", "توضیحات کنترل کیفیت");
            dictionary.Add("xQcUserConfirm_", "کاربر کنترل کیفیت");
            dictionary.Add("xQcUserConfirm", "کاربر کنترل کیفیت");
            dictionary.Add("xDayNumber", "روز شمار");
            dictionary.Add("xScUserConfirm_", "کاربر انتظامات");
            dictionary.Add("xScUserConfirm", "کاربر انتظامات");
            dictionary.Add("xWeight", "وزن");
            dictionary.Add("xNumberLading", "شماره باربری");
            dictionary.Add("xFreightName", "نام بابری");
            dictionary.Add("xReceptionConfirm", " دریافت گواهی سلامت محصول");
            dictionary.Add("xFinalConfirm", "تایید نهایی");
            dictionary.Add("xQcConfirm", "تایید کنترل کیفیت");
            //     dictionary.Add("xScConfirm", "تایید انتظامات");

            //   dictionary.Add("xLineCount", "تعداد خط");
            dictionary.Add("xHour", "ساعت");
            dictionary.Add("xDay", "روز");
            dictionary.Add("xIsPm", "تعمیرات نگهداری");


            dictionary.Add("BDate", "تاریخ زینتر قبلی");
            dictionary.Add("ADate", "تاریخ زینتر بعدی");
            dictionary.Add("TotalMaterial", "مجموع ذوب");
            dictionary.Add("NumberFurnace", "شماره کوره");
            dictionary.Add("AIsHalfZinter", "نوع زینتر");
            dictionary.Add("BIsHalfZinter", "نوع زینتر");


            dictionary.Add("xProductionDate", "تاریخ تولید");
            dictionary.Add("ShiftName", "نام شیفت");
            dictionary.Add("Piece", "نام قطعه");
            dictionary.Add("DefectNumber", "تعداد ضایعات");
            dictionary.Add("ControlledNumber", "تعداد کنترل شده");
            dictionary.Add("DefectPrecent", "درصد ضایعات");

            dictionary.Add("Bantonit", "بنتونیت");
            dictionary.Add("SandNew", "ماسه نو");
            dictionary.Add("CoalDust", "گرد زغال");
            dictionary.Add("Water", "آب");
            dictionary.Add("SandReturn", "ماسه برگشتی");
            dictionary.Add("BatchCount", " تعداد بچ ساخته شده");
            dictionary.Add("AVGBantonit", " بنتونیت به ازای هر بچ");
            dictionary.Add("AVGSandNew", "  ماسه نو به ازای هر بچ");
            dictionary.Add("AVGCoalDust", " گرد زغال به ازای هر بچ");
            dictionary.Add("AVGWater", " آب به ازای هر بچ");
            dictionary.Add("AVGSandReturn", " ماسه برگشتی به ازای هر بچ ");


            dictionary.Add("xPiecesLine1", "نام قطعه خط یک");
            dictionary.Add("xPiecesLine2", "نام قطعه خط دو");
            dictionary.Add("xSamplingTime", "زمان نمونه گیری");
            dictionary.Add("xMoisturePercent", "درصد رطوبت");
            dictionary.Add("xPermeability", "عبور گاز");
            dictionary.Add("xCompresiveStrength", "استحکام فشاری");
            dictionary.Add("xCompactibility", "تراکم پذیری");


            dictionary.Add("xName", "نام ");
            dictionary.Add("BeforPiecesProducts", "تعداد تولید قبل از دوره");
            dictionary.Add("BeforSendNumber", "تعداد ارسال به انبار قبل از دوره");
            dictionary.Add("BeforDefectNumber", "ضایعات قبل از دوره");
            dictionary.Add("AfterPiecesProducts", "تعداد قطعه تولید شده در دوره");
            dictionary.Add("AfterSendNumber", "تعداد ارسال به انبار در دوره");
            dictionary.Add("AfterDefectNumber", "تعداد ضایعات در دوره");
            dictionary.Add("inventory", "موجودی در گردش");
            dictionary.Add("Pieceweight", "وزن قطعه");
            dictionary.Add("PieceweightTotal", "وزن موجودی");

            dictionary.Add("Pieces", "نام قطعه");
            dictionary.Add("NumberPieces", "تعداد تولید");
            dictionary.Add("TotalPieceweight", "کیلوگرم وزن قطعه");
            dictionary.Add("Mold", "تعداد قالب");
            dictionary.Add("castweight", "وزن ذوب ریخته شده");



            dictionary.Add("Shift", "شیفت");
            dictionary.Add("xLineNumber", "شماره خط");

            dictionary.Add("xReportOther", "گزارشات دیگر");
            dictionary.Add("xReportMechanical", "گزارش مکانیکی");
            dictionary.Add("xReportElectric", "گزارش برقی");


            //    dictionary.Add("xName", "نام قطعه");
            dictionary.Add("xKind", "نوع");
            dictionary.Add("xStandard", "استاندارد");
            dictionary.Add("xPieceweight", "وزن قطعه");
            dictionary.Add("xTechnicalname", "نام تکنیکی");
            dictionary.Add("xKbythtotal", "تعداد کویته");
            dictionary.Add("xSolutionweight", "وزن راهکار");
            dictionary.Add("Efficiency", "بازده");
            dictionary.Add("MeltingWeight", "وزن ذوب هر قالب");

            dictionary.Add("xSpeedMolding", "سرعت قالب گیری ");

            dictionary.Add("xConsumption", "مورد مصرف");
            dictionary.Add("xNumberPerUnit", "ضریب مصرف");
            //   dictionary.Add("xCode", "کد محصول");

            dictionary.Add("xLastModifiedWeight", "وزن قبلی");
            dictionary.Add("xLastModifiedDate", "تاریخ آخرین ویرایش");

            dictionary.Add("xBalanceBegin", "موجودی ابتدای دوره");

            dictionary.Add("PiecesName", "نام قطعه");
            dictionary.Add("xSendNumber", "تعداد");

            //dictionary.Add("Material_","نا");
            dictionary.Add("MaterialName", "نام مواد");
            //dictionary.Add("Amount","");
            dictionary.Add("xLocation", "مکان");
            dictionary.Add("xDatePrd", "تاریخ تولید");
            dictionary.Add("xDateExp", "تاریخ انقضا");
            dictionary.Add("xDateAlarm", "تعداد روز قبل ازهشدار");
            dictionary.Add("xSystemCode", "کد سیستم");
            dictionary.Add("xRemain", "مقدار باقی مانده");

            dictionary.Add("xAct", "قبول");
            dictionary.Add("xDny", "رد");
            dictionary.Add("xOth", "مشروط");

            dictionary.Add("xMaterialName", "نام مواد");

            dictionary.Add("MaterialEnterB", "مقدار ورودی قبل از دوره");
            dictionary.Add("MaterialUsageB", "مقدار مصرفی قبل از دوره");

            dictionary.Add("MaterialEnter", "مقدار ورودی");
            dictionary.Add("MaterialUsage", "مقدار مصرفی");
            dictionary.Add("inventoryScrab", "مقدار قراضه در گردش");
            dictionary.Add("BalanceBegin", "موجودی ابتدای دوره");
            dictionary.Add("tedad", "تعداد");
            dictionary.Add("Title", "مرکز هزینه");

            dictionary.Add("StandardINV", "استاندارد");

            dictionary.Add("StandardSTC", "استاندارد");

            dictionary.Add("xPerCode", "شماره پرسنلی");
            dictionary.Add("xLunch", "نهار");
            dictionary.Add("xDinner", "شام");

            dictionary.Add("xPieces_Pr", "نام محصول - تولید ");
            dictionary.Add("PiecesProductCount", "تعداد محصول تولید شده");
            dictionary.Add("ProductionDate_QC", "تاریخ تولید - کنترل کیفیت");
            dictionary.Add("xPieces_QC", "نام قطعه - کنترل کیفیت");
            dictionary.Add("xControlledNumber", "تعداد کنترل  شده");
            dictionary.Add("Defect", "تعداد ضایعات");
            dictionary.Add("DefectPercent", "در صد ضایعات");
            dictionary.Add("DefectPercentText", "در صد ضایعات");

            dictionary.Add("CountPieces", "تعداد قطعه");
            dictionary.Add("TotalMin", "زمان - دقیقه");
            dictionary.Add("SpeedMoldingCalc", "سرعت قالب گیری محاسبه شده");
            dictionary.Add("SpeedMoldingPln", "سرعت قالب گیری در برنامه");

            dictionary.Add("line1", "خط یک");
            dictionary.Add("line2", "خط دو");

            dictionary.Add("xPerCount", "تعداد پرسنل");

            dictionary.Add("DownTimeType", "نوع توقف");
            dictionary.Add("xDuration", "مدت");
            dictionary.Add("xIsNight", "شبکاری");
            dictionary.Add("Totalweight", "وزن کل");



            dictionary.Add("NameMonthProduct", "اسم ماه");
            dictionary.Add("MonthProduct", "شماره ماه");
            dictionary.Add("WeightDefectPercent", "درصد کیلوگرم ضایعات");
            dictionary.Add("NumberDefectPercent", "درصد تعداد ضایعات");
            dictionary.Add("WeightDefectNumber", "وزن ضایعات");
            dictionary.Add("WeightControlledNumber", "وزن قطعات کنترل شده");

            dictionary.Add("CountMuscle", "تعداد ماهیچه");
            dictionary.Add("MuscleName", "نام ماهیچه");

            dictionary.Add("MinStock", "حداقل موجودی مورد نیاز");
            dictionary.Add("stock", "موجودی ماهیچه");
            dictionary.Add("MusclePlan", " مقدار ماهیچه در برنامه");
            dictionary.Add("NesMuscle", "مقدار ماهیچه مورد نیاز ");

            dictionary.Add("Stock", "موجودی انبار محصول");
            dictionary.Add("Inventory", "موجودی انبار نیمه ساخته");


            dictionary.Add("xSCUser_", "کاریر انتظامات");
            dictionary.Add("xSCUser", "کابر انتظامات");
            dictionary.Add("xSCConfirm", "تایید انتظامات");
            dictionary.Add("xWeightSend", "مقدار وزن حواله");
            dictionary.Add("xReceiverName", "دریافت کننده");
            dictionary.Add("xQuarantineWarehouseReceipt", "رسید انبار قرنطینه");
            dictionary.Add("xTransfersFromQuarantine", "حواله از انبار قرنطینه");
            dictionary.Add("xDateTransfer", "تاریخ حواله");
            dictionary.Add("xTimeTransfer", "ساعت حواله");
            dictionary.Add("xStockUser_", "کاربر انبار");
            dictionary.Add("xStockUser", "کاربر انبار");
            dictionary.Add("xStockConfirm", "تایید انبار دار");
            dictionary.Add("xStockComment", "توضیحات انبار دار");
            dictionary.Add("xQCConfirm", "تایید کنترل کیفیت");
            dictionary.Add("xQCUser_", "کاربر کنترل کیفیت");
            dictionary.Add("xQCUser", "کاربر کنترل کیفیت");
            dictionary.Add("xTRUser_", "کاربر بازرگانی");
            dictionary.Add("xTRUser", "کاربر بازرگانی");

            dictionary.Add("xFamily", "نام خانوادگی");
            dictionary.Add("xPerID", "شماره پرسنلی");
            dictionary.Add("xEmail", "ایمیل");
            dictionary.Add("xNationalCode", "کدملی");
            dictionary.Add("xAddress", "ادرس");
            dictionary.Add("xMob", "تلفن همراه ");
            dictionary.Add("xTel", "تلفن ثابت");
            dictionary.Add("xFatherName", "نام پدر");
            dictionary.Add("xIdentity", "شماره شناسنامه");
            dictionary.Add("xActive", "فعال");
            dictionary.Add("xReturnCustomer", "برگشت از مشتری");

            dictionary.Add("xEducation_", "تحصیلات");
            dictionary.Add("xPost", "سمت");
            dictionary.Add("xBirthDay", "تاریخ تولد");
            dictionary.Add("xDateEmployeement", "تاریخ استخدام");


            dictionary.Add("NameFamily", "نام و خانوادگی");
            dictionary.Add("Section", "نام قسمت");
            dictionary.Add("xBeginTimeOver1", "زمان شروع");
            dictionary.Add("xEndTimeOver1", "زمان پایان");
            dictionary.Add("xBeginTimeOver2", "زمان شروع بازنگری");
            dictionary.Add("xEndTimeOver2", "زمان پایان بازنگری");
            dictionary.Add("DurationMin", "مدت اضافه کاری");
            dictionary.Add("xReason", "علت اضافه کاری");


            dictionary.Add("nameobject", "نام قطعه");
            dictionary.Add("xnameset", "نام دستگاه");
            dictionary.Add("xnameset1", "نام مجموعه یک");
            dictionary.Add("xnameset2", "نام مجموعه دو");
            dictionary.Add("xnameset3", "نام مجموعه 3");
            //   dictionary.Add("xCount","تعداد");
            dictionary.Add("xCodeParent", "کد");
            dictionary.Add("xNeedExtra", "نیازمند یدکی");
            dictionary.Add("SerialSG", "کد در همکاران");

            //xLocation,
            //xSupplier,
            dictionary.Add("xWareHouse", "انبار دار");
            dictionary.Add("xDateWareHouse", "تاریخ تحویل");
            dictionary.Add("xNet", "تایید کننده ");
            //  xSerialSG      
            dictionary.Add("xShiftName", "نام شیفت");
            dictionary.Add("xShiftSuperviser", "سرپرست شیفت");
            dictionary.Add("xShiftSuperviser_", "سرپرست شیفت");
            dictionary.Add("xShiftInspector", "اپراتور بازرس شیفت");
            dictionary.Add("xFernesSuperviser", "سرپرست کوره");
            dictionary.Add("xSandOperator", "اپراتور خط ماسه");

            dictionary.Add("ToolsName", "نام ابزار");
            dictionary.Add("xReturnDate", "تاریخ برگشت");
            dictionary.Add("xCountReturn", "تعداد برگشت شده");
            dictionary.Add("xDateStart", "تاریخ شروع");
            dictionary.Add("xDescription", "توضیحات");


            //      x_, xDate, xTime, xPerId_, xDescriptionOfEvent, xOrgan, xReasonOfEvent, xComment, xSupplier_

            dictionary.Add("xDescriptionOfEvent", "شرح واقعه");
            dictionary.Add("xOrgan", "عضو حادثه دیده");
            dictionary.Add("xReasonOfEvent", "علت حادثه");
            dictionary.Add("xCorrectiveAction", "اقدام اصلاحی");

            dictionary.Add("xDescriptionOfDefects", "شرح نواقص");
            dictionary.Add("xNextActions", "اقدامات بعدی");
            dictionary.Add("xActionDeadline", "مهلت اقدام");
            dictionary.Add("xFormNumber", "شماره فرم");
            dictionary.Add("DurationToAll", "درصد زمان به کل");

            dictionary.Add("xDescriptionWarning", "شرح تذکرات");
            dictionary.Add("xCountPlan", "تعداد در برنامه");

            dictionary.Add("xNameFarsi", "نام فارسی");
            dictionary.Add("xGroupFarsi", "نام گروه فارسی");
            dictionary.Add("xValue", "مقدار");


            dictionary.Add("xObjectname", "نام ");
            dictionary.Add("xObjectFarsiName", "نام فارسی");

            dictionary.Add("xDateCharge", "تاریخ شارژ ");
            dictionary.Add("xDateEXP", "تاریخ اعتبار");

            dictionary.Add("xPerInfo_", "کد پرسنلی");
            //dictionary.Add("xWeight" ,"");
            dictionary.Add("xBloodPressure", "فشار خون");
            dictionary.Add("xEyeDis", "چشم");
            dictionary.Add("xSkinAndHair", "پوست و مو");
            dictionary.Add("xEar", "گوش");
            dictionary.Add("xHeadAndNeck", "سر و گردن");
            dictionary.Add("xLung", "ریه");
            dictionary.Add("xCardiovascular", "قلبی و عروقی");
            dictionary.Add("xAbdomenAndPelvis", "شکم و لگن");
            dictionary.Add("xKidney", "کلیه و مجاری");
            dictionary.Add("xMusculoskeletal", "اسکلتی و عضلانی");
            dictionary.Add("xNervousSystem", "سیتم عصبی");
            dictionary.Add("xPsychiatry", "روان");
            dictionary.Add("xOther", "سایر موارد");
            dictionary.Add("xREye", "چشم راست");
            dictionary.Add("xLEye", "چشم چپ");
            dictionary.Add("xRAudiometry", "ادیومتری راست");
            dictionary.Add("xLAudiometry", "ادیو متری چپ");
            dictionary.Add("xSpirometry", "اسپیرومتری");
            dictionary.Add("xFinal", "نتیجه نهایی");

            dictionary.Add("FireExtinguisherType", "نوع کپسول");
            dictionary.Add("xRegion", "نام استان");
            dictionary.Add("xCity", "نام شهر");
            dictionary.Add("ToolsNameDelivery", "نام اقلام دریافت شده");
            dictionary.Add("xPeriod", "دوره");

            dictionary.Add("NamePiecesOnPlan", "نام قطعه در برنامه");
            dictionary.Add("CountOnPlan", "تعداد قطعه در برنامه");
            dictionary.Add("xDifference", "اختلاف");


            dictionary.Add("xIsSemi", "حوادث جرئی");
            dictionary.Add("xCorrectiveCount", "تعداد بازکاری");
            dictionary.Add("xStartTime", "زمان شروع");
            dictionary.Add("xEndTime", "زمان پایان");
            dictionary.Add("MachineName", "نام دستگاه");
            dictionary.Add("xProductOperation_", " OP ");
            dictionary.Add("xOp_", " OP ");
            dictionary.Add("xDefect", " ضایعات ");
            dictionary.Add("xDefectNumber", " تعداد ضایعات ");
            dictionary.Add("OperatorName", "نام اپراتور");
            dictionary.Add("xDefectName", "نوع ضایعات");
            dictionary.Add("xTransferee", "تحویل گیرنده");
            dictionary.Add("xRelatedTests", "تست های مرتبط");

            dictionary.Add("ProductTurningCountB", " رسید محصول قبل دوره");
            dictionary.Add("ProductToTurningCountB", "ارسال به تولید قبل دوره");
            dictionary.Add("ProductTurningCountA", "رسید محصول در دوره");
            dictionary.Add("SendProductToTurningCountA", "ارسال به تولید در دوره");
            dictionary.Add("InventoryCount", "تعداد در جریان ساخت");
            dictionary.Add("xGrp", "گروه");
            dictionary.Add("CountKanban", "تعداد ارسالی طی دوره");
            dictionary.Add("Total", "مجموع");

            dictionary.Add("xYear", "سال");
            dictionary.Add("xMonth", "ماه");
            dictionary.Add("xGrp_", "گروه");
            dictionary.Add("xProductInspectionCount", "تعداد ضایعات");
            dictionary.Add("xFactory_", "مجموع");
            dictionary.Add("CustomerReturn", "برگشتی از مشتری");


            dictionary.Add("BudgetPlanCount", "تعداد فروش در بودجه");
            dictionary.Add("BudgetPlanCountWeight", "کیلوگرم فروش در بودجه");
            dictionary.Add("mSalePlanCountWeight", "کیلوگرم فروش قطعه");
            dictionary.Add("SalePlanSaleType", "نوع فروش");
            dictionary.Add("BudgetPlanPercent", "درصد تحقق بودجه");
            dictionary.Add("SaleCount", "تعداد فروش قطعه");
            dictionary.Add("BudgetPlanPieces", "نام قطعه در بودجه");
            dictionary.Add("SalePlanPieces", "نام قطعه فروخته شده");
            dictionary.Add("xModificationCount", "تعداد اصلاحی");

            dictionary.Add("MaterialReturnCount", "تعداد برگشتی مواد");
            dictionary.Add("MaterialDestructionCount", "تعداد تست تخریب مواد");
            dictionary.Add("xDelivery", "تحویل دهنده");
            dictionary.Add("SendNumberToWareHouse", "تعداد ارسالی به انبار");

            dictionary.Add("xGenDefect_", "نوع ضایعات");
            dictionary.Add("xDefectNumberCause", "تعداد علت ضایعات");
            dictionary.Add("DefectCode", "کد ضایعات");
            dictionary.Add("xDefectListCauseMachining", "علت ضایعات");
            dictionary.Add("xDefectComment", "مورد اصلاحی");
            dictionary.Add("xDefectCause_", "علت اصلاحی");
            dictionary.Add("xDefectListType_", "نوع ضایعات");

            dictionary.Add("xUser_", "نام کاربر");
            dictionary.Add("xGroup_", "نام گروه");
            dictionary.Add("xInsert", "اضافه");
            dictionary.Add("xUpdate", "بروز رسانی");
            dictionary.Add("xDelete", "حذف");
            dictionary.Add("xIsFinish", "پایان");


            dictionary.Add("CorrMoisturePercent", "درصد رطوبت");
            dictionary.Add("CorrPermeability", "عبور گاز");
            dictionary.Add("CorrCompresiveStrength", "استحکام فشاری");
            dictionary.Add("CorrCompactibility", "تراکم پذیری");

            dictionary.Add("x_", "کد سیستم");
            dictionary.Add("xDefectActive", "فعال؟");
            dictionary.Add("xSGCode", "کد همکاران");

            dictionary.Add("xGenTypeChange_", "نوع تغییرات");
            dictionary.Add("xDescriptionOperation", "شرح عملیات");
            dictionary.Add("xReasonChange", "دلیل تغییرات");
            dictionary.Add("xResultChanges", "نتیجه تغییرات");


            dictionary.Add("xGenStatus_", "وضعیت");
            dictionary.Add("xGageName_", "نام ابزار");
            dictionary.Add("xSerialNo", "شماره سریال");
            dictionary.Add("xModel", "مدل");
            dictionary.Add("xAccuracy", "دقت");
            dictionary.Add("xOtherInformation", "اطلاعات دیگر");
            dictionary.Add("xGenScheduleType_", "نوع زمان بندی");
            dictionary.Add("xPeriodDayCalibration", "دوره کالیبراسیون");
            dictionary.Add("xPlaceOfUse", "مکان استفاده");

            dictionary.Add("xInterval", "داخلی");
            dictionary.Add("xCalibrationPlace", "مکان کالیبراسیون");
            dictionary.Add("xDateSupplier", "تاریخ ثبت");
            dictionary.Add("xGenTypeReproduct_", "نوع بازکاری");
            dictionary.Add("xDateConfirm", "تاریخ تایید ");

            dictionary.Add("xGenDay_", "نوع شیفت");
            dictionary.Add("DefectListType", "دسته بندی ضایعات ");

            dictionary.Add("xCodeMold", "کد مدل");
            dictionary.Add("xSupplierCompanyName", "نام شرکت سازنده");
            dictionary.Add("xGenStatusMold_", "وضعیت مدل");
            dictionary.Add("xDateRegister", "تاریخ ثبت");
            dictionary.Add("xGenMoldType_", "نوع ");



            dictionary.Add("xCounter", "شمارش ");
            dictionary.Add("xTotalCounter", "مجموع شمارش ");

            dictionary.Add("xActivities", "شرح اقدامات ");

            //   FireExtinguisher
            dictionary.Add("xGenProductionMethod_", "روش تولید ");
            dictionary.Add("xMoldList_", " کد مدل ");
            dictionary.Add("xShift_", " شیفت ");

            dictionary.Add("xAccept", " تایید ");
            dictionary.Add("xDeny", " رد ");

            dictionary.Add("TolalMoldCount", " مجموع تعداد ضرب ");
            dictionary.Add("LastConfirmMoldCount", " اخرین تعداد ضرب کنترل شده ");

            dictionary.Add("xReShotBlastingCount", " تعداد شات مجدد ");

            dictionary.Add("ShotBlastingInspectionCount", " تعداد ضایعات قبلاز شات ");
            dictionary.Add("ShotBlastingPiceseCount", " تعداد قطعات شات شده ");
            dictionary.Add("ShotBlastingInventory", " نیمه ساخته شات نشده ");

            dictionary.Add("xRegisterDate", " تاریخ ثبت ");
            dictionary.Add("xRegisterTime", "زمان ثبت ");

            
                

            if (dictionary.ContainsKey(StInput))
            {
                string value = dictionary[StInput];
                return value;
            }

            return StInput;
        }
    }
}
