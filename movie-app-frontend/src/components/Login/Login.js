import React, { Fragment, useState } from "react";

import "./Login.css";

const Login = () => {
  const [formData, setFormData] = useState({
    email: "",
    password: "",
  });

  const { email, password } = formData;

  const onChange = (e) =>
    setFormData({ ...formData, [e.target.name]: e.target.value });

  const onSubmit = async (e) => {
   

  };



  return (
    <Fragment>
      <div className="loginContainer">
        <div className="login-form">
          <h1 className="large text-primary">Sign In</h1>
          <form className="form" onSubmit={(e) => onSubmit(e)}>
            <div className="form-group">
              <input
                type="email"
                placeholder="Email Address"
                name="email"
                value={email}
                onChange={(e) => onChange(e)}
              />
            </div>
            <div className="form-group">
              <input
                type="password"
                placeholder="Password"
                name="password"
                minLength="6"
                value={password}
                onChange={(e) => onChange(e)}
              />
            </div>

            <input type="submit" className="login-btn" value="Login" />
          </form>
        </div>
      </div>
    </Fragment>
  );
};

export default Login