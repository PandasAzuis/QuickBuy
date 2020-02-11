import { Component, OnInit } from "@angular/core"
import { User } from "../../model/user";
import { Router, ActivatedRoute } from "@angular/router";
import { UserService } from "../../services/user/user.service";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent implements OnInit {

  public user;
  public returnUrl: string;
  public message: string;

  constructor(private router: Router,
    private activatedRoute: ActivatedRoute,
    private userService: UserService) {
  }

  ngOnInit(): void {
    this.user = new User();
    this.returnUrl = this.activatedRoute.snapshot.queryParams['returnUrl'];
  }

  login() {

    this.userService
      .checkUser(this.user)
      .subscribe(
        data => {

          var userReturn: User;
          userReturn = data;

          sessionStorage.setItem("authenticated-user", "1");
          sessionStorage.setItem("user-email", userReturn.email);

          if (this.returnUrl == null) {
             // navigate for initial page 
            this.router.navigate(["/"])
          } else {
            // navigate for departure page 
            this.router.navigate([this.returnUrl]);
          }
        },
        err => {
          this.message = err.error;
        }
      );

  }

}
