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
import {PageNotFoundComponent} from './page-not-found/page-not-found.component';
import { LoginComponent } from './login/login.component';
import { HomepageComponent } from './homepage/homepage.component';

const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'parts', component: PartsComponent},
  { path: 'parts/add', component: AddPartComponent },
  { path: 'repair', component: RepairComponent, children: [
      { path: ':id', component: RepairStatusComponent }
    ] },
  { path: 'client', component: ClientComponent },
  { path: 'services', component: RservicesComponent },
  { path: 'services/add', component: AddRserviceComponent },
  { path: 'login', component: LoginComponent},
  {path: 'homepage', component:HomepageComponent},
  { path: '404', component: PageNotFoundComponent },
  { path: '**', redirectTo: '/404' }
  ];

@NgModule({
  imports: [
    RouterModule.forRoot(appRoutes)
  ],
  exports: [RouterModule]
  })
export class AppRoutingModule {
}
