import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MovieDisplayComponent } from './movie-display.component';

describe('MovieDisplayComponent', () => {
  let component: MovieDisplayComponent;
  let fixture: ComponentFixture<MovieDisplayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MovieDisplayComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MovieDisplayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
