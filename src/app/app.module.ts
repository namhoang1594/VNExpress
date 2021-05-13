import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PostComponent } from './post/post.component';
import { CategoriesComponent } from './categories/categories.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { VnexpressService } from './vnexpress.service';
import { CreatePostDialogComponent } from './post/create-post-dialog/create-post-dialog.component';
import { EditPostDialogComponent } from './post/edit-post-dialog/edit-post-dialog.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { DetailsPostDialogComponent } from './post/details-post-dialog/details-post-dialog.component';
import { CreateCategoriesDialogComponent } from './categories/create-categories-dialog/create-categories-dialog.component';
import { EditCategoriesDialogComponent } from './categories/edit-categories-dialog/edit-categories-dialog.component';

@NgModule({
  declarations: [
    AppComponent,
    PostComponent,
    CategoriesComponent,
    CreatePostDialogComponent,
    EditPostDialogComponent,
    DashboardComponent,
    DetailsPostDialogComponent,
    CreateCategoriesDialogComponent,
    EditCategoriesDialogComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
  ],
  providers: [VnexpressService],
  bootstrap: [AppComponent]
})
export class AppModule { }
