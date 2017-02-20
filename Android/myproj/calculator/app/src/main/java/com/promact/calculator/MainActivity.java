package com.promact.calculator;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;


public class MainActivity extends AppCompatActivity {
    Button b1,b2,b3,b4,b5,b6,b7,b8,b9,b0,bplus,bminus,bequal,clear;
    TextView input,output;
    int tot=0,temp1=0;
    String oper="+",str="";
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

        input = (TextView) findViewById(R.id.main_txt_input);
        output = (TextView) findViewById(R.id.main_txt_output);

        b0.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                if(oper=="=")
                {
                    input.setText(" ");
                    output.setText(" ");
                    str=" ";
                    oper="+";
                }
                str+="0";
                input.setText(str);
                temp1=(temp1*10)+0;
            }
        });
        b1.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                if(oper=="=")
                {
                    input.setText(" ");
                    output.setText(" ");
                    str=" ";
                    oper="+";
                }
                str+="1";
                input.setText(str);
                temp1=(temp1*10)+1;
            }
        });

        b2.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                if(oper=="=")
                {
                    input.setText(" ");
                    output.setText(" ");
                    str=" ";
                    oper="+";
                }
                str+="2";
                input.setText(str);
                temp1=(temp1*10)+2;
            }
        });

        b3.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                if(oper=="=")
                {
                    input.setText(" ");
                    output.setText(" ");
                    str=" ";
                    oper="+";
                }
                str+="3";
                input.setText(str);
                temp1=(temp1*10)+3;
            }
        });

        b4.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                if(oper=="=")
                {
                    input.setText(" ");
                    output.setText(" ");
                    str=" ";
                    oper="+";
                }
                str+="4";
                input.setText(str);
                temp1=(temp1*10)+4;
            }
        });
        b5.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                if(oper=="=")
                {
                    input.setText(" ");
                    output.setText(" ");
                    str=" ";
                    oper="+";
                }
                str+="5";
                input.setText(str);
                temp1=(temp1*10)+5;
            }
        });
        b6.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                if(oper=="=")
                {
                    input.setText(" ");
                    output.setText(" ");
                    str=" ";
                    oper="+";
                }
                str+="6";
                input.setText(str);
                temp1=(temp1*10)+6;
            }
        });
        b7.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                if(oper=="=")
                {
                    input.setText(" ");
                    output.setText(" ");
                    str=" ";
                    oper="+";
                }
                str+="7";
                input.setText(str);
                temp1=(temp1*10)+7;
            }
        });
        b8.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                if(oper=="=")
                {
                    input.setText(" ");
                    output.setText(" ");
                    str=" ";
                    oper="+";
                }
                str+="8";
                input.setText(str);
                temp1=(temp1*10)+8;
            }
        });
        b9.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                if(oper=="=")
                {
                    input.setText(" ");
                    output.setText(" ");
                    str=" ";
                    oper="+";
                }
                str+="9";
                input.setText(str);
                temp1=(temp1*10)+9;
            }
        });

        bplus.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                if(oper=="+")
                {
                    tot=tot+temp1;
                }
                if(oper=="-")
                {
                    tot=tot-temp1;
                }
                str+="+";
                oper="+";
                temp1=0;
                input.setText(str);

            }
        });

        bminus.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                if(oper=="+")
                {
                    tot=tot+temp1;
                }
                if(oper=="-")
                {
                    tot=tot-temp1;
                }
                str+="-";
                input.setText(str);
                oper="-";
                temp1=0;

            }
        });

        bequal.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                if(oper=="+")
                {
                    tot=tot+temp1;
                }
                if(oper=="-")
                {
                    tot=tot-temp1;
                }
                str+="=";
                output.setText(""+tot);
                oper="=";
                temp1=0;
                tot=0;
            }
        });

        clear.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                temp1=0;
                tot=0;
                oper="+";
                str="";
                output.setText(" ");
                input.setText("");
            }
        });

    }
}
