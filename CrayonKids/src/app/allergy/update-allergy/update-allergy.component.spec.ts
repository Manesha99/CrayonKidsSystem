import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateAllergyComponent } from './update-allergy.component';

describe('UpdateAllergyComponent', () => {
  let component: UpdateAllergyComponent;
  let fixture: ComponentFixture<UpdateAllergyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateAllergyComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdateAllergyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
