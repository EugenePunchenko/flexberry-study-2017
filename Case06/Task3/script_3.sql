/***��� ������� �������� ������� ��� ���� �������***/
 
  SELECT s.fio as '���',s.birthday as '���� ��������', '���� �������'=
  case  
	when (DAY(birthday) between 21 and 31 and MONTH(birthday)= 3) 
	  OR (DAY(birthday) between 1 and 20 and MONTH(birthday) = 4) then '����'
	when (DAY(birthday) between 23 and 31 and MONTH(birthday)= 7) 
	  OR (DAY(birthday) between 1 and 23 and MONTH(birthday) = 8) then '���'
	when (DAY(birthday) between 23 and 30 and MONTH(birthday)= 11) 
	  OR (DAY(birthday) between 1 and 21 and MONTH(birthday) = 12) then '�������'
	when (DAY(birthday) between 21 and 30 and MONTH(birthday)= 4) 
	  OR (DAY(birthday) between 1 and 20 and MONTH(birthday) = 5) then '�����'
	when (DAY(birthday) between 24 and 31 and MONTH(birthday)= 8) 
	  OR (DAY(birthday) between 1 and 23 and MONTH(birthday) = 9) then '����'
	when (DAY(birthday) between 22 and 31 and MONTH(birthday)= 12) 
	  OR (DAY(birthday) between 1 and 20 and MONTH(birthday) = 1) then '�������'
	when (DAY(birthday) between 21 and 31 and MONTH(birthday)= 5) 
	  OR (DAY(birthday) between 1 and 21 and MONTH(birthday) = 6) then '��������'
	when (DAY(birthday) between 24 and 30 and MONTH(birthday)= 9) 
	  OR (DAY(birthday) between 1 and 23 and MONTH(birthday) = 10) then '����'
	when (DAY(birthday) between 21 and 31 and MONTH(birthday)= 1) 
	  OR (DAY(birthday) between 1 and 20 and MONTH(birthday) = 2) then '�������'
	when (DAY(birthday) between 22 and 30 and MONTH(birthday)= 6) 
	  OR (DAY(birthday) between 1 and 22 and MONTH(birthday) = 7) then '���'
	when (DAY(birthday) between 24 and 31 and MONTH(birthday)= 10) 
	  OR (DAY(birthday) between 1 and 22 and MONTH(birthday) = 11) then '��������'
	when (DAY(birthday) between 21 and 29 and MONTH(birthday)= 2) 
	  OR (DAY(birthday) between 1 and 20 and MONTH(birthday) = 3) then '����'
	end
  FROM [task3].[dbo].[students] as s   
GO



