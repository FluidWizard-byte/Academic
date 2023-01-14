SQL> SELECT
  2  instructor_name "Module Head",
  3  module,
  4  contact
  5  FROM instructor
  6  WHERE instructor_id LIKE 'ML%';

Module Head                    MODULE                       CONTACT                                                                                                                                                                                             
------------------------------ ------------------------- ----------                                                                                                                                                                                             
Angelina Blue                  Networks                  1092387465                                                                                                                                                                                             
Sam Bla                        Accounting                1092387465                                                                                                                                                                                             
Drew D                         Modelling                 9000076543                                                                                                                                                                                             

SQL> SPOOL OFF
