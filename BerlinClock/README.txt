Being passed the hours and minutes as integers, we want to get a response that corresponds 
to the lights being off, red, or yellow in each row in the clock.
----

eg. given an input of
hours = 13
minutes = 23

we'd expect a console output of:
RROO - indication for every 5 hours set to R, otherwise set to O
RRRO - indication of every 1 hour set to R, otherwise set to O
YYRYOOOOOOO - every 5 minutes, change it to Y, for every 15 mins, set to R, otherwise if not yet in 5 or 15 minutes set to O
YYYO -  count for every minutes, set to Y if it is in a minute, otherwise set to O

Additional information on the timer:
Hours:
RROO -> this means that the 2 R is 10 hours
RRRO -> this means that the 3 R is 3 hours
With this information we get the 13 hour value

Minutes:
YYRYOOOOOOO -> this means that each Y consists of 5 minutes, the R is the 15 minute marker, this makes a total of 20 minutes.
YYYO -> this means that each Y consists of 1 minute, otherwise set to O, this sample makes a total of 3 minutes.
With this information for the minutes, we got a total of 13 minutes.