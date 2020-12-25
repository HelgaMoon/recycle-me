import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MaterialTypeCardComponent } from './material-type-card.component';

describe('MaterialTypeComponent', () => {
  let component: MaterialTypeCardComponent;
  let fixture: ComponentFixture<MaterialTypeCardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [MaterialTypeCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MaterialTypeCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
