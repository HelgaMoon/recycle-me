import { NgModule } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';
import { MatCardModule, MatGridListModule, MatProgressSpinnerModule, MatToolbarModule } from '@angular/material';


@NgModule({
  declarations: [
  ],
  imports: [
    MatCardModule,
    MatGridListModule,
    MatToolbarModule,
    MatProgressSpinnerModule,
    FlexLayoutModule,
  ],
  providers: [],
  bootstrap: [],
  exports: [
    MatCardModule,
    MatGridListModule,
    MatToolbarModule,
    MatProgressSpinnerModule,
    FlexLayoutModule
  ]
})
export class AppMatControlModule { }
