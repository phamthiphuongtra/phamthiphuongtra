import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WeeklyShiftScheduleComponent } from './weekly-shift-schedule.component';

describe('WeeklyShiftScheduleComponent', () => {
  let component: WeeklyShiftScheduleComponent;
  let fixture: ComponentFixture<WeeklyShiftScheduleComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [WeeklyShiftScheduleComponent]
    });
    fixture = TestBed.createComponent(WeeklyShiftScheduleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
