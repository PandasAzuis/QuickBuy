import { Component } from "@angular/core"
import { User } from "../../model/user";
import { Router } from "@angular/router";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {

  public user;

  constructor(private router: Router) {
    this.user = new User();
  }

  login() {
    if (this.user.email == "nicoly.melo18@outlook.com" && this.user.password == "0") {
      sessionStorage.setItem("authenticated-user", "1");
      this.router.navigate(['/']);
    }
  }

}
