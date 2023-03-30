import { Component, OnDestroy, OnInit } from '@angular/core';
import { AccountService } from 'src/app/services/account.service';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent implements OnInit, OnDestroy{

/**
 *
 */
constructor(private service: AccountService) {
}
ngOnInit(): void {
 this.get();
 this.getById();
}
get(): void{
  this.service.get().subscribe(response=>{
    console.log(response);
  }, error=>{
    console.log(error)
  }, ()=>{
    console.log('Finished');
  })
}
getById(id:number=2): void{
  this.service.getById(id).subscribe(response=>{
    console.log(response);
  }, error=>{
    console.log(error)
  }, ()=>{
    console.log('Finished');
  })
}
ngOnDestroy(): void {
  
}

}
