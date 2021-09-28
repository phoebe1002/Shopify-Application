import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddImageComponent } from './components/add-image/add-image.component';
import { SearchImageComponent } from './components/search-image/search-image.component';
import { AuthGuard } from '@auth0/auth0-angular';
import { HomeComponent } from './components/home/home.component';

const routes: Routes = [
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'addimage',
    component: AddImageComponent,
    canActivate: [AuthGuard]
  },
  {
    path: 'searchimage',
    component: SearchImageComponent,
    canActivate: [AuthGuard]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
