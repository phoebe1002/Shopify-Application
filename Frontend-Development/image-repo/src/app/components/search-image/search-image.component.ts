import { Component, OnInit } from '@angular/core';
import { image } from 'src/app/models/image';
import { ImageService } from 'src/app/services/imageApi.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-search-image',
  templateUrl: './search-image.component.html',
  styleUrls: ['./search-image.component.css']
})
export class SearchImageComponent implements OnInit {
  images: image[] = [];
  allImages: image[] = [];
  userId!: number;

  private _filterByLetters!: string;
  public get fillterbyLetters(): string {
    return this._filterByLetters;
  }
  public set filterByLetters(value : string) {
    this._filterByLetters = value;
    this.images = value ? this.allImages.filter((image) => image.name.toLowerCase().indexOf(value) !== -1) : this.allImages;
  }

  constructor(private imageServe: ImageService, private router: Router, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.activatedRoute.queryParams.subscribe(
      params => {
        this.userId = params.userId;
      }
    )
    this.imageServe.GetAllVisableImagesByUser(this.userId).then(
      result => {
        this.images = result;
        this.allImages = result;
      }
    )
  }
  
  GoToAdd() {
    this.router.navigate(['addimage'], {queryParams: {userId: this.userId}});
  }
}
