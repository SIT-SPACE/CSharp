namespace Cshape;

public partial class MainPage : ContentPage
{
	int count = 0; //ตัวแปรที่อยู่ในปีกกาใหญ่ สามารถใช้ในปีกกาเล็กได้หมดเลย 

	public MainPage()
	{
		InitializeComponent();
	}

	    private void Button_Clicked(object sender, EventArgs e)
    {
		myLabel.Text = "Hello from C#";
		/*int age =25;
		float  gpa = 3.75f;
		string name = "SiT";
		bool isGraduated = false;
		double pi = 3.14104198432; //Double 64 bit เก็บข้อมูลได้กว้างและแม่นยำกว่า float 32 bit แต่ใช้ความจำเยอะ
		int score = 60;
		if(score > 80)
		{
			myLabel.Text = "A";
		}
		else if (score > 70)
		{
			myLabel.Text = "B";
		}
		else if (score > 60)
		{
			myLabel.Text = "C";
		}
		else if (score > 50)
		{
			myLabel.Text = "D";
		}
		else{
			myLabel.Text = "F";
		}
        */
		
		
		string star = "";
		for(int i = 0; i < 5; i++)  //i++ คือ i += 
		{
			for(int j=0;  j<=i; j++)
			{
				star += "*";
			}
			star += "\n";
		}
		myLabel.Text = star;
		
		/*
        int i = 0;
		string star = "";

		while (i<10)
		{
			for(int j=0;  j<=i; j++)
			{
				star += "*";
			}
			star += "\n";
		}
		myLabel.Text = star;
	    */
    }
}

