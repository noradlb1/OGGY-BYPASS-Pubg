echo off
SetLocal EnableExtensions EnableDelayedExpansion
adb kill-server
adb start-server
goto RoutineX
:resume1
adb push %TEMP%\device_id.xml /data/data/com.vng.pubgmobile/shared_prefs
adb push %TEMP%\device_id.xml /data/data/com.vng.pubgmobile-1/shared_prefs
::Handle AndroidID here, Change
echo "Your Old Device ID :"
adb shell settings get secure android_id
set "IDD="
for /L %%i in (1,1,16) do call :Pseudo
adb shell settings put secure android_id %IDD%
adb shell content insert --uri content://settings/secure --bind name:s:android_id --bind value:s:%IDD%

adb shell setprop ro.mac_address %IDD%
adb shell setprop ro.product.device %IDD%
adb shell setprop ro.product.brand %IDD%
adb shell setprop ro.product.model %IDD%
adb shell setprop ro.product.name %IDD%
adb shell setprop ro.product.manufacturer %IDD%
adb shell setprop ro.android_id %IDD%
adb shell setprop net.hostname %IDD%
adb shell setprop gaid %IDD%
adb shell setprop android.device.id %IDD%
adb shell setprop ro.serialno %IDD%
adb shell setprop ro.runtime.firstboot %IDD%

