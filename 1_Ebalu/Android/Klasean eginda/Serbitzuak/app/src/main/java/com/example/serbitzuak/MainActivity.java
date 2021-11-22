package com.example.serbitzuak;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.app.Service;
import android.content.Intent;
import android.os.Bundle;
import android.os.IBinder;
import android.util.Log;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    final String tag = "Demo Servicio";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Button arrancar_btn = findViewById(R.id.arrancar_btn);
        arrancar_btn.setOnClickListener(this::Arrancar);

        Button detener_btn = findViewById(R.id.parar_btn);
        detener_btn.setOnClickListener(this::Detener);


    }

    public void Arrancar(View v){
        startService(new Intent(getBaseContext(), WirelessTester.class));
    }

    public void Detener(View v){
        stopService(new Intent(getBaseContext(), WirelessTester.class));
    }


}