SQL> SELECT
  2  course, COUNT(*) "students enrolled",
  3  MAX(marks) "highest marks"
  4  FROM
  5  student
  6  GROUP BY course;

COURSE                    students enrolled highest marks                                                                                                                                                                                                       
------------------------- ----------------- -------------                                                                                                                                                                                                       
BIT Computing                             2            90                                                                                                                                                                                                       
MBA Management                            2           100                                                                                                                                                                                                       
BIT Multimedia                            2           100                                                                                                                                                                                                       
BIT Networking                            2            70                                                                                                                                                                                                       

SQL> SPOOL OFF
