using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
    public class MainMenu
    {
        private List<string> m_Options;

        public MainMenu()
        {
            createOptions();
        }

        private void createOptions()
        {
            m_Options = new List<string>();
            m_Options.Add("Press 1 To Add new vehicle To the Garage");
            m_Options.Add("Press 2 To ");
            m_Options.Add("Press 3 To Add new vehicle To the Garage");
            m_Options.Add("Press 4 To Add new vehicle To the Garage");
            m_Options.Add("Press 5 To Add new vehicle To the Garage");
            m_Options.Add("Press 6 To Add new vehicle To the Garage");


        }

    }
}
