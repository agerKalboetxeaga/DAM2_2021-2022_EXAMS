package com.unieibar.uni_38_sqlite;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteException;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.text.TextWatcher;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity implements Button.OnClickListener, ListView.OnItemClickListener{

    private SQLiteDatabase db;
    private EditText txt_taldea;
    private EditText txt_diska;
    private Button btn_gehitu;
    private Button btn_ezabatu;
    private ListView lst_diskak;
    private String separadorea = ": ";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        txt_taldea = (EditText)findViewById(R.id.txt_taldea);
        txt_diska = (EditText)findViewById(R.id.txt_diska);
        btn_gehitu = (Button)findViewById(R.id.btn_gehitu);
        btn_gehitu.setOnClickListener(this);
        btn_ezabatu = (Button)findViewById(R.id.btn_ezabatu);
        btn_ezabatu.setOnClickListener(this);
        lst_diskak = (ListView)findViewById(R.id.lst_diskak);
        lst_diskak.setOnItemClickListener(this);

        // SQLite datu basea sortu edo atzitu
        db = openOrCreateDatabase("nireDiskak", Context.MODE_PRIVATE, null);
        db.execSQL("CREATE TABLE IF NOT EXISTS nireDiskak(taldea VARCHAR, diska VARCHAR);");
        zerrendaErakutsi();
    }

    @Override
    protected void onDestroy() {
        db.close();
        super.onDestroy();
    }

    public void zerrendaErakutsi(){
        ArrayAdapter<String> arrayAdapter;
        List<String> zerrenda = new ArrayList<String>();
        Cursor cursor = db.rawQuery("SELECT * FROM nireDiskak", null);
        if(cursor.getCount()==0) {
            zerrenda.add("Ez dago edukirik datu basean");
        }
        else{
            while(cursor.moveToNext()) {
                zerrenda.add(cursor.getString(0) + separadorea + cursor.getString(1));
            }
        }
        arrayAdapter = new ArrayAdapter<String>(getApplicationContext(), R.layout.zerrenda_lerroa, zerrenda);
        lst_diskak.setAdapter(arrayAdapter);
        cursor.close();
    }

    @Override
    public void onClick(View view) {
        if (view.getId() == btn_gehitu.getId())
        {
            diskaGehitu();
        }
        else if (view.getId() == btn_ezabatu.getId())
        {
            diskaEzabatu();
        }
    }

    public void diskaGehitu(){
        String talde_izena = txt_taldea.getText().toString();
        String diska_izena = txt_diska.getText().toString();
        String insert_query = "INSERT INTO nireDiskak VALUES ('" + talde_izena + "', '" + diska_izena + "')";
        db.execSQL(insert_query);
        Toast.makeText(this, talde_izena + ":" + diska_izena +" gehitu da datu basera", Toast.LENGTH_LONG).show();
        //Toast.makeText(this, insert_query, Toast.LENGTH_LONG).show();
        zerrendaErakutsi();
    }
    public void diskaEzabatu(){
        String talde_izena = txt_taldea.getText().toString();
        String diska_izena = txt_diska.getText().toString();
        try {
            String delete_query = "DELETE FROM nireDiskak WHERE taldea = '" + talde_izena + "' AND diska='" + diska_izena + "'";
            db.execSQL(delete_query);
            Toast.makeText(this, talde_izena + ":" + diska_izena +" ezabatu da datu basetik", Toast.LENGTH_LONG).show();
            //Toast.makeText(this, delete_query, Toast.LENGTH_LONG).show();
        }
        catch(SQLiteException s){
            Toast.makeText(this, "Errorea ezabatzerako garaian! " +  s.getMessage(), Toast.LENGTH_LONG).show();
        }
        zerrendaErakutsi();
    }

    @Override
    public void onItemClick(AdapterView<?> adapterView, View view, int position, long id) {
        TextView textView = (TextView)view;
        String testua_osorik = textView.getText().toString();
        if (testua_osorik.contains(":")) {
            String[] parts = testua_osorik.split(separadorea);
            String talde_izena = parts[0];
            String diska_izena = parts[1];
            txt_taldea.setText(talde_izena);
            txt_diska.setText(diska_izena);
        } else {
            Toast.makeText(this, "Datu basea hutsik dago oraindik...", Toast.LENGTH_LONG).show();
        }


    }
}