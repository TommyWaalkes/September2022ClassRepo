import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarlistComponent } from './carlist.component';

describe('CarlistComponent', () => {
  let component: CarlistComponent;
  let fixture: ComponentFixture<CarlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CarlistComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CarlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