echo "Your New Device ID :"
echo %IDD%
goto EmptyRecords
:resume2
echo Done
timeout /t 3
goto :eof
:EmptyRecords
echo Cleaning ID related files please wait 2 minutes
adb kill-server > nul 2>&1
adb start-server > nul 2>&1
adb remount > nul 2>&1
adb shell rm -rf /data/data/com.activision.callofduty.shooter/files/itop_login.txt > nul 2>&1
adb shell rm -rf /data/data/com.activision.callofduty.shooter/shared_prefs/itop.xml > nul 2>&1
adb shell rm -rf /storage/emulated/0/com.activision.callofduty.shooter > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Logs > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Logs > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/UpdateInfo > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/UpdateInfo > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/TableDatas > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/TableDatas > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Config > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Config > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/conversation.ini > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/conversation.ini > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/GameErrorNoRecords > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/GameErrorNoRecords > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/StatEventReportedFlag > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/StatEventReportedFlag > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/ImageDownload > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/ImageDownload > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/MMKV > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/MMKV > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/rawdata > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/rawdata > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames > nul 2>&1
::adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SrcVersion.ini > nul 2>&1
::adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SrcVersion.ini > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/logs > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/logs > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Pandora > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Pandora > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferEifs1 > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferEifs1 > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferEifs0 > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferEifs0 > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferTmpDir > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferTmpDir > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/RoleInfo > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/RoleInfo > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/databases > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/databases > nul 2>&1
adb shell rm -rf /sdcard/Android/.system_android_l2 > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/files/.system_android_l2 > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/files/.system_android_l2 > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/.system_android_l2 > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/.system_android_l2 > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Intermediate > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Intermediate > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/SaveGames > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/SaveGames > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/shared_prefs > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/shared_prefs > nul 2>&1
adb shell mkdir /data/data/com.vng.pubgmobile/shared_prefs > nul 2>&1
adb shell mkdir /data/data/com.vng.pubgmobile-1/shared_prefs > nul 2>&1
adb shell chmod -R 777 /data/data/com.vng.pubgmobile/shared_prefs > nul 2>&1
adb shell chmod -R 777 /data/data/com.vng.pubgmobile-1/shared_prefs > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/databases/* > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/databases/* > nul 2>&1
adb shell mv /data/data/com.vng.pubgmobile/shared_prefs/device_id3.xml /data/data/com.vng.pubgmobile/shared_prefs/device_id.xml > nul 2>&1
adb shell mv /data/data/com.vng.pubgmobile-1/shared_prefs/device_id3.xml /data/data/com.vng.pubgmobile-1/shared_prefs/device_id.xml > nul 2>&1
adb shell touch /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Intermediate > nul 2>&1
adb shell touch /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Intermediate > nul 2>&1
adb shell touch /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/SaveGames > nul 2>&1
adb shell touch /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/SaveGames > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/code_cache > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/code_cache > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/app_bugly > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/app_bugly > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/app_crashrecord > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/app_crashrecord > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/app_databases > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/app_databases > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/app_webview > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/app_webview > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/cache > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/cache > nul 2>&1
::adb shell rm -rf /data/data/com.vng.pubgmobile/files > nul 2>&1
::adb shell rm -rf /data/data/com.vng.pubgmobile-1/files > nul 2>&1
::adb shell rm -rf /data/data/com.vng.pubgmobile/lib > nul 2>&1
::adb shell rm -rf /data/data/com.vng.pubgmobile-1/lib > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/no_backup > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/no_backup > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/cache > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/cache > nul 2>&1
adb shell rm -f /sdcard/Android/data/com.vng.pubgmobile/files/.fff > nul 2>&1
adb shell rm -f /sdcard/Android/data/com.vng.pubgmobile-1/files/.fff > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/*.fff > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/*.fff > nul 2>&1
adb shell rm -f /sdcard/Android/data/com.vng.pubgmobile/files/ca-bundle.pem > nul 2>&1
adb shell rm -f /sdcard/Android/data/com.vng.pubgmobile-1/files/ca-bundle.pem > nul 2>&1
adb shell rm -rf "/sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/Epic Games" > nul 2>&1
adb shell rm -rf "/sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/Epic Games" > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/login-identifier.txt > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/login-identifier.txt > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/TGPA > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/TGPA > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/app_textures > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/app_textures > nul 2>&1
adb shell rm -f /data/app/com.vng.pubgmobile-1/lib/arm/libhelpshiftlistener.so > nul 2>&1
adb shell rm -rf /data/media/0/.backups/com.vng.pubgmobile > nul 2>&1
adb shell rm -rf /data/media/0/.backups/com.vng.pubgmobile-1 > nul 2>&1
adb shell rm -f /sdcard/.zzz > nul 2>&1
adb shell rm -f /sdcard/Android/.system_android_12 > nul 2>&1
adb shell rm -f /sdcard/Android/.system_android_l2 > nul 2>&1
adb shell rm -f "/sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/Epic Games/KeyValueStore.ini" > nul 2>&1
adb shell rm -f "/sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/Epic Games/KeyValueStore.ini" > nul 2>&1
adb shell "find . -name ".aaa"  -exec rm -rf {} \;"
adb shell "find . -name ".bbb"  -exec rm -rf {} \;"
adb shell "find . -name ".ccc"  -exec rm -rf {} \;"
adb shell "find . -name ".ddd"  -exec rm -rf {} \;"
adb shell "find . -name ".eee"  -exec rm -rf {} \;"
adb shell "find . -name ".fff"  -exec rm -rf {} \;"
adb shell "find . -name ".ggg"  -exec rm -rf {} \;"
adb shell "find . -name ".hhh"  -exec rm -rf {} \;"
adb shell "find . -name ".iii"  -exec rm -rf {} \;"
adb shell "find . -name ".jjj"  -exec rm -rf {} \;"
adb shell "find . -name ".kkk"  -exec rm -rf {} \;"
adb shell "find . -name ".lll"  -exec rm -rf {} \;"
adb shell "find . -name ".mmm"  -exec rm -rf {} \;"
adb shell "find . -name ".nnn"  -exec rm -rf {} \;"
adb shell "find . -name ".ooo"  -exec rm -rf {} \;"
adb shell "find . -name ".ppp"  -exec rm -rf {} \;"
adb shell "find . -name ".qqq"  -exec rm -rf {} \;"
adb shell "find . -name ".rrr"  -exec rm -rf {} \;"
adb shell "find . -name ".sss"  -exec rm -rf {} \;"
adb shell "find . -name ".ttt"  -exec rm -rf {} \;"
adb shell "find . -name ".uuu"  -exec rm -rf {} \;"
adb shell "find . -name ".vvv"  -exec rm -rf {} \;"
adb shell "find . -name ".www"  -exec rm -rf {} \;"
adb shell "find . -name ".xxx"  -exec rm -rf {} \;"
adb shell "find . -name ".yyy"  -exec rm -rf {} \;"
adb shell "find . -name ".zzz"  -exec rm -rf {} \;"

adb shell rm -rf /sdcard/Android/.system_android_l2 > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/cache/* > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/cache/* > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/code_cache/* > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/code_cache/* > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/shared_prefs/* > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/shared_prefs/* > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/databases/* > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/databases/* > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile/files/.system_android_l2 > nul 2>&1
adb shell rm -rf /data/data/com.vng.pubgmobile-1/files/.system_android_l2 > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/cache/* > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/cache/* > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/.system_android_l2 > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/.system_android_l2 > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/*.json > nul 2>&1
adb shell rm -rf /sdcard/Android/data/com.vng.pubgmobile-1/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SaveGames/*.json > nul 2>&1
goto resume2

:Pseudo
set /a x=%random% %% 22 
set IDD=%IDD%!string:~%x%,1!
goto :eof

:RoutineX
set "string=abcdefABCDEF0123456789"
set "rr="
for /L %%i in (1,1,4) do call :Pseudorr
set "ss="
for /L %%i in (1,1,4) do call :Pseudoss
set "tt="
for /L %%i in (1,1,4) do call :Pseudott
set "uu="
for /L %%i in (1,1,4) do call :Pseudouu
set "vv="
for /L %%i in (1,1,4) do call :Pseudovv
set "ww="
for /L %%i in (1,1,4) do call :Pseudoww
set "xx="
for /L %%i in (1,1,4) do call :Pseudoxx
set "yy="
for /L %%i in (1,1,4) do call :Pseudoyy
set "h1=^<?xml version='1.0' encoding='utf-8' standalone='yes' ?^>"
set "h2=^<map^>"
set "h3=    ^<string name="install"^>%rr%%ss%-%tt%-%uu%-%vv%-%ww%%xx%%yy%^</string^>"
set "h4=    ^<string name="uuid"^>%yy%%xx%%ww%%vv%%uu%%tt%%ss%%rr%^</string^>"
set "h5=    ^<string name="random"^>^</string^>"
set "h6=^</map^>"
DEL %TEMP%\device_id.xml
echo %h1%>>%TEMP%\device_id.xml
echo %h2%>>%TEMP%\device_id.xml
echo %h3%>>%TEMP%\device_id.xml
echo %h4%>>%TEMP%\device_id.xml
echo %h5%>>%TEMP%\device_id.xml
echo %h6%>>%TEMP%\device_id.xml
goto resume1

:Pseudorr
set /a x=%random% %% 22 
set rr=%rr%!string:~%x%,1!
goto :eof

:Pseudoss
set /a x=%random% %% 22 
set ss=%ss%!string:~%x%,1!
goto :eof

:Pseudott
set /a x=%random% %% 22 
set tt=%tt%!string:~%x%,1!
goto :eof

:Pseudouu
set /a x=%random% %% 22 
set uu=%uu%!string:~%x%,1!
goto :eof

:Pseudovv
set /a x=%random% %% 22 
set vv=%vv%!string:~%x%,1!
goto :eof

:Pseudoww
set /a x=%random% %% 22 
set ww=%ww%!string:~%x%,1!
goto :eof

:Pseudoxx
set /a x=%random% %% 22 
set xx=%xx%!string:~%x%,1!
goto :eof

:Pseudoyy
set /a x=%random% %% 22 
set yy=%yy%!string:~%x%,1!
goto :eof