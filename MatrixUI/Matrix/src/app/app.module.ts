import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import{MaterialModule} from '../app/modules/modulematerial/modulematerial.module';
import { NavigationComponent } from './components/navigation/navigation.component';
import { HomeComponent } from './components/home/home.component';
import { ContactComponent } from './components/contact/contact.component';
import { PortfolioComponent } from './components/portfolio/portfolio.component';
import { ClientsComponent } from './components/clients/clients.component';
import { ApiComponent } from './components/api/api.component';
import { BlogComponent } from './components/blog/blog.component';
import {FlexLayoutModule} from '@angular/flex-layout';
import { RoutingModule } from './routing/routing.module';

@NgModule({
  declarations: [
    AppComponent,
    NavigationComponent,
    HomeComponent,
    ContactComponent,
    PortfolioComponent,
    ClientsComponent,
    ApiComponent,
    BlogComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MaterialModule,
    FlexLayoutModule,
    RoutingModule
  ],

  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
