using System;
using System.Collections.Generic;
using System.Text;

namespace ToyotaVehicleSystem
{
    internal class NavigationManager
    {
        private Stack<Action> menuStack = new Stack<Action>();

        public void Navigate(Action menu)
        {
            menuStack.Push(menu);
        }

        public void Back()
        {
            if (menuStack.Count > 1)
            {
                menuStack.Pop();
                ShowCurrent();
            }
        }

        public void ShowCurrent()
        {
            if (menuStack.Count > 0)
            {
                menuStack.Peek()();
            }
        }
    }
}
