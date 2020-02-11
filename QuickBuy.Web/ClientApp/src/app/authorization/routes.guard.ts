import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";

@Injectable({
  providedIn: 'root'
})
export class RoutesGuard implements CanActivate {

  constructor(private router:Router) {

  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {

    var authenticated = sessionStorage.getItem("authenticated-user");

    if (authenticated == "1") {
      // if authenticated user
      return true;
    }

    // if not authenticated user
    this.router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
    return false;

  }

}
