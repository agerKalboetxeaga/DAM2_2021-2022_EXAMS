package com.example.http_conexion;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.util.concurrent.ExecutionException;

public class MainActivity extends AppCompatActivity {
    public TextView tx2;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        TextView tx = findViewById(R.id.textView2);
         tx2 = findViewById(R.id.textView);
        Conntection cn = new Conntection(this);
        Button btn2 = findViewById(R.id.button2);
        btn2.setOnClickListener(this::Sum);



            cn.execute("http://www.ciberaula.es/index.php");



    }

    private void Sum(View view) {
        HariaGehiketa hg = new HariaGehiketa(this);

        int num = hg.execute(0);

    }


}