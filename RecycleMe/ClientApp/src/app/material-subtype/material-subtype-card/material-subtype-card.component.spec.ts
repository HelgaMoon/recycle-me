import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { MaterialSubTypeCardComponent } from './material-subtype-card.component';

describe('MaterialSubTypeComponent', () => {
  let component: MaterialSubTypeCardComponent;
  let fixture: ComponentFixture<MaterialSubTypeCardComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [MaterialSubTypeCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MaterialSubTypeCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
