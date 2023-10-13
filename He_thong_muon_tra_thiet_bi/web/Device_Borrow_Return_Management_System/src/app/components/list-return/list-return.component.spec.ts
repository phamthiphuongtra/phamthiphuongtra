import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListReturnComponent } from './list-return.component';

describe('ListReturnComponent', () => {
  let component: ListReturnComponent;
  let fixture: ComponentFixture<ListReturnComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ListReturnComponent]
    });
    fixture = TestBed.createComponent(ListReturnComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
