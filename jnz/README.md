# jnz
some files used to test the JeeNode Zero

working with  [https://github.com/jeelabs/embello/tree/master/explore/1608-forth/flib] (JeeLabs Forth Library)

## tmp36.fs

usage:

    adc-init  ok.
    tmp36 .temp 17.9 ok.
    show-tmp36 TMP36 sample: 838 -- voltage: 675 mV -- temp: 17.5°C ok. 

## oled.fs

original file from JeeLabs site modified to comment starting the demo

    \ 1234 ms go

while it is possible to stop it, doing so left input without effect
