using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Ejer6_AndroidRelations
{
    [Activity(Label = "CALCULATOR", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button _b1;
        private Button _b2;
        private Button _b3;
        private Button _b4;
        private Button _b5;
        private Button _b6;
        private Button _b7;
        private Button _b8;
        private Button _b9;
        private Button _b10;
        private Button _b11;
        private Button _b12;
        private Button _b13;
        private Button _b14;
        private EditText _introduceText;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
            AddBindForLayout();
        }

        private void AddBindForLayout()
        {
            _b1 = FindViewById<Button>(Resource.Id.b1);
            _b2 = FindViewById<Button>(Resource.Id.b2);
            _b3 = FindViewById<Button>(Resource.Id.b3);
            _b4 = FindViewById<Button>(Resource.Id.b4);
            _b5 = FindViewById<Button>(Resource.Id.b5);
            _b6 = FindViewById<Button>(Resource.Id.b6);
            _b7 = FindViewById<Button>(Resource.Id.b7);
            _b8 = FindViewById<Button>(Resource.Id.b8);
            _b9 = FindViewById<Button>(Resource.Id.b9);
            _b10 = FindViewById<Button>(Resource.Id.b10);
            _b11 = FindViewById<Button>(Resource.Id.b11);
            _b12 = FindViewById<Button>(Resource.Id.b12);
            _b13 = FindViewById<Button>(Resource.Id.b13);
            _b14 = FindViewById<Button>(Resource.Id.b14);

            _introduceText = FindViewById<EditText>(Resource.Id.introduceText);

            _b1.Click += PushAndWrite;
            _b2.Click += PushAndWrite;
            _b3.Click += PushAndWrite;
            _b4.Click += PushAndWrite;
            _b5.Click += PushAndWrite;
            _b6.Click += PushAndWrite;
            _b7.Click += PushAndWrite;
            _b8.Click += PushAndWrite;
            _b9.Click += PushAndWrite;
            _b10.Click += PushAndWrite;
            _b11.Click += PushAndWrite;
            _b12.Click += PushAndWrite;
            _b13.Click += PushAndWrite;
            _b14.Click += PushAndWrite;
     
        }

        private void PushAndWrite(Object sender, EventArgs e)
        {
            Button botonWriteText = (Button)sender;
            _introduceText.Text = _introduceText.Text.ToString() + botonWriteText.Text.ToString();
           
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}
}

