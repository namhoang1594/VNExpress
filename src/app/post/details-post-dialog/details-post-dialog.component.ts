import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { VnexpressService } from 'src/app/vnexpress.service';
import { Post } from '../post.models';

@Component({
  selector: 'app-details-post-dialog',
  templateUrl: './details-post-dialog.component.html',
  styleUrls: ['./details-post-dialog.component.css']
})
export class DetailsPostDialogComponent implements OnInit {
  // posts: Observable<Post>;
  posts = new Post;
  id: number;

  constructor(
    private vnexpressService: VnexpressService, 
    private route: ActivatedRoute
    ) { 
      const idParam = 'id';
    if (this.route.snapshot.params[idParam]) {
      this.id = this.route.snapshot.params[idParam];
    }
    }

  ngOnInit() {
    this.getPostById();
  }

  getPostById(): void {
    //  this.posts = this.vnexpressService.getPostById(this.id);
    this.vnexpressService.getPostById(this.id).subscribe(post => this.posts = post);
  }

}
