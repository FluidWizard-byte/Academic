SQL> SELECT
  2  i.instructor_name,
  3  a.country,
  4  a.province,
  5  a.city,
  6  a.street,
  7  a.house
  8  FROM instructor i JOIN address a
  9  ON
 10  (i.address=a.address_id)
 11  WHERE
 12  i.instructor_name LIKE '%a %';

INSTRUCTOR_NAME                COUNTRY                   PROVINCE                  CITY                      STREET                    HOUSE                                                                                                                    
------------------------------ ------------------------- ------------------------- ------------------------- ------------------------- -------------------------                                                                                                
Angelina Blue                  Nepal                     3                         Koteshwor                 Dronacharya               11                                                                                                                       
Ana Bna                        Nepal                     3                         Patan                     111                       90/2                                                                                                                     
Dona De                        Nepal                     1                         Namche                    Point                     12                                                                                                                       
Angelina White                 Nepal                     1                         Namche                    Point                     12                                                                                                                       

SQL> SPOOL OFF
