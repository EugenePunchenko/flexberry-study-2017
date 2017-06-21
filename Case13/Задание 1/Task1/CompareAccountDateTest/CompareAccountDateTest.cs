using System;
using Xunit;

using CompareAccountDate;

namespace CompareAccountDateTest
{
    /// <summary>
    /// ������������ ���������� CompareAccountDate.
    /// </summary>
    public class CompareAccountDateTest
    {
        /// <summary>
        /// �������� ����� ��� �������� ������ (<see cref="CompareAccountDate"/>).
        /// ���� ��������� ��������� �����:
        /// <list type="number">
        /// <item><description>�������� ��� ������������ ������.</description></item> 
        /// <item><description>�������� ��������� �������� ������ ������� �������.</description></item> 
        /// <item><description>�������� ��������� 2 �������� � ������� ��������.</description></item> 
        /// </list> 
        /// </summary>
        [Fact]
        public void CompareAccountDateCompareTest()
        {
            // Arrange.
            string[] tempText1 = new string[]
            {
                "����� PMasalkin",
                "E-Mail pashamasalkin@yandex.ru",
                "������� ��������",
                "��� �����",
                "�������� ����������",
                "��� �",
                "����_�������� 1994",
                "����� �����������",
                "������ ������",
                "������� http:\\www.temp.ru"
            };

            string[] tempText3 = new string[]
            {
                "��� �",
                "����_�������� 1994",
                "����� �����������",
                "������ ������",
                "������� http:\\www.temp.ru"
            };

            string[] tempText4 = new string[]
            {
                "����� PMasalkin1",
                "E-Mail pashamasalkin@yandex.ru1",
                "������� ��������1",
                "��� �����1",
                "�������� ����������1",
                "��� �1",
                "����_�������� 19941",
                "����� �����������1",
                "������ ������1",
                "������� http:\\www.temp.ru"
            };

            string[] tempText2 = new string[] { };

            //Act
            var test1Act = CompareAccountDate.Compare.CompareAccountDate(tempText1, tempText1);
            var test2Act = CompareAccountDate.Compare.CompareAccountDate(tempText1, tempText3);
            var test3Act = CompareAccountDate.Compare.CompareAccountDate(tempText1, tempText4);
            var test4Act = CompareAccountDate.Compare.CompareAccountDate(tempText1, tempText2);

            //Assert

            // C��������� ���������� ��������
            Assert.Equal(test1Act, 100);

            // ���������� � ������� ��������
            Assert.Equal(test2Act, 50);

            // ��������� � �������� � 1 ������� �����
            Assert.Equal(test3Act, 10);

            // ��������� ������� ������� � ������.
            Assert.Equal(test4Act, 0);
        }

        /// <summary>
        /// �������� ����� ��� �������� ������ � ����������� � ������ ������� ���������� (<see cref="CompareAccountDate"/>).
        /// ���� ��������� ��������� �����:
        /// <list type="number">
        /// <item><description>�������� ��������� � ����������� � ������ ������� ����������.</description></item> 
        /// </list> 
        /// </summary>
        [Fact]
        public void CompareAccountDateInputWithEmptyTest()
        {
            // Arrange.
            string[] tempText5 = new string[]
            {
                string.Empty
            };

            //Act
            var test1Act = CompareAccountDate.Compare.CompareAccountDate(tempText5, tempText5);

            //Assert
            // ��������� �������� � ������� ����������.
            Assert.Equal(test1Act, 0);
        }

        /// <summary>
        /// �������� ����� ��� �������� ������ � ����������� � ������ null ���������� (<see cref="CompareAccountDate"/>).
        /// ���� ��������� ��������� �����:
        /// <list type="number">
        /// <item><description>�������� ��������� � ����������� � ������ null ����������.</description></item> 
        /// </list> 
        /// </summary>
        [Fact]
        public void CompareAccountDateInputWithNullTest()
        {
            // Arrange.
            string[] tempText6 = new string[]
            {
                null
            };

            //Act
            var test1Act = CompareAccountDate.Compare.CompareAccountDate(tempText6, tempText6);

            //Assert
            // ��������� �������� � null ���������.
            Assert.Equal(test1Act, 0);
        }

        /// <summary>
        /// �������� ����� ��� �������� ������ ��� �������� null ��������� (<see cref="CompareAccountDate"/>).
        /// ���� ��������� ��������� �����:
        /// <list type="number">
        /// <item><description>����� ������ ��� �������� �������� null ��������.</description></item> 
        /// </list> 
        /// </summary>
        [Fact]
        public void CompareAccountDateInputNullTest()
        {
            // ���������  null ���������.
            try
            {
                //Act
                CompareAccountDate.Compare.CompareAccountDate(null, null);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.Equal(ex.Message, CompareAccountDate.Compare.CompareAccountDateNullExeptionText);
            }
        }
    }
}
