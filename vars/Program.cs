﻿// See https://aka.ms/new-console-template for more information
int i = 10;
float f = 2.0f;
decimal d = 10.0m;
bool b = true;
char c = 'c';

string str = "a string";

var x = 10;
var z = "Hello!";

int[] vals = new int[5];

string[] strs = {"one", "two"};

Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",i,c,b,d,f,str,x,z);

object obj = null;
Console.WriteLine(obj);

long bignum;
bignum = i;

float i_to_f = i;

Console.WriteLine("{0},{1}",bignum, i_to_f);

int f_to_i = (int)f;
Console.WriteLine("{0}", f_to_i);