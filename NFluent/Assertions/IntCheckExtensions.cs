﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IntCheckExtensions.cs" company="">
// //   Copyright 2013 Thomas PIERRAIN
// //   Licensed under the Apache License, Version 2.0 (the "License");
// //   you may not use this file except in compliance with the License.
// //   You may obtain a copy of the License at
// //       http://www.apache.org/licenses/LICENSE-2.0
// //   Unless required by applicable law or agreed to in writing, software
// //   distributed under the License is distributed on an "AS IS" BASIS,
// //   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// //   See the License for the specific language governing permissions and
// //   limitations under the License.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------
namespace NFluent
{
    using System;

    using NFluent.Extensions;
    using NFluent.Helpers;

    /// <summary>
    /// Provides check methods to be executed on an integer value.
    /// </summary>
    public static class IntCheckExtensions
    {
        private const string DoNotChangeOrRemoveThisLine = Constants.AutoGeneratedNumberClassDisclaimerPlaceHolder;

        // Since this class is the model/template for the generation of all the other numbers related CheckExtensions classes, don't forget to re-generate all the other classes every time you change this one. To do that, just save the ..\T4\NumberFluentAssertionGenerator.tt file within Visual Studio 2012. This will trigger the T4 code generation process.

        /// <summary>
        /// Checks that the actual value is equal to another expected value.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <param name="expected">The expected value.</param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">The actual value is not equal to the expected value.</exception>
        public static ICheckLink<ICheck<int>> IsEqualTo(this ICheck<int> check, object expected)
        {
            // TODO transform NumberCheck<T> into a static class with functions only?
            var numberCheckStrategy = new NumberCheck<int>(check);
            return numberCheckStrategy.IsEqualTo(expected);
        }

        /// <summary>
        /// Checks that the actual value is not equal to another expected value.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <param name="expected">The expected value.</param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">The actual value is equal to the expected value.</exception>
        public static ICheckLink<ICheck<int>> IsNotEqualTo(this ICheck<int> check, object expected)
        {
            var numberCheckStrategy = new NumberCheck<int>(check);
            return numberCheckStrategy.IsNotEqualTo(expected);
        }

        /// <summary>
        /// Checks that the actual instance is an instance of the given type.
        /// </summary>
        /// <typeparam name="T">The expected Type of the instance.</typeparam>
        /// <param name="check">The fluent check to be extended.</param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">The actual instance is not of the provided type.</exception>
        public static ICheckLink<ICheck<int>> IsInstanceOf<T>(this ICheck<int> check)
        {
            var numberCheckStrategy = new NumberCheck<int>(check);
            return numberCheckStrategy.IsInstanceOf<T>();
        }

        /// <summary>
        /// Checks that the actual instance is an instance of the given type.
        /// </summary>
        /// <typeparam name="T">The expected Type of the instance.</typeparam>
        /// <param name="check">The fluent check to be extended.</param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">The actual instance is not of the provided type.</exception>
        public static ICheckLink<ICheck<int?>> IsInstanceOf<T>(this ICheck<int?> check)
        {
            var checkRunner = check as ICheckRunner<int?>;
            IRunnableCheck<int?> runnableCheck = check as IRunnableCheck<int?>;

            checkRunner.ExecuteCheck(
                () =>
                {
                    IsInstanceHelper.IsSameType(typeof(Nullable<int>), typeof(T), runnableCheck.Value);
                },
                IsInstanceHelper.BuildErrorMessageForNullable(typeof(Nullable<int>), typeof(T), runnableCheck.Value, true));

            return new CheckLink<ICheck<int?>>(check);
        }

        /// <summary>
        /// Checks that the actual instance is not an instance of the given type.
        /// </summary>
        /// <typeparam name="T">The type not expected for this instance.</typeparam>
        /// <param name="check">The fluent check to be extended.</param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">The actual instance is of the provided type.</exception>
        public static ICheckLink<ICheck<int>> IsNotInstanceOf<T>(this ICheck<int> check)
        {
            var numberCheckStrategy = new NumberCheck<int>(check);
            return numberCheckStrategy.IsNotInstanceOf<T>();
        }

