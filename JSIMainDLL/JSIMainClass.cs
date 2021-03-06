﻿/*  Title:          JSI Main Class
 *  Date:           3-12-20
 *  Author:         Terry Holmes
 *  
 *  Description:    This is used for the JSI Main Table */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace JSIMainDLL
{
    public class JSIMainClass
    {
        //setting up the class
        EventLogClass TheEventLogClass = new EventLogClass();

        JSIMainDataSet aJSIMainDataSet;
        JSIMainDataSetTableAdapters.jsimainTableAdapter aJSIMainTableAdapter;

        InsertIntoJSIMainEntryTableAdapters.QueriesTableAdapter aInsertIntoJSIMainTableAdatper;

        FindJSIMainByAssignedProjectIDDataSet aFindJSIMainByAssignedProjectIDDataSet;
        FindJSIMainByAssignedProjectIDDataSetTableAdapters.FindJSIMainByAssignedProjectIDTableAdapter aFindJSIMainByAssignedProjectIDTableAdapter;

        FindJSIMainByManagerIDDataSet aFindJSIMainByManagerIDDataSet;
        FindJSIMainByManagerIDDataSetTableAdapters.FindJSIMainByManagerIDTableAdapter aFindJSIMainByManagerIDTableAdapter;

        FindJSIMainByDateRangeDataSet aFindJSIMainByDateRangeDataSet;
        FindJSIMainByDateRangeDataSetTableAdapters.FindJSIMainByDateRangeTableAdapter aFindJSIMainByDateRangeTableAdapter;

        JSIPPEDataSet aJSIPPEDataSet;
        JSIPPEDataSetTableAdapters.JSIPPETableAdapter aJSIPPETableAdapter;

        InsertJSIPPEEntryTableAdapters.QueriesTableAdapter aInsertJSIPPETableAdatper;

        FindJSIPPEByJSITransactionIDDataSet aFindJSIPPEByJSITransactionIDDataSet;
        FindJSIPPEByJSITransactionIDDataSetTableAdapters.FindJSIPPEByJSITransactionIDTableAdapter aFindJSIPPEByJSITransactionIDTableAdapter;

        JSIVehicleDataSet aJSIVehicleDataSet;
        JSIVehicleDataSetTableAdapters.jsivehicleTableAdapter aJSIVehicleTableAdapter;

        InsertJSIVehicleEntryTableAdapters.QueriesTableAdapter aInsertJSIVehicleTableAdapter;

        FindJSIVehicleByJSITransactionIDDataSet aFindJSIVehicleByJSITransactionIDDataSet;
        FindJSIVehicleByJSITransactionIDDataSetTableAdapters.FindJSIVehicleByJSITransactionIDTableAdapter aFindJSIVehicleByJSITransactionIDTableAdapter;

        FindJSIVehicleByVehicleNumberDataSet aFindJSIVehicleByVehicleNumberDataSet;
        FindJSIVehicleByVehicleNumberDataSetTableAdapters.FindJSIVehicleInformationByVehicleNumberTableAdapter aFindJSIVehicleByVehicleNumberTableAdapter;

        JSILadderInspectionDataSet aJSILadderInspectionDataSet;
        JSILadderInspectionDataSetTableAdapters.jsiladderinspectionTableAdapter aJSILadderInspectionTableAdapter;

        InsertJSILadderInspectionEntryTableAdapters.QueriesTableAdapter aInsertJSILadderInspectionTableAdapter;

        FindJSILadderInspectionByJSITransactionIDDataSet aFindJSILadderInspectionByJSITransactionIDDataSet;
        FindJSILadderInspectionByJSITransactionIDDataSetTableAdapters.FindJSILadderInspectionByJSITransactionIDTableAdapter aFindJSILadderInspectionByJSITransactionIDTableAdapter;

        JSIUniformDataSet aJSIUniformDataSet;
        JSIUniformDataSetTableAdapters.jsiuniformTableAdapter aJSIUniformTableAdapter;

        InsertJSIUniformEntryTableAdapters.QueriesTableAdapter aInsertJSIUniformTableAdapter;

        FindJSIUniformByJSITransactionIDDataSet aFindJSIUniformByJSITransactionIDDataSet;
        FindJSIUniformByJSITransactionIDDataSetTableAdapters.FindJSIUniformByJSITransactionIDTableAdapter aFindJSIUniformByJSITransactionIDTableAdapter;

        JSISiteInspectionDataSet aJSISiteInspectionDataSet;
        JSISiteInspectionDataSetTableAdapters.jsisiteinspectionTableAdapter aJSISiteInspectionTableAdapter;

        InsertJSISiteInspectionEntryTableAdapters.QueriesTableAdapter aInsertJSISiteInspectionTableAdapter;

        FindJSISiteInspectionByJSITransactionIDDataSet aFindJSISiteInspectionByJSITransactionIDDataSet;
        FindJSISiteInspectionByJSITransactionIDDataSetTableAdapters.FindJSISiteInspectionByJSITransactionIDTableAdapter aFindJSISiteInspectionByJSITransactionIDTableAdapter;

        JSIOverallDataSet aJSIOverallDataSet;
        JSIOverallDataSetTableAdapters.jsioverallTableAdapter aJSIOverallTableAdapter;

        InsertJSIOverallEntryTableAdapters.QueriesTableAdapter aInsertJSIOverallTableAdapter;

        FindJSIOverallByJSITransactionIDDataSet aFindJSIOverallByJSITransactionIDDataSet;
        FindJSIOverallByJSITransactionIDDataSetTableAdapters.FindJSIOverallByJSITransactionIDTableAdapter aFindJSIOverallByJSITransactionIDTableAdapter;

        JSIDocumentationDataSet aJSIDocumentationDataSet;
        JSIDocumentationDataSetTableAdapters.jsidocumentationTableAdapter aJSIDocumentationTableAdapter;

        InsertJSIDocumentationEntryTableAdapters.QueriesTableAdapter aInsertJSIDocumentationTableAdapter;

        FindJSIDocumentationByJSITransactionIDDataSet aFindJSIDocumentationByJSITransactionIDDataSet;
        FindJSIDocumentationByJSITransactionIDDataSetTableAdapters.FindJSILadderInspectionByJSITransactionIDTableAdapter aFindJSIDocumentationByJSITransactionIDTableAdapter;

        JSIEmployeeDataSet aJSIEmployeeDataSet;
        JSIEmployeeDataSetTableAdapters.jsiemployeeTableAdapter aJSIEmployeeTableAdapter;

        InsertJSIEmployeeEntryTableAdapters.QueriesTableAdapter aInsertJSIEmployeeTableAdapter;

        FindJSIEmployeeByJSITransactionIDDataSet aFindJSIEmployeeByJSITransactionIDDataSet;
        FindJSIEmployeeByJSITransactionIDDataSetTableAdapters.FindJSIEmployeeByJSITransactionIDTableAdapter aFindJSIEmployeeByJSITransactionIDTableAdapter;

        FindJSIInspectionsByEmployeeDataSet aFindJSIInspectionsByEmployeeDataSet;
        FindJSIInspectionsByEmployeeDataSetTableAdapters.FindJSIInspectionsByEmployeeTableAdapter aFindJSIInspectionsByEmployeeTableAdapter;

        FindJSIMainByDateMatchDataSet aFindJSIMainByDateMatchDataSet;
        FindJSIMainByDateMatchDataSetTableAdapters.FindJSIMainByDateMatchTableAdapter aFindJSIMainByDateMatchTableAdapter;

        public FindJSIMainByDateMatchDataSet FindJSIMainByDateMatch(DateTime datTransactionDate)
        {
            try
            {
                aFindJSIMainByDateMatchDataSet = new FindJSIMainByDateMatchDataSet();
                aFindJSIMainByDateMatchTableAdapter = new FindJSIMainByDateMatchDataSetTableAdapters.FindJSIMainByDateMatchTableAdapter();
                aFindJSIMainByDateMatchTableAdapter.Fill(aFindJSIMainByDateMatchDataSet.FindJSIMainByDateMatch, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Find JSI Main By Date Match " + Ex.Message);
            }

            return aFindJSIMainByDateMatchDataSet;
        }
        public FindJSIInspectionsByEmployeeDataSet FindJSIInspectionsByEmployee(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindJSIInspectionsByEmployeeDataSet = new FindJSIInspectionsByEmployeeDataSet();
                aFindJSIInspectionsByEmployeeTableAdapter = new FindJSIInspectionsByEmployeeDataSetTableAdapters.FindJSIInspectionsByEmployeeTableAdapter();
                aFindJSIInspectionsByEmployeeTableAdapter.Fill(aFindJSIInspectionsByEmployeeDataSet.FindJSIInspectionsByEmployee, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Find JSI Inspection By Employee " + Ex.Message);
            }

            return aFindJSIInspectionsByEmployeeDataSet;
        }
        public FindJSIEmployeeByJSITransactionIDDataSet FindJSIEmployeeByJSITransactionID(int intJSITransactionID)
        {
            try
            {
                aFindJSIEmployeeByJSITransactionIDDataSet = new FindJSIEmployeeByJSITransactionIDDataSet();
                aFindJSIEmployeeByJSITransactionIDTableAdapter = new FindJSIEmployeeByJSITransactionIDDataSetTableAdapters.FindJSIEmployeeByJSITransactionIDTableAdapter();
                aFindJSIEmployeeByJSITransactionIDTableAdapter.Fill(aFindJSIEmployeeByJSITransactionIDDataSet.FindJSIEmployeeByJSITransactionID, intJSITransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Find JSI Employee by JSI Transaction ID " + Ex.Message);
            }

            return aFindJSIEmployeeByJSITransactionIDDataSet;
        }
        public bool InsertJSIEmployee(int intJSITransactionID, int intEmployeeID, DateTime datTransactionDate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertJSIEmployeeTableAdapter = new InsertJSIEmployeeEntryTableAdapters.QueriesTableAdapter();
                aInsertJSIEmployeeTableAdapter.InsertJSIEmployee(intJSITransactionID, intEmployeeID, datTransactionDate);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Insert JSI Employee " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public JSIEmployeeDataSet GetJSIEmployeeInfo()
        {
            try
            {
                aJSIEmployeeDataSet = new JSIEmployeeDataSet();
                aJSIEmployeeTableAdapter = new JSIEmployeeDataSetTableAdapters.jsiemployeeTableAdapter();
                aJSIEmployeeTableAdapter.Fill(aJSIEmployeeDataSet.jsiemployee);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Get JSI Employee Info " + Ex.Message);
            }

            return aJSIEmployeeDataSet;
        }
        public void UpdateJSIEmployeeDB(JSIEmployeeDataSet aJSIEmployeeDataSet)
        {
            try
            {
                aJSIEmployeeTableAdapter = new JSIEmployeeDataSetTableAdapters.jsiemployeeTableAdapter();
                aJSIEmployeeTableAdapter.Update(aJSIEmployeeDataSet.jsiemployee);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Update JSI Employee DB " + Ex.Message);
            }
        }
        public FindJSIDocumentationByJSITransactionIDDataSet FindJSIDocumenationByJSITransactionID(int intJSITransactionID)
        {
            try
            {
                aFindJSIDocumentationByJSITransactionIDDataSet = new FindJSIDocumentationByJSITransactionIDDataSet();
                aFindJSIDocumentationByJSITransactionIDTableAdapter = new FindJSIDocumentationByJSITransactionIDDataSetTableAdapters.FindJSILadderInspectionByJSITransactionIDTableAdapter();
                aFindJSIDocumentationByJSITransactionIDTableAdapter.Fill(aFindJSIDocumentationByJSITransactionIDDataSet.FindJSILadderInspectionByJSITransactionID, intJSITransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Find JSI Documentation By JSI Transaction ID " + Ex.Message);
            }

            return aFindJSIDocumentationByJSITransactionIDDataSet;
        }
        public bool InsertJSIDocumentation(int intJSITransactionID, DateTime datTransactionDate, int intEmployeeID, string strDocumentPath, string strDocumentNotes)
        {
            bool blnFatqlError = false;

            try
            {
                aInsertJSIDocumentationTableAdapter = new InsertJSIDocumentationEntryTableAdapters.QueriesTableAdapter();
                aInsertJSIDocumentationTableAdapter.InsertJSIDocumentation(intJSITransactionID, datTransactionDate, intEmployeeID, strDocumentPath, strDocumentNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Insert JSI Documentation " + Ex.Message);

                blnFatqlError = true;
            }

            return blnFatqlError;
        }
        public JSIDocumentationDataSet GetJSIDocumentationInfo()
        {
            try
            {
                aJSIDocumentationDataSet = new JSIDocumentationDataSet();
                aJSIDocumentationTableAdapter = new JSIDocumentationDataSetTableAdapters.jsidocumentationTableAdapter();
                aJSIDocumentationTableAdapter.Fill(aJSIDocumentationDataSet.jsidocumentation);
            }
            catch (Exception ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Get JSI Documentation Info " + ex.Message);
            }

            return aJSIDocumentationDataSet;
        }
        public void UpdateJSIDocumentationDB(JSIDocumentationDataSet aJSIDocumentationDataSet)
        {
            try
            {                
                aJSIDocumentationTableAdapter = new JSIDocumentationDataSetTableAdapters.jsidocumentationTableAdapter();
                aJSIDocumentationTableAdapter.Update(aJSIDocumentationDataSet.jsidocumentation);
            }
            catch (Exception ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Update JSI Documentation DB " + ex.Message);
            }
        }
        public FindJSIOverallByJSITransactionIDDataSet FindJSIOverallByJSITransactionID(int intJSITransactionID)
        {
            try
            {
                aFindJSIOverallByJSITransactionIDDataSet = new FindJSIOverallByJSITransactionIDDataSet();
                aFindJSIOverallByJSITransactionIDTableAdapter = new FindJSIOverallByJSITransactionIDDataSetTableAdapters.FindJSIOverallByJSITransactionIDTableAdapter();
                aFindJSIOverallByJSITransactionIDTableAdapter.Fill(aFindJSIOverallByJSITransactionIDDataSet.FindJSIOverallByJSITransactionID, intJSITransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Find JSI Overall By JSI Transaction ID " + Ex.Message);
            }

            return aFindJSIOverallByJSITransactionIDDataSet;
        }
        public bool InsertJSIOverall(int intJSITransactionID, string strOverallInspection, bool blnSafetyConcerns, int intInspectingEmployeeID, DateTime datInspectingDate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertJSIOverallTableAdapter = new InsertJSIOverallEntryTableAdapters.QueriesTableAdapter();
                aInsertJSIOverallTableAdapter.InsertJSIOverall(intJSITransactionID, strOverallInspection, blnSafetyConcerns, intInspectingEmployeeID, datInspectingDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Insert JSI Overall " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public JSIOverallDataSet GetJSIOverallInfo()
        {
            try
            {
                aJSIOverallDataSet = new JSIOverallDataSet();
                aJSIOverallTableAdapter = new JSIOverallDataSetTableAdapters.jsioverallTableAdapter();
                aJSIOverallTableAdapter.Fill(aJSIOverallDataSet.jsioverall);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Get JSI Overall Info " + Ex.Message);
            }

            return aJSIOverallDataSet;
        }
        public void UpdateJSIOverallDB(JSIOverallDataSet aJSIOverallDataSet)
        {
            try
            {
                aJSIOverallTableAdapter = new JSIOverallDataSetTableAdapters.jsioverallTableAdapter();
                aJSIOverallTableAdapter.Update(aJSIOverallDataSet.jsioverall);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Update JSI Overall DB " + Ex.Message);
            }
        }
        public FindJSISiteInspectionByJSITransactionIDDataSet FindJSISiteInspectionByJSITransactionID(int intJSITransactionID)
        {
            try
            {
                aFindJSISiteInspectionByJSITransactionIDDataSet = new FindJSISiteInspectionByJSITransactionIDDataSet();
                aFindJSISiteInspectionByJSITransactionIDTableAdapter = new FindJSISiteInspectionByJSITransactionIDDataSetTableAdapters.FindJSISiteInspectionByJSITransactionIDTableAdapter();
                aFindJSISiteInspectionByJSITransactionIDTableAdapter.Fill(aFindJSISiteInspectionByJSITransactionIDDataSet.FindJSISiteInspectionByJSITransactionID, intJSITransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Find JSI Site Inspection By JSI Transaction ID " + Ex.Message);
            }

            return aFindJSISiteInspectionByJSITransactionIDDataSet;
        }
        public bool InsertJSISiteInspection(int intJSITransactionID, string strTrafficCones, string strOnSiteFlagger, string strJSACompleted, string strTrafficSigns)
        {
            bool blnFatalError = false;

            try
            {
                aInsertJSISiteInspectionTableAdapter = new InsertJSISiteInspectionEntryTableAdapters.QueriesTableAdapter();
                aInsertJSISiteInspectionTableAdapter.InsertJSISiteInspection(intJSITransactionID, strTrafficCones, strOnSiteFlagger, strJSACompleted, strTrafficSigns);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Insert JSI Site Inspection " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public JSISiteInspectionDataSet GetJSISiteInspectionInfo()
        {
            try
            {
                aJSISiteInspectionDataSet = new JSISiteInspectionDataSet();
                aJSISiteInspectionTableAdapter = new JSISiteInspectionDataSetTableAdapters.jsisiteinspectionTableAdapter();
                aJSISiteInspectionTableAdapter.Fill(aJSISiteInspectionDataSet.jsisiteinspection);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Get JSI Site Inspection Info " + Ex.Message);
            }

            return aJSISiteInspectionDataSet;
        }
        public void UpdateJSISiteInspectionDB(JSISiteInspectionDataSet aJSISiteInspectionDataSet)
        {
            try
            {
                aJSISiteInspectionTableAdapter = new JSISiteInspectionDataSetTableAdapters.jsisiteinspectionTableAdapter();
                aJSISiteInspectionTableAdapter.Update(aJSISiteInspectionDataSet.jsisiteinspection);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Update JSI Site Inspection DB " + Ex.Message);
            }
        }
        public FindJSIUniformByJSITransactionIDDataSet FindJSIUniformByJSITransactionID(int intJSITransactionID)
        {
            try
            {
                aFindJSIUniformByJSITransactionIDDataSet = new FindJSIUniformByJSITransactionIDDataSet();
                aFindJSIUniformByJSITransactionIDTableAdapter = new FindJSIUniformByJSITransactionIDDataSetTableAdapters.FindJSIUniformByJSITransactionIDTableAdapter();
                aFindJSIUniformByJSITransactionIDTableAdapter.Fill(aFindJSIUniformByJSITransactionIDDataSet.FindJSIUniformByJSITransactionID, intJSITransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Find JSI Uniform By JSI Transaction ID " + Ex.Message);
            }

            return aFindJSIUniformByJSITransactionIDDataSet;
        }
        public bool InsertJSIUniform(int intJSITransactionID, bool blnCompanyProvidedUniform, bool blnValidDriversLicense, bool blnBlueJayLogo, bool blnIDBadge)
        {
            bool blnFatalError = false;

            try
            {
                aInsertJSIUniformTableAdapter = new InsertJSIUniformEntryTableAdapters.QueriesTableAdapter();
                aInsertJSIUniformTableAdapter.InsertJSIUniform(intJSITransactionID, blnCompanyProvidedUniform, blnValidDriversLicense, blnBlueJayLogo, blnIDBadge);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Insert JSI Uniform " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public JSIUniformDataSet GetJSIUniformInfo()
        {
            try
            {
                aJSIUniformDataSet = new JSIUniformDataSet();
                aJSIUniformTableAdapter = new JSIUniformDataSetTableAdapters.jsiuniformTableAdapter();
                aJSIUniformTableAdapter.Fill(aJSIUniformDataSet.jsiuniform);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Get JSI Uniform Info " + Ex.Message);
            }

            return aJSIUniformDataSet;
        }
        public void UpdateJSIUniformDB(JSIUniformDataSet aJSIUniformDataSet)
        {
            try
            {
                aJSIUniformTableAdapter = new JSIUniformDataSetTableAdapters.jsiuniformTableAdapter();
                aJSIUniformTableAdapter.Update(aJSIUniformDataSet.jsiuniform);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Update JSI Uniform DB " + Ex.Message);
            }
        }
        public FindJSILadderInspectionByJSITransactionIDDataSet FindJSILadderInspectionByJSITransactionID(int intJSITransactionID)
        {
            try
            {
                aFindJSILadderInspectionByJSITransactionIDDataSet = new FindJSILadderInspectionByJSITransactionIDDataSet();
                aFindJSILadderInspectionByJSITransactionIDTableAdapter = new FindJSILadderInspectionByJSITransactionIDDataSetTableAdapters.FindJSILadderInspectionByJSITransactionIDTableAdapter();
                aFindJSILadderInspectionByJSITransactionIDTableAdapter.Fill(aFindJSILadderInspectionByJSITransactionIDDataSet.FindJSILadderInspectionByJSITransactionID, intJSITransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Find JSI Ladder Inspection By JSI Transaction ID " + Ex.Message);
            }

            return aFindJSILadderInspectionByJSITransactionIDDataSet;
        }
        public bool InsertJSILadderInspection(int intJSITransactionID, string strExtensionLadder, string strSmallerLadder, string strDutyRatingStickers, string strCompanyLadders, string strLadderRackLocks)
        {
            bool blnFatalError = false;

            try
            {
                aInsertJSILadderInspectionTableAdapter = new InsertJSILadderInspectionEntryTableAdapters.QueriesTableAdapter();
                aInsertJSILadderInspectionTableAdapter.InsertJSILadderInspection(intJSITransactionID, strExtensionLadder, strSmallerLadder, strDutyRatingStickers, strCompanyLadders, strLadderRackLocks);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Insert JSI Ladder Inspection " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public JSILadderInspectionDataSet GetJSILadderInspectionInfo()
        {
            try
            {
                aJSILadderInspectionDataSet = new JSILadderInspectionDataSet();
                aJSILadderInspectionTableAdapter = new JSILadderInspectionDataSetTableAdapters.jsiladderinspectionTableAdapter();
                aJSILadderInspectionTableAdapter.Fill(aJSILadderInspectionDataSet.jsiladderinspection);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Get JSI Ladder Inspection Info " + Ex.Message);
            }

            return aJSILadderInspectionDataSet;
        }
        public void UpdateJSILadderInspectionDB(JSILadderInspectionDataSet aJSILadderInspectionDataSet)
        {
            try
            {
                aJSILadderInspectionTableAdapter = new JSILadderInspectionDataSetTableAdapters.jsiladderinspectionTableAdapter();
                aJSILadderInspectionTableAdapter.Update(aJSILadderInspectionDataSet.jsiladderinspection);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Update JSI Ladder Inspection DB " + Ex.Message);
            }
        }
        public FindJSIVehicleByVehicleNumberDataSet FindJSVehicleByVehicleNumber(string strVehicleNumber, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindJSIVehicleByVehicleNumberDataSet = new FindJSIVehicleByVehicleNumberDataSet();
                aFindJSIVehicleByVehicleNumberTableAdapter = new FindJSIVehicleByVehicleNumberDataSetTableAdapters.FindJSIVehicleInformationByVehicleNumberTableAdapter();
                aFindJSIVehicleByVehicleNumberTableAdapter.Fill(aFindJSIVehicleByVehicleNumberDataSet.FindJSIVehicleInformationByVehicleNumber, strVehicleNumber, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Find JSI Vehicle By Vehicle Number " + Ex.Message);
            }

            return aFindJSIVehicleByVehicleNumberDataSet;
        }
        public FindJSIVehicleByJSITransactionIDDataSet FindJSIVehicleByJSITransactionID(int intJSITransactionID)
        {
            try
            {
                aFindJSIVehicleByJSITransactionIDDataSet = new FindJSIVehicleByJSITransactionIDDataSet();
                aFindJSIVehicleByJSITransactionIDTableAdapter = new FindJSIVehicleByJSITransactionIDDataSetTableAdapters.FindJSIVehicleByJSITransactionIDTableAdapter();
                aFindJSIVehicleByJSITransactionIDTableAdapter.Fill(aFindJSIVehicleByJSITransactionIDDataSet.FindJSIVehicleByJSITransactionID, intJSITransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Find JSI Vehicle By Transaction ID " + Ex.Message);
            }

            return aFindJSIVehicleByJSITransactionIDDataSet;
        }
        public bool InsertJSIVehicle(int intJSITransactionID, bool blnMagnets, bool blnVehicleCleanliness, bool blnVehicleSecurie, bool blnSafetyMaintenanceIssues, bool blnFireExtingisherfirstAidKit, int intVehicleID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertJSIVehicleTableAdapter = new InsertJSIVehicleEntryTableAdapters.QueriesTableAdapter();
                aInsertJSIVehicleTableAdapter.InsertJSIVehicle(intJSITransactionID, blnMagnets, blnVehicleCleanliness, blnVehicleSecurie, blnSafetyMaintenanceIssues, blnFireExtingisherfirstAidKit, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Insert JSI Vehicle " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public JSIVehicleDataSet GetJSIVehicleInfo()
        {
            try
            {
                aJSIVehicleDataSet = new JSIVehicleDataSet();
                aJSIVehicleTableAdapter = new JSIVehicleDataSetTableAdapters.jsivehicleTableAdapter();
                aJSIVehicleTableAdapter.Fill(aJSIVehicleDataSet.jsivehicle);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Get JSI Vehicle Info " + Ex.Message);
            }

            return aJSIVehicleDataSet;
        }
        public void UpdateJSIVehicleDB(JSIVehicleDataSet aJSIVehicleDataSet)
        {
            try
            {
                aJSIVehicleTableAdapter = new JSIVehicleDataSetTableAdapters.jsivehicleTableAdapter();
                aJSIVehicleTableAdapter.Update(aJSIVehicleDataSet.jsivehicle);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Update JSI Vehicle DB " + Ex.Message);
            }
        }
        public FindJSIPPEByJSITransactionIDDataSet FindJSIPPEByJSITransactionID(int intJSITransactionID)
        {
            try
            {
                aFindJSIPPEByJSITransactionIDDataSet = new FindJSIPPEByJSITransactionIDDataSet();
                aFindJSIPPEByJSITransactionIDTableAdapter = new FindJSIPPEByJSITransactionIDDataSetTableAdapters.FindJSIPPEByJSITransactionIDTableAdapter();
                aFindJSIPPEByJSITransactionIDTableAdapter.Fill(aFindJSIPPEByJSITransactionIDDataSet.FindJSIPPEByJSITransactionID, intJSITransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Find JSI PPE By JSI Transaction ID " + Ex.Message);
            }

            return aFindJSIPPEByJSITransactionIDDataSet;
        }
        public bool InsertJSIPPE(int intJSITransactionID, string strSafetyVest, string strSafetyGlassGloves, string strSafetyFootGear, string strFallProtection, string strHardHat)
        {
            bool blnFatalError = false;

            try
            {
                aInsertJSIPPETableAdatper = new InsertJSIPPEEntryTableAdapters.QueriesTableAdapter();
                aInsertJSIPPETableAdatper.InsertJSIPPE(intJSITransactionID, strSafetyVest, strSafetyGlassGloves, strSafetyFootGear, strFallProtection, strHardHat);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Insert JSI PPE " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public JSIPPEDataSet GetJSIPPEInfo()
        {
            try
            {
                aJSIPPEDataSet = new JSIPPEDataSet();
                aJSIPPETableAdapter = new JSIPPEDataSetTableAdapters.JSIPPETableAdapter();
                aJSIPPETableAdapter.Fill(aJSIPPEDataSet.JSIPPE);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Get JSIPPE Info " + Ex.Message);
            }

            return aJSIPPEDataSet;
        }
        public void UpdateJSIPPEDB(JSIPPEDataSet aJSIPPEDataSet)
        {
            try
            {                aJSIPPEDataSet = new JSIPPEDataSet();
                aJSIPPETableAdapter = new JSIPPEDataSetTableAdapters.JSIPPETableAdapter();
                aJSIPPETableAdapter.Update(aJSIPPEDataSet.JSIPPE);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Get JSIPPE Info " + Ex.Message);
            }
        }
        public FindJSIMainByDateRangeDataSet FindJSIMainByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindJSIMainByDateRangeDataSet = new FindJSIMainByDateRangeDataSet();
                aFindJSIMainByDateRangeTableAdapter = new FindJSIMainByDateRangeDataSetTableAdapters.FindJSIMainByDateRangeTableAdapter();
                aFindJSIMainByDateRangeTableAdapter.Fill(aFindJSIMainByDateRangeDataSet.FindJSIMainByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Find JSI Main By Date Range " + Ex.Message);
            }

            return aFindJSIMainByDateRangeDataSet;
        }
        public FindJSIMainByManagerIDDataSet FindJSIMainByMangerID(int intManagerID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindJSIMainByManagerIDDataSet = new FindJSIMainByManagerIDDataSet();
                aFindJSIMainByManagerIDTableAdapter = new FindJSIMainByManagerIDDataSetTableAdapters.FindJSIMainByManagerIDTableAdapter();
                aFindJSIMainByManagerIDTableAdapter.Fill(aFindJSIMainByManagerIDDataSet.FindJSIMainByManagerID, intManagerID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // /Find JSI Main By Manager ID " + Ex.Message);
            }

            return aFindJSIMainByManagerIDDataSet;
        }
        public FindJSIMainByAssignedProjectIDDataSet FindJSIMainByAssignedProjectID(int intProjectID)
        {
            try
            {
                aFindJSIMainByAssignedProjectIDDataSet = new FindJSIMainByAssignedProjectIDDataSet();
                aFindJSIMainByAssignedProjectIDTableAdapter = new FindJSIMainByAssignedProjectIDDataSetTableAdapters.FindJSIMainByAssignedProjectIDTableAdapter();
                aFindJSIMainByAssignedProjectIDTableAdapter.Fill(aFindJSIMainByAssignedProjectIDDataSet.FindJSIMainByAssignedProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Find JSI Main By Assigned Project ID " + Ex.Message);
            }

            return aFindJSIMainByAssignedProjectIDDataSet;
        }
        public bool InsertIntoJSIMain(DateTime datTransactionDate, int intProjectID, int intEmployeeID, int intDepartmentID, int intVehicleID, DateTime datInspectionDate, int intManagerID, int intDataEntryEmployeeID, int intInspectingEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertIntoJSIMainTableAdatper = new InsertIntoJSIMainEntryTableAdapters.QueriesTableAdapter();
                aInsertIntoJSIMainTableAdatper.InsertIntoJSIMain(datTransactionDate, intProjectID, intEmployeeID, intDepartmentID, intVehicleID, datInspectionDate, intManagerID, intDataEntryEmployeeID, intInspectingEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Insert Into JSI Main " + Ex.Message);
            }

            return blnFatalError;
        }
        public JSIMainDataSet GetJSIMainInfo()
        {
            try
            {
                aJSIMainDataSet = new JSIMainDataSet();
                aJSIMainTableAdapter = new JSIMainDataSetTableAdapters.jsimainTableAdapter();
                aJSIMainTableAdapter.Fill(aJSIMainDataSet.jsimain);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Get JSI Main Info " + Ex.Message);
            }

            return aJSIMainDataSet;
        }
        public void UpdateJSIMainDB(JSIMainDataSet aJSIMainDataSet)
        {
            try
            {
                aJSIMainTableAdapter = new JSIMainDataSetTableAdapters.jsimainTableAdapter();
                aJSIMainTableAdapter.Update(aJSIMainDataSet.jsimain);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "JSI Main Class // Update JSI Main DB " + Ex.Message);
            }
        }
    }
}
