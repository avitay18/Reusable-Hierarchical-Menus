using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private readonly string r_ItemName;
        private List<MenuItem> m_MenuItemList = new List<MenuItem>();
        private string m_PrevMenu;

        public event Action<MenuItem> DoActionWhenChosen; 
        public MenuItem(string i_ItemName)
        {
            this.r_ItemName = i_ItemName;
        }
        public List<MenuItem> MenuItemList
        {
            get { return m_MenuItemList; }
        }

        public string ItemName
        {
            get
            {
                return this.r_ItemName;
            }
        }
        public string PrevMenu
        {
            get
            {
                return this.m_PrevMenu;
            }

            set
            {
                this.m_PrevMenu = value;
            }
        }
        public string Title
        {
            get
            {
                return this.r_ItemName;
            }
        }
        public void AddItem(MenuItem i_ItemToAdd)
        {
            m_MenuItemList.Add(i_ItemToAdd);
            i_ItemToAdd.PrevMenu = this.r_ItemName;
        }

        public void ItemChosen()
        {
            OnItemChosen();
        }
        protected virtual void OnItemChosen()
        {
            if(DoActionWhenChosen != null)
            {
                DoActionWhenChosen.Invoke(this);
            }
        }
    }
}
