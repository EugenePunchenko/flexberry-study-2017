/*�� ��������� ���� ������� �������� ��������������� �����������, 
		� �������� ���� ����������� �������.*/
		
SELECT o.*, cast(year(CURRENT_TIMESTAMP) as varchar)+'-'+cast(month(CURRENT_TIMESTAMP) as varchar)+'-'+cast(day(CURRENT_TIMESTAMP) as varchar)as '������� ����', '������' = 
CASE
  when DATEDIFF(DAY,CURRENT_TIMESTAMP,date_end)<0 then '������� ��������������!' 
  when DATEDIFF(DAY,CURRENT_TIMESTAMP,date_end)>=0 then '������� ������������'
  end 

FROM [task3].[dbo].[organizations]as o
GO

/*���� ������� ����� �� �������*/
SELECT o.*, cast(year(CURRENT_TIMESTAMP) as varchar)+'-'+cast(month(CURRENT_TIMESTAMP) as varchar)+'-'+cast(day(CURRENT_TIMESTAMP) as varchar)as '������� ����'
FROM [task3].[dbo].[organizations]as o
WHERE DATEDIFF(DAY,CURRENT_TIMESTAMP,date_end)>=0 

GO