using System;
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
        public void setHardCodeTemplates()
        {
            templateList.Add(getTemplate1());
            templateList.Add(getTemplate2());
            templateList.Add(getTemplate3());
        }

        // returns the list of templates
        public List<TemplateItem> getTemplateList()
        {
            return templateList;
        }

        // Returns Template #1
        private TemplateItem getTemplate1()
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
        private TemplateItem getTemplate2()
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
        private TemplateItem getTemplate3()
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
    }
}
