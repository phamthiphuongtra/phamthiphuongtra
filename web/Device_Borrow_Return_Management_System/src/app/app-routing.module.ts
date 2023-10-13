import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { BorrowComponent } from './components/borrow/borrow.component';
import { ListReturnComponent } from './components/list-return/list-return.component';
import { PerReturnComponent } from './components/per-return/per-return.component';
import { HistoryReturnsComponent } from './components/history-returns/history-returns.component';
import { DetailedHistoryComponent } from './components/detailed-history/detailed-history.component';
import { WeeklyShiftScheduleComponent } from './components/weekly-shift-schedule/weekly-shift-schedule.component';

const routes: Routes = [
  {path: "", component: HomeComponent},
  {path: "borrow", component:BorrowComponent},
  {path: "list-return", component:ListReturnComponent},
  {path: "per-return", component:PerReturnComponent},
  {path: "history-return", component:HistoryReturnsComponent},
  {path: "detailed-history", component:DetailedHistoryComponent},
  {path: "weekly-shift-schedule", component:WeeklyShiftScheduleComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
