import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEmergencyComponent } from './add-emergency.component';

describe('AddEmergencyComponent', () => {
  let component: AddEmergencyComponent;
  let fixture: ComponentFixture<AddEmergencyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddEmergencyComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddEmergencyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