        /// <summary>
        /// Checks that the actual value is equal to zero.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">The value is not equal to zero.</exception>
        public static ICheckLink<ICheck<int>> IsZero(this ICheck<int> check)
        {
            var numberCheckStrategy = new NumberCheck<int>(check);
            return numberCheckStrategy.IsZero();
        }

        /// <summary>
        /// Checks that the actual nullable value has a value and thus, is not null.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <returns>A check link.</returns>
        /// <exception cref="FluentCheckException">The value is null.</exception>
        public static INullableOrNumberCheckLink<int> HasAValue(this ICheck<int?> check)
        {
            var checkRunner = check as ICheckRunner<int?>;
            IRunnableCheck<int?> runnableCheck = check as IRunnableCheck<int?>;

            checkRunner.ExecuteCheck(
                () =>
                {
                    if (runnableCheck.Value == null)
                    {
                        throw new FluentCheckException(string.Format("\nThe checked nullable value has no value, which is unexpected."));
                    }
                },
                string.Format("\nThe checked nullable value:\n\t[{0}]\nhas a value, which is unexpected.", runnableCheck.Value.ToStringProperlyFormated()));

            return new NullableOrNumberCheckLink<int>(check);
        }

        /// <summary>
        /// Checks that the actual nullable value has no value and thus, is null. 
        /// Note: this method does not return A check link since the nullable is null.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <exception cref="FluentCheckException">The value is not null.</exception>
        public static void HasNoValue(this ICheck<int?> check)
        {
            var checkRunner = check as ICheckRunner<int?>;
            IRunnableCheck<int?> runnableCheck = check as IRunnableCheck<int?>;

            checkRunner.ExecuteCheck(
                () =>
                {
                    if (runnableCheck.Value != null)
                    {
                        throw new FluentCheckException(string.Format("\nThe checked nullable value:\n\t[{0}]\nhas a value, which is unexpected.", runnableCheck.Value));
                    }
                },
                "\nThe checked nullable value has no value, which is unexpected.");
        }
        
        /// <summary>
        /// Checks that the actual value is NOT equal to zero.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <returns>
        ///   <returns>A check link.</returns>
        /// </returns>
        /// <exception cref="FluentCheckException">The value is equal to zero.</exception>
        public static ICheckLink<ICheck<int>> IsNotZero(this ICheck<int> check)
        {
            var numberCheckStrategy = new NumberCheck<int>(check);
            return numberCheckStrategy.IsNotZero();
        }

        /// <summary>
        /// Checks that the actual value is strictly positive.
        /// </summary>
        /// <param name="check">The fluent check to be extended.</param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">The value is not strictly positive.</exception>
        public static ICheckLink<ICheck<int>> IsPositive(this ICheck<int> check)
        {
            var numberCheckStrategy = new NumberCheck<int>(check);
            return numberCheckStrategy.IsPositive();
        }

        /// <summary>
        /// Checks that the actual value is less than an operand.
        /// </summary>
        /// <param name="check">
        /// The fluent check to be extended.
        /// </param>
        /// <param name="comparand">
        /// Comparand to compare the value to.
        /// </param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">
        /// The value is not less than the comparand.
        /// </exception>
        public static ICheckLink<ICheck<int>> IsLessThan(this ICheck<int> check, int comparand)
        {
            var numberCheckStrategy = new NumberCheck<int>(check);
            return numberCheckStrategy.IsLessThan(comparand);
        }

        /// <summary>
        /// Checks that the actual value is more than an operand.
        /// </summary>
        /// <param name="check">
        /// The fluent check to be extended.
        /// </param>
        /// <param name="comparand">
        /// Comparand to compare the value to.
        /// </param>
        /// <returns>
        /// A check link.
        /// </returns>
        /// <exception cref="FluentCheckException">
        /// The value is not less than the comparand.
        /// </exception>
        public static ICheckLink<ICheck<int>> IsGreaterThan(this ICheck<int> check, int comparand)
        {
            var numberCheckStrategy = new NumberCheck<int>(check);
            return numberCheckStrategy.IsGreaterThan(comparand);
        }
    }
}