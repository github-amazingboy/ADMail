import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { ADMailComponent } from './components/a-dMail.component';
import { ADMailService } from '@a-dMail';
import { of } from 'rxjs';

describe('ADMailComponent', () => {
  let component: ADMailComponent;
  let fixture: ComponentFixture<ADMailComponent>;
  const mockADMailService = jasmine.createSpyObj('ADMailService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ADMailComponent],
      providers: [
        {
          provide: ADMailService,
          useValue: mockADMailService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ADMailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
