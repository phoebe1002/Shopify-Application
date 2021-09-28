import { Component, OnInit, Inject } from '@angular/core';
import { AuthService } from '@auth0/auth0-angular';
import { DOCUMENT } from '@angular/common';
import { ImageService } from 'src/app/services/imageApi.service';
import { user } from 'src/app/models/user';
import { Router } from '@angular/router';
@Component({
  selector: 'app-auth-button',
  template: `
  <ng-container *ngIf="auth.isAuthenticated$ | async; else loggedOut">
    <button (click)="auth.logout({ returnTo: document.location.origin })">
      Log out
    </button>
  </ng-container>

  <ng-template #loggedOut>
    <button (click)="auth.loginWithRedirect()">Log in</button>
  </ng-template>
`,

})
export class AuthButtonComponent implements OnInit {

  constructor(@Inject(DOCUMENT) public document: Document, public auth: AuthService, private imageService: ImageService, private router : Router) {}

  ngOnInit(): void {
    console.log(window.sessionStorage);
    if (this.auth.user$){
      this.auth.user$.subscribe(
        (result) => {
          console.log(result?.email);
          if (result?.email)
            this.imageService.GetUserByEmail(result?.email)
            .then((user) => {
              if(!user) {
                //save new user to db
                const newUser: user = {
                  id: 0,
                  email: result.email,
                  images: null
                }
                this.imageService.AddUser(newUser);
              } else {
                //direct to searchimages
                this.goToSearchImage(user.id);
              }
            })
        }
      )
    }
  }

  goToSearchImage(userId : number) {
    this.router.navigate(["searchimage"], {queryParams: {userId: userId}});
  }

}
