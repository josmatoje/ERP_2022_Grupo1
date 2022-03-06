import { TestBed } from '@angular/core/testing';

import { OrderLineConNombreService } from './orderLineConNombre/order-line-con-nombre.service';

describe('OrderLineConNombreService', () => {
  let service: OrderLineConNombreService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(OrderLineConNombreService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
