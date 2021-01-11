import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { HomeComponent } from './home/home.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { MaterialTypeCardComponent } from './material-type/material-type-card/material-type-card.component';
import { MaterialTypesComponent } from './material-type/material-types/material-types.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialTypeComponent } from './material-type/material-type/material-type.component';
import { FooterComponent } from './footer/footer.component';
import { AppMatControlModule } from './app.mat-controls.module';
import { MaterialSubTypeCardComponent } from './material-subtype/material-subtype-card/material-subtype-card.component';
import { MaterialSubTypeComponent } from './material-subtype/material-subtype/material-subtype.component';
import { MaterialSubTypesComponent } from './material-subtype/material-subtypes/material-subtypes.component';
import { MaterialCardComponent } from './material/material-card/material-card.component';
import { MaterialComponent } from './material/material/material.component';
import { MaterialsComponent } from './material/materials/materials.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    FetchDataComponent,
    MaterialTypeCardComponent,
    MaterialTypeComponent,
    MaterialTypesComponent,
    MaterialSubTypeCardComponent,
    MaterialSubTypeComponent,
    MaterialSubTypesComponent,
    MaterialCardComponent,
    MaterialComponent,
    MaterialsComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AppMatControlModule,
    RouterModule.forRoot([
    { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'materialtype/:id', component: MaterialTypeComponent },
      { path: 'materialsubtype/:id', component: MaterialSubTypeComponent },
      { path: 'material/:id', component: MaterialComponent },
], { relativeLinkResolution: 'legacy' }),
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
