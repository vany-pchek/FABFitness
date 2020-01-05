﻿using System;

namespace FABFitness.BL.Model
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public class User
    {
        #region Свойства
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime BirthDate { get; }
        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Рост.
        /// </summary>
        public double Height { get; set; }
        #endregion
        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="birthDate"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        public User(string name,
            Gender gender,
            DateTime birthDate,
            double weight,
            double height)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null.", nameof(name));
            }

           if(Gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null.", nameof(gender));

            }

           if(birthDate < DateTime.Parse("01.01.1900")&& birthDate >= DateTime.Now)
            {
                throw new ArgumentNullException("Невозможная дата рождения", nameof(birthDate));
            }
            
           if(weight <= 0)
            {
                throw new ArgumentNullException("Вес не может быть меньше либо равен нулю", nameof(weight));
            }

           if(height <= 0)
            {
                throw new ArgumentNullException("Рост не может быть меньше либо равен нулю.", nameof(height));
            }
            #endregion
        }

        public override string ToString()
        {
            return Name;
        }


    }
}
