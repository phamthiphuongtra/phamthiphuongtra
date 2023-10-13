import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { HeaderComponent } from './components/header/header.component';
import { MenuComponent } from './components/menu/menu.component';
import { BorrowComponent } from './components/borrow/borrow.component';
import { ListReturnComponent } from './components/list-return/list-return.component';
import { PerReturnComponent } from './components/per-return/per-return.component';
import { HistoryReturnsComponent } from './components/history-returns/history-returns.component';
import { DetailedHistoryComponent } from './components/detailed-history/detailed-history.component';
import { WeeklyShiftScheduleComponent } from './components/weekly-shift-schedule/weekly-shift-schedule.component';
import { HttpClientModule } from '@angular/common/http'; 
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    MenuComponent,
    BorrowComponent,
    ListReturnComponent,
    PerReturnComponent,
    HistoryReturnsComponent,
    DetailedHistoryComponent,
    WeeklyShiftScheduleComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
