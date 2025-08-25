

function signUp(username, password) {
  if (!username || !password) {
    showMessage("Please enter both fields.", "red");
    return;
  }

  if (localStorage.getItem(username)) {
    showMessage("User already exists!", "orange");
  } else {
    localStorage.setItem(username, password);
    showMessage("Sign up successful!", "green");
    
  }
}

function signIn(username, password) {
  if (!username || !password) {
    showMessage("Please enter both fields.", "red");
    return;
  }

  const storedPassword = localStorage.getItem(username);

  if (storedPassword === null) {
    showMessage("User does not exist. Please sign up.", "orange");
  } else if (storedPassword === password) {
    showMessage(`Welcome ${username}`, "green");
   
  } else {
    showMessage("Invalid credentials.", "red");
  }
}
