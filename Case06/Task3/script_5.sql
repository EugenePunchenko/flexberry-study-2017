/*��� ���������� �������� ������� ��� ��� ������������ �� ���� �������.*/

SELECT s.fio as '���',m.name as '�������������� ������',o.name as '�����������'
  FROM [task3].[dbo].[students] as s 
  JOIN [task3].[dbo].[choice] as ch on s.stud_id=ch.stud_id 
  JOIN [task3].[dbo].[modules]as m  on  ch.mod_id=m.mod_id 
  JOIN [task3].[dbo].[organizations]as o  on  m.org_id=o.org_id 
  WHERE s.fio = '������� 2' AND ch.priority_num = 1
GO

/*��� ������� �������� (������ �� �������� ����� ��������� ������ ��� ��������� 1 � 2!)*/
SELECT s.fio as '���',m.name as '�������������� ������',o.name as '�����������'
  FROM [task3].[dbo].[students] as s 
  JOIN [task3].[dbo].[choice] as ch on s.stud_id=ch.stud_id 
  JOIN [task3].[dbo].[modules]as m  on  ch.mod_id=m.mod_id 
  JOIN [task3].[dbo].[organizations]as o  on  m.org_id=o.org_id 
  WHERE s.fio = '������� 1' AND ch.priority_num = 1
GO