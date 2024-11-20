namespace Cshape;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
	private void Button_Clicked1(object sender, EventArgs e)
    {
		int[] score =  {80,90,71,55,67};
		string[] name = {"a","b","c","d","e"};
		double[] gpa = {3.5,3.7,3.2,3.1,3.6}; //float กับ double มันไม่เหมือนกันตรงที่ขนาดของตัวแปรที float(เก็บได้ 7 หลัก) มีขนาดเล็กกว่า double(16 หลัก)

		/*
		if (gpa >= 3.5) //else if = elif
		{
			myLabel1.Text = "ผ่าน";
		}
		else
		{
			myLabel1.Text = "ไม่ผ่าน";
		}
		-----------------------------------------------
		string text = "";
		for(int i=0; i<score.Length;  i++) //(เริ่ม; สิ้นสุด; ขั้นตอน)
		{ // i++ = i = i +1
			text = text + score[i] + " ";
		}
		myLabel1.Text = text;
		*/
		string text = "";
		foreach(var s in score) //var คือการประกาศตัวแปรโดยที่ไม่ต้องระบุประเภทของตัวแปร
		{ //  for จะวนลูปกับแอเรย์ที่มีคีย์เป็นตัวเลข และ เรียงลำดับกันเท่านั้น และ foreach คีย์จะเป็นตัวเลขหรือตัวอักษรก็ได้ และ ไม่จำเป็นต้องเรียงลำดับ
			text += $"score { s }, "; // $ ทำให้สามารถแทรกตัวแปรไปใน str ได้
		}
		myLabel1.Text = text;

	}
	private void Button_Clicked2(object sender, EventArgs e) //void คือ ไม่มีการ return 
    {
		//myLabel2.Text = GetGreetingMessage("Kuy",90);
		//UpdateLabelText("Kuy",90); //ไม่การ return คือไม่สามารถใช้ return ได้
		UpdateLabelText();
	}

	private string GetGreetingMessage()
	{
		return $"Hello Unknow";
	}
	private string GetGreetingMessage(string name)
	{
		return $"Hello {name}" ;
	}
	private string GetGreetingMessage(string name, int score)
	{
		return $"Hello {name}, Your Score {score}" ;
	}

	private void UpdateLabelText(string name, int score)
	{
		myLabel2.Text = $"Hello {name}, Your Score {score}" ;
	}
	private void UpdateLabelText()
	{
		string[] name = {"a","b","c"};
		int[] score = {90,80,70};
		string text = "";
		for(int i = 0 ; i < 3 ; i++)
		{
			text += $"Hello {name[i]}, Your Score {score[i]} \n";
		}
		myLabel2.Text = text;
	}
}