import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RepairStatusEmployeeComponent } from './repair-status-employee.component';

describe('RepairStatusEmployeeComponent', () => {
  let component: RepairStatusEmployeeComponent;
  let fixture: ComponentFixture<RepairStatusEmployeeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RepairStatusEmployeeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RepairStatusEmployeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
