import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailedHistoryComponent } from './detailed-history.component';

describe('DetailedHistoryComponent', () => {
  let component: DetailedHistoryComponent;
  let fixture: ComponentFixture<DetailedHistoryComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DetailedHistoryComponent]
    });
    fixture = TestBed.createComponent(DetailedHistoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
