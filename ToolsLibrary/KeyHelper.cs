
using System.Windows.Input;

namespace ToolsLibrary
{
    public class KeyHelper
    {
        public static bool IsKeyPressedValidPositiveInteger(Key ThisKey)
        {
            if ((ThisKey >= Key.D0 && ThisKey <= Key.D9) ||
                (ThisKey >= Key.NumPad0 && ThisKey <= Key.NumPad9))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsKeyPressedValidBinaryInteger(Key ThisKey)
        {
            if ((ThisKey >= Key.D0 && ThisKey <= Key.D1) ||
                (ThisKey >= Key.NumPad0 && ThisKey <= Key.NumPad1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
