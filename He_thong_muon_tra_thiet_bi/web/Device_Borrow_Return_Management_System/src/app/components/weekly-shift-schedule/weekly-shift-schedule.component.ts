import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { firstValueFrom } from 'rxjs';

@Component({
  selector: 'app-weekly-shift-schedule',
  templateUrl: './weekly-shift-schedule.component.html',
  styleUrls: ['./weekly-shift-schedule.component.css']
})
export class WeeklyShiftScheduleComponent {
  getShiftSchedule: any | undefined;
  shiftSchedule: { [key: string]: string } = {};
  name: string = '';
  phone: string = '';
  day: string = '';
  url: string = 'https://localhost:7109/api/Staff/';

  ngOnInit(): void {
    this.getData();
  }

  constructor(private http:HttpClient){}

  async getData(){
    await firstValueFrom(this.http.get(this.url))
    .then((data: any) => {
      this.getShiftSchedule = data;
      console.log(this.getShiftSchedule);
    })
    .catch((e: any) => console.log(e));
    
    this.getNameByDate('2');
  }

  async updateData(){
    await firstValueFrom(this.http.get('https://localhost:7109/name/' + this.day))
    .then((data:any)=>{
      this.shiftSchedule['id'] = data[0].id;
      this.shiftSchedule['name'] = data[0].name;
      this.shiftSchedule['phone'] = data[0].phone;
      this.shiftSchedule['date'] = data[0].date;
      this.shiftSchedule['createdDate'] = data[0].createdDate;
      console.log(this.shiftSchedule['name']);
      
    })
    .catch((e: any)=>alert(e));

    await firstValueFrom(this.http.put(this.url + this.shiftSchedule['id'], {
      id: this.shiftSchedule['id'],
      name: this.name,
      phone: this.phone || this.shiftSchedule['phone'],
      date: this.shiftSchedule['date'],
      createdDate: this.shiftSchedule['createdDate'],
      updatedDate: Date.now
    }))
    .then((data: any) => window.location.reload())
    .catch((e: any)=>console.log(e));
  }

  getNameByDate(date: string): string {
    if(this.getShiftSchedule != undefined){
      const matchingItem = this.getShiftSchedule.find((item: any) => item.date === date);
      return matchingItem ? matchingItem.name : '';
    }
    return '';
  }
}
