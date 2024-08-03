CREATE VIEW attandanceReport AS SELECT student.id AS ID, student.name AS Name, attandance_sheet._day as [Day],_month as [Month],_year as [Year] FROM attandance_Sheet INNER JOIN student ON student.id=attandance_sheet.std_id_fk



SELECT* FROM attandanceReport where _day=12

CREATE VIEW teacherSchedule AS SELECT schedule.[date] as [Date], schedule.[time] as [Time], teacher.name as [Teacher], subject.subjectname as[Subject]FROM schedule INNER JOIN teacher ON schedule.t_id_fk=teacher.id INNER JOIN subject ON schedule.sub_id_fk=subject.id