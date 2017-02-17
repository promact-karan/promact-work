package com.promact.calculator1;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    Button b1,b2,b3,b4,b5,b6,b7,b8,b9,b0,bplus,bminus,bequal,clear;
    EditText input,output;
    int tot,plus=0,minus=0,temp2=0;
    String temp="",oper="";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        b0=(Button) findViewById(R.id.main_btn_0);
        b1=(Button) findViewById(R.id.main_btn_1);
        b2=(Button) findViewById(R.id.main_btn_2);
        b3=(Button) findViewById(R.id.main_btn_3);
        b4=(Button) findViewById(R.id.main_btn_4);
        b5=(Button) findViewById(R.id.main_btn_5);
        b6=(Button) findViewById(R.id.main_btn_6);
        b7=(Button) findViewById(R.id.main_btn_7);
        b8=(Button) findViewById(R.id.main_btn_8);
        b9=(Button) findViewById(R.id.main_btn_9);
        bplus=(Button)findViewById(R.id.main_btn_plus);
        bminus = (Button)findViewById(R.id.main_btn_minus);
        bequal = (Button) findViewById(R.id.main_btn_equal);
        clear=(Button)findViewById(R.id.main_btn_c);

        input = (EditText) findViewById(R.id.main_txt_input);
        output = (EditText) findViewById(R.id.main_txt_output);


        b0.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                temp+="0";
                input.setText(temp);
                temp2=(temp2*10)+0;
            }
        });

        b1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                temp+="1";
                input.setText(temp);
                temp2=(temp2*10)+1;
            }
        });

        b2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                temp+="2";
                input.setText(temp);
                temp2=(temp2*10)+2;
            }
        });

        b3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                temp+="3";
                input.setText(temp);
                temp2=(temp2*10)+3;
            }
        });

        b4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                temp+="4";
                input.setText(temp);
                temp2=(temp2*10)+4;
            }
        });
        b5.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                temp+="5";
                input.setText(temp);
                temp2=(temp2*10)+5;
            }
        });
        b6.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                temp+="6";
                input.setText(temp);
                temp2=(temp2*10)+6;
            }
        });
        b7.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                temp+="7";
                input.setText(temp);
                temp2=(temp2*10)+7;
            }
        });
        b8.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                temp+="8";
                input.setText(temp);
                temp2=(temp2*10)+8;
            }
        });
        b9.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                temp+="9";
                input.setText(temp);
                temp2=(temp2*10)+9;
            }
        });

        bplus.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                temp+="+";
                tot=tot+temp2;
                input.setText(temp);
                temp2=0;
                //output.setText(tot);

               /* temp+="+";
                input.setText(temp);
                tot+=temp2;
                //output.setText(tot);
                temp2=0;
                oper="+";*/
            }
        });

        bminus.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
              /*  temp+="-";
                input.setText(temp);
              //  if(tot>0)
              //  {
                    tot-=temp2;
               // }
               if(tot==0)
                {
                    tot=temp2;
                }
                //output.setText(tot);
                temp2=0;
                oper="-";*/

            }
        });

        bequal.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                temp+="=";
                input.setText(temp);
                if(oper=="+")
                {
                    tot+=temp2;
                }
                if(oper=="-")
                {
                    tot-=temp2;
                }
               output.setText(""+tot);
               temp="";
                temp2=0;
                tot=0;
            }
        });

        clear.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                temp="";
                input.setText("");
                output.setText("");
            }
        });

    }
}
