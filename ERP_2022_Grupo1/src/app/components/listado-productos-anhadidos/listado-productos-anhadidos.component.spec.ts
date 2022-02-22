import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListadoProductosAnhadidosComponent } from './listado-productos-anhadidos.component';

describe('ListadoProductosAnhadidosComponent', () => {
  let component: ListadoProductosAnhadidosComponent;
  let fixture: ComponentFixture<ListadoProductosAnhadidosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListadoProductosAnhadidosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListadoProductosAnhadidosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
