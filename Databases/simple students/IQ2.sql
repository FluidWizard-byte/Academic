SQL> SELECT
  2  module "modules_by_many_instructors"
  3  FROM instructor
  4  GROUP BY
  5  module
  6  HAVING COUNT(*)>1;

modules_by_many_instructo                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
-------------------------                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
Networks                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
Database                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            

SQL> spool off
