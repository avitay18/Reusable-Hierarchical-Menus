﻿namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private MenuItem m_TheMainMenu;

        public MainMenu(string i_Title)
        {
            this.m_TheMainMenu = new MenuItem(i_Title);
        }
        public MenuItem TheMainMenu
        {
            get
            {
                return this.m_TheMainMenu;
            }
        }
        public void AddItem(MenuItem i_ItemToAdd)
        {
            this.m_TheMainMenu.AddItem(i_ItemToAdd);
        }
        public void Show()
        {
            m_TheMainMenu.ItemChosen();
        }
    }
}
