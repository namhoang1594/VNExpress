import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailsPostDialogComponent } from './details-post-dialog.component';

describe('DetailsPostDialogComponent', () => {
  let component: DetailsPostDialogComponent;
  let fixture: ComponentFixture<DetailsPostDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailsPostDialogComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetailsPostDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
