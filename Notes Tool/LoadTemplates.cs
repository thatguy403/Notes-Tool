﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Tool
{
    /*************************************************************
     * Class: LoadTemplate
     * Description:
     *  Loads a list of templates items for use on the main 
     *  program.
     * Future possible additions:
     *  - loading from file
     *************************************************************/
    class LoadTemplates
    {
        List<TemplateItem> templateList;    // List of templates

        // Initilizes the template list
        public void init()
        {
            templateList = new List<TemplateItem>();
        }

        // returns the list of templates
        public List<TemplateItem> getTemplateList()
        {
            return templateList;
        }

        #region Sample Test Templates

        // Add a test set of templates to the list
        public void setTestSample1()
        {
            TemplateItem temp1 = new TemplateItem();
            temp1.init();
            temp1.setTitle("Title 1");
            temp1.setTemplate("Template1");
            templateList.Add(temp1);

            TemplateItem temp2 = new TemplateItem();
            temp2.setTitle("Title 2");
            temp2.setTemplate("Template 2");
            templateList.Add(temp2);
        }

        // Adds a set of hard coded templates to the list
        public void setTestSample2()
        {
            templateList.Add(getTestTemplate1());
            templateList.Add(getTestTemplate2());
            templateList.Add(getTestTemplate3());
        }

        // Returns Template #1
        private TemplateItem getTestTemplate1()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("Template #1");
            template.setTemplate("Template #1 Line 1" + Environment.NewLine
                                 + "Template #1 Line 2" + Environment.NewLine
                                 + "Template #1 Line 3");

            return template;
        }

        // Returns Template #2
        private TemplateItem getTestTemplate2()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("Template #2");
            template.setTemplate("Template #2 Line 1" + Environment.NewLine 
                                 + "Template #2 Line 2" + Environment.NewLine
                                 + "Template #2 Line 3" + Environment.NewLine
                                 + "Template #2 Line 4");

            return template;
        }

        // Returns Template #3
        private TemplateItem getTestTemplate3()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("Template #3");
            template.setTemplate("Template #3 Line 1" + Environment.NewLine
                                 + "Template #3 Line 2" + Environment.NewLine
                                 + "Template #3 Line 3" + Environment.NewLine
                                 + "Template #3 Line 4" + Environment.NewLine
                                 + "Template #3 Line 5");

            return template;
        }
        #endregion

        #region Assure Templates

        // Adds a set of hard coded assure agent templates to the list
        public void setAssureTemplates()
        {
            // Main header
            templateList.Add(getAssureHeader());

            // Workflow Section
            //templateList.Add(getTitleWorkflow());

            // Tests Section
            templateList.Add(getTitleTests());
            templateList.Add(getGeneralChecks());
            templateList.Add(getEquipmentChecks());
            templateList.Add(getInsSpeed());
            templateList.Add(getSpeedTest());
            templateList.Add(getTSTV());

            // Closings Section
            templateList.Add(getTitleClosing());
            templateList.Add(getOpenClose());
            templateList.Add(getFollowUp());
            templateList.Add(getDispatch());

            //Other Section
            templateList.Add(getTitleOther());
            templateList.Add(getDispatchNotes());
        }

        // Returns Assure Service 2.0 Header
        private TemplateItem getAssureHeader()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("Service 2.0 Header");
            template.setTemplate("Spoke with/@: " + Environment.NewLine
                                 + "Verified by: " + Environment.NewLine
                                 + "CBR1: " + Environment.NewLine
                                 + "CBR2: " + Environment.NewLine                                 
                                 + "Case #: " + Environment.NewLine
                                 + "Customer issue: " + Environment.NewLine
                                 + "Issue since: " + Environment.NewLine
                                 + "Insight Workflow used: ");

            return template;
        }

        #region -- Workflow --

        // Returns Section title for workflow
        private TemplateItem getTitleWorkflow()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("-- Workflow --");
            template.setTemplate("");

            return template;
        }

        #region Voice workflows

        #endregion

        #region IPTV workflows

        #endregion

        #region Broadband workflows

        #endregion

        #region Satellite workflows

        #endregion

        #endregion

        #region -- Tests --

        // Returns Section title for workflow
        private TemplateItem getTitleTests()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("-- Troubleshooting Tests --");
            template.setTemplate("");

            return template;
        }

        // Returns General Checks
        private TemplateItem getGeneralChecks()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("General Checks");
            template.setTemplate("Outage: Y/N  Suspension: Y/N  Pending Orders: Y/N");

            return template;
        }

        // Returns Gateway/STB Checks
        private TemplateItem getEquipmentChecks()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("Equipment Checks");
            template.setTemplate("Device model: " + Environment.NewLine
                                 + "- Lights on: " + Environment.NewLine
                                 + "- Cables attached: " + Environment.NewLine
                                 + "- Rebooted: Y/N");

            return template;
        }

        // Returns Insight Speed Checks
        private TemplateItem getInsSpeed()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("Insight Speed Checks");
            template.setTemplate("Insight shows: " + Environment.NewLine
                                 + "- Current Train Rate: " + Environment.NewLine
                                 + "- Attainable rates: " + Environment.NewLine
                                 + "- Line attenuation: " + Environment.NewLine
                                 + "- Theoretical dB loss: " + Environment.NewLine
                                 + "- SNR margin: " + Environment.NewLine
                                 + "- QoS: ");

            return template;
        }

        // Returns Speed Test
        private TemplateItem getSpeedTest()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("Speed Test");
            template.setTemplate("- Device: , Wired: Y/N, Ping: , DL: , UL: ");

            return template;
        }

        // Returns Satellite template
        private TemplateItem getTSTV()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("TSTV");
            template.setTemplate("*** TSTV ****" + Environment.NewLine
                                 + "CNTCT: Must include contact name, contact times (Contact Number needs to be entered into CBR Field) " + Environment.NewLine
                                 + "CSG ACCOUNT #: Satellite TV from DT1 / Account in MultiVu " + Environment.NewLine
                                 + "RECEIVERS: Number and type of Receivers " + Environment.NewLine
                                 + "# AFFECTED: Number of receivers affected, or ALL " + Environment.NewLine
                                 + "SWITCH TYPE: " + Environment.NewLine
                                 + "CMNTS:  " + Environment.NewLine
                                 + "Signal Strength" + Environment.NewLine
                                 + "SAT 91" + Environment.NewLine
                                 + "Transponder" + Environment.NewLine
                                 + "1= " + Environment.NewLine
                                 + "13= " + Environment.NewLine
                                 + "32= " + Environment.NewLine
                                 + "SAT 82" + Environment.NewLine
                                 + "Transponder" + Environment.NewLine
                                 + "1= " + Environment.NewLine
                                 + "13= " + Environment.NewLine
                                 + "32= ");

            return template;
        }

        #endregion

        #region -- Ticket Closings --

        // Returns Section title for Closings
        private TemplateItem getTitleClosing()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("-- Ticket Closing --");
            template.setTemplate("");

            return template;
        }

        // Returns Open/Close
        private TemplateItem getOpenClose()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("Open/Close");
            template.setTemplate("Issue Resolved: Y/N" + Environment.NewLine
                                 + "Recap: Y/N" + Environment.NewLine
                                 + "Other issues: ");

            return template;
        }

        // Returns Follow Up
        private TemplateItem getFollowUp()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("Follow Up");
            template.setTemplate("Follow up /w cx is required" + Environment.NewLine
                                 + "Issue Resolved: Y/N" + Environment.NewLine
                                 + "Recap: Y/N" + Environment.NewLine
                                 + "Follow up reason: " + Environment.NewLine
                                 + "Follow up date: ");

            return template;
        }

        // Returns Dispatch
        private TemplateItem getDispatch()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("Dispatch");
            template.setTemplate("Dispatch reason: " + Environment.NewLine
                                 + "Verified Address: Y/N" + Environment.NewLine
                                 + "Verified CBR: Y/N" + Environment.NewLine
                                 + "Booking dispatch" + Environment.NewLine
                                 + "AOPC: Y/N");

            return template;
        }

        #endregion

        #region -- Other --

        // Returns Section title for Other
        private TemplateItem getTitleOther()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("-- Other --");
            template.setTemplate("");

            return template;
        }

        // Returns Speed Test
        private TemplateItem getDispatchNotes()
        {
            TemplateItem template = new TemplateItem();
            template.init();
            template.setTitle("S2.0 Dispatch Notes");
            template.setTemplate("**Service 2.0**"
                                 + "" + Environment.NewLine
                                 + "Spoke with/@: " + Environment.NewLine
                                 + "Case #: " + Environment.NewLine
                                 + "Owner/ID: " + Environment.NewLine
                                 + "CSD toll-free number: 18559109009" + Environment.NewLine
                                 + "Special Instructions: ");

            return template;
        }

        #endregion

        #endregion

    }
}
