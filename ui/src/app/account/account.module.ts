import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AccountRoutingModule } from './account-routing.module';
import { UserListComponent } from './user-list/user-list.component';


@NgModule({
  declarations: [
    UserListComponent
  ],
  imports: [
    CommonModule,
    AccountRoutingModule
  ]
})
export class AccountModule { }
