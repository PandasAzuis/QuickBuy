import { Component, OnInit } from "@angular/core"
import { User } from "../../model/user";
import { Router, ActivatedRoute } from "@angular/router";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent implements OnInit {

  public user;
  public returnUrl: string;

  constructor(private router: Router, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.user = new User();
    this.returnUrl = this.activatedRoute.snapshot.queryParams['returnUrl'];
  }

  login() {
    if (this.user.email == "nicoly.melo18@outlook.com" && this.user.password == "0") {
      sessionStorage.setItem("authenticated-user", "1");
      this.router.navigate([this.returnUrl]);
    }
  }

}
