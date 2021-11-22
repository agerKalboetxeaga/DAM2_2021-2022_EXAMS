package com.unieibar.uni_34_httpkonexioa;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.os.Bundle;
import android.text.method.ScrollingMovementMethod;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

public class MainActivity extends AppCompatActivity implements Button.OnClickListener, WebOrriaIrakurriListener {

    TextView lbl_url;
    EditText txt_url;
    TextView lbl_deskargatutakoa;
    Button btn_deskargatu;
    String urlString;
    public String webString;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        txt_url = (EditText)findViewById(R.id.txt_url);
        lbl_deskargatutakoa = (TextView)findViewById(R.id.lbl_deskargatutakoa);
        lbl_deskargatutakoa.setMovementMethod(new ScrollingMovementMethod());
        btn_deskargatu = (Button)findViewById(R.id.btn_deskargatu);
        btn_deskargatu.setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {
        ConnectivityManager connMgr = (ConnectivityManager)  getSystemService(Context.CONNECTIVITY_SERVICE);
        NetworkInfo networkInfo = connMgr.getActiveNetworkInfo();
        if (networkInfo != null && networkInfo.isConnected()) {

            // 1.0 bertsioa: AsyncTask-ekin
            //String urlString = txt_url.getText().toString();
            //WebOrriaDeskargatu wod = new WebOrriaDeskargatu(this);
            //wod.execute(urlString);

            // 2.0 bertsioa: Hariak zuzenean erabilita
            urlString = txt_url.getText().toString();
            WebOrriaIrrakurri woi = new WebOrriaIrrakurri(urlString);
            woi.setWebOrriaIrakurriListener(this);
            woi.start();
        } else {
            lbl_deskargatutakoa.setText("Ezin izan da interneteko konexioa lortu.");
        }
    }

    @Override
    public void webOrriarenEmaitzaStringEran(String ws) {
        //lbl_deskargatutakoa.setText(webString);

        webString = ws;
        lbl_deskargatutakoa.post(new Runnable() {
            @Override
            public void run() {
                lbl_deskargatutakoa.setText(webString);
            }
        });


    }
}