import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { Ng2TableModule } from 'ng2-table/ng2-table';
import { PaginationModule } from 'ngx-bootstrap/pagination'

import { AppComponent } from './app.component';

import {DataTable} from './component/datatable.component'

@NgModule({
  declarations: [
    AppComponent,
    DataTable
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    Ng2TableModule,
    PaginationModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
