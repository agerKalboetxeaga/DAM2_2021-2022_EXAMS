package com.example.http_conexion;

import android.app.Activity;
import android.os.AsyncTask;
import android.util.DisplayMetrics;
import android.widget.TextView;

public class HariaGehiketa extends AsyncTask<Integer, Integer, Integer> {
    TextView tx;
    Activity act;
    public HariaGehiketa(Activity act){
        tx = act.findViewById(R.id.textView);
        this.act = act;
    }
    @Override
    protected Integer doInBackground(Integer... integers) {
        int emaitza=0;

        for (int x =0; x <= 10;x++) {
            try {
                Thread.sleep(1000);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
            emaitza ++;
            publishProgress(emaitza);

            if(emaitza==10){
                return null;
            }

        }

        return emaitza;
    }

    @Override
    protected void onProgressUpdate(Integer... values) {
        super.onProgressUpdate(values);
        tx.setText(String.valueOf(values[0].intValue()));
        DisplayMetrics metrics;
        metrics = act.getApplicationContext().getResources().getDisplayMetrics();
        float Textsize =tx.getTextSize()/metrics.density;
        tx.setTextSize(Textsize + 5);
    }

    @Override
    protected void onPostExecute(Integer integer) {
        super.onPostExecute(integer);
    }
}
