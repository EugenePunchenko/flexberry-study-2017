/*������� ������ ���������, ������� ������� ������ ����������� ��������� �����������.*/

SELECT s.*, o.name, ch.priority_num as '���������'
  FROM [task3].[dbo].[students] as s 
  JOIN [task3].[dbo].[choice] as ch on s.stud_id=ch.stud_id 
  JOIN [task3].[dbo].[modules]as m  on  ch.mod_id=m.mod_id 
  JOIN [task3].[dbo].[organizations]as o  on  m.org_id=o.org_id 
  WHERE 
			o.name = '������'
		AND
			ch.priority_num = 1
GO


