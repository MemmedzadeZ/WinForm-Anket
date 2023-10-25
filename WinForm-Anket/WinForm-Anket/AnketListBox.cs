//namespace WinForm_Anket;

//public class AnketListBox:ListBox
//{

//    public AnketListBox()
//    {
//        this.DrawMode = DrawMode.OwnerDrawVariable;
//        this.DrawItem += AnketListBox_DrawItem;
//    }

//    public DrawMode DrawMode { get; }
//    public Action<object, DrawItemEventArgs> DrawItem { get; }

//    private void AnketListBox_DrawItem(object sender, DrawItemEventArgs e)
//    {
//        if (e.Index < 0)
//            return;

//        Anket anket = (Anket)this.Items[e.Index];
//        string itemText = $"{anket.Ad} {anket.Soyad} - {anket.Email}";

//        e.DrawBackground();

//        using (SolidBrush brush = new SolidBrush(e.ForeColor))
//        {
//            e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds);
//        }

//        e.DrawFocusRectangle();
//    }
//}
