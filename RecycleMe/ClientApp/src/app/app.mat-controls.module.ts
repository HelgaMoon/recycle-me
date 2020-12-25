import { NgModule } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';
import { MatButtonModule, MatCardModule, MatDividerModule, MatGridListModule, MatIconModule, MatProgressSpinnerModule, MatToolbarModule } from '@angular/material';


@NgModule({
  declarations: [
  ],
  imports: [
    MatCardModule,
    MatGridListModule,
    MatToolbarModule,
    MatProgressSpinnerModule,
    MatDividerModule,
    MatButtonModule,
    MatIconModule,
    FlexLayoutModule,
  ],
  providers: [],
  bootstrap: [],
  exports: [
    MatCardModule,
    MatGridListModule,
    MatToolbarModule,
    MatProgressSpinnerModule,
    MatDividerModule,
    MatButtonModule,
    MatIconModule,
    FlexLayoutModule,
  ]
})
export class AppMatControlModule { }
