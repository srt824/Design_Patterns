using AbstractFactory.Example1.Factories;

namespace AbstractFactory.Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IThemeFactory themeFactory = new WinFactory();

            IButton button = themeFactory.CreateButton();
            button.Render();

            IDropDown dropdown = themeFactory.CreateDropDown();
            dropdown.Render();

            ITextBox textbox = themeFactory.CreateTextBox();
            textbox.Render();
        }
    }
}
