namespace Cshape; //บอกขอบเขต Class

public partial class App : Application //partial  class คือส่วนหนึ่งของ App ที่เป็น class

{
	public App()  //Constructor

	{
		InitializeComponent();

		//MainPage = new NewPage1();
		MainPage = new OOP();
	}
}
