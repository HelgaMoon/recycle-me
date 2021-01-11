import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { MaterialSubTypeComponent } from './material-subtype.component';

describe('MaterialTypeComponent', () => {
  let component: MaterialSubTypeComponent;
  let fixture: ComponentFixture<MaterialSubTypeComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ MaterialSubTypeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MaterialSubTypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
