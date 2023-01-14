SQL> SELECT
  2  s.address,
  3  NVL(c.fax,1234567890) "fax"
  4  FROM student s JOIN contact c
  5  ON(c.phone=s.contact);

   ADDRESS        fax                                                                                                                                                                                                                                           
---------- ----------                                                                                                                                                                                                                                           
         1 5656788898                                                                                                                                                                                                                                           
         1 1234567890                                                                                                                                                                                                                                           
         3 1234567890                                                                                                                                                                                                                                           
         4 1234567890                                                                                                                                                                                                                                           
         5 1234567890                                                                                                                                                                                                                                           
         6 1234567890                                                                                                                                                                                                                                           
         6 2222666689                                                                                                                                                                                                                                           
         2 1212121211                                                                                                                                                                                                                                           

8 rows selected.

SQL> SPOOL OFF
