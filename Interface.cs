using System;
interface IControl
{
    void Paint();
}
interface IListBox
{
    void SetText(string text);
}
interface IComboBox : IControl, IListBox //inheritance
{

}

interface IDataBound
{
    void Bind(string b);
}
public class EditBox : IComboBox, IDataBound
{
    public void Paint() { }
    public void SetText(string text) { }
    public void Bind(string b) { }
}
