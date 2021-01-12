DROP TABLE IF EXISTS storage;
CREATE TABLE storage
(id int NOT NULL PRIMARY KEY IDENTITY(1,1),
name varchar(100) NOT NULL,
address varchar(255) NULL,
phone varchar(20) NULL,
storage_space varchar(100) NULL,
med_type varchar(100) NULL,
notes varchar(255) NULL);

DROP TABLE IF EXISTS suppliers;
CREATE TABLE suppliers
(id int NOT NULL PRIMARY KEY IDENTITY(1,1),
name varchar(100) NOT NULL,
address varchar(255) NOT NULL,
phone varchar(20) NOT NULL,
quality varchar(100) NOT NULL,
capabilities varchar(100) NOT NULL,
deliver_speed_d int NOT NULL,
notes varchar(255) NOT NULL);

DROP TABLE IF EXISTS sales;
CREATE TABLE sales
(id int NOT NULL PRIMARY KEY IDENTITY(1,1),
date datetime NULL,
supplier varchar(150) NULL,
med_type varchar(150) NOT NULL,
amount int NOT NULL,
total int NOT NULL,
notes varchar(150) NOT NULL,
status varchar(150) NOT NULL);

DROP TABLE IF EXISTS employees;
CREATE TABLE employees
(id int NOT NULL PRIMARY KEY IDENTITY(1,1),
name varchar(100) NOT NULL,
phone varchar(20) NULL,
address varchar(255) NULL,
job_title varchar(100) NOT NULL,
hire_date date NOT NULL,
salary int NOT NULL);