import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { User } from "../../model/user";

@Injectable({
  providedIn: "root"
})
export class UserService {

  private baseURL: string;

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

}
