namespace Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();

		if (this.AnimationIsRunning("TransitionAnimation"))
		{
			return;
		}

		var parentAnimation = new Animation();

		//PlanetsAnimation
		parentAnimation.Add(0.2, 0.4, new Animation(v => imgEarth.Opacity = v, 0, 1, Easing.CubicIn));

		parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null, null);
	}
}