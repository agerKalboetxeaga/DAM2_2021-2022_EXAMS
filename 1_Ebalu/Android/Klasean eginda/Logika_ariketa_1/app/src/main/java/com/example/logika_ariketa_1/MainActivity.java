package com.example.logika_ariketa_1;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Switch;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {
    private Button btn, btn2, btn3;
    private TextView txt, txt_2, txt3;
    private int kont = 0;
    private boolean active;
    private String text, text2, text_mem;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btn = (Button) findViewById(R.id.button_prueba);
        txt = (TextView) findViewById(R.id.txt_view);
        btn.setOnClickListener(this);
        txt_2 = (TextView) findViewById(R.id.textView_sapo);
        //(Switch)findViewById(R.id.switch1).
        btn2 = (Button) findViewById(R.id.btn_1); //variables
        btn3 = (Button) findViewById(R.id.btn2);
        txt3 = (TextView) findViewById(R.id.txt_3);
        btn2.setOnClickListener(this); //btn listeners
        btn3.setOnClickListener(this);
        text =(String) txt3.getText();  //base value
        text2 = (String) btn3.getText();
    }



    @Override
    public void onClick(View view) {
        switch(view.getId()){

            case R.id.btn_1: //1 boton
                text_mem = (String) txt3.getText();
                txt3.setText(btn3.getText());
                btn3.setText(text_mem);
                break;

            case R.id.btn2: //2. boton
                txt3.setText(text);
                btn3.setText(text2);
                break;

            case R.id.button_prueba:
                kont++;
                txt.setText(String.valueOf(kont));
                active = !active;
                txt.setTextSize(txt.getTextSize() + (float)0.1);
                if (active == true) {
                    txt_2.setVisibility(View.VISIBLE);


                } else {
                    txt_2.setVisibility(View.INVISIBLE);

                }
                break;

        }








       /* kont++;
        txt.setText(String.valueOf(kont));
        active = !active;
        txt.setTextSize(txt.getTextSize() + (float)0.1);
        if (active == true) {
            txt_2.setVisibility(View.VISIBLE);


        } else {
            txt_2.setVisibility(View.INVISIBLE);

        }

*/
    }

}