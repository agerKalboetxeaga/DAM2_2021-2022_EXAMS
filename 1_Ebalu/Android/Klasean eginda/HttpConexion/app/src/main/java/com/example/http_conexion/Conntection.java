package com.example.http_conexion;

import android.app.Activity;
import android.os.AsyncTask;
import android.widget.TextView;

import androidx.annotation.NonNull;

import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;

public class Conntection extends AsyncTask<String, Void, String> {
    TextView tx;
    public Conntection(Activity act){
         tx = act.findViewById(R.id.textView2);
    }

    @Override
    protected String doInBackground(String... strings) {
        HttpURLConnection httpURLConnection = null;
        URL url = null;
        try{
            url = new URL (String.valueOf(strings[0]));
        } catch (MalformedURLException e) {
            e.printStackTrace();
        }
        try{
            httpURLConnection = (HttpURLConnection) url.openConnection();
            httpURLConnection.setReadTimeout(10000);
            httpURLConnection.setConnectTimeout(10000);
            httpURLConnection.setRequestMethod("GET");

            httpURLConnection.connect();
            int res_code = httpURLConnection.getResponseCode();
            if(res_code == HttpURLConnection.HTTP_OK){
                InputStream is = new BufferedInputStream(httpURLConnection.getInputStream());
                BufferedReader reader = new BufferedReader(new InputStreamReader(is));
                String line = "";
                StringBuffer sb = new StringBuffer();
                while((line = reader.readLine())!= null){
                    sb.append(line);
                }
                return sb.toString();
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
        return null;
    }

    @Override
    protected void onPostExecute(String s) {
        tx.setText(s);
    }
}
