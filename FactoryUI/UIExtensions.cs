namespace FactoryUI
{
    public static class UIExtensions
    {
        public static void AddItem(this ComboBox comboBox, string? value)
        {            
            comboBox.Items.Add(value);  
        }

        public static void ClearItemAndText(this ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Text = string.Empty;
        }

        public static void Clear(this Label label)
        {
            label.Text = string.Empty;
        }

    }
}
