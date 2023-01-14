SQL> SELECT
  2  SUBSTR(course_name,4) "Specifications under BIT"
  3  FROM course
  4  WHERE course_name LIKE 'BIT%';

Specifications under BIT                                                                                                                                                                                                                                        
----------------------------------------------------------------------------------------                                                                                                                                                                        
 Computing                                                                                                                                                                                                                                                      
 Multimedia                                                                                                                                                                                                                                                     
 Networking                                                                                                                                                                                                                                                     

SQL> SPOOL OFF
