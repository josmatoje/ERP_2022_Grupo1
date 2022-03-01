import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PruebaLuisComponent } from './prueba-luis.component';

describe('PruebaLuisComponent', () => {
  let component: PruebaLuisComponent;
  let fixture: ComponentFixture<PruebaLuisComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PruebaLuisComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PruebaLuisComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
