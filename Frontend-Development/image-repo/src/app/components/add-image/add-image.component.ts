import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { image } from 'src/app/models/image';
import { ImageService } from 'src/app/services/imageApi.service';
import { FormBuilder, FormGroup, FormArray, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-image',
  templateUrl: './add-image.component.html',
  styleUrls: ['./add-image.component.css']
})
export class AddImageComponent implements OnInit {
  userId!: number;
  newImage: image = {
    id: 0,
    name: '',
    imageURL: '',
    isShared: false,
    userId: undefined,
  }
  
  constructor(private imageService: ImageService, private router: Router, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.activatedRoute.queryParams.subscribe(
      params => {
        this.userId = params.userId;
      }
    )
  }

  onSubmit(): void {
    console.log(this.newImage);
    this.newImage.userId = this.userId;
    this.imageService.AddImage(this.newImage)
    .then(result => {
      this.goToAll();
    })
  }

  onCheckBoxChangeForIsShared(e: any) {
    if(e.target.checked) this.newImage.isShared = true;
  }

  goToAll() {
    this.router.navigate(["searchimage"], {queryParams: {userId : this.userId}});
  }
}
