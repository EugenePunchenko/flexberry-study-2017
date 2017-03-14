/***������� ������� �����������, ����������� �� ��������: 
�� ������� �������� 
	1-�� ���������� ����� 3 �����, 
	2-�� ���������� - 2 �����, 
	3-�� ���������� - 1 ����.***/
	
SELECT o.name, sum(4-ch.priority_num) as  '����'
  FROM [task3].[dbo].[students] as s 
  JOIN [task3].[dbo].[choice] as ch on s.stud_id=ch.stud_id 
  JOIN [task3].[dbo].[modules]as m  on  ch.mod_id=m.mod_id 
  JOIN [task3].[dbo].[organizations]as o  on  m.org_id=o.org_id 
   WHERE (4-ch.priority_num) > 0
   GROUP BY o.name
   ORDER BY '����' desc
GO


