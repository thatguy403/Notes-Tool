using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Tool
{
    /*************************************************************
     * Class: TemplateItem
     * Description:
     *  Used to store the title and the actual template for use
     *  in a list.
     *************************************************************/
    class TemplateItem
    {
        private String title;       // Title of the template
        private String template;    // Template body

        // initilize elements
        public void init()
        {
            title = "";
            template = "";
        }

        // Set template title
        public void setTitle(String aTitle) { title = aTitle; }

        // Get template title
        public String getTitle() { return title; }

        // Set template
        public void setTemplate(String aTemplate) { template = aTemplate; }

        // Get template
        public String getTemplate() { return template; }

    }
}
