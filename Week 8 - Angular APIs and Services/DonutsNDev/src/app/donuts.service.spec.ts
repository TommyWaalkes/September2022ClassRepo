import { TestBed } from '@angular/core/testing';

import { DonutsService } from './donuts.service';

describe('DonutsService', () => {
  let service: DonutsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DonutsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
