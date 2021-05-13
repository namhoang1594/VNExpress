import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { VnexpressService } from 'src/app/vnexpress.service';
import { Post } from '../post.models';

@Component({
  selector: 'app-create-post-dialog',
  templateUrl: './create-post-dialog.component.html',
  styleUrls: ['./create-post-dialog.component.css']
})
export class CreatePostDialogComponent implements OnInit {
  posts: Post[] = [];
  createForm;

  constructor(
    private vnexpressService: VnexpressService,
    private route: ActivatedRoute,
    private router: Router,
    private formBuilder: FormBuilder
  ) { 
    this.createForm = this.formBuilder.group({
      name: ['', Validators.required],
      price: ['', Validators.required],
      img: ['']
    });
  }

  ngOnInit(): void {
    this.vnexpressService.get().subscribe((data: Position[]) => {
      this.positions = data;
    });
  }

}
