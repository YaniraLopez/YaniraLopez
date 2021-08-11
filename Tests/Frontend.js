require("dotenv").config({path: '/Credencials/.env'});
import LoginPage from '../Elements/LogIn';


fixture `Frontend test scripts`
    .page `https://todoist.com/`
test
    .page `https://todoist.com/Users/showLogin`
    ('succesfull login', async t => {
        const email = process.env.USER_EMAIL;
        const password = process.env.PASSWORD;

        const EmailTbox = Selector('.input_email');
        const PasswordTbox = Selector('.form_field_control');
        const LoginBtn = Selector('.submit_btn');

        await t 
        .typeText(LoginPage.emailInput, email)
        .typeText(LoginPage.passwordInput, password)
        .click(LoginBtn.LoginBtn)
        .wait(5000)
    });