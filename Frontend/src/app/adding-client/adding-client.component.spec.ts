import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddingClientComponent } from './adding-client.component';

describe('AddingClientComponent', () => {
  let component: AddingClientComponent;
  let fixture: ComponentFixture<AddingClientComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddingClientComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddingClientComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
