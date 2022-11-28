import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductMenuComponent } from './product-menu.component';

describe('ProductMenuComponent', () => {
  let component: ProductMenuComponent;
  let fixture: ComponentFixture<ProductMenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductMenuComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProductMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
