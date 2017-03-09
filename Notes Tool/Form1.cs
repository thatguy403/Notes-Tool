using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes_Tool
{
    public partial class f_NotesMain : Form
    {
        List<TemplateItem> templateList;

        public f_NotesMain()
        {
            InitializeComponent();
        }

        // Initilize items
        private void f_NotesMain_Load(object sender, EventArgs e)
        {
            // Populate the cb_TemplateList
            load_cbTemplateList();
            // Load first template into the notes
            tb_Notes.Text += loadTemplate(0);

            /*
            // Main header template loaded if available. Note: should always be the first in the list
            if (templateList.Count > 0) {
                tb_Notes.Text = templateList.ElementAt(0).getTemplate();
            }
            */
        }

        // loads the list of templates into cb_TemplateList
        private void load_cbTemplateList()
        {
            LoadTemplates loaded = new LoadTemplates();
            loaded.init();
            //loaded.setTestSample1();
            loaded.setHardCodeTemplates();
            templateList = loaded.getTemplateList();

            // Loads each of the titles in the template list into cb_TemplateList
            for(int i=0; i < templateList.Count; i++)
            {
                cb_TemplateList.Items.Add(templateList.ElementAt(i).getTitle());
            }
        }

        private String loadTemplate(int index)
        {
            if (templateList.Count > 0)
            {
                return templateList.ElementAt(index).getTemplate();
            }
            else {
                return "Error: List of templates is not loaded.";
            }
        }

        // Click action for Add button
        private void b_Add_Click(object sender, EventArgs e)
        {
            if (cb_TemplateList.SelectedIndex >= 0)
            {
                tb_Notes.Text += Environment.NewLine + loadTemplate(cb_TemplateList.SelectedIndex);
                    //templateList.ElementAt(cb_TemplateList.SelectedIndex).getTemplate();
            }
            else
            {
                MessageBox.Show("Please select a template to add.",
                                "Error!", MessageBoxButtons.OK);
            }
            
        }

        // Click action for Copy button
        private void b_Copy_Click(object sender, EventArgs e)
        {
            // Takes all text in the Notes section and coipes it to
            // the clipboard so the user can paste it where it is needed
            Clipboard.SetText(tb_Notes.Text);
        }

        // Click action for the Clear button
        private void b_Clear_Click(object sender, EventArgs e)
        {
            // Checks with the user if they are sure they want to clear the Notes section
            var confirmResult = MessageBox.Show("Are you sure you want to clear all notes?" + Environment.NewLine
                                                + "This action cannot be undone.",
                                                "Confirm Clear",
                                                MessageBoxButtons.YesNo);
            // If user confirms the clear action
            if (confirmResult == DialogResult.Yes)
            {
                // Clears the Notes section
                tb_Notes.Clear();
            }
            // else do nothing
            else {}
        }

        // Click action for Reset button
        private void b_Reset_Click(object sender, EventArgs e)
        {
            // Checks with the user if they are sure they want to clear the Notes section
            var confirmResult = MessageBox.Show("Are you sure you want to reset all notes?" + Environment.NewLine
                                                + "This action cannot be undone.",
                                                "Confirm Clear",
                                                MessageBoxButtons.YesNo);
            // If user confirms the clear action
            if (confirmResult == DialogResult.Yes)
            {
                // Clears the Notes section
                tb_Notes.Clear();
                // Adds initial template
                tb_Notes.Text = loadTemplate(0);
            }
            // else do nothing
            else { }
            
        }

        // Menu item File > Exit action
        private void tsmi_File_Exit_Click(object sender, EventArgs e)
        {
            // Exits the application
            Application.Exit();
        }

        // Menu item Help > About action
        private void tsmi_Help_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notes Tool" + Environment.NewLine
                            + "Version 1.0.0" + Environment.NewLine + Environment.NewLine
                            + "Developed by: Paul Ramos" + Environment.NewLine + Environment.NewLine
                            + "Please send any feedback to:" + Environment.NewLine
                            + "paul.ramos@telus.com",
                            "About Notes Tool",
                            MessageBoxButtons.OK);
        }
    }
}
