import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {

  constructor(private router:Router) {
  }

  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  public userLoggedIn(): boolean {
    return sessionStorage.getItem("authenticated-user") == "1";
  }

  logout() {
    sessionStorage.setItem("authenticated-user", "0");
    this.router.navigate(['/']);
  }
}
