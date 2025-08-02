\ generate-numbers.fs - writes numbers 1 to 10 in a file

variable i
1 i ! \ start generating at 1

\ open up the output file
s" numbers.txt" w/o create-file throw constant out

: write-number ( n -- )
  s>d <# #s #>           \ convert number to string
  out write-line throw ; \ write string to the file

: generate
  begin
   i @ dup               \ get current i and keep copy
   write-number          \ write the number to the file
   1 + dup i !           \ increment i
   11 <                   \ check condition i less than 11
  while
  repeat ;

generate
out close-file throw
." Finished writing."  cr
bye

