import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoriesComponent } from './categories/categories.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { DetailsPostDialogComponent } from './post/details-post-dialog/details-post-dialog.component';
import { PostComponent } from './post/post.component';

const routes: Routes = [
  {path:'dashboard',component:DashboardComponent},
  {path:'post',component:PostComponent},
  {path:'categories',component:CategoriesComponent},
  {path:'details/:id', component:DetailsPostDialogComponent},


  {path:'', redirectTo:'/dashboard', pathMatch:'full'},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
