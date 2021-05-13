import { TestBed } from '@angular/core/testing';

import { VnexpressService } from './vnexpress.service';

describe('VnexpressService', () => {
  let service: VnexpressService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(VnexpressService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
