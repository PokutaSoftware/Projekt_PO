import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import {AppRoutingModule} from './app-routing.module';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { PartsComponent } from './parts/parts.component';
import { RepairComponent } from './repair/repair.component';
import { RservicesComponent } from './rservices/rservices.component';
import { AddPartComponent } from './parts/add-part/add-part.component';
import { RepairStatusComponent } from './repair/repair-status/repair-status.component';
import { ClientComponent } from './client/client.component';
import { AddRserviceComponent } from './rservices/add-rservice/add-rservice.component';
import { HomeComponent } from './home/home.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { PartListComponent } from './parts/part-list/part-list.component';
import { LoginComponent } from './login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    PartsComponent,
    RepairComponent,
    RservicesComponent,
    AddPartComponent,
    RepairStatusComponent,
    ClientComponent,
    AddRserviceComponent,
    HomeComponent,
    PageNotFoundComponent,
    PartListComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
