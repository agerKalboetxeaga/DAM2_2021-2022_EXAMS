package com.unieibar.uni_34_httpkonexioa;

import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

public class WebOrriaIrrakurri extends Thread {

    // Barne propietateak
    private String urlString;
    private WebOrriaIrakurriListener worl;
    private String webString;

    public WebOrriaIrrakurri(String urlString)
    {
        this.urlString = urlString;
    }

    public void setWebOrriaIrakurriListener (WebOrriaIrakurriListener worl)
    {
        this.worl = worl;
    }

    @Override
    public void run() {

        // Hasi garela adieraziku dugu
        if (this.worl != null)
        {
            this.worl.webOrriarenEmaitzaStringEran("Web orria jaso nahian...");
        }

        // Web orria kargatuko dugu
        try {
            webString = urlDeskargatu(this.urlString);
        } catch (IOException e) {
            e.printStackTrace();
            webString = e.getLocalizedMessage();
        }

        // Bukatzerakoan String eran itzuliko diogu norbaiti (???)
        if (this.worl != null)
        {
            this.worl.webOrriarenEmaitzaStringEran(webString);
        }
    }

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
            return ex.getLocalizedMessage();
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
