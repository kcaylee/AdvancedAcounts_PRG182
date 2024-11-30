// script.js

// Array to store account numbers
let accounts = [];

// Function to register an account
function registerAccount() {
  const account = prompt("Enter a new account number:");
  if (account) {
    accounts.push(account);
    alert(`Account ${account} registered successfully!`);
  } else {
    alert("Invalid account number.");
  }
}

// Function to sort accounts
function sortAccounts() {
  if (accounts.length > 0) {
    accounts.sort((a, b) => parseInt(a) - parseInt(b)); // Sort numerically
    alert("Accounts sorted successfully!");
  } else {
    alert("No accounts to sort.");
  }
}

// Function to search for an account
function searchAccount() {
  const search = prompt("Enter account number to search:");
  if (accounts.includes(search)) {
    alert(`Account ${search} found.`);
  } else {
    alert(`Account ${search} not found.`);
  }
}

// Function to update an account
function updateAccount() {
  const oldAccount = prompt("Enter the account number to update:");
  const index = accounts.indexOf(oldAccount);
  if (index !== -1) {
    const newAccount = prompt("Enter the new account number:");
    if (newAccount) {
      accounts[index] = newAccount;
      alert(`Account ${oldAccount} updated to ${newAccount}.`);
    } else {
      alert("Invalid new account number.");
    }
  } else {
    alert(`Account ${oldAccount} not found.`);
  }
}

// Function to delete an account
function deleteAccount() {
  const account = prompt("Enter the account number to delete:");
  const index = accounts.indexOf(account);
  if (index !== -1) {
    accounts.splice(index, 1); // Remove the account from the array
    alert(`Account ${account} deleted successfully.`);
  } else {
    alert(`Account ${account} not found.`);
  }
}

// Function to view all accounts
function viewAccounts() {
  const output = document.getElementById("output");
  if (accounts.length > 0) {
    output.innerHTML = `<h2>Registered Accounts</h2><ul>${accounts
      .map(account => `<li>${account}</li>`)
      .join("")}</ul>`;
  } else {
    output.innerHTML = "<p>No accounts registered.</p>";
  }
}
