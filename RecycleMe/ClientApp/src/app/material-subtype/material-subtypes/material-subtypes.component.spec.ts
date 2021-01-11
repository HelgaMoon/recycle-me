import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { MaterialSubTypesComponent } from './material-subtypes.component';

describe('MaterialSubTypesComponent', () => {
  let component: MaterialSubTypesComponent;
  let fixture: ComponentFixture<MaterialSubTypesComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ MaterialSubTypesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MaterialSubTypesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
