SQL> SELECT
  2  i.instructor_name
  3  FROM
  4  instructor i
  5  INNER JOIN
  6  instructor j
  7  ON i.salary=j.salary
  8  AND i.module=j.module
  9  AND i.instructor_id!=j.instructor_id;

INSTRUCTOR_NAME                                                                                                                                                                                                                                                 
------------------------------                                                                                                                                                                                                                                  
Dona De                                                                                                                                                                                                                                                         
James John                                                                                                                                                                                                                                                      

SQL> SPOOL OFF
