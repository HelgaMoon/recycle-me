import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { MaterialCardComponent } from './material-card.component';

describe('MaterialComponent', () => {
  let component: MaterialCardComponent;
  let fixture: ComponentFixture<MaterialCardComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [MaterialCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MaterialCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
