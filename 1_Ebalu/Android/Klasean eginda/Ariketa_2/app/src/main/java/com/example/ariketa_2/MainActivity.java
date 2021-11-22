package com.example.ariketa_2;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RadioGroup;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    RadioGroup rgrp = (RadioGroup) findViewById(R.id.rGroup);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button btn_gehi = (Button) findViewById(R.id.btn_gehitu);
        btn_gehi.setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {
        if(rgrp.getChildCount() == 0){
            Toast.makeText(MainActivity.this, "Ezin da gehiago kendu", Toast.LENGTH_LONG).show();
        }
    }
    //.addView kreo, eso a dicho el sapo
}