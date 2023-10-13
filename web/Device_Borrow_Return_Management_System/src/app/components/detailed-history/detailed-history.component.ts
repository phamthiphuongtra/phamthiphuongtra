import { Component } from '@angular/core';

@Component({
  selector: 'app-detailed-history',
  templateUrl: './detailed-history.component.html',
  styleUrls: ['./detailed-history.component.css']
})
export class DetailedHistoryComponent {
  detail: any;
  devices: any = [];

  ngOnInit(): void {
    this.detail = history.state.detailHistory;
    this.checkDevices();
  }

  checkDevices(){
    for (let index in this.detail) {
      if (index != 'confirmBorrowed' && index != 'returnConfirm') {
        switch (this.detail[index]) {
          case 'Yes':
            this.devices.push(index);
            break;
          default:
            break;
        }
      }
    }
  }
}
