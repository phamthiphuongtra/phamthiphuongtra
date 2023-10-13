import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { firstValueFrom } from 'rxjs';

@Component({
  selector: 'app-history-returns',
  templateUrl: './history-returns.component.html',
  styleUrls: ['./history-returns.component.css']
})
export class HistoryReturnsComponent {
  history: any = [];
  devices: any = [];
  

  constructor(private http:HttpClient, private router:Router){
    this.getData();
  }

  async getData() {
    let url = 'https://localhost:7109/api/Borrow';
    
    await firstValueFrom(this.http.get(url))
    .then((data: any) => {
      this.history = data;
    })
    .catch((e) => {
      console.log(e);    
    });
    this.checkDevices();
  }

  passDataToDetail(i: any){
    this.router.navigate(['detailed-history'], {
      state: {
        detailHistory: this.history[i]
      }
    });
  }

  checkDevices(){
    this.history.forEach((e: any) => {
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
