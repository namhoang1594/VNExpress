import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateCategoriesDialogComponent } from './create-categories-dialog.component';

describe('CreateCategoriesDialogComponent', () => {
  let component: CreateCategoriesDialogComponent;
  let fixture: ComponentFixture<CreateCategoriesDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateCategoriesDialogComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateCategoriesDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
