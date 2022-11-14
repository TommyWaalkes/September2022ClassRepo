import { TestBed } from '@angular/core/testing';

import { RandomNumberGenerationService } from './random-number-generation.service';

describe('RandomNumberGenerationService', () => {
  let service: RandomNumberGenerationService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RandomNumberGenerationService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
