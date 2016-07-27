﻿using System;
using System.Collections;
using System.Collections.Generic;
using Orion.Framework;

namespace Orion.Authorization
{
	/// <summary>
	/// Service Definition: UserAccountService
	/// 
	/// Controls access to user accounts, groups and permissions and enables Orion to
	/// </summary>
	public interface IUserAccountService : IService
	{
		/// <summary>
		/// Returns a list of user accounts in the system, optionally filtered by a predicate expression.
		/// </summary>
		/// <param name="predicate">
		/// (optional) A predicate expression for filtering user accounts
		/// </param>
		/// <returns>
		/// An enumerable of <see cref="IUserAccount"/> objects satisfying the supplied predicate.  If no predicate 
		/// is specified, an enumerable of all user accounts are returned.
		/// </returns>
		IEnumerable<IUserAccount> Find(Predicate<IUserAccount> predicate = null);

		/// <summary>
		/// Adds an account with the specified account name to the account service in the default group.
		/// </summary>
		/// <param name="accountName">
		/// A string referring to the account name
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Thrown when the account name already exists
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Thrown if <paramref name="accountName"/> is null or empty
		/// </exception>
		void AddAccount(string accountName);

		/// <summary>
		/// Sets the account password to the specified password in clear-text.
		/// </summary>
		/// <param name="password">
		/// A string containing the clear text password of the account to be changed to
		/// </param>
		/// <remarks>
		/// This method force-updates the password on this account without re-authenticating, and should be considered an admin
		/// only function.
		/// </remarks>
		void SetPassword(string password);

		/// <summary>
		/// Updates the account password with a clear-text password specified by <paramref name="newPassword"/>, if the current 
		/// password on the account matches the clear-text password specified by <paramref name="currentPassword"/>.
		/// </summary>
		/// <param name="currentPassword">
		/// A string containing the clear-text password currently on the account.
		/// </param>
		/// <param name="newPassword">
		/// A string containing the new clear-text password for the account, if the current password matches.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Thrown if authentication failed on the account specifying <paramref name="currentPassword"/>, or <paramref name="newPassword"/>
		/// does not meet the password complexity requirements
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Thrown if <paramref name="currentPassword"/> or <paramref name="newPassword"/> is null or empty
		/// </exception>
		void ChangePassword(string currentPassword, string newPassword);

		/// <summary>
		/// Authenticates this user account with the specified clear-text password.
		/// </summary>
		/// <param name="password">
		/// A string containing the clear-text password to authenticate this account with.
		/// </param>
		/// <returns>
		/// true if the account authentication succeeded, false otherwise.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Thrown when <paramref name="password"/> is null or empty.
		/// </exception>
		bool Authenticate(string password);
	}
}