SQL> SELECT
  2  i.instructor_name,
  3  c.fax
  4  FROM instructor i JOIN contact c
  5  ON
  6  (i.contact=c.phone)
  7  WHERE i.module='Database';

INSTRUCTOR_NAME                       FAX                                                                                                                                                                                                                       
------------------------------ ----------                                                                                                                                                                                                                       
James John                                                                                                                                                                                                                                                      
Dona De                        1212121222                                                                                                                                                                                                                       

SQL> SPOOL OFF
