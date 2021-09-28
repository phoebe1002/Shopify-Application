import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddImageComponent } from './components/add-image/add-image.component';
import { SearchImageComponent } from './components/search-image/search-image.component';
import { AuthModule } from '@auth0/auth0-angular';
import { AuthButtonComponent } from './components/auth-button/auth-button.component';
import { HeaderComponent } from './components/header/header.component';
import { HomeComponent } from './components/home/home.component';

@NgModule({
  declarations: [
    AppComponent,
    AddImageComponent,
    SearchImageComponent,
    AuthButtonComponent,
    HeaderComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    AuthModule.forRoot({
      domain: 'dev-m543x1k7.us.auth0.com',
      clientId: 'USoMH6AyveiTEA9yZUAfwnuTrc6ErodX'
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
