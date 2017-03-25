﻿using Logic;

namespace Web.Tests
{
    using System;
    using Xunit;

    using Task1.Objects;
    using Logic;

    public class CodeGeneratorTests
    {
        [Fact]
        public void L1_Correct_1_1()
        {
            ///Тестовые данные.
            var TestConsumer = new Consumer()
            {
                Name = "1",
                DateReg = new DateTime(2017, 01, 01),
                Account = 1
            };
            
            //правильное решение
            var expectedCode = "20170101____200002";

            ///Запуск теста.
            var Code = Logic1.GenerateCode(TestConsumer);

            ///Сравнение.
            Assert.Equal(expectedCode, Code);
        }

        [Fact]
        public void L1_Correct_1_36()
        {
            ///Тестовые данные.
            var TestConsumer = new Consumer()
            {
                Name = "1",
                DateReg = new DateTime(2017, 01, 01),
                Account = 36
            };

            //правильное решение
            var expectedCode = "20170101____2000LP";

            ///Запуск теста.
            var Code = Logic1.GenerateCode(TestConsumer);

            ///Сравнение.
            Assert.Equal(expectedCode, Code);
        }

        [Fact]
        public void L1_Correct_aa_1()
        {
            ///Тестовые данные.
            var TestConsumer = new Consumer()
            {
                Name = "a0aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                DateReg = new DateTime(2017, 01, 01),
                Account = 1
            };

            //правильное решение
            var expectedCode = "20170101PZVPX00002";

            ///Запуск теста.
            var Code = Logic1.GenerateCode(TestConsumer);

            ///Сравнение.
            Assert.Equal(expectedCode, Code);
        }

        [Fact]
        public void L1_Correct_aaa_1()
        {
            ///Тестовые данные.
            var TestConsumer = new Consumer()
            {
                Name = "aa0aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                DateReg = new DateTime(2017, 01, 01),
                Account = 1
            };

            //правильное решение
            var expectedCode = "20170101Z308X00002";

            ///Запуск теста.
            var Code = Logic1.GenerateCode(TestConsumer);

            ///Сравнение.
            Assert.Equal(expectedCode, Code);
        }

        //пустой объект
        [Fact]
        public void L1_Incorrecе_empty_name()
        {
            ///Тестовые данные.
            var TestConsumer = new Consumer()
            {
                Name = null,
                DateReg = new DateTime(2017, 01, 01),
                Account = 123456789
            };

            ///Запуск теста.
            var ex = Assert.Throws<ArgumentNullException>(() => Logic1.GenerateCode(TestConsumer));

            ///Сравнение.
            Assert.Contains("Не заполнены все поля формы", ex.Message);
        }

        //пустой л/с
        [Fact]
        public void L1_Incorrect_empty_ls()
        {
            ///Тестовые данные.
            var TestConsumer = new Consumer()
            {
                Name = "РогаКопыта",
                DateReg = new DateTime(2017, 01, 01),
                //Account = null
            };

            ///Запуск теста.
            var ex = Assert.Throws<ArgumentNullException>(() => Logic1.GenerateCode(TestConsumer));

            ///Сравнение.
            Assert.Contains("Не заполнены все поля формы", ex.Message);
        }    

        [Fact]
        public void L2_Correct()
        {
            ///Тестовые данные.
            var TestConsumer = new Consumer()
            {
                Name = "абв",
                DateReg = new DateTime(2017, 01, 01),
                Account = 99
            };

            //правильное решение
            var expectedCode = "абв99170101396JNO0";

            ///Запуск теста.
            var Code = Logic2.GenerateCode(TestConsumer);

            ///Сравнение.
            Assert.Equal(expectedCode, Code);
        }
        [Fact]
        public void L2_Correct_short()
        {
            ///Тестовые данные.
            var TestConsumer = new Consumer()
            {
                Name = "1",
                DateReg = new DateTime(1917, 01, 01),
                Account = 62,
            };

            //правильное решение
            var expectedCode = "__162170101_H__24B";

            ///Запуск теста.
            var Code = Logic2.GenerateCode(TestConsumer);

            ///Сравнение.
            Assert.Equal(expectedCode, Code);
        }

        //год на 100 лет отличается
        [Fact]
        public void L2_Correct_short_year()
        {
            ///Тестовые данные.
            var TestConsumer = new Consumer()
            {
                Name = "1",
                DateReg = new DateTime(2017, 01, 01),
                Account = 62,
            };

            //правильное решение
            var expectedCode = "__16217010139__24B";

            ///Запуск теста.
            var Code = Logic2.GenerateCode(TestConsumer);

            ///Сравнение.
            Assert.Equal(expectedCode, Code);
        } 

        //пустой объект
        [Fact]
        public void L2_Incorrecе_empty_name()
        {
            ///Тестовые данные.
            var TestConsumer = new Consumer()
            {
                Name = null,
                DateReg = new DateTime(2017, 01, 01),
                Account = 123456789
            };

            ///Запуск теста.
            var ex = Assert.Throws<ArgumentNullException>(() => Logic2.GenerateCode(TestConsumer));

            ///Сравнение.
            Assert.Contains("Не заполнены все поля формы", ex.Message);
        }

        //пустой л/с
        [Fact]
        public void L2_Incorrect_empty_ls()
        {
            ///Тестовые данные.
            var TestConsumer = new Consumer()
            {
                Name = "РогаКопыта",
                DateReg = new DateTime(2017, 01, 01),
                //Account = null
            };

            ///Запуск теста.
            var ex = Assert.Throws<ArgumentNullException>(() => Logic2.GenerateCode(TestConsumer));

            ///Сравнение.
            Assert.Contains("Не заполнены все поля формы", ex.Message);
        }
    }
}