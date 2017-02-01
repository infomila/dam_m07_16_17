(function(){var l,p=this;function q(a){return void 0!==a}
function r(a,b,c){a=a.split(".");c=c||p;a[0]in c||!c.execScript||c.execScript("var "+a[0]);for(var d;a.length&&(d=a.shift());)!a.length&&q(b)?c[d]=b:c[d]&&Object.prototype.hasOwnProperty.call(c,d)?c=c[d]:c=c[d]={}}
function t(a,b){for(var c=a.split("."),d=b||p,e;e=c.shift();)if(null!=d[e])d=d[e];else return null;return d}
function aa(){}
function ba(a){var b=typeof a;if("object"==b)if(a){if(a instanceof Array)return"array";if(a instanceof Object)return b;var c=Object.prototype.toString.call(a);if("[object Window]"==c)return"object";if("[object Array]"==c||"number"==typeof a.length&&"undefined"!=typeof a.splice&&"undefined"!=typeof a.propertyIsEnumerable&&!a.propertyIsEnumerable("splice"))return"array";if("[object Function]"==c||"undefined"!=typeof a.call&&"undefined"!=typeof a.propertyIsEnumerable&&!a.propertyIsEnumerable("call"))return"function"}else return"null";
else if("function"==b&&"undefined"==typeof a.call)return"object";return b}
function u(a){return"array"==ba(a)}
function x(a){var b=ba(a);return"array"==b||"object"==b&&"number"==typeof a.length}
function z(a){return"string"==typeof a}
function ca(a){return"function"==ba(a)}
function da(a){var b=typeof a;return"object"==b&&null!=a||"function"==b}
var ea="closure_uid_"+(1E9*Math.random()>>>0),fa=0;function ga(a,b,c){return a.call.apply(a.bind,arguments)}
function ha(a,b,c){if(!a)throw Error();if(2<arguments.length){var d=Array.prototype.slice.call(arguments,2);return function(){var c=Array.prototype.slice.call(arguments);Array.prototype.unshift.apply(c,d);return a.apply(b,c)}}return function(){return a.apply(b,arguments)}}
function A(a,b,c){A=Function.prototype.bind&&-1!=Function.prototype.bind.toString().indexOf("native code")?ga:ha;return A.apply(null,arguments)}
function ia(a,b){var c=Array.prototype.slice.call(arguments,1);return function(){var b=c.slice();b.push.apply(b,arguments);return a.apply(this,b)}}
function ja(a,b){for(var c in b)a[c]=b[c]}
var B=Date.now||function(){return+new Date};
function C(a,b){function c(){}
c.prototype=b.prototype;a.S=b.prototype;a.prototype=new c;a.prototype.constructor=a;a.Ib=function(a,c,f){for(var d=Array(arguments.length-2),e=2;e<arguments.length;e++)d[e-2]=arguments[e];return b.prototype[c].apply(a,d)}}
;var ka=window.yt&&window.yt.config_||window.ytcfg&&window.ytcfg.data_||{};r("yt.config_",ka,void 0);var D=window.performance&&window.performance.timing&&window.performance.now?function(){return window.performance.timing.navigationStart+window.performance.now()}:function(){return(new Date).getTime()};function la(a){var b=arguments;if(1<b.length){var c=b[0];ka[c]=b[1]}else for(c in b=b[0],b)ka[c]=b[c]}
function E(a,b){return a in ka?ka[a]:b}
function ma(a){return E(a,void 0)}
;function na(a){if(!a)return"";a=a.split("#")[0].split("?")[0];a=a.toLowerCase();0==a.indexOf("//")&&(a=window.location.protocol+a);/^[\w\-]*:\/\//.test(a)||(a=window.location.href);var b=a.substring(a.indexOf("://")+3),c=b.indexOf("/");-1!=c&&(b=b.substring(0,c));a=a.substring(0,a.indexOf("://"));if("http"!==a&&"https"!==a&&"chrome-extension"!==a&&"file"!==a&&"android-app"!==a)throw Error("Invalid URI scheme in origin");var c="",d=b.indexOf(":");if(-1!=d){var e=b.substring(d+1),b=b.substring(0,d);
if("http"===a&&"80"!==e||"https"===a&&"443"!==e)c=":"+e}return a+"://"+b+c}
;function oa(){function a(){e[0]=1732584193;e[1]=4023233417;e[2]=2562383102;e[3]=271733878;e[4]=3285377520;n=m=0}
function b(a){for(var b=g,c=0;64>c;c+=4)b[c/4]=a[c]<<24|a[c+1]<<16|a[c+2]<<8|a[c+3];for(c=16;80>c;c++)a=b[c-3]^b[c-8]^b[c-14]^b[c-16],b[c]=(a<<1|a>>>31)&4294967295;a=e[0];for(var d=e[1],f=e[2],h=e[3],k=e[4],v,m,c=0;80>c;c++)40>c?20>c?(v=h^d&(f^h),m=1518500249):(v=d^f^h,m=1859775393):60>c?(v=d&f|h&(d|f),m=2400959708):(v=d^f^h,m=3395469782),v=((a<<5|a>>>27)&4294967295)+v+k+m+b[c]&4294967295,k=h,h=f,f=(d<<30|d>>>2)&4294967295,d=a,a=v;e[0]=e[0]+a&4294967295;e[1]=e[1]+d&4294967295;e[2]=e[2]+f&4294967295;
e[3]=e[3]+h&4294967295;e[4]=e[4]+k&4294967295}
function c(a,c){if("string"===typeof a){a=unescape(encodeURIComponent(a));for(var d=[],e=0,g=a.length;e<g;++e)d.push(a.charCodeAt(e));a=d}c||(c=a.length);d=0;if(0==m)for(;d+64<c;)b(a.slice(d,d+64)),d+=64,n+=64;for(;d<c;)if(f[m++]=a[d++],n++,64==m)for(m=0,b(f);d+64<c;)b(a.slice(d,d+64)),d+=64,n+=64}
function d(){var a=[],d=8*n;56>m?c(h,56-m):c(h,64-(m-56));for(var g=63;56<=g;g--)f[g]=d&255,d>>>=8;b(f);for(g=d=0;5>g;g++)for(var k=24;0<=k;k-=8)a[d++]=e[g]>>k&255;return a}
for(var e=[],f=[],g=[],h=[128],k=1;64>k;++k)h[k]=0;var m,n;a();return{reset:a,update:c,digest:d,Ha:function(){for(var a=d(),b="",c=0;c<a.length;c++)b+="0123456789ABCDEF".charAt(Math.floor(a[c]/16))+"0123456789ABCDEF".charAt(a[c]%16);return b}}}
;/*
 gapi.loader.OBJECT_CREATE_TEST_OVERRIDE &&*/
var pa=window,qa=document,ra=pa.location;function sa(){}
var ta=/\[native code\]/;function F(a,b,c){return a[b]=a[b]||c}
function ua(a){for(var b=0;b<this.length;b++)if(this[b]===a)return b;return-1}
function va(a){a=a.sort();for(var b=[],c=void 0,d=0;d<a.length;d++){var e=a[d];e!=c&&b.push(e);c=e}return b}
function H(){var a;if((a=Object.create)&&ta.test(a))a=a(null);else{a={};for(var b in a)a[b]=void 0}return a}
var wa=F(pa,"gapi",{});function xa(a,b,c){this.i=c;this.g=a;this.l=b;this.f=0;this.b=null}
xa.prototype.get=function(){var a;0<this.f?(this.f--,a=this.b,this.b=a.next,a.next=null):a=this.g();return a};
function ya(a,b){a.l(b);a.f<a.i&&(a.f++,b.next=a.b,a.b=b)}
;function za(a){if(Error.captureStackTrace)Error.captureStackTrace(this,za);else{var b=Error().stack;b&&(this.stack=b)}a&&(this.message=String(a))}
C(za,Error);za.prototype.name="CustomError";function Aa(a){return/^\s*$/.test(a)?!1:/^[\],:{}\s\u2028\u2029]*$/.test(a.replace(/\\["\\\/bfnrtu]/g,"@").replace(/(?:"[^"\\\n\r\u2028\u2029\x00-\x08\x0a-\x1f]*"|true|false|null|-?\d+(?:\.\d*)?(?:[eE][+\-]?\d+)?)[\s\u2028\u2029]*(?=:|,|]|}|$)/g,"]").replace(/(?:^|:|,)(?:[\s\u2028\u2029]*\[)+/g,""))}
function Ba(a){a=String(a);if(Aa(a))try{return eval("("+a+")")}catch(b){}throw Error("Invalid JSON string: "+a);}
function Ca(a){return eval("("+a+")")}
function Da(a){var b=[];Fa(new Ga,a,b);return b.join("")}
function Ga(){}
function Fa(a,b,c){if(null==b)c.push("null");else{if("object"==typeof b){if(u(b)){var d=b;b=d.length;c.push("[");for(var e="",f=0;f<b;f++)c.push(e),e=d[f],Fa(a,e,c),e=",";c.push("]");return}if(b instanceof String||b instanceof Number||b instanceof Boolean)b=b.valueOf();else{c.push("{");f="";for(d in b)Object.prototype.hasOwnProperty.call(b,d)&&(e=b[d],"function"!=typeof e&&(c.push(f),Ha(d,c),c.push(":"),Fa(a,e,c),f=","));c.push("}");return}}switch(typeof b){case "string":Ha(b,c);break;case "number":c.push(isFinite(b)&&
!isNaN(b)?String(b):"null");break;case "boolean":c.push(String(b));break;case "function":c.push("null");break;default:throw Error("Unknown type: "+typeof b);}}}
var Ia={'"':'\\"',"\\":"\\\\","/":"\\/","\b":"\\b","\f":"\\f","\n":"\\n","\r":"\\r","\t":"\\t","\x0B":"\\u000b"},Ja=/\uffff/.test("\uffff")?/[\\\"\x00-\x1f\x7f-\uffff]/g:/[\\\"\x00-\x1f\x7f-\xff]/g;function Ha(a,b){b.push('"',a.replace(Ja,function(a){var b=Ia[a];b||(b="\\u"+(a.charCodeAt(0)|65536).toString(16).substr(1),Ia[a]=b);return b}),'"')}
;function Ka(a,b){this.width=a;this.height=b}
l=Ka.prototype;l.Da=function(){return this.width*this.height};
l.aspectRatio=function(){return this.width/this.height};
l.isEmpty=function(){return!this.Da()};
l.ceil=function(){this.width=Math.ceil(this.width);this.height=Math.ceil(this.height);return this};
l.floor=function(){this.width=Math.floor(this.width);this.height=Math.floor(this.height);return this};
l.round=function(){this.width=Math.round(this.width);this.height=Math.round(this.height);return this};function La(a){this.b=a||{cookie:""}}
var Ma=/\s*;\s*/;l=La.prototype;l.isEnabled=function(){return navigator.cookieEnabled};
l.set=function(a,b,c,d,e,f){if(/[;=\s]/.test(a))throw Error('Invalid cookie name "'+a+'"');if(/[;\r\n]/.test(b))throw Error('Invalid cookie value "'+b+'"');q(c)||(c=-1);e=e?";domain="+e:"";d=d?";path="+d:"";f=f?";secure":"";c=0>c?"":0==c?";expires="+(new Date(1970,1,1)).toUTCString():";expires="+(new Date(B()+1E3*c)).toUTCString();this.b.cookie=a+"="+b+e+d+c+f};
l.get=function(a,b){for(var c=a+"=",d=(this.b.cookie||"").split(Ma),e=0,f;f=d[e];e++){if(0==f.lastIndexOf(c,0))return f.substr(c.length);if(f==a)return""}return b};
l.remove=function(a,b,c){var d=q(this.get(a));this.set(a,"",0,b,c);return d};
l.P=function(){return Na(this).keys};
l.D=function(){return Na(this).values};
l.isEmpty=function(){return!this.b.cookie};
l.G=function(){return this.b.cookie?(this.b.cookie||"").split(Ma).length:0};
l.da=function(a){for(var b=Na(this).values,c=0;c<b.length;c++)if(b[c]==a)return!0;return!1};
l.clear=function(){for(var a=Na(this).keys,b=a.length-1;0<=b;b--)this.remove(a[b])};
function Na(a){a=(a.b.cookie||"").split(Ma);for(var b=[],c=[],d,e,f=0;e=a[f];f++)d=e.indexOf("="),-1==d?(b.push(""),c.push(e)):(b.push(e.substring(0,d)),c.push(e.substring(d+1)));return{keys:b,values:c}}
;function Oa(a,b){for(var c in a)b.call(void 0,a[c],c,a)}
function Pa(a,b,c){for(var d in a)if(b.call(c,a[d],d,a))return!0;return!1}
function Qa(a){var b=[],c=0,d;for(d in a)b[c++]=a[d];return b}
function Ra(a){var b=[],c=0,d;for(d in a)b[c++]=d;return b}
function Sa(a){var b=Ta,c;for(c in b)if(a.call(void 0,b[c],c,b))return c}
function Ua(a){for(var b in a)return!1;return!0}
function Va(a){var b={},c;for(c in a)b[c]=a[c];return b}
var Wa="constructor hasOwnProperty isPrototypeOf propertyIsEnumerable toLocaleString toString valueOf".split(" ");function Xa(a,b){for(var c,d,e=1;e<arguments.length;e++){d=arguments[e];for(c in d)a[c]=d[c];for(var f=0;f<Wa.length;f++)c=Wa[f],Object.prototype.hasOwnProperty.call(d,c)&&(a[c]=d[c])}}
;function Ya(a){a.prototype.then=a.prototype.then;a.prototype.$goog_Thenable=!0}
function Za(a){if(!a)return!1;try{return!!a.$goog_Thenable}catch(b){return!1}}
;function $a(a,b){var c=ab;return Object.prototype.hasOwnProperty.call(c,a)?c[a]:c[a]=b(a)}
;function bb(){}
;var cb=String.prototype.trim?function(a){return a.trim()}:function(a){return a.replace(/^[\s\xa0]+|[\s\xa0]+$/g,"")};
function db(a){return decodeURIComponent(a.replace(/\+/g," "))}
function eb(a,b){for(var c=0,d=cb(String(a)).split("."),e=cb(String(b)).split("."),f=Math.max(d.length,e.length),g=0;0==c&&g<f;g++){var h=d[g]||"",k=e[g]||"";do{h=/(\d*)(\D*)(.*)/.exec(h)||["","","",""];k=/(\d*)(\D*)(.*)/.exec(k)||["","","",""];if(0==h[0].length&&0==k[0].length)break;c=fb(0==h[1].length?0:parseInt(h[1],10),0==k[1].length?0:parseInt(k[1],10))||fb(0==h[2].length,0==k[2].length)||fb(h[2],k[2]);h=h[3];k=k[3]}while(0==c)}return c}
function fb(a,b){return a<b?-1:a>b?1:0}
function gb(a){var b=Number(a);return 0==b&&/^[\s\xa0]*$/.test(a)?NaN:b}
;function hb(a){this.type="";this.state=this.source=this.data=this.currentTarget=this.relatedTarget=this.target=null;this.charCode=this.keyCode=0;this.shiftKey=this.ctrlKey=this.altKey=!1;this.rotation=this.clientY=this.clientX=0;this.changedTouches=null;if(a=a||window.event){this.event=a;for(var b in a)b in ib||(this[b]=a[b]);this.rotation=a.rotation;(b=a.target||a.srcElement)&&3==b.nodeType&&(b=b.parentNode);this.target=b;if(b=a.relatedTarget)try{b=b.nodeName?b:null}catch(c){b=null}else"mouseover"==
this.type?b=a.fromElement:"mouseout"==this.type&&(b=a.toElement);this.relatedTarget=b;this.clientX=void 0!=a.clientX?a.clientX:a.pageX;this.clientY=void 0!=a.clientY?a.clientY:a.pageY;this.keyCode=a.keyCode?a.keyCode:a.which;this.charCode=a.charCode||("keypress"==this.type?this.keyCode:0);this.altKey=a.altKey;this.ctrlKey=a.ctrlKey;this.shiftKey=a.shiftKey}}
hb.prototype.preventDefault=function(){this.event&&(this.event.returnValue=!1,this.event.preventDefault&&this.event.preventDefault())};
hb.prototype.stopPropagation=function(){this.event&&(this.event.cancelBubble=!0,this.event.stopPropagation&&this.event.stopPropagation())};
hb.prototype.stopImmediatePropagation=function(){this.event&&(this.event.cancelBubble=!0,this.event.stopImmediatePropagation&&this.event.stopImmediatePropagation())};
var ib={stopImmediatePropagation:1,stopPropagation:1,preventMouseEvent:1,preventManipulation:1,preventDefault:1,layerX:1,layerY:1,screenX:1,screenY:1,scale:1,rotation:1,webkitMovementX:1,webkitMovementY:1};var jb=null;"undefined"!=typeof XMLHttpRequest?jb=function(){return new XMLHttpRequest}:"undefined"!=typeof ActiveXObject&&(jb=function(){return new ActiveXObject("Microsoft.XMLHTTP")});
function kb(a){switch(a&&"status"in a?a.status:-1){case 200:case 201:case 202:case 203:case 204:case 205:case 206:case 304:return!0;default:return!1}}
;function I(){this.b=this.b;this.l=this.l}
I.prototype.b=!1;I.prototype.dispose=function(){this.b||(this.b=!0,this.K())};
function lb(a,b){a.b?q(void 0)?b.call(void 0):b():(a.l||(a.l=[]),a.l.push(q(void 0)?A(b,void 0):b))}
I.prototype.K=function(){if(this.l)for(;this.l.length;)this.l.shift()()};
function mb(a){a&&"function"==typeof a.dispose&&a.dispose()}
function nb(a){for(var b=0,c=arguments.length;b<c;++b){var d=arguments[b];x(d)?nb.apply(null,d):mb(d)}}
;var J;a:{var ob=p.navigator;if(ob){var pb=ob.userAgent;if(pb){J=pb;break a}}J=""}function K(a){return-1!=J.indexOf(a)}
;function qb(a){this.b=a}
qb.prototype.set=function(a,b){q(b)?this.b.set(a,Da(b)):this.b.remove(a)};
qb.prototype.get=function(a){var b;try{b=this.b.get(a)}catch(c){return}if(null!==b)try{return Ba(b)}catch(c){throw"Storage: Invalid value was encountered";}};
qb.prototype.remove=function(a){this.b.remove(a)};var L;L=F(pa,"___jsl",H());F(L,"I",0);F(L,"hel",10);function rb(){var a=ra.href,b;if(L.dpo)b=L.h;else{b=L.h;var c=RegExp("([#].*&|[#])jsh=([^&#]*)","g"),d=RegExp("([?#].*&|[?#])jsh=([^&#]*)","g");if(a=a&&(c.exec(a)||d.exec(a)))try{b=decodeURIComponent(a[2])}catch(e){}}return b}
function sb(a){var b=F(L,"PQ",[]);L.PQ=[];var c=b.length;if(0===c)a();else for(var d=0,e=function(){++d===c&&a()},f=0;f<c;f++)b[f](e)}
function tb(a){return F(F(L,"H",H()),a,H())}
;function ub(a){return a[a.length-1]}
var vb=Array.prototype.indexOf?function(a,b,c){return Array.prototype.indexOf.call(a,b,c)}:function(a,b,c){c=null==c?0:0>c?Math.max(0,a.length+c):c;
if(z(a))return z(b)&&1==b.length?a.indexOf(b,c):-1;for(;c<a.length;c++)if(c in a&&a[c]===b)return c;return-1},M=Array.prototype.forEach?function(a,b,c){Array.prototype.forEach.call(a,b,c)}:function(a,b,c){for(var d=a.length,e=z(a)?a.split(""):a,f=0;f<d;f++)f in e&&b.call(c,e[f],f,a)},wb=Array.prototype.map?function(a,b,c){return Array.prototype.map.call(a,b,c)}:function(a,b,c){for(var d=a.length,e=Array(d),f=z(a)?a.split(""):a,g=0;g<d;g++)g in f&&(e[g]=b.call(c,f[g],g,a));
return e},xb=Array.prototype.some?function(a,b,c){return Array.prototype.some.call(a,b,c)}:function(a,b,c){for(var d=a.length,e=z(a)?a.split(""):a,f=0;f<d;f++)if(f in e&&b.call(c,e[f],f,a))return!0;
return!1},yb=Array.prototype.every?function(a,b,c){return Array.prototype.every.call(a,b,c)}:function(a,b,c){for(var d=a.length,e=z(a)?a.split(""):a,f=0;f<d;f++)if(f in e&&!b.call(c,e[f],f,a))return!1;
return!0};
function zb(a,b){var c=Ab(a,b,void 0);return 0>c?null:z(a)?a.charAt(c):a[c]}
function Ab(a,b,c){for(var d=a.length,e=z(a)?a.split(""):a,f=0;f<d;f++)if(f in e&&b.call(c,e[f],f,a))return f;return-1}
function Bb(a,b){return 0<=vb(a,b)}
function Cb(a){return Array.prototype.concat.apply(Array.prototype,arguments)}
function Db(a){var b=a.length;if(0<b){for(var c=Array(b),d=0;d<b;d++)c[d]=a[d];return c}return[]}
function Eb(a,b){for(var c=1;c<arguments.length;c++){var d=arguments[c];if(x(d)){var e=a.length||0,f=d.length||0;a.length=e+f;for(var g=0;g<f;g++)a[e+g]=d[g]}else a.push(d)}}
function Fb(a,b,c){return 2>=arguments.length?Array.prototype.slice.call(a,b):Array.prototype.slice.call(a,b,c)}
function Gb(a,b){a.sort(b||Hb)}
function Ib(a,b,c){var d=c||Hb;Gb(a,function(a,c){return d(b(a),b(c))})}
function Jb(a){Ib(a,function(a){return a.index},void 0)}
function Hb(a,b){return a>b?1:a<b?-1:0}
;function Kb(){this.f=this.b=null}
var Mb=new xa(function(){return new Lb},function(a){a.reset()},100);
Kb.prototype.remove=function(){var a=null;this.b&&(a=this.b,this.b=this.b.next,this.b||(this.f=null),a.next=null);return a};
function Lb(){this.next=this.scope=this.b=null}
Lb.prototype.set=function(a,b){this.b=a;this.scope=b;this.next=null};
Lb.prototype.reset=function(){this.next=this.scope=this.b=null};function Nb(){return K("iPhone")&&!K("iPod")&&!K("iPad")}
;function Ob(a){this.b=a}
C(Ob,qb);function Pb(a){this.data=a}
function Qb(a){return!q(a)||a instanceof Pb?a:new Pb(a)}
Ob.prototype.set=function(a,b){Ob.S.set.call(this,a,Qb(b))};
Ob.prototype.f=function(a){a=Ob.S.get.call(this,a);if(!q(a)||a instanceof Object)return a;throw"Storage: Invalid value was encountered";};
Ob.prototype.get=function(a){if(a=this.f(a)){if(a=a.data,!q(a))throw"Storage: Invalid value was encountered";}else a=void 0;return a};var Rb=/^(?:([^:/?#.]+):)?(?:\/\/(?:([^/?#]*)@)?([^/#?]*?)(?::([0-9]+))?(?=[/#?]|$))?([^?#]+)?(?:\?([^#]*))?(?:#([\s\S]*))?$/;function Sb(a){return a?decodeURI(a):a}
function Tb(a,b){return b.match(Rb)[a]||null}
function Ub(a,b){if(a)for(var c=a.split("&"),d=0;d<c.length;d++){var e=c[d].indexOf("="),f,g=null;0<=e?(f=c[d].substring(0,e),g=c[d].substring(e+1)):f=c[d];b(f,g?db(g):"")}}
function Vb(a,b,c){if(u(b))for(var d=0;d<b.length;d++)Vb(a,String(b[d]),c);else null!=b&&c.push("&",a,""===b?"":"=",encodeURIComponent(String(b)))}
function Wb(a,b){for(var c in b)Vb(c,b[c],a);return a}
function Xb(a){a=Wb([],a);a[0]="";return a.join("")}
function Yb(a,b){var c=Wb([a],b);if(c[1]){var d=c[0],e=d.indexOf("#");0<=e&&(c.push(d.substr(e)),c[0]=d=d.substr(0,e));e=d.indexOf("?");0>e?c[1]="?":e==d.length-1&&(c[1]=void 0)}return c.join("")}
;function Zb(a){return a&&window.yterr?function(){try{return a.apply(this,arguments)}catch(b){$b(b)}}:a}
function $b(a,b){var c=t("yt.logging.errors.log");c?c(a,b,void 0,void 0,void 0):(c=E("ERRORS",[]),c.push([a,b,void 0,void 0,void 0]),la("ERRORS",c))}
;function ac(a){return E("EXPERIMENT_FLAGS",{})[a]}
;function bc(a,b,c){var d=[],e=[];if(1==(u(c)?2:1))return e=[b,a],M(d,function(a){e.push(a)}),cc(e.join(" "));
var f=[],g=[];M(c,function(a){g.push(a.key);f.push(a.value)});
c=Math.floor((new Date).getTime()/1E3);e=0==f.length?[c,b,a]:[f.join(":"),c,b,a];M(d,function(a){e.push(a)});
a=cc(e.join(" "));a=[c,a];0==g.length||a.push(g.join(""));return a.join("_")}
function cc(a){var b=oa();b.update(a);return b.Ha().toLowerCase()}
;var dc=F(L,"perf",H());F(dc,"g",H());var ec=F(dc,"i",H());F(dc,"r",[]);H();H();function fc(a,b,c){b&&0<b.length&&(b=gc(b),c&&0<c.length&&(b+="___"+gc(c)),28<b.length&&(b=b.substr(0,28)+(b.length-28)),c=b,b=F(ec,"_p",H()),F(b,c,H())[a]=(new Date).getTime(),b=dc.r,"function"===typeof b?b(a,"_p",c):b.push([a,"_p",c]))}
function gc(a){return a.join("__").replace(/\./g,"_").replace(/\-/g,"_").replace(/\,/g,"_")}
;function hc(){return(K("Chrome")||K("CriOS"))&&!K("Edge")}
;function ic(a){this.b=a}
C(ic,Ob);ic.prototype.set=function(a,b,c){if(b=Qb(b)){if(c){if(c<B()){ic.prototype.remove.call(this,a);return}b.expiration=c}b.creation=B()}ic.S.set.call(this,a,b)};
ic.prototype.f=function(a,b){var c=ic.S.f.call(this,a);if(c){var d;if(d=!b){d=c.creation;var e=c.expiration;d=!!e&&e<B()||!!d&&d>B()}if(d)ic.prototype.remove.call(this,a);else return c}};function jc(a){if(a.G&&"function"==typeof a.G)a=a.G();else if(x(a)||z(a))a=a.length;else{var b=0,c;for(c in a)b++;a=b}return a}
function kc(a){if(a.D&&"function"==typeof a.D)return a.D();if(z(a))return a.split("");if(x(a)){for(var b=[],c=a.length,d=0;d<c;d++)b.push(a[d]);return b}return Qa(a)}
function lc(a){if(a.P&&"function"==typeof a.P)return a.P();if(!a.D||"function"!=typeof a.D){if(x(a)||z(a)){var b=[];a=a.length;for(var c=0;c<a;c++)b.push(c);return b}return Ra(a)}}
function mc(a,b,c){if(a.forEach&&"function"==typeof a.forEach)a.forEach(b,c);else if(x(a)||z(a))M(a,b,c);else for(var d=lc(a),e=kc(a),f=e.length,g=0;g<f;g++)b.call(c,e[g],d&&d[g],a)}
function nc(a,b){if("function"==typeof a.every)return a.every(b,void 0);if(x(a)||z(a))return yb(a,b,void 0);for(var c=lc(a),d=kc(a),e=d.length,f=0;f<e;f++)if(!b.call(void 0,d[f],c&&c[f],a))return!1;return!0}
;function oc(a,b){ca(a)&&(a=Zb(a));return window.setTimeout(a,b)}
;function pc(a){a=a.split("&");for(var b={},c=0,d=a.length;c<d;c++){var e=a[c].split("=");if(1==e.length&&e[0]||2==e.length){var f=db(e[0]||""),e=db(e[1]||"");f in b?u(b[f])?Eb(b[f],e):b[f]=[b[f],e]:b[f]=e}}return b}
function qc(a){"?"==a.charAt(0)&&(a=a.substr(1));return pc(a)}
function rc(a){a=a.split(",");return a=a.map(function(a){return qc(a)})}
function sc(a,b,c){var d=a.split("#",2);a=d[0];var d=1<d.length?"#"+d[1]:"",e=a.split("?",2);a=e[0];var e=qc(e[1]||""),f;for(f in b)!c&&null!==e&&f in e||(e[f]=b[f]);return Yb(a,e)+d}
;var tc=H(),uc=[];function vc(a){throw Error("Bad hint"+(a?": "+a:""));}
uc.push(["jsl",function(a){for(var b in a)if(Object.prototype.hasOwnProperty.call(a,b)){var c=a[b];"object"==typeof c?L[b]=F(L,b,[]).concat(c):F(L,b,c)}if(b=a.u)a=F(L,"us",[]),a.push(b),(b=/^https:(.*)$/.exec(b))&&a.push("http:"+b[1])}]);
var wc=/^(\/[a-zA-Z0-9_\-]+)+$/,xc=[/\/amp\//,/\/amp$/,/^\/amp$/],yc=/^[a-zA-Z0-9\-_\.,!]+$/,zc=/^gapi\.loaded_[0-9]+$/,Ac=/^[a-zA-Z0-9,._-]+$/;function Bc(a,b,c,d){var e=a.split(";"),f=e.shift(),g=tc[f],h=null;g?h=g(e,b,c,d):vc("no hint processor for: "+f);h||vc("failed to generate load url");b=h;c=b.match(Cc);(d=b.match(Dc))&&1===d.length&&Ec.test(b)&&c&&1===c.length||vc("failed sanity: "+a);return h}
function Fc(a,b,c,d){function e(a){return encodeURIComponent(a).replace(/%2C/g,",")}
a=Gc(a);zc.test(c)||vc("invalid_callback");b=Hc(b);d=d&&d.length?Hc(d):null;return[encodeURIComponent(a.ab).replace(/%2C/g,",").replace(/%2F/g,"/"),"/k=",e(a.version),"/m=",e(b),d?"/exm="+e(d):"","/rt=j/sv=1/d=1/ed=1",a.ua?"/am="+e(a.ua):"",a.Ba?"/rs="+e(a.Ba):"",a.Ca?"/t="+e(a.Ca):"","/cb=",e(c)].join("")}
function Gc(a){"/"!==a.charAt(0)&&vc("relative path");for(var b=a.substring(1).split("/"),c=[];b.length;){a=b.shift();if(!a.length||0==a.indexOf("."))vc("empty/relative directory");else if(0<a.indexOf("=")){b.unshift(a);break}c.push(a)}a={};for(var d=0,e=b.length;d<e;++d){var f=b[d].split("="),g=decodeURIComponent(f[0]),h=decodeURIComponent(f[1]);2==f.length&&g&&h&&(a[g]=a[g]||h)}b="/"+c.join("/");wc.test(b)||vc("invalid_prefix");c=0;for(d=xc.length;c<d;++c)xc[c].test(b)&&vc("invalid_prefix");c=Ic(a,
"k",!0);d=Ic(a,"am");e=Ic(a,"rs");a=Ic(a,"t");return{ab:b,version:c,ua:d,Ba:e,Ca:a}}
function Hc(a){for(var b=[],c=0,d=a.length;c<d;++c){var e=a[c].replace(/\./g,"_").replace(/-/g,"_");Ac.test(e)&&b.push(e)}return b.join(",")}
function Ic(a,b,c){a=a[b];!a&&c&&vc("missing: "+b);if(a){if(yc.test(a))return a;vc("invalid: "+b)}return null}
var Ec=/^https?:\/\/[a-z0-9_.-]+\.google\.com(:\d+)?\/[a-zA-Z0-9_.,!=\-\/]+$/,Dc=/\/cb=/g,Cc=/\/\//g;function Jc(){var a=rb();if(!a)throw Error("Bad hint");return a}
tc.m=function(a,b,c,d){(a=a[0])||vc("missing_hint");return"https://apis.google.com"+Fc(a,b,c,d)};
var Kc=decodeURI("%73cript"),Lc=/^[-+_0-9\/A-Za-z]+={0,2}$/;function Mc(a,b){for(var c=[],d=0;d<a.length;++d){var e=a[d];e&&0>ua.call(b,e)&&c.push(e)}return c}
function Nc(){var a=L.nonce;if(void 0!==a)return a&&a===String(a)&&a.match(Lc)?a:L.nonce=null;var b=F(L,"us",[]);if(!b||!b.length)return L.nonce=null;for(var c=qa.getElementsByTagName(Kc),d=0,e=c.length;d<e;++d){var f=c[d];if(f.src&&(a=String(f.getAttribute("nonce")||"")||null)){for(var g=0,h=b.length;g<h&&b[g]!==f.src;++g);if(g!==h&&a&&a===String(a)&&a.match(Lc))return L.nonce=a}}return null}
function Oc(a){if("loading"!=qa.readyState)Pc(a);else{var b=Nc(),c="";null!==b&&(c=' nonce="'+b+'"');qa.write("<"+Kc+' src="'+encodeURI(a)+'"'+c+"></"+Kc+">")}}
function Pc(a){var b=qa.createElement(Kc);b.setAttribute("src",a);a=Nc();null!==a&&b.setAttribute("nonce",a);b.async="true";(a=qa.getElementsByTagName(Kc)[0])?a.parentNode.insertBefore(b,a):(qa.head||qa.body||qa.documentElement).appendChild(b)}
function Qc(a,b){var c=b&&b._c;if(c)for(var d=0;d<uc.length;d++){var e=uc[d][0],f=uc[d][1];f&&Object.prototype.hasOwnProperty.call(c,e)&&f(c[e],a,b)}}
function Rc(a,b,c){Sc(function(){var c;c=b===rb()?F(wa,"_",H()):H();c=F(tb(b),"_",c);a(c)},c)}
function Tc(a,b){var c=b||{};"function"==typeof b&&(c={},c.callback=b);Qc(a,c);var d=a?a.split(":"):[],e=c.h||Jc(),f=F(L,"ah",H());if(f["::"]&&d.length){for(var g=[],h=null;h=d.shift();){var k=h.split("."),k=f[h]||f[k[1]&&"ns:"+k[0]||""]||e,m=g.length&&g[g.length-1]||null,n=m;m&&m.hint==k||(n={hint:k,features:[]},g.push(n));n.features.push(h)}var v=g.length;if(1<v){var y=c.callback;y&&(c.callback=function(){0==--v&&y()})}for(;d=g.shift();)Uc(d.features,c,d.hint)}else Uc(d||[],c,e)}
function Uc(a,b,c){function d(a,b){if(v)return 0;pa.clearTimeout(n);y.push.apply(y,w);var d=((wa||{}).config||{}).update;d?d(f):f&&F(L,"cu",[]).push(f);if(b){fc("me0",a,G);try{Rc(b,c,m)}finally{fc("me1",a,G)}}return 1}
a=va(a)||[];var e=b.callback,f=b.config,g=b.timeout,h=b.ontimeout,k=b.onerror,m=void 0;"function"==typeof k&&(m=k);var n=null,v=!1;if(g&&!h||!g&&h)throw"Timeout requires both the timeout parameter and ontimeout parameter to be set";var k=F(tb(c),"r",[]).sort(),y=F(tb(c),"L",[]).sort(),G=[].concat(k);0<g&&(n=pa.setTimeout(function(){v=!0;h()},g));
var w=Mc(a,y);if(w.length){var w=Mc(a,k),R=F(L,"CP",[]),W=R.length;R[W]=function(a){function b(){var a=R[W+1];a&&a()}
function c(b){R[W]=null;d(w,a)&&sb(function(){e&&e();b()})}
if(!a)return 0;fc("ml1",w,G);0<W&&R[W-1]?R[W]=function(){c(b)}:c(b)};
if(w.length){var Ea="loaded_"+L.I++;wa[Ea]=function(a){R[W](a);wa[Ea]=null};
a=Bc(c,w,"gapi."+Ea,k);k.push.apply(k,w);fc("ml0",w,G);b.sync||pa.___gapisync?Oc(a):Pc(a)}else R[W](sa)}else d(w)&&e&&e()}
function Sc(a,b){if(L.hee&&0<L.hel)try{return a()}catch(c){b&&b(c),L.hel--,Tc("debug_error",function(){try{window.___jsl.hefn(c)}catch(d){throw c;}})}else try{return a()}catch(c){throw b&&b(c),c;
}}
wa.load=function(a,b){return Sc(function(){return Tc(a,b)})};function Vc(a){p.setTimeout(function(){throw a;},0)}
var Wc;
function Xc(){var a=p.MessageChannel;"undefined"===typeof a&&"undefined"!==typeof window&&window.postMessage&&window.addEventListener&&!K("Presto")&&(a=function(){var a=document.createElement("IFRAME");a.style.display="none";a.src="";document.documentElement.appendChild(a);var b=a.contentWindow,a=b.document;a.open();a.write("");a.close();var c="callImmediate"+Math.random(),d="file:"==b.location.protocol?"*":b.location.protocol+"//"+b.location.host,a=A(function(a){if(("*"==d||a.origin==d)&&a.data==
c)this.port1.onmessage()},this);
b.addEventListener("message",a,!1);this.port1={};this.port2={postMessage:function(){b.postMessage(c,d)}}});
if("undefined"!==typeof a&&!K("Trident")&&!K("MSIE")){var b=new a,c={},d=c;b.port1.onmessage=function(){if(q(c.next)){c=c.next;var a=c.va;c.va=null;a()}};
return function(a){d.next={va:a};d=d.next;b.port2.postMessage(0)}}return"undefined"!==typeof document&&"onreadystatechange"in document.createElement("SCRIPT")?function(a){var b=document.createElement("SCRIPT");
b.onreadystatechange=function(){b.onreadystatechange=null;b.parentNode.removeChild(b);b=null;a();a=null};
document.documentElement.appendChild(b)}:function(a){p.setTimeout(a,0)}}
;function Yc(){this.b="";this.f=Zc}
Yc.prototype.za=!0;Yc.prototype.xa=function(){return this.b};
var $c=/^(?:(?:https?|mailto|ftp):|[^&:/?#]*(?:[/?#]|$))/i,Zc={};function ad(a){var b=new Yc;b.b=a;return b}
ad("about:blank");var bd="StopIteration"in p?p.StopIteration:{message:"StopIteration",stack:""};function cd(){}
cd.prototype.next=function(){throw bd;};
cd.prototype.R=function(){return this};
function dd(a){if(a instanceof cd)return a;if("function"==typeof a.R)return a.R(!1);if(x(a)){var b=0,c=new cd;c.next=function(){for(;;){if(b>=a.length)throw bd;if(b in a)return a[b++];b++}};
return c}throw Error("Not implemented");}
function ed(a,b){if(x(a))try{M(a,b,void 0)}catch(c){if(c!==bd)throw c;}else{a=dd(a);try{for(;;)b.call(void 0,a.next(),void 0,a)}catch(c){if(c!==bd)throw c;}}}
function fd(a){if(x(a))return Db(a);a=dd(a);var b=[];ed(a,function(a){b.push(a)});
return b}
;var gd=K("Opera"),N=K("Trident")||K("MSIE"),hd=K("Edge"),id=K("Gecko")&&!(-1!=J.toLowerCase().indexOf("webkit")&&!K("Edge"))&&!(K("Trident")||K("MSIE"))&&!K("Edge"),jd=-1!=J.toLowerCase().indexOf("webkit")&&!K("Edge"),kd=K("Android"),ld=Nb()||K("iPad")||K("iPod");function md(){var a=p.document;return a?a.documentMode:void 0}
var nd;a:{var od="",pd=function(){var a=J;if(id)return/rv\:([^\);]+)(\)|;)/.exec(a);if(hd)return/Edge\/([\d\.]+)/.exec(a);if(N)return/\b(?:MSIE|rv)[: ]([^\);]+)(\)|;)/.exec(a);if(jd)return/WebKit\/(\S+)/.exec(a);if(gd)return/(?:Version)[ \/]?(\S+)/.exec(a)}();
pd&&(od=pd?pd[1]:"");if(N){var qd=md();if(null!=qd&&qd>parseFloat(od)){nd=String(qd);break a}}nd=od}var rd=nd,ab={};function O(a){return $a(a,function(){return 0<=eb(rd,a)})}
var sd;var td=p.document;sd=td&&N?md()||("CSS1Compat"==td.compatMode?parseInt(rd,10):5):void 0;function ud(){var a=vd,b=5E3;isNaN(b)&&(b=void 0);var c=t("yt.scheduler.instance.addJob");return c?c(a,0,b):void 0===b?(a(),NaN):oc(a,b||0)}
;function wd(a,b){xd||yd();zd||(xd(),zd=!0);var c=Ad,d=Mb.get();d.set(a,b);c.f?c.f.next=d:c.b=d;c.f=d}
var xd;function yd(){if(-1!=String(p.Promise).indexOf("[native code]")){var a=p.Promise.resolve(void 0);xd=function(){a.then(Bd)}}else xd=function(){var a=Bd;
!ca(p.setImmediate)||p.Window&&p.Window.prototype&&!K("Edge")&&p.Window.prototype.setImmediate==p.setImmediate?(Wc||(Wc=Xc()),Wc(a)):p.setImmediate(a)}}
var zd=!1,Ad=new Kb;function Bd(){for(var a;a=Ad.remove();){try{a.b.call(a.scope)}catch(b){Vc(b)}ya(Mb,a)}zd=!1}
;!id&&!N||N&&9<=Number(sd)||id&&O("1.9.1");N&&O("9");function Cd(){this.b=""}
Cd.prototype.za=!0;Cd.prototype.xa=function(){return this.b};
function Dd(a){var b=new Cd;b.b=a;return b}
Dd("<!DOCTYPE html>");Dd("");Dd("<br>");function Ed(a){this.b=a}
C(Ed,ic);function Fd(){}
C(Fd,bb);Fd.prototype.G=function(){var a=0;ed(this.R(!0),function(){a++});
return a};
Fd.prototype.clear=function(){var a=fd(this.R(!0)),b=this;M(a,function(a){b.remove(a)})};function Gd(a,b){this.f={};this.b=[];this.i=this.g=0;var c=arguments.length;if(1<c){if(c%2)throw Error("Uneven number of arguments");for(var d=0;d<c;d+=2)this.set(arguments[d],arguments[d+1])}else if(a){a instanceof Gd?(c=a.P(),d=a.D()):(c=Ra(a),d=Qa(a));for(var e=0;e<c.length;e++)this.set(c[e],d[e])}}
l=Gd.prototype;l.G=function(){return this.g};
l.D=function(){Hd(this);for(var a=[],b=0;b<this.b.length;b++)a.push(this.f[this.b[b]]);return a};
l.P=function(){Hd(this);return this.b.concat()};
l.da=function(a){for(var b=0;b<this.b.length;b++){var c=this.b[b];if(Id(this.f,c)&&this.f[c]==a)return!0}return!1};
l.equals=function(a,b){if(this===a)return!0;if(this.g!=a.G())return!1;var c=b||Jd;Hd(this);for(var d,e=0;d=this.b[e];e++)if(!c(this.get(d),a.get(d)))return!1;return!0};
function Jd(a,b){return a===b}
l.isEmpty=function(){return 0==this.g};
l.clear=function(){this.f={};this.i=this.g=this.b.length=0};
l.remove=function(a){return Id(this.f,a)?(delete this.f[a],this.g--,this.i++,this.b.length>2*this.g&&Hd(this),!0):!1};
function Hd(a){if(a.g!=a.b.length){for(var b=0,c=0;b<a.b.length;){var d=a.b[b];Id(a.f,d)&&(a.b[c++]=d);b++}a.b.length=c}if(a.g!=a.b.length){for(var e={},c=b=0;b<a.b.length;)d=a.b[b],Id(e,d)||(a.b[c++]=d,e[d]=1),b++;a.b.length=c}}
l.get=function(a,b){return Id(this.f,a)?this.f[a]:b};
l.set=function(a,b){Id(this.f,a)||(this.g++,this.b.push(a),this.i++);this.f[a]=b};
l.forEach=function(a,b){for(var c=this.P(),d=0;d<c.length;d++){var e=c[d],f=this.get(e);a.call(b,f,e,this)}};
l.R=function(a){Hd(this);var b=0,c=this.i,d=this,e=new cd;e.next=function(){if(c!=d.i)throw Error("The map has changed since the iterator was created");if(b>=d.b.length)throw bd;var e=d.b[b++];return a?e:d.f[e]};
return e};
function Id(a,b){return Object.prototype.hasOwnProperty.call(a,b)}
;var Kd=K("Firefox"),Ld=Nb()||K("iPod"),Md=K("iPad"),Nd=K("Android")&&!(hc()||K("Firefox")||K("Opera")||K("Silk")),Od=hc(),Pd=K("Safari")&&!(hc()||K("Coast")||K("Opera")||K("Edge")||K("Silk")||K("Android"))&&!(Nb()||K("iPad")||K("iPod"));function P(a,b){this.b=0;this.o=void 0;this.i=this.f=this.g=null;this.l=this.j=!1;if(a!=aa)try{var c=this;a.call(b,function(a){Qd(c,2,a)},function(a){Qd(c,3,a)})}catch(d){Qd(this,3,d)}}
function Rd(){this.next=this.context=this.f=this.g=this.b=null;this.i=!1}
Rd.prototype.reset=function(){this.context=this.f=this.g=this.b=null;this.i=!1};
var Sd=new xa(function(){return new Rd},function(a){a.reset()},100);
function Td(a,b,c){var d=Sd.get();d.g=a;d.f=b;d.context=c;return d}
function Ud(a){if(a instanceof P)return a;var b=new P(aa);Qd(b,2,a);return b}
function Vd(a){return new P(function(b,c){c(a)})}
P.prototype.then=function(a,b,c){return Wd(this,ca(a)?a:null,ca(b)?b:null,c)};
Ya(P);function Xd(a,b){return Wd(a,null,b,void 0)}
P.prototype.cancel=function(a){0==this.b&&wd(function(){var b=new Yd(a);Zd(this,b)},this)};
function Zd(a,b){if(0==a.b)if(a.g){var c=a.g;if(c.f){for(var d=0,e=null,f=null,g=c.f;g&&(g.i||(d++,g.b==a&&(e=g),!(e&&1<d)));g=g.next)e||(f=g);e&&(0==c.b&&1==d?Zd(c,b):(f?(d=f,d.next==c.i&&(c.i=d),d.next=d.next.next):$d(c),ae(c,e,3,b)))}a.g=null}else Qd(a,3,b)}
function be(a,b){a.f||2!=a.b&&3!=a.b||ce(a);a.i?a.i.next=b:a.f=b;a.i=b}
function Wd(a,b,c,d){var e=Td(null,null,null);e.b=new P(function(a,g){e.g=b?function(c){try{var e=b.call(d,c);a(e)}catch(m){g(m)}}:a;
e.f=c?function(b){try{var e=c.call(d,b);!q(e)&&b instanceof Yd?g(b):a(e)}catch(m){g(m)}}:g});
e.b.g=a;be(a,e);return e.b}
P.prototype.B=function(a){this.b=0;Qd(this,2,a)};
P.prototype.C=function(a){this.b=0;Qd(this,3,a)};
function Qd(a,b,c){if(0==a.b){a===c&&(b=3,c=new TypeError("Promise cannot resolve to itself"));a.b=1;var d;a:{var e=c,f=a.B,g=a.C;if(e instanceof P)be(e,Td(f||aa,g||null,a)),d=!0;else if(Za(e))e.then(f,g,a),d=!0;else{if(da(e))try{var h=e.then;if(ca(h)){de(e,h,f,g,a);d=!0;break a}}catch(k){g.call(a,k);d=!0;break a}d=!1}}d||(a.o=c,a.b=b,a.g=null,ce(a),3!=b||c instanceof Yd||ee(a,c))}}
function de(a,b,c,d,e){function f(a){h||(h=!0,d.call(e,a))}
function g(a){h||(h=!0,c.call(e,a))}
var h=!1;try{b.call(a,g,f)}catch(k){f(k)}}
function ce(a){a.j||(a.j=!0,wd(a.A,a))}
function $d(a){var b=null;a.f&&(b=a.f,a.f=b.next,b.next=null);a.f||(a.i=null);return b}
P.prototype.A=function(){for(var a;a=$d(this);)ae(this,a,this.b,this.o);this.j=!1};
function ae(a,b,c,d){if(3==c&&b.f&&!b.i)for(;a&&a.l;a=a.g)a.l=!1;if(b.b)b.b.g=null,fe(b,c,d);else try{b.i?b.g.call(b.context):fe(b,c,d)}catch(e){ge.call(null,e)}ya(Sd,b)}
function fe(a,b,c){2==b?a.g.call(a.context,c):a.f&&a.f.call(a.context,c)}
function ee(a,b){a.l=!0;wd(function(){a.l&&ge.call(null,b)})}
var ge=Vc;function Yd(a){za.call(this,a)}
C(Yd,za);Yd.prototype.name="cancel";function Q(a){I.call(this);this.o=1;this.i=[];this.j=0;this.f=[];this.g={};this.A=!!a}
C(Q,I);l=Q.prototype;l.subscribe=function(a,b,c){var d=this.g[a];d||(d=this.g[a]=[]);var e=this.o;this.f[e]=a;this.f[e+1]=b;this.f[e+2]=c;this.o=e+3;d.push(e);return e};
function he(a){var b=ie,c=a.g.onClick;if(c){var d=a.f;(c=zb(c,function(a){return d[a+1]==b&&void 0==d[a+2]}))&&a.aa(c)}}
l.aa=function(a){var b=this.f[a];if(b){var c=this.g[b];if(0!=this.j)this.i.push(a),this.f[a+1]=aa;else{if(c){var d=vb(c,a);0<=d&&Array.prototype.splice.call(c,d,1)}delete this.f[a];delete this.f[a+1];delete this.f[a+2]}}return!!b};
l.pa=function(a,b){var c=this.g[a];if(c){for(var d=Array(arguments.length-1),e=1,f=arguments.length;e<f;e++)d[e-1]=arguments[e];if(this.A)for(e=0;e<c.length;e++){var g=c[e];je(this.f[g+1],this.f[g+2],d)}else{this.j++;try{for(e=0,f=c.length;e<f;e++)g=c[e],this.f[g+1].apply(this.f[g+2],d)}finally{if(this.j--,0<this.i.length&&0==this.j)for(;c=this.i.pop();)this.aa(c)}}return 0!=e}return!1};
function je(a,b,c){wd(function(){a.apply(b,c)})}
l.clear=function(a){if(a){var b=this.g[a];b&&(M(b,this.aa,this),delete this.g[a])}else this.f.length=0,this.g={}};
l.G=function(a){if(a){var b=this.g[a];return b?b.length:0}a=0;for(b in this.g)a+=this.G(b);return a};
l.K=function(){Q.S.K.call(this);this.clear();this.i.length=0};function ke(a){this.b=a}
C(ke,Fd);l=ke.prototype;l.isAvailable=function(){if(!this.b)return!1;try{return this.b.setItem("__sak","1"),this.b.removeItem("__sak"),!0}catch(a){return!1}};
l.set=function(a,b){try{this.b.setItem(a,b)}catch(c){if(0==this.b.length)throw"Storage mechanism: Storage disabled";throw"Storage mechanism: Quota exceeded";}};
l.get=function(a){a=this.b.getItem(a);if(!z(a)&&null!==a)throw"Storage mechanism: Invalid value was encountered";return a};
l.remove=function(a){this.b.removeItem(a)};
l.G=function(){return this.b.length};
l.R=function(a){var b=0,c=this.b,d=new cd;d.next=function(){if(b>=c.length)throw bd;var d=c.key(b++);if(a)return d;d=c.getItem(d);if(!z(d))throw"Storage mechanism: Invalid value was encountered";return d};
return d};
l.clear=function(){this.b.clear()};
l.key=function(a){return this.b.key(a)};function le(a){this.b=new Gd;if(a){a=kc(a);for(var b=a.length,c=0;c<b;c++){var d=a[c];this.b.set(me(d),d)}}}
function me(a){var b=typeof a;return"object"==b&&a||"function"==b?"o"+(a[ea]||(a[ea]=++fa)):b.substr(0,1)+a}
l=le.prototype;l.G=function(){return this.b.G()};
l.remove=function(a){return this.b.remove(me(a))};
l.clear=function(){this.b.clear()};
l.isEmpty=function(){return this.b.isEmpty()};
l.contains=function(a){a=me(a);return Id(this.b.f,a)};
l.D=function(){return this.b.D()};
l.equals=function(a){return this.G()==jc(a)&&ne(this,a)};
function ne(a,b){var c=jc(b);if(a.G()>c)return!1;!(b instanceof le)&&5<c&&(b=new le(b));return nc(a,function(a){var c=b;if(c.contains&&"function"==typeof c.contains)a=c.contains(a);else if(c.da&&"function"==typeof c.da)a=c.da(a);else if(x(c)||z(c))a=Bb(c,a);else a:{for(var d in c)if(c[d]==a){a=!0;break a}a=!1}return a})}
l.R=function(){return this.b.R(!1)};function oe(){var a,b,c,d;a=document;if(a.querySelectorAll&&a.querySelector)return a.querySelectorAll(".yt-embed-thumbnail");if(a.getElementsByClassName){var e=a.getElementsByClassName("yt-embed-thumbnail");return e}e=a.getElementsByTagName("*");d={};for(b=c=0;a=e[b];b++){var f=a.className;"function"==typeof f.split&&Bb(f.split(/\s+/),"yt-embed-thumbnail")&&(d[c++]=a)}d.length=c;return d}
function pe(a){return N&&!O("9")?(a=a.getAttributeNode("tabindex"),null!=a&&a.specified):a.hasAttribute("tabindex")}
function qe(a){a=a.tabIndex;return"number"==typeof a&&0<=a&&32768>a}
function re(a,b){for(var c=0;a;){if(b(a))return a;a=a.parentNode;c++}return null}
;function se(){var a=null;try{a=window.localStorage||null}catch(b){}this.b=a}
C(se,ke);function te(){var a=null;try{a=window.sessionStorage||null}catch(b){}this.b=a}
C(te,ke);var ue=t("yt.pubsub.instance_")||new Q;Q.prototype.subscribe=Q.prototype.subscribe;Q.prototype.unsubscribeByKey=Q.prototype.aa;Q.prototype.publish=Q.prototype.pa;Q.prototype.clear=Q.prototype.clear;r("yt.pubsub.instance_",ue,void 0);var ve=t("yt.pubsub.subscribedKeys_")||{};r("yt.pubsub.subscribedKeys_",ve,void 0);var we=t("yt.pubsub.topicToKeys_")||{};r("yt.pubsub.topicToKeys_",we,void 0);var xe=t("yt.pubsub.isSynchronous_")||{};r("yt.pubsub.isSynchronous_",xe,void 0);
var ye=t("yt.pubsub.skipSubId_")||null;r("yt.pubsub.skipSubId_",ye,void 0);function ze(a,b){var c=Ae();if(c){var d=c.subscribe(a,function(){if(!ye||ye!=d){var c=arguments,f;f=function(){ve[d]&&b.apply(window,c)};
try{xe[a]?f():oc(f,0)}catch(g){$b(g)}}},void 0);
ve[d]=!0;we[a]||(we[a]=[]);we[a].push(d)}}
function Be(a,b){var c=Ae();c&&c.publish.apply(c,arguments)}
function Ce(a){we[a]&&(a=we[a],M(a,function(a){ve[a]&&delete ve[a]}),a.length=0)}
function De(a){var b=Ae();if(b)if(b.clear(a),a)Ce(a);else for(var c in we)Ce(c)}
function Ae(){return t("yt.pubsub.instance_")}
;var Ee=t("yt.dom.getNextId_");if(!Ee){Ee=function(){return++Fe};
r("yt.dom.getNextId_",Ee,void 0);var Fe=0}function Ge(){var a=document,b;xb(["fullscreenEnabled","webkitFullscreenEnabled","mozFullScreenEnabled","msFullscreenEnabled"],function(c){b=a[c];return!!b})}
;var He={log_event:"events",log_interaction:"interactions"},Ie={},Je={},Ke=0,Le=t("yt.logging.transport.logsQueue_")||{};r("yt.logging.transport.logsQueue_",Le,void 0);
function Me(){window.clearTimeout(Ke);if(!Ua(Le)){for(var a in Le){var b=Ie[a];if(!b){b=Je[a];if(!b)continue;b=new b;Ie[a]=b}var c=b.b,c={client:{hl:c.Qa,gl:c.Pa,clientName:c.Oa,clientVersion:c.innertubeContextClientVersion}};E("DELEGATED_SESSION_ID")&&(c.user={onBehalfOfUser:E("DELEGATED_SESSION_ID")});var d={context:c};d.requestTimeMs=Math.round(D());d[He[a]]=Le[a];var c=a,e={},d={headers:{"Content-Type":"application/json","X-Goog-Visitor-Id":E("VISITOR_DATA")},L:d,Aa:"JSON",oa:e.oa,ea:e.ea,onError:e.onError,
timeout:e.timeout,withCredentials:!0};a:{var e=[],f=na(String(p.location.href)),g=p.__OVERRIDE_SID;null==g&&(g=(new La(document)).get("SID"));if(g&&(f=(g=0==f.indexOf("https:")||0==f.indexOf("chrome-extension:"))?p.__SAPISID:p.__APISID,null==f&&(f=(new La(document)).get(g?"SAPISID":"APISID")),f)){var g=g?"SAPISIDHASH":"APISIDHASH",h=String(p.location.href),e=h&&f&&g?[g,bc(na(h),f,e||null)].join(" "):null;break a}e=null}e&&(d.headers.Authorization=e,d.headers["X-Goog-AuthUser"]=E("SESSION_INDEX",0));
b="//"+b.b.gb+("/youtubei/"+b.b.innertubeApiVersion+"/"+c)+"?alt=json&key="+b.b.innertubeApiKey;c=d;c.method="POST";c.L||(c.L={});Ne(b,c);delete Le[a]}Ua(Le)||Oe()}}
function Oe(){window.clearTimeout(Ke);Ke=oc(Me,E("LOGGING_BATCH_TIMEOUT",1E4))}
;function Pe(a){if(!Qe&&!Re||!window.JSON)return null;var b;try{b=Qe.get(a)}catch(c){}if(!z(b))try{b=Re.get(a)}catch(c){}if(!z(b))return null;try{b=JSON.parse(b,void 0)}catch(c){}return b}
var Re,Se=new se;Re=Se.isAvailable()?new Ed(Se):null;var Qe,Te=new te;Qe=Te.isAvailable()?new Ed(Te):null;var Ta=t("yt.events.listeners_")||{};r("yt.events.listeners_",Ta,void 0);var Ue=t("yt.events.counter_")||{count:0};r("yt.events.counter_",Ue,void 0);function Ve(a,b,c){a.addEventListener&&("mouseenter"!=b||"onmouseenter"in document?"mouseleave"!=b||"onmouseenter"in document?"mousewheel"==b&&"MozBoxSizing"in document.documentElement.style&&(b="MozMousePixelScroll"):b="mouseout":b="mouseover");return Sa(function(d){return d[0]==a&&d[1]==b&&d[2]==c&&0==d[4]})}
function We(a,b,c){if(a&&(a.addEventListener||a.attachEvent)){var d=Ve(a,b,c);if(!d){var d=++Ue.count+"",e=!("mouseenter"!=b&&"mouseleave"!=b||!a.addEventListener||"onmouseenter"in document),f;f=e?function(d){d=new hb(d);if(!re(d.relatedTarget,function(b){return b==a}))return d.currentTarget=a,d.type=b,c.call(a,d)}:function(b){b=new hb(b);
b.currentTarget=a;return c.call(a,b)};
f=Zb(f);a.addEventListener?("mouseenter"==b&&e?b="mouseover":"mouseleave"==b&&e?b="mouseout":"mousewheel"==b&&"MozBoxSizing"in document.documentElement.style&&(b="MozMousePixelScroll"),a.addEventListener(b,f,!1)):a.attachEvent("on"+b,f);Ta[d]=[a,b,c,f,!1]}}}
function Xe(a){a&&("string"==typeof a&&(a=[a]),M(a,function(a){if(a in Ta){var b=Ta[a],d=b[0],e=b[1],f=b[3],b=b[4];d.removeEventListener?d.removeEventListener(e,f,b):d.detachEvent&&d.detachEvent("on"+e,f);delete Ta[a]}}))}
;function Ye(a,b,c,d,e,f,g){function h(){4==(k&&"readyState"in k?k.readyState:0)&&b&&Zb(b)(k)}
var k=jb&&jb();if(!("open"in k))return null;"onloadend"in k?k.addEventListener("loadend",h,!1):k.onreadystatechange=h;c=(c||"GET").toUpperCase();d=d||"";k.open(c,a,!0);f&&(k.responseType=f);g&&(k.withCredentials=!0);f="POST"==c;if(e=Ze(a,e))for(var m in e)k.setRequestHeader(m,e[m]),"content-type"==m.toLowerCase()&&(f=!1);f&&k.setRequestHeader("Content-Type","application/x-www-form-urlencoded");k.send(d);return k}
function Ze(a,b){b=b||{};var c;c||(c=window.location.href);var d=Tb(1,a),e=Sb(Tb(3,a));d&&e?(d=c,c=a.match(Rb),d=d.match(Rb),c=c[3]==d[3]&&c[1]==d[1]&&c[4]==d[4]):c=e?Sb(Tb(3,c))==e&&(Number(Tb(4,c))||null)==(Number(Tb(4,a))||null):!0;for(var f in $e){if((e=d=E($e[f]))&&!(e=c)){var e=f,g=E("CORS_HEADER_WHITELIST")||{},h=Sb(Tb(3,a));e=h?(g=g[h])?Bb(g,e):!1:!0}e&&(b[f]=d)}return b}
function af(a,b){var c=E("XSRF_FIELD_NAME",void 0),d;b.headers&&(d=b.headers["Content-Type"]);return!b.Kb&&(!Sb(Tb(3,a))||b.withCredentials||Sb(Tb(3,a))==document.location.hostname)&&"POST"==b.method&&(!d||"application/x-www-form-urlencoded"==d)&&!(b.L&&b.L[c])}
function Ne(a,b){var c=b.format||"JSON";b.Lb&&(a=document.location.protocol+"//"+document.location.hostname+(document.location.port?":"+document.location.port:"")+a);var d=E("XSRF_FIELD_NAME",void 0),e=E("XSRF_TOKEN",void 0),f=b.fb;f&&(f[d]&&delete f[d],a=sc(a,f||{},!0));var g=b.postBody||"",f=b.L;af(a,b)&&(f||(f={}),f[d]=e);f&&z(g)&&(d=qc(g),Xa(d,f),g=b.Aa&&"JSON"==b.Aa?JSON.stringify(d):Xb(d));var h=!1,k,m=Ye(a,function(a){if(!h){h=!0;k&&window.clearTimeout(k);var d=kb(a),e=null;if(d||400<=a.status&&
500>a.status)e=bf(c,a,b.Jb);if(d)a:if(204==a.status)d=!0;else{switch(c){case "XML":d=0==parseInt(e&&e.return_code,10);break a;case "RAW":d=!0;break a}d=!!e}var e=e||{},f=b.context||p;d?b.ea&&b.ea.call(f,a,e):b.onError&&b.onError.call(f,a,e);b.Xa&&b.Xa.call(f,a,e)}},b.method,g,b.headers,b.responseType,b.withCredentials);
b.oa&&0<b.timeout&&(k=oc(function(){h||(h=!0,m.abort(),window.clearTimeout(k),b.oa.call(b.context||p,m))},b.timeout))}
function bf(a,b,c){var d=null;switch(a){case "JSON":a=b.responseText;b=b.getResponseHeader("Content-Type")||"";a&&0<=b.indexOf("json")&&(d=Ca(a));break;case "XML":if(b=(b=b.responseXML)?cf(b):null)d={},M(b.getElementsByTagName("*"),function(a){d[a.tagName]=df(a)})}c&&ef(d);
return d}
function ef(a){if(da(a))for(var b in a){var c;(c="html_content"==b)||(c=b.length-5,c=0<=c&&b.indexOf("_html",c)==c);if(c){c=b;var d;d=Dd(a[b]);a[c]=d}else ef(a[b])}}
function cf(a){return a?(a=("responseXML"in a?a.responseXML:a).getElementsByTagName("root"))&&0<a.length?a[0]:null:null}
function df(a){var b="";M(a.childNodes,function(a){b+=a.nodeValue});
return b}
var $e={"X-Goog-Visitor-Id":"SANDBOXED_VISITOR_ID","X-YouTube-Client-Name":"INNERTUBE_CONTEXT_CLIENT_NAME","X-YouTube-Client-Version":"INNERTUBE_CONTEXT_CLIENT_VERSION","X-Youtube-Identity-Token":"ID_TOKEN","X-YouTube-Page-CL":"PAGE_CL","X-YouTube-Page-Label":"PAGE_BUILD_LABEL","X-YouTube-Variants-Checksum":"VARIANTS_CHECKSUM"};function ff(a,b,c,d,e){c={name:c||E("INNERTUBE_CONTEXT_CLIENT_NAME",1),version:d||E("INNERTUBE_CONTEXT_CLIENT_VERSION",void 0)};e=window&&window.yterr||e||!1;if(a&&e&&!(5<=gf)){e=a.stacktrace;d=a.columnNumber;var f=t("window.location.href");if(z(a))a={message:a,name:"Unknown error",lineNumber:"Not available",fileName:f,stack:"Not available"};else{var g,h,k=!1;try{g=a.lineNumber||a.line||"Not available"}catch(v){g="Not available",k=!0}try{h=a.fileName||a.filename||a.sourceURL||p.$googDebugFname||f}catch(v){h=
"Not available",k=!0}a=!k&&a.lineNumber&&a.fileName&&a.stack&&a.message&&a.name?a:{message:a.message||"Not available",name:a.name||"UnknownError",lineNumber:g,fileName:h,stack:a.stack||"Not available"}}e=e||a.stack;g=a.lineNumber.toString();isNaN(g)||isNaN(d)||(g=g+":"+d);if(!(hf[a.message]||0<=e.indexOf("/YouTubeCenter.js")||0<=e.indexOf("/mytube.js"))){b={fb:{a:"logerror",t:"jserror",type:a.name,msg:a.message.substr(0,1E3),line:g,level:b||"ERROR"},L:{url:E("PAGE_NAME",window.location.href),file:a.fileName},
method:"POST"};e&&(b.L.stack=e);for(var m in c)b.L["client."+m]=c[m];if(m=E("LATEST_ECATCHER_SERVICE_TRACKING_PARAMS",void 0))for(var n in m)b.L[n]=m[n];Ne("/error_204",b);hf[a.message]=!0;gf++}}}
var hf={},gf=0;function jf(){this.b={apiaryHost:ma("APIARY_HOST"),Hb:ma("APIARY_HOST_FIRSTPARTY"),gapiHintOverride:E("GAPI_HINT_OVERRIDE"),gapiHintParams:ma("GAPI_HINT_PARAMS"),innertubeApiKey:ma("INNERTUBE_API_KEY"),innertubeApiVersion:ma("INNERTUBE_API_VERSION"),Oa:E("INNERTUBE_CONTEXT_CLIENT_NAME","WEB"),innertubeContextClientVersion:ma("INNERTUBE_CONTEXT_CLIENT_VERSION"),Qa:ma("INNERTUBE_CONTEXT_HL"),Pa:ma("INNERTUBE_CONTEXT_GL"),gb:ma("XHR_APIARY_HOST")}}
;function kf(){if(null==t("_lact",window)){var a=parseInt(E("LACT"),10),a=isFinite(a)?B()-Math.max(a,0):-1;r("_lact",a,window);-1==a&&lf();We(document,"keydown",lf);We(document,"keyup",lf);We(document,"mousedown",lf);We(document,"mouseup",lf);ze("page-mouse",lf);ze("page-scroll",lf);ze("page-resize",lf)}}
function lf(){null==t("_lact",window)&&(kf(),t("_lact",window));var a=B();r("_lact",a,window);Be("USER_ACTIVE")}
;function mf(a,b,c){var d={};d.eventTimeMs=Math.round(c||D());d[a]=b;ac("web_gel_lact")&&(a=t("_lact",window),a=null==a?-1:Math.max(B()-a,0),d.context={lastActivityMs:a});Le.log_event=Le.log_event||[];a=Le.log_event;a.push(d);Je.log_event=jf;a.length>=(Number(ac("web_logging_max_batch")||0)||20)?Me():Oe()}
;var nf=t("yt.logging.latency.usageStats_")||{};r("yt.logging.latency.usageStats_",nf,void 0);var of=0;function pf(a){nf[a]=nf[a]||{count:0};var b=nf[a];b.count++;b.time=D();of||(of=ud());return 10<b.count?(11==b.count&&ff(Error("CSI data exceeded logging limit with key: "+a)),!0):!1}
function vd(){var a=D(),b;for(b in nf)6E4<a-nf[b].time&&delete nf[b];of=0}
;function qf(a){return a?a.dataset?a.dataset[rf()]:a.getAttribute("data-loaded"):null}
var sf={};function rf(){return sf.loaded||(sf.loaded="loaded".replace(/\-([a-z])/g,function(a,b){return b.toUpperCase()}))}
;function tf(){var a=E("PLAYER_CONFIG",void 0)||{};this.url=a.url||"";this.urlV9As2=a.url_v9as2||"";this.args=a.args||Va(uf);this.assets=a.assets||{};this.attrs=a.attrs||Va(vf);this.params=a.params||Va(wf);this.minVersion=a.min_version||"8.0.0";this.fallback=a.fallback||null;this.fallbackMessage=a.fallbackMessage||null;this.html5=!!a.html5;this.disable=a.disable||{};this.loaded=!!a.loaded;this.messages=a.messages||{}}
var uf={enablejsapi:1},vf={},wf={allowscriptaccess:"always",allowfullscreen:"true",bgcolor:"#000000"};var xf=window.yt&&window.yt.msgs_||window.ytcfg&&window.ytcfg.msgs||{};r("yt.msgs_",xf,void 0);function yf(a){a=(a=a in xf?xf[a]:void 0)||"";var b={},c;for(c in b)a=a.replace(new RegExp("\\$"+c,"gi"),function(){return b[c]});
return a}
;var zf=Ld||Md;function Af(){return Bf("android")&&Bf("chrome")&&!(Bf("trident/")||Bf("edge/"))}
function Bf(a){var b=J;return b?0<=b.toLowerCase().indexOf(a):!1}
;function Cf(a,b){var c=Df(a),d=document.getElementById(c),e=d&&qf(d),f=d&&!e;e?b&&b():(b&&(ze(c,b),b[ea]||(b[ea]=++fa)),f||(d=Ef(a,c,function(){if(!qf(d)){var a=d;a&&(a.dataset?a.dataset[rf()]="true":a.setAttribute("data-loaded","true"));Be(c);oc(ia(De,c),0)}})))}
function Ef(a,b,c){var d=document.createElement("script");d.id=b;d.onload=function(){c&&setTimeout(c,0)};
d.onreadystatechange=function(){switch(d.readyState){case "loaded":case "complete":d.onload()}};
d.src=a;a=document.getElementsByTagName("head")[0]||document.body;a.insertBefore(d,a.firstChild);return d}
function Df(a){var b=document.createElement("a");a instanceof Yc||a instanceof Yc||(a=a.za?a.xa():String(a),$c.test(a)||(a="about:invalid#zClosurez"),a=ad(a));a instanceof Yc&&a.constructor===Yc&&a.f===Zc?a=a.b:(ba(a),a="type_error:SafeUrl");b.href=a;for(var b=b.href.replace(/^[a-zA-Z]+:\/\//,"//"),c=a=0;c<b.length;++c)a=31*a+b.charCodeAt(c)>>>0;return"js-"+a}
var Ff=/\.vflset|-vfl[a-zA-Z0-9_+=-]+/,Gf=/-[a-zA-Z]{2,3}_[a-zA-Z]{2,3}(?=(\/|$))/;var Hf={},If=0;function Jf(a,b){a&&(E("USE_NET_AJAX_FOR_PING_TRANSPORT",!1)?Ye(a,b):Kf(a,b))}
function Kf(a,b){var c=new Image,d=""+If++;Hf[d]=c;c.onload=c.onerror=function(){b&&Hf[d]&&b();delete Hf[d]};
c.src=a}
;function Lf(a,b){var c=Va(b);return new P(function(b,e){c.ea=function(a){kb(a)?b(a):e(new Mf("Request failed, status="+a.status,"net.badstatus",a))};
c.onError=function(a){e(new Mf("Unknown request error","net.unknown",a))};
c.oa=function(a){e(new Mf("Request timed out","net.timeout",a))};
Ne(a,c)})}
function Nf(a,b){function c(e,f,g){return Xd(e,function(e){return 0>=f||403===e.b.status?Vd(new Mf("Request retried too many times","net.retryexhausted",e.b)):d(g).then(function(){return c(Lf(a,b),f-1,Math.pow(2,4-f+1)*g)})})}
function d(a){return new P(function(b){setTimeout(b,a)})}
return c(Lf(a,b),3,1E3)}
function Mf(a,b,c){za.call(this,a+", errorCode="+b);this.errorCode=b;this.b=c}
C(Mf,za);Mf.prototype.name="PromiseAjaxError";function Of(a){I.call(this);this.f={};this.i={};this.element=Pf(this,a)}
C(Of,I);
function Pf(a,b,c){if(u(b)){c=0;var d=document.createElement(String(b[c++]));if(z(b[c])){var e=b[c++];if(e=Qf(a,d,"class",e))Rf(a,d,"class",e),a.f[e]=d}else if(u(b[c])){for(var f=b[c++],e=0;e<f.length;e++)a.f[f[e]]=d;Rf(a,d,"class",f.join(" "))}for(;c<b.length;c++){var g=b[c];u(g)||g&&g.F?(e=Pf(a,g),d.appendChild(e)):da(g)?g.element?d.appendChild(g.element):Sf(a,d,g):z(g)&&(g=Qf(a,d,"child",g),null!=g&&d.appendChild(document.createTextNode(String(g))))}}else{d=(c=c||"svg"==b.F)?document.createElementNS("http://www.w3.org/2000/svg",b.F):
document.createElement(String(b.F));if(e=b.ga){if(e=Qf(a,d,"class",e))Rf(a,d,"class",e),a.f[e]=d}else if(f=b.qa){for(e=0;e<f.length;e++)a.f[f[e]]=d;Rf(a,d,"class",f.join(" "))}if(f=b.ca)for(var h=0,e=0;e<f.length;e++)if(g=f[e])if(z(g))g=Qf(a,d,"child",g),null!=g&&d.appendChild(document.createTextNode(String(g)));else{var k=g,g=Pf(a,k,c);d.appendChild(g);k.Mb&&(k=Of.b(),g.id=k,g=document.createElementNS("http://www.w3.org/2000/svg","use"),g.setAttribute("class","ytp-svg-shadow"),g.setAttributeNS("http://www.w3.org/1999/xlink",
"href","#"+k),k=h++,d.insertBefore(g,d.childNodes[k]||null))}(b=b.fa)&&Sf(a,d,b)}return d}
function Qf(a,b,c,d){return"{{"==d.substr(0,2)?(a.i[d]=[b,c],null):d}
Of.prototype.update=function(a){for(var b in a)Tf(this,b,a[b])};
function Tf(a,b,c){(b=a.i["{{"+b+"}}"])&&Rf(a,b[0],b[1],c)}
function Uf(a){return u(a)&&z(a[0])||da(a)&&z(a.F)}
function Rf(a,b,c,d){if("child"==c){for(;c=b.firstChild;)b.removeChild(c);if(!u(d)||Uf(d))d=[d];c=d;d=[];for(var e=0;e<c.length;e++){var f=c[e];if(null!=f)if(!f.nodeType||1!=f.nodeType&&3!=f.nodeType)if(Uf(f))d.push(Pf(a,f));else if(f.element)d.push(f.element);else if(z(f)&&-1!=f.indexOf("\n"))for(var f=f.split("\n"),g=0;g<f.length;g++)0<g&&d.push(document.createElement("BR")),d.push(document.createTextNode(String(f[g])));else d.push(document.createTextNode(String(f)));else d.push(f)}for(a=0;a<d.length;a++)b.appendChild(d[a])}else"style"==
c?b.style.cssText=d?d:"":null===d?b.removeAttribute(c):b.setAttribute(c,d.toString())}
function Sf(a,b,c){for(var d in c){var e=c[d];null!=e&&Rf(a,b,d,z(e)?Qf(a,b,d,e):e)}}
Of.prototype.K=function(){this.f={};this.i={};var a=this.element;a&&a.parentNode&&a.parentNode.removeChild(a);Of.S.K.call(this)};
Of.f=1;Of.b=function(){return"ytp-svg-"+Of.f++};function Vf(a){Of.call(this,a);this.j=!0;this.g=[]}
C(Vf,Of);Vf.prototype.show=function(){if(!this.j){var a=this.element;a&&(a.style.display="");this.j=!0}};
Vf.prototype.focus=function(){var a=this.element;("A"==a.tagName||"INPUT"==a.tagName||"TEXTAREA"==a.tagName||"SELECT"==a.tagName||"BUTTON"==a.tagName?!a.disabled&&(!pe(a)||qe(a)):pe(a)&&qe(a))&&N&&(!ca(a.getBoundingClientRect)||N&&null==a.parentElement||a.getBoundingClientRect());this.element.focus()};
Vf.prototype.K=function(){for(;this.g.length;){var a=this.g.pop();a.target.removeEventListener(a.type,a.listener)}Vf.S.K.call(this)};function S(){I.call(this);this.j=new Q;lb(this,ia(mb,this.j))}
C(S,I);S.prototype.subscribe=function(a,b,c){return this.b?0:this.j.subscribe(a,b,c)};
S.prototype.aa=function(a){return this.b?!1:this.j.aa(a)};
S.prototype.i=function(a,b){this.b||this.j.pa.apply(this.j,arguments)};var Wf=void 0;var Xf={uJ:function(a,b){a.splice(0,b)},
iX:function(a,b){var c=a[0];a[0]=a[b%a.length];a[b]=c},
QS:function(a){a.reverse()}};
function Yf(a){a=a.split("");Xf.uJ(a,2);Xf.iX(a,64);Xf.QS(a,49);Xf.uJ(a,3);return a.join("")}
;function Zf(a){this.g=Math.exp(Math.log(.5)/a);this.b=0}
Zf.prototype.f=function(a,b){var c=Math.pow(this.g,a);this.b=b*(1-c)+c*this.b};function $f(a){this.j=0;this.i=a;this.l="index";this.b=0;this.g=[]}
$f.prototype.f=function(a,b){ag(this);this.g.push({index:this.j++,weight:a,value:b});this.b+=a;for(ag(this);this.b>this.i;){var c=this.b-this.i,d=this.g[0];d.weight<=c?(this.b-=d.weight,this.g.shift()):(this.b-=c,d.weight-=c)}};
function ag(a){"index"!=a.l&&(a.l="index",Jb(a.g))}
;var bg={auto:0,tiny:144,light:144,small:240,medium:360,large:480,hd720:720,hd1080:1080,hd1440:1440,hd2160:2160,hd2880:2880,highres:4320},cg="highres hd2880 hd2160 hd1440 hd1080 hd720 large medium small tiny".split(" ");function dg(a){this.b=a;D();this.l=new $f(4);this.g=new Zf(4);this.i=this.b.i?new Zf(this.b.b):new $f(this.b.b);this.f=this.b.j?new Zf(this.b.g):null;a=Pe("yt-player-bandwidth")||{};var b=0<a.byterate?a.byterate:this.b.l;this.i.f(this.b.f,b);this.f&&this.f.f(this.b.f,0<a.ltByterate?a.ltByterate:b);0<a.delay&&this.l.f(1,Math.min(+a.delay,2));0<a.stall?this.g.f(1,+a.stall):0<a.tailDelay&&this.g.f(1,+a.tailDelay);D()}
;function eg(){this.b=17;this.l=13E4;this.f=.5;this.i=!1;this.o=!0;this.j=!1;this.g=60}
;function fg(a){this.spatialAudioType=a||0}
;function gg(a,b,c,d,e,f,g,h,k,m){this.width=a;this.height=b;if(!f)a:{f=Math.max(a,b);a=Math.min(a,b);b=cg[0];for(k=0;k<cg.length;k++){var n=cg[k],v=bg[n];if(f>=Math.floor(16*v/9)*gg.prototype.b||a>=v*gg.prototype.b){f=b;break a}b=n}f="tiny"}this.quality=f;this.isAccelerated=!!g;this.fps=c||0;this.f=e||0;this.projectionType=d||0;(c=h)||(c=this.fps,d=this.projectionType,e=bg[this.quality],c=0==e?yf("YTP_AUTO"):e+(2==d||3==d?"s":"p")+(55<c?"60":49<c?"50":39<c?"48":""));this.qualityLabel=c;this.primaries=
m||""}
gg.prototype.b=1.3;function hg(a,b,c,d,e,f){this.id=a;this.b=0<=b.indexOf("/mp4")?1:0<=b.indexOf("/webm")?2:0<=b.indexOf("/x-flv")?3:0<=b.indexOf("/vtt")?4:0;this.mimeType=b;this.f=f||0;this.audio=c||null;this.video=d||null;this.g=e||null}
function ig(a){return 0<=a.indexOf("opus")||0<=a.indexOf("vorbis")||0<=a.indexOf("mp4a")}
function jg(a){return 0<=a.indexOf("vp9")||0<=a.indexOf("vp8")||0<=a.indexOf("avc1")}
;function kg(a,b,c){this.b=a||0;this.g=b||0;this.f=c}
kg.prototype.equals=function(a){return this.b==a.b&&this.g==a.g&&this.f==a.f};
var lg=new kg(bg.auto||0,bg.auto||0,!1);kg.prototype.isLocked=function(){return this.f&&!!this.b&&this.b==this.g};var mg={ub:1,vb:2,wb:3};function ng(){S.call(this);this.f={}}
C(ng,S);ng.prototype.remove=function(a){var b=this.get(a);delete this.f[a];return b};
ng.prototype.get=function(a){return this.f[a]||null};
ng.prototype.isEmpty=function(){return Ua(this.f)};var og={"ad-trueview-indisplay-pv":6,"ad-trueview-insearch":7},pg={"ad-trueview-indisplay-pv":2,"ad-trueview-insearch":2},qg=/^(\d*)_((\d*)_?(\d*))$/;function rg(a){a=a.match(qg);var b=a[3];return!(1==a[1]&&8==b)&&(7==b||8==b||10==b)}
;var sg,tg;var ug=J,ug=ug.toLowerCase();if(-1!=ug.indexOf("android")){var vg=ug.match(/android\D*(\d\.\d)[^\;|\)]*[\;\)]/);if(vg)sg=Number(vg[1]);else{var wg={cupcake:1.5,donut:1.6,eclair:2,froyo:2.2,gingerbread:2.3,honeycomb:3,"ice cream sandwich":4,jellybean:4.1,kitkat:4.4,lollipop:5.1,marshmallow:6,nougat:7.1},xg=ug.match("("+Ra(wg).join("|")+")");sg=xg?wg[xg[0]]:0}}else sg=void 0;tg=0<=sg;var yg=J,zg=yg.match(/\((BB10|PlayBook|BlackBerry);/);!zg||2>zg.length||yg.match(/Version\/(\d+\.\d+)/);J.match(/Mozilla\/[\d\.]+ \(Mobile;.* rv:([\d\.]+)\) Gecko\/[\d\.]+ Firefox\/[\d\.]+/);var Ag;var Bg=J,Cg=Bg.match(/\((iPad|iPhone|iPod)( Simulator)?;/);if(!Cg||2>Cg.length)Ag=void 0;else{var Dg=Bg.match(/\((iPad|iPhone|iPod)( Simulator)?; (U; )?CPU (iPhone )?OS (\d+_\d)[_ ]/);Ag=Dg&&6==Dg.length?Number(Dg[5].replace("_",".")):0}0<=Ag&&0<=J.search("Safari")&&J.search("Version");function Eg(){var a=t("yt.player.utils.videoElement_");a||(a=document.createElement("VIDEO"),r("yt.player.utils.videoElement_",a,void 0));return a}
;function T(a,b){return void 0==b?a:"1"==b?!0:!1}
function Fg(a,b,c){for(var d in c)if(c[d]==b)return c[d];return a}
function U(a,b){return void 0==b?a:Number(b)}
function V(a,b){return void 0==b?a:b.toString()}
function Gg(a,b){var c=bg.auto,d=bg[b];return d>bg.medium?new kg(d,c,!1):d>=c?new kg(c,d,!1):a}
;function Hg(a,b){this.b=this.A=this.g="";this.i=null;this.j=this.f="";this.o=!1;var c;a instanceof Hg?(this.o=q(b)?b:a.o,Ig(this,a.g),this.A=a.A,this.b=a.b,Jg(this,a.i),this.f=a.f,Kg(this,Lg(a.l)),this.j=a.j):a&&(c=String(a).match(Rb))?(this.o=!!b,Ig(this,c[1]||"",!0),this.A=Mg(c[2]||""),this.b=Mg(c[3]||"",!0),Jg(this,c[4]),this.f=Mg(c[5]||"",!0),Kg(this,c[6]||"",!0),this.j=Mg(c[7]||"")):(this.o=!!b,this.l=new Ng(null,0,this.o))}
Hg.prototype.toString=function(){var a=[],b=this.g;b&&a.push(Og(b,Pg,!0),":");var c=this.b;if(c||"file"==b)a.push("//"),(b=this.A)&&a.push(Og(b,Pg,!0),"@"),a.push(encodeURIComponent(String(c)).replace(/%25([0-9a-fA-F]{2})/g,"%$1")),c=this.i,null!=c&&a.push(":",String(c));if(c=this.f)this.b&&"/"!=c.charAt(0)&&a.push("/"),a.push(Og(c,"/"==c.charAt(0)?Qg:Rg,!0));(c=this.l.toString())&&a.push("?",c);(c=this.j)&&a.push("#",Og(c,Sg));return a.join("")};
Hg.prototype.resolve=function(a){var b=new Hg(this),c=!!a.g;c?Ig(b,a.g):c=!!a.A;c?b.A=a.A:c=!!a.b;c?b.b=a.b:c=null!=a.i;var d=a.f;if(c)Jg(b,a.i);else if(c=!!a.f){if("/"!=d.charAt(0))if(this.b&&!this.f)d="/"+d;else{var e=b.f.lastIndexOf("/");-1!=e&&(d=b.f.substr(0,e+1)+d)}e=d;if(".."==e||"."==e)d="";else if(-1!=e.indexOf("./")||-1!=e.indexOf("/.")){for(var d=0==e.lastIndexOf("/",0),e=e.split("/"),f=[],g=0;g<e.length;){var h=e[g++];"."==h?d&&g==e.length&&f.push(""):".."==h?((1<f.length||1==f.length&&
""!=f[0])&&f.pop(),d&&g==e.length&&f.push("")):(f.push(h),d=!0)}d=f.join("/")}else d=e}c?b.f=d:c=""!==a.l.toString();c?Kg(b,Lg(a.l)):c=!!a.j;c&&(b.j=a.j);return b};
function Ig(a,b,c){a.g=c?Mg(b,!0):b;a.g&&(a.g=a.g.replace(/:$/,""))}
function Jg(a,b){if(b){b=Number(b);if(isNaN(b)||0>b)throw Error("Bad port number "+b);a.i=b}else a.i=null}
function Kg(a,b,c){b instanceof Ng?(a.l=b,Tg(a.l,a.o)):(c||(b=Og(b,Ug)),a.l=new Ng(b,0,a.o))}
function Mg(a,b){return a?b?decodeURI(a.replace(/%25/g,"%2525")):decodeURIComponent(a):""}
function Og(a,b,c){return z(a)?(a=encodeURI(a).replace(b,Vg),c&&(a=a.replace(/%25([0-9a-fA-F]{2})/g,"%$1")),a):null}
function Vg(a){a=a.charCodeAt(0);return"%"+(a>>4&15).toString(16)+(a&15).toString(16)}
var Pg=/[#\/\?@]/g,Rg=/[\#\?:]/g,Qg=/[\#\?]/g,Ug=/[\#\?@]/g,Sg=/#/g;function Ng(a,b,c){this.f=this.b=null;this.g=a||null;this.i=!!c}
function Wg(a){a.b||(a.b=new Gd,a.f=0,a.g&&Ub(a.g,function(b,c){Xg(a,db(b),c)}))}
l=Ng.prototype;l.G=function(){Wg(this);return this.f};
function Xg(a,b,c){Wg(a);a.g=null;b=Yg(a,b);var d=a.b.get(b);d||a.b.set(b,d=[]);d.push(c);a.f=a.f+1}
l.remove=function(a){Wg(this);a=Yg(this,a);return Id(this.b.f,a)?(this.g=null,this.f=this.f-this.b.get(a).length,this.b.remove(a)):!1};
l.clear=function(){this.b=this.g=null;this.f=0};
l.isEmpty=function(){Wg(this);return 0==this.f};
function Zg(a,b){Wg(a);b=Yg(a,b);return Id(a.b.f,b)}
l.da=function(a){var b=this.D();return Bb(b,a)};
l.P=function(){Wg(this);for(var a=this.b.D(),b=this.b.P(),c=[],d=0;d<b.length;d++)for(var e=a[d],f=0;f<e.length;f++)c.push(b[d]);return c};
l.D=function(a){Wg(this);var b=[];if(z(a))Zg(this,a)&&(b=Cb(b,this.b.get(Yg(this,a))));else{a=this.b.D();for(var c=0;c<a.length;c++)b=Cb(b,a[c])}return b};
l.set=function(a,b){Wg(this);this.g=null;a=Yg(this,a);Zg(this,a)&&(this.f=this.f-this.b.get(a).length);this.b.set(a,[b]);this.f=this.f+1;return this};
l.get=function(a,b){var c=a?this.D(a):[];return 0<c.length?String(c[0]):b};
l.toString=function(){if(this.g)return this.g;if(!this.b)return"";for(var a=[],b=this.b.P(),c=0;c<b.length;c++)for(var d=b[c],e=encodeURIComponent(String(d)),d=this.D(d),f=0;f<d.length;f++){var g=e;""!==d[f]&&(g+="="+encodeURIComponent(String(d[f])));a.push(g)}return this.g=a.join("&")};
function Lg(a){var b=new Ng;b.g=a.g;a.b&&(b.b=new Gd(a.b),b.f=a.f);return b}
function Yg(a,b){var c=String(b);a.i&&(c=c.toLowerCase());return c}
function Tg(a,b){b&&!a.i&&(Wg(a),a.g=null,a.b.forEach(function(a,b){var c=b.toLowerCase();b!=c&&(this.remove(b),this.remove(c),0<a.length&&(this.g=null,this.b.set(Yg(this,c),Db(a)),this.f=this.f+a.length))},a));
a.i=b}
l.extend=function(a){for(var b=0;b<arguments.length;b++)mc(arguments[b],function(a,b){Xg(this,b,a)},this)};var $g=/^http:\/\/0\.[a-z0-9\-_]+\.[a-z0-9\-_]+\.l2gfe\.[a-z0-9_]+\.([a-z]{2}|i)\.borg\.google\.com(:[0-9]+)?\/|^https?:\/\/((?:uytfe\.corp|dev-uytfe\.corp|uytfe\.sandbox)\.google\.com\/|([-\w]*www[-\w]*\.|[-\w]*web[-\w]*\.|[-\w]*canary[-\w]*\.|[-\w]*dev[-\w]*\.|[-\w]{1,3}\.)+youtube(education|-nocookie)?\.com\/|([a-z]+\.)?[a-z0-9\-]{1,63}\.([a-z]{3}|i)\.corp\.google\.com(:[0-9]+)?\/|(docs|drive)\.google\.com\/(a\/[^/\\%]+\/|)|[A-Za-z0-9]+(-v6)?\.prod\.google\.com(:[0-9]+)?\/|m?web-ppg\.corp\.google\.com\/|play\.google\.com\/)/,
ah=/^https?:\/\/([A-Za-z0-9-]{1,63}\.)*(corp\.google\.com|docs\.google\.com|drive\.google\.com|prod\.google\.com|sandbox\.google\.com|plus\.google\.com|mail\.google\.com|youtube\.com|youtubeeducation\.com)(:[0-9]+)?\//,bh=/^https?:\/\/([A-Za-z0-9-]{1,63}\.)*(corp\.google\.com|borg\.google\.com|prod\.google\.com|video\.google\.com|youtube\.com|youtube\.googleapis\.com|youtube\-nocookie\.com|youtubeeducation\.com)(:[0-9]+)?\/\/*embed(\/+|\?|#|$)/,ch=/^((http(s)?):)?\/\/((((lh[3-6](-tt|-d[a-g,z])?\.((ggpht)|(googleusercontent)|(google)))|(([1-4]\.bp\.blogspot)|(bp[0-3]\.blogger))|((((cp|ci|gp)[3-6])|(ap[1-2]))\.(ggpht|googleusercontent))|(gm[1-4]\.ggpht)|(((yt[3-4])|(sp[1-3]))\.(ggpht|googleusercontent)))\.com)|(dp[3-6]\.googleusercontent\.cn)|(dp4\.googleusercontent\.com)|(photos\-image\-(dev|qa)(-auth)?\.corp\.google\.com)|((dev|dev2|dev3|qa|qa2|qa3|qa-red|qa-blue|canary)[-.]lighthouse\.sandbox\.google\.com\/image)|(image\-dev\-lighthouse(-auth)?\.sandbox\.google\.com(\/image)?))\/|^https?:\/\/(([A-Za-z0-9-]{1,63}\.)*(corp\.google\.com|borg\.google\.com|docs\.google\.com|drive\.google\.com|googleplex\.com|play\.google\.com|prod\.google\.com|sandbox\.google\.com|plus\.google\.com|video\.google\.com|youtube\.com|ytimg\.com)(:[0-9]+)?\/|s2\.googleusercontent\.com\/s2\/favicons\?|yt[3-4]\.ggpht\.com\/)/,
dh=/^https?:\/\/(googleads\.g\.doubleclick\.net\/(aclk|pagead\/conversion)|www\.google\.com\/(aclk|pagead\/conversion)|www\.googleadservices\.com\/(aclk|pagead\/(aclk|conversion)))/,eh=/^((http(s)?):)?\/\/((((lh[3-6](-tt|-d[a-g,z])?\.((ggpht)|(googleusercontent)|(google)))|(([1-4]\.bp\.blogspot)|(bp[0-3]\.blogger))|((((cp|ci|gp)[3-6])|(ap[1-2]))\.(ggpht|googleusercontent))|(gm[1-4]\.ggpht)|(((yt[3-4])|(sp[1-3]))\.(ggpht|googleusercontent)))\.com)|(dp[3-6]\.googleusercontent\.cn)|(dp4\.googleusercontent\.com)|(photos\-image\-(dev|qa)(-auth)?\.corp\.google\.com)|((dev|dev2|dev3|qa|qa2|qa3|qa-red|qa-blue|canary)[-.]lighthouse\.sandbox\.google\.com\/image)|(image\-dev\-lighthouse(-auth)?\.sandbox\.google\.com(\/image)?))\/|^https?:\/\/([A-Za-z0-9-]{1,63}\.)*(ba\.l\.google\.com|c\.googlesyndication\.com|corp\.google\.com|borg\.google\.com|docs\.google\.com|drive\.google\.com|googleplex\.com|googlevideo\.com|play\.google\.com|prod\.google\.com|sandbox\.google\.com|plus\.google\.com|mail\.google\.com|ed\.video\.google\.com|vp\.video\.l\.google\.com|youtube\.com|youtubeeducation\.com|xfx7\.com)(:[0-9]+)?\//,
fh=/^https?:\/\/(([A-Za-z0-9-]{1,63}\.)*(imasdk\.googleapis\.com|2mdn\.net|googlesyndication\.com|corp\.google\.com|borg\.google\.com|googleads\.g\.doubleclick\.net|prod\.google\.com|static\.doubleclick\.net|static\.googleadsserving\.cn|studioapi\.doubleclick\.net|youtube\.com|youtube\.googleapis\.com|youtube\-nocookie\.com|youtubeeducation\.com|ytimg\.com)(:[0-9]+)?\/|lightbox-(demos|builder)\.appspot\.com\/|s[01](qa)?\.2mdn\.net\/ads\/richmedia\/studio\/mu\/templates\/tetris|tpc\.googlesyndication\.com\/safeframe\/|www\.gstatic\.com\/doubleclick\/studio\/innovation\/h5\/layouts\/tetris|www\.gstatic\.com\/doubleclick\/studio\/innovation\/ytplayer)/,
gh=/^https?:\/\/(([A-Za-z0-9-]{1,63}\.)*(imasdk\.googleapis\.com|corp\.google\.com|borg\.google\.com|docs\.google\.com|drive\.google\.com|googleads\.g\.doubleclick\.net|googleplex\.com|play\.google\.com|prod\.google\.com|sandbox\.google\.com|photos\.google\.com|picasaweb\.google\.com|get\.google\.com|lh2\.google\.com|plus\.google\.com|spaces\.google\.com|books\.googleusercontent\.com|blogger\.com|mail\.google\.com|talkgadget\.google\.com|survey\.g\.doubleclick\.net|youtube\.com|youtube\.googleapis\.com|youtube\-nocookie\.com|youtubeeducation\.com|vevo\.com)(:[0-9]+)?\/|(www\.|encrypted\.)?google\.(cat|com(\.(a[fgiru]|b[dhnorz]|c[ouy]|do|e[cgt]|fj|g[hit]|hk|jm|kh|kw|l[bcy]|m[mtxy]|n[afgip]|om|p[aeghkry]|qa|s[abglv]|t[jnrw]|ua|uy|vc|vn))?|a[cdelmstz]|c[acdfghilmnvz]|b[aefgijsty]|ee|es|d[ejkmz]|g[aefglmpry]|f[imr]|i[emoqrst]|h[nrtu]|k[giz]|je|jo|m[degklnsuvw]|l[aiktuv]|n[eloru]|p[lnst]|s[cehikmnort]|r[osuw]|us|t[dgklmnot]|ws|vg|vu|co\.(ao|bw|ck|cr|i[dln]|jp|ke|kr|ls|ma|mz|nz|th|tz|u[gkz]|ve|vi|z[amw]))\/(search|webhp)\?|24e12c4a-a-95274a9c-s-sites\.googlegroups\.com\/a\/google\.com\/flash-api-test-harness\/apiharness\.swf|lightbox-(demos|builder)\.appspot\.com\/|s[01](qa)?\.2mdn\.net\/ads\/richmedia\/studio\/mu\/templates\/tetris|tpc\.googlesyndication\.com\/safeframe\/|www\.gstatic\.com\/doubleclick\/studio\/innovation\/h5\/layouts\/tetris)/;var hh=["2mdn.net"];function ih(a){return(a=$g.exec(a))?a[0]:""}
function jh(a){a=new Hg(a);Ig(a,document.location.protocol);a.b=document.location.hostname;document.location.port&&Jg(a,document.location.port);return a.toString()}
function kh(a){a=new Hg(a);Ig(a,document.location.protocol);return a.toString()}
;var lh=B().toString();
function mh(){var a;a:{if(window.crypto&&window.crypto.getRandomValues)try{var b=Array(16),c=new Uint8Array(16);window.crypto.getRandomValues(c);for(var d=0;d<b.length;d++)b[d]=c[d];a=b;break a}catch(e){}a=Array(16);for(b=0;16>b;b++){c=B();for(d=0;d<c%23;d++)a[b]=Math.random();a[b]=Math.floor(256*Math.random())}if(b=lh)for(c=1,d=0;d<b.length;d++)a[c%16]=a[c%16]^a[(c-1)%16]/4^b.charCodeAt(d),c++}b=[];for(c=0;c<a.length;c++)b.push("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_".charAt(a[c]&63));
return b.join("")}
;function nh(a,b){this.f=a;this.b=b}
nh.prototype.then=function(a,b,c){try{if(q(this.f))return a?Ud(a.call(c,this.f)):Ud(this.f);if(q(this.b)){if(!b)return Vd(this.b);var d=b.call(c,this.b);return!q(d)&&this.b.b?Vd(this.b):Ud(d)}throw Error("Invalid Result_ state");}catch(e){return Vd(e)}};
Ya(nh);var oh={Eb:"red",Gb:"white",ib:"blue"};var ph={hb:"adunit",mb:"detailpage",nb:"editpage",ob:"embedded",tb:"leanback",Cb:"previewpage",Db:"profilepage",Fb:"unplugged"};function qh(a,b){this.experimentIds=a?a.split(","):[];this.flags=pc(b||"");var c={};M(this.experimentIds,function(a){c[a]=!0});
this.experiments=c;c["9406693"]||c["9417210"]&&Pd&&O(8);this.enableAudioCast=!!c["9408394"]}
function X(a,b){return"true"==a.flags[b]}
;function rh(a){this.languageCode=a.languageCode;this.languageName=a.languageName||null;this.b=a.languageOriginal||null;this.id=a.id||null;this.isDefault=a.is_default||!1}
rh.prototype.toString=function(){return this.languageCode+"_"+this.languageName+"_"+this.b+"_"+this.id+"_"+this.isDefault};function sh(a){a=a||{};this.i=a.formats||"";this.b=a.format||1;if(1==this.b)for(var b=this.i.split(","),c=0;c<b.length;c++){var d=parseInt(b[c],10);isNaN(d)||(this.b=Math.max(d,this.b))}this.j=a.languageCode||"";this.o=a.languageName;this.l=a.kind||"";this.g=a.name;this.isDefault=a.is_default;this.A=a.vss_id||"";this.f=null;a.translationLanguage&&(this.f=new rh(a.translationLanguage))}
sh.prototype.toString=function(){var a=this.j+": ",b=this.o||"",c=[b];"asr"==this.l&&-1==b.indexOf("(")&&c.push(" (",yf("YTP_ASR_SETTINGS_LABEL"),")");this.g&&c.push(" - ",this.g);this.f&&c.push(" >> ",this.f.languageName);return a+c.join("")+" - "+this.A};
sh.prototype.equals=function(a){return a?this.toString()==a.toString():!1};function th(a){this.g=a||null;this.b=0;this.f=null}
th.prototype.then=function(a,b,c){return this.g?this.g.then(a,b,c):1==this.b&&a?(a=a.call(c,this.f),Za(a)||(b=new th,b.b=1,b.f=a,a=b),a):2==this.b&&b?(a=b.call(c,this.f),Za(a)||(b=new th,b.b=2,b.f=a,a=b),a):this};
Ya(th);function uh(a){return(a=a.exec(J))?a[1]:""}
var vh=function(){if(Kd)return uh(/Firefox\/([0-9.]+)/);if(N||hd||gd)return rd;if(Od)return uh(/Chrome\/([0-9.]+)/);if(Pd&&!(Nb()||K("iPad")||K("iPod")))return uh(/Version\/([0-9.]+)/);if(Ld||Md){var a=/Version\/(\S+).*Mobile\/(\S+)/.exec(J);if(a)return a[1]+"."+a[2]}else if(Nd)return(a=uh(/Android\s+([0-9.]+)/))?a:uh(/Version\/([0-9.]+)/);return""}();N&&O("9");!jd||O("528");id&&O("1.9b")||N&&O("8")||gd&&O("9.5")||jd&&O("528");id&&!O("8")||N&&O("9");function wh(){this.b=!!t("cast.receiver.platform.canDisplayType");!this.b&&t("cast.receiver.platform.getValue")&&window.cast.receiver.platform.getValue("max-video-resolution-vpx")}
function xh(){var a=Af()&&!(0<=eb(vh,29)),b=Bf("google tv")&&Bf("chrome")&&!(0<=eb(vh,30));return a||b?!1:!!(window.MediaSource||window.WebKitMediaSource||window.HTMLMediaElement&&HTMLMediaElement.prototype.webkitSourceAddId)}
;var yh="blogger books docs google-live play picasaweb gmail".split(" ");
function zh(a){I.call(this);a=Va(a);this.f="detailpage";this.j=null;this.A={};this.experiments=new qh(a.fexp,a.fflags);this.forcedExperiments=a.forced_experiments||null;var b;try{b=document.location.toString()}catch(h){b=""}this.C=b;var c=this.U=(this.O=bh.test(this.C))?V("",a.loaderUrl):this.C;b=gh.test(c);var d;d=(new RegExp("^(https?:)?//([a-z0-9-]{1,63}\\.)*("+hh.join("|").replace(/\./g,".")+")(:[0-9]+)?([/?#]|$)","i")).test(c);!b&&d&&(c=Error("isTrustedLoader("+c+") behavior is not consistent"),
.01>Math.random()&&$b(c,"WARNING"));this.o=b||d;this.Y=(this.na=(this.la=T(!1,a.ssl_stream))||T(!1,a.ssl))?"https":"http";this.baseYtUrl=ih(a.BASE_YT_URL)||ih(this.C)||this.Y+"://www.youtube.com/";b=0;"adunit"==a.el?fh.test(this.U)?(this.f="adunit",b=U(0,a.remote_ve_id)):this.f="embedded":"embedded"==a.el||this.o?this.f=Fg(this.f,a.el,ph):a.el&&(this.f="embedded");this.W=b;kf();b=null;d=a.ps;c=Bb(yh,d);!d||c&&!this.o||(b=d);this.i=b;this.N=Bb(yh,this.i);this.g={};this.g.c=a.c||"web";this.g.cver=a.cver||
"html5";this.g.cplayer="UNIPLAYER";Eg();this.isMobile=T("blazer"==this.i,a.is_html5_mobile_device);var e;a:{b=Eg();try{var f=b.muted;b.muted=!f;e=b.muted!=f;break a}catch(h){}e=!1}this.ia=e;this.B=(this.ka=T(!1,a.is_dni))||T("adunit"!=this.f&&"detailpage"!=this.f&&!this.N,X(this.experiments,"embed_show_infobar")||a.showinfo);this.V=T(!1,a.playsinline);e=this.isMobile&&tg&&2.3>=sg;f=this.isMobile&&(!X(this.experiments,"html5_prefer_standard_controls")||!kd);e=Ld&&!this.V||Bf("nintendo wiiu")||Bf("nintendo 3ds")||
!e&&T(f,a.use_native_controls)?"3":"1";this.ba="0"!=a.controls?e:"0";this.useTabletControls=this.isMobile;this.color=Fg("red",a.color,oh);0<this.W||!Ld||O(601);this.widgetReferrer=V("",a.widget_referrer);this.ia&&!(Ld&&!this.V||Bf("nintendo wiiu")||Bf("nintendo 3ds"))&&X(this.experiments,"mweb_muted_autoplay")&&(ld&&O(602)||kd&&Od&&O(53));e=("detailpage"==this.f||"adunit"==this.f)&&("blazer"==this.i||"mweb-polymer"==this.i);(this.ja=!T(!0,a.fs))||e||Ge();this.X="blazer"==this.i||"mweb-polymer"==this.i;
X(this.experiments,"mweb_autonav")&&t("yt.mobile.blazer.blazer_config.isMobilePersistentUniplayer");this.pageId=V("",a.pageid);this.mute=this.o&&T(!1,a.mute);this.storeUserVolume=!this.mute&&T("0"!=this.ba,a.store_user_volume);this.M=T(!1,a.iv_allow_in_place_switch);this.region=V("US",a.cr);this.hostLanguage=V("en",a.host_language);this.T="";new le;this.J=U(this.J,a.ismb);e=a;(f=e.adformat)||(f=(f=e.attrib)&&null!==og&&f in og&&null!==pg&&f in pg?pg[f]+"_"+og[f]:void 0);f?(b=f.match(qg))&&5==b.length?
(b=rg(f),f=this.O||this.o||b?f:null):f=null:f=null;b=!0;f&&(this.A.adformat=e.adformat,rg(f)||(this.j="adunit"==this.f?this.j:this.f,this.f="adunit",b=!1));b&&this.j&&(this.f=this.j,this.j=null);if(f=e.video_id&&e.video_id!=this.T)this.T=e.video_id;(e.adpings||f)&&e.adpings&&qc(e.adpings);if(e.feature||f)this.A.feature=e.feature;if(e.referrer||f)this.referrer=f=e.referrer,this.A.referrer=f;for(var g in Ah)f=Ah[g],b=e[f],void 0!=b&&(this.g[f]=b);!this.ma&&e.cl&&(this.ma=+e.cl);this.userAge=U(this.userAge,
e.user_age);this.userDisplayImage=V(this.userDisplayImage,e.user_display_image);ch.test(this.userDisplayImage)||(this.userDisplayImage="");this.userDisplayName=V(this.userDisplayName,e.user_display_name);this.userGender=V(this.userGender,e.user_gender);if(this.H=V(this.H,e.eventid))lh=this.H;this.csiPageType=V(this.csiPageType,e.csi_page_type);this.ha=V(this.ha,e.csi_service_name);this.X=T(this.X,e.enablecsi);e.enabled_engage_types&&new le(e.enabled_engage_types.split(","));this.M=T(this.M,e.iv_allow_in_place_switch);
this.A=a;new ng;a.innertube_api_key&&a.innertube_api_version&&this.g.c&&a.innertube_context_client_version&&this.hostLanguage&&this.region||X(this.experiments,"disable_innertube_config_reporting")||$b(Error("MISSING_INNERTUBE_CONFIG,api_key="+a.innertube_api_key+",api_version="+a.innertube_api_version+",interface="+this.g.c+",context_client_version="+a.innertube_context_client_version+",host_language="+this.hostLanguage+",region="+this.region));X(this.experiments,"king_crimson_player")&&!(0<this.W||
this.N)&&Af()&&eb(vh,55);new wh;g=new eg;if(Od&&Bf("crkey")||"TV"==this.g.cplatform)g.i=!0,g.f=.1;X(this.experiments,"html5_ewma_bandwidth_estimator")&&(g.i=!0);X(this.experiments,"html5_disable_aux_bandwidth_estimator")&&(g.o=!1);X(this.experiments,"html5_use_long_term_bandwidth_estimator")&&(g.j=!0,g.g=parseFloat(this.experiments.flags.html5_long_term_bandwidth_window_size)||0||g.g);this.J&&(g.l=this.J/8);g.b=parseFloat(this.experiments.flags.html5_bandwidth_window_size)||0||g.b;new dg(g);this.enableSafetyMode=
T(!1,a.enable_safety_mode)}
C(zh,I);var Ah={jb:"cbrand",kb:"cbr",lb:"cbrver",pb:"c",sb:"cver",rb:"ctheme",qb:"cplayer",xb:"cmodel",yb:"cnetwork",zb:"cos",Ab:"cosver",Bb:"cplatform"};
zh.prototype.getVideoUrl=function(a,b,c,d,e){b={list:b};c&&(e?b.time_continue=c:b.t=c);"gaming"==this.i?c="gaming.youtube.com":(c=Sb(Tb(3,this.baseYtUrl)),(e=Number(Tb(4,this.baseYtUrl))||null)&&(c+=":"+e),c="www.youtube-nocookie.com"==c?"www.youtube.com":c);d&&"www.youtube.com"==c?d="https://youtu.be/"+a:"WEB_UNPLUGGED"==this.g.c?(d="https://"+c+"/fire",b.v=a):(d=this.Y+"://"+c+"/watch",b.v=a,zf&&(a=t("yt.www.ads.biscotti.lastId_")||"")&&(b.ebc=a));return Yb(d,b)};
zh.prototype.isAd=function(){return"adunit"==this.f};function Bh(a,b,c){I.call(this);this.f=a;this.j=b||0;this.g=c;this.i=A(this.Ia,this)}
C(Bh,I);l=Bh.prototype;l.Z=0;l.K=function(){Bh.S.K.call(this);this.isActive()&&p.clearTimeout(this.Z);this.Z=0;delete this.f;delete this.g};
l.start=function(a){this.isActive()&&p.clearTimeout(this.Z);this.Z=0;var b=this.i;a=q(a)?a:this.j;if(!ca(b))if(b&&"function"==typeof b.handleEvent)b=A(b.handleEvent,b);else throw Error("Invalid listener argument");this.Z=2147483647<Number(a)?-1:p.setTimeout(b,a||0)};
l.isActive=function(){return 0!=this.Z};
l.Ia=function(){this.Z=0;this.f&&this.f.call(this.g)};function Ch(a,b,c){this.$=a;this.durationSecs=b;this.context=c}
;function Dh(a,b){return Eh(function(a,b){return Nf(a,b)},a,b)}
function Eh(a,b,c){return a(b,c).then(function(b){var d=!b.responseText||2048<b.responseText.length?"":0==b.responseText.indexOf("https://")?b.responseText:"";return d?Eh(a,d,c):b})}
;function Fh(a){this.g=a;this.l=this.f=this.j="";this.b={};this.i=""}
Fh.prototype.set=function(a,b){this.b[a]!==b&&(this.b[a]=b,this.i="")};
Fh.prototype.get=function(a){if(this.g){if(!eh.test(this.g))throw Error("Untrusted URL: "+this.g);var b,c=this.g;b=c instanceof Hg?new Hg(c):new Hg(c,void 0);this.j=b.g;this.l=b.b+(null!=b.i?":"+b.i:"");var d=b.f;0==d.indexOf("/videoplayback")?(this.f="/videoplayback",d=d.substr(14)):0==d.indexOf("/api/manifest/")?(c=d.indexOf("/",14),0<c?(this.f=d.substr(0,c),d=d.substr(c+1)):(this.f=d,d="")):(this.f=d,d="");var c=this.b,d=d.split("/"),e=0;d[0]||e++;for(var f={};e<d.length;e+=2)d[e]&&Gh(f,d[e],d[e+
1]);d=this.b=f;b=b.l.toString().split("&");e={};for(f=0;f<b.length;f++){var g=b[f],h=g.indexOf("=");0<h?Gh(e,g.substr(0,h),g.substr(h+1)):g&&(e[g]="")}ja(d,e);ja(this.b,c);"index.m3u8"==this.b.file&&(delete this.b.file,this.f+="/file/index.m3u8");this.i=this.g=""}return this.b[a]||null};
function Gh(a,b,c){if("cmo"==b){var d;0<=(d=c.indexOf("="))?(b="cmo="+c.substr(0,d),c=c.substr(d+1)):0<=(d=c.indexOf("%3D"))&&(b="cmo="+c.substr(0,d),c=c.substr(d+3))}a[b]=c}
;function Hh(a,b){this.start=a;this.end=b;this.length=b-a+1}
function Ih(a){a=a.split("-");return 2==a.length&&(a=new Hh(parseInt(a[0],10),parseInt(a[1],10)),!isNaN(a.start)&&!isNaN(a.end)&&!isNaN(a.length)&&0<a.length)?a:null}
Hh.prototype.toString=function(){return this.start+"-"+(null==this.end?"":this.end)};function Y(a,b){for(var c=a;c;c=c.parentNode)if(c.attributes){var d=c.getAttribute(b);if(d)return d}return""}
function Jh(a,b){for(var c=a;c;c=c.parentNode){var d=c.getElementsByTagName(b);if(0<d.length)return d[0]}return null}
function Kh(a){if(!a)return 0;var b=a.match(/PT(([0-9]*)H)?(([0-9]*)M)?(([0-9.]*)S)?/);return b?3600*parseFloat(b[2]||0)+60*parseFloat(b[4]||0)+parseFloat(b[6]||0):parseFloat(a)}
function Lh(a){return a.match(/^(\d{4})-(\d{2})-(\d{2})T(\d{2})\:(\d{2})\:(\d{2})\.(\d{3})$/)?a+"Z":a}
;function Mh(a,b,c,d,e){this.duration=c;this.endTime=b+c;this.b=a;this.sourceURL=d;this.startTime=b;this.range=e||null}
;function Nh(){this.b=[]}
Nh.prototype.f=function(){return this.b.length?this.b[this.b.length-1].b:-1};
Nh.prototype.i=function(){return 0<this.b.length};
function Oh(a,b){if(b>a.f())a.b=[];else{var c=Ab(a.b,function(a){return a.b>=b},a);
0<c&&a.b.splice(0,c)}}
;function Ph(a){var b=new Fh(a.g);b.j=a.j;b.f=a.f;b.l=a.l;b.b=Va(a.b);b.i=a.i}
;function Qh(a,b,c){this.index=null;this.info=b;this.initRange=c||null;new Ph(a)}
;function Rh(a,b,c,d,e){Qh.call(this,a,b,d);this.index=e||new Nh}
C(Rh,Qh);Rh.prototype.update=function(a,b,c){b=this.index;if(0!=a.length)if(a=Db(a),0==b.b.length)b.b=a;else{var d=b.b.length?ub(b.b).endTime:0,e=a[0].b-b.f();if(1<e){var f=b.b;if(!u(f))for(var g=f.length-1;0<=g;g--)delete f[g];f.length=0}for(e=0<e?0:-e+1;e<a.length;e++)f=a[e],f.startTime=d,f.endTime=f.startTime+f.duration,d+=a[e].duration,b.b.push(a[e])}Oh(this.index,c)};function Sh(a,b,c){this.b=a;this.$=b;this.durationSecs=c}
function Th(){this.b=[];this.f=null;this.l=0;this.i=[];this.g=!1;this.j=""}
Th.prototype.update=function(a,b){var c=void 0;this.f&&(c=this.f);var d=new Th,e=a.getElementsByTagName("S");if(e.length){var f=+Y(a,"timescale")||1,g=+Y(a,"startNumber")||0,h;h=+e[0].getAttribute("t")||0;var k=+Y(a,"presentationTimeOffset")||0;h=c?c.$+c.durationSecs:b?(h-k)/f:0;Date.parse(Lh(Y(a,"yt:segmentIngestTime")));d.g="SegmentTemplate"==a.parentNode.tagName;d.g&&(d.j=Y(a,"media"));k=c?g-c.b:1;d.l=0<k?0:-k+1;for(k=0;k<e.length;k++){var m=e[k],n=+m.getAttribute("d")/f;m.getAttribute("yt:sid");
for(var v=+m.getAttribute("r")||0,y=0;y<=v;y++)if(c&&g<=c.b)g++;else{var G=new Sh(g,h,n);d.b.push(G);var w;w=m;var R=f,W=G.$,Ea=w.getAttribute("yt:cuepointTimeOffset"),G=w.getAttribute("yt:cuepointDuration");Ea&&G?(W=+Ea/R+W,R=+G/R,w=w.getAttribute("yt:cuepointContext")||null,w=new Ch(W,R,w)):w=null;w&&d.i.push(w);g++;h+=n}}d.b.length&&(d.f=ub(d.b))}this.l=d.l;this.f=d.f||this.f;Eb(this.b,d.b);Eb(this.i,d.i);this.g=d.g;this.j=d.j};
function Uh(a){var b=a.i;a.i=[];return b}
;function Vh(){this.i=[];this.b=null;this.f={};this.g={}}
function Wh(a,b,c){var d=[];b=b.getElementsByTagName("SegmentTimeline");for(var e=0;e<b.length;e++){var f=b[e].parentNode.parentNode,g=null;"Period"==f.nodeName?g=Xh(a):"AdaptationSet"==f.nodeName?g=Yh(a,f.attributes.mimeType.value):"Representation"==f.nodeName&&(g=Zh(a,f.attributes.id.value));if(null==g)return;g.update(b[e],c);Eb(d,Uh(g))}Ib(d,function(a){return a.$});
Eb(a.i,d)}
function $h(a){a.b&&(a.b.b=[]);Oa(a.f,function(a){a.b=[]});
Oa(a.g,function(a){a.b=[]})}
function Xh(a){a.b||(a.b=new Th);return a.b}
function Yh(a,b){a.f[b]||(a.f[b]=new Th);return a.f[b]}
function Zh(a,b){a.g[b]||(a.g[b]=new Th);return a.g[b]}
;function ai(){this.b=new Float64Array(128);this.g=new Float64Array(128)}
ai.prototype.f=function(){return-1};
ai.prototype.i=function(){return 0<=this.f()};
ai.prototype.cap=function(a,b){if(1>this.b.length){var c=2*this.b.length,c=c+2,d=this.b;this.b=new Float64Array(c+1);var e=this.g;this.g=new Float64Array(c+1);for(c=0;1>c;c++)this.b[c]=d[c],this.g[c]=e[c]}this.g[0]=b;this.b[0]=a};function bi(a,b,c,d,e,f){Qh.call(this,a,b,c||void 0);this.indexRange=d;this.index=new ai;this.lastModified=f}
C(bi,Qh);function ci(a,b,c){S.call(this);this.J=this.duration=0;this.isLive=!1;this.C=D();this.g=Infinity;this.f={};this.M=a||"";this.B=0;this.o=null;this.V=!!b&&X(b,"html5_live_nonzero_first_segment_start_time");this.X=!!b&&X(b,"html5_live_self_init_segments");this.A=null;this.Y=c;this.ba=!b||!X(b,"html5_manifest_without_credentials");this.H=!!b&&X(b,"disable_html5_manifest_namespace_redux");this.N=""}
C(ci,S);function di(a){Pa(a.f,function(a){return!!a.info.g},a)}
function ei(a){return Pa(a.f,function(a){return a.info.video?2==a.info.video.projectionType:!1},a)}
function fi(a){return Pa(a.f,function(a){return a.info.video?3==a.info.video.projectionType:!1},a)}
function gi(a,b,c){var d=new ci;d.duration=c||0;M(a,function(a){var c=hi(a,b),e=Ih(a.init),h=Ih(a.index),k=ii(a.url,c,a.s);a=parseInt(a.lmt,10);k&&(c=new bi(k,c,e,h,0,a),d.f[c.info.id]=c)});
return d}
function hi(a,b){var c=a.type,d=ji(a),e=null;jg(c)&&(e=(a.size||"640x360").split("x"),e=new gg(+e[0],+e[1],+a.fps,+a.projection_type,void 0,void 0,!!a.isAccelerated,a.quality_label,0,a.primaries));var f=null;ig(c)&&(f=new fg(+a.spatial_audio_type));var g=parseInt(a.bitrate,10)/8,h=null;b&&a.drm_families&&(h={},M(a.drm_families.split(","),function(a){h[a]=b[a]}));
return new hg(d,c,f,e,h,g)}
function ji(a){var b=a.itag;a.xtags&&(b=a.itag+";"+a.xtags);return b}
ci.prototype.W=function(a){var b=a.getElementsByTagName("Representation");if(0<a.getElementsByTagName("SegmentList").length||0<a.getElementsByTagName("SegmentTemplate").length){this.o||(this.o=new Vh);Wh(this.o,a,this.V);this.i("refresh");for(a=0;a<b.length;a++){var c=ki(this,b[a]),d=this.isLive&&1==c.b&&this.X;if(!this.f[c.id]){var e=ii(Jh(b[a],"BaseURL").textContent,c),f=Jh(b[a],"Initialization");Y(f,"sourceURL");f=Ih(Y(f,"range"));d&&(f=void 0);this.f[c.id]=new Rh(e,c,0,null===f?void 0:f)}var c=
this.f[c.id],e=this.o,f=c,g;g=1;for(var h=f.info.mimeType.split(";"),k=[];0<g&&h.length;)k.push(h.shift()),g--;h.length&&k.push(h.join(";"));g=k[0];e=e.g[f.info.id]||e.f[g]||e.b||null;f=e.b;if(e.g)for(d=c,g=[],h=0;h<f.length;h++){for(var k=f[h],m=d.info.id,n=8*d.info.f,v=k.b,y=k.$,G=e.j.split("$$"),w=0;w<G.length;w++)G[w]=G[w].replace("$RepresentationID$",m),G[w]=G[w].replace("$Number$",v.toString()),G[w]=G[w].replace("$Bandwidth$",n.toString()),G[w]=G[w].replace("$Time$",y.toString());g.push(new Mh(k.b,
k.$,k.durationSecs,G.join("$"),null))}else for(e=Fb(Jh(b[a],"SegmentList").getElementsByTagName("SegmentURL"),e.l),g=[],h=0;h<e.length;h++)g.push(li(e[h],f[h],d));d=g;c.update(d,this.isLive,this.J)}$h(this.o);return!0}this.duration=Kh(Y(a,"mediaPresentationDuration"));a:{for(a=0;a<b.length;a++){f=b[a];c=ki(this,f);d=Jh(f,"BaseURL");e=ii(d.textContent,c);g=Jh(f,"SegmentBase");f=Ih(g.attributes.indexRange.value);g=Ih(g.getElementsByTagName("Initialization")[0].attributes.range.value);d.getAttribute(mi(this,
"contentLength"));c=new bi(e,c,g,f,0,NaN);if(!c){b=!1;break a}this.f[c.info.id]=c}b=!0}return b};
function ii(a,b,c){a=new Fh(a);a.set("alr","yes");a.set("keepalive","yes");a.set("ratebypass","yes");a.set("mime",encodeURIComponent(b.mimeType.split(";")[0]));c&&a.set("signature",Yf(c));return a}
var ni={commentary:1,alternate:2,dub:3,main:4};
function ki(a,b){var c=Y(b,"id"),c=c.replace(":",";");"captions"==c&&(c=Y(b,"lang"));var d=Y(b,"mimeType"),e=Y(b,"codecs"),d=e?d+'; codecs="'+e+'"':d,e=parseInt(Y(b,"bandwidth"),10)/8;Jh(b,"BaseURL").getAttribute(mi(a,"contentLength"));var f=null;if(jg(d)){var f=parseInt(Y(b,"width"),10),g=parseInt(Y(b,"height"),10),h=parseInt(Y(b,"frameRate"),10),k=Y(b,mi(a,"projectionType")),m=Y(b,mi(a,"stereoLayout")),k="equirectangular"==k,n,v;k&&"layout_top_bottom"==m?n=3:k&&!m?n=2:"layout_left_right"==m&&(v=
1);f=new gg(f,g,h,n,v)}n=null;if(ig(d)){Y(b,"audioSamplingRate");Y(b.getElementsByTagName("AudioChannelConfiguration")[0],"value");var y;n=Y(b,mi(a,"spatialAudioType"));"spatial_audio_type_ambisonics_5_1"==n?y=1:"spatial_audio_type_ambisonics_quad"==n&&(y=2);n=new fg(y);Y(b,"lang");if(y=Jh(b,"Role"))y=Y(y,"value")||"",null!==ni&&y in ni&&Y(b,mi(a,"langName"))}v=null;if(y=Jh(b,"ContentProtection"))if((v=y.attributes.schemeIdUri)&&"http://youtube.com/drm/2012/10/10"==v.textContent)for(v={},y=y.firstChild;null!=
y;y=y.nextSibling)"SystemURL"==y.localName&&"http://youtube.com/yt/2012/10/10"==y.namespaceURI&&(v[y.attributes.type.textContent]=y.textContent.trim());else v=null;return new hg(c,d,n,f,v,e)}
ci.prototype.T=function(a){a=a.responseText;a=(new DOMParser).parseFromString(a,"text/xml").getElementsByTagName("MPD")[0];this.g=1E3*Kh(Y(a,"minimumUpdatePeriod"))||Infinity;if(!this.H){var b;a:{for(b=0;b<a.attributes.length;b++)if("http://youtube.com/yt/2012/10/10"==a.attributes[b].value){b=a.attributes[b].name.split(":")[1];break a}b=""}this.N=b}this.isLive=Infinity>this.g&&0!=this.Y;this.J=parseInt(Y(a,mi(this,"earliestMediaSequence")),10)||0;Date.parse(Lh(Y(a,mi(this,"mpdResponseTime"))))&&B();
yb(a.getElementsByTagName("Period"),this.W,this);this.B=2;this.i("loaded");isFinite(this.g)&&oi(this);return this};
ci.prototype.U=function(a){this.B=3;this.i("loaderror");return Vd(a.b)};
function li(a,b,c){var d=a.getAttribute("media"),e=null;c||(a=a.getAttribute("mediaRange"),null!=a&&(0<=parseInt(a.split("-")[1],10)?e=Ih(a):d=d+"?range="+a));return new Mh(b.b,b.$,b.durationSecs,d,e)}
ci.prototype.O=function(){if(1!=this.B&&!this.b){var a;a:{a=this.f;for(var b in a){var c=a[b].index;if(c&&c.i()){a=c.f()+1;break a}}a=0}a=Yb(this.M,{start_seq:a.toString()});this.B=1;this.C=D();Xd(Dh(a||this.M,{format:"RAW",method:"GET",withCredentials:this.ba}).then(A(this.T,this)),A(this.U,this))}};
ci.prototype.resume=function(){isFinite(this.g)&&oi(this)};
function oi(a){if(a.isLive&&D()-a.C>=a.g)a.O();else{var b=Math.max(0,a.C+a.g-D());a.A||(a.A=new Bh(a.O,b,a),lb(a,ia(mb,a.A)));a.A.start(b)}}
function mi(a,b){return a.H?"yt:"+b:a.N+":"+b}
;function pi(a,b){this.version=a;this.args=b}
function qi(a){this.topic=a}
qi.prototype.toString=function(){return this.topic};var ri=window.performance||window.mozPerformance||window.msPerformance||window.webkitPerformance||{};function si(a){pi.call(this,1,arguments)}
C(si,pi);var ti=new qi("timing-sent");var ui=t("yt.pubsub2.instance_")||new Q;Q.prototype.subscribe=Q.prototype.subscribe;Q.prototype.unsubscribeByKey=Q.prototype.aa;Q.prototype.publish=Q.prototype.pa;Q.prototype.clear=Q.prototype.clear;r("yt.pubsub2.instance_",ui,void 0);var vi=t("yt.pubsub2.subscribedKeys_")||{};r("yt.pubsub2.subscribedKeys_",vi,void 0);var wi=t("yt.pubsub2.topicToKeys_")||{};r("yt.pubsub2.topicToKeys_",wi,void 0);var xi=t("yt.pubsub2.isAsync_")||{};r("yt.pubsub2.isAsync_",xi,void 0);
r("yt.pubsub2.skipSubKey_",null,void 0);function yi(a){var b=t("yt.pubsub2.instance_");b&&b.publish.call(b,ti.toString(),ti,a)}
;var zi={vc:!0},Ai={ad_at:"adType",cpn:"clientPlaybackNonce",csn:"clientScreenNonce",is_nav:"isNavigation",yt_lt:"loadType",yt_ad:"isMonetized",yt_ad_pr:"prerollAllowed",yt_red:"isRedSubscriber",yt_vis:"isVisible",docid:"videoId",plid:"videoId"},Bi="ap c cver ei yt_fss yt_li".split(" "),Ci=["isNavigation","isMonetized","prerollAllowed","isRedSubscriber","isVisible"],Di=A(ri.clearResourceTimings||ri.webkitClearResourceTimings||ri.mozClearResourceTimings||ri.msClearResourceTimings||ri.oClearResourceTimings||
aa,ri);
function Ei(a,b,c){if(!b&&"_"!=a[0]){var d=a;ri.mark&&(0==d.lastIndexOf("mark_",0)||(d="mark_"+d),c&&(d+=" ("+c+")"),ri.mark(d))}var d=Fi(c),e=b||D();d[a]&&(d["_"+a]=d["_"+a]||[d[a]],d["_"+a].push(e));d[a]=e;Gi(c)["tick_"+a]=b;c||b||D();ac("csi_on_gel")?(d=Hi(c),"_start"==a?pf("baseline_"+d)||mf("latencyActionBaselined",{clientActionNonce:d},b):pf("tick_"+a+"_"+d)||mf("latencyActionTicked",{tickName:a,clientActionNonce:d},b),a=!0):a=!1;if(!a&&!t("yt.timing."+(c||"")+"pingSent_")&&(b=ma((c||"")+"TIMING_ACTION"),
a=Fi(c),t("yt.timing."+(c||"")+"ready_")&&b&&a._start&&Ii(c)))if(c)Ji(c);else{b=!0;d=E("TIMING_WAIT",[]);if(d.length)for(var e=0,f=d.length;e<f;++e)if(!(d[e]in a)){b=!1;break}b&&Ji(c)}}
function Ki(a){var b=Li(a).info.yt_lt="hot_bg";Gi(a).info_yt_lt=b;if(ac("csi_on_gel"))if("yt_lt"in Ai){var c={},d=Ai.yt_lt;Bb(Ci,d)&&(b=!!b);c[d]=b;a=Hi(a);b=Object.keys(c).join("");pf("info_"+b+"_"+a)||(c.clientActionNonce=a,mf("latencyActionInfo",c))}else"yt_lt"in Bi||$b(Error("Unknown label yt_lt logged with GEL CSI."))}
function Mi(a){Ni(a);Di();Oi(!1,a);a||(E("TIMING_ACTION")&&la("PREVIOUS_ACTION",E("TIMING_ACTION")),la("TIMING_ACTION",""))}
function Ii(a){var b=Fi(a);if(b.aft)return b.aft;a=E((a||"")+"TIMING_AFT_KEYS",["ol"]);for(var c=a.length,d=0;d<c;d++){var e=b[a[d]];if(e)return e}return NaN}
function Ji(a){if(!ac("csi_on_gel")){var b=Fi(a),c=Li(a).info,d=b._start,e;for(e in b)if(0==e.lastIndexOf("_",0)&&u(b[e])){var f=e.slice(1);if(f in zi){var g=wb(b[e],function(a){return Math.round(a-d)});
c["all_"+f]=g.join()}delete b[e]}f=!!c.ap;if(g=t("yt.timing.reportbuilder_")){if(g=g(b,c,a))Pi(g,f),Mi(a)}else{var h=E("CSI_SERVICE_NAME","youtube"),g={v:2,s:h,action:E((a||"")+"TIMING_ACTION",void 0)},k=c.srt;void 0!==b.srt&&delete c.srt;if(c.h5jse){var m=window.location.protocol+t("ytplayer.config.assets.js");(m=ri.getEntriesByName?ri.getEntriesByName(m)[0]:null)?c.h5jse=Math.round(c.h5jse-m.responseEnd):delete c.h5jse}b.aft=Ii(a);Qi(a)&&"youtube"==h&&(Ki(a),h=b.vc,m=b.pbs,delete b.aft,c.aft=Math.round(m-
h));for(var n in c)"_"!=n.charAt(0)&&(g[n]=c[n]);b.ps=D();c={};n=[];for(e in b)"_"!=e.charAt(0)&&(h=Math.round(b[e]-d),c[e]=h,n.push(e+"."+h));g.rt=n.join(",");(b=t("ytdebug.logTiming"))&&b(g,c);Pi(g,f,a);yi(new si(c.aft+(k||0)))}}}
function Pi(a,b,c){if(ac("debug_csi_data")){var d=t("yt.timing.csiData");d||(d=[],r("yt.timing.csiData",d,void 0));d.push({page:location.href,time:new Date,args:a})}var d="",e;for(e in a)d+="&"+e+"="+a[e];a="/csi_204?"+d.substring(1);if(window.navigator&&window.navigator.sendBeacon&&b)try{window.navigator&&window.navigator.sendBeacon&&window.navigator.sendBeacon(a,"")||Jf(a,void 0)}catch(f){Jf(a,void 0)}else Jf(a);Oi(!0,c)}
function Hi(a){var b=Li(a).nonce;b||(b=mh(),Li(a).nonce=b);return b}
function Fi(a){return Li(a).tick}
function Gi(a){a=Li(a);"gel"in a||(a.gel={});return a.gel}
function Li(a){return t("ytcsi."+(a||"")+"data_")||Ni(a)}
function Ni(a){var b={tick:{},info:{}};r("ytcsi."+(a||"")+"data_",b,void 0);return b}
function Oi(a,b){r("yt.timing."+(b||"")+"pingSent_",a,void 0)}
function Qi(a){var b=Fi(a),c=b.pbr,d=b.vc,b=b.pbs;return c&&d&&b&&c<d&&d<b&&1==Li(a).info.yt_pvis}
;new Bh(Ri,1E3);function Ri(){Ei("vptl",0);Ei("vpl",0)}
;function Si(a,b){this.errorCode=a;this.details=b||{}}
;function Z(a){S.call(this);this.adModule=!1;this.adaptiveFormats="";this.ta=null;this.allowEmbed=!0;this.backgroundable=!1;this.watchAjaxToken=null;this.author="";this.V=this.U=!1;this.clientScreenNonce=this.clientPlaybackNonce=this.channelPath="";this.enableCardioBeforePlayback=this.enableCardio=this.W=this.contentCheckOk=!1;this.X=0;this.M=!1;this.paidContentOverlayDurationMs=0;this.isMdxPlayback=this.isLowLatencyLiveStream=this.isLiveDefaultBroadcast=this.isLiveDestination=this.H=this.isListed=
this.ha=!1;this.mdxControlMode=null;this.isPharma=!1;this.ja=0;this.ka="";this.ia=!1;this.liveChunkReadahead=NaN;this.lengthSeconds=this.liveStartWalltime=0;this.paygated=!1;this.profilePicture=void 0;this.racyCheckOk=!1;this.rootVeType=0;this.autonavState=1;Z.prototype.ma=lg;this.startSeconds=0;this.spacecastModule=!1;Z.prototype.na=lg;this.O=null;this.hlsFormats=this.sa=this.title="";this.ra="vvt";this.requiresPurchase=!1;this.clipStart=0;this.clipEnd=Infinity;this.J=this.Y=0;this.Sa={};this.captionTracks=
[];this.captionTranslationLanguages=[];this.T=!1;this.N={};this.la=new Bh(this.eb,5E3,this);lb(this,ia(mb,this.la));this.ba=0;this.g=[];this.A={};this.keywords={};this.o={};Ti(this,a)}
C(Z,S);Z.j=/\/img\/watermark\/youtube_(hd_)?watermark(-vfl\S{6})?.png$/;Z.i=1;Z.l=18E3;Z.f="ypc_buy_url ypc_full_video_message ypc_item_thumbnail ypc_item_title ypc_item_url ypc_module ypc_offer_button_text ypc_offer_description ypc_offer_headline ypc_offer_id ypc_offer_type ypc_overlay_timeout ypc_preview ypc_signin_message ypc_vid".split(" ");Z.g="author cc_asr cc_load_policy iv_load_policy iv_new_window keywords oauth_token requires_purchase rvs subscribed title ttsurl ypc_buy_url ypc_full_video_length ypc_item_thumbnail ypc_item_title ypc_item_url ypc_offer_button_text ypc_offer_description ypc_offer_headline ypc_offer_id ypc_preview ypc_price_string ypc_video_rental_bar_text".split(" ");
Z.b={iurl:"default.jpg",iurlmq:"mqdefault.jpg",iurlhq:"hqdefault.jpg",iurlsd:"sddefault.jpg",iurlhq720:"hq720.jpg",iurlmaxres:"maxresdefault.jpg"};
function Ui(a,b){var c=b||{};c.iv_invideo_url&&kh(c.iv_invideo_url);a.isPharma=T(a.isPharma,c.is_pharma);a.author=V(a.author,c.author);a.U=T(a.U,c.cc_asr);var d=c.ttsurl;!ah.test(d)&&d&&(d=jh(d),ah.test(d));c.caption_tracks&&c.caption_audio_tracks&&(Vi(a,c.caption_tracks),rc(c.caption_audio_tracks),c.caption_translation_languages&&Wi(a,c.caption_translation_languages));a.T=T(a.T,c.cc_contribute);a.channelPath=V(a.channelPath,c.channel_path);a.clientPlaybackNonce=V(a.clientPlaybackNonce,c.cpn);a.subscribed=
T(a.subscribed,c.subscribed);a.Ka=U(a.Ka,c.view_count);a.shortViewCount=V(a.shortViewCount,c.short_view_count_text);a.title=V(a.title,c.title);a.ypcPreview=V(a.ypcPreview,c.ypc_preview);a.ypcOrigin=V(a.ypcOrigin,c.ypc_origin);a.paygated=T(a.paygated,c.paygated);a.requiresPurchase=T(a.requiresPurchase,c.requires_purchase);c.keywords&&(a.keywords=Xi(c.keywords));c.rvs&&rc(c.rvs);a.contentCheckOk=T(a.contentCheckOk,"1"==c.cco);a.racyCheckOk=T(a.racyCheckOk,"1"==c.rco);a.oauthToken=V(a.oauthToken,c.oauth_token);
a.visitorData=V(a.visitorData,c.visitor_data);c.session_data&&pc(c.session_data);c.endscreen_autoplay_session_data&&pc(c.endscreen_autoplay_session_data);a.Ea=V(a.Ea,c.endscreen_ad_tracking_data);a.Wa=T(a.Wa,c.wait_for_vast_info_cards_xml);a.Ta=V(a.Ta,c.tracking_list||c.tv_list);c.player_response&&Ba(c.player_response);M(Z.g,function(a){a in c&&(this.A[a]=c[a])},a)}
function Ti(a,b){var c=b||{};"1"!=c.hlsdvr||xh();a.clientPlaybackNonce||(a.clientPlaybackNonce=c.cpn||mh());B();a.W=T(a.W,c.cenchd);a.enableCardio=T(a.enableCardio,c.enable_cardio);a.enableCardioBeforePlayback=T(a.enableCardioBeforePlayback,c.enable_cardio_before_playback);a.X=U(a.X,c.end||c.endSeconds);a.Ga=V(a.Ga,c.itct);a.ha=T(a.ha,c.noiba);a.H="1"==c.live_playback||!!c.fresca_preroll;a.isLiveDestination=T(a.isLiveDestination,c.is_live_destination);a.isLiveDefaultBroadcast="1"==c.live_default_broadcast;
a.isLowLatencyLiveStream="1"==c.is_low_latency_live_stream;a.isMdxPlayback=T(a.isMdxPlayback,c.mdx);c.mdx_control_mode&&(a.mdxControlMode=gb(c.mdx_control_mode));a.ja=U(a.ja,c.reload_count);a.ka=V(a.ka,c.reload_reason);a.ia=T(a.ia,c.utpsa);for(var d in Z.b){var e=c[d+"_webp"]||c[d];ch.test(e)&&(a.Sa[Z.b[d]]=e)}ch.test(c.murlmq_webp);a.Va=V(a.Va,c.vvt);a.mdxEnvironment=V(a.mdxEnvironment,c.mdx_environment);a.playbackId=c.plid;a.eventId=c.eventid;a.osid=c.osid;a.videoMetadata=c.vm;a.playlistId=V(a.playlistId,
c.list);c.remarketing_url&&(a.remarketingUrl=c.remarketing_url);c.ppv_remarketing_url&&(a.ppvRemarketingUrl=c.ppv_remarketing_url);!a.La&&c.session_data&&(a.La=pc(c.session_data).feature);a.isFling=1==U(a.isFling?1:0,c.is_fling);a.vnd=U(a.vnd,c.vnd);a.Fa=V(a.Fa,c.force_ads_url);a.Ma=V(a.Ma,c.ctrl);a.Na=V(a.Na,c.ytr);a.ma=Gg(a.ma,c.vq);a.na=Gg(a.na,c.suggestedQuality);a.B=c.approx_threed_layout||0;a.Ra=T(a.Ra,c.ssrt);a.videoId=c.docid||c.video_id||c.videoId||c.id||a.videoId;a.vssCredentialsToken=V(a.vssCredentialsToken,
c.vss_credentials_token);a.ra=V(a.ra,c.vss_credentials_token_type);a.ypcGid=V(a.ypcGid,c.ypc_gid);a.heartbeatToken=V(a.heartbeatToken,c.heartbeat_token);a.heartbeatInterval=U(a.heartbeatInterval,c.heartbeat_interval);a.heartbeatRetries=U(a.heartbeatRetries,c.heartbeat_retries);a.heartbeatSoftFail=T(a.heartbeatSoftFail,c.heartbeat_soft_fail);a.Ja=T(a.Ja,c.ithb);(c.ad3_module||c.ad_module)&&"1"==c.allow_html5_ads&&(a.adModule=!0,"1"==c.ad_preroll&&a.g.push("ad"));c.adaptive_fmts&&(a.adaptiveFormats=
c.adaptive_fmts);c.license_info&&(a.ta=Yi(c.license_info));c.allow_embed&&(a.allowEmbed="1"==c.allow_embed);c.backgroundable&&(a.backgroundable="1"==c.backgroundable);c.iv_load_policy&&(a.$a=Fg(a.$a,c.iv_load_policy,mg));c.cc_lang_pref&&(a.bb=V(c.cc_lang_pref,a.bb));c.cc_load_policy&&(a.cb=Fg(a.cb,c.cc_load_policy,mg));"0"==c.dash&&(a.V=!0);c.dashmpd&&(a.C=Yb(c.dashmpd,{cpn:a.clientPlaybackNonce}),d=/\/s\/([0-9A-F.]+)/,e=d.exec(a.C))&&(e=Yf(e[1]),a.C=a.C.replace(d,"/signature/"+e));c.drm_session_id&&
(a.drmSessionId=c.drm_session_id);void 0!=c.end&&(a.clipEnd=c.end);c.fair_play_cert&&window.atob&&(a.fairPlayCert=atob(c.fair_play_cert));c.fmt_list&&(a.fmtList=c.fmt_list);c.fresca_preroll&&a.g.push("fresca");c.is_listed&&(a.isListed=T(a.isListed,c.is_listed));c.paid_content_overlay_duration_ms&&(a.paidContentOverlayDurationMs=gb(c.paid_content_overlay_duration_ms));c.paid_content_overlay_text&&(a.paidContentOverlayText=c.paid_content_overlay_text);c.url_encoded_fmt_stream_map&&(a.sa=c.url_encoded_fmt_stream_map);
c.hls_formats&&(a.hlsFormats=c.hls_formats);c.hlsvp&&(a.hlsvp=c.hlsvp);c.length_seconds&&(a.lengthSeconds=gb(c.length_seconds));c.live_chunk_readahead&&(a.liveChunkReadahead=U(a.liveChunkReadahead,c.live_chunk_readahead));c.live_start_walltime&&(a.liveStartWalltime=gb(c.live_start_walltime));c.probe_url&&(a.probeUrl=kh(Yb(c.probe_url,{cpn:a.clientPlaybackNonce})));c.profile_picture&&(a.profilePicture=V(c.profile_picture,a.profilePicture));c.pyv_billable_url&&dh.test(c.pyv_billable_url);c.pyv_conv_url&&
dh.test(c.pyv_conv_url);"1"==c.spacecast_module&&(a.g.push("spacecast"),a.spacecastModule=!0);c.spacecast_addrs&&(a.spacecastModule=!0,a.N.addresses=c.spacecast_addrs.split(","),a.N.probe=!0,c.spacecast_query_params&&(a.N.applianceQueryParams=c.spacecast_query_params));0<a.startSeconds||(a.startSeconds=U(a.startSeconds,c.start||c.startSeconds));void 0==c.start||"1"==c.resume||a.H||(a.clipStart=c.start);c.url_encoded_third_party_media&&(a.O=rc(c.url_encoded_third_party_media));c.watch_ajax_token&&
(a.watchAjaxToken=c.watch_ajax_token);c.ypc_module&&a.g.push("ypc");c.ypc_clickwrap_module&&a.g.push("ypc_clickwrap");a.Ua=V(a.Ua,c.ucid);M("baseUrl uid oeid ieid ppe engaged subscribed".split(" "),function(a){c[a]&&(this.o[a]=c[a])},a);
a.o.focEnabled=T(a.o.focEnabled,c.focEnabled);a.o.rmktEnabled=T(a.o.rmktEnabled,c.rmktEnabled);a.A=c;Ui(a,c);Zi(a);c.adpings&&c.adpings&&qc(c.adpings);c.referrer&&(a.referrer=c.referrer);c.multifeed_metadata_list&&rc(c.multifeed_metadata_list);a.clientScreenNonce=V(a.clientScreenNonce,c.csn);a.rootVeType=U(a.rootVeType,c.root_ve_type)}
function Zi(a){if(xh()&&!a.V&&a.adaptiveFormats&&!a.H){var b;b=$i(a,a.adaptiveFormats);b=gi(b,a.ta,a.lengthSeconds);a.f=b;lb(a,ia(mb,b));var c;a:if(a.f){for(c in a.f.f)if((b=a.f.f[c].info.video)&&2==b.projectionType&&3==a.B){c=!0;break a}c=fi(a.f)}else c=!1;if(!(c=c||(a.f&&3!=a.B?ei(a.f):!1)))a:if(a.B||a.wa["3D"]?c=!0:(c=a.wa("yt3d:enable"),c="true"==c||"LR"==c||"RL"==c),c&&3!=a.B&&4!=a.B)c=!0;else{if(a.f)for(var d in a.f.f)if((c=a.f.f[d].info.video)&&1==c.f){c=!0;break a}c=!1}c&&a.g.push("webgl");
a.f.isLive||(a.H=!1);di(a.f)}}
l=Z.prototype;l.wa=function(a){return z(this.keywords[a])?this.keywords[a]:null};
function aj(a){var b=Bb(a.g,"ypc");a.ypcPreview&&(b=!1);return!a.b&&!(!a.videoId&&!a.O)&&!a.M&&(!!(a.C||a.adaptiveFormats||a.sa||a.O||a.spacecastFormatMap||a.spacecastAdaptiveFormats||a.hlsvp)||Bb(a.g,"fresca")||b)}
l.eb=function(){var a={format:"RAW",method:"GET",withCredentials:!1};0<this.ba&&(a.timeout=this.ba);var b="";0<this.J&&(b=sc(b,{playerretry:this.J},!1));Eh(Lf,b,a).then(Zb(this.Za),Zb(this.Ya),this);Ei("vir");Ei("vir",void 0,"video_to_ad");this.Y=D()};
l.Za=function(a){if(!this.b){var b=a.responseText;if(b){this.M=!1;var c=qc(b);"fail"==c.status?this.i("onStatusFail",c):(Ei("virc"),Ei("virc",void 0,"video_to_ad"),M(Z.f,function(a){a in this.A&&(c[a]=this.A[a])},this),Ti(this,c),aj(this)?this.b||(this.M=!1,this.i("dataloaded",this.A)):this.i("dataloaderror",new Si("manifest.net.retryexhausted",{successButUnplayable:"1"})))}else this.ya(a)}};
l.Ya=function(a){this.ya(a.b)};
l.ya=function(a){if(!this.b){var b=a?a.status:-1;a=0<=this.J||400==b;var c=200<b?"manifest.net.badstatus":"manifest.net.connect",d=((D()-this.Y)/1E3).toFixed(3),b={backend:"gvi",rc:b,rt:d};a||(this.J++,this.la.start());this.i("dataloaderror",new Si(c,b))}};
function $i(a,b){var c=rc(b),d={};M(c,function(a){var b=d[a.itag];b&&(a.width=b.width,a.height=b.height)},a);
return c}
function Xi(a){var b={};M(a.split(","),function(a){var c=a.split("=");2==c.length?b[c[0]]=c[1]:b[a]=!0});
return b}
function Yi(a){a=rc(a);var b={};M(a,function(a){var c=a.family;a=a.url;c&&a&&(b[c]=a)});
return b}
function Vi(a,b){for(var c=rc(b),d=0;d<c.length;d++){var e=c[d],f=e.u;ah.test(f)&&a.captionTracks.push(new sh({is_translateable:e.t,languageCode:e.lc,languageName:e.n,url:f,vss_id:e.v,kind:e.k,format:3}))}}
function Wi(a,b){for(var c=rc(b),d=0;d<c.length;d++){var e=c[d];a.captionTranslationLanguages.push(new rh({languageCode:e.lc,languageName:e.n}))}}
;function bj(a){Vf.call(this,{F:"div",ga:"ytp-lightweight",ca:[{F:"div",ga:"ytp-gradient-top"},{F:"div",ga:"ytp-chrome-top",ca:[{F:"div",ga:"ytp-title-text",ca:[{F:"a",qa:["ytp-title","ytp-title-link"],fa:{target:"blank_",href:"{{url}}"},ca:["{{title}}"]}]}]},{F:"button",qa:["ytp-large-play-button","ytp-button"],ca:[Wf?{F:"div",qa:["ytp-icon","ytp-icon-large-play-button"]}:{F:"svg",fa:{height:"100%",version:"1.1",viewBox:"0 0 68 48",width:"100%"},ca:[{F:"path",ga:"ytp-large-play-button-bg",fa:{d:"m .66,37.62 c 0,0 .66,4.70 2.70,6.77 2.58,2.71 5.98,2.63 7.49,2.91 5.43,.52 23.10,.68 23.12,.68 .00,-1.3e-5 14.29,-0.02 23.81,-0.71 1.32,-0.15 4.22,-0.17 6.81,-2.89 2.03,-2.07 2.70,-6.77 2.70,-6.77 0,0 .67,-5.52 .67,-11.04 l 0,-5.17 c 0,-5.52 -0.67,-11.04 -0.67,-11.04 0,0 -0.66,-4.70 -2.70,-6.77 C 62.03,.86 59.13,.84 57.80,.69 48.28,0 34.00,0 34.00,0 33.97,0 19.69,0 10.18,.69 8.85,.84 5.95,.86 3.36,3.58 1.32,5.65 .66,10.35 .66,10.35 c 0,0 -0.55,4.50 -0.66,9.45 l 0,8.36 c .10,4.94 .66,9.45 .66,9.45 z",
fill:"#1f1f1e","fill-opacity":"0.81"}},{F:"path",fa:{d:"m 26.96,13.67 18.37,9.62 -18.37,9.55 -0.00,-19.17 z",fill:"#fff"}},{F:"path",fa:{d:"M 45.02,23.46 45.32,23.28 26.96,13.67 43.32,24.34 45.02,23.46 z",fill:"#ccc"}}]}]}]});Wf=!1;var b=new zh(a.args||{});this.f["ytp-gradient-top"].style.display=b.B?"":"none";this.f["ytp-chrome-top"].style.display=b.B?"":"none";this.f["ytp-title"].style.display=b.B?"":"none";b.B&&(a=new Z(a.args),Tf(this,"title",a.title||""),Tf(this,"url",b.getVideoUrl(a.videoId,
a.playlistId)));b=this.f["ytp-title"];a=A(this.o,this);this.g.push({target:b,type:"click",listener:a});b.addEventListener("click",a)}
C(bj,Vf);bj.prototype.o=function(a){a=a||window.event;a.cancelBubble=!0;a.stopPropagation&&a.stopPropagation()};function cj(a,b,c){S.call(this);this.f=a;this.g=b;this.B=Sb(Tb(3,c));We(this.f,"click",A(this.C,this))}
C(cj,S);cj.prototype.C=function(){Ne("/get_player_token",{format:"RAW",method:"POST",L:{v:this.g,ref:this.B,w:this.f.clientWidth,h:this.f.clientHeight},context:this,ea:this.A,onError:this.o})};
cj.prototype.A=function(a){var b=this.g;a=a.responseText;var c=Pe("yt-player-two-stage-token")||{};q(a)?c[b]=a:delete c[b];b=c;a=B()+3E5;if((c=Re)&&window.JSON){z(b)||(b=JSON.stringify(b,void 0));try{c.set("yt-player-two-stage-token",b,a)}catch(d){c.remove("yt-player-two-stage-token")}}this.o()};
cj.prototype.o=function(){this.i("onClick",this.g)};
cj.prototype.K=function(){var a=this.f,b;for(b in Ta)Ta[b][0]==a&&Xe(b);this.f=null};function dj(a,b){I.call(this);this.f=a;this.i=b;this.g(this.i.iurl,!0)}
C(dj,I);dj.prototype.g=function(a,b){N&&!O(10)?this.f.style.filter='progid:DXImageTransform.Microsoft.AlphaImageLoader(src="'+a+'", sizingMethod="scale")':b||(this.f.style.backgroundImage="url("+a+")")};
dj.prototype.K=function(){this.f=null};var ej=null,fj=null,gj=null,hj=null;function ij(){var a=gj,b,c=window.document,c="CSS1Compat"==c.compatMode?c.documentElement:c.body;b=new Ka(c.clientWidth,c.clientHeight);var d=a.i,c=null;720<=b.height&&d.iurlmaxres?c=d.iurlmaxres:480<=b.height&&d.iurlsd?c=d.iurlsd:320<=b.height?c=d.iurlhq:180<=b.height&&(c=d.iurlmq);c&&(b=c,a=A(a.g,a,c,!1),c=new Image,c.onload=a,c.src=b)}
function ie(){var a=ma("EMBED_BINARY_URL"),b=jj;if(window.spf){var c="";if(a){var d=a.indexOf("jsbin/"),e=a.lastIndexOf(".js"),f=d+6;-1<d&&-1<e&&e>f&&(c=a.substring(f,e),c=c.replace(Ff,""),c=c.replace(Gf,""),c=c.replace("debug-",""),c=c.replace("tracing-",""))}spf.script.load(a,c,b)}else Cf(a,b)}
function jj(){la("LIGHTWEIGHT_AUTOPLAY",!0);ej&&ej.parentNode&&ej.parentNode.removeChild(ej);var a=fj;a.b||he(a.j);nb(fj,gj);hj.dispose();t("writeEmbed")()}
;r("writeLightweightEmbed",function(){var a=document;ej=z("lightweight-embed")?a.getElementById("lightweight-embed"):"lightweight-embed";var a=document,b=null;a.getElementsByClassName?b=a.getElementsByClassName("yt-embed-thumbnail")[0]:a.querySelectorAll&&a.querySelector?b=a.querySelector(".yt-embed-thumbnail"):b=oe()[0];gj=new dj(b||null,E("THUMBNAIL_URLS"));a=hj=new bj(new tf);b=ej;q(void 0)?b.insertBefore(a.element,b.childNodes[void 0]||null):b.appendChild(a.element);fj=new cj(hj.element,E("VIDEO_ID")||
"",E("EURL"));fj.subscribe("onClick",ie);We(window,"load",ij)},void 0);
r("yt.setConfig",la,void 0);r("yt.logging.errors.log",ff,void 0);}).call(this);
