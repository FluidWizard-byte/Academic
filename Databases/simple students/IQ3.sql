SQL> SELECT
  2  instructor_name
  3  FROM instructor
  4  WHERE
  5  LOWER(instructor_name) LIKE '%s%'
  6  AND
  7  salary>50000;

INSTRUCTOR_NAME                                                                                                                                                                                                                                                 
------------------------------                                                                                                                                                                                                                                  
James John                                                                                                                                                                                                                                                      

SQL> SPOOL OFF
