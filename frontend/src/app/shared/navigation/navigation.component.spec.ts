import { ComponentFixture, TestBed } from '@angular/core/testing';
import { MaterialModule } from '../../core/material/material.module';

import { NavigationComponent } from './navigation.component';

describe('NavigationComponent', () => {
  let component: NavigationComponent;
  let fixture: ComponentFixture<NavigationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MaterialModule],
      declarations: [ NavigationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NavigationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    component.appTitle = 'test app';
    expect(component).toBeTruthy();
    expect(component.appTitle).toEqual('test app');
  });
});
