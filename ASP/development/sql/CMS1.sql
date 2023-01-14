INSERT ALL  
    INTO address (city, zip) VALUES ('Kathmandu', 44600)  
    INTO address (city, zip) VALUES ('Pokhara', 33700)  
    INTO address (city, zip) VALUES ('Lumbini', 32914)
    INTO address (city, zip) VALUES ('Chitwan', 44200)
    INTO address (city, zip) VALUES ('Dillibazar', 44605)
SELECT * FROM dual;  

INSERT ALL  
    INTO course (course_name) VALUES ('Computing')
    INTO course (course_name) VALUES ('Networking')
    INTO course (course_name) VALUES ('Multimedia')
    INTO course (course_name) VALUES ('Marketing')
    INTO course (course_name) VALUES ('Artificial Intelligence')  
SELECT * FROM dual;  

INSERT ALL  
    INTO module (course,module_code,module_name,credit_hours) VALUES (1,'CS0134NI','Databases',4)
    INTO module (course,module_code,module_name,credit_hours) VALUES (1,'CS0134NI','Application Development',3)
    INTO module (course,module_code,module_name,credit_hours) VALUES (2,'CS0154NA','Ethical Hacking',4)
    INTO module (course,module_code,module_name,credit_hours) VALUES (2,'CS1134NA','Networks',4)
    INTO module (course,module_code,module_name,credit_hours) VALUES (3,'CS5134MI','3D Modelling',2)
    INTO module (course,module_code,module_name,credit_hours) VALUES (3,'CS6134MI','Game Design',2)
    INTO module (course,module_code,module_name,credit_hours) VALUES (4,'CS7134BB','Accounting',3)
    INTO module (course,module_code,module_name,credit_hours) VALUES (4,'CS8199BB','Business',6)
    INTO module (course,module_code,module_name,credit_hours) VALUES (5,'CS9114NE','Algorithms',5)
    INTO module (course,module_code,module_name,credit_hours) VALUES (5,'CS0104NE','Mathematics',4)
SELECT * FROM dual;  

INSERT ALL  
    INTO department (department_name,department_head) VALUES ('Digital Design','John Doe')
    INTO department (department_name,department_head) VALUES ('Computing','Bob Vance')
    INTO department (department_name,department_head) VALUES ('Maths','Michael Scott')
    INTO department (department_name,department_head) VALUES ('Business','Paul Newman')
    INTO department (department_name,department_head) VALUES ('Finance','Ben Simmons')
SELECT * FROM dual;  

INSERT ALL  
    INTO student (student_name,student_DOB,student_address,enrolled_course,student_email,student_phone) VALUES ('Scott Lang','01-JAN-1999',100,5,'sl1@mail.com','8998948984')
    INTO student (student_name,student_DOB,student_address,enrolled_course,student_email,student_phone) VALUES ('Sam Lee','03-FEB-1997',102,4,'slee@mail.com','1238763903')
    INTO student (student_name,student_DOB,student_address,enrolled_course,student_email,student_phone) VALUES ('Xiao Lang','01-JAN-2001',103,3,'xcn@mail.com','7865656676')
    INTO student (student_name,student_DOB,student_address,enrolled_course,student_email,student_phone) VALUES ('Hank Pym','11-Mar-2000',104,2,'hpy@mail.com','8000888989')
    INTO student (student_name,student_DOB,student_address,enrolled_course,student_email,student_phone) VALUES ('Happy H','21-AUG-1998',101,5,'hh@mail.com','8787878784')
SELECT * FROM dual;

INSERT ALL  
    INTO teacher (teacher_name,module_taught,department,teacher_address,teacher_email,teacher_phone) VALUES ('Simon Fox',1,2,104,'sf@mail.com','8447447447')
    INTO teacher (teacher_name,module_taught,department,teacher_address,teacher_email,teacher_phone) VALUES ('Sam Wilson',8,5,103,'swll@mail.com','8777747447')
    INTO teacher (teacher_name,module_taught,department,teacher_address,teacher_email,teacher_phone) VALUES ('Barry Don',5,1,102,'bdn@mail.com','1117447447')
    INTO teacher (teacher_name,module_taught,department,teacher_address,teacher_email,teacher_phone) VALUES ('Pen Smith',6,1,101,'psm@mail.com','9908947447')
    INTO teacher (teacher_name,module_taught,department,teacher_address,teacher_email,teacher_phone) VALUES ('Will Man',2,2,100,'wma@mail.com','1278364098')
SELECT * FROM dual;



INSERT ALL  
    INTO assignment (student,module,assignment_type,grade_obtained,status) VALUES (10005,10,'Individual Coursework','A','PASS')
    INTO assignment (student,module,assignment_type,grade_obtained,status) VALUES (10005,9,'Written Exam','A','PASS')
    INTO assignment (student,module,assignment_type,grade_obtained,status) VALUES (10006,8,'Group Coursework','A+','PASS')
    INTO assignment (student,module,assignment_type,grade_obtained,status) VALUES (10006,7,'Presentation','A','PASS')
    INTO assignment (student,module,assignment_type,grade_obtained,status) VALUES (10007,6,'MCQ Exam','A+','PASS')
    INTO assignment (student,module,assignment_type,grade_obtained,status) VALUES (10007,5,'Individual Coursework','A','PASS')
    INTO assignment (student,module,assignment_type,grade_obtained,status) VALUES (10008,4,'Written Examination','A','PASS')
    INTO assignment (student,module,assignment_type,grade_obtained,status) VALUES (10008,3,'Viva','B','PASS')
    INTO assignment (student,module,assignment_type,grade_obtained,status) VALUES (10009,2,'Individual Coursework','B+','PASS')
    INTO assignment (student,module,assignment_type,grade_obtained,status) VALUES (10009,1,'Individual Coursework','F','Fail')
SELECT * FROM dual;

INSERT ALL  
    INTO fee (student,amount,year_semester,due_date,payment_date,remarks) VALUES (10005,100000,'Year 3 sem 2','01-JAN-2021','','Not paid')
    INTO fee (student,amount,year_semester,due_date,payment_date,remarks) VALUES (10004,110000,'Year 3 sem 2','01-FEB-2021','01-FEB-2021','Paid')
    INTO fee (student,amount,year_semester,due_date,payment_date,remarks) VALUES (10003,120000,'Year 3 sem 2','01-APR-2021','','Pending')
    INTO fee (student,amount,year_semester,due_date,payment_date,remarks) VALUES (10002,130000,'Year 3 sem 2','01-MAR-2021','11-MAR-2021','Paid')
    INTO fee (student,amount,year_semester,due_date,payment_date,remarks) VALUES (10001,140000,'Year 3 sem 2','01-MAR-2021','07-MAR-2021','Paid')
SELECT * FROM dual;

ALTER TABLE student ADD attendance VARCHAR (4) ;

UPDATE student SET attendance = '100%' WHERE student_id = 10005;
UPDATE student SET attendance = '80%' WHERE student_id = 10006;
UPDATE student SET attendance = '70%' WHERE student_id = 10007;
UPDATE student SET attendance = '60%' WHERE student_id = 10008;
UPDATE student SET attendance = '50%' WHERE student_id = 10009;
UPDATE student SET attendance = '40%' WHERE student_id = 10020;

commit;

select 
teacher_name, module_name
from   module
inner  join teacher
on module_id = module_taught;

select amount, student_name
from student
join fee
on student_id=student;

select assignment_type,  student_name, module_name, assignment_type
FROM student
JOIN assignment
ON student.student_id=assignment.student
JOIN module ON module.module_id=assignment.module AND assignment.student=student.student_id
;



