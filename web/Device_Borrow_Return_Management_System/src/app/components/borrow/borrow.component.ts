import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { firstValueFrom } from 'rxjs';

@Component({
  selector: 'app-borrow',
  templateUrl: './borrow.component.html',
  styleUrls: ['./borrow.component.css']
})

export class BorrowComponent {
  name: string | undefined;
  classBorrow: string | undefined;
  MSSVBorrow: string | undefined;
  phone: string | undefined;
  borrowDate: string | undefined;
  returnDate: string | undefined;
  confirmBorrowed: string | undefined;
  returnConfirm: string | undefined;
  pen: boolean | undefined;
  pen1: string | undefined;
  wipes: boolean | undefined;
  wipes1: string | undefined;
  chalk: boolean | undefined;
  chalk1: string | undefined;
  projector: boolean | undefined;
  projector1: string | undefined;
  connector: boolean | undefined;
  connector1: string | undefined;
  mic: boolean | undefined;
  mic1: string | undefined;
  powerOutlet: boolean | undefined;
  powerOutlet1: string | undefined;
  bottledWater: boolean | undefined;
  bottledWater1: string | undefined;
  room: string | undefined;
  amount: number | undefined;

  constructor(private http:HttpClient){}

  convertData(){
    if(this.pen){
      this.pen1 = 'Yes';
    }else{
      this.pen1 = 'No';
    }
    if(this.wipes){
      this.wipes1 = 'Yes';
    }else{
      this.wipes1 = 'No';
    }
    if(this.chalk){
      this.chalk1 = 'Yes';
    }else{
      this.chalk1 = 'No';
    }
    if(this.projector){
      this.projector1 = 'Yes';
    }else{
      this.projector1 = 'No';
    }
    if(this.connector){
      this.connector1 = 'Yes';
    }else{
      this.connector1 = 'No';
    }
    if(this.powerOutlet){
      this.powerOutlet1 = 'Yes';
    }else{
      this.powerOutlet1 = 'No';
    }
    if(this.bottledWater){
      this.bottledWater1 = 'Yes';
    }else{
      this.bottledWater1 = 'No';
    }
    if(this.mic){
      this.mic1 = 'Yes';
    }else{
      this.mic1 = 'No';
    }
  }
  
  async postData(){
    this.convertData();
    let url = 'https://localhost:7109/api/Borrow';
    
    await firstValueFrom(this.http.post(url, {
      name: this.name,
      class: this.classBorrow,
      phone: this.phone,
      borrowedDate: this.borrowDate,
      returnDate: this.borrowDate,
      confirmBorrowed: 'Yes',
      returnConfirm: 'null',
      pen: this.pen1,
      chalk: this.chalk1,
      projector: this.projector1,
      connector: this.connector1,
      mic: this.mic1,
      powerOutlet: this.powerOutlet1,
      bottledWater: this.bottledWater1,
      status: '1',
      studentCode: this.MSSVBorrow,
      wipes: this.wipes1,
      room: this.room
    }))
    .then((data: any) => {
      alert('Done.');
      window.location.reload();
    }).catch((e) => alert(e));
  }
}
