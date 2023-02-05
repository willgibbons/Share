using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CSharpListObject
{
    public partial class Form : System.Windows.Forms.Form
    {
        //Members
        List<string> _listofstrings = null; // this is the standard list type // unused
        BindingList<string> _ListOfStrings; // binding list allows for linking lists to diff objects

        //Constructor
        public Form()
        {
            InitializeComponent();

            _ListOfStrings = new BindingList<string>(); // init Blist
            listBox1.DataSource = _ListOfStrings;       // bind list to listbox

            // add items to the list
            _ListOfStrings.Add("Item 1: string");
            _ListOfStrings.Add("Item 2: String");
            _ListOfStrings.Add("Item 3: STRING");
            // notice how they appear in the listbox on app launch
        }

        //Methods
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _ListOfStrings.Add(txtString.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                _ListOfStrings.RemoveAt(listBox1.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException E)
            {
                // if there are no items in the list an OutOfRange exception occurs
                // bandaid it by adding exception message to list
                _ListOfStrings.Add(E.Message);
            }
        }

    }//class
}//namespace
