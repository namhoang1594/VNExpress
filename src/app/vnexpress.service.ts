import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Post } from './post/post.models';


const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8'})
};
const apiUrl = 'https://5f0c7a5911b7f60016055e6c.mockapi.io/Api/ahihi';
@Injectable({
  providedIn: 'root'
})
export class VnexpressService {
  // myAppUrl: string;
  // myApiUrl: string;

  constructor(private httpClient: HttpClient) { 
    // this.myAppUrl = environment.appUrl;
    // this.myApiUrl = 'api/post/';
    
  }

  getAllPost(): Observable<Post[]> {
    // return this.http.get<Post[]>(this.myAppUrl + this.myApiUrl).pipe();
    return this.httpClient.get<Post[]>(apiUrl).pipe()
  }

  getPostById(id: number): Observable<Post> {
    // const url = `${this.myAppUrl + this.myApiUrl}/${id}`;
    const url = `${apiUrl}/${id}`;
    return this.httpClient.get<Post>(url).pipe();
  }

  addnewPost(addnewPost: Post): Observable<Post> {
    return this.httpClient.post<Post>(apiUrl, addnewPost, httpOptions).pipe();
  }

  // updatePost(updatePost: Post): Observable<Post> {
  //   const url = `${this.myAppUrl + this.myApiUrl}/${updatePost.id}`;
  //   return this.http.put<Post>(url, updatePost, httpOptions).pipe();
  // }

  // deletePost(PostId: number): Observable<Post> {
  //   const url = `${this.myAppUrl + this.myApiUrl}/${PostId}`;
  //   return this.http.delete<Post>(url, httpOptions).pipe();
  // }
}
