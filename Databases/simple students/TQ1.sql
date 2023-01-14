SQL> SELECT
  2  s.student_name,
  3  s.course,
  4  c.yearly_fee,DECODE(course,'BIT Computing',yearly_fee-yearly_fee*0.1,
  5  				'BIT Networking',yearly_fee-yearly_fee*0.1,
  6  				'BIT Multimedia',yearly_fee-yearly_fee*0.1,
  7  				yearly_fee) "updated_yearly_fees"
  8  FROM student s join course c
  9  ON (c.course_name=s.course);

STUDENT_NAME                   COURSE                    YEARLY_FEE updated_yearly_fees                                                                                                                                                                         
------------------------------ ------------------------- ---------- -------------------                                                                                                                                                                         
John Doe                       BIT Computing                 150000              135000                                                                                                                                                                         
Peter Parker                   BIT Computing                 150000              135000                                                                                                                                                                         
Dom Mann                       BIT Multimedia                150000              135000                                                                                                                                                                         
George Guy                     BIT Multimedia                150000              135000                                                                                                                                                                         
Freddy Day                     BIT Networking                150000              135000                                                                                                                                                                         
Barry Berry                    BIT Networking                150000              135000                                                                                                                                                                         
Lisa Mona                      MBA Management                100000              100000                                                                                                                                                                         
john Smith                     MBA Management                100000              100000                                                                                                                                                                         

8 rows selected.

SQL> SPOOL OFF
