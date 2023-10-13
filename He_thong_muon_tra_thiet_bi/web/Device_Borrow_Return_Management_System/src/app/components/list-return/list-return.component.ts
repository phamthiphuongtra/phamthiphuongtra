import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom, lastValueFrom } from 'rxjs';

@Component({
  selector: 'app-list-return',
  templateUrl: './list-return.component.html',
  styleUrls: ['./list-return.component.css']
})
export class ListReturnComponent {
  listReturn: any = [];
  completeDate: Date;
  localCompleteDate: string;
  devices: any = [];

  constructor(private http:HttpClient){
    this.getData();
    this.completeDate = new Date();
    this.localCompleteDate = this.completeDate.toISOString();
  }

  async getData() {
    let url = 'https://localhost:7109/api/Borrow';
    
    await firstValueFrom(this.http.get(url))
    .then((data: any) => {
      data.forEach((e: any) => {
        if(e.status == "1"){
          this.listReturn.push(e);
          console.log(this.listReturn);
        }
      });
    })
    .catch((e) => {
      alert(e);
    });
    
    this.checkDevices();
  }

  async updateData(item: any){
    let url = 'https://localhost:7109/api/Borrow/' + item.id.toString();
    
    await firstValueFrom(this.http.put(url, {
      id: item.id,
      name: item.name,
      class: item.class,
      phone: item.phone,
      borrowedDate: item.borrowDate,
      returnDate: this.localCompleteDate,
      confirmBorrowed: 'Yes',
      returnConfirm: 'Yes',
      pen: item.pen,
      chalk: item.chalk,
      projector: item.projector,
      connector: item.connector,
      mic: item.mic,
      powerOutlet: item.powerOutlet,
      bottledWater: item.bottledWater,
      status: '0',
      studentCode: item.studentCode,
      wipes: item.wipes,
      room: item.room
    }))
    .then((data: any) => {
      window.location.reload();
    })
    .catch((e) => {
      window.location.reload();
    })
  }

  customDate(){
    let date = new Date();
    var day = date.getDay();
    var month = date.getMonth();
    var year = date.getFullYear();
    var second = date.getSeconds();
    var minutes = date.getMinutes();
    var hours = date.getHours();
    var current_date = year+'-'+month+'-'+day+'T'+hours+':'+minutes+':'+second;
    return current_date;
  }

  checkDevices(){
    this.listReturn.forEach((e: any) => {
      for (let index in e) {
        if (index != 'confirmBorrowed' && index != 'returnConfirm') {
          switch (e[index]) {
            case 'Yes':
              this.devices.push(index);
              break;
            default:
              break;
          }
        }
      }
    });
  }
}
