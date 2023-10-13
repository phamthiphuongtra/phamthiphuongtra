import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HistoryReturnsComponent } from './history-returns.component';

describe('HistoryReturnsComponent', () => {
  let component: HistoryReturnsComponent;
  let fixture: ComponentFixture<HistoryReturnsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [HistoryReturnsComponent]
    });
    fixture = TestBed.createComponent(HistoryReturnsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
