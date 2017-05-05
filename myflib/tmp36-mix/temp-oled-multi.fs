\ include tmp36.fs
\ include oled.fs

task: thermometer

: temp-oled   hook-emit @  ['] lcd-emit hook-emit ! show-temp $0a emit hook-emit ! display ;

: thermometer& ( -- )
  thermometer activate
  begin
    temp-oled
    10000 ms
  again ;

\ adc-init i2c-init multitask thermometer&