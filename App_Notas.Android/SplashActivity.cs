
using Android.App;
using Android.Content;
using Android.OS;
using AndroidX.AppCompat.App;
using App_Notas.Droid;
using System.Threading.Tasks;

[Activity(Theme = "@style/SplashTheme", MainLauncher = true, NoHistory = true)]
public class SplashActivity : AppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        SetContentView(Resource.Layout.pagina_inicio);

        Task.Run(async () =>
        {
            await Task.Delay(500);
            RunOnUiThread(() =>
            {
                StartActivity(new Intent(this, typeof(MainActivity)));
                Finish();
            });
        });
    }
}
