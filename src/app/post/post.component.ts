import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { VnexpressService } from '../vnexpress.service';
import { Post } from './post.models';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})
export class PostComponent implements OnInit {
  posts: Post[] = [];

  constructor(
    private route: ActivatedRoute,
    private vnexpressService: VnexpressService
  ) { }

  ngOnInit() {
    this.getAllPost();
  }

  getAllPost(): void {
    this.vnexpressService.getAllPost().subscribe(post => this.posts = post);
  }

  // deletePost(PostId: number): void {
  //   const ask = confirm('Do you want to delete this post?');
  //   if(ask) {
  //     this.vnexpressService.deletePost(PostId).subscribe(_ => {
  //       this.posts = this.posts.filter(eachPost => eachPost.id !== PostId);
  //     });
  //   }
  // }
}

