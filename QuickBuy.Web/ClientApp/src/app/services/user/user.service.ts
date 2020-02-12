import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { User } from "../../model/user";

@Injectable({
  providedIn: "root"
})
export class UserService {

  private baseURL: string;
  private _user: User;

  get user(): User {
    let user_json = sessionStorage.getItem("authenticated-user");
    this._user = JSON.parse(user_json);
    return this._user;
  }

  set user(user: User) {
    sessionStorage.setItem("authenticated-user",JSON.stringify(user));
    this._user = user;
  }

  public authenticatedUser(): boolean {
    return this._user != null && this._user.email != "" && this._user.password != "";
  }

  public toCleanSession() {
    sessionStorage.setItem("authenticated-user", "0");
    this._user = null;
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  public checkUser(user: User): Observable<User> {
    const headers = new HttpHeaders().set('content-type', 'application/json');

    var body = {
      email: user.email,
      password: user.password
    }

    return this.http.post<User>(this.baseURL + "api/user/CheckUser", body, { headers });

  }

  public registerUser(user: User): Observable<User> {
    const headers = new HttpHeaders().set('content-type', 'application/json');

    var body = {
      email: user.email,
      password: user.password,
      name: user.name,
      surname: user.surname
    }

    return this.http.post<User>(this.baseURL + "api/user", body, { headers });
  }

}
