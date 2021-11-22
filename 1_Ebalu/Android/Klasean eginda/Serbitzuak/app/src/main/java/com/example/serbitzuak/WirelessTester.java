package com.example.serbitzuak;

import android.app.Service;
import android.content.Context;
import android.content.Intent;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.os.IBinder;
import android.util.Log;

import androidx.annotation.Nullable;

public class WirelessTester extends Service {
    final String tag = "Demo Servicio";
    public boolean enEjecucion = false;
    public boolean wifi_activo = false;
    private Tester tester;

    @Override
    public void onCreate() {
        Log.i(tag, "Servicio Wireless creado!");
        tester = new Tester();
    }

    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {
        if (!enEjecucion) {
            enEjecucion = true;
            tester.start();
            Log.i(tag, "Servicio wireless arrancado");

        } else {
            Log.i(tag, "El servicio Wireless ya estaba en ejecucion");
        }
        return START_STICKY;
    }

    @Nullable
    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }

    @Override
    public void onDestroy() {
        Log.i(tag, "Servicio Wireless destruido");
        if (enEjecucion) {
            tester.interrupt();
        }
    }

    public class Tester extends Thread {
        @Override
        public void run() {
            while (enEjecucion) {
                try {
                    Log.i(tag, "Servicio ejecutandose...");
                    if (CompruebaConexionWifi()) {
                        Log.i(tag, "Conexion wifi activada");
                    } else {
                        Log.i(tag, "conexion wifi desactivada");

                    }

                    sleep(3000);
                } catch (InterruptedException e) {
                    enEjecucion = false;
                    Log.i(tag, "hilo del servicio interrumpido...");
                }
            }
        }

        public boolean CompruebaConexionWifi() {
            ConnectivityManager connectivity = (ConnectivityManager) getApplicationContext().getSystemService(Context.CONNECTIVITY_SERVICE);
            if (connectivity != null) {
                NetworkInfo info = connectivity.getActiveNetworkInfo();//connectivity.getNetworkInfo(ConnectivityManager.TYPE_WIFI);

                if (info != null) {
                    if (info.isConnected()) {
                        if (info.getType() == ConnectivityManager.TYPE_WIFI) {
                            return true;
                        }

                    }
                }
            }
            return false;
        }

    }
}


