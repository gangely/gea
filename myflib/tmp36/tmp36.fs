\ tmp36.fs
\ gea 20170325 modif 20170413
\ needs adc (already loaded in jnz)

: tmp36 ( -- n1 ) pa0 adc ;

: adc>volt ( n1 -- n2 )  3300 4095 */ ;

: adc>temp ( n1 -- n2 )  adc>volt 500 - ;  \ in tenths of °C \

: #.#s ( d -- n addr ) <# # 46 hold #s #> ;

: temp$  ( n1 -- count addr)  adc>temp s>d #.#s ;

: temp. ( n1 -- )  temp$ type ;

: show-temp ( -- ) tmp36 ." temp: " temp. ." °C" ;

: show-tmp36 ( -- ) tmp36 ." TMP36 sample: " dup . ." -- voltage: " dup adc>volt . ." mV" ."  -- temp: " temp. ." °C" ;

\ adc-init
\ show-tmp36 cr