import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http'

import { AppComponent } from './app.component';
import { WeatherInfoComponent } from './weather-info/weather-info.component';
import { AppRoutingModule } from './app-routing.module';
import { RegisterUserComponent } from './register-user/register-user.component';

@NgModule({
  declarations: [
    AppComponent,
    WeatherInfoComponent,
    RegisterUserComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
