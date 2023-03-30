import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router'
import { WeatherInfoComponent } from './weather-info/weather-info.component';
import { RegisterUserComponent } from './register-user/register-user.component';

const routes: Routes = [
  { 
    path: 'weatherinfo', 
    component: WeatherInfoComponent 
  },
  {
    path: 'register',
    component: RegisterUserComponent
  },
  {path: 'account', loadChildren:()=> import('../app/account/account.module').then(x=>x.AccountModule)}
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule, RouterModule.forRoot(routes)
  ],
  exports: [ RouterModule ]
})
export class AppRoutingModule { }
