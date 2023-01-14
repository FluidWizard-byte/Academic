CREATE TABLE address (
    address_id INT NOT NULL,
    city VARCHAR (25) NOT NULL,
    zip NUMBER(5) NOT NULL,
    CONSTRAINT address_pk PRIMARY KEY (address_id)
);

CREATE TABLE course (
    course_id INT NOT NULL,
    course_name VARCHAR (25) NOT NULL,
    CONSTRAINT course_pk PRIMARY KEY (course_id)
);

CREATE TABLE module(
    module_id INT NOT NULL,
    course INT NOT NULL,
    module_code VARCHAR (8) NOT NULL,
    module_name VARCHAR (45) NOT NULL,
    credit_hours INT NOT NULL,
    CONSTRAINT module_pk PRIMARY KEY (module_id),
    CONSTRAINT module_fk FOREIGN KEY(course) REFERENCES course(course_id)
);

CREATE TABLE department(
    department_id INT NOT NULL,
    department_name VARCHAR (15) NOT NULL,
    department_head VARCHAR (25) NOT NULL,
    CONSTRAINT department_pk PRIMARY KEY (department_id)
);

CREATE TABLE student (
    student_id INT NOT NULL,
    student_name VARCHAR (25) NOT NULL,
    student_DOB DATE NOT NULL,
    student_address INT NOT NULL,
    enrolled_course INT NOT NULL,
    student_email VARCHAR (45) NOT NULL,
    student_phone VARCHAR (14) NOT NULL,
    CONSTRAINT student_pk PRIMARY KEY (student_id),
    CONSTRAINT student_fk FOREIGN KEY(student_address) REFERENCES address(address_id),
    CONSTRAINT student_fk1 FOREIGN KEY(enrolled_course) REFERENCES course(course_id)
);

CREATE TABLE teacher(
    teacher_id INT NOT NULL,
    teacher_name VARCHAR (25) NOT NULL,
    module_taught INT NOT NULL,
    department INT NOT NULL,
    teacher_address INT NOT NULL,
    teacher_email VARCHAR (45) NOT NULL,
    teacher_phone VARCHAR (14) NOT NULL,
    CONSTRAINT teacher_pk PRIMARY KEY (teacher_id),
    CONSTRAINT teacher_fk FOREIGN KEY(teacher_address) REFERENCES address(address_id),
    CONSTRAINT teacher_fk1 FOREIGN KEY(department) REFERENCES department(department_id),
    CONSTRAINT teacher_fk2 FOREIGN KEY(module_taught) REFERENCES module(module_id)
);

CREATE TABLE assignment(
    assignment_id INT NOT NULL,
    student INT NOT NULL,
    module INT NOT NULL,
    assignment_type VARCHAR (25) NOT NULL,
    grade_obtained VARCHAR (2) NOT NULL,
    status VARCHAR (4) NOT NULL,
    CONSTRAINT assignment_pk PRIMARY KEY (assignment_id),
    CONSTRAINT assignment_fk FOREIGN KEY(student) REFERENCES student(student_id),
    CONSTRAINT assignment_fk1 FOREIGN KEY(module) REFERENCES module(module_id)
);


CREATE TABLE fee(
    fee_id INT NOT NULL,
    student INT NOT NULL,
    amount INT NOT NULL,
    year_semester VARCHAR (15) NOT NULL,
    due_date DATE NOT NULL,
    payment_date DATE,
    remarks VARCHAR (20) NOT NULL,
    CONSTRAINT fee_pk PRIMARY KEY (fee_id),
    CONSTRAINT fee_fk FOREIGN KEY(student) REFERENCES student(student_id)
);

CREATE SEQUENCE address_sequence
    start with 100
    increment by 1;

CREATE OR REPLACE TRIGGER address_on_insert
    BEFORE INSERT ON address
    FOR EACH ROW
BEGIN
    SELECT address_sequence.nextval
    INTO :new.address_id
    FROM dual;
END;

CREATE SEQUENCE course_sequence
    start with 1
    increment by 1;

CREATE OR REPLACE TRIGGER course_on_insert
    BEFORE INSERT ON course
    FOR EACH ROW
BEGIN
    SELECT course_sequence.nextval
    INTO :new.course_id
    FROM dual;
END;

CREATE SEQUENCE assignment_sequence
    start with 1
    increment by 1;

CREATE OR REPLACE TRIGGER assignment_on_insert
    BEFORE INSERT ON assignment
    FOR EACH ROW
BEGIN
    SELECT assignment_sequence.nextval
    INTO :new.assignment_id
    FROM dual;
END;

CREATE SEQUENCE fee_sequence
    start with 1
    increment by 1;

CREATE OR REPLACE TRIGGER fee_on_insert
    BEFORE INSERT ON fee
    FOR EACH ROW
BEGIN
    SELECT fee_sequence.nextval
    INTO :new.fee_id
    FROM dual;
END;

CREATE SEQUENCE department_sequence
    start with 1
    increment by 1;

CREATE OR REPLACE TRIGGER department_on_insert
    BEFORE INSERT ON department
    FOR EACH ROW
BEGIN
    SELECT department_sequence.nextval
    INTO :new.department_id
    FROM dual;
END;

CREATE SEQUENCE module_sequence
    start with 1
    increment by 1;

CREATE OR REPLACE TRIGGER module_on_insert
    BEFORE INSERT ON module
    FOR EACH ROW
BEGIN
    SELECT module_sequence.nextval
    INTO :new.module_id
    FROM dual;
END;

CREATE SEQUENCE student_sequence
    start with 10000
    increment by 1;

CREATE OR REPLACE TRIGGER student_on_insert
    BEFORE INSERT ON student
    FOR EACH ROW
BEGIN
    SELECT student_sequence.nextval
    INTO :new.student_id
    FROM dual;
END;

CREATE SEQUENCE teacher_sequence
    start with 10000
    increment by 1;

CREATE OR REPLACE TRIGGER teacher_on_insert
    BEFORE INSERT ON teacher
    FOR EACH ROW
BEGIN
    SELECT teacher_sequence.nextval
    INTO :new.teacher_id
    FROM dual;
END;

