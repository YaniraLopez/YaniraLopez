import { t, Selector } from 'testcafe'
​
class LoginPage {
    constructor() {
        this.EmailTbox = Selector('.input_email');
        this.PasswordTbox = Selector('.form_field_control');
        this.LoginBtn = Selector('.submit_btn');
        this.errorMsg = Selector('p.error-message')
    }
​
    loginFlow = async (username, password) => {
        await t
            .typeText(this.userInput, username)
            .typeText(this.passwordInput, password)
            .click(this.loginBtn)
    }
}
​
export default new LoginPage()