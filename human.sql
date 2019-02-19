create database human
go
use human

create table User_level
(
id int identity(1,1) primary key not null,
name nvarchar(255)
)
insert User_level values(N'Admin')
insert User_level values(N'Member')

create table Users
(
id int identity(1,1) primary key not null,
email varchar(255),
password varchar(255),
fullname nvarchar(255),
address ntext,
phone varchar(15),
hometown ntext,
avatar ntext,
note ntext,
birthday date,
level_id int foreign key references User_level(id),
remember_token ntext,
created_at datetime,
updated_at datetime
)
insert Users values(N'phong@gmail.com','123456',N'Nguyễn Thanh Phong',N'Hòa Hiệp','0985632145','Đà Nẵng','avatar12345gfdgfdjhg','notetest','1990-12-12',1,null,null,null)
insert Users values(N'lam@gmail.com','123456',N'Nguyễn Văn Lâm',N'Quận 9','0985615745','TP. Hồ Chí Minh','avatar312345gfdgfdjhg','notetest1','1995-10-10',2,null,null,null)

create table Salary_char
(
id int identity(1,1) primary key not null,
name nvarchar(50),
chars varchar(5)
)

create table Self_language
(
id int identity(1,1) primary key not null,
name nvarchar(255),
level nvarchar(255)
)

create table Skill
(
id int identity(1,1) primary key not null,
name nvarchar(255)
)

create table Candidate
(
id int identity(1,1) primary key not null,
fullname nvarchar(255),
email varchar(255),
password varchar(255),
birthday date,
address ntext,
phone varchar(15),
img ntext,
cv_title ntext,
company_name ntext,
work_time_from date,
work_time_to date,
experience_year int,
current_position ntext,
desire_position ntext,
desire_job ntext,
desire_salary ntext,
salary_char_id int foreign key references Salary_char(id),
desire_work_location ntext,
career_goal ntext,
education_school_name ntext,
education_time_from date,
education_time_to date,
speciality nvarchar(255),
graduate_level nvarchar(255),
self_language_id int foreign key references Self_language(id),
language_other nvarchar(255),
skill_id int foreign key references Skill(id),
skill_other ntext,
hobby ntext,
facebook ntext,
idloginsocial ntext,
status_active int,
user_id int foreign key references Users(id),
created_at datetime,
updated_at datetime
)

create table Web_language
(
id int identity(1,1) primary key not null,
name nvarchar(255),
img ntext,
chars varchar(5)
)

create table Contact_us
(
id int identity(1,1) primary key not null,
name nvarchar(255),
email nvarchar(255),
address ntext,
phone varchar(15),
subject ntext,
content ntext,
created_at datetime,
updated_at datetime
)

create table Company
(
id int identity(1,1) primary key not null,
email nvarchar(255),
password varchar(255),
name nvarchar(255),
address ntext,
phone varchar(15),
fax nvarchar(255),
img ntext,
establish varchar(5),
founder nvarchar(255),
member_quantity int,
introduce ntext,
website nvarchar(255),
status_active int,
user_id int foreign key references Users(id),
created_at datetime,
updated_at datetime
)

create table Employment
(
id int identity(1,1) primary key not null,
name nvarchar(255)
)

create table Recruit
(
id int identity(1,1) primary key not null,
company_id int foreign key references Company(id),
title ntext,
quantity int,
sex int,
job_description ntext,
work_location ntext,
work_time ntext,
holiday ntext,
condition ntext,
employment_id int foreign key references Employment(id),
education_level nvarchar(255),
salary nvarchar(255),
salary_char_id int foreign key references Salary_char(id),
training_time nvarchar(255),
welfare ntext,
applicable_nationality nvarchar(255),
selection_process ntext,
status_active int,
user_id int foreign key references Users(id),
created_at datetime,
updated_at datetime,
)

create table Modnews
(
id int identity(1,1) primary key not null,
mod_name ntext,
mod_img ntext,
description ntext,
slug text,
user_id int foreign key references Users(id),
)

create table Listnews
(
id int identity(1,1) primary key not null,
modnews_id int foreign key references Modnews(id),
name ntext,
img ntext,
description ntext,
slug text,
user_id int foreign key references Users(id),
)

create table News
(
id int identity(1,1) primary key not null,
listnews_id int foreign key references Listnews(id),
name ntext,
intro ntext,
content ntext,
img ntext,
status_active int,
user_id int foreign key references Users(id),
created_at datetime,
updated_at datetime
)