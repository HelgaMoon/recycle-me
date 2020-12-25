import { NgModule } from '@angular/core';
import { MatCardModule, MatGridListModule, MatProgressSpinnerModule, MatToolbarModule } from '@angular/material';


@NgModule({
  declarations: [
  ],
  imports: [
    MatCardModule,
    MatGridListModule,
    MatToolbarModule,
    MatProgressSpinnerModule
  ],
  providers: [],
  bootstrap: [],
  exports: [
    MatCardModule,
    MatGridListModule,
    MatToolbarModule,
    MatProgressSpinnerModule
  ]
})
export class AppMatControlModule { }
