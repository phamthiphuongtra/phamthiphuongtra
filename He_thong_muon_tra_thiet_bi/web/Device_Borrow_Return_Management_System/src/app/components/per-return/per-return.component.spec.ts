import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PerReturnComponent } from './per-return.component';

describe('PerReturnComponent', () => {
  let component: PerReturnComponent;
  let fixture: ComponentFixture<PerReturnComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PerReturnComponent]
    });
    fixture = TestBed.createComponent(PerReturnComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
