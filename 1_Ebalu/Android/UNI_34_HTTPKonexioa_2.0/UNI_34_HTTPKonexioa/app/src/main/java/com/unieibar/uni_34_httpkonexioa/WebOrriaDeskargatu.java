package com.unieibar.uni_34_httpkonexioa;

import android.app.Activity;
import android.content.Context;
import android.os.AsyncTask;
import android.view.View;
import android.widget.TextView;

import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

public class WebOrriaDeskargatu extends AsyncTask<String, Void, String> {

    TextView lbl_deskargatutakoa;
    public WebOrriaDeskargatu(Activity pantailanagusia)
    {
        lbl_deskargatutakoa = pantailanagusia.findViewById(R.id.lbl_deskargatutakoa);
    }

    /**
     * Runs on the UI thread before {@link #doInBackground}.
     * Invoked directly by {@link #execute} or {@link #executeOnExecutor}.
     * The default version does nothing.
     *
     * @see #onPostExecute
     * @see #doInBackground
     */
    @Override
    protected void onPreExecute() {
        super.onPreExecute();
        lbl_deskargatutakoa.setText("Web orrira atzitzeko prestatzen...");
    }

    @Override
    protected String doInBackground(String... urls) {
        // Parametroak execute() metodotik datoz
        //lbl_deskargatutakoa.setText("...webgunea eskatzen");
        try {
            return urlDeskargatu(urls[0]);
        } catch (IOException e) {
            return "Web orria ezin izan da lortu. URL-a gaizki egon daiteke.";
        }
    }

    /**
     * Runs on the UI thread after {@link #publishProgress} is invoked.
     * The specified values are the values passed to {@link #publishProgress}.
     * The default version does nothing.
     *
     * @param values The values indicating progress.
     * @see #publishProgress
     * @see #doInBackground
     */
    @Override
    protected void onProgressUpdate(Void... values) {
        super.onProgressUpdate(values);
        lbl_deskargatutakoa.setText("...webguneko datuak jasotzen");
    }

    @Override
    protected void onPostExecute(String s) {
        lbl_deskargatutakoa.setText(s);
    }



    // URL string bat abiapuntu hartuta, HttpUrlConnection konexio bat zabaltzen du eta webguneko edukia
    // InputStream lortzen du, ondoren String-era bihurtzen du lortutakoa
    private String urlDeskargatu(String urlstr) throws IOException {
        InputStream is = null;

        try {
            URL url = new URL(urlstr);
            HttpURLConnection conn = (HttpURLConnection) url.openConnection();
            conn.setReadTimeout(10000); /* milisegundutan */
            conn.setConnectTimeout(15000); /* milisegundutan */
            conn.setRequestMethod("GET");
            conn.setDoInput(true);
            // eskaera hasten da
            conn.connect();
            int response = conn.getResponseCode();
            is = conn.getInputStream();

            // InputStream-a String-era bilakatu
            return is2string(is);
        }
        catch (Exception ex) {
            return ex.getMessage();
        }
        finally { // InputStream-a itxiko dugu beti
            if (is != null) {
                is.close();
            }
        }
    }

    // InputStream bat String-era bilakatzen du
    private String is2string(InputStream is) {
        try {
            ByteArrayOutputStream bo = new ByteArrayOutputStream();
            int i = is.read();
            while(i != -1) {
                bo.write(i);
                i = is.read();
            }
            return bo.toString();
        } catch (IOException e) {
            return "";
        }
    }

}
