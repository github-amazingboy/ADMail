import { TestBed } from '@angular/core/testing';
import { ADMailService } from './services/a-dMail.service';
import { RestService } from '@abp/ng.core';

describe('ADMailService', () => {
  let service: ADMailService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(ADMailService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
