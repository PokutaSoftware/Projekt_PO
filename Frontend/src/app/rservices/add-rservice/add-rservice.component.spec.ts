import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddRserviceComponent } from './add-rservice.component';

describe('AddRserviceComponent', () => {
  let component: AddRserviceComponent;
  let fixture: ComponentFixture<AddRserviceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddRserviceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddRserviceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
