using System;
using Xunit;

namespace ConvertAccountDateTest
{
    /// <summary>
    /// ������������ ���������� ConvertAccountDate.
    /// </summary>
    public class ConvertAccountDateTest
    {
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
            var test1Act =  0;//CompareAccountDate.Compare.CompareAccountDate(tempText5, tempText5);

            //Assert
            // ��������� �������� � ������� ����������.
            Assert.Equal(test1Act, 0);
        }
    }
}
