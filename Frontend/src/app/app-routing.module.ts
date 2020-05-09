import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {AppComponent} from './app.component';
import {PartsComponent} from './parts/parts.component';
import {AddPartComponent} from './parts/add-part/add-part.component';
import {RepairComponent} from './repair/repair.component';
import {RepairStatusComponent} from './repair/repair-status/repair-status.component';
import {ClientComponent} from './client/client.component';
import {RservicesComponent} from './rservices/rservices.component';
import {AddRserviceComponent} from './rservices/add-rservice/add-rservice.component';
import {HomeComponent} from './home/home.component';

const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'parts', component: PartsComponent, children: [
      { path: 'add', component: AddPartComponent }
    ] },
  { path: 'repair', component: RepairComponent, children: [
      { path: ':id', component: RepairStatusComponent }
    ] },
  { path: 'client', component: ClientComponent},
  { path: 'services', component: RservicesComponent, children: [
      {path: 'add', component: AddRserviceComponent}
    ] }
  ];

@NgModule({
  imports: [
    RouterModule.forRoot(appRoutes)
  ],
  exports: [RouterModule]
  })
export class AppRoutingModule {
}
