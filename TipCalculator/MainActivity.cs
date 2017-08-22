using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TipCalculator
{
    [Activity(Label = "Tip Calculator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        EditText inputBill;
        Button calculateBill;
        TextView outputTip, outputTotal;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //assign the reference to corresponding view elements
            inputBill = FindViewById<EditText>(Resource.Id.inputBill);
            calculateBill = FindViewById<Button>(Resource.Id.calculateButton);
            outputTip = FindViewById<TextView>(Resource.Id.outputTip);
            outputTotal = FindViewById<TextView>(Resource.Id.outputTotal);

            //button click assignment
            calculateBill.Click += OnCalculateClick;

           
        }

        void OnCalculateClick(object sender, EventArgs e)
        {
            //get user input and convert it to double
            string text = inputBill.Text;
            double bill = double.Parse(text);

            //calculate tip
            double tip = bill * 0.15;
            double total = bill + tip;

            //display results
            outputTip.Text = tip.ToString();
            outputTotal.Text = total.ToString();

        }
    }
}

