SQL> SELECT
  2  student_name,
  3  (SYSDATE-enrollment_date)/7 "weeks_since_enrollment"
  4  FROM student;

STUDENT_NAME                   weeks_since_enrollment                                                                                                                                                                                                           
------------------------------ ----------------------                                                                                                                                                                                                           
John Doe                                   171.962526                                                                                                                                                                                                           
Peter Parker                               171.962526                                                                                                                                                                                                           
Dom Mann                                   171.962526                                                                                                                                                                                                           
George Guy                                 119.819669                                                                                                                                                                                                           
Freddy Day                                 119.819669                                                                                                                                                                                                           
Barry Berry                                67.6768122                                                                                                                                                                                                           
Lisa Mona                                  67.6768122                                                                                                                                                                                                           
john Smith                                 67.6768122                                                                                                                                                                                                           

8 rows selected.

SQL> SPOOL OFF
